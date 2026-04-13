<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txtkode = New TextBox()
        txtnama = New TextBox()
        btnHapuskan = New Button()
        btnreset = New Button()
        btnbatal = New Button()
        dgvubah = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        txtCari = New TextBox()
        Label11 = New Label()
        CType(dgvubah, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Karakter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Karakter"
        ' 
        ' txtkode
        ' 
        txtkode.Enabled = False
        txtkode.Location = New Point(146, 55)
        txtkode.Name = "txtkode"
        txtkode.Size = New Size(655, 31)
        txtkode.TabIndex = 10
        ' 
        ' txtnama
        ' 
        txtnama.Enabled = False
        txtnama.Location = New Point(146, 12)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(655, 31)
        txtnama.TabIndex = 11
        ' 
        ' btnHapuskan
        ' 
        btnHapuskan.Location = New Point(807, 12)
        btnHapuskan.Name = "btnHapuskan"
        btnHapuskan.Size = New Size(112, 34)
        btnHapuskan.TabIndex = 18
        btnHapuskan.Text = "Hapus"
        btnHapuskan.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(807, 52)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(112, 34)
        btnreset.TabIndex = 19
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnbatal
        ' 
        btnbatal.Location = New Point(807, 92)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(112, 34)
        btnbatal.TabIndex = 20
        btnbatal.Text = "Batalkan"
        btnbatal.UseVisualStyleBackColor = True
        ' 
        ' dgvubah
        ' 
        dgvubah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvubah.Location = New Point(12, 132)
        dgvubah.Name = "dgvubah"
        dgvubah.RowHeadersWidth = 62
        dgvubah.Size = New Size(907, 384)
        dgvubah.TabIndex = 21
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(146, 92)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(655, 31)
        txtCari.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 92)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 25)
        Label11.TabIndex = 23
        Label11.Text = "Cari"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 502)
        Controls.Add(Label11)
        Controls.Add(txtCari)
        Controls.Add(dgvubah)
        Controls.Add(btnbatal)
        Controls.Add(btnreset)
        Controls.Add(btnHapuskan)
        Controls.Add(txtnama)
        Controls.Add(txtkode)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form Hapus"
        CType(dgvubah, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtatk As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txthp As TextBox
    Friend WithEvents txtdef As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtpasif As TextBox
    Friend WithEvents txtskill1 As TextBox
    Friend WithEvents txtskill2 As TextBox
    Friend WithEvents txtulti As TextBox
    Friend WithEvents cbatribut As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHapuskan As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents dgvubah As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label11 As Label
End Class
