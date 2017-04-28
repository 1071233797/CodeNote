<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F半成品盘点
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
        Me.btn保存 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.btn清空 = New System.Windows.Forms.Button
        Me.txt工序名称 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt分图名称 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt主图名称 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt在库数量 = New System.Windows.Forms.TextBox
        Me.txt工序编号 = New System.Windows.Forms.TextBox
        Me.txt分图号 = New System.Windows.Forms.TextBox
        Me.txt主图号 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt订单编号 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt盘点数量 = New System.Windows.Forms.TextBox
        Me.lbl上级图号 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(80, 244)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 14
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(149, 244)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 13
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(10, 244)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 12
        Me.btn清空.Text = "清空"
        '
        'txt工序名称
        '
        Me.txt工序名称.Location = New System.Drawing.Point(78, 166)
        Me.txt工序名称.Name = "txt工序名称"
        Me.txt工序名称.ReadOnly = True
        Me.txt工序名称.Size = New System.Drawing.Size(143, 23)
        Me.txt工序名称.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(1, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.Text = "工序名称"
        '
        'txt分图名称
        '
        Me.txt分图名称.Location = New System.Drawing.Point(78, 120)
        Me.txt分图名称.Name = "txt分图名称"
        Me.txt分图名称.ReadOnly = True
        Me.txt分图名称.Size = New System.Drawing.Size(143, 23)
        Me.txt分图名称.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.Text = "分图名称"
        '
        'txt主图名称
        '
        Me.txt主图名称.Location = New System.Drawing.Point(78, 74)
        Me.txt主图名称.Name = "txt主图名称"
        Me.txt主图名称.ReadOnly = True
        Me.txt主图名称.Size = New System.Drawing.Size(143, 23)
        Me.txt主图名称.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.Text = "主图名称"
        '
        'txt在库数量
        '
        Me.txt在库数量.Location = New System.Drawing.Point(78, 189)
        Me.txt在库数量.Name = "txt在库数量"
        Me.txt在库数量.Size = New System.Drawing.Size(143, 23)
        Me.txt在库数量.TabIndex = 71
        '
        'txt工序编号
        '
        Me.txt工序编号.Location = New System.Drawing.Point(78, 143)
        Me.txt工序编号.Name = "txt工序编号"
        Me.txt工序编号.ReadOnly = True
        Me.txt工序编号.Size = New System.Drawing.Size(143, 23)
        Me.txt工序编号.TabIndex = 70
        '
        'txt分图号
        '
        Me.txt分图号.Location = New System.Drawing.Point(78, 97)
        Me.txt分图号.Name = "txt分图号"
        Me.txt分图号.ReadOnly = True
        Me.txt分图号.Size = New System.Drawing.Size(143, 23)
        Me.txt分图号.TabIndex = 69
        '
        'txt主图号
        '
        Me.txt主图号.Location = New System.Drawing.Point(78, 51)
        Me.txt主图号.Name = "txt主图号"
        Me.txt主图号.ReadOnly = True
        Me.txt主图号.Size = New System.Drawing.Size(143, 23)
        Me.txt主图号.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.Text = "在库数量"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.Text = "工序编号"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(1, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.Text = "分图号"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(1, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.Text = "主图号"
        '
        'txt订单编号
        '
        Me.txt订单编号.Location = New System.Drawing.Point(78, 28)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(143, 23)
        Me.txt订单编号.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(1, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.Text = "订单编号"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.Text = "盘点数量"
        '
        'txt盘点数量
        '
        Me.txt盘点数量.Location = New System.Drawing.Point(78, 212)
        Me.txt盘点数量.Name = "txt盘点数量"
        Me.txt盘点数量.Size = New System.Drawing.Size(143, 23)
        Me.txt盘点数量.TabIndex = 85
        '
        'lbl上级图号
        '
        Me.lbl上级图号.Location = New System.Drawing.Point(3, 0)
        Me.lbl上级图号.Name = "lbl上级图号"
        Me.lbl上级图号.Size = New System.Drawing.Size(74, 20)
        Me.lbl上级图号.Text = "上级图号"
        Me.lbl上级图号.Visible = False
        '
        'F半成品盘点
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl上级图号)
        Me.Controls.Add(Me.txt盘点数量)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt工序名称)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt分图名称)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt主图名称)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt在库数量)
        Me.Controls.Add(Me.txt工序编号)
        Me.Controls.Add(Me.txt分图号)
        Me.Controls.Add(Me.txt主图号)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt订单编号)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "F半成品盘点"
        Me.Text = "F半成品盘点"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn清空 As System.Windows.Forms.Button
    Friend WithEvents txt工序名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt分图名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt主图名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt在库数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt工序编号 As System.Windows.Forms.TextBox
    Friend WithEvents txt分图号 As System.Windows.Forms.TextBox
    Friend WithEvents txt主图号 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt订单编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt盘点数量 As System.Windows.Forms.TextBox
    Friend WithEvents lbl上级图号 As System.Windows.Forms.Label
End Class
