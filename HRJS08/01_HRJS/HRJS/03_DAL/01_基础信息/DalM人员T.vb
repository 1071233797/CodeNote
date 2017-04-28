Imports System.Text

Public Class DalM人员T


#Region "IsExists"

    Public Function IsExists(ByVal str人员编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   M人员管理 " & vbCrLf)
            strSql.Append("WHERE  人员编号 = " & Utility.PFn_ChangeQuotation(str人员编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M人员管理")         'M人员

            strSql.Append(" (人员编号")          '人员编号
            strSql.Append(" ,人员名")           '人员名
            strSql.Append(" ,密码")          '密码
            strSql.Append(" ,部门")         '部门
            strSql.Append(" ,在职状态")           '在职状态
            strSql.Append(" ,电话号码")           '电话号码
            strSql.Append(" ,入职时间")           '入职时间

            strSql.Append(" ,性别")          '密码
            strSql.Append(" ,职务")         '部门
            strSql.Append(" ,邮箱")           '在职状态
            strSql.Append(" ,办公电话")           '电话号码
            strSql.Append(" ,工种")           '入职时间

            strSql.Append(" ,登录者" & vbCrLf)
            strSql.Append(" ,登录日期" & vbCrLf)
            strSql.Append(")")

            strSql.Append(" VALUES ")

            '人员编号
            strSql.Append(" (" & Utility.PFn_ChangeQuotation(clsM人员T.人员编号) & vbCrLf)

            '人员名
            strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.人员名) & vbCrLf)

            '密码
            strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.密码) & vbCrLf)

            '部门
            If clsM人员T.部门 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.部门) & vbCrLf)
            End If

            '在职状态
            If clsM人员T.在职状态 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.在职状态) & vbCrLf)
            End If

            '电话号码
            If clsM人员T.电话号码 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.电话号码) & vbCrLf)
            End If

            '入职时间
            'If clsM人员T.入职时间 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.入职时间) & "')")
            'End If
            If clsM人员T.入职时间 = "1900/01/01 0:00:00" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append(" ," & Utility.PFn_ChangeQuotation(clsM人员T.入职时间) & vbCrLf)
            End If

            '性别
            If clsM人员T.性别 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.性别) & vbCrLf)
            End If

            '职务
            If clsM人员T.职务 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.职务) & vbCrLf)
            End If

            '邮箱
            If clsM人员T.邮箱 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.邮箱) & vbCrLf)
            End If

            '办公电话
            If clsM人员T.办公电话 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.办公电话) & vbCrLf)
            End If

            '工种
            If clsM人员T.工种 = "" Then
                strSql.Append(" ,NULL ")
            Else
                strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员T.工种) & vbCrLf)
            End If

            strSql.AppendFormat(" ,{0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM人员T.登录者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(clsM人员T.登录日期))

            strSql.Append("  )")

            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE M人员管理 ") 'M人员
            strSql.Append(" SET ")

            '人员名
            strSql.Append(" 人员名 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员名) & vbCrLf)

            '密码
            strSql.Append(" ,密码 = " & Utility.PFn_ChangeQuotation(clsM人员T.密码) & vbCrLf)

            '部门
            If clsM人员T.部门 = "" Then
                strSql.Append(" ,部门 = NULL ")
            Else
                strSql.Append(" ,部门 = " & Utility.PFn_ChangeQuotation(clsM人员T.部门) & vbCrLf)
            End If

            '在职状态
            If clsM人员T.在职状态 = "" Then
                strSql.Append(" ,在职状态 = NULL ")
            Else
                strSql.Append(" ,在职状态 = " & Utility.PFn_ChangeQuotation(clsM人员T.在职状态) & vbCrLf)
            End If

            '电话号码
            If clsM人员T.电话号码 = "" Then
                strSql.Append(" ,电话号码 = NULL ")
            Else
                strSql.Append(" ,电话号码 = " & Utility.PFn_ChangeQuotation(clsM人员T.电话号码) & vbCrLf)
            End If

            '入职时间
            If clsM人员T.入职时间 = "1900/01/01 0:00:00" Then
                strSql.Append(" ,入职时间 = NULL ")
            Else
                strSql.Append(" ,入职时间 = " & Utility.PFn_ChangeQuotation(clsM人员T.入职时间) & vbCrLf)
            End If

            '性别
            If clsM人员T.性别 = "" Then
                strSql.Append(" ,性别=NULL ")
            Else
                strSql.Append(",性别=" & Utility.PFn_ChangeQuotation(clsM人员T.性别) & vbCrLf)
            End If

            '职务
            If clsM人员T.职务 = "" Then
                strSql.Append(" ,职务 =NULL ")
            Else
                strSql.Append(",职务 =" & Utility.PFn_ChangeQuotation(clsM人员T.职务) & vbCrLf)
            End If

            '邮箱
            If clsM人员T.邮箱 = "" Then
                strSql.Append(" ,邮箱 =NULL ")
            Else
                strSql.Append(",邮箱 =" & Utility.PFn_ChangeQuotation(clsM人员T.邮箱) & vbCrLf)
            End If

            '办公电话
            If clsM人员T.办公电话 = "" Then
                strSql.Append(" ,办公电话 =NULL ")
            Else
                strSql.Append(",办公电话 =" & Utility.PFn_ChangeQuotation(clsM人员T.办公电话) & vbCrLf)
            End If

            '工种
            If clsM人员T.工种 = "" Then
                strSql.Append(" ,工种 = NULL ")
            Else
                strSql.Append(",工种 = " & Utility.PFn_ChangeQuotation(clsM人员T.工种) & vbCrLf)
            End If
            strSql.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(clsM人员T.更新者))
            strSql.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(clsM人员T.更新日期))


            strSql.Append(" WHERE ")
            strSql.Append(" 人员编号 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员编号) & vbCrLf) '人员编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM M人员管理 ") 'M人员)

            strSql.Append(" WHERE ")
            strSql.Append(" 人员编号 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员编号) & vbCrLf) '人员编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " DeleteBatch "

    '数据删除操作
    Public Function DeleteBatch(ByVal str人员编号 As String) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM M人员管理 ") 'M人员)

            strSql.Append(" WHERE ")
            strSql.Append(" 人员编号 =  " & Utility.PFn_ChangeQuotation(str人员编号) & vbCrLf) '人员编号

            strSql.Append(" DELETE FROM M人员权限 ") 'M人员)

            strSql.Append(" WHERE ")
            strSql.Append(" 人员编号 =  " & Utility.PFn_ChangeQuotation(str人员编号) & vbCrLf) '人员编号
            'strSql.Append(" DELETE FROM M人员权限 ") 'M人员)

            'strSql.Append(" WHERE ")
            'strSql.Append(" 人员编号 IN ( '" & str人员编号 & "')" & vbCrLf) '人员编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT a.人员编号, " & vbCrLf)
            strSql.Append("       a.人员名, " & vbCrLf)
            strSql.Append("       a.密码, " & vbCrLf)
            strSql.Append("       Isnull(部门,'') AS 部门编号, " & vbCrLf)
            strSql.Append("       Isnull(b.部门名称,'') AS 部门名称, " & vbCrLf)
            strSql.Append("       Isnull(在职状态,'') AS 在职状态, " & vbCrLf)
            strSql.Append("       Isnull(电话号码,'') AS 电话号码, " & vbCrLf)

            strSql.Append("       Isnull(性别,'') AS 性别, " & vbCrLf)
            strSql.Append(" ISNULL(邮箱,'') AS 邮箱," & vbCrLf)           '
            strSql.Append(" ISNULL(职务,'') AS 职务," & vbCrLf)           '
            strSql.Append(" ISNULL(工种,'') AS 工种," & vbCrLf)           '
            strSql.Append("       Isnull(办公电话,'') AS 办公电话, " & vbCrLf)
            strSql.Append("       入职时间 AS 入职时间 " & vbCrLf)
            strSql.Append("FROM   m人员管理 a " & vbCrLf)
            strSql.Append("       LEFT JOIN m部门管理 b " & vbCrLf)
            strSql.Append("         ON a.部门 = b.部门编号 ")

            strSql.Append("WHERE  a.人员编号 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT m人员管理.人员编号 AS 人员编号, " & vbCrLf)
            strSql.Append("       m人员管理.人员名 AS 人员名, " & vbCrLf)
            strSql.Append("       m人员管理.密码 AS 密码, " & vbCrLf)
            strSql.Append("       Isnull(m人员管理.部门,'') AS 部门, " & vbCrLf)
            strSql.Append("       Isnull(m人员管理.职务,'') AS 职务, " & vbCrLf)
            strSql.Append("       Isnull(m人员管理.在职状态,'') AS 在职状态, " & vbCrLf)
            strSql.Append("       Isnull(m人员管理.电话号码,'') AS 电话号码, " & vbCrLf)
            strSql.Append("       Isnull(m人员管理.邮箱,'') AS 邮箱, " & vbCrLf)
            strSql.Append("       m部门管理.部门名称,")
            strSql.Append("       m人员管理.入职时间 AS 入职时间 " & vbCrLf)
            strSql.Append("FROM   m人员管理 " & vbCrLf)
            strSql.Append("left join    m部门管理 on m部门管理.部门编号=m人员管理.部门 " & vbCrLf)
            strSql.Append("WHERE  m人员管理.人员编号 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByCD"

    '检索全部数据
    Public Function LoadByCD(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT m人员管理.人员编号 AS 人员编号, " & vbCrLf)
            strSql.Append("       m人员管理.人员名 AS 人员名" & vbCrLf)

            strSql.Append("FROM   m人员管理 " & vbCrLf)
            strSql.Append("WHERE  m人员管理.人员编号 = " & Utility.PFn_ChangeQuotation(clsM人员T.人员编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM人员T As M人员T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ")

            strSql.Append("  0 AS 选择")            '人员编号
            strSql.Append("  ,M人员管理.人员编号 AS 人员编号")            '人员编号
            strSql.Append(" ,M人员管理.人员名 AS 人员姓名")          '人员名
            'strSql.Append(" ,M人员.密码 AS 密码")            '密码
            strSql.Append(" ,ISNULL(M部门管理.部门名称,'') AS 部门名称")           '部门
            'strSql.Append(" ,ISNULL(M人员.在职状态,'') AS 在职状态")           '在职状态
            strSql.Append(" ,ISNULL(M人员管理.电话号码,'') AS 电话号码")           '电话号码
            strSql.Append(" ,ISNULL(M人员管理.职务,'') AS 职务")           '电话号码
            strSql.Append(" ,ISNULL(M人员管理.工种,'') AS 工种")           '电话号码
            strSql.Append(" ,M人员管理.入职时间 AS 入职时间")          '入职时间

            strSql.Append(" FROM M人员管理 ") 'M人员)

            strSql.Append(" LEFT JOIN  M部门管理 ON M人员管理.部门= M部门管理.部门编号 ") 'M人员)

            strSql.Append(" WHERE 1=1 " & vbCrLf)

            If clsM人员T.人员编号 <> String.Empty Then
                strSql.Append(" AND M人员管理.人员编号 like '" & Utility.PFn_ChangeQuotation(clsM人员T.人员编号, True) & "%'" & vbCrLf)
            End If

            If clsM人员T.人员名 <> String.Empty Then
                strSql.Append(" AND M人员管理.人员名 like '%" & Utility.PFn_ChangeQuotation(clsM人员T.人员名, True) & "%'" & vbCrLf)
            End If

            If clsM人员T.部门 <> String.Empty Then
                strSql.Append(" AND M部门管理.部门编号 =" & Utility.PFn_ChangeQuotation(clsM人员T.部门) & vbCrLf)
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadList"
    Public Function LoadList()

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT a.人员编号, " & vbCrLf)
            strSql.Append("       a.人员名, " & vbCrLf)
            strSql.Append("FROM   m人员管理 a " & vbCrLf)
            strSql.Append(" ORDER BY a.人员编号")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region "DeleteSQL人员权限"

    Public Function DeleteSQL人员权限(ByVal m当者权限 As M人员T) As String
        Dim strBuilderSQL As New StringBuilder

        strBuilderSQL.AppendLine(" DELETE FROM M人员权限 ")
        strBuilderSQL.Append("  WHERE 人员编号=" & Utility.PFn_ChangeQuotation(m当者权限.人员编号))
        'データの操作を実行すると結果に戻る
        Return strBuilderSQL.ToString

    End Function

#End Region

#Region "Select详细Band"

    Public Function Select详细Band0(ByVal objCls As M人员T) As String

        Dim strSql As New StringBuilder(String.Empty)

        strSql.Append("SELECT   VM功能区分.名称 AS 第１階層, " & vbCrLf)
        strSql.Append("         CASE  " & vbCrLf)
        strSql.Append("           WHEN m人员权限.菜单区分 IS NULL THEN 'FALSE' " & vbCrLf)
        strSql.Append("           ELSE 'TRUE' " & vbCrLf)
        strSql.Append("         END AS 表示, " & vbCrLf)
        strSql.Append("         VM功能区分.区分 AS 区分, " & vbCrLf)
        strSql.Append("         VM功能区分.区分1 AS 区分1 " & vbCrLf)
        strSql.Append("FROM     VM功能区分 " & vbCrLf)
        strSql.Append("         LEFT JOIN m人员权限 " & vbCrLf)
        strSql.Append("           ON m人员权限.菜单区分 = VM功能区分.区分 " & vbCrLf)
        'If Not String.IsNullOrEmpty(objCls.人员编号) Then
        strSql.Append("              AND m人员权限.人员编号 =  " & Utility.PFn_ChangeQuotation(objCls.人员编号) & vbCrLf)
        'End If
        strSql.Append("WHERE    VM功能区分.区分2 = 0 " & vbCrLf)
        strSql.Append("         AND VM功能区分.区分3 = 0 " & vbCrLf)
        strSql.Append("ORDER BY VM功能区分.顺序")
        Return strSql.ToString

    End Function

    Public Function Select详细Band1(ByVal objCls As M人员T) As String

        Dim strSql As New StringBuilder(String.Empty)

        strSql.Append("SELECT   VM功能区分.名称 AS 第２階層, " & vbCrLf)
        strSql.Append("         CASE  " & vbCrLf)
        strSql.Append("           WHEN m人员权限.菜单区分 IS NULL THEN 'FALSE' " & vbCrLf)
        strSql.Append("           ELSE 'TRUE' " & vbCrLf)
        strSql.Append("         END AS 表示, " & vbCrLf)
        strSql.Append("         VM功能区分.区分 AS 区分, " & vbCrLf)
        strSql.Append("         VM功能区分.区分1 AS 区分1, " & vbCrLf)
        strSql.Append("         VM功能区分.区分2 AS 区分2 " & vbCrLf)
        strSql.Append("FROM     VM功能区分 " & vbCrLf)
        strSql.Append("         LEFT JOIN m人员权限 " & vbCrLf)
        strSql.Append("           ON m人员权限.菜单区分 = VM功能区分.区分 " & vbCrLf)
        'If Not String.IsNullOrEmpty(objCls.人员编号) Then
        strSql.Append("              AND m人员权限.人员编号 =  " & Utility.PFn_ChangeQuotation(objCls.人员编号) & vbCrLf)
        'End If
        strSql.Append("WHERE    VM功能区分.区分2 <> 0 " & vbCrLf)
        strSql.Append("         AND VM功能区分.区分3 = 0 " & vbCrLf)
        strSql.Append("ORDER BY VM功能区分.顺序")

        Return strSql.ToString

    End Function

    Public Function Select详细Band2(ByVal objCls As M人员T) As String

        Dim strSql As New StringBuilder(String.Empty)

        strSql.Append("SELECT   VM功能区分.名称 AS 第３階層, " & vbCrLf)
        strSql.Append("         CASE  " & vbCrLf)
        strSql.Append("           WHEN m人员权限.菜单区分 IS NULL THEN 'FALSE' " & vbCrLf)
        strSql.Append("           ELSE 'TRUE' " & vbCrLf)
        strSql.Append("         END AS 表示, " & vbCrLf)
        strSql.Append("         VM功能区分.区分 AS 区分, " & vbCrLf)
        strSql.Append("         VM功能区分.区分1 AS 区分1, " & vbCrLf)
        strSql.Append("         VM功能区分.区分2 AS 区分2 " & vbCrLf)
        strSql.Append("FROM     VM功能区分 " & vbCrLf)
        strSql.Append("         LEFT JOIN m人员权限 " & vbCrLf)
        strSql.Append("           ON m人员权限.菜单区分 = VM功能区分.区分 " & vbCrLf)
        'If Not String.IsNullOrEmpty(objCls.人员编号) Then
        strSql.Append("              AND m人员权限.人员编号 =  " & Utility.PFn_ChangeQuotation(objCls.人员编号) & vbCrLf)
        'End If
        strSql.Append("WHERE    VM功能区分.区分2 <> 0 " & vbCrLf)
        strSql.Append("         AND VM功能区分.区分3 <> 0 " & vbCrLf)
        strSql.Append("ORDER BY VM功能区分.顺序")

        Return strSql.ToString

    End Function

#End Region

#Region " InsertSQL人员权限 "

    '数据插入操作
    Public Function InsertSQL人员权限(ByVal clsM人员权限T As M人员权限T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO M人员权限")         'M人员

            strSql.Append(" (人员编号")          '人员编号
            strSql.Append(" ,菜单区分")           '菜单区分
            strSql.Append(")")

            strSql.Append(" VALUES ")

            '人员编号
            strSql.Append(" ( " & Utility.PFn_ChangeQuotation(clsM人员权限T.人员编号) & vbCrLf)

            '菜单区分
            strSql.Append("," & Utility.PFn_ChangeQuotation(clsM人员权限T.菜单区分) & vbCrLf)

            strSql.Append(")")

            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " LoadBM"

    '检索全部数据
    Public Function LoadBM(ByVal objM部门T As M部门T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	部门编号" & vbCrLf)
            strSql.Append(" 	,部门名称" & vbCrLf)
            'strSql.Append(" 	,登录者" & vbCrLf)
            'strSql.Append(" 	,登录日期" & vbCrLf)
            'strSql.Append(" 	,更新者" & vbCrLf)
            'strSql.Append(" 	,更新日期" & vbCrLf)
            strSql.Append(" FROM M部门管理")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM部门T.部门编号 <> String.Empty) Then
                strSql.Append(" AND 部门编号 = '" & Utility.PFn_ChangeQuotation(objM部门T.部门编号, True) & "'" & vbCrLf)
            End If
            If (objM部门T.部门名称 <> String.Empty) Then
                strSql.Append(" AND 部门名称 LIKE '%" & Utility.PFn_ChangeQuotation(objM部门T.部门名称, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 部门编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class