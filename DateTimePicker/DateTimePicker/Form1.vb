Public Class frm_dateTimePicker

    Private Sub rb_long_CheckedChanged(sender As Object, e As EventArgs) Handles rb_long.CheckedChanged
        If rb_long.Checked Then dtp_tanggal.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub rb_short_CheckedChanged(sender As Object, e As EventArgs) Handles rb_short.CheckedChanged
        If rb_short.Checked Then dtp_tanggal.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub rb_time_CheckedChanged(sender As Object, e As EventArgs) Handles rb_time.CheckedChanged
        If rb_time.Checked Then dtp_tanggal.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub rd_ddMMyyyy_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ddMMyyyy.CheckedChanged
        If rd_ddMMyyyy.Checked Then
            dtp_tanggal.Format = DateTimePickerFormat.Custom
            dtp_tanggal.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub rb_ddMMMMyyyy_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ddMMMMyyyy.CheckedChanged
        If rb_ddMMMMyyyy.Checked Then
            dtp_tanggal.Format = DateTimePickerFormat.Custom
            dtp_tanggal.CustomFormat = "dd MM yyyy"
        End If
    End Sub

    Private Sub rb_complete_CheckedChanged(sender As Object, e As EventArgs) Handles rb_complete.CheckedChanged
        If rb_complete.Checked Then
            dtp_tanggal.Format = DateTimePickerFormat.Custom
            dtp_tanggal.CustomFormat = "'H'ari dddd, dd MM yyyy - Pukul hh:mm:ss"
        End If
    End Sub
End Class
