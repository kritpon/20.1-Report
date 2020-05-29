Public Class frmSearchSale
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbOK As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbSaleID As System.Windows.Forms.Label
    Friend WithEvents lbSaleName As System.Windows.Forms.TextBox
    Friend WithEvents dataShow As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbOK = New System.Windows.Forms.Button()
        Me.lbSaleID = New System.Windows.Forms.Label()
        Me.lbSaleName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dataShow = New System.Windows.Forms.DataGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbExit
        '
        Me.cmbExit.BackColor = System.Drawing.Color.Maroon
        Me.cmbExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.ForeColor = System.Drawing.Color.White
        Me.cmbExit.Location = New System.Drawing.Point(520, 319)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(86, 31)
        Me.cmbExit.TabIndex = 15
        Me.cmbExit.Text = "Exit"
        Me.cmbExit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbOK)
        Me.GroupBox1.Controls.Add(Me.lbSaleID)
        Me.GroupBox1.Controls.Add(Me.lbSaleName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 48)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cmbOK
        '
        Me.cmbOK.BackColor = System.Drawing.Color.DarkOrange
        Me.cmbOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbOK.ForeColor = System.Drawing.Color.Navy
        Me.cmbOK.Location = New System.Drawing.Point(512, 16)
        Me.cmbOK.Name = "cmbOK"
        Me.cmbOK.Size = New System.Drawing.Size(86, 32)
        Me.cmbOK.TabIndex = 2
        Me.cmbOK.Text = "ค้นหา"
        Me.cmbOK.UseVisualStyleBackColor = False
        '
        'lbSaleID
        '
        Me.lbSaleID.BackColor = System.Drawing.Color.AliceBlue
        Me.lbSaleID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleID.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleID.Location = New System.Drawing.Point(92, 16)
        Me.lbSaleID.Name = "lbSaleID"
        Me.lbSaleID.Size = New System.Drawing.Size(64, 29)
        Me.lbSaleID.TabIndex = 10
        '
        'lbSaleName
        '
        Me.lbSaleName.BackColor = System.Drawing.Color.YellowGreen
        Me.lbSaleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaleName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSaleName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbSaleName.Location = New System.Drawing.Point(160, 16)
        Me.lbSaleName.MaxLength = 60
        Me.lbSaleName.Name = "lbSaleName"
        Me.lbSaleName.Size = New System.Drawing.Size(344, 30)
        Me.lbSaleName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'dataShow
        '
        Me.dataShow.DataMember = ""
        Me.dataShow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dataShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataShow.Location = New System.Drawing.Point(8, 8)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.ReadOnly = True
        Me.dataShow.Size = New System.Drawing.Size(616, 240)
        Me.dataShow.TabIndex = 24
        '
        'frmSearchSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1260, 679)
        Me.Controls.Add(Me.dataShow)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchSale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Dim chkData As Boolean = False
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As DataSet = New DataSet

    Sub showData()

        'If chkData = True Then
        '    subDS.Tables("ARdata").Clear()
        '    chkData = False
        'End If


        txtSQL = "SELECT * "
        txtSQL = txtSQL & " FROM  SalesMan "
        txtSQL = txtSQL & "Where SL_Off='0' "
        txtSQL = txtSQL & "And Not(SL_id='SL14') "

        txtSQL = txtSQL & " Order by sl_id "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SLdata")
        'chkData = True
        dataShow.DataSource = subDS.Tables("SLdata")

        Call frmSticGrd()


    End Sub

    Sub frmSticGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle
        Dim slID As New DataGridTextBoxColumn
        Dim slName As New DataGridTextBoxColumn
        Dim slGroup As New DataGridTextBoxColumn

        With grdTS
            .AlternatingBackColor = Color.AliceBlue
            .BackColor = Color.LightSkyBlue
            .ForeColor = Color.Navy
            .MappingName = "SLdata"  '¡ÓË¹´ãËé DatagridTalbleStyle ãªé¡Ñº Table ã´

        End With

        With slID
            .HeaderText = "ÃËÑÊ¾¹Ñ¡§Ò¹¢ÒÂ"
            .MappingName = "sl_ID"
            .NullText = "äÁèä´éÃÐºØäÇé"
            .ReadOnly = True
            .Width = 55
            .Alignment = HorizontalAlignment.Center
        End With

        With slName
            .HeaderText = "ª×èÍ¾¹Ñ¡§Ò¹¢ÒÂ"
            .MappingName = "sl_Name"
            .NullText = "äÁèä´éÃÐºØäÇé"
            .ReadOnly = True
            .Width = 200
            .Alignment = HorizontalAlignment.Left
        End With

        With slGroup
            .HeaderText = "ÃËÑÊ¡ÅØèÁ"
            .MappingName = "sl_grp"
            .NullText = "äÁèä´éÃÐºØäÇé"
            .ReadOnly = True
            .Width = 50
            .Alignment = HorizontalAlignment.Right
        End With


        grdTS.GridColumnStyles.Add(slID)
        grdTS.GridColumnStyles.Add(slName)
        grdTS.GridColumnStyles.Add(slGroup)

        With dataShow
            .TableStyles.Clear()
            .CaptionText = "¤é¹ËÒ ¾¹Ñ¡§Ò¹¢ÒÂ"
            .FlatMode = True
            .TableStyles.Add(grdTS)
        End With

    End Sub

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        lbSaleID.Text = ""
        lbSaleName.Text = ""

        Me.Close()
    End Sub

    Private Sub frmSearchSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call showData()
    End Sub

    Private Sub dataShow_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dataShow.Navigate

    End Sub

    Private Sub dataShow_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataShow.CurrentCellChanged

        Dim rowSel As Integer

        rowSel = dataShow.CurrentRowIndex
        If rowSel < 0 Then Exit Sub
        lbSaleID.Text = Convert.ToString(dataShow.Item(rowSel, 0))
        lbSaleName.Text = Convert.ToString(dataShow.Item(rowSel, 1))

    End Sub

    Private Sub cmbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOK.Click
        selSaleiD = lbSaleID.Text
        lbSaleID.Text = ""
        lbSaleName.Text = ""
        Me.Close()
    End Sub

End Class
