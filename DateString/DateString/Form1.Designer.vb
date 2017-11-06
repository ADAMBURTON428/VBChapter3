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
        Me.txtDayOfWeek = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDayOfWeek
        '
        Me.txtDayOfWeek.Location = New System.Drawing.Point(143, 35)
        Me.txtDayOfWeek.Name = "txtDayOfWeek"
        Me.txtDayOfWeek.Size = New System.Drawing.Size(115, 20)
        Me.txtDayOfWeek.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(143, 61)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(115, 20)
        Me.txtMonth.TabIndex = 1
        '
        'txtDayOfMonth
        '
        Me.txtDayOfMonth.Location = New System.Drawing.Point(143, 87)
        Me.txtDayOfMonth.Name = "txtDayOfMonth"
        Me.txtDayOfMonth.Size = New System.Drawing.Size(115, 20)
        Me.txtDayOfMonth.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(143, 113)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(115, 20)
        Me.txtYear.TabIndex = 3
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Location = New System.Drawing.Point(12, 159)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(231, 23)
        Me.lblDateString.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the day of the week"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter the day of the month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Enter the year"
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(12, 214)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(75, 23)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(97, 214)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayOfMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayOfWeek)
        Me.Name = "Form1"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDayOfWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtDayOfMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
