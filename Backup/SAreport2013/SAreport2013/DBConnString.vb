Option Explicit On
Option Strict On

Public NotInheritable Class DBConnString

    'Public Shared strConn2 As String = "Data Source=BD_KRITPON\SQLEXPRESS;Initial Catalog=DB2006;User ID=sa;Password=sys0500"    
    'Public Shared strConn2 As String = "Data Source=BD_Kritpon\SQLEXPRESS;Initial Catalog=DB2012a;User ID=sa;Password=sys0500"
    'Public Shared strConn2 As String = "server=BD_Kritpon\SQLExpress;database=DB2012;Trusted_Connection=yes;"

    'Public Shared strConn2 As String = "Data Source=7.213.77.186\SQLEXPRESS;Initial Catalog=DB2012;User ID=sa;Password=$y$0500"


    '  ��Ѻ����ͧ��� VK


    'Public Shared strConn2 As String = "Data Source=192.168.1.3\SQLEXPRESS;Initial Catalog=db2012; User ID=sa;Password=$y$05000"
    Public Shared strConn2 As String = "Data Source=192.168.1.3\SQLEXPRESS;Initial Catalog=newZone; User ID=sa;Password=$y$05000"
    'Public Shared strConn2 As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test2015;" ' User ID=sa;Password=$y$05000"
    'Public Shared strConn2 As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db2012;" ' User ID=sa;Password=$y$05000"

    'Public Shared strConn2 As String = "Data Source=BD_Kritpon-pc\SQLEXPRESS;Initial Catalog=DB2012;User ID=sa;Password=sys0500"


    '===================================================================================

    Public Shared UserName As String = ""

End Class