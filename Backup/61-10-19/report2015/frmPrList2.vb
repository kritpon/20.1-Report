Public Class frmPrList2
    Dim lvi As ListViewItem
    Dim chkData As Boolean = False
    Dim subDA As SqlClient.SqlDataAdapter
    Dim subDS As New DataSet
    Private Sub frmPrList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatGrid()
    End Sub

    Sub formatGrid()


        lsv3X6.Columns.Add("ใส", 68, HorizontalAlignment.Right)
        lsv3X6.Columns.Add("ขาว", 68, HorizontalAlignment.Right)
        lsv3X6.Columns.Add("สี", 68, HorizontalAlignment.Right)

        lsv3X6.View = View.Details
        lsv3X6.GridLines = True

        lsv1X2.Columns.Add("ใส", 68, HorizontalAlignment.Right)
        lsv1X2.Columns.Add("ขาว", 68, HorizontalAlignment.Right)
        lsv1X2.Columns.Add("สี", 68, HorizontalAlignment.Right)


        lsv1X2.View = View.Details
        lsv1X2.GridLines = True

        lsv4X6L.Columns.Add("ใส", 68, HorizontalAlignment.Right)
        lsv4X6L.Columns.Add("ขาว", 68, HorizontalAlignment.Right)
        lsv4X6L.Columns.Add("สี", 68, HorizontalAlignment.Right)


        lsv4X6L.View = View.Details
        lsv4X6L.GridLines = True

        lsv1X2.Columns.Add("ใส", 68, HorizontalAlignment.Right)
        lsv1X2.Columns.Add("ขาว", 68, HorizontalAlignment.Right)
        lsv1X2.Columns.Add("สี", 68, HorizontalAlignment.Right)


        lsv3X6.View = View.Details
        lsv3X6.GridLines = True


        'chkCol = True

    End Sub
    Function getSizeH(txtSize As String) As Double
        Dim i As Integer = 0
        Dim strI As String = ""
        Dim strL As String = ""
        Dim dblI As Double = 0

        For i = 0 To txtSize.Count - 1
            If strI = "X" Then
                Exit For
            End If
            strI = Mid(txtSize, i, 1)
            strL = strL & strI

        Next
        Return CDbl(strL)
    End Function

    Private Sub cmdCal_Click(sender As Object, e As EventArgs) Handles cmdCal.Click
        Dim anyData() As String
        Dim iRow As Integer = 0
        Dim Gvalue As Double = txtGvalue.Text
        Dim CostPr As Double = txtCost.Text
        Dim PriceSL As DueDate = txtPrice000.Text



        'Dim th0150 As Double = 1.5 : Dim th0200 As Double = 2.0
        'Dim th0250 As Double = 2.5 : Dim th0280 As Double = 2.8
        'Dim th0300 As Double = 3.0 : Dim th0400 As Double = 4.0
        'Dim th0476 As Double = 4.76 : Dim th0500 As Double = 5.0
        'Dim th0600 As Double = 6.0 : Dim th0800 As Double = 8.0
        txtSQL = "Select * "
        txtSQL = txtSQL & "From PriceThickMask "
        txtSQL = txtSQL & "order by Pr_Thick_V "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Command").Clear()
            chkData = False
        End If
        subDA.Fill(subDS, "Command")
        chkData = True
        lsv1X2.Items.Clear()
        lsv3X6.Items.Clear()
        lsv4X6L.Items.Clear()
        lsv4X6S.Items.Clear()
        lsv4X8L.Items.Clear()
        lsv4X8S.Items.Clear()

        For iRow = 0 To subDS.Tables("Command").Rows.Count - 1
            Dim colClean As Double = 0
            Dim colWhite As Double = 0
            Dim colColor As Double = 0
            Dim thick As Double  'subDS.Tables("Comment)

            With subDS.Tables("Command")
                thick = .Rows(iRow).Item("Pr_Thick_V")

                colClean = ((95 * 185 * thick * txtGvalue.Text) / 10000) * txtPrice000.Text
                colWhite = ((95 * 185 * thick * txtGvalue.Text) / 10000) * txtPriceWhite.Text
                colColor = ((95 * 185 * thick * txtGvalue.Text) / 10000) * txtPriceColor.Text

                anyData = {colClean.ToString("#,##0"), colWhite.ToString("#,##0"), colColor.ToString("#,##0")}
                lvi = New ListViewItem(anyData)
                lsv3X6.Items.Add(lvi)
            End With

            With subDS.Tables("Command")
                thick = .Rows(iRow).Item("Pr_Thick_V")

                colClean = ((101 * 201 * thick * txtGvalue.Text) / 10000) * txtPrice000.Text
                colWhite = ((101 * 201 * thick * txtGvalue.Text) / 10000) * txtPriceWhite.Text
                colColor = ((101 * 201 * thick * txtGvalue.Text) / 10000) * txtPriceColor.Text

                anyData = {colClean.ToString("#,##0"), colWhite.ToString("#,##0"), colColor.ToString("#,##0")}
                lvi = New ListViewItem(anyData)
                lsv1X2.Items.Add(lvi)
            End With


            'Dim sizeH As Double = 0 'getSizeH(lb101x201.Text)




            'If chkRow = True Then
            '    colorList(True)
            '    chkRow = False
            'Else
            '    colorList(False)
            '    chkRow = True
            'End If
        Next

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Hide()
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice000.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class