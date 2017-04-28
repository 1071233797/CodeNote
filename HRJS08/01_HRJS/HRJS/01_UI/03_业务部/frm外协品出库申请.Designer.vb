<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协品出库申请

    Inherits InheritsBusinessForm

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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协品名称")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协工序")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("出库数量")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("keychar")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序编号")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.gridList = New UserControl.UCGridEdit(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.dt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt人员名称 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt部门 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.lab备注 = New UserControl.UCLabel(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 19
        '
        'btnF11
        '
        Me.btnF11.TabIndex = 18
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 11
        Me.btnF4删除.Tag = "502803"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 10
        Me.btnF3保存.Tag = "502802"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 9
        Me.btnF2编辑.Tag = "502801"
        '
        'labModel
        '
        Me.labModel.TabIndex = 12
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 8
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 17
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 16
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 15
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 13
        Me.btnF6行删除.Tag = "502805"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 12
        Me.btnF5行追加.Tag = "502804"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 14
        '
        'gridList
        '
        Me.gridList.ActiveFormFeatureCode = ""
        Me.gridList.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.gridList.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridList.BackColorFlg = True
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gridList.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn1.TabStop = False
        UltraGridColumn1.Width = 155
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance6
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.TabStop = False
        UltraGridColumn2.Width = 127
        Appearance27.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance27
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance8
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance9
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridColumn5.Width = 153
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance10
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.ForeColor = System.Drawing.Color.Black
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance11
        UltraGridColumn7.Header.VisiblePosition = 5
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Width = 167
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance12
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance13.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance13.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance13
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance14
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.GroupByBox.Hidden = True
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.AddRowAppearance = Appearance17
        Me.gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.gridList.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance20.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance20
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Center"
        Appearance22.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridList.DisplayLayout.Override.MinRowHeight = 20
        Appearance23.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance23
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Center"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance25
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSelectorWidth = 40
        Me.gridList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance26.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance26
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.gridList.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.gridList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.gridList.FirstFocusColumnIndex = -1
        Me.gridList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridList.InsertColumn = ""
        Me.gridList.InsertColumn1 = ""
        Me.gridList.InsertColumn2 = ""
        Me.gridList.InsertValue = ""
        Me.gridList.IsItiranCheckBoxFlag = False
        Me.gridList.ItiranEditFlg = False
        Me.gridList.Location = New System.Drawing.Point(12, 177)
        Me.gridList.MasterFlg = False
        Me.gridList.MinHeaderHeight = 24
        Me.gridList.MinRowHeight = 20
        Me.gridList.Name = "gridList"
        Me.gridList.RowAltAppColor = System.Drawing.Color.White
        Me.gridList.RowAppColor = System.Drawing.Color.White
        Me.gridList.Size = New System.Drawing.Size(984, 503)
        Me.gridList.TabIndex = 7
        Me.gridList.Text = "UcGridEdit1"
        '
        'UcLabel5
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance5
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel5.Location = New System.Drawing.Point(12, 148)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 9
        Me.UcLabel5.Text = "申请日期"
        '
        'dt申请日期
        '
        Me.dt申请日期.Location = New System.Drawing.Point(112, 149)
        Me.dt申请日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请日期.Name = "dt申请日期"
        Me.dt申请日期.Size = New System.Drawing.Size(158, 22)
        Me.dt申请日期.TabIndex = 5
        '
        'txt人员名称
        '
        Me.txt人员名称.AutoSize = False
        Me.txt人员名称.Enabled = False
        Me.txt人员名称.IsDigit = False
        Me.txt人员名称.Location = New System.Drawing.Point(174, 79)
        Me.txt人员名称.Name = "txt人员名称"
        Me.txt人员名称.ReadOnly = True
        Me.txt人员名称.Size = New System.Drawing.Size(96, 23)
        Me.txt人员名称.TabIndex = 2
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(112, 79)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(62, 23)
        Me.txt人员编号.TabIndex = 1
        '
        'UcLabel2
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance3
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel2.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 5
        Me.UcLabel2.Text = "职务"
        '
        'txt职务
        '
        Me.txt职务.AutoSize = False
        Me.txt职务.Enabled = False
        Me.txt职务.IsDigit = False
        Me.txt职务.Location = New System.Drawing.Point(112, 102)
        Me.txt职务.Name = "txt职务"
        Me.txt职务.Size = New System.Drawing.Size(158, 23)
        Me.txt职务.TabIndex = 3
        '
        'UcLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance1
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 7
        Me.UcLabel1.Text = "部门"
        '
        'txt部门
        '
        Me.txt部门.AutoSize = False
        Me.txt部门.Enabled = False
        Me.txt部门.IsDigit = False
        Me.txt部门.Location = New System.Drawing.Point(112, 125)
        Me.txt部门.Name = "txt部门"
        Me.txt部门.Size = New System.Drawing.Size(158, 23)
        Me.txt部门.TabIndex = 4
        '
        'UcLabel17
        '
        Appearance7.BackColor = System.Drawing.Color.SkyBlue
        Appearance7.BackColor2 = System.Drawing.Color.White
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.BorderColor2 = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance7
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel17.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 2
        Me.UcLabel17.Text = "*申请者"
        '
        'UcLabel9
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance15
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel9.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 0
        Me.UcLabel9.Text = "*申请单编号"
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(374, 149)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(279, 23)
        Me.txt备注.TabIndex = 6
        '
        'lab备注
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.lab备注.Appearance = Appearance18
        Me.lab备注.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lab备注.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lab备注.Location = New System.Drawing.Point(274, 149)
        Me.lab备注.Name = "lab备注"
        Me.lab备注.Size = New System.Drawing.Size(100, 23)
        Me.lab备注.TabIndex = 7
        Me.lab备注.Text = "备注"
        '
        'txt申请单编号
        '
        Me.txt申请单编号.AutoSize = False
        Me.txt申请单编号.Enabled = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.Size = New System.Drawing.Size(158, 23)
        Me.txt申请单编号.TabIndex = 20
        '
        'frm外协品出库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt申请单编号)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.dt申请日期)
        Me.Controls.Add(Me.txt人员名称)
        Me.Controls.Add(Me.txt人员编号)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt职务)
        Me.Controls.Add(Me.lab备注)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.txt部门)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel9)
        Me.KeyPreview = True
        Me.Name = "frm外协品出库申请"
        Me.Text = "外协品出库申请"
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt部门, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.lab备注, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt人员编号, 0)
        Me.Controls.SetChildIndex(Me.txt人员名称, 0)
        Me.Controls.SetChildIndex(Me.dt申请日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.txt申请单编号, 0)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridList As UserControl.UCGridEdit
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents dt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt人员名称 As UserControl.UCText
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt部门 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents lab备注 As UserControl.UCLabel
    Friend WithEvents txt申请单编号 As UserControl.UCText
End Class
