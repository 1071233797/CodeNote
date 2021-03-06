Imports System.Text

#Region "DalM外协品入库申请T"
'------------------------------------------------------------------------------------
'   说明
'       外协品库入申请的数据库操作SQL文
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM外协品入库申请T
#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B外协品入库申请")          '外协品入库申请

            strSql.Append("(申请单编号")
            strSql.Append(" ,申请者编号")
            strSql.Append(" ,申请日期")
            strSql.Append(" ,订单编号")
            strSql.Append(" ,主图号")
            strSql.Append(" ,上级图号")
            strSql.Append(" ,分图号")
            strSql.Append(" ,外协加工工序编号")
            strSql.Append(" ,入库数量")
            strSql.Append(" ,单重")
            strSql.Append(" ,备注")
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请者编号))
            '申请日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请日期1))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.订单编号))
            '主图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.主图号))
            '上级图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.上级图号))
            '产品图号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号))
            '外协计划单()
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.外协加工工序编号))
            '入库数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.入库数量))
            '单重
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.单重))
            '更新日期
            strSql.AppendFormat(" {0} " & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.备注))
            strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls原材料入库申请T As B原材料入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE 原材料入库申请 ") '原材料入库申请
            strSql.Append(" SET ")

            '申请单编号

            '申请者编号

            '申请日期

            '材料编号

            '入库数量

            '入库重量

            '订单编号

            '产品图号

            '质检状态

            '登陆者

            '登陆日期

            '更新者

            '更新日期

            strSql.Append(" WHERE ")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Updatezj "

    '数据更新操作
    Public Function Updatezj(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B外协品入库申请 ") '原材料入库申请
            strSql.Append(" SET ")
            strSql.AppendFormat(" 检查者编号={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.检查者编号))
            strSql.AppendFormat(" ,异常数量={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.异常数量))
            strSql.AppendFormat(" ,异常原因={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.异常原因))
            strSql.AppendFormat(" ,备注={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.备注))

            strSql.AppendFormat(" ,质检状态={0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.质检状态))


            strSql.Append("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" DELETE FROM B外协品入库申请" & vbCrLf)
            strSql.Append(" WHERE  1=1" & vbCrLf)
            strSql.Append(" AND 申请单编号 =  '" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号, True) & "'" & vbCrLf)
            'SQLに戻る

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Deletezj "

    '数据删除操作
    Public Function Deletezj(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" UPDATE B原材料入库申请 ") '原材料入库申请
            strSql.Append(" SET ")
            strSql.AppendFormat(" 检查者编号=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.检查者编号))
            strSql.AppendFormat(" ,异常数量=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.异常数量))
            strSql.AppendFormat(" ,异常原因=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.异常原因))
            strSql.AppendFormat(" ,备注=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.备注))

            strSql.AppendFormat(" ,质检状态=NULL" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.质检状态))

            strSql.Append("  WHERE " & vbCrLf)
            strSql.AppendFormat("    申请单编号 = {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号))


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " 主图和分图存在CHECK "

    '检索全部数据
    Public Function Check主图分图(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT * FROM dbo.T图纸关系 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T图纸关系 B  " & vbCrLf)
            strSql.Append("ON B.关系ID = A.关系ID " & vbCrLf)
            strSql.Append("WHERE a.产品图号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号) & vbCrLf)
            strSql.Append("AND b.产品图号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.主图号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号  ")
            strSql.Append(" FROM    dbo.B外协品入库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         B.人员名 申请者名称 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.申请日期 ")
            strSql.Append(" FROM    dbo.B外协品入库申请 a ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B  ")
            strSql.Append("         ON a.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT")
            strSql.Append("        B外协加工管理.订单编号 ,")
            strSql.Append("        B外协加工管理.主图号 ,")
            strSql.Append("        B外协加工管理.上级图号 ,")
            strSql.Append("        B外协加工管理.分图号 ,")
            strSql.Append("        T图纸管理.品名 外协品名称 ,")
            strSql.Append("        T流转票管理.工序名称 加工工序 ,")
            strSql.Append("        dbo.B外协品入库申请.备注 ,")
            strSql.Append("        '' [入库数量（个）] ,")
            strSql.Append("        B外协品入库申请.单重 ,")
            strSql.Append("        T图纸管理.图纸,")
            strSql.Append("        T流转票管理.工序编号")
            strSql.Append(" FROM   B外协加工管理")
            strSql.Append("        inner JOIN T图纸管理 ON T图纸管理.主图号 = B外协加工管理.主图号 AND T图纸管理.产品图号 = B外协加工管理.分图号 AND T图纸管理.上级图号 = B外协加工管理.上级图号")
            strSql.Append("        LEFT  JOIN dbo.B外协品入库申请 ON B外协品入库申请.主图号 = B外协加工管理.主图号 AND B外协品入库申请.分图号 = B外协加工管理.分图号 AND B外协品入库申请.上级图号 = B外协加工管理.上级图号" & vbCrLf)
            strSql.Append("        LEFT  JOIN dbo.T流转票管理 ON T流转票管理.工序编号 = B外协加工管理.外协加工工序编号 AND T流转票管理.产品图号=B外协加工管理.分图号" & vbCrLf)

            strSql.Append(" WHERE   " & vbCrLf)
            strSql.Append("    B外协加工管理.外协计划状态='3'" & vbCrLf)
            'If cls外协品入库申请T.产品图号 = String.Empty Then
            '    strSql.Append(" OR B外协加工管理.分图号=" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号) & vbCrLf)
            'Else
            strSql.Append(" AND B外协加工管理.分图号=" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号) & vbCrLf)
            'End If
            strSql.Append(" ORDER BY T流转票管理.工序编号 DESC")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " SetData1 "

    '检索全部数据
    Public Function SetData1(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT")
            strSql.Append("        B外协品入库申请.订单编号 ,")
            strSql.Append("        B外协品入库申请.主图号 ,")
            strSql.Append("        B外协品入库申请.上级图号 ,")
            strSql.Append("        B外协品入库申请.分图号 ,")
            strSql.Append("        T图纸管理.品名 外协品名称 ,")
            strSql.Append("        T流转票管理.工序名称 加工工序 ,")
            strSql.Append("        dbo.B外协品入库申请.备注 ,")
            strSql.Append("        B外协品入库申请.入库数量 [入库数量（个）] ,")
            strSql.Append("        B外协品入库申请.单重 ,")
            strSql.Append("        T图纸管理.图纸 ,")
            strSql.Append("        T流转票管理.工序编号" & vbCrLf)
            strSql.Append(" FROM   B外协品入库申请" & vbCrLf)
            strSql.Append("        INNER JOIN T图纸管理 ON T图纸管理.主图号 = B外协品入库申请.主图号")
            strSql.Append("                            AND T图纸管理.产品图号 = B外协品入库申请.分图号")
            strSql.Append("                            AND T图纸管理.上级图号 = B外协品入库申请.上级图号")
            strSql.Append("        LEFT  JOIN dbo.T流转票管理 ON T流转票管理.工序编号 = B外协品入库申请.外协加工工序编号")
            strSql.Append("                                 AND T流转票管理.产品图号 = B外协品入库申请.分图号" & vbCrLf)
            strSql.Append(" WHERE   " & vbCrLf)
            strSql.Append("  B外协品入库申请.申请单编号=" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)
            'End If
            strSql.Append(" ORDER BY T流转票管理.工序编号 DESC")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "查询工序"
    Public Function LoadGetCom(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  外协加工工序编号 工序编号 ,")
            strSql.Append("        工序名称" & vbCrLf)
            strSql.Append("FROM    dbo.B外协加工管理")
            strSql.Append("        INNER JOIN dbo.T流转票管理 ON B外协加工管理.外协加工工序编号 = T流转票管理.工序编号")
            strSql.Append("                                 AND B外协加工管理.分图号 = T流转票管理.产品图号" & vbCrLf)
            strSql.Append("WHERE   分图号 =" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号) & vbCrLf)
            strSql.Append("ORDER BY 工序编号 DESC")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  distinct ")
            strSql.Append("         申请单编号 , ")
            strSql.Append("         申请者 , ")
            strSql.Append("         职务 , ")
            strSql.Append("         部门, ")
            strSql.Append("         申请日期, ")
            strSql.Append("         订单编号, ")
            strSql.Append("         D.客户名称 订单客户名称, ")
            strSql.Append("         B.外协加工数量 [入库数量(个)] , ")
            strSql.Append("         单重 ")
            strSql.Append(" FROM    dbo.B外协品入库申请 A ")
            strSql.Append("         LEFT JOIN dbo.B外协加工管理 B ON A.主图号 = B.主图号 ")
            strSql.Append("         INNER JOIN dbo.B订单管理 C ON A.订单编号 = C.订单编号 ")
            strSql.Append("         INNER JOIN dbo.M客户管理 D ON D.客户编号 = C.客户编号 ")
            strSql.Append(" WHERE   A.申请单编号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  distinct ")
            strSql.Append("         A.申请单编号 , ")
            strSql.Append("         A.申请者编号 , ")
            strSql.Append("         E.人员名 , ")
            strSql.Append("         E.职务 , ")
            strSql.Append("         E.部门 , ")
            strSql.Append("         A.订单编号 , ")
            strSql.Append("         A.主图号 , ")
            strSql.Append("         A.分图号 , ")
            strSql.Append("         F.品名 外协品名称, ")
            strSql.Append("         B.工序名称 加工工序, ")
            strSql.Append("         A.备注, ")
            strSql.Append("         A.入库数量, ")
            strSql.Append("         A.单重 , ")
            strSql.Append("         F.图纸  ")
            strSql.Append(" FROM    dbo.B外协品入库申请 A ")
            strSql.Append("         LEFT JOIN dbo.T流转票管理 B ON A.外协加工工序编号 = B.工序编号 AND A.分图号 = B.产品图号")
            strSql.Append("         LEFT JOIN dbo.T图纸管理 F ON A.分图号 = F.产品图号 ")
            strSql.Append("         LEFT JOIN dbo.M人员管理 E ON A.申请者编号 = E.人员编号 ")
            strSql.Append(" WHERE  " & vbCrLf)
            strSql.Append(" 申请单编号=" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)
            If Not String.IsNullOrEmpty(cls外协品入库申请T.产品图号) Then
                strSql.Append(" AND   A.分图号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.产品图号) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAllzj "

    '检索全部数据
    Public Function LoadAllzj(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  distinct ")
            strSql.Append("         0 选择 , ")
            strSql.Append("         A.主图号 , ")
            strSql.Append("         A.产品图号 , ")
            strSql.Append("         F.品名 , ")
            strSql.Append("         A.申请日期 , ")
            strSql.Append("         E.人员名 申请者名称 , ")
            strSql.Append("         A.入库数量, ")
            strSql.Append("         A.单重, ")
            strSql.Append("         A.异常数量, ")
            strSql.Append("         A.异常原因, ")
            strSql.Append("         A.备注, ")
            strSql.Append("        A.质检状态 ")

            strSql.Append(" FROM    dbo.B外协品入库申请 A ")
            strSql.Append("         LEFT JOIN dbo.B外协加工管理 B ON A.主图号 = B.主图号 ")
            strSql.Append("         INNER JOIN dbo.T图纸管理 F ON A.产品图号 = F.产品图号 ")
            strSql.Append("         INNER JOIN dbo.B订单管理 C ON F.产品图号 = C.产品图号 ")
            strSql.Append("         INNER JOIN dbo.M客户管理 D ON D.客户编号 = C.客户编号 ")
            strSql.Append("         INNER JOIN dbo.M人员管理 E ON A.申请者编号 = E.人员编号 ")
            strSql.Append(" WHERE   A.订单编号= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.订单编号) & vbCrLf)
            strSql.Append("or 申请单编号=" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT ")
            strSql.Append("         0 选择 , ")
            strSql.Append("         A.申请单编号 , ")
            strSql.Append("         申请者编号 , ")
            strSql.Append("         B.人员名 申请者 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         申请日期  ")
            strSql.Append(" FROM    dbo.B外协品入库申请 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append("         LEFT JOIN Z半成品入库质检 C ON C.申请单编号=A.申请单编号")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls外协品入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND A.申请单编号 like'" & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号, True) & "%'")
            End If
            If (cls外协品入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls外协品入库申请T.质检状态 <> String.Empty) Then
                strSql.Append(" AND C.处理结果 = " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.质检状态) & vbCrLf)
            End If

            If (cls外协品入库申请T.申请日期1 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请日期1) & vbCrLf)
            End If

            If (cls外协品入库申请T.申请日期2 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请日期2) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere1 "

    '检索全部数据
    Public Function LoadByWhere1(ByVal cls外协品入库申请T As B外协品入库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT distinct")
            strSql.Append("         B外协品入库申请.申请单编号 ,")
            strSql.Append("         B外协品入库申请.订单编号 ,")
            strSql.Append("         B外协品入库申请.主图号 ,")
            strSql.Append("         B外协品入库申请.上级图号 ,")
            strSql.Append("         B外协品入库申请.分图号 ,")
            strSql.Append("         T图纸管理.品名 外协品名称, ")
            strSql.Append("         入库数量 [入库数量(个)],  ")
            strSql.Append("         '' AS 隐藏, ")
            strSql.Append("         Z半成品入库质检.处理结果 质检状态  ")
            strSql.Append(" FROM    dbo.B外协品入库申请  " & vbCrLf)
            strSql.Append(" LEFT JOIN T图纸管理  ON T图纸管理.产品图号=B外协品入库申请.分图号" & vbCrLf)
            strSql.Append(" LEFT JOIN Z半成品入库质检  ON Z半成品入库质检.申请单编号=B外协品入库申请.申请单编号")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls外协品入库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND B外协品入库申请.申请单编号 like' " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请单编号, True) & "%'")
            End If
            If (cls外协品入库申请T.申请者编号 <> String.Empty) Then
                strSql.Append(" AND 申请者编号 = " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请者编号) & vbCrLf)
            End If

            If (cls外协品入库申请T.质检状态 <> String.Empty) Then
                strSql.Append(" AND Z半成品入库质检.处理结果 = " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.质检状态) & vbCrLf)
            End If

            If (cls外协品入库申请T.申请日期1 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 >= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请日期1) & vbCrLf)
            End If

            If (cls外协品入库申请T.申请日期2 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 <= " & Utility.PFn_ChangeQuotation(cls外协品入库申请T.申请日期2) & vbCrLf)
            End If
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
