Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class OPD

    Dim connection As SqlConnection = New SqlConnection("Data Source=INNORIK-7;Initial Catalog=INNOHOSPITAL;Integrated Security=True")
    Private Sub Patient_RecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Patient_RecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Patient_RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.INNOHOSPITALDataSet)

    End Sub

    Private Sub OPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet.Patient_Records' table. You can move, or remove it, as needed.
        Me.Patient_RecordsTableAdapter.Fill(Me.INNOHOSPITALDataSet.Patient_Records)


        cmbSearch.Items.Add("ReferenceNumber")
        cmbSearch.Items.Add("FirstName")
        cmbSearch.Items.Add("LastName")


        LoadDataInGrid()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue = cmbSearch.Text

        Select Case searchValue
            Case "ReferenceNumber"
                Me.Patient_RecordsBindingSource.Filter = "ReferenceNumber = '" & txtSearch.Text & "'"
            Case "FirstName"
                Me.Patient_RecordsBindingSource.Filter = "FirstName = '" & txtSearch.Text & "'"
            Case "LastName"
                Me.Patient_RecordsBindingSource.Filter = "LastName = '" & txtSearch.Text & "'"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to Exit", "Innorik Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Me.Patient_RecordsBindingSource.MoveFirst()
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        Me.Patient_RecordsBindingSource.MoveLast()
    End Sub

    Private Sub btnMovePrevious_Click(sender As Object, e As EventArgs) Handles btnMovePrevious.Click
        Me.Patient_RecordsBindingSource.MovePrevious()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Me.Patient_RecordsBindingSource.MoveNext()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            Static cmd As New SqlCommand("UPDATE Patient_Records SET FirstName = '" & FirstNameTextBox.Text & "', MiddleName ='" & MiddleNameTextBox.Text & "',
                                                              LastName = '" & LastNameTextBox.Text & "',DateOfBirth = '" & DateOfBirthDateTimePicker.Value & "', Age = '" & AgeTextBox.Text & "',
                                                              Occupation = '" & OccupationTextBox.Text & "', MaritalStatus = '" & MaritalStatusTextBox.Text & "',
                                                             NextOfKin =  '" & NextOfKinTextBox.Text & "',HouseAddress ='" & HouseAddressTextBox.Text & "', Location = '" & LocationTextBox.Text & "',
                                                             PhoneNumber =  '" & PhoneNumberTextBox.Text & "', TimeOfAdmission = '" & TimeOfAdmissionTextBox.Text & "', TimeOfDischarge ='" & TimeOfDischargeTextBox.Text & "' WHERE ReferenceNumber = '" & ReferenceNumberTextBox.Text & "'", connection)

            If MessageBox.Show("Update Pateint Record", "Innorik Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If (cmd.ExecuteNonQuery()) Then
                    MsgBox("Updated Successfully")
                    connection.Close()
                End If
                LoadDataInGrid()
                ReferenceNumberTextBox.Text = ""
                FirstNameTextBox.Text = ""
                MiddleNameTextBox.Text = ""
                LastNameTextBox.Text = ""
                DateOfBirthDateTimePicker.ResetText()
                AgeTextBox.Text = ""
                OccupationTextBox.Text = ""
                MaritalStatusTextBox.Text = ""
                NextOfKinTextBox.Text = ""
                HouseAddressTextBox.Text = ""
                LocationTextBox.Text = ""
                PhoneNumberTextBox.Text = ""
                TimeOfAdmissionTextBox.Text = ""
                TimeOfDischargeTextBox.Text = ""


            End If
        Catch ex As Exception
            If MessageBox.Show("Connection Failed", "Innorik Hospital Management System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                MessageBox.Show("Establishing Connection")
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub LoadDataInGrid()
        connection.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Patient_Records", connection)
        Dim Source As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        Source.Fill(table)
        Patient_RecordsDataGridView.DataSource = table
        connection.Close()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            connection.Open()
            Dim cmd As New SqlCommand("Delete From Patient_Records Where ReferenceNumber = '" & ReferenceNumberTextBox.Text & "' Or LastName ='" & LastNameTextBox.Text & "'")

            If MessageBox.Show("Delete Pateint Record", "Innorik Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If (cmd.ExecuteNonQuery()) Then
                    connection.Close()
                    MsgBox("Deleted Successfully")
                End If
                LoadDataInGrid()

                ReferenceNumberTextBox.Clear()
                FirstNameTextBox.Clear()
                MiddleNameTextBox.Clear()
                LastNameTextBox.Clear()
                DateOfBirthDateTimePicker.ResetText()


            End If
        Catch ex As Exception
            If MessageBox.Show("Connection Failed", "Innorik Hospital Management System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                MessageBox.Show("Establishing Connection")
                Exit Sub
            End If
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Try
            connection.Open()
            Dim cmd As New SqlCommand("INSERT INTO Patient_Records  VALUES('" & ReferenceNumberTextBox.Text & "', '" & FirstNameTextBox.Text & "','" & MiddleNameTextBox.Text & "',
                                                             '" & LastNameTextBox.Text & "','" & DateOfBirthDateTimePicker.Value & "', '" & AgeTextBox.Text & "',
                                                             '" & OccupationTextBox.Text & "','" & MaritalStatusTextBox.Text & "',
                                                            '" & NextOfKinTextBox.Text & "','" & HouseAddressTextBox.Text & "', '" & LocationTextBox.Text & "',
                                                           '" & PhoneNumberTextBox.Text & "','" & TimeOfAdmissionTextBox.Text & "', '" & TimeOfDischargeTextBox.Text & "')", connection)

            If MessageBox.Show("Delete Pateint Record", "Innorik Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                If (cmd.ExecuteNonQuery()) Then
                    MsgBox("Registered Successfully")
                    connection.Close()
                End If
                LoadDataInGrid()
                ReferenceNumberTextBox.Clear()
                FirstNameTextBox.Clear()
                MiddleNameTextBox.Clear()
                LastNameTextBox.Clear()
                DateOfBirthDateTimePicker.ResetText()

            End If
        Catch ex As Exception
            If MessageBox.Show("Connection Failed", "Innorik Hospital Management System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Retry Then
                MessageBox.Show("Establishing Connection")
                Exit Sub
            End If
        End Try
    End Sub
End Class