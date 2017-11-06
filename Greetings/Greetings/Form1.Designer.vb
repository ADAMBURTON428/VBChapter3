<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greeting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnShowGreeting = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Name"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(85, 80)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(110, 20)
        Me.txtUserName.TabIndex = 1
        '
        'lblGreeting
        '
        Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreeting.Location = New System.Drawing.Point(59, 133)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(173, 23)
        Me.lblGreeting.TabIndex = 2
        '
        'btnShowGreeting
        '
        Me.btnShowGreeting.Location = New System.Drawing.Point(59, 178)
        Me.btnShowGreeting.Name = "btnShowGreeting"
        Me.btnShowGreeting.Size = New System.Drawing.Size(75, 36)
        Me.btnShowGreeting.TabIndex = 3
        Me.btnShowGreeting.Text = "Show Greeting"
        Me.btnShowGreeting.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Greeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowGreeting)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Greeting"
        Me.Text = "Greetings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents btnShowGreeting As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
