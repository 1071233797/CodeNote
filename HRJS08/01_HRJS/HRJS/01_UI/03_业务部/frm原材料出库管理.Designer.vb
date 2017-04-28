<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm原材料出库管理

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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料名称")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料区分")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料批号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材质/型号")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("申请出库数量（个）")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("实际出库数量（个）")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("计划出库重量（kg）")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("实际出库重量（kg）")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库区域")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcText1 = New UserControl.UCText(Me.components)
        Me.UcText2 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UcText3 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcText4 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.UcText17 = New UserControl.UCText(Me.components)
        Me.UcGridEdit1 = New UserControl.UCGridEdit(Me.components)
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 6
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 5
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 3
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 4
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
        Me.UcLabel5.Location = New System.Drawing.Point(11, 102)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 481
        Me.UcLabel5.Text = "领料日期"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(111, 101)
        Me.UltraDateTimeEditor1.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(142, 21)
        Me.UltraDateTimeEditor1.TabIndex = 3
        '
        'UcText1
        '
        Me.UcText1.AutoSize = False
        Me.UcText1.IsDigit = False
        Me.UcText1.Location = New System.Drawing.Point(171, 78)
        Me.UcText1.Name = "UcText1"
        Me.UcText1.ReadOnly = True
        Me.UcText1.Size = New System.Drawing.Size(82, 23)
        Me.UcText1.TabIndex = 2
        '
        'UcText2
        '
        Me.UcText2.AutoSize = False
        Me.UcText2.ButtonsRight.Add(EditorButton1)
        Me.UcText2.IsDigit = False
        Me.UcText2.Location = New System.Drawing.Point(111, 78)
        Me.UcText2.Name = "UcText2"
        Me.UcText2.Size = New System.Drawing.Size(60, 21)
        Me.UcText2.TabIndex = 1
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
        Me.UcLabel2.Location = New System.Drawing.Point(11, 125)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 477
        Me.UcLabel2.Text = "职务"
        '
        'UcText3
        '
        Me.UcText3.AutoSize = False
        Me.UcText3.IsDigit = False
        Me.UcText3.Location = New System.Drawing.Point(111, 123)
        Me.UcText3.Name = "UcText3"
        Me.UcText3.Size = New System.Drawing.Size(142, 23)
        Me.UcText3.TabIndex = 4
        '
        'UcLabel1
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance18
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(11, 148)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 475
        Me.UcLabel1.Text = "部门"
        '
        'UcText4
        '
        Me.UcText4.AutoSize = False
        Me.UcText4.IsDigit = False
        Me.UcText4.Location = New System.Drawing.Point(111, 146)
        Me.UcText4.Name = "UcText4"
        Me.UcText4.Size = New System.Drawing.Size(142, 23)
        Me.UcText4.TabIndex = 5
        '
        'UcLabel17
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance14
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Location = New System.Drawing.Point(11, 79)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 474
        Me.UcLabel17.Text = "*领料者"
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
        Me.UcLabel3.Location = New System.Drawing.Point(11, 56)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 190
        Me.UcLabel3.Text = "*申请单编号"
        '
        'UcText17
        '
        Me.UcText17.AutoSize = False
        Me.UcText17.ButtonsRight.Add(EditorButton2)
        Me.UcText17.IsDigit = False
        Me.UcText17.Location = New System.Drawing.Point(111, 56)
        Me.UcText17.Name = "UcText17"
        Me.UcText17.Size = New System.Drawing.Size(142, 21)
        Me.UcText17.TabIndex = 0
        '
        'UcGridEdit1
        '
        Me.UcGridEdit1.ActiveFormFeatureCode = ""
        Me.UcGridEdit1.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.UcGridEdit1.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGridEdit1.BackColorFlg = True
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance30.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Appearance = Appearance30
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance31.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance31
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Width = 57
        Appearance1.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance2.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance2
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance4
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance32.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance32
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance33.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance33
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance34.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance34
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance35.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance35
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance36
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance37
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance38.ForeColor = System.Drawing.Color.Black
        UltraGridColumn11.CellAppearance = Appearance38
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Me.UcGridEdit1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UcGridEdit1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance39.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance39.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance39.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Appearance = Appearance39
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance40
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Hidden = True
        Appearance41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance41.BackColor2 = System.Drawing.SystemColors.Control
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.PromptAppearance = Appearance41
        Me.UcGridEdit1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcGridEdit1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance42.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.AddRowAppearance = Appearance42
        Me.UcGridEdit1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.UcGridEdit1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.UcGridEdit1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UcGridEdit1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.UcGridEdit1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance44.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.CellAppearance = Appearance44
        Me.UcGridEdit1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcGridEdit1.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Center"
        Appearance46.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.UcGridEdit1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UcGridEdit1.DisplayLayout.Override.MinRowHeight = 20
        Appearance47.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.RowAlternateAppearance = Appearance47
        Appearance48.BackColor = System.Drawing.Color.White
        Appearance48.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Override.RowAppearance = Appearance48
        Appearance49.TextHAlignAsString = "Center"
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorAppearance = Appearance49
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorWidth = 40
        Me.UcGridEdit1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance50.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance50
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.UcGridEdit1.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.UcGridEdit1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcGridEdit1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcGridEdit1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.UcGridEdit1.FirstFocusColumnIndex = -1
        Me.UcGridEdit1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcGridEdit1.InsertColumn = ""
        Me.UcGridEdit1.InsertColumn1 = ""
        Me.UcGridEdit1.InsertColumn2 = ""
        Me.UcGridEdit1.InsertValue = ""
        Me.UcGridEdit1.IsItiranCheckBoxFlag = False
        Me.UcGridEdit1.ItiranEditFlg = False
        Me.UcGridEdit1.Location = New System.Drawing.Point(10, 175)
        Me.UcGridEdit1.MasterFlg = False
        Me.UcGridEdit1.MinHeaderHeight = 24
        Me.UcGridEdit1.MinRowHeight = 20
        Me.UcGridEdit1.Name = "UcGridEdit1"
        Me.UcGridEdit1.RowAltAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.RowAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.Size = New System.Drawing.Size(986, 505)
        Me.UcGridEdit1.TabIndex = 1
        Me.UcGridEdit1.Text = "UcGridEdit1"
        '
        'frm原材料出库管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.UltraDateTimeEditor1)
        Me.Controls.Add(Me.UcGridEdit1)
        Me.Controls.Add(Me.UcText1)
        Me.Controls.Add(Me.UcText2)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcText3)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcText4)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.UcText17)
        Me.Name = "frm原材料出库管理"
        Me.Text = "原材料出库管理"
        Me.Controls.SetChildIndex(Me.UcText17, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.UcText4, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.UcText3, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.UcText2, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcText1, 0)
        Me.Controls.SetChildIndex(Me.UcGridEdit1, 0)
        Me.Controls.SetChildIndex(Me.UltraDateTimeEditor1, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcText17 As UserControl.UCText
    Friend WithEvents UcGridEdit1 As UserControl.UCGridEdit
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcText1 As UserControl.UCText
    Friend WithEvents UcText2 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents UcText3 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UcText4 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
End Class
