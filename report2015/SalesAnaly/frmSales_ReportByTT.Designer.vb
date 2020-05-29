<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales_ReportByTT
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
        Me.lbSalesName = New System.Windows.Forms.Label()
        Me.lsvARdetail = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCountCust = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbCountDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotalDiff = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotalProfit61 = New System.Windows.Forms.Label()
        Me.lbProfit1 = New System.Windows.Forms.Label()
        Me.lbTotalProfit60 = New System.Windows.Forms.Label()
        Me.lbProfit0 = New System.Windows.Forms.Label()
        Me.lbTotalRetio = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbDateKPIProfit = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optOrProfit61 = New System.Windows.Forms.RadioButton()
        Me.optOrProfit60 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optOrZA = New System.Windows.Forms.RadioButton()
        Me.optOrAZ = New System.Windows.Forms.RadioButton()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbSalesName
        '
        Me.lbSalesName.BackColor = System.Drawing.Color.YellowGreen
        Me.lbSalesName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSalesName.ForeColor = System.Drawing.Color.Black
        Me.lbSalesName.Location = New System.Drawing.Point(991, 187)
        Me.lbSalesName.Name = "lbSalesName"
        Me.lbSalesName.Size = New System.Drawing.Size(154, 26)
        Me.lbSalesName.TabIndex = 17
        Me.lbSalesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsvARdetail
        '
        Me.lsvARdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvARdetail.FullRowSelect = True
        Me.lsvARdetail.Location = New System.Drawing.Point(7, 5)
        Me.lsvARdetail.Name = "lsvARdetail"
        Me.lsvARdetail.Size = New System.Drawing.Size(872, 551)
        Me.lsvARdetail.TabIndex = 16
        Me.lsvARdetail.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(884, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCountCust
        '
        Me.lbCountCust.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCountCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCountCust.ForeColor = System.Drawing.Color.Black
        Me.lbCountCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCountCust.Location = New System.Drawing.Point(991, 220)
        Me.lbCountCust.Name = "lbCountCust"
        Me.lbCountCust.Size = New System.Drawing.Size(154, 26)
        Me.lbCountCust.TabIndex = 19
        Me.lbCountCust.Text = "0"
        Me.lbCountCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(884, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "จำนวนลูกค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(882, 7)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(362, 174)
        Me.Chart1.TabIndex = 21
        Me.Chart1.Text = "Chart1"
        '
        'lbCountDate
        '
        Me.lbCountDate.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCountDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCountDate.ForeColor = System.Drawing.Color.Black
        Me.lbCountDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCountDate.Location = New System.Drawing.Point(991, 356)
        Me.lbCountDate.Name = "lbCountDate"
        Me.lbCountDate.Size = New System.Drawing.Size(154, 26)
        Me.lbCountDate.TabIndex = 22
        Me.lbCountDate.Text = "0"
        Me.lbCountDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Khaki
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(884, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "นับถอยหลัง 61"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalDiff
        '
        Me.lbTotalDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbTotalDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalDiff.ForeColor = System.Drawing.Color.Black
        Me.lbTotalDiff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbTotalDiff.Location = New System.Drawing.Point(991, 324)
        Me.lbTotalDiff.Name = "lbTotalDiff"
        Me.lbTotalDiff.Size = New System.Drawing.Size(154, 26)
        Me.lbTotalDiff.TabIndex = 28
        Me.lbTotalDiff.Text = "0"
        Me.lbTotalDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Khaki
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(884, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 26)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ผลต่าง "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalProfit61
        '
        Me.lbTotalProfit61.BackColor = System.Drawing.Color.Cyan
        Me.lbTotalProfit61.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit61.ForeColor = System.Drawing.Color.Black
        Me.lbTotalProfit61.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbTotalProfit61.Location = New System.Drawing.Point(991, 293)
        Me.lbTotalProfit61.Name = "lbTotalProfit61"
        Me.lbTotalProfit61.Size = New System.Drawing.Size(154, 26)
        Me.lbTotalProfit61.TabIndex = 26
        Me.lbTotalProfit61.Text = "0"
        Me.lbTotalProfit61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProfit1
        '
        Me.lbProfit1.BackColor = System.Drawing.Color.Khaki
        Me.lbProfit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProfit1.ForeColor = System.Drawing.Color.Black
        Me.lbProfit1.Location = New System.Drawing.Point(884, 293)
        Me.lbProfit1.Name = "lbProfit1"
        Me.lbProfit1.Size = New System.Drawing.Size(101, 26)
        Me.lbProfit1.TabIndex = 27
        Me.lbProfit1.Text = "กำไรรวมปี 61"
        Me.lbProfit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalProfit60
        '
        Me.lbTotalProfit60.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbTotalProfit60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit60.ForeColor = System.Drawing.Color.Black
        Me.lbTotalProfit60.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbTotalProfit60.Location = New System.Drawing.Point(991, 260)
        Me.lbTotalProfit60.Name = "lbTotalProfit60"
        Me.lbTotalProfit60.Size = New System.Drawing.Size(154, 26)
        Me.lbTotalProfit60.TabIndex = 24
        Me.lbTotalProfit60.Text = "0"
        Me.lbTotalProfit60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProfit0
        '
        Me.lbProfit0.BackColor = System.Drawing.Color.Khaki
        Me.lbProfit0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProfit0.ForeColor = System.Drawing.Color.Black
        Me.lbProfit0.Location = New System.Drawing.Point(884, 260)
        Me.lbProfit0.Name = "lbProfit0"
        Me.lbProfit0.Size = New System.Drawing.Size(101, 26)
        Me.lbProfit0.TabIndex = 25
        Me.lbProfit0.Text = "กำไรรวมปี 60"
        Me.lbProfit0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalRetio
        '
        Me.lbTotalRetio.BackColor = System.Drawing.Color.White
        Me.lbTotalRetio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalRetio.ForeColor = System.Drawing.Color.Black
        Me.lbTotalRetio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbTotalRetio.Location = New System.Drawing.Point(1151, 324)
        Me.lbTotalRetio.Name = "lbTotalRetio"
        Me.lbTotalRetio.Size = New System.Drawing.Size(61, 26)
        Me.lbTotalRetio.TabIndex = 30
        Me.lbTotalRetio.Text = "0"
        Me.lbTotalRetio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Khaki
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1218, 324)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 26)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Khaki
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1151, 356)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 26)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "วัน"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Khaki
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1151, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 26)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "ราย"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Khaki
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(1151, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 26)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "บาท"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Khaki
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1151, 293)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 26)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "บาท"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDateKPIProfit
        '
        Me.lbDateKPIProfit.BackColor = System.Drawing.Color.Cyan
        Me.lbDateKPIProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDateKPIProfit.ForeColor = System.Drawing.Color.Black
        Me.lbDateKPIProfit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbDateKPIProfit.Location = New System.Drawing.Point(991, 388)
        Me.lbDateKPIProfit.Name = "lbDateKPIProfit"
        Me.lbDateKPIProfit.Size = New System.Drawing.Size(154, 26)
        Me.lbDateKPIProfit.TabIndex = 36
        Me.lbDateKPIProfit.Text = "0"
        Me.lbDateKPIProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Khaki
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(884, 388)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 26)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "KPI / วัน"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Khaki
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(1151, 388)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 26)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "บาท"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1133, 526)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(122, 40)
        Me.cmbExit.TabIndex = 39
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optOrProfit61)
        Me.GroupBox1.Controls.Add(Me.optOrProfit60)
        Me.GroupBox1.Location = New System.Drawing.Point(888, 420)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 72)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order by"
        '
        'optOrProfit61
        '
        Me.optOrProfit61.AutoSize = True
        Me.optOrProfit61.Location = New System.Drawing.Point(15, 44)
        Me.optOrProfit61.Name = "optOrProfit61"
        Me.optOrProfit61.Size = New System.Drawing.Size(113, 17)
        Me.optOrProfit61.TabIndex = 1
        Me.optOrProfit61.Text = "Order by - กำไร 61"
        Me.optOrProfit61.UseVisualStyleBackColor = True
        '
        'optOrProfit60
        '
        Me.optOrProfit60.AutoSize = True
        Me.optOrProfit60.Checked = True
        Me.optOrProfit60.Location = New System.Drawing.Point(14, 17)
        Me.optOrProfit60.Name = "optOrProfit60"
        Me.optOrProfit60.Size = New System.Drawing.Size(110, 17)
        Me.optOrProfit60.TabIndex = 0
        Me.optOrProfit60.TabStop = True
        Me.optOrProfit60.Text = "Order by- กำไร 60"
        Me.optOrProfit60.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optOrZA)
        Me.GroupBox2.Controls.Add(Me.optOrAZ)
        Me.GroupBox2.Location = New System.Drawing.Point(1175, 420)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(87, 72)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'optOrZA
        '
        Me.optOrZA.AutoSize = True
        Me.optOrZA.Checked = True
        Me.optOrZA.Location = New System.Drawing.Point(15, 43)
        Me.optOrZA.Name = "optOrZA"
        Me.optOrZA.Size = New System.Drawing.Size(51, 17)
        Me.optOrZA.TabIndex = 1
        Me.optOrZA.TabStop = True
        Me.optOrZA.Text = "Z-->A"
        Me.optOrZA.UseVisualStyleBackColor = True
        '
        'optOrAZ
        '
        Me.optOrAZ.AutoSize = True
        Me.optOrAZ.Location = New System.Drawing.Point(14, 16)
        Me.optOrAZ.Name = "optOrAZ"
        Me.optOrAZ.Size = New System.Drawing.Size(51, 17)
        Me.optOrAZ.TabIndex = 0
        Me.optOrAZ.Text = "A-->Z"
        Me.optOrAZ.UseVisualStyleBackColor = True
        '
        'frmSales_ReportByTT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1275, 596)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbDateKPIProfit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbTotalRetio)
        Me.Controls.Add(Me.lbTotalDiff)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbTotalProfit61)
        Me.Controls.Add(Me.lbProfit1)
        Me.Controls.Add(Me.lbTotalProfit60)
        Me.Controls.Add(Me.lbProfit0)
        Me.Controls.Add(Me.lbCountDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lbCountCust)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbSalesName)
        Me.Controls.Add(Me.lsvARdetail)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmSales_ReportByTT"
        Me.Text = "รายงานยอด TT "
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbSalesName As Label
    Friend WithEvents lsvARdetail As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents lbCountCust As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lbCountDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTotalDiff As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTotalProfit61 As Label
    Friend WithEvents lbProfit1 As Label
    Friend WithEvents lbTotalProfit60 As Label
    Friend WithEvents lbProfit0 As Label
    Friend WithEvents lbTotalRetio As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbDateKPIProfit As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optOrProfit61 As RadioButton
    Friend WithEvents optOrProfit60 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optOrZA As RadioButton
    Friend WithEvents optOrAZ As RadioButton
End Class
