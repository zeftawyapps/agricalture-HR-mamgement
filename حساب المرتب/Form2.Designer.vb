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
        Me.components = New System.ComponentModel.Container
        Dim SERLabel As System.Windows.Forms.Label
        Me.EmpDataDataGridView = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.MydataDataSet = New HOkmes.mydataDataSet
        Me.EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDataTableAdapter = New HOkmes.mydataDataSetTableAdapters.EmpDataTableAdapter
        Me.TableAdapterManager = New HOkmes.mydataDataSetTableAdapters.TableAdapterManager
        Me.SERTextBox = New System.Windows.Forms.TextBox
        SERLabel = New System.Windows.Forms.Label
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpDataDataGridView
        '
        Me.EmpDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpDataDataGridView.Location = New System.Drawing.Point(125, 93)
        Me.EmpDataDataGridView.Name = "EmpDataDataGridView"
        Me.EmpDataDataGridView.Size = New System.Drawing.Size(489, 289)
        Me.EmpDataDataGridView.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'MydataDataSet
        '
        Me.MydataDataSet.DataSetName = "mydataDataSet"
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
        Me.TableAdapterManager.UpdateOrder = HOkmes.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SERLabel
        '
        SERLabel.AutoSize = True
        SERLabel.Location = New System.Drawing.Point(332, 42)
        SERLabel.Name = "SERLabel"
        SERLabel.Size = New System.Drawing.Size(30, 13)
        SERLabel.TabIndex = 3
        SERLabel.Text = "SER:"
        '
        'SERTextBox
        '
        Me.SERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "SER", True))
        Me.SERTextBox.Location = New System.Drawing.Point(368, 39)
        Me.SERTextBox.Name = "SERTextBox"
        Me.SERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SERTextBox.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 443)
        Me.Controls.Add(SERLabel)
        Me.Controls.Add(Me.SERTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpDataDataGridView)
        Me.Name = "Form2"
        Me.Text = "  "
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmpDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MydataDataSet As HOkmes.mydataDataSet
    Friend WithEvents EmpDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpDataTableAdapter As HOkmes.mydataDataSetTableAdapters.EmpDataTableAdapter
    Friend WithEvents TableAdapterManager As HOkmes.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SERTextBox As System.Windows.Forms.TextBox
End Class
