Imports System.Data

Public Class F原材料出库

    Private Sub F原材料出库_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub ClearFrom()
        txt申请单.Text = String.Empty
        txt材料编号.Text = String.Empty
        txt材料名称.Text = String.Empty
        txt批次.Text = String.Empty
        txt库存数量.Text = String.Empty
        txt库存重量.Text = String.Empty
        lbl领料数量.Text = String.Empty
        lbl领料重量.Text = String.Empty
        txt备注.Text = String.Empty
        txt申请单.ReadOnly = False
        txt材料编号.ReadOnly = False
        btn保存.Enabled = False
        txt申请单.Focus()
    End Sub

    Private Sub ClearFrom2()

        txt材料编号.Text = String.Empty
        txt材料名称.Text = String.Empty
        txt批次.Text = String.Empty
        txt库存数量.Text = String.Empty
        txt库存重量.Text = String.Empty
        lbl领料数量.Text = String.Empty
        lbl领料重量.Text = String.Empty
        txt材料编号.ReadOnly = False
        btn保存.Enabled = False
        txt材料编号.Focus()
    End Sub

    Private Sub txt申请单_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt申请单.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt申请单.ReadOnly = True
            txt材料编号.Focus()
        End If
    End Sub

    Private Sub txt材料编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt材料编号.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim value() As String = txt材料编号.Text.Trim.Split("|")


                Dim m As New M原材料出库申请
                m.申请单编号 = txt申请单.Text.Trim

                m.材料编号 = value(0)
                m.批次号 = value(1)

                txt材料编号.Text = value(0)
                txt批次.Text = value(1)
                txt材料名称.Text = DALUtility.select原材料名称(value(0))
                lbl库存区域.Text = value(4)  '库存区域

                Dim m2 As New M原材料库存
                m2.材料编号 = txt材料编号.Text.Trim
                m2.批次号 = txt批次.Text.Trim

                Dim m3 As New M原材料出入库记录

                m3.申请单编号 = txt申请单.Text.Trim
                m3.材料编号 = txt材料编号.Text.Trim

                Dim dt As DataTable = DALUtility.select原材料出库申请(m)
                Dim dtk As DataTable = DALUtility.select原材料库存(m2)
                Dim dto As DataTable = DALUtility.select原材料出库SUM(m3)

              
                '判断申请单材料
                If dt.Rows.Count > 0 Then
                    '判断已领材料
                    If dto.Rows.Count > 0 Then
                        lbl领料数量.Text = Convert.ToDecimal(dt.Rows(0)("领料数量").ToString) - Convert.ToDecimal(dto.Rows(0)("数量").ToString)
                        lbl领料重量.Text = Convert.ToDecimal(dt.Rows(0)("领料重量").ToString) - Convert.ToDecimal(dto.Rows(0)("重量").ToString)
                    Else
                        lbl领料数量.Text = dt.Rows(0)("领料数量").ToString
                        lbl领料重量.Text = dt.Rows(0)("领料重量").ToString
                    End If
                    txt备注.Focus()
                    btn保存.Enabled = True
                Else
                    MsgBox("申请单与材料编号不匹配！")
                    ClearFrom2()
                    Exit Sub
                End If

                '判断库存材料
                If dtk.Rows.Count > 0 Then
                    txt库存数量.Text = dtk.Rows(0)("库存数量").ToString
                    txt库存重量.Text = dtk.Rows(0)("库存重量").ToString
                Else
                    MsgBox("库存中不存在的材料编号，请核对标签！")
                    ClearFrom2()
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click


        If Utility.isNumer(lbl领料数量) Then
            MsgBox("领料数量必须是数字")
            lbl领料数量.Text = String.Empty
            lbl领料数量.Focus()
            Exit Sub
        End If

        If Utility.isNumer(lbl领料重量) Then
            MsgBox("领料重量必须是数字")
            lbl领料重量.Text = String.Empty
            lbl领料重量.Focus()
            Exit Sub
        End If


        Dim m1 As New M原材料出入库记录
        m1.入出库编号 = Utility.GetRoundID()
        m1.入出库区分 = Utility.出入库区分_出库
        m1.申请单编号 = txt申请单.Text.Trim
        m1.材料编号 = txt材料编号.Text.Trim
        m1.批次号 = txt批次.Text.Trim

        If Convert.ToDecimal(lbl领料数量.Text.Trim) > Convert.ToDecimal(txt库存数量.Text.Trim) Then
            m1.入出库数量 = txt库存数量.Text.Trim
        Else
            m1.入出库数量 = lbl领料数量.Text.Trim
        End If

        If Convert.ToDecimal(lbl领料重量.Text.Trim) > Convert.ToDecimal(txt库存数量.Text.Trim) Then
            m1.入出库重量 = txt库存重量.Text.Trim
        Else
            m1.入出库重量 = lbl领料数量.Text.Trim
        End If

        m1.入出库日期 = Utility.GetDateTime()
        m1.库存区域 = lbl库存区域.Text.Trim
        m1.操作者编号 = Utility.操作者编号
        m1.操作PDA编号 = Utility.操作PDA_IP
        m1.备注 = txt备注.Text.Trim

        Dim m2 As New M原材料库存
        m2.材料编号 = txt材料编号.Text.Trim
        m2.批次号 = txt批次.Text.Trim
        m2.库存数量 = m1.入出库数量
        m2.库存重量 = m1.入出库重量
        m2.库存区域 = lbl库存区域.Text.Trim
        m2.入库日期 = Utility.GetDateTime()
        m2.备注 = txt备注.Text.Trim
       
        If DALUtility.update原材料(m1, m2) Then
            MsgBox("保存成功！")
            ClearFrom2()
        End If

    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub

    Private Sub F原材料出库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFrom()
    End Sub

    Private Sub lbl领料数量_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl领料数量.GotFocus
        lbl领料数量.SelectAll()
    End Sub

    Private Sub lbl领料重量_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl领料重量.GotFocus
        lbl领料重量.SelectAll()
    End Sub
End Class