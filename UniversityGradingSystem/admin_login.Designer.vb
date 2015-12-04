<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb_admin_pas = New System.Windows.Forms.MaskedTextBox()
        Me.tb_admin_usr = New System.Windows.Forms.TextBox()
        Me.bt_admin_back = New System.Windows.Forms.Button()
        Me.bt_admin_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources._2
        Me.PictureBox1.Image = Global.UniversityGradingSystem.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 268)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'tb_admin_pas
        '
        Me.tb_admin_pas.Location = New System.Drawing.Point(465, 150)
        Me.tb_admin_pas.Name = "tb_admin_pas"
        Me.tb_admin_pas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_admin_pas.Size = New System.Drawing.Size(131, 20)
        Me.tb_admin_pas.TabIndex = 19
        '
        'tb_admin_usr
        '
        Me.tb_admin_usr.Location = New System.Drawing.Point(465, 117)
        Me.tb_admin_usr.Name = "tb_admin_usr"
        Me.tb_admin_usr.Size = New System.Drawing.Size(131, 20)
        Me.tb_admin_usr.TabIndex = 18
        '
        'bt_admin_back
        '
        Me.bt_admin_back.Location = New System.Drawing.Point(468, 203)
        Me.bt_admin_back.Name = "bt_admin_back"
        Me.bt_admin_back.Size = New System.Drawing.Size(75, 23)
        Me.bt_admin_back.TabIndex = 17
        Me.bt_admin_back.Text = "Back"
        Me.bt_admin_back.UseVisualStyleBackColor = True
        '
        'bt_admin_login
        '
        Me.bt_admin_login.Location = New System.Drawing.Point(367, 203)
        Me.bt_admin_login.Name = "bt_admin_login"
        Me.bt_admin_login.Size = New System.Drawing.Size(75, 23)
        Me.bt_admin_login.TabIndex = 16
        Me.bt_admin_login.Text = "Login"
        Me.bt_admin_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username"
        '
        'admin_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UniversityGradingSystem.My.Resources.Resources._2
        Me.ClientSize = New System.Drawing.Size(629, 304)
        Me.Controls.Add(Me.tb_admin_pas)
        Me.Controls.Add(Me.tb_admin_usr)
        Me.Controls.Add(Me.bt_admin_back)
        Me.Controls.Add(Me.bt_admin_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tb_admin_pas As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tb_admin_usr As System.Windows.Forms.TextBox
    Friend WithEvents bt_admin_back As System.Windows.Forms.Button
    Friend WithEvents bt_admin_login As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
