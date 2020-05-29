Imports System.Data

Public Class salesObj

    Public SalesMan As New Data.DataTable '("SalesMan")
    ' Public rptGrpStk As New rptGrpStk

    Sub crt_SalesMan()

        SalesMan.Columns.Add("Code", GetType(System.String))
        SalesMan.Columns("Code").Unique = True
        SalesMan.PrimaryKey = New DataColumn() {SalesMan.Columns("Code")}

        SalesMan.Columns.Add("Type", GetType(System.String))
        SalesMan.Columns.Add("Name", GetType(System.String))
        '=============================================

        '=============================================
        SalesMan.Columns.Add("Target_Sales", GetType(System.Double)) '1
        SalesMan.Columns.Add("Target_Profit", GetType(System.Double))
        SalesMan.Columns.Add("Target_GP_Sales", GetType(System.Double))
        SalesMan.Columns.Add("Target_GP_Profit", GetType(System.Double))
        SalesMan.Columns.Add("Target_GP_Weight", GetType(System.Double)) '5

        SalesMan.Columns.Add("Target_TT_Sales", GetType(System.Double))  '6
        SalesMan.Columns.Add("Target_TT_Profit", GetType(System.Double))

        '=============================================
        SalesMan.Columns.Add("Act_Target", GetType(System.Double)) '1
        SalesMan.Columns.Add("Act_Cost", GetType(System.Double)) '1
        SalesMan.Columns.Add("Act_Profit", GetType(System.Double))
        SalesMan.Columns.Add("Act_GP_Sales", GetType(System.Double))
        SalesMan.Columns.Add("Act_GP_Profit", GetType(System.Double))
        SalesMan.Columns.Add("Act_GP_Weight", GetType(System.Double)) '5

        SalesMan.Columns.Add("Act_TT_Sales", GetType(System.Double))  '6
        SalesMan.Columns.Add("Act_TT_Profit", GetType(System.Double))

        '=============================================
        SalesMan.Columns.Add("Target_D", GetType(System.Double))  '8
        SalesMan.Columns.Add("Profit_D", GetType(System.Double))
        SalesMan.Columns.Add("Cost_D", GetType(System.Double))
        SalesMan.Columns.Add("GP_Sales_D", GetType(System.Double))
        SalesMan.Columns.Add("GP_Profit_D", GetType(System.Double))
        SalesMan.Columns.Add("GP_Weight_D", GetType(System.Double))
        SalesMan.Columns.Add("TT_Sales_D", GetType(System.Double))
        SalesMan.Columns.Add("TT_Profit_D", GetType(System.Double))  '14

        '=============================================
        SalesMan.Columns.Add("Target_M", GetType(System.Double)) '15
        SalesMan.Columns.Add("Profit_M", GetType(System.Double))
        SalesMan.Columns.Add("GP_Sales_M", GetType(System.Double))
        SalesMan.Columns.Add("GP_Profit_M", GetType(System.Double))
        SalesMan.Columns.Add("GP_Weight_M", GetType(System.Double)) '19

        SalesMan.Columns.Add("TT_Sales_M", GetType(System.Double))  '20
        SalesMan.Columns.Add("TT_Profit_M", GetType(System.Double))
        '=============================================
        SalesMan.Columns.Add("Target_Y", GetType(System.Double))  '22
        SalesMan.Columns.Add("Profit_Y", GetType(System.Double))
        SalesMan.Columns.Add("GP_Sales_Y", GetType(System.Double))
        SalesMan.Columns.Add("GP_Profit_Y", GetType(System.Double))
        SalesMan.Columns.Add("GP_Weight_Y", GetType(System.Double))

        SalesMan.Columns.Add("TT_Sales_Y", GetType(System.Double))
        SalesMan.Columns.Add("TT_Profit_Y", GetType(System.Double)) '29
        'rptGrpStk.crtDBtbSTkGrp()
    End Sub
    Sub addNewSales(SL_Type As String, SL_Code As String, SL_Name As String)

        Dim s As String
        Dim foundRow As DataRow
        s = SL_Code   'ข้อมูลที่จะค้นหา       
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then  ' ถ้ามีอยู่แล้ว

            '    foundRow.Item("Code") = SL_Code
            '    foundRow.Item("Name") = SL_Name
        Else
            SalesMan.Rows.Add(New Object() {SL_Code, SL_Type, SL_Name, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        End If

    End Sub
    Sub setTarget(sl_code As String, Target As Double,
                  Profit As Double, TargetGP As Double,
                  ProfitGP As Double, WeightGP As Double, TargetTT As Double, ProfitTT As Double)


        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then

            foundRow.Item("Target_Sales") = Target + foundRow.Item("Target_Sales")
            foundRow.Item("Target_Profit") = Profit + foundRow.Item("Target_Profit")

            foundRow.Item("Target_GP_Sales") = TargetGP + foundRow.Item("Target_GP_Sales")
            foundRow.Item("Target_GP_Profit") = ProfitGP + foundRow.Item("Target_GP_Profit")
            foundRow.Item("Target_GP_Weight") = WeightGP + foundRow.Item("Target_GP_Weight")

            foundRow.Item("Target_TT_Sales") = TargetTT + foundRow.Item("Target_TT_Sales")
            foundRow.Item("Target_TT_Profit") = ProfitTT + foundRow.Item("Target_TT_Profit")


        End If
    End Sub
    Sub setAct(sl_code As String, Target As Double,
                  Profit As Double, TargetGP As Double, Cost As Double,
                  ProfitGP As Double, WeightGP As Double, TargetTT As Double, ProfitTT As Double)


        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then

            foundRow.Item("Act_Target") = Target + foundRow.Item("Act_Target")
            foundRow.Item("Act_Profit") = Profit + foundRow.Item("Act_Profit")
            foundRow.Item("Act_Cost") = Cost + foundRow.Item("Act_Cost")

            foundRow.Item("Act_GP_Sales") = TargetGP + foundRow.Item("Act_GP_Sales")

            foundRow.Item("Act_GP_Profit") = ProfitGP + foundRow.Item("Act_GP_Profit")
            foundRow.Item("Act_GP_Weight") = WeightGP + foundRow.Item("Act_GP_Weight")

            foundRow.Item("Act_TT_Sales") = TargetTT + foundRow.Item("Act_TT_Sales")
            foundRow.Item("Act_TT_Profit") = ProfitTT + foundRow.Item("Act_TT_Profit")

        Else
            MsgBox("พบการขายใน Sales เลขที่==" & s & "=" & getSaleName(s) & "เปิดใช้รหัส Sales นี้ก่อนดูรายงาน")
        End If
    End Sub
    Sub setSalesGP_D(sl_code As String, SalesGP As Double, Cost As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then
            If IsDBNull(foundRow.Item("GP_Sales_D")) Then
                foundRow.Item("GP_Sales_D") = SalesGP + 0 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Target_D") = SalesGP + 0 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Cost_D") = Cost + 0
            Else
                foundRow.Item("GP_Sales_D") = SalesGP + foundRow.Item("GP_Sales_D") 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Target_D") = SalesGP + foundRow.Item("Target_D") 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Cost_D") = Cost + foundRow.Item("Cost_D")
            End If
        Else
        End If
    End Sub
    Sub setWeightGP_D(sl_code As String, WeightGP As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then
            If IsDBNull(foundRow.Item("GP_Weight_D")) Then
                foundRow.Item("GP_Weight_D") = WeightGP + 0 'dt.Rows(s)("Cost_Total")
                'foundRow.Item("We==_D") = WeightGP + 0 'dt.Rows(s)("Cost_Total")
            Else
                foundRow.Item("GP_Weight_D") = WeightGP + foundRow.Item("GP_Weight_D") 'dt.Rows(s)("Cost_Total")
                'foundRow.Item("Target_D") = WeightGP + foundRow.Item("Target_D") 'dt.Rows(s)("Cost_Total")
            End If
        Else
        End If
    End Sub
    Sub setSalesTT_D(sl_code As String, SalesTT As Double, Cost As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then
            If IsDBNull(foundRow.Item("TT_Sales_D")) Then
                foundRow.Item("TT_Sales_D") = SalesTT + 0 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Target_D") = SalesTT + 0
                foundRow.Item("Cost_D") = Cost + 0
            Else
                foundRow.Item("TT_Sales_D") = SalesTT + foundRow.Item("TT_Sales_D") 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Target_D") = SalesTT + foundRow.Item("Target_D")
                foundRow.Item("Cost_D") = Cost + foundRow.Item("Cost_D")
            End If
            'If IsDBNull(foundRow.Item("Profit_D")) Then

            'End If
        Else
        End If
    End Sub

    Sub setProfitGP_D(sl_code As String, ProfitGP As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then
            If IsDBNull(foundRow.Item("GP_Profit_D")) Then
                foundRow.Item("GP_Profit_D") = ProfitGP + 0 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Profit_D") = ProfitGP + 0 'dt.Rows(s)("Cost_Total")
            Else
                foundRow.Item("GP_Profit_D") = ProfitGP + foundRow.Item("GP_Profit_D") 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Profit_D") = ProfitGP + foundRow.Item("Profit_D") 'dt.Rows(s)("Cost_Total")
            End If
        Else
        End If
    End Sub

    Sub setProfitTT_D(sl_code As String, ProfitTT As Double)
        Dim foundRow As DataRow
        Dim s As String
        s = sl_code
        foundRow = SalesMan.Rows.Find(s)
        If foundRow IsNot Nothing Then
            If IsDBNull(foundRow.Item("TT_Profit_D")) Then
                foundRow.Item("TT_Profit_D") = ProfitTT + 0 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Profit_D") = ProfitTT + 0
            Else
                foundRow.Item("TT_Profit_D") = ProfitTT + foundRow.Item("TT_Profit_D") 'dt.Rows(s)("Cost_Total")
                foundRow.Item("Profit_D") = ProfitTT + foundRow.Item("Profit_D")
            End If
            'If IsDBNull(foundRow.Item("Profit_D")) Then

            'End If
        Else
        End If
    End Sub

End Class
