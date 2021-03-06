Imports System.Text

Public Class DalZ生产检查管理T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO dbo.Z生产检查管理 " & vbCrLf)

            strSql.Append("( " & vbCrLf)
            strSql.Append("订单编号, " & vbCrLf)
            strSql.Append("主图号, " & vbCrLf)
            strSql.Append("上级图号, " & vbCrLf)
            strSql.Append("分图号, " & vbCrLf)
            strSql.Append("工序编号, " & vbCrLf)
            strSql.Append("检查数量, " & vbCrLf)
            strSql.Append("检查内容, " & vbCrLf)
            strSql.Append("不良数量, " & vbCrLf)
            strSql.Append("不良原因, " & vbCrLf)
            strSql.Append("处理结果, " & vbCrLf)
            strSql.Append("检查者编号, " & vbCrLf)
            strSql.Append("检查日期, " & vbCrLf)
            strSql.Append("备注 " & vbCrLf)
            
            strSql.Append("         ) " & vbCrLf)

            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            'strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.检查ID))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.订单编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.主图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.上级图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.分图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.工序编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.检查数量))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.检查内容))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.不良数量))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.不良原因))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.处理结果))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.检查者编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.检查日期))
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产检查管理T.备注))


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
    Public Function Update(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSQL As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSQL.AppendFormat(" UPDATE [HRJS].[dbo].[Z生产实际录入]" & vbCrLf)
            strSQL.AppendFormat("    SET " & vbCrLf)
            strSQL.AppendFormat("       订单编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.订单编号))
            strSQL.AppendFormat("       ,主图号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.主图号))
            strSQL.AppendFormat("       ,产品图号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.产品图号))
            strSQL.AppendFormat("       ,人员编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.人员编号))
            strSQL.AppendFormat("       ,作业日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业日期))
            strSQL.AppendFormat("       ,作业时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业时间))
            'strSQL.AppendFormat("       ,作业结束时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业结束时间))
            strSQL.AppendFormat("       ,作业方式= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业方式))
            strSQL.AppendFormat("       ,本道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号))
            'strSQL.AppendFormat("       ,上道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.上道工序))
            'strSQL.AppendFormat("       ,下道工序= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.下道工序))
            'strSQL.AppendFormat("       ,作业指示= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业指示))

            strSQL.AppendFormat("       ,完成日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.完成日期))
            ' strSQL.AppendFormat("       ,制造批量号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.制造批量号))
            strSQL.AppendFormat("       ,设备编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.设备编号))
            strSQL.AppendFormat("       ,实际生产数= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.实际生产数))
            ' strSQL.AppendFormat("       ,流转票编号= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.流转票编号))
            'strSQL.AppendFormat("       ,图纸尺寸= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.图纸尺寸))
            'strSQL.AppendFormat("       ,公差= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.公差))
            'strSQL.AppendFormat("       ,自检时间= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.自检时间))
            'strSQL.AppendFormat("       ,自检结果= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.自检结果))
            'strSQL.AppendFormat("       ,自检结果自评= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.自检结果自评))
            'strSQL.AppendFormat("       ,不良品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.不良品数量))
            'strSQL.AppendFormat("       ,待修品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.待修品数量))
            'strSQL.AppendFormat("       ,报废品数量= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.报废品数量))
            strSQL.AppendFormat("       ,更新者= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.更新者))
            strSQL.AppendFormat("       ,更新日期= {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.更新日期))

            strSQL.Append("  WHERE " & vbCrLf)
            strSQL.AppendFormat("    订单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.订单编号))

            Return strSQL.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal objM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM Z生产检查管理" & vbCrLf)
            strSql.Append(" WHERE 检查ID=" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查ID) & vbCrLf)
            'SQLに戻る

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal clsM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT A.检查ID ," & vbCrLf)
            strSql.Append("        A.检查者编号 ," & vbCrLf)
            strSql.Append("        B.人员名 AS 检查者名称 ," & vbCrLf)
            strSql.Append("        A.检查日期" & vbCrLf)
            strSql.Append(" FROM   dbo.Z生产检查管理 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 B ON A.检查者编号 = B.人员编号" & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE A.检查ID=" & Utility.PFn_ChangeQuotation(clsM生产检查管理T.检查ID) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region

#Region " LoadAllGrid "

    '检索全部数据
    Public Function LoadAllGrid(ByVal objM生产实际T As Z生产实际管理T) As String

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
            strSql.Append(" FROM    dbo.Z生产实际录入 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal clsM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT A.检查ID , " & vbCrLf)
            strSql.Append("        A.订单编号 , " & vbCrLf)
            strSql.Append("        A.主图号 , " & vbCrLf)
            strSql.Append("        A.上级图号 , " & vbCrLf)
            strSql.Append("        A.分图号 , " & vbCrLf)
            strSql.Append("        E.品名 AS 产品名称 , " & vbCrLf)
            strSql.Append("        A.工序编号 本道工序编号 , " & vbCrLf)
            strSql.Append("        C.工序名称 , " & vbCrLf)
            strSql.Append("        B.实际生产数 [生产数量(个)] , " & vbCrLf)
            strSql.Append("        A.检查内容 , " & vbCrLf)
            strSql.Append("        A.检查数量 AS [检查数量(个)] , " & vbCrLf)
            strSql.Append("        A.不良数量 AS [不良数量(个)] , " & vbCrLf)
            strSql.Append("        A.不良原因 , " & vbCrLf)
            strSql.Append("        D.名称 处理结果 , " & vbCrLf)
            strSql.Append("        A.备注 " & vbCrLf)
            strSql.Append(" FROM   DBO.Z生产检查管理 A " & vbCrLf)
            strSql.Append("        LEFT JOIN Z生产实际录入 B ON A.订单编号 = B.订单编号 " & vbCrLf)
            strSql.Append("                               AND A.主图号 = B.主图号 " & vbCrLf)
            strSql.Append("                               AND A.分图号 = B.分图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN T流转票管理 C ON B.分图号 = C.产品图号 " & vbCrLf)
            strSql.Append("                              AND B.本道工序编号 = C.工序编号 " & vbCrLf)
            strSql.Append("        LEFT JOIN DBO.VM质检状态 D ON D.区分 = A.处理结果 " & vbCrLf)
            strSql.Append("        LEFT JOIN DBO.T图纸管理 E ON B.分图号 = E.产品图号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE A.检查ID=" & Utility.PFn_ChangeQuotation(clsM生产检查管理T.检查ID) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load人员 "

    '检索全部数据
    Public Function Load人员(ByVal objM生产实际T As Z生产实际管理T) As String

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
            strSql.Append("WHERE  人员编号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.人员编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " Load订单 "

    '检索全部数据
    Public Function Load订单(ByVal objM生产实际T As Z生产实际管理T) As String

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
            strSql.Append("WHERE  订单编号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "LoadAll"
    Public Function LoadAll(ByVal objM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT" & vbCrLf)
            strSql.Append("        A.检查ID ," & vbCrLf)
            strSql.Append("        A.检查者编号 ," & vbCrLf)
            strSql.Append("        M人员管理.人员名 检查者名称 ," & vbCrLf)
            strSql.Append("        A.检查日期 ," & vbCrLf)
            strSql.Append("        A.订单编号 ," & vbCrLf)
            strSql.Append("        A.主图号 ," & vbCrLf)
            strSql.Append("        A.分图号 ," & vbCrLf)
            strSql.Append("        A.检查数量 ," & vbCrLf)
            strSql.Append("        A.检查内容 ," & vbCrLf)
            strSql.Append("        A.不良数量 ," & vbCrLf)
            strSql.Append("        A.不良原因 ," & vbCrLf)
            strSql.Append("        VM质检状态.名称 处理结果 ," & vbCrLf)
            strSql.Append("        A.备注" & vbCrLf)
            strSql.Append(" FROM   Z生产检查管理 A" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 ON dbo.M人员管理.人员编号 = A.检查者编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM质检状态 ON VM质检状态.区分 = A.处理结果" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE A.检查ID =" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查ID) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadGetCom"

    '检索全部数据

    Public Function LoadGetCom(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append("SELECT " & vbCrLf)
            strSql.Append("          [工序编号] " & vbCrLf)
            strSql.Append("         ,[工序名称] " & vbCrLf)
            strSql.Append("         ,[加工内容简介] " & vbCrLf)
            strSql.Append("         ,[作业场所] " & vbCrLf)
            'strSql.Append("      ,[设备编号] " & vbCrLf)
            'strSql.Append("      ,[备注] " & vbCrLf)
            'strSql.Append("      ,[登陆者] " & vbCrLf)
            'strSql.Append("      ,[登陆日期] " & vbCrLf)
            'strSql.Append("      ,[更新者] " & vbCrLf)
            'strSql.Append("      ,[更新日期] " & vbCrLf)
            strSql.Append("  FROM [HRJS].[dbo].[T流转票管理] " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE  产品图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.产品图号) & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPK"

    '检索全部数据

    Public Function LoadByPK(ByVal objM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	检查ID" & vbCrLf)
            strSql.Append(" FROM Z生产检查管理")
            '检索条件 设定
            strSql.Append(" WHERE 检查ID=" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查ID) & vbCrLf)

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


    Public Function LoadByWhere(ByVal objM生产检查管理T As Z生产检查管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT  DISTINCT" & vbCrLf)
            strSql.Append("        A.检查ID ," & vbCrLf)
            strSql.Append("        B.订单编号 ," & vbCrLf)
            strSql.Append("        B.主图号 ," & vbCrLf)
            strSql.Append("        B.上级图号 ," & vbCrLf)
            strSql.Append("        B.分图号 ," & vbCrLf)
            strSql.Append("        E.品名 AS 产品名称 ," & vbCrLf)
            strSql.Append("        C.工序名称 ," & vbCrLf)
            strSql.Append("        B.实际生产数 [生产数量(个)] ," & vbCrLf)
            strSql.Append("        A.检查内容 ," & vbCrLf)
            strSql.Append("        A.检查数量 ," & vbCrLf)
            strSql.Append("        A.不良数量 ," & vbCrLf)
            strSql.Append("        A.不良原因 ," & vbCrLf)
            strSql.Append("        D.名称 处理结果 ," & vbCrLf)
            strSql.Append("        A.备注 ," & vbCrLf)
            strSql.Append("        人员.人员名 检查者 ," & vbCrLf)
            strSql.Append("        A.检查日期" & vbCrLf)
            strSql.Append(" FROM   dbo.Z生产检查管理 A" & vbCrLf)
            strSql.Append("        INNER JOIN Z生产实际录入 B ON B.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("                               AND B.主图号 = A.主图号" & vbCrLf)
            strSql.Append("                               AND B.上级图号 = A.上级图号" & vbCrLf)
            strSql.Append("                               AND B.分图号 = A.分图号" & vbCrLf)
            strSql.Append("        LEFT JOIN T流转票管理 C ON B.分图号 = C.产品图号" & vbCrLf)
            strSql.Append("                              AND B.本道工序编号 = C.工序编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM质检状态 D ON D.区分 = A.处理结果" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 E ON B.分图号 = E.产品图号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M人员管理 人员 ON 人员.人员编号 = A.检查者编号" & vbCrLf)

            strSql.Append("WHERE 1=1" & vbCrLf)
            If Not String.IsNullOrEmpty(objM生产检查管理T.检查者编号) Then
                strSql.Append("     AND 检查者编号=" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查者编号) & vbCrLf)
            End If
            If (objM生产检查管理T.检查日期s <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 >=" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查日期s) & vbCrLf)
            End If

            If (objM生产检查管理T.检查日期e <> "1900/1/1") Then
                strSql.Append(" AND 检查日期 <=" & Utility.PFn_ChangeQuotation(objM生产检查管理T.检查日期e) & vbCrLf)
            End If
            If objM生产检查管理T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z生产实际录入.订单编号='" & Utility.PFn_ChangeQuotation(objM生产检查管理T.订单编号, True) & "'" & vbCrLf)
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadBodyAllexp"

    Public Function LoadBodyAllexp(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("     M人员管理.人员名 AS 作业者 " & vbCrLf)
            strSql.Append(" 	,作业日期  " & vbCrLf)
            strSql.Append(" 	,作业方式  " & vbCrLf)
            strSql.Append(" 	,作业时间  " & vbCrLf)

            strSql.Append(" 	,Z生产实际录入.订单编号  " & vbCrLf)
            strSql.Append(" 	,B订单管理.订单数量 AS 计划生产数量  " & vbCrLf)
            strSql.Append(" 	,Z生产实际录入.产品图号  " & vbCrLf)
            strSql.Append(" 	,实际生产数  " & vbCrLf)
            strSql.Append(" 	,设备编号  " & vbCrLf)
            strSql.Append(" 	,本道工序  " & vbCrLf)
            strSql.Append(" 	,上道工序  " & vbCrLf)
            strSql.Append(" 	,下道工序  " & vbCrLf)
            strSql.Append(" 	,完成日期  " & vbCrLf)
            strSql.Append(" FROM Z生产实际录入" & vbCrLf)
            strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            strSql.Append(" ON B订单管理.订单编号=Z生产实际录入.订单编号" & vbCrLf)
            strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            strSql.Append(" ON M人员管理 .人员编号 =Z生产实际录入.人员编号 " & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单.订单编号 in ('" & objM生产实际T.订单编号 & "')" & vbCrLf)
            If Not String.IsNullOrEmpty(objM生产实际T.产品图号) Then
                strSql.Append("   AND 订单.产品图号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.产品图号) & vbCrLf)
            End If

            strSql.Append("ORDER BY 订单接受日期" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region


End Class
