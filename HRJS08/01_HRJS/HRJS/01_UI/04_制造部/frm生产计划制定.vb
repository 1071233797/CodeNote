Imports Infragistics.Win.UltraWinGrid
Imports System.IO
Imports O2S.Components.PDFRender4NET
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class frm生产计划制定
#Region "常量定义"

    Private Enum ENU_GRID As Integer
        产品图号 = 0
        品名 = 1
        是否为抵补品 = 2
        是否为试做品 = 3
        订货量 = 4
        投产数量 = 5
        总件完成期限 = 6
        小件完成期限 = 7
        发货日期 = 8
        图纸 = 9



    End Enum

#End Region
#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Dim mDt详细主数据 As DataTable  'grid详细
    Private mds As Integer
    Dim strPath As String = String.Empty
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    'Dim mDt工序 As DataTable
    Dim str分图号 As String
    Dim str上级图号 As String
    Dim str主图号 As String
#End Region

#Region "Form Event"

    Private Sub frm生产计划制定_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub frm生产计划制定_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm生产计划制定_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                    'Case Keys.F5
                    '    btnF5保存.Focus()
                    '    btnF5保存_Click(Nothing, Nothing)

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
        Dim frmSearch As frm订单一览        Dim frmSearch生产 As frm生产计划一览
        Try

            frmSearch = New frm订单一览
            frmSearch.intDoubleClick = 2
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString        '订单编号

                    If InputCheck订单计划() = False Then
                        Exit Sub
                    End If
                    SetData()

                    'Load生产计划()
                    'SetData()
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
    Private Sub txt订单编号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt订单编号.Leave
        Dim objM订单表T As B订单表T
        Dim objBLLM订单表T As BllM订单表T

        Try

            If txt订单编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt订单编号.Text.Trim <> String.Empty Then

                If Me.txt订单编号.Tag = Me.txt订单编号.Text.Trim Then
                    Exit Sub
                End If

                objM订单表T = New B订单表T

                objM订单表T.订单编号 = txt订单编号.Text.Trim

                objBLLM订单表T = New BllM订单表T

                objM订单表T = objBLLM订单表T.LoadByPKey(objM订单表T)

                If objM订单表T.审核状态 = 1 Then
                    MsgBox("请选择审核通过的数据。")
                    Exit Sub
                End If

                If objM订单表T.客户编号 <> String.Empty Then

                    InputCheck订单计划()

                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "订单信息")
                    Me.txt订单编号.Text = String.Empty
                    'Me.txt人员名称.Text = String.Empty
                    Me.txt订单编号.Select()
                End If
            Else
                Me.txt订单编号.Text = String.Empty
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
        Dim dv As DataView
        Try
            '清空画面对话框


            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ''画面の初期化処理
            ClearForm()

            Me.pic图纸.Image = Nothing

            mIntFormMode = Constant.ENU_MODE.Model_New
            SetData()
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

        Dim frmSearch As frm生产计划一览        Try

            frmSearch = New frm生产计划一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '原材料信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置


                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号").ToString          '订单编号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称").ToString          '客户名称
                    'Me.txt投产数量.Text = frmSearch.ReturnTable.Rows(0)("投产数量").ToString          '投产数量
                    'Me.txt完成期限.Text = frmSearch.ReturnTable.Rows(0)("完成期限").ToString          '完成期限
                    'Me.txt订货量.Text = frmSearch.ReturnTable.Rows(0)("订单数量").ToString            '订单数量
                    Me.txt备注.Text = frmSearch.ReturnTable.Rows(0)("备注").ToString                  '备注
                    'Me.grid生产计划制定.Rows(0).Cells("产品图号").Value = frmSearch.ReturnTable.Rows(0)("产品图号").ToString
                    '设置画面数据
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

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM生产计划制定T As New M生产计划制定T

        Dim objBll As New BLLM生产计划制定T
        Dim dv As DataView
        Try
            'If mIntFormMode = Constant.ENU_MODE.Model_New Then
            '    Exit Sub
            'End If

            '保存確認メッセージを表示する
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Exit Sub
            End If

            '保存確認メッセージを表示する
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID4) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            objM生产计划制定T.订单编号 = txt订单编号.Text.Trim

            If objBll.Delete(objM生产计划制定T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID28)
            End If

            mIntFormMode = Constant.ENU_MODE.Model_New
            'dv = mDt工序.DefaultView
            'dv.RowFilter = "产品图号=''"
            'If Not Me.grid工序.DataSource Is Nothing Then
            '    Me.grid工序.DataSource = dv
            'End If
            ClearForm()

            SetData()
            SetFormModel()

            Me.txt订单编号.Focus()

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

            '画面のCheck処理()
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

            'If mIntFormMode = Constant.ENU_MODE.Model_New Then
            '    Me.txt订单编号.Select()
            'Else
            '    Me.txt产品图号.Select()
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

    Private Sub grid生产计划制定_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles grid生产计划制定.InitializeLayout
        Try
            grid生产计划制定.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
            grid生产计划制定.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            'For index As Integer = 0 To 4
            '    For intLoopi = 0 To grid生产计划制定.DisplayLayout.Bands(index).Columns.Count - 1

            '        If intLoopi = ENU_GRID.产品图号 Then

            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellActivation = Activation.NoEdit
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).TabStop = False
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellAppearance.BackColor = Color.Gainsboro
            '        End If

            '        If intLoopi = ENU_GRID.品名 Then

            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellActivation = Activation.NoEdit
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).TabStop = False
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellAppearance.BackColor = Color.Gainsboro
            '        End If

            '        If intLoopi = ENU_GRID.订货量 Then

            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellActivation = Activation.NoEdit
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).TabStop = False
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellAppearance.BackColor = Color.Gainsboro
            '        End If

            '        If intLoopi = ENU_GRID.投产数量 Then

            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellActivation = Activation.NoEdit
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).TabStop = False
            '            grid生产计划制定.DisplayLayout.Bands(index).Columns(intLoopi).CellAppearance.BackColor = Color.Gainsboro
            '        End If
            '    Next intLoopi
            'Next
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub grid生产计划制定_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grid生产计划制定.CellChange
        Try


            'Select Case grid生产计划制定.ActiveCell.Column.Index
            '    Case ENU_GRID.是否整体外协加工
            '        'If grid生产计划制定.ActiveRow.Cells(ENU_GRID.是否整体外协加工).Text = True Then
            '        '    For i = 0 To mDt工序.Rows.Count - 1
            '        '        mDt工序.Rows(i)("外协数量") = grid生产计划制定.ActiveRow.Cells(ENU_GRID.投产数量).Text * grid生产计划制定.ActiveRow.Cells(ENU_GRID.数量).Text
            '        '        mDt工序.Rows(i)("是否外协加工") = True
            '        '    Next
            '        'Else
            '        '    For i = 0 To mDt工序.Rows.Count - 1
            '        '        mDt工序.Rows(i)("外协数量") = 0
            '        '        mDt工序.Rows(i)("是否外协加工") = False
            '        '    Next
            '        'End If
            '    Case ENU_GRID.投产数量
            '        'If grid生产计划制定.ActiveRow.Cells(ENU_GRID.投产数量).Text = "" Then
            '        '    'MsgBox("请先填入投产数量")
            '        '    Exit Sub
            '        'Else
            '        '    If grid生产计划制定.ActiveRow.Cells(ENU_GRID.是否整体外协加工).Text = True Then
            '        '        For i = 0 To mDt工序.Rows.Count - 1
            '        '            mDt工序.Rows(i)("外协数量") = grid生产计划制定.ActiveRow.Cells(ENU_GRID.投产数量).Text * grid生产计划制定.ActiveRow.Cells(ENU_GRID.数量).Text
            '        '            'mDt工序.Rows(i)("是否外协加工") = True
            '        '        Next
            '        '    Else
            '        '        For i = 0 To mDt工序.Rows.Count - 1
            '        '            mDt工序.Rows(i)("外协数量") = 0
            '        '            'mDt工序.Rows(i)("是否外协加工") = True
            '        '        Next
            '        '    End If
            '        'End If
            '    Case Else

            'End Select



        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面の内容を清空処理
            'SetGridStyle生产()
            'SetGridStyle工序()
            Me.ClearForm()
            Me.SetFormModel()
            BindGridCombox()
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

#Region "SetFormModel"

    Private Sub SetFormModel()

        Try

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New
                    txt订单编号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    txt订单编号.Focus()
                Case Constant.ENU_MODE.Model_Update

                    txt订单编号.ReadOnly = True
                    labModel.Text = Constant.cgStrUpdate
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

            Me.txt订单编号.Text = String.Empty
            Me.txt备注.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.dmt下达日期.Text = Date.Now
            Me.txt订单编号.Select()

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
            Dim objM生产计划T As New M生产计划制定T
            Dim objBll As New BLLM生产计划制定T
            Dim arryList As New ArrayList
            For Each dr As DataRow In Me.grid生产计划制定.DataSource.rows
                objM生产计划T = New M生产计划制定T
                objM生产计划T.订单编号 = Me.txt订单编号.Text
                objM生产计划T.主图号 = dr("产品图号")
                objM生产计划T.投产数量 = dr("投产数量")
                objM生产计划T.总件完成期限 = dr("总件完成期限")
                objM生产计划T.小件完成期限 = dr("小件完成期限")
                objM生产计划T.下达日期 = dmt下达日期.Value
                'objM生产计划T.作业者 = dr("产品图号")
                arryList.Add(objM生产计划T)
            Next
            mDt详细主数据 = Me.grid生产计划制定.DataSource
            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New
                    If objBll.LoadByPKey(objM生产计划T).订单编号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号")
                        Me.txt订单编号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                        Update订单()
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt订单编号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update产品(arryList) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                    Else

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt订单编号.Focus()
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

        Try

            If mIntFormMode = Constant.ENU_MODE.Model_Delete Then
                Return True
            End If

            '必須チェック(MsgID=21) 

            '原材料ID
            If Me.txt订单编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "订单编号", "订单编号")
                txt订单编号.Focus()
                Return False
            End If


            If Me.dmt下达日期.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "下达日期", "下达日期")
                dmt下达日期.Focus()
                Return False
            End If

            '完成期限

            'If Me.dt总件完成期限.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "总件完成期限", "总件完成期限")
            '    dt总件完成期限.Focus()
            '    Return False
            'End If

            'If Me.dt小件完成期限.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "小件完成期限", "小件完成期限")
            '    dt小件完成期限.Focus()
            '    Return False
            'End If


            'If Me.txt投产数量.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "投产数量", "投产数量")
            '    txt投产数量.Focus()
            '    Return False
            'End If


            'Dim intLoopi As Integer

            For intLoopi = 0 To grid生产计划制定.Rows.Count - 1

                If grid生产计划制定.Rows(intLoopi).Cells(ENU_GRID.投产数量).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "投产数量") '完成日
                    Return False
                End If
                If grid生产计划制定.Rows(intLoopi).Cells(ENU_GRID.总件完成期限).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "总件完成期限") '完成日
                    Return False
                End If

                If grid生产计划制定.Rows(intLoopi).Cells(ENU_GRID.小件完成期限).Value.ToString = "" Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "小件完成期限") '完成日                    Return False
                End If

            Next
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
    ''' <summary>
    ''' 権限の制御処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF3保存.Enabled = Utility.PFn_GetAuth(Me.btnF3保存.Tag)
            Me.btnF2编辑.Enabled = Utility.PFn_GetAuth(Me.btnF2编辑.Tag)
            Me.btnF4删除.Enabled = Utility.PFn_GetAuth(Me.btnF4删除.Tag)
            'Me.btnF5保存.Enabled = Utility.PFn_GetAuth(Me.btnF5保存.Tag)

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#Region "SetData"
    Private Sub SetData()
        Dim objM生产计划T As New M生产计划制定T
        Dim objBll As BLLM生产计划制定T
        Dim mDt详细主数据 As DataTable  'grid详细
        Dim dtGridInfo As New DataTable
        Dim str产品图号S As String = String.Empty

        Try
            '获取数据
            objM生产计划T = New M生产计划制定T
            objBll = New BLLM生产计划制定T

            objM生产计划T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产计划T.订单编号) Then
                objM生产计划T.订单编号 = " "
            End If
            If txt订单编号.Text.Trim <> String.Empty Then
                mdsInfoDataSet = objBll.LoadAllHead1(objM生产计划T)
                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                    'Me.dmt发货日期.Text = mdsInfoDataSet.Rows(0)("发货日期").ToString()
                    Me.txt备注.Text = mdsInfoDataSet.Rows(0)("备注").ToString()

                Else

                    Me.txt订单编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    'Me.dmt发货日期.Text = String.Empty
                    Me.txt备注.Text = ""

                End If
            End If
            objM生产计划T.订单编号 = Me.txt订单编号.Text.Trim
            Me.grid生产计划制定.DataSource = Nothing
            mDt详细主数据 = New DataTable
            mDt详细主数据 = objBll.LoadAllGrid(objM生产计划T)
            'Me.grid生产计划制定.DataSource = Nothing
            Me.grid生产计划制定.DataSource = mDt详细主数据

            SetGridStyle生产()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region
#Region "Load生产计划"
    Private Function Load生产计划() As Boolean
        Dim objM生产计划T As New M生产计划制定T
        Dim objBll As BLLM生产计划制定T

        Try
            '获取数据
            objM生产计划T = New M生产计划制定T
            objBll = New BLLM生产计划制定T

            objM生产计划T.订单编号 = Me.txt订单编号.Text

            If Me.txt订单编号.Text <> String.Empty Then

                mdsInfoDataSet = objBll.Load生产计划(objM生产计划T)

                If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                    MsgBox("该计划已制定！")
                    Return False
                Else
                    Return True
                End If
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Function
#End Region
#Region "Update订单"
    Private Sub Update订单()
        Dim objM生产计划T As New M生产计划制定T
        Dim objBll As BLLM生产计划制定T
        Dim arraylist As ArrayList
        Try
            '获取数据
            objM生产计划T = New M生产计划制定T
            objBll = New BLLM生产计划制定T

            objM生产计划T.订单编号 = txt订单编号.Text.Trim()

            If String.IsNullOrEmpty(objM生产计划T.订单编号) Then
                objM生产计划T.订单编号 = " "
            End If
            If txt订单编号.Text.Trim <> String.Empty Then
                mds = objBll.Update订单(objM生产计划T)
                'If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                '    Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                '    Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                '    Me.dmt发货日期.Text = mdsInfoDataSet.Rows(0)("发货日期").ToString()
                '    Me.txt备注.Text = mdsInfoDataSet.Rows(0)("备注").ToString()
                '    Me.pic图纸.Text = mdsInfoDataSet.Rows(0)("图纸").ToString()

                'Else
                '    Me.txt订单编号.Text = String.Empty
                '    Me.txt完成期限.Text = String.Empty
                'End If
                '    mdsGridDataSet = objBll.LoadAllGrid(objM生产计划T)
                '    Me.grid生产计划制定.DataSource = mdsGridDataSet
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
#Region "SetFormData"
    Private Sub SetFormData()
        Dim objM生产计划T As New M生产计划制定T
        Dim objBll As BLLM生产计划制定T
        Dim mDt详细 As DataSet  'grid详细
        Dim mDt详细主数据 As DataTable  'grid详细
        Dim mDt详细1 As New DataTable
        Dim mDt详细2 As DataTable  'grid详细
        Dim mDt详细3 As DataTable  'grid详细
        Dim mDt详细4 As DataTable  'grid详细
        Dim mDt详细5 As DataTable  'grid详细
        Dim dv As New DataView
        Dim str产品图号S As String
        Try
            '获取数据
            objM生产计划T = New M生产计划制定T
            objBll = New BLLM生产计划制定T

            objM生产计划T.订单编号 = txt订单编号.Text.Trim()
            'objM生产计划T.主图号 = grid生产计划制定.ActiveRow.Cells("主图号").Value.ToString
            If String.IsNullOrEmpty(objM生产计划T.订单编号) Then
                objM生产计划T.订单编号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAllHead(objM生产计划T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then

                Me.txt订单编号.Text = mdsInfoDataSet.Rows(0)("订单编号").ToString()
                'Me.txt完成期限.Text = mdsInfoDataSet.Rows(0)("完成期限").ToString()
                'Me.dmt发货日期.Text = mdsInfoDataSet.Rows(0)("发货日期").ToString()
            Else
                Me.txt订单编号.Text = String.Empty
                'Me.txt完成期限.Text = String.Empty
            End If

            mDt详细 = New DataSet
            mDt详细主数据 = New DataTable
            mDt详细主数据 = objBll.LoadAllGrid(objM生产计划T)
            'dv = mDt详细图纸主数据.DefaultView
            mDt详细1 = mDt详细主数据.Clone
            For Each dr As DataRow In mDt详细主数据.Rows
                If dr("上级图号") & "" = "" Then
                    mDt详细1.Rows.Add(dr.ItemArray)
                End If
            Next
            'dt二级图纸 = mDt详细图纸主数据.Clone
            'dv.RowFilter = "上级图号 is null"
            'If dv.Count > 0 Then
            '    For Each dr As DataRow In dv.FindRows
            '        mDt详细图纸1.Rows.Add(dr)
            '    Next
            'End If


            'mdt详细Band1データを記録テーブル初期化
            mDt详细2 = mDt详细主数据.Copy
            mDt详细3 = mDt详细主数据.Copy
            mDt详细4 = mDt详细主数据.Copy
            mDt详细5 = mDt详细主数据.Copy
            'mDt详细图纸2 = objBLLM生产计划制定T.LoadByWhere2(objM生产T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(4) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细1.TableName = "详细1"
            mDt详细.Tables.Add(mDt详细1)
            mDt详细2.TableName = "详细2"
            mDt详细.Tables.Add(mDt详细2)
            mDt详细3.TableName = "详细3"
            mDt详细.Tables.Add(mDt详细3)
            mDt详细4.TableName = "详细4"
            mDt详细.Tables.Add(mDt详细4)
            mDt详细5.TableName = "详细5"
            mDt详细.Tables.Add(mDt详细5)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("分图号")
            childCols(0) = mDt详细.Tables(1).Columns("上级图号")

            drBand(0) = New DataRelation("1階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(1).Columns("分图号")
            childCols(0) = mDt详细.Tables(2).Columns("上级图号")

            drBand(1) = New DataRelation("2階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(1))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(2).Columns("分图号")
            childCols(0) = mDt详细.Tables(3).Columns("上级图号")

            drBand(2) = New DataRelation("3階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(2))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(3).Columns("分图号")
            childCols(0) = mDt详细.Tables(4).Columns("上级图号")

            drBand(3) = New DataRelation("4階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(3))

            'ReDim parentCols(0)
            'ReDim childCols(0)
            'parentCols(0) = mDt详细.Tables(4).Columns("产品图号")
            'childCols(0) = mDt详细.Tables(5).Columns("上级图号")

            'drBand(4) = New DataRelation("5階層", parentCols, childCols, False)
            'mDt详细.Relations.Add(drBand(4))

            Me.grid生产计划制定.DataSource = mDt详细
            grid生产计划制定.Refresh()
            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Me.grid生产计划制定.DataSource = mDt详细

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid生产计划制定.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt订单编号.Focus()
            Else
                '検索データを表示する
                Me.grid生产计划制定.DataSource = mDt详细
                Me.grid生产计划制定.Focus()
                Me.grid生产计划制定.ActiveRow = Me.grid生产计划制定.Rows(0)
                For Each drr As DataRow In mDt详细主数据.Rows
                    If str产品图号S = String.Empty Then
                        str产品图号S = drr("分图号")
                    Else
                        str产品图号S = str产品图号S & "','" & drr("分图号")
                    End If
                Next
                objM生产计划T.分图号 = str产品图号S
                objM生产计划T.主图号 = str主图号                objM生产计划T.上级图号 = str上级图号
                'mDt工序 = objBll.LoadAllGrid1(objM生产计划T)
                'Call grdList_MouseDown(Nothing, Nothing)
                SetGridStyle生产()
            End If
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
#Region "BindGridCombox"

    Private Sub BindGridCombox(Optional ByVal intRowIndex As Integer = 0)

        Try
            Utility.PFn_SetGirdCombo(Me.grid生产计划制定, "VM是否外协", 0)
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "SetGridStyle生产"
    Private Sub SetGridStyle生产()
        Try
            With grid生产计划制定.DisplayLayout.Bands(0)
                '.Columns("数量(套)").Hidden = True
                .Columns("产品图号").CellActivation = Activation.NoEdit
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").Style = ColumnStyle.Double
                .Columns("投产数量").CellActivation = Activation.AllowEdit
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("订货量").Style = ColumnStyle.Double
                .Columns("订货量").CellActivation = Activation.NoEdit
                '.Columns("投产数量").PromptChar = ColumnStyle.Double
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                .Columns("图纸").Hidden = True
                '.Columns("主图号").Hidden = True
                '.Columns("上级图号").Hidden = True
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

#Region "InputCheck11"
    ''' <summary>
    ''' 画面のCheck処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Function InputCheck订单计划() As Boolean

        Try

            Dim objM生产计划T As New M生产计划制定T
            Dim objBll As BLLM生产计划制定T
            Dim mDt详细主数据1 As DataTable  'grid详细

            objM生产计划T = New M生产计划制定T
            objBll = New BLLM生产计划制定T
            objM生产计划T.订单编号 = Me.txt订单编号.Text

            mDt详细主数据1 = objBll.CheckGrid(objM生产计划T)

            If mDt详细主数据1 Is Nothing OrElse mDt详细主数据1.Rows.Count = 0 Then
                MsgBox("图号工序为空，请先录入工序")
                Return False
            End If


            If Load生产计划() Then

                'SetGridStyle生产()
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

    Private Sub dt总件完成期限_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        'If dt总件完成期限.Value Is Nothing Then
        '    Exit Sub
        'End If

        'If Me.grid生产计划制定.Rows.Count = 0 Then
        '    Exit Sub
        'End If


        'grid生产计划制定.Rows(0).Cells(ENU_GRID.完成期限).Value = Me.dt总件完成期限.Value


    End Sub

    Private Sub dt小件完成期限_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        'If dt总件完成期限.Value Is Nothing Then
        '    Exit Sub
        'End If

        'If Me.grid生产计划制定.Rows.Count = 0 Then
        '    Exit Sub
        'End If

    End Sub
End Class