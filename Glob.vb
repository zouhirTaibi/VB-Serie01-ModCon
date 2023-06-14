Imports System.Data.SqlClient

Module Glob
    Public strCon As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\GestStg.mdf;Integrated Security=True;User Instance=True"
    'Public strCon As String = "Data source=.\SQLExpress; integrated security=true;initial catalog=GestStg"

    Public StgCon As New SqlConnection(strCon)
    Public StgCmd As New SqlCommand("", StgCon)
    Public StgDr As SqlDataReader

End Module
