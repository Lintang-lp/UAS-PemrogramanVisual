Imports System.Data.Odbc
Public Class A_BuatMember
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
        Dim sql As String = "insert into member values('" & ID_M.Text & "','" & nama.Text &
       "','" & JK.Text & "','" & Email.Text & "','" & NoTlp.Text & "','" & Alamat.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Berhasil Membuat Member", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Gagal Membuat Member", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub ID_Member()
        Try
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM `member` ORDER BY ID_Member DESC", con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Dim lastTransNo As Integer = Integer.Parse(dr("ID_Member").ToString())
                ID_M.Text = (lastTransNo + 1).ToString()
            Else
                ID_M.Text = Date.Now.ToString("MMyyyy") & "001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub A_BuatMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ID_Member()
        nama.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()

        nama.Text = ""
        JK.Text = "-Pilih-"
        Email.Text = ""
        NoTlp.Text = ""
        Alamat.Text = ""
        ID_Member()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        A_ListMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nama.Text = ""
        JK.Text = "-Pilih-"
        Email.Text = ""
        NoTlp.Text = ""
        Alamat.Text = ""
        ID_Member()
    End Sub

End Class