Imports System.Data.SqlClient

Public Class Doctor
    Dim connection As SqlConnection = New SqlConnection("Data Source=INNORIK-7;Initial Catalog=INNOHOSPITAL;Integrated Security=True")


    Private Sub Patient_RecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DoctorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.INNOHOSPITALDataSet1)

    End Sub


    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet1.Patient_Records' table. You can move, or remove it, as needed.
        Me.Patient_RecordsTableAdapter.Fill(Me.INNOHOSPITALDataSet1.Patient_Records)
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet1.Patient_Records' table. You can move, or remove it, as needed.
        Me.Patient_RecordsTableAdapter.Fill(Me.INNOHOSPITALDataSet1.Patient_Records)
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet1.Prescription' table. You can move, or remove it, as needed.
        Me.PrescriptionTableAdapter.Fill(Me.INNOHOSPITALDataSet1.Prescription)
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet1.Nurse' table. You can move, or remove it, as needed.
        Me.NurseTableAdapter.Fill(Me.INNOHOSPITALDataSet1.Nurse)
        'TODO: This line of code loads data into the 'INNOHOSPITALDataSet1.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.INNOHOSPITALDataSet1.Doctor)

        cmbSearchDoc.Items.Add("Doctor_Ref_No")
        cmbSearchDoc.Items.Add("Doctor_NHS_No")

    End Sub

    Private Sub tabNurse_Click(sender As Object, e As EventArgs) Handles tabNurse.Click



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to Exit", "Innorik Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnMoveFirst_Click(sender As Object, e As EventArgs) Handles btnMoveFirst.Click
        Me.DoctorBindingSource.MoveFirst()
    End Sub

    Private Sub btnMoveLast_Click(sender As Object, e As EventArgs) Handles btnMoveLast.Click
        Me.DoctorBindingSource.MoveLast()
    End Sub

    Private Sub btnMovePrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.DoctorBindingSource.MovePrevious()
    End Sub

    Private Sub btnMoveNext_Click(sender As Object, e As EventArgs) Handles btnMoveNext.Click
        Me.DoctorBindingSource.MoveNext()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub



















    Private Sub LoadDataInGrid()
        connection.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Doctor", connection)
        Dim Source As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        Source.Fill(table)
        DoctorDataGridView.DataSource = table
        connection.Close()

    End Sub


End Class