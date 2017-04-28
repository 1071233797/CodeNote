Imports System.Drawing

Public Class ComVariable

#Region "定数"
    '記号
    Public Const CON_BRACKETS_LEFT As String = "("                  '左カッコ
    Public Const CON_BRACKETS_RIGHT As String = ")"                 '右カッコ
    Public Const CON_ALL_SPACE As String = "　"                     '全角空白
    Public Const CON_HALF_SPACE As String = " "                     '半角空白

    '灰色
    Public Shared Color_Control As Drawing.Color = Drawing.Color.FromArgb(212, 208, 200)

    '薄グレー
    Public Shared Color_Hui As Drawing.Color = Drawing.Color.FromArgb(128, 128, 128)

    '水色
    Public Shared Color_Blue As Drawing.Color = Drawing.Color.FromArgb(192, 255, 255)

    'ディープブルー
    Public Shared Color_DeepBlue As Drawing.Color = Drawing.Color.FromArgb(128, 128, 255)

    '黄色
    Public Shared Color_LightYellow As Drawing.Color = Drawing.Color.FromArgb(254, 251, 231)

    'メニューのボタン色
    Public Shared Color_Menu_Button As Drawing.Color = Drawing.Color.FromArgb(39, 41, 175)

    '深灰色
    Public Shared Color_Gray As Drawing.Color = Drawing.Color.FromArgb(132, 130, 132)

    '赤色
    Public Shared Color_Red As Drawing.Color = Drawing.Color.Red

    '黒色
    Public Shared Color_Black As Drawing.Color = Drawing.Color.Black

    '青色
    Public Shared Color_BlueColor As Drawing.Color = Drawing.Color.Blue

    'カレンダ(稼)
    Public Shared Color_Calendar_Operation As Drawing.Color = Drawing.Color.FromArgb(153, 204, 255)

    'カレンダ(休)
    Public Shared Color_Gray_Rest As Drawing.Color = Drawing.Color.FromArgb(255, 153, 204)

    '緑色
    Public Shared Color_LightGreen As Drawing.Color = Drawing.Color.LightGreen

    '青色
    Public Shared Color_LightSteelBlue As Drawing.Color = Drawing.Color.LightSteelBlue

    '灰色
    Public Shared Color_Gainsboro As Drawing.Color = Drawing.Color.Gainsboro

    '浅い灰色
    Public Shared Color_QianHui As Drawing.Color = Drawing.Color.FromArgb(224, 224, 224)

    'ローズ色
    Public Shared Color_Rose As Drawing.Color = Drawing.Color.FromArgb(255, 192, 255)

    'ピンク
    Public Shared Color_Pink As Drawing.Color = Color.Pink

    Public Shared Color_PapayaWhip As Drawing.Color = Color.PapayaWhip

    'Gridについて
    Public Const CON_ISCOMBOBOXCODE_FLG As String = "COMBOBOXCODE"   'コンボボックスフラグ(列TAG)
    Public Const CON_ISREADONLYROW_FLG As String = "READONLYROW"     '照会行フラグ(行TAG)
    Public Const CON_ISCODEIME_FLG As String = "CODEIME"             'コードのモードフラグ(列TAG)
    Public Const CON_ISCODESEARCH_FLG As String = "CODESEARCH"       'コードのモードフラグ(列TAG)
    Public Const CON_ISALPHANUMERIME_FLG As String = "ALPHANUMERIME" 'コードのモードフラグ(列TAG)
    Public Const CON_ISCODESPACEIME_FLG As String = "CODESPACEIME"   'コードのモードフラグ(列TAG)
    Public Const CON_ISCODE_ALPHANUMERIME_FLG As String = "CODE_ALPHANUMERIME" 'コードのモードフラグ(列TAG) 入庫_商品コード

#End Region

#Region "変数"
    'フォーム閉じるメッセージのフラグ
    Public Shared FormCloseMessageFlg As Boolean = True
 
    Public Shared CON_FONT As New Drawing.Font("ＭＳ ゴシック", 9)
    Public Shared CON_FONT13 As New Drawing.Font("ＭＳ ゴシック", 13)
#End Region

#Region "正規表現を使った文字列"
    '数字(0-100)
    Public Const CON_REGEX_NUMBER_0_100 As String = "^(\d{1,2}|100)$"

    '整数(0-9)
    Public Const CON_REGEX_NUMBER As String = "^[0-9]*$"

    '整数(0-9)と半角空白
    Public Const CON_REGEX_NUMBERBLANK As String = "^[0-9\-\x20]*$"

    '英文数字(A-Z,a-z,0-9)
    Public Const CON_REGEX_ALPHANUMERIC As String = "^[A-Z,a-z,0-9]*$"

    '電話番号(0-9)と(-)
    Public Const CON_REGEX_TEL As String = "^[-0-9]*$"

    '英文数字(A-Z,a-z,0-9)
    Public Const CON_REGEX_NUMERIC_TEL As String = "^[A-Z,a-z,-0-9,0-9]*$"
#End Region

End Class
