Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmMenu

    Dim chkSCData As Boolean = False
    Dim chkSLData As Boolean = False
    Dim chkRevData As Boolean = False
    Dim chkTypeD As Boolean = False
    Dim chkTypeS As Boolean = False
    Dim chkNewCus As Boolean = False


    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet
    Dim chkLoad As Boolean = False



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

        chkLoad = True

        runAllProgram()

        lbTimer.Text = Format(Now, "HH:mm:ss")
        'frmRPTstkSummary.MdiParent = Me
        'frmRptDetail.MdiParent = Me


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

        txtSQL = "Select Trh_Type,"
        txtSQL = txtSQL & "(CS_Name)as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num)as SumAmt,"
        txtSQL = txtSQL & "sum((Dtl_Num*Stk_Factor)/1000) as sumQw,"
        txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num)/(Dtl_Num*Stk_Factor)) as sumPrKg "

        txtSQL = txtSQL & "From TranDataH Left Join TranDataD  "
        txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "

        txtSQL = txtSQL & "left Join CSMast "
        txtSQL = txtSQL & "on Trh_user=CS_Code "
        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        txtSQL = txtSQL & "left join ProGrpMast "
        txtSQL = txtSQL & "On Stk_Prod=Progrp_id "

        txtSQL = txtSQL & "Where Trh_Type='B'  "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' "
        txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") "

        txtSQL = txtSQL & "And dtl_price>0 "
        txtSQL = txtSQL & "And not(Trh_user is null) "
        ' ==========  เลือกช่วงเวลา ================
        ' txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        txtSQL = txtSQL & "And dtl_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And dtl_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "

        'If optOneDay.Checked = True Then

        'ElseIf optGrp1M.Checked = True Then
        '    txtSQL = txtSQL & "and (month(Trh_Date)='" & Month(Now) & "' "
        '    txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        'ElseIf optGrpYear.Checked = True Then
        '    txtSQL = txtSQL & "and (year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        'ElseIf optGrp3M.Checked = True Then
        '    If getQvalues() = "T1" Then
        '        txtSQL = txtSQL & "and (  (month(Trh_Date)>='1' and month(Trh_Date)<='3')  "
        '        txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        '    ElseIf getQvalues() = "T2" Then
        '        txtSQL = txtSQL & "and (  (month(Trh_Date)>='4' and month(Trh_Date)<='6')  "
        '        txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        '    ElseIf getQvalues() = "T3" Then
        '        txtSQL = txtSQL & "and (  (month(Trh_Date)>='7' and month(Trh_Date)<='9')  "
        '        txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        '    ElseIf getQvalues() = "T4" Then
        '        txtSQL = txtSQL & "and (  (month(Trh_Date)>='10' and month(Trh_Date)<='12')  "
        '        txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
        '    End If
        'End If

        ' ==========  เลือกช่วงเวลา ================


        'txtSQL = txtSQL & "And Dtl_wh='01' "
0:      txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        txtSQL = txtSQL & ") "
        'If optGP.Checked = True Then

        'ElseIf optNPD.Checked = True Then
        '    txtSQL = txtSQL & "Stk_Prod='05' "
        'ElseIf optTT.Checked = True Then
        '    txtSQL = txtSQL & "Stk_Prod='02' "
        'ElseIf optGPNPD.Checked = True Then
        '    txtSQL = txtSQL & "Stk_Prod='01' or Stk_Prod='05' "

        'ElseIf optTotal.Checked = True Then

        '    txtSQL = txtSQL & "Stk_Prod='01' or Stk_Prod='02' or Stk_Prod='05' "

        'End If

        'txtSQL = txtSQL & "Order Stk_Prod='' "

        txtSQL = txtSQL & "and not(Trh_sale='SL03' "
        'txtSQL = txtSQL & "or Trh_Sale='SL12' " '  พนักงานขาย YT
        txtSQL = txtSQL & " ) "
        txtSQL = txtSQL & "Group by   Trh_Type,CS_Name "
        'If optByGrpSL.Checked = True Then

        '    If optTotal.Checked = True Then

        '    Else
        '        txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Stk_Prod,Progrp_Name "
        '    End If
        'Else
        '    If optTotal.Checked = True Then
        '        'txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Progrp_Name  "
        '        txtSQL = txtSQL & "Group by   Trh_Type,CS_Name   "
        '    Else
        '        txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Stk_Prod,Progrp_Name "
        '    End If

        'End If  

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

        chartCS.Series.Clear()
        chartCS.ChartAreas.Clear()
        lbTotalCS.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptCS01").Rows.Count + 1
        Me.Refresh()
        For i = 0 To subDS.Tables("rptCS01").Rows.Count - 1
            indexBar.PerformStep()
            indexBar.Value = i
            With subDS.Tables("rptCS01").Rows(i)
                'If optAmt.Checked = True Then
                '    series1.Points.AddXY(.Item("Sale"), Format(.Item("SumAmt"), "#,##0.000"))

                'Else

                'End If
                series0.Points.AddXY(.Item("Sale"), Format(.Item("sumQw"), "#,##0.00"))

                lbTotalCS.Text = Format(.Item("sumQw") + CDbl(lbTotalCS.Text), "#,##0.00")

            End With
            Me.Refresh()
        Next

        series0.ChartType = SeriesChartType.Column
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        'series0.IsXValueIndexed = True

        'series1.ChartType = SeriesChartType.Column
        'series1.BorderWidth = 4
        'series1.IsValueShownAsLabel = True
        'series1.IsVisibleInLegend = False
        'series1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)


        series0.Palette = ChartColorPalette.EarthTones
        'series0.ChartType = SeriesChartType.Column
        'series0.IsVisibleInLegend = True
        'series1.Palette = ChartColorPalette.EarthTones
        'series1.ChartType = SeriesChartType.Column
        'If optTypeBar.Checked = True Then

        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)

        With chartCS
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

        txtSQL = "Select Trh_Type,"
        txtSQL = txtSQL & "(SL_NickName)as Sale,"
        'txtSQL=txtSQL & ",Progrp_Name,"

        txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num)as SumAmt,"
        txtSQL = txtSQL & "sum((Dtl_Num*Stk_Factor)/1000) as sumQw,"
        txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num)/(Dtl_Num*Stk_Factor)) as sumPrKg "

        txtSQL = txtSQL & "From TranDataH Left Join TranDataD  "
        txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "

        txtSQL = txtSQL & "left Join SalesMan "
        txtSQL = txtSQL & "on Trh_Sale=SL_ID "
        'txtSQL = txtSQL & "Left Join grpSales "
        'txtSQL = txtSQL & "On sl_grp=Grps_id "
        txtSQL = txtSQL & "left join ProGrpMast "
        txtSQL = txtSQL & "On Stk_Prod=Progrp_id "

        txtSQL = txtSQL & "Where (Trh_Type='S'  "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' "
        txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") )"

        txtSQL = txtSQL & "And dtl_price>0 "
        txtSQL = txtSQL & "And not(Trh_user is null) "
        ' ==========  เลือกช่วงเวลา ================



        txtSQL = txtSQL & "And dtl_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And dtl_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "


        ' txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "

        ' ==========  เลือกช่วงเวลา ================


        'txtSQL = txtSQL & "And Dtl_wh='01' "
        txtSQL = txtSQL & "And ("
        txtSQL = txtSQL & "Stk_Prod='01' "
        txtSQL = txtSQL & ") "


        txtSQL = txtSQL & "and not(Trh_sale='SL03'or TRh_Sale='SL14' or Trh_Sale='SL12' ) "
        txtSQL = txtSQL & "Group by   Trh_Type,SL_NickName "


        txtSQL = txtSQL & "Order by sumQw desc  "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)

        If chkSLData = True Then

            subDS.Tables("rptSL01").Clear()
            chkSLData = False

        End If

        subDA.Fill(subDS, "rptSL01")
        chkSLData = True

        ' Dim slChart As New Series
        Dim slArea As New ChartArea
        Dim series_SL0 As New Series("SERIES_SL0")
        'Dim series_SL1 As New Series("SERIES_SL1")

        chartSL.ChartAreas.Clear()
        chartSL.Series.Clear()
        'chartSL.ChartAreas(0).AxisX.LineWidth = 2
        'chartSL.ChartAreas(0).AxisX.Interval = 1
        slArea.AxisX.LineWidth = 2
        slArea.AxisX.Interval = 1
        slArea.AxisX.MajorGrid.Enabled = False

        lbTotalSL.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptSL01").Rows.Count + 1

        Me.Refresh()

        For i = 0 To subDS.Tables("rptSL01").Rows.Count - 1
            indexBar.PerformStep()
            indexBar.Value = i
            With subDS.Tables("rptSL01").Rows(i)
                'If optAmt.Checked = True Then
                '    series1.Points.AddXY(.Item("Sale"), Format(.Item("SumAmt"), "#,##0.000"))

                'Else

                'End If
                series_SL0.Points.AddXY(.Item("Sale"), Format(.Item("sumQw"), "#,##0.00"))
                lbTotalSL.Text = Format((.Item("sumQw") + CDbl(lbTotalSL.Text)), "#,##0.00")

            End With
            Me.Refresh()
        Next

        series_SL0.ChartType = SeriesChartType.Column
        series_SL0.BorderWidth = 4
        series_SL0.IsValueShownAsLabel = True
        series_SL0.IsVisibleInLegend = False

        series_SL0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        'series0.IsXValueIndexed = True

        'series1.ChartType = SeriesChartType.Column
        'series1.BorderWidth = 4
        'series1.IsValueShownAsLabel = True
        'series1.IsVisibleInLegend = False
        'series1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)


        series_SL0.Palette = ChartColorPalette.EarthTones
        series_SL0.ChartType = SeriesChartType.Column

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

        With chartSL
            .ForeColor = Color.White
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .ChartAreas.Add(slArea)
            .Series.Add(series_SL0)
            '.Series.Add(series1)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ' chartCS.ChartAreas(0).AxisY.Maximum = max0 + 3
        End With

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
    Sub genDataRev()

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

        slRevArea.AxisX.LineWidth = 2
        slRevArea.AxisX.Interval = 1
        slRevArea.AxisX.MajorGrid.Enabled = False

        lbTotalRev.Text = 0
        indexBar.Value = 0
        indexBar.Minimum = 0
        indexBar.Maximum = subDS.Tables("rptSLRev01").Rows.Count + 1

        Me.Refresh()

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
            Me.Refresh()
        Next

        series_SLRev0.ChartType = SeriesChartType.Column
        series_SLRev0.BorderWidth = 4
        series_SLRev0.IsValueShownAsLabel = True
        series_SLRev0.IsVisibleInLegend = False

        series_SLRev0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        'series0.IsXValueIndexed = True

        'series1.ChartType = SeriesChartType.Column
        'series1.BorderWidth = 4
        'series1.IsValueShownAsLabel = True
        'series1.IsVisibleInLegend = False
        'series1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        'slRevArea.AxisY2.LineWidth = 2
        'slRevArea.AxisY2.Interval = 1
        'slRevArea.AxisY2.MajorGrid.Enabled = True

        series_SLRev0.Palette = ChartColorPalette.EarthTones
        series_SLRev0.ChartType = SeriesChartType.Column

        'series0.IsVisibleInLegend = True
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
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 2 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [02],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 3 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [03],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 4 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [04],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 5 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [05],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 6 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [06],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 7 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [07],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 8 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [08],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 9 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [09],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 10 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [10],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 11 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [11],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 12 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [12],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 13 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [13],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 14 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [14],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 15 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [15],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 16 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [16],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 17 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [17],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 18 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [18],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 19 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [19],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 20 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [20],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 21 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [21],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 22 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [22],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 23 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [23],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 24 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [24],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 25 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [25],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 26 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [26],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 27 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [27],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 28 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [28],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 29 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [29],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 30 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [30],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 31 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [31] "

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
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 2 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [02],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 3 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [03],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 4 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [04],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 5 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [05],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 6 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [06],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 7 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [07],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 8 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [08],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 9 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [09],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 10 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [10],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 11 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [11],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 12 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [12],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 13 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [13],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 14 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [14],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 15 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [15],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 16 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [16],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 17 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [17],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 18 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [18],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 19 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [19],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 20 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [20],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 21 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [21],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 22 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [22],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 23 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [23],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 24 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [24],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 25 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [25],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 26 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [26],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 27 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [27],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 28 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [28],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 29 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [29],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 30 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [30],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 31 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [31] "

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
                    AVGsales.Text = (lbTotalTypeS.Text / lbCountDate.Text).ToString("#,##0.00")
                    AvgTypeP.Text = (lbTotalTypeD.Text / lbCountDate.Text).ToString("#,##0.00")

                    'If subDS.Tables("rptTypeS").Rows(0).Item(i) > 0 Then
                    '    lbTarget19Sum.Text = Format((subDS.Tables("rptTypeS").Rows(0).Item(i) - txtSLtarget.Text) + lbTarget19Sum.Text, "#,##0.00")

                    'End If
                    Dcount = Dcount + 1
                    lbCountDate.Text = Dcount

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


    Sub genData19Ton()

        ' selQTy --  Q  หมายถึงแสดง แผ่น  ถ้าเป็น W หมายถึง ให้แสดงเป็น น้ำหนัก

        '======================================================================================================
        txtSQL = "Select  "

        For d = 1 To Microsoft.VisualBasic.Day(Now)
            If d = Microsoft.VisualBasic.Day(Now) Then
                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "] "

            Else
                txtSQL = txtSQL & "sum(case when day(trh_date) = " & d & " Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [" & d & "],"

            End If

        Next
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 2 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [02],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 3 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [03],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 4 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [04],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 5 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [05],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 6 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [06],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 7 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [07],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 8 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [08],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 9 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [09],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 10 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [10],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 11 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [11],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 12 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [12],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 13 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [13],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 14 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [14],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 15 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [15],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 16 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [16],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 17 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [17],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 18 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [18],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 19 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [19],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 20 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [20],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 21 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [21],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 22 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [22],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 23 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [23],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 24 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [24],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 25 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [25],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 26 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [26],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 27 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [27],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 28 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [28],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 29 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [29],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 30 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [30],"
        'txtSQL = txtSQL & "sum(case when day(trh_date) = 31 Then (Dtl_Num * Stk_Factor)/1000 Else 0 End) As [31] "

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

        Dim strDate As String = Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")

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

        Dim Area_TypeS As New ChartArea
        Dim series_19T As New Series("SERIES_D0")
        Dim series_S1 As New Series("SERIES_S1")

        Area_TypeS.AxisX.LineWidth = 2
        Area_TypeS.AxisX.Interval = 1
        Area_TypeS.AxisX.MajorGrid.Enabled = False
        chart19t.Series.Clear()
        chart19t.ChartAreas.Clear()

        lbTarget19Sum.Text = 0
        lbTarget19d.Text = 0

        For i = 0 To subDS.Tables("rptTypeS").Columns.Count - 1

            If subDS.Tables("rptTypeS").Rows(0).Item(i) > 0 Then

                series_19T.Points.AddXY(subDS.Tables("rptTypeS").Columns(i).ColumnName, (txtSLtarget.Text))
                series_S1.Points.AddXY(subDS.Tables("rptTypeS").Columns(i).ColumnName, Format(subDS.Tables("rptTypeS").Rows(0).Item(i), "#,##0"))
                lbTarget19Sum.Text = Format((subDS.Tables("rptTypeS").Rows(0).Item(i) - (txtSLtarget.Text)) + lbTarget19Sum.Text, "#,##0.00")

            End If

        Next
        Dim rowCount As Integer = subDS.Tables("rptTypeS").Rows.Count
        lbTarget19d.Text = Format(subDS.Tables("rptTypeS").Rows(0).Item(rowCount - 1) - (txtSLtarget.Text), "#,##0.00")

        If optColum.Checked = True Then
            series_19T.ChartType = SeriesChartType.Column
            series_S1.ChartType = SeriesChartType.Column
        Else
            series_19T.ChartType = SeriesChartType.Line
            series_S1.ChartType = SeriesChartType.Line
        End If

        series_19T.Color = Color.Red
        series_19T.BorderWidth = 4
        series_19T.IsValueShownAsLabel = True
        series_19T.IsVisibleInLegend = False
        series_19T.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        series_S1.Color = Color.Blue
        series_S1.BorderWidth = 4
        series_S1.IsValueShownAsLabel = True
        series_S1.IsVisibleInLegend = False
        series_S1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        'series_D0.Palette = ChartColorPalette.EarthTones
        ' series_D0.ChartType = SeriesChartType.Column

        With chart19t
            '.BackColor = Color.Black
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(series_19T)
            .Series.Add(series_S1)
            .ChartAreas.Add(Area_TypeS)
            '.Series.Add(series1)
            .BorderlineWidth = 1
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด

        End With

    End Sub

    Sub getDateAffter()
        Dim dataDateS As Integer  'Microsoft.VisualBasic.Day(Now).ToString
        Dim dataMonthS As Integer
        Dim dataYearS As Integer

        Dim dataDateE As Integer
        Dim dataMonthE As Integer
        Dim dataYearE As Integer

        If opt1Month.Checked = True Then

            dataDateS = DateAdd(DateInterval.Month, -1, txtDate01.Value).Day
            dataMonthS = DateAdd(DateInterval.Month, -1, txtDate01.Value).Month
            dataYearS = DateAdd(DateInterval.Month, -1, txtDate01.Value).Year
            'lbAns.Text = dataDateS & "-" & dataMonthS & "-" & dataYearS
            lbDate1.Text = DateAdd(DateInterval.Year, 543, CDate(1 & "-" & dataMonthS & "-" & dataYearS))
            txtDate01.Value = lbDate1.Text

            dataDateE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, txtDate01.Value)).Day
            dataMonthE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, txtDate01.Value)).Month
            dataYearE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, txtDate01.Value)).Year

            lbDate2.Text = DateAdd(DateInterval.Year, 543, CDate(dataDateE & "-" & dataMonthE & "-" & dataYearE))
            txtDate02.Value = lbDate2.Text

        ElseIf opt3Month.Checked = True Then
            dataDateS = DateAdd(DateInterval.Month, -3, txtDate01.Value).Day
            dataMonthS = DateAdd(DateInterval.Month, -3, txtDate01.Value).Month
            dataYearS = DateAdd(DateInterval.Month, -3, txtDate01.Value).Year
            lbDate1.Text = DateAdd(DateInterval.Year, 543, CDate(1 & "-" & dataMonthS & "-" & dataYearS))
            txtDate01.Value = lbDate1.Text

            dataDateE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 3, txtDate01.Value)).Day
            dataMonthE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 3, txtDate01.Value)).Month
            dataYearE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 3, txtDate01.Value)).Year

            lbDate2.Text = DateAdd(DateInterval.Year, 543, CDate(dataDateE & "-" & dataMonthE & "-" & dataYearE))
            txtDate02.Value = lbDate2.Text

        ElseIf opt6Month.Checked = True Then
            dataDateS = DateAdd(DateInterval.Month, -6, txtDate01.Value).Day
            dataMonthS = DateAdd(DateInterval.Month, -6, txtDate01.Value).Month
            dataYearS = DateAdd(DateInterval.Month, -6, txtDate01.Value).Year
            'lbAns.Text = dataDateS & "-" & dataMonthS & "-" & dataYearS
            lbDate1.Text = DateAdd(DateInterval.Year, 543, CDate(1 & "-" & dataMonthS & "-" & dataYearS))
            txtDate01.Value = lbDate1.Text

            ' DateAdd(DateInterval.Day, -1, txtDate01.Value)
            dataDateE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 6, txtDate01.Value)).Day
            dataMonthE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 6, txtDate01.Value)).Month
            dataYearE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 6, txtDate01.Value)).Year

            lbDate2.Text = DateAdd(DateInterval.Year, 543, CDate(dataDateE & "-" & dataMonthE & "-" & dataYearE))
            txtDate02.Value = lbDate2.Text

        ElseIf opt12Month.Checked = True Then
            dataDateS = DateAdd(DateInterval.Month, -12, txtDate01.Value).Day
            dataMonthS = DateAdd(DateInterval.Month, -12, txtDate01.Value).Month
            dataYearS = DateAdd(DateInterval.Month, -12, txtDate01.Value).Year
            'lbAns.Text = dataDateS & "-" & dataMonthS & "-" & dataYearS
            lbDate1.Text = DateAdd(DateInterval.Year, 543, CDate(1 & "-" & dataMonthS & "-" & dataYearS))
            txtDate01.Value = lbDate1.Text

            dataDateE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 12, txtDate01.Value)).Day
            dataMonthE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 12, txtDate01.Value)).Month
            dataYearE = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 12, txtDate01.Value)).Year

            lbDate2.Text = DateAdd(DateInterval.Year, 543, CDate(dataDateE & "-" & dataMonthE & "-" & dataYearE))
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

    Private Sub optColum_Click(sender As Object, e As EventArgs) Handles optColum.Click
        runAllProgram()
    End Sub

    Private Sub optLine_Click(sender As Object, e As EventArgs) Handles optLine.Click
        runAllProgram()
    End Sub
    Sub runAllProgram()
        If chkLoad = True Then

            genDataCSOrder()
            genDataSales()
            genDataTypeD()
            genData19Ton()
            getDataNewCus()
            genDataRev()

            lbTimer.Text = Format(Now, "HH:mm:ss")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        runAllProgram()
    End Sub

    Private Sub cmdSalesSum_Click(sender As Object, e As EventArgs) Handles cmdSalesSum.Click
        Dim frmSalesSum As New frmSalesSum

        frmSalesSum.Show()
    End Sub

    Private Sub opt1Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt1Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        'runAllProgram()
    End Sub

    Private Sub opt3Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt3Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        'runAllProgram()

    End Sub

    Private Sub opt6Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt6Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        ' runAllProgram()
    End Sub

    Private Sub opt12Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt12Month.CheckedChanged
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

    Private Sub cmbPending_Click(sender As Object, e As EventArgs) Handles cmbPending.Click
        Dim frmPending As New frmPendingOrder
        frmPending.Show()

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
        txtDate02.Value = txtDate01.Value
    End Sub

    Private Sub lbTarget19d_Click(sender As Object, e As EventArgs) Handles lbTarget19d.Click

    End Sub

    Private Sub lbTarget19d_TextChanged(sender As Object, e As EventArgs) Handles lbTarget19d.TextChanged

    End Sub

    Private Sub txtSLtarget_TextChanged(sender As Object, e As EventArgs) Handles txtSLtarget.TextChanged
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
        frmSAbyTT.Show()

    End Sub

    Private Sub cmbRptCS_Click(sender As Object, e As EventArgs) Handles cmbRptCS.Click
        Dim frmCSanaly As New frmRptCSmast
        frmCSanaly.Show()
    End Sub

    'Sub genDataCSProfitV()
    '    'Dim CSdate As Date = Format(DateAdd(DateInterval.Year, -543, Now), "dd/MM/yyyy")
    '    Dim CSdate As Date = Format(Now, "dd/MM/yyyy")

    '    txtSQL = "Select Trh_Type,"

    '    If optByGrpSL.Checked = True Then
    '        txtSQL = txtSQL & "(CS_Name)  as Sale,"
    '    Else
    '        'txtSQL = txtSQL & "left(SL_Name,5)  as Sale,"            
    '        txtSQL = txtSQL & "(CS_Name)  as Sale,"
    '    End If

    '    If optTotal.Checked = True Or optGPNPD.Checked = True Then
    '    Else
    '        txtSQL = txtSQL & "Stk_Prod,Progrp_Name,"
    '    End If
    '    If optTotal.Checked = True Then
    '        txtSQL = txtSQL & "(CS_Name)  as Progrp_Name, "
    '    Else
    '        txtSQL = txtSQL & "(CS_Name)  as Sale,Progrp_Name,"
    '        'txtSQL = txtSQL & "Stk_Prod,Progrp_Name,"
    '    End If

    '    txtSQL = txtSQL & "sum(Dtl_price*Dtl_Num)as SumSL,"
    '    txtSQL = txtSQL & "sum((Dtl_Num*Stk_Factor ) * 95) as sumCost,"
    '    txtSQL = txtSQL & "sum((Dtl_price*Dtl_Num)-((Dtl_Num*Stk_Factor ) * 95)) as sumAmt,"
    '    'txtSQL = txtSQL & "sum((Dtl_price*Dtl_Num)-((Dtl_Num*Stk_Factor ) * CostMast.CS_Cost)) as sumAmt,"
    '    txtSQL = txtSQL & "sum((Dtl_Num*Stk_Factor)/1000) as sumQw,"
    '    txtSQL = txtSQL & "avg((Dtl_price*Dtl_Num)/(Dtl_Num*Stk_Factor)) as sumPrKg "


    '    txtSQL = txtSQL & "From TranDataH Left Join TranDataD  "
    '    txtSQL = txtSQL & "On (trh_type=Dtl_Type And Trh_No=Dtl_No)  "
    '    txtSQL = txtSQL & "Left Join BaseMast "
    '    txtSQL = txtSQL & "On Dtl_idTrade=Stk_code "

    '    txtSQL = txtSQL & "left Join CSMast "
    '    txtSQL = txtSQL & "on Trh_user=CS_Code "
    '    'txtSQL = txtSQL & "Left Join grpSales "
    '    'txtSQL = txtSQL & "On sl_grp=Grps_id "
    '    txtSQL = txtSQL & "left join ProGrpMast "
    '    txtSQL = txtSQL & "On Stk_Prod=Progrp_id "

    '    ' Join Table Cost 
    '    'txtSQL = txtSQL & "Left Join CostMast "
    '    'txtSQL = txtSQL & "On (CostMast.CS_Stk_Code=TranDataD.Dtl_idTrade  "
    '    'txtSQL = txtSQL & "And  (LTRIM(year(TranDataD.dtl_date)-2000) + '/' + LTRIM(right(month(TranDataD.dtl_date),2)))=CostMast.CS_Date) "

    '    txtSQL = txtSQL & "Where Trh_Type='B'  "
    '    txtSQL = txtSQL & "And dtl_price>0 "
    '    txtSQL = txtSQL & "And not(Trh_user is null) "
    '    ' ==========  เลือกช่วงเวลา ================

    '    If optOneDay.Checked = True Then
    '        txtSQL = txtSQL & "and Trh_Date='" & Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy") & "' "
    '    ElseIf optGrp1M.Checked = True Then
    '        txtSQL = txtSQL & "and (month(Trh_Date)='" & Month(Now) & "' "
    '        txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '    ElseIf optGrpYear.Checked = True Then
    '        txtSQL = txtSQL & "and (year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '    ElseIf optGrp3M.Checked = True Then
    '        If getQvalues() = "T1" Then
    '            txtSQL = txtSQL & "and (  (month(Trh_Date)>='1' and month(Trh_Date)<='3')  "
    '            txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '        ElseIf getQvalues() = "T2" Then
    '            txtSQL = txtSQL & "and (  (month(Trh_Date)>='4' and month(Trh_Date)<='6')  "
    '            txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '        ElseIf getQvalues() = "T3" Then
    '            txtSQL = txtSQL & "and (  (month(Trh_Date)>='7' and month(Trh_Date)<='9')  "
    '            txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '        ElseIf getQvalues() = "T4" Then
    '            txtSQL = txtSQL & "and (  (month(Trh_Date)>='10' and month(Trh_Date)<='12')  "
    '            txtSQL = txtSQL & "And year(Trh_Date)='" & Year(DateAdd(DateInterval.Year, -543, Now)) & "')"
    '        End If
    '    End If

    '    ' ==========  เลือกช่วงเวลา ================

    '    'txtSQL = txtSQL & "And Dtl_wh='01' "
    '    txtSQL = txtSQL & "And ("
    '    If optGP.Checked = True Then
    '        txtSQL = txtSQL & "Stk_Prod='01' "
    '    ElseIf optNPD.Checked = True Then
    '        txtSQL = txtSQL & "Stk_Prod='05' "
    '    ElseIf optTT.Checked = True Then
    '        txtSQL = txtSQL & "Stk_Prod='02' "
    '    ElseIf optGPNPD.Checked = True Then
    '        txtSQL = txtSQL & "Stk_Prod='01' or Stk_Prod='05' "

    '    ElseIf optTotal.Checked = True Then

    '        txtSQL = txtSQL & "Stk_Prod='01' or Stk_Prod='02' or Stk_Prod='05' "
    '        'txtSQL = txtSQL & "Stk_Prod='01' or Stk_Prod='05' "

    '    End If
    '    txtSQL = txtSQL & ") "
    '    txtSQL = txtSQL & "and not(Trh_sale='SL03' or Trh_Sale='SL12' ) "

    '    'If CSdate = "01/01/2013" Then
    '    '    txtSQL = txtSQL & "And costMast.CS_Date='01/01/2013' "
    '    'Else
    '    '    txtSQL = txtSQL & "And costMast.CS_Date='" & Microsoft.VisualBasic.Right(Year(DateAdd(DateInterval.Year, -543, CSdate)), 2) & "/" & Format(Month(CSdate), "00") & "' "
    '    'End If
    '    'If optByGrpSL.Checked = True Then
    '    '    txtSQL = txtSQL & "Group by   Trh_Type,Grps_Name,Stk_Prod,Progrp_Name "
    '    'Else
    '    '    txtSQL = txtSQL & "Group by   Trh_Type,SL_nickName,Stk_Prod,Progrp_Name "
    '    'End If

    '    If optByGrpSL.Checked = True Then

    '        If optTotal.Checked = True Then
    '            txtSQL = txtSQL & "Group by   Trh_Type,CS_Name "
    '        Else
    '            txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Stk_Prod,Progrp_Name "
    '        End If
    '    Else
    '        If optTotal.Checked = True Then
    '            'txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Progrp_Name  "
    '            txtSQL = txtSQL & "Group by   Trh_Type,CS_Name   "
    '        Else
    '            txtSQL = txtSQL & "Group by   Trh_Type,CS_Name,Stk_Prod,Progrp_Name "
    '        End If

    '    End If


    '    txtSQL = txtSQL & "Order by sumAmt desc  "


    '    If chkSCData = True Then

    '        subDS.Tables("rptCS01").Clear()
    '        chkSCData = False

    '    End If

    '    subDA = New SqlClient.SqlDataAdapter(txtSQL, sqlConNet)
    '    subDA.Fill(subDS, "rptCS01")
    '    chkSCData = True

    '    '===================================================================================



    'End Sub

End Class