Imports System.Text
Imports System.Data.SqlClient
Imports System.Reflection
Imports HRJS.Utility
Imports HRJS.Constant

''' <summary>
''' 業務共通クラス
''' </summary>
''' <remarks>共通業務クラス</remarks>
''' <history>
''' [ ] 
''' </history>
Public Class ComBusiness

#Region " 採番処理 "

    ' ''' <summary>
    ' ''' 採番処理
    ' ''' </summary>
    ' ''' <param name="objDbCon">DB</param>
    ' ''' <param name="strIN_発番コード">発番コード</param>
    ' ''' <param name="strIN_日付">日付</param>
    ' ''' <param name="strIN_営業所コード">営業所コード</param>
    ' ''' <param name="strIN_課コード">課コード</param>
    ' ''' <param name="strIN_営業所記号">営業所記号</param>
    ' ''' <param name="strIN_西暦">西暦</param>
    ' ''' <returns>採番番号</returns>
    ' ''' <remarks> Revised</remarks>
    'Public Shared Function PFn_pro_get採番処理(ByVal objDbCon As DbHelper, _
    '                                           ByVal strIN_発番コード As String, _
    '                                           Optional ByVal strIN_日付 As String = "", _
    '                                           Optional ByVal strIN_営業所コード As String = "0", _
    '                                           Optional ByVal strIN_課コード As String = "0", _
    '                                           Optional ByVal strIN_営業所記号 As String = "", _
    '                                           Optional ByVal strIN_西暦 As String = "")

    '    Dim SqlParameterObject(6) As SqlParameter
    '    Dim str採番 As String = String.Empty

    '    SqlParameterObject(0) = New SqlParameter("@IN_発番コード", strIN_発番コード)
    '    SqlParameterObject(1) = New SqlParameter("@IN_日付", strIN_日付)
    '    SqlParameterObject(2) = New SqlParameter("@IN_営業所コード", strIN_営業所コード)
    '    SqlParameterObject(3) = New SqlParameter("@IN_営業所記号", strIN_営業所記号)
    '    SqlParameterObject(4) = New SqlParameter("@IN_課コード", strIN_課コード)
    '    SqlParameterObject(5) = New SqlParameter("@IN_西暦", strIN_西暦)
    '    SqlParameterObject(6) = New SqlParameter()
    '    SqlParameterObject(6).ParameterName = "@OUT_採番コード"
    '    SqlParameterObject(6).DbType = SqlDbType.VarChar
    '    SqlParameterObject(6).Size = 500
    '    SqlParameterObject(6).Direction = ParameterDirection.Output

    '    str採番 = objDbCon.ExcuteProcedures("dbo.pro_get採番処理", SqlParameterObject, "@OUT_採番コード")

    '    If str採番.Equals("-1") Then
    '        '採番名が最大番号を超えました。システム管理者に連絡してください。
    '        CommonMsg.showMsg("採番処理", Constant.ENU_MSGID.MSGID998, _
    '                                    PFn_GetNameByCd("採番名", "WHERE 発番コード = " & PFn_ChangeQuotation(strIN_発番コード) & "", "M_発番"))
    '        Return ""
    '    Else
    '        Return str採番
    '    End If

    'End Function

    Public Shared Function PFn_pro_get自動採番(ByVal objDbCon As DbHelper, _
                                               ByVal int採番区分 As Integer)

        Dim sqlParameterObject(2) As SqlParameter
        Dim str伝票番号 As String = String.Empty

        sqlParameterObject(0) = New SqlParameter("@IN_採番区分", int採番区分)
        sqlParameterObject(1) = New SqlParameter("@IN_担当者CD", gObjM_人员T.人员编号)
        sqlParameterObject(2) = New SqlParameter()
        sqlParameterObject(2).ParameterName = "@OUT_採番コード"
        'sqlParameterObject(2).DbType = SqlDbType.VarChar
        sqlParameterObject(2).Size = 500
        sqlParameterObject(2).Direction = ParameterDirection.Output

        str伝票番号 = objDbCon.PFn_ExcuteProcedures("DBO.PRO_GET_NO", sqlParameterObject, "@OUT_採番コード")

        If str伝票番号.Equals("-1") Then
            '※M_採番.最大桁数を超えた場合エラーとし処理しない
            CommonMsg.PFn_ShowMsg("採番", Constant.ENU_MSGID.MSGID14, "伝票番号の採番", "最大桁数を超えた", "伝票番号の採番が")
            str伝票番号 = String.Empty
        End If

        Return str伝票番号

    End Function

    'Public Shared Function PFn_pro_get採番(ByVal objDbCon As DbHelper, _
    '                                       ByVal str採番コード As String, _

    '                                       ByVal str受注番号 As String)

    '    Dim sqlParameterObject(2) As SqlParameter
    '    Dim str伝票番号 As String = String.Empty

    '    sqlParameterObject(0) = New SqlParameter("@IN_採番コード", str採番コード)
    '    sqlParameterObject(1) = New SqlParameter("@IN_伝票番号", str受注番号)
    '    sqlParameterObject(2) = New SqlParameter()
    '    sqlParameterObject(2).ParameterName = "@OUT_伝票番号"
    '    sqlParameterObject(2).Size = 500
    '    sqlParameterObject(2).Direction = ParameterDirection.Output

    '    str伝票番号 = objDbCon.PFn_ExcuteProcedures("DBO.PRO_GET採番", sqlParameterObject, "@OUT_伝票番号")

    '    If str伝票番号.Equals("-1") Then
    '        str伝票番号 = String.Empty
    '    End If

    '    Return str伝票番号

    'End Function

#End Region

#Region " 消費税 "

    ''' <summary>
    ''' 消費税を取得
    ''' </summary>
    ''' <param name="intIN_内外区分">引数１(IN)：内外区分(0：内税、1：外税)</param>
    ''' <param name="datIN_基準日">引数２(IN)：基準日</param>
    ''' <param name="dblIN_金額">引数３(IN)：金額</param>
    ''' <param name="intIN_丸め区分">引数４(IN)：丸め区分(VK消費税端数区分)</param>
    ''' <param name="dblOUT_金額">引数５(OUT)：金額</param>
    ''' <param name="dblOUT_消費税額">引数６(OUT)：消費税額</param>
    ''' <param name="objDbCon">DB</param>
    ''' <remarks>2014/05/19 李濤 Created</remarks>
    Public Shared Sub PSB_GET消費税(ByVal intIN_内外区分 As Integer, _
                                    ByVal datIN_基準日 As Date, _
                                    ByVal dblIN_金額 As Double, _
                                    ByVal intIN_丸め区分 As Integer, _
                                    ByRef dblOUT_金額 As Double, _
                                    ByRef dblOUT_消費税額 As Double, _
                                    Optional ByVal objDbCon As DbHelper = Nothing)

        Dim SqlParameterObject(5) As SqlParameter
        Dim str採番 As String = String.Empty

        SqlParameterObject(0) = New SqlParameter("@IN_内外区分", intIN_内外区分)
        SqlParameterObject(1) = New SqlParameter("@IN_基準日", datIN_基準日)
        SqlParameterObject(2) = New SqlParameter("@IN_金額", dblIN_金額)
        SqlParameterObject(3) = New SqlParameter("@IN_丸め区分", intIN_丸め区分)
        SqlParameterObject(4) = New SqlParameter("@OUT_金額", dblOUT_金額)
        SqlParameterObject(4).DbType = DbType.Double
        SqlParameterObject(4).Direction = ParameterDirection.Output
        SqlParameterObject(5) = New SqlParameter("@OUT_消費税額", dblOUT_消費税額)
        SqlParameterObject(5).DbType = DbType.Double
        SqlParameterObject(5).Direction = ParameterDirection.Output

        If objDbCon Is Nothing Then
            objDbCon = New DbHelper
            objDbCon.PFn_ExcuteProcedures("DBO.PRO_GET消費税", SqlParameterObject)
            objDbCon.PSb_CloseDB()
        Else
            objDbCon.PFn_ExcuteProcedures("DBO.PRO_GET消費税", SqlParameterObject)
        End If

        dblOUT_金額 = PFn_NullToZero(SqlParameterObject(4).Value)
        dblOUT_消費税額 = PFn_NullToZero(SqlParameterObject(5).Value)

    End Sub

#End Region

#Region "金額端数"

    Public Shared Function PFn_金額丸め(ByVal 金額種類 As Integer, ByVal 丸め前の金額 As Double, Optional ByVal 取引先CD As String = "") As Double
        Dim d丸め後の金額 As Double
        Select Case 金額種類
            Case Constant.Enum_金額種類.受注金額, Constant.Enum_金額種類.仕入金額, Constant.Enum_金額種類.売上金額, Constant.Enum_金額種類.発注金額
                Dim VM取引先 As DataTable = New DataTable
                VM取引先 = Utility.PFn_GetTableByWhere("*", "where 取引先コード= " & Utility.PFn_ChangeQuotation(取引先CD), "VM取引先")
                If VM取引先.Rows.Count > 0 Then
                    Select Case VM取引先.Rows(0)("金額端数区分").ToString
                        Case Constant.Enum_金額端数区分.切り上げ
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.切り上げ, 0)
                        Case Constant.Enum_金額端数区分.切り捨て
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.切り捨て, 0)
                        Case Constant.Enum_金額端数区分.四捨五入
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.四捨五入, 0)
                    End Select
                End If

            Case Constant.Enum_金額種類.その他金額
                Dim m基本 As DataTable = New DataTable
                m基本 = Utility.PFn_GetTableByWhere("top 1 * ", "where 1=1", "M_基本")
                If m基本.Rows.Count > 0 Then
                    Select Case m基本.Rows(0)("金額端数区分").ToString
                        Case Constant.Enum_金額端数区分.切り上げ
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.切り上げ, 0)
                        Case Constant.Enum_金額端数区分.切り捨て
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.切り捨て, 0)
                        Case Constant.Enum_金額端数区分.四捨五入
                            d丸め後の金額 = Utility.PFn_Round(丸め前の金額, Constant.Enum_金額端数区分.四捨五入, 0)
                    End Select
                End If
        End Select
        Return d丸め後の金額
    End Function
#End Region

#Region "コード検索用SQL文"

    ''' <summary>
    ''' 担当者のSQL文を戻る
    ''' </summary>
    ''' <returns>担当者のSQL文</returns>
    ''' <remarks>担当者のSQL文を戻る</remarks>
    Private Shared Function Fn_Get担当者SQL() As StringBuilder

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append("      担当者略名, " & vbCrLf)
        strSQL.Append("      担当者名 " & vbCrLf)
        strSQL.Append(" FROM M担当者  " & vbCrLf)
        strSQL.Append(" WHERE 担当者CD = @CODE " & vbCrLf)
        strSQL.Append(" AND 削除日時 IS NULL " & vbCrLf)

        Return strSQL
    End Function

    ''' <summary>
    ''' 部門事業所のSQL文を戻る
    ''' </summary>
    ''' <returns>部門事業所のSQL文</returns>
    ''' <remarks>部門事業所のSQL文を戻る</remarks>
    Private Shared Function Fn_Get部門事業所SQL() As StringBuilder

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append("       部門事業所略名," & vbCrLf)
        strSQL.Append("       部門事業所名  " & vbCrLf)
        strSQL.Append(" FROM  " & vbCrLf)
        strSQL.Append("     M部門事業所  " & vbCrLf)
        strSQL.Append(" WHERE 部門事業所区分 = @CODE1 " & vbCrLf)
        strSQL.Append(" AND 部門事業所CD = @CODE2 " & vbCrLf)
        strSQL.Append(" AND 削除日時 IS NULL " & vbCrLf)

        Return strSQL
    End Function

    ''' <summary>
    ''' 倉庫のSQL文を戻る
    ''' </summary>
    ''' <returns>倉庫のSQL文</returns>
    ''' <remarks>倉庫のSQL文を戻る</remarks>
    Private Shared Function Fn_Get倉庫SQL() As StringBuilder

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append("       倉庫略名," & vbCrLf)
        strSQL.Append("       倉庫名  " & vbCrLf)
        strSQL.Append(" FROM  " & vbCrLf)
        strSQL.Append("     M倉庫  " & vbCrLf)
        strSQL.Append(" WHERE 倉庫区分 = @CODE1 " & vbCrLf)
        strSQL.Append(" AND 倉庫CD = @CODE2 " & vbCrLf)
        strSQL.Append(" AND 削除日時 IS NULL " & vbCrLf)

        Return strSQL
    End Function

    ''' <summary>
    ''' 取引先のSQL文を戻る
    ''' </summary>
    ''' <returns>取引先のSQL文</returns>
    ''' <remarks>取引先のSQL文を戻る</remarks>
    Private Shared Function Fn_Get取引先SQL() As StringBuilder

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append("       取引先略名," & vbCrLf)
        strSQL.Append("       取引先名,  " & vbCrLf)
        strSQL.Append("       諸口区分  " & vbCrLf)
        strSQL.Append(" FROM  " & vbCrLf)
        strSQL.Append("     M取引先  " & vbCrLf)
        strSQL.Append(" WHERE 取引先種類区分 = @CODE1 " & vbCrLf)
        strSQL.Append(" AND 取引先CD = @CODE2 " & vbCrLf)
        strSQL.Append(" AND 削除日時 IS NULL " & vbCrLf)

        Return strSQL
    End Function

    ''' <summary>
    ''' 商品のSQL文を戻る
    ''' </summary>
    ''' <returns>商品のSQL文</returns>
    ''' <remarks>商品のSQL文を戻る</remarks>
    Private Shared Function Fn_Get商品SQL() As StringBuilder

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append("       商品名 AS 商品略名," & vbCrLf)
        strSQL.Append("       商品名  " & vbCrLf)
        strSQL.Append(" FROM  " & vbCrLf)
        strSQL.Append("     VM商品  " & vbCrLf)
        strSQL.Append(" WHERE " & vbCrLf)
        strSQL.Append("    商品CD = @CODE " & vbCrLf)
        strSQL.Append(" AND 削除日時 IS NULL " & vbCrLf)

        Return strSQL
    End Function

#End Region

#Region "PFn_GetDataFromCode"
   
    Public Shared Function PFn_GetDataFromCode(ByVal strCode As String, _
                                        ByVal intSQLCode As Integer, _
                                        Optional ByVal hstPara As Hashtable = Nothing) As DataTable
        If intSQLCode < 0 Then
            PFn_GetDataFromCode = Nothing
            Exit Function
        End If

        'SQL文を作成する
        Dim strSQL As StringBuilder = Nothing

        Select Case intSQLCode
            Case 0      '担当者のSQL文を取得する
                strSQL = Fn_Get担当者SQL()
            Case 1     'M部門事業所のSQL文を取得する
                strSQL = Fn_Get部門事業所SQL()
            Case 2     'M倉庫のSQL文を取得する
                strSQL = Fn_Get倉庫SQL()
            Case 3     'M取引先のSQL文を取得する
                strSQL = Fn_Get取引先SQL()
            Case 4     'M商品のSQL文を取得する
                strSQL = Fn_Get商品SQL()
        End Select

        '引数を変換する
        If hstPara Is Nothing Then
            hstPara = New Hashtable
            hstPara.Add("CODE", strCode)
        End If

        'SQL文を実行する
        PFn_GetDataFromCode = DbHelper.PFn_Sh_SelectDB(strSQL, hstPara)
    End Function
#End Region

End Class