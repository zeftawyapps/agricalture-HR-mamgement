<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gam3eaSearchFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Gam3iaDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Gam3iaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.T_button1 = New ZeftawyTools.t_button
        Me.T_textbox1 = New ZeftawyTools.t_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Gam3iaTableAdapter = New Zera3a.mydataDataSetTableAdapters.Gam3iaTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gam3iaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(351, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(319, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(3, 197)
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
        Me.Titel.Location = New System.Drawing.Point(264, 7)
        Me.Titel.Size = New System.Drawing.Size(129, 24)
        Me.Titel.Text = "بحث عن جمعيات"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(538, 199)
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(3, 244)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'MinBtn
        '
        Me.MinBtn.Size = New System.Drawing.Size(31, 36)
        Me.MinBtn.Visible = False
        '
        'CloosBtn
        '
        Me.CloosBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(0, 288)
        Me.T_textbox.Size = New System.Drawing.Size(22, 27)
        '
        'Gam3iaDataGridView
        '
        Me.Gam3iaDataGridView.AllowUserToAddRows = False
        Me.Gam3iaDataGridView.AllowUserToDeleteRows = False
        Me.Gam3iaDataGridView.AutoGenerateColumns = False
        Me.Gam3iaDataGridView.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.Gam3iaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gam3iaDataGridView.ColumnHeadersVisible = False
        Me.Gam3iaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Gam3iaDataGridView.DataSource = Me.Gam3iaBindingSource
        Me.Gam3iaDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gam3iaDataGridView.Location = New System.Drawing.Point(12, 78)
        Me.Gam3iaDataGridView.Name = "Gam3iaDataGridView"
        Me.Gam3iaDataGridView.ReadOnly = True
        Me.Gam3iaDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.Gam3iaDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gam3iaDataGridView.Size = New System.Drawing.Size(307, 216)
        Me.Gam3iaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Gam3iaName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "جمعيات"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 288
        '
        'Gam3iaBindingSource
        '
        Me.Gam3iaBindingSource.DataMember = "Gam3ia"
        Me.Gam3iaBindingSource.DataSource = Me.MydataDataSet
        '
        'MydataDataSet
        '
        Me.MydataDataSet.DataSetName = "mydataDataSet"
        Me.MydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.T_button1.Location = New System.Drawing.Point(139, 318)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "موافق"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(67, 34)
        Me.T_button1.TabIndex = 11
        Me.T_button1.Text = "موافق"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = ""
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(20, 43)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(198, 29)
        Me.T_textbox1.TabIndex = 1
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "الجمعية"
        '
        'Gam3iaTableAdapter
        '
        Me.Gam3iaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDataTableAdapter = Nothing
        Me.TableAdapterManager.Gam3iaTableAdapter = Me.Gam3iaTableAdapter
        Me.TableAdapterManager.HokmsTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.QualifayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Gam3eaSearchFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.CancelButton = Me.CloosBtn
        Me.ClientSize = New System.Drawing.Size(351, 364)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_textbox1)
        Me.Controls.Add(Me.T_button1)
        Me.Controls.Add(Me.Gam3iaDataGridView)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "Gam3eaSearchFrm"
        Me.Opacity = 1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث عن جمعيات"
        Me.TiteText = "بحث عن جمعيات"
        Me.UseMyBackColor = True
        Me.Controls.SetChildIndex(Me.Gam3iaDataGridView, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.T_textbox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gam3iaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents Gam3iaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gam3iaTableAdapter As Zera3a.mydataDataSetTableAdapters.Gam3iaTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Gam3iaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
