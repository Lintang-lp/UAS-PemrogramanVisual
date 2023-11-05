Public Class K_PemesananTiketDetail
    Public Sub New(ByVal DE_D_JudulFilm As String, ByVal DE_D_Studio As String, ByVal DE_D_hari As String, ByVal DE_D_JumlahTiket As String, ByVal DE_D_JamTayang As String, ByVal DE_D_NoKursi As String, ByVal DE_D_TotalPesan As String, ByVal DE_D_Discount As String, ByVal DE_D_TotalBayar As String, ByVal DE_B_Pembayaran As String, ByVal DE_B_Kembalian As String)
        InitializeComponent()
        Me.D_JudulFilm.Text = DE_D_JudulFilm
        Me.D_Studio.Text = DE_D_Studio
        Me.D_hari.Text = DE_D_hari
        Me.D_JumlahTiket.Text = DE_D_JumlahTiket
        Me.D_JamTayang.Text = DE_D_JamTayang
        Me.D_NoKursi.Text = DE_D_NoKursi
        Me.D_TotalPesan.Text = DE_D_TotalPesan
        Me.D_Discount.Text = DE_D_Discount
        Me.D_TotalBayar.Text = DE_D_TotalBayar
        Me.B_Pembayaran.Text = DE_B_Pembayaran
        Me.B_Kembalian.Text = DE_B_Kembalian
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub

    Private Sub K_PemesananTiketDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Time.Text = DateTime.Now.ToString("HH:mm:ss, dd MMMM yyyy")
        D_JudulFilm.Select()
        'D_TotalPesan.Enabled = False
        'D_Discount.Enabled = False
        'D_TotalBayar.Enabled = False
        'B_Pembayaran.Enabled = False
        'B_Kembalian.Enabled = False
    End Sub
End Class