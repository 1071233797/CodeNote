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
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量(个)")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance8})
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库重量(kg)")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.供应商编号 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt申请者编号 = New UserControl.UCText(Me.components)
        Me.txt申请者名称 = New UserControl.UCText(Me.components)
        Me.grid成品入库申请 = New UserControl.UCGridEdit(Me.components)
        Me.dt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnF5行追加 = New UserControl.UCButton(Me.components)
        Me.btnF6行删除 = New UserControl.UCButton(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt部门 = New UserControl.UCText(Me.components)
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid成品入库申请, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnF4删除.Tag = "401403"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        Me.btnF2编辑.Tag = "401401"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        Me.btnF3保存.Tag = "401402"
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
        Appearance57.BackColor = System.Drawing.Color.SkyBlue
        Appearance57.BackColor2 = System.Drawing.Color.White
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance57.BorderColor = System.Drawing.Color.Black
        Appearance57.BorderColor2 = System.Drawing.Color.Black
        Appearance57.TextHAlignAsString = "Left"
        Appearance57.TextVAlignAsString = "Middle"
        Me.供应商编号.Appearance = Appearance57
        Me.供应商编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.供应商编号.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.供应商编号.Location = New System.Drawing.Point(12, 148)
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
        'txt申请者编号
        '
        Me.txt申请者编号.AutoSize = False
        Me.txt申请者编号.ButtonsRight.Add(EditorButton1)
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
        Me.txt申请者名称.ReadOnly = True
        Me.txt申请者名称.Size = New System.Drawing.Size(77, 23)
        Me.txt申请者名称.TabIndex = 138
        '
        'grid成品入库申请
        '
        Me.grid成品入库申请.ActiveFormFeatureCode = ""
        Me.grid成品入库申请.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid成品入库申请.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid成品入库申请.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid成品入库申请.BackColorFlg = True
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance40.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid成品入库申请.DisplayLayout.Appearance = Appearance40
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance41.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance41
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance42.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance42
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance43.ForeColor = System.Drawing.Color.Black
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance43
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn3.CellButtonAppearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        Appearance8.ForeColor = System.Drawing.Color.Red
        UltraGridColumn3.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance44.ForeColor = System.Drawing.Color.Black
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance44
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn4.CellButtonAppearance = Appearance6
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.ValueBasedAppearance = ConditionValueAppearance1
        Appearance1.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance1
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.grid成品入库申请.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid成品入库申请.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid成品入库申请.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.grid成品入库申请.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid成品入库申请.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.grid成品入库申请.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid成品入库申请.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid成品入库申请.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.grid成品入库申请.DisplayLayout.MaxColScrollRegions = 1
        Me.grid成品入库申请.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.Color.White
        Me.grid成品入库申请.DisplayLayout.Override.AddRowAppearance = Appearance48
        Me.grid成品入库申请.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid成品入库申请.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid成品入库申请.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid成品入库申请.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid成品入库申请.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid成品入库申请.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Me.grid成品入库申请.DisplayLayout.Override.CardAreaAppearance = Appearance49
        Appearance50.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance50.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance50.TextVAlignAsString = "Middle"
        Me.grid成品入库申请.DisplayLayout.Override.CellAppearance = Appearance50
        Me.grid成品入库申请.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid成品入库申请.DisplayLayout.Override.CellPadding = 0
        Appearance51.BackColor = System.Drawing.SystemColors.Control
        Appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance51.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.BorderColor = System.Drawing.SystemColors.Window
        Me.grid成品入库申请.DisplayLayout.Override.GroupByRowAppearance = Appearance51
        Appearance52.TextHAlignAsString = "Center"
        Appearance52.TextVAlignAsString = "Middle"
        Me.grid成品入库申请.DisplayLayout.Override.HeaderAppearance = Appearance52
        Me.grid成品入库申请.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid成品入库申请.DisplayLayout.Override.MinRowHeight = 20
        Appearance53.BackColor = System.Drawing.Color.White
        Me.grid成品入库申请.DisplayLayout.Override.RowAlternateAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.Color.White
        Appearance54.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid成品入库申请.DisplayLayout.Override.RowAppearance = Appearance54
        Appearance55.TextHAlignAsString = "Center"
        Me.grid成品入库申请.DisplayLayout.Override.RowSelectorAppearance = Appearance55
        Me.grid成品入库申请.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid成品入库申请.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid成品入库申请.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid成品入库申请.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid成品入库申请.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance56.BackColor = System.Drawing.Color.White
        Me.grid成品入库申请.DisplayLayout.Override.TemplateAddRowAppearance = Appearance56
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid成品入库申请.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid成品入库申请.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid成品入库申请.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid成品入库申请.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid成品入库申请.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid成品入库申请.FirstFocusColumnIndex = -1
        Me.grid成品入库申请.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid成品入库申请.InsertColumn = ""
        Me.grid成品入库申请.InsertColumn1 = ""
        Me.grid成品入库申请.InsertColumn2 = ""
        Me.grid成品入库申请.InsertValue = ""
        Me.grid成品入库申请.IsItiranCheckBoxFlag = False
        Me.grid成品入库申请.ItiranEditFlg = False
        Me.grid成品入库申请.Location = New System.Drawing.Point(12, 177)
        Me.grid成品入库申请.MasterFlg = False
        Me.grid成品入库申请.MinHeaderHeight = 24
        Me.grid成品入库申请.MinRowHeight = 20
        Me.grid成品入库申请.Name = "grid成品入库申请"
        Me.grid成品入库申请.RowAltAppColor = System.Drawing.Color.White
        Me.grid成品入库申请.RowAppColor = System.Drawing.Color.White
        Me.grid成品入库申请.Size = New System.Drawing.Size(965, 503)
        Me.grid成品入库申请.TabIndex = 144
        Me.grid成品入库申请.Text = "UcGridEdit1"
        '
        'dt申请日期
        '
        Me.dt申请日期.Location = New System.Drawing.Point(112, 148)
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
        Me.btnF5行追加.Tag = "401404"
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
        Me.btnF6行删除.Tag = "401405"
        Me.btnF6行删除.Text = "F6:行删除"
        '
        'txt申请单编号
        '
        Me.txt申请单编号.AutoSize = False
        Me.txt申请单编号.Enabled = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.Size = New System.Drawing.Size(163, 23)
        Me.txt申请单编号.TabIndex = 148
        '
        'UcLabel2
        '
        Appearance58.BackColor = System.Drawing.Color.SkyBlue
        Appearance58.BackColor2 = System.Drawing.Color.White
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance58.BorderColor = System.Drawing.Color.Black
        Appearance58.BorderColor2 = System.Drawing.Color.Black
        Appearance58.TextHAlignAsString = "Left"
        Appearance58.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance58
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel2.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 149
        Me.UcLabel2.Text = "职务"
        '
        'txt职务
        '
        Me.txt职务.AutoSize = False
        Me.txt职务.Enabled = False
        Me.txt职务.IsDigit = False
        Me.txt职务.Location = New System.Drawing.Point(112, 102)
        Me.txt职务.Name = "txt职务"
        Me.txt职务.ReadOnly = True
        Me.txt职务.Size = New System.Drawing.Size(163, 23)
        Me.txt职务.TabIndex = 150
        '
        'UcLabel3
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance4
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel3.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 151
        Me.UcLabel3.Text = "部门"
        '
        'txt部门
        '
        Me.txt部门.AutoSize = False
        Me.txt部门.Enabled = False
        Me.txt部门.IsDigit = False
        Me.txt部门.Location = New System.Drawing.Point(112, 125)
        Me.txt部门.Name = "txt部门"
        Me.txt部门.ReadOnly = True
        Me.txt部门.Size = New System.Drawing.Size(163, 23)
        Me.txt部门.TabIndex = 152
        '
        'frm成品入库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt部门)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt职务)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt申请单编号)
        Me.Controls.Add(Me.btnF6行删除)
        Me.Controls.Add(Me.btnF5行追加)
        Me.Controls.Add(Me.dt申请日期)
        Me.Controls.Add(Me.grid成品入库申请)
        Me.Controls.Add(Me.txt申请者编号)
        Me.Controls.Add(Me.txt申请者名称)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.供应商编号)
        Me.Controls.Add(Me.UcLabel4)
        Me.Name = "frm成品入库申请"
        Me.Text = "成品入库申请"
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.供应商编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt申请者名称, 0)
        Me.Controls.SetChildIndex(Me.txt申请者编号, 0)
        Me.Controls.SetChildIndex(Me.grid成品入库申请, 0)
        Me.Controls.SetChildIndex(Me.dt申请日期, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.txt申请单编号, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.txt部门, 0)
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid成品入库申请, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents 供应商编号 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt申请者编号 As UserControl.UCText
    Friend WithEvents txt申请者名称 As UserControl.UCText
    Friend WithEvents grid成品入库申请 As UserControl.UCGridEdit
    Friend WithEvents dt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnF5行追加 As UserControl.UCButton
    Friend WithEvents btnF6行删除 As UserControl.UCButton
    Friend WithEvents txt申请单编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt部门 As UserControl.UCText
End Class
