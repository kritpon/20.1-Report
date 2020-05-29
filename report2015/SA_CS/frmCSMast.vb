Public Class frmCSMast
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet

    Dim chkData As Boolean = False
    Dim CS_id As String = ""
    Dim cs_Name As String = ""

    Sub fmtListView()

        lsvCS.Columns.Add("ID.", 80, HorizontalAlignment.Center) '0
        lsvCS.Columns.Add("Name", 200, HorizontalAlignment.Left) '1
        'lsvMap.Columns.Add("Order No.", 480, HorizontalAlignment.Left) '2
        lsvCS.View = View.Details
        lsvCS.GridLines = True

    End Sub

    Function chkDataCS(ByVal csCode As String) As Boolean
        Dim subDS As New DataSet
        Dim subDA As SqlClient.SqlDataAdapter

        txtSQL = "Select * "
        txtSQL = txtSQL & "From CSMast "
        txtSQL = txtSQL & "Where CS_Code='" & csCode & "'"


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")

        If subDS.Tables("master").Rows.Count > 0 Then
            Return True

        Else
            Return False
        End If



    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtCode.Text = "" Then
            MsgBox("ข้อมูลรหัสมีปัญหา โปรดตรวจสอบ ")
            Exit Sub
        Else
            CS_id = txtCode.Text
        End If
        If txtName.Text = "" Then
            MsgBox("ข้อมูลชื่อสินค้ามีปัญหา โปรดตรวจสอบ ")
            Exit Sub
        Else
            cs_Name = txtName.Text
        End If

        If chkDataCS(CS_id) = True Then

            txtSQL = "Update csMast "
            txtSQL = txtSQL & "set cs_Name='" & cs_Name & "',"
            txtSQL = txtSQL & "CS_update='" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "' "
            txtSQL = txtSQL & "Where cs_Code='" & CS_id & "' "

        Else

            txtSQL = "Insert Into CSMast "
            txtSQL = txtSQL & "Values("
            txtSQL = txtSQL & "'" & CS_id & "',"
            txtSQL = txtSQL & "'" & cs_Name & "',"
            txtSQL = txtSQL & "'" & (Format(DateAdd(DateInterval.Year, -543, Now), "MM/dd/yyyy")) & "' "
            txtSQL = txtSQL & ")"
        End If

        DBtools.dbSaveDATA(txtSQL, "")
        Call showDATA()
        Call clsText()

    End Sub

    Sub clsText()
        txtCode.Text = ""
        txtName.Text = ""


    End Sub

    Sub showDATA()

        Dim strID As String
        Dim strName As String

        Dim anydata() As String
        Dim lvi As ListViewItem
        Dim i As Integer


        txtSQL = "Select * "
        txtSQL = txtSQL & "From CSMast "
        txtSQL = txtSQL & "Order by CS_Code "

        If chkData = True Then
            subDS.Tables("Detail").Clear()
            chkData = False
        End If

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "Detail")
        chkData = True
        lsvCS.Items.Clear()

        For i = 0 To subDS.Tables("Detail").Rows.Count - 1
            With subDS.Tables("Detail").Rows(i)

                strID = .Item("CS_Code")
                strName = .Item("CS_Name")


                anydata = New String() {strID, strName}
                lvi = New ListViewItem(anydata)
                lsvCS.Items.Add(lvi)

            End With

        Next

    End Sub

    Private Sub frmCSMast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBtools.openDB()
        Call fmtListView()
        showDATA()

    End Sub

    Private Sub cmdSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSel.Click

        selCS = txtCode.Text
        Me.Close()

    End Sub

    Private Sub lsvCS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvCS.SelectedIndexChanged
        Dim cs_ID As String
        Dim cs_Name As String

        Dim LsvItem As ListViewItem
        Dim i As Integer = 0

        For i = 0 To lsvCS.SelectedItems.Count - 1

            LsvItem = lsvCS.SelectedItems(i)
            CS_id = lsvCS.Items(LsvItem.Index).SubItems(0).Text 'รหัส
            cs_Name = lsvCS.Items(LsvItem.Index).SubItems(1).Text ' ชือ่


            txtCode.Text = CS_id
            txtName.Text = cs_Name


        Next

    End Sub

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()

    End Sub

    Private Sub cmbDel_Click(sender As Object, e As EventArgs) Handles cmbDel.Click

    End Sub
End Class