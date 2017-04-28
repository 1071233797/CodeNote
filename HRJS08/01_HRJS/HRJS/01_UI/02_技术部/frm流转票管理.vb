Imports HRJS.Constant
Imports System.IO
Imports O2S.Components.PDFRender4NET

Public Class frm流转票管理
#Region "変数定義"
    Private mDtSearch As DataTable = Nothing
    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    'Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Dim strServerPicturePath1 As String = System.Configuration.ConfigurationManager.AppSettings.Get("CirculationPath")
    Dim strPath As String
    Dim strPathFlg As Boolean = False
    'Dim str产品图号 As String = String.Empty
#End Region
#Region "Form Event"
    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
    Private Sub frm流转票管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then

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
    Private Sub frm流转票管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                Case Keys.F10
                    btnF10.Focus()
                    'btnF10_Click(Nothing, Nothing)
                    e.Handled = True

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
#Region "Button Event"
    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click
        Try
            '清空画面对话框

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
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
    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click
        Dim frmSearch As frm流转票一览
        Try
            frmSearch = New frm流转票一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString
                    Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString
                    Me.ckb试做品.Checked = frmSearch.ReturnTable.Rows(0)("试做品").ToString
                    Call txt产品图号_Leave(Nothing, Nothing)
                    SetFormData()
                   
                End If
                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If
                '检索画面释放
                frmSearch.Dispose()
                frmSearch = Nothing
                '画面の修正処理
                mIntFormMode = Constant.ENU_MODE.Model_Update
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
            Call savePictureServerQuanXian()
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

            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Me.txt产品图号.Select()
            Else
                Me.grid流转票.Select()
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM流转票管理T As New M流转票管理T

        Dim objBll As New BllM流转票管理T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If

            '保存確認メッセージを表示する
            'If Me.grid流转票.ActiveRow Is Nothing Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '    Return
            'End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM流转票管理T.产品图号 = Me.txt产品图号.Text
            'objM流转票管理T.工序名称 = Me.grid流转票.ActiveRow.Cells("工序名称").Value

            If objBll.Delete(objM流转票管理T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt产品图号.Focus()
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click

        Try

            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                txt产品图号.Focus()
                Exit Sub
            End If

            Dim dr As DataRow
            Dim intRow As Integer

            If Me.grid流转票.Rows.Count = 0 Then
                intRow = 0
            Else

                If Me.grid流转票.ActiveRow Is Nothing Then
                    intRow = Me.grid流转票.Rows.Count - 1
                Else
                    intRow = Me.grid流转票.ActiveRow.Index + 1
                End If
            End If

            If mDtSearch Is Nothing Then
                Exit Sub
            End If

            'Dim dt检查数据 As DataTable
            'Dim intCloumns As Integer

            mDtSearch = mDtSearch
            dr = mDtSearch.NewRow()
            dr("外协加工") = False
            dr("组装品") = False

            'If intRow <> 0 Then
            '    For intCloumns = 0 To dt检查数据.Columns.Count - 5

            '        dr(intCloumns) = dt检查数据.Rows(intRow - 1)(intCloumns)
            '    Next
            'End If

            If intRow = 0 Then
                mDtSearch.Rows.Add(dr)
            Else
                mDtSearch.Rows.InsertAt(dr, intRow)
            End If

            Me.grid流转票.DataSource = Nothing
            Me.grid流转票.DataSource = mDtSearch
           
            SetGridStyle()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grid流转票_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid流转票.ClickCellButton
        Dim frmSearch As frm生产设备一览

        Try

            frmSearch = New frm生产设备一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '设备查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.grid流转票.ActiveRow.Cells("设备编号").Value = frmSearch.ReturnTable.Rows(0)("设备编号")          '设备编号
                    Me.grid流转票.ActiveRow.Cells("设备名称").Value = frmSearch.ReturnTable.Rows(0)("设备名称")

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
    Private Sub grid流转票_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid流转票.InitializeLayout
        grid流转票.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid流转票.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub
    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click
        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid流转票.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」

            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = Me.grid流转票.ActiveRow.VisibleIndex

            intRowDelete = Me.grid流转票.ActiveRow.Index

            'Me.grid流转票.Rows(intRowDelete).Delete(False)
            mDtSearch.Rows.RemoveAt(intRowDelete)
            If Me.grid流转票.Rows.VisibleRowCount = 0 Or Me.grid流转票.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid流转票.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid流转票.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid流转票.Rows.VisibleRowCount - 1
                End If

                Me.grid流转票.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid流转票.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid流转票.UpdateData()
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub txt产品图号_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txt产品图号.Leave
        Dim objM图纸T As M图纸T
        Dim objBLLM图纸T As BLLM图纸T

        Try

            'If txt产品图号.ReadOnly Then
            '    Exit Sub
            'End If

            If Me.txt产品图号.Text.Trim <> String.Empty Then

                If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
                    Exit Sub
                End If

                objM图纸T = New M图纸T

                objM图纸T.产品图号 = txt产品图号.Text.Trim

                objBLLM图纸T = New BLLM图纸T

                objM图纸T = objBLLM图纸T.LoadByPKey(objM图纸T)

                If objM图纸T.产品图号 <> String.Empty Then
                    Me.txt品名.Text = objM图纸T.品名
                    SetData()
                    Me.txt备注.Select()
                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "图纸名称")
                    Me.txt产品图号.Text = String.Empty
                    Me.txt品名.Text = String.Empty
                    'Me.btnF5行追加.Select()
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

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click
        Me.Cursor = Cursors.WaitCursor
        ''画面の終了処理
        Me.Close()
    End Sub
#End Region
#Region "control event"
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

                    '根据检索画面数据进行设置                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号

                    Me.txt品名.Text = frmSearch.ReturnTable.Rows(0)("品名")          '产品图号

                    If File.Exists(strServerPicturePath & frmSearch.ReturnTable.Rows(0)("图纸")) Then
                        strPath = strServerPicturePath & frmSearch.ReturnTable.Rows(0)("图纸")
                        If frmSearch.ReturnTable.Rows(0)("图纸").ToUpper.Contains(".PDF") Then
                            SetPDFPictureBoxImage()
                        Else
                            SetPictureBoxImage(Me.pic图纸, strServerPicturePath & frmSearch.ReturnTable.Rows(0)("图纸"))
                        End If
                    Else
                        Me.pic图纸.Image = Nothing
                    End If
                    '检查产品图号如果已经录入，带回数据
                    SetData()
                    Me.txt备注.Select()
                End If

            End If
            If Not frmSearch.ReturnTable Is Nothing Then
                '检索画面释放
                frmSearch.ReturnTable.Dispose()
                frmSearch.ReturnTable = Nothing
            End If
            '检索画面释放
            frmSearch.Dispose()
            frmSearch = Nothing
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
            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                txt产品图号.Focus()
                Return False
            End If

            If mDtSearch.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸编号", "图纸编号")
                Me.txt产品图号.Focus()
                Return False
            Else
                For Each dr As DataRow In mDtSearch.Rows
                    '必須チェック(MsgID=21) 
                    If dr("工序名称") & "" = String.Empty Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工序名称", "工序名称")
                        grid流转票.Focus()
                        Return False
                    End If
                    '订单ID
                    If dr("作业场所") & "" = String.Empty Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "作业场所", "作业场所")
                        grid流转票.Focus()
                        Return False
                    End If

                    'If dr("设备编号") & "" = String.Empty Then
                    '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "设备编号", "设备编号")
                    '    grid流转票.Focus()
                    '    Return False
                    'End If
                    'If dr("加工内容简介") & "" = String.Empty Then
                    '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "加工内容简介", "加工内容简介")
                    '    grid流转票.Focus()
                    '    Return False
                    'End If
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
#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する

            '画面の内容を清空処理


            SetFormData()
            Me.ClearForm()
            SetGridStyle()
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
#Region "'SetPermission"
    ''' <summary>
    ''' 権限の制御処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            'Me.btnF1清空.Enabled = Utility.PFn_GetAuth(Me.btnF1清空.Tag)
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            Me.btnF5行追加.Enabled = Utility.PFn_GetAuth(Me.btnF5行追加.Tag)
            Me.btnF6行删除.Enabled = Utility.PFn_GetAuth(Me.btnF6行删除.Tag)
            Me.btnF11.Enabled = Utility.PFn_GetAuth(Me.btnF11.Tag)

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
            Me.txt产品图号.Text = String.Empty

            Me.txt品名.Text = String.Empty
            Me.txt备注.Text = String.Empty
            Me.ckb试做品.Checked = False
            Me.pic图纸.Image = Nothing
            mDtSearch.Clear()
            grid流转票.DataSource = mDtSearch
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
#Region "SetFormModel"

    Private Sub SetFormModel()

        Try


            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt产品图号.ReadOnly = False
                    'txt工序名称.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    'txt产品图号.Select()

                Case Constant.ENU_MODE.Model_Update

                    txt产品图号.ReadOnly = True
                    'txt工序名称.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    'Me.grid流转票.Select()
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
#Region "SaveData"
    ''' <summary>
    ''' 画面の保存処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try
            Dim objM流转票T As New M流转票管理T
            Dim objBll As New BllM流转票管理T
            Dim arryList As New ArrayList
            For i = 0 To grid流转票.Rows.Count - 1
                objM流转票T = New M流转票管理T
                objM流转票T.产品图号 = Me.txt产品图号.Text
                objM流转票T.备注 = Me.txt备注.Text
                objM流转票T.是否为试做品 = Me.ckb试做品.Checked

                objM流转票T.是否为外协加工工序 = Utility.PFn_ToBoolean(grid流转票.Rows(i).Cells("外协加工").Text)
                objM流转票T.是否为组装品 = Utility.PFn_ToBoolean(grid流转票.Rows(i).Cells("组装品").Text)

                objM流转票T.工序编号 = i + 1
                objM流转票T.工序名称 = grid流转票.Rows(i).Cells("工序名称").Value
                objM流转票T.加工内容简介 = grid流转票.Rows(i).Cells("加工内容简介").Value.ToString()
                objM流转票T.作业场所 = grid流转票.Rows(i).Cells("作业场所").Value.ToString()
                objM流转票T.设备编号 = grid流转票.Rows(i).Cells("设备编号").Value.ToString()
                objM流转票T.图纸图片 = Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4)
                objM流转票T.登陆者 = gObjM_人员T.人员编号
                objM流转票T.登陆日期 = DateTime.Now
                objM流转票T.更新者 = gObjM_人员T.人员编号

                objM流转票T.更新日期 = DateTime.Now
                arryList.Add(objM流转票T)
            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM流转票T).产品图号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")
                        txt产品图号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then
                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        If File.Exists(strPath) Then
                            File.Copy(strPath, strServerPicturePath1 & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                        End If
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt产品图号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    'If objBll.Update(objM流转票T) > 0 Then
                    If objBll.Delete(objM流转票T) > 0 AndAlso objBll.Insert(arryList) > 0 Then
                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                        If File.Exists(strPath) Then
                            File.Copy(strPath, strServerPicturePath1 & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                        End If
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt产品图号.Focus()
                        Exit Sub
                    End If

            End Select

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#Region "SetFormData"

    Private Sub SetFormData()
        Dim objM流转票T As New M流转票管理T
        Dim objBll As BllM流转票管理T

        Try
            '获取数据
            objM流转票T = New M流转票管理T
            objBll = New BllM流转票管理T

            objM流转票T.产品图号 = Me.txt产品图号.Text
            'objM流转票T.工序名称 = txt工序名称.Text.Trim()
            If String.IsNullOrEmpty(objM流转票T.产品图号) Then
                objM流转票T.产品图号 = " "
            End If

            mDtSearch = objBll.LoadAllGrid(objM流转票T)
            If Not mDtSearch Is Nothing AndAlso mDtSearch.Rows.Count > 0 Then
                grid流转票.DataSource = mDtSearch

                If File.Exists(strServerPicturePath1 & mDtSearch.Rows(0)("图纸").ToString()) Then

                    strPath = strServerPicturePath1 & mDtSearch.Rows(0)("图纸").ToString()
                    If mDtSearch.Rows(0)("图纸").ToString().ToUpper.Contains(".PDF") Then
                        SetPDFPictureBoxImage()
                    Else
                        SetPictureBoxImage(Me.pic图纸, strServerPicturePath1 & mDtSearch.Rows(0)("图纸").ToString())
                    End If
                ElseIf File.Exists(strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString()) Then
                    strPath = strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString()
                    If mDtSearch.Rows(0)("图纸").ToString().ToUpper.Contains(".PDF") Then
                        SetPDFPictureBoxImage()
                    Else
                        SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString())
                    End If
                Else
                    Me.pic图纸.Image = Nothing
                End If
            Else
                grid流转票.DataSource = mDtSearch
            End If

            'grid流转票.DataSource = mDtSearch

            'If File.Exists(strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString()) Then

            '    strPath = strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString()
            '    If mDtSearch.Rows(0)("图纸").ToString().ToUpper.Contains(".PDF") Then
            '        SetPDFPictureBoxImage()
            '    Else
            '        SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mDtSearch.Rows(0)("图纸").ToString())
            '    End If
            'Else
            '    Me.pic图纸.Image = Nothing
            'End If

            With grid流转票.DisplayLayout.Bands(0)
                .Columns("备注").Hidden = True

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
#End Region
#Region "SetGridStyle"
    Private Sub SetGridStyle()
        Try
            With grid流转票.DisplayLayout.Bands(0)
                .Columns("外协加工").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                .Columns("组装品").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
                .Columns("设备编号").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
                .Columns("加工内容简介").Width = 425
                .Columns("加工内容简介").MaxLength = 9999999
                .Columns("产品图号").Hidden = True
                .Columns("备注").Hidden = True
                .Columns("试做品").Hidden = True
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
#Region "SetData"
    Private Sub SetData()
        Try
            Dim objM流转票管理T As New M流转票管理T
            Dim objBll As BllM流转票管理T

            '获取数据
            objM流转票管理T = New M流转票管理T
            objBll = New BllM流转票管理T

            objM流转票管理T.产品图号 = Me.txt产品图号.Text

            If String.IsNullOrEmpty(objM流转票管理T.产品图号) Then
                objM流转票管理T.产品图号 = " "
            End If
            If Me.txt产品图号.Text <> String.Empty Then

                mDtSearch = objBll.SetData(objM流转票管理T)

                If Not mDtSearch Is Nothing And mDtSearch.Rows.Count > 0 Then
                    Me.txt备注.Text = mDtSearch.Rows(0)("备注").ToString
                    Me.ckb试做品.Checked = mDtSearch.Rows(0)("试做品").ToString
                    grid流转票.DataSource = mDtSearch
                    '画面の修正処理()
                    mIntFormMode = Constant.ENU_MODE.Model_Update
                    SetFormModel()
                Else
                    Me.txt备注.Text = String.Empty
                    Me.pic图纸.Image = Nothing
                    grid流转票.DataSource = mDtSearch
                    '画面の新规処理()
                    mIntFormMode = Constant.ENU_MODE.Model_New
                    SetFormModel()
                End If
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
#Region "图片"
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

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub
    ''' <summary>
    ''' 获取访问服务器权限
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub savePictureServerQuanXian()
        Dim p As New Process
        '获取权限
        '--------------------------------------------------
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/c net use " & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PictureServer") & " " & Chr(34) & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PicturePassword") & Chr(34) & _
                                " /user:" & Chr(34) & _
                                System.Configuration.ConfigurationManager.AppSettings.Get("PictureUserID") & Chr(34)
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.CreateNoWindow = True
        p.Start()
        '--------------------------------------------------
    End Sub
#End Region

    Private Sub btnF11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF11.Click
        Try


            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog1.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog1.FileName
            Else
                Exit Sub
            End If
            If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                SetPDFPictureBoxImage()
            Else
                SetPictureBoxImage(Me.pic图纸, strPath)
            End If
            strPathFlg = True
            'pic图纸图片.Image.Dispose()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class