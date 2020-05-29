Public Class frmFindWH
    Dim chkData As Boolean
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As DataSet = New DataSet

    Sub showData()

        If chkData = True Then
            subDS.Tables("WHdata").Clear()
            chkData = False
        End If


        txtSQL = "SELECT * "
        txtSQL = txtSQL & " FROM  wareHouse "
        txtSQL = txtSQL & "where wh_type='DC' "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "WHdata")
        chkData = True
        dataShow.DataSource = subDS.Tables("WHdata")

        Call frmSticGrd()


    End Sub
    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim whID As New DataGridTextBoxColumn
        Dim whNameF As New DataGridTextBoxColumn
        Dim whName As New DataGridTextBoxColumn

        With grdTS
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.LightSkyBlue
            .ForeColor = Color.Navy
            .MappingName = "WHdata"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With whID
            .HeaderText = "รหัสคลัง"
            .MappingName = "WH_ID"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 55
            .Alignment = HorizontalAlignment.Center
        End With

        With whNameF
            .HeaderText = "ชื่อคลังสินค้า"
            .MappingName = "Wh_Desc"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        With whName
            .HeaderText = "ชื่อย่อย"
            .MappingName = "WH_Name"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Right
        End With


        grdTS.GridColumnStyles.Add(whID)
        grdTS.GridColumnStyles.Add(whNameF)
        grdTS.GridColumnStyles.Add(whName)

        With dataShow
            .TableStyles.Clear()
            .CaptionText = "ค้นหา คลังสินค้า"
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub

    Private Sub frmFindWH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call showData()
    End Sub

    Private Sub dataShow_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataShow.CurrentCellChanged
        Dim rowSel As Integer

        rowSel = dataShow.CurrentRowIndex
        If rowSel < 0 Then Exit Sub

        lbWHID.Text = Convert.ToString(dataShow.Item(rowSel, 0))
        lbWHName.Text = Convert.ToString(dataShow.Item(rowSel, 1))

    End Sub

  
    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click

        selWH = lbWHID.Text
        lbWHID.Text = ""
        lbWHName.Text = ""

        Me.Close()

    End Sub
End Class