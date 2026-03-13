Imports System.IO

Public Class Form1
    Dim ghobi() As CheckBox
    Dim gjk() As RadioButton

	Private Function cekdata() As Boolean
		ghobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12}
		gjk = {RadioButton1, RadioButton2}
		If Not ValidasiTextBox(TextBox1, "Nama tidak boleh kosong") Then Return False
		If Not ValidasiTextBox(TextBox2, "Umur tidak boleh kosong") Then Return False
		If Not ValidasiTextBox(TextBox3, "No HP tidak boleh kosong") Then Return False
		If Not ValidasiTextBox(TextBox4, "Almaat tidak boleh kosong") Then Return False
		If Not ValidasiRadioButton(gjk, "Jenis Kelamin belum dipilih") Then Return False
		If Not ValidasiCheckBox(ghobi, "Pilih Hobi") Then Return False
		If Not ValidasiPictureBox(PictureBox1, "Pilih Gambar dahulu") Then Return False
		Return True
	End Function

	Private Sub Tb1_keyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
		Module1.huruf(sender, e)
	End Sub
	Private Sub Tb2_keyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
		Module1.angka(sender, e)
	End Sub
	Private Sub Tb3_keyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
		Module1.angka(sender, e)
	End Sub

	Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles cetak.Click
		If cekdata() Then
			ghobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12}
			gjk = {RadioButton1, RadioButton2}
			Dim Hobi_Selected As String = GetSelectedCheckBox(ghobi)
			Dim jk_Selected As String = GetSelectedRadioButton(gjk)
			Module1.Nama = TextBox1.Text
			Module1.Umur = TextBox2.Text
			Module1.Hp = TextBox3.Text
			Module1.Alamat = TextBox4.Text
			Module1.Hobi = Hobi_Selected
			Module1.JK = jk_Selected
			Module1.Tanggal = DateTimePicker1.Value.ToShortDateString()
			Form2.Show()
		End If
	End Sub

	Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles pgambar.Click
		If ValidasiTextBox(TextBox1, "Nama Tidak Boleh Kosong") Then
			Dim NamaFile As String = TextBox1.Text.Trim()
			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
			openFileDialog.Title = "Pilih Gambar"
			If openFileDialog.ShowDialog() = DialogResult.OK Then
				Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
				Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
				Dim destinationPath As String = Path.Combine(folderPath, fileName)
				If Not Directory.Exists(folderPath) Then
					Directory.CreateDirectory(folderPath)
				End If
				File.Copy(openFileDialog.FileName, destinationPath, True)
				Module1.Gambar = destinationPath
				PictureBox1.Image = Image.FromFile(destinationPath)
				MessageBox.Show("Gambar berhasil dimuat", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		End If
	End Sub

End Class
