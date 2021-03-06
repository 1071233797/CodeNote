Imports System.Text

Public Class DalZ生产自检录入T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO dbo.Z生产自检录入 " & vbCrLf)
            strSql.Append("(订单编号, " & vbCrLf)
            strSql.Append("主图号, " & vbCrLf)
            strSql.Append("上级图号, " & vbCrLf)
            strSql.Append("作业者编号, " & vbCrLf)
            'strSql.Append("作业日期, " & vbCrLf)
            'strSql.Append("作业时间, " & vbCrLf)
            'strSql.Append("作业方式, " & vbCrLf)
            strSql.Append("本道工序编号, " & vbCrLf)
            'strSql.Append("上道工序, " & vbCrLf)
            'strSql.Append("下道工序, " & vbCrLf)
            'strSql.Append("作业指示, " & vbCrLf)
            strSql.Append("分图号, " & vbCrLf)
            strSql.Append("图纸尺寸, " & vbCrLf)
            strSql.Append("公差, " & vbCrLf)
            strSql.Append("自检时间, " & vbCrLf)
            strSql.Append("自检结果, " & vbCrLf)
            strSql.Append("不良品数量, " & vbCrLf)
            strSql.Append("待修品数量, " & vbCrLf)
            strSql.Append("报废品数量, " & vbCrLf)
            strSql.Append("备注, " & vbCrLf)
            strSql.Append("登陆者, " & vbCrLf)
            strSql.Append("登陆日期 " & vbCrLf)

            strSql.Append("         ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.订单编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.主图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.上级图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.人员编号))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业日期))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业时间))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业方式))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.本道工序编号))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.上道工序))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.下道工序))
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业指示))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.分图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.图纸尺寸))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.公差))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.自检时间))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.自检结果))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.不良品数量))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.待修品数量))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.报废品数量))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.备注))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.登陆者))
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.登陆日期))

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
    Public Function Update(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.AppendFormat(" UPDATE [HRJS].[dbo].[Z生产自检录入]" & vbCrLf)
            strSQL.AppendFormat("    SET " & vbCrLf)
            strSQL.AppendFormat("       订单编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.订单编号))
            strSQL.AppendFormat("       ,主图号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.主图号))
            strSQL.AppendFormat("       ,产品图号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.分图号))
            strSQL.AppendFormat("       ,人员编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.人员编号))
            strSQL.AppendFormat("       ,作业日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业日期))
            strSQL.AppendFormat("       ,作业时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业时间))
            strSQL.AppendFormat("       ,作业方式= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业方式))
            strSQL.AppendFormat("       ,本道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.本道工序编号))
            'strSQL.AppendFormat("       ,上道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.上道工序))
            'strSQL.AppendFormat("       ,下道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.下道工序))
            strSQL.AppendFormat("       ,作业指示= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.作业指示))
            strSQL.AppendFormat("       ,图纸尺寸= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.图纸尺寸))
            strSQL.AppendFormat("       ,公差= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.公差))
            strSQL.AppendFormat("       ,自检时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.自检时间))
            strSQL.AppendFormat("       ,自检结果= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.自检结果))
            strSQL.AppendFormat("       ,不良品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.不良品数量))
            strSQL.AppendFormat("       ,待修品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.待修品数量))
            strSQL.AppendFormat("       ,报废品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.报废品数量))
            strSQL.AppendFormat("       ,更新者= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.更新者))
            strSQL.AppendFormat("       ,更新日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.更新日期))

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产自检T.订单编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM Z生产自检录入" & vbCrLf)
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号) & vbCrLf)
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
    Public Function LoadAllGrid(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append("         图纸尺寸 " & vbCrLf)
            strSql.Append("         ,公差" & vbCrLf)
            strSql.Append("         ,自检时间" & vbCrLf)
            strSql.Append("         ,自检结果" & vbCrLf)
            strSql.Append("         ,不良品数量" & vbCrLf)
            strSql.Append("         ,待修品数量" & vbCrLf)
            strSql.Append("         ,报废品数量" & vbCrLf)
            strSql.Append("         ,备注" & vbCrLf)
            strSql.Append(" FROM    dbo.Z生产自检录入 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load人员 "

    '检索全部数据
    Public Function Load人员(ByVal objM生产自检T As Z生产自检录入T) As String

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
            strSql.Append("WHERE  人员编号 =" & Utility.PFn_ChangeQuotation(objM生产自检T.人员编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load订单 "

    '检索全部数据
    Public Function Load订单(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("         订单编号 " & vbCrLf)
            strSql.Append("         ,M客户管理.客户名称" & vbCrLf)
            strSql.Append("         ,订单数量" & vbCrLf)
            strSql.Append(" FROM    B订单管理 " & vbCrLf)
            strSql.Append(" INNER JOIN M客户管理 " & vbCrLf)
            strSql.Append(" ON B订单管理.客户编号= M客户管理.客户编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  订单编号 =" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "LoadAll"
    Public Function LoadAll(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("Z生产自检录入.作业者编号 " & vbCrLf)
            strSql.Append(",M人员管理.人员名" & vbCrLf)
            strSql.Append(",M人员管理.职务" & vbCrLf)
            strSql.Append(",M部门管理.部门名称" & vbCrLf)
            strSql.Append(",Z生产自检录入.订单编号" & vbCrLf)
            strSql.Append(",M客户管理.客户名称" & vbCrLf)
            strSql.Append(",Z生产自检录入.主图号" & vbCrLf)
            strSql.Append(",Z生产自检录入.上级图号" & vbCrLf)
            strSql.Append(",Z生产自检录入.分图号" & vbCrLf)
            strSql.Append(",T流转票管理.工序名称" & vbCrLf)
            strSql.Append(",T流转票管理.工序编号" & vbCrLf)
            strSql.Append(",dbo.T流转票管理. 加工内容简介 作业指示" & vbCrLf)
            strSql.Append(",图纸尺寸" & vbCrLf)
            strSql.Append(",公差" & vbCrLf)
            strSql.Append(",自检时间" & vbCrLf)
            strSql.Append(",自检结果" & vbCrLf)
            strSql.Append(",不良品数量" & vbCrLf)
            strSql.Append(",待修品数量" & vbCrLf)
            strSql.Append(",报废品数量" & vbCrLf)
            strSql.Append(",Z生产自检录入.备注" & vbCrLf)
            strSql.Append(" FROM Z生产自检录入" & vbCrLf)
            strSql.Append("  left join M人员管理  on M人员管理 .人员编号 =Z生产自检录入 .作业者编号 ")
            strSql.Append("  left join M部门管理  on M人员管理 .部门 =M部门管理 .部门编号 ")
            strSql.Append("  left join B订单管理  on Z生产自检录入 .订单编号 =B订单管理 .订单编号  AND B订单管理.产品图号 = Z生产自检录入.主图号")
            strSql.Append("  left join M客户管理  on B订单管理 .客户编号 =M客户管理 .客户编号")
            strSql.Append("  left join Z生产实际录入  on Z生产实际录入.分图号 =Z生产自检录入.分图号 ")
            strSql.Append("  LEFT JOIN dbo.T流转票管理 ON T流转票管理.工序编号=dbo.Z生产自检录入.本道工序编号 AND  T流转票管理.产品图号 = Z生产实际录入. 分图号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  Z生产自检录入.订单编号 =" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "LoadAllexp"
    Public Function LoadAllexp(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" M人员管理.人员名" & vbCrLf)
            strSql.Append(",Z生产自检录入.主图号" & vbCrLf)
            strSql.Append(",Z生产自检录入.上级图号" & vbCrLf)
            strSql.Append(",Z生产自检录入.分图号" & vbCrLf)
            strSql.Append(",T流转票管理.工序名称" & vbCrLf)
            strSql.Append(",T流转票管理.工序编号" & vbCrLf)
            strSql.Append(",图纸尺寸" & vbCrLf)
            strSql.Append(",公差" & vbCrLf)
            strSql.Append(",自检时间" & vbCrLf)
            strSql.Append(",自检结果" & vbCrLf)
            strSql.Append(",不良品数量" & vbCrLf)
            strSql.Append(",待修品数量" & vbCrLf)
            strSql.Append(",报废品数量" & vbCrLf)
            strSql.Append(",Z生产自检录入.备注" & vbCrLf)
            strSql.Append(" FROM Z生产自检录入" & vbCrLf)
            strSql.Append("  left join M人员管理  on M人员管理 .人员编号 =Z生产自检录入 .作业者编号 ")
            strSql.Append("  LEFT JOIN dbo.T流转票管理 ON T流转票管理.工序编号=dbo.Z生产自检录入.本道工序编号 AND  T流转票管理.产品图号 = Z生产自检录入. 分图号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  订单编号 in ('" & objM生产自检T.订单编号 & "')" & vbCrLf)
            strSql.Append("AND 主图号  in ('" & objM生产自检T.主图号 & "')" & vbCrLf)
            strSql.Append("AND 上级图号 in ('" & objM生产自检T.上级图号 & "')" & vbCrLf)
            strSql.Append("AND 分图号 in ('" & objM生产自检T.分图号 & "')" & vbCrLf)
            strSql.Append("AND 本道工序编号 in ('" & objM生产自检T.本道工序编号 & "')" & vbCrLf)
            'If (objM生产自检T.自检日期sta <> "1900/1/1") Then
            '    strSql.Append(" AND 自检时间 >=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期sta) & vbCrLf)
            'End If

            'If (objM生产自检T.自检日期end <> "1900/1/1") Then
            '    strSql.Append(" AND 自检时间 <=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期end) & vbCrLf)
            'End If
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadGetCom"

    '检索全部数据

    Public Function LoadGetCom(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append("SELECT " & vbCrLf)
            strSql.Append("          [工序编号] " & vbCrLf)
            strSql.Append("         ,[工序名称] " & vbCrLf)
            strSql.Append("         ,[加工内容简介] " & vbCrLf)
            strSql.Append("         ,[作业场所] " & vbCrLf)
            strSql.Append("  FROM [HRJS].[dbo].[T流转票管理] " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE  产品图号=" & Utility.PFn_ChangeQuotation(objM生产自检T.分图号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	订单编号" & vbCrLf)
            strSql.Append(" FROM Z生产自检录入")
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号) & vbCrLf)

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


    Public Function LoadByWhere(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" 	0 as 选择  " & vbCrLf)
            strSql.Append("     ,M人员管理.人员名 AS 作业者 " & vbCrLf)
            strSql.Append(" 	,Z生产自检录入.订单编号  " & vbCrLf)
            strSql.Append(" 	,Z生产自检录入.主图号  " & vbCrLf)
            strSql.Append(" 	,z生产自检录入.上级图号    " & vbCrLf)
            strSql.Append(" 	,Z生产自检录入.分图号  " & vbCrLf)
            strSql.Append(" 	,T流转票管理.工序名称 本道工序  " & vbCrLf)
            strSql.Append(" 	,T流转票管理.工序编号 本道工序编号  " & vbCrLf)
            strSql.Append(" FROM Z生产自检录入" & vbCrLf)
            strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            strSql.Append(" ON B订单管理.订单编号=Z生产自检录入.订单编号 AND Z生产自检录入.主图号=B订单管理.产品图号 " & vbCrLf)
            strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            strSql.Append(" ON M人员管理 .人员编号 =Z生产自检录入.作业者编号 " & vbCrLf)
            strSql.Append(" LEFT JOIN dbo.T流转票管理" & vbCrLf)
            strSql.Append(" ON dbo.T流转票管理.产品图号 =Z生产自检录入.分图号  AND T流转票管理.工序编号 = dbo.Z生产自检录入.本道工序编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE 1=1" & vbCrLf)
            If objM生产自检T.作业者 <> String.Empty Then
                strSql.Append(" AND M人员管理.人员名 like '" & Utility.PFn_ChangeQuotation(objM生产自检T.作业者, True) & "%'" & vbCrLf)
            End If
            If (objM生产自检T.自检日期sta <> "1900/1/1") Then
                strSql.Append(" AND 自检时间 >=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期sta) & vbCrLf)
            End If

            If (objM生产自检T.自检日期end <> "1900/1/1") Then
                strSql.Append(" AND 自检时间 <=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期end) & vbCrLf)
            End If
            If objM生产自检T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z生产自检录入.订单编号='" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号, True) & "'" & vbCrLf)
            End If
            If objM生产自检T.分图号 <> String.Empty Then
                strSql.Append(" AND Z生产自检录入.分图号='" & Utility.PFn_ChangeQuotation(objM生产自检T.分图号, True) & "'" & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere1"

    '检索全部数据
    'tudo


    Public Function LoadByWhere1(ByVal objM生产自检T As Z生产自检录入T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append(" 	订单编号  " & vbCrLf)
            strSql.Append(" 	,图纸尺寸  " & vbCrLf)
            strSql.Append(" 	,公差  " & vbCrLf)
            strSql.Append(" 	,自检时间 自检日期  " & vbCrLf)
            strSql.Append(" 	,自检结果  " & vbCrLf)
            strSql.Append(" 	,不良品数量  " & vbCrLf)
            strSql.Append(" 	,待修品数量  " & vbCrLf)
            strSql.Append(" 	,报废品数量  " & vbCrLf)
            strSql.Append(" 	,Z生产自检录入.备注  " & vbCrLf)
            strSql.Append(" FROM Z生产自检录入" & vbCrLf)
            strSql.Append("  INNER JOIN M人员管理 ON M人员管理.人员编号=Z生产自检录入.作业者编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE 1=1" & vbCrLf)
            'If objM生产自检T.部门编号 <> String.Empty Then
            '    strSql.Append(" AND M人员管理.部门='" & Utility.PFn_ChangeQuotation(objM生产自检T.部门编号, True) & "%'" & vbCrLf)
            'End If
            'If objM生产自检T.作业方式 <> String.Empty Then
            '    strSql.Append(" AND 作业方式='" & Utility.PFn_ChangeQuotation(objM生产自检T.作业方式, True) & "%'" & vbCrLf)
            'End If
            If objM生产自检T.作业者 <> String.Empty Then
                strSql.Append(" AND M人员管理.人员名 like '" & Utility.PFn_ChangeQuotation(objM生产自检T.作业者, True) & "%'" & vbCrLf)
            End If
            If (objM生产自检T.自检日期sta <> "1900/1/1") Then
                strSql.Append(" AND 自检时间 >=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期sta) & vbCrLf)
            End If

            If (objM生产自检T.自检日期end <> "1900/1/1") Then
                strSql.Append(" AND 自检时间 <=" & Utility.PFn_ChangeQuotation(objM生产自检T.自检日期end) & vbCrLf)
            End If
            If objM生产自检T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z生产自检录入.订单编号='" & Utility.PFn_ChangeQuotation(objM生产自检T.订单编号, True) & "'" & vbCrLf)
            End If
            If objM生产自检T.分图号 <> String.Empty Then
                strSql.Append(" AND Z生产自检录入.分图号='" & Utility.PFn_ChangeQuotation(objM生产自检T.分图号, True) & "'" & vbCrLf)
            End If
            strSql.Append(" ORDER BY 自检时间")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
