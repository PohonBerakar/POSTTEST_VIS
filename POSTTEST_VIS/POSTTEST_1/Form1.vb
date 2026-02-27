Public Class Form1
    Dim total As Double
    Dim semester As Integer
    Dim input_ips As Double
    Dim hasil_ipk As Double


    Private Sub tambahah_Click(sender As Object, e As EventArgs) Handles tambahah.Click
        If Double.TryParse(ips.Text, input_ips) Then
            If input_ips <= 0 Or input_ips > 4 Then
                MessageBox.Show("Masukkan ip yang benar lah bang !")
            Else
                total = total + input_ips
                semester = semester + 1
                hasil_ipk = total / semester
                ipk.Text = hasil_ipk
                ips.Text = ""
                If hasil_ipk < 2 Then
                    hasil.Text = "Belajar lagi lah bang"
                ElseIf hasil_ipk >= 2 And hasil_ipk <= 2.75 Then
                    hasil.Text = "IP segini mau jadi wapres kah bang?"
                ElseIf hasil_ipk > 2.75 And hasil_ipk <= 3 Then
                    hasil.Text = "Oke lah"
                Else
                    hasil.Text = "IP-mu lebih dari 3 bang, udah bisa Jadi Kariawan"
                End If
				If semester > 14 Then
                    MessageBox.Show("Udah semester 14 jir, Do Aja Banh")
                End If
            End If
        Else MessageBox.Show("Masukkan INput yang betul lah bang !!!")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ips_TextChanged(sender As Object, e As EventArgs) Handles ips.TextChanged

    End Sub

    Private Sub ipk_TextChanged(sender As Object, e As EventArgs) Handles ipk.TextChanged

    End Sub

    Private Sub reste_Click(sender As Object, e As EventArgs) Handles reste.Click
        total = 0
        semester = 0
        input_ips = 0
        hasil_ipk = 0
        ips.Text = ""
        ipk.Text = ""
        hasil.Text = ""
    End Sub

    Private Sub hasil_Click(sender As Object, e As EventArgs) Handles hasil.Click

    End Sub
End Class
