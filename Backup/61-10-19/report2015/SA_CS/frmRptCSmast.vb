Public Class frmRptCSmast

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub
    Sub formatGrid1()

        lsvCSlist.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("รหัสประจำตัว", 2, HorizontalAlignment.Left)
        lsvCSlist.Columns.Add("รายชื่อ CS ", 90, HorizontalAlignment.Left)
        lsvCSlist.Columns.Add("จำนวนลูกค้า ", 90, HorizontalAlignment.Right)


        lsvCSlist.Columns.Add("กำไรปี-ก่อน", 120, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("Diff", 120, HorizontalAlignment.Right)

        lsvCSlist.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)

        lsvCSlist.Columns.Add("Targetขาย-รวม", 120, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("ยอดขายรวม", 120, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("Diff", 120, HorizontalAlignment.Right)

        lsvCSlist.View = View.Details
        lsvCSlist.GridLines = True
        'chkCol = True

    End Sub
    Sub showData()
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim chkRow As Integer = 0
        Dim anyData() As String
        Dim lvi As ListViewItem

        txtSQL = "Select CS_Code,CS_Name,CSmast.CS_KPI,"
        txtSQL = txtSQL & "count(Ar_Cus_ID)as countAR,"
        txtSQL = txtSQL & "Sum(isnull(Ar_Sales_Target,0))as sumTarget,"

        txtSQL = txtSQL & "sum(isnull(TrHAfterY.Trh_Amt,0))as sumTrh_AmtAfterY,"
        txtSQL = txtSQL & "sum(isnull(TrHAfterY.Profit,0))as sumProfitAfterY,"

        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_Amt,0))as sumTrh_AmtNow,"
        txtSQL = txtSQL & "sum(isnull(TrHnow.Profit,0))as sumProfitNow "

        txtSQL = txtSQL & "From CSmast "
        txtSQL = txtSQL & "Left join ArFile  "
        txtSQL = txtSQL & "On CSmast.CS_Code=Ar_CS "

        txtSQL = txtSQL & "Left Join  "
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,sum(Trh_Amt)as Trh_Amt,"
        txtSQL = txtSQL & "sum(Trh_Amt-Trh_Cost_Amt)as Profit "
        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())-1)  "
        txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1))  "
        txtSQL = txtSQL & "Group by Trh_Cus"
        txtSQL = txtSQL & " ) TrHAfterY "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhAfterY.Trh_Cus  "

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

        txtSQL = txtSQL & "Where   CS_Off='0' "
        txtSQL = txtSQL & "group by CS_Code,CS_Name,CSmast.CS_KPI "
        txtSQL = txtSQL & "order by sum(Ar_Target_Year) desc  "
        txtSQL = txtSQL & ""
        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")

        For i = 0 To subDS.Tables("csShow").Rows.Count - 1
            Dim intCountAR As Integer = 0
            Dim intItem As Integer = 0
            Dim strCSName As String = ""
            Dim strCScode As String = ""
            Dim dblProfitAfter As Double = 0
            Dim dblProfitNow As Double = 0
            Dim dblSumAmt As Double = 0
            Dim dblCS_KPI As Double = 0
            Dim dblCS_KPI_GP As Double = 0
            Dim dblCS_KPI_TT As Double = 0
            Dim dblTargetYear As Double = 0
            Dim dblDiffTarget As Double = 0
            Dim dblDiffProfit As Double = 0

            intItem = i + 1
            With subDS.Tables("csShow").Rows(i)
                strCScode = .Item("CS_Code")
                strCSName = .Item("CS_Name")
                intCountAR = .Item("countAR")
                dblCS_KPI = .Item("CS_KPI")

                dblTargetYear = .Item("sumTarget")
                dblProfitAfter = .Item("sumProfitAfterY")

                dblSumAmt = .Item("sumTrh_AmtNow")
                dblProfitNow = .Item("sumProfitNow")

                dblDiffProfit = dblProfitNow - dblProfitAfter
                dblDiffTarget = dblSumAmt - dblTargetYear
                dblCS_KPI_GP = 0 '.Item("CS_GP_KPI")
                dblCS_KPI_TT = 0 '.Item("CS_TT_KPI")
                If chkRow = 1 Then
                    chkRow = 0
                ElseIf chkRow = 0 Then
                    chkRow = 1
                End If
            End With
            anyData = New String() {intItem.ToString("#,##0"), strCScode, strCSName, intCountAR.ToString("#,##0"), dblProfitAfter.ToString("#,##0.00"), dblProfitNow.ToString("#,##0.00"), dblDiffProfit.ToString("#,##0.00"), dblCS_KPI.ToString("#,##0.00"), dblCS_KPI_GP.ToString("#,##0.00"), dblCS_KPI_TT.ToString("#,##0.00"), dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), dblDiffTarget.ToString("#,##0.00")}
            lvi = New ListViewItem(anyData)
            lsvCSlist.Items.Add(lvi)

            If chkRow = 0 Then
                lvi.BackColor = Color.AliceBlue
                lvi.ForeColor = Color.Black
                'chkRow = 1

            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.CornflowerBlue 'LightSteelBlue 'DarkOrange
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
    Private Sub ftmCSmast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatGrid1()
        showData()
    End Sub

    Private Sub lsvCSlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCSlist.SelectedIndexChanged

    End Sub

    Private Sub lsvCSlist_DoubleClick(sender As Object, e As EventArgs) Handles lsvCSlist.DoubleClick
        Dim lvi0 As ListViewItem
        Dim frmCSreport As New frmCSreport

        For i = 0 To lsvCSlist.SelectedItems.Count - 1

            lvi0 = lsvCSlist.SelectedItems(i)
            ' Dim strGrpID As String = ""
            selCS = lsvCSlist.Items(lvi0.Index).SubItems(1).Text

        Next

        frmCSreport.Show()

    End Sub
End Class