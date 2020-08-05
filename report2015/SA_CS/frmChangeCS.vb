Public Class frmChangeCS
    Private Sub frmChangeCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbCusID.Text = selCusID
        lbCusName.Text = getCusName(selCusID)
        lbCScode.Text = getCScode(selCusID)
        lbCSName.Text = getCSName(lbCScode.Text)

    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Dim frmFindCS As New frmCSMast
        frmFindCS.ShowDialog()

        lbCScode.Text = selCS 'getCScode(selCusID)
        lbCSName.Text = getCSName(lbCScode.Text)

        Me.Refresh()

    End Sub

    Private Sub cmbUpdate_Click(sender As Object, e As EventArgs) Handles cmbUpdate.Click

        txtSQL = "Update ArFile "
        txtSQL = txtSQL & "Set Ar_CS='" & lbCScode.Text & "' "
        txtSQL = txtSQL & "Where Ar_Cus_ID='" & lbCusID.Text & "' "

        dbTools.dbSaveDATA(txtSQL, "")
        MsgBox("บันทึกเรียบร้อย ")
        Me.Close()

    End Sub

    Private Sub cmbEdit_Click(sender As Object, e As EventArgs) Handles cmbEdit.Click
        Dim frmEditCus As New searchCus

        selCusID = lbCusID.Text
        frmEditCus.ShowDialog()

    End Sub
End Class