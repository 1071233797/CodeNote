<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F原材料入库
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
        Me.btn关闭 = New System.Windows.Forms.Button
        Me.btn清空 = New System.Windows.Forms.Button
        Me.btn保存 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt申请单 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt材料编号 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt批次 = New System.Windows.Forms.TextBox
        Me.txt数量 = New System.Windows.Forms.TextBox
        Me.txt重量 = New System.Windows.Forms.TextBox
        Me.txt备注 = New System.Windows.Forms.TextBox
        Me.lbl库存区域 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt材料名称 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(157, 230)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 7
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(5, 230)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 6
        Me.btn清空.Text = "清空"
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(81, 230)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 8
        Me.btn保存.Text = "保存"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.Text = "申请单"
        '
        'txt申请单
        '
        Me.txt申请单.Location = New System.Drawing.Point(77, 20)
        Me.txt申请单.Name = "txt申请单"
        Me.txt申请单.Size = New System.Drawing.Size(143, 23)
        Me.txt申请单.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.Text = "材料编号"
        '
        'txt材料编号
        '
        Me.txt材料编号.Location = New System.Drawing.Point(77, 43)
        Me.txt材料编号.Name = "txt材料编号"
        Me.txt材料编号.Size = New System.Drawing.Size(143, 23)
        Me.txt材料编号.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.Text = "材料批次"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.Text = "入库数量"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.Text = "入库重量"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.Text = "备注"
        '
        'txt批次
        '
        Me.txt批次.Location = New System.Drawing.Point(77, 89)
        Me.txt批次.Name = "txt批次"
        Me.txt批次.ReadOnly = True
        Me.txt批次.Size = New System.Drawing.Size(143, 23)
        Me.txt批次.TabIndex = 22
        '
        'txt数量
        '
        Me.txt数量.Location = New System.Drawing.Point(77, 112)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.ReadOnly = True
        Me.txt数量.Size = New System.Drawing.Size(143, 23)
        Me.txt数量.TabIndex = 23
        '
        'txt重量
        '
        Me.txt重量.Location = New System.Drawing.Point(77, 135)
        Me.txt重量.Name = "txt重量"
        Me.txt重量.ReadOnly = True
        Me.txt重量.Size = New System.Drawing.Size(143, 23)
        Me.txt重量.TabIndex = 24
        '
        'txt备注
        '
        Me.txt备注.Location = New System.Drawing.Point(77, 158)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(143, 23)
        Me.txt备注.TabIndex = 25
        '
        'lbl库存区域
        '
        Me.lbl库存区域.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lbl库存区域.Location = New System.Drawing.Point(5, 207)
        Me.lbl库存区域.Name = "lbl库存区域"
        Me.lbl库存区域.Size = New System.Drawing.Size(74, 20)
        Me.lbl库存区域.Text = "库存区域编号"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.Text = "材料名称"
        '
        'txt材料名称
        '
        Me.txt材料名称.Location = New System.Drawing.Point(77, 66)
        Me.txt材料名称.Name = "txt材料名称"
        Me.txt材料名称.ReadOnly = True
        Me.txt材料名称.Size = New System.Drawing.Size(143, 23)
        Me.txt材料名称.TabIndex = 34
        '
        'F原材料入库
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(228, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt材料名称)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl库存区域)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.txt重量)
        Me.Controls.Add(Me.txt数量)
        Me.Controls.Add(Me.txt批次)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt材料编号)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt申请单)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "F原材料入库"
        Me.Text = "F原材料入库"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn清空 As System.Windows.Forms.Button
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt申请单 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt材料编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt批次 As System.Windows.Forms.TextBox
    Friend WithEvents txt数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt重量 As System.Windows.Forms.TextBox
    Friend WithEvents txt备注 As System.Windows.Forms.TextBox
    Friend WithEvents lbl库存区域 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt材料名称 As System.Windows.Forms.TextBox
End Class
