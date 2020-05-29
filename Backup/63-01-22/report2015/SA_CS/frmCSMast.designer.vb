<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCSMast
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
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.cmbDel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdSel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvCS = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbExit
        '
        Me.cmbExit.ForeColor = System.Drawing.Color.Blue
        Me.cmbExit.Location = New System.Drawing.Point(277, 18)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(114, 34)
        Me.cmbExit.TabIndex = 10
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = True
        '
        'cmbDel
        '
        Me.cmbDel.Enabled = False
        Me.cmbDel.Location = New System.Drawing.Point(134, 20)
        Me.cmbDel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDel.Name = "cmbDel"
        Me.cmbDel.Size = New System.Drawing.Size(114, 34)
        Me.cmbDel.TabIndex = 9
        Me.cmbDel.Text = "ลบ"
        Me.cmbDel.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Yellow
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(59, 322)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 44)
        Me.txtName.TabIndex = 14
        '
        'cmdSave
        '
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.Color.Red
        Me.cmdSave.Location = New System.Drawing.Point(13, 20)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(113, 34)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "บันทึก"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdSel
        '
        Me.cmdSel.ForeColor = System.Drawing.Color.Red
        Me.cmdSel.Location = New System.Drawing.Point(290, 318)
        Me.cmdSel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSel.Name = "cmdSel"
        Me.cmdSel.Size = New System.Drawing.Size(114, 34)
        Me.cmdSel.TabIndex = 11
        Me.cmdSel.Text = "เลือก"
        Me.cmdSel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbExit)
        Me.GroupBox1.Controls.Add(Me.cmbDel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 59)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(12, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 36)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ชื่อ  :"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Location = New System.Drawing.Point(88, 360)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(65, 44)
        Me.txtCode.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "รหัส CS  :"
        '
        'lsvCS
        '
        Me.lsvCS.BackColor = System.Drawing.SystemColors.Info
        Me.lsvCS.FullRowSelect = True
        Me.lsvCS.Location = New System.Drawing.Point(6, 7)
        Me.lsvCS.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvCS.Name = "lsvCS"
        Me.lsvCS.Size = New System.Drawing.Size(398, 305)
        Me.lsvCS.TabIndex = 11
        Me.lsvCS.UseCompatibleStateImageBehavior = False
        '
        'frmCSMast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 506)
        Me.Controls.Add(Me.cmdSel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvCS)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCSMast"
        Me.Text = "สร้าง / แก้ไข พนักงาน CS"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents cmbDel As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsvCS As System.Windows.Forms.ListView
End Class
