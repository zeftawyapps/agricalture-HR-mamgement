Imports ZeftawyTools
Public Class jobDescriptionFrm
    Dim DataWork As New TashfeenDataBaseWork.OLEDataBaseBinding
    Private Sub QulifaySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.Job' table. You can move, or remove it, as needed.
        Me.JobTableAdapter.Fill(Me.MydataDataSet.Job)
        'TODO: This line of code loads data into the 'MydataDataSet.Qualifay' table. You can move, or remove it, as needed.
        DataWork.loading(JobBindingSource, JobTableAdapter.Adapter, MydataDataSet.Job, Me)
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        Datacontrol2B1.GetT_buttonColor(Me.T_button)
        T_textbox1.Focus()
    End Sub
    Private mohel, naow As String
    Public Property Jop() As String
        Get
            Return mohel
        End Get
        Set(ByVal value As String)
            mohel = value
        End Set
    End Property

  


    Private Sub Datacontrol2B1_addnew() Handles Datacontrol2B1.addnew
        JobBindingSource.AddNew()
        NewGrb.Visible = True
    End Sub
    Private Sub Datacontrol2B1_save() Handles Datacontrol2B1.save

        DataWork.saveing()
        Me.JobTableAdapter.Fill(Me.MydataDataSet.Job)
        NewGrb.Visible = False
    End Sub
   
    Private Sub GetData()
        Me.Jop = Me.Gam3iaDataGridView.CurrentRow.Cells.Item(0).Value
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
        If e.KeyCode = Keys.F1 Then
            NewGrb.Visible = True
        End If
    End Sub
    Dim dataFilter As New TashfeenDataBaseWork.DataFilter
    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged
        dataFilter.filteration(JobBindingSource, "Jop", T_textbox1.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)
    End Sub

    Private Sub Gam3iaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gam3iaDataGridView.CellContentClick
           End Sub
End Class