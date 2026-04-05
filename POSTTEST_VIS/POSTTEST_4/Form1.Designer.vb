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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        DivisiToolStripMenuItem = New ToolStripMenuItem()
        LiderToolStripMenuItem = New ToolStripMenuItem()
        BabuLevel2ToolStripMenuItem = New ToolStripMenuItem()
        BabuLevel1ToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ComboBox1 = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TabPage2 = New TabPage()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage3 = New TabPage()
        Button3 = New Button()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox2 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DivisiToolStripMenuItem})
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' DivisiToolStripMenuItem
        ' 
        DivisiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LiderToolStripMenuItem, BabuLevel2ToolStripMenuItem, BabuLevel1ToolStripMenuItem})
        DivisiToolStripMenuItem.Name = "DivisiToolStripMenuItem"
        DivisiToolStripMenuItem.Size = New Size(156, 34)
        DivisiToolStripMenuItem.Text = "Divisi"
        ' 
        ' LiderToolStripMenuItem
        ' 
        LiderToolStripMenuItem.Name = "LiderToolStripMenuItem"
        LiderToolStripMenuItem.Size = New Size(213, 34)
        LiderToolStripMenuItem.Text = "Lider"
        ' 
        ' BabuLevel2ToolStripMenuItem
        ' 
        BabuLevel2ToolStripMenuItem.Name = "BabuLevel2ToolStripMenuItem"
        BabuLevel2ToolStripMenuItem.Size = New Size(213, 34)
        BabuLevel2ToolStripMenuItem.Text = "Babu Level 2"
        ' 
        ' BabuLevel1ToolStripMenuItem
        ' 
        BabuLevel1ToolStripMenuItem.Name = "BabuLevel1ToolStripMenuItem"
        BabuLevel1ToolStripMenuItem.Size = New Size(213, 34)
        BabuLevel1ToolStripMenuItem.Text = "Babu Level 1"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(106, 29)
        BukaDataToolStripMenuItem.Text = "Buka data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 94)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 344)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ComboBox1)
        TabPage1.Controls.Add(RadioButton2)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 306)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utana"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Lider", "Babu level 2", "Babu Level 1"})
        ComboBox1.Location = New Point(137, 203)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(300, 33)
        ComboBox1.TabIndex = 10
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(291, 155)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(126, 29)
        RadioButton2.TabIndex = 9
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(137, 157)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(102, 29)
        RadioButton1.TabIndex = 8
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki Laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(137, 100)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 6
        Label6.Text = "Divisi"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(137, 51)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(300, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(137, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(300, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 3
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 1
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TextBox4)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(MaskedTextBox1)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 306)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(147, 107)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(333, 113)
        TextBox4.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(147, 54)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(333, 31)
        TextBox3.TabIndex = 4
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(147, 3)
        MaskedTextBox1.Mask = "0000-0000-0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(333, 31)
        MaskedTextBox1.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 107)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 25)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 54)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 25)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 3)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 25)
        Label7.TabIndex = 0
        Label7.Text = "Nomor Telepon"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Button3)
        TabPage3.Controls.Add(Button2)
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(Button1)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 306)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(650, 46)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "Cetak Kartu"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(650, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 4
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox9)
        GroupBox2.Controls.Add(CheckBox8)
        GroupBox2.Controls.Add(CheckBox7)
        GroupBox2.Controls.Add(CheckBox6)
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Location = New Point(206, 150)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(419, 137)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobby"
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(274, 100)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(109, 29)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Ngoding"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(273, 65)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(125, 29)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Merampok"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(273, 30)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(112, 29)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Berenang"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(155, 100)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(106, 29)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Mendaki"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(155, 65)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(106, 29)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Mancing"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(155, 30)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(100, 29)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Gaming"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 100)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(146, 29)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Menggambar"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 65)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(99, 29)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Menulis"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 30)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(116, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Membaca"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Location = New Point(206, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(419, 134)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(6, 100)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(104, 29)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "Member"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(6, 65)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(85, 29)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Atmin"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(6, 30)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(75, 29)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Lider"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(30, 162)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "Browse"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(162, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 13F)
        Label1.Location = New Point(16, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 31)
        Label1.TabIndex = 2
        Label1.Text = "Judul Aplikasi"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.vh
        PictureBox2.Location = New Point(697, 33)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(89, 89)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DivisiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BabuLevel2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BabuLevel1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
