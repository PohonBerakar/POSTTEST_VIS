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
        Label1 = New Label()
        Label2 = New Label()
        ips = New TextBox()
        ipk = New TextBox()
        tambahah = New Button()
        reste = New Button()
        hasil = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 0
        Label1.Text = "IP Sesmester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' ips
        ' 
        ips.Location = New Point(267, 102)
        ips.Name = "ips"
        ips.Size = New Size(156, 23)
        ips.TabIndex = 2
        ' 
        ' ipk
        ' 
        ipk.Location = New Point(267, 187)
        ipk.Name = "ipk"
        ipk.ReadOnly = True
        ipk.Size = New Size(156, 23)
        ipk.TabIndex = 3
        ' 
        ' tambahah
        ' 
        tambahah.Location = New Point(267, 146)
        tambahah.Name = "tambahah"
        tambahah.Size = New Size(75, 23)
        tambahah.TabIndex = 4
        tambahah.Text = "Tambah"
        tambahah.UseVisualStyleBackColor = True
        ' 
        ' reste
        ' 
        reste.Location = New Point(348, 146)
        reste.Name = "reste"
        reste.Size = New Size(75, 23)
        reste.TabIndex = 5
        reste.Text = "Reset"
        reste.UseVisualStyleBackColor = True
        ' 
        ' hasil
        ' 
        hasil.AutoSize = True
        hasil.BackColor = Color.White
        hasil.Location = New Point(323, 242)
        hasil.Name = "hasil"
        hasil.Size = New Size(19, 15)
        hasil.TabIndex = 6
        hasil.Text = "    "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(hasil)
        Controls.Add(reste)
        Controls.Add(tambahah)
        Controls.Add(ipk)
        Controls.Add(ips)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ips As TextBox
    Friend WithEvents ipk As TextBox
    Friend WithEvents tambahah As Button
    Friend WithEvents reste As Button
    Friend WithEvents hasil As Label

End Class
