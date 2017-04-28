<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm货位管理
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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.部门名称 = New UserControl.UCLabel(Me.components)
        Me.部门编号 = New UserControl.UCLabel(Me.components)
        Me.txt货位名称 = New UserControl.UCText(Me.components)
        Me.txt货位编号 = New UserControl.UCText(Me.components)
        CType(Me.txt货位名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt货位编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 9
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 5
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 8
        Me.btnF4删除.Tag = "100103"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        Me.btnF2编辑.Tag = "100101"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        Me.btnF3保存.Tag = "100102"
        '
        'labModel
        '
        Me.labModel.TabIndex = 4
        Me.labModel.Text = "新增"
        '
        '部门名称
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.部门名称.Appearance = Appearance14
        Me.部门名称.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.部门名称.Location = New System.Drawing.Point(12, 79)
        Me.部门名称.Name = "部门名称"
        Me.部门名称.Size = New System.Drawing.Size(100, 23)
        Me.部门名称.TabIndex = 2
        Me.部门名称.Text = "*货位名称"
        '
        '部门编号
        '
        Appearance22.BackColor = System.Drawing.Color.SkyBlue
        Appearance22.BackColor2 = System.Drawing.Color.White
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance22.BorderColor = System.Drawing.Color.Black
        Appearance22.BorderColor2 = System.Drawing.Color.Black
        Appearance22.TextHAlignAsString = "Left"
        Appearance22.TextVAlignAsString = "Middle"
        Me.部门编号.Appearance = Appearance22
        Me.部门编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.部门编号.Location = New System.Drawing.Point(12, 56)
        Me.部门编号.Name = "部门编号"
        Me.部门编号.Size = New System.Drawing.Size(100, 23)
        Me.部门编号.TabIndex = 0
        Me.部门编号.Text = "*货位编号"
        '
        'txt货位名称
        '
        Me.txt货位名称.AutoSize = False
        Me.txt货位名称.IsDigit = False
        Me.txt货位名称.Location = New System.Drawing.Point(112, 78)
        Me.txt货位名称.MaxLength = 50
        Me.txt货位名称.Name = "txt货位名称"
        Me.txt货位名称.Size = New System.Drawing.Size(106, 23)
        Me.txt货位名称.TabIndex = 3
        '
        'txt货位编号
        '
        Me.txt货位编号.AutoSize = False
        Me.txt货位编号.IsDigit = False
        Me.txt货位编号.Location = New System.Drawing.Point(112, 55)
        Me.txt货位编号.MaxLength = 50
        Me.txt货位编号.Name = "txt货位编号"
        Me.txt货位编号.Size = New System.Drawing.Size(106, 23)
        Me.txt货位编号.TabIndex = 1
        '
        'frm货位管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.部门编号)
        Me.Controls.Add(Me.部门名称)
        Me.Controls.Add(Me.txt货位名称)
        Me.Controls.Add(Me.txt货位编号)
        Me.Name = "frm货位管理"
        Me.Text = "货位管理"
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.txt货位编号, 0)
        Me.Controls.SetChildIndex(Me.txt货位名称, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.部门名称, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.部门编号, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.txt货位名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt货位编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt货位编号 As UserControl.UCText
    Friend WithEvents txt货位名称 As UserControl.UCText
    Friend WithEvents 部门编号 As UserControl.UCLabel
    Friend WithEvents 部门名称 As UserControl.UCLabel
End Class
