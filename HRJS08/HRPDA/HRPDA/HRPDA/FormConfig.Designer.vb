<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormConfig
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn保存 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.lbl连接字符串 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txt数据库名 = New System.Windows.Forms.TextBox
        Me.txt用户 = New System.Windows.Forms.TextBox
        Me.txt密码 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.Text = "服务器IP"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.Text = "数据库名"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.Text = "用户"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.Text = "密码"
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Location = New System.Drawing.Point(40, 230)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 47
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(114, 230)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 46
        Me.btn关闭.Text = "关闭"
        '
        'lbl连接字符串
        '
        Me.lbl连接字符串.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.lbl连接字符串.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl连接字符串.Location = New System.Drawing.Point(4, 155)
        Me.lbl连接字符串.Name = "lbl连接字符串"
        Me.lbl连接字符串.Size = New System.Drawing.Size(223, 61)
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(79, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(143, 23)
        Me.txtIP.TabIndex = 49
        '
        'txt数据库名
        '
        Me.txt数据库名.Location = New System.Drawing.Point(79, 56)
        Me.txt数据库名.Name = "txt数据库名"
        Me.txt数据库名.Size = New System.Drawing.Size(143, 23)
        Me.txt数据库名.TabIndex = 50
        Me.txt数据库名.Text = "HRJS"
        '
        'txt用户
        '
        Me.txt用户.Location = New System.Drawing.Point(79, 86)
        Me.txt用户.Name = "txt用户"
        Me.txt用户.Size = New System.Drawing.Size(143, 23)
        Me.txt用户.TabIndex = 51
        Me.txt用户.Text = "sa"
        '
        'txt密码
        '
        Me.txt密码.Location = New System.Drawing.Point(79, 117)
        Me.txt密码.Name = "txt密码"
        Me.txt密码.Size = New System.Drawing.Size(143, 23)
        Me.txt密码.TabIndex = 52
        Me.txt密码.Text = "sa@1234"
        '
        'FormConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt密码)
        Me.Controls.Add(Me.txt用户)
        Me.Controls.Add(Me.txt数据库名)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lbl连接字符串)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormConfig"
        Me.Text = "FormConfig"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents lbl连接字符串 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txt数据库名 As System.Windows.Forms.TextBox
    Friend WithEvents txt用户 As System.Windows.Forms.TextBox
    Friend WithEvents txt密码 As System.Windows.Forms.TextBox
End Class
