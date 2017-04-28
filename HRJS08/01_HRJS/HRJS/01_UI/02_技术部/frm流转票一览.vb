Imports System.IO
Imports Infragistics.Win.UltraWinGrid
Imports Microsoft.Office.Interop
Imports HRJS.Constant
Imports O2S.Components.PDFRender4NET

Public Class frm流转票一览

#Region "常数定義"

    Public Enum ENU_GRID As Integer
        产品图号 = 0
    End Enum

#End Region

#Region "変数定義"
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("CirculationPath")
    Dim strSamplePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("SamplePath")
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细
    Public mstr产品图号 As String = String.Empty
    Dim strPath As String


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

    Private Sub frm流转票信息一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm流转票信息一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm流转票信息一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

#Region "Button Event"

    Private Sub btnF1清空_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF1清空.Click
        Try
            '清空画面对话框            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
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


            '关闭画面对话框()

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

            ''If Not InputCheck() Then
            ''    Exit Sub
            ''End If

            '砂時計のカーソルが設定
            Me.Cursor = Cursors.WaitCursor
            ClearForm()
            '検索を実行            DataSearch()

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

    Private Sub grid图纸_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid图纸.MouseDown
        Me.Cursor = Cursors.WaitCursor

        If Me.grid图纸.ActiveRow Is Nothing Then
            Exit Sub
        End If
        strPath = strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value
        If File.Exists(strPath) Then
            If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                SetPDFPictureBoxImage()
            Else
                SetPictureBoxImage(Me.pic图纸, strServerPicturePath & grid图纸.ActiveRow.Cells("图纸").Value)
            End If

        Else
            Me.pic图纸.Image = Nothing
        End If
        '検索を実行        DataSearchInfo()

    End Sub
#End Region


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
    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                      ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                      Handles grid流转票信息一览.DoubleClickRow

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


#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try

            'Grid初始化            SetCombo()
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
            '使用状态            Utility.PFn_SetCombo(Me.cob查询行数, "VM查询行数", 0)
            Utility.PFn_SetCombo(Me.cob图纸状态, "VM图纸状态", 0)
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
            Me.btn流转票导出.Enabled = Utility.PFn_GetAuth(Me.btn流转票导出.Tag)

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
            Me.txt产品图号.Text = mstr产品图号
            Me.txt品名.Text = String.Empty
            grid图纸.DataSource = Nothing
            Me.cob查询行数.Value = 1
            Me.cob图纸状态.Text = String.Empty
            Me.pic图纸.Image = Nothing
            grid流转票信息一览.DataSource = Nothing
            Me.txt产品图号.Select()
            InitGrid()

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


            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("品名")
            mDtSearch.Columns.Add("图纸状态")

            grid流转票信息一览.DataSource = mDtSearch
            grid图纸.DataSource = mDtSearch
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

            If Me.txt产品图号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                txt产品图号.Focus()
                Return False
            End If
            If Me.txt品名.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品名", "品名")
                txt品名.Focus()
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

#Region "DataSearch"

    Private Sub DataSearchInfo()

        Dim objM流转票T As M流转票管理T

        Dim objBLLM流转票T As New BllM流转票管理T

        Try
            objM流转票T = New M流转票管理T
            objM流转票T.产品图号 = Me.grid图纸.ActiveRow.Cells("产品图号").Value
            objM流转票T.品名 = Me.grid图纸.ActiveRow.Cells("品名").Value
            Me.grid流转票信息一览.DataSource = Nothing

            mDt详细 = New DataSet
            Me.mDt详细图纸1 = New DataTable
            mDt详细图纸1 = objBLLM流转票T.LoadAllGrid1(objM流转票T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细图纸2 = New DataTable
            mDt详细图纸2 = objBLLM流转票T.LoadAllGrid2(objM流转票T)

            Dim parentCols() As DataColumn
            Dim childCols() As DataColumn
            Dim drBand(2) As DataRelation

            mDt详细 = New DataSet
            'DataSetの親子関係を設定
            mDt详细.Relations.Clear()

            '親、子のテーブルを追加
            mDt详细图纸1.TableName = "详细图纸1"
            mDt详细.Tables.Add(mDt详细图纸1)

            mDt详细图纸2.TableName = "详细图纸2"
            mDt详细.Tables.Add(mDt详细图纸2)

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("产品图号")
            childCols(0) = mDt详细.Tables(1).Columns("产品图号")

            drBand(0) = New DataRelation("階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            Me.grid流转票信息一览.DataSource = mDt详细
            grid流转票信息一览.Refresh()


            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid流转票信息一览.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else
                '検索データを表示する
                Me.grid流转票信息一览.DataSource = mDt详细
                Me.grid流转票信息一览.Focus()
                Me.grid流转票信息一览.ActiveRow = Me.grid流转票信息一览.Rows(0)
                SetGridStyle流转票Info()
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

#Region "Selection"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Selection()

        Dim objBll As New BllM流转票管理T
        Dim objM流转票T As New M流转票管理T

        Try
            '一览打开, 不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If
            '选择行が無い場合
            If Me.grid流转票信息一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM流转票T.产品图号 = Me.grid流转票信息一览.ActiveRow.Cells("产品图号").Text.Trim

            'If Me.grid流转票信息一览.ActiveRow.Cells.All.Length > 3 Then
            '    objM流转票T.工序名称 = Me.grid流转票信息一览.ActiveRow.Cells("工序名称").Text.Trim
            'End If


            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllGrid(objM流转票T)

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
    Private Sub Selection1()

        Dim objBll As New BllM流转票管理T
        Dim objM流转票T As New M流转票管理T

        Try
            '选择行が無い場合
            'If Me.grid流转票信息一览.ActiveRow Is Nothing Then
            '    'メッセージ表示
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '    '処理終了
            '    Exit Sub
            'End If

            'objM流转票T.产品图号 = Me.grid流转票信息一览.ActiveRow.Cells("产品图号").Text.Trim

            'If Me.grid流转票信息一览.ActiveRow.Cells.All.Length > 3 Then
            '    objM流转票T.工序名称 = Me.grid流转票信息一览.ActiveRow.Cells("工序名称").Text.Trim
            'End If

            If Me.grid图纸.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM流转票T.产品图号 = Me.grid图纸.ActiveRow.Cells("产品图号").Text.Trim

            'If Me.grid图纸.ActiveRow.Cells.All.Length > 3 Then
            '    objM流转票T.工序名称 = Me.grid图纸.ActiveRow.Cells("产品图号").Text.Trim
            'End If

            'テーブルにデータを追加
            ReturnTable = objBll.LoadAllGrid(objM流转票T)

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
        Dim objM流转票T As M流转票管理T
        Dim objBLLM流转票T As New BllM流转票管理T
        Try
            objM流转票T = New M流转票管理T
            objM流转票T.产品图号 = Me.txt产品图号.Text.Trim
            objM流转票T.品名 = Me.txt品名.Text.Trim

            objM流转票T.图纸状态 = Me.cob图纸状态.Value
            'Me.grid图纸.DataSource = Nothing

            mDt详细 = New DataSet
            mDt详细图纸主数据 = New DataTable

            mDt详细图纸主数据 = objBLLM流转票T.LoadByWhere2(objM流转票T, Me.cob查询行数.Text)
            'dv = mDt详细图纸主数据.DefaultView
            mDt详细图纸1 = mDt详细图纸主数据.Clone
            For Each dr As DataRow In mDt详细图纸主数据.Rows
                If dr("上级图号") & "" = "" Then
                    mDt详细图纸1.Rows.Add(dr.ItemArray)
                End If
            Next

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

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(0).Columns("产品图号")
            childCols(0) = mDt详细.Tables(1).Columns("上级图号")

            drBand(0) = New DataRelation("1階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(1).Columns("产品图号")
            childCols(0) = mDt详细.Tables(2).Columns("上级图号")

            drBand(1) = New DataRelation("2階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(1))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(2).Columns("产品图号")
            childCols(0) = mDt详细.Tables(3).Columns("上级图号")

            drBand(2) = New DataRelation("3階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(2))

            ReDim parentCols(0)
            ReDim childCols(0)
            parentCols(0) = mDt详细.Tables(3).Columns("产品图号")
            childCols(0) = mDt详细.Tables(4).Columns("上级图号")

            drBand(3) = New DataRelation("4階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(3))

            Me.grid图纸.DataSource = mDt详细
            grid图纸.Refresh()
            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                '検索データを表示する
                Me.grid图纸.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else
                '検索データを表示する
                Me.grid图纸.DataSource = mDt详细
                Me.grid图纸.Focus()
                Me.grid图纸.ActiveRow = Me.grid图纸.Rows(0)

            End If
            SetGridStyle图纸()
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

    Private Sub SetGridStyle图纸()
        Try

            For index As Integer = 0 To 4
                With grid图纸.DisplayLayout.Bands(index)

                    .Columns("图纸").Hidden = True
                    .Columns("上级图号").Hidden = True
                End With
            Next

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub SetGridStyle流转票Info()
        Try

            With grid流转票信息一览.DisplayLayout.Bands(1)
                .Columns("产品图号").Hidden = True
                .Columns("品名").Hidden = True
                '.Columns("外协加工").Style = ColumnStyle.CheckBox
                '.Columns("组装品").Style = ColumnStyle.CheckBox
                '    .Columns("单件重量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
                '    .Columns("长").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '    .Columns("宽（外径）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '    .Columns("高（厚度）").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                '    .Columns("数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
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


    'Private Sub UcButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn流转票打印.Click
    '    If grid图纸.ActiveRow Is Nothing Then
    '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
    '        Exit Sub
    '    End If
    '    Dim rv As New ReportViewr
    '    rv.ReportExportType = Constant.ReporyType.流转票
    '    Dim objBll As New BLLM生产计划制定T
    '    Dim OI As New M生产计划制定T
    '    OI.产品图号 = grid图纸.ActiveRow.Cells("产品图号").Text
    '    Dim dtOrg = objBll.LoadByPKey1(OI)

    '    Dim objOID As New BllM流转票管理T
    '    Dim OID As New M流转票管理T
    '    Dim dt As New DataTable
    '    OID.产品图号 = OI.产品图号
    '    dt = objOID.LoadByWhere2(OID, Me.cob查询行数.Text)

    '    rv.DtOrg = dtOrg
    '    rv.DtSource = dt
    '    rv.ShowDialog()
    'End Sub

    Private Sub btn流转票打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn流转票导出.Click

        Dim objM流转票T As M流转票管理T

        Dim objBLLM流转票T As New BllM流转票管理T

        Dim dt流转票 As New DataTable

        If Me.grid图纸.ActiveRow Is Nothing Then
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '処理終了
            Exit Sub
        End If


        objM流转票T = New M流转票管理T
        objM流转票T.产品图号 = Me.grid图纸.ActiveRow.Cells("产品图号").Value
        dt流转票 = New DataTable
        dt流转票 = objBLLM流转票T.LoadAll流转票(objM流转票T)

        If dt流转票 Is Nothing OrElse dt流转票.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim dialogResult As DialogResult
        Dim fileFullName As String = ""
        Dim str产品图号S As String = String.Empty
        Dim strExt As String = ".xlsx"
        Dim ReturnDataTable As DataTable
        Dim str图纸等级 As String = String.Empty
        Dim strFilePath As String
        Dim intCount As Integer = 1
        Dim app As New Excel.Application
        Dim book As Excel._Workbook
        Dim sheet As Excel._Worksheet
        Try

            If Me.grid图纸.Rows.Count = 0 Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
                Exit Sub
            End If

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID42, "流转票") = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If


            '设置默认路径为当前应用程序根目录
            Me.FolderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory()

            '打开目录选择框            dialogResult = Me.FolderBrowserDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            '返回选择路径
            fileFullName = Me.FolderBrowserDialog.SelectedPath

            For Each dr As DataRow In dt流转票.Rows

                If str图纸等级 <> dr("图纸等级").ToString Then

                    If str图纸等级 <> String.Empty Then
                        book.Save()
                        book.Close()
                        'app = New Excel.Application
                    End If

                    str图纸等级 = dr("图纸等级")
                    strFilePath = fileFullName & "\" & dr("分图号") & ".xls"

                    If File.Exists(strSamplePath & "流转票.xls") Then
                        File.Copy(strSamplePath & "流转票.xls", strFilePath, True)
                    Else
                        MsgBox("模版不存在！")
                        Exit Sub
                    End If

                    app = New Excel.Application
                    app.Visible = False
                    book = app.Workbooks.Open(strFilePath)
                    sheet = DirectCast(book.Sheets(1), Excel._Worksheet)
                    sheet.Cells(4, 1).value = dr("品名")
                    sheet.Cells(4, 3).value = dr("分图号")
                    sheet.Cells(4, 5).value = dr("主图号")
                    'Dim im As Image = Image.FromFile(strServerPicturePath & dr("图纸"))   '获得Image
                    'Dim range As Excel.Range = sheet.Range(app.Cells(6, 13), app.Cells(6, 17))
                    'sheet.Paste(range, im)
                    intCount = 12
                End If
                sheet.Rows(intCount).Copy()
                sheet.Rows(intCount + 1).Insert()
                sheet.Cells(intCount, 1).value = dr("序号")
                sheet.Cells(intCount, 2).value = dr("工序名称")
                sheet.Cells(intCount, 3).value = dr("加工内容简介")
                sheet.Cells(intCount, 4).value = dr("作业场所")
                sheet.Cells(intCount, 6).value = dr("设备名称")

                intCount = intCount + 1
            Next
            str图纸等级 = String.Empty
            Dim objBll As New BLLM图纸T
            Dim objM图纸信息T As New M图纸T

            '选择行が無い場合
            If Me.grid图纸.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If


            'テーブルにデータを追加
            'ReturnTable = objBll.LoadAllexp(objM图纸信息T)

            'mDtSearch = ReturnTable

            'If mDtSearch Is Nothing OrElse mDtSearch.Rows.Count = 0 Then

            '    Me.Cursor = Cursors.Default

            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)
            '    Exit Sub
            'End If
            book.Save()
            'book.Close()

            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "流转票")
            'If PFn_DataTableToExcel1(mDtSearch, fileFullName) Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "图纸信息一览")
            'Else
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, "耗料表导出")
            'End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            book.Close()
            app.Quit()
            sheet = Nothing
            'Book = Nothing
            'App = Nothing
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
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
#End Region
End Class