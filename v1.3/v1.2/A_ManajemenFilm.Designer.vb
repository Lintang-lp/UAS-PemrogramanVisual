<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ManajemenFilm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ManajemenFilm))
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comen = New System.Windows.Forms.ListBox()
        Me.Hari = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kodefilm = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Cetak = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cb1 = New System.Windows.Forms.ComboBox()
        Me.JudulFilm = New System.Windows.Forms.TextBox()
        Me.HargaTiket = New System.Windows.Forms.TextBox()
        Me.JamTayang = New System.Windows.Forms.TextBox()
        Me.HargaFilm = New System.Windows.Forms.TextBox()
        Me.HargaStudio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(4, 19)
        Me.dgv2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(919, 232)
        Me.dgv2.TabIndex = 35
        '
        'Column6
        '
        Me.Column6.HeaderText = "kode"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 60
        '
        'Column1
        '
        Me.Column1.HeaderText = "NamaFilm"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jam"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Hari"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Studio"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 90
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Tiket"
        Me.Column5.Name = "Column5"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(591, 27)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 53)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Simpan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(736, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 52)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.comen)
        Me.GroupBox1.Controls.Add(Me.Hari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.kodefilm)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Cetak)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Cb1)
        Me.GroupBox1.Controls.Add(Me.JudulFilm)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.HargaTiket)
        Me.GroupBox1.Controls.Add(Me.JamTayang)
        Me.GroupBox1.Controls.Add(Me.HargaFilm)
        Me.GroupBox1.Controls.Add(Me.HargaStudio)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(927, 318)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manajemen Film"
        '
        'comen
        '
        Me.comen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comen.FormattingEnabled = True
        Me.comen.ItemHeight = 17
        Me.comen.Items.AddRange(New Object() {"NB: Weekend otomatis", "harga + RP 5000"})
        Me.comen.Location = New System.Drawing.Point(431, 256)
        Me.comen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comen.Name = "comen"
        Me.comen.Size = New System.Drawing.Size(200, 38)
        Me.comen.TabIndex = 107
        '
        'Hari
        '
        Me.Hari.FormattingEnabled = True
        Me.Hari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.Hari.Location = New System.Drawing.Point(171, 155)
        Me.Hari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(251, 24)
        Me.Hari.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "KodeFilm"
        '
        'kodefilm
        '
        Me.kodefilm.Location = New System.Drawing.Point(171, 27)
        Me.kodefilm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kodefilm.Name = "kodefilm"
        Me.kodefilm.Size = New System.Drawing.Size(251, 22)
        Me.kodefilm.TabIndex = 42
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(736, 101)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 53)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Harga Tiket"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "HargaFilm"
        '
        'Cetak
        '
        Me.Cetak.Location = New System.Drawing.Point(591, 101)
        Me.Cetak.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(115, 53)
        Me.Cetak.TabIndex = 40
        Me.Cetak.Text = "Cetak"
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jam Tayang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Studio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Judul Film"
        '
        'Cb1
        '
        Me.Cb1.FormattingEnabled = True
        Me.Cb1.Location = New System.Drawing.Point(171, 199)
        Me.Cb1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cb1.Name = "Cb1"
        Me.Cb1.Size = New System.Drawing.Size(251, 24)
        Me.Cb1.TabIndex = 3
        '
        'JudulFilm
        '
        Me.JudulFilm.Location = New System.Drawing.Point(171, 70)
        Me.JudulFilm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JudulFilm.Name = "JudulFilm"
        Me.JudulFilm.Size = New System.Drawing.Size(251, 22)
        Me.JudulFilm.TabIndex = 2
        '
        'HargaTiket
        '
        Me.HargaTiket.Location = New System.Drawing.Point(171, 284)
        Me.HargaTiket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HargaTiket.Name = "HargaTiket"
        Me.HargaTiket.ReadOnly = True
        Me.HargaTiket.Size = New System.Drawing.Size(251, 22)
        Me.HargaTiket.TabIndex = 2
        Me.HargaTiket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'JamTayang
        '
        Me.JamTayang.Location = New System.Drawing.Point(171, 114)
        Me.JamTayang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.JamTayang.Name = "JamTayang"
        Me.JamTayang.Size = New System.Drawing.Size(251, 22)
        Me.JamTayang.TabIndex = 2
        '
        'HargaFilm
        '
        Me.HargaFilm.Location = New System.Drawing.Point(171, 242)
        Me.HargaFilm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HargaFilm.Name = "HargaFilm"
        Me.HargaFilm.Size = New System.Drawing.Size(251, 22)
        Me.HargaFilm.TabIndex = 2
        Me.HargaFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HargaStudio
        '
        Me.HargaStudio.Location = New System.Drawing.Point(431, 201)
        Me.HargaStudio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HargaStudio.Name = "HargaStudio"
        Me.HargaStudio.ReadOnly = True
        Me.HargaStudio.Size = New System.Drawing.Size(112, 22)
        Me.HargaStudio.TabIndex = 2
        Me.HargaStudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(422, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Form Ubah Film"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgv2)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 398)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(927, 255)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Film"
        '
        'A_ManajemenFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 663)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "A_ManajemenFilm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Film"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb1 As System.Windows.Forms.ComboBox
    Friend WithEvents HargaStudio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Cetak As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JudulFilm As System.Windows.Forms.TextBox
    Friend WithEvents JamTayang As System.Windows.Forms.TextBox
    Friend WithEvents HargaFilm As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents kodefilm As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HargaTiket As System.Windows.Forms.TextBox
    Friend WithEvents Hari As System.Windows.Forms.ComboBox
    Friend WithEvents comen As System.Windows.Forms.ListBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
