Public Class ReportDesignControl

#Region "متغيرات هامة"

    Private Pageland As Boolean
    Private page_mt, page_mb, page_mr, page_ml As Integer 'الهوامش
    Private hrtText, hptText, frtText, fptText As String 'النصوص
    Private hrtAllinge, hptAllinge, frtAllinge, fptAllinge As allinge 'وضع النص
    Private hrFC, hpfc, frfc, fpfc As Color ' لون النص
    Private hrtfont, hptfont, frtfont, fptfont As Font

    Private hrbC, hpbc, frbc, fpbc As Brush ' الخلفيات
    Private hrFramC, hpFramC, frFramC, fpFramC As Color ' لون الاطار
    Private hrFramw, hpFramw, frFramw, fpFramw As Integer 'عرض الاطار

    Private pageBc As Brush
    Private pageFramC As Color
    Private pageFramw As Integer
    Private pageFramDouble As Boolean
    Private DGV As DataGridView '
    Private repotpage As New ReportPrint
    'تفاصيل البيانات
    Private tableBc, tableheadBc As Brush
    Private tableFramC As Color
    Private tableFramW As Integer
    Private tablecellFont As Font
    Private tablecellFC As Color
    Private tableAlligen As Alligne

    Private getDataFromExternalDGV As Boolean = False
#End Region

#Region "الاجراءات المستدعاة مع الحدث"
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        ' اجراء الطباعة نفس كل حاجة ما عدا في الاخر 


        'Dim mypages As New ReportPrint
        repotpage = ReportSetting()

        'اخذ البيانات 
        Dim pDocDailoge As New PrintPreviewDialog
        repotpage.Pages.Details.Table.setData(ZR_Datagrideview, GetDataGridRieghtoleft)
        PrintDocument1 = repotpage.PrintDcument
        pDocDailoge.Document = repotpage.PrintDcument
        pDocDailoge.ShowDialog()
        pDocDailoge.Close()
    End Sub


    Private Sub ReportDesignControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        repotpage = ReportDefultSetting()
        pageWlbl.Text = repotpage.Pages.Details.DetailesPart.Rectangle.Width.ToString
        DataWlbl.Text = PageWith().ToString
        PageWlbl2.Text = pageWlbl.Text
        Dim pw, dw As Integer
        pw = CInt(pageWlbl.Text)
        dw = CInt(DataWlbl.Text)
        If pw < dw Then
            printpnl.Visible = False
        Else
            printpnl.Visible = True
        End If
        ZR_Datagrideview.DataSource = DataGridview.DataSource
        ZR_Datagrideview.Font = tablecellFont
        ZR_Datagrideview.RightToLeft = DataGridview.RightToLeft
        ComboBox7.SelectedIndex = 0
        GetCulloms2()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        pageBc = reportPartBc(Button20)

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        pageFramC = reportPartFramC(Button19)
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        pageFramw = reportPartFramw(TextBox9)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedIndex = 0 Then
            Pageland = False

        Else
            Pageland = True

        End If
        repotpage.SetPage(Pageland, page_mt, page_ml, page_mr, page_mb)
        PageWithTest()
    End Sub
    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        page_mt = CInt(TextBox13.Text)
        PageWithTest()
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        page_mb = CInt(TextBox10.Text)
        PageWithTest()
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        page_mr = CInt(TextBox12.Text)
        PageWithTest()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        page_ml = CInt(TextBox11.Text)
        PageWithTest()
    End Sub


    Private Sub ZR_Datagrideview_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ZR_Datagrideview.KeyDown
        'If e.KeyCode = Keys.Delete Then

        '    Dim c As Integer
        '    c = Me.ZR_Datagrideview.CurrentCell.ColumnIndex
        '    ZR_Datagrideview.Columns.Remove(Me.ZR_Datagrideview.Columns.Item(c).Name)
        '    ZR_Datagrideview.Refresh()


        '    pageWlbl.Text = repotpage.Pages.Details.Detailes.Rectangle.Width.ToString
        '    DataWlbl.Text = PageWith().ToString
        '    Dim pw, dw As Integer
        '    pw = CInt(pageWlbl.Text)
        '    dw = CInt(DataWlbl.Text)
        '    If pw < dw Then
        '        printpnl.Visible = False
        '    Else
        '        printpnl.Visible = True
        '    End If
        'End If
    End Sub


    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        tableAlligen = Me.TextAlligne(ComboBox7)
        Select Case ComboBox7.SelectedIndex

            Case 0
                If ZR_Datagrideview.RightToLeft = Windows.Forms.RightToLeft.Yes Then
                    ZR_Datagrideview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                Else
                    ZR_Datagrideview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            Case 1
                If ZR_Datagrideview.RightToLeft = Windows.Forms.RightToLeft.Yes Then
                    ZR_Datagrideview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Else
                    ZR_Datagrideview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                End If

             
            Case 2
                ZR_Datagrideview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Select
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        tablecellFont = TextFont(Button11)
        tablecellFC = txtC
        ZR_Datagrideview.Font = tablecellFont
        PageWithTest()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tableBc = reportPartBc(Button7)

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        tableFramW = reportPartFramw(TextBox16)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tableFramC = reportPartFramC(Button2)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        tableheadBc = reportPartBc(Button15)

    End Sub
#End Region

   
#Region "اجراءات هامة"
   
    Private Function TextAlligne(ByVal Combox As ComboBox) As allinge
        Dim i As Integer
        i = Combox.SelectedIndex
        Select Case i
            Case 0
                Return allinge.reight
            Case 1
                Return allinge.left
            Case 2
                Return allinge.Center
        End Select
    End Function

   
    Private Function ReportDefultSetting() As ReportPrint
        Dim mypages As New ReportPrint


        ' البيانات الافتراضية لاعداد الصفحة
        Pageland = False
        page_mb = 1
        page_ml = 1
        page_mr = 1
        page_mt = 1
        pageBc = Brushes.White
        pageFramC = Color.Black
        pageFramw = 1
        pageFramDouble = True
        'نصوص اجزاء الصفحةالبيانات الافتراضية
        hrtText = "بسم الله الرحمن الرحيم"
        hrtAllinge = allinge.Center
        hptText = "بيانات الصفحة"
        hptAllinge = allinge.reight
        fptText = "نهاية الصفحة"
        fptAllinge = allinge.reight
        frtText = "ولكم جزيل الشكر" : frtAllinge = allinge.Center
        'خطوط اجزاء الصفحةالبيانات الافتراضية
        hrFC = Color.DarkRed : hrtfont = Button8.Font
        hpfc = Color.DarkBlue : hptfont = Button8.Font
        fpfc = Color.Black : fptfont = Button8.Font
        frfc = Color.DarkGreen : frtfont = Button8.Font
        'خلفية اجزاء الصفحة بيانات الافتراضية
        hrbC = Brushes.Transparent
        hpbc = Brushes.Transparent
        fpbc = Brushes.Transparent
        frbc = Brushes.Transparent
        'اطار الجزاء الصفحةالبيانات الاساسية
        hrFramC = Color.Transparent : hrFramw = 1
        hpFramC = Color.Transparent : hpFramw = 1
        fpFramC = Color.Transparent : fpFramw = 1
        frFramC = Color.Transparent : frFramw = 1
        'تنسيق بيانات التفاصيل بيانات اساسية
        tableBc = Brushes.Transparent
        tableheadBc = Brushes.LightGray
        tableFramC = Color.Black
        tableFramW = 1
        tablecellFont = Button8.Font
        tablecellFC = Color.Black
        tableAlligen = Alligne.وسط
        'اعداد الصفحة
        mypages.SetPage(Pageland, page_mt, page_ml, page_mr, page_mb)
        mypages.PageFormateSetting(pageBc, pageFramC, pageFramw, pageFramDouble)

        'نصوص اجزاء الصفحة
        mypages.SetHeaderReportText(hrtText, hrtAllinge)
        mypages.SetHeaderpageText(hptText, hptAllinge)
        mypages.SetFooterPageText(fptText, fptAllinge)
        mypages.SetFooterReportText(frtText, frtAllinge)
        'خطوط اجزاء الصفحة
        mypages.SetHeaderReportFont(hrFC, hrtfont)
        mypages.SetHeaderpageFont(hpfc, hptfont)
        mypages.SetFooterPageFont(fpfc, fptfont)
        mypages.SetFooterReportFont(frfc, frtfont)

        'خلفية اجزاء الصفحة
        mypages.SetHeaderReportBackColor(hrbC)
        mypages.SetHeaderpageBackColor(hpbc)
        mypages.SetFooterPageBackColor(fpbc)
        mypages.SetFooterReportBackColor(frbc)
        'اطار الجزاء الصفحة
        mypages.SetHeaderReportFrames(hrFramC, hrFramw)
        mypages.SetHeaderPageFrames(hpFramC, hpFramw)
        mypages.SetFooterPageFrames(fpFramC, fpFramw)
        mypages.SetFooterReportFrames(frFramC, frFramw)
        Return mypages
    End Function

    Private Function ReportSetting() As ReportPrint
        Dim mypages As New ReportPrint


        'اعداد الصفحة
        mypages.SetPage(Pageland, page_mt, page_ml, page_mr, page_mb)
        mypages.PageFormateSetting(pageBc, pageFramC, pageFramw, pageFramDouble)

        'نصوص اجزاء الصفحة
        mypages.SetHeaderReportText(hrtText, hrtAllinge)
        mypages.SetHeaderpageText(hptText, hptAllinge)
        mypages.SetFooterPageText(fptText, fptAllinge)
        mypages.SetFooterReportText(frtText, frtAllinge)
        'خطوط اجزاء الصفحة
        mypages.SetHeaderReportFont(hrFC, hrtfont)
        mypages.SetHeaderpageFont(hpfc, hptfont)
        mypages.SetFooterPageFont(fpfc, fptfont)
        mypages.SetFooterReportFont(frfc, frtfont)

        'خلفية اجزاء الصفحة
        mypages.SetHeaderReportBackColor(hrbC)
        mypages.SetHeaderpageBackColor(hpbc)
        mypages.SetFooterPageBackColor(fpbc)
        mypages.SetFooterReportBackColor(frbc)
        'اطار الجزاء الصفحة
        mypages.SetHeaderReportFrames(hrFramC, hrFramw)
        mypages.SetHeaderPageFrames(hpFramC, hpFramw)
        mypages.SetFooterPageFrames(fpFramC, fpFramw)
        mypages.SetFooterReportFrames(frFramC, frFramw)
        'بيانات التفاصيل
        mypages.SetTableFrame(tableBc, tableFramC, tableFramW)
        mypages.SetTableFontCell(tablecellFC, tablecellFont, tableAlligen)
        mypages.SetTableFrameheaderCellBackColor(tableheadBc)

        Return mypages
    End Function


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        hrtText = TextBox1.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        hptText = TextBox3.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        fptText = TextBox6.Text
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        frtText = TextBox8.Text
    End Sub
    Dim txtC As Color
    Private Function TextFont(ByVal Btn As Button)
        Dim FontD As New FontDialog
        FontD.ShowColor = True
        FontD.ShowDialog()
        Btn.Font = FontD.Font
        Btn.ForeColor = FontD.Color
        txtC = Btn.ForeColor
        Return Btn.Font

    End Function
    Private Function reportPartBc(ByVal Btn As Button) As Brush

        Dim ColorD As New ColorDialog
        ColorD.SolidColorOnly = True
        ColorD.ShowDialog()
        Dim brushd As New SolidBrush(ColorD.Color)

        ColorD.Dispose()
        Btn.BackColor = brushd.Color
        Return brushd
    End Function
    Private Function reportPartFramC(ByVal Btn As Button) As Color
        Dim ColorD As New ColorDialog
        ColorD.SolidColorOnly = True
        ColorD.ShowDialog()

        Dim fac As New Color
        fac = ColorD.Color
        Btn.BackColor = fac
        Return fac
    End Function
    Private Function reportPartFramw(ByVal txt As TextBox) As Integer
        Return CInt(txt.Text)
    End Function
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim mypages As New ReportPrint
        repotpage = ReportSetting()
        mypages = repotpage
        'اخذ البيانات 
        mypages.Pages.Details.Table.setData(ZR_Datagrideview, GetDataGridRieghtoleft)
        PrintDocument1 = mypages.PrintDcument


        PrintDocument1.Print()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        hrtAllinge = TextAlligne(ComboBox1)
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        hptAllinge = TextAlligne(ComboBox2)
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        fptAllinge = TextAlligne(ComboBox3)
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        frtAllinge = TextAlligne(ComboBox4)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        hrtfont = TextFont(Button1)
        hrFC = txtC
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        hptfont = TextFont(Button8)
        hpfc = txtC
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        fptfont = TextFont(Button12)
        fpfc = txtC
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frtfont = TextFont(Button16)
        frfc = txtC
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        hrbC = reportPartBc(Button3)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frbc = reportPartBc(Button6)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        fpbc = reportPartBc(Button10)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        frbc = reportPartBc(Button14)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        hrFramC = reportPartFramC(Button4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        hpFramC = reportPartFramC(Button5)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        fpFramC = reportPartFramC(Button9)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frFramC = reportPartFramC(Button13)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        fpFramw = reportPartFramw(TextBox4)
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        hrFramw = reportPartFramw(TextBox5)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        hpFramw = reportPartFramw(TextBox2)
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        frFramw = reportPartFramw(TextBox7)
    End Sub
    Private dg As New DataGridView
  
#End Region
#Region "اختيار البيانات "
    Public Property DataGridview As DataGridView
        Get
            Return dg
        End Get
        Set(ByVal value As DataGridView)

            dg = value
        End Set
    End Property

    Private Sub GetCulloms()
        Dim dg As New DataGridView
        dg = ZR_Datagrideview

        Dim c As Integer = dg.ColumnCount
        Dim i As Integer = 0
        Do Until i = c
            ListBox1.Items.Add(i.ToString + "\  " + dg.Columns.Item(i).HeaderText)

            i += 1
        Loop


    End Sub
    Private Sub PageWithTest()

        pageWlbl.Text = repotpage.Pages.Details.DetailesPart.Rectangle.Width.ToString
        DataWlbl.Text = PageWith()
        PageWlbl2.Text = repotpage.Pages.Details.DetailesPart.Rectangle.Width.ToString
        DataWlbl2.Text = PageWith().ToString

        Dim pw, dw As Integer
        pw = CInt(pageWlbl.Text)
        dw = CInt(DataWlbl.Text)
        If pw < dw Then
            printpnl.Visible = False
        Else
            printpnl.Visible = True
        End If
    End Sub

    Private Function PageWith() As Integer
        Dim dg As New DataGridView
        dg = ZR_Datagrideview
        Dim CW, CC As Integer
        CC = dg.ColumnCount
        Dim i As Integer = 0
        Dim w As Integer
        For i = 0 To CC - 1
            CW = dg.Columns(i).Width
            w = w + CW
        Next
        Return w
    End Function
    Private Function num(ByVal s As String) As Integer
        Dim i As Integer : i = InStr(s, "\")
        Dim ss As String
        If i > 0 Then

            ss = Mid(s, 1, i - 1)
            Return CInt(ss)
        End If
        Return CInt(ss)
    End Function
    Private Function myPageSize(ByVal width As Integer) As Integer
        Static i As Integer = 0
        i += width
        Return i
    End Function
    Private Sub TestWith()
        Dim d, i As Integer
        d = CInt(DataWlbl2.Text)
        i = CInt(PageWlbl2.Text)
        If d > i Then
            DataSelectBtn.Visible = False
        Else
            DataSelectBtn.Visible = True
        End If
       
    End Sub
    Private Sub GetDeletedColums()
        Dim ii As Integer = 0
        Dim iii As Integer
        Dim iiiname As String
        Dim ss(ListBox1.Items.Count - 1) As Integer
        Dim ssname(UBound(ss)) As String

        Do Until ii = ListBox1.Items.Count
            iii = num(ListBox1.Items(ii).ToString)
            ss(ii) = iii
            ii += 1
        Loop
        ii = 0
        Do Until ii = ListBox1.Items.Count

            iiiname = ZR_Datagrideview.Columns(ss(ii)).Name

            ssname(ii) = iiiname
            ii += 1
        Loop
        deletedcollumname = ssname
    End Sub
    Public deletedcollumname As String()
#End Region
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        ListBox2.Items.Add(ListBox1.SelectedItem.ToString)
        DataWlbl2.Text = myPageSize(dg.Columns.Item(num(ListBox1.SelectedItem.ToString)).Width.ToString)
        ListBox1.Items.Remove(ListBox1.SelectedItem.ToString)
        TestWith()
    End Sub
    Private Sub ListBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyCode = Keys.Delete Then
            ListBox1.Items.Add(ListBox2.SelectedItem.ToString)
            DataWlbl2.Text = myPageSize(-dg.Columns.Item(num(ListBox2.SelectedItem.ToString)).Width.ToString)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
            TestWith()
        End If
    End Sub
    Private Sub DeleteCulloms()
        Dim i As Integer = 0
        Do Until i = ListBox1.Items.Count
            ZR_Datagrideview.Columns.Remove(deletedcollumname(i))

            i += 1
        Loop
    End Sub
    Private Sub DataSelectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSelectBtn.Click
        GetDeletedColums()
        DeleteCulloms()
        PageWithTest()
        DataSelectBtn.Visible = False
        ListBox1.Items.Clear()
    End Sub
    Dim dgvnew As New DataGridView
    Private Sub GetCulloms2()
        Dim dg As New DataGridView


        dg = DataGridview
        dgvnew = ZR_Datagrideview

        Dim r As Integer = 0
        Dim c As Integer = dg.ColumnCount
        Dim namc(c), header(c) As String

      
        Dim czr_dg As Integer = ZR_Datagrideview.ColumnCount
        Dim i As Integer = 0


        Dim id As Integer

        '' ZR_Datagrideviewاخد كل الاعمدة من الداتا جريد 
        '' Dgناخد الاعمدة من 
        ''يتم حذف العمود من المصفوفة
        Dim ss As String

        i = 0
        Do Until i = c
            ListBox1.Items.Add(i.ToString + "\  " + dg.Columns.Item(i).HeaderText)
            namc(i) = dg.Columns.Item(i).DataPropertyName
            header(i) = dg.Columns.Item(i).HeaderText
            i += 1

        Loop
        ' تعديل رؤوس الجدول 
        Do Until r = dg.Columns.Count

            ZR_Datagrideview.Columns(namc(r)).HeaderText = header(r)
            id = ZR_Datagrideview.Columns(namc(r)).Index
            dgvnew.Columns.Remove(namc(r))
            r += 1
        Loop
        r = 0
        dgvnew.Refresh()

        Do Until r = dgvnew.Columns.Count
            ListBox2.Items.Add(dgvnew.Columns.Item(r).HeaderText)
            r += 1
        Loop
    End Sub

    Public Sub gooWork()

        Dim deletedcollumnames As String()
        Dim dg As New DataGridView
        dg = DataGridview
        Dim ii As Integer = 0
        Dim iiiname As String
        Dim ss(ListBox2.Items.Count - 1) As Integer
        Dim ssname(UBound(ss)) As String
        Dim namc(dg.Columns.Count), header(dg.Columns.Count) As String

        ii = 0
        Do Until ii = ListBox2.Items.Count
            iiiname = ListBox2.Items(ii)
            ssname(ii) = iiiname
            ii += 1
        Loop
        deletedcollumnames = ssname

        Dim i As Integer = 0
        Do Until i = ListBox2.Items.Count
            ZR_Datagrideview.Columns.Remove(deletedcollumnames(i))

            i += 1
        Loop

        i = 0
        Do Until i = dg.Columns.Count
            namc(i) = dg.Columns.Item(i).DataPropertyName
            header(i) = dg.Columns.Item(i).HeaderText
            i += 1

        Loop
        i = 0
        Do Until i = dg.Columns.Count

            ZR_Datagrideview.Columns(namc(i)).HeaderText = header(i)

            i += 1
        Loop
        ListBox2.Items.Clear()
        pageWlbl.Text = repotpage.Pages.Details.DetailesPart.Rectangle.Width.ToString
        DataWlbl.Text = PageWith().ToString
        PageWlbl2.Text = pageWlbl.Text
        Dim pw, dw As Integer
        pw = CInt(pageWlbl.Text)
        dw = CInt(DataWlbl.Text)
        If pw < dw Then
            printpnl.Visible = False
        Else
            printpnl.Visible = True
        End If
        ListBox1.Items.Clear()
        i = 0
        Do Until i = ZR_Datagrideview.Columns.Count
            ListBox1.Items.Add(i.ToString + "\  " + ZR_Datagrideview.Columns.Item(i).HeaderText)
            namc(i) = ZR_Datagrideview.Columns.Item(i).DataPropertyName
            header(i) = ZR_Datagrideview.Columns.Item(i).HeaderText
            i += 1

        Loop
    End Sub
    Private Function GetDataGridRieghtoleft() As Boolean
        If ZR_Datagrideview.RightToLeft = Windows.Forms.RightToLeft.No Then
            Return False
        Else
            Return True
        End If

    End Function
 
    Private Sub ZR_Datagrideview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ZR_Datagrideview.CellContentClick

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetCulloms2()
        gooWork()
        DataSelectBtn.Visible = True
    End Sub

    Private Sub Button21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        repotpage = ReportDefultSetting()
        pageWlbl.Text = repotpage.Pages.Details.DetailesPart.Rectangle.Width.ToString
        DataWlbl.Text = PageWith().ToString
        PageWlbl2.Text = pageWlbl.Text
        Dim pw, dw As Integer
        pw = CInt(pageWlbl.Text)
        dw = CInt(DataWlbl.Text)
        If pw < dw Then
            printpnl.Visible = False
        Else
            printpnl.Visible = True
        End If
        ZR_Datagrideview.DataSource = DataGridview.DataSource
        ZR_Datagrideview.Font = tablecellFont
        ZR_Datagrideview.RightToLeft = DataGridview.RightToLeft
        ComboBox7.SelectedIndex = 0
        GetCulloms2()
    End Sub
End Class
