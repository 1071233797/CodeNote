Imports System.Text

Public Class DalM原材料信息T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO M原材料信息") 'M原材料信息
            strSql.Append(" ( 原材料编号")            '原材料编号
            strSql.Append(" ,原材料区分")             '原材料区分
            strSql.Append(" ,材料种类")                   '材料种类
            strSql.Append(" ,材质")                   '材质
            strSql.Append(" ,材料代号")                   '材质
            strSql.Append(" ,密度")                   '材质      
            strSql.Append(" ,原材料名称")                     '宽
            strSql.Append(")")

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.原材料区分))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.材料种类))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.材质))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.材料代号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.密度))       
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.原材料名称))    
            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.Append(" UPDATE   " & vbCrLf)
            strSQL.Append("       M原材料信息 " & vbCrLf)
            strSQL.Append(" SET " & vbCrLf)
           
            If ojbM原材料T.原材料区分 = "" Then
                strSQL.Append(" 原材料区分 = NULL ")
            Else
                strSQL.Append(" 原材料区分 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料区分) & vbCrLf)
            End If

            '材料种类
            If ojbM原材料T.材料种类 = "" Then
                strSQL.Append(" ,材料种类 = NULL ")
            Else
                strSQL.Append(" ,材料种类 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.材料种类) & vbCrLf)
            End If

            '材质
            If ojbM原材料T.材质 = "" Then
                strSQL.Append(" ,材质 = NULL ")
            Else
                strSQL.Append(" ,材质 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.材质) & vbCrLf)
            End If

            If ojbM原材料T.材料代号 = "" Then
                strSQL.Append(" ,材料代号 = NULL ")
            Else
                strSQL.Append(" ,材料代号 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.材料代号) & vbCrLf)
            End If

            strSQL.Append(" ,原材料名称 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料名称) & vbCrLf)
            strSQL.Append(" ,密度 = " & Utility.PFn_ChangeQuotation(ojbM原材料T.密度) & vbCrLf)

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("       原材料编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" DELETE FROM M原材料信息" & vbCrLf)
            strSql.Append(" WHERE " & vbCrLf)
            strSql.AppendFormat("  原材料编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号))

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

    Public Function LoadAll(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	原材料编号" & vbCrLf)

            strSql.Append(" ,  原材料区分" & vbCrLf)

            strSql.Append(" , 材料种类" & vbCrLf)
            strSql.Append(" ,材质" & vbCrLf)
          
          
            strSql.Append(" FROM M原材料信息")
        
            '检索条件 设定
            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据

    Public Function LoadAllHead(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT 原材料编号 , " & vbCrLf)
            strSql.Append("         原材料区分 , " & vbCrLf)
            strSql.Append("         材料种类 , " & vbCrLf)
            strSql.Append("         材质 , " & vbCrLf)
            strSql.Append("         材料代号 , " & vbCrLf)
            strSql.Append("        原材料名称 , " & vbCrLf)
            strSql.Append("        密度  " & vbCrLf)
            strSql.Append(" FROM   dbo.M原材料信息 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 原材料编号=" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region



#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	原材料编号,原材料名称" & vbCrLf)
            strSql.Append("  ,VM材料区分.名称 原材料区分  " & vbCrLf)
            strSql.Append("  ,VM材料种类.名称 材料种类  " & vbCrLf)
            strSql.Append("  , VM材质.名称 材质  " & vbCrLf)
            strSql.Append("  , 材料代号  " & vbCrLf)
            strSql.Append(" FROM M原材料信息")
            strSql.Append(" INNER JOIN dbo.VM材料区分 ON VM材料区分.区分=原材料区分 " & vbCrLf)
            strSql.Append("  INNER JOIN dbo.VM材料种类 ON VM材料种类.区分=材料种类 " & vbCrLf)
            strSql.Append("  INNER JOIN dbo.VM材质 ON VM材质.区分=材质 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM原材料T.原材料编号 <> String.Empty) Then
                strSql.Append(" AND M原材料信息.原材料编号=" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号) & vbCrLf)
            End If
            If (ojbM原材料T.原材料区分 <> String.Empty) Then
                strSql.Append(" AND M原材料信息.原材料区分=" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料区分) & vbCrLf)
            End If
            If (ojbM原材料T.材料种类 <> String.Empty) Then
                strSql.Append(" AND M原材料信息.材料种类=" & Utility.PFn_ChangeQuotation(ojbM原材料T.材料种类) & vbCrLf)
            End If
            If (ojbM原材料T.材质 <> String.Empty) Then
                strSql.Append(" AND M原材料信息.材质=" & Utility.PFn_ChangeQuotation(ojbM原材料T.材质) & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据

    Public Function LoadByWhere(ByVal ojbM原材料T As M原材料信息T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT distinct 原材料编号 , " & vbCrLf)
            strSql.Append("        原材料名称 , " & vbCrLf)
            strSql.Append("        VM材料区分.名称 原材料区分 , " & vbCrLf)
            strSql.Append("        VM材料种类.名称 材料种类 , " & vbCrLf)
            strSql.Append("        VM材质.名称 材质 , " & vbCrLf)
            strSql.Append("        材料代号 , " & vbCrLf)
            strSql.Append("        ISNULL(密度,0)密度  " & vbCrLf)
          

         
            strSql.Append(" FROM   M原材料信息 " & vbCrLf)

            strSql.Append("     left JOIN dbo.VM材料区分 ON VM材料区分.区分=原材料区分 " & vbCrLf)
            strSql.Append("     left JOIN dbo.VM材料种类 ON VM材料种类.区分=材料种类 " & vbCrLf)
            strSql.Append("     left JOIN dbo.VM材质 ON VM材质.区分=材质 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 1=1 " & vbCrLf)
            If (ojbM原材料T.原材料编号 <> String.Empty) Then
                strSql.Append(" AND 原材料编号 =" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料编号) & vbCrLf)
            End If
           
            If (ojbM原材料T.原材料区分 <> String.Empty) Then
                strSql.Append(" AND 原材料区分 LIKE '%" & Utility.PFn_ChangeQuotation(ojbM原材料T.原材料区分, True) & "%'" & vbCrLf)
            End If
           
            If (ojbM原材料T.材料种类 <> String.Empty) Then
                strSql.Append(" AND 材料种类 LIKE '%" & Utility.PFn_ChangeQuotation(ojbM原材料T.材料种类, True) & "%'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 原材料编号")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
