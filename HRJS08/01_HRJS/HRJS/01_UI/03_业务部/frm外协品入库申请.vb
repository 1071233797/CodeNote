Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant
Imports System.IO
Imports O2S.Components.PDFRender4NET

Public Class frm外协品入库申请#Region "常量定义"
    Private Enum ENU_GRID As Integer
        订单编号 = 0
        主图号 = 1
        上级图号 = 2
        分图号 = 3
        外协品名称 = 4
        加工工序 = 5
        入库数量 = 6
        单重 = 7
        备注 = 8
        图纸 = 9
        工序编号 = 10

    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mDtSearch As DataTable = Nothing
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Private mdsPicDataSet As DataTable
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Dim dt工序 As New DataTable
    Dim strPath As String = String.Empty
#End Region

#Region "Form Event"

    Private Sub frm外协品入库申请_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frm外协品入库申请_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID1) = Constant.ENU_SHOWMSG.showMsgYes Then

                e.Cancel = False
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frm外协品入库申请_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2编辑.Focus()
                    btnF2编辑_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                Case Keys.F4
                    btnF4删除.Focus()
                    btnF4删除_Click(Nothing, Nothing)

                Case Keys.F5
                    btnF5行追加.Focus()
                    btnF5行追加_Click(Nothing, Nothing)

                Case Keys.F6
                    btnF6行删除.Focus()
                    btnF6行删除_Click(Nothing, Nothing)

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

    Private Sub gridlist_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridList.InitializeLayout
        gridList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        gridList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

    End Sub

    Private Sub gridlist_ClickCellButton(ByVal sender As Object, ByVal e As CellEventArgs) Handles gridList.ClickCellButton

        Dim frmSearch外协 As frm外协加工一览
        Try

            If Me.gridList.ActiveCell Is Nothing Then
                Exit Sub
            End If

            If Me.gridList.ActiveRow.Cells(ENU_GRID.订单编号).Activation = Activation.NoEdit Then
                Exit Sub
            End If

            '砂時計のカーソルが設定
            Me.Cursor = Cursors.WaitCursor
            frmSearch外协 = New frm外协加工一览
            frmSearch外协.FormOpenMode = Constant.ENU_MODE.Model_Search
            frmSearch外协.intDoubleClick = 2
            frmSearch外协.ShowDialog()

            '画面数据设置
            If frmSearch外协.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch外协.ReturnTable Is Nothing AndAlso 0 < frmSearch外协.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    If gridList.DataSource.select("订单编号='" & frmSearch外协.ReturnTable.Rows(0)("订单编号") & "'").length > 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号")

                    Else
                        Me.gridList.ActiveRow.Cells(ENU_GRID.订单编号).Value = frmSearch外协.ReturnTable.Rows(0)("订单编号")     '部品番号
                        Me.gridList.ActiveRow.Cells(ENU_GRID.分图号).Value = frmSearch外协.ReturnTable.Rows(0)("产品图号")     '部品番号
                        SetData()
                        strPath = strServerPicturePath & mdsGridDataSet.Rows(0)("图纸")
                        If File.Exists(strPath) Then
                            If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                                SetPDFPictureBoxImage()
                            Else
                                SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mdsGridDataSet.Rows(0)("图纸"))
                            End If
                        Else
                            Me.pic图纸.Image = Nothing
                        End If
                    End If

                End If
                If Not frmSearch外协.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch外协.ReturnTable.Dispose()
                    frmSearch外协.ReturnTable = Nothing
                    frmSearch外协.ReturnTable = Nothing
                End If
                '检索画面释放
                frmSearch外协.Dispose()
                frmSearch外协 = Nothing
            End If

            gridList.UpdateData()

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
            '清空画面对话框            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()

            SetFormData()

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

            Me.Cursor = Cursors.WaitCursor

            ''画面の終了処理

            Me.Close()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm外协品入库申请一览        Try
            frmSearch = New frm外协品入库申请一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt申请单编号.Text = frmSearch.ReturnTable.Rows(0)("申请单编号").ToString
                    'Me.gridList.ActiveRow.Cells("分图号").Value = frmSearch.ReturnTable.Rows(0)("分图号").ToString
                    '设置画面数据
                    SetFormData()
                    If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
                        strPath = strServerPicturePath & mdsGridDataSet.Rows(0)("图纸")
                        If File.Exists(strPath) Then
                            If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                                SetPDFPictureBoxImage()
                            Else
                                SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mdsGridDataSet.Rows(0)("图纸"))
                            End If

                        Else
                            Me.pic图纸.Image = Nothing
                        End If
                    End If
                End If
                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放

                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing


                '画面の修正処理                mIntFormMode = Constant.ENU_MODE.Model_Update
                SetFormModel()

            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF3保存_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF3保存.Click

        Try

            '画面のCheck処理
            If Not InputCheck() Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID2) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            '保存処理
            SaveData()


            'mIntFormMode = Constant.ENU_MODE.Model_New
            'Me.SetFormModel()

            Me.txt申请单编号.Select()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objB外协品入库申请T As New B外协品入库申请T

        Dim objBll As New BLLM外协品入库申请T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If Me.txt申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt申请单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objB外协品入库申请T.申请单编号 = txt申请单编号.Text.Trim

            If objBll.Delete(objB外协品入库申请T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            SetFormData()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click
        Dim dr As DataRow
        Dim intRow As Integer
        Dim objBll As New BLLM外协品入库申请T

        If gridList.Rows.Count = 0 Then
            intRow = 0
        Else
            intRow = gridList.Rows.Count
        End If

        dr = mdsGridDataSet.NewRow()

        mdsGridDataSet.Rows.Add(dr)
        mdsGridDataSet.AcceptChanges()

        With gridList

            .ActiveRow = .Rows(intRow)
            .Rows(intRow).Cells(0).Activate()
            .UpdateData()
            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        End With
    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click

        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If gridList.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = gridList.ActiveRow.VisibleIndex

            intRowDelete = gridList.ActiveRow.Index

            gridList.Rows(intRowDelete).Delete(False)

            If gridList.Rows.VisibleRowCount = 0 Or gridList.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If gridList.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf gridList.Rows.VisibleRowCount = intRow Then
                    intRow = gridList.Rows.VisibleRowCount - 1
                End If

                gridList.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                gridList.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.gridList.UpdateData()
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

#Region "Control Event"
#Region "申请单编号"
    Private Sub txt申请单编号_Enter(ByVal sender As Object, ByVal e As EventArgs)

        Try

            Me.txt申请单编号.Tag = Me.txt申请单编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt申请单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)


        Dim frmSearch As frm外协加工一览
        Try

            frmSearch = New frm外协加工一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt申请单编号.Text = frmSearch.ReturnTable.Rows(0)("外协计划单号")     '外协计划单号

                    Me.txt申请单编号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")
                    SetData()
                    SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mDtSearch.Rows(0)("图纸"))
                    'LoadGetCom()
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
#Region "人员编号"
    Private Sub txt人员编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt人员编号.Enter

        Try

            Me.txt人员编号.Tag = Me.txt人员编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt人员编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt人员编号.EditorButtonClick


        Dim frmSearch As frm人员一览
        Try

            frmSearch = New frm人员一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt人员编号.Text = frmSearch.ReturnTable.Rows(0)("人员编号")     '客户编号

                    Me.txt人员名称.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '客户名称

                    Me.txt职务.Text = frmSearch.ReturnTable.Rows(0)("职务")     '客户名称

                    Me.txt部门.Text = frmSearch.ReturnTable.Rows(0)("部门名称")     '部门

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
    Private Sub txt人员编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt人员编号.Validating

        Dim objM人员T As M人员T
        Dim objBllM人员T As BLLM人员T

        Try

            If txt人员编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt人员编号.Text.Trim <> String.Empty Then

                If Me.txt人员编号.Tag = Me.txt人员编号.Text.Trim Then
                    Exit Sub
                End If

                objM人员T = New M人员T

                objM人员T.人员编号 = txt人员编号.Text.Trim

                objBllM人员T = New BLLM人员T

                objM人员T = objBllM人员T.LoadByPKey(objM人员T)

                If objM人员T.人员编号 <> "" Then

                    Me.txt人员名称.Text = objM人员T.人员名                    Me.txt职务.Text = objM人员T.职务
                    Me.txt部门.Text = objM人员T.部门
                Else
                    Me.txt人员编号.Text = String.Empty
                    Me.txt人员名称.Text = String.Empty
                    Me.txt职务.Text = String.Empty
                    Me.txt部门.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员名称")
                    Me.txt人员编号.Select()
                End If
            Else
                Me.txt人员编号.Text = String.Empty
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
    Private Sub InitForm()

        Try
            SetGridStyle()

            '画面の内容を清空処理
            Me.ClearForm()
            SetFormModel()

            '権限の処理            Me.SetPermission()

            SetFormData()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt申请单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrNew
                    txt申请单编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt申请单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    Me.txt人员编号.Focus()
                Case Else

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

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt申请单编号.Text = "WXRK" & Now.ToString("yyyyMMddhhmmss")
            Me.txt人员编号.Text = String.Empty
            Me.txt人员名称.Text = String.Empty
            Me.txt职务.Text = String.Empty
            Me.txt部门.Text = String.Empty
            Me.dt申请日期.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.pic图纸.Image = Nothing

            Me.txt人员编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SaveData"

    Private Sub SaveData()

        Try
            Dim objM外协品入库申请T As New B外协品入库申请T
            Dim objBll As New BLLM外协品入库申请T
            Dim arryList As New ArrayList

            If gridList.Rows.Count > 0 Then

                For i = 0 To gridList.Rows.Count - 1
                    objM外协品入库申请T = New B外协品入库申请T
                    objM外协品入库申请T.申请单编号 = Me.txt申请单编号.Text.Trim
                    objM外协品入库申请T.申请者编号 = Me.txt人员编号.Text.Trim
                    objM外协品入库申请T.申请日期1 = Me.dt申请日期.Text.Trim
                    objM外协品入库申请T.订单编号 = gridList.Rows(i).Cells(ENU_GRID.订单编号).Value.ToString()
                    objM外协品入库申请T.主图号 = gridList.Rows(i).Cells(ENU_GRID.主图号).Value.ToString()
                    objM外协品入库申请T.上级图号 = gridList.Rows(i).Cells(ENU_GRID.上级图号).Value.ToString()
                    objM外协品入库申请T.产品图号 = gridList.Rows(i).Cells(ENU_GRID.分图号).Value.ToString()
                    objM外协品入库申请T.外协加工工序编号 = gridList.Rows(i).Cells(ENU_GRID.工序编号).Value.ToString()
                    objM外协品入库申请T.入库数量 = gridList.Rows(i).Cells("入库数量（个）").Value.ToString()
                    objM外协品入库申请T.单重 = gridList.Rows(i).Cells(ENU_GRID.单重).Value.ToString()
                    objM外协品入库申请T.备注 = gridList.Rows(i).Cells(ENU_GRID.备注).Value.ToString()
                    arryList.Add(objM外协品入库申请T)

                Next

            End If


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM外协品入库申请T).申请单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "申请单编号")
                        Me.txt申请单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt申请单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objM外协品入库申请T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt申请单编号.Focus()
                        Exit Sub
                    End If

            End Select

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
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

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If
            Dim objZ外协品入库申请T As New B外协品入库申请T
            Dim objBll As New BLLM外协品入库申请T

            Dim dt As New DataTable
            '必須チェック(MsgID=21) 

            '申请单编号
            If Me.txt申请单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请单编号", "申请单编号")
                txt申请单编号.Focus()
                Return False
            End If

            '客户名
            If Me.txt人员编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "申请者编号", "申请者编号")
                txt人员编号.Focus()
                Return False
            End If
            '职务
            If Me.txt职务.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "职务", "职务")
                txt职务.Focus()
                Return False
            End If
            '部门
            If Me.txt部门.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "部门", "部门")
                txt部门.Focus()
                Return False
            End If
            If gridList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                Return False
            Else
                For i = 0 To gridList.Rows.Count - 1
                    objZ外协品入库申请T.产品图号 = gridList.Rows(i).Cells("分图号").Value.ToString()
                    objZ外协品入库申请T.主图号 = gridList.Rows(i).Cells("主图号").Value.ToString()
                    dt = objBll.Check主图分图(objZ外协品入库申请T)

                    If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                        MsgBox("产品图号：" & objZ外协品入库申请T.产品图号 & "不属于主图号：" & objZ外协品入库申请T.主图号)
                        Return False
                    End If
                Next
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

#Region "SetPermission"

    Private Sub SetPermission()
        Try
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            'Me.grid客户管理.Enabled = Utility.PFn_GetAuth(Me.grid客户管理.Tag)
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "SetFormData"

    Private Sub SetFormData()
        Dim objZ外协品入库申请T As New B外协品入库申请T
        Dim objBll As BLLM外协品入库申请T

        Try
            '获取数据
            objZ外协品入库申请T = New B外协品入库申请T
            objBll = New BLLM外协品入库申请T

            objZ外协品入库申请T.申请单编号 = txt申请单编号.Text.Trim

            If String.IsNullOrEmpty(objZ外协品入库申请T.申请单编号) Then
                objZ外协品入库申请T.申请单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objZ外协品入库申请T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                Me.txt申请单编号.Text = mdsInfoDataSet.Rows(0)("申请单编号").ToString()
                Me.txt人员编号.Text = mdsInfoDataSet.Rows(0)("申请者编号").ToString()
                Me.txt职务.Text = mdsInfoDataSet.Rows(0)("职务").ToString()
                Me.txt部门.Text = mdsInfoDataSet.Rows(0)("部门").ToString()
                Me.dt申请日期.Text = mdsInfoDataSet.Rows(0)("申请日期").ToString()
            Else
                'Me.txt申请单编号.Text = String.Empty
                Me.txt人员编号.Text = String.Empty
                Me.txt职务.Text = String.Empty
                Me.txt部门.Text = String.Empty
                Me.dt申请日期.Text = String.Empty
            End If
            objZ外协品入库申请T.申请单编号 = txt申请单编号.Text.Trim()
            mdsGridDataSet = objBll.SetData1(objZ外协品入库申请T)
            If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
                Me.pic图纸.Text = mdsGridDataSet.Rows(0)("图纸").ToString()
            End If
            gridList.DataSource = mdsGridDataSet


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

#Region "SetData"
    Private Sub SetData()
        Dim objM外协品入库申请T As New B外协品入库申请T
        Dim objBll As BLLM外协品入库申请T
        Dim vl As New Infragistics.Win.ValueList
        Dim intLoopi As Integer
        Try
            '获取数据
            objM外协品入库申请T = New B外协品入库申请T
            objBll = New BLLM外协品入库申请T

            objM外协品入库申请T.订单编号 = Me.gridList.ActiveRow.Cells("订单编号").Value
            objM外协品入库申请T.产品图号 = Me.gridList.ActiveRow.Cells("分图号").Value
            mdsGridDataSet = objBll.SetData(objM外协品入库申请T)

            'If gridList.Rows(0).Cells("订单编号").Value.ToString <> String.Empty Then

            '    mDtSearch = objBll.SetData(objM外协品入库申请T)

            '    If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then

            '        'Me.gridList.ActiveRow.Cells("主图号").Value = mDtSearch.Rows(0)("主图号")
            '        Me.gridList.ActiveRow.Cells("上级图号").Value = mDtSearch.Rows(0)("上级图号")
            '        Me.gridList.ActiveRow.Cells("外协品名称").Value = mDtSearch.Rows(0)("外协品名称")
            '        Me.gridList.ActiveRow.Cells("出库数量").Value = mDtSearch.Rows(0)("出库数量")
            '        Me.gridList.ActiveRow.Cells("外协工序").Value = mDtSearch.Rows(0)("外协工序")

            '    Else
            '        'Me.gridList.ActiveRow.Cells("主图号").Value = String.Empty
            '        Me.gridList.ActiveRow.Cells("上级图号").Value = String.Empty
            '        Me.gridList.ActiveRow.Cells("外协品名称").Value = String.Empty
            '        Me.gridList.ActiveRow.Cells("出库数量").Value = 0
            '        Me.gridList.ActiveRow.Cells("外协工序").Value = String.Empty
            '    End If
            'End If

            If txt申请单编号.Text.Trim <> String.Empty Then
                dt工序 = objBll.LoadGetCom(objM外协品入库申请T)
                For intLoopi = 0 To dt工序.Rows.Count - 1
                    vl.ValueListItems.Add(dt工序.Rows(intLoopi).Item(0), dt工序.Rows(intLoopi).Item(1))
                Next intLoopi

                gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.加工工序).Style = ColumnStyle.DropDownList
                gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.加工工序).ValueList = vl
                gridList.DisplayLayout.Bands(0).Columns(ENU_GRID.加工工序).ValueList.SelectedItemIndex = 0
                'gridList.
            End If
            Me.gridList.DataSource = mdsGridDataSet
            'フォーカスの設定処理
            Me.txt申请单编号.Focus()
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

            With gridList.DisplayLayout.Bands(0)


                .Columns("入库数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单重").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("加工工序").Style = ColumnStyle.DropDownList
                .Columns("图纸").Hidden = True
                .Columns("工序编号").Hidden = True

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

#Region "图片大小设定"
    Friend Sub SetPictureBoxImage(ByVal pb As PictureBox, ByVal sFileName As String)
        '定义一个Bitmap对象作为绘制的接受对象
        Dim bmp As New Bitmap(pb.Width, pb.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim img As Image = Image.FromFile(sFileName)
        Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
        '按比例缩放
        GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
        g.DrawImage(img, rectImage)

        pb.Image = bmp
    End Sub

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub

#End Region
    Public Sub SetPDFPictureBoxImage()
        Dim pageImage As Bitmap = ConvertPDF2Image(strPath)
        Dim bmp As New Bitmap(Me.pic图纸.Width, Me.pic图纸.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim img As Image = pageImage
        Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
        '按比例缩放
        GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
        g.DrawImage(img, rectImage)

        Me.pic图纸.Image = bmp

    End Sub

    Public Function ConvertPDF2Image(ByVal pdfInputPath As String) As Bitmap

        Dim pdfFile1 As PDFFile = PDFFile.Open(pdfInputPath)

        If Not File.Exists(pdfInputPath) Then
            Directory.CreateDirectory(pdfInputPath)
        End If

        Return pdfFile1.GetPageImage(0, 56)
        'pageImage.Save(imageOutputPath & imageName & "." & imageFormat.ToString(), imageFormat)


    End Function
#End Region
End Class