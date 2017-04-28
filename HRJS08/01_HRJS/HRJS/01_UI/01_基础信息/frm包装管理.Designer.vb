<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm包装管理
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txt包装物编号 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt包装物名称 = New UserControl.UCText(Me.components)
        Me.txt供应商名称 = New UserControl.UCText(Me.components)
        Me.供应商编号 = New UserControl.UCLabel(Me.components)
        Me.txt供应商编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt规格 = New UserControl.UCText(Me.components)
        CType(Me.txt包装物编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt包装物名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt供应商名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt供应商编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt规格, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnF4删除.Tag = "101603"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        Me.btnF2编辑.Tag = "101601"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        Me.btnF3保存.Tag = "101602"
        '
        'txt包装物编号
        '
        Me.txt包装物编号.AutoSize = False
        Me.txt包装物编号.IsDigit = False
        Me.txt包装物编号.Location = New System.Drawing.Point(112, 56)
        Me.txt包装物编号.Name = "txt包装物编号"
        Me.txt包装物编号.Size = New System.Drawing.Size(106, 23)
        Me.txt包装物编号.TabIndex = 0
        '
        'UcLabel4
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance2
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 61
        Me.UcLabel4.Text = "*包装物编号"
        '
        'UcLabel8
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance3
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 59
        Me.UcLabel8.Text = "*包装物名称"
        '
        'txt包装物名称
        '
        Me.txt包装物名称.AutoSize = False
        Me.txt包装物名称.IsDigit = False
        Me.txt包装物名称.Location = New System.Drawing.Point(112, 79)
        Me.txt包装物名称.Name = "txt包装物名称"
        Me.txt包装物名称.Size = New System.Drawing.Size(262, 23)
        Me.txt包装物名称.TabIndex = 1
        '
        'txt供应商名称
        '
        Me.txt供应商名称.AutoSize = False
        Me.txt供应商名称.Enabled = False
        Me.txt供应商名称.IsDigit = False
        Me.txt供应商名称.Location = New System.Drawing.Point(218, 125)
        Me.txt供应商名称.Name = "txt供应商名称"
        Me.txt供应商名称.Size = New System.Drawing.Size(156, 23)
        Me.txt供应商名称.TabIndex = 4
        '
        '供应商编号
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.供应商编号.Appearance = Appearance1
        Me.供应商编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.供应商编号.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.供应商编号.Location = New System.Drawing.Point(12, 125)
        Me.供应商编号.Name = "供应商编号"
        Me.供应商编号.Size = New System.Drawing.Size(100, 23)
        Me.供应商编号.TabIndex = 63
        Me.供应商编号.Text = "*供应商编号"
        '
        'txt供应商编号
        '
        Me.txt供应商编号.AutoSize = False
        Me.txt供应商编号.ButtonsRight.Add(EditorButton1)
        Me.txt供应商编号.IsDigit = False
        Me.txt供应商编号.Location = New System.Drawing.Point(112, 125)
        Me.txt供应商编号.Name = "txt供应商编号"
        Me.txt供应商编号.Size = New System.Drawing.Size(106, 23)
        Me.txt供应商编号.TabIndex = 3
        '
        'UcLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance5
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 135
        Me.UcLabel1.Text = "*规格"
        '
        'txt规格
        '
        Me.txt规格.AutoSize = False
        Me.txt规格.IsDigit = False
        Me.txt规格.Location = New System.Drawing.Point(112, 102)
        Me.txt规格.Name = "txt规格"
        Me.txt规格.Size = New System.Drawing.Size(262, 23)
        Me.txt规格.TabIndex = 2
        '
        'frm包装管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.txt规格)
        Me.Controls.Add(Me.txt供应商编号)
        Me.Controls.Add(Me.txt供应商名称)
        Me.Controls.Add(Me.供应商编号)
        Me.Controls.Add(Me.txt包装物编号)
        Me.Controls.Add(Me.UcLabel4)
        Me.Controls.Add(Me.UcLabel8)
        Me.Controls.Add(Me.txt包装物名称)
        Me.Name = "frm包装管理"
        Me.Text = "包装管理"
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.txt包装物名称, 0)
        Me.Controls.SetChildIndex(Me.UcLabel8, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.txt包装物编号, 0)
        Me.Controls.SetChildIndex(Me.供应商编号, 0)
        Me.Controls.SetChildIndex(Me.txt供应商名称, 0)
        Me.Controls.SetChildIndex(Me.txt供应商编号, 0)
        Me.Controls.SetChildIndex(Me.txt规格, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        CType(Me.txt包装物编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt包装物名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt供应商名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt供应商编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt规格, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt包装物编号 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents txt包装物名称 As UserControl.UCText
    Friend WithEvents txt供应商名称 As UserControl.UCText
    Friend WithEvents 供应商编号 As UserControl.UCLabel
    Friend WithEvents txt供应商编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt规格 As UserControl.UCText
End Class
