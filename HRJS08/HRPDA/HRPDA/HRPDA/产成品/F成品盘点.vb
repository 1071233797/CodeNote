Imports System.Data

Public Class F成品盘点

    Private Sub ClearFrom()
        txt订单编号.Text = String.Empty
        txt产品图号.Text = String.Empty
        txt产品图名.Text = String.Empty

        txt库存数量.Text = String.Empty
        txt盘点数量.Text = String.Empty
        txt订单编号.ReadOnly = False
        btn保存.Enabled = False
        txt订单编号.Focus()
    End Sub

    Private Sub F成品盘点_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFrom()
    End Sub

    Private Sub F成品盘点_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub



    Private Sub txt订单编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt订单编号.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then


                Dim value() As String = txt订单编号.Text.Trim.Split("|")

                txt订单编号.Text = value(0)
                txt产品图号.Text = value(1)
                txt产品图名.Text = DALUtility.select图名(value(1))


                Dim m2 As New M产成品库存
                m2.订单编号 = value(0)
                m2.产品图号 = value(1)

                Dim dtk As DataTable = DALUtility.select产成品库存(m2)

                '判断库存材料
                If dtk.Rows.Count > 0 Then
                    txt库存数量.Text = dtk.Rows(0)("库存数量").ToString
                    txt盘点数量.Text = dtk.Rows(0)("库存数量").ToString

                    Me.txt订单编号.ReadOnly = True
                    txt盘点数量.SelectAll()
                    btn保存.Enabled = True
                Else
                    MsgBox("库存中不存在的产品，请核对标签！")
                    ClearFrom()
                    Exit Sub
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click
        If Utility.isNumer(txt盘点数量) Then
            MsgBox("盘点数量必须是数字")
            txt盘点数量.Text = String.Empty
            txt盘点数量.Focus()
            Exit Sub
        End If


        Dim m1 As New M产成品盘点
        m1.盘点CD = Utility.GetRoundID()
        m1.订单编号 = txt订单编号.Text.Trim
        m1.产品图号 = txt产品图号.Text.Trim
        m1.盘点人编号 = Utility.操作者编号
        m1.盘点日期 = Utility.GetDateTime()

        m1.盘点数量 = txt盘点数量.Text.Trim
        m1.在库数量 = txt库存数量.Text.Trim

        If DALUtility.insert产成品(m1) Then
            MsgBox("保存成功！")
            ClearFrom()
        End If
    End Sub
End Class