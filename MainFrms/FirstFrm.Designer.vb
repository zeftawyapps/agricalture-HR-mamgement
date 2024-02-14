<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstFrm
    Inherits ZeftawyTools.WelcomeFrm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(85, 354)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(113, 313)
        Me.Label1.Text = "تطوير معاذ الزفتاوي"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 205)
        Me.Label2.Text = "النظام المالي لمدرية الزراعة"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(113, 272)
        Me.Label5.Text = "نسخة تجريبية"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(162, 192)
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(113, 137)
        '
        'FirstFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 473)
        Me.MyFormCenterColor = System.Drawing.Color.Gold
        Me.MyFormSurrundColor = System.Drawing.Color.DarkGoldenrod
        Me.Name = "FirstFrm"
        Me.prograamName = "النظام المالي لمدرية الزراعة"
        Me.Text = "مديرية الزراعة"
        Me.Version = "نسخة تجريبية"
        Me.WellcomStart = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
