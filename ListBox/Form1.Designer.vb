<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstGender = New System.Windows.Forms.ListBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnGender = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstGender
        '
        Me.lstGender.FormattingEnabled = True
        Me.lstGender.ItemHeight = 20
        Me.lstGender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.lstGender.Location = New System.Drawing.Point(188, 49)
        Me.lstGender.Name = "lstGender"
        Me.lstGender.Size = New System.Drawing.Size(120, 84)
        Me.lstGender.TabIndex = 0
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(59, 73)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 26)
        Me.txtGender.TabIndex = 1
        Me.txtGender.Text = "Gender"
        '
        'btnGender
        '
        Me.btnGender.Location = New System.Drawing.Point(160, 217)
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(75, 23)
        Me.btnGender.TabIndex = 2
        Me.btnGender.Text = "You Gender"
        Me.btnGender.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lstGender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGender As Windows.Forms.ListBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnGender As Button
End Class
