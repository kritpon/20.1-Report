Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMenu
    Dim chkValue As Integer = 0
    Dim txtSQL As String = ""
    Dim chkSCData As Boolean = False
    Dim chkSLData As Boolean = False
    Dim chkRevData As Boolean = False
    Dim chkTypeD As Boolean = False
    Dim chkTypeS As Boolean = False
    Dim chkNewCus As Boolean = False

    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet
    Dim chkLoad As Boolean = False
    Public sales As New salesObj
    Dim strDate As Date = "03/01/2562"
    Dim endDate As Date = "28/12/2562"

    Private Sub cmbRptDetail_Click(sender As Object, e As EventArgs) Handles cmbRptDetail.Click
        'Dim frmRptDetail As New frmBegin
        'Me.frmrptdetail
        ' Me.Hide()
        ''frmRptDetail.MdiParent
        Dim frmRptDetail As New frmBegin


        Timer1.Enabled = False
        frmRptDetail.Show()
        'Me.Show()
        ''frmRptDetail.ShowDialog()
        'Dim frmMenu As New frmMenu
        'Me.frmMenu.MdiParent = Me
        'frmMenu.Show()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
        End

    End Sub

    Private Sub cmdRptStkRun_Click(sender As Object, e As EventArgs) Handles cmdRptStkRun.Click
        'Me.MinimumSize

        Dim frmRPTstkSummary As New frmStkSummary
        Timer1.Enabled = False
        frmRPTstkSummary.Show()




    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0



        i = calDayWork(Now, endDate) - 13
        lbDayWorkQty.Text = i
        lbDayWork0.Text = calDayWork(strDate, endDate) - 13  '  13 ที่ลบที่หลังคือ ลบวันหยุด 13 วันต่อปี
        lbDayAct.Text = lbDayWork0.Text - lbDayWorkQty.Text

        chkLoad = True

        sales.crt_SalesMan()
        getSales()

        optRatio.Checked = True
        lbProfitUnit_SL.Text = "กำไร Sales (%)"
        lbProfitUnit_CS.Text = "กำไร CS (%)"
        lbWeightUnit_SL.Text = "น้ำหนัก Sales (%)"
        lbWeightUnit_CS.Text = "น้ำหนัก CS (%)"
        lbAmtUnit_SL.Text = "มูลค่าขาย Sales (%)"
        lbAmtUnit_CS.Text = "มูลค่าขาย CS (%)"

        Call CS_totalTargetYear()
        Call totalTargetYear()  '  new  2562

        runAllProgram()

        lbTimer.Text = Format(Now, "HH:mm:ss")
        'frmRPTstkSummary.MdiParent = Me
        'frmRptDetail.MdiParent = Me


    End Sub
    Sub getSales()
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * from SalesMan "
        txtSQL = txtSQL & "Where SL_Off=0 "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "salesMan")
        For i = 0 To subDS.Tables("salesMan").Rows.Count - 1
            With subDS.Tables("salesMan").Rows(i)
                sales.addNewSales("SL", .Item("SL_ID"), .Item("SL_nickName"))
            End With
        Next

        txtSQL = "Select * from CSMast "
        txtSQL = txtSQL & "Where CS_Off=0 "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "CSMast")
        For i = 0 To subDS.Tables("CSMast").Rows.Count - 1
            With subDS.Tables("CSMast").Rows(i)
                sales.addNewSales("CS", .Item("CS_Code"), .Item("CS_Name"))
            End With
        Next

    End Sub

    Sub CS_totalTargetYear()

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        ' Label86.Text = DateTime.DaysInMonth("2019", 1)  วิธีคำนวนจำนวนวันในเดือน
        ' strCScode = lbCScode.Text

        'If chk100.Checked = True Then
        '    chkValue = 100
        'ElseIf chk0.Checked = True Then
        '    chkValue = 0
        'End If

        txtSQL = "Select Ar_Cus_ID,Ar_Name,(Ar_CS)as Ar_Sales,"
        'txtSQL = "Select "

        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_D_Amt,0))as sumTrh_D_AmtNow,"
        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_W,0))as sumTrh_WNow,"
        txtSQL = txtSQL & "sum(isnull(Trhnow.Trh_Cost,0))as sumTrh_Cost,"
        txtSQL = txtSQL & "sum(isnull(Trhnow.Profit,0))as sumTrh_Profit,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actGPSales, "

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_W,0) else  0 end ) as actGPWeight, "

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(Trhnow.Profit,0) else  0 end ) as actGPProfit, "

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actTTSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Profit,0) else  0 end ) as actTTProfit, "

        ' txtSQL = txtSQL & "(isnull(Ar_Sales_Target,0))as sumTarget, "  ' ข้อมูล sales  ประเมินยอดขาย
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
        txtSQL = txtSQL & "Left Join CSmast "
        txtSQL = txtSQL & "ON Ar_CS=CS_Code "

        'txtSQL = txtSQL & "Left Join AmphoeMast "
        'txtSQL = txtSQL & "On ArFile.Ar_Amphoe_Code=AmphoeMast.Amphoe_Code "

        txtSQL = txtSQL & "Left Join  "
        '===========================================================================================
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,Trh_ProD_Sales,sum(Trh_D_Amt)as Trh_D_Amt,sum(Trh_Cost_Amt)as Trh_Cost,sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Profit "

        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (TRh_Prod_Sales='01' or Trh_Prod_Sales='02' or Trh_Prod_Sales='05' ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        'txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        'txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' or Trh_Sale='SL99' ) "
        txtSQL = txtSQL & "Group by Trh_Cus,Trh_ProD_Sales "
        txtSQL = txtSQL & " ) TrHNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "
        '===========================================================================================
        'If selOptSL = 0 Then
        '    txtSQL = txtSQL & "Where   Ar_CS='" & strCScode & "' "

        'Else
        '    txtSQL = txtSQL & "Where   Ar_Sales='" & strCScode & "' "

        'End If
        txtSQL = txtSQL & "Where CS_off='0' "
        txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        '===========================================================================================

        txtSQL = txtSQL & "Group by  AR_CUS_ID,Ar_Name,Ar_CS,"
        txtSQL = txtSQL & "Ar_SL_Target,Ar_Profit,AR_GP_SL_Target,Ar_GP_W_Target,"
        txtSQL = txtSQL & "Ar_GP_Profit,Ar_TT_SL_Target,Ar_TT_Profit "

        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "TargetShow")
        'lbStd_Sales.Text = 0
        'lbStd_Profit.Text = 0
        'lbStd_GP.Text = 0
        'lbStd_GPProfit.Text = 0
        'lbStd_GPWeight.Text = 0
        'lbStd_TT.Text = 0
        'lbStd_TTProfit.Text = 0

        'lbPerf_Sales.Text = 0
        'lbPerf_Profit.Text = 0
        'lbPerf_GP.Text = 0
        'lbPerf_GPProfit.Text = 0
        'lbPerf_GPWeight.Text = 0
        'lbPerf_TT.Text = 0
        'lbPerf_TTProfit.Text = 0

        'lbTarget_Sales.Text = 0
        'lbTarget_Profit.Text = 0
        'lbTarget_GP.Text = 0
        'lbTarget_GPProfit.Text = 0
        'lbTarget_GPWeight.Text = 0

        'lbTarget_TT.Text = 0
        'lbTarget_TTProfit.Text = 0

        'lbAct_Profit.Text = 0
        'lbAct_Sales.Text = 0
        'lbAct_GP.Text = 0
        'lbAct_GPProfit.Text = 0
        'lbAct_GPweight.Text = 0

        'lbAct_TT.Text = 0
        'lbAct_TTProfit.Text = 0


        'lbDiff_TargetSales.Text = 0
        'lbDiff_TargetProfit.Text = 0

        'lbDiff_TargetGP.Text = 0
        'lbDiff_TargetGPProfit.Text = 0
        Label93.Text = 0
        For i = 0 To subDS.Tables("TargetShow").Rows.Count - 1

            With subDS.Tables("TargetShow").Rows(i)

                'lbTarget_Sales.Text = Format(.Item("SLTarget") + lbTarget_Sales.Text, "#,##0.00")
                'lbTarget_Profit.Text = Format(.Item("SLProfit") + lbTarget_Profit.Text, "#,##0.00")
                'lbTarget_GP.Text = Format(.Item("GP_Target") + lbTarget_GP.Text, "#,##0.00")
                'lbTarget_GPProfit.Text = Format(.Item("GP_Profit") + lbTarget_GPProfit.Text, "#,##0.00")
                'lbTarget_GPWeight.Text = Format(.Item("GP_W_Target") + lbTarget_GPWeight.Text, "#,##0.00")
                'lbTarget_TT.Text = Format(.Item("TT_Target") + lbTarget_TT.Text, "#,##0.00")
                'lbTarget_TTProfit.Text = Format(.Item("TT_Profit") + lbTarget_TTProfit.Text, "#,##0.00")

                sales.setTarget(.Item("Ar_Sales"), .Item("SLTarget"), .Item("SLProfit"),
                                .Item("GP_Target"), .Item("GP_Profit"), .Item("GP_W_Target"),
                                .Item("TT_Target"), .Item("TT_Profit"))


                sales.setAct(.Item("Ar_Sales"), .Item("sumTrh_D_AmtNow"), .Item("sumTrh_Profit"),
                             .Item("actGPSales"), .Item("sumTrh_Cost"), .Item("actGPProfit"), .Item("sumTrh_Wnow"),
                             .Item("actTTSales"), .Item("actTTProfit"))



                'lbAct_Profit.Text = Format(.Item("sumTrh_Profit") + lbAct_Profit.Text, "#,##0.00")
                'lbAct_Sales.Text = Format(.Item("sumTrh_AmtNow") + lbAct_Sales.Text, "#,##0.00")
                'lbAct_GP.Text = Format(.Item("actGPSales") + lbAct_GP.Text, "#,##0.00")
                'lbAct_GPProfit.Text = Format(.Item("actGPProfit") + lbAct_GPProfit.Text, "#,##0.00")
                'lbAct_GPweight.Text = Format(.Item("sumTrh_Wnow") + lbAct_GPweight.Text, "#,##0.00")

                'lbAct_TT.Text = Format(.Item("actTTSales") + lbAct_TT.Text, "#,##0.00")
                'lbAct_TTProfit.Text = Format(.Item("actTTProfit") + lbAct_TTProfit.Text, "#,##0.00")

            End With

        Next
        'Dim viewSales As New DataView(sales.SalesMan)
        'viewSales.RowFilter = "Type='SL'  "
        'viewSales.Sort = "Profit_D desc"
        'For Each row As DataRowView In viewSales

        '    'For d = 0 To view.Table.Rows.Count - 1
        '    With viewSales.Table
        '        Dim targetSales As Double = row.Item("Target_Sales")

        '        lbTarget_Sales.Text = Format(lbTarget_Sales.Text + targetSales, "#,##0.00")
        '        lbTarget_Profit.Text = Format(lbTarget_Profit.Text + row.Item("Target_Profit"), "#,##0.00")
        '        lbTarget_GP.Text = Format(lbTarget_GP.Text + row.Item("Target_GP_Sales"), "#,##0.00")
        '        lbTarget_GPProfit.Text = Format(lbTarget_GPProfit.Text + row.Item("Target_GP_Profit"), "#,##0.00")
        '        lbTarget_GPWeight.Text = Format(lbTarget_GPWeight.Text + row.Item("Target_GP_Weight"), "#,##0.00")
        '        lbTarget_TT.Text = Format(lbTarget_TT.Text + row.Item("Target_TT_Sales"), "#,##0.00")
        '        lbTarget_TTProfit.Text = Format(lbTarget_TTProfit.Text + row.Item("Target_TT_Profit"), "#,##0.00")

        '        lbAct_Sales.Text = Format(lbAct_Sales.Text + row.Item("Act_Target"), "#,##0.00")
        '        lbAct_Profit.Text = Format(lbAct_Profit.Text + row.Item("Act_Profit"), "#,##0.00")
        '        lbAct_GP.Text = Format(lbAct_GP.Text + row.Item("Act_GP_Sales"), "#,##0.00")
        '        lbAct_GPProfit.Text = Format(lbAct_GPProfit.Text + row.Item("Act_GP_Profit"), "#,##0.00")
        '        lbAct_GPweight.Text = Format(lbAct_GPweight.Text + row.Item("Act_GP_Weight"), "#,##0.00")
        '        lbAct_TT.Text = Format(lbAct_TT.Text + row.Item("Act_TT_Sales"), "#,##0.00")
        '        lbAct_TTProfit.Text = Format(lbAct_TTProfit.Text + row.Item("Act_TT_Profit"), "#,##0.00")


        '    End With

        'Next


        'lbDiff_TargetSales.Text = Format(lbTarget_Sales.Text - lbAct_Sales.Text, "#,##0.00")
        'lbDiff_TargetProfit.Text = Format(lbTarget_Profit.Text - lbAct_Profit.Text, "#,##0.00")

        'lbDiff_TargetGP.Text = Format(lbTarget_GP.Text - lbAct_GP.Text, "#,##0.00")
        'lbDiff_TargetGPProfit.Text = Format(lbTarget_GPProfit.Text - lbAct_GPProfit.Text, "#,##0.00")
        'lbDiff_TargetGPWeight.Text = Format(lbTarget_GPWeight.Text - lbAct_GPweight.Text, "#,##0.00")

        'lbDiff_TargetTT.Text = Format(lbTarget_TT.Text - lbAct_TT.Text, "#,##0.00")
        'lbDiff_TargetTTProfit.Text = Format(lbTarget_TTProfit.Text - lbAct_TTProfit.Text, "#,##0.00")

        'lbSim_Target.Text = Format(lbDiff_TargetSales.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_Profit.Text = Format(lbDiff_TargetProfit.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_GPtarget.Text = Format(lbDiff_TargetGP.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_GPProfit.Text = Format(lbDiff_TargetGPProfit.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_GPWeight.Text = Format(lbDiff_TargetGPWeight.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_TT.Text = Format(lbDiff_TargetTT.Text / lbDayWorkQty.Text, "#,##0.00")
        'lbSim_TTProfit.Text = Format(lbDiff_TargetTTProfit.Text / lbDayWorkQty.Text, "#,##0.00")


        'lbStd_Sales.Text = Format(lbTarget_Sales.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_Profit.Text = Format(lbTarget_Profit.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_GP.Text = Format(lbTarget_GP.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_GPProfit.Text = Format(lbTarget_GPProfit.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_GPWeight.Text = Format(lbTarget_GPWeight.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_TT.Text = Format(lbTarget_TT.Text / lbDayWork0.Text, "#,##0.00")
        'lbStd_TTProfit.Text = Format(lbTarget_TTProfit.Text / lbDayWork0.Text, "#,##0.00")

        'lbPerf_Sales.Text = Format(lbAct_Sales.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_Profit.Text = Format(lbAct_Profit.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_GP.Text = Format(lbAct_GP.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_GPProfit.Text = Format(lbAct_GPProfit.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_GPWeight.Text = Format(lbAct_GPweight.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_TT.Text = Format(lbAct_TT.Text / lbDayAct.Text, "#,##0.00")
        'lbPerf_TTProfit.Text = Format(lbAct_TTProfit.Text / lbDayAct.Text, "#,##0.00")


        'lbRatioAct_Sales.Text = Format((((lbAct_Sales.Text - lbTarget_Sales.Text) / lbTarget_Sales.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_Sales, lbRatioAct_Sales.Text)
        'lbRatioAct_Profit.Text = Format((((lbAct_Profit.Text - lbTarget_Profit.Text) / lbTarget_Profit.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_Profit, lbRatioAct_Profit.Text)
        'lbRatioAct_GP.Text = Format((((lbAct_GP.Text - lbTarget_GP.Text) / lbTarget_GP.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_GP, lbRatioAct_GP.Text)
        'lbRatioAct_GPProFit.Text = Format((((lbAct_GPProfit.Text - lbTarget_GPProfit.Text) / lbTarget_GPProfit.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_GPProFit, lbRatioAct_GPProFit.Text)
        'lbRatioAct_GPWeight.Text = Format((((lbAct_GPweight.Text - lbTarget_GPWeight.Text) / lbTarget_GPWeight.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_GPWeight, lbRatioAct_GPWeight.Text)
        'lbRatioAct_TT.Text = Format((((lbAct_TT.Text - lbTarget_TT.Text) / lbTarget_TT.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_TT, lbRatioAct_TT.Text)
        'lbRatioAct_TTProfit.Text = Format((((lbAct_TTProfit.Text - lbTarget_TTProfit.Text) / lbTarget_TTProfit.Text) * 100) - (chkValue - 100), "#,##0.00")
        'chkObj(lbRatioAct_TTProfit, lbRatioAct_TTProfit.Text)


        'lbRatioDiff_Sales.Text = Format((chkValue - 100) + lbRatioAct_Sales.Text, "#,##0.00")
        'chkObj(lbRatioDiff_Sales, lbRatioDiff_Sales.Text)
        'lbRatioDiff_Profit.Text = Format((chkValue - 100) + lbRatioAct_Profit.Text, "#,##0.00")
        'chkObj(lbRatioDiff_Profit, lbRatioDiff_Profit.Text)
        'lbRatioDiff_GP.Text = Format((chkValue - 100) + lbRatioAct_GP.Text, "#,#0.00")
        'chkObj(lbRatioDiff_GP, lbRatioDiff_GP.Text)
        'lbRatioDiff_GPProfit.Text = Format((chkValue - 100) + lbRatioAct_GPProFit.Text, "#,##0.00")
        'chkObj(lbRatioDiff_GPProfit, lbRatioDiff_GPProfit.Text)
        'lbRatioDiff_GPWeight.Text = Format((chkValue - 100) + lbRatioAct_GPWeight.Text, "#,##0.00")
        'chkObj(lbRatioDiff_GPWeight, lbRatioDiff_GPWeight.Text)
        'lbRatioDiff_TT.Text = Format((chkValue - 100) + lbRatioAct_TT.Text, "#,##0.00")
        'chkObj(lbRatioDiff_TT, lbRatioDiff_TT.Text)
        'lbRatioDiff_TTProfit.Text = Format((chkValue - 100) + lbRatioAct_TTProfit.Text, "#,##0.00")
        'chkObj(lbRatioDiff_TTProfit, lbRatioDiff_TTProfit.Text)

        'lbRatioPerf_Sales.Text = Format(chkValue + (((lbPerf_Sales.Text - lbStd_Sales.Text) / lbStd_Sales.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_Sales, lbRatioPerf_Sales.Text)
        'lbRatioPerf_Profit.Text = Format(chkValue + (((lbPerf_Profit.Text - lbStd_Profit.Text) / lbStd_Profit.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_Profit, lbRatioPerf_Profit.Text)
        'lbRatioPerf_GP.Text = Format(chkValue + (((lbPerf_GP.Text - lbStd_GP.Text) / lbStd_GP.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_GP, lbRatioPerf_GP.Text)
        'lbRatioPerf_GPProfit.Text = Format(chkValue + (((lbPerf_GPProfit.Text - lbStd_GPProfit.Text) / lbStd_GPProfit.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_GPProfit, lbRatioPerf_GPProfit.Text)
        'lbRatioPerf_GPWeight.Text = Format(chkValue + (((lbPerf_GPWeight.Text - lbStd_GPWeight.Text) / lbStd_GPWeight.Text) * 100), "#,##.00")
        'chkObj(lbRatioPerf_GPWeight, lbRatioPerf_GPWeight.Text)
        'lbRatioPerf_TT.Text = Format(chkValue + (((lbPerf_TT.Text - lbStd_TT.Text) / lbStd_TT.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_TT, lbRatioPerf_TT.Text)
        'lbRatioPerf_TTProfit.Text = Format(chkValue + (((lbPerf_TTProfit.Text - lbStd_TTProfit.Text) / lbStd_TTProfit.Text) * 100), "#,##0.00")
        'chkObj(lbRatioPerf_TTProfit, lbRatioPerf_TTProfit.Text)


    End Sub

    Sub totalTargetYear()

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        ' Label86.Text = DateTime.DaysInMonth("2019", 1)  วิธีคำนวนจำนวนวันในเดือน
        ' strCScode = lbCScode.Text

        If chk100.Checked = True Then
            chkValue = 100
        ElseIf chk0.Checked = True Then
            chkValue = 0
        End If

        txtSQL = "Select Ar_Cus_ID,Ar_Sales,"
        'txtSQL = "Select "

        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_D_Amt,0))as sumTrh_D_AmtNow,"
        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_W,0))as sumTrh_WNow,"
        txtSQL = txtSQL & "sum(isnull(Trhnow.Trh_Cost,0))as sumTrh_Cost,"
        txtSQL = txtSQL & "sum(isnull(Trhnow.Profit,0))as sumTrh_Profit,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actGPSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_W,0) else  0 end ) as actGPWeight, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(Trhnow.Profit,0) else  0 end ) as actGPProfit, "

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_D_Amt,0) else  0 end ) as actTTSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='02' or Trhnow.Trh_ProD_Sales='05') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Profit,0) else  0 end ) as actTTProfit, "

        ' txtSQL = txtSQL & "(isnull(Ar_Sales_Target,0))as sumTarget, "  ' ข้อมูล sales  ประเมินยอดขาย
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
        txtSQL = txtSQL & "Left Join CSmast "
        txtSQL = txtSQL & "ON Ar_CS=CS_Code "

        'txtSQL = txtSQL & "Left Join AmphoeMast "
        'txtSQL = txtSQL & "On ArFile.Ar_Amphoe_Code=AmphoeMast.Amphoe_Code "

        txtSQL = txtSQL & "Left Join  "
        '===========================================================================================
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,Trh_ProD_Sales,sum(Trh_D_Amt)as Trh_D_Amt,sum(Trh_Cost_Amt)as Trh_Cost,sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Profit "

        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (TRh_Prod_Sales='01' or Trh_Prod_Sales='02' or Trh_Prod_Sales='05' ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        'txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        'txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' or Trh_Sale='SL99' ) "
        txtSQL = txtSQL & "Group by Trh_Cus,Trh_ProD_Sales "
        txtSQL = txtSQL & " ) TrHNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "
        '===========================================================================================
        'If selOptSL = 0 Then
        '    txtSQL = txtSQL & "Where   Ar_CS='" & strCScode & "' "

        'Else
        '    txtSQL = txtSQL & "Where   Ar_Sales='" & strCScode & "' "

        'End If
        txtSQL = txtSQL & "Where CS_off='0' "
        txtSQL = txtSQL & "and not(Ar_sales='SL03'or Ar_Sales='SL14' or Ar_Sales='SL12' or Ar_Sales='SL99' ) "

        '===========================================================================================

        txtSQL = txtSQL & "Group by  AR_CUS_ID,Ar_Sales,"
        txtSQL = txtSQL & "Ar_SL_Target,Ar_Profit,AR_GP_SL_Target,Ar_GP_W_Target,"
        txtSQL = txtSQL & "Ar_GP_Profit,Ar_TT_SL_Target,Ar_TT_Profit "

        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "TargetShow")
        lbStd_Sales.Text = 0
        lbStd_Profit.Text = 0
        lbStd_GP.Text = 0
        lbStd_GPProfit.Text = 0
        lbStd_GPWeight.Text = 0
        lbStd_TT.Text = 0
        lbStd_TTProfit.Text = 0

        lbPerf_Sales.Text = 0
        lbPerf_Profit.Text = 0
        lbPerf_GP.Text = 0
        lbPerf_GPProfit.Text = 0
        lbPerf_GPWeight.Text = 0
        lbPerf_TT.Text = 0
        lbPerf_TTProfit.Text = 0

        lbTarget_Sales.Text = 0
        lbTarget_Profit.Text = 0
        lbTarget_GP.Text = 0
        lbTarget_GPProfit.Text = 0
        lbTarget_GPWeight.Text = 0

        lbTarget_TT.Text = 0
        lbTarget_TTProfit.Text = 0

        lbAct_Profit.Text = 0
        lbAct_Sales.Text = 0
        lbAct_GP.Text = 0
        lbAct_GPProfit.Text = 0
        lbAct_GPweight.Text = 0

        lbAct_TT.Text = 0
        lbAct_TTProfit.Text = 0


        lbDiff_TargetSales.Text = 0
        lbDiff_TargetProfit.Text = 0

        lbDiff_TargetGP.Text = 0
        lbDiff_TargetGPProfit.Text = 0

        For i = 0 To subDS.Tables("TargetShow").Rows.Count - 1

            With subDS.Tables("TargetShow").Rows(i)

                'lbTarget_Sales.Text = Format(.Item("SLTarget") + lbTarget_Sales.Text, "#,##0.00")
                'lbTarget_Profit.Text = Format(.Item("SLProfit") + lbTarget_Profit.Text, "#,##0.00")
                'lbTarget_GP.Text = Format(.Item("GP_Target") + lbTarget_GP.Text, "#,##0.00")
                'lbTarget_GPProfit.Text = Format(.Item("GP_Profit") + lbTarget_GPProfit.Text, "#,##0.00")
                'lbTarget_GPWeight.Text = Format(.Item("GP_W_Target") + lbTarget_GPWeight.Text, "#,##0.00")
                'lbTarget_TT.Text = Format(.Item("TT_Target") + lbTarget_TT.Text, "#,##0.00")
                'lbTarget_TTProfit.Text = Format(.Item("TT_Profit") + lbTarget_TTProfit.Text, "#,##0.00")
                If .Item("Ar_Sales") = "SL22" Then
                    MsgBox("SL22")
                End If

                sales.setTarget(.Item("Ar_Sales"), .Item("SLTarget"), .Item("SLProfit"),
                                .Item("GP_Target"), .Item("GP_Profit"), .Item("GP_W_Target"),
                                .Item("TT_Target"), .Item("TT_Profit"))


                sales.setAct(.Item("Ar_Sales"), .Item("sumTrh_D_AmtNow"), .Item("sumTrh_Profit"),
                             .Item("actGPSales"), .Item("sumTrh_Cost"), .Item("actGPProfit"), .Item("sumTrh_Wnow"),
                             .Item("actTTSales"), .Item("actTTProfit"))


                'lbAct_Profit.Text = Format(.Item("sumTrh_Profit") + lbAct_Profit.Text, "#,##0.00")
                'lbAct_Sales.Text = Format(.Item("sumTrh_AmtNow") + lbAct_Sales.Text, "#,##0.00")
                'lbAct_GP.Text = Format(.Item("actGPSales") + lbAct_GP.Text, "#,##0.00")
                'lbAct_GPProfit.Text = Format(.Item("actGPProfit") + lbAct_GPProfit.Text, "#,##0.00")
                'lbAct_GPweight.Text = Format(.Item("sumTrh_Wnow") + lbAct_GPweight.Text, "#,##0.00")

                'lbAct_TT.Text = Format(.Item("actTTSales") + lbAct_TT.Text, "#,##0.00")
                'lbAct_TTProfit.Text = Format(.Item("actTTProfit") + lbAct_TTProfit.Text, "#,##0.00")

            End With

        Next
        Dim viewSales As New DataView(sales.SalesMan)
        viewSales.RowFilter = "Type='SL'  "
        'viewSales.Sort = "Profit_D desc"
        For Each row As DataRowView In viewSales

            'For d = 0 To view.Table.Rows.Count - 1
            With viewSales.Table
                Dim targetSales As Double = row.Item("Target_Sales")

                lbTarget_Sales.Text = Format(lbTarget_Sales.Text + targetSales, "#,##0.00")
                lbTarget_Profit.Text = Format(lbTarget_Profit.Text + row.Item("Target_Profit"), "#,##0.00")
                lbTarget_GP.Text = Format(lbTarget_GP.Text + row.Item("Target_GP_Sales"), "#,##0.00")
                lbTarget_GPProfit.Text = Format(lbTarget_GPProfit.Text + row.Item("Target_GP_Profit"), "#,##0.00")
                lbTarget_GPWeight.Text = Format(lbTarget_GPWeight.Text + row.Item("Target_GP_Weight"), "#,##0.00")
                lbTarget_TT.Text = Format(lbTarget_TT.Text + row.Item("Target_TT_Sales"), "#,##0.00")
                lbTarget_TTProfit.Text = Format(lbTarget_TTProfit.Text + row.Item("Target_TT_Profit"), "#,##0.00")

                lbAct_Sales.Text = Format(lbAct_Sales.Text + row.Item("Act_Target"), "#,##0.00")
                lbAct_Profit.Text = Format(lbAct_Profit.Text + row.Item("Act_Profit"), "#,##0.00")
                lbAct_GP.Text = Format(lbAct_GP.Text + row.Item("Act_GP_Sales"), "#,##0.00")
                lbAct_GPProfit.Text = Format(lbAct_GPProfit.Text + row.Item("Act_GP_Profit"), "#,##0.00")
                lbAct_GPweight.Text = Format(lbAct_GPweight.Text + row.Item("Act_GP_Weight"), "#,##0.00")
                lbAct_TT.Text = Format(lbAct_TT.Text + row.Item("Act_TT_Sales"), "#,##0.00")
                lbAct_TTProfit.Text = Format(lbAct_TTProfit.Text + row.Item("Act_TT_Profit"), "#,##0.00")

            End With

        Next


        lbDiff_TargetSales.Text = Format(lbTarget_Sales.Text - lbAct_Sales.Text, "#,##0.00")
        lbDiff_TargetProfit.Text = Format(lbTarget_Profit.Text - lbAct_Profit.Text, "#,##0.00")

        lbDiff_TargetGP.Text = Format(lbTarget_GP.Text - lbAct_GP.Text, "#,##0.00")
        lbDiff_TargetGPProfit.Text = Format(lbTarget_GPProfit.Text - lbAct_GPProfit.Text, "#,##0.00")
        lbDiff_TargetGPWeight.Text = Format(lbTarget_GPWeight.Text - lbAct_GPweight.Text, "#,##0.00")

        lbDiff_TargetTT.Text = Format(lbTarget_TT.Text - lbAct_TT.Text, "#,##0.00")
        lbDiff_TargetTTProfit.Text = Format(lbTarget_TTProfit.Text - lbAct_TTProfit.Text, "#,##0.00")

        lbSim_Target.Text = Format(lbDiff_TargetSales.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_Profit.Text = Format(lbDiff_TargetProfit.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_GPtarget.Text = Format(lbDiff_TargetGP.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_GPProfit.Text = Format(lbDiff_TargetGPProfit.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_GPWeight.Text = Format(lbDiff_TargetGPWeight.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_TT.Text = Format(lbDiff_TargetTT.Text / lbDayWorkQty.Text, "#,##0.00")
        lbSim_TTProfit.Text = Format(lbDiff_TargetTTProfit.Text / lbDayWorkQty.Text, "#,##0.00")


        lbStd_Sales.Text = Format(lbTarget_Sales.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_Profit.Text = Format(lbTarget_Profit.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_GP.Text = Format(lbTarget_GP.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_GPProfit.Text = Format(lbTarget_GPProfit.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_GPWeight.Text = Format(lbTarget_GPWeight.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_TT.Text = Format(lbTarget_TT.Text / lbDayWork0.Text, "#,##0.00")
        lbStd_TTProfit.Text = Format(lbTarget_TTProfit.Text / lbDayWork0.Text, "#,##0.00")

        lbPerf_Sales.Text = Format(lbAct_Sales.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_Profit.Text = Format(lbAct_Profit.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_GP.Text = Format(lbAct_GP.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_GPProfit.Text = Format(lbAct_GPProfit.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_GPWeight.Text = Format(lbAct_GPweight.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_TT.Text = Format(lbAct_TT.Text / lbDayAct.Text, "#,##0.00")
        lbPerf_TTProfit.Text = Format(lbAct_TTProfit.Text / lbDayAct.Text, "#,##0.00")


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


    End Sub
    Sub getChartYear()
        Dim seriesYear As New Series

        chartYear.Series.Clear()
        seriesYear.Points.AddXY("Target", lbTarget_Profit.Text)
        seriesYear.Points.AddXY("Act", lbAct_Profit.Text)

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

    Private Sub cmdPriceList_Click(sender As Object, e As EventArgs) Handles cmdPriceList.Click
        'Me.Hide()
        ' frmPriceList.Show()
        'Me.Show()
        Dim frmSummary As New frmSummary
        Timer1.Enabled = False
        frmSummary.Show()

    End Sub

    Private Sub cmbCusSA_Click(sender As Object, e As EventArgs) Handles cmbCusSA.Click
        Dim frmCusSA As New frmCusSA
        Timer1.Enabled = False
        frmCusSA.Show()

    End Sub

    Private Sub cmdRptGrade_Click(sender As Object, e As EventArgs) Handles cmdRptGrade.Click
        'Me.Hide()
        Dim frmRptGrade As New frmRptCusGrad
        Timer1.Enabled = False
        frmRptGrade.Show()

        'Me.Show()

    End Sub

    Private Sub cmdRptCusSegment_Click(sender As Object, e As EventArgs) Handles cmdRptCusSegment.Click
        ' Me.Hide()
        Dim frmRptSegment As New frmRptCusGrp
        Timer1.Enabled = False
        frmRptSegment.Show()
        'Me.Show()
    End Sub


    Sub genDataCSOrder()

        txtSQL = "Select Stk_Prod,Trh_Type,"
        txtSQL = txtSQL & "(CS_Name)as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        txtSQL = txtSQL & "sum(trh_D_Amt)as SumAmt,"
        txtSQL = txtSQL & "sum((Stk_Factor*Dtl_num)/1000) as sumQw,"
        txtSQL = txtSQL & "sum((Trh_D_Amt-Trh_Cost_Amt)) as sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On (Trh_Type=Dtl_Type "
        txtSQL = txtSQL & "And Trh_No=Dtl_No )"
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On ( Dtl_idTrade=Stk_Code ) "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "left Join CSMast "
        txtSQL = txtSQL & "on Ar_CS=CS_Code "
        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        'txtSQL = txtSQL & "left join ProGrpMast "
        'txtSQL = txtSQL & "On Trh_Prod_Sales=Progrp_id "

        txtSQL = txtSQL & "Where Trh_Type='B'  "
        'txtSQL = txtSQL & "And (Trh_NoType='V' "
        'txtSQL = txtSQL & "Or Trh_NoType='N' "
        'txtSQL = txtSQL & "Or Trh_NoType='B' "
        'txtSQL = txtSQL & "Or Trh_NoType='M' "
        'txtSQL = txtSQL & "Or Trh_NoType='Y' "
        'txtSQL = txtSQL & "Or Trh_NoType='Z' "
        'txtSQL = txtSQL & ") "

        txtSQL = txtSQL & "And Trh_D_Amt>0 "
        'txtSQL = txtSQL & "And not(Trh_user is null) "
        ' ==========  เลือกช่วงเวลา ================
        ' txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        txtSQL = txtSQL & "And Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "

        ' ==========  เลือกช่วงเวลา ================
        'txtSQL = txtSQL & "And Dtl_wh='01' "
0:      txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        ' txtSQL = txtSQL & "or Stk_Prod_Sales='02' or Stk_Prod_Sales='05' "
        txtSQL = txtSQL & ") "

        'txtSQL = txtSQL & "And CS_off='0' "

        txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL99' ) "

        txtSQL = txtSQL & "Group by  Stk_Prod, Trh_Type,CS_Name "


        txtSQL = txtSQL & "Order by sumQw desc  "

        If chkSCData = True Then

            subDS.Tables("rptCS01").Clear()
            chkSCData = False

        End If

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "rptCS01")
        chkSCData = True

        'Dim sChart As New Series
        Dim csArea As New ChartArea
        Dim series0 As New Series("SERIES0")
        'Dim series1 As New Series("SERIES1")

        csArea.AxisX.LineWidth = 2
        csArea.AxisX.Interval = 1

        csArea.AxisX.MajorGrid.Enabled = False
        csArea.AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

        chartOrCS.Series.Clear()
        chartOrCS.ChartAreas.Clear()
        lbTotalCS.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptCS01").Rows.Count + 1
        'Me.Refresh()
        lbOrder_Sales.Text = 0
        lbOrder_Profit.Text = 0
        lbOrder_GP.Text = 0
        lbOrder_GPProfit.Text = 0
        lbOrder_GPWeight.Text = 0

        lbOrder_TT.Text = 0
        lbOrder_TTProfit.Text = 0

        For i = 0 To subDS.Tables("rptCS01").Rows.Count - 1
            indexBar.PerformStep()
            indexBar.Value = i
            With subDS.Tables("rptCS01").Rows(i)
                lbOrder_Sales.Text = Format(lbOrder_Sales.Text + .Item("sumAmt"), "#,##0.00")
                lbOrder_Profit.Text = Format(lbOrder_Profit.Text + .Item("sumProfit"), "#,##0.00")
                If .Item("Stk_Prod") = "01" Then
                    series0.Points.AddXY(.Item("Sale"), Format(.Item("sumQw"), "#,##0.00"))
                    lbTotalCS.Text = Format(.Item("sumQw") + CDbl(lbTotalCS.Text), "#,##0.00")

                    lbOrder_GP.Text = Format(lbOrder_GP.Text + .Item("sumAmt"), "#,##0.00")
                    lbOrder_GPProfit.Text = Format(lbOrder_GPProfit.Text + .Item("sumProfit"), "#,##0.00")
                    lbOrder_GPWeight.Text = Format(lbOrder_GPWeight.Text + .Item("sumQw"), "#,##0.00")

                Else
                    lbOrder_TT.Text = Format(lbOrder_TT.Text + .Item("sumAmt"), "#,##0.00")
                    lbOrder_TTProfit.Text = Format(lbOrder_TTProfit.Text + .Item("sumProfit"), "#,##0.00")

                End If


            End With
            'Me.Refresh()
        Next

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

        series0.ChartType = SeriesChartType.Column
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        series0.Palette = ChartColorPalette.BrightPastel

        With chartOrCS
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(csArea)
            .Series.Add(series0)
            '.Series.Add(series1)
            .BorderlineWidth = 1

            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ' chartCS.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With

    End Sub



    Private Sub optAmt_CheckedChanged(sender As Object, e As EventArgs)
        runAllProgram()


    End Sub

    Private Sub optWqty_CheckedChanged(sender As Object, e As EventArgs)

        runAllProgram()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        runAllProgram()
        lbTimer.Text = Format(Now, "HH:mm:ss")


    End Sub

    Sub genDataSales()

        lbDateProfitSL.Text = "  " & Format(txtDate01.Value, "dd/MM/yy") & "  ถึง  " & Format(txtDate02.Value, "dd/MM/yy")
        lbDateProfitCS.Text = lbDateProfitSL.Text
        lbDateWeightSL.Text = lbDateProfitSL.Text
        lbDateWeightCS.Text = lbDateProfitSL.Text
        lbDateAmtCS.Text = lbDateProfitSL.Text
        lbDateAmtSL.Text = lbDateProfitSL.Text

        txtSQL = "Select Trh_ProD_Sales,Trh_Type,Ar_Sales,"
        txtSQL = txtSQL & "(SL_NickName)as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        'txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num)as SumAmt,"
        'txtSQL = txtSQL & "sum(case when (Trh_ProD_Sales='01') then "
        'txtSQL = txtSQL & "     isnull(Trh_Amt,0) else  0 end ) as sumAmt, "
        txtSQL = txtSQL & "sum(isnull(Trh_Cost_Amt,0))as sumCost,"
        txtSQL = txtSQL & "sum(Trh_D_Amt)as SumAmt,"
        txtSQL = txtSQL & "sum(Trh_W_Sum) as sumQw,"
        txtSQL = txtSQL & "sum(isnull(Trh_D_Amt-Trh_Cost_Amt,0)) as sumProfit "
        'txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num)/(Dtl_Num*Stk_Factor)) as sumPrKg "
        'txtSQL = txtSQL & "((Trh_Amt)/(Trh_W_Sum)) as sumPrKg "

        txtSQL = txtSQL & "From TranDataH "
        'txtSQL = txtSQL & "Left Join TranDataD  "
        'txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
        'txtSQL = txtSQL & "Left Join BaseMast "
        'txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "


        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On TRh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "
        txtSQL = txtSQL & "left Join SalesMan "
        txtSQL = txtSQL & "on Ar_Sales=SL_ID "

        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        'txtSQL = txtSQL & "left join ProGrpMast "
        'txtSQL = txtSQL & "On Trh_ProD_Sales=Progrp_id "

        txtSQL = txtSQL & "Where Trh_D_Amt>0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "

        'txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        txtSQL = txtSQL & "And Trh_date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "


        ' ==========  เลือกช่วงเวลา ================
        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Trh_ProD_Sales='01' or Trh_Prod_Sales='02' or Trh_Prod_Sales='05' "
        txtSQL = txtSQL & ") "

        ' txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' ) "
        txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' or Trh_Sale='SL99' ) "

        txtSQL = txtSQL & "Group by  TRh_Prod_Sales,Trh_Type,Ar_Sales,SL_NickName "
        txtSQL = txtSQL & "Order by sumQw desc  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)

        If chkSLData = True Then

            subDS.Tables("rptSL01").Clear()
            chkSLData = False

        End If

        subDA.Fill(subDS, "rptSL01")
        chkSLData = True  ' ใช้  chkSLData ร่วมกับ กราฟอันต่อไป  อันนี้ยกเลิกใช้

        ' Dim slChart As New Series
        Dim slArea As New ChartArea
        Dim profitArea As New ChartArea
        Dim weightArea As New ChartArea

        Dim serTarget_SL As New Series
        Dim serProfit_SL As New Series
        Dim serWeightGP_SL As New Series
        Dim serTarget_Profit As New Series
        ' Dim serProfitTT_SL As New Series
        'Dim series_SL1 As New Series("SERIES_SL1")

        chartSalesSL.ChartAreas.Clear()
        chartSalesSL.Series.Clear()
        chartProfitSL.ChartAreas.Clear()
        chartProfitSL.Series.Clear()
        chartWeightSL.ChartAreas.Clear()
        chartWeightSL.Series.Clear()

        'chartSL.ChartAreas(0).AxisX.LineWidth = 2
        'chartSL.ChartAreas(0).AxisX.Interval = 1
        'slArea.AxisX.LineWidth = 2
        'slArea.AxisX.Interval = 1
        'slArea.AxisX.MajorGrid.Enabled = False

        'profitArea.AxisX.LineWidth = 2
        'profitArea.AxisX.Interval = 1
        'profitArea.AxisX.MajorGrid.Enabled = False

        lbTotalSL_W.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptSL01").Rows.Count + 1

        Me.Refresh()

        lbDaily_Sales.Text = 0
        lbDaily_Profit.Text = 0
        lbTotalSL_W.Text = 0

        lbDaily_GP.Text = 0
        lbDaily_GPWeight.Text = 0
        lbDaily_GPProfit.Text = 0
        lbDaily_TT.Text = 0
        lbDaily_TTProfit.Text = 0

        For i = 0 To subDS.Tables("rptSL01").Rows.Count - 1
            'indexBar.PerformStep()
            'indexBar.Value = i
            With subDS.Tables("rptSL01").Rows(i)

                If .Item("Trh_ProD_Sales") = "01" Then
                    sales.setSalesGP_D(.Item("Ar_Sales"), .Item("sumAmt"), .Item("sumCost"))
                    sales.setProfitGP_D(.Item("Ar_Sales"), .Item("sumProfit"))
                    sales.setWeightGP_D(.Item("Ar_Sales"), .Item("sumQw"))
                ElseIf .Item("Trh_ProD_Sales") = "02" Or .Item("TRh_Prod_Sales") = "05" Then

                    sales.setSalesTT_D(.Item("Ar_Sales"), .Item("sumAmt"), .Item("sumCost"))
                    sales.setProfitTT_D(.Item("Ar_Sales"), .Item("sumProfit"))
                End If

            End With
            ' Me.Refresh()

        Next

        lbTotalSL_Sales.Text = 0
        lbTotalSL_W.Text = 0
        lbTotalSL_Profit.Text = 0

        Dim viewSales As New DataView(sales.SalesMan)
        viewSales.RowFilter = "Type='SL' And Profit_D > 0 "
                    viewSales.Sort = "Profit_D desc"
        For Each row As DataRowView In viewSales
            'For d = 0 To view.Table.Rows.Count - 1
            With viewSales.Table
                Dim slName As String = row.Item("Name")
                Dim Profit As Double = row.Item("Profit_D")
                Dim GPWeight As Double = row.Item("GP_Weight_D")
                Dim SalesAmt As Double = row.Item("Target_D")
                If row.Item("Name") = "ต่าย" Then
                    Label93.Text = Format(Label93.Text + row.Item("Target_D"), "#,##0.00")
                End If
                lbTotalSL_Sales.Text = Format(lbTotalSL_Sales.Text + SalesAmt, "#,##0.00")
                lbTotalSL_W.Text = Format(lbTotalSL_W.Text + GPWeight, "#,##0.00")
                lbTotalSL_Profit.Text = Format(lbTotalSL_Profit.Text + Profit, "#,##0.00")

                lbDaily_Sales.Text = Format(lbDaily_Sales.Text + row.Item("Target_D"), "#,##0.00")
                lbDaily_Profit.Text = Format(lbDaily_Profit.Text + row.Item("Profit_D"), "#,##0.00")
                lbDaily_GP.Text = Format(lbDaily_GP.Text + row.Item("GP_Sales_D"), "#,##0.00")
                lbDaily_GPProfit.Text = Format(lbDaily_GPProfit.Text + row.Item("GP_Profit_D"), "#,##0.00")
                lbDaily_GPWeight.Text = Format(lbDaily_GPWeight.Text + row.Item("GP_Weight_D"), "#,##0.00")

                lbDaily_TT.Text = Format(lbDaily_TT.Text + row.Item("TT_Sales_D"), "#,##0.00")
                lbDaily_TTProfit.Text = Format(lbDaily_TTProfit.Text + row.Item("TT_Profit_D"), "#,##0.00")

                'Dim target_Sales As Double = row.Item("Target_Sales") / lbDayWork0.Text
                'Dim target_profit As Double = row.Item("Target_Profit") / lbDayWork0.Text
                'Dim target_weight As Double = (row.Item("Target_GP_Weight")) / lbDayWork0.Text

                'Dim ackDate As Integer = DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value) + 1
                Dim ackDate As Integer = calDayWork(txtDate01.Value, txtDate02.Value)
                Dim target_Sales As Double = (row.Item("Target_Sales") / lbDayWork0.Text) * ackDate 'DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value)
                Dim target_profit As Double = (row.Item("Target_Profit") / lbDayWork0.Text) * ackDate 'DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value)
                Dim target_weight As Double = (row.Item("Target_GP_Weight") / lbDayWork0.Text) * ackDate
                If optRatio.Checked = True Then
                    If slName = "บอล" Or slName = "ยอร์ช" Or slName = "มา" Then
                    Else

                        serTarget_SL.Points.AddXY(slName, Format(((SalesAmt - target_Sales) / target_Sales) * 100, "#,##0.00"))
                        serWeightGP_SL.Points.AddXY(slName, Format(((GPWeight - target_weight) / target_weight) * 100, "#,##0.00"))
                        serProfit_SL.Points.AddXY(slName, Format(((Profit - target_profit) / target_profit) * 100, "#,##0.00"))

                    End If


                Else
                    serTarget_SL.Points.AddXY(slName, Format(SalesAmt, "#,##0.00"))
                    serWeightGP_SL.Points.AddXY(slName, Format(GPWeight, "#,##0.00"))
                    serProfit_SL.Points.AddXY(slName, Format(Profit, "#,##0.00"))
                    If chkShowKPI.Checked = True Then
                        serTarget_Profit.Points.AddXY(slName, target_profit)
                    End If

                End If


                'serTarget_SL.Points.AddXY(slName, Format(SalesAmt, "#,##0.00"))
                'serWeightGP_SL.Points.AddXY(slName, Format(GPWeight, "#,##0.00"))
                'serProfit_SL.Points.AddXY(slName, Format(Profit, "#,##0.00"))
            End With
        Next

        '============================================================================
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
        With serTarget_SL
            .LabelFormat = "#,##0.00"
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            .Palette = ChartColorPalette.EarthTones
            .ChartType = SeriesChartType.Column
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            'series0.IsXValueIndexed = True

        End With

        'series0.IsVisibleInLegend = True
        'series1.Palette = ChartColorPalette.EarthTones
        'series1.ChartType = SeriesChartType.Column
        'If optTypeBar.Checked = True Then
        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)
        slArea.AxisX.MinorTickMark.Enabled = True
        'slArea.BackColor = Color.Black

        With chartSalesSL
            '.ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(slArea)
            .Series.Add(serTarget_SL)

            '.Series.Add(series1)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ' chartCS.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With
        With serProfit_SL
            .ChartType = SeriesChartType.Column
            .LabelFormat = "#,##0.00"
            '.LabelBackColor = Color.Black
            '.LabelForeColor = Color.Yellow
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            .Palette = ChartColorPalette.EarthTones
            '.ChartType = SeriesChartType.Column
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End With
        With serTarget_Profit
            .LabelFormat = "#,##0.00"
            '.LabelBackColor = Color.Orange
            '.LabelForeColor = Color.Black
            .ChartType = SeriesChartType.Column
            .BorderWidth = 1
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            '.Palette = ChartColorPalette.BrightPastel
            .Color = Color.YellowGreen
            '.ChartType = SeriesChartType.Column
            ' .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End With

        With chartProfitSL
            '.ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(profitArea)
            '.Series.Add(series_SL0)

            '.Series.Add(series1)
            .BorderlineWidth = 1
            .Series.Add(serTarget_Profit)
            .Series.Add(serProfit_SL)

        End With
        With serWeightGP_SL
            .ChartType = SeriesChartType.Column
            .LabelFormat = "#,##0.00"
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            .Palette = ChartColorPalette.EarthTones
            '.ChartType = SeriesChartType.Column
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End With


        With chartWeightSL
            '.ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(weightArea)
            '.Series.Add(series_SL0)

            '.Series.Add(series1)
            .BorderlineWidth = 1
            .Series.Add(serWeightGP_SL)
            '.Series.Add(serProfitTT)
        End With

    End Sub


    Sub CS_genDataSales()

        Dim viewSales As New DataView(sales.SalesMan)

        txtSQL = "Select Trh_ProD_Sales,Trh_Type,(Ar_CS)as Ar_Sales,"
        txtSQL = txtSQL & "isnull(CS_Name,'')as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        'txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num)as SumAmt,"
        'txtSQL = txtSQL & "sum(case when (Trh_ProD_Sales='01') then "
        'txtSQL = txtSQL & "     isnull(Trh_Amt,0) else  0 end ) as sumAmt, "

        txtSQL = txtSQL & "sum(isnull(Trh_D_Amt,0))as SumAmt,"
        txtSQL = txtSQL & "sum(isnull(Trh_Cost_Amt,0))as sumCost,"
        txtSQL = txtSQL & "sum(isnull(Trh_W_Sum,0)) as sumQw,"
        txtSQL = txtSQL & "sum(isnull(Trh_D_Amt-Trh_Cost_Amt,0)) as sumProfit "
        'txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num)/(Dtl_Num*Stk_Factor)) as sumPrKg "
        'txtSQL = txtSQL & "((Trh_Amt)/(Trh_W_Sum)) as sumPrKg "

        txtSQL = txtSQL & "From TranDataH "
        'txtSQL = txtSQL & "Left Join TranDataD  "
        'txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
        'txtSQL = txtSQL & "Left Join BaseMast "
        'txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "


        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On TRh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "
        txtSQL = txtSQL & "left Join CSMast "
        txtSQL = txtSQL & "on Ar_CS=CS_Code "

        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        'txtSQL = txtSQL & "left join ProGrpMast "
        'txtSQL = txtSQL & "On Trh_ProD_Sales=Progrp_id "

        txtSQL = txtSQL & "Where Trh_D_Amt>0 "
        ' txtSQL = txtSQL & "And not(Ar_Sales='') "
        txtSQL = txtSQL & "And Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' Or Trh_NoType='Z' )  "

        'txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        txtSQL = txtSQL & "And Trh_date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "
        ' txtSQL = txtSQL & "And Trh_Date='2020-07-16' "

        ' ==========  เลือกช่วงเวลา ================
        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Trh_ProD_Sales='01' or Trh_Prod_Sales='02'    "
        'Trh_ProD_Sales='01' or
        txtSQL = txtSQL & ") "

        ' txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' ) "
        txtSQL = txtSQL & "and not(Trh_sale='SL03' or TRh_Sale='SL14' or Trh_Sale='SL12' or Trh_Sale='SL99' ) "
        'txtSQL = txtSQL & "And not(Ar_Sales='0003') "
        txtSQL = txtSQL & "Group by  TRh_Prod_Sales,Trh_Type,Ar_CS,CS_Name "
        txtSQL = txtSQL & "Order by sumQw desc  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)

        If chkSLData = True Then

            subDS.Tables("rptSL01").Clear()
            chkSLData = False

        End If

        subDA.Fill(subDS, "rptSL01")
        chkSLData = True  ' ใช้  chkSLData ร่วมกับ กราฟอันต่อไป  อันนี้ยกเลิกใช้

        ' Dim slChart As New Series
        Dim slArea As New ChartArea
        Dim profitArea As New ChartArea
        Dim weightArea As New ChartArea

        Dim serTarget_Profit As New Series
        Dim serTarget_SL As New Series
        Dim serProfit_SL As New Series
        Dim serWeightGP_SL As New Series
        ' Dim serProfitTT_SL As New Series
        'Dim series_SL1 As New Series("SERIES_SL1")

        chartSalesCS.ChartAreas.Clear()
        chartSalesCS.Series.Clear()
        chartProfitCS.ChartAreas.Clear()
        chartProfitCS.Series.Clear()
        chartWeightCS.ChartAreas.Clear()
        chartWeightCS.Series.Clear()

        'chartSL.ChartAreas(0).AxisX.LineWidth = 2
        'chartSL.ChartAreas(0).AxisX.Interval = 1
        'slArea.AxisX.LineWidth = 2
        'slArea.AxisX.Interval = 1
        'slArea.AxisX.MajorGrid.Enabled = False

        'profitArea.AxisX.LineWidth = 2
        'profitArea.AxisX.Interval = 1
        'profitArea.AxisX.MajorGrid.Enabled = False

        'lbTotalSL_W.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptSL01").Rows.Count + 1

        'Me.Refresh()

        '63-07-30

        'lbDaily_Sales.Text = 0
        'lbDaily_Profit.Text = 0
        'lbTotalSL_W.Text = 0

        'lbDaily_GP.Text = 0
        'lbDaily_GPWeight.Text = 0
        'lbDaily_GPProfit.Text = 0
        'lbDaily_TT.Text = 0
        'lbDaily_TTProfit.Text = 0
        Dim vBar As Integer = 0
        For i = 0 To subDS.Tables("rptSL01").Rows.Count - 1
            indexBar.PerformStep()
            If vBar < 100 Then
                vBar = vBar + 1
            Else
                vBar = 0

            End If
            indexBar.Value = vBar
            With subDS.Tables("rptSL01").Rows(i)
                'Dim sumAmt As Double
                'If IsDBNull(.Item("sumAmt")) Then
                '    sumAmt = 0
                'Else
                '    sumAmt = .Item("suymAmt")
                'End If

                If .Item("Trh_ProD_Sales") = "01" Then

                    sales.setSalesGP_D(.Item("Ar_Sales"), .Item("sumAmt"), .Item("sumCost"))
                    sales.setProfitGP_D(.Item("Ar_Sales"), .Item("sumProfit"))
                    sales.setWeightGP_D(.Item("Ar_Sales"), .Item("sumQw"))
                ElseIf .Item("Trh_ProD_Sales") = "02" Or .Item("TRh_Prod_Sales") = "05" Then

                    sales.setSalesTT_D(.Item("Ar_Sales"), .Item("sumAmt"), .Item("sumCost"))
                    sales.setProfitTT_D(.Item("Ar_Sales"), .Item("sumProfit"))

                End If

            End With
            ' Me.Refresh()
        Next
        lbTotalSL_Sales_CS.Text = 0
        lbTotalSL_W_CS.Text = 0
        lbTotalSL_Profit_CS.Text = 0

        viewSales.RowFilter = "Type='CS' And Profit_D > 0 "
        viewSales.Sort = "Profit_D desc"
        For Each row As DataRowView In viewSales
            'For d = 0 To view.Table.Rows.Count - 1
            With viewSales.Table
                Dim slName As String = row.Item("Name")
                Dim Profit As Double = row.Item("Profit_D")
                Dim GPWeight As Double = row.Item("GP_Weight_D")
                Dim SalesAmt As Double = row.Item("Target_D")

                lbTotalSL_Sales_CS.Text = Format(lbTotalSL_Sales_CS.Text + SalesAmt, "#,##0.00")
                lbTotalSL_W_CS.Text = Format(lbTotalSL_W_CS.Text + GPWeight, "#,##0.00")
                lbTotalSL_Profit_CS.Text = Format(lbTotalSL_Profit_CS.Text + Profit, "#,##0.00")

                If row.Item("Name") = "คุณปุ้ย" Then
                    'Label93.Text = Format(Label93.Text + row.Item("Profit_D"), "#,##0.00")
                End If
                'lbDaily_Sales.Text = Format(lbDaily_Sales.Text + row.Item("Target_D"), "#,##0.00")
                'lbDaily_Profit.Text = Format(lbDaily_Profit.Text + row.Item("Profit_D"), "#,##0.00")
                'lbDaily_GP.Text = Format(lbDaily_GP.Text + row.Item("GP_Sales_D"), "#,##0.00")
                'lbDaily_GPProfit.Text = Format(lbDaily_GPProfit.Text + row.Item("GP_Profit_D"), "#,##0.00")
                'lbDaily_GPWeight.Text = Format(lbDaily_GPWeight.Text + row.Item("GP_Weight_D"), "#,##0.00")

                'lbDaily_TT.Text = Format(lbDaily_TT.Text + row.Item("TT_Sales_D"), "#,##0.00")
                'lbDaily_TTProfit.Text = Format(lbDaily_TTProfit.Text + row.Item("TT_Profit_D"), "#,##0.00")
                Dim ackDate As Integer = calDayWork(txtDate01.Value, txtDate02.Value) 'DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value) + 1

                Dim target_Sales As Double = (row.Item("Target_Sales") / lbDayWork0.Text) * ackDate 'DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value)
                Dim target_profit As Double = (row.Item("Target_Profit") / lbDayWork0.Text) * ackDate 'DateDiff(DateInterval.Day, txtDate01.Value, txtDate02.Value)
                Dim target_weight As Double = (row.Item("Target_GP_Weight") / lbDayWork0.Text) * ackDate

                If optRatio.Checked = True Then


                    serTarget_SL.Points.AddXY(slName, Format(((SalesAmt - target_Sales) / target_Sales) * 100, "#,##0.00"))
                    serWeightGP_SL.Points.AddXY(slName, Format(((GPWeight - target_weight) / target_weight) * 100, "#,##0.00"))
                    serProfit_SL.Points.AddXY(slName, Format(((Profit - target_profit) / target_profit) * 100, "#,##0.00"))
                Else
                    serTarget_SL.Points.AddXY(slName, Format(SalesAmt, "#,##0.00"))
                    serWeightGP_SL.Points.AddXY(slName, Format(GPWeight, "#,##0.00"))
                    serProfit_SL.Points.AddXY(slName, Format(Profit, "#,##0.00"))
                    If chkShowKPI.Checked = True Then
                        serTarget_Profit.Points.AddXY(slName, (target_profit))
                    End If

                End If

            End With
        Next

        '============================================================================
        'lbSLRatio_Sales.Text = Format((((lbDaily_Sales.Text - lbStd_Sales.Text) / lbStd_Sales.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_Sales, lbSLRatio_Sales.Text)
        'lbSLRatio_Profit.Text = Format((((lbDaily_Profit.Text - lbStd_Profit.Text) / lbStd_Profit.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_Profit, lbSLRatio_Profit.Text)
        'lbSLRatio_GP.Text = Format((((lbDaily_GP.Text - lbStd_GP.Text) / lbStd_GP.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_GP, lbSLRatio_GP.Text)
        'lbSLRatio_GPProfit.Text = Format((((lbDaily_GPProfit.Text - lbStd_GPProfit.Text) / lbStd_GPProfit.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_GPProfit, lbSLRatio_GPProfit.Text)
        'lbSLRatio_GPWeight.Text = Format((((lbDaily_GPWeight.Text - lbStd_GPWeight.Text) / lbStd_GPWeight.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_GPWeight, lbSLRatio_GPWeight.Text)
        'lbSLRatio_TT.Text = Format((((lbDaily_TT.Text - lbStd_TT.Text) / lbStd_TT.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_TT, lbSLRatio_TT.Text)
        'lbSLRatio_TTProfti.Text = Format((((lbDaily_TTProfit.Text - lbStd_TTProfit.Text) / lbStd_TTProfit.Text) * 100), "#,##0.00")
        'chkObj(lbSLRatio_TTProfti, lbSLRatio_TTProfti.Text)
        With serTarget_SL
            .LabelFormat = "#,##0.00"
            .LabelBackColor = Color.Yellow
            .LabelForeColor = Color.Black
            .LabelAngle = 90
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            'series0.IsXValueIndexed = True

            'series1.ChartType = SeriesChartType.Column
            'series1.BorderWidth = 4
            'series1.IsValueShownAsLabel = True
            'series1.IsVisibleInLegend = False
            'series1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

            .Palette = ChartColorPalette.BrightPastel
            .ChartType = SeriesChartType.Column
        End With


        'series0.IsVisibleInLegend = True
        'series1.Palette = ChartColorPalette.EarthTones
        'series1.ChartType = SeriesChartType.Column
        'If optTypeBar.Checked = True Then
        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)


        With slArea
            '.AxisX.MinorTickMark.Enabled = False
            '.AxisX.MinorTickMark.LineColor = Color.Yellow
            '.BackColor = Color.Gray

            '.AxisX.LineColor = Color.White
            '.AxisX.MinorGrid.LineColor = Color.Red
            '.BorderColor = Color.White
        End With
        'slArea

        With chartSalesCS
            .ForeColor = Color.White
            '.BorderlineColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(slArea)
            .Series.Add(serTarget_SL)

            '.Series.Add(series1)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ' chartCS.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With

        'serTarget_Profit.ChartType = SeriesChartType.Column
        'serTarget_Profit.BorderWidth = 4
        'serTarget_Profit.IsValueShownAsLabel = True
        'serTarget_Profit.IsVisibleInLegend = False

        'serTarget_Profit.Palette = ChartColorPalette.Fire
        'serTarget_Profit.ChartType = SeriesChartType.Column
        'serTarget_Profit.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        With serProfit_SL
            .LabelFormat = "#,##0.00"
            .LabelBackColor = Color.Yellow
            .LabelForeColor = Color.Black
            .ChartType = SeriesChartType.Column
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            .Palette = ChartColorPalette.BrightPastel

            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        End With
        With serTarget_Profit
            .LabelFormat = "#,##0.00"
            .LabelBackColor = Color.Orange
            .LabelForeColor = Color.Black
            .ChartType = SeriesChartType.Column
            .BorderWidth = 1
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False

            '.Palette = ChartColorPalette.BrightPastel
            .Color = Color.YellowGreen
            '.ChartType = SeriesChartType.Column
            ' .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End With

        With chartProfitCS
            '.ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(profitArea)
            '.Series.Add(serTarget_Profit)
            '.Series.Add(series_SL0)
            '.Series.Add(series1)
            .BorderlineWidth = 1
            .Series.Add(serTarget_Profit)
            .Series.Add(serProfit_SL)

            '.Series.Add(serProfitTT)
        End With

        With serWeightGP_SL
            .LabelFormat = "#,##0.00"
            .LabelBackColor = Color.Yellow
            .LabelForeColor = Color.Black
            '.LabelAngle = -90
            .ChartType = SeriesChartType.Column
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False
            .Palette = ChartColorPalette.BrightPastel

            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End With
        With chartWeightCS

            .ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(weightArea)
            '.Series.Add(series_SL0)

            '.Series.Add(series1)
            .BorderlineWidth = 1
            .Series.Add(serWeightGP_SL)
            '.Series.Add(serProfitTT)
        End With
        ' Me.Refresh()
    End Sub
    Function getCarNum() As String
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter
        Dim strNow As Date

        strNow = DateAdd(DateInterval.Day, 1, Now)

        txtSQL = "Select  trh_Bill,Trh_RunID "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Where (TranDataH.trh_type = 'P') "

        'txtSQL = txtSQL & "And Trh_date >= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "
        'txtSQL = txtSQL & "And Trh_date <= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "


        If Format(Now, "dddd").ToString = "เสาร์" Then
            ' MsgBox("วันนี้วัน" & Format(Now, "dddd").ToString)
            strNow = DateAdd(DateInterval.Day, 2, Now)

            txtSQL = txtSQL & "And Trh_date >= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "
            txtSQL = txtSQL & "And Trh_date <= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "

        Else
            strNow = DateAdd(DateInterval.Day, 1, Now)
            txtSQL = txtSQL & "And Trh_date >= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "
            txtSQL = txtSQL & "And Trh_date <= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "

            'strNow = Format(Now, "dddd").ToString

        End If



        txtSQL = txtSQL & "order by trh_bill,Trh_RunID desc "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "carNum")
        If subDS.Tables("carNum").Rows.Count = 0 Then
            Return "0"
        Else
            Return subDS.Tables("carNum").Rows(0).Item("Trh_RunID").ToString

        End If

    End Function

    Sub genDataRev()   '  ใบเบิก  ว่ามีรถจัดส่งกี่คัน

        txtSQL = "Select Trh_Type,"
        txtSQL = txtSQL & "(SL_NickName)as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num_2)as SumAmt,"
        txtSQL = txtSQL & "sum((Dtl_Num_2*Stk_Factor)/1000) as sumQw,"
        txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num_2)/(Dtl_Num_2*Stk_Factor)) as sumPrKg "

        txtSQL = txtSQL & "From TranDataH Left Join TranDataD  "
        txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "

        txtSQL = txtSQL & "left Join SalesMan "
        txtSQL = txtSQL & "On Ar_Sales=SL_ID "

        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        txtSQL = txtSQL & "left join ProGrpMast "
        txtSQL = txtSQL & "On Stk_Prod=Progrp_id "

        txtSQL = txtSQL & "Where Trh_Type='T'  "

        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        'txtSQL = txtSQL & "Or Trh_NoType='B' "
        'txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='X' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") "

        'txtSQL = txtSQL & "And dtl_price>0 "
        'txtSQL = txtSQL & "And not(Trh_user is null) "
        ' ==========  เลือกช่วงเวลา ================

        'Dim strDate01 As String
        Dim strNow As Date

        If Format(Now, "dddd").ToString = "เสาร์" Then
            ' MsgBox("วันนี้วัน" & Format(Now, "dddd").ToString)
            strNow = DateAdd(DateInterval.Day, 2, Now)

            txtSQL = txtSQL & "And dtl_dueDate >= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "
            txtSQL = txtSQL & "And dtl_dueDate <= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "

        Else
            strNow = DateAdd(DateInterval.Day, 1, Now)
            txtSQL = txtSQL & "And dtl_dueDate >= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "
            txtSQL = txtSQL & "And dtl_dueDate <= '" & Year(strNow) - 543 & "/" & Month(strNow) & "/" & Microsoft.VisualBasic.Day(strNow) & "' "

            'strNow = Format(Now, "dddd").ToString

        End If

        lbRevName.Text = "ยอดจองสินค้าเพื่อส่งวันที่  " & "-" & Format(strNow, "dd/MM/yyyy")

        ' txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        ' ==========  เลือกช่วงเวลา ================

        'txtSQL = txtSQL & "And Dtl_wh='01' "
        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        txtSQL = txtSQL & ") "


        'txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' ) "
        txtSQL = txtSQL & "Group by   Trh_Type,SL_NickName "


        txtSQL = txtSQL & "Order by sumQw desc  "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)

        If chkRevData = True Then

            subDS.Tables("rptSLRev01").Clear()
            chkRevData = False

        End If

        subDA.Fill(subDS, "rptSLRev01")
        chkRevData = True

        ' Dim slChart As New Series
        Dim slRevArea As New ChartArea
        Dim series_SLRev0 As New Series("SERIES_SLRev0")
        'Dim series_SL1 As New Series("SERIES_SL1")

        chartRev.ChartAreas.Clear()
        chartRev.Series.Clear()


        'chartSL.ChartAreas(0).AxisX.LineWidth = 2
        'chartSL.ChartAreas(0).AxisX.Interval = 1



        lbTotalRev.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptSLRev01").Rows.Count + 1

        ' Me.Refresh()

        For i = 0 To subDS.Tables("rptSLRev01").Rows.Count - 1
            indexBar.PerformStep()
            indexBar.Value = i
            With subDS.Tables("rptSLRev01").Rows(i)
                'If optAmt.Checked = True Then
                '    series1.Points.AddXY(.Item("Sale"), Format(.Item("SumAmt"), "#,##0.000"))

                'Else

                'End If
                series_SLRev0.Points.AddXY(.Item("Sale"), Format(.Item("sumQw"), "#,##0.00"))

                lbTotalRev.Text = Format((.Item("sumQw") + CDbl(lbTotalRev.Text)), "#,##0.00")
            End With
            ' Me.Refresh()
        Next

        With slRevArea
            .AxisX.LineWidth = 2
            .AxisX.Interval = 1
            .AxisX.MajorGrid.Enabled = False
        End With

        With series_SLRev0

            .LabelFormat = "#,##0.00"
            .ChartType = SeriesChartType.Column
            .BorderWidth = 4
            .IsValueShownAsLabel = True
            .IsVisibleInLegend = False
            .Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
            '.IsXValueIndexed = True
            '.IsVisibleInLegend = True
        End With


        'slRevArea.AxisY2.LineWidth = 2
        'slRevArea.AxisY2.Interval = 1
        'slRevArea.AxisY2.MajorGrid.Enabled = True

        With series_SLRev0
            .Palette = ChartColorPalette.EarthTones
            .ChartType = SeriesChartType.Column

        End With


        'series0
        'series1.Palette = ChartColorPalette.EarthTones
        'series1.ChartType = SeriesChartType.Column
        'If optTypeBar.Checked = True Then

        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)
        slRevArea.AxisX.MinorTickMark.Enabled = True
        'slArea.BackColor = Color.Black

        With chartRev
            .ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(slRevArea)
            .Series.Add(series_SLRev0)
            '.Series.Add(series1)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ' chartCS.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With

        lbCarCounter.Text = getCarNum()
        lbAVG_W.Text = Format(CDbl(lbCarCounter.Text) / CDbl(lbTotalRev.Text), "#,##0.00")
    End Sub


    Sub genDataTypeD()
        ' selQTy --  Q  หมายถึงแสดง แผ่น  ถ้าเป็น W หมายถึง ให้แสดงเป็น น้ำหนัก

        txtSQL = "Select  "
        For d = 1 To Microsoft.VisualBasic.Day(Now)
            If d = Microsoft.VisualBasic.Day(Now) Then

                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "] "

            Else

                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "],"

            End If
        Next

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_Code "

        Dim strDate As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")

        txtSQL = txtSQL & "Where trh_type = 'D' "
        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        txtSQL = txtSQL & ") "

        'txtSQL = txtSQL & "And (year(Trh_Date)=year(GETDATE()) "
        txtSQL = txtSQL & "And (year(Trh_Date)=year('" & strDate & "') "
        'txtSQL = txtSQL & "And month(Trh_Date)=month(GETDATE())) "
        txtSQL = txtSQL & "And month(Trh_Date)=month('" & strDate & "')) "

        'txtSQL = txtSQL & "And Not(dtl_detail='') "
        'txtSQL = txtSQL & "And dtl_detail='" & setTime & "' "

        txtSQL = txtSQL & "Group by  year(trh_Date),month(trh_Date) "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkTypeD = True Then

            subDS.Tables("rptTypeD").Clear()
            chkTypeD = False

        End If

        subDA.Fill(subDS, "rptTypeD")
        chkTypeD = True

        '======================================================================================================
        txtSQL = "Select  "
        For d = 1 To Microsoft.VisualBasic.Day(Now)
            If d = Microsoft.VisualBasic.Day(Now) Then

                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "] "

            Else

                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "],"

            End If

        Next

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_type=Dtl_type And Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_Code "

        'Dim strDate As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")

        txtSQL = txtSQL & "Where trh_type = 'S' "

        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' "
        txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") "

        txtSQL = txtSQL & "And dtl_price>0 "

        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        txtSQL = txtSQL & ") "

        txtSQL = txtSQL & "and not(Trh_sale='SL03' or Trh_Sale='SL12' ) "

        txtSQL = txtSQL & "And (year(Trh_Date)=year('" & strDate & "') "

        txtSQL = txtSQL & "And month(Trh_Date)=month('" & strDate & "')) "

        txtSQL = txtSQL & "Group by  year(trh_Date),month(trh_Date) "
        txtSQL = txtSQL & ""

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkTypeS = True Then

            subDS.Tables("rptTypeS").Clear()
            chkTypeS = False

        End If

        subDA.Fill(subDS, "rptTypeS")
        chkTypeS = True
        '=====================================================================================================


        Dim series_D0 As New Series("SERIES_D0")
        Dim series_S1 As New Series("SERIES_S1")
        Dim Area_TypeD As New ChartArea
        Area_TypeD.AxisX.LineWidth = 2
        Area_TypeD.AxisX.Interval = 1
        Area_TypeD.AxisX.MajorGrid.Enabled = False
        chartTypeD.Series.Clear()
        chartTypeD.ChartAreas.Clear()

        lbTotalTypeD.Text = 0
        lbTotalTypeS.Text = 0
        lbTarget19Sum.Text = 0
        lbDiff.Text = 0
        Dim Dcount As Integer = 0

        If subDS.Tables("rptTypeD").Rows.Count > 0 Then


            For i = 0 To subDS.Tables("rptTypeD").Columns.Count - 1
                If (subDS.Tables("rptTypeS").Rows(0).Item(i) > 0) And (subDS.Tables("rptTypeD").Columns(i).ColumnName > 0) Then

                    series_D0.Points.AddXY(subDS.Tables("rptTypeD").Columns(i).ColumnName, Format(subDS.Tables("rptTypeD").Rows(0).Item(i), "#,##0"))

                    series_S1.Points.AddXY(subDS.Tables("rptTypeS").Columns(i).ColumnName, Format(subDS.Tables("rptTypeS").Rows(0).Item(i), "#,##0"))

                    lbTotalTypeD.Text = Format(subDS.Tables("rptTypeD").Rows(0).Item(i) + lbTotalTypeD.Text, "#,##0.00")
                    lbTotalTypeS.Text = Format(subDS.Tables("rptTypeS").Rows(0).Item(i) + lbTotalTypeS.Text, "#,##0.00")
                    lbDiff.Text = Format(lbTotalTypeS.Text - lbTotalTypeD.Text, "#,##0.00")
                    AVGsales.Text = (lbTotalTypeS.Text / lbDayWork0.Text).ToString("#,##0.00")
                    AvgTypeP.Text = (lbTotalTypeD.Text / lbDayWork0.Text).ToString("#,##0.00")

                    'If subDS.Tables("rptTypeS").Rows(0).Item(i) > 0 Then
                    '    lbTarget19Sum.Text = Format((subDS.Tables("rptTypeS").Rows(0).Item(i) - txtSLtarget.Text) + lbTarget19Sum.Text, "#,##0.00")

                    'End If
                    Dcount = Dcount + 1
                    ' Dim eDate1 As Date = DateTime.DaysInMonth(2019, Month(Now)) & "/" & Month(Now) & "/" & Year(Now)
                    ' lbDayWork0.Text = calDayWork(Now, eDate1)

                End If


            Next

        End If
        If optColum.Checked = True Then
            series_D0.ChartType = SeriesChartType.Column
            series_S1.ChartType = SeriesChartType.Column
        Else
            series_D0.ChartType = SeriesChartType.Line
            series_S1.ChartType = SeriesChartType.Line
        End If

        series_D0.Color = Color.Red
        series_D0.BorderWidth = 4
        series_D0.IsValueShownAsLabel = True
        series_D0.IsVisibleInLegend = False
        series_D0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        series_S1.Color = Color.Blue
        series_S1.BorderWidth = 4
        series_S1.IsValueShownAsLabel = True
        series_S1.IsVisibleInLegend = False
        series_S1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)


        'series_D0.Palette = ChartColorPalette.EarthTones
        ' series_D0.ChartType = SeriesChartType.Column

        With chartTypeD
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(series_D0)
            .Series.Add(series_S1)
            .ChartAreas.Add(Area_TypeD)
            '.Series.Add(series1)
            .BorderlineWidth = 1
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

        End With

    End Sub

    Sub getDataNewCus()

        txtSQL = "select day(ar_add_date)day,count(ar_add_date)cCount  "

        txtSQL = txtSQL & "From ArFile "

        Dim strDate As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")

        txtSQL = txtSQL & "Where AR_type = 'AR' "

        'txtSQL = txtSQL & "And (year(Trh_Date)=year(GETDATE()) "
        txtSQL = txtSQL & "And (year(Ar_Add_Date)=year('" & strDate & "') "
        'txtSQL = txtSQL & "And month(Trh_Date)=month(GETDATE())) "
        txtSQL = txtSQL & "And month(Ar_Add_Date)=month('" & strDate & "')) "
        txtSQL = txtSQL & "and not(Ar_Sales='SL03' or Ar_Sales='SL12' ) "

        'txtSQL = txtSQL & "And Not(dtl_detail='') "
        'txtSQL = txtSQL & "And dtl_detail='" & setTime & "' "

        txtSQL = txtSQL & "Group by  (Ar_Add_Date)  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkNewCus = True Then

            subDS.Tables("rptNewCus").Clear()
            chkNewCus = False

        End If

        subDA.Fill(subDS, "rptNewCus")
        chkNewCus = True

        Dim Area_newC As New ChartArea
        Dim series_NewC As New Series("SERIES_NewC")
        'Dim series_S1 As New Series("SERIES_S1")

        Area_newC.AxisX.LineWidth = 2
        Area_newC.AxisX.Interval = 1
        Area_newC.AxisX.MajorGrid.Enabled = False

        chartNewCus.Series.Clear()
        chartNewCus.ChartAreas.Clear()

        lbTotalNewCus.Text = 0

        For i = 0 To subDS.Tables("rptNewCus").Rows.Count - 1

            series_NewC.Points.AddXY(subDS.Tables("rptNewCus").Rows(i).Item("day"), Format(subDS.Tables("rptNewCus").Rows(i).Item("cCount"), "#,##0"))

            lbTotalNewCus.Text = Format(Format(subDS.Tables("rptNewCus").Rows(i).Item("cCount") + lbTotalNewCus.Text, "#,##0.00"))

        Next

        series_NewC.ChartType = SeriesChartType.Column
        series_NewC.Color = Color.Green
        series_NewC.BorderWidth = 4
        series_NewC.IsValueShownAsLabel = True
        series_NewC.IsVisibleInLegend = False
        series_NewC.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        'series_D0.Palette = ChartColorPalette.EarthTones
        'series_D0.ChartType = SeriesChartType.Column

        With chartNewCus
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(Area_newC)
            .Series.Add(series_NewC)

            .BorderlineWidth = 1
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

        End With


    End Sub


    Sub genMonthlyReport()

        ' selQTy --  Q  หมายถึงแสดง แผ่น  ถ้าเป็น W หมายถึง ให้แสดงเป็น น้ำหนัก

        '======================================================================================================
        txtSQL = "Select  CS_Name,CS_Code,"
        txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,"
        txtSQL = txtSQL & "sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as Trh_Profit "

        'For d = 1 To Microsoft.VisualBasic.Day(Now)
        '    If d = Microsoft.VisualBasic.Day(Now) Then
        '        txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "] "

        '    Else
        '        txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "],"

        '    End If
        'Next

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join  TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=TranDataH.Trh_Cus  "
        txtSQL = txtSQL & "Left Join CSmast "
        txtSQL = txtSQL & "On Ar_Cs=CS_Code "
        ''===========================================================================================

        'Dim strDate As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")

        'txtSQL = txtSQL & " "
        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And ((Trh_Type='S'  ) "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "

        txtSQL = txtSQL & "And ( Year(Trh_Date) =year (GETDATE())  )  "
        'txtSQL = txtSQL & "And ( Day(Trh_Date)  =Day  (GetDate())  ) "
        txtSQL = txtSQL & "And ( Month(Trh_Date)=month(GetDate())  )  "
        txtSQL = txtSQL & "And CS_off=0 "
        '===========================================================================================
        'If selOptSL = 0 Then
        '    txtSQL = txtSQL & "And  Ar_CS='" & strCScode & "' "
        'Else
        '    txtSQL = txtSQL & "And  Ar_Sales='" & strCScode & "' "
        'End If
        ''===========================================================================================
        txtSQL = txtSQL & "Group by CS_Name,CS_Code  "
        txtSQL = txtSQL & " "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkTypeS = True Then

            subDS.Tables("rptTypeS").Clear()
            chkTypeS = False

        End If

        subDA.Fill(subDS, "rptTypeS")
        chkTypeS = True
        '=====================================================================================================

    End Sub

    Sub getDateAffter()
        'Dim dataDateS As Integer  'Microsoft.VisualBasic.Day(Now).ToString
        Dim dataMonthS As String
        'Dim dataYearS As Integer

        'Dim dataDateE As Integer
        Dim dataMonthE As String
        'Dim dataYearE As Integer


        If opt1Month.Checked = True Then

            'Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value)-1 & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) 
            'dataDateS = Microsoft.VisualBasic.Day(txtDate01.Value)
            dataMonthS = returnMM_YY(Month(txtDate01.Value) - 1, Year(Now()))
            ' dataYearS = Year(txtDate01.Value) - 543
            'lbAns.Text = dataDateS & "-" & dataMonthS & "-" & dataYearS
            lbDate1.Text = CDate(1 & "-" & dataMonthS)
            txtDate01.Value = lbDate1.Text

            ' dataDateE = Microsoft.VisualBasic.Day(txtDate01.Value)
            dataMonthE = returnMM_YY(Month(txtDate01.Value) + 1, Year(Now()))
            'dataYearE = Year(txtDate01.Value) - 543

            lbDate2.Text = DateAdd(DateInterval.Day, -1, CDate(1 & "-" & dataMonthE))
            txtDate02.Value = lbDate2.Text

        ElseIf opt3Month.Checked = True Then
            dataMonthS = returnMM_YY(Month(txtDate01.Value) - 4, Year(Now()))
            lbDate1.Text = CDate(1 & "-" & dataMonthS)
            txtDate01.Value = lbDate1.Text

            dataMonthE = returnMM_YY(Month(txtDate01.Value) + 4, Year(Now()))
            lbDate2.Text = DateAdd(DateInterval.Day, -1, CDate(1 & "-" & dataMonthE))
            txtDate02.Value = lbDate2.Text

        ElseIf opt6Month.Checked = True Then
            dataMonthS = returnMM_YY(Month(txtDate01.Value) - 7, Year(Now()))
            lbDate1.Text = CDate(1 & "-" & dataMonthS)
            txtDate01.Value = lbDate1.Text
            dataMonthE = returnMM_YY(Month(txtDate01.Value) + 7, Year(Now()))
            lbDate2.Text = DateAdd(DateInterval.Day, -1, CDate(1 & "-" & dataMonthE))

            txtDate02.Value = lbDate2.Text

        ElseIf opt12Month.Checked = True Then
            dataMonthS = returnMM_YY(Month(txtDate01.Value) - 13, Year(Now()))
            lbDate1.Text = CDate(1 & "-" & dataMonthS)
            txtDate01.Value = lbDate1.Text
            dataMonthE = returnMM_YY(Month(txtDate01.Value) + 13, Year(Now()))
            lbDate2.Text = DateAdd(DateInterval.Day, -1, CDate(1 & "-" & dataMonthE))

            txtDate02.Value = lbDate2.Text
        Else

        End If
    End Sub

    'Private Sub optColum_CheckedChanged(sender As Object, e As EventArgs) Handles optColum.CheckedChanged
    '    runAllProgram()

    'End Sub

    'Private Sub optLine_CheckedChanged(sender As Object, e As EventArgs) Handles optLine.CheckedChanged
    '    runAllProgram()
    'End Sub

    Private Sub optColum_Click(sender As Object, e As EventArgs)
        runAllProgram()
    End Sub

    Private Sub optLine_Click(sender As Object, e As EventArgs)
        runAllProgram()
    End Sub
    Sub runAllProgram()



        If chkLoad = True Then
            sales = Nothing
            sales = New salesObj
            sales.crt_SalesMan()
            getSales()

            Call CS_totalTargetYear()
            Call totalTargetYear()  '  new  2562


            genDataCSOrder()
            genDataSales()
            CS_genDataSales()
            genDataTypeD()
            genMonthlyReport()
            getDataNewCus()
            genDataRev()
            getChartYear()
            lbTimer.Text = Format(Now, "HH:mm:ss")
        End If
    End Sub

    Function calDayWork(d1 As Date, d2 As Date) As Integer
        Dim intSum As Integer = 0
        ' Dim endDate As Date = "31/12/2562"
        ' หาจำนวนวันทำงานระหว่าง D1 ถึง D2  ที่ตัดวันอาทิตย์ออก ไม่รวมวันหยุดไทย  
        Do While (d1 <= d2)
            If d1.DayOfWeek <> DayOfWeek.Sunday Then
                intSum = intSum + 1
            End If
            d1 = d1.AddDays(1)
        Loop
        Return intSum

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        runAllProgram()
    End Sub

    Private Sub cmdSalesSum_Click(sender As Object, e As EventArgs) Handles cmdSalesSum.Click
        Dim frmSalesSum As New frmSalesSum
        Timer1.Enabled = False
        frmSalesSum.Show()
    End Sub

    Private Sub cmbPending_Click(sender As Object, e As EventArgs) Handles cmbPending.Click
        Dim frmPending As New frmPendingOrder
        Timer1.Enabled = False
        frmPending.Show()

    End Sub

    Private Sub txtSLtarget_TextChanged(sender As Object, e As EventArgs)
        txtSLtarget2.Text = txtSLtarget.Text
    End Sub

    Private Sub frmMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End

    End Sub

    Private Sub frmMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub

    Private Sub cboAnalyTT_Click(sender As Object, e As EventArgs) Handles cboAnalyTT.Click
        'Dim frmSAbyTT As New frmMenuTT 'frmSAbyTT
        Dim frmSAbyTT As New frmSAbyTT
        Timer1.Enabled = False

        frmSAbyTT.Show()

    End Sub

    Private Sub cmbRptCS_Click(sender As Object, e As EventArgs) Handles cmbRptCS.Click
        Dim frmCSanaly As New frmRptCSmast
        Timer1.Enabled = False
        frmCSanaly.Show()
    End Sub

    Private Sub cmbRptStkSales_Click(sender As Object, e As EventArgs) Handles cmbRptStkSales.Click
        Dim frmStkRota As New frmStkRota
        Timer1.Enabled = False
        frmStkRota.Show()
    End Sub


    Private Sub opt1Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt1Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()

    End Sub

    Private Sub opt3Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt3Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        'runAllProgram()
    End Sub


    Private Sub optSelDay_CheckedChanged(sender As Object, e As EventArgs) Handles optSelDay.CheckedChanged
        txtDate01.Value = Now
        lbDate1.Text = txtDate01.Value

        txtDate02.Value = Now
        lbDate2.Text = txtDate02.Value
        'runAllProgram()
    End Sub

    Private Sub opt12Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt12Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        'runAllProgram()
    End Sub

    Private Sub opt6Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt6Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        ' runAllProgram()
    End Sub

    Private Sub optRatio_CheckedChanged(sender As Object, e As EventArgs) Handles optRatio.CheckedChanged

    End Sub

    Private Sub optRatio_Click(sender As Object, e As EventArgs) Handles optRatio.Click
        If chkLoad = True Then
            If optRatio.Checked = True Then
                lbProfitUnit_SL.Text = "กำไร Sales (%)"
                lbProfitUnit_CS.Text = "กำไร CS (%)"
                lbWeightUnit_SL.Text = "น้ำหนัก Sales (%)"
                lbWeightUnit_CS.Text = "น้ำหนัก CS (%)"
                lbAmtUnit_SL.Text = "มูลค่าขาย Sales (%)"
                lbAmtUnit_CS.Text = "มูลค่าขาย CS (%)"

            ElseIf optValue.checked = True Then

                lbProfitUnit_SL.Text = "กำไร Sales (บาท)"
                lbProfitUnit_CS.Text = "กำไร CS (บาท)"
                lbWeightUnit_SL.Text = "น้ำหนัก Sales (ตัน)"
                lbWeightUnit_CS.Text = "น้ำหนัก CS (ตัน)"
                lbAmtUnit_SL.Text = "มูลค่าขาย Sales (บาท)"
                lbAmtUnit_CS.Text = "มูลค่าขาย CS (บาท)"
            End If


        End If
        runAllProgram()
    End Sub

    Private Sub optValue_CheckedChanged(sender As Object, e As EventArgs) Handles optValue.CheckedChanged

    End Sub

    Private Sub optValue_Click(sender As Object, e As EventArgs) Handles optValue.Click

        If chkLoad = True Then
            If optRatio.Checked = True Then
                lbProfitUnit_SL.Text = "กำไร Sales (%)"
                lbProfitUnit_CS.Text = "กำไร CS (%)"
                lbWeightUnit_SL.Text = "น้ำหนัก Sales (%)"
                lbWeightUnit_CS.Text = "น้ำหนัก CS (%)"
                lbAmtUnit_SL.Text = "มูลค่าขาย Sales (%)"
                lbAmtUnit_CS.Text = "มูลค่าขาย CS (%)"

            ElseIf optValue.Checked = True Then

                lbProfitUnit_SL.Text = "กำไร Sales (บาท)"
                lbProfitUnit_CS.Text = "กำไร CS (บาท)"
                lbWeightUnit_SL.Text = "น้ำหนัก Sales (ตัน)"
                lbWeightUnit_CS.Text = "น้ำหนัก CS (ตัน)"
                lbAmtUnit_SL.Text = "มูลค่าขาย Sales (บาท)"
                lbAmtUnit_CS.Text = "มูลค่าขาย CS (บาท)"
            End If


        End If
        runAllProgram()
    End Sub

    Private Sub txtDate02_ValueChanged(sender As Object, e As EventArgs) Handles txtDate02.ValueChanged

    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
        txtDate02.Value = txtDate01.Value
    End Sub

    Private Sub chkShowKPI_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowKPI.CheckedChanged

    End Sub

    Private Sub chkShowKPI_Click(sender As Object, e As EventArgs) Handles chkShowKPI.Click
        runAllProgram()
    End Sub
End Class