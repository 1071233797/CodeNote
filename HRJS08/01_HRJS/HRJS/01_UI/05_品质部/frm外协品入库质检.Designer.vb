<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协品入库质检

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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("主图号")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("分图号名称")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("工序编号")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库数量")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance("KeyChar")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("检查数量")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良数量")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("不良原因")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理结果")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.grid外协品入库质检 = New UserControl.UCGridEdit(Me.components)
        Me.txt入库申请单编号 = New UserControl.UCText(Me.components)
        Me.txt检查者名称 = New UserControl.UCText(Me.components)
        Me.txt检查者编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.btnF5直接入库 = New UserControl.UCButton(Me.components)
        CType(Me.grid外协品入库质检, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入库申请单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.TabIndex = 7
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 3
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 5
        '
        'btnF2编辑
        '
        Me.btnF2编辑.Visible = False
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 4
        '
        'UcLabel3
        '
        Appearance12.BackColor = System.Drawing.Color.SkyBlue
        Appearance12.BackColor2 = System.Drawing.Color.White
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance12.BorderColor = System.Drawing.Color.Black
        Appearance12.BorderColor2 = System.Drawing.Color.Black
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance12
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel3.Location = New System.Drawing.Point(12, 56)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 190
        Me.UcLabel3.Text = "*入库申请单"
        '
        'grid外协品入库质检
        '
        Me.grid外协品入库质检.ActiveFormFeatureCode = ""
        Me.grid外协品入库质检.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid外协品入库质检.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid外协品入库质检.BackColorFlg = True
        Me.grid外协品入库质检.DataMember = Nothing
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid外协品入库质检.DisplayLayout.Appearance = Appearance2
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance3.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance3
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 57
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance4
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.TabStop = False
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.ForeColor = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.TabStop = False
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance6.ForeColor = System.Drawing.Color.Black
        UltraGridColumn12.CellAppearance = Appearance6
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn12.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.grid外协品入库质检.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid外协品入库质检.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid外协品入库质检.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.grid外协品入库质检.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid外协品入库质检.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.grid外协品入库质检.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid外协品入库质检.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid外协品入库质检.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.grid外协品入库质检.DisplayLayout.MaxColScrollRegions = 1
        Me.grid外协品入库质检.DisplayLayout.MaxRowScrollRegions = 1
        Appearance10.BackColor = System.Drawing.Color.White
        Me.grid外协品入库质检.DisplayLayout.Override.AddRowAppearance = Appearance10
        Me.grid外协品入库质检.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid外协品入库质检.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid外协品入库质检.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid外协品入库质检.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid外协品入库质检.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid外协品入库质检.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.grid外协品入库质检.DisplayLayout.Override.CardAreaAppearance = Appearance11
        Appearance13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance13.TextVAlignAsString = "Middle"
        Me.grid外协品入库质检.DisplayLayout.Override.CellAppearance = Appearance13
        Me.grid外协品入库质检.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid外协品入库质检.DisplayLayout.Override.CellPadding = 0
        Appearance14.BackColor = System.Drawing.SystemColors.Control
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.grid外协品入库质检.DisplayLayout.Override.GroupByRowAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Center"
        Appearance15.TextVAlignAsString = "Middle"
        Me.grid外协品入库质检.DisplayLayout.Override.HeaderAppearance = Appearance15
        Me.grid外协品入库质检.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid外协品入库质检.DisplayLayout.Override.MinRowHeight = 20
        Appearance16.BackColor = System.Drawing.Color.White
        Me.grid外协品入库质检.DisplayLayout.Override.RowAlternateAppearance = Appearance16
        Appearance18.BackColor = System.Drawing.Color.White
        Appearance18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid外协品入库质检.DisplayLayout.Override.RowAppearance = Appearance18
        Appearance19.TextHAlignAsString = "Center"
        Me.grid外协品入库质检.DisplayLayout.Override.RowSelectorAppearance = Appearance19
        Me.grid外协品入库质检.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid外协品入库质检.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid外协品入库质检.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid外协品入库质检.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid外协品入库质检.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance20.BackColor = System.Drawing.Color.White
        Me.grid外协品入库质检.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid外协品入库质检.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid外协品入库质检.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid外协品入库质检.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid外协品入库质检.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid外协品入库质检.FirstFocusColumnIndex = -1
        Me.grid外协品入库质检.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid外协品入库质检.InsertColumn = ""
        Me.grid外协品入库质检.InsertColumn1 = ""
        Me.grid外协品入库质检.InsertColumn2 = ""
        Me.grid外协品入库质检.InsertValue = ""
        Me.grid外协品入库质检.IsItiranCheckBoxFlag = False
        Me.grid外协品入库质检.ItiranEditFlg = False
        Me.grid外协品入库质检.Location = New System.Drawing.Point(9, 108)
        Me.grid外协品入库质检.MasterFlg = False
        Me.grid外协品入库质检.MinHeaderHeight = 24
        Me.grid外协品入库质检.MinRowHeight = 20
        Me.grid外协品入库质检.Name = "grid外协品入库质检"
        Me.grid外协品入库质检.RowAltAppColor = System.Drawing.Color.White
        Me.grid外协品入库质检.RowAppColor = System.Drawing.Color.White
        Me.grid外协品入库质检.Size = New System.Drawing.Size(987, 528)
        Me.grid外协品入库质检.TabIndex = 2
        Me.grid外协品入库质检.Text = "UcGridEdit1"
        '
        'txt入库申请单编号
        '
        Me.txt入库申请单编号.AutoSize = False
        Me.txt入库申请单编号.ButtonsRight.Add(EditorButton1)
        Me.txt入库申请单编号.IsDigit = False
        Me.txt入库申请单编号.Location = New System.Drawing.Point(112, 56)
        Me.txt入库申请单编号.Name = "txt入库申请单编号"
        Me.txt入库申请单编号.Size = New System.Drawing.Size(186, 23)
        Me.txt入库申请单编号.TabIndex = 0
        '
        'txt检查者名称
        '
        Me.txt检查者名称.AutoSize = False
        Me.txt检查者名称.IsDigit = False
        Me.txt检查者名称.Location = New System.Drawing.Point(206, 79)
        Me.txt检查者名称.Name = "txt检查者名称"
        Me.txt检查者名称.ReadOnly = True
        Me.txt检查者名称.Size = New System.Drawing.Size(92, 23)
        Me.txt检查者名称.TabIndex = 422
        '
        'txt检查者编号
        '
        Me.txt检查者编号.AutoSize = False
        Me.txt检查者编号.ButtonsRight.Add(EditorButton2)
        Me.txt检查者编号.IsDigit = False
        Me.txt检查者编号.Location = New System.Drawing.Point(112, 79)
        Me.txt检查者编号.Name = "txt检查者编号"
        Me.txt检查者编号.Size = New System.Drawing.Size(94, 23)
        Me.txt检查者编号.TabIndex = 1
        '
        'UcLabel1
        '
        Appearance17.BackColor = System.Drawing.Color.SkyBlue
        Appearance17.BackColor2 = System.Drawing.Color.White
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance17.BorderColor = System.Drawing.Color.Black
        Appearance17.BorderColor2 = System.Drawing.Color.Black
        Appearance17.TextHAlignAsString = "Left"
        Appearance17.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance17
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 79)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 420
        Me.UcLabel1.Text = "检查者"
        '
        'btnF5直接入库
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.Control
        Appearance25.TextHAlignAsString = "Center"
        Appearance25.TextVAlignAsString = "Middle"
        Me.btnF5直接入库.Appearance = Appearance25
        Me.btnF5直接入库.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF5直接入库.FSearchButtonName = ""
        Me.btnF5直接入库.Location = New System.Drawing.Point(375, 12)
        Me.btnF5直接入库.Name = "btnF5直接入库"
        Me.btnF5直接入库.Size = New System.Drawing.Size(78, 34)
        Me.btnF5直接入库.TabIndex = 6
        Me.btnF5直接入库.Text = "F5:直接入库"
        '
        'frm外协品入库质检
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.txt检查者名称)
        Me.Controls.Add(Me.txt检查者编号)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.UcLabel3)
        Me.Controls.Add(Me.txt入库申请单编号)
        Me.Controls.Add(Me.btnF5直接入库)
        Me.Controls.Add(Me.grid外协品入库质检)
        Me.Name = "frm外协品入库质检"
        Me.Text = "外协品入库质检"
        Me.Controls.SetChildIndex(Me.grid外协品入库质检, 0)
        Me.Controls.SetChildIndex(Me.btnF5直接入库, 0)
        Me.Controls.SetChildIndex(Me.txt入库申请单编号, 0)
        Me.Controls.SetChildIndex(Me.UcLabel3, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.txt检查者编号, 0)
        Me.Controls.SetChildIndex(Me.txt检查者名称, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.grid外协品入库质检, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入库申请单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt检查者编号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents grid外协品入库质检 As UserControl.UCGridEdit
    Friend WithEvents txt入库申请单编号 As UserControl.UCText
    Friend WithEvents txt检查者名称 As UserControl.UCText
    Friend WithEvents txt检查者编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents btnF5直接入库 As UserControl.UCButton
End Class
