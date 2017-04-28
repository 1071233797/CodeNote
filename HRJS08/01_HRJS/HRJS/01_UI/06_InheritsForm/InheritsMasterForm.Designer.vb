<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InheritsMasterForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの查询をクリーンアップするために dispose をオーバーライドします。
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
    'CD エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.btnF12关闭 = New UserControl.UCButton(Me.components)
        Me.btnF1清空 = New UserControl.UCButton(Me.components)
        Me.btnF4删除 = New UserControl.UCButton(Me.components)
        Me.btnF2编辑 = New UserControl.UCButton(Me.components)
        Me.btnF3保存 = New UserControl.UCButton(Me.components)
        Me.labModel = New UserControl.UCLabel(Me.components)
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Control
        Appearance1.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF12关闭.Appearance = Appearance1
        Me.btnF12关闭.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF12关闭.FSearchButtonName = "btnF12关闭"
        Me.btnF12关闭.Location = New System.Drawing.Point(918, 12)
        Me.btnF12关闭.Name = "btnF12关闭"
        Me.btnF12关闭.Size = New System.Drawing.Size(78, 34)
        Me.btnF12关闭.TabIndex = 46
        Me.btnF12关闭.Text = "F12:关闭"
        '
        'btnF1清空
        '
        Appearance3.BackColor = System.Drawing.SystemColors.Control
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF1清空.Appearance = Appearance3
        Me.btnF1清空.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF1清空.FSearchButtonName = "btnF1清空"
        Me.btnF1清空.Location = New System.Drawing.Point(62, 12)
        Me.btnF1清空.Name = "btnF1清空"
        Me.btnF1清空.Size = New System.Drawing.Size(78, 34)
        Me.btnF1清空.TabIndex = 43
        Me.btnF1清空.Text = "F1:清空"
        '
        'btnF4删除
        '
        Appearance8.BackColor = System.Drawing.SystemColors.Control
        Appearance8.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF4删除.Appearance = Appearance8
        Me.btnF4删除.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF4删除.FSearchButtonName = "btnF4删除"
        Me.btnF4删除.Location = New System.Drawing.Point(296, 12)
        Me.btnF4删除.Name = "btnF4删除"
        Me.btnF4删除.Size = New System.Drawing.Size(78, 34)
        Me.btnF4删除.TabIndex = 42
        Me.btnF4删除.Text = "F4:删除"
        '
        'btnF2编辑
        '
        Appearance5.BackColor = System.Drawing.SystemColors.Control
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF2编辑.Appearance = Appearance5
        Me.btnF2编辑.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF2编辑.FSearchButtonName = "btnF2编辑"
        Me.btnF2编辑.Location = New System.Drawing.Point(140, 12)
        Me.btnF2编辑.Name = "btnF2编辑"
        Me.btnF2编辑.Size = New System.Drawing.Size(78, 34)
        Me.btnF2编辑.TabIndex = 41
        Me.btnF2编辑.Text = "F2:编辑"
        '
        'btnF3保存
        '
        Appearance6.BackColor = System.Drawing.SystemColors.Control
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF3保存.Appearance = Appearance6
        Me.btnF3保存.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF3保存.FSearchButtonName = "btnF3保存"
        Me.btnF3保存.Location = New System.Drawing.Point(218, 12)
        Me.btnF3保存.Name = "btnF3保存"
        Me.btnF3保存.Size = New System.Drawing.Size(78, 34)
        Me.btnF3保存.TabIndex = 40
        Me.btnF3保存.Text = "F3:保存"
        '
        'labModel
        '
        Appearance7.BackColor = System.Drawing.Color.Yellow
        Appearance7.FontData.BoldAsString = "True"
        Appearance7.ForeColor = System.Drawing.Color.Red
        Appearance7.TextHAlignAsString = "Center"
        Appearance7.TextVAlignAsString = "Middle"
        Me.labModel.Appearance = Appearance7
        Me.labModel.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Solid
        Me.labModel.Font = New System.Drawing.Font("MS Gothic", 13.0!)
        Me.labModel.Location = New System.Drawing.Point(12, 13)
        Me.labModel.Name = "labModel"
        Me.labModel.Size = New System.Drawing.Size(50, 32)
        Me.labModel.TabIndex = 38
        Me.labModel.Text = "新建"
        '
        'InheritsMasterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF12关闭)
        Me.Controls.Add(Me.btnF1清空)
        Me.Controls.Add(Me.btnF4删除)
        Me.Controls.Add(Me.btnF2编辑)
        Me.Controls.Add(Me.btnF3保存)
        Me.Controls.Add(Me.labModel)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.KeyPreview = True
        Me.Name = "InheritsMasterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnF12关闭 As UserControl.UCButton
    Public WithEvents btnF1清空 As UserControl.UCButton
    Public WithEvents btnF4删除 As UserControl.UCButton
    Public WithEvents btnF2编辑 As UserControl.UCButton
    Public WithEvents btnF3保存 As UserControl.UCButton
    Public WithEvents labModel As UserControl.UCLabel
End Class
