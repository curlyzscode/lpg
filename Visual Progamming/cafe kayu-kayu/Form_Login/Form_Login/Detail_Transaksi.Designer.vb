<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Transaksi
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
        Me.tMeja = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabeldetailtransaksi = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tTransaksi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tDetail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tQty = New System.Windows.Forms.TextBox()
        Me.tDiskon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.tabeldetailtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tMeja
        '
        Me.tMeja.Location = New System.Drawing.Point(115, 60)
        Me.tMeja.MaxLength = 20
        Me.tMeja.Name = "tMeja"
        Me.tMeja.Size = New System.Drawing.Size(154, 20)
        Me.tMeja.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "No Meja"
        '
        'tabeldetailtransaksi
        '
        Me.tabeldetailtransaksi.AllowUserToAddRows = False
        Me.tabeldetailtransaksi.AllowUserToResizeRows = False
        Me.tabeldetailtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabeldetailtransaksi.Location = New System.Drawing.Point(13, 183)
        Me.tabeldetailtransaksi.Name = "tabeldetailtransaksi"
        Me.tabeldetailtransaksi.Size = New System.Drawing.Size(530, 150)
        Me.tabeldetailtransaksi.TabIndex = 72
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(349, 115)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(78, 51)
        Me.bHapus.TabIndex = 71
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(254, 115)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(78, 51)
        Me.bUbah.TabIndex = 70
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(160, 115)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(78, 51)
        Me.bTambah.TabIndex = 69
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Qty"
        '
        'tTransaksi
        '
        Me.tTransaksi.Location = New System.Drawing.Point(115, 34)
        Me.tTransaksi.MaxLength = 50
        Me.tTransaksi.Name = "tTransaksi"
        Me.tTransaksi.Size = New System.Drawing.Size(154, 20)
        Me.tTransaksi.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "ID Detail Transaksi"
        '
        'tDetail
        '
        Me.tDetail.Location = New System.Drawing.Point(115, 8)
        Me.tDetail.MaxLength = 13
        Me.tDetail.Name = "tDetail"
        Me.tDetail.Size = New System.Drawing.Size(154, 20)
        Me.tDetail.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "ID Transaksi"
        '
        'tQty
        '
        Me.tQty.Location = New System.Drawing.Point(115, 86)
        Me.tQty.MaxLength = 20
        Me.tQty.Name = "tQty"
        Me.tQty.Size = New System.Drawing.Size(154, 20)
        Me.tQty.TabIndex = 75
        '
        'tDiskon
        '
        Me.tDiskon.Location = New System.Drawing.Point(389, 8)
        Me.tDiskon.MaxLength = 20
        Me.tDiskon.Name = "tDiskon"
        Me.tDiskon.Size = New System.Drawing.Size(154, 20)
        Me.tDiskon.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Diskon"
        '
        'tTotal
        '
        Me.tTotal.Location = New System.Drawing.Point(389, 34)
        Me.tTotal.MaxLength = 20
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(154, 20)
        Me.tTotal.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Total Bayar"
        '
        'Detail_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 334)
        Me.Controls.Add(Me.tTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tDiskon)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tQty)
        Me.Controls.Add(Me.tMeja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabeldetailtransaksi)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tDetail)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Detail_Transaksi"
        Me.Text = "Detail_Transaksi"
        CType(Me.tabeldetailtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tMeja As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabeldetailtransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tQty As System.Windows.Forms.TextBox
    Friend WithEvents tDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
