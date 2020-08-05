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
    Friend WithEvents optFindCusName As System.Windows.Forms.RadioButton
    Friend WithEvents optCusAddr As System.Windows.Forms.RadioButton
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLineID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSave As Button
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbCusID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbCusGrid = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.cmbSave = New System.Windows.Forms.Button()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtLineID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCusAddr = New System.Windows.Forms.TextBox()
        Me.lbCusID = New System.Windows.Forms.TextBox()
        Me.lbCusName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOK = New System.Windows.Forms.Button()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.Button()
        Me.txtCusName = New System.Windows.Forms.TextBox()
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
        Me.dbCusGrid.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbCusGrid.DataMember = ""
        Me.dbCusGrid.FlatMode = True
        Me.dbCusGrid.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.dbCusGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbCusGrid.Location = New System.Drawing.Point(9, 4)
        Me.dbCusGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dbCusGrid.Name = "dbCusGrid"
        Me.dbCusGrid.ReadOnly = True
        Me.dbCusGrid.Size = New System.Drawing.Size(1006, 229)
        Me.dbCusGrid.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbExit)
        Me.GroupBox1.Controls.Add(Me.cmbSave)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.txtLineID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbCusAddr)
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(222, 231)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(795, 248)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(615, 190)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(171, 42)
        Me.cmbExit.TabIndex = 4
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'cmbSave
        '
        Me.cmbSave.BackColor = System.Drawing.Color.Green
        Me.cmbSave.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSave.ForeColor = System.Drawing.Color.White
        Me.cmbSave.Location = New System.Drawing.Point(615, 107)
        Me.cmbSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(173, 72)
        Me.cmbSave.TabIndex = 63
        Me.cmbSave.Text = "Save"
        Me.cmbSave.UseVisualStyleBackColor = False
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.YellowGreen
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(128, 115)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContact.MaxLength = 255
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(422, 26)
        Me.txtContact.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 35)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "ผู้ติดต่อ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.YellowGreen
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(128, 210)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.MaxLength = 255
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 26)
        Me.txtEmail.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(74, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "e-Mail"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.YellowGreen
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.ForeColor = System.Drawing.Color.Black
        Me.txtFax.Location = New System.Drawing.Point(384, 149)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFax.MaxLength = 255
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(167, 26)
        Me.txtFax.TabIndex = 60
        '
        'txtLineID
        '
        Me.txtLineID.BackColor = System.Drawing.Color.YellowGreen
        Me.txtLineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLineID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLineID.ForeColor = System.Drawing.Color.Black
        Me.txtLineID.Location = New System.Drawing.Point(384, 182)
        Me.txtLineID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLineID.MaxLength = 255
        Me.txtLineID.Name = "txtLineID"
        Me.txtLineID.Size = New System.Drawing.Size(167, 26)
        Me.txtLineID.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(328, 186)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "line ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(328, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Fax"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.YellowGreen
        Me.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.Color.Black
        Me.txtMobile.Location = New System.Drawing.Point(128, 179)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMobile.MaxLength = 255
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(167, 26)
        Me.txtMobile.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(74, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "มือถือ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusAddr
        '
        Me.lbCusAddr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbCusAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusAddr.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusAddr.ForeColor = System.Drawing.Color.Black
        Me.lbCusAddr.Location = New System.Drawing.Point(128, 46)
        Me.lbCusAddr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusAddr.MaxLength = 60
        Me.lbCusAddr.Multiline = True
        Me.lbCusAddr.Name = "lbCusAddr"
        Me.lbCusAddr.ReadOnly = True
        Me.lbCusAddr.Size = New System.Drawing.Size(480, 59)
        Me.lbCusAddr.TabIndex = 11
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusID.ForeColor = System.Drawing.Color.White
        Me.lbCusID.Location = New System.Drawing.Point(9, 37)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(112, 27)
        Me.lbCusID.TabIndex = 10
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbCusName.ForeColor = System.Drawing.Color.Black
        Me.lbCusName.Location = New System.Drawing.Point(128, 15)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusName.MaxLength = 60
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.ReadOnly = True
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
        Me.Label2.Text = "ชื่อลูกค้า"
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
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.YellowGreen
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Location = New System.Drawing.Point(128, 148)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTel.MaxLength = 255
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(167, 26)
        Me.txtTel.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(92, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Tel"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.chkCusType.Location = New System.Drawing.Point(950, 573)
        Me.chkCusType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkCusType.Name = "chkCusType"
        Me.chkCusType.Size = New System.Drawing.Size(64, 22)
        Me.chkCusType.TabIndex = 6
        Me.chkCusType.Text = "เฉพาะ"
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
        Me.GroupBox2.Location = New System.Drawing.Point(221, 483)
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
        Me.optCusAddr.Size = New System.Drawing.Size(103, 23)
        Me.optCusAddr.TabIndex = 13
        Me.optCusAddr.TabStop = True
        Me.optCusAddr.Text = "หาตามที่อยู่"
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
        Me.optFindCusName.Size = New System.Drawing.Size(120, 22)
        Me.optFindCusName.TabIndex = 12
        Me.optFindCusName.TabStop = True
        Me.optFindCusName.Text = "หาตามชื่อลูกค้า"
        Me.optFindCusName.UseVisualStyleBackColor = True
        '
        'searchCus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1028, 600)
        Me.Controls.Add(Me.dbCusGrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkCusType)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "searchCus"
        Me.Text = "ค้นหาข้อมูลลูกค้า 63-05-16"
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
        dRow(1) = "ประเภท"
        dTB.Rows.Add(dRow)

        dRow = dTB.NewRow
        dRow(0) = "AR"
        dRow(1) = "ชื่อ"
        dTB.Rows.Add(dRow)


        With cboType
            .DataSource = dTB
            .DisplayMember = "T_Name"
            .ValueMember = "T_Type"
        End With
        cboType.SelectedIndex = 1
    End Sub

    Private Sub searchCus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call frmSticGrd()
        '
        'ActivateKeyboardLayout(1, 0&)

        'Call addListCBO()


        'If optFindCusName.Checked = True Then
        '    Call showData(txtCusName.Text, "")
        'Else
        '    Call showData("", txtCusAdd.Text)
        'End If
        lbCusID.Text = selCusID
        If Len(lbCusID.Text) > 0 Then
            showMiniEditData()

        End If


        'txtCusName.SelectionStart = 0  'ãªéÃèÇÁ¡Ñº focus
        'txtCusName.SelectionLength = Len(txtCusName.Text) 'ãªéÃèÇÁ¡Ñº focus

        ' call showData()
        txtCusName.Focus() 'ãªéÃèÇÁ¡Ñº focus
        txtCusName.SelectAll()
    End Sub
    Sub showMiniEditData()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Where AR_Type='AR' "
        txtSQL = txtSQL & "And Ar_Cus_ID='" & lbCusID.Text & "' "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "master")

        With subDS.Tables("master").Rows(0)
            lbCusName.Text = .Item("Ar_Name")
            lbCusAddr.Text = .Item("Ar_Addr") & " " & .Item("Ar_Addr_1") & " " & .Item("Ar_Addr_2")
            If IsDBNull(.Item("Ar_Contact")) Then
                txtContact.Text = ""
            Else

                txtContact.Text = .Item("Ar_Contact")
            End If

            txtTel.Text = .Item("Ar_Tel_No").ToString
            If IsDBNull(.Item("Ar_Fax")) Then
                txtFax.Text = ""
            Else
                txtFax.Text = .Item("Ar_Fax").ToString
            End If

            If IsDBNull(.Item("Ar_Mobile")) Then
                txtMobile.Text = ""
            Else
                txtMobile.Text = .Item("Ar_Mobile")
            End If
            If IsDBNull(.Item("Ar_LineID")) Then
                txtLineID.Text = ""
            Else
                txtLineID.Text = .Item("Ar_lineID")
            End If
            If IsDBNull(.Item("Ar_Email_1")) Then
                txtEmail.Text = ""
            Else
                txtEmail.Text = .Item("Ar_Email_1")
            End If

        End With

        'Term = (dbCusGrid.Item(rowSel, 3))
        'If Term = 0 Then
        '    MsgBox("à¤Ã´Ôµà»ç¹ 0 ¡ÃØ³ÒµÃÇ¨ÊÍº´éÇÂ", MsgBoxStyle.OKOnly, "á¨é§ãËé·ÃÒº")
        'Else
        'End If

        'Sale = Convert.ToString(dbCusGrid.Item(rowSel, 6))
        'SaleID = Convert.ToString(dbCusGrid.Item(rowSel, 8))

        'Disc = Convert.ToString(dbCusGrid.Item(rowSel, 7))
        ' Limit = Convert.ToString(dbCusGrid.Item(rowSel, 5))



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
        txtSQL = txtSQL & " ArFile.AR_TERM,ar_cre_lim, salesman.SL_NAME,salesman.SL_ID, "
        txtSQL = txtSQL & "CSMast.CS_Name "

        txtSQL = txtSQL & " FROM ArFile LEFT OUTER JOIN "
        txtSQL = txtSQL & " salesman ON ArFile.AR_SALES = salesman.SL_ID "

        txtSQL = txtSQL & "Left Join CSMast "
        txtSQL = txtSQL & "On ArFile.Ar_CS=CSMast.CS_Code "

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
        Dim cusCSName As New DataGridTextBoxColumn

        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "ARdata"  '¡ÓË¹´ãËé DatagridTalbleStyle ãªé¡Ñº Table ã´

        End With

        With cusID
            .HeaderText = "รหัสลูกค้า"
            .MappingName = "Ar_Cus_ID"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 70
            .Alignment = HorizontalAlignment.Center
        End With

        With cusName
            .HeaderText = "ชื่อลูกค้า"
            .MappingName = "Ar_Name"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        With cusContact
            .HeaderText = "ชื่อพูดติดต่อ"
            .MappingName = "Ar_Contact"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 100
            .Alignment = HorizontalAlignment.Left
        End With
        With cusAddr
            .HeaderText = "ที่อยู่"
            .MappingName = "Ar_Addr0"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 250
            .Alignment = HorizontalAlignment.Left
        End With


        With cusTerm
            .HeaderText = "Term"
            .MappingName = "Ar_Term"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Left
        End With

        With cusCreLim
            .HeaderText = "เครดิต"
            .MappingName = "Ar_cre_lim"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 70
            .Alignment = HorizontalAlignment.Left
        End With

        With cusSale
            .HeaderText = "ชื่อ Sale"
            .MappingName = "sl_name"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 120
            .Alignment = HorizontalAlignment.Left
        End With

        With cusDisc
            .HeaderText = "ส่วนลด"
            .MappingName = "Ar_Disc"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 2
            .Alignment = HorizontalAlignment.Left
        End With

        With cusSaleID
            .HeaderText = "รหัสพนักงานขาย" 'ÃËÑÊsale
            .MappingName = "SL_ID"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 2
            .Alignment = HorizontalAlignment.Left
        End With

        With cusCSName
            .HeaderText = "ชื่อ CS"
            .MappingName = "CS_Name"
            .NullText = "ไม่พบข้อมูล"
            .ReadOnly = True
            .Width = 200
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
        grdTS.GridColumnStyles.Add(cusCSName)

        With dbCusGrid
            .TableStyles.Clear()
            .CaptionText = "ค้นหาข้อมูลลูกค้า"
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
                dbTools.dbSaveDATA(txtSQL, "")

            Else
                Lock01 = 0 'subDS.Tables("ARCheck").Rows(0).Item("ar_lock")
            End If


        End If


        If Lock01 = 0 Then  ' unlock 

            PId = lbCusID.Text
            selCusID = lbCusID.Text
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

            MsgBox("ÅÙ¡¤éÒÃÒÂ¹ÕéäÁèÊÒÁÒÃ¶à»Ô´ºÔÅä´é ! ", MsgBoxStyle.Critical, "á¨é§ãËé·ÃÒº")
            PId = ""
            PName = ""
            CusId = ""
            CusName = ""
            CusCreTerm = 0
            CusSaleName = ""
            CusSaleID = ""
            selCusID = ""
            CusDiscount = 0.0
            CusLimit = 0.0
            Term = 0
            Sale = ""
            SaleID = ""
            Disc = 0.0
            Limit = 0.0
            'ElseIf amt1 < amt2 And Lock01 = 1 Then 'Ë¹ÕéÁÒ¡¡¡ÇèÒà¤Ã´Ôµ áÅÐâ´¹ lock
            '    MsgBox("äÁèÊÒÁÒÃ¶à»Ô´ºÔÅãËéÅÙ¡¤éÒÃÒÂ¹Õéä´é à¹×èÍ§¨Ò¡ÁÕÂÍ´Ë¹Õéà¡Ô¹Ç§à§Ô¹à¤Ã´Ôµ ¡ÃØ³ÒµÔ´µèÍá¼¹¡ºÑ­ªÕ", MsgBoxStyle.OkOnly, "á¨é§ãËé·ÃÒº")
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
            'ElseIf amt1 < amt2 And Lock01 = 0 Then 'Ë¹ÕéÁÒ¡¡ÇèÒà¤Ã´Ôµ áµè¶Ù¡»Å´lock
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
        'Dim rowSel As Integer

        'rowSel = dbCusGrid.CurrentRowIndex
        'If rowSel < 0 Then Exit Sub

        'lbCusID.Text = Convert.ToString(dbCusGrid.Item(rowSel, 0))
        'lbCusName.Text = Convert.ToString(dbCusGrid.Item(rowSel, 1))

        'lbCusAddr.Text = cusTools.getArAddrFull(lbCusID.Text)

        '' lbCusAddr2.Text = ""
        ''=======================================================
        'Dim subDS As New DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        'txtSQL = "Select * "
        'txtSQL = txtSQL & "From ArFile "
        'txtSQL = txtSQL & "Where AR_Type='Pr' "
        'txtSQL = txtSQL & "And Ar_Cus_ID='" & lbCusID.text & "' "

        'subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDa.Fill(subDS, "master")
        ''=========================================================
        ''lbCusTel.Text = ""

        ''Term = (dbCusGrid.Item(rowSel, 3))
        ''If Term = 0 Then
        ''    MsgBox("à¤Ã´Ôµà»ç¹ 0 ¡ÃØ³ÒµÃÇ¨ÊÍº´éÇÂ", MsgBoxStyle.OKOnly, "á¨é§ãËé·ÃÒº")
        ''Else
        ''End If
        'Sale = Convert.ToString(dbCusGrid.Item(rowSel, 6))
        'SaleID = Convert.ToString(dbCusGrid.Item(rowSel, 8))
        'Disc = Convert.ToString(dbCusGrid.Item(rowSel, 7))
        'Limit = Convert.ToString(dbCusGrid.Item(rowSel, 5))



        Dim rowSel As Integer
        Dim subDS As New DataSet
        Dim subDa As SqlClient.SqlDataAdapter

        rowSel = dbCusGrid.CurrentRowIndex
        If rowSel < 0 Then Exit Sub

        lbCusID.Text = Convert.ToString(dbCusGrid.Item(rowSel, 0))
        lbCusName.Text = Convert.ToString(dbCusGrid.Item(rowSel, 1))
        lbCusAddr.Text = cusTools.getArAddrFull(lbCusID.Text)

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ArFile "
        txtSQL = txtSQL & "Where AR_Type='AR' "
        txtSQL = txtSQL & "And Ar_Cus_ID='" & lbCusID.Text & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "master")

        With subDS.Tables("master").Rows(0)
            lbCusName.Text = .Item("Ar_Name")

            If IsDBNull(.Item("Ar_Contact")) Then
                txtContact.Text = ""
            Else

                txtContact.Text = .Item("Ar_Contact")
            End If

            txtTel.Text = .Item("Ar_Tel_No").ToString
            If IsDBNull(.Item("Ar_Fax")) Then
                txtFax.Text = ""
            Else
                txtFax.Text = .Item("Ar_Fax").ToString

            End If

            If IsDBNull(.Item("Ar_Mobile")) Then
                txtMobile.Text = ""
            Else
                txtMobile.Text = .Item("Ar_Mobile")
            End If
            If IsDBNull(.Item("Ar_LineID")) Then
                txtLineID.Text = ""
            Else
                txtLineID.Text = .Item("Ar_lineID")
            End If
            If IsDBNull(.Item("Ar_Email_1")) Then
                txtEmail.Text = ""
            Else
                txtEmail.Text = .Item("Ar_Email_1")
            End If


        End With


        'Term = (dbCusGrid.Item(rowSel, 3))
        'If Term = 0 Then
        '    MsgBox("à¤Ã´Ôµà»ç¹ 0 ¡ÃØ³ÒµÃÇ¨ÊÍº´éÇÂ", MsgBoxStyle.OKOnly, "á¨é§ãËé·ÃÒº")
        'Else
        'End If
        Sale = Convert.ToString(dbCusGrid.Item(rowSel, 6))
        SaleID = Convert.ToString(dbCusGrid.Item(rowSel, 8))
        'Disc = Convert.ToString(dbCusGrid.Item(rowSel, 7))
        ' Limit = Convert.ToString(dbCusGrid.Item(rowSel, 5))



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

    Private Sub cmbSave_Click(sender As Object, e As EventArgs) Handles cmbSave.Click
        runSave()
    End Sub


    Sub runSave()

        Try

            dbTools.dbSaveDATA(sqlUpdateAddr, txtCusName.Text)

                Call txtCLS()

        Catch ex As Exception

            MsgBox("พบข้อมผิดพลาด " & ex.ToString)

        End Try


    End Sub


    Function sqlUpdateAddr() As String


        txtSQL = "Update ArFile "
        txtSQL = txtSQL & "Set "
        'txtSQL = txtSQL & "Ar_Type='AR',"
        'txtSQL = txtSQL & "Ar_Cus_ID='" & UCase(lbCusID.Text) & "',"
        'txtSQL = txtSQL & "Ar_Name='" & txtCusName.Text & "',"
        'txtSQL = txtSQL & "Ar_Name_2='" & Microsoft.VisualBasic.Left(txtCusName.Text, 60) & "',"

        txtSQL = txtSQL & "Ar_Contact='" & txtContact.Text & "', "
        txtSQL = txtSQL & "Ar_Tel_No='" & txtTel.Text & "',"
        txtSQL = txtSQL & "Ar_Fax='" & txtFax.Text & "',"
        txtSQL = txtSQL & "Ar_Mobile='" & txtMobile.Text & "',"
        txtSQL = txtSQL & "Ar_LineID='" & txtLineID.Text & "',"

        txtSQL = txtSQL & "Ar_Email_1='" & txtEmail.Text & "' "
        'txtSQL = txtSQL & "Ar_Sales='" & lbSalesID.Text & "' "

        ' ====================  เลือกข้อมูล ลูกค้า ===========================
        txtSQL = txtSQL & "Where Ar_Type='AR' "
        txtSQL = txtSQL & "And Ar_Cus_ID='" & lbCusID.Text & "' "

        Return txtSQL

    End Function
    Sub txtCLS()
        lbCusID.Text = ""
        lbCusName.Text = ""
        lbCusAddr.Text = ""
        txtContact.Text = ""
        'lbCusAddr2.Text = ""
        lbCusID.Text = ""
        txtCusName.Text = ""
        'txtAdd.Text = ""
        'txtAdd1.Text = ""
        'txtAdd2.Text = ""
        'txtZipCode.Text = ""
        txtTel.Text = ""
        txtMobile.Text = ""
        txtLineID.Text = ""
        txtFax.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub dbCusGrid_Click(sender As Object, e As EventArgs) Handles dbCusGrid.Click

    End Sub
End Class
