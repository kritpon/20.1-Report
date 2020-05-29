'Option Explicit On
'Option Strict On

'Imports Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Core


Public Class frmBegin
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbTranQty As System.Windows.Forms.Label
    Friend WithEvents lbQty1 As System.Windows.Forms.Label
    Friend WithEvents lbQty2 As System.Windows.Forms.Label
    Friend WithEvents chkSelCustom As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotSale2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkSelSale2 As System.Windows.Forms.RadioButton
    Friend WithEvents chkOptSale2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbAmt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
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
    Friend WithEvents lbGrpCode As System.Windows.Forms.Label
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
    Friend WithEvents lbProfitAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkNoGrpBy As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByStk As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByDoc As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpBySale As System.Windows.Forms.RadioButton
    Friend WithEvents chkGrpByCustom As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkNotSale As System.Windows.Forms.RadioButton
    Friend WithEvents chkSelSale As System.Windows.Forms.RadioButton
    Friend WithEvents chkOptSale As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAddComment As System.Windows.Forms.CheckBox
    Friend WithEvents lbFactor4 As System.Windows.Forms.Label
    Friend WithEvents cboGrpSL As System.Windows.Forms.ComboBox
    Friend WithEvents lbGrpSLCode As System.Windows.Forms.Label
    Friend WithEvents cboSale As System.Windows.Forms.ComboBox
    Friend WithEvents lbSelSaleID As System.Windows.Forms.Label
    Friend WithEvents cboSale2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbSelSaleID2 As System.Windows.Forms.Label
    Friend WithEvents lbGrpSLCode2 As System.Windows.Forms.Label
    Friend WithEvents cboGrpSL2 As System.Windows.Forms.ComboBox
    Friend WithEvents chkSelPO As System.Windows.Forms.CheckBox
    Friend WithEvents cboNoTypeDoc As System.Windows.Forms.ComboBox
    Friend WithEvents chkTypeVat As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents optNoSelNoType As System.Windows.Forms.RadioButton
    Friend WithEvents optSelNoType As System.Windows.Forms.RadioButton
    Friend WithEvents txtDiscItem As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDiscH As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabOpt1 As System.Windows.Forms.TabPage
    Friend WithEvents tabCost As System.Windows.Forms.TabPage
    Friend WithEvents lbDBName As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtStkCode As System.Windows.Forms.TextBox
    Friend WithEvents lbStkNameD As System.Windows.Forms.Label
    Friend WithEvents txtDateD As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCostPr As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents optType1 As System.Windows.Forms.RadioButton
    Friend WithEvents optType0 As System.Windows.Forms.RadioButton
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbPrSales As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbProFic As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbQty As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lbPrCost As System.Windows.Forms.Label
    Friend WithEvents lbProFicPer As System.Windows.Forms.Label
    Friend WithEvents chkCondition As System.Windows.Forms.CheckBox
    Friend WithEvents tabOpt2 As System.Windows.Forms.TabPage
    Friend WithEvents tabDisp As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbSumCost As System.Windows.Forms.Label
    Friend WithEvents lbSumSales As System.Windows.Forms.Label
    Friend WithEvents chkValueSum As System.Windows.Forms.CheckBox
    Friend WithEvents chkValueCost As System.Windows.Forms.CheckBox
    Friend WithEvents chkLostProF As System.Windows.Forms.CheckBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkNoGMB As System.Windows.Forms.CheckBox
    Friend WithEvents lbWHname As System.Windows.Forms.Label
    Friend WithEvents lbWHCode As System.Windows.Forms.Label
    Friend WithEvents lbFindWh As System.Windows.Forms.Label
    Friend WithEvents chkWH As System.Windows.Forms.CheckBox
    Friend WithEvents optSoft As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbWeigth As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbCal As System.Windows.Forms.Button
    Friend WithEvents txtCusCode As TextBox
    Friend WithEvents Worker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbString As Label
    Friend WithEvents lbReCount As Label
    Friend WithEvents lbDocNo As TextBox
    Friend WithEvents chkSalesYT As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProfitBit As TextBox
    Friend WithEvents lbStkCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboDType = New System.Windows.Forms.ComboBox()
        Me.lbDate01 = New System.Windows.Forms.DateTimePicker()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.lbFindStk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDate02 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkNot = New System.Windows.Forms.CheckBox()
        Me.optSpec = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbFactor4 = New System.Windows.Forms.Label()
        Me.lbGrpCode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboFactor5 = New System.Windows.Forms.ComboBox()
        Me.cboFactor4 = New System.Windows.Forms.ComboBox()
        Me.cboFactor3 = New System.Windows.Forms.ComboBox()
        Me.cboFactor2 = New System.Windows.Forms.ComboBox()
        Me.cboFactor1 = New System.Windows.Forms.ComboBox()
        Me.cboFactor55 = New System.Windows.Forms.ComboBox()
        Me.chkF5 = New System.Windows.Forms.CheckBox()
        Me.cboFactor44 = New System.Windows.Forms.ComboBox()
        Me.chkF4 = New System.Windows.Forms.CheckBox()
        Me.cboFactor33 = New System.Windows.Forms.ComboBox()
        Me.chkF3 = New System.Windows.Forms.CheckBox()
        Me.cboFactor22 = New System.Windows.Forms.ComboBox()
        Me.chkF2 = New System.Windows.Forms.CheckBox()
        Me.cboFactor11 = New System.Windows.Forms.ComboBox()
        Me.chkF1 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbDBName = New System.Windows.Forms.Label()
        Me.txtTSQL = New System.Windows.Forms.TextBox()
        Me.optStk = New System.Windows.Forms.CheckBox()
        Me.lbStkCode = New System.Windows.Forms.TextBox()
        Me.chkNotDoc = New System.Windows.Forms.CheckBox()
        Me.txtSelectNo = New System.Windows.Forms.TextBox()
        Me.chkDocNo = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSalesYT = New System.Windows.Forms.CheckBox()
        Me.lbReCount = New System.Windows.Forms.Label()
        Me.lbString = New System.Windows.Forms.Label()
        Me.chkNoGMB = New System.Windows.Forms.CheckBox()
        Me.chkLostProF = New System.Windows.Forms.CheckBox()
        Me.chkValueCost = New System.Windows.Forms.CheckBox()
        Me.chkValueSum = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProfitBit = New System.Windows.Forms.TextBox()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.cboNoTypeDoc = New System.Windows.Forms.ComboBox()
        Me.cboSale2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.optNoSelNoType = New System.Windows.Forms.RadioButton()
        Me.optSelNoType = New System.Windows.Forms.RadioButton()
        Me.chkTypeVat = New System.Windows.Forms.CheckBox()
        Me.cboGrpSL2 = New System.Windows.Forms.ComboBox()
        Me.lbGrpSLCode2 = New System.Windows.Forms.Label()
        Me.lbSelSaleID2 = New System.Windows.Forms.Label()
        Me.cboGrpSL = New System.Windows.Forms.ComboBox()
        Me.cboSale = New System.Windows.Forms.ComboBox()
        Me.lbSelSaleID = New System.Windows.Forms.Label()
        Me.lbGrpSLCode = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkNotSale = New System.Windows.Forms.RadioButton()
        Me.chkSelSale = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkNotSale2 = New System.Windows.Forms.RadioButton()
        Me.chkSelSale2 = New System.Windows.Forms.RadioButton()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.chkOptSale2 = New System.Windows.Forms.CheckBox()
        Me.chkSelCustom = New System.Windows.Forms.CheckBox()
        Me.chkOptSale = New System.Windows.Forms.CheckBox()
        Me.lbFindCus = New System.Windows.Forms.Label()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkCondition = New System.Windows.Forms.CheckBox()
        Me.chkGrpBySale = New System.Windows.Forms.RadioButton()
        Me.chkGrpByCustom = New System.Windows.Forms.RadioButton()
        Me.chkNoGrpBy = New System.Windows.Forms.RadioButton()
        Me.chkGrpByStk = New System.Windows.Forms.RadioButton()
        Me.chkGrpByDoc = New System.Windows.Forms.RadioButton()
        Me.chkSelPO = New System.Windows.Forms.CheckBox()
        Me.chkAddComment = New System.Windows.Forms.CheckBox()
        Me.chkOnDetail = New System.Windows.Forms.CheckBox()
        Me.chkProDDetl = New System.Windows.Forms.CheckBox()
        Me.chkCost = New System.Windows.Forms.CheckBox()
        Me.chkDispSale = New System.Windows.Forms.CheckBox()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbTranQty = New System.Windows.Forms.Label()
        Me.lbQty1 = New System.Windows.Forms.Label()
        Me.lbQty2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDiscItem = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDiscH = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbProfitAmt = New System.Windows.Forms.TextBox()
        Me.lbAmt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.indexBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.optSoft = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbPrint = New System.Windows.Forms.Button()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabOpt1 = New System.Windows.Forms.TabPage()
        Me.tabOpt2 = New System.Windows.Forms.TabPage()
        Me.tabDisp = New System.Windows.Forms.TabPage()
        Me.lbWHname = New System.Windows.Forms.Label()
        Me.lbWHCode = New System.Windows.Forms.Label()
        Me.lbFindWh = New System.Windows.Forms.Label()
        Me.chkWH = New System.Windows.Forms.CheckBox()
        Me.tabCost = New System.Windows.Forms.TabPage()
        Me.lbDocNo = New System.Windows.Forms.TextBox()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.lbWeigth = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbSumCost = New System.Windows.Forms.Label()
        Me.lbSumSales = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.cmbCal = New System.Windows.Forms.Button()
        Me.txtCostPr = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.optType0 = New System.Windows.Forms.RadioButton()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lbProFicPer = New System.Windows.Forms.Label()
        Me.lbPrCost = New System.Windows.Forms.Label()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lbProFic = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbPrSales = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbStkNameD = New System.Windows.Forms.Label()
        Me.txtDateD = New System.Windows.Forms.TextBox()
        Me.txtStkCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Worker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tabOpt1.SuspendLayout()
        Me.tabDisp.SuspendLayout()
        Me.tabCost.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDType
        '
        Me.cboDType.BackColor = System.Drawing.SystemColors.Window
        Me.cboDType.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboDType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDType.Location = New System.Drawing.Point(68, 360)
        Me.cboDType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDType.Name = "cboDType"
        Me.cboDType.Size = New System.Drawing.Size(232, 26)
        Me.cboDType.TabIndex = 1
        Me.cboDType.Text = "ComboBox1"
        '
        'lbDate01
        '
        Me.lbDate01.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate01.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate01.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbDate01.Location = New System.Drawing.Point(827, 362)
        Me.lbDate01.Margin = New System.Windows.Forms.Padding(2)
        Me.lbDate01.Name = "lbDate01"
        Me.lbDate01.Size = New System.Drawing.Size(136, 25)
        Me.lbDate01.TabIndex = 2
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkName.Location = New System.Drawing.Point(81, 16)
        Me.lbStkName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(358, 25)
        Me.lbStkName.TabIndex = 9
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbFindStk.Location = New System.Drawing.Point(440, 16)
        Me.lbFindStk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(34, 25)
        Me.lbFindStk.TabIndex = 6
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(43, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ª×èÍÊÔ¹¤éÒ"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 367)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "รายงาน"
        '
        'lbDate02
        '
        Me.lbDate02.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate02.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate02.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbDate02.Location = New System.Drawing.Point(1009, 362)
        Me.lbDate02.Margin = New System.Windows.Forms.Padding(2)
        Me.lbDate02.Name = "lbDate02"
        Me.lbDate02.Size = New System.Drawing.Size(132, 25)
        Me.lbDate02.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(977, 370)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ถึง"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbStkName)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.optStk)
        Me.GroupBox2.Controls.Add(Me.lbStkCode)
        Me.GroupBox2.Controls.Add(Me.lbFindStk)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(619, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(483, 272)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 53)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 209)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.chkNot)
        Me.TabPage1.Controls.Add(Me.optSpec)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(464, 182)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Option 1"
        '
        'chkNot
        '
        Me.chkNot.AutoSize = True
        Me.chkNot.ForeColor = System.Drawing.Color.SaddleBrown
        Me.chkNot.Location = New System.Drawing.Point(155, 9)
        Me.chkNot.Margin = New System.Windows.Forms.Padding(2)
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
        Me.optSpec.Location = New System.Drawing.Point(6, 8)
        Me.optSpec.Margin = New System.Windows.Forms.Padding(2)
        Me.optSpec.Name = "optSpec"
        Me.optSpec.Size = New System.Drawing.Size(133, 18)
        Me.optSpec.TabIndex = 38
        Me.optSpec.Text = "ตามการแยกประเภท"
        Me.optSpec.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lbFactor4)
        Me.GroupBox9.Controls.Add(Me.lbGrpCode)
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
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(10, 22)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(446, 148)
        Me.GroupBox9.TabIndex = 37
        Me.GroupBox9.TabStop = False
        '
        'lbFactor4
        '
        Me.lbFactor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFactor4.Location = New System.Drawing.Point(374, 96)
        Me.lbFactor4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFactor4.Name = "lbFactor4"
        Me.lbFactor4.Size = New System.Drawing.Size(66, 14)
        Me.lbFactor4.TabIndex = 43
        '
        'lbGrpCode
        '
        Me.lbGrpCode.ForeColor = System.Drawing.Color.Black
        Me.lbGrpCode.Location = New System.Drawing.Point(374, 72)
        Me.lbGrpCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrpCode.Name = "lbGrpCode"
        Me.lbGrpCode.Size = New System.Drawing.Size(60, 14)
        Me.lbGrpCode.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(374, 48)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 14)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(374, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Label10"
        '
        'cboFactor5
        '
        Me.cboFactor5.Enabled = False
        Me.cboFactor5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor5.FormattingEnabled = True
        Me.cboFactor5.Location = New System.Drawing.Point(110, 119)
        Me.cboFactor5.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor5.Name = "cboFactor5"
        Me.cboFactor5.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor5.TabIndex = 39
        '
        'cboFactor4
        '
        Me.cboFactor4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor4.FormattingEnabled = True
        Me.cboFactor4.Location = New System.Drawing.Point(110, 93)
        Me.cboFactor4.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor4.Name = "cboFactor4"
        Me.cboFactor4.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor4.TabIndex = 38
        '
        'cboFactor3
        '
        Me.cboFactor3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor3.FormattingEnabled = True
        Me.cboFactor3.Location = New System.Drawing.Point(110, 68)
        Me.cboFactor3.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor3.Name = "cboFactor3"
        Me.cboFactor3.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor3.TabIndex = 37
        '
        'cboFactor2
        '
        Me.cboFactor2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor2.FormattingEnabled = True
        Me.cboFactor2.Location = New System.Drawing.Point(110, 43)
        Me.cboFactor2.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor2.Name = "cboFactor2"
        Me.cboFactor2.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor2.TabIndex = 36
        '
        'cboFactor1
        '
        Me.cboFactor1.Enabled = False
        Me.cboFactor1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor1.FormattingEnabled = True
        Me.cboFactor1.Location = New System.Drawing.Point(110, 18)
        Me.cboFactor1.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor1.Name = "cboFactor1"
        Me.cboFactor1.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor1.TabIndex = 35
        '
        'cboFactor55
        '
        Me.cboFactor55.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor55.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor55.FormattingEnabled = True
        Me.cboFactor55.Location = New System.Drawing.Point(224, 118)
        Me.cboFactor55.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor55.Name = "cboFactor55"
        Me.cboFactor55.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor55.TabIndex = 34
        '
        'chkF5
        '
        Me.chkF5.AutoSize = True
        Me.chkF5.Enabled = False
        Me.chkF5.ForeColor = System.Drawing.Color.Black
        Me.chkF5.Location = New System.Drawing.Point(17, 122)
        Me.chkF5.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF5.Name = "chkF5"
        Me.chkF5.Size = New System.Drawing.Size(72, 18)
        Me.chkF5.TabIndex = 33
        Me.chkF5.Text = "Factor5"
        Me.chkF5.UseVisualStyleBackColor = True
        '
        'cboFactor44
        '
        Me.cboFactor44.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor44.DropDownHeight = 80
        Me.cboFactor44.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor44.FormattingEnabled = True
        Me.cboFactor44.IntegralHeight = False
        Me.cboFactor44.ItemHeight = 16
        Me.cboFactor44.Location = New System.Drawing.Point(224, 92)
        Me.cboFactor44.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor44.Name = "cboFactor44"
        Me.cboFactor44.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor44.TabIndex = 32
        '
        'chkF4
        '
        Me.chkF4.AutoSize = True
        Me.chkF4.ForeColor = System.Drawing.Color.Black
        Me.chkF4.Location = New System.Drawing.Point(17, 96)
        Me.chkF4.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF4.Name = "chkF4"
        Me.chkF4.Size = New System.Drawing.Size(72, 18)
        Me.chkF4.TabIndex = 31
        Me.chkF4.Text = "Factor4"
        Me.chkF4.UseVisualStyleBackColor = True
        '
        'cboFactor33
        '
        Me.cboFactor33.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor33.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor33.FormattingEnabled = True
        Me.cboFactor33.Location = New System.Drawing.Point(224, 67)
        Me.cboFactor33.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor33.Name = "cboFactor33"
        Me.cboFactor33.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor33.TabIndex = 30
        '
        'chkF3
        '
        Me.chkF3.AutoSize = True
        Me.chkF3.ForeColor = System.Drawing.Color.Black
        Me.chkF3.Location = New System.Drawing.Point(17, 71)
        Me.chkF3.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF3.Name = "chkF3"
        Me.chkF3.Size = New System.Drawing.Size(72, 18)
        Me.chkF3.TabIndex = 29
        Me.chkF3.Text = "Factor3"
        Me.chkF3.UseVisualStyleBackColor = True
        '
        'cboFactor22
        '
        Me.cboFactor22.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor22.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor22.FormattingEnabled = True
        Me.cboFactor22.Location = New System.Drawing.Point(224, 42)
        Me.cboFactor22.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor22.Name = "cboFactor22"
        Me.cboFactor22.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor22.TabIndex = 28
        '
        'chkF2
        '
        Me.chkF2.AutoSize = True
        Me.chkF2.ForeColor = System.Drawing.Color.Black
        Me.chkF2.Location = New System.Drawing.Point(17, 46)
        Me.chkF2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF2.Name = "chkF2"
        Me.chkF2.Size = New System.Drawing.Size(72, 18)
        Me.chkF2.TabIndex = 27
        Me.chkF2.Text = "Factor2"
        Me.chkF2.UseVisualStyleBackColor = True
        '
        'cboFactor11
        '
        Me.cboFactor11.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor11.FormattingEnabled = True
        Me.cboFactor11.Location = New System.Drawing.Point(224, 17)
        Me.cboFactor11.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor11.Name = "cboFactor11"
        Me.cboFactor11.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor11.TabIndex = 26
        '
        'chkF1
        '
        Me.chkF1.AutoSize = True
        Me.chkF1.ForeColor = System.Drawing.Color.Black
        Me.chkF1.Location = New System.Drawing.Point(17, 21)
        Me.chkF1.Margin = New System.Windows.Forms.Padding(2)
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
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(464, 182)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Option 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbDBName)
        Me.TabPage3.Controls.Add(Me.txtTSQL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(464, 182)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "txtSQL"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbDBName
        '
        Me.lbDBName.AutoSize = True
        Me.lbDBName.ForeColor = System.Drawing.Color.Black
        Me.lbDBName.Location = New System.Drawing.Point(6, 82)
        Me.lbDBName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDBName.Name = "lbDBName"
        Me.lbDBName.Size = New System.Drawing.Size(55, 14)
        Me.lbDBName.TabIndex = 26
        Me.lbDBName.Text = "Label18"
        '
        'txtTSQL
        '
        Me.txtTSQL.ForeColor = System.Drawing.Color.Blue
        Me.txtTSQL.Location = New System.Drawing.Point(3, 5)
        Me.txtTSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTSQL.Multiline = True
        Me.txtTSQL.Name = "txtTSQL"
        Me.txtTSQL.Size = New System.Drawing.Size(506, 72)
        Me.txtTSQL.TabIndex = 37
        '
        'optStk
        '
        Me.optStk.AutoSize = True
        Me.optStk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optStk.Location = New System.Drawing.Point(8, 22)
        Me.optStk.Margin = New System.Windows.Forms.Padding(2)
        Me.optStk.Name = "optStk"
        Me.optStk.Size = New System.Drawing.Size(78, 18)
        Me.optStk.TabIndex = 17
        Me.optStk.Text = "ตามสินค้า"
        Me.optStk.UseVisualStyleBackColor = True
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.Yellow
        Me.lbStkCode.Location = New System.Drawing.Point(87, 14)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(308, 22)
        Me.lbStkCode.TabIndex = 13
        '
        'chkNotDoc
        '
        Me.chkNotDoc.AutoSize = True
        Me.chkNotDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNotDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNotDoc.Location = New System.Drawing.Point(277, 142)
        Me.chkNotDoc.Margin = New System.Windows.Forms.Padding(2)
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
        Me.txtSelectNo.Location = New System.Drawing.Point(94, 134)
        Me.txtSelectNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSelectNo.MaxLength = 20
        Me.txtSelectNo.Name = "txtSelectNo"
        Me.txtSelectNo.Size = New System.Drawing.Size(176, 26)
        Me.txtSelectNo.TabIndex = 3
        '
        'chkDocNo
        '
        Me.chkDocNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDocNo.Location = New System.Drawing.Point(6, 138)
        Me.chkDocNo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDocNo.Name = "chkDocNo"
        Me.chkDocNo.Size = New System.Drawing.Size(130, 24)
        Me.chkDocNo.TabIndex = 2
        Me.chkDocNo.Text = "ส่วนเลขที่"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chkSalesYT)
        Me.GroupBox3.Controls.Add(Me.lbReCount)
        Me.GroupBox3.Controls.Add(Me.lbString)
        Me.GroupBox3.Controls.Add(Me.chkNoGMB)
        Me.GroupBox3.Controls.Add(Me.chkLostProF)
        Me.GroupBox3.Controls.Add(Me.chkValueCost)
        Me.GroupBox3.Controls.Add(Me.chkValueSum)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(6, -2)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(1112, 282)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'chkSalesYT
        '
        Me.chkSalesYT.BackColor = System.Drawing.Color.RoyalBlue
        Me.chkSalesYT.Checked = True
        Me.chkSalesYT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSalesYT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSalesYT.ForeColor = System.Drawing.Color.White
        Me.chkSalesYT.Location = New System.Drawing.Point(12, 238)
        Me.chkSalesYT.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSalesYT.Name = "chkSalesYT"
        Me.chkSalesYT.Size = New System.Drawing.Size(202, 24)
        Me.chkSalesYT.TabIndex = 69
        Me.chkSalesYT.Text = "ตัด YT"
        Me.chkSalesYT.UseVisualStyleBackColor = False
        '
        'lbReCount
        '
        Me.lbReCount.BackColor = System.Drawing.Color.Black
        Me.lbReCount.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbReCount.ForeColor = System.Drawing.Color.Lime
        Me.lbReCount.Location = New System.Drawing.Point(218, 240)
        Me.lbReCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbReCount.Name = "lbReCount"
        Me.lbReCount.Size = New System.Drawing.Size(384, 22)
        Me.lbReCount.TabIndex = 68
        '
        'lbString
        '
        Me.lbString.BackColor = System.Drawing.Color.Black
        Me.lbString.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbString.ForeColor = System.Drawing.Color.Lime
        Me.lbString.Location = New System.Drawing.Point(218, 212)
        Me.lbString.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbString.Name = "lbString"
        Me.lbString.Size = New System.Drawing.Size(384, 22)
        Me.lbString.TabIndex = 67
        '
        'chkNoGMB
        '
        Me.chkNoGMB.BackColor = System.Drawing.Color.RoyalBlue
        Me.chkNoGMB.Checked = True
        Me.chkNoGMB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoGMB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNoGMB.ForeColor = System.Drawing.Color.White
        Me.chkNoGMB.Location = New System.Drawing.Point(12, 208)
        Me.chkNoGMB.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNoGMB.Name = "chkNoGMB"
        Me.chkNoGMB.Size = New System.Drawing.Size(202, 24)
        Me.chkNoGMB.TabIndex = 29
        Me.chkNoGMB.Text = "ตัด สินค้า GMB"
        Me.chkNoGMB.UseVisualStyleBackColor = False
        '
        'chkLostProF
        '
        Me.chkLostProF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkLostProF.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkLostProF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chkLostProF.Location = New System.Drawing.Point(218, 186)
        Me.chkLostProF.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLostProF.Name = "chkLostProF"
        Me.chkLostProF.Size = New System.Drawing.Size(182, 24)
        Me.chkLostProF.TabIndex = 28
        Me.chkLostProF.Text = "เลือก-เฉพาะที่ขาดทุน"
        Me.chkLostProF.UseVisualStyleBackColor = False
        '
        'chkValueCost
        '
        Me.chkValueCost.BackColor = System.Drawing.Color.RoyalBlue
        Me.chkValueCost.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkValueCost.ForeColor = System.Drawing.Color.White
        Me.chkValueCost.Location = New System.Drawing.Point(420, 186)
        Me.chkValueCost.Margin = New System.Windows.Forms.Padding(2)
        Me.chkValueCost.Name = "chkValueCost"
        Me.chkValueCost.Size = New System.Drawing.Size(182, 24)
        Me.chkValueCost.TabIndex = 24
        Me.chkValueCost.Text = "เลือก-เฉพาะที่ไม่มีต้นทุน"
        Me.chkValueCost.UseVisualStyleBackColor = False
        '
        'chkValueSum
        '
        Me.chkValueSum.BackColor = System.Drawing.Color.YellowGreen
        Me.chkValueSum.Checked = True
        Me.chkValueSum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkValueSum.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkValueSum.ForeColor = System.Drawing.Color.Black
        Me.chkValueSum.Location = New System.Drawing.Point(12, 186)
        Me.chkValueSum.Margin = New System.Windows.Forms.Padding(2)
        Me.chkValueSum.Name = "chkValueSum"
        Me.chkValueSum.Size = New System.Drawing.Size(202, 24)
        Me.chkValueSum.TabIndex = 22
        Me.chkValueSum.Text = "เลือก-เฉพาะที่มีมูลค่าขาย/ซื้อ"
        Me.chkValueSum.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtProfitBit)
        Me.GroupBox5.Controls.Add(Me.lbCusName)
        Me.GroupBox5.Controls.Add(Me.cboNoTypeDoc)
        Me.GroupBox5.Controls.Add(Me.cboSale2)
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.chkTypeVat)
        Me.GroupBox5.Controls.Add(Me.cboGrpSL2)
        Me.GroupBox5.Controls.Add(Me.lbGrpSLCode2)
        Me.GroupBox5.Controls.Add(Me.lbSelSaleID2)
        Me.GroupBox5.Controls.Add(Me.cboGrpSL)
        Me.GroupBox5.Controls.Add(Me.cboSale)
        Me.GroupBox5.Controls.Add(Me.lbSelSaleID)
        Me.GroupBox5.Controls.Add(Me.lbGrpSLCode)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.txtSelectNo)
        Me.GroupBox5.Controls.Add(Me.chkDocNo)
        Me.GroupBox5.Controls.Add(Me.chkNotDoc)
        Me.GroupBox5.Controls.Add(Me.lbCusID)
        Me.GroupBox5.Controls.Add(Me.chkOptSale2)
        Me.GroupBox5.Controls.Add(Me.chkSelCustom)
        Me.GroupBox5.Controls.Add(Me.chkOptSale)
        Me.GroupBox5.Controls.Add(Me.lbFindCus)
        Me.GroupBox5.Location = New System.Drawing.Point(2, 5)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(608, 172)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(574, 142)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 17)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "% กำไร"
        '
        'txtProfitBit
        '
        Me.txtProfitBit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProfitBit.Location = New System.Drawing.Point(518, 135)
        Me.txtProfitBit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProfitBit.Name = "txtProfitBit"
        Me.txtProfitBit.Size = New System.Drawing.Size(55, 27)
        Me.txtProfitBit.TabIndex = 72
        Me.txtProfitBit.Text = "5"
        Me.txtProfitBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(199, 14)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(396, 25)
        Me.lbCusName.TabIndex = 14
        '
        'cboNoTypeDoc
        '
        Me.cboNoTypeDoc.BackColor = System.Drawing.Color.Green
        Me.cboNoTypeDoc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboNoTypeDoc.ForeColor = System.Drawing.SystemColors.Info
        Me.cboNoTypeDoc.Location = New System.Drawing.Point(95, 103)
        Me.cboNoTypeDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNoTypeDoc.Name = "cboNoTypeDoc"
        Me.cboNoTypeDoc.Size = New System.Drawing.Size(174, 27)
        Me.cboNoTypeDoc.TabIndex = 26
        Me.cboNoTypeDoc.Text = "ComboBox1"
        '
        'cboSale2
        '
        Me.cboSale2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboSale2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSale2.FormattingEnabled = True
        Me.cboSale2.Location = New System.Drawing.Point(266, 72)
        Me.cboSale2.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSale2.Name = "cboSale2"
        Me.cboSale2.Size = New System.Drawing.Size(170, 26)
        Me.cboSale2.TabIndex = 62
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.optNoSelNoType)
        Me.GroupBox10.Controls.Add(Me.optSelNoType)
        Me.GroupBox10.Location = New System.Drawing.Point(274, 95)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox10.Size = New System.Drawing.Size(160, 36)
        Me.GroupBox10.TabIndex = 44
        Me.GroupBox10.TabStop = False
        '
        'optNoSelNoType
        '
        Me.optNoSelNoType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optNoSelNoType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.optNoSelNoType.Location = New System.Drawing.Point(71, 13)
        Me.optNoSelNoType.Margin = New System.Windows.Forms.Padding(2)
        Me.optNoSelNoType.Name = "optNoSelNoType"
        Me.optNoSelNoType.Size = New System.Drawing.Size(74, 16)
        Me.optNoSelNoType.TabIndex = 24
        Me.optNoSelNoType.Text = "ไม่เลือก"
        '
        'optSelNoType
        '
        Me.optSelNoType.Checked = True
        Me.optSelNoType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelNoType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSelNoType.Location = New System.Drawing.Point(6, 13)
        Me.optSelNoType.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelNoType.Name = "optSelNoType"
        Me.optSelNoType.Size = New System.Drawing.Size(90, 16)
        Me.optSelNoType.TabIndex = 23
        Me.optSelNoType.TabStop = True
        Me.optSelNoType.Text = "เลือก"
        '
        'chkTypeVat
        '
        Me.chkTypeVat.AutoSize = True
        Me.chkTypeVat.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkTypeVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkTypeVat.Location = New System.Drawing.Point(8, 110)
        Me.chkTypeVat.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTypeVat.Name = "chkTypeVat"
        Me.chkTypeVat.Size = New System.Drawing.Size(79, 18)
        Me.chkTypeVat.TabIndex = 66
        Me.chkTypeVat.Text = "ประเภท V"
        Me.chkTypeVat.UseVisualStyleBackColor = True
        '
        'cboGrpSL2
        '
        Me.cboGrpSL2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboGrpSL2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrpSL2.FormattingEnabled = True
        Me.cboGrpSL2.Location = New System.Drawing.Point(95, 71)
        Me.cboGrpSL2.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGrpSL2.Name = "cboGrpSL2"
        Me.cboGrpSL2.Size = New System.Drawing.Size(168, 26)
        Me.cboGrpSL2.TabIndex = 65
        '
        'lbGrpSLCode2
        '
        Me.lbGrpSLCode2.BackColor = System.Drawing.Color.SlateBlue
        Me.lbGrpSLCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGrpSLCode2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGrpSLCode2.ForeColor = System.Drawing.Color.White
        Me.lbGrpSLCode2.Location = New System.Drawing.Point(95, 72)
        Me.lbGrpSLCode2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrpSLCode2.Name = "lbGrpSLCode2"
        Me.lbGrpSLCode2.Size = New System.Drawing.Size(44, 25)
        Me.lbGrpSLCode2.TabIndex = 64
        Me.lbGrpSLCode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSelSaleID2
        '
        Me.lbSelSaleID2.BackColor = System.Drawing.Color.SlateBlue
        Me.lbSelSaleID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSelSaleID2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSelSaleID2.ForeColor = System.Drawing.Color.White
        Me.lbSelSaleID2.Location = New System.Drawing.Point(311, 72)
        Me.lbSelSaleID2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSelSaleID2.Name = "lbSelSaleID2"
        Me.lbSelSaleID2.Size = New System.Drawing.Size(45, 25)
        Me.lbSelSaleID2.TabIndex = 63
        Me.lbSelSaleID2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboGrpSL
        '
        Me.cboGrpSL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboGrpSL.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrpSL.FormattingEnabled = True
        Me.cboGrpSL.Location = New System.Drawing.Point(96, 43)
        Me.cboGrpSL.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGrpSL.Name = "cboGrpSL"
        Me.cboGrpSL.Size = New System.Drawing.Size(166, 26)
        Me.cboGrpSL.TabIndex = 57
        '
        'cboSale
        '
        Me.cboSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboSale.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSale.FormattingEnabled = True
        Me.cboSale.Location = New System.Drawing.Point(266, 42)
        Me.cboSale.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSale.Name = "cboSale"
        Me.cboSale.Size = New System.Drawing.Size(170, 26)
        Me.cboSale.TabIndex = 59
        '
        'lbSelSaleID
        '
        Me.lbSelSaleID.BackColor = System.Drawing.Color.SlateBlue
        Me.lbSelSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSelSaleID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSelSaleID.ForeColor = System.Drawing.Color.White
        Me.lbSelSaleID.Location = New System.Drawing.Point(311, 43)
        Me.lbSelSaleID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSelSaleID.Name = "lbSelSaleID"
        Me.lbSelSaleID.Size = New System.Drawing.Size(45, 25)
        Me.lbSelSaleID.TabIndex = 60
        Me.lbSelSaleID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbGrpSLCode
        '
        Me.lbGrpSLCode.BackColor = System.Drawing.Color.SlateBlue
        Me.lbGrpSLCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGrpSLCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGrpSLCode.ForeColor = System.Drawing.Color.White
        Me.lbGrpSLCode.Location = New System.Drawing.Point(98, 44)
        Me.lbGrpSLCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrpSLCode.Name = "lbGrpSLCode"
        Me.lbGrpSLCode.Size = New System.Drawing.Size(43, 25)
        Me.lbGrpSLCode.TabIndex = 58
        Me.lbGrpSLCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkNotSale)
        Me.GroupBox7.Controls.Add(Me.chkSelSale)
        Me.GroupBox7.Location = New System.Drawing.Point(438, 35)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(156, 36)
        Me.GroupBox7.TabIndex = 43
        Me.GroupBox7.TabStop = False
        '
        'chkNotSale
        '
        Me.chkNotSale.AutoSize = True
        Me.chkNotSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkNotSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkNotSale.Location = New System.Drawing.Point(88, 13)
        Me.chkNotSale.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNotSale.Name = "chkNotSale"
        Me.chkNotSale.Size = New System.Drawing.Size(67, 18)
        Me.chkNotSale.TabIndex = 24
        Me.chkNotSale.Text = "ไม่เลือก"
        '
        'chkSelSale
        '
        Me.chkSelSale.Checked = True
        Me.chkSelSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSelSale.Location = New System.Drawing.Point(3, 14)
        Me.chkSelSale.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelSale.Name = "chkSelSale"
        Me.chkSelSale.Size = New System.Drawing.Size(90, 16)
        Me.chkSelSale.TabIndex = 23
        Me.chkSelSale.TabStop = True
        Me.chkSelSale.Text = "เลือก Sale"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkNotSale2)
        Me.GroupBox1.Controls.Add(Me.chkSelSale2)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(154, 35)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'chkNotSale2
        '
        Me.chkNotSale2.AutoSize = True
        Me.chkNotSale2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNotSale2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkNotSale2.Location = New System.Drawing.Point(85, 12)
        Me.chkNotSale2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNotSale2.Name = "chkNotSale2"
        Me.chkNotSale2.Size = New System.Drawing.Size(67, 18)
        Me.chkNotSale2.TabIndex = 31
        Me.chkNotSale2.Text = "ไม่เลือก"
        '
        'chkSelSale2
        '
        Me.chkSelSale2.Checked = True
        Me.chkSelSale2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSale2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSelSale2.Location = New System.Drawing.Point(2, 11)
        Me.chkSelSale2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelSale2.Name = "chkSelSale2"
        Me.chkSelSale2.Size = New System.Drawing.Size(96, 22)
        Me.chkSelSale2.TabIndex = 30
        Me.chkSelSale2.TabStop = True
        Me.chkSelSale2.Text = "เลือก Sale"
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Yellow
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(98, 14)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(70, 25)
        Me.lbCusID.TabIndex = 13
        Me.lbCusID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkOptSale2
        '
        Me.chkOptSale2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOptSale2.ForeColor = System.Drawing.Color.Black
        Me.chkOptSale2.Location = New System.Drawing.Point(6, 77)
        Me.chkOptSale2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkOptSale2.Name = "chkOptSale2"
        Me.chkOptSale2.Size = New System.Drawing.Size(131, 21)
        Me.chkOptSale2.TabIndex = 32
        Me.chkOptSale2.Text = "Sale ลูกค้า"
        '
        'chkSelCustom
        '
        Me.chkSelCustom.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelCustom.Location = New System.Drawing.Point(6, 21)
        Me.chkSelCustom.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelCustom.Name = "chkSelCustom"
        Me.chkSelCustom.Size = New System.Drawing.Size(98, 16)
        Me.chkSelCustom.TabIndex = 16
        Me.chkSelCustom.Text = "เลือกลูกค้า"
        '
        'chkOptSale
        '
        Me.chkOptSale.Checked = True
        Me.chkOptSale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOptSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOptSale.ForeColor = System.Drawing.Color.Black
        Me.chkOptSale.Location = New System.Drawing.Point(6, 49)
        Me.chkOptSale.Margin = New System.Windows.Forms.Padding(2)
        Me.chkOptSale.Name = "chkOptSale"
        Me.chkOptSale.Size = New System.Drawing.Size(96, 16)
        Me.chkOptSale.TabIndex = 25
        Me.chkOptSale.Text = "Sale หัวบิล"
        '
        'lbFindCus
        '
        Me.lbFindCus.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindCus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindCus.Location = New System.Drawing.Point(166, 14)
        Me.lbFindCus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindCus.Name = "lbFindCus"
        Me.lbFindCus.Size = New System.Drawing.Size(27, 25)
        Me.lbFindCus.TabIndex = 15
        Me.lbFindCus.Text = "..."
        Me.lbFindCus.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDate.Location = New System.Drawing.Point(782, 368)
        Me.chkDate.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(48, 18)
        Me.chkDate.TabIndex = 25
        Me.chkDate.Text = "วันที่"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkCondition)
        Me.GroupBox4.Controls.Add(Me.chkGrpBySale)
        Me.GroupBox4.Controls.Add(Me.chkGrpByCustom)
        Me.GroupBox4.Controls.Add(Me.chkNoGrpBy)
        Me.GroupBox4.Controls.Add(Me.chkGrpByStk)
        Me.GroupBox4.Controls.Add(Me.chkGrpByDoc)
        Me.GroupBox4.Controls.Add(Me.chkSelPO)
        Me.GroupBox4.Controls.Add(Me.chkAddComment)
        Me.GroupBox4.Controls.Add(Me.chkOnDetail)
        Me.GroupBox4.Controls.Add(Me.chkProDDetl)
        Me.GroupBox4.Controls.Add(Me.chkCost)
        Me.GroupBox4.Controls.Add(Me.chkDispSale)
        Me.GroupBox4.Location = New System.Drawing.Point(484, 5)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(652, 85)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'chkCondition
        '
        Me.chkCondition.Checked = True
        Me.chkCondition.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCondition.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCondition.ForeColor = System.Drawing.Color.Maroon
        Me.chkCondition.Location = New System.Drawing.Point(503, 10)
        Me.chkCondition.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCondition.Name = "chkCondition"
        Me.chkCondition.Size = New System.Drawing.Size(146, 24)
        Me.chkCondition.TabIndex = 28
        Me.chkCondition.Text = "áÊ´§ Condition"
        '
        'chkGrpBySale
        '
        Me.chkGrpBySale.AutoSize = True
        Me.chkGrpBySale.Enabled = False
        Me.chkGrpBySale.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpBySale.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpBySale.Location = New System.Drawing.Point(338, 120)
        Me.chkGrpBySale.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGrpBySale.Name = "chkGrpBySale"
        Me.chkGrpBySale.Size = New System.Drawing.Size(149, 20)
        Me.chkGrpBySale.TabIndex = 24
        Me.chkGrpBySale.TabStop = True
        Me.chkGrpBySale.Text = "ÃÇÁÃÒÂ¡ÒÃµÒÁ Sale"
        Me.chkGrpBySale.UseVisualStyleBackColor = True
        '
        'chkGrpByCustom
        '
        Me.chkGrpByCustom.AutoSize = True
        Me.chkGrpByCustom.Enabled = False
        Me.chkGrpByCustom.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByCustom.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpByCustom.Location = New System.Drawing.Point(324, 60)
        Me.chkGrpByCustom.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGrpByCustom.Name = "chkGrpByCustom"
        Me.chkGrpByCustom.Size = New System.Drawing.Size(163, 20)
        Me.chkGrpByCustom.TabIndex = 23
        Me.chkGrpByCustom.TabStop = True
        Me.chkGrpByCustom.Text = "ÃÇÁÃÒÂ¡ÒÃµÒÁÅÙ¡¤éÒ"
        Me.chkGrpByCustom.UseVisualStyleBackColor = True
        '
        'chkNoGrpBy
        '
        Me.chkNoGrpBy.AutoSize = True
        Me.chkNoGrpBy.Checked = True
        Me.chkNoGrpBy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkNoGrpBy.ForeColor = System.Drawing.Color.Black
        Me.chkNoGrpBy.Location = New System.Drawing.Point(324, 11)
        Me.chkNoGrpBy.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNoGrpBy.Name = "chkNoGrpBy"
        Me.chkNoGrpBy.Size = New System.Drawing.Size(137, 20)
        Me.chkNoGrpBy.TabIndex = 22
        Me.chkNoGrpBy.TabStop = True
        Me.chkNoGrpBy.Text = "áÂ¡ÃÒÂÅÐàÍÕÂ´"
        Me.chkNoGrpBy.UseVisualStyleBackColor = True
        '
        'chkGrpByStk
        '
        Me.chkGrpByStk.AutoSize = True
        Me.chkGrpByStk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByStk.ForeColor = System.Drawing.Color.Black
        Me.chkGrpByStk.Location = New System.Drawing.Point(324, 36)
        Me.chkGrpByStk.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGrpByStk.Name = "chkGrpByStk"
        Me.chkGrpByStk.Size = New System.Drawing.Size(182, 20)
        Me.chkGrpByStk.TabIndex = 21
        Me.chkGrpByStk.TabStop = True
        Me.chkGrpByStk.Text = "ÃÇÁÃÒÂ¡ÒÃµÒÁÊÔ¹¤éÒ"
        Me.chkGrpByStk.UseVisualStyleBackColor = True
        '
        'chkGrpByDoc
        '
        Me.chkGrpByDoc.AutoSize = True
        Me.chkGrpByDoc.Enabled = False
        Me.chkGrpByDoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkGrpByDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.chkGrpByDoc.Location = New System.Drawing.Point(338, 94)
        Me.chkGrpByDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGrpByDoc.Name = "chkGrpByDoc"
        Me.chkGrpByDoc.Size = New System.Drawing.Size(159, 20)
        Me.chkGrpByDoc.TabIndex = 20
        Me.chkGrpByDoc.TabStop = True
        Me.chkGrpByDoc.Text = "ÃÇÁÃÒÂ¡ÒÃµÒÁàÍ¡ÊÒÃ"
        Me.chkGrpByDoc.UseVisualStyleBackColor = True
        '
        'chkSelPO
        '
        Me.chkSelPO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelPO.Location = New System.Drawing.Point(176, 11)
        Me.chkSelPO.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelPO.Name = "chkSelPO"
        Me.chkSelPO.Size = New System.Drawing.Size(164, 24)
        Me.chkSelPO.TabIndex = 26
        Me.chkSelPO.Text = "áÊ´§àÅ¢·Õè #PO"
        '
        'chkAddComment
        '
        Me.chkAddComment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkAddComment.Location = New System.Drawing.Point(26, 114)
        Me.chkAddComment.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAddComment.Name = "chkAddComment"
        Me.chkAddComment.Size = New System.Drawing.Size(261, 24)
        Me.chkAddComment.TabIndex = 25
        Me.chkAddComment.Text = "áÊ´§-ËÁÒÂàËµØ"
        '
        'chkOnDetail
        '
        Me.chkOnDetail.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkOnDetail.Location = New System.Drawing.Point(176, 32)
        Me.chkOnDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.chkOnDetail.Name = "chkOnDetail"
        Me.chkOnDetail.Size = New System.Drawing.Size(146, 24)
        Me.chkOnDetail.TabIndex = 13
        Me.chkOnDetail.Text = "µéÍ§¡ÒÃ´ÙÃÒÂÅÐàÍÕÂ´"
        Me.chkOnDetail.Visible = False
        '
        'chkProDDetl
        '
        Me.chkProDDetl.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkProDDetl.Location = New System.Drawing.Point(25, 84)
        Me.chkProDDetl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkProDDetl.Name = "chkProDDetl"
        Me.chkProDDetl.Size = New System.Drawing.Size(261, 24)
        Me.chkProDDetl.TabIndex = 18
        Me.chkProDDetl.Text = "áÊ´§-ÃÒÂÅÐàÍÕÂ´ÊÔ¹¤éÒ ( »ÃÐàÀ·/¡ÅØèÁ/ÊÕ )"
        '
        'chkCost
        '
        Me.chkCost.Checked = True
        Me.chkCost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCost.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCost.Location = New System.Drawing.Point(10, 55)
        Me.chkCost.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCost.Name = "chkCost"
        Me.chkCost.Size = New System.Drawing.Size(240, 24)
        Me.chkCost.TabIndex = 17
        Me.chkCost.Text = "áÊ´§-¡ÓäÃ/¢Ò´·Ø¹"
        '
        'chkDispSale
        '
        Me.chkDispSale.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkDispSale.Location = New System.Drawing.Point(10, 14)
        Me.chkDispSale.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDispSale.Name = "chkDispSale"
        Me.chkDispSale.Size = New System.Drawing.Size(191, 16)
        Me.chkDispSale.TabIndex = 14
        Me.chkDispSale.Text = "áÊ´§ÃÒÂª×èÍ¾¹Ñ¡§Ò¹¢ÒÂ"
        '
        'lsvShow
        '
        Me.lsvShow.BackColor = System.Drawing.Color.Beige
        Me.lsvShow.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.Location = New System.Drawing.Point(8, 6)
        Me.lsvShow.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(1274, 300)
        Me.lsvShow.TabIndex = 21
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-143, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "¨Ó¹Ç¹ÃÒÂ¡ÒÃ"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(101, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "จำนวน"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "น้ำหนัก"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(736, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ขาย"
        '
        'lbTranQty
        '
        Me.lbTranQty.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbTranQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTranQty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTranQty.ForeColor = System.Drawing.Color.White
        Me.lbTranQty.Location = New System.Drawing.Point(5, 16)
        Me.lbTranQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTranQty.Name = "lbTranQty"
        Me.lbTranQty.Size = New System.Drawing.Size(50, 25)
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
        Me.lbQty1.Location = New System.Drawing.Point(142, 18)
        Me.lbQty1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty1.Name = "lbQty1"
        Me.lbQty1.Size = New System.Drawing.Size(101, 25)
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
        Me.lbQty2.Location = New System.Drawing.Point(326, 16)
        Me.lbQty2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty2.Name = "lbQty2"
        Me.lbQty2.Size = New System.Drawing.Size(65, 25)
        Me.lbQty2.TabIndex = 28
        Me.lbQty2.Text = "0"
        Me.lbQty2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(391, 24)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 24)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Ton."
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(244, 24)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 24)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "แผ่น"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(52, 24)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "รายการ"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbTranQty)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.txtCost)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtDiscItem)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.txtDiscH)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.lbProfitAmt)
        Me.GroupBox6.Controls.Add(Me.lbQty2)
        Me.GroupBox6.Controls.Add(Me.lbAmt)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.lbQty1)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 307)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(1272, 47)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.Blue
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCost.ForeColor = System.Drawing.Color.White
        Me.txtCost.Location = New System.Drawing.Point(941, 17)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(134, 24)
        Me.txtCost.TabIndex = 44
        Me.txtCost.Text = "0"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(916, 22)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 19)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "ทุน"
        '
        'txtDiscItem
        '
        Me.txtDiscItem.BackColor = System.Drawing.Color.Maroon
        Me.txtDiscItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDiscItem.ForeColor = System.Drawing.Color.White
        Me.txtDiscItem.Location = New System.Drawing.Point(471, 19)
        Me.txtDiscItem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscItem.Name = "txtDiscItem"
        Me.txtDiscItem.Size = New System.Drawing.Size(115, 23)
        Me.txtDiscItem.TabIndex = 42
        Me.txtDiscItem.Text = "0"
        Me.txtDiscItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(422, 23)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 24)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "ลด Item"
        '
        'txtDiscH
        '
        Me.txtDiscH.BackColor = System.Drawing.Color.Maroon
        Me.txtDiscH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDiscH.ForeColor = System.Drawing.Color.White
        Me.txtDiscH.Location = New System.Drawing.Point(644, 19)
        Me.txtDiscH.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiscH.Name = "txtDiscH"
        Me.txtDiscH.Size = New System.Drawing.Size(86, 23)
        Me.txtDiscH.TabIndex = 40
        Me.txtDiscH.Text = "0"
        Me.txtDiscH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(591, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 24)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "ลดหัวบิล"
        '
        'lbProfitAmt
        '
        Me.lbProfitAmt.BackColor = System.Drawing.Color.Blue
        Me.lbProfitAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProfitAmt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProfitAmt.ForeColor = System.Drawing.Color.White
        Me.lbProfitAmt.Location = New System.Drawing.Point(1128, 17)
        Me.lbProfitAmt.Margin = New System.Windows.Forms.Padding(2)
        Me.lbProfitAmt.Name = "lbProfitAmt"
        Me.lbProfitAmt.Size = New System.Drawing.Size(128, 24)
        Me.lbProfitAmt.TabIndex = 38
        Me.lbProfitAmt.Text = "0"
        Me.lbProfitAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbAmt
        '
        Me.lbAmt.BackColor = System.Drawing.Color.Blue
        Me.lbAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbAmt.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAmt.ForeColor = System.Drawing.Color.White
        Me.lbAmt.Location = New System.Drawing.Point(768, 17)
        Me.lbAmt.Margin = New System.Windows.Forms.Padding(2)
        Me.lbAmt.Name = "lbAmt"
        Me.lbAmt.Size = New System.Drawing.Size(134, 24)
        Me.lbAmt.TabIndex = 34
        Me.lbAmt.Text = "0"
        Me.lbAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(1094, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 24)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "กำไร"
        '
        'indexBar
        '
        Me.indexBar.BackColor = System.Drawing.Color.Gold
        Me.indexBar.Location = New System.Drawing.Point(304, 360)
        Me.indexBar.Margin = New System.Windows.Forms.Padding(2)
        Me.indexBar.Name = "indexBar"
        Me.indexBar.Size = New System.Drawing.Size(372, 23)
        Me.indexBar.TabIndex = 35
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.optSoft)
        Me.GroupBox8.Controls.Add(Me.RadioButton1)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.cmbPrint)
        Me.GroupBox8.Controls.Add(Me.cmbRun)
        Me.GroupBox8.Controls.Add(Me.cmbExit)
        Me.GroupBox8.Location = New System.Drawing.Point(1150, 360)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(132, 328)
        Me.GroupBox8.TabIndex = 36
        Me.GroupBox8.TabStop = False
        '
        'optSoft
        '
        Me.optSoft.AutoSize = True
        Me.optSoft.Location = New System.Drawing.Point(13, 211)
        Me.optSoft.Margin = New System.Windows.Forms.Padding(2)
        Me.optSoft.Name = "optSoft"
        Me.optSoft.Size = New System.Drawing.Size(71, 17)
        Me.optSoft.TabIndex = 28
        Me.optSoft.Text = "Color-Soft"
        Me.optSoft.UseVisualStyleBackColor = True
        Me.optSoft.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Beige
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 185)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 22)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Color-Light"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 282)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.YellowGreen
        Me.cmbPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbPrint.Location = New System.Drawing.Point(6, 73)
        Me.cmbPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(117, 42)
        Me.cmbPrint.TabIndex = 25
        Me.cmbPrint.Text = "Print"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'cmbRun
        '
        Me.cmbRun.BackColor = System.Drawing.Color.Gold
        Me.cmbRun.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbRun.Location = New System.Drawing.Point(6, 18)
        Me.cmbRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(117, 45)
        Me.cmbRun.TabIndex = 23
        Me.cmbRun.Text = "Run"
        Me.cmbRun.UseVisualStyleBackColor = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.DarkOrange
        Me.cmbExit.Location = New System.Drawing.Point(8, 123)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(117, 46)
        Me.cmbExit.TabIndex = 24
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl2.Controls.Add(Me.tabOpt1)
        Me.TabControl2.Controls.Add(Me.tabOpt2)
        Me.TabControl2.Controls.Add(Me.tabDisp)
        Me.TabControl2.Controls.Add(Me.tabCost)
        Me.TabControl2.Location = New System.Drawing.Point(8, 389)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1138, 315)
        Me.TabControl2.TabIndex = 38
        '
        'tabOpt1
        '
        Me.tabOpt1.BackColor = System.Drawing.Color.Transparent
        Me.tabOpt1.Controls.Add(Me.GroupBox3)
        Me.tabOpt1.Location = New System.Drawing.Point(4, 4)
        Me.tabOpt1.Margin = New System.Windows.Forms.Padding(2)
        Me.tabOpt1.Name = "tabOpt1"
        Me.tabOpt1.Padding = New System.Windows.Forms.Padding(2)
        Me.tabOpt1.Size = New System.Drawing.Size(1130, 289)
        Me.tabOpt1.TabIndex = 0
        Me.tabOpt1.Text = "รายงานขาย"
        '
        'tabOpt2
        '
        Me.tabOpt2.BackColor = System.Drawing.Color.Silver
        Me.tabOpt2.Location = New System.Drawing.Point(4, 4)
        Me.tabOpt2.Margin = New System.Windows.Forms.Padding(2)
        Me.tabOpt2.Name = "tabOpt2"
        Me.tabOpt2.Size = New System.Drawing.Size(1130, 289)
        Me.tabOpt2.TabIndex = 2
        Me.tabOpt2.Text = "ตัวเลือกสินค้า"
        '
        'tabDisp
        '
        Me.tabDisp.Controls.Add(Me.lbWHname)
        Me.tabDisp.Controls.Add(Me.lbWHCode)
        Me.tabDisp.Controls.Add(Me.lbFindWh)
        Me.tabDisp.Controls.Add(Me.chkWH)
        Me.tabDisp.Controls.Add(Me.GroupBox4)
        Me.tabDisp.Location = New System.Drawing.Point(4, 4)
        Me.tabDisp.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDisp.Name = "tabDisp"
        Me.tabDisp.Size = New System.Drawing.Size(1130, 289)
        Me.tabDisp.TabIndex = 3
        Me.tabDisp.Text = "การแสดงผล"
        Me.tabDisp.UseVisualStyleBackColor = True
        '
        'lbWHname
        '
        Me.lbWHname.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbWHname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHname.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHname.ForeColor = System.Drawing.Color.White
        Me.lbWHname.Location = New System.Drawing.Point(575, 130)
        Me.lbWHname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWHname.Name = "lbWHname"
        Me.lbWHname.Size = New System.Drawing.Size(268, 25)
        Me.lbWHname.TabIndex = 43
        '
        'lbWHCode
        '
        Me.lbWHCode.BackColor = System.Drawing.Color.Yellow
        Me.lbWHCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHCode.Location = New System.Drawing.Point(474, 131)
        Me.lbWHCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWHCode.Name = "lbWHCode"
        Me.lbWHCode.Size = New System.Drawing.Size(70, 25)
        Me.lbWHCode.TabIndex = 42
        Me.lbWHCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbFindWh
        '
        Me.lbFindWh.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindWh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindWh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindWh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindWh.Location = New System.Drawing.Point(542, 131)
        Me.lbFindWh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindWh.Name = "lbFindWh"
        Me.lbFindWh.Size = New System.Drawing.Size(27, 25)
        Me.lbFindWh.TabIndex = 44
        Me.lbFindWh.Text = "..."
        Me.lbFindWh.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'chkWH
        '
        Me.chkWH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkWH.ForeColor = System.Drawing.Color.Black
        Me.chkWH.Location = New System.Drawing.Point(381, 136)
        Me.chkWH.Margin = New System.Windows.Forms.Padding(2)
        Me.chkWH.Name = "chkWH"
        Me.chkWH.Size = New System.Drawing.Size(132, 21)
        Me.chkWH.TabIndex = 45
        Me.chkWH.Text = "¤ÅÑ§ÊÔ¹¤éÒ"
        '
        'tabCost
        '
        Me.tabCost.Controls.Add(Me.lbDocNo)
        Me.tabCost.Controls.Add(Me.txtCusCode)
        Me.tabCost.Controls.Add(Me.lbWeigth)
        Me.tabCost.Controls.Add(Me.Label24)
        Me.tabCost.Controls.Add(Me.Label25)
        Me.tabCost.Controls.Add(Me.Label26)
        Me.tabCost.Controls.Add(Me.lbSumCost)
        Me.tabCost.Controls.Add(Me.lbSumSales)
        Me.tabCost.Controls.Add(Me.GroupBox12)
        Me.tabCost.Controls.Add(Me.lbProFicPer)
        Me.tabCost.Controls.Add(Me.lbPrCost)
        Me.tabCost.Controls.Add(Me.lbQty)
        Me.tabCost.Controls.Add(Me.Label28)
        Me.tabCost.Controls.Add(Me.lbProFic)
        Me.tabCost.Controls.Add(Me.Label23)
        Me.tabCost.Controls.Add(Me.Label21)
        Me.tabCost.Controls.Add(Me.lbPrSales)
        Me.tabCost.Controls.Add(Me.Label20)
        Me.tabCost.Controls.Add(Me.lbStkNameD)
        Me.tabCost.Controls.Add(Me.txtDateD)
        Me.tabCost.Controls.Add(Me.txtStkCode)
        Me.tabCost.Controls.Add(Me.Label18)
        Me.tabCost.Location = New System.Drawing.Point(4, 4)
        Me.tabCost.Margin = New System.Windows.Forms.Padding(2)
        Me.tabCost.Name = "tabCost"
        Me.tabCost.Padding = New System.Windows.Forms.Padding(2)
        Me.tabCost.Size = New System.Drawing.Size(1130, 289)
        Me.tabCost.TabIndex = 1
        Me.tabCost.Text = "แก้ไขต้นทุน"
        Me.tabCost.UseVisualStyleBackColor = True
        '
        'lbDocNo
        '
        Me.lbDocNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbDocNo.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDocNo.ForeColor = System.Drawing.SystemColors.Menu
        Me.lbDocNo.Location = New System.Drawing.Point(127, 13)
        Me.lbDocNo.Margin = New System.Windows.Forms.Padding(2)
        Me.lbDocNo.Name = "lbDocNo"
        Me.lbDocNo.Size = New System.Drawing.Size(138, 33)
        Me.lbDocNo.TabIndex = 27
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtCusCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCusCode.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(10, 214)
        Me.txtCusCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(127, 20)
        Me.txtCusCode.TabIndex = 26
        '
        'lbWeigth
        '
        Me.lbWeigth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbWeigth.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWeigth.Location = New System.Drawing.Point(262, 95)
        Me.lbWeigth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWeigth.Name = "lbWeigth"
        Me.lbWeigth.Size = New System.Drawing.Size(180, 33)
        Me.lbWeigth.TabIndex = 25
        Me.lbWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(214, 108)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 20)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "น้ำหนัก"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(454, 108)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 20)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "มูลค่าทุน"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(448, 68)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 20)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "มูลค่าขาย"
        '
        'lbSumCost
        '
        Me.lbSumCost.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbSumCost.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSumCost.Location = New System.Drawing.Point(516, 95)
        Me.lbSumCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumCost.Name = "lbSumCost"
        Me.lbSumCost.Size = New System.Drawing.Size(218, 33)
        Me.lbSumCost.TabIndex = 21
        Me.lbSumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSumSales
        '
        Me.lbSumSales.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbSumSales.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSumSales.Location = New System.Drawing.Point(516, 55)
        Me.lbSumSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumSales.Name = "lbSumSales"
        Me.lbSumSales.Size = New System.Drawing.Size(218, 33)
        Me.lbSumSales.TabIndex = 20
        Me.lbSumSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.cmbCal)
        Me.GroupBox12.Controls.Add(Me.txtCostPr)
        Me.GroupBox12.Controls.Add(Me.Label19)
        Me.GroupBox12.Controls.Add(Me.GroupBox11)
        Me.GroupBox12.Controls.Add(Me.cmdSave)
        Me.GroupBox12.Location = New System.Drawing.Point(743, 6)
        Me.GroupBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox12.Size = New System.Drawing.Size(390, 217)
        Me.GroupBox12.TabIndex = 19
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "แก้ไข"
        '
        'cmbCal
        '
        Me.cmbCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCal.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbCal.Location = New System.Drawing.Point(234, 129)
        Me.cmbCal.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCal.Name = "cmbCal"
        Me.cmbCal.Size = New System.Drawing.Size(144, 50)
        Me.cmbCal.TabIndex = 9
        Me.cmbCal.Text = "คำนวนต้นทุน"
        Me.cmbCal.UseVisualStyleBackColor = False
        Me.cmbCal.Visible = False
        '
        'txtCostPr
        '
        Me.txtCostPr.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtCostPr.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCostPr.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCostPr.Location = New System.Drawing.Point(226, 29)
        Me.txtCostPr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCostPr.Name = "txtCostPr"
        Me.txtCostPr.Size = New System.Drawing.Size(154, 33)
        Me.txtCostPr.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(170, 40)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 17)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "ราคาทุน"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.optType1)
        Me.GroupBox11.Controls.Add(Me.optType0)
        Me.GroupBox11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox11.Size = New System.Drawing.Size(154, 189)
        Me.GroupBox11.TabIndex = 8
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "วิธีคิดต้นทุน"
        '
        'optType1
        '
        Me.optType1.AutoSize = True
        Me.optType1.Location = New System.Drawing.Point(20, 54)
        Me.optType1.Margin = New System.Windows.Forms.Padding(2)
        Me.optType1.Name = "optType1"
        Me.optType1.Size = New System.Drawing.Size(124, 23)
        Me.optType1.TabIndex = 1
        Me.optType1.TabStop = True
        Me.optType1.Text = "1. ทุนต่อหน่วย"
        Me.optType1.UseVisualStyleBackColor = True
        '
        'optType0
        '
        Me.optType0.AutoSize = True
        Me.optType0.Location = New System.Drawing.Point(16, 25)
        Me.optType0.Margin = New System.Windows.Forms.Padding(2)
        Me.optType0.Name = "optType0"
        Me.optType0.Size = New System.Drawing.Size(134, 23)
        Me.optType0.TabIndex = 0
        Me.optType0.TabStop = True
        Me.optType0.Text = "0. ทุนต่อน้ำหนัก"
        Me.optType0.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(234, 72)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(144, 50)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "บันทึกต้นทุน"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lbProFicPer
        '
        Me.lbProFicPer.BackColor = System.Drawing.Color.Yellow
        Me.lbProFicPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProFicPer.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProFicPer.Location = New System.Drawing.Point(518, 174)
        Me.lbProFicPer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProFicPer.Name = "lbProFicPer"
        Me.lbProFicPer.Size = New System.Drawing.Size(218, 34)
        Me.lbProFicPer.TabIndex = 18
        Me.lbProFicPer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPrCost
        '
        Me.lbPrCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbPrCost.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrCost.Location = New System.Drawing.Point(262, 135)
        Me.lbPrCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPrCost.Name = "lbPrCost"
        Me.lbPrCost.Size = New System.Drawing.Size(180, 33)
        Me.lbPrCost.TabIndex = 17
        Me.lbPrCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbQty
        '
        Me.lbQty.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbQty.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty.Location = New System.Drawing.Point(10, 49)
        Me.lbQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(100, 33)
        Me.lbQty.TabIndex = 16
        Me.lbQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 86)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 20)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "จำนวน"
        '
        'lbProFic
        '
        Me.lbProFic.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbProFic.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProFic.Location = New System.Drawing.Point(516, 135)
        Me.lbProFic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProFic.Name = "lbProFic"
        Me.lbProFic.Size = New System.Drawing.Size(218, 33)
        Me.lbProFic.TabIndex = 14
        Me.lbProFic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(473, 148)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 20)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "กำไร"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(214, 148)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 20)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "ราคาทุน"
        '
        'lbPrSales
        '
        Me.lbPrSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbPrSales.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrSales.Location = New System.Drawing.Point(262, 55)
        Me.lbPrSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPrSales.Name = "lbPrSales"
        Me.lbPrSales.Size = New System.Drawing.Size(180, 33)
        Me.lbPrSales.TabIndex = 10
        Me.lbPrSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(208, 68)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 20)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "ราคาขาย"
        '
        'lbStkNameD
        '
        Me.lbStkNameD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbStkNameD.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStkNameD.Location = New System.Drawing.Point(266, 12)
        Me.lbStkNameD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkNameD.Name = "lbStkNameD"
        Me.lbStkNameD.Size = New System.Drawing.Size(468, 31)
        Me.lbStkNameD.TabIndex = 3
        '
        'txtDateD
        '
        Me.txtDateD.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateD.Location = New System.Drawing.Point(10, 14)
        Me.txtDateD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateD.Name = "txtDateD"
        Me.txtDateD.Size = New System.Drawing.Size(116, 30)
        Me.txtDateD.TabIndex = 2
        '
        'txtStkCode
        '
        Me.txtStkCode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtStkCode.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkCode.ForeColor = System.Drawing.SystemColors.Window
        Me.txtStkCode.Location = New System.Drawing.Point(10, 236)
        Me.txtStkCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStkCode.Name = "txtStkCode"
        Me.txtStkCode.Size = New System.Drawing.Size(375, 27)
        Me.txtStkCode.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 262)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 20)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "รหัสสินค้า"
        '
        'Worker1
        '
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1307, 749)
        Me.Controls.Add(Me.cboDType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lsvShow)
        Me.Controls.Add(Me.lbDate01)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.indexBar)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lbDate02)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmBegin"
        Me.Text = "รายงานเอกสารต่างๆ"
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
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.tabOpt1.ResumeLayout(False)
        Me.tabDisp.ResumeLayout(False)
        Me.tabCost.ResumeLayout(False)
        Me.tabCost.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim subDA As Data.SqlClient.SqlDataAdapter
    Dim subDS As New Data.DataSet
    Dim chkData As Boolean

    Dim lvi As ListViewItem
    Dim lvi2 As ListViewItem

    Dim chkRow As Boolean = False
    Dim chkcol As Boolean = True

    Dim chkProdList As Boolean = False
    Dim chkGrpC As Boolean = False
    Dim chkColorC As Boolean = False

    Dim chkProfit As Boolean = False
    Dim Profitbit As Double = 0


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

    Dim frmFindStk As New frmFindStk

    Dim strStkCode As String
    Dim strstkName As String
    Dim strCost_pr As String
    Dim strCostType As String
    Dim strCost_id As String
    Dim strUpdate As String


    'Dim rpt1 As testReport3 = New testReport3
    Sub addItemSale(ByVal selGrpSale As String)

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As DataSet = New DataSet


        txtSQL = "SELECT * "
        txtSQL = txtSQL & " FROM  SalesMan "
        If selGrpSale = "G99" Then

        Else
            txtSQL = txtSQL & "Where SL_Grp='" & selGrpSale & "' "
        End If
        txtSQL = txtSQL & " Order by sl_id "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SLdata")

        With cboSale
            .DataSource = subDS.Tables("SLdata")
            .DisplayMember = "SL_Name"
            .ValueMember = "SL_ID"
        End With

        If cboGrpSL.Text = "All" Then
            cboSale.Text = "*"
        End If
        subDA = Nothing
        subDS = Nothing

    End Sub
    Sub addItemSale2(ByVal selGrpSale As String)

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As DataSet = New DataSet


        txtSQL = "SELECT * "
        txtSQL = txtSQL & " FROM  SalesMan "
        If selGrpSale = "G99" Then

        Else
            txtSQL = txtSQL & "Where SL_Grp='" & selGrpSale & "' "
        End If
        txtSQL = txtSQL & " Order by sl_id "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SLdata2")

        With cboSale2
            .DataSource = subDS.Tables("SLdata2")
            .DisplayMember = "SL_Name"
            .ValueMember = "SL_ID"
        End With

        'If cboGrpSL2.Text = "All" Then
        '    cboSale22.Text = "*"
        'End If
        subDA = Nothing
        subDS = Nothing

    End Sub
    Sub addItemGrpSL()

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim iRow As Integer = 0

        txtSQL = "Select * "
        txtSQL = txtSQL & "From GrpSales "
        txtSQL = txtSQL & "Order by GrpS_id "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "grpSL")

        If ds.Tables("grpSL").Rows.Count > 0 Then

            With cboGrpSL

                .DataSource = ds.Tables("grpSL")
                .DisplayMember = "Grps_Name"
                .ValueMember = "Grps_ID"


            End With
            With cboGrpSL

                .DataSource = ds.Tables("grpSL")
                .DisplayMember = "Grps_Name"
                .ValueMember = "Grps_ID"


            End With
        End If

        'cboGrpSL.SelectedItem = Nothing
        cboGrpSL.SelectedValue = "G05"


    End Sub

    Sub addItemGrpSL2()

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim iRow As Integer = 0

        txtSQL = "Select * "
        txtSQL = txtSQL & "From GrpSales "
        txtSQL = txtSQL & "Order by GrpS_id "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "grpSL")

        If ds.Tables("grpSL").Rows.Count > 0 Then

            With cboGrpSL2

                .DataSource = ds.Tables("grpSL")
                .DisplayMember = "Grps_Name"
                .ValueMember = "Grps_ID"


            End With
            With cboGrpSL2

                .DataSource = ds.Tables("grpSL")
                .DisplayMember = "Grps_Name"
                .ValueMember = "Grps_ID"


            End With
        End If

        'cboGrpSL.SelectedItem = Nothing
        cboGrpSL2.SelectedValue = "G05"


    End Sub

    Sub getColListView()


        'If chkFullOpt.Checked = True Then
        '    lsvShow.Columns.Add("¨Í§", 90, HorizontalAlignment.Right)
        '    lsvShow.Columns.Add("¤éÒ§Êè§", 90, HorizontalAlignment.Right)
        'Else

        'End If
        'If optDoc.Checked = True Then
        lsvShow.Columns.Add("Type", 5, HorizontalAlignment.Center)
        lsvShow.Columns.Add("ลำดับ", 25, HorizontalAlignment.Center)
        lsvShow.Columns.Add("วันที่", 65, HorizontalAlignment.Center)
        'lsvShow.Columns.Add("¤ÅÑ§", 40, HorizontalAlignment.Right)
        lsvShow.Columns.Add("เลขที่", 70, HorizontalAlignment.Left)
        If chkSelPO.Checked = True Then
            lsvShow.Columns.Add("เลขที่ PO", 90, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("เลขที่ PO", 1, HorizontalAlignment.Left)

        End If

        lsvShow.Columns.Add("ชื่อลูกค้า", 200, HorizontalAlignment.Left)
        'If CStr(cboDType.SelectedValue) = "S" Then
        If chkDispSale.Checked = True OrElse chkOptSale.Checked = True Then
            lsvShow.Columns.Add("พนักงานขาย", 70, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("ËÑÇºÔÅ", 1, HorizontalAlignment.Left)
        End If
        If chkDispSale.Checked = True OrElse chkOptSale2.Checked = True Then
            lsvShow.Columns.Add("Sale", 70, HorizontalAlignment.Left)
        Else
            lsvShow.Columns.Add("Sale", 1, HorizontalAlignment.Left)
        End If

        'End If
        lsvShow.Columns.Add("à¡çº", 2, HorizontalAlignment.Center)
        'If CStr(cboDType.SelectedValue) = "S" Then

        'Else
        '    lsvShow.Columns.Add("à¡çº", 90, HorizontalAlignment.Center)
        'End If

        lsvShow.Columns.Add("รายการสินค้า", 300, HorizontalAlignment.Left)

        lsvShow.Columns.Add("จำนวน(แผ่น)", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("นน.(Kg.)", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ราคา/Unit.", 95, HorizontalAlignment.Right)
        lsvShow.Columns.Add("มูลค่าขาย", 95, HorizontalAlignment.Right)

        'If chkCost.Checked = True Then    '  áÊ´§ ¡ÓäÃ/¢Ò´·Ø¹ 

        'End If
        lsvShow.Columns.Add("ราคา/kg", 95, HorizontalAlignment.Right)

        lsvShow.Columns.Add("ราคา/แผ่น", 95, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ราคา/Item", 70, HorizontalAlignment.Right)
        lsvShow.Columns.Add("ลดหัวบิล", 70, HorizontalAlignment.Right)

        lsvShow.Columns.Add("มูลค่าขาย", 100, HorizontalAlignment.Right)
        lsvShow.Columns.Add("กำไร", 90, HorizontalAlignment.Right)

        'If chkDisplStk.Checked = True Then

        '    lsvShow.Columns.Add("¤§àËÅ×Í(á¼è¹)", 90, HorizontalAlignment.Right)
        '    lsvShow.Columns.Add("¤§àËÅ×Í(Kg.)", 90, HorizontalAlignment.Right)

        'End If

        If chkProDDetl.Checked = True Then

        End If
        lsvShow.Columns.Add("Product Grp", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("ประเภท", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("กลุ่มย่อย", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("Color", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("หนา", 90, HorizontalAlignment.Left)
        lsvShow.Columns.Add("ขนาด", 90, HorizontalAlignment.Left)
        'lsvShow.Columns.Add("Paper", 90, HorizontalAlignment.Right)
        lsvShow.Columns.Add("เกรด", 90, HorizontalAlignment.Left)


        lsvShow.Columns.Add("StkCode", 10, HorizontalAlignment.Left)

        lsvShow.Columns.Add("user", 10, HorizontalAlignment.Right)
        lsvShow.Columns.Add("กำไร%", 100, HorizontalAlignment.Right)
        lsvShow.Columns.Add("NoType", 100, HorizontalAlignment.Right)

        'Profitbit
        'lsvShow.Columns.Add("¤§àËÅ×Í", 100, HorizontalAlignment.Right)
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
        ' Dim anyData2() As String

        Dim chkSelLostProF As Boolean = False
        '   µÑÇá»Ã ·Õèãªéã¹¡ÒÃ¤Ó¹Ç¹ ÃÒÂÅÐàÍÕÂ´

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim dtlType As String = ""
        Dim strDocNo As String = ""
        Dim dtlItem As String = ""
        Dim stkCode As String = ""
        Dim dtlStkName As String

        Dim strPtype As String = ""
        'Dim dtlDetail As String = ""
        Dim dtlPoDOC As String = ""

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
        Dim Dtl_ConDition As String = ""
        Dim Dtl_Con_id As String = ""
        Dim Q_Qty2 As Double = 0

        Dim Dtl_Cost_PR As Double = 0
        Dim Dtl_Cost_Amt As Double = 0

        Dim Dtl_Price As Double = 0
        Dim Dtl_Pr_Div_Q2 As Double = 0
        Dim Dtl_Amt As Double = 0
        Dim Dtl_ProFit As Double = 0

        Dim Dtl_Sum As Double = 0
        Dim strDtlDisc As String = ""
        Dim strTrhDisc As String = ""
        Dim Dtl_Disc As Double = 0
        Dim Trh_Disc As Double = 0

        Dim tempDisc As Double
        Dim tmpDtlDisc As Double = 0
        Dim tmpTrhDisc As Double = 0

        Dim irow0 As Integer = 0
        Dim txtCost0 As Double = 0
        Dim lbTranQty0 As Double = 0
        Dim lbQty1_0 As Double = 0
        Dim Dtl_Amt0 As Double = 0
        Dim txtDiscH0 As Double = 0
        Dim txtDiscItem0 As Double = 0
        Dim lbQty2_0 As Double = 0

        Dim num As Double = 0
        Dim userCo As String = ""

        Dim ProGrp_Name As String = ""
        Dim Type_Name As String = ""
        Dim Grp_Name As String = ""
        Dim Color_Name As String = ""
        Dim Th_Name As String = "'"
        Dim trh_Cost_Amt As Double = 0

        Dim Size_Name As String = ""
        Dim Grade_Name As String = ""
        Dim kgTotal As Double = 0
        Dim strShow As String = ""

        Dim itemQ As Double
        Dim amtDisc As Double
        Dim refCount As Integer = 0

        lbTranQty.Text = Format(0, "#,##0.00")
        lbQty1.Text = Format(0, "#,##0.00")
        kgTotal = 0
        lbQty2.Text = Format(0, "#,##0.00")
        lbAmt.Text = Format(0, "#,##0.00")
        lbProfitAmt.Text = Format(0, "#,##0.00")
        txtDiscH.Text = Format(0, "#,##0.00")
        txtDiscItem.Text = Format(0, "#,##0.00")
        txtCost.Text = Format(0, "#,##0.00")


        With subDS.Tables("Command")

            indexBar.Maximum = .Rows.Count
            indexBar.Minimum = 0
            indexBar.PerformStep()
            Dim RowCount As Integer = subDS.Tables("Command").Rows.Count
            Dim ref As Integer = CInt(((RowCount - 1) * 10) / 100)

            If (RowCount >= 1) Then

                lbReCount.Text = RowCount
                For iRow = 0 To RowCount - 1
                    refCount = refCount + 1
                    rowNo = iRow + 1
                    indexBar.Value = rowNo

                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then

                        MsgBox("ไม่พบชื่อสินค้าในฐานข้อมูล", MsgBoxStyle.Critical, "แจ้งเตือน")

                    End If

                    dtlType = CStr(.Rows(iRow).Item("Trh_Type"))
                    date01 = CDate(.Rows(iRow).Item("Trh_Date"))
                    strDocNo = CStr(.Rows(iRow).Item("Trh_No"))

                    'Dim linkDocNo As New LinkLabel
                    'linkDocNo.Name = strDocNo
                    'linkDocNo.Text = strDocNo
                    'Dim item2 As New ListViewItem("item2", 1)
                    'item2.SubItems.Add(dtlType)
                    'item2.SubItems.Add(date01)

                    ''lvi = New ListViewItem(anyData)
                    ''lsvShow.Items.Add(lvi)

                    ''ListView1.Items.AddRange(New ListViewItem() {item1, item2, item3})
                    ''ListView1.Items.Item(0).SubItems.Add(textBetween1)
                    'lsvShow.Columns.Add("Column 1", -2, HorizontalAlignment.Left)
                    'lsvShow.Columns.Add("Column 2", -2, HorizontalAlignment.Left)
                    'lsvShow.Items.AddRange(New ListViewItem() {item2})
                    '' lsvShow.Items.Item(0).SubItems.Add(textBetween1)

                    If IsDBNull(.Rows(iRow).Item("Trh_NoType")) Then
                        strPtype = ""
                    Else

                        strPtype = CStr(.Rows(iRow).Item("Trh_NoType"))
                    End If

                    If IsDBNull(.Rows(iRow).Item("Dtl_PO")) Then
                        dtlPoDOC = ""
                    Else
                        dtlPoDOC = CStr(.Rows(iRow).Item("Dtl_PO"))
                    End If

                    stkCode = CStr(.Rows(iRow).Item("dtl_idTrade"))


                    If dtlType = "B" Or dtlType = "D" Then
                        whName = ""
                    Else
                        If IsDBNull(.Rows(iRow).Item("Trh_Wh")) = True Then
                            whName = "ไม่พบรหัสคลังสินค้า"
                        Else
                            whName = CStr(dbTools.getStrName(.Rows(iRow).Item("Trh_Wh")))
                        End If
                    End If
                    If IsDBNull(.Rows(iRow).Item("Dtl_Con_id")) = False Then
                        Dtl_Con_id = .Rows(iRow).Item("dtl_con_id")
                    Else
                        Dtl_Con_id = ""
                    End If

                    If IsDBNull(.Rows(iRow).Item("condition")) = False Then

                        Dtl_ConDition = getCondition(Dtl_Con_id, "T")
                    End If

                    If dtlType = "S" Then
                        'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                        dtlItem = "ขายสินค้าให้ " & CStr(.Rows(iRow).Item("Ar_Name"))
                    ElseIf dtlType = "L" Or dtlType = "H" Then
                        'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                        dtlItem = "ลดหนี้ให้กับ " & CStr(.Rows(iRow).Item("Ar_Name"))

                    ElseIf dtlType = "X" Then
                        'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                        dtlItem = "àºÔ¡ÊÔ¹¤éÒÍÍ¡¨Ò¡ " & CStr(.Rows(iRow).Item("Ar_Name"))

                    ElseIf dtlType = "B" Then
                        'dtlItem = "Order ÊÔ¹¤éÒ¢Í§ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                        If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            dtlItem = " ******** äÁè¾º¢éÍÁÙÅ ***********"
                        Else
                            dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                        End If
                    ElseIf dtlType = "D" Then
                        If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            dtlItem = "รับสินค้าจากผลิต ******** äÁè¾º¢éÍÁÙÅ ***********"
                        Else
                            dtlItem = "รับสินค้าจากผลิตเพื่อ " & CStr(.Rows(iRow).Item("Ar_Name")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                        End If
                    ElseIf dtlType = "C" Then

                        If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            dtlItem = "ÃÑºÊÔ¹¤éÒ¨Ò¡¡ÒÃÊÑè§«×éÍ "
                        Else

                            dtlItem = "รับสินค้าจากซื้อ เพื่อ " & CStr(.Rows(iRow).Item("Ar_Name")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                        End If

                    ElseIf dtlType = "E" Then
                        If IsDBNull(.Rows(iRow).Item("Dtl_Cus_Name")) Then
                            dtlItem = "ÊÑè§¼ÅÔµà¾×èÍ " & "äÁèÁÕÃÐºØ" & "'"
                        Else
                            dtlItem = "สั่งผลิตสินค้า " & CStr(.Rows(iRow).Item("Dtl_Cus_Name")) '
                        End If

                    ElseIf dtlType = "G" Then
                        dtlItem = "ÃÑºÊÔ¹¤éÒ¨Ò¡¡ÒÃÃÕà¡Ã´."
                    ElseIf dtlType = "F" Then
                        dtlItem = "ÃÑºâÍ¹ÊÔ¹¤éÒà¢éÒ¤ÅÑ§ " & CStr(.Rows(iRow).Item("Ar_Name"))

                    ElseIf dtlType = "P" Or dtlType = "T" Then

                        If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            dtlItem = "àºÔ¡Êè§ãËé  "
                        Else
                            dtlItem = "àºÔ¡Êè§ãËé " & "-" & CStr(.Rows(iRow).Item("Ar_Name"))
                        End If

                    ElseIf dtlType = "Z" Then
                        dtlItem = "âÍ¹ÍÍ¡¨Ò¡¤ÅÑ§ " & CStr(.Rows(iRow).Item("Ar_Name"))
                    ElseIf dtlType = "A" Then
                        If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            dtlItem = "¾º¢éÍÁÙÅ AR_Name ¤èÒà»ç¹ Null "
                        Else
                            dtlItem = "»ÃÑºÂÍ´¡ÒÃµÃÇ¨¹Ñº" & "-" & CStr(.Rows(iRow).Item("Ar_Name"))
                        End If

                    ElseIf dtlType = "Q" Then
                        If IsDBNull(.Rows(iRow).Item("Trh_date")) Then
                            dtlItem = "µÃÇ¨¹Ñº "
                        Else
                            dtlItem = "µÃÇ¨¹Ñº ÇÑ¹·Õè " & .Rows(iRow).Item("Trh_date").ToString
                        End If

                    Else
                        dtlItem = " ******** äÁè¾º¢éÍÁÙÅ ***********"
                    End If


                    If IsDBNull(.Rows(iRow).Item("Stk_Name_1")) Then
                        dtlStkName = " ******** äÁè¾º¢éÍÁÙÅ ***********"
                    Else
                        dtlStkName = CStr(.Rows(iRow).Item("Stk_Name_1"))

                        If IsDBNull(.Rows(iRow).Item("Dtl_Detail")) = False And (dtlType = "S" Or dtlType = "L") Then
                            If Len(.Rows(iRow).Item("Dtl_Detail")) > 0 Then
                                '===============
                                'dtlStkName = dtlStkName & "--" & .Rows(iRow).Item("Dtl_Detail") ' àÍÒËÁÒÂàËµØãÊã¹ª×èÍ
                                dtlStkName = dtlStkName & "--" & .Rows(iRow).Item("Dtl_Detail") ' àÍÒËÁÒÂàËµØãÊã¹ª×èÍ
                                Dtl_Detail = .Rows(iRow).Item("Dtl_Detail")
                            End If
                        End If
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
                    Dtl_ProFit = 0
                    Dtl_Disc = 0
                    Trh_Disc = 0
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
                    ElseIf dtlType = "X" Then

                        Q_Rcv = num
                    ElseIf dtlType = "L" Or dtlType = "H" Then
                        Q_Rcv = num
                    ElseIf dtlType = "C" Then
                        Q_Rcv = num

                        Q_Rcv = num
                    ElseIf dtlType = "U" Then
                    ElseIf dtlType = "P" Or dtlType = "" Then
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

                    Dim Stk_F2 As Double = 0

                    If IsDBNull(.Rows(iRow).Item("Stk_Factor2")) Then
                        Stk_F2 = 0
                    Else
                        Stk_F2 = .Rows(iRow).Item("Stk_Factor2")
                    End If


                    '=====================================================================================================
                    If IsDBNull(.Rows(iRow).Item("Stk_Factor2")) Then
                        Q_Qty2 = Q_Rcv
                    Else
                        Q_Qty2 = (Q_Rcv * Stk_F2)
                    End If

                    'Dim tempTotal As Double

                    strDtlDisc = 0
                    tempDisc = 0
                    strTrhDisc = 0


                    '====================================================================================
                    If IsDBNull(.Rows(iRow).Item("Dtl_T_Disc")) = True Then

                        strDtlDisc = 0

                    Else
                        If IsNumeric(.Rows(iRow).Item("Dtl_T_Disc")) Then

                            strDtlDisc = .Rows(iRow).Item("Dtl_T_Disc")
                        Else

                            strDtlDisc = .Rows(iRow).Item("Dtl_T_Disc")

                        End If

                    End If
                    '===================================================

                    tmpTrhDisc = 0

                    If IsDBNull(.Rows(iRow).Item("Trh_Disc")) = True Then
                        strTrhDisc = 0
                    ElseIf Microsoft.VisualBasic.Right(.Rows(iRow).Item("Trh_Disc"), 1) = "%" Then

                        itemQ = getDocItem(strDocNo, dtlType)
                        amtDisc = getTrhDisc(strDocNo, dtlType)  ' ส่วนลดหัวบิล

                        If IsNumeric(.Rows(iRow).Item("Trh_Disc")) Then

                            If amtDisc = 0 Then
                                strTrhDisc = 0
                            Else
                                If itemQ = 0 Then
                                    strTrhDisc = 0
                                Else
                                    tmpTrhDisc = amtDisc / itemQ  ' ส่วนลดหัวบิล หารด้วยจำนวน Item ในบิล
                                    strTrhDisc = tmpTrhDisc
                                    'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
                                End If

                            End If
                        Else
                            strTrhDisc = .Rows(iRow).Item("Trh_Disc")
                            tmpTrhDisc = amtDisc / itemQ
                            'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
                        End If
                    ElseIf Microsoft.VisualBasic.Right(.Rows(iRow).Item("Trh_Disc"), 1) = "b" Then
                        strTrhDisc = .Rows(iRow).Item("Trh_Disc")
                        tmpTrhDisc = CDbl(Microsoft.VisualBasic.Left(.Rows(iRow).Item("Trh_Disc"), Len(.Rows(iRow).Item("Trh_Disc")) - 1))
                    ElseIf (.Rows(iRow).Item("Trh_Disc")) = 0 Then
                        strTrhDisc = 0
                    Else
                        itemQ = getDocItem(strDocNo, dtlType)
                        amtDisc = getTrhDisc(strDocNo, dtlType)  '  ÂÍ´à§Ô¹ÃÇÁ·ÕèËÑ¡ÊèÇ¹Å´áÅéÇ

                        If IsNumeric(.Rows(iRow).Item("Trh_Disc")) Then

                            If amtDisc = 0 Then
                                strTrhDisc = 0
                            Else
                                If itemQ = 0 Then
                                    strTrhDisc = 0
                                Else

                                    tmpTrhDisc = amtDisc / itemQ
                                    strTrhDisc = tmpTrhDisc
                                    'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
                                End If

                            End If
                        Else

                            strTrhDisc = .Rows(iRow).Item("Trh_Disc")
                            tmpTrhDisc = amtDisc / itemQ
                            'txtDiscH.Text = Format(tmpTrhDisc + CDbl(txtDiscH.Text), "#,##0.00")
                        End If

                    End If

                    '===================================================
                    If IsDBNull(.Rows(iRow).Item("Dtl_Price")) Then
                        Dtl_Price = 0
                    Else

                        '==============   àªç¤ÊèÇ¹Å´µèÍ Item  ¶éÒÁÕãËé¤Ó¹Ç¹ÁÙÅ¤èÒÃÇÁãËÁè   ========  
                        Dtl_Price = .Rows(iRow).Item("Dtl_Price")
                        If strDtlDisc = "0" Then


                        Else

                            tempDisc = getDiscValue(strDtlDisc, Dtl_Price)

                        End If

                        If dtlType = "B" Then
                            Dtl_Sum = (Dtl_Price - tempDisc) * Q_Rcv
                        Else

                            Dtl_Sum = ((Dtl_Price - tempDisc) * Q_Rcv) - tmpTrhDisc

                        End If
                        'If .Rows(iRow).Item("Dtl_Sum") = 0 Then

                        'Else

                        'End If
                        Dtl_Amt = Dtl_Sum
                    End If

                    '=============== µé¹·Ø¹   CS_Type=1   ¤Ô´µé¹·Ø¹µèÍ á¼è¹ / Ë¹èÇÂ
                    If dbTools.getCostType(stkCode) = 0 Then
                        'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
                        Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                        Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                        'Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        Dtl_ProFit = (Dtl_Amt - Dtl_Cost_Amt)
                        Profitbit = (Dtl_ProFit / Dtl_Cost_Amt) * 100

                        If Q_Qty2 = 0 Then
                            Dtl_Pr_Div_Q2 = Dtl_Amt
                        Else
                            Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / Q_Qty2)
                        End If

                    ElseIf dbTools.getCostType(stkCode) = 1 Then
                        Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                        Dtl_Cost_Amt = Dtl_Cost_PR * num
                        ' Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        Dtl_ProFit = (Dtl_Amt - Dtl_Cost_Amt)
                        Profitbit = (Dtl_ProFit / Dtl_Cost_Amt) * 100
                        If num = 0 Then
                            Dtl_Pr_Div_Q2 = Dtl_Amt
                        Else
                            Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / num)
                        End If
                    Else
                        'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
                        Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                        Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                        Dtl_ProFit = ((Dtl_Amt - Dtl_Cost_Amt - getDiscValue(strTrhDisc, Dtl_Sum)))
                        Profitbit = (Dtl_ProFit / Dtl_Cost_Amt) * 100

                        If Q_Qty2 = 0 Then
                            Dtl_Pr_Div_Q2 = Dtl_Amt
                        Else
                            Dtl_Pr_Div_Q2 = CDbl(Dtl_Amt / Q_Qty2)
                        End If
                    End If
                    trh_Cost_Amt = trh_Cost_Amt + Dtl_Cost_Amt

                    '=============================================
                    '  ¾ÔàÈÉ update ¢éÍÁÙÅã¹  TranDataD 

                    'txtSQL = "Update TranDataD "
                    'txtSQL = txtSQL & "Set Dtl_Pr_Cost='" & Dtl_Cost_PR & "' "
                    'txtSQL = txtSQL & "Where dtl_Type='" & dtlType & "' "
                    'txtSQL = txtSQL & "And Dtl_No='" & strDocNo & "' "
                    'txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
                    'dbTools.dbSaveDATA(txtSQL, "")

                    If dtlType = "L" Or dtlType = "H" Then

                        Dtl_Cost_Amt = 0
                        Dtl_Cost_PR = 0
                        Dtl_ProFit = 0
                    End If

                    If Dtl_Cost_Amt = 0 Then
                        chkProfit = False
                    ElseIf (Dtl_Amt > Dtl_Cost_Amt) Then

                        chkProfit = True
                    Else
                        chkProfit = False

                    End If

                    If IsDBNull(.Rows(iRow).Item("Sale1")) Then
                        dtlSaleName1 = ""
                    Else
                        dtlSaleName1 = .Rows(iRow).Item("Sale1")
                    End If

                    If IsDBNull(.Rows(iRow).Item("Sale2")) Then
                        dtlSaleName2 = ""
                    Else
                        dtlSaleName2 = .Rows(iRow).Item("Sale2")
                    End If

                    If chkProDDetl.Checked = True Then

                        ProGrp_Name = .Rows(iRow).Item("ProGrp_Name")
                        Type_Name = .Rows(iRow).Item("Type_Name")
                        Grp_Name = .Rows(iRow).Item("Grp_Name")
                        If IsDBNull(.Rows(iRow).Item("Color_Name")) Then
                            Color_Name = "äÁè¾ºª×èÍ"
                        Else
                            Color_Name = .Rows(iRow).Item("Color_Name")
                        End If

                        Th_Name = .Rows(iRow).Item("Th_Name3")
                        Size_Name = .Rows(iRow).Item("Size_Name")
                        Grade_Name = .Rows(iRow).Item("G_Name")

                    End If

                    If chkLostProF.Checked = True Then  '  àÅ×Í¡à©¾ÒÐ ¢Ò´·Ø¹
                        If Dtl_ProFit <= 0 Then
                            chkSelLostProF = True
                        Else
                            chkSelLostProF = False
                        End If

                    Else                                 '  àÅ×Í¡·Ñé§ËÁ´
                        chkSelLostProF = True
                    End If

                    If chkValueCost.Checked = True Then  ' àÅ×Í¡à©¾ÒÐ  µé¹·Ø¹à»ç¹ 0
                        If Dtl_Cost_Amt <= 0 Then
                            chkSelLostProF = True
                        Else
                            chkSelLostProF = False
                        End If
                    Else                                 '  àÅ×Í¡·Ñé§ËÁ´
                        chkSelLostProF = True
                    End If




                    If chkSelLostProF = True Then
                        '=======================   control  Total label  

                        kgTotal = Q_Qty2 + kgTotal

                        If selDocType = "L" Then
                            lbProfitAmt.Text = 0
                        Else
                            lbProfitAmt.Text = (Format(CDbl(lbProfitAmt.Text) + (Dtl_Amt - Dtl_Cost_Amt), "#,##0.00")).ToString
                        End If
                        userCo = .Rows(iRow).Item("Trh_User").ToString

                        '                        anyData1 = New String() {}

                        If selDocType = "S" Or selDocType = "P" Then
                            '======================================================================

                            anyData = New String() _
                       {strPtype, CStr(rowNo), CStr(Format(date01, "dd/MM/yy")), strDocNo, dtlPoDOC, dtlItem, dtlSaleName1, dtlSaleName2,
                       Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"),
                       Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"),
                       Dtl_Price.ToString("#,##0.00"), strDtlDisc.ToString, strTrhDisc.ToString, Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString("#,##0.00"),
                        stkCode.ToString, ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, strPtype, Profitbit.ToString("#,##0.00")}

                            '======================================================================
                        Else

                            anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlPoDOC, dtlItem, dtlSaleName1, dtlSaleName2,
                                    Dtl_Detail, dtlStkName,
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"),
                                    Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"),
                                 Dtl_Price.ToString("#,##0.00"), strDtlDisc.ToString, strTrhDisc.ToString, Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString("#,##0.00"),
                                 Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"),
                                 ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo, stkCode, strPtype, Profitbit.ToString("#,##0.00")}


                        End If

                        lvi = New ListViewItem(anyData)
                        lsvShow.Items.Add(lvi)
                        If chkRow = False Then
                            chkRow = True
                        Else
                            chkRow = False
                        End If

                        Call colorList(dtlType, strPtype)

                        If chkCondition.Checked = True Then
                            If (IsDBNull(Dtl_ConDition) = False) Then
                                If Len(Dtl_ConDition) > 0 Then
                                    anyData = New String() _
                                      {"", "", "", "", "", "****** condition  --------->", "",
                                        "", "",
                                       Dtl_ConDition, "",
                                       "", "", "",
                                    "", "", "",
                                    "", "",
                                    "", "", "", "", "", "", "", ""}

                                    'lvi = New ListViewItem(anyData)
                                    'lsvShow.Items.Add(lvi)

                                    lvi = New ListViewItem(anyData)

                                    lsvShow.Items.Add(lvi)

                                    Call colorList("", strPtype)
                                    Dtl_ConDition = ""
                                End If
                                'Exit For
                            End If

                        End If

                    End If
                    If selDocType = "L" Then
                        'Dtl_Detail
                        If (IsDBNull(Dtl_Detail) = False) Then
                            If Len(Dtl_Detail) > 0 Then
                                anyData = New String() _
                                  {"", "", "", "", "", "****** condition  --------->", "",
                                    "", "",
                                   Dtl_Detail, "",
                                   "", "", "",
                                "", "", "",
                                "", "",
                                "", "", "", "", "", "", "", ""}

                                'lvi = New ListViewItem(anyData)
                                'lsvShow.Items.Add(lvi)
                                lvi = New ListViewItem(anyData)
                                lsvShow.Items.Add(lvi)

                                Call colorList("", strPtype)
                                Dtl_ConDition = ""
                            End If
                        End If


                    End If



                    txtCost0 = Dtl_Cost_Amt + txtCost0 'µé¹·Ø¹
                    'irow0 = rowNo
                    lbQty1_0 = Q_Rcv + lbQty1_0 ' ¨Ó¹Ç¹á¼è¹
                    Dtl_Amt0 = Dtl_Amt + Dtl_Amt0 ' ÂÍ´¢ÒÂ
                    txtDiscH0 = tmpTrhDisc + txtDiscH0
                    txtDiscItem0 = (tempDisc * Q_Rcv) + txtDiscItem0
                    'lbQty2.Text = Format(kgTotal / 1000, "#,##0.00")

                    'lbString.Text = date01 & "-" & dtlType & "-" & strDocNo
                    lbReCount.Text = RowCount - iRow '& "-" & dtlStkName
                    'indexBar.Refresh()

                    'lvi.SubItems(iRow).Selected = True
                    ' áÊ´§¢éÍÁÙÅ·ÕèÅÐ 10 ºÑ¹·Ñ´
                    'If refCount = 10 Then
                    '    If lsvShow.Items.Count > 0 Then
                    '        lsvShow.EnsureVisible(lsvShow.Items.Count - 1)
                    '        lsvShow.Update()
                    '    End If

                    '    Me.Refresh()
                    '    refCount = 0
                    'End If


                Next


                If lsvShow.Items.Count > 0 Then
                    lsvShow.EnsureVisible(lsvShow.Items.Count - 1)
                    lsvShow.Update()
                End If

                Me.Refresh()

                txtCost.Text = Format(txtCost0, "#,##0.00")  'µé¹·Ø¹
                lbTranQty.Text = Format(rowNo, "#,##0")
                lbQty1.Text = Format(lbQty1_0, "#,##0.00") ' ¨Ó¹Ç¹á¼è¹
                lbAmt.Text = Format(Dtl_Amt0, "#,##0.00") ' ÂÍ´¢ÒÂ
                txtDiscH.Text = Format(txtDiscH0, "#,##0.00")
                txtDiscItem.Text = Format(txtDiscItem0, "#,##0.00")
                lbQty2.Text = Format(kgTotal / 1000, "#,##0.00")
            End If

        End With


    End Sub



    Sub getDetailGrpByStk()
        Dim iRow As Integer = 0

        'Dim anyData1() As String
        Dim anyData() As String

        '   µÑÇá»Ã ·Õèãªéã¹¡ÒÃ¤Ó¹Ç¹ ÃÒÂÅÐàÍÕÂ´

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String
        Dim strPtype As String = ""
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
        lbProfitAmt.Text = Format(0, "#,##0.00")

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
                            'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                            dtlItem = "¢ÒÂÊÔ¹¤éÒ  " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "B" Then
                            'dtlItem = "Order ÊÔ¹¤éÒ¢Í§ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            dtlItem = "Order ÊÔ¹¤éÒ " ' & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "D" Then
                            If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                                dtlItem = "ÃÑº¼ÅÔµà¾×èÍ ******** äÁè¾º¢éÍÁÙÅ ***********"
                            Else

                                dtlItem = "ÃÑº¼ÅÔµà¾×èÍ " '& CStr(.Rows(iRow).Item("Ar_Name")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            End If

                        ElseIf dtlType = "E" Then
                            dtlItem = "ÊÑè§¼ÅÔµ " ' & CStr(.Rows(iRow).Item("Ar_Name")) '
                        ElseIf dtlType = "G" Then
                            dtlItem = "ÃÑºÊÔ¹¤éÒ¨Ò¡¡ÒÃÃÕà¡Ã´."
                        ElseIf dtlType = "F" Then
                            dtlItem = "ÃÑºâÍ¹ÊÔ¹¤éÒ   " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "P" Then
                            dtlItem = "àºÔ¡ÊÔ¹¤éÒà¾×èÍ¢ÒÂ "
                            'If IsDBNull(.Rows(iRow).Item("Ar_Name")) Then
                            '    dtlItem = "àºÔ¡ÊÔ¹¤éÒà¾×èÍ¢ÒÂ "
                            'Else
                            '    dtlItem = "àºÔ¡ÊÔ¹¤éÒà¾×èÍ¢ÒÂ " & CStr(.Rows(iRow).Item("Ar_Name"))
                            'End If

                        ElseIf dtlType = "Z" Then
                            dtlItem = "âÍ¹ÊÔ¹¤éÒÍÍ¡¨Ò¡¤ÅÑ§  " '& CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "A" Then
                            dtlItem = "»ÃÑºÂÍ´¡ÒÃµÃÇ¨¹Ñº " '& "-" & CStr(.Rows(iRow).Item("Ar_Name"))
                        ElseIf dtlType = "Q" Then
                            If IsDBNull(.Rows(iRow).Item("Trh_date")) Then
                                dtlItem = "µÃÇ¨¹ÑºÊÔ¹¤éÒ "
                            Else
                                dtlItem = "µÃÇ¨¹ÑºÊÔ¹¤éÒ " '" ÇÑ¹·Õè " & .Rows(iRow).Item("Trh_date").ToString
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
                        '    Dtl_ProFit = "ÂÑ§äÁèÁÕµé¹·Ø¹"
                        '    chkProfit = False
                        'Else
                        ' =============== µé¹·Ø¹   CS_Type=1   ¤Ô´µé¹·Ø¹µèÍË¹èÇÂ
                        If dbTools.getCostType(stkCode) = 0 Then

                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0)
                            Dtl_Cost_Amt = Dtl_Cost_PR * Q_Qty2
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        ElseIf dbTools.getCostType(stkCode) = 1 Then
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0)
                            Dtl_Cost_Amt = Dtl_Cost_PR * num
                            Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                        Else
                            Dtl_Cost_PR = dbTools.getCostByStk(stkCode, date01, "", 0)
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
                        'If chkDisplStk.Checked = True Then
                        '    If IsDBNull(.Rows(iRow).Item("sumQtyBalQ1")) Then
                        '        Q_Bal_Q1 = 0
                        '    Else
                        '        Q_Bal_Q1 = CInt(.Rows(iRow).Item("sumQtyBalQ1"))
                        '        Q_Bal_F = (Q_Bal_Q1 * CDbl(.Rows(iRow).Item("Stk_Factor2")))

                        '    End If

                        'End If


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
                        lbProfitAmt.Text = CStr(Format(CDbl(lbProfitAmt.Text) + CDbl(Dtl_Amt - Dtl_Cost_Amt), "#,##0.00"))


                        'userCo = .Rows(iRow).Item("Trh_User").ToString

                        '                        anyData1 = New String() {}

                        If CStr(cboDType.SelectedValue) = "S" Or CStr(cboDType.SelectedValue) = "P" Then
                            'If chkDisplStk.Checked = True Then

                            '    anyData = New String() _
                            '         {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                            '         Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                            '         Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                            '         Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                            '         Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                            '         ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}


                            'Else
                            anyData = New String() _
                                {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2,
                                Dtl_Detail, dtlStkName, Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"),
                                Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"),
                                Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString,
                                ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name}

                            'End If

                        Else
                            'If chkDisplStk.Checked = True Then
                            '    anyData = New String() _
                            '            {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2, _
                            '            Dtl_Detail, dtlStkName, _
                            '            Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"), _
                            '            Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"), _
                            '         Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString, _
                            '         Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"), _
                            '         ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}


                            'Else
                            anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlSaleName1, dtlSaleName2,
                                    Dtl_Detail, dtlStkName,
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"),
                                    Dtl_Cost_Amt.ToString("#,##0.00"), Dtl_Cost_PR.ToString("#,##0.00"), Dtl_Pr_Div_Q2.ToString("#,##0.00"),
                                 Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00"), Dtl_ProFit.ToString,
                                 Q_Bal_Q1.ToString("#,##0"), Q_Bal_F.ToString("#,##0.00"),
                                 ProGrp_Name, Type_Name, Grp_Name, Color_Name, Th_Name, Size_Name, Grade_Name, userCo}

                            'End If

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

                        Call colorList(dtlType, strPtype)
                        'Exit For
                    End If

                Next

            End If
        End With

    End Sub

    Sub getItemDetailByStk()
        Dim iRow As Integer = 0


        Dim anyData() As String

        '   µÑÇá»Ã ·Õèãªéã¹¡ÒÃ¤Ó¹Ç¹ ÃÒÂÅÐàÍÕÂ´

        Dim rowNo As Integer = 0
        Dim date01 As Date
        Dim strDocNo As String = ""
        Dim strPtype As String = ""
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
                            strPtype = CStr(.Rows(iRow).Item("Trh_NoType"))
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
                                'dtlItem = "¢ÒÂÊÔ¹¤éÒãËé¡Ñº " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus"))
                                dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "B" Then
                                'dtlItem = "Order ÊÔ¹¤éÒ¢Í§ " & dbTools.findCusName(.Rows(iRow).Item("Trh_Cus")) '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                                dtlItem = CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "D" Then
                                dtlItem = "ÃÑºÊÔ¹¤éÒ¨Ò¡¡ÒÃ¼ÅÔµ" '& (subDS.Tables("rptByItem").Rows(iRow).Item("Dtl_idTrade"))
                            ElseIf dtlType = "G" Then
                                dtlItem = "ÃÑºÊÔ¹¤éÒ¨Ò¡¡ÒÃÃÕà¡Ã´" '
                            ElseIf dtlType = "F" Then
                                dtlItem = "ÃÑºâÍ¹ÊÔ¹¤éÒ" '
                            ElseIf dtlType = "P" Then
                                dtlItem = "àºÔ¡ÊÔ¹¤éÒà¾×èÍ¢ÒÂ " & CStr(.Rows(iRow).Item("Ar_Name"))
                            ElseIf dtlType = "Z" Then
                                dtlItem = "âÍ¹ÊÔ¹¤éÒÍÍ¡ "
                            End If
                        End If
                        lbTranQty.Text = Format(Int(iRow + 1), "#,##0")
                        lbQty1.Text = Format(Q_Rcv + CInt(lbQty1.Text), "#,##0.00")
                        lbQty2.Text = Format(Q_Qty2 + CDbl(lbQty2.Text), "#,##0.00")
                        lbAmt.Text = Format(Dtl_Amt + CDbl(lbAmt.Text), "#,##0.00")
                        If chkOnDetail.Checked = True Then
                            anyData = New String() _
                                    {dtlType, CStr(rowNo), CStr(date01), strDocNo, dtlItem, dtlStkName,
                                    Q_Rcv.ToString("#,##0"), Q_Qty2.ToString("#,##0.00"),
                                    Dtl_Price.ToString("#,##0.00"), Dtl_Amt.ToString("#,##0.00")}
                        ElseIf chkOnDetail.Checked = False Then
                            anyData = New String() _
                                    {dtlType, CStr(rowNo), dtlStkName,
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

                        Call colorList(dtlType, strPtype)
                    End If

                Next

            End If
        End With


    End Sub

    Sub colorList(ByVal iType As String, P_type As String)

        If P_type = "P" Then
            If chkProfit = True Then

                ' lvi.BackColor = System.Drawing.Color.GreenYellow
                lvi.BackColor = System.Drawing.Color.MediumSlateBlue
                lvi.ForeColor = System.Drawing.Color.White

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
        Else


            'If (listType = "QZ") Or (listType = "QC") Then
            If chkRow = True Then
                If (iType = "S") Then

                    If chkProfit = True Then

                        ' lvi.BackColor = System.Drawing.Color.GreenYellow
                        lvi.BackColor = System.Drawing.Color.YellowGreen
                        lvi.ForeColor = System.Drawing.Color.Black
                        If Profitbit <= CDbl(txtProfitBit.Text) Then
                            lvi.BackColor = System.Drawing.Color.DarkViolet
                            lvi.ForeColor = System.Drawing.Color.White
                        End If

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
                        If Profitbit <= CDbl(txtProfitBit.Text) Then
                            lvi.BackColor = System.Drawing.Color.DarkViolet
                            lvi.ForeColor = System.Drawing.Color.White
                        End If
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
                Else
                    lvi.BackColor = System.Drawing.Color.WhiteSmoke
                    lvi.ForeColor = System.Drawing.Color.Blue
                    lvi.UseItemStyleForSubItems = True
                End If
            Else
                If (iType = "") Then
                    lvi.BackColor = System.Drawing.Color.WhiteSmoke
                    lvi.ForeColor = System.Drawing.Color.Blue
                    lvi.UseItemStyleForSubItems = True
                Else
                    If chkProfit = True Then
                        lvi.BackColor = System.Drawing.Color.White
                        lvi.ForeColor = System.Drawing.Color.Black
                        If Profitbit <= CDbl(txtProfitBit.Text) Then
                            lvi.BackColor = System.Drawing.Color.DarkViolet
                            lvi.ForeColor = System.Drawing.Color.White
                        End If
                        lvi.UseItemStyleForSubItems = True
                    ElseIf chkProfit = False Then

                        lvi.BackColor = System.Drawing.Color.OrangeRed
                        lvi.ForeColor = System.Drawing.Color.White
                        lvi.UseItemStyleForSubItems = True

                    End If
                End If

            End If
        End If
        'End If
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
    '        .MappingName = "Command"  '¡ÓË¹´ãËé DatagridTalbleStyle ãªé¡Ñº Table ã´

    '    End With

    '    With colType
    '        .HeaderText = "»ÃÐàÀ·"
    '        .MappingName = "Trh_Type"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 50
    '    End With
    '    With colNo
    '        .HeaderText = "àÅ¢·Õè"
    '        .MappingName = "Trh_No"
    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With
    '    With colDate
    '        .HeaderText = "ÇÑ¹·Õè"
    '        .MappingName = "Trh_Date"
    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With

    '    With colStkName
    '        .HeaderText = "ÃÒÂ¡ÒÃ"
    '        .MappingName = "Stk_Name_1"
    '        ' .ReadOnly = True
    '        .Width = 250
    '    End With


    '    With colQty1
    '        .HeaderText = "¨Ó¹Ç¹á¼è¹"
    '        .MappingName = "Dtl_Num"
    '        .Alignment = HorizontalAlignment.Right

    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With


    '    With colQty2
    '        .HeaderText = "¹éÓË¹Ñ¡"
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
    '    '    .CaptionText = "ÃÒÂ§Ò¹¡ÒÃà¤Å×èÍ¹äËÇÊÔ¹¤éÒ"
    '    '    .FlatMode = True
    '    '    .TableStyles.Add(grdTS)
    '    '    '.Controls.Clear()
    '    'End With

    'End Sub

    Sub genSQLdetailByDoc() '  ===========   ÊÃéÒ§ÃÒÂ§Ò¹ àÍ¡ÊÒÃµèÒ§æ 

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,"
        txtSQL = txtSQL & "Dtl_Condition as Condition,"
        If chkNoGrpBy.Checked = True Then

            '  ÊèÇ¹¢Í§  àÍ¡ÊÒÃ
            txtSQL = txtSQL & "TranDataH.Trh_NoType,"
            txtSQL = txtSQL & "TranDatah.Trh_Date,"
            txtSQL = txtSQL & "TranDataH.Trh_No,TranDataD.Dtl_Con_id,Dtl_Detail,Dtl_Po,TranDataH.Trh_WH,"
            txtSQL = txtSQL & "Trh_Disc,"

            '  ÊèÇ¹¢Í§  ÅÙ¡¤éÒ
            If cboDType.SelectedValue = "P" Then

                txtSQL = txtSQL & "TranDataD.dtl_idCus,TranDataD.Dtl_Cus_Name,Ar_Name,"

            Else
                txtSQL = txtSQL & "TranDataH.Trh_Cus,TranDataD.Dtl_Cus_Name,Ar_Name,"
            End If


            '  ÊèÇ¹¢Í§  ¾¹Ñ¡§Ò¹¢ÒÂ
            txtSQL = txtSQL & "GrpSales.Grps_id,GrpSales.Grps_Name,Ar_sales,SalesMan1.Sl_Name as sale1,"
            txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
            txtSQL = txtSQL & ""

            '  ÊèÇ¹¢Í§  ÃÒÂ¡ÒÃÊÔ¹¤éÒ
            txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,BaseMast.Stk_Factor2,"
            txtSQL = txtSQL & "TranDataD.Dtl_Num,TranDataD.Dtl_Num_2,"
            txtSQL = txtSQL & "TranDataD.Dtl_Price,Dtl_T_Disc,TranDataD.Dtl_Sum,Dtl_Same_Code,Dtl_Detail,"

            '  ÊèÇ¹¢Í§  µé¹·Ø¹
            'txtSQL = txtSQL & "CostMast.CS_Cost,CostMast.CS_Type, "
            txtSQL = txtSQL & "TranDataH.Trh_user "

        ElseIf chkGrpByStk.Checked = True Then

            ''  ÊèÇ¹¢Í§  àÍ¡ÊÒÃ
            'txtSQL = txtSQL & "TranDataH.Trh_NoType,"
            'txtSQL = txtSQL & "TranDatah.Trh_Date,"
            'txtSQL = txtSQL & "TranDataH.Trh_No,TranDataD.Dtl_Con_id,Dtl_Detail,"

            ''  ÊèÇ¹¢Í§  ÅÙ¡¤éÒ
            'txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"

            ''  ÊèÇ¹¢Í§  ¾¹Ñ¡§Ò¹¢ÒÂ
            'txtSQL = txtSQL & "GrpSales.Grps_id,Grps_Name,Ar_sales,SalesMan1.Sl_Name as sale1,"
            'txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
            'txtSQL = txtSQL & ""

            '  ÊèÇ¹¢Í§  ÃÒÂ¡ÒÃÊÔ¹¤éÒ
            txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,BaseMast.Stk_Factor2,"
            txtSQL = txtSQL & "Dtl_Same_Code,"

            '  ÊèÇ¹¢Í§  µé¹·Ø¹
            'txtSQL = txtSQL & "CostMast.CS_Cost,CostMast.CS_Type, "
            txtSQL = txtSQL & ""

            '  ÊèÇ¹¢Í§  Sum Grp

            txtSQL = txtSQL & "sum(TranDataD.Dtl_Price * Dtl_Num)as Dtlsum,sum(TranDataD.Dtl_Num)as Dtl_Num "

        End If


        'If chkProDDetl.Checked = True Then



        'End If

        'If chkDisplStk.Checked = True Then
        '    If chkNoGrpBy.Checked = True Then
        '        txtSQL = txtSQL & ",tbstock.sumQtybalQ1 "
        '    Else
        '        txtSQL = txtSQL & ",SUM(tbStock.dtl_bal_q1)AS sumQtybalQ1 "
        '    End If

        'End If

        txtSQL = txtSQL & "FROM TranDataD Left JOIN TranDataH "
        txtSQL = txtSQL & "ON TranDataH.Trh_Type = TranDataD.Dtl_type "
        txtSQL = txtSQL & "AND TranDataH.Trh_No = TranDataD.Dtl_no "

        txtSQL = txtSQL & "left join SalesMan as SalesMan1 "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman1.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan1.Sl_Grp=GrpSales.Grps_ID "   '   Left Join  ¡Ñº  SaleMan1 ·Õè Join ¡Ñº ËÑÇºÔÅ (TranDataH.Trh_Sale )

        txtSQL = txtSQL & "left join Basemast "
        txtSQL = txtSQL & "on TranDataD.Dtl_idTrade=Basemast.Stk_Code "

        txtSQL = txtSQL & "left join Arfile "
        If cboDType.SelectedValue = "P" Then
            txtSQL = txtSQL & "on TranDataD.dtl_idCus=ArFile.Ar_Cus_id "
        Else
            txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "
        End If

        txtSQL = txtSQL & "left join SalesMan as SalesMan2 "
        txtSQL = txtSQL & "On ArFile.Ar_Sales=Salesman2.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales as GrpSales2 "
        txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales2.Grps_ID "   '   Left Join  ¡Ñº  SaleMan1 ·Õè Join ¡Ñº ËÑÇºÔÅ (TranDataH.Trh_Sale )

        '======   Table µé¹·Ø¹ÊÔ¹¤éÒ


        If (optSpec.Checked = True) Or (chkProDDetl.Checked = True) Then



        End If
        If chkWH.Checked = True Then
            txtSQL = txtSQL & "Left Join Warehouse "
            txtSQL = txtSQL & "On Trh_wh=Wh_ID "
        End If

        'If chkDisplStk.Checked = True Then
        '    txtSQL = txtSQL & "left join "
        '    txtSQL = txtSQL & "( "

        '    txtSQL = txtSQL & "Select dtl_code"
        '    If chkNoGrpBy.Checked = True Then
        '        txtSQL = txtSQL & ",SUM(dtl_bal_q1)AS sumQtybalQ1 "
        '    Else
        '        txtSQL = txtSQL & ",dtl_bal_Q1 "

        '    End If
        '    txtSQL = txtSQL & " "

        '    txtSQL = txtSQL & "From stkDetl "
        '    txtSQL = txtSQL & "Where "
        '    txtSQL = txtSQL & "not(Dtl_Store='110603') " ' 110603 á»ÃÃÙ»
        '    txtSQL = txtSQL & "And not(Dtl_Store='111660') " ' 111660 µÑ´ªÓÃØ´ 
        '    txtSQL = txtSQL & "And not(Dtl_Store='112054') " ' 112054 ¤ÅÑ§»ÃÑºÊµêÍ¡   
        '    If chkNoGrpBy.Checked = True Then

        '        txtSQL = txtSQL & "  group by dtl_code "
        '    Else
        '        txtSQL = txtSQL & ""
        '    End If
        '    txtSQL = txtSQL & ")tbStock "

        '    txtSQL = txtSQL & "On dtl_idTrade=dtl_code "

        'End If

        '=========##################==========   ÊèÇ¹¢Í§    Where ===============================$$$$$$$$$$$$$$$=========


        txtSQL = txtSQL & "where "

        txtSQL = txtSQL & "(Trh_Type='" & CStr(cboDType.SelectedValue) & "' "
        If chkSalesYT.Checked = True Then
            txtSQL = txtSQL & "And not(GrpSales.Grps_ID='G09') "
            'Else

        End If

        If chkValueSum.Checked = True Then  ' àªç¤ÇèÒÁÕÁÙÅ¤èÒ¢ÒÂãËéáÊ´§

            If cboNoTypeDoc.SelectedValue = "X" Then
            ElseIf cboNoTypeDoc.SelectedValue = "C" Then

            Else
                txtSQL = txtSQL & "And TranDataD.Dtl_Sum > 0 "
            End If

        End If

        If chkNoGMB.Checked = True Then
            txtSQL = txtSQL & "And not(Stk_Prod='04') "
        End If


        'If chkBeForSales.Checked = True Then
        '    'MsgBox("SL03")
        '    txtSQL = txtSQL & "And (  TranDataH.Trh_NoType='B' or TranDataH.Trh_NoType='M' ) )"
        'Else
        '    txtSQL = txtSQL & "And not(  TranDataH.Trh_NoType='B' or TranDataH.Trh_NoType='M' )) "
        'End If

        If chkTypeVat.Checked = True Then
            If cboNoTypeDoc.SelectedValue = "" Then

            Else
                If optNoSelNoType.Checked = True Then
                    txtSQL = txtSQL & "And Not"

                Else
                    txtSQL = txtSQL & "And  "

                End If

                If cboNoTypeDoc.SelectedValue = "M & B" Then
                    MsgBox("M & B  à©¾ÒÐà»Ô´ºÔÅ¢ÒÂ¡èÍ¹")
                    txtSQL = txtSQL & "( Trh_NoType='M' "
                    txtSQL = txtSQL & "or Trh_NoType='B' ) "
                ElseIf cboNoTypeDoc.SelectedValue = "V & N" Then
                    MsgBox("V & N")
                    txtSQL = txtSQL & "( Trh_NoType='V' "
                    txtSQL = txtSQL & "or Trh_NoType='N' ) "

                ElseIf cboNoTypeDoc.SelectedValue = "P & V & B" Then
                    MsgBox("P & V & B")
                    txtSQL = txtSQL & "( Trh_NoType='P' "
                    txtSQL = txtSQL & "or Trh_NoType='V'"
                    txtSQL = txtSQL & "or Trh_NoType='B' ) "

                ElseIf cboNoTypeDoc.SelectedValue = "V & B & M & N" Then
                    MsgBox("V & B & M & N & Y & Z")
                    txtSQL = txtSQL & "( Trh_NoType='V' "
                    txtSQL = txtSQL & "or Trh_NoType='B'"
                    txtSQL = txtSQL & "or Trh_NoType='Y'"

                    txtSQL = txtSQL & "or Trh_NoType='Z'"
                    txtSQL = txtSQL & "or Trh_NoType='M'"
                    txtSQL = txtSQL & "or Trh_NoType='N' ) "
                ElseIf cboNoTypeDoc.SelectedValue = "Y & Z" Then
                    MsgBox("Y & Z")
                    txtSQL = txtSQL & "( Trh_NoType='Y' "
                    txtSQL = txtSQL & "or Trh_NoType='Z')"


                ElseIf cboNoTypeDoc.SelectedValue = "X" Then
                    MsgBox("X à»Ô´µÑ´ÊµêÍ¡ à»Ô´ºÔÅ¢ÒÂ¡èÍ¹ ")
                    txtSQL = txtSQL & "( Trh_NoType='X' )"


                Else
                    txtSQL = txtSQL & " Trh_NoType='" & cboNoTypeDoc.SelectedValue & "' "

                End If

            End If

        Else



        End If
        'txtSQL = Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value)
        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        'txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        'txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "
        txtSQL = txtSQL & ")"
        ' ======================   à¾ÔèÁàµÔèÁá¡éä¢ÃÒ¤Ò·Ø¹«éÓ¡Ñ¹ªªªªªªªªªªªªª
        '        txtSQL = txtSQL & ""

        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If
        '=============== If 

        If (chkOptSale.Checked = True) Then   '   àÅ×Í¡ÃÒÂ§Ò¹ Sale ËÑÇºÔÅ

            txtSQL = txtSQL & "And "
            If chkNotSale.Checked = True Then
                txtSQL = txtSQL & "Not"
            Else
                txtSQL = txtSQL & " "
            End If

            If selGrpSale = "G99" Then
                txtSQL = txtSQL & "((GrpSales.Grps_ID like('%%'))) "
            Else

                txtSQL = txtSQL & "((GrpSales.Grps_ID like('%" & cboGrpSL.SelectedValue & "%')) "
                If cboSale.Text = "*" Then
                    txtSQL = txtSQL & "and (TranDataH.Trh_Sale like('%%'))) "
                Else
                    txtSQL = txtSQL & "and (TranDataH.Trh_Sale like('%" & cboSale.SelectedValue & "%'))) "

                End If

                'End If
            End If

        End If


        If chkOptSale2.Checked = True Then   '   àÅ×Í¡ÃÒÂ§Ò¹ Sale µÒÁ»ÃÐÇÑµÔÅÙ¡¤éÒ

            txtSQL = txtSQL & "And "
            If chkNotSale2.Checked = True Then
                txtSQL = txtSQL & "Not"
            Else
                txtSQL = txtSQL & " "
            End If

            If selGrpSale2 = "G99" Then
                txtSQL = txtSQL & "((GrpSales2.Grps_ID like('%%'))) "
            Else

                txtSQL = txtSQL & "((GrpSales2.Grps_ID like('%" & cboGrpSL2.SelectedValue & "%')) "
                If cboSale.Text = "*" Then
                    txtSQL = txtSQL & "and (ArFile.Ar_Sales like('%%'))) "
                Else
                    txtSQL = txtSQL & "and (ArFile.Ar_Sales like('%" & cboSale2.SelectedValue & "%'))) "
                End If

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

        '==============   àÅ×Í¡ Factor   =======================================

        If optSpec.Checked = True Then


            txtTSQL.Text = "µéÍ§¡ÒÃàÅ×Í¡¢éÍÁÙÅ "
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
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "áÅÐ à»ç¹ " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & "ËÃ×Í " '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ à»ç¹ " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "02" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Grp_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "07" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "07") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""

                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "

                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ "
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
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í à»ç¹ ¡ÅØèÁ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "02" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ à»ç¹ ¡ÅØèÁ  "
                    End If
                    txtSQL = txtSQL & "(BaseMast.Grp_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor33.Text '& Chr(13) & Chr(10) 

                ElseIf cboFactor3.SelectedValue.ToString = "07" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "07") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ à»ç¹ ¡ÅØèÁ  "
                    End If
                    txtSQL = txtSQL & "(BaseMast.G_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor33.Text '& Chr(13) & Chr(10) 

                End If
            End If

            '==========================================================================
            If chkF4.Checked = True Then
                lbFactor4.Text = cboFactor4.SelectedValue.ToString
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
                    '================================================  µÑÇà§×Í¹ä¢àÅ×Í¡   ´éÒ¹º¹à»ç¹á¤è  OR And 

                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor44.SelectedValue.ToString & "') "


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
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor44.SelectedValue.ToString & "') "


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
                End If
            End If
            txtSQL = txtSQL & ") "
        End If

        'End If

        '====================   Session  Group by
        If chkNoGrpBy.Checked = True Then
            txtSQL = txtSQL & ""
            txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No,TranDataD.Dtl_idTrade "
        ElseIf chkGrpByStk.Checked = True Then

            txtSQL = txtSQL & "Group by trandataH.Trh_Type,TranDataD.Dtl_idTrade,Basemast.Stk_Name_1, "
            txtSQL = txtSQL & "BaseMast.Stk_Factor,BaseMast.Stk_Factor2, "
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

    Sub genSQLdetailByDoc2() '  ===========   ÊÃéÒ§ÃÒÂ§Ò¹ àÍ¡ÊÒÃµèÒ§æ 

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,"

        '  ÊèÇ¹¢Í§  àÍ¡ÊÒÃ
        txtSQL = txtSQL & "TranDataH.Trh_NoType,"
        txtSQL = txtSQL & "TranDatah.Trh_Date,"
        txtSQL = txtSQL & "TranDataH.Trh_No,TranDataH.Trh_WH,"


        '  ÊèÇ¹¢Í§  ¾¹Ñ¡§Ò¹¢ÒÂ
        txtSQL = txtSQL & "GrpSales.Grps_id,GrpSales.Grps_Name,Ar_sales,SalesMan1.Sl_Name as sale1,"
        txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
        txtSQL = txtSQL & ""

        txtSQL = txtSQL & "TranDataH.Trh_user "

        txtSQL = txtSQL & "FROM TranDataH "

        txtSQL = txtSQL & "left join SalesMan as SalesMan1 "
        txtSQL = txtSQL & "On TranDatah.Trh_Sale=Salesman1.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales  "
        txtSQL = txtSQL & "on SalesMan1.Sl_Grp=GrpSales.Grps_ID "   '   Left Join  ¡Ñº  SaleMan1 ·Õè Join ¡Ñº ËÑÇºÔÅ (TranDataH.Trh_Sale )

        txtSQL = txtSQL & "left join Arfile "
        txtSQL = txtSQL & "on TranDataH.Trh_Cus=ArFile.Ar_Cus_id "

        txtSQL = txtSQL & "left join SalesMan as SalesMan2 "
        txtSQL = txtSQL & "On ArFile.Ar_Sales=Salesman2.Sl_Id "
        txtSQL = txtSQL & "left join GrpSales as GrpSales2 "
        txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales2.Grps_ID "   '   Left Join  ¡Ñº  SaleMan1 ·Õè Join ¡Ñº ËÑÇºÔÅ (TranDataH.Trh_Sale )

        '======   Table µé¹·Ø¹ÊÔ¹¤éÒ


        If (optSpec.Checked = True) Or (chkProDDetl.Checked = True) Then



        End If
        If chkWH.Checked = True Then
            txtSQL = txtSQL & "Left Join Warehouse "
            txtSQL = txtSQL & "On Trh_wh=Wh_ID "
        End If




        '=========##################==========   ÊèÇ¹¢Í§    Where ===============================$$$$$$$$$$$$$$$=========


        txtSQL = txtSQL & "where "
        txtSQL = txtSQL & "Trh_Type='" & CStr(cboDType.SelectedValue) & "' "
        If chkTypeVat.Checked = True Then
            If cboNoTypeDoc.SelectedValue = "" Then
            Else
                txtSQL = txtSQL & "And Trh_NoType='" & cboNoTypeDoc.SelectedValue & "' "
            End If

        Else

        End If

        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        'txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        'txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        ' ======================   à¾ÔèÁàµÔèÁá¡éä¢ÃÒ¤Ò·Ø¹«éÓ¡Ñ¹ªªªªªªªªªªªªª
        '        txtSQL = txtSQL & ""

        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If
        '=============== If 

        If (chkOptSale.Checked = True) Then   '   àÅ×Í¡ÃÒÂ§Ò¹ Sale ËÑÇºÔÅ

            txtSQL = txtSQL & "And "
            If chkNotSale.Checked = True Then
                txtSQL = txtSQL & "Not"
            Else
                txtSQL = txtSQL & " "
            End If

            If selGrpSale = "G99" Then
                txtSQL = txtSQL & "((GrpSales.Grps_ID like('%%'))) "
            Else

                txtSQL = txtSQL & "((GrpSales.Grps_ID like('%" & cboGrpSL.SelectedValue & "%')) "
                If cboSale.Text = "*" Then
                    txtSQL = txtSQL & "and (TranDataH.Trh_Sale like('%%'))) "
                Else
                    txtSQL = txtSQL & "and (TranDataH.Trh_Sale like('%" & cboSale.SelectedValue & "%'))) "
                End If

                'End If
            End If

        End If


        If chkOptSale2.Checked = True Then   '   àÅ×Í¡ÃÒÂ§Ò¹ Sale µÒÁ»ÃÐÇÑµÔÅÙ¡¤éÒ

            txtSQL = txtSQL & "And "
            If chkNotSale2.Checked = True Then
                txtSQL = txtSQL & "Not"
            Else
                txtSQL = txtSQL & " "
            End If

            If selGrpSale2 = "G99" Then
                txtSQL = txtSQL & "((GrpSales2.Grps_ID like('%%'))) "
            Else

                txtSQL = txtSQL & "((GrpSales2.Grps_ID like('%" & cboGrpSL2.SelectedValue & "%')) "
                If cboSale.Text = "*" Then
                    txtSQL = txtSQL & "and (ArFile.Ar_Sales like('%%'))) "
                Else
                    txtSQL = txtSQL & "and (ArFile.Ar_Sales like('%" & cboSale2.SelectedValue & "%'))) "
                End If

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



        '==============   àÅ×Í¡ Factor   =======================================



        'End If

        '====================   Session  Group by
        If chkNoGrpBy.Checked = True Then
            txtSQL = txtSQL & ""
            txtSQL = txtSQL & "Order by TranDataH.Trh_Date,TranDataH.Trh_No "
        ElseIf chkGrpByStk.Checked = True Then

            txtSQL = txtSQL & "Group by trandataH.Trh_Type,TranDataD.Dtl_idTrade,Basemast.Stk_Name_1, "
            txtSQL = txtSQL & "BaseMast.Stk_Factor,BaseMast.Stk_Factor2, "
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



    Sub genSQLdetlByPenOr()   '  ===========   ÊÃéÒ§ÃÒÂ§Ò¹ Pending Order 

        txtSQL = "SELECT  "
        txtSQL = txtSQL & "TranDataH.Trh_Type,TranDataH.Trh_NoType,Trh_Disc,"
        txtSQL = txtSQL & "TranDatah.Trh_Date, TranDataH.Trh_No,TranDataD.Dtl_Po,TranDataH.trh_wh,"
        txtSQL = txtSQL & "TranDataH.Trh_Cus,Ar_Name,"
        txtSQL = txtSQL & "Ar_sales,SalesMan1.Sl_Name as sale1,"
        txtSQL = txtSQL & "TranDataH.Trh_Sale,SalesMan2.Sl_Name as sale2,"
        txtSQL = txtSQL & "Dtl_Detail,Dtl_T_Disc,GrpSales.Grps_id,Grps_Name,"
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,TranDataD.Dtl_Price,Basemast.Stk_Name_1,BaseMast.Stk_Factor2,"
        txtSQL = txtSQL & "(TranDataD.Dtl_Num-TranDataD.Dtl_Num_2)as Dtl_Num,"
        txtSQL = txtSQL & "TranDataD.Dtl_Num_2,"
        txtSQL = txtSQL & "TranDataD.Dtl_Price,TranDataD.Dtl_Sum,TranDataD.Dtl_Con_id,Dtl_Same_Code,"
        txtSQL = txtSQL & "TranDataH.Trh_user,Dtl_Po,TranDataD.Dtl_Condition as condition "
        'txtSQL = txtSQL & ",CostMast.CS_Cost,CostMast.CS_Type "

        'If chkDisplStk.Checked = True Then
        '    txtSQL = txtSQL & ",tbStock.sumQtybalQ1 "
        'End If

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
            'txtSQL = txtSQL & "Left Join ProGrpMast "
            'txtSQL = txtSQL & "On BaseMast.Stk_Prod=ProGrpMast.ProGrp_ID "


            'txtSQL = txtSQL & "Left Join TypeMast "
            'txtSQL = txtSQL & "On BaseMast.Type_Code=TypeMast.Type_Code "

            'txtSQL = txtSQL & "Left Join GrpMast "
            'txtSQL = txtSQL & "On BaseMast.Grp_Code=GrpMast.Grp_Code "

            'txtSQL = txtSQL & "Left Join ColorMast "
            'txtSQL = txtSQL & "On (BaseMast.Color_Code=ColorMast.Color_Code "
            'txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type )"

            'txtSQL = txtSQL & "Left Join ThMast "
            'txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        End If

        'txtSQL = txtSQL & "Left Join CostMast "
        'txtSQL = txtSQL & "On BaseMast.Stk_Code=CostMast.CS_Stk_Code "

        'If chkDisplStk.Checked = True Then
        '    txtSQL = txtSQL & "left join "
        '    txtSQL = txtSQL & "( Select dtl_code,"
        '    txtSQL = txtSQL & "sum(dtl_bal_Q1)as sumQtybalQ1 "
        '    txtSQL = txtSQL & "From stkDetl "
        '    txtSQL = txtSQL & "group by dtl_code "
        '    txtSQL = txtSQL & ")tbStock "
        '    txtSQL = txtSQL & "On dtl_idTrade=dtl_code "
        'End If

        '==========================  Where  =========================

        txtSQL = txtSQL & "where "
        txtSQL = txtSQL & "Trh_Type='B' "
        txtSQL = txtSQL & "And Dtl_Off=0 "
        txtSQL = txtSQL & "And ((TranDataD.Dtl_Num-TranDataD.Dtl_Num_2)>0) "
        'txtSQL = txtSQL & "And ((TranDataD.Dtl_Num-TranDataD.Dtl_Num_4)>0) "
        'txtSQL = txtSQL & "And ((TranDataD.Dtl_Num_2)>0) "
        If chkDate.Checked = True Then

            txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

            'txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
            'txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        Else

        End If


        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If


        If chkOptSale.Checked = True Then
            If Len(cboSale.SelectedValue) > 0 And (chkSelSale.Checked = True) Then

                txtSQL = txtSQL & "And ArFile.Ar_Sales='" & Trim(cboSale.SelectedValue) & "' "

            ElseIf Len(cboSale.SelectedValue) > 0 And (chkNotSale.Checked = True) Then

                txtSQL = txtSQL & "And ( ArFile.Ar_Sales <>'" & Trim(cboSale.SelectedValue) & "') "

            End If
        End If

        If chkOptSale2.Checked = True Then
            If Len(lbSelSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then

                txtSQL = txtSQL & "And  ArFile.Ar_Sales ='" & Trim(cboSale2.SelectedValue) & "' "

            ElseIf Len(lbSelSaleID2.Text) > 0 And (chkNotSale2.Checked = True) Then

                txtSQL = txtSQL & "And ( ArFile.Ar_Sales <>'" & Trim(cboSale2.SelectedValue) & "') "

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

        If chkTypeVat.Checked = True Then
            If cboNoTypeDoc.SelectedValue = "" Then

            Else
                If optNoSelNoType.Checked = True Then
                    txtSQL = txtSQL & "And Not"

                Else
                    txtSQL = txtSQL & "And  "

                End If

                If cboNoTypeDoc.SelectedValue = "M & B" Then
                    MsgBox("M & B  à©¾ÒÐà»Ô´ºÔÅ¢ÒÂ¡èÍ¹")
                    txtSQL = txtSQL & "( Trh_NoType='M' "
                    txtSQL = txtSQL & "or Trh_NoType='B' ) "
                ElseIf cboNoTypeDoc.SelectedValue = "V & N" Then
                    MsgBox("V & N")
                    txtSQL = txtSQL & "( Trh_NoType='V' "
                    txtSQL = txtSQL & "or Trh_NoType='N' ) "

                ElseIf cboNoTypeDoc.SelectedValue = "P & V & B" Then
                    MsgBox("P & V & B")
                    txtSQL = txtSQL & "( Trh_NoType='P' "
                    txtSQL = txtSQL & "or Trh_NoType='V'"
                    txtSQL = txtSQL & "or Trh_NoType='B' ) "

                ElseIf cboNoTypeDoc.SelectedValue = "V & B & M & N" Then
                    MsgBox("V & B & M & N")
                    txtSQL = txtSQL & "( Trh_NoType='V' "
                    txtSQL = txtSQL & "or Trh_NoType='B'"
                    txtSQL = txtSQL & "or Trh_NoType='M'"
                    txtSQL = txtSQL & "or Trh_NoType='N' ) "

                ElseIf cboNoTypeDoc.SelectedValue = "X" Then
                    MsgBox("X เอกสารบิลขายก่อน ")
                    txtSQL = txtSQL & "( Trh_NoType='X' )"


                Else
                    txtSQL = txtSQL & " Trh_NoType='" & cboNoTypeDoc.SelectedValue & "' "

                End If

            End If

        Else



        End If

        '==============   àÅ×Í¡ Factor   =======================================

        If optSpec.Checked = True Then
            txtTSQL.Text = "µéÍ§¡ÒÃàÅ×Í¡¢éÍÁÙÅ "
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
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "áÅÐ à»ç¹ " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & "ËÃ×Í " '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ à»ç¹ " & cboFactor2.Text
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)

                ElseIf cboFactor2.SelectedValue.ToString = "02" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf chkF1.Checked = False Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Grp_Code='" & cboFactor22.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor22.Text '& Chr(13) & Chr(10) & Chr(13) & Chr(10)
                End If

            End If

            If chkF3.Checked = True Then

                If cboFactor3.SelectedValue.ToString = "00" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í à»ç¹ ¡ÅØèÁ "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "00") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Stk_Prod='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "01") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ "
                    End If
                    txtSQL = txtSQL & " (BaseMast.Type_Code='" & cboFactor33.SelectedValue.ToString & "') "
                    txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & " " & cboFactor33.Text

                ElseIf cboFactor3.SelectedValue.ToString = "02" Then

                    If (chkF1.Checked = True And cboFactor1.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or"
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    ElseIf (chkF1.Checked = False And chkF2.Checked = False) Then
                        txtSQL = txtSQL & ""
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "- "
                    ElseIf (chkF2.Checked = True And cboFactor2.SelectedValue.ToString = "02") Then
                        txtSQL = txtSQL & "Or "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "ËÃ×Í "
                    Else
                        txtSQL = txtSQL & "And "
                        txtTSQL.Text = txtTSQL.Text & Chr(13) & Chr(10) & "áÅÐ à»ç¹ ¡ÅØèÁ  "
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
        txtSQL = txtSQL & "Dtl_Detail,"
        'txtSQL = txtSQL & "GrpSales.Grps_id,Grps_Name,"
        txtSQL = txtSQL & "TranDataD.Dtl_idTrade,Basemast.Stk_Name_1,BaseMast.Stk_Factor,"
        txtSQL = txtSQL & "TranDataD.Dtl_Num,TranDataD.Dtl_Num_2,"
        txtSQL = txtSQL & "TranDataD.Dtl_Price,TranDataD.Dtl_Con_id,Dtl_Same_Code "
        'If chkDisplStk.Checked = True Then
        '    txtSQL = txtSQL & ",tbStock.sumQtybalQ1 "
        'End If

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

        'txtSQL = txtSQL & "left join GrpSales  "
        'txtSQL = txtSQL & "on SalesMan2.Sl_Grp=GrpSales.Grps_ID "

        'If chkDisplStk.Checked = True Then
        '    txtSQL = txtSQL & "left join "
        '    txtSQL = txtSQL & "( Select dtl_code,"
        '    txtSQL = txtSQL & "sum(dtl_bal_Q1)as sumQtybalQ1 "
        '    txtSQL = txtSQL & "From stkDetl "
        '    txtSQL = txtSQL & "group by dtl_code "
        '    txtSQL = txtSQL & ")tbStock "
        '    txtSQL = txtSQL & "On dtl_idTrade=dtl_code "
        'End If

        txtSQL = txtSQL & "where Trh_Type='" & CStr(cboDType.SelectedValue) & "' "
        txtSQL = txtSQL & "And Trh_Date >= '" & Year(lbDate01.Value) - 543 & "/" & Month(lbDate01.Value) & "/" & Microsoft.VisualBasic.Day(lbDate01.Value) & "' "
        txtSQL = txtSQL & "And Trh_Date <= '" & Year(lbDate02.Value) - 543 & "/" & Month(lbDate02.Value) & "/" & Microsoft.VisualBasic.Day(lbDate02.Value) & "' "

        'txtSQL = txtSQL & "And Trh_Date >= '" & Format(DateAdd(DateInterval.Year, -543, lbDate01.Value), "yyyy/MM/dd") & "' "
        'txtSQL = txtSQL & "And Trh_Date <= '" & Format(DateAdd(DateInterval.Year, -543, lbDate02.Value), "yyyy/MM/dd") & "' "

        If Len(lbCusID.Text) > 0 And (chkSelCustom.Checked = True) Then
            txtSQL = txtSQL & "And Trh_Cus='" & lbCusID.Text & "' "

        End If
        If chkDocNo.Checked = True Then

            txtSQL = txtSQL & "And Trh_No like '%" & Trim(txtSelectNo.Text) & "%' "

        Else

        End If

        If chkOptSale.Checked = True Then
            If Len(cboSale.SelectedValue) > 0 And (chkSelSale.Checked = True) Then

                txtSQL = txtSQL & "And Trh_Sale='" & Trim(cboSale.SelectedValue) & "' "

            ElseIf Len(cboSale.SelectedValue) > 0 And (chkNotSale.Checked = True) Then

                txtSQL = txtSQL & "And (Trh_Sale<>'" & Trim(cboSale.SelectedValue) & "') "

            End If
        End If

        If chkOptSale2.Checked = True Then
            If Len(lbSelSaleID2.Text) > 0 And (chkSelSale2.Checked = True) Then

                txtSQL = txtSQL & "And Ar_Sales='" & Trim(lbSelSaleID2.Text) & "' "

            ElseIf Len(lbSelSaleID2.Text) > 0 And (chkNotSale2.Checked = True) Then

                txtSQL = txtSQL & "And (Ar_Sales<>'" & Trim(lbSelSaleID2.Text) & "') "

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
        If Len(selStkID) > 0 Then
            optStk.Checked = True
            lbStkName.Text = dbTools.getStkName(selStkID)
        End If


    End Sub

    Private Sub lbDate01_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDate01.ValueChanged
        lbDate02.Value = lbDate01.Value
    End Sub

    Sub prnReport()

        Dim StkCode As String
        Dim trhDate As Date
        Dim tmpTrhNo As String = ""

        Dim strTrhDisc As String = 0
        Dim strDisc As String = 0

        Dim tempDisc As Double = 0
        Dim tempTrhDisc As Double = 0
        Dim tempPrice As Double = 0
        Dim tempTotal As Double = 0
        Dim tempQty As Double = 0
        Dim getCostType0 As String

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim oRng As Microsoft.Office.Interop.Excel.Range

        Dim rw As Integer
        'Dim countRow As Integer
        'Dim countRow2 As Integer

        Dim rowExcel As Integer = 9 '  àÃÔèÁ ÃÒÂ¡ÒÃºÃÃ·Ñ´·Õè 9
        Dim bufferExcel As Integer = 0 ' ãªéã¹¡Ã³Õ¢Öé¹ sheet ãËÁè áÅÐ ãËé buffer ¤èÒµèÍ¨Ò¡ sheet à´ÔÁ à¾×èÍ¹ÑºµèÍ
        Dim sheetCount As Integer = 1
        Dim exRow As Integer = 0
        'Dim dtlType As String = ""

        ' Dim stkName2 As String
        'dtlType = cboDType.SelectedValue.ToString

        'fileName = CurDir() & "\report\rptStk02.xls"
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
            .Range("E2").Value = "รายงาน--" & dbTools.getDocType(subDS.Tables("Command").Rows(0).Item("Trh_Type")) & "--"
            .Range("M2").Value = Now
            '.ActiveCell.Value = dbTools.getDocType(CStr(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Type")))

            '.Range("B9:U9").Select()
            '.Copy()
            '.Range("B" & (rowExcel + 1) & ":" & "U" & (rowExcel + 1)).Copy() '  àÅ×Í¡ºÃÃ·Ñ´à¾×èÍá·Ã¡                      

            For countRow = 0 To rw

                strDisc = 0
                strTrhDisc = "0"
                tempTrhDisc = 0
                tempDisc = 0
                tempQty = 0
                tempPrice = 0
                tempTotal = 0

                '            '  ============  à¾ÔèÁºÃÃ·Ñ´
                .Range("A" & (rowExcel + 2) & ":" & "AD" & (rowExcel + 2)).Insert()
                If exRow = 0 Then
                    .Range("A" & (rowExcel + 2) & ":" & "AD" & (rowExcel + 2)).Interior.ColorIndex = 6
                    exRow = 1
                Else
                    .Range("A" & (rowExcel + 2) & ":" & "AD" & (rowExcel + 2)).Interior.ColorIndex = 0
                    exRow = 0
                End If
                '            '  ============  à¾ÔèÁºÃÃ·Ñ´
                .Range("B" & rowExcel).Select()
                .Range("B" & rowExcel).Value = countRow + 1
                .Range("C" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")
                '.ActiveCell.Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date")

                .Range("D" & rowExcel).Value() = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No")
                tmpTrhNo = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No")

                'MsgBox("no" & subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No"))
                '.ActiveCell.Value = 

                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")) Then

                    .Range("E" & rowExcel).Value() = "äÁè¾º¢éÍÁÙÅ"
                    '    .ActiveCell.Value

                Else
                    .Range("E" & rowExcel).Value() = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Ar_Name")
                    '    .ActiveCell.Value 

                End If

                StkCode = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("dtl_idTrade").ToString
                getCostType0 = dbTools.getCostType(StkCode)

                trhDate = CDate(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Date"))

                .Range("G" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale1")

                .Range("F" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Sale2")

                .Range("i" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Name_1")
                '.ActiveCell
                .Range("L" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")
                tempQty = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")
                '.ActiveCell
                '.Select()

                'If tempPrice = 0 Then
                '    .Range("M" & rowExcel).Value = 0
                'Else
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
                    .Range("M" & rowExcel).Value = 0
                Else
                    .Range("M" & rowExcel).Value = CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) * CDbl(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2"))
                End If

                'End If


                '.Range("N" & rowExcel).Select()
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Stk_Factor2")) Or IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num")) Then
                    .Range("N" & rowExcel).Value = 0
                Else


                    If getCostType0 = 0 Then
                        .Range("N" & rowExcel).Value = CDbl(dbTools.getCostByStk(StkCode, trhDate, "", 0))
                    ElseIf getCostType0 = 1 Then
                        .Range("N" & rowExcel).Value = CDbl(dbTools.getCostByStk(StkCode, trhDate, "", 0))
                    Else
                        .Range("N" & rowExcel).Value = CDbl(0)

                    End If
                End If



                .Range("P" & rowExcel).Value = CStr("=T" & rowExcel & "/" & "M" & rowExcel)  '  ÃÒ¤ÒµèÍ¡ÔâÅ

                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) = True Then
                    .Range("Q" & rowExcel).Value = "0"
                    tempPrice = 0
                Else
                    If IsNumeric(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")) Then
                        tempPrice = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Price")
                        .Range("Q" & rowExcel).Value = tempPrice 'CStr("=T" & rowExcel & "/" & "L" & rowExcel)
                    Else
                        tempPrice = 0
                        .Range("Q" & rowExcel).Value = 0
                    End If

                End If
                If tempPrice = 0 Then
                    .Range("O" & rowExcel).Value = 0

                Else

                    If getCostType0 = 1 Then
                        .Range("O" & rowExcel).Value = CStr("=N" & rowExcel & "*" & "L" & rowExcel)
                    Else
                        ' costType=0
                        .Range("O" & rowExcel).Value = CStr("=N" & rowExcel & "*" & "M" & rowExcel)
                    End If

                End If
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_T_Disc")) = True Then
                    .Range("R" & rowExcel).Value = 0
                    strDisc = 0
                Else
                    If IsNumeric(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_T_Disc")) Then
                        strDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_T_Disc")
                        .Range("R" & rowExcel).Value = CDbl(strDisc * .Range("L" & rowExcel).Value)
                    Else
                        strDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_T_Disc")
                        .Range("R" & rowExcel).Value = getDiscValue(strDisc, (.Range("Q" & rowExcel).Value * .Range("L" & rowExcel).Value)) '(strDisc * (.Range("Q" & rowExcel).Value * .Range("L" & rowExcel).Value))
                    End If
                End If
                .Range("AA" & rowExcel).Value() = strDisc
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")) Then
                    strTrhDisc = "" ' subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                Else
                    strTrhDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                End If

                .Range("AB" & rowExcel).Value() = strTrhDisc
                If IsNumeric(strTrhDisc) = True Then
                    If strTrhDisc = 0 Then
                        strTrhDisc = 0
                        tempTrhDisc = 0
                    Else
                        strTrhDisc = CDbl(strTrhDisc)
                        tempTrhDisc = CDbl(strTrhDisc)

                    End If
                Else
                    tempTrhDisc = getTrhDisc(tmpTrhNo, selDocType)

                    'ElseIf IsDBNull(strTrhDisc) Then
                    'strTrhDisc = 0
                    'tempTrhDisc = 0
                    ' ElseIf strTrhDisc = "" Then
                    'strTrhDisc = 0
                    'tempTrhDisc = 0
                End If


                If IsDBNull(getTrhDisc(tmpTrhNo, selDocType)) = True Then
                    .Range("S" & rowExcel).Value = 0
                    strTrhDisc = 0
                Else
                    '============ ¤Ó¹Ç¹ÃÒ¤ÒÊèÇ¹Å´ ËÑÇºÔÅ ===================


                    '.Range("AB" & rowExcel).Value() = tempTrhDisc

                    If Microsoft.VisualBasic.Right(strTrhDisc, 1) = "%" Then

                        tempTrhDisc = CDbl(Microsoft.VisualBasic.Left(strTrhDisc, Len(strTrhDisc) - 1))
                        tempTrhDisc = (CDbl(tempTotal) * CDbl(tempTrhDisc)) / 100

                    ElseIf Microsoft.VisualBasic.Right(tempTrhDisc, 1) = "b" Or Microsoft.VisualBasic.Right(tempTrhDisc, 1) = "B" Then

                        tempTrhDisc = CDbl(Microsoft.VisualBasic.Left(tempDisc, Len(tempTrhDisc) - 1)) / getDocItem(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No"), "S")

                    ElseIf IsNumeric(tempDisc) Then
                        tempTrhDisc = tempTrhDisc / getDocItem(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No"), selDocType)

                    ElseIf tempTrhDisc = 0 Or tempTrhDisc = "" Then
                        tempTrhDisc = 0
                    End If

                    If IsNumeric(getTrhDisc(tmpTrhNo, selDocType)) Then
                        tempTrhDisc = getTrhDisc(tmpTrhNo, selDocType)

                        If tempTrhDisc = 0 Then
                            .Range("S" & rowExcel).Value = tempTrhDisc
                            strTrhDisc = 0
                            .Range("S" & rowExcel).Value = 0
                        Else

                            .Range("S" & rowExcel).Value = tempTrhDisc / getDocItem(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No"), selDocType)
                            strTrhDisc = tempTrhDisc / getDocItem(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_No"), selDocType)

                            'strTrhDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                            '.Range("S" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num") * getDiscValue(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc"), tempPrice)
                        End If
                    Else
                        strTrhDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                        .Range("S" & rowExcel).Value = (getDiscValue(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc"), tempPrice))

                        '.Range("S" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Num") * getDiscValue(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc"), tempPrice)
                        '.Range("S" & rowExcel).Value = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                        'strTrhDisc = subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Trh_Disc")
                    End If

                End If
                'getTrhDisc()

                If selDocType = "K" Then
                    .Range("T" & rowExcel).Value = CStr((("=L" & rowExcel & "*" & "Q" & rowExcel) & "-" & "R" & rowExcel) & "-" & "S" & rowExcel)
                Else
                    tempTotal = tempTotal - tempTrhDisc
                    .Range("T" & rowExcel).Value = (CStr((("=L" & rowExcel & "*" & "Q" & rowExcel) & "-" & "R" & rowExcel) & "-" & "S" & rowExcel)) 'tempTotal
                    .Range("Z" & rowExcel).Value = (CStr((("=L" & rowExcel & "*" & "Q" & rowExcel)))) 'tempTotal


                    'End If
                    '    End If
                End If
                If tempPrice = 0 Or selDocType = "L" Then
                    .Range("U" & rowExcel).Value = 0

                Else

                    .Range("U" & rowExcel).Value = CStr("=T" & rowExcel & "-" & "O" & rowExcel)

                End If
                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Po")) = False Then

                    If Len(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Po")) > 0 Then

                        .Range("X" & rowExcel).Value = "#PO:= " & subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Po")

                    End If

                End If

                If IsDBNull(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Detail")) = False Then

                    If Len(subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Detail")) > 0 Then

                        .Range("X" & rowExcel).Value = .Range("X" & rowExcel).Value & " ; " & subDS.Tables("Command").Rows(countRow + bufferExcel).Item("Dtl_Detail")
                    End If
                End If
                If IsDBNull(ramDateCost) = True Then
                    .Range("Y" & rowExcel).Value = ""
                Else
                    .Range("Y" & rowExcel).Value = ramDateCost

                End If
                rowExcel = rowExcel + 1

            Next

            'objExcelWorkBook.Close(SaveChanges:=0)
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcelWorkBook)
            'objExcelWorkBook = Nothing
            'objExcel.Quit()
            'System.Runtime.InteropServices.Marshal.ReleaseComObject(objExcel)
            'objExcel = Nothing


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

    'Private Sub frmReport2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    ElseIf e.KeyCode = Keys.F3 Then

    '        Dim frmFindStk As frmFindStk2 = New frmFindStk2
    '        selStkID = ""
    '        frmFindStk.ShowDialog()
    '        lbStkCode.Text = selStkID
    '        If lbStkCode.Text = "" Then
    '        Else
    '            lbStkName.Text = dbTools.getStkName(selStkID)
    '        End If


    '    End If
    'End Sub

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

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click

        Me.Hide()
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
            MsgBox("โปรดเลือกประเภทรายงาน ", MsgBoxStyle.Critical)
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

        selDocType = cboDType.SelectedValue.ToString

        If cboDType.SelectedValue.ToString = "K" Then
            MsgBox("โปรแกรมอยู่ในขั้นตอนทดสอบ ถ้าเจอข้อผิดพลาด โปรดแจ้ง ICT ")
            selDocType = "K"
            Call genSQLdetlByPenOr()
            Call getItemDetail()
        Else

            '  ====================   ÊÃéÒ§ SQL  ¢Í§ÃÒÂ§Ò¹
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
        '    MsgBox("â»Ã´àÅ×Í¡ËÑÇ¢éÍÃÒÂ§Ò¹·ÕèµéÍ§¡ÒÃ ", MsgBoxStyle.Critical)
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
        '    MsgBox("â»Ãá¡ÃÁ¡ÓÅÑ§ÍÂÙèã¹ÃÐËÇèÒ§·´ÊÍº à¡Ô´¢éÍ¼Ô´¾ÅÒ´â»Ã´á¨é§ ICT ")
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

    Function getMaster3(ByVal selTB As String, ByVal F1 As String, ByVal F2 As String, ProD_id As String) As DataSet

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
            txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            txtSQL = txtSQL & "Where Grp_type_Code = '" & F2 & "' "
            txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
            txtSQL = txtSQL & "Order by Grp_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            ' txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
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
            'MsgBox("¢éÍÁÙÅ·ÕèàÅ×Í¡ " & cboFactor1.SelectedValue.ToString)
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
            ' MsgBox("no=" & cboFactor3.Text)
            If cboFactor3.SelectedValue.ToString = "00" Then
                dsFC3 = getMaster3("00", cboFactor22.SelectedValue.ToString, "", Label10.Text)
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "01" Then
                dsFC3 = getMaster3("01", cboFactor22.SelectedValue.ToString, "", Label10.Text)
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "02" Then
                dsFC3 = getMaster3("02", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString, Label10.Text)
                With cboFactor33

                    .DataSource = dsFC3.Tables("master")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"

                End With
            ElseIf cboFactor3.SelectedValue.ToString = "07" Then
                dsFC3 = getMaster3("07", cboFactor22.SelectedValue.ToString, cboFactor22.SelectedValue.ToString, Label10.Text)
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

    'Private Sub lbFindWh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim findWh As New frmFindWH
    '    chkWH.Checked = True
    '    selWH = ""
    '    'findWh.ShowDialog()
    '    lbWHCode.Text = selWH
    '    lbWHname.Text = dbTools.getStore(selWH)

    'End Sub

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

    Private Sub cboDType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDType.Click

    End Sub


    Private Sub cboDType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDType.SelectedIndexChanged
        Try
            If cboDType.SelectedValue <> "S" Then

                chkOptSale.Checked = False
            Else
                chkOptSale.Checked = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboGrpSL_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrpSL.SelectedValueChanged
        Try


            If cboGrpSL.Text = "All" Then
                lbGrpSLCode.Text = cboGrpSL.SelectedValue
                selGrpSale = cboGrpSL.SelectedValue
                cboSale.Enabled = False
            Else
                lbGrpSLCode.Text = cboGrpSL.SelectedValue
                selGrpSale = cboGrpSL.SelectedValue
                cboSale.Enabled = True
                Call addItemSale(selGrpSale)
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboGrpSL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrpSL.SelectedIndexChanged
        chkSelSale.Checked = True

    End Sub

    Private Sub cboSale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSale.SelectedIndexChanged

    End Sub

    Private Sub cboSale_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSale.SelectedValueChanged

        Try
            'lbSelSaleID.Text = cboSale.SelectedValue
            lbSelSaleID.Text = cboSale.Text
        Catch ex As Exception

        End Try
    End Sub





    Private Sub cboSale2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSale2.SelectedValueChanged
        Try
            'lbSelSaleID.Text = cboSale.SelectedValue
            lbSelSaleID2.Text = cboSale2.Text

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cboGrpSL2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboGrpSL2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbGrpSLCode2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbGrpSLCode2.Click

    End Sub

    Private Sub cboGrpSL2_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrpSL2.SelectedIndexChanged
        chkSelSale2.Checked = True
    End Sub

    Private Sub cboGrpSL2_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrpSL2.SelectedValueChanged
        Try


            If cboGrpSL2.Text = "All" Then
                lbGrpSLCode2.Text = cboGrpSL2.SelectedValue
                selGrpSale2 = cboGrpSL2.SelectedValue
                cboSale2.Enabled = False
            Else
                lbGrpSLCode2.Text = cboGrpSL2.SelectedValue
                selGrpSale2 = cboGrpSL2.SelectedValue
                cboSale2.Enabled = True
                Call addItemSale2(selGrpSale2)
            End If



        Catch ex As Exception

        End Try
    End Sub


    Sub addDataVat()
        Dim dTB As New DataTable
        Dim Drow As DataRow
        dTB.Columns.Add(New DataColumn("T_Type", GetType(String)))
        dTB.Columns.Add(New DataColumn("T_Name", GetType(String)))


        Drow = dTB.NewRow
        Drow(0) = ""
        Drow(1) = ""
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "V"
        Drow(1) = "V :VAT"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "N"
        Drow(1) = "N :NoVAT"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "Y"
        Drow(1) = "Y :VAT ไม่คิดโปร"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "Z"
        Drow(1) = "Z :NoVAT ไม่คิดโปร"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "P"
        Drow(1) = "P คุณพิมพ์"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "B"
        Drow(1) = "B ขายก่อน VAT"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "M"
        Drow(1) = "M ขายก่อน NoVat"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "X"
        Drow(1) = "X ส่งของเปิดบิลก่อน"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "V & N"
        Drow(1) = "V & N"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "M & B"
        Drow(1) = "M & B"
        dTB.Rows.Add(Drow)


        Drow = dTB.NewRow
        Drow(0) = "P & V & B"
        Drow(1) = "P & V & B"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "V & B & M & N & Y & Z"
        Drow(1) = "V & B & M & N & Y & Z"
        dTB.Rows.Add(Drow)

        Drow = dTB.NewRow
        Drow(0) = "Y & Z"
        Drow(1) = "Y & Z"
        dTB.Rows.Add(Drow)



        'Drow = dTB.NewRow
        'Drow(0) = "DC"
        'Drow(1) = "DC"
        'dTB.Rows.Add(Drow)

        With cboNoTypeDoc

            .DataSource = dTB
            .DisplayMember = "T_Name"
            .ValueMember = "T_Type"
        End With
        'cboTypeDoc.SelectedValue = 1

    End Sub

    Private Sub cboNoTypeDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNoTypeDoc.SelectedIndexChanged

        If chkLoad = True Then

            chkTypeVat.Checked = True
            chkOptSale.Checked = False

        End If


    End Sub

    Dim chkData2 As Boolean = False
    'Dim chkData As Boolean = False
    'Dim chkProdList As Boolean = False
    Dim chkGrp As Boolean = False
    Dim chkColor As Boolean = False
    Dim chkLoad As Boolean = False
    ' Dim chkcol As Boolean = False
    Sub updateTableTran(trhNo As String)

        Dim pr_cost As Double = 0
        Dim stkCode As String = ""
        Dim stkFactor As Double = 0
        Dim TrhCostAmt As Double = 0
        Dim TrhWsum As Double = 0
        'Dim trh_Cost_Amt As Double
        Dim tmpCostAmt As Double = 0
        Dim prodCodeA As String = ""
        Dim prodCodeB As String = ""
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim Ans As Integer = 0

        tmpCostAmt = 0
        stkFactor = 0
        pr_cost = 0
        txtSQL = "Select * "
        txtSQL = txtSQL & "From TranDataD "

        txtSQL = txtSQL & "WHERE Dtl_Type='S' "
        txtSQL = txtSQL & "And Dtl_No='" & trhNo & "'  "
        'txtSQL = txtSQL & "And Dtl_idTrade='010101501230184000001013' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "stkList")

        Ans = subDS.Tables("stkList").Rows.Count

        For o = 0 To subDS.Tables("stklist").Rows.Count - 1

            stkCode = subDS.Tables("stkList").Rows(o).Item("dtl_idTrade")

            'If i = 0 Then
            '    prodCodeA = getProDCode(stkCode)
            '    prodCodeB = getProDCode(stkCode)
            'Else
            '    If prodCodeA = prodCodeB Then
            '        prodCodeB = getProDCode(stkCode)
            '    Else
            '        prodCodeA = getProDCode(stkCode)
            '        prodCodeB = getProDCode(stkCode)
            '        pr_cost = getCostByStk(stkCode, Format(subDS.Tables("stkList").Rows(o).Item("dtl_date"), "dd/MM/yyyy"), "", 0)
            '    End If
            'End If

            ' pr_cost = getCostByStk(stkCode, Format(subDS.Tables("stkList").Rows(o).Item("dtl_date"), "dd/MM/yyyy"), "", 0)
            stkFactor = getStkWight(stkCode)
            'TrhCostAmt = 0 'pr_cost * stkFactor
            Dim dtl_cost_Pr As Double = 0
            Dim Dtl_Cost_Amt As Double = 0
            Dim Q_num As Double = 0
            Dim date01 = Format(subDS.Tables("stkList").Rows(o).Item("dtl_date"), "dd/MM/yyyy")
            Dim dtl_ProFit As String = ""
            Dim dtl_Sum As Double = subDS.Tables("stkList").Rows(o).Item("Dtl_sum")
            Dim Dtl_Pr As Double = 0
            Dim strDtlDisc As String = subDS.Tables("stkList").Rows(o).Item("Dtl_T_Disc")

            Dim strDocNo As String = subDS.Tables("stkList").Rows(o).Item("dtl_no")

            '===================================
            If dbTools.getCostType(stkCode) = 0 Then

                Q_num = (subDS.Tables("stkList").Rows(o).Item("Dtl_Num") * stkFactor)
                TrhWsum = TrhWsum + Q_num

                dtl_cost_Pr = dbTools.getCostByStk(stkCode, date01, "", 0) ' ËÒÃÒ¤Ò·Ø¹ÊÔ¹¤éÒ
                Dtl_Cost_Amt = dtl_cost_Pr * Q_num    '  ËÒÁÙÅ¤èÒ·Ø¹ÊÔ¹¤éÒ
                'dtl_ProFit = (dtl_Sum - Dtl_Cost_Amt).ToString

                'If Q_num = 0 Then
                '    Dtl_Pr = dtl_Sum
                'Else
                '    Dtl_Pr = CDbl(dtl_Sum / Q_num)
                'End If

            ElseIf dbTools.getCostType(stkCode) = 1 Then

                Q_num = (subDS.Tables("stkList").Rows(o).Item("Dtl_Num"))
                TrhWsum = TrhWsum + Q_num
                dtl_cost_Pr = dbTools.getCostByStk(stkCode, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                Dtl_Cost_Amt = dtl_cost_Pr * Q_num
                ' Dtl_ProFit = CStr(Format(Dtl_Amt - Dtl_Cost_Amt, "#,##00.00"))
                'dtl_ProFit = (dtl_Sum - Dtl_Cost_Amt).ToString
                'If Q_num = 0 Then
                '    Dtl_Pr = dtl_Sum
                'Else
                '    Dtl_Pr = CDbl(dtl_Sum / Q_num)
                'End If
            Else
                'Dtl_Cost_PR = CDbl(.Rows(iRow).Item("CS_Cost"))
                Q_num = (subDS.Tables("stkList").Rows(o).Item("Dtl_Num") * stkFactor)
                TrhWsum = TrhWsum + Q_num
                dtl_cost_Pr = dbTools.getCostByStk(stkCode, date01, "", 0) 'CDbl(.Rows(iRow).Item("CS_Cost"))
                Dtl_Cost_Amt = dtl_cost_Pr * Q_num
                'dtl_ProFit = CStr(Format(dtl_Sum - Dtl_Cost_Amt - getDiscValue(strDtlDisc, dtl_Sum), "#,##00.00"))

                'If Q_num = 0 Then
                '    Dtl_Pr = dtl_Sum
                'Else
                '    Dtl_Pr = CDbl(dtl_Sum / Num)
                'End If
            End If

            TrhCostAmt = TrhCostAmt + Dtl_Cost_Amt

            '=============================================
            '  ¾ÔàÈÉ update ¢éÍÁÙÅã¹  TranDataD 

            txtSQL = "Update TranDataD "
            txtSQL = txtSQL & "Set Dtl_Pr_Cost='" & dtl_cost_Pr & "',"
            txtSQL = txtSQL & "Dtl_Cost_Sum='" & Dtl_Cost_Amt & "' "
            txtSQL = txtSQL & "Where dtl_Type='S' "
            txtSQL = txtSQL & "And Dtl_No='" & strDocNo & "' "
            txtSQL = txtSQL & "And Dtl_idTrade='" & stkCode & "' "
            dbTools.dbSaveSQLsrv(txtSQL, "")

            '=====================================
            'TrhCostAmt = trh_Cost_Amt

        Next
        subDS.Tables("stkList").Clear()
        'subDA = Nothing
        'Label1.Text = ds.Tables("tranDB").Rows(i).Item("Trh_No").ToString

        txtSQL = "Update TranDataH "
        txtSQL = txtSQL & "Set Trh_Item_Count='" & Ans & "',"
        txtSQL = txtSQL & "Trh_Cost_Amt='" & TrhCostAmt & "', "
        txtSQL = txtSQL & "Trh_ProD_Sales ='" & getProDCode(stkCode) & "',."
        txtSQL = txtSQL & "Trh_W_Sum='" & TrhWsum & "'"

        txtSQL = txtSQL & "Where Trh_Type='S' and TRh_no='" & trhNo & "'"
        dbTools.dbSaveSQLsrv(txtSQL, "")


    End Sub
    Sub saveDataCS(ByVal csCode As String, ByVal csStkCode As String, ByVal csStkName As String, ByVal csCostType As Integer, ByVal csCost As String, ByVal csDate As String)

        Dim csType As String = csCostType
        Dim baseStkType As String = dbTools.getCostType(csStkCode)

        If chkCostUpdate(csCode, csStkCode, csDate) = True Then


            txtSQL = "Update CostMast "
            txtSQL = txtSQL & "set "
            txtSQL = txtSQL & "CS_Cost='" & csCost & "', "
            txtSQL = txtSQL & "CS_Code='" & csCode & "', "
            txtSQL = txtSQL & "CS_Type='" & csType & "' "


            txtSQL = txtSQL & "Where CS_Stk_Code='" & csStkCode & "' "
            txtSQL = txtSQL & "And CS_Date='" & csDate & "'"

            dbTools.dbSaveSQLsrv(txtSQL, "")

            txtSQL = "Update Basemast "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "Stk_Equ='" & csType & "',Stk_Type='" & csType & "' "
            txtSQL = txtSQL & "Where Stk_Code='" & csStkCode & "' "

            dbTools.dbSaveSQLsrv(txtSQL, "")

        Else
            txtSQL = "Insert Into CostMast(CS_Code,CS_Stk_Code,CS_Stk_Name,CS_Cost,CS_Type,CS_Date) "

            txtSQL = txtSQL & "Values( "
            txtSQL = txtSQL & "'" & csCode & "',"
            txtSQL = txtSQL & "'" & csStkCode & "',"
            txtSQL = txtSQL & "'" & csStkName & "',"
            txtSQL = txtSQL & "'" & csCost & "',"
            txtSQL = txtSQL & "'" & baseStkType & "',"
            txtSQL = txtSQL & "'" & csDate & "'"
            txtSQL = txtSQL & ")"

            dbTools.dbSaveSQLsrv(txtSQL, "")

            txtSQL = "Update Basemast "
            txtSQL = txtSQL & "Set "
            txtSQL = txtSQL & "Stk_Equ='" & csType & "',Stk_Type='" & csType & "' "
            txtSQL = txtSQL & "Where Stk_Code='" & csStkCode & "' "

            dbTools.dbSaveSQLsrv(txtSQL, "")
        End If


    End Sub

    Sub saveDataCS2(csStkProd As String, csStkType As String, ByVal csCode As String, ByVal csStkCode As String, ByVal csStkName As String, ByVal csCostType As Integer, ByVal csCost As String, ByVal csDate As String)

        Dim csType As String = csCostType
        Dim baseStkType As String = dbTools.getCostType(csStkCode)

        If chkCostUpdate(csCode, csStkCode, csDate) = True Then

            txtSQL = "Update CostMast "
            txtSQL = txtSQL & "set "
            txtSQL = txtSQL & "CS_Stk_Prod='" & csStkProd & "',"
            txtSQL = txtSQL & "CS_Stk_Type='" & csStkType & "',"
            txtSQL = txtSQL & "CS_Cost='" & csCost & "', "
            txtSQL = txtSQL & "CS_Code='" & csCode & "', "
            txtSQL = txtSQL & "CS_Type='" & csType & "' "

            txtSQL = txtSQL & "Where CS_Stk_Code='" & csStkCode & "' "
            txtSQL = txtSQL & "And CS_Date='" & csDate & "'"

            dbTools.dbSaveSQLsrv(txtSQL, "")

        Else
            txtSQL = "Insert Into CostMast(CS_Stk_Prod,CS_Stk_type,CS_Code,CS_Stk_Code,CS_Stk_Name,CS_Cost,CS_Type,CS_Date) "

            txtSQL = txtSQL & "Values( "
            txtSQL = txtSQL & "'" & csStkProd & "',"
            txtSQL = txtSQL & "'" & csStkType & "',"
            txtSQL = txtSQL & "'" & csCode & "',"
            txtSQL = txtSQL & "'" & csStkCode & "',"
            txtSQL = txtSQL & "'" & csStkName & "',"
            txtSQL = txtSQL & "'" & csCost & "',"
            txtSQL = txtSQL & "'" & csType & "',"
            txtSQL = txtSQL & "'" & csDate & "'"
            txtSQL = txtSQL & ")"

            dbTools.dbSaveSQLsrv(txtSQL, "")

        End If


    End Sub
    Function chkCostUpdate(ByVal csCode As String, ByVal csStkCode As String, ByVal csDate As String) As Boolean
        Dim ans As Boolean = False
        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = "Select * "
        txtSQL = txtSQL & "From CostMast "
        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & "CS_Stk_Code='" & csStkCode & "' "  '"010102000305091503001011"
        txtSQL = txtSQL & "And CS_Date ='" & csDate & "'"

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "CostList")

        If subDS.Tables("CostList").Rows.Count > 0 Then
            ans = True
        Else
            ans = False
        End If
        Return ans

    End Function

    'Private Sub lsvShow_Click(sender As Object, e As EventArgs) Handles lsvShow.Click
    '    For i = 0 To lsvShow.SelectedItems.Count - 1

    '        lvi = lsvShow.SelectedItems(i)
    '        selStkID = lsvShow.Items(lvi.Index).SubItems(21).Text
    '        txtStkCode.Text = selStkID
    '        lbStkNameD.Text = dbTools.getStkName(selStkID)
    '        lbDocNo.Text = lsvShow.Items(lvi.Index).SubItems(4).Text
    '        txtDateD.Text = lsvShow.Items(lvi.Index).SubItems(2).Text()
    '        txtCostPr.Text = lsvShow.Items(lvi.Index).SubItems(13).Text()

    '        lbPrCost.Text = txtCostPr.Text
    '        lbPrSales.Text = lsvShow.Items(lvi.Index).SubItems(15).Text()

    '        lbProFic.Text = (CDbl(lbPrSales.Text) - CDbl(lbPrCost.Text))
    '        lbProFicPer.Text = (((CDbl(lbPrSales.Text) - CDbl(lbPrCost.Text)) / (CDbl(lbPrCost.Text))) * 100) & " %"

    '        If CDbl(lbProFic.Text) > 0 Then
    '            lbProFic.BackColor = Color.DarkGreen
    '            lbProFic.ForeColor = Color.White
    '        Else
    '            lbProFic.BackColor = Color.DarkRed
    '            lbProFic.ForeColor = Color.White
    '        End If
    '        strStkCode = txtStkCode.Text
    '        strstkName = getStkName(strStkCode)
    '        strCost_pr = txtCostPr.Text
    '        strCostType = getCostType(strStkCode)
    '        If strCostType = 0 Then
    '            optType0.Checked = True
    '            'optType0.BackColor = Color.Red
    '        Else
    '            optType1.Checked = True
    '            'optType1.BackColor = Color.Red
    '        End If

    '    Next
    'End Sub

    Private Sub lsvShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvShow.SelectedIndexChanged

        For i = 0 To lsvShow.SelectedItems.Count - 1

            Dim stkQty As Double = 0
            Dim stkPrice As Double = 0
            Dim stkCost As Double = 0
            Dim sumPrice As Double = 0
            Dim sumCost As Double = 0



            lvi = lsvShow.SelectedItems(i)
            selStkID = lsvShow.Items(lvi.Index).SubItems(20).Text
            txtStkCode.Text = selStkID
            If getStkName(selStkID) = "" Then
                Exit Sub
            End If
            lbStkNameD.Text = dbTools.getStkName(selStkID)
            lbDocNo.Text = lsvShow.Items(lvi.Index).SubItems(3).Text
            txtDateD.Text = lsvShow.Items(lvi.Index).SubItems(2).Text()
            stkQty = lsvShow.Items(lvi.Index).SubItems(10).Text
            lbWeigth.Text = Format(dbTools.getStkWight(selStkID), "#,##0.00")
            lbQty.Text = stkQty
            stkPrice = lsvShow.Items(lvi.Index).SubItems(15).Text()
            lbPrSales.Text = stkPrice
            txtCusCode.Text = getCusIDbyDoc(lbDocNo.Text, "S")

            If IsNumeric(lsvShow.Items(lvi.Index).SubItems(12).Text()) Then  'ÃÒ¤Ò·Ø¹
                stkCost = lsvShow.Items(lvi.Index).SubItems(12).Text()
            Else
                stkCost = 0
            End If
            txtCostPr.Text = stkCost
            lbPrCost.Text = stkCost

            strCostType = getCostType(selStkID)
            If strCostType = 0 Then
                optType0.Checked = True  '  ¤Ô´µé¹·Ø¹µèÍ ¡ÔâÅ
                'optType0.BackColor = Color.Red
                sumCost = (stkQty * (lbWeigth.Text * stkCost))
            Else
                optType1.Checked = True  '  ¤Ô´µé¹·Ø¹µèÍ Ë¹èÇÂ
                'optType1.BackColor = Color.Red
                sumCost = stkQty * stkCost

            End If

            sumPrice = stkQty * stkPrice
            lbSumCost.Text = Format(sumCost, "#,##0.00")
            lbSumSales.Text = Format(sumPrice, "#,##0.00")

            'If lbPrSales.Text = "" Then
            '    lbPrSales.Text = 0
            'End If

            lbProFic.Text = Format(sumPrice - sumCost, "#,##0.00")
            lbProFicPer.Text = Format((((sumPrice - sumCost) / (sumCost)) * 100), "#,##0.00") & " %"

            If CDbl(lbProFic.Text) > 0 Then
                lbProFic.BackColor = Color.DarkGreen
                lbProFic.ForeColor = Color.White
            Else
                lbProFic.BackColor = Color.DarkRed
                lbProFic.ForeColor = Color.White
            End If
            strStkCode = txtStkCode.Text
            strstkName = getStkName(strStkCode)
            strCost_pr = txtCostPr.Text



        Next
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If optType0.Checked = True Then
            strCostType = 0
        Else
            strCostType = 1
        End If

        strStkCode = selStkID
        strCost_pr = CDbl(txtCostPr.Text)
        strCost_id = strStkCode
        strUpdate = Mid(((Year(CDate(txtDateD.Text)) - 543).ToString), 3, 2) & "/" & Format(Month(CDate(txtDateD.Text)), "00")
        'strUpdate = Format(DateAdd(DateInterval.Year, -543, CDate(txtDateD.Text)), "yy/MM")
        'strUpdate = Format(DateAdd(DateInterval.Year, -543, CDate(txtDateD.Text)), "yy/MM")  'á¡éä¢ 2016-03-01

        Call saveDataCS(strCost_id, strStkCode, strstkName, strCostType, strCost_pr, strUpdate)
        Call updateTableTran(lbDocNo.Text)

        MsgBox("ºÑ¹·Ö¡µé¹·Ø¹àÃÕÂºÃéÍÂ", MsgBoxStyle.Information, "á¨é§àµ×Í¹")

    End Sub

    Private Sub optType0_CheckedChanged(sender As Object, e As EventArgs) Handles optType0.CheckedChanged
        If optType0.Checked = True Then
            optType0.BackColor = Color.Red
            optType1.BackColor = Color.Transparent
            'Else
            '    optType1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub optType1_CheckedChanged(sender As Object, e As EventArgs) Handles optType1.CheckedChanged
        If optType1.Checked = True Then
            optType1.BackColor = Color.Red
            optType0.BackColor = Color.Transparent
            'Else
            '    optType0.BackColor = Color.Red
        End If
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles tabCost.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objExcel As Microsoft.Office.Interop.Excel.Application
        Dim objExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim objExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim oRng As Microsoft.Office.Interop.Excel.Range

        'Dim dtlType As String = ""

        ' Dim stkName2 As String
        'dtlType = cboDType.SelectedValue.ToString
        'fileName = CurDir() & "\report\rptStk02.xls"
        objExcel = New Microsoft.Office.Interop.Excel.Application
        objExcel.Visible = True
        objExcelWorkBook = objExcel.Workbooks.Open(CurDir() & "\report\rptStk02.xlsx")
        objExcelWorkSheet = objExcelWorkBook.Worksheets(1)

        With objExcelWorkSheet

        End With
    End Sub


    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub chkValueSum_CheckedChanged(sender As Object, e As EventArgs) Handles chkValueSum.CheckedChanged

    End Sub

    Private Sub cmbCal_Click(sender As Object, e As EventArgs) Handles cmbCal.Click
        If optType0.Checked = True Then
            strCostType = 0
        Else
            strCostType = 1
        End If

        strStkCode = selStkID
        strCost_pr = CDbl(txtCostPr.Text)
        strCost_id = strStkCode
        strUpdate = Mid(((Year(CDate(txtDateD.Text)) - 543).ToString), 3, 2) & "/" & Format(Month(CDate(txtDateD.Text)), "00")
        'strUpdate = Format(DateAdd(DateInterval.Year, -543, CDate(txtDateD.Text)), "yy/MM")
        'lbWeigth.Text=

    End Sub

    Private Sub frmReport2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbTools.openDB()
        lbDBName.Text = Conn.DataSource & "\" & Conn.Database

        lbDate01.Value = Now
        lbDate02.Value = Now
        Call addDataVat()
        Call addItemCBO()
        Call addItemGrpSL()
        Call addItemGrpSL2()
        'Call addProdList()
        Call getColFactor()
        'Call FormatGrd()
        'optDoc.Checked = True
        Call getColListView()

        'lbSaleName.Text = dbTools.getSaleName(lbSaleID.Text)
        chkOptSale.Checked = True
        chkNotSale.Checked = True
        chkNotSale2.Checked = True
        cmbRun.Focus()
        chkLoad = True

    End Sub

    Private Sub cboFactor33_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFactor33.SelectedIndexChanged

        lbGrpCode.Text = cboFactor33.SelectedValue

    End Sub

    Private Sub cboFactor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFactor2.SelectedIndexChanged

    End Sub

    Private Sub lbCusID_Click(sender As Object, e As EventArgs) Handles lbCusID.Click

    End Sub

    Private Sub lbCusName_Click(sender As Object, e As EventArgs) Handles lbCusName.Click

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class
