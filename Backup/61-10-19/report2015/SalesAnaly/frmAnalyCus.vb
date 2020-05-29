
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmAnalyCus

    Dim strCusCode As String
    Dim frmLoad As Boolean = False
    Dim selMonth As String = ""
    Dim selCus As String = "" 'selCusID

    Sub addCboSL0()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL = txtSQL & "From  MktCusGrade "
        txtSQL = txtSQL & "Order by Grd_C_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listSL01")
        If subDS.Tables("listSL01").Rows.Count > 0 Then

            cboSelGrade.DataSource = subDS.Tables("listSL01")
            cboSelGrade.ValueMember = "Grd_C_ID"
            cboSelGrade.DisplayMember = "Grd_C_Name"
            'cboDClist.Text = ""
            cboSelGrade.SelectedItem = 0

        End If
    End Sub
    Sub addCboSL1()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL = txtSQL & "From  MktSegment "
        txtSQL = txtSQL & "Order by grp_code "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listSL01")

        If subDS.Tables("listSL01").Rows.Count > 0 Then

            cboSegment.DataSource = subDS.Tables("listSL01")
            cboSegment.ValueMember = "grp_code"
            cboSegment.DisplayMember = "Grp_Name"
            'cboDClist.Text = ""
            cboSegment.SelectedItem = 0

        End If
    End Sub
    Sub setHeadSalesItem()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvSalesItem.Columns.Add("#", 40, HorizontalAlignment.Left)
        lsvSalesItem.Columns.Add("วันที่", 70, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("รายการ", 120, HorizontalAlignment.Left)
        ' lsvSalesItem.Columns.Add("จำนวน", 50, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("ราคา/หน่วย", 80, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("ราคา/kg", 60, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("ทุนขาย", 90, HorizontalAlignment.Right)
        lsvSalesItem.Columns.Add("กำไร", 90, HorizontalAlignment.Right)

        lsvSalesItem.View = View.Details
        lsvSalesItem.FullRowSelect = True
        lsvSalesItem.GridLines = True

    End Sub
    Sub setHeadCusGrp()
        With lsvCusGrp
            .Columns.Add("#", 10, HorizontalAlignment.Center)
            .Columns.Add("รายชื่อบริษัทในเครือ", 350, HorizontalAlignment.Left)
            .Columns.Add("รหัส", 75, HorizontalAlignment.Right)

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True

        End With
    End Sub
    Sub setHeadMonthItem()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvListMonth.Columns.Add("#", 10, HorizontalAlignment.Center)
        lsvListMonth.Columns.Add("เดือน", 90, HorizontalAlignment.Left)
        lsvListMonth.Columns.Add("น้ำหนัก(T)", 65, HorizontalAlignment.Right)
        lsvListMonth.Columns.Add("มูลค่าขาย(ล้าน)", 90, HorizontalAlignment.Right)
        lsvListMonth.Columns.Add("ทุนขาย(ล้าน)", 90, HorizontalAlignment.Right)
        lsvListMonth.Columns.Add("กำไร(ล้าน)", 90, HorizontalAlignment.Right)
        lsvListMonth.Columns.Add("เดือน", 90, HorizontalAlignment.Right)

        lsvListMonth.View = View.Details
        lsvListMonth.FullRowSelect = True
        lsvListMonth.GridLines = True



    End Sub
    Sub RunFrmLoad()
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If frmLoad = False Then
            selCus = selCusID
            Call addCboSL0()
            Call addCboSL1()

            Call setHeadSalesItem()
            Call setHeadMonthItem()

            'Call runGetTarget()
            Call showChartMonth()
            Call showChartGrpProD()
            'Call showData()
            optNowY.Text = "ปี" & Year(Now)
            optNowMonth.Text = "เฉพาะเดือน " & Month(Now)
            optAVG_Now.Text = "ค่าเฉลี่ย " & Month(Now) - 1 & "เดือน"
            'If setFrm = 0 Then

            'Else
            '    'lbFrm.Text = "กลุ่ม"
            '    'Call addCboSL1()
            'End If

            lbLink.BackColor = Color.Gray
            lbID.Text = selCus
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ArFile "
            txtSQL = txtSQL & "Where Ar_Cus_ID='" & selCus & "' "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "arFile1")

            With subDS.Tables("arFile1")

                lbName.Text = .Rows(0).Item("Ar_Name") 'dbTools.getCusName(selCus)
                If IsDBNull(.Rows(0).Item("Ar_Target")) Then
                    txtTargetProfit.Text = "0"
                Else
                    txtTargetProfit.Text = Format(.Rows(0).Item("Ar_Target"), "#,##0.00")
                End If
                If IsDBNull(.Rows(0).Item("Ar_Sales_Target")) Then
                    txtTargetSales.Text = "0"
                Else
                    txtTargetSales.Text = Format(.Rows(0).Item("Ar_Sales_Target"), "#,##0.00")
                End If
                cboSelGrade.SelectedValue = .Rows(0).Item("Ar_Grade")
                cboSegment.SelectedValue = .Rows(0).Item("Ar_Group")
                lbContactName.Text = .Rows(0).Item("Ar_Contact")
                If IsDBNull(.Rows(0).Item("Ar_Contact_2")) Then
                    lbContactName2.Text = ""
                Else
                    lbContactName2.Text = .Rows(0).Item("Ar_Contact_2")
                End If

                lbTel.Text = .Rows(0).Item("Ar_Tel_No")

            End With
            frmLoad = True
        End If

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Where Ar_Grp_ID='" & selCus & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "arFile2")
        Dim strRow As Integer = 0
        Dim strArName As String = ""
        Dim strArCode As String = ""
        Dim anyData() As String
        Dim lvi As ListViewItem

        lsvCusGrp.Items.Clear()
        Call setHeadCusGrp()

        For i = 0 To subDS.Tables("arFile2").Rows.Count - 1
            With subDS.Tables("arFile2").Rows(i)
                strRow = i + 1
                strArName = .Item("Ar_Name")
                strArCode = .Item("Ar_Cus_ID")

                anyData = New String() {strRow, strArName, strArCode}
                lvi = New ListViewItem(anyData)

            End With
            lsvCusGrp.Items.Add(lvi)
        Next

    End Sub
    Private Sub frmSetGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RunFrmLoad()
    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If Not IsNumeric(txtTargetProfit.Text) Then
            MsgBox("ข้อมูล Target ไม่ถูกต้อง", MsgBoxStyle.Critical, "แจ้งเตือน !")
        End If

        txtSQL = "Update ArFile "
        txtSQL = txtSQL & "Set Ar_Grade='" & cboSelGrade.SelectedValue & "', "
        txtSQL = txtSQL & "Ar_Target='" & CDbl(txtTargetProfit.Text) & "', "
        txtSQL = txtSQL & "Ar_Sales_Target='" & CDbl(txtTargetSales.Text) & "',"
        txtSQL = txtSQL & "Ar_Contact='" & lbContactName.Text & "',"
        txtSQL = txtSQL & "Ar_Contact_2='" & lbContactName2.Text & "',"
        txtSQL = txtSQL & "Ar_Group='" & cboSegment.SelectedValue & "' "

        txtSQL = txtSQL & "Where Ar_Cus_iD='" & lbID.Text & "' "

        dbTools.dbSaveSQLsrv(txtSQL, "")
        Me.Close()

        'If setFrm = 0 Then

        '    'Else
        '    '    txtSQL = "Update ArFile "
        '    '    txtSQL = txtSQL & "Set AR_Group='" & cboSelGrade.SelectedValue & "', "
        '    '    txtSQL = txtSQL & "Ar_Target='" & txtTarget.Text & "' "

        '    '    txtSQL = txtSQL & "Where Ar_Cus_ID='" & lbID.Text & "' "

        '    '    dbTools.dbSaveSQLsrv(txtSQL, "")
        '    '    Me.Close()

        'End If
    End Sub
    Function getSQLShowData() As String
        ' Dim strCusCode As String = lbID.Text

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On (Trh_Type=Dtl_Type And Trh_No=Dtl_No ) "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Where (Trh_Type='S' "
        txtSQL = txtSQL & "And ( Trh_NoType='V' "
        txtSQL = txtSQL & "or Trh_NoType='B'"
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & "or Trh_NoType='M'"
        txtSQL = txtSQL & "or Trh_NoType='N' )) "

        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "'"
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If
        txtSQL = txtSQL & "And year(Trh_Date)=year(GETDATE()) "
        txtSQL = txtSQL & "And Month(Trh_Date)='" & selMonth & "' "

        If optGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        ElseIf optTT.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='02' "
        ElseIf optTotal.Checked = True Then

        End If
        If optAVG_Now.Checked = True Then
        ElseIf opt3Y.Checked = True Then
        Else
        End If


        txtSQL = txtSQL & "And Trh_Amt > 0 "
        txtSQL = txtSQL & "Order by Trh_Date,TRh_No "

        Return txtSQL

    End Function

    Sub showData()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem

        Dim dblAmt As Double = 0
        Dim dblCost As Double = 0
        Dim dblProfit As Double = 0
        Dim dblQty As Double = 0
        Dim dblQtyW As Double = 0
        Dim strDocNO As String = ""
        Dim strStkName As String = ""
        Dim dblPrice As Double = 0
        Dim dblPrKG As Double = 0
        Dim strDate As String = ""
        Dim chkRow As Integer = 0

        txtSQL = getSQLShowData()

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slDetail")
        lsvSalesItem.Items.Clear()

        For i = 0 To subDS.Tables("slDetail").Rows.Count - 1
            dblAmt = 0 : dblCost = 0 : dblPrice = 0 : dblProfit = 0
            dblQty = 0 : dblQtyW = 0 : strDocNO = "" : strDate = ""
            With subDS.Tables("slDeTail").Rows(i)

                strDate = .Item("Trh_Date")
                strDocNO = .Item("Trh_No")
                'dblAmt = .Item("Trh_Amt") - .Item("Trh_Disc_Amt")
                dblCost = 0 '.Item("Trh_Cost_Amt")
                dblProfit = 0 ' dblAmt - dblCost
                dblQtyW = .Item("Stk_Factor") * .Item("Dtl_Num")

                strStkName = .Item("Stk_Name_1")
                dblQty = .Item("Dtl_Num")
                dblPrice = .Item("Dtl_Price")

                If .Item("Trh_Prod_Sales") = "01" Then
                    dblPrKG = (.Item("Dtl_Price") / .Item("Stk_Factor"))
                    dblCost = .Item("Dtl_Cost_Sum") / dblQty
                Else
                    dblPrKG = 0
                    dblCost = .Item("Dtl_Cost_Sum") / dblQty
                End If
                dblProfit = (dblPrice - dblCost) * dblQty
                'dblQty = .Item("Dtl_Num")

                anyData = New String() {i + 1, strDate, strStkName, dblQty.ToString("#,##0.00"), dblPrice.ToString("#,##0.00"), dblPrKG.ToString("#,##0.00"), dblCost.ToString("#,##0.00"), dblProfit.ToString("#,##0.00")}
                lvi = New ListViewItem(anyData)
                'lbSumAmt.Text = (CDbl(lbSumAmt.Text) + dblAmt).ToString("#,##0.00")
                'lbSumCost.Text = (CDbl(lbSumCost.Text) + dblCost).ToString("#,##0.00")
                'lbSumProfit.Text = (CDbl(lbSumProfit.Text) + dblProfit).ToString("#,##0.00")
                'lbSumQtyW.Text = (CDbl(lbSumQtyW.Text) + dblQtyW).ToString("#,##0.00")
                lsvSalesItem.Items.Add(lvi)

                If chkRow = 0 Then
                    lvi.BackColor = Color.White
                    lvi.ForeColor = Color.Black
                    chkRow = 1

                ElseIf chkRow = 1 Then
                    lvi.BackColor = Color.PaleGoldenrod
                    lvi.ForeColor = Color.Black
                    chkRow = 0

                Else
                    lvi.BackColor = Color.Black
                    lvi.ForeColor = Color.White

                End If
            End With
        Next

    End Sub

    Function genSQLChartMonth() As String

        txtSQL = "select  "
        If optPrice.Checked = True Then
            'txtSQL = txtSQL & "month(Trh_Date)as Month,sum(Trh_Amt)as sumAmt,sum(Trh_W_Sum)as SumQtyW "
            txtSQL = txtSQL & " year(trh_date)as Y,month(trh_date)as M ,sum(isnull(trh_amt,0))as Trh_Amt,sum(isnull(trh_w_sum,0))as Trh_W_Sum,isnull(sum(trh_amt)/sum(trh_w_sum),0)as price "


        Else

            txtSQL = txtSQL & " year(trh_date)as Y,month(trh_date)as M ,sum(Trh_Cost_Amt)as Trh_Cost,sum(isnull(trh_amt-Trh_Disc_Amt,0))as Trh_Amt,sum(isnull(trh_w_sum,0))as Trh_W_Sum, "
            txtSQL = txtSQL & "isnull(sum(trh_amt)/sum(trh_w_sum),0)as price "
            'ElseIf optProfit.Checked = True Then

            '    txtSQL = txtSQL & "sum(case when month(trh_date)=01 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total01], "
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=02 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total02],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=03 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total03],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=04 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total04],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=05 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total05],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=06 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total06],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=07 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total07],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=08 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total08],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=09 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total09],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=10 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total10],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=11 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total11],"
            '    txtSQL = txtSQL & "sum(case when month(trh_date)=12 then (Trh_Amt-Trh_Cost_Amt) else 0 end) as [Total12] "

        End If

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "left join ArFile on trh_cus = AR_CUS_ID "

        txtSQL = txtSQL & "where (trh_type = 'S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' or Trh_NoType='Y'))  "
        txtSQL = txtSQL & "And Trh_Amt > 0 "
        txtSQL = txtSQL & ""

        ' txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "

        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "'"
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If

        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If

        If optGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        ElseIf optTT.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='02' "
        ElseIf optTotal.Checked = True Then

        End If

        If optPrice.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        End If

        If optPrice.Checked = True Then

            ' txtSQL = txtSQL & "Group by month(Trh_Date) "
            txtSQL = txtSQL & "group by year(trh_date),month(trh_date) "
        Else
            txtSQL = txtSQL & " Group by  year(trh_Date),month(trh_date) "
        End If
        'txtSQL = txtSQL & "order by  Total01 desc"

        txtSQL = txtSQL & "order by year(trh_Date),month(Trh_date) "

        txtSQL = txtSQL & ""
        txtSQL = txtSQL & ""
        Return txtSQL

    End Function

    Function showPrice()

        txtSQL = "select  "
        txtSQL = txtSQL & " year(trh_date)as Y,month(trh_date)as M ,sum(isnull(trh_amt,0))as Trh_Amt,sum(isnull(trh_w_sum,0))as Trh_W_Sum,isnull(sum(trh_amt)/sum(trh_w_sum),0)as price "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "left join ArFile "
        txtSQL = txtSQL & "on Trh_cus = AR_CUS_ID "

        txtSQL = txtSQL & "where (trh_type = 'S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' or Trh_NoType='Y'))  "
        txtSQL = txtSQL & "And Trh_Amt > 0 "
        txtSQL = txtSQL & ""

        ' txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "'"
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If

        txtSQL = txtSQL & "And Trh_Prod_Sales='01' "

        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "

        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If

        If optGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        ElseIf optTT.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='02' "
        ElseIf optTotal.Checked = True Then

        End If

        txtSQL = txtSQL & "Group by year(trh_Date),month(trh_date) "
        txtSQL = txtSQL & "Order by year(trh_Date),month(Trh_date) "

        txtSQL = txtSQL & ""
        txtSQL = txtSQL & ""

        Return txtSQL
    End Function

    Sub showChartMonth()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        Dim anyData() As String
        Dim lvi As ListViewItem
        Dim chkRow As Integer = 1
        Dim data01 As New DataPoint()

        Dim seriesAmt As New Series '("SERIES0")
        Dim seriesPrice As New Series

        'Dim seriesCost As New Series

        Dim MonthName As String = ""
        Dim dblAmt As Double = 0
        Dim dblPrice As Double = 0
        Dim dblCost As Double = 0
        Dim dblQtyW As Double = 0
        Dim dblProfit As Double = 0
        Dim strMonth As String = ""
        Dim max0 As Double = 0
        Dim min0 As Double = 100000
        txtSQL = genSQLChartMonth()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "saleMonth")

        txtSQL = showPrice()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "showPrice")

        ChartMonth.ChartAreas(0).AxisX.LineWidth = 2
        ChartMonth.ChartAreas(0).AxisX.Interval = 1

        ChartMonth.Series.Clear()
        lsvListMonth.Items.Clear()
        Dim sumQtyW As Double = 0
        Dim sumAmt As Double = 0
        Dim sumCost As Double = 0
        Dim sumProfit As Double = 0

        For i = 0 To subDS.Tables("saleMonth").Rows.Count - 1

            If optPrice.Checked = True Then
                chkRow = 1

                With subDS.Tables("saleMonth").Rows(i)
                    MonthName = .Item("Y").ToString & "-" & .Item("M").ToString

                    dblPrice = (.Item("Trh_Amt") / .Item("Trh_W_Sum"))
                    seriesAmt.Points.AddXY(MonthName, dblPrice)

                End With
                anyData = New String() {i + 1, MonthName, dblPrice.ToString("#,##0.00")}
                lvi = New ListViewItem(anyData)
                lsvListMonth.Items.Add(lvi)
                If chkRow = 0 Then
                    lvi.BackColor = Color.Silver
                    lvi.ForeColor = Color.Black
                    chkRow = 1

                ElseIf chkRow = 1 Then
                    lvi.BackColor = Color.PaleGoldenrod
                    lvi.ForeColor = Color.Black
                    chkRow = 0

                Else
                    lvi.BackColor = Color.Black
                    lvi.ForeColor = Color.White

                End If
                If max0 <= dblPrice Then
                    max0 = dblPrice
                End If


            Else
                chkRow = 1


                With subDS.Tables("saleMonth").Rows(i)
                    MonthName = .Item("Y").ToString & "-" & .Item("M").ToString
                    strMonth = .Item("M").ToString
                    sumQtyW = sumQtyW + .Item("Trh_W_Sum")
                    sumAmt = sumAmt + .Item("Trh_Amt")
                    sumCost = sumCost + .Item("Trh_Cost")
                    sumProfit = sumAmt - sumCost
                    '========================
                    If opt3Y.Checked = True Then
                        dblAmt = .Item("Trh_Amt") / 1000000
                        dblCost = .Item("Trh_Cost") / 1000000
                        dblQtyW = .Item("Trh_W_Sum") / 1000
                        dblProfit = (dblAmt - dblCost)
                    Else
                        dblAmt = .Item("Trh_Amt")
                        dblCost = .Item("Trh_Cost")
                        dblQtyW = .Item("Trh_W_Sum") / 1000
                        dblProfit = (dblAmt - dblCost)
                    End If

                    If optAmt.Checked = True Then
                        seriesAmt.Points.AddXY(MonthName, dblAmt)

                        If max0 <= dblAmt Then
                            max0 = dblAmt
                        End If
                    ElseIf optProfit.Checked = True Then

                        seriesAmt.Points.AddXY(MonthName, dblProfit)
                        If max0 <= dblProfit Then
                            max0 = dblProfit
                        End If
                    ElseIf optQtyW.Checked = True Then
                        seriesAmt.Points.AddXY(MonthName, dblQtyW)
                        If max0 <= dblQtyW Then
                            max0 = dblQtyW
                        End If
                    End If

                    anyData = New String() {"", MonthName, dblQtyW.ToString("#,##0.00"), dblAmt.ToString("#,##0.00"), dblCost.ToString("#,##0.00"), dblProfit.ToString("#,##0.00"), strMonth}
                    lvi = New ListViewItem(anyData)

                    lsvListMonth.Items.Add(lvi)
                    If chkRow = 0 Then
                        lvi.BackColor = Color.Silver
                        lvi.ForeColor = Color.Black
                        chkRow = 1

                    ElseIf chkRow = 1 Then
                        lvi.BackColor = Color.PaleGoldenrod
                        lvi.ForeColor = Color.Black
                        chkRow = 0

                    Else
                        lvi.BackColor = Color.Black
                        lvi.ForeColor = Color.White

                    End If
                End With

                'If min0 >= dblAmt Then
                '    min0 = dblAmt
                'End If

            End If

            lbTotalSales.Text = Format((sumAmt), "#,##0.00")
            lbTotalQtyW.Text = Format((sumQtyW), "#,##0.00")
            lbTotalProfit.Text = Format((sumProfit), "#,##0.00")
            lbPrKg01.Text = Format(lbTotalSales.Text / lbTotalQtyW.Text, "#,##0.00")

            If optNow.Checked = True Then
                lbSalesAVG.Text = Format((sumAmt / (i + 1)), "#,##0.00")
                lbQtyWAVG.Text = Format((sumQtyW / (i + 1)), "#,##0.00")
                lbProfitAVG.Text = Format((sumProfit) / (i + 1), "#,##0.00")
                lbRatioYear.Text = Format((sumProfit / sumCost) * 100, "#,##0.00")
                lbPrKg02.Text = Format(lbSalesAVG.Text / lbQtyWAVG.Text, "#,##0.00")
            Else
                lbSalesAVG.Text = Format((sumAmt / (i + 1)) * 12, "#,##0.00")
                lbQtyWAVG.Text = Format((sumQtyW / (i + 1)) * 12, "#,##0.00")
                lbProfitAVG.Text = Format((sumProfit) / (i + 1) * 12, "#,##0.00")
                lbRatioYear.Text = Format((sumProfit / sumCost) * 100, "#,##0.00")
                lbPrKg02.Text = Format(lbSalesAVG.Text / lbQtyWAVG.Text, "#,##0.00")
            End If

        Next
        anyData = New String() {"#", "ยอดรวม", sumQtyW.ToString("#,##0.00"), sumAmt.ToString("#,##0.00"), sumCost.ToString("#,##0.00"), sumProfit.ToString("#,##0.00"), ""}
        lvi = New ListViewItem(anyData)
        lsvListMonth.Items.Add(lvi)
        lvi.BackColor = Color.YellowGreen
        lvi.ForeColor = Color.Black

        For i = 0 To subDS.Tables("showPrice").Rows.Count - 1

            With subDS.Tables("showPrice").Rows(i)
                MonthName = "เดือน-" & .Item("Y").ToString & "/" & .Item("M").ToString
                If subDS.Tables("showPrice").Rows.Count > 0 Then
                    If IsDBNull(.Item("price")) Then
                        dblPrice = 0
                    Else
                        dblPrice = .Item("price")
                    End If
                End If
                seriesPrice.Points.AddXY(MonthName, dblPrice)
            End With

        Next
        'Dim Area0 As New ChartArea
        'Area0.AxisX.LineWidth = 2
        'Area0.AxisX.Interval = 1
        'Area0.AxisX.MajorGrid.Enabled = False

        seriesAmt.Palette = ChartColorPalette.EarthTones
        ' seriesPrice.Palette = ChartColorPalette.BrightPastel
        seriesPrice.Color = Color.OrangeRed
        seriesPrice.LabelForeColor = Color.Black
        seriesPrice.LabelBackColor = Color.YellowGreen

        'If optPrice.Checked = True Then

        '    seriesAmt.ChartType = SeriesChartType.Line
        'Else
        '    seriesAmt.ChartType = SeriesChartType.Column

        'End If

        If optBar.Checked = True Then
            seriesAmt.ChartType = SeriesChartType.Column
            seriesPrice.ChartType = SeriesChartType.Line
        Else
            seriesAmt.ChartType = SeriesChartType.Line
            seriesPrice.ChartType = SeriesChartType.Line
        End If

        seriesAmt.LabelFormat = "#,##0.00"
        seriesAmt.BorderWidth = 4
        seriesAmt.IsValueShownAsLabel = True
        seriesAmt.IsVisibleInLegend = False
        seriesAmt.LabelAngle = -90
        seriesPrice.BorderWidth = 4   '  กำหนดขนาดเส้นของกราฟเส้น
        seriesAmt.YAxisType = AxisType.Primary

        seriesPrice.LabelFormat = "#,##0.00"
        seriesPrice.YAxisType = AxisType.Secondary
        If opt3Y.Checked Then
            seriesPrice.IsValueShownAsLabel = False
            seriesPrice.IsVisibleInLegend = False
        Else
            seriesPrice.IsValueShownAsLabel = True
            seriesPrice.IsVisibleInLegend = False
        End If


        seriesAmt.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        If opt3Y.Checked = True Then
            seriesPrice.Font = New Font(Me.Font.Name, 8, FontStyle.Regular)
        Else
            seriesPrice.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End If


        ' series0.Color = Color.Black
        With ChartMonth
            '.Text = "กราฟแสดงยอดขาย "
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(seriesAmt)
            .Series.Add(seriesPrice)
            If optPrice.Checked = True Then
                '.BorderlineWidth = 1
            Else
                '.BorderlineWidth = 1
            End If
            .BackColor = Color.AliceBlue
            '.BackColor = Color.GhostWhite
            .ChartAreas(0).AxisX.LabelStyle.Font = New Font(Me.Font.Name, 10, FontStyle.Regular) 'New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Italic)
            '.ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            .ChartAreas(0).AxisX.LabelStyle.Angle = -90
            '.ChartAreas(0).AxisY.LabelStyle.Angle = -90
            '.ChartAreas(0).AxisY.MinorTickMark.Enabled = True
            '.ChartAreas(0).AxisY2.MinorTickMark.Enabled = True
            .ChartAreas(0).AxisX.LineWidth = 2
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            .ChartAreas(0).AxisY.MajorGrid.Enabled = False
            '.ChartAreas.Add(Area0)
            '.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            If optPrice.Checked = True Then
                .ChartAreas(0).AxisY.Minimum = 80
                .ChartAreas(0).AxisY.Maximum = max0 + 20
                '.ChartAreas(0).BackColor = Color.Black
            Else
                .ChartAreas(0).AxisY.Minimum = 0
                .ChartAreas(0).AxisX2.Minimum = 50
                '.ChartAreas(0).AxisY.Minimum = max0 - 100000
                'If optGP.Checked = True Then
                '.ChartAreas(0).AxisY.Maximum = max0 
                'ElseIf optTT.Checked = True Then
                '    .ChartAreas(0).AxisY.Maximum = max0 + 10000
                'ElseIf optTotal.Checked = True Then
                '    .ChartAreas(0).AxisY.Maximum = max0 + 100000

                'End If
                If optAmt.Checked = True Then
                    If opt3Y.Checked = True Then
                        .ChartAreas(0).AxisY.Maximum = max0
                    Else
                        .ChartAreas(0).AxisY.Maximum = max0 + 3000
                    End If
                    .ChartAreas(0).AxisX2.Minimum = 50
                ElseIf optProfit.Checked = True Then
                    If opt3Y.Checked = True Then
                        .ChartAreas(0).AxisY.Maximum = max0
                    Else

                        .ChartAreas(0).AxisY.Maximum = max0 + 3000
                    End If
                    .ChartAreas(0).AxisX2.Minimum = 50
                ElseIf optQtyW.Checked = True Then
                    If opt3Y.Checked = True Then
                        .ChartAreas(0).AxisY.Maximum = max0
                    Else
                        .ChartAreas(0).AxisY.Maximum = max0 + 3
                    End If
                    .ChartAreas(0).AxisY.Maximum = max0 + 3
                    .ChartAreas(0).AxisX2.Minimum = 50
                End If

            End If


        End With

    End Sub
    Function genSQLGrpProD()

        txtSQL = "select Trh_Prod_Sales,ProGrpMast.ProGrp_Name, "
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select sum(Trh_Amt) "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "where (trh_type = 'S' And (Trh_NoType='V' or Trh_NoType='N' Or Trh_NoType='B' or Trh_NoType='M' Or Trh_NoType='Z' or Trh_NoType='Y')) "
        txtSQL = txtSQL & "And Trh_Amt >0 "


        ' txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If

        'txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "'"
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If

        txtSQL = txtSQL & ")as sumSales, "
        txtSQL = txtSQL & "sum(Trh_Cost_Amt)as Trh_Cost, "
        txtSQL = txtSQL & "sum(isnull(trh_amt,0))as Trh_Amt, "
        txtSQL = txtSQL & "sum(isnull(trh_w_sum,0))as Trh_W_Sum, "
        txtSQL = txtSQL & "isnull(sum(trh_amt)/sum(trh_w_sum),0)as price "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left join ArFile on trh_cus = AR_CUS_ID "
        txtSQL = txtSQL & "Left Join ProGrpMast  "
        txtSQL = txtSQL & "On Trh_ProD_Sales=ProGrpMast.ProGrp_ID "

        txtSQL = txtSQL & "where (trh_type = 'S' And (Trh_NoType='V' or Trh_NoType='N' Or Trh_NoType='B' or Trh_NoType='M' Or Trh_NoType='Z' or Trh_NoType='Y'))  "
        txtSQL = txtSQL & "And Trh_Amt > 0 "

        'txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "'"
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If


        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If
        ' txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "

        txtSQL = txtSQL & "Group by  Trh_Prod_Sales,ProGrpMast.ProGrp_Name "
        txtSQL = txtSQL & ""
        Return txtSQL

    End Function
    Sub showChartGrpProD()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim strGrpName As String = ""
        Dim dblGrpValues As Double = 0
        Dim dblGRpAmt As Double = 0
        Dim dblGrpSumAmt As Double = 0
        Dim series0 As New Series("SERIES0")
        ChartGrp.Series.Clear()
        txtSQL = genSQLGrpProD()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "rptGrpProD")

        For i = 0 To subDS.Tables("rptGrpProD").Rows.Count - 1
            With subDS.Tables("rptGrpProD").Rows(i)
                strGrpName = .Item("ProGrp_Name")
                dblGrpSumAmt = .Item("sumSales")
                dblGRpAmt = .Item("Trh_Amt")
                dblGrpValues = 100 - (((dblGrpSumAmt - dblGRpAmt) / dblGrpSumAmt) * 100)

                series0.Points.AddXY(strGrpName, Format(dblGrpValues, "#,##0.00"))
            End With
        Next
        series0.ChartType = SeriesChartType.Pie
        series0.LabelFormat = "#,##0.00"
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = True

        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        With ChartGrp

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
    Private Sub optAmt_CheckedChanged(sender As Object, e As EventArgs) Handles optAmt.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optProfit_CheckedChanged(sender As Object, e As EventArgs) Handles optProfit.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optPrice_CheckedChanged(sender As Object, e As EventArgs) Handles optPrice.CheckedChanged
        If frmLoad = True Then
            optLine.Checked = True
            optGP.Checked = True
            Call showChartMonth()

        End If
    End Sub

    Private Sub optGP_CheckedChanged(sender As Object, e As EventArgs) Handles optGP.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optTT_CheckedChanged(sender As Object, e As EventArgs) Handles optTT.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optTotal_CheckedChanged(sender As Object, e As EventArgs) Handles optTotal.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub opt3Y_CheckedChanged(sender As Object, e As EventArgs) Handles opt3Y.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optNowY_CheckedChanged(sender As Object, e As EventArgs) Handles optNowY.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optQtyW_CheckedChanged(sender As Object, e As EventArgs) Handles optQtyW.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optBar_CheckedChanged(sender As Object, e As EventArgs) Handles optBar.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optLine_CheckedChanged(sender As Object, e As EventArgs) Handles optLine.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub lsvListMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvListMonth.SelectedIndexChanged

    End Sub

    Private Sub lsvListMonth_DoubleClick(sender As Object, e As EventArgs) Handles lsvListMonth.DoubleClick
        Dim lvi0 As ListViewItem
        For i = 0 To lsvListMonth.SelectedItems.Count - 1
            lvi0 = lsvListMonth.SelectedItems(i)
            selMonth = lsvListMonth.Items(lvi0.Index).SubItems(6).Text
        Next
        Call showData()
    End Sub

    Private Sub lsvSalesItem_DoubleClick(sender As Object, e As EventArgs) Handles lsvSalesItem.DoubleClick



    End Sub

    Private Sub ChartGrp_Click(sender As Object, e As EventArgs) Handles ChartGrp.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Sub runAnalyStock()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem

        txtSQL = "Select Top 20 Dtl_idTrade,BaseMast.Stk_Name_1,count(Dtl_idTrade)as countID,"
        txtSQL = txtSQL & "sum(Dtl_Num)as Dtl_Num ,sum(Dtl_Num*Stk_Factor)as sumQtyW "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On (Trh_Type=Dtl_Type And Trh_No=Dtl_No) "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "

        txtSQL = txtSQL & "Where  "

        'txtSQL = txtSQL & "Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "Ar_grp_id='" & selCus & "' "
        Else
            txtSQL = txtSQL & "Trh_Cus='" & selCus & "' "
        End If

        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If

        If optGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        ElseIf optTT.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='02' "
        ElseIf optTotal.Checked = True Then

        End If
        'txtSQL = txtSQL & "And countID > 20 "

        ' txtSQL = txtSQL & "And Trh_ProD_Sales='01' "  ' เพื่อหาค่าเฉลี่ยของ GP
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        'txtSQL = txtSQL & "Or Trh_NoType='B' "  ' ตัดออก เพราะคิดว่า การดูความถี่ของการขาย
        'txtSQL = txtSQL & "Or Trh_NoType='M' "  ' ต้องไม่ใช่การขายก่อน แต่ตั้งเป็นการส่งสินค้าที่ใช้จริงต่อครั้ง จุึงต้องรวม X เข้ามาเพื่อดูการเรียกของเข้า
        txtSQL = txtSQL & "Or Trh_NoType='X' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") )"
        txtSQL = txtSQL & "Group by Dtl_idtrade,Stk_Name_1 "
        If optSelF.Checked = True Then
            txtSQL = txtSQL & "Order by count(Dtl_idTrade)desc "
        ElseIf optSelQty.Checked = True Then
            txtSQL = txtSQL & "Order by sum(Dtl_Num)desc "
        ElseIf optSelQtyW.Checked = True Then
            txtSQL = txtSQL & "Order by sum(Dtl_Num*Stk_Factor)desc "
        End If


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "StkGoodSales")

        Dim strStkName As String = ""
        Dim strStkCode As String = ""
        Dim dblNum As Double = 0
        Dim intCountStk As Double = 0
        Dim dblSumQtyW As Double = 0
        Dim series0 As New Series
        Dim dataChart As Double = 0
        Dim max0 As Double = 0
        lsvGoodSale.Clear()
        setHeadDetail()
        ChartMonth.Series.Clear()

        For i = 0 To subDS.Tables("StkGoodSales").Rows.Count - 1
            With subDS.Tables("StkGoodSales").Rows(i)

                strStkName = .Item("Stk_Name_1")
                dblNum = .Item("Dtl_Num")
                dblSumQtyW = .Item("sumQtyW")
                intCountStk = .Item("countID")
                If optSelF.Checked = True Then
                    dataChart = intCountStk
                ElseIf optSelQty.Checked = True Then
                    dataChart = dblNum
                ElseIf optSelQtyW.Checked = True Then
                    dataChart = dblSumQtyW
                End If
                strStkCode = .Item("Dtl_idTrade")
            End With
            anyData = New String() {"#", strStkName, intCountStk.ToString("#,##0.00"), dblSumQtyW.ToString("#,##0.00"), dblNum.ToString("#,##0.00"), strStkCode}
            lvi = New ListViewItem(anyData)
            lsvGoodSale.Items.Add(lvi)

            series0.Points.AddXY(Microsoft.VisualBasic.Left(strStkName, 30), Format(dataChart, "#,##0.00"))
            If max0 < dataChart Then
                max0 = dataChart
            End If
        Next
        series0.Palette = ChartColorPalette.EarthTones
        series0.ChartType = SeriesChartType.Column
        series0.LabelFormat = "#,##0.00"
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = False
        series0.LabelAngle = 90
        With ChartMonth
            .BackColor = Color.Silver
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal
            .Series.Add(series0)
            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Italic)
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            .ChartAreas(0).AxisX.LabelStyle.Angle = -90
            '.ChartAreas(0).AxisY.MinorTickMark.Enabled = True
            '.ChartAreas(0).AxisY2.MinorTickMark.Enabled = True
            .ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            If optSelF.Checked = True Then

                .ChartAreas(0).AxisY.Maximum = max0 + ((max0 * 10) / 100)
            ElseIf optSelQty.Checked = True Then
                .ChartAreas(0).AxisY.Maximum = max0 + ((max0 * 10) / 100)
            ElseIf optselQtyW.Checked = True Then
                .ChartAreas(0).AxisY.Maximum = max0 + ((max0 * 10) / 100)
            End If

        End With

    End Sub
    Private Sub cmbRun01_Click(sender As Object, e As EventArgs) Handles cmbRun01.Click

        Call runAnalyStock()

    End Sub
    Sub setHeadDetail()

        ' lsvDetail.Clear()
        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        With lsvGoodSale.Columns

            .Add("#", 20, HorizontalAlignment.Left)
            .Add("รายการ", 180, HorizontalAlignment.Left)
            .Add("ความถี่", 50, HorizontalAlignment.Right)
            .Add("น้ำหนัก", 60, HorizontalAlignment.Right)
            .Add("จำนวน", 60, HorizontalAlignment.Right)
            .Add(" ID ", 60, HorizontalAlignment.Right)

            lsvGoodSale.View = View.Details
            lsvGoodSale.FullRowSelect = True
            lsvGoodSale.GridLines = True
        End With


    End Sub


    Private Sub optSelQty_Click(sender As Object, e As EventArgs) Handles optSelQty.Click
        If frmLoad = True Then
            Call runAnalyStock()
        End If
    End Sub

    Private Sub optSelQtyW_Click(sender As Object, e As EventArgs) Handles optSelQtyW.Click
        If frmLoad = True Then
            Call runAnalyStock()
        End If
    End Sub

    Private Sub optSelF_Click(sender As Object, e As EventArgs) Handles optSelF.Click
        If frmLoad = True Then
            Call runAnalyStock()
        End If
    End Sub



    Private Sub lsvGoodSale_Click(sender As Object, e As EventArgs) Handles lsvGoodSale.Click
        Dim lvi0 As ListViewItem
        Dim selStkCode As String = ""
        For i = 0 To lsvGoodSale.SelectedItems.Count - 1
            lvi0 = lsvGoodSale.SelectedItems(i)
            selStkCode = lsvGoodSale.Items(lvi0.Index).SubItems(5).Text
        Next
        ' MsgBox(selStkCode)
    End Sub
    Sub getSQLstkMonthF()

        txtSQL = "Select  Trh_Date,count(Dtl_idTrade)as countID,"
        txtSQL = txtSQL & "sum(Dtl_Num)as Dtl_Num ,sum(Dtl_Num*Stk_Factor)as sumQtyW "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On (Trh_Type=Dtl_Type And Trh_No=Dtl_No) "
        txtSQL = txtSQL & "Left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        txtSQL = txtSQL & "Where  "

        'txtSQL = txtSQL & "Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "Ar_grp_id='" & selCus & "' "
        Else
            txtSQL = txtSQL & "Trh_Cus='" & selCus & "' "
        End If

        If opt3Y.Checked = True Then
            txtSQL = txtSQL & "And( year(Trh_date)>=year(GetDate())-2 "
            txtSQL = txtSQL & "And year(Trh_Date)<=year(GetDate())) "
        ElseIf optNowY.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "
        ElseIf optYear59.Checked = True Then
            txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate())-2 "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "And Year(Trh_Date)=year(GETDATE()) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "
        End If

        If optGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='01' "
        ElseIf optTT.Checked = True Then
            txtSQL = txtSQL & "And Trh_Prod_Sales='02' "
        ElseIf optTotal.Checked = True Then

        End If
        'txtSQL = txtSQL & "And countID > 20 "

        ' txtSQL = txtSQL & "And Trh_ProD_Sales='01' "  ' เพื่อหาค่าเฉลี่ยของ GP
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        'txtSQL = txtSQL & "Or Trh_NoType='B' "  ' ตัดออก เพราะคิดว่า การดูความถี่ของการขาย
        'txtSQL = txtSQL & "Or Trh_NoType='M' "  ' ต้องไม่ใช่การขายก่อน แต่ตั้งเป็นการส่งสินค้าที่ใช้จริงต่อครั้ง จุึงต้องรวม X เข้ามาเพื่อดูการเรียกของเข้า
        txtSQL = txtSQL & "Or Trh_NoType='X' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") )"
        txtSQL = txtSQL & "Group by Dtl_idtrade,Stk_Name_1 "
        If optSelF.Checked = True Then
            txtSQL = txtSQL & "Order by count(Dtl_idTrade)desc "
        ElseIf optSelQty.Checked = True Then
            txtSQL = txtSQL & "Order by sum(Dtl_Num)desc "
        ElseIf optSelQtyW.Checked = True Then
            txtSQL = txtSQL & "Order by sum(Dtl_Num*Stk_Factor)desc "
        End If


    End Sub
    Sub runGetTarget()
        If optGrpCus.Checked = True Then
            txtSQL = "Select Ar_grp_id,"
        Else
            txtSQL = "Select Ar_Cus_ID,"
        End If


        txtSQL = txtSQL & "sum(Trh_Cost_Amt)as Trh_Cost_Amt,sum(Trh_Amt)as Trh_Amt,"
        txtSQL = txtSQL & "(((sum(Trh_Amt-Trh_Disc_Amt)-sum(Trh_Cost_Amt))/sum(Trh_Cost_Amt))*100)as Ratio "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "ON Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Where Trh_Amt >0 "

        'txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "And Ar_grp_id='" & selCus & "' "
        Else
            txtSQL = txtSQL & "And Trh_Cus='" & selCus & "' "
        End If

        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
        txtSQL = txtSQL & "And Month(Trh_Date)>=1"  ' เดือน
        txtSQL = txtSQL & "And (Month(Trh_Date)<=month(GetDate())) "  ' เดือน

        ' txtSQL = txtSQL & "And Trh_ProD_Sales='01' "  ' เพื่อหาค่าเฉลี่ยของ GP
        txtSQL = txtSQL & "And  (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' "
        txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") )"
        If optGrpCus.Checked = True Then
            txtSQL = txtSQL & "Group by Ar_grp_id "
        Else
            txtSQL = txtSQL & "Group by Ar_Cus_ID "

        End If


        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataReport")
        Dim PrRatio As Double = 0
        Dim prCost As Double = 0
        With subDS.Tables("dataReport").Rows(0)
            PrRatio = .Item("Ratio")
            lbRadioProfit.Text = Format(PrRatio, "#,##0.00")
            txtTargetProfit.Text = Format((txtTargetSales.Text * PrRatio) / 100, "#,##0.00")
        End With

    End Sub
    Private Sub cmbLink_Click(sender As Object, e As EventArgs) Handles cmbCal.Click
        Call runGetTarget()

    End Sub

    Private Sub optNow_CheckedChanged(sender As Object, e As EventArgs) Handles optNow.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()

        End If
        If optNow.Checked = True Then
            lbLink.Enabled = False
            lbLink.BackColor = Color.Gray
        End If
    End Sub

    Private Sub optYear_CheckedChanged(sender As Object, e As EventArgs) Handles optYear.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
        If optYear.Checked = True Then
            lbLink.Enabled = True
            lbLink.BackColor = Color.OrangeRed
        End If
    End Sub

    Private Sub lbLink_Click(sender As Object, e As EventArgs) Handles lbLink.Click
        txtTargetSales.Text = lbSalesAVG.Text
        Call runGetTarget()
    End Sub

    Private Sub optGrpCus_CheckedChanged(sender As Object, e As EventArgs) Handles optGrpCus.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub lsvCusGrp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCusGrp.SelectedIndexChanged

    End Sub

    Private Sub lsvCusGrp_DoubleClick(sender As Object, e As EventArgs) Handles lsvCusGrp.DoubleClick
        Dim selCusCode As String = ""
        Dim lvi0 As ListViewItem

        For i = 0 To lsvCusGrp.SelectedItems.Count - 1
            lvi0 = lsvCusGrp.SelectedItems(i)
            selCusCode = lsvCusGrp.Items(lvi0.Index).SubItems(2).Text
        Next
        selCusID = selCusCode
        Dim frmSetGrade As New frmAnalyCus
        frmSetGrade.Show()

    End Sub

    Private Sub optYear59_CheckedChanged(sender As Object, e As EventArgs) Handles optYear59.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub optAVG_Now_CheckedChanged(sender As Object, e As EventArgs) Handles optAVG_Now.CheckedChanged
        If frmLoad = True Then
            Call showChartMonth()
        End If
    End Sub

    Private Sub cmbAuto_Click(sender As Object, e As EventArgs) Handles cmbAuto.Click

        optYear59.Checked = True
        optYear.Checked = True
        optGrpCus.Checked = True
        Call showChartMonth()
        txtTargetSales.Text = lbSalesAVG.Text
        Call runGetTarget()

    End Sub
End Class