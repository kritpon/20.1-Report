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
        Me.lsvDetail = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCSname = New System.Windows.Forms.Label()
        Me.lbCScode = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optOrdSumSales = New System.Windows.Forms.RadioButton()
        Me.optOrdLastDate = New System.Windows.Forms.RadioButton()
        Me.optOrdTarget = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvDetail
        '
        Me.lsvDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvDetail.FullRowSelect = True
        Me.lsvDetail.Location = New System.Drawing.Point(6, 6)
        Me.lsvDetail.Name = "lsvDetail"
        Me.lsvDetail.Size = New System.Drawing.Size(1041, 367)
        Me.lsvDetail.TabIndex = 0
        Me.lsvDetail.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อ CS"
        '
        'lbCSname
        '
        Me.lbCSname.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCSname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCSname.Location = New System.Drawing.Point(60, 439)
        Me.lbCSname.Name = "lbCSname"
        Me.lbCSname.Size = New System.Drawing.Size(148, 17)
        Me.lbCSname.TabIndex = 2
        Me.lbCSname.Text = "lbCSname"
        '
        'lbCScode
        '
        Me.lbCScode.BackColor = System.Drawing.Color.OliveDrab
        Me.lbCScode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCScode.Location = New System.Drawing.Point(212, 439)
        Me.lbCScode.Name = "lbCScode"
        Me.lbCScode.Size = New System.Drawing.Size(74, 17)
        Me.lbCScode.TabIndex = 3
        Me.lbCScode.Text = "lbCScode"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Maroon
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(932, 439)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(115, 39)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "ออก"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optOrdSumSales)
        Me.GroupBox1.Controls.Add(Me.optOrdLastDate)
        Me.GroupBox1.Controls.Add(Me.optOrdTarget)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 55)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'optOrdSumSales
        '
        Me.optOrdSumSales.AutoSize = True
        Me.optOrdSumSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdSumSales.Location = New System.Drawing.Point(208, 17)
        Me.optOrdSumSales.Name = "optOrdSumSales"
        Me.optOrdSumSales.Size = New System.Drawing.Size(95, 22)
        Me.optOrdSumSales.TabIndex = 6
        Me.optOrdSumSales.Text = "ยอดขายรวม"
        Me.optOrdSumSales.UseVisualStyleBackColor = True
        '
        'optOrdLastDate
        '
        Me.optOrdLastDate.AutoSize = True
        Me.optOrdLastDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdLastDate.Location = New System.Drawing.Point(336, 17)
        Me.optOrdLastDate.Name = "optOrdLastDate"
        Me.optOrdLastDate.Size = New System.Drawing.Size(97, 22)
        Me.optOrdLastDate.TabIndex = 5
        Me.optOrdLastDate.Text = "วันที่ซื้อล่าสุด"
        Me.optOrdLastDate.UseVisualStyleBackColor = True
        '
        'optOrdTarget
        '
        Me.optOrdTarget.AutoSize = True
        Me.optOrdTarget.Checked = True
        Me.optOrdTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optOrdTarget.Location = New System.Drawing.Point(53, 17)
        Me.optOrdTarget.Name = "optOrdTarget"
        Me.optOrdTarget.Size = New System.Drawing.Size(95, 22)
        Me.optOrdTarget.TabIndex = 4
        Me.optOrdTarget.TabStop = True
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
        Me.cmbUpdate.Location = New System.Drawing.Point(932, 384)
        Me.cmbUpdate.Name = "cmbUpdate"
        Me.cmbUpdate.Size = New System.Drawing.Size(115, 39)
        Me.cmbUpdate.TabIndex = 6
        Me.cmbUpdate.Text = "update"
        Me.cmbUpdate.UseVisualStyleBackColor = False
        '
        'frmCSreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1101, 603)
        Me.Controls.Add(Me.cmbUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lbCScode)
        Me.Controls.Add(Me.lbCSname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvDetail)
        Me.Name = "frmCSreport"
        Me.Text = "frmCSreport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvDetail As ListView
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
End Class
