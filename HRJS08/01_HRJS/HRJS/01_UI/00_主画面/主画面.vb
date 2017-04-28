Imports HRJS.Constant
Imports HRJS.Utility
Imports System.IO
Imports UserControl


Public Class 主画面
#Region " 常数定義 "

    Private Const CSTRLOGIN As String = "登陆"
    Private Const CSTRLOGOFF As String = "注销"
    Private Const CON_VER As String = "Ver."                'Ver

    Private Const LIST_NAME_マスタ_マスタ As String = "マスタ"

#End Region

#Region " 変数定義 "

    Private mDt担当権限 As DataTable = Nothing                  '権限情報
    Private mstrBaseName As String = String.Empty
    Private myTimer As System.Windows.Forms.Timer
    Private mdtSearch As DataTable
    Private counter As Integer

#End Region

#Region "Form Event "

    Private Sub 主画面_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Configuration.PSb_SaveSystemInfo()
            SetPermission()

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub 主画面_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If Me.btnLogoOff.Text.ToString.Contains(CSTRLOGOFF) Then
            '确认信息(MsgID=1)
            If CommonMsg.PFn_ShowMsg(Me.Text, ENU_MSGID.MSGID1) = _
                        Constant.ENU_SHOWMSG.showMsgYes Then

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

    Private Sub txt密码_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt密码.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn登陆_Click(sender, e)
        End If
    End Sub
#End Region

#Region "Button"

#Region "系统"

    ''' '=================================================
    ''' <summary>
    ''' btn登陆_Click
    ''' </summary>
    ''' <remarks>用户登录</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn登陆_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn登陆.Click

        Dim objM人员T As M人员T
        Dim objBll As BLL主画面

        Dim bln担当Check As Boolean

        Try
            '砂時計のカーソルが設定

            Me.Cursor = Cursors.WaitCursor



            '人员
            If Me.txt人员ID.Text.Trim = String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "用户名")
                Me.txt人员ID.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub

            End If

            '密码
            If Me.txt密码.Text.Trim = String.Empty Then

                CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID13, "密码")
                Me.txt密码.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub

            End If

            '人员CD、密码チェック

            objM人员T = New M人员T

            objM人员T.人员编号 = Me.txt人员ID.Text.Trim
            objM人员T.密码 = Me.txt密码.Text.Trim

            objBll = New BLL主画面


            bln担当Check = objBll.Check担当(objM人员T)

            '人员マスタ存在しない、メッセージが表示する（ID=1）人员CDにフォーカスを設定する

            If bln担当Check = False Then
                Me.Cursor = Cursors.Default
                CommonMsg.PFn_ShowMsg(Me.Text.ToString, Constant.ENU_MSGID.MSGID35)
                Me.txt人员ID.Focus()
                Exit Sub
            End If

            '人员CD、密码より、人员マスタを検索する

            objM人员T = New M人员T
            objM人员T.人员编号 = Me.txt人员ID.Text.Trim

            gObjM_人员T = objBll.Get担当Info(objM人员T)

            '画面ロック処理

            'Me.SetControlEnabled()

            '権限情報の取得

            mDt担当権限 = objBll.Get担当権限(objM人员T)

            '権限()
            SetPermission()

            'Me.txt人员ID.Text = String.Empty
            'Me.txt密码.Text = String.Empty
            Me.txt人员ID.ReadOnly = True
            Me.txt密码.ReadOnly = True

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            '異常処理
            ExHelper.ProcessEx(ex)

        Finally
            'デフォルトのカーソル
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn注销_Click
    ''' </summary>
    ''' <remarks>用户注销</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn注销_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn注销.Click
        Try

            If CommonMsg.PFn_ShowMsg(Me.Text, Constant.ENU_MSGID.MSGID34) = Constant.ENU_SHOWMSG.showMsgNo Then
                '処理終了
                Exit Sub
            End If
            gObjM_人员T = New M人员T

            Me.txt人员ID.Text = String.Empty
            Me.txt密码.Text = String.Empty

            SetPermission()
            Me.txt人员ID.ReadOnly = False
            Me.txt密码.ReadOnly = False
            Me.txt人员ID.Focus()

        Catch ex As Exception
            '异常处理
            ExHelper.ProcessEx(ex)
        Finally
            '释放光标
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "基础数据"

#Region "部门管理"

    ''' '=================================================
    ''' <summary>
    ''' btn部门管理_Click
    ''' </summary>
    ''' <remarks>部门详细信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn部门管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn部门管理.Click
        Try

            Dim frm As New frm部门管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn货位管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn货位管理.Click
        Try

            Dim frm As New frm货位管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn部门一览_Click
    ''' </summary>
    ''' <remarks>部门信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn部门一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn部门一览.Click
        Try

            Dim frm As New frm部门一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn货位一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn货位一览.Click
        Try

            Dim frm As New frm货位一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "人员管理"

    ''' '=================================================
    ''' <summary>
    ''' btn人员管理_Click
    ''' </summary>
    ''' <remarks>人员详细信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn人员管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn人员管理.Click
        Try

            Dim frm As New frm人员管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn人员一览_Click
    ''' </summary>
    ''' <remarks>人员信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn人员一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn人员一览.Click
        Try

            Dim frm As New frm人员一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "客户管理"

    ''' '=================================================
    ''' <summary>
    ''' btn客户管理_Click
    ''' </summary>
    ''' <remarks>客户详细信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn客户管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn客户管理.Click
        Try

            Dim frm As New frm客户管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub






    ''' '=================================================
    ''' <summary>
    ''' btn客户一览_Click
    ''' </summary>
    ''' <remarks>客户信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn客户一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn客户一览.Click
        Try

            Dim frm As New frm客户一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "供应商管理"
    Private Sub btn供应商管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn供应商管理.Click

        Try

            Dim frm As New frm供应商管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn供应商一览_click(ByVal sender As Object, ByVal e As EventArgs) Handles btn供应商一览.Click

        Try
            Dim frm As New frm供应商一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "生产设备管理"

    ''' '=================================================
    ''' <summary>
    ''' btn生产设备管理_Click
    ''' </summary>
    ''' <remarks>生产设备详细信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn生产设备管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产设备管理.Click
        Try

            Dim frm As New frm生产设备管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn生产设备一览_Click
    ''' </summary>
    ''' <remarks>生产设备信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn生产设备一览_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产设备一览.Click
        Try

            Dim frm As New frm生产设备一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "终端设备管理"

    ''' '=================================================
    ''' <summary>
    ''' btn终端设备管理_Click
    ''' </summary>
    ''' <remarks>终端设备详细信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn终端设备管理_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btn终端设备管理.Click
        Try

            Dim frm As New frm终端设备管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn终端设备一览_Click
    ''' </summary>
    ''' <remarks>终端设备信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn终端设备一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn终端设备一览.Click
        Try

            Dim frm As New frm终端设备一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "模具管理"
    Private Sub btn模具管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn模具管理.Click
        Try

            Dim frm As New frm模具管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn模具一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn模具一览.Click
        Try

            Dim frm As New frm模具一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "产品种类管理"

    ''' '=================================================
    ''' <summary>
    ''' btn产品种类管理_Click
    ''' </summary>
    ''' <remarks>产品种类管理信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn产品种类管理_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try

            Dim frm As New frm产品种类管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn产品种类一览_Click
    ''' </summary>
    ''' <remarks>产品种类信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn产品种类一览_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim frm As New frm产品种类一览            frm.btnF3选择.Visible = False

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "数据备份"

    ''' '=================================================
    ''' <summary>
    ''' btn数据备份_Click
    ''' </summary>
    ''' <remarks>用户数据备份</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn数据备份_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn数据备份.Click
        Try

            Dim frm As New frm数据备份
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "原材料信息管理"
    ''' '=================================================
    ''' <summary>
    ''' btn产品种类管理_Click
    ''' </summary>
    ''' <remarks>产品种类管理信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料信息管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料信息管理.Click
        Try

            Dim frm As New frm原材料信息管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn产品种类一览_Click
    ''' </summary>
    ''' <remarks>产品种类信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料信息一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料信息一览.Click
        Try

            Dim frm As New frm原材料信息一览            frm.btnF3选择.Visible = False

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "包装管理"
    ''' '=================================================
    ''' <summary>
    ''' btn包装管理_Click
    ''' </summary>
    ''' <remarks>包装管理信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn包装管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn包装管理.Click
        Try

            Dim frm As New frm包装管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn包装一览_Click
    ''' </summary>
    ''' <remarks>包装管理信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn包装一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn包装一览.Click
        Try

            Dim frm As New frm包装一览            frm.btnF3选择.Visible = False

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "生产标签打印"
    ''' '=================================================
    ''' <summary>
    ''' btn生产标签打印_Click
    ''' </summary>
    ''' <remarks>生产标签打印</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn成品标签打印_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn成品标签打印.Click
        Try

            Dim frm As New frm成品标签打印

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn原材料标签打印_Click
    ''' </summary>
    ''' <remarks>btn原材料标签打印、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料标签打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn原材料标签打印.Click
        Try
            Dim frm As New frm原材料标签打印
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn外协品标签打印_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品标签打印.Click
        Try
            Dim frm As New frm外协品标签打印
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
#End Region

#End Region

#Region "业务部"

#Region "订单管理"

    ''' '=================================================
    ''' <summary>
    ''' btn订单录入_Click
    ''' </summary>
    ''' <remarks>订单信息的录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn订单录入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn订单录入.Click
        Try

            Dim frm As New frm订单录入
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn订单一览_Click
    ''' </summary>
    ''' <remarks>订单信息查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn订单一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn订单一览.Click
        Try

            Dim frm As New frm订单一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn订单进度查询_Click
    ''' </summary>
    ''' <remarks>订单进度查询浏览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn订单进度查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn订单进度查询.Click
        Try

            Dim frm As New frm订单进度查询
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "库存管理"

    ''' '=================================================
    ''' <summary>
    ''' btn入出库记录一览_Click
    ''' </summary>
    ''' <remarks>入出库信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn入出库记录一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn入出库记录一览.Click
        Try

            Dim frm As New frm入出库记录一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn库存一览_Click
    ''' </summary>
    ''' <remarks>库存信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn库存一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn库存一览.Click

        Try

            Dim frm As New frm成品库存一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn盘点查询_Click
    ''' </summary>
    ''' <remarks>库存盘点信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn盘点查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn盘点查询.Click
        Try

            Dim frm As New frm成品盘点管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "返品管理"

    ''' '=================================================
    ''' <summary>
    ''' btn返品查询_Click
    ''' </summary>
    ''' <remarks>返品信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn返品查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn返品查询.Click
        Try

            Dim frm As New frm返品一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "出荷管理"

    ''' '=================================================
    ''' <summary>
    ''' btn出荷指示发行_Click
    ''' </summary>
    ''' <remarks>出荷信息的录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn出荷指示发行_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn出荷指示发行.Click
        Try

            Dim frm As New frm出荷指示发行
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn出荷一览_Click
    ''' </summary>
    ''' <remarks>出荷信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn出荷一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn出荷一览.Click
        Try

            Dim frm As New frm出荷一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "原材料管理"

    ''' '=================================================
    ''' <summary>
    ''' btn原材料采购管理_Click
    ''' </summary>
    ''' <remarks>原材料采购信息的录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料采购管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料采购管理.Click
        Try

            Dim frm As New frm原材料采购管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn原材料采购一览_Click
    ''' </summary>
    ''' <remarks>原材料采购信息的查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料采购一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料采购一览.Click
        Try

            Dim frm As New frm原材料采购一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn原材料出库管理_Click
    ''' </summary>
    ''' <remarks>原材料出库信息的录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料出库管理_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim frm As New frm原材料出库管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn原材料库存一览_Click
    ''' </summary>
    ''' <remarks>原材料库存信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料库存一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn原材料库存一览.Click
        Try

            Dim frm As New frm原材料库存一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn原材料入出库一览_Click
    ''' </summary>
    ''' <remarks>原材料入出库信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料入出库一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料入出库一览.Click
        Try

            Dim frm As New frm原材料入出库一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn原材料盘点查询_Click
    ''' </summary>
    ''' <remarks>原材料库存盘点信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn原材料盘点查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料盘点查询.Click
        Try

            Dim frm As New frm原材料盘点管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "外协管理"

    ''' '=================================================
    ''' <summary>
    ''' btn外协加工管理_Click
    ''' </summary>
    ''' <remarks>外协加工信息的录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协加工管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协加工管理.Click
        Try

            Dim frm As New frm外协加工管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn外协加工一览_Click
    ''' </summary>
    ''' <remarks>外协加工信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协加工一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协加工一览.Click
        Try

            Dim frm As New frm外协加工一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn外协申请一览_Click
    ''' </summary>
    ''' <remarks>外协加工申请信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协申请一览_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim frm As New frm外协申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "外协品管理"

    ''' '=================================================
    ''' <summary>
    ''' btn外协品库存一览_Click
    ''' </summary>
    ''' <remarks>外协品库存信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品库存一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品库存一览.Click
        Try

            Dim frm As New frm半成品库存一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn成品入库申请_Click
    ''' </summary>
    ''' <remarks>成品入库申请</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn成品入库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn成品入库申请.Click
        Try

            Dim frm As New frm成品入库申请


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn成品入库申请一览_Click
    ''' </summary>
    ''' <remarks>成品入库申请</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn成品入库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn成品入库申请一览.Click
        Try

            Dim frm As New frm成品入库申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn外协品入出库一览_Click
    ''' </summary>
    ''' <remarks>外协品入出库信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品入出库一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品入出库一览.Click
        Try

            Dim frm As New frm半成品入出库一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn外协品盘点一览_Click
    ''' </summary>
    ''' <remarks>外协品盘点信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品盘点查询_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品盘点查询.Click
        Try

            Dim frm As New frm外协品盘点管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn外协品入库管理_Click
    ''' </summary>
    ''' <remarks>外协品入库管理</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品入库管理_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            Dim frm As New frm原材料入库管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "半成品入出库申请一览"
    ''' '=================================================
    ''' <summary>
    ''' btn半成品入库申请一览_Click
    ''' </summary>
    ''' <remarks>半成品入库申请一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn半成品入出库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn半成品入库申请一览.Click
        Try

            Dim frm As New frm半成品入库申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn半成品出库申请一览_Click
    ''' </summary>
    ''' <remarks>半成品出库申请一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn半成品出库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn半成品出库申请一览.Click
        Try

            Dim frm As New frm半成品出库申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "外协品入出库申请一览"
    ''' '=================================================
    ''' <summary>
    ''' btn外协品入库申请一览_Click
    ''' </summary>
    ''' <remarks>半成品入库申请一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品入出库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品入库申请一览.Click
        Try

            Dim frm As New frm外协品入库申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' '=================================================
    ''' <summary>
    ''' btn外协品出库申请一览_Click
    ''' </summary>
    ''' <remarks>外协品出库申请一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn外协品出库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品出库申请一览.Click
        Try

            Dim frm As New frm外协品出库申请一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "废料管理"

    ''' '=================================================
    ''' <summary>
    ''' btn废料回收管理_Click
    ''' </summary>
    ''' <remarks>废料回收信息录入、修改</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn废料回收管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn废料回收管理.Click
        Try

            Dim frm As New frm废料回收管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn废料回收一览_Click
    ''' </summary>
    ''' <remarks>废料回收信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn废料回收一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn废料回收一览.Click
        Try

            Dim frm As New frm废料回收一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn废料入出库一览_Click
    ''' </summary>
    ''' <remarks>废料入出库存信息查询</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn废料入出库一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn废料入出库一览.Click
        Try

            Dim frm As New frm废料入出库一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#End Region

#Region "技术部"

#Region "图纸管理"

    ''' '=================================================
    ''' <summary>
    ''' btn图纸管理_Click
    ''' </summary>
    ''' <remarks>图纸录入</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn图纸管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn图纸管理.Click
        Try

            Dim frm As New frm图纸信息管理
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn图纸一览_Click
    ''' </summary>
    ''' <remarks>图纸信息一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn图纸一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn图纸一览.Click
        Try

            Dim frm As New frm图纸信息一览            frm.btnF3选择.Visible = False

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "工艺卡管理"

    ''' '=================================================
    ''' <summary>
    ''' btn工艺卡管理_Click
    ''' </summary>
    ''' <remarks>工艺卡录入</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn工艺卡管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn工艺卡管理.Click
        Try

            Dim frm As New frm工艺卡录入

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    ''' '=================================================
    ''' <summary>
    ''' btn工艺卡一览_Click_Click
    ''' </summary>
    ''' <remarks>工艺卡信息一览</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn工艺卡一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn工艺卡一览.Click
        Try

            Dim frm As New frm工艺卡信息一览            frm.btnF3选择.Visible = False

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "流转票管理"
    ''' '=================================================
    ''' <summary>
    ''' btn流转票管理_Click
    ''' </summary>
    ''' <remarks>流转票录入</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn流转票管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn流转票管理.Click
        Try

            Dim frm As New frm流转票管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region



#Region "流转票管理"
    ''' '=================================================
    ''' <summary>
    ''' btn流转票管理_Click
    ''' </summary>
    ''' <remarks>流转票录入</remarks>
    ''' <history>
    ''' Created 2016/05/11 杜相儒 
    ''' </history>
    ''' '=================================================
    Private Sub btn流转票一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn流转票一览.Click
        Try

            Dim frm As New frm流转票一览            frm.btnF3选择.Visible = False
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#End Region
#End Region
#Region "制造部"

#Region "生产计划管理"

    Private Sub btn生产计划_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产计划.Click
        Try

            Dim frm As New frm生产计划制定
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub UcButton20_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产计划查询.Click
        Try

            Dim frm As New frm生产计划一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "生产实绩"


    Private Sub btn生产实绩录入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产实绩录入.Click
        Try

            Dim frm As New frm生产实绩录入
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn生产实绩一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产实绩一览.Click
        Try

            Dim frm As New frm生产实绩一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "包装实绩"

    Private Sub btn包装实绩录入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn包装实绩录入.Click
        Try

            Dim frm As New frm包装实绩管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn包装实绩一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn包装实绩一览.Click
        Try

            Dim frm As New frm包装实绩一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "外协品入出库申请"

    Private Sub btn半成品入库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn半成品入库申请.Click
        Try

            Dim frm As New frm半成品入库申请

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn外协品入库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品入库申请.Click
        Try

            Dim frm As New frm外协品入库申请

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn外协品出库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn外协品出库申请.Click
        Try

            Dim frm As New frm外协品出库申请

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn半成品出库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn半成品出库申请.Click
        Try

            Dim frm As New frm半成品出库申请

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region
#Region "生产自检录入"


    Private Sub btn生产自检录入_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产自检录入.Click
        Try

            Dim frm As New frm生产自检录入

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#Region "生产自检录入"

 
    Private Sub btn生产自检一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn生产自检一览.Click
        Try

            Dim frm As New frm生产自检一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#Region "原材料出库申请"


    Private Sub btn原材料出库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料出库申请.Click
        Try

            Dim frm As New frm原材料出库申请
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn原材料出库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料出库申请一览.Click
        Try

            Dim frm As New frm原材料出库申请一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn原材料入库申请_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料入库申请.Click
        Try

            Dim frm As New frm原材料入库申请
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn原材料入库申请一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料入库申请一览.Click
        Try

            Dim frm As New frm原材料入库申请一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn原材料入库质检一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料入库质检一览.Click
        Try

            Dim frm As New frm原材料入库质检一览
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "报废品管理"


    Private Sub btn报废品管理_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn报废品管理.Click
        Try

            Dim frm As New frm报废品管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn报废品一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn报废品一览.Click
        Try

            Dim frm As New frm报废品一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region

#Region "质检管理"

    Private Sub btn质检管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn质检管理.Click
        Try

            Dim frm As New frm生产检查管理

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn质检履历一览_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn质检履历一览.Click
        Try

            Dim frm As New frm生产检查一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn原材料入库质检_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn原材料入库质检.Click
        Try

            Dim frm As New frm原材料入库质检


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn半成品入库质检_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn半成品入库质检.Click
        Try

            Dim frm As New frm半成品入库质检


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btn外协品入库质检_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn成品入库质检.Click
        Try

            Dim frm As New frm成品入库质检


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#End Region
#End Region
#End Region

#Region "函数"

#Region "OpenForm"
    Private Sub OpenForm(ByVal form As Form)

        Dim frm As Form
        Dim bHas As Boolean

        bHas = False

        For Each frm In My.Application.OpenForms

            If frm.Text = form.Text Then

                frm.Activate()
                bHas = True

                Exit For

            End If

        Next

        If bHas Then
            form.Dispose()
            form = Nothing
        Else
            form.Show()
        End If

    End Sub

#End Region

#Region "DataSearch"
    Public Sub DataSearch()
        Dim objBll As New BLL主画面

        Dim objM人员T As M人员T

        Try

            'IF 登陆 
            If Me.btn登陆.Text.ToString.Contains(CSTRLOGOFF) Then
                objM人员T = New M人员T

                objM人员T.人员编号 = Me.txt人员ID.Text.Trim

                mdtSearch.Clear()

                '查询の検索処理

                mdtSearch = objBll.GetGridData(objM人员T)

                If mdtSearch Is Nothing OrElse mdtSearch.Rows.Count = 0 Then

                    '結果０件ＭＳＧ出力

                    'メッセージCD：12
                    Me.Cursor = Cursors.Default

                    ''查询Gridの初期化
                    'Me.grdList.Clear()
                    'Utility.SetGridName(mdtSearch, Me.grdList)

                    ''GRIDを清空処理

                    'Me.ClearGrid()

                Else

                    '検索データを表示する
                    'Utility.SetGridName(mdtSearch, Me.grdList)

                    'Me.grdList.Focus()
                    'Me.grdList.ActiveRow = Me.grdList.Rows(0)
                End If
            Else

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ExHelper.ProcessEx(ex)
        End Try
    End Sub
#End Region

#Region "SetPermission"

    Private Sub SetPermission()
        Try
            'Dim intLoopi As Integer
            'Dim intLoopj As Integer

            'For intLoopi = 0 To Me.Controls.Count - 1
            '    If Me.Controls(intLoopi).GetType() Is GetType(UCGroupBox) Then
            '        If String.IsNullOrEmpty(Me.Controls(intLoopi).Tag) Then
            '            Continue For
            '        End If
            '        Me.Controls(intLoopi).Enabled = Utility.PFn_GetAuth(Me.Controls(intLoopi).Tag)

            '        For intLoopj = 0 To Me.Controls(intLoopi).Controls.Count - 1
            '            If Me.Controls(intLoopi).Controls(intLoopj).GetType() Is GetType(UCButton) Then
            '                Me.Controls(intLoopi).Controls(intLoopj).Enabled = Utility.PFn_GetAuth(Me.Controls(intLoopi).Controls(intLoopj).Tag)
            '            End If

            '        Next

            '    End If
            'Next

            '基础信息()
            Me.gb基础数据.Enabled = Utility.PFn_GetAuth(Me.gb基础数据.Tag)
            Me.btn部门管理.Enabled = Utility.PFn_GetAuth(Me.btn部门管理.Tag)
            Me.btn部门一览.Enabled = Utility.PFn_GetAuth(Me.btn部门一览.Tag)
            Me.btn生产设备管理.Enabled = Utility.PFn_GetAuth(Me.btn生产设备管理.Tag)
            Me.btn生产设备一览.Enabled = Utility.PFn_GetAuth(Me.btn生产设备一览.Tag)
            Me.btn原材料信息管理.Enabled = Utility.PFn_GetAuth(Me.btn原材料信息管理.Tag)
            Me.btn原材料信息一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料信息一览.Tag)
            Me.btn人员管理.Enabled = Utility.PFn_GetAuth(Me.btn人员管理.Tag)
            Me.btn人员一览.Enabled = Utility.PFn_GetAuth(Me.btn人员一览.Tag)
            Me.btn终端设备管理.Enabled = Utility.PFn_GetAuth(Me.btn终端设备管理.Tag)
            Me.btn终端设备一览.Enabled = Utility.PFn_GetAuth(Me.btn终端设备一览.Tag)
            Me.btn外协对象管理.Enabled = Utility.PFn_GetAuth(Me.btn外协对象管理.Tag)
            Me.btn外协对象一览.Enabled = Utility.PFn_GetAuth(Me.btn外协对象一览.Tag)
            Me.btn客户管理.Enabled = Utility.PFn_GetAuth(Me.btn客户管理.Tag)
            Me.btn客户一览.Enabled = Utility.PFn_GetAuth(Me.btn客户一览.Tag)
            Me.btn模具管理.Enabled = Utility.PFn_GetAuth(Me.btn模具管理.Tag)
            Me.btn模具一览.Enabled = Utility.PFn_GetAuth(Me.btn模具一览.Tag)
            Me.btn货位管理.Enabled = Utility.PFn_GetAuth(Me.btn货位管理.Tag)
            Me.btn货位一览.Enabled = Utility.PFn_GetAuth(Me.btn货位一览.Tag)
            Me.btn供应商管理.Enabled = Utility.PFn_GetAuth(Me.btn供应商管理.Tag)
            Me.btn供应商一览.Enabled = Utility.PFn_GetAuth(Me.btn供应商一览.Tag)
            Me.btn包装管理.Enabled = Utility.PFn_GetAuth(Me.btn包装管理.Tag)
            Me.btn包装一览.Enabled = Utility.PFn_GetAuth(Me.btn包装一览.Tag)
            Me.btn数据备份.Enabled = Utility.PFn_GetAuth(Me.btn数据备份.Tag)

            '业务部
            Me.gb业务部.Enabled = Utility.PFn_GetAuth(Me.gb业务部.Tag)
            Me.btn订单录入.Enabled = Utility.PFn_GetAuth(Me.btn订单录入.Tag)
            Me.btn订单一览.Enabled = Utility.PFn_GetAuth(Me.btn订单一览.Tag)
            Me.btn订单进度查询.Enabled = Utility.PFn_GetAuth(Me.btn订单进度查询.Tag)
            Me.btn库存一览.Enabled = Utility.PFn_GetAuth(Me.btn库存一览.Tag)
            Me.btn入出库记录一览.Enabled = Utility.PFn_GetAuth(Me.btn入出库记录一览.Tag)
            Me.btn盘点查询.Enabled = Utility.PFn_GetAuth(Me.btn盘点查询.Tag)
            Me.btn出荷指示发行.Enabled = Utility.PFn_GetAuth(Me.btn出荷指示发行.Tag)
            Me.btn出荷指示一览.Enabled = Utility.PFn_GetAuth(Me.btn出荷指示一览.Tag)
            Me.btn出荷一览.Enabled = Utility.PFn_GetAuth(Me.btn出荷一览.Tag)
            Me.btn返品查询.Enabled = Utility.PFn_GetAuth(Me.btn返品查询.Tag)
            Me.btn原材料标签打印.Enabled = Utility.PFn_GetAuth(Me.btn原材料标签打印.Tag)
            Me.btn半成品标签打印.Enabled = Utility.PFn_GetAuth(Me.btn半成品标签打印.Tag)
            Me.btn外协品标签打印.Enabled = Utility.PFn_GetAuth(Me.btn外协品标签打印.Tag)
            Me.btn成品标签打印.Enabled = Utility.PFn_GetAuth(Me.btn成品标签打印.Tag)
            Me.btn原材料采购管理.Enabled = Utility.PFn_GetAuth(Me.btn原材料采购管理.Tag)
            Me.btn原材料采购一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料采购一览.Tag)
            Me.btn原材料入库申请.Enabled = Utility.PFn_GetAuth(Me.btn原材料入库申请.Tag)
            Me.btn原材料入库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料入库申请一览.Tag)
            Me.btn原材料盘点查询.Enabled = Utility.PFn_GetAuth(Me.btn原材料盘点查询.Tag)
            Me.btn原材料库存一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料库存一览.Tag)
            Me.btn原材料入出库一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料入出库一览.Tag)
            Me.btn外协加工管理.Enabled = Utility.PFn_GetAuth(Me.btn外协加工管理.Tag)
            Me.btn外协加工一览.Enabled = Utility.PFn_GetAuth(Me.btn外协加工一览.Tag)
            Me.btn外协品出库申请.Enabled = Utility.PFn_GetAuth(Me.btn外协品出库申请.Tag)
            Me.btn外协品出库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn外协品出库申请一览.Tag)
            Me.btn外协品入库申请.Enabled = Utility.PFn_GetAuth(Me.btn外协品入库申请.Tag)
            Me.btn外协品入库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn外协品入库申请一览.Tag)
            Me.btn外协品盘点查询.Enabled = Utility.PFn_GetAuth(Me.btn外协品盘点查询.Tag)
            Me.btn废料回收管理.Enabled = Utility.PFn_GetAuth(Me.btn废料回收管理.Tag)
            Me.btn废料回收一览.Enabled = Utility.PFn_GetAuth(Me.btn废料回收一览.Tag)
            Me.btn废料入出库一览.Enabled = Utility.PFn_GetAuth(Me.btn废料入出库一览.Tag)

            '技术部
            Me.gb技术部.Enabled = Utility.PFn_GetAuth(Me.gb技术部.Tag)
            Me.btn图纸管理.Enabled = Utility.PFn_GetAuth(Me.btn图纸管理.Tag)
            Me.btn图纸一览.Enabled = Utility.PFn_GetAuth(Me.btn图纸一览.Tag)
            Me.btn工艺卡管理.Enabled = Utility.PFn_GetAuth(Me.btn工艺卡管理.Tag)
            Me.btn工艺卡一览.Enabled = Utility.PFn_GetAuth(Me.btn工艺卡一览.Tag)
            Me.btn流转票管理.Enabled = Utility.PFn_GetAuth(Me.btn流转票管理.Tag)
            Me.btn流转票一览.Enabled = Utility.PFn_GetAuth(Me.btn流转票一览.Tag)

            '质检部
            Me.gb质检部.Enabled = Utility.PFn_GetAuth(Me.gb质检部.Tag)
            Me.btn质检管理.Enabled = Utility.PFn_GetAuth(Me.btn质检管理.Tag)
            Me.btn质检履历一览.Enabled = Utility.PFn_GetAuth(Me.btn质检履历一览.Tag)
            Me.btn原材料入库质检.Enabled = Utility.PFn_GetAuth(Me.btn原材料入库质检.Tag)
            Me.btn原材料入库质检一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料入库质检一览.Tag)
            Me.btn半成品入库质检.Enabled = Utility.PFn_GetAuth(Me.btn半成品入库质检.Tag)
            Me.btn半成品入库质检一览.Enabled = Utility.PFn_GetAuth(Me.btn半成品入库质检一览.Tag)
            Me.btn成品入库质检.Enabled = Utility.PFn_GetAuth(Me.btn成品入库质检.Tag)
            Me.btn成品入库质检一览.Enabled = Utility.PFn_GetAuth(Me.btn成品入库质检一览.Tag)

            '制造部
            Me.gb制造部.Enabled = Utility.PFn_GetAuth(Me.gb制造部.Tag)
            Me.btn生产计划.Enabled = Utility.PFn_GetAuth(Me.btn生产计划.Tag)
            Me.btn生产计划查询.Enabled = Utility.PFn_GetAuth(Me.btn生产计划查询.Tag)
            Me.btn生产实绩录入.Enabled = Utility.PFn_GetAuth(Me.btn生产实绩录入.Tag)
            Me.btn生产实绩一览.Enabled = Utility.PFn_GetAuth(Me.btn生产实绩一览.Tag)
            Me.btn生产自检录入.Enabled = Utility.PFn_GetAuth(Me.btn生产自检录入.Tag)
            Me.btn生产自检一览.Enabled = Utility.PFn_GetAuth(Me.btn生产自检一览.Tag)
            Me.btn原材料出库申请.Enabled = Utility.PFn_GetAuth(Me.btn原材料出库申请.Tag)
            Me.btn原材料出库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn原材料出库申请一览.Tag)
            Me.btn半成品入库申请.Enabled = Utility.PFn_GetAuth(Me.btn半成品入库申请.Tag)
            Me.btn半成品入库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn半成品入库申请一览.Tag)
            Me.btn半成品出库申请.Enabled = Utility.PFn_GetAuth(Me.btn半成品出库申请.Tag)
            Me.btn半成品出库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn半成品出库申请一览.Tag)
            Me.btn外协品入出库一览.Enabled = Utility.PFn_GetAuth(Me.btn外协品入出库一览.Tag)
            Me.btn外协品库存一览.Enabled = Utility.PFn_GetAuth(Me.btn外协品库存一览.Tag)
            Me.btn成品入库申请.Enabled = Utility.PFn_GetAuth(Me.btn成品入库申请.Tag)
            Me.btn成品入库申请一览.Enabled = Utility.PFn_GetAuth(Me.btn成品入库申请一览.Tag)
            Me.btn包装实绩录入.Enabled = Utility.PFn_GetAuth(Me.btn包装实绩录入.Tag)
            Me.btn包装实绩一览.Enabled = Utility.PFn_GetAuth(Me.btn包装实绩一览.Tag)
            Me.btn报废品管理.Enabled = Utility.PFn_GetAuth(Me.btn报废品管理.Tag)
            Me.btn报废品一览.Enabled = Utility.PFn_GetAuth(Me.btn报废品一览.Tag)

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

    Private Sub btn外协对象管理_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn外协对象管理.Click

        Try

            Dim frm As New frm外协对象管理


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn外协对象一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn外协对象一览.Click
        Try
            Dim frm As New frm外协对象一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn半成品入库质检一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn半成品入库质检一览.Click
        Try

            Dim frm As New frm半成品入库质检一览


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txt成品入库申请一览_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn成品入库质检一览.Click

        Try

            Dim frm As New frm成品入库质检一览


            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub gb制造部_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gb制造部.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn出荷指示一览.Click
        Try
            Dim frm As New frm出荷指示一览

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btn半成品标签打印_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn半成品标签打印.Click
        Try
            Dim frm As New frm半成品标签打印

            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class