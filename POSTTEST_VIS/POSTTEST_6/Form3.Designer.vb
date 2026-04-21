<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtkode = New TextBox()
        txtnama = New TextBox()
        txtatk = New TextBox()
        GroupBox1 = New GroupBox()
        txthp = New TextBox()
        txtdef = New TextBox()
        GroupBox2 = New GroupBox()
        txtulti = New TextBox()
        txtskill2 = New TextBox()
        txtskill1 = New TextBox()
        txtpasif = New TextBox()
        cbatribut = New ComboBox()
        Button1 = New Button()
        btnubahkan = New Button()
        btnreset = New Button()
        btnbatal = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        dgvubah = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvubah, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(492, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kode Karakter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(492, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama Karakter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(492, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 25)
        Label3.TabIndex = 2
        Label3.Text = "Atribut karakter"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 25)
        Label4.TabIndex = 3
        Label4.Text = "Attack"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 25)
        Label5.TabIndex = 4
        Label5.Text = "Deffense"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 25)
        Label6.TabIndex = 5
        Label6.Text = "HP"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 25)
        Label7.TabIndex = 6
        Label7.Text = "Passive"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(16, 128)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 25)
        Label8.TabIndex = 7
        Label8.Text = "Skill 1"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(16, 216)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 25)
        Label9.TabIndex = 8
        Label9.Text = "Skill 2"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 332)
        Label10.Name = "Label10"
        Label10.Size = New Size(145, 25)
        Label10.TabIndex = 9
        Label10.Text = "ULTIMATE MOVE"
        ' 
        ' txtkode
        ' 
        txtkode.Location = New Point(636, 9)
        txtkode.Name = "txtkode"
        txtkode.Size = New Size(247, 31)
        txtkode.TabIndex = 10
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(636, 55)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(247, 31)
        txtnama.TabIndex = 11
        ' 
        ' txtatk
        ' 
        txtatk.Location = New Point(144, 34)
        txtatk.Name = "txtatk"
        txtatk.Size = New Size(241, 31)
        txtatk.TabIndex = 13
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txthp)
        GroupBox1.Controls.Add(txtdef)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtatk)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Location = New Point(492, 190)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(391, 179)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Stats"
        ' 
        ' txthp
        ' 
        txthp.Location = New Point(144, 133)
        txthp.Name = "txthp"
        txthp.Size = New Size(241, 31)
        txthp.TabIndex = 15
        ' 
        ' txtdef
        ' 
        txtdef.Location = New Point(144, 82)
        txtdef.Name = "txtdef"
        txtdef.Size = New Size(241, 31)
        txtdef.TabIndex = 14
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtulti)
        GroupBox2.Controls.Add(txtskill2)
        GroupBox2.Controls.Add(txtskill1)
        GroupBox2.Controls.Add(txtpasif)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(450, 484)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Deskripsi Skills"
        ' 
        ' txtulti
        ' 
        txtulti.Location = New Point(6, 360)
        txtulti.Multiline = True
        txtulti.Name = "txtulti"
        txtulti.Size = New Size(438, 113)
        txtulti.TabIndex = 12
        ' 
        ' txtskill2
        ' 
        txtskill2.Location = New Point(80, 216)
        txtskill2.Multiline = True
        txtskill2.Name = "txtskill2"
        txtskill2.Size = New Size(364, 86)
        txtskill2.TabIndex = 11
        ' 
        ' txtskill1
        ' 
        txtskill1.Location = New Point(80, 128)
        txtskill1.Multiline = True
        txtskill1.Name = "txtskill1"
        txtskill1.Size = New Size(364, 86)
        txtskill1.TabIndex = 10
        ' 
        ' txtpasif
        ' 
        txtpasif.Location = New Point(80, 30)
        txtpasif.Multiline = True
        txtpasif.Name = "txtpasif"
        txtpasif.Size = New Size(364, 86)
        txtpasif.TabIndex = 7
        ' 
        ' cbatribut
        ' 
        cbatribut.FormattingEnabled = True
        cbatribut.Location = New Point(636, 103)
        cbatribut.Name = "cbatribut"
        cbatribut.Size = New Size(247, 33)
        cbatribut.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(636, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(247, 34)
        Button1.TabIndex = 17
        Button1.Text = "Tambahkan Atribut Baru"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnubahkan
        ' 
        btnubahkan.Location = New Point(492, 386)
        btnubahkan.Name = "btnubahkan"
        btnubahkan.Size = New Size(112, 34)
        btnubahkan.TabIndex = 18
        btnubahkan.Text = "Ubah"
        btnubahkan.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(636, 386)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(112, 34)
        btnreset.TabIndex = 19
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnbatal
        ' 
        btnbatal.Location = New Point(771, 386)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(112, 34)
        btnbatal.TabIndex = 20
        btnbatal.Text = "Batalkan"
        btnbatal.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' dgvubah
        ' 
        dgvubah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvubah.Location = New Point(12, 510)
        dgvubah.Name = "dgvubah"
        dgvubah.RowHeadersWidth = 62
        dgvubah.Size = New Size(871, 411)
        dgvubah.TabIndex = 21
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(902, 933)
        Controls.Add(dgvubah)
        Controls.Add(btnbatal)
        Controls.Add(btnreset)
        Controls.Add(btnubahkan)
        Controls.Add(Button1)
        Controls.Add(cbatribut)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(txtnama)
        Controls.Add(txtkode)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form Ubah"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvubah, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnubahkan As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvubah As DataGridView
End Class
