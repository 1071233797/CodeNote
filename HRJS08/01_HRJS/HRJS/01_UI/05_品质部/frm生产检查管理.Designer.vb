<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产检查管理

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
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查ID")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品名称")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("本道工序编号")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序名称")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产数量(个)")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance62})
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查内容")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查数量(个)")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("int")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良数量(个)")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良原因")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理结果")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.txt检查者名称 = New UserControl.UCText(Me.components)
        Me.txt检查者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.gridList = New UserControl.UCGridEdit(Me.components)
        Me.txt检查日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt检查ID = New UserControl.UCText(Me.components)
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 9
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 6
        Me.btnF4删除.Tag = "300103"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 5
        Me.btnF3保存.Tag = "300102"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 4
        Me.btnF2编辑.Tag = "300101"
        '
        'labModel
        '
        Me.labModel.Text = "新增"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 3
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 8
        Me.btnF6行删除.Tag = "300105"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 7
        Me.btnF5行追加.Tag = "300104"
        '
        'UcLabel12
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance15
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(12, 81)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(102, 23)
        Me.UcLabel12.TabIndex = 435
        Me.UcLabel12.Text = "检查日期"
        '
        'txt检查者名称
        '
        Me.txt检查者名称.AutoSize = False
        Me.txt检查者名称.IsDigit = False
        Me.txt检查者名称.Location = New System.Drawing.Point(187, 52)
        Me.txt检查者名称.Name = "txt检查者名称"
        Me.txt检查者名称.ReadOnly = True
        Me.txt检查者名称.Size = New System.Drawing.Size(93, 23)
        Me.txt检查者名称.TabIndex = 434
        '
        'txt检查者编号
        '
        Me.txt检查者编号.AutoSize = False
        Me.txt检查者编号.ButtonsRight.Add(EditorButton1)
        Me.txt检查者编号.IsDigit = False
        Me.txt检查者编号.Location = New System.Drawing.Point(112, 52)
        Me.txt检查者编号.Name = "txt检查者编号"
        Me.txt检查者编号.Size = New System.Drawing.Size(75, 23)
        Me.txt检查者编号.TabIndex = 0
        '
        'UcLabel1
        '
        Appearance56.BackColor = System.Drawing.Color.SkyBlue
        Appearance56.BackColor2 = System.Drawing.Color.White
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance56.BorderColor = System.Drawing.Color.Black
        Appearance56.BorderColor2 = System.Drawing.Color.Black
        Appearance56.TextHAlignAsString = "Left"
        Appearance56.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance56
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 52)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 433
        Me.UcLabel1.Text = "检查者"
        '
        'gridList
        '
        Me.gridList.ActiveFormFeatureCode = ""
        Me.gridList.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.gridList.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.BackColorFlg = True
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.gridList.DisplayLayout.Appearance = Appearance16
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance17.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance17
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.TabStop = False
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance18
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn2.Width = 104
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance19
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        Appearance61.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance61
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance20.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance20
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance21
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance22.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance22
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.TabStop = False
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance23
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance24
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn9.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.TabStop = False
        Appearance62.ForeColor = System.Drawing.Color.Red
        UltraGridColumn9.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance26.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance26
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance27.ForeColor = System.Drawing.Color.Black
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance27
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance43.ForeColor = System.Drawing.Color.Black
        UltraGridColumn12.CellAppearance = Appearance43
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance45.ForeColor = System.Drawing.Color.Black
        UltraGridColumn13.CellAppearance = Appearance45
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance46.ForeColor = System.Drawing.Color.Black
        UltraGridColumn14.CellAppearance = Appearance46
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance47.ForeColor = System.Drawing.Color.Black
        UltraGridColumn15.CellAppearance = Appearance47
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance48
        Appearance49.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance49
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.GroupByBox.Hidden = True
        Appearance50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance50.BackColor2 = System.Drawing.SystemColors.Control
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance50
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance51.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.AddRowAppearance = Appearance51
        Me.gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.gridList.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance52.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance52
        Appearance53.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance53.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance53.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance53
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Appearance54.BackColor = System.Drawing.SystemColors.Control
        Appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance54.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance54.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance54
        Appearance55.TextHAlignAsString = "Center"
        Appearance55.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance55
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.gridList.DisplayLayout.Override.MinRowHeight = 20
        Appearance57.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance57
        Appearance58.BackColor = System.Drawing.Color.White
        Appearance58.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance58
        Appearance59.TextHAlignAsString = "Center"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance59
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSelectorWidth = 40
        Me.gridList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance60.BackColor = System.Drawing.Color.White
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.gridList.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.gridList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.gridList.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridList.FirstFocusColumnIndex = -1
        Me.gridList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridList.InsertColumn = ""
        Me.gridList.InsertColumn1 = ""
        Me.gridList.InsertColumn2 = ""
        Me.gridList.InsertValue = ""
        Me.gridList.IsItiranCheckBoxFlag = False
        Me.gridList.ItiranEditFlg = False
        Me.gridList.Location = New System.Drawing.Point(12, 120)
        Me.gridList.MasterFlg = False
        Me.gridList.MinHeaderHeight = 24
        Me.gridList.MinRowHeight = 20
        Me.gridList.Name = "gridList"
        Me.gridList.RowAltAppColor = System.Drawing.Color.White
        Me.gridList.RowAppColor = System.Drawing.Color.White
        Me.gridList.Size = New System.Drawing.Size(984, 560)
        Me.gridList.TabIndex = 438
        Me.gridList.Text = "UcGridEdit1"
        '
        'txt检查日期
        '
        Me.txt检查日期.DateTime = New Date(2016, 8, 3, 0, 0, 0, 0)
        Me.txt检查日期.Location = New System.Drawing.Point(113, 81)
        Me.txt检查日期.MaskInput = "yyyy/mm/dd"
        Me.txt检查日期.Name = "txt检查日期"
        Me.txt检查日期.Size = New System.Drawing.Size(106, 22)
        Me.txt检查日期.TabIndex = 439
        Me.txt检查日期.Value = New Date(2016, 8, 3, 0, 0, 0, 0)
        '
        'txt检查ID
        '
        Me.txt检查ID.AutoSize = False
        Me.txt检查ID.IsDigit = False
        Me.txt检查ID.Location = New System.Drawing.Point(218, 80)
        Me.txt检查ID.Name = "txt检查ID"
        Me.txt检查ID.ReadOnly = True
        Me.txt检查ID.Size = New System.Drawing.Size(62, 23)
        Me.txt检查ID.TabIndex = 440
        Me.txt检查ID.Visible = False
        '
        'frm生产检查管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt检查ID)
        Me.Controls.Add(Me.txt检查日期)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.UcLabel12)
        Me.Controls.Add(Me.txt检查者名称)
        Me.Controls.Add(Me.txt检查者编号)
        Me.Controls.Add(Me.UcLabel1)
        Me.KeyPreview = True
        Me.Name = "frm生产检查管理"
        Me.Text = "生产检查管理"
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt检查者编号, 0)
        Me.Controls.SetChildIndex(Me.txt检查者名称, 0)
        Me.Controls.SetChildIndex(Me.UcLabel12, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.txt检查日期, 0)
        Me.Controls.SetChildIndex(Me.txt检查ID, 0)
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt检查者名称 As UserControl.UCText
    Friend WithEvents txt检查者编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents gridList As UserControl.UCGridEdit
    Friend WithEvents txt检查日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt检查ID As UserControl.UCText
End Class
