<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        JudulHapus = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Hapus = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        JudulTambah = New TextBox()
        GenreTambah = New TextBox()
        Tambah = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        DataBuku = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' JudulHapus
        ' 
        JudulHapus.Location = New Point(97, 38)
        JudulHapus.Name = "JudulHapus"
        JudulHapus.Size = New Size(100, 23)
        JudulHapus.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(54, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 7
        Label5.Text = "Judul Buku"
        ' 
        ' Hapus
        ' 
        Hapus.Location = New Point(97, 82)
        Hapus.Name = "Hapus"
        Hapus.Size = New Size(100, 23)
        Hapus.TabIndex = 9
        Hapus.Text = "Hapus"
        Hapus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 1
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "Genre"
        ' 
        ' JudulTambah
        ' 
        JudulTambah.Location = New Point(113, 38)
        JudulTambah.Name = "JudulTambah"
        JudulTambah.Size = New Size(100, 23)
        JudulTambah.TabIndex = 3
        ' 
        ' GenreTambah
        ' 
        GenreTambah.Location = New Point(113, 82)
        GenreTambah.Name = "GenreTambah"
        GenreTambah.Size = New Size(100, 23)
        GenreTambah.TabIndex = 4
        ' 
        ' Tambah
        ' 
        Tambah.Location = New Point(113, 130)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(100, 23)
        Tambah.TabIndex = 8
        Tambah.Text = "Tambahkan"
        Tambah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Tambah)
        GroupBox1.Controls.Add(GenreTambah)
        GroupBox1.Controls.Add(JudulTambah)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(294, 166)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Hapus)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(JudulHapus)
        GroupBox2.Location = New Point(302, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(291, 166)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' DataBuku
        ' 
        DataBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataBuku.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataBuku.Location = New Point(9, 173)
        DataBuku.Name = "DataBuku"
        DataBuku.Size = New Size(246, 164)
        DataBuku.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Judul"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Genre"
        Column2.Name = "Column2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents JudulHapus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Hapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents JudulTambah As TextBox
    Friend WithEvents GenreTambah As TextBox
    Friend WithEvents Tambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataBuku As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
