<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm原材料盘点管理
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
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料编号")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料名称")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料区分")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材质/型号")
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("长")
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("宽")
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("高")
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库总数量（个）")
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库总重量（kg）")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance213})
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点总数量（个）")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点总重量（kg）")
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差异总数量（个）")
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差异总重量（kg）")
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料批号")
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库数量（个）")
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库重量（kg）")
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库日期")
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点日期")
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点数量（个）")
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点重量（kg）")
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差异数量（个）")
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差异重量（kg）")
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差额调整数量（个）")
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差额调整重量（kg）")
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理方式")
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("调整后在库数量（个）")
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("调整后在库重量（kg）")
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点CD")
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料编号")
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grdList = New UserControl.UCGridEdit(Me.components)
        Me.btnF11原材料盘点表打印 = New UserControl.UCButton(Me.components)
        Me.cob材料区分 = New UserControl.UCCombo(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.dt盘点日期From = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.dt盘点日期To = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ck仅显示差异项 = New System.Windows.Forms.CheckBox
        Me.txt原材料名称 = New UserControl.UCText(Me.components)
        Me.txt原材料编号 = New UserControl.UCText(Me.components)
        Me.btnF4保存 = New UserControl.UCButton(Me.components)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cob材料区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.dt盘点日期From, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt盘点日期To, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 7
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 3
        Me.btnF2查询.Tag = "501801"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        Me.btnF3选择.Tag = "501802"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'grdList
        '
        Me.grdList.ActiveFormFeatureCode = ""
        Me.grdList.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grdList.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdList.BackColorFlg = True
        Appearance163.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance163.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grdList.DisplayLayout.Appearance = Appearance163
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance164.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance164
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance165.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance165
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.TabStop = False
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance166.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance166
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance167.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance167
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn4.TabStop = False
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance168.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance168
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance169.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance169
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance170.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance170
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance171.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance171
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance212.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance212
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance172.ForeColor = System.Drawing.Color.Black
        Appearance172.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance172
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn10.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.TabStop = False
        Appearance213.ForeColor = System.Drawing.Color.Red
        UltraGridColumn10.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance174.ForeColor = System.Drawing.Color.Black
        Appearance174.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance174
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn11.TabStop = False
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance176.ForeColor = System.Drawing.Color.Black
        Appearance176.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance176
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.TabStop = False
        UltraGridColumn12.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance178.ForeColor = System.Drawing.Color.Black
        Appearance178.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance178
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn13.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn13.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn13.TabStop = False
        UltraGridColumn13.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance180.ForeColor = System.Drawing.Color.Black
        Appearance180.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance180
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn14.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn14.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn14.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn14.TabStop = False
        UltraGridColumn14.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance182.ForeColor = System.Drawing.Color.Black
        UltraGridColumn15.CellAppearance = Appearance182
        UltraGridColumn15.Header.VisiblePosition = 6
        UltraGridColumn15.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn15.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn15.TabStop = False
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance183.ForeColor = System.Drawing.Color.Black
        UltraGridColumn16.CellAppearance = Appearance183
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn16.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn16.TabStop = False
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance184.ForeColor = System.Drawing.Color.Black
        Appearance184.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance184
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn17.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn17.TabStop = False
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance185.ForeColor = System.Drawing.Color.Black
        Appearance185.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance185
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn18.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn18.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn18.TabStop = False
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance186.ForeColor = System.Drawing.Color.Black
        Appearance186.TextHAlignAsString = "Center"
        UltraGridColumn19.CellAppearance = Appearance186
        UltraGridColumn19.Format = "yyyy/MM/dd"
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn19.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn19.TabStop = False
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance187.ForeColor = System.Drawing.Color.Black
        Appearance187.TextHAlignAsString = "Center"
        UltraGridColumn20.CellAppearance = Appearance187
        UltraGridColumn20.Format = "yyyy/MM/dd"
        UltraGridColumn20.Header.VisiblePosition = 6
        UltraGridColumn20.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn20.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn20.TabStop = False
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance188.ForeColor = System.Drawing.Color.Black
        Appearance188.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance188
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn21.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn21.TabStop = False
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance189.ForeColor = System.Drawing.Color.Black
        Appearance189.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance189
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn22.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn22.TabStop = False
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance190.ForeColor = System.Drawing.Color.Black
        Appearance190.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance190
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn23.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn23.TabStop = False
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance191.ForeColor = System.Drawing.Color.Black
        Appearance191.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance191
        UltraGridColumn24.Header.VisiblePosition = 8
        UltraGridColumn24.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn24.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn24.TabStop = False
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance192.ForeColor = System.Drawing.Color.Black
        Appearance192.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance192
        UltraGridColumn25.Header.VisiblePosition = 9
        UltraGridColumn25.MaxLength = 9
        UltraGridColumn25.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn25.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance193.ForeColor = System.Drawing.Color.Black
        Appearance193.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance193
        UltraGridColumn26.Header.VisiblePosition = 10
        UltraGridColumn26.MaxLength = 9
        UltraGridColumn26.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn26.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance194.ForeColor = System.Drawing.Color.Black
        UltraGridColumn27.CellAppearance = Appearance194
        UltraGridColumn27.Header.VisiblePosition = 11
        UltraGridColumn27.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn27.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn27.TabStop = False
        UltraGridColumn28.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance195.ForeColor = System.Drawing.Color.Black
        Appearance195.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance195
        UltraGridColumn28.Header.VisiblePosition = 12
        UltraGridColumn28.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn28.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn28.TabStop = False
        UltraGridColumn29.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance196.ForeColor = System.Drawing.Color.Black
        Appearance196.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance196
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn29.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn29.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn29.TabStop = False
        UltraGridColumn30.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance197.ForeColor = System.Drawing.Color.Black
        UltraGridColumn30.CellAppearance = Appearance197
        UltraGridColumn30.Header.VisiblePosition = 14
        UltraGridColumn30.MaxLength = 200
        UltraGridColumn30.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn30.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn31.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance198.ForeColor = System.Drawing.Color.Black
        UltraGridColumn31.CellAppearance = Appearance198
        UltraGridColumn31.Header.VisiblePosition = 15
        UltraGridColumn31.Hidden = True
        UltraGridColumn31.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn31.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn31.TabStop = False
        UltraGridColumn32.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance199.ForeColor = System.Drawing.Color.Black
        UltraGridColumn32.CellAppearance = Appearance199
        UltraGridColumn32.Header.VisiblePosition = 16
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn32.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn32.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn32.TabStop = False
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance200.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance200.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance200.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance200.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance200
        Appearance201.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance201
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.GroupByBox.Hidden = True
        Appearance202.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance202.BackColor2 = System.Drawing.SystemColors.Control
        Appearance202.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance202.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance202
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance203.BackColor = System.Drawing.Color.White
        Me.grdList.DisplayLayout.Override.AddRowAppearance = Appearance203
        Me.grdList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grdList.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance204.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance204
        Appearance205.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance205.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance205.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance205
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance206.BackColor = System.Drawing.SystemColors.Control
        Appearance206.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance206.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance206.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance206.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance206
        Appearance207.TextHAlignAsString = "Center"
        Appearance207.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance207
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdList.DisplayLayout.Override.MinRowHeight = 20
        Appearance208.BackColor = System.Drawing.Color.White
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance208
        Appearance209.BackColor = System.Drawing.Color.White
        Appearance209.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance209
        Appearance210.TextHAlignAsString = "Center"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance210
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grdList.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance211.BackColor = System.Drawing.Color.White
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance211
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grdList.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grdList.FirstFocusColumnIndex = -1
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.InsertColumn = ""
        Me.grdList.InsertColumn1 = ""
        Me.grdList.InsertColumn2 = ""
        Me.grdList.InsertValue = ""
        Me.grdList.IsItiranCheckBoxFlag = False
        Me.grdList.ItiranEditFlg = False
        Me.grdList.Location = New System.Drawing.Point(12, 138)
        Me.grdList.MasterFlg = False
        Me.grdList.MinHeaderHeight = 24
        Me.grdList.MinRowHeight = 20
        Me.grdList.Name = "grdList"
        Me.grdList.RowAltAppColor = System.Drawing.Color.White
        Me.grdList.RowAppColor = System.Drawing.Color.White
        Me.grdList.Size = New System.Drawing.Size(984, 346)
        Me.grdList.TabIndex = 1
        Me.grdList.Text = "UcGridEdit1"
        '
        'btnF11原材料盘点表打印
        '
        Me.btnF11原材料盘点表打印.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance53.BackColor = System.Drawing.SystemColors.Control
        Appearance53.BackColor2 = System.Drawing.SystemColors.Control
        Appearance53.TextHAlignAsString = "Center"
        Appearance53.TextVAlignAsString = "Middle"
        Me.btnF11原材料盘点表打印.Appearance = Appearance53
        Me.btnF11原材料盘点表打印.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11原材料盘点表打印.FSearchButtonName = ""
        Me.btnF11原材料盘点表打印.Location = New System.Drawing.Point(825, 12)
        Me.btnF11原材料盘点表打印.Name = "btnF11原材料盘点表打印"
        Me.btnF11原材料盘点表打印.Size = New System.Drawing.Size(85, 34)
        Me.btnF11原材料盘点表打印.TabIndex = 6
        Me.btnF11原材料盘点表打印.Tag = "501804"
        Me.btnF11原材料盘点表打印.Text = "F11：原材料盘点表打印"
        '
        'cob材料区分
        '
        Me.cob材料区分.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cob材料区分.DisplayLayout.Appearance = Appearance14
        Me.cob材料区分.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cob材料区分.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材料区分.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance59.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材料区分.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance59
        Me.cob材料区分.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材料区分.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.cob材料区分.DisplayLayout.MaxColScrollRegions = 1
        Me.cob材料区分.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cob材料区分.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cob材料区分.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.cob材料区分.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cob材料区分.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Me.cob材料区分.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cob材料区分.DisplayLayout.Override.CellAppearance = Appearance34
        Me.cob材料区分.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cob材料区分.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材料区分.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.cob材料区分.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.cob材料区分.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cob材料区分.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.cob材料区分.DisplayLayout.Override.RowAppearance = Appearance37
        Me.cob材料区分.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cob材料区分.DisplayLayout.Override.TemplateAddRowAppearance = Appearance38
        Me.cob材料区分.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cob材料区分.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cob材料区分.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cob材料区分.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cob材料区分.Location = New System.Drawing.Point(106, 44)
        Me.cob材料区分.Name = "cob材料区分"
        Me.cob材料区分.Size = New System.Drawing.Size(102, 22)
        Me.cob材料区分.TabIndex = 2
        Me.cob材料区分.Text = "辅助材料"
        '
        'UcLabel7
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance6
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 3
        Me.UcLabel7.Text = "原材料区分"
        '
        'UcLabel13
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance1
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 0
        Me.UcLabel13.Text = "原材料名称"
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel10)
        Me.UcGroupBox1.Controls.Add(Me.dt盘点日期From)
        Me.UcGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UcGroupBox1.Controls.Add(Me.dt盘点日期To)
        Me.UcGroupBox1.Controls.Add(Me.ck仅显示差异项)
        Me.UcGroupBox1.Controls.Add(Me.txt原材料名称)
        Me.UcGroupBox1.Controls.Add(Me.txt原材料编号)
        Me.UcGroupBox1.Controls.Add(Me.cob材料区分)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel7)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel13)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 80)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UcLabel10
        '
        Appearance28.BackColor = System.Drawing.Color.SkyBlue
        Appearance28.BackColor2 = System.Drawing.Color.White
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance28.BorderColor = System.Drawing.Color.Black
        Appearance28.BorderColor2 = System.Drawing.Color.Black
        Appearance28.TextHAlignAsString = "Left"
        Appearance28.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance28
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Location = New System.Drawing.Point(412, 23)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 13
        Me.UcLabel10.Text = "盘点日期"
        '
        'dt盘点日期From
        '
        Me.dt盘点日期From.DateTime = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dt盘点日期From.Location = New System.Drawing.Point(512, 23)
        Me.dt盘点日期From.MaskInput = "yyyy/mm/dd"
        Me.dt盘点日期From.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dt盘点日期From.Name = "dt盘点日期From"
        Me.dt盘点日期From.Size = New System.Drawing.Size(94, 21)
        Me.dt盘点日期From.TabIndex = 3
        Me.dt盘点日期From.Value = Nothing
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(608, 32)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(10, 19)
        Me.UltraLabel1.TabIndex = 15
        Me.UltraLabel1.Text = "~"
        '
        'dt盘点日期To
        '
        Me.dt盘点日期To.DateTime = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dt盘点日期To.Location = New System.Drawing.Point(623, 23)
        Me.dt盘点日期To.MaskInput = "yyyy/mm/dd"
        Me.dt盘点日期To.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dt盘点日期To.Name = "dt盘点日期To"
        Me.dt盘点日期To.Size = New System.Drawing.Size(115, 21)
        Me.dt盘点日期To.TabIndex = 4
        Me.dt盘点日期To.Value = Nothing
        '
        'ck仅显示差异项
        '
        Me.ck仅显示差异项.AutoSize = True
        Me.ck仅显示差异项.Location = New System.Drawing.Point(412, 53)
        Me.ck仅显示差异项.Name = "ck仅显示差异项"
        Me.ck仅显示差异项.Size = New System.Drawing.Size(96, 16)
        Me.ck仅显示差异项.TabIndex = 5
        Me.ck仅显示差异项.Text = "仅显示差异项"
        Me.ck仅显示差异项.UseVisualStyleBackColor = True
        '
        'txt原材料名称
        '
        Me.txt原材料名称.AutoSize = False
        Me.txt原材料名称.IsDigit = False
        Me.txt原材料名称.Location = New System.Drawing.Point(208, 21)
        Me.txt原材料名称.Name = "txt原材料名称"
        Me.txt原材料名称.ReadOnly = True
        Me.txt原材料名称.Size = New System.Drawing.Size(126, 23)
        Me.txt原材料名称.TabIndex = 1
        Me.txt原材料名称.TabStop = False
        '
        'txt原材料编号
        '
        Me.txt原材料编号.AutoSize = False
        Me.txt原材料编号.ButtonsRight.Add(EditorButton1)
        Me.txt原材料编号.IsDigit = False
        Me.txt原材料编号.Location = New System.Drawing.Point(106, 21)
        Me.txt原材料编号.Name = "txt原材料编号"
        Me.txt原材料编号.Size = New System.Drawing.Size(102, 23)
        Me.txt原材料编号.TabIndex = 0
        '
        'btnF4保存
        '
        Appearance3.BackColor = System.Drawing.SystemColors.Control
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        Me.btnF4保存.Appearance = Appearance3
        Me.btnF4保存.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF4保存.FSearchButtonName = ""
        Me.btnF4保存.Location = New System.Drawing.Point(252, 12)
        Me.btnF4保存.Name = "btnF4保存"
        Me.btnF4保存.Size = New System.Drawing.Size(80, 34)
        Me.btnF4保存.TabIndex = 5
        Me.btnF4保存.Tag = "501803"
        Me.btnF4保存.Text = "F4：保存"
        '
        'frm原材料盘点管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF4保存)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.Controls.Add(Me.btnF11原材料盘点表打印)
        Me.Controls.Add(Me.grdList)
        Me.KeyPreview = True
        Me.Name = "frm原材料盘点管理"
        Me.Text = "原材料盘点管理"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        Me.Controls.SetChildIndex(Me.btnF11原材料盘点表打印, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF4保存, 0)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cob材料区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.dt盘点日期From, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt盘点日期To, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdList As UserControl.UCGridEdit
    Friend WithEvents btnF11原材料盘点表打印 As UserControl.UCButton
    Friend WithEvents cob材料区分 As UserControl.UCCombo
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt原材料名称 As UserControl.UCText
    Friend WithEvents txt原材料编号 As UserControl.UCText
    Friend WithEvents ck仅显示差异项 As System.Windows.Forms.CheckBox
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents dt盘点日期From As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt盘点日期To As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents btnF4保存 As UserControl.UCButton
End Class

