Imports System
Imports System.Xml
Imports System.Configuration
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports HRJS.Constant

''' <summary>
''' 配置クラス：Configuration
''' </summary>
''' <remarks>配置クラス</remarks>
''' <history>
''' 	[ ]	2013/01/04	Created
''' </history>
Public Class Configuration

#Region "変数"

#End Region

#Region " GetConfiguration"

    Public Shared Function GetConfiguration(ByVal strAppString As String, ByVal key As String) As String

        Dim document As XmlDocument
        Dim configFile As String
        Dim configFilePath As String
        Dim reader As AppSettingsReader = New AppSettingsReader

        configFile = reader.GetValue(strAppString, GetType(String)).ToString()

        configFilePath = AppDomain.CurrentDomain.BaseDirectory

        configFile = System.IO.Path.GetDirectoryName(configFilePath) + "\" + configFile

        document = New XmlDocument
        document.Load(configFile)

        Dim result As String = Nothing

        For Each node As XmlNode In document("configuration")("appSettings")
            If node.Attributes("key").Value = key Then
                result = node.Attributes("value").Value
            End If
        Next

        result = result & ";Application Name=" & System.AppDomain.CurrentDomain.GetAssemblies.GetValue(1).fullname
        result = result & ";Workstation ID=" & System.Environment.GetEnvironmentVariable("CLIENTNAME")

        Return result

    End Function

    ''' <summary>
    ''' Configの情報を戻る
    ''' </summary>
    ''' <param name="strConfigKey">Configのキー</param>
    ''' <returns>Configの値</returns>
    ''' <remarks>Configの情報を戻る</remarks>
    Public Shared Function PFn_GetConnectionInfo(ByVal strConfigKey As String) As String
        Try
            PFn_GetConnectionInfo = System.Configuration.ConfigurationManager. _
                                    ConnectionStrings(strConfigKey).ConnectionString
        Catch ex As Exception
            PFn_GetConnectionInfo = String.Empty
        End Try
    End Function

    ''' <summary>
    ''' Configの情報を取得する
    ''' </summary>
    ''' <param name="strConfigKey">Configのキー</param>
    ''' <returns>Configの情報</returns>
    ''' <remarks>Configの情報を取得する</remarks>
    Public Shared Function PFn_GetAppConfigValue(ByVal strConfigKey As String) As String
        Try
            '    PFn_GetAppConfigValue = System.Configuration.ConfigurationManager. _
            '                            AppSettings(strConfigKey).ToString()
            Return ""
        Catch ex As Exception
            'PFn_GetAppConfigValue = String.Empty
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' システムの情報を保存する
    ''' </summary>
    ''' <remarks>Configファイルからシステムの情報を保存する</remarks>
    Public Shared Sub PSb_SaveSystemInfo()

        System.Configuration.ConfigurationManager.RefreshSection("connectionStrings")
        System.Configuration.ConfigurationManager.RefreshSection("appSettings")

        'DB連絡の文字列を取得する
        ConfigInfo.DBConnectionString = PFn_GetConnectionInfo("DBConn") & gStrDBUserPass

        'DBアクセスの最大時間
        If Not PFn_GetAppConfigValue("DBTimeOut") = String.Empty Then
            ConfigInfo.DBTimeOut = CInt(PFn_GetAppConfigValue("DBTimeOut"))
        End If

        'DB接続失敗のエラーメッセージ
        ConfigInfo.DBConnectionError = PFn_GetAppConfigValue("DBConnError")

        'お知らせ更新処理。承認履歴に更新処理する
        ConfigInfo.LOGApproval = PFn_GetAppConfigValue("ApprovalLog")

        'ログフラグを取得する
        ConfigInfo.LOGSQLFlg = PFn_GetAppConfigValue("SqlLog")
        ConfigInfo.LOGExceptionFlg = PFn_GetAppConfigValue("ErrLog")
        ConfigInfo.LOGTransactionFlg = PFn_GetAppConfigValue("TranLog")

    End Sub

#End Region

End Class

