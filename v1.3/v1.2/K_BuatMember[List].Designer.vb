<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class K_BuatMember_List_
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.jf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.std = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 205)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Member"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jf, Me.std, Me.hri, Me.jm, Me.hr, Me.TP})
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 16)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(636, 186)
        Me.dgv1.TabIndex = 1
        '
        'jf
        '
        Me.jf.HeaderText = "ID"
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
        Me.hri.HeaderText = "Gender"
        Me.hri.Name = "hri"
        '
        'jm
        '
        Me.jm.HeaderText = "Email"
        Me.jm.Name = "jm"
        '
        'hr
        '
        Me.hr.HeaderText = "NoTlp"
        Me.hr.Name = "hr"
        '
        'TP
        '
        Me.TP.HeaderText = "Alamat"
        Me.TP.Name = "TP"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(117, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 43)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 22)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "List Member Bioskop"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 43)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'K_BuatMember_List_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 313)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "K_BuatMember_List_"
        Me.Text = "K_BuatMember_List_"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents jf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents std As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
