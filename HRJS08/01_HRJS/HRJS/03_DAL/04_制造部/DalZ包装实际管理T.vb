Imports System.Text

Public Class DalZ包装实际管理T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO dbo.Z包装实际管理 " & vbCrLf)
            strSql.Append("(订单编号, " & vbCrLf)
            strSql.Append("产品图号, " & vbCrLf)
            strSql.Append("人员编号, " & vbCrLf)
            strSql.Append("作业日期, " & vbCrLf)
            strSql.Append("作业方式, " & vbCrLf)
            strSql.Append("完成日期, " & vbCrLf)
            strSql.Append("实际生产数, " & vbCrLf)        
            strSql.Append("登陆者, " & vbCrLf)
            strSql.Append("登陆日期 " & vbCrLf)
            strSql.Append("         ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.产品图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.人员编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业日期))         
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业方式))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.完成日期))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.实际生产数))           
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.登陆者))
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.登陆日期))
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
    Public Function Update(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.AppendFormat(" UPDATE [HRJS].[dbo].[Z包装实际管理]" & vbCrLf)
            strSQL.AppendFormat("    SET " & vbCrLf)
            strSQL.AppendFormat("       订单编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号))
            strSQL.AppendFormat("       ,产品图号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.产品图号))
            strSQL.AppendFormat("       ,人员编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.人员编号))
            strSQL.AppendFormat("       ,作业日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业开始时间))
            'strSQL.AppendFormat("       ,作业开始时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业开始时间))
            'strSQL.AppendFormat("       ,作业结束时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业完成时间))
            strSQL.AppendFormat("       ,作业方式= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业方式))
            strSQL.AppendFormat("       ,完成日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业完成时间))
            strSQL.AppendFormat("       ,制造批量号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.制造批量号))
            strSQL.AppendFormat("       ,实际生产数= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.实际生产数))
            strSQL.AppendFormat("       ,流转票编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.流转票编号))
            strSQL.AppendFormat("       ,作业指示= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.作业指示))
            strSQL.AppendFormat("       ,图纸尺寸= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.图纸尺寸))
            strSQL.AppendFormat("       ,公差= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.公差))
            strSQL.AppendFormat("       ,自检时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.自检时间))
            strSQL.AppendFormat("       ,自检结果= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.自检结果))
            strSQL.AppendFormat("       ,自检结果自评= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.自检结果自评))
            strSQL.AppendFormat("       ,不良品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.不良品数量))
            strSQL.AppendFormat("       ,待修品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.待修品数量))
            strSQL.AppendFormat("       ,报废品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.报废品数量))
            strSQL.AppendFormat("       ,更新者= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.更新者))
            strSQL.AppendFormat("       ,更新日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.更新日期))


            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM Z包装实际管理" & vbCrLf)
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号) & vbCrLf)
            'SQLに戻る

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllGrid "

    '检索全部数据
    Public Function LoadAllGrid(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("         图纸尺寸 " & vbCrLf)
            strSql.Append("         ,公差" & vbCrLf)
            strSql.Append("         ,自检时间" & vbCrLf)
            strSql.Append("         ,自检结果" & vbCrLf)
            strSql.Append("         ,自检结果自评" & vbCrLf)
            strSql.Append("         ,不良品数量" & vbCrLf)
            strSql.Append("         ,待修品数量" & vbCrLf)
            strSql.Append("         ,报废品数量" & vbCrLf)
            strSql.Append(" FROM    dbo.Z包装实际管理 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load人员 "

    '检索全部数据
    Public Function Load人员(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("         人员编号 " & vbCrLf)
            strSql.Append("         ,人员名" & vbCrLf)
            strSql.Append("         ,职务" & vbCrLf)
            strSql.Append("         ,M部门管理.部门名称" & vbCrLf)
            strSql.Append("         ,M人员管理.部门" & vbCrLf)
            strSql.Append(" FROM    M人员管理 " & vbCrLf)
            strSql.Append(" INNER JOIN M部门管理 " & vbCrLf)
            strSql.Append(" ON M人员管理.部门= M部门管理.部门编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  人员编号 =" & Utility.PFn_ChangeQuotation(objZ包装实际T.人员编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load订单 "

    '检索全部数据
    Public Function Load订单(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("         订单编号 " & vbCrLf)
            strSql.Append("         ,产品图号 " & vbCrLf)
            strSql.Append("         ,M客户管理.客户名称" & vbCrLf)
            strSql.Append("         ,订单数量" & vbCrLf)
            strSql.Append(" FROM    B订单管理 " & vbCrLf)
            strSql.Append(" INNER JOIN M客户管理 " & vbCrLf)
            strSql.Append(" ON B订单管理.客户编号= M客户管理.客户编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  订单编号 =" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "LoadAll"
    Public Function LoadAll(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" 	 Z包装实际管理.订单编号  " & vbCrLf)
            strSql.Append(" 	,Z包装实际管理.产品图号 " & vbCrLf)
            strSql.Append("     ,M人员管理.人员编号 " & vbCrLf)
            strSql.Append("     ,M人员管理.人员名  " & vbCrLf)
            strSql.Append("     ,M人员管理.职务  " & vbCrLf)
            strSql.Append(" 	,M部门管理 .部门名称" & vbCrLf)
            strSql.Append(" 	,M客户管理.客户名称  " & vbCrLf)
            strSql.Append(" 	,作业方式  " & vbCrLf)
            strSql.Append(" 	,作业日期  " & vbCrLf)
            strSql.Append(" 	,完成日期  " & vbCrLf)
            strSql.Append(" 	,B订单管理.投产数量 " & vbCrLf)
            strSql.Append(" 	,实际生产数  " & vbCrLf)
            strSql.Append(" FROM Z包装实际管理" & vbCrLf)
            strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            strSql.Append(" ON B订单管理.订单编号=Z包装实际管理.订单编号" & vbCrLf)
            strSql.Append(" AND B订单管理.产品图号 = Z包装实际管理.产品图号" & vbCrLf)
            strSql.Append(" LEFT JOIN M客户管理 ON M客户管理.客户编号 =B订单管理.客户编号  " & vbCrLf)
            strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            strSql.Append(" ON M人员管理 .人员编号 =Z包装实际管理.人员编号 " & vbCrLf)
            strSql.Append(" LEFT JOIN M部门管理 ON M部门管理 .部门编号 =M人员管理.部门  " & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  Z包装实际管理.订单编号 =" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	订单编号" & vbCrLf)
            strSql.Append(" FROM Z包装实际管理")
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere"

    '检索全部数据
    'tudo


    Public Function LoadByWhere(ByVal objZ包装实际T As Z包装实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" 	 Z包装实际管理.订单编号  " & vbCrLf)
            strSql.Append(" 	,Z包装实际管理.产品图号 " & vbCrLf)
            strSql.Append("     ,M人员管理.人员名 AS 作业者 " & vbCrLf)
            strSql.Append(" 	,M部门管理 .部门名称 AS 部门名称 " & vbCrLf)
            strSql.Append(" 	,作业方式  " & vbCrLf)
            strSql.Append(" 	,作业日期 AS 作业开始日期 " & vbCrLf)
            strSql.Append(" 	,完成日期 AS 作业完成日期 " & vbCrLf)
            strSql.Append(" 	,B订单管理.订单数量 AS 计划生产数量  " & vbCrLf)
            strSql.Append(" 	,实际生产数  " & vbCrLf)           
            strSql.Append(" FROM Z包装实际管理" & vbCrLf)
            strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            strSql.Append(" ON B订单管理.订单编号=Z包装实际管理.订单编号" & vbCrLf)
            strSql.Append(" AND B订单管理.产品图号 = Z包装实际管理.产品图号" & vbCrLf)
            strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            strSql.Append(" ON M人员管理 .人员编号 =Z包装实际管理.人员编号 " & vbCrLf)
            strSql.Append(" LEFT JOIN M部门管理 ON M部门管理 .部门编号 =M人员管理.部门  " & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE 1=1" & vbCrLf)
            If objZ包装实际T.部门编号 <> String.Empty Then
                strSql.Append(" AND M部门管理 .部门编号='" & Utility.PFn_ChangeQuotation(objZ包装实际T.部门编号, True) & "'" & vbCrLf)
            End If
            If objZ包装实际T.作业方式 <> String.Empty Then
                strSql.Append(" AND 作业方式='" & Utility.PFn_ChangeQuotation(objZ包装实际T.作业方式, True) & "'" & vbCrLf)
            End If
            If objZ包装实际T.作业者 <> String.Empty Then
                strSql.Append(" AND M人员管理.人员名 LIKE'" & Utility.PFn_ChangeQuotation(objZ包装实际T.作业者, True) & "%'" & vbCrLf)
            End If
            If objZ包装实际T.作业开始时间 <> String.Empty Then
                strSql.Append(" AND 作业日期>='" & Utility.PFn_ChangeQuotation(objZ包装实际T.作业开始时间, True) & "'" & vbCrLf)
            End If
            If objZ包装实际T.作业完成时间 <> String.Empty Then
                strSql.Append(" AND 完成日期<='" & Utility.PFn_ChangeQuotation(objZ包装实际T.作业完成时间, True) & "'" & vbCrLf)
            End If
            If objZ包装实际T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z包装实际管理.订单编号='" & Utility.PFn_ChangeQuotation(objZ包装实际T.订单编号, True) & "'" & vbCrLf)
            End If
            If objZ包装实际T.产品图号 <> String.Empty Then
                strSql.Append(" AND Z包装实际管理.产品图号='" & Utility.PFn_ChangeQuotation(objZ包装实际T.产品图号, True) & "'" & vbCrLf)
            End If
            'strSql.Append(" ORDER BY 作业开始时间")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region


End Class
