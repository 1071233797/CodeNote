<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm审核
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
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt审核备注 = New UserControl.UCText(Me.components)
        Me.cmb审核状态 = New UserControl.UCCombo(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.btnF11确定 = New UserControl.UCButton(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt审核备注, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb审核状态, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.Location = New System.Drawing.Point(438, 154)
        Me.btnF12关闭.TabIndex = 5
        Me.btnF12关闭.Text = "F12：关闭"
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 2
        Me.btnF2查询.TabStop = False
        Me.btnF2查询.Visible = False
        '
        'btnF3选择
        '
        Me.btnF3选择.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF3选择.Location = New System.Drawing.Point(276, 154)
        Me.btnF3选择.TabIndex = 3
        Me.btnF3选择.TabStop = False
        Me.btnF3选择.Tag = ""
        Me.btnF3选择.Visible = False
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 1
        Me.btnF1清空.TabStop = False
        Me.btnF1清空.Visible = False
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt审核备注)
        Me.UltraGroupBox1.Controls.Add(Me.cmb审核状态)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(506, 136)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt审核备注
        '
        Me.txt审核备注.IsDigit = False
        Me.txt审核备注.Location = New System.Drawing.Point(114, 55)
        Me.txt审核备注.Name = "txt审核备注"
        Me.txt审核备注.Size = New System.Drawing.Size(343, 21)
        Me.txt审核备注.TabIndex = 5
        '
        'cmb审核状态
        '
        Me.cmb审核状态.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cmb审核状态.DisplayLayout.Appearance = Appearance5
        Me.cmb审核状态.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmb审核状态.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb审核状态.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb审核状态.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.cmb审核状态.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cmb审核状态.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.cmb审核状态.DisplayLayout.MaxColScrollRegions = 1
        Me.cmb审核状态.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmb审核状态.DisplayLayout.Override.ActiveCellAppearance = Appearance13
        Appearance8.BackColor = System.Drawing.SystemColors.Highlight
        Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmb审核状态.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.cmb审核状态.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmb审核状态.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.cmb审核状态.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Appearance6.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cmb审核状态.DisplayLayout.Override.CellAppearance = Appearance6
        Me.cmb审核状态.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmb审核状态.DisplayLayout.Override.CellPadding = 0
        Appearance10.BackColor = System.Drawing.SystemColors.Control
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.cmb审核状态.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance12.TextHAlignAsString = "Left"
        Me.cmb审核状态.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.cmb审核状态.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmb审核状态.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.cmb审核状态.DisplayLayout.Override.RowAppearance = Appearance11
        Me.cmb审核状态.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmb审核状态.DisplayLayout.Override.TemplateAddRowAppearance = Appearance9
        Me.cmb审核状态.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmb审核状态.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmb审核状态.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmb审核状态.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cmb审核状态.Location = New System.Drawing.Point(114, 33)
        Me.cmb审核状态.Name = "cmb审核状态"
        Me.cmb审核状态.Size = New System.Drawing.Size(110, 22)
        Me.cmb审核状态.TabIndex = 4
        '
        'UcLabel1
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance15
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(15, 33)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.Text = "审核状态"
        '
        'UcLabel12
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance1
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(15, 56)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 2
        Me.UcLabel12.Text = "备注"
        '
        'btnF11确定
        '
        Me.btnF11确定.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.BackColor = System.Drawing.SystemColors.Control
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.TextHAlignAsString = "Center"
        Appearance20.TextVAlignAsString = "Middle"
        Me.btnF11确定.Appearance = Appearance20
        Me.btnF11确定.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11确定.FSearchButtonName = ""
        Me.btnF11确定.Location = New System.Drawing.Point(357, 154)
        Me.btnF11确定.Name = "btnF11确定"
        Me.btnF11确定.Size = New System.Drawing.Size(80, 34)
        Me.btnF11确定.TabIndex = 4
        Me.btnF11确定.Tag = "102301"
        Me.btnF11确定.Text = "F11:确定"
        '
        'frm审核
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 196)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnF11确定)
        Me.KeyPreview = True
        Me.Name = "frm审核"
        Me.Text = "审核"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF11确定, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt审核备注, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb审核状态, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnF11确定 As UserControl.UCButton
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents cmb审核状态 As UserControl.UCCombo
    Friend WithEvents txt审核备注 As UserControl.UCText
End Class
