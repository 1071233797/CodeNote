Imports System.Text

' ''#Region "Dal流转票管理
'' ''------------------------------------------------------------------------------------
'' ''   说明
'' ''       T流转票管理的数据库操作SQL文
'' ''   创建人
'' ''       大连智云科技 刘春广
'' ''   创建时间
'' ''       2016/8/22
'' ''   方法列表
'' ''       Insert,Update,Delete,LoadByPKey,LoadAll
'' ''------------------------------------------------------------------------------------
' ''#End Region

Public Class DalM流转票管理T
#Region "IsExists"

    'Public Function IsExists(ByVal str产品图号 As String)

    '    Dim strSql As New StringBuilder(System.String.Empty)    'Sql文



    '    Try
    '        strSql.Append("SELECT COUNT(1) " & vbCrLf)
    '        strSql.Append("FROM   T工艺卡 " & vbCrLf)
    '        strSql.Append("WHERE  产品图号 = " & Utility.PFn_PFn_ChangeQuotation(str产品图号))

    '        Return strSql.ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '        Return String.Empty
    '    End Try

    'End Function

#End Region


#Region " Insert "

    '数据插入操作
    Public Function Insert(ByVal clsM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" INSERT INTO T流转票管理")            'T流转票管理            strSql.Append(" (")         '加工内容简介            strSql.Append(" 产品图号")
            strSql.Append(" ,备注")
            strSql.Append(" ,试做品")
            strSql.Append(" ,外协加工")
            strSql.Append(" ,组装品")
            strSql.Append(" ,工序编号")
            strSql.Append(" ,工序名称")
            strSql.Append(" ,加工内容简介")
            strSql.Append(" ,作业场所")
            strSql.Append(" ,设备编号")
            strSql.Append(" ,图纸")
            strSql.Append(" ,登陆者")
            strSql.Append(" ,登陆日期")
            strSql.Append(" ,更新者")
            strSql.Append(" ,更新日期")
            strSql.Append(")")

            strSql.Append(" VALUES ")
            strSql.Append("  (" & vbCrLf)
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.产品图号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.备注))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为试做品))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为外协加工工序))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为组装品))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.工序编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.工序名称))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.加工内容简介))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.作业场所))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.设备编号))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.图纸图片))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.登陆者))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.登陆日期))
            strSql.AppendFormat(" {0}," & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.更新者))
            strSql.AppendFormat(" {0}" & vbCrLf, Utility.PFn_ChangeQuotation(clsM流转票管理T.更新日期))
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
    Public Function Update(ByVal clsM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" UPDATE T流转票管理 ") 'T流转票管理
            strSql.Append(" SET ")

            '加工内容简介
            If clsM流转票管理T.是否为外协加工工序 = "" Then
                strSql.Append(" 外协加工 = NULL ")
            Else
                strSql.Append(" 外协加工 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为外协加工工序) & "'")
            End If

            '作业场所
            If clsM流转票管理T.是否为组装品 = "" Then
                strSql.Append(" ,组装品 = NULL ")
            Else
                strSql.Append(" ,组装品 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为组装品) & "'")
            End If
            If clsM流转票管理T.是否为试做品 = "" Then
                strSql.Append(" ,试做品 = NULL ")
            Else
                strSql.Append(" ,试做品 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为试做品) & "'")
            End If

            '设备编号
            If clsM流转票管理T.工序名称 = "" Then
                strSql.Append(" ,工序名称 = NULL ")
            Else
                strSql.Append(" ,工序名称 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.工序名称) & "'")
            End If

            '订单编号
            If clsM流转票管理T.加工内容简介 = "" Then
                strSql.Append(" ,加工内容简介 = NULL ")
            Else
                strSql.Append(" ,加工内容简介 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.加工内容简介) & "'")
            End If

            '是否为外协加工工序
            If clsM流转票管理T.是否为外协加工工序 = "" Then
                strSql.Append(" ,是否为外协加工工序 = NULL ")
            Else
                strSql.Append(" ,是否为外协加工工序 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.是否为外协加工工序) & "'")
            End If

            '是否为组装品
            If clsM流转票管理T.作业场所 = "" Then
                strSql.Append(" ,作业场所 = NULL ")
            Else
                strSql.Append(" ,作业场所 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.作业场所) & "'")
            End If

            '是否为试做品
            If clsM流转票管理T.设备编号 = "" Then
                strSql.Append(" ,设备编号 = NULL ")
            Else
                strSql.Append(" ,设备编号 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.设备编号) & "'")
            End If

            '登陆者
            If clsM流转票管理T.登陆者 = "" Then
                strSql.Append(" ,登陆者 = NULL ")
            Else
                strSql.Append(" ,登陆者 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.登陆者) & "'")
            End If

            '登陆日期
            If clsM流转票管理T.登陆日期 = "1900/01/01 0:00:00" Then
                strSql.Append(" ,登陆日期 = NULL ")
            Else
                strSql.Append(" ,登陆日期 = TO_DATE('" & clsM流转票管理T.登陆日期 & "','YYYY/MM/DD HH24:MI:SS')")
            End If

            '更新者
            If clsM流转票管理T.更新者 = "" Then
                strSql.Append(" ,更新者 = NULL ")
            Else
                strSql.Append(" ,更新者 = '" & Utility.PFn_ChangeQuotation(clsM流转票管理T.更新者) & "'")
            End If

            '更新日期
            If clsM流转票管理T.更新日期 = "1900/01/01 0:00:00" Then
                strSql.Append(" ,更新日期 = NULL ")
            Else
                strSql.Append(" ,更新日期 = TO_DATE('" & clsM流转票管理T.更新日期 & "','YYYY/MM/DD HH24:MI:SS')")
            End If

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
    Public Function Delete(ByVal clsM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" DELETE FROM T流转票管理 ") 'T流转票管理)
            strSql.Append(" WHERE ")
            strSql.Append(" 产品图号=" & Utility.PFn_ChangeQuotation(clsM流转票管理T.产品图号) & vbCrLf)
            'strSql.Append(" and 工序名称=" & Utility.PFn_ChangeQuotation(clsM流转票管理T.工序名称) & vbCrLf)
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try

            strSql.Append(" SELECT TOP 1 ")

            strSql.Append("  产品图号")         '加工内容简介
            strSql.Append(" FROM T流转票管理 ") 'T流转票管理)
            strSql.Append(" where  产品图号=" & Utility.PFn_ChangeQuotation(clsM流转票管理T.产品图号) & vbCrLf)


            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region
#Region " LoadAll "

    '检索全部数据
    Public Function LoadByPK1(ByVal clsM流转票管理T As M流转票管理T) As String

        'Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        'Try

        '    strSql.Append(" SELECT  ")

        '    strSql.Append("  工序名称")         '工序名称
        '    strSql.Append("  ,加工内容简介")     '加工内容简介        '    strSql.Append("  ,作业场所")         '作业场所
        '    strSql.Append("  ,设备编号")         '设备编号
        '    strSql.Append(" FROM T流转票管理 ") 'T流转票管理)
        '    strSql.Append(" where  产品图号=" & Utility.PFn_ChangeQuotation(clsM流转票管理T.产品图号) & vbCrLf)


        '    Return strSql.ToString

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Return String.Empty
        'End Try

    End Function

#End Region

#Region " LoadAllGrid "

    '检索全部数据
    Public Function LoadAllGrid(ByVal objM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try
            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        产品图号 , " & vbCrLf)
            strSql.Append("        备注 , " & vbCrLf)
            strSql.Append("        试做品 , " & vbCrLf)
            strSql.Append("        [外协加工] , " & vbCrLf)
            strSql.Append("        [组装品] , " & vbCrLf)
            'strSql.Append("        [工序编号] , " & vbCrLf)
            strSql.Append("        [工序名称] , " & vbCrLf)
            strSql.Append("        [加工内容简介] , " & vbCrLf)
            strSql.Append("        [作业场所] , " & vbCrLf)
            strSql.Append("        [T流转票管理].[设备编号] , " & vbCrLf)
            strSql.Append("        M设备管理.设备名称, " & vbCrLf)
            strSql.Append("        图纸, " & vbCrLf)
            strSql.Append("        工序编号" & vbCrLf)
            strSql.Append(" FROM   [HRJS].[dbo].[T流转票管理] " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M设备管理 ON M设备管理.设备编号 = T流转票管理.设备编号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(objM流转票管理T.产品图号) & vbCrLf)
            strSql.Append(" ORDER BY 工序编号")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadAllGrid1(ByVal objM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT distinct A.产品图号 ,")
            strSql.Append("        A.品名 ,")
            strSql.Append("        B.备注,")
            strSql.Append("        case when B.试做品='true' then '是' else '否' end 试做品 ")

            strSql.Append(" FROM    dbo.T图纸管理 A")
            strSql.Append("        INNER JOIN dbo.T流转票管理 B ON A.产品图号 = B.产品图号")
            '检索条件 设定
            strSql.Append(" where 1=1 ")
            If objM流转票管理T.产品图号 <> "" Then
                strSql.Append("  and  A.产品图号 = " & Utility.PFn_ChangeQuotation(objM流转票管理T.产品图号) & "")
            End If
            If objM流转票管理T.品名 <> "" Then
                strSql.Append("  and  A.品名 = " & Utility.PFn_ChangeQuotation(objM流转票管理T.品名) & "")
            End If
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

    Public Function LoadAllGrid2(ByVal objM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append(" SELECT distinct A.产品图号 ,")
            strSql.Append("        A.品名 ,")
            strSql.Append("       case when B.外协加工='true' then '是' else '否' end 外协加工 ,")
            strSql.Append("        case when B.组装品='true' then '是' else '否' end 组装品 ,")
            strSql.Append("        B.工序编号 ,")
            strSql.Append("        B.工序名称 ,")
            strSql.Append("        B.加工内容简介 ,")
            strSql.Append("        B.作业场所 ,")
            strSql.Append("        B.设备编号,")
            strSql.Append("        M设备管理.设备名称")
            strSql.Append(" FROM    dbo.T图纸管理 A")
            strSql.Append("        INNER JOIN dbo.T流转票管理 B ON A.产品图号 = B.产品图号")
            strSql.Append("        LEFT JOIN dbo.M设备管理 ON M设备管理.设备编号 = B.设备编号")
            '检索条件 设定
            strSql.Append(" where 1=1 ")
            If objM流转票管理T.产品图号 <> "" Then
                strSql.Append("  and  A.产品图号 = " & Utility.PFn_ChangeQuotation(objM流转票管理T.产品图号) & "")
            End If
            If objM流转票管理T.品名 <> "" Then
                strSql.Append("  and  A.品名 = " & Utility.PFn_ChangeQuotation(objM流转票管理T.品名) & "")
            End If
            strSql.Append("  ORDER BY B.工序编号 ")
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function


    Public Function LoadAll流转票(ByVal objM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文


        Try
            strSql.Append("SELECT  所有图纸.ID - 主图关系.ID + 1 图纸等级 , " & vbCrLf)
            strSql.Append("        主图关系.产品图号 主图号 , " & vbCrLf)
            strSql.Append("        流转票.产品图号 分图号 , " & vbCrLf)
            strSql.Append("        图纸.品名 , " & vbCrLf)
            strSql.Append("        图纸.图纸 , " & vbCrLf)
            strSql.Append("        流转票.工序编号 序号 , " & vbCrLf)
            strSql.Append("        流转票.工序名称 , " & vbCrLf)
            strSql.Append("        流转票.加工内容简介 , " & vbCrLf)
            strSql.Append("        流转票.作业场所 , " & vbCrLf)
            strSql.Append("        设备.设备名称 " & vbCrLf)
            strSql.Append("FROM    dbo.T图纸关系 主图关系 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T图纸关系 所有图纸 ON 所有图纸.关系ID = 主图关系.关系ID " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T流转票管理 流转票 ON 流转票.产品图号 = 所有图纸.产品图号 " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M设备管理 设备 ON 设备.设备编号 = 流转票.设备编号 " & vbCrLf)
            strSql.Append("        INNER JOIN dbo.T图纸管理 图纸 ON 图纸.产品图号 = 流转票.产品图号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" where 1=1 ")
            If objM流转票管理T.产品图号 <> "" Then
                strSql.Append("  and 主图关系.产品图号 = " & Utility.PFn_ChangeQuotation(objM流转票管理T.产品图号) & vbCrLf)
            End If
            strSql.Append("ORDER BY 图纸等级 , " & vbCrLf)
            strSql.Append("        流转票.工序编号 " & vbCrLf)
            Return strSql.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function
#End Region
    Public Function LoadByWhere2(ByVal objM流转票T As M流转票管理T, ByVal intCount As Integer) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文

        Try
            strSql.Append("  SELECT DISTINCT top " & intCount & "")
            strSql.Append("            T图纸管理.产品图号 , " & vbCrLf)
            strSql.Append("            品名 , " & vbCrLf)
            strSql.Append("            T流转票管理.图纸 , " & vbCrLf)
            strSql.Append("            VM图纸状态.名称 图纸状态 , " & vbCrLf)
            strSql.Append("            上级关系.产品图号 上级图号 " & vbCrLf)
            strSql.Append("  FROM      dbo.T图纸关系 " & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T图纸关系 分图关系 ON 分图关系.关系ID = T图纸关系.关系ID " & vbCrLf)
            strSql.Append("                                         AND T图纸关系.CIID = 0 " & vbCrLf)
            strSql.Append("            LEFT JOIN dbo.T图纸关系 上级关系 ON 上级关系.ID = 分图关系.CIID AND 上级关系.关系ID = T图纸关系.关系ID" & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T图纸管理 ON 主图号 = T图纸关系.产品图号 " & vbCrLf)
            strSql.Append("                                    AND ( 上级关系.产品图号 = 上级图号 " & vbCrLf)
            strSql.Append("                                          OR 上级关系.产品图号 IS NULL " & vbCrLf)
            strSql.Append("                                        ) " & vbCrLf)
            strSql.Append("                                    AND T图纸管理.产品图号 = 分图关系.产品图号 " & vbCrLf)
            strSql.Append("            LEFT JOIN VM图纸状态 ON dbo.VM图纸状态.区分 = T图纸管理.图纸状态 " & vbCrLf)
            strSql.Append("            INNER JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = 分图关系.产品图号 " & vbCrLf)
            strSql.Append("  WHERE     T图纸关系.CIID = 0 " & vbCrLf)
            strSql.Append("            AND T图纸关系.产品图号 IN ( " & vbCrLf)
            strSql.Append("            SELECT DISTINCT " & vbCrLf)
            strSql.Append("                    ALL关系.产品图号 " & vbCrLf)
            strSql.Append("            FROM    dbo.T图纸关系 " & vbCrLf)
            strSql.Append("                    INNER JOIN dbo.T图纸关系 ALL关系 ON ALL关系.关系ID = T图纸关系.关系ID " & vbCrLf)
            strSql.Append("                    INNER JOIN dbo.T图纸管理 ON T图纸管理.产品图号 = ALL关系.产品图号 " & vbCrLf)
            strSql.Append("            WHERE   1=1 " & vbCrLf)
            If (objM流转票T.产品图号 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM流转票T.产品图号, True) & "%'" & vbCrLf)
            End If
            If (objM流转票T.品名 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM流转票T.品名, True) & "%'" & vbCrLf)
            End If
            If (objM流转票T.图纸状态 <> String.Empty) Then
                strSql.Append("                                                         AND T图纸管理.图纸状态 =" & Utility.PFn_ChangeQuotation(objM流转票T.图纸状态) & " " & vbCrLf)
            End If
            strSql.Append("                    AND ALL关系.CIID = 0  " & vbCrLf)
            strSql.Append("                    ) " & vbCrLf)



            'strSql.Append("  SELECT DISTINCT top " & intCount & "")
            'strSql.Append("         T图纸管理.产品图号 , ")
            'strSql.Append("  ")
            'strSql.Append("         品名 , ")
            ''strSql.Append("         备注 , ")
            'strSql.Append("         T流转票管理.图纸 , ")
            'strSql.Append("         vm图纸状态.名称 图纸状态, " & vbCrLf)
            'strSql.Append("  ")
            'strSql.Append("         CC.上级图号 ")
            'strSql.Append("  FROM   dbo.T图纸管理 ")
            'strSql.Append("         INNER JOIN ( SELECT distinct ddd.产品图号 上级图号 , ")
            'strSql.Append("                             aaa.CIID , ")
            'strSql.Append("                             CASE WHEN aaa.CIID = 0 THEN 0 ")
            'strSql.Append("                                  ELSE aaa.CIID - bbb.ID + 1 ")
            'strSql.Append("                             END ID , ")
            'strSql.Append("                             aaa.产品图号 , ")
            'strSql.Append("                             主号 ")
            'strSql.Append("                      FROM   dbo.T图纸关系 aaa ")
            'strSql.Append("                             INNER JOIN ( SELECT ID , ")
            'strSql.Append("                                                 关系ID , ")
            'strSql.Append("                                                 产品图号 主号 ")
            'strSql.Append("                                          FROM   T图纸关系 ")
            'strSql.Append("                                          WHERE  产品图号 IN ( SELECT ")
            'strSql.Append("                                                               产品图号 ")
            'strSql.Append("                                                           FROM ")
            'strSql.Append("                                                               dbo.T图纸管理 ")
            'strSql.Append("                                                             WHERE 1=1 " & vbCrLf)
            'If (objM流转票T.产品图号 <> String.Empty) Then
            '    strSql.Append("                                                         AND 产品图号 LIKE '%" & Utility.PFn_ChangeQuotation(objM流转票T.产品图号, True) & "%'" & vbCrLf)
            'End If
            'If (objM流转票T.品名 <> String.Empty) Then
            '    strSql.Append("                                                         AND 品名 LIKE '%" & Utility.PFn_ChangeQuotation(objM流转票T.品名, True) & "%'" & vbCrLf)
            'End If
            'If (objM流转票T.图纸状态 <> String.Empty) Then
            '    strSql.Append("                                                         AND 图纸状态 =" & Utility.PFn_ChangeQuotation(objM流转票T.图纸状态) & " " & vbCrLf)
            'End If
            'strSql.Append("                                                          )")
            'strSql.Append("                                        ) bbb ON bbb.关系ID = aaa.关系ID ")
            'strSql.Append("                             LEFT JOIN T图纸关系 ddd ON aaa.CIID = ddd.ID ")
            'strSql.Append("                    ) CC ON CC.产品图号 = T图纸管理.产品图号 ")
            'strSql.Append("        LEFT JOIN vm图纸状态 ON dbo.vm图纸状态.区分 = T图纸管理.图纸状态 " & vbCrLf)
            'strSql.Append("        INNER JOIN dbo.T流转票管理 ON T流转票管理.产品图号 = CC.产品图号  " & vbCrLf)

            Return strSql.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#Region " SetData "

    '检索全部数据
    Public Function SetData(ByVal clsM流转票管理T As M流转票管理T) As String

        Dim strSql As New StringBuilder(System.String.Empty)    'Sql文
        Try

            strSql.Append(" SELECT DISTINCT " & vbCrLf)
            strSql.Append("        产品图号 , " & vbCrLf)
            strSql.Append("        备注 , " & vbCrLf)
            strSql.Append("        试做品 , " & vbCrLf)
            strSql.Append("        [外协加工] , " & vbCrLf)
            strSql.Append("        [组装品] , " & vbCrLf)
            'strSql.Append("        [工序编号] , " & vbCrLf)
            strSql.Append("        [工序名称] , " & vbCrLf)
            strSql.Append("        [加工内容简介] , " & vbCrLf)
            strSql.Append("        [作业场所] , " & vbCrLf)
            strSql.Append("        [T流转票管理].[设备编号] , " & vbCrLf)
            strSql.Append("        M设备管理.设备名称, " & vbCrLf)
            strSql.Append("        图纸, " & vbCrLf)
            strSql.Append("        工序编号 " & vbCrLf)
            strSql.Append(" FROM   [HRJS].[dbo].[T流转票管理] " & vbCrLf)
            strSql.Append("        LEFT JOIN dbo.M设备管理 ON M设备管理.设备编号 = T流转票管理.设备编号 " & vbCrLf)
            '检索条件 设定
            strSql.Append(" WHERE 产品图号=" & Utility.PFn_ChangeQuotation(clsM流转票管理T.产品图号) & vbCrLf)
            strSql.Append("ORDER BY 工序编号")
            Return strSql.ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return String.Empty
        End Try

    End Function

#End Region

End Class
