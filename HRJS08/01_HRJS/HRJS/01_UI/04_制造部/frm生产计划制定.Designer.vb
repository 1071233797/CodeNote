<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产计划制定
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("工序名称")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("加工内容简介")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("作业场所")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("设备编号")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("是否外协加工")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("外协理由")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("外协数量")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("是否为组装品")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("起始日")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("完成日")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("作业者编号")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("作业者名称")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("备注")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("图纸")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("工序编号")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("品名", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为抵补品")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为试做品")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订货量")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("投产数量")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance36})
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("总件完成期限")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("小件完成期限")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("发货日期")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("图纸")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.dmt下达日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel15 = New UserControl.UCLabel(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.pic图纸 = New System.Windows.Forms.PictureBox
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.grid生产计划制定 = New UserControl.UCGridEdit(Me.components)
        CType(Me.dmt下达日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid生产计划制定, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.Location = New System.Drawing.Point(923, 12)
        Me.btnF12关闭.TabIndex = 13
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 9
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 12
        Me.btnF4删除.Tag = "400103"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 10
        Me.btnF2编辑.Tag = "400101"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 11
        Me.btnF3保存.Tag = "400102"
        '
        'labModel
        '
        Me.labModel.TabIndex = 24
        Me.labModel.Text = "新增"
        '
        'dmt下达日期
        '
        Me.dmt下达日期.DateTime = New Date(2016, 5, 10, 0, 0, 0, 0)
        Me.dmt下达日期.Location = New System.Drawing.Point(112, 102)
        Me.dmt下达日期.MaskInput = "yyyy/mm/dd"
        Me.dmt下达日期.Name = "dmt下达日期"
        Me.dmt下达日期.Size = New System.Drawing.Size(132, 21)
        Me.dmt下达日期.TabIndex = 6
        Me.dmt下达日期.Value = New Date(2016, 5, 10, 0, 0, 0, 0)
        '
        'UcLabel13
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance6
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 19
        Me.UcLabel13.Text = "*下达日期"
        '
        'UcLabel15
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel15.Appearance = Appearance3
        Me.UcLabel15.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel15.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel15.Name = "UcLabel15"
        Me.UcLabel15.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel15.TabIndex = 11
        Me.UcLabel15.Text = "客户名称"
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(112, 79)
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.ReadOnly = True
        Me.txt客户名称.Size = New System.Drawing.Size(132, 23)
        Me.txt客户名称.TabIndex = 1
        '
        'UcLabel5
        '
        Appearance42.BackColor = System.Drawing.Color.SkyBlue
        Appearance42.BackColor2 = System.Drawing.Color.White
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance42.BorderColor = System.Drawing.Color.Black
        Appearance42.BorderColor2 = System.Drawing.Color.Black
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance42
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 0
        Me.UcLabel5.Text = "*订单编号"
        '
        'UcLabel10
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance1
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 21
        Me.UcLabel10.Text = "订单备注"
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(112, 124)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.ReadOnly = True
        Me.txt备注.Size = New System.Drawing.Size(262, 23)
        Me.txt备注.TabIndex = 7
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton1)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(132, 23)
        Me.txt订单编号.TabIndex = 0
        '
        'pic图纸
        '
        Me.pic图纸.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic图纸.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic图纸.Location = New System.Drawing.Point(715, 52)
        Me.pic图纸.Name = "pic图纸"
        Me.pic图纸.Size = New System.Drawing.Size(286, 191)
        Me.pic图纸.TabIndex = 449
        Me.pic图纸.TabStop = False
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        '
        'grid生产计划制定
        '
        Me.grid生产计划制定.ActiveFormFeatureCode = ""
        Me.grid生产计划制定.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid生产计划制定.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid生产计划制定.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid生产计划制定.BackColorFlg = True
        Me.grid生产计划制定.DataMember = Nothing
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance29.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid生产计划制定.DisplayLayout.Appearance = Appearance29
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance30.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance30
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance31.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance31
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance33.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance33
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance34.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance34
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.TabStop = False
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance35.ForeColor = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance35
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        Appearance36.ForeColor = System.Drawing.Color.Red
        UltraGridColumn6.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance37
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance38.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance38
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance39.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance39
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance40.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance40
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.grid生产计划制定.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid生产计划制定.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产计划制定.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance41.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance41.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance41.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance41.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产计划制定.DisplayLayout.GroupByBox.Appearance = Appearance41
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产计划制定.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance43
        Me.grid生产计划制定.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产计划制定.DisplayLayout.GroupByBox.Hidden = True
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance44.BackColor2 = System.Drawing.SystemColors.Control
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产计划制定.DisplayLayout.GroupByBox.PromptAppearance = Appearance44
        Me.grid生产计划制定.DisplayLayout.MaxColScrollRegions = 1
        Me.grid生产计划制定.DisplayLayout.MaxRowScrollRegions = 1
        Appearance45.BackColor = System.Drawing.Color.White
        Me.grid生产计划制定.DisplayLayout.Override.AddRowAppearance = Appearance45
        Me.grid生产计划制定.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid生产计划制定.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid生产计划制定.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid生产计划制定.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid生产计划制定.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid生产计划制定.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance46.BackColor = System.Drawing.SystemColors.Window
        Me.grid生产计划制定.DisplayLayout.Override.CardAreaAppearance = Appearance46
        Appearance47.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance47.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance47.TextVAlignAsString = "Middle"
        Me.grid生产计划制定.DisplayLayout.Override.CellAppearance = Appearance47
        Me.grid生产计划制定.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid生产计划制定.DisplayLayout.Override.CellPadding = 0
        Appearance48.BackColor = System.Drawing.SystemColors.Control
        Appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance48.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance48.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产计划制定.DisplayLayout.Override.GroupByRowAppearance = Appearance48
        Appearance49.TextHAlignAsString = "Center"
        Appearance49.TextVAlignAsString = "Middle"
        Me.grid生产计划制定.DisplayLayout.Override.HeaderAppearance = Appearance49
        Me.grid生产计划制定.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid生产计划制定.DisplayLayout.Override.MinRowHeight = 20
        Appearance50.BackColor = System.Drawing.Color.White
        Me.grid生产计划制定.DisplayLayout.Override.RowAlternateAppearance = Appearance50
        Appearance51.BackColor = System.Drawing.Color.White
        Appearance51.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid生产计划制定.DisplayLayout.Override.RowAppearance = Appearance51
        Appearance52.TextHAlignAsString = "Center"
        Me.grid生产计划制定.DisplayLayout.Override.RowSelectorAppearance = Appearance52
        Me.grid生产计划制定.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid生产计划制定.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid生产计划制定.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid生产计划制定.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid生产计划制定.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance53.BackColor = System.Drawing.Color.White
        Me.grid生产计划制定.DisplayLayout.Override.TemplateAddRowAppearance = Appearance53
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid生产计划制定.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid生产计划制定.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid生产计划制定.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid生产计划制定.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid生产计划制定.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid生产计划制定.FirstFocusColumnIndex = -1
        Me.grid生产计划制定.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid生产计划制定.InsertColumn = ""
        Me.grid生产计划制定.InsertColumn1 = ""
        Me.grid生产计划制定.InsertColumn2 = ""
        Me.grid生产计划制定.InsertValue = ""
        Me.grid生产计划制定.IsItiranCheckBoxFlag = False
        Me.grid生产计划制定.ItiranEditFlg = False
        Me.grid生产计划制定.Location = New System.Drawing.Point(12, 249)
        Me.grid生产计划制定.MasterFlg = False
        Me.grid生产计划制定.MinHeaderHeight = 24
        Me.grid生产计划制定.MinRowHeight = 20
        Me.grid生产计划制定.Name = "grid生产计划制定"
        Me.grid生产计划制定.RowAltAppColor = System.Drawing.Color.White
        Me.grid生产计划制定.RowAppColor = System.Drawing.Color.White
        Me.grid生产计划制定.Size = New System.Drawing.Size(989, 439)
        Me.grid生产计划制定.TabIndex = 8
        Me.grid生产计划制定.Text = "UcGridEdit1"
        '
        'frm生产计划制定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 692)
        Me.Controls.Add(Me.grid生产计划制定)
        Me.Controls.Add(Me.pic图纸)
        Me.Controls.Add(Me.txt订单编号)
        Me.Controls.Add(Me.UcLabel10)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.dmt下达日期)
        Me.Controls.Add(Me.UcLabel13)
        Me.Controls.Add(Me.UcLabel15)
        Me.Controls.Add(Me.txt客户名称)
        Me.Controls.Add(Me.UcLabel5)
        Me.Name = "frm生产计划制定"
        Me.Text = "生产计划制定"
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.txt客户名称, 0)
        Me.Controls.SetChildIndex(Me.UcLabel15, 0)
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.dmt下达日期, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        Me.Controls.SetChildIndex(Me.UcLabel10, 0)
        Me.Controls.SetChildIndex(Me.txt订单编号, 0)
        Me.Controls.SetChildIndex(Me.pic图纸, 0)
        Me.Controls.SetChildIndex(Me.grid生产计划制定, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.dmt下达日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid生产计划制定, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dmt下达日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcLabel15 As UserControl.UCLabel
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents pic图纸 As System.Windows.Forms.PictureBox
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents grid生产计划制定 As UserControl.UCGridEdit
End Class
