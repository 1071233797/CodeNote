<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm外协品盘点管理

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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("名称")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库数量")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("入库日期")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("盘点数量")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("差额调整数量")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理方式")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("调整后在库数量")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("库存状态")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("在库总数")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.UcText2 = New UserControl.UCText(Me.components)
        Me.UcText5 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.UcText3 = New UserControl.UCText(Me.components)
        Me.UcText4 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UltraDateTimeEditor2 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.UcGridEdit1 = New UserControl.UCGridEdit(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 5
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 3
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.UcText2)
        Me.UcGroupBox1.Controls.Add(Me.UcText5)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UcGroupBox1.Controls.Add(Me.UcText3)
        Me.UcGroupBox1.Controls.Add(Me.UcText4)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UcGroupBox1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel13)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UcGroupBox1.Controls.Add(Me.UltraDateTimeEditor2)
        Me.UcGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 75)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UcText2
        '
        Me.UcText2.AutoSize = False
        Me.UcText2.ButtonsRight.Add(EditorButton1)
        Me.UcText2.IsDigit = False
        Me.UcText2.Location = New System.Drawing.Point(106, 21)
        Me.UcText2.Name = "UcText2"
        Me.UcText2.Size = New System.Drawing.Size(134, 23)
        Me.UcText2.TabIndex = 0
        '
        'UcText5
        '
        Me.UcText5.AutoSize = False
        Me.UcText5.ButtonsRight.Add(EditorButton2)
        Me.UcText5.IsDigit = False
        Me.UcText5.Location = New System.Drawing.Point(106, 44)
        Me.UcText5.Name = "UcText5"
        Me.UcText5.Size = New System.Drawing.Size(134, 23)
        Me.UcText5.TabIndex = 1
        '
        'UcLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance3
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 211
        Me.UcLabel3.Text = "订单编号"
        '
        'UcText3
        '
        Me.UcText3.AutoSize = False
        Me.UcText3.IsDigit = False
        Me.UcText3.Location = New System.Drawing.Point(614, 21)
        Me.UcText3.Name = "UcText3"
        Me.UcText3.ReadOnly = True
        Me.UcText3.Size = New System.Drawing.Size(126, 23)
        Me.UcText3.TabIndex = 3
        '
        'UcText4
        '
        Me.UcText4.AutoSize = False
        Me.UcText4.ButtonsRight.Add(EditorButton3)
        Me.UcText4.IsDigit = False
        Me.UcText4.Location = New System.Drawing.Point(512, 21)
        Me.UcText4.Name = "UcText4"
        Me.UcText4.Size = New System.Drawing.Size(102, 23)
        Me.UcText4.TabIndex = 2
        '
        'UcLabel2
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance4
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(412, 21)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 208
        Me.UcLabel2.Text = "客户名称"
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.DateTime = New Date(2016, 5, 22, 0, 0, 0, 0)
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(631, 44)
        Me.UltraDateTimeEditor1.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(109, 21)
        Me.UltraDateTimeEditor1.TabIndex = 5
        Me.UltraDateTimeEditor1.Value = New Date(2016, 5, 22, 0, 0, 0, 0)
        '
        'UcLabel13
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance2
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 199
        Me.UcLabel13.Text = "产品图号"
        '
        'UcLabel1
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance6
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(412, 44)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 200
        Me.UcLabel1.Text = "入库日期"
        '
        'UltraDateTimeEditor2
        '
        Me.UltraDateTimeEditor2.DateTime = New Date(2016, 5, 22, 0, 0, 0, 0)
        Me.UltraDateTimeEditor2.Location = New System.Drawing.Point(512, 44)
        Me.UltraDateTimeEditor2.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor2.Name = "UltraDateTimeEditor2"
        Me.UltraDateTimeEditor2.Size = New System.Drawing.Size(103, 21)
        Me.UltraDateTimeEditor2.TabIndex = 4
        Me.UltraDateTimeEditor2.Value = New Date(2016, 5, 22, 0, 0, 0, 0)
        '
        'UltraLabel1
        '
        Me.UltraLabel1.Location = New System.Drawing.Point(614, 47)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(19, 18)
        Me.UltraLabel1.TabIndex = 204
        Me.UltraLabel1.Text = "~"
        '
        'UcGridEdit1
        '
        Me.UcGridEdit1.ActiveFormFeatureCode = ""
        Me.UcGridEdit1.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.UcGridEdit1.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGridEdit1.BackColorFlg = True
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Appearance = Appearance5
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance7.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance7
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance8.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance8
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance32.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance32
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance33.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance33
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance34.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance34
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance35.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance35
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.ForeColor = System.Drawing.Color.Black
        UltraGridColumn7.CellAppearance = Appearance36
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn7.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn7.Width = 91
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.ForeColor = System.Drawing.Color.Black
        UltraGridColumn8.CellAppearance = Appearance37
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn8.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance38.ForeColor = System.Drawing.Color.Black
        UltraGridColumn9.CellAppearance = Appearance38
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn9.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn9.Width = 69
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance39.ForeColor = System.Drawing.Color.Black
        UltraGridColumn10.CellAppearance = Appearance39
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn10.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.UcGridEdit1.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.UcGridEdit1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Appearance = Appearance40
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance41
        Me.UcGridEdit1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UcGridEdit1.DisplayLayout.GroupByBox.Hidden = True
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance42.BackColor2 = System.Drawing.SystemColors.Control
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UcGridEdit1.DisplayLayout.GroupByBox.PromptAppearance = Appearance42
        Me.UcGridEdit1.DisplayLayout.MaxColScrollRegions = 1
        Me.UcGridEdit1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance43.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.AddRowAppearance = Appearance43
        Me.UcGridEdit1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.UcGridEdit1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.UcGridEdit1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.UcGridEdit1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.UcGridEdit1.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.UcGridEdit1.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.CardAreaAppearance = Appearance44
        Appearance45.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance45.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance45.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.CellAppearance = Appearance45
        Me.UcGridEdit1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UcGridEdit1.DisplayLayout.Override.CellPadding = 0
        Appearance46.BackColor = System.Drawing.SystemColors.Control
        Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance46.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.BorderColor = System.Drawing.SystemColors.Window
        Me.UcGridEdit1.DisplayLayout.Override.GroupByRowAppearance = Appearance46
        Appearance47.TextHAlignAsString = "Center"
        Appearance47.TextVAlignAsString = "Middle"
        Me.UcGridEdit1.DisplayLayout.Override.HeaderAppearance = Appearance47
        Me.UcGridEdit1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.UcGridEdit1.DisplayLayout.Override.MinRowHeight = 20
        Appearance48.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.RowAlternateAppearance = Appearance48
        Appearance49.BackColor = System.Drawing.Color.White
        Appearance49.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.UcGridEdit1.DisplayLayout.Override.RowAppearance = Appearance49
        Appearance50.TextHAlignAsString = "Center"
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorAppearance = Appearance50
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UcGridEdit1.DisplayLayout.Override.RowSelectorWidth = 40
        Me.UcGridEdit1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance51.BackColor = System.Drawing.Color.White
        Me.UcGridEdit1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance51
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.UcGridEdit1.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.UcGridEdit1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UcGridEdit1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UcGridEdit1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.UcGridEdit1.FirstFocusColumnIndex = -1
        Me.UcGridEdit1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcGridEdit1.InsertColumn = ""
        Me.UcGridEdit1.InsertColumn1 = ""
        Me.UcGridEdit1.InsertColumn2 = ""
        Me.UcGridEdit1.InsertValue = ""
        Me.UcGridEdit1.IsItiranCheckBoxFlag = False
        Me.UcGridEdit1.ItiranEditFlg = False
        Me.UcGridEdit1.Location = New System.Drawing.Point(12, 133)
        Me.UcGridEdit1.MasterFlg = False
        Me.UcGridEdit1.MinHeaderHeight = 24
        Me.UcGridEdit1.MinRowHeight = 20
        Me.UcGridEdit1.Name = "UcGridEdit1"
        Me.UcGridEdit1.RowAltAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.RowAppColor = System.Drawing.Color.White
        Me.UcGridEdit1.Size = New System.Drawing.Size(984, 547)
        Me.UcGridEdit1.TabIndex = 1
        Me.UcGridEdit1.Text = "UcGridEdit1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "F4:保存"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm外协品盘点一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UcGridEdit1)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.Name = "frm外协品盘点一览"
        Me.Text = "外协品盘点管理"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UcGridEdit1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGridEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcText5 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcText3 As UserControl.UCText
    Friend WithEvents UcText4 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents UltraDateTimeEditor2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UcText2 As UserControl.UCText
    Friend WithEvents UcGridEdit1 As UserControl.UCGridEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
