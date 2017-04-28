Imports System.Data

Public Class F半成品盘点

    Private Sub ClearForm()

        txt订单编号.Text = String.Empty
        txt主图号.Text = String.Empty
        txt主图名称.Text = String.Empty
        txt分图号.Text = String.Empty
        txt分图名称.Text = String.Empty
        txt工序编号.Text = String.Empty
        txt工序名称.Text = String.Empty
        txt在库数量.Text = String.Empty
        txt盘点数量.Text = String.Empty
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

    Private Sub F半成品盘点_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub F半成品盘点_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub


    Private Sub txt订单编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt订单编号.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then


                Dim value() As String = txt订单编号.Text.Trim.Split("|")

                txt订单编号.Text = value(0)
                txt主图号.Text = value(1)
                txt主图名称.Text = DALUtility.select图名(value(1))
                txt分图号.Text = value(3)
                txt分图名称.Text = DALUtility.select图名(value(3))
                txt工序编号.Text = value(4)
                txt工序名称.Text = DALUtility.select工序名称(value(3), value(4))


                lbl上级图号.Text = value(2)

                Dim m2 As New M半成品库存
                m2.订单编号 = value(0)
                m2.主图号 = value(1)
                m2.上级图号 = value(2)
                m2.分图号 = value(3)
                m2.工序编号 = value(4)

                Dim dtk As DataTable = DALUtility.select半成品库存(m2)

                '判断库存材料
                If dtk.Rows.Count > 0 Then
                    txt在库数量.Text = dtk.Rows(0)("库存数量").ToString
                    txt盘点数量.Text = dtk.Rows(0)("库存数量").ToString

                    Me.txt订单编号.ReadOnly = True
                    txt盘点数量.SelectAll()
                    btn保存.Enabled = True
                Else
                    MsgBox("库存中不存在的材料编号，请核对标签！")
                    ClearForm()
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
            Exit Sub
        End If


        Dim m1 As New M半成品盘点
        m1.盘点CD = Utility.GetRoundID()
        m1.订单编号 = txt订单编号.Text.Trim
        m1.主图号 = txt主图号.Text.Trim
        m1.上级图号 = lbl上级图号.Text.Trim
        m1.分图号 = txt分图号.Text.Trim
        m1.工序编号 = txt工序编号.Text.Trim

        m1.盘点日期 = Utility.GetDateTime()
        m1.盘点人编号 = Utility.操作者编号
        m1.盘点数量 = txt盘点数量.Text.Trim
        m1.在库数量 = txt在库数量.Text.Trim


       


        If DALUtility.insert半成品(m1) Then
            MsgBox("保存成功！")
            ClearForm()
        End If
    End Sub
End Class