Imports System.Text


Public Class DalM外协申请一览T
#Region " Update "

    '数据更新操作
    Public Function Update(ByVal clsB外协申请一览T As B外协申请一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B外协申请一览 ") '采购表
            strSql.Append(" SET  " & vbCrLf)
            strSql.Append(" 外协计划状态= 1")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Load外协 "

    '检索全部数据
    Public Function Load外协(ByVal clsB外协申请一览T As B外协申请一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  * form B外协加工管理")

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsB外协申请一览T As B外协申请一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append(" SELECT  0 选择,")
            strSql.Append("         T图纸管理.产品图号 , ")
            strSql.Append("         M客户管理.客户编号 , ")
            strSql.Append("         M客户管理.客户名称 , ")
            strSql.Append("         CC.上级图号, ")
            strSql.Append("         CC.订单编号, ")
            strSql.Append("         CC.主图号  , ")
            strSql.Append("         Z生产计划制定.工序名称 AS 外协工序 ,")
            strSql.Append("         Z生产计划制定.下达日期 AS 外协申请日期 ,")
            strSql.Append("         Z生产计划制定.投产数量 AS 加工数量 ,")
            strSql.Append("         Z生产计划制定.完成日 AS 完成日期 ,")
            strSql.Append("         A.外协计划状态 ,")
            strSql.Append("         A.外协申请理由 , ")
            strSql.Append("         Z生产计划制定.作业者 AS 外协申请者")
            strSql.Append(" FROM    dbo.T图纸管理 ")
            strSql.Append(" INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号")
            strSql.Append("             INNER JOIN ( SELECT ddd.产品图号 上级图号 ,")
            strSql.Append("                                   aaa.CIID ,")
            strSql.Append("                        CASE WHEN aaa.CIID = 0 THEN 0" & vbCrLf)
            strSql.Append("                            ELSE aaa.CIID - bbb.ID + 1" & vbCrLf)
            strSql.Append("                              END ID ,")
            strSql.Append("                              aaa.产品图号 ,")
            strSql.Append("                              主号 ,")
            strSql.Append("                              bbb.订单编号 ,")
            strSql.Append("                              bbb.主图号 主图号" & vbCrLf)
            strSql.Append("         FROM   dbo.T图纸关系 aaa" & vbCrLf)
            strSql.Append("                  INNER JOIN ( SELECT ID ,")
            strSql.Append("                                      关系ID ,")
            strSql.Append("                                      T图纸关系.产品图号 主号 ,")
            strSql.Append("                                      B订单管理.订单编号 ,")
            strSql.Append("                                      B订单管理.产品图号 主图号" & vbCrLf)
            strSql.Append("                               FROM   T图纸关系" & vbCrLf)
            strSql.Append("                               INNER JOIN B订单管理 ON B订单管理.产品图号 = T图纸关系.产品图号" & vbCrLf)
            strSql.Append("                               WHERE  T图纸关系.CIID = 0" & vbCrLf)
            strSql.Append("                                       ) bbb ON bbb.关系ID = aaa.关系ID" & vbCrLf)
            strSql.Append("                                    LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID" & vbCrLf)
            strSql.Append("                                     ) CC ON CC.产品图号 = T图纸管理.产品图号" & vbCrLf)
            strSql.Append("   INNER JOIN dbo.Z生产计划制定 ON Z生产计划制定.订单编号 = CC.订单编号" & vbCrLf)

            strSql.Append("         AND Z生产计划制定.产品图号 = CC.产品图号 " & vbCrLf)
            strSql.Append("          inner join B外协申请一览 A on Z生产计划制定.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("WHERE 1=1" & vbCrLf)
            strSql.Append("AND Z生产计划制定.是否外协加工='1'")
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsB外协申请一览T As B外协申请一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT  0 选择,")
            strSql.Append("         T图纸管理.产品图号 , ")
            'strSql.Append("         M客户管理.客户编号 , ")
            strSql.Append("         M客户管理.客户名称 , ")
            strSql.Append("         CC.订单编号, ")
            strSql.Append("         CC.主图号  , ")
            strSql.Append("         Z生产计划制定.工序名称 AS 外协工序 ,")
            'strSql.Append("         Z生产计划制定.下达日期 AS 外协申请日期 ,")
            strSql.Append("         Z生产计划制定.投产数量 AS 加工数量 ,")
            strSql.Append("         Z生产计划制定.完成日 AS 完成日期 ,")
            strSql.Append("         A.外协计划状态 ,")
            strSql.Append("         A.外协申请理由 , ")
            strSql.Append("         Z生产计划制定.作业者 AS 外协申请者")
            strSql.Append(" FROM    dbo.T图纸管理 ")
            strSql.Append(" INNER JOIN dbo.M客户管理 ON M客户管理.客户编号 = T图纸管理.客户编号")
            strSql.Append("             INNER JOIN ( SELECT ddd.产品图号 上级图号 ,")
            strSql.Append("                                   aaa.CIID ,")
            strSql.Append("                        CASE WHEN aaa.CIID = 0 THEN 0" & vbCrLf)
            strSql.Append("                            ELSE aaa.CIID - bbb.ID + 1" & vbCrLf)
            strSql.Append("                              END ID ,")
            strSql.Append("                              aaa.产品图号 ,")
            strSql.Append("                              主号 ,")
            strSql.Append("                              bbb.订单编号 ,")
            strSql.Append("                              bbb.主图号 主图号" & vbCrLf)
            strSql.Append("         FROM   dbo.T图纸关系 aaa" & vbCrLf)
            strSql.Append("                  INNER JOIN ( SELECT ID ,")
            strSql.Append("                                      关系ID ,")
            strSql.Append("                                      T图纸关系.产品图号 主号 ,")
            strSql.Append("                                      B订单管理.订单编号 ,")
            strSql.Append("                                      B订单管理.产品图号 主图号" & vbCrLf)
            strSql.Append("                               FROM   T图纸关系" & vbCrLf)
            strSql.Append("                               INNER JOIN B订单管理 ON B订单管理.产品图号 = T图纸关系.产品图号" & vbCrLf)
            strSql.Append("                               WHERE  T图纸关系.CIID = 0" & vbCrLf)
            strSql.Append("                                       ) bbb ON bbb.关系ID = aaa.关系ID" & vbCrLf)
            strSql.Append("                                    LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID" & vbCrLf)
            strSql.Append("                                     ) CC ON CC.产品图号 = T图纸管理.产品图号" & vbCrLf)
            strSql.Append("   INNER JOIN dbo.Z生产计划制定 ON Z生产计划制定.订单编号 = CC.订单编号" & vbCrLf)

            strSql.Append("         AND Z生产计划制定.产品图号 = CC.产品图号 " & vbCrLf)
            strSql.Append("          inner join B外协申请一览 A on Z生产计划制定.订单编号 = A.订单编号" & vbCrLf)
            strSql.Append("WHERE 1=1" & vbCrLf)
            strSql.Append("AND Z生产计划制定.是否外协加工='1'")
            ''检索条件 设定
            If clsB外协申请一览T.订单编号 <> String.Empty Then
                strSql.Append(" AND Z生产计划制定.订单编号='" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.订单编号, True) & "'" & vbCrLf)
            End If
            If clsB外协申请一览T.产品图号 <> String.Empty Then
                strSql.Append(" AND Z生产计划制定.产品图号='" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.产品图号, True) & "'" & vbCrLf)
            End If

            If clsB外协申请一览T.外协工序 <> String.Empty Then
                strSql.Append(" AND A.外协工序 LIKE'" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.外协工序, True) & "%'" & vbCrLf)
            End If
            If clsB外协申请一览T.外协加工状态 <> String.Empty Then
                strSql.Append(" AND A.外协加工状态='" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.外协加工状态, True) & "'" & vbCrLf)
            End If
            If clsB外协申请一览T.外协申请日期起 <> "1900/1/1" Then
                strSql.Append(" AND Z生产计划制定.下达日期>=" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.外协申请日期起) & vbCrLf)
            End If
            If clsB外协申请一览T.外协申请日期止 <> "1900/1/1" Then
                strSql.Append(" AND Z生产计划制定.下达日期<=" & Utility.PFn_ChangeQuotation(clsB外协申请一览T.外协申请日期止) & vbCrLf)
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
