﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm半成品出库申请
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序编号")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序名称")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("半成品种类编号")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("半成品种类名称")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("库存数量")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("库存区域")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("出库数量")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance2})
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("出库去向")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.gridList = New UserControl.UCGridEdit(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.dt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt人员名称 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt部门 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 17
        '
        'btnF11
        '
        Me.btnF11.TabIndex = 16
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 10
        Me.btnF4删除.Tag = "400803"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 9
        Me.btnF3保存.Tag = "400802"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 8
        Me.btnF2编辑.Tag = "400801"
        '
        'labModel
        '
        Me.labModel.TabIndex = 12
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 7
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 15
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 14
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 13
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 12
        Me.btnF6行删除.Tag = "400805"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 11
        Me.btnF5行追加.Tag = "400804"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 19
        '
        'gridList
        '
        Me.gridList.ActiveFormFeatureCode = ""
        Me.gridList.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.gridList.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridList.BackColorFlg = True
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gridList.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance4
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance6
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.TabStop = False
        Appearance44.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance44
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance8
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.TabStop = False
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance9
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance10
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance21
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.TabStop = False
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance24
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance27.ForeColor = System.Drawing.Color.Black
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance27
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.TabStop = False
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance28
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.TabStop = False
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance29.ForeColor = System.Drawing.Color.Black
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance29
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.ForeColor = System.Drawing.Color.Red
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance30.ForeColor = System.Drawing.Color.Black
        UltraGridColumn12.CellAppearance = Appearance30
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance31.ForeColor = System.Drawing.Color.Black
        UltraGridColumn13.CellAppearance = Appearance31
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.GroupByBox.Hidden = True
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance35.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.AddRowAppearance = Appearance35
        Me.gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.gridList.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance36
        Appearance37.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance37.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance37.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance37
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Appearance38.BackColor = System.Drawing.SystemColors.Control
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance38
        Appearance39.TextHAlignAsString = "Center"
        Appearance39.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance39
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridList.DisplayLayout.Override.MinRowHeight = 20
        Appearance40.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance40
        Appearance41.BackColor = System.Drawing.Color.White
        Appearance41.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance41
        Appearance42.TextHAlignAsString = "Center"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance42
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSelectorWidth = 40
        Me.gridList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance43.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance43
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
        Me.gridList.Location = New System.Drawing.Point(12, 177)
        Me.gridList.MasterFlg = False
        Me.gridList.MinHeaderHeight = 24
        Me.gridList.MinRowHeight = 20
        Me.gridList.Name = "gridList"
        Me.gridList.RowAltAppColor = System.Drawing.Color.White
        Me.gridList.RowAppColor = System.Drawing.Color.White
        Me.gridList.Size = New System.Drawing.Size(984, 503)
        Me.gridList.TabIndex = 6
        Me.gridList.Text = "UcGridEdit1"
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
        Me.UcLabel5.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel5.Location = New System.Drawing.Point(12, 148)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 9
        Me.UcLabel5.Text = "申请日期"
        '
        'dt申请日期
        '
        Me.dt申请日期.Location = New System.Drawing.Point(112, 149)
        Me.dt申请日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请日期.Name = "dt申请日期"
        Me.dt申请日期.Size = New System.Drawing.Size(158, 22)
        Me.dt申请日期.TabIndex = 5
        '
        'txt人员名称
        '
        Me.txt人员名称.AutoSize = False
        Me.txt人员名称.Enabled = False
        Me.txt人员名称.IsDigit = False
        Me.txt人员名称.Location = New System.Drawing.Point(174, 79)
        Me.txt人员名称.Name = "txt人员名称"
        Me.txt人员名称.ReadOnly = True
        Me.txt人员名称.Size = New System.Drawing.Size(96, 23)
        Me.txt人员名称.TabIndex = 2
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(112, 79)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(62, 23)
        Me.txt人员编号.TabIndex = 1
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
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel2.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 5
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
        Me.txt职务.Size = New System.Drawing.Size(158, 23)
        Me.txt职务.TabIndex = 3
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
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 7
        Me.UcLabel1.Text = "部门"
        '
        'txt部门
        '
        Me.txt部门.AutoSize = False
        Me.txt部门.Enabled = False
        Me.txt部门.IsDigit = False
        Me.txt部门.Location = New System.Drawing.Point(112, 125)
        Me.txt部门.Name = "txt部门"
        Me.txt部门.ReadOnly = True
        Me.txt部门.Size = New System.Drawing.Size(158, 23)
        Me.txt部门.TabIndex = 4
        '
        'UcLabel17
        '
        Appearance7.BackColor = System.Drawing.Color.SkyBlue
        Appearance7.BackColor2 = System.Drawing.Color.White
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.BorderColor2 = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance7
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel17.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 2
        Me.UcLabel17.Text = "*申请者"
        '
        'UcLabel9
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance15
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel9.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 0
        Me.UcLabel9.Text = "*申请单编号"
        '
        'txt申请单编号
        '
        Me.txt申请单编号.AutoSize = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.ReadOnly = True
        Me.txt申请单编号.Size = New System.Drawing.Size(158, 23)
        Me.txt申请单编号.TabIndex = 0
        '
        'frm半成品出库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.dt申请日期)
        Me.Controls.Add(Me.txt人员名称)
        Me.Controls.Add(Me.txt人员编号)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt职务)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.txt部门)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.txt申请单编号)
        Me.KeyPreview = True
        Me.Name = "frm半成品出库申请"
        Me.Text = "半成品出库申请"
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.txt申请单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt部门, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt人员编号, 0)
        Me.Controls.SetChildIndex(Me.txt人员名称, 0)
        Me.Controls.SetChildIndex(Me.dt申请日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridList As UserControl.UCGridEdit
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents dt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt人员名称 As UserControl.UCText
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt部门 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents txt申请单编号 As UserControl.UCText
End Class
