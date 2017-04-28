<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm图纸信息管理
    Inherits InheritsBusinessForm

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("三级图号")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("二级图号", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("二级图号")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("一级图号", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材料种类")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("材质/型号")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("单件重量")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("长")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("宽（直径）")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("高（厚度）")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("数量（每套）")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("要求")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("备注")
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btn图纸导入 = New UserControl.UCButton(Me.components)
        Me.txt产品图号 = New UserControl.UCText(Me.components)
        Me.UcLabel6 = New UserControl.UCLabel(Me.components)
        Me.UcLabel17 = New UserControl.UCLabel(Me.components)
        Me.pic图纸 = New System.Windows.Forms.PictureBox
        Me.UcLabel5 = New UserControl.UCLabel(Me.components)
        Me.txt品名 = New UserControl.UCText(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.txt图纸版本编号 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt客户名称 = New UserControl.UCText(Me.components)
        Me.txt客户编号 = New UserControl.UCText(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt主图号 = New UserControl.UCText(Me.components)
        Me.UcLabel3 = New UserControl.UCLabel(Me.components)
        Me.UcLabel2 = New UserControl.UCLabel(Me.components)
        Me.txt数量 = New UserControl.UCText(Me.components)
        Me.UcLabel4 = New UserControl.UCLabel(Me.components)
        Me.txt分图号 = New UserControl.UCText(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UcLabel8 = New UserControl.UCLabel(Me.components)
        Me.txt主图号品名 = New UserControl.UCText(Me.components)
        Me.UcLabel10 = New UserControl.UCLabel(Me.components)
        Me.txt长 = New UserControl.UCText(Me.components)
        Me.UcLabel11 = New UserControl.UCLabel(Me.components)
        Me.txt宽 = New UserControl.UCText(Me.components)
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.txt高 = New UserControl.UCText(Me.components)
        Me.UcLabel13 = New UserControl.UCLabel(Me.components)
        Me.txt单件重量 = New UserControl.UCText(Me.components)
        Me.UcLabel14 = New UserControl.UCLabel(Me.components)
        Me.txt要求 = New UserControl.UCText(Me.components)
        Me.UcLabel15 = New UserControl.UCLabel(Me.components)
        Me.txt备注 = New UserControl.UCText(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl更新日期 = New UserControl.UCLabel(Me.components)
        Me.UcLabel18 = New UserControl.UCLabel(Me.components)
        Me.dt更新日期1 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.dt创建日期 = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.cob材质 = New UserControl.UCCombo(Me.components)
        Me.cob图纸状态 = New UserControl.UCCombo(Me.components)
        Me.UcLabel19 = New UserControl.UCLabel(Me.components)
        Me.cob材料种类 = New UserControl.UCCombo(Me.components)
        Me.UcLabel7 = New UserControl.UCLabel(Me.components)
        Me.UcLabel16 = New UserControl.UCLabel(Me.components)
        Me.txt材料代号 = New UserControl.UCText(Me.components)
        Me.UcLabel9 = New UserControl.UCLabel(Me.components)
        Me.UcLabel21 = New UserControl.UCLabel(Me.components)
        Me.txt材料名称 = New UserControl.UCText(Me.components)
        Me.txt原材料编号 = New UserControl.UCText(Me.components)
        Me.txt上级图号 = New UserControl.UCText(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn复制 = New System.Windows.Forms.Button
        Me.txt复制后主图号 = New UserControl.UCText(Me.components)
        Me.UcLabel20 = New UserControl.UCLabel(Me.components)
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt图纸版本编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt主图号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt分图号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt主图号品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt长, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt宽, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt单件重量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt要求, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dt更新日期1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt创建日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cob材质, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cob图纸状态, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cob材料种类, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt材料代号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt材料名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt上级图号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txt复制后主图号, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Me.btnF12关闭.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF12关闭.Location = New System.Drawing.Point(918, 12)
        Me.btnF12关闭.TabIndex = 15
        '
        'btnF11
        '
        Me.btnF11.Location = New System.Drawing.Point(840, 12)
        Me.btnF11.TabIndex = 13
        '
        'btnF4删除
        '
        Me.btnF4删除.TabIndex = 8
        Me.btnF4删除.Tag = "200103"
        '
        'btnF3保存
        '
        Me.btnF3保存.TabIndex = 7
        Me.btnF3保存.Tag = "200102"
        '
        'btnF2编辑
        '
        Me.btnF2编辑.TabIndex = 6
        Me.btnF2编辑.Tag = "200101"
        '
        'labModel
        '
        Me.labModel.TabIndex = 10
        Me.labModel.Text = "新增"
        '
        'btnF1清空
        '
        Me.btnF1清空.TabIndex = 5
        '
        'btnF10
        '
        Me.btnF10.TabIndex = 11
        '
        'btnF9
        '
        Me.btnF9.TabIndex = 10
        '
        'btnF8
        '
        Me.btnF8.TabIndex = 12
        Me.btnF8.Tag = "200107"
        Me.btnF8.Text = "F8:行删除"
        '
        'btnF6行删除
        '
        Me.btnF6行删除.FSearchButtonName = "btnF6子级图纸删除"
        Me.btnF6行删除.TabIndex = 10
        Me.btnF6行删除.Tag = "200105"
        Me.btnF6行删除.Text = "F6:子级图纸删除"
        '
        'btnF5行追加
        '
        Me.btnF5行追加.FSearchButtonName = "btnF5子级图纸追加"
        Me.btnF5行追加.TabIndex = 9
        Me.btnF5行追加.Tag = "200104"
        Me.btnF5行追加.Text = "F5:子级图纸追加"
        '
        'btnF7
        '
        Me.btnF7.TabIndex = 11
        Me.btnF7.Tag = "200106"
        Me.btnF7.Text = "F7:行追加"
        '
        'btn图纸导入
        '
        Me.btn图纸导入.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.BackColor = System.Drawing.SystemColors.Control
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        Me.btn图纸导入.Appearance = Appearance4
        Me.btn图纸导入.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btn图纸导入.FSearchButtonName = ""
        Me.btn图纸导入.Location = New System.Drawing.Point(823, 12)
        Me.btn图纸导入.Name = "btn图纸导入"
        Me.btn图纸导入.Size = New System.Drawing.Size(95, 34)
        Me.btn图纸导入.TabIndex = 14
        Me.btn图纸导入.Tag = "200109"
        Me.btn图纸导入.Text = "F11:图纸导入"
        '
        'txt产品图号
        '
        Me.txt产品图号.AutoSize = False
        Me.txt产品图号.IsDigit = False
        Me.txt产品图号.Location = New System.Drawing.Point(110, 20)
        Me.txt产品图号.Name = "txt产品图号"
        Me.txt产品图号.Size = New System.Drawing.Size(184, 23)
        Me.txt产品图号.TabIndex = 0
        '
        'UcLabel6
        '
        Appearance1.BackColor = System.Drawing.Color.SkyBlue
        Appearance1.BackColor2 = System.Drawing.Color.White
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance1.BorderColor = System.Drawing.Color.Black
        Appearance1.BorderColor2 = System.Drawing.Color.Black
        Appearance1.TextHAlignAsString = "Left"
        Appearance1.TextVAlignAsString = "Middle"
        Me.UcLabel6.Appearance = Appearance1
        Me.UcLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel6.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel6.Location = New System.Drawing.Point(10, 20)
        Me.UcLabel6.Name = "UcLabel6"
        Me.UcLabel6.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel6.TabIndex = 0
        Me.UcLabel6.Text = "*产品图号"
        '
        'UcLabel17
        '
        Appearance2.BackColor = System.Drawing.Color.SkyBlue
        Appearance2.BackColor2 = System.Drawing.Color.White
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance2.BorderColor = System.Drawing.Color.Black
        Appearance2.BorderColor2 = System.Drawing.Color.Black
        Appearance2.TextHAlignAsString = "Left"
        Appearance2.TextVAlignAsString = "Middle"
        Me.UcLabel17.Appearance = Appearance2
        Me.UcLabel17.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel17.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel17.Location = New System.Drawing.Point(10, 66)
        Me.UcLabel17.Name = "UcLabel17"
        Me.UcLabel17.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel17.TabIndex = 4
        Me.UcLabel17.Text = "*品名"
        '
        'pic图纸
        '
        Me.pic图纸.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic图纸.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic图纸.Location = New System.Drawing.Point(709, 56)
        Me.pic图纸.Name = "pic图纸"
        Me.pic图纸.Size = New System.Drawing.Size(286, 216)
        Me.pic图纸.TabIndex = 338
        Me.pic图纸.TabStop = False
        '
        'UcLabel5
        '
        Appearance46.BackColor = System.Drawing.Color.SkyBlue
        Appearance46.BackColor2 = System.Drawing.Color.White
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance46.BorderColor = System.Drawing.Color.Black
        Appearance46.BorderColor2 = System.Drawing.Color.Black
        Appearance46.TextHAlignAsString = "Left"
        Appearance46.TextVAlignAsString = "Middle"
        Me.UcLabel5.Appearance = Appearance46
        Me.UcLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel5.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel5.Location = New System.Drawing.Point(10, 89)
        Me.UcLabel5.Name = "UcLabel5"
        Me.UcLabel5.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel5.TabIndex = 6
        Me.UcLabel5.Text = "*客户名称"
        '
        'txt品名
        '
        Me.txt品名.AutoSize = False
        Me.txt品名.IsDigit = False
        Me.txt品名.Location = New System.Drawing.Point(110, 66)
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Size = New System.Drawing.Size(184, 23)
        Me.txt品名.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(374, 56)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "节点2"
        TreeNode1.Text = "三级图号"
        TreeNode2.Name = "节点1"
        TreeNode2.Text = "二级图号"
        TreeNode3.Name = "节点3"
        TreeNode3.Text = "二级图号"
        TreeNode4.Name = "节点0"
        TreeNode4.Text = "一级图号"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.TreeView1.Size = New System.Drawing.Size(312, 562)
        Me.TreeView1.TabIndex = 2
        '
        'txt图纸版本编号
        '
        Me.txt图纸版本编号.AutoSize = False
        Me.txt图纸版本编号.IsDigit = False
        Me.txt图纸版本编号.Location = New System.Drawing.Point(110, 43)
        Me.txt图纸版本编号.Name = "txt图纸版本编号"
        Me.txt图纸版本编号.Size = New System.Drawing.Size(184, 23)
        Me.txt图纸版本编号.TabIndex = 1
        '
        'UcLabel1
        '
        Appearance81.BackColor = System.Drawing.Color.SkyBlue
        Appearance81.BackColor2 = System.Drawing.Color.White
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance81.BorderColor = System.Drawing.Color.Black
        Appearance81.BorderColor2 = System.Drawing.Color.Black
        Appearance81.TextHAlignAsString = "Left"
        Appearance81.TextVAlignAsString = "Middle"
        Me.UcLabel1.Appearance = Appearance81
        Me.UcLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel1.Location = New System.Drawing.Point(10, 43)
        Me.UcLabel1.Name = "UcLabel1"
        Me.UcLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel1.TabIndex = 2
        Me.UcLabel1.Text = "*图纸版本编号"
        '
        'txt客户名称
        '
        Me.txt客户名称.AutoSize = False
        Me.txt客户名称.Enabled = False
        Me.txt客户名称.IsDigit = False
        Me.txt客户名称.Location = New System.Drawing.Point(178, 89)
        Me.txt客户名称.Name = "txt客户名称"
        Me.txt客户名称.ReadOnly = True
        Me.txt客户名称.Size = New System.Drawing.Size(116, 23)
        Me.txt客户名称.TabIndex = 4
        '
        'txt客户编号
        '
        Me.txt客户编号.AutoSize = False
        Me.txt客户编号.ButtonsRight.Add(EditorButton1)
        Me.txt客户编号.IsDigit = False
        Me.txt客户编号.Location = New System.Drawing.Point(110, 89)
        Me.txt客户编号.Name = "txt客户编号"
        Me.txt客户编号.Size = New System.Drawing.Size(68, 23)
        Me.txt客户编号.TabIndex = 3
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9})
        '
        'txt主图号
        '
        Me.txt主图号.AutoSize = False
        Me.txt主图号.ButtonsRight.Add(EditorButton2)
        Me.txt主图号.IsDigit = False
        Me.txt主图号.Location = New System.Drawing.Point(110, 20)
        Me.txt主图号.Name = "txt主图号"
        Me.txt主图号.Size = New System.Drawing.Size(184, 23)
        Me.txt主图号.TabIndex = 0
        '
        'UcLabel3
        '
        Appearance15.BackColor = System.Drawing.Color.SkyBlue
        Appearance15.BackColor2 = System.Drawing.Color.White
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance15.BorderColor = System.Drawing.Color.Black
        Appearance15.BorderColor2 = System.Drawing.Color.Black
        Appearance15.TextHAlignAsString = "Left"
        Appearance15.TextVAlignAsString = "Middle"
        Me.UcLabel3.Appearance = Appearance15
        Me.UcLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcLabel3.Location = New System.Drawing.Point(10, 20)
        Me.UcLabel3.Name = "UcLabel3"
        Me.UcLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel3.TabIndex = 358
        Me.UcLabel3.Text = "*主图号"
        '
        'UcLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.SkyBlue
        Appearance6.BackColor2 = System.Drawing.Color.White
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance6.BorderColor = System.Drawing.Color.Black
        Appearance6.BorderColor2 = System.Drawing.Color.Black
        Appearance6.TextHAlignAsString = "Left"
        Appearance6.TextVAlignAsString = "Middle"
        Me.UcLabel2.Appearance = Appearance6
        Me.UcLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel2.Location = New System.Drawing.Point(10, 112)
        Me.UcLabel2.Name = "UcLabel2"
        Me.UcLabel2.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel2.TabIndex = 4
        Me.UcLabel2.Text = "*数量（套）"
        '
        'txt数量
        '
        Me.txt数量.AutoSize = False
        Me.txt数量.IsDigit = False
        Me.txt数量.Location = New System.Drawing.Point(110, 112)
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Size = New System.Drawing.Size(184, 23)
        Me.txt数量.TabIndex = 4
        '
        'UcLabel4
        '
        Appearance45.BackColor = System.Drawing.Color.SkyBlue
        Appearance45.BackColor2 = System.Drawing.Color.White
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance45.BorderColor = System.Drawing.Color.Black
        Appearance45.BorderColor2 = System.Drawing.Color.Black
        Appearance45.TextHAlignAsString = "Left"
        Appearance45.TextVAlignAsString = "Middle"
        Me.UcLabel4.Appearance = Appearance45
        Me.UcLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel4.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel4.Location = New System.Drawing.Point(10, 66)
        Me.UcLabel4.Name = "UcLabel4"
        Me.UcLabel4.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel4.TabIndex = 0
        Me.UcLabel4.Text = "分图号"
        '
        'txt分图号
        '
        Me.txt分图号.AutoSize = False
        Me.txt分图号.IsDigit = False
        Me.txt分图号.Location = New System.Drawing.Point(110, 66)
        Me.txt分图号.Name = "txt分图号"
        Me.txt分图号.Size = New System.Drawing.Size(184, 23)
        Me.txt分图号.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt主图号)
        Me.GroupBox1.Controls.Add(Me.UcLabel8)
        Me.GroupBox1.Controls.Add(Me.UcLabel4)
        Me.GroupBox1.Controls.Add(Me.UcLabel3)
        Me.GroupBox1.Controls.Add(Me.txt主图号品名)
        Me.GroupBox1.Controls.Add(Me.txt分图号)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "主图号关系信息设定"
        '
        'UcLabel8
        '
        Appearance7.BackColor = System.Drawing.Color.SkyBlue
        Appearance7.BackColor2 = System.Drawing.Color.White
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance7.BorderColor = System.Drawing.Color.Black
        Appearance7.BorderColor2 = System.Drawing.Color.Black
        Appearance7.TextHAlignAsString = "Left"
        Appearance7.TextVAlignAsString = "Middle"
        Me.UcLabel8.Appearance = Appearance7
        Me.UcLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel8.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel8.Location = New System.Drawing.Point(10, 43)
        Me.UcLabel8.Name = "UcLabel8"
        Me.UcLabel8.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel8.TabIndex = 0
        Me.UcLabel8.Text = "主图号品名"
        '
        'txt主图号品名
        '
        Me.txt主图号品名.AutoSize = False
        Me.txt主图号品名.Enabled = False
        Me.txt主图号品名.IsDigit = False
        Me.txt主图号品名.Location = New System.Drawing.Point(110, 43)
        Me.txt主图号品名.Name = "txt主图号品名"
        Me.txt主图号品名.Size = New System.Drawing.Size(184, 23)
        Me.txt主图号品名.TabIndex = 1
        '
        'UcLabel10
        '
        Appearance9.BackColor = System.Drawing.Color.SkyBlue
        Appearance9.BackColor2 = System.Drawing.Color.White
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance9.BorderColor = System.Drawing.Color.Black
        Appearance9.BorderColor2 = System.Drawing.Color.Black
        Appearance9.TextHAlignAsString = "Left"
        Appearance9.TextVAlignAsString = "Middle"
        Me.UcLabel10.Appearance = Appearance9
        Me.UcLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel10.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel10.Location = New System.Drawing.Point(10, 227)
        Me.UcLabel10.Name = "UcLabel10"
        Me.UcLabel10.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel10.TabIndex = 4
        Me.UcLabel10.Text = "长"
        '
        'txt长
        '
        Me.txt长.AutoSize = False
        Me.txt长.IsDigit = False
        Me.txt长.Location = New System.Drawing.Point(110, 227)
        Me.txt长.Name = "txt长"
        Me.txt长.Size = New System.Drawing.Size(184, 23)
        Me.txt长.TabIndex = 9
        '
        'UcLabel11
        '
        Appearance10.BackColor = System.Drawing.Color.SkyBlue
        Appearance10.BackColor2 = System.Drawing.Color.White
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance10.BorderColor = System.Drawing.Color.Black
        Appearance10.BorderColor2 = System.Drawing.Color.Black
        Appearance10.TextHAlignAsString = "Left"
        Appearance10.TextVAlignAsString = "Middle"
        Me.UcLabel11.Appearance = Appearance10
        Me.UcLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel11.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel11.Location = New System.Drawing.Point(10, 250)
        Me.UcLabel11.Name = "UcLabel11"
        Me.UcLabel11.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel11.TabIndex = 4
        Me.UcLabel11.Text = "宽（直径）"
        '
        'txt宽
        '
        Me.txt宽.AutoSize = False
        Me.txt宽.IsDigit = False
        Me.txt宽.Location = New System.Drawing.Point(110, 250)
        Me.txt宽.Name = "txt宽"
        Me.txt宽.Size = New System.Drawing.Size(184, 23)
        Me.txt宽.TabIndex = 10
        '
        'UcLabel12
        '
        Appearance11.BackColor = System.Drawing.Color.SkyBlue
        Appearance11.BackColor2 = System.Drawing.Color.White
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance11.BorderColor = System.Drawing.Color.Black
        Appearance11.BorderColor2 = System.Drawing.Color.Black
        Appearance11.TextHAlignAsString = "Left"
        Appearance11.TextVAlignAsString = "Middle"
        Me.UcLabel12.Appearance = Appearance11
        Me.UcLabel12.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel12.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel12.Location = New System.Drawing.Point(10, 273)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 4
        Me.UcLabel12.Text = "高（厚度）"
        '
        'txt高
        '
        Me.txt高.AutoSize = False
        Me.txt高.IsDigit = False
        Me.txt高.Location = New System.Drawing.Point(110, 273)
        Me.txt高.Name = "txt高"
        Me.txt高.Size = New System.Drawing.Size(184, 23)
        Me.txt高.TabIndex = 11
        '
        'UcLabel13
        '
        Appearance12.BackColor = System.Drawing.Color.SkyBlue
        Appearance12.BackColor2 = System.Drawing.Color.White
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance12.BorderColor = System.Drawing.Color.Black
        Appearance12.BorderColor2 = System.Drawing.Color.Black
        Appearance12.TextHAlignAsString = "Left"
        Appearance12.TextVAlignAsString = "Middle"
        Me.UcLabel13.Appearance = Appearance12
        Me.UcLabel13.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel13.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel13.Location = New System.Drawing.Point(10, 296)
        Me.UcLabel13.Name = "UcLabel13"
        Me.UcLabel13.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel13.TabIndex = 4
        Me.UcLabel13.Text = "单件重量"
        '
        'txt单件重量
        '
        Me.txt单件重量.AutoSize = False
        Me.txt单件重量.IsDigit = False
        Me.txt单件重量.Location = New System.Drawing.Point(110, 296)
        Me.txt单件重量.Name = "txt单件重量"
        Me.txt单件重量.Size = New System.Drawing.Size(184, 23)
        Me.txt单件重量.TabIndex = 12
        '
        'UcLabel14
        '
        Appearance14.BackColor = System.Drawing.Color.SkyBlue
        Appearance14.BackColor2 = System.Drawing.Color.White
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance14.BorderColor = System.Drawing.Color.Black
        Appearance14.BorderColor2 = System.Drawing.Color.Black
        Appearance14.TextHAlignAsString = "Left"
        Appearance14.TextVAlignAsString = "Middle"
        Me.UcLabel14.Appearance = Appearance14
        Me.UcLabel14.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel14.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel14.Location = New System.Drawing.Point(10, 319)
        Me.UcLabel14.Name = "UcLabel14"
        Me.UcLabel14.Size = New System.Drawing.Size(100, 39)
        Me.UcLabel14.TabIndex = 4
        Me.UcLabel14.Text = "要求"
        '
        'txt要求
        '
        Me.txt要求.AutoSize = False
        Me.txt要求.IsDigit = False
        Me.txt要求.Location = New System.Drawing.Point(110, 319)
        Me.txt要求.Name = "txt要求"
        Me.txt要求.Size = New System.Drawing.Size(184, 39)
        Me.txt要求.TabIndex = 13
        '
        'UcLabel15
        '
        Appearance24.BackColor = System.Drawing.Color.SkyBlue
        Appearance24.BackColor2 = System.Drawing.Color.White
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance24.BorderColor = System.Drawing.Color.Black
        Appearance24.BorderColor2 = System.Drawing.Color.Black
        Appearance24.TextHAlignAsString = "Left"
        Appearance24.TextVAlignAsString = "Middle"
        Me.UcLabel15.Appearance = Appearance24
        Me.UcLabel15.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel15.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel15.Location = New System.Drawing.Point(10, 358)
        Me.UcLabel15.Name = "UcLabel15"
        Me.UcLabel15.Size = New System.Drawing.Size(100, 39)
        Me.UcLabel15.TabIndex = 4
        Me.UcLabel15.Text = "备注"
        '
        'txt备注
        '
        Me.txt备注.AutoSize = False
        Me.txt备注.IsDigit = False
        Me.txt备注.Location = New System.Drawing.Point(110, 358)
        Me.txt备注.Name = "txt备注"
        Me.txt备注.Size = New System.Drawing.Size(184, 39)
        Me.txt备注.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl更新日期)
        Me.GroupBox2.Controls.Add(Me.UcLabel18)
        Me.GroupBox2.Controls.Add(Me.dt更新日期1)
        Me.GroupBox2.Controls.Add(Me.dt创建日期)
        Me.GroupBox2.Controls.Add(Me.cob材质)
        Me.GroupBox2.Controls.Add(Me.cob图纸状态)
        Me.GroupBox2.Controls.Add(Me.UcLabel19)
        Me.GroupBox2.Controls.Add(Me.cob材料种类)
        Me.GroupBox2.Controls.Add(Me.UcLabel7)
        Me.GroupBox2.Controls.Add(Me.UcLabel16)
        Me.GroupBox2.Controls.Add(Me.txt材料代号)
        Me.GroupBox2.Controls.Add(Me.UcLabel9)
        Me.GroupBox2.Controls.Add(Me.UcLabel6)
        Me.GroupBox2.Controls.Add(Me.txt产品图号)
        Me.GroupBox2.Controls.Add(Me.UcLabel17)
        Me.GroupBox2.Controls.Add(Me.UcLabel2)
        Me.GroupBox2.Controls.Add(Me.UcLabel21)
        Me.GroupBox2.Controls.Add(Me.UcLabel5)
        Me.GroupBox2.Controls.Add(Me.txt品名)
        Me.GroupBox2.Controls.Add(Me.txt数量)
        Me.GroupBox2.Controls.Add(Me.UcLabel10)
        Me.GroupBox2.Controls.Add(Me.UcLabel11)
        Me.GroupBox2.Controls.Add(Me.txt材料名称)
        Me.GroupBox2.Controls.Add(Me.txt客户名称)
        Me.GroupBox2.Controls.Add(Me.txt原材料编号)
        Me.GroupBox2.Controls.Add(Me.UcLabel12)
        Me.GroupBox2.Controls.Add(Me.txt客户编号)
        Me.GroupBox2.Controls.Add(Me.txt长)
        Me.GroupBox2.Controls.Add(Me.txt图纸版本编号)
        Me.GroupBox2.Controls.Add(Me.UcLabel13)
        Me.GroupBox2.Controls.Add(Me.UcLabel1)
        Me.GroupBox2.Controls.Add(Me.txt宽)
        Me.GroupBox2.Controls.Add(Me.UcLabel14)
        Me.GroupBox2.Controls.Add(Me.txt备注)
        Me.GroupBox2.Controls.Add(Me.txt高)
        Me.GroupBox2.Controls.Add(Me.txt要求)
        Me.GroupBox2.Controls.Add(Me.UcLabel15)
        Me.GroupBox2.Controls.Add(Me.txt单件重量)
        Me.GroupBox2.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 500)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "图号信息"
        '
        'lbl更新日期
        '
        Appearance5.BackColor = System.Drawing.Color.SkyBlue
        Appearance5.BackColor2 = System.Drawing.Color.White
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance5.BorderColor = System.Drawing.Color.Black
        Appearance5.BorderColor2 = System.Drawing.Color.Black
        Appearance5.TextHAlignAsString = "Left"
        Appearance5.TextVAlignAsString = "Middle"
        Me.lbl更新日期.Appearance = Appearance5
        Me.lbl更新日期.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.lbl更新日期.Location = New System.Drawing.Point(10, 419)
        Me.lbl更新日期.Name = "lbl更新日期"
        Me.lbl更新日期.Size = New System.Drawing.Size(100, 23)
        Me.lbl更新日期.TabIndex = 470
        Me.lbl更新日期.Text = "更新日期"
        '
        'UcLabel18
        '
        Appearance16.BackColor = System.Drawing.Color.SkyBlue
        Appearance16.BackColor2 = System.Drawing.Color.White
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance16.BorderColor = System.Drawing.Color.Black
        Appearance16.BorderColor2 = System.Drawing.Color.Black
        Appearance16.TextHAlignAsString = "Left"
        Appearance16.TextVAlignAsString = "Middle"
        Me.UcLabel18.Appearance = Appearance16
        Me.UcLabel18.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel18.Location = New System.Drawing.Point(10, 397)
        Me.UcLabel18.Name = "UcLabel18"
        Me.UcLabel18.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel18.TabIndex = 470
        Me.UcLabel18.Text = "创建日期"
        '
        'dt更新日期1
        '
        Me.dt更新日期1.Location = New System.Drawing.Point(110, 419)
        Me.dt更新日期1.MaskInput = "yyyy/mm/dd"
        Me.dt更新日期1.Name = "dt更新日期1"
        Me.dt更新日期1.Size = New System.Drawing.Size(184, 21)
        Me.dt更新日期1.TabIndex = 16
        '
        'dt创建日期
        '
        Me.dt创建日期.Location = New System.Drawing.Point(110, 397)
        Me.dt创建日期.MaskInput = "yyyy/mm/dd"
        Me.dt创建日期.Name = "dt创建日期"
        Me.dt创建日期.Size = New System.Drawing.Size(184, 21)
        Me.dt创建日期.TabIndex = 15
        '
        'cob材质
        '
        Me.cob材质.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cob材质.DisplayLayout.Appearance = Appearance36
        Me.cob材质.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cob材质.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance37.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance37.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance37.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材质.DisplayLayout.GroupByBox.Appearance = Appearance37
        Appearance38.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材质.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance38
        Me.cob材质.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance39.BackColor2 = System.Drawing.SystemColors.Control
        Appearance39.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材质.DisplayLayout.GroupByBox.PromptAppearance = Appearance39
        Me.cob材质.DisplayLayout.MaxColScrollRegions = 1
        Me.cob材质.DisplayLayout.MaxRowScrollRegions = 1
        Appearance40.BackColor = System.Drawing.SystemColors.Window
        Appearance40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cob材质.DisplayLayout.Override.ActiveCellAppearance = Appearance40
        Appearance41.BackColor = System.Drawing.SystemColors.Highlight
        Appearance41.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cob材质.DisplayLayout.Override.ActiveRowAppearance = Appearance41
        Me.cob材质.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cob材质.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Me.cob材质.DisplayLayout.Override.CardAreaAppearance = Appearance27
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Appearance29.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cob材质.DisplayLayout.Override.CellAppearance = Appearance29
        Me.cob材质.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cob材质.DisplayLayout.Override.CellPadding = 0
        Appearance30.BackColor = System.Drawing.SystemColors.Control
        Appearance30.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance30.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance30.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材质.DisplayLayout.Override.GroupByRowAppearance = Appearance30
        Appearance31.TextHAlignAsString = "Left"
        Me.cob材质.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.cob材质.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cob材质.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.cob材质.DisplayLayout.Override.RowAppearance = Appearance32
        Me.cob材质.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance33.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cob材质.DisplayLayout.Override.TemplateAddRowAppearance = Appearance33
        Me.cob材质.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cob材质.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cob材质.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cob材质.Enabled = False
        Me.cob材质.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cob材质.Location = New System.Drawing.Point(110, 181)
        Me.cob材质.Name = "cob材质"
        Me.cob材质.Size = New System.Drawing.Size(184, 22)
        Me.cob材质.TabIndex = 7
        Me.cob材质.Text = "A"
        '
        'cob图纸状态
        '
        Me.cob图纸状态.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance61.BackColor = System.Drawing.SystemColors.Window
        Appearance61.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cob图纸状态.DisplayLayout.Appearance = Appearance61
        Me.cob图纸状态.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cob图纸状态.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance62.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance62.BorderColor = System.Drawing.SystemColors.Window
        Me.cob图纸状态.DisplayLayout.GroupByBox.Appearance = Appearance62
        Appearance63.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob图纸状态.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance63
        Me.cob图纸状态.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance64.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance64.BackColor2 = System.Drawing.SystemColors.Control
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance64.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob图纸状态.DisplayLayout.GroupByBox.PromptAppearance = Appearance64
        Me.cob图纸状态.DisplayLayout.MaxColScrollRegions = 1
        Me.cob图纸状态.DisplayLayout.MaxRowScrollRegions = 1
        Appearance65.BackColor = System.Drawing.SystemColors.Window
        Appearance65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cob图纸状态.DisplayLayout.Override.ActiveCellAppearance = Appearance65
        Appearance66.BackColor = System.Drawing.SystemColors.Highlight
        Appearance66.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cob图纸状态.DisplayLayout.Override.ActiveRowAppearance = Appearance66
        Me.cob图纸状态.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cob图纸状态.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Me.cob图纸状态.DisplayLayout.Override.CardAreaAppearance = Appearance67
        Appearance68.BorderColor = System.Drawing.Color.Silver
        Appearance68.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cob图纸状态.DisplayLayout.Override.CellAppearance = Appearance68
        Me.cob图纸状态.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cob图纸状态.DisplayLayout.Override.CellPadding = 0
        Appearance69.BackColor = System.Drawing.SystemColors.Control
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.cob图纸状态.DisplayLayout.Override.GroupByRowAppearance = Appearance69
        Appearance70.TextHAlignAsString = "Left"
        Me.cob图纸状态.DisplayLayout.Override.HeaderAppearance = Appearance70
        Me.cob图纸状态.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cob图纸状态.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.cob图纸状态.DisplayLayout.Override.RowAppearance = Appearance71
        Me.cob图纸状态.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance72.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cob图纸状态.DisplayLayout.Override.TemplateAddRowAppearance = Appearance72
        Me.cob图纸状态.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cob图纸状态.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cob图纸状态.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cob图纸状态.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cob图纸状态.Location = New System.Drawing.Point(110, 442)
        Me.cob图纸状态.Name = "cob图纸状态"
        Me.cob图纸状态.Size = New System.Drawing.Size(184, 22)
        Me.cob图纸状态.TabIndex = 17
        '
        'UcLabel19
        '
        Appearance34.BackColor = System.Drawing.Color.SkyBlue
        Appearance34.BackColor2 = System.Drawing.Color.White
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance34.BorderColor = System.Drawing.Color.Black
        Appearance34.BorderColor2 = System.Drawing.Color.Black
        Appearance34.TextHAlignAsString = "Left"
        Appearance34.TextVAlignAsString = "Middle"
        Me.UcLabel19.Appearance = Appearance34
        Me.UcLabel19.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel19.Location = New System.Drawing.Point(10, 442)
        Me.UcLabel19.Name = "UcLabel19"
        Me.UcLabel19.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel19.TabIndex = 444
        Me.UcLabel19.Text = "图纸状态"
        '
        'cob材料种类
        '
        Me.cob材料种类.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cob材料种类.DisplayLayout.Appearance = Appearance17
        Me.cob材料种类.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cob材料种类.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材料种类.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材料种类.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.cob材料种类.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cob材料种类.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.cob材料种类.DisplayLayout.MaxColScrollRegions = 1
        Me.cob材料种类.DisplayLayout.MaxRowScrollRegions = 1
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cob材料种类.DisplayLayout.Override.ActiveCellAppearance = Appearance22
        Appearance23.BackColor = System.Drawing.SystemColors.Highlight
        Appearance23.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cob材料种类.DisplayLayout.Override.ActiveRowAppearance = Appearance23
        Me.cob材料种类.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cob材料种类.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Me.cob材料种类.DisplayLayout.Override.CardAreaAppearance = Appearance25
        Appearance26.BorderColor = System.Drawing.Color.Silver
        Appearance26.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cob材料种类.DisplayLayout.Override.CellAppearance = Appearance26
        Me.cob材料种类.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cob材料种类.DisplayLayout.Override.CellPadding = 0
        Appearance28.BackColor = System.Drawing.SystemColors.Control
        Appearance28.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance28.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.BorderColor = System.Drawing.SystemColors.Window
        Me.cob材料种类.DisplayLayout.Override.GroupByRowAppearance = Appearance28
        Appearance35.TextHAlignAsString = "Left"
        Me.cob材料种类.DisplayLayout.Override.HeaderAppearance = Appearance35
        Me.cob材料种类.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cob材料种类.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance42.BackColor = System.Drawing.SystemColors.Window
        Appearance42.BorderColor = System.Drawing.Color.Silver
        Me.cob材料种类.DisplayLayout.Override.RowAppearance = Appearance42
        Me.cob材料种类.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance43.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cob材料种类.DisplayLayout.Override.TemplateAddRowAppearance = Appearance43
        Me.cob材料种类.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cob材料种类.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cob材料种类.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cob材料种类.Enabled = False
        Me.cob材料种类.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.cob材料种类.Location = New System.Drawing.Point(110, 158)
        Me.cob材料种类.Name = "cob材料种类"
        Me.cob材料种类.Size = New System.Drawing.Size(184, 22)
        Me.cob材料种类.TabIndex = 6
        Me.cob材料种类.Text = "A"
        '
        'UcLabel7
        '
        Appearance44.BackColor = System.Drawing.Color.SkyBlue
        Appearance44.BackColor2 = System.Drawing.Color.White
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance44.BorderColor = System.Drawing.Color.Black
        Appearance44.BorderColor2 = System.Drawing.Color.Black
        Appearance44.TextHAlignAsString = "Left"
        Appearance44.TextVAlignAsString = "Middle"
        Me.UcLabel7.Appearance = Appearance44
        Me.UcLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel7.Location = New System.Drawing.Point(10, 158)
        Me.UcLabel7.Name = "UcLabel7"
        Me.UcLabel7.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel7.TabIndex = 444
        Me.UcLabel7.Text = "材料种类"
        '
        'UcLabel16
        '
        Appearance3.BackColor = System.Drawing.Color.SkyBlue
        Appearance3.BackColor2 = System.Drawing.Color.White
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance3.BorderColor = System.Drawing.Color.Black
        Appearance3.BorderColor2 = System.Drawing.Color.Black
        Appearance3.TextHAlignAsString = "Left"
        Appearance3.TextVAlignAsString = "Middle"
        Me.UcLabel16.Appearance = Appearance3
        Me.UcLabel16.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel16.Location = New System.Drawing.Point(10, 181)
        Me.UcLabel16.Name = "UcLabel16"
        Me.UcLabel16.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel16.TabIndex = 443
        Me.UcLabel16.Text = "材质"
        '
        'txt材料代号
        '
        Me.txt材料代号.AutoSize = False
        Me.txt材料代号.Enabled = False
        Me.txt材料代号.IsDigit = False
        Me.txt材料代号.Location = New System.Drawing.Point(110, 204)
        Me.txt材料代号.Name = "txt材料代号"
        Me.txt材料代号.Size = New System.Drawing.Size(184, 23)
        Me.txt材料代号.TabIndex = 8
        '
        'UcLabel9
        '
        Appearance8.BackColor = System.Drawing.Color.SkyBlue
        Appearance8.BackColor2 = System.Drawing.Color.White
        Appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance8.BorderColor = System.Drawing.Color.Black
        Appearance8.BorderColor2 = System.Drawing.Color.Black
        Appearance8.TextHAlignAsString = "Left"
        Appearance8.TextVAlignAsString = "Middle"
        Me.UcLabel9.Appearance = Appearance8
        Me.UcLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel9.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel9.Location = New System.Drawing.Point(10, 204)
        Me.UcLabel9.Name = "UcLabel9"
        Me.UcLabel9.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel9.TabIndex = 363
        Me.UcLabel9.Text = "材料代号"
        '
        'UcLabel21
        '
        Appearance13.BackColor = System.Drawing.Color.SkyBlue
        Appearance13.BackColor2 = System.Drawing.Color.White
        Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance13.BorderColor = System.Drawing.Color.Black
        Appearance13.BorderColor2 = System.Drawing.Color.Black
        Appearance13.TextHAlignAsString = "Left"
        Appearance13.TextVAlignAsString = "Middle"
        Me.UcLabel21.Appearance = Appearance13
        Me.UcLabel21.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel21.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel21.Location = New System.Drawing.Point(10, 135)
        Me.UcLabel21.Name = "UcLabel21"
        Me.UcLabel21.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel21.TabIndex = 6
        Me.UcLabel21.Text = "材料编码"
        '
        'txt材料名称
        '
        Me.txt材料名称.AutoSize = False
        Me.txt材料名称.Enabled = False
        Me.txt材料名称.IsDigit = False
        Me.txt材料名称.Location = New System.Drawing.Point(178, 135)
        Me.txt材料名称.Name = "txt材料名称"
        Me.txt材料名称.ReadOnly = True
        Me.txt材料名称.Size = New System.Drawing.Size(116, 23)
        Me.txt材料名称.TabIndex = 4
        '
        'txt原材料编号
        '
        Me.txt原材料编号.AutoSize = False
        Me.txt原材料编号.ButtonsRight.Add(EditorButton3)
        Me.txt原材料编号.IsDigit = False
        Me.txt原材料编号.Location = New System.Drawing.Point(110, 135)
        Me.txt原材料编号.Name = "txt原材料编号"
        Me.txt原材料编号.Size = New System.Drawing.Size(68, 23)
        Me.txt原材料编号.TabIndex = 5
        '
        'txt上级图号
        '
        Me.txt上级图号.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txt上级图号.AutoSize = False
        Me.txt上级图号.IsDigit = False
        Me.txt上级图号.Location = New System.Drawing.Point(764, 338)
        Me.txt上级图号.Name = "txt上级图号"
        Me.txt上级图号.Size = New System.Drawing.Size(184, 23)
        Me.txt上级图号.TabIndex = 3
        Me.txt上级图号.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox3.Controls.Add(Me.btn复制)
        Me.GroupBox3.Controls.Add(Me.txt复制后主图号)
        Me.GroupBox3.Controls.Add(Me.UcLabel20)
        Me.GroupBox3.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(692, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "主图复制"
        '
        'btn复制
        '
        Me.btn复制.Location = New System.Drawing.Point(216, 55)
        Me.btn复制.Name = "btn复制"
        Me.btn复制.Size = New System.Drawing.Size(78, 34)
        Me.btn复制.TabIndex = 1
        Me.btn复制.Tag = "200108"
        Me.btn复制.Text = "复制"
        Me.btn复制.UseVisualStyleBackColor = True
        '
        'txt复制后主图号
        '
        Me.txt复制后主图号.AutoSize = False
        Me.txt复制后主图号.IsDigit = False
        Me.txt复制后主图号.Location = New System.Drawing.Point(110, 20)
        Me.txt复制后主图号.Name = "txt复制后主图号"
        Me.txt复制后主图号.Size = New System.Drawing.Size(184, 23)
        Me.txt复制后主图号.TabIndex = 0
        '
        'UcLabel20
        '
        Appearance18.BackColor = System.Drawing.Color.SkyBlue
        Appearance18.BackColor2 = System.Drawing.Color.White
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump
        Appearance18.BorderColor = System.Drawing.Color.Black
        Appearance18.BorderColor2 = System.Drawing.Color.Black
        Appearance18.TextHAlignAsString = "Left"
        Appearance18.TextVAlignAsString = "Middle"
        Me.UcLabel20.Appearance = Appearance18
        Me.UcLabel20.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Etched
        Me.UcLabel20.Font = New System.Drawing.Font("宋体", 9.0!)
        Me.UcLabel20.Location = New System.Drawing.Point(10, 20)
        Me.UcLabel20.Name = "UcLabel20"
        Me.UcLabel20.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel20.TabIndex = 0
        Me.UcLabel20.Text = "复制后主图号"
        '
        'frm图纸信息管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn图纸导入)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.txt上级图号)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.pic图纸)
        Me.KeyPreview = True
        Me.Name = "frm图纸信息管理"
        Me.Text = "图纸信息管理"
        Me.Controls.SetChildIndex(Me.pic图纸, 0)
        Me.Controls.SetChildIndex(Me.btnF11, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.txt上级图号, 0)
        Me.Controls.SetChildIndex(Me.TreeView1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btn图纸导入, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnF5行追加, 0)
        Me.Controls.SetChildIndex(Me.btnF6行删除, 0)
        Me.Controls.SetChildIndex(Me.btnF8, 0)
        Me.Controls.SetChildIndex(Me.btnF7, 0)
        Me.Controls.SetChildIndex(Me.btnF9, 0)
        Me.Controls.SetChildIndex(Me.btnF10, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF2编辑, 0)
        Me.Controls.SetChildIndex(Me.btnF3保存, 0)
        Me.Controls.SetChildIndex(Me.btnF4删除, 0)
        Me.Controls.SetChildIndex(Me.labModel, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        CType(Me.txt产品图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic图纸, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt图纸版本编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt客户编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt主图号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt分图号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txt主图号品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt长, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt宽, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt单件重量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt要求, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt备注, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dt更新日期1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt创建日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cob材质, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cob图纸状态, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cob材料种类, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt材料代号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt材料名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原材料编号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt上级图号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txt复制后主图号, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn图纸导入 As UserControl.UCButton
    Friend WithEvents txt产品图号 As UserControl.UCText
    Friend WithEvents UcLabel6 As UserControl.UCLabel
    Friend WithEvents UcLabel17 As UserControl.UCLabel
    Friend WithEvents pic图纸 As System.Windows.Forms.PictureBox
    Friend WithEvents UcLabel5 As UserControl.UCLabel
    Friend WithEvents txt品名 As UserControl.UCText
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txt图纸版本编号 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents txt客户名称 As UserControl.UCText
    Friend WithEvents txt客户编号 As UserControl.UCText
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt主图号 As UserControl.UCText
    Friend WithEvents UcLabel3 As UserControl.UCLabel
    Friend WithEvents UcLabel2 As UserControl.UCLabel
    Friend WithEvents txt数量 As UserControl.UCText
    Friend WithEvents UcLabel4 As UserControl.UCLabel
    Friend WithEvents txt分图号 As UserControl.UCText
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcLabel10 As UserControl.UCLabel
    Friend WithEvents txt长 As UserControl.UCText
    Friend WithEvents UcLabel11 As UserControl.UCLabel
    Friend WithEvents txt宽 As UserControl.UCText
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt高 As UserControl.UCText
    Friend WithEvents UcLabel13 As UserControl.UCLabel
    Friend WithEvents txt单件重量 As UserControl.UCText
    Friend WithEvents UcLabel14 As UserControl.UCLabel
    Friend WithEvents txt要求 As UserControl.UCText
    Friend WithEvents UcLabel15 As UserControl.UCLabel
    Friend WithEvents txt备注 As UserControl.UCText
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents UcLabel8 As UserControl.UCLabel
    Friend WithEvents txt主图号品名 As UserControl.UCText
    Friend WithEvents txt材料代号 As UserControl.UCText
    Friend WithEvents UcLabel9 As UserControl.UCLabel
    Friend WithEvents cob材质 As UserControl.UCCombo
    Friend WithEvents cob材料种类 As UserControl.UCCombo
    Friend WithEvents UcLabel7 As UserControl.UCLabel
    Friend WithEvents UcLabel16 As UserControl.UCLabel
    Friend WithEvents lbl更新日期 As UserControl.UCLabel
    Friend WithEvents UcLabel18 As UserControl.UCLabel
    Friend WithEvents dt更新日期1 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt创建日期 As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cob图纸状态 As UserControl.UCCombo
    Friend WithEvents UcLabel19 As UserControl.UCLabel
    Friend WithEvents txt上级图号 As UserControl.UCText
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt复制后主图号 As UserControl.UCText
    Friend WithEvents UcLabel20 As UserControl.UCLabel
    Friend WithEvents btn复制 As System.Windows.Forms.Button
    Friend WithEvents UcLabel21 As UserControl.UCLabel
    Friend WithEvents txt材料名称 As UserControl.UCText
    Friend WithEvents txt原材料编号 As UserControl.UCText
End Class
