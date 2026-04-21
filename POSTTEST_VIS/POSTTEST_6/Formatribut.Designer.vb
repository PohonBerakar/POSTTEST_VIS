<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formatribut
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtkodeatribut = New TextBox()
        txtAtribut = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        Btnkembali = New Button()
        CType(dgvJenis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 14)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Atribut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(335, 14)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 1
        Label2.Text = "Atribut"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 137)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 25)
        Label3.TabIndex = 2
        Label3.Text = "Cari"
        ' 
        ' txtkodeatribut
        ' 
        txtkodeatribut.Location = New Point(134, 14)
        txtkodeatribut.Margin = New Padding(4, 5, 4, 5)
        txtkodeatribut.Name = "txtkodeatribut"
        txtkodeatribut.Size = New Size(173, 31)
        txtkodeatribut.TabIndex = 3
        ' 
        ' txtAtribut
        ' 
        txtAtribut.Location = New Point(410, 14)
        txtAtribut.Margin = New Padding(4, 5, 4, 5)
        txtAtribut.Name = "txtAtribut"
        txtAtribut.Size = New Size(180, 31)
        txtAtribut.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(51, 137)
        txtSearch.Margin = New Padding(4, 5, 4, 5)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(539, 31)
        txtSearch.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(13, 68)
        btnSimpan.Margin = New Padding(4, 5, 4, 5)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(107, 38)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(134, 68)
        btnUbah.Margin = New Padding(4, 5, 4, 5)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(107, 38)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(249, 68)
        btnHapus.Margin = New Padding(4, 5, 4, 5)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(107, 38)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(364, 68)
        btnBatal.Margin = New Padding(4, 5, 4, 5)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(107, 38)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenis
        ' 
        dgvJenis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenis.Location = New Point(13, 178)
        dgvJenis.Margin = New Padding(4, 5, 4, 5)
        dgvJenis.Name = "dgvJenis"
        dgvJenis.RowHeadersWidth = 62
        dgvJenis.Size = New Size(577, 250)
        dgvJenis.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Btnkembali
        ' 
        Btnkembali.Location = New Point(478, 68)
        Btnkembali.Name = "Btnkembali"
        Btnkembali.Size = New Size(112, 38)
        Btnkembali.TabIndex = 11
        Btnkembali.Text = "Keluar"
        Btnkembali.UseVisualStyleBackColor = True
        ' 
        ' Formatribut
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(612, 441)
        Controls.Add(Btnkembali)
        Controls.Add(dgvJenis)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtAtribut)
        Controls.Add(txtkodeatribut)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Formatribut"
        Text = "Form1"
        CType(dgvJenis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkodeatribut As TextBox
    Friend WithEvents txtAtribut As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Btnkembali As Button

End Class
