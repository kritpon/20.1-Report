Module cusTools

    Function getArAddrFull(ByVal ar_Code As String) As String

        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "

        txtSQL = txtSQL & "WHERE (((ArFile.AR_Cus_ID) Like '%" & ar_Code & "%'))"
        txtSQL = txtSQL & "And (Ar_Type='AR') "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "ARList")

        ans = subDS.Tables("ARList").Rows(0).Item("Ar_Addr") & " " & subDS.Tables("ARList").Rows(0).Item("Ar_Addr_1") & " " & subDS.Tables("ARList").Rows(0).Item("Ar_Addr_2")
        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function


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

    Function getCusVatType(ByVal cusId As String) As String

        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Try
            txtSQL = "Select Ar_Cus_ID,Ar_Vat_Type "
            txtSQL = txtSQL & "From ArFile "

            txtSQL = txtSQL & "WHERE (ArFile.AR_Cus_ID='" & cusId & "')"
            txtSQL = txtSQL & "And (Ar_Type='AR') "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "ARList")

            ans = subDS.Tables("ARList").Rows(0).Item("Ar_Vat_Type")
            subDS = Nothing
            subDA = Nothing
            Return ans
        Catch ex As Exception
            Return ""
        End Try


    End Function

    Function getCusIDbyDoc(ByVal DocNo As String, ByVal DocType As String) As String
        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        If Trim(DocNo) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return False
        Else
            'dbTools.openDB()
            txtSQL = "Select * "
            txtSQL = txtSQL & "From TranDataH "

            txtSQL = txtSQL & "WHERE ((Trh_Type='" & DocType & "') "
            txtSQL = txtSQL & "And (Trh_No='" & DocNo & "')) "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "NoList")

            If subDS.Tables("NoList").Rows.Count > 0 Then
                ans = subDS.Tables("NoList").Rows(0).Item("Trh_Cus")
            Else
                ans = ""
            End If

            subDS = Nothing
            subDA = Nothing
            'dbTools.closeDB()
            Return ans
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


    Function getSaleCode(ByVal saleName As String) As String
        Dim ans As String
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From salesman "
        txtSQL = txtSQL & "WHERE SL_Name='" & saleName & "'"
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "slList")

        If subDS.Tables("slList").Rows.Count - 1 < 0 Then
            ans = ""
        Else
            ans = subDS.Tables("slList").Rows(0).Item("sl_ID")
        End If

        subDS = Nothing
        subDA = Nothing
        Return ans

    End Function

    Function getCSName(ByVal strCScode As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        'dbTools.openDB()
        If Trim(strCScode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From CSmast "

            txtSQL = txtSQL & "WHERE ((CS_Code='" & strCScode & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "strList")

            ans = subDS.Tables("strList").Rows(0).Item("cs_name")

            ' dbTools.closeDB()
            If subDS.Tables("strList").Rows.Count > 0 Then
                subDS = Nothing
                subDA = Nothing
                Return ans
            Else
                Return ""
            End If

        End If

    End Function


    Function getCScode(ByVal strArCode As String) As String

        Dim ans As String

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        'dbTools.openDB()
        If Trim(strArCode) = "" Then
            subDS = Nothing
            subDA = Nothing
            Return ""
        Else
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ArFile "

            txtSQL = txtSQL & "WHERE ((Ar_Cus_ID='" & strArCode & "'))"

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA.Fill(subDS, "strList")

            ' dbTools.closeDB()
            If subDS.Tables("strList").Rows.Count > 0 Then

                ans = subDS.Tables("strList").Rows(0).Item("AR_CS")
                subDS = Nothing
                subDA = Nothing
                Return ans
            Else
                Return ""
            End If

        End If


    End Function

End Module
