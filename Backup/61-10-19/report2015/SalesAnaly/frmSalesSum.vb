Public Class frmSalesSum

    Sub formatGrid()


        lsvSales.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvSales.Columns.Add("Sales Name", 120, HorizontalAlignment.Left)
        lsvSales.Columns.Add("จำนวนลูกค้า", 100, HorizontalAlignment.Right)
        lsvSales.Columns.Add("KPI", 160, HorizontalAlignment.Right)

        lsvSales.Columns.Add("ยอดกำไรปี 59", 180, HorizontalAlignment.Right)

        lsvSales.Columns.Add("Target-กำไร" & Year(Now), 150, HorizontalAlignment.Right)
        lsvSales.Columns.Add("กำไรปี" & Year(Now), 150, HorizontalAlignment.Right)
        lsvSales.Columns.Add("ยอดขายปี" & Year(Now), 150, HorizontalAlignment.Right)
        lsvSales.Columns.Add("id", 1, HorizontalAlignment.Right)


        lsvSales.View = View.Details
        lsvSales.GridLines = True
        'chkCol = True

    End Sub

    Private Sub frmSalesSum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem
        lsvSales.Clear()

        formatGrid()

        txtSQL = "Select sl_id,SL_Name,SL_NickName,SL_Target,count(Ar_Cus_ID)as countAR,"
        txtSQL = txtSQL & "Sum(isnull(Ar_Target,0))as sumTarget,"
        txtSQL = txtSQL & "sum(isnull(Ar_Target_Year,0))as sumTargetYear,"
        txtSQL = txtSQL & "sum(isnull(Trh_Amt,0))as sumTrh_Amt,sum(isnull(Trh_W_Sum,0))as sumTrh_W_Sum,"
        txtSQL = txtSQL & "sum(isnull(Profit,0))as sumProfit "

        txtSQL = txtSQL & "From SalesMan "
        txtSQL = txtSQL & "Left join ArFile "
        txtSQL = txtSQL & "On SL_ID=Ar_Sales "
        txtSQL = txtSQL & "left Join ("
        '=======================================================
        txtSQL = txtSQL & "Select Trh_Cus,sum(Trh_Amt)as Trh_Amt,sum(Trh_W_Sum)as Trh_W_Sum,sum(Trh_Amt-Trh_Cost_Amt)as Profit "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Where Trh_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "
        txtSQL = txtSQL & "    )"
        txtSQL = txtSQL & "And ("

        txtSQL = txtSQL & "Year(Trh_Date)=year(GETDATE()))  "
        txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate()))) "

        txtSQL = txtSQL & "Group by Trh_Cus "
        txtSQL = txtSQL & ") TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "
        '================================================================
        txtSQL = txtSQL & "Where SL_Off=0 "
        txtSQL = txtSQL & "and not(SL_ID='SL14' or SL_ID='SL99' or SL_ID='SL23' or SL_ID='SL03')"

        txtSQL = txtSQL & "group by sl_id,SL_Name,SL_NickName,SL_Target "
        txtSQL = txtSQL & "order by sum(Ar_Target_Year) desc "

        'txtSQL = txtSQL & "Order by sl_grp "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csCode")

        Dim slName As String = ""
        Dim slNum As Integer = 0
        Dim slTarget As Double = 0
        Dim slTarget59 As Double = 0
        Dim slSumAmt As Double = 0
        Dim slSumProfit As Double = 0
        Dim slKpi As Double = 0
        Dim countAr As Integer = 0

        Dim totalTarget As Double = 0
        Dim totalTarget59 As Double = 0
        Dim totalSumAmt As Double = 0
        Dim totalSumProfit As Double = 0
        Dim totalKPI As Double = 0
        Dim totalAr As Integer = 0

        With subDS.Tables("csCode")

            lbTotalKPI.Text = 0
            lbTotalTarget.Text = 0
            lbTotalYear59.Text = 0
            Dim chkRow As Integer = 0
            ' lsvDetail.Items.Clear()
            Dim SL_ID As String
            For i = 0 To subDS.Tables("csCode").Rows.Count - 1

                slName = .Rows(i).Item("SL_Name")
                slNum = i
                slKpi = .Rows(i).Item("SL_Target") * 12

                If IsDBNull(.Rows(i).Item("SumTarget")) Then
                    slTarget = 0
                Else
                    slTarget = .Rows(i).Item("SumTarget")
                End If
                slSumAmt = .Rows(i).Item("sumTrh_Amt")
                slSumProfit = .Rows(i).Item("sumProfit")
                countAr = .Rows(i).Item("countAr")

                If IsDBNull(.Rows(i).Item("sumTargetYear")) Then
                    slTarget59 = 0
                Else
                    slTarget59 = .Rows(i).Item("sumTargetYear")
                End If

                totalKPI = slKpi + totalKPI
                totalSumProfit = totalSumProfit + slSumProfit
                totalTarget = totalTarget + slTarget
                totalAr = countAr + totalAr
                totalTarget59 = totalTarget59 + slTarget59
                totalSumAmt = slSumAmt + totalSumAmt

                SL_ID = .Rows(i).Item("SL_ID")
                anyData = New String() {slNum, slName, countAr, slKpi.ToString("#,##0.00"), slTarget59.ToString("#,##0.00"), slTarget.ToString("#,##0.00"), slSumProfit.ToString("#,##0.00"), slSumAmt.ToString("#,##0.00"), SL_ID}
                lvi = New ListViewItem(anyData)
                lsvSales.Items.Add(lvi)

                If chkRow = 0 Then
                    lvi.BackColor = Color.Orange
                    lvi.ForeColor = Color.Black
                    chkRow = 1
                ElseIf chkRow = 1 Then
                    lvi.BackColor = Color.PaleGoldenrod
                    lvi.ForeColor = Color.Black
                    chkRow = 0
                Else
                    lvi.BackColor = Color.DarkRed
                    lvi.ForeColor = Color.White
                End If
            Next
            lbTotalKPI.Text = totalKPI.ToString("#,##0.00")
            lbTotalProfit.Text = totalSumProfit.ToString("#,##0.00")
            lbTotalTarget.Text = totalTarget.ToString("#,##0.00")
            lbTotalYear59.Text = totalTarget59.ToString("#,##0.00")
            lbTotalAmt.Text = totalSumAmt.ToString("#,##0.00")
            lbCountCus.Text = totalAr.ToString("#,##0")

            anyData = New String() {"#", "Total", totalAr, totalKPI.ToString("#,##0.00"), totalTarget59.ToString("#,##0.00"), totalTarget.ToString("#,##0.00"), totalSumProfit.ToString("#,##0.00"), totalSumAmt.ToString("#,##0.00"), ""}
            lvi = New ListViewItem(anyData)
            lsvSales.Items.Add(lvi)
            lvi.BackColor = Color.YellowGreen
            lvi.ForeColor = Color.Black

        End With


    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub


    Private Sub lsvSales_Click(sender As Object, e As EventArgs) Handles lsvSales.Click




    End Sub

    Private Sub lsvSales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvSales.SelectedIndexChanged

    End Sub

    Private Sub lsvSales_DoubleClick(sender As Object, e As EventArgs) Handles lsvSales.DoubleClick
        'Dim frmSetSales As New frmSetSales
        'Dim lvi0 As ListViewItem

        'For i = 0 To lsvSales.SelectedItems.Count - 1
        '    lvi0 = lsvSales.SelectedItems(i)
        '    'Dim strGrpID As String = ""

        '    selSale = lsvSales.Items(lvi0.Index).SubItems(6).Text

        'Next

        'frmSetSales.ShowDialog()

        Dim lvi0 As ListViewItem

        For i = 0 To lsvSales.SelectedItems.Count - 1
            lvi0 = lsvSales.SelectedItems(i)

            'Dim strGrpID As String = ""

            selSale = lsvSales.Items(lvi0.Index).SubItems(8).Text

        Next

        Dim frmSLdetl As New frmSalesDetl
        frmSLdetl.Show()


    End Sub
End Class