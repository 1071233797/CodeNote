<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm客户管理
    Inherits InheritsBusinessForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。

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

    'Windows フォーム デザイナで必要です。

    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。

    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("负责人姓名")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("负责人职务")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("负责人部门")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("负责人电话")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("负责人邮箱")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("供应商编号CD")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim ScrollBarLook1 As Infragistics.Win.UltraWinScrollBar.ScrollBarLook = New Infragistics.Win.UltraWinScrollBar.ScrollBarLook
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Me.lbl客户编号 = New UserControl.UCLabel(Me.components)
        Me.txt客户编号 = New UserControl.UCText(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.lbl客户名称 = New UserControl.UCLabel(Me.components)
        Me.txt邮政编码 = New UserControl.UCText(Me.components)
        Me.lbl邮政编码 = New UserControl.UCLabel(Me.components)
        Me.txt公司地址 = New UserControl.UCText(Me.components)
        Me.lbl公司地址 = New UserControl.UCLabel(Me.components)
        Me.lbl传真号码 = New UserControl.UCLabel(Me.components)
        Me.txt传真号码 = New UserControl.UCText(Me.components)
        Me.lbl电话号码 = New UserControl.UCLabel(Me.components)
        Me.txt电话号码 = New UserControl.UCText(Me.components)
        Me.grid客户管理 = New UserControl.UCGridEdit(Me.components)
        Me.lbl交货方式 = New UserControl.UCLabel(Me.components)
        Me.cbo交货方式 = New UserControl.UCCombo(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt税率 = New UserControl.UCText(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt邮政编码, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt公司地址, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt传真号码, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt电话号码, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid客户管理, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbo交货方式, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税率, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 21
        '
        'btnF11
        '
        Me.btnF11.TabIndex = 20
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 13
        Me.btnF4删除.Tag = "100503"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 12
        Me.btnF3保存.Tag = "100502"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 11
        Me.btnF2编辑.Tag = "100501"
        '
        'labModel
        '
        Me.labModel.TabIndex = 15
        Me.labModel.Text = "新增"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 10
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 19
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 18
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 17
        '
        'btnF6行删除
        '
        Me.btnF6行删除.TabIndex = 15
        Me.btnF6行删除.Tag = "100505"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.TabIndex = 14
        Me.btnF5行追加.Tag = "100504"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 16
        '
        'lbl客户编号
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.lbl客户编号.Appearance = Appearance1
        Me.lbl客户编号.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl客户编号.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl客户编号.Location = New System.Drawing.Point(12, 56)
        Me.lbl客户编号.Name = "lbl客户编号"
        Me.lbl客户编号.Size = New System.Drawing.Size(100, 23)
        Me.lbl客户编号.TabIndex = 0
        Me.lbl客户编号.Text = "*客户编号"
        '
        'txt客户编号
        '
        Me.txt客户编号.AutoSize = False
        Me.txt客户编号.IsDigit = False
        Me.txt客户编号.Location = New System.Drawing.Point(112, 56)
        Me.txt客户编号.MaxLength = 50
        Me.txt客户编号.Name = "txt客户编号"
        Me.txt客户编号.Size = New System.Drawing.Size(106, 23)
        Me.txt客户编号.TabIndex = 1
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(112, 79)
        Me.txt客户名称.MaxLength = 50
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.Size = New System.Drawing.Size(183, 23)
        Me.txt客户名称.TabIndex = 2
        '
        'lbl客户名称
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.lbl客户名称.Appearance = Appearance2
        Me.lbl客户名称.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl客户名称.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl客户名称.Location = New System.Drawing.Point(12, 79)
        Me.lbl客户名称.Name = "lbl客户名称"
        Me.lbl客户名称.Size = New System.Drawing.Size(100, 23)
        Me.lbl客户名称.TabIndex = 2
        Me.lbl客户名称.Text = "*客户名称"
        '
        'txt邮政编码
        '
        Me.txt邮政编码.AutoSize = False
        Me.txt邮政编码.IsDigit = False
        Me.txt邮政编码.Location = New System.Drawing.Point(112, 102)
        Me.txt邮政编码.MaxLength = 50
        Me.txt邮政编码.Name = "txt邮政编码"
        Me.txt邮政编码.Size = New System.Drawing.Size(106, 23)
        Me.txt邮政编码.TabIndex = 3
        '
        'lbl邮政编码
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.lbl邮政编码.Appearance = Appearance3
        Me.lbl邮政编码.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl邮政编码.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl邮政编码.Location = New System.Drawing.Point(12, 102)
        Me.lbl邮政编码.Name = "lbl邮政编码"
        Me.lbl邮政编码.Size = New System.Drawing.Size(100, 23)
        Me.lbl邮政编码.TabIndex = 4
        Me.lbl邮政编码.Text = "邮政编码"
        '
        'txt公司地址
        '
        Me.txt公司地址.AutoSize = False
        Me.txt公司地址.IsDigit = False
        Me.txt公司地址.Location = New System.Drawing.Point(112, 125)
        Me.txt公司地址.MaxLength = 50
        Me.txt公司地址.Name = "txt公司地址"
        Me.txt公司地址.Size = New System.Drawing.Size(183, 23)
        Me.txt公司地址.TabIndex = 4
        '
        'lbl公司地址
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.lbl公司地址.Appearance = Appearance5
        Me.lbl公司地址.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl公司地址.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl公司地址.Location = New System.Drawing.Point(12, 125)
        Me.lbl公司地址.Name = "lbl公司地址"
        Me.lbl公司地址.Size = New System.Drawing.Size(100, 23)
        Me.lbl公司地址.TabIndex = 6
        Me.lbl公司地址.Text = "公司地址"
        '
        'lbl传真号码
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.lbl传真号码.Appearance = Appearance4
        Me.lbl传真号码.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl传真号码.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl传真号码.Location = New System.Drawing.Point(12, 171)
        Me.lbl传真号码.Name = "lbl传真号码"
        Me.lbl传真号码.Size = New System.Drawing.Size(100, 23)
        Me.lbl传真号码.TabIndex = 10
        Me.lbl传真号码.Text = "传真号码"
        '
        'txt传真号码
        '
        Me.txt传真号码.AutoSize = False
        Me.txt传真号码.IsDigit = False
        Me.txt传真号码.Location = New System.Drawing.Point(112, 171)
        Me.txt传真号码.MaxLength = 50
        Me.txt传真号码.Name = "txt传真号码"
        Me.txt传真号码.Size = New System.Drawing.Size(106, 23)
        Me.txt传真号码.TabIndex = 6
        '
        'lbl电话号码
        '
        Appearance7.BackColor = System.Drawing.Color.SkyBlue
        Appearance7.BackColor2 = System.Drawing.Color.White
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.BorderColor2 = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.TextVAlignAsString = "Middle"
        Me.lbl电话号码.Appearance = Appearance7
        Me.lbl电话号码.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl电话号码.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl电话号码.Location = New System.Drawing.Point(12, 148)
        Me.lbl电话号码.Name = "lbl电话号码"
        Me.lbl电话号码.Size = New System.Drawing.Size(100, 23)
        Me.lbl电话号码.TabIndex = 8
        Me.lbl电话号码.Text = "电话号码"
        '
        'txt电话号码
        '
        Me.txt电话号码.AutoSize = False
        Me.txt电话号码.IsDigit = False
        Me.txt电话号码.Location = New System.Drawing.Point(112, 148)
        Me.txt电话号码.MaxLength = 50
        Me.txt电话号码.Name = "txt电话号码"
        Me.txt电话号码.Size = New System.Drawing.Size(106, 23)
        Me.txt电话号码.TabIndex = 5
        '
        'grid客户管理
        '
        Me.grid客户管理.ActiveFormFeatureCode = ""
        Me.grid客户管理.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        Me.grid客户管理.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid客户管理.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid客户管理.BackColorFlg = True
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grid客户管理.DisplayLayout.Appearance = Appearance9
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance10.ForeColor = System.Drawing.Color.Black
        UltraGridColumn1.CellAppearance = Appearance10
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.MaxLength = 50
        UltraGridColumn1.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance42.ForeColor = System.Drawing.Color.Black
        UltraGridColumn2.CellAppearance = Appearance42
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.MaxLength = 50
        UltraGridColumn2.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn2.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance43.ForeColor = System.Drawing.Color.Black
        UltraGridColumn3.CellAppearance = Appearance43
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.MaxLength = 50
        UltraGridColumn3.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn3.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn3.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance44.ForeColor = System.Drawing.Color.Black
        UltraGridColumn4.CellAppearance = Appearance44
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MaxLength = 50
        UltraGridColumn4.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn4.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance45.ForeColor = System.Drawing.Color.Black
        UltraGridColumn5.CellAppearance = Appearance45
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.MaxLength = 50
        UltraGridColumn5.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn5.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn5.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        Appearance58.ForeColor = System.Drawing.Color.Black
        UltraGridColumn6.CellAppearance = Appearance58
        UltraGridColumn6.Header.Caption = "客户编号CD"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.RowLayoutColumnInfo.AllowCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.Horizontal
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(0, 20)
        UltraGridColumn6.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 24)
        UltraGridColumn6.TabStop = False
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.grid客户管理.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid客户管理.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid客户管理.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance46.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance46.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance46.BorderColor = System.Drawing.SystemColors.Window
        Me.grid客户管理.DisplayLayout.GroupByBox.Appearance = Appearance46
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid客户管理.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance47
        Me.grid客户管理.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid客户管理.DisplayLayout.GroupByBox.Hidden = True
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance48.BackColor2 = System.Drawing.SystemColors.Control
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance48.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid客户管理.DisplayLayout.GroupByBox.PromptAppearance = Appearance48
        Me.grid客户管理.DisplayLayout.MaxColScrollRegions = 1
        Me.grid客户管理.DisplayLayout.MaxRowScrollRegions = 1
        Appearance49.BackColor = System.Drawing.Color.White
        Me.grid客户管理.DisplayLayout.Override.AddRowAppearance = Appearance49
        Me.grid客户管理.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom
        Me.grid客户管理.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grid客户管理.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid客户管理.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid客户管理.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.None
        Me.grid客户管理.DisplayLayout.Override.BorderStyleHeader = Infragistics.Win.UIElementBorderStyle.Raised
        Appearance50.BackColor = System.Drawing.SystemColors.Window
        Me.grid客户管理.DisplayLayout.Override.CardAreaAppearance = Appearance50
        Appearance51.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Appearance51.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Appearance51.TextVAlignAsString = "Middle"
        Me.grid客户管理.DisplayLayout.Override.CellAppearance = Appearance51
        Me.grid客户管理.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid客户管理.DisplayLayout.Override.CellPadding = 0
        Appearance52.BackColor = System.Drawing.SystemColors.Control
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.grid客户管理.DisplayLayout.Override.GroupByRowAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Center"
        Appearance53.TextVAlignAsString = "Middle"
        Me.grid客户管理.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.grid客户管理.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grid客户管理.DisplayLayout.Override.MinRowHeight = 20
        Appearance54.BackColor = System.Drawing.Color.White
        Me.grid客户管理.DisplayLayout.Override.RowAlternateAppearance = Appearance54
        Appearance55.BackColor = System.Drawing.Color.White
        Appearance55.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grid客户管理.DisplayLayout.Override.RowAppearance = Appearance55
        Appearance56.TextHAlignAsString = "Center"
        Me.grid客户管理.DisplayLayout.Override.RowSelectorAppearance = Appearance56
        Me.grid客户管理.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grid客户管理.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid客户管理.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid客户管理.DisplayLayout.Override.RowSelectorWidth = 40
        Me.grid客户管理.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Fixed
        Appearance57.BackColor = System.Drawing.Color.White
        Me.grid客户管理.DisplayLayout.Override.TemplateAddRowAppearance = Appearance57
        ScrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd
        Me.grid客户管理.DisplayLayout.ScrollBarLook = ScrollBarLook1
        Me.grid客户管理.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid客户管理.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid客户管理.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell
        Me.grid客户管理.FirstFocusColumnIndex = -1
        Me.grid客户管理.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grid客户管理.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.grid客户管理.InsertColumn = ""
        Me.grid客户管理.InsertColumn1 = ""
        Me.grid客户管理.InsertColumn2 = ""
        Me.grid客户管理.InsertValue = ""
        Me.grid客户管理.IsItiranCheckBoxFlag = False
        Me.grid客户管理.ItiranEditFlg = False
        Me.grid客户管理.Location = New System.Drawing.Point(12, 246)
        Me.grid客户管理.MasterFlg = False
        Me.grid客户管理.MinHeaderHeight = 24
        Me.grid客户管理.MinRowHeight = 20
        Me.grid客户管理.Name = "grid客户管理"
        Me.grid客户管理.RowAltAppColor = System.Drawing.Color.White
        Me.grid客户管理.RowAppColor = System.Drawing.Color.White
        Me.grid客户管理.Size = New System.Drawing.Size(984, 434)
        Me.grid客户管理.TabIndex = 9
        Me.grid客户管理.Text = "UcGridEdit1"
        '
        'lbl交货方式
        '
        Appearance8.BackColor = System.Drawing.Color.SkyBlue
        Appearance8.BackColor2 = System.Drawing.Color.White
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance8.BorderColor = System.Drawing.Color.Black
        Appearance8.BorderColor2 = System.Drawing.Color.Black
        Appearance8.TextHAlignAsString = "Left"
        Appearance8.TextVAlignAsString = "Middle"
        Me.lbl交货方式.Appearance = Appearance8
        Me.lbl交货方式.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl交货方式.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.lbl交货方式.Location = New System.Drawing.Point(12, 194)
        Me.lbl交货方式.Name = "lbl交货方式"
        Me.lbl交货方式.Size = New System.Drawing.Size(100, 23)
        Me.lbl交货方式.TabIndex = 12
        Me.lbl交货方式.Text = "交货方式"
        '
        'cbo交货方式
        '
        Me.cbo交货方式.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbo交货方式.DisplayLayout.Appearance = Appearance14
        Me.cbo交货方式.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbo交货方式.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.cbo交货方式.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo交货方式.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.cbo交货方式.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo交货方式.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.cbo交货方式.DisplayLayout.MaxColScrollRegions = 1
        Me.cbo交货方式.DisplayLayout.MaxRowScrollRegions = 1
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbo交货方式.DisplayLayout.Override.ActiveCellAppearance = Appearance31
        Appearance32.BackColor = System.Drawing.SystemColors.Highlight
        Appearance32.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbo交货方式.DisplayLayout.Override.ActiveRowAppearance = Appearance32
        Me.cbo交货方式.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cbo交货方式.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Me.cbo交货方式.DisplayLayout.Override.CardAreaAppearance = Appearance41
        Appearance34.BorderColor = System.Drawing.Color.Silver
        Appearance34.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbo交货方式.DisplayLayout.Override.CellAppearance = Appearance34
        Me.cbo交货方式.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbo交货方式.DisplayLayout.Override.CellPadding = 0
        Appearance35.BackColor = System.Drawing.SystemColors.Control
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.cbo交货方式.DisplayLayout.Override.GroupByRowAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Left"
        Me.cbo交货方式.DisplayLayout.Override.HeaderAppearance = Appearance36
        Me.cbo交货方式.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cbo交货方式.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.cbo交货方式.DisplayLayout.Override.RowAppearance = Appearance37
        Me.cbo交货方式.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbo交货方式.DisplayLayout.Override.TemplateAddRowAppearance = Appearance38
        Me.cbo交货方式.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbo交货方式.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbo交货方式.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbo交货方式.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cbo交货方式.Location = New System.Drawing.Point(112, 194)
        Me.cbo交货方式.Name = "cbo交货方式"
        Me.cbo交货方式.Size = New System.Drawing.Size(106, 22)
        Me.cbo交货方式.TabIndex = 7
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
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(12, 217)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 28
        Me.UcLabel1.Text = "税率"
        '
        'txt税率
        '
        Me.txt税率.AutoSize = False
        Me.txt税率.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt税率.IsDigit = False
        Me.txt税率.Location = New System.Drawing.Point(112, 217)
        Me.txt税率.MaxLength = 50
        Me.txt税率.Name = "txt税率"
        Me.txt税率.Size = New System.Drawing.Size(106, 23)
        Me.txt税率.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "%"
        '
        'frm客户管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt税率)
        Me.Controls.Add(Me.UcLabel1)
        Me.Controls.Add(Me.lbl交货方式)
        Me.Controls.Add(Me.cbo交货方式)
        Me.Controls.Add(Me.grid客户管理)
        Me.Controls.Add(Me.lbl传真号码)
        Me.Controls.Add(Me.txt传真号码)
        Me.Controls.Add(Me.lbl电话号码)
        Me.Controls.Add(Me.txt电话号码)
        Me.Controls.Add(Me.lbl公司地址)
        Me.Controls.Add(Me.txt公司地址)
        Me.Controls.Add(Me.lbl邮政编码)
        Me.Controls.Add(Me.txt邮政编码)
        Me.Controls.Add(Me.lbl客户名称)
        Me.Controls.Add(Me.txt客户名称)
        Me.Controls.Add(Me.lbl客户编号)
        Me.Controls.Add(Me.txt客户编号)
        Me.KeyPreview = True
        Me.Name = "frm客户管理"
        Me.Text = "客户管理"
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.txt客户编号, 0)
        Me.Controls.SetChildIndex(Me.lbl客户编号, 0)
        Me.Controls.SetChildIndex(Me.txt客户名称, 0)
        Me.Controls.SetChildIndex(Me.lbl客户名称, 0)
        Me.Controls.SetChildIndex(Me.txt邮政编码, 0)
        Me.Controls.SetChildIndex(Me.lbl邮政编码, 0)
        Me.Controls.SetChildIndex(Me.txt公司地址, 0)
        Me.Controls.SetChildIndex(Me.lbl公司地址, 0)
        Me.Controls.SetChildIndex(Me.txt电话号码, 0)
        Me.Controls.SetChildIndex(Me.lbl电话号码, 0)
        Me.Controls.SetChildIndex(Me.txt传真号码, 0)
        Me.Controls.SetChildIndex(Me.lbl传真号码, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.grid客户管理, 0)
        Me.Controls.SetChildIndex(Me.cbo交货方式, 0)
        Me.Controls.SetChildIndex(Me.lbl交货方式, 0)
        Me.Controls.SetChildIndex(Me.UcLabel1, 0)
        Me.Controls.SetChildIndex(Me.txt税率, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt邮政编码, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt公司地址, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt传真号码, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt电话号码, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid客户管理, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbo交货方式, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税率, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl客户编号 As UserControl.UCLabel
    Friend WithEvents txt客户编号 As UserControl.UCText
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents lbl客户名称 As UserControl.UCLabel
    Friend WithEvents txt邮政编码 As UserControl.UCText
    Friend WithEvents lbl邮政编码 As UserControl.UCLabel
    Friend WithEvents txt公司地址 As UserControl.UCText
    Friend WithEvents lbl公司地址 As UserControl.UCLabel
    Friend WithEvents lbl传真号码 As UserControl.UCLabel
    Friend WithEvents txt传真号码 As UserControl.UCText
    Friend WithEvents lbl电话号码 As UserControl.UCLabel
    Friend WithEvents txt电话号码 As UserControl.UCText
    Friend WithEvents grid客户管理 As UserControl.UCGridEdit
    Friend WithEvents lbl交货方式 As UserControl.UCLabel
    Friend WithEvents cbo交货方式 As UserControl.UCCombo
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt税率 As UserControl.UCText
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
