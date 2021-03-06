Imports System.Text

#Region "Dal原材料出库申请"
'------------------------------------------------------------------------------------
'   说明
'       原材料出库申请的数据库操作SQL文
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/29
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalZ外协品出库申请T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B外协品出库申请")          '外协品出库申请

            strSql.Append(" (申请单编号")          '申请单编号
            strSql.Append(" ,申请者编号")          '申请者编号
            strSql.Append(" ,申请日期")           '领料日期
            strSql.Append(" ,备注")           '领料重量
            strSql.Append(" ,订单编号")           '领料重量
            strSql.Append(" ,主图号")           '订单编号
            strSql.Append(" ,上级图号")           '订单编号
            strSql.Append(" ,分图号")           '材料编号
            strSql.Append(" ,外协品名称")           '领料数量
            strSql.Append(" ,出库数量")           '产品图号
            strSql.Append(" ,工序编号")           '产品图号


           
            strSql.Append(")")
            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            '申请单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号))
            '申请者编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请者编号))
            '领料日期
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.订单编号))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.主图号))
            '订单编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.上级图号))
            '材料编号
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.分图号))
            '领料数量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.外协品名称))
            '领料重量
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.出库数量))
            '领料重量
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协品出库申请T.工序编号))
            
           
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
    Public Function Update(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE 外协品出库申请 ") '外协品出库申请
            strSql.Append(" SET ")

            '申请单编号

            '申请者编号

            '领料日期

            '材料编号

            '领料数量

            '领料重量

            '订单编号

            '产品图号

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

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B外协品出库申请 ") '外协品出库申请)

            strSql.Append(" WHERE 申请单编号=" & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " 主图和分图存在CHECK "

    '检索全部数据
    Public Function Check主图分图(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT * FROM dbo.T图纸关系 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T图纸关系 B  " & vbCrLf)
            strSql.Append("ON B.关系ID = A.关系ID " & vbCrLf)
            strSql.Append("WHERE a.产品图号= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.产品图号) & vbCrLf)
            strSql.Append("AND b.产品图号= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.主图号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT   A.订单编号, " & vbCrLf)
            strSql.Append("  A.主图号, " & vbCrLf)
            strSql.Append("  A.上级图号, " & vbCrLf)
            strSql.Append("  B.品名 AS 外协品名称," & vbCrLf)
            strSql.Append("  A.外协数量 AS 出库数量," & vbCrLf)
            strSql.Append("  C.工序名称 AS 外协工序," & vbCrLf)
            strSql.Append("  C.工序编号" & vbCrLf)
            strSql.Append("  FROM dbo.Z生产计划制定 A" & vbCrLf)
            strSql.Append("  INNER JOIN dbo.T图纸管理 B ON B.产品图号 = A.分图号" & vbCrLf)
            strSql.Append("  INNER JOIN dbo.T流转票管理 C ON C.产品图号 = A.分图号" & vbCrLf)
            strSql.Append("   AND C.工序编号 = A.工序编号" & vbCrLf)
            strSql.Append(" WHERE A.订单编号=" & Utility.PFn_ChangeQuotation(cls外协品出库申请T.订单编号) & vbCrLf)
            strSql.Append(" AND A.工序编号=" & Utility.PFn_ChangeQuotation(cls外协品出库申请T.工序编号) & vbCrLf)
            strSql.Append(" AND A.分图号=" & Utility.PFn_ChangeQuotation(cls外协品出库申请T.分图号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Set订单 "

    '检索全部数据
    Public Function Set订单(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT   A.订单编号 " & vbCrLf)
            strSql.Append("         ,产品图号 " & vbCrLf)
            strSql.Append("         ,M客户管理.客户名称 " & vbCrLf)
            strSql.Append(" FROM    B订单管理 A ")
            strSql.Append(" INNER JOIN  M客户管理 ")
            strSql.Append(" ON  B订单管理.客户编号 = M客户管理.客户编号 ")
            strSql.Append(" WHERE A.订单编号=" & Utility.PFn_ChangeQuotation(cls外协品出库申请T.订单编号) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '检索全部数据
    Public Function LoadByPKey(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  申请单编号 , ")
            strSql.Append("         申请者编号  ")
            strSql.Append(" FROM    dbo.B外协品出库申请")
            strSql.Append(" WHERE   申请单编号= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据
    Public Function LoadAllHead(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT A.申请单编号 , " & vbCrLf)
            strSql.Append("        申请者编号 , " & vbCrLf)
            strSql.Append("        B.人员名 申请者名称, " & vbCrLf)
            strSql.Append("        职务 , " & vbCrLf)
            strSql.Append("        部门 , " & vbCrLf)
            strSql.Append("        A.申请日期,A.备注 " & vbCrLf)
            strSql.Append(" FROM   dbo.B外协品出库申请 A " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 " & vbCrLf)
            strSql.Append(" WHERE  A.申请单编号 = " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadGridAll "

    '检索全部数据
    Public Function LoadGridAll(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT A.订单编号, " & vbCrLf)
            strSql.Append("       A.主图号, " & vbCrLf)
            strSql.Append("       A.上级图号, " & vbCrLf)
            strSql.Append("       A.分图号," & vbCrLf)
            strSql.Append("       A.外协品名称, " & vbCrLf)
            strSql.Append("       A.出库数量, " & vbCrLf)
            strSql.Append("       B.工序名称 AS 外协工序, " & vbCrLf)
            strSql.Append("       A.工序编号 " & vbCrLf)
            strSql.Append("FROM dbo.B外协品出库申请 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T流转票管理 B ON B.产品图号 = A.分图号 " & vbCrLf)
            strSql.Append("AND B.工序编号 = A.工序编号 " & vbCrLf)
            strSql.Append(" WHERE  申请单编号= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT DISTINCT ")
            strSql.Append("         0 AS 选择 , ")
            strSql.Append("         A.申请单编号 , ")
            strSql.Append("         B.人员名 申请者 , ")
            strSql.Append("         B.职务 , ")
            strSql.Append("         B.部门 , ")
            strSql.Append("         A.申请日期 , ")
            strSql.Append("         B.人员名 作成者, ")
            strSql.Append("         A.备注 ")
            strSql.Append(" FROM    dbo.B外协品出库申请 A ")
            strSql.Append("         INNER JOIN dbo.M人员管理 B ON A.申请者编号 = B.人员编号 ")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls外协品出库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND A.申请单编号 = " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)
            End If

            If (cls外协品出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 >= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.开始日期) & vbCrLf)
            End If

            If (cls外协品出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND A.申请日期 <= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.结束日期) & vbCrLf)
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
    Public Function LoadByWhere1(ByVal cls外协品出库申请T As Z外协品出库申请T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT DISTINCT")
            strSql.Append("        申请单编号 ,")
            strSql.Append("        订单编号 ,")
            strSql.Append("        主图号 ,")
            strSql.Append("        上级图号 ,")
            strSql.Append("        分图号 ,")
            strSql.Append("        外协品名称 ,")
            strSql.Append("        出库数量 [申请数量（个）]" & vbCrLf)
            strSql.Append("FROM    dbo.B外协品出库申请 " & vbCrLf)
            strSql.Append("         INNER JOIN dbo.M人员管理 ON B外协品出库申请.申请者编号 = M人员管理.人员编号 ")
            strSql.Append(" WHERE   1 = 1 ")
            If (cls外协品出库申请T.申请单编号 <> String.Empty) Then
                strSql.Append(" AND 申请单编号 = " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.申请单编号) & vbCrLf)
            End If

            If (cls外协品出库申请T.开始日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 >= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.开始日期) & vbCrLf)
            End If

            If (cls外协品出库申请T.结束日期 <> "1900/1/1") Then
                strSql.Append(" AND 申请日期 <= " & Utility.PFn_ChangeQuotation(cls外协品出库申请T.结束日期) & vbCrLf)
            End If

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
