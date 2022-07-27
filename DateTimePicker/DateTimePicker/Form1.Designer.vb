<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dateTimePicker
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
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_long = New System.Windows.Forms.RadioButton()
        Me.rb_short = New System.Windows.Forms.RadioButton()
        Me.rb_time = New System.Windows.Forms.RadioButton()
        Me.rd_ddMMyyyy = New System.Windows.Forms.RadioButton()
        Me.rb_ddMMMMyyyy = New System.Windows.Forms.RadioButton()
        Me.rb_complete = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Location = New System.Drawing.Point(12, 12)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(290, 20)
        Me.dtp_tanggal.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_complete)
        Me.GroupBox1.Controls.Add(Me.rb_ddMMMMyyyy)
        Me.GroupBox1.Controls.Add(Me.rd_ddMMyyyy)
        Me.GroupBox1.Controls.Add(Me.rb_time)
        Me.GroupBox1.Controls.Add(Me.rb_short)
        Me.GroupBox1.Controls.Add(Me.rb_long)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Format yang diinginkan"
        '
        'rb_long
        '
        Me.rb_long.AutoSize = True
        Me.rb_long.Checked = True
        Me.rb_long.Location = New System.Drawing.Point(6, 31)
        Me.rb_long.Name = "rb_long"
        Me.rb_long.Size = New System.Drawing.Size(49, 17)
        Me.rb_long.TabIndex = 0
        Me.rb_long.TabStop = True
        Me.rb_long.Text = "Long"
        Me.rb_long.UseVisualStyleBackColor = True
        '
        'rb_short
        '
        Me.rb_short.AutoSize = True
        Me.rb_short.Location = New System.Drawing.Point(6, 54)
        Me.rb_short.Name = "rb_short"
        Me.rb_short.Size = New System.Drawing.Size(50, 17)
        Me.rb_short.TabIndex = 1
        Me.rb_short.TabStop = True
        Me.rb_short.Text = "Short"
        Me.rb_short.UseVisualStyleBackColor = True
        '
        'rb_time
        '
        Me.rb_time.AutoSize = True
        Me.rb_time.Location = New System.Drawing.Point(6, 77)
        Me.rb_time.Name = "rb_time"
        Me.rb_time.Size = New System.Drawing.Size(48, 17)
        Me.rb_time.TabIndex = 2
        Me.rb_time.TabStop = True
        Me.rb_time.Text = "Time"
        Me.rb_time.UseVisualStyleBackColor = True
        '
        'rd_ddMMyyyy
        '
        Me.rd_ddMMyyyy.AutoSize = True
        Me.rd_ddMMyyyy.Location = New System.Drawing.Point(7, 101)
        Me.rd_ddMMyyyy.Name = "rd_ddMMyyyy"
        Me.rd_ddMMyyyy.Size = New System.Drawing.Size(127, 17)
        Me.rd_ddMMyyyy.TabIndex = 3
        Me.rd_ddMMyyyy.TabStop = True
        Me.rd_ddMMyyyy.Text = "Custom : dd/mm/yyyy"
        Me.rd_ddMMyyyy.UseVisualStyleBackColor = True
        '
        'rb_ddMMMMyyyy
        '
        Me.rb_ddMMMMyyyy.AutoSize = True
        Me.rb_ddMMMMyyyy.Location = New System.Drawing.Point(7, 125)
        Me.rb_ddMMMMyyyy.Name = "rb_ddMMMMyyyy"
        Me.rb_ddMMMMyyyy.Size = New System.Drawing.Size(143, 17)
        Me.rb_ddMMMMyyyy.TabIndex = 4
        Me.rb_ddMMMMyyyy.TabStop = True
        Me.rb_ddMMMMyyyy.Text = "Custom : dd MMMM yyyy"
        Me.rb_ddMMMMyyyy.UseVisualStyleBackColor = True
        '
        'rb_complete
        '
        Me.rb_complete.AutoSize = True
        Me.rb_complete.Location = New System.Drawing.Point(7, 149)
        Me.rb_complete.Name = "rb_complete"
        Me.rb_complete.Size = New System.Drawing.Size(280, 17)
        Me.rb_complete.TabIndex = 5
        Me.rb_complete.TabStop = True
        Me.rb_complete.Text = "Custom : Hari dddd, dd MMMM yyyy – Pukul hh:mm:ss"
        Me.rb_complete.UseVisualStyleBackColor = True
        '
        'frm_dateTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_dateTimePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DateTimePicker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtp_tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_long As System.Windows.Forms.RadioButton
    Friend WithEvents rb_short As System.Windows.Forms.RadioButton
    Friend WithEvents rb_time As System.Windows.Forms.RadioButton
    Friend WithEvents rd_ddMMyyyy As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ddMMMMyyyy As System.Windows.Forms.RadioButton
    Friend WithEvents rb_complete As System.Windows.Forms.RadioButton

End Class
