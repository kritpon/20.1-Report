<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.chkSelCustom = New System.Windows.Forms.CheckBox()
        Me.lbFindCus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbSumSaleAmt2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbTotalSales = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbSumSalesNoPro = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbSumDN2Amt = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbSumCNAmt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbSumDNAmt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbSumSaleAmt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDate01 = New System.Windows.Forms.DateTimePicker()
        Me.lbDate02 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lsvListCust = New System.Windows.Forms.ListView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbCusName
        '
        Me.lbCusName.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbCusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCusName.ForeColor = System.Drawing.Color.White
        Me.lbCusName.Location = New System.Drawing.Point(218, 12)
        Me.lbCusName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusName.Name = "lbCusName"
        Me.lbCusName.Size = New System.Drawing.Size(396, 26)
        Me.lbCusName.TabIndex = 18
        '
        'lbCusID
        '
        Me.lbCusID.BackColor = System.Drawing.Color.Yellow
        Me.lbCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCusID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCusID.Location = New System.Drawing.Point(116, 12)
        Me.lbCusID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCusID.Name = "lbCusID"
        Me.lbCusID.Size = New System.Drawing.Size(70, 26)
        Me.lbCusID.TabIndex = 17
        Me.lbCusID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkSelCustom
        '
        Me.chkSelCustom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkSelCustom.Location = New System.Drawing.Point(26, 20)
        Me.chkSelCustom.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSelCustom.Name = "chkSelCustom"
        Me.chkSelCustom.Size = New System.Drawing.Size(98, 17)
        Me.chkSelCustom.TabIndex = 20
        Me.chkSelCustom.Text = "เลือกลูกค้า"
        '
        'lbFindCus
        '
        Me.lbFindCus.BackColor = System.Drawing.Color.DarkCyan
        Me.lbFindCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindCus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindCus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbFindCus.Location = New System.Drawing.Point(186, 12)
        Me.lbFindCus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindCus.Name = "lbFindCus"
        Me.lbFindCus.Size = New System.Drawing.Size(27, 26)
        Me.lbFindCus.TabIndex = 19
        Me.lbFindCus.Text = "..."
        Me.lbFindCus.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvListCust)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lbSumSaleAmt2)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lbTotalSales)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbSumSalesNoPro)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbSumDN2Amt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdRun)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbSumCNAmt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbSumDNAmt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbSumSaleAmt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 99)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 507)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(964, 159)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 20)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "บาท"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(964, 53)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 20)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "บาท"
        '
        'lbSumSaleAmt2
        '
        Me.lbSumSaleAmt2.BackColor = System.Drawing.Color.Black
        Me.lbSumSaleAmt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumSaleAmt2.ForeColor = System.Drawing.Color.Yellow
        Me.lbSumSaleAmt2.Location = New System.Drawing.Point(708, 36)
        Me.lbSumSaleAmt2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumSaleAmt2.Name = "lbSumSaleAmt2"
        Me.lbSumSaleAmt2.Size = New System.Drawing.Size(244, 36)
        Me.lbSumSaleAmt2.TabIndex = 25
        Me.lbSumSaleAmt2.Text = "0.00"
        Me.lbSumSaleAmt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(484, 49)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(206, 24)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "ยอดรวมการขาย โปรโมทชั่น"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(536, 159)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(148, 24)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "ยอดรวมขายทั้งหมด"
        '
        'lbTotalSales
        '
        Me.lbTotalSales.BackColor = System.Drawing.Color.Black
        Me.lbTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotalSales.ForeColor = System.Drawing.Color.Lime
        Me.lbTotalSales.Location = New System.Drawing.Point(708, 146)
        Me.lbTotalSales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotalSales.Name = "lbTotalSales"
        Me.lbTotalSales.Size = New System.Drawing.Size(244, 36)
        Me.lbTotalSales.TabIndex = 22
        Me.lbTotalSales.Text = "0.00"
        Me.lbTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(964, 109)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "บาท"
        '
        'lbSumSalesNoPro
        '
        Me.lbSumSalesNoPro.BackColor = System.Drawing.Color.Black
        Me.lbSumSalesNoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumSalesNoPro.ForeColor = System.Drawing.Color.Cyan
        Me.lbSumSalesNoPro.Location = New System.Drawing.Point(708, 92)
        Me.lbSumSalesNoPro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumSalesNoPro.Name = "lbSumSalesNoPro"
        Me.lbSumSalesNoPro.Size = New System.Drawing.Size(244, 36)
        Me.lbSumSalesNoPro.TabIndex = 20
        Me.lbSumSalesNoPro.Text = "0.00"
        Me.lbSumSalesNoPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(500, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 24)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "ยอดรวมการขายไม่คิดโปร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 473)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(514, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ยอดรวมการขาย จะเป็นยอดขายจากเอกสาร ประเภท V ,B ,N ,M เท่านั้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "บาท"
        '
        'lbSumDN2Amt
        '
        Me.lbSumDN2Amt.BackColor = System.Drawing.Color.Black
        Me.lbSumDN2Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumDN2Amt.ForeColor = System.Drawing.Color.White
        Me.lbSumDN2Amt.Location = New System.Drawing.Point(138, 158)
        Me.lbSumDN2Amt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumDN2Amt.Name = "lbSumDN2Amt"
        Me.lbSumDN2Amt.Size = New System.Drawing.Size(244, 36)
        Me.lbSumDN2Amt.TabIndex = 16
        Me.lbSumDN2Amt.Text = "0.00"
        Me.lbSumDN2Amt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ยอดลดหนี้จัดส่ง"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Maroon
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(442, 408)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(124, 53)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdRun
        '
        Me.cmdRun.BackColor = System.Drawing.Color.DarkGreen
        Me.cmdRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdRun.ForeColor = System.Drawing.Color.White
        Me.cmdRun.Location = New System.Drawing.Point(308, 408)
        Me.cmdRun.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(124, 53)
        Me.cmdRun.TabIndex = 13
        Me.cmdRun.Text = "RUN"
        Me.cmdRun.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Yellow
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(162, 408)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(128, 50)
        Me.cmdPrint.TabIndex = 12
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(394, 299)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "บาท"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(394, 237)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "บาท"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(394, 107)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "บาท"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(394, 53)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "บาท"
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.Black
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.Lime
        Me.lbTotal.Location = New System.Drawing.Point(138, 282)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(244, 36)
        Me.lbTotal.TabIndex = 7
        Me.lbTotal.Text = "0.00"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 295)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ยอดรวม"
        '
        'lbSumCNAmt
        '
        Me.lbSumCNAmt.BackColor = System.Drawing.Color.Black
        Me.lbSumCNAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumCNAmt.ForeColor = System.Drawing.Color.Red
        Me.lbSumCNAmt.Location = New System.Drawing.Point(138, 220)
        Me.lbSumCNAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumCNAmt.Name = "lbSumCNAmt"
        Me.lbSumCNAmt.Size = New System.Drawing.Size(244, 36)
        Me.lbSumCNAmt.TabIndex = 5
        Me.lbSumCNAmt.Text = "0.00"
        Me.lbSumCNAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ยอดลดหนี้"
        '
        'lbSumDNAmt
        '
        Me.lbSumDNAmt.BackColor = System.Drawing.Color.Black
        Me.lbSumDNAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumDNAmt.ForeColor = System.Drawing.Color.Cyan
        Me.lbSumDNAmt.Location = New System.Drawing.Point(138, 90)
        Me.lbSumDNAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumDNAmt.Name = "lbSumDNAmt"
        Me.lbSumDNAmt.Size = New System.Drawing.Size(244, 36)
        Me.lbSumDNAmt.TabIndex = 3
        Me.lbSumDNAmt.Text = "0.00"
        Me.lbSumDNAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ยอดเพิ่มหนี้"
        '
        'lbSumSaleAmt
        '
        Me.lbSumSaleAmt.BackColor = System.Drawing.Color.Black
        Me.lbSumSaleAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSumSaleAmt.ForeColor = System.Drawing.Color.Yellow
        Me.lbSumSaleAmt.Location = New System.Drawing.Point(138, 36)
        Me.lbSumSaleAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSumSaleAmt.Name = "lbSumSaleAmt"
        Me.lbSumSaleAmt.Size = New System.Drawing.Size(244, 36)
        Me.lbSumSaleAmt.TabIndex = 1
        Me.lbSumSaleAmt.Text = "0.00"
        Me.lbSumSaleAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดรวมการขาย"
        '
        'lbDate01
        '
        Me.lbDate01.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate01.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate01.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbDate01.Location = New System.Drawing.Point(296, 50)
        Me.lbDate01.Margin = New System.Windows.Forms.Padding(2)
        Me.lbDate01.Name = "lbDate01"
        Me.lbDate01.Size = New System.Drawing.Size(136, 25)
        Me.lbDate01.TabIndex = 22
        '
        'lbDate02
        '
        Me.lbDate02.CalendarFont = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate02.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbDate02.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbDate02.Location = New System.Drawing.Point(478, 50)
        Me.lbDate02.Margin = New System.Windows.Forms.Padding(2)
        Me.lbDate02.Name = "lbDate02"
        Me.lbDate02.Size = New System.Drawing.Size(132, 25)
        Me.lbDate02.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(445, 56)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 14)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "ถึง"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(258, 53)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "วันที่"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(884, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 53)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "ทดสอบ"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'lsvListCust
        '
        Me.lsvListCust.Location = New System.Drawing.Point(442, 217)
        Me.lsvListCust.Name = "lsvListCust"
        Me.lsvListCust.Size = New System.Drawing.Size(557, 174)
        Me.lsvListCust.TabIndex = 28
        Me.lsvListCust.UseCompatibleStateImageBehavior = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(627, 18)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(190, 17)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "รวมยอดขายในเครือ"
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1034, 617)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbDate01)
        Me.Controls.Add(Me.lbDate02)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbCusName)
        Me.Controls.Add(Me.lbCusID)
        Me.Controls.Add(Me.chkSelCustom)
        Me.Controls.Add(Me.lbFindCus)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSummary"
        Me.Text = "frmSummary"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCusName As Label
    Friend WithEvents lbCusID As Label
    Friend WithEvents chkSelCustom As CheckBox
    Friend WithEvents lbFindCus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbSumCNAmt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbSumDNAmt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbSumSaleAmt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdRun As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents lbDate01 As DateTimePicker
    Friend WithEvents lbDate02 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbSumDN2Amt As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbSumSalesNoPro As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbSumSaleAmt2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbTotalSales As Label
    Friend WithEvents lsvListCust As ListView
    Friend WithEvents CheckBox1 As CheckBox
End Class
