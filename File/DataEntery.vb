Imports ZeftawyTools
Public Class DataEntery
    Inherits myformDesign
    Dim DataF As New TashfeenDataBaseWork.DataFilter
    Dim dgv As New DataGrideVeiwWorks
    Private Sub DataEntery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopleft)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        dgv.DataGridView = Me.HokmsDataGridView

        Timer1.Enabled = True
    End Sub
    Private Sub looding()
        'TODO: This line of code loads data into the 'MydataDataSet.Hokms' table. You can move, or remove it, as needed.
        Me.HokmsTableAdapter.FillByEntery(Me.MydataDataSet.Hokms)
      
    End Sub
    Private Sub Save()
        Me.Validate()
        Me.HokmsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MydataDataSet)
        Me.HokmsTableAdapter.FillByEntery(Me.MydataDataSet.Hokms)
        msgbox("تم الحفظ")
    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        Save()
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        Me.HokmsTableAdapter.Fill(Me.MydataDataSet.Hokms)
        msgbox("تم اظهار كل السجلات")
    End Sub

    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button3.Click
        HokmsBindingSource.AddNew()
        dgv.setDataFromDatagridview(0, T_textbox1.Text)
    End Sub

    Private Sub T_textbox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox2.TextChanged
        DataF.filteration(HokmsBindingSource, "Name", T_textbox2.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)
    End Sub

    Private Sub T_textbox3_pressEnter() Handles T_textbox3.pressEnter
        If T_textbox3.Text = "0" Then
            DataF.filteration(HokmsBindingSource, "Name", "", TashfeenDataBaseWork.DataFilter.feildtyp.simistring)

            Exit Sub
        End If


        DataF.filteration(HokmsBindingSource, "PageNo", T_textbox3.Text, TashfeenDataBaseWork.DataFilter.feildtyp.int)

    End Sub

    Private Sub T_textbox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox3.TextChanged
  
    End Sub

    Private Sub T_textbox4_pressEnter() Handles T_textbox4.pressEnter
        If T_textbox4.Text = "0" Then
            DataF.filteration(HokmsBindingSource, "Name", "", TashfeenDataBaseWork.DataFilter.feildtyp.simistring)

            Exit Sub
        End If
        DataF.filteration(HokmsBindingSource, "Da3waNo", T_textbox4.Text, TashfeenDataBaseWork.DataFilter.feildtyp.int)

    End Sub

    Private Sub PostDawn(ByVal newtxt As String, ByVal dgv As DataGridView)
        Dim curntCollmn, rcount, curntcell As Integer : Dim txt As String

        rcount = dgv.RowCount
        curntcell = dgv.CurrentRow.Index
        curntCollmn = dgv.CurrentCell.ColumnIndex
        txt = dgv.CurrentCell.Value
        Do Until curntcell = rcount - 1

            dgv.Rows.Item(curntcell).Cells.Item(dgv.CurrentCell.ColumnIndex).Value = newtxt
            newtxt = txt
            curntcell += 1
            txt = dgv.Rows.Item(curntcell).Cells.Item(dgv.CurrentCell.ColumnIndex).Value

        Loop
         
    End Sub

    Private Sub HokmsDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HokmsDataGridView.KeyDown
        If e.KeyCode = Keys.F2 Then
            PostDawn("", Me.HokmsDataGridView)
        End If
        If e.KeyCode = Keys.F1 Then
            If isHokmRight() Then
                Dim i As Integer = HokmsBindingSource.Position
                Save()
                HokmsBindingSource.Position = i
            Else
                msgbox("يوجد فرق" + fark.ToString)

            End If
        End If
    End Sub
    'Private Sub PostUp(ByVal newtxt As String, ByVal dgv As DataGridView)
    '    Dim curntCollmn, rcount, curntcell As Integer : Dim txt As String

    '    rcount = dgv.RowCount
    '    curntcell = dgv.CurrentRow.Index
    '    curntCollmn = dgv.CurrentCell.ColumnIndex
    '    txt = dgv.CurrentCell.Value
    '    Do Until curntcell = rcount - 1

    '        dgv.Rows.Item(curntcell).Cells.Item(dgv.CurrentCell.ColumnIndex).Value = newtxt
    '        newtxt = txt
    '        curntcell += 1
    '        txt = dgv.Rows.Item(curntcell).Cells.Item(dgv.CurrentCell.ColumnIndex).Value

    '    Loop

    'End Sub
    Private Function isHokmRight() As Boolean
        On Error Resume Next
        Dim Assasy, _1, _2, _3, _4, _5, _6 As Single
        Dim Res, malagh As Single
        Assasy = dgv.GetDataFromDatagridview(5)
        _1 = dgv.GetDataFromDatagridview(6)
        _2 = dgv.GetDataFromDatagridview(7)
        _3 = dgv.GetDataFromDatagridview(8)
        _4 = dgv.GetDataFromDatagridview(9)
        _5 = dgv.GetDataFromDatagridview(10)
        _6 = dgv.GetDataFromDatagridview(11)
        malagh = dgv.GetDataFromDatagridview(12)
        Dim Days As Integer = dgv.GetDataFromDatagridview(4)
        Dim Sume As Single = Assasy + _1 + _2 + _3 + _4 + _5 + _6
        Res = (Sume * 12 * Days) / 365

        fark = Res - malagh
        If fark > 0.05 Then
            Return False
        Else

            Return True
        End If
    End Function
    Dim fark As Single
    Private Sub HokmsDataGridView_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles HokmsDataGridView.UserAddedRow
        dgv.setDataFromDatagridview(0, T_textbox1.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        looding()
        Timer1.Enabled = False
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        PostDawn("", Me.HokmsDataGridView)
    End Sub

   
    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button5.Click
        Me.HokmsTableAdapter.FillByprint(Me.MydataDataSet.Hokms)

        'Dim Report As New ReportFrm
        'Dim cr As New CrystalReport1
        'Dim datatable As New DataTable
        'datatable = MydataDataSet.Hokms
        'cr.SetDataSource(datatable)
        'Report.CrystalReport11 = cr
        'Report.CrystalReportViewer1.ReportSource = cr
        'Report.Show()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class