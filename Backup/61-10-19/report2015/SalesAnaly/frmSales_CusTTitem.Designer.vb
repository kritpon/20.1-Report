<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales_CusTTitem
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
        Me.lbTotalItem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCusCode = New System.Windows.Forms.Label()
        Me.lsvStkItem = New System.Windows.Forms.ListView()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbTotalItem
        '
        Me.lbTotalItem.BackColor = System.Drawing.Color.YellowGreen
        Me.lbTotalItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalItem.ForeColor = System.Drawing.Color.Black
        Me.lbTotalItem.Location = New System.Drawing.Point(115, 541)
        Me.lbTotalItem.Name = "lbTotalItem"
        Me.lbTotalItem.Size = New System.Drawing.Size(154, 26)
        Me.lbTotalItem.TabIndex = 26
        Me.lbTotalItem.Text = "0"
        Me.lbTotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Khaki
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 541)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "จำนวน Item"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.Black
        Me.lbCusName.Location = New System.Drawing.Point(115, 508)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(363, 26)
        Me.lbCusName.TabIndex = 24
        Me.lbCusName.Text = "CusName"
        Me.lbCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ลูกค้า"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCusCode
        '
        Me.lbCusCode.BackColor = System.Drawing.Color.Khaki
        Me.lbCusCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusCode.ForeColor = System.Drawing.Color.Black
        Me.lbCusCode.Location = New System.Drawing.Point(476, 508)
        Me.lbCusCode.Name = "lbCusCode"
        Me.lbCusCode.Size = New System.Drawing.Size(101, 26)
        Me.lbCusCode.TabIndex = 30
        Me.lbCusCode.Text = "CusCode"
        Me.lbCusCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lsvStkItem
        '
        Me.lsvStkItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvStkItem.FullRowSelect = True
        Me.lsvStkItem.Location = New System.Drawing.Point(8, 8)
        Me.lsvStkItem.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvStkItem.Name = "lsvStkItem"
        Me.lsvStkItem.Size = New System.Drawing.Size(1225, 493)
        Me.lsvStkItem.TabIndex = 31
        Me.lsvStkItem.UseCompatibleStateImageBehavior = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1111, 556)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(122, 40)
        Me.cmbExit.TabIndex = 40
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'frmSales_CusTTitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1244, 608)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.lsvStkItem)
        Me.Controls.Add(Me.lbCusCode)
        Me.Controls.Add(Me.lbTotalItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSales_CusTTitem"
        Me.Text = "frmSales_CusTTitem"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbTotalItem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCusName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbCusCode As Label
    Friend WithEvents lsvStkItem As ListView
    Friend WithEvents cmbExit As Button
End Class
