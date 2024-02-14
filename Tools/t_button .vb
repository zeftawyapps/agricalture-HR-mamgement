Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
<DefaultProperty("me_text")> _
Public Class t_button
    Inherits Button
    Private mouse As Integer = 1
    Private Checbox, checkd As Boolean
    ''' <summary>
    ''' هل تجعل الزر على شكل شيك بوكس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("هل تجعل الزر على شكل شيك بوكس")> _
    <Category("Zeftawy tools")> _
Public Property CheckBox() As Boolean
        Get
            Return Checbox
        End Get
        Set(ByVal value As Boolean)
            Checbox = value
        End Set
    End Property
    Public Event isChecked() : Public Event isnotChecked()

    <Browsable(True)> _
    Public Property Checked As Boolean
        Get
            Return checkd
        End Get
        Set(ByVal value As Boolean)
            checkd = False
            If CheckBox Then
                checkd = value
                If checkd Then
                    RaiseEvent isChecked()
                Else
                    RaiseEvent isnotChecked()
                End If
            Else
                Exit Property
            End If
        End Set
    End Property
    Private Function IsItInMe(ByVal p As Point) As Boolean
        If p.X < Me.Left + Me.Width And p.X > Me.Left And p.Y > Me.Top And p.Y < Me.Top + Me.Height Then
            Return True
        Else
            Return False
        End If
    End Function
    Private AutS As Boolean
    Public Property meAutoSize As Boolean
        Get
            Return AutS
        End Get
        Set(ByVal value As Boolean)
            AutS = value
        End Set
    End Property
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click
        mouse = 2
        If CheckBox Then
            If Checked Then
                Checked = False
            Else
                Checked = True
            End If

        End If
    End Sub
#Region "خصائص الالوان"
    Private cent_color As Color = Color.DodgerBlue
    ''' <summary>
    '''  اللون الوسطي في حالة مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون الوسطي في حالة مرور الماوس")> _
    <Category("Zeftawy tools")> _
    <DefaultValueAttribute(GetType(Color), "PaleGreen")> _
    Public Property meloodcenter_color() As Color
        Get
            Return cent_color
        End Get
        Set(ByVal value As Color)
            cent_color = value
        End Set
    End Property
    Private surru_color As Color = Color.Blue
    ''' <summary>
    '''  اللون المحيطي في حالة التحميل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون المحيطي في حالة التحميل")> _
    <Category("Zeftawy tools")> _
      <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property meloodserruonding_color() As Color
        Get
            Return surru_color
        End Get
        Set(ByVal value As Color)
            surru_color = value
        End Set
    End Property
    Private meclc_cent_color As Color = Color.Crimson
    ''' <summary>
    '''  اللون الوسطي في حالة نقر  الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون الوسطي في حالة نقر الماوس الماوس")> _
    <Category("Zeftawy tools")> _
      <DefaultValueAttribute(GetType(Color), "GreenYellow")> _
    Public Property buttonclick_center_color() As Color
        Get
            Return meclc_cent_color
        End Get
        Set(ByVal value As Color)
            meclc_cent_color = value
        End Set
    End Property
    Private meclcsurrou_color As Color = Color.Cyan
    ''' <summary>
    '''  اللون المحيطي في حالة نقر  الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون المحيطي في حالة نقر الماوس")> _
    <Category("Zeftawy tools")> _
      <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property buttonclick_surrounding_color() As Color
        Get
            Return meclcsurrou_color
        End Get
        Set(ByVal value As Color)
            meclcsurrou_color = value
        End Set
    End Property
    Private memovecent_color As Color = Color.Lime
    ''' <summary>
    '''  اللون الوسطي في حالة مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون الوسطي في حالة مرور الماوس")> _
    <Category("Zeftawy tools")> _
      <DefaultValueAttribute(GetType(Color), "LimeGreen")> _
    Public Property mousemove_center_color() As Color
        Get
            Return memovecent_color
        End Get
        Set(ByVal value As Color)
            memovecent_color = value
        End Set
    End Property
    Private memovesurr_color As Color = Color.GreenYellow
    ''' <summary>
    '''  اللون المحيطي في حالة مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("اللون المحيطي في حالة مرور الماوس")> _
    <Category("Zeftawy tools")> _
      <DefaultValueAttribute(GetType(Color), "GreenYellow")> _
    Public Property mousrmove_surronding_color() As Color
        Get
            Return memovesurr_color
        End Get
        Set(ByVal value As Color)
            memovesurr_color = value
        End Set
    End Property

#End Region

    Private Sub t_button_isChecked() Handles Me.isChecked
        If CheckBox Then
            mouse = 2
            Me.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub t_button_isnotChecked() Handles Me.isnotChecked
        If CheckBox Then
            mouse = 1
            Me.Refresh()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        mouse = 2
        If Me.MakeMeAs = shap.نص Then
            If Me.IsItInMe(e.Location) Then
                mouse = 2

            End If
        End If
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        If Checked Then Exit Sub
        mouse = 1
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Checked then Exit Sub
        mouse = 3
        If Me.MakeMeAs = shap.نص Then
            If Me.IsItInMe(e.Location) Then
                mouse = 3

            End If
        End If
    End Sub
    Private txt As String = "تاشفين"
    ''' <summary>
    '''  كتابة النص في حالة تلوين الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("كتابة النص في حالة تلوين الزر")> _
    <Category("Zeftawy tools")> _
    Public Property me_text() As String
        Get
            Return txt
        End Get
        Set(ByVal value As String)
            txt = value
            Me.Text = value
            Me.Refresh()
        End Set
    End Property

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.BackColor = Color.Red
    End Sub
    Private for_color As Color = Color.Black
    ''' <summary>
    '''   لون خط النص في حالة تلوين الزر وعند التحميل
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("لون خط النص في حالة تلوين الزر وعند التحميل")> _
    <Category("Zeftawy tools")> _
    Public Property font_color() As Color
        Get
            Return for_color
        End Get
        Set(ByVal value As Color)
            for_color = value
        End Set
    End Property
    Private movefor_color As Color = Color.White
    ''' <summary>
    '''   لون خط النص في حالة تلوين الزر وعند مرور الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("لون خط النص في حالة تلوين الزر وعند مرور الماوس")> _
    <Category("Zeftawy tools")> _
    Public Property font_color_Mousemove() As Color
        Get
            Return movefor_color
        End Get
        Set(ByVal value As Color)
            movefor_color = value
        End Set
    End Property
    Private clickfor_color As Color = Color.Yellow
    ''' <summary>
    '''   لون خط النص في حالة تلوين الزر وعند نقر الماوس
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("لون خط النص في حالة تلوين الزر وعند نقر الماوس")> _
    <Category("Zeftawy tools")> _
    Public Property font_color_Mouseclick() As Color
        Get
            Return clickfor_color
        End Get
        Set(ByVal value As Color)
            clickfor_color = value
        End Set
    End Property

    Private Sub mouse_leave(ByVal g As Graphics)
        Dim shape2 As New GraphicsPath
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        shape2.AddRectangle(rec)


        Dim color_center As Color = Me.meloodcenter_color
        Dim coror_surruwnd As Color() = {Me.meloodserruonding_color}
        Dim brush As New PathGradientBrush(shape2)
        brush.CenterColor = color_center
        brush.SurroundColors = coror_surruwnd
        g.FillRectangle(brush, 0, 0, Me.Width + 10, Me.Height + 10)
        Dim f As New Font(Me.Font, FontStyle.Bold)
        Dim colors As New SolidBrush(font_color)
        drowstring(g)
        'Dim shape As New System.Drawing.Drawing2D.GraphicsPath
        'shape.AddEllipse(5, 5, Me.Width - 5, Me.Height - 5)

        'Me.Button1.Region = New System.Drawing.Region(shape)
    End Sub
    Private Sub mouse_move(ByVal g As Graphics)
        Dim shape2 As New GraphicsPath
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        shape2.AddRectangle(rec)


        Dim color_center As Color = Me.mousemove_center_color
        Dim coror_surruwnd As Color() = {Me.mousrmove_surronding_color}
        Dim brush As New PathGradientBrush(shape2)
        brush.CenterColor = color_center
        brush.SurroundColors = coror_surruwnd
        g.FillRectangle(brush, 0, 0, Me.Width + 10, Me.Height + 10)
        Dim f As New Font(Me.Font, FontStyle.Bold)
        Dim colors As New SolidBrush(font_color_Mousemove)
        drowstring(g)
        'Dim shape As New System.Drawing.Drawing2D.GraphicsPath
        'shape.AddEllipse(5, 5, Me.Width - 5, Me.Height - 5)

        'Me.Button1.Region = New System.Drawing.Region(shape)
    End Sub
    Private Sub mouse_click(ByVal g As Graphics)
        Dim shape2 As New GraphicsPath
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        shape2.AddRectangle(rec)


        Dim color_center As Color = Me.buttonclick_center_color
        Dim coror_surruwnd As Color() = {Me.buttonclick_surrounding_color}
        Dim brush As New PathGradientBrush(shape2)
        brush.CenterColor = color_center
        brush.SurroundColors = coror_surruwnd
        g.FillRectangle(brush, 0, 0, Me.Width + 10, Me.Height + 10)
        Dim f As New Font(Me.Font, FontStyle.Bold)
        Dim colors As New SolidBrush(font_color_Mouseclick)
        drowstring(g)
        'Dim shape As New System.Drawing.Drawing2D.GraphicsPath
        'shape.AddEllipse(5, 5, Me.Width - 5, Me.Height - 5)

        'Me.Button1.Region = New System.Drawing.Region(shape)
    End Sub
    Private stringpoint As Integer
    Private Sub drowstring(ByVal g As Graphics)

        Dim f As New Font(Me.Font, FontStyle.Bold)
        Dim colors As New SolidBrush(font_color_Mouseclick)
        If Me.MakeMeAs = shap.نجمة Then
            g.DrawString(me_text, f, colors, Me.Width / 4, Me.Height / 3)
            stringpoint = Me.Width / 4
        ElseIf Me.MakeMeAs = shap.دائرة Then
            g.DrawString(me_text, f, colors, Me.Width / 3, Me.Height / 3)
            stringpoint = Me.Width / 3
        Else

            g.DrawString(me_text, f, colors, Me.Width / 4, Me.Height / 4)
            stringpoint = Me.Width / 4
        End If

    End Sub
    Private Function Allign(ByVal all As Alligne) As StringFormat
        Select Case all
            Case Alligne.وسط
                Dim sf As New StringFormat

                Dim ssf As New StringFormat
                ssf.FormatFlags = StringFormatFlags.DisplayFormatControl
                sf = ssf
                Return sf
            Case Alligne.يسار
                Dim sf As New StringFormat

                Dim ssf As New StringFormat
                ssf.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
                sf = ssf
                Return sf

            Case Alligne.يمين
                Dim sf As New StringFormat

                Dim ssf As New StringFormat
                ssf.FormatFlags = StringFormatFlags.DirectionRightToLeft
                sf = ssf
                Return sf

        End Select


    End Function
    Private sf As Alligne = Alligne.يمين
    Private Property Alligne As Alligne
        Get
            Return sf
        End Get
        Set(ByVal value As Alligne)
            sf = value
        End Set
    End Property
    Private Sub MakeMeAsText()

        Dim myGraphicsPath As New System.Drawing. _
        Drawing2D.GraphicsPath()
        Dim stringText As String = me_text
        Dim f As New Font(Me.Font, 55)

        Dim family As FontFamily = New FontFamily("Arial")
        Dim fontStyle As FontStyle = fontStyle.Underline
        Dim emSize As Integer = Me.Font.Size * 4
        Dim origin As PointF = New PointF(0, 0)
        Dim format As StringFormat = StringFormat.GenericDefault

        If Not UseDefFontInTxtShap Then
            myGraphicsPath.AddString(stringText, f.FontFamily, f.Style, f.Size, origin, format)
        Else

            myGraphicsPath.AddString(stringText, family, _
            fontStyle, emSize, origin, format)

        End If

        Me.Region = New Region(myGraphicsPath)

    End Sub
    Private dff As Boolean = True
    Private BackG As Boolean
    ''' <summary>
    '''   جعل الخلفية من خاصية الباك كلر 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("جعل الخلفية من خاصية الباك كلر ")> _
    <Category("Zeftawy tools")> _
    Public Property UseDefultButton() As Boolean
        Get
            Return BackG
        End Get
        Set(ByVal value As Boolean)
            BackG = value
        End Set
    End Property
    Public Property UseDefFontInTxtShap As Boolean
        Get
            Return dff
        End Get
        Set(ByVal value As Boolean)
            dff = value
        End Set
    End Property

    Private Sub MakeMeAsrec()
        Dim shape As New GraphicsPath
        Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
        shape.AddRectangle(rec)

        Me.Region = New System.Drawing.Region(shape)

    End Sub
    Private Sub MakeMeAsStare()
        Dim p1 As New Point(0, Me.Height * 3 / 6)
        Dim p2 As New Point(Me.Width * 1 / 6, Me.Height * 2 / 6)
        Dim p3 As New Point(Me.Width * 1 / 6, Me.Height * 1 / 6)
        Dim p4 As New Point(Me.Width * 2 / 6, Me.Height * 1 / 6)
        Dim p5 As New Point(Me.Width * 3 / 6, 0)
        Dim p6 As New Point(Me.Width * 4 / 6, Me.Height * 1 / 6)
        Dim p7 As New Point(Me.Width * 5 / 6, Me.Height * 1 / 6)
        Dim p8 As New Point(Me.Width * 5 / 6, Me.Height * 2 / 6)
        Dim p9 As New Point((Me.Width * 6 / 6), Me.Height * 3 / 6)
        Dim p10 As New Point(Me.Width * 5 / 6, Me.Height * 4 / 6)
        Dim p11 As New Point(Me.Width * 5 / 6, Me.Height * 5 / 6)
        Dim p12 As New Point(Me.Width * 4 / 6, Me.Height * 5 / 6)
        Dim p13 As New Point(Me.Width * 3 / 6, (Me.Height - 6 / 6))
        Dim p14 As New Point(Me.Width * 2 / 6, Me.Height * 5 / 6)
        Dim p15 As New Point(Me.Width * 1 / 6, Me.Height * 5 / 6)
        Dim p16 As New Point(Me.Width * 1 / 6, Me.Height * 4 / 6)
        Dim pf As PointF() = {p1, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16}

        Dim shape2 As New GraphicsPath
        shape2.AddPolygon(pf)
        Me.Region = New System.Drawing.Region(shape2)

    End Sub

    Private Sub MakeMeAsCyrcle()
        Dim shape As New GraphicsPath
        shape.AddEllipse(5, 5, Me.Width - 5, Me.Height - 5)

        Me.Region = New System.Drawing.Region(shape)

    End Sub

    Private Sub Button1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Select Case Me.MakeMeAs
            Case shap.دائرة
                MakeMeAsCyrcle()
            Case shap.نص
                MakeMeAsText()
            Case shap.مستطيل
                MakeMeAsrec()
            Case shap.نجمة
                MakeMeAsStare()

        End Select
        If UseDefultButton Then

            Exit Sub
        End If

        If CheckBox Then
            If Checked Then
                mouse_click(e.Graphics)

            Else
                mouse_leave(e.Graphics)
            End If
        End If
        Select Case mouse
            Case 1
                mouse_leave(e.Graphics)
            Case 2
                mouse_click(e.Graphics)

            Case 3
                mouse_move(e.Graphics)
        End Select

        If AutoSize Then
            Dim surface As Graphics = Me.CreateGraphics
            Dim textSize As SizeF = surface.MeasureString _
            ("  " & Me.me_text & "  ", Me.Font)
            surface.Dispose()
            Me.Width = CInt(textSize.Width) + stringpoint
        End If
    End Sub

    
    Private shap As Shap
    ''' <summary>
    '''   تغيير شكل الزر
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Browsable(True)> _
    <Description("تغيير شكل الزر")> _
    <Category("Zeftawy tools")> _
    Public Property MakeMeAs() As Shap
        Get
            Return shap
        End Get
        Set(ByVal value As Shap)
            shap = value
            If value = shap.نص Then Me.Cursor = Cursors.Hand
        End Set
    End Property
    Public Function meTextAnimation(ByVal txt As String, ByVal power As Integer) As String
        Static i As Integer = 0
        Dim ll, tleng As Integer
        ll = Len(txt)
        Dim ss As String
        ss = Mid(txt, 1, i)
        tleng = Len(ss)
        i += power
        If tleng >= ll Then
            i = 0

        Else

        End If

        Return ss
    End Function

    
End Class
Public Enum Shap
    مستطيل
    دائرة
    نجمة
    نص
End Enum
Public Enum Alligne
    يمين
    يسار
    وسط
End Enum