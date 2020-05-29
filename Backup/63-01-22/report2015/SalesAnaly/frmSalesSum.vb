Public Class frmSalesSum

    Sub formatGrid()


        lsvSales.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvSales.Columns.Add("Sales Name", 120, HorizontalAlignment.Left)
        lsvSales.Columns.Add("จำนวนลูกค้า", 100, HorizontalAlignment.Right)
        lsvSales.Columns.Add("KPI", 160, HorizontalAlignment.Right)

        lsvSales.Columns.Add("เป้า-ขาย", 180, HorizontalAlignment.Right)
        lsvSales.Columns.Add("ประเมิน-กำไร", 150, HorizontalAlignment.Right)

        lsvSales.Columns.Add("ยอดขายปี" & Year(Now), 150, HorizontalAlignment.Right)
        lsvSales.Columns.Add("กำไรปี" & Year(Now), 150, HorizontalAlignment.Right)

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
        txtSQL = txtSQL & "Sum(isnull(Ar_Profit,0))as ProfitTarget,"
        txtSQL = txtSQL & "sum(isnull(Ar_SL_Target,0))as SalesTarget,"




        '=========================================================
        txtSQL = txtSQL & "sum(case when (TranDataH.Trh_ProD_Sales='01' or TranDataH.Trh_ProD_Sales='02' or TranDataH.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TranDataH.Trh_D_Amt,0) else  0 end ) as sumTrh_D_Amt, "
        'txtSQL = txtSQL & "sum(isnull(Trh_Amt,0))as sumTrh_Amt,"

        txtSQL = txtSQL & "sum(case when (TranDataH.Trh_ProD_Sales='01' or TranDataH.Trh_ProD_Sales='02' or TranDataH.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TranDataH.Trh_W_Sum,0) else  0 end ) as sumTrh_W_Sum, "
        'txtSQL = txtSQL & "sum(isnull(Trh_W_Sum,0))as sumTrh_W_Sum,"

        txtSQL = txtSQL & "sum(case when (TranDataH.Trh_ProD_Sales='01' or TranDataH.Trh_ProD_Sales='02' or TranDataH.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TranDataH.Profit,0) else  0 end ) as sumTrh_Profit "
        'txtSQL = txtSQL & "sum(isnull(Profit,0))as sumTrh_Profit "
        '=========================================================

        txtSQL = txtSQL & "From SalesMan "
        txtSQL = txtSQL & "Left join ArFile "
        txtSQL = txtSQL & "On SL_ID=Ar_Sales "
        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "

        txtSQL = txtSQL & "left Join ("
        '=======================================================
        txtSQL = txtSQL & "Select Trh_Cus,Trh_Prod_Sales,sum(Trh_D_Amt)as Trh_D_Amt,sum(Trh_W_Sum)as Trh_W_Sum,sum(Trh_D_Amt-Trh_Cost_Amt)as Profit "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "
        txtSQL = txtSQL & "    )"
        txtSQL = txtSQL & "And ("

        txtSQL = txtSQL & "Year(Trh_Date)=year(GETDATE()) ) "
        'txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate()))) "

        txtSQL = txtSQL & "Group by Trh_Cus,Trh_Prod_Sales "
        txtSQL = txtSQL & ") TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "
        '================================================================
        txtSQL = txtSQL & "Where SL_Off=0 "
        txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        txtSQL = txtSQL & "group by sl_id,SL_Name,SL_NickName,SL_Target "
        txtSQL = txtSQL & "order by sum(Ar_Target_Year) desc "

        'txtSQL = txtSQL & "Order by sl_grp "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csCode")

        Dim slName As String = ""
        Dim slNum As Integer = 0
        Dim slTarget As Double = 0

        Dim salesTarget As Double = 0
        Dim totalSalesTarget As Double = 0

        Dim profitTarget As Double = 0
        Dim totalProfitTarget As Double = 0

        Dim slTrhAmt As Double = 0
        Dim totalTrhAmt As Double = 0

        Dim slTrhProfit As Double
        Dim totalslTrhProfit As Double
        Dim slKpi As Double
        Dim countAr As Integer
        Dim totalKPI As Double = 0
        Dim totalAr As Integer = 0

        With subDS.Tables("csCode")


            Dim chkRow As Integer = 0
            ' lsvDetail.Items.Clear()
            Dim SL_ID As String
            For i = 0 To subDS.Tables("csCode").Rows.Count - 1
                slNum = i
                slName = .Rows(i).Item("SL_Name")
                slKpi = .Rows(i).Item("SL_Target") * 12   ' ====   kpi  =====
                totalKPI = slKpi + totalKPI
                countAr = .Rows(i).Item("countAr")  '=======  counter AR
                totalAr = countAr + totalAr

                profitTarget = .Rows(i).Item("ProfitTarget")    '=======  เป้ากำไร 
                totalProfitTarget = totalProfitTarget + profitTarget

                salesTarget = .Rows(i).Item("SalesTarget") '=====  เป้ายอดขาย
                totalSalesTarget = totalSalesTarget + salesTarget   '  รวม Target Sales All Sales

                slTrhAmt = .Rows(i).Item("sumTrh_D_Amt")  '=== ยอดขาย
                totalTrhAmt = totalTrhAmt + slTrhAmt


                slTrhProfit = .Rows(i).Item("sumTrh_Profit")
                totalslTrhProfit = totalslTrhProfit + slTrhProfit

                SL_ID = .Rows(i).Item("SL_ID")
                anyData = New String() {slNum, slName, countAr, slKpi.ToString("#,##0.00"),
                    salesTarget.ToString("#,##0.00"), profitTarget.ToString("#,##0.00"),
                    slTrhAmt.ToString("#,##0.00"), slTrhProfit.ToString("#,##0.00"), SL_ID}

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

            anyData = New String() {"#", "Total", totalAr, totalKPI.ToString("#,##0.00"),
                totalSalesTarget.ToString("#,##0.00"), totalProfitTarget.ToString("#,##0.00"),
                totalTrhAmt.ToString("#,##0.00"), totalslTrhProfit.ToString("#,##0.00"), ""}

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
        selCS = selSale 'lsvCSlist.Items(lvi0.Index).SubItems(1).Text
        Dim frmCSreport As New frmCSreport
        selOptSL = 1
        frmCSreport.Show()


        'Dim frmSLdetl As New frmSalesDetl
        'frmSLdetl.Show()


    End Sub
End Class