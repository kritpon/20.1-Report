Module rptTools
    Function getDblTrhDisc(trhNo As String, trhType As String, trhAVG As Boolean) As Double

        Dim Ans As Double = 0
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        Dim strTrhDisc As String
        Dim dblTrhDisc As Double
        Dim dblTotalTrhAmt As Double
        Dim dblItemTrh As Double '= getDocItem(trhNo, trhType)

        If trhType = "K" Then
            trhType = "B"
        End If
        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "WHERE trh_type='" & trhType & "' "
        txtSQL = txtSQL & "And Trh_No='" & trhNo & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataTrh")
        If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) Then
            Return 0

        End If
        '
        'If strTrhDisc = 0 Then
        '    Return 0
        'End If

        'If subDS.Tables("dataTrh").Rows.Count > 0 Then
        If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) = False Then

            If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) Then
                strTrhDisc = ""
            Else
                strTrhDisc = subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc").ToString  'String % ส่วนลด 
            End If


            If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Item_Count")) Then
                dblItemTrh = 0
            Else
                dblItemTrh = subDS.Tables("dataTrh").Rows(0).Item("Trh_Item_Count")  ' จำนวน Item ทั้งหมดเพื่อนำมาหาร ส่วนลดหัวบิลเฉลียทั้งบิล

            End If
            If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")) Then
                dblTotalTrhAmt = 0
            Else
                dblTotalTrhAmt = subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")  ' ยอดเงินรวม
            End If


            'dblItemQ = getDocItem(subDS.Tables("dataTrh").Rows(0).Item("Trh_No"), "S")
            If IsNumeric(strTrhDisc) Then
                If strTrhDisc = 0 Then
                    Return 0

                End If

                'If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")) Then
                '    Return 0
                'Else
                '    dblTotalTrhAmt = subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")  ' ยอดเงินรวม
                'End If
                ' Ans = CDbl(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc"))
                Ans = CDbl(strTrhDisc)

            Else
                If Microsoft.VisualBasic.Right(strTrhDisc, 1) = "%" Then

                    dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1))
                    dblTrhDisc = (dblTotalTrhAmt * CDbl(dblTrhDisc)) / 100
                    Ans = dblTrhDisc

                ElseIf Microsoft.VisualBasic.Right(strTrhDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strTrhDisc, 1) = "B" Then

                    Ans = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1))

                ElseIf IsNumeric(strTrhDisc) Then
                    Ans = CDbl(strTrhDisc)

                End If

            End If

        End If
        If trhAVG = True Then
            Ans = Ans / dblItemTrh  ' =  Ans = Ans /  dblItemTrh

        End If
        'If Ans > 0 Then
        '    MsgBox("ok")
        'End If

        subDS = Nothing
        subDA = Nothing
        Return Ans

    End Function
    Function getStrTrhDisc(trhNo As String, trhType As String) As String

        Dim ans As Double
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        Dim strTrhDisc As String = ""
        Dim dblTrhDisc As Double = 0
        Dim dblTotalTrhAmt As Double = 0

        'Dim dblItemQ As Double = 0
        If trhType = "K" Then
            trhType = "B"
        End If
        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataH "
        txtSQL = txtSQL & "WHERE trh_type='" & trhType & "' "
        txtSQL = txtSQL & "And Trh_No='" & trhNo & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "dataTrh")

        'If subDS.Tables("dataTrh").Rows.Count > 0 Then
        If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) = False Then

            If IsDBNull(subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")) Then
                dblTotalTrhAmt = 0
            Else
                dblTotalTrhAmt = subDS.Tables("dataTrh").Rows(0).Item("Trh_Amt")  ' ยอดเงิน
            End If
            strTrhDisc = subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")  ' % ส่วนลด 

            'dblItemQ = getDocItem(subDS.Tables("dataTrh").Rows(0).Item("Trh_No"), "S")
            If IsNumeric(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) Then
                If CDbl(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc")) = 0 Then
                    ans = 0
                Else
                    ans = CDbl(subDS.Tables("dataTrh").Rows(0).Item("Trh_Disc"))
                End If
            Else
                If Microsoft.VisualBasic.Right(strTrhDisc, 1) = "%" Then

                    dblTrhDisc = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1))
                    dblTrhDisc = (dblTotalTrhAmt * CDbl(dblTrhDisc)) / 100
                    ans = dblTrhDisc '/ dblItemQ

                ElseIf Microsoft.VisualBasic.Right(strTrhDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strTrhDisc, 1) = "B" Then

                    ans = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1)) '/ dblItemQ

                ElseIf IsNumeric(strTrhDisc) Then
                    ans = CDbl(strTrhDisc)

                End If

            End If
        Else
            ans = 0
        End If

        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function


    Function getDocItem(ByVal DocNo As String, ByVal DocType As String) As Integer
        Dim ans As Integer

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If DocType = "K" Then
            DocType = "B"
        End If
        If Trim(DocNo) = "" Then
            Return 0
        Else

            'dbTools.openDB()
            txtSQL = "Select * "
            txtSQL = txtSQL & "From TranDataD "

            txtSQL = txtSQL & "WHERE Dtl_Type='" & DocType & "' "
            txtSQL = txtSQL & "And Dtl_No='" & DocNo & "'  "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "stkList")

            ans = subDS.Tables("stkList").Rows.Count
            '============================ แก้ไขพิเศษ  ============================

            Return ans
        End If

        ' dbTools.closeDB()

    End Function


    Function getDiscValue(strDisc As String, PriceV As Double) As Double

        Dim ANS As Double = 0
        Dim tempDisc As Double

        If Microsoft.VisualBasic.Right(strDisc, 1) = "%" Then

            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))
            tempDisc = (PriceV * CDbl(tempDisc)) / 100

        ElseIf Microsoft.VisualBasic.Right(strDisc, 1) = "b" Or Microsoft.VisualBasic.Right(strDisc, 1) = "B" Then

            tempDisc = CDbl(Microsoft.VisualBasic.Left(strDisc, Len(strDisc) - 1))

        ElseIf IsNumeric(tempDisc) Then

            tempDisc = CDbl(strDisc)

        ElseIf strDisc = 0 Or strDisc = "" Then

            tempDisc = 0
        End If
        Return tempDisc

    End Function

    Function calAmt() As Double
        Dim Ans As String = ""

        Return Ans
    End Function

    Function getStrTypeReport(dtlType As String, strCusName As String) As String
        Dim dtlItem As String = ""

        If dtlType = "S" Then
            'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
            dtlItem = "ขายสินค้าให้ " & strCusName
        ElseIf dtlType = "L" Or dtlType = "H" Then
            'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
            dtlItem = "ลดหนี้ให้กับ " & strCusName

        ElseIf dtlType = "X" Then
            'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
            dtlItem = "เบิกใช้เพื่อ " & strCusName

        ElseIf dtlType = "B" Or dtlType = "5" Then 'เพิ่มType ของใบแจ้งหนี้เข้าไป 
            'dtlItem = "Order ÊÔ¹¤éÒ¢Í§ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
            If IsDBNull(strCusName) Then
                dtlItem = " ******** ไม่พบข้อมูล ***********"
            Else
                dtlItem = "รับ Order " & strCusName
            End If
        ElseIf dtlType = "D" Then
            If IsDBNull(strCusName) Then
                dtlItem = "รับสินค้าจากผลิต ******** ไม่พบข้อมูล ***********"
            Else
                dtlItem = "รับสินค้าจากผลิตเพื่อ " & strCusName '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
            End If
        ElseIf dtlType = "C" Then

            If IsDBNull(strCusName) Then
                dtlItem = "รับสินค้าจากซื้อ เพื่อ "
            Else

                dtlItem = "รับสินค้าจากซื้อ เพื่อ " & strCusName '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
            End If

        ElseIf dtlType = "E" Then
            If IsDBNull(strCusName) Then
                dtlItem = "สั่งผลิตสินค้า " & "-" & "'"
            Else
                dtlItem = "สั่งผลิตสินค้า " & strCusName '
            End If

        ElseIf dtlType = "G" Then
            dtlItem = "MMA เข้าถังกวน"
        ElseIf dtlType = "F" Then
            dtlItem = "รับสินค้าจาก " & strCusName

        ElseIf dtlType = "P" Or dtlType = "T" Then

            If IsDBNull(strCusName) Then
                dtlItem = "ไม่พบข้อมูล  "
            Else
                dtlItem = "เบิกสินค้าเพื่อ " & "-" & strCusName
            End If

        ElseIf dtlType = "Z" Then
            dtlItem = "โอนสินค้าไปที่ " & strCusName
        ElseIf dtlType = "A" Then
            If IsDBNull(strCusName) Then
                dtlItem = "ปรับยอดตรวจนับ Null "
            Else
                dtlItem = "ปรับยอดตรวจนับ " & "-" & strCusName
            End If

        ElseIf dtltype = "6" Then
            dtlItem = "เสนอราคาให้" & "-" & strCusName
        Else
            dtlItem = " ******** ไม่พบรายกางที่เลือก ***********"
        End If

        Return dtlItem

    End Function

    Function getStrRcv() As String

        Dim dtltype As String = ""
        Dim Q_Rcv As Double = 0
        Dim num As Double = 0
        If dtltype = "S" Then

        ElseIf dtltype = "X" Then
            Q_Rcv = num
        ElseIf dtltype = "L" Or dtltype = "H" Then
            Q_Rcv = num
        ElseIf dtltype = "C" Then
            Q_Rcv = num
        ElseIf dtltype = "U" Then

        ElseIf dtltype = "P" Or dtltype = "" Then
            Q_Rcv = num
        ElseIf dtltype = "B" Then
            Q_Rcv = num
        ElseIf dtltype = "5" Then 'เพิ่มTypeของใบแจ้งหนี้เข้าไป เพื่อให้รายงานแสดงจำนวนแผ่น
            Q_Rcv = num
        ElseIf dtltype = "D" Then
            Q_Rcv = num
            'Q_Bal = (Q_Bal + Q_Rcv)
        ElseIf dtltype = "E" Then
            Q_Rcv = num
            'Q_Bal = (Q_Bal + Q_Rcv)
        ElseIf dtltype = "G" Then
            Q_Rcv = num
            'Q_Bal = (Q_Bal + Q_Rcv)
        ElseIf dtltype = "F" Then
            Q_Rcv = num
            'Q_Bal = (Q_Bal + Q_Rcv)
        ElseIf dtltype = "Z" Then
            Q_Rcv = num
        ElseIf dtltype = "A" Then
            Q_Rcv = num
        ElseIf dtltype = "Q" Then
            Q_Rcv = num
        End If

        Return Q_Rcv

    End Function

    'Function getDblTrhDisc(strDocNo As String, dtlType As String, dblTrhAmt As Double, strTrhDisc As String) As Double
    '    Dim tmpTrhDisc As Double = 0
    '    Dim itemQ As Double
    '    Dim amtDisc As Double
    '    itemQ = getDocItem(strDocNo, dtlType)    ' จำนวน Item ในบิล
    '    'amtDisc = getDblTrhDisc(strDocNo, dtlType)  ' ส่วนลดหัวบิล

    '    If IsDBNull(strTrhDisc) = True Then
    '        strTrhDisc = 0
    '    ElseIf Microsoft.VisualBasic.Right(strTrhDisc, 1) = "%" Then

    '        If IsNumeric(strTrhDisc) Then
    '            If amtDisc = 0 Then
    '                strTrhDisc = 0
    '            Else
    '                If itemQ = 0 Then
    '                    strTrhDisc = 0
    '                Else
    '                    tmpTrhDisc = amtDisc / itemQ  ' ส่วนลดหัวบิล หารด้วยจำนวน Item ในบิล
    '                    strTrhDisc = tmpTrhDisc
    '                    'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
    '                End If
    '            End If
    '        Else
    '            strTrhDisc = strTrhDisc
    '            tmpTrhDisc = amtDisc / itemQ
    '            'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
    '        End If
    '    ElseIf Microsoft.VisualBasic.Right(strTrhDisc, 1) = "b" Then
    '        'strTrhDisc = strTrhDisc
    '        tmpTrhDisc = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1))
    '    ElseIf (strTrhDisc) = 0 Then
    '        strTrhDisc = 0
    '    Else
    '        'itemQ = getDocItem(strDocNo, dtlType)
    '        'amtDisc = getDblTrhDisc(strDocNo, dtlType)  '  ÂÍ´à§Ô¹ÃÇÁ·ÕèËÑ¡ÊèÇ¹Å´áÅéÇ

    '        If IsNumeric(strTrhDisc) Then
    '            If amtDisc = 0 Then
    '                strTrhDisc = 0
    '            Else
    '                If itemQ = 0 Then
    '                    strTrhDisc = 0
    '                Else
    '                    tmpTrhDisc = amtDisc / itemQ
    '                    strTrhDisc = tmpTrhDisc
    '                    'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
    '                End If

    '            End If
    '        Else
    '            strTrhDisc = strTrhDisc
    '            tmpTrhDisc = amtDisc / itemQ
    '            'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
    '        End If

    '    End If
    '    Return tmpTrhDisc
    'End Function

    Function returnMM_YY(dataMonthS As Integer, dataYear As Integer) As String
        Dim ans As String = ""

        If dataMonthS < 0 Then
            dataYear = dataYear - 1

            If dataMonthS = -1 Then
                ans = 12.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -2 Then
                ans = 11.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -3 Then
                ans = 10.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -4 Then
                ans = 9.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -5 Then
                ans = 8.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -6 Then
                ans = 7.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -7 Then
                ans = 6.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -8 Then
                ans = 5.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -9 Then
                ans = 4.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -10 Then
                ans = 3.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -11 Then
                ans = 2.ToString & "-" & dataYear.ToString
            ElseIf dataMonthS = -12 Then
                ans = 1.ToString & "-" & dataYear.ToString
            Else
                ans = dataMonthS & "-" & dataYear.ToString
            End If
        ElseIf dataMonthS > 12 Then ' And dataMonthS < 24
            'Dim data1 As Integer
            dataYear = dataYear
            ans = (dataMonthS - 13).ToString & "-" & dataYear.ToString
        ElseIf dataMonthS = 0 Then
            ans = "1" & "-" & dataYear.ToString
        Else
            ans = dataMonthS & "-" & dataYear.ToString
        End If

        'End If
        Return ans
    End Function
End Module
