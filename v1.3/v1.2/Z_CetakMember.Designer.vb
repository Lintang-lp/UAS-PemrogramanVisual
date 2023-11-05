<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Z_CetakMember
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Z_DataLaporan = New v1._3.Z_DataLaporan()
        Me.DataMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Z_DataLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataLaporanMember"
        ReportDataSource1.Value = Me.DataMemberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "v1._3.Z_CetakMember.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(699, 325)
        Me.ReportViewer1.TabIndex = 0
        '
        'Z_DataLaporan
        '
        Me.Z_DataLaporan.DataSetName = "Z_DataLaporan"
        Me.Z_DataLaporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataMemberBindingSource
        '
        Me.DataMemberBindingSource.DataMember = "DataMember"
        Me.DataMemberBindingSource.DataSource = Me.Z_DataLaporan
        '
        'Z_CetakMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 325)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Z_CetakMember"
        Me.Text = "Z_CetakMember"
        CType(Me.Z_DataLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataMemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Z_DataLaporan As v1._3.Z_DataLaporan
End Class
