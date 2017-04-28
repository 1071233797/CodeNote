Imports HRJS.Constant
Imports System.IO
Public Class frm报废品管理


#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    ' Dim strID As String = String.Empty
    Dim strPath As String = String.Empty
    Dim strPathFlg1 As Boolean = False
    Dim strPathFlg2 As Boolean = False
    Dim strPathFlg3 As Boolean = False
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("ScrapPath")
#End Region

#Region "Form Event"

    Private Sub frm报废品管理_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm报废品管理_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm报废品管理_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

        Dim frmSearch As frm报废品一览

        Try

            frmSearch = New frm报废品一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '设备信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    'strID = frmSearch.ReturnTable.Rows(0)("ID").ToString
                    Me.txt报废品订单编号.Text = frmSearch.ReturnTable.Rows(0)("报废品订单编号").ToString          '报废品订单编号                    Me.txt报废品订单编号.Enabled = False
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString          '客户名称
                    Me.txt发货日期.Text = frmSearch.ReturnTable.Rows(0)("发货日期").ToString          '发货日期
                    Me.txt报废品图号.Text = frmSearch.ReturnTable.Rows(0)("报废品图号").ToString          '报废品图号
                    Me.txt总图号.Text = frmSearch.ReturnTable.Rows(0)("总图号").ToString          '总图号
                    Me.txt报废品产生工序.Text = frmSearch.ReturnTable.Rows(0)("报废品产生工序").ToString          '报废品产生工序
                    Me.txt报废品数量.Text = frmSearch.ReturnTable.Rows(0)("报废品数量").ToString          '报废品数
                    Me.txt报废品生产者.Text = frmSearch.ReturnTable.Rows(0)("报废品生产者").ToString       '报废品生产者
                    Me.txt报废日期.Text = frmSearch.ReturnTable.Rows(0)("报废日期").ToString          '报废日期
                    Me.txt报废原因.Text = frmSearch.ReturnTable.Rows(0)("报废原因").ToString          '报废原因
                    Me.txt品质处理结果.Text = frmSearch.ReturnTable.Rows(0)("处理结果").ToString          '品质处理结果
                    Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString          '备注
                    Me.txt图片导入1.Text = frmSearch.ReturnTable.Rows(0)("pic1").ToString          '备注
                    Me.txt图片导入2.Text = frmSearch.ReturnTable.Rows(0)("pic2").ToString          '备注
                    Me.txt图片导入3.Text = frmSearch.ReturnTable.Rows(0)("pic3").ToString          '备注


                    If File.Exists(strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic1").ToString()) Then


                        SetPictureBoxImage(Me.pic1, strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic1").ToString())
                    End If

                    If File.Exists(strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic2").ToString()) Then

                        SetPictureBoxImage(Me.pic2, strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic2").ToString())

                    End If

                    If File.Exists(strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic3").ToString()) Then

                        SetPictureBoxImage(Me.pic3, strServerPicturePath & frmSearch.ReturnTable.Rows(0)("pic3").ToString())
                    End If

                    strPathFlg1 = False
                    strPathFlg2 = False
                    strPathFlg3 = False

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

            'cbo设备类别.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM报废品T As New B报废品T

        Dim objBll As New BllM报废品T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt报废品订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废品订单编号", "报废品订单编号")
                txt报废品订单编号.Focus()
                Exit Sub
            End If



            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM报废品T.报废品订单编号 = txt报废品订单编号.Text.Trim
            objM报废品T.报废品产生工序 = txt报废品产生工序.Text.Trim
            objM报废品T.报废品生产者 = txt报废品生产者.Text.Trim
            objM报废品T.报废品数量 = txt报废品数量.Text.Trim
            'objM报废品管理T.ID = strID

            If objBll.Delete(objM报废品T) > 0 Then

                '成功メッセージを表示する

                If File.Exists(txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(Me.txt图片导入1.Text), 4)) Then
                    File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(Me.txt图片导入1.Text), 4))

                End If
                If File.Exists(txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(Me.txt图片导入2.Text), 4)) Then
                    File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(Me.txt图片导入2.Text), 4))

                End If
                If File.Exists(txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(Me.txt图片导入3.Text), 4)) Then
                    File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(Me.txt图片导入3.Text), 4))

                End If

                'File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(Me.txt图片导入1.Text), 4))
                'File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(Me.txt图片导入2.Text), 4))
                'File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(Me.txt图片导入3.Text), 4))


                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New

            SetFormModel()
            ClearForm()
            Me.txt报废品订单编号.Focus()

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
            '获取访问服务器权限
            Call savePictureServerQuanXian()
            '画面のCheck処理

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
                Me.txt报废品订单编号.Select()
            Else
                Me.txt报废品订单编号.Select()
            End If
            ''画面の初期化処理
            ' ClearForm()
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
            ' Me.SetCombo()

            'Me.SetInputDigit()

            '画面の内容を清空処理
            Me.ClearForm()

            '権限の処理
            Me.SetPermission()

            Me.txt报废品订单编号.Select()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "SetCombo"

    'Private Sub SetCombo()

    '    Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

    '    Try

    '        '使用状态
    '        Utility.PFn_SetCombo(Me.cbo使用状态, "VM使用状态", 0)

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt报废品订单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt报废品订单编号.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt报废品订单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    txt报废品订单编号.Select()
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

#Region "SetInputDigit"
    'Private Sub SetInputDigit()
    '    txt设备产量.IsDigit = True
    'End Sub
#End Region

#Region "ClearForm"

    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()

        Try

            Me.txt报废品订单编号.Text = String.Empty
            Me.txt报废品订单编号.Enabled = True
            Me.txt客户名称.Text = String.Empty
            Me.txt发货日期.Text = DateTime.Now
            Me.txt报废品图号.Text = String.Empty
            Me.txt总图号.Text = String.Empty
            Me.txt报废品产生工序.Text = String.Empty
            Me.txt报废品数量.Text = String.Empty
            Me.txt报废品生产者.Text = String.Empty
            Me.txt报废原因.Text = String.Empty
            Me.txt品质处理结果.Text = String.Empty
            Me.txt备注.Text = String.Empty
            Me.txt报废日期.Text = DateTime.Now
            Me.pic1.Image = Nothing
            Me.pic2.Image = Nothing
            Me.pic3.Image = Nothing
            strPathFlg1 = False
            strPathFlg2 = False
            strPathFlg3 = False
            Me.txt图片导入1.Text = String.Empty
            Me.txt图片导入2.Text = String.Empty
            Me.txt图片导入3.Text = String.Empty

            Me.txt报废品订单编号.Select()

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

            Dim objM报废品T As New B报废品T
            Dim objBll As New BllM报废品T
            'objM废料回收管理T.ID = strID
            objM报废品T.报废品订单编号 = txt报废品订单编号.Text.Trim
            objM报废品T.客户名称 = txt客户名称.Text.Trim
            objM报废品T.发货日期 = txt发货日期.Text.Trim
            objM报废品T.报废品图号 = txt报废品图号.Text.Trim
            objM报废品T.总图号 = txt总图号.Text.Trim
            objM报废品T.报废品产生工序 = txt报废品产生工序.Text.Trim
            objM报废品T.报废品数量 = txt报废品数量.Text.Trim
            objM报废品T.报废品生产者 = txt报废品生产者.Text.Trim
            objM报废品T.报废日期 = txt报废日期.Text.Trim
            objM报废品T.报废原因 = txt报废原因.Text.Trim
            objM报废品T.处理结果 = txt品质处理结果.Text.Trim
            objM报废品T.备注 = txt备注.Text.Trim


            'If Not File.Exists(txt图片导入1.Text) Then
            '    Exit Sub
            'Else
            '    objM报废品T.pic1 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(Me.txt图片导入1.Text), 4)
            'End If

            'If Not File.Exists(txt图片导入2.Text) Then
            '    Exit Sub
            'Else
            '    objM报废品T.pic2 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(Me.txt图片导入2.Text), 4)
            'End If

            'If Not File.Exists(txt图片导入3.Text) Then
            '    Exit Sub
            'Else
            '    objM报废品T.pic3 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(Me.txt图片导入3.Text), 4)
            'End If
            If strPathFlg1 AndAlso File.Exists(Me.txt图片导入1.Text) Then
                objM报废品T.pic1 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(Me.txt图片导入1.Text), 4)

            End If
            If strPathFlg2 AndAlso File.Exists(Me.txt图片导入2.Text) Then
                objM报废品T.pic2 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(Me.txt图片导入2.Text), 4)

            End If
            If strPathFlg3 AndAlso File.Exists(Me.txt图片导入3.Text) Then
                objM报废品T.pic3 = Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(Me.txt图片导入3.Text), 4)
            End If

            objM报废品T.登录者 = gObjM_人员T.人员编号
            objM报废品T.登录日期 = DateTime.Now
            objM报废品T.更新者 = gObjM_人员T.人员编号
            objM报废品T.更新日期 = DateTime.Now



            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    'If objBll.LoadByPKey(objM报废品T).报废品订单编号 <> String.Empty Then

                    '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "报废品订单编号")
                    '    txt报废品订单编号.Select()
                    '    '処理終了
                    '    Exit Sub

                    'End If

                    If objBll.Insert(objM报废品T) > 0 Then


                        If File.Exists(txt图片导入1.Text) Then
                            File.Copy(txt图片导入1.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(txt图片导入1.Text), 4), True)
                        End If
                        If File.Exists(txt图片导入2.Text) Then
                            File.Copy(txt图片导入2.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(txt图片导入2.Text), 4), True)
                        End If
                        If File.Exists(txt图片导入3.Text) Then
                            File.Copy(txt图片导入3.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(txt图片导入3.Text), 4), True)
                        End If

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt报废品订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM报废品T) > 0 Then
                        If strPathFlg1 Then
                            File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(txt图片导入1.Text), 4))
                            File.Copy(txt图片导入1.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-1" & Strings.Right(Path.GetFileName(txt图片导入1.Text), 4), True)

                        End If
                        If strPathFlg2 Then
                            File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(txt图片导入2.Text), 4))
                            File.Copy(txt图片导入2.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-2" & Strings.Right(Path.GetFileName(txt图片导入2.Text), 4), True)

                        End If
                        If strPathFlg3 Then
                            File.Delete(strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(txt图片导入3.Text), 4))
                            File.Copy(txt图片导入3.Text, strServerPicturePath & Me.txt报废品订单编号.Text & Now.ToString("yyyyMMddHHMMSS") & "-3" & Strings.Right(Path.GetFileName(txt图片导入3.Text), 4), True)

                        End If


                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt报废品订单编号.Focus()
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

#End Region

#Region "InputCheck"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck() As Boolean
        Dim objM报废品T As B报废品T
        Dim objBllM报废品T As BllM报废品T
        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '设备ID
            If Me.txt报废品订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废品订单编号", "报废品订单编号")
                txt报废品订单编号.Focus()
                Return False
            End If

            If Not IsNumeric(Me.txt报废品图号.Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废品图号", "报废品图号")
                txt报废品图号.Focus()
                Return False
            End If
            '设备名            If Me.txt报废品产生工序.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废品产生工序", "报废品产生工序")
                txt报废品产生工序.Focus()
                Return False
            End If

            If Me.txt报废品生产者.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废品生产者", "报废品生产者")
                txt报废品生产者.Focus()
                Return False
            End If
            If Me.txt报废品数量.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID30, "报废品数量", "报废品数量")
                txt报废品数量.Focus()
                Return False
            End If
            If Me.txt报废日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废日期", "报废日期")
                txt报废日期.Focus()
                Return False
            End If
            If Me.txt报废原因.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "报废原因", "报废原因")
                txt报废原因.Focus()
                Return False
            End If
            If Me.txt品质处理结果.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品质处理结果", "品质处理结果")
                txt品质处理结果.Focus()
                Return False
            End If
            If Me.txt备注.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "备注", "备注")
                txt备注.Focus()
                Return False

            End If
            If Not File.Exists(strPath) AndAlso strPathFlg1 AndAlso strPathFlg2 AndAlso strPathFlg3 = True Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID43)
                Return False
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

            'Me.btnF1清空.Enabled = Utility.PFn_GetAuth(Me.btnF1清空.Tag)
            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)

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

#Region "Control Event"

#Region "报废品订单编号"

    Private Sub txt报废品订单编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品订单编号.Enter

        Try

            Me.txt报废品订单编号.Tag = Me.txt报废品订单编号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品订单编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品订单编号.EditorButtonClick


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

                    Me.txt报废品订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")     '原材料编号

                    Me.txt发货日期.Text = frmSearch.ReturnTable.Rows(0)("发货日期")     '原材料名称

                    Me.txt总图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '原材料规格

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '材质tudu

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
#Region "报废品图号"

    Private Sub txt报废品图号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品订单编号.Enter

        Try

            Me.txt报废品图号.Tag = Me.txt报废品图号.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品图号.EditorButtonClick


        Dim frmSearch As frm图纸信息一览
        Try

            frmSearch = New frm图纸信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt报废品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '产品图号


                    'Me.txt发货日期.Text = frmSearch.ReturnTable.Rows(0)("发货日期")     '原材料名称

                    'Me.txt总图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '原材料规格
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
#Region "报废品生产者"

    Private Sub txt报废品生产者_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt报废品生产者.Enter

        Try

            Me.txt报废品生产者.Tag = Me.txt报废品生产者.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt报废品生产者_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt报废品生产者.EditorButtonClick


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

                    Me.txt报废品生产者.Text = frmSearch.ReturnTable.Rows(0)("人员名")     '产品图号


                    'Me.txt发货日期.Text = frmSearch.ReturnTable.Rows(0)("发货日期")     '原材料名称

                    'Me.txt总图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")     '原材料规格
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
#Region "图片导入"

    Private Sub txt图片导入1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt图片导入1.Enter

        Try

            Me.txt图片导入1.Tag = Me.txt图片导入1.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt图片导入1_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt图片导入1.EditorButtonClick

        Try

            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog.FileName
            Else
                Exit Sub
            End If
            Me.txt图片导入1.Text = strPath     '原材料规格
            SetPictureBoxImage(Me.pic1, strPath)
            strPathFlg1 = True
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub txt图片导入2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt图片导入2.Enter

        Try

            Me.txt图片导入2.Tag = Me.txt图片导入2.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt图片导入2_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt图片导入2.EditorButtonClick

        Try

            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog.FileName
            Else
                Exit Sub
            End If
            Me.txt图片导入2.Text = strPath

            SetPictureBoxImage(Me.pic2, strPath)
            strPathFlg2 = True
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub txt图片导入3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt图片导入3.Enter

        Try

            Me.txt图片导入3.Tag = Me.txt图片导入3.Text.Trim

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try

    End Sub

    Private Sub txt图片导入3_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt图片导入3.EditorButtonClick

        Try

            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog.FileName
            Else
                Exit Sub
            End If
            Me.txt图片导入3.Text = strPath

            SetPictureBoxImage(Me.pic3, strPath)
            strPathFlg3 = True
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
        img.Dispose()
    End Sub

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub


#End Region
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

End Class
