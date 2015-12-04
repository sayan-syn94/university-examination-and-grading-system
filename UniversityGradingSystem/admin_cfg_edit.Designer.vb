<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_cfg_edit
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
        Me.cbx_m = New System.Windows.Forms.CheckBox()
        Me.cbx_me = New System.Windows.Forms.CheckBox()
        Me.cbx_hu = New System.Windows.Forms.CheckBox()
        Me.cbx_es = New System.Windows.Forms.CheckBox()
        Me.cbx_cs = New System.Windows.Forms.CheckBox()
        Me.cbx_gen_res = New System.Windows.Forms.CheckBox()
        Me.bt_sv = New System.Windows.Forms.Button()
        Me.bt_bck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbx_m
        '
        Me.cbx_m.AutoSize = True
        Me.cbx_m.Location = New System.Drawing.Point(24, 32)
        Me.cbx_m.Name = "cbx_m"
        Me.cbx_m.Size = New System.Drawing.Size(86, 17)
        Me.cbx_m.TabIndex = 1
        Me.cbx_m.Text = "Mathematics"
        Me.cbx_m.UseVisualStyleBackColor = True
        '
        'cbx_me
        '
        Me.cbx_me.AutoSize = True
        Me.cbx_me.Location = New System.Drawing.Point(183, 32)
        Me.cbx_me.Name = "cbx_me"
        Me.cbx_me.Size = New System.Drawing.Size(78, 17)
        Me.cbx_me.TabIndex = 2
        Me.cbx_me.Text = "Mechanics"
        Me.cbx_me.UseVisualStyleBackColor = True
        '
        'cbx_hu
        '
        Me.cbx_hu.AutoSize = True
        Me.cbx_hu.Location = New System.Drawing.Point(24, 66)
        Me.cbx_hu.Name = "cbx_hu"
        Me.cbx_hu.Size = New System.Drawing.Size(60, 17)
        Me.cbx_hu.TabIndex = 3
        Me.cbx_hu.Text = "English"
        Me.cbx_hu.UseVisualStyleBackColor = True
        '
        'cbx_es
        '
        Me.cbx_es.AutoSize = True
        Me.cbx_es.Location = New System.Drawing.Point(183, 66)
        Me.cbx_es.Name = "cbx_es"
        Me.cbx_es.Size = New System.Drawing.Size(78, 17)
        Me.cbx_es.TabIndex = 4
        Me.cbx_es.Text = "Electronics"
        Me.cbx_es.UseVisualStyleBackColor = True
        '
        'cbx_cs
        '
        Me.cbx_cs.AutoSize = True
        Me.cbx_cs.Location = New System.Drawing.Point(87, 100)
        Me.cbx_cs.Name = "cbx_cs"
        Me.cbx_cs.Size = New System.Drawing.Size(113, 17)
        Me.cbx_cs.TabIndex = 5
        Me.cbx_cs.Text = "Computer Science"
        Me.cbx_cs.UseVisualStyleBackColor = True
        '
        'cbx_gen_res
        '
        Me.cbx_gen_res.AutoSize = True
        Me.cbx_gen_res.Location = New System.Drawing.Point(87, 137)
        Me.cbx_gen_res.Name = "cbx_gen_res"
        Me.cbx_gen_res.Size = New System.Drawing.Size(103, 17)
        Me.cbx_gen_res.TabIndex = 6
        Me.cbx_gen_res.Text = "Generate Result"
        Me.cbx_gen_res.UseVisualStyleBackColor = True
        '
        'bt_sv
        '
        Me.bt_sv.Location = New System.Drawing.Point(24, 185)
        Me.bt_sv.Name = "bt_sv"
        Me.bt_sv.Size = New System.Drawing.Size(75, 23)
        Me.bt_sv.TabIndex = 7
        Me.bt_sv.Text = "Save"
        Me.bt_sv.UseVisualStyleBackColor = True
        '
        'bt_bck
        '
        Me.bt_bck.Location = New System.Drawing.Point(183, 185)
        Me.bt_bck.Name = "bt_bck"
        Me.bt_bck.Size = New System.Drawing.Size(75, 23)
        Me.bt_bck.TabIndex = 8
        Me.bt_bck.Text = "Back"
        Me.bt_bck.UseVisualStyleBackColor = True
        '
        'admin_cfg_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.Controls.Add(Me.bt_bck)
        Me.Controls.Add(Me.bt_sv)
        Me.Controls.Add(Me.cbx_gen_res)
        Me.Controls.Add(Me.cbx_cs)
        Me.Controls.Add(Me.cbx_es)
        Me.Controls.Add(Me.cbx_hu)
        Me.Controls.Add(Me.cbx_me)
        Me.Controls.Add(Me.cbx_m)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_cfg_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Configuration File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_m As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_me As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_hu As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_es As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_cs As System.Windows.Forms.CheckBox
    Friend WithEvents cbx_gen_res As System.Windows.Forms.CheckBox
    Friend WithEvents bt_sv As System.Windows.Forms.Button
    Friend WithEvents bt_bck As System.Windows.Forms.Button
End Class
