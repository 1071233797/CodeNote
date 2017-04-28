<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F成品入库
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
        Me.lbl库存区域 = New System.Windows.Forms.Label
        Me.txt备注 = New System.Windows.Forms.TextBox
        Me.txt重量 = New System.Windows.Forms.TextBox
        Me.txt数量 = New System.Windows.Forms.TextBox
        Me.txt产品图名 = New System.Windows.Forms.TextBox
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
        Me.SuspendLayout()
        '
        'txt产品图号
        '
        Me.txt产品图号.Location = New System.Drawing.Point(76, 54)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.ReadOnly = True
        Me.txt产品图号.Size = New System.Drawing.Size(143, 23)
        Me.txt产品图号.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.Text = "产品图号"
        '
        'lbl库存区域
        '
        Me.lbl库存区域.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lbl库存区域.Location = New System.Drawing.Point(4, 183)
        Me.lbl库存区域.Name = "lbl库存区域"
        Me.lbl库存区域.Size = New System.Drawing.Size(74, 20)
        Me.lbl库存区域.Text = "库存区域编号"
        '
        'txt备注
        '
        Me.txt备注.Location = New System.Drawing.Point(76, 146)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(143, 23)
        Me.txt备注.TabIndex = 51
        '
        'txt重量
        '
        Me.txt重量.Location = New System.Drawing.Point(76, 123)
        Me.txt重量.Name = "txt重量"
        Me.txt重量.ReadOnly = True
        Me.txt重量.Size = New System.Drawing.Size(143, 23)
        Me.txt重量.TabIndex = 50
        '
        'txt数量
        '
        Me.txt数量.Location = New System.Drawing.Point(76, 100)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.ReadOnly = True
        Me.txt数量.Size = New System.Drawing.Size(143, 23)
        Me.txt数量.TabIndex = 49
        '
        'txt产品图名
        '
        Me.txt产品图名.Location = New System.Drawing.Point(76, 77)
        Me.txt产品图名.Name = "txt产品图名"
        Me.txt产品图名.ReadOnly = True
        Me.txt产品图名.Size = New System.Drawing.Size(143, 23)
        Me.txt产品图名.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.Text = "备注"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.Text = "入库重量"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.Text = "入库数量"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.Text = "产品图名"
        '
        'txt订单编号
        '
        Me.txt订单编号.Location = New System.Drawing.Point(76, 31)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(143, 23)
        Me.txt订单编号.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.Text = "订单编号"
        '
        'txt申请单
        '
        Me.txt申请单.Location = New System.Drawing.Point(76, 8)
        Me.txt申请单.Name = "txt申请单"
        Me.txt申请单.Size = New System.Drawing.Size(143, 23)
        Me.txt申请单.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.Text = "申请单"
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(80, 221)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 45
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(154, 221)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 44
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(5, 221)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 43
        Me.btn清空.Text = "清空"
        '
        'F成品入库
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(226, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt产品图号)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl库存区域)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.txt重量)
        Me.Controls.Add(Me.txt数量)
        Me.Controls.Add(Me.txt产品图名)
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
        Me.Name = "F成品入库"
        Me.Text = "F成品入库"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt产品图号 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl库存区域 As System.Windows.Forms.Label
    Friend WithEvents txt备注 As System.Windows.Forms.TextBox
    Friend WithEvents txt重量 As System.Windows.Forms.TextBox
    Friend WithEvents txt数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt产品图名 As System.Windows.Forms.TextBox
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
End Class
