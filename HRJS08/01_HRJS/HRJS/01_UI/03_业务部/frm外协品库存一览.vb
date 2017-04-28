Imports Infragistics.Win.UltraWinGrid

Public Class frm外协品库存一览
#Region "変数定義"

    Private mDtSearch As DataTable = Nothing

    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As DataTable = Nothing                'grd详细
    Private mdt详细Band1 As DataTable = Nothing                'grd详细
    'Private mstr车型库存 As String = String.Empty

#End Region

#Region "Form Event"

    Private Sub frm原材料库存一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try
            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2查询.Focus()
                    btnF2查询_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3选择.Focus()
                    btnF3选择_Click(Nothing, Nothing)

                    'Case Keys.F10
                    '    btnF10原材料库存导出.Focus()
                    '    btnF10原材料库存导出_Click(Nothing, Nothing)

                    'Case Keys.F11
                    '    btnF11原材料库存导入.Focus()
                    '    btnF11原材料库存导入_Click(Nothing, Nothing)

                Case Keys.F12
                    btnF12关闭.Focus()
                    btnF12关闭_Click(Nothing, Nothing)
                    e.Handled = True

                Case Else

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try
    End Sub

    Private Sub frm原材料库存一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then
            If Me.FormOpenMode <> Constant.ENU_MODE.Model_NULL Then
                Exit Sub
            End If
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgYes Then

                e.Cancel = False
            Else
                e.Cancel = True
            End If
            'End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm原材料库存一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try

            '画面の初期化処理
            Me.InitForm()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Button Event"

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click
        Try
            '清空画面对话框
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If
            ClearForm()
            InitGrid()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click
        Try
            ReturnType = Constant.ENU_MSTSEARCH.SearchMCancel

            '画面を閉じる
            Me.Close()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2查询.Click
        Try

            '砂時計のカーソルが設定

            Me.Cursor = Cursors.WaitCursor

            '検索を実行

            Me.DataSearch()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF3选择_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3选择.Click
        Try
            '选择処理
            'Me.Selection()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


        Dim frmSearch As frm工艺卡信息一览
        Try

            frmSearch = New frm工艺卡信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放

                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick


        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放

                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick


        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")

                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放

                frmSearch.Dispose()
                frmSearch = Nothing

            End If

            '光标设置
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    ''' 
    Private Sub InitForm()

        Try
            'Grid初始化
            Me.InitGrid()

            'Utility.PFn_SetCombo(cob材料区分, "VM材料区分", 1)

            'Utility.PFn_SetCombo(cob材料类别, "VM材料类别", 1)

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理

            'Me.SetPermission()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try
            mdt详细Band0 = New DataTable

            mdt详细Band0.Columns.Add("选择")
            mdt详细Band0.Columns.Add("外协订单编号")
            mdt详细Band0.Columns.Add("客户名称")
            mdt详细Band0.Columns.Add("产品图号")
            mdt详细Band0.Columns.Add("产品名称")
            mdt详细Band0.Columns.Add("订单编号")
            mdt详细Band0.Columns.Add("外协工序")
            mdt详细Band0.Columns.Add("外协加工数量")
            mdt详细Band0.Columns.Add("入库日期")
            mdt详细Band0.Columns.Add("作成者")
            mdt详细Band0.Columns.Add("库存区域")
            mdt详细Band0.Columns.Add("出库去向")
            mdt详细Band0.Columns.Add("计划带料数")
            mdt详细Band0.Columns.Add("实际带料数")
            mdt详细Band0.Columns.Add("备注")


            grdList.DataSource = mdt详细Band0

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt产品图号.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt加工工序.Text = String.Empty
            txt出库方向.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            txt入库日期sta.Text = DateAdd("M", -1, Now)
            txt入库日期end.Text = Date.Now
            Me.txt产品图号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SetPermission"

    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btnF11出库单打印.Enabled = Utility.PFn_GetAuth(Me.btnF11出库单打印.Tag)
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try

            With grdList.DisplayLayout.Bands(0)

                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("入库日期").CellActivation = Activation.NoEdit
            End With

            'With grdList.DisplayLayout.Bands(1)

            '    .Columns("材料编号").Hidden = True
            '    .Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            '    .Columns("数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '    .Columns("重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '    .Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            '    .Columns("结算金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            'End With

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "InputCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck() As Boolean

        Try

            If Not String.IsNullOrEmpty(txt入库日期sta.Text.Trim) And Not String.IsNullOrEmpty(txt入库日期end.Text.Trim) Then
                If DateTime.Parse(txt入库日期sta.DateTime) > DateTime.Parse(txt入库日期end.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "入库日期", "入库日期")
                    txt入库日期sta.Focus()
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
            Return False
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Function

#End Region

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objB外协品库存T As B外协品库存T
        Dim objBLLM外协品库存T As New BLLM外协品库存T

        Try
            If Not InputCheck() Then
                Exit Sub
            End If
            objB外协品库存T = New B外协品库存T

            objB外协品库存T.订单编号 = Me.txt订单编号.Text.Trim
            objB外协品库存T.产品图号 = Me.txt产品图号.Text.Trim
            objB外协品库存T.外协工序 = Me.txt加工工序.Text.Trim
            objB外协品库存T.出库去向 = Me.txt出库方向.Text.Trim
            objB外协品库存T.客户编号 = Me.txt客户编号.Text.Trim

            If (Not Me.txt入库日期sta.Text.Trim = String.Empty) Then
                objB外协品库存T.入库日期From = txt入库日期sta.Text.Trim
            Else
                objB外协品库存T.入库日期From = Constant.CGSTRDATE_DEFAULT
            End If
            If (Not Me.txt入库日期end.Text.Trim = String.Empty) Then
                objB外协品库存T.入库日期To = Me.txt入库日期end.Text.Trim
            Else
                objB外协品库存T.入库日期To = Constant.CGSTRDATE_DEFAULT
            End If
            '查询の検索処理
            '查询の検索処理
            mDtSearch = objBLLM外协品库存T.LoadByWhere(objB外协品库存T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mDtSearch

                For i = 0 To grdList.Rows.Count - 1

                    If DateTime.Parse(grdList.Rows(i).Cells("入库日期").Value.ToString) <= DateTime.Now.AddDays(5) Then

                        grdList.Rows(i).Appearance.ForeColor = Color.Red
                    Else
                        grdList.Rows(i).Appearance.ForeColor = Color.Black
                    End If
                    grdList.UpdateData()
                Next
                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
                SetGridStyle()
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#End Region

End Class