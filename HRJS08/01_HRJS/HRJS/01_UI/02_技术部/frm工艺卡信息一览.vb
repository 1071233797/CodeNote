Public Class frm工艺卡信息一览



#Region "常数定義"

    Public Enum ENU_GRID As Integer
        产品图号 = 0
    End Enum

#End Region

#Region "変数定義"
    Private mDtSearch图纸 As DataTable = Nothing
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细
    Private mstr产品图号 As String = String.Empty


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

    Private Sub frm工艺卡信息一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm工艺卡信息一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm工艺卡信息一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
            '清空画面对话框
            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID6) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If
            ClearForm()


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


            ''关闭画面对话框()

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

#End Region


    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                       ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) _
                                       Handles grid工艺卡信息一览.DoubleClickRow

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
            'Me.InitGrid()

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
            Me.btn工艺卡打印.Enabled = Utility.PFn_GetAuth(Me.btn工艺卡打印.Tag)

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
            Me.cob查询行数.Value = 1
            Me.cob图纸状态.Text = String.Empty
            'Me.txt客户名称.Text = String.Empty
            'Me.dt录入日期star.Text = String.Empty
            'Me.dt录入日期end.Text = String.Empty
            'grid工艺卡信息一览.DataSource = Nothing
            'grid图纸.DataSource = Nothing
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
            mDtSearch.Columns.Add("工序名称")
            mDtSearch.Columns.Add("加工内容")
            mDtSearch.Columns.Add("作业者")
            mDtSearch.Columns.Add("录入日期")

            grid工艺卡信息一览.DataSource = mDtSearch

            mDtSearch图纸 = New DataTable
            mDtSearch图纸.Columns.Add("产品图号")
            mDtSearch图纸.Columns.Add("品名")
            grid图纸.DataSource = mDtSearch图纸
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
            'If Not String.IsNullOrEmpty(dt录入日期star.Text.Trim) And Not String.IsNullOrEmpty(dt录入日期end.Text.Trim) Then
            '    If DateTime.Parse(dt录入日期end.DateTime) > DateTime.Parse(dt录入日期end.DateTime) Then
            '        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "录入日期", "录入日期")
            '        dt录入日期star.Focus()
            '        Return False
            '    End If

            'End If
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
            'If Me.txt客户名称.Text.Trim = String.Empty Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户名称", "客户名称")
            '    txt客户名称.Focus()
            '    Return False
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

#Region "DataSearchinfo"

    Private Sub DataSearchInfo(ByVal 产品图号 As String, ByVal str品名 As String)

        Dim objM工艺卡T As M工艺卡T

        Dim objBLLM工艺卡T As New BLLM工艺卡T

        Try
            objM工艺卡T = New M工艺卡T
            objM工艺卡T.产品图号 = 产品图号
            objM工艺卡T.品名 = str品名
            'objM工艺卡T.更新日期 = Me.dt录入日期end.Text.Trim
            'If (Not Me.dt录入日期star.Text.Trim = String.Empty) Then
            '    objM工艺卡T.更新日期 = Me.dt录入日期star.Text.Trim
            'Else
            '    objM工艺卡T.更新日期 = Constant.CGSTRDATE_DEFAULT
            'End If

            'If (Not Me.dt录入日期end.Text.Trim = String.Empty) Then
            '    objM工艺卡T.更新日期 = Me.dt录入日期end.Text.Trim
            'Else
            '    objM工艺卡T.更新日期 = Constant.CGSTRDATE_DEFAULT
            'End If
            Me.grid工艺卡信息一览.DataSource = Nothing

            mDt详细 = New DataSet
            Me.mDt详细图纸1 = New DataTable
            mDt详细图纸1 = objBLLM工艺卡T.LoadByWhere(objM工艺卡T)

            'mdt详细Band1データを記録テーブル初期化
            Me.mDt详细图纸2 = New DataTable
            mDt详细图纸2 = objBLLM工艺卡T.LoadByWhere1(objM工艺卡T)

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

            Me.grid工艺卡信息一览.DataSource = mDt详细
            grid工艺卡信息一览.Refresh()


            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then

                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid工艺卡信息一览.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt产品图号.Focus()
            Else
                '検索データを表示する
                Me.grid工艺卡信息一览.DataSource = mDt详细
                Me.grid工艺卡信息一览.Focus()
                Me.grid工艺卡信息一览.ActiveRow = Me.grid工艺卡信息一览.Rows(0)
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

        Dim objM工艺卡T As M工艺卡T
        Dim objBLLM工艺卡T As New BLLM工艺卡T
        Try
            objM工艺卡T = New M工艺卡T
            objM工艺卡T.产品图号 = Me.txt产品图号.Text.Trim
            objM工艺卡T.品名 = Me.txt品名.Text.Trim
            objM工艺卡T.图纸状态 = Me.cob图纸状态.Value
            Me.grid图纸.DataSource = Nothing

            mDt详细 = New DataSet
            mDt详细图纸主数据 = New DataTable
            mDt详细图纸主数据 = objBLLM工艺卡T.LoadByWhere2(objM工艺卡T, Me.cob查询行数.Text)
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
                SetGridStyle图纸()
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

        Dim objBll As New BLLM工艺卡T
        Dim objM工艺卡T As New M工艺卡T

        Try
            '选择行が無い場合
            If Me.grid工艺卡信息一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If

            objM工艺卡T.产品图号 = Me.grid工艺卡信息一览.ActiveRow.Cells("产品图号").Text.Trim
            'objM工艺卡T.工序名称 = Me.grid工艺卡信息一览.ActiveRow.Cells("工序名称").Text.Trim
            'テーブルにデータを追加
            ReturnTable = objBll.LoadByWhere1(objM工艺卡T)

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

    Private Sub grid图纸_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid图纸.MouseDown
        If grid图纸.ActiveRow Is Nothing Then
            Exit Sub
        End If

        DataSearchInfo(grid图纸.ActiveRow.Cells("产品图号").Value, grid图纸.ActiveRow.Cells("品名").Value)
    End Sub

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

            With grid工艺卡信息一览.DisplayLayout.Bands(1)
                .Columns("产品图号").Hidden = True
                .Columns("录入日期").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center

                .Columns("录入日期").CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
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

    Private Sub btn工艺卡打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn工艺卡打印.Click

    End Sub
End Class