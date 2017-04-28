<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm生产检查一览
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
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("上级图号")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品名称")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序名称")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产数量")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查内容")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查数量")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良数量")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良原因")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理结果")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查者")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查日期")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Me.查询条件 = New UserControl.UCGroupBox(Me.components)
        Me.txt检查者名称 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt检查者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.txt检查日期s = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.txt检查日期e = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.gridList = New UserControl.UCGrid(Me.components)
        CType(Me.查询条件, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.查询条件.SuspendLayout()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查日期s, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查日期e, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        '
        'btnF2查询
        '
        Me.btnF2查询.Tag = "300201"
        '
        'btnF3选择
        '
        Me.btnF3选择.Tag = "300202"
        '
        'btnF1清空
        '
        '
        '查询条件
        '
        Me.查询条件.Controls.Add(Me.txt检查者名称)
        Me.查询条件.Controls.Add(Me.UcLabel3)
        Me.查询条件.Controls.Add(Me.txt检查者编号)
        Me.查询条件.Controls.Add(Me.UcLabel6)
        Me.查询条件.Controls.Add(Me.txt订单编号)
        Me.查询条件.Controls.Add(Me.Label1)
        Me.查询条件.Controls.Add(Me.UcLabel12)
        Me.查询条件.Controls.Add(Me.txt检查日期s)
        Me.查询条件.Controls.Add(Me.txt检查日期e)
        Me.查询条件.Location = New System.Drawing.Point(12, 52)
        Me.查询条件.Name = "查询条件"
        Me.查询条件.Size = New System.Drawing.Size(984, 83)
        Me.查询条件.TabIndex = 55
        Me.查询条件.Text = "查询条件"
        Me.查询条件.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt检查者名称
        '
        Me.txt检查者名称.AutoSize = False
        Me.txt检查者名称.IsDigit = False
        Me.txt检查者名称.Location = New System.Drawing.Point(200, 19)
        Me.txt检查者名称.Name = "txt检查者名称"
        Me.txt检查者名称.ReadOnly = True
        Me.txt检查者名称.Size = New System.Drawing.Size(114, 23)
        Me.txt检查者名称.TabIndex = 157
        '
        'UcLabel3
        '
        Appearance72.BackColor = System.Drawing.Color.SkyBlue
        Appearance72.BackColor2 = System.Drawing.Color.White
        Appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance72.BorderColor = System.Drawing.Color.Black
        Appearance72.BorderColor2 = System.Drawing.Color.Black
        Appearance72.TextHAlignAsString = "Left"
        Appearance72.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance72
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(6, 19)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 159
        Me.UcLabel3.Text = "检查员"
        '
        'txt检查者编号
        '
        Me.txt检查者编号.AutoSize = False
        Me.txt检查者编号.ButtonsRight.Add(EditorButton1)
        Me.txt检查者编号.IsDigit = False
        Me.txt检查者编号.Location = New System.Drawing.Point(106, 19)
        Me.txt检查者编号.Name = "txt检查者编号"
        Me.txt检查者编号.Size = New System.Drawing.Size(94, 23)
        Me.txt检查者编号.TabIndex = 158
        '
        'UcLabel6
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance2
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(376, 21)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 159
        Me.UcLabel6.Text = "订单编号"
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton2)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(476, 21)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(92, 23)
        Me.txt订单编号.TabIndex = 158
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "~"
        '
        'UcLabel12
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance18
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(6, 48)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 127
        Me.UcLabel12.Text = "检查日期"
        '
        'txt检查日期s
        '
        Me.txt检查日期s.Location = New System.Drawing.Point(106, 49)
        Me.txt检查日期s.MaskInput = "yyyy/mm/dd"
        Me.txt检查日期s.Name = "txt检查日期s"
        Me.txt检查日期s.Size = New System.Drawing.Size(98, 21)
        Me.txt检查日期s.TabIndex = 142
        '
        'txt检查日期e
        '
        Me.txt检查日期e.Location = New System.Drawing.Point(215, 49)
        Me.txt检查日期e.MaskInput = "yyyy/mm/dd"
        Me.txt检查日期e.Name = "txt检查日期e"
        Me.txt检查日期e.Size = New System.Drawing.Size(99, 21)
        Me.txt检查日期e.TabIndex = 145
        '
        'gridList
        '
        Appearance20.BackColor = System.Drawing.Color.LightGray
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Appearance = Appearance20
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance21
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance22
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance23
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        Me.gridList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.GroupByBox.Appearance = Appearance24
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance25
        Me.gridList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance26.BackColor2 = System.Drawing.SystemColors.Control
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridList.DisplayLayout.GroupByBox.PromptAppearance = Appearance26
        Me.gridList.DisplayLayout.MaxColScrollRegions = 1
        Me.gridList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveCellAppearance = Appearance27
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.gridList.DisplayLayout.Override.ActiveRowAppearance = Appearance28
        Me.gridList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.gridList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.CardAreaAppearance = Appearance29
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Appearance30.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.gridList.DisplayLayout.Override.CellAppearance = Appearance30
        Me.gridList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.gridList.DisplayLayout.Override.CellPadding = 0
        Me.gridList.DisplayLayout.Override.DefaultRowHeight = 20
        Appearance31.BackColor = System.Drawing.SystemColors.Control
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.gridList.DisplayLayout.Override.GroupByRowAppearance = Appearance31
        Appearance32.TextHAlignAsString = "Left"
        Me.gridList.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.gridList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.gridList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridList.DisplayLayout.Override.RowAlternateAppearance = Appearance33
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Me.gridList.DisplayLayout.Override.RowAppearance = Appearance34
        Appearance35.TextHAlignAsString = "Center"
        Appearance35.TextVAlignAsString = "Middle"
        Me.gridList.DisplayLayout.Override.RowSelectorAppearance = Appearance35
        Me.gridList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.gridList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.gridList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.gridList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.gridList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.gridList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.gridList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.gridList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.gridList.Location = New System.Drawing.Point(12, 141)
        Me.gridList.Name = "gridList"
        Me.gridList.Size = New System.Drawing.Size(984, 537)
        Me.gridList.TabIndex = 59
        Me.gridList.Text = "UcGrid1"
        '
        'frm生产检查一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.gridList)
        Me.Controls.Add(Me.查询条件)
        Me.KeyPreview = True
        Me.Name = "frm生产检查一览"
        Me.Text = "生产检查一览"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.查询条件, 0)
        Me.Controls.SetChildIndex(Me.gridList, 0)
        CType(Me.查询条件, System.ComponentModel.ISupportInitialize).EndInit()
        Me.查询条件.ResumeLayout(False)
        Me.查询条件.PerformLayout()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查日期s, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查日期e, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 查询条件 As UserControl.UCGroupBox
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt检查日期s As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt检查日期e As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents txt检查者名称 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents txt检查者编号 As UserControl.UCText
    Friend WithEvents gridList As UserControl.UCGrid
End Class
