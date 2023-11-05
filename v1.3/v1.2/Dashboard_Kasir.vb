Public Class Dashboard_Kasir

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        K_PemesananTiket.Cb2.Text = ""
        K_PemesananTiket.Studio.Text = ""
        K_PemesananTiket.Hari.Text = ""
        K_PemesananTiket.Jam_Tayang.Text = ""
        K_PemesananTiket.NO_Kursi_1.Text = ""
        K_PemesananTiket.No_Kursi_2.Text = ""
        K_PemesananTiket.Harga.Text = ""
        K_PemesananTiket.Jumlah_Tiket.Text = ""

        'K_PemesananTiket.D_JudulFilm.Text = "Judul Film"
        'K_PemesananTiket.D_Studio.Text = "Studio"
        'K_PemesananTiket.D_hari.Text = "______"
        'K_PemesananTiket.D_JumlahTiket.Text = "______"
        'K_PemesananTiket.D_JamTayang.Text = "______"
        'K_PemesananTiket.D_NoKursi.Text = "______"
        K_PemesananTiket.D_TotalPesan.Text = ""
        K_PemesananTiket.D_Discount.Text = ""
        K_PemesananTiket.B_Pembayaran.Text = ""

        K_PemesananTiket.B_Pembayaran.Text = ""
        K_PemesananTiket.B_Pembayaran.Text = ""
        K_PemesananTiket.B_Kembalian.Text = ""

        K_PemesananTiket.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        K_BuatMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time.Text = DateTime.Now.ToString("HH:mm:ss, dd MMMM yyyy")
    End Sub
End Class