<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm成品入库申请一览
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请单编号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请者")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("职务")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("部门")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请日期")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请单编号")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量(个)")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance1})
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库重量(kg)")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("质检状态")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.gridlist = New UserControl.UCGrid(Me.components)
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb质检状态 = New UserControl.UCCombo(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.dmt申请日期end = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.dmt申请日期sta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        Me.txt申请者名称 = New UserControl.UCText(Me.components)
        Me.txt申请者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.btn11 = New UserControl.UCButton(Me.components)
        CType(Me.gridlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.cmb质检状态, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt申请日期end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt申请日期sta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 6
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 3
        Me.btnF2查询.Tag = "401501"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        Me.btnF3选择.Tag = "401502"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'gridlist
        '
        Me.gridlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.BackColor = System.Drawing.Color.LightGray
        Appearance2.BorderColor = System.Drawing.Color.Silver
        Appearance2.TextVAlignAsString = "Middle"
        Me.gridlist.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 131
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance3
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        Appearance1.ForeColor = System.Drawing.Color.Red
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.Width = 112
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.gridlist.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridlist.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridlist.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridlist.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.gridlist.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridlist.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.gridlist.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridlist.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.gridlist.DisplayLayout.MaxColScrollRegions = 1
        Me.gridlist.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.gridlist.DisplayLayout.Override.ActiveCellAppearance = Appearance10
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.gridlist.DisplayLayout.Override.ActiveRowAppearance = Appearance11
        Me.gridlist.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridlist.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridlist.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.gridlist.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridlist.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.gridlist.DisplayLayout.Override.CardAreaAppearance = Appearance12
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridlist.DisplayLayout.Override.CellAppearance = Appearance13
        Me.gridlist.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.gridlist.DisplayLayout.Override.CellPadding = 0
        Me.gridlist.DisplayLayout.Override.DefaultRowHeight = 20
        Me.gridlist.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.gridlist.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance16.TextHAlignAsString = "Left"
        Me.gridlist.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.gridlist.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.gridlist.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridlist.DisplayLayout.Override.RowAlternateAppearance = Appearance18
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.gridlist.DisplayLayout.Override.RowAppearance = Appearance19
        Appearance21.TextHAlignAsString = "Center"
        Appearance21.TextVAlignAsString = "Middle"
        Me.gridlist.DisplayLayout.Override.RowSelectorAppearance = Appearance21
        Me.gridlist.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridlist.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridlist.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridlist.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.gridlist.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.gridlist.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.gridlist.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.gridlist.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridlist.DisplayLayout.Override.TemplateAddRowAppearance = Appearance22
        Me.gridlist.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridlist.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridlist.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.gridlist.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridlist.Location = New System.Drawing.Point(12, 138)
        Me.gridlist.Name = "gridlist"
        Me.gridlist.Size = New System.Drawing.Size(983, 529)
        Me.gridlist.TabIndex = 1
        Me.gridlist.Text = "UcGrid2"
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.Label1)
        Me.UcGroupBox1.Controls.Add(Me.cmb质检状态)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel8)
        Me.UcGroupBox1.Controls.Add(Me.dmt申请日期end)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UcGroupBox1.Controls.Add(Me.dmt申请日期sta)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UcGroupBox1.Controls.Add(Me.txt申请单编号)
        Me.UcGroupBox1.Controls.Add(Me.txt申请者名称)
        Me.UcGroupBox1.Controls.Add(Me.txt申请者编号)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 80)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(550, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 493
        Me.Label1.Text = "~"
        '
        'cmb质检状态
        '
        Me.cmb质检状态.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Appearance20.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb质检状态.DisplayLayout.Appearance = Appearance20
        Me.cmb质检状态.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb质检状态.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb质检状态.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb质检状态.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.cmb质检状态.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb质检状态.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.cmb质检状态.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb质检状态.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb质检状态.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb质检状态.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.cmb质检状态.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb质检状态.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Me.cmb质检状态.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb质检状态.DisplayLayout.Override.CellAppearance = Appearance34
        Me.cmb质检状态.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb质检状态.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb质检状态.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.cmb质检状态.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.cmb质检状态.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb质检状态.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.cmb质检状态.DisplayLayout.Override.RowAppearance = Appearance37
        Me.cmb质检状态.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb质检状态.DisplayLayout.Override.TemplateAddRowAppearance = Appearance38
        Me.cmb质检状态.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb质检状态.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb质检状态.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb质检状态.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cmb质检状态.Location = New System.Drawing.Point(447, 43)
        Me.cmb质检状态.Name = "cmb质检状态"
        Me.cmb质检状态.Size = New System.Drawing.Size(100, 22)
        Me.cmb质检状态.TabIndex = 5
        Me.cmb质检状态.Text = "已质检"
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
        Me.UcLabel8.Location = New System.Drawing.Point(347, 44)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 492
        Me.UcLabel8.Text = "质检状态"
        '
        'dmt申请日期end
        '
        Me.dmt申请日期end.Location = New System.Drawing.Point(566, 21)
        Me.dmt申请日期end.MaskInput = "yyyy/mm/dd"
        Me.dmt申请日期end.Name = "dmt申请日期end"
        Me.dmt申请日期end.Size = New System.Drawing.Size(100, 21)
        Me.dmt申请日期end.TabIndex = 4
        '
        'UcLabel3
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance5
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(347, 21)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 468
        Me.UcLabel3.Text = "申请日期"
        '
        'dmt申请日期sta
        '
        Me.dmt申请日期sta.Location = New System.Drawing.Point(447, 21)
        Me.dmt申请日期sta.MaskInput = "yyyy/mm/dd"
        Me.dmt申请日期sta.Name = "dmt申请日期sta"
        Me.dmt申请日期sta.Size = New System.Drawing.Size(100, 21)
        Me.dmt申请日期sta.TabIndex = 3
        '
        'UcLabel1
        '
        Appearance58.BackColor = System.Drawing.Color.SkyBlue
        Appearance58.BackColor2 = System.Drawing.Color.White
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance58.BorderColor = System.Drawing.Color.Black
        Appearance58.BorderColor2 = System.Drawing.Color.Black
        Appearance58.TextHAlignAsString = "Left"
        Appearance58.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance58
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 466
        Me.UcLabel1.Text = "申请单编号"
        '
        'txt申请单编号
        '
        Me.txt申请单编号.AutoSize = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(106, 21)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.Size = New System.Drawing.Size(162, 23)
        Me.txt申请单编号.TabIndex = 0
        '
        'txt申请者名称
        '
        Me.txt申请者名称.AutoSize = False
        Me.txt申请者名称.IsDigit = False
        Me.txt申请者名称.Location = New System.Drawing.Point(176, 44)
        Me.txt申请者名称.Name = "txt申请者名称"
        Me.txt申请者名称.ReadOnly = True
        Me.txt申请者名称.Size = New System.Drawing.Size(92, 23)
        Me.txt申请者名称.TabIndex = 2
        '
        'txt申请者编号
        '
        Me.txt申请者编号.AutoSize = False
        Me.txt申请者编号.ButtonsRight.Add(EditorButton1)
        Me.txt申请者编号.IsDigit = False
        Me.txt申请者编号.Location = New System.Drawing.Point(106, 44)
        Me.txt申请者编号.Name = "txt申请者编号"
        Me.txt申请者编号.Size = New System.Drawing.Size(70, 23)
        Me.txt申请者编号.TabIndex = 1
        '
        'UcLabel2
        '
        Appearance43.BackColor = System.Drawing.Color.SkyBlue
        Appearance43.BackColor2 = System.Drawing.Color.White
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance43.BorderColor = System.Drawing.Color.Black
        Appearance43.BorderColor2 = System.Drawing.Color.Black
        Appearance43.TextHAlignAsString = "Left"
        Appearance43.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance43
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 208
        Me.UcLabel2.Text = "申请者"
        '
        'btn11
        '
        Me.btn11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.TextHAlignAsString = "Center"
        Appearance17.TextVAlignAsString = "Middle"
        Me.btn11.Appearance = Appearance17
        Me.btn11.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btn11.FSearchButtonName = ""
        Me.btn11.Location = New System.Drawing.Point(834, 12)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(79, 33)
        Me.btn11.TabIndex = 5
        Me.btn11.Tag = "401503"
        Me.btn11.Text = "F11:入库申请单打印"
        '
        'frm成品入库申请一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.gridlist)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm成品入库申请一览"
        Me.Text = "成品入库申请一览"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gridlist, 0)
        Me.Controls.SetChildIndex(Me.btn11, 0)
        CType(Me.gridlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.cmb质检状态, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt申请日期end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt申请日期sta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridlist As UserControl.UCGrid
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents dmt申请日期end As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents dmt申请日期sta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt申请者名称 As UserControl.UCText
    Friend WithEvents txt申请者编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents cmb质检状态 As UserControl.UCCombo
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents btn11 As UserControl.UCButton
    Friend WithEvents txt申请单编号 As UserControl.UCText
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
