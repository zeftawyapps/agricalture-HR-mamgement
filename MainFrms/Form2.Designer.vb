<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MydataDataSet = New Zera3a.mydataDataSet()
        Me.EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDataTableAdapter = New Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter()
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager()
        Me.EmpDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmpData_QueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.EmpData_QueryTableAdapter = New Zera3a.mydataDataSetTableAdapters.EmpData_QueryTableAdapter()
        Me.ManegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpData_QueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MydataDataSet
        '
        Me.MydataDataSet.DataSetName = "mydataDataSet"
        Me.MydataDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.MydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpDataBindingSource
        '
        Me.EmpDataBindingSource.DataMember = "EmpData"
        Me.EmpDataBindingSource.DataSource = Me.MydataDataSet
        '
        'EmpDataTableAdapter
        '
        Me.EmpDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDataTableAdapter = Me.EmpDataTableAdapter
        Me.TableAdapterManager.FinanceDegreeTableAdapter = Nothing
        Me.TableAdapterManager.Gam3iaTableAdapter = Nothing
        Me.TableAdapterManager.HokmsTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.QualifayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpDataDataGridView
        '
        Me.EmpDataDataGridView.AutoGenerateColumns = False
        Me.EmpDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManegeDataGridViewTextBoxColumn, Me.CntDataGridViewTextBoxColumn})
        Me.EmpDataDataGridView.DataSource = Me.EmpData_QueryBindingSource
        Me.EmpDataDataGridView.Location = New System.Drawing.Point(189, 109)
        Me.EmpDataDataGridView.Name = "EmpDataDataGridView"
        Me.EmpDataDataGridView.Size = New System.Drawing.Size(601, 220)
        Me.EmpDataDataGridView.TabIndex = 1
        '
        'EmpData_QueryBindingSource
        '
        Me.EmpData_QueryBindingSource.DataMember = "EmpData Query"
        Me.EmpData_QueryBindingSource.DataSource = Me.MydataDataSet
        '
        'EmpData_QueryTableAdapter
        '
        Me.EmpData_QueryTableAdapter.ClearBeforeFill = True
        '
        'ManegeDataGridViewTextBoxColumn
        '
        Me.ManegeDataGridViewTextBoxColumn.DataPropertyName = "Manege"
        Me.ManegeDataGridViewTextBoxColumn.HeaderText = "Manege"
        Me.ManegeDataGridViewTextBoxColumn.Name = "ManegeDataGridViewTextBoxColumn"
        '
        'CntDataGridViewTextBoxColumn
        '
        Me.CntDataGridViewTextBoxColumn.DataPropertyName = "cnt"
        Me.CntDataGridViewTextBoxColumn.HeaderText = "cnt"
        Me.CntDataGridViewTextBoxColumn.Name = "CntDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 349)
        Me.Controls.Add(Me.EmpDataDataGridView)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpData_QueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents EmpDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpDataTableAdapter As Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpData_QueryBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents EmpData_QueryTableAdapter As Zera3a.mydataDataSetTableAdapters.EmpData_QueryTableAdapter
    Friend WithEvents ManegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
