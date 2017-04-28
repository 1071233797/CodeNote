Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports HRJS.Constant
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports O2S.Components.PDFRender4NET
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class frm图纸信息管理

#Region "常量定义"

    Private Enum ENU_GRID As Integer
        材料种类 = 0
        材质 = 1
        型号 = 2
        长 = 3
        宽 = 4
        高 = 5
        单件重量 = 6
        数量 = 7
        要求 = 8
        备注 = 9
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
    Class nn
        Public name As String
        Public parent As String
        Public snumber As String
    End Class

#End Region

#Region "変数定義"

    Private mIntFormMode As Integer = Constant.ENU_MODE.Model_New
    'Private mdsGridDataSet As DataTable
    Private mdsInfoDataSet As DataTable
    Private mdsInfoDataSet1 As DataTable
    Private mdsInfoTree As DataTable
    Dim strTree As String = String.Empty
    Dim strPath As String = String.Empty
    Dim strPathFlg As Boolean = False
    Dim strServerPicturePath As String = System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath")
    Dim str节点图号 As String = String.Empty
    Dim strFlg As Boolean = False
    Dim strChang As String
#End Region

#Region "Form Event"

    Private Sub frm图纸录入_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

    Private Sub frm图纸录入_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm模具详细_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.F1
                    btnF1清空.Focus()
                    btnF1清空_Click(Nothing, Nothing)

                Case Keys.F2
                    btnF2编辑.Focus()
                    'btnF2编辑_Click(Nothing, Nothing)

                Case Keys.F3
                    btnF3保存.Focus()
                    btnF3保存_Click(Nothing, Nothing)

                Case Keys.F4
                    btnF4删除.Focus()
                    btnF4删除_Click(Nothing, Nothing)

                Case Keys.F11
                    btnF11.Focus()
                    btn图纸导入_Click(Nothing, Nothing)
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

    Private Sub txt数量_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt数量.KeyPress

        If Utility.IsDigit(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt长_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt长.KeyPress

        If Utility.IsDigit(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt宽_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt宽.KeyPress

        If Utility.IsDigit(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt高_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt高.KeyPress

        If Utility.IsDigit(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

#End Region

#Region "Button Event"
    Private Sub btn图纸导入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn图纸导入.Click
        Try


            Dim dialogResult As DialogResult

            dialogResult = Me.OpenFileDialog.ShowDialog()

            If dialogResult = Windows.Forms.DialogResult.OK Then
                strPath = Me.OpenFileDialog.FileName
            Else
                Exit Sub
            End If

            If Path.GetExtension(strPath).ToUpper = ".PDF" Then
                SetPDFPictureBoxImage()
            Else
                SetPictureBoxImage(Me.pic图纸, strPath)
            End If




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


    Private Sub btnF5行追加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF5行追加.Click
        If Me.txt分图号.Text.Trim = String.Empty Then

            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "分图号", "分图号")
            txt分图号.Focus()
            Exit Sub
        End If

        Dim node As TreeNode = TreeView1.SelectedNode
        If Not node Is Nothing Then
            'node.Nodes.Add((TreeView1.GetNodeCount(False) + 1) & "级图号")
            node.Nodes.Add(Me.txt分图号.Text)
            Me.txt分图号.Text = String.Empty
            Me.txt分图号.Focus()
        Else
            MessageBox.Show("没有选中任何节点")
        End If
    End Sub

    Private Sub btnF6行删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF6行删除.Click
        Dim node As TreeNode = TreeView1.SelectedNode

        If node Is Nothing Then
            MessageBox.Show("没有选中任何节点")
        Else
            TreeView1.Nodes.Remove(node)
        End If
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

    Private Sub txt产品图号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt产品图号.Leave

        If mIntFormMode = Constant.ENU_MODE.Model_Update Then

            Dim node As TreeNode = TreeView1.SelectedNode

            If node Is Nothing Then
                Exit Sub
            End If

            If node.Text <> txt产品图号.Text.Trim Then
                strChang = node.Text
                node.Text = txt产品图号.Text.Trim
                strFlg = True
            End If
        End If
    End Sub


    Private Sub txt主图号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt主图号.Leave
        Dim objM图纸T As M图纸T
        Dim objBLLM图纸T As BLLM图纸T

        Try

            'If txt产品图号.ReadOnly Then
            '    Exit Sub
            'End If

            If Me.txt主图号.Text.Trim <> String.Empty Then

                If Me.txt主图号.Tag = Me.txt主图号.Text.Trim Then
                    Exit Sub
                End If

                objM图纸T = New M图纸T

                objM图纸T.产品图号 = txt主图号.Text.Trim

                objBLLM图纸T = New BLLM图纸T

                objM图纸T = objBLLM图纸T.LoadByPKey(objM图纸T)

                If objM图纸T.产品图号 <> String.Empty Then
                    Me.txt主图号品名.Text = objM图纸T.品名

                    mdsInfoTree = objBLLM图纸T.LoadTree(objM图纸T)

                    If Not mdsInfoTree Is Nothing AndAlso mdsInfoTree.Rows.Count > 0 Then
                        Dim intCount As Integer = mdsInfoTree.Rows.Count - 1
                        Dim nd As New nn
                        Dim intI As Integer = 0
                        Me.TreeView1.Nodes.Clear()
                        For Each dr As DataRow In mdsInfoTree.Rows
                            nd = New nn
                            nd.name = dr("产品图号")
                            nd.parent = dr("ID")
                            nd.snumber = dr("CIID")
                            addto(nd, TreeView1.Nodes)
                        Next
                    Else
                        Me.TreeView1.Nodes.Clear()
                        If TreeView1.Nodes.Count = 0 AndAlso Me.txt主图号.Text <> "" Then
                            TreeView1.Nodes.Add(Me.txt主图号.Text)
                            TreeView1.LabelEdit = True
                            str节点图号 = Me.txt主图号.Text
                        End If
                    End If
                Else

                    Me.TreeView1.Nodes.Clear()
                    If TreeView1.Nodes.Count = 0 AndAlso Me.txt主图号.Text <> "" Then
                        TreeView1.Nodes.Add(Me.txt主图号.Text)
                        TreeView1.LabelEdit = True
                        str节点图号 = Me.txt主图号.Text
                    End If
                    Me.txt产品图号.Text = Me.txt主图号.Text
                    Me.txt分图号.Focus()
                End If
            Else
                Me.txt主图号.Text = String.Empty
            End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub txt产品图号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt主图号.EditorButtonClick
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
                    Me.txt主图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号")          '产品图号
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
            Me.txt产品图号_Leave(Nothing, Nothing)
            Me.txt分图号.Focus()
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

            'If mIntFormMode = Constant.ENU_MODE.Model_New Then
            '    Me.txt产品图号.Select()
            'Else
            '    Me.txt图纸版本编号.Select()
            'End If
            mIntFormMode = Constant.ENU_MODE.Model_New
            Me.SetFormModel()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnF2编辑_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF2编辑.Click

        Dim frmSearch As frm图纸信息一览        Try
            frmSearch = New frm图纸信息一览            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '部门信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then
                    Me.ClearForm()
                    '根据检索画面数据进行设置                    Me.txt产品图号.Text = frmSearch.ReturnTable.Rows(0)("产品图号").ToString
                    Me.txt主图号.Text = frmSearch.ReturnTable.Rows(0)("主图号").ToString
                    Me.txt上级图号.Text = frmSearch.ReturnTable.Rows(0)("上级图号").ToString
                    '设置画面数据
                    SetFormData()
                End If

                If Not frmSearch.ReturnTable Is Nothing Then
                    '检索画面释放                    frmSearch.ReturnTable.Dispose()
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

    Private Sub btnF4删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF4删除.Click

        Dim objM图纸T As New M图纸T

        Dim objBll As New BLLM图纸T

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

            objM图纸T.产品图号 = txt产品图号.Text.Trim
            objM图纸T.主图号 = txt主图号.Text.Trim
            objM图纸T.上级图号 = txt上级图号.Text.Trim
            If objBll.Delete(objM图纸T, False) > 0 Then
                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrDelete)
                If strPath <> "" Then
                    File.Delete(strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4))
                End If
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

    Private Sub btnF12关闭_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF12关闭.Click
        Me.Cursor = Cursors.WaitCursor
        ''画面の終了処理        Me.Close()
    End Sub
    Private Sub txt原材料编号_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txt原材料编号.EditorButtonClick


        Dim frmSearch As frm原材料信息一览
        Try

            frmSearch = New frm原材料信息一览
            frmSearch.FormOpenMode = Constant.ENU_MODE.Model_Search

            '工程信息查询画面打开
            frmSearch.ShowDialog()

            '画面数据设置
            If frmSearch.ReturnType = Constant.ENU_MSTSEARCH.SearchMOk Then

                If Not frmSearch.ReturnTable Is Nothing AndAlso 0 < frmSearch.ReturnTable.Rows.Count Then

                    '根据检索画面数据进行设置

                    Me.txt原材料编号.Text = frmSearch.ReturnTable.Rows(0)("原材料编号")     '原材料编号

                    Me.txt材料名称.Text = frmSearch.ReturnTable.Rows(0)("原材料名称")     '原材料名称

                    Me.cob材料种类.Value = frmSearch.ReturnTable.Rows(0)("材料种类")     '材料种类


                    Me.cob材质.Value = frmSearch.ReturnTable.Rows(0)("材质")     '材质
                    Me.txt材料代号.Text = frmSearch.ReturnTable.Rows(0)("材料代号") & ""

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

    Private Sub txt原材料编号_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt原材料编号.Validating

        Dim objM原材料信息T As M原材料信息T
        Dim objBllM原材料信息T As BLLM原材料信息T

        Try

            If txt原材料编号.ReadOnly Then
                Exit Sub
            End If

            If Me.txt原材料编号.Text.Trim <> String.Empty Then

                If Me.txt原材料编号.Tag = Me.txt原材料编号.Text.Trim Then
                    Exit Sub
                End If

                objM原材料信息T = New M原材料信息T

                objM原材料信息T.原材料编号 = txt原材料编号.Text.Trim

                objBllM原材料信息T = New BLLM原材料信息T

                objM原材料信息T = objBllM原材料信息T.LoadByPKey(objM原材料信息T)

                If objM原材料信息T.原材料编号 <> "" Then

                    Me.txt原材料编号.Text = objM原材料信息T.原材料编号                    'Me.txt原材.Text = objM原材料信息T.原材料编号                    Me.txt材料名称.Text = objM原材料信息T.原材料名称   '部门
                    Me.cob材料种类.Text = objM原材料信息T.材料种类   '部门
                    Me.cob材质.Text = objM原材料信息T.材质   '部门
                    Me.txt材料代号.Text = objM原材料信息T.材料代号 & ""
                    ' Me.lbl材质.Text = objM原材料信息T.材质
                    ' Me.txt规格.Text = objM原材料信息T.原材规格

                Else
                    txt原材料编号.Text = String.Empty
                    Me.txt材料名称.Text = String.Empty
                    Me.cob材料种类.Text = String.Empty
                    Me.cob材质.Text = String.Empty
                    Me.txt材料代号.Text = String.Empty
                    'CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID14, "人员姓名")
                    'Me.txt使用者编号.Select()
                End If
            Else
                Me.txt原材料编号.Text = String.Empty
            End If

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    'Private Sub btnF7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF7.Click
    '    Try
    '        Dim dr As DataRow
    '        Dim intRow As Integer

    '        If Me.grid图纸.Rows.Count = 0 Then
    '            intRow = 0
    '        Else
    '            intRow = Me.grid图纸.Rows.Count
    '        End If

    '        dr = mdsGridDataSet.NewRow()

    '        mdsGridDataSet.Rows.Add(dr)
    '        mdsGridDataSet.AcceptChanges()

    '        With Me.grid图纸
    '            .ActiveRow = .Rows(intRow)
    '            .Rows(intRow).Cells(0).Activate()
    '            .UpdateData()
    '            .PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
    '        End With
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    'Private Sub grid图纸_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
    '    grid图纸.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
    '    grid图纸.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
    'End Sub

    Private Sub txt高_ChangeUICues(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt高.TextChanged, txt长.TextChanged, txt宽.TextChanged
        Try
            Dim db密度 As Double = 0


            Select Case Me.cob材料种类.Text.ToString
                Case "板材"
                    If Me.cob材质.Text <> "" _
                                       AndAlso Me.txt长.Text <> "" _
                                       AndAlso Me.txt宽.Text <> "" _
                                       AndAlso Me.txt高.Text <> "" _
                                        Then
                        db密度 = get密度(Me.cob材质.Text.ToString)

                        If db密度 = 0 Then
                            Exit Try
                        End If



                        Me.txt单件重量.Text = Math.Round(Me.txt长.Text _
                        * Me.txt宽.Text _
                        * Me.txt高.Text _
                        * db密度 / 1000000, 2)
                    End If
                Case "棒材"
                    If Me.cob材质.Text <> "" _
                                 AndAlso Me.txt长.Text <> "" _
                                 AndAlso Me.txt宽.Text <> "" Then
                        db密度 = get密度(Me.cob材质.Text.ToString)

                        If db密度 = 0 Then
                            Exit Try
                        End If
                        Me.txt单件重量.Text = Math.Round(Me.txt长.Text _
                        * (Me.txt宽.Text / 2) ^ 2 * 3.14 _
                        * db密度 / 1000000, 2)
                    End If
                Case "管材"
                    If Me.cob材质.Text <> "" _
                                 AndAlso Me.txt长.Text <> "" _
                                 AndAlso Me.txt宽.Text <> "" _
                                 AndAlso Me.txt高.Text <> "" _
                                  Then

                        'If me.txt宽.text < me.txt高.text Then
                        '    me.txt高.text = 0
                        '    Exit Try
                        'End If

                        db密度 = get密度(Me.cob材质.Text.ToString)

                        If db密度 = 0 Then
                            Exit Try
                        End If
                        Me.txt单件重量.Text = Math.Round((Me.txt长.Text * (Me.txt宽.Text / 2) ^ 2 * 3.14 * db密度 _
                        - Me.txt长.Text * ((Me.txt宽.Text - Me.txt高.Text * 2) / 2) ^ 2 * 3.14 * db密度) / 1000000, 2)
                    End If
                Case "标准件"
                    If IsDBNull(Me.cob材质.Text) _
                                 AndAlso Me.txt长.Text <> "" _
                                 AndAlso Me.txt宽.Text <> "" _
                                 AndAlso Me.txt高.Text <> "" _
                                  Then

                    End If
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


    'Private Sub btnF8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnF8.Click
    '    Dim intRow As Integer
    '    Dim intRowDelete As Integer

    '    Try

    '        If Me.grid图纸.ActiveRow Is Nothing Then
    '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID18)
    '            Return
    '        End If

    '        '「選択された行を削除してもよろしいですか？」
    '        If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID4) = ENU_SHOWMSG.showMsgNo Then
    '            '登録処理終了
    '            Me.Cursor = Cursors.Default
    '            Return
    '        End If


    '        intRow = Me.grid图纸.ActiveRow.VisibleIndex

    '        intRowDelete = Me.grid图纸.ActiveRow.Index

    '        Me.grid图纸.Rows(intRowDelete).Delete(False)

    '        If Me.grid图纸.Rows.VisibleRowCount = 0 Or Me.grid图纸.Rows.Count = 0 Then
    '            '行を追加
    '            'Me.FN_AddGrid範囲NewRow()
    '            intRow = 0
    '        Else
    '            If Me.grid图纸.Rows.VisibleRowCount < intRow Then
    '                intRow = 0
    '            ElseIf Me.grid图纸.Rows.VisibleRowCount = intRow Then
    '                intRow = Me.grid图纸.Rows.VisibleRowCount - 1
    '            End If

    '            Me.grid图纸.Rows.GetRowAtVisibleIndex(intRow).Cells(0).Activated = True
    '            Me.grid图纸.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
    '            Me.grid图纸.UpdateData()
    '        End If
    '    Catch ex As Exception
    '        '異常処理
    '        ExHelper.ProcessEx(ex)
    '    Finally
    '        'デフォルトのカーソル
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    'Private Sub txt产品图号_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles txt主图号.ChangeUICues
    '    Me.TreeView1.Nodes.Clear()
    '    If TreeView1.Nodes.Count = 0 AndAlso Me.txt产品图号1.Text <> "" Then
    '        TreeView1.Nodes.Add(Me.txt产品图号1.Text)
    '        TreeView1.LabelEdit = True

    '    End If
    'End Sub

    'Private Sub txt产品图号_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt主图号.Leave
    '    Me.TreeView1.Nodes.Clear()
    '    If TreeView1.Nodes.Count = 0 AndAlso Me.txt主图号.Text <> "" Then
    '        TreeView1.Nodes.Add(Me.txt主图号.Text)
    '        TreeView1.LabelEdit = True
    '        str节点图号 = Me.txt主图号.Text
    '    End If
    'End Sub
    Private Sub TreeView1_BeforeLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeView1.BeforeLabelEdit
        If CBool(e.Node.Tag) = True Then
            e.CancelEdit = True
        End If
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick


        If TreeView1.SelectedNode Is Nothing Then
            Exit Sub
        End If

        Dim node As TreeNode = TreeView1.SelectedNode
        Me.txt产品图号.Text = node.Text

        If Not node.Parent Is Nothing Then
            Me.txt上级图号.Text = node.Parent.Text
        Else
            Me.txt上级图号.Text = Me.txt主图号.Text
        End If
        Call SetFormData()

        'txt产品图号_Leave(Nothing, Nothing)


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

    Private Sub txt复制_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn复制.Click
        Try
            If Me.txt主图号.Text.Trim = String.Empty Then
                If Me.txt产品图号.Text.Trim = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "主图号", "主图号")
                    txt主图号.Focus()
                    Exit Sub
                End If
            End If

            If Me.txt复制后主图号.Text.Trim = String.Empty Then
                If Me.txt复制后主图号.Text.Trim = String.Empty Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "复制后主图号", "复制后主图号")
                    txt复制后主图号.Focus()
                    Exit Sub
                End If
            End If

            Dim objM图纸T As New M图纸T
            Dim objBll As New BLLM图纸T

            objM图纸T = New M图纸T
            objM图纸T.产品图号 = txt复制后主图号.Text.Trim
            If objBll.LoadByPKey(objM图纸T).产品图号 <> String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")

                txt产品图号.Select()
                '処理終了
                Exit Sub

            End If
            objM图纸T.复制后图号 = txt复制后主图号.Text.Trim
            objM图纸T.主图号 = txt主图号.Text.Trim

            If objBll.insert复制(objM图纸T) > 0 Then

                '成功メッセージを表示する
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                If File.Exists(strPath) Then
                    File.Copy(strPath, strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                End If

            Else
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                Me.txt产品图号.Select()
                Exit Sub
            End If
            'objM图纸T.主图号 = txt主图号.Text.Trim
            'objM图纸T.上级图号 = txt主图号.Text.Trim
            'objM图纸T.产品图号 = txt复制后主图号.Text.Trim
            'objM图纸T.产品图号1 = txt产品图号.Text.Trim
            'objM图纸T.变量 = 2
            'If objBll.LoadAll流转票(objM图纸T).产品图号 <> String.Empty Then
            '    objBll.insert流转票(objM图纸T)
            'End If
            'If objBll.LoadAll工艺卡(objM图纸T).产品图号 <> String.Empty Then
            '    objBll.insert工艺卡(objM图纸T)
            'End If
            'If Not objBll.LoadBy订单(objM图纸T) Is Nothing Then
            '    Dim dt = objBll.LoadBy订单(objM图纸T)
            '    Dim str订单编号 As String = String.Empty
            '    For Each drr As DataRow In dt.Rows
            '        If Not IsDBNull(drr("订单编号")) Then
            '            If str订单编号 = String.Empty Then
            '                str订单编号 = drr("订单编号")
            '            Else
            '                str订单编号 = "'" & str订单编号 & "','" & drr("订单编号") & "'"
            '            End If
            '        End If
            '    Next
            '    objM图纸T.订单编号 = str订单编号
            '    objBll.LoadDataByWhere_Proc(objM图纸T)
            'End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        End Try


    End Sub
#End Region

#Region "InitForm"
    ''' <summary>
    ''' フォーカスの初期設定処理
    ''' </summary>
    ''' <remarks>処理モードによってフォーカスの初期設定処理</remarks>
    Private Sub InitForm()

        Try
            '画面のComboの初期値を設定する
            Me.SetCombo()

            '画面の内容を清空処理
            Me.ClearForm()

            SetFormData()

            '権限の処理            Me.SetPermission()

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub
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

            If Me.dt创建日期.Text.Trim = String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "创建日期", "创建日期")
                dt创建日期.Focus()
                Return False

            End If
            If Me.dt更新日期1.Text.Trim = String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "更新日期", "更新日期")
                dt更新日期1.Focus()
                Return False

            End If
            If Me.cob图纸状态.Text.Trim = String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸状态", "图纸状态")
                cob图纸状态.Focus()
                Return False

            End If
            '图纸版本编号
            If Me.txt图纸版本编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸版本编号", "图纸版本编号")
                txt图纸版本编号.Focus()
                Return False
            End If
            If Me.txt品名.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "品名", "品名")
                txt品名.Focus()
                Return False
            End If

            If Me.txt客户编号.Text.Trim = String.Empty Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "客户编号")
                Return False
            End If

            If Me.txt数量.Text.Trim = String.Empty OrElse Me.txt数量.Text.Trim = "0" Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "数量（套）")
                Return False
            End If

            'If pic图纸.Image Is Nothing Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "图纸图像")
            '    Return False
            'End If

            If Not File.Exists(strPath) AndAlso strPathFlg = True Then
                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID43)
                Return False
            End If
            Select Case Me.cob材料种类.Text
                Case "管材", "板材"
                    If Me.txt长.Text & "" = "" OrElse Me.txt长.Text = 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "长", "长")
                        Return False
                    End If

                    If Me.txt宽.Text & "" = "" OrElse Me.txt宽.Text = 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[宽（直径）]", "[宽（直径）]")
                        Return False
                    End If

                    If Me.txt高.Text & "" = "" OrElse Me.txt高.Text = 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[高（厚度）]", "[高（厚度）]")
                        Return False
                    End If
                Case "棒材"
                    If Me.txt长.Text & "" = "" OrElse Me.txt长.Text = 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "长", "长")
                        Return False
                    End If

                    If Me.txt宽.Text & "" = "" OrElse Me.txt宽.Text = 0 Then
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[宽（直径）]", "[宽（直径）]")
                        Return False
                    End If
                Case Else

            End Select
            'If File.Exists(System.Configuration.ConfigurationManager.AppSettings.Get("PicturePath") & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4)) _
            'AndAlso strPathFlg = True Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID44)
            '    Return False
            'End If


            'If grid图纸.DataSource.rows.Count = 0 Then
            '    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "材料种类", "材料种类")
            '    Me.btnF5行追加.Focus()
            '    Return False
            'Else
            '    For i = 0 To grid图纸.Rows.Count - 1
            '        If grid图纸.Rows(i).Cells("材料种类").Value = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "材料种类", "材料种类")
            '            Return False
            '        End If

            '        If grid图纸.Rows(i).Cells("材质").Value = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "材质", "材质")
            '            Return False
            '        End If

            '        If grid图纸.Rows(i).Cells("型号").Value = "" Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "型号", "型号")
            '            Return False
            '        End If

            '        If grid图纸.Rows(i).Cells("单件重量").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("单件重量").Value = 0 Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "单件重量", "单件重量")
            '            Return False
            '        End If



            '        Select Case grid图纸.Rows(i).Cells("材料种类").Value
            '            Case "管材", "板材"
            '                If grid图纸.Rows(i).Cells("长").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("长").Value = 0 Then
            '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "长", "长")
            '                    Return False
            '                End If

            '                If grid图纸.Rows(i).Cells("宽（直径）").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("宽（直径）").Value = 0 Then
            '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[宽（直径）]", "[宽（直径）]")
            '                    Return False
            '                End If

            '                If grid图纸.Rows(i).Cells("高（厚度）").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("高（厚度）").Value = 0 Then
            '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[高（厚度）]", "[高（厚度）]")
            '                    Return False
            '                End If
            '            Case "棒材"
            '                If grid图纸.Rows(i).Cells("长").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("长").Value = 0 Then
            '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "长", "长")
            '                    Return False
            '                End If

            '                If grid图纸.Rows(i).Cells("宽（直径）").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("宽（直径）").Value = 0 Then
            '                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[宽（直径）]", "[宽（直径）]")
            '                    Return False
            '                End If
            '            Case Else

            '        End Select


            '        If grid图纸.Rows(i).Cells("数量（每套）").Value.ToString & "" = "" OrElse grid图纸.Rows(i).Cells("数量（每套）").Value = 0 Then
            '            CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "[数量（每套）]", "[数量（每套）]")
            '            Return False
            '        End If
            '    Next
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

    Private Sub txt客户编号_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt客户编号.Enter
        Me.txt客户编号.Tag = Me.txt客户编号.Text.Trim
    End Sub
#End Region
#End Region

#Region "SetCombo"

    Private Sub SetCombo()

        Dim dtCbo As DataTable = Nothing            'コンボボックスデータテーブル
        Try
            '使用状态            Utility.PFn_SetCombo(Me.cob材料种类, "VM材料种类", 1)
            Utility.PFn_SetCombo(Me.cob图纸状态, "VM图纸状态", 0)
            Utility.PFn_SetCombo(Me.cob材质, "VM材质", 1)
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
            Me.btnF7.Enabled = Utility.PFn_GetAuth(Me.btnF7.Tag)
            Me.btnF8.Enabled = Utility.PFn_GetAuth(Me.btnF8.Tag)
            Me.btn复制.Enabled = Utility.PFn_GetAuth(Me.btn复制.Tag)
            Me.btn图纸导入.Enabled = Utility.PFn_GetAuth(Me.btn图纸导入.Tag)
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
            Me.txt主图号.Text = String.Empty
            Me.txt主图号品名.Text = String.Empty
            Me.txt分图号.Text = String.Empty
            Me.txt产品图号.Text = String.Empty
            Me.txt图纸版本编号.Text = String.Empty
            Me.txt品名.Text = String.Empty
            Me.txt客户编号.Text = String.Empty
            Me.txt客户名称.Text = String.Empty
            Me.txt数量.Text = "1"
            Me.cob材料种类.Text = String.Empty
            Me.cob图纸状态.Value = 1
            Me.cob材质.Text = String.Empty
            Me.txt材料代号.Text = String.Empty
            'Me.txt原材料名称.Text = String.Empty
            Me.txt长.Text = String.Empty
            Me.txt宽.Text = String.Empty
            Me.txt高.Text = String.Empty
            Me.txt单件重量.Text = String.Empty
            Me.txt要求.Text = String.Empty
            Me.txt备注.Text = String.Empty
            Me.dt创建日期.Text = Date.Now
            Me.dt创建日期.Text = Date.Now
            Me.pic图纸.Image = Nothing
            Me.TreeView1.Nodes.Clear()
            strPathFlg = False
            Me.txt复制后主图号.Text = String.Empty
            Me.txt原材料编号.Text = String.Empty
            Me.txt材料名称.Text = String.Empty
            Me.txt主图号.Select()

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
                    txt主图号.ReadOnly = False
                    txt产品图号.ReadOnly = False
                    labModel.Text = Constant.cgStrNew
                    'txt产品图号.Select()
                Case Constant.ENU_MODE.Model_Update
                    txt主图号.ReadOnly = True
                    txt产品图号.ReadOnly = False
                    labModel.Text = Constant.cgStrUpdate
                    'txt图纸版本编号.Select()
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
    ''' 画面の保存処理    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()

        Try
            Dim objM图纸T As New M图纸T
            Dim objBll As New BLLM图纸T
            Dim arryList As New ArrayList

            objM图纸T = New M图纸T
            objM图纸T.产品图号1 = strChang
            objM图纸T.产品图号 = txt产品图号.Text.Trim
            objM图纸T.图纸版本编号 = txt图纸版本编号.Text.Trim
            objM图纸T.品名 = txt品名.Text.Trim
            objM图纸T.客户编号 = txt客户编号.Text.Trim
            objM图纸T.图纸图片 = Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4)

            If Not Me.txt原材料编号.Text & "" = "" Then
                objM图纸T.原材料编号 = Me.txt原材料编号.Text
            End If
            'If Not Me.cob材料种类.Value & "" = "" Then
            '    objM图纸T.材料种类 = Me.cob材料种类.Value
            'End If

            'If Not Me.cob材质.Value & "" = "" Then
            '    objM图纸T.材质 = Me.cob材质.Value
            'End If

            If Not Me.cob图纸状态.Value & "" = "" Then
                objM图纸T.图纸状态 = Me.cob图纸状态.Value
            End If

            objM图纸T.主图号 = Me.txt主图号.Text

            If Me.txt主图号.Text.Trim = Me.txt产品图号.Text.Trim Then
                objM图纸T.上级图号 = Me.txt主图号.Text.Trim
                'Else

                '    If TreeView1.Nodes(Me.txt产品图号.Text.Trim).Parent Is Nothing Then
                '        objM图纸T.上级图号 = Me.txt主图号.Text.Trim
                '    Else
                '        objM图纸T.上级图号 = TreeView1.Nodes(Me.txt产品图号.Text.Trim).Parent.Text
                '    End If
            Else
                objM图纸T.上级图号 = Me.txt上级图号.Text.Trim
            End If


            'objM图纸T.图纸状态 = Me.cob图纸状态.Value
            'objM图纸T.材料代码 = Me.txt材料代号.Text
            objM图纸T.单件重量 = Me.txt单件重量.Text
            objM图纸T.长 = Me.txt长.Text
            objM图纸T.宽 = Me.txt宽.Text
            objM图纸T.高 = Me.txt高.Text
            objM图纸T.数量 = Me.txt数量.Text
            objM图纸T.要求 = Me.txt要求.Text
            objM图纸T.备注 = Me.txt备注.Text
            objM图纸T.创建日期 = Me.dt创建日期.Value
            objM图纸T.登录者 = gObjM_人员T.人员编号
            objM图纸T.登录日期 = DateTime.Now
            objM图纸T.更新者 = gObjM_人员T.人员编号
            objM图纸T.更新日期 = Me.dt更新日期1.Value
            objM图纸T.主图号 = txt主图号.Text
            arryList.Add(objM图纸T)

            Dim dt As New DataTable

            If Me.txt主图号.Text <> "" Then
                Dim dtMax As New DataTable
                Dim IntMax As Integer
                Dim int关系ID As Integer
                dtMax = objBll.LoadIDMax()
                IntMax = dtMax.Rows(0).Item("ID")
                int关系ID = dtMax.Rows(0).Item("关系ID")
                dt = getTreeView(IntMax, int关系ID)
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "产品图号", "产品图号")
                    Exit Sub
                End If
            End If

            Select Case mIntFormMode

                Case Constant.ENU_MODE.Model_New

                    If objBll.LoadByPKey(objM图纸T).产品图号 <> String.Empty Then

                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID21, "产品图号")

                        txt产品图号.Select()
                        '処理終了
                        Exit Sub

                    End If

                    If objBll.Insert(arryList, dt) > 0 Then

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrNew)

                        If File.Exists(strPath) Then
                            File.Copy(strPath, strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                        End If



                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrNew)
                        Me.txt产品图号.Select()
                        Exit Sub
                    End If

                Case Constant.ENU_MODE.Model_Update

                    If objBll.Update(objM图纸T, dt) > 0 Then

                        If strPathFlg Then

                            If File.Exists(strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4)) Then
                                File.Delete(strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4))
                            End If

                            If File.Exists(strPath) Then
                                File.Copy(strPath, strServerPicturePath & Me.txt产品图号.Text & Strings.Right(Path.GetFileName(strPath), 4), True)
                            End If
                        End If

                        '成功メッセージを表示する
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID11, Constant.cgStrUpdate)
                        If strFlg Then
                            objM图纸T.主图号 = txt主图号.Text.Trim
                            objM图纸T.上级图号 = txt主图号.Text.Trim
                            objM图纸T.产品图号 = txt产品图号.Text.Trim
                            '    objM图纸T.产品图号1 = strChang
                            objM图纸T.变量 = 1
                            If objBll.LoadAll流转票(objM图纸T).产品图号 <> String.Empty Then
                                objBll.insert流转票(objM图纸T)
                            End If
                            If objBll.LoadAll工艺卡(objM图纸T).产品图号 <> String.Empty Then
                                objBll.insert工艺卡(objM图纸T)
                            End If
                            If Not objBll.LoadBy订单(objM图纸T) Is Nothing Then
                                Dim ds = objBll.LoadBy订单(objM图纸T)
                                Dim str订单编号 As String = String.Empty
                                For Each drr As DataRow In ds.Rows
                                    If Not IsDBNull(drr("订单编号")) Then
                                        If str订单编号 = String.Empty Then
                                            str订单编号 = drr("订单编号")
                                        Else
                                            str订单编号 = "'" & str订单编号 & "','" & drr("订单编号") & "'"
                                        End If
                                    End If
                                Next
                                objM图纸T.订单编号 = str订单编号
                                objBll.LoadDataByWhere_Proc(objM图纸T)
                            End If
                        End If
                    Else
                        CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID29, Constant.cgStrUpdate)
                        Me.txt产品图号.Focus()
                        Exit Sub
                    End If

            End Select
            'Me.ClearForm()
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

#Region "SetFormData"
    Public Sub ShowImgByByte(ByVal imgBytesIn As Byte())
        Dim ms As New MemoryStream(imgBytesIn)
        pic图纸.Image = Image.FromStream(ms)
    End Sub

#End Region

#Region "SetFormData"

    Private Sub SetFormData()
        Dim objM图纸T As New M图纸T
        Dim objBll As BLLM图纸T

        Try
            '获取数据
            objM图纸T = New M图纸T
            objBll = New BLLM图纸T


            objM图纸T.产品图号 = txt产品图号.Text.Trim()
            objM图纸T.主图号 = txt主图号.Text.Trim()
            objM图纸T.上级图号 = txt上级图号.Text.Trim()
            If String.IsNullOrEmpty(objM图纸T.产品图号) Then
                objM图纸T.产品图号 = " "
            End If
            mdsInfoDataSet = objBll.LoadAll图纸(objM图纸T)
            If Not mdsInfoDataSet Is Nothing And mdsInfoDataSet.Rows.Count > 0 Then


                Me.txt产品图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString()
                Me.txt图纸版本编号.Text = mdsInfoDataSet.Rows(0)("图纸版本编号").ToString()
                Me.txt品名.Text = mdsInfoDataSet.Rows(0)("品名").ToString()
                Me.txt客户编号.Text = mdsInfoDataSet.Rows(0)("客户编号").ToString()
                Me.txt客户名称.Text = mdsInfoDataSet.Rows(0)("客户名称").ToString()
                Me.txt数量.Text = mdsInfoDataSet.Rows(0)("数量").ToString()
                Me.txt原材料编号.Text = mdsInfoDataSet.Rows(0)("原材料编号").ToString()
                'Me.cob材料种类.Text = mdsInfoDataSet.Rows(0)("材料种类").ToString()
                'Me.cob材质.Text = mdsInfoDataSet.Rows(0)("材质").ToString()
                Me.cob图纸状态.Text = mdsInfoDataSet.Rows(0)("图纸状态").ToString()
                'Me.txt材料代号.Text = mdsInfoDataSet.Rows(0)("材料代号").ToString()
                'Me.txt原材料名称.Text = mdsInfoDataSet.Rows(0)("原材料名称").ToString()
                Me.txt长.Text = mdsInfoDataSet.Rows(0)("长").ToString()
                Me.txt宽.Text = mdsInfoDataSet.Rows(0)("宽").ToString()
                Me.txt高.Text = mdsInfoDataSet.Rows(0)("高").ToString()
                Me.txt单件重量.Text = mdsInfoDataSet.Rows(0)("单件重量").ToString()
                Me.txt要求.Text = mdsInfoDataSet.Rows(0)("要求").ToString()
                Me.txt备注.Text = mdsInfoDataSet.Rows(0)("备注").ToString()
                Me.dt创建日期.Text = mdsInfoDataSet.Rows(0)("创建日期").ToString()
                Me.dt更新日期1.Text = mdsInfoDataSet.Rows(0)("更新日期").ToString()
                txt原材料编号_Validating(Nothing, Nothing)
                Try
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
                Catch ex As Exception

                End Try

                If objBll.LoadTree(objM图纸T).Rows.Count > 0 Then
                    Me.txt主图号.Text = mdsInfoDataSet.Rows(0)("产品图号").ToString()
                    txt主图号_Leave(Nothing, Nothing)
                End If
                'Me.pic图纸.Image = Image.FromFile(strServerPicturePath & mdsInfoDataSet.Rows(0)("图纸").ToString())
                'strPath = mdsInfoDataSet.Rows(0)("图纸").ToString()
                strPathFlg = False

                '画面の修正処理                mIntFormMode = Constant.ENU_MODE.Model_Update
                SetFormModel()

            Else
                mdsInfoDataSet1 = objBll.LoadAll图纸1(objM图纸T)
                If Not mdsInfoDataSet1 Is Nothing And mdsInfoDataSet1.Rows.Count > 0 Then
                    Me.txt图纸版本编号.Text = String.Empty
                    Me.txt品名.Text = String.Empty
                    Me.txt客户编号.Text = mdsInfoDataSet1.Rows(0)("客户编号").ToString()
                    Me.txt客户名称.Text = mdsInfoDataSet1.Rows(0)("客户名称").ToString()
                    Me.txt数量.Text = "1"
                    Me.cob材料种类.Text = String.Empty
                    Me.cob材质.Text = String.Empty
                    Me.cob图纸状态.Value = 1
                    Me.txt材料代号.Text = String.Empty
                    Me.txt长.Text = String.Empty
                    Me.txt宽.Text = String.Empty
                    Me.txt高.Text = String.Empty
                    Me.txt单件重量.Text = String.Empty
                    Me.txt要求.Text = String.Empty
                    Me.txt备注.Text = String.Empty
                    Me.pic图纸.Image = Nothing
                    strPathFlg = False
                    mIntFormMode = Constant.ENU_MODE.Model_New
                    SetFormModel()
                Else
                    Me.txt图纸版本编号.Text = String.Empty
                    Me.txt品名.Text = String.Empty
                    Me.txt客户编号.Text = String.Empty
                    Me.txt客户名称.Text = String.Empty
                    Me.txt数量.Text = "1"
                    Me.cob材料种类.Text = String.Empty
                    Me.cob材质.Text = String.Empty
                    Me.cob图纸状态.Value = 1
                    Me.txt材料代号.Text = String.Empty
                    Me.txt长.Text = String.Empty
                    Me.txt宽.Text = String.Empty
                    Me.txt高.Text = String.Empty
                    Me.txt单件重量.Text = String.Empty
                    Me.txt要求.Text = String.Empty
                    Me.txt备注.Text = String.Empty

                    Me.pic图纸.Image = Nothing
                    strPathFlg = False

                    mIntFormMode = Constant.ENU_MODE.Model_New
                    SetFormModel()
                End If
            End If

            'mdsGridDataSet = objBll.LoadAllGrid(objM图纸T)
            'If Not mdsGridDataSet Is Nothing And mdsGridDataSet.Rows.Count > 0 Then
            'grid图纸.DataSource = mdsGridDataSet
            'grid图纸管理.DisplayLayout.Bands(0).Columns("产品图号CD").Hidden = True



            'BindGridCombox()
            'End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub DiGuiLoad(ByRef tn As TreeNode, ByVal strTreeName As String, ByVal str产品图号 As String)
        '1.将当前节点显示到lable上
        If tn.Text = strTreeName Then
            Dim node As TreeNode = tn
            If Not node Is Nothing Then
                'node.Nodes.Add((TreeView1.GetNodeCount(False) + 1) & "级图号")

                'node.Nodes.Add((TreeView1.GetNodeCount(False) + 1) & "级图号")
                node.Nodes.Add(str产品图号)
            End If

        End If
        For Each tnSub As TreeNode In tn.Nodes
            DiGuiLoad(tnSub, strTreeName, str产品图号)
        Next
    End Sub
#End Region

#Region "Tree"
    Private Sub getTree()


        strTree = String.Empty

        '#Region "递归"
        '1.获取TreeView的所有根节点
        For Each tn As TreeNode In TreeView1.Nodes
            DiGui(tn)
        Next

        '#End Region


    End Sub

    Private Sub DiGui(ByVal tn As TreeNode)
        '1.将当前节点显示到lable上
        strTree += tn.Level & "|" & Convert.ToString(tn.Text) & vbCr & vbLf
        For Each tnSub As TreeNode In tn.Nodes
            DiGui(tnSub)
        Next
    End Sub

    Public Function getTreeView(ByVal IntMax As Integer, ByVal int关系ID As Integer) As DataTable
        Dim dt As New DataTable
        Dim dr As DataRow
        Dim strTrees As String()
        Dim intNo As Integer = 0
        Call getTree()

        dt.Columns.Add("ID")
        dt.Columns.Add("CIID")
        dt.Columns.Add("图号")
        dt.Columns.Add("关系ID")
        intNo = IntMax + 1
        int关系ID = int关系ID + 1
        strTrees = strTree.Split(vbCr & vbLf)
        Dim intID As Integer = 0
        Dim intID0 As Integer = 0
        Dim intID1 As Integer = 0
        Dim intID2 As Integer = 0

        Dim intID3 As Integer = 0

        Dim intID4 As Integer = 0

        Dim intCIID As Integer = 0

        Dim int上行CIID As Integer = 0
        For Each Str As String In strTrees
            If Str.Split("|").Length = 2 Then
                dr = dt.NewRow
                dr("ID") = intNo
                If Me.txt主图号.Text = Str.Split("|")(1).Trim Then
                    dr("CIID") = 0
                Else
                    If Str.Split("|")(0).Trim > intCIID Then
                        dr("CIID") = intID
                    ElseIf Str.Split("|")(0).Trim < intCIID Then
                        Select Case Str.Split("|")(0).Trim - 1
                            Case 0
                                dr("CIID") = intID0
                            Case 1
                                dr("CIID") = intID1
                            Case 2
                                dr("CIID") = intID2
                            Case 3
                                dr("CIID") = intID3
                            Case 4
                                dr("CIID") = intID4
                            Case Else
                        End Select

                    Else
                        dr("CIID") = int上行CIID
                    End If

                End If
                dr("图号") = Str.Split("|")(1).Trim
                dr("关系ID") = int关系ID
                intNo = intNo + 1
                intID = dr("ID")

                Select Case Str.Split("|")(0).Trim
                    Case 0
                        intID0 = dr("ID")
                    Case 1
                        intID1 = dr("ID")
                    Case 2
                        intID2 = dr("ID")
                    Case 3
                        intID3 = dr("ID")
                    Case 4
                        intID4 = dr("ID")
                    Case Else
                End Select

                intCIID = Str.Split("|")(0).Trim
                int上行CIID = dr("CIID")
                dt.Rows.Add(dr)
            End If
        Next
        Return dt
    End Function

    Public Sub addto(ByVal nd As nn, ByVal nodes As TreeNodeCollection)
        Dim dd As TreeNode
        Dim tmpd As TreeNode
        If nd.snumber = "0" Then
            tmpd = nodes.Add(nd.name)
            tmpd.ToolTipText = nd.parent
            Exit Sub
        Else
            For Each dd In nodes
                If nd.snumber = dd.ToolTipText Then
                    tmpd = dd.Nodes.Add(nd.name)
                    tmpd.ToolTipText = nd.parent
                    Exit Sub
                End If
                addto(nd, dd.Nodes)
            Next
        End If
    End Sub
#End Region

#Region "图片大小设定"
    Public Function get密度(ByVal str材质 As String) As Double
        Dim objM图纸T As New M图纸T
        Dim objBll As BLLM图纸T
        Dim dt密度 As New DataTable

        Try
            '获取数据
            objM图纸T = New M图纸T
            objBll = New BLLM图纸T

            objM图纸T.材质 = str材质
            If String.IsNullOrEmpty(objM图纸T.材质) Then
                Return 0
            End If

            dt密度 = objBll.LoadAll密度(objM图纸T)

            If Not dt密度 Is Nothing OrElse dt密度.Rows.Count > 0 Then
                Return dt密度.Rows(0).Item("密度")
            Else
                Return 0
            End If

            'End If
        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)
        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Function
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