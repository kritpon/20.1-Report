Public Class frmCSreport
    'Dim strCScode As String = selCS
    Sub formatGrid1()

        lsvDetail.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("รหัสลูกค้า", 2, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("รายชื่อลูกค้า", 250, HorizontalAlignment.Left)


        'lsvDetail.Columns.Add("กำไรปี-ก่อน", 120, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)

        'lsvDetail.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("Targetขาย-รวม", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ยอดขายรวม", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("วันที่ขายล่าสุด", 180, HorizontalAlignment.Right)

        lsvDetail.View = View.Details
        lsvDetail.GridLines = True
        'chkCol = True

    End Sub
    Private Sub frmCSreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbCSname.Text = dbTools.getCSName(selCS)
        lbCScode.Text = selCS
        Call formatGrid1()
        Call showData()
    End Sub
    Sub showData()
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim chkRow As Integer = 0
        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim strCScode As String = ""

        strCScode = lbCScode.Text
        txtSQL = "Select Ar_Cus_ID,Ar_Name,Ar_LastSales_Date,"
        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_Amt,0))as sumTrh_AmtNow,"
        txtSQL = txtSQL & "Sum(isnull(Ar_Sales_Target,0))as sumTarget "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join  "
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,sum(Trh_Amt)as Trh_Amt,"
        txtSQL = txtSQL & "sum(Trh_Amt-Trh_Cost_Amt)as Profit "
        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        txtSQL = txtSQL & "Group by Trh_Cus"
        txtSQL = txtSQL & " ) TrHNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "

        txtSQL = txtSQL & "Where   Ar_CS='" & strCScode & "' "
        txtSQL = txtSQL & " group by  AR_CUS_ID,Ar_Name,Ar_LastSales_Date "

        If optOrdTarget.Checked = True Then
            txtSQL = txtSQL & "order by Sum(isnull(Ar_Sales_Target,0)) desc  "
        ElseIf optOrdLastDate.Checked = True Then
            txtSQL = txtSQL & "order by Ar_LastSales_Date desc  "
        ElseIf optOrdSumSales.Checked = True Then
            txtSQL = txtSQL & "order by sum(isnull(TrHnow.Trh_Amt,0)) desc  "

        End If


        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")

        lsvDetail.Clear()
        formatGrid1()

        For i = 0 To subDS.Tables("csShow").Rows.Count - 1

            Dim intCountAR As Integer = 0
            Dim intItem As Integer = 0
            Dim strCusCode As String = ""
            Dim strCusName As String = ""
            Dim strLastSales As String = ""
            Dim dblTargetYear As Double = 0

            Dim dblProfitAfter As Double = 0
            Dim dblProfitNow As Double = 0

            Dim dblTotalProfitAfter As Double = 0
            Dim dblTotalProfitNow As Double = 0

            Dim dblSumAmt As Double = 0
            Dim dblCS_KPI As Double = 0
            Dim dblCS_KPI_GP As Double = 0
            Dim dblCS_KPI_TT As Double = 0

            intItem = i + 1
            With subDS.Tables("csShow").Rows(i)

                strCusCode = .Item("Ar_Cus_ID")
                strCusName = .Item("Ar_Name")

                dblTargetYear = .Item("sumTarget")
                dblSumAmt = .Item("sumTrh_AmtNow")
                If IsDBNull(.Item("Ar_LastSales_Date")) Then
                    strLastSales = ""
                Else
                    strLastSales = .Item("Ar_LastSales_Date")
                End If

                'dblCS_KPI = .Item("CS_KPI")
                'dblProfitAfter = .Item("sumProfitAfterY")
                'intCountAR = .Item("countAR")
                'dblSumAmt = .Item("sumTrh_AmtNow")
                'dblProfitNow = .Item("sumProfitNow")

                dblCS_KPI_GP = 0 '.Item("CS_GP_KPI")
                dblCS_KPI_TT = 0 '.Item("CS_TT_KPI")

                If chkRow = 1 Then
                    chkRow = 0
                ElseIf chkRow = 0 Then
                    chkRow = 1
                End If
            End With
            anyData = New String() {intItem.ToString("#,##0"), strCusCode, strCusName, dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), strLastSales}
            lvi = New ListViewItem(anyData)
            lsvDetail.Items.Add(lvi)

            If chkRow = 0 Then
                lvi.BackColor = Color.AliceBlue
                lvi.ForeColor = Color.Black
                'chkRow = 1

            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.SkyBlue 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                lvi.ForeColor = Color.Black

                'chkRow = 0
                'ElseIf chkRow = 2 Then

                '    lvi.BackColor = Color.PaleGoldenrod
                '    lvi.ForeColor = Color.DarkRed
                '    chkRow = 0
                'ElseIf chkRow = 3 Then

                '    lvi.BackColor = Color.White
                '    lvi.ForeColor = Color.DarkRed
                '    chkRow = 1
            End If
        Next



    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub lsvDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvDetail.SelectedIndexChanged

    End Sub

    Private Sub lsvDetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvDetail.DoubleClick


        Dim lvi0 As ListViewItem
        Dim frmChangeCS As New frmChangeCS

        For i = 0 To lsvDetail.SelectedItems.Count - 1
            lvi0 = lsvDetail.SelectedItems(i)
            ' Dim strGrpID As String = ""
            selCusID = lsvDetail.Items(lvi0.Index).SubItems(1).Text

        Next

        frmChangeCS.Show()
    End Sub

    Private Sub optOrdTarget_CheckedChanged(sender As Object, e As EventArgs) Handles optOrdTarget.CheckedChanged
        Call showData()
    End Sub

    Private Sub optOrdLastDate_CheckedChanged(sender As Object, e As EventArgs) Handles optOrdLastDate.CheckedChanged
        Call showData()
    End Sub

    Private Sub optOrdSumSales_CheckedChanged(sender As Object, e As EventArgs) Handles optOrdSumSales.CheckedChanged
        Call showData()
    End Sub

    Private Sub cmbUpdate_Click(sender As Object, e As EventArgs) Handles cmbUpdate.Click
        Call showData()
    End Sub
End Class