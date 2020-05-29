Public Class frmSales_CusTTitem

    Private Sub frmSales_CusTTitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call formatGrid()
        lbCusCode.Text = selCusID
        lbCusName.Text = getCusName(selCusID)
        dataShow()
    End Sub
    Sub formatGrid()
        'Dim strHead01 As String
        lsvStkItem.Columns.Add("id", 10, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("รายการ", 280, HorizontalAlignment.Left)

        lsvStkItem.Columns.Add("จำนวนปี 60", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("จำนวนปี 61", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("Diff", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("%", 90, HorizontalAlignment.Right)

        lsvStkItem.Columns.Add("ยอดกำไรปี 60", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("ยอดกำไรปี 61", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("Diff", 120, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("%", 90, HorizontalAlignment.Right)
        lsvStkItem.Columns.Add("กำไรKPI/วัน", 90, HorizontalAlignment.Right)

        lsvStkItem.Columns.Add("วัน-ขายล่าสุด", 200, HorizontalAlignment.Right)

        lsvStkItem.View = View.Details
        lsvStkItem.GridLines = True
        'chkCol = True

    End Sub
    Function getSQLdata() As String
        txtSQL = "Select Trh_Type,Dtl_idTrade,Stk_Name_1, "
        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='2017')  then (Dtl_Num) else 0 end)as 'num2560', "
        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='2018')  then (Dtl_Num) else 0 end)as 'num2561',"
        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='2017')  then (Dtl_Sum-Dtl_Cost_Sum) else 0 end)as 'Profit2560', "
        txtSQL = txtSQL & "sum(case when (year(Trh_Date)='2018')  then (Dtl_Sum-Dtl_Cost_Sum) else 0 end)as 'Profit2561' "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type and Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join BAsemast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_Code "

        txtSQL = txtSQL & "Where  Trh_Type='S'  And Not(Trh_NoType='X') "
        txtSQL = txtSQL & "And Trh_D_Amt >0 "
        txtSQL = txtSQL & "And Trh_ProD_Sales='02' "
        txtSQL = txtSQL & "And Year(Trh_Date)>=2017 And Year(Trh_Date)<= 2018 "

        txtSQL = txtSQL & "And Trh_Cus='" & lbCusCode.Text & "' "

        txtSQL = txtSQL & "group by Trh_Type,Dtl_idTrade,Stk_Name_1 "
        txtSQL = txtSQL & "order by Profit2560 desc "
        Return txtsql

    End Function
    Sub dataShow()
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim chkRow As Integer = 1

        txtSQL = getSQLdata()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slDetail")
        lsvStkItem.Clear()
        formatGrid()

        Dim strStkcode As String = ""
        Dim strStkName As String = ""

        Dim dblNum60 As Double = 0
        Dim dblNum61 As Double = 0
        Dim dblDiffNum As Double = 0
        Dim dblNumRetio As Double = 0

        Dim dblProfit60 As Double = 0
        Dim dblProfit61 As Double = 0
        Dim dblDiff As Double = 0
        Dim dblAmtDate As Double = 0
        Dim dblRetio As Double = 0
        Dim dblTotalNum60 As Double = 0
        Dim dblTotalNum61 As Double = 0
        Dim dblTotalDiffNum As Double = 0

        Dim dblTotalProfit60 As Double = 0
        Dim dblTotalProfit61 As Double = 0
        Dim dblTotalDiff As Double = 0
        Dim dblTotalAmtdate As Double = 0

        For i = 0 To subDS.Tables("slDetail").Rows.Count - 1

            With subDS.Tables("slDetail").Rows(i)
                strStkcode = .Item("Dtl_idTrade")
                strStkName = .Item("Stk_Name_1")

                dblNum60 = .Item("num2560")
                dblTotalNum60 = dblTotalNum60 + dblNum60

                dblNum61 = .Item("num2561")
                dblTotalNum61 = dblNum61 + dblTotalNum61

                dblDiffNum = dblNum61 - dblNum60
                dblTotalDiffNum = dblTotalDiffNum + dblDiffNum

                dblNumRetio = (dblDiffNum / dblNum60) * 100

                dblProfit60 = .Item("Profit2560")
                dblTotalProfit60 = dblTotalProfit60 + dblProfit60

                dblProfit61 = .Item("Profit2561")
                dblTotalProfit61 = dblTotalProfit61 + dblProfit61

                dblDiff = (dblProfit61 - dblProfit60)
                dblTotalDiff = dblTotalDiff + dblDiff

                dblRetio = (dblDiff / dblProfit60) * 100

            End With
            If dblRetio < 0 Then
                chkRow = 3
            ElseIf dblRetio > 0 Then
                chkRow = 2
            End If
            anyData = New String() {strStkcode, strStkName, dblNum60.ToString("#,##0.00"), dblNum61.ToString("#,##0.00"), dblDiffNum.ToString("#,##0.00"), dblNumRetio.ToString("#,##0.00") & " %", dblProfit60.ToString("#,##0.00"), dblProfit61.ToString("#,##0.00"), dblDiff.ToString("#,##0.00"), dblRetio.ToString("#,##0.00") & " %"}
            lvi = New ListViewItem(anyData)
            lsvStkItem.Items.Add(lvi)
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
            lbTotalItem.Text = (i + 1).ToString("#,##0.00")
        Next
        strStkName = "===  Total ========>"
        dblNumRetio = ((dblTotalNum61 - dblTotalNum60) / dblTotalNum60) * 100
        dblRetio = ((dblTotalProfit61 - dblTotalProfit60) / dblTotalProfit60) * 100
        anyData = New String() {strStkcode, strStkName, dblTotalNum60.ToString("#,##0.00"), dblTotalNum61.ToString("#,##0.00"), dblTotalDiffNum.ToString("#,##0.00"), dblNumRetio.ToString("#,##0.00") & " %", dblTotalProfit60.ToString("#,##0.00"), dblTotalProfit61.ToString("#,##0.00"), dblTotalDiff.ToString("#,##0.00"), dblRetio.ToString("#,##0.00") & " %"}
        lvi = New ListViewItem(anyData)
        lsvStkItem.Items.Add(lvi)
        lvi.BackColor = Color.DarkOrange
        lvi.ForeColor = Color.Black

    End Sub
    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub
End Class