Imports HRJS.Constant

Public Class frm外协品盘点管理#Region "常数定義"

    Public Enum ENU_GRID As Integer
        订单编号 = 0
        产品图号 = 1
        名称 = 2
        在库数量 = 3
        入库日期 = 4
        盘点数量 = 5
        差异数量 = 6
        差额调整数量 = 7
        调整后在库数量 = 8
        处理方式 = 9
    End Enum

#End Region

#Region "変数定義"

    Private mDtSearch As DataTable = Nothing
    Private mstr订单编号 As String = String.Empty
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New

    Public Property 订单编号() As String
        Get
            Return mstr订单编号

        End Get
        Set(ByVal Value As String)
            mstr订单编号 = Value
        End Set
    End Property

#End Region

#Region "Form Event"

    Private Sub frm外协品库存盘点_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm外协品库存盘点_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm外协品库存盘点_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F4
                    btnF4保存.Focus()
                    btnF4保存_Click(Nothing, Nothing)

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

#End Region
#Region "Control Event"

#Region "订单"
    Private Sub txt订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt订单编号.EditorButtonClick
        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString        '订单编号

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
#Region "产品图号"
    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt产品图号.EditorButtonClick
        Dim frmSearch As frm图纸信息一览
        Try

            frmSearch = New frm图纸信息一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString        '产品图号
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
#Region "客户"
    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号").ToString        '客户编号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString        '客户名称

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

                objM客户T = objBllM客户T.LoadByPKey(objM客户T)

                If objM客户T.客户编号 <> "" Then

                    Me.txt客户名称.Text = objM客户T.客户名称

                Else
                    Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    Me.txt客户编号.Select()
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
    Private Sub btnF4保存_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4保存.Click

        Try

            '画面のCheck処理
            'If Not InputCheck() Then
            '    Exit Sub
            'End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            '保存処理
            'SaveData()
            SaveData1()
            SaveData2()

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

            '关闭画面对话框

            'If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgNo Then
            '    '処理終了
            '    Exit Sub
            'End If

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

#End Region

#Region "Grid Event"
    Private Sub grid采购_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridlist.CellChange
        Try
            If gridlist.DataSource Is Nothing OrElse gridlist.Rows.Count = 0 Then
                Exit Sub
            End If
            gridlist.UpdateData()
            '调整数量
            If gridlist.ActiveCell.Band.Index = 0 Then
                If gridlist.ActiveCell.Column.Index = ENU_GRID.差额调整数量 Then
                    If Me.gridlist.ActiveRow.Cells("处理方式").Value = 1 Then
                        Me.gridlist.ActiveRow.Cells("调整后在库数量").Value = CInt(Me.gridlist.ActiveRow.Cells(ENU_GRID.盘点数量).Value) + CInt(Me.gridlist.ActiveRow.Cells(ENU_GRID.差额调整数量).Value)
                    Else
                        If Me.gridlist.ActiveRow.Cells("处理方式").Value = 2 Then
                            Me.gridlist.ActiveRow.Cells("调整后在库数量").Value = Me.gridlist.ActiveRow.Cells(ENU_GRID.盘点数量).Value - Me.gridlist.ActiveRow.Cells(ENU_GRID.差额调整数量).Value
                        End If
                    End If
                End If
            End If

            Me.gridlist.UpdateData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub gridlist_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridlist.InitializeLayout

        Try
            gridlist.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            gridlist.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
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
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            'Grid初始化
            SetButtonStatus()
            Me.InitGrid()

            '画面の内容を清空処理
            Me.ClearForm()
            Me.txt产品图号.Select()
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
#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt产品图号.Text = String.Empty
            txt订单编号.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            dmt入库日期sta.Text = DateAdd("M", -1, Now)
            dmt入库日期end.Text = Date.Now
            Me.txt产品图号.Focus()
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

            mDtSearch = New DataTable
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("主图号")
            mDtSearch.Columns.Add("上级图号")
            mDtSearch.Columns.Add("分图号")
            mDtSearch.Columns.Add("名称")
            mDtSearch.Columns.Add("加工工序")
            mDtSearch.Columns.Add("在库数量")
            mDtSearch.Columns.Add("入库日期")
            mDtSearch.Columns.Add("盘点数量")
            mDtSearch.Columns.Add("差异数量")
            mDtSearch.Columns.Add("差额调整数量")
            mDtSearch.Columns.Add("处理方式")
            mDtSearch.Columns.Add("调整后在库数量")

            gridlist.DataSource = mDtSearch

            'If Not Me.gridlist.DataSource Is Nothing OrElse Me.gridlist.Rows.Count > 0 Then
            '    Me.gridlist.DataSource.clear()
            'End If

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
            Me.btnF4保存.Enabled = Utility.PFn_GetAuth(Me.btnF4保存.Tag)

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        'Dim objBll As New BLLZ包装实际管理T
        'Dim objZ包装实际T As New Z包装实际管理T


        'Try
        '    '选择行が無い場合
        '    If Me.grid包装实际一览.ActiveRow Is Nothing Then
        '        'メッセージ表示
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
        '        '処理終了
        '        Exit Sub
        '    End If

        '    objZ包装实际T.订单编号 = Me.grid包装实际一览.ActiveRow.Cells("订单编号").Text.Trim
        '    'テーブルにデータを追加
        '    ReturnTable = objBll.LoadAll(objZ包装实际T)

        '    If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
        '        'メッセージ表示
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
        '        Exit Sub
        '    End If

        '    ReturnType = Constant.ENU_MSTSEARCH.SearchMOk

        '    '画面を閉じる
        '    Me.Close()
        'Catch ex As Exception
        '    '異常処理
        '    ExHelper.ProcessEx(ex)
        'Finally
        '    'デフォルトのカーソル
        '    Me.Cursor = Cursors.Default
        'End Try

    End Sub

#End Region
#Region "SetButtonStatus"
    Private Sub SetButtonStatus()
        Select Case FormOpenMode
            Case ENU_MODE.Model_NULL
                Me.btnF3选择.Visible = False
            Case Else
                Me.btnF3选择.Visible = True
        End Select
    End Sub
#End Region
#Region "DataSearch"

    Private Sub DataSearch()

        Dim objZ外协品盘点T As B外协品库存盘点T

        Dim objBllZ外协品盘点T As New BLLB外协品库存盘点T

        Try
            objZ外协品盘点T = New B外协品库存盘点T

            objZ外协品盘点T.主图号 = Me.txt产品图号.Text.Trim
            objZ外协品盘点T.订单编号 = Me.txt订单编号.Text.Trim
            objZ外协品盘点T.客户编号 = Me.txt客户编号.Text.Trim
            If (Not Me.dmt入库日期sta.Text.Trim = String.Empty) Then
                objZ外协品盘点T.入库日期1 = Me.dmt入库日期sta.Text.Trim
            Else
                objZ外协品盘点T.入库日期1 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.dmt入库日期end.Text.Trim = String.Empty) Then
                objZ外协品盘点T.入库日期2 = Me.dmt入库日期end.Text.Trim
            Else
                objZ外协品盘点T.入库日期2 = Constant.CGSTRDATE_DEFAULT
            End If
            '查询の検索処理

            mDtSearch = objBllZ外协品盘点T.LoadLevel(objZ外协品盘点T)

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.gridlist.DataSource = mDtSearch
                gridlist.DisplayLayout.Bands(0).Columns("工序编号").Hidden = True
                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else

                '検索データを表示する
                Me.gridlist.DataSource = mDtSearch

                Me.gridlist.Focus()
                Me.gridlist.ActiveRow = Me.gridlist.Rows(0)
                gridlist.DisplayLayout.Bands(0).Columns("工序编号").Hidden = True
            End If

            ''****************************************************
            ''查询の検索処理:件数
            'Dim dtCOUNT As New DataTable

            'dtCOUNT = objBllM部门T.GetGridData(objM部门T, True)

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
#Region "SaveData1"

    Private Sub SaveData1()

        Dim objBll As BLLB外协品库存盘点T

        Try

            Dim intLoopi As Integer
            Dim arrayList As New ArrayList

            For intLoopi = 0 To gridlist.Rows.Count - 1
                'If gridlist.Rows(intLoopi).Cells(ENU_GRID.选择).Value = 0 Then
                '    Continue For
                'End If


                If gridlist.Rows(intLoopi).Cells(ENU_GRID.差额调整数量).Value = 0 Then
                    Continue For
                End If
                Dim objModel As New B外协品库存盘点T
                objModel.主图号 = gridlist.Rows(intLoopi).Cells("主图号").Value
                objModel.上级图号 = gridlist.Rows(intLoopi).Cells("上级图号").Value
                objModel.分图号 = gridlist.Rows(intLoopi).Cells("分图号").Value
                objModel.工序编号 = gridlist.Rows(intLoopi).Cells("工序编号").Value
                objModel.订单编号 = gridlist.Rows(intLoopi).Cells("订单编号").Value
                objModel.调整后在库数量 = gridlist.Rows(intLoopi).Cells(ENU_GRID.调整后在库数量).Value
                arrayList.Add(objModel)
            Next



            objBll = New BLLB外协品库存盘点T

            If objBll.Update库存调整(arrayList) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                '显示当前盘点数据
                Me.DataSearch()
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                Me.gridlist.Select()
                Exit Sub
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
#Region "SaveData2"

    Private Sub SaveData2()

        Dim objBll As BLLB外协品库存盘点T

        Try

            Dim intLoopi As Integer
            Dim arrayList As New ArrayList

            For intLoopi = 0 To gridlist.Rows.Count - 1

                'If gridlist.Rows(intLoopi).Cells(ENU_GRID.差额调整数量).Value = 0 Then
                '    Continue For
                'End If
                Dim objModel As New B外协品库存盘点T
                objModel.主图号 = gridlist.Rows(intLoopi).Cells("主图号").Value
                objModel.分图号 = gridlist.Rows(intLoopi).Cells("分图号").Value
                objModel.上级图号 = gridlist.Rows(intLoopi).Cells("上级图号").Value
                objModel.订单编号 = gridlist.Rows(intLoopi).Cells("订单编号").Value
                objModel.加工工序 = gridlist.Rows(intLoopi).Cells("加工工序").Value
                objModel.在库数量 = gridlist.Rows(intLoopi).Cells("在库数量").Value
                objModel.入库日期 = gridlist.Rows(intLoopi).Cells("入库日期").Value
                objModel.盘点数量 = gridlist.Rows(intLoopi).Cells("盘点数量").Value
                objModel.差异数量 = gridlist.Rows(intLoopi).Cells("差异数量").Value
                'objModel.调整数量 = gridlist.Rows(intLoopi).Cells("调整数量").Value
                objModel.调整后在库数量 = gridlist.Rows(intLoopi).Cells("调整后在库数量").Value
                'objModel.在库状态 = gridlist.Rows(intLoopi).Cells("在库状态").Value
                objModel.处理方式 = gridlist.Rows(intLoopi).Cells("处理方式").Value
                arrayList.Add(objModel)
            Next


            objBll = New BLLB外协品库存盘点T

            If objBll.Insert(arrayList) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                '显示当前盘点数据
                Me.DataSearch()
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                Me.gridlist.Select()
                Exit Sub
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