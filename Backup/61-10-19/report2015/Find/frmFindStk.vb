Public Class frmFindStk
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
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents lbStkName As System.Windows.Forms.TextBox
    Friend WithEvents dataShow As System.Windows.Forms.DataGrid
    Friend WithEvents lbStkCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboDClist As System.Windows.Forms.ComboBox
    Friend WithEvents chkDC As System.Windows.Forms.CheckBox
    Friend WithEvents lbQty2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbQty1 As System.Windows.Forms.Label
    Friend WithEvents lbiTemQty As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbSQL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProdList As System.Windows.Forms.ComboBox
    Friend WithEvents lbChkCount As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMoreZero As System.Windows.Forms.RadioButton
    Friend WithEvents chkZero As System.Windows.Forms.RadioButton
    Friend WithEvents chkLessZero As System.Windows.Forms.RadioButton
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents cmbSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSelStr As System.Windows.Forms.CheckBox
    Friend WithEvents lbStrCode02 As System.Windows.Forms.Label
    Friend WithEvents cmbSelCus02 As System.Windows.Forms.Label
    Friend WithEvents lbStrName As System.Windows.Forms.Label
    Friend WithEvents lbStrCode As System.Windows.Forms.TextBox
    Friend WithEvents lbCusName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFindName As System.Windows.Forms.TextBox
    Friend WithEvents txtWH As System.Windows.Forms.TextBox
    Friend WithEvents lbWhCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbTypeID As System.Windows.Forms.Label
    Friend WithEvents lbGrpCode As System.Windows.Forms.Label
    Friend WithEvents lbColorCode As System.Windows.Forms.Label
    Friend WithEvents lbSize1 As System.Windows.Forms.Label
    Friend WithEvents lbTh1 As System.Windows.Forms.Label
    Friend WithEvents chkGrade1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPaper1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSize1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkTh1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkColor1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkGrp1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkType1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrp As System.Windows.Forms.ComboBox
    Friend WithEvents cboThick As System.Windows.Forms.ComboBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboPaper As System.Windows.Forms.ComboBox
    Friend WithEvents lbPaper As System.Windows.Forms.Label
    Friend WithEvents lbGrade As System.Windows.Forms.Label
    Friend WithEvents cmbOK2 As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbStkQty1 As System.Windows.Forms.Label
    Friend WithEvents chkStkStr As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkName As System.Windows.Forms.RadioButton
    Friend WithEvents chkStk As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmbFindStrStk As System.Windows.Forms.Button
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbStkQty1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWH = New System.Windows.Forms.TextBox()
        Me.lbWhCode = New System.Windows.Forms.Label()
        Me.lbStrCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbCusName = New System.Windows.Forms.TextBox()
        Me.lbStkCode = New System.Windows.Forms.TextBox()
        Me.lbStkName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOK = New System.Windows.Forms.Button()
        Me.dataShow = New System.Windows.Forms.DataGrid()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbQty2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbChkCount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbQty1 = New System.Windows.Forms.Label()
        Me.lbiTemQty = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboDClist = New System.Windows.Forms.ComboBox()
        Me.chkDC = New System.Windows.Forms.CheckBox()
        Me.lbSQL = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtFindName = New System.Windows.Forms.TextBox()
        Me.chkName = New System.Windows.Forms.RadioButton()
        Me.chkStk = New System.Windows.Forms.RadioButton()
        Me.cboProdList = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPaper1 = New System.Windows.Forms.CheckBox()
        Me.lbGrade = New System.Windows.Forms.Label()
        Me.lbPaper = New System.Windows.Forms.Label()
        Me.lbTypeID = New System.Windows.Forms.Label()
        Me.lbGrpCode = New System.Windows.Forms.Label()
        Me.lbColorCode = New System.Windows.Forms.Label()
        Me.lbSize1 = New System.Windows.Forms.Label()
        Me.lbTh1 = New System.Windows.Forms.Label()
        Me.chkGrade1 = New System.Windows.Forms.CheckBox()
        Me.chkSize1 = New System.Windows.Forms.CheckBox()
        Me.chkTh1 = New System.Windows.Forms.CheckBox()
        Me.chkColor1 = New System.Windows.Forms.CheckBox()
        Me.chkGrp1 = New System.Windows.Forms.CheckBox()
        Me.chkType1 = New System.Windows.Forms.CheckBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.cboGrp = New System.Windows.Forms.ComboBox()
        Me.cboThick = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.cboPaper = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbStrCode02 = New System.Windows.Forms.Label()
        Me.chkSelStr = New System.Windows.Forms.CheckBox()
        Me.cmbSelCus02 = New System.Windows.Forms.Label()
        Me.lbStrName = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkStkStr = New System.Windows.Forms.CheckBox()
        Me.cmbOK2 = New System.Windows.Forms.Button()
        Me.chkMoreZero = New System.Windows.Forms.RadioButton()
        Me.chkZero = New System.Windows.Forms.RadioButton()
        Me.chkLessZero = New System.Windows.Forms.RadioButton()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmbFindStrStk = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbStkQty1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtWH)
        Me.GroupBox1.Controls.Add(Me.lbWhCode)
        Me.GroupBox1.Controls.Add(Me.lbStrCode)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.lbStkCode)
        Me.GroupBox1.Controls.Add(Me.lbStkName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 230)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 76)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'lbStkQty1
        '
        Me.lbStkQty1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbStkQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkQty1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkQty1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkQty1.Location = New System.Drawing.Point(830, 14)
        Me.lbStkQty1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkQty1.Name = "lbStkQty1"
        Me.lbStkQty1.Size = New System.Drawing.Size(162, 55)
        Me.lbStkQty1.TabIndex = 132
        Me.lbStkQty1.Text = "00"
        Me.lbStkQty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(783, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "จำนวน"
        '
        'txtWH
        '
        Me.txtWH.BackColor = System.Drawing.Color.Black
        Me.txtWH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWH.ForeColor = System.Drawing.Color.Lime
        Me.txtWH.Location = New System.Drawing.Point(52, 48)
        Me.txtWH.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Size = New System.Drawing.Size(129, 26)
        Me.txtWH.TabIndex = 128
        '
        'lbWhCode
        '
        Me.lbWhCode.BackColor = System.Drawing.Color.Blue
        Me.lbWhCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWhCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbWhCode.Location = New System.Drawing.Point(11, 53)
        Me.lbWhCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWhCode.Name = "lbWhCode"
        Me.lbWhCode.Size = New System.Drawing.Size(35, 16)
        Me.lbWhCode.TabIndex = 129
        Me.lbWhCode.Text = "WH"
        '
        'lbStrCode
        '
        Me.lbStrCode.BackColor = System.Drawing.Color.Black
        Me.lbStrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStrCode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStrCode.ForeColor = System.Drawing.Color.Lime
        Me.lbStrCode.Location = New System.Drawing.Point(216, 48)
        Me.lbStrCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbStrCode.Name = "lbStrCode"
        Me.lbStrCode.Size = New System.Drawing.Size(114, 26)
        Me.lbStrCode.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(189, 54)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 16)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "คลัง"
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.Black
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.Yellow
        Me.lbCusName.Location = New System.Drawing.Point(336, 46)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbCusName.MaxLength = 60
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(438, 26)
        Me.lbCusName.TabIndex = 125
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.SystemColors.Info
        Me.lbStkCode.Location = New System.Drawing.Point(50, 16)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(280, 27)
        Me.lbStkCode.TabIndex = 70
        Me.lbStkCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.Yellow
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbStkName.Location = New System.Drawing.Point(336, 16)
        Me.lbStkName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbStkName.MaxLength = 60
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(438, 27)
        Me.lbStkName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ชื่อ"
        '
        'cmbOK
        '
        Me.cmbOK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.Red
        Me.cmbOK.Location = New System.Drawing.Point(1052, 24)
        Me.cmbOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(177, 108)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "เลือก"
        '
        'dataShow
        '
        Me.dataShow.CaptionBackColor = System.Drawing.Color.SlateGray
        Me.dataShow.DataMember = ""
        Me.dataShow.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dataShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataShow.Location = New System.Drawing.Point(4, 6)
        Me.dataShow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.ReadOnly = True
        Me.dataShow.Size = New System.Drawing.Size(1025, 168)
        Me.dataShow.TabIndex = 10
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbQty2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.lbChkCount)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.lbQty1)
        Me.GroupBox5.Controls.Add(Me.lbiTemQty)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 185)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(1036, 46)
        Me.GroupBox5.TabIndex = 120
        Me.GroupBox5.TabStop = False
        '
        'lbQty2
        '
        Me.lbQty2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty2.ForeColor = System.Drawing.Color.White
        Me.lbQty2.Location = New System.Drawing.Point(732, 14)
        Me.lbQty2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty2.Name = "lbQty2"
        Me.lbQty2.Size = New System.Drawing.Size(142, 24)
        Me.lbQty2.TabIndex = 125
        Me.lbQty2.Text = "0"
        Me.lbQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(688, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 18)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "น้ำหนัก"
        '
        'lbChkCount
        '
        Me.lbChkCount.BackColor = System.Drawing.Color.Blue
        Me.lbChkCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbChkCount.ForeColor = System.Drawing.Color.Yellow
        Me.lbChkCount.Location = New System.Drawing.Point(986, 14)
        Me.lbChkCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbChkCount.Name = "lbChkCount"
        Me.lbChkCount.Size = New System.Drawing.Size(42, 21)
        Me.lbChkCount.TabIndex = 127
        Me.lbChkCount.Text = "5"
        Me.lbChkCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbChkCount.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(441, 22)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 20)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "รายการ"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(652, 22)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 18)
        Me.Label16.TabIndex = 127
        Me.Label16.Text = "แผ่น"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(881, 21)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 16)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Kg."
        '
        'lbQty1
        '
        Me.lbQty1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty1.ForeColor = System.Drawing.Color.White
        Me.lbQty1.Location = New System.Drawing.Point(538, 14)
        Me.lbQty1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty1.Name = "lbQty1"
        Me.lbQty1.Size = New System.Drawing.Size(116, 24)
        Me.lbQty1.TabIndex = 124
        Me.lbQty1.Text = "0"
        Me.lbQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbiTemQty
        '
        Me.lbiTemQty.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbiTemQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbiTemQty.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbiTemQty.ForeColor = System.Drawing.Color.White
        Me.lbiTemQty.Location = New System.Drawing.Point(326, 14)
        Me.lbiTemQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbiTemQty.Name = "lbiTemQty"
        Me.lbiTemQty.Size = New System.Drawing.Size(116, 24)
        Me.lbiTemQty.TabIndex = 123
        Me.lbiTemQty.Text = "0"
        Me.lbiTemQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(494, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 18)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "จำนวน"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(238, 22)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "จำนวนรายการ"
        '
        'cboDClist
        '
        Me.cboDClist.FormattingEnabled = True
        Me.cboDClist.Location = New System.Drawing.Point(360, 28)
        Me.cboDClist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDClist.Name = "cboDClist"
        Me.cboDClist.Size = New System.Drawing.Size(163, 21)
        Me.cboDClist.TabIndex = 130
        '
        'chkDC
        '
        Me.chkDC.AutoSize = True
        Me.chkDC.Location = New System.Drawing.Point(274, 29)
        Me.chkDC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkDC.Name = "chkDC"
        Me.chkDC.Size = New System.Drawing.Size(70, 17)
        Me.chkDC.TabIndex = 129
        Me.chkDC.Text = "เลือกคลัง"
        Me.chkDC.UseVisualStyleBackColor = True
        '
        'lbSQL
        '
        Me.lbSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSQL.Location = New System.Drawing.Point(4, 56)
        Me.lbSQL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbSQL.Multiline = True
        Me.lbSQL.Name = "lbSQL"
        Me.lbSQL.Size = New System.Drawing.Size(1014, 47)
        Me.lbSQL.TabIndex = 122
        Me.lbSQL.Text = "TextBox1"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtFindName)
        Me.GroupBox6.Controls.Add(Me.chkName)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(581, 53)
        Me.GroupBox6.TabIndex = 128
        Me.GroupBox6.TabStop = False
        '
        'txtFindName
        '
        Me.txtFindName.BackColor = System.Drawing.Color.Yellow
        Me.txtFindName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtFindName.ForeColor = System.Drawing.Color.Black
        Me.txtFindName.Location = New System.Drawing.Point(102, 16)
        Me.txtFindName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFindName.Name = "txtFindName"
        Me.txtFindName.Size = New System.Drawing.Size(468, 27)
        Me.txtFindName.TabIndex = 73
        '
        'chkName
        '
        Me.chkName.AutoSize = True
        Me.chkName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkName.Location = New System.Drawing.Point(9, 20)
        Me.chkName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkName.Name = "chkName"
        Me.chkName.Size = New System.Drawing.Size(85, 20)
        Me.chkName.TabIndex = 75
        Me.chkName.TabStop = True
        Me.chkName.Text = "หาตามชื่อ"
        Me.chkName.UseVisualStyleBackColor = True
        '
        'chkStk
        '
        Me.chkStk.AutoSize = True
        Me.chkStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkStk.Location = New System.Drawing.Point(26, 25)
        Me.chkStk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkStk.Name = "chkStk"
        Me.chkStk.Size = New System.Drawing.Size(59, 20)
        Me.chkStk.TabIndex = 76
        Me.chkStk.TabStop = True
        Me.chkStk.Text = "สินค้า"
        Me.chkStk.UseVisualStyleBackColor = True
        '
        'cboProdList
        '
        Me.cboProdList.BackColor = System.Drawing.Color.DodgerBlue
        Me.cboProdList.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProdList.ForeColor = System.Drawing.SystemColors.Info
        Me.cboProdList.FormattingEnabled = True
        Me.cboProdList.Location = New System.Drawing.Point(92, 21)
        Me.cboProdList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProdList.Name = "cboProdList"
        Me.cboProdList.Size = New System.Drawing.Size(174, 27)
        Me.cboProdList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPaper1)
        Me.GroupBox2.Controls.Add(Me.lbGrade)
        Me.GroupBox2.Controls.Add(Me.lbPaper)
        Me.GroupBox2.Controls.Add(Me.lbTypeID)
        Me.GroupBox2.Controls.Add(Me.lbGrpCode)
        Me.GroupBox2.Controls.Add(Me.lbColorCode)
        Me.GroupBox2.Controls.Add(Me.lbSize1)
        Me.GroupBox2.Controls.Add(Me.lbTh1)
        Me.GroupBox2.Controls.Add(Me.chkGrade1)
        Me.GroupBox2.Controls.Add(Me.chkSize1)
        Me.GroupBox2.Controls.Add(Me.chkTh1)
        Me.GroupBox2.Controls.Add(Me.chkColor1)
        Me.GroupBox2.Controls.Add(Me.chkGrp1)
        Me.GroupBox2.Controls.Add(Me.chkType1)
        Me.GroupBox2.Controls.Add(Me.cboType)
        Me.GroupBox2.Controls.Add(Me.cboColor)
        Me.GroupBox2.Controls.Add(Me.cboGrade)
        Me.GroupBox2.Controls.Add(Me.cboGrp)
        Me.GroupBox2.Controls.Add(Me.cboThick)
        Me.GroupBox2.Controls.Add(Me.cboSize)
        Me.GroupBox2.Controls.Add(Me.cboPaper)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1096, 74)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        '
        'chkPaper1
        '
        Me.chkPaper1.AutoSize = True
        Me.chkPaper1.Checked = True
        Me.chkPaper1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPaper1.Location = New System.Drawing.Point(890, 46)
        Me.chkPaper1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPaper1.Name = "chkPaper1"
        Me.chkPaper1.Size = New System.Drawing.Size(73, 21)
        Me.chkPaper1.TabIndex = 76
        Me.chkPaper1.Text = "กระดาษ"
        Me.chkPaper1.UseVisualStyleBackColor = True
        '
        'lbGrade
        '
        Me.lbGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbGrade.Location = New System.Drawing.Point(967, 46)
        Me.lbGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrade.Name = "lbGrade"
        Me.lbGrade.Size = New System.Drawing.Size(52, 16)
        Me.lbGrade.TabIndex = 84
        Me.lbGrade.Text = "0"
        '
        'lbPaper
        '
        Me.lbPaper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbPaper.Location = New System.Drawing.Point(835, 46)
        Me.lbPaper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPaper.Name = "lbPaper"
        Me.lbPaper.Size = New System.Drawing.Size(48, 16)
        Me.lbPaper.TabIndex = 83
        Me.lbPaper.Text = "0"
        '
        'lbTypeID
        '
        Me.lbTypeID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTypeID.Location = New System.Drawing.Point(13, 46)
        Me.lbTypeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTypeID.Name = "lbTypeID"
        Me.lbTypeID.Size = New System.Drawing.Size(73, 16)
        Me.lbTypeID.TabIndex = 82
        Me.lbTypeID.Text = "0"
        '
        'lbGrpCode
        '
        Me.lbGrpCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbGrpCode.Location = New System.Drawing.Point(174, 46)
        Me.lbGrpCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrpCode.Name = "lbGrpCode"
        Me.lbGrpCode.Size = New System.Drawing.Size(113, 16)
        Me.lbGrpCode.TabIndex = 81
        Me.lbGrpCode.Text = "0"
        '
        'lbColorCode
        '
        Me.lbColorCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbColorCode.Location = New System.Drawing.Point(351, 46)
        Me.lbColorCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbColorCode.Name = "lbColorCode"
        Me.lbColorCode.Size = New System.Drawing.Size(96, 16)
        Me.lbColorCode.TabIndex = 80
        Me.lbColorCode.Text = "0"
        '
        'lbSize1
        '
        Me.lbSize1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSize1.Location = New System.Drawing.Point(668, 46)
        Me.lbSize1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSize1.Name = "lbSize1"
        Me.lbSize1.Size = New System.Drawing.Size(100, 16)
        Me.lbSize1.TabIndex = 79
        Me.lbSize1.Text = "0"
        '
        'lbTh1
        '
        Me.lbTh1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTh1.Location = New System.Drawing.Point(512, 46)
        Me.lbTh1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTh1.Name = "lbTh1"
        Me.lbTh1.Size = New System.Drawing.Size(84, 16)
        Me.lbTh1.TabIndex = 78
        Me.lbTh1.Text = "0"
        '
        'chkGrade1
        '
        Me.chkGrade1.AutoSize = True
        Me.chkGrade1.Checked = True
        Me.chkGrade1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGrade1.Location = New System.Drawing.Point(1026, 46)
        Me.chkGrade1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkGrade1.Name = "chkGrade1"
        Me.chkGrade1.Size = New System.Drawing.Size(55, 21)
        Me.chkGrade1.TabIndex = 77
        Me.chkGrade1.Text = "เกรด"
        Me.chkGrade1.UseVisualStyleBackColor = True
        '
        'chkSize1
        '
        Me.chkSize1.AutoSize = True
        Me.chkSize1.Checked = True
        Me.chkSize1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSize1.Location = New System.Drawing.Point(771, 46)
        Me.chkSize1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSize1.Name = "chkSize1"
        Me.chkSize1.Size = New System.Drawing.Size(61, 21)
        Me.chkSize1.TabIndex = 75
        Me.chkSize1.Text = "ขนาด"
        Me.chkSize1.UseVisualStyleBackColor = True
        '
        'chkTh1
        '
        Me.chkTh1.AutoSize = True
        Me.chkTh1.Checked = True
        Me.chkTh1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTh1.Location = New System.Drawing.Point(603, 46)
        Me.chkTh1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkTh1.Name = "chkTh1"
        Me.chkTh1.Size = New System.Drawing.Size(52, 21)
        Me.chkTh1.TabIndex = 74
        Me.chkTh1.Text = "หนา"
        Me.chkTh1.UseVisualStyleBackColor = True
        '
        'chkColor1
        '
        Me.chkColor1.AutoSize = True
        Me.chkColor1.Checked = True
        Me.chkColor1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColor1.Location = New System.Drawing.Point(456, 48)
        Me.chkColor1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkColor1.Name = "chkColor1"
        Me.chkColor1.Size = New System.Drawing.Size(36, 21)
        Me.chkColor1.TabIndex = 73
        Me.chkColor1.Text = "สี"
        Me.chkColor1.UseVisualStyleBackColor = True
        '
        'chkGrp1
        '
        Me.chkGrp1.AutoSize = True
        Me.chkGrp1.Checked = True
        Me.chkGrp1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGrp1.Location = New System.Drawing.Point(294, 46)
        Me.chkGrp1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkGrp1.Name = "chkGrp1"
        Me.chkGrp1.Size = New System.Drawing.Size(52, 21)
        Me.chkGrp1.TabIndex = 72
        Me.chkGrp1.Text = "กลุ่ม"
        Me.chkGrp1.UseVisualStyleBackColor = True
        '
        'chkType1
        '
        Me.chkType1.AutoSize = True
        Me.chkType1.Checked = True
        Me.chkType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkType1.Location = New System.Drawing.Point(90, 46)
        Me.chkType1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkType1.Name = "chkType1"
        Me.chkType1.Size = New System.Drawing.Size(72, 21)
        Me.chkType1.TabIndex = 71
        Me.chkType1.Text = "ประเภท"
        Me.chkType1.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboType.DropDownHeight = 90
        Me.cboType.DropDownWidth = 7
        Me.cboType.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboType.IntegralHeight = False
        Me.cboType.Location = New System.Drawing.Point(11, 18)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(162, 24)
        Me.cboType.TabIndex = 1
        Me.cboType.Text = "ComboBox1"
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboColor.DropDownHeight = 90
        Me.cboColor.DropDownWidth = 7
        Me.cboColor.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboColor.IntegralHeight = False
        Me.cboColor.ItemHeight = 16
        Me.cboColor.Location = New System.Drawing.Point(350, 18)
        Me.cboColor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(158, 24)
        Me.cboColor.TabIndex = 3
        Me.cboColor.Text = "ComboBox1"
        '
        'cboGrade
        '
        Me.cboGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboGrade.DropDownHeight = 90
        Me.cboGrade.DropDownWidth = 7
        Me.cboGrade.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrade.IntegralHeight = False
        Me.cboGrade.Location = New System.Drawing.Point(967, 18)
        Me.cboGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(126, 24)
        Me.cboGrade.TabIndex = 7
        Me.cboGrade.Text = "ComboBox1"
        '
        'cboGrp
        '
        Me.cboGrp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboGrp.DropDownHeight = 90
        Me.cboGrp.DropDownWidth = 7
        Me.cboGrp.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrp.IntegralHeight = False
        Me.cboGrp.Location = New System.Drawing.Point(174, 18)
        Me.cboGrp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Size = New System.Drawing.Size(176, 24)
        Me.cboGrp.TabIndex = 2
        Me.cboGrp.Text = "ComboBox1"
        '
        'cboThick
        '
        Me.cboThick.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboThick.DropDownHeight = 90
        Me.cboThick.DropDownWidth = 7
        Me.cboThick.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboThick.IntegralHeight = False
        Me.cboThick.Location = New System.Drawing.Point(508, 18)
        Me.cboThick.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboThick.Name = "cboThick"
        Me.cboThick.Size = New System.Drawing.Size(158, 24)
        Me.cboThick.TabIndex = 4
        Me.cboThick.Text = "ComboBox1"
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboSize.DropDownHeight = 90
        Me.cboSize.DropDownWidth = 7
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSize.IntegralHeight = False
        Me.cboSize.Location = New System.Drawing.Point(666, 18)
        Me.cboSize.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(165, 24)
        Me.cboSize.TabIndex = 5
        Me.cboSize.Text = "ComboBox2"
        '
        'cboPaper
        '
        Me.cboPaper.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboPaper.DropDownHeight = 90
        Me.cboPaper.DropDownWidth = 7
        Me.cboPaper.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboPaper.IntegralHeight = False
        Me.cboPaper.Location = New System.Drawing.Point(832, 18)
        Me.cboPaper.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPaper.Name = "cboPaper"
        Me.cboPaper.Size = New System.Drawing.Size(133, 24)
        Me.cboPaper.TabIndex = 6
        Me.cboPaper.Text = "ComboBox1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbStrCode02)
        Me.GroupBox3.Controls.Add(Me.chkSelStr)
        Me.GroupBox3.Controls.Add(Me.cmbSelCus02)
        Me.GroupBox3.Controls.Add(Me.lbStrName)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(544, 8)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(458, 46)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เลือกชื่อลูกค้า"
        '
        'lbStrCode02
        '
        Me.lbStrCode02.BackColor = System.Drawing.Color.Blue
        Me.lbStrCode02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStrCode02.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStrCode02.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbStrCode02.Location = New System.Drawing.Point(84, 16)
        Me.lbStrCode02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStrCode02.Name = "lbStrCode02"
        Me.lbStrCode02.Size = New System.Drawing.Size(80, 24)
        Me.lbStrCode02.TabIndex = 66
        Me.lbStrCode02.Text = "110098"
        Me.lbStrCode02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkSelStr
        '
        Me.chkSelStr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkSelStr.Location = New System.Drawing.Point(14, 22)
        Me.chkSelStr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkSelStr.Name = "chkSelStr"
        Me.chkSelStr.Size = New System.Drawing.Size(79, 16)
        Me.chkSelStr.TabIndex = 68
        Me.chkSelStr.Text = "ชื่อลูกค้า"
        '
        'cmbSelCus02
        '
        Me.cmbSelCus02.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbSelCus02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbSelCus02.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSelCus02.ForeColor = System.Drawing.Color.White
        Me.cmbSelCus02.Location = New System.Drawing.Point(422, 16)
        Me.cmbSelCus02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cmbSelCus02.Name = "cmbSelCus02"
        Me.cmbSelCus02.Size = New System.Drawing.Size(27, 24)
        Me.cmbSelCus02.TabIndex = 65
        Me.cmbSelCus02.Text = "..."
        Me.cmbSelCus02.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbStrName
        '
        Me.lbStrName.BackColor = System.Drawing.Color.Yellow
        Me.lbStrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStrName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStrName.Location = New System.Drawing.Point(167, 16)
        Me.lbStrName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStrName.Name = "lbStrName"
        Me.lbStrName.Size = New System.Drawing.Size(256, 24)
        Me.lbStrName.TabIndex = 64
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSearch.ForeColor = System.Drawing.Color.Green
        Me.cmbSearch.Location = New System.Drawing.Point(1106, 7)
        Me.cmbSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(97, 66)
        Me.cmbSearch.TabIndex = 123
        Me.cmbSearch.Text = "ค้นหา"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkStkStr)
        Me.GroupBox4.Controls.Add(Me.cmbOK2)
        Me.GroupBox4.Controls.Add(Me.chkMoreZero)
        Me.GroupBox4.Controls.Add(Me.chkZero)
        Me.GroupBox4.Controls.Add(Me.chkLessZero)
        Me.GroupBox4.Controls.Add(Me.chkOption)
        Me.GroupBox4.Location = New System.Drawing.Point(1052, 134)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(178, 172)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        '
        'chkStkStr
        '
        Me.chkStkStr.AutoSize = True
        Me.chkStkStr.Location = New System.Drawing.Point(11, 108)
        Me.chkStkStr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkStkStr.Name = "chkStkStr"
        Me.chkStkStr.Size = New System.Drawing.Size(118, 17)
        Me.chkStkStr.TabIndex = 129
        Me.chkStkStr.Text = "แสดงคลังปรับสต๊อก"
        Me.chkStkStr.UseVisualStyleBackColor = True
        '
        'cmbOK2
        '
        Me.cmbOK2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK2.ForeColor = System.Drawing.Color.Green
        Me.cmbOK2.Location = New System.Drawing.Point(18, 130)
        Me.cmbOK2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbOK2.Name = "cmbOK2"
        Me.cmbOK2.Size = New System.Drawing.Size(124, 34)
        Me.cmbOK2.TabIndex = 128
        Me.cmbOK2.Text = "พิมพ์ Stock"
        '
        'chkMoreZero
        '
        Me.chkMoreZero.Checked = True
        Me.chkMoreZero.Location = New System.Drawing.Point(36, 61)
        Me.chkMoreZero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkMoreZero.Name = "chkMoreZero"
        Me.chkMoreZero.Size = New System.Drawing.Size(96, 15)
        Me.chkMoreZero.TabIndex = 6
        Me.chkMoreZero.TabStop = True
        Me.chkMoreZero.Text = "มากกว่า 0"
        '
        'chkZero
        '
        Me.chkZero.Location = New System.Drawing.Point(36, 40)
        Me.chkZero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkZero.Name = "chkZero"
        Me.chkZero.Size = New System.Drawing.Size(96, 16)
        Me.chkZero.TabIndex = 5
        Me.chkZero.Text = "เท่ากับ 0"
        '
        'chkLessZero
        '
        Me.chkLessZero.Location = New System.Drawing.Point(36, 83)
        Me.chkLessZero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkLessZero.Name = "chkLessZero"
        Me.chkLessZero.Size = New System.Drawing.Size(79, 16)
        Me.chkLessZero.TabIndex = 4
        Me.chkLessZero.Text = "น้อยกว่า 0"
        '
        'chkOption
        '
        Me.chkOption.Location = New System.Drawing.Point(8, 18)
        Me.chkOption.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(168, 16)
        Me.chkOption.TabIndex = 2
        Me.chkOption.Text = "ใช้เงื่อนไขจำนวนคงเหลือ"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(4, 6)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1015, 46)
        Me.ListView1.TabIndex = 127
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboDClist)
        Me.GroupBox7.Controls.Add(Me.chkStk)
        Me.GroupBox7.Controls.Add(Me.chkDC)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.cboProdList)
        Me.GroupBox7.Controls.Add(Me.TabControl2)
        Me.GroupBox7.Location = New System.Drawing.Point(4, 304)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(1230, 180)
        Me.GroupBox7.TabIndex = 128
        Me.GroupBox7.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(4, 61)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1218, 114)
        Me.TabControl2.TabIndex = 131
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.cmbFindStrStk)
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Size = New System.Drawing.Size(1210, 88)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "หาตามชื่อ"
        '
        'cmbFindStrStk
        '
        Me.cmbFindStrStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbFindStrStk.ForeColor = System.Drawing.Color.Green
        Me.cmbFindStrStk.Location = New System.Drawing.Point(602, 8)
        Me.cmbFindStrStk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbFindStrStk.Name = "cmbFindStrStk"
        Me.cmbFindStrStk.Size = New System.Drawing.Size(482, 62)
        Me.cmbFindStrStk.TabIndex = 131
        Me.cmbFindStrStk.Text = "ค้นหา"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.cmbSearch)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage4.Size = New System.Drawing.Size(1210, 88)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "หาตาม Factor"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1040, 202)
        Me.TabControl1.TabIndex = 129
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dataShow)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1032, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.lbSQL)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1032, 176)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmFindStk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1237, 494)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.cmbOK)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmFindStk"
        Me.Text = "ค้นหาข้อมูลสินค้า  (Update 21/10/2556)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim subDA As Data.SqlClient.SqlDataAdapter
    Dim subDS As New Data.DataSet
    Dim chkData2 As Boolean = False
    Dim chkData As Boolean = False
    Dim chkProdList As Boolean = False
    Dim chkGrp As Boolean = False
    Dim chkColor As Boolean = False
    Dim chkLoad As Boolean = False



    Sub addProdList()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ProGrpMast "
        txtSQL = txtSQL & "Order by ProGrp_id "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData")
        If subDS.Tables("listData").Rows.Count > 0 Then
            cboProdList.DataSource = subDS.Tables("listData")
            cboProdList.ValueMember = "ProGrp_id"
            cboProdList.DisplayMember = "ProGrp_Name"
            'cboDClist.Text = ""
            cboProdList.SelectedItem = 0
        End If



    End Sub

    Sub addListDC()


        txtSQL = "Select * "
        txtSQL = txtSQL & "From wareHouse "
        txtSQL = txtSQL & "where Wh_Type='DC' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "WareHouse")
        If subDS.Tables("WareHouse").Rows.Count > 0 Then
            cboDClist.DataSource = subDS.Tables("WareHouse")
            cboDClist.ValueMember = "Wh_id"
            cboDClist.DisplayMember = "Wh_Name"
            'cboDClist.Text = ""
            cboDClist.SelectedItem = 0
        End If


    End Sub

    Sub addItemCBO()

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim iRow As Integer = 0

        'cboType.SelectedItem = Nothing
        'cboGrp.SelectedItem = Nothing
        'cboSize.SelectedItem = Nothing
        'cboThick.SelectedItem = Nothing
        'cboPaper.SelectedItem = Nothing
        'cboColor.SelectedItem = Nothing
        'cboGrade.SelectedItem = Nothing



        'txtSQL = "Select  Color_Code,(color_code1 + '-'+ Color_StkName) as Color_StkName  "
        'txtSQL = txtSQL & "From ColorMast "
        'txtSQL = txtSQL & "Order by Color_Grp,Color_StkName "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "ColorMast")

        'If ds.Tables("ColorMast").Rows.Count > 0 Then
        '    With cboColor
        '        .DataSource = ds.Tables("ColorMast")
        '        .DisplayMember = "Color_StkName"
        '        .ValueMember = "Color_Code"
        '        '.Text = ""
        '    End With
        'End If

        'txtSQL = "Select  Type_Code,Type_Name,Type_Stk_Name  From TypeMast "
        'txtSQL = txtSQL & "Order by Type_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "TypeMast")

        'If ds.Tables("TypeMast").Rows.Count > 0 Then
        '    With cboType
        '        .DataSource = ds.Tables("TypeMast")
        '        .DisplayMember = "Type_Name"
        '        .ValueMember = "Type_Code"
        '        '.Text = ""
        '    End With
        'End If

        'txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
        'txtSQL = txtSQL & "From GrpMast "
        'txtSQL = txtSQL & "Order by Grp_Name "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "GrpMast")

        'If ds.Tables("GrpMast").Rows.Count > 0 Then
        '    With cboGrp
        '        .DataSource = ds.Tables("GrpMast")
        '        .DisplayMember = "Grp_Name"
        '        .ValueMember = "Grp_Code"
        '        '.Text = ""
        '    End With
        'End If


        'If IsDBNull(cboType.SelectedValue) Then

        'Else
        '    txtSQL = txtSQL & "Where Color_Type='" & cboType.SelectedValue & "'"
        'End If




        txtSQL = "Select Th_Name3,"
        txtSQL = txtSQL & "Th_Code,Th_Th "
        txtSQL = txtSQL & "From ThMast "
        txtSQL = txtSQL & "Order by Th_Th "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "ThMast")

        If ds.Tables("ThMast").Rows.Count > 0 Then
            With cboThick
                .DataSource = ds.Tables("ThMast")
                .DisplayMember = "Th_Name3"
                .ValueMember = "Th_Code"
                '.Text = ""
            End With
        End If

        txtSQL = "Select  Size_Name_2,Size_Code  From SizeMast "
        txtSQL = txtSQL & "Order by Size_Name_2  "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "SizeMast")

        If ds.Tables("SizeMast").Rows.Count > 0 Then
            With cboSize
                .DataSource = ds.Tables("SizeMast")
                .DisplayMember = "Size_Name_2"
                .ValueMember = "Size_Code"
                '.Text = ""
            End With
        End If

        txtSQL = "Select  Paper_Name,Paper_Code  From PaperMast "
        txtSQL = txtSQL & "Order by Paper_Code"

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "PaperMast")


        If ds.Tables("PaperMast").Rows.Count > 0 Then
            With cboPaper
                .DataSource = ds.Tables("paperMast")
                .DisplayMember = "Paper_Name"
                .ValueMember = "Paper_Code"
                '.Text = ""

            End With
        End If

        txtSQL = "Select  G_Name,G_Code  From gMast "
        txtSQL = txtSQL & "Order by G_Name "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "GradeMast")


        If ds.Tables("GradeMast").Rows.Count > 0 Then
            With cboGrade
                .DataSource = ds.Tables("GradeMast")
                .DisplayMember = "G_Name"
                .ValueMember = "G_Code"
                '.Text = ""
            End With
        End If




        cboType.SelectedItem = Nothing
        cboType.SelectedValue = "01"

        cboGrp.SelectedItem = Nothing
        cboGrp.SelectedValue = "01"

        cboSize.SelectedItem = Nothing
        cboSize.SelectedValue = "12301840"

        cboThick.SelectedItem = Nothing
        cboThick.SelectedText = ""

        cboPaper.SelectedItem = Nothing
        cboPaper.SelectedIndex = 1

        cboColor.SelectedItem = Nothing
        cboColor.SelectedValue = "00001"

        cboGrade.SelectedItem = Nothing
        cboGrade.SelectedIndex = 3

        'Call chgColorList()

    End Sub

    Private Sub frmFindStk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If chkLoad = False Then
            'DBTools.connDB()
            Call addItemCBO()
            Call addProdList()
            chkLoad = True
            txtFindName.Focus()
        End If
        Call addListDC()
        chkMoreZero.Checked = True
        chkName.Checked = True
        chkOption.Checked = False
        'lbStkCode.Text = selStkID
        chkSelStr.Checked = True
        lbStrName.Text = dbTools.getCusName(lbStrCode02.Text)
        'cmbSelCus02.Enabled = False
        'cmbSelCus02.BackColor = Color.Red

        'lbStrName.Text = dbTools.getCusName(lbStrCode02.Text)
        txtFindName.Focus()
        txtFindName.SelectAll()

        'cbotype.SelectedItem=
    End Sub

    Sub FormatGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim StkChk As New DataGridTextBoxColumn


        Dim StkColor As New DataGridTextBoxColumn
        Dim stkSize As New DataGridTextBoxColumn
        Dim stkThick As New DataGridTextBoxColumn
        Dim StkName As New DataGridTextBoxColumn
        Dim StkFactor As New DataGridTextBoxColumn
        Dim StkCode As New DataGridTextBoxColumn
        Dim Q1 As New DataGridTextBoxColumn
        Dim StkQty As New DataGridTextBoxColumn

        Dim StkWHcode As New DataGridTextBoxColumn
        Dim StkWH As New DataGridTextBoxColumn
        Dim stkStr As New DataGridTextBoxColumn
        Dim stkStrCode As New DataGridTextBoxColumn


        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "Master"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With



        With StkColor
            .HeaderText = "Color"
            .MappingName = "Color_Name"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 90
        End With

        With stkSize
            .HeaderText = "ขนาด"
            .MappingName = "Size_Name"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 70
        End With

        With stkThick
            .HeaderText = "หนา"
            .MappingName = "Th_Name"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 70
        End With

        With StkWH
            .HeaderText = "คลัง"
            .MappingName = "wh_Name"
            .Alignment = HorizontalAlignment.Left
            '.ReadOnly = True
            .Width = 80
        End With
        With StkWHcode
            .HeaderText = "WH"
            .MappingName = "wh_id"
            .Alignment = HorizontalAlignment.Right
            '.ReadOnly = True
            .Width = 100
        End With
        With stkStrCode
            .HeaderText = "รหัสลูกค้า"
            .MappingName = "Dtl_Store"
            .Alignment = HorizontalAlignment.Right
            '.ReadOnly = True
            .Width = 100
        End With

        With stkStr
            .HeaderText = "ลูกค้า"
            .MappingName = "Ar_Name"
            .Alignment = HorizontalAlignment.Left
            '.ReadOnly = True
            .Width = 250
        End With
        With StkCode
            .HeaderText = "รหัสสินค้า"
            .MappingName = "Stk_Code"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 10
        End With

        With StkName
            .HeaderText = "ชื่อ"
            .MappingName = "Stk_Name_1"
            ' .ReadOnly = True
            .Width = 400
        End With

        With StkQty
            .HeaderText = "คงเหลือ"
            .MappingName = "Dtl_Bal_Q1"
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0"
            ' .ReadOnly = True
            .Width = 100
        End With

        With StkFactor
            .HeaderText = "น้ำหนัก/แผ่น"
            .MappingName = "Stk_Factor"
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            ' .ReadOnly = True
            .Width = 100
        End With
        With Q1
            .HeaderText = "น้ำหนักรวม"
            .MappingName = "w1"
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0.00"
            ' .ReadOnly = True
            .Width = 75
        End With



        grdTS.GridColumnStyles.Add(StkWH) '0
        grdTS.GridColumnStyles.Add(stkStr) '1
        grdTS.GridColumnStyles.Add(StkName) '2
        grdTS.GridColumnStyles.Add(StkQty) '4
        grdTS.GridColumnStyles.Add(StkFactor) '3
        grdTS.GridColumnStyles.Add(Q1) '5
        grdTS.GridColumnStyles.Add(StkCode) '6
        grdTS.GridColumnStyles.Add(stkStrCode) '7
        grdTS.GridColumnStyles.Add(StkWHcode) '8



        With dataShow
            .TableStyles.Clear()
            .CaptionText = "รายงานรายชื่อสินค้า"
            .FlatMode = True
            .TableStyles.Add(grdTS)
            '.Controls.Clear()
        End With

    End Sub
    Sub ShowDataSum()
        Dim txtSQL2 As String = ""
        Dim txtsql3 As String = ""
        'Dim subDT As Data.DataTable
        'Dim subDs As DataSet = New Data.DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        dataShow.Refresh()


        'Dim subDT As Data.DataTable
        'Dim subDs As DataSet = New Data.DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        dataShow.Refresh()

        txtSQL = "Select "
        txtSQL = txtSQL & "sum(StkDetl.Dtl_Bal_Q1)as SumQty1,sum(StkDetl.Dtl_Bal_Q1 * Stk_Factor)as sumQty2 "


        txtSQL = txtSQL & "From  BaseMast Left Join ColorMast "
        txtSQL = txtSQL & "On BaseMast.Color_Code=ColorMast.Color_Code "
        txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type "

        txtSQL = txtSQL & "Left Join SizeMast "
        txtSQL = txtSQL & "On BaseMast.Size_Code=SizeMast.Size_Code "

        txtSQL = txtSQL & "Left Join ThMast "
        txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        txtSQL = txtSQL & "Left Join StkDetl "
        txtSQL = txtSQL & "On BaseMast.Stk_Code=StkDetl.Dtl_Code "
        txtSQL = txtSQL & "Left Join ArFile  "
        txtSQL = txtSQL & "On StkDetl.Dtl_Store=Arfile.Ar_Cus_Id "



        If chkStk.Checked = True Then

            If chkStk.Checked = False Then

            Else
                '=====  แก้ไขเพื่อ ให้สามารถเลือกข้อมูล NPD ให้ได้ไปก่อน จนกว่ารหัสจะถูกแก้ไขหมด
                'If cboProdList.SelectedValue <> "05" Then

                'Else
                txtSQL2 = txtSQL2 & " And Stk_Prod='" & cboProdList.SelectedValue & "' "
                'End If

            End If

            If chkType1.Checked = False Then

            Else
                txtSQL2 = txtSQL2 & " And baseMast.Type_Code ='" & cboType.SelectedValue & "' "
            End If

            If chkGrp1.Checked = False Then

            Else
                txtSQL2 = txtSQL2 & " And  BaseMast.Grp_Code ='" & cboGrp.SelectedValue & "' "
            End If

            If chkSize1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.Size_Code ='" & cboSize.SelectedValue & "' "
            End If

            If chkPaper1.Checked = False Then
            Else
                txtSQL2 = txtSQL2 & " And  baseMast.paper_code ='" & cboPaper.SelectedValue & "' "
            End If

            If chkTh1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.Th_Code ='" & cboThick.SelectedValue & "' "
            End If

            If chkColor1.Checked = False Then
            Else
                txtSQL2 = txtSQL2 & " And  BaseMast.color_Code ='" & cboColor.SelectedValue & "' "
            End If

            If chkGrade1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.G_Code ='" & cboGrade.SelectedValue & "' "
            End If

        End If

        txtSQL = txtSQL & "Left Join warehouse "
        txtSQL = txtSQL & "On StkDetl.Dtl_wh=wareHouse.Wh_id "

        '===================   Where  =========================

        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & "(not(Dtl_Bal_Q1 is null) "
        'txtSQL = txtSQL & "And Ar_stk_Chk=1 "

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        txtSQL = txtSQL & "And not(Dtl_Store='110603') " ' 110603 แปรรูป
        txtSQL = txtSQL & "And not(Dtl_Store='111660') " ' 111660 ตัดชำรุด 

        If chkStkStr.Checked = True Then
        Else
            txtSQL = txtSQL & "And not(Dtl_Store='112054') " ' 112054 คลังปรับสต๊อก   
        End If
        txtSQL = txtSQL & " )"

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        If chkDC.Checked = True Then
            txtSQL = txtSQL & "And stkdetl.dtl_wh='" & cboDClist.SelectedValue & "'"
        End If

        If chkOption.Checked = True Then
            If chkMoreZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 > 0 "
            End If
            If chkZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 = 0 "
            End If
            If chkLessZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 < 0 "
            End If
        End If


        'If Len(txtSQL2) > 0 Or Len(txtsql3) > 0 Then

        'End If

        '=======    ถ้า   chkStk   ใช้เลือกข้อมูลตาม Factor   ===============
        If chkStk.Checked = True Then
            txtSQL = txtSQL & txtSQL2
        End If

        '=======    ถ้า   chkname   ใช้เลือกข้อมูลตาม ชือ่   ===============

        If chkName.Checked = True Then
            txtSQL = txtSQL & "And Stk_Name_1 like '%" & txtFindName.Text & "%' "
        End If

        If chkSelStr.Checked = True Then
            txtSQL = txtSQL & "And Dtl_Store='" & lbStrCode02.Text & "'"
        End If

        txtSQL = txtSQL & "And (wareHouse.Wh_Type='DC') "

        txtSQL = txtSQL
        '===================   Where  =========================



        'txtSQL = txtSQL & "Basemast.Grp_Code,BaseMast.Color_Code,BaseMast.Th_Code,BaseMast.Size_Code,Dtl_Bal_Q1" ' desc "

        '===============================================================================================
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData2 = True Then
            subDS.Tables("Master2").Clear()
            chkData2 = False
        End If
        subDA.Fill(subDS, "Master2")
        chkData2 = True

        'lbSql.Text = txtSQL

        'dataShow.DataSource = subDS.Tables("Master2")
        'dataShow.Refresh()

        If subDS.Tables("Master2").Rows.Count > 0 Then
            If IsDBNull(subDS.Tables("Master2").Rows(0).Item("sumQty1")) Then
                lbQty1.Text = Format(0, "#,##0.00")
                lbQty2.Text = Format(0, "#,##0.00")
            Else
                lbQty1.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty1"), "#,##0.00")
                lbQty2.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty2"), "#,##0.00")
            End If

            'lbQty2.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty2"), "#,##0.00")
        End If

    End Sub
    Sub ShowDataSum2()

        Dim txtSQL2 As String = ""
        Dim txtsql3 As String = ""
        'Dim subDT As Data.DataTable
        'Dim subDs As DataSet = New Data.DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        dataShow.Refresh()

        'txtSQL = "Select Stk_Code,Stk_Name_1,Stk_Factor,ColorMast.Color_Name,"
        'txtSQL = txtSQL & "StkDetl.Dtl_Code, StkDetl.Dtl_Store,ArFile.Ar_Name,StkDetl.Dtl_Bal_Q1,(StkDetl.Dtl_Bal_Q1 * Stk_Factor)as Dtl_Bal_Q2,Dtl_Or_Q1 "

        txtSQL = "Select "
        txtSQL = txtSQL & "sum(StkDetl.Dtl_Bal_Q1)as SumQty1,sum(StkDetl.Dtl_Bal_Q1 * Stk_Factor)as sumQty2 "

        txtSQL = txtSQL & "From  BaseMast Left Join ColorMast "
        txtSQL = txtSQL & "On BaseMast.Color_Code=ColorMast.Color_Code "
        txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type "
        txtSQL = txtSQL & "Left Join StkDetl "
        txtSQL = txtSQL & "On BaseMast.Stk_Code=StkDetl.Dtl_Code "
        txtSQL = txtSQL & "Left Join ArFile  "
        txtSQL = txtSQL & "On StkDetl.Dtl_Store=Arfile.Ar_Cus_Id "



        If chkStk.Checked = True Then

            '=====================================================

            If chkStk.Checked = False Then

            Else
                '=====  แก้ไขเพื่อ ให้สามารถเลือกข้อมูล NPD ให้ได้ไปก่อน จนกว่ารหัสจะถูกแก้ไขหมด
                'If cboProdList.SelectedValue <> "05" Then

                'Else
                txtSQL2 = txtSQL2 & " And Stk_Prod='" & cboProdList.SelectedValue & "' "
                'End If

            End If

            If Trim(cboType.SelectedValue) = "" Then

            Else
                txtSQL2 = txtSQL2 & " And Type_Code ='" & cboType.SelectedValue & "' "
            End If

            If Trim(cboGrp.SelectedValue) = "" Then

            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If

                txtSQL2 = txtSQL2 & " And  Grp_Code ='" & cboGrp.SelectedValue & "' "
            End If

            If Trim(cboSize.SelectedValue) = "" Then
            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If
                txtSQL2 = txtSQL2 & " And  Size_Code ='" & cboSize.SelectedValue & "' "
            End If

            If Trim(cboPaper.SelectedValue) = "" Then
            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If
                txtSQL2 = txtSQL2 & " And  paper_code ='" & cboPaper.SelectedValue & "' "
            End If

            If Trim(cboThick.SelectedValue) = "" Then
            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If
                txtSQL2 = txtSQL2 & " And  Th_Code ='" & cboThick.SelectedValue & "' "
            End If

            If Trim(cboColor.SelectedValue) = "" Then
            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If
                txtSQL2 = txtSQL2 & " And  BaseMast.color_Code ='" & cboColor.SelectedValue & "' "
            End If

            If Trim(cboGrade.SelectedValue) = "" Then
            Else
                'If Len(txtSQL2) > 0 Then
                '    txtSQL2 = txtSQL2 & " And "
                'End If
                txtSQL2 = txtSQL2 & " And  G_Code ='" & cboGrade.SelectedValue & "' "
            End If

            '=====================================================

        Else
            txtSQL2 = "And BaseMast.Stk_Name_1 like '%" & txtFindName.Text & "%' "

        End If

        txtSQL = txtSQL & "Left Join warehouse "
        txtSQL = txtSQL & "On StkDetl.Dtl_wh=wareHouse.Wh_id "


        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & "(not(Dtl_Bal_Q1 is null) "

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        txtSQL = txtSQL & "And not(Dtl_Store='110603') " ' 110603 แปรรูป
        txtSQL = txtSQL & "And not(Dtl_Store='111660') " ' 111660 ตัดชำรุด 

        txtSQL = txtSQL & txtSQL2

        If chkStkStr.Checked = True Then
        Else
            txtSQL = txtSQL & "And not(Dtl_Store='112054') " ' 112054 คลังปรับสต๊อก   
        End If
        txtSQL = txtSQL & " )"

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        txtSQL = txtSQL & "And not(Basemast.Type_Code='04' or BaseMast.Type_Code='11' or BaseMast.Type_Code='13') "

        txtSQL = txtSQL & "And (wareHouse.Wh_Type='DC') "

        If chkOption.Checked = True Then
            If chkMoreZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 > 0 "
            End If
            If chkZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 = 0 "
            End If
            If chkLessZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 < 0 "
            End If
        End If


        'If Len(txtSQL2) > 0 Or Len(txtsql3) > 0 Then

        'End If

        If chkDC.Checked = True Then
            txtSQL = txtSQL & "And stkdetl.dtl_wh='" & cboDClist.SelectedValue & "'"
        End If

        txtSQL = txtSQL & "And (wareHouse.Wh_Type='DC') "


        If chkStk.Checked = True Then
            txtSQL = txtSQL & txtSQL2
        End If
        If chkSelStr.Checked = True Then
            txtSQL = txtSQL & "And Dtl_Store='" & lbStrCode02.Text & "'"
        End If


        txtSQL = txtSQL

        'txtSQL = txtSQL & "order by  Basemast.Type_Code,Basemast.Grp_Code,BaseMast.Color_Code,BaseMast.Th_Code,BaseMast.Size_Code,Dtl_Bal_Q1 desc "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData2 = True Then
            subDS.Tables("Master2").Clear()
            chkData2 = False
        End If
        subDA.Fill(subDS, "Master2")
        chkData2 = True

        'lbSql.Text = txtSQL

        'dataShow.DataSource = subDS.Tables("Master2")
        'dataShow.Refresh()

        If subDS.Tables("Master2").Rows.Count > 0 Then
            If IsDBNull(subDS.Tables("Master2").Rows(0).Item("sumQty1")) Then
                lbQty1.Text = Format(0, "#,##0.00")
                lbQty2.Text = Format(0, "#,##0.00")
            Else
                lbQty1.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty1"), "#,##0.00")
                lbQty2.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty2"), "#,##0.00")
            End If

            'lbQty2.Text = Format(subDS.Tables("Master2").Rows(0).Item("sumQty2"), "#,##0.00")
        End If

    End Sub

    Sub ShowData()

        Dim txtSQL2 As String = ""
        Dim txtsql3 As String = ""
        'Dim subDT As Data.DataTable
        'Dim subDs As DataSet = New Data.DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        dataShow.Refresh()


        'Dim subDT As Data.DataTable
        'Dim subDs As DataSet = New Data.DataSet
        'Dim subDa As SqlClient.SqlDataAdapter
        dataShow.Refresh()

        txtSQL = "Select Wh_id,Wh_Name,Stk_Code,Stk_Name_1,"
        txtSQL = txtSQL & "Stk_Factor,"
        'txtSQL = txtSQL & "ColorMast.Color_Name,"
        'txtSQL = txtSQL & "ThMast.Th_Name,SizeMast.Size_Name,"

        txtSQL = txtSQL & "StkDetl.Dtl_Code, StkDetl.Dtl_Store,ArFile.Ar_Name,"

        txtSQL = txtSQL & "StkDetl.Dtl_Bal_Q1,Dtl_Or_Q1,"
        txtSQL = txtSQL & "(dtl_bal_Q1 * Stk_Factor)as w1,Stk_Prod "

        txtSQL = txtSQL & "From  BaseMast "
        'txtSQL = txtSQL & "Left Join ColorMast "
        'txtSQL = txtSQL & "On BaseMast.Color_Code=ColorMast.Color_Code "
        'txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type "

        'txtSQL = txtSQL & "Left Join SizeMast "
        'txtSQL = txtSQL & "On BaseMast.Size_Code=SizeMast.Size_Code "

        'txtSQL = txtSQL & "Left Join ThMast "
        'txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        txtSQL = txtSQL & "Left Join StkDetl "
        txtSQL = txtSQL & "On BaseMast.Stk_Code=StkDetl.Dtl_Code "
        txtSQL = txtSQL & "Left Join ArFile  "
        txtSQL = txtSQL & "On StkDetl.Dtl_Store=Arfile.Ar_Cus_Id "



        If chkStk.Checked = True Then

            If chkStk.Checked = False Then

            Else
                '=====  แก้ไขเพื่อ ให้สามารถเลือกข้อมูล NPD ให้ได้ไปก่อน จนกว่ารหัสจะถูกแก้ไขหมด
                'If cboProdList.SelectedValue <> "05" Then

                'Else
                txtSQL2 = txtSQL2 & " And Stk_Prod='" & cboProdList.SelectedValue & "' "
                'End If

            End If

            If chkType1.Checked = False Then

            Else
                txtSQL2 = txtSQL2 & " And baseMast.Type_Code ='" & cboType.SelectedValue & "' "
            End If

            If chkGrp1.Checked = False Then

            Else
                txtSQL2 = txtSQL2 & " And  BaseMast.Grp_Code ='" & cboGrp.SelectedValue & "' "
            End If

            If chkSize1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.Size_Code ='" & cboSize.SelectedValue & "' "
            End If

            If chkPaper1.Checked = False Then
            Else
                txtSQL2 = txtSQL2 & " And  baseMast.paper_code ='" & cboPaper.SelectedValue & "' "
            End If

            If chkTh1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.Th_Code ='" & cboThick.SelectedValue & "' "
            End If

            If chkColor1.Checked = False Then
            Else
                txtSQL2 = txtSQL2 & " And  BaseMast.color_Code ='" & cboColor.SelectedValue & "' "
            End If

            If chkGrade1.Checked = False Then
            Else

                txtSQL2 = txtSQL2 & " And  baseMast.G_Code ='" & cboGrade.SelectedValue & "' "
            End If

        End If

        txtSQL = txtSQL & "Left Join warehouse "
        txtSQL = txtSQL & "On StkDetl.Dtl_wh=wareHouse.Wh_id "

        '===================   Where  =========================

        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & "(not(Dtl_Bal_Q1 is null) "
        'txtSQL = txtSQL & "And Ar_stk_Chk=1 "

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        txtSQL = txtSQL & "And not(Dtl_Store='110603') " ' 110603 แปรรูป
        txtSQL = txtSQL & "And not(Dtl_Store='111660') " ' 111660 ตัดชำรุด 

        If chkStkStr.Checked = True Then
        Else
            txtSQL = txtSQL & "And not(Dtl_Store='112054') " ' 112054 คลังปรับสต๊อก   
        End If
        txtSQL = txtSQL & " )"

        '============================   ไม่แสดงคลังสินค้าต่อไปนี้    ==========================================

        If chkDC.Checked = True Then
            txtSQL = txtSQL & "And stkdetl.dtl_wh='" & cboDClist.SelectedValue & "'"
        End If

        If chkOption.Checked = True Then
            If chkMoreZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 > 0 "
            End If
            If chkZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 = 0 "
            End If
            If chkLessZero.Checked = True Then
                txtSQL = txtSQL & " And Dtl_Bal_Q1 < 0 "
            End If
        End If


        'If Len(txtSQL2) > 0 Or Len(txtsql3) > 0 Then

        'End If

        '=======    ถ้า   chkStk   ใช้เลือกข้อมูลตาม Factor   ===============
        If chkStk.Checked = True Then
            txtSQL = txtSQL & txtSQL2
        End If

        '=======    ถ้า   chkname   ใช้เลือกข้อมูลตาม ชือ่   ===============

        If chkName.Checked = True Then
            txtSQL = txtSQL & "And Stk_Name_1 like '%" & txtFindName.Text & "%' "
        End If

        If chkSelStr.Checked = True Then
            txtSQL = txtSQL & "And Dtl_Store='" & lbStrCode02.Text & "'"
        End If

        txtSQL = txtSQL & "And (wareHouse.Wh_Type='DC') "

        txtSQL = txtSQL
        '===================   Where  =========================


        txtSQL = txtSQL & "order by  WH_Name,Basemast.Stk_Code,Dtl_Bal_Q1 desc "
        'txtSQL = txtSQL & "Basemast.Grp_Code,BaseMast.Color_Code,BaseMast.Th_Code,BaseMast.Size_Code,Dtl_Bal_Q1" ' desc "

        '===============================================================================================
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Master").Clear()
            chkData = False
        End If
        subDA.Fill(subDS, "Master")
        chkData = True

        lbSQL.Text = txtSQL
        lbiTemQty.Text = Format(subDS.Tables("Master").Rows.Count, "#,##0.00")

        dataShow.DataSource = subDS.Tables("Master")

        dataShow.Refresh()


    End Sub

    Private Sub dataGrid_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dataShow.CurrentCellChanged
        Dim UserSelRow As Integer = 0

        UserSelRow = dataShow.CurrentRowIndex
        dataShow.Select(UserSelRow)
        If UserSelRow >= 0 Then


            lbStkCode.Text = CStr(dataShow.Item(UserSelRow, 6))
            lbStkName.Text = dbTools.getStkName(lbStkCode.Text)

            If IsDBNull(dataShow.Item(UserSelRow, 8)) Then
                MsgBox("NO")
            Else
                lbWhCode.Text = CStr(dataShow.Item(UserSelRow, 8))
            End If

            txtWH.Text = CStr(dataShow.Item(UserSelRow, 0))

            If IsDBNull(dataShow.Item(UserSelRow, 7)) Then
                lbStrCode.Text = ""
            Else
                lbStrCode.Text = CStr(dataShow.Item(UserSelRow, 7))
                lbCusName.Text = dbTools.getCusName(lbStrCode.Text)

            End If

            If IsDBNull(dataShow.Item(UserSelRow, 3)) Then
                lbStkQty1.Text = 0
            Else
                lbStkQty1.Text = Format(CInt(CStr(dataShow.Item(UserSelRow, 3))), "#,##0.00")

            End If

        End If
    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        selWH = lbWhCode.Text
        selStkID = Trim(lbStkCode.Text)
        selCusID = Trim(lbStrCode.Text)
        Me.Hide()
       
    End Sub

    Private Sub frmFindStk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        ElseIf e.KeyCode = 13 Then
            Call ShowData()
            Call FormatGrd()
        End If
    End Sub


    'Private Sub cmbSelCus02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmFindStr As searchCus = New searchCus
    '    selStkID = ""
    '    frmFindStr.ShowDialog()
    '    lbStrCode02.Text = selCusiD
    '    If lbStrCode02.Text = "" Then
    '    Else
    '        lbStrName.Text = DBTools.getCusName(selCusiD)
    '    End If
    'End Sub

    'Private Sub chkSelStr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If chkSelStr.Checked = False Then

    '        cmbSelCus02.Enabled = False
    '        cmbSelCus02.BackColor = Color.Red

    '    ElseIf chkSelStr.Checked = True Then

    '        cmbSelCus02.Enabled = True
    '        cmbSelCus02.BackColor = Color.DarkGray


    '    End If
    'End Sub


    Private Sub cmbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.Click

        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")

        If chkSelStr.Checked = True And lbStrCode02.Text = "" Then
            MsgBox("ข้อมูลคลังสินค้าของลูกค้าที่ต้องการดูยังไม่ถูกเลือก โปรดตรวจสอบอีกครั้งหนึ่ง ")
            Exit Sub

        End If

        Call FormatGrd()

        Call ShowData()
        Call ShowDataSum()
        dataShow.Focus()

        'If subDS.Tables("Master").Rows.Count > 0 Then
        '    'lbStkCode.Text = subDS.Tables("Master").
        'End If
    End Sub


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboProdList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProdList.KeyDown
        If e.KeyCode = 13 Then
            cboType.Focus()
        End If
    End Sub



    Private Sub cboProdList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProdList.SelectedIndexChanged
        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try
            txtSQL = "Select  Type_Code,Type_Name  From TypeMast "
            txtSQL = txtSQL & "Where Type_Prod = '" & cboProdList.SelectedValue & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa1.Fill(subDs, "dbList")
            chkProdList = True

            If subDs.Tables("dbList").Rows.Count > 0 Then
                With cboType
                    .DataSource = subDs.Tables("dbList")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"
                    '.Items.Add("")
                    .Text = ""
                End With
                'cboType.SelectedItem = Nothing
            End If
            lbTypeID.Text = cboType.SelectedValue

        Catch ex As Exception

        End Try
    End Sub



    Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyDown
        If e.KeyCode = 13 Then

            cboGrp.Focus()
        End If

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        'Dim subDs As DataSet = New DataSet
        'Dim subDa1 As SqlClient.SqlDataAdapter
        Try

            txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
            txtSQL = txtSQL & "From GrpMast "
            If IsDBNull(cboType.SelectedValue) = True Then

            Else
                If cboProdList.SelectedValue = "05" Then
                    'txtSQL = txtSQL & "Where Grp_Type_Code='" & cboType.SelectedValue & "' "
                    '                ElseIf  Then
                Else
                    txtSQL = txtSQL & "Where Grp_Type_Code='" & cboType.SelectedValue & "' "
                    'รอแก้ไขกลุ่มทั้งหมด 

                End If

            End If

            txtSQL = txtSQL & "Order by Grp_Name "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkGrp = True Then
                subDS.Tables("GrpMast").Clear()
                chkGrp = False

            End If
            subDA.Fill(subDS, "GrpMast")
            chkGrp = True
            If subDS.Tables("GrpMast").Rows.Count > 0 Then
                With cboGrp
                    .DataSource = subDS.Tables("GrpMast")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"
                    .Text = ""
                End With
            End If

            txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
            If cboType.SelectedValue = "05" Then

                'ElseIf cboType.SelectedValue = "05" Then

            Else
                txtSQL = txtSQL & "Where Color_Type = '" & cboType.SelectedValue & "' "
            End If

            txtSQL = txtSQL & "Order by Color_stkname "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkColor = True Then
                subDS.Tables("ColorMast").Clear()
                chkColor = False
            End If
            subDA.Fill(subDS, "ColorMast")
            chkColor = True

            If subDS.Tables("ColorMast").Rows.Count > 0 Then
                With cboColor

                    .DataSource = subDS.Tables("ColorMast")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With
                'cboColor.SelectedItem = Nothing
            End If



        Catch ex As Exception

        End Try


    End Sub


    Private Sub cboGrp_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrp.KeyDown
        If e.KeyCode = 13 Then

            cboColor.Focus()

        End If
    End Sub

    Private Sub cboColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboColor.KeyDown
        If e.KeyCode = 13 Then

            cboThick.Focus()
        End If
    End Sub

    Private Sub cboGrp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrp.LostFocus
        lbGrpCode.Text = (cboGrp.SelectedValue & "-" & cboGrp.Text)
    End Sub


    Private Sub cboColor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColor.LostFocus
        Try
            lbColorCode.Text = cboColor.SelectedValue.ToString
        Catch ex As Exception
            lbColorCode.Text = "Error"
        End Try


    End Sub

    Private Sub cboThick_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboThick.KeyDown
        If e.KeyCode = 13 Then
            cboSize.Focus()
        End If

    End Sub



    Private Sub cboThick_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboThick.LostFocus
        lbTh1.Text = cboThick.SelectedValue & " " & cboThick.Text
    End Sub

    Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSize.KeyDown
        If e.KeyCode = 13 Then
            cboPaper.Focus()
        End If
    End Sub



    Private Sub cboSize_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSize.LostFocus
        '        lbSize1.Text = cboSize.SelectedValue
        lbSize1.Text = cboSize.SelectedValue & "-" & cboSize.Text
    End Sub

    Private Sub cboPaper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPaper.KeyDown
        If e.KeyCode = 13 Then
            cboGrade.Focus()
        End If
    End Sub

    Private Sub cboPaper_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPaper.LostFocus
        lbPaper.Text = cboPaper.Text
    End Sub

    Private Sub cboGrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrade.KeyDown
        If e.KeyCode = 13 Then
            cmbSearch.Focus()
        End If

    End Sub



    Private Sub cboGrade_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrade.LostFocus
        lbGrade.Text = cboGrade.Text
    End Sub


    Private Sub cmbOK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK2.Click

        Call prnReport()

    End Sub

    Sub prnReport()



        Dim myExcel As Microsoft.Office.Interop.Excel.Application

        'Dim myExcel As Excel.Application

        'Dim subDA2 As New SqlClient.SqlDataAdapter
        'Dim subDS2 As New DataSet


        Dim rw As Integer
        Dim countRow As Integer
        'Dim countRow2 As Integer
        Dim rowExcel As Integer = 6 '  เริ่ม รายการบรรทัดที่ 6
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        ' Dim stkName2 As String



        fileName = CurDir() & "\report\rptStk05.xls"
        'myExcel = New Excel.Application
        myExcel = CType(CreateObject("Excel.Application"), Microsoft.Office.Interop.Excel.Application)
        myExcel.Visible = True
        myExcel.DisplayAlerts = False
        'myExcel.ActiveWorkbook.AutoUpdateSaveChanges = False
        myExcel.AskToUpdateLinks = False
        'myExcel.WindowState = Excel.XlWindowState.xlNormal
        'myExcel.WindowState=

        myExcel.Workbooks.Open(fileName, 0, 1)

        With myExcel

            'rw = .ActiveCell.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row
            If IsDBNull(subDS.Tables("Command")) Then
                Exit Sub
            Else
                rw = subDS.Tables("Master").Rows.Count - 1

            End If


            .ActiveWindow.FreezePanes = False
            .Range("D5").Select()
            '.ActiveCell.Value = DBTools.getDocType(CStr(cboDType.SelectedValue))
            Dim exRow As Integer = 0
            For countRow = 0 To rw

                '  ============  เพิ่มบรรทัด
                .Range("B" & (rowExcel + 2) & ":" & "AC" & (rowExcel + 2)).Insert()

                '.Range("B" & (rowExcel + 1) & ":" & "K" & (rowExcel + 1)).Copy() '  เลือกบรรทัดเพื่อแทรก    

                '.Range("B" & (rowExcel + 3) & ":" & "O" & (rowExcel + 3)).Select()
                '.Range("B" & (rowExcel + 2) & ":" & "K" & (rowExcel + 2)).Insert()
                If exRow = 0 Then
                    .Range("B" & (rowExcel + 2) & ":" & "K" & (rowExcel + 2)).Interior.ColorIndex = 19
                    exRow = 1
                Else
                    .Range("B" & (rowExcel + 2) & ":" & "K" & (rowExcel + 2)).Interior.ColorIndex = 2
                    exRow = 0
                End If


                '.Selection.Insert(Shift:=2)    '     เพิ่ม( Insert ) บรรทัด 
                '  ============  เพิ่มบรรทัด

                .Range("B" & rowExcel).Value = countRow + 1

                .Range("D" & rowExcel).Value = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Wh_Name")

                .Range("E" & rowExcel).Value = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Ar_Name")

                'If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")) Then

                '    .Range("E" & rowExcel).Select()
                '    .ActiveCell.Value = "ไม่พบข้อมูล"

                'Else
                '    .Range("E" & rowExcel).Select()
                '    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")

                'End If


                .Range("F" & rowExcel).Value = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Stk_Name_1")


                .Range("G" & rowExcel).Value = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Stk_Factor")

                Dim dtlBalQ1 As Double = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Dtl_bal_q1")
                .Range("H" & rowExcel).Value = dtlBalQ1
                Dim dtlFactor As Double = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("W1")
                .Range("i" & rowExcel).Value = dtlFactor

                Dim stkCode11 As String = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Stk_Code")
                Dim date01 As String = Now.ToString("yyyy-MM-dd")

                If dbTools.getCostType(stkCode11) = 0 Then

                    .Range("J" & rowExcel).Value = dbTools.getCostByStk(stkCode11, date01, "", 0)
                    .Range("K" & rowExcel).Value = ("=J" & rowExcel) & "*" & ("I" & rowExcel)
                    'Dtl_Cost_PR = dbTools.getCostByStk(stkCode11, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                    'Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2

                Else
                    .Range("J" & rowExcel).Value = dbTools.getCostByStk(stkCode11, date01, "", 0)
                    .Range("K" & rowExcel).Value = dbTools.getCostByStk(stkCode11, date01, "", 0) * dtlBalQ1
                End If


                .Range("N" & rowExcel).Value = subDS.Tables("Master").Rows(countRow + bufferExcel).Item("Stk_Code")
                '.Range("P" & rowExcel).Value = 0   ตัวอย่าง

                rowExcel = rowExcel + 1
                'If rowExcel = 900 Then
                '    'bufferExcel = 500
                '    rowExcel = 9
                '    'myExcel.Workbooks.Open(fileName, 0, 1)
                '    sheetCount = sheetCount + 1
                '    .Sheets(sheetCount).select()
                'End If

            Next

            'myExcel.Quit()
            myExcel = Nothing
        End With
    End Sub

    Private Sub chkType1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkType1.CheckedChanged
        If chkType1.Checked = False Then
            chkGrp1.Checked = False
            chkColor1.Checked = False
            chkTh1.Checked = False
            chkSize1.Checked = False
            chkPaper1.Checked = False
            chkGrade1.Checked = False
        End If
    End Sub


    Sub findStkCode()

        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")

        If chkSelStr.Checked = True And lbStrCode02.Text = "" Then
            MsgBox("ข้อมูลคลังสินค้าของลูกค้าที่ต้องการดูยังไม่ถูกเลือก โปรดตรวจสอบอีกครั้งหนึ่ง ")
            Exit Sub

        End If

        Call FormatGrd()

        Call ShowData()
        Call ShowDataSum()
        dataShow.Focus()
    End Sub
   
    Private Sub cmbFindStrStk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFindStrStk.Click
        Call findStkCode()

    End Sub

    Private Sub txtFindName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call findStkCode()
        End If
    End Sub

    Private Sub txtFindName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFindName.MouseClick
        chkName.Checked = True
    End Sub

   


    Private Sub txtFindName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindName.TextChanged
        chkName.Checked = True

       


    End Sub

    Private Sub chkStk_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStk.CheckedChanged
        If chkStk.Checked = True Then
            chkName.Checked = False
        Else
            chkName.Checked = True
        End If
    End Sub

    Private Sub chkName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkName.CheckedChanged
        If chkName.Checked = True Then
            chkStk.Checked = False
        Else
            chkStk.Checked = True
        End If
    End Sub

    Private Sub cmbSelCus02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelCus02.Click
        Dim frmFindCus As New searchCus
        frmFindCus.ShowDialog()

        lbStrCode02.Text = selCusID
        lbStrName.Text = dbTools.getCusName(selCusID)
        Call findStkCode()


    End Sub

    Private Sub chkSelStr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelStr.CheckedChanged
        If chkSelStr.Checked = True Then
            cmbSelCus02.Enabled = True
        Else
            cmbSelCus02.Enabled = False
        End If
    End Sub
End Class
