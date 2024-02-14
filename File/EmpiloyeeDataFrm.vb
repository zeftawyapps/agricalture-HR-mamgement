Imports ZeftawyTools
Public Class EmpiloyeeDataFrm
    Inherits myformDesign
    Dim CP As New copypast
    Dim SaveCase, ReportCase As Integer
    Dim dataWork As New TashfeenDataBaseWork.OLEDataBaseBinding
    Const IDEror As String = "الرقم القومي خطأ"
    Const NameEror As String = "الاسم خطأ"
    Const Gam3yaError As String = "الجمعية غلط  "
    Const Visa As String = "فيزا"
    Const VisaAndSer As String = "فيزا - رقم سري "
    Const NoVisa As String = "لا فيزا"
    Private Sub EmpiloyeeDataFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.EmpData' table. You can move, or remove it, as needed.
        'Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)
        SaveCase = 1 'في حالة التحميل العادي
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        Datacontrol3B1.GetT_buttonColor(Me.T_button)
        DataPostion1.GetT_buttonColor(Me.T_button)
        DataPostion1.pchang()
        dataWork.loading(EmpDataBindingSource, Me.EmpDataTableAdapter.Adapter, MydataDataSet.EmpData, Me, DataPostion1)
        dataWork.showDatabyReaderTocombobox(Visacasecom, "isIDReght", "EmpData", EmpDataTableAdapter.Connection)
        EmpDataDataGridView.Focus()
    End Sub
   
    Private Sub T_textbox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gam3SearchTxt.Enter

        Dim gam As New Gam3eaSearchFrm
        gam.ShowDialog()
        If gam.Gam3yaName = "" Then gam.Close() : Exit Sub
        Gam3SearchTxt.Text = gam.Gam3yaName

        gam.Close()

    End Sub
    Private Sub Datacontrol3B1_addnew() Handles Datacontrol3B1.addnew
        dataWork.addingNew()
    End Sub
    Private Sub Datacontrol3B1_delet() Handles Datacontrol3B1.delet
        dataWork.delete()
    End Sub
    Private Sub Datacontrol3B1_save() Handles Datacontrol3B1.save
        NameProcess()
        dataWork.saveing()
        SaveCases(SaveCase)

    End Sub

    Private Sub NmaeSearchTxt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NmaeSearchTxt.DoubleClick
        NmaeSearchTxt.Clear()
    End Sub
    Private Sub NmaeSearchTxt_pressEnter() Handles NmaeSearchTxt.pressEnter
        Dim x As Object = NmaeSearchTxt.Text
        If IsNumeric(x) Then
            Me.EmpDataTableAdapter.FillByNid(MydataDataSet.EmpData, NmaeSearchTxt.Text)
            SaveCase = 4 ' بحث رقم قومي
        Else
            Dim s, serach As String
            s = NmaeSearchTxt.Text
            serach = WordProcesse.WordProcess(s)
            NmaeSearchTxt.Text = serach
            Me.EmpDataTableAdapter.FillByName(MydataDataSet.EmpData, serach)
            SaveCase = 3 ' بحث باسم

        End If

        EmpDataDataGridView.Focus()
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EmpDataTableAdapter.FillByName(MydataDataSet.EmpData, NmaeSearchTxt.Text)
        SaveCase = 3 ' بحث باسم
    End Sub
    Private Sub Gam3SearchTxt_pressEnter() Handles Gam3SearchTxt.pressEnter
        Me.EmpDataTableAdapter.FillByGam(MydataDataSet.EmpData, Gam3SearchTxt.Text)
        GroupBox2.Visible = True
        SaveCase = 2 ' بحث جمعية
              EmpDataDataGridView.Focus()
    End Sub
    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EmpDataTableAdapter.FillByGam(MydataDataSet.EmpData, Gam3SearchTxt.Text)
        GroupBox2.Visible = True
        SaveCase = 2 ' بحث جمعية
    End Sub
    Private Sub SaveCases(ByVal TheCase As Integer)
        Dim p As Integer
        p = Me.EmpDataBindingSource.Position
        Select Case TheCase
            Case 1
                Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)

            Case 2
                Me.EmpDataTableAdapter.FillByGam(MydataDataSet.EmpData, Gam3SearchTxt.Text)

            Case 3
                Me.EmpDataTableAdapter.FillByName(MydataDataSet.EmpData, NmaeSearchTxt.Text)
            Case 4
                Me.EmpDataTableAdapter.FillByNid(MydataDataSet.EmpData, NmaeSearchTxt.Text)

        End Select
        EmpDataBindingSource.Position = p
        dataWork.showDatabyReaderTocombobox(Visacasecom, "isIDReght", "EmpData", EmpDataTableAdapter.Connection)

    End Sub
    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO: This line of code loads data into the 'MydataDataSet.EmpData' table. You can move, or remove it, as needed.
        Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)
        SaveCase = 1
    End Sub
    Dim qul, noaw As String
    Private Sub DatagrideStyl()
        Dim h As String = "  F12:ادخال تاريخ الميلاد  و المعاش طبقا للرقم القومي   F11: ادخال الوظيفة  F10:ادخال المؤهل  F9:ادخال العنوان"
        Select Case EmpDataDataGridView.CurrentCell.ColumnIndex
            Case 0
                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkRed
                helpLable.Text = "F1 :تغيير اسم الجمعية  enter  ادخال الجمعية التي في صندوق النص " + h
            Case 2
                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkSlateGray
                helpLable.Text = "F1:له فيزا او رقم سري  F2:استلم الفيزا و الرقم السري  F3:يوجد خطا في الاسم او الرقم القومي او ليس له فيزا  F4:نقل عن الجميعة   F5: تاكيد نقل الجمعية " + h
            Case 12
                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkSeaGreen
                helpLable.Text = "  F1 : ادخال المؤهل" + h
            Case 13
                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkOrchid
                helpLable.Text = "  F1 : ادخال الوظيفة و الدرجة الوظيفية" + h

            Case 14
                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkKhaki
                helpLable.Text = "  F1 : ادخال تاريخ الميلاد و المعاش" + h

            Case 15

                EmpDataDataGridView.CurrentCell.Style.SelectionBackColor = Color.DarkBlue
                helpLable.Text = "  F1 : تاريخ الميلاد و المعاش" + h

            Case Else
                helpLable.Text = h
        End Select

      
    End Sub

    Private Sub EmpDataDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpDataDataGridView.CellDoubleClick
        If EmpDataDataGridView.CurrentCell.ColumnIndex = 0 Then

            Gam3yaEnter()
        End If
    End Sub
    Private Sub EmpDataDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpDataDataGridView.CellEnter
           DataPostion1.pchang()
        DatagrideStyl()
    End Sub
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Gam3yaEnter()
    End Sub
    Private Sub Gam3yaEnter()
        If Gam3SearchTxt.Text = "اسم الجمعية " Then GoTo ss
        Gsm3iatxt.Text = Gam3SearchTxt.Text
        empindex += 1
        EmpCodeTxt.Text = (empindex).ToString
ss:
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub jobnEnter()
        If qul = "" Then Exit Sub
        jopTxt.Text = qul

        Degreetxt.Text = Darga(Inputbox("اخل الدرجة على شكل رقم"))
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub QulifcationEnter()
        If qul = "" Then Exit Sub
        QualifcationTxt.Text = qul
        naw3iaTxt.Text = noaw
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub EmpDataDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EmpDataDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 0 Then
                Gam3yaEnter()
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 0 Then
                GetEmp()
            End If
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 2 Then
                GetVisaCase()
            End If
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 8 Then
                Getfinance()
            End If
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 1 Then
                empindex = CInt(Inputbox("ادخل رقم المسلسل"))
                empindex -= 1
                Gam3yaEnter()
            End If
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 12 Then
                Getqul()
            End If

            If EmpDataDataGridView.CurrentCell.ColumnIndex = 13 Then
                Getjob()
            End If
            If EmpDataDataGridView.CurrentCell.ColumnIndex = 14 Then
                getParthDate()
            End If
        End If
        Select Case e.KeyCode
            Case Keys.F9
                GetAddress()
            Case Keys.F10
                Getqul()
            Case Keys.F11
                Getjob()
                         Case Keys.F12
                NameProcess()
                GetParthDataFromId()

            Case Keys.F2
                If EmpDataDataGridView.CurrentCell.ColumnIndex = 2 Then


                    Dim ss As String
                    ss = EmpDataDataGridView.CurrentRow.Cells(2).Value.ToString
                    If ss = Visa Then
                        EmpDataDataGridView.CurrentRow.Cells(2).Value = "استلام" + " " + ss
                    ElseIf ss = "فيزا-رقم سري" Then
                        EmpDataDataGridView.CurrentRow.Cells(2).Value = "استلام" + " " + ss

                    End If
                End If
                dataWork.saveing()
                SaveCases(SaveCase)
                'CP.openFile()
            Case Keys.F3
                getError()
                'CP.past(EmpDataDataGridView, EmpDataBindingSource)
            Case Keys.F4
                Gam3yaaEror()
            Case Keys.F5
                newGam3yaa()
            Case Keys.F7
                wordprocess()
        End Select
    End Sub
    Private Sub getError()
        Dim x As String = Inputbox("ادخل الخطأ")
        If IsNumeric(x) Then
            Dim i As Integer = Len(x)
            If Not i = 14 Then
                msgbox("ادخل الرقم القومي 14 رقم يابني", msgtype.oK)
                Exit Sub
            End If
            EmpDataDataGridView.CurrentRow.Cells(2).Value = IDEror

            Me.EmpDataDataGridView.CurrentRow.Cells(18).Value = EmpIDtxt.Text
            EmpIDtxt.Text = x
        ElseIf x = "" Then
            EmpDataDataGridView.CurrentRow.Cells(2).Value = NoVisa
        Else
            Dim s As String = x
            x = WordProcesse.WordProcess(x)
            EmpDataDataGridView.CurrentRow.Cells(2).Value = NameEror

            Me.EmpDataDataGridView.CurrentRow.Cells(18).Value = EmpNametxt.Text
            EmpNametxt.Text = x
        End If
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub Gam3yaaEror()
        Dim gam As New Gam3eaSearchFrm
        gam.ShowDialog()
        If gam.Gam3yaName = "" Then gam.Close() : Exit Sub
        Me.EmpDataDataGridView.CurrentRow.Cells(18).Value = gam.Gam3yaName
        EmpDataDataGridView.CurrentRow.Cells(2).Value = Gam3yaError
        dataWork.saveing()
        SaveCases(SaveCase)
      
    End Sub
    Private Sub newGam3yaa()
        Dim x As String = EmpDataDataGridView.CurrentRow.Cells(2).Value
        Dim g As String = Me.EmpDataDataGridView.CurrentRow.Cells(18).Value
        If x = Gam3yaError And Not g = "" Then
            EmpDataDataGridView.CurrentRow.Cells(2).Value = ""
            EmpDataDataGridView.CurrentRow.Cells(18).Value = ""
            EmpDataDataGridView.CurrentRow.Cells(0).Value = g

            dataWork.saveing()
            SaveCases(SaveCase)
                Else

        End If
    End Sub
    Dim Gamindex As String : Dim empindex As Integer = 0
    Private Sub GetVisaCase()
        Dim s As String
        s = EmpDataDataGridView.CurrentCell.Value.ToString
        Select Case s
            Case ""
                s = "فيزا"
            Case "فيزا"
                s = "فيزا-رقم سري"

        End Select
        EmpDataDataGridView.CurrentRow.Cells(2).Value = s

        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub GetAddress()
        Dim x As String = Inputbox("ادخل العنوان")
        Addresstxt.Text = x

        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Function Darga(ByVal x As Integer) As String
        Select Case x
            Case 1
                Return "1- اولى"
            Case 2
                Return "2- ثانية"
            Case 3
                Return "3- ثالثة"
            Case 4
                Return "4- رابعة"
            Case 5
                Return "5- خامسة"
            Case 6
                Return "6- سادسة"
            Case 0
                Return "0- كبير"
            Case Else
                Return "6- سادسة"
        End Select
    End Function
    Private Sub GetEmp()
        Dim gam As New Gam3eaSearchFrm
        gam.ShowDialog()
        Gam3SearchTxt.Text = gam.Gam3yaName
        If gam.Gam3yaName = "" Then gam.Close() : Exit Sub
        'Gamindex = gam.INdex
        gam.Close()
        Gam3yaEnter()
    End Sub

    Private Sub Getfinance()
        Dim gam As New FinanceDegree
        gam.Name = EmpNametxt.Text
        gam.ShowDialog()


        'Gamindex = gam.INdex
        gam.Close()
        SaveCases(SaveCase)
    End Sub
    Private Sub Getqul()
        Dim Quli As New QulifaySearch
        Quli.ShowDialog()
        qul = Quli.Moahel
        noaw = Quli.Now3eea
        If qul = "" Then Quli.Close() : Exit Sub

        Quli.Close()
        QulifcationEnter()
    End Sub
    Private Sub Getjob()
        Dim job As New jobDescriptionFrm
        job.ShowDialog()
        qul = job.Jop
        job.Close()
        jobnEnter()
    End Sub
    Private Sub getParthDate()
        Dim x As String = Inputbox("ادخل التاريخ")
        Dim d As Date = WordProcesse.DateProssce(x)
        ParthDatetxt.Text = Format(d, "dd/MM/yyyy")
        m3ashDatetxt.Text = DateAdd(DateInterval.Year, 60, d)
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub ParthDatetxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParthDatetxt.Enter
        getParthDate()
    End Sub
    Private Sub QualifcationTxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles QualifcationTxt.Enter
        Getqul()
    End Sub
    Private Sub jopTxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles jopTxt.Enter
        Getjob()
    End Sub
    Private Sub GetParthDataFromId()
        Dim iD As String = EmpIDtxt.Text
        Dim getmydate As String = Mid(iD, 2, 6)

        Dim d As String = Mid(getmydate, 5, 2)
        Dim M As String = Mid(getmydate, 3, 2)
        Dim y As String = Mid(getmydate, 1, 2)
        Dim x As String = d + M + "19" + y

        Dim dt As Date = WordProcesse.DateProssce(x)
        ParthDatetxt.Text = Format(dt, "dd/MM/yyyy")
        m3ashDatetxt.Text = DateAdd(DateInterval.Year, 60, dt)
      
        dataWork.saveing()
        SaveCases(SaveCase)
    End Sub
    Private Sub NameProcess()
        Dim s As String
        s = EmpNametxt.Text
        EmpNametxt.Text = WordProcesse.WordProcess(s)
        'dataWork.saveing()
        'SaveCases(SaveCase)
    End Sub
    Private Function RightToleftTxt(ByVal txt As String) As String
        Dim i As Integer = Len(txt)
        Dim Ch(i - 1) As Char
        Dim i0 As Integer = 0
        Do While i0 < i
            Ch(i0) = Mid(txt, i0 + 1, 1)
            i0 += 1
        Loop
        i0 = i - 1
        Dim s As String = Ch(i0)
        Do Until i0 = 0
            Dim dd As String = Ch(i0 - 1)
            s = s + dd
            i0 = i0 - 1
        Loop
        Return s
    End Function
    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EmpDataTableAdapter.FillByNid(MydataDataSet.EmpData, NmaeSearchTxt.Text)
        SaveCase = 4 ' بحث باسم
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SaveCases(1)
        Timer1.Enabled = False
    End Sub

    Private Sub EmpDataDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpDataDataGridView.CellContentClick


    End Sub

    Private Sub Gam3SearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gam3SearchTxt.TextChanged

    End Sub

    Private Sub Datacontrol3B1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datacontrol3B1.Load

    End Sub

    Private Sub NmaeSearchTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmaeSearchTxt.TextChanged

    End Sub
    Private Sub wordprocess()
        Dim i As Integer = 0
        EmpDataBindingSource.MoveFirst()
        Dim s As String
        Do Until i = EmpDataBindingSource.Count - 1
            s = EmpNametxt.Text
            EmpNametxt.Text = WordProcesse.WordProcess(s)
            EmpDataBindingSource.MoveNext()
            i += 1
        Loop
    End Sub
    'Private Sub T_button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button6.Click
    '    Dim i As Integer = 0
    '    EmpDataBindingSource.MoveFirst()
    '    Dim s As String
    '    Do Until i = EmpDataBindingSource.Count - 1
    '        s = naw3iaTxt.Text
    '        naw3iaTxt.Text = WordProcesse.WordProcess(s)
    '        EmpDataBindingSource.MoveNext()
    '        i += 1
    '    Loop
    'End Sub

    Private Sub EmpNametxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpNametxt.TextChanged

    End Sub

    Private Sub Visacasecom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visacasecom.SelectedIndexChanged
        Dim s As String
        s = Gam3SearchTxt.Text
        Dim v As String = Visacasecom.Text
        If v = "" Then v = "ISNULL"
        If s = "اسم الجمعية " Then
            EmpDataTableAdapter.FillByIDNameNoGam3yaa(MydataDataSet.EmpData, v)
            ReportCase = 1
        Else

            EmpDataTableAdapter.FillByErrors(MydataDataSet.EmpData, Gam3SearchTxt.Text, v)
            ReportCase = 2
        End If
        EmpDataDataGridView.Focus()
    End Sub

    Private Sub T_button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button5.Click
        Dim s As String
        s = Gam3SearchTxt.Text
        'If s = "اسم الجمعية " Then
        '    EmpDataTableAdapter.FillByIDNameNoGam3yaa(MydataDataSet.EmpData, NoVisa)
        '    Dim Report As New ReportFrm

        '    Dim cr As New NoGam3novisa
        '    Dim datatable As New DataTable
        '    datatable = MydataDataSet.EmpData
        '    cr.SetDataSource(datatable)

        '    Report.CrystalReportViewer1.ReportSource = cr
        '    Report.WindowState = FormWindowState.Maximized
        '    Report.Show()

        'Else
        'EmpDataTableAdapter.FillByErrors(MydataDataSet.EmpData, Gam3SearchTxt.Text, NoVisa)
        'printReportnovisa()
        'End If

    End Sub
    Private Sub printReportnovisa()
        '    Dim Report As New ReportFrm

        '    Dim cr As New novisa
        '    Dim datatable As New DataTable
        '    datatable = MydataDataSet.EmpData
        '    cr.SetDataSource(datatable)

        '    Report.CrystalReportViewer1.ReportSource = cr
        '    Report.WindowState = FormWindowState.Maximized
        '    Report.Show()
        'End Sub

        'Private Sub T_button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        '    Dim s As String
        '    s = Gam3SearchTxt.Text
        '    If s = "اسم الجمعية " Then
        '        EmpDataTableAdapter.FillByIDNameNoGam3yaa(MydataDataSet.EmpData, IDEror)
        '        Dim Report As New ReportFrm

        '        Dim cr As New NoGamIDError
        '        Dim datatable As New DataTable
        '        datatable = MydataDataSet.EmpData
        '        cr.SetDataSource(datatable)

        '        Report.CrystalReportViewer1.ReportSource = cr
        '        Report.WindowState = FormWindowState.Maximized
        '        Report.Show()

        '    Else
        '        EmpDataTableAdapter.FillByErrors(MydataDataSet.EmpData, Gam3SearchTxt.Text, IDEror)
        '        Dim Report As New ReportFrm
        '        Dim cr As New IDError
        '        Dim datatable As New DataTable
        '        datatable = MydataDataSet.EmpData
        '        cr.SetDataSource(datatable)

        '        Report.CrystalReportViewer1.ReportSource = cr
        '        Report.WindowState = FormWindowState.Maximized
        '        Report.Show()
        '    End If


        'End Sub

    End Sub
    Private Sub T_button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Dim s As String
        s = Gam3SearchTxt.Text
        'If s = "اسم الجمعية " Then
        '    EmpDataTableAdapter.FillByIDNameNoGam3yaa(MydataDataSet.EmpData, NameEror)
        '    Dim Report As New ReportFrm

        '    Dim cr As New NoGamNameError
        '    Dim datatable As New DataTable
        '    datatable = MydataDataSet.EmpData
        '    cr.SetDataSource(datatable)

        '    Report.CrystalReportViewer1.ReportSource = cr
        '    Report.WindowState = FormWindowState.Maximized
        '    Report.Show()

        'Else
        '    EmpDataTableAdapter.FillByErrors(MydataDataSet.EmpData, Gam3SearchTxt.Text, NameEror)

        '    Dim Report As New ReportFrm
        '    Dim cr As New NameError
        '    Dim datatable As New DataTable
        '    datatable = MydataDataSet.EmpData
        '    cr.SetDataSource(datatable)

        '    Report.CrystalReportViewer1.ReportSource = cr
        '    Report.WindowState = FormWindowState.Maximized
        '    Report.Show()
        'End If

    End Sub

    Private Sub T_button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        EmpDataTableAdapter.FillByIDNameNoGam3yaa(MydataDataSet.EmpData, Gam3yaError)

        'Dim Report As New ReportFrm
        'Dim cr As New Gam3yaaError
        'Dim datatable As New DataTable
        'datatable = MydataDataSet.EmpData
        'cr.SetDataSource(datatable)

        'Report.CrystalReportViewer1.ReportSource = cr
        'Report.WindowState = FormWindowState.Maximized
        'Report.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub T_button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        Dim print As New ZeftawyReport
        print.ReportDesignControl1.DataGridview = Me.EmpDataDataGridView

        print.ShowDialog()
        print.Close()
    End Sub
End Class