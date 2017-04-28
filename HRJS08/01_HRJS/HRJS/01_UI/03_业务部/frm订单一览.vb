Imports HRJS.Constant
Imports System.Text
Imports System.IO
Imports Infragistics.Win.UltraWinGrid
Imports O2S.Components.PDFRender4NET
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class frm订单一览
#Region "常数定義"

    'Public Enum ENU_GRID As Integer
    '    选择 = 0
    '    订单编号 = 1
    '    产品图号 = 2
    'End Enum
    'Public Enum ENU_GRID As Integer

    '    订单编号 = 1
    '    产品图号 = 2
    'End Enum


#End Region

#Region "変数定義"
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Private mDtSearch As DataTable = Nothing
    Private mstr订单编号 As String = String.Empty
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细订单1 As DataTable  'grid详细
    Private mDt详细订单2 As DataTable  'grid详细
    Public intDoubleClick As Integer = 0
    Dim strPath As String = String.Empty

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

    Private Sub frm订单一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm订单一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm订单一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2查询.Focus()
                    btnF2查询_Click(Nothing, Nothing)

                Case Keys.F9
                    btn审核.Focus()
                    btn审核_Click(Nothing, Nothing)

                Case Keys.F10
                    btnF10订单导入.Focus()
                    btnF10订单导入_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11订单导出.Focus()
                    btnF11订单导出_Click(Nothing, Nothing)

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

    Private Sub btnF2查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2查询.Click
        Try

            If Not InputCheck() Then
                Exit Sub
            End If

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
            Me.Selection()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'lxq 2017-04-21 add
    Private Sub btn审核_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn审核.Click
        Dim frmSearch As frm审核

        Dim objM订单表T As New B订单表T

        Dim objBll As New BllM订单表T

        Dim str订单编号 As String = String.Empty
        Dim dt As New DataTable
        Try

            If grdList.Rows.Count = 0 Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If
            If grdList.ActiveRow.Cells Is Nothing Then
                MsgBox("请选择需要审核的数据")
                Exit Sub
            End If

            '获取所有所选择的需要审核的订单编号
            dt = grdList.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows
                If drr("选择") = True Then
                    If str订单编号 = String.Empty Then
                        str订单编号 = drr("订单编号")
                    Else
                        str订单编号 = str订单编号 & "','" & drr("订单编号")
                    End If
                End If
            Next
            objM订单表T.订单编号 = str订单编号
            frmSearch = New frm审核
            'frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = 1 Then


                '获取审核画面数据
                objM订单表T.审核状态 = frmSearch.cmb审核状态.Value
                objM订单表T.审核备注 = frmSearch.txt审核备注.Text
                objM订单表T.审核人 = gObjM_人员T.人员编号

                '判断是否有审核数据
                If frmSearch.cmb审核状态.Value <> String.Empty Then

                    '修改订单表的审核数据

                    If objBll.Update审核数据(objM订单表T) > 0 Then
                        '提示审核成功
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, "审核")
                    End If
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放
                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
                frmSearch = Nothing
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    'lxq 2017-04-21 end

    Private Sub btnF10订单导入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF10订单导入.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            ''订单导入
            ImportData()


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF11订单导出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF11订单导出.Click

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

#End Region

#Region "Grid Event"

    'Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
    '                                       ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs)


    '    Try

    '        '选择処理
    '        Me.Selection()

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub


    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                      ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                      Handles grdList.DoubleClickRow

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

    Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout

        Try
            Dim intLoopi As Integer
            For index = 1 To grdList.DisplayLayout.Bands(0).Columns.Count - 1
                grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Next
            grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
            
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub grdList_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grdList.MouseDown
        Try

            If grdList.ActiveRow Is Nothing Then
                Exit Sub
            End If

            If grdList.ActiveRow.Cells.Count < 15 Then
                Exit Sub
            End If

            strPath = strServerPicturePath & grdList.ActiveRow.Cells("图纸").Value
            If File.Exists(strPath) Then
                If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                    SetPDFPictureBoxImage()
                Else
                    SetPictureBoxImage(Me.pic图纸, strServerPicturePath & grdList.ActiveRow.Cells("图纸").Value)
                End If

            Else
                Me.pic图纸.Image = Nothing
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
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

#Region "产品种类"

    'Private Sub txt产品种类编号_Enter(ByVal sender As Object, ByVal e As EventArgs)

    '    Try

    '        Me.txt产品种类编号.Tag = Me.txt产品种类编号.Text.Trim

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    End Try

    'End Sub

    'Private Sub txt产品种类编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)


    '    Dim frmSearch As frm产品种类一览
    '    Try

    '        frmSearch = New frm产品种类一览
    '        frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

    '        '工程信息查询画面打开
    '        frmSearch.ShowDialog()

    '        '画面数据设置
    '        If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

    '            If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

    '                '根据检索画面数据进行设置

    '                Me.txt产品种类编号.Text = frmSearch.ReturnTable.Rows(0)("产品种类编号")     '客户编号

    '                Me.txt产品种类名称.Text = frmSearch.ReturnTable.Rows(0)("产品种类名称")     '客户名称


    '            End If

    '            If Not frmSearch.ReturnTable Is Nothing Then
    '                '检索画面释放

    '                frmSearch.ReturnTable.Dispose()
    '                frmSearch.ReturnTable = Nothing
    '            End If

    '            '检索画面释放

    '            frmSearch.Dispose()
    '            frmSearch = Nothing

    '        End If

    '        '光标设置
    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        '异常处理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        '默认光标设置
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    'Private Sub txt产品种类编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '    Dim objM产品种类T As M产品种类T
    '    Dim dtM产品种类T As DataTable
    '    Dim objBllM产品种类T As BLLM产品种类T

    '    Try

    '        If txt产品种类编号.ReadOnly Then
    '            Exit Sub
    '        End If


    '        If Me.txt产品种类编号.Text.Trim <> String.Empty Then

    '            If Me.txt产品种类编号.Tag = Me.txt产品种类编号.Text.Trim Then
    '                Exit Sub
    '            End If
    '            objM产品种类T = New M产品种类T

    '            objM产品种类T.产品种类编号 = txt产品种类编号.Text.Trim

    '            objBllM产品种类T = New BLLM产品种类T

    '            dtM产品种类T = objBllM产品种类T.LoadByWhere(objM产品种类T)

    '            If dtM产品种类T.Rows.Count <> 0 Then

    '                Me.txt产品种类名称.Text = dtM产品种类T.Rows(0).Item("产品种类名称").ToString
    '            Else
    '                Me.txt产品种类名称.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID22, "客户名称")
    '                'Me.txt客户编号.Select()
    '            End If
    '        Else
    '            Me.txt产品种类名称.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

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

                    Me.txt产品名称.Text = objM图纸T.品名
                    Me.txt发货日期.Select()
                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "图纸信息")
                    Me.txt产品图号.Text = String.Empty
                    Me.txt产品名称.Text = String.Empty
                    Me.txt产品图号.Select()
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

    Private Sub txt客户编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating

        Dim objM客户T As M客户T
        'Dim dtM客户T As DataTable
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

                If objM客户T.客户名称 <> String.Empty Then
                    Me.txt客户名称.Text = objM客户T.客户名称
                    Me.txt产品图号.Select()
                Else
                    Me.txt客户名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户信息")
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

    'Private Sub txt产品图号_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt产品图号.Validating

    '    Dim objM产品T As M图纸管理T
    '    Dim dtM客户T As DataTable
    '    Dim objBLLM产品T As BLLM图纸管理T
    '    Try

    '        If txt产品图号.ReadOnly Then
    '            Exit Sub
    '        End If
    '        If Me.txt产品图号.Text.Trim <> String.Empty Then
    '            If Me.txt产品图号.Tag = Me.txt产品图号.Text.Trim Then
    '                Exit Sub
    '            End If
    '        End If


    '        If Me.txt产品图号.Text.Trim <> String.Empty Then

    '            objM产品T = New M图纸管理T

    '            objM产品T.产品图号 = txt产品图号.Text.Trim

    '            objBLLM产品T = New BLLM图纸管理T

    '            objM产品T = objBLLM产品T.LoadByPKey(objM产品T)

    '            If objM产品T.产品图号 <> "" Then

    '                Me.txt产品名称.Text = objM产品T.部品名称
    '            Else
    '                Me.txt产品名称.Text = String.Empty
    '                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "部品名称")
    '                'Me.txt产品图号.Select()
    '            End If
    '        Else
    '            Me.txt产品名称.Text = String.Empty
    '        End If

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

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
            '画面のComboの初期値を設定する
            Me.SetCombo()

            SetButtonStatus()

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

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

        Try
            Utility.PFn_SetCombo(Me.cob订单状态, "VM订单状态", 0)
            Utility.PFn_SetCombo(Me.cob订单区分, "VM订单区分", 0)
            Utility.PFn_SetCombo(Me.cob审核状态, "VM审核状态", 0)
            Utility.PFn_SetCombo(Me.cob产品区分, "VM产品区分", 0)
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
            Me.btnF10订单导入.Enabled = Utility.PFn_GetAuth(Me.btnF10订单导入.Tag)
            Me.btnF11订单导出.Enabled = Utility.PFn_GetAuth(Me.btnF11订单导出.Tag)
            Me.btn审核.Enabled = Utility.PFn_GetAuth(Me.btn审核.Tag)
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
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

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try
            Me.txt订单编号.Text = String.Empty
            Me.txt产品发票号.Text = String.Empty
            Me.cob订单状态.Text = String.Empty
            Me.cob产品区分.Text = String.Empty
            'If cob订单状态.Rows.Count > 0 Then
            '    cob订单状态.Rows(0).Selected = True
            'End If
            Me.cob订单区分.Text = String.Empty
            'If cob订单区分.Rows.Count > 0 Then
            '    cob订单区分.Rows(0).Selected = False
            'End If
            Me.cob审核状态.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt产品名称.Text = String.Empty
            'Me.txt产品种类编号.Text = String.Empty
            'Me.txt产品种类名称.Text = String.Empty
            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty

            Me.txt目的港名.Text = String.Empty

            Me.txt发货日期.Text = DateAdd("M", -1, Now)
            Me.txt发货日期2.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.txt到货日期.Text = DateAdd("M", -1, Now)
            Me.txt到货日期2.Text = DateTime.Now.ToString("yyyy/MM/dd")
            Me.pic图纸.Image = Nothing
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

#Region "InitGrid"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid()
        Try

            mDtSearch = New DataTable
            mDtSearch.Columns.Add("选择")
            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("订单区分")
            mDtSearch.Columns.Add("订单状态")
            mDtSearch.Columns.Add("客户名称")
            mDtSearch.Columns.Add("厂内编号")
            mDtSearch.Columns.Add("订单接受日期")
            mDtSearch.Columns.Add("审核状态")
            mDtSearch.Columns.Add("审核人")
            mDtSearch.Columns.Add("审核备注")


            grdList.DataSource = mDtSearch

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

            '必須チェック(MsgID=21) 
            If Not String.IsNullOrEmpty(txt发货日期.Text.Trim) And Not String.IsNullOrEmpty(txt发货日期2.Text.Trim) Then
                If DateTime.Parse(txt发货日期.DateTime) >= DateTime.Parse(txt发货日期2.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "发货日期", "发货日期")
                    txt发货日期.Focus()
                    Return False
                End If
            End If
            If Not String.IsNullOrEmpty(txt到货日期.Text.Trim) And Not String.IsNullOrEmpty(txt到货日期2.Text.Trim) Then
                If DateTime.Parse(txt到货日期.DateTime) >= DateTime.Parse(txt到货日期2.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "到货日期", "到货日期")
                    txt到货日期.Focus()
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

        Dim objM订单表T As B订单表T

        Dim objBLLM订单表T As New BllM订单表T

        Try

            objM订单表T = New B订单表T
            objBLLM订单表T = New BllM订单表T

            If Not IsNothing(Me.cob订单区分.Value) Then
                objM订单表T.订单区分 = Me.cob订单区分.Value
            End If
            'If Not IsNothing(Me.cob审核状态.Text.Trim) Then
            '    objM订单表T.订单区分 = Me.cob订单区分.Value.ToString()
            'End If
            objM订单表T.审核状态 = Me.cob审核状态.Value
            objM订单表T.订单状态 = Me.cob订单状态.Value
            objM订单表T.产品区分 = Me.cob产品区分.Value
            objM订单表T.订单编号 = Me.txt订单编号.Text.Trim
            'objM订单表T.产品种类名称 = Me.txt产品种类名称.Text.Trim

            objM订单表T.产品发票号 = Me.txt产品发票号.Text.Trim
            objM订单表T.目的港名 = Me.txt目的港名.Text.Trim
            objM订单表T.产品图号 = Me.txt产品图号.Text.Trim
            objM订单表T.客户编号 = Me.txt客户编号.Text.Trim

            If (Not Me.txt发货日期.Text.Trim = String.Empty) Then
                objM订单表T.发货日期 = Format(CDate(Me.txt发货日期.Text), "yyyy-MM-dd")
            Else
                objM订单表T.发货日期 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.txt发货日期2.Text.Trim = String.Empty) Then
                objM订单表T.发货日期2 = Format(CDate(Me.txt发货日期2.Text.Trim), "yyyy-MM-dd")
            Else
                objM订单表T.发货日期2 = Constant.CGSTRDATE_DEFAULT
            End If
            If (Not Me.txt到货日期.Text.Trim = String.Empty) Then
                objM订单表T.到货日期 = Format(CDate(Me.txt到货日期.Text.Trim), "yyyy-MM-dd")
            Else
                objM订单表T.到货日期 = Constant.CGSTRDATE_DEFAULT
            End If

            If (Not Me.txt到货日期2.Text.Trim = String.Empty) Then
                objM订单表T.到货日期2 = Format(CDate(Me.txt到货日期2.Text.Trim), "yyyy-MM-dd")
            Else
                objM订单表T.到货日期2 = Constant.CGSTRDATE_DEFAULT
            End If
            If FormOpenMode = Constant.ENU_MODE.Model_Ref Then
                objM订单表T.审核状态 = 2
            End If
            '查询の検索処理


            mDt详细 = New DataSet
            Me.mDt详细订单1 = New DataTable
            mDt详细订单1 = objBLLM订单表T.LoadByWhere(objM订单表T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细订单2 = New DataTable
            mDt详细订单2 = objBLLM订单表T.LoadByWhere1(objM订单表T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细订单1.TableName = "详细订单1"
            mDt详细.Tables.Add(mDt详细订单1)

            mDt详细订单2.TableName = "详细订单2"
            mDt详细.Tables.Add(mDt详细订单2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("订单编号")
            childCols(0) = mDt详细.Tables(1).Columns("订单编号")

            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            Me.grdList.DataSource = mDt详细
            grdList.Refresh()

            mDtSearch = objBLLM订单表T.LoadByWhere(objM订单表T)


            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '    '検索データを表示する
                Me.grdList.DataSource = mDt详细

                '    'フォーカスの設定処理
                Me.txt订单编号.Focus()
            Else

                '    '    '検索データを表示する
                '    Me.grdList.DataSource = mDtSearch

                '    '    For i = 0 To grdList.Rows.Count - 1

                '    '        If DateTime.Parse(grdList.Rows(i).Cells("发货日期").Value.ToString("yyyy/MM/dd")) <= DateTime.Now.AddDays(5) Then

                '    '            grdList.Rows(i).Appearance.ForeColor = Color.Red
                '    '        Else
                '    '            grdList.Rows(i).Appearance.ForeColor = Color.Black
                '    '        End If
                '    '        grdList.UpdateData()
                '    '    Next
                Me.grdList.DataSource = mDt详细
                Me.grdList.Focus()
                Me.grdList.ActiveRow = Me.grdList.Rows(0)
                SetGridStyle()
            End If
            Me.pic图纸.Image = Nothing
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "ImportData"

    Private Sub ImportData()

        Dim filePath = String.Empty
        Dim dialogResult As DialogResult
        Dim ReturnDataTable As DataTable
        Dim objBll As New BllM订单表T

        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "excel工作簿(*.elsx)|*.xlsx|excel97-2003工作簿(*.xls)|*.xls"

        dialogResult = OpenFileDialog.ShowDialog()

        Try


            If dialogResult = Windows.Forms.DialogResult.OK Then
                filePath = OpenFileDialog.FileName
                Dim str = OpenFileDialog.Filter

                If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID37, "订单", filePath) = Constant.ENU_SHOWMSG.showMsgNo Then
                    '処理終了
                    Exit Sub
                End If


                '读取数据到datatable
                ReturnDataTable = Utility.PFn_ExcelToDataTable(filePath)

                If Not ImportCheck(ReturnDataTable) Then
                    Exit Sub
                End If
                '插入数据
                If InsertBatch(ReturnDataTable) > 0 Then

                    '成功メッセージを表示する
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                    Me.DataSearch()
                Else
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID36)
                    Me.txt订单编号.Select()
                    Exit Sub
                End If
                '插入数据
                'If s > 0 Then

                '    '成功メッセージを表示する
                '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)
                '    Me.DataSearch()
                'Else
                '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID36)
                '    Me.txt订单编号.Select()
                '    Exit Sub
                'End If
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
        Dim str订单编号S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try

            If Me.grdList.Rows.Count = 0 Then
                MsgBox("请选择导出信息")
                Exit Sub
            End If

            dt = grdList.DataSource.tables(0)

            For Each drr As DataRow In dt.Rows

                If drr("选择") = True Then

                    If str订单编号S = String.Empty Then
                        str订单编号S = drr("订单编号")
                    Else
                        str订单编号S = str订单编号S & "','" & drr("订单编号")
                    End If
                End If

            Next
            If Me.grdList.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "订单一览") = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            '设置默认路径为当前应用程序根目录
            Me.FolderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory()

            '打开目录选择框
            dialogResult = Me.FolderBrowserDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            '返回选择路径
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\订单一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            'For i = 0 To grdList.Rows.Count - 1

            '    If grdList.Rows(i).Cells("选择").Value = 1 Then

            '        dtReturnTable.ImportRow(Me.mDtSearch.Rows(i))

            '    End If

            'Next
            Dim objBll As New BllM订单表T
            Dim objM订单表T As New B订单表T


            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM订单表T.订单编号 = str订单编号S

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllexp(objM订单表T)

            mDtSearch = ReturnTable

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If Utility.PFn_DataTableToExcel(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "订单一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "订单一览数据导出")
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
#Region "ImportCheck"
    ''' <summary>
    ''' 订单导入检查     ''' </summary>
    ''' <remarks></remarks>
    Private Function ImportCheck(ByVal dtTable As DataTable) As Boolean

        Dim intLoopRows As Integer
        Dim strMsg As New StringBuilder
        Dim objBll订单 As BllM订单表T
        Dim objBll客户 As BLLM客户T
        'Dim objBll图号 As BLLM产品图号T
        Dim objBll人员 As BLLM人员T
        Dim str订单编号S As String = ""
        Dim str厂内编号S As String = ""
        Dim str客户编号S As String = ""
        Dim str产品图号S As String = ""
        Dim str产品区分S As String = ""
        Dim str币种S As String = ""
        Dim str交货方式S As String = ""
        Dim str订单区分S As String = ""
        Dim strMSGS As String = ""
        'Dim hasTable As Hashtable
        Try

            '如果没有数据退出处理          
            If dtTable.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID36, Constant.cgStrNew)
                Return False
            End If


            objBll订单 = New BllM订单表T
            objBll客户 = New BLLM客户T
            'objBll图号 = New BLLM产品图号T
            objBll人员 = New BLLM人员T

            For intLoopRows = 0 To dtTable.Rows.Count - 1

                Dim intLoopj As Integer
                Dim strCheckString As String = ""

                For intLoopj = 0 To dtTable.Columns.Count - 1
                    strCheckString += dtTable.Rows(intLoopRows)(intLoopj).ToString
                Next

                If strCheckString = "" Then
                    Continue For
                End If

                '订单编号
                If Utility.NullToString(dtTable.Rows(intLoopRows)("订单下发日期") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【订单下发日期】不能为空。" & vbCrLf, intLoopRows + 1)

                End If

                If Utility.NullToString(dtTable.Rows(intLoopRows)("客户编号") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【客户编号】不能为空。" & vbCrLf, intLoopRows + 1)

                End If

                '出荷去向
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("机型制造编号")) = "" Then
                '    strMsg.AppendFormat("行：{0}【机型制造编号】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If

                '出荷日期
                If Utility.NullToString(dtTable.Rows(intLoopRows)("产品图番") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【产品图番】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                ''部品番号
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("产品名称")) = "" Then
                '    strMsg.AppendFormat("行：{0}【产品名称】不能为空。" & vbCrLf, intLoopRows + 1)

                'End If
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("品种规格")) = "" Then
                '    strMsg.AppendFormat("行：{0}【品种规格】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("型号")) = "" Then
                '    strMsg.AppendFormat("行：{0}【型号】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If

                '出荷数量
                If Utility.NullToString(dtTable.Rows(intLoopRows)("订货数量") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【订货数量】不能为空。" & vbCrLf, intLoopRows + 1)
                Else
                    If Not IsNumeric(dtTable.Rows(intLoopRows)("订货数量")) Then
                        strMsg.AppendFormat("行：{0}【订货数量】只能输入数字。" & vbCrLf, intLoopRows + 1)
                    End If
                End If

                '出荷日期
                If Utility.NullToString(dtTable.Rows(intLoopRows)("发货日期") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【发货日期】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("到货日期")) = "" Then
                    strMsg.AppendFormat("行：{0}【到货日期】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
              
                If Utility.NullToString(dtTable.Rows(intLoopRows)("订单号") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【订单号】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("厂内编号")) = "" Then
                    strMsg.AppendFormat("行：{0}【厂内编号】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                '取所有订单编号
                If str订单编号S.Contains(dtTable.Rows(intLoopRows)("订单号") & "") = False Then
                    If str订单编号S = "" Then
                        str订单编号S = dtTable.Rows(intLoopRows)("订单号")
                    Else
                        str订单编号S = str订单编号S & "','" & dtTable.Rows(intLoopRows)("订单号")
                    End If
                End If
                If str厂内编号S.Contains(dtTable.Rows(intLoopRows)("厂内编号") & "") = False Then
                    If str厂内编号S = "" Then
                        str厂内编号S = dtTable.Rows(intLoopRows)("厂内编号")
                    Else
                        str厂内编号S = str厂内编号S & "','" & dtTable.Rows(intLoopRows)("厂内编号")
                    End If
                End If
                If str客户编号S.Contains(dtTable.Rows(intLoopRows)("客户编号")) = False Then
                    If str客户编号S = "" Then
                        str客户编号S = dtTable.Rows(intLoopRows)("客户编号")
                    Else
                        str客户编号S = str客户编号S & "','" & dtTable.Rows(intLoopRows)("客户编号")
                    End If
                End If
                'If str产品区分S.Contains(dtTable.Rows(intLoopRows)("产品区分") & "") = False Then
                '    If str产品区分S & "" = "" Then
                '        str产品区分S = dtTable.Rows(intLoopRows)("产品区分")
                '    Else
                '        str产品区分S = "'" & str产品区分S & "','" & dtTable.Rows(intLoopRows)("产品区分") & "'"
                '    End If
                'End If
                If str币种S.Contains(dtTable.Rows(intLoopRows)("币种") & "") = False Then
                    If str币种S = "" Then
                        str币种S = dtTable.Rows(intLoopRows)("币种")
                    Else
                        str币种S = str币种S & "','" & dtTable.Rows(intLoopRows)("币种")
                    End If
                End If

                If str交货方式S.Contains(dtTable.Rows(intLoopRows)("货物成交方式(FOB/CIF)") & "") = False Then
                    If str交货方式S = "" Then
                        str交货方式S = dtTable.Rows(intLoopRows)("货物成交方式(FOB/CIF)")
                    Else
                        str交货方式S = str交货方式S & "','" & dtTable.Rows(intLoopRows)("货物成交方式(FOB/CIF)")
                    End If
                End If
                If str订单区分S.Contains(dtTable.Rows(intLoopRows)("订单区分") & "") = False Then
                    If str订单区分S = "" Then
                        str订单区分S = dtTable.Rows(intLoopRows)("订单区分")
                    Else
                        str订单区分S = str订单区分S & "','" & dtTable.Rows(intLoopRows)("订单区分")
                    End If
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("币种")) = "" Then
                    strMsg.AppendFormat("行：{0}【币种】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("含税单价")) = "" Then
                    strMsg.AppendFormat("行：{0}【含税单价】不能为空。" & vbCrLf, intLoopRows + 1)

                End If
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("不含税单价")) = "" Then
                '    strMsg.AppendFormat("行：{0}【不含税单价】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("含税金额")) = "" Then
                '    strMsg.AppendFormat("行：{0}【含税金额】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If
                'If Utility.NullToString(dtTable.Rows(intLoopRows)("不含税金额")) = "" Then
                '    strMsg.AppendFormat("行：{0}【不含税金额】不能为空。" & vbCrLf, intLoopRows + 1)
                'End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("货物成交方式（FOB/CIF)")) = "" Then
                    strMsg.AppendFormat("行：{0}【货物成交方式（FOB/CIF)】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("货物到达目的港")) = "" Then
                    strMsg.AppendFormat("行：{0}【货物到达目的港】不能为空。" & vbCrLf, intLoopRows + 1)
                End If
                If Utility.NullToString(dtTable.Rows(intLoopRows)("订单区分") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【订单区分】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

                If Utility.NullToString(dtTable.Rows(intLoopRows)("厂内编号") & "") = "" Then
                    strMsg.AppendFormat("行：{0}【厂内编号】不能为空。" & vbCrLf, intLoopRows + 1)
                End If

            Next
            Dim hasTable As New Hashtable

            For index = 0 To dtTable.Rows.Count - 1
                If index = 0 Then
                    hasTable.Add(dtTable.Rows(index)("订单号"), dtTable.Rows(index)("厂内编号"))
                Else
                    If hasTable.ContainsKey(dtTable.Rows(index)("订单号")) Then
                        Dim value As String = hasTable(dtTable.Rows(index)("订单号"))
                        If value = dtTable.Rows(index)("厂内编号") Then

                        Else
                            MsgBox("相同订单编号的厂内编号要相同！！！")
                            Exit Function
                        End If
                    Else
                        If hasTable.ContainsValue(dtTable.Rows(index)("厂内编号") & "") Then
                            MsgBox("厂内编号重复！！！")
                            Exit Function
                        Else
                            hasTable.Add(dtTable.Rows(index)("订单号"), dtTable.Rows(index)("厂内编号"))
                        End If
                    End If
                End If
                    
            Next


            '-------------------------------------------------------判断数据库中存在文档中的订单编号
            Dim objBll As New BllM订单表T
            Dim objM订单表T As New B订单表T
            objM订单表T = New B订单表T

            objM订单表T.订单编号 = str订单编号S
            If objBll.LoadByPKey订单编号1(objM订单表T).订单编号 <> String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "订单编号")
                Me.txt订单编号.Select()
                '処理終了
                Exit Function
            End If

            If str产品区分S <> "" Then
                If Utility.CheckcomboValue("VM产品区分 where  区分 IN('" & str产品区分S & "')", str产品区分S.Split(",").Length) = False Then
                    strMSGS = strMSGS & "输入的产品区分不正确。" & vbCrLf
                End If
            End If



            If str币种S <> "" Then
                If Utility.CheckcomboValue("VM币种 where  区分 IN('" & str币种S & "')", str币种S.Split(",").Length) = False Then
                    strMSGS = strMSGS & "输入的币种不正确。" & vbCrLf
                End If
            End If



            If str交货方式S <> "" Then
                If Utility.CheckcomboValue("VM交货方式 where  区分 IN('" & str交货方式S & "')", str交货方式S.Split(",").Length) = False Then
                    strMSGS = strMSGS & "输入的交货方式不正确。" & vbCrLf
                End If

            End If


            If str订单区分S <> "" Then
                If Utility.CheckcomboValue("VM订单区分 where  区分 IN('" & str订单区分S & "')", str订单区分S.Split(",").Length) = False Then
                    strMSGS = strMSGS & "输入的订单区分不正确。" & vbCrLf
                End If
            End If



            Dim objM客户T As New M客户T
            Dim objBll客户1 As New BLLM客户T
            objM客户T.客户编号 = str客户编号S
            If objBll客户1.CheckByPKey(objM客户T).Rows.Count <> str客户编号S.Split("','").Length Then

                strMSGS = strMSGS & "输入的客户编号不正确。" & vbCrLf
            End If


    



            '-------------------------------------------------------
  
            Dim objM图纸T As New M图纸T
            Dim objBll图纸 As New BLLM图纸T
            'Dim objDalM图纸T As New DalM图纸T
            Dim intCount As Integer
            For intLoopRows = 0 To dtTable.Rows.Count - 1

                Dim intLoopj As Integer
                Dim strCheckString As String = ""

                For intLoopj = 0 To dtTable.Columns.Count - 1
                    strCheckString += dtTable.Rows(intLoopRows)(intLoopj).ToString
                Next

                If strCheckString = "" Then
                    Continue For
                End If
                str产品图号S = dtTable.Rows(intLoopRows)("产品图番")
                objM图纸T.产品图号 = str产品图号S
                If objBll图纸.LoadByPKey产品图号(objM图纸T).产品图号 = String.Empty Then
                    strMSGS = strMSGS & "输入的图号不存在。" & vbCrLf
                End If
            Next
            If strMsg.Length > 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID40, strMsg.ToString)
                Return False
            End If
            If strMSGS <> "" Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID40, strMSGS.ToString)
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

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BllM订单表T
        Dim objM订单表T As New B订单表T

        Try
            '选择行が無い場合
            If Me.grdList.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '查询の选择されたレCDを取得する
            'objM订单T.制造区分 = Me.cbo制造区分.Value

            If intDoubleClick = 1 Then
                If grdList.ActiveRow.Cells.Count < 15 Then
                    MsgBox("请选择图号。")
                    Exit Sub
                Else
                    If Me.grdList.ActiveRow.Cells("审核状态").Value <> "审核通过" Then
                        MsgBox("请选择审核通过的数据。")
                        Exit Sub
                    Else
                        objM订单表T.产品图号 = Me.grdList.ActiveRow.Cells("产品图号").Text.Trim
                    End If
                    'objM订单表T.订单编号 = Me.grdList.ActiveRow.Cells(ENU_GRID1.订单编号).Text.Trim

                End If
            ElseIf intDoubleClick = 2 Then
                If Me.grdList.ActiveRow.Cells.Count < 13 Then
                    If Me.grdList.ActiveRow.Cells("审核状态").Value <> "审核通过" Then
                        MsgBox("请选择审核通过的数据。")
                        Exit Sub
                    End If

                End If
            End If
            objM订单表T.订单编号 = Me.grdList.ActiveRow.Cells("订单编号").Text.Trim

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM订单表T)

            If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
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

    '初始化布局
    'Private Sub grdList_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdList.InitializeLayout
    '    Dim intLoopi As Integer

    '    Try

    '        grdList.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

    '        grdList.DisplayLayout.TabNavigation = TabNavigation.NextControlOnLastCell
    '        grdList.DisplayLayout.Override.AllowAddNew = AllowAddNew.No

    '        For intLoopi = 0 To grdList.DisplayLayout.Bands(0).Columns.Count - 1

    '            If intLoopi = ENU_GRID.出荷数量 Then
    '                grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellActivation = Activation.AllowEdit
    '            Else

    '                grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellActivation = Activation.NoEdit
    '                grdList.DisplayLayout.Bands(0).Columns(intLoopi).TabStop = False
    '                grdList.DisplayLayout.Bands(0).Columns(intLoopi).CellAppearance.BackColor = Color.Gainsboro
    '            End If

    '        Next intLoopi


    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub
    Private Function get客户编号BY客户名称(ByVal str客户名称 As String) As String
        Dim objM客户T As M客户T
        Dim objBLLM客户T As BLLM客户T
        get客户编号BY客户名称 = ""
        Try

            If txt客户编号.ReadOnly Then
                Exit Function
            End If

            If str客户名称 <> String.Empty Then

                objM客户T = New M客户T

                objM客户T.客户名称 = str客户名称

                objBLLM客户T = New BLLM客户T

                objM客户T = objBLLM客户T.get客户编号BY客户名称(objM客户T)

                If objM客户T.客户编号 <> String.Empty Then

                    get客户编号BY客户名称 = objM客户T.客户编号
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



#Region "InsertBatch "

    '插入数据
    Public Function InsertBatch(ByVal obj订单表T As DataTable) As Integer

        Dim objDal订单表T As New DalM订单表T
        Dim objBll订单表T As New BllM订单表T
        Dim ObjDBConn As New DbHelper
        Dim strSql As New StringBuilder
        Dim strSqlCD As String = String.Empty
        Dim intRows As Integer = 0
        Dim clsM订单表T As New B订单表T
        Dim hasTable As New Hashtable
        Try
            If obj订单表T Is Nothing OrElse obj订单表T.Rows.Count = 0 Then
                Return intRows
            End If

            For index = 0 To obj订单表T.Rows.Count - 1
                'Dim clsM订单表T As New B订单表T

                Dim intLoopj As Integer
                Dim strCheckString As String = ""

                For intLoopj = 0 To obj订单表T.Columns.Count - 1
                    strCheckString += obj订单表T.Rows(index)(intLoopj).ToString
                Next

                If strCheckString = "" Then
                    Continue For
                End If
                If index = 0 Then
                    hasTable.Add(obj订单表T.Rows(index)("订单号"), obj订单表T.Rows(index)("订单下发日期"))
                    clsM订单表T.订单接受日期 = Format(obj订单表T.Rows(index)("订单下发日期"), "yyyy-MM-dd")
                Else
                    If hasTable.ContainsKey(obj订单表T.Rows(index)("订单号")) Then
                        Dim value As String = hasTable(obj订单表T.Rows(index)("订单号"))
                        clsM订单表T.订单接受日期 = Format(value, "yyyy-MM-dd")
                    Else
                        hasTable.Add(obj订单表T.Rows(index)("订单号"), obj订单表T.Rows(index)("订单下发日期"))
                        clsM订单表T.订单接受日期 = Format(obj订单表T.Rows(index)("订单下发日期"), "yyyy-MM-dd")
                    End If
                End If
                'clsM订单表T.订单接受日期 = obj订单表T.Rows(index)("订单下发日期").ToString()

                clsM订单表T.客户编号 = get客户编号BY客户名称(obj订单表T.Rows(index)("客户编号").ToString())
                If clsM订单表T.客户编号 = "" Then
                    Dim todu As String = "该客户不存在！"
                    Return intRows
                End If

                clsM订单表T.机型制造编号 = obj订单表T.Rows(index)("机型制造编号").ToString()

                clsM订单表T.产品图号 = obj订单表T.Rows(index)("产品图番").ToString()
                clsM订单表T.产品名称 = obj订单表T.Rows(index)("产品名称").ToString()
                clsM订单表T.品种规格 = obj订单表T.Rows(index)("品种规格").ToString()
                clsM订单表T.型号 = obj订单表T.Rows(index)("型号").ToString()
                clsM订单表T.订单数量 = obj订单表T.Rows(index)("订货数量").ToString()
                'clsM订单表T.投产数量 = obj订单表T.Rows(index)("投产数量").ToString()
                clsM订单表T.发货日期 = Format(obj订单表T.Rows(index)("发货日期"), "yyyy-MM-dd")
                clsM订单表T.备注 = obj订单表T.Rows(index)("备注").ToString()
                clsM订单表T.订单编号 = obj订单表T.Rows(index)("订单号").ToString()
                If objBll订单表T.LoadByPKey订单编号(clsM订单表T).订单编号 <> String.Empty Then
                    MsgBox("订单编号重复！！！")
                    '処理終了
                    ' ClearForm()

                    Exit Function
                End If
                clsM订单表T.产品助记码 = obj订单表T.Rows(index)("产品助记码").ToString()
                clsM订单表T.产品区分 = obj订单表T.Rows(index)("产品区分").ToString()
                clsM订单表T.币种 = obj订单表T.Rows(index)("币种").ToString()
                clsM订单表T.含税单价 = obj订单表T.Rows(index)("含税单价").ToString()
                clsM订单表T.未税单价 = obj订单表T.Rows(index)("不含税单价").ToString()
                clsM订单表T.含税总金额 = obj订单表T.Rows(index)("含税金额").ToString()
                clsM订单表T.未税总金额 = obj订单表T.Rows(index)("不含税金额").ToString()
                clsM订单表T.交货方式 = obj订单表T.Rows(index)("货物成交方式（FOB/CIF)").ToString()
                clsM订单表T.目的港名 = obj订单表T.Rows(index)("货物到达目的港").ToString()
                clsM订单表T.订单区分 = obj订单表T.Rows(index)("订单区分").ToString()
                clsM订单表T.厂内编号 = obj订单表T.Rows(index)("厂内编号").ToString()
                If objBll订单表T.LoadByPKey厂内编号(clsM订单表T).厂内编号 <> String.Empty Then

                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "厂内编号")
                    MsgBox("厂内编号重复！！！")
                    '処理終了
                    'ClearForm()
                    Exit Function

                End If
                clsM订单表T.产品发票号 = obj订单表T.Rows(index)("产品发票号").ToString()


                clsM订单表T.到货日期 = Format(obj订单表T.Rows(index)("到货日期"), "yyyy-MM-dd")
                clsM订单表T.备注 = obj订单表T.Rows(index)("备注").ToString()
                clsM订单表T.审核状态 = "1"
                clsM订单表T.作成者编号 = gObjM_人员T.人员编号
                ' clsM订单表T.登录者 = gObjM_人员T.人员编号
                'clsM订单表T.登录日期 = DateTime.Now
                ' clsM订单表T.客户编号 = obj订单表T.Rows(index)("客户名称").ToString()
                'clsM订单表T.订单区分 = obj订单表T.Rows(index)("订单区分").ToString()
                'clsM订单表T.厂内编号 = obj订单表T.Rows(index)("厂内编号").ToString()
                'clsM订单表T.产品区分 = obj订单表T.Rows(index)("产品区分").ToString()
                'clsM订单表T.产品种类编号 = obj订单表T.Rows(index)("产品种类编号").ToString()
                'clsM订单表T.到货日期 = obj订单表T.Rows(index)("到货日期").ToString()
                'clsM订单表T.作成者编号 = obj订单表T.Rows(index)("作成者编号").ToString()
                'clsM订单表T.交货方式 = obj订单表T.Rows(index)("交货方式").ToString()
                'clsM订单表T.发货日期 = obj订单表T.Rows(index)("发货日期").ToString()
                'clsM订单表T.登录者 = obj订单表T.Rows(index)("作成者编号").ToString()
                'clsM订单表T.登录日期 = DateTime.Now
                'clsM订单表T.审核状态 = obj订单表T.Rows(index)("审核状态").ToString()
                'clsM订单表T.到货日期 = obj订单表T.Rows(index)("审核人").ToString()

                'strSqlCD = objDal订单表T.Get订单编号CD(clsM订单表T)

                'Dim str顺序号 As String
                'str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSqlCD)
                'Dim str As String = clsM订单表T.订单编号 + str顺序号
                'clsM订单表T.订单编号CD = str
                clsM订单表T.订单状态 = 1
                strSql.Append(objDal订单表T.Insert(clsM订单表T))
            Next
            intRows = ObjDBConn.PFn_ExcuteDB(strSql.ToString)

            ObjDBConn.PSb_CloseDB()

            Return intRows


        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception("InsertBatch", ex)
        End Try

    End Function

#End Region
#Region "SetGridStyle"

    Private Sub SetGridStyle()
        Try
            With grdList.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
            End With

            With grdList.DisplayLayout.Bands(1)
                If grdList.DisplayLayout.Bands(1) Is Nothing Then
                    Exit Sub
                Else
                    .Columns("订单编号").Hidden = True
                    .Columns("发货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("到货日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                    .Columns("发货日期").CellActivation = Activation.NoEdit
                    .Columns("到货日期").CellActivation = Activation.NoEdit

                    .Columns("订单数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    .Columns("图纸").Hidden = True
                    .Columns("审核状态").Hidden = True
                    '.Columns("高").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("税率").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                    '.Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If
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
End Class