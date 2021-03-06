Imports System.Text

Public Class DalZ生产实际管理T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal objM生产实际T As Z生产实际管理T, ByVal int更新 As Integer) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" INSERT INTO dbo.Z生产实际录入 " & vbCrLf)
            strSql.Append("(订单编号, " & vbCrLf)
            strSql.Append("主图号, " & vbCrLf)
            strSql.Append("上级图号, " & vbCrLf)
            strSql.Append("分图号, " & vbCrLf)
            strSql.Append("作业者编号, " & vbCrLf)
            strSql.Append("作业日期, " & vbCrLf)
            strSql.Append("作业时间, " & vbCrLf)
            strSql.Append("作业方式, " & vbCrLf)
            strSql.Append("本道工序编号, " & vbCrLf)
            strSql.Append("设备编号, " & vbCrLf)
            strSql.Append("实际生产数, " & vbCrLf)
            strSql.Append("登陆者, " & vbCrLf)
            strSql.Append("登陆日期 " & vbCrLf)
            strSql.Append("         ) " & vbCrLf)
            strSql.Append("  VALUES" & vbCrLf)
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.订单编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.主图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.上级图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.分图号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业者编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业日期))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业时间))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.作业方式))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.设备编号))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.实际生产数))
            strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.登陆者))
            strSql.AppendFormat("  {0}" & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.登陆日期))
            strSql.Append(")" & vbCrLf)

            If int更新 = 1 Then
                strSql.Append(" IF ( SELECT COUNT(*) " & vbCrLf)
                strSql.Append("      FROM   dbo.T流转票管理 " & vbCrLf)
                strSql.Append("      WHERE  产品图号 = '" & objM生产实际T.分图号 & "' " & vbCrLf)
                strSql.Append("             AND 工序编号 = '" & objM生产实际T.本道工序编号 + 1 & "' " & vbCrLf)
                strSql.Append("             AND 外协加工 = 'True' " & vbCrLf)
                strSql.Append("    ) > 0 " & vbCrLf)
                strSql.Append("     INSERT  dbo.B外协加工管理 " & vbCrLf)
                strSql.Append("             ( 订单编号 , " & vbCrLf)
                strSql.Append("               主图号 , " & vbCrLf)
                strSql.Append("               上级图号 , " & vbCrLf)
                strSql.Append("               分图号 , " & vbCrLf)
                strSql.Append("               外协加工工序编号 , " & vbCrLf)
                strSql.Append("               外协加工数量 , " & vbCrLf)
                strSql.Append("               外协计划状态 " & vbCrLf)
                strSql.Append("             )VALUES  ( " & vbCrLf)
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.订单编号))
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.主图号))
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.上级图号))
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.分图号))
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号 + 1))
                strSql.AppendFormat("  {0}," & vbCrLf, Utility.PFn_ChangeQuotation(objM生产实际T.计划生产数))
                strSql.Append("              N'1' " & vbCrLf)
                strSql.Append("             ) " & vbCrLf)
            End If

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
    Public Function Delete(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM Z生产实际录入" & vbCrLf)
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)
            strSql.Append(" AND 主图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.主图号) & vbCrLf)
            strSql.Append(" AND 上级图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.上级图号) & vbCrLf)
            strSql.Append(" AND 分图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.分图号) & vbCrLf)
            strSql.Append(" AND 本道工序编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号) & vbCrLf)
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
    Public Function LoadAll(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT " & vbCrLf)
            strSql.Append("Z生产实际录入.作业者编号" & vbCrLf)
            strSql.Append(",M人员管理.人员名" & vbCrLf)
            strSql.Append(",M人员管理.职务" & vbCrLf)
            strSql.Append(",M部门管理.部门名称" & vbCrLf)
            strSql.Append(",Z生产实际录入.订单编号" & vbCrLf)
            strSql.Append(",M客户管理.客户名称" & vbCrLf)
            strSql.Append(",Z生产实际录入.上级图号" & vbCrLf)
            strSql.Append(",Z生产实际录入.分图号" & vbCrLf)
            strSql.Append(",T流转票管理 .工序编号" & vbCrLf)
            strSql.Append(",T流转票管理 .工序名称" & vbCrLf)
            strSql.Append(",T流转票管理.加工内容简介 作业指示" & vbCrLf)
            strSql.Append(",Z生产实际录入.设备编号" & vbCrLf)
            strSql.Append(",B订单管理.订单数量 as 计划生产数量" & vbCrLf)
            strSql.Append(",Z生产实际录入.作业日期" & vbCrLf)
            strSql.Append(",Z生产实际录入.主图号" & vbCrLf)
            strSql.Append(",作业方式" & vbCrLf)
            strSql.Append(",作业时间" & vbCrLf)
            'strSql.Append(",作业结束时间" & vbCrLf)
            strSql.Append(",实际生产数" & vbCrLf)
            ' strSql.Append(",不良品数量" & vbCrLf)
            ' strSql.Append(",待修品数量" & vbCrLf)
            ' strSql.Append(",报废品数量" & vbCrLf)
            strSql.Append(" FROM Z生产实际录入" & vbCrLf)
            strSql.Append("  left join M人员管理  on M人员管理 .人员编号 =Z生产实际录入 .作业者编号 ")
            strSql.Append("  left join M部门管理  on M人员管理 .部门 =M部门管理 .部门编号 ")
            strSql.Append("  left join B订单管理  on Z生产实际录入 .订单编号 =B订单管理 .订单编号 AND B订单管理.产品图号 = Z生产实际录入.主图号 ")
            strSql.Append("  left join M客户管理  on B订单管理 .客户编号 =M客户管理 .客户编号")
            strSql.Append("  left join T流转票管理  on Z生产实际录入.主图号 =T流转票管理 .产品图号 AND  T流转票管理.工序编号 = Z生产实际录入.本道工序编号" & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  Z生产实际录入.订单编号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)
            strSql.Append(" AND Z生产实际录入.分图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.分图号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function CheckOutSourcing(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" FROM    dbo.T流转票管理 " & vbCrLf)
            strSql.Append(" WHERE   产品图号 = " & Utility.PFn_ChangeQuotation(objM生产实际T.分图号) & vbCrLf)
            strSql.Append("         AND 工序编号 = " & Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号 + 1) & vbCrLf)
            strSql.Append("         AND 外协加工 = 'True' " & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region "SetData"
    Public Function SetData(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT" & vbCrLf)
            strSql.Append("        A.订单编号 ," & vbCrLf)
            strSql.Append("        A.主图号 ," & vbCrLf)
            strSql.Append("        A.分图号 ," & vbCrLf)
            strSql.Append("        E.品名 AS 产品名称 ," & vbCrLf)
            strSql.Append("        A.本道工序编号 ," & vbCrLf)
            strSql.Append("        C.工序名称 ," & vbCrLf)
            strSql.Append("        A.实际生产数 [生产数量(个)] ," & vbCrLf)
            strSql.Append("        B.检查内容 ," & vbCrLf)
            strSql.Append("        B.检查数量 AS [检查数量(个)] ," & vbCrLf)
            strSql.Append("        B.不良数量 AS [不良数量(个)] ," & vbCrLf)
            strSql.Append("        B.不良原因 ," & vbCrLf)
            strSql.Append("        D.名称 处理结果 ," & vbCrLf)
            strSql.Append("        B.备注" & vbCrLf)
            strSql.Append(" FROM   Z生产实际录入 A" & vbCrLf)
            strSql.Append("        LEFT JOIN Z生产检查管理 B ON B.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("                               AND B.主图号 = A.主图号" & vbCrLf)
            strSql.Append("                               AND B.分图号 = A.分图号" & vbCrLf)
            strSql.Append("        LEFT JOIN T流转票管理 C ON A.分图号 = C.产品图号" & vbCrLf)
            strSql.Append("                              AND A.本道工序编号 = C.工序编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM质检状态 D ON D.区分 = B.处理结果" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 E ON A.分图号 = E.产品图号" & vbCrLf)
            ' strSql.Append(" WHERE  A.订单编号 = N' ';" & vbCrLf)
            strSql.Append("WHERE  A.订单编号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)

            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
    Public Function SetData1(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT  DISTINCT" & vbCrLf)
            strSql.Append("        A.订单编号 ," & vbCrLf)
            strSql.Append("        A.主图号 ," & vbCrLf)
            strSql.Append("        A.上级图号 ," & vbCrLf)
            strSql.Append("        A.分图号 ," & vbCrLf)
            strSql.Append("        E.品名 AS 产品名称 ," & vbCrLf)
            strSql.Append("        A.本道工序编号 ," & vbCrLf)
            strSql.Append("        C.工序名称 ," & vbCrLf)
            strSql.Append("        A.实际生产数 [生产数量(个)] " & vbCrLf)

            strSql.Append(" FROM   Z生产实际录入 A" & vbCrLf)
            strSql.Append("        LEFT JOIN Z生产检查管理 B ON B.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("                               AND B.主图号 = A.主图号" & vbCrLf)
            strSql.Append("                               AND B.上级图号 = A.上级图号" & vbCrLf)
            strSql.Append("                               AND B.分图号 = A.分图号" & vbCrLf)
            strSql.Append("        LEFT JOIN T流转票管理 C ON A.分图号 = C.产品图号" & vbCrLf)
            strSql.Append("                              AND A.本道工序编号 = C.工序编号" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.VM质检状态 D ON D.区分 = B.处理结果" & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.T图纸管理 E ON A.分图号 = E.产品图号" & vbCrLf)
            ' strSql.Append(" WHERE  A.订单编号 = N' ';" & vbCrLf)
            strSql.Append("WHERE  A.订单编号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)

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

            strSql.Append("SELECT DISTINCT" & vbCrLf)
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

    Public Function LoadByPK(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try

            strSql.Append(" SELECT   " & vbCrLf)
            strSql.Append(" 	订单编号" & vbCrLf)
            strSql.Append(" 	,主图号" & vbCrLf)
            strSql.Append(" 	,分图号" & vbCrLf)
            strSql.Append(" 	,本道工序编号" & vbCrLf)
            strSql.Append(" FROM Z生产实际录入")
            '检索条件 设定
            strSql.Append(" WHERE 订单编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号) & vbCrLf)
            strSql.Append(" AND 主图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.主图号) & vbCrLf)
            strSql.Append(" AND 上级图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.上级图号) & vbCrLf)
            strSql.Append(" AND 分图号=" & Utility.PFn_ChangeQuotation(objM生产实际T.分图号) & vbCrLf)
            strSql.Append(" AND 本道工序编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.本道工序编号) & vbCrLf)

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


    Public Function LoadByWhere(ByVal objM生产实际T As Z生产实际管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("  SELECT DISTINCT " & vbCrLf)
            strSql.Append("         0 选择 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.订单编号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.主图号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.上级图号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.分图号 , " & vbCrLf)
            strSql.Append("         作业时间 , " & vbCrLf)
            strSql.Append("         作业方式 , " & vbCrLf)
            strSql.Append("         作业日期 , " & vbCrLf)
            strSql.Append("         本道工序编号 , " & vbCrLf)
            strSql.Append("         T流转票管理.工序名称 本道工序 , " & vbCrLf)
            strSql.Append("         Z生产计划制定.投产数量 * T图纸管理.数量 AS 计划生产数量 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.实际生产数 实际生产数量 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.设备编号 , " & vbCrLf)
            strSql.Append("         M人员管理.人员名 AS 作业者 " & vbCrLf)
            strSql.Append("  FROM   Z生产实际录入 " & vbCrLf)
            strSql.Append("         LEFT JOIN B订单管理 ON B订单管理.订单编号 = Z生产实际录入.订单编号 " & vbCrLf)
            strSql.Append("                            AND B订单管理.产品图号 = Z生产实际录入.主图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN T流转票管理 ON T流转票管理.工序编号 = Z生产实际录入.本道工序编号 " & vbCrLf)
            strSql.Append("                             AND T流转票管理.产品图号 = Z生产实际录入.分图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.Z生产计划制定 ON Z生产计划制定.订单编号 = Z生产实际录入.订单编号 " & vbCrLf)
            strSql.Append("                                  AND Z生产计划制定.产品图号 = B订单管理.产品图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN dbo.T图纸管理 ON T图纸管理.主图号 = Z生产实际录入.主图号 " & vbCrLf)
            strSql.Append("                                AND T图纸管理.上级图号 = Z生产实际录入.上级图号 " & vbCrLf)
            strSql.Append("                                AND T图纸管理.上级图号 = Z生产实际录入.上级图号 " & vbCrLf)
            strSql.Append("         LEFT JOIN M人员管理 ON M人员管理.人员编号 = Z生产实际录入.作业者编号 " & vbCrLf)
            strSql.Append("  WHERE  1 = 1 " & vbCrLf)
            If objM生产实际T.作业方式 <> String.Empty Then
                strSql.Append(" AND 作业方式=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业方式) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(objM生产实际T.作业者编号) Then
                strSql.Append("     AND Z生产实际录入.作业者编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业者编号) & vbCrLf)
            End If
            If (objM生产实际T.作业日期sta <> "1900/1/1") Then
                strSql.Append(" AND 作业日期 >=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业日期sta) & vbCrLf)
            End If

            If (objM生产实际T.作业日期end <> "1900/1/1") Then
                strSql.Append(" AND 作业日期 <=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业日期end) & vbCrLf)
            End If
            If objM生产实际T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z生产实际录入.订单编号='" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号, True) & "'" & vbCrLf)
            End If
            If objM生产实际T.产品图号 <> String.Empty Then
                strSql.Append(" AND Z生产实际录入.分图号='" & Utility.PFn_ChangeQuotation(objM生产实际T.产品图号, True) & "'" & vbCrLf)
            End If
            strSql.Append("  ORDER BY Z生产实际录入.订单编号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.主图号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.上级图号 , " & vbCrLf)
            strSql.Append("         Z生产实际录入.分图号 , " & vbCrLf)
            strSql.Append("         本道工序编号  " & vbCrLf)







            'strSql.Append(" SELECT    " & vbCrLf)
            'strSql.Append(" 	 0 选择  " & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入.订单编号  " & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入.主图号" & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入.上级图号" & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入.分图号" & vbCrLf)
            'strSql.Append(" 	,作业时间  " & vbCrLf)
            'strSql.Append(" 	,作业方式  " & vbCrLf)
            'strSql.Append(" 	,作业日期  " & vbCrLf)
            ''strSql.Append(" 	,完成日期  " & vbCrLf)
            'strSql.Append(" 	,T流转票管理.工序名称 本道工序" & vbCrLf)
            'strSql.Append(" 	,B订单管理.订单数量 AS 计划生产数量  " & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入. 实际生产数 实际生产数量 " & vbCrLf)
            'strSql.Append(" 	,Z生产实际录入.设备编号  " & vbCrLf)
            'strSql.Append("     ,M人员管理.人员名 AS 作业者 " & vbCrLf)
            'strSql.Append(" FROM Z生产实际录入" & vbCrLf)
            'strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            'strSql.Append(" ON B订单管理.订单编号=Z生产实际录入.订单编号 AND  B订单管理. 产品图号 = Z生产实际录入.主图号" & vbCrLf)
            'strSql.Append(" left join T流转票管理 on T流转票管理.工序编号 =Z生产实际录入.本道工序编号 AND T流转票管理.产品图号 = Z生产实际录入.分图号")
            'strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            'strSql.Append(" ON M人员管理 .人员编号 =Z生产实际录入.作业者编号 " & vbCrLf)
            ''检索条件 设定
            'strSql.Append("WHERE 1=1" & vbCrLf)
            ''If objM生产实际T.部门编号 <> String.Empty Then
            ''    strSql.Append(" AND M人员管理.部门='" & Utility.PFn_ChangeQuotation(objM生产实际T.部门编号, True) & "%'" & vbCrLf)
            ''End If
            'If objM生产实际T.作业方式 <> String.Empty Then
            '    strSql.Append(" AND 作业方式=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业方式) & vbCrLf)
            'End If
            'If Not String.IsNullOrEmpty(objM生产实际T.作业者编号) Then
            '    strSql.Append("     AND Z生产实际录入.作业者编号=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业者编号) & vbCrLf)
            'End If
            'If (objM生产实际T.作业日期sta <> "1900/1/1") Then
            '    strSql.Append(" AND 作业日期 >=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业日期sta) & vbCrLf)
            'End If

            'If (objM生产实际T.作业日期end <> "1900/1/1") Then
            '    strSql.Append(" AND 作业日期 <=" & Utility.PFn_ChangeQuotation(objM生产实际T.作业日期end) & vbCrLf)
            'End If
            'If objM生产实际T.订单编号 <> String.Empty Then
            '    strSql.Append(" AND Z生产实际录入.订单编号='" & Utility.PFn_ChangeQuotation(objM生产实际T.订单编号, True) & "'" & vbCrLf)
            'End If
            'If objM生产实际T.产品图号 <> String.Empty Then
            '    strSql.Append(" AND Z生产实际录入.分图号='" & Utility.PFn_ChangeQuotation(objM生产实际T.产品图号, True) & "'" & vbCrLf)
            'End If
            'strSql.Append(" ORDER BY 订单编号,主图号,上级图号,分图号,本道工序编号")
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
            strSql.Append(" 	Z生产实际录入.订单编号  " & vbCrLf)
            strSql.Append(" 	,Z生产实际录入.主图号" & vbCrLf)
            strSql.Append(" 	,Z生产实际录入.分图号" & vbCrLf)
            strSql.Append(" 	,作业时间  " & vbCrLf)
            strSql.Append(" 	,作业方式  " & vbCrLf)
            strSql.Append(" 	,作业日期  " & vbCrLf)
            'strSql.Append(" 	,完成日期  " & vbCrLf)
            strSql.Append(" 	,T流转票管理.工序名称 本道工序" & vbCrLf)
            strSql.Append(" 	,B订单管理.订单数量 AS 计划生产数量  " & vbCrLf)
            strSql.Append(" 	,Z生产实际录入. 实际生产数 实际生产数量 " & vbCrLf)
            strSql.Append(" 	,Z生产实际录入.设备编号  " & vbCrLf)
            strSql.Append("     ,M人员管理.人员名 AS 作业者 " & vbCrLf)
            strSql.Append(" FROM Z生产实际录入" & vbCrLf)
            strSql.Append(" LEFT JOIN B订单管理" & vbCrLf)
            strSql.Append(" ON B订单管理.订单编号=Z生产实际录入.订单编号 AND  B订单管理. 产品图号 = Z生产实际录入.主图号" & vbCrLf)
            strSql.Append(" left join T流转票管理 on T流转票管理.工序编号 =Z生产实际录入.本道工序编号 AND T流转票管理.产品图号 = Z生产实际录入.分图号")
            strSql.Append(" LEFT JOIN M人员管理" & vbCrLf)
            strSql.Append(" ON M人员管理 .人员编号 =Z生产实际录入.作业者编号 " & vbCrLf)
            '检索条件 设定
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND B订单管理.订单编号 in ('" & objM生产实际T.订单编号 & "')" & vbCrLf)
            strSql.Append("   AND T流转票管理.工序名称 in ('" & objM生产实际T.本道工序 & "')" & vbCrLf)

            If Not String.IsNullOrEmpty(objM生产实际T.产品图号) Then
                strSql.Append("   AND 订单.产品图号 =" & Utility.PFn_ChangeQuotation(objM生产实际T.产品图号) & vbCrLf)
            End If

            strSql.Append("ORDER BY 作业日期" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region


End Class
