Imports System.Globalization
Imports System.ComponentModel
Public Class t_textbox
    Inherits TextBox
    ''' <summary>
    ''' LabelText  لقراءة البيانات في حالة اتسخدام الخاصية 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(False)> _
    <Description("LabelText  لقراءة البيانات في حالة اتسخدام الخاصية")> _
    Public ReadOnly Property MeText As String
        Get
            If Me.Text = Me.WaterMark Then
                Return ""
            Else
                Return Me.Text
            End If
        End Get
    End Property
    Public Event Null()
    Private LblTxt As String = "مكتبة الزفتاوي"
    ''' <summary>
    ''' ادخال صندوق العناوين داخل صندوق النصوص
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("ادخال العلامات المائية داخل صندوق النصوص")> _
    Public Property WaterMark As String
        Get

            Return LblTxt
        End Get
        Set(ByVal value As String)
            LblTxt = value
            If Me.Text = "" Then
                Me.Text = value
                Forcolor = Me.ForeColor
                Me.ForeColor = Me.LabelColor
            End If
        End Set
    End Property


    Private Lblcol As Color = Color.Gray
    ''' <summary>
    ''' ادخال صندوق العناوين داخل صندوق النصوص
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("ادخال صندوق العناوين داخل صندوق النصوص")> _
    Public Property LabelColor As Color
        Get
            Return Lblcol
        End Get
        Set(ByVal value As Color)
            Lblcol = value
        End Set
    End Property
    Private txtcol As Color = Color.Black
    ''' <summary>
    ''' ادخال صندوق العناوين داخل صندوق النصوص
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("ادخال صندوق العناوين داخل صندوق النصوص")> _
    Public Property textColor As Color
        Get
            Return txtcol
        End Get
        Set(ByVal value As Color)
            txtcol = value
        End Set
    End Property
    Private cent_color As Color = Color.DodgerBlue
    Private nomr As Boolean
    ''' <summary>
    ''' هل يتعامل مع الارقام
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("هل يتعامل مع الارقام")> _
Public Property numaricCheck() As Boolean
        Get
            Return nomr
        End Get
        Set(ByVal value As Boolean)
            nomr = value
            If value Then
                Me.Text = "0"
            Else
                Me.Text = ""
            End If
        End Set
    End Property
    ''' <summary>
    ''' لون التكست عند دخول
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("لون التكست عند دخول")> _
    Public Property enter_color() As Color
        Get
            Return cent_color
        End Get
        Set(ByVal value As Color)
            cent_color = value
        End Set
    End Property
    Private lev_color As Color = Color.DodgerBlue
    ''' <summary>
    ''' لون التكست عند خروج الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("لون التكست عند خروج الماوس")> _
    Public Property leave_color() As Color
        Get
            Return lev_color
        End Get
        Set(ByVal value As Color)
            value = Me.BackColor
            lev_color = value

        End Set
    End Property
    Private link As Boolean

    <Browsable(False)> _
    Public Property combo_link() As Boolean
        Get
            Return link
        End Get
        Set(ByVal value As Boolean)
            link = value
        End Set
    End Property
    Private com As ComboBox
    <Browsable(False)> _
    Public Property combobox() As ComboBox
        Get
            Return com

        End Get
        Set(ByVal value As ComboBox)
            com = value
            If ll Then
                fillcombo(com)

            End If
        End Set
    End Property
    Private readonty_color As Color = Color.DodgerBlue
    ''' <summary>
    ''' لون التكست عندما  يكون للقتراءة فقط 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description("لون التكست عندما يكون للقراءة فقط  ")> _
    Public Property read_only_color() As Color
        Get
            Return readonty_color
        End Get
        Set(ByVal value As Color)
            readonty_color = value
            If Me.ReadOnly Then
                Me.BackColor = readonty_color
            End If
        End Set
    End Property

    Private Sub t_textbox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.BackColor = Me.enter_color
        links(True)
        If Me.Text = WaterMark Then
            Me.Text = ""
            Me.ForeColor = Forcolor
        End If
       
    End Sub
    Private Shared Forcolor As Color
    Private Sub tashfeen_textbox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.BackColor = Me.enter_color
        links(True)
        If Me.Text = Me.WaterMark Then
            Me.Text = ""
            Me.ForeColor = Me.textColor
        ElseIf Me.WaterMark = "" Then
            Me.ForeColor = Me.textColor
        End If
    End Sub

    Private Sub tashfeen_textbox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.BackColor = Me.leave_color
        'كشف عن شكل ايميل
        If Not checkEmail Then
            GoTo leng
        End If
        If Me.Text = "" Then GoTo color
        Dim x As Boolean = emailChieck(Me.Text)
        If x = True Then
            GoTo color
            '  T_textbox4.Focus()
        Else
            Me.Focus()
        End If
        ' فحص رقم النص
leng:
        Dim l As Boolean = textlongthcheck(Me.checkNolength, Textlengthcheck)
        If l Then
            GoTo color
        Else
            Me.Focus()
        End If
        'لون المغادرة
color:
        Me.BackColor = Me.leave_color
        If Me.Text = "" Then
            Me.Text = Me.WaterMark
            Forcolor = Me.ForeColor
            Me.ForeColor = Me.LabelColor
        Else
                Me.ForeColor = Me.textColor
            End If
        If Me.WaterMark = "" Then
            Me.ForeColor = Me.textColor
        End If

    End Sub
    ''' <summary>
    ''' اظهار الكومبو
    ''' </summary>
    ''' <param name="com"></param>
    ''' <remarks></remarks>
    Private Sub fillcombo(ByVal com As ComboBox)
        com.Visible = True
        'com.Focus()
        ' com.DroppedDown = True
        com.Focus()
    End Sub
    Private l As Boolean
    Private Property ll() As Boolean
        Get
            Return l
        End Get
        Set(ByVal value As Boolean)

            l = value


        End Set
    End Property
    Private Sub links(ByVal l As Boolean)
        If combo_link Then
            ll = l
            fillcombo(combobox)
        End If

    End Sub

    Private Sub t_textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If numaricCheck Then
            If Not IsNumeric(Me.Text.Trim) Then
                Me.Text = "0"
            End If
        End If
        If Me.WaterMark = "" Then
            Me.ForeColor = Me.textColor
        End If
    End Sub

    Private ech As Boolean = False
    ''' <summary>
    '''  هل يختبر الايميل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description(" هل يخبتر الايميل")> _
    Public Property checkEmail() As Boolean
        Get
            Return ech
        End Get
        Set(ByVal value As Boolean)
            ech = value
        End Set
    End Property
    Private setl As SETlangAs = SetLangAs.عربي
    ''' <summary>
    ''' اللغة التي يبدأ 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description(" اللغة التي يبدا بها ")> _
    Public Property SetLangAs As SETlangAs
        Get
            Return setl
        End Get
        Set(ByVal value As SETlangAs)
            setl = value
            setlan()
        End Set
    End Property
    Private Sub Arabic(ByVal _
  sender As Object, ByVal e As EventArgs)

        InputLanguage.CurrentInputLanguage = _
        InputLanguage.FromCulture(New CultureInfo _
        (CultureInfo.CurrentCulture.ToString))
        'Me.TextAlign = HorizontalAlignment.Right
    End Sub
    Private Sub English _
   (ByVal sender As Object, ByVal e As EventArgs)

        InputLanguage.CurrentInputLanguage = _
        InputLanguage.FromCulture(New CultureInfo("en"))
        'Me.TextAlign = HorizontalAlignment.Left
    End Sub
    Private Function emailChieck(ByVal t As String) As Boolean
        Dim i As Integer = Len(t)
        Dim at As Integer = InStr(1, t, "@")
        If at > 0 Then
            Dim dot As Integer = InStr(at, t, ".")
            If dot > 0 Then
                Return True
            Else

                MsgBox("الرجاء ادخال الايميل بطريقة سليمة")
                Return False

            End If
        Else

            MsgBox("الرجاء ادخال الايميل بطريقة سليمة")
            Return False
        End If
    End Function

    Private tl As Integer
    ''' <summary>
    ''' تحديد طول النص المتاح
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description(" تحديد طول النص")> _
    Public Property Textlengthcheck() As Integer
        Get
            Return tl
        End Get
        Set(ByVal value As Integer)
            tl = value
        End Set
    End Property

    Private che As chekcno = chekcno.None
    ''' <summary>
    '''  تحديد النص الكبر من او اصغر من او يساوي
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("zeftawyTool")> _
    <Browsable(True)> _
    <Description(" تحديد هل النصر اكبر من او اصغر من او يساوي  طول النص المحدد")> _
    Public Property checkNolength() As chekcno
        Get
            Return che
        End Get
        Set(ByVal value As chekcno)
            che = value
        End Set
    End Property
    Private Sub setlan()
        Select Case Me.SetLangAs
            Case SetLangAs.عربي
                AddHandler Me.GotFocus, AddressOf Arabic
                Me.RightToLeft = Windows.Forms.RightToLeft.Yes
            Case SetLangAs.لاتيني
                AddHandler Me.GotFocus, AddressOf English
                Me.RightToLeft = Windows.Forms.RightToLeft.No
        End Select
    End Sub
    Private Function textlongthcheck(ByVal chek As chekcno, ByVal leing As Integer) As Boolean
        Select Case chek
            Case chekcno.None
                Return True
                Exit Function

            Case chekcno.greeter
                'اكبر من
                If Me.Text = "" Then
                    Return True
                    Exit Function
                End If

                Dim i As Integer = Len(Me.Text)
                If Not i > leing Then

                    MsgBox(" النص لا يقل عن" + leing.ToString + "حرف")
                    Return False
                Else
                    Return True
                End If
            Case chekcno.lower
                'اصغر من
                If Me.Text = "" Then
                    Return True
                    Exit Function
                End If

                Dim i As Integer = Len(Me.Text)
                If Not i < leing Then

                    MsgBox(" النص لايزيد عن" + leing.ToString + "حرف")
                    Return False
                Else
                    Return True
                End If

            Case chekcno.equale
                ' يساوي
                If Me.Text = "" Then
                    Return True
                    Exit Function
                End If

                Dim i As Integer = Len(Me.Text)
                If Not i = leing Then

                    MsgBox(" النص يجب ان يساوي  " + leing.ToString + "حرف")
                    Return False
                Else
                    Return True
                End If
            Case chekcno.greeterorEqual
                'اكبر من يساوي
                If Me.Text = "" Then
                    Return True
                    Exit Function
                End If

                Dim i As Integer = Len(Me.Text)
                If Not i >= leing Then

                    MsgBox(" النص لا يقل عن" + leing.ToString + "حرف")
                    Return False
                Else
                    Return True
                End If
            Case chekcno.lowerorequal
                'اصغر من يساوي
                If Me.Text = "" Then
                    Return True
                    Exit Function
                End If

                Dim i As Integer = Len(Me.Text)
                If Not i <= leing Then

                    MsgBox(" النص لا زيد عن" + leing.ToString + "حرف")
                    Return False
                Else
                    Return True
                End If


        End Select
    End Function
    Private lAll As SETAllawlangAs = SETAllawlangAs.الكل
    Private Property SetAllowLang As SETAllawlangAs
        Get
            Return lAll
        End Get
        Set(ByVal value As SETAllawlangAs)
            lAll = value
            If value = SETAllawlangAs.الكل Then Exit Property
            SetLangAs = value

        End Set
    End Property

    Private Sub Allenglish(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 128) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    ''' <summary>
    ''' في حالة الظغط على مفتاح الادخال  لنفيذ امر معين
    ''' </summary>
    ''' <remarks></remarks>
    Public Event pressEnter()
    Private Sub t_textbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        Select Case SetAllowLang
            Case SETAllawlangAs.عربي

                SetLangAs = SetLangAs.عربي
            Case SETAllawlangAs.لاتيني

                SetLangAs = SetLangAs.لاتيني
            Case SETAllawlangAs.الكل
                Exit Select
        End Select
    End Sub

    Private Sub t_textbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then RaiseEvent pressEnter()
    End Sub

    Private Sub t_textbox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Validated
        'If Me.Text = "" Then
        '    Me.Text = Me.LabelText
        '    Forcolor = Me.ForeColor
        '    Me.ForeColor = Me.LabelColor
        'End If
    End Sub
End Class
Public Enum chekcno
    None
    greeter
    lower
    equale
    greeterorEqual
    lowerorequal
End Enum
Public Enum SETlangAs
    عربي
    لاتيني
End Enum
Public Enum SETAllawlangAs
    عربي
    لاتيني
    الكل
End Enum