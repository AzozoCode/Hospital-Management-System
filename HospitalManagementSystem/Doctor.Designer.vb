<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Doctor_Ref_NoLabel As System.Windows.Forms.Label
        Dim Doctor_NHS_NoLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Medical_CenterLabel As System.Windows.Forms.Label
        Dim Address_Of_CenterLabel As System.Windows.Forms.Label
        Dim Medical_ReferenceLabel As System.Windows.Forms.Label
        Dim Office_Number1Label As System.Windows.Forms.Label
        Dim Office_Number2Label As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim Nurse_ReferenceLabel As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim MODLabel As System.Windows.Forms.Label
        Dim Tablet_NameLabel As System.Windows.Forms.Label
        Dim Dosage_mgLabel As System.Windows.Forms.Label
        Dim Number_Of_TabletsLabel As System.Windows.Forms.Label
        Dim Issued_DateLabel As System.Windows.Forms.Label
        Dim Expire_DateLabel As System.Windows.Forms.Label
        Dim Daily_DosageLabel As System.Windows.Forms.Label
        Dim Possible_Side_EffectLabel As System.Windows.Forms.Label
        Dim Possible_InformationLabel As System.Windows.Forms.Label
        Dim Storage_AreaLabel As System.Windows.Forms.Label
        Dim AdministrationLabel As System.Windows.Forms.Label
        Dim Driving_and_using_MachinesLabel As System.Windows.Forms.Label
        Dim ReferenceNumberLabel As System.Windows.Forms.Label
        Dim FirstNameLabel2 As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim OccupationLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim NextOfKinLabel As System.Windows.Forms.Label
        Dim HouseAddressLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim TimeOfAdmissionLabel As System.Windows.Forms.Label
        Dim TimeOfDischargeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDoctor = New System.Windows.Forms.TabPage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.FilterDoc = New System.Windows.Forms.GroupBox()
        Me.btnSearchDoc = New System.Windows.Forms.Button()
        Me.cmbSearchDoc = New System.Windows.Forms.ComboBox()
        Me.txtSearchDoc = New System.Windows.Forms.TextBox()
        Me.Doctor_Ref_NoTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INNOHOSPITALDataSet1 = New HospitalManagementSystem.INNOHOSPITALDataSet1()
        Me.Doctor_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_CenterTextBox = New System.Windows.Forms.TextBox()
        Me.Address_Of_CenterTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.Office_Number1TextBox = New System.Windows.Forms.TextBox()
        Me.Office_Number2TextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabNurse = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nurse_ReferenceTextBox = New System.Windows.Forms.TextBox()
        Me.NurseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.MODTextBox = New System.Windows.Forms.TextBox()
        Me.NurseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPrescription = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tablet_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PrescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dosage_mgTextBox = New System.Windows.Forms.TextBox()
        Me.Number_Of_TabletsTextBox = New System.Windows.Forms.TextBox()
        Me.Issued_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Expire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Daily_DosageTextBox = New System.Windows.Forms.TextBox()
        Me.Possible_Side_EffectTextBox = New System.Windows.Forms.TextBox()
        Me.Possible_InformationTextBox = New System.Windows.Forms.TextBox()
        Me.Storage_AreaTextBox = New System.Windows.Forms.TextBox()
        Me.AdministrationTextBox = New System.Windows.Forms.TextBox()
        Me.Driving_and_using_MachinesTextBox = New System.Windows.Forms.TextBox()
        Me.PrescriptionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPatient = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewPatient = New System.Windows.Forms.Button()
        Me.btnDeletePatient = New System.Windows.Forms.Button()
        Me.btnInsertPatient = New System.Windows.Forms.Button()
        Me.btnUpdatePatient = New System.Windows.Forms.Button()
        Me.Patient_RecordsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patient_RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReferenceNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusTextBox = New System.Windows.Forms.TextBox()
        Me.NextOfKinTextBox = New System.Windows.Forms.TextBox()
        Me.HouseAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TimeOfAdmissionTextBox = New System.Windows.Forms.TextBox()
        Me.TimeOfDischargeTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorTableAdapter = New HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.DoctorTableAdapter()
        Me.TableAdapterManager = New HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.TableAdapterManager()
        Me.DoctorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DoctorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NurseTableAdapter = New HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.NurseTableAdapter()
        Me.PrescriptionTableAdapter = New HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.PrescriptionTableAdapter()
        Me.Patient_RecordsTableAdapter = New HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.Patient_RecordsTableAdapter()
        Me.brnViewPrescri = New System.Windows.Forms.Button()
        Me.btnUpdatePrescri = New System.Windows.Forms.Button()
        Me.btnInsertPrescri = New System.Windows.Forms.Button()
        Me.btnDeletePrescri = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnViewNurse = New System.Windows.Forms.Button()
        Me.btnDeleteNurse = New System.Windows.Forms.Button()
        Me.btnInsertNurse = New System.Windows.Forms.Button()
        Me.btnUpdateNurse = New System.Windows.Forms.Button()
        Doctor_Ref_NoLabel = New System.Windows.Forms.Label()
        Doctor_NHS_NoLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Medical_CenterLabel = New System.Windows.Forms.Label()
        Address_Of_CenterLabel = New System.Windows.Forms.Label()
        Medical_ReferenceLabel = New System.Windows.Forms.Label()
        Office_Number1Label = New System.Windows.Forms.Label()
        Office_Number2Label = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        Nurse_ReferenceLabel = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        MODLabel = New System.Windows.Forms.Label()
        Tablet_NameLabel = New System.Windows.Forms.Label()
        Dosage_mgLabel = New System.Windows.Forms.Label()
        Number_Of_TabletsLabel = New System.Windows.Forms.Label()
        Issued_DateLabel = New System.Windows.Forms.Label()
        Expire_DateLabel = New System.Windows.Forms.Label()
        Daily_DosageLabel = New System.Windows.Forms.Label()
        Possible_Side_EffectLabel = New System.Windows.Forms.Label()
        Possible_InformationLabel = New System.Windows.Forms.Label()
        Storage_AreaLabel = New System.Windows.Forms.Label()
        AdministrationLabel = New System.Windows.Forms.Label()
        Driving_and_using_MachinesLabel = New System.Windows.Forms.Label()
        ReferenceNumberLabel = New System.Windows.Forms.Label()
        FirstNameLabel2 = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        OccupationLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        NextOfKinLabel = New System.Windows.Forms.Label()
        HouseAddressLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        TimeOfAdmissionLabel = New System.Windows.Forms.Label()
        TimeOfDischargeLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabDoctor.SuspendLayout()
        Me.FilterDoc.SuspendLayout()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INNOHOSPITALDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNurse.SuspendLayout()
        CType(Me.NurseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NurseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPrescription.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPatient.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Patient_RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorBindingNavigator.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Doctor_Ref_NoLabel
        '
        Doctor_Ref_NoLabel.AutoSize = True
        Doctor_Ref_NoLabel.Location = New System.Drawing.Point(6, 27)
        Doctor_Ref_NoLabel.Name = "Doctor_Ref_NoLabel"
        Doctor_Ref_NoLabel.Size = New System.Drawing.Size(185, 29)
        Doctor_Ref_NoLabel.TabIndex = 1
        Doctor_Ref_NoLabel.Text = "Doctor Ref No:"
        '
        'Doctor_NHS_NoLabel
        '
        Doctor_NHS_NoLabel.AutoSize = True
        Doctor_NHS_NoLabel.Location = New System.Drawing.Point(6, 67)
        Doctor_NHS_NoLabel.Name = "Doctor_NHS_NoLabel"
        Doctor_NHS_NoLabel.Size = New System.Drawing.Size(199, 29)
        Doctor_NHS_NoLabel.TabIndex = 3
        Doctor_NHS_NoLabel.Text = "Doctor NHS No:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 107)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(148, 29)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(6, 147)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(124, 29)
        SurnameLabel.TabIndex = 7
        SurnameLabel.Text = "Surname:"
        '
        'Medical_CenterLabel
        '
        Medical_CenterLabel.AutoSize = True
        Medical_CenterLabel.Location = New System.Drawing.Point(6, 187)
        Medical_CenterLabel.Name = "Medical_CenterLabel"
        Medical_CenterLabel.Size = New System.Drawing.Size(197, 29)
        Medical_CenterLabel.TabIndex = 9
        Medical_CenterLabel.Text = "Medical Center:"
        '
        'Address_Of_CenterLabel
        '
        Address_Of_CenterLabel.AutoSize = True
        Address_Of_CenterLabel.Location = New System.Drawing.Point(6, 227)
        Address_Of_CenterLabel.Name = "Address_Of_CenterLabel"
        Address_Of_CenterLabel.Size = New System.Drawing.Size(235, 29)
        Address_Of_CenterLabel.TabIndex = 11
        Address_Of_CenterLabel.Text = "Address Of Center:"
        '
        'Medical_ReferenceLabel
        '
        Medical_ReferenceLabel.AutoSize = True
        Medical_ReferenceLabel.Location = New System.Drawing.Point(6, 267)
        Medical_ReferenceLabel.Name = "Medical_ReferenceLabel"
        Medical_ReferenceLabel.Size = New System.Drawing.Size(240, 29)
        Medical_ReferenceLabel.TabIndex = 13
        Medical_ReferenceLabel.Text = "Medical Reference:"
        '
        'Office_Number1Label
        '
        Office_Number1Label.AutoSize = True
        Office_Number1Label.Location = New System.Drawing.Point(698, 29)
        Office_Number1Label.Name = "Office_Number1Label"
        Office_Number1Label.Size = New System.Drawing.Size(203, 29)
        Office_Number1Label.TabIndex = 15
        Office_Number1Label.Text = "Office Number1:"
        '
        'Office_Number2Label
        '
        Office_Number2Label.AutoSize = True
        Office_Number2Label.Location = New System.Drawing.Point(698, 69)
        Office_Number2Label.Name = "Office_Number2Label"
        Office_Number2Label.Size = New System.Drawing.Size(203, 29)
        Office_Number2Label.TabIndex = 17
        Office_Number2Label.Text = "Office Number2:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(698, 109)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(189, 29)
        EmailAddressLabel.TabIndex = 19
        EmailAddressLabel.Text = "Email Address:"
        '
        'Nurse_ReferenceLabel
        '
        Nurse_ReferenceLabel.AutoSize = True
        Nurse_ReferenceLabel.Location = New System.Drawing.Point(29, 217)
        Nurse_ReferenceLabel.Name = "Nurse_ReferenceLabel"
        Nurse_ReferenceLabel.Size = New System.Drawing.Size(218, 29)
        Nurse_ReferenceLabel.TabIndex = 1
        Nurse_ReferenceLabel.Text = "Nurse Reference:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Location = New System.Drawing.Point(29, 257)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(148, 29)
        FirstNameLabel1.TabIndex = 3
        FirstNameLabel1.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(29, 297)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(144, 29)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'MODLabel
        '
        MODLabel.AutoSize = True
        MODLabel.Location = New System.Drawing.Point(29, 337)
        MODLabel.Name = "MODLabel"
        MODLabel.Size = New System.Drawing.Size(79, 29)
        MODLabel.TabIndex = 7
        MODLabel.Text = "MOD:"
        '
        'Tablet_NameLabel
        '
        Tablet_NameLabel.AutoSize = True
        Tablet_NameLabel.Location = New System.Drawing.Point(12, 140)
        Tablet_NameLabel.Name = "Tablet_NameLabel"
        Tablet_NameLabel.Size = New System.Drawing.Size(171, 29)
        Tablet_NameLabel.TabIndex = 1
        Tablet_NameLabel.Text = "Tablet Name:"
        '
        'Dosage_mgLabel
        '
        Dosage_mgLabel.AutoSize = True
        Dosage_mgLabel.Location = New System.Drawing.Point(12, 180)
        Dosage_mgLabel.Name = "Dosage_mgLabel"
        Dosage_mgLabel.Size = New System.Drawing.Size(153, 29)
        Dosage_mgLabel.TabIndex = 3
        Dosage_mgLabel.Text = "Dosage mg:"
        '
        'Number_Of_TabletsLabel
        '
        Number_Of_TabletsLabel.AutoSize = True
        Number_Of_TabletsLabel.Location = New System.Drawing.Point(12, 220)
        Number_Of_TabletsLabel.Name = "Number_Of_TabletsLabel"
        Number_Of_TabletsLabel.Size = New System.Drawing.Size(242, 29)
        Number_Of_TabletsLabel.TabIndex = 5
        Number_Of_TabletsLabel.Text = "Number Of Tablets:"
        '
        'Issued_DateLabel
        '
        Issued_DateLabel.AutoSize = True
        Issued_DateLabel.Location = New System.Drawing.Point(12, 261)
        Issued_DateLabel.Name = "Issued_DateLabel"
        Issued_DateLabel.Size = New System.Drawing.Size(158, 29)
        Issued_DateLabel.TabIndex = 7
        Issued_DateLabel.Text = "Issued Date:"
        '
        'Expire_DateLabel
        '
        Expire_DateLabel.AutoSize = True
        Expire_DateLabel.Location = New System.Drawing.Point(12, 301)
        Expire_DateLabel.Name = "Expire_DateLabel"
        Expire_DateLabel.Size = New System.Drawing.Size(156, 29)
        Expire_DateLabel.TabIndex = 9
        Expire_DateLabel.Text = "Expire Date:"
        '
        'Daily_DosageLabel
        '
        Daily_DosageLabel.AutoSize = True
        Daily_DosageLabel.Location = New System.Drawing.Point(12, 340)
        Daily_DosageLabel.Name = "Daily_DosageLabel"
        Daily_DosageLabel.Size = New System.Drawing.Size(175, 29)
        Daily_DosageLabel.TabIndex = 11
        Daily_DosageLabel.Text = "Daily Dosage:"
        '
        'Possible_Side_EffectLabel
        '
        Possible_Side_EffectLabel.AutoSize = True
        Possible_Side_EffectLabel.Location = New System.Drawing.Point(12, 380)
        Possible_Side_EffectLabel.Name = "Possible_Side_EffectLabel"
        Possible_Side_EffectLabel.Size = New System.Drawing.Size(256, 29)
        Possible_Side_EffectLabel.TabIndex = 13
        Possible_Side_EffectLabel.Text = "Possible Side Effect:"
        '
        'Possible_InformationLabel
        '
        Possible_InformationLabel.AutoSize = True
        Possible_InformationLabel.Location = New System.Drawing.Point(12, 422)
        Possible_InformationLabel.Name = "Possible_InformationLabel"
        Possible_InformationLabel.Size = New System.Drawing.Size(259, 29)
        Possible_InformationLabel.TabIndex = 15
        Possible_InformationLabel.Text = "Possible Information:"
        '
        'Storage_AreaLabel
        '
        Storage_AreaLabel.AutoSize = True
        Storage_AreaLabel.Location = New System.Drawing.Point(12, 462)
        Storage_AreaLabel.Name = "Storage_AreaLabel"
        Storage_AreaLabel.Size = New System.Drawing.Size(173, 29)
        Storage_AreaLabel.TabIndex = 17
        Storage_AreaLabel.Text = "Storage Area:"
        '
        'AdministrationLabel
        '
        AdministrationLabel.AutoSize = True
        AdministrationLabel.Location = New System.Drawing.Point(12, 502)
        AdministrationLabel.Name = "AdministrationLabel"
        AdministrationLabel.Size = New System.Drawing.Size(186, 29)
        AdministrationLabel.TabIndex = 19
        AdministrationLabel.Text = "Administration:"
        '
        'Driving_and_using_MachinesLabel
        '
        Driving_and_using_MachinesLabel.AutoSize = True
        Driving_and_using_MachinesLabel.Location = New System.Drawing.Point(12, 542)
        Driving_and_using_MachinesLabel.Name = "Driving_and_using_MachinesLabel"
        Driving_and_using_MachinesLabel.Size = New System.Drawing.Size(340, 29)
        Driving_and_using_MachinesLabel.TabIndex = 21
        Driving_and_using_MachinesLabel.Text = "Driving and using Machines:"
        '
        'ReferenceNumberLabel
        '
        ReferenceNumberLabel.AutoSize = True
        ReferenceNumberLabel.Location = New System.Drawing.Point(16, 18)
        ReferenceNumberLabel.Name = "ReferenceNumberLabel"
        ReferenceNumberLabel.Size = New System.Drawing.Size(241, 29)
        ReferenceNumberLabel.TabIndex = 0
        ReferenceNumberLabel.Text = "Reference Number:"
        '
        'FirstNameLabel2
        '
        FirstNameLabel2.AutoSize = True
        FirstNameLabel2.Location = New System.Drawing.Point(16, 58)
        FirstNameLabel2.Name = "FirstNameLabel2"
        FirstNameLabel2.Size = New System.Drawing.Size(148, 29)
        FirstNameLabel2.TabIndex = 2
        FirstNameLabel2.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(16, 98)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(176, 29)
        MiddleNameLabel.TabIndex = 4
        MiddleNameLabel.Text = "Middle Name:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = True
        LastNameLabel1.Location = New System.Drawing.Point(16, 138)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(144, 29)
        LastNameLabel1.TabIndex = 6
        LastNameLabel1.Text = "Last Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(16, 179)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(169, 29)
        DateOfBirthLabel.TabIndex = 8
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(16, 218)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(66, 29)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(16, 258)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(152, 29)
        OccupationLabel.TabIndex = 12
        OccupationLabel.Text = "Occupation:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(16, 298)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(178, 29)
        MaritalStatusLabel.TabIndex = 14
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'NextOfKinLabel
        '
        NextOfKinLabel.AutoSize = True
        NextOfKinLabel.Location = New System.Drawing.Point(16, 338)
        NextOfKinLabel.Name = "NextOfKinLabel"
        NextOfKinLabel.Size = New System.Drawing.Size(152, 29)
        NextOfKinLabel.TabIndex = 16
        NextOfKinLabel.Text = "Next Of Kin:"
        '
        'HouseAddressLabel
        '
        HouseAddressLabel.AutoSize = True
        HouseAddressLabel.Location = New System.Drawing.Point(16, 378)
        HouseAddressLabel.Name = "HouseAddressLabel"
        HouseAddressLabel.Size = New System.Drawing.Size(198, 29)
        HouseAddressLabel.TabIndex = 18
        HouseAddressLabel.Text = "House Address:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(16, 418)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(119, 29)
        LocationLabel.TabIndex = 20
        LocationLabel.Text = "Location:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(16, 458)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(195, 29)
        PhoneNumberLabel.TabIndex = 22
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'TimeOfAdmissionLabel
        '
        TimeOfAdmissionLabel.AutoSize = True
        TimeOfAdmissionLabel.Location = New System.Drawing.Point(16, 498)
        TimeOfAdmissionLabel.Name = "TimeOfAdmissionLabel"
        TimeOfAdmissionLabel.Size = New System.Drawing.Size(242, 29)
        TimeOfAdmissionLabel.TabIndex = 24
        TimeOfAdmissionLabel.Text = "Time Of Admission:"
        '
        'TimeOfDischargeLabel
        '
        TimeOfDischargeLabel.AutoSize = True
        TimeOfDischargeLabel.Location = New System.Drawing.Point(16, 538)
        TimeOfDischargeLabel.Name = "TimeOfDischargeLabel"
        TimeOfDischargeLabel.Size = New System.Drawing.Size(239, 29)
        TimeOfDischargeLabel.TabIndex = 26
        TimeOfDischargeLabel.Text = "Time Of Discharge:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(968, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INNORIK HOSPITAL MANAGEMENT SYSTEM"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDoctor)
        Me.TabControl1.Controls.Add(Me.tabNurse)
        Me.TabControl1.Controls.Add(Me.tabPrescription)
        Me.TabControl1.Controls.Add(Me.tabPatient)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(327, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1093, 821)
        Me.TabControl1.TabIndex = 1
        '
        'tabDoctor
        '
        Me.tabDoctor.AutoScroll = True
        Me.tabDoctor.Controls.Add(Me.btnAdd)
        Me.tabDoctor.Controls.Add(Me.btnExit)
        Me.tabDoctor.Controls.Add(Me.btnUpdate)
        Me.tabDoctor.Controls.Add(Me.btnDelete)
        Me.tabDoctor.Controls.Add(Me.btnMoveLast)
        Me.tabDoctor.Controls.Add(Me.btnMoveNext)
        Me.tabDoctor.Controls.Add(Me.btnPrevious)
        Me.tabDoctor.Controls.Add(Me.btnMoveFirst)
        Me.tabDoctor.Controls.Add(Me.FilterDoc)
        Me.tabDoctor.Controls.Add(Doctor_Ref_NoLabel)
        Me.tabDoctor.Controls.Add(Me.Doctor_Ref_NoTextBox)
        Me.tabDoctor.Controls.Add(Doctor_NHS_NoLabel)
        Me.tabDoctor.Controls.Add(Me.Doctor_NHS_NoTextBox)
        Me.tabDoctor.Controls.Add(FirstNameLabel)
        Me.tabDoctor.Controls.Add(Me.FirstNameTextBox)
        Me.tabDoctor.Controls.Add(SurnameLabel)
        Me.tabDoctor.Controls.Add(Me.SurnameTextBox)
        Me.tabDoctor.Controls.Add(Medical_CenterLabel)
        Me.tabDoctor.Controls.Add(Me.Medical_CenterTextBox)
        Me.tabDoctor.Controls.Add(Address_Of_CenterLabel)
        Me.tabDoctor.Controls.Add(Me.Address_Of_CenterTextBox)
        Me.tabDoctor.Controls.Add(Medical_ReferenceLabel)
        Me.tabDoctor.Controls.Add(Me.Medical_ReferenceTextBox)
        Me.tabDoctor.Controls.Add(Office_Number1Label)
        Me.tabDoctor.Controls.Add(Me.Office_Number1TextBox)
        Me.tabDoctor.Controls.Add(Office_Number2Label)
        Me.tabDoctor.Controls.Add(Me.Office_Number2TextBox)
        Me.tabDoctor.Controls.Add(EmailAddressLabel)
        Me.tabDoctor.Controls.Add(Me.EmailAddressTextBox)
        Me.tabDoctor.Controls.Add(Me.DoctorDataGridView)
        Me.tabDoctor.Location = New System.Drawing.Point(4, 38)
        Me.tabDoctor.Name = "tabDoctor"
        Me.tabDoctor.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDoctor.Size = New System.Drawing.Size(1085, 779)
        Me.tabDoctor.TabIndex = 0
        Me.tabDoctor.Text = "Doctor"
        Me.tabDoctor.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(929, 701)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 47)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1141, 701)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 47)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(643, 701)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(127, 47)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(787, 701)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(127, 47)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(194, 701)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(143, 47)
        Me.btnMoveLast.TabIndex = 26
        Me.btnMoveLast.Text = "Move Last"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(353, 701)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(127, 47)
        Me.btnMoveNext.TabIndex = 25
        Me.btnMoveNext.Text = "Next"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(496, 701)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(127, 47)
        Me.btnPrevious.TabIndex = 24
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(11, 701)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(163, 47)
        Me.btnMoveFirst.TabIndex = 23
        Me.btnMoveFirst.Text = "Move First"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'FilterDoc
        '
        Me.FilterDoc.Controls.Add(Me.btnSearchDoc)
        Me.FilterDoc.Controls.Add(Me.cmbSearchDoc)
        Me.FilterDoc.Controls.Add(Me.txtSearchDoc)
        Me.FilterDoc.Location = New System.Drawing.Point(618, 184)
        Me.FilterDoc.Name = "FilterDoc"
        Me.FilterDoc.Size = New System.Drawing.Size(650, 100)
        Me.FilterDoc.TabIndex = 22
        Me.FilterDoc.TabStop = False
        Me.FilterDoc.Text = "Filter"
        '
        'btnSearchDoc
        '
        Me.btnSearchDoc.Location = New System.Drawing.Point(497, 43)
        Me.btnSearchDoc.Name = "btnSearchDoc"
        Me.btnSearchDoc.Size = New System.Drawing.Size(133, 37)
        Me.btnSearchDoc.TabIndex = 23
        Me.btnSearchDoc.Text = "Search"
        Me.btnSearchDoc.UseVisualStyleBackColor = True
        '
        'cmbSearchDoc
        '
        Me.cmbSearchDoc.FormattingEnabled = True
        Me.cmbSearchDoc.Location = New System.Drawing.Point(226, 43)
        Me.cmbSearchDoc.Name = "cmbSearchDoc"
        Me.cmbSearchDoc.Size = New System.Drawing.Size(236, 37)
        Me.cmbSearchDoc.TabIndex = 22
        '
        'txtSearchDoc
        '
        Me.txtSearchDoc.Location = New System.Drawing.Point(6, 43)
        Me.txtSearchDoc.Name = "txtSearchDoc"
        Me.txtSearchDoc.Size = New System.Drawing.Size(214, 34)
        Me.txtSearchDoc.TabIndex = 21
        '
        'Doctor_Ref_NoTextBox
        '
        Me.Doctor_Ref_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Doctor_Ref_No", True))
        Me.Doctor_Ref_NoTextBox.Location = New System.Drawing.Point(252, 24)
        Me.Doctor_Ref_NoTextBox.Name = "Doctor_Ref_NoTextBox"
        Me.Doctor_Ref_NoTextBox.Size = New System.Drawing.Size(327, 34)
        Me.Doctor_Ref_NoTextBox.TabIndex = 2
        '
        'DoctorBindingSource
        '
        Me.DoctorBindingSource.DataMember = "Doctor"
        Me.DoctorBindingSource.DataSource = Me.INNOHOSPITALDataSet1
        '
        'INNOHOSPITALDataSet1
        '
        Me.INNOHOSPITALDataSet1.DataSetName = "INNOHOSPITALDataSet1"
        Me.INNOHOSPITALDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Doctor_NHS_NoTextBox
        '
        Me.Doctor_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Doctor_NHS_No", True))
        Me.Doctor_NHS_NoTextBox.Location = New System.Drawing.Point(252, 64)
        Me.Doctor_NHS_NoTextBox.Name = "Doctor_NHS_NoTextBox"
        Me.Doctor_NHS_NoTextBox.Size = New System.Drawing.Size(327, 34)
        Me.Doctor_NHS_NoTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(252, 104)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(327, 34)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(252, 144)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(327, 34)
        Me.SurnameTextBox.TabIndex = 8
        '
        'Medical_CenterTextBox
        '
        Me.Medical_CenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Medical_Center", True))
        Me.Medical_CenterTextBox.Location = New System.Drawing.Point(252, 184)
        Me.Medical_CenterTextBox.Name = "Medical_CenterTextBox"
        Me.Medical_CenterTextBox.Size = New System.Drawing.Size(327, 34)
        Me.Medical_CenterTextBox.TabIndex = 10
        '
        'Address_Of_CenterTextBox
        '
        Me.Address_Of_CenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Address_Of_Center", True))
        Me.Address_Of_CenterTextBox.Location = New System.Drawing.Point(252, 224)
        Me.Address_Of_CenterTextBox.Name = "Address_Of_CenterTextBox"
        Me.Address_Of_CenterTextBox.Size = New System.Drawing.Size(327, 34)
        Me.Address_Of_CenterTextBox.TabIndex = 12
        '
        'Medical_ReferenceTextBox
        '
        Me.Medical_ReferenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Medical_Reference", True))
        Me.Medical_ReferenceTextBox.Location = New System.Drawing.Point(252, 264)
        Me.Medical_ReferenceTextBox.Name = "Medical_ReferenceTextBox"
        Me.Medical_ReferenceTextBox.Size = New System.Drawing.Size(327, 34)
        Me.Medical_ReferenceTextBox.TabIndex = 14
        '
        'Office_Number1TextBox
        '
        Me.Office_Number1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Office_Number1", True))
        Me.Office_Number1TextBox.Location = New System.Drawing.Point(944, 26)
        Me.Office_Number1TextBox.Name = "Office_Number1TextBox"
        Me.Office_Number1TextBox.Size = New System.Drawing.Size(282, 34)
        Me.Office_Number1TextBox.TabIndex = 16
        '
        'Office_Number2TextBox
        '
        Me.Office_Number2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "Office_Number2", True))
        Me.Office_Number2TextBox.Location = New System.Drawing.Point(944, 66)
        Me.Office_Number2TextBox.Name = "Office_Number2TextBox"
        Me.Office_Number2TextBox.Size = New System.Drawing.Size(282, 34)
        Me.Office_Number2TextBox.TabIndex = 18
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(944, 106)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(282, 34)
        Me.EmailAddressTextBox.TabIndex = 20
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AutoGenerateColumns = False
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DoctorDataGridView.DataSource = Me.DoctorBindingSource
        Me.DoctorDataGridView.Location = New System.Drawing.Point(6, 304)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.RowHeadersWidth = 51
        Me.DoctorDataGridView.RowTemplate.Height = 24
        Me.DoctorDataGridView.Size = New System.Drawing.Size(1262, 359)
        Me.DoctorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doctor_Ref_No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Doctor_Ref_No"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doctor_NHS_No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doctor_NHS_No"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Medical_Center"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Medical_Center"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address_Of_Center"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address_Of_Center"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Medical_Reference"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Medical_Reference"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Office_Number1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Office_Number1"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Office_Number2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Office_Number2"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EmailAddress"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EmailAddress"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'tabNurse
        '
        Me.tabNurse.Controls.Add(Me.GroupBox3)
        Me.tabNurse.Controls.Add(Me.Label3)
        Me.tabNurse.Controls.Add(Me.Label2)
        Me.tabNurse.Controls.Add(Nurse_ReferenceLabel)
        Me.tabNurse.Controls.Add(Me.Nurse_ReferenceTextBox)
        Me.tabNurse.Controls.Add(FirstNameLabel1)
        Me.tabNurse.Controls.Add(Me.FirstNameTextBox1)
        Me.tabNurse.Controls.Add(LastNameLabel)
        Me.tabNurse.Controls.Add(Me.LastNameTextBox)
        Me.tabNurse.Controls.Add(MODLabel)
        Me.tabNurse.Controls.Add(Me.MODTextBox)
        Me.tabNurse.Controls.Add(Me.NurseDataGridView)
        Me.tabNurse.Location = New System.Drawing.Point(4, 38)
        Me.tabNurse.Name = "tabNurse"
        Me.tabNurse.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNurse.Size = New System.Drawing.Size(1085, 779)
        Me.tabNurse.TabIndex = 1
        Me.tabNurse.Text = "Nurse"
        Me.tabNurse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(899, 46)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "INNORIK HOSPITAL MANAGEMENT SYSTEM"
        '
        'Nurse_ReferenceTextBox
        '
        Me.Nurse_ReferenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "Nurse_Reference", True))
        Me.Nurse_ReferenceTextBox.Location = New System.Drawing.Point(253, 214)
        Me.Nurse_ReferenceTextBox.Name = "Nurse_ReferenceTextBox"
        Me.Nurse_ReferenceTextBox.Size = New System.Drawing.Size(312, 34)
        Me.Nurse_ReferenceTextBox.TabIndex = 2
        '
        'NurseBindingSource
        '
        Me.NurseBindingSource.DataMember = "Nurse"
        Me.NurseBindingSource.DataSource = Me.INNOHOSPITALDataSet1
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "FirstName", True))
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(253, 254)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(312, 34)
        Me.FirstNameTextBox1.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(253, 294)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(312, 34)
        Me.LastNameTextBox.TabIndex = 6
        '
        'MODTextBox
        '
        Me.MODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NurseBindingSource, "MOD", True))
        Me.MODTextBox.Location = New System.Drawing.Point(253, 334)
        Me.MODTextBox.Name = "MODTextBox"
        Me.MODTextBox.Size = New System.Drawing.Size(312, 34)
        Me.MODTextBox.TabIndex = 8
        '
        'NurseDataGridView
        '
        Me.NurseDataGridView.AutoGenerateColumns = False
        Me.NurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NurseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.NurseDataGridView.DataSource = Me.NurseBindingSource
        Me.NurseDataGridView.Location = New System.Drawing.Point(6, 389)
        Me.NurseDataGridView.Name = "NurseDataGridView"
        Me.NurseDataGridView.RowHeadersWidth = 51
        Me.NurseDataGridView.RowTemplate.Height = 24
        Me.NurseDataGridView.Size = New System.Drawing.Size(559, 193)
        Me.NurseDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nurse_Reference"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nurse_Reference"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MOD"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MOD"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'tabPrescription
        '
        Me.tabPrescription.AutoScroll = True
        Me.tabPrescription.Controls.Add(Me.GroupBox1)
        Me.tabPrescription.Controls.Add(Tablet_NameLabel)
        Me.tabPrescription.Controls.Add(Me.Tablet_NameTextBox)
        Me.tabPrescription.Controls.Add(Dosage_mgLabel)
        Me.tabPrescription.Controls.Add(Me.Dosage_mgTextBox)
        Me.tabPrescription.Controls.Add(Number_Of_TabletsLabel)
        Me.tabPrescription.Controls.Add(Me.Number_Of_TabletsTextBox)
        Me.tabPrescription.Controls.Add(Issued_DateLabel)
        Me.tabPrescription.Controls.Add(Me.Issued_DateDateTimePicker)
        Me.tabPrescription.Controls.Add(Expire_DateLabel)
        Me.tabPrescription.Controls.Add(Me.Expire_DateDateTimePicker)
        Me.tabPrescription.Controls.Add(Daily_DosageLabel)
        Me.tabPrescription.Controls.Add(Me.Daily_DosageTextBox)
        Me.tabPrescription.Controls.Add(Possible_Side_EffectLabel)
        Me.tabPrescription.Controls.Add(Me.Possible_Side_EffectTextBox)
        Me.tabPrescription.Controls.Add(Possible_InformationLabel)
        Me.tabPrescription.Controls.Add(Me.Possible_InformationTextBox)
        Me.tabPrescription.Controls.Add(Storage_AreaLabel)
        Me.tabPrescription.Controls.Add(Me.Storage_AreaTextBox)
        Me.tabPrescription.Controls.Add(AdministrationLabel)
        Me.tabPrescription.Controls.Add(Me.AdministrationTextBox)
        Me.tabPrescription.Controls.Add(Driving_and_using_MachinesLabel)
        Me.tabPrescription.Controls.Add(Me.Driving_and_using_MachinesTextBox)
        Me.tabPrescription.Controls.Add(Me.PrescriptionDataGridView)
        Me.tabPrescription.Location = New System.Drawing.Point(4, 38)
        Me.tabPrescription.Name = "tabPrescription"
        Me.tabPrescription.Size = New System.Drawing.Size(1085, 779)
        Me.tabPrescription.TabIndex = 2
        Me.tabPrescription.Text = "Prescription"
        Me.tabPrescription.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDeletePrescri)
        Me.GroupBox1.Controls.Add(Me.btnInsertPrescri)
        Me.GroupBox1.Controls.Add(Me.btnUpdatePrescri)
        Me.GroupBox1.Controls.Add(Me.brnViewPrescri)
        Me.GroupBox1.Location = New System.Drawing.Point(858, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 440)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operations"
        '
        'Tablet_NameTextBox
        '
        Me.Tablet_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Tablet_Name", True))
        Me.Tablet_NameTextBox.Location = New System.Drawing.Point(358, 137)
        Me.Tablet_NameTextBox.Name = "Tablet_NameTextBox"
        Me.Tablet_NameTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Tablet_NameTextBox.TabIndex = 2
        '
        'PrescriptionBindingSource
        '
        Me.PrescriptionBindingSource.DataMember = "Prescription"
        Me.PrescriptionBindingSource.DataSource = Me.INNOHOSPITALDataSet1
        '
        'Dosage_mgTextBox
        '
        Me.Dosage_mgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Dosage_mg", True))
        Me.Dosage_mgTextBox.Location = New System.Drawing.Point(358, 177)
        Me.Dosage_mgTextBox.Name = "Dosage_mgTextBox"
        Me.Dosage_mgTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Dosage_mgTextBox.TabIndex = 4
        '
        'Number_Of_TabletsTextBox
        '
        Me.Number_Of_TabletsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Number_Of_Tablets", True))
        Me.Number_Of_TabletsTextBox.Location = New System.Drawing.Point(358, 217)
        Me.Number_Of_TabletsTextBox.Name = "Number_Of_TabletsTextBox"
        Me.Number_Of_TabletsTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Number_Of_TabletsTextBox.TabIndex = 6
        '
        'Issued_DateDateTimePicker
        '
        Me.Issued_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrescriptionBindingSource, "Issued_Date", True))
        Me.Issued_DateDateTimePicker.Location = New System.Drawing.Point(358, 257)
        Me.Issued_DateDateTimePicker.Name = "Issued_DateDateTimePicker"
        Me.Issued_DateDateTimePicker.Size = New System.Drawing.Size(407, 34)
        Me.Issued_DateDateTimePicker.TabIndex = 8
        '
        'Expire_DateDateTimePicker
        '
        Me.Expire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PrescriptionBindingSource, "Expire_Date", True))
        Me.Expire_DateDateTimePicker.Location = New System.Drawing.Point(358, 297)
        Me.Expire_DateDateTimePicker.Name = "Expire_DateDateTimePicker"
        Me.Expire_DateDateTimePicker.Size = New System.Drawing.Size(407, 34)
        Me.Expire_DateDateTimePicker.TabIndex = 10
        '
        'Daily_DosageTextBox
        '
        Me.Daily_DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Daily_Dosage", True))
        Me.Daily_DosageTextBox.Location = New System.Drawing.Point(358, 337)
        Me.Daily_DosageTextBox.Name = "Daily_DosageTextBox"
        Me.Daily_DosageTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Daily_DosageTextBox.TabIndex = 12
        '
        'Possible_Side_EffectTextBox
        '
        Me.Possible_Side_EffectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Possible_Side_Effect", True))
        Me.Possible_Side_EffectTextBox.Location = New System.Drawing.Point(358, 377)
        Me.Possible_Side_EffectTextBox.Name = "Possible_Side_EffectTextBox"
        Me.Possible_Side_EffectTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Possible_Side_EffectTextBox.TabIndex = 14
        '
        'Possible_InformationTextBox
        '
        Me.Possible_InformationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Possible_Information", True))
        Me.Possible_InformationTextBox.Location = New System.Drawing.Point(358, 419)
        Me.Possible_InformationTextBox.Name = "Possible_InformationTextBox"
        Me.Possible_InformationTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Possible_InformationTextBox.TabIndex = 16
        '
        'Storage_AreaTextBox
        '
        Me.Storage_AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Storage_Area", True))
        Me.Storage_AreaTextBox.Location = New System.Drawing.Point(358, 459)
        Me.Storage_AreaTextBox.Name = "Storage_AreaTextBox"
        Me.Storage_AreaTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Storage_AreaTextBox.TabIndex = 18
        '
        'AdministrationTextBox
        '
        Me.AdministrationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Administration", True))
        Me.AdministrationTextBox.Location = New System.Drawing.Point(358, 499)
        Me.AdministrationTextBox.Name = "AdministrationTextBox"
        Me.AdministrationTextBox.Size = New System.Drawing.Size(407, 34)
        Me.AdministrationTextBox.TabIndex = 20
        '
        'Driving_and_using_MachinesTextBox
        '
        Me.Driving_and_using_MachinesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PrescriptionBindingSource, "Driving_and_using_Machines", True))
        Me.Driving_and_using_MachinesTextBox.Location = New System.Drawing.Point(358, 539)
        Me.Driving_and_using_MachinesTextBox.Name = "Driving_and_using_MachinesTextBox"
        Me.Driving_and_using_MachinesTextBox.Size = New System.Drawing.Size(407, 34)
        Me.Driving_and_using_MachinesTextBox.TabIndex = 22
        '
        'PrescriptionDataGridView
        '
        Me.PrescriptionDataGridView.AutoGenerateColumns = False
        Me.PrescriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrescriptionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.PrescriptionDataGridView.DataSource = Me.PrescriptionBindingSource
        Me.PrescriptionDataGridView.Location = New System.Drawing.Point(17, 585)
        Me.PrescriptionDataGridView.Name = "PrescriptionDataGridView"
        Me.PrescriptionDataGridView.RowHeadersWidth = 51
        Me.PrescriptionDataGridView.RowTemplate.Height = 24
        Me.PrescriptionDataGridView.Size = New System.Drawing.Size(1054, 189)
        Me.PrescriptionDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tablet_Name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tablet_Name"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 125
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Dosage_mg"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Dosage_mg"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 125
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Number_Of_Tablets"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Number_Of_Tablets"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 125
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Issued_Date"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Issued_Date"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 125
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Expire_Date"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Expire_Date"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 125
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Daily_Dosage"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Daily_Dosage"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 125
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Possible_Side_Effect"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Possible_Side_Effect"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 125
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Possible_Information"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Possible_Information"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 125
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Storage_Area"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Storage_Area"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 125
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Administration"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Administration"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 125
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Driving_and_using_Machines"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Driving_and_using_Machines"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 125
        '
        'tabPatient
        '
        Me.tabPatient.Controls.Add(Me.GroupBox2)
        Me.tabPatient.Controls.Add(Me.Patient_RecordsDataGridView)
        Me.tabPatient.Controls.Add(ReferenceNumberLabel)
        Me.tabPatient.Controls.Add(Me.ReferenceNumberTextBox)
        Me.tabPatient.Controls.Add(FirstNameLabel2)
        Me.tabPatient.Controls.Add(Me.FirstNameTextBox2)
        Me.tabPatient.Controls.Add(MiddleNameLabel)
        Me.tabPatient.Controls.Add(Me.MiddleNameTextBox)
        Me.tabPatient.Controls.Add(LastNameLabel1)
        Me.tabPatient.Controls.Add(Me.LastNameTextBox1)
        Me.tabPatient.Controls.Add(DateOfBirthLabel)
        Me.tabPatient.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.tabPatient.Controls.Add(AgeLabel)
        Me.tabPatient.Controls.Add(Me.AgeTextBox)
        Me.tabPatient.Controls.Add(OccupationLabel)
        Me.tabPatient.Controls.Add(Me.OccupationTextBox)
        Me.tabPatient.Controls.Add(MaritalStatusLabel)
        Me.tabPatient.Controls.Add(Me.MaritalStatusTextBox)
        Me.tabPatient.Controls.Add(NextOfKinLabel)
        Me.tabPatient.Controls.Add(Me.NextOfKinTextBox)
        Me.tabPatient.Controls.Add(HouseAddressLabel)
        Me.tabPatient.Controls.Add(Me.HouseAddressTextBox)
        Me.tabPatient.Controls.Add(LocationLabel)
        Me.tabPatient.Controls.Add(Me.LocationTextBox)
        Me.tabPatient.Controls.Add(PhoneNumberLabel)
        Me.tabPatient.Controls.Add(Me.PhoneNumberTextBox)
        Me.tabPatient.Controls.Add(TimeOfAdmissionLabel)
        Me.tabPatient.Controls.Add(Me.TimeOfAdmissionTextBox)
        Me.tabPatient.Controls.Add(TimeOfDischargeLabel)
        Me.tabPatient.Controls.Add(Me.TimeOfDischargeTextBox)
        Me.tabPatient.Location = New System.Drawing.Point(4, 38)
        Me.tabPatient.Name = "tabPatient"
        Me.tabPatient.Size = New System.Drawing.Size(1085, 779)
        Me.tabPatient.TabIndex = 3
        Me.tabPatient.Text = "Patient"
        Me.tabPatient.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewPatient)
        Me.GroupBox2.Controls.Add(Me.btnDeletePatient)
        Me.GroupBox2.Controls.Add(Me.btnInsertPatient)
        Me.GroupBox2.Controls.Add(Me.btnUpdatePatient)
        Me.GroupBox2.Location = New System.Drawing.Point(681, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(311, 395)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commands"
        '
        'btnViewPatient
        '
        Me.btnViewPatient.Location = New System.Drawing.Point(88, 309)
        Me.btnViewPatient.Name = "btnViewPatient"
        Me.btnViewPatient.Size = New System.Drawing.Size(112, 43)
        Me.btnViewPatient.TabIndex = 3
        Me.btnViewPatient.Text = "View"
        Me.btnViewPatient.UseVisualStyleBackColor = True
        '
        'btnDeletePatient
        '
        Me.btnDeletePatient.Location = New System.Drawing.Point(88, 212)
        Me.btnDeletePatient.Name = "btnDeletePatient"
        Me.btnDeletePatient.Size = New System.Drawing.Size(112, 40)
        Me.btnDeletePatient.TabIndex = 2
        Me.btnDeletePatient.Text = "Delete"
        Me.btnDeletePatient.UseVisualStyleBackColor = True
        '
        'btnInsertPatient
        '
        Me.btnInsertPatient.Location = New System.Drawing.Point(88, 127)
        Me.btnInsertPatient.Name = "btnInsertPatient"
        Me.btnInsertPatient.Size = New System.Drawing.Size(112, 40)
        Me.btnInsertPatient.TabIndex = 1
        Me.btnInsertPatient.Text = "Insert"
        Me.btnInsertPatient.UseVisualStyleBackColor = True
        '
        'btnUpdatePatient
        '
        Me.btnUpdatePatient.Location = New System.Drawing.Point(88, 47)
        Me.btnUpdatePatient.Name = "btnUpdatePatient"
        Me.btnUpdatePatient.Size = New System.Drawing.Size(112, 40)
        Me.btnUpdatePatient.TabIndex = 0
        Me.btnUpdatePatient.Text = "Update"
        Me.btnUpdatePatient.UseVisualStyleBackColor = True
        '
        'Patient_RecordsDataGridView
        '
        Me.Patient_RecordsDataGridView.AutoGenerateColumns = False
        Me.Patient_RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patient_RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39})
        Me.Patient_RecordsDataGridView.DataSource = Me.Patient_RecordsBindingSource
        Me.Patient_RecordsDataGridView.Location = New System.Drawing.Point(3, 575)
        Me.Patient_RecordsDataGridView.Name = "Patient_RecordsDataGridView"
        Me.Patient_RecordsDataGridView.RowHeadersWidth = 51
        Me.Patient_RecordsDataGridView.RowTemplate.Height = 24
        Me.Patient_RecordsDataGridView.Size = New System.Drawing.Size(1079, 194)
        Me.Patient_RecordsDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ReferenceNumber"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ReferenceNumber"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 125
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn27.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 125
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn28.HeaderText = "MiddleName"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 125
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn29.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 125
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn30.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 125
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 125
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Occupation"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 125
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "MaritalStatus"
        Me.DataGridViewTextBoxColumn33.HeaderText = "MaritalStatus"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 125
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "NextOfKin"
        Me.DataGridViewTextBoxColumn34.HeaderText = "NextOfKin"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 125
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "HouseAddress"
        Me.DataGridViewTextBoxColumn35.HeaderText = "HouseAddress"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 125
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 125
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn37.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 125
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "TimeOfAdmission"
        Me.DataGridViewTextBoxColumn38.HeaderText = "TimeOfAdmission"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 125
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TimeOfDischarge"
        Me.DataGridViewTextBoxColumn39.HeaderText = "TimeOfDischarge"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 125
        '
        'Patient_RecordsBindingSource
        '
        Me.Patient_RecordsBindingSource.DataMember = "Patient_Records"
        Me.Patient_RecordsBindingSource.DataSource = Me.INNOHOSPITALDataSet1
        '
        'ReferenceNumberTextBox
        '
        Me.ReferenceNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "ReferenceNumber", True))
        Me.ReferenceNumberTextBox.Location = New System.Drawing.Point(264, 15)
        Me.ReferenceNumberTextBox.Name = "ReferenceNumberTextBox"
        Me.ReferenceNumberTextBox.Size = New System.Drawing.Size(353, 34)
        Me.ReferenceNumberTextBox.TabIndex = 1
        '
        'FirstNameTextBox2
        '
        Me.FirstNameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "FirstName", True))
        Me.FirstNameTextBox2.Location = New System.Drawing.Point(264, 55)
        Me.FirstNameTextBox2.Name = "FirstNameTextBox2"
        Me.FirstNameTextBox2.Size = New System.Drawing.Size(353, 34)
        Me.FirstNameTextBox2.TabIndex = 3
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(264, 95)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(353, 34)
        Me.MiddleNameTextBox.TabIndex = 5
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "LastName", True))
        Me.LastNameTextBox1.Location = New System.Drawing.Point(264, 135)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(353, 34)
        Me.LastNameTextBox1.TabIndex = 7
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_RecordsBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(264, 175)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(353, 34)
        Me.DateOfBirthDateTimePicker.TabIndex = 9
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(264, 215)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(353, 34)
        Me.AgeTextBox.TabIndex = 11
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(264, 255)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(353, 34)
        Me.OccupationTextBox.TabIndex = 13
        '
        'MaritalStatusTextBox
        '
        Me.MaritalStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "MaritalStatus", True))
        Me.MaritalStatusTextBox.Location = New System.Drawing.Point(264, 295)
        Me.MaritalStatusTextBox.Name = "MaritalStatusTextBox"
        Me.MaritalStatusTextBox.Size = New System.Drawing.Size(353, 34)
        Me.MaritalStatusTextBox.TabIndex = 15
        '
        'NextOfKinTextBox
        '
        Me.NextOfKinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "NextOfKin", True))
        Me.NextOfKinTextBox.Location = New System.Drawing.Point(264, 335)
        Me.NextOfKinTextBox.Name = "NextOfKinTextBox"
        Me.NextOfKinTextBox.Size = New System.Drawing.Size(353, 34)
        Me.NextOfKinTextBox.TabIndex = 17
        '
        'HouseAddressTextBox
        '
        Me.HouseAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "HouseAddress", True))
        Me.HouseAddressTextBox.Location = New System.Drawing.Point(264, 375)
        Me.HouseAddressTextBox.Name = "HouseAddressTextBox"
        Me.HouseAddressTextBox.Size = New System.Drawing.Size(353, 34)
        Me.HouseAddressTextBox.TabIndex = 19
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(264, 415)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(353, 34)
        Me.LocationTextBox.TabIndex = 21
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(264, 455)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(353, 34)
        Me.PhoneNumberTextBox.TabIndex = 23
        '
        'TimeOfAdmissionTextBox
        '
        Me.TimeOfAdmissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "TimeOfAdmission", True))
        Me.TimeOfAdmissionTextBox.Location = New System.Drawing.Point(264, 495)
        Me.TimeOfAdmissionTextBox.Name = "TimeOfAdmissionTextBox"
        Me.TimeOfAdmissionTextBox.Size = New System.Drawing.Size(353, 34)
        Me.TimeOfAdmissionTextBox.TabIndex = 25
        '
        'TimeOfDischargeTextBox
        '
        Me.TimeOfDischargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "TimeOfDischarge", True))
        Me.TimeOfDischargeTextBox.Location = New System.Drawing.Point(264, 535)
        Me.TimeOfDischargeTextBox.Name = "TimeOfDischargeTextBox"
        Me.TimeOfDischargeTextBox.Size = New System.Drawing.Size(353, 34)
        Me.TimeOfDischargeTextBox.TabIndex = 27
        '
        'DoctorTableAdapter
        '
        Me.DoctorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorTableAdapter = Me.DoctorTableAdapter
        Me.TableAdapterManager.NurseTableAdapter = Nothing
        Me.TableAdapterManager.Patient_RecordsTableAdapter = Nothing
        Me.TableAdapterManager.PrescriptionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HospitalManagementSystem.INNOHOSPITALDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'DoctorBindingNavigator
        '
        Me.DoctorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DoctorBindingNavigator.BindingSource = Me.DoctorBindingSource
        Me.DoctorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DoctorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DoctorBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DoctorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DoctorBindingNavigatorSaveItem})
        Me.DoctorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoctorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DoctorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DoctorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DoctorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DoctorBindingNavigator.Name = "DoctorBindingNavigator"
        Me.DoctorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DoctorBindingNavigator.Size = New System.Drawing.Size(1579, 31)
        Me.DoctorBindingNavigator.TabIndex = 2
        Me.DoctorBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'DoctorBindingNavigatorSaveItem
        '
        Me.DoctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorBindingNavigatorSaveItem.Name = "DoctorBindingNavigatorSaveItem"
        Me.DoctorBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.DoctorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NurseTableAdapter
        '
        Me.NurseTableAdapter.ClearBeforeFill = True
        '
        'PrescriptionTableAdapter
        '
        Me.PrescriptionTableAdapter.ClearBeforeFill = True
        '
        'Patient_RecordsTableAdapter
        '
        Me.Patient_RecordsTableAdapter.ClearBeforeFill = True
        '
        'brnViewPrescri
        '
        Me.brnViewPrescri.Location = New System.Drawing.Point(51, 63)
        Me.brnViewPrescri.Name = "brnViewPrescri"
        Me.brnViewPrescri.Size = New System.Drawing.Size(122, 50)
        Me.brnViewPrescri.TabIndex = 0
        Me.brnViewPrescri.Text = "View"
        Me.brnViewPrescri.UseVisualStyleBackColor = True
        '
        'btnUpdatePrescri
        '
        Me.btnUpdatePrescri.Location = New System.Drawing.Point(55, 166)
        Me.btnUpdatePrescri.Name = "btnUpdatePrescri"
        Me.btnUpdatePrescri.Size = New System.Drawing.Size(118, 50)
        Me.btnUpdatePrescri.TabIndex = 1
        Me.btnUpdatePrescri.Text = "Update"
        Me.btnUpdatePrescri.UseVisualStyleBackColor = True
        '
        'btnInsertPrescri
        '
        Me.btnInsertPrescri.Location = New System.Drawing.Point(55, 255)
        Me.btnInsertPrescri.Name = "btnInsertPrescri"
        Me.btnInsertPrescri.Size = New System.Drawing.Size(118, 50)
        Me.btnInsertPrescri.TabIndex = 2
        Me.btnInsertPrescri.Text = "Insert"
        Me.btnInsertPrescri.UseVisualStyleBackColor = True
        '
        'btnDeletePrescri
        '
        Me.btnDeletePrescri.Location = New System.Drawing.Point(55, 345)
        Me.btnDeletePrescri.Name = "btnDeletePrescri"
        Me.btnDeletePrescri.Size = New System.Drawing.Size(118, 50)
        Me.btnDeletePrescri.TabIndex = 3
        Me.btnDeletePrescri.Text = "Delete"
        Me.btnDeletePrescri.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 46)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nurse Dashoard"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnViewNurse)
        Me.GroupBox3.Controls.Add(Me.btnDeleteNurse)
        Me.GroupBox3.Controls.Add(Me.btnInsertNurse)
        Me.GroupBox3.Controls.Add(Me.btnUpdateNurse)
        Me.GroupBox3.Location = New System.Drawing.Point(651, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 368)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Commands"
        '
        'btnViewNurse
        '
        Me.btnViewNurse.Location = New System.Drawing.Point(88, 309)
        Me.btnViewNurse.Name = "btnViewNurse"
        Me.btnViewNurse.Size = New System.Drawing.Size(112, 43)
        Me.btnViewNurse.TabIndex = 3
        Me.btnViewNurse.Text = "View"
        Me.btnViewNurse.UseVisualStyleBackColor = True
        '
        'btnDeleteNurse
        '
        Me.btnDeleteNurse.Location = New System.Drawing.Point(88, 212)
        Me.btnDeleteNurse.Name = "btnDeleteNurse"
        Me.btnDeleteNurse.Size = New System.Drawing.Size(112, 40)
        Me.btnDeleteNurse.TabIndex = 2
        Me.btnDeleteNurse.Text = "Delete"
        Me.btnDeleteNurse.UseVisualStyleBackColor = True
        '
        'btnInsertNurse
        '
        Me.btnInsertNurse.Location = New System.Drawing.Point(88, 127)
        Me.btnInsertNurse.Name = "btnInsertNurse"
        Me.btnInsertNurse.Size = New System.Drawing.Size(112, 40)
        Me.btnInsertNurse.TabIndex = 1
        Me.btnInsertNurse.Text = "Insert"
        Me.btnInsertNurse.UseVisualStyleBackColor = True
        '
        'btnUpdateNurse
        '
        Me.btnUpdateNurse.Location = New System.Drawing.Point(88, 47)
        Me.btnUpdateNurse.Name = "btnUpdateNurse"
        Me.btnUpdateNurse.Size = New System.Drawing.Size(112, 40)
        Me.btnUpdateNurse.TabIndex = 0
        Me.btnUpdateNurse.Text = "Update"
        Me.btnUpdateNurse.UseVisualStyleBackColor = True
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 899)
        Me.Controls.Add(Me.DoctorBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Doctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDoctor.ResumeLayout(False)
        Me.tabDoctor.PerformLayout()
        Me.FilterDoc.ResumeLayout(False)
        Me.FilterDoc.PerformLayout()
        CType(Me.DoctorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INNOHOSPITALDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNurse.ResumeLayout(False)
        Me.tabNurse.PerformLayout()
        CType(Me.NurseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NurseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPrescription.ResumeLayout(False)
        Me.tabPrescription.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPatient.ResumeLayout(False)
        Me.tabPatient.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Patient_RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoctorBindingNavigator.ResumeLayout(False)
        Me.DoctorBindingNavigator.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDoctor As TabPage
    Friend WithEvents tabNurse As TabPage
    Friend WithEvents tabPrescription As TabPage
    Friend WithEvents tabPatient As TabPage
    Friend WithEvents INNOHOSPITALDataSet1 As INNOHOSPITALDataSet1
    Friend WithEvents DoctorBindingSource As BindingSource
    Friend WithEvents DoctorTableAdapter As INNOHOSPITALDataSet1TableAdapters.DoctorTableAdapter
    Friend WithEvents TableAdapterManager As INNOHOSPITALDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DoctorBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DoctorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Doctor_Ref_NoTextBox As TextBox
    Friend WithEvents Doctor_NHS_NoTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Medical_CenterTextBox As TextBox
    Friend WithEvents Address_Of_CenterTextBox As TextBox
    Friend WithEvents Medical_ReferenceTextBox As TextBox
    Friend WithEvents Office_Number1TextBox As TextBox
    Friend WithEvents Office_Number2TextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents DoctorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents FilterDoc As GroupBox
    Friend WithEvents btnSearchDoc As Button
    Friend WithEvents cmbSearchDoc As ComboBox
    Friend WithEvents txtSearchDoc As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents NurseBindingSource As BindingSource
    Friend WithEvents NurseTableAdapter As INNOHOSPITALDataSet1TableAdapters.NurseTableAdapter
    Friend WithEvents Nurse_ReferenceTextBox As TextBox
    Friend WithEvents FirstNameTextBox1 As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents MODTextBox As TextBox
    Friend WithEvents NurseDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents PrescriptionBindingSource As BindingSource
    Friend WithEvents PrescriptionTableAdapter As INNOHOSPITALDataSet1TableAdapters.PrescriptionTableAdapter
    Friend WithEvents PrescriptionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tablet_NameTextBox As TextBox
    Friend WithEvents Dosage_mgTextBox As TextBox
    Friend WithEvents Number_Of_TabletsTextBox As TextBox
    Friend WithEvents Issued_DateDateTimePicker As DateTimePicker
    Friend WithEvents Expire_DateDateTimePicker As DateTimePicker
    Friend WithEvents Daily_DosageTextBox As TextBox
    Friend WithEvents Possible_Side_EffectTextBox As TextBox
    Friend WithEvents Possible_InformationTextBox As TextBox
    Friend WithEvents Storage_AreaTextBox As TextBox
    Friend WithEvents AdministrationTextBox As TextBox
    Friend WithEvents Driving_and_using_MachinesTextBox As TextBox
    Friend WithEvents Patient_RecordsBindingSource As BindingSource
    Friend WithEvents Patient_RecordsTableAdapter As INNOHOSPITALDataSet1TableAdapters.Patient_RecordsTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Patient_RecordsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumberTextBox As TextBox
    Friend WithEvents FirstNameTextBox2 As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents LastNameTextBox1 As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents OccupationTextBox As TextBox
    Friend WithEvents MaritalStatusTextBox As TextBox
    Friend WithEvents NextOfKinTextBox As TextBox
    Friend WithEvents HouseAddressTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents TimeOfAdmissionTextBox As TextBox
    Friend WithEvents TimeOfDischargeTextBox As TextBox
    Friend WithEvents btnViewPatient As Button
    Friend WithEvents btnDeletePatient As Button
    Friend WithEvents btnInsertPatient As Button
    Friend WithEvents btnUpdatePatient As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnViewNurse As Button
    Friend WithEvents btnDeleteNurse As Button
    Friend WithEvents btnInsertNurse As Button
    Friend WithEvents btnUpdateNurse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDeletePrescri As Button
    Friend WithEvents btnInsertPrescri As Button
    Friend WithEvents btnUpdatePrescri As Button
    Friend WithEvents brnViewPrescri As Button
End Class
