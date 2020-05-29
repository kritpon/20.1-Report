Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSales_ReportByTT
    Dim frmLoad As Boolean = False
    Dim chkSelOpt As Boolean = False
    Dim strSelOpt As String = ""

    Sub formatGrid()
        'Dim strHead01 As String
        lsvARdetail.Columns.Add("id", 10, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ชื่อลูกค้า", 220, HorizontalAlignment.Left)

        lsvARdetail.Columns.Add("ยอดกำไรปี " & Year(Now) - 1, 120, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("Target" & Year(Now), 120, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add(strHead01, 120, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("%", 90, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("ยอดขาย" & Year(Now) - 2, 120, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("Target" & Year(Now), 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ยอดกำไรปี " & Year(Now) - 0, 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("Diff", 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("%", 90, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("กำไรKPI/วัน", 90, HorizontalAlignment.Right)

        'lsvARdetail.Columns.Add("น้ำหนักขาย" & Year(Now), 110, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("ราคา/kg", 90, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("ราคาขาย/Kg(ปัจจุบัน)", 80, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("วัน-ขายล่าสุด", 200, HorizontalAlignment.Right)

        lsvARdetail.View = View.Details
        lsvARdetail.GridLines = True
        'chkCol = True
        lbProfit0.Text = "กำไรรวมปี" & Year(Now) - 1
        lbProfit1.Text = "กำไรรวมปี" & Year(Now) - 0
    End Sub
    Function getSQL() As String

        txtSQL = "Select Ar_Cus_ID,Ar_Name,"
        'txtSQL = txtSQL & "Trh_No,Trh_NoType,"

        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='" & (Year(Now) - 543) - 1 & "')  then (Trh_D_Amt-Trh_Cost_Amt) else 0 end)as '" & "TrhProfit" & (Year(Now) - 1).ToString & "', "
        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='" & (Year(Now) - 543) - 0 & "')  then (Trh_D_Amt-Trh_Cost_Amt) else 0 end)as '" & "TrhProfit" & (Year(Now) - 0).ToString & "', "
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Cost_Amt)as sumDiff "
        'txtSQL = txtSQL & "sum(Trh60.Trh_Amt)as Trh_Amt60,"
        'txtSQL = txtSQL & "sum(Trh60.Trh_Cost_Amt)as Trh_Cost_Amt60,"
        'txtSQL = txtSQL & "sum((Trh60.Trh_Amt-Trh60.Trh_Cost_Amt))as TrhProfit60,"
        'txtSQL = txtSQL & "sum((Trh61.Trh_Amt-Trh61.Trh_Cost_Amt))as TrhProfit61 "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "

        txtSQL = txtSQL & "Where Trh_Type='S' "
        txtSQL = txtSQL & "And Ar_Sales='" & dbTools.getSaleCode(lbSalesName.Text) & "'"
        '============================================================
        txtSQL = txtSQL & "And not(Trh_Notype='X') "
        txtSQL = txtSQL & "And year(Trh_Date)>=" & Year(Now) - 543 - 1 & " "
        txtSQL = txtSQL & "And year(Trh_Date)<=" & Year(Now) - 543 & " "
        txtSQL = txtSQL & "And Trh_D_Amt>0 "
        txtSQL = txtSQL & "And Trh_ProD_Sales='02' "

        txtSQL = txtSQL & "Group by Ar_Cus_ID,Ar_Name "
        If optOrProfit60.Checked = True Then
            If optOrAZ.Checked Then
                txtSQL = txtSQL & "Order by " & "TrhProfit" & (Year(Now) - 1).ToString & " asc "
            Else
                txtSQL = txtSQL & "Order by " & "TrhProfit" & (Year(Now) - 1).ToString & " desc "
            End If


        ElseIf optOrProfit61.Checked = True Then

            If optOrAZ.Checked Then
                txtSQL = txtSQL & "Order by " & "TrhProfit" & (Year(Now) - 0).ToString & " asc "
            Else
                txtSQL = txtSQL & "Order by " & "TrhProfit" & (Year(Now) - 0).ToString & " desc "
            End If


        End If

        Return txtSQL

    End Function
    Sub runRpt()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim chkRow As Integer = 0

        Dim DateEndYear As Integer = 0
        Dim date01 As Date = Year(Now) - 543 & "/" & Month(Now) & "/" & Microsoft.VisualBasic.Day(Now)
        Dim date02 As Date = Year(Now) - 543 & "/12/31"
        DateEndYear = DateDiff(DateInterval.Day, date01, date02)
        lbCountDate.Text = DateEndYear.ToString("#,#00")
        txtSQL = getSQL()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slDetail")
        lsvARdetail.Clear()
        formatGrid()

        Dim strArCusID As String = ""
        Dim strArName As String = ""
        Dim dblTrhProfit60 As Double = 0
        Dim dblTrhProfit61 As Double = 0
        Dim dblDiff As Double = 0
        Dim dblAmtDate As Double = 0
        Dim dblRetio As Double = 0

        Dim dblTotalTrhProfit60 As Double = 0
        Dim dblTotalTrhProfit61 As Double = 0
        Dim dblTotalDiff As Double = 0
        Dim dblTotalAmtdate As Double = 0

        For i = 0 To subDS.Tables("slDetail").Rows.Count - 1

            With subDS.Tables("slDetail").Rows(i)
                strArCusID = .Item("Ar_Cus_ID")
                strArName = .Item("Ar_Name")

                If IsDBNull(.Item("TrhProfit" & (Year(Now) - 1).ToString)) Then
                    dblTrhProfit60 = 0 '.Item("TrhProfit60")
                Else
                    dblTrhProfit60 = .Item("TrhProfit" & (Year(Now) - 1).ToString)
                    dblTotalTrhProfit60 = dblTrhProfit60 + dblTotalTrhProfit60

                End If
                If IsDBNull(.Item("TrhProfit" & (Year(Now) - 0).ToString)) Then
                    dblTrhProfit61 = 0
                Else
                    dblTrhProfit61 = .Item("TrhProfit" & (Year(Now) - 0).ToString)
                    dblTotalTrhProfit61 = dblTrhProfit61 + dblTotalTrhProfit61
                End If
                dblDiff = dblTrhProfit61 - dblTrhProfit60
                dblTotalDiff = dblTotalDiff + dblDiff

                If dblDiff > 0 Then
                    chkRow = 2
                ElseIf dblDiff < 0 Then
                    chkRow = 3

                End If
                dblAmtDate = dblDiff / DateEndYear
                dblTotalAmtdate = dblAmtDate + dblTotalAmtdate
                dblRetio = ((dblDiff) / dblTrhProfit60) * 100
            End With


            anyData = New String() {strArCusID, strArName, dblTrhProfit60.ToString("#,##0.00"), dblTrhProfit61.ToString("#,##0.00"), dblDiff.ToString("#,##0.00"), dblRetio.ToString("#,##0.00") & " %", dblAmtDate.ToString("#,##0.00")}
            lvi = New ListViewItem(anyData)
            lsvARdetail.Items.Add(lvi)

            If chkRow = 0 Then
                lvi.BackColor = Color.White
                lvi.ForeColor = Color.Black
                chkRow = 1

            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.PaleGoldenrod
                lvi.ForeColor = Color.Black
                chkRow = 0
            ElseIf chkRow = 2 Then
                lvi.BackColor = Color.YellowGreen
                lvi.ForeColor = Color.Black
                chkRow = 1
            ElseIf chkRow = 3 Then
                lvi.BackColor = Color.Linen
                lvi.ForeColor = Color.DarkRed
                chkRow = 1

            End If
            lbCountCust.Text = i + 1.ToString("#,##0")
        Next

        lbTotalProfit60.Text = dblTotalTrhProfit60.ToString("#,##0.00")
        lbTotalProfit61.Text = dblTotalTrhProfit61.ToString("#,##0.00")
        lbTotalDiff.Text = dblTotalDiff.ToString("#,##0.00")

        lbDateKPIProfit.Text = dblTotalAmtdate.ToString("#,##0.00")
        dblRetio = ((dblTotalDiff) / dblTotalTrhProfit60) * 100
        lbTotalRetio.Text = dblRetio.ToString("#,##0.00")
        strArName = "--ยอดรวม--"

        anyData = New String() {strArCusID, strArName, dblTotalTrhProfit60.ToString("#,##0.00"), dblTotalTrhProfit61.ToString("#,##0.00"), dblTotalDiff.ToString("#,##0.00"), dblRetio.ToString("#,##0.00"), dblTotalAmtdate.ToString("#,##0.00")}
        lvi = New ListViewItem(anyData)
        lsvARdetail.Items.Add(lvi)

        lvi.BackColor = Color.DarkOrange
        lvi.ForeColor = Color.Black

        chkRow = 1
    End Sub
    Private Sub frmSales_ReportByTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLoad = True
        If frmLoad = True Then
            'grpBoxNow.Text = ""
            lbSalesName.Text = getSaleName(selSale)
            'Call formatGrid()
            'lbKPI.Text = Format(getSaleKPI(selSale) * 12, "#,##0.00")
            'optAVG_Now.Text = "ยอดเฉลี่ย" & " " & Format(DateAdd(DateInterval.Month, -1, Now()), "MM") & " เดือน"
            Call runRpt()

        End If
    End Sub

    Private Sub lsvARdetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvARdetail.SelectedIndexChanged

    End Sub

    Private Sub lsvARdetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvARdetail.DoubleClick
        Dim lvi0 As ListViewItem

        For i = 0 To lsvARdetail.SelectedItems.Count - 1
            lvi0 = lsvARdetail.SelectedItems(i)
            selCusID = lsvARdetail.Items(lvi0.Index).SubItems(0).Text

        Next

        Dim frmCusTTitem As New frmSales_CusTTitem
        frmCusTTitem.Show()
        'Call runRpt()
    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub optOrProfit60_CheckedChanged(sender As Object, e As EventArgs) Handles optOrProfit60.CheckedChanged
        Call runRpt()
    End Sub

    Private Sub optOrProfit61_CheckedChanged(sender As Object, e As EventArgs) Handles optOrProfit61.CheckedChanged
        Call runRpt()
    End Sub

    Private Sub optOrZA_CheckedChanged(sender As Object, e As EventArgs) Handles optOrZA.CheckedChanged
        Call runRpt()
    End Sub

    Private Sub optOrAZ_CheckedChanged(sender As Object, e As EventArgs) Handles optOrAZ.CheckedChanged
        Call runRpt()
    End Sub
End Class