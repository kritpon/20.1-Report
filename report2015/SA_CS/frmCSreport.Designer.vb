<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCSreport
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lsvGreen = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCSname = New System.Windows.Forms.Label()
        Me.lbCScode = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optZone = New System.Windows.Forms.RadioButton()
        Me.optOrdSumSales = New System.Windows.Forms.RadioButton()
        Me.optOrdLastDate = New System.Windows.Forms.RadioButton()
        Me.optOrdTarget = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUpdate = New System.Windows.Forms.Button()
        Me.lbCountItem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTotalAmt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotalTarget = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbDifAmt = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chartYear = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chartAct = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.opt_Profit = New System.Windows.Forms.RadioButton()
        Me.opt_Sales = New System.Windows.Forms.RadioButton()
        Me.lbTarget_GPWeight = New System.Windows.Forms.Label()
        Me.lbTarget_TTProfit = New System.Windows.Forms.Label()
        Me.lbTarget_TT = New System.Windows.Forms.Label()
        Me.lbTarget_Sales = New System.Windows.Forms.Label()
        Me.lbTarget_GPProfit = New System.Windows.Forms.Label()
        Me.lbTarget_Profit = New System.Windows.Forms.Label()
        Me.lbTarget_GP = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbRatioAct_GPWeight = New System.Windows.Forms.Label()
        Me.lbRatioAct_TTProfit = New System.Windows.Forms.Label()
        Me.lbRatioAct_TT = New System.Windows.Forms.Label()
        Me.lbRatioAct_Sales = New System.Windows.Forms.Label()
        Me.lbRatioAct_GPProFit = New System.Windows.Forms.Label()
        Me.lbRatioAct_Profit = New System.Windows.Forms.Label()
        Me.lbRatioAct_GP = New System.Windows.Forms.Label()
        Me.lbAct_GPweight = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbAct_TTProfit = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbAct_TT = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbAct_Sales = New System.Windows.Forms.Label()
        Me.lbAct_GPProfit = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbAct_Profit = New System.Windows.Forms.Label()
        Me.lbAct_GP = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbDayQty = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbRatioDiff_GPWeight = New System.Windows.Forms.Label()
        Me.lbRatioDiff_TTProfit = New System.Windows.Forms.Label()
        Me.lbRatioDiff_TT = New System.Windows.Forms.Label()
        Me.lbRatioDiff_Sales = New System.Windows.Forms.Label()
        Me.lbRatioDiff_GPProfit = New System.Windows.Forms.Label()
        Me.lbRatioDiff_Profit = New System.Windows.Forms.Label()
        Me.lbRatioDiff_GP = New System.Windows.Forms.Label()
        Me.lbDiff_TargetGPWeight = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbDiff_TargetTTProfit = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbDiff_TargetTT = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lbDiff_TargetSales = New System.Windows.Forms.Label()
        Me.lbDiff_TargetGPPrifit = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lbDiff_TargetProfit = New System.Windows.Forms.Label()
        Me.lbDiff_TargetGP = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbActDay = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbSim_GPWeight = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbSim_TTProfit = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lbSim_TT = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lbSim_Target = New System.Windows.Forms.Label()
        Me.lbSim_GPProfit = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lbSim_Profit = New System.Windows.Forms.Label()
        Me.lbSim_GPtarget = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbDayQty0 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lbRatioPerf_GPWeight = New System.Windows.Forms.Label()
        Me.lbRatioPerf_TTProfit = New System.Windows.Forms.Label()
        Me.lbRatioPerf_TT = New System.Windows.Forms.Label()
        Me.lbRatioPerf_Sales = New System.Windows.Forms.Label()
        Me.lbRatioPerf_GPProfit = New System.Windows.Forms.Label()
        Me.lbRatioPerf_Profit = New System.Windows.Forms.Label()
        Me.lbRatioPerf_GP = New System.Windows.Forms.Label()
        Me.lbPerf_GPWeight = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lbPerf_TTProfit = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lbPerf_TT = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lbPerf_Sales = New System.Windows.Forms.Label()
        Me.lbPerf_GPProfit = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.lbPerf_Profit = New System.Windows.Forms.Label()
        Me.lbPerf_GP = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.lbRatio_CusItem6M = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.lbCusItem6M = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.lbCusItem = New System.Windows.Forms.Label()
        Me.lbCusItem1M = New System.Windows.Forms.Label()
        Me.lbRatio_CusItem0 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.lbRatio_CusItem2M = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.lbRatio_CusItem1M = New System.Windows.Forms.Label()
        Me.lbCusItem2M = New System.Windows.Forms.Label()
        Me.lbRatio_CusItem = New System.Windows.Forms.Label()
        Me.chartCusItem = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.lbCusItem0 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lbSLRatio_Sales = New System.Windows.Forms.Label()
        Me.lbSLRatio_GPWeight = New System.Windows.Forms.Label()
        Me.lbSLRatio_TTProfti = New System.Windows.Forms.Label()
        Me.lbSLRatio_TT = New System.Windows.Forms.Label()
        Me.lbSLRatio_GPProfit = New System.Windows.Forms.Label()
        Me.lbSLRatio_Profit = New System.Windows.Forms.Label()
        Me.lbSLRatio_GP = New System.Windows.Forms.Label()
        Me.lbDaily_Sales = New System.Windows.Forms.Label()
        Me.lbDaily_GPWeight = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbDaily_TTProfit = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.lbDaily_TT = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.lbDaily_GPProfit = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.lbDaily_Profit = New System.Windows.Forms.Label()
        Me.lbDaily_GP = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lbOrRatio_GPWeight = New System.Windows.Forms.Label()
        Me.lbOrRatio_TTProfit = New System.Windows.Forms.Label()
        Me.lbOrRatio_TT = New System.Windows.Forms.Label()
        Me.lbOrRatio_Sales = New System.Windows.Forms.Label()
        Me.lbOrRatio_GPProfit = New System.Windows.Forms.Label()
        Me.lbOrRatio_Profit = New System.Windows.Forms.Label()
        Me.lbOrRatio_GP = New System.Windows.Forms.Label()
        Me.lbOrder_GPWeight = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lbOrder_TTProfit = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lbOrder_TT = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lbOrder_Sales = New System.Windows.Forms.Label()
        Me.lbOrder_GPProfit = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.lbOrder_Profit = New System.Windows.Forms.Label()
        Me.lbOrder_GP = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbStd_GPWeight = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbStd_TTProfit = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lbStd_TT = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lbStd_Sales = New System.Windows.Forms.Label()
        Me.lbStd_GPProfit = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lbStd_Profit = New System.Windows.Forms.Label()
        Me.lbStd_GP = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.lsvYellow = New System.Windows.Forms.ListView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lsvOrang = New System.Windows.Forms.ListView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lsvRed = New System.Windows.Forms.ListView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lbCusTotal = New System.Windows.Forms.Label()
        Me.lbcustotalStr = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lbCusRedQty = New System.Windows.Forms.Label()
        Me.lbCusOrangQty = New System.Windows.Forms.Label()
        Me.lbCusYellowQty = New System.Windows.Forms.Label()
        Me.lbCusGreenQty = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chartCusActive = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chk0 = New System.Windows.Forms.RadioButton()
        Me.chk100 = New System.Windows.Forms.RadioButton()
        Me.cmbRptDetl = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chartYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.chartAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.chartCusItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.chartCusActive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvGreen
        '
        Me.lsvGreen.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lsvGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvGreen.FullRowSelect = True
        Me.lsvGreen.HideSelection = False
        Me.lsvGreen.Location = New System.Drawing.Point(6, 6)
        Me.lsvGreen.Name = "lsvGreen"
        Me.lsvGreen.Size = New System.Drawing.Size(1267, 458)
        Me.lsvGreen.TabIndex = 0
        Me.lsvGreen.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อ"
        '
        'lbCSname
        '
        Me.lbCSname.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCSname.Location = New System.Drawing.Point(94, 9)
        Me.lbCSname.Name = "lbCSname"
        Me.lbCSname.Size = New System.Drawing.Size(148, 21)
        Me.lbCSname.TabIndex = 2
        Me.lbCSname.Text = "lbCSname"
        '
        'lbCScode
        '
        Me.lbCScode.BackColor = System.Drawing.Color.OliveDrab
        Me.lbCScode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCScode.Location = New System.Drawing.Point(246, 9)
        Me.lbCScode.Name = "lbCScode"
        Me.lbCScode.Size = New System.Drawing.Size(74, 21)
        Me.lbCScode.TabIndex = 3
        Me.lbCScode.Text = "lbCScode"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Maroon
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(644, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(115, 39)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optZone)
        Me.GroupBox1.Controls.Add(Me.optOrdSumSales)
        Me.GroupBox1.Controls.Add(Me.optOrdLastDate)
        Me.GroupBox1.Controls.Add(Me.optOrdTarget)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 470)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'optZone
        '
        Me.optZone.AutoSize = True
        Me.optZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optZone.Location = New System.Drawing.Point(352, 17)
        Me.optZone.Name = "optZone"
        Me.optZone.Size = New System.Drawing.Size(89, 22)
        Me.optZone.TabIndex = 7
        Me.optZone.Text = "เขตการขาย"
        Me.optZone.UseVisualStyleBackColor = True
        '
        'optOrdSumSales
        '
        Me.optOrdSumSales.AutoSize = True
        Me.optOrdSumSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdSumSales.Location = New System.Drawing.Point(150, 17)
        Me.optOrdSumSales.Name = "optOrdSumSales"
        Me.optOrdSumSales.Size = New System.Drawing.Size(95, 22)
        Me.optOrdSumSales.TabIndex = 6
        Me.optOrdSumSales.Text = "ยอดขายรวม"
        Me.optOrdSumSales.UseVisualStyleBackColor = True
        '
        'optOrdLastDate
        '
        Me.optOrdLastDate.AutoSize = True
        Me.optOrdLastDate.Checked = True
        Me.optOrdLastDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdLastDate.Location = New System.Drawing.Point(249, 17)
        Me.optOrdLastDate.Name = "optOrdLastDate"
        Me.optOrdLastDate.Size = New System.Drawing.Size(97, 22)
        Me.optOrdLastDate.TabIndex = 5
        Me.optOrdLastDate.TabStop = True
        Me.optOrdLastDate.Text = "วันที่ซื้อล่าสุด"
        Me.optOrdLastDate.UseVisualStyleBackColor = True
        '
        'optOrdTarget
        '
        Me.optOrdTarget.AutoSize = True
        Me.optOrdTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdTarget.Location = New System.Drawing.Point(53, 17)
        Me.optOrdTarget.Name = "optOrdTarget"
        Me.optOrdTarget.Size = New System.Drawing.Size(95, 22)
        Me.optOrdTarget.TabIndex = 4
        Me.optOrdTarget.Text = "ตาม Target"
        Me.optOrdTarget.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ลำดับ"
        '
        'cmbUpdate
        '
        Me.cmbUpdate.BackColor = System.Drawing.Color.Yellow
        Me.cmbUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbUpdate.ForeColor = System.Drawing.Color.Black
        Me.cmbUpdate.Location = New System.Drawing.Point(523, 6)
        Me.cmbUpdate.Name = "cmbUpdate"
        Me.cmbUpdate.Size = New System.Drawing.Size(115, 39)
        Me.cmbUpdate.TabIndex = 6
        Me.cmbUpdate.Text = "update"
        Me.cmbUpdate.UseVisualStyleBackColor = False
        '
        'lbCountItem
        '
        Me.lbCountItem.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCountItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCountItem.Location = New System.Drawing.Point(64, 537)
        Me.lbCountItem.Name = "lbCountItem"
        Me.lbCountItem.Size = New System.Drawing.Size(76, 28)
        Me.lbCountItem.TabIndex = 7
        Me.lbCountItem.Text = "Label2"
        Me.lbCountItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 546)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "จำนวน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 544)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ขายรวม"
        '
        'lbTotalAmt
        '
        Me.lbTotalAmt.BackColor = System.Drawing.Color.YellowGreen
        Me.lbTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalAmt.Location = New System.Drawing.Point(430, 537)
        Me.lbTotalAmt.Name = "lbTotalAmt"
        Me.lbTotalAmt.Size = New System.Drawing.Size(148, 28)
        Me.lbTotalAmt.TabIndex = 9
        Me.lbTotalAmt.Text = "Label2"
        Me.lbTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 544)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "เป้า-ขาย"
        '
        'lbTotalTarget
        '
        Me.lbTotalTarget.BackColor = System.Drawing.Color.YellowGreen
        Me.lbTotalTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalTarget.Location = New System.Drawing.Point(215, 537)
        Me.lbTotalTarget.Name = "lbTotalTarget"
        Me.lbTotalTarget.Size = New System.Drawing.Size(148, 28)
        Me.lbTotalTarget.TabIndex = 11
        Me.lbTotalTarget.Text = "Label2"
        Me.lbTotalTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(586, 542)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Diff"
        '
        'lbDifAmt
        '
        Me.lbDifAmt.BackColor = System.Drawing.Color.YellowGreen
        Me.lbDifAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDifAmt.Location = New System.Drawing.Point(621, 537)
        Me.lbDifAmt.Name = "lbDifAmt"
        Me.lbDifAmt.Size = New System.Drawing.Size(148, 28)
        Me.lbDifAmt.TabIndex = 13
        Me.lbDifAmt.Text = "Label2"
        Me.lbDifAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chartYear)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 167)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ปี"
        '
        'chartYear
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartYear.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartYear.Legends.Add(Legend1)
        Me.chartYear.Location = New System.Drawing.Point(5, 17)
        Me.chartYear.Name = "chartYear"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartYear.Series.Add(Series1)
        Me.chartYear.Size = New System.Drawing.Size(259, 144)
        Me.chartYear.TabIndex = 24
        Me.chartYear.Text = "Chart1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chartAct)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 168)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เดือนนี้"
        '
        'chartAct
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartAct.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartAct.Legends.Add(Legend2)
        Me.chartAct.Location = New System.Drawing.Point(6, 17)
        Me.chartAct.Name = "chartAct"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartAct.Series.Add(Series2)
        Me.chartAct.Size = New System.Drawing.Size(265, 144)
        Me.chartAct.TabIndex = 25
        Me.chartAct.Text = "Chart2"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton6)
        Me.GroupBox4.Controls.Add(Me.RadioButton5)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.opt_Profit)
        Me.GroupBox4.Controls.Add(Me.opt_Sales)
        Me.GroupBox4.Controls.Add(Me.lbTarget_GPWeight)
        Me.GroupBox4.Controls.Add(Me.lbTarget_TTProfit)
        Me.GroupBox4.Controls.Add(Me.lbTarget_TT)
        Me.GroupBox4.Controls.Add(Me.lbTarget_Sales)
        Me.GroupBox4.Controls.Add(Me.lbTarget_GPProfit)
        Me.GroupBox4.Controls.Add(Me.lbTarget_Profit)
        Me.GroupBox4.Controls.Add(Me.lbTarget_GP)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(275, 219)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Target"
        '
        'RadioButton6
        '
        Me.RadioButton6.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(9, 184)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton6.TabIndex = 57
        Me.RadioButton6.Text = "เป้า-กำไร TT"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(9, 156)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton5.TabIndex = 56
        Me.RadioButton5.Text = "เป้า-ขาย TT"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(9, 128)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton4.TabIndex = 55
        Me.RadioButton4.Text = "เป้า-น้ำหนัก GP"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(9, 100)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton2.TabIndex = 53
        Me.RadioButton2.Text = "เป้า-กำไร GP"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(9, 72)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(120, 21)
        Me.RadioButton1.TabIndex = 52
        Me.RadioButton1.Text = "เป้า-ขาย GP"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'opt_Profit
        '
        Me.opt_Profit.BackColor = System.Drawing.Color.DarkGray
        Me.opt_Profit.Checked = True
        Me.opt_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt_Profit.Location = New System.Drawing.Point(9, 44)
        Me.opt_Profit.Name = "opt_Profit"
        Me.opt_Profit.Size = New System.Drawing.Size(120, 21)
        Me.opt_Profit.TabIndex = 51
        Me.opt_Profit.TabStop = True
        Me.opt_Profit.Text = "เป้า-กำไรรวม"
        Me.opt_Profit.UseVisualStyleBackColor = False
        '
        'opt_Sales
        '
        Me.opt_Sales.BackColor = System.Drawing.Color.DarkGray
        Me.opt_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.opt_Sales.Location = New System.Drawing.Point(9, 16)
        Me.opt_Sales.Name = "opt_Sales"
        Me.opt_Sales.Size = New System.Drawing.Size(120, 21)
        Me.opt_Sales.TabIndex = 50
        Me.opt_Sales.Text = "เป้า-ขายรวม"
        Me.opt_Sales.UseVisualStyleBackColor = False
        '
        'lbTarget_GPWeight
        '
        Me.lbTarget_GPWeight.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_GPWeight.Location = New System.Drawing.Point(135, 128)
        Me.lbTarget_GPWeight.Name = "lbTarget_GPWeight"
        Me.lbTarget_GPWeight.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_GPWeight.TabIndex = 33
        Me.lbTarget_GPWeight.Text = "0"
        Me.lbTarget_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_TTProfit
        '
        Me.lbTarget_TTProfit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_TTProfit.Location = New System.Drawing.Point(135, 184)
        Me.lbTarget_TTProfit.Name = "lbTarget_TTProfit"
        Me.lbTarget_TTProfit.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_TTProfit.TabIndex = 31
        Me.lbTarget_TTProfit.Text = "0"
        Me.lbTarget_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_TT
        '
        Me.lbTarget_TT.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_TT.Location = New System.Drawing.Point(135, 156)
        Me.lbTarget_TT.Name = "lbTarget_TT"
        Me.lbTarget_TT.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_TT.TabIndex = 29
        Me.lbTarget_TT.Text = "0"
        Me.lbTarget_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_Sales
        '
        Me.lbTarget_Sales.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_Sales.Location = New System.Drawing.Point(135, 16)
        Me.lbTarget_Sales.Name = "lbTarget_Sales"
        Me.lbTarget_Sales.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_Sales.TabIndex = 21
        Me.lbTarget_Sales.Text = "0"
        Me.lbTarget_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_GPProfit
        '
        Me.lbTarget_GPProfit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_GPProfit.Location = New System.Drawing.Point(135, 100)
        Me.lbTarget_GPProfit.Name = "lbTarget_GPProfit"
        Me.lbTarget_GPProfit.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_GPProfit.TabIndex = 27
        Me.lbTarget_GPProfit.Text = "0"
        Me.lbTarget_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_Profit
        '
        Me.lbTarget_Profit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_Profit.Location = New System.Drawing.Point(135, 44)
        Me.lbTarget_Profit.Name = "lbTarget_Profit"
        Me.lbTarget_Profit.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_Profit.TabIndex = 23
        Me.lbTarget_Profit.Text = "0"
        Me.lbTarget_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTarget_GP
        '
        Me.lbTarget_GP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbTarget_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget_GP.Location = New System.Drawing.Point(135, 72)
        Me.lbTarget_GP.Name = "lbTarget_GP"
        Me.lbTarget_GP.Size = New System.Drawing.Size(130, 21)
        Me.lbTarget_GP.TabIndex = 25
        Me.lbTarget_GP.Text = "0"
        Me.lbTarget_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_GPWeight)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_TTProfit)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_TT)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_Sales)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_GPProFit)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_Profit)
        Me.GroupBox5.Controls.Add(Me.lbRatioAct_GP)
        Me.GroupBox5.Controls.Add(Me.lbAct_GPweight)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.lbAct_TTProfit)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.lbAct_TT)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.lbAct_Sales)
        Me.GroupBox5.Controls.Add(Me.lbAct_GPProfit)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.lbAct_Profit)
        Me.GroupBox5.Controls.Add(Me.lbAct_GP)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(294, 170)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(276, 219)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Actual"
        '
        'lbRatioAct_GPWeight
        '
        Me.lbRatioAct_GPWeight.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_GPWeight.Location = New System.Drawing.Point(219, 127)
        Me.lbRatioAct_GPWeight.Name = "lbRatioAct_GPWeight"
        Me.lbRatioAct_GPWeight.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_GPWeight.TabIndex = 54
        Me.lbRatioAct_GPWeight.Text = "0"
        Me.lbRatioAct_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_TTProfit
        '
        Me.lbRatioAct_TTProfit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_TTProfit.Location = New System.Drawing.Point(219, 183)
        Me.lbRatioAct_TTProfit.Name = "lbRatioAct_TTProfit"
        Me.lbRatioAct_TTProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_TTProfit.TabIndex = 53
        Me.lbRatioAct_TTProfit.Text = "0"
        Me.lbRatioAct_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_TT
        '
        Me.lbRatioAct_TT.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_TT.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_TT.Location = New System.Drawing.Point(219, 155)
        Me.lbRatioAct_TT.Name = "lbRatioAct_TT"
        Me.lbRatioAct_TT.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_TT.TabIndex = 52
        Me.lbRatioAct_TT.Text = "0"
        Me.lbRatioAct_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_Sales
        '
        Me.lbRatioAct_Sales.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_Sales.Location = New System.Drawing.Point(219, 15)
        Me.lbRatioAct_Sales.Name = "lbRatioAct_Sales"
        Me.lbRatioAct_Sales.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_Sales.TabIndex = 48
        Me.lbRatioAct_Sales.Text = "0"
        Me.lbRatioAct_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_GPProFit
        '
        Me.lbRatioAct_GPProFit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_GPProFit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_GPProFit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_GPProFit.Location = New System.Drawing.Point(219, 99)
        Me.lbRatioAct_GPProFit.Name = "lbRatioAct_GPProFit"
        Me.lbRatioAct_GPProFit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_GPProFit.TabIndex = 51
        Me.lbRatioAct_GPProFit.Text = "0"
        Me.lbRatioAct_GPProFit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_Profit
        '
        Me.lbRatioAct_Profit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_Profit.Location = New System.Drawing.Point(219, 43)
        Me.lbRatioAct_Profit.Name = "lbRatioAct_Profit"
        Me.lbRatioAct_Profit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_Profit.TabIndex = 49
        Me.lbRatioAct_Profit.Text = "0"
        Me.lbRatioAct_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioAct_GP
        '
        Me.lbRatioAct_GP.BackColor = System.Drawing.Color.OliveDrab
        Me.lbRatioAct_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioAct_GP.ForeColor = System.Drawing.Color.Black
        Me.lbRatioAct_GP.Location = New System.Drawing.Point(219, 71)
        Me.lbRatioAct_GP.Name = "lbRatioAct_GP"
        Me.lbRatioAct_GP.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioAct_GP.TabIndex = 50
        Me.lbRatioAct_GP.Text = "0"
        Me.lbRatioAct_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAct_GPweight
        '
        Me.lbAct_GPweight.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_GPweight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_GPweight.ForeColor = System.Drawing.Color.Black
        Me.lbAct_GPweight.Location = New System.Drawing.Point(99, 127)
        Me.lbAct_GPweight.Name = "lbAct_GPweight"
        Me.lbAct_GPweight.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_GPweight.TabIndex = 47
        Me.lbAct_GPweight.Text = "0"
        Me.lbAct_GPweight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 21)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "น้ำหนัก GP"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAct_TTProfit
        '
        Me.lbAct_TTProfit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbAct_TTProfit.Location = New System.Drawing.Point(99, 183)
        Me.lbAct_TTProfit.Name = "lbAct_TTProfit"
        Me.lbAct_TTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_TTProfit.TabIndex = 45
        Me.lbAct_TTProfit.Text = "0"
        Me.lbAct_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 183)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 21)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "กำไร TT"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAct_TT
        '
        Me.lbAct_TT.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_TT.ForeColor = System.Drawing.Color.Black
        Me.lbAct_TT.Location = New System.Drawing.Point(99, 155)
        Me.lbAct_TT.Name = "lbAct_TT"
        Me.lbAct_TT.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_TT.TabIndex = 43
        Me.lbAct_TT.Text = "0"
        Me.lbAct_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 21)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "ขายรวม"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 155)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 21)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "ขาย TT"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAct_Sales
        '
        Me.lbAct_Sales.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbAct_Sales.Location = New System.Drawing.Point(99, 15)
        Me.lbAct_Sales.Name = "lbAct_Sales"
        Me.lbAct_Sales.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_Sales.TabIndex = 35
        Me.lbAct_Sales.Text = "0"
        Me.lbAct_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAct_GPProfit
        '
        Me.lbAct_GPProfit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbAct_GPProfit.Location = New System.Drawing.Point(99, 99)
        Me.lbAct_GPProfit.Name = "lbAct_GPProfit"
        Me.lbAct_GPProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_GPProfit.TabIndex = 41
        Me.lbAct_GPProfit.Text = "0"
        Me.lbAct_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 21)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "กำไรรวม"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 99)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 21)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "กำไร GP"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAct_Profit
        '
        Me.lbAct_Profit.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbAct_Profit.Location = New System.Drawing.Point(99, 43)
        Me.lbAct_Profit.Name = "lbAct_Profit"
        Me.lbAct_Profit.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_Profit.TabIndex = 37
        Me.lbAct_Profit.Text = "0"
        Me.lbAct_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbAct_GP
        '
        Me.lbAct_GP.BackColor = System.Drawing.Color.OliveDrab
        Me.lbAct_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbAct_GP.ForeColor = System.Drawing.Color.Black
        Me.lbAct_GP.Location = New System.Drawing.Point(99, 71)
        Me.lbAct_GP.Name = "lbAct_GP"
        Me.lbAct_GP.Size = New System.Drawing.Size(113, 21)
        Me.lbAct_GP.TabIndex = 39
        Me.lbAct_GP.Text = "0"
        Me.lbAct_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(83, 21)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "ขาย GP"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(583, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Work Day เหลือ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDayQty
        '
        Me.lbDayQty.BackColor = System.Drawing.Color.Blue
        Me.lbDayQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDayQty.ForeColor = System.Drawing.Color.White
        Me.lbDayQty.Location = New System.Drawing.Point(673, 394)
        Me.lbDayQty.Name = "lbDayQty"
        Me.lbDayQty.Size = New System.Drawing.Size(165, 21)
        Me.lbDayQty.TabIndex = 37
        Me.lbDayQty.Text = "0"
        Me.lbDayQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_GPWeight)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_TTProfit)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_TT)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_Sales)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_GPProfit)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_Profit)
        Me.GroupBox6.Controls.Add(Me.lbRatioDiff_GP)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetGPWeight)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetTTProfit)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetTT)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetSales)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetGPPrifit)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetProfit)
        Me.GroupBox6.Controls.Add(Me.lbDiff_TargetGP)
        Me.GroupBox6.Controls.Add(Me.Label36)
        Me.GroupBox6.Location = New System.Drawing.Point(576, 170)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(271, 219)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Diff"
        '
        'lbRatioDiff_GPWeight
        '
        Me.lbRatioDiff_GPWeight.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_GPWeight.Location = New System.Drawing.Point(216, 127)
        Me.lbRatioDiff_GPWeight.Name = "lbRatioDiff_GPWeight"
        Me.lbRatioDiff_GPWeight.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_GPWeight.TabIndex = 54
        Me.lbRatioDiff_GPWeight.Text = "0"
        Me.lbRatioDiff_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_TTProfit
        '
        Me.lbRatioDiff_TTProfit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_TTProfit.Location = New System.Drawing.Point(216, 183)
        Me.lbRatioDiff_TTProfit.Name = "lbRatioDiff_TTProfit"
        Me.lbRatioDiff_TTProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_TTProfit.TabIndex = 53
        Me.lbRatioDiff_TTProfit.Text = "0"
        Me.lbRatioDiff_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_TT
        '
        Me.lbRatioDiff_TT.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_TT.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_TT.Location = New System.Drawing.Point(216, 155)
        Me.lbRatioDiff_TT.Name = "lbRatioDiff_TT"
        Me.lbRatioDiff_TT.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_TT.TabIndex = 52
        Me.lbRatioDiff_TT.Text = "0"
        Me.lbRatioDiff_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_Sales
        '
        Me.lbRatioDiff_Sales.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_Sales.Location = New System.Drawing.Point(216, 15)
        Me.lbRatioDiff_Sales.Name = "lbRatioDiff_Sales"
        Me.lbRatioDiff_Sales.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_Sales.TabIndex = 48
        Me.lbRatioDiff_Sales.Text = "0"
        Me.lbRatioDiff_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_GPProfit
        '
        Me.lbRatioDiff_GPProfit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_GPProfit.Location = New System.Drawing.Point(216, 99)
        Me.lbRatioDiff_GPProfit.Name = "lbRatioDiff_GPProfit"
        Me.lbRatioDiff_GPProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_GPProfit.TabIndex = 51
        Me.lbRatioDiff_GPProfit.Text = "0"
        Me.lbRatioDiff_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_Profit
        '
        Me.lbRatioDiff_Profit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_Profit.Location = New System.Drawing.Point(216, 43)
        Me.lbRatioDiff_Profit.Name = "lbRatioDiff_Profit"
        Me.lbRatioDiff_Profit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_Profit.TabIndex = 49
        Me.lbRatioDiff_Profit.Text = "0"
        Me.lbRatioDiff_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioDiff_GP
        '
        Me.lbRatioDiff_GP.BackColor = System.Drawing.Color.DarkOrange
        Me.lbRatioDiff_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioDiff_GP.ForeColor = System.Drawing.Color.Black
        Me.lbRatioDiff_GP.Location = New System.Drawing.Point(216, 71)
        Me.lbRatioDiff_GP.Name = "lbRatioDiff_GP"
        Me.lbRatioDiff_GP.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioDiff_GP.TabIndex = 50
        Me.lbRatioDiff_GP.Text = "0"
        Me.lbRatioDiff_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDiff_TargetGPWeight
        '
        Me.lbDiff_TargetGPWeight.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetGPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetGPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetGPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbDiff_TargetGPWeight.Name = "lbDiff_TargetGPWeight"
        Me.lbDiff_TargetGPWeight.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetGPWeight.TabIndex = 47
        Me.lbDiff_TargetGPWeight.Text = "0"
        Me.lbDiff_TargetGPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 21)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "น้ำหนัก GP"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDiff_TargetTTProfit
        '
        Me.lbDiff_TargetTTProfit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetTTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetTTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetTTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbDiff_TargetTTProfit.Name = "lbDiff_TargetTTProfit"
        Me.lbDiff_TargetTTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetTTProfit.TabIndex = 45
        Me.lbDiff_TargetTTProfit.Text = "0"
        Me.lbDiff_TargetTTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 183)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 21)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "กำไร TT"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDiff_TargetTT
        '
        Me.lbDiff_TargetTT.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetTT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetTT.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetTT.Location = New System.Drawing.Point(97, 155)
        Me.lbDiff_TargetTT.Name = "lbDiff_TargetTT"
        Me.lbDiff_TargetTT.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetTT.TabIndex = 43
        Me.lbDiff_TargetTT.Text = "0"
        Me.lbDiff_TargetTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(83, 21)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "ขายรวม"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label29.Location = New System.Drawing.Point(7, 155)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 21)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "ขาย TT"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDiff_TargetSales
        '
        Me.lbDiff_TargetSales.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetSales.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetSales.Location = New System.Drawing.Point(97, 15)
        Me.lbDiff_TargetSales.Name = "lbDiff_TargetSales"
        Me.lbDiff_TargetSales.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetSales.TabIndex = 35
        Me.lbDiff_TargetSales.Text = "0"
        Me.lbDiff_TargetSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDiff_TargetGPPrifit
        '
        Me.lbDiff_TargetGPPrifit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetGPPrifit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetGPPrifit.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetGPPrifit.Location = New System.Drawing.Point(97, 99)
        Me.lbDiff_TargetGPPrifit.Name = "lbDiff_TargetGPPrifit"
        Me.lbDiff_TargetGPPrifit.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetGPPrifit.TabIndex = 41
        Me.lbDiff_TargetGPPrifit.Text = "0"
        Me.lbDiff_TargetGPPrifit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(83, 21)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "กำไรรวม"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label33.Location = New System.Drawing.Point(7, 99)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 21)
        Me.Label33.TabIndex = 40
        Me.Label33.Text = "กำไร GP"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDiff_TargetProfit
        '
        Me.lbDiff_TargetProfit.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetProfit.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetProfit.Location = New System.Drawing.Point(97, 43)
        Me.lbDiff_TargetProfit.Name = "lbDiff_TargetProfit"
        Me.lbDiff_TargetProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetProfit.TabIndex = 37
        Me.lbDiff_TargetProfit.Text = "0"
        Me.lbDiff_TargetProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDiff_TargetGP
        '
        Me.lbDiff_TargetGP.BackColor = System.Drawing.Color.DarkOrange
        Me.lbDiff_TargetGP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDiff_TargetGP.ForeColor = System.Drawing.Color.Black
        Me.lbDiff_TargetGP.Location = New System.Drawing.Point(97, 71)
        Me.lbDiff_TargetGP.Name = "lbDiff_TargetGP"
        Me.lbDiff_TargetGP.Size = New System.Drawing.Size(113, 21)
        Me.lbDiff_TargetGP.TabIndex = 39
        Me.lbDiff_TargetGP.Text = "0"
        Me.lbDiff_TargetGP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label36.Location = New System.Drawing.Point(7, 71)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 21)
        Me.Label36.TabIndex = 38
        Me.Label36.Text = "ขาย GP"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(301, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Work Day Act."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbActDay
        '
        Me.lbActDay.BackColor = System.Drawing.Color.Blue
        Me.lbActDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbActDay.ForeColor = System.Drawing.Color.White
        Me.lbActDay.Location = New System.Drawing.Point(393, 395)
        Me.lbActDay.Name = "lbActDay"
        Me.lbActDay.Size = New System.Drawing.Size(165, 21)
        Me.lbActDay.TabIndex = 40
        Me.lbActDay.Text = "0"
        Me.lbActDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lbSim_GPWeight)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.lbSim_TTProfit)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.lbSim_TT)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label37)
        Me.GroupBox7.Controls.Add(Me.lbSim_Target)
        Me.GroupBox7.Controls.Add(Me.lbSim_GPProfit)
        Me.GroupBox7.Controls.Add(Me.Label40)
        Me.GroupBox7.Controls.Add(Me.Label41)
        Me.GroupBox7.Controls.Add(Me.lbSim_Profit)
        Me.GroupBox7.Controls.Add(Me.lbSim_GPtarget)
        Me.GroupBox7.Controls.Add(Me.Label44)
        Me.GroupBox7.Location = New System.Drawing.Point(576, 421)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(271, 214)
        Me.GroupBox7.TabIndex = 41
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Sim/Day"
        '
        'lbSim_GPWeight
        '
        Me.lbSim_GPWeight.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbSim_GPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbSim_GPWeight.Name = "lbSim_GPWeight"
        Me.lbSim_GPWeight.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_GPWeight.TabIndex = 47
        Me.lbSim_GPWeight.Text = "0"
        Me.lbSim_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label26.Location = New System.Drawing.Point(7, 127)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 21)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "น้ำหนัก GP"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSim_TTProfit
        '
        Me.lbSim_TTProfit.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbSim_TTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbSim_TTProfit.Name = "lbSim_TTProfit"
        Me.lbSim_TTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_TTProfit.TabIndex = 45
        Me.lbSim_TTProfit.Text = "0"
        Me.lbSim_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label31.Location = New System.Drawing.Point(7, 183)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 21)
        Me.Label31.TabIndex = 44
        Me.Label31.Text = "กำไร TT"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSim_TT
        '
        Me.lbSim_TT.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_TT.ForeColor = System.Drawing.Color.Black
        Me.lbSim_TT.Location = New System.Drawing.Point(97, 155)
        Me.lbSim_TT.Name = "lbSim_TT"
        Me.lbSim_TT.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_TT.TabIndex = 43
        Me.lbSim_TT.Text = "0"
        Me.lbSim_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label35.Location = New System.Drawing.Point(7, 15)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 21)
        Me.Label35.TabIndex = 34
        Me.Label35.Text = "ขายรวม"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label37.Location = New System.Drawing.Point(7, 155)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(83, 21)
        Me.Label37.TabIndex = 42
        Me.Label37.Text = "ขาย TT"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSim_Target
        '
        Me.lbSim_Target.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_Target.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_Target.ForeColor = System.Drawing.Color.Black
        Me.lbSim_Target.Location = New System.Drawing.Point(97, 15)
        Me.lbSim_Target.Name = "lbSim_Target"
        Me.lbSim_Target.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_Target.TabIndex = 35
        Me.lbSim_Target.Text = "0"
        Me.lbSim_Target.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSim_GPProfit
        '
        Me.lbSim_GPProfit.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbSim_GPProfit.Location = New System.Drawing.Point(97, 99)
        Me.lbSim_GPProfit.Name = "lbSim_GPProfit"
        Me.lbSim_GPProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_GPProfit.TabIndex = 41
        Me.lbSim_GPProfit.Text = "0"
        Me.lbSim_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label40.Location = New System.Drawing.Point(7, 43)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 21)
        Me.Label40.TabIndex = 36
        Me.Label40.Text = "กำไรรวม"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label41.Location = New System.Drawing.Point(7, 99)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(83, 21)
        Me.Label41.TabIndex = 40
        Me.Label41.Text = "กำไร GP"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSim_Profit
        '
        Me.lbSim_Profit.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbSim_Profit.Location = New System.Drawing.Point(97, 43)
        Me.lbSim_Profit.Name = "lbSim_Profit"
        Me.lbSim_Profit.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_Profit.TabIndex = 37
        Me.lbSim_Profit.Text = "0"
        Me.lbSim_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSim_GPtarget
        '
        Me.lbSim_GPtarget.BackColor = System.Drawing.Color.Khaki
        Me.lbSim_GPtarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSim_GPtarget.ForeColor = System.Drawing.Color.Black
        Me.lbSim_GPtarget.Location = New System.Drawing.Point(97, 71)
        Me.lbSim_GPtarget.Name = "lbSim_GPtarget"
        Me.lbSim_GPtarget.Size = New System.Drawing.Size(113, 21)
        Me.lbSim_GPtarget.TabIndex = 39
        Me.lbSim_GPtarget.Text = "0"
        Me.lbSim_GPtarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label44.Location = New System.Drawing.Point(7, 71)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(83, 21)
        Me.Label44.TabIndex = 38
        Me.Label44.Text = "ขาย GP"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(21, 395)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 21)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Work Day รวม"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDayQty0
        '
        Me.lbDayQty0.BackColor = System.Drawing.Color.Blue
        Me.lbDayQty0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDayQty0.ForeColor = System.Drawing.Color.White
        Me.lbDayQty0.Location = New System.Drawing.Point(111, 395)
        Me.lbDayQty0.Name = "lbDayQty0"
        Me.lbDayQty0.Size = New System.Drawing.Size(165, 21)
        Me.lbDayQty0.TabIndex = 43
        Me.lbDayQty0.Text = "0"
        Me.lbDayQty0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_GPWeight)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_TTProfit)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_TT)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_Sales)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_GPProfit)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_Profit)
        Me.GroupBox8.Controls.Add(Me.lbRatioPerf_GP)
        Me.GroupBox8.Controls.Add(Me.lbPerf_GPWeight)
        Me.GroupBox8.Controls.Add(Me.Label34)
        Me.GroupBox8.Controls.Add(Me.lbPerf_TTProfit)
        Me.GroupBox8.Controls.Add(Me.Label39)
        Me.GroupBox8.Controls.Add(Me.lbPerf_TT)
        Me.GroupBox8.Controls.Add(Me.Label43)
        Me.GroupBox8.Controls.Add(Me.Label45)
        Me.GroupBox8.Controls.Add(Me.lbPerf_Sales)
        Me.GroupBox8.Controls.Add(Me.lbPerf_GPProfit)
        Me.GroupBox8.Controls.Add(Me.Label48)
        Me.GroupBox8.Controls.Add(Me.Label49)
        Me.GroupBox8.Controls.Add(Me.lbPerf_Profit)
        Me.GroupBox8.Controls.Add(Me.lbPerf_GP)
        Me.GroupBox8.Controls.Add(Me.Label52)
        Me.GroupBox8.Location = New System.Drawing.Point(294, 421)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(271, 214)
        Me.GroupBox8.TabIndex = 44
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Act./Day"
        '
        'lbRatioPerf_GPWeight
        '
        Me.lbRatioPerf_GPWeight.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_GPWeight.Location = New System.Drawing.Point(215, 127)
        Me.lbRatioPerf_GPWeight.Name = "lbRatioPerf_GPWeight"
        Me.lbRatioPerf_GPWeight.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_GPWeight.TabIndex = 54
        Me.lbRatioPerf_GPWeight.Text = "0"
        Me.lbRatioPerf_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_TTProfit
        '
        Me.lbRatioPerf_TTProfit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_TTProfit.Location = New System.Drawing.Point(215, 183)
        Me.lbRatioPerf_TTProfit.Name = "lbRatioPerf_TTProfit"
        Me.lbRatioPerf_TTProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_TTProfit.TabIndex = 53
        Me.lbRatioPerf_TTProfit.Text = "0"
        Me.lbRatioPerf_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_TT
        '
        Me.lbRatioPerf_TT.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_TT.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_TT.Location = New System.Drawing.Point(215, 155)
        Me.lbRatioPerf_TT.Name = "lbRatioPerf_TT"
        Me.lbRatioPerf_TT.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_TT.TabIndex = 52
        Me.lbRatioPerf_TT.Text = "0"
        Me.lbRatioPerf_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_Sales
        '
        Me.lbRatioPerf_Sales.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_Sales.Location = New System.Drawing.Point(215, 15)
        Me.lbRatioPerf_Sales.Name = "lbRatioPerf_Sales"
        Me.lbRatioPerf_Sales.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_Sales.TabIndex = 48
        Me.lbRatioPerf_Sales.Text = "0"
        Me.lbRatioPerf_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_GPProfit
        '
        Me.lbRatioPerf_GPProfit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_GPProfit.Location = New System.Drawing.Point(215, 99)
        Me.lbRatioPerf_GPProfit.Name = "lbRatioPerf_GPProfit"
        Me.lbRatioPerf_GPProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_GPProfit.TabIndex = 51
        Me.lbRatioPerf_GPProfit.Text = "0"
        Me.lbRatioPerf_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_Profit
        '
        Me.lbRatioPerf_Profit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_Profit.Location = New System.Drawing.Point(215, 43)
        Me.lbRatioPerf_Profit.Name = "lbRatioPerf_Profit"
        Me.lbRatioPerf_Profit.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_Profit.TabIndex = 49
        Me.lbRatioPerf_Profit.Text = "0"
        Me.lbRatioPerf_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatioPerf_GP
        '
        Me.lbRatioPerf_GP.BackColor = System.Drawing.Color.YellowGreen
        Me.lbRatioPerf_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatioPerf_GP.ForeColor = System.Drawing.Color.Black
        Me.lbRatioPerf_GP.Location = New System.Drawing.Point(215, 71)
        Me.lbRatioPerf_GP.Name = "lbRatioPerf_GP"
        Me.lbRatioPerf_GP.Size = New System.Drawing.Size(50, 21)
        Me.lbRatioPerf_GP.TabIndex = 50
        Me.lbRatioPerf_GP.Text = "0"
        Me.lbRatioPerf_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPerf_GPWeight
        '
        Me.lbPerf_GPWeight.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_GPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbPerf_GPWeight.Name = "lbPerf_GPWeight"
        Me.lbPerf_GPWeight.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_GPWeight.TabIndex = 47
        Me.lbPerf_GPWeight.Text = "0"
        Me.lbPerf_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label34.Location = New System.Drawing.Point(7, 127)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(83, 21)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "น้ำหนัก GP"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPerf_TTProfit
        '
        Me.lbPerf_TTProfit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_TTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbPerf_TTProfit.Name = "lbPerf_TTProfit"
        Me.lbPerf_TTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_TTProfit.TabIndex = 45
        Me.lbPerf_TTProfit.Text = "0"
        Me.lbPerf_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label39.Location = New System.Drawing.Point(7, 183)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(83, 21)
        Me.Label39.TabIndex = 44
        Me.Label39.Text = "กำไร TT"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPerf_TT
        '
        Me.lbPerf_TT.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_TT.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_TT.Location = New System.Drawing.Point(97, 155)
        Me.lbPerf_TT.Name = "lbPerf_TT"
        Me.lbPerf_TT.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_TT.TabIndex = 43
        Me.lbPerf_TT.Text = "0"
        Me.lbPerf_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label43.Location = New System.Drawing.Point(7, 15)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(83, 21)
        Me.Label43.TabIndex = 34
        Me.Label43.Text = "ขายรวม"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label45.Location = New System.Drawing.Point(7, 155)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 21)
        Me.Label45.TabIndex = 42
        Me.Label45.Text = "ขาย TT"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPerf_Sales
        '
        Me.lbPerf_Sales.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_Sales.Location = New System.Drawing.Point(97, 15)
        Me.lbPerf_Sales.Name = "lbPerf_Sales"
        Me.lbPerf_Sales.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_Sales.TabIndex = 35
        Me.lbPerf_Sales.Text = "0"
        Me.lbPerf_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPerf_GPProfit
        '
        Me.lbPerf_GPProfit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_GPProfit.Location = New System.Drawing.Point(97, 99)
        Me.lbPerf_GPProfit.Name = "lbPerf_GPProfit"
        Me.lbPerf_GPProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_GPProfit.TabIndex = 41
        Me.lbPerf_GPProfit.Text = "0"
        Me.lbPerf_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label48.Location = New System.Drawing.Point(7, 43)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(83, 21)
        Me.Label48.TabIndex = 36
        Me.Label48.Text = "กำไรรวม"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label49.Location = New System.Drawing.Point(7, 99)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(83, 21)
        Me.Label49.TabIndex = 40
        Me.Label49.Text = "กำไร GP"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPerf_Profit
        '
        Me.lbPerf_Profit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_Profit.Location = New System.Drawing.Point(97, 43)
        Me.lbPerf_Profit.Name = "lbPerf_Profit"
        Me.lbPerf_Profit.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_Profit.TabIndex = 37
        Me.lbPerf_Profit.Text = "0"
        Me.lbPerf_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPerf_GP
        '
        Me.lbPerf_GP.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPerf_GP.ForeColor = System.Drawing.Color.Black
        Me.lbPerf_GP.Location = New System.Drawing.Point(97, 71)
        Me.lbPerf_GP.Name = "lbPerf_GP"
        Me.lbPerf_GP.Size = New System.Drawing.Size(113, 21)
        Me.lbPerf_GP.TabIndex = 39
        Me.lbPerf_GP.Text = "0"
        Me.lbPerf_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label52.Location = New System.Drawing.Point(7, 71)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(83, 21)
        Me.Label52.TabIndex = 38
        Me.Label52.Text = "ขาย GP"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(5, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1287, 671)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.GroupBox13)
        Me.TabPage1.Controls.Add(Me.GroupBox12)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox9)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.lbDayQty0)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.lbActDay)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.lbDayQty)
        Me.TabPage1.ForeColor = System.Drawing.Color.Blue
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ถามรวม"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.lbRatio_CusItem6M)
        Me.GroupBox13.Controls.Add(Me.Label87)
        Me.GroupBox13.Controls.Add(Me.lbCusItem6M)
        Me.GroupBox13.Controls.Add(Me.Label78)
        Me.GroupBox13.Controls.Add(Me.lbCusItem)
        Me.GroupBox13.Controls.Add(Me.lbCusItem1M)
        Me.GroupBox13.Controls.Add(Me.lbRatio_CusItem0)
        Me.GroupBox13.Controls.Add(Me.Label80)
        Me.GroupBox13.Controls.Add(Me.lbRatio_CusItem2M)
        Me.GroupBox13.Controls.Add(Me.Label82)
        Me.GroupBox13.Controls.Add(Me.lbRatio_CusItem1M)
        Me.GroupBox13.Controls.Add(Me.lbCusItem2M)
        Me.GroupBox13.Controls.Add(Me.lbRatio_CusItem)
        Me.GroupBox13.Controls.Add(Me.chartCusItem)
        Me.GroupBox13.Controls.Add(Me.Label79)
        Me.GroupBox13.Controls.Add(Me.lbCusItem0)
        Me.GroupBox13.Location = New System.Drawing.Point(576, 2)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(567, 167)
        Me.GroupBox13.TabIndex = 66
        Me.GroupBox13.TabStop = False
        '
        'lbRatio_CusItem6M
        '
        Me.lbRatio_CusItem6M.BackColor = System.Drawing.Color.Black
        Me.lbRatio_CusItem6M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatio_CusItem6M.ForeColor = System.Drawing.Color.White
        Me.lbRatio_CusItem6M.Location = New System.Drawing.Point(234, 135)
        Me.lbRatio_CusItem6M.Name = "lbRatio_CusItem6M"
        Me.lbRatio_CusItem6M.Size = New System.Drawing.Size(48, 21)
        Me.lbRatio_CusItem6M.TabIndex = 66
        Me.lbRatio_CusItem6M.Text = "0"
        Me.lbRatio_CusItem6M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label87.Location = New System.Drawing.Point(10, 137)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(149, 21)
        Me.Label87.TabIndex = 64
        Me.Label87.Text = "ขาดการติดต่อกว่า  6 เดือน"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusItem6M
        '
        Me.lbCusItem6M.BackColor = System.Drawing.Color.Black
        Me.lbCusItem6M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusItem6M.ForeColor = System.Drawing.Color.White
        Me.lbCusItem6M.Location = New System.Drawing.Point(163, 136)
        Me.lbCusItem6M.Name = "lbCusItem6M"
        Me.lbCusItem6M.Size = New System.Drawing.Size(65, 21)
        Me.lbCusItem6M.TabIndex = 65
        Me.lbCusItem6M.Text = "0"
        Me.lbCusItem6M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label78.Location = New System.Drawing.Point(9, 17)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(149, 21)
        Me.Label78.TabIndex = 51
        Me.Label78.Text = "ลูกค้าทั้งหมด"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusItem
        '
        Me.lbCusItem.BackColor = System.Drawing.Color.Black
        Me.lbCusItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbCusItem.Location = New System.Drawing.Point(162, 17)
        Me.lbCusItem.Name = "lbCusItem"
        Me.lbCusItem.Size = New System.Drawing.Size(65, 21)
        Me.lbCusItem.TabIndex = 52
        Me.lbCusItem.Text = "0"
        Me.lbCusItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusItem1M
        '
        Me.lbCusItem1M.BackColor = System.Drawing.Color.Black
        Me.lbCusItem1M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusItem1M.ForeColor = System.Drawing.Color.Yellow
        Me.lbCusItem1M.Location = New System.Drawing.Point(162, 75)
        Me.lbCusItem1M.Name = "lbCusItem1M"
        Me.lbCusItem1M.Size = New System.Drawing.Size(65, 21)
        Me.lbCusItem1M.TabIndex = 54
        Me.lbCusItem1M.Text = "0"
        Me.lbCusItem1M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatio_CusItem0
        '
        Me.lbRatio_CusItem0.BackColor = System.Drawing.Color.Black
        Me.lbRatio_CusItem0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatio_CusItem0.ForeColor = System.Drawing.Color.Lime
        Me.lbRatio_CusItem0.Location = New System.Drawing.Point(234, 47)
        Me.lbRatio_CusItem0.Name = "lbRatio_CusItem0"
        Me.lbRatio_CusItem0.Size = New System.Drawing.Size(48, 21)
        Me.lbRatio_CusItem0.TabIndex = 63
        Me.lbRatio_CusItem0.Text = "0"
        Me.lbRatio_CusItem0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label80.Location = New System.Drawing.Point(9, 75)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(149, 21)
        Me.Label80.TabIndex = 53
        Me.Label80.Text = "ขาดการติดต่อ  1 เดือน"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbRatio_CusItem2M
        '
        Me.lbRatio_CusItem2M.BackColor = System.Drawing.Color.Black
        Me.lbRatio_CusItem2M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatio_CusItem2M.ForeColor = System.Drawing.Color.Red
        Me.lbRatio_CusItem2M.Location = New System.Drawing.Point(233, 102)
        Me.lbRatio_CusItem2M.Name = "lbRatio_CusItem2M"
        Me.lbRatio_CusItem2M.Size = New System.Drawing.Size(48, 21)
        Me.lbRatio_CusItem2M.TabIndex = 62
        Me.lbRatio_CusItem2M.Text = "0"
        Me.lbRatio_CusItem2M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label82.Location = New System.Drawing.Point(9, 104)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(149, 21)
        Me.Label82.TabIndex = 55
        Me.Label82.Text = "ขาดการติดต่อกว่า  2 เดือน"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbRatio_CusItem1M
        '
        Me.lbRatio_CusItem1M.BackColor = System.Drawing.Color.Black
        Me.lbRatio_CusItem1M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatio_CusItem1M.ForeColor = System.Drawing.Color.Yellow
        Me.lbRatio_CusItem1M.Location = New System.Drawing.Point(233, 74)
        Me.lbRatio_CusItem1M.Name = "lbRatio_CusItem1M"
        Me.lbRatio_CusItem1M.Size = New System.Drawing.Size(48, 21)
        Me.lbRatio_CusItem1M.TabIndex = 61
        Me.lbRatio_CusItem1M.Text = "0"
        Me.lbRatio_CusItem1M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusItem2M
        '
        Me.lbCusItem2M.BackColor = System.Drawing.Color.Black
        Me.lbCusItem2M.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusItem2M.ForeColor = System.Drawing.Color.Red
        Me.lbCusItem2M.Location = New System.Drawing.Point(162, 103)
        Me.lbCusItem2M.Name = "lbCusItem2M"
        Me.lbCusItem2M.Size = New System.Drawing.Size(65, 21)
        Me.lbCusItem2M.TabIndex = 56
        Me.lbCusItem2M.Text = "0"
        Me.lbCusItem2M.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRatio_CusItem
        '
        Me.lbRatio_CusItem.BackColor = System.Drawing.Color.Black
        Me.lbRatio_CusItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbRatio_CusItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRatio_CusItem.Location = New System.Drawing.Point(233, 16)
        Me.lbRatio_CusItem.Name = "lbRatio_CusItem"
        Me.lbRatio_CusItem.Size = New System.Drawing.Size(48, 21)
        Me.lbRatio_CusItem.TabIndex = 60
        Me.lbRatio_CusItem.Text = "0"
        Me.lbRatio_CusItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chartCusItem
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartCusItem.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartCusItem.Legends.Add(Legend3)
        Me.chartCusItem.Location = New System.Drawing.Point(289, 13)
        Me.chartCusItem.Name = "chartCusItem"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chartCusItem.Series.Add(Series3)
        Me.chartCusItem.Size = New System.Drawing.Size(265, 144)
        Me.chartCusItem.TabIndex = 57
        Me.chartCusItem.Text = "Chart1"
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label79.Location = New System.Drawing.Point(10, 48)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(149, 21)
        Me.Label79.TabIndex = 58
        Me.Label79.Text = "ติดต่อในช่วง 1 เดือน"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusItem0
        '
        Me.lbCusItem0.BackColor = System.Drawing.Color.Black
        Me.lbCusItem0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusItem0.ForeColor = System.Drawing.Color.Lime
        Me.lbCusItem0.Location = New System.Drawing.Point(163, 48)
        Me.lbCusItem0.Name = "lbCusItem0"
        Me.lbCusItem0.Size = New System.Drawing.Size(65, 21)
        Me.lbCusItem0.TabIndex = 59
        Me.lbCusItem0.Text = "0"
        Me.lbCusItem0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_Sales)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_GPWeight)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_TTProfti)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_TT)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_GPProfit)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_Profit)
        Me.GroupBox12.Controls.Add(Me.lbSLRatio_GP)
        Me.GroupBox12.Controls.Add(Me.lbDaily_Sales)
        Me.GroupBox12.Controls.Add(Me.lbDaily_GPWeight)
        Me.GroupBox12.Controls.Add(Me.Label11)
        Me.GroupBox12.Controls.Add(Me.lbDaily_TTProfit)
        Me.GroupBox12.Controls.Add(Me.Label67)
        Me.GroupBox12.Controls.Add(Me.lbDaily_TT)
        Me.GroupBox12.Controls.Add(Me.Label69)
        Me.GroupBox12.Controls.Add(Me.Label70)
        Me.GroupBox12.Controls.Add(Me.Label71)
        Me.GroupBox12.Controls.Add(Me.lbDaily_GPProfit)
        Me.GroupBox12.Controls.Add(Me.Label73)
        Me.GroupBox12.Controls.Add(Me.Label74)
        Me.GroupBox12.Controls.Add(Me.lbDaily_Profit)
        Me.GroupBox12.Controls.Add(Me.lbDaily_GP)
        Me.GroupBox12.Controls.Add(Me.Label77)
        Me.GroupBox12.Location = New System.Drawing.Point(853, 421)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(290, 214)
        Me.GroupBox12.TabIndex = 50
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "ขาย-วันนี้"
        '
        'lbSLRatio_Sales
        '
        Me.lbSLRatio_Sales.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_Sales.Location = New System.Drawing.Point(214, 14)
        Me.lbSLRatio_Sales.Name = "lbSLRatio_Sales"
        Me.lbSLRatio_Sales.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_Sales.TabIndex = 55
        Me.lbSLRatio_Sales.Text = "0"
        Me.lbSLRatio_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_GPWeight
        '
        Me.lbSLRatio_GPWeight.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_GPWeight.Location = New System.Drawing.Point(214, 127)
        Me.lbSLRatio_GPWeight.Name = "lbSLRatio_GPWeight"
        Me.lbSLRatio_GPWeight.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_GPWeight.TabIndex = 54
        Me.lbSLRatio_GPWeight.Text = "0"
        Me.lbSLRatio_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_TTProfti
        '
        Me.lbSLRatio_TTProfti.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_TTProfti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_TTProfti.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_TTProfti.Location = New System.Drawing.Point(214, 183)
        Me.lbSLRatio_TTProfti.Name = "lbSLRatio_TTProfti"
        Me.lbSLRatio_TTProfti.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_TTProfti.TabIndex = 53
        Me.lbSLRatio_TTProfti.Text = "0"
        Me.lbSLRatio_TTProfti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_TT
        '
        Me.lbSLRatio_TT.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_TT.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_TT.Location = New System.Drawing.Point(214, 155)
        Me.lbSLRatio_TT.Name = "lbSLRatio_TT"
        Me.lbSLRatio_TT.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_TT.TabIndex = 52
        Me.lbSLRatio_TT.Text = "0"
        Me.lbSLRatio_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_GPProfit
        '
        Me.lbSLRatio_GPProfit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_GPProfit.Location = New System.Drawing.Point(214, 99)
        Me.lbSLRatio_GPProfit.Name = "lbSLRatio_GPProfit"
        Me.lbSLRatio_GPProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_GPProfit.TabIndex = 51
        Me.lbSLRatio_GPProfit.Text = "0"
        Me.lbSLRatio_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_Profit
        '
        Me.lbSLRatio_Profit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_Profit.Location = New System.Drawing.Point(214, 43)
        Me.lbSLRatio_Profit.Name = "lbSLRatio_Profit"
        Me.lbSLRatio_Profit.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_Profit.TabIndex = 49
        Me.lbSLRatio_Profit.Text = "0"
        Me.lbSLRatio_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSLRatio_GP
        '
        Me.lbSLRatio_GP.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbSLRatio_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSLRatio_GP.ForeColor = System.Drawing.Color.Black
        Me.lbSLRatio_GP.Location = New System.Drawing.Point(214, 71)
        Me.lbSLRatio_GP.Name = "lbSLRatio_GP"
        Me.lbSLRatio_GP.Size = New System.Drawing.Size(50, 21)
        Me.lbSLRatio_GP.TabIndex = 50
        Me.lbSLRatio_GP.Text = "0"
        Me.lbSLRatio_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDaily_Sales
        '
        Me.lbDaily_Sales.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_Sales.Location = New System.Drawing.Point(97, 14)
        Me.lbDaily_Sales.Name = "lbDaily_Sales"
        Me.lbDaily_Sales.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_Sales.TabIndex = 48
        Me.lbDaily_Sales.Text = "0"
        Me.lbDaily_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDaily_GPWeight
        '
        Me.lbDaily_GPWeight.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_GPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbDaily_GPWeight.Name = "lbDaily_GPWeight"
        Me.lbDaily_GPWeight.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_GPWeight.TabIndex = 47
        Me.lbDaily_GPWeight.Text = "0"
        Me.lbDaily_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 21)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "น้ำหนัก GP"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDaily_TTProfit
        '
        Me.lbDaily_TTProfit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_TTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbDaily_TTProfit.Name = "lbDaily_TTProfit"
        Me.lbDaily_TTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_TTProfit.TabIndex = 45
        Me.lbDaily_TTProfit.Text = "0"
        Me.lbDaily_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label67.Location = New System.Drawing.Point(7, 183)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(83, 21)
        Me.Label67.TabIndex = 44
        Me.Label67.Text = "กำไร TT"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDaily_TT
        '
        Me.lbDaily_TT.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_TT.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_TT.Location = New System.Drawing.Point(97, 155)
        Me.lbDaily_TT.Name = "lbDaily_TT"
        Me.lbDaily_TT.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_TT.TabIndex = 43
        Me.lbDaily_TT.Text = "0"
        Me.lbDaily_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label69.Location = New System.Drawing.Point(7, 15)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(83, 21)
        Me.Label69.TabIndex = 34
        Me.Label69.Text = "ขายรวม"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label70.Location = New System.Drawing.Point(7, 155)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(83, 21)
        Me.Label70.TabIndex = 42
        Me.Label70.Text = "ขาย TT"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(-441, 134)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(165, 21)
        Me.Label71.TabIndex = 35
        Me.Label71.Text = "0"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDaily_GPProfit
        '
        Me.lbDaily_GPProfit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_GPProfit.Location = New System.Drawing.Point(97, 99)
        Me.lbDaily_GPProfit.Name = "lbDaily_GPProfit"
        Me.lbDaily_GPProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_GPProfit.TabIndex = 41
        Me.lbDaily_GPProfit.Text = "0"
        Me.lbDaily_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label73.Location = New System.Drawing.Point(7, 43)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(83, 21)
        Me.Label73.TabIndex = 36
        Me.Label73.Text = "กำไรรวม"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label74
        '
        Me.Label74.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label74.Location = New System.Drawing.Point(7, 99)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(83, 21)
        Me.Label74.TabIndex = 40
        Me.Label74.Text = "กำไร GP"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDaily_Profit
        '
        Me.lbDaily_Profit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_Profit.Location = New System.Drawing.Point(97, 43)
        Me.lbDaily_Profit.Name = "lbDaily_Profit"
        Me.lbDaily_Profit.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_Profit.TabIndex = 37
        Me.lbDaily_Profit.Text = "0"
        Me.lbDaily_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDaily_GP
        '
        Me.lbDaily_GP.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lbDaily_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDaily_GP.ForeColor = System.Drawing.Color.Black
        Me.lbDaily_GP.Location = New System.Drawing.Point(97, 71)
        Me.lbDaily_GP.Name = "lbDaily_GP"
        Me.lbDaily_GP.Size = New System.Drawing.Size(113, 21)
        Me.lbDaily_GP.TabIndex = 39
        Me.lbDaily_GP.Text = "0"
        Me.lbDaily_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label77.Location = New System.Drawing.Point(7, 71)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(83, 21)
        Me.Label77.TabIndex = 38
        Me.Label77.Text = "ขาย GP"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_GPWeight)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_TTProfit)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_TT)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_Sales)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_GPProfit)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_Profit)
        Me.GroupBox10.Controls.Add(Me.lbOrRatio_GP)
        Me.GroupBox10.Controls.Add(Me.lbOrder_GPWeight)
        Me.GroupBox10.Controls.Add(Me.Label38)
        Me.GroupBox10.Controls.Add(Me.lbOrder_TTProfit)
        Me.GroupBox10.Controls.Add(Me.Label51)
        Me.GroupBox10.Controls.Add(Me.lbOrder_TT)
        Me.GroupBox10.Controls.Add(Me.Label56)
        Me.GroupBox10.Controls.Add(Me.Label57)
        Me.GroupBox10.Controls.Add(Me.lbOrder_Sales)
        Me.GroupBox10.Controls.Add(Me.lbOrder_GPProfit)
        Me.GroupBox10.Controls.Add(Me.Label61)
        Me.GroupBox10.Controls.Add(Me.Label62)
        Me.GroupBox10.Controls.Add(Me.lbOrder_Profit)
        Me.GroupBox10.Controls.Add(Me.lbOrder_GP)
        Me.GroupBox10.Controls.Add(Me.Label65)
        Me.GroupBox10.Location = New System.Drawing.Point(853, 170)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(290, 219)
        Me.GroupBox10.TabIndex = 49
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "รับ Order วันนี้"
        '
        'lbOrRatio_GPWeight
        '
        Me.lbOrRatio_GPWeight.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_GPWeight.Location = New System.Drawing.Point(214, 127)
        Me.lbOrRatio_GPWeight.Name = "lbOrRatio_GPWeight"
        Me.lbOrRatio_GPWeight.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_GPWeight.TabIndex = 54
        Me.lbOrRatio_GPWeight.Text = "0"
        Me.lbOrRatio_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_TTProfit
        '
        Me.lbOrRatio_TTProfit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_TTProfit.Location = New System.Drawing.Point(214, 183)
        Me.lbOrRatio_TTProfit.Name = "lbOrRatio_TTProfit"
        Me.lbOrRatio_TTProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_TTProfit.TabIndex = 53
        Me.lbOrRatio_TTProfit.Text = "0"
        Me.lbOrRatio_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_TT
        '
        Me.lbOrRatio_TT.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_TT.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_TT.Location = New System.Drawing.Point(214, 155)
        Me.lbOrRatio_TT.Name = "lbOrRatio_TT"
        Me.lbOrRatio_TT.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_TT.TabIndex = 52
        Me.lbOrRatio_TT.Text = "0"
        Me.lbOrRatio_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_Sales
        '
        Me.lbOrRatio_Sales.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_Sales.Location = New System.Drawing.Point(214, 15)
        Me.lbOrRatio_Sales.Name = "lbOrRatio_Sales"
        Me.lbOrRatio_Sales.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_Sales.TabIndex = 48
        Me.lbOrRatio_Sales.Text = "0"
        Me.lbOrRatio_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_GPProfit
        '
        Me.lbOrRatio_GPProfit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_GPProfit.Location = New System.Drawing.Point(214, 99)
        Me.lbOrRatio_GPProfit.Name = "lbOrRatio_GPProfit"
        Me.lbOrRatio_GPProfit.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_GPProfit.TabIndex = 51
        Me.lbOrRatio_GPProfit.Text = "0"
        Me.lbOrRatio_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_Profit
        '
        Me.lbOrRatio_Profit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_Profit.Location = New System.Drawing.Point(214, 43)
        Me.lbOrRatio_Profit.Name = "lbOrRatio_Profit"
        Me.lbOrRatio_Profit.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_Profit.TabIndex = 49
        Me.lbOrRatio_Profit.Text = "0"
        Me.lbOrRatio_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrRatio_GP
        '
        Me.lbOrRatio_GP.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrRatio_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrRatio_GP.ForeColor = System.Drawing.Color.Black
        Me.lbOrRatio_GP.Location = New System.Drawing.Point(214, 71)
        Me.lbOrRatio_GP.Name = "lbOrRatio_GP"
        Me.lbOrRatio_GP.Size = New System.Drawing.Size(50, 21)
        Me.lbOrRatio_GP.TabIndex = 50
        Me.lbOrRatio_GP.Text = "0"
        Me.lbOrRatio_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrder_GPWeight
        '
        Me.lbOrder_GPWeight.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_GPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbOrder_GPWeight.Name = "lbOrder_GPWeight"
        Me.lbOrder_GPWeight.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_GPWeight.TabIndex = 47
        Me.lbOrder_GPWeight.Text = "0"
        Me.lbOrder_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label38.Location = New System.Drawing.Point(7, 127)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(83, 21)
        Me.Label38.TabIndex = 46
        Me.Label38.Text = "น้ำหนัก GP"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOrder_TTProfit
        '
        Me.lbOrder_TTProfit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_TTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbOrder_TTProfit.Name = "lbOrder_TTProfit"
        Me.lbOrder_TTProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_TTProfit.TabIndex = 45
        Me.lbOrder_TTProfit.Text = "0"
        Me.lbOrder_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label51.Location = New System.Drawing.Point(7, 183)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(83, 21)
        Me.Label51.TabIndex = 44
        Me.Label51.Text = "กำไร TT"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOrder_TT
        '
        Me.lbOrder_TT.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_TT.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_TT.Location = New System.Drawing.Point(97, 155)
        Me.lbOrder_TT.Name = "lbOrder_TT"
        Me.lbOrder_TT.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_TT.TabIndex = 43
        Me.lbOrder_TT.Text = "0"
        Me.lbOrder_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label56.Location = New System.Drawing.Point(7, 15)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(83, 21)
        Me.Label56.TabIndex = 34
        Me.Label56.Text = "ขายรวม"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label57.Location = New System.Drawing.Point(7, 155)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(83, 21)
        Me.Label57.TabIndex = 42
        Me.Label57.Text = "ขาย TT"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOrder_Sales
        '
        Me.lbOrder_Sales.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_Sales.Location = New System.Drawing.Point(97, 15)
        Me.lbOrder_Sales.Name = "lbOrder_Sales"
        Me.lbOrder_Sales.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_Sales.TabIndex = 35
        Me.lbOrder_Sales.Text = "0"
        Me.lbOrder_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrder_GPProfit
        '
        Me.lbOrder_GPProfit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_GPProfit.Location = New System.Drawing.Point(97, 99)
        Me.lbOrder_GPProfit.Name = "lbOrder_GPProfit"
        Me.lbOrder_GPProfit.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_GPProfit.TabIndex = 41
        Me.lbOrder_GPProfit.Text = "0"
        Me.lbOrder_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label61.Location = New System.Drawing.Point(7, 43)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(83, 21)
        Me.Label61.TabIndex = 36
        Me.Label61.Text = "กำไรรวม"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label62.Location = New System.Drawing.Point(7, 99)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(83, 21)
        Me.Label62.TabIndex = 40
        Me.Label62.Text = "กำไร GP"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOrder_Profit
        '
        Me.lbOrder_Profit.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_Profit.Location = New System.Drawing.Point(97, 43)
        Me.lbOrder_Profit.Name = "lbOrder_Profit"
        Me.lbOrder_Profit.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_Profit.TabIndex = 37
        Me.lbOrder_Profit.Text = "0"
        Me.lbOrder_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrder_GP
        '
        Me.lbOrder_GP.BackColor = System.Drawing.Color.MediumPurple
        Me.lbOrder_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOrder_GP.ForeColor = System.Drawing.Color.Black
        Me.lbOrder_GP.Location = New System.Drawing.Point(97, 71)
        Me.lbOrder_GP.Name = "lbOrder_GP"
        Me.lbOrder_GP.Size = New System.Drawing.Size(113, 21)
        Me.lbOrder_GP.TabIndex = 39
        Me.lbOrder_GP.Text = "0"
        Me.lbOrder_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label65.Location = New System.Drawing.Point(7, 71)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(83, 21)
        Me.Label65.TabIndex = 38
        Me.Label65.Text = "ขาย GP"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lbStd_GPWeight)
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.lbStd_TTProfit)
        Me.GroupBox9.Controls.Add(Me.Label42)
        Me.GroupBox9.Controls.Add(Me.lbStd_TT)
        Me.GroupBox9.Controls.Add(Me.Label47)
        Me.GroupBox9.Controls.Add(Me.Label50)
        Me.GroupBox9.Controls.Add(Me.lbStd_Sales)
        Me.GroupBox9.Controls.Add(Me.lbStd_GPProfit)
        Me.GroupBox9.Controls.Add(Me.Label54)
        Me.GroupBox9.Controls.Add(Me.Label55)
        Me.GroupBox9.Controls.Add(Me.lbStd_Profit)
        Me.GroupBox9.Controls.Add(Me.lbStd_GP)
        Me.GroupBox9.Controls.Add(Me.Label58)
        Me.GroupBox9.Location = New System.Drawing.Point(16, 421)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(271, 214)
        Me.GroupBox9.TabIndex = 48
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Std./Day"
        '
        'lbStd_GPWeight
        '
        Me.lbStd_GPWeight.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_GPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_GPWeight.ForeColor = System.Drawing.Color.Black
        Me.lbStd_GPWeight.Location = New System.Drawing.Point(97, 127)
        Me.lbStd_GPWeight.Name = "lbStd_GPWeight"
        Me.lbStd_GPWeight.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_GPWeight.TabIndex = 47
        Me.lbStd_GPWeight.Text = "0"
        Me.lbStd_GPWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 127)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 21)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "น้ำหนัก GP"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStd_TTProfit
        '
        Me.lbStd_TTProfit.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_TTProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_TTProfit.ForeColor = System.Drawing.Color.Black
        Me.lbStd_TTProfit.Location = New System.Drawing.Point(97, 183)
        Me.lbStd_TTProfit.Name = "lbStd_TTProfit"
        Me.lbStd_TTProfit.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_TTProfit.TabIndex = 45
        Me.lbStd_TTProfit.Text = "0"
        Me.lbStd_TTProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label42.Location = New System.Drawing.Point(7, 183)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(83, 21)
        Me.Label42.TabIndex = 44
        Me.Label42.Text = "กำไร TT"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStd_TT
        '
        Me.lbStd_TT.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_TT.ForeColor = System.Drawing.Color.Black
        Me.lbStd_TT.Location = New System.Drawing.Point(97, 155)
        Me.lbStd_TT.Name = "lbStd_TT"
        Me.lbStd_TT.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_TT.TabIndex = 43
        Me.lbStd_TT.Text = "0"
        Me.lbStd_TT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label47.Location = New System.Drawing.Point(7, 15)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(83, 21)
        Me.Label47.TabIndex = 34
        Me.Label47.Text = "ขายรวม"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label50.Location = New System.Drawing.Point(7, 155)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(83, 21)
        Me.Label50.TabIndex = 42
        Me.Label50.Text = "ขาย TT"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStd_Sales
        '
        Me.lbStd_Sales.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_Sales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_Sales.ForeColor = System.Drawing.Color.Black
        Me.lbStd_Sales.Location = New System.Drawing.Point(97, 15)
        Me.lbStd_Sales.Name = "lbStd_Sales"
        Me.lbStd_Sales.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_Sales.TabIndex = 35
        Me.lbStd_Sales.Text = "0"
        Me.lbStd_Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbStd_GPProfit
        '
        Me.lbStd_GPProfit.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_GPProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_GPProfit.ForeColor = System.Drawing.Color.Black
        Me.lbStd_GPProfit.Location = New System.Drawing.Point(97, 99)
        Me.lbStd_GPProfit.Name = "lbStd_GPProfit"
        Me.lbStd_GPProfit.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_GPProfit.TabIndex = 41
        Me.lbStd_GPProfit.Text = "0"
        Me.lbStd_GPProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label54.Location = New System.Drawing.Point(7, 43)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(83, 21)
        Me.Label54.TabIndex = 36
        Me.Label54.Text = "กำไรรวม"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label55.Location = New System.Drawing.Point(7, 99)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(83, 21)
        Me.Label55.TabIndex = 40
        Me.Label55.Text = "กำไร GP"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStd_Profit
        '
        Me.lbStd_Profit.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_Profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_Profit.ForeColor = System.Drawing.Color.Black
        Me.lbStd_Profit.Location = New System.Drawing.Point(97, 43)
        Me.lbStd_Profit.Name = "lbStd_Profit"
        Me.lbStd_Profit.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_Profit.TabIndex = 37
        Me.lbStd_Profit.Text = "0"
        Me.lbStd_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbStd_GP
        '
        Me.lbStd_GP.BackColor = System.Drawing.Color.SkyBlue
        Me.lbStd_GP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStd_GP.ForeColor = System.Drawing.Color.Black
        Me.lbStd_GP.Location = New System.Drawing.Point(97, 71)
        Me.lbStd_GP.Name = "lbStd_GP"
        Me.lbStd_GP.Size = New System.Drawing.Size(165, 21)
        Me.lbStd_GP.TabIndex = 39
        Me.lbStd_GP.Text = "0"
        Me.lbStd_GP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label58.Location = New System.Drawing.Point(7, 71)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(83, 21)
        Me.Label58.TabIndex = 38
        Me.Label58.Text = "ขาย GP"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.lsvGreen)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.lbDifAmt)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lbTotalTarget)
        Me.TabPage2.Controls.Add(Me.lbTotalAmt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lbCountItem)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Green"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Cornsilk
        Me.TabPage3.Controls.Add(Me.Label83)
        Me.TabPage3.Controls.Add(Me.GroupBox14)
        Me.TabPage3.Controls.Add(Me.Label85)
        Me.TabPage3.Controls.Add(Me.Label88)
        Me.TabPage3.Controls.Add(Me.Label89)
        Me.TabPage3.Controls.Add(Me.Label90)
        Me.TabPage3.Controls.Add(Me.Label91)
        Me.TabPage3.Controls.Add(Me.Label92)
        Me.TabPage3.Controls.Add(Me.Label93)
        Me.TabPage3.Controls.Add(Me.lsvYellow)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Yellow"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label83.Location = New System.Drawing.Point(586, 542)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(29, 17)
        Me.Label83.TabIndex = 23
        Me.Label83.Text = "Diff"
        Me.Label83.Visible = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.RadioButton3)
        Me.GroupBox14.Controls.Add(Me.RadioButton7)
        Me.GroupBox14.Controls.Add(Me.RadioButton8)
        Me.GroupBox14.Controls.Add(Me.RadioButton9)
        Me.GroupBox14.Controls.Add(Me.Label84)
        Me.GroupBox14.Location = New System.Drawing.Point(6, 470)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(468, 49)
        Me.GroupBox14.TabIndex = 15
        Me.GroupBox14.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(352, 17)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(89, 22)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.Text = "เขตการขาย"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(150, 17)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "ยอดขายรวม"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Checked = True
        Me.RadioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(249, 17)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(97, 22)
        Me.RadioButton8.TabIndex = 5
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "วันที่ซื้อล่าสุด"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(53, 17)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(95, 22)
        Me.RadioButton9.TabIndex = 4
        Me.RadioButton9.Text = "ตาม Target"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label84.Location = New System.Drawing.Point(10, 19)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(37, 17)
        Me.Label84.TabIndex = 3
        Me.Label84.Text = "ลำดับ"
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.YellowGreen
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label85.Location = New System.Drawing.Point(621, 537)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(148, 28)
        Me.Label85.TabIndex = 22
        Me.Label85.Text = "Label2"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label85.Visible = False
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label88.Location = New System.Drawing.Point(375, 544)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(51, 17)
        Me.Label88.TabIndex = 19
        Me.Label88.Text = "ขายรวม"
        Me.Label88.Visible = False
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.YellowGreen
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label89.Location = New System.Drawing.Point(215, 537)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(148, 28)
        Me.Label89.TabIndex = 20
        Me.Label89.Text = "Label2"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label89.Visible = False
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.YellowGreen
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label90.Location = New System.Drawing.Point(430, 537)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(148, 28)
        Me.Label90.TabIndex = 18
        Me.Label90.Text = "Label2"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label90.Visible = False
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label91.Location = New System.Drawing.Point(162, 544)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(52, 17)
        Me.Label91.TabIndex = 21
        Me.Label91.Text = "เป้า-ขาย"
        Me.Label91.Visible = False
        '
        'Label92
        '
        Me.Label92.BackColor = System.Drawing.Color.YellowGreen
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label92.Location = New System.Drawing.Point(64, 537)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(76, 28)
        Me.Label92.TabIndex = 16
        Me.Label92.Text = "Label2"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label92.Visible = False
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label93.Location = New System.Drawing.Point(13, 546)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(46, 17)
        Me.Label93.TabIndex = 17
        Me.Label93.Text = "จำนวน"
        Me.Label93.Visible = False
        '
        'lsvYellow
        '
        Me.lsvYellow.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lsvYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvYellow.FullRowSelect = True
        Me.lsvYellow.HideSelection = False
        Me.lsvYellow.Location = New System.Drawing.Point(6, 6)
        Me.lsvYellow.Name = "lsvYellow"
        Me.lsvYellow.Size = New System.Drawing.Size(1267, 458)
        Me.lsvYellow.TabIndex = 1
        Me.lsvYellow.UseCompatibleStateImageBehavior = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.MistyRose
        Me.TabPage4.Controls.Add(Me.lsvOrang)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Orang"
        '
        'lsvOrang
        '
        Me.lsvOrang.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lsvOrang.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvOrang.FullRowSelect = True
        Me.lsvOrang.HideSelection = False
        Me.lsvOrang.Location = New System.Drawing.Point(7, 9)
        Me.lsvOrang.Name = "lsvOrang"
        Me.lsvOrang.Size = New System.Drawing.Size(1267, 458)
        Me.lsvOrang.TabIndex = 2
        Me.lsvOrang.UseCompatibleStateImageBehavior = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage5.Controls.Add(Me.lsvRed)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Red"
        '
        'lsvRed
        '
        Me.lsvRed.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lsvRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvRed.FullRowSelect = True
        Me.lsvRed.HideSelection = False
        Me.lsvRed.Location = New System.Drawing.Point(6, 7)
        Me.lsvRed.Name = "lsvRed"
        Me.lsvRed.Size = New System.Drawing.Size(1267, 458)
        Me.lsvRed.TabIndex = 3
        Me.lsvRed.UseCompatibleStateImageBehavior = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label66)
        Me.TabPage6.Controls.Add(Me.lbCusTotal)
        Me.TabPage6.Controls.Add(Me.lbcustotalStr)
        Me.TabPage6.Controls.Add(Me.Label59)
        Me.TabPage6.Controls.Add(Me.Label60)
        Me.TabPage6.Controls.Add(Me.Label63)
        Me.TabPage6.Controls.Add(Me.Label64)
        Me.TabPage6.Controls.Add(Me.lbCusRedQty)
        Me.TabPage6.Controls.Add(Me.lbCusOrangQty)
        Me.TabPage6.Controls.Add(Me.lbCusYellowQty)
        Me.TabPage6.Controls.Add(Me.lbCusGreenQty)
        Me.TabPage6.Controls.Add(Me.Label46)
        Me.TabPage6.Controls.Add(Me.Label53)
        Me.TabPage6.Controls.Add(Me.Label16)
        Me.TabPage6.Controls.Add(Me.Label9)
        Me.TabPage6.Controls.Add(Me.chartCusActive)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1279, 645)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "กราฟลูกค้า Active"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.White
        Me.Label66.Location = New System.Drawing.Point(1223, 355)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(53, 37)
        Me.Label66.TabIndex = 73
        Me.Label66.Text = "ราย"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusTotal
        '
        Me.lbCusTotal.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCusTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusTotal.ForeColor = System.Drawing.Color.White
        Me.lbCusTotal.Location = New System.Drawing.Point(1079, 355)
        Me.lbCusTotal.Name = "lbCusTotal"
        Me.lbCusTotal.Size = New System.Drawing.Size(115, 37)
        Me.lbCusTotal.TabIndex = 72
        Me.lbCusTotal.Text = "0"
        Me.lbCusTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbcustotalStr
        '
        Me.lbcustotalStr.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbcustotalStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbcustotalStr.ForeColor = System.Drawing.Color.White
        Me.lbcustotalStr.Location = New System.Drawing.Point(834, 355)
        Me.lbcustotalStr.Name = "lbcustotalStr"
        Me.lbcustotalStr.Size = New System.Drawing.Size(405, 37)
        Me.lbcustotalStr.TabIndex = 71
        Me.lbcustotalStr.Text = "รวมทั้งหมด"
        Me.lbcustotalStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Brown
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(1223, 296)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(53, 37)
        Me.Label59.TabIndex = 69
        Me.Label59.Text = "ราย"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(1223, 236)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(53, 37)
        Me.Label60.TabIndex = 70
        Me.Label60.Text = "ราย"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Yellow
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(1223, 174)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(53, 37)
        Me.Label63.TabIndex = 68
        Me.Label63.Text = "ราย"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.GreenYellow
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(1223, 121)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(53, 37)
        Me.Label64.TabIndex = 67
        Me.Label64.Text = "ราย"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusRedQty
        '
        Me.lbCusRedQty.BackColor = System.Drawing.Color.Brown
        Me.lbCusRedQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusRedQty.ForeColor = System.Drawing.Color.White
        Me.lbCusRedQty.Location = New System.Drawing.Point(1079, 296)
        Me.lbCusRedQty.Name = "lbCusRedQty"
        Me.lbCusRedQty.Size = New System.Drawing.Size(115, 37)
        Me.lbCusRedQty.TabIndex = 65
        Me.lbCusRedQty.Text = "0"
        Me.lbCusRedQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusOrangQty
        '
        Me.lbCusOrangQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusOrangQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusOrangQty.ForeColor = System.Drawing.Color.Black
        Me.lbCusOrangQty.Location = New System.Drawing.Point(1079, 236)
        Me.lbCusOrangQty.Name = "lbCusOrangQty"
        Me.lbCusOrangQty.Size = New System.Drawing.Size(115, 37)
        Me.lbCusOrangQty.TabIndex = 66
        Me.lbCusOrangQty.Text = "0"
        Me.lbCusOrangQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusYellowQty
        '
        Me.lbCusYellowQty.BackColor = System.Drawing.Color.Yellow
        Me.lbCusYellowQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusYellowQty.ForeColor = System.Drawing.Color.Black
        Me.lbCusYellowQty.Location = New System.Drawing.Point(1079, 174)
        Me.lbCusYellowQty.Name = "lbCusYellowQty"
        Me.lbCusYellowQty.Size = New System.Drawing.Size(115, 37)
        Me.lbCusYellowQty.TabIndex = 64
        Me.lbCusYellowQty.Text = "0"
        Me.lbCusYellowQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCusGreenQty
        '
        Me.lbCusGreenQty.BackColor = System.Drawing.Color.GreenYellow
        Me.lbCusGreenQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusGreenQty.ForeColor = System.Drawing.Color.Black
        Me.lbCusGreenQty.Location = New System.Drawing.Point(1079, 121)
        Me.lbCusGreenQty.Name = "lbCusGreenQty"
        Me.lbCusGreenQty.Size = New System.Drawing.Size(115, 37)
        Me.lbCusGreenQty.TabIndex = 63
        Me.lbCusGreenQty.Text = "0"
        Me.lbCusGreenQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Brown
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(834, 296)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(405, 37)
        Me.Label46.TabIndex = 61
        Me.Label46.Text = "ลูกค้าขาดการติดต่อ 6 เดือน"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(834, 236)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(405, 37)
        Me.Label53.TabIndex = 62
        Me.Label53.Text = "ลูกค้าขาดการติดต่อ 2 เดือน"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Yellow
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(834, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(405, 37)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "ลูกค้าขาดการติดต่อ 1 เดือน"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.GreenYellow
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(834, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(405, 37)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "ลูกค้าปกติ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chartCusActive
        '
        ChartArea4.Name = "ChartArea1"
        Me.chartCusActive.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.chartCusActive.Legends.Add(Legend4)
        Me.chartCusActive.Location = New System.Drawing.Point(3, 7)
        Me.chartCusActive.Name = "chartCusActive"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.chartCusActive.Series.Add(Series4)
        Me.chartCusActive.Size = New System.Drawing.Size(929, 623)
        Me.chartCusActive.TabIndex = 58
        Me.chartCusActive.Text = "Chart1"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.chk0)
        Me.GroupBox11.Controls.Add(Me.chk100)
        Me.GroupBox11.Location = New System.Drawing.Point(1001, -2)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(175, 52)
        Me.GroupBox11.TabIndex = 46
        Me.GroupBox11.TabStop = False
        '
        'chk0
        '
        Me.chk0.AutoSize = True
        Me.chk0.Checked = True
        Me.chk0.Location = New System.Drawing.Point(104, 21)
        Me.chk0.Name = "chk0"
        Me.chk0.Size = New System.Drawing.Size(52, 17)
        Me.chk0.TabIndex = 1
        Me.chk0.TabStop = True
        Me.chk0.Text = "chk 0"
        Me.chk0.UseVisualStyleBackColor = True
        '
        'chk100
        '
        Me.chk100.AutoSize = True
        Me.chk100.Location = New System.Drawing.Point(14, 20)
        Me.chk100.Name = "chk100"
        Me.chk100.Size = New System.Drawing.Size(61, 17)
        Me.chk100.TabIndex = 0
        Me.chk100.TabStop = True
        Me.chk100.Text = "chk100"
        Me.chk100.UseVisualStyleBackColor = True
        '
        'cmbRptDetl
        '
        Me.cmbRptDetl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbRptDetl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbRptDetl.ForeColor = System.Drawing.Color.White
        Me.cmbRptDetl.Location = New System.Drawing.Point(401, 6)
        Me.cmbRptDetl.Name = "cmbRptDetl"
        Me.cmbRptDetl.Size = New System.Drawing.Size(115, 39)
        Me.cmbRptDetl.TabIndex = 47
        Me.cmbRptDetl.Text = "รายละเอียด "
        Me.cmbRptDetl.UseVisualStyleBackColor = False
        '
        'frmCSreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1305, 729)
        Me.Controls.Add(Me.cmbRptDetl)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbUpdate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lbCScode)
        Me.Controls.Add(Me.lbCSname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCSreport"
        Me.Text = "frmCSreport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.chartYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.chartAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.chartCusItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.chartCusActive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvGreen As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCSname As Label
    Friend WithEvents lbCScode As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optOrdLastDate As RadioButton
    Friend WithEvents optOrdTarget As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents optOrdSumSales As RadioButton
    Friend WithEvents cmbUpdate As Button
    Friend WithEvents lbCountItem As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbTotalAmt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTotalTarget As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbDifAmt As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbTarget_Sales As Label
    Friend WithEvents lbTarget_Profit As Label
    Friend WithEvents chartYear As DataVisualization.Charting.Chart
    Friend WithEvents lbTarget_GPProfit As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbTarget_GP As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbTarget_TTProfit As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbTarget_TT As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbTarget_GPWeight As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chartAct As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbAct_GPweight As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbAct_TTProfit As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbAct_TT As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbAct_Sales As Label
    Friend WithEvents lbAct_GPProfit As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbAct_Profit As Label
    Friend WithEvents lbAct_GP As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbDayQty As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbDiff_TargetGPWeight As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbDiff_TargetTTProfit As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbDiff_TargetTT As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lbDiff_TargetSales As Label
    Friend WithEvents lbDiff_TargetGPPrifit As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lbDiff_TargetProfit As Label
    Friend WithEvents lbDiff_TargetGP As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbActDay As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbSim_GPWeight As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lbSim_TTProfit As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lbSim_TT As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lbSim_Target As Label
    Friend WithEvents lbSim_GPProfit As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents lbSim_Profit As Label
    Friend WithEvents lbSim_GPtarget As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbDayQty0 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lbPerf_GPWeight As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lbPerf_TTProfit As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lbPerf_TT As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents lbPerf_Sales As Label
    Friend WithEvents lbPerf_GPProfit As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents lbPerf_Profit As Label
    Friend WithEvents lbPerf_GP As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents lbStd_GPWeight As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lbStd_TTProfit As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents lbStd_TT As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lbStd_Sales As Label
    Friend WithEvents lbStd_GPProfit As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents lbStd_Profit As Label
    Friend WithEvents lbStd_GP As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents optZone As RadioButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lbOrder_GPWeight As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents lbOrder_TTProfit As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lbOrder_TT As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents lbOrder_Sales As Label
    Friend WithEvents lbOrder_GPProfit As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents lbOrder_Profit As Label
    Friend WithEvents lbOrder_GP As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents lbRatioAct_GPWeight As Label
    Friend WithEvents lbRatioAct_TTProfit As Label
    Friend WithEvents lbRatioAct_TT As Label
    Friend WithEvents lbRatioAct_Sales As Label
    Friend WithEvents lbRatioAct_GPProFit As Label
    Friend WithEvents lbRatioAct_Profit As Label
    Friend WithEvents lbRatioAct_GP As Label
    Friend WithEvents lbRatioPerf_GPWeight As Label
    Friend WithEvents lbRatioPerf_TTProfit As Label
    Friend WithEvents lbRatioPerf_TT As Label
    Friend WithEvents lbRatioPerf_Sales As Label
    Friend WithEvents lbRatioPerf_GPProfit As Label
    Friend WithEvents lbRatioPerf_Profit As Label
    Friend WithEvents lbRatioPerf_GP As Label
    Friend WithEvents lbRatioDiff_GPWeight As Label
    Friend WithEvents lbRatioDiff_TTProfit As Label
    Friend WithEvents lbRatioDiff_TT As Label
    Friend WithEvents lbRatioDiff_Sales As Label
    Friend WithEvents lbRatioDiff_GPProfit As Label
    Friend WithEvents lbRatioDiff_Profit As Label
    Friend WithEvents lbRatioDiff_GP As Label
    Friend WithEvents opt_Profit As RadioButton
    Friend WithEvents opt_Sales As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents chk0 As RadioButton
    Friend WithEvents chk100 As RadioButton
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents lbDaily_GPWeight As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbDaily_TTProfit As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents lbDaily_TT As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents lbDaily_GPProfit As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents lbDaily_Profit As Label
    Friend WithEvents lbDaily_GP As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents lbCusItem2M As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents lbCusItem1M As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents lbCusItem As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label79 As Label
    Friend WithEvents lbCusItem0 As Label
    Friend WithEvents chartCusItem As DataVisualization.Charting.Chart
    Friend WithEvents lbRatio_CusItem0 As Label
    Friend WithEvents lbRatio_CusItem2M As Label
    Friend WithEvents lbRatio_CusItem1M As Label
    Friend WithEvents lbRatio_CusItem As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents lbDaily_Sales As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents Label84 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents lsvYellow As ListView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lsvOrang As ListView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lsvRed As ListView
    Friend WithEvents lbRatio_CusItem6M As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents lbCusItem6M As Label
    Friend WithEvents lbSLRatio_Sales As Label
    Friend WithEvents lbSLRatio_GPWeight As Label
    Friend WithEvents lbSLRatio_TTProfti As Label
    Friend WithEvents lbSLRatio_TT As Label
    Friend WithEvents lbSLRatio_GPProfit As Label
    Friend WithEvents lbSLRatio_Profit As Label
    Friend WithEvents lbSLRatio_GP As Label
    Friend WithEvents lbOrRatio_GPWeight As Label
    Friend WithEvents lbOrRatio_TTProfit As Label
    Friend WithEvents lbOrRatio_TT As Label
    Friend WithEvents lbOrRatio_Sales As Label
    Friend WithEvents lbOrRatio_GPProfit As Label
    Friend WithEvents lbOrRatio_Profit As Label
    Friend WithEvents lbOrRatio_GP As Label
    Friend WithEvents cmbRptDetl As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents chartCusActive As DataVisualization.Charting.Chart
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents lbCusRedQty As Label
    Friend WithEvents lbCusOrangQty As Label
    Friend WithEvents lbCusYellowQty As Label
    Friend WithEvents lbCusGreenQty As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents lbCusTotal As Label
    Friend WithEvents lbcustotalStr As Label
End Class
