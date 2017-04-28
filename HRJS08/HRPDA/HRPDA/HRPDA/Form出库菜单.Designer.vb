<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form出库菜单
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
        Me.btn外协品出库 = New System.Windows.Forms.Button
        Me.btn产成品出库 = New System.Windows.Forms.Button
        Me.btn半成品出库 = New System.Windows.Forms.Button
        Me.btn原材料出库 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.btn返回品出库 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn外协品出库
        '
        Me.btn外协品出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn外协品出库.Location = New System.Drawing.Point(46, 116)
        Me.btn外协品出库.Name = "btn外协品出库"
        Me.btn外协品出库.Size = New System.Drawing.Size(140, 30)
        Me.btn外协品出库.TabIndex = 14
        Me.btn外协品出库.Text = "外协品出库"
        Me.btn外协品出库.Visible = False
        '
        'btn产成品出库
        '
        Me.btn产成品出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn产成品出库.Location = New System.Drawing.Point(46, 157)
        Me.btn产成品出库.Name = "btn产成品出库"
        Me.btn产成品出库.Size = New System.Drawing.Size(140, 30)
        Me.btn产成品出库.TabIndex = 13
        Me.btn产成品出库.Text = "产成品出库"
        '
        'btn半成品出库
        '
        Me.btn半成品出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn半成品出库.Location = New System.Drawing.Point(46, 75)
        Me.btn半成品出库.Name = "btn半成品出库"
        Me.btn半成品出库.Size = New System.Drawing.Size(140, 30)
        Me.btn半成品出库.TabIndex = 12
        Me.btn半成品出库.Text = "半成品出库"
        '
        'btn原材料出库
        '
        Me.btn原材料出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn原材料出库.Location = New System.Drawing.Point(46, 34)
        Me.btn原材料出库.Name = "btn原材料出库"
        Me.btn原材料出库.Size = New System.Drawing.Size(140, 30)
        Me.btn原材料出库.TabIndex = 11
        Me.btn原材料出库.Text = "原材料出库"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(46, 239)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(140, 30)
        Me.btn关闭.TabIndex = 16
        Me.btn关闭.Text = "关 闭"
        '
        'btn返回品出库
        '
        Me.btn返回品出库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn返回品出库.Location = New System.Drawing.Point(46, 198)
        Me.btn返回品出库.Name = "btn返回品出库"
        Me.btn返回品出库.Size = New System.Drawing.Size(140, 30)
        Me.btn返回品出库.TabIndex = 15
        Me.btn返回品出库.Text = "返回品出库"
        Me.btn返回品出库.Visible = False
        '
        'Form出库菜单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn返回品出库)
        Me.Controls.Add(Me.btn外协品出库)
        Me.Controls.Add(Me.btn产成品出库)
        Me.Controls.Add(Me.btn半成品出库)
        Me.Controls.Add(Me.btn原材料出库)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form出库菜单"
        Me.Text = "Form出库菜单"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn外协品出库 As System.Windows.Forms.Button
    Friend WithEvents btn产成品出库 As System.Windows.Forms.Button
    Friend WithEvents btn半成品出库 As System.Windows.Forms.Button
    Friend WithEvents btn原材料出库 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn返回品出库 As System.Windows.Forms.Button
End Class
