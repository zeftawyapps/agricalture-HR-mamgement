Imports ZeftawyTools
Public Class QulifaySearch
    Dim DataWork As New TashfeenDataBaseWork.OLEDataBaseBinding
    Private Sub QulifaySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.Qualifay' table. You can move, or remove it, as needed.
        Me.QualifayTableAdapter.Fill(Me.MydataDataSet.Qualifay)
        DataWork.loading(QualifayBindingSource, QualifayTableAdapter.Adapter, MydataDataSet.Qualifay, Me)
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        Datacontrol2B1.GetT_buttonColor(Me.T_button)
        T_textbox3.Focus()
    End Sub
    Private mohel As String
    Public Property Moahel() As String
        Get
            Return mohel
        End Get
        Set(ByVal value As String)
            mohel = value
        End Set
    End Property
    Private Sub Datacontrol2B1_addnew() Handles Datacontrol2B1.addnew
        QualifayBindingSource.AddNew()
        NewGrb.Visible = True
    End Sub
    Private Sub Datacontrol2B1_save() Handles Datacontrol2B1.save
        T_textbox4.Text = QulifayEnter()
        DataWork.saveing()
        Me.QualifayTableAdapter.Fill(Me.MydataDataSet.Qualifay)
        NewGrb.Visible = False
    End Sub
    Private Function QulifayEnter() As String
        Dim B As String = ComboBox1.Text
        Dim K As String = T_textbox2.Text
        Dim Dof3a As String = T_textbox3.Text
        Dim St As String = B + " " + K
        Return St
    End Function
    Private Sub GetData()
        Me.mohel = Me.Gam3iaDataGridView.CurrentRow.Cells.Item(0).Value + " " + T_textbox3.Text
        Me.Now3eea = Me.Gam3iaDataGridView.CurrentRow.Cells.Item(1).Value
        Me.Close()
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        GetData()
    End Sub
    Private Sub Gam3iaDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gam3iaDataGridView.CellDoubleClick
        GetData()
    End Sub   
    Private Sub Gam3iaDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Gam3iaDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetData()
        End If
    End Sub
    Dim dataFilter As New TashfeenDataBaseWork.DataFilter
    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged
        dataFilter.filteration(QualifayBindingSource, "Qulifay", T_textbox1.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)
    End Sub
    Private naw3 As String
    Public Property Now3eea() As String
        Get
            Return naw3
        End Get
        Set(ByVal value As String)
            naw3 = value
        End Set
    End Property
    Private Sub Datacontrol2B1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datacontrol2B1.Load

    End Sub
End Class