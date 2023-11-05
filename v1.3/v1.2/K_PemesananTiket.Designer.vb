<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_PemesananTiket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(K_PemesananTiket))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb2 = New System.Windows.Forms.ComboBox()
        Me.Cb1 = New System.Windows.Forms.ComboBox()
        Me.Jam_Tayang = New System.Windows.Forms.TextBox()
        Me.Hari = New System.Windows.Forms.TextBox()
        Me.Studio = New System.Windows.Forms.TextBox()
        Me.member_nama = New System.Windows.Forms.TextBox()
        Me.IDPesanan = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Jumlah_Tiket = New System.Windows.Forms.TextBox()
        Me.Harga = New System.Windows.Forms.TextBox()
        Me.No_Kursi_2 = New System.Windows.Forms.ComboBox()
        Me.NO_Kursi_1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.B_Pembayaran = New System.Windows.Forms.TextBox()
        Me.D_TotalPesan = New System.Windows.Forms.TextBox()
        Me.D_Discount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.B_Kembalian = New System.Windows.Forms.TextBox()
        Me.D_TotalBayar = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pemesanan Tiket Bioskop"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb2)
        Me.GroupBox1.Controls.Add(Me.Cb1)
        Me.GroupBox1.Controls.Add(Me.Jam_Tayang)
        Me.GroupBox1.Controls.Add(Me.Hari)
        Me.GroupBox1.Controls.Add(Me.Studio)
        Me.GroupBox1.Controls.Add(Me.member_nama)
        Me.GroupBox1.Controls.Add(Me.IDPesanan)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Jumlah_Tiket)
        Me.GroupBox1.Controls.Add(Me.Harga)
        Me.GroupBox1.Controls.Add(Me.No_Kursi_2)
        Me.GroupBox1.Controls.Add(Me.NO_Kursi_1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 77)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(340, 337)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pemesanan"
        '
        'Cb2
        '
        Me.Cb2.FormattingEnabled = True
        Me.Cb2.Location = New System.Drawing.Point(116, 119)
        Me.Cb2.Name = "Cb2"
        Me.Cb2.Size = New System.Drawing.Size(179, 22)
        Me.Cb2.TabIndex = 25
        '
        'Cb1
        '
        Me.Cb1.FormattingEnabled = True
        Me.Cb1.Location = New System.Drawing.Point(116, 56)
        Me.Cb1.Name = "Cb1"
        Me.Cb1.Size = New System.Drawing.Size(179, 22)
        Me.Cb1.TabIndex = 24
        '
        'Jam_Tayang
        '
        Me.Jam_Tayang.Location = New System.Drawing.Point(116, 212)
        Me.Jam_Tayang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Jam_Tayang.Name = "Jam_Tayang"
        Me.Jam_Tayang.ReadOnly = True
        Me.Jam_Tayang.Size = New System.Drawing.Size(179, 22)
        Me.Jam_Tayang.TabIndex = 23
        '
        'Hari
        '
        Me.Hari.Location = New System.Drawing.Point(116, 180)
        Me.Hari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Hari.Name = "Hari"
        Me.Hari.ReadOnly = True
        Me.Hari.Size = New System.Drawing.Size(179, 22)
        Me.Hari.TabIndex = 23
        '
        'Studio
        '
        Me.Studio.Location = New System.Drawing.Point(116, 149)
        Me.Studio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Studio.Name = "Studio"
        Me.Studio.ReadOnly = True
        Me.Studio.Size = New System.Drawing.Size(179, 22)
        Me.Studio.TabIndex = 22
        '
        'member_nama
        '
        Me.member_nama.Location = New System.Drawing.Point(116, 88)
        Me.member_nama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.member_nama.Name = "member_nama"
        Me.member_nama.ReadOnly = True
        Me.member_nama.Size = New System.Drawing.Size(179, 22)
        Me.member_nama.TabIndex = 21
        '
        'IDPesanan
        '
        Me.IDPesanan.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDPesanan.Location = New System.Drawing.Point(116, 27)
        Me.IDPesanan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IDPesanan.Name = "IDPesanan"
        Me.IDPesanan.ReadOnly = True
        Me.IDPesanan.Size = New System.Drawing.Size(179, 22)
        Me.IDPesanan.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 30)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 14)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "IDPesanan"
        '
        'Jumlah_Tiket
        '
        Me.Jumlah_Tiket.Location = New System.Drawing.Point(116, 307)
        Me.Jumlah_Tiket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Jumlah_Tiket.Name = "Jumlah_Tiket"
        Me.Jumlah_Tiket.Size = New System.Drawing.Size(179, 22)
        Me.Jumlah_Tiket.TabIndex = 17
        '
        'Harga
        '
        Me.Harga.Location = New System.Drawing.Point(116, 276)
        Me.Harga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        Me.Harga.Size = New System.Drawing.Size(179, 22)
        Me.Harga.TabIndex = 15
        '
        'No_Kursi_2
        '
        Me.No_Kursi_2.FormattingEnabled = True
        Me.No_Kursi_2.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.No_Kursi_2.Location = New System.Drawing.Point(212, 245)
        Me.No_Kursi_2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.No_Kursi_2.Name = "No_Kursi_2"
        Me.No_Kursi_2.Size = New System.Drawing.Size(84, 22)
        Me.No_Kursi_2.TabIndex = 14
        '
        'NO_Kursi_1
        '
        Me.NO_Kursi_1.FormattingEnabled = True
        Me.NO_Kursi_1.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.NO_Kursi_1.Location = New System.Drawing.Point(116, 245)
        Me.NO_Kursi_1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NO_Kursi_1.Name = "NO_Kursi_1"
        Me.NO_Kursi_1.Size = New System.Drawing.Size(84, 22)
        Me.NO_Kursi_1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 310)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Jumlah Tiket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 279)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 14)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 247)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "No. Kursi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 184)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 215)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jam Tayang"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 59)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 14)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Member"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Studio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Judul Film"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(19, 418)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "*pembelian lebih dari 5 mendapatkan discount 10%"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(402, 328)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.B_Pembayaran)
        Me.GroupBox3.Controls.Add(Me.D_TotalPesan)
        Me.GroupBox3.Controls.Add(Me.D_Discount)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.B_Kembalian)
        Me.GroupBox3.Controls.Add(Me.D_TotalBayar)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(402, 77)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(340, 229)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bayar"
        '
        'B_Pembayaran
        '
        Me.B_Pembayaran.Location = New System.Drawing.Point(120, 147)
        Me.B_Pembayaran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_Pembayaran.Name = "B_Pembayaran"
        Me.B_Pembayaran.Size = New System.Drawing.Size(179, 22)
        Me.B_Pembayaran.TabIndex = 34
        Me.B_Pembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_TotalPesan
        '
        Me.D_TotalPesan.Location = New System.Drawing.Point(120, 27)
        Me.D_TotalPesan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_TotalPesan.Name = "D_TotalPesan"
        Me.D_TotalPesan.ReadOnly = True
        Me.D_TotalPesan.Size = New System.Drawing.Size(179, 22)
        Me.D_TotalPesan.TabIndex = 33
        Me.D_TotalPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_Discount
        '
        Me.D_Discount.Location = New System.Drawing.Point(120, 62)
        Me.D_Discount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_Discount.Name = "D_Discount"
        Me.D_Discount.ReadOnly = True
        Me.D_Discount.Size = New System.Drawing.Size(179, 22)
        Me.D_Discount.TabIndex = 31
        Me.D_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 14)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Total Harga"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 64)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 14)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Discount"
        '
        'B_Kembalian
        '
        Me.B_Kembalian.Location = New System.Drawing.Point(120, 184)
        Me.B_Kembalian.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.B_Kembalian.Name = "B_Kembalian"
        Me.B_Kembalian.ReadOnly = True
        Me.B_Kembalian.Size = New System.Drawing.Size(179, 22)
        Me.B_Kembalian.TabIndex = 16
        Me.B_Kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'D_TotalBayar
        '
        Me.D_TotalBayar.Location = New System.Drawing.Point(120, 92)
        Me.D_TotalBayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.D_TotalBayar.Name = "D_TotalBayar"
        Me.D_TotalBayar.ReadOnly = True
        Me.D_TotalBayar.Size = New System.Drawing.Size(179, 22)
        Me.D_TotalBayar.TabIndex = 16
        Me.D_TotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 184)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 14)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Kembalian"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 150)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 14)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pembayaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 14)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total Bayar"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(654, 328)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 50)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Bayar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(19, 434)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 13)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "*pembelian lebih dari 10 bonus 1 tiket"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(404, 469)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 449)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "*pembelian menggunakan member discount 5%"
        '
        'K_PemesananTiket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 555)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "K_PemesananTiket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pemesanan Tiket Bioskop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Jumlah_Tiket As System.Windows.Forms.TextBox
    Friend WithEvents Harga As System.Windows.Forms.TextBox
    Friend WithEvents No_Kursi_2 As System.Windows.Forms.ComboBox
    Friend WithEvents NO_Kursi_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents B_Kembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IDPesanan As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Jam_Tayang As System.Windows.Forms.TextBox
    Friend WithEvents Hari As System.Windows.Forms.TextBox
    Friend WithEvents Studio As System.Windows.Forms.TextBox
    Friend WithEvents member_nama As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents D_TotalPesan As System.Windows.Forms.TextBox
    Friend WithEvents D_Discount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents B_Pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents D_TotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
