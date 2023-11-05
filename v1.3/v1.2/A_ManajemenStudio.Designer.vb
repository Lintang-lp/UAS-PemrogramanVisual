<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ManajemenStudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ManajemenStudio))
        Me.TLC = New System.Windows.Forms.ComboBox()
        Me.NamaStudio = New System.Windows.Forms.TextBox()
        Me.LebarCinema = New System.Windows.Forms.TextBox()
        Me.Kapasitas = New System.Windows.Forms.TextBox()
        Me.TipeProyektor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cetak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HargaStudio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KodeStudio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sensor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tipesound = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SweetBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.jf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLC
        '
        Me.TLC.FormattingEnabled = True
        Me.TLC.Items.AddRange(New Object() {"Flat", "Curve"})
        Me.TLC.Location = New System.Drawing.Point(195, 156)
        Me.TLC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TLC.Name = "TLC"
        Me.TLC.Size = New System.Drawing.Size(293, 24)
        Me.TLC.TabIndex = 16
        '
        'NamaStudio
        '
        Me.NamaStudio.Location = New System.Drawing.Point(195, 71)
        Me.NamaStudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NamaStudio.Name = "NamaStudio"
        Me.NamaStudio.Size = New System.Drawing.Size(293, 22)
        Me.NamaStudio.TabIndex = 15
        '
        'LebarCinema
        '
        Me.LebarCinema.Location = New System.Drawing.Point(195, 201)
        Me.LebarCinema.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LebarCinema.Name = "LebarCinema"
        Me.LebarCinema.Size = New System.Drawing.Size(293, 22)
        Me.LebarCinema.TabIndex = 15
        '
        'Kapasitas
        '
        Me.Kapasitas.Location = New System.Drawing.Point(195, 116)
        Me.Kapasitas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Kapasitas.Name = "Kapasitas"
        Me.Kapasitas.Size = New System.Drawing.Size(293, 22)
        Me.Kapasitas.TabIndex = 15
        '
        'TipeProyektor
        '
        Me.TipeProyektor.Location = New System.Drawing.Point(195, 241)
        Me.TipeProyektor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TipeProyektor.Name = "TipeProyektor"
        Me.TipeProyektor.Size = New System.Drawing.Size(293, 22)
        Me.TipeProyektor.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Tipe Proyektor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipe Layar Cinema"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Kapasitas"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(749, 320)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 53)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(604, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 53)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar Cinema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Studio"
        '
        'Cetak
        '
        Me.Cetak.Location = New System.Drawing.Point(604, 394)
        Me.Cetak.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(115, 53)
        Me.Cetak.TabIndex = 15
        Me.Cetak.Text = "Cetak"
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Form Ubah Studio Film"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HargaStudio)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TLC)
        Me.GroupBox1.Controls.Add(Me.NamaStudio)
        Me.GroupBox1.Controls.Add(Me.LebarCinema)
        Me.GroupBox1.Controls.Add(Me.Kapasitas)
        Me.GroupBox1.Controls.Add(Me.KodeStudio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Sensor)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Tipesound)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.SweetBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TipeProyektor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 79)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(868, 404)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manajemen Studio"
        '
        'HargaStudio
        '
        Me.HargaStudio.Location = New System.Drawing.Point(540, 71)
        Me.HargaStudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HargaStudio.Name = "HargaStudio"
        Me.HargaStudio.Size = New System.Drawing.Size(293, 22)
        Me.HargaStudio.TabIndex = 18
        Me.HargaStudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(536, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 18)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Harga"
        '
        'KodeStudio
        '
        Me.KodeStudio.Location = New System.Drawing.Point(195, 31)
        Me.KodeStudio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.KodeStudio.Name = "KodeStudio"
        Me.KodeStudio.Size = New System.Drawing.Size(293, 22)
        Me.KodeStudio.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "KodeStudio"
        '
        'Sensor
        '
        Me.Sensor.Location = New System.Drawing.Point(195, 373)
        Me.Sensor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sensor.Name = "Sensor"
        Me.Sensor.Size = New System.Drawing.Size(293, 22)
        Me.Sensor.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Sensor Realistic"
        '
        'Tipesound
        '
        Me.Tipesound.Location = New System.Drawing.Point(195, 286)
        Me.Tipesound.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tipesound.Name = "Tipesound"
        Me.Tipesound.Size = New System.Drawing.Size(293, 22)
        Me.Tipesound.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "TipeSound"
        '
        'SweetBox
        '
        Me.SweetBox.Location = New System.Drawing.Point(195, 330)
        Me.SweetBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SweetBox.Name = "SweetBox"
        Me.SweetBox.Size = New System.Drawing.Size(293, 22)
        Me.SweetBox.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "SweetBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 489)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(872, 300)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Film"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jf, Me.std, Me.hri, Me.jm, Me.hr, Me.TP, Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(4, 19)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(864, 277)
        Me.dgv1.TabIndex = 0
        '
        'jf
        '
        Me.jf.HeaderText = "K-Std"
        Me.jf.Name = "jf"
        Me.jf.Width = 80
        '
        'std
        '
        Me.std.HeaderText = "Nama"
        Me.std.Name = "std"
        '
        'hri
        '
        Me.hri.HeaderText = "Kapasitas"
        Me.hri.Name = "hri"
        '
        'jm
        '
        Me.jm.HeaderText = "TipeLyr"
        Me.jm.Name = "jm"
        '
        'hr
        '
        Me.hr.HeaderText = "LebarLyr"
        Me.hr.Name = "hr"
        '
        'TP
        '
        Me.TP.HeaderText = "TipeProyektor"
        Me.TP.Name = "TP"
        '
        'Column3
        '
        Me.Column3.HeaderText = "TipeSound"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "SweetBox"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Realistis"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Harga"
        Me.Column4.Name = "Column4"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(749, 394)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 53)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'A_ManajemenStudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 802)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cetak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "A_ManajemenStudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManajemenStudio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TLC As System.Windows.Forms.ComboBox
    Friend WithEvents NamaStudio As System.Windows.Forms.TextBox
    Friend WithEvents LebarCinema As System.Windows.Forms.TextBox
    Friend WithEvents Kapasitas As System.Windows.Forms.TextBox
    Friend WithEvents TipeProyektor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cetak As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KodeStudio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Sensor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SweetBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Tipesound As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents HargaStudio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents jf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents std As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
