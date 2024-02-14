Imports ZeftawyTools
Public Class FinanceDegree
    Dim data, data1 As New TashfeenDataBaseWork.OLEDataBaseBinding
    Private Sub FinanceDegree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.EmpData' table. You can move, or remove it, as needed.
        Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)
        'TODO: This line of code loads data into the 'MydataDataSet.FinanceDegree' table. You can move, or remove it, as needed.
        Me.FinanceDegreeTableAdapter.Fill(Me.MydataDataSet.FinanceDegree)
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)
        data.loading(EmpDataBindingSource, EmpDataTableAdapter.Adapter, MydataDataSet.EmpData, Me)

        data1.loading(FinanceDegreeBindingSource, FinanceDegreeTableAdapter.Adapter, MydataDataSet.FinanceDegree, Me)

        DataPostion1.GetT_buttonColor(Me.T_button)
    End Sub
    Private Sub T_textbox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox1.TextChanged
        Me.FinanceDegreeTableAdapter.FillByName(Me.MydataDataSet.FinanceDegree, T_textbox1.Text)
    End Sub

    Private Sub T_textbox2_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles T_textbox2.MouseDoubleClick
        T_textbox2.Clear()
    End Sub

    Private Sub T_textbox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_textbox2.TextChanged
        Me.FinanceDegreeTableAdapter.FillByFinance(Me.MydataDataSet.FinanceDegree, T_textbox2.Text)
    End Sub
    Dim cap As New copypast
    Dim pos As Integer
    Private Sub T_button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FinanceDegreeBindingSource.MoveLast()
        pos = FinanceDegreeBindingSource.Position + 1
        cap.PastNew(Me.Gam3iaDataGridView, FinanceDegreeBindingSource, 0)

        FinanceDegreeBindingSource.Position = pos
        cap.pastvalue(Me.Gam3iaDataGridView, FinanceDegreeBindingSource, 1, ComboBox3.Text)

      
    End Sub
    Private Sub T_button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button1.Click
        data1.saveing()
        Me.FinanceDegreeTableAdapter.Fill(Me.MydataDataSet.FinanceDegree)
    End Sub
    Private Sub T_button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button6.Click
        FinaceDegreeTextBox.Text = ComboBox1.Text
    End Sub

    Private Sub T_button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button2.Click
        T_textbox1.Text = EmpNmeTextBox.Text
    End Sub

    Private Sub T_button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button4.Click
        FinaceDegreeTextBox.Text = FdegreeTextBox.Text
    End Sub

    Private Sub T_button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button5.Click
        data.saveing()
    End Sub

      Private Sub GetEmp()
        Dim gam As New Gam3eaSearchFrm
        gam.ShowDialog()
        T_textbox3.Text = gam.Gam3yaName
        If gam.Gam3yaName = "" Then gam.Close() : Exit Sub
        'Gamindex = gam.INdex
        gam.Close()


    End Sub
    Private Sub T_textbox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_textbox3.Enter
        GetEmp()
        Me.EmpDataTableAdapter.FillByGam(MydataDataSet.EmpData, T_textbox3.Text)

    End Sub
    Private Sub T_button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_button7.Click
        EmpNmeTextBox.Text = EmpNameTextBox.Text
    End Sub

    Private Sub T_button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FinanceDegreeBindingSource.MoveLast()
        pos = FinanceDegreeBindingSource.Position + 1
        cap.PastNew(Me.Gam3iaDataGridView, FinanceDegreeBindingSource, 0)
        FinanceDegreeBindingSource.Position = pos
        cap.pastvalue(Me.Gam3iaDataGridView, FinanceDegreeBindingSource, 1, ComboBox3.Text)

    End Sub

    Private Sub Gam3iaDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gam3iaDataGridView.CellContentClick

    End Sub

    Private Sub Gam3iaDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Gam3iaDataGridView.KeyDown
        If e.KeyCode = Keys.F1 Then

            Dim s As String
            
            Dim i As Integer = 0
            FinanceDegreeBindingSource.MoveFirst()

            Do Until i = FinanceDegreeBindingSource.Count - 1
                s = EmpNameTextBox.Text
                EmpNameTextBox.Text = WordProcesse.WordProcess(s)
                FinanceDegreeBindingSource.MoveNext()
                i += 1
            Loop

        End If
    End Sub
End Class