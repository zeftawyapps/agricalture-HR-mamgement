<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class get_error
    Inherits ZeftawyTools.myformDesign

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.EmpDataDataGridView = New System.Windows.Forms.DataGridView
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.UnNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.UnNameTableAdapter = New HOkmes.mydataDataSetTableAdapters.UnNameTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.UnNameDataGridView = New System.Windows.Forms.DataGridView
        Me.EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpDataTableAdapter = New Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter
        Me.ManegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpNmeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NationalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T_button4 = New ZeftawyTools.t_button
        Me.T_button1 = New ZeftawyTools.t_button
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnNameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(535, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(503, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Size = New System.Drawing.Size(10, 10)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Size = New System.Drawing.Size(10, 25)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-45, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-24, 75)
        Me.MsgT_Button.Size = New System.Drawing.Size(70, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(448, 7)
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(630, 335)
        '
        'T_button
        '
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'T_textbox
        '
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'EmpDataDataGridView
        '
        Me.EmpDataDataGridView.AutoGenerateColumns = False
        Me.EmpDataDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.EmpDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ManegeDataGridViewTextBoxColumn, Me.EmpNmeDataGridViewTextBoxColumn, Me.NationalIDDataGridViewTextBoxColumn})
        Me.EmpDataDataGridView.DataSource = Me.EmpDataBindingSource
        Me.EmpDataDataGridView.Location = New System.Drawing.Point(38, 59)
        Me.EmpDataDataGridView.Name = "EmpDataDataGridView"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Simplified Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow
        Me.EmpDataDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.EmpDataDataGridView.Size = New System.Drawing.Size(457, 251)
        Me.EmpDataDataGridView.TabIndex = 13
        '
        'MydataDataSet
        '
        Me.MydataDataSet.DataSetName = "mydataDataSet"
        Me.MydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnNameBindingSource
        '
        Me.UnNameBindingSource.DataMember = "UnName"
        Me.UnNameBindingSource.DataSource = Me.MydataDataSet
        '
        'UnNameTableAdapter
        '
        'Me.UnNameTableAdapter.ClearBeforeFill = True
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
        'Me.TableAdapterManager.UnNameTableAdapter = Me.UnNameTableAdapter
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UnNameDataGridView
        '
        Me.UnNameDataGridView.AutoGenerateColumns = False
        Me.UnNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnNameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.UnNameDataGridView.DataSource = Me.UnNameBindingSource
        Me.UnNameDataGridView.Location = New System.Drawing.Point(38, 371)
        Me.UnNameDataGridView.Name = "UnNameDataGridView"
        Me.UnNameDataGridView.Size = New System.Drawing.Size(457, 250)
        Me.UnNameDataGridView.TabIndex = 14
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
        'ManegeDataGridViewTextBoxColumn
        '
        Me.ManegeDataGridViewTextBoxColumn.DataPropertyName = "Manege"
        Me.ManegeDataGridViewTextBoxColumn.HeaderText = "Manege"
        Me.ManegeDataGridViewTextBoxColumn.Name = "ManegeDataGridViewTextBoxColumn"
        '
        'EmpNmeDataGridViewTextBoxColumn
        '
        Me.EmpNmeDataGridViewTextBoxColumn.DataPropertyName = "EmpNme"
        Me.EmpNmeDataGridViewTextBoxColumn.HeaderText = "EmpNme"
        Me.EmpNmeDataGridViewTextBoxColumn.Name = "EmpNmeDataGridViewTextBoxColumn"
        '
        'NationalIDDataGridViewTextBoxColumn
        '
        Me.NationalIDDataGridViewTextBoxColumn.DataPropertyName = "NationalID"
        Me.NationalIDDataGridViewTextBoxColumn.HeaderText = "NationalID"
        Me.NationalIDDataGridViewTextBoxColumn.Name = "NationalIDDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nid"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Manage"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Manage"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'T_button4
        '
        Me.T_button4.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button4.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button4.CheckBox = False
        Me.T_button4.Checked = False
        Me.T_button4.font_color = System.Drawing.Color.Black
        Me.T_button4.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button4.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button4.Location = New System.Drawing.Point(193, 316)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "Refrish"
        Me.T_button4.meAutoSize = False
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(139, 41)
        Me.T_button4.TabIndex = 15
        Me.T_button4.Text = "Refrish"
        Me.T_button4.UseDefFontInTxtShap = True
        Me.T_button4.UseDefultButton = False
        Me.T_button4.UseVisualStyleBackColor = True
        '
        'T_button1
        '
        Me.T_button1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button1.CheckBox = False
        Me.T_button1.Checked = False
        Me.T_button1.font_color = System.Drawing.Color.Black
        Me.T_button1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button1.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button1.Location = New System.Drawing.Point(182, 642)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "Refrish"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(139, 41)
        Me.T_button1.TabIndex = 16
        Me.T_button1.Text = "Refrish"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'get_error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 752)
        Me.Controls.Add(Me.T_button1)
        Me.Controls.Add(Me.T_button4)
        Me.Controls.Add(Me.UnNameDataGridView)
        Me.Controls.Add(Me.EmpDataDataGridView)
        Me.Name = "get_error"
        Me.Opacity = 1
        Me.Text = "get_error"
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.EmpDataDataGridView, 0)
        Me.Controls.SetChildIndex(Me.UnNameDataGridView, 0)
        Me.Controls.SetChildIndex(Me.T_button4, 0)
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnNameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmpDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents UnNameBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents UnNameTableAdapter As HOkmes.mydataDataSetTableAdapters.UnNameTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpDataTableAdapter As Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter
    Friend WithEvents UnNameDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ManegeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpNmeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_button4 As ZeftawyTools.t_button
    Friend WithEvents T_button1 As ZeftawyTools.t_button
End Class
