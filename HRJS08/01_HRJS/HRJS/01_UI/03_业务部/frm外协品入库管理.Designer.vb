<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协品入库管理
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("质检状态")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协名称")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("流转票编号")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协加工数量（个）")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协对象")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("回厂日期")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请者")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.txt确认者名称 = New UserControl.UCText(Me.components)
        Me.txt确认者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt检查者名称 = New UserControl.UCText(Me.components)
        Me.txt检查者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt外协订单编号 = New UserControl.UCText(Me.components)
        Me.gridList = New UserControl.UCGridEdit(Me.components)
        CType(Me.txt确认者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt确认者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外协订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF11
        '
        Me.btnF11.Text = "F11:申请质检"
        '
        'btnF6行删除
        '
        Me.btnF6行删除.Text = "F6:直接入库"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.Text = "F5:行删除"
        '
        'txt确认者名称
        '
        Me.txt确认者名称.AutoSize = False
        Me.txt确认者名称.IsDigit = False
        Me.txt确认者名称.Location = New System.Drawing.Point(230, 102)
        Me.txt确认者名称.Name = "txt确认者名称"
        Me.txt确认者名称.ReadOnly = True
        Me.txt确认者名称.Size = New System.Drawing.Size(147, 23)
        Me.txt确认者名称.TabIndex = 422
        '
        'txt确认者编号
        '
        Me.txt确认者编号.AutoSize = False
        Me.txt确认者编号.ButtonsRight.Add(EditorButton1)
        Me.txt确认者编号.IsDigit = False
        Me.txt确认者编号.Location = New System.Drawing.Point(112, 102)
        Me.txt确认者编号.Name = "txt确认者编号"
        Me.txt确认者编号.Size = New System.Drawing.Size(118, 23)
        Me.txt确认者编号.TabIndex = 421
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
        Me.UcLabel2.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 420
        Me.UcLabel2.Text = "确认者"
        '
        'txt检查者名称
        '
        Me.txt检查者名称.AutoSize = False
        Me.txt检查者名称.IsDigit = False
        Me.txt检查者名称.Location = New System.Drawing.Point(230, 79)
        Me.txt检查者名称.Name = "txt检查者名称"
        Me.txt检查者名称.ReadOnly = True
        Me.txt检查者名称.Size = New System.Drawing.Size(147, 23)
        Me.txt检查者名称.TabIndex = 419
        '
        'txt检查者编号
        '
        Me.txt检查者编号.AutoSize = False
        Me.txt检查者编号.ButtonsRight.Add(EditorButton2)
        Me.txt检查者编号.IsDigit = False
        Me.txt检查者编号.Location = New System.Drawing.Point(112, 79)
        Me.txt检查者编号.Name = "txt检查者编号"
        Me.txt检查者编号.Size = New System.Drawing.Size(118, 23)
        Me.txt检查者编号.TabIndex = 417
        '
        'UcLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance4
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 416
        Me.UcLabel1.Text = "检查者"
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
        Me.UcLabel3.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 190
        Me.UcLabel3.Text = "*外协订单编号"
        '
        'txt外协订单编号
        '
        Me.txt外协订单编号.AutoSize = False
        Me.txt外协订单编号.ButtonsRight.Add(EditorButton3)
        Me.txt外协订单编号.IsDigit = False
        Me.txt外协订单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt外协订单编号.Name = "txt外协订单编号"
        Me.txt外协订单编号.Size = New System.Drawing.Size(118, 23)
        Me.txt外协订单编号.TabIndex = 217
        '
        'gridList
        '
        Me.gridList.ActiveFormFeatureCode = ""
        Me.gridList.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.gridList.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.BackColorFlg = True
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance31.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gridList.DisplayLayout.Appearance = Appearance31
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance32.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance32
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 57
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance33.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance33
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance34.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance34
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance35.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance35
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance36
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance37
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance1.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance1
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance2.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance2
        UltraGridColumn8.Format = "yyyy/mm/dd"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance38.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance38
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance3.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance3
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance39
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance40
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.GroupByBox.Hidden = True
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance41.BackColor2 = System.Drawing.SystemColors.Control
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance41
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance65.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.AddRowAppearance = Appearance65
        Me.gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.gridList.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance66.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance66
        Appearance67.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance67.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance67.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance67
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Appearance68.BackColor = System.Drawing.SystemColors.Control
        Appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance68.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance68.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance68
        Appearance69.TextHAlignAsString = "Center"
        Appearance69.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance69
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridList.DisplayLayout.Override.MinRowHeight = 20
        Appearance70.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance70
        Appearance71.BackColor = System.Drawing.Color.White
        Appearance71.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance71
        Appearance72.TextHAlignAsString = "Center"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance72
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSelectorWidth = 40
        Me.gridList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance73.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance73
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
        Me.gridList.Location = New System.Drawing.Point(10, 131)
        Me.gridList.MasterFlg = False
        Me.gridList.MinHeaderHeight = 24
        Me.gridList.MinRowHeight = 20
        Me.gridList.Name = "gridList"
        Me.gridList.RowAltAppColor = System.Drawing.Color.White
        Me.gridList.RowAppColor = System.Drawing.Color.White
        Me.gridList.Size = New System.Drawing.Size(986, 549)
        Me.gridList.TabIndex = 400
        Me.gridList.Text = "UcGridEdit1"
        '
        'frm外协品入库管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt确认者名称)
        Me.Controls.Add(Me.txt确认者编号)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt检查者名称)
        Me.Controls.Add(Me.txt检查者编号)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt外协订单编号)
        Me.Name = "frm外协品入库管理"
        Me.Text = "外协品入库管理"
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.txt外协订单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.txt检查者编号, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.txt检查者名称, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        Me.Controls.SetChildIndex(Me.txt确认者编号, 0)
        Me.Controls.SetChildIndex(Me.txt确认者名称, 0)
        CType(Me.txt确认者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt确认者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外协订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt外协订单编号 As UserControl.UCText
    Friend WithEvents gridList As UserControl.UCGridEdit
    Friend WithEvents txt检查者编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt检查者名称 As UserControl.UCText
    Friend WithEvents txt确认者名称 As UserControl.UCText
    Friend WithEvents txt确认者编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
End Class
