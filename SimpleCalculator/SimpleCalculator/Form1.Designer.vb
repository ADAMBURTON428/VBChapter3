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
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnExponant = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(83, 85)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(35, 23)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(124, 85)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(39, 23)
        Me.btnMinus.TabIndex = 1
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(169, 85)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(44, 23)
        Me.btnTimes.TabIndex = 2
        Me.btnTimes.Text = "x"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(83, 114)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(36, 23)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnExponant
        '
        Me.btnExponant.Location = New System.Drawing.Point(124, 114)
        Me.btnExponant.Name = "btnExponant"
        Me.btnExponant.Size = New System.Drawing.Size(39, 23)
        Me.btnExponant.TabIndex = 5
        Me.btnExponant.Text = "^"
        Me.btnExponant.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(169, 114)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(44, 23)
        Me.btnMod.TabIndex = 6
        Me.btnMod.Text = "MOD"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Number 1"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(24, 85)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(53, 13)
        Me.lblOperation.TabIndex = 8
        Me.lblOperation.Text = "Operation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Results"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(98, 232)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(174, 27)
        Me.lblResult.TabIndex = 11
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(53, 291)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Clear"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(250, 290)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(98, 38)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 14
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(98, 188)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Number 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 343)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnExponant)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnExponant As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
