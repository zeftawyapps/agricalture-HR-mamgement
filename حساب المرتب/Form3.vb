Public Class Form3
    Private cost As Custom()
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cost = {New Custom("mohamed", 5, "tanta"), _
                New Custom("ahmad", 15, "cairo"), _
             New Custom("ali", 20, "tanta")}
        'Dim i = From x In cost _
        '         Where x.Age > 5 _
        ''         Select x.name
        'i.Where(Function(n As Integer) n = 5)
        'For Each c In i
        '    ListBox1.Items.Add(c)
        'Next

        'Dim x = i.Where(Function(q) q.IndexOf = 1)

        'For Each c In x
        '    ListBox2.Items.Add(c)
        'Next
    End Sub
End Class
Public Class Custom
    Public name As String
    Public Age As Integer
    Public city As String
    Public Sub New(ByVal n, ByVal a, ByVal c)
        name = n
        Age = a
        city = c
    End Sub
    Public Sub New()

    End Sub
End Class