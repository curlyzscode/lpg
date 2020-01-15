<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konter
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
        Me.tabelkonter = New System.Windows.Forms.DataGridView()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bUbah = New System.Windows.Forms.Button()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.tabelkonter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelkonter
        '
        Me.tabelkonter.AllowUserToAddRows = False
        Me.tabelkonter.AllowUserToResizeRows = False
        Me.tabelkonter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelkonter.Location = New System.Drawing.Point(12, 125)
        Me.tabelkonter.Name = "tabelkonter"
        Me.tabelkonter.Size = New System.Drawing.Size(272, 124)
        Me.tabelkonter.TabIndex = 53
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(207, 83)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(77, 27)
        Me.bHapus.TabIndex = 52
        Me.bHapus.Text = "&Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bUbah
        '
        Me.bUbah.Location = New System.Drawing.Point(112, 83)
        Me.bUbah.Name = "bUbah"
        Me.bUbah.Size = New System.Drawing.Size(77, 27)
        Me.bUbah.TabIndex = 51
        Me.bUbah.Text = "&Ubah"
        Me.bUbah.UseVisualStyleBackColor = True
        '
        'bTambah
        '
        Me.bTambah.Location = New System.Drawing.Point(18, 83)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(77, 27)
        Me.bTambah.TabIndex = 50
        Me.bTambah.Text = "&Tambah"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(112, 47)
        Me.tNama.MaxLength = 50
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(154, 20)
        Me.tNama.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nama Konter"
        '
        'tID
        '
        Me.tID.Location = New System.Drawing.Point(112, 21)
        Me.tID.MaxLength = 13
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(154, 20)
        Me.tID.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "ID Konter"
        '
        'Konter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 261)
        Me.Controls.Add(Me.tabelkonter)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bUbah)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Konter"
        Me.Text = "Konter"
        CType(Me.tabelkonter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabelkonter As System.Windows.Forms.DataGridView
    Friend WithEvents bHapus As System.Windows.Forms.Button
    Friend WithEvents bUbah As System.Windows.Forms.Button
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents tNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
