<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindWH
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
        Me.lbWHID = New System.Windows.Forms.Label
        Me.lbWHName = New System.Windows.Forms.TextBox
        Me.dataShow = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbOK = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmbExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbWHID
        '
        Me.lbWHID.BackColor = System.Drawing.Color.AliceBlue
        Me.lbWHID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHID.Location = New System.Drawing.Point(96, 16)
        Me.lbWHID.Name = "lbWHID"
        Me.lbWHID.Size = New System.Drawing.Size(65, 23)
        Me.lbWHID.TabIndex = 10
        '
        'lbWHName
        '
        Me.lbWHName.BackColor = System.Drawing.Color.Yellow
        Me.lbWHName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWHName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWHName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbWHName.Location = New System.Drawing.Point(160, 16)
        Me.lbWHName.MaxLength = 60
        Me.lbWHName.Name = "lbWHName"
        Me.lbWHName.Size = New System.Drawing.Size(344, 23)
        Me.lbWHName.TabIndex = 8
        '
        'dataShow
        '
        Me.dataShow.DataMember = ""
        Me.dataShow.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dataShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataShow.Location = New System.Drawing.Point(4, 5)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.ReadOnly = True
        Me.dataShow.Size = New System.Drawing.Size(616, 240)
        Me.dataShow.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "คลังสินค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOK
        '
        Me.cmbOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.White
        Me.cmbOK.Location = New System.Drawing.Point(512, 13)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(90, 34)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "เลือก"
        Me.cmbOK.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(160, 16)
        Me.TextBox1.MaxLength = 60
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 21)
        Me.TextBox1.TabIndex = 8
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.DarkRed
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(516, 309)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(90, 24)
        Me.cmbExit.TabIndex = 26
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbWHID)
        Me.GroupBox1.Controls.Add(Me.lbWHName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 56)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'frmFindWH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 352)
        Me.Controls.Add(Me.dataShow)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFindWH"
        Me.Text = "เลือกคลังสินค้า"
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbWHID As System.Windows.Forms.Label
    Friend WithEvents lbWHName As System.Windows.Forms.TextBox
    Friend WithEvents dataShow As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
