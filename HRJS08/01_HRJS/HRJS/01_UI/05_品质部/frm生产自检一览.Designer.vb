<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产自检一览

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("作业者")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("本道工序")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("本道工序编号")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("图纸尺寸")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("公差")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("自检时间")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("自检结果")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良品数量")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("待修品数量")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品数量")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.grid生产自检一览 = New UserControl.UCGrid(Me.components)
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt作业者名称 = New UserControl.UCText(Me.components)
        Me.txt人员编号 = New UserControl.UCText(Me.components)
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel25 = New UserControl.UCLabel(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.UcLabel18 = New UserControl.UCLabel(Me.components)
        Me.dmt自检日期end = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.UcLabel16 = New UserControl.UCLabel(Me.components)
        Me.dmt自检日期sta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.btnF11生产数据导出 = New UserControl.UCButton(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.grid生产自检一览, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt作业者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt自检日期end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dmt自检日期sta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'btnF2查询
        '
        Me.btnF2查询.Tag = "402001"
        '
        'btnF3选择
        '
        Me.btnF3选择.Tag = "402002"
        '
        'btnF1清空
        '
        '
        'grid生产自检一览
        '
        Me.grid生产自检一览.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.grid生产自检一览.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 72
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
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn10.Width = 53
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.grid生产自检一览.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid生产自检一览.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid生产自检一览.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产自检一览.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产自检一览.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产自检一览.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.grid生产自检一览.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid生产自检一览.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.grid生产自检一览.DisplayLayout.MaxColScrollRegions = 1
        Me.grid生产自检一览.DisplayLayout.MaxRowScrollRegions = 1
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.grid生产自检一览.DisplayLayout.Override.ActiveCellAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.grid生产自检一览.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.grid生产自检一览.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid生产自检一览.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid生产自检一览.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grid生产自检一览.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid生产自检一览.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.grid生产自检一览.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid生产自检一览.DisplayLayout.Override.CellAppearance = Appearance11
        Me.grid生产自检一览.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid生产自检一览.DisplayLayout.Override.CellPadding = 0
        Me.grid生产自检一览.DisplayLayout.Override.DefaultRowHeight = 20
        Me.grid生产自检一览.DisplayLayout.Override.ExpansionIndicator = Infragistics.Win.UltraWinGrid.ShowExpansionIndicator.CheckOnDisplay
        Appearance12.BackColor = System.Drawing.SystemColors.Control
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.grid生产自检一览.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Left"
        Me.grid生产自检一览.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.grid生产自检一览.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grid生产自检一览.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grid生产自检一览.DisplayLayout.Override.RowAlternateAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Me.grid生产自检一览.DisplayLayout.Override.RowAppearance = Appearance16
        Appearance17.TextHAlignAsString = "Center"
        Appearance17.TextVAlignAsString = "Middle"
        Me.grid生产自检一览.DisplayLayout.Override.RowSelectorAppearance = Appearance17
        Me.grid生产自检一览.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid生产自检一览.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid生产自检一览.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid生产自检一览.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.grid生产自检一览.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grid生产自检一览.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grid生产自检一览.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grid生产自检一览.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid生产自检一览.DisplayLayout.Override.TemplateAddRowAppearance = Appearance18
        Me.grid生产自检一览.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid生产自检一览.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid生产自检一览.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grid生产自检一览.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid生产自检一览.Location = New System.Drawing.Point(12, 159)
        Me.grid生产自检一览.Name = "grid生产自检一览"
        Me.grid生产自检一览.Size = New System.Drawing.Size(984, 521)
        Me.grid生产自检一览.TabIndex = 56
        Me.grid生产自检一览.Text = "UcGrid1"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt作业者名称)
        Me.UltraGroupBox1.Controls.Add(Me.txt人员编号)
        Me.UltraGroupBox1.Controls.Add(Me.txt订单编号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel25)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.txt产品图号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel18)
        Me.UltraGroupBox1.Controls.Add(Me.dmt自检日期end)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel16)
        Me.UltraGroupBox1.Controls.Add(Me.dmt自检日期sta)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 101)
        Me.UltraGroupBox1.TabIndex = 55
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt作业者名称
        '
        Me.txt作业者名称.AutoSize = False
        Me.txt作业者名称.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt作业者名称.IsDigit = False
        Me.txt作业者名称.Location = New System.Drawing.Point(240, 22)
        Me.txt作业者名称.Name = "txt作业者名称"
        Me.txt作业者名称.ReadOnly = True
        Me.txt作业者名称.Size = New System.Drawing.Size(135, 23)
        Me.txt作业者名称.TabIndex = 290
        '
        'txt人员编号
        '
        Me.txt人员编号.AutoSize = False
        Me.txt人员编号.ButtonsRight.Add(EditorButton1)
        Me.txt人员编号.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt人员编号.IsDigit = False
        Me.txt人员编号.Location = New System.Drawing.Point(106, 23)
        Me.txt人员编号.Name = "txt人员编号"
        Me.txt人员编号.Size = New System.Drawing.Size(134, 21)
        Me.txt人员编号.TabIndex = 289
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton2)
        Me.txt订单编号.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(476, 44)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(100, 21)
        Me.txt订单编号.TabIndex = 288
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
        Me.UcLabel25.Location = New System.Drawing.Point(376, 44)
        Me.UcLabel25.Name = "UcLabel25"
        Me.UcLabel25.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel25.TabIndex = 287
        Me.UcLabel25.Text = "订单编号"
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
        Me.UcLabel6.Location = New System.Drawing.Point(6, 47)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 284
        Me.UcLabel6.Text = "产品图号"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton3)
        Me.txt产品图号.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(106, 47)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(134, 21)
        Me.txt产品图号.TabIndex = 282
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
        Me.UcLabel18.Location = New System.Drawing.Point(6, 23)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel18.TabIndex = 285
        Me.UcLabel18.Text = "作业者"
        '
        'dmt自检日期end
        '
        Me.dmt自检日期end.Location = New System.Drawing.Point(587, 22)
        Me.dmt自检日期end.MaskInput = "yyyy/mm/dd"
        Me.dmt自检日期end.Name = "dmt自检日期end"
        Me.dmt自检日期end.Size = New System.Drawing.Size(98, 21)
        Me.dmt自检日期end.TabIndex = 276
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(576, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "~"
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
        Me.UcLabel16.Location = New System.Drawing.Point(376, 21)
        Me.UcLabel16.Name = "UcLabel16"
        Me.UcLabel16.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel16.TabIndex = 207
        Me.UcLabel16.Text = "自检日期"
        '
        'dmt自检日期sta
        '
        Me.dmt自检日期sta.Location = New System.Drawing.Point(476, 22)
        Me.dmt自检日期sta.MaskInput = "yyyy/mm/dd"
        Me.dmt自检日期sta.Name = "dmt自检日期sta"
        Me.dmt自检日期sta.Size = New System.Drawing.Size(100, 21)
        Me.dmt自检日期sta.TabIndex = 206
        '
        'btnF11生产数据导出
        '
        Me.btnF11生产数据导出.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.Control
        Appearance14.TextHAlignAsString = "Center"
        Appearance14.TextVAlignAsString = "Middle"
        Me.btnF11生产数据导出.Appearance = Appearance14
        Me.btnF11生产数据导出.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11生产数据导出.FSearchButtonName = ""
        Me.btnF11生产数据导出.Location = New System.Drawing.Point(828, 12)
        Me.btnF11生产数据导出.Name = "btnF11生产数据导出"
        Me.btnF11生产数据导出.Size = New System.Drawing.Size(82, 34)
        Me.btnF11生产数据导出.TabIndex = 183
        Me.btnF11生产数据导出.Tag = "402003"
        Me.btnF11生产数据导出.Text = "F11:生产数据导出"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frm生产自检一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF11生产数据导出)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.grid生产自检一览)
        Me.KeyPreview = True
        Me.Name = "frm生产自检一览"
        Me.Text = "生产自检一览"
        Me.Controls.SetChildIndex(Me.grid生产自检一览, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF11生产数据导出, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.grid生产自检一览, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt作业者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt自检日期end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dmt自检日期sta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid生产自检一览 As UserControl.UCGrid
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel16 As UserControl.UCLabel
    Friend WithEvents dmt自检日期sta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dmt自检日期end As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents UcLabel18 As UserControl.UCLabel
    Friend WithEvents UcLabel25 As UserControl.UCLabel
    Friend WithEvents btnF11生产数据导出 As UserControl.UCButton
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txt人员编号 As UserControl.UCText
    Friend WithEvents txt作业者名称 As UserControl.UCText
End Class

