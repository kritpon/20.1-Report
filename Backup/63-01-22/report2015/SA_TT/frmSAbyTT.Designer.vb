<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAbyTT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lsvSATT = New System.Windows.Forms.ListView()
        Me.cboSegment = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSelNPD = New System.Windows.Forms.RadioButton()
        Me.optSel2 = New System.Windows.Forms.RadioButton()
        Me.optSelGP = New System.Windows.Forms.RadioButton()
        Me.optSelTT = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chartStk = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lsvSaleSum = New System.Windows.Forms.ListView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dataShow = New System.Windows.Forms.DataGridView()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.optYear = New System.Windows.Forms.RadioButton()
        Me.lbDate2 = New System.Windows.Forms.Label()
        Me.optSelDay = New System.Windows.Forms.RadioButton()
        Me.lbDate1 = New System.Windows.Forms.Label()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.txtDate02 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.opt12Month = New System.Windows.Forms.RadioButton()
        Me.opt6Month = New System.Windows.Forms.RadioButton()
        Me.opt3Month = New System.Windows.Forms.RadioButton()
        Me.opt1Month = New System.Windows.Forms.RadioButton()
        Me.cboStkType = New System.Windows.Forms.ComboBox()
        Me.chkSales = New System.Windows.Forms.CheckBox()
        Me.cboSales = New System.Windows.Forms.ComboBox()
        Me.chkSegment = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkStkType = New System.Windows.Forms.CheckBox()
        Me.cmbTest = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.chartStk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvSATT
        '
        Me.lsvSATT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvSATT.FullRowSelect = True
        Me.lsvSATT.Location = New System.Drawing.Point(6, 6)
        Me.lsvSATT.Name = "lsvSATT"
        Me.lsvSATT.Size = New System.Drawing.Size(714, 378)
        Me.lsvSATT.TabIndex = 0
        Me.lsvSATT.UseCompatibleStateImageBehavior = False
        '
        'cboSegment
        '
        Me.cboSegment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSegment.FormattingEnabled = True
        Me.cboSegment.Location = New System.Drawing.Point(353, 13)
        Me.cboSegment.Name = "cboSegment"
        Me.cboSegment.Size = New System.Drawing.Size(221, 26)
        Me.cboSegment.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSelNPD)
        Me.GroupBox1.Controls.Add(Me.optSel2)
        Me.GroupBox1.Controls.Add(Me.optSelGP)
        Me.GroupBox1.Controls.Add(Me.optSelTT)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 467)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'optSelNPD
        '
        Me.optSelNPD.AutoSize = True
        Me.optSelNPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelNPD.ForeColor = System.Drawing.Color.White
        Me.optSelNPD.Location = New System.Drawing.Point(165, 14)
        Me.optSelNPD.Name = "optSelNPD"
        Me.optSelNPD.Size = New System.Drawing.Size(55, 21)
        Me.optSelNPD.TabIndex = 3
        Me.optSelNPD.Text = "NPD"
        Me.optSelNPD.UseVisualStyleBackColor = True
        '
        'optSel2
        '
        Me.optSel2.AutoSize = True
        Me.optSel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSel2.ForeColor = System.Drawing.Color.White
        Me.optSel2.Location = New System.Drawing.Point(236, 14)
        Me.optSel2.Name = "optSel2"
        Me.optSel2.Size = New System.Drawing.Size(78, 21)
        Me.optSel2.TabIndex = 2
        Me.optSel2.Text = "สินค้ารวม"
        Me.optSel2.UseVisualStyleBackColor = True
        '
        'optSelGP
        '
        Me.optSelGP.AutoSize = True
        Me.optSelGP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelGP.ForeColor = System.Drawing.Color.White
        Me.optSelGP.Location = New System.Drawing.Point(103, 14)
        Me.optSelGP.Name = "optSelGP"
        Me.optSelGP.Size = New System.Drawing.Size(46, 21)
        Me.optSelGP.TabIndex = 1
        Me.optSelGP.Text = "GP"
        Me.optSelGP.UseVisualStyleBackColor = True
        '
        'optSelTT
        '
        Me.optSelTT.AutoSize = True
        Me.optSelTT.Checked = True
        Me.optSelTT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelTT.ForeColor = System.Drawing.Color.White
        Me.optSelTT.Location = New System.Drawing.Point(9, 14)
        Me.optSelTT.Name = "optSelTT"
        Me.optSelTT.Size = New System.Drawing.Size(78, 21)
        Me.optSelTT.TabIndex = 0
        Me.optSelTT.TabStop = True
        Me.optSelTT.Text = "สินค้า TT"
        Me.optSelTT.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1256, 416)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chartStk)
        Me.TabPage1.Controls.Add(Me.lsvSATT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1248, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สินค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chartStk
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartStk.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartStk.Legends.Add(Legend1)
        Me.chartStk.Location = New System.Drawing.Point(726, 10)
        Me.chartStk.Name = "chartStk"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartStk.Series.Add(Series1)
        Me.chartStk.Size = New System.Drawing.Size(516, 374)
        Me.chartStk.TabIndex = 1
        Me.chartStk.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsvSaleSum)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1248, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ลูกค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsvSaleSum
        '
        Me.lsvSaleSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvSaleSum.FullRowSelect = True
        Me.lsvSaleSum.Location = New System.Drawing.Point(6, 6)
        Me.lsvSaleSum.Name = "lsvSaleSum"
        Me.lsvSaleSum.Size = New System.Drawing.Size(1236, 378)
        Me.lsvSaleSum.TabIndex = 1
        Me.lsvSaleSum.UseCompatibleStateImageBehavior = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1248, 390)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Segment"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(6, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1236, 378)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dataShow)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1248, 390)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "-"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dataShow
        '
        Me.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataShow.Location = New System.Drawing.Point(9, 10)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataShow.Size = New System.Drawing.Size(1236, 369)
        Me.dataShow.TabIndex = 0
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdRun.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdRun.Location = New System.Drawing.Point(1016, 427)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(112, 44)
        Me.cmdRun.TabIndex = 9
        Me.cmdRun.Text = "RUN"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmbExit.Location = New System.Drawing.Point(1016, 480)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(112, 44)
        Me.cmbExit.TabIndex = 10
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.optYear)
        Me.GroupBox4.Controls.Add(Me.lbDate2)
        Me.GroupBox4.Controls.Add(Me.optSelDay)
        Me.GroupBox4.Controls.Add(Me.lbDate1)
        Me.GroupBox4.Controls.Add(Me.txtDate01)
        Me.GroupBox4.Controls.Add(Me.txtDate02)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.opt12Month)
        Me.GroupBox4.Controls.Add(Me.opt6Month)
        Me.GroupBox4.Controls.Add(Me.opt3Month)
        Me.GroupBox4.Controls.Add(Me.opt1Month)
        Me.GroupBox4.Location = New System.Drawing.Point(594, 420)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(386, 180)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        '
        'optYear
        '
        Me.optYear.AutoSize = True
        Me.optYear.BackColor = System.Drawing.Color.MediumPurple
        Me.optYear.Checked = True
        Me.optYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optYear.ForeColor = System.Drawing.Color.White
        Me.optYear.Location = New System.Drawing.Point(13, 121)
        Me.optYear.Margin = New System.Windows.Forms.Padding(2)
        Me.optYear.Name = "optYear"
        Me.optYear.Size = New System.Drawing.Size(88, 24)
        Me.optYear.TabIndex = 27
        Me.optYear.TabStop = True
        Me.optYear.Text = "ข้อมูลทั้งปี"
        Me.optYear.UseVisualStyleBackColor = False
        '
        'lbDate2
        '
        Me.lbDate2.BackColor = System.Drawing.Color.Black
        Me.lbDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate2.ForeColor = System.Drawing.Color.Lime
        Me.lbDate2.Location = New System.Drawing.Point(246, 82)
        Me.lbDate2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbDate2.Name = "lbDate2"
        Me.lbDate2.Size = New System.Drawing.Size(120, 22)
        Me.lbDate2.TabIndex = 26
        Me.lbDate2.Text = "Label1"
        Me.lbDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optSelDay
        '
        Me.optSelDay.AutoSize = True
        Me.optSelDay.BackColor = System.Drawing.Color.MediumPurple
        Me.optSelDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelDay.ForeColor = System.Drawing.Color.White
        Me.optSelDay.Location = New System.Drawing.Point(13, 52)
        Me.optSelDay.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelDay.Name = "optSelDay"
        Me.optSelDay.Size = New System.Drawing.Size(66, 24)
        Me.optSelDay.TabIndex = 11
        Me.optSelDay.Text = "ระบุวัน"
        Me.optSelDay.UseVisualStyleBackColor = False
        '
        'lbDate1
        '
        Me.lbDate1.BackColor = System.Drawing.Color.Black
        Me.lbDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate1.ForeColor = System.Drawing.Color.Lime
        Me.lbDate1.Location = New System.Drawing.Point(98, 82)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ถึง"
        '
        'opt12Month
        '
        Me.opt12Month.AutoSize = True
        Me.opt12Month.BackColor = System.Drawing.Color.MediumPurple
        Me.opt12Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt12Month.ForeColor = System.Drawing.Color.White
        Me.opt12Month.Location = New System.Drawing.Point(270, 17)
        Me.opt12Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt12Month.Name = "opt12Month"
        Me.opt12Month.Size = New System.Drawing.Size(81, 24)
        Me.opt12Month.TabIndex = 6
        Me.opt12Month.Text = "12 เดือน"
        Me.opt12Month.UseVisualStyleBackColor = False
        '
        'opt6Month
        '
        Me.opt6Month.AutoSize = True
        Me.opt6Month.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.opt6Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt6Month.ForeColor = System.Drawing.Color.Black
        Me.opt6Month.Location = New System.Drawing.Point(184, 17)
        Me.opt6Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt6Month.Name = "opt6Month"
        Me.opt6Month.Size = New System.Drawing.Size(72, 24)
        Me.opt6Month.TabIndex = 5
        Me.opt6Month.Text = "6 เดือน"
        Me.opt6Month.UseVisualStyleBackColor = False
        '
        'opt3Month
        '
        Me.opt3Month.AutoSize = True
        Me.opt3Month.BackColor = System.Drawing.Color.YellowGreen
        Me.opt3Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt3Month.ForeColor = System.Drawing.Color.Black
        Me.opt3Month.Location = New System.Drawing.Point(98, 17)
        Me.opt3Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt3Month.Name = "opt3Month"
        Me.opt3Month.Size = New System.Drawing.Size(72, 24)
        Me.opt3Month.TabIndex = 4
        Me.opt3Month.Text = "3 เดือน"
        Me.opt3Month.UseVisualStyleBackColor = False
        '
        'opt1Month
        '
        Me.opt1Month.AutoSize = True
        Me.opt1Month.BackColor = System.Drawing.Color.Gold
        Me.opt1Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt1Month.ForeColor = System.Drawing.Color.Black
        Me.opt1Month.Location = New System.Drawing.Point(13, 17)
        Me.opt1Month.Margin = New System.Windows.Forms.Padding(2)
        Me.opt1Month.Name = "opt1Month"
        Me.opt1Month.Size = New System.Drawing.Size(72, 24)
        Me.opt1Month.TabIndex = 3
        Me.opt1Month.Text = "1 เดือน"
        Me.opt1Month.UseVisualStyleBackColor = False
        '
        'cboStkType
        '
        Me.cboStkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboStkType.FormattingEnabled = True
        Me.cboStkType.Location = New System.Drawing.Point(421, 481)
        Me.cboStkType.Name = "cboStkType"
        Me.cboStkType.Size = New System.Drawing.Size(160, 26)
        Me.cboStkType.TabIndex = 43
        '
        'chkSales
        '
        Me.chkSales.AutoSize = True
        Me.chkSales.ForeColor = System.Drawing.Color.White
        Me.chkSales.Location = New System.Drawing.Point(6, 18)
        Me.chkSales.Name = "chkSales"
        Me.chkSales.Size = New System.Drawing.Size(85, 17)
        Me.chkSales.TabIndex = 45
        Me.chkSales.Text = "พนักงานขาย"
        Me.chkSales.UseVisualStyleBackColor = True
        '
        'cboSales
        '
        Me.cboSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSales.FormattingEnabled = True
        Me.cboSales.Location = New System.Drawing.Point(89, 13)
        Me.cboSales.Name = "cboSales"
        Me.cboSales.Size = New System.Drawing.Size(167, 26)
        Me.cboSales.TabIndex = 46
        '
        'chkSegment
        '
        Me.chkSegment.AutoSize = True
        Me.chkSegment.ForeColor = System.Drawing.Color.White
        Me.chkSegment.Location = New System.Drawing.Point(284, 18)
        Me.chkSegment.Name = "chkSegment"
        Me.chkSegment.Size = New System.Drawing.Size(68, 17)
        Me.chkSegment.TabIndex = 47
        Me.chkSegment.Text = "Segment"
        Me.chkSegment.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboSales)
        Me.GroupBox2.Controls.Add(Me.chkSegment)
        Me.GroupBox2.Controls.Add(Me.cboSegment)
        Me.GroupBox2.Controls.Add(Me.chkSales)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 421)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 46)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'chkStkType
        '
        Me.chkStkType.AutoSize = True
        Me.chkStkType.Checked = True
        Me.chkStkType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStkType.ForeColor = System.Drawing.Color.White
        Me.chkStkType.Location = New System.Drawing.Point(333, 487)
        Me.chkStkType.Name = "chkStkType"
        Me.chkStkType.Size = New System.Drawing.Size(89, 17)
        Me.chkStkType.TabIndex = 48
        Me.chkStkType.Text = "ประเภทสินค้า"
        Me.chkStkType.UseVisualStyleBackColor = True
        '
        'cmbTest
        '
        Me.cmbTest.BackColor = System.Drawing.Color.Teal
        Me.cmbTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbTest.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cmbTest.Location = New System.Drawing.Point(1016, 541)
        Me.cmbTest.Name = "cmbTest"
        Me.cmbTest.Size = New System.Drawing.Size(112, 44)
        Me.cmbTest.TabIndex = 49
        Me.cmbTest.Text = "ทดสอบ"
        Me.cmbTest.UseVisualStyleBackColor = False
        '
        'frmSAbyTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(1271, 612)
        Me.Controls.Add(Me.cmbTest)
        Me.Controls.Add(Me.cboStkType)
        Me.Controls.Add(Me.chkStkType)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSAbyTT"
        Me.Text = "frmSAbyTT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.chartStk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvSATT As ListView
    Friend WithEvents cboSegment As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSel2 As RadioButton
    Friend WithEvents optSelGP As RadioButton
    Friend WithEvents optSelTT As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lsvSaleSum As ListView
    Friend WithEvents cmdRun As Button
    Friend WithEvents optSelNPD As RadioButton
    Friend WithEvents cmbExit As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbDate2 As Label
    Friend WithEvents optSelDay As RadioButton
    Friend WithEvents lbDate1 As Label
    Friend WithEvents txtDate01 As DateTimePicker
    Friend WithEvents txtDate02 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents opt12Month As RadioButton
    Friend WithEvents opt6Month As RadioButton
    Friend WithEvents opt3Month As RadioButton
    Friend WithEvents opt1Month As RadioButton
    Friend WithEvents chartStk As DataVisualization.Charting.Chart
    Friend WithEvents cboStkType As ComboBox
    Friend WithEvents chkSales As CheckBox
    Friend WithEvents cboSales As ComboBox
    Friend WithEvents chkSegment As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkStkType As CheckBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dataShow As DataGridView
    Friend WithEvents cmbTest As Button
    Friend WithEvents optYear As RadioButton
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListView1 As ListView
End Class
