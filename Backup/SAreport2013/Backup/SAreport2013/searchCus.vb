Public Class searchCus
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.Button
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents dbCusGrid As System.Windows.Forms.DataGrid
    Friend WithEvents lbCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents chkCusType As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbCusGrid = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbCusID = New System.Windows.Forms.Label
        Me.lbCusName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbOK = New System.Windows.Forms.Button
        Me.cmbSearch = New System.Windows.Forms.Button
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbExit = New System.Windows.Forms.Button
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.chkCusType = New System.Windows.Forms.CheckBox
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbCusGrid
        '
        Me.dbCusGrid.CaptionBackColor = System.Drawing.Color.SlateGray
        Me.dbCusGrid.DataMember = ""
        Me.dbCusGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbCusGrid.Location = New System.Drawing.Point(8, 0)
        Me.dbCusGrid.Name = "dbCusGrid"
        Me.dbCusGrid.Size = New System.Drawing.Size(592, 248)
        Me.dbCusGrid.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Turquoise
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(96, 16)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(65, 21)
        Me.lbCusID.TabIndex = 10
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.PowderBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbCusName.Location = New System.Drawing.Point(160, 16)
        Me.lbCusName.MaxLength = 60
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(344, 21)
        Me.lbCusName.TabIndex = 8
        Me.lbCusName.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ชื่อลูกค้าที่เลือก"
        '
        'cmbOK
        '
        Me.cmbOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbOK.Location = New System.Drawing.Point(512, 16)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(72, 21)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "เลือก"
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSearch.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbSearch.Location = New System.Drawing.Point(424, 256)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(72, 21)
        Me.cmbSearch.TabIndex = 9
        Me.cmbSearch.Text = "ค้นหา"
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCusName.Location = New System.Drawing.Point(88, 256)
        Me.txtCusName.MaxLength = 60
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(328, 21)
        Me.txtCusName.TabIndex = 6
        Me.txtCusName.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(16, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชื่อที่ต้องการ"
        '
        'cmbExit
        '
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.cmbExit.Location = New System.Drawing.Point(520, 336)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(72, 24)
        Me.cmbExit.TabIndex = 4
        Me.cmbExit.Text = "Exit"
        '
        'cboType
        '
        Me.cboType.Location = New System.Drawing.Point(512, 256)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(88, 21)
        Me.cboType.TabIndex = 5
        Me.cboType.Text = "ComboBox1"
        '
        'chkCusType
        '
        Me.chkCusType.Enabled = False
        Me.chkCusType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCusType.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.chkCusType.Location = New System.Drawing.Point(8, 336)
        Me.chkCusType.Name = "chkCusType"
        Me.chkCusType.Size = New System.Drawing.Size(56, 24)
        Me.chkCusType.TabIndex = 6
        Me.chkCusType.Text = "ไม่ระบุ"
        '
        'searchCus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(608, 381)
        Me.Controls.Add(Me.chkCusType)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dbCusGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.cmbSearch)
        Me.Name = "searchCus"
        Me.Text = "ค้นหาข้อมูลเจ้าหนี้"
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
   
    Dim chkData As Boolean = False
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As DataSet = New DataSet
    Dim Term As Integer
    Dim Sale As String
    Dim Disc As Double


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        'dbTools.closeDB()
        Me.Close()
    End Sub

    Private Sub searchCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dTB As New DataTable
        Dim dRow As DataRow
        'Dim i As Integer

        'dbTools.openDB()

        dTB.Columns.Add(New DataColumn("T_Type", GetType(String)))
        dTB.Columns.Add(New DataColumn("T_Name", GetType(String)))

        dRow = dTB.NewRow
        dRow(0) = "AP"
        dRow(1) = "เจ้าหนี้"
        dTB.Rows.Add(dRow)

        dRow = dTB.NewRow
        dRow(0) = "AR"
        dRow(1) = "ลูกหนี้"
        dTB.Rows.Add(dRow)


        With cboType
            .DataSource = dTB
            .DisplayMember = "T_Name"
            .ValueMember = "T_Type"
        End With
        cboType.SelectedIndex = 1
        Call showData("")


    End Sub

    Sub showData(ByVal cusName As String)
        'dbTools.openDB()
        If chkData = True Then
            subDS.Tables("ARdata").Clear()
            chkData = False
        End If
        txtSQL = "  SELECT     ArFile.AR_TYPE, ArFile.AR_CUS_ID, ArFile.AR_NAME, "
        txtSQL = txtSQL & "ArFile.AR_DISC, ArFile.AR_TERM, salesman.SL_NAME "

        txtSQL = txtSQL & "FROM ArFile LEFT OUTER JOIN Salesman "
        txtSQL = txtSQL & "ON ArFile.AR_SALES = salesman.SL_ID "

        txtSQL = txtSQL & "Where Ar_Type='" & Convert.ToString(cboType.SelectedValue) & "' "
        txtSQL = txtSQL & "And  (Ar_Name Like '%" & cusName & "%') "
        txtSQL = txtSQL & "Order by Ar_Cus_ID,Ar_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSql, Conn)
        subDA.Fill(subDS, "ARdata")
        chkData = True
        dbCusGrid.DataSource = subDS.Tables("ARdata")
        Call frmSticGrd()
        'subDA = Nothing
        'subDS = Nothing
        'dbTools.closeDB()


    End Sub

    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim cusID As New DataGridTextBoxColumn
        Dim cusName As New DataGridTextBoxColumn
        Dim cusContact As New DataGridTextBoxColumn
        Dim cusTerm As New DataGridTextBoxColumn
        Dim cusSale As New DataGridTextBoxColumn
        Dim cusDisc As New DataGridTextBoxColumn

        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "ARdata"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With cusID
            .HeaderText = "รหัส เจ้าหนี้/ลูกหนี้"
            .MappingName = "Ar_Cus_ID"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 100
            .Alignment = HorizontalAlignment.Center
        End With

        With cusName
            .HeaderText = "ชื่อเจ้าหนี้/ลูกหนี้"
            .MappingName = "Ar_Name"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 220
            .Alignment = HorizontalAlignment.Left
        End With

        With cusContact
            .HeaderText = "ชื่อผู้ติดต่อ"
            .MappingName = "Ar_Contact"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 150
            .Alignment = HorizontalAlignment.Left
        End With

        With cusTerm
            .HeaderText = "เครดิตเทอม"
            .MappingName = "Ar_Term"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Left
        End With

        With cusSale
            .HeaderText = "Sale"
            .MappingName = "sl_name"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 120
            .Alignment = HorizontalAlignment.Left
        End With

        With cusDisc
            .HeaderText = "ส่วนลดลูกค้า"
            .MappingName = "Ar_Disc"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Left
        End With

        grdTS.GridColumnStyles.Add(cusID)
        grdTS.GridColumnStyles.Add(cusName)
        grdTS.GridColumnStyles.Add(cusContact)
        grdTS.GridColumnStyles.Add(cusTerm)
        grdTS.GridColumnStyles.Add(cusSale)
        grdTS.GridColumnStyles.Add(cusDisc)
        With dbCusGrid
            .TableStyles.Clear()
            .CaptionText = "ค้นหา ลูกหนี้-เจ้าหนี้ "
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub

    Private Sub cmbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.Click
        Call showData(txtCusName.Text)
    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        Dim amt1 As Double
        Dim amt2 As Double
        Dim Nine As Double
        'Dim Cre As Double
        Dim Lock01 As Integer
        subDS.Clear()
        txtSql = " SELECT     ArFile.AR_CUS_ID, ArFile.AR_NAME, ArFile.AR_Lock, ArFile.AR_DISC, ArFile.AR_CRE_LIM, SUM(ArDetail.ARD_AMT) AS sum, (arfile.ar_cre_lim * 90)/100 AS Ninety "
        txtSql = txtSql & " FROM         ArFile LEFT OUTER JOIN"
        txtSql = txtSql & " ArDetail ON ArFile.AR_CUS_ID = ArDetail.ARD_CUS"
        txtSql = txtSql & "  WHERE     (ArFile.AR_TYPE = N'ar') AND (ardetail.Ard_Slmn <> 'SL03') AND LEFT(ardetail.ARD_Date, 4) >= '2000' AND (ardetail.ard_amt <> '0') and arfile.ar_cus_id='" & lbCusID.Text & "'"
        txtSql = txtSql & " GROUP BY ArFile.AR_CUS_ID, ArFile.AR_NAME, ArFile.AR_Lock, ArFile.AR_DISC, ArFile.AR_CRE_LIM"

        subDA = New SqlClient.SqlDataAdapter(txtSql, Conn)
        subDA.Fill(subDS, "ARCheck")
        If subDS.Tables("ARCheck").Rows.Count > 0 Then
            amt1 = subDS.Tables("ARCheck").Rows(0).Item("ar_cre_lim")
            amt2 = subDS.Tables("ARCheck").Rows(0).Item("sum")
            Nine = subDS.Tables("ARCheck").Rows(0).Item("Ninety")
            Lock01 = subDS.Tables("ARCheck").Rows(0).Item("ar_lock")
            PId = lbCusID.Text
            PName = lbCusName.Text
            CusId = lbCusID.Text
            CusName = lbCusName.Text
            '    If amt1 > amt2 And Lock01 = 0 Then  'หนี้น้อยกว่าวงเงิน

            '        CusCreTerm = Term
            '        CusSaleName = Sale
            '        CusDiscount = Disc
            '        Term = 0
            '        Sale = ""
            '        Disc = 0.0
            '    ElseIf amt1 > amt2 And Lock01 = 1 Then 'เนื่องจากว่ายังไม่ได้เอายอดหนี้ใน businessรวมกับใน SA จึงทำให้มีcaseแบบนี้เกิดขึ้น ถ้าทำให้รวมกันแล้วสามารถเอาออกได้
            '        MsgBox("ไม่สามารถเปิดบิลให้ลูกค้ารายนี้ได้ เนื่องจากมียอดหนี้เกินวงเงินเครดิต กรุณาติดต่อแผนกบัญชี", MsgBoxStyle.OKOnly, "แจ้งให้ทราบ")
            '        PId = ""
            '        PName = ""
            '        CusId = ""
            '        CusName = ""
            '        CusCreTerm = 0
            '        CusSaleName = ""
            '        CusDiscount = 0.0
            '        Term = 0
            '        Sale = ""
            '        Disc = 0.0
            '    ElseIf amt1 < amt2 And Lock01 = 1 Then 'หนี้มากกกว่าเครดิต และโดน lock
            '        MsgBox("ไม่สามารถเปิดบิลให้ลูกค้ารายนี้ได้ เนื่องจากมียอดหนี้เกินวงเงินเครดิต กรุณาติดต่อแผนกบัญชี", MsgBoxStyle.OKOnly, "แจ้งให้ทราบ")
            '        PId = ""
            '        PName = ""
            '        CusId = ""
            '        CusName = ""
            '        CusCreTerm = 0
            '        CusSaleName = ""
            '        CusDiscount = 0.0
            '        Term = 0
            '        Sale = ""
            '        Disc = 0.0
            '    ElseIf amt1 < amt2 And Lock01 = 0 Then 'หนี้มากกว่าเครดิต แต่ถูกปลดlock
            '        PId = lbCusID.Text
            '        PName = lbCusName.Text
            '        CusId = lbCusID.Text
            '        CusName = lbCusName.Text
            '        CusCreTerm = Term
            '        CusSaleName = Sale
            '        CusDiscount = Disc
            '        Term = 0
            '        Sale = ""
            '        Disc = 0.0
            '    End If
        Else 'recordcount<=0 'ไม่มีใน ardetail
            PId = lbCusID.Text
            PName = lbCusName.Text
            CusId = lbCusID.Text
            CusName = lbCusName.Text
            CusCreTerm = Term
            CusSaleName = Sale
            CusDiscount = Disc
            Term = 0
            Sale = ""
            Disc = 0.0

        End If



        Me.Close()
    End Sub

    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = 13 Then
            Call showData(txtCusName.Text)
        End If
    End Sub

    Private Sub cboType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedValueChanged
        If cboType.Text = "" Then Exit Sub
        Call showData("")
    End Sub

    Private Sub dbCusGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbCusGrid.CurrentCellChanged
        Dim rowSel As Integer

        rowSel = dbCusGrid.CurrentRowIndex
        If rowSel < 0 Then Exit Sub
        lbCusID.Text = Convert.ToString(dbCusGrid.Item(rowSel, 0))
        lbCusName.Text = Convert.ToString(dbCusGrid.Item(rowSel, 1))
        Term = (dbCusGrid.Item(rowSel, 3))
        If Term = 0 Then
            MsgBox("เครดิตเป็น 0 กรุณาตรวจสอบด้วย", MsgBoxStyle.OKOnly, "แจ้งให้ทราบ")
        Else
        End If
        Sale = Convert.ToString(dbCusGrid.Item(rowSel, 4))
        Disc = Convert.ToDouble(dbCusGrid.Item(rowSel, 5))
    End Sub

   
End Class
