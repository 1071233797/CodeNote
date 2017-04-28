<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协加工管理
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
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("客户名称")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协状态")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协加工数量")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协工序")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("完成日期")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("回厂日期")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("原材料编号")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("带料数量")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance37})
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("加工单价")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("加工总金额")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("审核状态")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("审核人")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("审核备注")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("外协加工工序编号")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否外协加工")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否整体外协加工")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(983)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-7)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.grid外协加工管理 = New UserControl.UCGridEdit(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.txt外协对象 = New UserControl.UCText(Me.components)
        Me.txt外协对象名称 = New UserControl.UCText(Me.components)
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.btn查询 = New System.Windows.Forms.Button
        Me.txt外协工序 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.txt外协订单编号 = New UserControl.UCText(Me.components)
        CType(Me.grid外协加工管理, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外协对象, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外协对象名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt外协工序, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外协订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 11
        '
        'btnF11
        '
        Me.btnF11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF11.TabIndex = 10
        Me.btnF11.Tag = "502607"
        Me.btnF11.Text = "F11:审核通过"
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 6
        Me.btnF4删除.Tag = "502603"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 5
        Me.btnF3保存.Tag = "502602"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 4
        Me.btnF2编辑.Tag = "502601"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 3
        '
        'btnF10
        '
        Me.btnF10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF10.TabIndex = 9
        Me.btnF10.Tag = "502606"
        Me.btnF10.Text = "F10:外协计划导入"
        Me.btnF10.Visible = True
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
        Me.btnF6行删除.TabIndex = 8
        Me.btnF6行删除.Tag = "502605"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 7
        Me.btnF5行追加.Tag = "502604"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 10
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
        Me.UcLabel2.Location = New System.Drawing.Point(10, 140)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 198
        Me.UcLabel2.Text = "*外协计划单号"
        '
        'UcLabel4
        '
        Appearance65.BackColor = System.Drawing.Color.SkyBlue
        Appearance65.BackColor2 = System.Drawing.Color.White
        Appearance65.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance65.BorderColor = System.Drawing.Color.Black
        Appearance65.BorderColor2 = System.Drawing.Color.Black
        Appearance65.TextHAlignAsString = "Left"
        Appearance65.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance65
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel4.Location = New System.Drawing.Point(10, 163)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 205
        Me.UcLabel4.Text = "*外协对象"
        '
        'grid外协加工管理
        '
        Me.grid外协加工管理.ActiveFormFeatureCode = ""
        Me.grid外协加工管理.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid外协加工管理.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid外协加工管理.BackColorFlg = True
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid外协加工管理.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance2.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance4
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance5
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        Appearance74.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance74
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance6
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance7
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance8
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance9
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance10
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance11.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance11
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance12.ForeColor = System.Drawing.Color.Black
        UltraGridColumn11.CellAppearance = Appearance12
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance13.ForeColor = System.Drawing.Color.Black
        UltraGridColumn12.CellAppearance = Appearance13
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance14.ForeColor = System.Drawing.Color.Black
        UltraGridColumn13.CellAppearance = Appearance14
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn13.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance37.ForeColor = System.Drawing.Color.Red
        UltraGridColumn13.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance15.ForeColor = System.Drawing.Color.Black
        UltraGridColumn14.CellAppearance = Appearance15
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn14.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn14.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn14.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance16.ForeColor = System.Drawing.Color.Black
        UltraGridColumn15.CellAppearance = Appearance16
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn15.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn15.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn15.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance18.ForeColor = System.Drawing.Color.Black
        UltraGridColumn16.CellAppearance = Appearance18
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn16.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance19.ForeColor = System.Drawing.Color.Black
        UltraGridColumn17.CellAppearance = Appearance19
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn17.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance20.ForeColor = System.Drawing.Color.Black
        UltraGridColumn18.CellAppearance = Appearance20
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn18.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance21.ForeColor = System.Drawing.Color.Black
        UltraGridColumn19.CellAppearance = Appearance21
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn19.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance22.ForeColor = System.Drawing.Color.Black
        UltraGridColumn20.CellAppearance = Appearance22
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn20.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance23.ForeColor = System.Drawing.Color.Black
        UltraGridColumn21.CellAppearance = Appearance23
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn21.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance24.ForeColor = System.Drawing.Color.Black
        UltraGridColumn22.CellAppearance = Appearance24
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn22.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Me.grid外协加工管理.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid外协加工管理.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid外协加工管理.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid外协加工管理.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.grid外协加工管理.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.grid外协加工管理.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid外协加工管理.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.grid外协加工管理.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid外协加工管理.DisplayLayout.GroupByBox.Hidden = True
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid外协加工管理.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.grid外协加工管理.DisplayLayout.MaxColScrollRegions = 1
        Me.grid外协加工管理.DisplayLayout.MaxRowScrollRegions = 1
        Appearance28.BackColor = System.Drawing.Color.White
        Me.grid外协加工管理.DisplayLayout.Override.AddRowAppearance = Appearance28
        Me.grid外协加工管理.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid外协加工管理.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid外协加工管理.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid外协加工管理.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid外协加工管理.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid外协加工管理.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Me.grid外协加工管理.DisplayLayout.Override.CardAreaAppearance = Appearance29
        Appearance30.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance30.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance30.TextVAlignAsString = "Middle"
        Me.grid外协加工管理.DisplayLayout.Override.CellAppearance = Appearance30
        Me.grid外协加工管理.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid外协加工管理.DisplayLayout.Override.CellPadding = 0
        Appearance31.BackColor = System.Drawing.SystemColors.Control
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.grid外协加工管理.DisplayLayout.Override.GroupByRowAppearance = Appearance31
        Appearance32.TextHAlignAsString = "Center"
        Appearance32.TextVAlignAsString = "Middle"
        Me.grid外协加工管理.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.grid外协加工管理.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid外协加工管理.DisplayLayout.Override.MinRowHeight = 20
        Appearance33.BackColor = System.Drawing.Color.White
        Me.grid外协加工管理.DisplayLayout.Override.RowAlternateAppearance = Appearance33
        Appearance34.BackColor = System.Drawing.Color.White
        Appearance34.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid外协加工管理.DisplayLayout.Override.RowAppearance = Appearance34
        Appearance35.TextHAlignAsString = "Center"
        Me.grid外协加工管理.DisplayLayout.Override.RowSelectorAppearance = Appearance35
        Me.grid外协加工管理.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid外协加工管理.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid外协加工管理.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid外协加工管理.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid外协加工管理.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance36.BackColor = System.Drawing.Color.White
        Me.grid外协加工管理.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid外协加工管理.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid外协加工管理.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid外协加工管理.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid外协加工管理.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid外协加工管理.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid外协加工管理.FirstFocusColumnIndex = -1
        Me.grid外协加工管理.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid外协加工管理.InsertColumn = ""
        Me.grid外协加工管理.InsertColumn1 = ""
        Me.grid外协加工管理.InsertColumn2 = ""
        Me.grid外协加工管理.InsertValue = ""
        Me.grid外协加工管理.IsItiranCheckBoxFlag = False
        Me.grid外协加工管理.ItiranEditFlg = False
        Me.grid外协加工管理.Location = New System.Drawing.Point(10, 207)
        Me.grid外协加工管理.MasterFlg = False
        Me.grid外协加工管理.MinHeaderHeight = 24
        Me.grid外协加工管理.MinRowHeight = 20
        Me.grid外协加工管理.Name = "grid外协加工管理"
        Me.grid外协加工管理.RowAltAppColor = System.Drawing.Color.White
        Me.grid外协加工管理.RowAppColor = System.Drawing.Color.White
        Me.grid外协加工管理.Size = New System.Drawing.Size(985, 481)
        Me.grid外协加工管理.TabIndex = 2
        Me.grid外协加工管理.Text = "UcGridEdit1"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'txt外协对象
        '
        Me.txt外协对象.AutoSize = False
        Me.txt外协对象.ButtonsRight.Add(EditorButton1)
        Me.txt外协对象.IsDigit = False
        Me.txt外协对象.Location = New System.Drawing.Point(110, 163)
        Me.txt外协对象.MaxLength = 20
        Me.txt外协对象.Name = "txt外协对象"
        Me.txt外协对象.Size = New System.Drawing.Size(60, 23)
        Me.txt外协对象.TabIndex = 207
        '
        'txt外协对象名称
        '
        Me.txt外协对象名称.AutoSize = False
        Me.txt外协对象名称.Enabled = False
        Me.txt外协对象名称.IsDigit = False
        Me.txt外协对象名称.Location = New System.Drawing.Point(170, 163)
        Me.txt外协对象名称.Name = "txt外协对象名称"
        Me.txt外协对象名称.ReadOnly = True
        Me.txt外协对象名称.Size = New System.Drawing.Size(95, 23)
        Me.txt外协对象名称.TabIndex = 206
        Me.txt外协对象名称.TabStop = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.btn查询)
        Me.UltraGroupBox1.Controls.Add(Me.txt外协工序)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txt产品图号)
        Me.UltraGroupBox1.Controls.Add(Me.txt订单编号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel6)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(11, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 79)
        Me.UltraGroupBox1.TabIndex = 208
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'btn查询
        '
        Me.btn查询.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btn查询.Location = New System.Drawing.Point(711, 24)
        Me.btn查询.Name = "btn查询"
        Me.btn查询.Size = New System.Drawing.Size(78, 34)
        Me.btn查询.TabIndex = 420
        Me.btn查询.Tag = "502608"
        Me.btn查询.Text = "查询"
        Me.btn查询.UseVisualStyleBackColor = True
        '
        'txt外协工序
        '
        Me.txt外协工序.AutoSize = False
        Me.txt外协工序.IsDigit = False
        Me.txt外协工序.Location = New System.Drawing.Point(371, 26)
        Me.txt外协工序.Name = "txt外协工序"
        Me.txt外协工序.Size = New System.Drawing.Size(106, 22)
        Me.txt外协工序.TabIndex = 419
        '
        'UcLabel1
        '
        Appearance43.BackColor = System.Drawing.Color.SkyBlue
        Appearance43.BackColor2 = System.Drawing.Color.White
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance43.BorderColor = System.Drawing.Color.Black
        Appearance43.BorderColor2 = System.Drawing.Color.Black
        Appearance43.TextHAlignAsString = "Left"
        Appearance43.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance43
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(271, 26)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 417
        Me.UcLabel1.Text = "外协工序"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton2)
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(106, 46)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(103, 23)
        Me.txt产品图号.TabIndex = 3
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton3)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(106, 23)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(103, 23)
        Me.txt订单编号.TabIndex = 0
        '
        'UcLabel3
        '
        Appearance42.BackColor = System.Drawing.Color.SkyBlue
        Appearance42.BackColor2 = System.Drawing.Color.White
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance42.BorderColor = System.Drawing.Color.Black
        Appearance42.BorderColor2 = System.Drawing.Color.Black
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance42
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(6, 46)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 414
        Me.UcLabel3.Text = "产品图号"
        '
        'UcLabel6
        '
        Appearance17.BackColor = System.Drawing.Color.SkyBlue
        Appearance17.BackColor2 = System.Drawing.Color.White
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance17.BorderColor = System.Drawing.Color.Black
        Appearance17.BorderColor2 = System.Drawing.Color.Black
        Appearance17.TextHAlignAsString = "Left"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance17
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(6, 23)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 211
        Me.UcLabel6.Text = "订单编号"
        '
        'txt外协订单编号
        '
        Me.txt外协订单编号.Enabled = False
        Me.txt外协订单编号.IsDigit = False
        Me.txt外协订单编号.Location = New System.Drawing.Point(110, 140)
        Me.txt外协订单编号.Name = "txt外协订单编号"
        Me.txt外协订单编号.Size = New System.Drawing.Size(155, 22)
        Me.txt外协订单编号.TabIndex = 209
        '
        'frm外协加工管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt外协订单编号)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.txt外协对象名称)
        Me.Controls.Add(Me.txt外协对象)
        Me.Controls.Add(Me.grid外协加工管理)
        Me.Controls.Add(Me.UcLabel4)
        Me.Controls.Add(Me.UcLabel2)
        Me.KeyPreview = True
        Me.Name = "frm外协加工管理"
        Me.Text = "外协加工管理"
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
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.grid外协加工管理, 0)
        Me.Controls.SetChildIndex(Me.txt外协对象, 0)
        Me.Controls.SetChildIndex(Me.txt外协对象名称, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txt外协订单编号, 0)
        CType(Me.grid外协加工管理, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外协对象, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外协对象名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt外协工序, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外协订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents grid外协加工管理 As UserControl.UCGridEdit
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt外协对象 As UserControl.UCText
    Friend WithEvents txt外协对象名称 As UserControl.UCText
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents btn查询 As System.Windows.Forms.Button
    Friend WithEvents txt外协工序 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents txt外协订单编号 As UserControl.UCText
End Class
