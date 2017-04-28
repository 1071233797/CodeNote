<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm原材料入库申请
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料编号")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料名称")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料区分")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材料种类")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("材质")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("长")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("宽")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("高")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("实际采购数量")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("实际采购重量")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量（个）")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance9})
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库重量（kg）")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料编号")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料名称")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料区分")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材质")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库数量（个）")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库重量（kg）")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("订单编号")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("客户名称")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料编号")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料名称")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库数量（个）")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库重量（kg）")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("订单编号")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("客户名称")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料编号")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料名称")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料区分")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库数量（个）")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("入库重量（kg）")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("订单编号")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("客户名称")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.dt申请日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt部门 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.txt申请单编号 = New UserControl.UCText(Me.components)
        Me.txt人员名称 = New UserControl.UCText(Me.components)
        Me.grid原材料入库申请 = New UserControl.UCGridEdit(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt采购单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.txt批次号 = New UserControl.UCText(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.txt供应商批次号 = New UserControl.UCText(Me.components)
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid原材料入库申请, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt采购单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt批次号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt供应商批次号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 22
        '
        'btnF11
        '
        Me.btnF11.TabIndex = 21
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 14
        Me.btnF4删除.Tag = "502003"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 13
        Me.btnF3保存.Tag = "502002"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 12
        Me.btnF2编辑.Tag = "502001"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 11
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 20
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 19
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 18
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 16
        Me.btnF6行删除.Text = ""
        Me.btnF6行删除.Visible = False
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 15
        Me.btnF5行追加.Text = ""
        Me.btnF5行追加.Visible = False
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 17
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
        Me.UcLabel5.Location = New System.Drawing.Point(12, 171)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 483
        Me.UcLabel5.Text = "申请日期"
        '
        'dt申请日期
        '
        Me.dt申请日期.Location = New System.Drawing.Point(112, 171)
        Me.dt申请日期.MaskInput = "yyyy/mm/dd"
        Me.dt申请日期.Name = "dt申请日期"
        Me.dt申请日期.Size = New System.Drawing.Size(158, 22)
        Me.dt申请日期.TabIndex = 6
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(112, 102)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(70, 23)
        Me.txt人员编号.TabIndex = 2
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
        Me.UcLabel2.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 480
        Me.UcLabel2.Text = "职务"
        '
        'txt职务
        '
        Me.txt职务.AutoSize = False
        Me.txt职务.IsDigit = False
        Me.txt职务.Location = New System.Drawing.Point(112, 125)
        Me.txt职务.Name = "txt职务"
        Me.txt职务.ReadOnly = True
        Me.txt职务.Size = New System.Drawing.Size(158, 23)
        Me.txt职务.TabIndex = 4
        '
        'UcLabel1
        '
        Appearance80.BackColor = System.Drawing.Color.SkyBlue
        Appearance80.BackColor2 = System.Drawing.Color.White
        Appearance80.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance80.BorderColor = System.Drawing.Color.Black
        Appearance80.BorderColor2 = System.Drawing.Color.Black
        Appearance80.TextHAlignAsString = "Left"
        Appearance80.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance80
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 148)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 478
        Me.UcLabel1.Text = "部门"
        '
        'txt部门
        '
        Me.txt部门.AutoSize = False
        Me.txt部门.IsDigit = False
        Me.txt部门.Location = New System.Drawing.Point(112, 148)
        Me.txt部门.Name = "txt部门"
        Me.txt部门.ReadOnly = True
        Me.txt部门.Size = New System.Drawing.Size(158, 23)
        Me.txt部门.TabIndex = 5
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
        Me.UcLabel17.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 477
        Me.UcLabel17.Text = "*申请者"
        '
        'UcLabel9
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance1
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel9.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 475
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
        Me.txt申请单编号.TabIndex = 0
        '
        'txt人员名称
        '
        Me.txt人员名称.AutoSize = False
        Me.txt人员名称.IsDigit = False
        Me.txt人员名称.Location = New System.Drawing.Point(182, 102)
        Me.txt人员名称.Name = "txt人员名称"
        Me.txt人员名称.ReadOnly = True
        Me.txt人员名称.Size = New System.Drawing.Size(88, 23)
        Me.txt人员名称.TabIndex = 3
        '
        'grid原材料入库申请
        '
        Me.grid原材料入库申请.ActiveFormFeatureCode = ""
        Me.grid原材料入库申请.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid原材料入库申请.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid原材料入库申请.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid原材料入库申请.BackColorFlg = True
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid原材料入库申请.DisplayLayout.Appearance = Appearance4
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance6
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.TabStop = False
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance22.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance22
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.TabStop = False
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance24
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        Appearance2.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance37.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance37
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.TabStop = False
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance38.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance38
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance39.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance39
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.TabStop = False
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance40.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance40
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn8.TabStop = False
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance41.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance41
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance42.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance42
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance43.ForeColor = System.Drawing.Color.Black
        UltraGridColumn11.CellAppearance = Appearance43
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn11.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn11.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        Appearance9.ForeColor = System.Drawing.Color.Red
        UltraGridColumn11.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance45.ForeColor = System.Drawing.Color.Black
        UltraGridColumn12.CellAppearance = Appearance45
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn12.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn12.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.grid原材料入库申请.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid原材料入库申请.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid原材料入库申请.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance47.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance47.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance47.BorderColor = System.Drawing.SystemColors.Window
        Me.grid原材料入库申请.DisplayLayout.GroupByBox.Appearance = Appearance47
        Appearance48.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid原材料入库申请.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance48
        Me.grid原材料入库申请.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid原材料入库申请.DisplayLayout.GroupByBox.Hidden = True
        Appearance49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance49.BackColor2 = System.Drawing.SystemColors.Control
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance49.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid原材料入库申请.DisplayLayout.GroupByBox.PromptAppearance = Appearance49
        Me.grid原材料入库申请.DisplayLayout.MaxColScrollRegions = 1
        Me.grid原材料入库申请.DisplayLayout.MaxRowScrollRegions = 1
        Appearance50.BackColor = System.Drawing.Color.White
        Me.grid原材料入库申请.DisplayLayout.Override.AddRowAppearance = Appearance50
        Me.grid原材料入库申请.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid原材料入库申请.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid原材料入库申请.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid原材料入库申请.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid原材料入库申请.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid原材料入库申请.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance51.BackColor = System.Drawing.SystemColors.Window
        Me.grid原材料入库申请.DisplayLayout.Override.CardAreaAppearance = Appearance51
        Appearance52.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance52.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance52.TextVAlignAsString = "Middle"
        Me.grid原材料入库申请.DisplayLayout.Override.CellAppearance = Appearance52
        Me.grid原材料入库申请.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid原材料入库申请.DisplayLayout.Override.CellPadding = 0
        Appearance53.BackColor = System.Drawing.SystemColors.Control
        Appearance53.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance53.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance53.BorderColor = System.Drawing.SystemColors.Window
        Me.grid原材料入库申请.DisplayLayout.Override.GroupByRowAppearance = Appearance53
        Appearance54.TextHAlignAsString = "Center"
        Appearance54.TextVAlignAsString = "Middle"
        Me.grid原材料入库申请.DisplayLayout.Override.HeaderAppearance = Appearance54
        Me.grid原材料入库申请.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid原材料入库申请.DisplayLayout.Override.MinRowHeight = 20
        Appearance55.BackColor = System.Drawing.Color.White
        Me.grid原材料入库申请.DisplayLayout.Override.RowAlternateAppearance = Appearance55
        Appearance56.BackColor = System.Drawing.Color.White
        Appearance56.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid原材料入库申请.DisplayLayout.Override.RowAppearance = Appearance56
        Appearance57.TextHAlignAsString = "Center"
        Me.grid原材料入库申请.DisplayLayout.Override.RowSelectorAppearance = Appearance57
        Me.grid原材料入库申请.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid原材料入库申请.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid原材料入库申请.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid原材料入库申请.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid原材料入库申请.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance58.BackColor = System.Drawing.Color.White
        Me.grid原材料入库申请.DisplayLayout.Override.TemplateAddRowAppearance = Appearance58
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid原材料入库申请.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid原材料入库申请.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid原材料入库申请.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid原材料入库申请.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid原材料入库申请.FirstFocusColumnIndex = -1
        Me.grid原材料入库申请.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid原材料入库申请.InsertColumn = ""
        Me.grid原材料入库申请.InsertColumn1 = ""
        Me.grid原材料入库申请.InsertColumn2 = ""
        Me.grid原材料入库申请.InsertValue = ""
        Me.grid原材料入库申请.IsItiranCheckBoxFlag = False
        Me.grid原材料入库申请.ItiranEditFlg = False
        Me.grid原材料入库申请.Location = New System.Drawing.Point(12, 199)
        Me.grid原材料入库申请.MasterFlg = False
        Me.grid原材料入库申请.MinHeaderHeight = 24
        Me.grid原材料入库申请.MinRowHeight = 20
        Me.grid原材料入库申请.Name = "grid原材料入库申请"
        Me.grid原材料入库申请.RowAltAppColor = System.Drawing.Color.White
        Me.grid原材料入库申请.RowAppColor = System.Drawing.Color.White
        Me.grid原材料入库申请.Size = New System.Drawing.Size(984, 467)
        Me.grid原材料入库申请.TabIndex = 10
        Me.grid原材料入库申请.Text = "UcGridEdit1"
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'UcLabel3
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance15
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel3.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 475
        Me.UcLabel3.Text = "*采购单编号"
        '
        'txt采购单编号
        '
        Me.txt采购单编号.AutoSize = False
        Me.txt采购单编号.ButtonsRight.Add(EditorButton2)
        Me.txt采购单编号.IsDigit = False
        Me.txt采购单编号.Location = New System.Drawing.Point(112, 79)
        Me.txt采购单编号.Name = "txt采购单编号"
        Me.txt采购单编号.Size = New System.Drawing.Size(158, 23)
        Me.txt采购单编号.TabIndex = 1
        '
        'UcLabel4
        '
        Appearance10.BackColor = System.Drawing.Color.SkyBlue
        Appearance10.BackColor2 = System.Drawing.Color.White
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.BorderColor2 = System.Drawing.Color.Black
        Appearance10.TextHAlignAsString = "Left"
        Appearance10.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance10
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel4.Location = New System.Drawing.Point(289, 79)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 478
        Me.UcLabel4.Text = "批次号"
        '
        'txt批次号
        '
        Me.txt批次号.AutoSize = False
        Me.txt批次号.Enabled = False
        Me.txt批次号.IsDigit = False
        Me.txt批次号.Location = New System.Drawing.Point(389, 79)
        Me.txt批次号.Name = "txt批次号"
        Me.txt批次号.Size = New System.Drawing.Size(158, 23)
        Me.txt批次号.TabIndex = 8
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(389, 102)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(158, 23)
        Me.txt备注.TabIndex = 9
        '
        'UcLabel6
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance18
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel6.Location = New System.Drawing.Point(289, 102)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 486
        Me.UcLabel6.Text = "备注"
        '
        'UcLabel7
        '
        Appearance8.BackColor = System.Drawing.Color.SkyBlue
        Appearance8.BackColor2 = System.Drawing.Color.White
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance8.BorderColor = System.Drawing.Color.Black
        Appearance8.BorderColor2 = System.Drawing.Color.Black
        Appearance8.TextHAlignAsString = "Left"
        Appearance8.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance8
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel7.Location = New System.Drawing.Point(289, 56)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 478
        Me.UcLabel7.Text = "供应商批次号"
        '
        'txt供应商批次号
        '
        Me.txt供应商批次号.AutoSize = False
        Me.txt供应商批次号.IsDigit = False
        Me.txt供应商批次号.Location = New System.Drawing.Point(389, 56)
        Me.txt供应商批次号.Name = "txt供应商批次号"
        Me.txt供应商批次号.Size = New System.Drawing.Size(158, 23)
        Me.txt供应商批次号.TabIndex = 7
        '
        'frm原材料入库申请
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt备注)
        Me.Controls.Add(Me.UcLabel6)
        Me.Controls.Add(Me.txt供应商批次号)
        Me.Controls.Add(Me.txt批次号)
        Me.Controls.Add(Me.txt采购单编号)
        Me.Controls.Add(Me.UcLabel5)
        Me.Controls.Add(Me.dt申请日期)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.UcLabel7)
        Me.Controls.Add(Me.txt职务)
        Me.Controls.Add(Me.UcLabel4)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.txt部门)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel9)
        Me.Controls.Add(Me.txt申请单编号)
        Me.Controls.Add(Me.txt人员名称)
        Me.Controls.Add(Me.txt人员编号)
        Me.Controls.Add(Me.grid原材料入库申请)
        Me.Controls.Add(Me.UcLabel3)
        Me.KeyPreview = True
        Me.Name = "frm原材料入库申请"
        Me.Text = "原材料入库申请"
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.grid原材料入库申请, 0)
        Me.Controls.SetChildIndex(Me.txt人员编号, 0)
        Me.Controls.SetChildIndex(Me.txt人员名称, 0)
        Me.Controls.SetChildIndex(Me.txt申请单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel9, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt部门, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.UcLabel4, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.UcLabel7, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.dt申请日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel5, 0)
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
        Me.Controls.SetChildIndex(Me.txt采购单编号, 0)
        Me.Controls.SetChildIndex(Me.txt批次号, 0)
        Me.Controls.SetChildIndex(Me.txt供应商批次号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel6, 0)
        Me.Controls.SetChildIndex(Me.txt备注, 0)
        CType(Me.dt申请日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt部门, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid原材料入库申请, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt采购单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt批次号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt供应商批次号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents dt申请日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt部门 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents txt申请单编号 As UserControl.UCText
    Friend WithEvents txt人员名称 As UserControl.UCText
    Friend WithEvents grid原材料入库申请 As UserControl.UCGridEdit
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt采购单编号 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents txt批次号 As UserControl.UCText
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents txt供应商批次号 As UserControl.UCText
End Class
