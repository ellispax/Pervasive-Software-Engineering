Imports MySql.Data.MySqlClient


Public Class Form1


    Private Sub clear()
        txtpassword.Text = ""
        txtusername.Text = ""

        txtusername.Focus()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Public Sub sendname()
        MDI_Home.lbluser.Text = txtusername.Text
        Dim stamp As String = GetTimeStamp()
        MDI_Home.lbllog.Text = stamp

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtusername.Text = "" Then
            MsgBox("Please provide username!")
            txtusername.Focus()
            Exit Sub

        End If

        If txtpassword.Text = "" Then
            MsgBox("Please provide Passsword!")
            txtpassword.Focus()
            Exit Sub
        End If

        Dim User As String = txtusername.Text
        Dim Pass As String = txtpassword.Text
        Dim sqlQuery As String = "SELECT username, password FROM users where username = '" + User + "' and password = '" + Pass + "' "

        'incase you use SQL Server
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand

        'connecting using mysql connector
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        Dim TABLE As New DataTable
        'Dim i As Integer
        conn = GetConnect()
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        conn.Open()
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)

            ' username = User
            If TABLE.Rows.Count <= 0 Then
                MessageBox.Show("Unknown Login Credentials ")
                clear()

            Else
                'sendname()
                MDI_Home.Show()
                sendname()


                Me.Hide()


            End If
        End With


        'If txtusername.Text = "ellis" And txtpassword.Text = "mapakama" Then

        '    MDI_Home.Show()
        '    Me.Hide()
        'Else
        '    MsgBox("Wrong Username or Password!", vbAbortRetryIgnore)
        '    clear()

        'End If
    End Sub
End Class
