Imports System.Text

#Region "DalZ报废品管理T
'------------------------------------------------------------------------------------
'   说明
'       Z报废品管理T的数据库操作SQL文
'   创建人
'       大连智云科技 李陈盛
'   创建时间
'       2016/8/31
'   方法列表
'       Insert,Update,Delete,LoadByPKey,LoadAll
'------------------------------------------------------------------------------------
#End Region

Public Class DalZ报废品管理T

#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal clsZ报废品管理T As Z报废品管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append(" INSERT INTO Z报废品管理T")          'Z报废品管理T

            'strSql.Append(" (订单编号")           '订单编号
            'strSql.Append(" ,报废品图号")          '报废品图号
            'strSql.Append(" ,总图号")            '总图号
            'strSql.Append(" ,报废品产生工序")            '报废品产生工序
            'strSql.Append(" ,报废品数量")          '报废品数量
            'strSql.Append(" ,报废品生产者")         '报废品生产者
            'strSql.Append(" ,报废日期")           '报废日期
            'strSql.Append(" ,图片1")            '图片1
            'strSql.Append(" ,图片2")            '图片2
            'strSql.Append(" ,图片3")            '图片3
            'strSql.Append(" ,报废原因")           '报废原因
            'strSql.Append(" ,品质处理结果")         '品质处理结果
            'strSql.Append(" ,备注 ")            '备注 
            'strSql.Append(")")

            'strSql.Append(" VALUES ")

            ''订单编号
            'strSql.Append(" ('" & Utility.changeQuotation(clsZ报废品管理T.订单编号) & "'")

            ''报废品图号
            'If clsZ报废品管理T.报废品图号 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.报废品图号) & "'")
            'End If

            ''总图号
            'If clsZ报废品管理T.总图号 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.总图号) & "'")
            'End If

            ''报废品产生工序
            'If clsZ报废品管理T.报废品产生工序 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.报废品产生工序) & "'")
            'End If

            ''报废品数量
            'If clsZ报废品管理T.报废品数量 = 0 Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ," & clsZ报废品管理T.报废品数量)
            'End If

            ''报废品生产者
            'If clsZ报废品管理T.报废品生产者 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.报废品生产者) & "'")
            'End If

            ''报废日期
            'If clsZ报废品管理T.报废日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(",TO_DATE('" & clsZ报废品管理T.报废日期 & "','YYYY/MM/DD HH24:MI:SS')")
            'End If

            ''图片1
            'If clsZ报废品管理T.图片1 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.图片1) & "'")
            'End If

            ''图片2
            'If clsZ报废品管理T.图片2 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.图片2) & "'")
            'End If

            ''图片3
            'If clsZ报废品管理T.图片3 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.图片3) & "'")
            'End If

            ''报废原因
            'If clsZ报废品管理T.报废原因 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.报废原因) & "'")
            'End If

            ''品质处理结果
            'If clsZ报废品管理T.品质处理结果 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.品质处理结果) & "'")
            'End If

            ''备注 
            'If clsZ报废品管理T.备注 = "" Then
            '    strSql.Append(" ,NULL ")
            'Else
            '    strSql.Append(" ,'" & Utility.changeQuotation(clsZ报废品管理T.备注) & "'")
            'End If
            'strSql.Append(" )")
            Return strSql.ToString

        Catch ex As Exception
            Return String.Empty
            MessageBox.Show(ex.ToString)
        End Try

    End Function

#End Region

#Region " Update "

    '数据更新操作
    Public Function Update(ByVal clsZ报废品管理T As Z报废品管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            'strSql.Append(" UPDATE Z报废品管理T ") 'Z报废品管理T
            'strSql.Append(" SET ")

            ''订单编号
            'If clsZ报废品管理T.订单编号 = "" Then
            '    strSql.Append(" 订单编号 = NULL ")
            'Else
            '    strSql.Append(" 订单编号 = '" & Utility.changeQuotation(clsZ报废品管理T.订单编号) & "'")
            'End If

            ''报废品图号
            'If clsZ报废品管理T.报废品图号 = "" Then
            '    strSql.Append(" ,报废品图号 = NULL ")
            'Else
            '    strSql.Append(" ,报废品图号 = '" & Utility.changeQuotation(clsZ报废品管理T.报废品图号) & "'")
            'End If

            ''总图号
            'If clsZ报废品管理T.总图号 = "" Then
            '    strSql.Append(" ,总图号 = NULL ")
            'Else
            '    strSql.Append(" ,总图号 = '" & Utility.changeQuotation(clsZ报废品管理T.总图号) & "'")
            'End If

            ''报废品产生工序
            'If clsZ报废品管理T.报废品产生工序 = "" Then
            '    strSql.Append(" ,报废品产生工序 = NULL ")
            'Else
            '    strSql.Append(" ,报废品产生工序 = '" & Utility.changeQuotation(clsZ报废品管理T.报废品产生工序) & "'")
            'End If

            ''报废品数量
            'If clsZ报废品管理T.报废品数量 = 0 Then
            '    strSql.Append(" ,报废品数量 = NULL ")
            'Else
            '    strSql.Append(" ,报废品数量 = " & clsZ报废品管理T.报废品数量)
            'End If

            ''报废品生产者
            'If clsZ报废品管理T.报废品生产者 = "" Then
            '    strSql.Append(" ,报废品生产者 = NULL ")
            'Else
            '    strSql.Append(" ,报废品生产者 = '" & Utility.changeQuotation(clsZ报废品管理T.报废品生产者) & "'")
            'End If

            ''报废日期
            'If clsZ报废品管理T.报废日期 = "1900/01/01 0:00:00" Then
            '    strSql.Append(" ,报废日期 = NULL ")
            'Else
            '    strSql.Append(" ,报废日期 = TO_DATE('" & clsZ报废品管理T.报废日期 & "','YYYY/MM/DD HH24:MI:SS')")
            'End If

            ''图片1
            'If clsZ报废品管理T.图片1 = "" Then
            '    strSql.Append(" ,图片1 = NULL ")
            'Else
            '    strSql.Append(" ,图片1 = '" & Utility.changeQuotation(clsZ报废品管理T.图片1) & "'")
            'End If

            ''图片2
            'If clsZ报废品管理T.图片2 = "" Then
            '    strSql.Append(" ,图片2 = NULL ")
            'Else
            '    strSql.Append(" ,图片2 = '" & Utility.changeQuotation(clsZ报废品管理T.图片2) & "'")
            'End If

            ''图片3
            'If clsZ报废品管理T.图片3 = "" Then
            '    strSql.Append(" ,图片3 = NULL ")
            'Else
            '    strSql.Append(" ,图片3 = '" & Utility.changeQuotation(clsZ报废品管理T.图片3) & "'")
            'End If

            ''报废原因
            'If clsZ报废品管理T.报废原因 = "" Then
            '    strSql.Append(" ,报废原因 = NULL ")
            'Else
            '    strSql.Append(" ,报废原因 = '" & Utility.changeQuotation(clsZ报废品管理T.报废原因) & "'")
            'End If

            ''品质处理结果
            'If clsZ报废品管理T.品质处理结果 = "" Then
            '    strSql.Append(" ,品质处理结果 = NULL ")
            'Else
            '    strSql.Append(" ,品质处理结果 = '" & Utility.changeQuotation(clsZ报废品管理T.品质处理结果) & "'")
            'End If

            ''备注 
            'If clsZ报废品管理T.备注 = "" Then
            '    strSql.Append(" ,备注  = NULL ")
            'Else
            '    strSql.Append(" ,备注  = '" & Utility.changeQuotation(clsZ报废品管理T.备注) & "'")
            'End If

            'strSql.Append(" WHERE ")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " Delete "

    '数据删除操作
    Public Function Delete(ByVal clsZ报废品管理T As Z报废品管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM Z报废品管理T ") 'Z报废品管理T)

            strSql.Append(" WHERE ")

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsZ报废品管理T As Z报废品管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT ")

            strSql.Append("  Z报废品管理T.订单编号 AS 订单编号")           '订单编号
            strSql.Append(" ,ISNULL(Z报废品管理T.报废品图号,'') AS 报废品图号")          '报废品图号
            strSql.Append(" ,ISNULL(Z报废品管理T.总图号,'') AS 总图号")          '总图号
            strSql.Append(" ,ISNULL(Z报废品管理T.报废品产生工序,'') AS 报废品产生工序")          '报废品产生工序
            strSql.Append(" ,ISNULL(Z报废品管理T.报废品数量,0) AS 报废品数量")           '报废品数量
            strSql.Append(" ,ISNULL(Z报废品管理T.报废品生产者,'') AS 报废品生产者")            '报废品生产者
            strSql.Append(" ,Z报废品管理T.报废日期 AS 报废日期")           '报废日期
            strSql.Append(" ,ISNULL(Z报废品管理T.图片1,'') AS 图片1")          '图片1
            strSql.Append(" ,ISNULL(Z报废品管理T.图片2,'') AS 图片2")          '图片2
            strSql.Append(" ,ISNULL(Z报废品管理T.图片3,'') AS 图片3")          '图片3
            strSql.Append(" ,ISNULL(Z报废品管理T.报废原因,'') AS 报废原因")            '报废原因
            strSql.Append(" ,ISNULL(Z报废品管理T.品质处理结果,'') AS 品质处理结果")            '品质处理结果
            strSql.Append(" ,ISNULL(Z报废品管理T.备注 ,'') AS 备注 ")          '备注 

            strSql.Append(" FROM Z报废品管理T ") 'Z报废品管理T)

            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
