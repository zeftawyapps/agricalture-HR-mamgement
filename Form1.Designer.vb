<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDesingne
    Inherits ZeftawyTools.myformDesign

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
        Me.TitelBar.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.massegBoxFormat.SuspendLayout()
        Me.MsgTilteBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitelBar
        '
        Me.TitelBar.Size = New System.Drawing.Size(680, 37)
        '
        'Logo
        '
        Me.Logo.Location = New System.Drawing.Point(648, 3)
        '
        'massegBoxFormat
        '
        Me.massegBoxFormat.Location = New System.Drawing.Point(73, 137)
        '
        'MsgText
        '
        Me.MsgText.ForeColor = System.Drawing.Color.DarkRed
        '
        'msgTitl
        '
        Me.msgTitl.Size = New System.Drawing.Size(59, 19)
        Me.msgTitl.Text = "الزراعة"
        '
        'Titel
        '
        Me.Titel.Location = New System.Drawing.Point(593, 7)
        Me.Titel.Size = New System.Drawing.Size(57, 24)
        Me.Titel.Text = "الاحكام"
        '
        'Labelbox
        '
        Me.Labelbox.Location = New System.Drawing.Point(703, 103)
        '
        'T_button
        '
        Me.T_button.buttonclick_center_color = System.Drawing.Color.DarkGreen
        Me.T_button.buttonclick_surrounding_color = System.Drawing.Color.Lime
        Me.T_button.Location = New System.Drawing.Point(329, 172)
        Me.T_button.meloodcenter_color = System.Drawing.Color.LimeGreen
        Me.T_button.meloodserruonding_color = System.Drawing.Color.DarkGreen
        Me.T_button.mousemove_center_color = System.Drawing.Color.GreenYellow
        Me.T_button.mousrmove_surronding_color = System.Drawing.Color.ForestGreen
        Me.T_button.Size = New System.Drawing.Size(152, 46)
        Me.ToolTip1.SetToolTip(Me.T_button, "fdsgdfgdfg")
        '
        'MinBtn
        '
        Me.MinBtn.buttonclick_center_color = System.Drawing.Color.Maroon
        Me.MinBtn.buttonclick_surrounding_color = System.Drawing.Color.LightCoral
        Me.MinBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinBtn.meloodcenter_color = System.Drawing.Color.OrangeRed
        Me.MinBtn.meloodserruonding_color = System.Drawing.Color.DarkRed
        Me.MinBtn.mousemove_center_color = System.Drawing.Color.LightCoral
        Me.MinBtn.mousrmove_surronding_color = System.Drawing.Color.DarkRed
        '
        'CloosBtn
        '
        Me.CloosBtn.buttonclick_center_color = System.Drawing.Color.Maroon
        Me.CloosBtn.buttonclick_surrounding_color = System.Drawing.Color.LightCoral
        Me.CloosBtn.meloodcenter_color = System.Drawing.Color.OrangeRed
        Me.CloosBtn.meloodserruonding_color = System.Drawing.Color.DarkRed
        Me.CloosBtn.mousemove_center_color = System.Drawing.Color.LightCoral
        Me.CloosBtn.mousrmove_surronding_color = System.Drawing.Color.DarkRed
        '
        'T_textbox
        '
        Me.T_textbox.enter_color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.T_textbox.ForeColor = System.Drawing.Color.DarkGreen
        Me.T_textbox.read_only_color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'FormDesingne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 304)
        Me.MyFormCenterColor = System.Drawing.Color.Lime
        Me.MyFormSurrundColor = System.Drawing.Color.ForestGreen
        Me.Name = "FormDesingne"
        Me.Opacity = 1
        Me.Text = "الاحكام"
        Me.TiteText = "الاحكام"
        Me.TitelBar.ResumeLayout(False)
        Me.TitelBar.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.massegBoxFormat.ResumeLayout(False)
        Me.massegBoxFormat.PerformLayout()
        Me.MsgTilteBar.ResumeLayout(False)
        Me.MsgTilteBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
