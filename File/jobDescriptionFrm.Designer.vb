Imports ZeftawyTools
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jobDescriptionFrm
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
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.T_button1 = New ZeftawyTools.t_button
        Me.T_textbox1 = New ZeftawyTools.t_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.NewGrb = New System.Windows.Forms.GroupBox
        Me.T_textbox4 = New ZeftawyTools.t_textbox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Datacontrol2B1 = New ZeftawyTools.datacontrol2B
        Me.Label2 = New System.Windows.Forms.Label
        Me.JobTableAdapter = New Zera3a.mydataDataSetTableAdapters.JobTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.JopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewGrb.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(4)
        Me.TitelBar.Size = New System.Drawing.Size(397, 51)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(355, 4)
        Me.Logo.Margin = New System.Windows.Forms.Padding(4)
        Me.Logo.Size = New System.Drawing.Size(43, 43)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(4, 273)
        Me.massegBoxFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.massegBoxFormat.Size = New System.Drawing.Size(13, 14)
        '
        'MsgText
        '
        Me.MsgText.Location = New System.Drawing.Point(23, 48)
        Me.MsgText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Margin = New System.Windows.Forms.Padding(4)
        Me.MsgTilteBar.Size = New System.Drawing.Size(13, 35)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-60, 0)
        Me.msgTitl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-32, 104)
        Me.MsgT_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.MsgT_Button.Size = New System.Drawing.Size(93, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(281, 10)
        Me.Titel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titel.Size = New System.Drawing.Size(129, 24)
        Me.Titel.Text = "بحث عن جمعيات"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(683, 323)
        Me.Labelbox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(4, 338)
        Me.T_button.Margin = New System.Windows.Forms.Padding(4)
        Me.T_button.Size = New System.Drawing.Size(13, 14)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'MinBtn
        '
        Me.MinBtn.Location = New System.Drawing.Point(51, -7)
        Me.MinBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.MinBtn.Size = New System.Drawing.Size(45, 50)
        Me.MinBtn.Visible = False
        '
        'CloosBtn
        '
        Me.CloosBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloosBtn.Location = New System.Drawing.Point(4, -7)
        Me.CloosBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CloosBtn.Size = New System.Drawing.Size(45, 50)
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(-11, 303)
        Me.T_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox.Size = New System.Drawing.Size(28, 27)
        '
        'Gam3iaDataGridView
        '
        Me.Gam3iaDataGridView.AllowUserToAddRows = False
        Me.Gam3iaDataGridView.AllowUserToDeleteRows = False
        Me.Gam3iaDataGridView.AutoGenerateColumns = False
        Me.Gam3iaDataGridView.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.Gam3iaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gam3iaDataGridView.ColumnHeadersVisible = False
        Me.Gam3iaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JopDataGridViewTextBoxColumn})
        Me.Gam3iaDataGridView.DataSource = Me.JobBindingSource
        Me.Gam3iaDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gam3iaDataGridView.Location = New System.Drawing.Point(25, 105)
        Me.Gam3iaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Gam3iaDataGridView.Name = "Gam3iaDataGridView"
        Me.Gam3iaDataGridView.ReadOnly = True
        Me.Gam3iaDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.Gam3iaDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gam3iaDataGridView.Size = New System.Drawing.Size(357, 218)
        Me.Gam3iaDataGridView.TabIndex = 2
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.MydataDataSet
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
        Me.T_button1.Location = New System.Drawing.Point(164, 510)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.Margin = New System.Windows.Forms.Padding(4)
        Me.T_button1.me_text = "موافق"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(89, 47)
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
        Me.T_textbox1.Location = New System.Drawing.Point(40, 68)
        Me.T_textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(264, 29)
        Me.T_textbox1.TabIndex = 1
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 13
        '
        'NewGrb
        '
        Me.NewGrb.Controls.Add(Me.T_textbox4)
        Me.NewGrb.Controls.Add(Me.Label5)
        Me.NewGrb.Location = New System.Drawing.Point(32, 403)
        Me.NewGrb.Name = "NewGrb"
        Me.NewGrb.Size = New System.Drawing.Size(335, 83)
        Me.NewGrb.TabIndex = 21
        Me.NewGrb.TabStop = False
        Me.NewGrb.Visible = False
        '
        'T_textbox4
        '
        Me.T_textbox4.checkEmail = False
        Me.T_textbox4.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox4.combo_link = False
        Me.T_textbox4.combobox = Nothing
        Me.T_textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JobBindingSource, "Jop", True))
        Me.T_textbox4.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.T_textbox4.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelText = ""
        Me.T_textbox4.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox4.Location = New System.Drawing.Point(15, 26)
        Me.T_textbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox4.Name = "T_textbox4"
        Me.T_textbox4.numaricCheck = False
        Me.T_textbox4.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox4.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox4.Size = New System.Drawing.Size(229, 29)
        Me.T_textbox4.TabIndex = 22
        Me.T_textbox4.textColor = System.Drawing.Color.Black
        Me.T_textbox4.Textlengthcheck = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "الوظيفة"
        '
        'Datacontrol2B1
        '
        Me.Datacontrol2B1.add_or_delete = ZeftawyTools.adddelete.add
        Me.Datacontrol2B1.BackColor = System.Drawing.Color.Transparent
        Me.Datacontrol2B1.bindingsouce = Nothing
        Me.Datacontrol2B1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Datacontrol2B1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Datacontrol2B1.buttonforecolor = System.Drawing.Color.Empty
        Me.Datacontrol2B1.Location = New System.Drawing.Point(51, 338)
        Me.Datacontrol2B1.Margin = New System.Windows.Forms.Padding(4)
        Me.Datacontrol2B1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Datacontrol2B1.meloodserruonding_color = System.Drawing.Color.Green
        Me.Datacontrol2B1.meText = "اضافة وحفظ"
        Me.Datacontrol2B1.mousemove_center_color = System.Drawing.Color.Lime
        Me.Datacontrol2B1.Name = "Datacontrol2B1"
        Me.Datacontrol2B1.Size = New System.Drawing.Size(253, 58)
        Me.Datacontrol2B1.TabIndex = 22
        Me.Datacontrol2B1.textfont = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "الوظيفة"
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDataTableAdapter = Nothing
        Me.TableAdapterManager.FinanceDegreeTableAdapter = Nothing
        Me.TableAdapterManager.Gam3iaTableAdapter = Nothing
        Me.TableAdapterManager.HokmsTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Me.JobTableAdapter
        Me.TableAdapterManager.QualifayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JopDataGridViewTextBoxColumn
        '
        Me.JopDataGridViewTextBoxColumn.DataPropertyName = "Jop"
        Me.JopDataGridViewTextBoxColumn.HeaderText = "Jop"
        Me.JopDataGridViewTextBoxColumn.Name = "JopDataGridViewTextBoxColumn"
        Me.JopDataGridViewTextBoxColumn.ReadOnly = True
        Me.JopDataGridViewTextBoxColumn.Width = 350
        '
        'jobDescriptionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.CancelButton = Me.CloosBtn
        Me.ClientSize = New System.Drawing.Size(397, 598)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Datacontrol2B1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_textbox1)
        Me.Controls.Add(Me.T_button1)
        Me.Controls.Add(Me.Gam3iaDataGridView)
        Me.Controls.Add(Me.NewGrb)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "jobDescriptionFrm"
        Me.Opacity = 1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث عن جمعيات"
        Me.TiteText = "بحث عن جمعيات"
        Me.UseMyBackColor = True
        Me.Controls.SetChildIndex(Me.NewGrb, 0)
        Me.Controls.SetChildIndex(Me.Gam3iaDataGridView, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.T_button1, 0)
        Me.Controls.SetChildIndex(Me.T_textbox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Datacontrol2B1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewGrb.ResumeLayout(False)
        Me.NewGrb.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gam3iaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewGrb As System.Windows.Forms.GroupBox
    Friend WithEvents Datacontrol2B1 As ZeftawyTools.datacontrol2B
    Friend WithEvents T_textbox4 As ZeftawyTools.t_textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents JobBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobTableAdapter As Zera3a.mydataDataSetTableAdapters.JobTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
