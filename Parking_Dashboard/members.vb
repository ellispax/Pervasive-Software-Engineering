Imports System.Data
Imports MySql.Data.MySqlClient

Public Class members
    Private Sub Unlock()
        ' txtid.Enabled = True
        txtname.Enabled = True
        txtnumplate.Enabled = True
        txtmodel.Enabled = True
        txtemail.Enabled = True
        txtapartnum.Enabled = True

    End Sub

    Private Sub LocK()
        txtid.Enabled = False
        txtname.Enabled = False
        txtnumplate.Enabled = False
        txtmodel.Enabled = False
        txtemail.Enabled = False
        txtapartnum.Enabled = False
    End Sub

    Private Sub clear()
        txtid.Text = ""
        txtname.Text = ""
        txtnumplate.Text = ""
        txtmodel.Text = ""
        txtemail.Text = ""
        txtapartnum.Text = ""

        txtid.Focus()

    End Sub



    Public Sub loadItemListview() ' this will load the list view for members
        Dim sqlQuery As String = "SELECT * FROM members "

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
            listMembers.Items.Clear()
        End With

        For i = 0 To TABLE.Rows.Count - 1
            With listMembers
                .Items.Add(TABLE.Rows(i)("member_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("full_name"))
                    .Add(TABLE.Rows(i)("number_plate"))
                    .Add(TABLE.Rows(i)("car_model"))
                    .Add(TABLE.Rows(i)("aprt_number"))
                    .Add(TABLE.Rows(i)("email"))
                    .Add(TABLE.Rows(i)("active_status"))

                End With
            End With

        Next
        conn.Close()
    End Sub



    Private Sub members_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadItemListview()

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear()
        Unlock()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        clear()
        LocK()

    End Sub

    Public Sub AbortAdd()
        clear()
        LocK()

    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Public Sub CheckDoesNotExist()
        Dim sqlQuery As String = "SELECT * FROM members WHERE number_plate = '" + txtnumplate.Text + "' "
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim TABLE As New DataTable

        conn = GetConnect()
        With sqlCommand
            .CommandText = sqlQuery
            .Connection = conn
        End With

        conn.Open()
        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(TABLE)
        End With

        If TABLE.Rows.Count > 0 Then
            Dim qn As VariantType = MsgBox("The number plate you entered already exists." & vbCrLf & "Click Retry to re-enter or Cancel to abort the operation.", vbCritical + vbRetryCancel, "Wrong Input Data")
            If qn = vbRetry Then
                GoTo err
            Else
                AbortAdd()
                Exit Sub
            End If
        End If
        Exit Sub
err:

        txtid.Focus()
        txtid.SelectAll()
    End Sub
    Public Sub Check_Fields()
        If txtname.Text = "" Then
            MsgBox("Name Cannot be BLANK", vbCritical, "Missing  Name")
            txtname.Focus()
            Exit Sub
        End If

        If txtnumplate.Text = "" Then
            MsgBox("Number Plat cannot be blank", vbCritical, "Missing Number Plate")
            txtnumplate.Focus()

        End If

        If txtmodel.Text = "" Then
            MsgBox("Car Model cannot be BLANK!", vbCritical, "Missing Car Model")
            txtmodel.Focus()

        End If

        If txtapartnum.Text = "" Then
            MsgBox("Apartment Number Cannot be BLANK", vbCritical, "Missing Apartment Number")
            txtapartnum.Focus()
            Exit Sub
        End If

        If txtemail.Text = "" Then
            MsgBox("Email cannot be blank", vbCritical, "Missing user Email")
            txtemail.Focus()

        End If


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Check_Fields()

        conn = GetConnect()
        Dim sqlCommand As New MySqlCommand("INSERT INTO members ( full_name, number_plate, car_model, aprt_number, email, active_status) VALUES ('" + txtname.Text + "', '" + txtnumplate.Text + "','" + txtmodel.Text + "','" + txtapartnum.Text + "','" + txtemail.Text + "','Active') ", conn)

        Try
            conn.Open()
            sqlCommand.ExecuteNonQuery()
            MsgBox("Record Saved successfully.", vbInformation, "SAVED")

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        conn.Close()
        loadItemListview()
    End Sub
End Class