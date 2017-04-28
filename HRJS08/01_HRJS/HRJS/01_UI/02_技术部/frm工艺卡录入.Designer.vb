<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm工艺卡录入
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序名称")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("加工内容")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业者")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("录入日期")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料种类")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材质/型号")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("单件重量")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("长")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("宽（直径）")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("高（厚度）")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("数量（每套）")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("要求")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("备注")
        Me.txt品名 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.pic图纸 = New System.Windows.Forms.PictureBox
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.grid工艺卡 = New UserControl.UCGridEdit(Me.components)
        Me.cek附加图号 = New System.Windows.Forms.CheckBox
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt附加图号 = New UserControl.UCText(Me.components)
        Me.lbl附加品名 = New UserControl.UCLabel(Me.components)
        Me.txt附加品名 = New UserControl.UCText(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid工艺卡, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt附加图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt附加品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.Location = New System.Drawing.Point(921, 12)
        Me.btnF12关闭.TabIndex = 13
        '
        'btnF11
        '
        Me.btnF11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF11.TabIndex = 12
        Me.btnF11.Tag = "200306"
        Me.btnF11.Text = "F11:图片导入"
        Me.btnF11.Visible = True
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 9
        Me.btnF4删除.Tag = "200303"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 8
        Me.btnF3保存.Tag = "200302"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 7
        Me.btnF2编辑.Tag = "200301"
        '
        'labModel
        '
        Me.labModel.Text = "新增"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 6
        '
        'btnF10
        '
        Me.btnF10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnF6行删除.TabIndex = 11
        Me.btnF6行删除.Tag = "200305"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 10
        Me.btnF5行追加.Tag = "200304"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 10
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
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance6
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel17.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 358
        Me.UcLabel17.Text = "品名"
        '
        'UcLabel6
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance5
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel6.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 356
        Me.UcLabel6.Text = "*产品图号"
        '
        'pic图纸
        '
        Me.pic图纸.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic图纸.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic图纸.Location = New System.Drawing.Point(753, 52)
        Me.pic图纸.Name = "pic图纸"
        Me.pic图纸.Size = New System.Drawing.Size(243, 210)
        Me.pic图纸.TabIndex = 374
        Me.pic图纸.TabStop = False
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton1)
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(112, 56)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(184, 23)
        Me.txt产品图号.TabIndex = 0
        '
        'grid工艺卡
        '
        Me.grid工艺卡.ActiveFormFeatureCode = ""
        Me.grid工艺卡.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid工艺卡.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid工艺卡.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid工艺卡.BackColorFlg = True
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid工艺卡.DisplayLayout.Appearance = Appearance9
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance21.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance21
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance22.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance22
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.Width = 502
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance23.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance23
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.Width = 142
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance25.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance25
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.Width = 106
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance26.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance26
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5})
        Me.grid工艺卡.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid工艺卡.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid工艺卡.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.grid工艺卡.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid工艺卡.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.grid工艺卡.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid工艺卡.DisplayLayout.GroupByBox.Hidden = True
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid工艺卡.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.grid工艺卡.DisplayLayout.MaxColScrollRegions = 1
        Me.grid工艺卡.DisplayLayout.MaxRowScrollRegions = 1
        Appearance30.BackColor = System.Drawing.Color.White
        Me.grid工艺卡.DisplayLayout.Override.AddRowAppearance = Appearance30
        Me.grid工艺卡.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid工艺卡.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid工艺卡.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid工艺卡.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid工艺卡.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid工艺卡.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.grid工艺卡.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance32.TextVAlignAsString = "Middle"
        Me.grid工艺卡.DisplayLayout.Override.CellAppearance = Appearance32
        Me.grid工艺卡.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid工艺卡.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.grid工艺卡.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Center"
        Appearance34.TextVAlignAsString = "Middle"
        Me.grid工艺卡.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.grid工艺卡.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid工艺卡.DisplayLayout.Override.MinRowHeight = 20
        Appearance35.BackColor = System.Drawing.Color.White
        Me.grid工艺卡.DisplayLayout.Override.RowAlternateAppearance = Appearance35
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid工艺卡.DisplayLayout.Override.RowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Center"
        Me.grid工艺卡.DisplayLayout.Override.RowSelectorAppearance = Appearance37
        Me.grid工艺卡.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid工艺卡.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid工艺卡.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid工艺卡.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid工艺卡.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance40.BackColor = System.Drawing.Color.White
        Me.grid工艺卡.DisplayLayout.Override.TemplateAddRowAppearance = Appearance40
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid工艺卡.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid工艺卡.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid工艺卡.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid工艺卡.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid工艺卡.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid工艺卡.FirstFocusColumnIndex = -1
        Me.grid工艺卡.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid工艺卡.InsertColumn = ""
        Me.grid工艺卡.InsertColumn1 = ""
        Me.grid工艺卡.InsertColumn2 = ""
        Me.grid工艺卡.InsertValue = ""
        Me.grid工艺卡.IsItiranCheckBoxFlag = False
        Me.grid工艺卡.ItiranEditFlg = False
        Me.grid工艺卡.Location = New System.Drawing.Point(12, 268)
        Me.grid工艺卡.MasterFlg = False
        Me.grid工艺卡.MinHeaderHeight = 24
        Me.grid工艺卡.MinRowHeight = 20
        Me.grid工艺卡.Name = "grid工艺卡"
        Me.grid工艺卡.RowAltAppColor = System.Drawing.Color.White
        Me.grid工艺卡.RowAppColor = System.Drawing.Color.White
        Me.grid工艺卡.Size = New System.Drawing.Size(984, 400)
        Me.grid工艺卡.TabIndex = 5
        Me.grid工艺卡.Text = "UcGridEdit1"
        '
        'cek附加图号
        '
        Me.cek附加图号.AutoSize = True
        Me.cek附加图号.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.cek附加图号.Location = New System.Drawing.Point(12, 111)
        Me.cek附加图号.Name = "cek附加图号"
        Me.cek附加图号.Size = New System.Drawing.Size(72, 16)
        Me.cek附加图号.TabIndex = 2
        Me.cek附加图号.Text = "附加图号"
        Me.cek附加图号.UseVisualStyleBackColor = True
        '
        'UcLabel1
        '
        Appearance81.BackColor = System.Drawing.Color.SkyBlue
        Appearance81.BackColor2 = System.Drawing.Color.White
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance81.BorderColor = System.Drawing.Color.Black
        Appearance81.BorderColor2 = System.Drawing.Color.Black
        Appearance81.TextHAlignAsString = "Left"
        Appearance81.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance81
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 135)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 376
        Me.UcLabel1.Text = "附加图号"
        '
        'txt附加图号
        '
        Me.txt附加图号.AutoSize = False
        Me.txt附加图号.IsDigit = False
        Me.txt附加图号.Location = New System.Drawing.Point(112, 134)
        Me.txt附加图号.Name = "txt附加图号"
        Me.txt附加图号.Size = New System.Drawing.Size(184, 23)
        Me.txt附加图号.TabIndex = 3
        '
        'lbl附加品名
        '
        Appearance24.BackColor = System.Drawing.Color.SkyBlue
        Appearance24.BackColor2 = System.Drawing.Color.White
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance24.BorderColor = System.Drawing.Color.Black
        Appearance24.BorderColor2 = System.Drawing.Color.Black
        Appearance24.TextHAlignAsString = "Left"
        Appearance24.TextVAlignAsString = "Middle"
        Me.lbl附加品名.Appearance = Appearance24
        Me.lbl附加品名.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl附加品名.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl附加品名.Location = New System.Drawing.Point(12, 158)
        Me.lbl附加品名.Name = "lbl附加品名"
        Me.lbl附加品名.Size = New System.Drawing.Size(100, 23)
        Me.lbl附加品名.TabIndex = 358
        Me.lbl附加品名.Text = "附加品名"
        '
        'txt附加品名
        '
        Me.txt附加品名.AutoSize = False
        Me.txt附加品名.IsDigit = False
        Me.txt附加品名.Location = New System.Drawing.Point(112, 158)
        Me.txt附加品名.Name = "txt附加品名"
        Me.txt附加品名.Size = New System.Drawing.Size(184, 23)
        Me.txt附加品名.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'frm工艺卡录入
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.cek附加图号)
        Me.Controls.Add(Me.grid工艺卡)
        Me.Controls.Add(Me.txt产品图号)
        Me.Controls.Add(Me.pic图纸)
        Me.Controls.Add(Me.txt附加图号)
        Me.Controls.Add(Me.txt附加品名)
        Me.Controls.Add(Me.lbl附加品名)
        Me.Controls.Add(Me.txt品名)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel6)
        Me.KeyPreview = True
        Me.Name = "frm工艺卡录入"
        Me.Text = "工艺卡管理"
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.UcLabel6, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt品名, 0)
        Me.Controls.SetChildIndex(Me.lbl附加品名, 0)
        Me.Controls.SetChildIndex(Me.txt附加品名, 0)
        Me.Controls.SetChildIndex(Me.txt附加图号, 0)
        Me.Controls.SetChildIndex(Me.pic图纸, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.txt产品图号, 0)
        Me.Controls.SetChildIndex(Me.grid工艺卡, 0)
        Me.Controls.SetChildIndex(Me.cek附加图号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid工艺卡, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt附加图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt附加品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt品名 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents pic图纸 As System.Windows.Forms.PictureBox
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn图纸导入 As UserControl.UCButton
    Friend WithEvents grid工艺卡 As UserControl.UCGridEdit
    Friend WithEvents cek附加图号 As System.Windows.Forms.CheckBox
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt附加图号 As UserControl.UCText
    Friend WithEvents lbl附加品名 As UserControl.UCLabel
    Friend WithEvents txt附加品名 As UserControl.UCText
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource


End Class
