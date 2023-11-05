﻿Imports System.Data.Odbc
Public Class A_ListMember
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

    Sub list_member()
        dgv1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from member order by ID_Member asc",
            con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
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
            If (MessageBox.Show("Anda yakin menghapus Member dengan ID=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from member where ID_Member='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus Member " & a & "", vbInformation, "INFORMASI")
                con.Close()
            End If
        End If
    End Sub
    Private Sub A_ListMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list_member()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A_BuatMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hapus()
        list_member()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dashboard_Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Cetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        Dim query As String = "SELECT * FROM member ORDER BY ID_Member ASC"
        Try
            Z_CetakMember.Z_DataLaporan.Clear()
            Z_CetakMember.Z_DataLaporan.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(Z_CetakMember.Z_DataLaporan.DataMember)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Z_CetakMember.ReportViewer1.ZoomPercent = 95
        Z_CetakMember.ReportViewer1.RefreshReport()
        Z_CetakMember.Show()
    End Sub
End Class