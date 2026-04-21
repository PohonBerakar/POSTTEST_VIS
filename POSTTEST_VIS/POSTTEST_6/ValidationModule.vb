Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function
    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Or cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiJenisAtribut(ep As ErrorProvider, txtkodeatribut As TextBox, txtatribut As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtkodeatribut, "Kode Atribut tidak boleh kosong")
        Dim atributValid As Boolean = ValidasiTextBox(ep, txtatribut, "Atribut tidak boleh kosong")
        Return kodeValid And atributValid
    End Function

    Public Function ValidasiDataKarakter(ep As ErrorProvider, txtkode As TextBox, cbatribut As ComboBox, txtnama As TextBox, txtatk As TextBox, txtdef As TextBox, txthp As TextBox, txtpasif As TextBox, txtskill1 As TextBox, txtskill2 As TextBox, txtulti As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtkode, "Kode Karakter wajib diisi!")
        Dim atributValid As Boolean = ValidasiComboBox(ep, cbatribut, "Silakan pilih atribut karakter!")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtnama, "Nama Karakter wajib diisi!")
        Dim atkValid As Boolean = ValidasiTextBox(ep, txtatk, "stat attack wajib diisi!")
        Dim defValid As Boolean = ValidasiTextBox(ep, txtdef, "Stat Def wajib diisi!")
        Dim hpvalid As Boolean = ValidasiTextBox(ep, txthp, "Stat HP wajib diisi!")
        Dim pasifValid As Boolean = ValidasiTextBox(ep, txtpasif, "Skill Pasif wajib diisi!")
        Dim skill1Valid As Boolean = ValidasiTextBox(ep, txtskill1, "Skill 1 wajib diisi!")
        Dim skill2Valid As Boolean = ValidasiTextBox(ep, txtskill2, "Skill 2 wajib diisi!")
        Dim ultiValid As Boolean = ValidasiTextBox(ep, txtulti, "Skill Ultimate wajib diisi!")
        Return kodeValid And atributValid And namaValid And atkValid And defValid And hpvalid And pasifValid And skill1Valid And skill2Valid And ultiValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module