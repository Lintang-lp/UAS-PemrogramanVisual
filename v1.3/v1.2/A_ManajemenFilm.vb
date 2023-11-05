Imports System.Data.Odbc

Public Class A_ManajemenFilm
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
        Dim sql As String = "insert into judul_film values('" & kodefilm.Text & "','" & JudulFilm.Text & "','" &
            JamTayang.Text & "', '" & Hari.Text & "','" & Cb1.Text & "','" & HargaTiket.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        dgv2.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from judul_film order by Nama_Film asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv2.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub tampilStudio()
        koneksi()
        cmd = New OdbcCommand("select NamaStudio from studio order by HargaStudio asc", con)
        dr = cmd.ExecuteReader
        Cb1.Items.Clear()
        Do While dr.Read
            Cb1.Items.Add(dr.Item("NamaStudio"))
        Loop
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        tampilStudio()
        kodefilm.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If kodefilm.Text = "" Or JudulFilm.Text = "" Or JamTayang.Text = "" Or Hari.Text = "" Or Cb1.Text = "-Pilih-" Or HargaTiket.Text = "" Or HargaFilm.Text = "" Or HargaStudio.Text = "" Then
            MsgBox("Silahkan Lengkapi Data", vbInformation, "PERINGATAN")
        Else
            simpan()
            tampil()
            kodefilm.Text = ""
            JudulFilm.Text = ""
            JamTayang.Text = ""
            Hari.Text = ""
            Cb1.Text = "-Pilih-"
            HargaTiket.Text = ""
            HargaFilm.Text = ""
            HargaStudio.Text = ""
        End If
    End Sub

    Private Sub Cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb1.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from studio where NamaStudio='" & Cb1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            HargaStudio.Text = dr.Item("HargaStudio")
        Else
            MsgBox("Studio Film tidak ada")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = dgv2.Item(0, dgv2.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Film yang dihapus belum DIPILIH")
        ElseIf (MessageBox.Show("Anda yakin menghapus data Film=" & a &
           "...?", "Delete", MessageBoxButtons.OKCancel,
           MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
            koneksi()
            cmd = New OdbcCommand("delete from judul_film where ID_FILM='" & a & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus Film '" & a & "'", vbInformation, "INFORMASI")
            con.Close()
            tampil()
        End If
    End Sub

    Private Sub Harga_Obat_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dashboard_Admin.Show()
    End Sub

    Private Sub HargaFilm_TextChanged(sender As Object, e As EventArgs) Handles HargaFilm.TextChanged
        If HargaFilm.Text = "" Or HargaFilm.Text = " " Then
            HargaTiket.Text = ""
        Else
            Dim HR As Double
            HR = 5000
            If Hari.Text = "Sabtu" Or Hari.Text = "Minggu" Then
                Dim HS As Double
                Dim HF As Double
                Dim HT As Double
                HS = HargaStudio.Text
                HF = HargaFilm.Text
                HT = HS + HF + HR
                HargaTiket.Text = HT
            Else
                Dim HS As Double
                Dim HF As Double
                Dim HT As Double
                HS = HargaStudio.Text
                HF = HargaFilm.Text
                HT = HS + HF
                HargaTiket.Text = HT
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dashboard_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Cetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        Dim query As String = "SELECT * FROM judul_film ORDER BY ID_Film ASC"
        Try
            Z_CetakJudulFilm.Z_DataLaporan.Clear()
            Z_CetakJudulFilm.Z_DataLaporan.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(Z_CetakJudulFilm.Z_DataLaporan.DataFilm)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Z_CetakJudulFilm.ReportViewer1.ZoomPercent = 95
        Z_CetakJudulFilm.ReportViewer1.RefreshReport()
        Z_CetakJudulFilm.Show()
    End Sub
End Class