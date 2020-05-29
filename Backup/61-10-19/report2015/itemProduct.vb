Public Class itemProduct
    Private _StkCode As String
    Private _StkName As String

    Public Sub New(ByVal stkcode As String, ByVal stkname As String)
        _StkCode = stkcode
        _StkName = stkname
    End Sub

    Public Property ProDuct_Name() As String
        Get
            Return _StkName
        End Get
        Set(ByVal value As String)
            _StkName = value
        End Set
    End Property


    Public Property StkCode() As String
        Get
            Return _StkCode
        End Get
        Set(ByVal value As String)
            _StkCode = value
        End Set
    End Property
End Class
