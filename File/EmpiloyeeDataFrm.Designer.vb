Imports ZeftawyTools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpiloyeeDataFrm
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
        Dim ManegeLabel As System.Windows.Forms.Label
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim EmpNmeLabel As System.Windows.Forms.Label
        Dim NationalIDLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim SocialCaseLabel As System.Windows.Forms.Label
        Dim QulifcathionLabel As System.Windows.Forms.Label
        Dim EMpDescribeLabel As System.Windows.Forms.Label
        Dim AdreeseLabel As System.Windows.Forms.Label
        Dim PactheDayLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.T_button4 = New ZeftawyTools.t_button
        Me.T_button3 = New ZeftawyTools.t_button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.T_button2 = New ZeftawyTools.t_button
        Me.T_button1 = New ZeftawyTools.t_button
        Me.Visacasecom = New System.Windows.Forms.ComboBox
        Me.T_button5 = New ZeftawyTools.t_button
        Me.Gam3SearchTxt = New ZeftawyTools.t_textbox
        Me.NmaeSearchTxt = New ZeftawyTools.t_textbox
        Me.Label1 = New System.Windows.Forms.Label
        Me.EmpDataDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.isIDReght = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Degree = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Naow3ia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMpDescribe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PactheDay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FinanceDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.menhaa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FamilyNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorNameId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MydataDataSet = New Zera3a.mydataDataSet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Errortxt = New ZeftawyTools.t_textbox
        Me.Degreetxt = New ZeftawyTools.t_textbox
        Me.naw3iaTxt = New ZeftawyTools.t_textbox
        Me.m3ashDatetxt = New ZeftawyTools.t_textbox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.QualifcationTxt = New ZeftawyTools.t_textbox
        Me.jopTxt = New ZeftawyTools.t_textbox
        Me.ParthDatetxt = New ZeftawyTools.t_textbox
        Me.Addresstxt = New ZeftawyTools.t_textbox
        Me.Gsm3iatxt = New ZeftawyTools.t_textbox
        Me.EmpIDtxt = New ZeftawyTools.t_textbox
        Me.EmpNametxt = New ZeftawyTools.t_textbox
        Me.EmpCodeTxt = New ZeftawyTools.t_textbox
        Me.DataPostion1 = New ZeftawyTools.DataPostion
        Me.Datacontrol3B1 = New ZeftawyTools.datacontrol3B
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EmpDataTableAdapter = New Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter
        Me.TableAdapterManager = New Zera3a.mydataDataSetTableAdapters.TableAdapterManager
        Me.helpLable = New System.Windows.Forms.TextBox
        ManegeLabel = New System.Windows.Forms.Label
        EmpIDLabel = New System.Windows.Forms.Label
        EmpNmeLabel = New System.Windows.Forms.Label
        NationalIDLabel = New System.Windows.Forms.Label
        SexLabel = New System.Windows.Forms.Label
        SocialCaseLabel = New System.Windows.Forms.Label
        QulifcathionLabel = New System.Windows.Forms.Label
        EMpDescribeLabel = New System.Windows.Forms.Label
        AdreeseLabel = New System.Windows.Forms.Label
        PactheDayLabel = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(1036, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(1004, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(3, 329)
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
        Me.Titel.Location = New System.Drawing.Point(949, 7)
        Me.Titel.Size = New System.Drawing.Size(175, 24)
        Me.Titel.Text = "بيانات العاملين الاساسية"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(611, 274)
        Me.Labelbox.Size = New System.Drawing.Size(0, 24)
        Me.Labelbox.Text = ""
        '
        'T_button
        '
        Me.T_button.Location = New System.Drawing.Point(72, 50)
        Me.T_button.Size = New System.Drawing.Size(10, 10)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        Me.T_button.Visible = False
        '
        'T_textbox
        '
        Me.T_textbox.Location = New System.Drawing.Point(3, 235)
        Me.T_textbox.Size = New System.Drawing.Size(10, 27)
        '
        'ManegeLabel
        '
        ManegeLabel.AutoSize = True
        ManegeLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManegeLabel.Location = New System.Drawing.Point(224, 21)
        ManegeLabel.Name = "ManegeLabel"
        ManegeLabel.Size = New System.Drawing.Size(67, 19)
        ManegeLabel.TabIndex = 12
        ManegeLabel.Text = "الجمعية"
        '
        'EmpIDLabel
        '
        EmpIDLabel.AutoSize = True
        EmpIDLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpIDLabel.Location = New System.Drawing.Point(883, 21)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(100, 19)
        EmpIDLabel.TabIndex = 13
        EmpIDLabel.Text = "كود الموظف"
        '
        'EmpNmeLabel
        '
        EmpNmeLabel.AutoSize = True
        EmpNmeLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpNmeLabel.Location = New System.Drawing.Point(668, 15)
        EmpNmeLabel.Name = "EmpNmeLabel"
        EmpNmeLabel.Size = New System.Drawing.Size(54, 19)
        EmpNmeLabel.TabIndex = 14
        EmpNmeLabel.Text = "الاسم"
        '
        'NationalIDLabel
        '
        NationalIDLabel.AutoSize = True
        NationalIDLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NationalIDLabel.Location = New System.Drawing.Point(235, 63)
        NationalIDLabel.Name = "NationalIDLabel"
        NationalIDLabel.Size = New System.Drawing.Size(107, 19)
        NationalIDLabel.TabIndex = 15
        NationalIDLabel.Text = "الرقم القومي"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexLabel.Location = New System.Drawing.Point(894, 63)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(44, 19)
        SexLabel.TabIndex = 17
        SexLabel.Text = "النوع"
        '
        'SocialCaseLabel
        '
        SocialCaseLabel.AutoSize = True
        SocialCaseLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SocialCaseLabel.Location = New System.Drawing.Point(589, 60)
        SocialCaseLabel.Name = "SocialCaseLabel"
        SocialCaseLabel.Size = New System.Drawing.Size(133, 19)
        SocialCaseLabel.TabIndex = 19
        SocialCaseLabel.Text = "الحالة الاجتماعية"
        '
        'QulifcathionLabel
        '
        QulifcathionLabel.AutoSize = True
        QulifcathionLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QulifcathionLabel.Location = New System.Drawing.Point(244, 144)
        QulifcathionLabel.Name = "QulifcathionLabel"
        QulifcathionLabel.Size = New System.Drawing.Size(63, 19)
        QulifcathionLabel.TabIndex = 27
        QulifcathionLabel.Text = "المؤهل"
        '
        'EMpDescribeLabel
        '
        EMpDescribeLabel.AutoSize = True
        EMpDescribeLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EMpDescribeLabel.Location = New System.Drawing.Point(506, 180)
        EMpDescribeLabel.Name = "EMpDescribeLabel"
        EMpDescribeLabel.Size = New System.Drawing.Size(128, 19)
        EMpDescribeLabel.TabIndex = 29
        EMpDescribeLabel.Text = "الوصف الوظيفي"
        '
        'AdreeseLabel
        '
        AdreeseLabel.AutoSize = True
        AdreeseLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdreeseLabel.Location = New System.Drawing.Point(880, 103)
        AdreeseLabel.Name = "AdreeseLabel"
        AdreeseLabel.Size = New System.Drawing.Size(58, 19)
        AdreeseLabel.TabIndex = 35
        AdreeseLabel.Text = "العنوان"
        '
        'PactheDayLabel
        '
        PactheDayLabel.AutoSize = True
        PactheDayLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PactheDayLabel.Location = New System.Drawing.Point(867, 141)
        PactheDayLabel.Name = "PactheDayLabel"
        PactheDayLabel.Size = New System.Drawing.Size(96, 19)
        PactheDayLabel.TabIndex = 37
        PactheDayLabel.Text = "تاريخ الميلاد"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(529, 141)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 19)
        Label3.TabIndex = 53
        Label3.Text = "تاريخ المعاش"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(250, 179)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 19)
        Label2.TabIndex = 57
        Label2.Text = "الدرجة"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(843, 185)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(140, 19)
        Label4.TabIndex = 55
        Label4.Text = "المجموعة النوعية"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(245, 106)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(62, 19)
        Label5.TabIndex = 59
        Label5.Text = "الاخطاء"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.T_button4)
        Me.GroupBox1.Controls.Add(Me.T_button3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Gam3SearchTxt)
        Me.GroupBox1.Controls.Add(Me.NmaeSearchTxt)
        Me.GroupBox1.Font = New System.Drawing.Font("Arabic Transparent", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1021, 75)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'T_button4
        '
        Me.T_button4.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button4.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button4.CheckBox = False
        Me.T_button4.Checked = False
        Me.T_button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button4.font_color = System.Drawing.Color.Black
        Me.T_button4.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button4.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button4.Location = New System.Drawing.Point(1, 28)
        Me.T_button4.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button4.me_text = "طباعة مفتوحة"
        Me.T_button4.meAutoSize = False
        Me.T_button4.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button4.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button4.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button4.Name = "T_button4"
        Me.T_button4.Size = New System.Drawing.Size(115, 33)
        Me.T_button4.TabIndex = 21
        Me.T_button4.Text = "طباعة مفتوحة"
        Me.T_button4.UseDefFontInTxtShap = True
        Me.T_button4.UseDefultButton = False
        Me.T_button4.UseVisualStyleBackColor = True
        '
        'T_button3
        '
        Me.T_button3.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button3.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button3.CheckBox = False
        Me.T_button3.Checked = False
        Me.T_button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button3.font_color = System.Drawing.Color.Black
        Me.T_button3.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button3.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button3.Location = New System.Drawing.Point(790, 28)
        Me.T_button3.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button3.me_text = "المنقولين"
        Me.T_button3.meAutoSize = False
        Me.T_button3.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button3.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button3.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button3.Name = "T_button3"
        Me.T_button3.Size = New System.Drawing.Size(93, 33)
        Me.T_button3.TabIndex = 20
        Me.T_button3.Text = "المنقولين"
        Me.T_button3.UseDefFontInTxtShap = True
        Me.T_button3.UseDefultButton = False
        Me.T_button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.T_button2)
        Me.GroupBox2.Controls.Add(Me.T_button1)
        Me.GroupBox2.Controls.Add(Me.Visacasecom)
        Me.GroupBox2.Controls.Add(Me.T_button5)
        Me.GroupBox2.Location = New System.Drawing.Point(116, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 63)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'T_button2
        '
        Me.T_button2.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button2.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button2.CheckBox = False
        Me.T_button2.Checked = False
        Me.T_button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button2.font_color = System.Drawing.Color.Black
        Me.T_button2.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button2.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button2.Location = New System.Drawing.Point(6, 21)
        Me.T_button2.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button2.me_text = "الاسم خطا"
        Me.T_button2.meAutoSize = False
        Me.T_button2.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button2.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button2.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button2.Name = "T_button2"
        Me.T_button2.Size = New System.Drawing.Size(104, 33)
        Me.T_button2.TabIndex = 20
        Me.T_button2.Text = "الاسم خطا"
        Me.T_button2.UseDefFontInTxtShap = True
        Me.T_button2.UseDefultButton = False
        Me.T_button2.UseVisualStyleBackColor = True
        '
        'T_button1
        '
        Me.T_button1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button1.CheckBox = False
        Me.T_button1.Checked = False
        Me.T_button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button1.font_color = System.Drawing.Color.Black
        Me.T_button1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button1.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button1.Location = New System.Drawing.Point(116, 20)
        Me.T_button1.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button1.me_text = "الرقم القومي خطأ"
        Me.T_button1.meAutoSize = False
        Me.T_button1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button1.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button1.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button1.Name = "T_button1"
        Me.T_button1.Size = New System.Drawing.Size(155, 33)
        Me.T_button1.TabIndex = 19
        Me.T_button1.Text = "الرقم القومي خطأ"
        Me.T_button1.UseDefFontInTxtShap = True
        Me.T_button1.UseDefultButton = False
        Me.T_button1.UseVisualStyleBackColor = True
        '
        'Visacasecom
        '
        Me.Visacasecom.FormattingEnabled = True
        Me.Visacasecom.Location = New System.Drawing.Point(391, 20)
        Me.Visacasecom.Name = "Visacasecom"
        Me.Visacasecom.Size = New System.Drawing.Size(126, 30)
        Me.Visacasecom.TabIndex = 1
        '
        'T_button5
        '
        Me.T_button5.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.T_button5.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.T_button5.CheckBox = False
        Me.T_button5.Checked = False
        Me.T_button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_button5.font_color = System.Drawing.Color.Black
        Me.T_button5.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.T_button5.font_color_Mousemove = System.Drawing.Color.White
        Me.T_button5.Location = New System.Drawing.Point(277, 20)
        Me.T_button5.MakeMeAs = ZeftawyTools.Shap.مستطيل
        Me.T_button5.me_text = "لم يطبع فيزا"
        Me.T_button5.meAutoSize = False
        Me.T_button5.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.T_button5.meloodserruonding_color = System.Drawing.Color.MidnightBlue
        Me.T_button5.mousemove_center_color = System.Drawing.Color.Lime
        Me.T_button5.Name = "T_button5"
        Me.T_button5.Size = New System.Drawing.Size(109, 33)
        Me.T_button5.TabIndex = 18
        Me.T_button5.Text = "لم يطبع فيزا"
        Me.T_button5.UseDefFontInTxtShap = True
        Me.T_button5.UseDefultButton = False
        Me.T_button5.UseVisualStyleBackColor = True
        '
        'Gam3SearchTxt
        '
        Me.Gam3SearchTxt.checkEmail = False
        Me.Gam3SearchTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Gam3SearchTxt.combo_link = False
        Me.Gam3SearchTxt.combobox = Nothing
        Me.Gam3SearchTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Gam3SearchTxt.ForeColor = System.Drawing.Color.Gray
        Me.Gam3SearchTxt.LabelColor = System.Drawing.Color.Gray
        Me.Gam3SearchTxt.LabelText = "اسم الجمعية "
        Me.Gam3SearchTxt.leave_color = System.Drawing.SystemColors.Window
        Me.Gam3SearchTxt.Location = New System.Drawing.Point(889, 31)
        Me.Gam3SearchTxt.Name = "Gam3SearchTxt"
        Me.Gam3SearchTxt.numaricCheck = False
        Me.Gam3SearchTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Gam3SearchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Gam3SearchTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Gam3SearchTxt.Size = New System.Drawing.Size(126, 30)
        Me.Gam3SearchTxt.TabIndex = 2
        Me.Gam3SearchTxt.Text = "اسم الجمعية "
        Me.Gam3SearchTxt.textColor = System.Drawing.Color.Black
        Me.Gam3SearchTxt.Textlengthcheck = 0
        '
        'NmaeSearchTxt
        '
        Me.NmaeSearchTxt.checkEmail = False
        Me.NmaeSearchTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.NmaeSearchTxt.combo_link = False
        Me.NmaeSearchTxt.combobox = Nothing
        Me.NmaeSearchTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.NmaeSearchTxt.ForeColor = System.Drawing.Color.Gray
        Me.NmaeSearchTxt.LabelColor = System.Drawing.Color.Gray
        Me.NmaeSearchTxt.LabelText = "ادخل البحث"
        Me.NmaeSearchTxt.leave_color = System.Drawing.SystemColors.Window
        Me.NmaeSearchTxt.Location = New System.Drawing.Point(637, 28)
        Me.NmaeSearchTxt.Name = "NmaeSearchTxt"
        Me.NmaeSearchTxt.numaricCheck = False
        Me.NmaeSearchTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.NmaeSearchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NmaeSearchTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.NmaeSearchTxt.Size = New System.Drawing.Size(147, 30)
        Me.NmaeSearchTxt.TabIndex = 0
        Me.NmaeSearchTxt.Text = "ادخل البحث"
        Me.NmaeSearchTxt.textColor = System.Drawing.Color.Black
        Me.NmaeSearchTxt.Textlengthcheck = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-21, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'EmpDataDataGridView
        '
        Me.EmpDataDataGridView.AutoGenerateColumns = False
        Me.EmpDataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.EmpDataDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EmpDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpDataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.isIDReght, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Degree, Me.Naow3ia, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn22, Me.EMpDescribe, Me.PactheDay, Me.FinanceDate, Me.menhaa, Me.FamilyNo, Me.ErrorNameId})
        Me.EmpDataDataGridView.DataSource = Me.EmpDataBindingSource
        Me.EmpDataDataGridView.Location = New System.Drawing.Point(0, 124)
        Me.EmpDataDataGridView.Name = "EmpDataDataGridView"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Simplified Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow
        Me.EmpDataDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.EmpDataDataGridView.Size = New System.Drawing.Size(1024, 289)
        Me.EmpDataDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Manege"
        Me.DataGridViewTextBoxColumn2.HeaderText = "الجمعية "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 103
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "كود الموظف"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 116
        '
        'isIDReght
        '
        Me.isIDReght.DataPropertyName = "isIDReght"
        Me.isIDReght.HeaderText = "حالة افيزا"
        Me.isIDReght.Name = "isIDReght"
        Me.isIDReght.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EmpNme"
        Me.DataGridViewTextBoxColumn4.HeaderText = "اسم الموظف"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 126
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NationalID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "الرقم القومي"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 14
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EmpDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "تاريخ التوظيف"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 127
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn8.HeaderText = "النوع"
        Me.DataGridViewTextBoxColumn8.Items.AddRange(New Object() {"1-ذكر", "2-انثى"})
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.Width = 72
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SocialCase"
        Me.DataGridViewTextBoxColumn9.HeaderText = "الحالة الاجتماعية"
        Me.DataGridViewTextBoxColumn9.Items.AddRange(New Object() {"1-اعزب", "2-متزوج", "3-مطلق", "4-ارمل"})
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn9.Width = 155
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FinaceDegree"
        Me.DataGridViewTextBoxColumn10.HeaderText = "الدرجة المالية"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"1-1-الوزير-تخصصى", "1-2-مساعد اول وزير-تخصصى", "1-3-مساعد وزير-تخصصى", "1-4-رئيس قطاع-تخصصى", "1-5-رئيس اداره مركزيه-تخصصى", "1-6-مدير عام-تخصصى", "2-7-كبير كتاب-مكتيى", "1-8-الدرجه الاولى-تخصصى", "2-8-الدرجه الاولى-مكتيى", "3-8-الدرجه الاولى-مهنى", "1-9-الدرجه التانيه-تخصصى", "2-9-الدرجه التانيه-مكتيى", "3-9-الدرجه التانيه-مهنى", "1-10-الدرجه الثالثه-تخصصى", "2-10-الدرجه الثالثه-مكتيى", "3-10-الدرجه الثالثه-مهنى", "4-10-الدرجه الثالثه-خدمات معاونه", "2-11-الدرجه الرابعه-مكتيى", "3-11-الدرجه الرابعه-مهنى", "4-11-الدرجه الرابعه-خدمات معاونه", "2-12-الدرجه الخامسه-مكتيى", "3-12-الدرجه الخامسه-مهنى", "4-12-الدرجه الخامسه-خدمات معاونه", "3-13-الدرجه السادسه-مهنى", "4-13-الدرجه السادسه-خدمات معاونه"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.Width = 131
        '
        'Degree
        '
        Me.Degree.DataPropertyName = "Degree"
        Me.Degree.HeaderText = "درجة"
        Me.Degree.Name = "Degree"
        Me.Degree.Width = 75
        '
        'Naow3ia
        '
        Me.Naow3ia.DataPropertyName = "Naow3ia"
        Me.Naow3ia.HeaderText = "نوعية"
        Me.Naow3ia.Name = "Naow3ia"
        Me.Naow3ia.Width = 77
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Adreese"
        Me.DataGridViewTextBoxColumn13.HeaderText = "العنوان"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 87
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Qulifcathion"
        Me.DataGridViewTextBoxColumn22.HeaderText = "المؤهل"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 92
        '
        'EMpDescribe
        '
        Me.EMpDescribe.DataPropertyName = "EMpDescribe"
        Me.EMpDescribe.HeaderText = "الوصف الوظيفي"
        Me.EMpDescribe.Name = "EMpDescribe"
        Me.EMpDescribe.Width = 143
        '
        'PactheDay
        '
        Me.PactheDay.DataPropertyName = "PactheDay"
        Me.PactheDay.HeaderText = "تاريخ الميلاد"
        Me.PactheDay.Name = "PactheDay"
        Me.PactheDay.Width = 117
        '
        'FinanceDate
        '
        Me.FinanceDate.DataPropertyName = "FinanceDate"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FinanceDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.FinanceDate.HeaderText = "تاريخ المعاش"
        Me.FinanceDate.Name = "FinanceDate"
        Me.FinanceDate.ReadOnly = True
        Me.FinanceDate.Width = 125
        '
        'menhaa
        '
        Me.menhaa.DataPropertyName = "menhaa"
        Me.menhaa.HeaderText = "طالب المنحة"
        Me.menhaa.Name = "menhaa"
        Me.menhaa.Width = 124
        '
        'FamilyNo
        '
        Me.FamilyNo.DataPropertyName = "FamilyNo"
        Me.FamilyNo.HeaderText = "عدد افراد الاسرة"
        Me.FamilyNo.Name = "FamilyNo"
        Me.FamilyNo.Width = 151
        '
        'ErrorNameId
        '
        Me.ErrorNameId.DataPropertyName = "ErrorNameId"
        Me.ErrorNameId.HeaderText = "الاخطاء"
        Me.ErrorNameId.Name = "ErrorNameId"
        Me.ErrorNameId.Width = 91
        '
        'EmpDataBindingSource
        '
        Me.EmpDataBindingSource.DataMember = "EmpData"
        Me.EmpDataBindingSource.DataSource = Me.MydataDataSet
        '
        'MydataDataSet
        '
        Me.MydataDataSet.DataSetName = "mydataDataSet"
        Me.MydataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Errortxt)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.Degreetxt)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.naw3iaTxt)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.m3ashDatetxt)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.QualifcationTxt)
        Me.GroupBox3.Controls.Add(Me.jopTxt)
        Me.GroupBox3.Controls.Add(Me.ParthDatetxt)
        Me.GroupBox3.Controls.Add(Me.Addresstxt)
        Me.GroupBox3.Controls.Add(Me.Gsm3iatxt)
        Me.GroupBox3.Controls.Add(Me.EmpIDtxt)
        Me.GroupBox3.Controls.Add(Me.EmpNametxt)
        Me.GroupBox3.Controls.Add(Me.EmpCodeTxt)
        Me.GroupBox3.Controls.Add(EmpNmeLabel)
        Me.GroupBox3.Controls.Add(EmpIDLabel)
        Me.GroupBox3.Controls.Add(QulifcathionLabel)
        Me.GroupBox3.Controls.Add(EMpDescribeLabel)
        Me.GroupBox3.Controls.Add(PactheDayLabel)
        Me.GroupBox3.Controls.Add(ManegeLabel)
        Me.GroupBox3.Controls.Add(NationalIDLabel)
        Me.GroupBox3.Controls.Add(SocialCaseLabel)
        Me.GroupBox3.Controls.Add(SexLabel)
        Me.GroupBox3.Controls.Add(AdreeseLabel)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 419)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(992, 218)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'Errortxt
        '
        Me.Errortxt.checkEmail = False
        Me.Errortxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Errortxt.combo_link = False
        Me.Errortxt.combobox = Nothing
        Me.Errortxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "ErrorNameId", True))
        Me.Errortxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Errortxt.ForeColor = System.Drawing.Color.Gray
        Me.Errortxt.LabelColor = System.Drawing.Color.Gray
        Me.Errortxt.LabelText = ""
        Me.Errortxt.leave_color = System.Drawing.SystemColors.Window
        Me.Errortxt.Location = New System.Drawing.Point(9, 97)
        Me.Errortxt.Name = "Errortxt"
        Me.Errortxt.numaricCheck = False
        Me.Errortxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Errortxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Errortxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Errortxt.Size = New System.Drawing.Size(212, 30)
        Me.Errortxt.TabIndex = 60
        Me.Errortxt.textColor = System.Drawing.Color.Black
        Me.Errortxt.Textlengthcheck = 0
        '
        'Degreetxt
        '
        Me.Degreetxt.checkEmail = False
        Me.Degreetxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Degreetxt.combo_link = False
        Me.Degreetxt.combobox = Nothing
        Me.Degreetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Degree", True))
        Me.Degreetxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Degreetxt.ForeColor = System.Drawing.Color.Gray
        Me.Degreetxt.LabelColor = System.Drawing.Color.Gray
        Me.Degreetxt.LabelText = ""
        Me.Degreetxt.leave_color = System.Drawing.SystemColors.Window
        Me.Degreetxt.Location = New System.Drawing.Point(16, 171)
        Me.Degreetxt.Name = "Degreetxt"
        Me.Degreetxt.numaricCheck = False
        Me.Degreetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Degreetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Degreetxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Degreetxt.Size = New System.Drawing.Size(209, 30)
        Me.Degreetxt.TabIndex = 58
        Me.Degreetxt.textColor = System.Drawing.Color.Black
        Me.Degreetxt.Textlengthcheck = 0
        '
        'naw3iaTxt
        '
        Me.naw3iaTxt.checkEmail = False
        Me.naw3iaTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.naw3iaTxt.combo_link = False
        Me.naw3iaTxt.combobox = Nothing
        Me.naw3iaTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Naow3ia", True))
        Me.naw3iaTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.naw3iaTxt.ForeColor = System.Drawing.Color.Gray
        Me.naw3iaTxt.LabelColor = System.Drawing.Color.Gray
        Me.naw3iaTxt.LabelText = ""
        Me.naw3iaTxt.leave_color = System.Drawing.SystemColors.Window
        Me.naw3iaTxt.Location = New System.Drawing.Point(651, 173)
        Me.naw3iaTxt.Name = "naw3iaTxt"
        Me.naw3iaTxt.numaricCheck = False
        Me.naw3iaTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.naw3iaTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.naw3iaTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.naw3iaTxt.Size = New System.Drawing.Size(163, 30)
        Me.naw3iaTxt.TabIndex = 56
        Me.naw3iaTxt.textColor = System.Drawing.Color.Black
        Me.naw3iaTxt.Textlengthcheck = 0
        '
        'm3ashDatetxt
        '
        Me.m3ashDatetxt.checkEmail = False
        Me.m3ashDatetxt.checkNolength = ZeftawyTools.chekcno.None
        Me.m3ashDatetxt.combo_link = False
        Me.m3ashDatetxt.combobox = Nothing
        Me.m3ashDatetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "FinanceDate", True))
        Me.m3ashDatetxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.m3ashDatetxt.ForeColor = System.Drawing.Color.Gray
        Me.m3ashDatetxt.LabelColor = System.Drawing.Color.Gray
        Me.m3ashDatetxt.LabelText = ""
        Me.m3ashDatetxt.leave_color = System.Drawing.SystemColors.Window
        Me.m3ashDatetxt.Location = New System.Drawing.Point(337, 138)
        Me.m3ashDatetxt.Name = "m3ashDatetxt"
        Me.m3ashDatetxt.numaricCheck = False
        Me.m3ashDatetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.m3ashDatetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.m3ashDatetxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.m3ashDatetxt.Size = New System.Drawing.Size(163, 30)
        Me.m3ashDatetxt.TabIndex = 54
        Me.m3ashDatetxt.textColor = System.Drawing.Color.Black
        Me.m3ashDatetxt.Textlengthcheck = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "SocialCase", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1-اعزب", "2-متزوج", "3-مطلق", "4-ارمل"})
        Me.ComboBox2.Location = New System.Drawing.Point(348, 54)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(235, 31)
        Me.ComboBox2.TabIndex = 51
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Sex", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1-ذكر", "2-انثى"})
        Me.ComboBox1.Location = New System.Drawing.Point(744, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 31)
        Me.ComboBox1.TabIndex = 50
        '
        'QualifcationTxt
        '
        Me.QualifcationTxt.checkEmail = False
        Me.QualifcationTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.QualifcationTxt.combo_link = False
        Me.QualifcationTxt.combobox = Nothing
        Me.QualifcationTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Qulifcathion", True))
        Me.QualifcationTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.QualifcationTxt.ForeColor = System.Drawing.Color.Gray
        Me.QualifcationTxt.LabelColor = System.Drawing.Color.Gray
        Me.QualifcationTxt.LabelText = ""
        Me.QualifcationTxt.leave_color = System.Drawing.SystemColors.Window
        Me.QualifcationTxt.Location = New System.Drawing.Point(18, 135)
        Me.QualifcationTxt.Name = "QualifcationTxt"
        Me.QualifcationTxt.numaricCheck = False
        Me.QualifcationTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.QualifcationTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.QualifcationTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.QualifcationTxt.Size = New System.Drawing.Size(207, 30)
        Me.QualifcationTxt.TabIndex = 48
        Me.QualifcationTxt.textColor = System.Drawing.Color.Black
        Me.QualifcationTxt.Textlengthcheck = 0
        '
        'jopTxt
        '
        Me.jopTxt.checkEmail = False
        Me.jopTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.jopTxt.combo_link = False
        Me.jopTxt.combobox = Nothing
        Me.jopTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "EMpDescribe", True))
        Me.jopTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.jopTxt.ForeColor = System.Drawing.Color.Gray
        Me.jopTxt.LabelColor = System.Drawing.Color.Gray
        Me.jopTxt.LabelText = ""
        Me.jopTxt.leave_color = System.Drawing.SystemColors.Window
        Me.jopTxt.Location = New System.Drawing.Point(337, 174)
        Me.jopTxt.Name = "jopTxt"
        Me.jopTxt.numaricCheck = False
        Me.jopTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.jopTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.jopTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.jopTxt.Size = New System.Drawing.Size(163, 30)
        Me.jopTxt.TabIndex = 47
        Me.jopTxt.textColor = System.Drawing.Color.Black
        Me.jopTxt.Textlengthcheck = 0
        '
        'ParthDatetxt
        '
        Me.ParthDatetxt.checkEmail = False
        Me.ParthDatetxt.checkNolength = ZeftawyTools.chekcno.None
        Me.ParthDatetxt.combo_link = False
        Me.ParthDatetxt.combobox = Nothing
        Me.ParthDatetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "PactheDay", True))
        Me.ParthDatetxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.ParthDatetxt.ForeColor = System.Drawing.Color.Gray
        Me.ParthDatetxt.LabelColor = System.Drawing.Color.Gray
        Me.ParthDatetxt.LabelText = ""
        Me.ParthDatetxt.leave_color = System.Drawing.SystemColors.Window
        Me.ParthDatetxt.Location = New System.Drawing.Point(651, 137)
        Me.ParthDatetxt.Name = "ParthDatetxt"
        Me.ParthDatetxt.numaricCheck = False
        Me.ParthDatetxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.ParthDatetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ParthDatetxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.ParthDatetxt.Size = New System.Drawing.Size(163, 30)
        Me.ParthDatetxt.TabIndex = 44
        Me.ParthDatetxt.textColor = System.Drawing.Color.Black
        Me.ParthDatetxt.Textlengthcheck = 0
        '
        'Addresstxt
        '
        Me.Addresstxt.checkEmail = False
        Me.Addresstxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Addresstxt.combo_link = False
        Me.Addresstxt.combobox = Nothing
        Me.Addresstxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Adreese", True))
        Me.Addresstxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Addresstxt.ForeColor = System.Drawing.Color.Gray
        Me.Addresstxt.LabelColor = System.Drawing.Color.Gray
        Me.Addresstxt.LabelText = ""
        Me.Addresstxt.leave_color = System.Drawing.SystemColors.Window
        Me.Addresstxt.Location = New System.Drawing.Point(348, 100)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.numaricCheck = False
        Me.Addresstxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Addresstxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Addresstxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Addresstxt.Size = New System.Drawing.Size(513, 30)
        Me.Addresstxt.TabIndex = 42
        Me.Addresstxt.textColor = System.Drawing.Color.Black
        Me.Addresstxt.Textlengthcheck = 0
        '
        'Gsm3iatxt
        '
        Me.Gsm3iatxt.checkEmail = False
        Me.Gsm3iatxt.checkNolength = ZeftawyTools.chekcno.None
        Me.Gsm3iatxt.combo_link = False
        Me.Gsm3iatxt.combobox = Nothing
        Me.Gsm3iatxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "Manege", True))
        Me.Gsm3iatxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.Gsm3iatxt.ForeColor = System.Drawing.Color.Gray
        Me.Gsm3iatxt.LabelColor = System.Drawing.Color.Gray
        Me.Gsm3iatxt.LabelText = ""
        Me.Gsm3iatxt.leave_color = System.Drawing.SystemColors.Window
        Me.Gsm3iatxt.Location = New System.Drawing.Point(6, 15)
        Me.Gsm3iatxt.Name = "Gsm3iatxt"
        Me.Gsm3iatxt.numaricCheck = False
        Me.Gsm3iatxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.Gsm3iatxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Gsm3iatxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.Gsm3iatxt.Size = New System.Drawing.Size(212, 30)
        Me.Gsm3iatxt.TabIndex = 41
        Me.Gsm3iatxt.textColor = System.Drawing.Color.Black
        Me.Gsm3iatxt.Textlengthcheck = 0
        '
        'EmpIDtxt
        '
        Me.EmpIDtxt.checkEmail = False
        Me.EmpIDtxt.checkNolength = ZeftawyTools.chekcno.None
        Me.EmpIDtxt.combo_link = False
        Me.EmpIDtxt.combobox = Nothing
        Me.EmpIDtxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "NationalID", True))
        Me.EmpIDtxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.EmpIDtxt.ForeColor = System.Drawing.Color.Gray
        Me.EmpIDtxt.LabelColor = System.Drawing.Color.Gray
        Me.EmpIDtxt.LabelText = ""
        Me.EmpIDtxt.leave_color = System.Drawing.SystemColors.Window
        Me.EmpIDtxt.Location = New System.Drawing.Point(6, 55)
        Me.EmpIDtxt.MaxLength = 14
        Me.EmpIDtxt.Name = "EmpIDtxt"
        Me.EmpIDtxt.numaricCheck = False
        Me.EmpIDtxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.EmpIDtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EmpIDtxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.EmpIDtxt.Size = New System.Drawing.Size(212, 30)
        Me.EmpIDtxt.TabIndex = 40
        Me.EmpIDtxt.textColor = System.Drawing.Color.Black
        Me.EmpIDtxt.Textlengthcheck = 14
        '
        'EmpNametxt
        '
        Me.EmpNametxt.checkEmail = False
        Me.EmpNametxt.checkNolength = ZeftawyTools.chekcno.None
        Me.EmpNametxt.combo_link = False
        Me.EmpNametxt.combobox = Nothing
        Me.EmpNametxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "EmpNme", True))
        Me.EmpNametxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.EmpNametxt.ForeColor = System.Drawing.Color.Gray
        Me.EmpNametxt.LabelColor = System.Drawing.Color.Gray
        Me.EmpNametxt.LabelText = ""
        Me.EmpNametxt.leave_color = System.Drawing.SystemColors.Window
        Me.EmpNametxt.Location = New System.Drawing.Point(297, 15)
        Me.EmpNametxt.Name = "EmpNametxt"
        Me.EmpNametxt.numaricCheck = False
        Me.EmpNametxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.EmpNametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EmpNametxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.EmpNametxt.Size = New System.Drawing.Size(365, 30)
        Me.EmpNametxt.TabIndex = 39
        Me.EmpNametxt.textColor = System.Drawing.Color.Black
        Me.EmpNametxt.Textlengthcheck = 0
        '
        'EmpCodeTxt
        '
        Me.EmpCodeTxt.checkEmail = False
        Me.EmpCodeTxt.checkNolength = ZeftawyTools.chekcno.None
        Me.EmpCodeTxt.combo_link = False
        Me.EmpCodeTxt.combobox = Nothing
        Me.EmpCodeTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpDataBindingSource, "EmpID", True))
        Me.EmpCodeTxt.enter_color = System.Drawing.Color.DodgerBlue
        Me.EmpCodeTxt.ForeColor = System.Drawing.Color.Gray
        Me.EmpCodeTxt.LabelColor = System.Drawing.Color.Gray
        Me.EmpCodeTxt.LabelText = ""
        Me.EmpCodeTxt.leave_color = System.Drawing.SystemColors.Window
        Me.EmpCodeTxt.Location = New System.Drawing.Point(738, 15)
        Me.EmpCodeTxt.Name = "EmpCodeTxt"
        Me.EmpCodeTxt.numaricCheck = False
        Me.EmpCodeTxt.read_only_color = System.Drawing.Color.DodgerBlue
        Me.EmpCodeTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.EmpCodeTxt.SetLangAs = ZeftawyTools.SETlangAs.عربي
        Me.EmpCodeTxt.Size = New System.Drawing.Size(139, 30)
        Me.EmpCodeTxt.TabIndex = 38
        Me.EmpCodeTxt.textColor = System.Drawing.Color.Black
        Me.EmpCodeTxt.Textlengthcheck = 0
        '
        'DataPostion1
        '
        Me.DataPostion1.AutoSize = True
        Me.DataPostion1.BackColor = System.Drawing.Color.Transparent
        Me.DataPostion1.bindingsouce = Me.EmpDataBindingSource
        Me.DataPostion1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.DataPostion1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.DataPostion1.ButtonFareColor = System.Drawing.Color.Empty
        Me.DataPostion1.Data_Posetion_Active = True
        Me.DataPostion1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPostion1.font_color = System.Drawing.Color.Black
        Me.DataPostion1.font_color_Mouseclick = System.Drawing.Color.Yellow
        Me.DataPostion1.font_color_Mousemove = System.Drawing.Color.White
        Me.DataPostion1.Location = New System.Drawing.Point(38, 644)
        Me.DataPostion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataPostion1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.DataPostion1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.DataPostion1.mousemove_center_color = System.Drawing.Color.Lime
        Me.DataPostion1.Name = "DataPostion1"
        Me.DataPostion1.Size = New System.Drawing.Size(541, 59)
        Me.DataPostion1.TabIndex = 40
        Me.DataPostion1.textfont = Nothing
        '
        'Datacontrol3B1
        '
        Me.Datacontrol3B1.BackColor = System.Drawing.Color.Transparent
        Me.Datacontrol3B1.buttonclick_center_color = System.Drawing.Color.Crimson
        Me.Datacontrol3B1.buttonclick_surrounding_color = System.Drawing.Color.Cyan
        Me.Datacontrol3B1.ButtonForeColor = System.Drawing.Color.Empty
        Me.Datacontrol3B1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datacontrol3B1.Location = New System.Drawing.Point(587, 644)
        Me.Datacontrol3B1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Datacontrol3B1.meloodcenter_color = System.Drawing.Color.DodgerBlue
        Me.Datacontrol3B1.meloodserruonding_color = System.Drawing.Color.Blue
        Me.Datacontrol3B1.mousemove_center_color = System.Drawing.Color.Lime
        Me.Datacontrol3B1.Name = "Datacontrol3B1"
        Me.Datacontrol3B1.Size = New System.Drawing.Size(401, 59)
        Me.Datacontrol3B1.TabIndex = 41
        Me.Datacontrol3B1.textfont = Nothing
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
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
        'helpLable
        '
        Me.helpLable.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.helpLable.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpLable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.helpLable.Location = New System.Drawing.Point(30, 710)
        Me.helpLable.Multiline = True
        Me.helpLable.Name = "helpLable"
        Me.helpLable.ReadOnly = True
        Me.helpLable.Size = New System.Drawing.Size(994, 58)
        Me.helpLable.TabIndex = 42
        '
        'EmpiloyeeDataFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpDataDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.helpLable)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataPostion1)
        Me.Controls.Add(Me.Datacontrol3B1)
        Me.Name = "EmpiloyeeDataFrm"
        Me.Opacity = 1
        Me.Text = "بيانات العاملين الاساسية"
        Me.TiteText = "بيانات العاملين الاساسية"
        Me.Controls.SetChildIndex(Me.Datacontrol3B1, 0)
        Me.Controls.SetChildIndex(Me.DataPostion1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.helpLable, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.EmpDataDataGridView, 0)
        Me.Controls.SetChildIndex(Me.T_button, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TitelBar, 0)
        Me.Controls.SetChildIndex(Me.Labelbox, 0)
        Me.Controls.SetChildIndex(Me.massegBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.T_textbox, 0)
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EmpDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MydataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NmaeSearchTxt As ZeftawyTools.t_textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Gam3SearchTxt As ZeftawyTools.t_textbox
    Friend WithEvents MydataDataSet As Zera3a.mydataDataSet
    Friend WithEvents EmpDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpDataTableAdapter As Zera3a.mydataDataSetTableAdapters.EmpDataTableAdapter
    Friend WithEvents TableAdapterManager As Zera3a.mydataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpDataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents EmpNametxt As ZeftawyTools.t_textbox
    Friend WithEvents EmpCodeTxt As ZeftawyTools.t_textbox
    Friend WithEvents QualifcationTxt As ZeftawyTools.t_textbox
    Friend WithEvents jopTxt As ZeftawyTools.t_textbox
    Friend WithEvents ParthDatetxt As ZeftawyTools.t_textbox
    Friend WithEvents Addresstxt As ZeftawyTools.t_textbox
    Friend WithEvents Gsm3iatxt As ZeftawyTools.t_textbox
    Friend WithEvents EmpIDtxt As ZeftawyTools.t_textbox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataPostion1 As ZeftawyTools.DataPostion
    Friend WithEvents Datacontrol3B1 As ZeftawyTools.datacontrol3B
    Friend WithEvents m3ashDatetxt As ZeftawyTools.t_textbox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Degreetxt As ZeftawyTools.t_textbox
    Friend WithEvents naw3iaTxt As ZeftawyTools.t_textbox
    Friend WithEvents Errortxt As ZeftawyTools.t_textbox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isIDReght As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Degree As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Naow3ia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMpDescribe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PactheDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinanceDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents menhaa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorNameId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Visacasecom As System.Windows.Forms.ComboBox
    Friend WithEvents T_button5 As ZeftawyTools.t_button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents T_button3 As ZeftawyTools.t_button
    Friend WithEvents T_button2 As ZeftawyTools.t_button
    Friend WithEvents T_button1 As ZeftawyTools.t_button
    Friend WithEvents helpLable As System.Windows.Forms.TextBox
    Friend WithEvents T_button4 As ZeftawyTools.t_button
End Class
