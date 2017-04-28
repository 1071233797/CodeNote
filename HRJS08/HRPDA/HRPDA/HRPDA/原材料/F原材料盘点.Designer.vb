<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class F原材料盘点
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
        Me.txt备注 = New System.Windows.Forms.TextBox
        Me.txt在库重量 = New System.Windows.Forms.TextBox
        Me.txt在库数量 = New System.Windows.Forms.TextBox
        Me.txt批次 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt材料编号 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt盘点重量 = New System.Windows.Forms.TextBox
        Me.txt盘点数量 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt材料名称 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn保存
        '
        Me.btn保存.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn保存.Enabled = False
        Me.btn保存.Location = New System.Drawing.Point(75, 237)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(64, 43)
        Me.btn保存.TabIndex = 11
        Me.btn保存.Text = "保存"
        '
        'btn关闭
        '
        Me.btn关闭.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn关闭.Location = New System.Drawing.Point(144, 237)
        Me.btn关闭.Name = "btn关闭"
        Me.btn关闭.Size = New System.Drawing.Size(64, 43)
        Me.btn关闭.TabIndex = 10
        Me.btn关闭.Text = "关闭"
        '
        'btn清空
        '
        Me.btn清空.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn清空.Location = New System.Drawing.Point(5, 237)
        Me.btn清空.Name = "btn清空"
        Me.btn清空.Size = New System.Drawing.Size(64, 43)
        Me.btn清空.TabIndex = 9
        Me.btn清空.Text = "清空"
        '
        'txt备注
        '
        Me.txt备注.Location = New System.Drawing.Point(80, 187)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(128, 23)
        Me.txt备注.TabIndex = 48
        '
        'txt在库重量
        '
        Me.txt在库重量.Location = New System.Drawing.Point(80, 118)
        Me.txt在库重量.Name = "txt在库重量"
        Me.txt在库重量.ReadOnly = True
        Me.txt在库重量.Size = New System.Drawing.Size(128, 23)
        Me.txt在库重量.TabIndex = 47
        '
        'txt在库数量
        '
        Me.txt在库数量.Location = New System.Drawing.Point(80, 95)
        Me.txt在库数量.Name = "txt在库数量"
        Me.txt在库数量.ReadOnly = True
        Me.txt在库数量.Size = New System.Drawing.Size(128, 23)
        Me.txt在库数量.TabIndex = 46
        '
        'txt批次
        '
        Me.txt批次.Location = New System.Drawing.Point(80, 72)
        Me.txt批次.Name = "txt批次"
        Me.txt批次.ReadOnly = True
        Me.txt批次.Size = New System.Drawing.Size(128, 23)
        Me.txt批次.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.Text = "备注"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.Text = "在库重量"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.Text = "在库数量"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.Text = "材料批次"
        '
        'txt材料编号
        '
        Me.txt材料编号.Location = New System.Drawing.Point(80, 26)
        Me.txt材料编号.Name = "txt材料编号"
        Me.txt材料编号.Size = New System.Drawing.Size(128, 23)
        Me.txt材料编号.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.Text = "材料编号"
        '
        'txt盘点重量
        '
        Me.txt盘点重量.Location = New System.Drawing.Point(80, 164)
        Me.txt盘点重量.Name = "txt盘点重量"
        Me.txt盘点重量.Size = New System.Drawing.Size(128, 23)
        Me.txt盘点重量.TabIndex = 57
        '
        'txt盘点数量
        '
        Me.txt盘点数量.Location = New System.Drawing.Point(80, 141)
        Me.txt盘点数量.Name = "txt盘点数量"
        Me.txt盘点数量.Size = New System.Drawing.Size(128, 23)
        Me.txt盘点数量.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.Text = "盘点重量"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(5, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.Text = "盘点数量"
        '
        'txt材料名称
        '
        Me.txt材料名称.Location = New System.Drawing.Point(80, 49)
        Me.txt材料名称.Name = "txt材料名称"
        Me.txt材料名称.ReadOnly = True
        Me.txt材料名称.Size = New System.Drawing.Size(128, 23)
        Me.txt材料名称.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.Text = "材料名称"
        '
        'F原材料盘点
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(217, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt材料名称)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt盘点重量)
        Me.Controls.Add(Me.txt盘点数量)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.txt在库重量)
        Me.Controls.Add(Me.txt在库数量)
        Me.Controls.Add(Me.txt批次)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt材料编号)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn关闭)
        Me.Controls.Add(Me.btn清空)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "F原材料盘点"
        Me.Text = "F原材料盘点"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn保存 As System.Windows.Forms.Button
    Friend WithEvents btn关闭 As System.Windows.Forms.Button
    Friend WithEvents btn清空 As System.Windows.Forms.Button
    Friend WithEvents txt备注 As System.Windows.Forms.TextBox
    Friend WithEvents txt在库重量 As System.Windows.Forms.TextBox
    Friend WithEvents txt在库数量 As System.Windows.Forms.TextBox
    Friend WithEvents txt批次 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt材料编号 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt盘点重量 As System.Windows.Forms.TextBox
    Friend WithEvents txt盘点数量 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt材料名称 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
