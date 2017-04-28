<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm废料入出库一览
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("区分")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("废料产生工序")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("废料数量")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("原材料批号")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("原材料名称")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("原材料规格")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("回收日期")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt废料产生工序 = New UserControl.UCText(Me.components)
        Me.txt原材料名称 = New UserControl.UCText(Me.components)
        Me.txt原材料编号 = New UserControl.UCText(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.cob废料入出库区分 = New UserControl.UCCombo(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt回收日期止 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt回收日期起 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.gridList = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt废料产生工序, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cob废料入出库区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回收日期止, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt回收日期起, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 3
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 1
        Me.btnF2查询.Tag = "502501"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 2
        Me.btnF3选择.Tag = "502502"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt废料产生工序)
        Me.UltraGroupBox1.Controls.Add(Me.txt原材料名称)
        Me.UltraGroupBox1.Controls.Add(Me.txt原材料编号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.cob废料入出库区分)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.txt回收日期止)
        Me.UltraGroupBox1.Controls.Add(Me.txt回收日期起)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 79)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt废料产生工序
        '
        Me.txt废料产生工序.AutoSize = False
        Me.txt废料产生工序.IsDigit = False
        Me.txt废料产生工序.Location = New System.Drawing.Point(106, 43)
        Me.txt废料产生工序.Name = "txt废料产生工序"
        Me.txt废料产生工序.Size = New System.Drawing.Size(122, 22)
        Me.txt废料产生工序.TabIndex = 1
        Me.txt废料产生工序.TabStop = False
        '
        'txt原材料名称
        '
        Me.txt原材料名称.AutoSize = False
        Me.txt原材料名称.IsDigit = False
        Me.txt原材料名称.Location = New System.Drawing.Point(477, 19)
        Me.txt原材料名称.Name = "txt原材料名称"
        Me.txt原材料名称.ReadOnly = True
        Me.txt原材料名称.Size = New System.Drawing.Size(126, 23)
        Me.txt原材料名称.TabIndex = 252
        Me.txt原材料名称.TabStop = False
        '
        'txt原材料编号
        '
        Me.txt原材料编号.AutoSize = False
        Me.txt原材料编号.ButtonsRight.Add(EditorButton1)
        Me.txt原材料编号.IsDigit = False
        Me.txt原材料编号.Location = New System.Drawing.Point(377, 19)
        Me.txt原材料编号.Name = "txt原材料编号"
        Me.txt原材料编号.Size = New System.Drawing.Size(100, 23)
        Me.txt原材料编号.TabIndex = 2
        '
        'UcLabel7
        '
        Appearance45.BackColor = System.Drawing.Color.SkyBlue
        Appearance45.BackColor2 = System.Drawing.Color.White
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance45.BorderColor = System.Drawing.Color.Black
        Appearance45.BorderColor2 = System.Drawing.Color.Black
        Appearance45.TextHAlignAsString = "Left"
        Appearance45.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance45
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Location = New System.Drawing.Point(277, 20)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 251
        Me.UcLabel7.Text = "原材料名称"
        '
        'cob废料入出库区分
        '
        Me.cob废料入出库区分.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cob废料入出库区分.DisplayLayout.Appearance = Appearance19
        Me.cob废料入出库区分.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cob废料入出库区分.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.cob废料入出库区分.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob废料入出库区分.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.cob废料入出库区分.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob废料入出库区分.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.cob废料入出库区分.DisplayLayout.MaxColScrollRegions = 1
        Me.cob废料入出库区分.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cob废料入出库区分.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cob废料入出库区分.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.cob废料入出库区分.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cob废料入出库区分.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Me.cob废料入出库区分.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cob废料入出库区分.DisplayLayout.Override.CellAppearance = Appearance34
        Me.cob废料入出库区分.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cob废料入出库区分.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.cob废料入出库区分.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.cob废料入出库区分.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.cob废料入出库区分.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cob废料入出库区分.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.cob废料入出库区分.DisplayLayout.Override.RowAppearance = Appearance37
        Me.cob废料入出库区分.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cob废料入出库区分.DisplayLayout.Override.TemplateAddRowAppearance = Appearance38
        Me.cob废料入出库区分.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cob废料入出库区分.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cob废料入出库区分.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cob废料入出库区分.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cob废料入出库区分.Location = New System.Drawing.Point(106, 20)
        Me.cob废料入出库区分.Name = "cob废料入出库区分"
        Me.cob废料入出库区分.Size = New System.Drawing.Size(122, 22)
        Me.cob废料入出库区分.TabIndex = 0
        Me.cob废料入出库区分.Text = "入库"
        '
        'UcLabel8
        '
        Appearance47.BackColor = System.Drawing.Color.SkyBlue
        Appearance47.BackColor2 = System.Drawing.Color.White
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance47.BorderColor = System.Drawing.Color.Black
        Appearance47.BorderColor2 = System.Drawing.Color.Black
        Appearance47.TextHAlignAsString = "Left"
        Appearance47.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance47
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 247
        Me.UcLabel8.Text = "废料产生工序"
        '
        'UcLabel1
        '
        Appearance44.BackColor = System.Drawing.Color.SkyBlue
        Appearance44.BackColor2 = System.Drawing.Color.White
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance44.BorderColor = System.Drawing.Color.Black
        Appearance44.BorderColor2 = System.Drawing.Color.Black
        Appearance44.TextHAlignAsString = "Left"
        Appearance44.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance44
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 249
        Me.UcLabel1.Text = "废料入出库区分"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(479, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "~"
        '
        'txt回收日期止
        '
        Me.txt回收日期止.Location = New System.Drawing.Point(496, 43)
        Me.txt回收日期止.MaskInput = "yyyy/mm/dd"
        Me.txt回收日期止.Name = "txt回收日期止"
        Me.txt回收日期止.Size = New System.Drawing.Size(107, 21)
        Me.txt回收日期止.TabIndex = 4
        '
        'txt回收日期起
        '
        Me.txt回收日期起.Location = New System.Drawing.Point(377, 43)
        Me.txt回收日期起.MaskInput = "yyyy/mm/dd"
        Me.txt回收日期起.Name = "txt回收日期起"
        Me.txt回收日期起.Size = New System.Drawing.Size(100, 21)
        Me.txt回收日期起.TabIndex = 3
        '
        'UcLabel12
        '
        Appearance48.BackColor = System.Drawing.Color.SkyBlue
        Appearance48.BackColor2 = System.Drawing.Color.White
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance48.BorderColor = System.Drawing.Color.Black
        Appearance48.BorderColor2 = System.Drawing.Color.Black
        Appearance48.TextHAlignAsString = "Left"
        Appearance48.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance48
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(277, 43)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 127
        Me.UcLabel12.Text = "回收日期"
        '
        'gridList
        '
        Me.gridList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance2
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn7.CellAppearance = Appearance3
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.gridList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance10
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Me.gridList.DisplayLayout.Override.DefaultRowHeight = 20
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance12.TextHAlignAsString = "Left"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.gridList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance14
        Appearance16.TextHAlignAsString = "Center"
        Appearance16.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance16
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.gridList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.gridList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.gridList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.gridList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance17
        Me.gridList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.gridList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridList.Location = New System.Drawing.Point(12, 137)
        Me.gridList.Name = "gridList"
        Me.gridList.Size = New System.Drawing.Size(983, 543)
        Me.gridList.TabIndex = 6
        Me.gridList.Text = "UcGrid2"
        '
        'frm废料入出库一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.gridList)
        Me.KeyPreview = True
        Me.Name = "frm废料入出库一览"
        Me.Text = "废料入出库一览"
        Me.Controls.SetChildIndex(Me.gridList, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt废料产生工序, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cob废料入出库区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回收日期止, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt回收日期起, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt回收日期止 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt回收日期起 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents cob废料入出库区分 As UserControl.UCCombo
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents gridList As UserControl.UCGrid
    Friend WithEvents txt原材料名称 As UserControl.UCText
    Friend WithEvents txt原材料编号 As UserControl.UCText
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents txt废料产生工序 As UserControl.UCText
End Class
