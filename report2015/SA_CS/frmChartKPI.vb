Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmChartKPI
    Dim SalesCode As String = selCS

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub frmChartKPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim strDate As Date = "03/01/2562"
        Dim endDate As Date = "28/12/2562"
        'Call txtCLS()
        i = calDayWork(Now, endDate) - 13
        lbDayQty.Text = i
        lbDayQty0.Text = calDayWork(strDate, endDate) - 13  '  13 ที่ลบที่หลังคือ ลบวันหยุด 13 วันต่อปี
        lbActDay.Text = lbDayQty0.Text - lbDayQty.Text
        showData()

    End Sub

    Sub showData()

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select Ar_Cus_ID,Ar_Name,Ar_LastSales_Date,Amphoe_Name,AmphoeMast.Country_Name,Ar_Tel_No,AR_Contact,"
        txtSQL = txtSQL & "sum(isnull(TrHnow.Trh_Amt,0))as sumTrh_AmtNow,"
        txtSQL = txtSQL & "sum(isnull(Trhnow.Profit,0))as sumTrh_Profit,"

        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_Amt,0) else  0 end ) as actGPSales, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_W,0) else  0 end ) as actGPWeight, "
        txtSQL = txtSQL & "sum(case when (Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(Trhnow.Profit,0) else  0 end ) as actGPProfit, "

        txtSQL = txtSQL & "sum(case when not(Trhnow.Trh_ProD_Sales='01') then "
        txtSQL = txtSQL & "     isnull(TrhNow.Trh_Amt,0) else  0 end ) as actTTSales, "
        txtSQL = txtSQL & "sum(case when not(Trhnow.Trh_ProD_Sales='01') then "
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

        txtSQL = txtSQL & "Left Join AmphoeMast "
        txtSQL = txtSQL & "On ArFile.Ar_Amphoe_Code=AmphoeMast.Amphoe_Code "

        txtSQL = txtSQL & "Left Join  "
        '===========================================================================================
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select Trh_Cus,Trh_ProD_Sales,sum(Trh_Amt)as Trh_Amt,sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_Amt-Trh_Cost_Amt)as Profit "

        txtSQL = txtSQL & "From TranDataH  "
        txtSQL = txtSQL & "Where Trh_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE()))  "
        'txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())))  "
        txtSQL = txtSQL & "Group by Trh_Cus,Trh_ProD_Sales "
        txtSQL = txtSQL & " ) TrHNow "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrhNow.Trh_Cus  "
        '===========================================================================================
        If selOptSL = 0 Then
            txtSQL = txtSQL & "Where     Ar_CS='" & SalesCode & "' "
        Else
            txtSQL = txtSQL & "Where    Ar_Sales='" & SalesCode & "' "
        End If
        ''===========================================================================================
        txtSQL = txtSQL & "Group by  AR_CUS_ID,Ar_Name,Ar_LastSales_Date ,Amphoe_Name,AmphoeMast.Country_Name,Ar_Tel_No,AR_CONTACT,"
        txtSQL = txtSQL & "Ar_Sales_Target,Ar_SL_Target,Ar_Profit,AR_GP_SL_Target,Ar_GP_W_Target,"
        txtSQL = txtSQL & "Ar_GP_Profit,Ar_TT_SL_Target,Ar_TT_Profit "

        'If optOrdTarget.Checked = True Then
        '    txtSQL = txtSQL & "order by Sum(isnull(Ar_Sales_Target,0)) desc  "
        'ElseIf optOrdLastDate.Checked = True Then
        '    txtSQL = txtSQL & "order by Ar_LastSales_Date desc  "
        'ElseIf optOrdSumSales.Checked = True Then
        '    txtSQL = txtSQL & "order by sum(isnull(TrHnow.Trh_Amt,0)) desc  "
        'ElseIf optZone.Checked = True Then
        '    txtSQL = txtSQL & "Order by Amphoe_Name "
        'End If

        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csShow")

        Dim std_Profit As Double = 0
        Dim Perf_Profit As Double = 0
        Dim sim_Profit As Double = 0

        For i = 0 To subDS.Tables("csShow").Rows.Count - 1
            With subDS.Tables("csShow").Rows(i)
                'Format(.Item("SLProfit") + lbTarget_Profit.Text, "#,##0.00")
                std_Profit = std_Profit + .Item("SLProfit")
                Perf_Profit = Perf_Profit + .Item("sumTrh_Profit")


            End With

        Next
        lbSim_Profit.Text = Format((std_Profit - Perf_Profit) / lbDayQty.Text, "#,##0.00")
        lbStd_Profit.Text = Format(std_Profit / lbDayQty0.Text, "#,##0.00")
        lbPerf_Profit.Text = Format(Perf_Profit / lbActDay.Text, "#,##0.00")

        txtSQL = "Select Trh_Type,Trh_Date,"
        txtSQL = txtSQL & "sum(Trh_Amt)as Trh_Amt,"
        txtSQL = txtSQL & "sum(Trh_w_sum)as Trh_W,"
        txtSQL = txtSQL & "sum(Trh_Amt-Trh_Cost_Amt)as Trh_Profit "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join  TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=TranDataH.Trh_Cus  "
        ''===========================================================================================

        'txtSQL = txtSQL & " "
        txtSQL = txtSQL & "Where Trh_Amt > 0 "
        txtSQL = txtSQL & "And ((Trh_Type='S'  ) "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "

        txtSQL = txtSQL & "And ( Year(Trh_Date) =year (GETDATE())  )  "
        'txtSQL = txtSQL & "And ( Day(Trh_Date)  =Day  (GetDate())  ) "
        txtSQL = txtSQL & "And ( Month(Trh_Date)=month(GetDate())  )  "

        '===========================================================================================
        If selOptSL = 0 Then
            txtSQL = txtSQL & "And  Ar_CS='" & SalesCode & "' "
        Else
            txtSQL = txtSQL & "And  Ar_Sales='" & SalesCode & "' "
        End If
        ''===========================================================================================
        txtSQL = txtSQL & "Group by Trh_Type,TRh_Date  "
        txtSQL = txtSQL & " "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "csMonthly")

        Dim seriesAct As New Series
        Dim seriesStd As New Series
        Dim seriesAvg As New Series
        Dim seriesSim As New Series


        chartAct.Series.Clear()
        For M = 0 To subDS.Tables("csMonthly").Rows.Count - 1
            With subDS.Tables("csMonthly").Rows(M)
                Dim stdDate As Date = Format(DateAdd(DateInterval.Year, -543, .Item("Trh_Date")), "dd/MM/yyyy")
                '============================================================
                seriesStd.Points.AddXY(stdDate, lbStd_Profit.Text)
                seriesAct.Points.AddXY(stdDate, .Item("Trh_Profit"))
                seriesAvg.Points.AddXY(stdDate, lbPerf_Profit.Text)
                seriesSim.Points.AddXY(stdDate, lbSim_Profit.Text)
            End With
        Next

        '============================================================
        With seriesStd
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.OrangeRed
            .LabelFormat = "#,##0.00"
            .BorderWidth = 2
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        With seriesSim
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.White
            .LabelFormat = "#,##0.00"
            .BorderWidth = 1
            '.BorderDashStyle = ChartDashStyle.Dot
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        With seriesAvg
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.DeepSkyBlue
            .LabelFormat = "#,##0.00"
            .BorderWidth = 2
            .IsValueShownAsLabel = False  '  แสดงค่าบนกราฟ
            .IsVisibleInLegend = False  ' แสดงป้ายชื่อข้างกราฟ
            .LabelAngle = 0    ' หมุน Label แสดงค่าบนกราฟ
            .LabelToolTip = "#VAL"  '  เอา mouse วางที่กราฟ แล้วแสดงค่า
        End With
        With seriesAct
            .ChartType = DataVisualization.Charting.SeriesChartType.Point


            .Color = Color.GreenYellow
            ' .BorderColor
            .LabelFormat = "#,##0.00"
            .BorderWidth = 4
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
        With ChartM
            '.AxisX.LineWidth = 2
            '.AxisX.Interval = 1
            '.AxisX.MajorGrid.Enabled = True
            '.AxisX.MinorTickMark.Enabled = True
            '.BorderColor = Color.White
            '.BorderWidth = 1
            '.AxisY.MajorGrid.LineColor = Color.White
            '.AxisY.MajorGrid.LineWidth = 1

        End With

        With chartAct

            .ChartAreas.Add(ChartM)
            .BorderlineWidth = 1
            .BorderlineColor = Color.White
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal

            .Series.Add(seriesStd)
            .Series.Add(seriesAvg)
            .Series.Add(seriesSim)
            .Series.Add(seriesAct)
        End With
    End Sub

    Private Sub chartAct_Click(sender As Object, e As EventArgs) Handles chartAct.Click

    End Sub
End Class