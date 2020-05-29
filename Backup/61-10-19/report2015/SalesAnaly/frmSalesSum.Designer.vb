<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesSum
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
        Me.lsvSales = New System.Windows.Forms.ListView()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbTotalKPI = New System.Windows.Forms.Label()
        Me.lbTotalTarget = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotalYear59 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbCountCus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTotalProfit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotalAmt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsvSales
        '
        Me.lsvSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvSales.FullRowSelect = True
        Me.lsvSales.Location = New System.Drawing.Point(12, 8)
        Me.lsvSales.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvSales.Name = "lsvSales"
        Me.lsvSales.Size = New System.Drawing.Size(1150, 283)
        Me.lsvSales.TabIndex = 0
        Me.lsvSales.UseCompatibleStateImageBehavior = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1038, 360)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(124, 48)
        Me.cmbExit.TabIndex = 1
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KPI รวม"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalKPI
        '
        Me.lbTotalKPI.BackColor = System.Drawing.Color.Blue
        Me.lbTotalKPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalKPI.ForeColor = System.Drawing.Color.White
        Me.lbTotalKPI.Location = New System.Drawing.Point(83, 293)
        Me.lbTotalKPI.Name = "lbTotalKPI"
        Me.lbTotalKPI.Size = New System.Drawing.Size(108, 26)
        Me.lbTotalKPI.TabIndex = 3
        Me.lbTotalKPI.Text = "0"
        Me.lbTotalKPI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalTarget
        '
        Me.lbTotalTarget.BackColor = System.Drawing.Color.Blue
        Me.lbTotalTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalTarget.ForeColor = System.Drawing.Color.White
        Me.lbTotalTarget.Location = New System.Drawing.Point(615, 293)
        Me.lbTotalTarget.Name = "lbTotalTarget"
        Me.lbTotalTarget.Size = New System.Drawing.Size(108, 26)
        Me.lbTotalTarget.TabIndex = 5
        Me.lbTotalTarget.Text = "0"
        Me.lbTotalTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Target รวม"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalYear59
        '
        Me.lbTotalYear59.BackColor = System.Drawing.Color.Blue
        Me.lbTotalYear59.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalYear59.ForeColor = System.Drawing.Color.White
        Me.lbTotalYear59.Location = New System.Drawing.Point(430, 293)
        Me.lbTotalYear59.Name = "lbTotalYear59"
        Me.lbTotalYear59.Size = New System.Drawing.Size(108, 26)
        Me.lbTotalYear59.TabIndex = 7
        Me.lbTotalYear59.Text = "0"
        Me.lbTotalYear59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ยอดปี 59"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCountCus
        '
        Me.lbCountCus.BackColor = System.Drawing.Color.Blue
        Me.lbCountCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCountCus.ForeColor = System.Drawing.Color.White
        Me.lbCountCus.Location = New System.Drawing.Point(267, 293)
        Me.lbCountCus.Name = "lbCountCus"
        Me.lbCountCus.Size = New System.Drawing.Size(88, 26)
        Me.lbCountCus.TabIndex = 9
        Me.lbCountCus.Text = "0"
        Me.lbCountCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "จำนวนลูกค้า"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalProfit
        '
        Me.lbTotalProfit.BackColor = System.Drawing.Color.Blue
        Me.lbTotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalProfit.ForeColor = System.Drawing.Color.White
        Me.lbTotalProfit.Location = New System.Drawing.Point(796, 293)
        Me.lbTotalProfit.Name = "lbTotalProfit"
        Me.lbTotalProfit.Size = New System.Drawing.Size(108, 26)
        Me.lbTotalProfit.TabIndex = 11
        Me.lbTotalProfit.Text = "0"
        Me.lbTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(726, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "กำไร รวม"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbTotalAmt
        '
        Me.lbTotalAmt.BackColor = System.Drawing.Color.Blue
        Me.lbTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalAmt.ForeColor = System.Drawing.Color.White
        Me.lbTotalAmt.Location = New System.Drawing.Point(978, 293)
        Me.lbTotalAmt.Name = "lbTotalAmt"
        Me.lbTotalAmt.Size = New System.Drawing.Size(108, 26)
        Me.lbTotalAmt.TabIndex = 13
        Me.lbTotalAmt.Text = "0"
        Me.lbTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(907, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ยอดขาย"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSalesSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1190, 419)
        Me.Controls.Add(Me.lbTotalAmt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbTotalProfit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbCountCus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbTotalYear59)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbTotalTarget)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbTotalKPI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.lsvSales)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSalesSum"
        Me.Text = "Sales Summary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvSales As ListView
    Friend WithEvents cmbExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbTotalKPI As Label
    Friend WithEvents lbTotalTarget As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTotalYear59 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbCountCus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTotalProfit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTotalAmt As Label
    Friend WithEvents Label7 As Label
End Class
