Public Class frm返品一览
#Region "変数定義"

    Private mDtSearch As DataTable = Nothing

    Private mds详细 As DataSet = Nothing                'grd详细
    Private mdt详细Band0 As DataTable = Nothing                'grd详细
    Private mdt详细Band1 As DataTable = Nothing                'grd详细
    'Private mstr车型库存 As String = String.Empty

#End Region

#Region "Form Event"

    Private Sub frm外协品入库申请一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F12
                    btnF12关闭.Focus()
                    btnF12关闭_Click(Nothing, Nothing)
                    e.Handled = True

                Case Else

            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub frm返品一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm返品一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
#Region "Control Event"

#Region "产品图号"

    Private Sub txt产品图号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt产品图号.Enter

        Try

            Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick


        Dim frmSearch As frm图纸信息一览
        Try
            frmSearch = New frm图纸信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '    '根据检索画面数据进行设置

                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '客户编号

                    Me.txt产品名称.Text = frmSearch.ReturnTable.Rows(0)("品名")     '部品名称

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

    Private Sub txt产品图号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt产品图号.Validating

        Dim objM产品T As M图纸T
        Dim dtM客户T As DataTable
        Dim objBLLM产品T As BLLM图纸T
        Try

            If txt产品图号.ReadOnly Then
                Exit Sub
            End If
            If Me.txt产品图号.Text.Trim <> String.Empty Then
                If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
                    Exit Sub
                End If
            End If


            If Me.txt产品图号.Text.Trim <> String.Empty Then

                objM产品T = New M图纸T

                objM产品T.产品图号 = txt产品图号.Text.Trim

                objBLLM产品T = New BLLM图纸T

                objM产品T = objBLLM产品T.LoadByPKey(objM产品T)

                If objM产品T.产品图号 <> "" Then

                    Me.txt产品名称.Text = objM产品T.品名
                Else
                    Me.txt产品名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部品名称")
                    'Me.txt产品图号.Select()
                End If
            Else
                Me.txt产品图号.Text = String.Empty
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

#Region "客户编号"

    Private Sub txt客户编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt客户编号.Enter

        Try

            Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
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

                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称


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


    Private Sub txt客户编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating

        Dim objM客户T As M客户T
        Dim dtM客户T As DataTable
        Dim objBllM客户T As BLLM客户T

        Try

            If txt客户编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txt客户编号.Text.Trim <> String.Empty Then

                If Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim Then
                    Exit Sub
                End If
                objM客户T = New M客户T

                objM客户T.客户编号 = txt客户编号.Text.Trim

                objBllM客户T = New BLLM客户T

                dtM客户T = objBllM客户T.LoadByWhere(objM客户T)

                If dtM客户T.Rows.Count <> 0 Then

                    Me.txt客户名称.Text = dtM客户T.Rows(0).Item("客户名称").ToString
                Else
                    Me.txt客户名称.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
                    'Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户名称.Text = String.Empty
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

#Region "订单编号"

    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick

        Dim frmSearch订单 As frm订单一览
        Try
            frmSearch订单 = New frm订单一览
            frmSearch订单.FormOpenMode = Constant.ENU_MODE.Model_Ref
            frmSearch订单.ShowDialog()

            '画面数据设置
            If frmSearch订单.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch订单.ReturnTable Is Nothing AndAlso 0 < frmSearch订单.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch订单.ReturnTable.Rows(0)("订单编号")     '部品番号

                End If
            End If
        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '默认光标设置
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#End Region

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


            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

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


            mdt详细Band0.Columns.Add("订单编号")
            mdt详细Band0.Columns.Add("产品图号")
            mdt详细Band0.Columns.Add("产品名称")
            mdt详细Band0.Columns.Add("客户名称")
            mdt详细Band0.Columns.Add("生产日期")
            mdt详细Band0.Columns.Add("返品数量")
            mdt详细Band0.Columns.Add("库存状态")


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
            txt产品名.Text = String.Empty

            txt客户编号.Text = String.Empty
            txt客户名.Text = String.Empty
            txt订单编号.Text = String.Empty
            date开始日期.Text = DateAdd("M", -1, Now)
            date结束日期.Text = Date.Now
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

#Region "DataSearch"

    Private Sub DataSearch()
        Dim objBllM返品一览T As New BLLM返品一览T
        Dim objM返品一览T As New B返品一览T

        Try
        

            objM返品一览T.产品图号 = Me.txt产品图号.Text.Trim
            objM返品一览T.订单编号 = Me.txt订单编号.Text.Trim
            objM返品一览T.客户编号 = Me.txt客户编号.Text.Trim
            objM返品一览T.开始日期 = date开始日期.Text.Trim
            objM返品一览T.结束日期 = date结束日期.Text.Trim

            '查询の検索処理
            mDtSearch = objBllM返品一览T.LoadByWhere(objM返品一览T)

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

                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部品T.GetGridData(objM部品T, True)

            'Me.grdList.PSummaryFooterCaption(dtCOUNT.Rows.Count)
            ''****************************************************

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
    ''' <summary>
    ''' 権限の制御処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
          
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