Public Class frmRptCSmast

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub
    Sub formatGrid1()

        lsvCSlist.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("รหัสประจำตัว", 2, HorizontalAlignment.Left)
        lsvCSlist.Columns.Add("รายชื่อ CS ", 90, HorizontalAlignment.Left)
        lsvCSlist.Columns.Add("จำนวนลูกค้า ", 90, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("KPI กำไร", 150, HorizontalAlignment.Right)

        lsvCSlist.Columns.Add("เป้า-กำไร", 150, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("กำไร-ปัจจุบัน", 130, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("Diff", 150, HorizontalAlignment.Right)

        lsvCSlist.Columns.Add("เป้า-ขาย", 150, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("ขาย-ปัจจุบัน", 130, HorizontalAlignment.Right)
        lsvCSlist.Columns.Add("Diff", 150, HorizontalAlignment.Right)


        lsvCSlist.Columns.Add("-", 120, HorizontalAlignment.Right)
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


        txtSQL = txtSQL & "Sum(isnull(ArTarget.Ar_Profit,0))as ProfitTarget,"
        txtSQL = txtSQL & "sum(isnull(ArTarget.Ar_SL_Target,0))as SalesTarget,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01' or Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as SalesNow, "

        ' txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_Amt,0))as SalesNow,"
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01' or Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_Profit,0) else  0 end ) as ProfitNow "
        'txtSQL = txtSQL & "sum(isnull(TrhNow.Trh_Profit,0))as ProfitNow "


        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left join CSMast  "
        txtSQL = txtSQL & "On CSmast.CS_Code=Ar_CS "

        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "


        txtSQL = txtSQL & "Left Join  "
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,Trh_Prod_Sales,sum(Trh_D_Amt)as Trh_D_Amt,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Trh_Profit "
        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        txtSQL = txtSQL & "Group by Trh_Cus,Trh_Prod_Sales "
        txtSQL = txtSQL & " ) TrhNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "

        txtSQL = txtSQL & "Where  CS_Off='0' "
        txtSQL = txtSQL & "And Ar_Type='AR' "
        txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "


        txtSQL = txtSQL & "group by CS_Code,CS_Name,CSmast.CS_KPI "

        txtSQL = txtSQL & "Order by ProfitTarget desc"
        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")
        Dim dblTotalKPI As Double = 0

        Dim dblTotalProfit As Double = 0
        Dim dblTotalProfitNow As Double = 0
        Dim dblTotalProfitDiff As Double = 0

        Dim dblTotalSales As Double = 0
        Dim dblTotalSalesNow As Double = 0
        Dim dblTotalSalesDiff As Double = 0

        Dim dblTotalItem As Double = 0

        For i = 0 To subDS.Tables("csShow").Rows.Count - 1
            Dim intCountAR As Integer = 0
            Dim intItem As Integer = 0
            Dim strCSName As String = ""
            Dim strCScode As String = ""
            Dim dblCS_KPI As Double = 0

            Dim dblProfit_Target As Double = 0
            Dim dblProfit_Now As Double = 0
            Dim dblProfit_Diff As Double = 0

            Dim dblSale_Target As Double = 0
            Dim dblSale_Now As Double = 0
            Dim dblSale_Diff As Double = 0


            intItem = i + 1


            With subDS.Tables("csShow").Rows(i)

                strCScode = .Item("CS_Code")
                strCSName = .Item("CS_Name")
                intCountAR = .Item("countAR")
                dblTotalItem = dblTotalItem + intCountAR
                If IsDBNull(.Item("CS_KPI")) Then
                    dblCS_KPI = 0
                Else
                    dblCS_KPI = .Item("CS_KPI")
                End If
                dblTotalKPI = dblTotalKPI + dblCS_KPI


                dblProfit_Target = .Item("ProfitTarget")
                dblTotalProfit = dblTotalProfit + dblProfit_Target

                dblProfit_Now = .Item("ProfitNow")
                dblTotalProfitNow = dblProfit_Now + dblTotalProfitNow

                dblProfit_Diff = dblProfit_Target - dblProfit_Now
                dblTotalProfitDiff = dblTotalProfitDiff + dblProfit_Diff


                dblSale_Target = .Item("SalesTarget")
                dblTotalSales = dblTotalSales + dblSale_Target

                dblSale_Now = .Item("SalesNow")
                dblTotalSalesNow = dblTotalSalesNow + dblSale_Now

                dblSale_Diff = dblSale_Target - dblSale_Now
                dblTotalSalesDiff = dblTotalSalesDiff + dblSale_Diff

                'dblDiffProfit = dblProfitNow - dblProfitAfter
                'dblDiffTarget = dblSumAmt - dblTargetYear
                'dblCS_KPI_GP = 0 '.Item("CS_GP_KPI")
                'dblCS_KPI_TT = 0 '.Item("CS_TT_KPI")
                If chkRow = 1 Then
                    chkRow = 0
                ElseIf chkRow = 0 Then
                    chkRow = 1
                End If
            End With
            anyData = New String() {intItem.ToString("#,##0"), strCScode, strCSName, intCountAR.ToString("#,##0"), dblCS_KPI.ToString("#,##0.00"),
                dblProfit_Target.ToString("#,##0.00"), dblProfit_Now.ToString("#,##0.00"), dblProfit_Diff.ToString("#,##0.00"),
                dblSale_Target.ToString("#,##0.00"), dblSale_Now.ToString("#,##0.00"), dblSale_Diff.ToString("#,##0.00"), "", ""}

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
        anyData = New String() {"", "", "", dblTotalItem.ToString("#,##0"), dblTotalKPI.ToString("#,##0.00"),
            dblTotalProfit.ToString("#,##0.00"), dblTotalProfitNow.ToString("#,##0.00"), dblTotalProfitDiff.ToString("#,##0.00"),
            dblTotalSales.ToString("#,##0.00"), dblTotalSalesNow.ToString("#,##0.00"), dblTotalSalesDiff.ToString("#,##0.00")}

        lvi = New ListViewItem(anyData)
        lsvCSlist.Items.Add(lvi)
        lvi.BackColor = Color.Orange
        lvi.ForeColor = Color.Black

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
        selOptSL = 0
        frmCSreport.Show()

    End Sub
End Class