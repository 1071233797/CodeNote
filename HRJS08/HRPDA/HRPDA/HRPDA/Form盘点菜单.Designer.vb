<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form盘点菜单
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn产成品盘点 = New System.Windows.Forms.Button
        Me.btn半成品盘点 = New System.Windows.Forms.Button
        Me.btn原材料盘点 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn产成品盘点
        '
        Me.btn产成品盘点.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn产成品盘点.Location = New System.Drawing.Point(43, 154)
        Me.btn产成品盘点.Name = "btn产成品盘点"
        Me.btn产成品盘点.Size = New System.Drawing.Size(140, 43)
        Me.btn产成品盘点.TabIndex = 18
        Me.btn产成品盘点.Text = "产成品盘点"
        '
        'btn半成品盘点
        '
        Me.btn半成品盘点.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn半成品盘点.Location = New System.Drawing.Point(43, 92)
        Me.btn半成品盘点.Name = "btn半成品盘点"
        Me.btn半成品盘点.Size = New System.Drawing.Size(140, 43)
        Me.btn半成品盘点.TabIndex = 17
        Me.btn半成品盘点.Text = "半成品盘点"
        '
        'btn原材料盘点
        '
        Me.btn原材料盘点.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn原材料盘点.Location = New System.Drawing.Point(43, 30)
        Me.btn原材料盘点.Name = "btn原材料盘点"
        Me.btn原材料盘点.Size = New System.Drawing.Size(140, 43)
        Me.btn原材料盘点.TabIndex = 16
        Me.btn原材料盘点.Text = "原材料盘点"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(43, 216)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(140, 43)
        Me.btn关闭.TabIndex = 21
        Me.btn关闭.Text = "关 闭"
        '
        'Form盘点菜单
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn产成品盘点)
        Me.Controls.Add(Me.btn半成品盘点)
        Me.Controls.Add(Me.btn原材料盘点)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form盘点菜单"
        Me.Text = "Form盘点菜单"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn产成品盘点 As System.Windows.Forms.Button
    Friend WithEvents btn半成品盘点 As System.Windows.Forms.Button
    Friend WithEvents btn原材料盘点 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
End Class
