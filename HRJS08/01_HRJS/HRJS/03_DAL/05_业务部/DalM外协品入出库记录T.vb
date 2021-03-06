Imports System.Text

#Region "Dal入出库记录
'------------------------------------------------------------------------------------
'   说明
'       入出库记录的数据库操作SQL文
'   创建人
'       大连智云科技 解辉品
'   创建时间
'       2016/5/24
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalM外协品入出库记录T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO B原材料入出库记录")            '入出库记录

            strSql.Append(" (入出库单号")          '入出库单号
            strSql.Append(" ,出荷指示编号")
            strSql.Append(" ,制造批量号")          '制造批量号
            strSql.Append(" ,入出库区分")          '入出库区分
            strSql.Append(" ,入出库数量")         '数量
            strSql.Append(" ,入出库日期")         '日期
            strSql.Append(" ,备注")         '日期
            strSql.Append(")")

            strSql.Append(" VALUES ")

            ''入出库单号
            'strSql.Append(" ('" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库单号) & "'")

            ''出荷指示编号
            'If cls入出库记录T.出荷指示编号 = 0 Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append("," & cls入出库记录T.出荷指示编号)
            'End If

            ''制造批量号
            'strSql.Append(" ,'" & Utility.PFn_ChangeQuotation(cls入出库记录T.制造批量号) & "'")


            ''入出库区分
            'If cls入出库记录T.入出库区分 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & "'")
            'End If

            ''数量
            'If cls入出库记录T.入出库数量 = 0 Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ," & cls入出库记录T.入出库数量)
            'End If

            ''日期
            'If cls入出库记录T.入出库日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(",'" & cls入出库记录T.入出库日期 & "'")
            'End If

            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE B原材料入出库记录 ") '入出库记录
            strSql.Append(" SET ")

            ''制造批量号
            'strSql.Append(" ,制造批量号 = '" & Utility.PFn_ChangeQuotation(cls入出库记录T.制造批量号) & "'")

            ''入出库区分
            'If cls入出库记录T.入出库区分 = "" Then
            '    strSql.Append(" ,入出库区分 = NULL ")
            'Else
            '    strSql.Append(" ,入出库区分 = '" & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & "'")
            'End If

            ''数量
            'If cls入出库记录T.入出库数量 = 0 Then
            '    strSql.Append(" ,数量 = NULL ")
            'Else
            '    strSql.Append(" ,数量 = " & cls入出库记录T.入出库数量)
            'End If

            ''日期
            'If cls入出库记录T.入出库日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,日期 = NULL ")
            'Else
            '    strSql.Append(" ,日期 = '" & cls入出库记录T.入出库日期 & "'")
            'End If

            strSql.Append(" WHERE ")
            strSql.Append(" 入出库记录CD = " & cls入出库记录T.入出库记录CD) '入出库单号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM B原材料入出库记录 ") '入出库记录)

            strSql.Append(" WHERE ")
            strSql.Append(" 入出库记录CD = " & cls入出库记录T.入出库记录CD) '入出库单号

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal cls入出库记录T As B原材料入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ")

            strSql.Append("  入出库记录.入出库单号 AS 入出库单号")           '入出库单号
            strSql.Append(" ,入出库记录.材料编号 AS 材料编号")         '部品番号
            strSql.Append(" ,入出库记录.材料批号 AS 材料批号")           '制造批量号
            strSql.Append(" ,ISNULL(入出库记录.订单编号,'') AS 订单编号")          '部品区分
            strSql.Append(" ,ISNULL(入出库记录.入出库区分,'') AS 入出库区分")            '入出库区分
            strSql.Append(" ,ISNULL(入出库记录.入出库数量,0) AS [数量（个）]")           '数量
            strSql.Append(" ,ISNULL(入出库记录.入出库重量,0) AS [重量（kg）]")           '数量
            strSql.Append(" ,入出库记录.入出库日期 AS 入出库日期")         '日期

            strSql.Append(" FROM B原材料入出库记录 入出库记录 ") '入出库记录)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal cls入出库记录T As B外协品入出库一览T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append("select DISTINCT A.入出库区分, " & vbCrLf)
            strSql.Append("       A.订单编号, " & vbCrLf)
            strSql.Append("       D.客户名称, " & vbCrLf)
            strSql.Append("       A.主图号 , " & vbCrLf)
            strSql.Append("       A.上级图号 , " & vbCrLf)
            strSql.Append("       A.分图号 [产品图号], " & vbCrLf)
            strSql.Append("       C.品名 产品名称, " & vbCrLf)
            strSql.Append("       A.数量, " & vbCrLf)
            strSql.Append("       A.入出库日期 " & vbCrLf)
            strSql.Append("       From dbo.Z半成品入出库记录 A  " & vbCrLf)
            strSql.Append("       inner join dbo.T图纸管理 C  " & vbCrLf)
            strSql.Append("       on A.主图号 = C.产品图号 " & vbCrLf)
            strSql.Append("       inner join dbo.B订单管理 B " & vbCrLf)
            strSql.Append("       on A.订单编号 = B.订单编号 " & vbCrLf)
            strSql.Append("       inner join dbo.M客户管理 D " & vbCrLf)
            strSql.Append("       on B.客户编号 = D.客户编号" & vbCrLf)

            strSql.Append("WHERE  1 = 1 " & vbCrLf)

            If (cls入出库记录T.入出库区分 <> String.Empty) Then
                strSql.Append(" AND 入出库区分 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.入出库区分) & vbCrLf)
            End If
            If (cls入出库记录T.产品图号 <> String.Empty) Then
                strSql.Append(" AND A.主图号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.产品图号) & vbCrLf)
            End If
            If (cls入出库记录T.订单编号 <> String.Empty) Then
                strSql.Append(" AND A.订单编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.订单编号) & vbCrLf)
            End If
            If (cls入出库记录T.客户编号 <> String.Empty) Then
                strSql.Append(" AND B.客户编号 = " & Utility.PFn_ChangeQuotation(cls入出库记录T.客户编号) & vbCrLf)
            End If
            If cls入出库记录T.开始日期 <> "1900/1/1" Then
                strSql.Append(" AND A.入出库日期 >=" & Utility.PFn_ChangeQuotation(cls入出库记录T.开始日期) & vbCrLf)
            End If
            If cls入出库记录T.结束日期 <> "1900/1/1" Then
                strSql.Append(" AND A.入出库日期 <" & Utility.PFn_ChangeQuotation(cls入出库记录T.结束日期.AddDays(1)) & vbCrLf)
            End If


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
