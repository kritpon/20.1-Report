
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmSalesDetl
    Dim frmLoad As Boolean = False
    Dim chkSelOpt As Boolean = False
    Dim strSelOpt As String = ""

    Sub formatGrid()

        Dim strHead01 As String
        If optSum.Checked = True Then
            strHead01 = "กำไรรวม" & " " & Format(Now(), "MM") & " เดือน"
        ElseIf optAVG_Now.Checked = True Then

            strHead01 = "กำไรรวม" & " " & Format(DateAdd(DateInterval.Month, -1, Now()), "MM") & " เดือน"
        Else

            strHead01 = "กำไรรวม" & "เดือน " & Format(Now(), "MM")

        End If


        lsvARdetail.Columns.Add("#", 40, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ชื่อลูกค้า", 220, HorizontalAlignment.Left)
        If optGrade.Checked = True Then
            lsvARdetail.Columns.Add("-เกรด-", 80, HorizontalAlignment.Center)
        Else
            lsvARdetail.Columns.Add("-เกรด-", 1, HorizontalAlignment.Center)
        End If
        If optSegment.Checked = True Then
            lsvARdetail.Columns.Add("Segment", 100, HorizontalAlignment.Left)

        Else
            lsvARdetail.Columns.Add("Segment", 1, HorizontalAlignment.Left)
        End If
        lsvARdetail.Columns.Add("เขต", 100, HorizontalAlignment.Left)
        lsvARdetail.Columns.Add("จังหวัด", 90, HorizontalAlignment.Left)
        'If optSector.Checked = True Then

        'Else
        '    lsvARdetail.Columns.Add("เขต", 1, HorizontalAlignment.Left)
        '    lsvARdetail.Columns.Add("จังหวัด", 1, HorizontalAlignment.Left)
        'End If


        lsvARdetail.Columns.Add("ยอดกำไรปี 59", 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("Target" & Year(Now), 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add(strHead01, 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("%", 90, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ยอดขาย" & Year(Now) - 2, 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("Target" & Year(Now), 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ยอดขาย" & Year(Now), 120, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("%", 90, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("น้ำหนักขาย" & Year(Now), 110, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("ราคา/kg", 90, HorizontalAlignment.Right)
        'lsvARdetail.Columns.Add("ราคาขาย/Kg(ปัจจุบัน)", 80, HorizontalAlignment.Right)
        lsvARdetail.Columns.Add("วัน-ขายล่าสุด", 200, HorizontalAlignment.Right)


        lsvARdetail.Columns.Add("id", 100, HorizontalAlignment.Right)

        lsvARdetail.View = View.Details
        lsvARdetail.GridLines = True
        'chkCol = True

    End Sub

    Private Sub frmSalesDetl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLoad = True
        selSale = selCS

        If selOptSL = 0 Then
            lbSalesName.Text = cusTools.getCSName(selCS)
            lbSalesCode.Text = selCS
        Else
            lbSalesName.Text = cusTools.getSaleName(selCS)
            lbSalesCode.Text = selCS
        End If


        If frmLoad = True Then
            'grpBoxNow.Text = ""

            'lbSalesName.Text = getSaleName(selSale)
            lbKPI.Text = Format(getSaleKPI(selSale, selOptSL) * 12, "#,##0.00")
            optAVG_Now.Text = "ยอดเฉลี่ย" & " " & Format(DateAdd(DateInterval.Month, -1, Now()), "MM") & " เดือน"
            Call runReport()
        End If

    End Sub
    Function getPendingOrder() As String

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

        'txtSQL = txtSQL & "Left Join SalesMan "
        'txtSQL = txtSQL & "On SL_ID=Ar_Sales "

        txtSQL = txtSQL & "WHERE (TranDataD.Dtl_type = 'B') "
        txtSQL = txtSQL & "AND (ARFILE.AR_TYPE ='AR') "
        txtSQL = txtSQL & "And not(Stk_Prod='09') "

        If selOptSL = 0 Then
            txtSQL = txtSQL & "And  Ar_CS='" & selSale & "' "
        Else
            txtSQL = txtSQL & "And  Ar_Sales='" & selSale & "' "
        End If


        txtSQL = txtSQL & "and (trandatad.dtl_num-trandatad.dtl_num_2)>0 "
        txtSQL = txtSQL & "Group By "
        txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME "

        txtSQL = txtSQL & "Order by ARFILE.AR_NAME,QtyW desc "

        Return txtSQL

    End Function
    Function getSQL() As String

        txtSQL = "Select Grd_C_Name,Grp_Name,"
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "(AR_Grp_id)as Ar_Cus_ID,Ar_Grp_ID,Ar_Name,AR_LastSales_Date,"
        Else
            txtSQL = txtSQL & "(Ar_Cus_ID)as Ar_Cus_ID,Ar_Grp_ID,Ar_Name,AR_LastSales_Date,"
        End If


        txtSQL = txtSQL & "Country_Name,Amphoe_Name,isnull(PrKg.Pr_Kg,0)as Pr_Kg,"
        txtSQL = txtSQL & "Trh_D_Amt59,Profit59,"
        If optSum.Checked = True Then

            txtSQL = txtSQL & "Ar_Target_Year,"
            txtSQL = txtSQL & "Ar_Target,"
            txtSQL = txtSQL & "Ar_Sales_Target,"
            txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,"
            txtSQL = txtSQL & "Sum(Trh_w_Sum)as Trh_W_Sum,"
            txtSQL = txtSQL & "sum(Profit)as Profit "
        ElseIf optAVG_Now.Checked = True Then


            txtSQL = txtSQL & "((Ar_Target_Year/12)*(Month(GetDate())-1))as Ar_Target_Year,"
            txtSQL = txtSQL & "((Ar_Target/12)*(Month(GetDate())-1))as Ar_Target,"
            txtSQL = txtSQL & "((Ar_Sales_Target/12)*(Month(GetDate())-1)) as Ar_Sales_Target,"
            txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,"
            txtSQL = txtSQL & "Sum(Trh_w_Sum)as Trh_W_Sum,"
            txtSQL = txtSQL & "sum(Profit)as Profit "

        ElseIf optMonthNow.Checked = True Then

            txtSQL = txtSQL & "(Ar_Target_Year/12)as Ar_Target_Year,"
            txtSQL = txtSQL & "(Ar_Target/12)as Ar_Target,"
            txtSQL = txtSQL & "(Ar_Sales_Target/12)as Ar_Sales_Target,"

            txtSQL = txtSQL & "sum(Trh_D_Amt)as Trh_D_Amt,"
            txtSQL = txtSQL & "Sum(Trh_w_Sum)as Trh_W_Sum,"
            txtSQL = txtSQL & "sum(Profit)as Profit "

        End If

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join ArTarget "
        txtSQL = txtSQL & "On Ar_Cus_ID=Ar_Code "

        txtSQL = txtSQL & "Left Join AmphoeMast "
        txtSQL = txtSQL & "On Ar_Amphoe_code=Amphoe_Code "
        txtSQL = txtSQL & "Left Join MktCusGrade "
        txtSQL = txtSQL & "On Ar_Grade=GRD_C_ID "
        txtSQL = txtSQL & "left Join MktSegment "
        txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "
        '==================================================================================
        txtSQL = txtSQL & "left Join ("
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Select Ar_Grp_ID as Trh_Cus,"
        Else
            txtSQL = txtSQL & "Select Trh_Cus as Trh_Cus,"
        End If
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Disc_Amt)as Trh_D_Amt,sum(Trh_W_Sum)as Trh_W_Sum,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Disc_Amt-Trh_Cost_Amt)as Profit "

        txtSQL = txtSQL & "From TranDataH "
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Left Join ArFile "
            txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        Else

        End If

        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "
        txtSQL = txtSQL & "    )"
        txtSQL = txtSQL & "And ("


        If optSum.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)=year(GETDATE()))  "
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate()))) "
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)=year(GETDATE())) "
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1))   "
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)=year(GETDATE())) "
            txtSQL = txtSQL & "And  ( Month(Trh_Date)=month(GetDate()) )   "
        End If

        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And (Trh_ProD_Sales='02' or Trh_ProD_Sales='05')"
        Else

        End If

        'txtSQL = txtSQL & "Group by Ar_Grp_ID "
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Group by Ar_Grp_ID "
        Else
            txtSQL = txtSQL & "Group by Trh_Cus "
        End If
        txtSQL = txtSQL & ") TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "
        '==================================================================================
        '==================================================================================
        txtSQL = txtSQL & "left Join ("


        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Select (Ar_Grp_ID) as TrhCus59,"
        Else
            txtSQL = txtSQL & "Select (Trh_Cus) as TrhCus59,"
        End If

        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Disc_Amt)as Trh_D_Amt59,sum(Trh_W_Sum)as Trh_W_Sum59,sum((Trh_D_Amt-Trh_Disc_Amt)-Trh_Cost_Amt)as Profit59 "

        txtSQL = txtSQL & "From TranDataH "
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Left Join Arfile "
            txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "
        Else

        End If

        txtSQL = txtSQL & "Where Trh_D_Amt > 0 "
        txtSQL = txtSQL & "And (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "
        txtSQL = txtSQL & "    )"
        txtSQL = txtSQL & "And ("

        If optSum.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)='2017')  " ' อนาคตต้องมาเปลี่ยนให้เป็น  year(Trh_Date)=year(GetDate())-2
        ElseIf optAVG_Now.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)='2017'  " ' อนาคตต้องมาเปลี่ยนให้เป็น  year(Trh_Date)=year(GetDate())-2
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) "
            txtSQL = txtSQL & "And (Month(Trh_Date)<=month(GetDate())-1)) )  "
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "Year(Trh_Date)='2017'  " ' อนาคตต้องมาเปลี่ยนให้เป็น  year(Trh_Date)=year(GetDate())-2
            txtSQL = txtSQL & "And  ( Month(Trh_Date)=month(GetDate()) )  ) "
        End If

        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And (Trh_ProD_Sales='02' or Trh_ProD_Sales='05') "
        Else

        End If

        'txtSQL = txtSQL & "Group by Ar_Grp_ID "
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "Group by Ar_Grp_ID "
        Else
            txtSQL = txtSQL & "Group by Trh_Cus "
        End If
        txtSQL = txtSQL & ") TrH59 "
        txtSQL = txtSQL & "On Ar_Cus_ID=TrH59.TrhCus59 "
        '==================================================================================

        txtSQL = txtSQL & "Left Join ("

        txtSQL = txtSQL & "Select (Ar_Cus_ID)as T_Cus ,"
        txtSQL = txtSQL & "(sum(Trh_D_Amt)/sum(Trh_W_Sum))as Pr_Kg "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "ON Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "Where Trh_D_Amt >0 "
        txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
        'txtSQL = txtSQL & "And  (Month(Trh_Date)=month(GetDate()))     "  ' เดือน
        txtSQL = txtSQL & "And  (Month(Trh_Date)=month(Ar_LastSales_Date))     "  ' เดือน

        txtSQL = txtSQL & "And Trh_ProD_Sales='01' "  ' เพื่อหาค่าเฉลี่ยของ GP

        txtSQL = txtSQL & "And  (Trh_Type='S' "
        txtSQL = txtSQL & "And (Trh_NoType='V' "
        txtSQL = txtSQL & "Or Trh_NoType='N' "
        txtSQL = txtSQL & "Or Trh_NoType='B' "
        txtSQL = txtSQL & "Or Trh_NoType='M' "
        txtSQL = txtSQL & "Or Trh_NoType='Y' "
        txtSQL = txtSQL & "Or Trh_NoType='Z' "
        txtSQL = txtSQL & ") )"
        txtSQL = txtSQL & "Group by Ar_Cus_ID "


        txtSQL = txtSQL & ") PrKg "
        txtSQL = txtSQL & "On ArFile.Ar_Cus_ID=PrKg.T_Cus "
        '==================================================================================
        txtSQL = txtSQL & "Where AR_Type='AR' "
        If selSale = "" Then
        Else
            If selOptSL = 0 Then
                txtSQL = txtSQL & "And  Ar_CS='" & selSale & "' "
            Else
                txtSQL = txtSQL & "And  Ar_Sales='" & selSale & "' "
            End If
        End If


        If chkSelOpt = True Then
            If optGrade.Checked = True Then
                txtSQL = txtSQL & "And Ar_Grade='" & strSelOpt & " ' "
            Else
                txtSQL = txtSQL & "And Ar_Group='" & strSelOpt & " ' "
            End If
            chkSelOpt = False
        Else

        End If
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "And Ar_Cus_ID=Ar_Grp_Id "
        End If
        If Len(Trim(txtFind.Text)) Then
            txtSQL = txtSQL & "And Ar_Name like '%" & txtFind.Text & "%' "
        End If
        '=================================================================================
        txtSQL = txtSQL & "group by Grd_C_Name,Grp_Name,Country_Name,Amphoe_Name,"
        If optCusGrp.Checked = True Then
            txtSQL = txtSQL & "AR_Grp_id,"
        Else
            txtSQL = txtSQL & "Ar_Cus_ID,Ar_Grp_ID,"
        End If
        txtSQL = txtSQL & "Ar_Name,AR_LastSales_Date,Ar_Target_Year,Ar_Target,Ar_Sales_Target,PrKg.Pr_Kg,TrH59.Trh_D_Amt59,Profit59 "

        '=================================================================================
        If optSector.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Country_Name ASC,Amphoe_Name,Profit DESC"
            Else
                txtSQL = txtSQL & "Order by Country_Name DESC,Amphoe_Name,Profit DESC"
            End If
        ElseIf optTarget.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Ar_Target ASC "
            Else
                txtSQL = txtSQL & "Order by Ar_Target DESC "
            End If
        ElseIf optLastSales.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by AR_LastSales_Date ASC,Profit DESC"
            Else
                txtSQL = txtSQL & "Order by AR_LastSales_Date DESC,Profit DESC"
            End If
        ElseIf optGrade.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Grd_C_Name ASC,Profit DESC"
            Else
                txtSQL = txtSQL & "Order by Grd_C_Name DESC,Profit DESC"
            End If
        ElseIf optSegment.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Grp_Name ASC,Country_Name ASC,Amphoe_Name,Profit DESC"
            Else
                txtSQL = txtSQL & "Order by Grp_Name DESC,Country_Name DESC,Amphoe_Name,Profit DESC"
            End If
        ElseIf optTotalSales.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Trh_D_Amt ASC "
            Else
                txtSQL = txtSQL & "Order by Trh_D_Amt DESC "
            End If
        ElseIf optProfit.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Profit ASC "
            Else
                txtSQL = txtSQL & "Order by Profit DESC "
            End If
        ElseIf optCusName.Checked = True Then
            If optAZ.Checked = True Then
                txtSQL = txtSQL & "Order by Ar_Name ASC "
            Else
                txtSQL = txtSQL & "Order by Ar_Name DESC "
            End If
        End If

        Return txtSQL

    End Function

    Sub runRpt()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim anyData() As String
        Dim lvi As ListViewItem

        'lsvARdetail.Clear()
        'Call formatGrid()
        txtSQL = getSQL()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slDetail")
        Dim arNum As Integer = 0
        Dim arName As String = ""

        Dim arGrade As String = ""
        Dim arSegment As String = ""

        Dim arAmphoe As String = ""
        Dim arCity As String = ""

        Dim arTarget As Double = 0
        Dim arTarget59 As Integer = 0
        Dim arTargetSales As Double = 0
        Dim arSalesTarget As Double = 0
        Dim arSumSales59 As Double = 0
        Dim arProfit As Double = 0
        Dim arAmt As Double = 0
        Dim arSumQtyW As Double = 0
        Dim arPrKg As Double = 0
        Dim arLastSales As String = ""
        Dim chkTarget As Integer = 0

        With subDS.Tables("slDeTail")

            lbKPI.Text = 0
            lbTotalTarget.Text = 0
            lbTotalYear59.Text = 0
            lbTotalProfitNow.Text = 0
            lbTotalTarget2.Text = 0
            lbTotalSales.Text = 0
            lbTotalProfit.Text = 0
            lbTotalQtyW.Text = 0
            lbTotalTargetSL.Text = 0

            Dim chkRow As Integer = 0
            Dim ArCode As String
            '------------------------------------------------
            lsvARdetail.Clear()
            Call formatGrid()
            '------------------------------------------------

            If optAVG_Now.Checked = True Then
                lbKPI.Text = Format(getSaleKPI(selSale, selOptSL) * (Month(Now) - 1), "#,##0.00")
                lbKPI0.Text = lbKPI.Text

                ' grpBoxNow.Text = "ยอดในช่วง " & (Month(Now) - 1) & " เดือน"

            ElseIf optSum.Checked = True Then

                lbKPI.Text = Format(getSaleKPI(selSale, selOptSL) * 12, "#,##0.00")
                lbKPI0.Text = lbKPI.Text

                ' grpBoxNow.Text = "ยอดในช่วง " & (Month(Now)) & " เดือน"

            ElseIf optMonthNow.Checked = True Then
                ' grpBoxNow.Text = " เดือน" & "ยอดในช่วง " & (Month(Now))
            End If

            For i = 0 To subDS.Tables("slDetail").Rows.Count - 1

                arNum = i + 1
                arName = .Rows(i).Item("Ar_Name")
                If IsDBNull(.Rows(i).Item("Grd_C_Name")) Then
                    arGrade = "-"
                Else
                    arGrade = .Rows(i).Item("Grd_C_Name")
                End If


                If IsDBNull(.Rows(i).Item("Grp_Name")) Then
                    arSegment = "-"
                Else
                    arSegment = .Rows(i).Item("Grp_Name")
                End If
                '
                If IsDBNull(.Rows(i).Item("Country_Name")) Then
                    arAmphoe = ""
                    arCity = ""
                Else
                    arAmphoe = .Rows(i).Item("Amphoe_Name")
                    arCity = .Rows(i).Item("Country_Name")
                End If

                If IsDBNull(.Rows(i).Item("Profit59")) Then
                    arTarget59 = 0
                Else
                    arTarget59 = .Rows(i).Item("Profit59") '.Rows(i).Item("Ar_Target_Year")
                    lbTotalYear59.Text = Format(arTarget59 + lbTotalYear59.Text, "#,##0.00")
                End If

                If IsDBNull(.Rows(i).Item("Trh_D_Amt59")) Then
                    arSumSales59 = 0
                Else
                    arSumSales59 = .Rows(i).Item("Trh_D_Amt59")

                End If


                If IsDBNull(.Rows(i).Item("Ar_Target")) Then
                    arTarget = 0

                Else

                    arTarget = .Rows(i).Item("Ar_Target")
                    lbTotalTarget.Text = Format(arTarget + lbTotalTarget.Text, "#,##0.00")
                    lbTotalTarget2.Text = lbTotalTarget.Text
                    lbTotalTarget1.Text = lbTotalTarget.Text

                End If

                If IsDBNull(.Rows(i).Item("Ar_LastSales_Date")) Then
                    arLastSales = "ไม่พบข้อมูล"
                Else
                    arLastSales = (.Rows(i).Item("Ar_LastSales_Date"))
                End If

                'If ArCode = "115171" Then
                '    MsgBox("115171")
                'End If

                If IsDBNull(.Rows(i).Item("Ar_Grp_ID")) Or (.Rows(i).Item("Ar_Grp_ID") = "") Then
                        ArCode = .Rows(i).Item("Ar_Cus_ID")
                    Else
                        ArCode = .Rows(i).Item("Ar_Grp_ID")
                End If

                '////////////////////////////////////////////////////////////////
                If IsDBNull(.Rows(i).Item("Profit")) Then
                    arProfit = 0 '.Rows(i).Item("Profit")
                Else
                    arProfit = .Rows(i).Item("Profit")
                End If
                If IsDBNull(.Rows(i).Item("Trh_D_Amt")) Then
                    arAmt = 0
                    arSumQtyW = 0
                    arPrKg = 0
                Else
                    arAmt = .Rows(i).Item("Trh_D_Amt")
                    arSumQtyW = .Rows(i).Item("Trh_w_Sum")
                    arPrKg = .Rows(i).Item("Pr_Kg")

                End If

                If IsDBNull(.Rows(i).Item("Ar_Sales_Target")) Then
                    arSalesTarget = 0
                Else
                    arSalesTarget = .Rows(i).Item("Ar_Sales_Target")
                End If

                If ((arProfit - arTarget) > 0) And (arTarget > 0) Then
                    chkTarget = 1
                Else
                    chkTarget = 0

                End If

                Dim diffSalesRatio As Double = 0
                diffSalesRatio = (((arAmt - arSalesTarget) / arSalesTarget) * 100)
                Dim diffProfitRatio As Double = 0
                diffProfitRatio = (((arProfit - arTarget) / arTarget) * 100)
                anyData = New String() {arNum, arName, arGrade, arSegment, arAmphoe, arCity, arTarget59.ToString("#,##0.00"), arTarget.ToString("#,##0.00"), arProfit.ToString("#,##0.00"), diffProfitRatio.ToString("#,##0.00"), arSumSales59.ToString("#,##0.00"), arSalesTarget.ToString("#,##0.00"), arAmt.ToString("#,##0.00"), diffSalesRatio.ToString("#,##0.00"), arSumQtyW.ToString("#,##0.00"), arPrKg.ToString("#,##0.00"), arLastSales, ArCode}
                lvi = New ListViewItem(anyData)
                lbTotalProfitNow.Text = (CDbl(lbTotalProfitNow.Text) + arProfit).ToString("#,##0.00")
                lbTotalQtyW.Text = (CDbl(lbTotalQtyW.Text) + arSumQtyW).ToString("#,##0.00")
                lsvARdetail.Items.Add(lvi)
                lbDiffProF_Target.Text = (lbTotalProfitNow.Text - lbTotalTarget1.Text).ToString("#,##0.00")
                lbTotalSales.Text = (arAmt + lbTotalSales.Text).ToString("#,##0.00")
                lbTotalTargetSL.Text = Format(arSalesTarget + lbTotalTargetSL.Text, "#,##0.00")

                Dim chkGrpCus As Integer = 0
                If .Rows(i).Item("Ar_Cus_iD") = .Rows(i).Item("Ar_Grp_ID") Then
                    chkGrpCus = 0
                Else
                    chkGrpCus = 1
                End If
                If chkRow = 0 Then
                    lvi.BackColor = Color.White
                    lvi.ForeColor = Color.Black
                    chkRow = 1

                ElseIf chkRow = 1 Then
                    lvi.BackColor = Color.PaleGoldenrod
                    lvi.ForeColor = Color.Black
                    chkRow = 0

                    'Else
                    '    lvi.BackColor = Color.Black
                    '    lvi.ForeColor = Color.White
                End If
                'If optCusName.Checked = True Then

                'End If
                If chkGrpCus = 1 Then
                    lvi.BackColor = Color.MediumPurple
                    lvi.ForeColor = Color.White
                Else

                End If
                chkGrpCus = 0


                lbCusQty.Text = i + 1
                If chkTarget = 1 Then
                    lvi.BackColor = Color.YellowGreen
                    lvi.ForeColor = Color.Black
                End If
                If optTotalSales.Checked = True Then
                    If diffSalesRatio < 0 Then
                        lvi.BackColor = Color.Linen
                        lvi.ForeColor = Color.Black
                    Else
                        lvi.BackColor = Color.YellowGreen
                        lvi.ForeColor = Color.Black
                    End If
                ElseIf optProfit.Checked = True Then

                    If diffProfitRatio < 0 Then
                        lvi.BackColor = Color.Pink
                        lvi.ForeColor = Color.Black
                    Else
                        lvi.BackColor = Color.YellowGreen
                        lvi.ForeColor = Color.Black
                    End If
                End If
            Next

            lbDiffTarget.Text = Format(lbTotalTarget.Text - lbTotalYear59.Text, "#,##0.00")
            lbDiffTarget2.Text = Format((lbTotalTarget2.Text - lbKPI.Text), "#,##0.00")
            lbDiffKPI.Text = Format(lbTotalProfitNow.Text - lbKPI0.Text, "#,##0.00")
            lbX_Diff.Text = Format(100 - (((lbKPI0.Text - lbTotalProfitNow.Text) / lbTotalProfitNow.Text) * 100), "#,##0") & " %"
            lbX_DiffPf_Target.Text = (100 - (((lbTotalTarget1.Text - lbTotalProfitNow.Text) / lbTotalProfitNow.Text) * 100)).ToString("#,##0") & "%"
            lbDiffSales.Text = Format(lbTotalSales.Text - lbTotalTargetSL.Text, "#,##0.00")
            lbPriceKg.Text = Format(lbTotalSales.Text / lbTotalQtyW.Text, "#,##0.00")

        End With
        ' getSQLDetailSL()
        Call showChart()
    End Sub
    Sub setHeadDetail()

        ' lsvDetail.Clear()
        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvDetail.Columns.Add("#", 30, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("รายการ", 100, HorizontalAlignment.Left)
        lsvDetail.Columns.Add("จำนวน", 50, HorizontalAlignment.Right)
        lsvDetail.Columns.Add(" Values ", 120, HorizontalAlignment.Right)
        lsvDetail.Columns.Add(" % ", 60, HorizontalAlignment.Right)
        lsvDetail.Columns.Add(" ID ", 60, HorizontalAlignment.Right)

        lsvDetail.View = View.Details
        lsvDetail.FullRowSelect = True
        lsvDetail.GridLines = True
        txtFind.Text = ""
    End Sub
    Sub showChart()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = getSQLshowChart()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataReport")

        'Dim data01 As New DataPoint()
        'Dim sChart As New Series
        Dim series0 As New Series("SERIES0")
        Dim anyData() As String
        Dim lviReportDtl As ListViewItem

        CusChart.ChartAreas(0).AxisX.LineWidth = 2
        CusChart.ChartAreas(0).AxisX.Interval = 1

        CusChart.Series.Clear()
        Dim max0 As Integer = 0
        Dim strName As String = ""
        Dim strCode As String = ""
        Dim dblValues As Double = 0
        'Dim dblValues2 As Double = 0
        Dim dblPercen As Double = 0
        Dim intCount As Integer = 0
        Dim dblTotalProfNow As Double = CDbl(lbTotalProfitNow.Text)

        lsvDetail.Clear()
        Call setHeadDetail()
        lbCusChartTotal.Text = 0
        For i = 0 To subDS.Tables("dataReport").Rows.Count - 1

            With subDS.Tables("dataReport").Rows(i)
                If IsDBNull(.Item("Name")) Then
                    strName = "Null"
                Else
                    strName = .Item("Name")
                    strCode = .Item("code")
                End If

                If optChtBar.Checked = True Then
                    dblValues = .Item("Profit")
                    ' dblValues2 = .Item("Profit") / 1000000
                    dblPercen = 100 - (((dblTotalProfNow - dblValues) / dblTotalProfNow) * 100)
                    intCount = .Item("Grp_Count")
                    ' series0.Points.AddXY(.Item("Name"), .Item("Profit"))
                    series0.Points.AddXY(.Item("Name"), Format(dblValues, "#,##0.00"))
                Else
                    dblValues = .Item("Profit")
                    dblPercen = 100 - (((dblTotalProfNow - dblValues) / dblTotalProfNow) * 100)
                    intCount = .Item("Grp_Count")
                    ' series0.Points.AddXY(.Item("Name"), .Item("Profit"))
                    series0.Points.AddXY(.Item("Name"), Format(dblPercen, "#,##0.00"))
                End If
                If max0 <= dblValues Then
                    max0 = dblValues
                End If
            End With

            anyData = New String() {(i + 1), strName, intCount.ToString("#,##0"), dblValues.ToString("#,##0.00"), dblPercen.ToString("#,##0.00"), strCode}
            lviReportDtl = New ListViewItem(anyData)
            lsvDetail.Items.Add(lviReportDtl)
            lbCusChartTotal.Text = (lbCusChartTotal.Text + dblValues).ToString("#,##0.00")
        Next
        If optChtBar.Checked = True Then

            series0.Palette = ChartColorPalette.EarthTones
            series0.ChartType = SeriesChartType.Column
            series0.LabelFormat = "#,##0.00"
            series0.BorderWidth = 4
            series0.IsValueShownAsLabel = True
            series0.IsVisibleInLegend = False
            series0.LabelAngle = 90

            series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        Else
            series0.ChartType = SeriesChartType.Pie
            series0.LabelFormat = "#,##0.00"
            series0.BorderWidth = 4
            series0.IsValueShownAsLabel = True
            series0.IsVisibleInLegend = True

            series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        End If

        'series0.Palette = ChartColorPalette.EarthTones
        ' series0.ChartType = SeriesChartType.Pie

        'If optTypeBar.Checked = True Then

        'Else
        '    series0.ChartType = SeriesChartType.Pie
        '    series0.IsVisibleInLegend = True
        'End If

        'CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman",11.0F, System.Drawing.FontStyle.Italic)
        With CusChart
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
            .ChartAreas(0).AxisY.Maximum = max0 + 1000000
        End With

    End Sub

    Function getSQLshowChart() As String

        txtSQL = "Select "
        If optGrade.Checked = True Then

            txtSQL = txtSQL & "(MktCusGrade.Grd_C_ID)as code,(Grd_C_Name)as Name,"

            txtSQL = txtSQL & "(Select count(*)as GradeCount "
            txtSQL = txtSQL & "from ArFile "
            txtSQL = txtSQL & "Left Join MktCusGrade On Ar_Grade=GRD_C_ID "
            'txtSQL = txtSQL & "Where Ar_Sales='" & selSale & "' "

            If selSale = "" Then
            Else
                txtSQL = txtSQL & "Where  Ar_Sales='" & selSale & "' "
            End If

            txtSQL = txtSQL & ")as V100,  "
            txtSQL = txtSQL & "count(Grd_C_Name)as Grp_Count,"
            txtSQL = txtSQL & "isnull(sum(Profit),0)as Profit,sum(Trh_D_Amt)as Trh_D_Amt, "

        ElseIf optSegment.Checked = True Then

            txtSQL = txtSQL & "(MktSegment.Grp_Code)as code,(Grp_name)as Name,"

            txtSQL = txtSQL & "(Select count(*)as GrpCount "
            txtSQL = txtSQL & "from ArFile "
            txtSQL = txtSQL & "Left Join MktSegment On AR_Group=Grp_Code "
            If selSale = "" Then
            Else
                txtSQL = txtSQL & "Where  Ar_Sales='" & selSale & "' "
            End If

            txtSQL = txtSQL & ")as V100,  "
            txtSQL = txtSQL & "count(Grp_name)as Grp_Count,"
            txtSQL = txtSQL & "isnull(sum(Profit),0)as Profit,sum(Trh_D_Amt)as Trh_D_Amt, "
            'MktSegment on ArFile.AR_Group=MktSegment.Grp_Code "
        Else

            txtSQL = txtSQL & "(MktCusGrade.Grd_C_ID)as code,(Grd_C_Name)as Name,"

            txtSQL = txtSQL & "(Select count(*)as GradCount "
            txtSQL = txtSQL & "from ArFile "
            txtSQL = txtSQL & "Left Join MktCusGrade On Ar_Grade=GRD_C_ID "
            If selSale = "" Then
            Else
                txtSQL = txtSQL & "Where  Ar_Sales='" & selSale & "' "
            End If

            txtSQL = txtSQL & ")as V100,  "
            txtSQL = txtSQL & "count(Grd_C_Name)as Grp_Count,"
            txtSQL = txtSQL & "isnull(sum(Profit),0)as Profit,sum(Trh_D_Amt)as Trh_D_Amt, "


        End If

        txtSQL = txtSQL & "( Select sum(Trh_D_Amt-Trh_Disc_Amt-Trh_Cost_Amt)as sumProfit "
        txtSQL = txtSQL & "from ArFile Left Join TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_id=Trh_Cus "

        txtSQL = txtSQL & "Where trh_type='S' "
        If selSale = "" Then
        Else
            txtSQL = txtSQL & "And Ar_Sales='" & selSale & "' "
        End If

        txtSQL = txtSQL & "And Trh_D_Amt > 0 "

        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And (Trh_ProD_Sales='02' or Trh_ProD_Sales='05') "
        Else

        End If

        If optSum.Checked = True Then
            txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())) )  "
            txtSQL = txtSQL & ")as sumProfic "
        ElseIf optAVG_Now.Checked = True Then

            txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )  "
            txtSQL = txtSQL & ")as sumProfic "
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
            txtSQL = txtSQL & "And  (Month(Trh_Date)=month(GetDate()))   "
            txtSQL = txtSQL & ")as sumProfic "
        End If


        'txtSQL = txtSQL & "From ArFile "
        'txtSQL = txtSQL & "Left Join AmphoeMast "
        'txtSQL = txtSQL & "On Ar_Amphoe_code=Amphoe_Code "
        'txtSQL = txtSQL & "Left Join MktCusGrade "
        'txtSQL = txtSQL & "On Ar_Grade=GRD_C_ID "
        'txtSQL = txtSQL & "left Join MktSegment "
        'txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "


        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join AmphoeMast "
        txtSQL = txtSQL & "On Ar_Amphoe_code=Amphoe_Code "
        If optGrade.Checked = True Then
            txtSQL = txtSQL & "Left Join MktCusGrade On ArFile.Ar_Grade=GRD_C_ID "

        ElseIf optSegment.Checked = True Then

            txtSQL = txtSQL & "left Join MktSegment on ArFile.AR_Group=MktSegment.Grp_Code "
        Else
            txtSQL = txtSQL & "Left Join MktCusGrade On ArFile.Ar_Grade=GRD_C_ID "
        End If

        txtSQL = txtSQL & "Left Join ( "
        txtSQL = txtSQL & "Select Trh_Cus,sum(Trh_D_Amt)as Trh_D_Amt,"
        txtSQL = txtSQL & "sum(Trh_D_Amt-Trh_Disc_Amt-Trh_Cost_Amt)as Profit "
        txtSQL = txtSQL & "from TranDataH "
        txtSQL = txtSQL & "Where  "
        txtSQL = txtSQL & "(Trh_Type='S' And (Trh_NoType='V' Or Trh_NoType='N' Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "
        txtSQL = txtSQL & "And Trh_D_Amt > 0 "

        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And (Trh_ProD_Sales='02' or Trh_ProD_Sales='05' ) "
        Else

        End If

        If optSum.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())) )    "  ' เดือน
        ElseIf optAVG_Now.Checked = True Then

            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "  ' เดือน
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And (Month(Trh_Date)=month(GetDate()))   "
        End If


        txtSQL = txtSQL & "Group by Trh_Cus "
        txtSQL = txtSQL & ")TranDataH "

        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "
        If selSale = "" Then
        Else
            txtSQL = txtSQL & "Where Ar_Sales='" & selSale & "' "
        End If


        If optGrade.Checked = True Then
            txtSQL = txtSQL & "group by MktCusGrade.Grd_C_ID,Grd_C_Name "
        ElseIf optSegment.Checked = True Then
            txtSQL = txtSQL & "group by MktSegment.Grp_Code,Grp_name "
        Else
            txtSQL = txtSQL & "group by MktCusGrade.Grd_C_ID,Grd_C_Name "
        End If
        txtSQL = txtSQL & "Order by Profit desc"

        Return txtSQL

    End Function
    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub
    Function genSQLMonthChart() As String

        txtSQL = "Select  year(Trh_Date)as trh_Year,month(Trh_Date)as trh_Month,"
        txtSQL = txtSQL & "sum(Trh_D_Amt)As Trh_D_Amt,"
        txtSQL = txtSQL & "sum(Trh_W_Sum)as Trh_W_Sum,"
        txtSQL = txtSQL & "sum(Trh_Cost_Amt)As Trh_Cost_Amt, "
        txtSQL = txtSQL & "isnull(sum((Trh_D_Amt -Trh_Disc_Amt- Trh_Cost_Amt)), 0)As Profit  "

        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Left Join AmphoeMast On Ar_Amphoe_code=Amphoe_Code "
        txtSQL = txtSQL & "Left Join MktCusGrade On Ar_Grade=GRD_C_ID  "
        txtSQL = txtSQL & "Left Join MktSegment on ArFile.AR_Group=MktSegment.Grp_Code "
        txtSQL = txtSQL & "left Join TranDataH "
        txtSQL = txtSQL & "On Ar_Cus_ID=Trh_Cus "

        txtSQL = txtSQL & "Where  AR_type ='AR' "
        If selSale = "" Then
        Else
            txtSQL = txtSQL & "And Ar_Sales='" & selSale & "' "
        End If

        txtSQL = txtSQL & "And (Trh_Type='S' And (Trh_NoType='V' Or Trh_NoType='N' Or Trh_NoType='B' Or Trh_NoType='M' Or Trh_NoType='Y' Or Trh_NoType='Z' ) ) "

        'txtSQL=txtSQL & "And ar_cus_id ='112200' and trh_no='N61010011'
        If optSum.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)>=year(GETDATE())-2 and Year(Trh_Date)<=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())) )    "  ' เดือน
        ElseIf optAVG_Now.Checked = True Then

            txtSQL = txtSQL & "And (Year(Trh_Date)>=year(GETDATE())-2 and Year(Trh_Date)<=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "  ' เดือน
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)>=year(GETDATE())-2 and Year(Trh_Date)<=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And (Month(Trh_Date)=month(GetDate()))   "
        End If

        txtSQL = txtSQL & "And Trh_D_Amt > 0 "

        If optSelGP.Checked = True Then
            txtSQL = txtSQL & "And Trh_ProD_Sales='01' "
        ElseIf optSelTT.Checked = True Then
            txtSQL = txtSQL & "And (Trh_ProD_Sales='02' or Trh_ProD_Sales='05') "
        Else

        End If
        ' txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
        'If optSum.Checked = True Then
        '    txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
        '    txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=GetDate()) )  "

        'Else
        '    txtSQL = txtSQL & "And  (Year(Trh_Date)=year(GETDATE())) "
        '    txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=GetDate()-1) )  "


        'End If

        txtSQL = txtSQL & "group by  year(Trh_Date),month(Trh_Date) "
        txtSQL = txtSQL & "order by  year(Trh_Date),month(Trh_Date) "

        Return txtSQL

    End Function

    Sub showMonthChart()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = genSQLMonthChart()
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataMonth")

        Dim data01 As New DataPoint()
        'Dim sChart As New Series
        'Dim chartAreas0 As New ChartArea
        'Dim chartAreas1 As New ChartArea

        Dim series0 As New Series '("SERIES0")
        Dim series1 As New Series '("SERIES0")
        Dim series2 As New Series '("SERIES0")

        Dim series00 As New Series '("SERIES0")
        Dim series11 As New Series '("SERIES0")
        Dim series22 As New Series '("SERIES0")

        Dim anyData() As String
        Dim lviReportDtl As ListViewItem


        'chartAreas0.GetSeriesDepth(series0)
        'chartAreas0.GetSeriesDepth(series1)
        'chartAreas0.GetSeriesDepth(series2)

        'chartAreas1.GetSeriesDepth(series00)
        'chartAreas1.GetSeriesDepth(series11)
        'chartAreas1.GetSeriesDepth(series22)
        'MonthChart.ChartAreas.Clear()
        'MonthChart.ChartAreas.Add(chartAreas0)
        'MonthChart.ChartAreas.Add(chartAreas1)

        MonthChart.ChartAreas(0).AxisX.LineWidth = 2
        MonthChart.ChartAreas(0).AxisX.Interval = 1

        MonthChart.Series.Clear()
        Dim chkRow As Integer = 0
        Dim max0 As Integer = 0
        Dim max00 As Integer = 0

        Dim strName As String = ""

        Dim dblData As Double = 0
        Dim dblTotalData As Double = 0

        Dim dblAmt As Double = 0
        Dim dblSumQtyW As Double = 0

        Dim totalData0 As Double = 0
        ' Dim totalSumQtyW0 As Double = 0
        Dim totalData1 As Double = 0
        ' Dim totalSumQtyW1 As Double = 0
        Dim totalData2 As Double = 0
        ' Dim totalSumQtyW2 As Double = 0

        Dim intMonth As Double = 0
        Dim intCount As Integer = 0
        Dim dblProfit As Double = 0
        Dim yearNow As Integer = Year(DateAdd(DateInterval.Year, -543, Now))
        Dim year1 As Integer = yearNow - 1
        Dim year2 As Integer = yearNow - 2
        Dim div0 As Integer = 0

        lsvMonthChart.Clear()
        'lsvMonthChart.Items.Clear()
        setHeadMonth()

        For i = 0 To subDS.Tables("dataMonth").Rows.Count - 1

            With subDS.Tables("dataMonth").Rows(i)
                If IsDBNull(.Item("trh_Month")) Then
                    strName = "Null"
                Else
                    strName = .Item("Trh_Year") & "-" & .Item("trh_Month")
                End If

                If optSumAmt.Checked = True Then
                    dblData = .Item("Trh_D_Amt")
                    div0 = 1000000
                ElseIf optSumProfit.Checked = True Then
                    dblData = .Item("Profit")
                    div0 = 1000000
                ElseIf optSumQtyW.Checked = True Then
                    dblData = .Item("Trh_W_Sum")
                    div0 = 1000
                End If

                dblAmt = .Item("Trh_D_Amt") / 1000000
                dblSumQtyW = .Item("Trh_W_Sum") / 1000
                dblProfit = .Item("Profit") / 1000000

                'dblPercen = 100 - (((dblTotalProfNow - dblValues) / dblTotalProfNow) * 100)
                intCount = 0 '.Item("Grp_Count")
                ' series0.Points.AddXY(.Item("Name"), .Item("Profit"))
                '===========================================================================
                'MsgBox(Mid(.Item("Name"), 4, 4))

                chkRow = .Item("trh_Year")
                If yearNow = chkRow Then
                    series0.Points.AddXY(.Item("trh_Month"), Format(dblData / div0, "#,##0.00"))
                    totalData0 = dblData / div0 + (totalData0)
                    ' totalSumQtyW0 = .Item("Profit") + totalSumQtyW0
                ElseIf year1 = chkRow Then
                    series1.Points.AddXY(.Item("trh_Month"), Format(dblData / div0, "#,##0.00"))
                    totalData1 = dblData / div0 + (totalData1)
                    ' totalSumQtyW1 = .Item("Profit") + totalSumQtyW1
                ElseIf year2 = chkRow Then
                    series2.Points.AddXY(.Item("trh_Month"), Format(dblData / div0, "#,##0.00"))
                    totalData2 = dblData / div0 + (totalData2)
                    ' totalSumQtyW2 = .Item("Profit") + totalSumQtyW2
                End If


                'If yearNow = .Item("Trh_Year") Then
                'ElseIf year1 = .Item("Trh_Year") Then
                'ElseIf year2 = .Item("Trh_Year") Then
                'End If
                If max00 <= (totalData0) Then
                    max00 = totalData0
                ElseIf max00 <= (totalData1) Then
                    max00 = totalData1
                ElseIf max00 <= (totalData2) Then
                    max00 = totalData2
                End If
                '===========================================================================
                If max0 <= dblData / div0 Then
                    max0 = dblData / div0
                End If
            End With

            anyData = New String() {strName, dblAmt.ToString("#,##0.00"), dblSumQtyW.ToString("#,##0.00"), dblProfit.ToString("#,##0.00")}
            lviReportDtl = New ListViewItem(anyData)
            lsvMonthChart.Items.Add(lviReportDtl)
            If chkRow = yearNow Then
                lviReportDtl.BackColor = Color.Orange
                lviReportDtl.ForeColor = Color.Black
                chkRow = 1

            ElseIf chkRow = year1 Then
                lviReportDtl.BackColor = Color.YellowGreen
                lviReportDtl.ForeColor = Color.Black
                chkRow = 0

            ElseIf chkRow = year2 Then

                lviReportDtl.BackColor = Color.OliveDrab
                lviReportDtl.ForeColor = Color.Black

            End If
        Next
        Dim StrMonth As String = "Total" '(Month(Now) + 1)

        series00.Points.AddXY(StrMonth, Format(totalData0, "#,##0.00"))
        series11.Points.AddXY(StrMonth, Format(totalData1, "#,##0.00"))
        series22.Points.AddXY(StrMonth, Format(totalData2, "#,##0.00"))
        'If optChtBar.Checked = True Then

        'series0.Palette = ChartColorPalette.EarthTones
        series0.Color = Color.Orange
        series0.Name = yearNow
        series0.ChartType = SeriesChartType.Column
        series0.LabelFormat = "#,##0.00"
        series0.BorderWidth = 4
        series0.IsValueShownAsLabel = True
        series0.IsVisibleInLegend = True  ' แสดงป้ายชื่อข้อมูล 
        series0.LabelAngle = 90
        series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        series00.Color = Color.Orange
        series00.Name = "รวม" & yearNow
        series00.ChartType = SeriesChartType.Column
        series00.LabelFormat = "#,##0.00"
        series00.BorderWidth = 4
        series00.IsValueShownAsLabel = True
        series00.IsVisibleInLegend = True  ' แสดงป้ายชื่อข้อมูล 
        series00.LabelAngle = 90
        series00.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        ' series1.Palette = ChartColorPalette.EarthTones
        series1.Name = year1
        series1.Color = Color.YellowGreen
        series1.ChartType = SeriesChartType.Column
        series1.LabelFormat = "#,##0.00"
        series1.BorderWidth = 4
        series1.IsValueShownAsLabel = True
        series1.IsVisibleInLegend = True ' แสดงป้ายชื่อข้อมูล 
        series1.LabelAngle = 90
        series1.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        series11.Name = "รวม" & year1
        series11.Color = Color.YellowGreen
        series11.ChartType = SeriesChartType.Column
        series11.LabelFormat = "#,##0.00"
        series11.BorderWidth = 4
        series11.IsValueShownAsLabel = True
        series11.IsVisibleInLegend = True ' แสดงป้ายชื่อข้อมูล 
        series11.LabelAngle = 90
        series11.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        ' series2.Palette = ChartColorPalette.EarthTones
        series2.Name = year2
        series2.Color = Color.OliveDrab
        series2.ChartType = SeriesChartType.Column
        series2.LabelFormat = "#,##0.00"
        series2.BorderWidth = 4
        series2.IsValueShownAsLabel = True
        series2.IsVisibleInLegend = True ' แสดงป้ายชื่อข้อมูล 
        series2.LabelAngle = 90
        series2.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)

        ' series22.Palette = ChartColorPalette.EarthTones
        series22.Name = "รวม" & year2
        series22.Color = Color.OliveDrab
        series22.ChartType = SeriesChartType.Column
        series22.LabelFormat = "#,##0.00"
        series22.BorderWidth = 4
        series22.IsValueShownAsLabel = True
        series22.IsVisibleInLegend = True ' แสดงป้ายชื่อข้อมูล 
        series22.LabelAngle = 90
        series22.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)


        'series0.YAxisType = AxisType.Primary
        'series1.YAxisType = AxisType.Primary
        'series2.YAxisType = AxisType.Primary

        'series00.YAxisType = AxisType.Secondary
        'series11.YAxisType = AxisType.Secondary
        'series22.YAxisType = AxisType.Secondary
        'Else
        'series0.ChartType = SeriesChartType.Pie
        '    series0.LabelFormat = "#,##0.00"
        '    series0.BorderWidth = 4
        '    series0.IsValueShownAsLabel = True
        '    series0.IsVisibleInLegend = True

        '    series0.Font = New Font(Me.Font.Name, 10, FontStyle.Regular)
        'End If

        With MonthChart

            .ChartAreas(0).AxisX.LabelStyle.Angle = -90  ' หมุนป้ายแกน X 
            '.ChartAreas(0).AxisY.Minimum = 10
            .ChartAreas(0).AxisX.MajorGrid.Enabled = False
            .BackColor = Color.DarkGray
            .TextAntiAliasingQuality = TextAntiAliasingQuality.Normal

            If optYear.Checked = True Then
                .Series.Add(series22)
                .Series.Add(series11)
                .Series.Add(series00)
                .ChartAreas(0).AxisY.Maximum = max00 + ((max00 * 50) / 100)
            Else

                .Series.Add(series2)
                .Series.Add(series1)
                .Series.Add(series0)
                .ChartAreas(0).AxisY.Maximum = max0 + ((max0 * 30) / 100)
            End If

            .BorderlineWidth = 1
            '.ChartAreas(0).AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Italic)
            .ChartAreas(0).AxisX.MinorTickMark.Enabled = True  ' ทำให้ Label ชื่อในแนวแกน X โชว์ทั้งหมด
            '.ChartAreas(0).AxisX.LabelStyle.Angle = -90
            '.ChartAreas(0).AxisY.MinorTickMark.Enabled = True
            '.ChartAreas(0).AxisY2.MinorTickMark.Enabled = True
            .ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont  ' จัดให้อยู่ในแนวเดียวกันทั้งหดม
            '.ChartAreas(0).AxisY.Maximum = max0
        End With
    End Sub

    Sub setHeadMonth()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        'lsvMonthChart.Columns.Add("#", 30, HorizontalAlignment.Left)
        lsvMonthChart.Columns.Add("รายการ", 60, HorizontalAlignment.Left)
        lsvMonthChart.Columns.Add("ยอดขาย", 70, HorizontalAlignment.Right)
        lsvMonthChart.Columns.Add("น้ำหนัก", 70, HorizontalAlignment.Right)
        lsvMonthChart.Columns.Add("กำไร", 70, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("ที่อยู่-จังหวัด", 150, HorizontalAlignment.Left)

        'lsvDetail.Columns.Add("เริ่มทำการซื้อขาย", 120, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("ซื้อขายล่าสุด", 120, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("อายุลูกค้า", 120, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("กำไรปี 59", 150, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("Target", 150, HorizontalAlignment.Right)
        'lsvDetail.Columns.Add("id", 1, HorizontalAlignment.Right)
        lsvMonthChart.View = View.Details
        lsvMonthChart.FullRowSelect = True
        lsvMonthChart.GridLines = True

    End Sub

    Sub runReport()

        Call runRpt()

        'Call setHeadMonth()
        Call showMonthChart()
        Call showChartGrpProD()

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbCusQty.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles lbDiffTarget.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub lsvARdetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvARdetail.SelectedIndexChanged

    End Sub
    'Function getArGrpID(CusID As String) As String
    '    Dim subDA As SqlClient.SqlDataAdapter
    '    Dim subDS As New DataSet
    '    txtSQL = "Select * "
    '    txtSQL = txtSQL & "FRom ArFile "
    '    txtSQL = txtSQL & "Where Ar_Cus_ID='" & CusID & "' "

    '    subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '    subDA.Fill(subDS, "dataArfile")
    '    If subDS.Tables("dataArfile").Rows.Count > 0 Then
    '        If IsDBNull(subDS.Tables("dataArfile").Rows(0).Item("Ar_Grp_ID")) Then
    '            Return ""
    '        Else
    '            Return subDS.Tables("dataArfile").Rows(0).Item("Ar_Grp_ID")
    '        End If

    '    End If
    'End Function
    Private Sub lsvARdetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvARdetail.DoubleClick

        Dim lvi0 As ListViewItem

        For i = 0 To lsvARdetail.SelectedItems.Count - 1
            lvi0 = lsvARdetail.SelectedItems(i)
            selCusID = lsvARdetail.Items(lvi0.Index).SubItems(17).Text

        Next
        If selCusID = "" Then
            MsgBox("พบ Error บันทัดที่ 1349 แจ้ง ICT ")
            Exit Sub
        End If
        Dim frmSetGrade As New frmAnalyCus
        frmSetGrade.Show()
        'Call runRpt()

    End Sub

    Private Sub cmdSetup_Click(sender As Object, e As EventArgs) Handles cmdSetup.Click

        Dim frmSetSales As New frmSetSales
        frmSetSales.ShowDialog()
        runReport()

    End Sub

    Private Sub optSector_Click(sender As Object, e As EventArgs) Handles optSector.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optAZ_Click(sender As Object, e As EventArgs) Handles optAZ.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub


    Private Sub optLastSales_Click(sender As Object, e As EventArgs) Handles optLastSales.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optTarget_Click(sender As Object, e As EventArgs) Handles optTarget.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub


    Private Sub optGrade_Click(sender As Object, e As EventArgs) Handles optGrade.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub


    Private Sub optZA_Click(sender As Object, e As EventArgs) Handles optZA.Click
        If frmLoad = True Then
            runReport()
        End If

    End Sub

    Private Sub optAZ_CheckedChanged(sender As Object, e As EventArgs) Handles optAZ.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub optAVG_CheckedChanged(sender As Object, e As EventArgs) Handles optAVG_Now.CheckedChanged
        If frmLoad = True Then
            runReport()

        End If
    End Sub

    Private Sub optSum_CheckedChanged(sender As Object, e As EventArgs) Handles optSum.CheckedChanged
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSegment_Click(sender As Object, e As EventArgs) Handles optSegment.Click
        If frmLoad = True Then
            ' strSelOpt = ""
            runReport()
        End If

    End Sub

    Private Sub optLastSales_CheckedChanged(sender As Object, e As EventArgs) Handles optLastSales.CheckedChanged

    End Sub

    Private Sub optChtBar_CheckedChanged(sender As Object, e As EventArgs) Handles optChtBar.CheckedChanged
        If frmLoad = True Then
            Call showChart()
        End If
    End Sub

    Private Sub optChrPie_CheckedChanged(sender As Object, e As EventArgs) Handles optChrPie.CheckedChanged
        If frmLoad = True Then
            Call showChart()

        End If
    End Sub

    Private Sub optChrPie_Click(sender As Object, e As EventArgs) Handles optChrPie.Click
        If frmLoad = True Then
            Call showChart()
        End If
    End Sub

    Private Sub optChtBar_Click(sender As Object, e As EventArgs) Handles optChtBar.Click
        If frmLoad = True Then
            Call showChart()
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub optSelGP_CheckedChanged(sender As Object, e As EventArgs) Handles optSelGP.CheckedChanged
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSelTT_CheckedChanged(sender As Object, e As EventArgs) Handles optSelTT.CheckedChanged
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSelTotal_CheckedChanged(sender As Object, e As EventArgs) Handles optSelTotal.CheckedChanged
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub lsvDetail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvDetail.SelectedIndexChanged

    End Sub
    Private Sub lsvARdetail_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lsvARdetail.ColumnClick
        ' MsgBox(e.Column)

        lsvARdetail.Columns(e.Column).Width = 1


    End Sub
    Private Sub lsvDetail_DoubleClick(sender As Object, e As EventArgs) Handles lsvDetail.DoubleClick
        Dim lvi0 As ListViewItem

        For i = 0 To lsvDetail.SelectedItems.Count - 1
            lvi0 = lsvDetail.SelectedItems(i)

            chkSelOpt = True
            strSelOpt = lsvDetail.Items(lvi0.Index).SubItems(5).Text

        Next
        If frmLoad = True Then
            runReport()
            ' strSelOpt = ""
        End If

    End Sub

    Function genSQLGrpProD()

        txtSQL = "select Trh_Prod_Sales,ProGrpMast.ProGrp_Name, "
        txtSQL = txtSQL & "("
        txtSQL = txtSQL & "Select sum(Trh_D_Amt) "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On TranDataH.Trh_Cus=ArFile.Ar_Cus_ID "
        txtSQL = txtSQL & "where (trh_type = 'S' And (Trh_NoType='V' or Trh_NoType='N' Or Trh_NoType='B' or Trh_NoType='M' Or Trh_NoType='Z' or Trh_NoType='Y')) "
        txtSQL = txtSQL & "And Trh_D_Amt >0 "
        If optSum.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())) )    "  ' เดือน
        ElseIf optAVG_Now.Checked = True Then

            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "  ' เดือน
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And (Month(Trh_Date)=month(GetDate()))   "
        End If

        'txtSQL = txtSQL & "And Trh_Cus='" & selCusID & "' 
        If selSale = "" Then
        Else
            txtSQL = txtSQL & "And Ar_Sales='" & selSale & "' "
        End If

        txtSQL = txtSQL & ")as sumSales, "
        txtSQL = txtSQL & "sum(Trh_Cost_Amt)as Trh_Cost, "
        txtSQL = txtSQL & "sum(isnull(trh_D_amt,0))as Trh_D_Amt, "
        txtSQL = txtSQL & "sum(isnull(trh_w_sum,0))as Trh_W_Sum, "
        txtSQL = txtSQL & "isnull(sum(trh_D_amt)/sum(trh_w_sum),0)as price "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left join ArFile "
        txtSQL = txtSQL & "on trh_cus = AR_CUS_ID "
        txtSQL = txtSQL & "Left Join ProGrpMast  "
        txtSQL = txtSQL & "On Trh_ProD_Sales=ProGrpMast.ProGrp_ID "

        txtSQL = txtSQL & "where (trh_type = 'S' And (Trh_NoType='V' or Trh_NoType='N' Or Trh_NoType='B' or Trh_NoType='M' Or Trh_NoType='Z' or Trh_NoType='Y'))  "
        txtSQL = txtSQL & "And Trh_D_Amt > 0 "
        'txtSQL = txtSQL & "And Trh_Cus='" & selCusID & "' "
        If selSale = "" Then
        Else
            txtSQL = txtSQL & "And Ar_Sales='" & selSale & "' "
        End If

        txtSQL = txtSQL & "And not(ProGrpMast.ProGrp_ID='04' or ProGrpMast.ProGrp_ID='09') "
        'txtSQL = txtSQL & "And year(trh_Date)=Year(GetDate()) "

        If optSum.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())) )    "  ' เดือน
        ElseIf optAVG_Now.Checked = True Then

            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And ((Month(Trh_Date)>=1) and (Month(Trh_Date)<=month(GetDate())-1) )   "  ' เดือน
        ElseIf optMonthNow.Checked = True Then
            txtSQL = txtSQL & "And (Year(Trh_Date)=year(GETDATE())) "  ' ปี
            txtSQL = txtSQL & "And (Month(Trh_Date)=month(GetDate()))   "
            txtSQL = txtSQL & "And Trh_W_Sum > 1 "  ' ป้องกันการ Error  จาก Trh_W_Sum เป็น 0
        End If

        txtSQL = txtSQL & "Group by  Trh_Prod_Sales,ProGrpMast.ProGrp_Name "
        txtSQL = txtSQL & "order by Trh_D_Amt "
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
        Try
            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "rptGrpProD")

            For i = 0 To subDS.Tables("rptGrpProD").Rows.Count - 1
                With subDS.Tables("rptGrpProD").Rows(i)
                    strGrpName = .Item("ProGrp_Name")
                    dblGrpSumAmt = .Item("sumSales")
                    dblGRpAmt = .Item("Trh_D_Amt")
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

        Catch ex As Exception
            MsgBox("ข้อมูลไม่พอในการคำนวนยอด")
        End Try

    End Sub

    Private Sub optMonthNow_CheckedChanged(sender As Object, e As EventArgs) Handles optMonthNow.CheckedChanged
        If frmLoad = True Then
            runReport()

        End If
    End Sub

    Private Sub optSegment_CheckedChanged(sender As Object, e As EventArgs) Handles optSegment.CheckedChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lbDiffProF_Target.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lbX_DiffPf_Target.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optGrade_CheckedChanged(sender As Object, e As EventArgs) Handles optGrade.CheckedChanged

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub optTarget_CheckedChanged(sender As Object, e As EventArgs) Handles optTarget.CheckedChanged

    End Sub

    Private Sub optTotalSales_CheckedChanged(sender As Object, e As EventArgs) Handles optTotalSales.CheckedChanged

    End Sub

    Private Sub optTotalSales_Click(sender As Object, e As EventArgs) Handles optTotalSales.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optProfit_CheckedChanged(sender As Object, e As EventArgs) Handles optProfit.CheckedChanged

    End Sub

    Private Sub optProfit_Click(sender As Object, e As EventArgs) Handles optProfit.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optMonth_CheckedChanged(sender As Object, e As EventArgs) Handles optMonth.CheckedChanged

    End Sub

    Private Sub optMonth_Click(sender As Object, e As EventArgs) Handles optMonth.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optYear_CheckedChanged(sender As Object, e As EventArgs) Handles optYear.CheckedChanged

    End Sub

    Private Sub optYear_Click(sender As Object, e As EventArgs) Handles optYear.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSumAmt_CheckedChanged(sender As Object, e As EventArgs) Handles optSumAmt.CheckedChanged

    End Sub

    Private Sub optSumAmt_Click(sender As Object, e As EventArgs) Handles optSumAmt.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSumProfit_CheckedChanged(sender As Object, e As EventArgs) Handles optSumProfit.CheckedChanged

    End Sub

    Private Sub optSumProfit_Click(sender As Object, e As EventArgs) Handles optSumProfit.Click
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optSumQtyW_CheckedChanged(sender As Object, e As EventArgs) Handles optSumQtyW.CheckedChanged
        If frmLoad = True Then
            runReport()
        End If
    End Sub

    Private Sub optCusName_CheckedChanged(sender As Object, e As EventArgs) Handles optCusName.CheckedChanged
        If frmLoad = True Then
            ' strSelOpt = ""
            runReport()
        End If
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            runReport()
        End If
    End Sub

    Private Sub cmbReportTT_Click(sender As Object, e As EventArgs) Handles cmbReportTT.Click
        Dim frmSalesRptTT As New frmSales_ReportByTT
        frmSalesRptTT.Show()

    End Sub



    'Function getCusGrade(cusCode As String) As String

    '    Dim ans As String
    '    Dim subDA As SqlClient.SqlDataAdapter
    '    Dim subDS As New DataSet
    '    Try
    '        txtSQL = "Select * "
    '        txtSQL = txtSQL & "From ArFile "

    '        txtSQL = txtSQL & "WHERE ArFile.AR_Cus_ID='" & CusId & "'"

    '        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '        subDA.Fill(subDS, "ARList")

    '        ans = subDS.Tables("ARList").Rows(0).Item("Ar_Grade")
    '        subDS = Nothing
    '        subDA = Nothing
    '        Return ans

    '    Catch ex As Exception
    '        Return ""
    '    End Try

    'End Function
End Class