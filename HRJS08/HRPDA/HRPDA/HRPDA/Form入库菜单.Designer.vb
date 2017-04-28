<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form入库菜单
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
        Me.btn原材料入库 = New System.Windows.Forms.Button
        Me.btn半成品入库 = New System.Windows.Forms.Button
        Me.btn产成品入库 = New System.Windows.Forms.Button
        Me.btn外协品入库 = New System.Windows.Forms.Button
        Me.btn返回品入库 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn原材料入库
        '
        Me.btn原材料入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn原材料入库.Location = New System.Drawing.Point(46, 33)
        Me.btn原材料入库.Name = "btn原材料入库"
        Me.btn原材料入库.Size = New System.Drawing.Size(140, 30)
        Me.btn原材料入库.TabIndex = 6
        Me.btn原材料入库.Text = "原材料入库"
        '
        'btn半成品入库
        '
        Me.btn半成品入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn半成品入库.Location = New System.Drawing.Point(46, 74)
        Me.btn半成品入库.Name = "btn半成品入库"
        Me.btn半成品入库.Size = New System.Drawing.Size(140, 30)
        Me.btn半成品入库.TabIndex = 7
        Me.btn半成品入库.Text = "半成品入库"
        '
        'btn产成品入库
        '
        Me.btn产成品入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn产成品入库.Location = New System.Drawing.Point(46, 156)
        Me.btn产成品入库.Name = "btn产成品入库"
        Me.btn产成品入库.Size = New System.Drawing.Size(140, 30)
        Me.btn产成品入库.TabIndex = 8
        Me.btn产成品入库.Text = "产成品入库"
        '
        'btn外协品入库
        '
        Me.btn外协品入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn外协品入库.Location = New System.Drawing.Point(46, 115)
        Me.btn外协品入库.Name = "btn外协品入库"
        Me.btn外协品入库.Size = New System.Drawing.Size(140, 30)
        Me.btn外协品入库.TabIndex = 9
        Me.btn外协品入库.Text = "外协品入库"
        Me.btn外协品入库.Visible = False
        '
        'btn返回品入库
        '
        Me.btn返回品入库.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn返回品入库.Location = New System.Drawing.Point(46, 197)
        Me.btn返回品入库.Name = "btn返回品入库"
        Me.btn返回品入库.Size = New System.Drawing.Size(140, 30)
        Me.btn返回品入库.TabIndex = 10
        Me.btn返回品入库.Text = "返回品入库"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(46, 238)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(140, 30)
        Me.btn关闭.TabIndex = 17
        Me.btn关闭.Text = "关 闭"
        '
        'Form入库菜单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn返回品入库)
        Me.Controls.Add(Me.btn外协品入库)
        Me.Controls.Add(Me.btn产成品入库)
        Me.Controls.Add(Me.btn半成品入库)
        Me.Controls.Add(Me.btn原材料入库)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form入库菜单"
        Me.Text = "Form入库菜单"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn原材料入库 As System.Windows.Forms.Button
    Friend WithEvents btn半成品入库 As System.Windows.Forms.Button
    Friend WithEvents btn产成品入库 As System.Windows.Forms.Button
    Friend WithEvents btn外协品入库 As System.Windows.Forms.Button
    Friend WithEvents btn返回品入库 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
End Class
