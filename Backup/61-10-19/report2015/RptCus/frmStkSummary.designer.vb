<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStkSummary
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSelPD = New System.Windows.Forms.RadioButton()
        Me.optSelAll = New System.Windows.Forms.RadioButton()
        Me.optSelGMB = New System.Windows.Forms.RadioButton()
        Me.optSelTT = New System.Windows.Forms.RadioButton()
        Me.optSelGP = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotalQty = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTotalWeight = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbTotalCost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbTotalProfit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotalSales = New System.Windows.Forms.Label()
        Me.lsvShow = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lsvStkSum = New System.Windows.Forms.ListView()
        Me.lbStrConnect = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optSelName = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optProfit = New System.Windows.Forms.RadioButton()
        Me.optAmt = New System.Windows.Forms.RadioButton()
        Me.optWeight = New System.Windows.Forms.RadioButton()
        Me.optUnit = New System.Windows.Forms.RadioButton()
        Me.lbStkName = New System.Windows.Forms.Label()
        Me.optStk = New System.Windows.Forms.CheckBox()
        Me.lbFindStk = New System.Windows.Forms.Label()
        Me.lbStkCode = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkPriceZero = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdRun.ForeColor = System.Drawing.Color.White
        Me.cmdRun.Location = New System.Drawing.Point(868, 656)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(172, 46)
        Me.cmdRun.TabIndex = 6
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.DarkRed
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(1056, 656)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(172, 46)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSelPD)
        Me.GroupBox1.Controls.Add(Me.optSelAll)
        Me.GroupBox1.Controls.Add(Me.optSelGMB)
        Me.GroupBox1.Controls.Add(Me.optSelTT)
        Me.GroupBox1.Controls.Add(Me.optSelGP)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 574)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(482, 56)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'optSelPD
        '
        Me.optSelPD.AutoSize = True
        Me.optSelPD.Location = New System.Drawing.Point(261, 22)
        Me.optSelPD.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelPD.Name = "optSelPD"
        Me.optSelPD.Size = New System.Drawing.Size(49, 24)
        Me.optSelPD.TabIndex = 4
        Me.optSelPD.Text = "PD"
        Me.optSelPD.UseVisualStyleBackColor = True
        '
        'optSelAll
        '
        Me.optSelAll.AutoSize = True
        Me.optSelAll.Location = New System.Drawing.Point(337, 22)
        Me.optSelAll.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelAll.Name = "optSelAll"
        Me.optSelAll.Size = New System.Drawing.Size(77, 24)
        Me.optSelAll.TabIndex = 3
        Me.optSelAll.Text = "GP+TT"
        Me.optSelAll.UseVisualStyleBackColor = True
        '
        'optSelGMB
        '
        Me.optSelGMB.AutoSize = True
        Me.optSelGMB.Location = New System.Drawing.Point(172, 22)
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
        Me.optSelTT.Location = New System.Drawing.Point(92, 22)
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
        Me.optSelGP.Location = New System.Drawing.Point(14, 22)
        Me.optSelGP.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelGP.Name = "optSelGP"
        Me.optSelGP.Size = New System.Drawing.Size(50, 24)
        Me.optSelGP.TabIndex = 0
        Me.optSelGP.TabStop = True
        Me.optSelGP.Text = "GP"
        Me.optSelGP.UseVisualStyleBackColor = True
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
        Me.TabControl1.Size = New System.Drawing.Size(1345, 511)
        Me.TabControl1.TabIndex = 10
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
        Me.TabPage1.Size = New System.Drawing.Size(1337, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 442)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 33)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "จำนวนรวม"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalQty
        '
        Me.lbTotalQty.BackColor = System.Drawing.Color.Black
        Me.lbTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalQty.ForeColor = System.Drawing.Color.White
        Me.lbTotalQty.Location = New System.Drawing.Point(104, 442)
        Me.lbTotalQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalQty.Name = "lbTotalQty"
        Me.lbTotalQty.Size = New System.Drawing.Size(136, 33)
        Me.lbTotalQty.TabIndex = 9
        Me.lbTotalQty.Text = "0"
        Me.lbTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(258, 442)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 33)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "น้ำหนักรวม"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalWeight
        '
        Me.lbTotalWeight.BackColor = System.Drawing.Color.Black
        Me.lbTotalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalWeight.ForeColor = System.Drawing.Color.White
        Me.lbTotalWeight.Location = New System.Drawing.Point(356, 442)
        Me.lbTotalWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalWeight.Name = "lbTotalWeight"
        Me.lbTotalWeight.Size = New System.Drawing.Size(136, 33)
        Me.lbTotalWeight.TabIndex = 7
        Me.lbTotalWeight.Text = "0"
        Me.lbTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(492, 442)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 33)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "มูลค่าทุนรวม"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalCost
        '
        Me.lbTotalCost.BackColor = System.Drawing.Color.Black
        Me.lbTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalCost.ForeColor = System.Drawing.Color.White
        Me.lbTotalCost.Location = New System.Drawing.Point(600, 442)
        Me.lbTotalCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalCost.Name = "lbTotalCost"
        Me.lbTotalCost.Size = New System.Drawing.Size(136, 33)
        Me.lbTotalCost.TabIndex = 5
        Me.lbTotalCost.Text = "0"
        Me.lbTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(999, 442)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 33)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "กำไรรวม"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalProfit
        '
        Me.lbTotalProfit.BackColor = System.Drawing.Color.Black
        Me.lbTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit.ForeColor = System.Drawing.Color.White
        Me.lbTotalProfit.Location = New System.Drawing.Point(1078, 442)
        Me.lbTotalProfit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalProfit.Name = "lbTotalProfit"
        Me.lbTotalProfit.Size = New System.Drawing.Size(136, 33)
        Me.lbTotalProfit.TabIndex = 3
        Me.lbTotalProfit.Text = "0"
        Me.lbTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(743, 442)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 33)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "มูลค่าขายรวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalSales
        '
        Me.lbTotalSales.BackColor = System.Drawing.Color.Black
        Me.lbTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalSales.ForeColor = System.Drawing.Color.White
        Me.lbTotalSales.Location = New System.Drawing.Point(854, 442)
        Me.lbTotalSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalSales.Name = "lbTotalSales"
        Me.lbTotalSales.Size = New System.Drawing.Size(136, 33)
        Me.lbTotalSales.TabIndex = 1
        Me.lbTotalSales.Text = "0"
        Me.lbTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsvShow
        '
        Me.lsvShow.BackColor = System.Drawing.Color.Cornsilk
        Me.lsvShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvShow.FullRowSelect = True
        Me.lsvShow.GridLines = True
        Me.lsvShow.Location = New System.Drawing.Point(6, 8)
        Me.lsvShow.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvShow.Name = "lsvShow"
        Me.lsvShow.Size = New System.Drawing.Size(1214, 426)
        Me.lsvShow.TabIndex = 0
        Me.lsvShow.UseCompatibleStateImageBehavior = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Controls.Add(Me.lsvStkSum)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1337, 478)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chart"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(4, 8)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1080, 460)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'lsvStkSum
        '
        Me.lsvStkSum.Location = New System.Drawing.Point(1086, 2)
        Me.lsvStkSum.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvStkSum.Name = "lsvStkSum"
        Me.lsvStkSum.Size = New System.Drawing.Size(246, 468)
        Me.lsvStkSum.TabIndex = 0
        Me.lsvStkSum.UseCompatibleStateImageBehavior = False
        '
        'lbStrConnect
        '
        Me.lbStrConnect.AutoSize = True
        Me.lbStrConnect.BackColor = System.Drawing.Color.Gold
        Me.lbStrConnect.Location = New System.Drawing.Point(10, 718)
        Me.lbStrConnect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStrConnect.Name = "lbStrConnect"
        Me.lbStrConnect.Size = New System.Drawing.Size(57, 20)
        Me.lbStrConnect.TabIndex = 11
        Me.lbStrConnect.Text = "Label3"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optSelName)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.optProfit)
        Me.GroupBox3.Controls.Add(Me.optAmt)
        Me.GroupBox3.Controls.Add(Me.optWeight)
        Me.GroupBox3.Controls.Add(Me.optUnit)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 520)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(720, 56)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'optSelName
        '
        Me.optSelName.AutoSize = True
        Me.optSelName.Location = New System.Drawing.Point(602, 24)
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
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ลำดับตาม"
        '
        'optProfit
        '
        Me.optProfit.AutoSize = True
        Me.optProfit.Location = New System.Drawing.Point(492, 24)
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
        Me.optAmt.Location = New System.Drawing.Point(390, 24)
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
        Me.optWeight.Location = New System.Drawing.Point(288, 24)
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
        Me.optUnit.Location = New System.Drawing.Point(153, 24)
        Me.optUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.optUnit.Name = "optUnit"
        Me.optUnit.Size = New System.Drawing.Size(109, 24)
        Me.optUnit.TabIndex = 0
        Me.optUnit.Text = "จำนวนหน่วย"
        Me.optUnit.UseVisualStyleBackColor = True
        '
        'lbStkName
        '
        Me.lbStkName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkName.Location = New System.Drawing.Point(95, 638)
        Me.lbStkName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkName.Name = "lbStkName"
        Me.lbStkName.Size = New System.Drawing.Size(358, 25)
        Me.lbStkName.TabIndex = 19
        '
        'optStk
        '
        Me.optStk.AutoSize = True
        Me.optStk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optStk.Location = New System.Drawing.Point(10, 640)
        Me.optStk.Margin = New System.Windows.Forms.Padding(2)
        Me.optStk.Name = "optStk"
        Me.optStk.Size = New System.Drawing.Size(87, 24)
        Me.optStk.TabIndex = 20
        Me.optStk.Text = "ตามสินค้า"
        Me.optStk.UseVisualStyleBackColor = True
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbFindStk.Location = New System.Drawing.Point(456, 638)
        Me.lbFindStk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(34, 25)
        Me.lbFindStk.TabIndex = 18
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbStkCode.Location = New System.Drawing.Point(95, 638)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(358, 25)
        Me.lbStkCode.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'chkPriceZero
        '
        Me.chkPriceZero.AutoSize = True
        Me.chkPriceZero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkPriceZero.Location = New System.Drawing.Point(10, 678)
        Me.chkPriceZero.Margin = New System.Windows.Forms.Padding(2)
        Me.chkPriceZero.Name = "chkPriceZero"
        Me.chkPriceZero.Size = New System.Drawing.Size(313, 24)
        Me.chkPriceZero.TabIndex = 22
        Me.chkPriceZero.Text = "ตัดยอดสินค้าราคาเป็น 0 บาท (ของแถม,ของคืน)"
        Me.chkPriceZero.UseVisualStyleBackColor = False
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
        Me.GroupBox4.Location = New System.Drawing.Point(856, 520)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(382, 124)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'lbDate2
        '
        Me.lbDate2.BackColor = System.Drawing.Color.Black
        Me.lbDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate2.ForeColor = System.Drawing.Color.Lime
        Me.lbDate2.Location = New System.Drawing.Point(246, 90)
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
        Me.optSelDay.Location = New System.Drawing.Point(13, 57)
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
        Me.lbDate1.Location = New System.Drawing.Point(98, 90)
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
        Me.txtDate01.Location = New System.Drawing.Point(98, 55)
        Me.txtDate01.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(120, 26)
        Me.txtDate01.TabIndex = 7
        '
        'txtDate02
        '
        Me.txtDate02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDate02.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate02.Location = New System.Drawing.Point(246, 56)
        Me.txtDate02.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate02.Name = "txtDate02"
        Me.txtDate02.Size = New System.Drawing.Size(120, 26)
        Me.txtDate02.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 60)
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
        Me.opt12Month.Location = New System.Drawing.Point(270, 22)
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
        Me.opt6Month.Location = New System.Drawing.Point(184, 22)
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
        Me.opt3Month.Location = New System.Drawing.Point(98, 22)
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
        Me.opt1Month.Location = New System.Drawing.Point(13, 22)
        Me.opt1Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt1Month.Name = "opt1Month"
        Me.opt1Month.Size = New System.Drawing.Size(78, 24)
        Me.opt1Month.TabIndex = 3
        Me.opt1Month.Text = "1 เดือน"
        Me.opt1Month.UseVisualStyleBackColor = False
        '
        'frmStkSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1285, 749)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chkPriceZero)
        Me.Controls.Add(Me.lbStkName)
        Me.Controls.Add(Me.optStk)
        Me.Controls.Add(Me.lbFindStk)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbStrConnect)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.lbStkCode)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmStkSummary"
        Me.Text = "รายงานตามสินค้า"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdRun As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSelAll As RadioButton
    Friend WithEvents optSelGMB As RadioButton
    Friend WithEvents optSelTT As RadioButton
    Friend WithEvents optSelGP As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lsvShow As ListView
    Friend WithEvents lbStrConnect As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents optProfit As RadioButton
    Friend WithEvents optAmt As RadioButton
    Friend WithEvents optWeight As RadioButton
    Friend WithEvents optUnit As RadioButton
    Friend WithEvents optSelPD As RadioButton
    Friend WithEvents lbStkName As Label
    Friend WithEvents optStk As CheckBox
    Friend WithEvents lbFindStk As Label
    Friend WithEvents lbStkCode As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents optSelName As RadioButton
    Friend WithEvents lbTotalSales As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbTotalCost As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbTotalProfit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkPriceZero As CheckBox
    Friend WithEvents lsvStkSum As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTotalWeight As Label
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
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
