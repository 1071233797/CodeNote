Imports HRJS.Constant
Imports UserControl
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Text
Imports Infragistics.Win.UltraWinGrid
Imports O2S.Components.PDFRender4NET
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frm图纸信息一览#Region "常数定義"

    Public Enum ENU_GRID As Integer
        图纸信息编号 = 0
        图纸信息名称 = 1

    End Enum
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
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    'Private mDtSearch As DataTable = Nothing
    Dim mDt详细图纸主数据 As DataTable  'grid详细
    Private mDtSearch As DataTable = Nothing
    Public mstr产品图号 As String = String.Empty
    Public bol订单 As Boolean = False
    Dim strPath As String = String.Empty
    Public Property 产品图号() As String
        Get
            Return mstr产品图号
        End Get
        Set(ByVal Value As String)
            mstr产品图号 = Value
        End Set
    End Property
#End Region

#Region "Form Event"

    Private Sub frm图纸信息一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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
    Private Sub frm图纸信息一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frm图纸信息一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

#End Region

#Region "Control Event"

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
            'InitGrid()
            Me.pic图纸.Image = Nothing

            If Not Me.grid图纸.DataSource Is Nothing AndAlso Me.grid图纸.DataSource.tables(0).rows.count > 0 Then
                Me.grid图纸.DataSource.clear()
            End If

            'Me.grid图纸.DataSource.clear()
            'Me.grid图纸Info.DataSource.clear()
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

                    '根据检索画面数据进行设置                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
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

    Private Sub txt客户编号_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txt客户编号.Leave
        Dim objM客户T As M客户T
        Dim objBLLM客户T As BLLM客户T

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

                objBLLM客户T = New BLLM客户T

                objM客户T = objBLLM客户T.LoadByPKey(objM客户T)

                If objM客户T.客户名称 <> String.Empty Then

                    Me.txt客户名称.Text = objM客户T.客户名称
                Else

                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
                    'Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    Me.txt客户编号.Select()
                End If
            Else
                Me.txt客户编号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub txt客户编号_BeforeEditorButtonCheckStateChanged(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.BeforeCheckStateChangedEventArgs) Handles txt客户编号.BeforeEditorButtonCheckStateChanged
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")     '客户编号

                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")     '客户名称
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
                    frmSearch.ReturnTable = Nothing
                End If

                '检索画面释放                frmSearch.Dispose()
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

#Region "Grid Event"

    Private Sub grid图纸_DoubleClickRow(ByVal sender As System.Object, _
                                           ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                           Handles grid图纸.DoubleClickRow

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


    Private Sub grid图纸_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid图纸.InitializeLayout

        Try

            grid图纸.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            grid图纸.DisplayLayout.Bands(0).Columns(0).CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub grid图纸_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grid图纸.MouseDown
        Try

            If Me.grid图纸.ActiveRow Is Nothing Then
                Exit Sub
            End If
            Try
                If File.Exists(strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value) Then
                    If Path.GetExtension(strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value).ToUpper = ".PDF" Then
                        strPath = strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value
                        SetPDFPictureBoxImage()
                    Else
                        SetPictureBoxImage(Me.pic图纸, strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value)
                    End If
                Else
                    Me.pic图纸.Image = Nothing
                End If
            Catch ex As Exception
            End Try


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grid图纸_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles grid图纸.KeyDown
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

    Private Sub btn图纸目录导出_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn图纸目录导出.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            ''订单导入
            ExportData2()


        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

        'Dim dialogResult As DialogResult
        'Dim fileFullName As String = ""

        'Dim strExt As String = ".xlsx"
        'Try

        '    If Me.grid图纸.Rows.Count = 0 Then
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
        '        Exit Sub
        '    End If

        '    If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "图纸目录") = Constant.ENU_SHOWMSG.showMsgNo Then
        '        '処理終了
        '        Exit Sub
        '    End If


        '    '设置默认路径为当前应用程序根目录
        '    Me.FolderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory()

        '    '打开目录选择框
        '    dialogResult = Me.FolderBrowserDialog.ShowDialog()

        '    If dialogResult = Windows.Forms.DialogResult.Cancel Then
        '        Exit Sub
        '    End If

        '    '返回选择路径
        '    fileFullName = Me.FolderBrowserDialog.SelectedPath & "\图纸目录导出 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

        '    If mDt详细图纸主数据 Is Nothing OrElse mDt详细图纸主数据.Rows.Count = 0 Then

        '        Me.Cursor = Cursors.Default

        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
        '        Exit Sub
        '    End If

        '    Dim dtInfo As New DataTable
        '    Dim drInfo As DataRow
        '    Dim drSearch As DataRow()
        '    Dim dvSearch As DataView
        '    dtInfo.Columns.Add("总图号")
        '    dtInfo.Columns.Add("分图号")
        '    dtInfo.Columns.Add("小分图号")
        '    dtInfo.Columns.Add("小小分图号")
        '    dtInfo.Columns.Add("最小分图号")
        '    dtInfo.Columns.Add("[件/套]")
        '    dtInfo.Columns.Add("备注")
        '    drSearch = mDt详细图纸主数据.Select("上级图号 is NUll")
        '    dvSearch = New DataView(mDt详细图纸主数据)

        '    For Each dr As DataRow In drSearch
        '        drInfo = mDt详细图纸主数据.NewRow
        '        drInfo("总图号") = dr("产品图号")
        '        dtInfo.Rows.Add(drInfo)
        '    Next


        '    'For Each dr As DataRow In mDt详细图纸主数据.Rows

        '    'Next
        '    'Utility.PFn_DataTableToExcel(mDt详细图纸主数据, fileFullName) = DataTable
        '    'If Not ImportCheck(DataTable) Then
        '    '    Exit Sub
        '    'End If

        '    ''插入数据
        '    ' InsertBatch(DataTable) > 0 


        '    If Utility.PFn_DataTableToExcel(mDt详细图纸主数据, fileFullName) Then
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "图纸目录")
        '    Else
        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "图纸目录数据导出")
        '    End If

        'Catch ex As Exception

        'End Try
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
            Me.SetCombo()

            'Grid初始化
            'Me.InitGrid()
            SetButtonStatus()
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

#Region "SetCombo"

    'Private Sub SetCombo()

    '    Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル

    '    Try

    '        '制限件数コンボボックス
    '        Utility.SetCombo图纸信息(Me.cob图纸信息类别, "M图纸信息类别")

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "ClearForm"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearForm()
        Try

            txt产品图号.Text = mstr产品图号
            txt品名.Text = String.Empty
            txt客户编号.Text = String.Empty
            txt客户名称.Text = String.Empty
            Me.cob查询行数.Value = 1
            Me.cob图纸状态.Text = String.Empty
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

#Region "'SetPermission"
    ''' <summary>
    ''' 権限の制御処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPermission()
        Try

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btn图纸目录导出.Enabled = Utility.PFn_GetAuth(Me.btn图纸目录导出.Tag)

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
            '使用状态            Utility.PFn_SetCombo(Me.cob查询行数, "VM查询行数", 0)
            Utility.PFn_SetCombo(Me.cob图纸状态, "VM图纸状态", 1)
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

        Dim objBll As New BLLM图纸T
        Dim objM图纸信息T As New M图纸T

        Try
            '一览打开, 不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '选择行が無い場合
            If Me.grid图纸.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If


            '查询の选择されたレCDを取得する
            If bol订单 Then
                objM图纸信息T.产品图号 = Me.grid图纸.ActiveRow.Cells("主图号").Text.Trim
            Else
                objM图纸信息T.产品图号 = Me.grid图纸.ActiveRow.Cells("产品图号").Text.Trim
            End If



            'テーブルにデータを追加
            ReturnTable = objBll.LoadAll(objM图纸信息T)

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

#Region "DataSearch"

    Private Sub DataSearch()


        Dim mDt详细 As DataSet  'grid详细
        Dim mDt详细图纸主数据 As DataTable  'grid详细
        Dim mDt详细图纸1 As New DataTable
        Dim mDt详细图纸2 As DataTable  'grid详细
        Dim mDt详细图纸3 As DataTable  'grid详细
        Dim mDt详细图纸4 As DataTable  'grid详细
        Dim mDt详细图纸5 As DataTable  'grid详细
        Dim dv As New DataView

        'Dim dt二级图纸 As New DataTable


        Dim objM图纸T As M图纸T
        Dim objBLLM图纸T As New BLLM图纸T

        Try
            objM图纸T = New M图纸T
            objM图纸T.产品图号 = Me.txt产品图号.Text.Trim
            objM图纸T.品名 = Me.txt品名.Text.Trim
            objM图纸T.客户编号 = Me.txt客户编号.Text.Trim

            If Me.cob图纸状态.Value & "" <> "" Then
                objM图纸T.图纸状态 = Me.cob图纸状态.Value
            End If


            Me.grid图纸.DataSource = Nothing

            mDt详细 = New DataSet
            mDt详细图纸主数据 = New DataTable
            mDt详细图纸主数据 = objBLLM图纸T.LoadByWhere2(objM图纸T, Me.cob查询行数.Text)
            'dv = mDt详细图纸主数据.DefaultView
            mDt详细图纸1 = mDt详细图纸主数据.Clone
            For Each dr As DataRow In mDt详细图纸主数据.Rows
                If dr("上级图号") & "" = "" Then
                    mDt详细图纸1.Rows.Add(dr.ItemArray)
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
            mDt详细图纸2 = mDt详细图纸主数据.Copy
            mDt详细图纸3 = mDt详细图纸主数据.Copy
            mDt详细图纸4 = mDt详细图纸主数据.Copy
            mDt详细图纸5 = mDt详细图纸主数据.Copy
            'mDt详细图纸2 = objBLLM图纸T.LoadByWhere2(objM图纸T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(4) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细图纸1.TableName = "详细图纸1"
            mDt详细.Tables.Add(mDt详细图纸1)
            mDt详细图纸2.TableName = "详细图纸2"
            mDt详细.Tables.Add(mDt详细图纸2)
            mDt详细图纸3.TableName = "详细图纸3"
            mDt详细.Tables.Add(mDt详细图纸3)
            mDt详细图纸4.TableName = "详细图纸4"
            mDt详细.Tables.Add(mDt详细图纸4)
            mDt详细图纸5.TableName = "详细图纸5"
            mDt详细.Tables.Add(mDt详细图纸5)

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mDt详细.Tables(0).Columns("主图号")
            childCols(0) = mDt详细.Tables(1).Columns("主图号")
            parentCols(1) = mDt详细.Tables(0).Columns("产品图号")
            childCols(1) = mDt详细.Tables(1).Columns("上级图号")

            drBand(0) = New DataRelation("1階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mDt详细.Tables(1).Columns("主图号")
            childCols(0) = mDt详细.Tables(2).Columns("主图号")
            parentCols(1) = mDt详细.Tables(1).Columns("产品图号")
            childCols(1) = mDt详细.Tables(2).Columns("上级图号")

            drBand(1) = New DataRelation("2階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(1))

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mDt详细.Tables(2).Columns("主图号")
            childCols(0) = mDt详细.Tables(3).Columns("主图号")
            parentCols(1) = mDt详细.Tables(2).Columns("产品图号")
            childCols(1) = mDt详细.Tables(3).Columns("上级图号")

            drBand(2) = New DataRelation("3階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(2))

            ReDim parentCols(1)
            ReDim childCols(1)
            parentCols(0) = mDt详细.Tables(3).Columns("主图号")
            childCols(0) = mDt详细.Tables(4).Columns("主图号")
            parentCols(1) = mDt详细.Tables(3).Columns("产品图号")
            childCols(1) = mDt详细.Tables(4).Columns("上级图号")

            drBand(3) = New DataRelation("4階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(3))

            Me.grid图纸.DataSource = mDt详细
            grid图纸.Refresh()
            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grid图纸.PClear()
                '検索データを表示する
                Me.grid图纸.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else
                '検索データを表示する
                Me.grid图纸.DataSource = mDt详细
                Me.grid图纸.Focus()
                Me.grid图纸.ActiveRow = Me.grid图纸.Rows(0)
                SetGridStyle图纸()
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try


        'Dim mDt详细 As DataSet  'grid详细
        'Dim mDt详细图纸1 As DataTable  'grid详细
        'Dim mDt详细图纸2 As DataTable  'grid详细


        'Dim objM图纸T As M图纸T
        'Dim objBLLM图纸T As New BLLM图纸T

        'Try
        '    objM图纸T = New M图纸T
        '    objM图纸T.产品图号 = Me.txt产品图号.Text.Trim
        '    objM图纸T.品名 = Me.txt品名.Text.Trim
        '    objM图纸T.客户编号 = Me.txt客户编号.Text.Trim

        '    Me.grid图纸.DataSource = Nothing

        '    mDt详细 = New DataSet
        '    mDt详细图纸1 = New DataTable
        '    mDt详细图纸1 = objBLLM图纸T.LoadByWhere2(objM图纸T)

        '    'mdt详细Band1データを記録テーブル初期化
        '    mDt详细图纸2 = New DataTable
        '    mDt详细图纸2 = objBLLM图纸T.LoadByWhere2(objM图纸T)

        '    Dim parentCols() As DataColumn
        '    Dim childCols() As DataColumn
        '    Dim drBand(2) As DataRelation

        '    mDt详细 = New DataSet
        '    'DataSetの親子関係を設定
        '    mDt详细.Relations.Clear()

        '    '親、子のテーブルを追加
        '    mDt详细图纸1.TableName = "详细图纸1"
        '    mDt详细.Tables.Add(mDt详细图纸1)

        '    mDt详细图纸2.TableName = "详细图纸2"
        '    mDt详细.Tables.Add(mDt详细图纸2)

        '    ReDim parentCols(1)
        '    ReDim childCols(1)
        '    parentCols(1) = mDt详细.Tables(0).Columns("产品图号")
        '    childCols(1) = mDt详细.Tables(1).Columns("上级图号")

        '    drBand(0) = New DataRelation("階層", parentCols, childCols, False)
        '    mDt详细.Relations.Add(drBand(0))

        '    Me.grid图纸.DataSource = mDt详细
        '    grid图纸.Refresh()


        '    If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

        '        '結果０件ＭＳＧ出力
        '        'メッセージCD：211
        '        Me.Cursor = Cursors.Default

        '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

        '        ''查询Gridの初期化
        '        'Me.grid图纸.PClear()
        '        '検索データを表示する
        '        Me.grid图纸.DataSource = mDt详细

        '        'フォーカスの設定処理
        '        Me.txt产品图号.Focus()
        '    Else
        '        '検索データを表示する
        '        Me.grid图纸.DataSource = mDt详细
        '        Me.grid图纸.Focus()
        '        Me.grid图纸.ActiveRow = Me.grid图纸.Rows(0)
        '    End If

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
                Me.btn耗料表打印.Visible = False

            Case Else
                Me.btnF3选择.Visible = True
                Me.btn耗料表打印.Visible = False
        End Select
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
    End Sub

    Friend Sub GetScaleZoomRect(ByVal nSrcWidth As Integer, ByVal nSrcHeight As Integer, ByRef nDstWidth As Integer, ByRef nDstHeight As Integer)
        If nSrcWidth / nSrcHeight < nDstWidth / nDstHeight Then
            nDstWidth = nDstHeight * (nSrcWidth / nSrcHeight)
        Else
            nDstHeight = nDstWidth * (nSrcHeight / nSrcWidth)
        End If
    End Sub

#End Region

#Region "SetGridStyle"

    Private Sub SetGridStyle图纸()
        Try

            With grid图纸.DisplayLayout.Bands(0)
                .Columns("选择").Style = ColumnStyle.CheckBox
                .Columns("选择").CellActivation = Activation.AllowEdit
                .Columns("图纸").Hidden = True
                .Columns("orderId").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("主图号").Hidden = True
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("入库日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                '.Columns("数量（个）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("重量（kg）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '.Columns("含税单价").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With
            With grid图纸.DisplayLayout.Bands(1)
                .Columns("选择").Hidden = True
                .Columns("图纸").Hidden = True
                .Columns("orderId").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("主图号").Hidden = True
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With

            With grid图纸.DisplayLayout.Bands(2)
                .Columns("选择").Hidden = True
                .Columns("图纸").Hidden = True
                .Columns("orderId").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("主图号").Hidden = True
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With

            With grid图纸.DisplayLayout.Bands(3)
                .Columns("选择").Hidden = True
                .Columns("图纸").Hidden = True
                .Columns("orderId").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("主图号").Hidden = True
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            End With


            With grid图纸.DisplayLayout.Bands(4)
                .Columns("选择").Hidden = True
                .Columns("图纸").Hidden = True
                .Columns("orderId").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("主图号").Hidden = True
                .Columns("数量（每套）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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


    Private Sub btn耗料表打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn耗料表打印.Click
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
#Region "ExportData"
    Private Sub ExportData()


        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim str产品图号S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try

            If Me.grid图纸.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If


            dt = grid图纸.DataSource.tables(0)
            str产品图号S = String.Empty
            For Each drr As DataRow In dt.Rows
                If drr("选择") = True Then
                    If str产品图号S = String.Empty Then
                        str产品图号S = drr("产品图号")

                    Else
                        str产品图号S = str产品图号S & "','" & drr("产品图号")

                    End If
                End If
            Next

            If str产品图号S = String.Empty Then
                MsgBox("请选择打印信息！")
                Exit Sub
            End If


            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "图纸信息一览") = Constant.ENU_SHOWMSG.showMsgNo Then
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
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\耗料表一览 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            'For i = 0 To grdList.Rows.Count - 1

            '    If grdList.Rows(i).Cells("选择").Value = 1 Then

            '        dtReturnTable.ImportRow(Me.mDtSearch.Rows(i))

            '    End If

            'Next
            Dim objBll As New BLLM图纸T
            Dim objM图纸信息T As New M图纸T

            '选择行が無い場合
            If Me.grid图纸.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM图纸信息T.产品图号 = str产品图号S

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllexp(objM图纸信息T)

            mDtSearch = ReturnTable

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If



            If PFn_DataTableToExcel1(mDtSearch, fileFullName) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "图纸信息一览")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "耗料表导出")
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
#Region "ExportData2"
    Private Sub ExportData2()
        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim strExt As String = ".xlsx"
        Dim str产品图号S As String = String.Empty
        Dim ReturnDataTable As DataTable
        Dim dt As New DataTable
        Try
            If Me.grid图纸.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If
            str产品图号S = String.Empty
            dt = grid图纸.DataSource.tables(0)
            For Each drr As DataRow In dt.Rows
                If drr("选择") = True Then
                    If str产品图号S = String.Empty Then
                        str产品图号S = drr("产品图号")

                    Else
                        str产品图号S = str产品图号S & "','" & drr("产品图号")

                    End If
                End If
            Next
            If str产品图号S = String.Empty Then
                MsgBox("请选择打印信息！")
                Exit Sub
            End If


            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "图纸目录") = Constant.ENU_SHOWMSG.showMsgNo Then
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
            fileFullName = Me.FolderBrowserDialog.SelectedPath & "\图纸目录导出 " & Format(Now(), "yyyy-MM-dd H-mm-ss ffff") & strExt

            'For i = 0 To grdList.Rows.Count - 1

            '    If grdList.Rows(i).Cells("选择").Value = 1 Then

            '        dtReturnTable.ImportRow(Me.mDtSearch.Rows(i))

            '    End If

            'Next
            Dim objBll As New BLLM图纸T
            Dim objM图纸信息T As New M图纸T

            '选择行が無い場合
            If Me.grid图纸.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM图纸信息T.产品图号 = str产品图号S

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllexp2(objM图纸信息T)

            mDtSearch = ReturnTable

            If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If PFn_DataTableToExcel2(mDtSearch, fileFullName, Me.grid图纸.ActiveRow.Cells("品名").Text.Trim) Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "图纸目录")
            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "图纸目录数据导出")
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

    Public Shared Function PFn_DataTableToExcel1(ByVal Table As DataTable, ByVal FileName As String) As Boolean

        Dim oExcel As New Excel.Application

        Dim obook As Excel.Workbook

        Dim oSheet As Excel.Worksheet

        Dim rowIndex, colIndex As Integer
        Try

            obook = oExcel.Workbooks.Add '(Directory.GetCurrentDirectory() & "\Templates\Template_Export.xlsx")

            oSheet = obook.Worksheets(1)

            'oSheet.Name = SheetName

            Dim r As Integer, c As Integer

            Dim rCount As Integer

            Dim cCount As Integer

            rCount = Table.Rows.Count

            cCount = Table.Columns.Count()

            For c = 1 To cCount

                oSheet.Cells(3, c) = Table.Columns(c - 1).Caption '设置列标题

            Next

            c = 0 : r = 0

            For r = 1 To rCount

                For c = 1 To cCount

                    oSheet.Columns(c).EntireColumn.NumberFormatLocal = "@"
                    oSheet.Cells(r + 5, c) = CStr(Table.Rows(r - 1)(c - 1).ToString)

                Next
                oSheet.Columns.EntireColumn.AutoFit() '列宽自适应。
                oSheet.Range("A1:D1").Merge()
                oSheet.Range("E1:O1").Merge()
                'oSheet.Range("AB1:AC1").Merge()
                oSheet.Range("A2:D2").Merge()
                oSheet.Range("E2:O2").Merge()
                'oSheet.Range("AB2:AC2").Merge()
                oSheet.Range("A3:A5").Merge()
                oSheet.Range("B3:B5").Merge()
                oSheet.Range("C3:C5").Merge()
                oSheet.Range("D3:D5").Merge()
                oSheet.Range("E3:E5").Merge()
                oSheet.Range("I3:I5").Merge()
                oSheet.Range("F3:F5").Merge()
                oSheet.Range("G3:G5").Merge()
                oSheet.Range("H3:H5").Merge()
                oSheet.Range("N3:N5").Merge()
                oSheet.Range("O3:O5").Merge()
                'oSheet.Range("AB3:AB5").Merge()
                'oSheet.Range("AC3:AC5").Merge()
                oSheet.Range("J3:J5").Merge()
                oSheet.Range("K3:K5").Merge()
                oSheet.Range("M3:M5").Merge()
                oSheet.Range("L3:L5").Merge()
                oSheet.Range("P3:P5").Merge()
                oSheet.Range("Q3:Q5").Merge()

                With oSheet
                    .Columns.EntireColumn.AutoFit()
                    .Range("E1:O1").HorizontalAlignment = Excel.Constants.xlCenter
                    .Range("E1:O1").Font.Size = 12
                    .Range("E1:O1").Font.Name = "宋体"
                    .Range("E1:O1").Font.Bold = True
                    .Range("E1:O1").Cells.Value = "大连华日金属成型厂"
                    .Range("E2:O2").HorizontalAlignment = Excel.Constants.xlCenter
                    .Range("E2:O2").Font.Size = 15
                    .Range("E2:O2").Font.Name = "宋体"
                    .Range("E2:O2").Font.Bold = True
                    .Range("E2:O2").Cells.Value = "产品材料消耗统计表"
                End With

            Next

            obook.Saved = True
            obook.SaveCopyAs(FileName)

            Return True

        Catch ex As Exception

            Return False
        Finally

            oExcel = Nothing
            obook = Nothing
            oSheet = Nothing
        End Try

    End Function
    Public Shared Function PFn_DataTableToExcel2(ByVal Table As DataTable, ByVal FileName As String, ByVal str品名 As String) As Boolean

        Dim xlApp As New Excel.Application

        Dim xlbook As Excel.Workbook

        Dim xlSheet As Excel.Worksheet

        Dim rowIndex, colIndex As Integer
        Dim dt As New DataTable

        dt.Columns.Add("一层")
        dt.Columns.Add("二层")
        dt.Columns.Add("三层")
        dt.Columns.Add("四层")
        dt.Columns.Add("五层")
        Dim dr As DataRow = dt.NewRow
        dt.Rows.Add(dr)
        Try

            xlbook = xlApp.Workbooks.Add '(Directory.GetCurrentDirectory() & "\Templates\Template_Export.xlsx")

            xlSheet = xlbook.Worksheets(1)

            'oSheet.Name = SheetName

            Dim r As Integer, c As Integer

            Dim rCount As Integer

            Dim cCount As Integer

            rCount = Table.Rows.Count

            cCount = Table.Columns.Count()

            For c = 1 To cCount

                xlSheet.Cells(2, c) = Table.Columns(c - 1).Caption '设置列标题

            Next

            c = 0 : r = 0
            Dim intNO As Integer = 0
            For r = 1 To rCount

                For c = 1 To cCount

                    xlSheet.Columns(c).EntireColumn.NumberFormatLocal = "@"

                    Select Case Table.Columns(c - 1).ColumnName
                        Case "主图号", "分图号", "小分图号", "小小分图号", "最小分图号"
                            If dt.Rows(0)(c - 2) & "" <> CStr(Table.Rows(r - 1)(c - 1).ToString) & "" Then
                                dt.Rows(0)(c - 2) = CStr(Table.Rows(r - 1)(c - 1).ToString)
                                xlSheet.Cells(r + 2, c) = CStr(Table.Rows(r - 1)(c - 1).ToString)
                            End If
                        Case "序号"
                            intNO = intNO + 1
                            xlSheet.Cells(r + 2, c) = intNO
                        Case Else
                            xlSheet.Cells(r + 2, c) = CStr(Table.Rows(r - 1)(c - 1).ToString)

                    End Select


                Next
                xlSheet.Columns.EntireColumn.AutoFit() '列宽自适应。
                xlSheet.Range("A1:H1").Merge()

                With xlSheet
                    .Columns.EntireColumn.AutoFit()
                    .Range("A1:H1").HorizontalAlignment = Excel.Constants.xlCenter
                    .Range("A1:H1").Font.Size = 20
                    .Range("A1:H1").Font.Name = "宋体"
                    .Range("A1:H1").Font.Bold = True
                    .Range("A1:H1").Cells.Value = str品名

                    '.Range("E2:O2").HorizontalAlignment = Excel.Constants.xlCenter
                    '.Range("E2:O2").Font.Size = 15
                    '.Range("E2:O2").Font.Name = "宋体"
                    '.Range("E2:O2").Font.Bold = True
                    '.Range("E2:O2").Cells.Value = "产品材料消耗统计表"
                End With

            Next

            xlbook.Saved = True
            xlbook.SaveCopyAs(FileName)

            Return True

        Catch ex As Exception

            Return False
        Finally

            xlApp = Nothing
            xlbook = Nothing
            xlSheet = Nothing
        End Try

    End Function
    Public Sub SetPDFPictureBoxImage()
        Try
            Dim pageImage As Bitmap = ConvertPDF2Image(strServerPicturePath, Definition.One)
            Dim bmp As New Bitmap(Me.pic图纸.Width, Me.pic图纸.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)

            Dim img As Image = pageImage
            Dim rectImage As New Rectangle(0, 0, bmp.Width, bmp.Height)
            '按比例缩放
            GetScaleZoomRect(img.Width, img.Height, rectImage.Width, rectImage.Height)
            g.DrawImage(img, rectImage)

            Me.pic图纸.Image = bmp

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Public Function ConvertPDF2Image(ByVal pdfInputPath As String, ByVal definition As Definition) As Bitmap

        Dim pdfFile1 As PDFFile = PDFFile.Open(strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value)

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
End Class