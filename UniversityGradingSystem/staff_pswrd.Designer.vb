<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_pswrd
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
        Me.bt_sv = New System.Windows.Forms.Button()
        Me.bt_bck = New System.Windows.Forms.Button()
        Me.tb_entrpswrd = New System.Windows.Forms.TextBox()
        Me.tb_retrpswrd = New System.Windows.Forms.TextBox()
        Me.bt_rst = New System.Windows.Forms.Button()
        Me.tb_stf_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Renter Password"
        '
        'bt_sv
        '
        Me.bt_sv.Location = New System.Drawing.Point(22, 122)
        Me.bt_sv.Name = "bt_sv"
        Me.bt_sv.Size = New System.Drawing.Size(75, 23)
        Me.bt_sv.TabIndex = 3
        Me.bt_sv.Text = "Save"
        Me.bt_sv.UseVisualStyleBackColor = True
        '
        'bt_bck
        '
        Me.bt_bck.Location = New System.Drawing.Point(194, 122)
        Me.bt_bck.Name = "bt_bck"
        Me.bt_bck.Size = New System.Drawing.Size(75, 23)
        Me.bt_bck.TabIndex = 4
        Me.bt_bck.Text = "Back"
        Me.bt_bck.UseVisualStyleBackColor = True
        '
        'tb_entrpswrd
        '
        Me.tb_entrpswrd.Location = New System.Drawing.Point(117, 49)
        Me.tb_entrpswrd.Name = "tb_entrpswrd"
        Me.tb_entrpswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_entrpswrd.Size = New System.Drawing.Size(147, 20)
        Me.tb_entrpswrd.TabIndex = 5
        '
        'tb_retrpswrd
        '
        Me.tb_retrpswrd.Location = New System.Drawing.Point(117, 81)
        Me.tb_retrpswrd.Name = "tb_retrpswrd"
        Me.tb_retrpswrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_retrpswrd.Size = New System.Drawing.Size(147, 20)
        Me.tb_retrpswrd.TabIndex = 6
        '
        'bt_rst
        '
        Me.bt_rst.Location = New System.Drawing.Point(113, 122)
        Me.bt_rst.Name = "bt_rst"
        Me.bt_rst.Size = New System.Drawing.Size(75, 23)
        Me.bt_rst.TabIndex = 7
        Me.bt_rst.Text = "Reset"
        Me.bt_rst.UseVisualStyleBackColor = True
        '
        'tb_stf_id
        '
        Me.tb_stf_id.Enabled = False
        Me.tb_stf_id.Location = New System.Drawing.Point(117, 17)
        Me.tb_stf_id.Name = "tb_stf_id"
        Me.tb_stf_id.Size = New System.Drawing.Size(147, 20)
        Me.tb_stf_id.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Staff ID"
        '
        'staff_pswrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 161)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_stf_id)
        Me.Controls.Add(Me.bt_rst)
        Me.Controls.Add(Me.tb_retrpswrd)
        Me.Controls.Add(Me.tb_entrpswrd)
        Me.Controls.Add(Me.bt_bck)
        Me.Controls.Add(Me.bt_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "staff_pswrd"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Staff Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_sv As System.Windows.Forms.Button
    Friend WithEvents bt_bck As System.Windows.Forms.Button
    Friend WithEvents tb_entrpswrd As System.Windows.Forms.TextBox
    Friend WithEvents tb_retrpswrd As System.Windows.Forms.TextBox
    Friend WithEvents bt_rst As System.Windows.Forms.Button
    Friend WithEvents tb_stf_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
