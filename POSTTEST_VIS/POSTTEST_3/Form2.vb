Imports System.Reflection.Metadata

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = Module1.Nama
        Label2.Text = Module1.Umur
        Label3.Text = Module1.Hobi
        Label4.Text = Module1.JK
        Label5.Text = Module1.Alamat
        Label6.Text = Module1.Hp
        Label7.Text = Module1.Tanggal
        PictureBox1.Image = Image.FromFile(Module1.Gambar)
    End Sub

End Class