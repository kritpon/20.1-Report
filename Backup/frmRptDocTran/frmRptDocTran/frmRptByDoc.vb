'Option Explicit On
'Option Strict On

'Imports Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Core


Public Class frmReport2
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
    Friend WithEvents lbStkName As System.Windows.Forms.Label
    Friend WithEvents lbFindStk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbDate01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbDate02 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDocNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtSelectNo As System.Windows.Forms.TextBox
    Friend WithEvents lsvShow As System.Windows.Forms.ListView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCusName As System.Windows.Forms.Label
    Friend WithEvents lbCusID As System.Windows.Forms.Label
    Friend WithEvents lbFindCus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbTranQty As System.Windows.Forms.Label
    Friend WithEvents lbQty1 As System.Windows.Forms.Label
    Friend WithEvents lbQty2 As System.Windows.Forms.Label
    Friend WithEvents chkSelCustom As System.Windows.Forms.CheckBox
    Friend WithEvents lbFindSale2 As System.Windows.Forms.Label
    Friend WithEvents lbSaleID2 As System.Windows.Forms.Label
    Friend WithEvents lbSaleName2 As System.Windows.Forms.Label
    Friend WithEvents chkNotSale2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkSelSale2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkOptSale2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbAmt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDisplStk As System.Windows.Forms.CheckBox
    Friend WithEvents chkDispSale As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnDetail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPrint As System.Windows.Forms.Button
    Friend WithEvents cmbRun As System.Windows.Forms.Button
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents optStk As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotDoc As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents chkNot As System.Windows.Forms.CheckBox
    Friend WithEvents optSpec As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboFactor5 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFactor4 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFactor3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFactor2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFactor1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFactor55 As System.Windows.Forms.ComboBox
    Friend WithEvents chkF5 As System.Windows.Forms.CheckBox
    Friend WithEvents cboFactor44 As System.Windows.Forms.ComboBox
    Friend WithEvents chkF4 As System.Windows.Forms.CheckBox
    Friend WithEvents cboFactor33 As System.Windows.Forms.ComboBox
    Friend WithEvents chkF3 As System.Windows.Forms.CheckBox
    Friend WithEvents cboFactor22 As System.Windows.Forms.ComboBox
    Friend WithEvents chkF2 As System.Windows.Forms.CheckBox
    Friend WithEvents cboFactor11 As System.Windows.Forms.ComboBox
    Friend WithEvents chkF1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtTSQL As System.Windows.Forms.TextBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkCost As System.Windows.Forms.CheckBox
    Friend WithEvents indexBar As System.Windows.Forms.ProgressBar
    Friend WithEvents chkProDDetl As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lbCostAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkNoGrpBy As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByStk As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByDoc As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpBySale As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByCustom As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Worker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkNotSale As System.Windows.Forms.RadioButton
    Friend WithEvents chkSelSale As System.Windows.Forms.RadioButton
    Friend WithEvents chkOptSale As System.Windows.Forms.CheckBox
    Friend WithEvents lbFindSale As System.Windows.Forms.Label
    Friend WithEvents lbSaleID As System.Windows.Forms.Label
    Friend WithEvents lbSaleName As System.Windows.Forms.Label
    Friend WithEvents lbWHname As System.Windows.Forms.Label
    Friend WithEvents lbWHCode As System.Windows.Forms.Label
    Friend WithEvents lbFindWh As System.Windows.Forms.Label
    Friend WithEvents chkWH As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbStkCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboDType = New System.Windows.Forms.ComboBox
        Me.lbDate01 = New System.Windows.Forms.DateTimePicker
        Me.lbStkName = New System.Windows.Forms.Label
        Me.lbFindStk = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbDate02 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkNot = New System.Windows.Forms.CheckBox
        Me.optSpec = New System.Windows.Forms.CheckBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboFactor5 = New System.Windows.Forms.ComboBox
        Me.cboFactor4 = New System.Windows.Forms.ComboBox
        Me.cboFactor3 = New System.Windows.Forms.ComboBox
        Me.cboFactor2 = New System.Windows.Forms.ComboBox
        Me.cboFactor1 = New System.Windows.Forms.ComboBox
        Me.cboFactor55 = New System.Windows.Forms.ComboBox
        Me.chkF5 = New System.Windows.Forms.CheckBox
        Me.cboFactor44 = New System.Windows.Forms.ComboBox
        Me.chkF4 = New System.Windows.Forms.CheckBox
        Me.cboFactor33 = New System.Windows.Forms.ComboBox
        Me.chkF3 = New System.Windows.Forms.CheckBox
        Me.cboFactor22 = New System.Windows.Forms.ComboBox
        Me.chkF2 = New System.Windows.Forms.CheckBox
        Me.cboFactor11 = New System.Windows.Forms.ComboBox
        Me.chkF1 = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtTSQL = New System.Windows.Forms.TextBox
        Me.optStk = New System.Windows.Forms.CheckBox
        Me.lbStkCode = New System.Windows.Forms.TextBox
        Me.chkNotDoc = New System.Windows.Forms.CheckBox
        Me.txtSelectNo = New System.Windows.Forms.TextBox
        Me.chkDocNo = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.chkNotSale = New System.Windows.Forms.RadioButton
        Me.chkSelSale = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkNotSale2 = New System.Windows.Forms.RadioButton
        Me.chkSelSale2 = New System.Windows.Forms.RadioButton
        Me.lbWHname = New System.Windows.Forms.Label
        Me.lbWHCode = New System.Windows.Forms.Label
        Me.lbFindWh = New System.Windows.Forms.Label
        Me.chkWH = New System.Windows.Forms.CheckBox
        Me.lbSaleID = New System.Windows.Forms.Label
        Me.lbSaleName2 = New System.Windows.Forms.Label
        Me.lbCusID = New System.Windows.Forms.Label
        Me.lbSaleID2 = New System.Windows.Forms.Label
        Me.lbFindSale2 = New System.Windows.Forms.Label
        Me.chkOptSale2 = New System.Windows.Forms.CheckBox
        Me.chkSelCustom = New System.Windows.Forms.CheckBox
        Me.chkOptSale = New System.Windows.Forms.CheckBox
        Me.lbFindSale = New System.Windows.Forms.Label
        Me.lbCusName = New System.Windows.Forms.Label
        Me.lbFindCus = New System.Windows.Forms.Label
        Me.lbSaleName = New System.Windows.Forms.Label
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.chkGrpBySale = New System.Windows.Forms.RadioButton
        Me.chkGrpByCustom = New System.Windows.Forms.RadioButton
        Me.chkNoGrpBy = New System.Windows.Forms.RadioButton
        Me.chkGrpByStk = New System.Windows.Forms.RadioButton
        Me.chkGrpByDoc = New System.Windows.Forms.RadioButton
        Me.chkOnDetail = New System.Windows.Forms.CheckBox
        Me.chkProDDetl = New System.Windows.Forms.CheckBox
        Me.chkCost = New System.Windows.Forms.CheckBox
        Me.chkDisplStk = New System.Windows.Forms.CheckBox
        Me.chkDispSale = New System.Windows.Forms.CheckBox
        Me.lsvShow = New System.Windows.Forms.ListView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbTranQty = New System.Windows.Forms.Label
        Me.lbQty1 = New System.Windows.Forms.Label
        Me.lbQty2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lbCostAmt = New System.Windows.Forms.TextBox
        Me.indexBar = New System.Windows.Forms.ProgressBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbAmt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbPrint = New System.Windows.Forms.Button
        Me.cmbRun = New System.Windows.Forms.Button
        Me.cmbExit = New System.Windows.Forms.Button
        Me.Worker1 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDType
        '
        Me.cboDType.BackColor = System.Drawing.SystemColors.Window
        Me.cboDType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDType.Location = New System.Drawing.Point(56, 16)
        Me.cboDType.Name = "cboDType"
        Me.cboDType.Size = New System.Drawing.Size(213, 24)
        Me.cboDType.TabIndex = 1
        Me.cboDType.Text = "ComboBox1"
        '
        'lbDate01
        '
        Me.lbDate01.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate01.Location = New System.Drawing.Point(786, 16)
        Me.lbDate01.Name = "lbDate01"
        Me.lbDate01.Size = New System.Drawing.Size(144, 23)
        Me.lbDate01.TabIndex = 2
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkName.Location = New System.Drawing.Point(81, 13)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(418, 24)
        Me.lbStkName.TabIndex = 9
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbFindStk.Location = New System.Drawing.Point(504, 12)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(31, 25)
        Me.lbFindStk.TabIndex = 6
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(40, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "รายงาน"
        '
        'lbDate02
        '
        Me.lbDate02.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate02.Location = New System.Drawing.Point(954, 16)
        Me.lbDate02.Name = "lbDate02"
        Me.lbDate02.Size = New System.Drawing.Size(144, 23)
        Me.lbDate02.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(931, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ถึง"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbStkName)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.optStk)
        Me.GroupBox2.Controls.Add(Me.lbStkCode)
        Me.GroupBox2.Controls.Add(Me.lbFindStk)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(554, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 297)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(5, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 214)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.chkNot)
        Me.TabPage1.Controls.Add(Me.optSpec)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 187)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Option 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkNot
        '
        Me.chkNot.AutoSize = True
        Me.chkNot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNot.Location = New System.Drawing.Point(137, 11)
        Me.chkNot.Name = "chkNot"
        Me.chkNot.Size = New System.Drawing.Size(68, 18)
        Me.chkNot.TabIndex = 39
        Me.chkNot.Text = "ไม่เลือก"
        Me.chkNot.UseVisualStyleBackColor = True
        '
        'optSpec
        '
        Me.optSpec.AutoSize = True
        Me.optSpec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSpec.Location = New System.Drawing.Point(5, 11)
        Me.optSpec.Name = "optSpec"
        Me.optSpec.Size = New System.Drawing.Size(133, 18)
        Me.optSpec.TabIndex = 38
        Me.optSpec.Text = "ตามการแยกประเภท"
        Me.optSpec.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.Label11)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.cboFactor5)
        Me.GroupBox9.Controls.Add(Me.cboFactor4)
        Me.GroupBox9.Controls.Add(Me.cboFactor3)
        Me.GroupBox9.Controls.Add(Me.cboFactor2)
        Me.GroupBox9.Controls.Add(Me.cboFactor1)
        Me.GroupBox9.Controls.Add(Me.cboFactor55)
        Me.GroupBox9.Controls.Add(Me.chkF5)
        Me.GroupBox9.Controls.Add(Me.cboFactor44)
        Me.GroupBox9.Controls.Add(Me.chkF4)
        Me.GroupBox9.Controls.Add(Me.cboFactor33)
        Me.GroupBox9.Controls.Add(Me.chkF3)
        Me.GroupBox9.Controls.Add(Me.cboFactor22)
        Me.GroupBox9.Controls.Add(Me.chkF2)
        Me.GroupBox9.Controls.Add(Me.cboFactor11)
        Me.GroupBox9.Controls.Add(Me.chkF1)
        Me.GroupBox9.Location = New System.Drawing.Point(34, 20)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(440, 148)
        Me.GroupBox9.TabIndex = 37
        Me.GroupBox9.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 14)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(380, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 14)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 14)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Label10"
        '
        'cboFactor5
        '
        Me.cboFactor5.Enabled = False
        Me.cboFactor5.FormattingEnabled = True
        Me.cboFactor5.Location = New System.Drawing.Point(101, 119)
        Me.cboFactor5.Name = "cboFactor5"
        Me.cboFactor5.Size = New System.Drawing.Size(100, 22)
        Me.cboFactor5.TabIndex = 39
        '
        'cboFactor4
        '
        Me.cboFactor4.FormattingEnabled = True
        Me.cboFactor4.Location = New System.Drawing.Point(101, 93)
        Me.cboFactor4.Name = "cboFactor4"
        Me.cboFactor4.Size = New System.Drawing.Size(100, 22)
        Me.cboFactor4.TabIndex = 38
        '
        'cboFactor3
        '
        Me.cboFactor3.FormattingEnabled = True
        Me.cboFactor3.Location = New System.Drawing.Point(101, 68)
        Me.cboFactor3.Name = "cboFactor3"
        Me.cboFactor3.Size = New System.Drawing.Size(100, 22)
        Me.cboFactor3.TabIndex = 37
        '
        'cboFactor2
        '
        Me.cboFactor2.FormattingEnabled = True
        Me.cboFactor2.Location = New System.Drawing.Point(101, 43)
        Me.cboFactor2.Name = "cboFactor2"
        Me.cboFactor2.Size = New System.Drawing.Size(100, 22)
        Me.cboFactor2.TabIndex = 36
        '
        'cboFactor1
        '
        Me.cboFactor1.Enabled = False
        Me.cboFactor1.FormattingEnabled = True
        Me.cboFactor1.Location = New System.Drawing.Point(101, 18)
        Me.cboFactor1.Name = "cboFactor1"
        Me.cboFactor1.Size = New System.Drawing.Size(100, 22)
        Me.cboFactor1.TabIndex = 35
        '
        'cboFactor55
        '
        Me.cboFactor55.FormattingEnabled = True
        Me.cboFactor55.Location = New System.Drawing.Point(213, 118)
        Me.cboFactor55.Name = "cboFactor55"
        Me.cboFactor55.Size = New System.Drawing.Size(161, 22)
        Me.cboFactor55.TabIndex = 34
        '
        'chkF5
        '
        Me.chkF5.AutoSize = True
        Me.chkF5.Enabled = False
        Me.chkF5.Location = New System.Drawing.Point(16, 122)
        Me.chkF5.Name = "chkF5"
        Me.chkF5.Size = New System.Drawing.Size(72, 18)
        Me.chkF5.TabIndex = 33
        Me.chkF5.Text = "Factor5"
        Me.chkF5.UseVisualStyleBackColor = True
        '
        'cboFactor44
        '
        Me.cboFactor44.DropDownHeight = 80
        Me.cboFactor44.FormattingEnabled = True
        Me.cboFactor44.IntegralHeight = False
        Me.cboFactor44.ItemHeight = 14
        Me.cboFactor44.Location = New System.Drawing.Point(213, 92)
        Me.cboFactor44.Name = "cboFactor44"
        Me.cboFactor44.Size = New System.Drawing.Size(161, 22)
        Me.cboFactor44.TabIndex = 32
        '
        'chkF4
        '
        Me.chkF4.AutoSize = True
        Me.chkF4.Location = New System.Drawing.Point(16, 96)
        Me.chkF4.Name = "chkF4"
        Me.chkF4.Size = New System.Drawing.Size(72, 18)
        Me.chkF4.TabIndex = 31
        Me.chkF4.Text = "Factor4"
        Me.chkF4.UseVisualStyleBackColor = True
        '
        'cboFactor33
        '
        Me.cboFactor33.FormattingEnabled = True
        Me.cboFactor33.Location = New System.Drawing.Point(213, 67)
        Me.cboFactor33.Name = "cboFactor33"
        Me.cboFactor33.Size = New System.Drawing.Size(161, 22)
        Me.cboFactor33.TabIndex = 30
        '
        'chkF3
        '
        Me.chkF3.AutoSize = True
        Me.chkF3.Location = New System.Drawing.Point(16, 71)
        Me.chkF3.Name = "chkF3"
        Me.chkF3.Size = New System.Drawing.Size(72, 18)
        Me.chkF3.TabIndex = 29
        Me.chkF3.Text = "Factor3"
        Me.chkF3.UseVisualStyleBackColor = True
        '
        'cboFactor22
        '
        Me.cboFactor22.FormattingEnabled = True
        Me.cboFactor22.Location = New System.Drawing.Point(213, 42)
        Me.cboFactor22.Name = "cboFactor22"
        Me.cboFactor22.Size = New System.Drawing.Size(161, 22)
        Me.cboFactor22.TabIndex = 28
        '
        'chkF2
        '
        Me.chkF2.AutoSize = True
        Me.chkF2.Location = New System.Drawing.Point(16, 46)
        Me.chkF2.Name = "chkF2"
        Me.chkF2.Size = New System.Drawing.Size(72, 18)
        Me.chkF2.TabIndex = 27
        Me.chkF2.Text = "Factor2"
        Me.chkF2.UseVisualStyleBackColor = True
        '
        'cboFactor11
        '
        Me.cboFactor11.FormattingEnabled = True
        Me.cboFactor11.Location = New System.Drawing.Point(213, 17)
        Me.cboFactor11.Name = "cboFactor11"
        Me.cboFactor11.Size = New System.Drawing.Size(161, 22)
        Me.cboFactor11.TabIndex = 26
        '
        'chkF1
        '
        Me.chkF1.AutoSize = True
        Me.chkF1.Location = New System.Drawing.Point(16, 21)
        Me.chkF1.Name = "chkF1"
        Me.chkF1.Size = New System.Drawing.Size(72, 18)
        Me.chkF1.TabIndex = 25
        Me.chkF1.Text = "Factor1"
        Me.chkF1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 187)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Option 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtTSQL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(522, 187)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "txtSQL"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtTSQL
        '
        Me.txtTSQL.ForeColor = System.Drawing.Color.Blue
        Me.txtTSQL.Location = New System.Drawing.Point(11, 6)
        Me.txtTSQL.Multiline = True
        Me.txtTSQL.Name = "txtTSQL"
        Me.txtTSQL.Size = New System.Drawing.Size(465, 175)
        Me.txtTSQL.TabIndex = 37
        '
        'optStk
        '
        Me.optStk.AutoSize = True
        Me.optStk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optStk.Location = New System.Drawing.Point(6, 14)
        Me.optStk.Name = "optStk"
        Me.optStk.Size = New System.Drawing.Size(78, 18)
        Me.optStk.TabIndex = 17
        Me.optStk.Text = "ตามสินค้า"
        Me.optStk.UseVisualStyleBackColor = True
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.Yellow
        Me.lbStkCode.Location = New System.Drawing.Point(81, 41)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(282, 22)
        Me.lbStkCode.TabIndex = 13
        '
        'chkNotDoc
        '
        Me.chkNotDoc.AutoSize = True
        Me.chkNotDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNotDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNotDoc.Location = New System.Drawing.Point(259, 134)
        Me.chkNotDoc.Name = "chkNotDoc"
        Me.chkNotDoc.Size = New System.Drawing.Size(68, 18)
        Me.chkNotDoc.TabIndex = 37
        Me.chkNotDoc.Text = "ไม่เลือก"
        Me.chkNotDoc.UseVisualStyleBackColor = True
        '
        'txtSelectNo
        '
        Me.txtSelectNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSelectNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelectNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelectNo.Location = New System.Drawing.Point(87, 127)
        Me.txtSelectNo.MaxLength = 20
        Me.txtSelectNo.Name = "txtSelectNo"
        Me.txtSelectNo.Size = New System.Drawing.Size(166, 26)
        Me.txtSelectNo.TabIndex = 3
        '
        'chkDocNo
        '
        Me.chkDocNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDocNo.Location = New System.Drawing.Point(6, 131)
        Me.chkDocNo.Name = "chkDocNo"
        Me.chkDocNo.Size = New System.Drawing.Size(120, 24)
        Me.chkDocNo.TabIndex = 2
        Me.chkDocNo.Text = "ส่วนเลขที่"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboDType)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.lbDate01)
        Me.GroupBox3.Controls.Add(Me.chkDate)
        Me.GroupBox3.Controls.Add(Me.lbDate02)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 354)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1110, 348)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.lbWHname)
        Me.GroupBox5.Controls.Add(Me.lbWHCode)
        Me.GroupBox5.Controls.Add(Me.lbFindWh)
        Me.GroupBox5.Controls.Add(Me.chkWH)
        Me.GroupBox5.Controls.Add(Me.txtSelectNo)
        Me.GroupBox5.Controls.Add(Me.chkDocNo)
        Me.GroupBox5.Controls.Add(Me.chkNotDoc)
        Me.GroupBox5.Controls.Add(Me.lbSaleID)
        Me.GroupBox5.Controls.Add(Me.lbSaleName2)
        Me.GroupBox5.Controls.Add(Me.lbCusID)
        Me.GroupBox5.Controls.Add(Me.lbSaleID2)
        Me.GroupBox5.Controls.Add(Me.lbFindSale2)
        Me.GroupBox5.Controls.Add(Me.chkOptSale2)
        Me.GroupBox5.Controls.Add(Me.chkSelCustom)
        Me.GroupBox5.Controls.Add(Me.chkOptSale)
        Me.GroupBox5.Controls.Add(Me.lbFindSale)
        Me.GroupBox5.Controls.Add(Me.lbCusName)
        Me.GroupBox5.Controls.Add(Me.lbFindCus)
        Me.GroupBox5.Controls.Add(Me.lbSaleName)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(4, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(548, 159)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkNotSale)
        Me.GroupBox7.Controls.Add(Me.chkSelSale)
        Me.GroupBox7.Location = New System.Drawing.Point(370, 62)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(172, 36)
        Me.GroupBox7.TabIndex = 43
        Me.GroupBox7.TabStop = False
        '
        'chkNotSale
        '
        Me.chkNotSale.Checked = True
        Me.chkNotSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNotSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkNotSale.Location = New System.Drawing.Point(90, 13)
        Me.chkNotSale.Name = "chkNotSale"
        Me.chkNotSale.Size = New System.Drawing.Size(72, 16)
        Me.chkNotSale.TabIndex = 24
        Me.chkNotSale.TabStop = True
        Me.chkNotSale.Text = "ไม่เลือก"
        '
        'chkSelSale
        '
        Me.chkSelSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSelSale.Location = New System.Drawing.Point(5, 14)
        Me.chkSelSale.Name = "chkSelSale"
        Me.chkSelSale.Size = New System.Drawing.Size(83, 16)
        Me.chkSelSale.TabIndex = 23
        Me.chkSelSale.Text = "เลือก Sale"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkNotSale2)
        Me.GroupBox1.Controls.Add(Me.chkSelSale2)
        Me.GroupBox1.Location = New System.Drawing.Point(369, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 35)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'chkNotSale2
        '
        Me.chkNotSale2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNotSale2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkNotSale2.Location = New System.Drawing.Point(93, 12)
        Me.chkNotSale2.Name = "chkNotSale2"
        Me.chkNotSale2.Size = New System.Drawing.Size(73, 21)
        Me.chkNotSale2.TabIndex = 31
        Me.chkNotSale2.Text = "ไม่เลือก Sale"
        '
        'chkSelSale2
        '
        Me.chkSelSale2.Checked = True
        Me.chkSelSale2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSale2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSelSale2.Location = New System.Drawing.Point(5, 11)
        Me.chkSelSale2.Name = "chkSelSale2"
        Me.chkSelSale2.Size = New System.Drawing.Size(89, 22)
        Me.chkSelSale2.TabIndex = 30
        Me.chkSelSale2.TabStop = True
        Me.chkSelSale2.Text = "เลือก Sale"
        '
        'lbWHname
        '
        Me.lbWHname.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbWHname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHname.ForeColor = System.Drawing.Color.White
        Me.lbWHname.Location = New System.Drawing.Point(179, 43)
        Me.lbWHname.Name = "lbWHname"
        Me.lbWHname.Size = New System.Drawing.Size(187, 24)
        Me.lbWHname.TabIndex = 39
        '
        'lbWHCode
        '
        Me.lbWHCode.BackColor = System.Drawing.Color.Yellow
        Me.lbWHCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHCode.Location = New System.Drawing.Point(86, 43)
        Me.lbWHCode.Name = "lbWHCode"
        Me.lbWHCode.Size = New System.Drawing.Size(64, 24)
        Me.lbWHCode.TabIndex = 38
        Me.lbWHCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbFindWh
        '
        Me.lbFindWh.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindWh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindWh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindWh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindWh.Location = New System.Drawing.Point(150, 43)
        Me.lbFindWh.Name = "lbFindWh"
        Me.lbFindWh.Size = New System.Drawing.Size(24, 24)
        Me.lbFindWh.TabIndex = 40
        Me.lbFindWh.Text = "..."
        Me.lbFindWh.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'chkWH
        '
        Me.chkWH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkWH.ForeColor = System.Drawing.Color.Black
        Me.chkWH.Location = New System.Drawing.Point(5, 47)
        Me.chkWH.Name = "chkWH"
        Me.chkWH.Size = New System.Drawing.Size(121, 21)
        Me.chkWH.TabIndex = 41
        Me.chkWH.Text = "คลังสินค้า"
        '
        'lbSaleID
        '
        Me.lbSaleID.BackColor = System.Drawing.Color.Yellow
        Me.lbSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleID.Location = New System.Drawing.Point(86, 71)
        Me.lbSaleID.Name = "lbSaleID"
        Me.lbSaleID.Size = New System.Drawing.Size(64, 24)
        Me.lbSaleID.TabIndex = 18
        Me.lbSaleID.Text = "SL03"
        Me.lbSaleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSaleName2
        '
        Me.lbSaleName2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbSaleName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleName2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleName2.ForeColor = System.Drawing.Color.White
        Me.lbSaleName2.Location = New System.Drawing.Point(179, 99)
        Me.lbSaleName2.Name = "lbSaleName2"
        Me.lbSaleName2.Size = New System.Drawing.Size(187, 24)
        Me.lbSaleName2.TabIndex = 28
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Yellow
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(86, 15)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(64, 24)
        Me.lbCusID.TabIndex = 13
        Me.lbCusID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSaleID2
        '
        Me.lbSaleID2.BackColor = System.Drawing.Color.Yellow
        Me.lbSaleID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleID2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleID2.Location = New System.Drawing.Point(86, 99)
        Me.lbSaleID2.Name = "lbSaleID2"
        Me.lbSaleID2.Size = New System.Drawing.Size(64, 24)
        Me.lbSaleID2.TabIndex = 27
        Me.lbSaleID2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbFindSale2
        '
        Me.lbFindSale2.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindSale2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindSale2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindSale2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindSale2.Location = New System.Drawing.Point(150, 99)
        Me.lbFindSale2.Name = "lbFindSale2"
        Me.lbFindSale2.Size = New System.Drawing.Size(24, 24)
        Me.lbFindSale2.TabIndex = 29
        Me.lbFindSale2.Text = "..."
        Me.lbFindSale2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'chkOptSale2
        '
        Me.chkOptSale2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOptSale2.ForeColor = System.Drawing.Color.Black
        Me.chkOptSale2.Location = New System.Drawing.Point(5, 103)
        Me.chkOptSale2.Name = "chkOptSale2"
        Me.chkOptSale2.Size = New System.Drawing.Size(121, 21)
        Me.chkOptSale2.TabIndex = 32
        Me.chkOptSale2.Text = "Sale ลูกค้า"
        '
        'chkSelCustom
        '
        Me.chkSelCustom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelCustom.Location = New System.Drawing.Point(6, 21)
        Me.chkSelCustom.Name = "chkSelCustom"
        Me.chkSelCustom.Size = New System.Drawing.Size(90, 16)
        Me.chkSelCustom.TabIndex = 16
        Me.chkSelCustom.Text = "เลือกลูกค้า"
        '
        'chkOptSale
        '
        Me.chkOptSale.Checked = True
        Me.chkOptSale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOptSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOptSale.ForeColor = System.Drawing.Color.Black
        Me.chkOptSale.Location = New System.Drawing.Point(5, 76)
        Me.chkOptSale.Name = "chkOptSale"
        Me.chkOptSale.Size = New System.Drawing.Size(89, 16)
        Me.chkOptSale.TabIndex = 25
        Me.chkOptSale.Text = "Sale หัวบิล"
        '
        'lbFindSale
        '
        Me.lbFindSale.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindSale.Location = New System.Drawing.Point(150, 71)
        Me.lbFindSale.Name = "lbFindSale"
        Me.lbFindSale.Size = New System.Drawing.Size(24, 24)
        Me.lbFindSale.TabIndex = 20
        Me.lbFindSale.Text = "..."
        Me.lbFindSale.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(179, 15)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(187, 24)
        Me.lbCusName.TabIndex = 14
        '
        'lbFindCus
        '
        Me.lbFindCus.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindCus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindCus.Location = New System.Drawing.Point(150, 15)
        Me.lbFindCus.Name = "lbFindCus"
        Me.lbFindCus.Size = New System.Drawing.Size(24, 24)
        Me.lbFindCus.TabIndex = 15
        Me.lbFindCus.Text = "..."
        Me.lbFindCus.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbSaleName
        '
        Me.lbSaleName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleName.ForeColor = System.Drawing.Color.White
        Me.lbSaleName.Location = New System.Drawing.Point(178, 71)
        Me.lbSaleName.Name = "lbSaleName"
        Me.lbSaleName.Size = New System.Drawing.Size(188, 24)
        Me.lbSaleName.TabIndex = 19
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(739, 18)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(50, 20)
        Me.chkDate.TabIndex = 25
        Me.chkDate.Text = "วันที่"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkGrpBySale)
        Me.GroupBox4.Controls.Add(Me.chkGrpByCustom)
        Me.GroupBox4.Controls.Add(Me.chkNoGrpBy)
        Me.GroupBox4.Controls.Add(Me.chkGrpByStk)
        Me.GroupBox4.Controls.Add(Me.chkGrpByDoc)
        Me.GroupBox4.Controls.Add(Me.chkOnDetail)
        Me.GroupBox4.Controls.Add(Me.chkProDDetl)
        Me.GroupBox4.Controls.Add(Me.chkCost)
        Me.GroupBox4.Controls.Add(Me.chkDisplStk)
        Me.GroupBox4.Controls.Add(Me.chkDispSale)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 194)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(548, 147)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'chkGrpBySale
        '
        Me.chkGrpBySale.AutoSize = True
        Me.chkGrpBySale.Enabled = False
        Me.chkGrpBySale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpBySale.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpBySale.Location = New System.Drawing.Point(342, 120)
        Me.chkGrpBySale.Name = "chkGrpBySale"
        Me.chkGrpBySale.Size = New System.Drawing.Size(137, 20)
        Me.chkGrpBySale.TabIndex = 24
        Me.chkGrpBySale.TabStop = True
        Me.chkGrpBySale.Text = "รวมรายการตาม Sale"
        Me.chkGrpBySale.UseVisualStyleBackColor = True
        '
        'chkGrpByCustom
        '
        Me.chkGrpByCustom.AutoSize = True
        Me.chkGrpByCustom.Enabled = False
        Me.chkGrpByCustom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByCustom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpByCustom.Location = New System.Drawing.Point(341, 68)
        Me.chkGrpByCustom.Name = "chkGrpByCustom"
        Me.chkGrpByCustom.Size = New System.Drawing.Size(138, 20)
        Me.chkGrpByCustom.TabIndex = 23
        Me.chkGrpByCustom.TabStop = True
        Me.chkGrpByCustom.Text = "รวมรายการตามลูกค้า"
        Me.chkGrpByCustom.UseVisualStyleBackColor = True
        '
        'chkNoGrpBy
        '
        Me.chkNoGrpBy.AutoSize = True
        Me.chkNoGrpBy.Checked = True
        Me.chkNoGrpBy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNoGrpBy.ForeColor = System.Drawing.Color.Black
        Me.chkNoGrpBy.Location = New System.Drawing.Point(341, 17)
        Me.chkNoGrpBy.Name = "chkNoGrpBy"
        Me.chkNoGrpBy.Size = New System.Drawing.Size(119, 20)
        Me.chkNoGrpBy.TabIndex = 22
        Me.chkNoGrpBy.TabStop = True
        Me.chkNoGrpBy.Text = "แยกรายละเอียด"
        Me.chkNoGrpBy.UseVisualStyleBackColor = True
        '
        'chkGrpByStk
        '
        Me.chkGrpByStk.AutoSize = True
        Me.chkGrpByStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByStk.ForeColor = System.Drawing.Color.Black
        Me.chkGrpByStk.Location = New System.Drawing.Point(341, 42)
        Me.chkGrpByStk.Name = "chkGrpByStk"
        Me.chkGrpByStk.Size = New System.Drawing.Size(153, 20)
        Me.chkGrpByStk.TabIndex = 21
        Me.chkGrpByStk.TabStop = True
        Me.chkGrpByStk.Text = "รวมรายการตามสินค้า"
        Me.chkGrpByStk.UseVisualStyleBackColor = True
        '
        'chkGrpByDoc
        '
        Me.chkGrpByDoc.AutoSize = True
        Me.chkGrpByDoc.Enabled = False
        Me.chkGrpByDoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpByDoc.Location = New System.Drawing.Point(341, 94)
        Me.chkGrpByDoc.Name = "chkGrpByDoc"
        Me.chkGrpByDoc.Size = New System.Drawing.Size(148, 20)
        Me.chkGrpByDoc.TabIndex = 20
        Me.chkGrpByDoc.TabStop = True
        Me.chkGrpByDoc.Text = "รวมรายการตามเอกสาร"
        Me.chkGrpByDoc.UseVisualStyleBackColor = True
        '
        'chkOnDetail
        '
        Me.chkOnDetail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOnDetail.Location = New System.Drawing.Point(179, 16)
        Me.chkOnDetail.Name = "chkOnDetail"
        Me.chkOnDetail.Size = New System.Drawing.Size(135, 24)
        Me.chkOnDetail.TabIndex = 13
        Me.chkOnDetail.Text = "ต้องการดูรายละเอียด"
        Me.chkOnDetail.Visible = False
        '
        'chkProDDetl
        '
        Me.chkProDDetl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkProDDetl.Location = New System.Drawing.Point(23, 88)
        Me.chkProDDetl.Name = "chkProDDetl"
        Me.chkProDDetl.Size = New System.Drawing.Size(241, 24)
        Me.chkProDDetl.TabIndex = 18
        Me.chkProDDetl.Text = "แสดงรายละเอียดสินค้า ( ประเภท/กลุ่ม/สี )"
        '
        'chkCost
        '
        Me.chkCost.Checked = True
        Me.chkCost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCost.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCost.Location = New System.Drawing.Point(23, 61)
        Me.chkCost.Name = "chkCost"
        Me.chkCost.Size = New System.Drawing.Size(221, 24)
        Me.chkCost.TabIndex = 17
        Me.chkCost.Text = "แสดง-กำไร/ขาดทุน"
        '
        'chkDisplStk
        '
        Me.chkDisplStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDisplStk.Location = New System.Drawing.Point(23, 36)
        Me.chkDisplStk.Name = "chkDisplStk"
        Me.chkDisplStk.Size = New System.Drawing.Size(152, 24)
        Me.chkDisplStk.TabIndex = 15
        Me.chkDisplStk.Text = "แสดงสต๊อกคงเหลือ"
        '
        'chkDispSale
        '
        Me.chkDispSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDispSale.Location = New System.Drawing.Point(23, 20)
        Me.chkDispSale.Name = "chkDispSale"
        Me.chkDispSale.Size = New System.Drawing.Size(176, 16)
        Me.chkDispSale.TabIndex = 14
        Me.chkDispSale.Text = "แสดงรายชื่อพนักงานขาย"
        '
        'lsvShow
        '
        Me.lsvShow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.Location = New System.Drawing.Point(7, 6)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(1235, 305)
        Me.lsvShow.TabIndex = 21
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-132, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "จำนวนรายการ"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(365, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "จำนวน"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(558, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "น้ำหนัก"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(806, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "มูลค่าขาย"
        '
        'lbTranQty
        '
        Me.lbTranQty.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTranQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTranQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTranQty.ForeColor = System.Drawing.Color.White
        Me.lbTranQty.Location = New System.Drawing.Point(216, 17)
        Me.lbTranQty.Name = "lbTranQty"
        Me.lbTranQty.Size = New System.Drawing.Size(96, 24)
        Me.lbTranQty.TabIndex = 26
        Me.lbTranQty.Text = "0"
        Me.lbTranQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty1
        '
        Me.lbQty1.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty1.ForeColor = System.Drawing.Color.White
        Me.lbQty1.Location = New System.Drawing.Point(405, 17)
        Me.lbQty1.Name = "lbQty1"
        Me.lbQty1.Size = New System.Drawing.Size(104, 24)
        Me.lbQty1.TabIndex = 27
        Me.lbQty1.Text = "0"
        Me.lbQty1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty2
        '
        Me.lbQty2.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbQty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbQty2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbQty2.ForeColor = System.Drawing.Color.White
        Me.lbQty2.Location = New System.Drawing.Point(601, 17)
        Me.lbQty2.Name = "lbQty2"
        Me.lbQty2.Size = New System.Drawing.Size(128, 24)
        Me.lbQty2.TabIndex = 28
        Me.lbQty2.Text = "0"
        Me.lbQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(988, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 24)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "บาท"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(735, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 24)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Kg."
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(515, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "แผ่น"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(314, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 24)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "รายการ"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbCostAmt)
        Me.GroupBox6.Controls.Add(Me.indexBar)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.lbQty2)
        Me.GroupBox6.Controls.Add(Me.lbAmt)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.lbQty1)
        Me.GroupBox6.Controls.Add(Me.lbTranQty)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 309)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1234, 47)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        '
        'lbCostAmt
        '
        Me.lbCostAmt.BackColor = System.Drawing.Color.Blue
        Me.lbCostAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCostAmt.ForeColor = System.Drawing.Color.White
        Me.lbCostAmt.Location = New System.Drawing.Point(1071, 17)
        Me.lbCostAmt.Name = "lbCostAmt"
        Me.lbCostAmt.Size = New System.Drawing.Size(117, 23)
        Me.lbCostAmt.TabIndex = 38
        Me.lbCostAmt.Text = "0"
        Me.lbCostAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'indexBar
        '
        Me.indexBar.BackColor = System.Drawing.Color.Red
        Me.indexBar.Location = New System.Drawing.Point(11, 18)
        Me.indexBar.Name = "indexBar"
        Me.indexBar.Size = New System.Drawing.Size(197, 23)
        Me.indexBar.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(1194, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "บาท"
        '
        'lbAmt
        '
        Me.lbAmt.BackColor = System.Drawing.Color.Blue
        Me.lbAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAmt.ForeColor = System.Drawing.Color.White
        Me.lbAmt.Location = New System.Drawing.Point(865, 17)
        Me.lbAmt.Name = "lbAmt"
        Me.lbAmt.Size = New System.Drawing.Size(117, 23)
        Me.lbAmt.TabIndex = 34
        Me.lbAmt.Text = "0"
        Me.lbAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(1029, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "กำไร"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.cmbPrint)
        Me.GroupBox8.Controls.Add(Me.cmbRun)
        Me.GroupBox8.Controls.Add(Me.cmbExit)
        Me.GroupBox8.Location = New System.Drawing.Point(1119, 354)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(127, 346)
        Me.GroupBox8.TabIndex = 36
        Me.GroupBox8.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbPrint
        '
        Me.cmbPrint.Location = New System.Drawing.Point(10, 73)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmbPrint.TabIndex = 25
        Me.cmbPrint.Text = "Print"
        '
        'cmbRun
        '
        Me.cmbRun.Location = New System.Drawing.Point(10, 22)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(104, 32)
        Me.cmbRun.TabIndex = 23
        Me.cmbRun.Text = "Run"
        '
        'cmbExit
        '
        Me.cmbExit.Location = New System.Drawing.Point(12, 175)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(104, 32)
        Me.cmbExit.TabIndex = 24
        Me.cmbExit.Text = "Exit"
        '
        'Worker1
        '
        '
        'frmReport2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1274, 705)
        Me.Controls.Add(Me.lsvShow)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.KeyPreview = True
        Me.Name = "frmReport2"
        Me.Text = "รายงานการเคลื่อนไหวสินค้า /ตามเอกสาร / ตามสินค้า  18-02-2556"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim subDA As Data.SqlClient.SqlDataAdapter
    Dim subDS As New Data.DataSet
    Dim chkData As Boolean

    Dim lvi As ListViewItem

    Dim chkRow As Boolean = False
    Dim chkcol As Boolean = True

    Dim chkProdList As Boolean = False
    Dim chkGrpC As Boolean = False
    Dim chkColorC As Boolean = False

    Dim chkProfit As Boolean = False

    Dim chkFac1 As Boolean = False
    Dim chkFac2 As Boolean = False
    Dim chkFac3 As Boolean = False
    Dim chkFac4 As Boolean = False
    Dim chkFac5 As Boolean = False

    Dim chkFac11 As Boolean = False
    Dim chkFac22 As Boolean = False
    Dim chkFac33 As Boolean = False
    Dim chkFac44 As Boolean = False
    Dim chkFac55 As Boolean = False

    Dim frmFindStk As frmFindStk = New frmFindStk


    'Dim rpt1 As testReport3 = New testReport3



    Sub getColListView()


        'If chkFullOpt.Checked = True Then
        '    lsvShow.Columns.Add("จอง", 90, HorizontalAlignment.Right)
        '    lsvShow.Columns.Add("ค้างส่ง", 90, HorizontalAlignment.Right)
        'Else

        'End If
        'If optDoc.Checked = True Then
        lsvShow.Columns.Add("Type", 5, HorizontalAlignment.Center)
        lsvShow.Columns.Add("ลำดับ", 50, HorizontalAlignment.Center)
        lsvShow.Columns.Add("วันที่ ", 80, HorizontalAlignment.Center)
        lsvShow.Columns.Add("คลัง", 40, HorizontalAlignment.Right)
        lsvShow.Columns.Add("เลขที่", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("ลูกค้า", 200, HorizontalAlignment.Left)
        'If CStr(cboDType.SelectedValue) = "S" Then
        If chkDispSale.Checked = True OrElse chkOptSale.Checked = True Then
            lsvShow.Columns.Add("หัวบิล", 70, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("หัวบิล", 1, HorizontalAlignment.Left)
        End If
        If chkDispSale.Checked = True OrElse chkOptSale2.Checked = True Then
            lsvShow.Columns.Add("Sale", 70, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("Sale", 1, HorizontalAlignment.Left)
        End If

        'End If

        If CStr(cboDType.SelectedValue) = "S" Then
            lsvShow.Columns.Add("เก็บ", 2, HorizontalAlignment.Center)
        Else
            lsvShow.Columns.Add("เก็บ", 90, HorizontalAlignment.Center)
        End If

        lsvShow.Columns.Add("รายการ", 300, HorizontalAlignment.Left)

        lsvShow.Columns.Add("จำนวน(แผ่น)", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("จำนวน(Kg.)", 90, HorizontalAlignment.Right)
        If chkCost.Checked = True Then    '  แสดง กำไร/ขาดทุน 
            lsvShow.Columns.Add("ต้นทุน/Unit.", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("ต้นทุนขาย", 90, HorizontalAlignment.Right)

        End If
        lsvShow.Columns.Add("ราคาขาย/kg", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ราคา/แผ่น", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("มูลค่าขาย", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("กำไร", 90, HorizontalAlignment.Right)

        If chkDisplStk.Checked = True Then

            lsvShow.Columns.Add("คงเหลือ(แผ่น)", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("คงเหลือ(Kg.)", 90, HorizontalAlignment.Right)

        End If

        If chkProDDetl.Checked = True Then
            lsvShow.Columns.Add("Product Grp", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("ประเภท", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("กลุ่มย่อย", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("Color", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("หนา", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("ขนาด", 90, HorizontalAlignment.Right)
            'lsvShow.Columns.Add("Paper", 90, HorizontalAlignment.Right)
            lsvShow.Columns.Add("เกรด", 90, HorizontalAlignment.Right)
        End If




        lsvShow.Columns.Add("user", 90, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("จ่าย", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("คงเหลือ", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("xxx", 100, HorizontalAlignment.Right)
        'lsvShow.Columns.Add("con_id", 80, HorizontalAlignment.Center)

        lsvShow.View = View.Details
        lsvShow.GridLines = True
        'chkCol = True

    End Sub

    Sub getItemDetail()
        Dim iRow As Integer = 0

        'Dim anyData1() As String
        Dim anyData() As String

        '   ตัวแปร ที่ใช้ในการคำนวน รายละเอียด

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String
        Dim dtlItem As String
        Dim stkCode As String = ""
        Dim dtlStkName As String
        Dim dtlType As String
        Dim whName As String = ""
        Dim dtlSaleName1 As String
        Dim dtlSaleName2 As String

        Dim Q_Iss As Double = 0
        Dim Q_Rcv As Double = 0
        Dim Q_Pen As Double = 0
        Dim Q_Order As Double = 0

        Dim Q_Bal As Double = 0
        Dim Q_Bal_F As Double = 0
        Dim Q_Bal_Q1 As Integer = 0

        Dim Dtl_Detail As String = ""
        Dim Q_Qty2 As Double = 0

        Dim Dtl_Cost_PR As Double = 0
        Dim Dtl_Cost_Amt As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Pr_Div_Q2 As Double = 0
        Dim Dtl_Amt As Double = 0
        Dim Dtl_ProFit As String

        Dim num As Double = 0
        Dim userCo As String = ""

        Dim ProGrp_Name As String = ""
        Dim Type_Name As String = ""
        Dim Grp_Name As String = ""
        Dim Color_Name As String = ""
        Dim Th_Name As String = "'"
        Dim Size_Name As String = ""
        Dim Grade_Name As String = ""


        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")
        lbCostAmt.Text = Format(0, "#,##0.00")

        With subDS.Tables("Command")

            If (subDS.Tables("Command").Rows.Count >= 1) Then

                For iRow = 0 To .Rows.Count - 1
                    rowNo = iRow + 1

                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                    Else

                        dtlType = CStr(.Rows(iRow).Item("Trh_Type"))
                        date01 = CDate(.Rows(iRow).Item("Trh_Date"))
                        strDocNo = CStr(.Rows(iRow).Item("Trh_No"))
                        stkCode = CStr(.Rows(iRow).Item("dtl_idTrade"))

                        If dtlType = "B" Or dtlType = "D" Then
                            whName = ""
                        Else
                            whName = CStr(dbTools.getStrName(.Rows(iRow).Item("Trh_Wh")))
                        End If


                        If dtlType = "S" Then
                            'dtlItem = "ขายสินค้าให้กับ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                            dtlItem = "ขายสินค้าให้ " & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "B" Then
                            'dtlItem = "Order สินค้าของ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                                dtlItem = " ******** ไม่พบข้อมูล ***********"
                            Else
                                dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                            End If

                        ElseIf dtlType = "D" Then
                            If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                                dtlItem = "รับผลิตเพื่อ ******** ไม่พบข้อมูล ***********"
                            Else

                                dtlItem = "รับผลิตเพื่อ " & CStr(.Rows(iRow).Item("Ar_Name")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            End If

                        ElseIf dtlType = "E" Then
                            dtlItem = "สั่งผลิตเพื่อ " & CStr(.Rows(iRow).Item("Ar_Name")) '
                        ElseIf dtlType = "G" Then
                            dtlItem = "รับสินค้าจากการรีเกรด."
                        ElseIf dtlType = "F" Then
                            dtlItem = "รับโอนสินค้าเข้าคลัง " & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "P" Then

                            If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                                dtlItem = "เบิกสินค้าเพื่อขาย "
                            Else
                                dtlItem = "เบิกสินค้าเพื่อขาย " & CStr(.Rows(iRow).Item("Ar_Name"))
                            End If

                        ElseIf dtlType = "Z" Then
                            dtlItem = "โอนสินค้าออกจากคลัง " & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "A" Then
                            dtlItem = "ปรับยอดการตรวจนับ" & "-" & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "Q" Then
                            If IsDBNull(.Rows(iRow).Item("Trh_date")) Then
                                dtlItem = "ตรวจนับสินค้า "
                            Else
                                dtlItem = "ตรวจนับสินค้า วันที่ " & .Rows(iRow).Item("Trh_date").ToString
                            End If

                        Else
                            dtlItem = " ******** ไม่พบข้อมูล ***********"
                        End If

                        If IsDBNull(.Rows(iRow).Item("Dtl_Detail")) Then
                            Dtl_Detail = " ******** ไม่พบข้อมูล ***********"
                        Else
                            Dtl_Detail = CStr(.Rows(iRow).Item("Dtl_Detail"))
                        End If

                        If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                            dtlStkName = " ******** ไม่พบข้อมูล ***********"
                        Else
                            dtlStkName = CStr(.Rows(iRow).Item("Stk_Name_1"))
                        End If


                        Q_Iss = 0
                        Q_Rcv = 0
                        Q_Order = 0
                        Q_Pen = 0
                        Q_Qty2 = 0
                        Dtl_Price = 0
                        Dtl_Amt = 0
                        Q_Bal_Q1 = 0
                        num = 0
                        Dtl_Cost_Amt = 0
                        Dtl_Cost_PR = 0
                        Dtl_ProFit = ""
                        chkProfit = False


                        If IsDBNull(.Rows(iRow).Item("Dtl_Num")) Then
                            num = 0
                        Else
                            num = CDbl(.Rows(iRow).Item("Dtl_Num"))
                        End If
                        'Q_Bal = 0
                        '===========================================================================================================
                        If dtlType = "S" Then
                            Q_Rcv = num
                        ElseIf dtlType = "P" Then
                            Q_Rcv = num
                        ElseIf dtlType = "U" Then
                            Q_Rcv = num
                        ElseIf dtlType = "B" Then
                            Q_Rcv = num
                            Q_Pen = num - CDbl(.Rows(iRow).Item("Dtl_num_2"))
                        ElseIf dtlType = "D" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "E" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "G" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "F" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "Z" Then
                            Q_Rcv = num
                        ElseIf dtlType = "A" Then
                            Q_Rcv = num
                        ElseIf dtlType = "Q" Then
                            Q_Rcv = num

                        End If
                        '=====================================================================================================
                        If IsDBNull(.Rows(iRow).Item("Stk_Factor2")) Then
                            Q_Qty2 = Q_Rcv
                        Else
                            Q_Qty2 = (Q_Rcv * CDbl(.Rows(iRow).Item("Stk_Factor2")))
                        End If

                        If IsDBNull(.Rows(iRow).Item("Dtl_Price")) Then
                            Dtl_Price = 0
                        Else
                            Dtl_Price = CDbl(.Rows(iRow).Item("Dtl_Price"))

                            Dtl_Amt = (Q_Rcv * Dtl_Price)
                            Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / Q_Qty2)
                        End If

                        'If IsDBNull(dbTools.getCostType(stkCode)) Then
                        '    Dtl_Cost_Amt = 0
                        '    Dtl_Cost_PR = 0
                        '    Dtl_ProFit = "ยังไม่มีต้นทุน"
                        '    chkProfit = False
                        'Else
                        '=============== ต้นทุน   CS_Type=1   คิดต้นทุนต่อ แผ่น / หน่วย
                        If dbTools.getCostType(stkCode) = 0 Then

                            'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                            Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))

                        ElseIf dbTools.getCostType(stkCode) = 1 Then

                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                            Dtl_Cost_Amt = Dtl_Cost_PR * num
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))

                        Else

                            'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                            Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))

                        End If

                        If Dtl_Cost_Amt = 0 Then
                            chkProfit = False
                        ElseIf (Dtl_Amt > Dtl_Cost_Amt) Then

                            chkProfit = True
                        Else
                            chkProfit = False

                        End If

                        'End If

                        'If chkOptSale.Checked = True Then

                        'End If
                        'If chkOptSale2.Checked = True Then

                        'End If


                        'If chkOptSale.Checked = True Then
                        'If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then

                        If IsDBNull(.Rows(iRow).Item("Sale1")) Then
                            dtlSaleName1 = ""
                        Else
                            dtlSaleName1 = CStr(.Rows(iRow).Item("Sale1"))
                        End If
                        If chkDisplStk.Checked = True Then
                            If IsDBNull(.Rows(iRow).Item("sumQtyBalQ1")) Then
                                Q_Bal_Q1 = 0
                            Else
                                Q_Bal_Q1 = CInt(.Rows(iRow).Item("sumQtyBalQ1"))
                                Q_Bal_F = (Q_Bal_Q1 * CDbl(.Rows(iRow).Item("Stk_Factor2")))

                            End If

                        End If


                        'End If
                        'End If

                        'If chkOptSale2.Checked = True Then
                        'If Len(lbSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then
                        If IsDBNull(.Rows(iRow).Item("Sale2")) Then
                            dtlSaleName2 = ""
                        Else
                            dtlSaleName2 = CStr(.Rows(iRow).Item("Sale2"))
                        End If

                        If chkProDDetl.Checked = True Then

                            ProGrp_Name = CStr(.Rows(iRow).Item("ProGrp_Name"))
                            Type_Name = CStr(.Rows(iRow).Item("Type_Name"))
                            Grp_Name = CStr(.Rows(iRow).Item("Grp_Name"))
                            Color_Name = CStr(.Rows(iRow).Item("Color_Name"))
                            Th_Name = CStr(.Rows(iRow).Item("Th_Name3"))
                            Size_Name = CStr(.Rows(iRow).Item("Size_Name"))
                            Grade_Name = CStr(.Rows(iRow).Item("G_Name"))

                        End If

                        'End If
                        'End If

                        '=======================   control  Total label  

                        lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                        lbQty1.Text = Format(Q_Rcv + CInt(lbQty1.Text), "#,##0.00")
                        lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                        lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")
                        lbCostAmt.Text = CStr(Format(CDbl(lbCostAmt.Text) + CDbl(Dtl_Amt - Dtl_Cost_Amt), "#,##0.00"))


                        userCo = .Rows(iRow).Item("Trh_User").ToString

                        '                        anyData1 = New String() {}

                        If CStr(cboDType.SelectedValue) = "S" Or CStr(cboDType.SelectedValue) = "P" Then
                            If chkDisplStk.Checked = True Then

                                anyData = New String() _
                                     {dtlType, CStr(rowNo), CStr(date01), whName, strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                     Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                     Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}


                            Else
                                anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), whName, strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                    Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                    Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                    Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                    ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}

                            End If

                        Else
                            If chkDisplStk.Checked = True Then
                                anyData = New String() _
                                        {dtlType, CStr(rowNo), CStr(date01), whName, strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                        Dtl_Detail, dtlStkName, _
                                        Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                        Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}


                            Else
                                anyData = New String() _
                                        {dtlType, CStr(rowNo), CStr(date01), whName, strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                        Dtl_Detail, dtlStkName, _
                                        Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                        Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}

                            End If

                        End If

                        'If CStr(cboDType.SelectedValue) = "S" Or CStr(cboDType.SelectedValue) = "P" Then
                        '    If chkDisplStk.Checked = True Then
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Q_Bal_Q1.ToString("#,##0"), "0", ProGrp_Name}

                        '    Else
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), "0", ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}

                        '    End If

                        'Else
                        '    If chkDisplStk.Checked = True Then
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Q_Bal_Q1.ToString("#,##0"), userCo}

                        '    Else
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), userCo}

                        '    End If

                        'End If


                        lvi = New ListViewItem(anyData)
                        lsvShow.Items.Add(lvi)

                        If chkRow = False Then
                            chkRow = True
                        Else
                            chkRow = False
                        End If

                        Call colorList(dtlType)
                        'Exit For
                    End If

                Next

            End If
        End With


    End Sub

    Sub getDetailGrpByStk()
        Dim iRow As Integer = 0

        'Dim anyData1() As String
        Dim anyData() As String

        '   ตัวแปร ที่ใช้ในการคำนวน รายละเอียด

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String
        Dim dtlItem As String
        Dim stkCode As String = ""
        Dim dtlStkName As String
        Dim dtlType As String
        'Dim dtlConiD As String
        Dim dtlSaleName1 As String
        Dim dtlSaleName2 As String

        Dim Q_Iss As Double = 0
        Dim Q_Rcv As Double = 0
        Dim Q_Pen As Double = 0
        Dim Q_Order As Double = 0

        Dim Q_Bal As Double = 0
        Dim Q_Bal_F As Double = 0
        Dim Q_Bal_Q1 As Integer = 0

        Dim Dtl_Detail As String = ""
        Dim Q_Qty2 As Double = 0

        Dim Dtl_Cost_PR As Double = 0
        Dim Dtl_Cost_Amt As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Pr_Div_Q2 As Double = 0
        Dim Dtl_Amt As Double = 0
        Dim Dtl_ProFit As String

        Dim num As Double = 0
        Dim userCo As String = ""

        Dim ProGrp_Name As String = ""
        Dim Type_Name As String = ""
        Dim Grp_Name As String = ""
        Dim Color_Name As String = ""
        Dim Th_Name As String = "'"
        Dim Size_Name As String = ""
        Dim Grade_Name As String = ""


        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")
        lbCostAmt.Text = Format(0, "#,##0.00")

        With subDS.Tables("Command")

            If (subDS.Tables("Command").Rows.Count >= 1) Then

                For iRow = 0 To .Rows.Count - 1
                    rowNo = iRow + 1

                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                    Else

                        dtlType = CStr(.Rows(iRow).Item("Trh_Type"))
                        date01 = CDate(Format(Now, "yyyy/MM/dd"))
                        stkCode = CStr(.Rows(iRow).Item("dtl_idTrade"))

                        date01 = Now 'CDate(.Rows(iRow).Item("Trh_Date"))
                        strDocNo = "" 'CStr(.Rows(iRow).Item("Trh_No"))

                        If dtlType = "S" Then
                            'dtlItem = "ขายสินค้าให้กับ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                            dtlItem = "ขายสินค้า  " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "B" Then
                            'dtlItem = "Order สินค้าของ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            dtlItem = "Order สินค้า " ' & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "D" Then
                            If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                                dtlItem = "รับผลิตเพื่อ ******** ไม่พบข้อมูล ***********"
                            Else

                                dtlItem = "รับผลิตเพื่อ " '& CStr(.Rows(iRow).Item("Ar_Name")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            End If

                        ElseIf dtlType = "E" Then
                            dtlItem = "สั่งผลิต " ' & CStr(.Rows(iRow).Item("Ar_Name")) '
                        ElseIf dtlType = "G" Then
                            dtlItem = "รับสินค้าจากการรีเกรด."
                        ElseIf dtlType = "F" Then
                            dtlItem = "รับโอนสินค้า   " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "P" Then
                            dtlItem = "เบิกสินค้าเพื่อขาย "
                            'If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            '    dtlItem = "เบิกสินค้าเพื่อขาย "
                            'Else
                            '    dtlItem = "เบิกสินค้าเพื่อขาย " & CStr(.Rows(iRow).Item("Ar_Name"))
                            'End If

                        ElseIf dtlType = "Z" Then
                            dtlItem = "โอนสินค้าออกจากคลัง  " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "A" Then
                            dtlItem = "ปรับยอดการตรวจนับ " '& "-" & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "Q" Then
                            If IsDBNull(.Rows(iRow).Item("Trh_date")) Then
                                dtlItem = "ตรวจนับสินค้า "
                            Else
                                dtlItem = "ตรวจนับสินค้า " '" วันที่ " & .Rows(iRow).Item("Trh_date").ToString
                            End If

                        Else
                            dtlItem = ""
                        End If
                        Dtl_Detail = ""
                        'If IsDBNull(.Rows(iRow).Item("Dtl_Detail")) Then

                        'Else
                        '    Dtl_Detail = CStr(.Rows(iRow).Item("Dtl_Detail"))
                        'End If

                        If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                            dtlStkName = ""
                        Else
                            dtlStkName = CStr(.Rows(iRow).Item("Stk_Name_1"))
                        End If


                        Q_Iss = 0
                        Q_Rcv = 0
                        Q_Order = 0
                        Q_Pen = 0
                        Q_Qty2 = 0
                        Dtl_Price = 0
                        Dtl_Amt = 0
                        Q_Bal_Q1 = 0
                        num = 0
                        Dtl_Cost_Amt = 0
                        Dtl_Cost_PR = 0
                        Dtl_ProFit = ""
                        chkProfit = False
                        Dtl_Amt = 0




                        If IsDBNull(.Rows(iRow).Item("Dtl_Num")) Then
                            num = 0
                        Else
                            num = CDbl(.Rows(iRow).Item("Dtl_Num"))
                        End If
                        'Q_Bal = 0
                        '===========================================================================================================
                        If dtlType = "S" Then
                            Q_Rcv = num
                        ElseIf dtlType = "P" Then
                            Q_Rcv = num
                        ElseIf dtlType = "U" Then
                            Q_Rcv = num
                        ElseIf dtlType = "B" Then
                            Q_Rcv = num
                            Q_Pen = 0 'num - CDbl(.Rows(iRow).Item("Dtl_num_2"))
                        ElseIf dtlType = "D" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "E" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "G" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "F" Then

                            Q_Rcv = num
                            'Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "Z" Then
                            Q_Rcv = num
                        ElseIf dtlType = "A" Then
                            Q_Rcv = num
                        ElseIf dtlType = "Q" Then
                            Q_Rcv = num

                        End If
                        '=====================================================================================================
                        If IsDBNull(.Rows(iRow).Item("Stk_Factor2")) Then
                            Q_Qty2 = Q_Rcv
                        Else
                            Q_Qty2 = (Q_Rcv * CDbl(.Rows(iRow).Item("Stk_Factor2")))
                        End If
                        'Dtl_Price = CDbl(.Rows(iRow).Item("Dtlsum")) / num ' CDbl(.Rows(iRow).Item("Dtl_Num"))
                        'Dtl_Amt = CDbl(.Rows(iRow).Item("Dtlsum"))

                        'If IsDBNull(.Rows(iRow).Item("Dtl_Price")) Then

                        'Else
                        Dtl_Price = CDbl(.Rows(iRow).Item("Dtlsum")) / num

                        Dtl_Amt = CDbl(.Rows(iRow).Item("Dtlsum"))
                        Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / Q_Qty2)
                        'End If

                        If chkCost.Checked = True Then


                        End If

                        'If dbTools.getCostByStk(stkCode, date01) Then
                        '    Dtl_Cost_Amt = 0
                        '    Dtl_Cost_PR = 0
                        '    Dtl_ProFit = "ยังไม่มีต้นทุน"
                        '    chkProfit = False
                        'Else
                        ' =============== ต้นทุน   CS_Type=1   คิดต้นทุนต่อหน่วย
                        If dbTools.getCostType(stkCode) = 0 Then

                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0)
                            Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        ElseIf dbTools.getCostType(stkCode) = 1 Then
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0)
                            Dtl_Cost_Amt = Dtl_Cost_PR * num
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        Else
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, 0)
                            Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        End If

                        If (Dtl_Amt > Dtl_Cost_Amt) Then
                            chkProfit = True
                        Else
                            chkProfit = False
                        End If

                        'End If

                        'If chkOptSale.Checked = True Then

                        'End If
                        'If chkOptSale2.Checked = True Then

                        'End If


                        'If chkOptSale.Checked = True Then
                        'If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then

                        ' If IsDBNull(.Rows(iRow).Item("Sale1")) Then
                        dtlSaleName1 = ""
                        '    Else
                        '    dtlSaleName1 = CStr(.Rows(iRow).Item("Sale1"))
                        'End If
                        If chkDisplStk.Checked = True Then
                            If IsDBNull(.Rows(iRow).Item("sumQtyBalQ1")) Then
                                Q_Bal_Q1 = 0
                            Else
                                Q_Bal_Q1 = CInt(.Rows(iRow).Item("sumQtyBalQ1"))
                                Q_Bal_F = (Q_Bal_Q1 * CDbl(.Rows(iRow).Item("Stk_Factor2")))

                            End If

                        End If


                        'End If
                        'End If

                        'If chkOptSale2.Checked = True Then
                        'If Len(lbSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then
                        'If IsDBNull(.Rows(iRow).Item("Sale2")) Then
                        dtlSaleName2 = ""
                        '    Else
                        '    dtlSaleName2 = CStr(.Rows(iRow).Item("Sale2"))
                        'End If

                        If chkProDDetl.Checked = True Then

                            ProGrp_Name = CStr(.Rows(iRow).Item("ProGrp_Name"))
                            Type_Name = CStr(.Rows(iRow).Item("Type_Name"))
                            Grp_Name = CStr(.Rows(iRow).Item("Grp_Name"))
                            Color_Name = CStr(.Rows(iRow).Item("Color_Name"))
                            Th_Name = CStr(.Rows(iRow).Item("Th_Name3"))
                            Size_Name = CStr(.Rows(iRow).Item("Size_Name"))
                            Grade_Name = CStr(.Rows(iRow).Item("G_Name"))

                        End If

                        'End If
                        'End If

                        '=======================   control  Total label  

                        lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                        lbQty1.Text = Format(Q_Rcv + CInt(lbQty1.Text), "#,##0.00")
                        lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                        lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")
                        lbCostAmt.Text = CStr(Format(CDbl(lbCostAmt.Text) + CDbl(Dtl_Amt - Dtl_Cost_Amt), "#,##0.00"))


                        'userCo = .Rows(iRow).Item("Trh_User").ToString

                        '                        anyData1 = New String() {}

                        If CStr(cboDType.SelectedValue) = "S" Or CStr(cboDType.SelectedValue) = "P" Then
                            If chkDisplStk.Checked = True Then

                                anyData = New String() _
                                     {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                     Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                     Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}


                            Else
                                anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                    Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                    Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                    Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                    ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}

                            End If

                        Else
                            If chkDisplStk.Checked = True Then
                                anyData = New String() _
                                        {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                        Dtl_Detail, dtlStkName, _
                                        Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                        Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}


                            Else
                                anyData = New String() _
                                        {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                                        Dtl_Detail, dtlStkName, _
                                        Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                        Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                                     Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                                     Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                                     ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}

                            End If

                        End If

                        'If CStr(cboDType.SelectedValue) = "S" Or CStr(cboDType.SelectedValue) = "P" Then
                        '    If chkDisplStk.Checked = True Then
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Q_Bal_Q1.ToString("#,##0"), "0", ProGrp_Name}

                        '    Else
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), "0", ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}

                        '    End If

                        'Else
                        '    If chkDisplStk.Checked = True Then
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Q_Bal_Q1.ToString("#,##0"), userCo}

                        '    Else
                        '        anyData = New String() _
                        '                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                        '                Dtl_Detail, dtlStkName, _
                        '                Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                        '                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), userCo}

                        '    End If

                        'End If


                        lvi = New ListViewItem(anyData)
                        lsvShow.Items.Add(lvi)

                        If chkRow = False Then
                            chkRow = True
                        Else
                            chkRow = False
                        End If

                        Call colorList(dtlType)
                        'Exit For
                    End If

                Next

            End If
        End With

    End Sub

    Sub getItemDetailByStk()
        Dim iRow As Integer = 0


        Dim anyData() As String

        '   ตัวแปร ที่ใช้ในการคำนวน รายละเอียด

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String = ""
        Dim dtlItem As String = ""
        Dim dtlStkName As String = ""
        Dim dtlType As String = ""
        'Dim dtlConiD As String

        Dim Q_Iss As Double = 0
        Dim Q_Rcv As Double = 0
        Dim Q_Pen As Double = 0
        Dim Q_Order As Double = 0
        Dim Q_Bal As Double = 0

        Dim Q_Detail As String = ""

        Dim Q_Qty2 As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Amt As Double = 0
        Dim num As Double = 0

        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")

        With subDS.Tables("Command")

            If (subDS.Tables("Command").Rows.Count >= 1) Then

                For iRow = 0 To .Rows.Count - 1
                    rowNo = iRow + 1
                    strDocNo = "" : dtlItem = ""
                    dtlStkName = "" : dtlType = ""
                    num = 0
                    '===========================================================================================================
                    Q_Iss = 0 : Q_Rcv = 0
                    Q_Order = 0 : Q_Pen = 0
                    Q_Qty2 = 0 : Dtl_Price = 0 : Dtl_Amt = 0
                    '===========================================================================================================
                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                    Else

                        dtlType = CStr(.Rows(iRow).Item("Trh_Type"))

                        If IsDBNull(.Rows(iRow).Item("Trh_No")) Then
                            strDocNo = ""
                        Else
                            strDocNo = CStr(.Rows(iRow).Item("Trh_No"))
                        End If
                        If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                            dtlStkName = ""
                        Else
                            dtlStkName = CStr(.Rows(iRow).Item("Stk_Name_1"))
                        End If

                        rowNo = 0


                        If IsDBNull(.Rows(iRow).Item("Dtl_Num")) Then
                            num = 0
                        Else
                            num = CDbl(.Rows(iRow).Item("Dtl_Num"))
                        End If
                        'Q_Bal = 0
                        '===========================================================================================================
                        'Q_Bal = 0
                        If dtlType = "S" Then
                            Q_Rcv = num
                        ElseIf dtlType = "B" Then
                            Q_Rcv = num
                            Q_Pen = (num - CDbl(.Rows(iRow).Item("Dtl_num_2")))
                        ElseIf dtlType = "D" Then

                            Q_Rcv = num
                            Q_Bal = (Q_Bal + Q_Rcv)

                        ElseIf dtlType = "P" Then
                            Q_Rcv = num
                        End If
                        If IsDBNull(.Rows(iRow).Item("Stk_Factor")) Then
                            Q_Qty2 = Q_Rcv
                        Else
                            Q_Qty2 = (Q_Rcv * CDbl(.Rows(iRow).Item("Stk_Factor")))
                        End If


                        Dtl_Price = 0 ' .Rows(iRow).Item("Dtl_Price")
                        Dtl_Amt = 0 '(Q_Rcv * Dtl_Price)

                        '=======================   control  Total label  
                        If chkOnDetail.Checked = True Then
                            date01 = CDate(.Rows(iRow).Item("Trh_Date"))
                            If dtlType = "S" Then
                                'dtlItem = "ขายสินค้าให้กับ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                                dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "B" Then
                                'dtlItem = "Order สินค้าของ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                                dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "D" Then
                                dtlItem = "รับสินค้าจากการผลิต" '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            ElseIf dtlType = "G" Then
                                dtlItem = "รับสินค้าจากการรีเกรด" '
                            ElseIf dtlType = "F" Then
                                dtlItem = "รับโอนสินค้า" '
                            ElseIf dtlType = "P" Then
                                dtlItem = "เบิกสินค้าเพื่อขาย " & CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "Z" Then
                                dtlItem = "โอนสินค้าออก "
                            End If
                        End If
                        lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                        lbQty1.Text = Format(Q_Rcv + CInt(lbQty1.Text), "#,##0.00")
                        lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                        lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")
                        If chkOnDetail.Checked = True Then
                            anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlStkName, _
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                                    Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00")}
                        ElseIf chkOnDetail.Checked = False Then
                            anyData = New String() _
                                    {dtlType, CStr(rowNo), dtlStkName, _
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00")}
                        Else
                            anyData = New String() {}

                        End If

                        lvi = New ListViewItem(anyData)
                        lsvShow.Items.Add(lvi)
                        If chkRow = False Then
                            chkRow = True
                        Else
                            chkRow = False
                        End If

                        Call colorList(dtlType)
                    End If

                Next

            End If
        End With


    End Sub

    Sub colorList(ByVal iType As String)

        'If (listType = "QZ") Or (listType = "QC") Then
        If chkRow = True Then
            If (iType = "S") Then

                If chkProfit = True Then

                    lvi.BackColor = System.Drawing.Color.GreenYellow
                    lvi.ForeColor = System.Drawing.Color.Black

                    lvi.UseItemStyleForSubItems = True
                Else

                    lvi.BackColor = System.Drawing.Color.Red
                    lvi.ForeColor = System.Drawing.Color.White
                    'lvi.ForeColor = System.Drawing.Color.Black
                    'lvi.SubItems.Item(1).BackColor = Color.Black
                    'lvi.SubItems.Item(2).BackColor = Color.Black
                    'lvi.SubItems.Item(3).BackColor = Color.Black

                    lvi.UseItemStyleForSubItems = True
                    chkProfit = True

                End If

            ElseIf (iType = "B") Then



                If chkProfit = True Then

                    lvi.BackColor = System.Drawing.Color.Yellow
                    lvi.ForeColor = System.Drawing.Color.Black

                    lvi.UseItemStyleForSubItems = True

                Else
                    lvi.BackColor = System.Drawing.Color.Red
                    lvi.ForeColor = System.Drawing.Color.White

                    lvi.UseItemStyleForSubItems = True
                    chkProfit = True

                End If

            ElseIf (iType = "C") Then

                lvi.BackColor = System.Drawing.Color.Blue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "D") Then

                lvi.BackColor = System.Drawing.Color.Blue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "E") Then

                lvi.BackColor = System.Drawing.Color.Yellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "F") Then

                lvi.BackColor = System.Drawing.Color.SlateBlue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "G") Then

                lvi.BackColor = System.Drawing.Color.MidnightBlue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "P") Then

                lvi.BackColor = System.Drawing.Color.MidnightBlue
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "R") Then

                lvi.BackColor = System.Drawing.Color.Crimson
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "T") Then

                lvi.BackColor = System.Drawing.Color.Yellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            ElseIf (iType = "X") Then

                lvi.BackColor = System.Drawing.Color.Yellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            ElseIf (iType = "A") Then

                lvi.BackColor = System.Drawing.Color.Yellow
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            ElseIf (iType = "Q") Then

                lvi.BackColor = System.Drawing.Color.Crimson
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True

            ElseIf (iType = "Z") Then

                lvi.BackColor = System.Drawing.Color.Crimson
                lvi.ForeColor = System.Drawing.Color.White
                lvi.UseItemStyleForSubItems = True
                'ElseIf (dayDif <= -91) Then

                '    lvi.BackColor = System.Drawing.Color.Tomato
                '    lvi.UseItemStyleForSubItems = True
            End If
        Else
            If chkProfit = True Then
                lvi.BackColor = System.Drawing.Color.White
                lvi.ForeColor = System.Drawing.Color.Black
                lvi.UseItemStyleForSubItems = True
            Else

                lvi.BackColor = System.Drawing.Color.WhiteSmoke
                lvi.ForeColor = System.Drawing.Color.Red
                lvi.UseItemStyleForSubItems = True

            End If


        End If

        'End If
    End Sub

    Private Sub frmReport2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbTools.openDB()
        lbDate01.Value = Now
        lbDate02.Value = Now
        Call addItemCBO()
        'Call addProdList()
        Call getColFactor()
        'Call FormatGrd()
        'optDoc.Checked = True
        Call getColListView()
        lbSaleName.Text = dbTools.getSaleName(lbSaleID.Text)
        cmbRun.Focus()
    End Sub

    'Sub FormatGrd()

    '    Dim grdTS As DataGridTableStyle = New DataGridTableStyle

    '    Dim colType As New DataGridTextBoxColumn
    '    Dim colDate As New DataGridTextBoxColumn
    '    Dim colNo As New DataGridTextBoxColumn
    '    Dim colStkName As New DataGridTextBoxColumn
    '    Dim colDetl As New DataGridTextBoxColumn
    '    Dim colQty1 As New DataGridTextBoxColumn
    '    Dim colQty2 As New DataGridTextBoxColumn
    '    'dim col


    '    With grdTS
    '        .AlternatingBackColor = Color.LemonChiffon
    '        .BackColor = Color.White
    '        .MappingName = "Command"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

    '    End With

    '    With colType
    '        .HeaderText = "ประเภท"
    '        .MappingName = "Trh_Type"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 50
    '    End With
    '    With colNo
    '        .HeaderText = "เลขที่"
    '        .MappingName = "Trh_No"
    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With
    '    With colDate
    '        .HeaderText = "วันที่"
    '        .MappingName = "Trh_Date"
    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With

    '    With colStkName
    '        .HeaderText = "รายการ"
    '        .MappingName = "Stk_Name_1"
    '        ' .ReadOnly = True
    '        .Width = 250
    '    End With


    '    With colQty1
    '        .HeaderText = "จำนวนแผ่น"
    '        .MappingName = "Dtl_Num"
    '        .Alignment = HorizontalAlignment.Right

    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With


    '    With colQty2
    '        .HeaderText = "น้ำหนัก"
    '        .MappingName = "Dtl_Num_2"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 100
    '    End With


    '    grdTS.GridColumnStyles.Add(colType)
    '    grdTS.GridColumnStyles.Add(colDate)
    '    grdTS.GridColumnStyles.Add(colNo)
    '    grdTS.GridColumnStyles.Add(colStkName)
    '    grdTS.GridColumnStyles.Add(colQty1)
    '    grdTS.GridColumnStyles.Add(colQty2)


    '    'With dataShow
    '    '    .TableStyles.Clear()
    '    '    .CaptionText = "รายงานการเคลื่อนไหวสินค้า"
    '    '    .FlatMode = True
    '    '    .TableStyles.Add(grdTS)
    '    '    '.Controls.Clear()
    '    'End With

    'End Sub

    Sub genSQLdetailByDoc() '  ===========   สร้างรายงาน เอกสารต่างๆ 

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,"
        If chkNoGrpBy.Checked = True Then

            '  ส่วนของ  เอกสาร
            txtSQL = txtSQL & "TranDataH.Trh_NoType,"
            txtSQL = txtSQL & "TranDatah.Trh_Date,"
            txtSQL = txtSQL & " TranDataH.Trh_No,TranDataD.Dtl_Con_id,Dtl_Detail,TranDataH.Trh_WH,"

            '  ส่วนของ  ลูกค้า
            txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"

            '  ส่วนของ  พนักงานขาย
            txtSQL = txtSQL & "GrpSales.Grps_id,Grps_Name,Ar_sales,SalesMan1.Sl_Name as sale1,"
            txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
            txtSQL = txtSQL & ""

            '  ส่วนของ  รายการสินค้า
            txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,BaseMast.Stk_Factor2,"
            txtSQL = txtSQL & "TranDataD.Dtl_Num,TranDataD.Dtl_Num_2,"
            txtSQL = txtSQL & "TranDataD.Dtl_Price,Dtl_Same_Code,"

            '  ส่วนของ  ต้นทุน
            'txtSQL = txtSQL & "CostMast.CS_Cost,CostMast.CS_Type, "
            txtSQL = txtSQL & "TranDataH.Trh_user "

        ElseIf chkGrpByStk.Checked = True Then

            ''  ส่วนของ  เอกสาร
            'txtSQL = txtSQL & "TranDataH.Trh_NoType,"
            'txtSQL = txtSQL & "TranDatah.Trh_Date,"
            'txtSQL = txtSQL & "TranDataH.Trh_No,TranDataD.Dtl_Con_id,Dtl_Detail,"

            ''  ส่วนของ  ลูกค้า
            'txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"

            ''  ส่วนของ  พนักงานขาย
            'txtSQL = txtSQL & "GrpSales.Grps_id,Grps_Name,Ar_sales,SalesMan1.Sl_Name as sale1,"
            'txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
            'txtSQL = txtSQL & ""

            '  ส่วนของ  รายการสินค้า
            txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,BaseMast.Stk_Factor2,"
            txtSQL = txtSQL & "Dtl_Same_Code,"
            '  ส่วนของ  ต้นทุน
            'txtSQL = txtSQL & "CostMast.CS_Cost,CostMast.CS_Type, "
            txtSQL = txtSQL & ""

            '  ส่วนของ  Sum Grp

            txtSQL = txtSQL & "sum(TranDataD.Dtl_Price * Dtl_Num)as Dtlsum,sum(TranDataD.Dtl_Num)as Dtl_Num "




        End If


        If chkProDDetl.Checked = True Then

            '  เพิ่มรายละเอียดเกียวกับการแสดง Factor 
            txtSQL = txtSQL & ","
            txtSQL = txtSQL & "TypeMast.Type_Name,"
            txtSQL = txtSQL & "GrpMast.Grp_Name,"
            txtSQL = txtSQL & "ColorMast.Color_Name,"
            txtSQL = txtSQL & "ThMast.Th_Name3,"
            txtSQL = txtSQL & "SizeMast.Size_Name,"
            txtSQL = txtSQL & "GMast.G_Name,"

            txtSQL = txtSQL & "ProGrpMast.ProGrp_Name "

            '  เพิ่มรายละเอียดเกียวกับการแสดง Factor 

        End If

        If chkDisplStk.Checked = True Then
            If chkNoGrpBy.Checked = True Then
                txtSQL = txtSQL & ",tbstock.sumQtybalQ1 "
            Else
                txtSQL = txtSQL & ",SUM(tbStock.dtl_bal_q1)AS sumQtybalQ1 "
            End If

        End If

        txtSQL = txtSQL & "FROM TranDataD Left JOIN TranDataH "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "
        txtSQL = txtSQL & "left join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "

        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan1 "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman1.Sl_Id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan2 "
        txtSQL = txtSQL & "On ArFile.Ar_Sales=Salesman2.Sl_Id "

        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales.Grps_ID "

        '======   Table ต้นทุนสินค้า
        'txtSQL = txtSQL & "Left join CostMast "
        'txtSQL = txtSQL & "On BaseMast.Stk_Code=CostMast.CS_Stk_Code "



        If (optSpec.Checked = True) Or (chkProDDetl.Checked = True) Then

            txtSQL = txtSQL & "Left Join ProGrpMast "
            txtSQL = txtSQL & "On BaseMast.Stk_Prod=ProGrpMast.ProGrp_ID "


            txtSQL = txtSQL & "Left Join TypeMast "
            txtSQL = txtSQL & "On BaseMast.Type_Code=TypeMast.Type_Code "

            txtSQL = txtSQL & "Left Join GrpMast "
            txtSQL = txtSQL & "On BaseMast.Grp_Code=GrpMast.Grp_Code "

            txtSQL = txtSQL & "Left Join ThMast "
            txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "


            txtSQL = txtSQL & "Left Join ColorMast "
            txtSQL = txtSQL & "On (BaseMast.Color_Code=ColorMast.Color_Code "
            txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type )"

            txtSQL = txtSQL & "Left Join SizeMast "
            txtSQL = txtSQL & "On BaseMast.Size_Code=SizeMast.Size_Code "

            txtSQL = txtSQL & "Left Join GMast "
            txtSQL = txtSQL & "On BaseMast.G_Code=GMast.G_Code "

        End If
        If chkWH.Checked = True Then
            txtSQL = txtSQL & "Left Join Warehouse "
            txtSQL = txtSQL & "On Trh_wh=Wh_ID "
        End If

        If chkDisplStk.Checked = True Then
            txtSQL = txtSQL & "left join "
            txtSQL = txtSQL & "( "

            txtSQL = txtSQL & "Select dtl_code"
            If chkNoGrpBy.Checked = True Then
                txtSQL = txtSQL & ",SUM(dtl_bal_q1)AS sumQtybalQ1 "
            Else
                txtSQL = txtSQL & ",dtl_bal_Q1 "

            End If
            txtSQL = txtSQL & " "

            txtSQL = txtSQL & "From stkDetl "
            txtSQL = txtSQL & "Where "
            txtSQL = txtSQL & "not(Dtl_Store='110603') " ' 110603 แปรรูป
            txtSQL = txtSQL & "And not(Dtl_Store='111660') " ' 111660 ตัดชำรุด 
            txtSQL = txtSQL & "And not(Dtl_Store='112054') " ' 112054 คลังปรับสต๊อก   
            If chkNoGrpBy.Checked = True Then

                txtSQL = txtSQL & "  group by dtl_code "
            Else
                txtSQL = txtSQL & ""
            End If
            txtSQL = txtSQL & ")tbStock "

            txtSQL = txtSQL & "On dtl_idTrade=dtl_code "

        End If

        '=========##################==========   ส่วนของ    Where ===============================$$$$$$$$$$$$$$$=========


        txtSQL = txtSQL & "where "
        txtSQL = txtSQL & "Trh_Type='" & CStr(cboDType.SelectedValue) & "' "
        txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        ' ======================   เพิ่มเติ่มแก้ไขราคาทุนซ้ำกันชชชชชชชชชชชชช
        '        txtSQL = txtSQL & ""

        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If
        '=============== If 

        If (chkOptSale.Checked = True) Then
            If (cboDType.SelectedValue = "P") Then

                If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then
                    txtSQL = txtSQL & "And Trh_Sale='" & Trim(lbSaleID.Text) & "' "
                ElseIf Len(lbSaleID.Text) > 0 And (chkNotSale.Checked = True) Then
                    txtSQL = txtSQL & "And (Trh_Sale<>'" & Trim(lbSaleID.Text) & "') "
                End If

            End If


            If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then

                txtSQL = txtSQL & "And Trh_Sale='" & Trim(lbSaleID.Text) & "' "

            ElseIf Len(lbSaleID.Text) > 0 And (chkNotSale.Checked = True) Then

                txtSQL = txtSQL & "And (Trh_Sale<>'" & Trim(lbSaleID.Text) & "') "

            End If

        End If

        If chkOptSale2.Checked = True Then
            If Len(lbSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then

                txtSQL = txtSQL & "And Ar_Sales= '" & Trim(lbSaleID2.Text) & "' "

            ElseIf Len(lbSaleID2.Text) > 0 And (chkNotSale2.Checked = True) Then

                txtSQL = txtSQL & "And (Ar_Sales <> '" & Trim(lbSaleID2.Text) & "') "

            End If
        End If

        If chkDocNo.Checked = True Then
            If chkNotDoc.Checked = True Then

                txtSQL = txtSQL & "And not(Trh_No like '%" & Trim(txtSelectNo.Text) & "%') "
            Else

                txtSQL = txtSQL & "And Trh_No like '%" & Trim(txtSelectNo.Text) & "%' "
            End If
        End If
        If chkWH.Checked = True Then

            txtSQL = txtSQL & "And Trh_wh= '" & lbWHCode.Text & "' "
        End If

        If optStk.Checked = True Then
            txtSQL = txtSQL & "and (dtl_idTrade='" & Trim(lbStkCode.Text) & "') "
        End If

        '==============   เลือก Factor   =======================================

        If optSpec.Checked = True Then


            txtTSQL.Text = "ต้องการเลือกข้อมูล "
            If chkNot.Checked = True Then
                txtSQL = txtSQL & "And not("

            ElseIf chkNot.Checked = False Then
                txtSQL = txtSQL & "And ("

                'txtSQL = txtSQL & ") "

            End If
            If chkF1.Checked = True Then
                txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "Option 1 := "
                If cboFactor1.SelectedValue.ToString = "00" Then
                    txtSQL = txtSQL & "(BaseMast.Stk_Prod='" & cboFactor11.SelectedValue.ToString & "') "
                ElseIf cboFactor1.SelectedValue.ToString = "01" Then
                    txtSQL = txtSQL & "(BaseMast.Type_Code='" & cboFactor11.SelectedValue.ToString & "') "
                ElseIf cboFactor1.SelectedValue.ToString = "02" Then
                    txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor11.SelectedValue.ToString & "') "
                End If
                txtTSQL.Text = txtTSQL.Text & " " & cboFactor1.Text
                txtTSQL.Text = txtTSQL.Text & cboFactor11.Text

            End If

            If chkF2.Checked = True Then

                If cboFactor2.SelectedValue.ToString = "00" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "และ เป็น " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & "หรือ " '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ เป็น " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "02" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Grp_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "07" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "07") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""

                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "

                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.G_Code='" & cboFactor22.SelectedValue.ToString & "') "

                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                End If

                'End If


            End If

            If chkF3.Checked = True Then

                If cboFactor3.SelectedValue.ToString = "00" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ เป็น กลุ่ม "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "02" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ เป็น กลุ่ม  "
                    End If
                    txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor33.Text '& Chr(13) & Chr(10) 

                ElseIf cboFactor3.SelectedValue.ToString = "07" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "07") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ เป็น กลุ่ม  "
                    End If
                    txtSQL = txtSQL & "(BaseMast.G_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor33.Text '& Chr(13) & Chr(10) 

                End If

                '==========================================================================
                If chkF4.Checked = True Then

                    If cboFactor4.SelectedValue.ToString = "00" Then
                        If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                            txtSQL = txtSQL & "Or "

                        ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                            txtSQL = txtSQL & ""
                        ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "00") Then
                            txtSQL = txtSQL & "Or "

                        Else
                            txtSQL = txtSQL & "And "

                        End If
                        txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor33.SelectedValue.ToString & "') "


                    ElseIf cboFactor4.SelectedValue.ToString = "01" Then
                        If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                            txtSQL = txtSQL & "Or"

                        ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                            txtSQL = txtSQL & ""

                        ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "01") Then
                            txtSQL = txtSQL & "Or "

                        Else
                            txtSQL = txtSQL & "And "

                        End If
                        txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor33.SelectedValue.ToString & "') "


                    ElseIf cboFactor4.SelectedValue.ToString = "02" Then

                        If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                            txtSQL = txtSQL & "Or"

                        ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                            txtSQL = txtSQL & ""

                        ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                            txtSQL = txtSQL & "Or "

                        Else
                            txtSQL = txtSQL & "And "

                        End If
                        txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor44.SelectedValue.ToString & "') "


                    ElseIf cboFactor4.SelectedValue.ToString = "05" Then

                        If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                            txtSQL = txtSQL & "Or"

                        ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                            txtSQL = txtSQL & ""

                        ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                            txtSQL = txtSQL & "Or "

                        Else
                            txtSQL = txtSQL & "And "

                        End If
                        txtSQL = txtSQL & "(BaseMast.Size_Code='" & cboFactor44.SelectedValue.ToString & "') "


                    ElseIf cboFactor4.SelectedValue.ToString = "07" Then

                        If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "07") Then
                            txtSQL = txtSQL & "Or"

                        ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                            txtSQL = txtSQL & ""

                        ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                            txtSQL = txtSQL & "Or "

                        Else
                            txtSQL = txtSQL & "And "

                        End If
                        txtSQL = txtSQL & "(BaseMast.G_Code='" & cboFactor44.SelectedValue.ToString & "') "

                    End If

                End If
            End If
            txtSQL = txtSQL & ") "
        End If

        '====================   Session  Group by
        If chkNoGrpBy.Checked = True Then
            txtSQL = txtSQL & ""
            txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No,TranDataD.Dtl_idTrade "
        ElseIf chkGrpByStk.Checked = True Then

            txtSQL = txtSQL & "Group by trandataH.Trh_Type,TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,"
            txtSQL = txtSQL & "BaseMast.Stk_Factor,BaseMast.Stk_Factor2,"
            txtSQL = txtSQL & "Dtl_Same_Code "
            'txtSQL = txtSQL & ",CostMast.CS_Cost,CostMast.CS_Type "

            txtSQL = txtSQL & "Order by TranDataD.Dtl_idTrade "

        End If

        '====================   Session  Group by

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Command")
        chkData = True

    End Sub

    Sub genSQLdetlByPenOr()   '  ===========   สร้างรายงาน Pending Order 

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,TranDataH.Trh_NoType,"
        txtSQL = txtSQL & "TranDatah.Trh_Date, TranDataH.Trh_No,TranDataH.trh_wh,"
        txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"
        txtSQL = txtSQL & "Ar_sales,SalesMan1.Sl_Name as sale1,"
        txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
        txtSQL = txtSQL & "Dtl_Detail,GrpSales.Grps_id,Grps_Name,"
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor2,"
        txtSQL = txtSQL & "(TranDataD.Dtl_Num-TranDataD.Dtl_Num_2)as Dtl_Num,"
        txtSQL = txtSQL & "TranDataD.Dtl_Num_2,"
        txtSQL = txtSQL & "TranDataD.Dtl_Price,TranDataD.Dtl_Con_id,Dtl_Same_Code,"
        txtSQL = txtSQL & "TranDataH.Trh_user,Dtl_Po "
        'txtSQL = txtSQL & ",CostMast.CS_Cost,CostMast.CS_Type "

        If chkDisplStk.Checked = True Then
            txtSQL = txtSQL & ",tbStock.sumQtybalQ1 "
        End If

        '====================  Form =========================
        txtSQL = txtSQL & "FROM TranDataD Left JOIN TranDataH "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "
        txtSQL = txtSQL & "left join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "

        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan1 "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman1.Sl_Id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan2 "
        txtSQL = txtSQL & "On ArFile.Ar_Sales=Salesman2.Sl_Id "

        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales.Grps_ID "

        If optSpec.Checked = True Then
            txtSQL = txtSQL & "Left Join ProGrpMast "
            txtSQL = txtSQL & "On BaseMast.Stk_Prod=ProGrpMast.ProGrp_ID "


            txtSQL = txtSQL & "Left Join TypeMast "
            txtSQL = txtSQL & "On BaseMast.Type_Code=TypeMast.Type_Code "

            txtSQL = txtSQL & "Left Join GrpMast "
            txtSQL = txtSQL & "On BaseMast.Grp_Code=GrpMast.Grp_Code "

            txtSQL = txtSQL & "Left Join ColorMast "
            txtSQL = txtSQL & "On (BaseMast.Color_Code=ColorMast.Color_Code "
            txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type )"

            txtSQL = txtSQL & "Left Join ThMast "
            txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        End If

        'txtSQL = txtSQL & "Left Join CostMast "
        'txtSQL = txtSQL & "On BaseMast.Stk_Code=CostMast.CS_Stk_Code "



        If chkDisplStk.Checked = True Then
            txtSQL = txtSQL & "left join "
            txtSQL = txtSQL & "( Select dtl_code,"
            txtSQL = txtSQL & "sum(dtl_bal_Q1)as sumQtybalQ1 "
            txtSQL = txtSQL & "From stkDetl "
            txtSQL = txtSQL & "group by dtl_code "
            txtSQL = txtSQL & ")tbStock "
            txtSQL = txtSQL & "On dtl_idTrade=dtl_code "
        End If

        '==========================  Where  =========================

        txtSQL = txtSQL & "where "
        txtSQL = txtSQL & "Trh_Type='B' "
        txtSQL = txtSQL & "And ((TranDataD.Dtl_Num-TranDataD.Dtl_Num_2)>0) "
        If chkDate.Checked = True Then

            txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        Else

        End If


        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If


        If chkOptSale.Checked = True Then
            If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then

                txtSQL = txtSQL & "And Trh_Sale='" & Trim(lbSaleID.Text) & "' "

            ElseIf Len(lbSaleID.Text) > 0 And (chkNotSale.Checked = True) Then

                txtSQL = txtSQL & "And (Trh_Sale<>'" & Trim(lbSaleID.Text) & "') "

            End If
        End If

        If chkOptSale2.Checked = True Then
            If Len(lbSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then

                txtSQL = txtSQL & "And Ar_Sales='" & Trim(lbSaleID2.Text) & "' "

            ElseIf Len(lbSaleID2.Text) > 0 And (chkNotSale2.Checked = True) Then

                txtSQL = txtSQL & "And (Ar_Sales<>'" & Trim(lbSaleID2.Text) & "') "

            End If
        End If

        If chkDocNo.Checked = True Then
            If chkNotDoc.Checked = True Then

                txtSQL = txtSQL & "And not(Trh_No like '%" & Trim(txtSelectNo.Text) & "%') "
            Else

                txtSQL = txtSQL & "And Trh_No like '%" & Trim(txtSelectNo.Text) & "%' "
            End If


        End If
        If optStk.Checked = True Then
            txtSQL = txtSQL & "and (dtl_idTrade='" & Trim(lbStkCode.Text) & "') "
        End If

        '==============   เลือก Factor   =======================================

        If optSpec.Checked = True Then
            txtTSQL.Text = "ต้องการเลือกข้อมูล "
            If chkNot.Checked = True Then

                txtSQL = txtSQL & "And not("

            ElseIf chkNot.Checked = False Then
                txtSQL = txtSQL & "And ("

                'txtSQL = txtSQL & ") "

            End If
            If chkF1.Checked = True Then
                txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "Option 1 := "
                If cboFactor1.SelectedValue.ToString = "00" Then
                    txtSQL = txtSQL & "(BaseMast.Stk_Prod='" & cboFactor11.SelectedValue.ToString & "') "
                ElseIf cboFactor1.SelectedValue.ToString = "01" Then
                    txtSQL = txtSQL & "(BaseMast.Type_Code='" & cboFactor11.SelectedValue.ToString & "') "
                ElseIf cboFactor1.SelectedValue.ToString = "02" Then
                    txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor11.SelectedValue.ToString & "') "
                End If
                txtTSQL.Text = txtTSQL.Text & " " & cboFactor1.Text
                txtTSQL.Text = txtTSQL.Text & cboFactor11.Text

            End If

            If chkF2.Checked = True Then

                If cboFactor2.SelectedValue.ToString = "00" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "และ เป็น " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & "หรือ " '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ เป็น " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "02" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Grp_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                End If

            End If

            If chkF3.Checked = True Then

                If cboFactor3.SelectedValue.ToString = "00" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ เป็น กลุ่ม "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "02" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "หรือ "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "และ เป็น กลุ่ม  "
                    End If
                    txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor33.Text '& Chr(13) & Chr(10) 
                End If

            End If

            txtSQL = txtSQL & ") "


        End If


        txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No,TranDataD.Dtl_idTrade "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Command")
        chkData = True

    End Sub

    Sub genSQLdetailByStk()


        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,TranDataH.Trh_NoType,"
        txtSQL = txtSQL & "TranDatah.Trh_Date, TranDataH.Trh_No,"
        txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"
        txtSQL = txtSQL & "Ar_sales,SalesMan1.Sl_Name as sale1,"
        txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
        txtSQL = txtSQL & "Dtl_Detail,GrpSales.Grps_id,Grps_Name,"
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,"
        txtSQL = txtSQL & "TranDataD.Dtl_Num,TranDataD.Dtl_Num_2,"
        txtSQL = txtSQL & "TranDataD.Dtl_Price,TranDataD.Dtl_Con_id,Dtl_Same_Code "
        If chkDisplStk.Checked = True Then
            txtSQL = txtSQL & ",tbStock.sumQtybalQ1 "
        End If

        txtSQL = txtSQL & "FROM TranDataD Left JOIN TranDataH "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "
        txtSQL = txtSQL & "left join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "

        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan1 "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman1.Sl_Id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan2 "
        txtSQL = txtSQL & "On ArFile.Ar_Sales=Salesman2.Sl_Id "

        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales.Grps_ID "

        If chkDisplStk.Checked = True Then
            txtSQL = txtSQL & "left join "
            txtSQL = txtSQL & "( Select dtl_code,"
            txtSQL = txtSQL & "sum(dtl_bal_Q1)as sumQtybalQ1 "
            txtSQL = txtSQL & "From stkDetl "
            txtSQL = txtSQL & "group by dtl_code "
            txtSQL = txtSQL & ")tbStock "
            txtSQL = txtSQL & "On dtl_idTrade=dtl_code "
        End If

        txtSQL = txtSQL & "where Trh_Type='" & CStr(cboDType.SelectedValue) & "' "
        txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If
        If chkDocNo.Checked = True Then

            txtSQL = txtSQL & "And Trh_No like '%" & Trim(txtSelectNo.Text) & "%' "

        Else

        End If

        If chkOptSale.Checked = True Then
            If Len(lbSaleID.Text) > 0 And (chkSelSale.Checked = True) Then

                txtSQL = txtSQL & "And Trh_Sale='" & Trim(lbSaleID.Text) & "' "

            ElseIf Len(lbSaleID.Text) > 0 And (chkNotSale.Checked = True) Then

                txtSQL = txtSQL & "And (Trh_Sale<>'" & Trim(lbSaleID.Text) & "') "

            End If
        End If

        If chkOptSale2.Checked = True Then
            If Len(lbSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then

                txtSQL = txtSQL & "And Ar_Sales='" & Trim(lbSaleID2.Text) & "' "

            ElseIf Len(lbSaleID2.Text) > 0 And (chkNotSale2.Checked = True) Then

                txtSQL = txtSQL & "And (Ar_Sales<>'" & Trim(lbSaleID2.Text) & "') "

            End If
        End If

        If optStk.Checked = True Then
            txtSQL = txtSQL & "and (dtl_idTrade='" & Trim(lbStkCode.Text) & "') "
        End If

        txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No,TranDataD.Dtl_idTrade "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Command")
        chkData = True

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
        cboDType.SelectedItem = Nothing

        txtSQL = "Select Type_id,(Type_id + ' - ' + Type_name) Type_Name From  TypeDocMast "
        txtSQL = txtSQL & "Where type_sel='1' "
        txtSQL = txtSQL & "Order by Type_ID "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "DTypeMast")

        If ds.Tables("DTypeMast").Rows.Count > 0 Then
            With cboDType
                .DataSource = ds.Tables("DTypeMast")
                .DisplayMember = "Type_Name"
                .ValueMember = "Type_ID"
                .Text = ""

            End With
        End If
        cboDType.SelectedItem = Nothing
        cboDType.SelectedValue = "S"

    End Sub



    Private Sub lbFindStk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindStk.Click

        selStkID = ""
        Me.BackColor = Color.Gray
        frmFindStk.ShowDialog()
        lbStkCode.Text = selStkID
        Me.BackColor = Color.WhiteSmoke
        lbStkName.Text = dbTools.getStkName(selStkID)

    End Sub

    Private Sub lbDate01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDate01.ValueChanged
        lbDate02.Value = lbDate01.Value
    End Sub

    'Sub prnReport()
    '    Dim StkCode As String
    '    Dim trhDate As Date
    '    'Dim myExcel As Microsoft.Office.Interop.Excel.Application
    '    'Dim myExcel As Excel.Application

    '    'Dim subDA2 As New SqlClient.SqlDataAdapter
    '    'Dim subDS2 As New DataSet


    '    Dim rw As Integer
    '    Dim countRow As Integer
    '    'Dim countRow2 As Integer
    '    Dim rowExcel As Integer = 9 '  เริ่ม รายการบรรทัดที่ 9
    '    Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
    '    Dim sheetCount As Integer = 1
    '    ' Dim stkName2 As String



    '    fileName = CurDir() & "\report\rptStk02.xls"
    '    'myExcel = New Excel.Application
    '    myExcel = CType(CreateObject("Excel.Application"), Microsoft.Office.Interop.Excel.Application)
    '    myExcel.Visible = True
    '    'myExcel.DisplayAlerts = False
    '    'myExcel.ActiveWorkbook.AutoUpdateSaveChanges = False
    '    'myExcel.AskToUpdateLinks = False
    '    'myExcel.WindowState = Excel.XlWindowState.xlNormal
    '    'myExcel.WindowState=

    '    myExcel.Workbooks.Open(fileName, 0, 1)

    '    With myExcel

    '        'rw = .ActiveCell.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row
    '        If IsDBNull(subDS.Tables("Command")) Then
    '            Exit Sub
    '        Else
    '            rw = subDS.Tables("Command").Rows.Count - 1
    '        End If


    '        .ActiveWindow.FreezePanes = False
    '        .Range("E2").Select()
    '        .ActiveCell.Value = dbTools.getDocType(CStr(cboDType.SelectedValue))
    '        Dim exRow As Integer = 0
    '        For countRow = 0 To rw

    '            '  ============  เพิ่มบรรทัด
    '            .Range("B" & (rowExcel + 1) & ":" & "AC" & (rowExcel + 1)).Copy() '  เลือกบรรทัดเพื่อแทรก       
    '            '.Range("B" & (rowExcel + 3) & ":" & "O" & (rowExcel + 3)).Select()
    '            .Range("B" & (rowExcel + 2) & ":" & "AC" & (rowExcel + 2)).Insert()
    '            If exRow = 0 Then
    '                .Range("B" & (rowExcel + 2) & ":" & "AC" & (rowExcel + 2)).Interior.ColorIndex = 6
    '                exRow = 1
    '            Else
    '                .Range("B" & (rowExcel + 2) & ":" & "AC" & (rowExcel + 2)).Interior.ColorIndex = 0
    '                exRow = 0
    '            End If


    '            '.Selection.Insert(Shift:=2)    '     เพิ่ม( Insert ) บรรทัด 
    '            '  ============  เพิ่มบรรทัด

    '            .Range("B" & rowExcel).Select()
    '            .ActiveCell.Value = countRow + 1
    '            '.ActiveCell.Font.ColorIndex=
    '            .Range("C" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")

    '            .Range("D" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No")

    '            If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")) Then

    '                .Range("E" & rowExcel).Select()
    '                .ActiveCell.Value = "ไม่พบข้อมูล"

    '            Else
    '                .Range("E" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")

    '            End If

    '            StkCode = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("dtl_idTrade").ToString
    '            trhDate = CDate(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date"))
    '            .Range("G" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale1")
    '            .Range("F" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale2")


    '            '.Range("i" & rowExcel).Select()
    '            '.ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Detail")

    '            .Range("i" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Name_1")

    '            .Range("L" & rowExcel).Select()
    '            .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")

    '            .Range("M" & rowExcel).Select()
    '            If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
    '                .ActiveCell.Value = 0
    '            Else
    '                .ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) * CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2"))
    '            End If

    '            .Range("N" & rowExcel).Select()
    '            If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
    '                .ActiveCell.Value = 0
    '            Else

    '                If dbTools.getCostType(StkCode) = 0 Then
    '                    '.ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) * 98
    '                    '.ActiveCell.Value = CDbl(0)
    '                    .ActiveCell.Value = CDbl(dbTools.getCostByStk(StkCode, trhDate))
    '                ElseIf dbTools.getCostType(StkCode) = 1 Then

    '                    '.ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) * CDbl(dbTools.getCostByStk(StkCode, trhDate))
    '                    .ActiveCell.Value = CDbl(dbTools.getCostByStk(StkCode, trhDate))
    '                Else
    '                    .ActiveCell.Value = CDbl(0)

    '                End If
    '            End If


    '            .Range("P" & rowExcel).Select()

    '            If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) = True Then
    '                .ActiveCell.Value = "***"
    '            Else
    '                If IsNumeric(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) Then
    '                    .ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price"))
    '                Else
    '                    .ActiveCell.Value = ""
    '                End If

    '            End If

    '            If chkProDDetl.Checked = True Then


    '                '.Range("U" & rowExcel).Select()
    '                '.ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_idTrade")

    '                .Range("X" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Type_Name")
    '                .Range("Y" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("ProGrp_Name")

    '                '.Range("W" & rowExcel).Select()
    '                '.ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Grp_Name")

    '                .Range("Z" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Color_Name")

    '                .Range("AA" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Th_Name3")

    '                .Range("AB" & rowExcel).Select()
    '                .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Size_Name")


    '            End If


    '            If chkDisplStk.Checked = True Then
    '                .Range("T" & rowExcel).Select()
    '                .ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("sumQtyBalQ1"))
    '            End If

    '            rowExcel = rowExcel + 1
    '            'If rowExcel = 900 Then
    '            '    'bufferExcel = 500
    '            '    rowExcel = 9
    '            '    'myExcel.Workbooks.Open(fileName, 0, 1)
    '            '    sheetCount = sheetCount + 1
    '            '    .Sheets(sheetCount).select()
    '            'End If

    '        Next



    '        'myExcel.Quit()
    '        myExcel = Nothing
    '    End With
    'End Sub
    Sub prnReport()

        Dim StkCode As String
        Dim trhDate As Date
        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim oRng As Microsoft.Office.Interop.Excel.Range

        Dim rw As Integer
        'Dim countRow As Integer
        'Dim countRow2 As Integer

        Dim rowExcel As Integer = 9 '  เริ่ม รายการบรรทัดที่ 9
        Dim bufferExcel As Integer = 0 ' ใช้ในกรณีขึ้น sheet ใหม่ และ ให้ buffer ค่าต่อจาก sheet เดิม เพื่อนับต่อ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0

        ' Dim stkName2 As String
        fileName = CurDir() & "\report\rptStk02.xls"


        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptStk02.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet

            If IsDBNull(subDS.Tables("Command")) Then
                Exit Sub
            Else
                rw = subDS.Tables("Command").Rows.Count - 1
            End If

            '        .ActiveWindow.FreezePanes = False
            .Range("E2").Select()
            '.ActiveCell.Value = dbTools.getDocType(CStr(cboDType.SelectedValue))


            '.Range("B9:U9").Select()
            '.Copy()
            '.Range("B" & (rowExcel + 1) & ":" & "U" & (rowExcel + 1)).Copy() '  เลือกบรรทัดเพื่อแทรก                      
            For countRow = 0 To rw

                '            '  ============  เพิ่มบรรทัด

                .Range("B" & (rowExcel + 2) & ":" & "U" & (rowExcel + 2)).Insert()
                '.Range("B" & (rowExcel + 2) & ":" & "U" & (rowExcel + 2)).PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll)

                '.Range("B10:U11").Select()
                '.Paste()


                'Range("B10:U10").Select()
                'ActiveSheet.Paste(Link:=True)

                If exRow = 0 Then
                    .Range("B" & (rowExcel + 2) & ":" & "U" & (rowExcel + 2)).Interior.ColorIndex = 6
                    exRow = 1
                Else
                    .Range("B" & (rowExcel + 2) & ":" & "U" & (rowExcel + 2)).Interior.ColorIndex = 0
                    exRow = 0
                End If

                '            '  ============  เพิ่มบรรทัด

                .Range("B" & rowExcel).Select()
                .Range("B" & rowExcel).Value = countRow + 1


                .Range("C" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")
                '.ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")

                .Range("D" & rowExcel).Value() = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No")
                '.ActiveCell.Value = 

                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")) Then

                    .Range("E" & rowExcel).Value() = "ไม่พบข้อมูล"
                    '    .ActiveCell.Value

                Else
                    .Range("E" & rowExcel).Value() = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")
                    '    .ActiveCell.Value 

                End If

                StkCode = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("dtl_idTrade").ToString
                trhDate = CDate(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date"))

                .Range("G" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale1")

                .Range("F" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale2")


                .Range("i" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Name_1")
                '.ActiveCell

                .Range("L" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")
                '.ActiveCell

                '.Select()
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
                    .Range("M" & rowExcel).Value = 0
                Else
                    .Range("M" & rowExcel).Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) * CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2"))
                End If

                '.Range("N" & rowExcel).Select()
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
                    .Range("N" & rowExcel).Value = 0
                Else

                    If dbTools.getCostType(StkCode) = 0 Then
                        .Range("N" & rowExcel).Value = CDbl(dbTools.getCostByStk(StkCode, trhDate, 0))
                    ElseIf dbTools.getCostType(StkCode) = 1 Then
                        .Range("N" & rowExcel).Value = CDbl(dbTools.getCostByStk(StkCode, trhDate, 0))
                    Else
                        .Range("N" & rowExcel).Value = CDbl(0)

                    End If
                End If
                If dbTools.getCostType(StkCode) = 1 Then
                    .Range("O" & rowExcel).Value = CStr("=N" & rowExcel & "*" & "L" & rowExcel)
                Else
                    .Range("O" & rowExcel).Value = CStr("=N" & rowExcel & "*" & "M" & rowExcel)
                End If



                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) = True Then
                    .Range("P" & rowExcel).Value = "***"
                Else
                    If IsNumeric(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) Then
                        .Range("P" & rowExcel).Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price"))
                    Else
                        .Range("P" & rowExcel).Value = 0
                    End If

                End If
                .Range("Q" & rowExcel).Value = CStr("=R" & rowExcel & "/" & "M" & rowExcel)
                .Range("R" & rowExcel).Value = CStr("=P" & rowExcel & "*" & "L" & rowExcel)
                .Range("S" & rowExcel).Value = CStr("=R" & rowExcel & "-" & "O" & rowExcel)


                If chkProDDetl.Checked = True Then

                    .Range("X" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Type_Name")
                    .Range("Y" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("ProGrp_Name")

                    .Range("Z" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Color_Name")

                    .Range("AA" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Th_Name3")

                    .Range("AB" & rowExcel).Select()
                    .ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Size_Name")
                End If

                rowExcel = rowExcel + 1

            Next

            objExcel = Nothing
            objExcelWorkBook = Nothing
            objExcelWorkSheet = Nothing

        End With

    End Sub
    '.Range("P" & rowExcel).Select()

    'If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) = True Then
    '    .ActiveCell.Value = "***"
    'Else
    '    If IsNumeric(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) Then
    '        .ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price"))
    '    Else
    '        .ActiveCell.Value = ""
    '    End If

    'End If

    'If chkDisplStk.Checked = True Then
    '    .Range("T" & rowExcel).Select()
    '    .ActiveCell.Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("sumQtyBalQ1"))
    'End If

    Private Sub frmReport2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F3 Then

            Dim frmFindStk As frmFindStk = New frmFindStk
            selStkID = ""
            frmFindStk.ShowDialog()
            lbStkCode.Text = selStkID
            If lbStkCode.Text = "" Then
            Else
                lbStkName.Text = dbTools.getStkName(selStkID)
            End If


        End If
    End Sub

    Private Sub lbFindCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindCus.Click
        Dim searchCus As searchCus = New searchCus
        chkSelCustom.Checked = True

        selStkID = ""
        searchCus.ShowDialog()
        lbCusID.Text = CusId
        lbCusName.Text = dbTools.getCusName(CusId)

    End Sub

    Private Sub txtSelectNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSelectNo.KeyDown
        If e.KeyCode = 13 Then
            lsvShow.Items.Clear()
            chkcol = False
            If chkcol = False Then
                lsvShow.Columns.Clear()
                Call getColListView()
                chkcol = True

            End If
            If chkDocNo.Checked = True Then

                Call genSQLdetailByDoc()
                Call getItemDetail()

            ElseIf optStk.Checked = True Then

                Call genSQLdetailByStk()
                Call getItemDetailByStk()

            End If
        End If
    End Sub

    Private Sub lbFindSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindSale.Click
        Dim searchSale As frmSearchSale = New frmSearchSale
        chkOptSale.Checked = True
        selStkID = ""
        searchSale.ShowDialog()
        lbSaleID.Text = selSaleiD
        lbSaleName.Text = dbTools.getSaleName(selSaleiD)
    End Sub

    Private Sub lbFindSale2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindSale2.Click
        Dim searchSale As frmSearchSale = New frmSearchSale
        chkOptSale2.Checked = True
        selStkID = ""
        searchSale.ShowDialog()
        lbSaleID2.Text = selSaleiD
        lbSaleName2.Text = dbTools.getSaleName(selSaleiD)
    End Sub


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click

        End

    End Sub

    Private Sub cmbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint.Click

        Worker1.WorkerReportsProgress = True
        Worker1.WorkerSupportsCancellation = True
        Worker1.RunWorkerAsync()

    End Sub

    Private Sub cmbRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRun.Click
        'Dim frmTime As New frmTimer
        'frmTime.ShowDialog()


        If cboDType.Text = "" Then
            MsgBox("โปรดเลือกหัวข้อรายงานที่ต้องการ ", MsgBoxStyle.Critical)
            Exit Sub
        Else

        End If

        lsvShow.Items.Clear()
        chkcol = False
        If chkcol = False Then

            lsvShow.Columns.Clear()
            Call getColListView()
            chkcol = True

        End If
        If cboDType.SelectedValue.ToString = "K" Then
            MsgBox("โปรแกรมกำลังอยู่ในระหว่างทดสอบ เกิดข้อผิดพลาดโปรดแจ้ง ICT ")
            genSQLdetlByPenOr()
            getItemDetail()
        Else
            Call genSQLdetailByDoc()
            If chkNoGrpBy.Checked = True Then
                Call getItemDetail()

            ElseIf chkGrpByStk.Checked = True Then
                Call getDetailGrpByStk()
            End If

        End If


    End Sub

    Sub RunAns()

        'If cboDType.Text = "" Then
        '    MsgBox("โปรดเลือกหัวข้อรายงานที่ต้องการ ", MsgBoxStyle.Critical)
        '    Exit Sub
        'Else

        'End If

        'lsvShow.Items.Clear()
        'chkcol = False
        'If chkcol = False Then

        '    lsvShow.Columns.Clear()
        '    Call getColListView()
        '    chkcol = True

        'End If
        'If cboDType.SelectedValue.ToString = "K" Then
        '    MsgBox("โปรแกรมกำลังอยู่ในระหว่างทดสอบ เกิดข้อผิดพลาดโปรดแจ้ง ICT ")
        '    genSQLdetlByPenOr()
        '    getItemDetail()
        'Else
        '    Call genSQLdetailByDoc()
        '    If chkNoGrpBy.Checked = True Then
        '        Call getItemDetail()
        '    ElseIf chkGrpByStk.Checked = True Then
        '        Call getDetailGrpByStk()
        '    End If

        'End If



        'If optDoc.Checked = True Then

        '    Call genSQLdetailByDoc()
        '    Call getItemDetail()

        'ElseIf optStk.Checked = True Then

        '    'Call genSQLdetailByStk()
        '    'Call getItemDetailByStk()
        '    Call genSQLdetailByDoc()
        '    Call getItemDetail()

        'End If
    End Sub

    Sub addProdList()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL = txtSQL & "From ProGrpMast "
        txtSQL = txtSQL & "Order by ProGrp_id "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData")
        If subDS.Tables("listData").Rows.Count > 0 Then
            cboFactor11.DataSource = subDS.Tables("listData")
            cboFactor11.ValueMember = "ProGrp_id"
            cboFactor11.DisplayMember = "ProGrp_Name"
            'cboDClist.Text = ""
            cboFactor11.SelectedItem = 0
        End If

    End Sub


    'Private Sub cboProdList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFactor11.SelectedIndexChanged
    '    Dim subDs As DataSet = New DataSet
    '    Dim subDa1 As SqlClient.SqlDataAdapter
    '    Try
    '        txtSQL = "Select  Type_Code,Type_Name  From TypeMast "
    '        txtSQL = txtSQL & "Where Type_Prod = '" & cboFactor11.SelectedValue.ToString & "' "
    '        txtSQL = txtSQL & "Order by Type_Code "

    '        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
    '        subDa1.Fill(subDs, "dbList")
    '        chkProdList = True

    '        If subDs.Tables("dbList").Rows.Count > 0 Then
    '            With cboFactor22

    '                .DataSource = subDs.Tables("dbList")
    '                .DisplayMember = "Type_Name"
    '                .ValueMember = "Type_Code"
    '                '.Items.Add("")
    '                .Text = ""
    '            End With
    '            'cboType.SelectedItem = Nothing
    '        End If
    '        'lbTypeID.Text = cboType.SelectedValue
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try

            txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
            txtSQL = txtSQL & "From GrpMast "

            If IsDBNull(cboFactor22.SelectedValue) = True Then

            Else
                txtSQL = txtSQL & "Where Grp_Type_Code='" & (cboFactor22.SelectedValue.ToString) & "' "
            End If

            txtSQL = txtSQL & "Order by Grp_Name "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkGrpC = True Then
                'subDs.Tables("GrpMast").Clear()
                'chkGrp = False

            End If
            subDa1.Fill(subDs, "GrpMast")
            chkGrpC = True

            If subDs.Tables("GrpMast").Rows.Count > 0 Then
                With cboFactor33
                    .DataSource = subDs.Tables("GrpMast")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"
                    If cboFactor22.Text = "GP" Then
                        .SelectedValue = 2
                    End If
                End With

            End If


            txtSQL = "Select  Color_Code,(color_code1 + '  '+ Color_StkName) as Color_StkName  From ColorMast "
            txtSQL = txtSQL & "Where Color_Type = '" & CStr(cboFactor22.SelectedValue) & "' "
            txtSQL = txtSQL & "Order by Color_stkname "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkColorC = True Then
                'subDs.Tables("ColorMast").Clear()
                'ChkColor = False

            End If
            subDa1.Fill(subDs, "ColorMast")
            chkColorC = False

            If subDs.Tables("ColorMast").Rows.Count > 0 Then
                With cboFactor44
                    .DataSource = subDs.Tables("ColorMast")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With
                cboFactor44.SelectedItem = Nothing
            End If

            ' Call showData()

        Catch ex As Exception

        End Try
    End Sub

    Sub getColFactor()


        'txtSQL = "Select  Type_Code,Type_Name,Type_Stk_Name  From TypeMast "
        'txtSQL = txtSQL & "Order by Type_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "TypeMast")

        'If ds.Tables("TypeMast").Rows.Count > 0 Then
        '    With cboType
        '        .DataSource = ds.Tables("TypeMast")
        '        .DisplayMember = "Type_Name"
        '        .ValueMember = "Type_Code"
        '        .Text = ""
        '    End With
        'End If

        'txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  From GrpMast "
        'txtSQL = txtSQL & "Order by Grp_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "GrpMast")

        'If ds.Tables("GrpMast").Rows.Count > 0 Then
        '    With cboGrp
        '        .DataSource = ds.Tables("GrpMast")
        '        .DisplayMember = "Grp_Name"
        '        .ValueMember = "Grp_Code"
        '        .Text = ""
        '    End With
        'End If


        'txtSQL = "Select  Color_Code,(color_code1 + '-'+ Color_StkName) as Color_StkName "
        'txtSQL = txtSQL & "From ColorMast "
        'txtSQL = txtSQL & "Order by Color_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "ColorMast")

        'If ds.Tables("ColorMast").Rows.Count > 0 Then
        '    With cboColor
        '        .DataSource = ds.Tables("ColorMast")
        '        .DisplayMember = "Color_StkName"
        '        .ValueMember = "Color_Code"
        '        .Text = ""
        '    End With
        'End If


        txtSQL = "Select  Th_Name,Th_Code,Th_Th  From ThMast "
        txtSQL = txtSQL & "Order by Th_Name "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "ThMast")

        If subDS.Tables("ThMast").Rows.Count > 0 Then
            With cboFactor55
                .DataSource = subDS.Tables("ThMast")
                .DisplayMember = "Th_Th"
                .ValueMember = "Th_Code"
                .Text = ""
            End With
        End If

    End Sub

    Function getSelMaster(ByVal f1 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If f1 = "01" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' "
            txtSQL = txtSQL & "Order by Fac_Code "

        ElseIf f1 = "02" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or  Fac_code='07' "
            txtSQL = txtSQL & "Order by Fac_Code "
        ElseIf f1 = "03" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or Fac_Code='02'   or  Fac_code='07' "
            txtSQL = txtSQL & "Order by Fac_Code "

        ElseIf f1 = "04" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or Fac_Code='02'  or  Fac_code='05' or  Fac_code='07' "
            txtSQL = txtSQL & "Order by Fac_Code "

        End If

        subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA2.Fill(subDS2, "selMaster")


        Return subDS2

    End Function

    Function getMaster1(ByVal selTB As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_Prod = '" & cboFactor11.SelectedValue.ToString & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            If IsDBNull(cboFactor22.SelectedValue) = True Then

            Else
                txtSQL = txtSQL & "Where Grp_Type_Code='" & (cboFactor22.SelectedValue.ToString) & "' "
            End If

            '            txtSQL = txtSQL & "Where Type_Prod = '" & cboFactor11.SelectedValue.ToString & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")


        End If

        Return subDS2

    End Function
    Function getMaster2(ByVal selTB As String, ByVal F1 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")


        End If

        Return subDS2

    End Function

    Function getMaster3(ByVal selTB As String, ByVal F1 As String, ByVal F2 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            txtSQL = txtSQL & "Where Grp_type_Code = '" & F2 & "' "
            txtSQL = txtSQL & "Order by Grp_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        End If

        Return subDS2

    End Function
    Function getMaster4(ByVal selTB As String, ByVal F1 As String, ByVal F2 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet

        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            txtSQL = txtSQL & "Where Grp_type_Code = '" & F2 & "' "
            txtSQL = txtSQL & "Order by Grp_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "05" Then

            txtSQL = "Select  Size_Code,Size_Name  "
            txtSQL = txtSQL & "From SizeMast "
            'txtSQL = txtSQL & "Where Size_Code = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Size_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        End If

        Return subDS2

    End Function


    Private Sub optSpec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSpec.CheckedChanged
        If optSpec.Checked = True Then
            chkF1.Checked = True

        End If
    End Sub




    Private Sub chkF1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF1.CheckedChanged
        Dim dsChkF1 As New DataSet

        If chkF1.Checked = True Then
            dsChkF1 = getSelMaster("01")
            If dsChkF1.Tables("selMaster").Rows.Count > 0 Then
                With cboFactor1
                    .DataSource = dsChkF1.Tables("selMaster")
                    .DisplayMember = "Fac_Name"
                    .ValueMember = "Fac_Code"
                    .SelectedIndex = 0
                End With
            End If
        End If
    End Sub


    Private Sub cboFactor1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFactor1.SelectedValueChanged
        Dim dsFC1 As New DataSet
        Try
            'MsgBox("ข้อมูลที่เลือก " & cboFactor1.SelectedValue.ToString)
            If cboFactor1.SelectedValue.ToString = "00" Then

                dsFC1 = getMaster1(cboFactor1.SelectedValue.ToString)
                With cboFactor11
                    .DataSource = dsFC1.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cboFactor11_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFactor11.SelectedValueChanged
        Label10.Text = cboFactor11.SelectedValue.ToString
    End Sub



    Private Sub chkF2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF2.CheckedChanged

        Dim dsChkF2 As New DataSet
        If chkF2.Checked = True Then

            dsChkF2 = getSelMaster("02")
            If dsChkF2.Tables("selMaster").Rows.Count > 0 Then
                With cboFactor2
                    .DataSource = dsChkF2.Tables("selMaster")
                    .DisplayMember = "Fac_Name"
                    .ValueMember = "Fac_Code"

                End With
            End If
        ElseIf chkF2.Checked = False Then

            'dsChkF2.Tables("selMaster").Clear()
            'cboFactor2.Items.Clear()

        End If

    End Sub

    Private Sub cboFactor2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFactor2.SelectedValueChanged
        Dim dsFC2 As New DataSet
        Try
            If cboFactor2.SelectedValue.ToString = "00" Then
                dsFC2 = getMaster2("00", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With
            ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                dsFC2 = getMaster2("01", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"

                End With
            ElseIf cboFactor2.SelectedValue.ToString = "07" Then
                dsFC2 = getMaster2("07", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "G_Name"
                    .ValueMember = "G_Code"

                End With

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboFactor22_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFactor22.SelectedValueChanged
        Label11.Text = cboFactor22.SelectedValue.ToString
    End Sub

    Private Sub chkF3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF3.CheckedChanged
        Dim dsChkF3 As New DataSet

        If chkF3.Checked = True Then
            dsChkF3 = getSelMaster("03")
            If dsChkF3.Tables("selMaster").Rows.Count > 0 Then
                With cboFactor3
                    .DataSource = dsChkF3.Tables("selMaster")
                    .DisplayMember = "Fac_Name"
                    .ValueMember = "Fac_Code"

                End With
            End If
        End If
    End Sub


    Private Sub cboFactor3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFactor3.SelectedIndexChanged
        Dim dsFC3 As New DataSet
        Try
            If cboFactor3.SelectedValue.ToString = "00" Then
                dsFC3 = getMaster3("00", cboFactor22.SelectedValue.ToString, "")
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                dsFC3 = getMaster3("01", cboFactor22.SelectedValue.ToString, "")
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "02" Then
                dsFC3 = getMaster3("02", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString)
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "07" Then
                dsFC3 = getMaster3("07", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString)
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "G_Name"
                    .ValueMember = "G_Code"

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub


   

    Private Sub Worker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker1.DoWork

        Call prnReport()

    End Sub

    Private Sub Worker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Worker1.RunWorkerCompleted

        MessageBox.Show("Worker is done !")

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub chkF4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF4.CheckedChanged
        Dim dsChkF4 As New DataSet

        If chkF4.Checked = True Then
            dsChkF4 = getSelMaster("04")
            If dsChkF4.Tables("selMaster").Rows.Count > 0 Then
                With cboFactor4
                    .DataSource = dsChkF4.Tables("selMaster")
                    .DisplayMember = "Fac_Name"
                    .ValueMember = "Fac_Code"

                End With
            End If
        End If
    End Sub

    Private Sub chkF5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkF5.CheckedChanged
        Dim dsChkF5 As New DataSet

        If chkF5.Checked = True Then
            dsChkF5 = getSelMaster("05")
            If dsChkF5.Tables("selMaster").Rows.Count > 0 Then
                With cboFactor5
                    .DataSource = dsChkF5.Tables("selMaster")
                    .DisplayMember = "Fac_Name"
                    .ValueMember = "Fac_Code"

                End With
            End If
        End If
    End Sub

    Private Sub chkOptSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOptSale.CheckedChanged

    End Sub

    Private Sub chkSelCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelCustom.CheckedChanged

    End Sub

    Private Sub lbFindWh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindWh.Click
        Dim findWh As New frmFindWH
        chkWH.Checked = True
        selWH = ""
        findWh.ShowDialog()
        lbWHCode.Text = selWH
        lbWHname.Text = dbTools.getStore(selWH)

    End Sub

    Private Sub txtSelectNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelectNo.TextChanged
        chkDocNo.Checked = True

    End Sub

    Private Sub cboFactor4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFactor4.SelectedIndexChanged
        Dim dsFC4 As New DataSet
        Try
            If cboFactor4.SelectedValue.ToString = "00" Then
                dsFC4 = getMaster4("00", cboFactor22.SelectedValue.ToString, "")
                With cboFactor44
                    .DataSource = dsFC4.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With
            ElseIf cboFactor4.SelectedValue.ToString = "01" Then
                dsFC4 = getMaster4("01", cboFactor22.SelectedValue.ToString, "")
                With cboFactor44

                    .DataSource = dsFC4.Tables("master")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"

                End With
            ElseIf cboFactor4.SelectedValue.ToString = "02" Then
                dsFC4 = getMaster4("02", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString)
                With cboFactor44

                    .DataSource = dsFC4.Tables("master")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"

                End With
            ElseIf cboFactor4.SelectedValue.ToString = "05" Then
                dsFC4 = getMaster4("05", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString)
                With cboFactor44

                    .DataSource = dsFC4.Tables("master")
                    .DisplayMember = "Size_Name"
                    .ValueMember = "Size_Code"
                End With

            ElseIf cboFactor4.SelectedValue.ToString = "07" Then
                dsFC4 = getMaster4("07", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString)
                With cboFactor44

                    .DataSource = dsFC4.Tables("master")
                    .DisplayMember = "G_Name"
                    .ValueMember = "G_Code"

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

   
End Class
