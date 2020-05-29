<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales_Menu
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbRunRptTT = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "รายงานภาพรวม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbRunRptTT
        '
        Me.cmbRunRptTT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbRunRptTT.Location = New System.Drawing.Point(23, 84)
        Me.cmbRunRptTT.Name = "cmbRunRptTT"
        Me.cmbRunRptTT.Size = New System.Drawing.Size(203, 56)
        Me.cmbRunRptTT.TabIndex = 1
        Me.cmbRunRptTT.Text = "รายงาน สินค้า TT"
        Me.cmbRunRptTT.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(23, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(203, 56)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "รายงานสินค้าGP"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'frmSales_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 305)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmbRunRptTT)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSales_Menu"
        Me.Text = "frmSales_Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cmbRunRptTT As Button
    Friend WithEvents Button3 As Button
End Class
