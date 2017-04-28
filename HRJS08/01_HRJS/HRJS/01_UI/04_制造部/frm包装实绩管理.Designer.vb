<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm包装实绩管理
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Me.txt部门名称 = New UserControl.UCText(Me.components)
        Me.txt职务 = New UserControl.UCText(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.dmt完成日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel18 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.cmb作业方式 = New UserControl.UCCombo(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt实际生产数量 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt人员名 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel25 = New UserControl.UCLabel(Me.components)
        Me.txt计划生产数量 = New UserControl.UCText(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.UcLabel16 = New UserControl.UCLabel(Me.components)
        Me.dmt作业日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt完成日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb作业方式, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt实际生产数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt计划生产数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt作业日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        '
        'btnF11
        '
        Me.btnF11.TabStop = False
        Me.btnF11.Text = "F11:审核通过"
        '
        'btnF4删除
        '
        Me.btnF4删除.Tag = "401603"
        '
        'btnF3保存
        '
        Me.btnF3保存.Tag = "401602"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.Tag = "401601"
        '
        'btnF1清空
        '
        '
        'btnF6行删除
        '
        Me.btnF6行删除.Visible = False
        '
        'btnF5行追加
        '
        Me.btnF5行追加.Visible = False
        '
        'txt部门名称
        '
        Me.txt部门名称.AutoSize = False
        Me.txt部门名称.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt部门名称.IsDigit = False
        Me.txt部门名称.Location = New System.Drawing.Point(112, 102)
        Me.txt部门名称.Name = "txt部门名称"
        Me.txt部门名称.ReadOnly = True
        Me.txt部门名称.Size = New System.Drawing.Size(100, 23)
        Me.txt部门名称.TabIndex = 328
        '
        'txt职务
        '
        Me.txt职务.AutoSize = False
        Me.txt职务.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt职务.IsDigit = False
        Me.txt职务.Location = New System.Drawing.Point(112, 79)
        Me.txt职务.Name = "txt职务"
        Me.txt职务.ReadOnly = True
        Me.txt职务.Size = New System.Drawing.Size(100, 23)
        Me.txt职务.TabIndex = 327
        '
        'UcLabel7
        '
        Appearance23.BackColor = System.Drawing.Color.SkyBlue
        Appearance23.BackColor2 = System.Drawing.Color.White
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance23.BorderColor = System.Drawing.Color.Black
        Appearance23.BorderColor2 = System.Drawing.Color.Black
        Appearance23.TextHAlignAsString = "Left"
        Appearance23.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance23
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel7.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 326
        Me.UcLabel7.Text = "职务"
        '
        'UcLabel10
        '
        Appearance55.BackColor = System.Drawing.Color.SkyBlue
        Appearance55.BackColor2 = System.Drawing.Color.White
        Appearance55.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance55.BorderColor = System.Drawing.Color.Black
        Appearance55.BorderColor2 = System.Drawing.Color.Black
        Appearance55.TextHAlignAsString = "Left"
        Appearance55.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance55
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel10.Location = New System.Drawing.Point(12, 148)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 322
        Me.UcLabel10.Text = "*作业完成日期"
        '
        'dmt完成日期
        '
        Me.dmt完成日期.Location = New System.Drawing.Point(112, 148)
        Me.dmt完成日期.MaskInput = "yyyy/mm/dd"
        Me.dmt完成日期.Name = "dmt完成日期"
        Me.dmt完成日期.Size = New System.Drawing.Size(100, 22)
        Me.dmt完成日期.TabIndex = 321
        '
        'UcLabel18
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel18.Appearance = Appearance5
        Me.UcLabel18.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel18.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel18.TabIndex = 320
        Me.UcLabel18.Text = "*作业者"
        '
        'UcLabel6
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance4
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel6.Location = New System.Drawing.Point(12, 218)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 313
        Me.UcLabel6.Text = "*产品图号"
        '
        'cmb作业方式
        '
        Me.cmb作业方式.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb作业方式.DisplayLayout.Appearance = Appearance43
        Me.cmb作业方式.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb作业方式.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb作业方式.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb作业方式.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.cmb作业方式.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb作业方式.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.cmb作业方式.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb作业方式.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb作业方式.DisplayLayout.Override.ActiveCellAppearance = Appearance48
        Appearance19.BackColor = System.Drawing.SystemColors.Highlight
        Appearance19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb作业方式.DisplayLayout.Override.ActiveRowAppearance = Appearance19
        Me.cmb作业方式.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb作业方式.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Me.cmb作业方式.DisplayLayout.Override.CardAreaAppearance = Appearance21
        Appearance22.BorderColor = System.Drawing.Color.Silver
        Appearance22.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb作业方式.DisplayLayout.Override.CellAppearance = Appearance22
        Me.cmb作业方式.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb作业方式.DisplayLayout.Override.CellPadding = 0
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb作业方式.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Left"
        Me.cmb作业方式.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.cmb作业方式.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb作业方式.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.Color.Silver
        Me.cmb作业方式.DisplayLayout.Override.RowAppearance = Appearance49
        Me.cmb作业方式.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb作业方式.DisplayLayout.Override.TemplateAddRowAppearance = Appearance51
        Me.cmb作业方式.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb作业方式.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb作业方式.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb作业方式.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cmb作业方式.Location = New System.Drawing.Point(112, 171)
        Me.cmb作业方式.Name = "cmb作业方式"
        Me.cmb作业方式.Size = New System.Drawing.Size(100, 22)
        Me.cmb作业方式.TabIndex = 308
        Me.cmb作业方式.Text = "计件"
        '
        'UcLabel8
        '
        Appearance52.BackColor = System.Drawing.Color.SkyBlue
        Appearance52.BackColor2 = System.Drawing.Color.White
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance52.BorderColor = System.Drawing.Color.Black
        Appearance52.BorderColor2 = System.Drawing.Color.Black
        Appearance52.TextHAlignAsString = "Left"
        Appearance52.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance52
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel8.Location = New System.Drawing.Point(12, 171)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 307
        Me.UcLabel8.Text = "作业方式"
        '
        'txt实际生产数量
        '
        Me.txt实际生产数量.AutoSize = False
        Me.txt实际生产数量.IsDigit = False
        Me.txt实际生产数量.Location = New System.Drawing.Point(112, 289)
        Me.txt实际生产数量.Name = "txt实际生产数量"
        Me.txt实际生产数量.Size = New System.Drawing.Size(100, 23)
        Me.txt实际生产数量.TabIndex = 306
        '
        'UcLabel2
        '
        Appearance58.BackColor = System.Drawing.Color.SkyBlue
        Appearance58.BackColor2 = System.Drawing.Color.White
        Appearance58.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance58.BorderColor = System.Drawing.Color.Black
        Appearance58.BorderColor2 = System.Drawing.Color.Black
        Appearance58.TextHAlignAsString = "Left"
        Appearance58.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance58
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel2.Location = New System.Drawing.Point(12, 289)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 305
        Me.UcLabel2.Text = "*实际包装数量"
        '
        'txt人员名
        '
        Me.txt人员名.AutoSize = False
        Me.txt人员名.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt人员名.IsDigit = False
        Me.txt人员名.Location = New System.Drawing.Point(212, 56)
        Me.txt人员名.Name = "txt人员名"
        Me.txt人员名.ReadOnly = True
        Me.txt人员名.Size = New System.Drawing.Size(114, 21)
        Me.txt人员名.TabIndex = 304
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(112, 55)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(100, 23)
        Me.txt人员编号.TabIndex = 303
        '
        'UcLabel1
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance1
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel1.Location = New System.Drawing.Point(12, 102)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 302
        Me.UcLabel1.Text = "部门名称"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(112, 217)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.ReadOnly = True
        Me.txt产品图号.Size = New System.Drawing.Size(100, 23)
        Me.txt产品图号.TabIndex = 291
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(112, 241)
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.ReadOnly = True
        Me.txt客户名称.Size = New System.Drawing.Size(100, 23)
        Me.txt客户名称.TabIndex = 300
        '
        'UcLabel13
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance3
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel13.Location = New System.Drawing.Point(12, 242)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 290
        Me.UcLabel13.Text = "客户名称"
        '
        'UcLabel25
        '
        Appearance42.BackColor = System.Drawing.Color.SkyBlue
        Appearance42.BackColor2 = System.Drawing.Color.White
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance42.BorderColor = System.Drawing.Color.Black
        Appearance42.BorderColor2 = System.Drawing.Color.Black
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        Me.UcLabel25.Appearance = Appearance42
        Me.UcLabel25.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel25.Location = New System.Drawing.Point(12, 194)
        Me.UcLabel25.Name = "UcLabel25"
        Me.UcLabel25.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel25.TabIndex = 297
        Me.UcLabel25.Text = "*订单编号"
        '
        'txt计划生产数量
        '
        Me.txt计划生产数量.AutoSize = False
        Me.txt计划生产数量.IsDigit = False
        Me.txt计划生产数量.Location = New System.Drawing.Point(112, 265)
        Me.txt计划生产数量.Name = "txt计划生产数量"
        Me.txt计划生产数量.ReadOnly = True
        Me.txt计划生产数量.Size = New System.Drawing.Size(100, 23)
        Me.txt计划生产数量.TabIndex = 296
        '
        'UcLabel17
        '
        Appearance57.BackColor = System.Drawing.Color.SkyBlue
        Appearance57.BackColor2 = System.Drawing.Color.White
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance57.BorderColor = System.Drawing.Color.Black
        Appearance57.BorderColor2 = System.Drawing.Color.Black
        Appearance57.TextHAlignAsString = "Left"
        Appearance57.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance57
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel17.Location = New System.Drawing.Point(12, 265)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 295
        Me.UcLabel17.Text = "计划包装数量"
        '
        'UcLabel16
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel16.Appearance = Appearance2
        Me.UcLabel16.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel16.Location = New System.Drawing.Point(12, 125)
        Me.UcLabel16.Name = "UcLabel16"
        Me.UcLabel16.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel16.TabIndex = 294
        Me.UcLabel16.Text = "*作业开始日期"
        '
        'dmt作业日期
        '
        Me.dmt作业日期.Location = New System.Drawing.Point(112, 125)
        Me.dmt作业日期.MaskInput = "yyyy/mm/dd"
        Me.dmt作业日期.Name = "dmt作业日期"
        Me.dmt作业日期.Size = New System.Drawing.Size(100, 22)
        Me.dmt作业日期.TabIndex = 286
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton2)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(112, 194)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(100, 23)
        Me.txt订单编号.TabIndex = 330
        '
        'frm包装实绩管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt订单编号)
        Me.Controls.Add(Me.txt部门名称)
        Me.Controls.Add(Me.txt职务)
        Me.Controls.Add(Me.UcLabel7)
        Me.Controls.Add(Me.UcLabel10)
        Me.Controls.Add(Me.dmt完成日期)
        Me.Controls.Add(Me.UcLabel18)
        Me.Controls.Add(Me.UcLabel6)
        Me.Controls.Add(Me.cmb作业方式)
        Me.Controls.Add(Me.UcLabel8)
        Me.Controls.Add(Me.txt实际生产数量)
        Me.Controls.Add(Me.UcLabel2)
        Me.Controls.Add(Me.txt人员名)
        Me.Controls.Add(Me.txt人员编号)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.txt产品图号)
        Me.Controls.Add(Me.txt客户名称)
        Me.Controls.Add(Me.UcLabel13)
        Me.Controls.Add(Me.UcLabel25)
        Me.Controls.Add(Me.txt计划生产数量)
        Me.Controls.Add(Me.UcLabel17)
        Me.Controls.Add(Me.UcLabel16)
        Me.Controls.Add(Me.dmt作业日期)
        Me.KeyPreview = True
        Me.Name = "frm包装实绩管理"
        Me.Text = "包装实绩录入"
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
        Me.Controls.SetChildIndex(Me.dmt作业日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel16, 0)
        Me.Controls.SetChildIndex(Me.UcLabel17, 0)
        Me.Controls.SetChildIndex(Me.txt计划生产数量, 0)
        Me.Controls.SetChildIndex(Me.UcLabel25, 0)
        Me.Controls.SetChildIndex(Me.UcLabel13, 0)
        Me.Controls.SetChildIndex(Me.txt客户名称, 0)
        Me.Controls.SetChildIndex(Me.txt产品图号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt人员编号, 0)
        Me.Controls.SetChildIndex(Me.txt人员名, 0)
        Me.Controls.SetChildIndex(Me.UcLabel2, 0)
        Me.Controls.SetChildIndex(Me.txt实际生产数量, 0)
        Me.Controls.SetChildIndex(Me.UcLabel8, 0)
        Me.Controls.SetChildIndex(Me.cmb作业方式, 0)
        Me.Controls.SetChildIndex(Me.UcLabel6, 0)
        Me.Controls.SetChildIndex(Me.UcLabel18, 0)
        Me.Controls.SetChildIndex(Me.dmt完成日期, 0)
        Me.Controls.SetChildIndex(Me.UcLabel10, 0)
        Me.Controls.SetChildIndex(Me.UcLabel7, 0)
        Me.Controls.SetChildIndex(Me.txt职务, 0)
        Me.Controls.SetChildIndex(Me.txt部门名称, 0)
        Me.Controls.SetChildIndex(Me.txt订单编号, 0)
        CType(Me.txt部门名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt职务, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt完成日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb作业方式, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt实际生产数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt计划生产数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt作业日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt部门名称 As UserControl.UCText
    Friend WithEvents txt职务 As UserControl.UCText
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents dmt完成日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel18 As UserControl.UCLabel
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents cmb作业方式 As UserControl.UCCombo
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents txt实际生产数量 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt人员名 As UserControl.UCText
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcLabel25 As UserControl.UCLabel
    Friend WithEvents txt计划生产数量 As UserControl.UCText
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents UcLabel16 As UserControl.UCLabel
    Friend WithEvents dmt作业日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt订单编号 As UserControl.UCText
End Class
