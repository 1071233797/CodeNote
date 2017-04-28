<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm原材料标签打印
    Inherits InheritsSearchForm

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
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcCombo1 = New UserControl.UCCombo(Me.components)
        Me.UcCombo2 = New UserControl.UCCombo(Me.components)
        Me.btnF11打印 = New UserControl.UCButton(Me.components)
        Me.txt原材料材料编号 = New UserControl.UCText(Me.components)
        Me.原材料材料编号 = New UserControl.UCLabel(Me.components)
        Me.txt数量 = New UserControl.UCText(Me.components)
        Me.数量 = New UserControl.UCLabel(Me.components)
        Me.txt重量 = New UserControl.UCText(Me.components)
        Me.重量 = New UserControl.UCLabel(Me.components)
        Me.txt批次 = New UserControl.UCText(Me.components)
        Me.批次 = New UserControl.UCLabel(Me.components)
        Me.txt库存区域 = New UserControl.UCText(Me.components)
        Me.库存区域 = New UserControl.UCLabel(Me.components)
        CType(Me.UcCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcCombo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt批次, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt库存区域, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 4
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 1
        Me.btnF2查询.Visible = False
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 2
        Me.btnF3选择.Visible = False
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 0
        '
        'UcCombo1
        '
        Me.UcCombo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UcCombo1.DisplayLayout.Appearance = Appearance41
        Me.UcCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance43.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance43.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.GroupByBox.Appearance = Appearance43
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance44
        Me.UcCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance45.BackColor2 = System.Drawing.SystemColors.Control
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo1.DisplayLayout.GroupByBox.PromptAppearance = Appearance45
        Me.UcCombo1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcCombo1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Appearance46.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UcCombo1.DisplayLayout.Override.ActiveCellAppearance = Appearance46
        Appearance47.BackColor = System.Drawing.SystemColors.Highlight
        Appearance47.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UcCombo1.DisplayLayout.Override.ActiveRowAppearance = Appearance47
        Me.UcCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UcCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.Override.CardAreaAppearance = Appearance48
        Appearance49.BorderColor = System.Drawing.Color.Silver
        Appearance49.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UcCombo1.DisplayLayout.Override.CellAppearance = Appearance49
        Me.UcCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcCombo1.DisplayLayout.Override.CellPadding = 0
        Appearance51.BackColor = System.Drawing.SystemColors.Control
        Appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance51.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.Override.GroupByRowAppearance = Appearance51
        Appearance53.TextHAlignAsString = "Left"
        Me.UcCombo1.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.UcCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UcCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Appearance55.BorderColor = System.Drawing.Color.Silver
        Me.UcCombo1.DisplayLayout.Override.RowAppearance = Appearance55
        Me.UcCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcCombo1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance56
        Me.UcCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UcCombo1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcCombo1.Location = New System.Drawing.Point(135, 49)
        Me.UcCombo1.Name = "UcCombo1"
        Me.UcCombo1.Size = New System.Drawing.Size(100, 22)
        Me.UcCombo1.TabIndex = 138
        Me.UcCombo1.Text = "刘明"
        '
        'UcCombo2
        '
        Me.UcCombo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UcCombo2.DisplayLayout.Appearance = Appearance22
        Me.UcCombo2.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcCombo2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo2.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo2.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.UcCombo2.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo2.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.UcCombo2.DisplayLayout.MaxColScrollRegions = 1
        Me.UcCombo2.DisplayLayout.MaxRowScrollRegions = 1
        Appearance28.BackColor = System.Drawing.SystemColors.Window
        Appearance28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UcCombo2.DisplayLayout.Override.ActiveCellAppearance = Appearance28
        Appearance29.BackColor = System.Drawing.SystemColors.Highlight
        Appearance29.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UcCombo2.DisplayLayout.Override.ActiveRowAppearance = Appearance29
        Me.UcCombo2.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UcCombo2.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance30.BackColor = System.Drawing.SystemColors.Window
        Me.UcCombo2.DisplayLayout.Override.CardAreaAppearance = Appearance30
        Appearance31.BorderColor = System.Drawing.Color.Silver
        Appearance31.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UcCombo2.DisplayLayout.Override.CellAppearance = Appearance31
        Me.UcCombo2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcCombo2.DisplayLayout.Override.CellPadding = 0
        Appearance32.BackColor = System.Drawing.SystemColors.Control
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo2.DisplayLayout.Override.GroupByRowAppearance = Appearance32
        Appearance38.TextHAlignAsString = "Left"
        Me.UcCombo2.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.UcCombo2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UcCombo2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Me.UcCombo2.DisplayLayout.Override.RowAppearance = Appearance39
        Me.UcCombo2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcCombo2.DisplayLayout.Override.TemplateAddRowAppearance = Appearance40
        Me.UcCombo2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcCombo2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcCombo2.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UcCombo2.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcCombo2.Location = New System.Drawing.Point(135, 80)
        Me.UcCombo2.Name = "UcCombo2"
        Me.UcCombo2.Size = New System.Drawing.Size(100, 22)
        Me.UcCombo2.TabIndex = 140
        Me.UcCombo2.Text = "刘明"
        '
        'btnF11打印
        '
        Me.btnF11打印.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance61.BackColor = System.Drawing.SystemColors.Control
        Appearance61.BackColor2 = System.Drawing.SystemColors.Control
        Appearance61.TextHAlignAsString = "Center"
        Appearance61.TextVAlignAsString = "Middle"
        Me.btnF11打印.Appearance = Appearance61
        Me.btnF11打印.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11打印.FSearchButtonName = ""
        Me.btnF11打印.Location = New System.Drawing.Point(832, 12)
        Me.btnF11打印.Name = "btnF11打印"
        Me.btnF11打印.Size = New System.Drawing.Size(80, 34)
        Me.btnF11打印.TabIndex = 3
        Me.btnF11打印.Text = "F11:打印"
        '
        'txt原材料材料编号
        '
        Me.txt原材料材料编号.AutoSize = False
        Me.txt原材料材料编号.IsDigit = False
        Me.txt原材料材料编号.Location = New System.Drawing.Point(127, 67)
        Me.txt原材料材料编号.Name = "txt原材料材料编号"
        Me.txt原材料材料编号.Size = New System.Drawing.Size(149, 23)
        Me.txt原材料材料编号.TabIndex = 467
        '
        '原材料材料编号
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.原材料材料编号.Appearance = Appearance4
        Me.原材料材料编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.原材料材料编号.Location = New System.Drawing.Point(13, 68)
        Me.原材料材料编号.Name = "原材料材料编号"
        Me.原材料材料编号.Size = New System.Drawing.Size(114, 23)
        Me.原材料材料编号.TabIndex = 468
        Me.原材料材料编号.Text = "原材料材料编号"
        '
        'txt数量
        '
        Me.txt数量.AutoSize = False
        Me.txt数量.IsDigit = False
        Me.txt数量.Location = New System.Drawing.Point(127, 97)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Size = New System.Drawing.Size(149, 23)
        Me.txt数量.TabIndex = 467
        '
        '数量
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.数量.Appearance = Appearance5
        Me.数量.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.数量.Location = New System.Drawing.Point(13, 97)
        Me.数量.Name = "数量"
        Me.数量.Size = New System.Drawing.Size(114, 23)
        Me.数量.TabIndex = 468
        Me.数量.Text = "数量"
        '
        'txt重量
        '
        Me.txt重量.AutoSize = False
        Me.txt重量.IsDigit = False
        Me.txt重量.Location = New System.Drawing.Point(127, 126)
        Me.txt重量.Name = "txt重量"
        Me.txt重量.Size = New System.Drawing.Size(149, 23)
        Me.txt重量.TabIndex = 467
        '
        '重量
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.重量.Appearance = Appearance6
        Me.重量.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.重量.Location = New System.Drawing.Point(13, 126)
        Me.重量.Name = "重量"
        Me.重量.Size = New System.Drawing.Size(114, 23)
        Me.重量.TabIndex = 468
        Me.重量.Text = "重量"
        '
        'txt批次
        '
        Me.txt批次.AutoSize = False
        Me.txt批次.IsDigit = False
        Me.txt批次.Location = New System.Drawing.Point(127, 155)
        Me.txt批次.Name = "txt批次"
        Me.txt批次.Size = New System.Drawing.Size(149, 23)
        Me.txt批次.TabIndex = 467
        '
        '批次
        '
        Appearance7.BackColor = System.Drawing.Color.SkyBlue
        Appearance7.BackColor2 = System.Drawing.Color.White
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.BorderColor2 = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.TextVAlignAsString = "Middle"
        Me.批次.Appearance = Appearance7
        Me.批次.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.批次.Location = New System.Drawing.Point(13, 155)
        Me.批次.Name = "批次"
        Me.批次.Size = New System.Drawing.Size(114, 23)
        Me.批次.TabIndex = 468
        Me.批次.Text = "批次"
        '
        'txt库存区域
        '
        Me.txt库存区域.AutoSize = False
        Me.txt库存区域.IsDigit = False
        Me.txt库存区域.Location = New System.Drawing.Point(127, 184)
        Me.txt库存区域.Name = "txt库存区域"
        Me.txt库存区域.Size = New System.Drawing.Size(149, 23)
        Me.txt库存区域.TabIndex = 467
        '
        '库存区域
        '
        Appearance8.BackColor = System.Drawing.Color.SkyBlue
        Appearance8.BackColor2 = System.Drawing.Color.White
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance8.BorderColor = System.Drawing.Color.Black
        Appearance8.BorderColor2 = System.Drawing.Color.Black
        Appearance8.TextHAlignAsString = "Left"
        Appearance8.TextVAlignAsString = "Middle"
        Me.库存区域.Appearance = Appearance8
        Me.库存区域.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.库存区域.Location = New System.Drawing.Point(13, 184)
        Me.库存区域.Name = "库存区域"
        Me.库存区域.Size = New System.Drawing.Size(114, 23)
        Me.库存区域.TabIndex = 468
        Me.库存区域.Text = "库存区域"
        '
        'frm原材料标签打印
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.库存区域)
        Me.Controls.Add(Me.批次)
        Me.Controls.Add(Me.重量)
        Me.Controls.Add(Me.数量)
        Me.Controls.Add(Me.原材料材料编号)
        Me.Controls.Add(Me.txt库存区域)
        Me.Controls.Add(Me.txt批次)
        Me.Controls.Add(Me.txt重量)
        Me.Controls.Add(Me.txt数量)
        Me.Controls.Add(Me.txt原材料材料编号)
        Me.Controls.Add(Me.btnF11打印)
        Me.Name = "frm原材料标签打印"
        Me.Text = "原材料标签打印"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.btnF11打印, 0)
        Me.Controls.SetChildIndex(Me.txt原材料材料编号, 0)
        Me.Controls.SetChildIndex(Me.txt数量, 0)
        Me.Controls.SetChildIndex(Me.txt重量, 0)
        Me.Controls.SetChildIndex(Me.txt批次, 0)
        Me.Controls.SetChildIndex(Me.txt库存区域, 0)
        Me.Controls.SetChildIndex(Me.原材料材料编号, 0)
        Me.Controls.SetChildIndex(Me.数量, 0)
        Me.Controls.SetChildIndex(Me.重量, 0)
        Me.Controls.SetChildIndex(Me.批次, 0)
        Me.Controls.SetChildIndex(Me.库存区域, 0)
        CType(Me.UcCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcCombo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt重量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt批次, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt库存区域, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcCombo1 As UserControl.UCCombo
    Friend WithEvents UcCombo2 As UserControl.UCCombo
    Friend WithEvents btnF11打印 As UserControl.UCButton
    Friend WithEvents txt原材料材料编号 As UserControl.UCText
    Friend WithEvents 原材料材料编号 As UserControl.UCLabel
    Friend WithEvents txt数量 As UserControl.UCText
    Friend WithEvents 数量 As UserControl.UCLabel
    Friend WithEvents txt重量 As UserControl.UCText
    Friend WithEvents 重量 As UserControl.UCLabel
    Friend WithEvents txt批次 As UserControl.UCText
    Friend WithEvents 批次 As UserControl.UCLabel
    Friend WithEvents txt库存区域 As UserControl.UCText
    Friend WithEvents 库存区域 As UserControl.UCLabel
End Class
