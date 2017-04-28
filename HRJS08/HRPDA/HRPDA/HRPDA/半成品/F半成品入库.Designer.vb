<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F半成品入库
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
        Me.txt数量 = New System.Windows.Forms.TextBox
        Me.txt工序编号 = New System.Windows.Forms.TextBox
        Me.txt分图号 = New System.Windows.Forms.TextBox
        Me.txt主图号 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt订单编号 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt申请单 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn保存 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.btn清空 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt主图名称 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt分图名称 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt工序名称 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txt数量
        '
        Me.txt数量.Location = New System.Drawing.Point(80, 202)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Size = New System.Drawing.Size(143, 23)
        Me.txt数量.TabIndex = 41
        '
        'txt工序编号
        '
        Me.txt工序编号.Location = New System.Drawing.Point(80, 156)
        Me.txt工序编号.Name = "txt工序编号"
        Me.txt工序编号.ReadOnly = True
        Me.txt工序编号.Size = New System.Drawing.Size(143, 23)
        Me.txt工序编号.TabIndex = 40
        '
        'txt分图号
        '
        Me.txt分图号.Location = New System.Drawing.Point(80, 110)
        Me.txt分图号.Name = "txt分图号"
        Me.txt分图号.ReadOnly = True
        Me.txt分图号.Size = New System.Drawing.Size(143, 23)
        Me.txt分图号.TabIndex = 39
        '
        'txt主图号
        '
        Me.txt主图号.Location = New System.Drawing.Point(80, 64)
        Me.txt主图号.Name = "txt主图号"
        Me.txt主图号.ReadOnly = True
        Me.txt主图号.Size = New System.Drawing.Size(143, 23)
        Me.txt主图号.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.Text = "入库数量"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.Text = "工序编号"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.Text = "分图号"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.Text = "主图号"
        '
        'txt订单编号
        '
        Me.txt订单编号.Location = New System.Drawing.Point(80, 41)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(143, 23)
        Me.txt订单编号.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.Text = "订单编号"
        '
        'txt申请单
        '
        Me.txt申请单.Location = New System.Drawing.Point(80, 18)
        Me.txt申请单.Name = "txt申请单"
        Me.txt申请单.Size = New System.Drawing.Size(143, 23)
        Me.txt申请单.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.Text = "申请单"
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(79, 232)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 35
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(156, 232)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 34
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(3, 232)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 33
        Me.btn清空.Text = "清空"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.Text = "主图名称"
        '
        'txt主图名称
        '
        Me.txt主图名称.Location = New System.Drawing.Point(80, 87)
        Me.txt主图名称.Name = "txt主图名称"
        Me.txt主图名称.ReadOnly = True
        Me.txt主图名称.Size = New System.Drawing.Size(143, 23)
        Me.txt主图名称.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.Text = "分图名称"
        '
        'txt分图名称
        '
        Me.txt分图名称.Location = New System.Drawing.Point(80, 133)
        Me.txt分图名称.Name = "txt分图名称"
        Me.txt分图名称.ReadOnly = True
        Me.txt分图名称.Size = New System.Drawing.Size(143, 23)
        Me.txt分图名称.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.Text = "工序名称"
        '
        'txt工序名称
        '
        Me.txt工序名称.Location = New System.Drawing.Point(80, 179)
        Me.txt工序名称.Name = "txt工序名称"
        Me.txt工序名称.ReadOnly = True
        Me.txt工序名称.Size = New System.Drawing.Size(143, 23)
        Me.txt工序名称.TabIndex = 56
        '
        'F半成品入库
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(226, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt工序名称)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt分图名称)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt主图名称)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt数量)
        Me.Controls.Add(Me.txt工序编号)
        Me.Controls.Add(Me.txt分图号)
        Me.Controls.Add(Me.txt主图号)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt订单编号)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt申请单)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "F半成品入库"
        Me.Text = "F半成品入库"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt工序编号 As System.Windows.Forms.TextBox
    Friend WithEvents txt分图号 As System.Windows.Forms.TextBox
    Friend WithEvents txt主图号 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt订单编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt申请单 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn清空 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt主图名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt分图名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt工序名称 As System.Windows.Forms.TextBox
End Class
