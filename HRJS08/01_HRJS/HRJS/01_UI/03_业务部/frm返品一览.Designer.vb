<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm返品一览
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("客户名称")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("生产日期")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("返品数量")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("返品原因")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("库存区域")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("客户名称")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("产品图号")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("生产日期")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("返品数量")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("返品原因")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton5 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("订单编号")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品图号")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("产品名称")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("客户名称")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("生产日期")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("返品数量")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance = New Infragistics.Win.ConditionValueAppearance(New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Contains, "-", True, GetType(String)), Infragistics.Win.ICondition)}, New Infragistics.Win.Appearance() {Appearance1})
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("库存状态")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt客户名 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt客户编号 = New UserControl.UCText(Me.components)
        Me.txt产品名 = New UserControl.UCText(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.UltraDateTimeEditor2 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UltraDateTimeEditor1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UcGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.txt订单编号 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.txt产品名称 = New UserControl.UCText(Me.components)
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.UcText4 = New UserControl.UCText(Me.components)
        Me.UcText2 = New UserControl.UCText(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.date结束日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.date开始日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.grdList = New UserControl.UCGrid(Me.components)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt客户名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UcGroupBox1.SuspendLayout()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt产品名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date结束日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.date开始日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnF2查询.Tag = "501001"
        '
        'btnF3选择
        '
        Me.btnF3选择.TabIndex = 4
        Me.btnF3选择.Tag = "501002"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 2
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraGroupBox1.Controls.Add(Me.txt客户名)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txt客户编号)
        Me.UltraGroupBox1.Controls.Add(Me.txt产品名)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.txt产品图号)
        Me.UltraGroupBox1.Controls.Add(Me.Label2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraDateTimeEditor2)
        Me.UltraGroupBox1.Controls.Add(Me.UltraDateTimeEditor1)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel3)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(984, 76)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "查询条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt客户名
        '
        Me.txt客户名.AutoSize = False
        Me.txt客户名.IsDigit = False
        Me.txt客户名.Location = New System.Drawing.Point(206, 42)
        Me.txt客户名.Name = "txt客户名"
        Me.txt客户名.ReadOnly = True
        Me.txt客户名.Size = New System.Drawing.Size(143, 23)
        Me.txt客户名.TabIndex = 3
        '
        'UcLabel1
        '
        Appearance4.BackColor = System.Drawing.Color.SkyBlue
        Appearance4.BackColor2 = System.Drawing.Color.White
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance4.BorderColor = System.Drawing.Color.Black
        Appearance4.BorderColor2 = System.Drawing.Color.Black
        Appearance4.TextHAlignAsString = "Left"
        Appearance4.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance4
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Location = New System.Drawing.Point(6, 42)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 5
        Me.UcLabel1.Text = "客户名称"
        '
        'txt客户编号
        '
        Me.txt客户编号.AutoSize = False
        Me.txt客户编号.ButtonsRight.Add(EditorButton1)
        Me.txt客户编号.IsDigit = False
        Me.txt客户编号.Location = New System.Drawing.Point(106, 42)
        Me.txt客户编号.Name = "txt客户编号"
        Me.txt客户编号.Size = New System.Drawing.Size(100, 23)
        Me.txt客户编号.TabIndex = 2
        '
        'txt产品名
        '
        Me.txt产品名.AutoSize = False
        Me.txt产品名.IsDigit = False
        Me.txt产品名.Location = New System.Drawing.Point(206, 19)
        Me.txt产品名.Name = "txt产品名"
        Me.txt产品名.ReadOnly = True
        Me.txt产品名.Size = New System.Drawing.Size(143, 23)
        Me.txt产品名.TabIndex = 1
        '
        'UcLabel6
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance5
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Location = New System.Drawing.Point(6, 19)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 4
        Me.UcLabel6.Text = "产品图号"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.ButtonsRight.Add(EditorButton2)
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(106, 19)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(100, 23)
        Me.txt产品图号.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "~"
        '
        'UltraDateTimeEditor2
        '
        Me.UltraDateTimeEditor2.Location = New System.Drawing.Point(599, 43)
        Me.UltraDateTimeEditor2.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor2.Name = "UltraDateTimeEditor2"
        Me.UltraDateTimeEditor2.Size = New System.Drawing.Size(118, 21)
        Me.UltraDateTimeEditor2.TabIndex = 5
        '
        'UltraDateTimeEditor1
        '
        Me.UltraDateTimeEditor1.Location = New System.Drawing.Point(480, 43)
        Me.UltraDateTimeEditor1.MaskInput = "yyyy/mm/dd"
        Me.UltraDateTimeEditor1.Name = "UltraDateTimeEditor1"
        Me.UltraDateTimeEditor1.Size = New System.Drawing.Size(94, 21)
        Me.UltraDateTimeEditor1.TabIndex = 4
        '
        'UcLabel3
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance6
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Location = New System.Drawing.Point(380, 42)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 127
        Me.UcLabel3.Text = "生产日期"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'UcGroupBox1
        '
        Me.UcGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel8)
        Me.UcGroupBox1.Controls.Add(Me.txt客户名称)
        Me.UcGroupBox1.Controls.Add(Me.txt订单编号)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel4)
        Me.UcGroupBox1.Controls.Add(Me.txt产品名称)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel5)
        Me.UcGroupBox1.Controls.Add(Me.UcText4)
        Me.UcGroupBox1.Controls.Add(Me.UcText2)
        Me.UcGroupBox1.Controls.Add(Me.Label1)
        Me.UcGroupBox1.Controls.Add(Me.date结束日期)
        Me.UcGroupBox1.Controls.Add(Me.date开始日期)
        Me.UcGroupBox1.Controls.Add(Me.UcLabel7)
        Me.UcGroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.UcGroupBox1.Name = "UcGroupBox1"
        Me.UcGroupBox1.Size = New System.Drawing.Size(984, 76)
        Me.UcGroupBox1.TabIndex = 0
        Me.UcGroupBox1.Text = "查询条件"
        Me.UcGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'UcLabel8
        '
        Appearance27.BackColor = System.Drawing.Color.SkyBlue
        Appearance27.BackColor2 = System.Drawing.Color.White
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance27.BorderColor = System.Drawing.Color.Black
        Appearance27.BorderColor2 = System.Drawing.Color.Black
        Appearance27.TextHAlignAsString = "Left"
        Appearance27.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance27
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Location = New System.Drawing.Point(380, 19)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 146
        Me.UcLabel8.Text = "订单编号"
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(206, 42)
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.ReadOnly = True
        Me.txt客户名称.Size = New System.Drawing.Size(143, 23)
        Me.txt客户名称.TabIndex = 3
        '
        'txt订单编号
        '
        Me.txt订单编号.AutoSize = False
        Me.txt订单编号.ButtonsRight.Add(EditorButton3)
        Me.txt订单编号.IsDigit = False
        Me.txt订单编号.Location = New System.Drawing.Point(480, 19)
        Me.txt订单编号.Name = "txt订单编号"
        Me.txt订单编号.Size = New System.Drawing.Size(200, 23)
        Me.txt订单编号.TabIndex = 145
        '
        'UcLabel4
        '
        Appearance127.BackColor = System.Drawing.Color.SkyBlue
        Appearance127.BackColor2 = System.Drawing.Color.White
        Appearance127.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance127.BorderColor = System.Drawing.Color.Black
        Appearance127.BorderColor2 = System.Drawing.Color.Black
        Appearance127.TextHAlignAsString = "Left"
        Appearance127.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance127
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Location = New System.Drawing.Point(6, 42)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 5
        Me.UcLabel4.Text = "客户名称"
        '
        'txt产品名称
        '
        Me.txt产品名称.AutoSize = False
        Me.txt产品名称.IsDigit = False
        Me.txt产品名称.Location = New System.Drawing.Point(206, 19)
        Me.txt产品名称.Name = "txt产品名称"
        Me.txt产品名称.ReadOnly = True
        Me.txt产品名称.Size = New System.Drawing.Size(143, 23)
        Me.txt产品名称.TabIndex = 1
        '
        'UcLabel5
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance2
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Location = New System.Drawing.Point(6, 19)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 4
        Me.UcLabel5.Text = "产品图号"
        '
        'UcText4
        '
        Me.UcText4.AutoSize = False
        Me.UcText4.ButtonsRight.Add(EditorButton4)
        Me.UcText4.IsDigit = False
        Me.UcText4.Location = New System.Drawing.Point(106, 19)
        Me.UcText4.Name = "UcText4"
        Me.UcText4.Size = New System.Drawing.Size(100, 23)
        Me.UcText4.TabIndex = 0
        '
        'UcText2
        '
        Me.UcText2.AutoSize = False
        Me.UcText2.ButtonsRight.Add(EditorButton5)
        Me.UcText2.IsDigit = False
        Me.UcText2.Location = New System.Drawing.Point(106, 42)
        Me.UcText2.Name = "UcText2"
        Me.UcText2.Size = New System.Drawing.Size(100, 23)
        Me.UcText2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(582, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "~"
        '
        'date结束日期
        '
        Me.date结束日期.Location = New System.Drawing.Point(599, 42)
        Me.date结束日期.MaskInput = "yyyy/mm/dd"
        Me.date结束日期.Name = "date结束日期"
        Me.date结束日期.Size = New System.Drawing.Size(81, 21)
        Me.date结束日期.TabIndex = 5
        '
        'date开始日期
        '
        Me.date开始日期.Location = New System.Drawing.Point(480, 42)
        Me.date开始日期.MaskInput = "yyyy/mm/dd"
        Me.date开始日期.Name = "date开始日期"
        Me.date开始日期.Size = New System.Drawing.Size(94, 21)
        Me.date开始日期.TabIndex = 4
        '
        'UcLabel7
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance15
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Location = New System.Drawing.Point(380, 42)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 127
        Me.UcLabel7.Text = "生产日期"
        '
        'grdList
        '
        Appearance25.BackColor = System.Drawing.Color.LightGray
        Appearance25.BorderColor = System.Drawing.Color.Silver
        Appearance25.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Appearance = Appearance25
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance26
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance28
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.ImeMode = System.Windows.Forms.ImeMode.Disable
        UltraGridColumn6.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance1.ForeColor = System.Drawing.Color.Red
        UltraGridColumn6.ValueBasedAppearance = ConditionValueAppearance1
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.grdList.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grdList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance30.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.GroupByBox.Appearance = Appearance30
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance31
        Me.grdList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance32.BackColor2 = System.Drawing.SystemColors.Control
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance32.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdList.DisplayLayout.GroupByBox.PromptAppearance = Appearance32
        Me.grdList.DisplayLayout.MaxColScrollRegions = 1
        Me.grdList.DisplayLayout.MaxRowScrollRegions = 1
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveCellAppearance = Appearance33
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.grdList.DisplayLayout.Override.ActiveRowAppearance = Appearance34
        Me.grdList.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdList.DisplayLayout.Override.AllowRowLayoutCellSizing = Infragistics.Win.UltraWinGrid.RowLayoutSizing.None
        Me.grdList.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdList.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.CardAreaAppearance = Appearance35
        Appearance36.BorderColor = System.Drawing.Color.Silver
        Appearance36.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdList.DisplayLayout.Override.CellAppearance = Appearance36
        Me.grdList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grdList.DisplayLayout.Override.CellPadding = 0
        Me.grdList.DisplayLayout.Override.DefaultRowHeight = 20
        Appearance37.BackColor = System.Drawing.SystemColors.Control
        Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance37.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.grdList.DisplayLayout.Override.GroupByRowAppearance = Appearance37
        Appearance38.TextHAlignAsString = "Left"
        Me.grdList.DisplayLayout.Override.HeaderAppearance = Appearance38
        Me.grdList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.DisplayLayout.Override.RowAlternateAppearance = Appearance39
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.grdList.DisplayLayout.Override.RowAppearance = Appearance40
        Appearance52.TextHAlignAsString = "Center"
        Appearance52.TextVAlignAsString = "Middle"
        Me.grdList.DisplayLayout.Override.RowSelectorAppearance = Appearance52
        Me.grdList.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.grdList.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grdList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdList.DisplayLayout.Override.RowSizingArea = Infragistics.Win.UltraWinGrid.RowSizingArea.RowSelectorsOnly
        Me.grdList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.grdList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.grdList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.grdList.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance59.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdList.DisplayLayout.Override.TemplateAddRowAppearance = Appearance59
        Me.grdList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.grdList.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.grdList.Location = New System.Drawing.Point(12, 141)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(984, 539)
        Me.grdList.TabIndex = 6
        Me.grdList.Text = "UcGrid1"
        '
        'frm返品一览
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.UcGroupBox1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.KeyPreview = True
        Me.Name = "frm返品一览"
        Me.Text = "返品查询"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.UcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grdList, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.txt客户名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDateTimeEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UcGroupBox1.ResumeLayout(False)
        Me.UcGroupBox1.PerformLayout()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt订单编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt产品名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UcText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date结束日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.date开始日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt客户编号 As UserControl.UCText
    Friend WithEvents txt产品名 As UserControl.UCText
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents txt客户名 As UserControl.UCText
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UltraDateTimeEditor2 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraDateTimeEditor1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents txt订单编号 As UserControl.UCText
    Friend WithEvents UcText2 As UserControl.UCText
    Friend WithEvents txt产品名称 As UserControl.UCText
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents UcText4 As UserControl.UCText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents date结束日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents date开始日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents grdList As UserControl.UCGrid
End Class

