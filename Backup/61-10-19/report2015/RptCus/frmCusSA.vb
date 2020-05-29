Public Class frmCusSA
    Dim chkData As Boolean = False
    Dim chkProfit As Boolean = False
    Dim lvi As ListViewItem
    Dim subDa As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet
    Dim chkLoad As Boolean = False

    Sub addItemSale2()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As DataSet = New DataSet


        txtSQL = "SELECT * "
        txtSQL = txtSQL & "FROM  SalesMan "
        txtSQL = txtSQL & "where SL_Off='0' "
        'If selGrpSale = "G99" Then

        'Else
        '    txtSQL = txtSQL & "Where SL_Grp='" & selGrpSale & "' "
        'End If

        txtSQL = txtSQL & " Order by sl_id "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SLdata2")

        With cboSales
            .DataSource = subDS.Tables("SLdata2")
            .DisplayMember = "SL_Name"
            .ValueMember = "SL_ID"
        End With

        subDA = Nothing
        subDS = Nothing

    End Sub



    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Hide()

    End Sub

    Private Sub frmCusSA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbStrConnect.Text = strConn

        Call formatGrid2()
        Call addItemSale2()
        chkLoad = True

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

    'Function genSQLdb() As String
    '    txtSQL = "Select Ar_Cus_ID,Ar_Name,"
    '    txtSQL = txtSQL & "sum(Trh_Amt-Trh_Disc_Amt)as Trh_Amt,sum(Trh_W_Sum)as Trh_W_Sum,"
    '    txtSQL = txtSQL & "sum(Trh_Amt-Trh_Disc_Amt-Trh_Cost_Amt)as Profit "

    '    txtSQL = txtSQL & "From ArFile "
    '    txtSQL = txtSQL & "Left Join TranDataH "
    '    txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

    '    txtSQL = txtSQL & "Where "
    '    txtSQL = txtSQL & "(Trh_Type='S' "
    '    txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
    '    txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
    '    txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "
    '    txtSQL = txtSQL & "    )"
    '    If optSelAR.Checked = True Then

    '        If chkGrpCus.Checked = True Then
    '            txtSQL = txtSQL & "And ArFile.Ar_Grp_ID='" & lbCusCode.Text & "'  "
    '        Else
    '            txtSQL = txtSQL & "And TranDataH.Trh_Cus='" & lbCusCode.Text & "'  "
    '        End If

    '    Else
    '        txtSQL = txtSQL & ""

    '    End If

    '    If chkPriceZero.Checked = True Then
    '        txtSQL = txtSQL & "And (Trh_Amt > 0  ) "

    '    End If

    '    txtSQL = txtSQL & "And Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
    '    txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "

    '    If optSelGP.Checked = True Then
    '        txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
    '    ElseIf optSelTT.Checked = True Then
    '        txtSQL = txtSQL & "And Trh_ProD_Sales='02' "
    '    ElseIf optSelPD.Checked = True Then
    '        txtSQL = txtSQL & "And Trh_ProD_Sales='03' "
    '    ElseIf optSelGMB.Checked = True Then
    '        txtSQL = txtSQL & "And Trh_ProD_Sales='04' "
    '    ElseIf optSelNPD.Checked = True Then
    '        txtSQL = txtSQL & "And Trh_ProD_Sales='05' "
    '    ElseIf optSelGPTT.Checked = True Then
    '        txtSQL = txtSQL & "And (Trh_ProD_Sales='01' or Trh_ProD_Sales='02' or Trh_ProD_Sales='05')"
    '    End If

    '    txtSQL = txtSQL & "Group by Ar_Cus_ID,Ar_Name "
    '    Return txtSQL

    'End Function
    Function genSQLdb() As String

        txtSQL = "Select TranDataD.Dtl_Type, "
        If chkDocID.Checked = True Then
            txtSQL = txtSQL & "TranDataH.Trh_No,"
        End If
        txtSQL = txtSQL & "TranDataH.Trh_Cus,ArFile.Ar_Grp_ID,ArFile.Ar_Name,AR_Sales_Target,"
        If chkNoSelDetail.Checked = True Then

        Else
            txtSQL = txtSQL & "TranDataD.Dtl_idTrade,BaseMast.Stk_name_1,Stk_Factor,"
        End If


        txtSQL = txtSQL & "sum(TranDataD.Dtl_Num)as sumQty,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_Num * BaseMast.Stk_Factor)as sumWeight,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_sum)as sumAmt,"

        If optSelGP.Checked = True Or optSelGMB.Checked = True Then

            txtSQL = txtSQL & "sum(TranDataD.dtl_Cost_Sum)as sumCost,  "
            txtSQL = txtSQL & "sum(Dtl_sum-(dtl_Pr_Cost * (TranDataD.Dtl_Num * BaseMast.Stk_Factor)))as sumProfit "

        ElseIf optSelTT.Checked = True Then

            txtSQL = txtSQL & "sum((dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumCost, "
            txtSQL = txtSQL & "sum(Dtl_sum-(dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumProfit "

        ElseIf optSelPD.Checked = True Then

            txtSQL = txtSQL & "sum((dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumCost, "
            txtSQL = txtSQL & "sum(Dtl_sum-(dtl_Pr_Cost * (TranDataD.Dtl_Num )))as sumProfit "
        Else

            txtSQL = txtSQL & "sum(TranDataD.dtl_Cost_Sum)as sumCost "

        End If

        txtSQL = txtSQL & "From TranDataD left Join TranDataH "
        txtSQL = txtSQL & "On TranDataD.Dtl_Type=TranDataH.Trh_Type "
        txtSQL = txtSQL & "And TranDataD.Dtl_No=TranDataH.Trh_No "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On TranDataH.Trh_Cus=ArFile.Ar_cus_ID "
        txtSQL = txtSQL & "left Join BaseMast "
        txtSQL = txtSQL & "On TranDataD.Dtl_idTrade=BaseMast.Stk_Code "

        txtSQL = txtSQL & "Where dtl_type='S' "
        'txtSQL = txtSQL & "And  not(Trh_NoType='X') And not(Trh_NoType='P') "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "

        'txtSQL = txtSQL & "And (dtl_date '" & txtDate01.Text & "') "

        txtSQL = txtSQL & "And dtl_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
        txtSQL = txtSQL & "And dtl_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "' "

        If optSelStk.Checked = True Then
            txtSQL = txtSQL & "And Dtl_idTrade='" & lbStkCode.Text & "' "

        End If
        If optSales.Checked = True Then
            txtSQL = txtSQL & "And Ar_Sales='" & cboSales.SelectedValue & "' "
        End If

        If chkPriceZero.Checked = True Then
            txtSQL = txtSQL & "And (dtl_sum > 0 and dtl_price > 0 ) "
        Else
            txtSQL = txtSQL & ""
        End If


        If optSelAR.Checked = True Then

            If chkGrpCus.Checked = True Then
                txtSQL = txtSQL & "And ArFile.Ar_Grp_ID='" & lbCusCode.Text & "'  "
            Else
                txtSQL = txtSQL & "And TranDataH.Trh_Cus='" & lbCusCode.Text & "'  "
            End If

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
        ElseIf optSelNPD.Checked = True Then
            txtSQL = txtSQL & "And Stk_Prod='05' "
        ElseIf optSelGPTT.Checked = True Then
            txtSQL = txtSQL & "And (Stk_Prod='01' or Stk_Prod='02' or Stk_Prod='05')"
        End If

        txtSQL = txtSQL & ""
        txtSQL = txtSQL & "Group by TranDataD.dtl_type,"
        If chkDocID.Checked = True Then
            txtSQL = txtSQL & "TranDataH.Trh_No,"
        End If
        txtSQL = txtSQL & "TranDataH.Trh_Cus,ArFile.Ar_Grp_ID,ArFile.Ar_Name,AR_Sales_Target "

        If chkNoSelDetail.Checked = True Then
        Else
            txtSQL = txtSQL & ",TranDataD.Dtl_idTrade,BaseMast.Stk_name_1,Stk_Factor "
        End If

        If optUnit.Checked = True Then
            txtSQL = txtSQL & "Order by "
            txtSQL = txtSQL & "sumQty desc"
        ElseIf optWeight.Checked = True Then
            txtSQL = txtSQL & "Order by "
            txtSQL = txtSQL & "sumWeight desc"
        ElseIf optAmt.Checked = True Then
            txtSQL = txtSQL & "Order by "
            txtSQL = txtSQL & "sumAmt desc"
        ElseIf optProfit.Checked = True Then
            If optSelGPTT.Checked = True Then
                MsgBox("option GP & TT ไม่สามารถลำดับตาม กำไรได้", vbOKOnly, "แจ้งเตือน")

            Else
                txtSQL = txtSQL & "Order by "
                txtSQL = txtSQL & "sumProfit desc"
            End If

        ElseIf optSelName.Checked = True Then
            txtSQL = txtSQL & "Order by "
            txtSQL = txtSQL & "Stk_Name_1 "
        ElseIf optSelCusName.Checked = True Then
            txtSQL = txtSQL & "Order by "
            txtSQL = txtSQL & "Ar_Name "
        End If

        Return txtSQL


    End Function

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Dim frmFindCus As New searchCus
        frmFindCus.ShowDialog()
        optSelAR.Checked = True

        lbCusCode.Text = selCusID
        If selCusID = "" Then
            MsgBox("ไม่พบข้อมูล ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub
        End If
        lbCusName.Text = getCusName(selCusID)
        optSelAR.Checked = True


        If chkLoad = True Then


            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If

    End Sub

    Private Sub lbFindStk_Click(sender As Object, e As EventArgs) Handles lbFindStk.Click
        Dim frmFindStk As New frmFindStk
        frmFindStk.ShowDialog()
        lbStkCode.Text = selStkID
        lbStkName.Text = getStkName(selStkID)
        optSelStk.Checked = True


        If chkLoad = True Then


            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If


    End Sub

    Private Sub lbStkName_Click(sender As Object, e As EventArgs) Handles lbStkName.Click

    End Sub

    Function getSQLPending(arCode As String) As String

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME,"


        txtSQL = txtSQL & "sum(TranDataD.Dtl_num-TranDataD.Dtl_num_2) as Pending, "
        txtSQL = txtSQL & "sum(TranDataD.Dtl_price * (TranDataD.Dtl_num-TranDataD.Dtl_num_2))as sumAmt,"
        txtSQL = txtSQL & "sum((TranDataD.Dtl_num-TranDataD.Dtl_num_2)*Stk_Factor) as QtyW "

        txtSQL = txtSQL & "FROM  TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On TranDataH.Trh_type=Dtl_type "
        txtSQL = txtSQL & "And TranDataH.Trh_No=Dtl_No "

        txtSQL = txtSQL & " LEFT  JOIN  BaseMast "
        txtSQL = txtSQL & "ON TranDataD.Dtl_idtrade = BaseMast.Stk_Code "

        txtSQL = txtSQL & "LEFT  JOIN ARFILE "
        txtSQL = txtSQL & "ON TranDataD.Dtl_idcus = ARFILE.AR_CUS_ID "
        txtSQL = txtSQL & "Left Join SalesMan "
        txtSQL = txtSQL & "On SL_ID=Ar_Sales "

        txtSQL = txtSQL & "WHERE (TranDataD.Dtl_type = 'B') "
        txtSQL = txtSQL & "AND (ARFILE.AR_TYPE ='AR') "
        txtSQL = txtSQL & "And not(Stk_Prod='09') "
        txtSQL = txtSQL & "and trandatad.dtl_idcus='" & arCode & "' "
        txtSQL = txtSQL & "and (trandatad.dtl_num-trandatad.dtl_num_2)>0 "


        txtSQL = txtSQL & "Group By "
        txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME "
        txtSQL = txtSQL & "Order by ARFILE.AR_NAME,QtyW desc "

        Return txtSQL

    End Function

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        If chkLoad = True Then
            'lsvShow.Items.Clear()
            lsvShow.Clear()
            If chkNoSelDetail.Checked = True Then
                Call formatGrid2()
            Else
                Call formatGrid()
            End If

            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If


    End Sub

    Sub colorList(chkRow As Boolean)


        If chkProfit = True Then

            ' lvi.BackColor = System.Drawing.Color.GreenYellow
            If chkRow = False Then
                lvi.BackColor = System.Drawing.Color.Honeydew 'PowderBlue
                lvi.ForeColor = System.Drawing.Color.Black '
            Else
                lvi.BackColor = System.Drawing.Color.PaleGoldenrod 'YellowGreen
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

            'dim itemQ = getDocItem(strDocNo, dtlType)
            'amtDisc = getTrhDisc(strDocNo, dtlType)  ' ส่วนลดหัวบิล

            For iRow = 0 To .Rows.Count - 1
                Dim ArName As String = .Rows(iRow).Item("Ar_Name")
                Dim ArSalesTarget As Double = 0
                Dim stkCode As String = "" '.Rows(iRow).Item("Dtl_idTrade")
                Dim strStkName As String = "" '.Rows(iRow).Item("Stk_Name_1")

                If chkNoSelDetail.Checked = True Then
                    stkCode = ""
                    strStkName = ""

                Else
                    stkCode = .Rows(iRow).Item("Dtl_idTrade")
                    strStkName = .Rows(iRow).Item("Stk_Name_1")

                End If
                If IsDBNull(.Rows(iRow).Item("Ar_Sales_Target")) Then
                    ArSalesTarget = 0
                Else
                    ArSalesTarget = .Rows(iRow).Item("Ar_Sales_Target")
                End If
                Dim strNumber As Integer = iRow + 1

                Dim strQty As Double = .Rows(iRow).Item("sumQty")
                Dim strWeight As Double = .Rows(iRow).Item("sumWeight")

                Dim date01 As Date = (Year(txtDate01.Value) & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value))

                'Dim Dtl_Cost_PR As Double = DBtools.getCostByStk(stkCode, Format(date01, "yyyy-MM-dd"), "", 0)
                'strCost = Dtl_Cost_PR
                Dim strCost As Double = 0
                Dim strSumCost As Double = 0

                Dim strAmt As Double = .Rows(iRow).Item("sumAmt")
                Dim dblCost As Double = .Rows(iRow).Item("sumCost")

                If optSelGPTT.Checked = True Then
                    ' ต้นทุน
                    strCost = .Rows(iRow).Item("sumCost") / strQty
                    strSumCost = strCost * strQty

                    'กำไร

                Else
                    strCost = dblCost / strWeight
                    strSumCost = strCost * strWeight
                    'If dbTools.getCostType(stkCode) = 0 Then

                    'Else
                    '    strCost = .Rows(iRow).Item("sumCost") / strQty
                    '    strSumCost = strCost * strQty
                    'End If

                End If

                Dim strProfit As Double = strAmt - strSumCost
                'Dim strProfitKg As Double = (strProfit / strWeight)

                If strProfit > 0 Then
                    chkProfit = True
                Else
                    chkProfit = False
                End If
                Dim ratioProfit As Double = 0
                ratioProfit = (strProfit / strSumCost) * 100

                Dim strPrice As Double = 0

                If dbTools.getCostType(stkCode) = 0 Then
                    strPrice = .Rows(iRow).Item("sumAmt") / strWeight

                Else
                    strPrice = .Rows(iRow).Item("sumAmt") / .Rows(iRow).Item("sumQty")

                End If

                anyData = New String() {iRow.ToString("#,##0"), ArName, ArSalesTarget.ToString("#,##0.00"), strStkName,
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

    Private Sub opt1Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt1Month.CheckedChanged

        txtDate01.Value = Now
        getDateAffter()
        If chkLoad = True Then


            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If

    End Sub

    Private Sub opt3Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt3Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        If chkLoad = True Then


            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If

    End Sub

    Private Sub opt6Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt6Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()


    End Sub

    Private Sub opt12Month_CheckedChanged(sender As Object, e As EventArgs) Handles opt12Month.CheckedChanged
        txtDate01.Value = Now
        getDateAffter()
        If chkLoad = True Then

            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If

    End Sub

    Private Sub optSelDay_CheckedChanged(sender As Object, e As EventArgs) Handles optSelDay.CheckedChanged
        txtDate01.Value = Now
        lbDate1.Text = txtDate01.Value

        txtDate02.Value = Now
        lbDate2.Text = txtDate02.Value

        If chkLoad = True Then

            'lsvShow.Items.Clear()
            lsvShow.Clear()
            Call formatGrid()
            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()
        End If

    End Sub

    Private Sub chkNoSelDetail_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoSelDetail.CheckedChanged
        If chkNoSelDetail.Checked = True Then
            lsvShow.Clear()
            chkDocID.Checked = False
            chkDocID.Visible = False
            Call formatGrid2()
        Else
            lsvShow.Clear()
            chkDocID.Checked = False
            chkDocID.Visible = False
            Call formatGrid()
        End If

        If chkLoad = True Then

            'lsvShow.Items.Clear()


            txtSQL = genSQLdb()
            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkData = True Then
                subDS.Tables("Command").Clear()
                chkData = False
            End If

            subDa.Fill(subDS, "Command")
            chkData = True
            Call getItemDetail()

        End If
    End Sub
    Sub formatGrid()


        lsvShow.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ชื่อลูกค้า", 200, HorizontalAlignment.Left)
        lsvShow.Columns.Add("Target ขาย", 1, HorizontalAlignment.Left)
        If chkNoSelDetail.Checked = True Then
            lsvShow.Columns.Add("รายการ", 1, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("รายการ", 300, HorizontalAlignment.Left)
        End If

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
    Sub formatGrid2()


        lsvShow.Columns.Add("#", 50, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ชื่อลูกค้า", 200, HorizontalAlignment.Left)
        lsvShow.Columns.Add("Target ขาย", 150, HorizontalAlignment.Right)
        lsvShow.Columns.Add("รายการ", 1, HorizontalAlignment.Left)

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
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        'MsgBox("coming soon", MsgBoxStyle.Critical, "แจ้งเตือน")
        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim rw As Integer = 0
        Dim countRow As Integer = 0
        Dim rowExcel As Integer = 6 '  เริ่ม รายการบรรทัดที่ 9
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0

        ' fileName = CurDir() & "\report\prtSAcusgrp01.xls"

        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\prtSAcusgrp01.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet

            If IsDBNull(subDS.Tables("Command")) Then
                Exit Sub
            Else
                rw = subDS.Tables("Command").Rows.Count - 1
            End If
            .Range("H2").Value = Now
            For countRow = 0 To rw
                '            '  ============  เพิ่มบรรทัด
                .Range("A" & (rowExcel + 2) & ":" & "AD" & (rowExcel + 2)).Insert()

                '            '  ============  เพิ่มบรรทัด

                .Range("B" & rowExcel).Select()
                .Range("B" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("Ar_Name")
                If chkNoSelDetail.Checked = False Then
                    '.Range("C" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumQty")
                    '.Range("D" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumWeight")
                    '.Range("E" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    '.Range("F" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost")
                    '.Range("G" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    '.Range("H" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt")
                    '.Range("I" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumCost")
                    '.Range("j" & rowExcel).Value = 100 * ((subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow).Item("sumCost")) / subDS.Tables("Command").Rows(countRow).Item("sumCost"))
                    .Range("C" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("Stk_Name_1")
                    .Range("D" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumQty")
                    .Range("E" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumWeight")
                    .Range("F" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    .Range("G" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost")
                    .Range("H" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    .Range("I" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt")
                    .Range("J" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumCost")
                    .Range("K" & rowExcel).Value = 100 * ((subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow).Item("sumCost")) / subDS.Tables("Command").Rows(countRow).Item("sumCost"))

                Else

                    .Range("C" & rowExcel).Value = "" 'subDS.Tables("Command").Rows(countRow).Item("Stk_Name_1")
                    .Range("D" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumQty")
                    .Range("E" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumWeight")
                    .Range("F" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    .Range("G" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumCost")
                    .Range("H" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") / subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumWeight")
                    .Range("I" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt")
                    .Range("J" & rowExcel).Value = subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow - bufferExcel).Item("sumCost")
                    .Range("K" & rowExcel).Value = 100 * ((subDS.Tables("Command").Rows(countRow).Item("sumAmt") - subDS.Tables("Command").Rows(countRow).Item("sumCost")) / subDS.Tables("Command").Rows(countRow).Item("sumCost"))

                End If

                '=(I6/F6)*100

                ' strProfit

                rowExcel = rowExcel + 1

            Next

            .Range("B" & rowExcel + 2).Value = "=SUM(B6:B" & rowExcel & ")"
            .Range("C" & rowExcel + 2).Value = "=SUM(C6:C" & rowExcel & ")"
            .Range("D" & rowExcel + 2).Value = "=SUM(D6:D" & rowExcel & ")"
            .Range("E" & rowExcel + 2).Value = "=SUM(E6:E" & rowExcel & ")"
            .Range("F" & rowExcel + 2).Value = "=SUM(F6:F" & rowExcel & ")"
            .Range("G" & rowExcel + 2).Value = "=SUM(G6:G" & rowExcel & ")"
            .Range("H" & rowExcel + 2).Value = "=SUM(H6:H" & rowExcel & ")"
            .Range("I" & rowExcel + 2).Value = "=SUM(I6:I" & rowExcel & ")"
            .Range("J" & rowExcel + 2).Value = "=SUM(J6:J" & rowExcel & ")"



        End With

    End Sub


    Private Sub cboSales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSales.SelectedIndexChanged




        'If chkLoad = True Then
        '    optSales.Checked = True

        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optWeight_CheckedChanged(sender As Object, e As EventArgs) Handles optWeight.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optUnit_CheckedChanged(sender As Object, e As EventArgs) Handles optUnit.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optAmt_CheckedChanged(sender As Object, e As EventArgs) Handles optAmt.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optProfit_CheckedChanged(sender As Object, e As EventArgs) Handles optProfit.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optSelName_CheckedChanged(sender As Object, e As EventArgs) Handles optSelName.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub optSelCusName_CheckedChanged(sender As Object, e As EventArgs) Handles optSelCusName.CheckedChanged


        'If chkLoad = True Then


        '    'lsvShow.Items.Clear()
        '    lsvShow.Clear()
        '    Call formatGrid()
        '    txtSQL = genSQLdb()
        '    subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        '    If chkData = True Then
        '        subDS.Tables("Command").Clear()
        '        chkData = False
        '    End If

        '    subDa.Fill(subDS, "Command")
        '    chkData = True
        '    Call getItemDetail()
        'End If
    End Sub

    Private Sub chkDocID_CheckedChanged(sender As Object, e As EventArgs) Handles chkDocID.CheckedChanged

    End Sub

    Private Sub optSelPD_CheckedChanged(sender As Object, e As EventArgs) Handles optSelPD.CheckedChanged

    End Sub

    Private Sub txtDate01_ValueChanged(sender As Object, e As EventArgs) Handles txtDate01.ValueChanged
        txtDate02.Value = txtDate01.Value

    End Sub

    Private Sub chkGrpCus_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrpCus.CheckedChanged

    End Sub

    Private Sub optSelAR_CheckedChanged(sender As Object, e As EventArgs) Handles optSelAR.CheckedChanged
        If optSelAR.Checked = True Then
            chkGrpCus.Enabled = True
            chkGrpCus.BackColor = Color.DodgerBlue
        Else
            chkGrpCus.Enabled = False
            chkGrpCus.BackColor = Color.LightBlue
        End If
    End Sub
End Class
