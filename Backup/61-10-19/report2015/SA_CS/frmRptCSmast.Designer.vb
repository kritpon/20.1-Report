<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCSmast
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
        Me.lsvCSlist = New System.Windows.Forms.ListView()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lsvCSlist
        '
        Me.lsvCSlist.BackColor = System.Drawing.Color.Gainsboro
        Me.lsvCSlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvCSlist.FullRowSelect = True
        Me.lsvCSlist.Location = New System.Drawing.Point(7, 8)
        Me.lsvCSlist.Name = "lsvCSlist"
        Me.lsvCSlist.Size = New System.Drawing.Size(1280, 208)
        Me.lsvCSlist.TabIndex = 0
        Me.lsvCSlist.UseCompatibleStateImageBehavior = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1188, 233)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(99, 41)
        Me.cmbExit.TabIndex = 1
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'frmCSmast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1299, 286)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.lsvCSlist)
        Me.Name = "frmCSmast"
        Me.Text = "ข้อมูล CS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvCSlist As ListView
    Friend WithEvents cmbExit As Button
End Class
