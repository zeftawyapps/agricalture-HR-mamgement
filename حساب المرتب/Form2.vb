Public Class Form2

  

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.EmpData' table. You can move, or remove it, as needed.
        Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)
        'TODO: This line of code loads data into the 'MydataDataSet1.EmpData' table. You can move, or remove it, as needed.
        EmpDataDataGridView.DataSource = EmpDataTableAdapter.ScalarQuery

    End Sub

    Private Sub EmpDataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MydataDataSet)

    End Sub
End Class