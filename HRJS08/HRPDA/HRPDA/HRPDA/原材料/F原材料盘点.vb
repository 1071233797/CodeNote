Imports System.Data

Public Class F原材料盘点


    Private Sub ClearFrom()
        txt材料编号.Text = String.Empty
        txt批次.Text = String.Empty
        txt材料名称.Text = String.Empty
        txt在库数量.Text = String.Empty
        txt在库重量.Text = String.Empty
        txt盘点数量.Text = String.Empty
        txt盘点重量.Text = String.Empty
        txt备注.Text = String.Empty
        Me.txt材料编号.ReadOnly = False
        btn保存.Enabled = False
        txt材料编号.Focus()
    End Sub

    Private Sub btn关闭_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn关闭.Click
        Me.Close()
    End Sub
    Private Sub F原材料盘点_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFrom()
    End Sub

    Private Sub F原材料盘点_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized '最大化
    End Sub
    Private Sub txt材料编号_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt材料编号.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then


                Dim value() As String = txt材料编号.Text.Trim.Split("|")

                txt材料编号.Text = value(0)
                txt批次.Text = value(1)
                txt材料名称.Text = DALUtility.select原材料名称(value(0))

                Dim m2 As New M原材料库存
                m2.材料编号 = txt材料编号.Text.Trim
                m2.批次号 = txt批次.Text.Trim

                Dim dtk As DataTable = DALUtility.select原材料库存(m2)

                '判断库存材料
                If dtk.Rows.Count > 0 Then
                    txt在库数量.Text = dtk.Rows(0)("库存数量").ToString
                    txt在库重量.Text = dtk.Rows(0)("库存重量").ToString
                    txt盘点数量.Text = dtk.Rows(0)("库存数量").ToString
                    txt盘点重量.Text = dtk.Rows(0)("库存重量").ToString
                    Me.txt材料编号.ReadOnly = True
                    txt备注.Focus()
                    btn保存.Enabled = True
                Else
                    MsgBox("库存中不存在的材料编号，请核对标签！")
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

        If Utility.isNumer(txt盘点重量) Then
            txt盘点重量.Text = String.Empty
            txt盘点重量.Focus()
            MsgBox("盘点重量必须是数字")
            Exit Sub
        End If

        Dim m1 As New M原材料盘点
        m1.盘点CD = Utility.GetRoundID()
        m1.材料编号 = txt材料编号.Text.Trim
        m1.批次号 = txt批次.Text.Trim
        m1.在库数量 = txt在库数量.Text.Trim
        m1.在库重量 = txt在库重量.Text.Trim
        m1.盘点数量 = txt盘点数量.Text.Trim
        m1.盘点重量 = txt盘点重量.Text.Trim
        m1.盘点人编号 = Utility.操作者编号
        m1.操作PDA = Utility.操作PDA_IP
        m1.盘点日期 = Utility.GetDateTime()
        m1.备注 = txt备注.Text.Trim


        If DALUtility.insert原材料(m1) Then
            MsgBox("保存成功！")
            ClearFrom()
        End If
    End Sub


    Private Sub txt盘点数量_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt盘点数量.GotFocus
        txt盘点数量.SelectAll()
    End Sub

    Private Sub txt盘点重量_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt盘点重量.GotFocus
        txt盘点重量.SelectAll()
    End Sub

    Private Sub btn清空_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn清空.Click
        ClearFrom()
    End Sub
End Class