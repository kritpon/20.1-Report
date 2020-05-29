<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesSum
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
        Me.lsvSales = New System.Windows.Forms.ListView()
        Me.cmbExit = New System.Windows.Forms.Button()
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
        Me.cmbExit.Location = New System.Drawing.Point(1038, 295)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(124, 48)
        Me.cmbExit.TabIndex = 1
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'frmSalesSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1190, 358)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.lsvSales)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSalesSum"
        Me.Text = "Sales Summary"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvSales As ListView
    Friend WithEvents cmbExit As Button
End Class
