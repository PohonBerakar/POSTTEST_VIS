Module Module1
	Public Buku(100, 1) As String
	Public Jumlah As Integer

	Function bukuAda(ByVal judul As String) As Boolean
		Dim i As Integer
		For i = 0 To Jumlah - 1
			If Buku(i, 0) = judul Then
				Return True
			End If
		Next
		Return False

	End Function
	Public Sub TambahBuku(ByVal judultambah As String, ByVal genretambah As String)
		If bukuAda(judultambah) Then
			MessageBox.Show("Buku sudah ada")
		Else
			If Jumlah >= 100 Then
				MessageBox.Show("Kapasitas buku penuh !!!")
			Else
				Buku(Jumlah, 0) = judultambah
				Buku(Jumlah, 1) = genretambah
				Jumlah = Jumlah + 1
				MessageBox.Show("Buku ditambahkan")
			End If

		End If
	End Sub

	Public Sub HapusBuku(ByVal judulhapus As String)
		Dim i As Integer
		Dim ada As Boolean = False
		For i = 0 To Jumlah - 1
			If Buku(i, 0) = judulhapus Then
				ada = True
			End If
		Next
		If ada Then
			Dim j As Integer
			For j = 0 To Jumlah - 1
				If Buku(j, 0) = judulhapus Then
					Buku(j, 0) = ""
					Buku(j, 1) = ""
				End If
			Next
			MessageBox.Show("Buku dihapus")
			Jumlah = Jumlah - 1
		Else
			MessageBox.Show("Buku tidak ada")
		End If
	End Sub
End Module