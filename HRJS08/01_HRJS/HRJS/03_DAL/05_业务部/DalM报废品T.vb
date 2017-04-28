Imports System.Text
Public Class DalM报废品T




#Region "IsExists"

    Public Function IsExists(ByVal str报废品订单编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B报废品 " & vbCrLf)
            strSql.Append("WHERE  报废品订单编号 = " & Utility.PFn_ChangeQuotation(str报废品订单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM报废品T As B报废品T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B报废品" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.Append(" 	报废品订单编号" & vbCrLf)
            strSql.Append(" 	,客户名称 " & vbCrLf)
            strSql.Append(" 	,发货日期 " & vbCrLf)
            strSql.Append(" 	,报废品图号 " & vbCrLf)
            strSql.Append(" 	,总图号" & vbCrLf)
            strSql.Append(" 	,报废品产生工序 " & vbCrLf)
            strSql.Append(" 	,报废品数量 " & vbCrLf)
            strSql.Append(" 	,报废品生产者 " & vbCrLf)
            strSql.Append(" 	,报废日期 " & vbCrLf)
            strSql.Append(" 	,报废原因" & vbCrLf)
            strSql.Append(" 	,处理结果" & vbCrLf)
            strSql.Append(" 	,备注 " & vbCrLf)
            
            strSql.Append(" 	,pic1 " & vbCrLf)
            strSql.Append(" 	,pic2 " & vbCrLf)
            strSql.Append(" 	,pic3 " & vbCrLf)
            strSql.Append(" 	,登录者" & vbCrLf)
            strSql.Append(" 	,登录日期 " & vbCrLf)

            strSql.Append("  )" & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.客户名称))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.发货日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.总图号))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品产生工序))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品数量))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品生产者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废日期))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废原因))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.处理结果))

            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.备注))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic1))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic2))

            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic3))
            

            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.登录者))
            strSql.AppendFormat(" ,{0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.登录日期))
            


            strSql.Append(")" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal objM报废品T As B报废品T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       B报废品 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)

            strSQL.AppendFormat(" 		报废品订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号))
            'If Not objM模具T.模具型号 = "" Then
            strSQL.AppendFormat(" 		,客户名称 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.客户名称))
            'End If
            'If Not objM模具T.维护周期 = "" Then
            strSQL.AppendFormat(" 		,发货日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.发货日期))
            'End If
            'If Not objM模具T.上次维护日期 = "" Then
            strSQL.AppendFormat(" 		,报废品图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品图号))
            'End If
            'If Not objM模具T.使用状态 = "" Then
            strSQL.AppendFormat(" 		,总图号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.总图号))
            'End If
            strSQL.AppendFormat(" 		,报废品产生工序 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品产生工序))

            strSQL.AppendFormat(" 		,报废品数量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品数量))

            strSQL.AppendFormat(" 		,报废品生产者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品生产者))

            strSQL.AppendFormat(" 		,报废日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废日期))

            'If Not objM模具T.模具产量 = "" Then
            strSQL.AppendFormat(" 		,报废原因 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废原因))
            'End If
            'If Not objM模具T.维护厂商 = "" Then
            strSQL.AppendFormat(" 		,处理结果 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.处理结果))
            'End If
            'If Not objM模具T.维护负责人 = "" Then
            strSQL.AppendFormat(" 		,备注 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.备注))
            'End If

            If objM报废品T.pic1 <> "" Then
                strSQL.AppendFormat(" 		,pic1 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic1))
            End If

            If objM报废品T.pic2 <> "" Then
                strSQL.AppendFormat(" 		,pic2 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic2))
            End If

            If objM报废品T.pic3 <> "" Then
                strSQL.AppendFormat(" 		,pic3 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.pic3))
            End If
            strSQL.AppendFormat(" 		,更新者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.更新者))
            strSQL.AppendFormat(" 		,更新日期 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.更新日期))
           

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    报废品订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objM报废品T As B报废品T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM B报废品" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  报废品订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号))
            strSql.AppendFormat(" and  报废品产生工序 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品产生工序))
            strSql.AppendFormat(" and  报废品生产者 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品生产者))
            strSql.AppendFormat(" and  报废品数量 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM报废品T.报废品数量))
            'SQLに戻る
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal objM报废品T As B报废品T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT 报废品订单编号 , " & vbCrLf)
            strSql.Append("         M客户管理.客户编号 , " & vbCrLf)
            strSql.Append("         M客户管理.客户名称, " & vbCrLf)
            strSql.Append("         发货日期 , " & vbCrLf)
            strSql.Append("         报废品图号 , " & vbCrLf)
            strSql.Append("         总图号 , " & vbCrLf)
            strSql.Append("         报废品产生工序 , " & vbCrLf)
            strSql.Append("         报废品数量 , " & vbCrLf)
            strSql.Append("         M人员管理.人员名 报废品生产者 , " & vbCrLf)
            strSql.Append("         报废日期 , " & vbCrLf)
            strSql.Append("         报废原因 , " & vbCrLf)
            strSql.Append("         处理结果 , " & vbCrLf)
            strSql.Append("         备注 , " & vbCrLf)
            strSql.Append("         pic1 , " & vbCrLf)
            strSql.Append("         pic2 , " & vbCrLf)
            strSql.Append("         pic3  " & vbCrLf)
            'strSql.Append("         维护内容 , " & vbCrLf)
            'strSql.Append("         模具图片 , " & vbCrLf)
            'strSql.Append("         类型 , " & vbCrLf)
            'strSql.Append("         设计者 , " & vbCrLf)

            'strSql.Append("         制造日期 , " & vbCrLf)
           
            strSql.Append("  FROM   B报废品 " & vbCrLf)
            strSql.Append("         left JOIN dbo.M人员管理 ON 人员名 = 报废品生产者 " & vbCrLf)
            strSql.Append("         left JOIN dbo.M客户管理 ON M客户管理.客户名称 = B报废品.客户名称 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 报废品订单编号=" & Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号) & vbCrLf)
            'strSql.Append(" WHERE 报废品图号=" & Utility.PFn_ChangeQuotation(objM报废品T.报废品图号) & vbCrLf)
            'strSql.Append(" WHERE 报废品产生工序=" & Utility.PFn_ChangeQuotation(objM报废品T.报废品产生工序) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPK"

    '检索全部数据
    Public Function LoadByPK(ByVal objM报废品T As B报废品T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	报废品订单编号" & vbCrLf)
            ' strSql.Append(" 	,模具名称 " & vbCrLf)

            strSql.Append(" FROM B报废品")
            '检索条件 设定
            strSql.Append(" WHERE 报废品订单编号=" & Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    Public Function LoadByWhere(ByVal objM报废品T As B报废品T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT distinct 报废品图号 , ")

            strSql.Append("         报废品订单编号 , ")
            strSql.Append("         报废品产生工序 , ")
            strSql.Append("         B.客户名称 , ")
            strSql.Append("         报废品数量 , ")
            strSql.Append("         c.人员名 报废品生产者 , ")
            strSql.Append("         报废日期 , ")
            strSql.Append("         报废原因, ")
            strSql.Append("         处理结果 , ")
            strSql.Append("         备注,  ")


            strSql.Append("         pic1 , ")
            strSql.Append("         pic2 , ")

            strSql.Append("         pic3  ")
            'strSql.Append("         生产日期 , ")
            'strSql.Append("         存放区域 , ")
            'strSql.Append("         维护负责人编号 , ")
            'strSql.Append("         维护部门名称 , ")
            'strSql.Append("         维护负责人姓名 , ")
            'strSql.Append("         维护内容 , ")
            'strSql.Append("         模具图片 , ")
            'strSql.Append("         A.负责人电话 ")
            strSql.Append("  FROM   B报废品 A ")
            strSql.Append("         left JOIN dbo.M客户管理 B ON B.客户名称 = A.客户名称 ")
            strSql.Append("         left JOIN dbo.M人员管理 c ON A.报废品生产者 = c.人员名 ")
            ' strSql.Append("         LEFT JOIN VM使用状态 ON A.使用状态 = VM使用状态.区分 ")
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (objM报废品T.报废品图号 <> String.Empty) Then
                strSql.Append(" AND 报废品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.报废品图号, True) & "%'" & vbCrLf)
            End If
            If (objM报废品T.报废品订单编号 <> String.Empty) Then
                strSql.Append(" AND 报废品订单编号 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.报废品订单编号, True) & "%'" & vbCrLf)
            End If
            If (objM报废品T.报废品生产者 <> String.Empty) Then
                strSql.Append(" AND 报废品生产者 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.报废品生产者, True) & "%'" & vbCrLf)
            End If

            If (objM报废品T.报废品产生工序 <> String.Empty) Then
                strSql.Append(" AND 报废品产生工序 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.报废品产生工序, True) & "%'" & vbCrLf)
            End If

            'If (objM报废品T.报废日期 <> String.Empty) Then
            '    strSql.Append(" AND A.类型 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.类型, True) & "%'" & vbCrLf)
            'End If

            'If (objM报废品T.报废日期 <> String.Empty) Then
            '    strSql.Append(" AND 模具型号 LIKE '%" & Utility.PFn_ChangeQuotation(objM报废品T.模具型号, True) & "%'" & vbCrLf)
            'End If
            If (objM报废品T.报废日期起 <> "1900/1/1") Then
                strSql.Append(" AND 报废日期 >=" & Utility.PFn_ChangeQuotation(objM报废品T.报废日期起.ToString("yyyy/MM/dd")) & vbCrLf)
            End If

            If (objM报废品T.报废日期止 <> "1900/1/1") Then
                strSql.Append(" AND 报废日期 <=" & Utility.PFn_ChangeQuotation(objM报废品T.报废日期止.ToString("yyyy/MM/dd")) & vbCrLf)
            End If
            strSql.Append(" ORDER BY 报废品订单编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class

