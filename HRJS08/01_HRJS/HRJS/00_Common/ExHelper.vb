#Region "ExHelper説明"

'--------------------------------------------------------------------------------
'概要

'   異常を処理

'作成
'    [2013-01-04]
'--------------------------------------------------------------------------------

#End Region

Imports HRJS.Constant

Public Class ExHelper

    '--------------------------------------------------------------------------------
    '概要

    '   DBConnectionを処理

    '作成   
    '    [2007-06-18]
    'パラメタ説明

    '   ex:(In) ->異常
    '戻り値
    '   なし

    '--------------------------------------------------------------------------------
    Public Shared Sub ProcessDBHelper(ByRef obj As DbHelper)

        If Not obj Is Nothing Then
            If Not obj.Trans Is Nothing Then
                obj.PSb_Rollback()
            End If
            If Not obj.Conn Is Nothing Then
                obj.PSb_CloseDB()
            End If
        End If

    End Sub

    ''' <summary>
    ''' 異常処理
    ''' </summary>
    ''' <param name="ex">異常の対象</param>
    ''' <remarks></remarks>
    Public Overloads Shared Sub ProcessEx(ByVal ex As Exception)

        'LOGファイルを出力する
        Utility.PSb_WriteLOGFile(3, ex.GetBaseException.ToString())

        'DB連絡異常

        If Not ex.InnerException Is Nothing AndAlso ex.InnerException.Message = CON_OPENDB_ERROR Then
            MsgBox(ConfigInfo.DBConnectionError & vbCrLf & vbCrLf & "Configファイルの内容を確認してください", MsgBoxStyle.Critical, "データベース接続エラー(" & ENU_MSGID.ErrorDbOpen & ")")
            Exit Sub
        End If

        ShowMessage(ex)

    End Sub

    ''' <summary>
    ''' 異常処理
    ''' </summary>
    ''' <param name="ex">異常の対象</param>
    ''' <param name="strFeature">タイトル文字</param>
    ''' <remarks></remarks>
    Public Overloads Shared Sub ProcessEx(ByVal ex As Exception, ByVal strFeature As String)

        If strFeature = String.Empty OrElse strFeature Is Nothing Then

            ProcessEx(ex)

            Exit Sub
        End If

        'LOGファイルを出力する
        Utility.PSb_WriteLOGFile(3, ex.GetBaseException.ToString())

        'DB連絡異常
        If Not ex.InnerException Is Nothing AndAlso ex.InnerException.Message = CON_OPENDB_ERROR Then
            MsgBox(ConfigInfo.DBConnectionError & vbCrLf & vbCrLf & "Configファイルの内容を確認してください", MsgBoxStyle.Critical, "データベース接続エラー(" & ENU_MSGID.ErrorDbOpen & ")")
            Exit Sub
        End If

        ShowMessage(ex, strFeature)

    End Sub

    ''' <summary>
    ''' 異常表示
    ''' </summary>
    ''' <param name="ex">異常の対象</param>
    ''' <remarks></remarks>
    Private Overloads Shared Sub ShowMessage(ByVal ex As Exception)


        Dim strLog As String

        strLog = ex.GetBaseException.ToString

        'If Not ex.InnerException Is Nothing Then
        '    Dim sEx As Exception
        '    sEx = ex.InnerException

        '    Do
        '        strLog = strLog + vbCrLf + sEx.Message
        '        sEx = sEx.InnerException
        '    Loop Until sEx Is Nothing
        'End If

        MsgBox("例外エラーが発生しました。" & vbCrLf & "画面のハードコピーを保存しシステム管理者に連絡してください。" & vbCrLf & vbCrLf & strLog, vbCritical, "(" & ENU_MSGID.MSGID999 & ")")

    End Sub

    ''' <summary>
    ''' 異常表示
    ''' </summary>
    ''' <param name="ex">異常の対象</param>
    ''' <param name="strFeature">タイトル文字</param>
    ''' <remarks></remarks>
    Private Overloads Shared Sub ShowMessage(ByVal ex As Exception, ByVal strFeature As String)

        Dim strLog As String

        strLog = ex.Message

        If Not ex.InnerException Is Nothing Then
            Dim sEx As Exception
            sEx = ex.InnerException

            Do
                strLog = strLog + vbCrLf + sEx.Message
                sEx = sEx.InnerException
            Loop Until sEx Is Nothing
        End If

        MsgBox("例外エラーが発生しました。" & vbCrLf & "画面のハードコピーを保存しシステム管理者に連絡してください。" _
               & vbCrLf & vbCrLf & strLog, vbCritical, strFeature.TrimEnd & "(" & ENU_MSGID.MSGID999 & ")")

    End Sub

End Class
