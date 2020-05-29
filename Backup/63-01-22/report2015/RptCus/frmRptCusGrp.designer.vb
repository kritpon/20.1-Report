<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptCusGrp
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvCusGrade = New System.Windows.Forms.ListView()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartCus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.chkSelSL = New System.Windows.Forms.CheckBox()
        Me.cboSelSL = New System.Windows.Forms.ComboBox()
        Me.optTypeBar = New System.Windows.Forms.RadioButton()
        Me.optPie = New System.Windows.Forms.RadioButton()
        Me.lsvDetail = New System.Windows.Forms.ListView()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.chkCutNoDetl = New System.Windows.Forms.CheckBox()
        Me.lbTarget = New System.Windows.Forms.Label()
        Me.labelxx = New System.Windows.Forms.Label()
        Me.cmbPrint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvCusGrade)
        Me.GroupBox1.Controls.Add(Me.lbTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(986, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(307, 303)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lsvCusGrade
        '
        Me.lsvCusGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvCusGrade.Location = New System.Drawing.Point(10, 12)
        Me.lsvCusGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvCusGrade.Name = "lsvCusGrade"
        Me.lsvCusGrade.Size = New System.Drawing.Size(288, 260)
        Me.lsvCusGrade.TabIndex = 0
        Me.lsvCusGrade.UseCompatibleStateImageBehavior = False
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.YellowGreen
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(106, 271)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(190, 24)
        Me.lbTotal.TabIndex = 35
        Me.lbTotal.Text = "จำนวนรวม"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "จำนวนรวม"
        '
        'ChartCus
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartCus.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartCus.Legends.Add(Legend1)
        Me.ChartCus.Location = New System.Drawing.Point(9, 9)
        Me.ChartCus.Margin = New System.Windows.Forms.Padding(2)
        Me.ChartCus.Name = "ChartCus"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartCus.Series.Add(Series1)
        Me.ChartCus.Size = New System.Drawing.Size(970, 296)
        Me.ChartCus.TabIndex = 3
        Me.ChartCus.Text = "Chart1"
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.Gold
        Me.cmdRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdRun.Location = New System.Drawing.Point(996, 307)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(148, 47)
        Me.cmdRun.TabIndex = 5
        Me.cmdRun.Text = "ดูรายงาน"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'chkSelSL
        '
        Me.chkSelSL.AutoSize = True
        Me.chkSelSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelSL.Location = New System.Drawing.Point(618, 323)
        Me.chkSelSL.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelSL.Name = "chkSelSL"
        Me.chkSelSL.Size = New System.Drawing.Size(124, 22)
        Me.chkSelSL.TabIndex = 29
        Me.chkSelSL.Text = "เลือกพนักงานขาย"
        Me.chkSelSL.UseVisualStyleBackColor = True
        '
        'cboSelSL
        '
        Me.cboSelSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSelSL.FormattingEnabled = True
        Me.cboSelSL.Location = New System.Drawing.Point(750, 319)
        Me.cboSelSL.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSelSL.Name = "cboSelSL"
        Me.cboSelSL.Size = New System.Drawing.Size(232, 32)
        Me.cboSelSL.TabIndex = 28
        '
        'optTypeBar
        '
        Me.optTypeBar.AutoSize = True
        Me.optTypeBar.Checked = True
        Me.optTypeBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optTypeBar.Location = New System.Drawing.Point(128, 319)
        Me.optTypeBar.Margin = New System.Windows.Forms.Padding(2)
        Me.optTypeBar.Name = "optTypeBar"
        Me.optTypeBar.Size = New System.Drawing.Size(118, 24)
        Me.optTypeBar.TabIndex = 35
        Me.optTypeBar.TabStop = True
        Me.optTypeBar.Text = "กราฟ Column"
        Me.optTypeBar.UseVisualStyleBackColor = True
        '
        'optPie
        '
        Me.optPie.AutoSize = True
        Me.optPie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optPie.Location = New System.Drawing.Point(24, 319)
        Me.optPie.Margin = New System.Windows.Forms.Padding(2)
        Me.optPie.Name = "optPie"
        Me.optPie.Size = New System.Drawing.Size(86, 24)
        Me.optPie.TabIndex = 34
        Me.optPie.Text = "กราฟ Pie"
        Me.optPie.UseVisualStyleBackColor = True
        '
        'lsvDetail
        '
        Me.lsvDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvDetail.Location = New System.Drawing.Point(9, 358)
        Me.lsvDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDetail.Name = "lsvDetail"
        Me.lsvDetail.Size = New System.Drawing.Size(1286, 312)
        Me.lsvDetail.TabIndex = 33
        Me.lsvDetail.UseCompatibleStateImageBehavior = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Brown
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(1145, 674)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(148, 47)
        Me.cmdExit.TabIndex = 36
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'chkCutNoDetl
        '
        Me.chkCutNoDetl.AutoSize = True
        Me.chkCutNoDetl.Checked = True
        Me.chkCutNoDetl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCutNoDetl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkCutNoDetl.Location = New System.Drawing.Point(259, 319)
        Me.chkCutNoDetl.Margin = New System.Windows.Forms.Padding(2)
        Me.chkCutNoDetl.Name = "chkCutNoDetl"
        Me.chkCutNoDetl.Size = New System.Drawing.Size(150, 22)
        Me.chkCutNoDetl.TabIndex = 37
        Me.chkCutNoDetl.Text = "ตัด-ไม่ระบุ Segment"
        Me.chkCutNoDetl.UseVisualStyleBackColor = True
        '
        'lbTarget
        '
        Me.lbTarget.BackColor = System.Drawing.Color.Black
        Me.lbTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTarget.ForeColor = System.Drawing.Color.Yellow
        Me.lbTarget.Location = New System.Drawing.Point(844, 682)
        Me.lbTarget.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTarget.Name = "lbTarget"
        Me.lbTarget.Size = New System.Drawing.Size(294, 32)
        Me.lbTarget.TabIndex = 40
        Me.lbTarget.Text = "0"
        Me.lbTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelxx
        '
        Me.labelxx.AutoSize = True
        Me.labelxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.labelxx.Location = New System.Drawing.Point(746, 694)
        Me.labelxx.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelxx.Name = "labelxx"
        Me.labelxx.Size = New System.Drawing.Size(94, 20)
        Me.labelxx.TabIndex = 39
        Me.labelxx.Text = "Total Target"
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmbPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPrint.ForeColor = System.Drawing.Color.White
        Me.cmbPrint.Location = New System.Drawing.Point(1146, 307)
        Me.cmbPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(148, 47)
        Me.cmbPrint.TabIndex = 41
        Me.cmbPrint.Text = "Print"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'frmRptCusGrp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1303, 741)
        Me.Controls.Add(Me.cmbPrint)
        Me.Controls.Add(Me.lbTarget)
        Me.Controls.Add(Me.labelxx)
        Me.Controls.Add(Me.chkCutNoDetl)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.optTypeBar)
        Me.Controls.Add(Me.optPie)
        Me.Controls.Add(Me.lsvDetail)
        Me.Controls.Add(Me.chkSelSL)
        Me.Controls.Add(Me.cboSelSL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChartCus)
        Me.Controls.Add(Me.cmdRun)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRptCusGrp"
        Me.Text = "frmRptCusGrp"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ChartCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lsvCusGrade As ListView
    Friend WithEvents ChartCus As DataVisualization.Charting.Chart
    Friend WithEvents cmdRun As Button
    Friend WithEvents chkSelSL As CheckBox
    Friend WithEvents cboSelSL As ComboBox
    Friend WithEvents optTypeBar As RadioButton
    Friend WithEvents optPie As RadioButton
    Friend WithEvents lsvDetail As ListView
    Friend WithEvents cmdExit As Button
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkCutNoDetl As CheckBox
    Friend WithEvents lbTarget As Label
    Friend WithEvents labelxx As Label
    Friend WithEvents cmbPrint As Button
End Class
