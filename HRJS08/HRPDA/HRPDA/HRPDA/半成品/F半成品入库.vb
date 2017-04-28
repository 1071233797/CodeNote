Imports System.Data

Public Class F半成品入库

    Private str半成品种类 As String = ""
    Private str半成品库存区域 As String = ""
    Private str半成品上级图号 As String = ""

    Private Sub ClearForm()
        txt申请单.Text = String.Empty
        txt订单编号.Text = String.Empty
        txt主图号.Text = String.Empty
        txt主图名称.Text = String.Empty
        txt分图号.Text = String.Empty
        txt分图名称.Text = String.Empty
        txt工序编号.Text = String.Empty
        txt工序名称.Text = String.Empty
        txt数量.Text = String.Empty
        txt申请单.ReadOnly = False
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt申请单.Focus()
    End Sub

    Private Sub ClearForm2()

        txt订单编号.Text = String.Empty
        txt主图号.Text = String.Empty
        txt主图名称.Text = String.Empty
        txt分图号.Text = String.Empty
        txt分图名称.Text = String.Empty
        txt工序编号.Text = String.Empty
        txt工序名称.Text = String.Empty
        txt数量.Text = String.Empty
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt订单编号.Focus()
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearForm()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub


    Private Sub F半成品入库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub


    Private Sub F半成品入库_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
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

                Dim m As New M半成品入库申请
                m.申请单编号 = txt申请单.Text.Trim
                m.订单编号 = value(0)
                m.主图号 = value(1)
                m.上级图号 = value(2)
                m.分图号 = value(3)
                m.工序编号 = value(4)
                m.入库数量 = value(5)


                txt订单编号.Text = value(0)
                txt主图号.Text = value(1)
                txt主图名称.Text = DALUtility.select图名(value(1))
                txt分图号.Text = value(3)
                txt分图名称.Text = DALUtility.select图名(value(3))
                txt工序编号.Text = value(4)
                txt工序名称.Text = DALUtility.select工序名称(value(3), value(4))
                txt数量.Text = value(5)
                str半成品种类 = value(6)
                str半成品库存区域 = value(7)

                str半成品上级图号 = value(2)

                Dim dt As DataTable = DALUtility.select半成品入库申请(m)

                If dt.Rows.Count > 0 Then
                    '''''''''''''''''''''
                    btn保存.Enabled = True
                    btn保存.Focus()
                Else
                    MsgBox("申请单与半成品号不匹配！")
                  ClearForm2()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click

        Dim m1 As New M半成品出入库记录
        m1.入出库记录CD = Utility.GetRoundID()
        m1.入出库区分 = Utility.出入库区分_入库
        m1.申请单编号 = txt申请单.Text.Trim
        m1.订单编号 = txt订单编号.Text.Trim
        m1.主图号 = txt主图号.Text.Trim
        m1.分图号 = txt分图号.Text.Trim
        m1.工序编号 = txt工序编号.Text.Trim
        m1.数量 = txt数量.Text.Trim
        m1.操作者编号 = Utility.操作者编号
        m1.入出库日期 = Utility.GetDateTime()
        m1.库存区域 = str半成品库存区域

        m1.上级图号 = str半成品上级图号

        Dim m2 As New M半成品库存
        m2.订单编号 = txt订单编号.Text.Trim
        m2.主图号 = txt主图号.Text.Trim
        m2.上级图号 = str半成品上级图号
        m2.分图号 = txt分图号.Text.Trim
        m2.工序编号 = txt工序编号.Text.Trim
        m2.库存数量 = txt数量.Text.Trim
        m2.半成品种类 = str半成品种类
        m2.库存区域 = str半成品库存区域


        If DALUtility.select半成品库存(m2).Rows.Count > 0 Then
            MsgBox("已操作，无需重复操作！")
            ClearForm2()
            Exit Sub
        End If

        If DALUtility.insert半成品(m1, m2) Then
            MsgBox("保存成功！")
            ClearForm()
        End If

    End Sub
End Class