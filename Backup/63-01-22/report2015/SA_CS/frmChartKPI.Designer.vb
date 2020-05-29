<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChartKPI
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
        Me.chartAct = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.lbStd_Profit = New System.Windows.Forms.Label()
        Me.lbPerf_Profit = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbDayQty0 = New System.Windows.Forms.Label()
        Me.lbActDay = New System.Windows.Forms.Label()
        Me.lbDayQty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbSim_Profit = New System.Windows.Forms.Label()
        CType(Me.chartAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartAct
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartAct.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartAct.Legends.Add(Legend1)
        Me.chartAct.Location = New System.Drawing.Point(7, 10)
        Me.chartAct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chartAct.Name = "chartAct"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartAct.Series.Add(Series1)
        Me.chartAct.Size = New System.Drawing.Size(981, 497)
        Me.chartAct.TabIndex = 0
        Me.chartAct.Text = "Chart1"
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(854, 580)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(124, 38)
        Me.cmbExit.TabIndex = 1
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'lbStd_Profit
        '
        Me.lbStd_Profit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbStd_Profit.Location = New System.Drawing.Point(173, 546)
        Me.lbStd_Profit.Name = "lbStd_Profit"
        Me.lbStd_Profit.Size = New System.Drawing.Size(149, 20)
        Me.lbStd_Profit.TabIndex = 2
        Me.lbStd_Profit.Text = "Label1"
        Me.lbStd_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPerf_Profit
        '
        Me.lbPerf_Profit.BackColor = System.Drawing.Color.YellowGreen
        Me.lbPerf_Profit.Location = New System.Drawing.Point(173, 574)
        Me.lbPerf_Profit.Name = "lbPerf_Profit"
        Me.lbPerf_Profit.Size = New System.Drawing.Size(149, 20)
        Me.lbPerf_Profit.TabIndex = 3
        Me.lbPerf_Profit.Text = "Label2"
        Me.lbPerf_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb
        '
        Me.lb.BackColor = System.Drawing.Color.Silver
        Me.lb.Location = New System.Drawing.Point(18, 574)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(149, 20)
        Me.lb.TabIndex = 5
        Me.lb.Text = "Actual_Profit"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(18, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Target_Profit"
        '
        'lbDayQty0
        '
        Me.lbDayQty0.BackColor = System.Drawing.Color.Blue
        Me.lbDayQty0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDayQty0.ForeColor = System.Drawing.Color.White
        Me.lbDayQty0.Location = New System.Drawing.Point(337, 574)
        Me.lbDayQty0.Name = "lbDayQty0"
        Me.lbDayQty0.Size = New System.Drawing.Size(165, 21)
        Me.lbDayQty0.TabIndex = 46
        Me.lbDayQty0.Text = "0"
        Me.lbDayQty0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbActDay
        '
        Me.lbActDay.BackColor = System.Drawing.Color.Blue
        Me.lbActDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbActDay.ForeColor = System.Drawing.Color.White
        Me.lbActDay.Location = New System.Drawing.Point(337, 546)
        Me.lbActDay.Name = "lbActDay"
        Me.lbActDay.Size = New System.Drawing.Size(165, 21)
        Me.lbActDay.TabIndex = 45
        Me.lbActDay.Text = "0"
        Me.lbActDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDayQty
        '
        Me.lbDayQty.BackColor = System.Drawing.Color.Blue
        Me.lbDayQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDayQty.ForeColor = System.Drawing.Color.White
        Me.lbDayQty.Location = New System.Drawing.Point(337, 605)
        Me.lbDayQty.Name = "lbDayQty"
        Me.lbDayQty.Size = New System.Drawing.Size(165, 21)
        Me.lbDayQty.TabIndex = 44
        Me.lbDayQty.Text = "0"
        Me.lbDayQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(18, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Sim_Profit"
        '
        'lbSim_Profit
        '
        Me.lbSim_Profit.BackColor = System.Drawing.Color.Yellow
        Me.lbSim_Profit.Location = New System.Drawing.Point(173, 605)
        Me.lbSim_Profit.Name = "lbSim_Profit"
        Me.lbSim_Profit.Size = New System.Drawing.Size(149, 20)
        Me.lbSim_Profit.TabIndex = 47
        Me.lbSim_Profit.Text = "Label1"
        Me.lbSim_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmChartKPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 645)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbSim_Profit)
        Me.Controls.Add(Me.lbDayQty0)
        Me.Controls.Add(Me.lbActDay)
        Me.Controls.Add(Me.lbDayQty)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbPerf_Profit)
        Me.Controls.Add(Me.lbStd_Profit)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.chartAct)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmChartKPI"
        Me.Text = "frmChartKPI"
        CType(Me.chartAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartAct As DataVisualization.Charting.Chart
    Friend WithEvents cmbExit As Button
    Friend WithEvents lbStd_Profit As Label
    Friend WithEvents lbPerf_Profit As Label
    Friend WithEvents lb As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbDayQty0 As Label
    Friend WithEvents lbActDay As Label
    Friend WithEvents lbDayQty As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbSim_Profit As Label
End Class
