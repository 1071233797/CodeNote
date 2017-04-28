Imports System.Data

Public Class F成品出库

    Private Sub ClearFrom()
        txt出荷指示.Text = String.Empty
        txt订单编号.Text = String.Empty
        txt产品图号.Text = String.Empty
        txt产品图名.Text = String.Empty
        txt出库数量.Text = String.Empty
        txt库存数量.Text = String.Empty
        txt出荷指示.ReadOnly = False
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt出荷指示.Focus()
    End Sub

    Private Sub ClearFrom2()

        txt订单编号.Text = String.Empty
        txt产品图号.Text = String.Empty
        txt产品图名.Text = String.Empty
        txt出库数量.Text = String.Empty
        txt库存数量.Text = String.Empty
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt订单编号.Focus()
    End Sub

    Private Sub F成品出库_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFrom()
    End Sub

    Private Sub F成品出库_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub

    Private Sub txt出荷指示_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt出荷指示.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txt出荷指示.ReadOnly = True
            txt订单编号.Focus()
        End If
    End Sub

    Private Sub txt订单编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt订单编号.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim value() As String = txt订单编号.Text.Trim.Split("|")

                Dim m As New M产成品出库申请
                m.出荷指示编号 = txt出荷指示.Text.Trim
                m.订单编号 = value(0)
                m.产品图号 = value(1)


                txt订单编号.Text = value(0)
                txt产品图号.Text = value(1)
                txt产品图名.Text = DALUtility.select图名(value(1))
                lbl库存区域.Text = value(4)

                Dim m2 As New M产成品库存

                m2.订单编号 = txt订单编号.Text.Trim
                m2.产品图号 = txt产品图号.Text



                Dim m3 As New M产成品出入库记录

                m3.申请单编号 = txt出荷指示.Text.Trim
                m3.订单编号 = txt订单编号.Text.Trim



                Dim dt As DataTable = DALUtility.select产成品出库申请(m)
                Dim dtk As DataTable = DALUtility.select产成品库存(m2)
                Dim dto As DataTable = DALUtility.select产成品出库SUM(m3)


                '判断申请单量
                If dt.Rows.Count > 0 Then
                    '判断已领材料
                    If dto.Rows.Count > 0 Then
                        txt出库数量.Text = Convert.ToDecimal(dt.Rows(0)("出荷数量").ToString) - Convert.ToDecimal(dto.Rows(0)("数量").ToString)

                    Else
                        txt出库数量.Text = dt.Rows(0)("出荷数量").ToString

                    End If
                    btn保存.Enabled = True
                    btn保存.Focus()
                Else
                    MsgBox("申请单与产品不匹配！")
                    ClearFrom2()
                    Exit Sub
                End If

                '判断库存量
                If dtk.Rows.Count > 0 Then
                    txt库存数量.Text = dtk.Rows(0)("库存数量").ToString

                Else
                    MsgBox("库存中不存在的产品，请核对标签！")
                   ClearFrom2()
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click
        If Utility.isNumer(txt出库数量) Then
            MsgBox("出库数量必须是数字")
            Exit Sub
        End If

        Dim m1 As New M产成品出入库记录
        m1.入出库记录CD = Utility.GetRoundID()
        m1.入出库区分 = Utility.出入库区分_出库
        m1.申请单编号 = txt出荷指示.Text.Trim
        m1.订单编号 = txt订单编号.Text.Trim
        m1.产品图号 = txt产品图号.Text.Trim

        m1.入出库重量 = "0"
        m1.入出库日期 = Utility.GetDateTime()
        m1.库存区域 = lbl库存区域.Text.Trim
        m1.操作者 = Utility.操作者编号
        m1.操作PDA = Utility.操作PDA_IP
        m1.备注 = txt备注.Text.Trim
        m1.库存状态 = Utility.库存状态_正常品


        If Convert.ToDecimal(txt出库数量.Text.Trim) > Convert.ToDecimal(txt库存数量.Text.Trim) Then
            m1.入出库数量 = txt库存数量.Text.Trim
        Else
            m1.入出库数量 = txt出库数量.Text.Trim
        End If



        Dim m2 As New M产成品库存
        m2.产品图号 = txt产品图号.Text.Trim
        m2.订单编号 = txt订单编号.Text.Trim
        m2.库存数量 = txt出库数量.Text.Trim
        m2.库存重量 = "0"
        m2.库存区域 = lbl库存区域.Text.Trim
        m2.入库日期 = Utility.GetDateTime()
        m2.库存状态 = Utility.库存状态_正常品

        If DALUtility.update产成品(m1, m2) Then
            MsgBox("保存成功！")
            ClearFrom2()
        End If
    End Sub
End Class