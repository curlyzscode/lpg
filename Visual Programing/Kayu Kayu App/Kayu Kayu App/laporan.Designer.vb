<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan))
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoLaporanHarian = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rdoLaporanBulanan = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoLaporanMenu = New System.Windows.Forms.RadioButton()
        Me.rdoLaporanKonter = New System.Windows.Forms.RadioButton()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Panel9.Controls.Add(Me.PictureBox1)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.btnClose)
        Me.Panel9.Location = New System.Drawing.Point(-124, 13)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1232, 33)
        Me.Panel9.TabIndex = 269
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 23)
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
        Me.Label5.Size = New System.Drawing.Size(98, 26)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "LAPORAN"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(893, 436)
        Me.PictureBox2.TabIndex = 270
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dtpAwal)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdoLaporanHarian)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.rdoLaporanBulanan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.rdoLaporanMenu)
        Me.Panel1.Controls.Add(Me.rdoLaporanKonter)
        Me.Panel1.Location = New System.Drawing.Point(30, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 371)
        Me.Panel1.TabIndex = 292
        '
        'dtpAwal
        '
        Me.dtpAwal.CustomFormat = "dd/MM/yyyy"
        Me.dtpAwal.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwal.Location = New System.Drawing.Point(32, 189)
        Me.dtpAwal.Name = "dtpAwal"
        Me.dtpAwal.Size = New System.Drawing.Size(145, 23)
        Me.dtpAwal.TabIndex = 285
        Me.dtpAwal.Value = New Date(2018, 8, 11, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 289
        Me.Label3.Text = "Pilih Periode"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(32, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 35)
        Me.Button1.TabIndex = 280
        Me.Button1.Text = "&Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 288
        Me.Label2.Text = "Sampai :"
        '
        'rdoLaporanHarian
        '
        Me.rdoLaporanHarian.AutoSize = True
        Me.rdoLaporanHarian.BackColor = System.Drawing.Color.White
        Me.rdoLaporanHarian.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLaporanHarian.ForeColor = System.Drawing.Color.Black
        Me.rdoLaporanHarian.Location = New System.Drawing.Point(32, 30)
        Me.rdoLaporanHarian.Name = "rdoLaporanHarian"
        Me.rdoLaporanHarian.Size = New System.Drawing.Size(110, 19)
        Me.rdoLaporanHarian.TabIndex = 281
        Me.rdoLaporanHarian.TabStop = True
        Me.rdoLaporanHarian.Text = "Laporan Harian"
        Me.rdoLaporanHarian.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(32, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 23)
        Me.DateTimePicker1.TabIndex = 287
        Me.DateTimePicker1.Value = New Date(2018, 8, 11, 0, 0, 0, 0)
        '
        'rdoLaporanBulanan
        '
        Me.rdoLaporanBulanan.AutoSize = True
        Me.rdoLaporanBulanan.BackColor = System.Drawing.Color.White
        Me.rdoLaporanBulanan.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLaporanBulanan.ForeColor = System.Drawing.Color.Black
        Me.rdoLaporanBulanan.Location = New System.Drawing.Point(32, 55)
        Me.rdoLaporanBulanan.Name = "rdoLaporanBulanan"
        Me.rdoLaporanBulanan.Size = New System.Drawing.Size(118, 19)
        Me.rdoLaporanBulanan.TabIndex = 282
        Me.rdoLaporanBulanan.TabStop = True
        Me.rdoLaporanBulanan.Text = "Laporan Bulanan"
        Me.rdoLaporanBulanan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 286
        Me.Label4.Text = "Dari :"
        '
        'rdoLaporanMenu
        '
        Me.rdoLaporanMenu.AutoSize = True
        Me.rdoLaporanMenu.BackColor = System.Drawing.Color.White
        Me.rdoLaporanMenu.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLaporanMenu.ForeColor = System.Drawing.Color.Black
        Me.rdoLaporanMenu.Location = New System.Drawing.Point(32, 80)
        Me.rdoLaporanMenu.Name = "rdoLaporanMenu"
        Me.rdoLaporanMenu.Size = New System.Drawing.Size(104, 19)
        Me.rdoLaporanMenu.TabIndex = 283
        Me.rdoLaporanMenu.TabStop = True
        Me.rdoLaporanMenu.Text = "Laporan Menu"
        Me.rdoLaporanMenu.UseVisualStyleBackColor = False
        '
        'rdoLaporanKonter
        '
        Me.rdoLaporanKonter.AutoSize = True
        Me.rdoLaporanKonter.BackColor = System.Drawing.Color.White
        Me.rdoLaporanKonter.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLaporanKonter.ForeColor = System.Drawing.Color.Black
        Me.rdoLaporanKonter.Location = New System.Drawing.Point(32, 105)
        Me.rdoLaporanKonter.Name = "rdoLaporanKonter"
        Me.rdoLaporanKonter.Size = New System.Drawing.Size(110, 19)
        Me.rdoLaporanKonter.TabIndex = 284
        Me.rdoLaporanKonter.TabStop = True
        Me.rdoLaporanKonter.Text = "Laporan Konter"
        Me.rdoLaporanKonter.UseVisualStyleBackColor = False
        '
        'laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 532)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporan"
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtpAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoLaporanHarian As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdoLaporanBulanan As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdoLaporanMenu As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLaporanKonter As System.Windows.Forms.RadioButton
End Class
