Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim connection As SqlConnection = New SqlConnection("Data Source=INNORIK-7;Initial Catalog=INNOHOSPITAL;Integrated Security=True")
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdUserType.Items.Add("doctor")
        cmdUserType.Items.Add("lab")
        cmdUserType.Items.Add("opd")
        cmdUserType.Items.Add("pharmacy")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to Exit", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text = "" Then
            MessageBox.Show("User Name can't be Empty")
            txtUserName.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Password can't be Empty")
            txtPassword.Focus()
            Exit Sub
        End If

        If cmdUserType.SelectedItem = "" Then
            MessageBox.Show(" Select a User Type")
            cmdUserType.Focus()
            Exit Sub
        End If

        'Try

        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select * From Users Where UserName = '" & txtUserName.Text & "' And Password = '" & txtPassword.Text & "' And UserType = '" & cmdUserType.SelectedItem & "'", connection)
        Dim read As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Table As New DataTable
        read.Fill(Table)

        If (Table.Rows.Count > 0) Then
            MessageBox.Show("You are logged in as " & Table.Rows(0)(2))
            If (cmdUserType.SelectedIndex = 0) Then
                MessageBox.Show("Welcome Doctor")
                Doctor.Show()
                connection.Close()
                Me.Hide()

            ElseIf (cmdUserType.SelectedIndex = 1) Then
                MessageBox.Show("Welcome Technician")
                Lab.Show()
                connection.Close()
                Me.Hide()
            ElseIf (cmdUserType.SelectedIndex = 2) Then
                MessageBox.Show("Welcome To the Out Patient Department")
                OPD.Show()
                connection.Close()
                Me.Hide()
            ElseIf (cmdUserType.SelectedIndex = 3) Then
                MessageBox.Show("Welcome Pharmacist")
                Pharmacy.Show()
                connection.Close()
                Me.Hide()
            End If
        Else
            MessageBox.Show("invalid User Name and Password")
                txtUserName.Text = ""
                txtPassword.Text = ""
            End If

        'Catch ex As Exception
        'MessageBox.Show("Connection Failed", "Hospital Management System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        ' End Try
    End Sub
End Class
