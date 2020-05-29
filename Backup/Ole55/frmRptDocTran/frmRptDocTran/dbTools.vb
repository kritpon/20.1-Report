'Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Module dbTools

    '  Array  ใช้ในการเก็บค่าตัวแปรที่เลือก ข้อมูล

    Public selectProduct(10) As String
    '  Format ของ Array 
    '  SelectProduct(0)  เก็บไว้ใส่  ลำดับที่
    '  SelectProduct(1)  เก็บไว้ใส่  ชื่อสินค้า  Product Name

    'Friend DAODBEngine_definst As New DAO.DBEngine
    'Public strCon As String
    Dim strCon As String
    Public txtSQL1 As String

    Public SLid As String

    'Public pathDB As String

    'Public DB01 As DAO.Database

    Public tbName As String  ' ชื่อ Table  

    Public fileName As String  '  ชื่อไฟล์


    'Public Conn As SqlClient.SqlConnection = New SqlClient.SqlConnection
    Public Conn As SqlConnection = New SqlConnection
    Public subCom As SqlClient.SqlCommand = New SqlClient.SqlCommand
    Public com As SqlCommand = New SqlCommand

    Public gDA As SqlClient.SqlDataAdapter
    Public gDs As DataSet = New DataSet

    Public selCusID As String   ' ตัวแปลร่วมสำหรับเก็บค่า รหัสลูกค้า
    Public selCusType As String ' ตัวแปลร่วมสำหรับเก็บค่า รหัสประเภทลูกค้า
    Public selStore As String  '  ตัวแปรร่วมสำหรับเก็บค่า รหัสคลังสินค้า

    Public selGCusID As String
    Public selGCusName As String

    Public selSaleiD As String  ' ตัวแปลร่วมสำหรับเก็บค่า รหัสพนักงานขาย
    Public selStkID As String   ' ตัวแปลร่วมสำหรับเก็บค่า รหัสสินค้า

    Public txtSQL As String
    'Public Dt As DataTable
    Public selAcctID As String
    Public strConn As String
    Public selBlock As String
    Public selWH As String = ""
    'Public stkColor1 As stkColor = New stkColor


    '=================== ตัวแปรใบเบิกจอย  =====================
    Public PId As String = "" 'เก็บรหัสลูกค้า
    Public PName As String = "" 'เก็บชื่อลูกค้า
    Public Pdate As String = ""
    Public Pdate2 As String = ""
    Public SelectDate As Date
    Public SelectNo As String = "" 'เก็บเลข

    Public CusId As String
    Public CusName As String
    Public CusCreTerm As Integer
    Public CusSaleName As String
    Public CusDiscount As Double
    Public LEdit As ListViewItem

    Public SelectName As String = "" 'เก็บชื่อสินค้า
    Public SelectNum As Integer = 0 'เก็บจำนวน
    Public SelectPrice As Double = 0 'เก็บราคา
    Public SelectCode As String = "" 'เก็บรหัสสินค้า
    Public SelectWeight As Double = 0 'เก็บน้ำหนักแผ่น
    Public SelectStock As Double = 0 'เก็บStock
    Public ChangeCode As String = "" 'เก็บรหัสสินค้าที่จะเปลี่ยน

    Public Ddate As String = ""
    Public Dno As String = ""
    Public Dvat As String = ""
    Public Dcus As String = ""
    Public Dpro As String = ""
    Public Dnum As Integer = 0
    Public Dprice As Single = 0
    Public Dweight As Single = 0
    Public Dproduct As String = ""
    Public Dcusname As String = ""
    Public Ditem As String = ""
    Public DOrder As String = ""
    Public Stock As Integer = 0  'stock

    Public chkNew As Boolean 'เช็คว่ามีการเลือกเอกสารใหม่
    Public chkEditDoc As Boolean 'เช็คว่ามีการเลือกเอกสารมาแก้ไข
    Public chkDel As Boolean 'เช็คว่ามีการลบรายการหรือไม่
    Public EditNo As String = ""

    '=====================================================

    '===================   ประกาศ ตัวแปร ในการใช้ Get User Name
    Declare Function GetUserName Lib "advapi32.dll" Alias _
           "GetUserNameA" (ByVal lpBuffer As String, _
           ByRef nSize As Integer) As Integer

    Public Function GetUserName() As String

        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))

    End Function

    '==========================================================================

    Private Declare Function GetComputerName Lib "kernel32" Alias _
            "GetComputerNameA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

    '===================   ประกาศ ตัวแปร ในการใช้ Get User Name
    'Sub connDB()

    '    'pathDB = "i:\center\SC50.mdb"
    '    'DB01 = DAODBEngine_definst.OpenDatabase(pathDB)

    '    'strConn = "server=EDP;database=db2006;Trusted_Connection=yes;"
    '    ''strConn = "server=(local);database=db2006Test;Trusted_Connection=yes;"
    '    'With Conn
    '    '    If .State = ConnectionState.Open Then .Close()
    '    '    .ConnectionString = strConn
    '    '    .Open()
    '    'End With

    'End Sub

    Sub openDB()
        strConn = DBConnString.strConn2
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

    End Sub

    'Sub openDAO()

    '    'pathDB = "\\edp\business\center\pan49.mdb"
    '    'DB01 = DAODBEngine_definst.OpenDatabase(pathDB)

    'End Sub

    Sub closeDB()
        Conn.Close()
    End Sub

    'Sub closeDAO()
    '    'DB01.Close()

    'End Sub

    Sub dbDelDATA(ByVal txtSQL As String, ByVal txtDisy As String)

        Try
            If MessageBox.Show("ต้องการลบข้อมูล ' " & txtDisy & " ' ที่ระบุหรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    .ExecuteNonQuery()
                End With
            End If
        Catch errprocess As Exception
            MessageBox.Show("ไม่สามารถลบข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Sub dbDelSQLsrv(ByVal txtSQL As String, ByVal txtDisy As String)

        Try
            If MessageBox.Show("ต้องการลบข้อมูล ' " & txtDisy & " ' ที่ระบุหรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                With subCom
                    .CommandType = CommandType.Text
                    .CommandText = txtSQL
                    .Connection = Conn
                    .ExecuteNonQuery()
                End With
            End If
        Catch errprocess As Exception
            MessageBox.Show("ไม่สามารถลบข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Sub dbSaveDATA(ByVal txtSQL As String, ByVal txtDisy As String)

        Try
            ' If MessageBox.Show("ต้องการบันทึกข้อมูล ' " & txtDisy & " ' ที่ระบุหรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'DB01.Execute(txtSQL)  ' บันทึกข้อมูลลง Business 

            With subCom
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With

            'End If
        Catch errprocess As Exception
            MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    'Sub readDB()
    '    'Dim ansTB As String
    '    'Dim ansF As String
    '    'Dim sizeF As String
    '    'Dim countTB As Integer
    '    'Dim countF As Integer

    '    'With DB01
    '    '    For countTB = 0 To DB01.TableDefs.Count - 1
    '    '        ansTB = .TableDefs(countTB).Name
    '    '        For countF = 0 To .TableDefs(countTB).Fields.Count - 1
    '    '            ansF = .TableDefs(countTB).Fields(countF).Name
    '    '            sizeF = Convert.ToString(.TableDefs(countTB).Fields(countF).Size)

    '    '        Next
    '    '    Next
    '    'End With
    '    'With Conn

    '    'End With
    'End Sub

    Sub dbSaveSQLsrv(ByVal tSQL As String, ByVal txtDisy As String)
        dbTools.openDB()
        Try
            With subCom
                .CommandType = CommandType.Text
                .CommandText = tSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            dbTools.closeDB()

        Catch errprocess As Exception
            'MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show(tSQL)
            dbTools.closeDB()
            Exit Sub
        End Try

    End Sub

    '=====================   Function  เสริม ใช้สอบถามค่าต่างๆ ใน DataBase ============================

    Function getCusName(ByVal cusId As String) As String

        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Try
            txtSQL = "Select Ar_Cus_ID,Ar_Name,Ar_C_Term,Ar_Target,Ar_Cre_Lim "
            txtSQL = txtSQL & "From ArFile "

            txtSQL = txtSQL & "WHERE (ArFile.AR_Cus_ID='" & cusId & "')"
            txtSQL = txtSQL & "And (Ar_Type='AR') "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "ARList")

            ans = subDS.Tables("ARList").Rows(0).Item("Ar_Name")
            subDS = Nothing
            subDA = Nothing
            Return ans
        Catch ex As Exception
            Return ""
        End Try


    End Function

    Function getStkWight(ByVal stkCode As String) As Double
        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        dbTools.openDB()
        txtSQL = "Select * "
        txtSQL = txtSQL & "From BaseMast "

        txtSQL = txtSQL & "WHERE (((Stk_Code)='" & stkCode & "'))"

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "command")

        ans = subDS.Tables("command").Rows(0).Item("Stk_Factor")
        subDS = Nothing
        subDA = Nothing
        dbTools.closeDB()
        Return ans

    End Function

    Function getDocType(ByVal docType As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From TypeDocMast "
        txtSQL = txtSQL & "WHERE Type_ID='" & docType & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "command")

        ans = subDS.Tables("command").Rows(0).Item("Type_Name")
        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function

    Function getStore(ByVal strId As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If Trim(strId) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From WareHouse "
            txtSQL = txtSQL & "WHERE Wh_ID='" & strId & "' "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "strList")

            ans = subDS.Tables("strList").Rows(0).Item("Wh_Name")
            subDS = Nothing
            subDA = Nothing
            Return ans
        End If

    End Function

    Function getStrName(ByVal strId As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        dbTools.openDB()
        If Trim(strId) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From warehouse "

            txtSQL = txtSQL & "WHERE ((wh_id='" & strId & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "strList")

            ans = subDS.Tables("strList").Rows(0).Item("wh_Name")

            dbTools.closeDB()
            If subDS.Tables("strList").Rows.Count > 0 Then
                subDS = Nothing
                subDA = Nothing
                Return ans
            Else
                Return ""
            End If

        End If


    End Function

    Function getTypeName(ByVal typId As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If Trim(typId) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From TypeMast "

            txtSQL = txtSQL & "WHERE ((Type_code='" & typId & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "TypeList")

            ans = subDS.Tables("TypeList").Rows(0).Item("Type_Name")

            If subDS.Tables("TypeList").Rows.Count > 0 Then
                subDS = Nothing
                subDA = Nothing
                Return ans
            Else
                Return ""
            End If

        End If


    End Function

    Function getTypeCode(ByVal typName As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        If Trim(typName) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From TypeMast "

            txtSQL = txtSQL & "WHERE ((Type_Name='" & typName & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "TypeList")

            ans = subDS.Tables("TypeList").Rows(0).Item("Type_Code")

            If subDS.Tables("TypeList").Rows.Count > 0 Then
                subDS = Nothing
                subDA = Nothing
                Return ans
            Else
                Return ""
            End If

        End If


    End Function

    Function getStkName(ByVal stkId As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Try
            If Trim(stkId) = "" Then
                subDS = Nothing
                subDA = Nothing
                Return ""
            Else
                txtSQL = "Select * "
                txtSQL = txtSQL & "From BaseMast "

                txtSQL = txtSQL & "WHERE Stk_Code='" & stkId & "'"

                subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDA.Fill(subDS, "stkList")

                ans = subDS.Tables("stkList").Rows(0).Item("stk_Name_1")
                subDS = Nothing
                subDA = Nothing
                Return ans

            End If
        Catch ex As Exception
            Return ""
        End Try



    End Function

    Function getStock(ByVal stkId As String, ByVal strID As String) As Double

        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        dbTools.openDB()
        Try
            If Trim(stkId) = "" Then
                subDS = Nothing
                subDA = Nothing
                Return ""
            Else
                txtSQL = "Select * "
                txtSQL = txtSQL & "From StkDetl "

                txtSQL = txtSQL & "WHERE (((Dtl_Code) Like '%" & stkId & "%')) "
                txtSQL = txtSQL & "And (((Dtl_Store) Like '%" & strID & "%')) "

                subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDA.Fill(subDS, "stkList")

                If subDS.Tables("stkList").Rows.Count > 0 Then
                    ans = subDS.Tables("stkList").Rows(0).Item("Dtl_Bal_Q1")
                Else
                    ans = 0
                End If

                subDS = Nothing
                subDA = Nothing
                dbTools.closeDB()
                Return ans
            End If
        Catch ex As Exception
            dbTools.closeDB()
            Return 0
        End Try

    End Function

    Function getDocNumber(ByVal DocNo As String, ByVal DocType As String) As Boolean
        Dim ans As Boolean

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If Trim(DocNo) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            dbTools.openDB()
            txtSQL = "Select * "
            txtSQL = txtSQL & "From TranDataH "

            txtSQL = txtSQL & "WHERE ((Trh_Type='" & DocType & "') "
            txtSQL = txtSQL & "And (Trh_No='" & DocNo & "')) "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "stkList")

            If subDS.Tables("stkList").Rows.Count > 0 Then
                ans = True
            Else
                ans = False
            End If

            subDS = Nothing
            subDA = Nothing
            dbTools.closeDB()
            Return ans
        End If

    End Function

    Function getStkDetl(ByVal StrCode As String, ByVal StkCode As String) As Boolean
        Dim ans As Boolean

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        If Trim(StkCode) = "" Or Trim(StrCode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From StkDetl "

            txtSQL = txtSQL & "WHERE ((Dtl_Store='" & StrCode & "') "
            txtSQL = txtSQL & "And (Dtl_Code='" & StkCode & "')) "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "stkList")

            If subDS.Tables("stkList").Rows.Count > 0 Then
                ans = True
            Else
                ans = False
            End If

            subDS = Nothing
            subDA = Nothing
            Return ans
        End If

    End Function
    Function getChkBaseMast(ByVal StkCode As String) As Boolean

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        If Trim(StkCode) = "" Or Trim(StkCode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From BaseMast "
            txtSQL = txtSQL & "WHERE (Stk_Code='" & StkCode & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "stkList")

            If subDS.Tables("stkList").Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    Function getSaleName(ByVal saleId As String) As String

        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From salesman "

        txtSQL = txtSQL & "WHERE SL_id='" & saleId & "'"


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slList")

        If subDS.Tables("slList").Rows.Count - 1 < 0 Then
            ans = ""
        Else
            ans = subDS.Tables("slList").Rows(0).Item("sl_Name")
        End If

        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function

    Function getPending(ByVal cusCode As String, ByVal stkCode As String) As Double

        Dim ans As Double

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        If Trim(stkCode) = "" Or Trim(cusCode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            txtSQL = "Select Dtl_idCus,Dtl_idTrade,sum(Dtl_Num-Dtl_Num_2)as penDing "
            txtSQL = txtSQL & "From TranDataD "

            txtSQL = txtSQL & "Where Dtl_idCus='" & cusCode & "'"
            txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "'"
            txtSQL = txtSQL & "And Dtl_Type='B' "
            txtSQL = txtSQL & "Group by Dtl_idCus,Dtl_idTrade "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "PendingTB")
            If subDS.Tables("PendingTB").Rows.Count > 0 Then
                ans = subDS.Tables("PendingTB").Rows(0).Item("penDing")
                Return ans
            Else
                subDS = Nothing
                subDA = Nothing
                Return 0
            End If


        End If
    End Function

    ' ใช้ Update  Stkdetl  แบบสำเร็จ

    Sub updateStock(ByVal CusID As String, ByVal StkCode As String, ByVal OrderQ1 As Double, ByVal RcvQ1 As Double, ByVal IssQ1 As Double, ByVal PenDingUpdate As Boolean)

        Dim subDA3 As New SqlClient.SqlDataAdapter
        Dim subDS3 As New DataSet

        Dim wStk As Double = dbTools.getStkWight(StkCode)

        txtSQL = "Select * From StkDetl "
        txtSQL = txtSQL & "Where Dtl_Code='" & StkCode & "' "
        txtSQL = txtSQL & "And  Dtl_Store='" & CusID & "'"

        subDA3 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA3.Fill(subDS3, "chkStk")


        If subDS3.Tables("chkStk").Rows.Count > 0 Then
            With subDS3.Tables("chkStk").Rows(0)

                txtSQL = "Update StkDetl Set "



                txtSQL = txtSQL & "Dtl_Or_Q1=" & ((.Item("Dtl_Or_Q1") + OrderQ1)) & ","
                txtSQL = txtSQL & "Dtl_Or_Q2=" & ((.Item("Dtl_Or_Q2") + (OrderQ1 * wStk))) & ","

                txtSQL = txtSQL & "Dtl_Rcv_Q1=" & ((.Item("Dtl_Rcv_Q2") + RcvQ1)) & ","
                txtSQL = txtSQL & "Dtl_Rcv_Q2=" & ((.Item("Dtl_Rcv_Q2") + (RcvQ1 * wStk))) & ","

                txtSQL = txtSQL & "Dtl_iSS_Q1=" & ((.Item("Dtl_iss_Q1") + IssQ1)) & ","
                txtSQL = txtSQL & "Dtl_iSS_Q2=" & ((.Item("Dtl_iss_Q2") + (IssQ1 * wStk))) & ","

               

                If ((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) > 0 Then
                    txtSQL = txtSQL & "Dtl_LS_Q1=0" & ","
                    txtSQL = txtSQL & "Dtl_LS_Q2=0" & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & (.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1 & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q2=" & (((.Item("Dtl_LS_Q2") + .Item("Dtl_Bal_q2") + RcvQ1) - IssQ1) * wStk) & ","
                Else
                    txtSQL = txtSQL & "Dtl_LS_Q1=" & (((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1) & ","
                    txtSQL = txtSQL & "Dtl_LS_Q2=0" & (((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1) * wStk & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & ((.Item("Dtl_LS_Q1") + .Item("Dtl_Bal_q1") + RcvQ1) - IssQ1) * -1 & ","
                    txtSQL = txtSQL & "Dtl_Bal_Q2=" & ((((.Item("Dtl_LS_Q2") + .Item("Dtl_Bal_q2") + RcvQ1) - IssQ1)) * wStk) * -1 & ","
                End If                

                If PenDingUpdate = True Then
                    txtSQL = txtSQL & "Dtl_Pen_Q1=" & ((dbTools.getPending(CusID, StkCode) + OrderQ1) - IssQ1) & ","
                    txtSQL = txtSQL & "Dtl_Pen_Q2=" & (((dbTools.getPending(CusID, StkCode) + OrderQ1) - IssQ1) * wStk) & " "
                End If
                txtSQL = txtSQL & "Where Dtl_Store='" & CusID & "' "
                txtSQL = txtSQL & "And Dtl_Code='" & StkCode & "'"

            End With

        Else
            txtSQL = "Insert Into StkDetl "
            txtSQL = txtSQL & "("
            txtSQL = txtSQL & "Dtl_Store,Dtl_Code,"

            txtSQL = txtSQL & "Dtl_Or_Q1,Dtl_Or_Q2,"    ' จอง
            txtSQL = txtSQL & "Dtl_Rcv_Q1,Dtl_Rcv_Q2,"  ' ผลิต
            txtSQL = txtSQL & "Dtl_ISS_Q1,Dtl_ISS_Q2,"  ' ขาย

            txtSQL = txtSQL & "Dtl_LS_Q1,Dtl_LS_Q2, "   ' ยกมา
            txtSQL = txtSQL & "Dtl_Bal_Q1,Dtl_Bal_Q2,"

            txtSQL = txtSQL & "Dtl_Pen_Q1,Dtl_Pen_Q2 "
            txtSQL = txtSQL & ")"
            txtSQL = txtSQL & " Values"
            txtSQL = txtSQL & "("
            txtSQL = txtSQL & "'" & CusID & "','" & StkCode & "',"

            txtSQL = txtSQL & (OrderQ1) & "," & (((OrderQ1 * wStk))) & ","   '  จอง
            txtSQL = txtSQL & (RcvQ1) & "," & (RcvQ1 * wStk) & ","   '  ผลิต
            txtSQL = txtSQL & (IssQ1) & "," & (IssQ1 * wStk) & ","   '  ขาย

            If (RcvQ1 - IssQ1) < 0 Then
                txtSQL = txtSQL & (RcvQ1 - IssQ1) * -1 & "," & ((RcvQ1 - IssQ1) * -1) * wStk & ","  '  ยกมา
                txtSQL = txtSQL & 0 & "," & 0 & ","     '  Stock
            Else
                txtSQL = txtSQL & 0 & "," & 0 & ","  '  ยกมา
                txtSQL = txtSQL & (RcvQ1 - IssQ1) & "," & ((RcvQ1 - IssQ1) * wStk) & ","     '  Stock
            End If


            txtSQL = txtSQL & ((dbTools.getPending(CusID, StkCode) + OrderQ1) - IssQ1) & "," 'pen_q1
            txtSQL = txtSQL & (((dbTools.getPending(CusID, StkCode) + OrderQ1) - IssQ1) * wStk) & " "  '  pen

            txtSQL = txtSQL & ")"

        End If
        Call dbTools.dbSaveSQLsrv(txtSQL, "")
        subDS3 = Nothing
        subDA3 = Nothing
    End Sub

    Sub updateStkdetl(ByVal dtlType As String, ByVal dtlStr As String, ByVal dtlCode As String, ByVal dtlQty As Integer)
        Dim f As String = ""
        'Dim stkCode As String = "010103001230184000001011"
        Dim subDaZ As SqlClient.SqlDataAdapter
        Dim subDsZ As DataSet = New DataSet
        Dim iLoop As Integer = 0
        'Dim strcode As String = "110098"
        'f = dbTools.chkDtlFlag(stkcode, strcode)
        dbTools.openDB()
        txtSQL = "Select * from StkDetl "
        txtSQL = txtSQL & "where Dtl_Code='" & dtlCode & "'"
        txtSQL = txtSQL & "And Dtl_Store='" & dtlStr & "'"

        subDaZ = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDaZ.Fill(subDsZ, "DtlSet")

        Dim issQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_iSS_Q1")
        Dim rcvQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_RCV_Q1")
        Dim lsQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_LS_Q1")
        Dim orQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Or_Q1")
        Dim balQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Bal_Q1")
        Dim penQ1 As Integer = subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Pen_Q1")


        If subDsZ.Tables("DtlSet").Rows.Count > 0 Then

            txtSQL = "Update StkDetl Set "
            Select Case dtlType
                Case "S"
                    txtSQL = txtSQL & "Dtl_iss_Q1=" & issQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Pen_Q1=" & orQ1 + dtlQty - issQ1 & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 - dtlQty & " "
                Case "D"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "G"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "B"
                    txtSQL = txtSQL & "Dtl_Or_Q1=" & orQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Pen_Q1=" & orQ1 + dtlQty - issQ1 & " "

                Case "F"
                    txtSQL = txtSQL & "Dtl_RCV_Q1=" & rcvQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 + dtlQty & " "
                Case "Z"
                    txtSQL = txtSQL & "Dtl_iss_Q1=" & issQ1 + dtlQty & " "
                    txtSQL = txtSQL & "Dtl_Bal_Q1=" & lsQ1 + rcvQ1 - issQ1 - dtlQty & " "

            End Select

            txtSQL = txtSQL & "Where Dtl_Store='" & dtlStr & "' "
            txtSQL = txtSQL & "And Dtl_Code='" & dtlCode & "'"

            dbTools.dbSaveSQLsrv(txtSQL, "")
        End If
        dbTools.closeDB()

    End Sub

    Sub chkZero()
        Dim f As String = ""
        Dim stkCode As String = "010103001230184000001011"
        Dim subDaZ As SqlClient.SqlDataAdapter
        Dim subDsZ As DataSet = New DataSet
        Dim iLoop As Integer = 0
        'Dim strcode As String = "110098"
        'f = dbTools.chkDtlFlag(stkcode, strcode)
        dbTools.openDB()
        txtSQL = "Select * from StkDetl "
        txtSQL = txtSQL & "where Dtl_Code='" & stkCode & "'"
        subDaZ = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDaZ.Fill(subDsZ, "DtlSet")

        For iLoop = 0 To subDsZ.Tables("DtlSet").Rows.Count - 1

            If subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Bal_Q1") < 0 Then
                txtSQL = "Update StkDetl Set "
                txtSQL = txtSQL & "Dtl_Ls_Q1=" & subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Bal_Q1") * -1 & " "
                txtSQL = txtSQL & "Where Dtl_Store='" & subDsZ.Tables("DtlSet").Rows(iLoop).Item("Dtl_Store") & "' "
                txtSQL = txtSQL & "And Dtl_Code='" & stkCode & "'"
                dbTools.dbSaveSQLsrv(txtSQL, "")
            End If

        Next
        dbTools.closeDB()
    End Sub


    Function chkDtlFlag(ByVal stkCode As String, ByVal strCode As String) As String
        Dim txtSQL As String = ""
        Dim dr As SqlDataReader
        Dim sb As StringBuilder


        sb = New StringBuilder
        sb.Remove(0, sb.Length())
        sb.Append("Select * From StkDetl ")
        sb.Append("Where Dtl_Code=@stkCode ")
        sb.Append("And Dtl_Store=@strCode ")
        Dim sqlSearch As String
        sqlSearch = sb.ToString

        'txtSQL = "Select * From StkDetl "
        'txtSQL = txtSQL & "Where Dtl_Code='" & stkCode & "'"
        'txtSQL = txtSQL & "And Dtl_Store='" & strCode & "' "
        'txtSQL = txtSQL & "Where Dtl_Code=@stkCode "
        'txtSQL = txtSQL & "And Dtl_Store=@strCode "


        'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'If chkStkMast = True Then
        '    subDS.Tables("loopStkMast").Clear()
        '    chkStkMast = False
        'End If
        dbTools.openDB()
        With com
            .CommandText = sqlSearch
            .Parameters.Clear()
            .Parameters.Add("@stkCode", SqlDbType.NVarChar).Value = stkCode
            .Parameters.Add("@strCode", SqlDbType.NVarChar).Value = strCode
            .CommandType = CommandType.Text
            .Connection = Conn
            dr = .ExecuteReader
            If dr.HasRows Then
                dr.Close()
                dbTools.closeDB()
                Return "Edit"
            Else
                dr.Close()
                dbTools.closeDB()
                Return "Add"
            End If
        End With
    End Function

    'Public Function IsNumeric(ByVal sText As String) As Boolean
    '    Dim b As Boolean = True
    '    Dim x As Integer = 0

    '    For x = 0 To sText.Length - 1
    '        Dim sChar As String = sText.Substring(x, 1)

    '        If Asc(sChar) = 57 Then
    '            b = False
    '            Exit For
    '        End If
    '    Next

    '    Return b
    'End Function






    '=====================   Function  เสริม ใช้สอบถามค่าต่างๆ ใน DataBase ============================


End Module
