<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.bt_admin_login = New System.Windows.Forms.Button()
        Me.bt_staff_login = New System.Windows.Forms.Button()
        Me.bt_student_login = New System.Windows.Forms.Button()
        Me.bt_exit = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_admin_login
        '
        Me.bt_admin_login.Location = New System.Drawing.Point(455, 234)
        Me.bt_admin_login.Name = "bt_admin_login"
        Me.bt_admin_login.Size = New System.Drawing.Size(80, 23)
        Me.bt_admin_login.TabIndex = 0
        Me.bt_admin_login.Text = "Admin"
        Me.bt_admin_login.UseVisualStyleBackColor = True
        '
        'bt_staff_login
        '
        Me.bt_staff_login.Location = New System.Drawing.Point(455, 263)
        Me.bt_staff_login.Name = "bt_staff_login"
        Me.bt_staff_login.Size = New System.Drawing.Size(80, 23)
        Me.bt_staff_login.TabIndex = 1
        Me.bt_staff_login.Text = "Staff"
        Me.bt_staff_login.UseVisualStyleBackColor = True
        '
        'bt_student_login
        '
        Me.bt_student_login.Location = New System.Drawing.Point(455, 292)
        Me.bt_student_login.Name = "bt_student_login"
        Me.bt_student_login.Size = New System.Drawing.Size(80, 23)
        Me.bt_student_login.TabIndex = 2
        Me.bt_student_login.Text = "Student"
        Me.bt_student_login.UseVisualStyleBackColor = True
        '
        'bt_exit
        '
        Me.bt_exit.Location = New System.Drawing.Point(455, 374)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(80, 23)
        Me.bt_exit.TabIndex = 3
        Me.bt_exit.Text = "Exit"
        Me.bt_exit.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(25, 384)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(51, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About Us"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SRS University"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources.University_of_Otago
        Me.ClientSize = New System.Drawing.Size(594, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.bt_student_login)
        Me.Controls.Add(Me.bt_staff_login)
        Me.Controls.Add(Me.bt_admin_login)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University Examination System And Grading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_admin_login As System.Windows.Forms.Button
    Friend WithEvents bt_staff_login As System.Windows.Forms.Button
    Friend WithEvents bt_student_login As System.Windows.Forms.Button
    Friend WithEvents bt_exit As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
