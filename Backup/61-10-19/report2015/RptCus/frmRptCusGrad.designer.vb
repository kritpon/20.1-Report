<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptCusGrad
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
        Me.ChartCus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvCusGrade = New System.Windows.Forms.ListView()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cboSelSL = New System.Windows.Forms.ComboBox()
        Me.chkSelSL = New System.Windows.Forms.CheckBox()
        Me.lsvDetail = New System.Windows.Forms.ListView()
        Me.optPie = New System.Windows.Forms.RadioButton()
        Me.optTypeBar = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.chkCutNoDetl = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optOrderName = New System.Windows.Forms.RadioButton()
        Me.optOrderQty = New System.Windows.Forms.RadioButton()
        Me.labelxx = New System.Windows.Forms.Label()
        Me.lbTarget = New System.Windows.Forms.Label()
        Me.cmbPrint = New System.Windows.Forms.Button()
        CType(Me.ChartCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartCus
        '
        ChartArea1.IsSameFontSizeForAllAxes = True
        ChartArea1.Name = "ChartArea1"
        Me.ChartCus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartCus.Legends.Add(Legend1)
        Me.ChartCus.Location = New System.Drawing.Point(12, 21)
        Me.ChartCus.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartCus.Name = "ChartCus"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartCus.Series.Add(Series1)
        Me.ChartCus.Size = New System.Drawing.Size(970, 269)
        Me.ChartCus.TabIndex = 0
        Me.ChartCus.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvCusGrade)
        Me.GroupBox1.Controls.Add(Me.lbTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(985, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(324, 288)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lsvCusGrade
        '
        Me.lsvCusGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvCusGrade.Location = New System.Drawing.Point(10, 23)
        Me.lsvCusGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvCusGrade.Name = "lsvCusGrade"
        Me.lsvCusGrade.Size = New System.Drawing.Size(306, 222)
        Me.lsvCusGrade.TabIndex = 0
        Me.lsvCusGrade.UseCompatibleStateImageBehavior = False
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.YellowGreen
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(108, 255)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(206, 24)
        Me.lbTotal.TabIndex = 33
        Me.lbTotal.Text = "จำนวนรวม"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 260)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "จำนวนรวม"
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdRun.Location = New System.Drawing.Point(995, 298)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(148, 47)
        Me.cmdRun.TabIndex = 2
        Me.cmdRun.Text = "ดูรายงาน"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'cboSelSL
        '
        Me.cboSelSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSelSL.FormattingEnabled = True
        Me.cboSelSL.Location = New System.Drawing.Point(822, 313)
        Me.cboSelSL.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSelSL.Name = "cboSelSL"
        Me.cboSelSL.Size = New System.Drawing.Size(162, 28)
        Me.cboSelSL.TabIndex = 23
        '
        'chkSelSL
        '
        Me.chkSelSL.AutoSize = True
        Me.chkSelSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSL.Location = New System.Drawing.Point(720, 314)
        Me.chkSelSL.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelSL.Name = "chkSelSL"
        Me.chkSelSL.Size = New System.Drawing.Size(97, 22)
        Me.chkSelSL.TabIndex = 27
        Me.chkSelSL.Text = "พนักงานขาย"
        Me.chkSelSL.UseVisualStyleBackColor = True
        '
        'lsvDetail
        '
        Me.lsvDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvDetail.Location = New System.Drawing.Point(14, 356)
        Me.lsvDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDetail.Name = "lsvDetail"
        Me.lsvDetail.Size = New System.Drawing.Size(1286, 313)
        Me.lsvDetail.TabIndex = 28
        Me.lsvDetail.UseCompatibleStateImageBehavior = False
        '
        'optPie
        '
        Me.optPie.AutoSize = True
        Me.optPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optPie.Location = New System.Drawing.Point(14, 314)
        Me.optPie.Margin = New System.Windows.Forms.Padding(2)
        Me.optPie.Name = "optPie"
        Me.optPie.Size = New System.Drawing.Size(86, 24)
        Me.optPie.TabIndex = 29
        Me.optPie.Text = "กราฟ Pie"
        Me.optPie.UseVisualStyleBackColor = True
        '
        'optTypeBar
        '
        Me.optTypeBar.AutoSize = True
        Me.optTypeBar.Checked = True
        Me.optTypeBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optTypeBar.Location = New System.Drawing.Point(118, 314)
        Me.optTypeBar.Margin = New System.Windows.Forms.Padding(2)
        Me.optTypeBar.Name = "optTypeBar"
        Me.optTypeBar.Size = New System.Drawing.Size(118, 24)
        Me.optTypeBar.TabIndex = 30
        Me.optTypeBar.TabStop = True
        Me.optTypeBar.Text = "กราฟ Column"
        Me.optTypeBar.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Brown
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(1151, 673)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(148, 47)
        Me.cmdExit.TabIndex = 31
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'chkCutNoDetl
        '
        Me.chkCutNoDetl.AutoSize = True
        Me.chkCutNoDetl.Checked = True
        Me.chkCutNoDetl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCutNoDetl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCutNoDetl.Location = New System.Drawing.Point(255, 314)
        Me.chkCutNoDetl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCutNoDetl.Name = "chkCutNoDetl"
        Me.chkCutNoDetl.Size = New System.Drawing.Size(114, 22)
        Me.chkCutNoDetl.TabIndex = 34
        Me.chkCutNoDetl.Text = "ตัด-ไม่ระบุเกรด"
        Me.chkCutNoDetl.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optOrderName)
        Me.GroupBox2.Controls.Add(Me.optOrderQty)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 305)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(255, 38)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'optOrderName
        '
        Me.optOrderName.AutoSize = True
        Me.optOrderName.BackColor = System.Drawing.Color.DarkOrange
        Me.optOrderName.Checked = True
        Me.optOrderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrderName.Location = New System.Drawing.Point(144, 9)
        Me.optOrderName.Margin = New System.Windows.Forms.Padding(2)
        Me.optOrderName.Name = "optOrderName"
        Me.optOrderName.Size = New System.Drawing.Size(95, 22)
        Me.optOrderName.TabIndex = 1
        Me.optOrderName.TabStop = True
        Me.optOrderName.Text = "ลำดับตามชื่อ"
        Me.optOrderName.UseVisualStyleBackColor = False
        '
        'optOrderQty
        '
        Me.optOrderQty.AutoSize = True
        Me.optOrderQty.BackColor = System.Drawing.Color.SaddleBrown
        Me.optOrderQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrderQty.ForeColor = System.Drawing.Color.White
        Me.optOrderQty.Location = New System.Drawing.Point(8, 8)
        Me.optOrderQty.Margin = New System.Windows.Forms.Padding(2)
        Me.optOrderQty.Name = "optOrderQty"
        Me.optOrderQty.Size = New System.Drawing.Size(117, 22)
        Me.optOrderQty.TabIndex = 0
        Me.optOrderQty.Text = "ลำดับตามจำนวน"
        Me.optOrderQty.UseVisualStyleBackColor = False
        '
        'labelxx
        '
        Me.labelxx.AutoSize = True
        Me.labelxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelxx.Location = New System.Drawing.Point(743, 693)
        Me.labelxx.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelxx.Name = "labelxx"
        Me.labelxx.Size = New System.Drawing.Size(94, 20)
        Me.labelxx.TabIndex = 36
        Me.labelxx.Text = "Total Target"
        '
        'lbTarget
        '
        Me.lbTarget.BackColor = System.Drawing.Color.Black
        Me.lbTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget.ForeColor = System.Drawing.Color.Yellow
        Me.lbTarget.Location = New System.Drawing.Point(850, 681)
        Me.lbTarget.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTarget.Name = "lbTarget"
        Me.lbTarget.Size = New System.Drawing.Size(294, 32)
        Me.lbTarget.TabIndex = 37
        Me.lbTarget.Text = "0"
        Me.lbTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPrint.ForeColor = System.Drawing.Color.White
        Me.cmbPrint.Location = New System.Drawing.Point(1150, 298)
        Me.cmbPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(144, 47)
        Me.cmbPrint.TabIndex = 38
        Me.cmbPrint.Text = "Print"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'frmRptCusGrad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1360, 741)
        Me.Controls.Add(Me.cmbPrint)
        Me.Controls.Add(Me.lbTarget)
        Me.Controls.Add(Me.labelxx)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkCutNoDetl)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.optTypeBar)
        Me.Controls.Add(Me.optPie)
        Me.Controls.Add(Me.lsvDetail)
        Me.Controls.Add(Me.chkSelSL)
        Me.Controls.Add(Me.cboSelSL)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChartCus)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRptCusGrad"
        Me.Text = "frmRptCusGrad"
        CType(Me.ChartCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartCus As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lsvCusGrade As ListView
    Friend WithEvents cmdRun As Button
    Friend WithEvents cboSelSL As ComboBox
    Friend WithEvents chkSelSL As CheckBox
    Friend WithEvents lsvDetail As ListView
    Friend WithEvents optPie As RadioButton
    Friend WithEvents optTypeBar As RadioButton
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents chkCutNoDetl As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optOrderName As RadioButton
    Friend WithEvents optOrderQty As RadioButton
    Friend WithEvents labelxx As Label
    Friend WithEvents lbTarget As Label
    Friend WithEvents cmbPrint As Button
End Class
