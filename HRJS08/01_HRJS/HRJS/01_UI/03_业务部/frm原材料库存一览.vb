Imports HRJS.Constant
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class frm原材料库存一览
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

                Case Keys.F10
                    btnF10原材料库存导出.Focus()
                    btnF10原材料库存导出_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11原材料库存导入.Focus()
                    btnF11原材料库存导入_Click(Nothing, Nothing)

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

    Private Sub btnF10原材料库存导出_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF10原材料库存导出.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            ''订单导入
            ExportData()


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF11原材料库存导入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11原材料库存导入.Click

        Try

            Me.Cursor = Cursors.WaitCursor

            '原材料库存
            ExportData()

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

    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs)


        Try

            '选择処理
            Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    'Private Sub grdList_ClickCell(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.ClickCellEventArgs) Handles grdList.ClickCell
    '    If e.Cell.Equals(grdList.ActiveRow.Cells("选择")) Then
    '        Me.grdList.UpdateData()
    '    End If
    'End Sub
    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout

        Try
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

            grdList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            grdList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Try

            If e.KeyCode <> Keys.Enter Then
                Exit Sub
            End If

            Select Case FormOpenMode

                Case Constant.ENU_MODE.Model_Search
                    '选择処理
                    Me.Selection()
            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "Control Event"

#Region "供应商编号"

    Private Sub txt供应商编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt供应商编号.Enter

        Try

            Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt供应商编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt供应商编号.EditorButtonClick


        Dim frmSearch As frm供应商一览
        Try

            frmSearch = New frm供应商一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt供应商编号.Text = frmSearch.ReturnTable.Rows(0)("供应商编号")     '供应商编号

                    Me.txt供应商名称.Text = frmSearch.ReturnTable.Rows(0)("供应商名称")     '供应商名称


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


    Private Sub txt供应商编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt供应商编号.Validating

        Dim objM供应商T As M供应商T
        Dim dtM供应商T As DataTable
        Dim objBllM供应商T As BLLM供应商T

        Try

            If txt供应商编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txt供应商编号.Text.Trim <> String.Empty Then

                If Me.txt供应商编号.Tag = Me.txt供应商编号.Text.Trim Then
                    Exit Sub
                End If
                objM供应商T = New M供应商T

                objM供应商T.供应商编号 = txt供应商编号.Text.Trim

                objBllM供应商T = New BLLM供应商T

                dtM供应商T = objBllM供应商T.LoadByWhere(objM供应商T)

                If dtM供应商T.Rows.Count <> 0 Then

                    Me.txt供应商名称.Text = dtM供应商T.Rows(0).Item("供应商名称").ToString
                Else
                    Me.txt供应商名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "供应商名称")
                    Me.txt供应商编号.Select()
                End If
            Else
                Me.txt供应商名称.Text = String.Empty
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

#Region "原材料编号"

    Private Sub txt原材料编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt原材料编号.Enter

        Try

            Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt原材料编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt原材料编号.EditorButtonClick


        Dim frmSearch As frm原材料信息一览
        Try

            frmSearch = New frm原材料信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt原材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料编号")     '原材料编号

                    Me.txt原材料名称.Text = frmSearch.ReturnTable.Rows(0)("原材料名称")     '原材料名称


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


    Private Sub txt原材料编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt原材料编号.Validating

        Dim objM原材料T As M原材料信息T
        Dim dtM原材料T As DataTable
        Dim objBllM原材料T As BLLM原材料信息T

        Try

            If txt原材料编号.ReadOnly Then
                Exit Sub
            End If


            If Me.txt原材料编号.Text.Trim <> String.Empty Then

                If Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim Then
                    Exit Sub
                End If
                objM原材料T = New M原材料信息T

                objM原材料T.原材料编号 = txt原材料编号.Text.Trim

                objBllM原材料T = New BLLM原材料信息T

                dtM原材料T = objBllM原材料T.LoadByWhere(objM原材料T)

                If dtM原材料T.Rows.Count <> 0 Then

                    Me.txt原材料名称.Text = dtM原材料T.Rows(0).Item("原材料名称").ToString
                Else
                    Me.txt原材料名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "原材料名称")
                    Me.txt原材料编号.Select()
                End If
            Else
                Me.txt原材料名称.Text = String.Empty
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

            Utility.PFn_SetCombo(cob材料区分, "VM材料区分", 0)

            Utility.PFn_SetCombo(cob材料类别, "VM材料种类", 0)

            Utility.PFn_SetCombo(txt材质, "VM材质", 0)

            '画面の内容を清空処理
            Me.ClearForm()
            SetButtonStatus()
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

            mdt详细Band0.Columns.Add("选择")
            mdt详细Band0.Columns.Add("材料编号")
            mdt详细Band0.Columns.Add("材料名称")
            mdt详细Band0.Columns.Add("材料区分")
            mdt详细Band0.Columns.Add("材质")
            mdt详细Band0.Columns.Add("材料种类")
            mdt详细Band0.Columns.Add("数量（个）")
            mdt详细Band0.Columns.Add("重量（kg）")

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


            cob材料区分.Value = String.Empty
            cob材料类别.Value = String.Empty
            txt材质.Text = String.Empty
            txt原材料编号.Text = String.Empty
            txt原材料名称.Text = String.Empty
            txt供应商编号.Text = String.Empty
            txt供应商名称.Text = String.Empty
            'txt入库日期From.Text = DateAdd("M", -1, Now)
            'txt入库日期To.Text = DateTime.Now
            Me.txt原材料编号.Select()

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
            Me.btnF10原材料库存导出.Enabled = Utility.PFn_GetAuth(Me.btnF10原材料库存导出.Tag)
            Me.btnF11原材料库存导入.Enabled = Utility.PFn_GetAuth(Me.btnF11原材料库存导入.Tag)
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

            End With

            With grdList.DisplayLayout.Bands(1)

                .Columns("材料编号").Hidden = True
                .Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("结算金额").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With

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

            'If Not String.IsNullOrEmpty(txt入库日期From.Text.Trim) And Not String.IsNullOrEmpty(txt入库日期To.Text.Trim) Then
            '    If DateTime.Parse(txt入库日期From.DateTime) > DateTime.Parse(txt入库日期To.DateTime) Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "入库日期", "入库日期")
            '        txt入库日期From.Focus()
            '        Return False
            '    End If
            'End If
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
#Region "SetButtonStatus"
    Private Sub SetButtonStatus()
        Select Case FormOpenMode
            Case ENU_MODE.Model_NULL
                Me.btnF3选择.Visible = False
                Me.btnF11原材料库存导入.Visible = False
            Case Else
                Me.btnF3选择.Visible = True
        End Select
    End Sub
#End Region
#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BLLM原材料库存T
        Dim objCls As New M原材料库存T
        Try
            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID25)
                '処理終了
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            objCls.材料编号 = Me.grdList.ActiveRow.Cells("材料编号").Text.Trim

            'テーブルにデータを追加

            ReturnTable = objBll.LoadAll(objCls)
            'If Me.grdList.ActiveRow.HasParent Then
            '    MessageBox.Show("当前行为子行，第三列值：" & Me.grdList.ActiveRow.Cells(2).Text.Trim)
            'Else
            '    MessageBox.Show("当前行为父行，第三列值：" & Me.grdList.ActiveRow.Cells(2).Text.Trim)
            'End If

            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示

                'CommonMsg.ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID26)
                Exit Sub
            End If

            ReturnType = Constant.ENU_MSTSEARCH.SearchMOk

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

#Region "DataSearch"

    Private Sub DataSearch()

        Dim objM原材料库存T As M原材料库存T
        Dim objBllM原材料库存T As New BLLM原材料库存T

        Try
            If Not InputCheck() Then
                Exit Sub
            End If
            objM原材料库存T = New M原材料库存T

            objM原材料库存T.材料区分 = Me.cob材料区分.Value
            objM原材料库存T.材料类别 = Me.cob材料类别.Value
            objM原材料库存T.材料编号 = Me.txt原材料编号.Text.Trim
            objM原材料库存T.材质型号 = txt材质.Value
            objM原材料库存T.供应商编号 = Me.txt供应商编号.Text.Trim
            '查询の検索処理
            mds详细 = New DataSet

            'mdt详细Band0データを記録テーブル初期化
            Me.mdt详细Band0 = New DataTable
            mdt详细Band0 = objBllM原材料库存T.LoadLevel0(objM原材料库存T)

            'mdt详细Band1データを記録テーブル初期化

            Me.mdt详细Band1 = New DataTable
            mdt详细Band1 = objBllM原材料库存T.LoadLevel1(objM原材料库存T)

            ''------------------------------------------

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(1) As DataRelation

            mds详细 = New DataSet
            'DataSetの親子関係を設定
            mds详细.Relations.Clear()  '两者的关系清空

            '親、子のテーブルを追加
            mdt详细Band0.TableName = "详细Band0"
            mds详细.Tables.Add(mdt详细Band0)

            mdt详细Band1.TableName = "详细Band1"
            mds详细.Tables.Add(mdt详细Band1)

            ReDim parentCols(0) '声明数组
            ReDim childCols(0)

            parentCols(0) = mds详细.Tables(0).Columns("材料编号")
            childCols(0) = mds详细.Tables(1).Columns("材料编号")
            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mds详细.Relations.Add(drBand(0))

            If mds详细 Is Nothing OrElse mds详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grdList.DataSource = mds详细

                'フォーカスの設定処理
                Me.txt原材料编号.Focus()
            Else

                '検索データを表示する
                Me.grdList.DataSource = mds详细
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
#Region "ExportData"

    Private Sub ExportData()

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim str材料编号S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try
            If Me.grdList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If
            dt = grdList.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows

                If drr("选择") = True Then

                    If str材料编号S = String.Empty Then
                        str材料编号S = drr("材料编号")

                    Else
                        str材料编号S = str材料编号S & "','" & drr("材料编号")

                    End If
                Else
                    MsgBox("请选择一条数据！！！")
                    Exit Sub
                End If

            Next


            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "原材料库存一览") = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            '设置默认路径为当前应用程序根目录
            Me.FolderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory()

            '打开目录选择框
            dialogResult = Me.FolderBrowserDialog1.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            '返回选择路径
            fileFullName = Me.FolderBrowserDialog1.SelectedPath & "\原材料库存一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            Dim objBll As New BLLM原材料库存T
            Dim objM原材料库存T As New M原材料库存T


            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM原材料库存T.材料编号 = str材料编号S


            'テーブルにデータを追加
            ReturnTable = objBll.LoadRepot(objM原材料库存T)

            mDtSearch = ReturnTable

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "原材料库存一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "原材料库存一览数据导出")
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