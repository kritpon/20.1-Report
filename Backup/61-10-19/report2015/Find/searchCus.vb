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
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.Button
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents dbCusGrid As System.Windows.Forms.DataGrid
    Friend WithEvents lbCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents chkCusType As System.Windows.Forms.CheckBox
    Friend WithEvents txtCusAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCusAddr As System.Windows.Forms.TextBox
    Friend WithEvents lbCusAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents lbCusTel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optFindCusName As System.Windows.Forms.RadioButton
    Friend WithEvents optCusAddr As System.Windows.Forms.RadioButton
    Friend WithEvents lbCusID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbCusGrid = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbCusTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbCusAddr2 = New System.Windows.Forms.TextBox()
        Me.lbCusAddr = New System.Windows.Forms.TextBox()
        Me.lbCusID = New System.Windows.Forms.TextBox()
        Me.lbCusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOK = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.Button()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.chkCusType = New System.Windows.Forms.CheckBox()
        Me.txtCusAdd = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optCusAddr = New System.Windows.Forms.RadioButton()
        Me.optFindCusName = New System.Windows.Forms.RadioButton()
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbCusGrid
        '
        Me.dbCusGrid.CaptionBackColor = System.Drawing.Color.SlateGray
        Me.dbCusGrid.DataMember = ""
        Me.dbCusGrid.FlatMode = True
        Me.dbCusGrid.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dbCusGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbCusGrid.Location = New System.Drawing.Point(9, 4)
        Me.dbCusGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dbCusGrid.Name = "dbCusGrid"
        Me.dbCusGrid.ReadOnly = True
        Me.dbCusGrid.Size = New System.Drawing.Size(794, 229)
        Me.dbCusGrid.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbCusTel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbCusAddr2)
        Me.GroupBox1.Controls.Add(Me.lbCusAddr)
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 231)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(795, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbCusTel
        '
        Me.lbCusTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusTel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusTel.ForeColor = System.Drawing.Color.White
        Me.lbCusTel.Location = New System.Drawing.Point(401, 76)
        Me.lbCusTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusTel.MaxLength = 60
        Me.lbCusTel.Name = "lbCusTel"
        Me.lbCusTel.Size = New System.Drawing.Size(209, 27)
        Me.lbCusTel.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(369, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tel."
        '
        'lbCusAddr2
        '
        Me.lbCusAddr2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusAddr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusAddr2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusAddr2.ForeColor = System.Drawing.Color.White
        Me.lbCusAddr2.Location = New System.Drawing.Point(130, 76)
        Me.lbCusAddr2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusAddr2.MaxLength = 60
        Me.lbCusAddr2.Name = "lbCusAddr2"
        Me.lbCusAddr2.Size = New System.Drawing.Size(209, 27)
        Me.lbCusAddr2.TabIndex = 12
        '
        'lbCusAddr
        '
        Me.lbCusAddr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusAddr.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusAddr.ForeColor = System.Drawing.Color.White
        Me.lbCusAddr.Location = New System.Drawing.Point(130, 45)
        Me.lbCusAddr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusAddr.MaxLength = 60
        Me.lbCusAddr.Name = "lbCusAddr"
        Me.lbCusAddr.Size = New System.Drawing.Size(480, 27)
        Me.lbCusAddr.TabIndex = 11
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusID.ForeColor = System.Drawing.Color.White
        Me.lbCusID.Location = New System.Drawing.Point(9, 45)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(112, 27)
        Me.lbCusID.TabIndex = 10
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(130, 15)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusName.MaxLength = 60
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(480, 27)
        Me.lbCusName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ชื่อลูกค้าที่เลือก"
        '
        'cmbOK
        '
        Me.cmbOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbOK.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.White
        Me.cmbOK.Location = New System.Drawing.Point(615, 14)
        Me.cmbOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(173, 86)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "เลือก"
        Me.cmbOK.UseVisualStyleBackColor = False
        '
        'cmbSearch
        '
        Me.cmbSearch.BackColor = System.Drawing.Color.Yellow
        Me.cmbSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSearch.ForeColor = System.Drawing.Color.Black
        Me.cmbSearch.Location = New System.Drawing.Point(547, 16)
        Me.cmbSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(240, 63)
        Me.cmbSearch.TabIndex = 9
        Me.cmbSearch.Text = "ค้นหา"
        Me.cmbSearch.UseVisualStyleBackColor = False
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusName.ForeColor = System.Drawing.Color.White
        Me.txtCusName.Location = New System.Drawing.Point(127, 16)
        Me.txtCusName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCusName.MaxLength = 60
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(308, 27)
        Me.txtCusName.TabIndex = 2
        '
        'cmbExit
        '
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.Location = New System.Drawing.Point(679, 441)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(124, 32)
        Me.cmbExit.TabIndex = 4
        Me.cmbExit.Text = "ออก"
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboType.Location = New System.Drawing.Point(440, 20)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(90, 24)
        Me.cboType.TabIndex = 5
        Me.cboType.Text = "ComboBox1"
        '
        'chkCusType
        '
        Me.chkCusType.Enabled = False
        Me.chkCusType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCusType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkCusType.Location = New System.Drawing.Point(8, 450)
        Me.chkCusType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCusType.Name = "chkCusType"
        Me.chkCusType.Size = New System.Drawing.Size(88, 22)
        Me.chkCusType.TabIndex = 6
        Me.chkCusType.Text = "ไม่ระบุ"
        '
        'txtCusAdd
        '
        Me.txtCusAdd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txtCusAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusAdd.CausesValidation = False
        Me.txtCusAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCusAdd.ForeColor = System.Drawing.SystemColors.Window
        Me.txtCusAdd.Location = New System.Drawing.Point(127, 48)
        Me.txtCusAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCusAdd.Name = "txtCusAdd"
        Me.txtCusAdd.Size = New System.Drawing.Size(307, 27)
        Me.txtCusAdd.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCusAddr)
        Me.GroupBox2.Controls.Add(Me.txtCusName)
        Me.GroupBox2.Controls.Add(Me.optFindCusName)
        Me.GroupBox2.Controls.Add(Me.txtCusAdd)
        Me.GroupBox2.Controls.Add(Me.cmbSearch)
        Me.GroupBox2.Controls.Add(Me.cboType)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 347)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(794, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลที่ต้องการ"
        '
        'optCusAddr
        '
        Me.optCusAddr.AutoSize = True
        Me.optCusAddr.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optCusAddr.Location = New System.Drawing.Point(8, 52)
        Me.optCusAddr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.optCusAddr.Name = "optCusAddr"
        Me.optCusAddr.Size = New System.Drawing.Size(105, 23)
        Me.optCusAddr.TabIndex = 13
        Me.optCusAddr.TabStop = True
        Me.optCusAddr.Text = "ค้นตามที่อยู่"
        Me.optCusAddr.UseVisualStyleBackColor = True
        '
        'optFindCusName
        '
        Me.optFindCusName.AutoSize = True
        Me.optFindCusName.Checked = True
        Me.optFindCusName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFindCusName.Location = New System.Drawing.Point(8, 24)
        Me.optFindCusName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.optFindCusName.Name = "optFindCusName"
        Me.optFindCusName.Size = New System.Drawing.Size(121, 22)
        Me.optFindCusName.TabIndex = 12
        Me.optFindCusName.TabStop = True
        Me.optFindCusName.Text = "ค้นตามชื่อลูกค้า"
        Me.optFindCusName.UseVisualStyleBackColor = True
        '
        'searchCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(819, 440)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkCusType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dbCusGrid)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "searchCus"
        Me.Text = "ค้นหาข้อมูลลูกค้า"
        CType(Me.dbCusGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Private Declare Function ActivateKeyboardLayout Lib "user32" (ByVal HKL As Long, ByVal flags As Long) As Long

    Dim chkData As Boolean = False
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As DataSet = New DataSet
    Dim Term As Integer
    Dim Sale As String
    Dim SaleID As String
    Dim Disc As String 'Double
    Dim Limit As Double


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        'dbTools.closeDB()
        Me.Close()
    End Sub
    Sub addListCBO()
        Dim dTB As New DataTable
        Dim dRow As DataRow
        chkItem = False
        'dbTools.openDB()
        'txtCusName.Focus()

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
    End Sub

    Private Sub searchCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '
        'ActivateKeyboardLayout(1, 0&)

        'Call addListCBO()


        'If optFindCusName.Checked = True Then
        '    Call showData(txtCusName.Text, "")
        'Else
        '    Call showData("", txtCusAdd.Text)
        'End If

        txtCusName.Focus() 'ใช้ร่วมกับ focus
        'txtCusName.SelectionStart = 0  'ใช้ร่วมกับ focus
        'txtCusName.SelectionLength = Len(txtCusName.Text) 'ใช้ร่วมกับ focus


    End Sub

    Sub showData(ByVal cusName As String, ByVal cusAddr As String)
        'DBtools.openDB()
        If chkData = True Then
            subDS.Tables("ARdata").Clear()
            chkData = False
        End If
        txtSQL = "SELECT ArFile.AR_TYPE, ArFile.AR_CUS_ID, ArFile.AR_NAME,"
        txtSQL = txtSQL & "(Ar_Addr + ' ' + Ar_Addr_1 + Ar_Addr_2)ar_addr0,"
        txtSQL = txtSQL & " ArFile.AR_DISC,"
        txtSQL = txtSQL & " ArFile.AR_TERM,ar_cre_lim, salesman.SL_NAME,salesman.SL_ID "

        txtSQL = txtSQL & " FROM ArFile LEFT OUTER JOIN "
        txtSQL = txtSQL & " salesman ON ArFile.AR_SALES = salesman.SL_ID "

        txtSQL = txtSQL & " Where Ar_Type='AR' "
        txtSQL = txtSQL & " And  ("
        If cusName = "" Then
            txtSQL = txtSQL & "(ar_addr + ar_addr_1 + ar_addr_2 like '%" & cusAddr & "%') "
        Else
            txtSQL = txtSQL & "(Ar_Name Like '%" & cusName & "%') "
        End If
        txtSQL = txtSQL & ") "

        txtSQL = txtSQL & " Order by Ar_Cus_ID,Ar_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
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
        Dim cusAddr As New DataGridTextBoxColumn
        Dim cusContact As New DataGridTextBoxColumn
        Dim cusTerm As New DataGridTextBoxColumn
        Dim cusSale As New DataGridTextBoxColumn
        Dim cusDisc As New DataGridTextBoxColumn
        Dim cusCreLim As New DataGridTextBoxColumn
        Dim cusSaleID As New DataGridTextBoxColumn

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
            .Width = 70
            .Alignment = HorizontalAlignment.Center
        End With

        With cusName
            .HeaderText = "ชื่อเจ้าหนี้/ลูกหนี้"
            .MappingName = "Ar_Name"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        With cusContact
            .HeaderText = "ชื่อผู้ติดต่อ"
            .MappingName = "Ar_Contact"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 100
            .Alignment = HorizontalAlignment.Left
        End With
        With cusAddr
            .HeaderText = "ที่อยู่"
            .MappingName = "Ar_Addr0"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 250
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

        With cusCreLim
            .HeaderText = "เครดิตลิมิต"
            .MappingName = "Ar_cre_lim"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 70
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

        With cusSaleID
            .HeaderText = "" 'รหัสsale
            .MappingName = "SL_ID"
            .NullText = "ไม่ได้ระบุไว้"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Left
        End With

        grdTS.GridColumnStyles.Add(cusID)
        grdTS.GridColumnStyles.Add(cusName)
        grdTS.GridColumnStyles.Add(cusContact)
        grdTS.GridColumnStyles.Add(cusAddr)
        grdTS.GridColumnStyles.Add(cusTerm)
        grdTS.GridColumnStyles.Add(cusCreLim)
        grdTS.GridColumnStyles.Add(cusSale)
        grdTS.GridColumnStyles.Add(cusDisc)
        grdTS.GridColumnStyles.Add(cusSaleID)

        With dbCusGrid
            .TableStyles.Clear()
            .CaptionText = "ค้นหา ลูกหนี้-เจ้าหนี้ "
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub

    Private Sub cmbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.Click

        If optFindCusName.Checked = True Then
            Call showData(txtCusName.Text, "")
        Else
            Call showData("", txtCusAdd.Text)
        End If

        'txtCusName.Focus()
    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        Call OK2()
    End Sub
    Sub OK2()
        Dim amt1 As Double
        'Dim amt2 As Double
        Dim Nine As Double
        'Dim Cre As Double
        Dim Lock01 As Integer
        subDS.Clear()
        txtSQL = " SELECT ArFile.AR_CUS_ID, ArFile.AR_NAME, ArFile.AR_Lock, "
        txtSQL = txtSQL & "ArFile.AR_DISC, ArFile.AR_CRE_LIM,"
        txtSQL = txtSQL & "(arfile.ar_cre_lim * 90)/100 AS Ninety "

        txtSQL = txtSQL & "FROM ArFile "
        'txtSQL = txtSQL & "LEFT OUTER JOIN"
        'txtSQL = txtSQL & "ArDetail ON ArFile.AR_CUS_ID = ArDetail.ARD_CUS"

        txtSQL = txtSQL & "WHERE (ArFile.AR_TYPE = N'ar') "
        txtSQL = txtSQL & "And ArFile.AR_cus_id='" & lbCusID.Text & "' "

        'txtSQL = txtSQL & "And LEFT(ardetail.ARD_Date, 4) >= '2000' "
        'txtSQL = txtSQL & "AND (ardetail.Ard_Slmn <> 'SL03') "
        'txtSQL = txtSQL & "AND (ardetail.ard_amt <> '0') "

        txtSQL = txtSQL & "GROUP BY ArFile.AR_CUS_ID, ArFile.AR_NAME, ArFile.AR_Lock, ArFile.AR_DISC, ArFile.AR_CRE_LIM"

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "ARCheck")


        If (subDS.Tables("ARCheck").Rows.Count = 0) Then
            amt1 = 0 '
            Nine = 0
        Else
            amt1 = subDS.Tables("ARCheck").Rows(0).Item("ar_cre_lim")
            Nine = 0 'subDS.Tables("ARCheck").Rows(0).Item("Ninety")

            If IsDBNull(subDS.Tables("ARCheck").Rows(0).Item("ar_lock")) Then

                Lock01 = 0
                txtSQL = "Update ArFile set Ar_Lock=0 "
                txtSQL = txtSQL & "Where Ar_Cus_iD='" & lbCusID.Text & "' "
                DBtools.dbSaveDATA(txtSQL, "")

            Else
                Lock01 = 0 'subDS.Tables("ARCheck").Rows(0).Item("ar_lock")
            End If


        End If
     
     
        If Lock01 = 0 Then  ' unlock 

            PId = lbCusID.Text
            selCusiD = lbCusID.Text
            'selCusiD()
            PName = lbCusName.Text
            CusId = lbCusID.Text
            'selCusiD = lbCusID.Text
            CusName = lbCusName.Text
            CusCreTerm = Term
            CusSaleName = Sale
            CusSaleID = SaleID
            CusDiscount = Disc
            CusLimit = Limit
            Term = 0
            Sale = ""
            SaleID = ""
            Disc = 0.0
            Limit = 0.0

        ElseIf Lock01 = 1 Then ' lock 

            MsgBox("ลูกค้ารายนี้ไม่สามารถเปิดบิลได้ ! ", MsgBoxStyle.Critical, "แจ้งให้ทราบ")
            PId = ""
            PName = ""
            CusId = ""
            CusName = ""
            CusCreTerm = 0
            CusSaleName = ""
            CusSaleID = ""
            selCusiD = ""
            CusDiscount = 0.0
            CusLimit = 0.0
            Term = 0
            Sale = ""
            SaleID = ""
            Disc = 0.0
            Limit = 0.0
            'ElseIf amt1 < amt2 And Lock01 = 1 Then 'หนี้มากกกว่าเครดิต และโดน lock
            '    MsgBox("ไม่สามารถเปิดบิลให้ลูกค้ารายนี้ได้ เนื่องจากมียอดหนี้เกินวงเงินเครดิต กรุณาติดต่อแผนกบัญชี", MsgBoxStyle.OkOnly, "แจ้งให้ทราบ")
            '    PId = ""
            '    PName = ""
            '    CusId = ""
            '    CusName = ""
            '    CusCreTerm = 0
            '    selCusiD = ""
            '    CusSaleName = ""
            '    CusSaleID = ""
            '    CusDiscount = 0.0
            '    CusLimit = 0.0
            '    Term = 0
            '    Sale = ""
            '    SaleID = ""
            '    Disc = 0.0
            '    Limit = 0.0
            'ElseIf amt1 < amt2 And Lock01 = 0 Then 'หนี้มากกว่าเครดิต แต่ถูกปลดlock
            '    PId = lbCusID.Text
            '    PName = lbCusName.Text
            '    CusId = lbCusID.Text
            '    selCusiD = lbCusID.Text
            '    CusName = lbCusName.Text
            '    CusCreTerm = Term
            '    CusSaleName = Sale
            '    CusSaleID = SaleID
            '    CusDiscount = Disc
            '    CusLimit = Limit
            '    Term = 0
            '    Sale = ""
            '    SaleID = ""
            '    Disc = 0.0
            '    Limit = 0.0
            'ElseIf amt1 = amt2 = 0 Then

            '    PId = lbCusID.Text
            '    PName = lbCusName.Text
            '    CusId = lbCusID.Text
            '    CusName = lbCusName.Text
            '    CusCreTerm = Term
            '    CusSaleName = Sale
            '    CusSaleID = SaleID
            '    CusDiscount = Disc
            '    Term = 0
            '    Sale = ""
            '    SaleID = ""
            '    Disc = 0.0
            '    Limit = 0.0
        End If

        Me.Close()
    End Sub
    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        If e.KeyCode = 13 Then
            If optFindCusName.Checked = True Then
                Call showData(txtCusName.Text, "")
            Else
                Call showData("", txtCusAdd.Text)
            End If
            dbCusGrid.Focus()
        End If
    End Sub

    Private Sub cboType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.SelectedValueChanged
        If cboType.Text = "" Then Exit Sub
        If optFindCusName.Checked = True Then
            Call showData(txtCusName.Text, "")
        Else
            Call showData("", txtCusAdd.Text)
        End If
    End Sub

    Private Sub dbCusGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbCusGrid.CurrentCellChanged
        Dim rowSel As Integer

        rowSel = dbCusGrid.CurrentRowIndex
        If rowSel < 0 Then Exit Sub

        lbCusID.Text = Convert.ToString(dbCusGrid.Item(rowSel, 0))
        lbCusName.Text = Convert.ToString(dbCusGrid.Item(rowSel, 1))
        lbCusAddr.Text = DBtools.getArAddrFull(lbCusID.Text)
        lbCusAddr2.Text = ""
        lbCusTel.Text = ""

        'Term = (dbCusGrid.Item(rowSel, 3))
        'If Term = 0 Then
        '    MsgBox("เครดิตเป็น 0 กรุณาตรวจสอบด้วย", MsgBoxStyle.OKOnly, "แจ้งให้ทราบ")
        'Else
        'End If
        Sale = Convert.ToString(dbCusGrid.Item(rowSel, 6))
        SaleID = Convert.ToString(dbCusGrid.Item(rowSel, 8))
        Disc = Convert.ToString(dbCusGrid.Item(rowSel, 7))
        Limit = Convert.ToString(dbCusGrid.Item(rowSel, 5))




    End Sub


  

    Private Sub txtCusName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusName.TextChanged
        optFindCusName.Checked = True

    End Sub

    Private Sub txtCusAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            If optFindCusName.Checked = True Then
                Call showData(txtCusName.Text, "")
            Else
                Call showData("", txtCusAdd.Text)
            End If
        End If
    End Sub

    Private Sub txtCusAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusAdd.TextChanged

        optCusAddr.Checked = True

    End Sub

    Private Sub dbCusGrid_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dbCusGrid.Navigate

    End Sub
End Class
