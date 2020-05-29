Public Class frmPendingOrder

    Sub getCols()

        lsvPending.Items.Clear()
        lsvPending.Clear()
        lsvPending.Refresh()
        If optShowArDetail.Checked = True Then

            lsvPending.Columns.Add("#", 30, HorizontalAlignment.Center)
            lsvPending.Columns.Add("--วันที่--", 1, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("type", 1, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("Order", 1, HorizontalAlignment.Left)
            lsvPending.Columns.Add("ลูกค้า", 300, HorizontalAlignment.Left)
            lsvPending.Columns.Add("รายการ", 1, HorizontalAlignment.Left)        '==0
            lsvPending.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("น้ำหนัก", 100, HorizontalAlignment.Right)        '==00

            lsvPending.Columns.Add("ราคา", 90, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("ลด", 50, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("หลังลด", 80, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("มูลค่า", 100, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("ราคาเฉลี่ย", 80, HorizontalAlignment.Right)

            lsvPending.Columns.Add("หมายเหตุ", 100, HorizontalAlignment.Left)      '==10
            lsvPending.Columns.Add("ลดหัวบิล", 100, HorizontalAlignment.Left)      '==10
            ' lsvRev.Columns.Add("เลขที่ Order ", 100, HorizontalAlignment.Left)      '==11

        ElseIf optShowDetail.Checked = True Then

            lsvPending.Columns.Add("#", 30, HorizontalAlignment.Center)
            lsvPending.Columns.Add("--วันที่--", 100, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("type", 30, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("Order", 100, HorizontalAlignment.Left)
            lsvPending.Columns.Add("ลูกค้า", 250, HorizontalAlignment.Left)
            lsvPending.Columns.Add("รายการ", 250, HorizontalAlignment.Left)        '==0
            lsvPending.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("น้ำหนัก", 100, HorizontalAlignment.Right)        '==00

            lsvPending.Columns.Add("ราคา", 90, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("ลด", 50, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("หลังลด", 80, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("มูลค่า", 100, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("ราคาเฉลี่ย", 80, HorizontalAlignment.Right)

            lsvPending.Columns.Add("หมายเหตุ", 100, HorizontalAlignment.Left)      '==10
            lsvPending.Columns.Add("ลดหัวบิล", 100, HorizontalAlignment.Left)      '==10
            ' lsvRev.Columns.Add("เลขที่ Order ", 100, HorizontalAlignment.Left) 

        ElseIf optShowStkDetl.Checked = True Then

            lsvPending.Columns.Add("#", 30, HorizontalAlignment.Center)
            lsvPending.Columns.Add("--วันที่--", 1, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("type", 1, HorizontalAlignment.Center) '==0
            lsvPending.Columns.Add("Order", 1, HorizontalAlignment.Left)
            lsvPending.Columns.Add("ลูกค้า", 1, HorizontalAlignment.Left)
            lsvPending.Columns.Add("รายการ", 250, HorizontalAlignment.Left)        '==0
            lsvPending.Columns.Add("จำนวน", 60, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("น้ำหนัก", 100, HorizontalAlignment.Right)        '==00

            lsvPending.Columns.Add("ราคา", 90, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("ลด", 50, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("หลังลด", 80, HorizontalAlignment.Right)        '==00
            lsvPending.Columns.Add("มูลค่า", 100, HorizontalAlignment.Right)         '==9
            lsvPending.Columns.Add("ราคาเฉลี่ย", 80, HorizontalAlignment.Right)

            lsvPending.Columns.Add("หมายเหตุ", 100, HorizontalAlignment.Left)      '==10
            lsvPending.Columns.Add("ลดหัวบิล", 100, HorizontalAlignment.Left)      '==10
            ' lsvRev.Columns.Add("เลขที่ Order ", 100, HorizontalAlignment.Left)      '==11

        End If

        lsvPending.View = View.Details
        lsvPending.GridLines = True


    End Sub

    Private Sub frmPendingOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getCols()

    End Sub

    Private Sub cmbFindCus_Click(sender As Object, e As EventArgs) Handles cmbFindCus.Click
        Dim findCus As New searchCus
        findCus.ShowDialog()

        selStkID = ""

        lbCusID.Text = CusId
        lbCusName.Text = cusTools.getCusName(CusId)
    End Sub
    Function getSQL() As String

        txtSQL = "SELECT  "

        If optShowDetail.Checked = True Then
            txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME,"
            txtSQL = txtSQL & "Trh_Date,Trh_No,Trh_Type,Trh_NoType,TranDataD.Dtl_date,TranDataD.Dtl_con_id, "
            txtSQL = txtSQL & "TranDataD.Dtl_idtrade, BaseMast.Stk_Name_1,TranDataD.Dtl_detail,TranDataD.Dtl_T_Disc, "

        ElseIf optShowArDetail.Checked = True Then
            txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME,"
        ElseIf optShowStkDetl.Checked = True Then
            txtSQL = txtSQL & "TranDataD.Dtl_idtrade, BaseMast.Stk_Name_1, "
        End If

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
        If optSelCustom.Checked = True Then
            If lbCusID.Text = "" Then
            Else
                txtSQL = txtSQL & "and trandatad.dtl_idcus='" & lbCusID.Text & "' "
            End If

            txtSQL = txtSQL & "and (trandatad.dtl_num-trandatad.dtl_num_2)>0 "

        ElseIf optSelSales.Checked = True Then
            If lbSalesID.Text = "" Then
            Else
                txtSQL = txtSQL & "and Ar_Sales='" & lbSalesID.Text & "' "
            End If


            txtSQL = txtSQL & "and (trandatad.dtl_num-trandatad.dtl_num_2)>0 "

        End If

        txtSQL = txtSQL & "Group By "

        If optShowDetail.Checked = True Then

            txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME,"
            txtSQL = txtSQL & "Trh_Date,Trh_No,Trh_Type,Trh_NoType,TranDataD.Dtl_date,TranDataD.Dtl_con_id, "
            txtSQL = txtSQL & "TranDataD.Dtl_idtrade, BaseMast.Stk_Name_1,TranDataD.Dtl_detail,TranDataD.Dtl_T_Disc, "
            txtSQL = txtSQL & "TranDataD.Dtl_price "
            txtSQL = txtSQL & "order by trandatad.dtl_con_id"

        ElseIf optShowArDetail.Checked = True Then
            txtSQL = txtSQL & "TranDataD.Dtl_idcus,ARFILE.AR_NAME "

            txtSQL = txtSQL & "Order by ARFILE.AR_NAME,QtyW desc"

        ElseIf optShowStkDetl.Checked = True Then
            txtSQL = txtSQL & "TranDataD.Dtl_idtrade, BaseMast.Stk_Name_1  "

            txtSQL = txtSQL & "Order by QtyW desc"

        End If

        Return txtSQL

    End Function
    Sub RunReport(cusCode As String)


        Dim ODS As DataSet = New DataSet
        Dim ODA As SqlClient.SqlDataAdapter

        ODS.Clear()

        txtSQL = getSQL()
        ODA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        ODA.Fill(ODS, "PendingData")

        lsvPending.Clear()

        Call getCols()

        Dim anyData() As String
        Dim lviPenDing As ListViewItem

        lbSumAmt.Text = 0
        lbSumW.Text = 0
        lbSumQty.Text = 0

        For i = 0 To ODS.Tables("PendingData").Rows.Count - 1

            Dim strDocNo As String = ""
            Dim numItem As Integer = 0
            Dim trhDate As String = ""
            Dim strDocType As String = ""
            Dim strNoType As String = ""
            Dim conID As String = ""
            Dim ArName As String = ""
            Dim stkName As String = ""
            Dim StkQty As Integer = 0
            Dim StkW As Double = 0
            Dim dblPrice As Double = 0
            Dim dblAmt As Double = 0
            Dim strDetail As String = ""
            Dim strDisc As String = ""
            Dim TrhItem As Double = 0
            Dim TrhDisc As Double = 0
            Dim tmpTrhDisc As Double = 0
            Dim dblPriceDisc As Double = 0
            Dim avgPrice As Double = 0


            With ODS.Tables("PendingData")

                numItem = i + 1
                If optShowDetail.Checked = True Then
                    strDocNo = .Rows(i).Item("Trh_No")
                    trhDate = Format(.Rows(i).Item("Trh_Date"), "dd-MM-yyyy")
                    If IsDBNull(.Rows(i).Item("Trh_NoType")) Then
                        strNotype = ""
                    Else
                        strNotype = .Rows(i).Item("Trh_NoType")
                    End If
                    strDocType = .Rows(i).Item("Trh_Type")
                    TrhItem = getDocItem(strDocNo, strDocType)   '  จำนวน Item สินค้าในบิล
                    tmpTrhDisc = getDblTrhDisc(strDocNo, strDocType, True)   ' ส่วนลดหัวบิล
                    'tmpTrhDisc = TrhDisc / TrhItem

                    conID = .Rows(i).Item("Dtl_con_id")
                    ArName = .Rows(i).Item("Ar_Name")
                    stkName = .Rows(i).Item("Stk_Name_1")
                    StkQty = .Rows(i).Item("Pending")

                    StkW = .Rows(i).Item("QtyW")

                    TrhItem = getDocItem(strDocNo, strDocType)

                    dblPrice = .Rows(i).Item("sumAmt") / StkQty
                    strDisc = .Rows(i).Item("Dtl_T_Disc")
                    dblPriceDisc = dblPrice - getDiscValue(strDisc, dblPrice)
                    dblAmt = dblPriceDisc * StkQty
                    avgPrice = dblAmt / StkW

                    strDetail = .Rows(i).Item("Dtl_detail")


                ElseIf optShowArDetail.Checked = True Then

                    trhDate = ""
                    strNotype = ""
                    conID = ""
                    ArName = .Rows(i).Item("Ar_Name")
                    stkName = "" ' .Rows(i).Item("Stk_Name_1")
                    StkQty = .Rows(i).Item("Pending")
                    StkW = .Rows(i).Item("QtyW")
                    dblPrice = .Rows(i).Item("sumAmt") / StkQty
                    dblAmt = dblPriceDisc * StkQty

                ElseIf optShowStkDetl.Checked = True Then

                    trhDate = ""
                    strNotype = ""
                    conID = ""
                    ArName = ""
                    stkName = .Rows(i).Item("Stk_Name_1")
                    StkQty = .Rows(i).Item("Pending")
                    StkW = .Rows(i).Item("QtyW")
                    dblPrice = .Rows(i).Item("sumAmt") / StkQty
                    dblAmt = dblPriceDisc * StkQty

                    strDetail = ""

                End If
                '.Rows(i).Item("sumAmt")

                anyData = New String() {numItem, trhDate, strNoType, conID, ArName, stkName, StkQty.ToString("#,##0"), StkW.ToString("#,##0.00"), dblPrice.ToString("#,##0.00"), strDisc, dblPriceDisc.ToString("#,##0.00"), dblAmt.ToString("#,##0.00"), avgPrice.ToString("#,##0.00"), strDetail, TrhDisc}
                lbSumAmt.Text = (lbSumAmt.Text + dblAmt).ToString("#,##0.00")
                lbSumW.Text = (lbSumW.Text + StkW).ToString("#,##0.00")
                lbSumQty.Text = (lbSumQty.Text + StkQty).ToString("#,##0.00")

            End With

            lviPenDing = New ListViewItem(anyData)
            lsvPending.Items.Add(lviPenDing)

        Next


    End Sub

    Private Sub cmbRun_Click(sender As Object, e As EventArgs) Handles cmbRun.Click
        Call RunReport(lbCusID.Text)
    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub

    Private Sub cmbPrint_Click(sender As Object, e As EventArgs) Handles cmbPrint.Click
        Dim ODS As DataSet = New DataSet
        Dim ODA As SqlClient.SqlDataAdapter

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim rw As Integer
        'Dim countRow As Integer
        'Dim countRow2 As Integer

        Dim rowExcel As Integer = 9 '  àÃÔèÁ ÃÒÂ¡ÒÃºÃÃ·Ñ´·Õè 9
        Dim bufferExcel As Integer = 0 ' ãªéã¹¡Ã³Õ¢Öé¹ sheet ãËÁè áÅÐ ãËé buffer ¤èÒµèÍ¨Ò¡ sheet à´ÔÁ à¾×èÍ¹ÑºµèÍ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\reportPending.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        ODS.Clear()

        txtSQL = getSQL()
        ODA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        ODA.Fill(ODS, "PendingData")

        Call getCols()
        If optShowDetail.Checked = True Then

            objExcelWorkSheet.Columns("D").select
            objExcelWorkSheet.Columns("D").insert


        End If
        rowExcel = 5
        Dim numItem As Integer = 0
        Dim trhDate As String = ""
        Dim typeDoc As String = ""
        Dim conID As String = ""
        Dim stkName As String = ""
        Dim ArName As String = ""
        Dim StkQty As Integer = 0
        Dim StkW As Double = 0
        Dim dblPrice As Double = 0
        Dim dblAmt As Double = 0
        Dim strDetail As String = ""

        For i = 0 To ODS.Tables("PendingData").Rows.Count - 1
            trhDate = ""
            typeDoc = ""
            conID = ""
            ArName = ""
            stkName = ""
            StkQty = 0
            StkW = 0
            dblPrice = 0
            strDetail = ""
            dblAmt = 0
            ' rowExcel = 5
            rowExcel = 5 + i
            numItem = i + 1

            With objExcelWorkSheet

                If optShowDetail.Checked = True Then
                    With ODS.Tables("PendingData")
                        trhDate = Format(.Rows(i).Item("Trh_Date"), "dd-MM-yyyy")
                        If IsDBNull(.Rows(i).Item("Trh_NoType")) Then
                            typeDoc = ""
                        Else
                            typeDoc = .Rows(i).Item("Trh_NoType")
                        End If

                        conID = .Rows(i).Item("Dtl_con_id")
                        ArName = .Rows(i).Item("Ar_Name")
                        stkName = .Rows(i).Item("Stk_Name_1")
                        StkQty = .Rows(i).Item("Pending")
                        StkW = .Rows(i).Item("QtyW")
                        dblPrice = .Rows(i).Item("sumAmt") / StkQty
                        strDetail = .Rows(i).Item("Dtl_detail")
                        dblAmt = StkQty * dblPrice
                    End With
                    .Range("A" & rowExcel).Select()
                    .Range("B" & rowExcel).Value = trhDate.ToString
                    .Range("C" & rowExcel).Value = conID
                    .Range("D" & rowExcel).Value = ArName
                    .Range("E" & rowExcel).Value = stkName
                    .Range("F" & rowExcel).Value = StkQty
                    .Range("G" & rowExcel).Value = StkW
                    .Range("H" & rowExcel).Value = dblPrice
                    .Range("I" & rowExcel).Value = dblAmt


                ElseIf optShowArDetail.Checked = True Then
                    With ODS.Tables("PendingData")
                        stkName = .Rows(i).Item("Ar_Name")
                        StkQty = .Rows(i).Item("Pending")
                        StkW = .Rows(i).Item("QtyW")
                        dblPrice = .Rows(i).Item("sumAmt") / StkQty
                        strDetail = "" '.Rows(i).Item("Dtl_detail")
                        dblAmt = StkQty * dblPrice
                    End With
                    .Range("A" & rowExcel).Select()
                    .Range("B" & rowExcel).Value = ""
                    .Range("C" & rowExcel).Value = ""
                    .Range("D" & rowExcel).Value = stkName
                    .Range("E" & rowExcel).Value = StkQty
                    .Range("F" & rowExcel).Value = StkW
                    .Range("G" & rowExcel).Value = dblPrice
                    .Range("H" & rowExcel).Value = dblAmt

                ElseIf optShowStkDetl.Checked = True Then
                    With ODS.Tables("PendingData")

                        stkName = .Rows(i).Item("Stk_Name_1")
                        StkQty = .Rows(i).Item("Pending")
                        StkW = .Rows(i).Item("QtyW")
                        dblPrice = .Rows(i).Item("sumAmt") / StkQty
                        strDetail = ""
                        dblAmt = StkQty * dblPrice
                    End With

                    .Range("A" & rowExcel).Select()
                    .Range("B" & rowExcel).Value = ""
                    .Range("C" & rowExcel).Value = ""
                    .Range("D" & rowExcel).Value = stkName
                    .Range("E" & rowExcel).Value = StkQty
                    .Range("F" & rowExcel).Value = StkW
                    .Range("G" & rowExcel).Value = dblPrice
                    .Range("H" & rowExcel).Value = dblAmt

                End If

                .Range("A" & (rowExcel + 2) & ":" & "AD" & (rowExcel + 2)).Insert()


            End With
            '

        Next

        With objExcelWorkSheet

            rowExcel = rowExcel + 3
            If optShowDetail.Checked = True Then
                .Range("F" & rowExcel).Value = "=sum(F5" & ":F" & rowExcel - 3 & ")"
                .Range("G" & rowExcel).Value = "=sum(G5" & ":G" & rowExcel - 3 & ")"
                ' .Range("H" & rowExcel).Value = '"=sum(H5" & ":H" & rowExcel - 3 & ")"
                .Range("I" & rowExcel).Value = "=sum(I5" & ":I" & rowExcel - 3 & ")"
            Else
                .Range("E" & rowExcel).Value = "=sum(E5" & ":E" & rowExcel - 3 & ")"
                .Range("F" & rowExcel).Value = "=sum(F5" & ":F" & rowExcel - 3 & ")"
                ' .Range("G" & rowExcel).Value = "=sum(G5" & ":G" & rowExcel - 3 & ")"
                .Range("H" & rowExcel).Value = "=sum(H5" & ":H" & rowExcel - 3 & ")"
            End If

        End With

    End Sub

    Private Sub cmbFindSL_Click(sender As Object, e As EventArgs) Handles cmbFindSL.Click
        Dim frmFindSL As New frmSearchSale
        optSelSales.Checked = True
        frmSearchSale.ShowDialog()
        lbSalesID.Text = selSaleiD
        lbSalesName.Text = getSaleName(selSaleiD)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lbCusID.Text = ""
        lbCusName.Text = ""
        lbSalesID.Text = ""
        lbSalesName.Text = ""

    End Sub
End Class