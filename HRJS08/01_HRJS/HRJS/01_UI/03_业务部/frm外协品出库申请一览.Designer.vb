<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协品出库申请一览

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
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请单编号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请者")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("职务")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("部门")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请日期")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作成者")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请单编号")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协品名称")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请数量(个)")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.gridList = New UserControl.UCGrid(Me.components)
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        Me.dt申请结束日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.dt申请开始日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt申请者名称 = New UserControl.UCText(Me.components)
        Me.txt申请者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.btnF11出库申请单打印 = New UserControl.UCButton(Me.components)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请结束日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请开始日期, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnF2查询.Tag = "502901"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        Me.btnF3选择.Tag = "502902"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'gridList
        '
        Me.gridList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance125.BackColor = System.Drawing.Color.LightGray
        Appearance125.BorderColor = System.Drawing.Color.Silver
        Appearance125.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Appearance = Appearance125
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 131
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance126.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance126
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 5
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 7
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance127.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance127.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance127.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance127
        Appearance128.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance128
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance129.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance129.BackColor2 = System.Drawing.SystemColors.Control
        Appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance129.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance129
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance130.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance130.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveCellAppearance = Appearance130
        Appearance131.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance131.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveRowAppearance = Appearance131
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.gridList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance132.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance132
        Appearance133.BorderColor = System.Drawing.Color.Silver
        Appearance133.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance133
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Me.gridList.DisplayLayout.Override.DefaultRowHeight = 20
        Me.gridList.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance134.BackColor = System.Drawing.SystemColors.Control
        Appearance134.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance134.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance134.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance134.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance134
        Appearance135.TextHAlignAsString = "Left"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance135
        Me.gridList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance136.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance136
        Appearance137.BackColor = System.Drawing.SystemColors.Window
        Appearance137.BorderColor = System.Drawing.Color.Silver
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance137
        Appearance138.TextHAlignAsString = "Center"
        Appearance138.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance138
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.gridList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.gridList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.gridList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.gridList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance139.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance139
        Me.gridList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.gridList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridList.Location = New System.Drawing.Point(12, 133)
        Me.gridList.Name = "gridList"
        Me.gridList.Size = New System.Drawing.Size(983, 547)
        Me.gridList.TabIndex = 1
        Me.gridList.Text = "UcGrid2"
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UcGroupBox1.Controls.Add(Me.txt申请单编号)
        Me.UcGroupBox1.Controls.Add(Me.dt申请结束日期)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UcGroupBox1.Controls.Add(Me.dt申请开始日期)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UcGroupBox1.Controls.Add(Me.txt申请者名称)
        Me.UcGroupBox1.Controls.Add(Me.txt申请者编号)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 75)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Location = New System.Drawing.Point(539, 27)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(23, 18)
        Me.UltraLabel3.TabIndex = 474
        Me.UltraLabel3.Text = "～"
        '
        'txt申请单编号
        '
        Me.txt申请单编号.AutoSize = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(106, 21)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.Size = New System.Drawing.Size(163, 23)
        Me.txt申请单编号.TabIndex = 469
        '
        'dt申请结束日期
        '
        Me.dt申请结束日期.Location = New System.Drawing.Point(560, 23)
        Me.dt申请结束日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请结束日期.Name = "dt申请结束日期"
        Me.dt申请结束日期.Size = New System.Drawing.Size(100, 21)
        Me.dt申请结束日期.TabIndex = 4
        '
        'UcLabel3
        '
        Appearance16.BackColor = System.Drawing.Color.SkyBlue
        Appearance16.BackColor2 = System.Drawing.Color.White
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance16.BorderColor = System.Drawing.Color.Black
        Appearance16.BorderColor2 = System.Drawing.Color.Black
        Appearance16.TextHAlignAsString = "Left"
        Appearance16.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance16
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(333, 23)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 468
        Me.UcLabel3.Text = "申请日期"
        '
        'dt申请开始日期
        '
        Me.dt申请开始日期.Location = New System.Drawing.Point(433, 23)
        Me.dt申请开始日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请开始日期.Name = "dt申请开始日期"
        Me.dt申请开始日期.Size = New System.Drawing.Size(100, 21)
        Me.dt申请开始日期.TabIndex = 3
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
        'txt申请者名称
        '
        Me.txt申请者名称.AutoSize = False
        Me.txt申请者名称.IsDigit = False
        Me.txt申请者名称.Location = New System.Drawing.Point(184, 44)
        Me.txt申请者名称.Name = "txt申请者名称"
        Me.txt申请者名称.ReadOnly = True
        Me.txt申请者名称.Size = New System.Drawing.Size(85, 23)
        Me.txt申请者名称.TabIndex = 2
        '
        'txt申请者编号
        '
        Me.txt申请者编号.AutoSize = False
        Me.txt申请者编号.ButtonsRight.Add(EditorButton1)
        Me.txt申请者编号.IsDigit = False
        Me.txt申请者编号.Location = New System.Drawing.Point(106, 44)
        Me.txt申请者编号.Name = "txt申请者编号"
        Me.txt申请者编号.Size = New System.Drawing.Size(78, 23)
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
        'btnF11出库申请单打印
        '
        Me.btnF11出库申请单打印.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.TextHAlignAsString = "Center"
        Appearance17.TextVAlignAsString = "Middle"
        Me.btnF11出库申请单打印.Appearance = Appearance17
        Me.btnF11出库申请单打印.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11出库申请单打印.FSearchButtonName = ""
        Me.btnF11出库申请单打印.Location = New System.Drawing.Point(831, 13)
        Me.btnF11出库申请单打印.Name = "btnF11出库申请单打印"
        Me.btnF11出库申请单打印.Size = New System.Drawing.Size(79, 33)
        Me.btnF11出库申请单打印.TabIndex = 5
        Me.btnF11出库申请单打印.Tag = "502903"
        Me.btnF11出库申请单打印.Text = "F11:出库申请单打印"
        '
        'frm外协品出库申请一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF11出库申请单打印)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm外协品出库申请一览"
        Me.Text = "外协品出库申请一览"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        Me.Controls.SetChildIndex(Me.btnF11出库申请单打印, 0)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请结束日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请开始日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请者编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridList As UserControl.UCGrid
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents dt申请结束日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents dt申请开始日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt申请者名称 As UserControl.UCText
    Friend WithEvents txt申请者编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents btnF11出库申请单打印 As UserControl.UCButton
    Friend WithEvents txt申请单编号 As UserControl.UCText
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
End Class
