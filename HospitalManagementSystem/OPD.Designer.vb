<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OPD
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
        Dim ReferenceNumberLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OPD))
        Me.INNOHOSPITALDataSet = New HospitalManagementSystem.INNOHOSPITALDataSet()
        Me.Patient_RecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_RecordsTableAdapter = New HospitalManagementSystem.INNOHOSPITALDataSetTableAdapters.Patient_RecordsTableAdapter()
        Me.TableAdapterManager = New HospitalManagementSystem.INNOHOSPITALDataSetTableAdapters.TableAdapterManager()
        Me.Patient_RecordsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Patient_RecordsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Patient_RecordsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenceNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnMoveFirst = New System.Windows.Forms.Button()
        Me.btnMoveLast = New System.Windows.Forms.Button()
        Me.btnMovePrevious = New System.Windows.Forms.Button()
        Me.btnMoveNext = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        ReferenceNumberLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
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
        CType(Me.INNOHOSPITALDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_RecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Patient_RecordsBindingNavigator.SuspendLayout()
        CType(Me.Patient_RecordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReferenceNumberLabel
        '
        ReferenceNumberLabel.AutoSize = True
        ReferenceNumberLabel.Location = New System.Drawing.Point(23, 147)
        ReferenceNumberLabel.Name = "ReferenceNumberLabel"
        ReferenceNumberLabel.Size = New System.Drawing.Size(124, 16)
        ReferenceNumberLabel.TabIndex = 2
        ReferenceNumberLabel.Text = "Reference Number:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(23, 175)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(75, 16)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Location = New System.Drawing.Point(23, 203)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(91, 16)
        MiddleNameLabel.TabIndex = 6
        MiddleNameLabel.Text = "Middle Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(23, 231)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(75, 16)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "Last Name:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(23, 260)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(84, 16)
        DateOfBirthLabel.TabIndex = 10
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(23, 287)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(35, 16)
        AgeLabel.TabIndex = 12
        AgeLabel.Text = "Age:"
        '
        'OccupationLabel
        '
        OccupationLabel.AutoSize = True
        OccupationLabel.Location = New System.Drawing.Point(23, 315)
        OccupationLabel.Name = "OccupationLabel"
        OccupationLabel.Size = New System.Drawing.Size(78, 16)
        OccupationLabel.TabIndex = 14
        OccupationLabel.Text = "Occupation:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(23, 343)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(90, 16)
        MaritalStatusLabel.TabIndex = 16
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'NextOfKinLabel
        '
        NextOfKinLabel.AutoSize = True
        NextOfKinLabel.Location = New System.Drawing.Point(23, 371)
        NextOfKinLabel.Name = "NextOfKinLabel"
        NextOfKinLabel.Size = New System.Drawing.Size(74, 16)
        NextOfKinLabel.TabIndex = 18
        NextOfKinLabel.Text = "Next Of Kin:"
        '
        'HouseAddressLabel
        '
        HouseAddressLabel.AutoSize = True
        HouseAddressLabel.Location = New System.Drawing.Point(23, 399)
        HouseAddressLabel.Name = "HouseAddressLabel"
        HouseAddressLabel.Size = New System.Drawing.Size(104, 16)
        HouseAddressLabel.TabIndex = 20
        HouseAddressLabel.Text = "House Address:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(23, 427)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(61, 16)
        LocationLabel.TabIndex = 22
        LocationLabel.Text = "Location:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(23, 455)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(100, 16)
        PhoneNumberLabel.TabIndex = 24
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'TimeOfAdmissionLabel
        '
        TimeOfAdmissionLabel.AutoSize = True
        TimeOfAdmissionLabel.Location = New System.Drawing.Point(23, 483)
        TimeOfAdmissionLabel.Name = "TimeOfAdmissionLabel"
        TimeOfAdmissionLabel.Size = New System.Drawing.Size(123, 16)
        TimeOfAdmissionLabel.TabIndex = 26
        TimeOfAdmissionLabel.Text = "Time Of Admission:"
        '
        'TimeOfDischargeLabel
        '
        TimeOfDischargeLabel.AutoSize = True
        TimeOfDischargeLabel.Location = New System.Drawing.Point(23, 511)
        TimeOfDischargeLabel.Name = "TimeOfDischargeLabel"
        TimeOfDischargeLabel.Size = New System.Drawing.Size(122, 16)
        TimeOfDischargeLabel.TabIndex = 28
        TimeOfDischargeLabel.Text = "Time Of Discharge:"
        '
        'INNOHOSPITALDataSet
        '
        Me.INNOHOSPITALDataSet.DataSetName = "INNOHOSPITALDataSet"
        Me.INNOHOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Patient_RecordsBindingSource
        '
        Me.Patient_RecordsBindingSource.DataMember = "Patient_Records"
        Me.Patient_RecordsBindingSource.DataSource = Me.INNOHOSPITALDataSet
        '
        'Patient_RecordsTableAdapter
        '
        Me.Patient_RecordsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Patient_RecordsTableAdapter = Me.Patient_RecordsTableAdapter
        Me.TableAdapterManager.UpdateOrder = HospitalManagementSystem.INNOHOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Patient_RecordsBindingNavigator
        '
        Me.Patient_RecordsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Patient_RecordsBindingNavigator.BindingSource = Me.Patient_RecordsBindingSource
        Me.Patient_RecordsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Patient_RecordsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Patient_RecordsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Patient_RecordsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Patient_RecordsBindingNavigatorSaveItem})
        Me.Patient_RecordsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Patient_RecordsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Patient_RecordsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Patient_RecordsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Patient_RecordsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Patient_RecordsBindingNavigator.Name = "Patient_RecordsBindingNavigator"
        Me.Patient_RecordsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Patient_RecordsBindingNavigator.Size = New System.Drawing.Size(1584, 27)
        Me.Patient_RecordsBindingNavigator.TabIndex = 0
        Me.Patient_RecordsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
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
        'Patient_RecordsBindingNavigatorSaveItem
        '
        Me.Patient_RecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Patient_RecordsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Patient_RecordsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Patient_RecordsBindingNavigatorSaveItem.Name = "Patient_RecordsBindingNavigatorSaveItem"
        Me.Patient_RecordsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Patient_RecordsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Patient_RecordsDataGridView
        '
        Me.Patient_RecordsDataGridView.AutoGenerateColumns = False
        Me.Patient_RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Patient_RecordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Patient_RecordsDataGridView.DataSource = Me.Patient_RecordsBindingSource
        Me.Patient_RecordsDataGridView.Location = New System.Drawing.Point(371, 144)
        Me.Patient_RecordsDataGridView.Name = "Patient_RecordsDataGridView"
        Me.Patient_RecordsDataGridView.RowHeadersWidth = 51
        Me.Patient_RecordsDataGridView.RowTemplate.Height = 24
        Me.Patient_RecordsDataGridView.Size = New System.Drawing.Size(1172, 383)
        Me.Patient_RecordsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ReferenceNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ReferenceNumber"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MiddleName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MiddleName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Occupation"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MaritalStatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MaritalStatus"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NextOfKin"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NextOfKin"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "HouseAddress"
        Me.DataGridViewTextBoxColumn10.HeaderText = "HouseAddress"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TimeOfAdmission"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TimeOfAdmission"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TimeOfDischarge"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TimeOfDischarge"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'ReferenceNumberTextBox
        '
        Me.ReferenceNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "ReferenceNumber", True))
        Me.ReferenceNumberTextBox.Location = New System.Drawing.Point(153, 144)
        Me.ReferenceNumberTextBox.Name = "ReferenceNumberTextBox"
        Me.ReferenceNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ReferenceNumberTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(153, 172)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(153, 200)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MiddleNameTextBox.TabIndex = 7
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(153, 228)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LastNameTextBox.TabIndex = 9
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Patient_RecordsBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(153, 256)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateOfBirthDateTimePicker.TabIndex = 11
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(153, 284)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AgeTextBox.TabIndex = 13
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Occupation", True))
        Me.OccupationTextBox.Location = New System.Drawing.Point(153, 312)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.Size = New System.Drawing.Size(200, 22)
        Me.OccupationTextBox.TabIndex = 15
        '
        'MaritalStatusTextBox
        '
        Me.MaritalStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "MaritalStatus", True))
        Me.MaritalStatusTextBox.Location = New System.Drawing.Point(153, 340)
        Me.MaritalStatusTextBox.Name = "MaritalStatusTextBox"
        Me.MaritalStatusTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MaritalStatusTextBox.TabIndex = 17
        '
        'NextOfKinTextBox
        '
        Me.NextOfKinTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "NextOfKin", True))
        Me.NextOfKinTextBox.Location = New System.Drawing.Point(153, 368)
        Me.NextOfKinTextBox.Name = "NextOfKinTextBox"
        Me.NextOfKinTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NextOfKinTextBox.TabIndex = 19
        '
        'HouseAddressTextBox
        '
        Me.HouseAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "HouseAddress", True))
        Me.HouseAddressTextBox.Location = New System.Drawing.Point(153, 396)
        Me.HouseAddressTextBox.Name = "HouseAddressTextBox"
        Me.HouseAddressTextBox.Size = New System.Drawing.Size(200, 22)
        Me.HouseAddressTextBox.TabIndex = 21
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(153, 424)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LocationTextBox.TabIndex = 23
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(153, 452)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneNumberTextBox.TabIndex = 25
        '
        'TimeOfAdmissionTextBox
        '
        Me.TimeOfAdmissionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "TimeOfAdmission", True))
        Me.TimeOfAdmissionTextBox.Location = New System.Drawing.Point(153, 480)
        Me.TimeOfAdmissionTextBox.Name = "TimeOfAdmissionTextBox"
        Me.TimeOfAdmissionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TimeOfAdmissionTextBox.TabIndex = 27
        '
        'TimeOfDischargeTextBox
        '
        Me.TimeOfDischargeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Patient_RecordsBindingSource, "TimeOfDischarge", True))
        Me.TimeOfDischargeTextBox.Location = New System.Drawing.Point(153, 508)
        Me.TimeOfDischargeTextBox.Name = "TimeOfDischargeTextBox"
        Me.TimeOfDischargeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TimeOfDischargeTextBox.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1049, 54)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "INNORIK HOSPITAL MANAGEMENT SYSTEM"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(1015, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 22)
        Me.txtSearch.TabIndex = 31
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(1256, 10)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(155, 24)
        Me.cmbSearch.TabIndex = 32
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1417, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 23)
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnMoveFirst
        '
        Me.btnMoveFirst.Location = New System.Drawing.Point(371, 551)
        Me.btnMoveFirst.Name = "btnMoveFirst"
        Me.btnMoveFirst.Size = New System.Drawing.Size(98, 30)
        Me.btnMoveFirst.TabIndex = 34
        Me.btnMoveFirst.Text = "Move First"
        Me.btnMoveFirst.UseVisualStyleBackColor = True
        '
        'btnMoveLast
        '
        Me.btnMoveLast.Location = New System.Drawing.Point(526, 551)
        Me.btnMoveLast.Name = "btnMoveLast"
        Me.btnMoveLast.Size = New System.Drawing.Size(98, 30)
        Me.btnMoveLast.TabIndex = 35
        Me.btnMoveLast.Text = "Move Last"
        Me.btnMoveLast.UseVisualStyleBackColor = True
        '
        'btnMovePrevious
        '
        Me.btnMovePrevious.Location = New System.Drawing.Point(661, 551)
        Me.btnMovePrevious.Name = "btnMovePrevious"
        Me.btnMovePrevious.Size = New System.Drawing.Size(130, 30)
        Me.btnMovePrevious.TabIndex = 36
        Me.btnMovePrevious.Text = "Move Previous"
        Me.btnMovePrevious.UseVisualStyleBackColor = True
        '
        'btnMoveNext
        '
        Me.btnMoveNext.Location = New System.Drawing.Point(828, 551)
        Me.btnMoveNext.Name = "btnMoveNext"
        Me.btnMoveNext.Size = New System.Drawing.Size(98, 30)
        Me.btnMoveNext.TabIndex = 37
        Me.btnMoveNext.Text = "Next"
        Me.btnMoveNext.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(963, 551)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 30)
        Me.btnUpdate.TabIndex = 38
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1093, 551)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 30)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(1207, 551)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(98, 30)
        Me.btnRegister.TabIndex = 40
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1397, 551)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 30)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'OPD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1584, 610)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnMoveNext)
        Me.Controls.Add(Me.btnMovePrevious)
        Me.Controls.Add(Me.btnMoveLast)
        Me.Controls.Add(Me.btnMoveFirst)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ReferenceNumberLabel)
        Me.Controls.Add(Me.ReferenceNumberTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleNameLabel)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(DateOfBirthLabel)
        Me.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(OccupationLabel)
        Me.Controls.Add(Me.OccupationTextBox)
        Me.Controls.Add(MaritalStatusLabel)
        Me.Controls.Add(Me.MaritalStatusTextBox)
        Me.Controls.Add(NextOfKinLabel)
        Me.Controls.Add(Me.NextOfKinTextBox)
        Me.Controls.Add(HouseAddressLabel)
        Me.Controls.Add(Me.HouseAddressTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(TimeOfAdmissionLabel)
        Me.Controls.Add(Me.TimeOfAdmissionTextBox)
        Me.Controls.Add(TimeOfDischargeLabel)
        Me.Controls.Add(Me.TimeOfDischargeTextBox)
        Me.Controls.Add(Me.Patient_RecordsDataGridView)
        Me.Controls.Add(Me.Patient_RecordsBindingNavigator)
        Me.Name = "OPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ggf"
        CType(Me.INNOHOSPITALDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_RecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_RecordsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Patient_RecordsBindingNavigator.ResumeLayout(False)
        Me.Patient_RecordsBindingNavigator.PerformLayout()
        CType(Me.Patient_RecordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INNOHOSPITALDataSet As INNOHOSPITALDataSet
    Friend WithEvents Patient_RecordsBindingSource As BindingSource
    Friend WithEvents Patient_RecordsTableAdapter As INNOHOSPITALDataSetTableAdapters.Patient_RecordsTableAdapter
    Friend WithEvents TableAdapterManager As INNOHOSPITALDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patient_RecordsBindingNavigator As BindingNavigator
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
    Friend WithEvents Patient_RecordsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Patient_RecordsDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ReferenceNumberTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnMoveFirst As Button
    Friend WithEvents btnMoveLast As Button
    Friend WithEvents btnMovePrevious As Button
    Friend WithEvents btnMoveNext As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnExit As Button
End Class
