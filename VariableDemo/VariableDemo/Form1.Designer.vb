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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShowName = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your first name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your last name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "This is your full name"
        '
        'btnShowName
        '
        Me.btnShowName.Location = New System.Drawing.Point(12, 185)
        Me.btnShowName.Name = "btnShowName"
        Me.btnShowName.Size = New System.Drawing.Size(75, 23)
        Me.btnShowName.TabIndex = 3
        Me.btnShowName.Text = "Show Name"
        Me.btnShowName.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 185)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblFullName
        '
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Location = New System.Drawing.Point(137, 117)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(135, 19)
        Me.lblFullName.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(137, 33)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(115, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(137, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(115, 20)
        Me.txtLastName.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnShowName As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
