Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmRptCusGrad
    Dim chkLoad As Boolean = False

    Dim subDa As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet
    Dim strSalesID As String = ""
    Dim strGradeID As String = ""
    Dim strGradeName As String = ""

    ' Dim chkDataArFile As Boolean = False
    Dim chkDataArDetail As Boolean = False


    'Sub addCboSL2()
    '    Dim subDA As New SqlClient.SqlDataAdapter
    '    Dim subDS As New DataSet
    '    txtSQL = "Select * "
    '    txtSQL = txtSQL & "From  MktSegment "

    '    txtSQL = txtSQL & "Order by grp_code "

    '    subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    subDA.Fill(subDS, "listSL01")
    '    If subDS.Tables("listSL01").Rows.Count > 0 Then

    '        cboGrpCus.DataSource = subDS.Tables("listSL01")
    '        cboGrpCus.ValueMember = "grp_code"
    '        cboGrpCus.DisplayMember = "Grp_Name"
    '        'cboDClist.Text = ""
    '        cboGrpCus.SelectedItem = 0

    '    End If
    'End Sub

    Private Sub frmRptCusGrad_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DBtools.openDB()
        Call setHeaddetail()
        Call setHeadDetail2()
        Call addCboSL1()
        'Call addCboSL2

        chkLoad = True
        chkSelSL.Checked = False
        Call showReport()
    End Sub

    Function getSQLsum() As String

        txtSQL = "Select count(Ar_Grade)sumCus "
        txtSQL = txtSQL & "from ArFile "
        txtSQL = txtSQL & "left Join MktCusGrade "
        txtSQL = txtSQL & "on ArFile.AR_Grade=MktCusGrade.Grd_C_ID "

        txtSQL = txtSQL & "Where Ar_Type='AR' "
        If chkSelSL.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales ='" & cboSelSL.SelectedValue & "' "
        End If
        If chkCutNoDetl.Checked = True Then
            txtSQL = txtSQL & "And AR_Grade<> '' "
            txtSQL = txtSQL & "And AR_Grade<> '00' "
        End If
        'txtSQL = txtSQL & "Group by Ar_Grade,MktCusGrade.Grd_C_Name "

        'txtSQL = txtSQL & "Order by countCus desc"

        Return txtSQL

    End Function

    Function getSQLdata() As String

        txtSQL = "Select Ar_Grade,MktCusGrade.Grd_C_Name,count(Ar_Grade)countCus "
        txtSQL = txtSQL & "from ArFile "
        txtSQL = txtSQL & "left Join MktCusGrade "
        txtSQL = txtSQL & "on ArFile.AR_Grade=MktCusGrade.Grd_C_ID "

        txtSQL = txtSQL & "Where Ar_Type='AR' "
        If chkSelSL.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales ='" & cboSelSL.SelectedValue & "' "
        End If

        If chkCutNoDetl.Checked = True Then
            txtSQL = txtSQL & "And AR_Grade<> '' "
            txtSQL = txtSQL & "And AR_Grade<> '00' "
        End If

        txtSQL = txtSQL & "Group by Ar_Grade,MktCusGrade.Grd_C_Name "


        If optOrderName.Checked = True Then
            txtSQL = txtSQL & "Order by Grd_C_Name Asc"
        Else
            txtSQL = txtSQL & "Order by countCus desc"
        End If



        Return txtSQL

    End Function

    Sub showReport()

        Dim anyData() As String
        Dim lviReportDtl As ListViewItem

        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        Dim data01 As New DataPoint()
        Dim sChart As New Series
        Dim series0 As New Series("SERIES0")

        Dim sumData As Double = 0
        Dim chkRow As Integer = 0
        ' ChartCus.ChartAreas.Clear()
        'Dim CArea As ChartArea = ChartCus.ChartAreas(0)
        'ChartCus.ChartAreas.Add()
        'lsvCusGrade.CheckBoxes = True


        ChartCus.ChartAreas(0).AxisX.LineWidth = 2
        ChartCus.ChartAreas(0).AxisX.Interval = 1

        ChartCus.Series.Clear()

        txtSQL = getSQLsum()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "sumData")

        If subDS.Tables("sumData").Rows.Count > 0 Then
            sumData = 0
            sumData = subDS.Tables("sumData").Rows(0).Item("sumCus")
        Else
            sumData = 0
        End If

        lbTotal.Text = Format(sumData, "#,##0.00")
        txtSQL = getSQLdata()

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataDetl")

        lsvCusGrade.Items.Clear()
        Dim max0 As Integer = 0


        For i = 0 To subDS.Tables("dataDetl").Rows.Count - 1

            With subDS.Tables("dataDetl").Rows(i)

                Dim strGradeCode As String = ""
                Dim strGradeName As String = ""
                Dim sumGrade As Integer = 0
                Dim dblRatio As Double = 0
                Dim strRetio As String = ""

                ' Dim countGrade As Integer = i + 1
                If IsDBNull(.Item("Grd_C_Name")) Then
                    strGradeName = ""
                Else
                    strGradeName = .Item("Grd_C_Name")
                End If

                If IsDBNull(.Item("Ar_Grade")) Then
                    strGradeCode = ""
                Else

                    strGradeCode = .Item("Ar_Grade")

                End If

                sumGrade = .Item("CountCus")
                dblRatio = 100 - (100 * ((sumData - sumGrade) / sumData))
                strRetio = dblRatio.ToString("#,##.00") & " %"

                anyData = New String() {strGradeCode, strGradeName, sumGrade.ToString("#,##0"), strRetio}
                lviReportDtl = New ListViewItem(anyData)
                lsvCusGrade.Items.Add(lviReportDtl)



                If chkRow = 0 Then
                    lviReportDtl.BackColor = Color.White
                    lviReportDtl.ForeColor = Color.Black
                    chkRow = 1
                ElseIf chkRow = 1 Then
                    lviReportDtl.BackColor = Color.PaleGoldenrod
                    lviReportDtl.ForeColor = Color.Black
                    chkRow = 0
                    'Else
                    '    lviReportDtl.BackColor = Color.DarkRed
                    '    lviReportDtl.ForeColor = Color.White
                End If

                If chkCutNoDetl.Checked = False Or .Item("Ar_Grade") <> "00" Or (IsDBNull(.Item("Ar_Grade"))) Then
                    If (IsDBNull(.Item("Ar_Grade"))) Then

                        series0.Points.AddXY("null", .Item("CountCus"))
                    Else
                        series0.Points.AddXY(.Item("Grd_C_Name"), .Item("CountCus"))

                        If max0 < .Item("CountCus") Then
                            max0 = .Item("CountCus")
                        End If
                    End If

                    'series0.LabelBackColor = Color.Black

                End If


            End With

        Next
        'ChartCus.ChartAreas.Clear()
        'Dim CArea As New ChartArea
        'CArea.AxisX.LabelStyle.Font = New Font("Verdana,Arial,Helvetica,sans-serif", 16.0, FontStyle.Regular)


        series0.ChartType = SeriesChartType.Column
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        'series0.IsXValueIndexed = True

        'series0
        series0.Palette = ChartColorPalette.EarthTones
        If optTypeBar.Checked = True Then
            series0.ChartType = SeriesChartType.Column
        Else
            series0.ChartType = SeriesChartType.Pie
            series0.IsVisibleInLegend = True
        End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)

        With ChartCus
            '.ChartAreas.Add(CArea)
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            '.TextAntiAliasingQuality = TextAntiAliasingQuality.High
            .Series.Add(series0)
            .BorderlineWidth = 1
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            ChartCus.ChartAreas(0).AxisY.Maximum = max0 + 3

        End With



    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        showReport()
    End Sub

    Sub addCboSL1()
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL = txtSQL & "From SalesMan "
        txtSQL = txtSQL & "Where sl_off='0' "
                    txtSQL = txtSQL & "And not(sl_id='SL14') "
        txtSQL = txtSQL & "Order by SL_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listSL01")
        If subDS.Tables("listSL01").Rows.Count > 0 Then

            cboSelSL.DataSource = subDS.Tables("listSL01")
            cboSelSL.ValueMember = "SL_ID"
            cboSelSL.DisplayMember = "SL_Name"
            'cboDClist.Text = ""
            cboSelSL.SelectedItem = 0

        End If
    End Sub

    Private Sub cboSelSL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelSL.SelectedIndexChanged
        If chkLoad = True Then
            If chkSelSL.Checked = False Then
                lsvDetail.Items.Clear()
                chkSelSL.Checked = True
                Call showReport()
            End If
            If chkLoad = True Then
                lsvDetail.Items.Clear()
                Call showReport()

            End If
        End If



    End Sub


    Sub setHeaddetail()

        'lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvCusGrade.Columns.Add("รหัส", 40, HorizontalAlignment.Left)
        lsvCusGrade.Columns.Add("ชื่อเกรด", 100, HorizontalAlignment.Left)
        lsvCusGrade.Columns.Add("จำนวน", 80, HorizontalAlignment.Right)
        lsvCusGrade.Columns.Add("%", 80, HorizontalAlignment.Right)

        lsvCusGrade.View = View.Details
        lsvCusGrade.FullRowSelect = True
        lsvCusGrade.GridLines = True

    End Sub
    Sub setHeadDetail2()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)

        lsvDetail.Columns.Add("ชื่อลูกค้า", 300, HorizontalAlignment.Left)

        lsvDetail.Columns.Add("ที่อยู่-เขต", 150, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("ที่อยู่-จังหวัด", 150, HorizontalAlignment.Left)

        lsvDetail.Columns.Add("เริ่มทำการซื้อขาย", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ซื้อขายล่าสุด", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("อายุลูกค้า", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("กำไรปี59", 150, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("Target", 150, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("id", 1, HorizontalAlignment.Right)

        lsvDetail.View = View.Details
        lsvDetail.FullRowSelect = True
        lsvDetail.GridLines = True

    End Sub



    Private Sub lsvCusGrade_Click(sender As Object, e As EventArgs) Handles lsvCusGrade.Click



        Dim lvi0 As ListViewItem
        Dim anyData() As String
        Dim lvi1 As ListViewItem
        Dim strTarget As String = ""
        lsvDetail.Items.Clear()
        lbTarget.Text = 0
        For i = 0 To lsvCusGrade.SelectedItems.Count - 1
            lvi0 = lsvCusGrade.SelectedItems(i)

            strGradeID = lsvCusGrade.Items(lvi0.Index).SubItems(0).Text
            strGradeName = lsvCusGrade.Items(lvi0.Index).SubItems(1).Text
            ' lsvCusGrade.Items(i).SubItems(0).Text

            strSalesID = cboSelSL.SelectedValue
            ' lbAns.Text = strGradeID

            txtSQL = "Select * "
            txtSQL = txtSQL & "From ArFile "
            txtSQL = txtSQL & "Left Join AmphoeMast "
            txtSQL = txtSQL & "On Ar_Amphoe_Code=Amphoe_Code "
            txtSQL = txtSQL & "Where Ar_Type='AR' "

            If chkSelSL.Checked = True Then
                txtSQL = txtSQL & "And Ar_Sales='" & strSalesID & "' "
            End If
            'If strGradeID = "" Then
            'Else


            'End If
            txtSQL = txtSQL & "And Ar_Grade='" & strGradeID & "' "

            txtSQL = txtSQL & "Order by Ar_LastSales_date desc "


            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkDataArDetail = True Then
                subDS.Tables("listDtl02").Clear()
                chkDataArDetail = False
            End If

            subDa.Fill(subDS, "listDtl02")
            chkDataArDetail = True

        Next
        Dim chkRow As Integer = 0
        ' lsvDetail.Items.Clear()


        For x = 0 To subDS.Tables("listDtl02").Rows.Count - 1

            Dim strCusID As String = ""
            Dim strCusName As String = ""
            Dim dblTarget As Double = 0
            Dim dblTarget59 As Double = 0
            Dim strCusAddr As String = ""
            Dim strCusAddr2 As String = ""
            Dim strDate01 As String = ""
            Dim strDate02 As String = ""
            Dim strDateDiff As String = ""

            With subDS.Tables("listDtl02").Rows(x)
                strCusName = .Item("Ar_Name")
                If IsDBNull(.Item("Ar_Target")) Then
                    dblTarget = 0
                Else
                    dblTarget = .Item("Ar_Target")
                End If
                If IsDBNull(.Item("Ar_Target_Year")) Then
                    dblTarget59 = 0
                Else
                    dblTarget59 = .Item("Ar_Target_Year")
                End If

                If IsDBNull(.Item("Amphoe_Name")) Then
                    strCusAddr = "ไม่ระบุอำเภอ"
                Else
                    strCusAddr = .Item("Amphoe_Name")
                End If
                If IsDBNull(.Item("Country_Name")) Then
                    strCusAddr2 = "ไม่ระบุจังหวัด"
                Else
                    strCusAddr2 = .Item("Country_Name")
                End If
                If IsDBNull(.Item("Ar_Add_Date")) Then
                    strDate01 = "ไม่ระบุวันที่เริม"
                Else
                    strDate01 = .Item("Ar_Add_Date")
                End If
                If IsDBNull(.Item("Ar_Add_Date")) Then
                    strDate01 = "----------"
                Else
                    strDate01 = .Item("Ar_Add_Date")
                End If
                If IsDBNull(.Item("Ar_LastSales_Date")) Then
                    strDate02 = "----------"

                Else
                    strDate02 = .Item("Ar_LastSales_Date")

                End If
                If IsDBNull(.Item("Ar_Cus_id")) Then

                    strCusID = ""
                Else

                    strCusID = .Item("Ar_Cus_ID")
                End If

                If strDate01 = "----------" Then
                    strDateDiff = "----------"
                    'ElseIf strDate02 = "----------" Then
                    '    strDateDiff = "----------"
                Else
                    Dim dblTmp As Double = 0
                    Dim date01 As Date = CDate(strDate01)
                    Dim date02 As Date = Now 'CDate(strDate02)


                    dblTmp = DateDiff(DateInterval.Month, date01, date02)
                    If dblTmp = 0 Then
                        dblTmp = 0
                    Else
                        dblTmp = dblTmp - 1
                    End If

                    strDateDiff = (dblTmp).ToString & " เดือน"

                End If

                If chkRow = 0 Then
                    chkRow = 1
                Else
                    chkRow = 0
                End If

            End With

            anyData = New String() {strCusName, strCusAddr, strCusAddr2, Mid(strDate01, 1, 10), Mid((strDate02), 1, 10), strDateDiff, dblTarget59.ToString("#,##0.00"), dblTarget.ToString("#,##0.00"), strCusID}
            lvi1 = New ListViewItem(anyData)
            lsvDetail.Items.Add(lvi1)

            lbTarget.Text = Format(dblTarget + lbTarget.Text, "#,##0.00")

            If chkRow = 0 Then
                lvi1.BackColor = Color.White
                lvi1.ForeColor = Color.Black

            ElseIf chkRow = 1 Then
                lvi1.BackColor = Color.PaleGoldenrod
                lvi1.ForeColor = Color.Black
            Else
                lvi1.BackColor = Color.DarkRed
                lvi1.ForeColor = Color.White
            End If
        Next




    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optPie.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub optTypeBar_CheckedChanged(sender As Object, e As EventArgs) Handles optTypeBar.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub chkSelSL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelSL.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub lsvCusGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCusGrade.SelectedIndexChanged

    End Sub

    Private Sub lsvCusGrade_DoubleClick(sender As Object, e As EventArgs) Handles lsvCusGrade.DoubleClick


    End Sub

    Private Sub optOrderName_CheckedChanged(sender As Object, e As EventArgs) Handles optOrderName.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub optOrderQty_CheckedChanged(sender As Object, e As EventArgs) Handles optOrderQty.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub chkCutNoDetl_CheckedChanged(sender As Object, e As EventArgs) Handles chkCutNoDetl.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub lsvDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvDetail.SelectedIndexChanged

    End Sub

    Private Sub lsvDetail_Click(sender As Object, e As EventArgs) Handles lsvDetail.Click

    End Sub

    Private Sub lsvDetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvDetail.DoubleClick

        Dim lvi0 As ListViewItem
        'Dim strCusID As String = ""
        Dim frmSetgrade As New frmAnalyCus

        For i = 0 To lsvDetail.SelectedItems.Count - 1

            lvi0 = lsvDetail.SelectedItems(i)

            selCusID = lsvDetail.Items(lvi0.Index).SubItems(7).Text
            frmSetgrade.ShowDialog()
            Call showReport()
            lsvDetail.Items.Clear()

            ' lsvCusGrade.Items(i).SubItems(0).Text
            'Dim strCusID As String = ""
            'strCusID =
            'lbAns.Text = strGrpID

        Next

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmbPrint_Click(sender As Object, e As EventArgs) Handles cmbPrint.Click
        Call printToExcel()

    End Sub
    Sub printToExcel()

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim rw As Integer = 0
        Dim rowExcel As Integer = 3 ' เริ่มที่บันทัดที่ 9
        Dim bufferExcel As Integer = 0 '
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0

        fileName = CurDir() & "\report\rptCusGrade.xlsx"
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptCusGrade.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet

            If IsDBNull(subDS.Tables("listDtl02")) Then
                Exit Sub
            Else
                rw = subDS.Tables("listDtl02").Rows.Count - 1

            End If

            For countRow = 0 To rw


                .Range("B" & rowExcel).Select()
                .Range("B" & rowExcel).Value = countRow + 1
                .Range("C" & rowExcel).Select()
                .Range("C" & rowExcel).Value = subDS.Tables("listDtl02").Rows(countRow).Item("Ar_Name")
                .Range("D" & rowExcel).Value = subDS.Tables("listDtl02").Rows(countRow).Item("Amphoe_Name")
                .Range("E" & rowExcel).Value = subDS.Tables("listDtl02").Rows(countRow).Item("Country_Name")
                .Range("F" & rowExcel).Value = subDS.Tables("listDtl02").Rows(countRow).Item("Ar_LastSales_Date")
                .Range("G" & rowExcel).Value = subDS.Tables("listDtl02").Rows(countRow).Item("Ar_Target")

                .Range("A" & (rowExcel + 1) & ":" & "AD" & (rowExcel + 1)).Insert()
                If exRow = 0 Then
                    .Range("A" & (rowExcel) & ":" & "AD" & (rowExcel + 1)).Interior.ColorIndex = 0
                    exRow = 1
                Else
                    .Range("A" & (rowExcel) & ":" & "AD" & (rowExcel + 1)).Interior.ColorIndex = 0
                    exRow = 0
                End If
                rowExcel = rowExcel + 1

            Next
            .Range("A" & (rowExcel) & ":" & "H" & (rowExcel)).Interior.ColorIndex = 45
            .Range("F" & rowExcel).Value = "ยอดรวม Target"
            .Range("G" & rowExcel).Value = "=SUM(G2:G" & rowExcel - 1 & ")"
            Dim strSalesName As String = ""
            If chkSelSL.Checked = True Then
                strSalesName = "พนักงานขาย " & cboSelSL.Text
            Else
                strSalesName = "พนักงานขาย ทุกคน"
            End If
            .Range("C1").Value = "รายชื่อลูกค้า เกรด-" & strGradeName & "-" & strSalesName
            '.Range("G" & rowExcel).Value = "=SUM(G2:G" & rowExcel - 1 & ")"

        End With

    End Sub

End Class