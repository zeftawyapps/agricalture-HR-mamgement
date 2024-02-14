Imports ZeftawyTools
Public Class Gam3eaSearchFrm
    Inherits myformDesign
    Private Sub Gam3eaSearchFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.Gam3ia' table. You can move, or remove it, as needed.
              myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        Me.Gam3iaTableAdapter.Fill(Me.MydataDataSet.Gam3ia)
        T_textbox1.Focus()
    End Sub
    Private Sub GetData()
        Me.Gam3yaName = Me.Gam3iaDataGridView.CurrentCell.Value
        Me.INdex = Me.Gam3iaBindingSource.Position
        Me.Close()
    End Sub
    Dim DataFilter As New TashfeenDataBaseWork.DataFilter
    Dim Gam As String
    ''' <summary>
    ''' اظهار اسماء الجمعيات 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Gam3yaName() As String
        Get
            Return Gam
        End Get
        Set(ByVal value As String)
            Gam = value
        End Set
    End Property
    Dim INd As String
    ''' <summary>
    ''' رقم الجمعية 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property INdex() As String
        Get
            Return INd
        End Get
        Set(ByVal value As String)
            INd = value
        End Set
    End Property

    Private Sub T_textbox1_pressEnter() Handles T_textbox1.pressEnter
        Gam3iaDataGridView.Focus()
    End Sub
    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged
        DataFilter.filteration(Gam3iaBindingSource, "Gam3iaName", T_textbox1.Text, TashfeenDataBaseWork.DataFilter.feildtyp.simistring)
    End Sub

    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        GetData()
    End Sub

    Private Sub Gam3iaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gam3iaDataGridView.CellContentClick

    End Sub

    Private Sub Gam3iaDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Gam3iaDataGridView.DoubleClick
        GetData()
    End Sub

    Private Sub Gam3iaDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Gam3iaDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetData()
        End If
    End Sub
End Class