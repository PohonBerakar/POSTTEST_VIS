Imports MySqlConnector

Module DataModule

#Region "karakter"
#Region "search"
    Public Function search(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tbkarakter.kodekarakter, tbkarakter.nama, tbatribute.atribut AS 'Atribut Karakter', " &
                                  "tbkarakter.atk, tbkarakter.def, tbkarakter.hp, " &
                                  "tbkarakter.pasif, tbkarakter.skill1, tbkarakter.skill2, tbkarakter.ultimate " &
                                  "FROM tbkarakter " &
                                  "INNER JOIN tbatribute ON tbkarakter.kodeatribut = tbatribute.kodeatribut " &
                                  "WHERE tbkarakter.nama LIKE @keyword OR tbkarakter.kodekarakter LIKE @keyword " &
                                  "ORDER BY tbkarakter.kodekarakter ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
#End Region

#Region "getchara"
    Public Function getchara() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tbkarakter.kodekarakter, tbkarakter.nama, tbatribute.atribut AS 'Atribut Karakter', " &
                                  "tbkarakter.atk, tbkarakter.def, tbkarakter.hp, " &
                                  "tbkarakter.pasif, tbkarakter.skill1, tbkarakter.skill2, tbkarakter.ultimate " &
                                  "FROM tbkarakter " &
                                  "INNER JOIN tbatribute ON tbkarakter.kodeatribut = tbatribute.kodeatribut " &
                                  "ORDER BY tbkarakter.kodekarakter ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
#End Region

#Region "getcharbykode"
    Public Function getcharByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbkarakter WHERE kodekarakter = @kodekarakter"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kodekarakter", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
#End Region

#Region "kode char sudah ada"
    Public Function kodecharSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbkarakter WHERE kodekarakter = @kodekarakter"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodekarakter", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function
#End Region

#Region "simpan karakter"
    Public Function simpanchar(kodekarakter As String, kodeatribut As String, nama As String, atk As String, def As String, hp As Integer, pasif As String, skill1 As String, skill2 As String, ultimate As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbkarakter (kodekarakter, nama, kodeatribut, atk, def, hp, pasif, skill1, skill2, ultimate) " &
                                  "VALUES (@kodekarakter, @nama, @kodeatribut, @atk, @def, @hp, @pasif, @skill1, @skill2, @ultimate)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodekarakter", kodekarakter)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kodeatribut", kodeatribut)
                    cmd.Parameters.AddWithValue("@atk", atk)
                    cmd.Parameters.AddWithValue("@def", def)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@pasif", pasif)
                    cmd.Parameters.AddWithValue("@skill1", skill1)
                    cmd.Parameters.AddWithValue("@skill2", skill2)
                    cmd.Parameters.AddWithValue("@ultimate", ultimate)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "ubah karakter"
    Public Function ubahchar(kodekarakter As String, kodeatribut As String, nama As String, atk As String, def As String, hp As Integer, pasif As String, skill1 As String, skill2 As String, ultimate As String) As Boolean
        Try
            Dim query As String = "UPDATE tbkarakter SET nama = @nama, kodeatribut = @kodeatribut, atk = @atk, def = @def, hp = @hp, " &
                                  "pasif = @pasif, skill1 = @skill1, skill2 = @skill2, ultimate = @ultimate " &
                                  "WHERE kodekarakter = @kodekarakter"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodekarakter", kodekarakter)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kodeatribut", kodeatribut)
                    cmd.Parameters.AddWithValue("@atk", atk)
                    cmd.Parameters.AddWithValue("@def", def)
                    cmd.Parameters.AddWithValue("@hp", hp)
                    cmd.Parameters.AddWithValue("@pasif", pasif)
                    cmd.Parameters.AddWithValue("@skill1", skill1)
                    cmd.Parameters.AddWithValue("@skill2", skill2)
                    cmd.Parameters.AddWithValue("@ultimate", ultimate)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region "Hapus Buku"
	Public Function hapuschar(kodekarakter As String) As Boolean
		Try
			Dim query As String = "DELETE FROM tbkarakter WHERE kodekarakter = @kodekarakter"
			Using conn As MySqlConnection = GetConnection()
				conn.Open()
				Using cmd As New MySqlCommand(query, conn)
					cmd.Parameters.AddWithValue("@kodekarakter", kodekarakter)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			Return True
		Catch ex As Exception
			MessageBox.Show("Gagal menghapus data buku: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return False
		End Try
	End Function
#End Region

#End Region

#Region "Atribut"
#Region "getatribut"
	Public Function getatribut() As DataTable
		Dim dt As New DataTable()
		Try
			Dim query As String = "SELECT * FROM tbatribute ORDER BY kodeatribut ASC"
			Using conn As MySqlConnection = GetConnection()
				Using da As New MySqlDataAdapter(query, conn)
					da.Fill(dt)
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Gagal menampilkan data atribut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return dt
	End Function
#End Region

#Region "kodeatribut sudah ada"
	Public Function kodeatributSudahAda(kode As String) As Boolean
		Try
			Dim query As String = "SELECT COUNT(*) FROM tbatribute WHERE kodeatribut = @kodeatribut"
			Using conn As MySqlConnection = GetConnection()
				conn.Open()
				Using cmd As New MySqlCommand(query, conn)
					cmd.Parameters.AddWithValue("@kodeatribut", kode)
					Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
					Return jumlah > 0
				End Using
			End Using
		Catch ex As Exception
			Return True
		End Try
	End Function
#End Region

#Region "Search atribut"
	Public Function searchAtribut(keyword As String) As DataTable
		Dim dt As New DataTable()
		Try
			Dim query As String = "SELECT * FROM tbatribute WHERE atribut LIKE @keyword OR kodeatribut LIKE @keyword ORDER BY kodeatribut ASC"
			Using conn As MySqlConnection = GetConnection()
				Using da As New MySqlDataAdapter(query, conn)
					da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
					da.Fill(dt)
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Gagal mencari data atribut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return dt
	End Function
#End Region

#Region "getatributbykode"
	Public Function getatributByKode(kode As String) As DataTable
		Dim dt As New DataTable()
		Try
			Dim query As String = "SELECT * FROM tbatribute WHERE kodeatribut = @kodeatribut"
			Using conn As MySqlConnection = GetConnection()
				Using da As New MySqlDataAdapter(query, conn)
					da.SelectCommand.Parameters.AddWithValue("@kodeatribut", kode)
					da.Fill(dt)
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return dt
	End Function
#End Region

#Region "simpan atribut"
	Public Function simpanAtribut(kodeatribut As String, atribut As String) As Boolean
		Try
			Dim query As String = "INSERT INTO tbatribute (kodeatribut, atribut) VALUES (@kodeatribut, @atribut)"
			Using conn As MySqlConnection = GetConnection()
				conn.Open()
				Using cmd As New MySqlCommand(query, conn)
					cmd.Parameters.AddWithValue("@kodeatribut", kodeatribut)
					cmd.Parameters.AddWithValue("@atribut", atribut)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			Return True
		Catch ex As Exception
			MessageBox.Show("Gagal menyimpan data atribut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return False
		End Try
	End Function
#End Region

#Region "ubah atribut"
	Public Function ubahAtribut(kodeatribut As String, atribut As String) As Boolean
		Try
			Dim query As String = "UPDATE tbatribute SET atribut = @atribut WHERE kodeatribut = @kodeatribut"
			Using conn As MySqlConnection = GetConnection()
				conn.Open()
				Using cmd As New MySqlCommand(query, conn)
					cmd.Parameters.AddWithValue("@kodeatribut", kodeatribut)
					cmd.Parameters.AddWithValue("@atribut", atribut)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			Return True
		Catch ex As Exception
			MessageBox.Show("Gagal mengubah data atribut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return False
		End Try
	End Function
#End Region

#Region "hapus atribut"
	Public Function hapusAtribut(kodeatribut As String) As Boolean
		Try
			Dim query As String = "DELETE FROM tbatribute WHERE kodeatribut = @kodeatribut"
			Using conn As MySqlConnection = GetConnection()
				conn.Open()
				Using cmd As New MySqlCommand(query, conn)
					cmd.Parameters.AddWithValue("@kodeatribut", kodeatribut)
					cmd.ExecuteNonQuery()
				End Using
			End Using
			Return True
		Catch ex As Exception
			MessageBox.Show("Gagal menghapus data atribut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return False
		End Try
	End Function
#End Region

#Region ""

#End Region


#End Region



End Module