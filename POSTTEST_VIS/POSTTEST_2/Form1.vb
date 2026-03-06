Public Class Form1
	Private Sub tampil()
		DataBuku.Rows.Clear()
		For i As Integer = 0 To Jumlah - 1
			DataBuku.Rows.Add(Buku(i, 0), Buku(i, 1))
		Next
	End Sub

	Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
		If JudulTambah.Text = "" Or GenreTambah.Text = "" Then
			MessageBox.Show("Judul atau Genre tidak boleh kosong")
			Return
		End If
		TambahBuku(JudulTambah.Text, GenreTambah.Text)
		tampil()
		JudulTambah.Text = ""
		GenreTambah.Text = ""
	End Sub

	Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
		If JudulHapus.Text = "" Then
			MessageBox.Show("Masukkan judul yang ingin dihapus !!!")
			Return
		End If
		HapusBuku(JudulHapus.Text)
		tampil()
		JudulHapus.Text = ""
	End Sub
End Class
