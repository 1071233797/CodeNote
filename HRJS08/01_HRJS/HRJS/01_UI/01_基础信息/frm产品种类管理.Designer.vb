<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm产品种类管理
    Inherits InheritsMasterForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.产品种类名称 = New UserControl.UCLabel(Me.components)
        Me.txt产品种类名称 = New UserControl.UCText(Me.components)
        Me.产品种类编号 = New UserControl.UCLabel(Me.components)
        Me.txt产品种类编号 = New UserControl.UCText(Me.components)
        CType(Me.txt产品种类名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品种类编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 6
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 5
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 3
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 4
        '
        'labModel
        '
        Me.labModel.Text = "新增"
        '
        '产品种类名称
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.产品种类名称.Appearance = Appearance5
        Me.产品种类名称.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.产品种类名称.Location = New System.Drawing.Point(12, 79)
        Me.产品种类名称.Name = "产品种类名称"
        Me.产品种类名称.Size = New System.Drawing.Size(100, 23)
        Me.产品种类名称.TabIndex = 0
        Me.产品种类名称.Text = "*产品种类名称"
        '
        'txt产品种类名称
        '
        Me.txt产品种类名称.AutoSize = False
        Me.txt产品种类名称.IsDigit = False
        Me.txt产品种类名称.Location = New System.Drawing.Point(112, 79)
        Me.txt产品种类名称.Name = "txt产品种类名称"
        Me.txt产品种类名称.Size = New System.Drawing.Size(106, 23)
        Me.txt产品种类名称.TabIndex = 1
        '
        '产品种类编号
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.产品种类编号.Appearance = Appearance2
        Me.产品种类编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.产品种类编号.Location = New System.Drawing.Point(12, 56)
        Me.产品种类编号.Name = "产品种类编号"
        Me.产品种类编号.Size = New System.Drawing.Size(100, 23)
        Me.产品种类编号.TabIndex = 56
        Me.产品种类编号.Text = "*产品种类编号"
        '
        'txt产品种类编号
        '
        Me.txt产品种类编号.AutoSize = False
        Me.txt产品种类编号.IsDigit = False
        Me.txt产品种类编号.Location = New System.Drawing.Point(112, 56)
        Me.txt产品种类编号.Name = "txt产品种类编号"
        Me.txt产品种类编号.Size = New System.Drawing.Size(106, 23)
        Me.txt产品种类编号.TabIndex = 0
        '
        'frm产品种类管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt产品种类编号)
        Me.Controls.Add(Me.产品种类编号)
        Me.Controls.Add(Me.产品种类名称)
        Me.Controls.Add(Me.txt产品种类名称)
        Me.Name = "frm产品种类管理"
        Me.Text = "产品种类管理"
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.txt产品种类名称, 0)
        Me.Controls.SetChildIndex(Me.产品种类名称, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.产品种类编号, 0)
        Me.Controls.SetChildIndex(Me.txt产品种类编号, 0)
        CType(Me.txt产品种类名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品种类编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt产品种类名称 As UserControl.UCText
    Friend WithEvents 产品种类名称 As UserControl.UCLabel
    Friend WithEvents 产品种类编号 As UserControl.UCLabel
    Friend WithEvents txt产品种类编号 As UserControl.UCText
End Class
