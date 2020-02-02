<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbNoMeja = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdTransaksi = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.dgvTransaksi = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDiskon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.txtPembayaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtIdMenu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNamaMenu = New System.Windows.Forms.TextBox()
        Me.txtKategori = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.TextBox()
        Me.lblTanggal = New System.Windows.Forms.TextBox()
        Me.lblWaktu = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnBatalMenu = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.timeTransaksi = New System.Windows.Forms.Timer(Me.components)
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.btnClose)
        Me.Panel9.Location = New System.Drawing.Point(-126, 13)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1232, 33)
        Me.Panel9.TabIndex = 269
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 181
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(190, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 26)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "TRANSAKSI"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1328, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 25)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbNoMeja)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNamaPelanggan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 115)
        Me.GroupBox1.TabIndex = 270
        Me.GroupBox1.TabStop = False
        '
        'cmbNoMeja
        '
        Me.cmbNoMeja.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNoMeja.FormattingEnabled = True
        Me.cmbNoMeja.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbNoMeja.Location = New System.Drawing.Point(108, 78)
        Me.cmbNoMeja.Name = "cmbNoMeja"
        Me.cmbNoMeja.Size = New System.Drawing.Size(121, 23)
        Me.cmbNoMeja.TabIndex = 278
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 277
        Me.Label2.Text = "No Meja"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.BackColor = System.Drawing.Color.White
        Me.txtNamaPelanggan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPelanggan.ForeColor = System.Drawing.Color.Black
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(108, 49)
        Me.txtNamaPelanggan.MaxLength = 10
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(189, 23)
        Me.txtNamaPelanggan.TabIndex = 274
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "Nama Pelanggan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdTransaksi
        '
        Me.txtIdTransaksi.BackColor = System.Drawing.Color.White
        Me.txtIdTransaksi.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTransaksi.ForeColor = System.Drawing.Color.Black
        Me.txtIdTransaksi.Location = New System.Drawing.Point(108, 20)
        Me.txtIdTransaksi.MaxLength = 10
        Me.txtIdTransaksi.Name = "txtIdTransaksi"
        Me.txtIdTransaksi.Size = New System.Drawing.Size(189, 23)
        Me.txtIdTransaksi.TabIndex = 272
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 15)
        Me.Label20.TabIndex = 273
        Me.Label20.Text = "ID Transaksi"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(521, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 140)
        Me.GroupBox2.TabIndex = 271
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL BAYAR"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBayar.Enabled = False
        Me.txtTotalBayar.Font = New System.Drawing.Font("DS-Digital", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.ForeColor = System.Drawing.Color.White
        Me.txtTotalBayar.Location = New System.Drawing.Point(16, 30)
        Me.txtTotalBayar.MaxLength = 10
        Me.txtTotalBayar.Multiline = True
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(336, 104)
        Me.txtTotalBayar.TabIndex = 281
        Me.txtTotalBayar.Text = "250.000"
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvTransaksi
        '
        Me.dgvTransaksi.AllowUserToAddRows = False
        Me.dgvTransaksi.AllowUserToDeleteRows = False
        Me.dgvTransaksi.AllowUserToResizeColumns = False
        Me.dgvTransaksi.AllowUserToResizeRows = False
        Me.dgvTransaksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransaksi.Location = New System.Drawing.Point(40, 232)
        Me.dgvTransaksi.Name = "dgvTransaksi"
        Me.dgvTransaksi.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransaksi.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransaksi.Size = New System.Drawing.Size(849, 168)
        Me.dgvTransaksi.TabIndex = 272
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbDiskon)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtKembalian)
        Me.GroupBox3.Controls.Add(Me.txtPembayaran)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(40, 406)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 114)
        Me.GroupBox3.TabIndex = 273
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PEMBAYARAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(83, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 15)
        Me.Label7.TabIndex = 283
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDiskon
        '
        Me.cmbDiskon.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiskon.FormattingEnabled = True
        Me.cmbDiskon.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbDiskon.Location = New System.Drawing.Point(20, 54)
        Me.cmbDiskon.Name = "cmbDiskon"
        Me.cmbDiskon.Size = New System.Drawing.Size(63, 23)
        Me.cmbDiskon.TabIndex = 279
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 19)
        Me.Label4.TabIndex = 281
        Me.Label4.Text = "DISKON"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKembalian
        '
        Me.txtKembalian.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKembalian.Font = New System.Drawing.Font("DS-Digital", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalian.ForeColor = System.Drawing.Color.White
        Me.txtKembalian.Location = New System.Drawing.Point(313, 51)
        Me.txtKembalian.MaxLength = 10
        Me.txtKembalian.Multiline = True
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(153, 41)
        Me.txtKembalian.TabIndex = 280
        Me.txtKembalian.Text = "10.000"
        Me.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPembayaran
        '
        Me.txtPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPembayaran.Font = New System.Drawing.Font("DS-Digital", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPembayaran.ForeColor = System.Drawing.Color.White
        Me.txtPembayaran.Location = New System.Drawing.Point(130, 50)
        Me.txtPembayaran.MaxLength = 10
        Me.txtPembayaran.Multiline = True
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.Size = New System.Drawing.Size(153, 41)
        Me.txtPembayaran.TabIndex = 279
        Me.txtPembayaran.Text = "260.000"
        Me.txtPembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "KEMBALIAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(126, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 273
        Me.Label6.Text = "PEMBAYARAN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProses
        '
        Me.btnProses.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnProses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.ForeColor = System.Drawing.Color.White
        Me.btnProses.Image = CType(resources.GetObject("btnProses.Image"), System.Drawing.Image)
        Me.btnProses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProses.Location = New System.Drawing.Point(4, 14)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(225, 41)
        Me.btnProses.TabIndex = 284
        Me.btnProses.Text = "&Proses dan Cetak"
        Me.btnProses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.Location = New System.Drawing.Point(235, 14)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(111, 41)
        Me.btnBatal.TabIndex = 286
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'txtIdMenu
        '
        Me.txtIdMenu.BackColor = System.Drawing.Color.White
        Me.txtIdMenu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMenu.ForeColor = System.Drawing.Color.Black
        Me.txtIdMenu.Location = New System.Drawing.Point(80, 203)
        Me.txtIdMenu.MaxLength = 10
        Me.txtIdMenu.Name = "txtIdMenu"
        Me.txtIdMenu.Size = New System.Drawing.Size(115, 23)
        Me.txtIdMenu.TabIndex = 279
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 279
        Me.Label8.Text = "Kode"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNamaMenu
        '
        Me.txtNamaMenu.BackColor = System.Drawing.Color.White
        Me.txtNamaMenu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaMenu.ForeColor = System.Drawing.Color.Black
        Me.txtNamaMenu.Location = New System.Drawing.Point(195, 203)
        Me.txtNamaMenu.MaxLength = 10
        Me.txtNamaMenu.Name = "txtNamaMenu"
        Me.txtNamaMenu.Size = New System.Drawing.Size(115, 23)
        Me.txtNamaMenu.TabIndex = 287
        '
        'txtKategori
        '
        Me.txtKategori.BackColor = System.Drawing.Color.White
        Me.txtKategori.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKategori.ForeColor = System.Drawing.Color.Black
        Me.txtKategori.Location = New System.Drawing.Point(310, 203)
        Me.txtKategori.MaxLength = 10
        Me.txtKategori.Name = "txtKategori"
        Me.txtKategori.Size = New System.Drawing.Size(115, 23)
        Me.txtKategori.TabIndex = 288
        '
        'txtStok
        '
        Me.txtStok.BackColor = System.Drawing.Color.White
        Me.txtStok.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.ForeColor = System.Drawing.Color.Black
        Me.txtStok.Location = New System.Drawing.Point(425, 203)
        Me.txtStok.MaxLength = 10
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(115, 23)
        Me.txtStok.TabIndex = 289
        '
        'txtHargaJual
        '
        Me.txtHargaJual.BackColor = System.Drawing.Color.White
        Me.txtHargaJual.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.ForeColor = System.Drawing.Color.Black
        Me.txtHargaJual.Location = New System.Drawing.Point(540, 203)
        Me.txtHargaJual.MaxLength = 10
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(115, 23)
        Me.txtHargaJual.TabIndex = 290
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.White
        Me.txtQTY.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.ForeColor = System.Drawing.Color.Black
        Me.txtQTY.Location = New System.Drawing.Point(655, 203)
        Me.txtQTY.MaxLength = 10
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(115, 23)
        Me.txtQTY.TabIndex = 291
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.BackColor = System.Drawing.Color.White
        Me.txtTotalHarga.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.ForeColor = System.Drawing.Color.Black
        Me.txtTotalHarga.Location = New System.Drawing.Point(770, 203)
        Me.txtTotalHarga.MaxLength = 10
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(115, 23)
        Me.txtTotalHarga.TabIndex = 292
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsername.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(7, 19)
        Me.lblUsername.MaxLength = 10
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(153, 23)
        Me.lblUsername.TabIndex = 279
        '
        'lblTanggal
        '
        Me.lblTanggal.BackColor = System.Drawing.Color.White
        Me.lblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTanggal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggal.ForeColor = System.Drawing.Color.Black
        Me.lblTanggal.Location = New System.Drawing.Point(7, 48)
        Me.lblTanggal.MaxLength = 10
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(153, 23)
        Me.lblTanggal.TabIndex = 293
        '
        'lblWaktu
        '
        Me.lblWaktu.BackColor = System.Drawing.Color.White
        Me.lblWaktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWaktu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaktu.ForeColor = System.Drawing.Color.Black
        Me.lblWaktu.Location = New System.Drawing.Point(7, 77)
        Me.lblWaktu.MaxLength = 10
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(104, 23)
        Me.lblWaktu.TabIndex = 294
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblUsername)
        Me.GroupBox4.Controls.Add(Me.lblWaktu)
        Me.GroupBox4.Controls.Add(Me.lblTanggal)
        Me.GroupBox4.Location = New System.Drawing.Point(349, 52)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 115)
        Me.GroupBox4.TabIndex = 295
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnBatal)
        Me.GroupBox5.Controls.Add(Me.btnProses)
        Me.GroupBox5.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(536, 460)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(353, 62)
        Me.GroupBox5.TabIndex = 296
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Transaksi"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnBatalMenu)
        Me.GroupBox6.Controls.Add(Me.btnHapus)
        Me.GroupBox6.Controls.Add(Me.btnEdit)
        Me.GroupBox6.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(537, 406)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(355, 55)
        Me.GroupBox6.TabIndex = 297
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Menu"
        '
        'btnBatalMenu
        '
        Me.btnBatalMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnBatalMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatalMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatalMenu.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatalMenu.ForeColor = System.Drawing.Color.White
        Me.btnBatalMenu.Image = CType(resources.GetObject("btnBatalMenu.Image"), System.Drawing.Image)
        Me.btnBatalMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatalMenu.Location = New System.Drawing.Point(234, 14)
        Me.btnBatalMenu.Name = "btnBatalMenu"
        Me.btnBatalMenu.Size = New System.Drawing.Size(85, 35)
        Me.btnBatalMenu.TabIndex = 238
        Me.btnBatalMenu.Text = "&Batal"
        Me.btnBatalMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBatalMenu.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.Location = New System.Drawing.Point(145, 14)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 35)
        Me.btnHapus.TabIndex = 237
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(56, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 35)
        Me.btnEdit.TabIndex = 236
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'timeTransaksi
        '
        Me.timeTransaksi.Enabled = True
        Me.timeTransaksi.Interval = 1000
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 532)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtKategori)
        Me.Controls.Add(Me.txtNamaMenu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvTransaksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transaksi"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNamaPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbNoMeja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtPembayaran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtIdMenu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNamaMenu As System.Windows.Forms.TextBox
    Friend WithEvents txtKategori As System.Windows.Forms.TextBox
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblTanggal As System.Windows.Forms.TextBox
    Friend WithEvents lblWaktu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBatalMenu As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents timeTransaksi As System.Windows.Forms.Timer
    Friend WithEvents cmbDiskon As System.Windows.Forms.ComboBox
End Class
