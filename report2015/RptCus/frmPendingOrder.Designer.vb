<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPendingOrder
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
        Me.lsvPending = New System.Windows.Forms.ListView()
        Me.lbCusName = New System.Windows.Forms.Label()
        Me.cmbFindCus = New System.Windows.Forms.Button()
        Me.cmbRun = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbSalesName = New System.Windows.Forms.Label()
        Me.optSelSales = New System.Windows.Forms.RadioButton()
        Me.optSelCustom = New System.Windows.Forms.RadioButton()
        Me.lbSalesID = New System.Windows.Forms.Label()
        Me.cmbFindSL = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optShowDetail = New System.Windows.Forms.RadioButton()
        Me.optShowArDetail = New System.Windows.Forms.RadioButton()
        Me.optShowStkDetl = New System.Windows.Forms.RadioButton()
        Me.cmbPrint = New System.Windows.Forms.Button()
        Me.lbCusID = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSumAmt = New System.Windows.Forms.Label()
        Me.lbSumW = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbSumQty = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvPending
        '
        Me.lsvPending.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lsvPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lsvPending.FullRowSelect = True
        Me.lsvPending.HideSelection = False
        Me.lsvPending.Location = New System.Drawing.Point(12, 7)
        Me.lsvPending.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvPending.Name = "lsvPending"
        Me.lsvPending.Size = New System.Drawing.Size(1336, 471)
        Me.lsvPending.TabIndex = 0
        Me.lsvPending.UseCompatibleStateImageBehavior = False
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusName.Location = New System.Drawing.Point(95, 22)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(304, 29)
        Me.lbCusName.TabIndex = 2
        Me.lbCusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFindCus
        '
        Me.cmbFindCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbFindCus.Location = New System.Drawing.Point(438, 22)
        Me.cmbFindCus.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFindCus.Name = "cmbFindCus"
        Me.cmbFindCus.Size = New System.Drawing.Size(35, 29)
        Me.cmbFindCus.TabIndex = 3
        Me.cmbFindCus.Text = "..."
        Me.cmbFindCus.UseVisualStyleBackColor = True
        '
        'cmbRun
        '
        Me.cmbRun.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbRun.ForeColor = System.Drawing.Color.White
        Me.cmbRun.Location = New System.Drawing.Point(1079, 16)
        Me.cmbRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbRun.Name = "cmbRun"
        Me.cmbRun.Size = New System.Drawing.Size(136, 57)
        Me.cmbRun.TabIndex = 4
        Me.cmbRun.Text = "RUN"
        Me.cmbRun.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbSalesName)
        Me.GroupBox1.Controls.Add(Me.optSelSales)
        Me.GroupBox1.Controls.Add(Me.optSelCustom)
        Me.GroupBox1.Controls.Add(Me.lbSalesID)
        Me.GroupBox1.Controls.Add(Me.cmbFindSL)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbPrint)
        Me.GroupBox1.Controls.Add(Me.lbCusID)
        Me.GroupBox1.Controls.Add(Me.cmbExit)
        Me.GroupBox1.Controls.Add(Me.lbCusName)
        Me.GroupBox1.Controls.Add(Me.cmbRun)
        Me.GroupBox1.Controls.Add(Me.cmbFindCus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 521)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1224, 167)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(360, 96)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 45)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Clean"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbSalesName
        '
        Me.lbSalesName.BackColor = System.Drawing.Color.YellowGreen
        Me.lbSalesName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSalesName.Location = New System.Drawing.Point(96, 58)
        Me.lbSalesName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSalesName.Name = "lbSalesName"
        Me.lbSalesName.Size = New System.Drawing.Size(302, 29)
        Me.lbSalesName.TabIndex = 12
        Me.lbSalesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optSelSales
        '
        Me.optSelSales.AutoSize = True
        Me.optSelSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelSales.Location = New System.Drawing.Point(6, 62)
        Me.optSelSales.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelSales.Name = "optSelSales"
        Me.optSelSales.Size = New System.Drawing.Size(93, 24)
        Me.optSelSales.TabIndex = 16
        Me.optSelSales.TabStop = True
        Me.optSelSales.Text = "ตามSales"
        Me.optSelSales.UseVisualStyleBackColor = True
        '
        'optSelCustom
        '
        Me.optSelCustom.AutoSize = True
        Me.optSelCustom.Checked = True
        Me.optSelCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optSelCustom.Location = New System.Drawing.Point(6, 25)
        Me.optSelCustom.Margin = New System.Windows.Forms.Padding(2)
        Me.optSelCustom.Name = "optSelCustom"
        Me.optSelCustom.Size = New System.Drawing.Size(86, 24)
        Me.optSelCustom.TabIndex = 15
        Me.optSelCustom.TabStop = True
        Me.optSelCustom.Text = "ตามลูกค้า"
        Me.optSelCustom.UseVisualStyleBackColor = True
        '
        'lbSalesID
        '
        Me.lbSalesID.BackColor = System.Drawing.Color.YellowGreen
        Me.lbSalesID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSalesID.Location = New System.Drawing.Point(398, 58)
        Me.lbSalesID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSalesID.Name = "lbSalesID"
        Me.lbSalesID.Size = New System.Drawing.Size(40, 29)
        Me.lbSalesID.TabIndex = 14
        Me.lbSalesID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFindSL
        '
        Me.cmbFindSL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbFindSL.Location = New System.Drawing.Point(438, 58)
        Me.cmbFindSL.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbFindSL.Name = "cmbFindSL"
        Me.cmbFindSL.Size = New System.Drawing.Size(35, 29)
        Me.cmbFindSL.TabIndex = 13
        Me.cmbFindSL.Text = "..."
        Me.cmbFindSL.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optShowDetail)
        Me.GroupBox2.Controls.Add(Me.optShowArDetail)
        Me.GroupBox2.Controls.Add(Me.optShowStkDetl)
        Me.GroupBox2.Location = New System.Drawing.Point(491, 20)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(394, 139)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'optShowDetail
        '
        Me.optShowDetail.AutoSize = True
        Me.optShowDetail.Checked = True
        Me.optShowDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optShowDetail.Location = New System.Drawing.Point(20, 90)
        Me.optShowDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.optShowDetail.Name = "optShowDetail"
        Me.optShowDetail.Size = New System.Drawing.Size(105, 24)
        Me.optShowDetail.TabIndex = 13
        Me.optShowDetail.TabStop = True
        Me.optShowDetail.Text = "แสดงทั้งหมด"
        Me.optShowDetail.UseVisualStyleBackColor = True
        '
        'optShowArDetail
        '
        Me.optShowArDetail.AutoSize = True
        Me.optShowArDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optShowArDetail.Location = New System.Drawing.Point(20, 58)
        Me.optShowArDetail.Margin = New System.Windows.Forms.Padding(2)
        Me.optShowArDetail.Name = "optShowArDetail"
        Me.optShowArDetail.Size = New System.Drawing.Size(173, 24)
        Me.optShowArDetail.TabIndex = 12
        Me.optShowArDetail.Text = "รวมกลุ่ม-เฉพาะชื่อลูกค้า"
        Me.optShowArDetail.UseVisualStyleBackColor = True
        '
        'optShowStkDetl
        '
        Me.optShowStkDetl.AutoSize = True
        Me.optShowStkDetl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optShowStkDetl.Location = New System.Drawing.Point(20, 26)
        Me.optShowStkDetl.Margin = New System.Windows.Forms.Padding(2)
        Me.optShowStkDetl.Name = "optShowStkDetl"
        Me.optShowStkDetl.Size = New System.Drawing.Size(156, 24)
        Me.optShowStkDetl.TabIndex = 11
        Me.optShowStkDetl.Text = "รวมกลุ่ม-เฉพาะสินค้า"
        Me.optShowStkDetl.UseVisualStyleBackColor = True
        '
        'cmbPrint
        '
        Me.cmbPrint.BackColor = System.Drawing.Color.Orange
        Me.cmbPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbPrint.ForeColor = System.Drawing.Color.White
        Me.cmbPrint.Location = New System.Drawing.Point(924, 16)
        Me.cmbPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPrint.Name = "cmbPrint"
        Me.cmbPrint.Size = New System.Drawing.Size(136, 57)
        Me.cmbPrint.TabIndex = 7
        Me.cmbPrint.Text = "รายงาน"
        Me.cmbPrint.UseVisualStyleBackColor = False
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.YellowGreen
        Me.lbCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(398, 22)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(40, 29)
        Me.lbCusID.TabIndex = 6
        Me.lbCusID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Brown
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(1079, 84)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(136, 57)
        Me.cmbExit.TabIndex = 5
        Me.cmbExit.Text = "ออก"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(924, 484)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "มูลค่า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSumAmt
        '
        Me.lbSumAmt.BackColor = System.Drawing.Color.Yellow
        Me.lbSumAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumAmt.Location = New System.Drawing.Point(974, 484)
        Me.lbSumAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumAmt.Name = "lbSumAmt"
        Me.lbSumAmt.Size = New System.Drawing.Size(184, 25)
        Me.lbSumAmt.TabIndex = 7
        Me.lbSumAmt.Text = "0"
        Me.lbSumAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSumW
        '
        Me.lbSumW.BackColor = System.Drawing.Color.YellowGreen
        Me.lbSumW.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumW.Location = New System.Drawing.Point(664, 484)
        Me.lbSumW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumW.Name = "lbSumW"
        Me.lbSumW.Size = New System.Drawing.Size(184, 25)
        Me.lbSumW.TabIndex = 9
        Me.lbSumW.Text = "0"
        Me.lbSumW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(596, 484)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "น้ำหนัก"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(850, 484)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kg."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(1160, 484)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "บาท"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 484)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "แผ่น"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSumQty
        '
        Me.lbSumQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbSumQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumQty.Location = New System.Drawing.Point(329, 484)
        Me.lbSumQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumQty.Name = "lbSumQty"
        Me.lbSumQty.Size = New System.Drawing.Size(184, 25)
        Me.lbSumQty.TabIndex = 13
        Me.lbSumQty.Text = "0"
        Me.lbSumQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 484)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "จำนวน"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPendingOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbSumQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSumW)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbSumAmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lsvPending)
        Me.Name = "frmPendingOrder"
        Me.Text = "18-02-63 Pending Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lsvPending As ListView
    Friend WithEvents lbCusName As Label
    Friend WithEvents cmbFindCus As Button
    Friend WithEvents cmbRun As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbExit As Button
    Friend WithEvents lbCusID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbSumAmt As Label
    Friend WithEvents lbSumW As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPrint As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optShowDetail As RadioButton
    Friend WithEvents optShowArDetail As RadioButton
    Friend WithEvents optShowStkDetl As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents lbSumQty As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents optSelSales As RadioButton
    Friend WithEvents optSelCustom As RadioButton
    Friend WithEvents lbSalesID As Label
    Friend WithEvents lbSalesName As Label
    Friend WithEvents cmbFindSL As Button
    Friend WithEvents Button1 As Button
End Class
