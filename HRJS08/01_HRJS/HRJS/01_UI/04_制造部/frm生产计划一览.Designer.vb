<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产计划一览
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
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("品名")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订货量")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("投产数量")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否整体外协加工")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为抵补品")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为试做品")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("合格标准")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("图纸")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("品名")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订货量")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("投产数量")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否整体外协加工")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为抵补品")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("是否为试做品")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("合格标准")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("图纸")
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
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.dmt完成日期sta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.dmt完成日期end = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.cmb产品状态 = New UserControl.UCCombo(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt客户编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.btn流转票导出 = New UserControl.UCButton(Me.components)
        Me.grid生产计划一览 = New UserControl.UCGrid(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.dmt完成日期sta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.dmt完成日期end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb产品状态, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid生产计划一览, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 6
        Me.btnF12关闭.Text = "F12：关闭"
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 3
        Me.btnF2查询.Tag = "400201"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        Me.btnF3选择.Tag = "400202"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'UcLabel10
        '
        Appearance59.BackColor = System.Drawing.Color.SkyBlue
        Appearance59.BackColor2 = System.Drawing.Color.White
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance59.BorderColor = System.Drawing.Color.Black
        Appearance59.BorderColor2 = System.Drawing.Color.Black
        Appearance59.TextHAlignAsString = "Left"
        Appearance59.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance59
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Location = New System.Drawing.Point(333, 21)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 9
        Me.UcLabel10.Text = "完成日期"
        '
        'dmt完成日期sta
        '
        Me.dmt完成日期sta.Location = New System.Drawing.Point(433, 22)
        Me.dmt完成日期sta.MaskInput = "yyyy/mm/dd"
        Me.dmt完成日期sta.Name = "dmt完成日期sta"
        Me.dmt完成日期sta.Size = New System.Drawing.Size(94, 21)
        Me.dmt完成日期sta.TabIndex = 10
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.Label1)
        Me.UcGroupBox1.Controls.Add(Me.dmt完成日期end)
        Me.UcGroupBox1.Controls.Add(Me.txt订单编号)
        Me.UcGroupBox1.Controls.Add(Me.txt产品图号)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel5)
        Me.UcGroupBox1.Controls.Add(Me.cmb产品状态)
        Me.UcGroupBox1.Controls.Add(Me.txt客户名称)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UcGroupBox1.Controls.Add(Me.txt客户编号)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel6)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel10)
        Me.UcGroupBox1.Controls.Add(Me.dmt完成日期sta)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 80)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "~"
        '
        'dmt完成日期end
        '
        Me.dmt完成日期end.Location = New System.Drawing.Point(547, 22)
        Me.dmt完成日期end.MaskInput = "yyyy/mm/dd"
        Me.dmt完成日期end.Name = "dmt完成日期end"
        Me.dmt完成日期end.Size = New System.Drawing.Size(94, 21)
        Me.dmt完成日期end.TabIndex = 12
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton1)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(106, 21)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(148, 23)
        Me.txt订单编号.TabIndex = 6
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton2)
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(106, 44)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(148, 23)
        Me.txt产品图号.TabIndex = 3
        '
        'UcLabel5
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance3
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(715, 23)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 0
        Me.UcLabel5.Text = "产品状态"
        '
        'cmb产品状态
        '
        Me.cmb产品状态.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb产品状态.DisplayLayout.Appearance = Appearance14
        Me.cmb产品状态.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb产品状态.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance91.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance91.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance91.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance91.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb产品状态.DisplayLayout.GroupByBox.Appearance = Appearance91
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb产品状态.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.cmb产品状态.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance92.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance92.BackColor2 = System.Drawing.SystemColors.Control
        Appearance92.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance92.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb产品状态.DisplayLayout.GroupByBox.PromptAppearance = Appearance92
        Me.cmb产品状态.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb产品状态.DisplayLayout.MaxRowScrollRegions = 1
        Appearance93.BackColor = System.Drawing.SystemColors.Window
        Appearance93.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb产品状态.DisplayLayout.Override.ActiveCellAppearance = Appearance93
        Appearance94.BackColor = System.Drawing.SystemColors.Highlight
        Appearance94.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb产品状态.DisplayLayout.Override.ActiveRowAppearance = Appearance94
        Me.cmb产品状态.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb产品状态.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance95.BackColor = System.Drawing.SystemColors.Window
        Me.cmb产品状态.DisplayLayout.Override.CardAreaAppearance = Appearance95
        Appearance96.BorderColor = System.Drawing.Color.Silver
        Appearance96.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb产品状态.DisplayLayout.Override.CellAppearance = Appearance96
        Me.cmb产品状态.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb产品状态.DisplayLayout.Override.CellPadding = 0
        Appearance97.BackColor = System.Drawing.SystemColors.Control
        Appearance97.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance97.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance97.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance97.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb产品状态.DisplayLayout.Override.GroupByRowAppearance = Appearance97
        Appearance98.TextHAlignAsString = "Left"
        Me.cmb产品状态.DisplayLayout.Override.HeaderAppearance = Appearance98
        Me.cmb产品状态.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb产品状态.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance99.BackColor = System.Drawing.SystemColors.Window
        Appearance99.BorderColor = System.Drawing.Color.Silver
        Me.cmb产品状态.DisplayLayout.Override.RowAppearance = Appearance99
        Me.cmb产品状态.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance100.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb产品状态.DisplayLayout.Override.TemplateAddRowAppearance = Appearance100
        Me.cmb产品状态.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb产品状态.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb产品状态.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb产品状态.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cmb产品状态.Location = New System.Drawing.Point(815, 23)
        Me.cmb产品状态.Name = "cmb产品状态"
        Me.cmb产品状态.Size = New System.Drawing.Size(106, 22)
        Me.cmb产品状态.TabIndex = 1
        Me.cmb产品状态.Text = "抵补品"
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(527, 44)
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.ReadOnly = True
        Me.txt客户名称.Size = New System.Drawing.Size(114, 23)
        Me.txt客户名称.TabIndex = 8
        '
        'UcLabel2
        '
        Appearance63.BackColor = System.Drawing.Color.SkyBlue
        Appearance63.BackColor2 = System.Drawing.Color.White
        Appearance63.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance63.BorderColor = System.Drawing.Color.Black
        Appearance63.BorderColor2 = System.Drawing.Color.Black
        Appearance63.TextHAlignAsString = "Left"
        Appearance63.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance63
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(333, 44)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 5
        Me.UcLabel2.Text = "客户名称"
        '
        'txt客户编号
        '
        Me.txt客户编号.AutoSize = False
        Me.txt客户编号.ButtonsRight.Add(EditorButton3)
        Me.txt客户编号.IsDigit = False
        Me.txt客户编号.Location = New System.Drawing.Point(433, 44)
        Me.txt客户编号.Name = "txt客户编号"
        Me.txt客户编号.Size = New System.Drawing.Size(94, 23)
        Me.txt客户编号.TabIndex = 7
        '
        'UcLabel1
        '
        Appearance101.BackColor = System.Drawing.Color.SkyBlue
        Appearance101.BackColor2 = System.Drawing.Color.White
        Appearance101.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance101.BorderColor = System.Drawing.Color.Black
        Appearance101.BorderColor2 = System.Drawing.Color.Black
        Appearance101.TextHAlignAsString = "Left"
        Appearance101.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance101
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.Text = "产品总图号"
        '
        'UcLabel6
        '
        Appearance64.BackColor = System.Drawing.Color.SkyBlue
        Appearance64.BackColor2 = System.Drawing.Color.White
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance64.BorderColor = System.Drawing.Color.Black
        Appearance64.BorderColor2 = System.Drawing.Color.Black
        Appearance64.TextHAlignAsString = "Left"
        Appearance64.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance64
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 4
        Me.UcLabel6.Text = "订单编号"
        '
        'btn流转票导出
        '
        Me.btn流转票导出.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance65.BackColor = System.Drawing.SystemColors.Control
        Appearance65.BackColor2 = System.Drawing.SystemColors.Control
        Appearance65.TextHAlignAsString = "Center"
        Appearance65.TextVAlignAsString = "Middle"
        Me.btn流转票导出.Appearance = Appearance65
        Me.btn流转票导出.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btn流转票导出.FSearchButtonName = ""
        Me.btn流转票导出.Location = New System.Drawing.Point(830, 12)
        Me.btn流转票导出.Name = "btn流转票导出"
        Me.btn流转票导出.Size = New System.Drawing.Size(80, 34)
        Me.btn流转票导出.TabIndex = 5
        Me.btn流转票导出.Tag = "400203"
        Me.btn流转票导出.Text = "F11:流转票导出"
        '
        'grid生产计划一览
        '
        Me.grid生产计划一览.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance32.BackColor = System.Drawing.Color.LightGray
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextVAlignAsString = "Middle"
        Me.grid生产计划一览.DisplayLayout.Appearance = Appearance32
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 4
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 5
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.VisiblePosition = 7
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.VisiblePosition = 8
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 9
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.VisiblePosition = 11
        UltraGridColumn27.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn27.Header.VisiblePosition = 12
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        Me.grid生产计划一览.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid生产计划一览.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid生产计划一览.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产计划一览.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产计划一览.DisplayLayout.GroupByBox.Appearance = Appearance33
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产计划一览.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance34
        Me.grid生产计划一览.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance35.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance35.BackColor2 = System.Drawing.SystemColors.Control
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产计划一览.DisplayLayout.GroupByBox.PromptAppearance = Appearance35
        Me.grid生产计划一览.DisplayLayout.MaxColScrollRegions = 1
        Me.grid生产计划一览.DisplayLayout.MaxRowScrollRegions = 1
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.grid生产计划一览.DisplayLayout.Override.ActiveCellAppearance = Appearance36
        Appearance37.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance37.ForeColor = System.Drawing.Color.Black
        Me.grid生产计划一览.DisplayLayout.Override.ActiveRowAppearance = Appearance37
        Me.grid生产计划一览.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid生产计划一览.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid生产计划一览.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grid生产计划一览.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产计划一览.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Me.grid生产计划一览.DisplayLayout.Override.CardAreaAppearance = Appearance38
        Appearance39.BorderColor = System.Drawing.Color.Silver
        Appearance39.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid生产计划一览.DisplayLayout.Override.CellAppearance = Appearance39
        Me.grid生产计划一览.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid生产计划一览.DisplayLayout.Override.CellPadding = 0
        Me.grid生产计划一览.DisplayLayout.Override.DefaultRowHeight = 20
        Me.grid生产计划一览.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance40.BackColor = System.Drawing.SystemColors.Control
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产计划一览.DisplayLayout.Override.GroupByRowAppearance = Appearance40
        Appearance41.TextHAlignAsString = "Left"
        Me.grid生产计划一览.DisplayLayout.Override.HeaderAppearance = Appearance41
        Me.grid生产计划一览.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grid生产计划一览.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance42.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid生产计划一览.DisplayLayout.Override.RowAlternateAppearance = Appearance42
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.Color.Silver
        Me.grid生产计划一览.DisplayLayout.Override.RowAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Center"
        Appearance44.TextVAlignAsString = "Middle"
        Me.grid生产计划一览.DisplayLayout.Override.RowSelectorAppearance = Appearance44
        Me.grid生产计划一览.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid生产计划一览.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid生产计划一览.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid生产计划一览.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.grid生产计划一览.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grid生产计划一览.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grid生产计划一览.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grid生产计划一览.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid生产计划一览.DisplayLayout.Override.TemplateAddRowAppearance = Appearance45
        Me.grid生产计划一览.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid生产计划一览.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid生产计划一览.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grid生产计划一览.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid生产计划一览.Location = New System.Drawing.Point(12, 138)
        Me.grid生产计划一览.Name = "grid生产计划一览"
        Me.grid生产计划一览.Size = New System.Drawing.Size(984, 523)
        Me.grid生产计划一览.TabIndex = 453
        Me.grid生产计划一览.Text = "UcGrid1"
        '
        'frm生产计划一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grid生产计划一览)
        Me.Controls.Add(Me.btn流转票导出)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm生产计划一览"
        Me.Text = "生产计划查询"
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.btn流转票导出, 0)
        Me.Controls.SetChildIndex(Me.grid生产计划一览, 0)
        CType(Me.dmt完成日期sta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.dmt完成日期end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb产品状态, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid生产计划一览, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents dmt完成日期sta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents btn流转票导出 As UserControl.UCButton
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt客户编号 As UserControl.UCText
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents cmb产品状态 As UserControl.UCCombo
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents dmt完成日期end As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grid生产计划一览 As UserControl.UCGrid
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
