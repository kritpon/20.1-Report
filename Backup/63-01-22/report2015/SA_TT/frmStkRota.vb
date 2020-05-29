Public Class frmStkRota
    Dim chkFrmLoad As Boolean = False


    Function getSelMaster(ByVal f1 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If f1 = "01" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' "
            txtSQL = txtSQL & "Order by Fac_Code "

        ElseIf f1 = "02" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            ' txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or  Fac_code='07' "
            txtSQL = txtSQL & "Where  Fac_Code='01' "
            txtSQL = txtSQL & "Order by Fac_Code "
        ElseIf f1 = "03" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or Fac_Code='02'   or  Fac_code='07' "
            txtSQL = txtSQL & "Order by Fac_Code "

        ElseIf f1 = "04" Then

            txtSQL = "Select * "
            txtSQL = txtSQL & "From FactorMast "
            txtSQL = txtSQL & "Where Fac_Code='00' or Fac_Code='01' or Fac_Code='02'  or  Fac_code='05' or  Fac_code='07' "
            txtSQL = txtSQL & "Order by Fac_Code "

        End If

        subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA2.Fill(subDS2, "selMaster")


        Return subDS2

    End Function

    Function getMaster1(ByVal selTB As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_Prod = '" & cboFactor11.SelectedValue.ToString & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            If IsDBNull(cboFactor22.SelectedValue) = True Then

            Else
                txtSQL = txtSQL & "Where Grp_Type_Code='" & (cboFactor22.SelectedValue.ToString) & "' "
            End If

            '            txtSQL = txtSQL & "Where Type_Prod = '" & cboFactor11.SelectedValue.ToString & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")


        End If

        Return subDS2

    End Function
    Function getMaster2(ByVal selTB As String, ByVal F1 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")


        End If

        Return subDS2

    End Function

    Function getMaster3(ByVal selTB As String, ByVal F1 As String, ByVal F2 As String, ProD_id As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet
        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            txtSQL = txtSQL & "Where Grp_type_Code = '" & F2 & "' "
            txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
            txtSQL = txtSQL & "Order by Grp_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            ' txtSQL = txtSQL & "And Grp_Prod_Code='" & ProD_id & "' "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        End If

        Return subDS2

    End Function
    Function getMaster4(ByVal selTB As String, ByVal F1 As String, ByVal F2 As String) As DataSet

        Dim subDA2 As New SqlClient.SqlDataAdapter
        Dim subDS2 As New DataSet

        If selTB = "00" Then
            txtSQL = "Select * "
            txtSQL = txtSQL & "From ProGrpMast "
            txtSQL = txtSQL & "Order by ProGrp_ID "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "01" Then
            txtSQL = "Select  Type_Code,Type_Name  "
            txtSQL = txtSQL & "From TypeMast "
            txtSQL = txtSQL & "Where Type_prod = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "02" Then

            txtSQL = "Select  Grp_Code,Grp_Name  "
            txtSQL = txtSQL & "From GrpMast "
            txtSQL = txtSQL & "Where Grp_type_Code = '" & F2 & "' "
            txtSQL = txtSQL & "Order by Grp_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "05" Then

            txtSQL = "Select  Size_Code,Size_Name  "
            txtSQL = txtSQL & "From SizeMast "
            'txtSQL = txtSQL & "Where Size_Code = '" & F1 & "' "
            txtSQL = txtSQL & "Order by Size_Code "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        ElseIf selTB = "07" Then
            txtSQL = "Select  G_Code,G_Name  "
            txtSQL = txtSQL & "From GMast "
            txtSQL = txtSQL & "Order by G_Name_2 "

            subDA2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDA2.Fill(subDS2, "master")

        End If

        Return subDS2

    End Function
    Sub addItemSale()

        Dim subDA As SqlClient.SqlDataAdapter
        Dim subDS As DataSet = New DataSet


        txtSQL = "SELECT * "
        txtSQL = txtSQL & "FROM  SalesMan "
        txtSQL = txtSQL & "where SL_Off='0' "
        'If selGrpSale = "G99" Then

        'Else
        '    txtSQL = txtSQL & "Where SL_Grp='" & selGrpSale & "' "
        'End If

        txtSQL = txtSQL & " Order by sl_id "


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SLdata2")

        With cboSales
            .DataSource = subDS.Tables("SLdata2")
            .DisplayMember = "SL_Name"
            .ValueMember = "SL_ID"
        End With

        subDA = Nothing
        subDS = Nothing

    End Sub
    Sub addCboSegment()
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL = txtSQL & "From  MktSegment "

        txtSQL = txtSQL & "Order by grp_code "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listSL01")
        If subDS.Tables("listSL01").Rows.Count > 0 Then

            cboSegment.DataSource = subDS.Tables("listSL01")
            cboSegment.ValueMember = "grp_code"
            cboSegment.DisplayMember = "Grp_Name"
            'cboDClist.Text = ""
            cboSegment.SelectedItem = 0

        End If
    End Sub

    Private Sub frmBegin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setHead()
        Call setHead2()
        Call addItemSale()
        Call addCboSegment()
        addCboProD()
        addCboType()
        chkFrmLoad = True
        cboFactor22.SelectedValue = "G1"
    End Sub
    Sub addCboProD()
        Dim dsChkF1 As New DataSet
        dsChkF1 = getSelMaster("01")
        If dsChkF1.Tables("selMaster").Rows.Count > 0 Then
            With cboFactor1
                .DataSource = dsChkF1.Tables("selMaster")
                .DisplayMember = "Fac_Name"
                .ValueMember = "Fac_Code"
                .SelectedIndex = 0
            End With
            cboFactor11.SelectedValue = "05"
            chkF1.Checked = True
        End If
    End Sub
    Private Sub chkF1_CheckedChanged(sender As Object, e As EventArgs) Handles chkF1.CheckedChanged


        If chkF1.Checked = True Then
            addCboProD()
        End If

    End Sub

    Private Sub cboFactor1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFactor1.SelectedValueChanged

        Dim dsFC1 As New DataSet
        Try
            'MsgBox("¢éÍÁÙÅ·ÕèàÅ×Í¡ " & cboFactor1.SelectedValue.ToString)
            If cboFactor1.SelectedValue.ToString = "00" Then

                dsFC1 = getMaster1(cboFactor1.SelectedValue.ToString)
                With cboFactor11
                    .DataSource = dsFC1.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With

            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub addCboType()
        Dim dsChkF2 As New DataSet
        dsChkF2 = getSelMaster("02")
        If dsChkF2.Tables("selMaster").Rows.Count > 0 Then
            With cboFactor2
                .DataSource = dsChkF2.Tables("selMaster")
                .DisplayMember = "Fac_Name"
                .ValueMember = "Fac_Code"

            End With
            cboFactor2.SelectedValue = "01"
            chkF2.Checked = True
        End If
    End Sub
    Private Sub chkF2_CheckedChanged(sender As Object, e As EventArgs) Handles chkF2.CheckedChanged


        If chkF2.Checked = True Then
            addCboType()

        ElseIf chkF2.Checked = False Then

            'dsChkF2.Tables("selMaster").Clear()
            'cboFactor2.Items.Clear()

        End If

    End Sub

    Private Sub cboFactor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFactor2.SelectedIndexChanged

    End Sub
    Sub callChkCboFactor2()
        Dim dsFC2 As New DataSet
        Try
            If cboFactor2.SelectedValue.ToString = "00" Then
                dsFC2 = getMaster2("00", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "ProGrp_Name"
                    .ValueMember = "ProGrp_ID"

                End With
            ElseIf cboFactor2.SelectedValue.ToString = "01" Then
                dsFC2 = getMaster2("01", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"

                End With

            ElseIf cboFactor2.SelectedValue.ToString = "07" Then
                dsFC2 = getMaster2("07", cboFactor11.SelectedValue.ToString)
                With cboFactor22

                    .DataSource = dsFC2.Tables("master")
                    .DisplayMember = "G_Name"
                    .ValueMember = "G_Code"

                End With

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboFactor2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFactor2.SelectedValueChanged
        Call callChkCboFactor2()
    End Sub

    Private Sub cboFactor22_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFactor22.SelectedValueChanged
        lbTypeID.Text = cboFactor22.SelectedValue.ToString
        optAmt2.Text = "ยอดขาย-" & cboFactor22.Text
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub


    Private Sub cboFactor11_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFactor11.SelectedValueChanged
        lbProdID.Text = cboFactor11.SelectedValue.ToString
        Call callChkCboFactor2()
    End Sub
    Function genSQL_Report() As String

        txtSQL = "Select Ar_Cus_ID,Ar_Name,Grp_Name,Ar_LastSales_Date, "
        txtSQL = txtSQL & "sum(case when (BaseMast.Stk_Prod='01' and BaseMast.Type_Code='01')  then (Dtl_Price*Dtl_Num) else 0 end)as 'sumAmt01' ,"
        txtSQL = txtSQL & "sum(case when (BaseMast.Stk_Prod='" & lbProdID.Text & "' and BaseMast.Type_Code='" & lbTypeID.Text & "')  then (Dtl_Price*Dtl_Num) else 0 end)as 'sumAmt05' "

        txtSQL = txtSQL & "from TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On TRh_Type = Dtl_Type and Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=AR_CUS_ID "

        txtSQL = txtSQL & "left Join MktSegment "
        txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "

        txtSQL = txtSQL & "Left Join BAseMast "
        txtSQL = txtSQL & "On Dtl_IDtrade=Stk_Code "

        txtSQL = txtSQL & "Where Trh_Type='S' "

        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "

        If chkDate.Checked = True Then
            txtSQL = txtSQL & "And (Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "') "

        Else
            txtSQL = txtSQL & " And year(Trh_Date)=2018 "
        End If

        txtSQL = txtSQL & "And ((BaseMast.Stk_Prod='" & lbProdID.Text & "' "
        txtSQL = txtSQL & "And Type_Code='" & lbTypeID.Text & "') "
        txtSQL = txtSQL & " or(BaseMast.Stk_Prod='01' "
        txtSQL = txtSQL & "And Type_Code='01')  ) "

        If chkSales.Checked = True Then
            txtSQL = txtSQL & "And Trh_Sale='" & cboSales.SelectedValue & "' "
        End If
        If chkSegment.Checked = True Then
            txtSQL = txtSQL & "And MktSegment.Grp_Code='" & cboSegment.SelectedValue & "' "
        End If

        txtSQL = txtSQL & "group by Ar_Cus_ID,Ar_Name,Grp_Name,Ar_LastSales_Date "
        If optAmt1.Checked = True Then
            txtSQL = txtSQL & "Order by sumAmt01 "
            If optASC.Checked Then
                txtSQL = txtSQL & "Asc "
            Else
                txtSQL = txtSQL & "Desc "
            End If
        ElseIf optAmt2.Checked = True Then
            txtSQL = txtSQL & "Order by sumAmt05 "
            If optASC.Checked Then
                txtSQL = txtSQL & "Asc "
            Else
                txtSQL = txtSQL & "Desc "
            End If
            'ElseIf optRatio.Checked = True Then
            '    txtSQL = txtSQL & "Order by sumAmt01 "
            '    If optASC.Checked Then
            '        txtSQL = txtSQL & "Asc "
            '    Else
            '        txtSQL = txtSQL & "Desc "
            '    End If
        End If
        txtSQL = txtSQL & ""
        Return txtSQL

    End Function
    Private Sub cmbRun_Click(sender As Object, e As EventArgs) Handles cmbRun.Click
        If chkFrmLoad = True Then
            Call runReport()
        End If


    End Sub
    Sub runReport()
        Call runReportSegment()
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = genSQL_Report()

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listReport")

        Dim anyData() As String
        Dim lvi As ListViewItem

        lsvItem.Clear()
        setHead()
        Dim chkRow As Integer = 0
        For i = 0 To subDS.Tables("listReport").Rows.Count - 1
            With subDS.Tables("listReport").Rows(i)
                Dim strArName As String = .Item("Ar_Name")
                Dim strGrpName As String
                If IsDBNull(.Item("Grp_Name")) Then
                    strGrpName = ""
                Else
                    strGrpName = .Item("Grp_Name")
                End If
                Dim dblGP_Amt As Double = .Item("sumAmt01")
                Dim dblTT_Amt As Double = .Item("sumAmt05")
                Dim dblDiffRatio As Double = 100 - (((dblGP_Amt - dblTT_Amt) / dblGP_Amt) * 100)
                If dblTT_Amt = 0 Then
                    chkRow = 2
                End If
                anyData = New String() {i + 1.ToString("#,##0"), strArName, strGrpName, dblGP_Amt.ToString("#,##0.00"), dblTT_Amt.ToString("#,##0.00"), dblDiffRatio.ToString("#,##0.00")}
                lvi = New ListViewItem(anyData)
                lsvItem.Items.Add(lvi)
            End With
            If chkRow = 0 Then
                lvi.BackColor = Color.YellowGreen
                lvi.ForeColor = Color.Black
                chkRow = 1
            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.White
                lvi.ForeColor = Color.Black
                chkRow = 0
            Else
                lvi.BackColor = Color.Pink
                lvi.ForeColor = Color.Black
                chkRow = 1

            End If

        Next
        chkRow = 0

    End Sub
    Sub setHead()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvItem.Columns.Add("#", 50, HorizontalAlignment.Center)

        lsvItem.Columns.Add("ชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvItem.Columns.Add("Segment", 120, HorizontalAlignment.Left)
        lsvItem.Columns.Add("ยอดขาย GP", 120, HorizontalAlignment.Right)
        lsvItem.Columns.Add("สินค้า-" & cboFactor22.Text, 120, HorizontalAlignment.Right)
        lsvItem.Columns.Add("%", 80, HorizontalAlignment.Right)
        'lsvSales.Columns.Add("ที่อยู่", 200, HorizontalAlignment.Left)
        ' lsvCusName.Columns.Add("รหัส Link ", 200, HorizontalAlignment.Center)
        ' lsvCusName.Columns.Add("วันที่ซื้อขายล่าสุด ", 200, HorizontalAlignment.Center)
        lsvItem.View = View.Details
        lsvItem.FullRowSelect = True
        lsvItem.GridLines = True

    End Sub
    Sub setHead2()

        ' lsvCusGrade.Columns.Add("#", 30, HorizontalAlignment.Center)
        lsvRptSegment.Columns.Add("#", 30, HorizontalAlignment.Center)

        'lsvRptSegment.Columns.Add("ชื่อลูกค้า", 250, HorizontalAlignment.Left)
        lsvRptSegment.Columns.Add("Segment", 120, HorizontalAlignment.Left)
        lsvRptSegment.Columns.Add("ยอดขาย GP", 90, HorizontalAlignment.Right)
        lsvRptSegment.Columns.Add("สินค้า-" & cboFactor22.Text, 90, HorizontalAlignment.Right)
        lsvRptSegment.Columns.Add("%", 80, HorizontalAlignment.Right)
        lsvRptSegment.Columns.Add("ID", 90, HorizontalAlignment.Right)
        'lsvSales.Columns.Add("ที่อยู่", 200, HorizontalAlignment.Left)
        ' lsvCusName.Columns.Add("รหัส Link ", 200, HorizontalAlignment.Center)
        ' lsvCusName.Columns.Add("วันที่ซื้อขายล่าสุด ", 200, HorizontalAlignment.Center)
        lsvRptSegment.View = View.Details
        lsvRptSegment.FullRowSelect = True
        lsvRptSegment.GridLines = True

    End Sub
    Private Sub cboSales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSales.SelectedIndexChanged

    End Sub

    Private Sub cboSales_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSales.SelectedValueChanged
        If chkFrmLoad = True Then
            chkSales.Checked = True
            Call runReport()

        End If

    End Sub

    Private Sub cboSegment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSegment.SelectedIndexChanged

    End Sub

    Private Sub cboSegment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSegment.SelectedValueChanged
        If chkFrmLoad = True Then
            chkSegment.Checked = True
            Call runReport()
        End If

    End Sub

    Private Sub cmbExit_Click(sender As Object, e As EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Private Sub cboFactor22_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFactor22.SelectedIndexChanged

    End Sub

    Private Sub optAmt2_CheckedChanged(sender As Object, e As EventArgs) Handles optAmt2.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If

    End Sub

    Private Sub optAmt1_CheckedChanged(sender As Object, e As EventArgs) Handles optAmt1.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub

    Private Sub optASC_CheckedChanged(sender As Object, e As EventArgs) Handles optASC.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub

    Private Sub optDesc_CheckedChanged(sender As Object, e As EventArgs) Handles optDesc.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub

    Private Sub chkSegment_CheckedChanged(sender As Object, e As EventArgs) Handles chkSegment.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub

    Private Sub chkSales_CheckedChanged(sender As Object, e As EventArgs) Handles chkSales.CheckedChanged
        If chkFrmLoad = True Then
            Call runReport()
        End If
    End Sub

    Private Sub cboFactor11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFactor11.SelectedIndexChanged

    End Sub

    Function genSQL_Segment() As String
        txtSQL = "Select MktSegment.Grp_Code,MktSegment.Grp_Name,MktSegment.Grp_Code, "

        txtSQL = txtSQL & "sum(case when (BaseMast.Stk_Prod='01' and BaseMast.Type_Code='01')  then (Dtl_Price*Dtl_Num) else 0 end)as 'sumAmt01' ,"
        txtSQL = txtSQL & "sum(case when (BaseMast.Stk_Prod='" & lbProdID.Text & "' and BaseMast.Type_Code='" & lbTypeID.Text & "')  then (Dtl_Price*Dtl_Num) else 0 end)as 'sumAmt05' "

        txtSQL = txtSQL & "from TranDataH "
        txtSQL = txtSQL & "Left Join TranDataD "
        txtSQL = txtSQL & "On TRh_Type = Dtl_Type and Trh_No=Dtl_No "
        txtSQL = txtSQL & "Left Join ArFile "
        txtSQL = txtSQL & "On Trh_Cus=AR_CUS_ID "

        txtSQL = txtSQL & "left Join MktSegment "
        txtSQL = txtSQL & "on ArFile.AR_Group=MktSegment.Grp_Code "

        txtSQL = txtSQL & "Left Join BAseMast "
        txtSQL = txtSQL & "On Dtl_IDtrade=Stk_Code "



        txtSQL = txtSQL & "Where Trh_Type='S' "

        txtSQL = txtSQL & "And (Trh_NoType='V' Or Trh_NoType='N' "
        txtSQL = txtSQL & "     Or Trh_NoType='B' Or Trh_NoType='M'"
        txtSQL = txtSQL & "     Or Trh_NoType='Y' Or Trh_NoType='Z' ) "

        If chkDate.Checked = True Then
            txtSQL = txtSQL & "And (Trh_Date >= '" & Year(txtDate01.Value) - 543 & "/" & Month(txtDate01.Value) & "/" & Microsoft.VisualBasic.Day(txtDate01.Value) & "' "
            txtSQL = txtSQL & "And Trh_Date <= '" & Year(txtDate02.Value) - 543 & "/" & Month(txtDate02.Value) & "/" & Microsoft.VisualBasic.Day(txtDate02.Value) & "') "

        Else
            txtSQL = txtSQL & " And year(Trh_Date)=2018 "
        End If

        txtSQL = txtSQL & "And ((BaseMast.Stk_Prod='" & lbProdID.Text & "' "
        txtSQL = txtSQL & "And Type_Code='" & lbTypeID.Text & "') "
        txtSQL = txtSQL & " or(BaseMast.Stk_Prod='01' "
        txtSQL = txtSQL & "And Type_Code='01')  ) "

        If chkSales.Checked = True Then
            txtSQL = txtSQL & "And Trh_Sale='" & cboSales.SelectedValue & "' "
        End If
        'If chkSegment.Checked = True Then
        '    txtSQL = txtSQL & "And MktSegment.Grp_Code='" & cboSegment.SelectedValue & "' "
        'End If

        txtSQL = txtSQL & "group by MktSegment.Grp_Code,MktSegment.Grp_Name,MktSegment.Grp_Code "
        If optAmt1.Checked = True Then
            txtSQL = txtSQL & "Order by sumAmt01 "
            If optASC.Checked Then
                txtSQL = txtSQL & "Asc "
            Else
                txtSQL = txtSQL & "Desc "
            End If
        ElseIf optAmt2.Checked = True Then
            txtSQL = txtSQL & "Order by sumAmt05 "
            If optASC.Checked Then
                txtSQL = txtSQL & "Asc "
            Else
                txtSQL = txtSQL & "Desc "
            End If
            'ElseIf optRatio.Checked = True Then
            '    txtSQL = txtSQL & "Order by sumAmt01 "
            '    If optASC.Checked Then
            '        txtSQL = txtSQL & "Asc "
            '    Else
            '        txtSQL = txtSQL & "Desc "
            '    End If
        End If
        txtSQL = txtSQL & ""
        Return txtSQL

    End Function
    Sub runReportSegment()
        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet

        txtSQL = genSQL_Segment()

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listSegment")

        Dim anyData() As String
        Dim lvi As ListViewItem

        lsvRptSegment.Clear()
        setHead2()
        Dim chkRow As Integer = 0
        Dim totalGP_Amt As Double = 0
        Dim totalTT_Amt As Double = 0
        Dim totalRatio As Double = 0
        For i = 0 To subDS.Tables("listSegment").Rows.Count - 1
            With subDS.Tables("listSegment").Rows(i)
                'Dim strArName As String = .Item("Grp_Name")
                Dim strGrpName As String
                Dim strGrpCode As String
                If IsDBNull(.Item("Grp_Name")) Then
                    strGrpName = ""
                    strGrpCode = ""
                Else
                    strGrpName = .Item("Grp_Name")
                    strGrpCode = .Item("Grp_Code")
                End If
                Dim dblGP_Amt As Double = .Item("sumAmt01")
                totalGP_Amt = totalGP_Amt + dblGP_Amt
                Dim dblTT_Amt As Double = .Item("sumAmt05")
                totalTT_Amt = totalTT_Amt + dblTT_Amt
                If dblTT_Amt = 0 Then
                    chkRow = 2
                End If
                Dim dblDiffRatio As Double = 100 - (((dblGP_Amt - dblTT_Amt) / dblGP_Amt) * 100)

                anyData = New String() {i + 1.ToString("#,##0"), strGrpName, dblGP_Amt.ToString("#,##0.00"), dblTT_Amt.ToString("#,##0.00"), dblDiffRatio.ToString("#,##0.00"), strGrpCode}
                lvi = New ListViewItem(anyData)
                lsvRptSegment.Items.Add(lvi)
            End With

            If chkRow = 0 Then
                lvi.BackColor = Color.Yellow
                lvi.ForeColor = Color.Black
                chkRow = 1
            ElseIf chkRow = 1 Then
                lvi.BackColor = Color.White
                lvi.ForeColor = Color.Black
                chkRow = 0
            Else
                lvi.BackColor = Color.Pink
                lvi.ForeColor = Color.Black
                chkRow = 0

            End If

        Next

        totalRatio = 100 - (((totalGP_Amt - totalTT_Amt) / totalGP_Amt) * 100)
        anyData = New String() {"", "Total ====>", totalGP_Amt.ToString("#,##0.00"), totalTT_Amt.ToString("#,##0.00"), totalRatio.ToString("#,##0.00"), ""}
        lvi = New ListViewItem(anyData)
        lsvRptSegment.Items.Add(lvi)
        lvi.BackColor = Color.YellowGreen
        lvi.ForeColor = Color.Black
    End Sub

    Private Sub lsvItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvItem.SelectedIndexChanged

    End Sub

    Private Sub lsvRptSegment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvRptSegment.SelectedIndexChanged

    End Sub

    Private Sub lsvRptSegment_Click(sender As Object, e As EventArgs) Handles lsvRptSegment.Click

        Dim lvi0 As ListViewItem
        Dim strSegment As String = ""
        For i = 0 To lsvRptSegment.SelectedItems.Count - 1
            lvi0 = lsvRptSegment.SelectedItems(i)
            'Dim strGrpID As String = ""
            strSegment = lsvRptSegment.Items(lvi0.Index).SubItems(5).Text

        Next
        cboSegment.SelectedValue = strSegment
    End Sub
End Class
