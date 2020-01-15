<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pelanggan
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabelpelanggan = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tPelanggan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tabelpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelpelanggan
        '
        Me.tabelpelanggan.AllowUserToAddRows = False
        Me.tabelpelanggan.AllowUserToResizeRows = False
        Me.tabelpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpelanggan.Location = New System.Drawing.Point(23, 100)
        Me.tabelpelanggan.Name = "tabelpelanggan"
        Me.tabelpelanggan.Size = New System.Drawing.Size(246, 150)
        Me.tabelpelanggan.TabIndex = 39
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(192, 71)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(77, 23)
        Me.bHapus.TabIndex = 38
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(108, 71)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(77, 23)
        Me.bUbah.TabIndex = 37
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(23, 71)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(77, 23)
        Me.bTambah.TabIndex = 36
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(115, 40)
        Me.tNama.MaxLength = 50
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(154, 20)
        Me.tNama.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nama Pelanggan"
        '
        'tPelanggan
        '
        Me.tPelanggan.Location = New System.Drawing.Point(115, 14)
        Me.tPelanggan.MaxLength = 13
        Me.tPelanggan.Name = "tPelanggan"
        Me.tPelanggan.Size = New System.Drawing.Size(154, 20)
        Me.tPelanggan.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ID Pelanggan"
        '
        'Pelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 273)
        Me.Controls.Add(Me.tabelpelanggan)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tPelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pelanggan"
        Me.Text = "Pelanggan"
        CType(Me.tabelpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabelpelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
