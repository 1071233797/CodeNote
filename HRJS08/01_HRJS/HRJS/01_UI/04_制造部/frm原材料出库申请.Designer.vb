<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm原材料出库申请
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
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料编号")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料名称")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料区分")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材质")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("长")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance1})
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("宽")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("高")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("领料数量（个）")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("领料重量（kg）")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("预计成品数量")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(982)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-7)
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt部门 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.txt人员名称 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.dt领料日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.grid原材料出库申请 = New UserControl.UCGridEdit(Me.components)
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt领料日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid原材料出库申请, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 24
        '
        'btnF11
        '
        Me.btnF11.Text = "F11:审核通过"
        Me.btnF11.Visible = True
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 16
        Me.btnF4删除.Tag = "400603"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 15
        Me.btnF3保存.Tag = "400602"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 14
        Me.btnF2编辑.Tag = "400601"
        '
        'labModel
        '
        Me.labModel.TabIndex = 12
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 13
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 22
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 21
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 20
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 18
        Me.btnF6行删除.Tag = "400605"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 17
        Me.btnF5行追加.Tag = "400604"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 19
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
        Me.txt部门.IsDigit = False
        Me.txt部门.Location = New System.Drawing.Point(112, 125)
        Me.txt部门.Name = "txt部门"
        Me.txt部门.ReadOnly = True
        Me.txt部门.Size = New System.Drawing.Size(158, 23)
        Me.txt部门.TabIndex = 8
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
        Me.UcLabel17.Text = "*领料者"
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
        Me.txt申请单编号.Enabled = False
        Me.txt申请单编号.IsDigit = False
        Me.txt申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt申请单编号.Name = "txt申请单编号"
        Me.txt申请单编号.Size = New System.Drawing.Size(158, 23)
        Me.txt申请单编号.TabIndex = 1
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
        Me.txt职务.IsDigit = False
        Me.txt职务.Location = New System.Drawing.Point(112, 102)
        Me.txt职务.Name = "txt职务"
        Me.txt职务.ReadOnly = True
        Me.txt职务.Size = New System.Drawing.Size(158, 23)
        Me.txt职务.TabIndex = 6
        '
        'txt人员名称
        '
        Me.txt人员名称.AutoSize = False
        Me.txt人员名称.IsDigit = False
        Me.txt人员名称.Location = New System.Drawing.Point(186, 79)
        Me.txt人员名称.Name = "txt人员名称"
        Me.txt人员名称.ReadOnly = True
        Me.txt人员名称.Size = New System.Drawing.Size(84, 23)
        Me.txt人员名称.TabIndex = 4
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(112, 79)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(74, 23)
        Me.txt人员编号.TabIndex = 3
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
        Me.UcLabel5.Text = "领料日期"
        '
        'dt领料日期
        '
        Me.dt领料日期.Location = New System.Drawing.Point(112, 149)
        Me.dt领料日期.MaskInput = "yyyy/mm/dd"
        Me.dt领料日期.Name = "dt领料日期"
        Me.dt领料日期.Size = New System.Drawing.Size(158, 22)
        Me.dt领料日期.TabIndex = 10
        '
        'grid原材料出库申请
        '
        Me.grid原材料出库申请.ActiveFormFeatureCode = ""
        Me.grid原材料出库申请.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid原材料出库申请.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid原材料出库申请.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid原材料出库申请.BackColorFlg = True
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid原材料出库申请.DisplayLayout.Appearance = Appearance4
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance6
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn1.TabStop = False
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance8
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.TabStop = False
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance9
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance10
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.TabStop = False
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance11
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance12
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance13
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn7.TabStop = False
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance14
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.ForeColor = System.Drawing.Color.Black
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance16
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn9.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance1.ForeColor = System.Drawing.Color.Red
        UltraGridColumn9.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.ForeColor = System.Drawing.Color.Black
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance19
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn10.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.ForeColor = System.Drawing.Color.Black
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance21
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance23.ForeColor = System.Drawing.Color.Black
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance23
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn12.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance25.ForeColor = System.Drawing.Color.Black
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance25
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn13.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn13.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance27.ForeColor = System.Drawing.Color.Black
        UltraGridColumn14.CellAppearance = Appearance27
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance28.ForeColor = System.Drawing.Color.Black
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance28
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn15.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn15.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn15.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.grid原材料出库申请.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid原材料出库申请.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid原材料出库申请.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid原材料出库申请.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.grid原材料出库申请.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.grid原材料出库申请.DisplayLayout.GroupByBox.Appearance = Appearance30
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid原材料出库申请.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
        Me.grid原材料出库申请.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid原材料出库申请.DisplayLayout.GroupByBox.Hidden = True
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance32.BackColor2 = System.Drawing.SystemColors.Control
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid原材料出库申请.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
        Me.grid原材料出库申请.DisplayLayout.MaxColScrollRegions = 1
        Me.grid原材料出库申请.DisplayLayout.MaxRowScrollRegions = 1
        Appearance33.BackColor = System.Drawing.Color.White
        Me.grid原材料出库申请.DisplayLayout.Override.AddRowAppearance = Appearance33
        Me.grid原材料出库申请.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid原材料出库申请.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid原材料出库申请.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid原材料出库申请.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid原材料出库申请.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid原材料出库申请.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Me.grid原材料出库申请.DisplayLayout.Override.CardAreaAppearance = Appearance34
        Appearance35.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance35.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance35.TextVAlignAsString = "Middle"
        Me.grid原材料出库申请.DisplayLayout.Override.CellAppearance = Appearance35
        Me.grid原材料出库申请.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid原材料出库申请.DisplayLayout.Override.CellPadding = 0
        Appearance36.BackColor = System.Drawing.SystemColors.Control
        Appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.BorderColor = System.Drawing.SystemColors.Window
        Me.grid原材料出库申请.DisplayLayout.Override.GroupByRowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Center"
        Appearance37.TextVAlignAsString = "Middle"
        Me.grid原材料出库申请.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.grid原材料出库申请.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid原材料出库申请.DisplayLayout.Override.MinRowHeight = 20
        Appearance38.BackColor = System.Drawing.Color.White
        Me.grid原材料出库申请.DisplayLayout.Override.RowAlternateAppearance = Appearance38
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid原材料出库申请.DisplayLayout.Override.RowAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Center"
        Me.grid原材料出库申请.DisplayLayout.Override.RowSelectorAppearance = Appearance40
        Me.grid原材料出库申请.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid原材料出库申请.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid原材料出库申请.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid原材料出库申请.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid原材料出库申请.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance41.BackColor = System.Drawing.Color.White
        Me.grid原材料出库申请.DisplayLayout.Override.TemplateAddRowAppearance = Appearance41
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid原材料出库申请.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid原材料出库申请.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid原材料出库申请.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid原材料出库申请.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid原材料出库申请.FirstFocusColumnIndex = -1
        Me.grid原材料出库申请.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid原材料出库申请.InsertColumn = ""
        Me.grid原材料出库申请.InsertColumn1 = ""
        Me.grid原材料出库申请.InsertColumn2 = ""
        Me.grid原材料出库申请.InsertValue = ""
        Me.grid原材料出库申请.IsItiranCheckBoxFlag = False
        Me.grid原材料出库申请.ItiranEditFlg = False
        Me.grid原材料出库申请.Location = New System.Drawing.Point(12, 177)
        Me.grid原材料出库申请.MasterFlg = False
        Me.grid原材料出库申请.MinHeaderHeight = 24
        Me.grid原材料出库申请.MinRowHeight = 20
        Me.grid原材料出库申请.Name = "grid原材料出库申请"
        Me.grid原材料出库申请.RowAltAppColor = System.Drawing.Color.White
        Me.grid原材料出库申请.RowAppColor = System.Drawing.Color.White
        Me.grid原材料出库申请.Size = New System.Drawing.Size(984, 491)
        Me.grid原材料出库申请.TabIndex = 11
        Me.grid原材料出库申请.Text = "UcGridEdit1"
        '
        'frm原材料出库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grid原材料出库申请)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.dt领料日期)
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
        Me.Name = "frm原材料出库申请"
        Me.Text = "原材料出库申请"
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.txt申请单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt部门, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt人员编号, 0)
        Me.Controls.SetChildIndex(Me.txt人员名称, 0)
        Me.Controls.SetChildIndex(Me.dt领料日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
        Me.Controls.SetChildIndex(Me.grid原材料出库申请, 0)
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt领料日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid原材料出库申请, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt部门 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents txt申请单编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents txt人员名称 As UserControl.UCText
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents dt领料日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents grid原材料出库申请 As UserControl.UCGridEdit
End Class
