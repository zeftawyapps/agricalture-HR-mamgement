<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QulifaySearch
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
        Me.QulifayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nao3ea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QualifayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.T_button1 = New ZeftawyTools.t_button
        Me.T_textbox1 = New ZeftawyTools.t_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QualifayTableAdapter = New Zera3a.mydataDataSetTableAdapters.QualifayTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.T_textbox2 = New ZeftawyTools.t_textbox
        Me.T_textbox3 = New ZeftawyTools.t_textbox
        Me.Label4 = New System.Windows.Forms.Label
        Me.NewGrb = New System.Windows.Forms.GroupBox
        Me.Naow3iaComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.T_textbox4 = New ZeftawyTools.t_textbox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Datacontrol2B1 = New ZeftawyTools.datacontrol2B
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualifayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewGrb.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Margin = New System.Windows.Forms.Padding(4)
        Me.TitelBar.Size = New System.Drawing.Size(591, 51)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(549, 4)
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
        Me.Titel.Location = New System.Drawing.Point(475, 10)
        Me.Titel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titel.Size = New System.Drawing.Size(129, 24)
        Me.Titel.Text = "بحث عن جمعيات"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(780, 318)
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
        Me.Gam3iaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QulifayDataGridViewTextBoxColumn, Me.nao3ea})
        Me.Gam3iaDataGridView.DataSource = Me.QualifayBindingSource
        Me.Gam3iaDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gam3iaDataGridView.Location = New System.Drawing.Point(13, 112)
        Me.Gam3iaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Gam3iaDataGridView.Name = "Gam3iaDataGridView"
        Me.Gam3iaDataGridView.ReadOnly = True
        Me.Gam3iaDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen
        Me.Gam3iaDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Gam3iaDataGridView.Size = New System.Drawing.Size(527, 218)
        Me.Gam3iaDataGridView.TabIndex = 10
        '
        'QulifayDataGridViewTextBoxColumn
        '
        Me.QulifayDataGridViewTextBoxColumn.DataPropertyName = "Qulifay"
        Me.QulifayDataGridViewTextBoxColumn.HeaderText = "المؤهل"
        Me.QulifayDataGridViewTextBoxColumn.Name = "QulifayDataGridViewTextBoxColumn"
        Me.QulifayDataGridViewTextBoxColumn.ReadOnly = True
        Me.QulifayDataGridViewTextBoxColumn.Width = 410
        '
        'nao3ea
        '
        Me.nao3ea.DataPropertyName = "nao3ea"
        Me.nao3ea.HeaderText = "نوعية"
        Me.nao3ea.Name = "nao3ea"
        Me.nao3ea.ReadOnly = True
        '
        'QualifayBindingSource
        '
        Me.QualifayBindingSource.DataMember = "Qualifay"
        Me.QualifayBindingSource.DataSource = Me.MydataDataSet
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
        Me.T_button1.Location = New System.Drawing.Point(262, 529)
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
        Me.T_textbox1.Location = New System.Drawing.Point(171, 59)
        Me.T_textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = False
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(263, 29)
        Me.T_textbox1.TabIndex = 2
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "المؤهل"
        '
        'QualifayTableAdapter
        '
        Me.QualifayTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDataTableAdapter = Nothing
        Me.TableAdapterManager.FinanceDegreeTableAdapter = Nothing
        Me.TableAdapterManager.Gam3iaTableAdapter = Nothing
        Me.TableAdapterManager.HokmsTableAdapter = Nothing
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.QualifayTableAdapter = Me.QualifayTableAdapter
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"بكالوريوس", "دبلوم", "معهد", "ليسانس", "اعدادي", "ابتادئي", "امي", "محو امية"})
        Me.ComboBox1.Location = New System.Drawing.Point(343, 43)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 26)
        Me.ComboBox1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(447, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "المؤهل"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "كليه"
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = ""
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(24, 40)
        Me.T_textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(268, 29)
        Me.T_textbox2.TabIndex = 18
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.T_textbox3.ForeColor = System.Drawing.Color.Black
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = ""
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(16, 59)
        Me.T_textbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = True
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(80, 29)
        Me.T_textbox3.TabIndex = 1
        Me.T_textbox3.Text = "0"
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "دفعة"
        '
        'NewGrb
        '
        Me.NewGrb.Controls.Add(Me.Naow3iaComboBox)
        Me.NewGrb.Controls.Add(Me.Label6)
        Me.NewGrb.Controls.Add(Me.T_textbox4)
        Me.NewGrb.Controls.Add(Me.Label5)
        Me.NewGrb.Controls.Add(Me.Label2)
        Me.NewGrb.Controls.Add(Me.ComboBox1)
        Me.NewGrb.Controls.Add(Me.T_textbox2)
        Me.NewGrb.Controls.Add(Me.Label3)
        Me.NewGrb.Location = New System.Drawing.Point(12, 403)
        Me.NewGrb.Name = "NewGrb"
        Me.NewGrb.Size = New System.Drawing.Size(512, 123)
        Me.NewGrb.TabIndex = 21
        Me.NewGrb.TabStop = False
        Me.NewGrb.Visible = False
        '
        'Naow3iaComboBox
        '
        Me.Naow3iaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifayBindingSource, "nao3ea", True))
        Me.Naow3iaComboBox.FormattingEnabled = True
        Me.Naow3iaComboBox.Items.AddRange(New Object() {"0- تخصصي", "1-مكتبي", "2- مهني", "3- خدمات معاونة"})
        Me.Naow3iaComboBox.Location = New System.Drawing.Point(15, 76)
        Me.Naow3iaComboBox.Name = "Naow3iaComboBox"
        Me.Naow3iaComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Naow3iaComboBox.Size = New System.Drawing.Size(136, 26)
        Me.Naow3iaComboBox.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "النوعية"
        '
        'T_textbox4
        '
        Me.T_textbox4.checkEmail = False
        Me.T_textbox4.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox4.combo_link = False
        Me.T_textbox4.combobox = Nothing
        Me.T_textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualifayBindingSource, "Qulifay", True))
        Me.T_textbox4.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.T_textbox4.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelText = ""
        Me.T_textbox4.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox4.Location = New System.Drawing.Point(220, 77)
        Me.T_textbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.T_textbox4.Name = "T_textbox4"
        Me.T_textbox4.numaricCheck = False
        Me.T_textbox4.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox4.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox4.Size = New System.Drawing.Size(228, 29)
        Me.T_textbox4.TabIndex = 22
        Me.T_textbox4.textColor = System.Drawing.Color.Black
        Me.T_textbox4.Textlengthcheck = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(456, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "المؤهل"
        '
        'Datacontrol2B1
        '
        Me.Datacontrol2B1.add_or_delete = ZeftawyTools.adddelete.add
        Me.Datacontrol2B1.BackColor = System.Drawing.Color.Transparent
        Me.Datacontrol2B1.bindingsouce = Nothing
        Me.Datacontrol2B1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Datacontrol2B1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Datacontrol2B1.buttonforecolor = System.Drawing.Color.Empty
        Me.Datacontrol2B1.Location = New System.Drawing.Point(124, 338)
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
        'QulifaySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.CancelButton = Me.CloosBtn
        Me.ClientSize = New System.Drawing.Size(591, 589)
        Me.Controls.Add(Me.Datacontrol2B1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_textbox3)
        Me.Controls.Add(Me.T_textbox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.T_button1)
        Me.Controls.Add(Me.Gam3iaDataGridView)
        Me.Controls.Add(Me.NewGrb)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MyFormStartPossition = ZeftawyTools.myformstartP.iscenter
        Me.Name = "QulifaySearch"
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
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.T_textbox1, 0)
        Me.Controls.SetChildIndex(Me.T_textbox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Datacontrol2B1, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        CType(Me.Gam3iaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualifayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents QualifayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QualifayTableAdapter As Zera3a.mydataDataSetTableAdapters.QualifayTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NewGrb As System.Windows.Forms.GroupBox
    Friend WithEvents Datacontrol2B1 As ZeftawyTools.datacontrol2B
    Friend WithEvents T_textbox4 As ZeftawyTools.t_textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QulifayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nao3ea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Naow3iaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
