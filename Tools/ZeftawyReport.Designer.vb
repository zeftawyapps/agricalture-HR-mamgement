<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZeftawyReport
    Inherits System.Windows.Forms.Form

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
        Me.ReportDesignControl1 = New Zera3a.ReportDesignControl()
        Me.SuspendLayout()
        '
        'ReportDesignControl1
        '
        Me.ReportDesignControl1.Location = New System.Drawing.Point(36, 12)
        Me.ReportDesignControl1.Name = "ReportDesignControl1"
        Me.ReportDesignControl1.Size = New System.Drawing.Size(770, 447)
        Me.ReportDesignControl1.TabIndex = 0
        '
        'ZeftawyReport
        '
        Me.ClientSize = New System.Drawing.Size(871, 463)
        Me.Controls.Add(Me.ReportDesignControl1)
        Me.Name = "ZeftawyReport"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportDesignControl1 As Zera3a.ReportDesignControl
    'Friend WithEvents ReportDesignControl2 As Zera3a.ReportDesignControl
End Class
