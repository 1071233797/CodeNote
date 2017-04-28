<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产实绩数据一览
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业者")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业日期")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业开始时间")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业结束时间")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产图号")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("计划生产数量")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("实际生产数量")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备编号")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良品数量")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("待修品数量")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品数量")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UcGrid1 = New UserControl.UCGrid(Me.components)
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.UcLabel16 = New UserControl.UCLabel(Me.components)
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraDateTimeEditor2 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UcText2 = New UserControl.UCText(Me.components)
        Me.UcText3 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcCombo1 = New UserControl.UCCombo(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.UcText15 = New UserControl.UCText(Me.components)
        Me.UcText21 = New UserControl.UCText(Me.components)
        Me.UcText8 = New UserControl.UCText(Me.components)
        Me.UcLabel18 = New UserControl.UCLabel(Me.components)
        Me.UcText7 = New UserControl.UCText(Me.components)
        Me.UcLabel25 = New UserControl.UCLabel(Me.components)
        CType(Me.UcGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcCombo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcGrid1
        '
        Me.UcGrid1.DataMember = Nothing
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcGrid1.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.UcGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UcGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGrid1.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.UcGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.UcGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.UcGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.UcGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.UcGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UcGrid1.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.UcGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.UcGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UcGrid1.DisplayLayout.Override.CellAppearance = Appearance11
        Me.UcGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.UcGrid1.DisplayLayout.Override.CellPadding = 0
        Me.UcGrid1.DisplayLayout.Override.DefaultRowHeight = 20
        Me.UcGrid1.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance12.BackColor = System.Drawing.SystemColors.Control
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Left"
        Me.UcGrid1.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.UcGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.UcGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcGrid1.DisplayLayout.Override.RowAlternateAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.UcGrid1.DisplayLayout.Override.RowAppearance = Appearance15
        Appearance16.TextHAlignAsString = "Center"
        Appearance16.TextVAlignAsString = "Middle"
        Me.UcGrid1.DisplayLayout.Override.RowSelectorAppearance = Appearance16
        Me.UcGrid1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UcGrid1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.UcGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UcGrid1.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.UcGrid1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.UcGrid1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.UcGrid1.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.UcGrid1.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
        Me.UcGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcGrid1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.UcGrid1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcGrid1.Location = New System.Drawing.Point(12, 159)
        Me.UcGrid1.Name = "UcGrid1"
        Me.UcGrid1.Size = New System.Drawing.Size(984, 462)
        Me.UcGrid1.TabIndex = 56
        Me.UcGrid1.Text = "UcGrid1"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UcText7)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel25)
        Me.UltraGroupBox1.Controls.Add(Me.UcText8)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UcText15)
        Me.UltraGroupBox1.Controls.Add(Me.UcText21)
        Me.UltraGroupBox1.Controls.Add(Me.UcCombo1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.UcText2)
        Me.UltraGroupBox1.Controls.Add(Me.UcText3)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UltraDateTimeEditor2)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel16)
        Me.UltraGroupBox1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 101)
        Me.UltraGroupBox1.TabIndex = 55
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UcLabel16
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel16.Appearance = Appearance2
        Me.UcLabel16.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel16.Location = New System.Drawing.Point(536, 21)
        Me.UcLabel16.Name = "UcLabel16"
        Me.UcLabel16.Size = New System.Drawing.Size(86, 21)
        Me.UcLabel16.TabIndex = 207
        Me.UcLabel16.Text = "作业日期"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(622, 21)
        Me.UltraDateTimeEditor1.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(86, 21)
        Me.UltraDateTimeEditor1.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(714, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "~"
        '
        'UltraDateTimeEditor2
        '
        Me.UltraDateTimeEditor2.Location = New System.Drawing.Point(731, 21)
        Me.UltraDateTimeEditor2.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor2.Name = "UltraDateTimeEditor2"
        Me.UltraDateTimeEditor2.Size = New System.Drawing.Size(86, 21)
        Me.UltraDateTimeEditor2.TabIndex = 276
        '
        'UcText2
        '
        Me.UcText2.AutoSize = False
        Me.UcText2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcText2.Location = New System.Drawing.Point(178, 21)
        Me.UcText2.Name = "UcText2"
        Me.UcText2.ReadOnly = True
        Me.UcText2.Size = New System.Drawing.Size(108, 21)
        Me.UcText2.TabIndex = 279
        '
        'UcText3
        '
        Me.UcText3.AutoSize = False
        Me.UcText3.ButtonsRight.Add(EditorButton2)
        Me.UcText3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcText3.Location = New System.Drawing.Point(92, 21)
        Me.UcText3.Name = "UcText3"
        Me.UcText3.ReadOnly = True
        Me.UcText3.Size = New System.Drawing.Size(86, 21)
        Me.UcText3.TabIndex = 278
        '
        'UcLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.SkyBlue
        Appearance23.BackColor2 = System.Drawing.Color.White
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance23.BorderColor = System.Drawing.Color.Black
        Appearance23.BorderColor2 = System.Drawing.Color.Black
        Appearance23.TextHAlignAsString = "Left"
        Appearance23.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance23
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(86, 21)
        Me.UcLabel1.TabIndex = 277
        Me.UcLabel1.Text = "部门名称"
        '
        'UcCombo1
        '
        Me.UcCombo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UcCombo1.DisplayLayout.Appearance = Appearance43
        Me.UcCombo1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcCombo1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.UcCombo1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcCombo1.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.UcCombo1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcCombo1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UcCombo1.DisplayLayout.Override.ActiveCellAppearance = Appearance48
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UcCombo1.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.UcCombo1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UcCombo1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UcCombo1.DisplayLayout.Override.CellAppearance = Appearance22
        Me.UcCombo1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcCombo1.DisplayLayout.Override.CellPadding = 0
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.UcCombo1.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Left"
        Me.UcCombo1.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.UcCombo1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UcCombo1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.Color.Silver
        Me.UcCombo1.DisplayLayout.Override.RowAppearance = Appearance49
        Me.UcCombo1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UcCombo1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance51
        Me.UcCombo1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcCombo1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcCombo1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UcCombo1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcCombo1.Location = New System.Drawing.Point(92, 43)
        Me.UcCombo1.Name = "UcCombo1"
        Me.UcCombo1.Size = New System.Drawing.Size(86, 22)
        Me.UcCombo1.TabIndex = 281
        Me.UcCombo1.Text = "计件"
        '
        'UcLabel8
        '
        Appearance52.BackColor = System.Drawing.Color.SkyBlue
        Appearance52.BackColor2 = System.Drawing.Color.White
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance52.BorderColor = System.Drawing.Color.Black
        Appearance52.BorderColor2 = System.Drawing.Color.Black
        Appearance52.TextHAlignAsString = "Left"
        Appearance52.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance52
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(6, 43)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(86, 23)
        Me.UcLabel8.TabIndex = 280
        Me.UcLabel8.Text = "作业方式"
        '
        'UcLabel6
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance4
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel6.Location = New System.Drawing.Point(536, 65)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(86, 21)
        Me.UcLabel6.TabIndex = 284
        Me.UcLabel6.Text = "生产图号"
        '
        'UcText15
        '
        Me.UcText15.AutoSize = False
        Me.UcText15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcText15.Location = New System.Drawing.Point(790, 65)
        Me.UcText15.Name = "UcText15"
        Me.UcText15.ReadOnly = True
        Me.UcText15.Size = New System.Drawing.Size(149, 21)
        Me.UcText15.TabIndex = 283
        '
        'UcText21
        '
        Me.UcText21.AutoSize = False
        Me.UcText21.ButtonsRight.Add(EditorButton1)
        Me.UcText21.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcText21.Location = New System.Drawing.Point(622, 65)
        Me.UcText21.Name = "UcText21"
        Me.UcText21.ReadOnly = True
        Me.UcText21.Size = New System.Drawing.Size(168, 21)
        Me.UcText21.TabIndex = 282
        '
        'UcText8
        '
        Me.UcText8.AutoSize = False
        Me.UcText8.Location = New System.Drawing.Point(92, 67)
        Me.UcText8.Name = "UcText8"
        Me.UcText8.ReadOnly = True
        Me.UcText8.Size = New System.Drawing.Size(168, 21)
        Me.UcText8.TabIndex = 286
        '
        'UcLabel18
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel18.Appearance = Appearance5
        Me.UcLabel18.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel18.Location = New System.Drawing.Point(6, 67)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Size = New System.Drawing.Size(86, 21)
        Me.UcLabel18.TabIndex = 285
        Me.UcLabel18.Text = "作业者"
        '
        'UcText7
        '
        Me.UcText7.AutoSize = False
        Me.UcText7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcText7.Location = New System.Drawing.Point(622, 43)
        Me.UcText7.Name = "UcText7"
        Me.UcText7.ReadOnly = True
        Me.UcText7.Size = New System.Drawing.Size(168, 21)
        Me.UcText7.TabIndex = 288
        '
        'UcLabel25
        '
        Appearance42.BackColor = System.Drawing.Color.SkyBlue
        Appearance42.BackColor2 = System.Drawing.Color.White
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance42.BorderColor = System.Drawing.Color.Black
        Appearance42.BorderColor2 = System.Drawing.Color.Black
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UcLabel25.Appearance = Appearance42
        Me.UcLabel25.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel25.Location = New System.Drawing.Point(536, 43)
        Me.UcLabel25.Name = "UcLabel25"
        Me.UcLabel25.Size = New System.Drawing.Size(86, 21)
        Me.UcLabel25.TabIndex = 287
        Me.UcLabel25.Text = "订单编号"
        '
        'frm生产实绩数据一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcGrid1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm生产实绩数据一览"
        Me.Text = "生产数据一览"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UcGrid1, 0)
        CType(Me.UcGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcCombo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcGrid1 As UserControl.UCGrid
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel16 As UserControl.UCLabel
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditor2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcText2 As UserControl.UCText
    Friend WithEvents UcText3 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcCombo1 As UserControl.UCCombo
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents UcText15 As UserControl.UCText
    Friend WithEvents UcText21 As UserControl.UCText
    Friend WithEvents UcText8 As UserControl.UCText
    Friend WithEvents UcLabel18 As UserControl.UCLabel
    Friend WithEvents UcText7 As UserControl.UCText
    Friend WithEvents UcLabel25 As UserControl.UCLabel
End Class

