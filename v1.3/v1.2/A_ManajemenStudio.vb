Imports System.Data.Odbc
Public Class A_ManajemenStudio
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
        Dim sql As String = "insert into studio values('" & KodeStudio.Text & "','" & NamaStudio.Text & "','" &
        Kapasitas.Text & "','" & TLC.Text & "','" & LebarCinema.Text & "','" & TipeProyektor.Text & "','" &
        Tipesound.Text & "','" & SweetBox.Text & "','" & Sensor.Text & "','" & HargaStudio.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Berhasil Menambah Studio Baru", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Gagal Menambah Studio Baru", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub list_studio()
        dgv1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from studio order by KodeStudio asc",
            con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub Hapus()
        Dim a As String = dgv1.Item(0, dgv1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Studio yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus Studio dengan KodeStudio=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from studio where KodeStudio='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Studio", vbInformation, "INFORMASI")
                con.Close()
            End If
        End If
    End Sub


    Private Sub A_ManajemenStudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list_studio()
        NamaStudio.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        list_studio()

        KodeStudio.Text = ""
        NamaStudio.Text = ""
        Kapasitas.Text = ""
        TLC.Text = ""
        LebarCinema.Text = ""
        TipeProyektor.Text = ""
        Tipesound.Text = ""
        SweetBox.Text = ""
        Sensor.Text = ""
        HargaStudio.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dashboard_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hapus()
        list_studio()
    End Sub

    Private Sub Cetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        Dim query As String = "SELECT * FROM studio ORDER BY KodeStudio ASC"
        Try
            Z_CetakStudio.Z_DataLaporan.Clear()
            Z_CetakStudio.Z_DataLaporan.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(Z_CetakStudio.Z_DataLaporan.DataStudio)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Z_CetakStudio.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Z_CetakStudio.ReportViewer1.ZoomPercent = 95
        Z_CetakStudio.ReportViewer1.RefreshReport()
        Z_CetakStudio.Show()
    End Sub
End Class