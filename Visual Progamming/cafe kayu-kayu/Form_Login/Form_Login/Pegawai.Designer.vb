<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pegawai
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
        Me.tabelpegawai = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.tAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tTempat = New System.Windows.Forms.TextBox()
        Me.tPekerjaan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.tnohp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.tabelpegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelpegawai
        '
        Me.tabelpegawai.AllowUserToAddRows = False
        Me.tabelpegawai.AllowUserToResizeRows = False
        Me.tabelpegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpegawai.Location = New System.Drawing.Point(15, 200)
        Me.tabelpegawai.Name = "tabelpegawai"
        Me.tabelpegawai.Size = New System.Drawing.Size(617, 150)
        Me.tabelpegawai.TabIndex = 31
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(372, 143)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(78, 51)
        Me.bHapus.TabIndex = 30
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(277, 143)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(78, 51)
        Me.bUbah.TabIndex = 29
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(183, 143)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(78, 51)
        Me.bTambah.TabIndex = 28
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'tAlamat
        '
        Me.tAlamat.Location = New System.Drawing.Point(367, 14)
        Me.tAlamat.Multiline = True
        Me.tAlamat.Name = "tAlamat"
        Me.tAlamat.Size = New System.Drawing.Size(265, 58)
        Me.tAlamat.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tanggal Lahir"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(124, 37)
        Me.tNama.MaxLength = 50
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(154, 20)
        Me.tNama.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nama"
        '
        'tID
        '
        Me.tID.Location = New System.Drawing.Point(124, 11)
        Me.tID.MaxLength = 13
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(154, 20)
        Me.tID.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID Pegawai"
        '
        'tTempat
        '
        Me.tTempat.Location = New System.Drawing.Point(123, 63)
        Me.tTempat.MaxLength = 20
        Me.tTempat.Name = "tTempat"
        Me.tTempat.Size = New System.Drawing.Size(154, 20)
        Me.tTempat.TabIndex = 32
        '
        'tPekerjaan
        '
        Me.tPekerjaan.Location = New System.Drawing.Point(123, 115)
        Me.tPekerjaan.MaxLength = 20
        Me.tPekerjaan.Name = "tPekerjaan"
        Me.tPekerjaan.Size = New System.Drawing.Size(154, 20)
        Me.tPekerjaan.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Pekerjaan / Bagian"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 20)
        Me.DateTimePicker1.TabIndex = 35
        '
        'tnohp
        '
        Me.tnohp.Location = New System.Drawing.Point(367, 89)
        Me.tnohp.MaxLength = 20
        Me.tnohp.Name = "tnohp"
        Me.tnohp.Size = New System.Drawing.Size(154, 20)
        Me.tnohp.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "No HP"
        '
        'Pegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 360)
        Me.Controls.Add(Me.tnohp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.tPekerjaan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tTempat)
        Me.Controls.Add(Me.tabelpegawai)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.tAlamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pegawai"
        Me.Text = "Pegawai"
        CType(Me.tabelpegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabelpegawai As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents tAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tTempat As System.Windows.Forms.TextBox
    Friend WithEvents tPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tnohp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
