<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InheritsSearchForm
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'CD エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.btnF12关闭 = New UserControl.UCButton(Me.components)
        Me.btnF3选择 = New UserControl.UCButton(Me.components)
        Me.btnF2查询 = New UserControl.UCButton(Me.components)
        Me.btnF1清空 = New UserControl.UCButton(Me.components)
        Me.SuspendLayout()
        '
        'btnF12关闭
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Control
        Appearance1.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF12关闭.Appearance = Appearance1
        Me.btnF12关闭.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF12关闭.FSearchButtonName = "btnF12关闭"
        Me.btnF12关闭.Location = New System.Drawing.Point(916, 12)
        Me.btnF12关闭.Name = "btnF12关闭"
        Me.btnF12关闭.Size = New System.Drawing.Size(80, 34)
        Me.btnF12关闭.TabIndex = 54
        Me.btnF12关闭.Text = "F12:关闭"
        '
        'btnF3选择
        '
        Appearance4.BackColor = System.Drawing.SystemColors.Control
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF3选择.Appearance = Appearance4
        Me.btnF3选择.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF3选择.FSearchButtonName = "btnF3选择"
        Me.btnF3选择.Location = New System.Drawing.Point(172, 12)
        Me.btnF3选择.Name = "btnF3选择"
        Me.btnF3选择.Size = New System.Drawing.Size(80, 34)
        Me.btnF3选择.TabIndex = 51
        Me.btnF3选择.Text = "F3:选择"
        '
        'btnF2查询
        '
        Appearance5.BackColor = System.Drawing.SystemColors.Control
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF2查询.Appearance = Appearance5
        Me.btnF2查询.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF2查询.FSearchButtonName = "btnF2查询"
        Me.btnF2查询.Location = New System.Drawing.Point(92, 12)
        Me.btnF2查询.Name = "btnF2查询"
        Me.btnF2查询.Size = New System.Drawing.Size(80, 34)
        Me.btnF2查询.TabIndex = 51
        Me.btnF2查询.Text = "F2:查询"
        '
        'btnF1清空
        '
        Appearance2.BackColor = System.Drawing.SystemColors.Control
        Appearance2.BackColor2 = System.Drawing.SystemColors.Control
        Me.btnF1清空.Appearance = Appearance2
        Me.btnF1清空.Font = New System.Drawing.Font("MS Gothic", 9.0!)
        Me.btnF1清空.FSearchButtonName = "btnF1清空"
        Me.btnF1清空.Location = New System.Drawing.Point(12, 12)
        Me.btnF1清空.Name = "btnF1清空"
        Me.btnF1清空.Size = New System.Drawing.Size(80, 34)
        Me.btnF1清空.TabIndex = 51
        Me.btnF1清空.Text = "F1:清空"
        '
        'InheritsSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 692)
        Me.Controls.Add(Me.btnF12关闭)
        Me.Controls.Add(Me.btnF3选择)
        Me.Controls.Add(Me.btnF1清空)
        Me.Controls.Add(Me.btnF2查询)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "InheritsSearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InheritsSearchForm"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnF12关闭 As UserControl.UCButton
    Public WithEvents btnF2查询 As UserControl.UCButton
    Public WithEvents btnF3选择 As UserControl.UCButton
    Public WithEvents btnF1清空 As UserControl.UCButton
End Class
