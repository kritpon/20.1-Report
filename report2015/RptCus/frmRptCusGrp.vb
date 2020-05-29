Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmRptCusGrp
    Dim chkLoad As Boolean = False

    Dim subDa As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet

    Dim strSegmentName As String = ""

    Dim chkDataArFile As Boolean = False
    Dim chkDataArDetail As Boolean = False

    Private Sub frmRptCusGrp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBtools.openDB()
        setHeaddetail()
        setHeadDetail2()
        Call addCboSL1()
        chkLoad = True
        chkSelSL.Checked = False
        showReport()
    End Sub

    Sub setHeaddetail()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)

        lsvCusGrade.Columns.Add("รหัส", 30, HorizontalAlignment.Left)
        lsvCusGrade.Columns.Add("ชื่อ Segment ", 140, HorizontalAlignment.Left)
        lsvCusGrade.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)
        lsvCusGrade.Columns.Add("%", 60, HorizontalAlignment.Right)

        lsvCusGrade.View = View.Details
        lsvCusGrade.FullRowSelect = True
        lsvCusGrade.GridLines = True

    End Sub

    Sub setHeadDetail2()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)

        lsvDetail.Columns.Add("ชื่อลูกค้า", 330, HorizontalAlignment.Left)

        lsvDetail.Columns.Add("ที่อยู่-เขต", 150, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("ที่อยู่-จังหวัด", 150, HorizontalAlignment.Left)

        lsvDetail.Columns.Add("เริ่มทำการซื้อขาย", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("ซื้อขายล่าสุด", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("อายุลูกค้า", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("กำไรปี 59", 150, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("Target", 150, HorizontalAlignment.Right)
        lsvDetail.Columns.Add("id", 1, HorizontalAlignment.Right)
        lsvDetail.View = View.Details
        lsvDetail.FullRowSelect = True
        lsvDetail.GridLines = True

    End Sub

    Function getSQLsum() As String

        txtSQL = "Select count(AR_Group)sumCus "
        txtSQL = txtSQL & "from ArFile "
        txtSQL = txtSQL & "left Join MktSegment "
        txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "

        txtSQL = txtSQL & "Where Ar_Type='AR' "
        If chkSelSL.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales ='" & cboSelSL.SelectedValue & "' "
        End If

        If chkCutNoDetl.Checked = True Then
            txtSQL = txtSQL & "And Ar_Group<> '' "
            txtSQL = txtSQL & "And Ar_Group<> '00' "
        End If

        'txtSQL = txtSQL & "Group by Ar_Grade,MktCusGrade.Grd_C_Name "

        'txtSQL = txtSQL & "Order by countCus desc"

        Return txtSQL

    End Function

    Function getSQLdata() As String

        txtSQL = "Select Ar_Group,MktSegment.Grp_Name,count(Ar_Group)countCus "
        txtSQL = txtSQL & "from ArFile "

        txtSQL = txtSQL & "left Join MktSegment "
        txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "

        txtSQL = txtSQL & "Where Ar_Type='AR' "

        If chkSelSL.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales ='" & cboSelSL.SelectedValue & "' "
        End If
        If chkCutNoDetl.Checked = True Then
            txtSQL = txtSQL & "And Ar_Group<> '' "
            txtSQL = txtSQL & "And Ar_Group<> '00' "
        End If

        txtSQL = txtSQL & "Group by Ar_Group,MktSegment.Grp_Name "
        txtSQL = txtSQL & "Order by countCus desc"

        Return txtSQL

    End Function

    Sub showReport()

        Dim anyData() As String
        Dim lviReportDtl As ListViewItem

        Dim subDS As New DataSet
        Dim subDA As New SqlClient.SqlDataAdapter

        Dim data01 As New DataPoint()
        Dim sChart As New Series
        Dim series0 As New Series("SERIES0")

        Dim sumData As Double = 0
        Dim chkRow As Integer = 0

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
        subDA.Fill(subDS, "dataGrade")
        lsvCusGrade.Items.Clear()

        Dim max0 As Integer = 0

        For i = 0 To subDS.Tables("dataGrade").Rows.Count - 1

            With subDS.Tables("dataGrade").Rows(i)

                Dim strGrpName As String = ""
                Dim strGrpCode As String = ""
                Dim sumGrade As Integer = 0
                Dim dblRatio As Double = 0
                Dim strRetio As String = ""

                'strGrpName = .Item("Grp_Name")
                If IsDBNull(.Item("Ar_Group")) Then
                    strGrpCode = ""
                Else

                    strGrpCode = .Item("Ar_Group")
                End If

                sumGrade = .Item("CountCus")
                dblRatio = 100 - (100 * ((sumData - sumGrade) / sumData))
                strRetio = dblRatio.ToString("#,##.00") & " %"

                ' Dim countGrade As Integer = i + 1
                If IsDBNull(.Item("Grp_Name")) Then
                    strGrpName = ""
                Else
                    strGrpName = .Item("Grp_Name")
                End If

                sumGrade = .Item("CountCus")
                anyData = New String() {strGrpCode, strGrpName, sumGrade.ToString("#,##0"), strRetio}
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
                End If

                If chkCutNoDetl.Checked = False Or .Item("Ar_Group") <> "00" Then
                    series0.Points.AddXY(.Item("Grp_Name"), .Item("CountCus"))
                    If max0 < .Item("CountCus") Then
                        max0 = .Item("CountCus")
                    End If
                End If

            End With

        Next

        series0.ChartType = SeriesChartType.Column
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        'series0.IsXValueIndexed = True


        series0.Palette = ChartColorPalette.EarthTones

        If optTypeBar.Checked = True Then
            series0.ChartType = SeriesChartType.Column
        Else
            series0.ChartType = SeriesChartType.Pie
            series0.IsVisibleInLegend = True
        End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)

        With ChartCus
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
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

    Private Sub lsvCusGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCusGrade.SelectedIndexChanged

    End Sub

    Private Sub lsvCusGrade_Click(sender As Object, e As EventArgs) Handles lsvCusGrade.Click

        'Dim subDa As SqlClient.SqlDataAdapter
        'Dim subDS As New DataSet

        Dim lvi0 As ListViewItem
        Dim anyData() As String
        Dim lvi1 As ListViewItem
        Dim strTarget As String = ""
        lsvDetail.Items.Clear()

        For i = 0 To lsvCusGrade.SelectedItems.Count - 1
            lvi0 = lsvCusGrade.SelectedItems(i)

            Dim strGrpID As String = ""

            strGrpID = lsvCusGrade.Items(lvi0.Index).SubItems(0).Text
            ' lsvCusGrade.Items(i).SubItems(0).Text
            Dim strSalesID As String = ""
            strSalesID = cboSelSL.SelectedValue
            strSegmentName = lsvCusGrade.Items(lvi0.Index).SubItems(1).Text
            'lbAns.Text = strGrpID

            txtSQL = "Select * "
            txtSQL = txtSQL & "From ArFile "
            txtSQL = txtSQL & "Left Join AmphoeMast "
            txtSQL = txtSQL & "On Ar_Amphoe_Code=Amphoe_Code "
            txtSQL = txtSQL & "Where Ar_Type='AR' "

            If chkSelSL.Checked = True Then
                txtSQL = txtSQL & "And Ar_Sales='" & strSalesID & "' "
            End If
            'If strGrpID = "" Then

            'Else

            txtSQL = txtSQL & "And Ar_Group='" & strGrpID & "' "
            'End If

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
        lbTarget.Text = 0

        For x = 0 To subDS.Tables("listDtl02").Rows.Count - 1


            Dim strCusName As String = ""
            Dim dblTarget As Double = 0
            Dim dblTarget59 As Double = 0
            Dim strCusAddr As String = ""
            Dim strCusAddr2 As String = ""
            Dim strDate01 As String = ""
            Dim strDate02 As String = ""
            Dim strDateDiff As String = ""
            Dim strCusID As String = ""


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
                ElseIf strDate02 = "----------" Then
                    strDateDiff = "----------"
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



    Private Sub optTypeBar_CheckedChanged(sender As Object, e As EventArgs) Handles optTypeBar.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub optPie_CheckedChanged(sender As Object, e As EventArgs) Handles optPie.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub lsvDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvDetail.SelectedIndexChanged

    End Sub

    Private Sub lsvDetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvDetail.DoubleClick

        Dim lvi0 As ListViewItem
        'Dim strCusID As String = ""
        Dim frmSetgrade As New frmAnalyCus

        For i = 0 To lsvDetail.SelectedItems.Count - 1

            lvi0 = lsvDetail.SelectedItems(i)

            selCusID = lsvDetail.Items(lvi0.Index).SubItems(7).Text
            setFrm = 1
            frmSetgrade.ShowDialog()

            Call showReport()
            lsvDetail.Items.Clear()

            ' lsvCusGrade.Items(i).SubItems(0).Text
            'Dim strCusID As String = ""
            'strCusID =
            'lbAns.Text = strGrpID

        Next

    End Sub

    Private Sub chkCutNoDetl_CheckedChanged(sender As Object, e As EventArgs) Handles chkCutNoDetl.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lbTotal_Click(sender As Object, e As EventArgs) Handles lbTotal.Click

    End Sub

    Private Sub chkSelSL_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelSL.CheckedChanged
        If chkLoad = True Then
            lsvDetail.Items.Clear()
            Call showReport()
        End If
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

        fileName = CurDir() & "\report\rptCusSegment.xlsx"
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptCusSegment.xlsx")
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
            .Range("C1").Value = "รายชื่อลูกค้า Segment-" & strSegmentName & "-" & strSalesName
            '.Range("G" & rowExcel).Value = "=SUM(G2:G" & rowExcel - 1 & ")"

        End With

    End Sub

End Class