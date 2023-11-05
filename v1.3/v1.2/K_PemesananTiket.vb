Imports System.Data.Odbc
Public Class K_PemesananTiket
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=vb_uas"
        con.Open()
    End Sub

    Sub simpan()
        koneksi()
        'Kursi
        Dim kursi As String
        kursi = NO_Kursi_1.Text + No_Kursi_2.Text
        'Bonus Pembelian lebih dari 10
        Dim Bon10 As Double
        If Jumlah_Tiket.Text > 10 Then
            Bon10 = Jumlah_Tiket.Text + 1
            Jumlah_Tiket.Text = Bon10
        Else
            Jumlah_Tiket.Text = Jumlah_Tiket.Text
        End If
        'Input Ke Database
        Dim sql As String = "insert into transaksi values('" & IDPesanan.Text & "','" & Cb1.Text & "','" &
            member_nama.Text & "', '" & Cb2.Text & "','" & Studio.Text & "','" & Hari.Text & "','" &
            Jam_Tayang.Text & "','" & kursi & "','" & Harga.Text & "','" & Jumlah_Tiket.Text & "','" &
            D_TotalPesan.Text & "','" & D_Discount.Text & "','" & D_TotalBayar.Text & "','" &
            B_Pembayaran.Text & "','" & B_Kembalian.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub ID_Pesanan()
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM `transaksi` ORDER BY ID_Transaksi DESC", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Dim lastTransNo As Integer = Integer.Parse(dr("ID_Transaksi").ToString())
                IDPesanan.Text = (lastTransNo + 1).ToString()
            Else
                IDPesanan.Text = "10001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub tampilmember()
        koneksi()
        cmd = New OdbcCommand("select ID_Member from member order by ID_Member asc", con)
        dr = cmd.ExecuteReader
        Cb1.Items.Clear()
        Do While dr.Read
            Cb1.Items.Add(dr.Item("ID_Member"))
        Loop
    End Sub

    Sub tampilfilm()
        koneksi()
        cmd = New OdbcCommand("select Nama_Film from judul_film order by Nama_Film asc", con)
        dr = cmd.ExecuteReader
        Cb2.Items.Clear()
        Do While dr.Read
            Cb2.Items.Add(dr.Item("Nama_Film"))
        Loop
    End Sub

    Sub DetailPesanan()
        Dim DE_D_JudulFilm, DE_D_Studio, DE_D_hari, DE_D_JumlahTiket, DE_D_JamTayang, DE_D_NoKursi As String
        Dim DE_D_TotalPesan, DE_D_Discount, DE_D_TotalBayar, DE_B_Pembayaran, DE_B_Kembalian As String

        DE_D_JudulFilm = Cb2.Text
        DE_D_Studio = Studio.Text
        DE_D_hari = Hari.Text
        DE_D_JumlahTiket = Jumlah_Tiket.Text
        DE_D_JamTayang = Jam_Tayang.Text
        DE_D_NoKursi = NO_Kursi_1.Text + No_Kursi_2.Text
        DE_D_TotalPesan = D_TotalPesan.Text
        DE_D_Discount = D_Discount.Text
        DE_D_TotalBayar = D_TotalBayar.Text
        DE_B_Pembayaran = B_Pembayaran.Text
        DE_B_Kembalian = B_Kembalian.Text
        Dim frm As New K_PemesananTiketDetail(DE_D_JudulFilm, DE_D_Studio, DE_D_hari, DE_D_JumlahTiket, DE_D_JamTayang, DE_D_NoKursi, DE_D_TotalPesan, DE_D_Discount, DE_D_TotalBayar, DE_B_Pembayaran, DE_B_Kembalian)
        frm.Show()
    End Sub


    Private Sub K_PemesananTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID_Pesanan()
        tampilmember()
        tampilfilm()
        Cb1.Select()
    End Sub

    Private Sub Cb1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cb1.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from member where ID_Member='" & Cb1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            member_nama.Text = dr.Item("NamaPengguna")
        Else
            MsgBox("Tidakada Data Member")
        End If

    End Sub

    Private Sub Cb2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cb2.SelectedIndexChanged
        cmd = New OdbcCommand("select * from judul_film where Nama_Film='" & Cb2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Studio.Text = dr.Item("Studio")
            Hari.Text = dr.Item("Hari")
            Jam_Tayang.Text = dr.Item("Jam_Tayang")
            Harga.Text = dr.Item("Harga_Tiket")
        Else
            MsgBox("Kode obat tidak ada")
        End If
    End Sub

    Private Sub Jumlah_Tiket_TextChanged(sender As Object, e As EventArgs) Handles Jumlah_Tiket.TextChanged
        If Jumlah_Tiket.Text = "" Or Jumlah_Tiket.Text = " " Then
            D_TotalPesan.Text = ""
            D_Discount.Text = ""
            D_TotalBayar.Text = ""
        Else
            Dim HT As Double
            Dim JT As Double
            Dim TP As Double
            Dim TB As Double

            HT = Harga.Text
            JT = Jumlah_Tiket.Text
            TP = HT * JT
            D_TotalPesan.Text = TP


            Dim DisconMember As Double
            DisconMember = 0.05
            Dim Discon_5 As Double
            Discon_5 = 0.1
            Dim POT_10 As Double

            'Diskon Member
            If Cb1.Text = "" Or Cb1.Text = " " Then
                'Diskon non Member Pembelian lebih dari 5
                If Jumlah_Tiket.Text > 5 Then
                    D_TotalBayar.Text = TP - (TP * Discon_5)
                    D_Discount.Text = TP - D_TotalBayar.Text
                Else
                    D_Discount.Text = "0"
                    D_TotalBayar.Text = TP
                End If
            Else
                'Diskon Member pembelian lebih dari 5
                TB = TP - (TP * DisconMember)
                If Jumlah_Tiket.Text > 5 Then
                    D_TotalBayar.Text = TB - (TB * Discon_5)
                    D_Discount.Text = TP - D_TotalBayar.Text
                Else
                    D_TotalBayar.Text = TB
                    D_Discount.Text = TP - D_TotalBayar.Text
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TBayar As Double
        TBayar = D_TotalBayar.Text

        If Cb2.Text = "" Or Cb2.Text = " " Then
            MsgBox("Silahkan Lengkapi Data", vbInformation, "PERINGATAN")
        Else
            If B_Pembayaran.Text = "" Or B_Pembayaran.Text = " " Then
                MsgBox("Silahkan Masukkan Nilai pembayaran yang valid", vbInformation, "PERINGATAN")
            ElseIf B_Pembayaran.Text < TBayar Then
                MsgBox("Nominal Yang ada Masukkan Kurang", vbInformation, "PERINGATAN")
            Else
                B_Kembalian.Text = B_Pembayaran.Text - D_TotalBayar.Text
                simpan()
                DetailPesanan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IDPesanan.Text = ""
        Cb1.Text = ""
        member_nama.Text = ""
        Cb2.Text = ""
        Studio.Text = ""
        Hari.Text = ""
        Jam_Tayang.Text = ""
        NO_Kursi_1.Text = ""
        No_Kursi_2.Text = ""
        Harga.Text = ""
        Jumlah_Tiket.Text = ""
        D_TotalPesan.Text = ""
        D_Discount.Text = ""
        D_TotalBayar.Text = ""
        B_Pembayaran.Text = ""
        B_Kembalian.Text = ""

        Cb1.Select()
        ID_Pesanan()
    End Sub

    Private Sub D_TotalPesan_TextChanged(sender As Object, e As EventArgs)
        'D_JudulFilm.Text = Cb2.Text
        'D_Studio.Text = Studio.Text
        'D_hari.Text = Hari.Text
        'D_JumlahTiket.Text = Jumlah_Tiket.Text
        'D_JamTayang.Text = Jam_Tayang.Text
        'D_NoKursi.Text = NO_Kursi_1.Text + No_Kursi_2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_Kasir.Show()
        Me.Hide()
    End Sub

    Private Sub member_nama_TextChanged(sender As Object, e As EventArgs) Handles member_nama.TextChanged
        If Cb1.Text = "" Or Cb1.Text = " " Then
            member_nama.Text = ""
        End If
    End Sub
End Class