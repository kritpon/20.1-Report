<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeCS
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
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.cmbUpdate = New System.Windows.Forms.Button()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.lbCSName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCScode = New System.Windows.Forms.Label()
        Me.cmbEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.Location = New System.Drawing.Point(120, 9)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(280, 25)
        Me.lbCusName.TabIndex = 0
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Yellow
        Me.lbCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(12, 9)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(102, 25)
        Me.lbCusID.TabIndex = 1
        '
        'cmbUpdate
        '
        Me.cmbUpdate.BackColor = System.Drawing.Color.Goldenrod
        Me.cmbUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbUpdate.Location = New System.Drawing.Point(439, 9)
        Me.cmbUpdate.Name = "cmbUpdate"
        Me.cmbUpdate.Size = New System.Drawing.Size(136, 47)
        Me.cmbUpdate.TabIndex = 2
        Me.cmbUpdate.Text = "Update"
        Me.cmbUpdate.UseVisualStyleBackColor = False
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(439, 122)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(136, 47)
        Me.cmbExit.TabIndex = 3
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'lbCSName
        '
        Me.lbCSName.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCSName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCSName.ForeColor = System.Drawing.Color.White
        Me.lbCSName.Location = New System.Drawing.Point(185, 52)
        Me.lbCSName.Name = "lbCSName"
        Me.lbCSName.Size = New System.Drawing.Size(191, 25)
        Me.lbCSName.TabIndex = 4
        Me.lbCSName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "..."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "เลือก CS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCScode
        '
        Me.lbCScode.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbCScode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCScode.ForeColor = System.Drawing.Color.White
        Me.lbCScode.Location = New System.Drawing.Point(120, 52)
        Me.lbCScode.Name = "lbCScode"
        Me.lbCScode.Size = New System.Drawing.Size(68, 25)
        Me.lbCScode.TabIndex = 7
        Me.lbCScode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEdit
        '
        Me.cmbEdit.BackColor = System.Drawing.Color.Yellow
        Me.cmbEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbEdit.Location = New System.Drawing.Point(439, 62)
        Me.cmbEdit.Name = "cmbEdit"
        Me.cmbEdit.Size = New System.Drawing.Size(136, 47)
        Me.cmbEdit.TabIndex = 8
        Me.cmbEdit.Text = "แก้ไขข้อมูลลูกค้า"
        Me.cmbEdit.UseVisualStyleBackColor = False
        '
        'frmChangeCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 181)
        Me.Controls.Add(Me.cmbEdit)
        Me.Controls.Add(Me.lbCScode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbCSName)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.cmbUpdate)
        Me.Controls.Add(Me.lbCusID)
        Me.Controls.Add(Me.lbCusName)
        Me.Name = "frmChangeCS"
        Me.Text = "frmChangeCS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbCusName As Label
    Friend WithEvents lbCusID As Label
    Friend WithEvents cmbUpdate As Button
    Friend WithEvents cmbExit As Button
    Friend WithEvents lbCSName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbCScode As Label
    Friend WithEvents cmbEdit As Button
End Class
