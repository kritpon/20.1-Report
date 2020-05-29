<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStkRota
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
        Me.lsvItem = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbTypeID = New System.Windows.Forms.Label()
        Me.lbProdID = New System.Windows.Forms.Label()
        Me.cboFactor1 = New System.Windows.Forms.ComboBox()
        Me.cboFactor2 = New System.Windows.Forms.ComboBox()
        Me.cboFactor22 = New System.Windows.Forms.ComboBox()
        Me.chkF2 = New System.Windows.Forms.CheckBox()
        Me.cboFactor11 = New System.Windows.Forms.ComboBox()
        Me.chkF1 = New System.Windows.Forms.CheckBox()
        Me.chkSales = New System.Windows.Forms.CheckBox()
        Me.chkSegment = New System.Windows.Forms.CheckBox()
        Me.cboSales = New System.Windows.Forms.ComboBox()
        Me.cboSegment = New System.Windows.Forms.ComboBox()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.txtDate01 = New System.Windows.Forms.DateTimePicker()
        Me.txtDate02 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optAmt2 = New System.Windows.Forms.RadioButton()
        Me.optAmt1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.optDesc = New System.Windows.Forms.RadioButton()
        Me.optASC = New System.Windows.Forms.RadioButton()
        Me.lsvRptSegment = New System.Windows.Forms.ListView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.chartTotal = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.chartTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsvItem
        '
        Me.lsvItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvItem.FullRowSelect = True
        Me.lsvItem.Location = New System.Drawing.Point(6, 37)
        Me.lsvItem.Name = "lsvItem"
        Me.lsvItem.Size = New System.Drawing.Size(790, 446)
        Me.lsvItem.TabIndex = 0
        Me.lsvItem.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbTypeID)
        Me.GroupBox1.Controls.Add(Me.lbProdID)
        Me.GroupBox1.Controls.Add(Me.cboFactor1)
        Me.GroupBox1.Controls.Add(Me.cboFactor2)
        Me.GroupBox1.Controls.Add(Me.cboFactor22)
        Me.GroupBox1.Controls.Add(Me.chkF2)
        Me.GroupBox1.Controls.Add(Me.cboFactor11)
        Me.GroupBox1.Controls.Add(Me.chkF1)
        Me.GroupBox1.Location = New System.Drawing.Point(819, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 83)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สินค้าเป้าหมาย"
        '
        'lbTypeID
        '
        Me.lbTypeID.ForeColor = System.Drawing.Color.Black
        Me.lbTypeID.Location = New System.Drawing.Point(347, 54)
        Me.lbTypeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTypeID.Name = "lbTypeID"
        Me.lbTypeID.Size = New System.Drawing.Size(60, 14)
        Me.lbTypeID.TabIndex = 50
        Me.lbTypeID.Text = "Label11"
        '
        'lbProdID
        '
        Me.lbProdID.ForeColor = System.Drawing.Color.Black
        Me.lbProdID.Location = New System.Drawing.Point(347, 24)
        Me.lbProdID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProdID.Name = "lbProdID"
        Me.lbProdID.Size = New System.Drawing.Size(60, 14)
        Me.lbProdID.TabIndex = 49
        Me.lbProdID.Text = "Label10"
        '
        'cboFactor1
        '
        Me.cboFactor1.FormattingEnabled = True
        Me.cboFactor1.Location = New System.Drawing.Point(79, 21)
        Me.cboFactor1.Name = "cboFactor1"
        Me.cboFactor1.Size = New System.Drawing.Size(111, 21)
        Me.cboFactor1.TabIndex = 48
        '
        'cboFactor2
        '
        Me.cboFactor2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor2.FormattingEnabled = True
        Me.cboFactor2.Location = New System.Drawing.Point(79, 45)
        Me.cboFactor2.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor2.Name = "cboFactor2"
        Me.cboFactor2.Size = New System.Drawing.Size(110, 24)
        Me.cboFactor2.TabIndex = 45
        '
        'cboFactor22
        '
        Me.cboFactor22.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor22.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor22.FormattingEnabled = True
        Me.cboFactor22.Location = New System.Drawing.Point(193, 45)
        Me.cboFactor22.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor22.Name = "cboFactor22"
        Me.cboFactor22.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor22.TabIndex = 41
        '
        'chkF2
        '
        Me.chkF2.AutoSize = True
        Me.chkF2.ForeColor = System.Drawing.Color.Black
        Me.chkF2.Location = New System.Drawing.Point(13, 49)
        Me.chkF2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF2.Name = "chkF2"
        Me.chkF2.Size = New System.Drawing.Size(62, 17)
        Me.chkF2.TabIndex = 40
        Me.chkF2.Text = "Factor2"
        Me.chkF2.UseVisualStyleBackColor = True
        '
        'cboFactor11
        '
        Me.cboFactor11.BackColor = System.Drawing.Color.YellowGreen
        Me.cboFactor11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboFactor11.FormattingEnabled = True
        Me.cboFactor11.Location = New System.Drawing.Point(193, 20)
        Me.cboFactor11.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFactor11.Name = "cboFactor11"
        Me.cboFactor11.Size = New System.Drawing.Size(150, 24)
        Me.cboFactor11.TabIndex = 39
        '
        'chkF1
        '
        Me.chkF1.AutoSize = True
        Me.chkF1.ForeColor = System.Drawing.Color.Black
        Me.chkF1.Location = New System.Drawing.Point(13, 24)
        Me.chkF1.Margin = New System.Windows.Forms.Padding(2)
        Me.chkF1.Name = "chkF1"
        Me.chkF1.Size = New System.Drawing.Size(62, 17)
        Me.chkF1.TabIndex = 38
        Me.chkF1.Text = "Factor1"
        Me.chkF1.UseVisualStyleBackColor = True
        '
        'chkSales
        '
        Me.chkSales.AutoSize = True
        Me.chkSales.Checked = True
        Me.chkSales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSales.Location = New System.Drawing.Point(12, 8)
        Me.chkSales.Name = "chkSales"
        Me.chkSales.Size = New System.Drawing.Size(91, 22)
        Me.chkSales.TabIndex = 3
        Me.chkSales.Text = "ตาม Sales"
        Me.chkSales.UseVisualStyleBackColor = True
        '
        'chkSegment
        '
        Me.chkSegment.AutoSize = True
        Me.chkSegment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSegment.Location = New System.Drawing.Point(286, 8)
        Me.chkSegment.Name = "chkSegment"
        Me.chkSegment.Size = New System.Drawing.Size(113, 22)
        Me.chkSegment.TabIndex = 4
        Me.chkSegment.Text = "ตาม Segment"
        Me.chkSegment.UseVisualStyleBackColor = True
        '
        'cboSales
        '
        Me.cboSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSales.FormattingEnabled = True
        Me.cboSales.Location = New System.Drawing.Point(104, 4)
        Me.cboSales.Name = "cboSales"
        Me.cboSales.Size = New System.Drawing.Size(164, 26)
        Me.cboSales.TabIndex = 5
        '
        'cboSegment
        '
        Me.cboSegment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSegment.FormattingEnabled = True
        Me.cboSegment.Location = New System.Drawing.Point(405, 6)
        Me.cboSegment.Name = "cboSegment"
        Me.cboSegment.Size = New System.Drawing.Size(218, 26)
        Me.cboSegment.TabIndex = 6
        '
        'cmbRun
        '
        Me.cmbRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbRun.Location = New System.Drawing.Point(994, 490)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(123, 46)
        Me.cmbRun.TabIndex = 7
        Me.cmbRun.Text = "RUN"
        Me.cmbRun.UseVisualStyleBackColor = False
        '
        'txtDate01
        '
        Me.txtDate01.Location = New System.Drawing.Point(950, 322)
        Me.txtDate01.Name = "txtDate01"
        Me.txtDate01.Size = New System.Drawing.Size(127, 20)
        Me.txtDate01.TabIndex = 8
        '
        'txtDate02
        '
        Me.txtDate02.Location = New System.Drawing.Point(1117, 322)
        Me.txtDate02.Name = "txtDate02"
        Me.txtDate02.Size = New System.Drawing.Size(127, 20)
        Me.txtDate02.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1082, 326)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "ถึง"
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1123, 490)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(123, 46)
        Me.cmbExit.TabIndex = 53
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optAmt2)
        Me.GroupBox2.Controls.Add(Me.optAmt1)
        Me.GroupBox2.Location = New System.Drawing.Point(817, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 49)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'optAmt2
        '
        Me.optAmt2.AutoSize = True
        Me.optAmt2.Checked = True
        Me.optAmt2.Location = New System.Drawing.Point(98, 22)
        Me.optAmt2.Name = "optAmt2"
        Me.optAmt2.Size = New System.Drawing.Size(63, 17)
        Me.optAmt2.TabIndex = 1
        Me.optAmt2.TabStop = True
        Me.optAmt2.Text = "ยอดขาย"
        Me.optAmt2.UseVisualStyleBackColor = True
        '
        'optAmt1
        '
        Me.optAmt1.AutoSize = True
        Me.optAmt1.Location = New System.Drawing.Point(4, 22)
        Me.optAmt1.Name = "optAmt1"
        Me.optAmt1.Size = New System.Drawing.Size(81, 17)
        Me.optAmt1.TabIndex = 0
        Me.optAmt1.Text = "ยอดขาย GP"
        Me.optAmt1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optDesc)
        Me.GroupBox3.Controls.Add(Me.optASC)
        Me.GroupBox3.Location = New System.Drawing.Point(1104, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(138, 49)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'optDesc
        '
        Me.optDesc.AutoSize = True
        Me.optDesc.Checked = True
        Me.optDesc.Location = New System.Drawing.Point(80, 19)
        Me.optDesc.Name = "optDesc"
        Me.optDesc.Size = New System.Drawing.Size(42, 17)
        Me.optDesc.TabIndex = 3
        Me.optDesc.TabStop = True
        Me.optDesc.Text = "Z-A"
        Me.optDesc.UseVisualStyleBackColor = True
        '
        'optASC
        '
        Me.optASC.AutoSize = True
        Me.optASC.Location = New System.Drawing.Point(19, 19)
        Me.optASC.Name = "optASC"
        Me.optASC.Size = New System.Drawing.Size(42, 17)
        Me.optASC.TabIndex = 2
        Me.optASC.Text = "A-Z"
        Me.optASC.UseVisualStyleBackColor = True
        '
        'lsvRptSegment
        '
        Me.lsvRptSegment.Location = New System.Drawing.Point(808, 37)
        Me.lsvRptSegment.Name = "lsvRptSegment"
        Me.lsvRptSegment.Size = New System.Drawing.Size(457, 279)
        Me.lsvRptSegment.TabIndex = 56
        Me.lsvRptSegment.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1285, 590)
        Me.TabControl1.TabIndex = 57
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage1.Controls.Add(Me.chartTotal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1277, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage2.Controls.Add(Me.chkDate)
        Me.TabPage2.Controls.Add(Me.cboSegment)
        Me.TabPage2.Controls.Add(Me.cmbExit)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.cmbRun)
        Me.TabPage2.Controls.Add(Me.lsvRptSegment)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.chkSales)
        Me.TabPage2.Controls.Add(Me.chkSegment)
        Me.TabPage2.Controls.Add(Me.txtDate02)
        Me.TabPage2.Controls.Add(Me.cboSales)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lsvItem)
        Me.TabPage2.Controls.Add(Me.txtDate01)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1277, 564)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(873, 325)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(71, 17)
        Me.chkDate.TabIndex = 57
        Me.chkDate.Text = "เลือกวันที่"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'chartTotal
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartTotal.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartTotal.Legends.Add(Legend1)
        Me.chartTotal.Location = New System.Drawing.Point(11, 11)
        Me.chartTotal.Name = "chartTotal"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartTotal.Series.Add(Series1)
        Me.chartTotal.Size = New System.Drawing.Size(441, 226)
        Me.chartTotal.TabIndex = 0
        Me.chartTotal.Text = "Chart1"
        '
        'frmStkRota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1294, 599)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmStkRota"
        Me.Text = "frmBegin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.chartTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvItem As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboFactor2 As ComboBox
    Friend WithEvents cboFactor22 As ComboBox
    Friend WithEvents chkF2 As CheckBox
    Friend WithEvents cboFactor11 As ComboBox
    Friend WithEvents chkF1 As CheckBox
    Friend WithEvents cboFactor1 As ComboBox
    Friend WithEvents lbTypeID As Label
    Friend WithEvents lbProdID As Label
    Friend WithEvents chkSales As CheckBox
    Friend WithEvents chkSegment As CheckBox
    Friend WithEvents cboSales As ComboBox
    Friend WithEvents cboSegment As ComboBox
    Friend WithEvents cmbRun As Button
    Friend WithEvents txtDate01 As DateTimePicker
    Friend WithEvents txtDate02 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optAmt2 As RadioButton
    Friend WithEvents optAmt1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents optDesc As RadioButton
    Friend WithEvents optASC As RadioButton
    Friend WithEvents lsvRptSegment As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chkDate As CheckBox
    Friend WithEvents chartTotal As DataVisualization.Charting.Chart
End Class
