Public Class Formatribut


    Private Sub Kosong()
        txtkodeatribut.Clear()
        txtAtribut.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtkodeatribut.Focus()
    End Sub
    Private Sub tampilkan()
        dgvJenis.DataSource = DataModule.getatribut()
    End Sub

    Private Sub Formatribut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan()
        Kosong()
    End Sub


    Private Sub Btnkembali_Click(sender As Object, e As EventArgs) Handles Btnkembali.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        tampilkan()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiJenisAtribut(ErrorProvider1, txtkodeatribut, txtAtribut) Then Exit Sub

        Dim kode As String = txtkodeatribut.Text.Trim()
        Dim namaJenis As String = txtAtribut.Text.Trim()
        If kodeatributSudahAda(kode) Then
            MessageBox.Show("Kode Jenis sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkodeatribut.Focus()
            Exit Sub
        End If
        If simpanAtribut(kode, namaJenis) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkan()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtkodeatribut.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkodeatribut.Focus()
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If hapusAtribut(txtkodeatribut.Text.Trim()) Then
                MessageBox.Show("Data Atribut berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilkan()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiJenisAtribut(ErrorProvider1, txtkodeatribut, txtAtribut) Then Exit Sub

        Dim kode As String = txtkodeatribut.Text.Trim()
        Dim namaJenis As String = txtAtribut.Text.Trim()
        If ubahAtribut(kode, namaJenis) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkan()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenis.CellClick
        If e.RowIndex >= 0 Then
            txtkodeatribut.Text = dgvJenis.Rows(e.RowIndex).Cells("kodeatribut").Value.ToString()
            txtAtribut.Text = dgvJenis.Rows(e.RowIndex).Cells("atribut").Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()
        If keyword = "" Then
            tampilkan()
        Else
            dgvJenis.DataSource = searchAtribut(keyword)
        End If
    End Sub

    Private Sub txtJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAtribut.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub txtKodeJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodeatribut.KeyPress

        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable =
            getatributByKode(txtkodeatribut.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtkodeatribut.Text = dt.Rows(0)("kodeatribut").ToString()
                txtAtribut.Text = dt.Rows(0)("atribut").ToString()
            Else
                txtAtribut.Clear()
            End If
            txtAtribut.Focus()
        End If
    End Sub
End Class