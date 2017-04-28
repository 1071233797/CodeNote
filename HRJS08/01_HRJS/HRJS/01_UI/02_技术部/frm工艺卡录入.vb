Imports HRJS.Constant
Imports System.IO
Imports System.IO.File
Imports O2S.Components.PDFRender4NET
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections.Generic
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Public Class frm工艺卡录入#Region "常量定义"
    Public Enum Definition
        One = 1
        Two = 2
        Three = 3
        Four = 4
        Five = 5
        Six = 6
        Seven = 7
        Eight = 8
        Nine = 9
        Ten = 10
    End Enum
#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    'Private mdsInfoDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Dim strPath As String
    Dim strPathFlg As Boolean = False
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Dim strTechnologyPathPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("TechnologyPath")
    Dim strMouldPath As String = System.Configuration.ConfigurationManager.AppSettings.Get("MouldPath")
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
    Private Sub frm工艺卡录入_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm工艺卡录入_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
                    btnF10_Click(Nothing, Nothing)
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
    'Private Sub btn图纸导入_Click(sender As Object, e As EventArgs) Handles btn图纸导入.Click
    '    Try
    '        Dim strPath As String

    '        Dim dialogResult As DialogResult

    '        dialogResult = Me.OpenFileDialog.ShowDialog()

    '        If dialogResult = Windows.Forms.DialogResult.OK Then
    '            strPath = Me.OpenFileDialog.FileName

    '        End If

    '        Me.pic图纸.Image = Image.FromFile(strPath)

    '        'pic图纸图片.Image.Dispose()

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    ' End Sub
    Private Sub btnF1清空_Click(sender As Object, e As EventArgs) Handles btnF1清空.Click
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
    Private Sub btnF2编辑_Click(sender As Object, e As EventArgs) Handles btnF2编辑.Click
        Dim frmSearch As frm工艺卡信息一览
        Try
            frmSearch = New frm工艺卡信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                 If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString
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
            '获取访问服务器权限
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
                Me.txt品名.Select()
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

        Dim objM工艺卡T As New M工艺卡T

        Dim objBll As New BLLM工艺卡T

        Try
            If mIntFormMode = Constant.ENU_MODE.Model_New Then
                Exit Sub
            End If
            '保存確認メッセージを表示する
            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                txt产品图号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            objM工艺卡T.产品图号 = txt产品图号.Text.Trim

            If objBll.Delete(objM工艺卡T) > 0 Then

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
            Dim intRow1 As Integer
            Dim BH As String

            If Me.grid工艺卡.Rows.Count = 0 Then
                intRow = 0
            Else

                If Me.grid工艺卡.ActiveRow Is Nothing Then
                    intRow = Me.grid工艺卡.Rows.Count - 1
                Else
                    intRow = Me.grid工艺卡.ActiveRow.Index + 1
                    'intRow1 = Me.grid工艺卡.ActiveRow.Index + 1
                End If
            End If

            If mdsInfoDataSet Is Nothing Then
                Exit Sub
            End If

            mdsInfoDataSet = mdsInfoDataSet
            dr = mdsInfoDataSet.NewRow()

            'If intRow <> 0 Then
            '    For intCloumns = 0 To dt检查数据.Columns.Count - 5

            '        dr(intCloumns) = dt检查数据.Rows(intRow - 1)(intCloumns)
            '    Next
            'End If

            If intRow = 0 Then
                mdsInfoDataSet.Rows.Add(dr)
            Else
                mdsInfoDataSet.Rows.InsertAt(dr, intRow)
            End If

            mdsInfoDataSet.AcceptChanges()
            Me.grid工艺卡.ActiveRow = Me.grid工艺卡.Rows(intRow)
            Me.grid工艺卡.Rows(intRow).Cells(0).Activate()
            Me.grid工艺卡.UpdateData()
            Me.grid工艺卡.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

            SetGridStyle图纸()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub grid工艺卡_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid工艺卡.InitializeLayout
        grid工艺卡.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid工艺卡.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    End Sub
    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click
        Dim intRow As Integer
        Dim intRowDelete As Integer

        Try

            If Me.grid工艺卡.ActiveRow Is Nothing Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                Return
            End If

            '「選択された行を削除してもよろしいですか？」

            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
                '登録処理終了
                Me.Cursor = Cursors.Default
                Return
            End If


            intRow = Me.grid工艺卡.ActiveRow.VisibleIndex

            intRowDelete = Me.grid工艺卡.ActiveRow.Index

            Me.grid工艺卡.Rows(intRowDelete).Delete(False)

            If Me.grid工艺卡.Rows.VisibleRowCount = 0 Or Me.grid工艺卡.Rows.Count = 0 Then
                '行を追加
                'Me.FN_AddGrid範囲NewRow()
                intRow = 0
            Else
                If Me.grid工艺卡.Rows.VisibleRowCount < intRow Then
                    intRow = 0
                ElseIf Me.grid工艺卡.Rows.VisibleRowCount = intRow Then
                    intRow = Me.grid工艺卡.Rows.VisibleRowCount - 1
                End If

                Me.grid工艺卡.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
                Me.grid工艺卡.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                Me.grid工艺卡.UpdateData()
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btnF10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF10.Click

    End Sub

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click
        Me.Cursor = Cursors.WaitCursor
        ''画面の終了処理
        Me.Close()
    End Sub
#End Region
#Region "control event"

    Private Sub cek是否为试做品_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cek附加图号.CheckedChanged


        If Me.cek附加图号.Checked Then
            '图纸ID
            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                Me.cek附加图号.Checked = False
                txt产品图号.Focus()
                Exit Sub
            End If

            'If Me.txt品名.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品名", "品名")
            '    Me.cek附加图号.Checked = False
            '    txt品名.Focus()
            '    Exit Sub
            'End If

            Me.txt产品图号.Enabled = False
            'Me.txt品名.Enabled = False
            Me.txt附加图号.Enabled = True
            Me.txt附加品名.Enabled = True
        Else
            Me.txt产品图号.Enabled = True
            'Me.txt品名.Enabled = True
            Me.txt附加图号.Enabled = False
            Me.txt附加品名.Enabled = False
            Me.txt附加图号.Text = String.Empty
            Me.txt附加品名.Text = String.Empty
        End If



    End Sub

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
                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号
                    Me.txt品名.Text = frmSearch.ReturnTable.Rows(0)("品名")     '品名
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
                    SetData()

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

    Private Sub txt产品图号_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txt产品图号.Leave
        Dim objM图纸T As M图纸T
        Dim objBLLM图纸T As BLLM图纸T

        Try

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
                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "图纸名称")
                    Me.txt产品图号.Text = String.Empty
                    Me.txt品名.Text = String.Empty
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

            '必須チェック(MsgID=21) 

            '图纸ID
            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                txt产品图号.Focus()
                Return False
            End If


            'If Me.txt品名.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品名", "品名")
            '    txt品名.Focus()
            '    Return False
            'End If


            If Me.cek附加图号.Checked Then
                If Me.txt附加图号.Text.Trim = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "附加图号", "附加图号")
                    txt附加图号.Focus()
                    Return False
                End If

                If Me.txt附加品名.Text.Trim = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "附加品名", "附加品名")
                    txt品名.Focus()
                    Return False
                End If
            End If

            'If pic图纸.Image Is Nothing Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸图像")
            '    Return False
            'End If

            If grid工艺卡.DataSource.rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "工序名称", "加工内容")
                Me.btnF5行追加.Focus()
                Return False
            Else
                For Each dr As DataRow In grid工艺卡.DataSource.rows

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
            SetFormData()
            ''画面の初期化処理
            ClearForm()


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
    ''' 権限の制御処理    ''' </summary>
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
            'Me.txt加工内容.Text = String.Empty
            'Me.txt工序名称.Text = String.Empty
            Me.pic图纸.Image = Nothing
            strPathFlg = False
            Me.cek附加图号.Checked = False
            Me.txt产品图号.Enabled = True
            'Me.txt品名.Enabled = True
            Me.txt附加图号.Enabled = False
            Me.txt附加品名.Enabled = False
            Me.txt附加图号.Text = String.Empty
            Me.txt附加品名.Text = String.Empty
            mdsInfoDataSet.Clear()
            grid工艺卡.DataSource = mdsInfoDataSet
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
#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    txt产品图号.ReadOnly = False
                    txt品名.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    grid工艺卡.Select()
                Case Constant.ENU_MODE.Model_Update

                    txt产品图号.ReadOnly = True
                    txt品名.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
                    grid工艺卡.Select()
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
#Region "load"

    Private Sub Load()
        Dim intRow1 As Integer

        Try
            If grid工艺卡.Rows.Count = 0 Then
                For i = 0 To grid工艺卡.Rows.Count + 1
                    intRow1 = Me.grid工艺卡.Rows.Count
                Next
                For i = 0 To grid工艺卡.Rows.Count + 1
                    Me.grid工艺卡.ActiveRow.Cells("工序编号").Value = intRow1
                Next
            Else
                'For i = 0 To grid工艺卡.Rows.Count - 1
                '    intRow1 += Me.grid工艺卡.Rows.Count
                'Next
                For i = 0 To grid工艺卡.Rows.Count - 1
                    Me.grid工艺卡.Rows(i).Cells("工序编号").Value = intRow1
                Next
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
#Region "SaveData"
    ''' <summary>
    ''' 画面の保存処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try
            Dim objM工艺卡T As New M工艺卡T
            Dim objBll As New BLLM工艺卡T
            Dim arryList As New ArrayList

            For i = 0 To grid工艺卡.Rows.Count - 1
                objM工艺卡T = New M工艺卡T
                If Me.cek附加图号.Checked Then
                    objM工艺卡T.产品图号 = txt附加图号.Text.Trim
                    objM工艺卡T.品名 = txt附加品名.Text.Trim
                    objM工艺卡T.上级图号 = txt产品图号.Text.Trim
                Else
                    objM工艺卡T.产品图号 = txt产品图号.Text.Trim
                    'objM工艺卡T.品名 = txt品名.Text.Trim
                End If

                If Me.cek附加图号.Checked Then
                    objM工艺卡T.图纸图片 = Me.txt附加图号.Text & Strings.Right(Path.GetFileName(strPath), 4)
                Else

                    objM工艺卡T.图纸图片 = Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4)
                End If

                If grid工艺卡.Rows(i).Cells("录入时间").Value.ToString() & "" = "" Then

                    objM工艺卡T.录入时间 = DateTime.Now
                Else

                    objM工艺卡T.录入时间 = grid工艺卡.Rows(i).Cells("录入时间").Value.ToString()
                End If
                objM工艺卡T.工序编号 = i + 1
                objM工艺卡T.工序名称 = grid工艺卡.Rows(i).Cells("工序名称").Value.ToString()
                objM工艺卡T.加工内容 = grid工艺卡.Rows(i).Cells("加工内容").Value.ToString()
                objM工艺卡T.备注 = grid工艺卡.Rows(i).Cells("备注").Value.ToString()
                objM工艺卡T.作业者 = grid工艺卡.Rows(i).Cells("作业者").Value.ToString()
                objM工艺卡T.登陆者 = gObjM_人员T.人员编号
                objM工艺卡T.登陆日期 = DateTime.Now
                objM工艺卡T.更新者 = gObjM_人员T.人员编号
                objM工艺卡T.更新日期 = DateTime.Now
                arryList.Add(objM工艺卡T)
            Next

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM工艺卡T).工序名称 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "工序名称")
                        'txt工序名称.Select()
                        '処理終了
                        Exit Sub
                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        If strPathFlg Then
                            File.Copy(strPath, strTechnologyPathPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                        End If

                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt产品图号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Delete(objM工艺卡T) > 0 AndAlso objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                        If strPathFlg Then

                            If Me.cek附加图号.Checked Then
                                File.Delete(strTechnologyPathPicturePath & Me.txt附加图号.Text & Strings.Right(Path.GetFileName(strPath), 4))
                                File.Copy(strPath, strTechnologyPathPicturePath & Me.txt附加图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                            Else
                                File.Delete(strTechnologyPathPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4))
                                File.Copy(strPath, strTechnologyPathPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                            End If

                      
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
    '#Region "GetImgSrting"

    '    Private Function GetImgSrting(ByVal imgValue As Image) As String

    '        Dim bmp As New Bitmap(imgValue, 320, 320)
    '        Dim ex As String = ".jpg"

    '        Dim bReturn() As Byte = Nothing

    '        Dim ms As MemoryStream = New MemoryStream()

    '        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

    '        bReturn = ms.ToArray()
    '        ms.Close()

    '        Return Convert.ToBase64String(bReturn)

    '    End Function

    '#End Region
    '#Region "ShowImgByByte"
    '    Public Sub ShowImgByByte(imgBytesIn As Byte())
    '        Dim ms As New MemoryStream(imgBytesIn)
    '        pic图纸.Image = Image.FromStream(ms)
    '    End Sub
    '#End Region
#Region "SetFormData"

    Private Sub SetFormData()
        Dim objM工艺卡T As New M工艺卡T
        Dim objBll As BLLM工艺卡T

        Try
            '获取数据
            objM工艺卡T = New M工艺卡T
            objBll = New BLLM工艺卡T

            objM工艺卡T.产品图号 = txt产品图号.Text.Trim()
            If String.IsNullOrEmpty(objM工艺卡T.产品图号) Then
                objM工艺卡T.产品图号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAll(objM工艺卡T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                strPath = mdsInfoDataSet.Rows(0)("图纸").ToString()
                If mdsInfoDataSet.Rows(0)("上级图号").ToString() & "" = "" Then
                    Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString()
                    Me.txt品名.Text = mdsInfoDataSet.Rows(0)("品名").ToString()
                 
                    If File.Exists(strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString()) Then

                        strPath = strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString()
                        If mdsInfoDataSet.Rows(0)("图纸").ToString().ToUpper.Contains(".PDF") Then
                            SetPDFPictureBoxImage()
                        Else
                            SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString())
                        End If
                    Else
                        Me.pic图纸.Image = Nothing
                    End If
                Else
                    Me.cek附加图号.Checked = True
                    Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("上级图号").ToString()
                    Me.txt附加图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString()
                    Me.txt附加品名.Text = mdsInfoDataSet.Rows(0)("附加品名").ToString()
                    If File.Exists(strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString()) Then

                        strPath = strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString()
                        If mdsInfoDataSet.Rows(0)("图纸").ToString().ToUpper.Contains(".PDF") Then
                            SetPDFPictureBoxImage()
                        Else
                            SetPictureBoxImage(Me.pic图纸, strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString())
                        End If
                    Else

                        Me.pic图纸.Image = Nothing
                    End If
                End If

            Else
                Me.txt产品图号.Text = String.Empty
                Me.txt品名.Text = String.Empty

            End If

            mdsInfoDataSet = objBll.LoadAllGrid(objM工艺卡T)
            'If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
            grid工艺卡.DataSource = mdsInfoDataSet
            'grid图纸管理.DisplayLayout.Bands(0).Columns("产品图号CD").Hidden = True
            SetGridStyle图纸()
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
    Private Sub btn图纸导入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11.Click
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
            'If File.Exists(strPath) Then
            '    SetPictureBoxImage(Me.pic图纸, strPath)
            'End If

            'Me.pic图纸.Image = Image.FromFile(strPath)
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
    Public Sub SetPDFPictureBoxImage()
        Dim pageImage As Bitmap = ConvertPDF2Image(strPath, Definition.One)
        Dim bmp As New Bitmap(Me.pic图纸.Width, Me.pic图纸.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim img As Image = pageImage
        Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
        '按比例缩放
        GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
        g.DrawImage(img, rectImage)

        Me.pic图纸.Image = bmp

    End Sub
    Public Function ConvertPDF2Image(ByVal pdfInputPath As String, ByVal definition As Definition) As Bitmap

        Dim pdfFile1 As PDFFile = PDFFile.Open(pdfInputPath)

        If Not File.Exists(pdfInputPath) Then
            Directory.CreateDirectory(pdfInputPath)
        End If

        Return pdfFile1.GetPageImage(0, 56 * CInt(definition))
        'pageImage.Save(imageOutputPath & imageName & "." & imageFormat.ToString(), imageFormat)


    End Function
    Private Sub pic图纸_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pic图纸.DoubleClick
        If Path.GetExtension(strPath).ToUpper = ".PDF" Then

            If File.Exists(strPath) Then
                Try
                    Process.Start(strPath)
                Catch ex As Exception

                End Try


            End If

        End If
    End Sub
#Region "SetGridStyle"

    Private Sub SetGridStyle图纸()
        Try

            With grid工艺卡.DisplayLayout.Bands(0)

                .Columns("作业者").Hidden = True
                .Columns("录入时间").Hidden = True
   
      
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
            Dim objM工艺卡T As New M工艺卡T
            Dim objBll As BLLM工艺卡T

            '获取数据
            objM工艺卡T = New M工艺卡T
            objBll = New BLLM工艺卡T

            objM工艺卡T.产品图号 = Me.txt产品图号.Text

            If String.IsNullOrEmpty(objM工艺卡T.产品图号) Then
                objM工艺卡T.产品图号 = " "
            End If
            If Me.txt产品图号.Text <> String.Empty Then

                mdsInfoDataSet = objBll.SetData(objM工艺卡T)

                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then
                   
                    grid工艺卡.DataSource = mdsInfoDataSet
                    '画面の修正処理()
                    mIntFormMode = Constant.ENU_MODE.Model_Update
                    SetFormModel()
                Else
                   
                    grid工艺卡.DataSource = mdsInfoDataSet
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
End Class