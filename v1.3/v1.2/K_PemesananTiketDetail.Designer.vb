<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_PemesananTiketDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_PemesananTiketDetail))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.B_Kembalian = New System.Windows.Forms.TextBox()
        Me.B_Pembayaran = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.D_NoKursi = New System.Windows.Forms.Label()
        Me.D_JamTayang = New System.Windows.Forms.Label()
        Me.D_JumlahTiket = New System.Windows.Forms.Label()
        Me.D_hari = New System.Windows.Forms.Label()
        Me.D_Studio = New System.Windows.Forms.Label()
        Me.D_TotalPesan = New System.Windows.Forms.TextBox()
        Me.D_TotalBayar = New System.Windows.Forms.TextBox()
        Me.D_Discount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.D_JudulFilm = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Time = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Time)
        Me.GroupBox3.Controls.Add(Me.B_Kembalian)
        Me.GroupBox3.Controls.Add(Me.B_Pembayaran)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.D_TotalBayar)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 382)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(453, 176)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bayar"
        '
        'B_Kembalian
        '
        Me.B_Kembalian.Location = New System.Drawing.Point(160, 113)
        Me.B_Kembalian.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_Kembalian.Name = "B_Kembalian"
        Me.B_Kembalian.ReadOnly = True
        Me.B_Kembalian.Size = New System.Drawing.Size(193, 26)
        Me.B_Kembalian.TabIndex = 16
        Me.B_Kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'B_Pembayaran
        '
        Me.B_Pembayaran.Location = New System.Drawing.Point(160, 70)
        Me.B_Pembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_Pembayaran.Name = "B_Pembayaran"
        Me.B_Pembayaran.ReadOnly = True
        Me.B_Pembayaran.Size = New System.Drawing.Size(193, 26)
        Me.B_Pembayaran.TabIndex = 16
        Me.B_Pembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(32, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Kembalian"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 18)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pembayaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total Bayar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.D_NoKursi)
        Me.GroupBox2.Controls.Add(Me.D_JamTayang)
        Me.GroupBox2.Controls.Add(Me.D_JumlahTiket)
        Me.GroupBox2.Controls.Add(Me.D_hari)
        Me.GroupBox2.Controls.Add(Me.D_Studio)
        Me.GroupBox2.Controls.Add(Me.D_TotalPesan)
        Me.GroupBox2.Controls.Add(Me.D_Discount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.D_JudulFilm)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(100, 167)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(499, 576)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(141, 207)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 18)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(141, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(12, 18)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(141, 247)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 17)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(141, 128)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(12, 18)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = ":"
        '
        'D_NoKursi
        '
        Me.D_NoKursi.AutoSize = True
        Me.D_NoKursi.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_NoKursi.Location = New System.Drawing.Point(198, 196)
        Me.D_NoKursi.Name = "D_NoKursi"
        Me.D_NoKursi.Size = New System.Drawing.Size(73, 29)
        Me.D_NoKursi.TabIndex = 23
        Me.D_NoKursi.Text = "______"
        '
        'D_JamTayang
        '
        Me.D_JamTayang.AutoSize = True
        Me.D_JamTayang.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_JamTayang.Location = New System.Drawing.Point(198, 160)
        Me.D_JamTayang.Name = "D_JamTayang"
        Me.D_JamTayang.Size = New System.Drawing.Size(73, 29)
        Me.D_JamTayang.TabIndex = 22
        Me.D_JamTayang.Text = "______"
        '
        'D_JumlahTiket
        '
        Me.D_JumlahTiket.AutoSize = True
        Me.D_JumlahTiket.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_JumlahTiket.Location = New System.Drawing.Point(198, 236)
        Me.D_JumlahTiket.Name = "D_JumlahTiket"
        Me.D_JumlahTiket.Size = New System.Drawing.Size(73, 29)
        Me.D_JumlahTiket.TabIndex = 21
        Me.D_JumlahTiket.Text = "______"
        '
        'D_hari
        '
        Me.D_hari.AutoSize = True
        Me.D_hari.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_hari.Location = New System.Drawing.Point(198, 117)
        Me.D_hari.Name = "D_hari"
        Me.D_hari.Size = New System.Drawing.Size(73, 29)
        Me.D_hari.TabIndex = 20
        Me.D_hari.Text = "______"
        '
        'D_Studio
        '
        Me.D_Studio.AutoSize = True
        Me.D_Studio.Font = New System.Drawing.Font("Bahnschrift", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Studio.Location = New System.Drawing.Point(28, 73)
        Me.D_Studio.Name = "D_Studio"
        Me.D_Studio.Size = New System.Drawing.Size(115, 41)
        Me.D_Studio.TabIndex = 18
        Me.D_Studio.Text = "Studio"
        '
        'D_TotalPesan
        '
        Me.D_TotalPesan.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.D_TotalPesan.Location = New System.Drawing.Point(224, 291)
        Me.D_TotalPesan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.D_TotalPesan.Name = "D_TotalPesan"
        Me.D_TotalPesan.ReadOnly = True
        Me.D_TotalPesan.Size = New System.Drawing.Size(193, 26)
        Me.D_TotalPesan.TabIndex = 17
        Me.D_TotalPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_TotalBayar
        '
        Me.D_TotalBayar.Location = New System.Drawing.Point(160, 28)
        Me.D_TotalBayar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.D_TotalBayar.Name = "D_TotalBayar"
        Me.D_TotalBayar.ReadOnly = True
        Me.D_TotalBayar.Size = New System.Drawing.Size(193, 26)
        Me.D_TotalBayar.TabIndex = 16
        Me.D_TotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_Discount
        '
        Me.D_Discount.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.D_Discount.Location = New System.Drawing.Point(224, 334)
        Me.D_Discount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.D_Discount.Name = "D_Discount"
        Me.D_Discount.ReadOnly = True
        Me.D_Discount.Size = New System.Drawing.Size(193, 26)
        Me.D_Discount.TabIndex = 15
        Me.D_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(96, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total Harga"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Jumlah Tiket"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(96, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 18)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Seat/Row"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 18)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Time"
        '
        'D_JudulFilm
        '
        Me.D_JudulFilm.AutoSize = True
        Me.D_JudulFilm.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_JudulFilm.Location = New System.Drawing.Point(23, 20)
        Me.D_JudulFilm.Name = "D_JudulFilm"
        Me.D_JudulFilm.Size = New System.Drawing.Size(230, 53)
        Me.D_JudulFilm.TabIndex = 1
        Me.D_JudulFilm.Text = "Judul Film"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.v1._3.My.Resources.Resources.logo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(255, 38)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(197, 113)
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Bahnschrift", 8.0!)
        Me.Time.Location = New System.Drawing.Point(157, 145)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(39, 17)
        Me.Time.TabIndex = 28
        Me.Time.Text = "Time"
        '
        'K_PemesananTiketDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 793)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "K_PemesananTiketDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Pemesanan"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents B_Kembalian As System.Windows.Forms.TextBox
    Friend WithEvents B_Pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents D_NoKursi As System.Windows.Forms.Label
    Friend WithEvents D_JamTayang As System.Windows.Forms.Label
    Friend WithEvents D_JumlahTiket As System.Windows.Forms.Label
    Friend WithEvents D_hari As System.Windows.Forms.Label
    Friend WithEvents D_Studio As System.Windows.Forms.Label
    Friend WithEvents D_TotalPesan As System.Windows.Forms.TextBox
    Friend WithEvents D_TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents D_Discount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents D_JudulFilm As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Time As System.Windows.Forms.Label
End Class
