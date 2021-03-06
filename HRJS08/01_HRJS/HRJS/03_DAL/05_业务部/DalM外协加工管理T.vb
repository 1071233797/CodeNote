Imports System.Text

#Region "DalM外协加工管理T"
'------------------------------------------------------------------------------------
'   说明
'       DalM外协加工管理T数据库操作SQL文
'   创建人
'       
'   创建时间
'       2016/5/25
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM外协加工管理T

#Region "IsExists"

    Public Function IsExists外协订单编号(ByVal str外协订单编号 As String)

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT COUNT(1) " & vbCrLf)
            strSql.Append("FROM   B外协加工管理 " & vbCrLf)
            strSql.Append("WHERE  外协订单编号 = " & Utility.PFn_ChangeQuotation(str外协订单编号))

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B外协加工管理")         '采购表

            strSql.Append(" (外协计划单号")
            strSql.Append(" ,外协对象编号")
            strSql.Append(" ,订单编号")
            strSql.Append(" ,主图号")
            strSql.Append(" ,上级图号")
            strSql.Append(" ,分图号")
            strSql.Append(" ,外协计划状态")
            strSql.Append(" ,外协加工数量")
            strSql.Append(" ,外协加工工序编号")
            strSql.Append(" ,回厂日期")
            strSql.Append(" ,原材料编号")
            strSql.Append(" ,带料数量")
            strSql.Append(" ,加工单价")
            strSql.Append(" ,加工总金额")
            strSql.append(" ,审核状态")
            strSql.Append(" ,审核人")
            strSql.Append(" ,审核备注")
            strSql.Append(" ,备注")
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.主图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.上级图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.分图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.原材料编号))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.计划带料数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.实际带料数量))
            If cls外协加工T.加工单价 = "" Then
                strSql.AppendFormat("加工单价 =NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.加工单价))
            End If
            If cls外协加工T.加工总金额 = "" Then
                strSql.AppendFormat("加工总金额 =NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.加工总金额))
            End If
            If cls外协加工T.审核状态 = "" Or cls外协加工T.审核状态 = "0" Then
                strSql.Append(" 0, ")
                strSql.Append(" NULL, ")
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核状态))
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核人))
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核备注))
            End If
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.备注))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.作成者))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.登陆者))
            'strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.登陆日期))
            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

    Public Function Insert生产实绩_外协(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B外协加工管理")         '采购表

            strSql.Append(" (")
            strSql.Append(" 外协计划单号")
            strSql.Append(" ,外协对象编号")
            strSql.Append(" ,外协计划状态")
            strSql.Append(" ,订单编号")
            strSql.Append(" ,主图号")
            strSql.Append(" ,上级图号")
            strSql.Append(" ,分图号")
            strSql.Append(" ,外协加工数量")
            strSql.Append(" ,外协加工工序编号")
            strSql.Append(" ,回厂日期")
            strSql.Append(" ,作成者编号")
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态))

            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.主图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.上级图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.分图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.作成者编号))

            strSql.Append("  )" & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

    Public Function InsertNew初始管理(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try



            strSql.Append(" DELETE  FROM B外协加工管理 " & vbCrLf)
            strSql.Append(" WHERE   外协计划单号 ='' " & vbCrLf)
            strSql.Append("         AND 订单编号 = '" & cls外协加工T.订单编号 & "' " & vbCrLf)
            strSql.Append("         AND 主图号 =  '" & cls外协加工T.主图号 & "' " & vbCrLf)
            strSql.Append("         AND 上级图号 =  '" & cls外协加工T.上级图号 & "' " & vbCrLf)
            strSql.Append("         AND 分图号 =  '" & cls外协加工T.分图号 & "' " & vbCrLf)
            strSql.Append("         AND 外协加工工序编号 =  '" & cls外协加工T.外协工序 & "';  " & vbCrLf)


            strSql.Append(" INSERT INTO B外协加工管理")         '采购表
            strSql.Append(" (外协计划单号")
            strSql.Append(" ,外协对象编号")
            strSql.Append(" ,订单编号")
            strSql.Append(" ,主图号")
            strSql.Append(" ,上级图号")
            strSql.Append(" ,分图号")
            strSql.Append(" ,外协计划状态")
            strSql.Append(" ,外协加工数量")
            strSql.Append(" ,外协加工工序编号")
            strSql.Append(" ,回厂日期")
            strSql.Append(" ,原材料编号")
            strSql.Append(" ,带料数量")
            strSql.Append(" ,加工单价")
            strSql.Append(" ,加工总金额")
            strSql.Append(" ,审核状态")
            strSql.Append(" ,审核人")
            strSql.Append(" ,审核备注")
            strSql.Append(" ,备注")
            strSql.Append(")")

            strSql.Append(" VALUES ")

            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.订单编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.主图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.上级图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.分图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协加工数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.外协工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.原材料编号))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.计划带料数量))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.实际带料数量))
            If cls外协加工T.加工单价 = "" Then
                strSql.AppendFormat("加工单价 =NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.加工单价))
            End If
            If cls外协加工T.加工总金额 = "" Then
                strSql.AppendFormat("加工总金额 =NULL,")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.加工总金额))
            End If
            If cls外协加工T.审核状态 = "" Or cls外协加工T.审核状态 = "0" Then
                strSql.Append(" 0, ")
                strSql.Append(" NULL, ")
                strSql.Append(" NULL, ")
            Else
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核状态))
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核人))
                strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.审核备注))
            End If
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.备注))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.作成者))
            'strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.登陆者))
            'strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(cls外协加工T.登陆日期))
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
    Public Function Update(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE dbo.B外协加工管理 ") 'B外协加工管理
            strSql.Append(" SET ")

            strSql.AppendFormat(" 外协计划单号=" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号))
            strSql.AppendFormat(" ,外协对象编号=" & Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号))
            strSql.AppendFormat(" ,外协计划状态=" & Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态))
            strSql.AppendFormat(" ,回厂日期=" & Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1))
            strSql.AppendFormat(" ,原材料编号=" & Utility.PFn_ChangeQuotation(cls外协加工T.原材料编号))
            strSql.AppendFormat(" ,带料数量=" & Utility.PFn_ChangeQuotation(cls外协加工T.实际带料数量))
            strSql.AppendFormat(" ,加工单价=" & Utility.PFn_ChangeQuotation(cls外协加工T.加工单价))
            strSql.AppendFormat(" ,加工总金额=" & Utility.PFn_ChangeQuotation(cls外协加工T.加工总金额))
            strSql.AppendFormat(" ,备注=" & Utility.PFn_ChangeQuotation(cls外协加工T.备注))
            strSql.Append(" WHERE ")
            strSql.Append("   订单编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.订单编号) & vbCrLf)
            strSql.Append("   AND 主图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.主图号) & vbCrLf)
            strSql.Append("   AND 分图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.分图号) & vbCrLf)
            strSql.Append("   AND 上级图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.上级图号) & vbCrLf)
            strSql.Append("   AND 外协加工工序编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协工序) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Update审核 "

    '数据更新操作
    Public Function Update审核(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B外协加工管理 ") '采购表
            strSql.Append(" SET ")
            strSql.Append(" 审核状态=" & Utility.PFn_ChangeQuotation(cls外协加工T.审核状态))
            strSql.Append(" ,审核备注=" & Utility.PFn_ChangeQuotation(cls外协加工T.审核备注))
            strSql.Append(" ,审核人=" & Utility.PFn_ChangeQuotation(cls外协加工T.审核人) & vbCrLf)
            strSql.Append("WHERE 外协计划单号 in('" & cls外协加工T.外协订单编号 & "')")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B外协加工管理 ") '采购表)

            strSql.Append(" WHERE ")
            strSql.Append(" 外协计划单号 = " & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号)) '外协订单编号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadHead"

    Public Function LoadHead(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" 外协计划单号")           '外协订单编号
            strSql.Append(" ,B外协加工管理.外协对象编号")           '外协订单编号
            strSql.Append(" ,M外协对象管理.外协对象名称")           '外协对象

            strSql.Append("  FROM   B外协加工管理" & vbCrLf)
            strSql.Append("  INNER JOIN  M外协对象管理 ON B外协加工管理.外协对象编号=M外协对象管理.外协对象编号" & vbCrLf)

            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 外协计划单号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadBody"

    Public Function LoadBody(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)
            strSql.Append("         B外协加工管理.订单编号, ")
            strSql.Append("         B外协加工管理.主图号, ")
            strSql.Append("         B外协加工管理.分图号 , ")
            strSql.Append("         M客户管理.客户名称 , ")
            strSql.Append("         vm外协计划状态.名称 外协状态 ,")
            strSql.Append("         Z生产计划制定.投产数量 AS 外协加工数量 ,")
            strSql.Append("         T流转票管理.工序名称 AS 外协工序 ,")
            strSql.Append("         Z生产计划制定.小件完成期限 AS 完成日期,")
            strSql.Append("         回厂日期 ,")
            strSql.Append("         原材料编号,")
            strSql.Append("         带料数量 ,")
            strSql.Append("         加工单价, ")
            strSql.Append("         加工总金额,")
            strSql.Append("         B外协加工管理.备注,")
            'strSql.Append("         作成者," & vbCrLf)
            'strSql.Append("         B外协加工管理.客户编号," & vbCrLf)
            strSql.Append("         B外协加工管理.审核人," & vbCrLf)
            strSql.Append("         B外协加工管理.审核备注," & vbCrLf)
            strSql.Append("         T流转票管理.工序编号 AS 外协加工工序编号")
            strSql.Append(" FROM  B外协加工管理" & vbCrLf)
            strSql.Append("LEFT JOIN  B订单管理 ON   B订单管理.订单编号=B外协加工管理.订单编号 and B订单管理.产品图号=B外协加工管理.主图号" & vbCrLf)
            strSql.Append("LEFT JOIN  Z生产计划制定 ON   B订单管理.订单编号=Z生产计划制定.订单编号 and B订单管理.产品图号=Z生产计划制定.产品图号" & vbCrLf)
            strSql.Append("LEFT JOIN  T流转票管理 ON   T流转票管理.工序编号=B外协加工管理.外协加工工序编号 and T流转票管理.产品图号=B外协加工管理.分图号" & vbCrLf)
            strSql.Append("LEFT JOIN M客户管理 ON  B订单管理.客户编号=M客户管理.客户编号" & vbCrLf)
            strSql.Append("LEFT JOIN VM外协计划状态 ON  VM外协计划状态.区分=B外协加工管理.外协计划状态" & vbCrLf)
            strSql.Append(" WHERE 外协计划单号=" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "LoadAll"

    Public Function LoadAll(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT  " & vbCrLf)
            strSql.Append("         外协计划单号,")           '外协订单编号
            strSql.Append("         订单编号, ")
            strSql.Append("         分图号 产品图号, ")
            strSql.Append("         主图号, ")
            strSql.Append("         外协加工数量 ,")
            strSql.Append("         回厂日期 ,")
            strSql.Append("         带料数量 ,")
            strSql.Append("         加工单价, ")
            strSql.Append("         加工总金额,")
            strSql.Append("         备注")
            strSql.Append(" FROM  B外协加工管理" & vbCrLf)
            strSql.Append(" WHERE ")
            If cls外协加工T.外协订单编号 = "" Then
                strSql.Append("外协计划单号=NULL")
            Else
                strSql.Append(" 外协计划单号= " & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号) & vbCrLf)
            End If
            strSql.Append(" or  分图号=" & Utility.PFn_ChangeQuotation(cls外协加工T.分图号) & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPK "

    '检索全部数据
    Public Function LoadByPK(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" 外协计划单号")           '外协订单编号
            strSql.Append(" ,M外协对象管理.外协对象名称")           '外协对象

            strSql.Append("  FROM   B外协加工管理" & vbCrLf)
            strSql.Append("  INNER JOIN  M外协对象管理 ON B外协加工管理.外协对象编号=M外协对象管理.外协对象编号" & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 外协计划单号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByPKey实际外协 "

    '检索全部数据
    Public Function LoadByPKey实际外协(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT  " & vbCrLf)

            strSql.Append(" 外协加工工序编号 ")           '外协加工工序编号
            'strSql.Append(" ,M外协对象管理.外协对象名称")           '外协对象

            strSql.Append("  FROM   B外协加工管理" & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("   AND 订单编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.订单编号) & vbCrLf)
            strSql.Append("   AND 主图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.主图号) & vbCrLf)
            strSql.Append("   AND 分图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.分图号) & vbCrLf)
            strSql.Append("   AND 上级图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.上级图号) & vbCrLf)
            strSql.Append("   AND 外协加工工序编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协工序) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " 主图和分图存在CHECK "

    '检索全部数据
    Public Function Check主图分图(ByVal cls外协加工管理T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("SELECT * FROM dbo.T图纸关系 A " & vbCrLf)
            strSql.Append("INNER JOIN dbo.T图纸关系 B  " & vbCrLf)
            strSql.Append("ON B.关系ID = A.关系ID " & vbCrLf)
            strSql.Append("WHERE a.产品图号= " & Utility.PFn_ChangeQuotation(cls外协加工管理T.分图号) & vbCrLf)
            strSql.Append("AND b.产品图号= " & Utility.PFn_ChangeQuotation(cls外协加工管理T.主图号) & vbCrLf)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region "LoadBand0"

    Public Function LoadBand0(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try


            strSql.Append("SELECT  DISTINCT 0 选择," & vbCrLf)
            strSql.Append("          外协计划单号,")
            'strSql.Append("         主图号, " & vbCrLf)
            strSql.Append("         M外协对象管理.外协对象名称" & vbCrLf)
            strSql.Append(" FROM  B外协加工管理" & vbCrLf)
            strSql.Append("LEFT JOIN M外协对象管理 ON M外协对象管理.外协对象编号=B外协加工管理.外协对象编号" & vbCrLf)
            strSql.Append("WHERE  1=1 " & vbCrLf)
            strSql.Append("  AND 外协计划单号 is not null")
            If Not String.IsNullOrEmpty(cls外协加工T.外协订单编号) Then
                strSql.Append("     AND 外协计划单号 LIKE '" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.外协对象编号) Then
                strSql.Append("     AND M外协对象管理.外协对象编号 LIKE '" & Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.订单编号) Then
                strSql.Append("     AND B外协加工管理.订单编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.订单编号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.主图号) Then
                strSql.Append("     AND B外协加工管理.主图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.主图号) & vbCrLf)
            End If
            If (cls外协加工T.回厂日期1 <> "1900/1/1") Then
                strSql.Append(" AND 回厂日期 >=" & Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1) & vbCrLf)
            End If
            If (cls外协加工T.回厂日期2 <> "1900/1/1") Then
                strSql.Append(" AND 回厂日期 <" & Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期2.AddDays(1)) & vbCrLf)
            End If

            If Not String.IsNullOrEmpty(cls外协加工T.外协加工状态) Then
                strSql.Append("     AND B外协加工管理.外协计划状态 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态) & vbCrLf)
            End If
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region "LoadBand1"

    Public Function LoadBand1(ByVal cls外协加工T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("SELECT DISTINCT " & vbCrLf)
            strSql.Append("         外协计划单号, " & vbCrLf)
            strSql.Append("         B外协加工管理.主图号, " & vbCrLf)
            strSql.Append("         B外协加工管理.分图号, " & vbCrLf)
            strSql.Append("         B外协加工管理.订单编号 ," & vbCrLf)
            strSql.Append("         外协对象名称 外协对象, " & vbCrLf)
            strSql.Append("         外协加工数量 ," & vbCrLf)
            strSql.Append("         T流转票管理.工序名称 外协工序 ," & vbCrLf)
            strSql.Append("         VM外协计划状态.名称 外协计划状态 ," & vbCrLf)
            strSql.Append("         Z生产计划制定.小件完成期限 AS 完成日期 , " & vbCrLf)
            strSql.Append("         回厂日期 ," & vbCrLf)
            strSql.Append("         加工单价," & vbCrLf)
            strSql.Append("         加工总金额," & vbCrLf)
            strSql.Append("         带料数量, " & vbCrLf)
            strSql.Append("         VM审核状态.名称 审核状态," & vbCrLf)
            strSql.Append("         审核备注," & vbCrLf)
            strSql.Append("         B外协加工管理.备注" & vbCrLf)
            strSql.Append(" FROM  B外协加工管理" & vbCrLf)
            strSql.Append("LEFT JOIN Z生产计划制定 ON  Z生产计划制定.订单编号=B外协加工管理.订单编号 AND Z生产计划制定. 产品图号=B外协加工管理.主图号" & vbCrLf)
            strSql.Append("LEFT JOIN M外协对象管理 ON M外协对象管理.外协对象编号=B外协加工管理.外协对象编号" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.T流转票管理 ON T流转票管理.工序编号 = B外协加工管理.外协加工工序编号 AND T流转票管理.产品图号 = B外协加工管理.分图号" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.VM外协计划状态 ON VM外协计划状态.区分=B外协加工管理.外协计划状态" & vbCrLf)
            strSql.Append("LEFT JOIN dbo.VM审核状态 ON 审核状态=VM审核状态.区分" & vbCrLf)
            strSql.Append("WHERE  外协计划单号<>'' " & vbCrLf)
            If Not String.IsNullOrEmpty(cls外协加工T.外协订单编号) Then
                strSql.Append("     AND 外协计划单号 LIKE '" & Utility.PFn_ChangeQuotation(cls外协加工T.外协订单编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.外协对象编号) Then
                strSql.Append("     AND M外协对象管理.外协对象编号 LIKE '" & Utility.PFn_ChangeQuotation(cls外协加工T.外协对象编号, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.订单编号) Then
                strSql.Append("     AND B外协加工管理.订单编号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.订单编号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.主图号) Then
                strSql.Append("     AND B外协加工管理.主图号 =" & Utility.PFn_ChangeQuotation(cls外协加工T.主图号) & vbCrLf)
            End If
            If (cls外协加工T.回厂日期1 <> "1900/1/1") Then
                strSql.Append(" AND 回厂日期 >=" & Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期1) & vbCrLf)
            End If
            If (cls外协加工T.回厂日期2 <> "1900/1/1") Then
                strSql.Append(" AND 回厂日期 <" & Utility.PFn_ChangeQuotation(cls外协加工T.回厂日期2.AddDays(1)) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(cls外协加工T.外协加工状态) Then
                strSql.Append("     AND VM外协计划状态.区分 =" & Utility.PFn_ChangeQuotation(cls外协加工T.外协加工状态) & vbCrLf)
            End If
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsB外协加工管理T As B外协加工管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            
            strSql.Append("SELECT DISTINCT  ")
            If clsB外协加工管理T.区分 = 1 Then
                strSql.Append("        0  选择,")
            Else
                strSql.Append("        'true'  选择,")
            End If
            strSql.Append("         外协管理.订单编号 ,")
            strSql.Append("         外协管理.主图号 ,")
            strSql.Append("         外协管理.上级图号 ,")
            strSql.Append("         外协管理.分图号 ,")
            strSql.Append("         M客户管理.客户名称 ,")
            strSql.Append("         VM外协计划状态.名称 外协状态 ,")
            strSql.Append("         外协管理.外协加工数量 AS 外协加工数量 ,")
            strSql.Append("         流转票.工序名称 AS 外协工序 ,")
            'strSql.Append("         外协管理.回厂日期   完成日期 ,")
            strSql.Append("         外协管理.回厂日期 ,")
            strSql.Append("         外协管理.原材料编号 ,")
            strSql.Append("         外协管理.带料数量 ,")
            strSql.Append("         外协管理.加工单价 ,")
            strSql.Append("         外协管理.加工总金额 ,")
            strSql.Append("         外协管理.备注 ,")
            strSql.Append("         外协管理.审核状态 ,")
            strSql.Append("         外协管理.审核人 ,")
            strSql.Append("         外协管理.审核备注 ,")
            strSql.Append("         流转票.工序编号 外协加工工序编号")
            strSql.Append(" FROM    dbo.B外协加工管理 外协管理")
            strSql.Append("         LEFT JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 外协管理.分图号")
            strSql.Append("                                     AND 流转票.工序编号 = 外协管理.外协加工工序编号")
            strSql.Append("         LEFT JOIN dbo.B订单管理 订单 ON 订单.订单编号 = 外协管理.订单编号")
            strSql.Append("                                   AND 外协管理.主图号 = 订单.产品图号")
            strSql.Append("         LEFT JOIN dbo.M客户管理 ON M客户管理.客户编号 = 订单.客户编号")
            strSql.Append("         LEFT JOIN VM外协计划状态 ON VM外协计划状态.区分 = 外协管理.外协计划状态  ")
            strSql.Append(" WHERE 1=1 ")
            'If clsB外协加工管理T.区分 = 1 Then
            '    strSql.Append("WHERE   外协管理.外协计划状态='1'" & vbCrLf)
            'Else
            '    strSql.Append("WHERE   外协管理.外协计划状态<>'1'" & vbCrLf)
            'End If
            If Not String.IsNullOrEmpty(clsB外协加工管理T.外协订单编号) Then
                strSql.Append(" AND 外协管理.外协计划单号=" & Utility.PFn_ChangeQuotation(clsB外协加工管理T.外协订单编号) & vbCrLf)
            Else
                strSql.Append("")
            End If

            If clsB外协加工管理T.区分1 <> 1 Then
                strSql.Append("  AND 外协管理.外协计划单号 is null")
            End If
            If Not String.IsNullOrEmpty(clsB外协加工管理T.订单编号) Then
                strSql.Append(" AND 外协管理.订单编号=" & Utility.PFn_ChangeQuotation(clsB外协加工管理T.订单编号) & vbCrLf)
            End If
            If Not String.IsNullOrEmpty(clsB外协加工管理T.外协工序) Then
                strSql.Append(" AND 流转票.工序名称 LIKE '" & Utility.PFn_ChangeQuotation(clsB外协加工管理T.外协工序, True) & "%'")
            End If
            If Not String.IsNullOrEmpty(clsB外协加工管理T.主图号) Then
                strSql.Append(" AND 外协管理.主图号=" & Utility.PFn_ChangeQuotation(clsB外协加工管理T.主图号))
            End If
            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
End Class
