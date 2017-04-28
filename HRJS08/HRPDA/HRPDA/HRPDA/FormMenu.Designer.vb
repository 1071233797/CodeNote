<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMenu
    Inherits System.Windows.Forms.Form

    '窗体重写释放，以清理组件列表。
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
        Me.btn入库 = New System.Windows.Forms.Button
        Me.btn出库 = New System.Windows.Forms.Button
        Me.btn盘点 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn入库
        '
        Me.btn入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn入库.Location = New System.Drawing.Point(32, 46)
        Me.btn入库.Name = "btn入库"
        Me.btn入库.Size = New System.Drawing.Size(160, 43)
        Me.btn入库.TabIndex = 5
        Me.btn入库.Text = "入库"
        '
        'btn出库
        '
        Me.btn出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn出库.Location = New System.Drawing.Point(32, 95)
        Me.btn出库.Name = "btn出库"
        Me.btn出库.Size = New System.Drawing.Size(160, 43)
        Me.btn出库.TabIndex = 6
        Me.btn出库.Text = "出库"
        '
        'btn盘点
        '
        Me.btn盘点.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn盘点.Location = New System.Drawing.Point(32, 144)
        Me.btn盘点.Name = "btn盘点"
        Me.btn盘点.Size = New System.Drawing.Size(160, 43)
        Me.btn盘点.TabIndex = 7
        Me.btn盘点.Text = "盘点"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(32, 193)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(160, 43)
        Me.btn关闭.TabIndex = 8
        Me.btn关闭.Text = "关闭"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(228, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn盘点)
        Me.Controls.Add(Me.btn出库)
        Me.Controls.Add(Me.btn入库)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn入库 As System.Windows.Forms.Button
    Friend WithEvents btn出库 As System.Windows.Forms.Button
    Friend WithEvents btn盘点 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
End Class
