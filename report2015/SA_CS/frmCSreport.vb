Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmCSreport
    'Dim strCScode As String = selCS
    Dim frmLoad As Boolean = False
    Dim chkValue As Integer = 0


    Sub formatGrid1()

        lsvDetail.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("รหัสลูกค้า", 2, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("รายชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("พนักงานขาย", 70, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("ผู้ติดต่อ", 150, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("เขตการขาย", 130, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("Tel", 180, HorizontalAlignment.Left)        '
        'lsvDetail.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)

        'lsvDetail.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ประเมินขาย/ปี", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ขาย-ปัจจุบัน", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ระยะขาดการติดต่อ", 150, HorizontalAlignment.Right)
        lsvDetail.View = View.Details
        lsvDetail.GridLines = True
        'chkCol = True

        lsvDetail1M.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvDetail1M.Columns.Add("รหัสลูกค้า", 2, HorizontalAlignment.Left)
        lsvDetail1M.Columns.Add("รายชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvDetail1M.Columns.Add("พนักงานขาย", 70, HorizontalAlignment.Left)
        lsvDetail1M.Columns.Add("ผู้ติดต่อ", 150, HorizontalAlignment.Left)
        lsvDetail1M.Columns.Add("เขตการขาย", 130, HorizontalAlignment.Left)
        lsvDetail1M.Columns.Add("Tel", 180, HorizontalAlignment.Left)
        '
        'lsvDetail.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)

        'lsvDetail.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)
        lsvDetail1M.Columns.Add("ประเมินขาย/ปี", 120, HorizontalAlignment.Right)
        lsvDetail1M.Columns.Add("ขาย-ปัจจุบัน", 120, HorizontalAlignment.Right)
        lsvDetail1M.Columns.Add("ระยะขาดการติดต่อ", 150, HorizontalAlignment.Right)

        lsvDetail1M.View = View.Details
        lsvDetail1M.GridLines = True
        'chkCol = True

        lsvDetail2M.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvDetail2M.Columns.Add("รหัสลูกค้า", 2, HorizontalAlignment.Left)
        lsvDetail2M.Columns.Add("รายชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvDetail2M.Columns.Add("พนักงานขาย", 70, HorizontalAlignment.Left)
        lsvDetail2M.Columns.Add("ผู้ติดต่อ", 150, HorizontalAlignment.Left)
        lsvDetail2M.Columns.Add("เขตการขาย", 130, HorizontalAlignment.Left)
        lsvDetail2M.Columns.Add("Tel", 180, HorizontalAlignment.Left)
        '
        'lsvDetail.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)

        'lsvDetail.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)
        lsvDetail2M.Columns.Add("ประเมินขาย/ปี", 120, HorizontalAlignment.Right)
        lsvDetail2M.Columns.Add("ขาย-ปัจจุบัน", 120, HorizontalAlignment.Right)
        lsvDetail2M.Columns.Add("ระยะขาดการติดต่อ", 150, HorizontalAlignment.Right)

        lsvDetail2M.View = View.Details
        lsvDetail2M.GridLines = True
        'chkCol = True


        lsvDetail6M.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvDetail6M.Columns.Add("รหัสลูกค้า", 2, HorizontalAlignment.Left)
        lsvDetail6m.Columns.Add("รายชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvDetail6m.Columns.Add("พนักงานขาย", 70, HorizontalAlignment.Left)
        lsvDetail6m.Columns.Add("ผู้ติดต่อ", 150, HorizontalAlignment.Left)
        lsvDetail6m.Columns.Add("เขตการขาย", 130, HorizontalAlignment.Left)
        lsvDetail6m.Columns.Add("Tel", 180, HorizontalAlignment.Left)
        '
        'lsvDetail.Columns.Add("กำไรปี-ปัจจุบัน", 120, HorizontalAlignment.Right)

        'lsvDetail.Columns.Add("KPI รวม", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI GP", 100, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("KPI TT", 100, HorizontalAlignment.Right)
        lsvDetail6m.Columns.Add("ประเมินขาย/ปี", 120, HorizontalAlignment.Right)
        lsvDetail6m.Columns.Add("ขาย-ปัจจุบัน", 120, HorizontalAlignment.Right)
        lsvDetail6m.Columns.Add("ระยะขาดการติดต่อ", 150, HorizontalAlignment.Right)

        lsvDetail6m.View = View.Details
        lsvDetail6m.GridLines = True
        'chkCol = True
    End Sub
    Private Sub frmCSreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'selOptSL = 0  '  เลือกรายงานเป็นอะไร  0 เป็น  CS ถ้า 1 เป็น  Sales
        If selOptSL = 0 Then
            lbCSname.Text = cusTools.getCSName(selCS)
            lbCScode.Text = selCS
        Else
            lbCSname.Text = cusTools.getSaleName(selCS)
            lbCScode.Text = selCS
        End If

        'Call formatGrid1()
        Dim i As Integer = 0
        Dim strDate As Date = "03/01/2562"
        Dim endDate As Date = "28/12/2562"
        Call txtCLS()
        i = calDayWork(Now, endDate) - 13
        lbDayQty.Text = i
        lbDayQty0.Text = calDayWork(strDate, endDate) - 13  '  13 ที่ลบที่หลังคือ ลบวันหยุด 13 วันต่อปี
        lbActDay.Text = lbDayQty0.Text - lbDayQty.Text
        Call showData()
        '   lbCSname.Text=DateTime.DaysInMonth(2019,Month(now))
        frmLoad = True

    End Sub

    Sub showData()

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim chkRow As Integer = 0
        Dim chkRow1 As Integer = 0
        Dim chkRow2 As Integer = 0
        Dim chkRow3 As Integer = 0

        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim strCScode As String = ""
        ' Label86.Text = DateTime.DaysInMonth("2019", 1)  วิธีคำนวนจำนวนวันในเดือน

        strCScode = lbCScode.Text
        txtSQL = "Select Ar_Cus_ID,Ar_Name,SL_nickName,Ar_LastSales_Date,Amphoe_Name,AmphoeMast.Country_Name,Ar_Tel_No,AR_Contact,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01' or Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as sumTrh_AmtNow, "
        ' txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_Amt,0))as sumTrh_AmtNow,"
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01' or Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Profit,0) else  0 end ) as sumTrh_Profit, "
        'txtSQL = txtSQL & "sum(isnull(Trhnow.Profit,0))as sumTrh_Profit,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actGPSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_W,0) else  0 end ) as actGPWeight, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(Trhnow.Profit,0) else  0 end ) as actGPProfit, "

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05' ) then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actTTSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05' ) then "
        txtSQL = txtSQL & "     isnull(TrhNow.Profit,0) else  0 end ) as actTTProfit, "

        txtSQL = txtSQL & "(isnull(Ar_Sales_Target,0))as sumTarget, "  ' ข้อมูล sales  ประเมินยอดขาย
        txtSQL = txtSQL & "(isnull(Ar_SL_Target,0))as SLTarget,"  '  ข้อมูลจากการขายในอดีต ปี 60
        txtSQL = txtSQL & "(isnull(Ar_Profit,0))as SLProfit,"   '  ข้อมูลกาจการขายในอดีต 
        txtSQL = txtSQL & "(isnull(AR_GP_SL_Target,0))as GP_Target,"
        txtSQL = txtSQL & "(isnull(Ar_GP_W_Target,0))as GP_W_Target,"
        txtSQL = txtSQL & "(isnull(Ar_GP_Profit,0))as GP_Profit, "
        txtSQL = txtSQL & "(isnull(Ar_TT_SL_Target,0))as TT_Target,"
        txtSQL = txtSQL & "(isnull(Ar_TT_Profit,0))as TT_Profit "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "

        txtSQL = txtSQL & "Inner Join SalesMan "
        txtSQL = txtSQL & "On Ar_Sales=SL_ID "

        txtSQL = txtSQL & "Left Join AmphoeMast "
        txtSQL = txtSQL & "On ArFile.Ar_Amphoe_Code=AmphoeMast.Amphoe_Code "

        txtSQL = txtSQL & "Left Join  "
        '===========================================================================================
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,Trh_ProD_Sales,sum(Trh_D_Amt)as Trh_D_Amt,sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Profit "

        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (TRh_Prod_Sales='01' or Trh_Prod_Sales='02' or Trh_Prod_Sales='05' ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        'txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        txtSQL = txtSQL & "Group by Trh_Cus,Trh_ProD_Sales "
        txtSQL = txtSQL & " ) TrHNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "
        '===========================================================================================
        If selOptSL = 0 Then
            txtSQL = txtSQL & "Where   Ar_CS='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        Else
            txtSQL = txtSQL & "Where   Ar_Sales='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        End If
        '===========================================================================================

        txtSQL = txtSQL & "Group by  AR_CUS_ID,Ar_Name,SL_nickName,Ar_LastSales_Date ,Amphoe_Name,AmphoeMast.Country_Name,Ar_Tel_No,AR_CONTACT,"
        txtSQL = txtSQL & "Ar_Sales_Target,Ar_SL_Target,Ar_Profit,AR_GP_SL_Target,Ar_GP_W_Target,"
        txtSQL = txtSQL & "Ar_GP_Profit,Ar_TT_SL_Target,Ar_TT_Profit "

        If optOrdTarget.Checked = True Then
            txtSQL = txtSQL & "order by Sum(isnull(Ar_Sales_Target,0)) desc  "
        ElseIf optOrdLastDate.Checked = True Then
            txtSQL = txtSQL & "order by Ar_LastSales_Date desc  "
        ElseIf optOrdSumSales.Checked = True Then
            txtSQL = txtSQL & "order by sum(isnull(TrHnow.Trh_D_Amt,0)) desc  "
        ElseIf optZone.Checked = True Then
            txtSQL = txtSQL & "Order by Amphoe_Name "
        End If

        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")

        lsvDetail.Clear()
        lsvDetail1M.Clear()
        lsvDetail2M.Clear()
        lsvDetail6m.Clear()
        formatGrid1()
        Dim dblTotalTargetYear As Double = 0
        Dim dblTotalSumAmt As Double = 0

        Dim seriesYear As New Series '("SERIES0")
        Dim seriesCus As New Series
        Dim seriesCusActive As New Series

        chartCusItem.Series.Clear()
        chartYear.Series.Clear()
        chartCusActive.Series.Clear()


        'Dim seriesPrice As New Series
        Call txtCLS()
        Dim CusItem1M As Integer = 0
        Dim cusItem2M As Integer = 0  ' จำนวนลูกค้าที่ขาดการติดต่อ มากกว่า  2 เดือน
        Dim cusItem6M As Integer = 0

        lbCusItem0.Text = 0
        lbCusItem1M.Text = 0
        lbCusItem2M.Text = 0
        lbCusItem6M.Text = 0

        Dim itemM0 As Integer = 0
        Dim itemM1 As Integer = 0
        Dim itemM2 As Integer = 0
        Dim itemM6 As Integer = 0


        For i = 0 To subDS.Tables("csShow").Rows.Count - 1

            Dim intCountAR As Integer = 0
            Dim intItem As Integer = 0
            Dim strCusCode As String = ""
            Dim strCusName As String = ""
            Dim strSalesName As String = ""
            Dim strCusContact As String = ""
            Dim strLastSales As String = ""
            Dim strTelNo As String = ""

            Dim dblTargetYear As Double = 0

            Dim dblProfitAfter As Double = 0
            Dim dblProfitNow As Double = 0

            Dim dblTotalProfitAfter As Double = 0
            Dim dblTotalProfitNow As Double = 0

            Dim dblSumAmt As Double = 0
            Dim dblCS_KPI As Double = 0
            Dim dblCS_KPI_GP As Double = 0
            Dim dblCS_KPI_TT As Double = 0

            Dim strAmphoe As String = ""
            intItem = i + 1
            lbCountItem.Text = Format(intItem, "#,##0")
            lbCusItem.Text = Format(intItem, "#,##0")
            Dim chkM As Integer = 0

            With subDS.Tables("csShow").Rows(i)

                strCusCode = .Item("Ar_Cus_ID")
                strCusName = .Item("Ar_Name")
                strSalesName = .Item("SL_nickName")

                dblTargetYear = .Item("SLTarget")

                dblTotalTargetYear = dblTotalTargetYear + dblTargetYear

                dblSumAmt = .Item("sumTrh_AmtNow")
                dblTotalSumAmt = dblTotalSumAmt + dblSumAmt

                lbTarget_Sales.Text = Format(.Item("SLTarget") + lbTarget_Sales.Text, "#,##0.00")
                lbTarget_Profit.Text = Format(.Item("SLProfit") + lbTarget_Profit.Text, "#,##0.00")
                lbTarget_GP.Text = Format(.Item("GP_Target") + lbTarget_GP.Text, "#,##0.00")
                lbTarget_GPProfit.Text = Format(.Item("GP_Profit") + lbTarget_GPProfit.Text, "#,##0.00")
                lbTarget_GPWeight.Text = Format(.Item("GP_W_Target") + lbTarget_GPWeight.Text, "#,##0.00")

                lbTarget_TT.Text = Format(.Item("TT_Target") + lbTarget_TT.Text, "#,##0.00")
                lbTarget_TTProfit.Text = Format(.Item("TT_Profit") + lbTarget_TTProfit.Text, "#,##0.00")

                lbAct_Sales.Text = Format(.Item("sumTrh_AmtNow") + lbAct_Sales.Text, "#,##0.00")
                lbAct_Profit.Text = Format(.Item("sumTrh_Profit") + lbAct_Profit.Text, "#,##0.00")

                lbAct_GP.Text = Format(.Item("actGPSales") + lbAct_GP.Text, "#,##0.00")
                lbAct_GPProfit.Text = Format(.Item("actGPProfit") + lbAct_GPProfit.Text, "#,##0.00")
                lbAct_GPweight.Text = Format(.Item("actGPWeight") + lbAct_GPweight.Text, "#,##0.00")
                lbAct_TT.Text = Format(.Item("actTTsales") + lbAct_TT.Text, "#,##0.00")
                lbAct_TTProfit.Text = Format(.Item("actTTProfit") + lbAct_TTProfit.Text, "#,##0.00")

                lbDiff_TargetSales.Text = Format(lbTarget_Sales.Text - lbAct_Sales.Text, "#,##0.00")
                lbDiff_TargetProfit.Text = Format(lbTarget_Profit.Text - lbAct_Profit.Text, "#,##0.00")
                lbDiff_TargetGP.Text = Format(lbTarget_GP.Text - lbAct_GP.Text, "#,##0.00")
                lbDiff_TargetGPPrifit.Text = Format(lbTarget_GPProfit.Text - lbAct_GPProfit.Text, "#,##0.00")
                lbDiff_TargetGPWeight.Text = Format(lbTarget_GPWeight.Text - lbAct_GPweight.Text, "#,##0.00")
                lbDiff_TargetTT.Text = Format(lbTarget_TT.Text - lbAct_TT.Text, "#,##0.00")
                lbDiff_TargetTTProfit.Text = Format(lbTarget_TTProfit.Text - lbAct_TTProfit.Text, "#,##0.00")

                lbSim_Target.Text = Format(lbDiff_TargetSales.Text / lbDayQty.Text, "#,##0.00")
                lbSim_Profit.Text = Format(lbDiff_TargetProfit.Text / lbDayQty.Text, "#,##0.00")
                lbSim_GPtarget.Text = Format(lbDiff_TargetGP.Text / lbDayQty.Text, "#,##0.00")
                lbSim_GPProfit.Text = Format(lbDiff_TargetGPPrifit.Text / lbDayQty.Text, "#,##0.00")
                lbSim_GPWeight.Text = Format(lbDiff_TargetGPWeight.Text / lbDayQty.Text, "#,##0.00")
                lbSim_TT.Text = Format(lbDiff_TargetTT.Text / lbDayQty.Text, "#,##0.00")
                lbSim_TTProfit.Text = Format(lbDiff_TargetTTProfit.Text / lbDayQty.Text, "#,##0.00")

                lbPerf_Sales.Text = Format(lbAct_Sales.Text / lbActDay.Text, "#,##0.00")
                lbPerf_Profit.Text = Format(lbAct_Profit.Text / lbActDay.Text, "#,##0.00")
                lbPerf_GP.Text = Format(lbAct_GP.Text / lbActDay.Text, "#,##0.00")
                lbPerf_GPProfit.Text = Format(lbAct_GPProfit.Text / lbActDay.Text, "#,##0.00")
                lbPerf_GPWeight.Text = Format(lbAct_GPweight.Text / lbActDay.Text, "#,##0.00")
                lbPerf_TT.Text = Format(lbAct_TT.Text / lbActDay.Text, "#,##0.00")
                lbPerf_TTProfit.Text = Format(lbAct_TTProfit.Text / lbActDay.Text, "#,##0.00")

                lbStd_Sales.Text = Format(lbTarget_Sales.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_Profit.Text = Format(lbTarget_Profit.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_GP.Text = Format(lbTarget_GP.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_GPProfit.Text = Format(lbTarget_GPProfit.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_GPWeight.Text = Format(lbTarget_GPWeight.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_TT.Text = Format(lbTarget_TT.Text / lbDayQty0.Text, "#,##0.00")
                lbStd_TTProfit.Text = Format(lbTarget_TTProfit.Text / lbDayQty0.Text, "#,##0.00")

                If IsDBNull(.Item("Ar_LastSales_Date")) Then
                    strLastSales = ""
                    chkM = 2
                Else
                    strLastSales = DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31 & " เดือน-" & Format(DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) Mod 31, "00") & " วัน"

                    ' ISNULL((DATEDIFF(DAY ,Ar_lastSales_Date,GETDATE())),0)

                    If (DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31) >= 1 And (DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31) < 2 Then
                        chkRow = 2
                        chkM = 1
                        CusItem1M = CusItem1M + 1
                        lbCusItem1M.Text = Format(CusItem1M, "#,##0.00")
                    ElseIf (DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31) >= 2 And (DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31) < 6 Then
                        chkM = 2
                        chkRow = 3
                        cusItem2M = cusItem2M + 1
                        lbCusItem2M.Text = Format(cusItem2M, "#,##0.00")

                    ElseIf (DateDiff(DateInterval.Day, .Item("Ar_LastSales_Date"), Now) \ 31) >= 6 Then
                        chkM = 3
                        chkRow = 4
                        cusItem6M = cusItem6M + 1
                        lbCusItem6M.Text = Format(cusItem6M, "#,##0.00")

                    Else

                        chkM = 0

                    End If
                End If

                If IsDBNull(.Item("Amphoe_Name")) Then
                    strAmphoe = "ไม่พบข้อมูล"
                Else
                    strAmphoe = .Item("Amphoe_Name")
                End If
                If IsDBNull(.Item("Ar_Tel_No")) Then
                    strTelNo = "ไม่มีข้อมูล"
                Else
                    strTelNo = .Item("Ar_Tel_No")
                End If

                strCusContact = .Item("Ar_Contact")
                ' Dim d As Integer = 
                'dblCS_KPI = .Item("CS_KPI")
                'dblProfitAfter = .Item("sumProfitAfterY")
                'intCountAR = .Item("countAR")
                'dblSumAmt = .Item("sumTrh_AmtNow")
                'dblProfitNow = .Item("sumProfitNow")

                dblCS_KPI_GP = 0 '.Item("CS_GP_KPI")
                dblCS_KPI_TT = 0 '.Item("CS_TT_KPI")

                'If chkRow = 1 Then
                '    chkRow = 0
                'ElseIf chkRow = 0 Then
                '    chkRow = 1
                'End If
            End With


            If chkM = 0 Then
                itemM0 = itemM0 + 1
                anyData = New String() {itemM0.ToString("#,##0"), strCusCode, strCusName, strSalesName, strCusContact, strAmphoe, strTelNo, dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), strLastSales}
                lvi = New ListViewItem(anyData)
                lsvDetail.Items.Add(lvi)
                If chkRow = 0 Then
                    lvi.BackColor = Color.AliceBlue
                    lvi.ForeColor = Color.Black
                    chkRow = 1

                ElseIf chkRow = 1 Then
                    lvi.BackColor = Color.SkyBlue 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.Black
                    chkRow = 0
                End If

            ElseIf chkM = 1 Then
                itemM1 = itemM1 + 1
                anyData = New String() {itemM1.ToString("#,##0"), strCusCode, strCusName, strSalesName, strCusContact, strAmphoe, strTelNo, dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), strLastSales}
                lvi = New ListViewItem(anyData)
                lsvDetail1M.Items.Add(lvi)
                If chkRow1 = 0 Then
                    lvi.BackColor = Color.Yellow 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.Black
                    chkRow1 = 1
                Else
                    lvi.BackColor = Color.White 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.Black
                    chkRow1 = 0

                End If

            ElseIf chkM = 2 Then

                itemM2 = itemM2 + 1
                anyData = New String() {itemM2.ToString("#,##0"), strCusCode, strCusName, strSalesName, strCusContact, strAmphoe, strTelNo, dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), strLastSales}
                lvi = New ListViewItem(anyData)
                lsvDetail2M.Items.Add(lvi)
                If chkRow2 = 0 Then
                    lvi.BackColor = Color.DarkRed 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.White
                    chkRow2 = 1

                ElseIf chkRow2 = 1 Then
                    lvi.BackColor = Color.White 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.Black
                    chkRow2 = 0

                End If
            ElseIf chkM = 3 Then

                itemM6 = itemM6 + 1
                anyData = New String() {itemM6.ToString("#,##0"), strCusCode, strCusName, strSalesName, strCusContact, strAmphoe, strTelNo, dblTargetYear.ToString("#,##0.00"), dblSumAmt.ToString("#,##0.00"), strLastSales}
                lvi = New ListViewItem(anyData)
                lsvDetail6m.Items.Add(lvi)
                If chkRow3 = 0 Then
                    lvi.BackColor = Color.Gray 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.White
                    chkRow3 = 1

                ElseIf chkRow3 = 1 Then
                    lvi.BackColor = Color.White 'CornflowerBlue 'LightSteelBlue 'DarkOrange
                    lvi.ForeColor = Color.Black
                    chkRow3 = 0

                End If
            End If

        Next
        lbCusItem0.Text = Format(lbCusItem.Text - lbCusItem1M.Text - lbCusItem2M.Text - lbCusItem6M.Text, "#,##0.00")

        If chk100.Checked = True Then
            chkValue = 100
        ElseIf chk0.Checked = True Then
            chkValue = 0
        End If


        lbRatioAct_Sales.Text = Format((((lbAct_Sales.Text - lbTarget_Sales.Text) / lbTarget_Sales.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_Sales, lbRatioAct_Sales.Text)
        lbRatioAct_Profit.Text = Format((((lbAct_Profit.Text - lbTarget_Profit.Text) / lbTarget_Profit.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_Profit, lbRatioAct_Profit.Text)
        lbRatioAct_GP.Text = Format((((lbAct_GP.Text - lbTarget_GP.Text) / lbTarget_GP.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_GP, lbRatioAct_GP.Text)
        lbRatioAct_GPProFit.Text = Format((((lbAct_GPProfit.Text - lbTarget_GPProfit.Text) / lbTarget_GPProfit.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_GPProFit, lbRatioAct_GPProFit.Text)
        lbRatioAct_GPWeight.Text = Format((((lbAct_GPweight.Text - lbTarget_GPWeight.Text) / lbTarget_GPWeight.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_GPWeight, lbRatioAct_GPWeight.Text)
        lbRatioAct_TT.Text = Format((((lbAct_TT.Text - lbTarget_TT.Text) / lbTarget_TT.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_TT, lbRatioAct_TT.Text)
        lbRatioAct_TTProfit.Text = Format((((lbAct_TTProfit.Text - lbTarget_TTProfit.Text) / lbTarget_TTProfit.Text) * 100) - (chkValue - 100), "#,##0.00")
        chkObj(lbRatioAct_TTProfit, lbRatioAct_TTProfit.Text)


        lbRatioDiff_Sales.Text = Format((chkValue - 100) + lbRatioAct_Sales.Text, "#,##0.00")
        chkObj(lbRatioDiff_Sales, lbRatioDiff_Sales.Text)
        lbRatioDiff_Profit.Text = Format((chkValue - 100) + lbRatioAct_Profit.Text, "#,##0.00")
        chkObj(lbRatioDiff_Profit, lbRatioDiff_Profit.Text)
        lbRatioDiff_GP.Text = Format((chkValue - 100) + lbRatioAct_GP.Text, "#,#0.00")
        chkObj(lbRatioDiff_GP, lbRatioDiff_GP.Text)
        lbRatioDiff_GPProfit.Text = Format((chkValue - 100) + lbRatioAct_GPProFit.Text, "#,##0.00")
        chkObj(lbRatioDiff_GPProfit, lbRatioDiff_GPProfit.Text)
        lbRatioDiff_GPWeight.Text = Format((chkValue - 100) + lbRatioAct_GPWeight.Text, "#,##0.00")
        chkObj(lbRatioDiff_GPWeight, lbRatioDiff_GPWeight.Text)
        lbRatioDiff_TT.Text = Format((chkValue - 100) + lbRatioAct_TT.Text, "#,##0.00")
        chkObj(lbRatioDiff_TT, lbRatioDiff_TT.Text)
        lbRatioDiff_TTProfit.Text = Format((chkValue - 100) + lbRatioAct_TTProfit.Text, "#,##0.00")
        chkObj(lbRatioDiff_TTProfit, lbRatioDiff_TTProfit.Text)

        lbRatioPerf_Sales.Text = Format(chkValue + (((lbPerf_Sales.Text - lbStd_Sales.Text) / lbStd_Sales.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_Sales, lbRatioPerf_Sales.Text)
        lbRatioPerf_Profit.Text = Format(chkValue + (((lbPerf_Profit.Text - lbStd_Profit.Text) / lbStd_Profit.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_Profit, lbRatioPerf_Profit.Text)
        lbRatioPerf_GP.Text = Format(chkValue + (((lbPerf_GP.Text - lbStd_GP.Text) / lbStd_GP.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_GP, lbRatioPerf_GP.Text)
        lbRatioPerf_GPProfit.Text = Format(chkValue + (((lbPerf_GPProfit.Text - lbStd_GPProfit.Text) / lbStd_GPProfit.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_GPProfit, lbRatioPerf_GPProfit.Text)
        lbRatioPerf_GPWeight.Text = Format(chkValue + (((lbPerf_GPWeight.Text - lbStd_GPWeight.Text) / lbStd_GPWeight.Text) * 100), "#,##.00")
        chkObj(lbRatioPerf_GPWeight, lbRatioPerf_GPWeight.Text)
        lbRatioPerf_TT.Text = Format(chkValue + (((lbPerf_TT.Text - lbStd_TT.Text) / lbStd_TT.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_TT, lbRatioPerf_TT.Text)
        lbRatioPerf_TTProfit.Text = Format(chkValue + (((lbPerf_TTProfit.Text - lbStd_TTProfit.Text) / lbStd_TTProfit.Text) * 100), "#,##0.00")
        chkObj(lbRatioPerf_TTProfit, lbRatioPerf_TTProfit.Text)


        seriesCus.ChartType = SeriesChartType.Pie
        lbRatio_CusItem0.Text = Format((((lbCusItem0.Text - lbCusItem.Text) / lbCusItem.Text) * 100) + 100, "#,##0.00")
        lbRatio_CusItem1M.Text = Format((((lbCusItem1M.Text - lbCusItem.Text) / lbCusItem.Text) * 100) + 100, "#,##0.00")
        lbRatio_CusItem2M.Text = Format((((lbCusItem2M.Text - lbCusItem.Text) / lbCusItem.Text) * 100) + 100, "#,##0.00")
        lbRatio_CusItem6M.Text = Format((((lbCusItem6M.Text - lbCusItem.Text) / lbCusItem.Text) * 100) + 100, "#,##0.00")
        seriesCusActive.ChartType = SeriesChartType.Pie
        With seriesCusActive

            .Points.AddXY("ขาดติดต่อกว่า 6M", lbRatio_CusItem6M.Text)
            .Points(0).Color = Color.Brown

            .Points.AddXY("ขาดติดต่อ 2M", lbRatio_CusItem2M.Text)
            .Points(1).Color = Color.DarkOrange

            .Points.AddXY("ขาดติดต่อ 1M", lbRatio_CusItem1M.Text)
            .Points(2).Color = Color.Yellow

            .Points.AddXY("ปกติ", lbRatio_CusItem0.Text)
            .Points(3).Color = Color.YellowGreen 'OliveDrab


            .Font = New Font("Microsoft Sans Serif", 24)
            .LabelFormat = "#,##0.00"

            .BorderWidth = 4
            .IsValueShownAsLabel = True  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ

            ' Label.Font = New Font("Comic Sans MS", 12, FontStyle.Bold Or FontStyle.Underline)
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า


        End With

        '============================================================

        seriesCus.Points.AddXY("ขาดติดต่อกว่า 6M", lbRatio_CusItem6M.Text)
        seriesCus.Points(0).Color = Color.Brown 'Crimson
        seriesCus.Points.AddXY("ขาดติดต่อ 2M", lbRatio_CusItem2M.Text)
        seriesCus.Points(1).Color = Color.DarkOrange
        seriesCus.Points.AddXY("ขาดติดต่อ 1M", lbRatio_CusItem1M.Text)
        seriesCus.Points(2).Color = Color.Yellow

        seriesCus.Points.AddXY("ปกติ", lbRatio_CusItem0.Text)
        seriesCus.Points(3).Color = Color.YellowGreen

        'seriesCus..ChartAreas(0).AxisX.LabelStyle.Font = New Font("Verdana", 28)
        seriesCus.LabelFormat = "#,##0.00"
        seriesCus.BorderWidth = 4
        seriesCus.IsValueShownAsLabel = True  '  แสดงค่าบนกราฟ
        seriesCus.IsVisibleInLegend = True  ' แสดงป้ายชื่อข้างกราฟ
        seriesCus.LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
        seriesCus.LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า

        '======================================================================
        seriesYear.Points.AddXY("Target", lbRatioDiff_Profit.Text)

        If chk100.Checked = True Then
            seriesYear.Points.AddXY("Act", (lbRatioAct_Profit.Text) + 100)
        Else
            seriesYear.Points.AddXY("Act", (lbRatioAct_Profit.Text))
        End If


        seriesYear.ChartType = SeriesChartType.Pie
        seriesYear.Palette = ChartColorPalette.BrightPastel
        'seriesPrice.Palette = ChartColorPalette.BrightPastel
        'seriesYear.Color = Color.OrangeRed
        seriesYear.LabelForeColor = Color.Black
        seriesYear.LabelBackColor = Color.YellowGreen

        seriesYear.LabelFormat = "#,##0.00"
        seriesYear.BorderWidth = 4
        seriesYear.IsValueShownAsLabel = True  '  แสดงค่าบนกราฟ
        seriesYear.IsVisibleInLegend = True  ' แสดงป้ายชื่อข้างกราฟ
        seriesYear.LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
        seriesYear.LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        'seriesYear.BorderWidth = 4   '  กำหนดขนาดเส้นของกราฟเส้น
        'seriesYear.YAxisType = AxisType.Primary

        With chartYear
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(seriesYear)
            '.Series.Add(seriesPrice)

        End With
        With chartCusItem
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(seriesCus)
            '.Series.Add(seriesPrice)

        End With
        With chartCusActive
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(seriesCusActive)

        End With
        anyData = New String() {"", "", "", "", "", "", dblTotalTargetYear.ToString("#,##0.00"), dblTotalSumAmt.ToString("#,##0.00"), ""}
        lvi = New ListViewItem(anyData)
        lsvDetail.Items.Add(lvi)
        lvi.BackColor = Color.Black 'CornflowerBlue 'LightSteelBlue 'DarkOrange
        lvi.ForeColor = Color.Yellow
        lbTotalAmt.Text = Format(dblTotalSumAmt, "#,##0.00")
        lbTotalTarget.Text = Format(dblTotalTargetYear, "#,##0.00")
        lbDifAmt.Text = Format(lbTotalAmt.Text - lbTotalTarget.Text, "#,##0.00")

        Call showDailyRpt()

    End Sub

    Sub showDailyRpt()


        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        Dim strCScode As String = ""
        strCScode = lbCScode.Text

        txtSQL = "Select Trh_Type,Trh_ProD_Sales,"
        txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(isnull(Trh_D_Amt-Trh_Cost_Amt,0))as Trh_Profit "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join  TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=TranDataH.Trh_Cus  "
        '===========================================================================================

        txtSQL = txtSQL & " "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And ((Trh_Type='S' or Trh_Type='B' ) "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And ( Year(Trh_Date) =year (GETDATE())  )  "
        txtSQL = txtSQL & "And ( Day(Trh_Date)  =Day  (GetDate())  ) "
        txtSQL = txtSQL & "And ( Month(Trh_Date)=month(GetDate())  )  "

        '===========================================================================================
        If selOptSL = 0 Then
            txtSQL = txtSQL & "And  Ar_CS='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        Else
            txtSQL = txtSQL & "And  Ar_Sales='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        End If
        '===========================================================================================
        txtSQL = txtSQL & "Group by Trh_Type,Trh_ProD_Sales "
        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")

        For i = 0 To subDS.Tables("csShow").Rows.Count - 1
            With subDS.Tables("csShow").Rows(i)
                If .Item("Trh_Type") = "B" Then
                    If IsDBNull(.Item("Trh_Prod_Sales")) Then
                        lbOrder_Sales.Text = Format(.Item("Trh_D_Amt") + lbOrder_Sales.Text, "#,##0.00")
                        lbOrder_Profit.Text = Format(.Item("Trh_Profit") + lbOrder_Profit.Text, "#,##0.00")
                        lbOrder_GPWeight.Text = Format(.Item("Trh_W") + lbOrder_GPWeight.Text, "#,##0.00")
                    Else
                        If .Item("Trh_Prod_Sales") = "01" Then

                            lbOrder_Sales.Text = Format(.Item("Trh_D_Amt") + lbOrder_Sales.Text, "#,##0.00")
                            lbOrder_Profit.Text = Format(.Item("Trh_Profit") + lbOrder_Profit.Text, "#,##0.00")

                            lbOrder_GP.Text = Format(.Item("Trh_D_Amt") + lbOrder_GP.Text, "#,##0.00")
                            lbOrder_GPProfit.Text = Format(.Item("Trh_Profit") + lbOrder_GPProfit.Text, "#,##0.00")
                            lbOrder_GPWeight.Text = Format(.Item("Trh_W") + lbOrder_GPWeight.Text, "#,##0.00")

                        ElseIf .Item("Trh_Prod_Sales") = "02" Or .Item("Trh_Prod_Sales") = "05" Then

                            lbOrder_Sales.Text = Format(.Item("Trh_D_Amt") + lbOrder_Sales.Text, "#,##0.00")
                            lbOrder_Profit.Text = Format(.Item("Trh_Profit") + lbOrder_Profit.Text, "#,##0.00")

                            lbOrder_TT.Text = Format(.Item("Trh_D_Amt") + lbOrder_TT.Text, "#,##0.00")
                            lbOrder_TTProfit.Text = Format(.Item("Trh_Profit") + lbOrder_TTProfit.Text, "#,##0.00")


                        End If
                    End If



                ElseIf .Item("TRh_Type") = "S" Then
                    If .Item("Trh_Prod_Sales") = "01" Then

                        lbDaily_Sales.Text = Format(.Item("Trh_D_Amt"), "#,##0.00")
                        lbDaily_Profit.Text = Format(.Item("Trh_Profit"), "#,##0.00")

                        lbDaily_GP.Text = Format(.Item("Trh_D_Amt"), "#,##0.00")
                        lbDaily_GPProfit.Text = Format(.Item("Trh_Profit"), "#,##0.00")
                        lbDaily_GPWeight.Text = Format(.Item("Trh_w"), "#,##0.00")

                    ElseIf .Item("Trh_Prod_Sales") = "02" Or .Item("Trh_Prod_Sales") = "05" Then
                        lbDaily_Sales.Text = Format(lbDaily_Sales.Text + .Item("Trh_D_Amt"), "#,##0.00")
                        lbDaily_Profit.Text = Format(lbDaily_Profit.Text + .Item("Trh_Profit"), "#,##0.00")

                        lbDaily_TT.Text = Format(.Item("Trh_D_Amt") + lbDaily_TT.Text, "#,##0.00")
                        lbDaily_TTProfit.Text = Format(.Item("Trh_Profit") + lbDaily_TTProfit.Text, "#,##0.00")
                    End If



                End If
            End With
        Next
        '==================================================================================
        lbOrRatio_Sales.Text = Format((((lbOrder_Sales.Text - lbStd_Sales.Text) / lbStd_Sales.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_Sales, lbOrRatio_Sales.Text)
        lbOrRatio_Profit.Text = Format((((lbOrder_Profit.Text - lbStd_Profit.Text) / lbStd_Profit.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_Profit, lbOrRatio_Profit.Text)

        lbOrRatio_GP.Text = Format((((lbOrder_GP.Text - lbStd_GP.Text) / lbStd_GP.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_GP, lbOrRatio_GP.Text)
        lbOrRatio_GPProfit.Text = Format((((lbOrder_GPProfit.Text - lbStd_GPProfit.Text) / lbStd_GPProfit.Text) * 100), "")
        chkObj(lbOrRatio_GPProfit, lbOrRatio_GPProfit.Text)
        lbOrRatio_GPWeight.Text = Format((((lbOrder_GPWeight.Text - lbStd_GPWeight.Text) / lbStd_GPWeight.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_GPWeight, lbOrRatio_GPWeight.Text)

        lbOrRatio_TT.Text = Format((((lbOrder_TT.Text - lbStd_TT.Text) / lbStd_TT.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_TT, lbOrRatio_TT.Text)
        lbOrRatio_TTProfit.Text = Format((((lbOrder_TTProfit.Text - lbStd_TTProfit.Text) / lbStd_TTProfit.Text) * 100), "#,##0.00")
        chkObj(lbOrRatio_TTProfit, lbOrRatio_TTProfit.Text)
        '==================================================================================
        lbSLRatio_Sales.Text = Format((((lbDaily_Sales.Text - lbStd_Sales.Text) / lbStd_Sales.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_Sales, lbSLRatio_Sales.Text)
        lbSLRatio_Profit.Text = Format((((lbDaily_Profit.Text - lbStd_Profit.Text) / lbStd_Profit.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_Profit, lbSLRatio_Profit.Text)
        lbSLRatio_GP.Text = Format((((lbDaily_GP.Text - lbStd_GP.Text) / lbStd_GP.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_GP, lbSLRatio_GP.Text)
        lbSLRatio_GPProfit.Text = Format((((lbDaily_GPProfit.Text - lbStd_GPProfit.Text) / lbStd_GPProfit.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_GPProfit, lbSLRatio_GPProfit.Text)
        lbSLRatio_GPWeight.Text = Format((((lbDaily_GPWeight.Text - lbStd_GPWeight.Text) / lbStd_GPWeight.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_GPWeight, lbSLRatio_GPWeight.Text)
        lbSLRatio_TT.Text = Format((((lbDaily_TT.Text - lbStd_TT.Text) / lbStd_TT.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_TT, lbSLRatio_TT.Text)
        lbSLRatio_TTProfti.Text = Format((((lbDaily_TTProfit.Text - lbStd_TTProfit.Text) / lbStd_TTProfit.Text) * 100), "#,##0.00")
        chkObj(lbSLRatio_TTProfti, lbSLRatio_TTProfti.Text)
        '==================================================================================
        txtSQL = "Select Trh_Type,Trh_Date,"
        txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,"
        txtSQL = txtSQL & "sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Trh_Profit "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join  TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=TranDataH.Trh_Cus  "
        ''===========================================================================================

        'txtSQL = txtSQL & " "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And ((Trh_Type='S'  ) "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "

        txtSQL = txtSQL & "And ( Year(Trh_Date) =year (GETDATE())  )  "
        'txtSQL = txtSQL & "And ( Day(Trh_Date)  =Day  (GetDate())  ) "
        txtSQL = txtSQL & "And ( Month(Trh_Date)=month(GetDate())  )  "

        '===========================================================================================
        If selOptSL = 0 Then
            txtSQL = txtSQL & "And  Ar_CS='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        Else
            txtSQL = txtSQL & "And  Ar_Sales='" & strCScode & "' "
            txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        End If
        ''===========================================================================================
        txtSQL = txtSQL & "Group by Trh_Type,TRh_Date  "
        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csMonthly")

        Dim seriesAct As New Series
        Dim seriesStd As New Series
        Dim seriesAvg As New Series

        chartAct.Series.Clear()
        For M = 0 To subDS.Tables("csMonthly").Rows.Count - 1
            With subDS.Tables("csMonthly").Rows(M)
                Dim stdDate As Date = Format(DateAdd(DateInterval.Year, -543, .Item("Trh_Date")), "dd/MM/yyyy")
                '============================================================
                seriesStd.Points.AddXY(stdDate, lbStd_Profit.Text)
                seriesAct.Points.AddXY(stdDate, .Item("Trh_Profit"))
                seriesAvg.Points.AddXY(stdDate, lbPerf_Profit.Text)
            End With
        Next

        '============================================================
        With seriesStd
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.Red
            .LabelFormat = "#,##0.00"
            .BorderWidth = 1
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        With seriesAvg
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.DeepSkyBlue
            .LabelFormat = "#,##0.00"
            .BorderWidth = 1
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        With seriesAct
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.Green
            .LabelFormat = "#,##0.00"
            .BorderWidth = 1
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        Dim ChartM As New ChartArea
        ChartM.BackColor = Color.Black
        With ChartM
            .BorderColor = Color.White
            .BorderWidth = 1
        End With
        chartAct.ChartAreas.Clear()
        '============================================================
        With chartAct
            .ChartAreas.Add(ChartM)
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(seriesAct)
            .Series.Add(seriesStd)
            .Series.Add(seriesAvg)
            '.Series.Add(seriesPrice)
        End With

    End Sub


    Sub chkObj(obj0 As Object, dblValue As Double)

        If dblValue < 0 Then
            obj0.backcolor = Color.Black
            obj0.forecolor = Color.Red
        Else
            obj0.backcolor = Color.Black
            obj0.forecolor = Color.GreenYellow
        End If

    End Sub

    Sub txtCLS()
        lbTarget_Sales.Text = Format(0, "#,##0.00")
        lbTarget_Profit.Text = Format(0, "#,##0.00")
        lbTarget_GP.Text = Format(0, "#,##0.00")
        lbTarget_GPProfit.Text = Format(0, "#,##0.00")
        lbTarget_GPWeight.Text = Format(0, "#,##0.00")

        lbTarget_TT.Text = Format(0, "#,##0.00")
        lbTarget_TTProfit.Text = Format(0, "#,##0.00")

        lbAct_Sales.Text = Format(0, "#,##0.00")
        lbAct_Profit.Text = Format(0, "#,##0.00")

        lbAct_GP.Text = Format(0, "#,##0.00")
        lbAct_GPProfit.Text = Format(0, "#,##0.00")
        lbAct_GPweight.Text = Format(0, "#,##0.00")
        lbAct_TT.Text = Format(0, "#,##0.00")
        lbAct_TTProfit.Text = Format(0, "#,##0.00")

        lbDiff_TargetSales.Text = Format(0, "#,##0.00")
        lbDiff_TargetProfit.Text = Format(0, "#,##0.00")
        lbDiff_TargetGP.Text = Format(0, "#,##0.00")
        lbDiff_TargetGPPrifit.Text = Format(0, "#,##0.00")
        lbDiff_TargetGPWeight.Text = Format(0, "#,##0.00")
        lbDiff_TargetTT.Text = Format(0, "#,##0.00")
        lbDiff_TargetTTProfit.Text = Format(0, "#,##0.00")

        lbDaily_Sales.Text = Format(0, "#,##0.00")
        lbDaily_Profit.Text = Format(0, "#,##0.00")
        lbDaily_GP.Text = Format(0, "#,##0.00")
        lbDaily_GPProfit.Text = Format(0, "#,##0.00")
        lbDaily_GPWeight.Text = Format(0, "#,##0.00")
        lbDaily_TT.Text = Format(0, "#,##0.00")
        lbDaily_TTProfit.Text = Format(0, "#,##0.00")

        lbOrder_Sales.Text = Format(0, "#,##0.00")
        lbOrder_Profit.Text = Format(0, "#,##0.00")
        lbOrder_GP.Text = Format(0, "#,##0.00")
        lbOrder_GPProfit.Text = Format(0, "#,##0.00")
        lbOrder_GPWeight.Text = Format(0, "#,##0.00")
        lbOrder_TT.Text = Format(0, "#,##0.00")
        lbOrder_TTProfit.Text = Format(0, "#,##0.00")



        lbSim_Target.Text = Format(0, "#,##0.00")
        lbSim_Profit.Text = Format(0, "#,##0.00")
        lbSim_GPtarget.Text = Format(0, "#,##0.00")
        lbSim_GPProfit.Text = 0 'Format(lbDiff_TargetGPPrifit.Text / lbDayQty.Text, "#,##0.00")
        lbSim_GPWeight.Text = 0 'Format(lbDiff_TargetGPWeight.Text / lbDayQty.Text, "#,##0.00")
        lbSim_TT.Text = 0 ' Format(lbDiff_TargetTT.Text / lbDayQty.Text, "#,##0.00")
        lbSim_TTProfit.Text = 0 ' Format(lbDiff_TargetTTProfit.Text / lbDayQty.Text, "#,##0.00")

        lbPerf_Sales.Text = 0 ' Format(lbAct_Sales.Text / lbActDay.Text, "#,##0.00")
        lbPerf_Profit.Text = 0 ' Format(lbAct_Profit.Text / lbActDay.Text, "#,##0.00")
        lbPerf_GP.Text = 0 'Format(lbAct_GP.Text / lbActDay.Text, "#,##0.00")
        lbPerf_GPProfit.Text = 0 ' Format(lbAct_GPProfit.Text / lbActDay.Text, "#,##0.00")
        lbPerf_GPWeight.Text = 0 'Format(lbAct_GPweight.Text / lbActDay.Text, "#,##0.00")
        lbPerf_TT.Text = 0 ' Format(lbAct_TT.Text / lbActDay.Text, "#,##0.00")
        lbPerf_TTProfit.Text = 0 ' Format(lbAct_TTProfit.Text / lbActDay.Text, "#,##0.00")

        lbStd_Sales.Text = 0 'Format(lbTarget_Sales.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_Profit.Text = 0 ' Format(lbTarget_Profit.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_GP.Text = 0 ' Format(lbTarget_GP.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_GPProfit.Text = 0 'Format(lbTarget_GPProfit.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_GPWeight.Text = 0 ' Format(lbTarget_GPWeight.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_TT.Text = 0 '(lbTarget_TT.Text / lbDayQty0.Text, "#,##0.00")
        lbStd_TTProfit.Text = 0 'Format(lbTarget_TTProfit.Text / lbDayQty0.Text, "#,##0.00")

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
        If frmLoad = True Then
            Call showData()
        End If
    End Sub

    Private Sub optOrdLastDate_CheckedChanged(sender As Object, e As EventArgs) Handles optOrdLastDate.CheckedChanged
        If frmLoad = True Then
            Call showData()
        End If
    End Sub

    Private Sub optOrdSumSales_CheckedChanged(sender As Object, e As EventArgs) Handles optOrdSumSales.CheckedChanged
        If frmLoad = True Then
            Call showData()
        End If

    End Sub

    Private Sub cmbUpdate_Click(sender As Object, e As EventArgs) Handles cmbUpdate.Click

        If frmLoad = True Then
            Call showData()
        End If
    End Sub

    Private Sub lbTotalTarget_Click(sender As Object, e As EventArgs) Handles lbTotalTarget.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub chk100_Click(sender As Object, e As EventArgs) Handles chk100.Click
        If frmLoad = True Then
            If chk100.Checked = True Then
                chkValue = 100
            ElseIf chk0.Checked = True Then
                chkValue = 0
            End If
            showData()
        End If

    End Sub

    Private Sub chk0_Click(sender As Object, e As EventArgs) Handles chk0.Click
        If frmLoad = True Then
            If chk100.Checked = True Then
                chkValue = 100
            ElseIf chk0.Checked = True Then
                chkValue = 0
            End If
            showData()
        End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub cmbRptDetl_Click(sender As Object, e As EventArgs) Handles cmbRptDetl.Click
        Dim frmSalesDetl As New frmSalesDetl
        frmSalesDetl.ShowDialog()

    End Sub

    Private Sub chartAct_Click(sender As Object, e As EventArgs) Handles chartAct.Click

    End Sub

    Private Sub chartAct_DoubleClick(sender As Object, e As EventArgs) Handles chartAct.DoubleClick
        Dim frmchartKPI As New frmChartKPI
        frmchartKPI.ShowDialog()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class