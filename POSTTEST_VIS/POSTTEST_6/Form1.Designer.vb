<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        txtCari = New TextBox()
        dgvChar = New DataGridView()
        btnClose = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        Label1 = New Label()
        CType(dgvChar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(60, 52)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(949, 31)
        txtCari.TabIndex = 17
        ' 
        ' dgvChar
        ' 
        dgvChar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChar.Location = New Point(12, 89)
        dgvChar.Name = "dgvChar"
        dgvChar.RowHeadersWidth = 62
        dgvChar.Size = New Size(997, 487)
        dgvChar.TabIndex = 19
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(366, 12)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(112, 34)
        btnClose.TabIndex = 10
        btnClose.Text = "Keluar"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(248, 12)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(130, 12)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 8
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(12, 12)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Tambah"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 25)
        Label1.TabIndex = 20
        Label1.Text = "Cari"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1027, 588)
        Controls.Add(Label1)
        Controls.Add(dgvChar)
        Controls.Add(txtCari)
        Controls.Add(btnClose)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Name = "Form1"
        Text = "Form1"
        CType(dgvChar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvChar As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
End Class
