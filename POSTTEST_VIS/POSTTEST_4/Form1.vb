Imports System.IO
Public Class Form1

    Dim gambar As String
    Dim peran() As RadioButton
    Dim jk() As RadioButton
    Dim hobi() As CheckBox

    Dim nama, id, lahir, jenis, divisi, nomor, email, alamat, peranp, hobip As String

    Private Function cekdata() As Boolean
        peran = {RadioButton3, RadioButton4, RadioButton5}
        jk = {RadioButton1, RadioButton2}
        hobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9}
        If Not ValidasiTextBox(TextBox1, "Nama tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(TextBox2, "ID tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(TextBox3, "Email tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(TextBox4, "Alamat tidak boleh kosong") Then Return False
        If Not ValidasiPictureBox(PictureBox1, "Gambar harus dipilih") Then Return False
        If Not ValidasiRadioButton(jk, "Jenis Kelamin harus dipilih") Then Return False
        If Not ValidasiRadioButton(peran, "Peran harus dipilih") Then Return False
        If Not ValidasiCheckBox(hobi, "Hobi harus dipilih") Then Return False
        If MaskedTextBox1.Text = "" Then Return False
        Return True
    End Function
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih File"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            gambar = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = gambar
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        peran = {RadioButton3, RadioButton4, RadioButton5}
        hobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4}
        hobip = GetSelectedCheckBox(hobi)
        peranp = GetSelectedRadioButton(peran)
        MessageBox.Show("Data Berhasil Disimpan")
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim simpan As DialogResult
        simpan = MessageBox.Show("Apakah Anda Yakin Ingin Menyimpan Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If simpan = DialogResult.Yes Then
            If cekdata() Then
                nama = TextBox1.Text
                id = TextBox2.Text
                lahir = DateTimePicker1.Value.ToString("dd/MM/yyyy")
                jenis = GetSelectedRadioButton(jk)
                divisi = ComboBox1.SelectedItem.ToString()
                nomor = MaskedTextBox1.Text
                email = TextBox3.Text
                alamat = TextBox4.Text
                peranp = GetSelectedRadioButton(peran)
                hobip = GetSelectedCheckBox(hobi)
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Gagal Menyimpan, masih ada data yang kosong, periksa tab lain", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub LiderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiderToolStripMenuItem.Click
        ComboBox1.Text = "Lider"
    End Sub

    Private Sub BabuLevel2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BabuLevel2ToolStripMenuItem.Click
        ComboBox1.Text = "Babu Level 2"
    End Sub

    Private Sub BabuLevel1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BabuLevel1ToolStripMenuItem.Click
        ComboBox1.Text = "Babu Level 1"
    End Sub

    Private Sub LakiLakiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        jenis = "Laki-laki"
    End Sub

    Private Sub PerempuanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        jenis = "Perempuan"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cetak As DialogResult
        cetak = MessageBox.Show("Apakah Anda Yakin Ingin Mencetak Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cetak = DialogResult.Yes Then
            If cekdata() Then
                Form2.Label7.Text = nama
                Form2.Label8.Text = id
                Form2.Label9.Text = divisi
                Form2.Label10.Text = nomor
                Form2.Label11.Text = hobip
                Form2.PictureBox4.ImageLocation = gambar
                Form2.Show()
            Else
                MessageBox.Show("Gagal Mencetak, masih ada data yang kosong, periksa tab lain", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim cetak As DialogResult
        cetak = MessageBox.Show("Apakah Anda Yakin Ingin Mencetak Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If cetak = DialogResult.Yes Then
            If cekdata() Then
                Form2.Label7.Text = nama
                Form2.Label8.Text = id
                Form2.Label9.Text = divisi
                Form2.Label10.Text = nomor
                Form2.Label11.Text = hobip
                Form2.PictureBox4.ImageLocation = gambar
                Form2.Show()
            Else
                MessageBox.Show("Gagal Mencetak, masih ada data yang kosong, periksa tab lain", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub nomor_leave(sender As Object, e As EventArgs) Handles MaskedTextBox1.Leave
		If Not MaskedTextBox1.MaskCompleted Then
			ErrorProvider1.SetError(MaskedTextBox1, "Nomor HP harus lengkap, contoh:0812-3456-7890")
		Else
			ErrorProvider1.SetError(MaskedTextBox1, "")
		End If
    End Sub
End Class
