Imports System.Data
Imports MySql.Data.MySqlClient


Module DbConnect

    'Public conn As SqlConnection
    Public conn As MySqlConnection
    Public stamp As String


    Public Function GetConnect()
        'conn = New SqlConnection("server=ELLIS_PAX-PC\MAPAKAME;Trusted_Connection = True;database=Shop;")
        conn = New MySqlConnection("server=rds-pervasive-proj.cb3epmfrlspm.us-east-2.rds.amazonaws.com; uid=admin;pwd=mapakame0605;database=pervasivedb;")
        'conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\SCSdb.mdf;Integrated Security=True")
        Return conn
    End Function

    Public Function GetTimeStamp()
        Dim yy As String = Now.Year.ToString
        Dim m As String = Now.Month.ToString
        Dim d As String = Now.Day.ToString
        Dim h As String = Now.Hour.ToString
        Dim mm As String = Now.Minute.ToString
        Dim ss As String = Now.Second.ToString

        stamp = yy & "/" & m & "/" & d & " " & h & ":" & mm & ":" & ss
        Return stamp
    End Function


End Module
