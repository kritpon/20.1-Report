
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSAbyTT
    Dim chkLoad As Boolean = False
    Dim selProd As String = ""
    Sub addSalesMan()
        txtSQL = "Select * "
        txtSQL = txtSQL & "from SalesMan "
        txtSQL = txtSQL & "where SL_Off='0' "
        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter
        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "salesMan")

        With cboSales
            .DataSource = subDS.Tables("salesMan")
            .DisplayMember = "SL_Name"
            .ValueMember = "SL_ID"

        End With
    End Sub
    Sub addSegment()


        txtSQL = "Select * "
        txtSQL = txtSQL & "FRom MktSegment "
        txtSQL = txtSQL & "Order by Grp_Name "
        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter
        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "segment")

        With cboSegment
            .DataSource = subDS.Tables("segment")
            .DisplayMember = "Grp_Name"
            .ValueMember = "Grp_Code"

        End With
    End Sub
    Private Sub frmSAbyTT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addSalesMan()
        addSegment()
        'formatGrid()
        'getCusTT()
        chkLoad = True
        If chkLoad = True Then
            genSumTTSales()
            addListType()
        End If
        lsvSATT.Items.Clear()
    End Sub


    Sub formatGrid()

        lsvSATT.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvSATT.Columns.Add("ชื่อสินค้า", 280, HorizontalAlignment.Left)
        lsvSATT.Columns.Add("จำนวน", 70, HorizontalAlignment.Right)
        lsvSATT.Columns.Add("ขาย Y60", 85, HorizontalAlignment.Right)
        lsvSATT.Columns.Add("ขาย Y61", 85, HorizontalAlignment.Right)

        lsvSATT.Columns.Add("%", 60, HorizontalAlignment.Right)
        lsvSATT.Columns.Add("ทุนขาย", 80, HorizontalAlignment.Right)
        lsvSATT.Columns.Add("กำไร", 80, HorizontalAlignment.Right)

        lsvSATT.View = View.Details
        lsvSATT.GridLines = True

        'chkCol = True

    End Sub

    Sub getCusTT()
        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join MktSegment "
        txtSQL = txtSQL & "On Ar_Group=Grp_Code "
        txtSQL = txtSQL & "Where Ar_Group='" & cboSegment.SelectedValue & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "master")

        Dim strArName As String = ""
        Dim strArCode As String = ""
        Dim dblArTarget As Double = 0
        Dim dblItem As Double = 0
        Dim anyData() As String
        Dim lvi As ListViewItem
        lsvSATT.Clear()
        formatGrid()

        For i = 0 To subDS.Tables("master").Rows.Count - 1
            With subDS.Tables("master").Rows(i)
                strArCode = .Item("Ar_Cus_ID")
                strArName = .Item("Ar_Name")
                If IsDBNull(.Item("Ar_Target")) Then
                    dblArTarget = 0
                Else
                    dblArTarget = .Item("Ar_Target")
                End If

                dblItem = i + 1

                anyData = New String() {dblItem.ToString("#,##0"), strArName, dblArTarget.ToString("#,##0.00")}
                lvi = New ListViewItem(anyData)
                lsvSATT.Items.Add(lvi)
            End With
        Next


    End Sub

    Sub genSumTTSales()

        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter

        txtSQL = "Select TOP 100 Stk_Code,Stk_Name_1,"
        txtSQL = txtSQL & "sum(Dtl_Num)as sumNum,"
        'txtSQL = txtSQL & "sum(Dtl_Num * Dtl_Price)as sumAmt,"
        'txtSQL = txtSQL & "sum(Dtl_Cost_Sum)as sumCost,"


        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 1 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Cost_Sum) else 0 end)as sumCost0, "
        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 0 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Cost_Sum) else 0 end)as sumCost1, "


        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 1 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Sum) else 0 end)as sumAmt0, "
        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 0 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Sum) else 0 end)as sumAmt1 "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type and Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_Code "
        txtSQL = txtSQL & "Left Join Arfile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Where Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' or Trh_NoType='N' or Trh_NoType='B' or Trh_NoType='M' or Trh_NoType='Z' or Trh_NoType='Y') "
        txtSQL = txtSQL & "and not(Trh_Sale='SL03' or trh_sale='SL14') "

        If chkSegment.Checked = True Then
            txtSQL = txtSQL & "And  Ar_Group='" & cboSegment.SelectedValue & "' "
        End If
        txtSQL = txtSQL & "And BaseMast.Type_Code='" & cboStkType.SelectedValue & "' "
        'txtSQL = txtSQL & " And Year(Trh_Date) >= 2016 "
        'txtSQL = txtSQL & "And year(Trh_Date)>=2018 "
        'txtSQL = txtSQL & "And Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        'txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "
        If optYear.Checked = True Then
            txtSQL = txtSQL & "And ( "
            txtSQL = txtSQL & "Year(Trh_Date)='" & (Year(Now) - 543) - 1 & "' "
            txtSQL = txtSQL & "Or (Year(Trh_Date)='" & (Year(Now) - 543) & "' )"
            txtSQL = txtSQL & ")"
        Else
            txtSQL = txtSQL & "And ( "
            txtSQL = txtSQL & "(Trh_Date >= '" & Year(txtDate01.Value) - 543 - 1 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 - 1 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "')"


            txtSQL = txtSQL & "Or (Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "')"

            txtSQL = txtSQL & ") "

        End If
        If chkSales.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales='" & cboSales.SelectedValue & "' "
        End If

        If optSelNPD.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='05' "
            If chkStkType.Checked = True Then
                txtSQL = txtSQL & "And Type_Code='" & cboStkType.SelectedValue & "'"
            End If

        ElseIf optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='01' "
            If chkStkType.Checked = True Then
                txtSQL = txtSQL & "And Type_Code='" & cboStkType.SelectedValue & "'"
            End If

        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='02' "
            If chkStkType.Checked = True Then
                txtSQL = txtSQL & "And Type_Code='" & cboStkType.SelectedValue & "'"
            End If
        Else
            txtSQL = txtSQL & "And (Stk_Prod='01' or Stk_Prod='05' or Stk_Prod='02') "
        End If

        txtSQL = txtSQL & "Group by Stk_Code,Stk_Name_1 "
        txtSQL = txtSQL & "Order by sum(Dtl_Num * Dtl_Price)desc "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "masterSum")
        '===========================================================================================

        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim chkRow As Integer = 0
        Dim strStkName As String = ""
        Dim dblSumNum As Double = 0
        Dim dblSumAmt0 As Double = 0
        Dim dblSumAmt1 As Double = 0
        Dim dblSumCost0 As Double = 0
        Dim dblSumCost1 As Double = 0
        Dim dblSumProfit As Double = 0
        Dim dblItem As Integer = 0
        Dim maxRow As Integer = subDS.Tables("masterSum").Rows.Count - 1
        lsvSATT.Clear()
        lsvSaleSum.Clear()
        dataShow.Columns.Clear()
        dataShow.Rows.Clear()
        formatGrid()

        lsvSaleSum.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvSaleSum.Columns.Add("ลูกค้า", 200, HorizontalAlignment.Left)
        lsvSaleSum.Columns.Add("ขาย 60", 90, HorizontalAlignment.Right)
        lsvSaleSum.Columns.Add("ขาย 61", 90, HorizontalAlignment.Right)
        lsvSaleSum.Columns.Add("%", 90, HorizontalAlignment.Right)
        '====================== set Head ของ DataGrid ============================
        dataShow.Columns.Add("item", "#")
        dataShow.Columns(0).Width = 50
        dataShow.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dataShow.Columns.Add("Ar_Name", "ลูกค้า")
        dataShow.Columns(1).Width = 200
        dataShow.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft

        dataShow.Columns.Add("sumCost0", "ทุนขาย 60")
        dataShow.Columns(2).Width = 90
        dataShow.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


        dataShow.Columns.Add("sumCost1", "ทุนขาย 61")
        dataShow.Columns(3).Width = 90
        dataShow.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


        dataShow.Columns.Add("sumAmt0", "มูลค้าขาย 60")
        dataShow.Columns(4).Width = 90
        dataShow.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


        dataShow.Columns.Add("sumAmt1", "มูลค้าขาย 61")
        dataShow.Columns(5).Width = 90
        dataShow.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        '====================== set Head ของ DataGrid ============================
        txtSQL = "Select Ar_Name,ArFile.Ar_LastSales_Date, "
        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 1 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Sum) else 0 end)as '" & (Year(Now) - 1).ToString & "-" & selProd & "', "
        txtSQL = txtSQL & "sum(case when ((year(Trh_Date)='" & (Year(Now) - 543) - 0 & "') and (Trh_ProD_Sales)='" & selProd & "') then (Dtl_Sum) else 0 end)as '" & (Year(Now) - 0).ToString & "-" & selProd & "' "

        Dim series0 As New Series("SERIES0")
        chartStk.Series.Clear()
        Dim dblTotalAmt As Double = 0
        Dim dblTotalAmt0 As Double = 0
        Dim dblRetioStk As Double = 0
        Dim dblTotalNum As Double = 0 : Dim dblTotalCost As Double = 0 : Dim dblTotalProfit As Double

        For i = 0 To subDS.Tables("masterSum").Rows.Count - 1
            dblTotalAmt = dblTotalAmt + subDS.Tables("masterSum").Rows(i).Item("sumAmt1")
            dblTotalAmt0 = dblTotalAmt0 + subDS.Tables("masterSum").Rows(i).Item("sumAmt0")
        Next

        For i = 0 To subDS.Tables("masterSum").Rows.Count - 1
            dblRetioStk = 0
            If i = 0 Then txtSQL = txtSQL & ","
            With subDS.Tables("masterSum").Rows(i)
                lsvSaleSum.Columns.Add(.Item("Stk_Name_1"), 200, HorizontalAlignment.Right)
                lsvSaleSum.Columns.Add("%", 60, HorizontalAlignment.Right)
                '====================== set Head ของ DataGrid ============================

                dataShow.Columns.Add("Stk_Name_1", .Item("Stk_Name_1"))
                dataShow.Columns(i + (4 + (i * 1))).Width = 100
                dataShow.Columns(i + (4 + (i * 1))).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                dataShow.Columns.Add("retio", "%")
                dataShow.Columns(i + (5 + (i * 1))).Width = 60
                dataShow.Columns(i + (5 + (i * 1))).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight


                '====================== set Head ของ DataGrid ============================
                strStkName = .Item("Stk_Name_1")
                If IsDBNull(.Item("sumAmt1")) Then
                    dblSumAmt1 = 0
                Else
                    dblSumAmt1 = .Item("sumAmt1")
                End If
                If IsDBNull(.Item("sumAmt0")) Then
                    dblSumAmt0 = 0
                Else
                    dblSumAmt0 = (.Item("sumAmt0") / 12) * Month(Now) ' เพิ่มหาร 12 แล้ว คุณจำนวนเดือนปัจจุบัน
                End If

                If IsDBNull(.Item("sumCost0")) Then
                    dblSumCost0 = 0
                Else
                    dblSumCost0 = .Item("sumCost0")
                End If

                If IsDBNull(.Item("sumCost1")) Then
                    dblSumCost1 = 0
                Else
                    dblSumCost1 = .Item("sumCost1")

                End If
                'dblSumCost = .Item("sumCost")
                dblTotalCost = dblSumCost1 + dblTotalCost
                dblSumProfit = (dblSumAmt1 - dblSumCost1)

                If dblSumAmt0 = 0 Then
                    dblRetioStk = 100
                Else
                    dblRetioStk = ((dblSumAmt1 - dblSumAmt0) / dblSumAmt0) * 100
                End If

                dblTotalProfit = dblTotalProfit + dblSumProfit
                If dblRetioStk < 0 Then
                    If chkRow = 1 Then
                        chkRow = 2
                    ElseIf chkRow = 0 Then
                        chkRow = 3
                    End If

                End If
                dblSumNum = .Item("sumNum")
                dblTotalNum = dblSumNum + dblTotalNum
                series0.Points.AddXY(strStkName, Format(dblRetioStk, "#,##0.00"))
                If i < maxRow Then
                    txtSQL = txtSQL & "sum(case when year(Trh_Date)='" & ((Year(Now) - 543)) & "' And (dtl_idTrade)='" & .Item("Stk_Code") & "' then (Dtl_Sum) else 0 end)as '" & .Item("Stk_Name_1") & "', "
                Else
                    txtSQL = txtSQL & "sum(case when year(Trh_Date)='" & ((Year(Now) - 543)) & "' And (dtl_idTrade)='" & .Item("Stk_Code") & "' then (Dtl_Sum) else 0 end)as '" & .Item("Stk_Name_1") & "' "

                End If
            End With
            dblItem = i + 1

            anyData = New String() {dblItem.ToString("#,##0"), strStkName, dblSumNum.ToString("#,##0.00"), dblSumAmt0.ToString("#,##0.00"), dblSumAmt1.ToString("#,##0.00"), dblRetioStk.ToString("#,##0.00"), dblSumCost1.ToString("#,##0.00"), dblSumProfit.ToString("#,##0.00")}
            lvi = New ListViewItem(anyData)
            lsvSATT.Items.Add(lvi)

            If chkRow = 0 Then
                lvi.BackColor = Color.White
                lvi.ForeColor = Color.Black
                chkRow = 1

            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.PaleGoldenrod
                lvi.ForeColor = Color.Black
                chkRow = 0
            ElseIf chkrow = 2 Then

                lvi.BackColor = Color.PaleGoldenrod
                lvi.ForeColor = Color.DarkRed
                chkRow = 0
            ElseIf chkRow = 3 Then

                lvi.BackColor = Color.White
                lvi.ForeColor = Color.DarkRed
                chkRow = 1
            End If
        Next

        strStkName = "ยอดรวม" : dblSumNum = dblTotalNum : dblSumAmt1 = dblTotalAmt
        dblSumCost1 = dblTotalCost : dblSumProfit = dblTotalProfit : dblRetioStk = 0

        anyData = New String() {dblItem.ToString("#,##0"), strStkName, dblSumNum.ToString("#,##0.00"), dblTotalAmt0.ToString("#,##0.00"), dblSumAmt1.ToString("#,##0.00"), dblRetioStk.ToString("#,##0.00"), dblSumCost1.ToString("#,##0.00"), dblSumProfit.ToString("#,##0.00")}
        lvi = New ListViewItem(anyData)
        lsvSATT.Items.Add(lvi)
        lvi.BackColor = Color.YellowGreen
        lvi.ForeColor = Color.Black


        lsvSaleSum.View = View.Details
        lsvSaleSum.GridLines = True

        txtSQL = txtSQL & "From  ArFile "
        txtSQL = txtSQL & "Left JOin TranDataH "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type and Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On Dtl_idTrade=Stk_Code "



        txtSQL = txtSQL & "Where Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' or Trh_NoType='N' or Trh_NoType='B' or Trh_NoType='M' or Trh_NoType='Z' or Trh_NoType='Y') "
        txtSQL = txtSQL & "and not(Trh_Sale='SL03' or trh_sale='SL14') "
        If chkSales.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales='" & cboSales.SelectedValue & "' "
        End If
        If chkSegment.Checked = True Then
            txtSQL = txtSQL & "And Ar_Group='" & cboSegment.SelectedValue & "' "

        End If
        If chkStkType.Checked = True Then
            txtSQL = txtSQL & "And BaseMast.Type_Code='" & cboStkType.SelectedValue & "' "

        End If

        ' txtSQL = txtSQL & "And BaseMast.Type_Code='" & cboStkType.SelectedValue & "' "
        If optYear.Checked = True Then
            txtSQL = txtSQL & "And ( "
            txtSQL = txtSQL & "Year(Trh_Date)='" & (Year(Now) - 543) - 1 & "' "
            txtSQL = txtSQL & "Or (Year(Trh_Date)='" & (Year(Now) - 543) & "' )"
            txtSQL = txtSQL & ")"
        Else
            txtSQL = txtSQL & "And ( "
            txtSQL = txtSQL & "(Trh_Date >= '" & Year(txtDate01.Value) - 543 - 1 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 - 1 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "')"


            txtSQL = txtSQL & "Or (Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "')"

            txtSQL = txtSQL & ") "

        End If



        txtSQL = txtSQL & "Group by Ar_Name,Ar_Target,Ar_LastSales_Date "
        txtSQL = txtSQL & "Order by sum(Trh_D_Amt) desc"

        '====================================================================

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "masterReport")
        'Dim colCount As Integer = subDS.Tables("masterReport").Columns.Count - 1

        Dim strArName As String = ""
        Dim intItem2 As Integer = 0
        'Dim dblSumNum As Double = 0
        Dim dblsumSaleAmt As Double = 0
        'Dim strData(maxRow) As String
        Dim ratioSales As Double = 0
        Dim dblSumAmt2 As Double = 0
        Dim dblSumAmt3 As Double = 0
        Dim ratio1 As Double = 0
        Dim dblSumSaleItem As Double = 0
        'Dim dblItem As Integer = 0
        Dim dblTotalAmt2 As Double = 0
        Dim dblTotalAmt3 As Double = 0
        Dim lvi2 As ListViewItem
        Dim dblTotal(subDS.Tables("masterReport").Columns.Count, 1) As Double

        For n = 0 To subDS.Tables("masterReport").Rows.Count - 1
            lvi2 = New ListViewItem
            With subDS.Tables("masterReport").Rows(n)

                'lvi2.SubItems.Add(n + 1)
                lvi2.SubItems.Add(.Item("Ar_Name"))

                dblSumAmt2 = .Item(2)
                dblTotalAmt2 = dblSumAmt2 + dblTotalAmt2
                lvi2.SubItems.Add(Format(dblSumAmt2, "#,##0.00"))

                dblSumAmt3 = .Item(3)
                dblTotalAmt3 = dblSumAmt3 + dblTotalAmt3
                lvi2.SubItems.Add(Format(dblSumAmt3, "#,##0.00"))

                ratio1 = ((dblSumAmt3 - dblSumAmt2) / dblSumAmt2) * 100
                lvi2.SubItems.Add(Format(ratio1, "#,##0.00"))

                'If ratio1 < 0 Then
                '    chkRow = 2
                'End If
                dataShow.Rows.Add(n.ToString("#,##0"), .Item("Ar_Name"), dblSumAmt2.ToString("#,##0.00"), dblSumAmt3.ToString("#,##0.00"))
                '
                'dataShow.Rows(n).Cells(4)
                For c = 4 To subDS.Tables("masterReport").Columns.Count - 1

                    If IsDBNull(.Item(c)) Then
                        dblSumSaleItem = 0
                    Else
                        dblSumSaleItem = .Item(c)
                    End If
                    lvi2.SubItems.Add(Format(dblSumSaleItem, ("#,##0.00")))

                    dblTotal(c, 1) = dblSumSaleItem + dblTotal(c, 1)
                    If dblSumAmt3 = 0 Then
                        ratioSales = 0
                    Else
                        ratioSales = 100 - (((dblSumAmt3 - dblSumSaleItem) / dblSumAmt3) * 100)
                    End If
                    lvi2.SubItems.Add(Format(ratioSales, "#,##0.00"))

                    '+ (4 + (c * 1))
                    dataShow.Rows(n).Cells(c + ((c - 4) + 0)).Value = dblSumSaleItem.ToString("#,##0.00")
                    'dataShow.Rows(n).Cells.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    ' dataShow.Rows(n).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dataShow.Rows(n).Cells(c + ((c - 4) + 1)).Value = ratioSales.ToString("#,##0.00")
                    'dataShow.Rows(n).Cells(c + ((c - 4) + 1)).Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    'dataShow.Rows(n).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Next


            End With
            lsvSaleSum.Items.Add(lvi2)
            If chkRow = 0 Then
                lvi2.BackColor = Color.White
                lvi2.ForeColor = Color.Black
                chkRow = 1

            ElseIf chkRow = 1 Then
                lvi2.BackColor = Color.PaleGoldenrod
                lvi2.ForeColor = Color.Black
                chkRow = 0
            ElseIf chkrow = 2 Then
                lvi2.BackColor = Color.Orange
                lvi2.ForeColor = Color.Black
                chkRow = 0

            End If
        Next
        '=============================================================
        lvi2 = New ListViewItem
        lvi2.SubItems.Add("ยอดรวม")
        lvi2.SubItems.Add(Format(dblTotalAmt2, "#,##0.00"))
        lvi2.SubItems.Add(Format(dblTotalAmt3, "#,##0.00"))
        Dim sumRatio As Double = 0
        sumRatio = (((dblTotalAmt3 - dblTotalAmt2) / dblTotalAmt2) * 100)
        lvi2.SubItems.Add(sumRatio.ToString("#,##0.00"))
        ' ต้องเพิ่ม row อีก loop 

        For c = 4 To subDS.Tables("masterReport").Columns.Count - 1

            dblSumSaleItem = dblTotal(c, 1)
            lvi2.SubItems.Add(dblSumSaleItem.ToString("#,##0.00"))
            ratioSales = 100 - (((dblTotalAmt3 - dblSumSaleItem) / dblTotalAmt3) * 100)
            lvi2.SubItems.Add(Format(ratioSales, "#,##0.00"))

        Next

        lvi2.BackColor = Color.YellowGreen
        lvi2.ForeColor = Color.Black
        lsvSaleSum.Items.Add(lvi2)

        '==============================  chart  =======================
        series0.ChartType = SeriesChartType.Pie
        series0.LabelFormat = "#,##0.00"
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = True
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        With chartStk
            .BackColor = Color.Silver
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(series0)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Italic)
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            '.ChartAreas(0).AxisX.LabelStyle.Angle = -90
            '.ChartAreas(0).AxisY.MinorTickMark.Enabled = True
            '.ChartAreas(0).AxisY2.MinorTickMark.Enabled = True
            .ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            '.ChartAreas(0).AxisY.Maximum = max0 + 1000000
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

    Sub formatGrid2()

        lsvSaleSum.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvSaleSum.Columns.Add("ลูกค้า", 200, HorizontalAlignment.Left)

        lsvSaleSum.View = View.Details
        lsvSaleSum.GridLines = True

        'chkCol = True

    End Sub
    Private Sub cboSegment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSegment.SelectedIndexChanged
        If chkLoad = True Then
            genSumTTSales()
        End If

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        If chkLoad = True Then
            genSumTTSales()
        End If
    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs)
        txtDate02.Value = txtDate01.Value

    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub opt1Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt1Month.CheckedChanged

        txtDate01.Value = Now
        getDateAffter()


    End Sub

    Private Sub opt3Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt3Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()

    End Sub

    Private Sub opt6Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt6Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()

    End Sub

    Private Sub opt12Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt12Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()

    End Sub

    Private Sub optSelDay_CheckedChanged(sender As Object, e As EventArgs) Handles optSelDay.CheckedChanged
        txtDate01.Value = Now
        lbDate1.Text = txtDate01.Value

        txtDate02.Value = Now
        lbDate2.Text = txtDate02.Value
    End Sub
    Sub addListType()
        txtSQL = "Select * "
        txtSQL = txtSQL & "From TypeMast "
        If optSelTT.Checked = True Then
            txtSQL = txtSQL & "Where Type_Prod='02' "
        ElseIf optSelNPD.Checked = True Then
            txtSQL = txtSQL & "Where Type_Prod='05' "
        ElseIf optSelGP.Checked = True Then
            txtSQL = txtSQL & "Where Type_Prod='01' "
        Else

        End If
        txtSQL = txtSQL & "Order by Type_Code "

        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter
        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "typemast")

        With cboStkType
            .DataSource = subDS.Tables("typemast")
            .DisplayMember = "Type_Name"
            .ValueMember = "Type_Code"
            .SelectedIndex = 1
        End With
    End Sub
    Private Sub optSelTT_Click(sender As Object, e As EventArgs) Handles optSelTT.Click

        If chkLoad = True Then
            addListType()
            selProd = "02"
        End If

    End Sub

    Private Sub optSelGP_CheckedChanged(sender As Object, e As EventArgs) Handles optSelGP.CheckedChanged

    End Sub

    Private Sub optSelGP_Click(sender As Object, e As EventArgs) Handles optSelGP.Click
        If chkLoad = True Then
            addListType()
            selProd = "01"
        End If
    End Sub

    Private Sub optSelNPD_CheckedChanged(sender As Object, e As EventArgs) Handles optSelNPD.CheckedChanged

    End Sub

    Private Sub optSelNPD_Click(sender As Object, e As EventArgs) Handles optSelNPD.Click
        If chkLoad = True Then
            addListType()
            selProd = "05"
        End If
    End Sub

    Private Sub optSel2_CheckedChanged(sender As Object, e As EventArgs) Handles optSel2.CheckedChanged

    End Sub

    Private Sub optSel2_Click(sender As Object, e As EventArgs) Handles optSel2.Click
        If chkLoad = True Then
            addListType()
        End If
    End Sub

    Private Sub cboStkType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStkType.SelectedIndexChanged
        If chkLoad = True Then
            'genSumTTSales()
        End If
    End Sub

    Private Sub cboStkType_Click(sender As Object, e As EventArgs) Handles cboStkType.Click

    End Sub

    Private Sub optSelTT_CheckedChanged(sender As Object, e As EventArgs) Handles optSelTT.CheckedChanged

    End Sub

    Private Sub lsvSaleSum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvSaleSum.SelectedIndexChanged

    End Sub

    Private Sub lsvSaleSum_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lsvSaleSum.ColumnClick
        If lsvSaleSum.Columns(e.Column).Width = 10 Then
            lsvSaleSum.Columns(e.Column).Width = 90
        Else
            lsvSaleSum.Columns(e.Column).Width = 10

        End If


    End Sub
    Public Class test
        Public Sub New(ByVal Name1 As String, ByVal cost As String)
            _name1 = Name1
            _cost = cost
        End Sub
        Private _name1 As String
        Public Property Name1() As String
            Get
                Return _name1
            End Get
            Set(ByVal value As String)
                _name1 = value
            End Set
        End Property

        Private _cost As String
        Public Property Cost() As String
            Get
                Return _cost
            End Get
            Set(ByVal value As String)
                _cost = value
            End Set
        End Property
    End Class
    Sub testDBgrid()

        Dim list = New List(Of test)
        list.Add(New test("Mac", 2200))
        list.Add(New test("PC", 1100))

        ' DataGridView1.DataSource = list
        dataShow.Columns.Add("Test", "Win")
        dataShow.Columns(0).Width = 150
        dataShow.Columns.Add("Test2", "Loss")
        dataShow.Columns(1).Width = 250
        'DataGridView1.Columns.Add("Test3", "Win")
        For i = 0 To list.Count - 1
            dataShow.Rows.Add(list(i).Name1, list(i).Cost)
        Next
        dataShow.Rows(1).Cells(1).Style.BackColor = Color.Orange

    End Sub

    Private Sub cmbTest_Click(sender As Object, e As EventArgs) Handles cmbTest.Click
        testDBgrid()
    End Sub
End Class