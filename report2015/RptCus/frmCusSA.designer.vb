<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCusSA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lsvListCus = New System.Windows.Forms.ListView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optSelCusName = New System.Windows.Forms.RadioButton()
        Me.optSelName = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optProfit = New System.Windows.Forms.RadioButton()
        Me.optAmt = New System.Windows.Forms.RadioButton()
        Me.optWeight = New System.Windows.Forms.RadioButton()
        Me.optUnit = New System.Windows.Forms.RadioButton()
        Me.lbStrConnect = New System.Windows.Forms.Label()
        Me.lbTotalWeight = New System.Windows.Forms.Label()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.optSelStk = New System.Windows.Forms.CheckBox()
        Me.lbFindStk = New System.Windows.Forms.Label()
        Me.lbStkCode = New System.Windows.Forms.Label()
        Me.chkPriceZero = New System.Windows.Forms.CheckBox()
        Me.lbTotalCost = New System.Windows.Forms.Label()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSelNPD = New System.Windows.Forms.RadioButton()
        Me.optSelPD = New System.Windows.Forms.RadioButton()
        Me.optSelGPTT = New System.Windows.Forms.RadioButton()
        Me.optSelGMB = New System.Windows.Forms.RadioButton()
        Me.optSelTT = New System.Windows.Forms.RadioButton()
        Me.optSelGP = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotalQty = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbTotalProfit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotalSales = New System.Windows.Forms.Label()
        Me.optSelAR = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.lbCusCode = New System.Windows.Forms.Label()
        Me.chkNoSelDetail = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbDate2 = New System.Windows.Forms.Label()
        Me.optSelDay = New System.Windows.Forms.RadioButton()
        Me.lbDate1 = New System.Windows.Forms.Label()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.txtDate02 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.opt12Month = New System.Windows.Forms.RadioButton()
        Me.opt6Month = New System.Windows.Forms.RadioButton()
        Me.opt3Month = New System.Windows.Forms.RadioButton()
        Me.opt1Month = New System.Windows.Forms.RadioButton()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.optSales = New System.Windows.Forms.CheckBox()
        Me.cboSales = New System.Windows.Forms.ComboBox()
        Me.chkDocID = New System.Windows.Forms.CheckBox()
        Me.chkGrpCus = New System.Windows.Forms.CheckBox()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(272, 449)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "น้ำหนักรวม"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(502, 449)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "มูลค่าทุนรวม"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsvListCus)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1229, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chart"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsvListCus
        '
        Me.lsvListCus.HideSelection = False
        Me.lsvListCus.Location = New System.Drawing.Point(10, 12)
        Me.lsvListCus.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvListCus.Name = "lsvListCus"
        Me.lsvListCus.Size = New System.Drawing.Size(559, 461)
        Me.lsvListCus.TabIndex = 0
        Me.lsvListCus.UseCompatibleStateImageBehavior = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optSelCusName)
        Me.GroupBox3.Controls.Add(Me.optSelName)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.optProfit)
        Me.GroupBox3.Controls.Add(Me.optAmt)
        Me.GroupBox3.Controls.Add(Me.optWeight)
        Me.GroupBox3.Controls.Add(Me.optUnit)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 520)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(794, 47)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'optSelCusName
        '
        Me.optSelCusName.AutoSize = True
        Me.optSelCusName.Location = New System.Drawing.Point(703, 15)
        Me.optSelCusName.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelCusName.Name = "optSelCusName"
        Me.optSelCusName.Size = New System.Drawing.Size(83, 24)
        Me.optSelCusName.TabIndex = 6
        Me.optSelCusName.Text = "ชื่อลูกค้า"
        Me.optSelCusName.UseVisualStyleBackColor = True
        '
        'optSelName
        '
        Me.optSelName.AutoSize = True
        Me.optSelName.Location = New System.Drawing.Point(591, 15)
        Me.optSelName.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelName.Name = "optSelName"
        Me.optSelName.Size = New System.Drawing.Size(83, 24)
        Me.optSelName.TabIndex = 5
        Me.optSelName.Text = "ชื่อสินค้า"
        Me.optSelName.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ลำดับตาม"
        '
        'optProfit
        '
        Me.optProfit.AutoSize = True
        Me.optProfit.Location = New System.Drawing.Point(468, 15)
        Me.optProfit.Margin = New System.Windows.Forms.Padding(2)
        Me.optProfit.Name = "optProfit"
        Me.optProfit.Size = New System.Drawing.Size(99, 24)
        Me.optProfit.TabIndex = 3
        Me.optProfit.Text = "มูลค่ากำไร"
        Me.optProfit.UseVisualStyleBackColor = True
        '
        'optAmt
        '
        Me.optAmt.AutoSize = True
        Me.optAmt.Location = New System.Drawing.Point(352, 15)
        Me.optAmt.Margin = New System.Windows.Forms.Padding(2)
        Me.optAmt.Name = "optAmt"
        Me.optAmt.Size = New System.Drawing.Size(92, 24)
        Me.optAmt.TabIndex = 2
        Me.optAmt.Text = "มูลค่าขาย"
        Me.optAmt.UseVisualStyleBackColor = True
        '
        'optWeight
        '
        Me.optWeight.AutoSize = True
        Me.optWeight.Checked = True
        Me.optWeight.Location = New System.Drawing.Point(249, 15)
        Me.optWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.optWeight.Name = "optWeight"
        Me.optWeight.Size = New System.Drawing.Size(75, 24)
        Me.optWeight.TabIndex = 1
        Me.optWeight.TabStop = True
        Me.optWeight.Text = "น้ำหนัก"
        Me.optWeight.UseVisualStyleBackColor = True
        '
        'optUnit
        '
        Me.optUnit.AutoSize = True
        Me.optUnit.Location = New System.Drawing.Point(112, 15)
        Me.optUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.optUnit.Name = "optUnit"
        Me.optUnit.Size = New System.Drawing.Size(109, 24)
        Me.optUnit.TabIndex = 0
        Me.optUnit.Text = "จำนวนหน่วย"
        Me.optUnit.UseVisualStyleBackColor = True
        '
        'lbStrConnect
        '
        Me.lbStrConnect.AutoSize = True
        Me.lbStrConnect.BackColor = System.Drawing.Color.Gold
        Me.lbStrConnect.Location = New System.Drawing.Point(6, 716)
        Me.lbStrConnect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStrConnect.Name = "lbStrConnect"
        Me.lbStrConnect.Size = New System.Drawing.Size(57, 20)
        Me.lbStrConnect.TabIndex = 28
        Me.lbStrConnect.Text = "Label3"
        '
        'lbTotalWeight
        '
        Me.lbTotalWeight.BackColor = System.Drawing.Color.Black
        Me.lbTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalWeight.ForeColor = System.Drawing.Color.White
        Me.lbTotalWeight.Location = New System.Drawing.Point(368, 449)
        Me.lbTotalWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalWeight.Name = "lbTotalWeight"
        Me.lbTotalWeight.Size = New System.Drawing.Size(136, 22)
        Me.lbTotalWeight.TabIndex = 7
        Me.lbTotalWeight.Text = "0"
        Me.lbTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkName.Location = New System.Drawing.Point(100, 676)
        Me.lbStkName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(358, 25)
        Me.lbStkName.TabIndex = 31
        '
        'optSelStk
        '
        Me.optSelStk.AutoSize = True
        Me.optSelStk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSelStk.Location = New System.Drawing.Point(11, 678)
        Me.optSelStk.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelStk.Name = "optSelStk"
        Me.optSelStk.Size = New System.Drawing.Size(87, 24)
        Me.optSelStk.TabIndex = 32
        Me.optSelStk.Text = "ตามสินค้า"
        Me.optSelStk.UseVisualStyleBackColor = True
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbFindStk.Location = New System.Drawing.Point(465, 676)
        Me.lbFindStk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(34, 25)
        Me.lbFindStk.TabIndex = 30
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkCode.Location = New System.Drawing.Point(106, 676)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(358, 25)
        Me.lbStkCode.TabIndex = 33
        '
        'chkPriceZero
        '
        Me.chkPriceZero.AutoSize = True
        Me.chkPriceZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkPriceZero.Location = New System.Drawing.Point(760, 628)
        Me.chkPriceZero.Margin = New System.Windows.Forms.Padding(2)
        Me.chkPriceZero.Name = "chkPriceZero"
        Me.chkPriceZero.Size = New System.Drawing.Size(177, 24)
        Me.chkPriceZero.TabIndex = 34
        Me.chkPriceZero.Text = "ตัดยอดสินค้าราคา 0 บาท"
        Me.chkPriceZero.UseVisualStyleBackColor = False
        '
        'lbTotalCost
        '
        Me.lbTotalCost.BackColor = System.Drawing.Color.Black
        Me.lbTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalCost.ForeColor = System.Drawing.Color.White
        Me.lbTotalCost.Location = New System.Drawing.Point(611, 449)
        Me.lbTotalCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalCost.Name = "lbTotalCost"
        Me.lbTotalCost.Size = New System.Drawing.Size(136, 22)
        Me.lbTotalCost.TabIndex = 5
        Me.lbTotalCost.Text = "0"
        Me.lbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsvShow
        '
        Me.lsvShow.BackColor = System.Drawing.Color.Honeydew
        Me.lsvShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.GridLines = True
        Me.lsvShow.HideSelection = False
        Me.lsvShow.Location = New System.Drawing.Point(6, 8)
        Me.lsvShow.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(1214, 392)
        Me.lsvShow.TabIndex = 0
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSelNPD)
        Me.GroupBox1.Controls.Add(Me.optSelPD)
        Me.GroupBox1.Controls.Add(Me.optSelGPTT)
        Me.GroupBox1.Controls.Add(Me.optSelGMB)
        Me.GroupBox1.Controls.Add(Me.optSelTT)
        Me.GroupBox1.Controls.Add(Me.optSelGP)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 562)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(601, 45)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'optSelNPD
        '
        Me.optSelNPD.AutoSize = True
        Me.optSelNPD.Location = New System.Drawing.Point(372, 16)
        Me.optSelNPD.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelNPD.Name = "optSelNPD"
        Me.optSelNPD.Size = New System.Drawing.Size(60, 24)
        Me.optSelNPD.TabIndex = 5
        Me.optSelNPD.Text = "NPD"
        Me.optSelNPD.UseVisualStyleBackColor = True
        '
        'optSelPD
        '
        Me.optSelPD.AutoSize = True
        Me.optSelPD.Location = New System.Drawing.Point(301, 16)
        Me.optSelPD.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelPD.Name = "optSelPD"
        Me.optSelPD.Size = New System.Drawing.Size(49, 24)
        Me.optSelPD.TabIndex = 4
        Me.optSelPD.Text = "PD"
        Me.optSelPD.UseVisualStyleBackColor = True
        '
        'optSelGPTT
        '
        Me.optSelGPTT.AutoSize = True
        Me.optSelGPTT.Location = New System.Drawing.Point(454, 16)
        Me.optSelGPTT.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelGPTT.Name = "optSelGPTT"
        Me.optSelGPTT.Size = New System.Drawing.Size(119, 24)
        Me.optSelGPTT.TabIndex = 3
        Me.optSelGPTT.Text = "GP+TT+NPD"
        Me.optSelGPTT.UseVisualStyleBackColor = True
        '
        'optSelGMB
        '
        Me.optSelGMB.AutoSize = True
        Me.optSelGMB.Location = New System.Drawing.Point(200, 16)
        Me.optSelGMB.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelGMB.Name = "optSelGMB"
        Me.optSelGMB.Size = New System.Drawing.Size(64, 24)
        Me.optSelGMB.TabIndex = 2
        Me.optSelGMB.Text = "GMB"
        Me.optSelGMB.UseVisualStyleBackColor = True
        '
        'optSelTT
        '
        Me.optSelTT.AutoSize = True
        Me.optSelTT.Location = New System.Drawing.Point(108, 16)
        Me.optSelTT.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelTT.Name = "optSelTT"
        Me.optSelTT.Size = New System.Drawing.Size(45, 24)
        Me.optSelTT.TabIndex = 1
        Me.optSelTT.Text = "TT"
        Me.optSelTT.UseVisualStyleBackColor = True
        '
        'optSelGP
        '
        Me.optSelGP.AutoSize = True
        Me.optSelGP.Checked = True
        Me.optSelGP.Location = New System.Drawing.Point(14, 16)
        Me.optSelGP.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelGP.Name = "optSelGP"
        Me.optSelGP.Size = New System.Drawing.Size(50, 24)
        Me.optSelGP.TabIndex = 0
        Me.optSelGP.TabStop = True
        Me.optSelGP.Text = "GP"
        Me.optSelGP.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Maroon
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(1060, 658)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(172, 46)
        Me.cmdExit.TabIndex = 24
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdRun.ForeColor = System.Drawing.Color.White
        Me.cmdRun.Location = New System.Drawing.Point(862, 658)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(172, 46)
        Me.cmdRun.TabIndex = 23
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1237, 509)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lbTotalQty)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lbTotalWeight)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lbTotalCost)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lbTotalProfit)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.lbTotalSales)
        Me.TabPage1.Controls.Add(Me.lsvShow)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1229, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 449)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "จำนวนรวม"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalQty
        '
        Me.lbTotalQty.BackColor = System.Drawing.Color.Black
        Me.lbTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalQty.ForeColor = System.Drawing.Color.White
        Me.lbTotalQty.Location = New System.Drawing.Point(124, 449)
        Me.lbTotalQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(136, 22)
        Me.lbTotalQty.TabIndex = 11
        Me.lbTotalQty.Text = "0"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1004, 449)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 22)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "กำไรรวม"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalProfit
        '
        Me.lbTotalProfit.BackColor = System.Drawing.Color.Black
        Me.lbTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit.ForeColor = System.Drawing.Color.White
        Me.lbTotalProfit.Location = New System.Drawing.Point(1082, 449)
        Me.lbTotalProfit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalProfit.Name = "lbTotalProfit"
        Me.lbTotalProfit.Size = New System.Drawing.Size(136, 22)
        Me.lbTotalProfit.TabIndex = 3
        Me.lbTotalProfit.Text = "0"
        Me.lbTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(748, 449)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "มูลค่าขายรวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalSales
        '
        Me.lbTotalSales.BackColor = System.Drawing.Color.Black
        Me.lbTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalSales.ForeColor = System.Drawing.Color.White
        Me.lbTotalSales.Location = New System.Drawing.Point(862, 449)
        Me.lbTotalSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalSales.Name = "lbTotalSales"
        Me.lbTotalSales.Size = New System.Drawing.Size(136, 22)
        Me.lbTotalSales.TabIndex = 1
        Me.lbTotalSales.Text = "0"
        Me.lbTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optSelAR
        '
        Me.optSelAR.AutoSize = True
        Me.optSelAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSelAR.Location = New System.Drawing.Point(11, 648)
        Me.optSelAR.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelAR.Name = "optSelAR"
        Me.optSelAR.Size = New System.Drawing.Size(87, 24)
        Me.optSelAR.TabIndex = 37
        Me.optSelAR.Text = "ตามลูกค้า"
        Me.optSelAR.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(390, 646)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "..."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.Black
        Me.lbCusName.Location = New System.Drawing.Point(100, 646)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(294, 25)
        Me.lbCusName.TabIndex = 38
        '
        'lbCusCode
        '
        Me.lbCusCode.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbCusCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbCusCode.Location = New System.Drawing.Point(106, 646)
        Me.lbCusCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusCode.Name = "lbCusCode"
        Me.lbCusCode.Size = New System.Drawing.Size(272, 25)
        Me.lbCusCode.TabIndex = 39
        '
        'chkNoSelDetail
        '
        Me.chkNoSelDetail.AutoSize = True
        Me.chkNoSelDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNoSelDetail.Checked = True
        Me.chkNoSelDetail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoSelDetail.Location = New System.Drawing.Point(947, 628)
        Me.chkNoSelDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNoSelDetail.Name = "chkNoSelDetail"
        Me.chkNoSelDetail.Size = New System.Drawing.Size(147, 24)
        Me.chkNoSelDetail.TabIndex = 40
        Me.chkNoSelDetail.Text = "ตัดรายละเอียดสินค้า"
        Me.chkNoSelDetail.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.lbDate2)
        Me.GroupBox4.Controls.Add(Me.optSelDay)
        Me.GroupBox4.Controls.Add(Me.lbDate1)
        Me.GroupBox4.Controls.Add(Me.txtDate01)
        Me.GroupBox4.Controls.Add(Me.txtDate02)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.opt12Month)
        Me.GroupBox4.Controls.Add(Me.opt6Month)
        Me.GroupBox4.Controls.Add(Me.opt3Month)
        Me.GroupBox4.Controls.Add(Me.opt1Month)
        Me.GroupBox4.Location = New System.Drawing.Point(854, 511)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(386, 110)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        '
        'lbDate2
        '
        Me.lbDate2.BackColor = System.Drawing.Color.Black
        Me.lbDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate2.ForeColor = System.Drawing.Color.Lime
        Me.lbDate2.Location = New System.Drawing.Point(246, 85)
        Me.lbDate2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDate2.Name = "lbDate2"
        Me.lbDate2.Size = New System.Drawing.Size(118, 22)
        Me.lbDate2.TabIndex = 26
        Me.lbDate2.Text = "Label1"
        Me.lbDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optSelDay
        '
        Me.optSelDay.AutoSize = True
        Me.optSelDay.BackColor = System.Drawing.Color.MediumPurple
        Me.optSelDay.Checked = True
        Me.optSelDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelDay.ForeColor = System.Drawing.Color.White
        Me.optSelDay.Location = New System.Drawing.Point(13, 52)
        Me.optSelDay.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelDay.Name = "optSelDay"
        Me.optSelDay.Size = New System.Drawing.Size(71, 24)
        Me.optSelDay.TabIndex = 11
        Me.optSelDay.TabStop = True
        Me.optSelDay.Text = "ระบุวัน"
        Me.optSelDay.UseVisualStyleBackColor = False
        '
        'lbDate1
        '
        Me.lbDate1.BackColor = System.Drawing.Color.Black
        Me.lbDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate1.ForeColor = System.Drawing.Color.Lime
        Me.lbDate1.Location = New System.Drawing.Point(98, 85)
        Me.lbDate1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDate1.Name = "lbDate1"
        Me.lbDate1.Size = New System.Drawing.Size(118, 22)
        Me.lbDate1.TabIndex = 1
        Me.lbDate1.Text = "Label1"
        Me.lbDate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDate01
        '
        Me.txtDate01.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate01.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate01.Location = New System.Drawing.Point(98, 51)
        Me.txtDate01.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(120, 26)
        Me.txtDate01.TabIndex = 7
        '
        'txtDate02
        '
        Me.txtDate02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate02.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate02.Location = New System.Drawing.Point(246, 51)
        Me.txtDate02.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate02.Name = "txtDate02"
        Me.txtDate02.Size = New System.Drawing.Size(120, 26)
        Me.txtDate02.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ถึง"
        '
        'opt12Month
        '
        Me.opt12Month.AutoSize = True
        Me.opt12Month.BackColor = System.Drawing.Color.MediumPurple
        Me.opt12Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt12Month.ForeColor = System.Drawing.Color.White
        Me.opt12Month.Location = New System.Drawing.Point(270, 17)
        Me.opt12Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt12Month.Name = "opt12Month"
        Me.opt12Month.Size = New System.Drawing.Size(88, 24)
        Me.opt12Month.TabIndex = 6
        Me.opt12Month.Text = "12 เดือน"
        Me.opt12Month.UseVisualStyleBackColor = False
        '
        'opt6Month
        '
        Me.opt6Month.AutoSize = True
        Me.opt6Month.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.opt6Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt6Month.ForeColor = System.Drawing.Color.Black
        Me.opt6Month.Location = New System.Drawing.Point(184, 17)
        Me.opt6Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt6Month.Name = "opt6Month"
        Me.opt6Month.Size = New System.Drawing.Size(78, 24)
        Me.opt6Month.TabIndex = 5
        Me.opt6Month.Text = "6 เดือน"
        Me.opt6Month.UseVisualStyleBackColor = False
        '
        'opt3Month
        '
        Me.opt3Month.AutoSize = True
        Me.opt3Month.BackColor = System.Drawing.Color.YellowGreen
        Me.opt3Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt3Month.ForeColor = System.Drawing.Color.Black
        Me.opt3Month.Location = New System.Drawing.Point(98, 17)
        Me.opt3Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt3Month.Name = "opt3Month"
        Me.opt3Month.Size = New System.Drawing.Size(78, 24)
        Me.opt3Month.TabIndex = 4
        Me.opt3Month.Text = "3 เดือน"
        Me.opt3Month.UseVisualStyleBackColor = False
        '
        'opt1Month
        '
        Me.opt1Month.AutoSize = True
        Me.opt1Month.BackColor = System.Drawing.Color.Gold
        Me.opt1Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt1Month.ForeColor = System.Drawing.Color.Black
        Me.opt1Month.Location = New System.Drawing.Point(13, 17)
        Me.opt1Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt1Month.Name = "opt1Month"
        Me.opt1Month.Size = New System.Drawing.Size(78, 24)
        Me.opt1Month.TabIndex = 3
        Me.opt1Month.Text = "1 เดือน"
        Me.opt1Month.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.OliveDrab
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(663, 658)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(172, 46)
        Me.cmdPrint.TabIndex = 42
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'optSales
        '
        Me.optSales.AutoSize = True
        Me.optSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSales.Location = New System.Drawing.Point(11, 614)
        Me.optSales.Margin = New System.Windows.Forms.Padding(2)
        Me.optSales.Name = "optSales"
        Me.optSales.Size = New System.Drawing.Size(94, 24)
        Me.optSales.TabIndex = 44
        Me.optSales.Text = "ตามSales"
        Me.optSales.UseVisualStyleBackColor = True
        '
        'cboSales
        '
        Me.cboSales.BackColor = System.Drawing.Color.OliveDrab
        Me.cboSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSales.ForeColor = System.Drawing.Color.White
        Me.cboSales.FormattingEnabled = True
        Me.cboSales.Location = New System.Drawing.Point(100, 612)
        Me.cboSales.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSales.Name = "cboSales"
        Me.cboSales.Size = New System.Drawing.Size(229, 32)
        Me.cboSales.TabIndex = 45
        '
        'chkDocID
        '
        Me.chkDocID.AutoSize = True
        Me.chkDocID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkDocID.Location = New System.Drawing.Point(1102, 628)
        Me.chkDocID.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDocID.Name = "chkDocID"
        Me.chkDocID.Size = New System.Drawing.Size(139, 24)
        Me.chkDocID.TabIndex = 46
        Me.chkDocID.Text = "แสดงเลขที่เอกสาร"
        Me.chkDocID.UseVisualStyleBackColor = False
        Me.chkDocID.Visible = False
        '
        'chkGrpCus
        '
        Me.chkGrpCus.AutoSize = True
        Me.chkGrpCus.BackColor = System.Drawing.Color.LightBlue
        Me.chkGrpCus.Enabled = False
        Me.chkGrpCus.ForeColor = System.Drawing.Color.White
        Me.chkGrpCus.Location = New System.Drawing.Point(427, 646)
        Me.chkGrpCus.Margin = New System.Windows.Forms.Padding(2)
        Me.chkGrpCus.Name = "chkGrpCus"
        Me.chkGrpCus.Size = New System.Drawing.Size(153, 24)
        Me.chkGrpCus.TabIndex = 47
        Me.chkGrpCus.Text = "รวมยอดลูกค้าในกลุ่ม"
        Me.chkGrpCus.UseVisualStyleBackColor = False
        '
        'frmCusSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1255, 748)
        Me.Controls.Add(Me.chkGrpCus)
        Me.Controls.Add(Me.chkDocID)
        Me.Controls.Add(Me.cboSales)
        Me.Controls.Add(Me.optSales)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkNoSelDetail)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.optSelAR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbStrConnect)
        Me.Controls.Add(Me.lbStkName)
        Me.Controls.Add(Me.optSelStk)
        Me.Controls.Add(Me.lbFindStk)
        Me.Controls.Add(Me.lbStkCode)
        Me.Controls.Add(Me.chkPriceZero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbCusCode)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCusSA"
        Me.Text = "รางานวิเคราะห์การขายตามลูกค้า"
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lsvListCus As ListView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optSelName As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents optProfit As RadioButton
    Friend WithEvents optAmt As RadioButton
    Friend WithEvents optWeight As RadioButton
    Friend WithEvents optUnit As RadioButton
    Friend WithEvents lbStrConnect As Label
    Friend WithEvents lbTotalWeight As Label
    Friend WithEvents lbStkName As Label
    Friend WithEvents optSelStk As CheckBox
    Friend WithEvents lbFindStk As Label
    Friend WithEvents lbStkCode As Label
    Friend WithEvents chkPriceZero As CheckBox
    Friend WithEvents lbTotalCost As Label
    Friend WithEvents lsvShow As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSelPD As RadioButton
    Friend WithEvents optSelGPTT As RadioButton
    Friend WithEvents optSelGMB As RadioButton
    Friend WithEvents optSelTT As RadioButton
    Friend WithEvents optSelGP As RadioButton
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdRun As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents lbTotalProfit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTotalSales As Label

    Friend WithEvents optSelAR As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbCusName As Label
    Friend WithEvents lbCusCode As Label
    Friend WithEvents chkNoSelDetail As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbTotalQty As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbDate2 As Label
    Friend WithEvents optSelDay As RadioButton
    Friend WithEvents lbDate1 As Label
    Friend WithEvents txtDate01 As DateTimePicker
    Friend WithEvents txtDate02 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents opt12Month As RadioButton
    Friend WithEvents opt6Month As RadioButton
    Friend WithEvents opt3Month As RadioButton
    Friend WithEvents opt1Month As RadioButton
    Friend WithEvents optSelCusName As RadioButton
    Friend WithEvents cmdPrint As Button
    Friend WithEvents optSales As CheckBox
    Friend WithEvents cboSales As ComboBox
    Friend WithEvents chkDocID As CheckBox
    Friend WithEvents chkGrpCus As CheckBox
    Friend WithEvents optSelNPD As RadioButton
End Class
