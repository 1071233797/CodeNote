<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewr
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.arvMain = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.SuspendLayout()
        '
        'arvMain
        '
        Me.arvMain.BackColor = System.Drawing.SystemColors.Control
        Me.arvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arvMain.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.arvMain.Location = New System.Drawing.Point(0, 0)
        Me.arvMain.Name = "arvMain"
        Me.arvMain.ReportViewer.CurrentPage = 0
        Me.arvMain.ReportViewer.MultiplePageCols = 3
        Me.arvMain.ReportViewer.MultiplePageRows = 2
        Me.arvMain.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.arvMain.Size = New System.Drawing.Size(733, 443)
        Me.arvMain.TabIndex = 1
        Me.arvMain.TableOfContents.Text = "Contents"
        Me.arvMain.TableOfContents.Width = 240
        Me.arvMain.TabTitleLength = 35
        Me.arvMain.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ReportViewr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 443)
        Me.Controls.Add(Me.arvMain)
        Me.Name = "ReportViewr"
        Me.Text = "ReportViewr"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents arvMain As DataDynamics.ActiveReports.Viewer.Viewer
End Class
