<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMain
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
        Me.btn清空 = New System.Windows.Forms.Button
        Me.btn登录 = New System.Windows.Forms.Button
        Me.btn配置 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt用户 = New System.Windows.Forms.TextBox
        Me.txt密码 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(27, 143)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(78, 43)
        Me.btn清空.TabIndex = 0
        Me.btn清空.Text = "清空"
        '
        'btn登录
        '
        Me.btn登录.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn登录.Location = New System.Drawing.Point(126, 143)
        Me.btn登录.Name = "btn登录"
        Me.btn登录.Size = New System.Drawing.Size(78, 43)
        Me.btn登录.TabIndex = 1
        Me.btn登录.Text = "登录"
        '
        'btn配置
        '
        Me.btn配置.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn配置.Location = New System.Drawing.Point(27, 221)
        Me.btn配置.Name = "btn配置"
        Me.btn配置.Size = New System.Drawing.Size(78, 43)
        Me.btn配置.TabIndex = 2
        Me.btn配置.Text = "配置"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(126, 221)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(78, 43)
        Me.btn关闭.TabIndex = 3
        Me.btn关闭.Text = "关闭"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.Text = "用户名"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.Text = "密   码"
        '
        'txt用户
        '
        Me.txt用户.Location = New System.Drawing.Point(70, 25)
        Me.txt用户.Name = "txt用户"
        Me.txt用户.Size = New System.Drawing.Size(123, 23)
        Me.txt用户.TabIndex = 7
        '
        'txt密码
        '
        Me.txt密码.Location = New System.Drawing.Point(70, 68)
        Me.txt密码.Name = "txt密码"
        Me.txt密码.Size = New System.Drawing.Size(123, 23)
        Me.txt密码.TabIndex = 8
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt密码)
        Me.Controls.Add(Me.txt用户)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn配置)
        Me.Controls.Add(Me.btn登录)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn清空 As System.Windows.Forms.Button
    Friend WithEvents btn登录 As System.Windows.Forms.Button
    Friend WithEvents btn配置 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt用户 As System.Windows.Forms.TextBox
    Friend WithEvents txt密码 As System.Windows.Forms.TextBox

End Class
