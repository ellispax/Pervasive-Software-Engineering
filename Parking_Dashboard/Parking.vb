Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Parking
    Dim State As Boolean = False


    Public Sub loadListview() ' this will load the list view for members
        Dim sqlQuery As String = "SELECT * FROM parking WHERE number_plate = '" + txtnumplate.Text + "' "

        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        'use if using sql server for database
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand


        Dim TABLE As New DataTable
        Dim i As Integer
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
            listIndividual.Items.Clear()
        End With

        For i = 0 To TABLE.Rows.Count - 1
            With listIndividual
                .Items.Add(TABLE.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("number_plate"))
                    .Add(TABLE.Rows(i)("time_in"))
                    .Add(TABLE.Rows(i)("time_out"))
                    .Add(TABLE.Rows(i)("designation"))

                End With
            End With

        Next
        conn.Close()
    End Sub
    Public Sub loadItemListview() ' this will load the list view for members
        Dim sqlQuery As String = "SELECT * FROM parking "

        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand

        'use if using sql server for database
        'Dim sqlAdapter As New SqlDataAdapter
        'Dim sqlCommand As New SqlCommand


        Dim TABLE As New DataTable
        Dim i As Integer
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
            listParking.Items.Clear()
        End With
        If TABLE.Rows.Count <= 0 Then
            MsgBox("No Records Found with Number Plate provided!!", vbOKOnly)
            Exit Sub
        Else
            State = True
        End If
        For i = 0 To TABLE.Rows.Count - 1
            With listParking
                .Items.Add(TABLE.Rows(i)("id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("number_plate"))
                    .Add(TABLE.Rows(i)("time_in"))
                    .Add(TABLE.Rows(i)("time_out"))
                    .Add(TABLE.Rows(i)("designation"))

                End With
            End With

        Next
        conn.Close()

    End Sub
    Private Sub Parking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemListview()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        loadListview()
        If State = True Then
            listIndividual.Visible = True
            listParking.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtnumplate.Text = ""
        listParking.Visible = True
        listIndividual.Visible = False

    End Sub
End Class