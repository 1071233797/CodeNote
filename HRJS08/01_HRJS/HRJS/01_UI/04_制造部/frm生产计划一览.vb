Imports Infragistics.Win.UltraWinGrid
Imports HRJS.Constant
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Drawing.Imaging
'Imports O2S.Components.PDFRender4NET
'Imports Spire.Pdf
'Imports Spire.Pdf.Graphics
Public Class frm生产计划一览

#Region "常数定義"

    Public Enum ENU_GRID As Integer
        订单编号 = 0
    End Enum

#End Region

#Region "変数定義"
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("CirculationPath")
    'Dim strSamplePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("SamplePath")
    Dim strSamplePath As String = "E:\HRJS\"
    Dim CirculationPath As String = "E:\HRJS\华日图纸路径"
    Private mDtSearch As DataTable = Nothing
    Private mDt详细 As DataSet  'grid详细
    Private mDt详细图纸1 As DataTable  'grid详细
    Private mDt详细图纸2 As DataTable  'grid详细
    Private mstr订单编号 As String = String.Empty
    Public mstr产品图号 As String = String.Empty
    Public intDoubleClick As Integer = 0
    Dim mDt工序 As DataTable


    Public Property 订单编号() As String
        Get
            Return mstr订单编号
        End Get
        Set(ByVal Value As String)
            mstr订单编号 = Value
        End Set
    End Property
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

    Private Sub frm生产计划一览_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
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

    Private Sub frm生产计划一览_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm生产计划一览_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

                    'Case Keys.F11
                    '    btnF11流转票打印.Focus()
                    '    btnF11流转票打印_Click(Nothing, Nothing)

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
        Dim frmSearch As frm订单一览
        Try

            frmSearch = New frm订单一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt订单编号.Text = frmSearch.ReturnTable.Rows(0)("订单编号")          '订单编号
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
#Region "产品图号"
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
#Region "客户编号"
    Private Sub txt客户编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt客户编号.EditorButtonClick
        Dim frmSearch As frm客户一览
        Try

            frmSearch = New frm客户一览

            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '供应商查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置
                    Me.txt客户编号.Text = frmSearch.ReturnTable.Rows(0)("客户编号")          '客户编号
                    Me.txt客户名称.Text = frmSearch.ReturnTable.Rows(0)("客户名称")          '客户名称
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
    Private Sub txt客户编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt客户编号.Validating
        'tudu
        Dim objM客户T As M客户T
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

                If objM客户T.客户编号 <> "" Then

                    Me.txt客户名称.Text = objM客户T.客户名称

                Else
                    Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "客户名称")
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

    Private Sub gridList_InitializeLayout(ByVal sender As Object, ByVal e As InitializeLayoutEventArgs) Handles grid生产计划一览.InitializeLayout
        grid生产计划一览.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        grid生产计划一览.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False

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
            InitGrid1()
            'If Not Me.grid工序.DataSource Is Nothing AndAlso Me.grid工序.DataSource.rows.count > 0 Then
            '    Me.grid工序.DataSource.clear()
            'End If
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

    Private Sub btn流转票打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn流转票导出.Click

        Dim objM生产计划T As M生产计划制定T

        Dim objBLLM生产计划T As New BLLM生产计划制定T

        Dim dt生产计划 As New DataTable



        If Me.grid生产计划一览.ActiveRow Is Nothing Then
            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
            '処理終了
            Exit Sub
        End If
        objM生产计划T = New M生产计划制定T
        objM生产计划T.订单编号 = Me.grid生产计划一览.ActiveRow.Cells("订单编号").Value
        objM生产计划T.分图号 = Me.grid生产计划一览.ActiveRow.Cells("分图号").Value
        dt生产计划 = New DataTable
        dt生产计划 = objBLLM生产计划T.LoadAll生产计划(objM生产计划T)

        If dt生产计划 Is Nothing OrElse dt生产计划.Rows.Count = 0 Then
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

        'Dim im As String = String.Empty
        Try

            If Me.grid生产计划一览.Rows.Count = 0 Then
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

            For Each dr As DataRow In dt生产计划.Rows

                If str图纸等级 <> dr("图纸等级").ToString Then

                    If str图纸等级 <> String.Empty Then
                        book.Save()
                        book.Close()

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

                    If dr("图纸") <> "" Then
                        Dim img As Image = Image.FromFile(CirculationPath & "\" & dr("图纸"))   '获得Image
                        System.Windows.Forms.Clipboard.SetDataObject(img, True)  '复制到剪贴板
                        Dim range As Excel.Range = sheet.Range(sheet.Cells(6, 11), sheet.Cells(1, 2))  '粘贴图片的位置
                        sheet.Paste(range, img)  '将图片插入Excel
                    End If
                    sheet.Cells(4, 1).value = dr("品名")
                    sheet.Cells(4, 3).value = dr("分图号")

                    sheet.Cells(4, 5).value = dr("主图号")
                    sheet.Cells(8, 1).value = dr("投产数量")
                    sheet.Cells(8, 3).value = dr("完成期限")
                    sheet.Cells(8, 4).value = dr("下达日期")
                    sheet.Cells(8, 5).value = dr("订单号")
                    sheet.Cells(8, 8).value = dr("订货量")
                    sheet.Cells(8, 10).value = dr("发货日期")
                    
                    intCount = 12
                End If
                sheet.Rows(intCount).Copy()
                sheet.Rows(intCount + 1).Insert()
                sheet.Cells(intCount, 1).value = dr("序号")
                sheet.Cells(intCount, 2).value = dr("工序名称")
                sheet.Cells(intCount, 3).value = dr("加工内容简介")
                sheet.Cells(intCount, 4).value = dr("作业场所")
                sheet.Cells(intCount, 6).value = dr("设备名称")
                sheet.Cells(intCount, 8).value = dr("指示完成日期")
                sheet.Cells(intCount, 9).value = dr("作业起始日期")

                intCount = intCount + 1
            Next
            str图纸等级 = String.Empty
            Dim objBll As New BLLM图纸T
            Dim objM图纸信息T As New M图纸T

            '选择行が無い場合
            If Me.grid生产计划一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If


           
            book.Save()
            'book.Close()

            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID10, "流转票")
           

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

#End Region
    Private Sub grdList_DoubleClickRow(ByVal sender As System.Object, _
                                       ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles grid生产计划一览.DoubleClickRow

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

    'Private Sub grdList_DoubleClickRow2(ByVal sender As System.Object, _
    '                                   ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs)


    '    Try

    '        '选择処理
    '        Me.Selection1()

    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    'Private Sub grdList_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles grid生产计划一览.MouseDown

    '    Dim objM生产T As M生产计划制定T
    '    Dim objBLLM生产T As New BLLM生产计划制定T
    '    Dim dtGridInfo As New DataTable
    '    'Dim mDt详细 As DataTable
    '    ''Dim dr As DataRow()
    '    'Dim dv As DataView
    '    Try
    '        objM生产T = New M生产计划制定T
    '        If grid生产计划一览.ActiveRow Is Nothing Then
    '            Exit Sub
    '        End If
    '        objM生产T.订单编号 = grid生产计划一览.ActiveRow.Cells("订单编号").Value
    '        objM生产T.主图号 = grid生产计划一览.ActiveRow.Cells("主图号").Value
    '        objM生产T.分图号 = grid生产计划一览.ActiveRow.Cells("分图号").Value


    '        Me.grid工序.DataSource = Nothing

    '        dtGridInfo = objBLLM生产T.LoadAllGrid1(objM生产T)

    '        'If File.Exists(strServerPicturePath & grid生产计划制定.ActiveRow.Cells("图纸").Value) Then
    '        '    SetPictureBoxImage(Me.pic图纸, strServerPicturePath & grid生产计划制定.ActiveRow.Cells("图纸").Value)
    '        'End If
    '        Me.grid工序.DataSource = dtGridInfo
    '        If Not Me.grid工序.DataSource Is Nothing Then
    '            SetGridStyle工序()
    '        End If
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub
#Region "Private Method"

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try

            'Grid初始化            'SetGridStyle生产()
            Me.InitGrid1()
            Me.InitGrid2()
            '画面の内容を清空処理
            Me.ClearForm()
            SetCombo()
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

            Me.btnF2查询.Enabled = Utility.PFn_GetAuth(Me.btnF2查询.Tag)
            Me.btnF3选择.Enabled = Utility.PFn_GetAuth(Me.btnF3选择.Tag)
            Me.btn流转票导出.Enabled = Utility.PFn_GetAuth(Me.btn流转票导出.Tag)

        Catch ex As Exception
            '異常処理()
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル()
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
            Me.cmb产品状态.Text = String.Empty
            Me.txt订单编号.Text = String.Empty
            Me.txt产品图号.Text = mstr产品图号
            Me.txt客户名称.Text = String.Empty
            Me.txt客户编号.Text = String.Empty
            Me.dmt完成日期sta.Text = String.Empty
            Me.dmt完成日期end.Text = String.Empty
            grid生产计划一览.DataSource = Nothing
            Me.txt订单编号.Select()
            InitGrid1()
            InitGrid2()
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
    Private Sub InitGrid1()
        Try

            mDtSearch = New DataTable

            mDtSearch.Columns.Add("订单编号")
            mDtSearch.Columns.Add("产品图号")
            mDtSearch.Columns.Add("品名")
            mDtSearch.Columns.Add("订货量")
            mDtSearch.Columns.Add("投产数量")
            mDtSearch.Columns.Add("是否整体外协加工")
            mDtSearch.Columns.Add("是否为抵补品")
            mDtSearch.Columns.Add("是否为试作品")
            mDtSearch.Columns.Add("合格标准")
            mDtSearch.Columns.Add("备注")
            grid生产计划一览.DataSource = mDtSearch

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region
#Region "InitGrid2"
    ''' <summary>
    ''' 画面の内容を清空処理
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitGrid2()
        Try

            mDtSearch = New DataTable

            mDtSearch.Columns.Add("工序名称")
            mDtSearch.Columns.Add("加工内容简介")
            mDtSearch.Columns.Add("作业场所")
            mDtSearch.Columns.Add("设备编号")
            mDtSearch.Columns.Add("是否外协加工")
            mDtSearch.Columns.Add("外协理由")
            mDtSearch.Columns.Add("是否为组装品")
            mDtSearch.Columns.Add("起始日")
            mDtSearch.Columns.Add("完成日")
            mDtSearch.Columns.Add("作业者编号")
            mDtSearch.Columns.Add("作业者名称")
            mDtSearch.Columns.Add("备注")
            grid生产计划一览.DataSource = mDtSearch

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

            '制限件数コンボボックス

            Utility.PFn_SetCombo(Me.cmb产品状态, "VM产品状态", 0)

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
            If Not String.IsNullOrEmpty(dmt完成日期sta.Text.Trim) And Not String.IsNullOrEmpty(dmt完成日期end.Text.Trim) Then
                If DateTime.Parse(dmt完成日期end.DateTime) > DateTime.Parse(dmt完成日期sta.DateTime) Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID15, "完成日", "完成日")
                    dmt完成日期sta.Focus()
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

        Dim mDt详细 As DataSet  'grid详细
        Dim mDt详细主数据 As DataTable  'grid详细
        Dim mDt详细1 As New DataTable
        Dim mDt详细2 As DataTable  'grid详细
        Dim mDt详细3 As DataTable  'grid详细
        Dim mDt详细4 As DataTable  'grid详细
        Dim mDt详细5 As DataTable  'grid详细
        'Dim dt二级图纸 As New DataTable


        Dim objM生产T As M生产计划制定T
        Dim objBLLM生产计划制定T As New BLLM生产计划制定T

        Try
            objM生产T = New M生产计划制定T
            objM生产T.主图号 = Me.txt产品图号.Text.Trim
            objM生产T.订单编号 = Me.txt订单编号.Text.Trim
            objM生产T.完成日1 = Me.dmt完成日期sta.Text.Trim
            objM生产T.完成日2 = Me.dmt完成日期end.Text.Trim
            objM生产T.产品状态 = Me.cmb产品状态.Text.Trim
            Me.grid生产计划一览.DataSource = Nothing

            mDt详细 = New DataSet
            mDt详细主数据 = New DataTable
            mDt详细主数据 = objBLLM生产计划制定T.LoadByWhere2(objM生产T)
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
            'mDt详细2 = mDt详细主数据.Copy
            'mDt详细3 = mDt详细主数据.Copy
            'mDt详细4 = mDt详细主数据.Copy
            'mDt详细5 = mDt详细主数据.Copy


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
            'mDt详细.Relations.Clear()

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

            ReDim parentCols(2)
            ReDim childCols(2)
            parentCols(0) = mDt详细.Tables(0).Columns("主图号")
            childCols(0) = mDt详细.Tables(1).Columns("主图号")
            parentCols(1) = mDt详细.Tables(0).Columns("分图号")
            childCols(1) = mDt详细.Tables(1).Columns("上级图号")
            parentCols(2) = mDt详细.Tables(0).Columns("订单编号")
            childCols(2) = mDt详细.Tables(1).Columns("订单编号")
            drBand(0) = New DataRelation("1階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(0))

            ReDim parentCols(2)
            ReDim childCols(2)
            parentCols(0) = mDt详细.Tables(1).Columns("主图号")
            childCols(0) = mDt详细.Tables(2).Columns("主图号")
            parentCols(1) = mDt详细.Tables(1).Columns("分图号")
            childCols(1) = mDt详细.Tables(2).Columns("上级图号")
            parentCols(2) = mDt详细.Tables(1).Columns("订单编号")
            childCols(2) = mDt详细.Tables(2).Columns("订单编号")
            drBand(1) = New DataRelation("2階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(1))

            ReDim parentCols(2)
            ReDim childCols(2)
            parentCols(0) = mDt详细.Tables(2).Columns("主图号")
            childCols(0) = mDt详细.Tables(3).Columns("主图号")
            parentCols(1) = mDt详细.Tables(2).Columns("分图号")
            childCols(1) = mDt详细.Tables(3).Columns("上级图号")
            parentCols(2) = mDt详细.Tables(2).Columns("订单编号")
            childCols(2) = mDt详细.Tables(3).Columns("订单编号")
            drBand(2) = New DataRelation("3階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(2))

            ReDim parentCols(2)
            ReDim childCols(2)
            parentCols(0) = mDt详细.Tables(3).Columns("主图号")
            childCols(0) = mDt详细.Tables(4).Columns("主图号")
            parentCols(1) = mDt详细.Tables(3).Columns("分图号")
            childCols(1) = mDt详细.Tables(4).Columns("上级图号")
            parentCols(2) = mDt详细.Tables(3).Columns("订单编号")
            childCols(2) = mDt详细.Tables(4).Columns("订单编号")
            drBand(3) = New DataRelation("4階層", parentCols, childCols, False)
            mDt详细.Relations.Add(drBand(3))

            'ReDim parentCols(0)
            'ReDim childCols(0)
            'parentCols(0) = mDt详细.Tables(4).Columns("产品图号")
            'childCols(0) = mDt详细.Tables(5).Columns("上级图号")

            'drBand(4) = New DataRelation("5階層", parentCols, childCols, False)
            'mDt详细.Relations.Add(drBand(4))



            Me.grid生产计划一览.DataSource = mDt详细
            grid生产计划一览.Refresh()
            If mDt详细 Is Nothing OrElse mDt详细.Tables(0).Rows.Count = 0 Then
                SetGridStyle生产()
                '結果０件ＭＳＧ出力
                'メッセージCD：211
                Me.Cursor = Cursors.Default

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID16)

                ''查询Gridの初期化
                'Me.grdList.PClear()
                '検索データを表示する
                Me.grid生产计划一览.DataSource = mDt详细

                'フォーカスの設定処理
                Me.txt订单编号.Focus()

            Else
                '検索データを表示する
                Me.grid生产计划一览.DataSource = mDt详细
                Me.grid生产计划一览.Focus()
                Me.grid生产计划一览.ActiveRow = Me.grid生产计划一览.Rows(0)
                SetGridStyle生产()
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

        Dim objBll As New BLLM生产计划制定T
        Dim objM生产计划T As New M生产计划制定T

        Try

            '一览打开，不做处理
            If FormOpenMode = ENU_MODE.Model_NULL Then
                Exit Sub
            End If

            '外协品出库等页面打开时只能点击下方gird
            If intDoubleClick = 1 Then
                MsgBox("请点击下方列表，选择工序")
                Exit Sub
            End If

            '选择行が無い場合
            If Me.grid生产计划一览.ActiveRow Is Nothing Then
                'メッセージ表示
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
                '処理終了
                Exit Sub
            End If
            If intDoubleClick = 1 Then
                If grid生产计划一览.ActiveRow.Cells.Count < 15 Then
                    MsgBox("请选择下面列表。")
                    Exit Sub
                End If
            End If
            objM生产计划T.分图号 = Me.grid生产计划一览.ActiveRow.Cells("分图号").Text.Trim
            objM生产计划T.订单编号 = Me.grid生产计划一览.ActiveRow.Cells("订单编号").Text.Trim


            'テーブルにデータを追加
            ReturnTable = objBll.LoadSelect(objM生产计划T)

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

#Region "Selection1"

    ''' <summary>
    ''' 选择処理
    ''' </summary>
    ''' <remarks></remarks>
    'Private Sub Selection1()

    '    Dim objBll As New BLLM生产计划制定T
    '    Dim objM生产计划T As New M生产计划制定T

    '    Try
    '        '一览打开，不做处理
    '        If FormOpenMode = ENU_MODE.Model_NULL Then
    '            Exit Sub
    '        End If

    '        '选择行が無い場合
    '        If Me.grid生产计划一览.ActiveRow Is Nothing Then
    '            'メッセージ表示
    '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
    '            '処理終了
    '            Exit Sub
    '        End If

    '        'If intDoubleClick = 1 Then
    '        '    If grid生产计划一览.ActiveRow.Cells.Count < 15 Then
    '        '        MsgBox("请选择下面列表。")
    '        '        Exit Sub
    '        '    End If        
    '        'End If

    '        objM生产计划T.订单编号 = Me.grid工序.ActiveRow.Cells("订单编号").Text.Trim
    '        objM生产计划T.主图号 = Me.grid工序.ActiveRow.Cells("主图号").Text.Trim
    '        objM生产计划T.分图号 = Me.grid工序.ActiveRow.Cells("分图号").Text.Trim
    '        objM生产计划T.工序编号 = Me.grid工序.ActiveRow.Cells("工序编号").Text.Trim

    '        ReturnTable = objBll.LoadSelect(objM生产计划T)

    '        If ReturnTable Is Nothing OrElse ReturnTable.Rows.Count = 0 Then
    '            'メッセージ表示
    '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID19)
    '            Exit Sub
    '        End If

    '        ReturnType = Constant.ENU_MSTSEARCH.SearchMOk

    '        '画面を閉じる
    '        Me.Close()
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

#End Region

#Region "SetGridStyle生产"
    Private Sub SetGridStyle生产()
        Try
            With grid生产计划一览.DisplayLayout.Bands(0)
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("图纸").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("分图号").Hidden = True
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellActivation = Activation.NoEdit
                .Columns("投产数量").CellActivation = Activation.NoEdit
                '.Columns("是否整体外协加工").CellActivation = Activation.NoEdit
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                '.Columns("合格标准").CellActivation = Activation.NoEdit
                .Columns("备注").CellActivation = Activation.NoEdit
                .Columns("图纸").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
            End With
            With grid生产计划一览.DisplayLayout.Bands(1)
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("图纸").Hidden = True
                .Columns("上级图号").Hidden = True
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                '.Columns("分图号").Hidden = True
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellActivation = Activation.NoEdit
                .Columns("投产数量").CellActivation = Activation.NoEdit
                '.Columns("是否整体外协加工").CellActivation = Activation.NoEdit
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                '.Columns("合格标准").CellActivation = Activation.NoEdit
                .Columns("备注").CellActivation = Activation.NoEdit
                .Columns("图纸").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
            End With
            With grid生产计划一览.DisplayLayout.Bands(2)
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("图纸").Hidden = True
                '.Columns("上级图号").Hidden = True
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellActivation = Activation.NoEdit
                .Columns("投产数量").CellActivation = Activation.NoEdit
                '.Columns("是否整体外协加工").CellActivation = Activation.NoEdit
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                '.Columns("合格标准").CellActivation = Activation.NoEdit
                .Columns("备注").CellActivation = Activation.NoEdit
                .Columns("图纸").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
            End With
            With grid生产计划一览.DisplayLayout.Bands(3)
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("图纸").Hidden = True
                '.Columns("上级图号").Hidden = True
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellActivation = Activation.NoEdit
                .Columns("投产数量").CellActivation = Activation.NoEdit
                '.Columns("是否整体外协加工").CellActivation = Activation.NoEdit
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                '.Columns("合格标准").CellActivation = Activation.NoEdit
                .Columns("备注").CellActivation = Activation.NoEdit
                .Columns("图纸").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
            End With
            With grid生产计划一览.DisplayLayout.Bands(4)
                .Columns("订货量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("投产数量").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("图纸").Hidden = True
                '.Columns("上级图号").Hidden = True
                .Columns("订单编号").CellActivation = Activation.NoEdit
                .Columns("主图号").CellActivation = Activation.NoEdit
                .Columns("分图号").CellActivation = Activation.NoEdit
                .Columns("品名").CellActivation = Activation.NoEdit
                .Columns("订货量").CellActivation = Activation.NoEdit
                .Columns("投产数量").CellActivation = Activation.NoEdit
                '.Columns("是否整体外协加工").CellActivation = Activation.NoEdit
                .Columns("是否为抵补品").CellActivation = Activation.NoEdit
                .Columns("是否为试做品").CellActivation = Activation.NoEdit
                '.Columns("合格标准").CellActivation = Activation.NoEdit
                .Columns("备注").CellActivation = Activation.NoEdit
                .Columns("图纸").CellActivation = Activation.NoEdit
                .Columns("上级图号").CellActivation = Activation.NoEdit
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
#Region "SetGridStyle工序"
    'Private Sub SetGridStyle工序()
    '    Try

    '        With grid工序.DisplayLayout.Bands(0)
    '            .Columns("是否外协加工").Style = ColumnStyle.CheckBox
    '            .Columns("是否外协加工").CellActivation = Activation.NoEdit
    '            .Columns("起始日").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
    '            .Columns("起始日").CellActivation = Activation.NoEdit
    '            .Columns("完成日").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
    '            .Columns("完成日").CellActivation = Activation.NoEdit
    '            .Columns("订单编号").Hidden = True
    '            .Columns("主图号").Hidden = True
    '            .Columns("分图号").Hidden = True
    '            .Columns("上级图号").Hidden = True
    '            .Columns("工序编号").Hidden = True
    '            .Columns("产品图号").Hidden = True
    '        End With

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

End Class