Imports HRJS.Constant

''' <summary>
''' DB変数クラス：基類
''' </summary>
''' <remarks>DB変数クラス</remarks>
''' <history>
''' 	[ ]	2013/12/26	Created
''' </history>
Public Class BaseDBT

    Private int制限件数 As Integer = -1                 '制限件数           
    Private strフリーワード As String

    '------------------------------------------------------------------------------------
    ' 概要
    '  制限件数を設定する
    ' 備考
    '  なし
    '------------------------------------------------------------------------------------
    Public Overridable Property 制限件数() As Integer
        Get
            Return int制限件数
        End Get
        Set(ByVal Value As Integer)
            int制限件数 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    ' 概要
    '  フリーワードを設定する
    ' 備考
    '  なし
    '------------------------------------------------------------------------------------
    Public Overridable Property フリーワード() As String
        Get
            Return strフリーワード
        End Get
        Set(ByVal Value As String)
            strフリーワード = Value
        End Set
    End Property

End Class
