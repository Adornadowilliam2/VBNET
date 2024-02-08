<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class database
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.AccountidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccttypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccounttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountbalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Bolivar_Finals.DataSet1()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountidDataGridViewTextBoxColumn, Me.AccountnumberDataGridViewTextBoxColumn, Me.AccttypeidDataGridViewTextBoxColumn, Me.AccounttypeDataGridViewTextBoxColumn, Me.PinDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.AccountbalanceDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.SessionBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(800, 450)
        Me.dgv.TabIndex = 0
        '
        'AccountidDataGridViewTextBoxColumn
        '
        Me.AccountidDataGridViewTextBoxColumn.DataPropertyName = "account_id"
        Me.AccountidDataGridViewTextBoxColumn.HeaderText = "account_id"
        Me.AccountidDataGridViewTextBoxColumn.Name = "AccountidDataGridViewTextBoxColumn"
        Me.AccountidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountnumberDataGridViewTextBoxColumn
        '
        Me.AccountnumberDataGridViewTextBoxColumn.DataPropertyName = "account_number"
        Me.AccountnumberDataGridViewTextBoxColumn.HeaderText = "account_number"
        Me.AccountnumberDataGridViewTextBoxColumn.Name = "AccountnumberDataGridViewTextBoxColumn"
        Me.AccountnumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccttypeidDataGridViewTextBoxColumn
        '
        Me.AccttypeidDataGridViewTextBoxColumn.DataPropertyName = "acct_type_id"
        Me.AccttypeidDataGridViewTextBoxColumn.HeaderText = "acct_type_id"
        Me.AccttypeidDataGridViewTextBoxColumn.Name = "AccttypeidDataGridViewTextBoxColumn"
        Me.AccttypeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccounttypeDataGridViewTextBoxColumn
        '
        Me.AccounttypeDataGridViewTextBoxColumn.DataPropertyName = "account_type"
        Me.AccounttypeDataGridViewTextBoxColumn.HeaderText = "account_type"
        Me.AccounttypeDataGridViewTextBoxColumn.Name = "AccounttypeDataGridViewTextBoxColumn"
        Me.AccounttypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PinDataGridViewTextBoxColumn
        '
        Me.PinDataGridViewTextBoxColumn.DataPropertyName = "pin"
        Me.PinDataGridViewTextBoxColumn.HeaderText = "pin"
        Me.PinDataGridViewTextBoxColumn.Name = "PinDataGridViewTextBoxColumn"
        Me.PinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        Me.BirthdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountbalanceDataGridViewTextBoxColumn
        '
        Me.AccountbalanceDataGridViewTextBoxColumn.DataPropertyName = "account_balance"
        Me.AccountbalanceDataGridViewTextBoxColumn.HeaderText = "account_balance"
        Me.AccountbalanceDataGridViewTextBoxColumn.Name = "AccountbalanceDataGridViewTextBoxColumn"
        Me.AccountbalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionBindingSource
        '
        Me.SessionBindingSource.DataMember = "session"
        Me.SessionBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents AccountidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountnumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccttypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccounttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountbalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SessionBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
