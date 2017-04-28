Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Text
Imports System.Data
Imports System.Drawing
Imports UserControl
Imports Infragistics.Win.UltraWinEditors

Public Class UCGridEdit

#Region "定数"

#End Region

#Region "変数"
    Private _ActiveFormFeatureCode As String = String.Empty     '当前機能コード

    Private _MasterFlg As Boolean = False                       'グリッドマスタ系/業務系区分

    Private _ItiranEditFlg As Boolean = False                   'グリッド一覧/編集区分
    Private _InsertValue As String = String.Empty               '入力前0埋め
    Private _InsertColumn As String = String.Empty
    Private _InsertColumn1 As String = String.Empty
    Private _InsertColumn2 As String = String.Empty
    Private _FirstFocusColumnIndex As Integer = -1              '選択列番号

    Private mblnEnteringFlg As Boolean = False                  '進入フラグ

    Private mblnFocus As Boolean = False
    Private mblnEnterEventFLG As Boolean = True
    Private _MinRowHeight As Integer = 20                               '行高設定
    Private _MinHeaderHeight As Integer = 24                            '列頭高設定

    Private _IsItiranCheckBoxFlag As Boolean = False                    '一覧CheckBox
    Private _AllowColMoving As AllowColMoving = UltraWinGrid.AllowColMoving.NotAllowed
    Private _AllowCellSizing As RowLayoutSizing = RowLayoutSizing.Horizontal
    Private mstrBeforeEdit As String                                    '変更前値

    Private _RowAppBackColor As Drawing.Color = Color.White             '行の背景色

    Private _RowAltAppBackColor As Drawing.Color = Color.White          '行の背景色

    Private _BackColorFlg As Boolean = True

    'セルのメッセージ専用
    Private mblnExitEditShowFlg As Boolean = False              'メッセージ表示フラグ
    Private mstrCellUpdateMsgID As ArrayList = Nothing          'メッセージ番号

    Private mstrCellUpdateMsgItem1 As ArrayList = Nothing       'メッセージ引数1
    Private mstrCellUpdateMsgItem2 As ArrayList = Nothing       'メッセージ引数2
    Private mstrCellUpdateMsgItem3 As ArrayList = Nothing       'メッセージ引数3
    Private mblnExitFocus As Boolean = False                    'プッカスフラグ

    Private blnF4Flag As Boolean = False            'キーフラグ

    Private mcolBackColor As System.Drawing.Color
    Private rcFlg As String = String.Empty     'メッセージ引数3

#End Region

#Region "Tab"
    'Private intTabKey As Integer

    'ReadOnly Property GeTabKey() As Integer
    '    Get
    '        Return intTabKey
    '    End Get
    'End Property

    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    Const WM_KEYDOWN As Integer = &H100
    '    Const WM_SYSKEYDOWN As Integer = &H104
    '    Dim ee As New System.Windows.Forms.KeyEventArgs(keyData)
    '    If ((msg.Msg = WM_KEYDOWN) Or _
    '    (msg.Msg = WM_SYSKEYDOWN)) Then
    '        Select Case (keyData)

    '            Case (System.Windows.Forms.Keys.Tab)
    '                intTabKey = 1
    '            Case (System.Windows.Forms.Keys.Enter)
    '                intTabKey = 5
    '            Case (System.Windows.Forms.Keys.Shift + System.Windows.Forms.Keys.Tab)
    '                intTabKey = 3
    '            Case (System.Windows.Forms.Keys.Shift + System.Windows.Forms.Keys.Enter)
    '                intTabKey = 4
    '            Case System.Windows.Forms.Keys.Control
    '                intTabKey = 2
    '            Case Else
    '                intTabKey = 0

    '        End Select
    '    End If

    '    Return MyBase.ProcessCmdKey(msg, keyData)
    'End Function
#Region "Tab"
    Private intTabKey As Integer = 0
    Private mIntEnterKey As Integer = 0

    ReadOnly Property GeTabKey() As Integer
        Get
            Return intTabKey
        End Get
    End Property

    ReadOnly Property intEnterKey() As Integer
        Get
            Return mIntEnterKey
        End Get
    End Property

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        Dim ee As New System.Windows.Forms.KeyEventArgs(keyData)
        If ((msg.Msg = WM_KEYDOWN) Or _
        (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)

                Case (System.Windows.Forms.Keys.Tab)
                    intTabKey = 1
                Case (System.Windows.Forms.Keys.Enter)
                    mIntEnterKey = 1
                    intTabKey = 2
                Case System.Windows.Forms.Keys.Tab + System.Windows.Forms.Keys.Shift
                    intTabKey = 3
                Case System.Windows.Forms.Keys.Tab + System.Windows.Forms.Keys.Enter
                    intTabKey = 4
                Case Else
                    intTabKey = 0

            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

#End Region

#End Region

#Region "プロパティ"
    ''' <summary>
    ''' 当前フォームの機能コード
    ''' </summary>
    ''' <value>機能コード</value>
    ''' <returns>機能コード</returns>
    ''' <remarks>当前フォームの機能コード</remarks>
    Public Property ActiveFormFeatureCode() As String
        Get
            ActiveFormFeatureCode = _ActiveFormFeatureCode
        End Get
        Set(ByVal value As String)
            _ActiveFormFeatureCode = value
        End Set
    End Property

    <System.ComponentModel.Description("マスタ系(True);業務系(False)")> Public Property MasterFlg() As Boolean
        Get
            MasterFlg = _MasterFlg
        End Get
        Set(ByVal value As Boolean)
            _MasterFlg = value
        End Set
    End Property

    ''' <summary>
    ''' グリッド一覧/編集区分
    ''' </summary>
    ''' <value>区分</value>
    ''' <returns>一覧(True);編集(False)</returns>
    ''' <remarks>グリッド一覧/編集区分</remarks>
    <System.ComponentModel.Description("一覧(True);編集(False)")> Public Property ItiranEditFlg() As Boolean
        Get
            ItiranEditFlg = _ItiranEditFlg
        End Get
        Set(ByVal value As Boolean)
            _ItiranEditFlg = value
        End Set
    End Property

    Public Property FirstFocusColumnIndex() As Integer
        Get
            FirstFocusColumnIndex = _FirstFocusColumnIndex
        End Get
        Set(ByVal value As Integer)
            _FirstFocusColumnIndex = value
        End Set
    End Property

    ''' <summary>
    ''' 行高設定
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>行高設定</remarks>
    Public Property MinRowHeight() As Integer
        Get
            MinRowHeight = _MinRowHeight
        End Get
        Set(ByVal value As Integer)
            _MinRowHeight = value
        End Set
    End Property

    Public Property MinHeaderHeight() As Integer
        Get
            MinHeaderHeight = _MinHeaderHeight
        End Get
        Set(ByVal value As Integer)
            _MinHeaderHeight = value
        End Set
    End Property

    Public Property AllowCellSizing() As RowLayoutSizing
        Get
            AllowCellSizing = _AllowCellSizing
        End Get
        Set(ByVal value As RowLayoutSizing)
            _AllowCellSizing = value
        End Set
    End Property

    Public Property AllowColMoving() As AllowColMoving
        Get
            AllowColMoving = _AllowColMoving
        End Get
        Set(ByVal value As AllowColMoving)
            _AllowColMoving = value
        End Set
    End Property

    ''' <summary>
    ''' 入力前0埋め
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property InsertValue() As String
        Get
            InsertValue = _InsertValue
        End Get
        Set(ByVal value As String)
            _InsertValue = value
        End Set
    End Property

    Public Property InsertColumn() As String
        Get
            InsertColumn = _InsertColumn
        End Get
        Set(ByVal value As String)
            _InsertColumn = value
        End Set
    End Property

    Public Property InsertColumn1() As String
        Get
            InsertColumn1 = _InsertColumn1
        End Get
        Set(ByVal value As String)
            _InsertColumn1 = value
        End Set
    End Property

    Public Property InsertColumn2() As String
        Get
            InsertColumn2 = _InsertColumn2
        End Get
        Set(ByVal value As String)
            _InsertColumn2 = value
        End Set
    End Property

    ''' <summary>
    ''' 一覧CheckBox区分
    ''' </summary>
    ''' <value>区分</value>
    ''' <returns>存在(True);存在しません(False)</returns>
    ''' <remarks>グリッドマスタ系/業務系区分</remarks>
    Public Property IsItiranCheckBoxFlag() As Boolean
        Get
            IsItiranCheckBoxFlag = _IsItiranCheckBoxFlag
        End Get
        Set(ByVal value As Boolean)
            _IsItiranCheckBoxFlag = value
        End Set
    End Property

    ''' <summary>
    ''' 行の背景色は設けます
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowAppColor() As Drawing.Color
        Get
            RowAppColor = _RowAppBackColor
        End Get
        Set(ByVal value As Drawing.Color)
            _RowAppBackColor = value
        End Set
    End Property

    ''' <summary>
    ''' 行の背景色は設けます
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property RowAltAppColor() As Drawing.Color
        Get
            RowAltAppColor = _RowAltAppBackColor
        End Get
        Set(ByVal value As Drawing.Color)
            _RowAltAppBackColor = value
        End Set
    End Property

    Public Property BackColorFlg() As Boolean
        Get
            BackColorFlg = _BackColorFlg
        End Get
        Set(ByVal value As Boolean)
            _BackColorFlg = value
        End Set
    End Property

#End Region

#Region "イベント"

    'Private Sub UCGridEdit_AfterCellActivate(sender As Object, e As EventArgs) Handles Me.AfterCellActivate
    '    If Not Me.ActiveCell Is Nothing Then
    '        Select Case Me.ActiveCell.Column.Style
    '            Case ColumnStyle.Button ', ColumnStyle.CheckBox
    '            Case Else
    '                If Me.ActiveCell.Activation = Activation.AllowEdit AndAlso Not Me.ActiveCell.IsInEditMode Then
    '                    Me.PerformAction(UltraGridAction.EnterEditMode)
    '                End If
    '        End Select
    '    End If
    'End Sub

   
    Private Sub CtlGrid_BeforeEnterEditMode(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.BeforeEnterEditMode
        mstrBeforeEdit = Me.ActiveCell.Text

        'セルの背景色を処理

        If Not Me.ActiveCell Is Nothing Then
            Select Case Me.ActiveCell.Column.Style
                Case ColumnStyle.Button ', ColumnStyle.CheckBox
                Case Else
                    Select Case Me.ActiveCell.Style
                        Case ColumnStyle.Button ', ColumnStyle.CheckBox
                        Case Else
                            If Me.ActiveCell.Column.CellActivation = Activation.ActivateOnly Then
                                Exit Select
                            End If
                            If Me.ActiveCell.Activation = Activation.AllowEdit Then
                                mcolBackColor = Me.ActiveCell.Appearance.BackColor
                                Me.ActiveCell.Appearance.BackColor = MUCColor.CommonEnter  'Color.PapayaWhip
                            End If
                    End Select
            End Select
        End If

    End Sub

    ''' <summary>
    ''' セル進入事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>セル進入事件</remarks>
    Private Sub CtlGrid_AfterEnterEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AfterEnterEditMode
        'セルプッカスフラグをセット

        Me.mblnExitFocus = False
    End Sub

    Private Sub CtlGrid_AfterExitEditMode(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AfterExitEditMode
        Try

            'セルの背景色を処理

            If Not Me.ActiveCell Is Nothing Then
                Select Case Me.ActiveCell.Column.Style
                    Case ColumnStyle.Button ', ColumnStyle.CheckBox
                    Case Else
                        Select Case Me.ActiveCell.Style
                            Case ColumnStyle.Button ', ColumnStyle.CheckBox
                            Case Else
                                If Me.ActiveCell.Column.CellActivation = Activation.ActivateOnly Then
                                    Exit Select
                                End If
                                If Me.ActiveCell.Activation = Activation.AllowEdit Then
                                    'Me.ActiveCell.Appearance.BackColor = Color.White
                                    If mcolBackColor = MUCColor.CommonEnter Then
                                        Me.ActiveCell.Appearance.BackColor = Nothing
                                    Else
                                        If BackColorFlg Then
                                            If Me.ActiveCell.Appearance.BackColor <> Color.White Then
                                                Me.ActiveCell.Appearance.BackColor = mcolBackColor
                                            End If
                                        ElseIf Me.ActiveCell.Appearance.BackColor = MUCColor.CommonEnter Then
                                            Me.ActiveCell.Appearance.BackColor = Nothing
                                        End If
                                    End If
                                End If
                        End Select
                End Select
            End If

            'メッセージ表示フラグを判断する

            If mblnExitEditShowFlg Then
                Dim i As Integer
                For i = 0 To mstrCellUpdateMsgID.Count - 1
                    'メッセージ表示

                    'ComMessage.PFn_ShowMessageBox(Me.ActiveFormFeatureCode, _
                    '                              UCUtility.PFn_ToString(mstrCellUpdateMsgID(i)), _
                    '                              UCUtility.PFn_ToString(mstrCellUpdateMsgItem1(i)), _
                    '                              UCUtility.PFn_ToString(mstrCellUpdateMsgItem2(i)), _
                    '                              UCUtility.PFn_ToString(mstrCellUpdateMsgItem3(i)))
                Next

                If Not mstrCellUpdateMsgID Is Nothing Then
                    mstrCellUpdateMsgID.Clear()
                    mstrCellUpdateMsgID = Nothing
                End If

                If Not mstrCellUpdateMsgItem1 Is Nothing Then
                    mstrCellUpdateMsgItem1.Clear()
                    mstrCellUpdateMsgItem1 = Nothing
                End If

                If Not mstrCellUpdateMsgItem2 Is Nothing Then
                    mstrCellUpdateMsgItem2.Clear()
                    mstrCellUpdateMsgItem2 = Nothing
                End If

                If Not mstrCellUpdateMsgItem3 Is Nothing Then
                    mstrCellUpdateMsgItem3.Clear()
                    mstrCellUpdateMsgItem3 = Nothing
                End If
            End If

            'プッカス設置を判断する

            If Me.mblnExitFocus Then
                'プッカスをセットする
                Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))
            End If

            'メッセージ初期化
            mblnExitEditShowFlg = False

        Catch ex As Exception
            '異常処理
            'ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub

    ''' <summary>
    ''' ロットプッカス時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>ロットプッカス時</remarks>
    Private Sub CtlGrid_BeforeCellDeactivate(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.BeforeCellDeactivate
        'プッカス設置フラグを判断する
        If mblnExitFocus Then
            '操作終了
            e.Cancel = True

            'プッカスを再設置する
            Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))
        End If

        'プッカス設置フラグを初期化

        mblnExitFocus = False
    End Sub

    ''' <summary>
    ''' 新規行のプッカスをセットする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>新規行のプッカスをセットする</remarks>
    Private Sub CtlGrid_AfterRowInsert(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles Me.AfterRowInsert
        If e.Row.Index = 0 Then
            Me.EventManager.AllEventsEnabled = False
            'Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell)
            Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))
            Me.EventManager.AllEventsEnabled = True
        End If
    End Sub

    ''' <summary>
    ''' 進入処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>進入処理</remarks>
    Private Sub CtlGrid_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Dim i As Integer
        Dim j As Integer
        mblnEnteringFlg = True

        '一覧グリッドを判断する
        If Not Me.ItiranEditFlg Then
            '進入事件フラグを判断する
            If Not Me.mblnEnterEventFLG Then
                Me.mblnEnterEventFLG = True
                '進入事件フラグは「False」の場合、終了する

                Exit Sub
            End If

            '初期プッカスの存在を判断する
            If Me.FirstFocusColumnIndex < 0 Then
                '存在しない場合、終了する

                Exit Sub
            End If

            'プッカスを判断する

            If Windows.Forms.Control.MouseButtons = Windows.Forms.MouseButtons.None Then
                '行数を判断する

                If Me.Rows.Count > 0 Then
                    '新規行を判断する
                    If Me.Rows(0).IsAddRow Then
                        '列をループする

                        For j = 0 To Me.Rows.TemplateAddRow.Cells.Count - 1
                            '正常列を判断する
                            If Me.Rows.TemplateAddRow.Cells(j).Column.CellActivation = Activation.AllowEdit AndAlso _
                                Me.Rows.TemplateAddRow.Cells(j).Column.TabStop <> False Then
                                '正常セルを判断する

                                If Me.Rows.TemplateAddRow.Cells(j).Activation = Activation.AllowEdit AndAlso _
                                    Me.Rows.TemplateAddRow.Cells(j).TabStop <> DefaultableBoolean.False Then

                                    'Me.EventManager.AllEventsEnabled = False
                                    Me.Rows.TemplateAddRow.Cells(j).Activate()
                                    Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                    'Me.EventManager.AllEventsEnabled = True

                                    Exit Sub
                                End If
                            End If
                        Next

                        'Me.Rows.TemplateAddRow.Cells(Me.FirstFocusColumnIndex).Activate()
                        'Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                    Else
                        '有効行をループする

                        For i = 0 To Me.Rows.Count - 1
                            '照会行を判断する
                            If Me.Rows(i).Tag Is Nothing OrElse Me.Rows(i).Tag.Equals(String.Empty) Then
                                '列をループする

                                For j = 0 To Me.Rows(i).Cells.Count - 1
                                    '正常列を判断する
                                    If Me.Rows(i).Cells(j).Column.CellActivation = Activation.AllowEdit AndAlso _
                                        Me.Rows(i).Cells(j).Column.TabStop <> False Then
                                        '正常セルを判断する

                                        If Me.Rows(i).Cells(j).Activation = Activation.AllowEdit AndAlso _
                                            Me.Rows(i).Cells(j).TabStop <> DefaultableBoolean.False Then

                                            Me.EventManager.AllEventsEnabled = False
                                            Me.Rows(i).Cells(j).Activate()
                                            Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                            Me.EventManager.AllEventsEnabled = True

                                            Exit Sub
                                        End If
                                    End If
                                Next

                            End If
                        Next

                        '有効行がない時、新規行を「有無」に判断する
                        If Me.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom OrElse _
                           Me.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.TemplateOnBottom Then
                            '新規行のプッカスをセットする
                            '列をループする

                            For j = 0 To Me.Rows.TemplateAddRow.Cells.Count - 1
                                '正常列を判断する
                                If Me.Rows.TemplateAddRow.Cells(j).Column.CellActivation = Activation.AllowEdit AndAlso _
                                    Me.Rows.TemplateAddRow.Cells(j).Column.TabStop <> False Then
                                    '正常セルを判断する

                                    If Me.Rows.TemplateAddRow.Cells(j).Activation = Activation.AllowEdit AndAlso _
                                        Me.Rows.TemplateAddRow.Cells(j).TabStop <> DefaultableBoolean.False Then

                                        'Me.EventManager.AllEventsEnabled = False
                                        Me.Rows.TemplateAddRow.Cells(j).Activate()
                                        Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                        'Me.EventManager.AllEventsEnabled = True

                                        Exit Sub
                                    End If
                                End If
                            Next
                        Else
                            Me.TabStop = False
                            '次項目を移動する

                        End If
                    End If
                Else
                    '有効行がない時、新規行を「有無」に判断する
                    If Me.DisplayLayout.Override.AllowAddNew = AllowAddNew.TemplateOnBottom Then
                        '新規行のプッカスをセットする
                        '列をループする

                        For j = 0 To Me.Rows.TemplateAddRow.Cells.Count - 1
                            '正常列を判断する
                            If Me.Rows.TemplateAddRow.Cells(j).Column.CellActivation = Activation.AllowEdit AndAlso _
                                Me.Rows.TemplateAddRow.Cells(j).Column.TabStop <> False Then
                                '正常セルを判断する

                                If Me.Rows.TemplateAddRow.Cells(j).Activation = Activation.AllowEdit AndAlso _
                                    Me.Rows.TemplateAddRow.Cells(j).TabStop <> DefaultableBoolean.False Then

                                    'Me.EventManager.AllEventsEnabled = False
                                    Me.Rows.TemplateAddRow.Cells(j).Activate()
                                    Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
                                    'Me.EventManager.AllEventsEnabled = True

                                    Exit Sub
                                End If
                            End If
                        Next
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CtlGrid_BeforeCellActivate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CancelableCellEventArgs) Handles Me.BeforeCellActivate
        Me.mblnExitFocus = False

        '当前行の存在を判断する

        If Me.ActiveRow Is Nothing Then
            Exit Sub
        End If

        '新規行の存在を判断する

        If Me.DisplayLayout.Override.AllowAddNew = AllowAddNew.Default OrElse _
           Me.DisplayLayout.Override.AllowAddNew = AllowAddNew.No Then
            Exit Sub
        End If

        '---------------------------F2---------------------------
        ''当前行は新規行を判断する
        'If Not Me.ActiveRow.IsAddRow AndAlso Me.ActiveRow.Index = 0 Then
        '    '当前操作セルの判断する

        '    If Not e.Cell Is Nothing Then
        '        Me.EventManager.AllEventsEnabled = False
        '        Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))
        '        'Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ActivateCell)
        '        Me.EventManager.AllEventsEnabled = True
        '    End If
        'End If

    End Sub

    Private Sub CtlGrid_BeforeCellUpdate(ByVal sender As Object, _
                        ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) _
                        Handles Me.BeforeCellUpdate
        'Me.EventManager.AllEventsEnabled = False
        'If e.Cell.Row.IsAddRow AndAlso e.Cell.Row.Index = 0 Then
        '    Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf EnterEditModeOnFirstCellInGrid))
        'End If
        'Me.EventManager.AllEventsEnabled = True
    End Sub

  
    Private Sub CtlGrid_AfterCellUpdate(ByVal sender As Object, _
                                        ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) _
                                        Handles Me.AfterCellUpdate
        Dim intColumnIndex As Integer
        Dim intRowIndex As Integer
        Dim intBandIndex As Integer
        Dim isClearFlg As Boolean

        'nothingを判断する

        If UCUtility.PFn_IsNothingOrNull(e.Cell) Then
            Exit Sub
        End If

        '************************************************************************
        '2014/07/23  数　光

        'If e.Cell.Row.IsAddRow AndAlso e.Cell.Row.Index = 0 Then
        '    If Not e.Cell.Value Is Nothing AndAlso Not e.Cell.Value.Equals(String.Empty) Then
        '        'If UCUtility.PFn_ToString(e.Cell.Value).Length = 1 Then
        '        Me.EventManager.AllEventsEnabled = False
        '        Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf EnterEditModeOnFirstCellInGrid))
        '        Me.EventManager.AllEventsEnabled = True
        '        'Exit Sub
        '        'End If
        '    End If
        'End If
        '************************************************************************

        Try
            'Me.EventManager.AllEventsEnabled = False
            'If e.Cell.Row.IsAddRow AndAlso e.Cell.Row.Index = 0 Then
            '    Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf EnterEditModeOnFirstCellInGrid))
            'End If
            'Me.EventManager.AllEventsEnabled = True

            '当前選択セルの行、列、バンドを取得する

            intColumnIndex = e.Cell.Column.Index
            intRowIndex = e.Cell.Row.Index
            intBandIndex = e.Cell.Band.Index

            '様式は「一般文字列」を判断する
            If e.Cell.Column.Style = ColumnStyle.Default OrElse _
                e.Cell.Column.Style = ColumnStyle.EditButton Then
                '両辺の空白を削除する
                Me.EventManager.AllEventsEnabled = False
                Try
                    e.Cell.Value = UCUtility.PFn_Trim(e.Cell.Value)
                Catch ex As Exception
                    e.Cell.Value = DBNull.Value
                End Try

                Me.EventManager.AllEventsEnabled = True

                '入力モードを判断する
                If e.Cell.Column.ImeMode = Windows.Forms.ImeMode.Disable Then
                    '空を判断する
                    If Not e.Cell.Equals(String.Empty) Then
                        '半角文字をチェックする

                        If Not UCUtility.PFn_CheckHalfEm(UCUtility.PFn_ToString(e.Cell.Value)) Then
                            Me.EventManager.AllEventsEnabled = False
                            '該当セルの値をクリアする

                            e.Cell.Value = String.Empty
                            Me.EventManager.AllEventsEnabled = True
                        End If
                    End If
                End If

                'コンボボックスを判断する
                If Not e.Cell.Column.Tag Is Nothing AndAlso _
                   e.Cell.Column.Tag.Equals(ComVariable.CON_ISCOMBOBOXCODE_FLG) Then
                    Dim objValueList As Infragistics.Win.ValueList

                    'セルのTagは「ComboBoxCode」と次のセルの様式を判断する
                    If Me.DisplayLayout.Bands(intBandIndex).Columns(intColumnIndex + 1).Style = _
                        ColumnStyle.DropDownList Then

                        '空を判断する
                        If e.Cell.Value.Equals(String.Empty) Then
                            Me.EventManager.AllEventsEnabled = False
                            'コードとリストの内容をクリアする
                            e.Cell.Row.Cells(intColumnIndex + 1).Value = String.Empty
                            Me.EventManager.AllEventsEnabled = True
                            Exit Sub
                        End If

                        'クリアフラグを初期化
                        isClearFlg = True

                        'リストを取得する
                        'objValueList = CType(Me.DisplayLayout.Bands(intBandIndex).Columns( _
                        '        intColumnIndex + 1).ValueList, ValueList)
                        'リストを取得する
                        If Not Me.rcFlg.Equals(String.Empty) Then

                            If Me.ActiveRow.Cells(intColumnIndex + 1).ValueList Is Nothing Then
                                objValueList = CType(Me.DisplayLayout.Bands(intBandIndex).Columns( _
                                intColumnIndex + 1).ValueList, ValueList)
                            Else
                                objValueList = CType(Me.ActiveRow.Cells(intColumnIndex + 1).ValueList, ValueList)
                            End If

                        Else
                            objValueList = CType(Me.DisplayLayout.Bands(intBandIndex).Columns( _
                                intColumnIndex + 1).ValueList, ValueList)
                        End If

                        Me.EventManager.AllEventsEnabled = False
                        'リストをループする

                        If objValueList Is Nothing Then
                            isClearFlg = True
                        Else
                            For i As Integer = 0 To objValueList.ValueListItems.Count - 1
                                '画面値とリスト値を判断する
                                If UCUtility.PFn_ToString(e.Cell.Value).Equals(UCUtility.PFn_ToString( _
                                                              objValueList.ValueListItems(i).DataValue)) Then
                                    'リストをセットする

                                    e.Cell.Row.Cells(intColumnIndex + 1).Value = objValueList.ValueListItems(i).DataValue

                                    isClearFlg = False
                                    Exit For
                                End If
                            Next
                        End If

                        If isClearFlg Then
                            'コードとリストの内容をクリアする
                            e.Cell.Row.Cells(intColumnIndex + 1).Value = System.DBNull.Value
                            'e.Cell.Value = DBNull.Value
                        End If

                        Me.EventManager.AllEventsEnabled = True
                    End If
                End If

                Exit Sub
            ElseIf e.Cell.Column.Style = ColumnStyle.Date Then
                If Not Me.ActiveCell Is Nothing Then
                    Dim strInputDate As String
                    strInputDate = UCUtility.PFn_ToDateTime(e.Cell.Value).Date.ToString("yyyy/MM/dd")

                    strInputDate = strInputDate.Replace("_", "")
                    Me.EventManager.AllEventsEnabled = False
                    If strInputDate.Length = 10 AndAlso IsDate(strInputDate) Then
                        If CDate(strInputDate) > CDate("2100/12/31") Then
                            e.Cell.Value = DBNull.Value
                        End If
                        If CDate(strInputDate) < CDate("1900/01/01") Then
                            e.Cell.Value = DBNull.Value
                        End If
                    ElseIf strInputDate.Length = 7 AndAlso IsDate(strInputDate + "/01") Then
                        If CDate(strInputDate + "/01") > CDate("2100/12/31") Then
                            e.Cell.Value = DBNull.Value
                        End If
                        If CDate(strInputDate + "/01") < CDate("1900/01/01") Then
                            e.Cell.Value = DBNull.Value
                        End If
                    ElseIf strInputDate.Length = 8 AndAlso IsDate(strInputDate) Then
                        If CDate(strInputDate) > CDate("2100/12/31") Then
                            e.Cell.Value = DBNull.Value
                        End If
                        If CDate(strInputDate) < CDate("1900/01/01") Then
                            e.Cell.Value = DBNull.Value
                        End If
                    ElseIf strInputDate.Length = 9 AndAlso IsDate(strInputDate) Then
                        If CDate(strInputDate) > CDate("2100/12/31") Then
                            e.Cell.Value = DBNull.Value
                        End If
                        If CDate(strInputDate) < CDate("1900/01/01") Then
                            e.Cell.Value = DBNull.Value
                        End If
                    ElseIf (strInputDate.Length = 5 Or strInputDate.Length = 6) AndAlso IsDate(strInputDate) Then
                        If CDate(strInputDate) > CDate("2100/12/31") Then
                            e.Cell.Value = DBNull.Value
                        End If
                        If CDate(strInputDate) < CDate("1900/01/01") Then
                            e.Cell.Value = DBNull.Value
                        End If
                    Else
                        e.Cell.Value = DBNull.Value
                    End If
                    Me.EventManager.AllEventsEnabled = True
                End If
            End If
        Catch ex As Exception
            Me.EventManager.AllEventsEnabled = True

            '異常処理
            'ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub

    ''' <summary>
    ''' 初期の共通スタイルは設けます
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>初期の共通スタイルは設けます</remarks>
    ''' <history>
    ''' 	[WANGZHIFENG]	2010/01/24	Created
    ''' </history>
    Private Sub CtlGrid_InitializeLayout(ByVal sender As Object, _
                            ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) _
                            Handles Me.InitializeLayout
        ''マウスのスタイル
        'Me.Cursor = Windows.Forms.Cursors.Arrow        '初期Gridのプッカスが異常です

        'Me.TabStop = True

        Me.Font = ComVariable.CON_FONT

        '行数を判断する

        If Me.Rows.Count <= 0 Then
            '新規行の存在を判断する

            If Me.Rows.TemplateAddRow Is Nothing Then
                Me.TabStop = False
            End If
        End If

        With e.Layout
            '背の景色
            .Appearance.BackColor = ComVariable.Color_Gray
            .Appearance.BorderColor = ComVariable.Color_Control

            'スクロール・バー
            .ScrollBounds = ScrollBounds.ScrollToFill
            .ScrollStyle = ScrollStyle.Immediate
            .Scrollbars = Scrollbars.Automatic
            .ScrollBarLook.ScrollBarArrowStyle = UltraWinScrollBar.ScrollBarArrowStyle.OneAtEachEnd

            'グループは表示ありません
            .GroupByBox.Hidden = True

            'Tab順

            .TabNavigation = TabNavigation.NextControlOnLastCell

            'Grid頭の表示示ありません
            .CaptionVisible = DefaultableBoolean.False

            .BorderStyle = UIElementBorderStyle.Solid
        End With

        With e.Layout.Override
            .AllowAddNew = AllowAddNew.TemplateOnBottom

            If e.Layout.Bands.Count > 1 Then
                '「+」の表示状態を「無子データ不表示」にセットする

                .ExpansionIndicator = ShowExpansionIndicator.CheckOnDisplay
            Else
                .ExpansionIndicator = ShowExpansionIndicator.Default
            End If

            .TemplateAddRowAppearance.BackColor = Color.White 'System.Drawing.SystemColors.ControlLight
            .AddRowAppearance.BackColor = Color.White
            .CellAppearance.BorderColor = ComVariable.Color_Gray   'Color.Silver
            .RowAppearance.BorderColor = ComVariable.Color_Gray

            'セルを複製します
            '.AllowMultiCellOperations = AllowMultiCellOperation.CopyWithHeaders
            .AllowMultiCellOperations = AllowMultiCellOperation.None

            '行の背景色は設けます
            .RowAppearance.BackColor = _RowAppBackColor
            .RowAlternateAppearance.BackColor = _RowAltAppBackColor

            '表示のスタイル

            .BorderStyleHeader = UIElementBorderStyle.Raised
            .BorderStyleCell = UIElementBorderStyle.Default
            .BorderStyleRow = UIElementBorderStyle.Default
            .RowSizing = RowSizing.Fixed
            If ItiranEditFlg Then
                .SelectTypeRow = SelectType.Extended
            End If
            .DefaultRowHeight = -1
            .MinRowHeight = _MinRowHeight
            .CellPadding = 0
            .AllowColMoving = _AllowColMoving

            '列　ExternalSortMulti　ない
            .HeaderClickAction = HeaderClickAction.Default

            '行号は表示あります

            .RowSelectorHeaderStyle = RowSelectorHeaderStyle.SeparateElement
            .RowSelectorNumberStyle = RowSelectorNumberStyle.RowIndex

            .RowSelectors = DefaultableBoolean.True
            .RowSelectorWidth = 40

            'フォントは表示

            .RowSelectorAppearance.TextHAlign = HAlign.Center
            .HeaderAppearance.TextHAlign = HAlign.Center
            .HeaderAppearance.TextVAlign = VAlign.Middle

            '列幅設定
            .AllowColSizing = AllowColSizing.Free

            '列削除しない
            .AllowDelete = DefaultableBoolean.False

            '垂直表示
            .CellAppearance.TextVAlign = VAlign.Middle

            .CellClickAction = CellClickAction.EditAndSelectText

            If ItiranEditFlg Then
                .ActiveCellAppearance.BackColor = Nothing
                .ActiveCellAppearance.ForeColor = Nothing
                .ActiveRowAppearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
                .ActiveRowAppearance.ForeColor = System.Drawing.SystemColors.WindowText
            Else
                .ActiveCellAppearance.BackColor = Nothing
                .ActiveCellAppearance.ForeColor = Nothing
                .ActiveRowAppearance.BackColor = Nothing
                .ActiveRowAppearance.ForeColor = Nothing
            End If
        End With

        '数字の赤いの対象
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ConditionValueAppearance1 As Infragistics.Win.ConditionValueAppearance
        ConditionValueAppearance1 = New Infragistics.Win.ConditionValueAppearance( _
                New Infragistics.Win.ICondition() {CType(New Infragistics.Win.OperatorCondition( _
                                                   Infragistics.Win.ConditionOperator.Contains, "-", _
                                                   True, GetType(String)), Infragistics.Win.ICondition)}, _
                                                   New Infragistics.Win.Appearance() {Appearance1})

        '各バンドの列をセットする
        For intBand As Integer = 0 To e.Layout.Bands.Count - 1
            With e.Layout.Bands(intBand)
                '編集のスタイルは設定
                For i As Integer = 0 To .ColumnFilters.Count - 1

                    '行高設定
                    .ColumnFilters(i).Column.RowLayoutColumnInfo.PreferredCellSize = _
                                New System.Drawing.Size(.ColumnFilters(i).Column. _
                                                RowLayoutColumnInfo.PreferredCellSize.Width, _MinRowHeight)
                    '列頭高設定

                    .ColumnFilters(i).Column.RowLayoutColumnInfo.PreferredLabelSize = _
                                New System.Drawing.Size(.ColumnFilters(i).Column. _
                                                RowLayoutColumnInfo.PreferredLabelSize.Width, _MinHeaderHeight)
                    '列幅設定
                    .ColumnFilters(i).Column.RowLayoutColumnInfo.AllowCellSizing = AllowCellSizing

                    '多行文本の時、スクロールバーをセットする
                    If .ColumnFilters(i).Column.CellMultiLine = DefaultableBoolean.True Then
                        .ColumnFilters(i).Column.VertScrollBar = True
                    End If

                    If .ColumnFilters(i).Column.CellActivation = Activation.ActivateOnly Then

                        ''マスタ系(True);業務系(False)
                        'If MasterFlg Then
                        '    '.ColumnFilters(i).Column.CellAppearance.BackColor = ComVariable.Color_Control
                        '    .ColumnFilters(i).Column.CellAppearance.ForeColor = Color.Black
                        'Else
                        '    If IsItiranCheckBoxFlag = False Then
                        '        .ColumnFilters(i).Column.CellAppearance.BackColor = Nothing
                        '        .ColumnFilters(i).Column.CellAppearance.ForeColor = ComVariable.Color_Gray
                        '    Else
                        '        .ColumnFilters(i).Column.CellAppearance.BackColor = Nothing
                        '        .ColumnFilters(i).Column.CellAppearance.ForeColor = ComVariable.Color_Black
                        '    End If
                        'End If
                        .ColumnFilters(i).Column.TabStop = False
                    Else
                        '.ColumnFilters(i).Column.CellAppearance.BackColor = Nothing
                        '.ColumnFilters(i).Column.CellAppearance.ForeColor = Color.Black
                        .ColumnFilters(i).Column.TabStop = True
                    End If

                    .ColumnFilters(i).Column.CellAppearance.BackColor = Nothing
                    .ColumnFilters(i).Column.CellAppearance.ForeColor = Color.Black

                    If .ColumnFilters(i).Column.CellActivation = Activation.NoEdit Or _
                        .ColumnFilters(i).Column.CellActivation = Activation.ActivateOnly Then
                        .ColumnFilters(i).Column.TabStop = False
                        'e.Layout.TabNavigation = TabNavigation.NextControl
                    End If

                    If .ColumnFilters(i).Column.Hidden = True _
                            OrElse .ColumnFilters(i).Column.RowLayoutColumnInfo.LabelPosition _
                                                                    = LabelPosition.LabelOnly Then
                        .ColumnFilters(i).Column.TabStop = False
                    End If

                    'グリッドの様式を初期設置する
                    Select Case .ColumnFilters(i).Column.Style
                        Case ColumnStyle.Double, ColumnStyle.Integer        '数字
                            '入力方式をセットする
                            .ColumnFilters(i).Column.ImeMode = Windows.Forms.ImeMode.Disable

                            '赤い数字を設置する

                            Appearance1.ForeColor = System.Drawing.Color.Red
                            .ColumnFilters(i).Column.ValueBasedAppearance = ConditionValueAppearance1
                        Case ColumnStyle.Date, ColumnStyle.DateTime         '日付
                            '入力方式をセットする
                            .ColumnFilters(i).Column.ImeMode = Windows.Forms.ImeMode.Disable
                    End Select

                Next
            End With
        Next intBand
    End Sub

    ''' <summary>
    ''' マイナスの値を赤字で表示する(行)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>マイナスの値を赤字で表示する(行)</remarks>
    Private Sub CtlGrid_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles Me.InitializeRow
        Try
            Dim i As Integer
            For i = 0 To e.Row.Cells.Count - 1
                '文字色をセットする

                If e.Row.Cells(i).Column.Style = ColumnStyle.Double OrElse _
                   e.Row.Cells(i).Column.Style = ColumnStyle.Integer Then
                    If UCUtility.PFn_ToDouble(e.Row.Cells(i).Value) < 0 Then
                        e.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Red
                    Else
                        Call Sb_SetCellColor(i, e)
                    End If
                Else
                    Call Sb_SetCellColor(i, e)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' セルの色をセットする
    ''' </summary>
    ''' <param name="intRowIndex"></param>
    ''' <param name="e"></param>
    ''' <remarks>セルの色をセットする</remarks>
    Private Sub Sb_SetCellColor(ByVal intRowIndex As Integer, ByVal e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs)

        'If Not (e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Gray _
        'OrElse e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black) Then
        '    Exit Sub
        'End If

        If Not (e.Row.Cells(intRowIndex).Column.Style = ColumnStyle.Double OrElse _
            e.Row.Cells(intRowIndex).Column.Style = ColumnStyle.Integer) Then
            Exit Sub
        End If

        'マスタ系を判断する

        If Me.MasterFlg Then
            '黒色をセットする
            e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
        Else
            '一覧系を判断する

            If Me.ItiranEditFlg Then
                '黒色をセットする
                e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
            Else
                '一覧系CheckBoxを判断する

                If Me.IsItiranCheckBoxFlag Then
                    '黒色をセットする
                    e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                Else
                    '列の入力状態を判断する

                    If e.Row.Cells(intRowIndex).Column.CellActivation = Activation.AllowEdit Then
                        If e.Row.Activation = Activation.AllowEdit Then
                            If e.Row.Cells(intRowIndex).Activation = Activation.AllowEdit Then
                                '行の入力状態を判断する

                                If e.Row.Activation = Activation.AllowEdit Then
                                    '黒色をセットする
                                    e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                                Else
                                    '色なしをセットする

                                    e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                                End If
                            Else
                                '色なしをセットする

                                e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                            End If
                        Else
                            '色なしをセットする

                            e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                        End If
                    Else
                        '色なしをセットする

                        e.Row.Cells(intRowIndex).Appearance.ForeColor = ComVariable.Color_Black
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CtlGrid_CellChange(ByVal sender As Object, _
                                   ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) _
                                   Handles Me.CellChange
        Dim intColumnIndex As Integer
        Dim intRowIndex As Integer
        Dim intBandIndex As Integer
        'Dim intTextBit As Integer
        'Dim intTextLength As Integer

        Try
            'nothingを判断する

            If UCUtility.PFn_IsNothingOrNull(e.Cell) Then
                Exit Sub
            End If

            '様式は「数字」を判断する
            If e.Cell.Column.Style = ColumnStyle.Integer OrElse _
                                        e.Cell.Column.Style = ColumnStyle.Double Then
                If e.Cell.Text.Equals(String.Empty) Then
                    Exit Sub
                End If

                If UCUtility.PFn_ToDouble(e.Cell.Text) < 0 Then
                    'マイナスの値を赤字で表示する

                    e.Cell.Appearance.ForeColor = ComVariable.Color_Red
                Else
                    e.Cell.Appearance.ForeColor = ComVariable.Color_Black
                End If

                Exit Sub
            End If

            '=======================================================================
            'MaxLength:全角文字　半角文字
            ''文字列を判断する
            'If e.Cell.Column.Style = ColumnStyle.Default Then

            '    intTextBit = Encoding.Default.GetByteCount(e.Cell.Text)
            '    intTextLength = e.Cell.Column.MaxLength

            '    If intTextLength <> 0 Then

            '        If e.Cell.Column.Style = ColumnStyle.Default Then

            '            If intTextBit > intTextLength Then
            '                '元値を設置する
            '                e.Cell.Value = mstrBeforeEdit
            '            Else
            '                mstrBeforeEdit = Me.ActiveCell.Text
            '            End If

            '        End If

            '    End If

            '    Exit Sub
            'End If
            '=======================================================================

            '様式は「DropDownList」を判断する
            If e.Cell.Column.Style = ColumnStyle.DropDownList Then
                intColumnIndex = e.Cell.Column.Index
                intRowIndex = e.Cell.Row.Index
                intBandIndex = e.Cell.Band.Index

                '前セルのnothingを判断する

                If Not e.Cell.Row.Cells(intColumnIndex - 1) Is Nothing Then
                    '「Tag」を判断する
                    If Me.DisplayLayout.Bands(intBandIndex).Columns(intColumnIndex - 1).Tag _
                        Is Nothing Then
                        Exit Sub
                    End If

                    '前セルのTagは「ComboBoxCode」を判断する
                    If Me.DisplayLayout.Bands(intBandIndex).Columns(intColumnIndex - 1).Tag.Equals( _
                            ComVariable.CON_ISCOMBOBOXCODE_FLG) Then
                        '当前セルのプッカスをセットする(TemplateAddRow事件ために)
                        e.Cell.Activate()

                        Me.EventManager.AllEventsEnabled = False
                        Dim SelectedValue As Object
                        'SelectedValue = Me.DisplayLayout.Bands(intBandIndex).Columns( _
                        '    intColumnIndex).ValueList.GetValue(Me.DisplayLayout.Bands( _
                        '    intBandIndex).Columns(intColumnIndex).ValueList.SelectedItemIndex)
                        If Not Me.rcFlg.Equals(String.Empty) Then

                            If Me.ActiveRow.Cells(intColumnIndex).ValueList Is Nothing Then
                                SelectedValue = Me.DisplayLayout.Bands(intBandIndex) _
                                            .Columns(intColumnIndex).ValueList.GetValue( _
                                            Me.DisplayLayout.Bands(intBandIndex) _
                                            .Columns(intColumnIndex).ValueList.SelectedItemIndex)
                            Else
                                SelectedValue = Me.ActiveRow.Cells(intColumnIndex) _
                                            .ValueList.GetValue(Me.ActiveRow _
                                            .Cells(intColumnIndex).ValueList.SelectedItemIndex)
                            End If

                        Else
                            SelectedValue = Me.DisplayLayout.Bands(intBandIndex) _
                                            .Columns(intColumnIndex).ValueList.GetValue( _
                                            Me.DisplayLayout.Bands(intBandIndex) _
                                            .Columns(intColumnIndex).ValueList.SelectedItemIndex)
                        End If

                        'コードをセットする

                        If SelectedValue.Equals(String.Empty) Then
                            e.Cell.Row.Cells(intColumnIndex - 1).Value = DBNull.Value
                        Else
                            e.Cell.Row.Cells(intColumnIndex - 1).Value = SelectedValue
                        End If

                        Me.EventManager.AllEventsEnabled = True
                    End If
                End If

                Exit Sub
            End If
        Catch ex As Exception
            Me.EventManager.AllEventsEnabled = True

            '異常処理
            'ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub

    ''' <summary>
    ''' キー事件処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>キー事件処理</remarks>
    Private Sub CtlGrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case System.Windows.Forms.Keys.Tab
                    'セルの背景色を処理

                    If Not Me.ActiveCell Is Nothing Then
                        Select Case Me.ActiveCell.Column.Style
                            Case ColumnStyle.Button ', ColumnStyle.CheckBox
                            Case Else
                                Select Case Me.ActiveCell.Style
                                    Case ColumnStyle.Button ', ColumnStyle.CheckBox
                                    Case Else
                                        If Me.ActiveCell.Column.CellActivation = Activation.ActivateOnly Then
                                            Exit Select
                                        End If
                                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                                            'Me.ActiveCell.Appearance.BackColor = Color.White
                                            If mcolBackColor = MUCColor.CommonEnter Then
                                                Me.ActiveCell.Appearance.BackColor = Nothing
                                            Else
                                                If BackColorFlg Then
                                                    If Me.ActiveCell.Appearance.BackColor <> Color.White Then
                                                        Me.ActiveCell.Appearance.BackColor = mcolBackColor
                                                    End If
                                                ElseIf Me.ActiveCell.Appearance.BackColor = MUCColor.CommonEnter Then
                                                    Me.ActiveCell.Appearance.BackColor = Nothing
                                                End If
                                            End If
                                        End If
                                End Select
                        End Select
                    End If
                    '「Enter」キーを判断する
                Case Windows.Forms.Keys.Enter
                    '当前選択行を判断する
                    If Not Me.ActiveRow Is Nothing Then
                        '当前選択行は新規行を判断する
                        If Me.ActiveRow.IsAddRow Then
                            '当前選択セルを判断する

                            If Not Me.ActiveCell Is Nothing Then
                                Dim intRow As Integer
                                Dim intCol As Integer

                                '位置を取得する

                                intRow = Me.ActiveRow.Index
                                intCol = Me.ActiveCell.Column.Index

                                '当前セルを再セットする

                                If Me.ActiveRow.HasParent Then
                                    Me.ActiveRow.ParentRow.ChildBands(0).Rows(intRow).Cells(intCol).Activated = True
                                Else
                                    'Me.ActiveCell.Activated = True
                                    Me.Rows(intRow).Cells(intCol).Activated = True
                                End If


                                'Me.ActiveRow.

                                '当前動作を戻る

                                e.Handled = True

                                'Me.PerformAction(UltraGridAction.NextCellByTab, False, False)
                            End If
                        End If
                    End If
                    Exit Sub

                Case Windows.Forms.Keys.Space
                    '「空格」キーを判断する
                    If Not Me.ActiveCell Is Nothing Then
                        'CheckBox様式を判断する

                        If Me.ActiveCell.Column.Style = ColumnStyle.CheckBox Then
                            Me.EventManager.AllEventsEnabled = False
                            Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
                            Me.EventManager.AllEventsEnabled = True
                        End If
                    End If
                    Exit Sub

                Case Windows.Forms.Keys.M

                    'alt+N:F1

                    '「F1」キーを判断する
                    If Not Me.ActiveCell Is Nothing Then
                        If e.Alt AndAlso Not e.Shift AndAlso Not e.Control Then
                            'ボタン様式を判断する
                            If Me.ActiveCell.Column.Style = ColumnStyle.EditButton AndAlso _
                                Me.ActiveCell.Activation = Activation.AllowEdit Then

                                'クリック事件を実行する

                                Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                            ElseIf Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                Me.ActiveCell.Column.Style = ColumnStyle.DateTime OrElse _
                                Me.ActiveCell.Column.Style = ColumnStyle.DropDownList Then

                                blnF4Flag = True
                                System.Windows.Forms.SendKeys.Send("{F4}")

                            End If
                            'コンボボックスを判断する
                            If Not Me.ActiveCell Is Nothing Then
                                If Not Me.ActiveCell.Column.Tag Is Nothing Then
                                    If Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCOMBOBOXCODE_FLG) Then

                                        Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 1)

                                        If Me.ActiveCell.Column.Style = ColumnStyle.DropDownList Then
                                            blnF4Flag = True
                                            System.Windows.Forms.SendKeys.Send("{F4}")

                                        End If
                                    ElseIf Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                                           Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) OrElse _
                                           Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODESEARCH_FLG) OrElse _
                                           Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODE_ALPHANUMERIME_FLG) Then

                                        If Not Me.ActiveCell.Column.Style = ColumnStyle.EditButton Then
                                            If Me.ActiveCell.Activation = Activation.AllowEdit Then

                                                If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Column.Tag.Equals(ComVariable.CON_ISCODESEARCH_FLG) OrElse _
                                                   Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Column.Tag.Equals(ComVariable.CON_ISCODE_ALPHANUMERIME_FLG) Then

                                                    If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Activation = Activation.AllowEdit Then
                                                        Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index)

                                                        'クリック事件を実行する

                                                        Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))
                                                    End If

                                                Else
                                                    If Not Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag Is Nothing Then
                                                        If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                                                           Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) Then
                                                            If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Style = ColumnStyle.EditButton AndAlso _
                                                               Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Activation = Activation.AllowEdit Then

                                                                Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 1)

                                                                'クリック事件を実行する

                                                                Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                                                            ElseIf Not Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag Is Nothing Then
                                                                If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                                                                                                                           Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) Then
                                                                    If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Style = ColumnStyle.EditButton AndAlso _
                                                                       Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Activation = Activation.AllowEdit Then

                                                                        Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 2)

                                                                        'クリック事件を実行する

                                                                        Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                                                                        'Add by 2014/03/11 Liu Start
                                                                    ElseIf Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 3).Column.Style = ColumnStyle.EditButton AndAlso _
                                                                        Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 3).Activation = Activation.AllowEdit Then

                                                                        Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 3)

                                                                        'クリック事件を実行する

                                                                        Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))
                                                                        'Add by 2014/03/11 Liu End
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If

                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If

                    End If

                    '「F1」キーを判断する
                    'If Not Me.ActiveCell Is Nothing Then
                    '    If Not e.Alt AndAlso Not e.Shift AndAlso Not e.Control Then
                    '        'ボタン様式を判断する
                    '        If Me.ActiveCell.Column.Style = ColumnStyle.EditButton AndAlso _
                    '            Me.ActiveCell.Activation = Activation.AllowEdit Then

                    '            'クリック事件を実行する

                    '            Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                    '        ElseIf Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                    '            Me.ActiveCell.Column.Style = ColumnStyle.DateTime OrElse _
                    '            Me.ActiveCell.Column.Style = ColumnStyle.DropDownList Then

                    '            blnF4Flag = True
                    '            System.Windows.Forms.SendKeys.Send("{F4}")

                    '        End If
                    '        'コンボボックスを判断する
                    '        If Not Me.ActiveCell Is Nothing Then
                    '            If Not Me.ActiveCell.Column.Tag Is Nothing Then
                    '                If Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCOMBOBOXCODE_FLG) Then

                    '                    Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 1)

                    '                    If Me.ActiveCell.Column.Style = ColumnStyle.DropDownList Then
                    '                        blnF4Flag = True
                    '                        System.Windows.Forms.SendKeys.Send("{F4}")

                    '                    End If
                    '                ElseIf Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                    '                       Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) OrElse _
                    '                       Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODESEARCH_FLG) OrElse _
                    '                       Me.ActiveCell.Column.Tag.Equals(ComVariable.CON_ISCODE_ALPHANUMERIME_FLG) Then

                    '                    If Not Me.ActiveCell.Column.Style = ColumnStyle.EditButton Then
                    '                        If Me.ActiveCell.Activation = Activation.AllowEdit Then

                    '                            If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Column.Tag.Equals(ComVariable.CON_ISCODESEARCH_FLG) OrElse _
                    '                               Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Column.Tag.Equals(ComVariable.CON_ISCODE_ALPHANUMERIME_FLG) Then

                    '                                If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index).Activation = Activation.AllowEdit Then
                    '                                    Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index)

                    '                                    'クリック事件を実行する

                    '                                    Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))
                    '                                End If

                    '                            Else
                    '                                If Not Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag Is Nothing Then
                    '                                    If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                    '                                       Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) Then
                    '                                        If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Column.Style = ColumnStyle.EditButton AndAlso _
                    '                                           Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 1).Activation = Activation.AllowEdit Then

                    '                                            Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 1)

                    '                                            'クリック事件を実行する

                    '                                            Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                    '                                        ElseIf Not Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag Is Nothing Then
                    '                                            If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag.Equals(ComVariable.CON_ISCODEIME_FLG) OrElse _
                    '                                                                                                       Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Tag.Equals(ComVariable.CON_ISALPHANUMERIME_FLG) Then
                    '                                                If Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Column.Style = ColumnStyle.EditButton AndAlso _
                    '                                                   Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 2).Activation = Activation.AllowEdit Then

                    '                                                    Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 2)

                    '                                                    'クリック事件を実行する

                    '                                                    Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))

                    '                                                    'Add by 2014/03/11 Liu Start
                    '                                                ElseIf Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 3).Column.Style = ColumnStyle.EditButton AndAlso _
                    '                                                    Me.ActiveRow.Cells(Me.ActiveCell.Column.Index + 3).Activation = Activation.AllowEdit Then

                    '                                                    Me.ActiveCell = Me.ActiveCell.Row.Cells(Me.ActiveCell.Column.Index + 3)

                    '                                                    'クリック事件を実行する

                    '                                                    Me.OnClickCellButton(New Infragistics.Win.UltraWinGrid.CellEventArgs(Me.ActiveCell))
                    '                                                    'Add by 2014/03/11 Liu End
                    '                                                End If
                    '                                            End If
                    '                                        End If
                    '                                    End If
                    '                                End If
                    '                            End If

                    '                        End If
                    '                    End If
                    '                End If
                    '            End If
                    '        End If
                    '    End If

                    'End If

                    Exit Sub
                Case Windows.Forms.Keys.F4
                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                           Me.ActiveCell.Column.Style = ColumnStyle.DateTime OrElse _
                           Me.ActiveCell.Column.Style = ColumnStyle.DropDownList Then

                            If blnF4Flag = True Then
                                blnF4Flag = False
                            Else
                                e.Handled = True
                            End If
                        End If
                    End If
                Case Windows.Forms.Keys.Oem1, Windows.Forms.Keys.Oemplus
                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                        Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then
                                        Me.ActiveCell.Value = Now.ToString("yyyy/MM/dd")
                                    End If
                                End If

                            End If

                        End If
                    End If
                Case Windows.Forms.Keys.OemMinus, Windows.Forms.Keys.Subtract
                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                        Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then
                                        Me.ActiveCell.Value = DateAdd(DateInterval.Day, -1, Now).ToString("yyyy/MM/dd")
                                    End If
                                End If

                            End If

                        End If
                    End If
                Case Windows.Forms.Keys.PageUp

                    '補助入力キー設定
                    Dim dtNowDay As Date

                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                        Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then
                                        dtNowDay = Now
                                        Me.ActiveCell.Value = DateSerial(dtNowDay.Year, dtNowDay.Month, 1).ToString("yyyy/MM/dd")
                                    End If
                                End If

                            End If

                        End If

                    End If
                Case Windows.Forms.Keys.PageDown

                    '補助入力キー設定
                    Dim dtNowDay As Date

                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                        Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then

                                        dtNowDay = Now
                                        Me.ActiveCell.Value = DateSerial(dtNowDay.Year, dtNowDay.Month + 1, 0).ToString("yyyy/MM/dd")

                                    End If
                                End If

                            End If

                        End If

                    End If
                Case Windows.Forms.Keys.Up
                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                        Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then

                                        If Not Me.ActiveCell.Value Is Nothing Then
                                            Me.ActiveCell.Value = DateAdd(DateInterval.Day, -1, Me.ActiveCell.Value).ToString("yyyy/MM/dd")
                                            e.Handled = True
                                        Else
                                            Me.ActiveCell.Value = Now
                                            e.Handled = True
                                        End If
                                    End If
                                End If

                            End If
                        End If

                    End If

                Case Windows.Forms.Keys.Down
                    If Not Me.ActiveCell Is Nothing Then
                        If Me.ActiveCell.Activation = Activation.AllowEdit Then
                            If Me.ActiveCell.Column.CellActivation = Activation.AllowEdit Then
                                If Me.ActiveCell.IsInEditMode Then
                                    '数値と日付を判断する

                                    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                                    Me.ActiveCell.Column.Style = ColumnStyle.DateTime Then
                                        If Not Me.ActiveCell.Value Is Nothing Then
                                            Me.ActiveCell.Value = DateAdd(DateInterval.Day, 1, Me.ActiveCell.Value).ToString("yyyy/MM/dd")
                                            e.Handled = True
                                        Else
                                            Me.ActiveCell.Value = Now
                                            e.Handled = True
                                        End If
                                    End If
                                End If

                            End If
                        End If

                    End If

                    ''「上、下」キーを判断する
                    'If Not Me.ActiveCell Is Nothing Then
                    '    '数値と日付を判断する

                    '    If Me.ActiveCell.Column.Style = ColumnStyle.Date OrElse _
                    '    Me.ActiveCell.Column.Style = ColumnStyle.DateTime OrElse _
                    '    Me.ActiveCell.Column.Style = ColumnStyle.Double OrElse _
                    '    Me.ActiveCell.Column.Style = ColumnStyle.Integer Then
                    '        '入力モードを判断する
                    '        If Me.ActiveCell.IsInEditMode Then
                    '            e.Handled = True
                    '        End If
                    '    End If
                    'End If
                Case Else
                    UCUtility.CopyGridCell(e, Me)
            End Select
        Catch ex As Exception
            '異常処理
            'ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub

    ''' <summary>
    ''' セルのエラー処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>セルのエラー処理</remarks>
    Private Sub CtlGrid_CellDataError(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellDataErrorEventArgs) Handles Me.CellDataError
        Try
            e.RestoreOriginalValue = True
            e.RaiseErrorEvent = False
        Catch ex As Exception
            '異常処理
            ' ComException.Show(Me.ActiveFormFeatureCode, ex)
        End Try
    End Sub

  
    Private Sub CtlGrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        '当前行の有無を判断する

        If Me.ActiveRow Is Nothing Then
            Exit Sub
        End If

        '新規行を判断する
        If Not Me.ActiveRow.IsAddRow Then
            Exit Sub
        End If

        '親行を判断する

        If Not Me.ActiveRow.HasParent Then
            Exit Sub
        End If

        Me.EventManager.AllEventsEnabled = False
        '有効行を判断する
        If Me.ActiveRow.Index > 0 Then
            '上行のプッカスをセットする

            Me.ActiveRow.ParentRow.ChildBands(0).Rows(Me.ActiveRow.Index - 1).Activate()
        Else
            '親行のプッカスをセットする

            Me.ActiveRow.ParentRow.Activate()
        End If

        Me.EventManager.AllEventsEnabled = True
    End Sub

    Protected Overrides Sub OnAfterCellUpdate(ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)

        Dim strColumns() As String

        If Not Me.ActiveCell Is Nothing Then

            If Not InsertColumn.Equals(String.Empty) Then

                If Me.ActiveCell.Band.Index = 0 Then

                    strColumns = InsertColumn.Split(CChar(","))

                    Call SetInsertValue(strColumns, 0, e)

                End If
            End If

            If Not InsertColumn1.Equals(String.Empty) Then

                If Me.ActiveCell.Band.Index = 1 Then

                    strColumns = InsertColumn1.Split(CChar(","))

                    Call SetInsertValue(strColumns, 1, e)

                End If
            End If

            If Not InsertColumn2.Equals(String.Empty) Then

                If Me.ActiveCell.Band.Index = 2 Then

                    strColumns = InsertColumn2.Split(CChar(","))

                    Call SetInsertValue(strColumns, 2, e)

                End If
            End If

        End If

        '事件処理を開始する

        Call MyBase.OnAfterCellUpdate(e)
    End Sub

    Private Sub CtlGrid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim intASCNum As Integer               'ASC番号

        'Ctrl + C
        If Asc(e.KeyChar) = 3 Then
            Exit Sub
        End If

        'Backspaceキー
        If Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        'Ctrl + V
        If Asc(e.KeyChar) = 22 Then
            Exit Sub
        End If

        'Ctrl + X
        If Asc(e.KeyChar) = 24 Then
            Exit Sub
        End If

        'Ctrl + Z
        If Asc(e.KeyChar) = 26 Then
            Exit Sub
        End If

        If Not Me.ActiveCell Is Nothing Then

            If Not Me.ActiveCell.Column.Tag Is Nothing Then

                If Me.ActiveCell.Column.Tag = ComVariable.CON_ISCODEIME_FLG _
                OrElse Me.ActiveCell.Column.Tag = ComVariable.CON_ISCOMBOBOXCODE_FLG _
                OrElse Me.ActiveCell.Column.Tag = ComVariable.CON_ISCODESEARCH_FLG Then
                    '数字チェック
                    intASCNum = Asc(e.KeyChar)

                    '「0-9」を判断する
                    If 48 <= intASCNum AndAlso intASCNum <= 57 Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                ElseIf Me.ActiveCell.Column.Tag = ComVariable.CON_ISALPHANUMERIME_FLG _
                    OrElse Me.ActiveCell.Column.Tag = ComVariable.CON_ISCODE_ALPHANUMERIME_FLG Then
                    '英文数字(A-Z,a-z,0-9)
                    intASCNum = Asc(e.KeyChar)

                    '半角チェック「a-z」、「A-Z」、「0-9」と「-」を判断する
                    If (intASCNum >= 97 AndAlso intASCNum <= 122) _
                    OrElse (intASCNum >= 65 AndAlso intASCNum <= 90) _
                    OrElse (intASCNum >= 48 AndAlso intASCNum <= 57) _
                    OrElse intASCNum = 45 OrElse intASCNum = 42 Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                ElseIf Me.ActiveCell.Column.Tag = ComVariable.CON_ISCODESPACEIME_FLG Then
                    '数字チェック
                    intASCNum = Asc(e.KeyChar)

                    '「0-9」を判断する
                    If 48 <= intASCNum AndAlso intASCNum <= 57 _
                    OrElse intASCNum = 32 Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If

            End If

        End If

    End Sub

#End Region

#Region "関数"

#Region "プッカス相関関数"
    ''' <summary>
    ''' 登録処理後グリッドの焦点設置(廃棄)
    ''' </summary>
    ''' <remarks>登録処理後グリッドの焦点設置(廃棄)</remarks>
    ''' <history>
    ''' 	[WANGZHIFENG]	2010/01/24	Created
    ''' </history>
    Public Sub PSb_SetEntryFocus()

        'Dim rowSelected As UltraGridRow
        'Dim cellSelected As UltraGridCell
        ''データの更新
        'Me.UpdateData()

        'With Me.Selected
        '    '行選択を焦点設置
        '    If .Rows.Count > 0 Then
        '        For Each rowSelected In .Rows
        '            rowSelected.Selected = False
        '            If rowSelected.Activated = True Then
        '                rowSelected.Selected = True
        '            End If
        '        Next
        '    End If
        '    '列選択を焦点設置
        '    If .Cells.Count > 0 Then
        '        For Each cellSelected In .Cells
        '            cellSelected.Selected = False
        '            If cellSelected.Activated = True Then
        '                cellSelected.Selected = True
        '            End If
        '        Next
        '    End If
        'End With

        ''セルを状態

        'Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        Me.Select()

    End Sub

    ''' <summary>
    ''' 一覧グリッドの焦点設置
    ''' </summary>
    ''' <param name="intCellRowIndex">行番号</param>
    ''' <param name="intCellColumnIndex">列番号</param>
    ''' <remarks>一覧グリッドの焦点設置</remarks>
    Public Sub PSb_SetItiranFocus(ByVal intCellRowIndex As Integer, _
                                ByVal intCellColumnIndex As Integer)
        Me.Focus()
        If Me.Rows.Count > 0 Then
            Me.Rows(intCellRowIndex).Cells(intCellColumnIndex).Activate()
        End If
    End Sub


    ''' <summary>
    ''' グリッドのフォーカスをセットする(外部)
    ''' </summary>
    ''' <param name="intCellRowIndex">行番号</param>
    ''' <param name="intCellColumnIndex">列番号</param>
    ''' <param name="intBandIndex">バンド番号</param>
    ''' <param name="intChildCellRowIndex">子バンド行番号</param>
    ''' <param name="intChildChildCellRowIndex">子の子バンド行番号</param>
    ''' <remarks>グリッドのフォーカスをセットする(外部)</remarks>
    Public Sub PSb_SetCellFocus(ByVal intCellRowIndex As Integer, _
                                ByVal intCellColumnIndex As Integer, _
                                Optional ByVal intBandIndex As Integer = 0, _
                                Optional ByVal intChildCellRowIndex As Integer = 0, _
                                Optional ByVal intChildChildCellRowIndex As Integer = 0)
        '全て事件は使用不可をセットする

        Me.EventManager.AllEventsEnabled = False

        '進入事件フラグは使用不可をセットする
        Me.mblnEnterEventFLG = False

        'グリッドのプッカスをセットする

        Me.Focus()

        '全て事件は使用可をセットする
        Me.EventManager.AllEventsEnabled = True

        '有効行を判断する
        If Me.Rows.Count > 0 Then
            '多層を判断する

            If intBandIndex = 0 Then
                '一層のセルをセットする
                Me.ActiveCell = Me.Rows(intCellRowIndex).Cells(intCellColumnIndex)
            ElseIf intBandIndex = 1 Then
                '多層の有効行を判断する

                If Me.Rows(intCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする

                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).Cells(intCellColumnIndex)
                Else
                    '多層の新規行をセットする
                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows.TemplateAddRow.Cells(intCellColumnIndex)
                End If
            ElseIf intBandIndex = 2 Then
                '多層の有効行を判断する

                If Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする

                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows(intChildChildCellRowIndex).Cells(intCellColumnIndex)
                Else
                    '多層の新規行をセットする
                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows.TemplateAddRow.Cells(intCellColumnIndex)
                End If
            End If
        Else
            '新規行をセットする

            Me.ActiveCell = Me.Rows.TemplateAddRow.Cells(intCellColumnIndex)
        End If

        'プッカスをセットする
        Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))

        Me.mblnEnterEventFLG = True
    End Sub

    ''' <summary>
    ''' グリッドのフォーカスをセットする(外部)
    ''' </summary>
    ''' <param name="intCellRowIndex">行番号</param>
    ''' <param name="strColKey">列名</param>
    ''' <param name="intBandIndex">バンド番号</param>
    ''' <param name="intChildCellRowIndex">子バンド行番号</param>
    ''' <param name="intChildChildCellRowIndex">子の子バンド行番号</param>
    ''' <remarks>グリッドのフォーカスをセットする(外部)</remarks>
    Public Sub PSb_SetCellFocus(ByVal intCellRowIndex As Integer, _
                                ByVal strColKey As String, _
                                Optional ByVal intBandIndex As Integer = 0, _
                                Optional ByVal intChildCellRowIndex As Integer = 0, _
                                Optional ByVal intChildChildCellRowIndex As Integer = 0)
        ''一覧を判断する
        'If Me.ItiranEditFlg Then
        '    Exit Sub
        'End If

        '全て事件は使用不可をセットする

        Me.EventManager.AllEventsEnabled = False

        '進入事件フラグは使用不可をセットする
        Me.mblnEnterEventFLG = False

        'グリッドのプッカスをセットする

        Me.Focus()

        '全て事件は使用可をセットする
        Me.EventManager.AllEventsEnabled = True

        '有効行を判断する
        If Me.Rows.Count > 0 Then
            '多層を判断する

            If intBandIndex = 0 Then
                '一層のセルをセットする
                Me.ActiveCell = Me.Rows(intCellRowIndex).Cells(strColKey)
            ElseIf intBandIndex = 1 Then
                '多層の有効行を判断する

                If Me.Rows(intCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする

                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).Cells(strColKey)
                Else
                    '多層の新規行をセットする
                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows.TemplateAddRow.Cells(strColKey)
                End If
            ElseIf intBandIndex = 2 Then
                '多層の有効行を判断する

                If Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0).Rows.Count > 0 Then
                    '多層のセルをセットする

                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows(intChildChildCellRowIndex).Cells(strColKey)
                Else
                    '多層の新規行をセットする
                    Me.ActiveCell = Me.Rows(intCellRowIndex).ChildBands(0).Rows(intChildCellRowIndex).ChildBands(0). _
                                       Rows.TemplateAddRow.Cells(strColKey)
                End If
            End If
        Else
            '新規行をセットする

            Me.ActiveCell = Me.Rows.TemplateAddRow.Cells(strColKey)
        End If

        'プッカスをセットする
        Me.BeginInvoke(New Windows.Forms.MethodInvoker(AddressOf SetEnterEditMode))

        Me.mblnEnterEventFLG = True
    End Sub

    Public Sub PSb_SetCellButtonFocus(ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        If e.Cell.Row.IsAddRow AndAlso e.Cell.Row.Index = 0 Then
            e.Cell.Row.Update()
            Me.PSb_SetCellFocus(e.Cell.Row.Index, e.Cell.Column.Index)
            e.Cell.Activate()
            Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        End If
    End Sub

    ''' <summary>
    ''' グリッド既時チッェクした、プッカスの設置関数(内部)
    ''' </summary>
    ''' <param name="intCellRowIndex">行番号</param>
    ''' <param name="intColIndex">列番号</param>
    ''' <param name="intBandIndex">バード番号</param>
    ''' <param name="intChildCellRowIndex">子層行番号</param>
    ''' <param name="intChildChildCellRowIndex">子の子バンド行番号</param>
    ''' <remarks>グリッド既時チッェクした、プッカスの設置関数(内部)</remarks>
    Public Sub PSb_SetUpdateCellFocus(ByVal intCellRowIndex As Integer, _
                                ByVal intColIndex As Integer, _
                                Optional ByVal intBandIndex As Integer = 0, _
                                Optional ByVal intChildCellRowIndex As Integer = 0, _
                                Optional ByVal intChildChildCellRowIndex As Integer = 0)
        Call PSb_SetCellFocus(intCellRowIndex, intColIndex, intBandIndex, intChildCellRowIndex, intChildChildCellRowIndex)
        mblnExitFocus = True
    End Sub

    ''' <summary>
    ''' グリッド既時チッェクした、プッカスの設置関数(内部)
    ''' </summary>
    ''' <param name="intCellRowIndex">行番号</param>
    ''' <param name="strColKey">列キー</param>
    ''' <param name="intBandIndex">バード番号</param>
    ''' <param name="intChildCellRowIndex">子層行番号</param>
    ''' <param name="intChildChildCellRowIndex">子の子バンド行番号</param>
    ''' <remarks>グリッド既時チッェクした、プッカスの設置関数(内部)</remarks>
    Public Sub PSb_SetUpdateCellFocus(ByVal intCellRowIndex As Integer, _
                                ByVal strColKey As String, _
                                Optional ByVal intBandIndex As Integer = 0, _
                                Optional ByVal intChildCellRowIndex As Integer = 0, _
                                Optional ByVal intChildChildCellRowIndex As Integer = 0)
        Call PSb_SetCellFocus(intCellRowIndex, strColKey, intBandIndex, intChildCellRowIndex, intChildChildCellRowIndex)
        mblnExitFocus = True
    End Sub

#End Region

#Region "文字色処理関数"
    ''' <summary>
    ''' グリッドの文字色をセットする
    ''' </summary>
    ''' <param name="intRowsindex">行番号</param>
    ''' <remarks>グリッドの文字色をセットする</remarks>
    Public Sub PSb_SetRowFontRed(ByVal intRowsindex As Integer)
        Dim i As Integer
        '列をループする

        For i = 0 To Me.DisplayLayout.Bands(0).Columns.Count - 1
            '列の様式を判断する

            If Me.DisplayLayout.Bands(0).Columns(i).Style = ColumnStyle.Double OrElse _
                Me.DisplayLayout.Bands(0).Columns(i).Style = ColumnStyle.Integer Then
                'マイナスを判断する

                If UCUtility.PFn_ToDouble(Me.Rows(intRowsindex).Cells(i).Value) < 0 Then
                    '文字色をセットする

                    Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Red
                Else
                    '文字色をセットする

                    Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Black

                    ''一覧フラグを判断する

                    'If Me.ItiranEditFlg Then
                    '    '文字色をセットする

                    '    Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                    'Else
                    '    'マスタフラグを判断する

                    '    If MasterFlg Then
                    '        '文字色をセットする

                    '        Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                    '    Else
                    '        If Me.Rows(intRowsindex).Cells(i).Activation = Activation.AllowEdit Then
                    '            '文字色をセットする

                    '            Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                    '        Else
                    '            If Me.IsItiranCheckBoxFlag = False Then
                    '                '文字色をセットする

                    '                Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Gray
                    '            Else
                    '                '文字色をセットする

                    '                Me.Rows(intRowsindex).Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                    '            End If
                    '        End If
                    '    End If
                    'End If
                End If
            End If
        Next
    End Sub


    ''' <summary>
    ''' 数値の文字色を「赤色」に変更する
    ''' </summary>
    ''' <param name="e">当前セル</param>
    ''' <remarks>数値の文字色を「赤色」に変更する</remarks>
    Public Sub PSb_SetRowNumberColor(ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Dim intRowIndex As Integer          '当前行

        Dim i As Integer

        '当前行を取得する
        intRowIndex = e.Cell.Row.Index

        '列をループする

        For i = 0 To e.Cell.Band.Columns.Count - 1
            '様式は「数字」を判断する
            If e.Cell.Band.Columns(i).Style = ColumnStyle.Integer OrElse _
                                        e.Cell.Column.Style = ColumnStyle.Double Then
                If Not e.Cell.Row.Cells(i).Text.Equals(String.Empty) Then
                    If UCUtility.PFn_ToDouble(e.Cell.Row.Cells(i).Text) < 0 Then
                        'マイナスの値を赤字で表示する

                        e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Red
                    Else
                        e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Black

                        ''使用可を判断する
                        'If e.Cell.Row.Cells(i).Activation = Activation.AllowEdit Then
                        '    e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                        'Else
                        '    'マスタを判断する
                        '    If Me.MasterFlg Then
                        '        e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                        '    Else
                        '        If Me.IsItiranCheckBoxFlag = False Then
                        '            e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Gray
                        '        Else
                        '            e.Cell.Row.Cells(i).Appearance.ForeColor = ComVariable.Color_Black
                        '        End If
                        '    End If
                        'End If
                    End If
                End If
            End If
        Next
    End Sub

#End Region

#Region "列幅設置関数"

    ''' <summary>
    ''' グリッドの寛を取得する(多グリッド)
    ''' </summary>
    ''' <param name="blnOneHead">False:多グリッド存在</param>
    ''' <remarks>グリッドの寛を取得する</remarks>
    ''' <history>
    ''' 	[WANGZHIFENG]	2010/01/24	Created
    ''' </history>
    Public Sub PSb_GetHeadWith(ByRef lngGridWith() As Long, _
                               Optional ByVal blnOneHead As Boolean = False)

        Dim intColCount As Integer = 0                  '列数
        Dim intGridWithCount As Integer = 0             '総列数

        Dim intBandCount As Integer = 0                 'グリッド階数

        intBandCount = Me.DisplayLayout.Bands.Count - 1

        Me.ActiveColScrollRegion.Position = 0

        For intBand As Integer = 0 To intBandCount

            '列数を取得する

            intColCount = Me.DisplayLayout.Bands(intBand).Columns.Count

            '配列を宣言する
            ReDim Preserve lngGridWith(intColCount + intGridWithCount - 1)

            'グリッドの寛を取得する

            For i As Integer = 0 To intColCount - 1

                '多グリッド存在

                If blnOneHead = False Then
                    If Me.DisplayLayout.Bands(intBand).Columns(i).RowLayoutColumnInfo.PreferredCellSize.Width <> 0 Then
                        lngGridWith(i + intGridWithCount) = _
                        Me.DisplayLayout.Bands(intBand).Columns(i).RowLayoutColumnInfo.PreferredCellSize.Width
                    Else
                        lngGridWith(i + intGridWithCount) = Me.DisplayLayout.Bands(intBand).Columns(i).Width
                    End If
                Else
                    lngGridWith(i + intGridWithCount) = _
                                        Me.DisplayLayout.Bands(intBand).Columns(i).Width
                End If
            Next i

            '配列カウントを取得する

            intGridWithCount = intGridWithCount + intColCount
        Next intBand
    End Sub

    ''' <summary>
    ''' グリッドのコラムの寛さを設定する(多グリッド)
    ''' </summary>
    ''' <param name="lngGridWith">グリッドの寛さ</param>
    ''' <param name="blnOneHead">False:多グリッド存在</param>
    ''' <remarks>グリッドのコラムの寛さを設定する</remarks>
    ''' <history>
    ''' 	[WANGZHIFENG]	2010/01/24	Created
    ''' </history>
    Public Sub PSb_SetHeadWith(ByVal lngGridWith() As Long, _
                               Optional ByVal blnOneHead As Boolean = False)

        Dim intColCount As Integer = 0                  '列数
        Dim intGridWithCount As Integer = 0             '総列数

        Dim intBandCount As Integer = 0                 'グリッド階数

        'グリッドの列寛存在しない
        If lngGridWith Is Nothing OrElse lngGridWith.Length = 0 Then
            Exit Sub
        End If

        intBandCount = Me.DisplayLayout.Bands.Count - 1

        Me.ActiveColScrollRegion.Position = 0

        'グリッドのコラムの寛さを設定する
        For intBand As Integer = 0 To intBandCount

            '列数を取得する

            intColCount = Me.DisplayLayout.Bands(intBand).Columns.Count

            'グリッドの寛を設定する

            For i As Integer = 0 To intColCount - 1
                '多グリッド存在

                If blnOneHead = False Then
                    Me.DisplayLayout.Bands(intBand).Columns(i).RowLayoutColumnInfo.PreferredCellSize = _
                    New System.Drawing.Size(UCUtility.PFn_ToInteger(lngGridWith(i + intGridWithCount)), _MinRowHeight)


                Else
                    Me.DisplayLayout.Bands(intBand).Columns(i).RowLayoutColumnInfo.PreferredCellSize = _
                    New System.Drawing.Size(UCUtility.PFn_ToInteger(lngGridWith(i + intGridWithCount)), _MinRowHeight)
                    'Me.DisplayLayout.Bands(intBand).Columns(i).Width = _
                    '                    UCUtility.PFn_ToInteger(lngGridWith(i + intGridWithCount))
                End If
            Next i

            '配列カウントを取得する

            intGridWithCount = intGridWithCount + intColCount
        Next intBand
    End Sub

#End Region

    Public Sub PSb_Clear()

        Dim dtGrid As DataTable = Nothing
        Dim i As Integer
        Dim j As Integer

        For i = 0 To Me.DisplayLayout.Bands.Count - 1
            dtGrid = New DataTable
            For j = 0 To Me.DisplayLayout.Bands(i).Columns.Count - 1
                '数字類型を判断する

                If Me.DisplayLayout.Bands(i).Columns(j).Style = ColumnStyle.Integer Then
                    '「Integer」類型をセットする

                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key, GetType(Integer))
                ElseIf Me.DisplayLayout.Bands(i).Columns(j).Style = ColumnStyle.Double Then
                    '「Double」類型をセットする

                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key, GetType(Double))
                ElseIf Me.DisplayLayout.Bands(i).Columns(j).Style = ColumnStyle.Date Then
                    '「Date」類型をセットする

                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key, GetType(Date))
                ElseIf Me.DisplayLayout.Bands(i).Columns(j).Style = ColumnStyle.DateTime Then
                    '「DateTime」類型をセットする

                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key, GetType(DateTime))
                ElseIf Me.DisplayLayout.Bands(i).Columns(j).Style = ColumnStyle.DropDownCalendar Then
                    '「DropDownCalendar」類型をセットする

                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key, GetType(Date))
                Else
                    dtGrid.Columns.Add(Me.DisplayLayout.Bands(i).Columns(j).Key)
                End If
            Next j
        Next i
        Me.DataSource = dtGrid
    End Sub

    ''' <summary>
    ''' 小数桁数をセットする(整列)
    ''' </summary>
    ''' <param name="intBandIndex">パッド番号</param>
    ''' <param name="intColIndex">列番号</param>
    ''' <param name="strMaskInput">MaskInput</param>
    ''' <remarks>小数桁数をセットする(整列)</remarks>
    Public Sub PSb_SetGridNumberDigits(ByVal intBandIndex As Integer, _
                                       ByVal intColIndex() As Integer, _
                                      ByVal strMaskInput As String)
        Dim i As Integer
        Try
            If strMaskInput Is Nothing OrElse strMaskInput.Equals(String.Empty) Then
                Exit Sub
            End If

            For i = LBound(intColIndex) To UBound(intColIndex)
                If strMaskInput.IndexOf(".") >= 0 Then
                    Me.DisplayLayout.Bands(intBandIndex).Columns(intColIndex(i)).Style = ColumnStyle.Double
                    Me.DisplayLayout.Bands(intBandIndex).Columns(intColIndex(i)).MaskInput = strMaskInput
                Else
                    Me.DisplayLayout.Bands(intBandIndex).Columns(intColIndex(i)).Style = ColumnStyle.Integer
                    Me.DisplayLayout.Bands(intBandIndex).Columns(intColIndex(i)).MaskInput = strMaskInput
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 小数桁数をセットする(整列)
    ''' </summary>
    ''' <param name="intBandIndex">パッド番号</param>
    ''' <param name="strColKey">列キー</param>
    ''' <param name="strMaskInput">MaskInput</param>
    ''' <remarks>小数桁数をセットする(整列)</remarks>
    Public Sub PSb_SetGridNumberDigits(ByVal intBandIndex As Integer, _
                                       ByVal strColKey() As String, _
                                       ByVal strMaskInput As String)
        Dim i As Integer
        Try
            If strMaskInput Is Nothing OrElse strMaskInput.Equals(String.Empty) Then
                Exit Sub
            End If

            For i = LBound(strColKey) To UBound(strColKey)
                If strMaskInput.IndexOf(".") >= 0 Then
                    Me.DisplayLayout.Bands(intBandIndex).Columns(strColKey(i)).Style = ColumnStyle.Double
                    Me.DisplayLayout.Bands(intBandIndex).Columns(strColKey(i)).MaskInput = strMaskInput
                Else
                    Me.DisplayLayout.Bands(intBandIndex).Columns(strColKey(i)).Style = ColumnStyle.Integer
                    Me.DisplayLayout.Bands(intBandIndex).Columns(strColKey(i)).MaskInput = strMaskInput
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' 各端数小数単位のMaskInputをセットする(セル)
    ''' </summary>
    ''' <param name="intDecimal">各端数小数単位</param>
    ''' <param name="intCount">小数点前位数</param>
    ''' <param name="bolReadOnly">ReadOnly</param>
    ''' <returns>各端数小数単位のMaskInput</returns>
    ''' <remarks>各端数小数単位のMaskInputをセットする(セル)</remarks>
    Public Function PFn_GetEditorsValueList(ByVal intDecimal As Integer, _
                                         Optional ByVal intCount As Integer = 9, _
                                         Optional ByVal bolReadOnly As Boolean = True _
                                        ) As EmbeddableEditorBase

        Dim editorSettings As DefaultEditorOwnerSettings = Nothing

        '文字格式化

        editorSettings = New DefaultEditorOwnerSettings()
        editorSettings.MaskClipMode = UltraWinMaskedEdit.MaskMode.Raw
        editorSettings.MaskDataMode = UltraWinMaskedEdit.MaskMode.Raw
        editorSettings.MaskDisplayMode = UltraWinMaskedEdit.MaskMode.Raw

        '格式化文字列を取得する

        'editorSettings.MaskInput = ComBusiness.PFn_SetMaskInputString(intDecimal, intCount, bolReadOnly)
        'editorSettings.Format = ComBusiness.PFn_SetFormatString(intDecimal, intCount, bolReadOnly)
        PFn_GetEditorsValueList = New EditorWithMask(New DefaultEditorOwner(editorSettings))
    End Function

    ''' <summary>
    ''' メッセージを表示する(グリッド内、既時メッセージ用)
    ''' </summary>
    ''' <param name="strMsgID">メッセージコード</param>
    ''' <param name="strMsgItem1">引数1</param>
    ''' <param name="strMsgItem2">引数2</param>
    ''' <param name="strMsgItem3">引数3</param>
    ''' <remarks>メッセージを表示する(グリッド内、既時メッセージ用)</remarks>
    Public Sub PSb_CellUpdateMessage(ByVal strMsgID As String, _
                                          Optional ByVal strMsgItem1 As String = "", _
                                          Optional ByVal strMsgItem2 As String = "", _
                                          Optional ByVal strMsgItem3 As String = "")
        '表示メッセージフラグをセットする
        mblnExitEditShowFlg = True
        Dim mstrCellUpdateMsg As New ArrayList
        If mstrCellUpdateMsgID Is Nothing Then
            mstrCellUpdateMsgID = New ArrayList()
        End If
        mstrCellUpdateMsgID.Add(strMsgID)

        If mstrCellUpdateMsgItem1 Is Nothing Then
            mstrCellUpdateMsgItem1 = New ArrayList()
        End If
        mstrCellUpdateMsgItem1.Add(strMsgItem1)

        If mstrCellUpdateMsgItem2 Is Nothing Then
            mstrCellUpdateMsgItem2 = New ArrayList()
        End If
        mstrCellUpdateMsgItem2.Add(strMsgItem2)

        If mstrCellUpdateMsgItem3 Is Nothing Then
            mstrCellUpdateMsgItem3 = New ArrayList()
        End If
        mstrCellUpdateMsgItem3.Add(strMsgItem3)
    End Sub

   
    Public Sub PSb_SetRowOnEnable(ByVal objRow As UltraGridRow, _
                                  Optional ByVal objActivation As UltraWinGrid.Activation _
                                  = Activation.ActivateOnly)
        Dim i As Integer
        If objActivation = Activation.ActivateOnly OrElse objActivation = Activation.Disabled Then
            '照会行フラグをセットする
            objRow.Tag = ComVariable.CON_ISREADONLYROW_FLG

            '列をループして、照会モードをセットする
            For i = 0 To objRow.Cells.Count - 1

                'セルの使用をセットする

                objRow.Cells(i).Activation = objActivation

                '背景色をセットする

                objRow.Cells(i).Appearance.BackColor = Nothing

                '「TAB」順の使用をセットする

                objRow.Cells(i).TabStop = DefaultableBoolean.False

                Select Case objRow.Cells(i).Column.Style
                    Case ColumnStyle.Button                         '様式は「Button」を判断する
                        '使用不可をセットする
                        objRow.Cells(i).Activation = Activation.Disabled
                    Case ColumnStyle.EditButton                     '様式は「EditButton」を判断する
                        '使用不可をセットする
                        'objRow.Cells(i).Style = ColumnStyle.Edit
                        objRow.Cells(i).Style = ColumnStyle.EditButton
                End Select
            Next
        Else
            '列をループして、照会モードをセットする
            For i = 0 To objRow.Cells.Count - 1

                'セルの使用をセットする

                objRow.Cells(i).Activation = objActivation

                '背景色をセットする

                objRow.Cells(i).Appearance.BackColor = Color.White

                '「TAB」順の使用をセットする

                objRow.Cells(i).TabStop = DefaultableBoolean.True

                Select Case objRow.Cells(i).Column.Style
                    Case ColumnStyle.Button                         '様式は「Button」を判断する
                        '使用可をセットする

                        objRow.Cells(i).Style = ColumnStyle.EditButton
                    Case ColumnStyle.EditButton                     '様式は「EditButton」を判断する
                        '使用可をセットする

                        objRow.Cells(i).Style = ColumnStyle.EditButton
                End Select
            Next
        End If

        '色をセットする

        Call CtlGrid_InitializeRow(Nothing, New InitializeRowEventArgs(objRow, True))
    End Sub

    Public Sub PSb_SetCellEnable(ByVal objCell As Infragistics.Win.UltraWinGrid.UltraGridCell, _
                                 ByVal objActivation As UltraWinGrid.Activation)
        'セルの使用をセットする

        objCell.Activation = objActivation

        If objCell.Activation = Activation.ActivateOnly OrElse _
            objCell.Activation = Activation.Disabled Then
            '「TAB」順の使用をセットする

            objCell.TabStop = DefaultableBoolean.False

            '「EditButton」様式のセットする

            If objCell.Column.Style = ColumnStyle.EditButton Then
                'objCell.Style = ColumnStyle.Edit
                objCell.Style = ColumnStyle.EditButton
            ElseIf objCell.Column.Style = ColumnStyle.Button Then
                objCell.Activation = Activation.Disabled
            End If

            ''文字色をセットする

            'If objCell.Column.Style = ColumnStyle.Double OrElse _
            '    objCell.Column.Style = ColumnStyle.Integer Then
            '    If UCUtility.PFn_ToDouble(objCell.Value) < 0 Then
            '        objCell.Appearance.ForeColor = ComVariable.Color_Red
            '    Else
            '        objCell.Appearance.ForeColor = ComVariable.Color_Gray
            '    End If
            'Else
            '    objCell.Appearance.ForeColor = ComVariable.Color_Gray
            'End If
        Else
            '「TAB」順の使用をセットする

            objCell.TabStop = DefaultableBoolean.True

            '「EditButton」様式のセットする

            If objCell.Column.Style = ColumnStyle.EditButton Then
                objCell.Style = ColumnStyle.EditButton
            End If

            ''文字色をセットする

            'If objCell.Column.Style = ColumnStyle.Double OrElse _
            '    objCell.Column.Style = ColumnStyle.Integer Then
            '    If UCUtility.PFn_ToDouble(objCell.Value) < 0 Then
            '        objCell.Appearance.ForeColor = ComVariable.Color_Red
            '    Else
            '        objCell.Appearance.ForeColor = ComVariable.Color_Black
            '    End If
            'Else
            '    objCell.Appearance.ForeColor = ComVariable.Color_Black
            'End If
        End If

        '文字色をセットする

        If objCell.Column.Style = ColumnStyle.Double OrElse _
            objCell.Column.Style = ColumnStyle.Integer Then
            If UCUtility.PFn_ToDouble(objCell.Value) < 0 Then
                objCell.Appearance.ForeColor = ComVariable.Color_Red
            Else
                objCell.Appearance.ForeColor = ComVariable.Color_Black
            End If
        Else
            objCell.Appearance.ForeColor = ComVariable.Color_Black
        End If

    End Sub

    '''' <summary>
    '''' 列の使用をセットする
    '''' </summary>
    '''' <param name="objColumn">列</param>
    '''' <param name="objActivation">状態</param>
    '''' <remarks>列の使用をセットする</remarks>
    'Public Sub PSb_SetColumnEnable(ByVal objColumn As Infragistics.Win.UltraWinGrid.UltraGridColumn, _
    '                             ByVal objActivation As UltraWinGrid.Activation)
    '    Dim i As Integer

    '    'セルの使用をセットする

    '    objColumn.CellActivation = objActivation

    '    If objColumn.CellActivation = Activation.ActivateOnly OrElse _
    '        objColumn.CellActivation = Activation.Disabled Then
    '        '「TAB」順の使用をセットする

    '        objColumn.TabStop = False

    '        '「EditButton」様式のセットする

    '        If objColumn.Style = ColumnStyle.EditButton Then
    '            For i = 0 To objColumn.Band.Layout.Rows.Count - 1
    '                objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Style = ColumnStyle.Edit
    '            Next
    '        ElseIf objColumn.Style = ColumnStyle.Button Then
    '            objColumn.CellActivation = Activation.Disabled
    '        End If

    '        ''文字色をセットする

    '        'If objColumn.Style = ColumnStyle.Double OrElse _
    '        '    objColumn.Style = ColumnStyle.Integer Then
    '        '    For i = 0 To objColumn.Band.Layout.Rows.Count - 1
    '        '        If UCUtility.PFn_ToDouble(objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Value) < 0 Then
    '        '            objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Red
    '        '        Else
    '        '            objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Gray
    '        '        End If
    '        '    Next
    '        'Else
    '        '    objColumn.CellAppearance.ForeColor = ComVariable.Color_Gray
    '        'End If
    '    Else
    '        '「TAB」順の使用をセットする

    '        objColumn.TabStop = True

    '        '「EditButton」様式のセットする

    '        If objColumn.Style = ColumnStyle.EditButton Then
    '            For i = 0 To objColumn.Band.Layout.Rows.Count - 1
    '                objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Style = ColumnStyle.EditButton
    '            Next
    '        End If

    '        ''文字色をセットする

    '        'If objColumn.Style = ColumnStyle.Double OrElse _
    '        '    objColumn.Style = ColumnStyle.Integer Then
    '        '    For i = 0 To objColumn.Band.Layout.Rows.Count - 1
    '        '        If UCUtility.PFn_ToDouble(objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Value) < 0 Then
    '        '            objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Red
    '        '        Else
    '        '            objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Black
    '        '        End If
    '        '    Next
    '        'Else
    '        '    objColumn.CellAppearance.ForeColor = ComVariable.Color_Black
    '        'End If
    '    End If

    '    '文字色をセットする

    '    If objColumn.Style = ColumnStyle.Double OrElse _
    '        objColumn.Style = ColumnStyle.Integer Then
    '        For i = 0 To objColumn.Band.Layout.Rows.Count - 1
    '            If UCUtility.PFn_ToDouble(objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Value) < 0 Then
    '                objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Red
    '            Else
    '                objColumn.Band.Layout.Rows(i).Cells(objColumn.Index).Appearance.ForeColor = ComVariable.Color_Black
    '            End If
    '        Next
    '    Else
    '        objColumn.CellAppearance.ForeColor = ComVariable.Color_Black
    '    End If

    'End Sub

 
    Public Function PFn_CheckGridShiftTab(ByRef e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim intRowIndex As Integer
        Dim intColIndex As Integer
        Dim intTabRowIndex As Integer
        Dim intTabColIndex As Integer

        '初期設置
        PFn_CheckGridShiftTab = True
        'キーを判断する

        If e.Shift AndAlso e.KeyCode = Windows.Forms.Keys.Tab Then
            '当前セルの有無を判断する
            If Me.ActiveCell Is Nothing Then
                PFn_CheckGridShiftTab = True
                Exit Function
            End If

            '前回セルの位置を保存する
            intRowIndex = Me.ActiveCell.Row.Index
            intColIndex = Me.ActiveCell.Column.Index

            'プッカスを前に移動する

            Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.PrevCellByTab)

            '移動したセルの位置を保存する
            intTabRowIndex = Me.ActiveCell.Row.Index
            intTabColIndex = Me.ActiveCell.Column.Index

            '当操作を終了する
            e.Handled = True

            '前回セルの位置と移動したセルの位置を判断する
            If intRowIndex = intTabRowIndex AndAlso intColIndex = intTabColIndex Then
                '相同の場合、プッカスを設置する
                PFn_CheckGridShiftTab = False

                Exit Function
            End If
        End If
    End Function

    ''' <summary>
    ''' 照会Cellをセットする
    ''' </summary>
    ''' <param name="intColIndexF">列番号(From)</param>
    ''' <param name="intColIndexT">列番号(To)</param>
    ''' <param name="intBandIndex">層番号</param>
    ''' <param name="objActivation">アクティベート</param>
    ''' <remarks>入力Cellは照会Cellへセットする</remarks>
    Public Sub PSb_SetCellOnEnable(ByVal intColIndexF As Integer, _
                                   ByVal intColIndexT As Integer, _
                                   Optional ByVal intBandIndex As Integer = 0, _
                                   Optional ByVal objActivation As Activation = Activation.ActivateOnly)
        Dim i As Integer
        Dim j As Integer
        Select Case intBandIndex
            Case 0
                '一層

                '行をループする

                For i = 0 To Me.DisplayLayout.Rows.Count - 1
                    For j = intColIndexF To intColIndexT

                        'セルの使用をセットする

                        PSb_SetCellEnable(Me.DisplayLayout.Rows(i).Cells(j), objActivation)

                    Next
                Next
            Case 1
                '二層
                '列をループする

                For n = 0 To Me.DisplayLayout.Rows.Count - 1
                    For i = 0 To Me.Rows(n).ChildBands(0).Rows.Count - 1
                        For j = intColIndexF To intColIndexT

                            'セルの使用をセットする

                            PSb_SetCellEnable(Me.Rows(n).ChildBands(0).Rows(i).Cells(j), objActivation)

                        Next
                    Next
                Next
            Case 2
                '三層
                '列をループする

                For n = 0 To Me.DisplayLayout.Rows.Count - 1
                    For i = 0 To Me.Rows(n).ChildBands(0).Rows.Count - 1
                        For m = 0 To Me.Rows(n).ChildBands(0).Rows(i).ChildBands(0).Rows.Count - 1
                            For j = intColIndexF To intColIndexT

                                'セルの使用をセットする

                                PSb_SetCellEnable(Me.Rows(n).ChildBands(0).Rows(i).ChildBands(0).Rows(m).Cells(j), objActivation)

                            Next
                        Next
                    Next
                Next
        End Select

    End Sub

    ''' <summary>
    ''' 照会Cellをセットする
    ''' </summary>
    ''' <param name="intRowIndex">行番号</param>
    ''' <param name="intColIndexF">列番号(From)</param>
    ''' <param name="intColIndexT">列番号(To)</param>
    ''' <param name="intBandIndex">層番号</param>
    ''' <param name="intChildRowIndex">子行番号</param>
    ''' <param name="objActivation">アクティベート</param>
    ''' <remarks>入力Cellは照会Cellへセットする</remarks>
    Public Sub PSb_SetRowCellOnEnable(ByVal intRowIndex As Integer, _
                                      ByVal intColIndexF As Integer, _
                                      ByVal intColIndexT As Integer, _
                                      Optional ByVal intBandIndex As Integer = 0, _
                                      Optional ByVal intChildRowIndex As Integer = 0, _
                                      Optional ByVal objActivation As Activation = Activation.ActivateOnly, _
                                      Optional ByVal intChildChildRowIndex As Integer = 0)
        Dim i As Integer
        Select Case intBandIndex
            Case 0
                '一層

                '行をループする

                For i = intColIndexF To intColIndexT

                    'セルの使用をセットする

                    PSb_SetCellEnable(Me.DisplayLayout.Rows(intRowIndex).Cells(i), objActivation)

                Next
            Case 1
                '二層
                '列をループする

                For i = intColIndexF To intColIndexT

                    'セルの使用をセットする

                    PSb_SetCellEnable(Me.Rows(intRowIndex).ChildBands(0).Rows(intChildRowIndex).Cells(i), objActivation)

                Next
            Case 2
                '三層
                '列をループする

                For i = intColIndexF To intColIndexT

                    'セルの使用をセットする

                    PSb_SetCellEnable(Me.Rows(intRowIndex).ChildBands(0).Rows(intChildRowIndex).ChildBands(0).Rows(intChildChildRowIndex).Cells(i), objActivation)

                Next
        End Select

    End Sub

    ' ''' <summary>
    ' ''' 「CodeText」コードについて、マスタを検索する

    ' ''' </summary>
    ' ''' <param name="rowIndex">行のIndex番号</param>
    ' ''' <param name="codeKey">コード列キー</param>
    ' ''' <param name="nameKey">名前列キー</param>
    ' ''' <param name="SQLCode">SQL文番号</param>
    ' ''' <param name="hstPara">引数</param>
    ' ''' <param name="blnShowFlg">表示フラグの判断FLG</param>
    ' ''' <remarks>「CodeText」コードについて、マスタを検索する</remarks>
    'Public Sub CodeValidating(ByVal rowIndex As Integer, ByVal codeKey As String, ByVal nameKey As String, ByVal SQLCode As Integer, Optional ByVal hstPara As Hashtable = Nothing, Optional ByVal blnShowFlg As Boolean = True)
    '    Dim dtData As DataTable = Nothing
    '    Dim strCode As String

    '    Try
    '        Me.EventManager.AllEventsEnabled = False

    '        strCode = UCUtility.PFn_Trim(Me.Rows(rowIndex).Cells(codeKey).Value)

    '        '入力文字を判断する

    '        If strCode = String.Empty Or strCode = "" Then
    '            Me.Rows(rowIndex).Cells(nameKey).Value = String.Empty
    '        End If

    '        'SQL文を実行する
    '        dtData = ComBusiness.PFn_GetDataFromCode(strCode, SQLCode, hstPara)

    '        'データの存在を判断する

    '        If dtData Is Nothing OrElse dtData.Rows.Count <= 0 Then
    '            'コード

    '            Me.Rows(rowIndex).Cells(codeKey).Value = String.Empty

    '            'データがない時、名前項目をクリアする

    '            Me.Rows(rowIndex).Cells(nameKey).Value = String.Empty

    '            Me.PSb_SetCellFocus(rowIndex, codeKey)
    '        Else
    '            '名前をセットする
    '            Me.Rows(rowIndex).Cells(nameKey).Value = UCUtility.PFn_ToString(dtData.Rows(0)(0))

    '            If blnShowFlg Then
    '                '表示フラグを判断する
    '                Dim strShowFlg As Integer = 0
    '                strShowFlg = UCUtility.PFn_ToInteger(dtData.Rows(0)(1))

    '                If strShowFlg = 0 Then
    '                    '確認メッセージを表示する
    '                    Call ComMessage.PFn_ShowMessageBox(Me.ActiveFormFeatureCode, ComMessage.CON_MESSAGE_ID30)

    '                    Me.PSb_SetCellFocus(rowIndex, codeKey)
    '                End If
    '            End If
    '        End If

    '        Me.EventManager.AllEventsEnabled = True

    '        If Not dtData Is Nothing Then
    '            dtData.Dispose()
    '            dtData = Nothing
    '        End If
    '    Catch ex As Exception

    '        Me.EventManager.AllEventsEnabled = True

    '        If Not dtData Is Nothing Then
    '            dtData.Dispose()
    '            dtData = Nothing
    '        End If

    '        Throw ex

    '    End Try
    'End Sub

    
    Public Sub CodeValidating(ByVal rowIndex As Integer, ByVal codeKey As String, ByVal nameKey As String)
        Try
            '画面の管理区分コードを取得する

            Dim strCode As String = UCUtility.PFn_Trim(Me.Rows(rowIndex).Cells(codeKey).Value)

            '空を判断する
            If Not strCode.Equals(String.Empty) Then
                Dim count As Integer = Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.ItemCount

                If count <= 0 Then
                    Me.EventManager.AllEventsEnabled = False

                    'コードを空をセットする

                    Me.Rows(rowIndex).Cells(codeKey).Value = DBNull.Value

                    '空行を選択する

                    Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.SelectedItemIndex = -1

                    'コンボボックス名は空をセットする
                    Me.Rows(rowIndex).Cells(nameKey).Value = String.Empty

                    Me.EventManager.AllEventsEnabled = True

                    Exit Sub
                End If

                'リスト項目をループする

                For i As Integer = 0 To count - 1
                    '画面の管理区分名コードを取得する
                    Dim strCodeTemp As String = UCUtility.PFn_Trim(Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.GetValue(i))

                    '同じ項目を判断する

                    If strCode.Equals(strCodeTemp) Then
                        Me.EventManager.AllEventsEnabled = False

                        '同じ項目を選択する

                        Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.SelectedItemIndex = i

                        'コンボボックス名をセットする
                        Me.Rows(rowIndex).Cells(nameKey).Value = strCodeTemp

                        Me.EventManager.AllEventsEnabled = True
                        Exit Sub
                    End If
                Next
            End If

            Me.EventManager.AllEventsEnabled = False

            'コードを空をセットする

            Me.Rows(rowIndex).Cells(codeKey).Value = DBNull.Value

            '空行を選択する

            Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.SelectedItemIndex = -1

            'コンボボックス名は空をセットする
            Me.Rows(rowIndex).Cells(nameKey).Value = String.Empty

            Me.EventManager.AllEventsEnabled = True
        Catch ex As Exception

            Me.EventManager.AllEventsEnabled = True

            Throw ex

        End Try
    End Sub

    ''' <summary>
    ''' 「CodeComboBox」名より、コードをセット
    ''' </summary>
    ''' <param name="rowIndex">行のIndex番号</param>
    ''' <param name="codeKey">コード列キー</param>
    ''' <param name="nameKey">名前列キー</param>
    ''' <remarks>「CodeComboBox」名より、コードをセット</remarks>
    Public Sub SetCodeComboBoxCode(ByVal rowIndex As Integer, ByVal codeKey As String, ByVal nameKey As String)

        Try

            Dim index As Integer = Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.SelectedItemIndex
            Dim strCode As String = UCUtility.PFn_Trim(Me.DisplayLayout.Bands(0).Columns(nameKey).ValueList.GetValue(index))

            Me.EventManager.AllEventsEnabled = False
            Me.Rows(rowIndex).Cells(codeKey).Value = strCode
            Me.EventManager.AllEventsEnabled = True

        Catch ex As Exception
            Me.EventManager.AllEventsEnabled = True
            Throw ex
        End Try

    End Sub

    ''' <summary>
    ''' Grid背景色を設定する
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PSb_SetCellBackColor()

        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim m As Integer
        Dim n As Integer

        For i = 0 To Me.DisplayLayout.Bands.Count - 1
            With Me.DisplayLayout.Bands(i).Layout
                Select Case i
                    Case 0
                        For j = 0 To .Rows.Count - 1
                            For k = 0 To .Rows(j).Cells.Count - 1
                                If .Rows(j).Cells(k).Activation = Activation.AllowEdit Then
                                    .Rows(j).Cells(k).Appearance.BackColor = Color.White
                                    .Rows(j).Cells(k).TabStop = DefaultableBoolean.True
                                ElseIf .Rows(j).Cells(k).Activation = Activation.ActivateOnly Then
                                    'If j Mod 2 = 0 Then
                                    '    .Rows(j).Cells(k).Appearance.BackColor = RowAppColor
                                    'Else
                                    '    .Rows(j).Cells(k).Appearance.BackColor = RowAltAppColor
                                    'End If
                                    .Rows(j).Cells(k).Appearance.BackColor = Nothing
                                    .Rows(j).Cells(k).TabStop = DefaultableBoolean.False
                                End If
                            Next k
                        Next j
                    Case 1
                        For j = 0 To .Rows.Count - 1
                            For k = 0 To .Rows(j).ChildBands(0).Rows.Count - 1
                                For n = 0 To .Rows(j).ChildBands(0).Rows(k).Cells.Count - 1
                                    If .Rows(j).ChildBands(0).Rows(k).Cells(n).Activation = Activation.AllowEdit Then
                                        .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = Color.White
                                        .Rows(j).ChildBands(0).Rows(k).Cells(n).TabStop = DefaultableBoolean.True
                                    ElseIf .Rows(j).ChildBands(0).Rows(k).Cells(n).Activation = Activation.ActivateOnly Then
                                        'If k Mod 2 = 0 Then
                                        '    .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = RowAppColor
                                        'Else
                                        '    .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = RowAltAppColor
                                        'End If
                                        .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = Nothing
                                        .Rows(j).ChildBands(0).Rows(k).Cells(n).TabStop = DefaultableBoolean.False
                                    End If
                                Next n
                            Next k
                        Next j
                    Case 2
                        For j = 0 To .Rows.Count - 1
                            For k = 0 To .Rows(j).ChildBands(0).Rows.Count - 1
                                For m = 0 To .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows.Count - 1
                                    For n = 0 To .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells.Count - 1
                                        If .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Activation = Activation.AllowEdit Then
                                            .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = Color.White
                                            .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).TabStop = DefaultableBoolean.True
                                        ElseIf .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Activation = Activation.ActivateOnly Then
                                            'If m Mod 2 = 0 Then
                                            '    .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = RowAppColor
                                            'Else
                                            '    .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = RowAltAppColor
                                            'End If
                                            .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = Nothing
                                            .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).TabStop = DefaultableBoolean.False
                                        End If
                                    Next n
                                Next m
                            Next k
                        Next j
                End Select
            End With
        Next

        Me.UpdateData()

    End Sub

    ''' <summary>
    ''' Grid背景色を設定する
    ''' </summary>
    ''' <param name="intBands">バグ</param>
    ''' <param name="ClrBcakColor">背景色</param>
    ''' <remarks></remarks>
    Public Sub PSb_SetCellBackColor(ByVal intBands As Integer, _
                                    ByVal ClrBcakColor As Drawing.Color)
        Dim j As Integer
        Dim k As Integer
        Dim m As Integer
        Dim n As Integer

        With Me.DisplayLayout.Bands(intBands).Layout
            Select Case intBands
                Case 0
                    For j = 0 To .Rows.Count - 1
                        For k = 0 To .Rows(j).Cells.Count - 1
                            If .Rows(j).Cells(k).Activation = Activation.AllowEdit Then
                                .Rows(j).Cells(k).Appearance.BackColor = Color.White
                                .Rows(j).Cells(k).TabStop = DefaultableBoolean.True
                            ElseIf .Rows(j).Cells(k).Activation = Activation.ActivateOnly Then
                                .Rows(j).Cells(k).Appearance.BackColor = ClrBcakColor
                                .Rows(j).Cells(k).TabStop = DefaultableBoolean.False
                            End If
                        Next k
                    Next j
                Case 1
                    For j = 0 To .Rows.Count - 1
                        For k = 0 To .Rows(j).ChildBands(0).Rows.Count - 1
                            For n = 0 To .Rows(j).ChildBands(0).Rows(k).Cells.Count - 1
                                If .Rows(j).ChildBands(0).Rows(k).Cells(n).Activation = Activation.AllowEdit Then
                                    .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = Color.White
                                    .Rows(j).ChildBands(0).Rows(k).Cells(n).TabStop = DefaultableBoolean.True
                                ElseIf .Rows(j).ChildBands(0).Rows(k).Cells(n).Activation = Activation.ActivateOnly Then
                                    .Rows(j).ChildBands(0).Rows(k).Cells(n).Appearance.BackColor = ClrBcakColor
                                    .Rows(j).ChildBands(0).Rows(k).Cells(n).TabStop = DefaultableBoolean.False
                                End If
                            Next n
                        Next k
                    Next j
                Case 2
                    For j = 0 To .Rows.Count - 1
                        For k = 0 To .Rows(j).ChildBands(0).Rows.Count - 1
                            For m = 0 To .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows.Count - 1
                                For n = 0 To .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells.Count - 1
                                    If .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Activation = Activation.AllowEdit Then
                                        .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = Color.White
                                        .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).TabStop = DefaultableBoolean.True
                                    ElseIf .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Activation = Activation.ActivateOnly Then
                                        .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).Appearance.BackColor = ClrBcakColor
                                        .Rows(j).ChildBands(0).Rows(k).ChildBands(0).Rows(m).Cells(n).TabStop = DefaultableBoolean.False
                                    End If
                                Next n
                            Next m
                        Next k
                    Next j
            End Select
        End With

    End Sub

#Region "私有関数"

    ''' <summary>
    ''' グリッドのフォーカスをセットする(新規行入力時用)
    ''' </summary>
    ''' <remarks>グリッドのフォーカスをセットする(新規行入力時用)</remarks>
    Private Sub EnterEditModeOnFirstCellInGrid()
        '有効行を判断する
        If Me.Rows.Count <= 0 Then
            Exit Sub
        End If

        '全て事件を終了する

        Me.EventManager.AllEventsEnabled = False

        ''当前行は新規行を判断する
        'If Not Me.ActiveRow.IsAddRow Then
        '    Me.EventManager.AllEventsEnabled = True
        '    Exit Sub
        'End If

        'プッカスをセットする
        Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)

        '当前セルの有効性を判断する
        If Not Me.ActiveCell Is Nothing AndAlso _
            Not Me.ActiveCell Is DBNull.Value AndAlso _
            Not Me.ActiveCell.Equals(String.Empty) Then
            If Me.ActiveCell.IsInEditMode Then
                'セル様式を判断する

                If Not Me.ActiveCell.Column.Style = ColumnStyle.CheckBox AndAlso _
                    Not Me.ActiveCell.Column.Style = ColumnStyle.Button AndAlso _
                    Not Me.ActiveCell.Column.Style = ColumnStyle.DropDownList AndAlso _
                    Not Me.ActiveCell.Column.Style = ColumnStyle.DropDown Then
                    If Not Me.ActiveCell.Style = ColumnStyle.CheckBox Then

                        '当前セルの文字の最後位置を移動する
                        Me.ActiveCell.SelStart = Me.ActiveCell.Text.Length
                    End If
                End If
            End If
        End If

        '全て事件を開始する

        Me.EventManager.AllEventsEnabled = True

    End Sub

    ''' <summary>
    ''' プッカスをセットする
    ''' </summary>
    ''' <remarks>プッカスをセットする</remarks>
    Private Sub SetEnterEditMode()
        Me.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode, False, False)
    End Sub

    ''' <summary>
    ''' 入力前0埋め
    ''' </summary>
    ''' <param name="strColumns"></param>
    ''' <param name="intBand"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SetInsertValue(ByVal strColumns() As String, ByVal intBand As Integer, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs)
        Dim strCell As String

        strCell = UCUtility.PFn_Trim(e.Cell.Text)

        For Each strColumn As String In strColumns

            If Not strColumn.Equals(String.Empty) Then

                If CInt(strColumn) = e.Cell.Column.Index Then

                    '入力前0埋め
                    If Not UCUtility.PFn_Trim(InsertValue).Equals(String.Empty) AndAlso _
                       Not strCell.Equals(String.Empty) Then

                        Me.EventManager.AllEventsEnabled = False

                        e.Cell.Value = strCell.PadLeft(Me.DisplayLayout.Bands(intBand).Columns(CInt(strColumn)).MaxLength, _
                                                           CChar(InsertValue))

                        Me.EventManager.AllEventsEnabled = True

                    End If

                End If

            End If

        Next
    End Sub

    Public Sub PSb_SummaryFooterCaption(ByVal lngCount As Long)

        Dim band As UltraGridBand = Me.DisplayLayout.Bands(0)
        Dim summary As SummarySettings
        ' Add a summary.
        'Dim summary As SummarySettings = band.Summaries.Add(SummaryType.Count, band.Columns("CustomerID"))
        If band.Summaries.Count = 0 Then
            summary = band.Summaries.Add(String.Empty)
        Else
            summary = band.Summaries.Item(0)
        End If

        ' Set the summary position to Left so that it shows up on the left of the
        ' summary footer area.
        summary.SummaryPosition = SummaryPosition.Left

        ' Set the format with which to format the calculated summary when displaying
        ' in the summary footer.
        'summary.DisplayFormat = "Record Count = {0:#####}"
        'summary.DisplayFormat = "Record Count =  " & lngCount
        summary.DisplayFormat = "計 : " & lngCount & "件"

        ' Set the appearance of the summary.
        summary.Lines = 1

        summary.Appearance.FontData.Name = "ＭＳ ゴシック"
        summary.Appearance.FontData.SizeInPoints = 10
        summary.Appearance.TextHAlign = HAlign.Left
        summary.Appearance.TextVAlign = VAlign.Middle
        summary.Appearance.ForeColor = Color.DarkBlue
        summary.Appearance.BackColor = Color.White

        summary.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed

        band.Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
        ' Set the border style of summaries to desired value.
        band.Override.BorderStyleSummaryValue = UIElementBorderStyle.None

        ' Set the appearance of summary footer and the footer caption.
        band.Override.SummaryFooterAppearance.BackColor = Color.White
        band.Override.SummaryFooterCaptionAppearance.BackColor = Color.White

    End Sub

#End Region

#End Region


End Class
