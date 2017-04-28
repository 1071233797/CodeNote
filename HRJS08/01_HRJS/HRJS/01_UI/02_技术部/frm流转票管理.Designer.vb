<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm流转票管理
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协加工")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("组装品")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序名称")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("加工内容简介")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业场所")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备编号")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("设备名称")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("试做品")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("图纸")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序编号", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(984)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-7)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grid流转票 = New UserControl.UCGridEdit(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt品名 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.ckb试做品 = New System.Windows.Forms.CheckBox
        Me.试做品 = New UserControl.UCLabel(Me.components)
        Me.pic图纸 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.grid流转票, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 12
        '
        'btnF11
        '
        Me.btnF11.TabIndex = 11
        Me.btnF11.Tag = "200506"
        Me.btnF11.Text = "F11：图片导入"
        Me.btnF11.Visible = True
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 8
        Me.btnF4删除.Tag = "200503"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        Me.btnF3保存.Tag = "200502"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        Me.btnF2编辑.Tag = "200501"
        '
        'labModel
        '
        Me.labModel.TabIndex = 11
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 5
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 13
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 12
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 11
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 10
        Me.btnF6行删除.Tag = "200505"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 9
        Me.btnF5行追加.Tag = "200504"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 10
        '
        'grid流转票
        '
        Me.grid流转票.ActiveFormFeatureCode = ""
        Me.grid流转票.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid流转票.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid流转票.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid流转票.BackColorFlg = True
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid流转票.DisplayLayout.Appearance = Appearance3
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.TabStop = False
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance7
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2.Width = 64
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance8
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn3.Width = 67
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance9.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance9
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance10
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.Width = 425
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance11
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance12
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance13
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance14
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.TabStop = False
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance15.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance15
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.TabStop = False
        Appearance27.ForeColor = System.Drawing.Color.Black
        UltraGridColumn11.CellAppearance = Appearance27
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.grid流转票.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid流转票.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid流转票.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid流转票.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.grid流转票.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Appearance16.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.grid流转票.DisplayLayout.GroupByBox.Appearance = Appearance16
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid流转票.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance17
        Me.grid流转票.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid流转票.DisplayLayout.GroupByBox.Hidden = True
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance18.BackColor2 = System.Drawing.SystemColors.Control
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance18.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid流转票.DisplayLayout.GroupByBox.PromptAppearance = Appearance18
        Me.grid流转票.DisplayLayout.MaxColScrollRegions = 1
        Me.grid流转票.DisplayLayout.MaxRowScrollRegions = 1
        Appearance19.BackColor = System.Drawing.Color.White
        Me.grid流转票.DisplayLayout.Override.AddRowAppearance = Appearance19
        Me.grid流转票.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid流转票.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid流转票.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid流转票.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid流转票.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid流转票.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance20.BackColor = System.Drawing.SystemColors.Window
        Me.grid流转票.DisplayLayout.Override.CardAreaAppearance = Appearance20
        Appearance21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance21.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance21.TextVAlignAsString = "Middle"
        Me.grid流转票.DisplayLayout.Override.CellAppearance = Appearance21
        Me.grid流转票.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid流转票.DisplayLayout.Override.CellPadding = 0
        Appearance22.BackColor = System.Drawing.SystemColors.Control
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.grid流转票.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Center"
        Appearance23.TextVAlignAsString = "Middle"
        Me.grid流转票.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.grid流转票.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid流转票.DisplayLayout.Override.MinRowHeight = 20
        Appearance24.BackColor = System.Drawing.Color.White
        Me.grid流转票.DisplayLayout.Override.RowAlternateAppearance = Appearance24
        Appearance25.BackColor = System.Drawing.Color.White
        Appearance25.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid流转票.DisplayLayout.Override.RowAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Center"
        Me.grid流转票.DisplayLayout.Override.RowSelectorAppearance = Appearance26
        Me.grid流转票.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid流转票.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid流转票.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid流转票.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid流转票.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance50.BackColor = System.Drawing.Color.White
        Me.grid流转票.DisplayLayout.Override.TemplateAddRowAppearance = Appearance50
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid流转票.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid流转票.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid流转票.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid流转票.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid流转票.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid流转票.FirstFocusColumnIndex = -1
        Me.grid流转票.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid流转票.InsertColumn = ""
        Me.grid流转票.InsertColumn1 = ""
        Me.grid流转票.InsertColumn2 = ""
        Me.grid流转票.InsertValue = ""
        Me.grid流转票.IsItiranCheckBoxFlag = False
        Me.grid流转票.ItiranEditFlg = False
        Me.grid流转票.Location = New System.Drawing.Point(12, 256)
        Me.grid流转票.MasterFlg = False
        Me.grid流转票.MinHeaderHeight = 24
        Me.grid流转票.MinRowHeight = 20
        Me.grid流转票.Name = "grid流转票"
        Me.grid流转票.RowAltAppColor = System.Drawing.Color.White
        Me.grid流转票.RowAppColor = System.Drawing.Color.White
        Me.grid流转票.Size = New System.Drawing.Size(986, 424)
        Me.grid流转票.TabIndex = 4
        Me.grid流转票.Text = "UcGridEdit1"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton1)
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(112, 55)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(184, 23)
        Me.txt产品图号.TabIndex = 0
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
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel3.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 440
        Me.UcLabel3.Text = "*产品图号"
        '
        'txt品名
        '
        Me.txt品名.AutoSize = False
        Me.txt品名.Enabled = False
        Me.txt品名.IsDigit = False
        Me.txt品名.Location = New System.Drawing.Point(112, 79)
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Size = New System.Drawing.Size(184, 23)
        Me.txt品名.TabIndex = 1
        '
        'UcLabel17
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance1
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel17.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 442
        Me.UcLabel17.Text = "品名"
        '
        'UcLabel1
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance2
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 442
        Me.UcLabel1.Text = "备注"
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(112, 103)
        Me.txt备注.MaxLength = 50000
        Me.txt备注.Multiline = True
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(574, 125)
        Me.txt备注.TabIndex = 2
        '
        'ckb试做品
        '
        Me.ckb试做品.AutoSize = True
        Me.ckb试做品.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.ckb试做品.Location = New System.Drawing.Point(116, 233)
        Me.ckb试做品.Name = "ckb试做品"
        Me.ckb试做品.Size = New System.Drawing.Size(60, 16)
        Me.ckb试做品.TabIndex = 3
        Me.ckb试做品.Text = "试做品"
        Me.ckb试做品.UseVisualStyleBackColor = True
        '
        '试做品
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.试做品.Appearance = Appearance6
        Me.试做品.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.试做品.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.试做品.Location = New System.Drawing.Point(12, 229)
        Me.试做品.Name = "试做品"
        Me.试做品.Size = New System.Drawing.Size(100, 23)
        Me.试做品.TabIndex = 445
        Me.试做品.Text = "试做品"
        '
        'pic图纸
        '
        Me.pic图纸.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic图纸.Location = New System.Drawing.Point(716, 56)
        Me.pic图纸.Name = "pic图纸"
        Me.pic图纸.Size = New System.Drawing.Size(280, 194)
        Me.pic图纸.TabIndex = 446
        Me.pic图纸.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm流转票管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.pic图纸)
        Me.Controls.Add(Me.试做品)
        Me.Controls.Add(Me.ckb试做品)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.txt品名)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.txt产品图号)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.grid流转票)
        Me.KeyPreview = True
        Me.Name = "frm流转票管理"
        Me.Text = "流转票管理"
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.grid流转票, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.txt产品图号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt品名, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        Me.Controls.SetChildIndex(Me.ckb试做品, 0)
        Me.Controls.SetChildIndex(Me.试做品, 0)
        Me.Controls.SetChildIndex(Me.pic图纸, 0)
        CType(Me.grid流转票, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents btnF10流转票打印 As UserControl.UCButton
    Friend WithEvents grid流转票 As UserControl.UCGridEdit
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt品名 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents ckb试做品 As System.Windows.Forms.CheckBox
    Friend WithEvents 试做品 As UserControl.UCLabel
    Friend WithEvents pic图纸 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
