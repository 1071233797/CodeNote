<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm成品入库申请
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量(个)")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库重量(kg)")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.供应商编号 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcText1 = New UserControl.UCText(Me.components)
        Me.txt申请者编号 = New UserControl.UCText(Me.components)
        Me.txt申请者名称 = New UserControl.UCText(Me.components)
        Me.UcGridEdit1 = New UserControl.UCGridEdit(Me.components)
        Me.dt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnF5行追加 = New UserControl.UCButton(Me.components)
        Me.btnF6行删除 = New UserControl.UCButton(Me.components)
        CType(Me.UcText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
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
        Me.UcLabel4.Text = "*申请单编号"
        '
        '供应商编号
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.供应商编号.Appearance = Appearance4
        Me.供应商编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.供应商编号.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.供应商编号.Location = New System.Drawing.Point(12, 102)
        Me.供应商编号.Name = "供应商编号"
        Me.供应商编号.Size = New System.Drawing.Size(100, 23)
        Me.供应商编号.TabIndex = 63
        Me.供应商编号.Text = "入库日期"
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
        Me.UcLabel1.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 135
        Me.UcLabel1.Text = "*申请者"
        '
        'UcText1
        '
        Me.UcText1.AutoSize = False
        Me.UcText1.ButtonsRight.Add(EditorButton1)
        Me.UcText1.IsDigit = False
        Me.UcText1.Location = New System.Drawing.Point(112, 56)
        Me.UcText1.Name = "UcText1"
        Me.UcText1.Size = New System.Drawing.Size(163, 23)
        Me.UcText1.TabIndex = 136
        '
        'txt申请者编号
        '
        Me.txt申请者编号.AutoSize = False
        Me.txt申请者编号.ButtonsRight.Add(EditorButton2)
        Me.txt申请者编号.IsDigit = False
        Me.txt申请者编号.Location = New System.Drawing.Point(112, 79)
        Me.txt申请者编号.Name = "txt申请者编号"
        Me.txt申请者编号.Size = New System.Drawing.Size(86, 23)
        Me.txt申请者编号.TabIndex = 137
        '
        'txt申请者名称
        '
        Me.txt申请者名称.AutoSize = False
        Me.txt申请者名称.Enabled = False
        Me.txt申请者名称.IsDigit = False
        Me.txt申请者名称.Location = New System.Drawing.Point(198, 79)
        Me.txt申请者名称.Name = "txt申请者名称"
        Me.txt申请者名称.Size = New System.Drawing.Size(77, 23)
        Me.txt申请者名称.TabIndex = 138
        '
        'UcGridEdit1
        '
        Me.UcGridEdit1.ActiveFormFeatureCode = ""
        Me.UcGridEdit1.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.UcGridEdit1.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.BackColorFlg = True
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Appearance = Appearance19
        Appearance31.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance31
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance32.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance32
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance33.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance33
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance34.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance34
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.UcGridEdit1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UcGridEdit1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance20.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance20.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Appearance = Appearance20
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance21
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Hidden = True
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance22.BackColor2 = System.Drawing.SystemColors.Control
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.PromptAppearance = Appearance22
        Me.UcGridEdit1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcGridEdit1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance35.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.AddRowAppearance = Appearance35
        Me.UcGridEdit1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.UcGridEdit1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.UcGridEdit1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UcGridEdit1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.UcGridEdit1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance26.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.CellAppearance = Appearance26
        Me.UcGridEdit1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcGridEdit1.DisplayLayout.Override.CellPadding = 0
        Appearance27.BackColor = System.Drawing.SystemColors.Control
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.GroupByRowAppearance = Appearance27
        Appearance28.TextHAlignAsString = "Center"
        Appearance28.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.HeaderAppearance = Appearance28
        Me.UcGridEdit1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UcGridEdit1.DisplayLayout.Override.MinRowHeight = 20
        Appearance36.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.RowAlternateAppearance = Appearance36
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Override.RowAppearance = Appearance29
        Appearance37.TextHAlignAsString = "Center"
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorAppearance = Appearance37
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorWidth = 40
        Me.UcGridEdit1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance30.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance30
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.UcGridEdit1.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.UcGridEdit1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcGridEdit1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcGridEdit1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.UcGridEdit1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UcGridEdit1.FirstFocusColumnIndex = -1
        Me.UcGridEdit1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcGridEdit1.InsertColumn = ""
        Me.UcGridEdit1.InsertColumn1 = ""
        Me.UcGridEdit1.InsertColumn2 = ""
        Me.UcGridEdit1.InsertValue = ""
        Me.UcGridEdit1.IsItiranCheckBoxFlag = False
        Me.UcGridEdit1.ItiranEditFlg = False
        Me.UcGridEdit1.Location = New System.Drawing.Point(12, 159)
        Me.UcGridEdit1.MasterFlg = False
        Me.UcGridEdit1.MinHeaderHeight = 24
        Me.UcGridEdit1.MinRowHeight = 20
        Me.UcGridEdit1.Name = "UcGridEdit1"
        Me.UcGridEdit1.RowAltAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.RowAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.Size = New System.Drawing.Size(965, 521)
        Me.UcGridEdit1.TabIndex = 144
        Me.UcGridEdit1.Text = "UcGridEdit1"
        '
        'dt申请日期
        '
        Me.dt申请日期.Location = New System.Drawing.Point(111, 102)
        Me.dt申请日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请日期.Name = "dt申请日期"
        Me.dt申请日期.Size = New System.Drawing.Size(164, 21)
        Me.dt申请日期.TabIndex = 145
        '
        'btnF5行追加
        '
        Appearance39.BackColor = System.Drawing.SystemColors.Control
        Appearance39.BackColor2 = System.Drawing.SystemColors.Control
        Appearance39.TextHAlignAsString = "Center"
        Appearance39.TextVAlignAsString = "Middle"
        Me.btnF5行追加.Appearance = Appearance39
        Me.btnF5行追加.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF5行追加.FSearchButtonName = ""
        Me.btnF5行追加.Location = New System.Drawing.Point(374, 12)
        Me.btnF5行追加.Name = "btnF5行追加"
        Me.btnF5行追加.Size = New System.Drawing.Size(78, 34)
        Me.btnF5行追加.TabIndex = 146
        Me.btnF5行追加.Text = "F5:行追加"
        '
        'btnF6行删除
        '
        Appearance38.BackColor = System.Drawing.SystemColors.Control
        Appearance38.BackColor2 = System.Drawing.SystemColors.Control
        Appearance38.TextHAlignAsString = "Center"
        Appearance38.TextVAlignAsString = "Middle"
        Me.btnF6行删除.Appearance = Appearance38
        Me.btnF6行删除.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF6行删除.FSearchButtonName = ""
        Me.btnF6行删除.Location = New System.Drawing.Point(452, 12)
        Me.btnF6行删除.Name = "btnF6行删除"
        Me.btnF6行删除.Size = New System.Drawing.Size(78, 34)
        Me.btnF6行删除.TabIndex = 147
        Me.btnF6行删除.Text = "F6:行删除"
        '
        'frm成品入库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF6行删除)
        Me.Controls.Add(Me.btnF5行追加)
        Me.Controls.Add(Me.dt申请日期)
        Me.Controls.Add(Me.UcGridEdit1)
        Me.Controls.Add(Me.txt申请者编号)
        Me.Controls.Add(Me.txt申请者名称)
        Me.Controls.Add(Me.UcText1)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.供应商编号)
        Me.Controls.Add(Me.UcLabel4)
        Me.Name = "frm成品入库申请"
        Me.Text = "包装管理"
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.供应商编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.UcText1, 0)
        Me.Controls.SetChildIndex(Me.txt申请者名称, 0)
        Me.Controls.SetChildIndex(Me.txt申请者编号, 0)
        Me.Controls.SetChildIndex(Me.UcGridEdit1, 0)
        Me.Controls.SetChildIndex(Me.dt申请日期, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        CType(Me.UcText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents 供应商编号 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcText1 As UserControl.UCText
    Friend WithEvents txt申请者编号 As UserControl.UCText
    Friend WithEvents txt申请者名称 As UserControl.UCText
    Friend WithEvents UcGridEdit1 As UserControl.UCGridEdit
    Friend WithEvents dt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnF5行追加 As UserControl.UCButton
    Friend WithEvents btnF6行删除 As UserControl.UCButton
End Class
