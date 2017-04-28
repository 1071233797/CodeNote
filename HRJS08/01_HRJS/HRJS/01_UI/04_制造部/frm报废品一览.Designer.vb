<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm报废品一览
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
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("选择")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品图号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品订单编号")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品产生工序")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("客户名称")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品数量")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废品生产者")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废日期")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("报废原因")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("处理结果")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("备注")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pic1")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pic2")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("pic3")
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
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt报废日期止 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt人员名称 = New UserControl.UCText(Me.components)
        Me.pic3 = New System.Windows.Forms.PictureBox
        Me.pic2 = New System.Windows.Forms.PictureBox
        Me.pic1 = New System.Windows.Forms.PictureBox
        Me.txt报废品生产者 = New UserControl.UCText(Me.components)
        Me.txt报废品图号 = New UserControl.UCText(Me.components)
        Me.txt报废品产生工序 = New UserControl.UCText(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt报废品订单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.txt报废日期起 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.UcButton1 = New UserControl.UCButton(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt报废日期止, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt报废品生产者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt报废品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt报废品产生工序, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt报废品订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt报废日期起, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.TabIndex = 4
        '
        'btnF2查询
        '
        Me.btnF2查询.TabIndex = 1
        Me.btnF2查询.Tag = "401901"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 2
        Me.btnF3选择.Tag = "401902"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 0
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废日期止)
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.txt人员名称)
        Me.UltraGroupBox1.Controls.Add(Me.pic3)
        Me.UltraGroupBox1.Controls.Add(Me.pic2)
        Me.UltraGroupBox1.Controls.Add(Me.pic1)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废品生产者)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废品图号)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废品产生工序)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel8)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废品订单编号)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txt报废日期起)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 218)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt报废日期止
        '
        Me.txt报废日期止.Location = New System.Drawing.Point(192, 112)
        Me.txt报废日期止.MaskInput = "yyyy/mm/dd"
        Me.txt报废日期止.Name = "txt报废日期止"
        Me.txt报废日期止.Size = New System.Drawing.Size(84, 21)
        Me.txt报废日期止.TabIndex = 344
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "~"
        '
        'txt人员名称
        '
        Me.txt人员名称.AutoSize = False
        Me.txt人员名称.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt人员名称.IsDigit = False
        Me.txt人员名称.Location = New System.Drawing.Point(176, 67)
        Me.txt人员名称.Name = "txt人员名称"
        Me.txt人员名称.ReadOnly = True
        Me.txt人员名称.Size = New System.Drawing.Size(100, 23)
        Me.txt人员名称.TabIndex = 342
        '
        'pic3
        '
        Me.pic3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic3.Location = New System.Drawing.Point(763, 18)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(215, 187)
        Me.pic3.TabIndex = 341
        Me.pic3.TabStop = False
        '
        'pic2
        '
        Me.pic2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic2.Location = New System.Drawing.Point(528, 18)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(215, 187)
        Me.pic2.TabIndex = 340
        Me.pic2.TabStop = False
        '
        'pic1
        '
        Me.pic1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic1.Location = New System.Drawing.Point(298, 18)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(215, 187)
        Me.pic1.TabIndex = 339
        Me.pic1.TabStop = False
        '
        'txt报废品生产者
        '
        Me.txt报废品生产者.AutoSize = False
        Me.txt报废品生产者.ButtonsRight.Add(EditorButton1)
        Me.txt报废品生产者.IsDigit = False
        Me.txt报废品生产者.Location = New System.Drawing.Point(106, 67)
        Me.txt报废品生产者.Name = "txt报废品生产者"
        Me.txt报废品生产者.Size = New System.Drawing.Size(70, 23)
        Me.txt报废品生产者.TabIndex = 2
        '
        'txt报废品图号
        '
        Me.txt报废品图号.AutoSize = False
        Me.txt报废品图号.ButtonsRight.Add(EditorButton2)
        Me.txt报废品图号.IsDigit = False
        Me.txt报废品图号.Location = New System.Drawing.Point(106, 21)
        Me.txt报废品图号.Name = "txt报废品图号"
        Me.txt报废品图号.Size = New System.Drawing.Size(170, 23)
        Me.txt报废品图号.TabIndex = 0
        '
        'txt报废品产生工序
        '
        Me.txt报废品产生工序.AutoSize = False
        Me.txt报废品产生工序.IsDigit = False
        Me.txt报废品产生工序.Location = New System.Drawing.Point(106, 90)
        Me.txt报废品产生工序.Name = "txt报废品产生工序"
        Me.txt报废品产生工序.Size = New System.Drawing.Size(170, 23)
        Me.txt报废品产生工序.TabIndex = 3
        '
        'UcLabel8
        '
        Appearance49.BackColor = System.Drawing.Color.SkyBlue
        Appearance49.BackColor2 = System.Drawing.Color.White
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance49.BorderColor = System.Drawing.Color.Black
        Appearance49.BorderColor2 = System.Drawing.Color.Black
        Appearance49.TextHAlignAsString = "Left"
        Appearance49.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance49
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(6, 90)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 6
        Me.UcLabel8.Text = "报废品产生工序"
        '
        'txt报废品订单编号
        '
        Me.txt报废品订单编号.AutoSize = False
        Me.txt报废品订单编号.ButtonsRight.Add(EditorButton3)
        Me.txt报废品订单编号.IsDigit = False
        Me.txt报废品订单编号.Location = New System.Drawing.Point(106, 44)
        Me.txt报废品订单编号.Name = "txt报废品订单编号"
        Me.txt报废品订单编号.Size = New System.Drawing.Size(170, 23)
        Me.txt报废品订单编号.TabIndex = 1
        '
        'UcLabel2
        '
        Appearance51.BackColor = System.Drawing.Color.SkyBlue
        Appearance51.BackColor2 = System.Drawing.Color.White
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance51.BorderColor = System.Drawing.Color.Black
        Appearance51.BorderColor2 = System.Drawing.Color.Black
        Appearance51.TextHAlignAsString = "Left"
        Appearance51.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance51
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Location = New System.Drawing.Point(6, 44)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 2
        Me.UcLabel2.Text = "报废品订单编号"
        '
        'UcLabel1
        '
        Appearance23.BackColor = System.Drawing.Color.SkyBlue
        Appearance23.BackColor2 = System.Drawing.Color.White
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance23.BorderColor = System.Drawing.Color.Black
        Appearance23.BorderColor2 = System.Drawing.Color.Black
        Appearance23.TextHAlignAsString = "Left"
        Appearance23.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance23
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 21)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 0
        Me.UcLabel1.Text = "报废品图号"
        '
        'UcLabel3
        '
        Appearance52.BackColor = System.Drawing.Color.SkyBlue
        Appearance52.BackColor2 = System.Drawing.Color.White
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance52.BorderColor = System.Drawing.Color.Black
        Appearance52.BorderColor2 = System.Drawing.Color.Black
        Appearance52.TextHAlignAsString = "Left"
        Appearance52.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance52
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(6, 67)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 4
        Me.UcLabel3.Text = "报废品生产者"
        '
        'txt报废日期起
        '
        Me.txt报废日期起.Location = New System.Drawing.Point(106, 113)
        Me.txt报废日期起.MaskInput = "yyyy/mm/dd"
        Me.txt报废日期起.Name = "txt报废日期起"
        Me.txt报废日期起.Size = New System.Drawing.Size(71, 21)
        Me.txt报废日期起.TabIndex = 4
        '
        'UcLabel12
        '
        Appearance22.BackColor = System.Drawing.Color.SkyBlue
        Appearance22.BackColor2 = System.Drawing.Color.White
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance22.BorderColor = System.Drawing.Color.Black
        Appearance22.BorderColor2 = System.Drawing.Color.Black
        Appearance22.TextHAlignAsString = "Left"
        Appearance22.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance22
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Location = New System.Drawing.Point(6, 113)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 8
        Me.UcLabel12.Text = "报废日期"
        '
        'UcButton1
        '
        Me.UcButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance65.BackColor = System.Drawing.SystemColors.Control
        Appearance65.BackColor2 = System.Drawing.SystemColors.Control
        Appearance65.TextHAlignAsString = "Center"
        Appearance65.TextVAlignAsString = "Middle"
        Me.UcButton1.Appearance = Appearance65
        Me.UcButton1.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.UcButton1.FSearchButtonName = ""
        Me.UcButton1.Location = New System.Drawing.Point(830, 12)
        Me.UcButton1.Name = "UcButton1"
        Me.UcButton1.Size = New System.Drawing.Size(80, 34)
        Me.UcButton1.TabIndex = 3
        Me.UcButton1.Tag = "401903"
        Me.UcButton1.Text = "F11:报废品记录打印"
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
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 48
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance15
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance16
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
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
        Me.grdList.Location = New System.Drawing.Point(14, 289)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(981, 391)
        Me.grdList.TabIndex = 7
        Me.grdList.Text = "UcGrid1"
        '
        'frm报废品一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.UcButton1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm报废品一览"
        Me.Text = "报废品一览"
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UcButton1, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt报废日期止, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt人员名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt报废品生产者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt报废品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt报废品产生工序, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt报废品订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt报废日期起, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt报废日期起 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt报废品订单编号 As UserControl.UCText
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt报废品产生工序 As UserControl.UCText
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents txt报废品图号 As UserControl.UCText
    Friend WithEvents UcButton1 As UserControl.UCButton
    Friend WithEvents grdList As UserControl.UCGrid
    Friend WithEvents txt报废品生产者 As UserControl.UCText
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt人员名称 As UserControl.UCText
    Friend WithEvents txt报废日期止 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
