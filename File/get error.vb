Imports ZeftawyTools
Public Class get_error
    Inherits myformDesign
    Private Sub get_error_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MydataDataSet.EmpData' table. You can move, or remove it, as needed.
        Me.EmpDataTableAdapter.Fill(Me.MydataDataSet.EmpData)
        'TODO: This line of code loads data into the 'MydataDataSet.UnName' table. You can move, or remove it, as needed.
        'Me.UnNameTableAdapter.Fill(Me.MydataDataSet.UnName)
        myProjectWork.GetFormDesign(FormDesingne, Me, ZeftawyTools.recshaps.rectopreght)
        myProjectWork.changeTextforcolor(Me, T_textbox.BackColor)


    End Sub

    Private Sub UnNameBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UnNameBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MydataDataSet)

    End Sub
End Class