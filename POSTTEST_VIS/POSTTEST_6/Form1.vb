Public Class Form1
#Region "Fungsi"
    Public Sub TampilData()
        dgvChar.DataSource = DataModule.getchara()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TampilData()
	End Sub
#End Region


#Region "Search"
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text.Trim()
        If keyword = "" Then
            TampilData()
        Else
            dgvChar.DataSource = DataModule.search(keyword)
        End If
    End Sub
#End Region

#Region "BUTTON"
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Form2.Show()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Form3.Show()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Form4.Show()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim keluar As DialogResult
        keluar = MessageBox.Show("Apakah Anda Yakin Ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
#End Region
End Class