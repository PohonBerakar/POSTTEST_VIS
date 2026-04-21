Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvubah.DataSource = DataModule.getchara()
    End Sub

    Private Sub dgvubah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvubah.CellClick
        If e.RowIndex >= 0 Then
            txtkode.Text = dgvubah.Rows(e.RowIndex).Cells("kodekarakter").Value.ToString()
            txtnama.Text = dgvubah.Rows(e.RowIndex).Cells("nama").Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text.Trim()
        If keyword = "" Then
            dgvubah.DataSource = DataModule.getchara()
        Else
            dgvubah.DataSource = DataModule.search(keyword)
        End If
    End Sub

    Private Sub btnHapuskan_Click(sender As Object, e As EventArgs) Handles btnHapuskan.Click
        Dim hapus As DialogResult
        hapus = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hapus = DialogResult.Yes Then
            DataModule.hapuschar(txtkode.Text)
            MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvubah.DataSource = DataModule.getchara()
            txtkode.Clear()
            txtnama.Clear()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtkode.Clear()
        txtnama.Clear()
        txtCari.Clear()
        dgvubah.DataSource = DataModule.getchara()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Batalkan tindakan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class