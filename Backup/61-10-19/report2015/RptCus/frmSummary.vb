Public Class frmSummary
    Private Sub lbFindCus_Click(sender As Object, e As EventArgs) Handles lbFindCus.Click

        Dim searchCus As searchCus = New searchCus
        chkSelCustom.Checked = True

        selStkID = ""
        searchCus.ShowDialog()
        lbCusID.Text = CusId
        lbCusName.Text = dbTools.getCusName(CusId)

    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        lbSumSaleAmt.Text = 0
        lbSumDNAmt.Text = 0
        lbSumCNAmt.Text = 0

        txtSQL = "Select AR_Cus_id,Ar_Name,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Disc_amt)sumAmt, "
        txtSQL = txtSQL & "sum(TranDataH.Trh_Cost_Amt)sumCost ,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Cost_Amt)sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        'txtSQL = txtSQL & "Left Join TranDataD "
        'txtSQL = txtSQL & "ON Trh_Type=Dtl_type and Trh_No=Dtl_no "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "where (Trh_Type='S')"
        '==================   ใช้เลือกลูกค้า =========================

        txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        '==================   ใช้เลือกลูกค้า =========================
        txtSQL = txtSQL & "And not(Trh_ProD_Sales='09') "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) "

        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "
        'txtSQL = txtSQL & "And not(dtl_idTrade='130000000000000000000000' or dtl_idTrade='aa4100000000000000002001' ) "
        ' ตัวสินค้าบริการออก เพราะ ยอดขายจะร่วมแต่การขายสินค้าอย่างเดียว


        txtSQL = txtSQL & "And (Trh_NoType='N' or Trh_NoType='V' or Trh_NoType='B' or Trh_NoType='M' ) "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Full_Amt=0 )"


        txtSQL = txtSQL & "group by Ar_Cus_id,Ar_Name  "
        'txtSQL = txtSQL & "BaseMast.Stk_Factor,BaseMast.Stk_Factor2, "
        'txtSQL = txtSQL & "Dtl_Same_Code "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Command")
        If subDS.Tables("Command").Rows.Count > 0 Then
            lbSumSaleAmt.Text = Format(subDS.Tables("Command").Rows(0).Item("sumAmt"), "#,##0.00")
        Else
            lbSumSaleAmt.Text = "0.0"
        End If


        txtSQL = "Select AR_Cus_id,Ar_Name,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_Sum)sumAmt, "
        txtSQL = txtSQL & "sum(TranDataH.Trh_Cost_Amt)sumCost ,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Cost_Amt)sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type And Trh_No=Dtl_No "

        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "where (Trh_Type='L')"
        txtSQL = txtSQL & "And not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) "
        ' txtSQL = txtSQL & "And not(Dtl_idTrade='aa4100000000000000002000' )"
        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "
        'txtSQL = txtSQL & "And (Trh_NoType='N' or Trh_NoType='V' or Trh_NoType='B' or Trh_NoType='M' ) "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Full_Amt=0 )"
        txtSQL = txtSQL & "group by Ar_Cus_id,Ar_Name  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Command2")

        If subDS.Tables("Command2").Rows.Count > 0 Then
            lbSumCNAmt.Text = Format(subDS.Tables("Command2").Rows(0).Item("sumAmt"), "#,##0.00")
        Else
            lbSumCNAmt.Text = "0.0"
        End If

        txtSQL = "Select AR_Cus_id,Ar_Name,"
        txtSQL = txtSQL & "sum(TranDataD.Dtl_Sum)sumAmt, "
        txtSQL = txtSQL & "sum(TranDataH.Trh_Cost_Amt)sumCost ,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Cost_Amt)sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On Trh_Type=Dtl_Type And Trh_No=Dtl_No "

        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "where (Trh_Type='L')"
        txtSQL = txtSQL & "And not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) "
        txtSQL = txtSQL & "And (Dtl_idTrade='aa4100000000000000002000' )"
        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "
        'txtSQL = txtSQL & "And (Trh_NoType='N' or Trh_NoType='V' or Trh_NoType='B' or Trh_NoType='M' ) "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Full_Amt=0 )"


        txtSQL = txtSQL & "group by Ar_Cus_id,Ar_Name  "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Command3")

        If subDS.Tables("Command3").Rows.Count > 0 Then
            lbSumDN2Amt.Text = Format(subDS.Tables("Command3").Rows(0).Item("sumAmt"), "#,##0.00")
        Else
            lbSumDN2Amt.Text = "0.0"
        End If


        txtSQL = "Select AR_Cus_id,Ar_Name,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt)sumAmt, "
        txtSQL = txtSQL & "sum(TranDataH.Trh_Cost_Amt)sumCost ,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Cost_Amt)sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "where (Trh_Type='H')"
        txtSQL = txtSQL & "And not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) "

        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "
        'txtSQL = txtSQL & "And (Trh_NoType='N' or Trh_NoType='V' or Trh_NoType='B' or Trh_NoType='M' ) "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Full_Amt=0 )"


        txtSQL = txtSQL & "group by Ar_Cus_id,Ar_Name  "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Command4")

        If subDS.Tables("Command4").Rows.Count > 0 Then
            lbSumDNAmt.Text = Format(subDS.Tables("Command4").Rows(0).Item("sumAmt"), "#,##0.00")
        Else
            lbSumDNAmt.Text = "0.0"
        End If


        lbTotal.Text = Format(CDbl(lbSumSaleAmt.Text) + CDbl(lbSumDNAmt.Text) + CDbl(lbSumDN2Amt.Text) - CDbl(lbSumCNAmt.Text), "#,##0.00")

        txtSQL = "Select AR_Cus_id,Ar_Name,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Disc_amt)sumAmt, "
        txtSQL = txtSQL & "sum(TranDataH.Trh_Cost_Amt)sumCost ,"
        txtSQL = txtSQL & "sum(TranDataH.TRh_Amt-TranDataH.Trh_Cost_Amt)sumProfit "

        txtSQL = txtSQL & "From TranDataH "
        'txtSQL = txtSQL & "Left Join TranDataD "
        'txtSQL = txtSQL & "ON Trh_Type=Dtl_type and Trh_No=Dtl_no "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=Ar_Cus_ID "

        txtSQL = txtSQL & "where (Trh_Type='S')"
        txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "
        txtSQL = txtSQL & "And not(Trh_ProD_Sales='09') "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) "

        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "
        'txtSQL = txtSQL & "And not(dtl_idTrade='130000000000000000000000' or dtl_idTrade='aa4100000000000000002001' ) "
        ' ตัวสินค้าบริการออก เพราะ ยอดขายจะร่วมแต่การขายสินค้าอย่างเดียว


        txtSQL = txtSQL & "And (Trh_NoType='Y' or Trh_NoType='Z' ) "
        txtSQL = txtSQL & "And not(TranDataH.Trh_Full_Amt=0 )"


        txtSQL = txtSQL & "group by Ar_Cus_id,Ar_Name  "
        'txtSQL = txtSQL & "BaseMast.Stk_Factor,BaseMast.Stk_Factor2, "
        'txtSQL = txtSQL & "Dtl_Same_Code "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "NoPro")
        If subDS.Tables("NoPro").Rows.Count > 0 Then
            lbSumSalesNoPro.Text = Format(subDS.Tables("NoPro").Rows(0).Item("sumAmt"), "#,##0.00")
        Else
            lbSumSalesNoPro.Text = "0.0"
        End If

        lbTotalSales.Text = ((CDbl(lbSumSaleAmt2.Text) + CDbl(lbSumSalesNoPro.Text))).ToString("#,##0.00")

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim rw As Integer = 0
        Dim countRow As Integer = 0
        Dim rowExcel As Integer = 6 '  เริ่ม รายการบรรทัดที่ 9
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0

        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptSummary01.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet

            .Range("D4").Value = lbCusName.Text 'subDS.Tables("Command").Rows(countRow).Item("Ar_Name")

            .Range("D6").Value = Format(lbDate01.Value, "dd/MM/yyyy").ToString
            .Range("F6").Value = Format(lbDate02.Value, "dd/MM/yyyy").ToString

            .Range("D9").Value = lbSumSaleAmt.Text
            .Range("D11").Value = lbSumDNAmt.Text
            .Range("D13").Value = lbSumDN2Amt.Text
            .Range("D15").Value = lbSumCNAmt.Text

            .Range("D17").Value = lbTotal.Text

            .Range("D23").Value = lbSumSalesNoPro.Text

        End With

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim i As Integer = 0

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH left Join TranDataD "
        txtSQL = txtSQL & "On TranDataH.Trh_Type=TranDataD.Dtl_Type And Trh_No=Dtl_no "

        txtSQL = txtSQL & "where(Trh_Type ='S') "
        '--And Trh_Cus ='110624' 
        txtSQL = txtSQL & "And (dtl_idTrade ='130000000000000000000000'  )  "
        'And Trh_Cus ='110624' 
        'And (Trh_NoType ='N' or Trh_NoType='V' or Trh_NoType='B' or Trh_NoType='M' ) 
        'And Not (TranDataH.Trh_Full_Amt = 0)

        '--And Not(TranDataH.Trh_Sale='SL03' or TranDataH.Trh_Sale='SL12' or Trh_Sale='SL14' ) 
        txtSQL = txtSQL & "And Trh_Date <= '2017/11/30'  "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Command4")

        For i = 0 To subDS.Tables("Command4").Rows.Count - 1

            With subDS.Tables("Command4").Rows(i)

                txtSQL = "Update tranDataH set Trh_ProD_Sales='09' "
                txtSQL = txtSQL & "where Trh_Type='S' "
                txtSQL = txtSQL & "And Trh_No='" & .Item("Trh_No") & "' "

                dbTools.dbSaveSQLsrv(txtSQL, "")


            End With

        Next
    End Sub

    Private Sub lbSumSaleAmt_Click(sender As Object, e As EventArgs) Handles lbSumSaleAmt.Click

    End Sub

    Private Sub lbSumSaleAmt_TextChanged(sender As Object, e As EventArgs) Handles lbSumSaleAmt.TextChanged
        lbSumSaleAmt2.Text = lbSumSaleAmt.Text

    End Sub

    Private Sub lbDate01_ValueChanged(sender As Object, e As EventArgs) Handles lbDate01.ValueChanged
        lbDate02.Value = lbDate01.Value

    End Sub
End Class