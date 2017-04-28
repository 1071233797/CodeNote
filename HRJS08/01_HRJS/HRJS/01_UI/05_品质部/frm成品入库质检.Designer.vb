<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm成品入库质检

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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance2})
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查内容")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查数量")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良数量")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良原因")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理结果")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.grid成品入库质检 = New UserControl.UCGridEdit(Me.components)
        Me.txt入库申请单编号 = New UserControl.UCText(Me.components)
        Me.txt检查者名称 = New UserControl.UCText(Me.components)
        Me.txt检查者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.txt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt申请者名称 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        CType(Me.grid成品入库质检, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入库申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 7
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 3
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 5
        Me.btnF4删除.Tag = "3000703"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.Tag = "3000701"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 4
        Me.btnF3保存.Tag = "3000702"
        '
        'UcLabel3
        '
        Appearance12.BackColor = System.Drawing.Color.SkyBlue
        Appearance12.BackColor2 = System.Drawing.Color.White
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance12.BorderColor = System.Drawing.Color.Black
        Appearance12.BorderColor2 = System.Drawing.Color.Black
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance12
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel3.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 190
        Me.UcLabel3.Text = "*入库申请单"
        '
        'grid成品入库质检
        '
        Me.grid成品入库质检.ActiveFormFeatureCode = ""
        Me.grid成品入库质检.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid成品入库质检.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid成品入库质检.BackColorFlg = True
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance27.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid成品入库质检.DisplayLayout.Appearance = Appearance27
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance28
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.TabStop = False
        Appearance1.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance29.ForeColor = System.Drawing.Color.Black
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance29
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn3.TabStop = False
        Appearance2.ForeColor = System.Drawing.Color.Red
        UltraGridColumn3.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance30.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance30
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance44.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance44
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn5.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn5.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance45.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance45
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn6.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance46.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance46
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance47.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance47
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance48.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance48
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.grid成品入库质检.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid成品入库质检.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid成品入库质检.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.grid成品入库质检.DisplayLayout.GroupByBox.Appearance = Appearance49
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid成品入库质检.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance50
        Me.grid成品入库质检.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid成品入库质检.DisplayLayout.GroupByBox.Hidden = True
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance51.BackColor2 = System.Drawing.SystemColors.Control
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid成品入库质检.DisplayLayout.GroupByBox.PromptAppearance = Appearance51
        Me.grid成品入库质检.DisplayLayout.MaxColScrollRegions = 1
        Me.grid成品入库质检.DisplayLayout.MaxRowScrollRegions = 1
        Appearance52.BackColor = System.Drawing.Color.White
        Me.grid成品入库质检.DisplayLayout.Override.AddRowAppearance = Appearance52
        Me.grid成品入库质检.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid成品入库质检.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid成品入库质检.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid成品入库质检.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid成品入库质检.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid成品入库质检.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Me.grid成品入库质检.DisplayLayout.Override.CardAreaAppearance = Appearance53
        Appearance55.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance55.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance55.TextVAlignAsString = "Middle"
        Me.grid成品入库质检.DisplayLayout.Override.CellAppearance = Appearance55
        Me.grid成品入库质检.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid成品入库质检.DisplayLayout.Override.CellPadding = 0
        Appearance56.BackColor = System.Drawing.SystemColors.Control
        Appearance56.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance56.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance56.BorderColor = System.Drawing.SystemColors.Window
        Me.grid成品入库质检.DisplayLayout.Override.GroupByRowAppearance = Appearance56
        Appearance57.TextHAlignAsString = "Center"
        Appearance57.TextVAlignAsString = "Middle"
        Me.grid成品入库质检.DisplayLayout.Override.HeaderAppearance = Appearance57
        Me.grid成品入库质检.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid成品入库质检.DisplayLayout.Override.MinRowHeight = 20
        Appearance58.BackColor = System.Drawing.Color.White
        Me.grid成品入库质检.DisplayLayout.Override.RowAlternateAppearance = Appearance58
        Appearance59.BackColor = System.Drawing.Color.White
        Appearance59.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid成品入库质检.DisplayLayout.Override.RowAppearance = Appearance59
        Appearance60.TextHAlignAsString = "Center"
        Me.grid成品入库质检.DisplayLayout.Override.RowSelectorAppearance = Appearance60
        Me.grid成品入库质检.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid成品入库质检.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid成品入库质检.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid成品入库质检.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid成品入库质检.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance61.BackColor = System.Drawing.Color.White
        Me.grid成品入库质检.DisplayLayout.Override.TemplateAddRowAppearance = Appearance61
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid成品入库质检.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid成品入库质检.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid成品入库质检.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid成品入库质检.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid成品入库质检.FirstFocusColumnIndex = -1
        Me.grid成品入库质检.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid成品入库质检.InsertColumn = ""
        Me.grid成品入库质检.InsertColumn1 = ""
        Me.grid成品入库质检.InsertColumn2 = ""
        Me.grid成品入库质检.InsertValue = ""
        Me.grid成品入库质检.IsItiranCheckBoxFlag = False
        Me.grid成品入库质检.ItiranEditFlg = False
        Me.grid成品入库质检.Location = New System.Drawing.Point(12, 108)
        Me.grid成品入库质检.MasterFlg = False
        Me.grid成品入库质检.MinHeaderHeight = 24
        Me.grid成品入库质检.MinRowHeight = 20
        Me.grid成品入库质检.Name = "grid成品入库质检"
        Me.grid成品入库质检.RowAltAppColor = System.Drawing.Color.White
        Me.grid成品入库质检.RowAppColor = System.Drawing.Color.White
        Me.grid成品入库质检.Size = New System.Drawing.Size(984, 556)
        Me.grid成品入库质检.TabIndex = 2
        Me.grid成品入库质检.Text = "UcGridEdit1"
        '
        'txt入库申请单编号
        '
        Me.txt入库申请单编号.AutoSize = False
        Me.txt入库申请单编号.ButtonsRight.Add(EditorButton1)
        Me.txt入库申请单编号.IsDigit = False
        Me.txt入库申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt入库申请单编号.Name = "txt入库申请单编号"
        Me.txt入库申请单编号.Size = New System.Drawing.Size(168, 23)
        Me.txt入库申请单编号.TabIndex = 0
        '
        'txt检查者名称
        '
        Me.txt检查者名称.AutoSize = False
        Me.txt检查者名称.IsDigit = False
        Me.txt检查者名称.Location = New System.Drawing.Point(187, 79)
        Me.txt检查者名称.Name = "txt检查者名称"
        Me.txt检查者名称.ReadOnly = True
        Me.txt检查者名称.Size = New System.Drawing.Size(93, 23)
        Me.txt检查者名称.TabIndex = 422
        '
        'txt检查者编号
        '
        Me.txt检查者编号.AutoSize = False
        Me.txt检查者编号.ButtonsRight.Add(EditorButton2)
        Me.txt检查者编号.IsDigit = False
        Me.txt检查者编号.Location = New System.Drawing.Point(112, 79)
        Me.txt检查者编号.Name = "txt检查者编号"
        Me.txt检查者编号.Size = New System.Drawing.Size(75, 23)
        Me.txt检查者编号.TabIndex = 1
        '
        'UcLabel1
        '
        Appearance54.BackColor = System.Drawing.Color.SkyBlue
        Appearance54.BackColor2 = System.Drawing.Color.White
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance54.BorderColor = System.Drawing.Color.Black
        Appearance54.BorderColor2 = System.Drawing.Color.Black
        Appearance54.TextHAlignAsString = "Left"
        Appearance54.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance54
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 420
        Me.UcLabel1.Text = "检查者"
        '
        'UcLabel12
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance15
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(375, 81)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(102, 23)
        Me.UcLabel12.TabIndex = 430
        Me.UcLabel12.Text = "申请日期"
        '
        'txt申请日期
        '
        Me.txt申请日期.Location = New System.Drawing.Point(475, 82)
        Me.txt申请日期.MaskInput = "yyyy/mm/dd"
        Me.txt申请日期.Name = "txt申请日期"
        Me.txt申请日期.Size = New System.Drawing.Size(93, 21)
        Me.txt申请日期.TabIndex = 431
        '
        'txt申请者名称
        '
        Me.txt申请者名称.AutoSize = False
        Me.txt申请者名称.IsDigit = False
        Me.txt申请者名称.Location = New System.Drawing.Point(477, 57)
        Me.txt申请者名称.Name = "txt申请者名称"
        Me.txt申请者名称.ReadOnly = True
        Me.txt申请者名称.Size = New System.Drawing.Size(93, 23)
        Me.txt申请者名称.TabIndex = 429
        '
        'UcLabel2
        '
        Appearance17.BackColor = System.Drawing.Color.SkyBlue
        Appearance17.BackColor2 = System.Drawing.Color.White
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance17.BorderColor = System.Drawing.Color.Black
        Appearance17.BorderColor2 = System.Drawing.Color.Black
        Appearance17.TextHAlignAsString = "Left"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance17
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel2.Location = New System.Drawing.Point(375, 58)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(102, 23)
        Me.UcLabel2.TabIndex = 428
        Me.UcLabel2.Text = "申请者"
        '
        'frm成品入库质检
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcLabel12)
        Me.Controls.Add(Me.txt申请日期)
        Me.Controls.Add(Me.txt申请者名称)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt检查者名称)
        Me.Controls.Add(Me.txt检查者编号)
        Me.Controls.Add(Me.grid成品入库质检)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt入库申请单编号)
        Me.Name = "frm成品入库质检"
        Me.Text = "成品入库质检"
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.txt入库申请单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.grid成品入库质检, 0)
        Me.Controls.SetChildIndex(Me.txt检查者编号, 0)
        Me.Controls.SetChildIndex(Me.txt检查者名称, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt申请者名称, 0)
        Me.Controls.SetChildIndex(Me.txt申请日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel12, 0)
        CType(Me.grid成品入库质检, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入库申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents grid成品入库质检 As UserControl.UCGridEdit
    Friend WithEvents txt入库申请单编号 As UserControl.UCText
    Friend WithEvents txt检查者名称 As UserControl.UCText
    Friend WithEvents txt检查者编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt申请者名称 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel


End Class
