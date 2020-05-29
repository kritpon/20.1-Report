Public Class frmSetSales

    Private Sub frmSetSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbID.Text = selSale
        lbName.Text = getSaleName(selSale)
        txtKPI.Text = getSaleKPI(selSale)

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If IsNumeric(txtKPI.Text) Then
            txtSQL = "Update SalesMan Set SL_Target='" & txtKPI.Text & "' "
            txtSQL = txtSQL & "Where SL_ID='" & lbID.Text & "' "
            dbTools.dbSaveSQLsrv(txtSQL, "")

            MsgBox("update เรียบร้อย", MsgBoxStyle.OkOnly, "แจ้งเตือน")
            Me.Close()

        Else
            MsgBox("KPI ที่ใส่ไม่ถูกต้อง โปรดตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class