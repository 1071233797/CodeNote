﻿
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm供应商一览
    Inherits InheritsSearchForm

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
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("バンド 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("供应商编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("供应商名称")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("公司地址")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("邮政编码")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("电话号码")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("传真号码")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("供货方式")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("税率")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt供应商名称 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.txt供应商编号 = New UserControl.UCText(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.txt供应商名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt供应商编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.Text = "F12：关闭"
        '
        'btnF2查询
        '
        Me.btnF2查询.Tag = "100801"
        '
        'btnF3选择
        '
        Me.btnF3选择.Tag = "100802"
        '
        'btnF1清空
        '
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.txt供应商名称)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel4)
        Me.UcGroupBox1.Controls.Add(Me.txt供应商编号)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 75)
        Me.UcGroupBox1.TabIndex = 56
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt供应商名称
        '
        Me.txt供应商名称.AutoSize = False
        Me.txt供应商名称.IsDigit = False
        Me.txt供应商名称.Location = New System.Drawing.Point(106, 44)
        Me.txt供应商名称.MaxLength = 50
        Me.txt供应商名称.Name = "txt供应商名称"
        Me.txt供应商名称.Size = New System.Drawing.Size(134, 23)
        Me.txt供应商名称.TabIndex = 9
        '
        'UcLabel2
        '
        Appearance62.BackColor = System.Drawing.Color.SkyBlue
        Appearance62.BackColor2 = System.Drawing.Color.White
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance62.BorderColor = System.Drawing.Color.Black
        Appearance62.BorderColor2 = System.Drawing.Color.Black
        Appearance62.TextHAlignAsString = "Left"
        Appearance62.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance62
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 8
        Me.UcLabel2.Text = "供应商名称"
        '
        'UcLabel4
        '
        Appearance35.BackColor = System.Drawing.Color.SkyBlue
        Appearance35.BackColor2 = System.Drawing.Color.White
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance35.BorderColor = System.Drawing.Color.Black
        Appearance35.BorderColor2 = System.Drawing.Color.Black
        Appearance35.TextHAlignAsString = "Left"
        Appearance35.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance35
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UcLabel4.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 6
        Me.UcLabel4.Text = "供应商编号"
        '
        'txt供应商编号
        '
        Me.txt供应商编号.AutoSize = False
        Me.txt供应商编号.IsDigit = False
        Me.txt供应商编号.Location = New System.Drawing.Point(106, 21)
        Me.txt供应商编号.MaxLength = 50
        Me.txt供应商编号.Name = "txt供应商编号"
        Me.txt供应商编号.Size = New System.Drawing.Size(134, 23)
        Me.txt供应商编号.TabIndex = 7
        '
        'grdList
        '
        Me.grdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.Color.LightGray
        Appearance1.BorderColor = System.Drawing.Color.Silver
        Appearance1.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 94
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 166
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 188
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 87
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 89
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 72
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance5.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 20
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance11
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Center"
        Appearance13.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance13
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSelectorStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 133)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(984, 534)
        Me.grdList.TabIndex = 57
        Me.grdList.Text = "UcGrid1"
        '
        'frm供应商一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm供应商一览"
        Me.Text = "供应商一览"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        CType(Me.txt供应商名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt供应商编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt供应商名称 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents txt供应商编号 As UserControl.UCText
    Friend WithEvents grdList As UserControl.UCGrid
End Class

