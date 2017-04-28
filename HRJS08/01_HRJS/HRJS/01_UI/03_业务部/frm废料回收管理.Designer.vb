<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm废料回收管理
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
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Me.UcLabel14 = New UserControl.UCLabel(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.UcLabel11 = New UserControl.UCLabel(Me.components)
        Me.txt废料数量 = New UserControl.UCText(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.txt回收日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt原材料名称 = New UserControl.UCText(Me.components)
        Me.txt材质 = New UserControl.UCText(Me.components)
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt废料产生工序 = New UserControl.UCText(Me.components)
        Me.UcLabel15 = New UserControl.UCLabel(Me.components)
        Me.txt原材料批号 = New UserControl.UCText(Me.components)
        Me.txt原材料编号 = New UserControl.UCText(Me.components)
        Me.txt原材料规格 = New UserControl.UCText(Me.components)
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt废料数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回收日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt材质, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt废料产生工序, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料批号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料规格, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 11
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 7
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 10
        Me.btnF4删除.Tag = "502303"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 8
        Me.btnF2编辑.Tag = "502301"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 9
        Me.btnF3保存.Tag = "502302"
        '
        'UcLabel14
        '
        Appearance21.BackColor = System.Drawing.Color.SkyBlue
        Appearance21.BackColor2 = System.Drawing.Color.White
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance21.BorderColor = System.Drawing.Color.Black
        Appearance21.BorderColor2 = System.Drawing.Color.Black
        Appearance21.TextHAlignAsString = "Left"
        Appearance21.TextVAlignAsString = "Middle"
        Me.UcLabel14.Appearance = Appearance21
        Me.UcLabel14.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel14.Location = New System.Drawing.Point(12, 220)
        Me.UcLabel14.Name = "UcLabel14"
        Me.UcLabel14.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel14.TabIndex = 241
        Me.UcLabel14.Text = "备注"
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(112, 218)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(262, 23)
        Me.txt备注.TabIndex = 6
        '
        'UcLabel11
        '
        Appearance42.BackColor = System.Drawing.Color.SkyBlue
        Appearance42.BackColor2 = System.Drawing.Color.White
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance42.BorderColor = System.Drawing.Color.Black
        Appearance42.BorderColor2 = System.Drawing.Color.Black
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UcLabel11.Appearance = Appearance42
        Me.UcLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel11.Location = New System.Drawing.Point(12, 128)
        Me.UcLabel11.Name = "UcLabel11"
        Me.UcLabel11.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel11.TabIndex = 237
        Me.UcLabel11.Text = "废料数量"
        '
        'txt废料数量
        '
        Me.txt废料数量.AutoSize = False
        Me.txt废料数量.IsDigit = False
        Me.txt废料数量.Location = New System.Drawing.Point(112, 128)
        Me.txt废料数量.Name = "txt废料数量"
        Me.txt废料数量.Size = New System.Drawing.Size(184, 23)
        Me.txt废料数量.TabIndex = 3
        '
        'UcLabel8
        '
        Appearance44.BackColor = System.Drawing.Color.SkyBlue
        Appearance44.BackColor2 = System.Drawing.Color.White
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance44.BorderColor = System.Drawing.Color.Black
        Appearance44.BorderColor2 = System.Drawing.Color.Black
        Appearance44.TextHAlignAsString = "Left"
        Appearance44.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance44
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(12, 105)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 235
        Me.UcLabel8.Text = "废料产生工序"
        '
        'UcLabel5
        '
        Appearance45.BackColor = System.Drawing.Color.SkyBlue
        Appearance45.BackColor2 = System.Drawing.Color.White
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance45.BorderColor = System.Drawing.Color.Black
        Appearance45.BorderColor2 = System.Drawing.Color.Black
        Appearance45.TextHAlignAsString = "Left"
        Appearance45.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance45
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(12, 197)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 232
        Me.UcLabel5.Text = "回收日期"
        '
        'txt回收日期
        '
        Me.txt回收日期.Location = New System.Drawing.Point(112, 197)
        Me.txt回收日期.MaskInput = "yyyy/mm/dd"
        Me.txt回收日期.Name = "txt回收日期"
        Me.txt回收日期.Size = New System.Drawing.Size(184, 21)
        Me.txt回收日期.TabIndex = 5
        '
        'txt原材料名称
        '
        Me.txt原材料名称.AutoSize = False
        Me.txt原材料名称.IsDigit = False
        Me.txt原材料名称.Location = New System.Drawing.Point(237, 59)
        Me.txt原材料名称.Name = "txt原材料名称"
        Me.txt原材料名称.ReadOnly = True
        Me.txt原材料名称.Size = New System.Drawing.Size(137, 23)
        Me.txt原材料名称.TabIndex = 3
        '
        'txt材质
        '
        Me.txt材质.AutoSize = False
        Me.txt材质.IsDigit = False
        Me.txt材质.Location = New System.Drawing.Point(112, 151)
        Me.txt材质.Name = "txt材质"
        Me.txt材质.ReadOnly = True
        Me.txt材质.Size = New System.Drawing.Size(184, 23)
        Me.txt材质.TabIndex = 4
        '
        'UcLabel13
        '
        Appearance49.BackColor = System.Drawing.Color.SkyBlue
        Appearance49.BackColor2 = System.Drawing.Color.White
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance49.BorderColor = System.Drawing.Color.Black
        Appearance49.BorderColor2 = System.Drawing.Color.Black
        Appearance49.TextHAlignAsString = "Left"
        Appearance49.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance49
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Location = New System.Drawing.Point(12, 151)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 222
        Me.UcLabel13.Text = "材质"
        '
        'UcLabel6
        '
        Appearance25.BackColor = System.Drawing.Color.SkyBlue
        Appearance25.BackColor2 = System.Drawing.Color.White
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance25.BorderColor = System.Drawing.Color.Black
        Appearance25.BorderColor2 = System.Drawing.Color.Black
        Appearance25.TextHAlignAsString = "Left"
        Appearance25.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance25
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(12, 174)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 224
        Me.UcLabel6.Text = "原材料规格"
        '
        'UcLabel2
        '
        Appearance51.BackColor = System.Drawing.Color.SkyBlue
        Appearance51.BackColor2 = System.Drawing.Color.White
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance51.BorderColor = System.Drawing.Color.Black
        Appearance51.BorderColor2 = System.Drawing.Color.Black
        Appearance51.TextHAlignAsString = "Left"
        Appearance51.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance51
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(12, 59)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 246
        Me.UcLabel2.Text = "原材料编号"
        '
        'txt废料产生工序
        '
        Me.txt废料产生工序.AutoSize = False
        Me.txt废料产生工序.IsDigit = False
        Me.txt废料产生工序.Location = New System.Drawing.Point(112, 105)
        Me.txt废料产生工序.Name = "txt废料产生工序"
        Me.txt废料产生工序.Size = New System.Drawing.Size(184, 23)
        Me.txt废料产生工序.TabIndex = 2
        '
        'UcLabel15
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel15.Appearance = Appearance1
        Me.UcLabel15.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel15.Location = New System.Drawing.Point(12, 82)
        Me.UcLabel15.Name = "UcLabel15"
        Me.UcLabel15.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel15.TabIndex = 249
        Me.UcLabel15.Text = "原材料批号"
        '
        'txt原材料批号
        '
        Me.txt原材料批号.AutoSize = False
        Me.txt原材料批号.IsDigit = False
        Me.txt原材料批号.Location = New System.Drawing.Point(112, 82)
        Me.txt原材料批号.Name = "txt原材料批号"
        Me.txt原材料批号.Size = New System.Drawing.Size(184, 23)
        Me.txt原材料批号.TabIndex = 1
        '
        'txt原材料编号
        '
        Me.txt原材料编号.AutoSize = False
        Me.txt原材料编号.ButtonsRight.Add(EditorButton1)
        Me.txt原材料编号.IsDigit = False
        Me.txt原材料编号.Location = New System.Drawing.Point(112, 59)
        Me.txt原材料编号.MaxLength = 50
        Me.txt原材料编号.Name = "txt原材料编号"
        Me.txt原材料编号.Size = New System.Drawing.Size(125, 23)
        Me.txt原材料编号.TabIndex = 0
        '
        'txt原材料规格
        '
        Me.txt原材料规格.AutoSize = False
        Me.txt原材料规格.IsDigit = False
        Me.txt原材料规格.Location = New System.Drawing.Point(112, 174)
        Me.txt原材料规格.Name = "txt原材料规格"
        Me.txt原材料规格.Size = New System.Drawing.Size(184, 23)
        Me.txt原材料规格.TabIndex = 4
        '
        'frm废料回收管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt原材料规格)
        Me.Controls.Add(Me.txt原材料编号)
        Me.Controls.Add(Me.UcLabel15)
        Me.Controls.Add(Me.txt原材料批号)
        Me.Controls.Add(Me.txt废料产生工序)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcLabel14)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.UcLabel11)
        Me.Controls.Add(Me.txt废料数量)
        Me.Controls.Add(Me.UcLabel8)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.txt回收日期)
        Me.Controls.Add(Me.txt原材料名称)
        Me.Controls.Add(Me.txt材质)
        Me.Controls.Add(Me.UcLabel13)
        Me.Controls.Add(Me.UcLabel6)
        Me.Name = "frm废料回收管理"
        Me.Text = "废料回收管理"
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel6, 0)
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.txt材质, 0)
        Me.Controls.SetChildIndex(Me.txt原材料名称, 0)
        Me.Controls.SetChildIndex(Me.txt回收日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.UcLabel8, 0)
        Me.Controls.SetChildIndex(Me.txt废料数量, 0)
        Me.Controls.SetChildIndex(Me.UcLabel11, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        Me.Controls.SetChildIndex(Me.UcLabel14, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt废料产生工序, 0)
        Me.Controls.SetChildIndex(Me.txt原材料批号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel15, 0)
        Me.Controls.SetChildIndex(Me.txt原材料编号, 0)
        Me.Controls.SetChildIndex(Me.txt原材料规格, 0)
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt废料数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回收日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt材质, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt废料产生工序, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料批号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料规格, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel14 As UserControl.UCLabel
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents UcLabel11 As UserControl.UCLabel
    Friend WithEvents txt废料数量 As UserControl.UCText
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents txt回收日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt原材料名称 As UserControl.UCText
    Friend WithEvents txt材质 As UserControl.UCText
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt废料产生工序 As UserControl.UCText
    Friend WithEvents UcLabel15 As UserControl.UCLabel
    Friend WithEvents txt原材料批号 As UserControl.UCText
    Friend WithEvents txt原材料编号 As UserControl.UCText
    Friend WithEvents txt原材料规格 As UserControl.UCText
End Class
