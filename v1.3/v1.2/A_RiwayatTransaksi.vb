Imports System.Data.Odbc
Public Class A_RiwayatTransaksi
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

    Sub tampilRiwayatTransaksi()
        Dgv1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from transaksi order by ID_Transaksi asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                Dgv1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9), row(10), row(11), row(12), row(13), row(14))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Private Sub A_RiwayatTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilRiwayatTransaksi()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dashboard_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = "SELECT * FROM transaksi ORDER BY ID_Transaksi ASC"
        Try
            Z_CetakTransaksi.Z_DataLaporan.Clear()
            Z_CetakTransaksi.Z_DataLaporan.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(Z_CetakTransaksi.Z_DataLaporan.transaksi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Z_CetakTransaksi.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Z_CetakTransaksi.ReportViewer1.ZoomPercent = 95
        Z_CetakTransaksi.ReportViewer1.RefreshReport()
        Z_CetakTransaksi.Show()
    End Sub
End Class