<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataEntery
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
        Dim PageNoLabel As System.Windows.Forms.Label
        Dim Da3waNoLabel As System.Windows.Forms.Label
        Dim JudgeyearLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DesationLabel As System.Windows.Forms.Label
        Dim NoOfDayLabel As System.Windows.Forms.Label
        Dim MonyLabel As System.Windows.Forms.Label
        Dim NotLabel As System.Windows.Forms.Label
        Dim DateofLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataEntery))
        Me.T_textbox1 = New ZeftawyTools.t_textbox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.HokmsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Asasy = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._10_6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HokmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.T_button1 = New ZeftawyTools.t_button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.T_textbox4 = New ZeftawyTools.t_textbox
        Me.Label3 = New System.Windows.Forms.Label
        Me.T_textbox3 = New ZeftawyTools.t_textbox
        Me.T_textbox2 = New ZeftawyTools.t_textbox
        Me.T_button4 = New ZeftawyTools.t_button
        Me.T_button2 = New ZeftawyTools.t_button
        Me.T_button3 = New ZeftawyTools.t_button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PageNoTextBox = New System.Windows.Forms.TextBox
        Me.Da3waNoTextBox = New System.Windows.Forms.TextBox
        Me.JudgeyearTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.DesationTextBox = New System.Windows.Forms.TextBox
        Me.NoOfDayTextBox = New System.Windows.Forms.TextBox
        Me.MonyTextBox = New System.Windows.Forms.TextBox
        Me.NotTextBox = New System.Windows.Forms.TextBox
        Me.DateofTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HokmsTableAdapter = New Zera3a.mydataDataSetTableAdapters.HokmsTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.T_button5 = New ZeftawyTools.t_button
        PageNoLabel = New System.Windows.Forms.Label
        Da3waNoLabel = New System.Windows.Forms.Label
        JudgeyearLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        DesationLabel = New System.Windows.Forms.Label
        NoOfDayLabel = New System.Windows.Forms.Label
        MonyLabel = New System.Windows.Forms.Label
        NotLabel = New System.Windows.Forms.Label
        DateofLabel1 = New System.Windows.Forms.Label
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HokmsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HokmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Controls.Add(Me.T_button4)
        Me.TitelBar.Size = New System.Drawing.Size(1036, 45)
        Me.TitelBar.Controls.SetChildIndex(Me.Titel, 0)
        Me.TitelBar.Controls.SetChildIndex(Me.T_button4, 0)
        Me.TitelBar.Controls.SetChildIndex(Me.CloosBtn, 0)
        Me.TitelBar.Controls.SetChildIndex(Me.Logo, 0)
        Me.TitelBar.Controls.SetChildIndex(Me.MinBtn, 0)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(993, 3)
        Me.Logo.Size = New System.Drawing.Size(42, 38)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(12, 51)
        Me.massegBoxFormat.Size = New System.Drawing.Size(14, 13)
        '
        'MsgText
        '
        Me.MsgText.Location = New System.Drawing.Point(23, 43)
        '
        'MsgTilteBar
        '
        Me.MsgTilteBar.Size = New System.Drawing.Size(14, 31)
        '
        'msgTitl
        '
        Me.msgTitl.Location = New System.Drawing.Point(-59, 0)
        '
        'MsgT_Button
        '
        Me.MsgT_Button.Location = New System.Drawing.Point(-32, 93)
        Me.MsgT_Button.Size = New System.Drawing.Size(94, 0)
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(920, 8)
        Me.Titel.Size = New System.Drawing.Size(151, 24)
        Me.Titel.Text = "ادخال بيانات الاحكام"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(116, 429)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(-16, 129)
        Me.T_button.Size = New System.Drawing.Size(14, 13)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'MinBtn
        '
        Me.MinBtn.Location = New System.Drawing.Point(50, -6)
        Me.MinBtn.Size = New System.Drawing.Size(46, 45)
        '
        'CloosBtn
        '
        Me.CloosBtn.Location = New System.Drawing.Point(3, -6)
        Me.CloosBtn.Size = New System.Drawing.Size(46, 45)
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(3, 70)
        Me.T_textbox.Size = New System.Drawing.Size(12, 27)
        '
        'PageNoLabel
        '
        PageNoLabel.AutoSize = True
        PageNoLabel.Location = New System.Drawing.Point(753, 26)
        PageNoLabel.Name = "PageNoLabel"
        PageNoLabel.Size = New System.Drawing.Size(105, 26)
        PageNoLabel.TabIndex = 18
        PageNoLabel.Text = "رقم الصفحة"
        '
        'Da3waNoLabel
        '
        Da3waNoLabel.AutoSize = True
        Da3waNoLabel.Location = New System.Drawing.Point(146, 26)
        Da3waNoLabel.Name = "Da3waNoLabel"
        Da3waNoLabel.Size = New System.Drawing.Size(95, 26)
        Da3waNoLabel.TabIndex = 20
        Da3waNoLabel.Text = "رقم الدعوة"
        '
        'JudgeyearLabel
        '
        JudgeyearLabel.AutoSize = True
        JudgeyearLabel.Location = New System.Drawing.Point(753, 78)
        JudgeyearLabel.Name = "JudgeyearLabel"
        JudgeyearLabel.Size = New System.Drawing.Size(129, 26)
        JudgeyearLabel.TabIndex = 22
        JudgeyearLabel.Text = "السنة القضائية"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(581, 29)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(53, 26)
        NameLabel.TabIndex = 24
        NameLabel.Text = "الاسم"
        '
        'DesationLabel
        '
        DesationLabel.AutoSize = True
        DesationLabel.Location = New System.Drawing.Point(552, 84)
        DesationLabel.Name = "DesationLabel"
        DesationLabel.Size = New System.Drawing.Size(88, 26)
        DesationLabel.TabIndex = 26
        DesationLabel.Text = "رقم القرار"
        '
        'NoOfDayLabel
        '
        NoOfDayLabel.AutoSize = True
        NoOfDayLabel.Location = New System.Drawing.Point(155, 84)
        NoOfDayLabel.Name = "NoOfDayLabel"
        NoOfDayLabel.Size = New System.Drawing.Size(86, 26)
        NoOfDayLabel.TabIndex = 30
        NoOfDayLabel.Text = "عدد الايام"
        '
        'MonyLabel
        '
        MonyLabel.AutoSize = True
        MonyLabel.Location = New System.Drawing.Point(767, 119)
        MonyLabel.Name = "MonyLabel"
        MonyLabel.Size = New System.Drawing.Size(57, 26)
        MonyLabel.TabIndex = 32
        MonyLabel.Text = "المبلغ"
        '
        'NotLabel
        '
        NotLabel.AutoSize = True
        NotLabel.Location = New System.Drawing.Point(552, 125)
        NotLabel.Name = "NotLabel"
        NotLabel.Size = New System.Drawing.Size(83, 26)
        NotLabel.TabIndex = 34
        NotLabel.Text = "ملاحظات"
        '
        'DateofLabel1
        '
        DateofLabel1.AutoSize = True
        DateofLabel1.Location = New System.Drawing.Point(376, 78)
        DateofLabel1.Name = "DateofLabel1"
        DateofLabel1.Size = New System.Drawing.Size(66, 26)
        DateofLabel1.TabIndex = 35
        DateofLabel1.Text = "التاريخ"
        '
        'T_textbox1
        '
        Me.T_textbox1.checkEmail = False
        Me.T_textbox1.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox1.combo_link = False
        Me.T_textbox1.combobox = Nothing
        Me.T_textbox1.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox1.LabelText = "مكتبة الزفتاوي"
        Me.T_textbox1.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox1.Location = New System.Drawing.Point(6, 16)
        Me.T_textbox1.Name = "T_textbox1"
        Me.T_textbox1.numaricCheck = True
        Me.T_textbox1.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox1.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox1.Size = New System.Drawing.Size(106, 30)
        Me.T_textbox1.TabIndex = 10
        Me.T_textbox1.Text = "0"
        Me.T_textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox1.textColor = System.Drawing.Color.Black
        Me.T_textbox1.Textlengthcheck = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.T_textbox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(179, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 58)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "رقم الصفحة"
        '
        'HokmsDataGridView
        '
        Me.HokmsDataGridView.AutoGenerateColumns = False
        Me.HokmsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HokmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HokmsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.Asasy, Me._10_1, Me._10_2, Me._10_3, Me._10_4, Me._10_5, Me._10_6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10})
        Me.HokmsDataGridView.DataSource = Me.HokmsBindingSource
        Me.HokmsDataGridView.Location = New System.Drawing.Point(3, 213)
        Me.HokmsDataGridView.Name = "HokmsDataGridView"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Simplified Arabic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HokmsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.HokmsDataGridView.Size = New System.Drawing.Size(1021, 380)
        Me.HokmsDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PageNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "رقم الصفحة"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Da3waNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "رقم الدعوى"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Judgeyear"
        Me.DataGridViewTextBoxColumn4.HeaderText = "سنة الحكم"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "الاسم"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 400
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NoOfDay"
        Me.DataGridViewTextBoxColumn8.HeaderText = "عدد الايام"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Asasy
        '
        Me.Asasy.DataPropertyName = "Asasy"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Asasy.DefaultCellStyle = DataGridViewCellStyle1
        Me.Asasy.HeaderText = "اساسي"
        Me.Asasy.Name = "Asasy"
        Me.Asasy.Width = 150
        '
        '_10_1
        '
        Me._10_1.DataPropertyName = "_10_1"
        Me._10_1.HeaderText = "1"
        Me._10_1.Name = "_10_1"
        Me._10_1.Width = 150
        '
        '_10_2
        '
        Me._10_2.DataPropertyName = "_10_2"
        Me._10_2.HeaderText = "2"
        Me._10_2.Name = "_10_2"
        Me._10_2.Width = 150
        '
        '_10_3
        '
        Me._10_3.DataPropertyName = "_10_3"
        Me._10_3.HeaderText = "3"
        Me._10_3.Name = "_10_3"
        Me._10_3.Width = 150
        '
        '_10_4
        '
        Me._10_4.DataPropertyName = "_10_4"
        Me._10_4.HeaderText = "4"
        Me._10_4.Name = "_10_4"
        Me._10_4.Width = 150
        '
        '_10_5
        '
        Me._10_5.DataPropertyName = "_10_5"
        Me._10_5.HeaderText = "5"
        Me._10_5.Name = "_10_5"
        Me._10_5.Width = 150
        '
        '_10_6
        '
        Me._10_6.DataPropertyName = "_10_6"
        Me._10_6.HeaderText = "6"
        Me._10_6.Name = "_10_6"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mony"
        Me.DataGridViewTextBoxColumn9.HeaderText = "المبلغ"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Desation"
        Me.DataGridViewTextBoxColumn6.HeaderText = "رقم القرار"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Dateof"
        Me.DataGridViewTextBoxColumn7.HeaderText = "التاريخ"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Not"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ملاحظات"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 300
        '
        'HokmsBindingSource
        '
        Me.HokmsBindingSource.DataMember = "Hokms"
        Me.HokmsBindingSource.DataSource = Me.MydataDataSet
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
        Me.T_button1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button1.font_color = System.Drawing.Color.Black
        Me.T_button1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button1.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button1.Location = New System.Drawing.Point(197, 75)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "حفظ"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(97, 47)
        Me.T_button1.TabIndex = 12
        Me.T_button1.Text = "حفظ"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.T_textbox4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.T_textbox3)
        Me.GroupBox2.Controls.Add(Me.T_textbox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 149)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "الاسم"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "رقم الدعوى"
        '
        'T_textbox4
        '
        Me.T_textbox4.checkEmail = False
        Me.T_textbox4.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox4.combo_link = False
        Me.T_textbox4.combobox = Nothing
        Me.T_textbox4.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.ForeColor = System.Drawing.Color.Black
        Me.T_textbox4.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox4.LabelText = ""
        Me.T_textbox4.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox4.Location = New System.Drawing.Point(14, 108)
        Me.T_textbox4.Name = "T_textbox4"
        Me.T_textbox4.numaricCheck = True
        Me.T_textbox4.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox4.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox4.Size = New System.Drawing.Size(315, 30)
        Me.T_textbox4.TabIndex = 14
        Me.T_textbox4.Text = "0"
        Me.T_textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox4.textColor = System.Drawing.Color.Black
        Me.T_textbox4.Textlengthcheck = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "رقم الصفحة"
        '
        'T_textbox3
        '
        Me.T_textbox3.checkEmail = False
        Me.T_textbox3.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox3.combo_link = False
        Me.T_textbox3.combobox = Nothing
        Me.T_textbox3.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.ForeColor = System.Drawing.Color.Black
        Me.T_textbox3.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox3.LabelText = ""
        Me.T_textbox3.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox3.Location = New System.Drawing.Point(17, 59)
        Me.T_textbox3.Name = "T_textbox3"
        Me.T_textbox3.numaricCheck = True
        Me.T_textbox3.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox3.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox3.Size = New System.Drawing.Size(315, 30)
        Me.T_textbox3.TabIndex = 12
        Me.T_textbox3.Text = "0"
        Me.T_textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox3.textColor = System.Drawing.Color.Black
        Me.T_textbox3.Textlengthcheck = 0
        '
        'T_textbox2
        '
        Me.T_textbox2.checkEmail = False
        Me.T_textbox2.checkNolength = ZeftawyTools.chekcno.None
        Me.T_textbox2.combo_link = False
        Me.T_textbox2.combobox = Nothing
        Me.T_textbox2.enter_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.ForeColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelColor = System.Drawing.Color.Gray
        Me.T_textbox2.LabelText = ""
        Me.T_textbox2.leave_color = System.Drawing.SystemColors.Window
        Me.T_textbox2.Location = New System.Drawing.Point(14, 22)
        Me.T_textbox2.Name = "T_textbox2"
        Me.T_textbox2.numaricCheck = False
        Me.T_textbox2.read_only_color = System.Drawing.Color.DodgerBlue
        Me.T_textbox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T_textbox2.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.T_textbox2.Size = New System.Drawing.Size(315, 30)
        Me.T_textbox2.TabIndex = 10
        Me.T_textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.T_textbox2.textColor = System.Drawing.Color.Black
        Me.T_textbox2.Textlengthcheck = 0
        '
        'T_button4
        '
        Me.T_button4.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button4.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button4.CheckBox = False
        Me.T_button4.Checked = False
        Me.T_button4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button4.font_color = System.Drawing.Color.Black
        Me.T_button4.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button4.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button4.Location = New System.Drawing.Point(102, -4)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "ترحيل حقول"
        Me.T_button4.meAutoSize = False
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(178, 47)
        Me.T_button4.TabIndex = 16
        Me.T_button4.Text = "ترحيل حقول"
        Me.T_button4.UseDefFontInTxtShap = True
        Me.T_button4.UseDefultButton = False
        Me.T_button4.UseVisualStyleBackColor = True
        Me.T_button4.Visible = False
        '
        'T_button2
        '
        Me.T_button2.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button2.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button2.CheckBox = False
        Me.T_button2.Checked = False
        Me.T_button2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button2.font_color = System.Drawing.Color.Black
        Me.T_button2.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button2.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button2.Location = New System.Drawing.Point(6, 75)
        Me.T_button2.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button2.me_text = "كل السجلات"
        Me.T_button2.meAutoSize = False
        Me.T_button2.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button2.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button2.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button2.Name = "T_button2"
        Me.T_button2.Size = New System.Drawing.Size(170, 47)
        Me.T_button2.TabIndex = 14
        Me.T_button2.Text = "كل السجلات"
        Me.T_button2.UseDefFontInTxtShap = True
        Me.T_button2.UseDefultButton = False
        Me.T_button2.UseVisualStyleBackColor = True
        '
        'T_button3
        '
        Me.T_button3.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button3.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button3.CheckBox = False
        Me.T_button3.Checked = False
        Me.T_button3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button3.font_color = System.Drawing.Color.Black
        Me.T_button3.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button3.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button3.Location = New System.Drawing.Point(300, 75)
        Me.T_button3.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button3.me_text = "جديد"
        Me.T_button3.meAutoSize = False
        Me.T_button3.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button3.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button3.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button3.Name = "T_button3"
        Me.T_button3.Size = New System.Drawing.Size(97, 47)
        Me.T_button3.TabIndex = 15
        Me.T_button3.Text = "جديد"
        Me.T_button3.UseDefFontInTxtShap = True
        Me.T_button3.UseDefultButton = False
        Me.T_button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.T_button5)
        Me.GroupBox3.Controls.Add(Me.T_button2)
        Me.GroupBox3.Controls.Add(Me.T_button3)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.T_button1)
        Me.GroupBox3.Location = New System.Drawing.Point(488, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 133)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'PageNoTextBox
        '
        Me.PageNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "PageNo", True))
        Me.PageNoTextBox.ForeColor = System.Drawing.Color.Green
        Me.PageNoTextBox.Location = New System.Drawing.Point(646, 20)
        Me.PageNoTextBox.Name = "PageNoTextBox"
        Me.PageNoTextBox.ReadOnly = True
        Me.PageNoTextBox.Size = New System.Drawing.Size(101, 35)
        Me.PageNoTextBox.TabIndex = 19
        '
        'Da3waNoTextBox
        '
        Me.Da3waNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Da3waNo", True))
        Me.Da3waNoTextBox.ForeColor = System.Drawing.Color.Green
        Me.Da3waNoTextBox.Location = New System.Drawing.Point(17, 22)
        Me.Da3waNoTextBox.Name = "Da3waNoTextBox"
        Me.Da3waNoTextBox.ReadOnly = True
        Me.Da3waNoTextBox.Size = New System.Drawing.Size(123, 35)
        Me.Da3waNoTextBox.TabIndex = 21
        '
        'JudgeyearTextBox
        '
        Me.JudgeyearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Judgeyear", True))
        Me.JudgeyearTextBox.ForeColor = System.Drawing.Color.Green
        Me.JudgeyearTextBox.Location = New System.Drawing.Point(646, 69)
        Me.JudgeyearTextBox.Name = "JudgeyearTextBox"
        Me.JudgeyearTextBox.ReadOnly = True
        Me.JudgeyearTextBox.Size = New System.Drawing.Size(101, 35)
        Me.JudgeyearTextBox.TabIndex = 23
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Name", True))
        Me.NameTextBox.ForeColor = System.Drawing.Color.Green
        Me.NameTextBox.Location = New System.Drawing.Point(247, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(328, 35)
        Me.NameTextBox.TabIndex = 25
        '
        'DesationTextBox
        '
        Me.DesationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Desation", True))
        Me.DesationTextBox.ForeColor = System.Drawing.Color.Green
        Me.DesationTextBox.Location = New System.Drawing.Point(448, 78)
        Me.DesationTextBox.Name = "DesationTextBox"
        Me.DesationTextBox.ReadOnly = True
        Me.DesationTextBox.Size = New System.Drawing.Size(96, 35)
        Me.DesationTextBox.TabIndex = 27
        '
        'NoOfDayTextBox
        '
        Me.NoOfDayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "NoOfDay", True))
        Me.NoOfDayTextBox.ForeColor = System.Drawing.Color.Green
        Me.NoOfDayTextBox.Location = New System.Drawing.Point(14, 75)
        Me.NoOfDayTextBox.Name = "NoOfDayTextBox"
        Me.NoOfDayTextBox.ReadOnly = True
        Me.NoOfDayTextBox.Size = New System.Drawing.Size(123, 35)
        Me.NoOfDayTextBox.TabIndex = 31
        '
        'MonyTextBox
        '
        Me.MonyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Mony", True))
        Me.MonyTextBox.ForeColor = System.Drawing.Color.Green
        Me.MonyTextBox.Location = New System.Drawing.Point(646, 116)
        Me.MonyTextBox.Name = "MonyTextBox"
        Me.MonyTextBox.ReadOnly = True
        Me.MonyTextBox.Size = New System.Drawing.Size(101, 35)
        Me.MonyTextBox.TabIndex = 33
        '
        'NotTextBox
        '
        Me.NotTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Not", True))
        Me.NotTextBox.ForeColor = System.Drawing.Color.Green
        Me.NotTextBox.Location = New System.Drawing.Point(14, 116)
        Me.NotTextBox.Name = "NotTextBox"
        Me.NotTextBox.ReadOnly = True
        Me.NotTextBox.Size = New System.Drawing.Size(527, 35)
        Me.NotTextBox.TabIndex = 35
        '
        'DateofTextBox
        '
        Me.DateofTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HokmsBindingSource, "Dateof", True))
        Me.DateofTextBox.ForeColor = System.Drawing.Color.Green
        Me.DateofTextBox.Location = New System.Drawing.Point(247, 75)
        Me.DateofTextBox.Name = "DateofTextBox"
        Me.DateofTextBox.ReadOnly = True
        Me.DateofTextBox.Size = New System.Drawing.Size(123, 35)
        Me.DateofTextBox.TabIndex = 36
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.NotTextBox)
        Me.GroupBox4.Controls.Add(NotLabel)
        Me.GroupBox4.Controls.Add(Me.MonyTextBox)
        Me.GroupBox4.Controls.Add(MonyLabel)
        Me.GroupBox4.Controls.Add(Me.NoOfDayTextBox)
        Me.GroupBox4.Controls.Add(NoOfDayLabel)
        Me.GroupBox4.Controls.Add(DateofLabel1)
        Me.GroupBox4.Controls.Add(PageNoLabel)
        Me.GroupBox4.Controls.Add(Me.DateofTextBox)
        Me.GroupBox4.Controls.Add(Me.PageNoTextBox)
        Me.GroupBox4.Controls.Add(DesationLabel)
        Me.GroupBox4.Controls.Add(Me.NameTextBox)
        Me.GroupBox4.Controls.Add(Me.DesationTextBox)
        Me.GroupBox4.Controls.Add(NameLabel)
        Me.GroupBox4.Controls.Add(Me.JudgeyearTextBox)
        Me.GroupBox4.Controls.Add(JudgeyearLabel)
        Me.GroupBox4.Controls.Add(Da3waNoLabel)
        Me.GroupBox4.Controls.Add(Me.Da3waNoTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 611)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(909, 157)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'HokmsTableAdapter
        '
        Me.HokmsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpDataTableAdapter = Nothing
        Me.TableAdapterManager.FinanceDegreeTableAdapter = Nothing
        Me.TableAdapterManager.Gam3iaTableAdapter = Nothing
        Me.TableAdapterManager.HokmsTableAdapter = Me.HokmsTableAdapter
        Me.TableAdapterManager.JobTableAdapter = Nothing
        Me.TableAdapterManager.QualifayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Zera3a.mydataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_button5
        '
        Me.T_button5.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button5.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button5.CheckBox = False
        Me.T_button5.Checked = False
        Me.T_button5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button5.font_color = System.Drawing.Color.Black
        Me.T_button5.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button5.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button5.Location = New System.Drawing.Point(22, 16)
        Me.T_button5.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button5.me_text = "طباعة"
        Me.T_button5.meAutoSize = False
        Me.T_button5.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button5.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button5.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button5.Name = "T_button5"
        Me.T_button5.Size = New System.Drawing.Size(130, 47)
        Me.T_button5.TabIndex = 17
        Me.T_button5.Text = "طباعة"
        Me.T_button5.UseDefFontInTxtShap = True
        Me.T_button5.UseDefultButton = False
        Me.T_button5.UseVisualStyleBackColor = True
        '
        'DataEntery
        '
        Me.AnimationSpeed = 100
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.HokmsDataGridView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataEntery"
        Me.Opacity = 1
        Me.Text = "ادخال بيانات الاحكام"
        Me.TiteText = "ادخال بيانات الاحكام"
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.HokmsDataGridView, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.HokmsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HokmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_textbox1 As ZeftawyTools.t_textbox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents HokmsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HokmsTableAdapter As Zera3a.mydataDataSetTableAdapters.HokmsTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HokmsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents T_textbox2 As ZeftawyTools.t_textbox
    Friend WithEvents T_button2 As ZeftawyTools.t_button
    Friend WithEvents T_button3 As ZeftawyTools.t_button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents T_textbox4 As ZeftawyTools.t_textbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T_textbox3 As ZeftawyTools.t_textbox
    Friend WithEvents PageNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Da3waNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JudgeyearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoOfDayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateofTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents T_button4 As ZeftawyTools.t_button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asasy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _10_6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T_button5 As ZeftawyTools.t_button
End Class
