<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm数据备份
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraGroupBox1 = New UserControl.UCGroupBox(Me.components)
        Me.txt上次备份日期 = New UserControl.UCText(Me.components)
        Me.UcLabel1 = New UserControl.UCLabel(Me.components)
        Me.txt数据库备份路径 = New UserControl.UCText(Me.components)
        Me.UcLabel12 = New UserControl.UCLabel(Me.components)
        Me.btnF11备份 = New UserControl.UCButton(Me.components)
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.txt上次备份日期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数据库备份路径, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnF3选择.Location = New System.Drawing.Point(264, 154)
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
        Me.UltraGroupBox1.Controls.Add(Me.txt上次备份日期)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txt数据库备份路径)
        Me.UltraGroupBox1.Controls.Add(Me.UcLabel12)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(506, 136)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "备份条件"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'txt上次备份日期
        '
        Me.txt上次备份日期.AutoSize = False
        Me.txt上次备份日期.IsDigit = False
        Me.txt上次备份日期.Location = New System.Drawing.Point(115, 33)
        Me.txt上次备份日期.Name = "txt上次备份日期"
        Me.txt上次备份日期.ReadOnly = True
        Me.txt上次备份日期.Size = New System.Drawing.Size(115, 23)
        Me.txt上次备份日期.TabIndex = 1
        Me.txt上次备份日期.TabStop = False
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
        Me.UcLabel1.Text = "上次备份日期"
        '
        'txt数据库备份路径
        '
        Me.txt数据库备份路径.AutoSize = False
        Me.txt数据库备份路径.ButtonsRight.Add(EditorButton1)
        Me.txt数据库备份路径.IsDigit = False
        Me.txt数据库备份路径.Location = New System.Drawing.Point(115, 62)
        Me.txt数据库备份路径.Name = "txt数据库备份路径"
        Me.txt数据库备份路径.Size = New System.Drawing.Size(289, 23)
        Me.txt数据库备份路径.TabIndex = 3
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
        Me.UcLabel12.Location = New System.Drawing.Point(15, 62)
        Me.UcLabel12.Name = "UcLabel12"
        Me.UcLabel12.Size = New System.Drawing.Size(100, 23)
        Me.UcLabel12.TabIndex = 2
        Me.UcLabel12.Text = "数据备份路径"
        '
        'btnF11备份
        '
        Me.btnF11备份.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.BackColor = System.Drawing.SystemColors.Control
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.TextHAlignAsString = "Center"
        Appearance20.TextVAlignAsString = "Middle"
        Me.btnF11备份.Appearance = Appearance20
        Me.btnF11备份.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF11备份.FSearchButtonName = ""
        Me.btnF11备份.Location = New System.Drawing.Point(352, 154)
        Me.btnF11备份.Name = "btnF11备份"
        Me.btnF11备份.Size = New System.Drawing.Size(80, 34)
        Me.btnF11备份.TabIndex = 4
        Me.btnF11备份.Tag = "102301"
        Me.btnF11备份.Text = "F11:备份"
        '
        'frm数据备份
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 196)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.btnF11备份)
        Me.KeyPreview = True
        Me.Name = "frm数据备份"
        Me.Text = "数据备份"
        Me.Controls.SetChildIndex(Me.btnF2查询, 0)
        Me.Controls.SetChildIndex(Me.btnF1清空, 0)
        Me.Controls.SetChildIndex(Me.btnF3选择, 0)
        Me.Controls.SetChildIndex(Me.btnF11备份, 0)
        Me.Controls.SetChildIndex(Me.btnF12关闭, 0)
        Me.Controls.SetChildIndex(Me.UltraGroupBox1, 0)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.txt上次备份日期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数据库备份路径, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnF11备份 As UserControl.UCButton
    Friend WithEvents UltraGroupBox1 As UserControl.UCGroupBox
    Friend WithEvents txt数据库备份路径 As UserControl.UCText
    Friend WithEvents UcLabel12 As UserControl.UCLabel
    Friend WithEvents txt上次备份日期 As UserControl.UCText
    Friend WithEvents UcLabel1 As UserControl.UCLabel
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
End Class
