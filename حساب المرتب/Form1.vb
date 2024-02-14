Public Class Form1
    Dim HSalary As New SalaryAdded
    Dim dSalary As New salaryDeduction


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HSalary.Assasy = CSng(Assasytxt.Text)
        g15txt.Text = HSalary.getHokoma15.ToString
        g1txt.Text = HSalary.getHokoma1.ToString
        g2txt.Text = HSalary.getHokoma2.ToString
        g1_5txt.Text = HSalary.getHokoma1_5.ToString
        HSalary.SetBadalHwaf(CSng(txtb1.Text), CSng(txtb2.Text), CSng(txtb3.Text), CSng(txtb4.Text), CSng(txtb5.Text), CSng(txtEg6.Text), CSng(txteg4.Text), CSng(txthd.Text))
        HSalary.SetBadal3adwaa(CSng(txtbad3.Text), CSng(txtbadtf.Text), CSng(txtmenhaa.Text))
        txt200.Text = HSalary.Get200.ToString
        txtTotalhwa.Text = HSalary.TotalHeafeez
        txtmot1.Text = HSalary.getmotgher1.ToString
        Txtmot15.Text = HSalary.getmotgher15.ToString
        txtTotalAdd.Text = HSalary.totalADDED.ToString
        txt75.Text = HSalary.Get75
        txt125.Text = HSalary.Get125
    End Sub

    Private Sub txtb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtb1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dSalary.Assasy = CSng(Assasytxt.Text)
        dSalary.SetTotalHafez = CSng(txtTotalhwa.Text)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class