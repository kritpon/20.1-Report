Public Class frmStkSummary
    Dim chkData As Boolean = False
    Dim chkProfit As Boolean = False
    Dim lvi As ListViewItem
    Dim subDa As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet

    Private Sub frmBegin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbStrConnect.Text = strConn
        Call formatGrid()
    End Sub
    Sub formatGrid()


        lsvShow.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvShow.Columns.Add("รายการ", 300, HorizontalAlignment.Left)

        lsvShow.Columns.Add("จำนวน", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("น้ำหนัก(Kg.)", 100, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ราคาทุน", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("มูลค่าทุน", 110, HorizontalAlignment.Right)

        lsvShow.Columns.Add("ราคาขาย", 100, HorizontalAlignment.Right)
        lsvShow.Columns.Add("มูลค่าขาย", 110, HorizontalAlignment.Right)
        lsvShow.Columns.Add("กำไรรวม", 110, HorizontalAlignment.Right)

        lsvShow.Columns.Add("% กำไร", 90, HorizontalAlignment.Right)


        lsvShow.View = View.Details
        lsvShow.GridLines = True
        'chkCol = True

    End Sub
    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click

        lsvShow.Items.Clear()
        txtSQL = genSQLdb()

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDa.Fill(subDS, "Command")
        chkData = True

        Call getItemDetail()

    End Sub
    Sub getItemDetail()

        With subDS.Tables("Command")
            Dim iRow As Integer = 0
            Dim anyData() As String
            Dim chkRow As Boolean = False
            lbTotalCost.Text = Format(0, "#,##0.00")
            lbTotalSales.Text = Format(0, "#,##0.00")
            lbTotalProfit.Text = Format(0, "#,##0.00")
            lbTotalWeight.Text = Format(0, "#,##0.00")
            lbTotalQty.Text = Format(0, "#,##0.00")

            For iRow = 0 To .Rows.Count - 1

                Dim stkCode As String = .Rows(iRow).Item("Dtl_idTrade")
                Dim strNumber As Integer = iRow + 1
                Dim strStkName As String = .Rows(iRow).Item("Stk_Name_1")
                Dim strQty As Double = .Rows(iRow).Item("sumQty")
                Dim strWeight As Double = .Rows(iRow).Item("sumWeight")

                Dim date01 As Date = (Year(txtDate01.Value) & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value))

                'Dim Dtl_Cost_PR As Double = DBtools.getCostByStk(stkCode, Format(date01, "yyyy-MM-dd"), "", 0)
                'strCost = Dtl_Cost_PR

                Dim strCost As Double = 0
                Dim strSumCost As Double = 0
                If dbTools.getCostType(stkCode) = 0 Then
                    strCost = .Rows(iRow).Item("sumCost") / strWeight
                    strSumCost = strCost * strWeight
                Else
                    strCost = .Rows(iRow).Item("sumCost") / strQty
                    strSumCost = strCost * strQty
                End If
                Dim strPrice As Double = 0

                If dbTools.getCostType(stkCode) = 0 Then
                    strPrice = .Rows(iRow).Item("sumAmt") / strWeight

                Else
                    strPrice = .Rows(iRow).Item("sumAmt") / .Rows(iRow).Item("sumQty")

                End If


                Dim strAmt As Double = .Rows(iRow).Item("sumAmt")

                Dim strProfit As Double = strAmt - strSumCost
                'Dim strProfitKg As Double = (strProfit / strWeight)
                If strProfit > 0 Then
                    chkProfit = True
                Else
                    chkProfit = False
                End If
                Dim ratioProfit As Double = 0
                ratioProfit = (strProfit / strSumCost) * 100

                anyData = New String() {iRow.ToString("#,##0"), strStkName,
                    strQty.ToString("#,##0.00"),
                    strWeight.ToString("#,##0.00"),
                    strCost.ToString("#,##0.00"),
                    strSumCost.ToString("#,##0.00"),
                    strPrice.ToString("#,##0.00"),
                    strAmt.ToString("#,##0.00"),
                    strProfit.ToString("#,##0.00"),
                    ratioProfit.ToString("#,##0.00")}

                lvi = New ListViewItem(anyData)
                lsvShow.Items.Add(lvi)
                If chkRow = True Then
                    colorList(True)
                    chkRow = False
                Else
                    colorList(False)
                    chkRow = True
                End If
                lbTotalCost.Text = Format(lbTotalCost.Text + strSumCost, "#,##0.00")
                lbTotalSales.Text = Format(lbTotalSales.Text + strAmt, "#,##0.00")
                lbTotalProfit.Text = Format(lbTotalProfit.Text + strProfit, "#,##0.00")
                lbTotalWeight.Text = Format(lbTotalWeight.Text + strWeight, "#,##0.00")
                lbTotalQty.Text = Format(lbTotalQty.Text + strQty, "#,##0.00")
            Next


        End With
    End Sub

    Sub colorList(chkRow As Boolean)


        If chkProfit = True Then

            ' lvi.BackColor = System.Drawing.Color.GreenYellow
            If chkRow = False Then
                lvi.BackColor = System.Drawing.Color.Azure 'PowderBlue
                lvi.ForeColor = System.Drawing.Color.Black '
            Else
                lvi.BackColor = System.Drawing.Color.LightBlue
                lvi.ForeColor = System.Drawing.Color.Black '
            End If


            lvi.UseItemStyleForSubItems = True
        Else

            lvi.BackColor = System.Drawing.Color.DarkOrange
            lvi.ForeColor = System.Drawing.Color.White
            'lvi.ForeColor = System.Drawing.Color.Black
            'lvi.SubItems.Item(1).BackColor = Color.Black
            'lvi.SubItems.Item(2).BackColor = Color.Black
            'lvi.SubItems.Item(3).BackColor = Color.Black

            lvi.UseItemStyleForSubItems = True
            chkProfit = True

        End If

    End Sub
    'Function getSQL3Month()

    '    'If optTotalSale.Checked = True Then

    '    txtSQL = txtSQL & "sum(case when month(trh_date)=01 then (Dtl_num * dtl_Price) else 0 end) as [Total01],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=02 then (Dtl_num * dtl_Price) else 0 end) as [Total02],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=03 then (Dtl_num * dtl_Price) else 0 end) as [Total03],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=04 then (Dtl_num * dtl_Price) else 0 end) as [Total04],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=05 then (Dtl_num * dtl_Price) else 0 end) as [Total05],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=06 then (Dtl_num * dtl_Price) else 0 end) as [Total06],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=07 then (Dtl_num * dtl_Price) else 0 end) as [Total07],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=08 then (Dtl_num * dtl_Price) else 0 end) as [Total08],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=09 then (Dtl_num * dtl_Price) else 0 end) as [Total09],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=10 then (Dtl_num * dtl_Price) else 0 end) as [Total10],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=11 then (Dtl_num * dtl_Price) else 0 end) as [Total11],"
    '    txtSQL = txtSQL & "sum(case when month(trh_date)=12 then (Dtl_num * dtl_Price) else 0 end) as [Total12] "

    '    ' ElseIf optTotalW.Checked = True Then
    'End Function
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

    Function genSQLdb() As String

        txtSQL = "Select TranDataD.Dtl_Type, "
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,BaseMast.Stk_name_1,Stk_Factor,"



        txtSQL = txtSQL & "sum(TranDataD.Dtl_Num)as sumQty,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_Num * BaseMast.Stk_Factor)as sumWeight,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_sum)as sumAmt,"

        If optSelGP.Checked = True Or optSelGMB.Checked = True Then
            txtSQL = txtSQL & "sum((dtl_Pr_Cost * (TranDataD.Dtl_Num * BaseMast.Stk_Factor)))as sumCost, "
            txtSQL = txtSQL & "sum(Dtl_sum-(dtl_Pr_Cost * (TranDataD.Dtl_Num * BaseMast.Stk_Factor)))as sumProfit "

        Else 'If optSelTT.Checked = True Then
            txtSQL = txtSQL & "sum((dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumCost, "
            txtSQL = txtSQL & "sum(Dtl_sum-(dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumProfit "


        End If


        txtSQL = txtSQL & "From TranDataD "
        txtSQL = txtSQL & "left Join TranDataH "
        txtSQL = txtSQL & "On TranDataD.Dtl_Type=TranDataH.Trh_Type "
        txtSQL = txtSQL & "And TranDataD.Dtl_No=TranDataH.Trh_No "
        txtSQL = txtSQL & "left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "

        txtSQL = txtSQL & "Where dtl_type='S' "
        txtSQL = txtSQL & "And  not(Trh_NoType='X') And not(Trh_NoType='P') "
        'txtSQL = txtSQL & "And (dtl_date '" & txtDate01.Text & "') "
        Dim dataDateS As Integer = Now.Day 'Microsoft.VisualBasic.Day(Now).ToString
        Dim dataMonthS As Integer = Now.Month
        Dim dataYearS As Integer = Now.Year

        Dim dataDateE As Integer = 1
        'Dim dataMonthE As Integer
        'Dim dataYearE As Integer


        '  ทำวันที่ปัจจุบันให้เป็นวันที่ 1 ก่อน
        '  คำนวนวันที่ 1 ไปจนถึงจำนวนเดือนที่ต้องการ จะรายงาน เช่น 3 เดือน

        'If opt1Month.Checked = True Then

        '    txtSQL = txtSQL & "And month(TranDataH.trh_Date)=month('" & Format(Now, "yyyy/MM/dd") & "') "
        '    txtSQL = txtSQL & "And year(TranDataH.trh_Date)=year('" & Format(Now, "yyyy/MM/dd") & "')-543 "

        'ElseIf opt3Month.Checked = True Then

        '    txtSQL = txtSQL & "And TranDataH.trh_Date>='" & Format(DateAdd(DateInterval.Month, -3, DateAdd(DateInterval.Year, -543, Now)), "yyyy/MM/dd") & "' "

        '    ' txtSQL = txtSQL & "And year(TranDataH.trh_Date)=year('" & Format(Now, "yyyy/MM/dd") & "')-543 "
        'ElseIf opt6Month.Checked = True Then
        '    txtSQL = txtSQL & "And month(TranDataH.trh_Date)>=month('" & Format(Now, "yyyy/MM/dd") & "')-5 "

        '    txtSQL = txtSQL & "And year(TranDataH.trh_Date)=year('" & Format(Now, "yyyy/MM/dd") & "')-543 "

        'Else

        txtSQL = txtSQL & "And dtl_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And dtl_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "


        'End If

        If optStk.Checked = True Then
            txtSQL = txtSQL & "And Dtl_idTrade='" & lbStkCode.Text & "' "
        Else

        End If

        If chkPriceZero.Checked = True Then
            ' txtSQL = txtSQL & "And not(Trh_NoType='X') "
            txtSQL = txtSQL & "And (dtl_sum > 0 and dtl_price > 0 ) "

        Else
            txtSQL = txtSQL & ""
        End If


        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='02' "
        ElseIf optSelPD.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='03' "
        ElseIf optSelGMB.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='04' "
        ElseIf optSelAll.Checked = True Then
            txtSQL = txtSQL & "And (Stk_Prod='01'or Stk_Prod='02') "
        End If
        txtSQL = txtSQL & ""
        txtSQL = txtSQL & "Group by TranDataD.dtl_type,TranDataD.Dtl_idTrade,BaseMast.Stk_name_1,Stk_Factor "

        txtSQL = txtSQL & "Order by "

        If optUnit.Checked = True Then
            txtSQL = txtSQL & "sumQty desc"
        ElseIf optWeight.Checked = True Then
            txtSQL = txtSQL & "sumWeight desc"
        ElseIf optAmt.Checked = True Then
            txtSQL = txtSQL & "sumAmt desc"
        ElseIf optProfit.Checked = True Then
            txtSQL = txtSQL & "sumProfit desc"
        ElseIf optSelName.Checked = True Then
            txtSQL = txtSQL & "Stk_Name_1 "
        End If

        Return txtSQL


    End Function


    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click


        Me.Hide()

    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs)
        txtDate02.Value = txtDate01.Value

    End Sub

    Private Sub lbFindStk_Click(sender As Object, e As EventArgs) Handles lbFindStk.Click

        selStkID = ""
        Me.BackColor = Color.Gray
        frmFindStk.ShowDialog()
        lbStkCode.Text = selStkID
        Me.BackColor = Color.WhiteSmoke
        If Len(selStkID) > 0 Then
            optStk.Checked = True
            lbStkName.Text = dbTools.getStkName(selStkID)
            optStk.Checked = True
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub lsvShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvShow.SelectedIndexChanged

    End Sub

    Private Sub lsvShow_DoubleClick(sender As Object, e As EventArgs) Handles lsvShow.DoubleClick

        'Dim frmStkAnaly As New frmStkAnaly
        'frmStkAnaly.ShowDialog()


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

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs)

    End Sub
End Class
