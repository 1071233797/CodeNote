Imports System.Data

Public Class F成品入库


    Private Sub F成品入库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFrom()
    End Sub

    Private Sub F成品入库_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub ClearFrom()
        txt申请单.Text = String.Empty
        txt订单编号.Text = String.Empty
        txt产品图号.Text = String.Empty
        txt产品图名.Text = String.Empty
        txt数量.Text = String.Empty
        txt重量.Text = String.Empty
        txt申请单.ReadOnly = False
        txt订单编号.ReadOnly = False
        txt备注.Text = String.Empty
        btn保存.Enabled = False
        txt申请单.Focus()
    End Sub

    Private Sub ClearFrom2()

        txt订单编号.Text = String.Empty
        txt产品图号.Text = String.Empty
        txt产品图名.Text = String.Empty
        txt数量.Text = String.Empty
        txt重量.Text = String.Empty
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt订单编号.Focus()
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub



    Private Sub txt申请单_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt申请单.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt申请单.ReadOnly = True
            txt订单编号.Focus()
        End If
    End Sub

    Private Sub txt订单编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt订单编号.KeyPress

        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim value() As String = txt订单编号.Text.Trim.Split("|")


                Dim m As New M产成品入库申请
                m.申请单编号 = txt申请单.Text.Trim

                m.订单编号 = value(0)
                m.产品图号 = value(1)
                m.入库数量 = value(2)
                m.入库重量 = value(3)
                txt订单编号.Text = value(0)
                txt产品图号.Text = value(1)
                txt产品图名.Text = DALUtility.select图名(value(1))
                txt数量.Text = value(2)
                txt重量.Text = value(3)
                lbl库存区域.Text = value(4)
                Dim dt As DataTable = DALUtility.select产成品入库申请(m)

                If dt.Rows.Count > 0 Then
                    '''''''''''''''''''''
                    txt备注.Focus()
                    btn保存.Enabled = True
                Else
                    MsgBox("申请单与产品编号不匹配！")
                    ClearFrom2()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click


        Dim m1 As New M产成品出入库记录
        m1.入出库记录CD = Utility.GetRoundID()
        m1.入出库区分 = Utility.出入库区分_入库
        m1.申请单编号 = txt申请单.Text.Trim
        m1.订单编号 = txt订单编号.Text.Trim
        m1.产品图号 = txt产品图号.Text.Trim
        m1.入出库数量 = txt数量.Text.Trim
        m1.入出库重量 = txt重量.Text.Trim
        m1.入出库日期 = Utility.GetDateTime()
        m1.库存区域 = lbl库存区域.Text.Trim
        m1.操作者 = Utility.操作者编号
        m1.操作PDA = Utility.操作PDA_IP
        m1.备注 = txt备注.Text.Trim
        m1.库存状态 = Utility.库存状态_正常品

        Dim m2 As New M产成品库存
        m2.产品图号 = txt产品图号.Text.Trim
        m2.订单编号 = txt订单编号.Text.Trim
        m2.库存数量 = txt数量.Text.Trim
        m2.库存重量 = txt重量.Text.Trim
        m2.库存区域 = lbl库存区域.Text.Trim
        m2.入库日期 = Utility.GetDateTime()
        m2.库存状态 = Utility.库存状态_正常品

        If DALUtility.select产成品库存(m2).Rows.Count > 0 Then
            MsgBox("已操作，无需重复操作！")
            ClearFrom2()
            Exit Sub
        End If

        If DALUtility.insert产成品(m1, m2) Then
            MsgBox("保存成功！")
            ClearFrom2()
        Else
            MsgBox("保存失败！")
        End If
    End Sub
End Class