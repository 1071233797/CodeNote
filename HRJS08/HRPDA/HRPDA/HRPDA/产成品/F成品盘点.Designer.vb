<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F成品盘点
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
        Me.txt产品图号 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt盘点数量 = New System.Windows.Forms.TextBox
        Me.txt库存数量 = New System.Windows.Forms.TextBox
        Me.txt产品图名 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt订单编号 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn保存 = New System.Windows.Forms.Button
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.btn清空 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt产品图号
        '
        Me.txt产品图号.Location = New System.Drawing.Point(77, 50)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.ReadOnly = True
        Me.txt产品图号.Size = New System.Drawing.Size(143, 23)
        Me.txt产品图号.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.Text = "产品图号"
        '
        'txt盘点数量
        '
        Me.txt盘点数量.Location = New System.Drawing.Point(77, 119)
        Me.txt盘点数量.Name = "txt盘点数量"
        Me.txt盘点数量.Size = New System.Drawing.Size(143, 23)
        Me.txt盘点数量.TabIndex = 66
        '
        'txt库存数量
        '
        Me.txt库存数量.Location = New System.Drawing.Point(77, 96)
        Me.txt库存数量.Name = "txt库存数量"
        Me.txt库存数量.ReadOnly = True
        Me.txt库存数量.Size = New System.Drawing.Size(143, 23)
        Me.txt库存数量.TabIndex = 65
        '
        'txt产品图名
        '
        Me.txt产品图名.Location = New System.Drawing.Point(77, 73)
        Me.txt产品图名.Name = "txt产品图名"
        Me.txt产品图名.ReadOnly = True
        Me.txt产品图名.Size = New System.Drawing.Size(143, 23)
        Me.txt产品图名.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.Text = "盘点数量"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.Text = "库存数量"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.Text = "产品图名"
        '
        'txt订单编号
        '
        Me.txt订单编号.Location = New System.Drawing.Point(77, 27)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(143, 23)
        Me.txt订单编号.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.Text = "订单编号"
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(84, 209)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 62
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(163, 209)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 61
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(5, 209)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 60
        Me.btn清空.Text = "清空"
        '
        'F成品盘点
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(230, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt产品图号)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt盘点数量)
        Me.Controls.Add(Me.txt库存数量)
        Me.Controls.Add(Me.txt产品图名)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt订单编号)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "F成品盘点"
        Me.Text = "成品盘点"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt产品图号 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt盘点数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt库存数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt产品图名 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt订单编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn清空 As System.Windows.Forms.Button
End Class
