<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.tStatus = New System.Windows.Forms.TextBox()
        Me.tabelpegawai = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tNoHP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.tabelpegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tStatus
        '
        Me.tStatus.Location = New System.Drawing.Point(123, 111)
        Me.tStatus.MaxLength = 20
        Me.tStatus.Name = "tStatus"
        Me.tStatus.Size = New System.Drawing.Size(154, 20)
        Me.tStatus.TabIndex = 46
        '
        'tabelpegawai
        '
        Me.tabelpegawai.AllowUserToAddRows = False
        Me.tabelpegawai.AllowUserToResizeRows = False
        Me.tabelpegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelpegawai.Location = New System.Drawing.Point(31, 204)
        Me.tabelpegawai.Name = "tabelpegawai"
        Me.tabelpegawai.Size = New System.Drawing.Size(468, 150)
        Me.tabelpegawai.TabIndex = 45
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(310, 147)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(78, 51)
        Me.bHapus.TabIndex = 44
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(215, 147)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(78, 51)
        Me.bUbah.TabIndex = 43
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(121, 147)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(78, 51)
        Me.bTambah.TabIndex = 42
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Status"
        '
        'tNoHP
        '
        Me.tNoHP.Location = New System.Drawing.Point(123, 86)
        Me.tNoHP.MaxLength = 20
        Me.tNoHP.Name = "tNoHP"
        Me.tNoHP.Size = New System.Drawing.Size(154, 20)
        Me.tNoHP.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Kategori"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(123, 34)
        Me.tNama.MaxLength = 50
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(154, 20)
        Me.tNama.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nama Menu"
        '
        'tID
        '
        Me.tID.Location = New System.Drawing.Point(123, 8)
        Me.tID.MaxLength = 13
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(154, 20)
        Me.tID.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ID Menu"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 60)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Harga"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 415)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tStatus)
        Me.Controls.Add(Me.tabelpegawai)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tNoHP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.tabelpegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tStatus As System.Windows.Forms.TextBox
    Friend WithEvents tabelpegawai As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tNoHP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
