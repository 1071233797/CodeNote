Imports System.Text

Public Class Dal主画面
#Region "主画面"

#Region "UpdatePassWord"
    Public Function UpdatePassWordSQL(ByVal objM人员T As M人员T) As String

        Dim strSql As New StringBuilder(String.Empty)     'Sql文

        strSql.Append(" UPDATE " & vbCrLf)  'M担当
        strSql.Append("       M人员 " & vbCrLf)  'M担当
        strSql.Append(" SET " & vbCrLf)  'M担当

        '密码
        strSql.AppendFormat(" 密码 = " & Utility.PFn_ChangeQuotation(objM人员T.密码))

        ''更新者CD
        'strSql.AppendFormat(" ,更新人员CD = {0}" & vbCrLf, Utility.ChangeQuotation(gObjM_人员T.人员CD))

        ''更新日時
        'strSql.AppendFormat(" ,更新日時 = {0}" & vbCrLf, Utility.ChangeQuotation(objM人员T.更新日時))

        strSql.Append(" WHERE " & vbCrLf)
        strSql.AppendFormat("     人员CD = " & Utility.PFn_ChangeQuotation(objM人员T.人员编号))

        'SQLに戻る

        Return strSql.ToString

    End Function

#End Region

#Region "Check担当SQL"
    Public Function Check担当SQL(ByVal objM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        strSql.Append(" SELECT " & vbCrLf)

        strSql.Append("    人员编号," & vbCrLf)
        strSql.Append("    人员名," & vbCrLf)
        strSql.Append("    密码" & vbCrLf)

        strSql.Append(" FROM" & vbCrLf)
        strSql.Append("    M人员管理 " & vbCrLf)
        strSql.Append(" WHERE 1=1 " & vbCrLf)
        'strSql.Append("       削除日時 IS NULL" & vbCrLf)
        'strSql.AppendFormat(" AND  人员CD = {0}" & vbCrLf, Utility.ChangeQuotation(objM人员T.人员CD)) '担当CD
        'strSql.AppendFormat(" AND 密码 = {0}" & vbCrLf, Utility.ChangeQuotation(objM人员T.密码))
        strSql.AppendFormat(" AND  人员编号 = " & Utility.PFn_ChangeQuotation(objM人员T.人员编号)) '担当CD
        strSql.AppendFormat(" AND 密码 = " & Utility.PFn_ChangeQuotation(objM人员T.密码))

        Return strSql.ToString

    End Function
#End Region

#Region "Get担当InfoSQL"
    ''' <summary>
    ''' SQL:Get担当Info
    ''' </summary>
    ''' <param name="objM人员T"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get担当InfoSQL(ByVal objM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Dim objM担当T As M人员T = Nothing

        strSql.Append(" SELECT " & vbCrLf)
        strSql.Append(" 	人员编号," & vbCrLf)
        strSql.Append(" 	人员名," & vbCrLf)
        strSql.Append(" 	密码," & vbCrLf)
        strSql.Append(" 	部门," & vbCrLf)
        strSql.Append(" 	电话号码" & vbCrLf)

        strSql.Append(" FROM " & vbCrLf)
        strSql.Append("     M人员管理" & vbCrLf)

        strSql.Append(" WHERE 1=1 " & vbCrLf)
        strSql.AppendFormat(" AND 人员编号 =" & Utility.PFn_ChangeQuotation(objM人员T.人员编号))

        Return strSql.ToString

    End Function
#End Region

#Region "Get担当権限SQL"

    Public Function Get担当権限SQL(ByVal objM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        strSql.Append(" SELECT " & vbCrLf)
        strSql.Append(" 	人员编号," & vbCrLf)
        strSql.Append(" 	菜单区分" & vbCrLf)

        strSql.Append(" FROM " & vbCrLf)
        strSql.Append("     M人员权限" & vbCrLf)
        strSql.Append(" WHERE " & vbCrLf)
        strSql.AppendFormat("     人员编号=" & Utility.PFn_ChangeQuotation(objM人员T.人员编号))

        '結果に戻る

        Return strSql.ToString

    End Function

#End Region

#Region "InsertL登陆记录SQL"
    'Public Function InsertL登陆记录SQL(ByVal objM人员T As M人员T) As String

    '    Dim strSql As New StringBuilder(String.Empty)     'Sql文


    '    strSql.Append(" INSERT INTO T登陆注销" & vbCrLf)
    '    strSql.Append("  (" & vbCrLf)
    '    strSql.Append("     人员CD," & vbCrLf)
    '    strSql.Append("     登陆注销区分," & vbCrLf)
    '    strSql.Append("     登陆注销日時" & vbCrLf)
    '    strSql.Append("  )" & vbCrLf)
    '    strSql.Append("  VALUES" & vbCrLf)
    '    strSql.Append("  (" & vbCrLf)
    '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.utility.ChangeQuotation(objM人员T.人员CD))
    '    strSql.AppendFormat(" {0}," & vbCrLf, Utility.utility.ChangeQuotation(objM人员T.z_登陆注销区分))
    '    strSql.AppendFormat(" '{0}'" & vbCrLf, objM人员T.z_登陆注销日時)
    '    strSql.Append(")" & vbCrLf)

    '    'SQLに戻る

    '    Return strSql.ToString

    'End Function
#End Region

#Region "検索SQL"

    ''' <summary>
    ''' 検索SQL
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetGridDataSQL(ByVal objM人员T As M人员T) As String

        Dim strSQL As StringBuilder

        strSQL = New StringBuilder

        strSQL.Append(" SELECT " & vbCrLf)
        strSQL.Append(" 	NM承認申請対象区分.名称 AS 申請対象," & vbCrLf)
        strSQL.Append(" 	--登陆．人员CD = M承認记录．承認人员CD　の場合「主」、以外「代理」" & vbCrLf)
        strSQL.AppendFormat(" 	CASE WHEN T承認记录.承認人员CD='{0}' THEN " & vbCrLf, objM人员T.人员编号)
        strSQL.Append(" 	          '主'" & vbCrLf)
        strSQL.Append(" 		 ELSE " & vbCrLf)
        strSQL.Append(" 		     '代理'" & vbCrLf)
        strSQL.Append(" 		 END AS 承認対象," & vbCrLf)
        strSQL.Append(" 	T承認记录.更新日時 AS 申請日," & vbCrLf)
        strSQL.Append(" 	T承認记录.伝票编号 AS 伝票编号," & vbCrLf)
        strSQL.Append(" 	T承認记录.更新人员CD AS CD," & vbCrLf)
        strSQL.Append(" 	VM人员.人员略名 AS 申請人员名," & vbCrLf)
        strSQL.Append(" 	T承認记录.承認コメント AS 依頼コメント" & vbCrLf)
        strSQL.Append(" FROM " & vbCrLf)
        strSQL.Append(" 	T承認记录 " & vbCrLf)
        strSQL.Append(" LEFT JOIN " & vbCrLf)
        strSQL.Append("     T承認记录 V元承認记录 ON T承認记录.承認记录编号 = V元承認记录.元承認记录编号" & vbCrLf)
        strSQL.Append(" LEFT JOIN " & vbCrLf)
        strSQL.Append("     NM承認申請対象区分 ON NM承認申請対象区分.区分=T承認记录.申請対象区分" & vbCrLf)
        strSQL.Append(" LEFT JOIN " & vbCrLf)
        strSQL.Append("     VM人员 ON VM人员.人员CD=T承認记录.更新人员CD" & vbCrLf)
        strSQL.Append(" WHERE " & vbCrLf)
        strSQL.Append("     V元承認记录.承認记录编号 IS NULL " & vbCrLf)
        ' strSQL.Append(" 	AND T承認记录.元承認记录编号 IS NULL " & vbCrLf)
        strSQL.Append(" 	AND T承認记录.申請有効フラグ = '1'" & vbCrLf)
        strSQL.Append(" 	AND T承認记录.承認区分='1'" & vbCrLf)

        '・代理含むチェックボックス			
        '	チェックON　の場合		
        '		 mSR1．承認人员CD = 登陆．人员CD OR mSR1．代理承認人员CD = 登陆．人员CD	
        '	チェックOFF　の場合		
        '		 mSR1．承認人员CD = 登陆．人员CD	
        strSQL.AppendFormat(" AND T承認记录.承認人员CD='{0}'", objM人员T.人员编号)

        strSQL.Append(" ORDER BY T承認记录.承認记录编号")

        Return strSQL.ToString

    End Function

#End Region

#End Region
End Class
