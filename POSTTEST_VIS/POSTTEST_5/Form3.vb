Public Class Form3

    Private Sub tampilData()
        dgvubah.DataSource = DataModule.getchara()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtJenis As DataTable = DataModule.getatribut()
        cbatribut.DataSource = dtJenis
        cbatribut.DisplayMember = "atribut"
        cbatribut.ValueMember = "kodeatribut"
        tampilData()
    End Sub

    Private Sub kosongkan()
        txtkode.Clear()
        txtnama.Clear()
        cbatribut.SelectedIndex = -1
        txtatk.Clear()
        txtdef.Clear()
        txthp.Clear()
        txtpasif.Clear()
        txtskill1.Clear()
        txtskill2.Clear()
        txtulti.Clear()
    End Sub

    Private Sub dgvubah_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvubah.CellClick
        If e.RowIndex >= 0 Then
            txtkode.Text = dgvubah.Rows(e.RowIndex).Cells("kodekarakter").Value.ToString()
            txtnama.Text = dgvubah.Rows(e.RowIndex).Cells("nama").Value.ToString()
            cbatribut.Text = dgvubah.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtatk.Text = dgvubah.Rows(e.RowIndex).Cells("atk").Value.ToString()
            txtdef.Text = dgvubah.Rows(e.RowIndex).Cells("def").Value.ToString()
            txthp.Text = dgvubah.Rows(e.RowIndex).Cells("hp").Value.ToString()
            txtpasif.Text = dgvubah.Rows(e.RowIndex).Cells("pasif").Value.ToString()
            txtskill1.Text = dgvubah.Rows(e.RowIndex).Cells("skill1").Value.ToString()
            txtskill2.Text = dgvubah.Rows(e.RowIndex).Cells("skill2").Value.ToString()
            txtulti.Text = dgvubah.Rows(e.RowIndex).Cells("ultimate").Value.ToString()
        End If
    End Sub


    Private Sub txtatk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtatk.KeyPress
        ValidationModule.HanyaAngka(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtdef.Focus()
        End If
    End Sub

    Private Sub txtdef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdef.KeyPress
        ValidationModule.HanyaAngka(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtdef.Focus()
        End If
    End Sub

    Private Sub txthp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthp.KeyPress
        ValidationModule.HanyaAngka(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtdef.Focus()
        End If
    End Sub



    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Batalkan tindakan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Dim reset As DialogResult
        reset = MessageBox.Show("Reset ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reset = DialogResult.Yes Then
            kosongkan()
            tampilData()
        End If
    End Sub

    Private Sub btnubahkan_Click(sender As Object, e As EventArgs) Handles btnubahkan.Click
        ErrorProvider1.Clear()
		If Not ValidationModule.ValidasiDataKarakter(ErrorProvider1, txtkode, cbatribut, txtnama, txtatk, txtdef, txthp, txtpasif, txtskill1, txtskill2, txtulti) Then
			MessageBox.Show("Periksa kembali data yang Anda masukkan!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		Dim kode As String = txtkode.Text.Trim()
        Dim nama As String = txtnama.Text.Trim()
        Dim atribut As String = cbatribut.SelectedValue.ToString()
        Dim atk As String = txtatk.Text.Trim()
        Dim def As String = txtdef.Text.Trim()
        Dim hp As String = txthp.Text.Trim()
        Dim pasif As String = txtpasif.Text.Trim()
        Dim skill1 As String = txtskill1.Text.Trim()
        Dim skill2 As String = txtskill2.Text.Trim()
        Dim ulti As String = txtulti.Text.Trim()

        If DataModule.ubahchar(kode, atribut, nama, atk, def, hp, pasif, skill1, skill2, ulti) Then
            MessageBox.Show("Data karakter berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilData()
        Else
            MessageBox.Show("Gagal mengubah data karakter. Pastikan kode karakter benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim masuk As DialogResult
        masuk = MessageBox.Show("Tambahkan Atribut Baru?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If masuk = DialogResult.Yes Then
            Formatribut.Show()
        End If
    End Sub

    Private Sub txtKodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkode.KeyPress
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = DataModule.getcharByKode(txtkode.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtnama.Text = dt.Rows(0)("nama").ToString()
                cbatribut.Text = dt.Rows(0)("atribut").ToString()
                txtatk.Text = dt.Rows(0)("atk").ToString()
                txtdef.Text = dt.Rows(0)("def").ToString()
                txthp.Text = dt.Rows(0)("hp").ToString()
                txtpasif.Text = dt.Rows(0)("pasif").ToString()
                txtskill1.Text = dt.Rows(0)("skill1").ToString()
                txtskill2.Text = dt.Rows(0)("skill2").ToString()
                txtulti.Text = dt.Rows(0)("ultimate").ToString()
            Else
                txtnama.Clear()
                cbatribut.SelectedIndex = -1
                txtatk.Clear()
                txtdef.Clear()
                txthp.Clear()
                txtpasif.Clear()
                txtskill1.Clear()
                txtskill2.Clear()
                txtulti.Clear()
            End If

            cbatribut.Focus()
        End If
    End Sub
End Class