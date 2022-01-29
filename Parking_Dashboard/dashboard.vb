Imports System.Data
Imports System.Net
Imports MySql.Data.MySqlClient


Public Class dashboard

    Private Sub get_lots()
        Dim sqlQuery As String = "SELECT * FROM parking_lots WHERE lot_id = 220010001 "

        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        'use if using sql server for database
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand


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

            'fix for listview not to duplicate items
            'listMembers.Items.Clear()
        End With

        If TABLE.Rows.Count > 0 Then

            ' Dim a, c, s As Integer
            'a = TABLE.Rows(0)(3)
            'c = TABLE.Rows(0)(4)

            's = a - c

            lblName.Text = TABLE.Rows(0)(1).ToString
            'lblSlots.Text = TABLE.Rows(0)(1).ToString
            'lblfree.Text = TABLE.Rows(0)(2).ToString
            'lblvisitors.Text = TABLE.Rows(0)(3).ToString
            'lblresidents.Text = TABLE.Rows(0)(4).ToString
            'lblUsed.Text = lblvisitors.Text + lblresidents.Text



        Else
            MsgBox("Item Not Found !")
            'clear()

        End If
    End Sub
    Private Sub get_counts()
        Dim sqlQuery As String = "SELECT * FROM counters WHERE lot_id = 220010001 "

        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        'use if using sql server for database
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand


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

            'fix for listview not to duplicate items
            'listMembers.Items.Clear()
        End With

        If TABLE.Rows.Count > 0 Then

            Dim a, c, s As Integer
            'a = TABLE.Rows(0)(3)
            'c = TABLE.Rows(0)(4)

            's = a - c

            'lblName.Text = TABLE.Rows(0)(1).ToString
            lblSlots.Text = TABLE.Rows(0)(1).ToString
            lblfree.Text = TABLE.Rows(0)(2).ToString
            lblvisitors.Text = TABLE.Rows(0)(3).ToString
            lblresidents.Text = TABLE.Rows(0)(4).ToString
            a = lblvisitors.Text
            c = lblresidents.Text
            lblUsed.Text = a + c



        Else
            MsgBox("Item Not Found !")
            'clear()

        End If
    End Sub
    Private Sub get_members()
        Dim sqlQuery As String = "SELECT * FROM members "

        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        'use if using sql server for database
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand


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

            'fix for listview not to duplicate items
            'listMembers.Items.Clear()
        End With

        Dim members As Integer = TABLE.Rows.Count
        lblMCount.Text = members
    End Sub
    'get weather data 

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Close()
        members.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_lots()
        get_counts()

        get_members()
    End Sub


End Class