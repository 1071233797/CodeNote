Imports System.Text
Imports System.Data.SqlClient
Imports HRJS.Constant
Public Class BLLM外协对象T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry外协对象 As ArrayList) As Integer

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM部门.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM外协对象T.Delete(arry外协对象(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry外协对象.Count - 1
                Dim cls外协对象T As New M外协对象T
                cls外协对象T = arry外协对象(i)
                If String.IsNullOrEmpty(cls外协对象T.外协对象编号CD) Then
                    strSql = objDalM外协对象T.Get外协对象编号CD(cls外协对象T)

                    Dim str顺序号 As String
                    str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                    Dim str As String = cls外协对象T.外协对象编号 + "CD" + str顺序号
                    cls外协对象T.外协对象编号CD = str

                    strSql = objDalM外协对象T.Insert(cls外协对象T)
                Else
                    strSql = objDalM外协对象T.Insert(cls外协对象T)
                End If
                intRows += ObjDBConn.PFn_ExcuteDB(strSql)

            Next

            ObjDBConn.PSb_Commit()
            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Update "

    '根据主键更新数据
    Public Function Update(ByVal arry外协对象 As ArrayList) As Integer

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.Update"
        Dim strSqlS As String = String.Empty
        Dim cls外协对象T As M外协对象T
        Try
            cls外协对象T = New M外协对象T
            cls外协对象T = arry外协对象(0)

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM外协对象T.Delete(cls外协对象T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry外协对象.Count - 1
                cls外协对象T = New M外协对象T
                cls外协对象T = arry外协对象(i)
                strSql = objDalM外协对象T.Get外协对象编号CD(cls外协对象T)

                Dim str顺序号 As String
                str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                Dim str As String = cls外协对象T.外协对象编号 + "CD" + str顺序号
                cls外协对象T.外协对象编号CD = str

                strSql = objDalM外协对象T.Insert(cls外协对象T)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)

            Next
            'For i = 0 To arry外协对象.Count - 1
            '    Dim cls外协对象T As New M外协对象T
            '    cls外协对象T = arry外协对象(i)
            '    strSqlS = objDalM外协对象T.LoadInfoAll(cls外协对象T)

            '    dtReturn = ObjDBConn.PFn_FillDataTable(strSqlS)
            '    If dtReturn.Rows.Count > 0 Then
            '        strSql = objDalM外协对象T.Update(cls外协对象T)

            '    Else
            '        strSql = objDalM外协对象T.Get外协对象编号CD(cls外协对象T)

            '        Dim str顺序号 As String
            '        str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
            '        Dim str As String = cls外协对象T.外协对象编号 + str顺序号
            '        cls外协对象T.外协对象编号CD = str

            '        strSql = objDalM外协对象T.Insert(cls外协对象T)
            '    End If
            '    intRows += ObjDBConn.PFn_ExcuteDB(strSql)
            'Next
            ObjDBConn.PSb_Commit()

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " Delete "

    '删除数据
    Public Function Delete(ByVal clsM外协对象T As M外协对象T) As Integer

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.Delete"

        Try

            strSql = objDalM外协对象T.Delete(clsM外协对象T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            ObjDBConn.PSb_CloseDB()

            Return intRows

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByPKey "

    '根据主键检索
    Public Function LoadByPKey(ByVal clsM外协对象T As M外协对象T) As M外协对象T

        Dim objM外协对象T As New M外协对象T
        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM外协对象T.LoadByPK(clsM外协对象T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM外协对象T.外协对象编号 = sdr.Item("外协对象编号")            '部门名                objM外协对象T.外协对象名称 = sdr.Item("外协对象名称")            '部门名
                objM外协对象T.税率 = sdr.Item("税率")            '部门名
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM外协对象T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadInfoAll(ByVal clsM外协对象T As M外协对象T) As DataTable

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.LoadAll"

        Try

            strSql = objDalM外协对象T.LoadInfoAll(clsM外协对象T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadGridAll(ByVal clsM外协对象T As M外协对象T) As DataTable

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.LoadAll"

        Try

            strSql = objDalM外协对象T.LoadGridAll(clsM外协对象T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadInfoCD(ByVal clsM外协对象T As M外协对象T) As DataTable

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.LoadAll"

        Try

            strSql = objDalM外协对象T.LoadByPK(clsM外协对象T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region

#Region " LoadByWhere "

    '检索全部数据
    Public Function LoadByWhere(ByVal clsM外协对象T As M外协对象T) As DataTable

        Dim objDalM外协对象T As New DalM外协对象T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM外协对象.LoadByWhere"

        Try

            strSql = objDalM外协对象T.LoadByWhere(clsM外协对象T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region "SaveData"

    'Public Function SaveData(ByVal objM部门T As M外协对象T, ByVal intMode As Integer) As Integer

    '    Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
    '    Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
    '    Dim strRtnSQL As String = Nothing
    '    Dim objDalM外协对象T As New DalM外协对象T

    '    Try

    '        objDbCon = New DbHelper
    '        '事務の開始
    '        objDbCon.PSb_BeginTransaction()

    '        Select Case intMode

    '            Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

    '                '部门新規を処理
    '                If objDbCon.PFn_ExcuteDB(objDalM外协对象T.Insert(objM部门T)) < 0 Then
    '                    'ロールバック
    '                    objDbCon.PSb_Rollback()
    '                    '保存処理終了
    '                    Return Constant.ENU_RETURNTYPE.Failed
    '                End If

    '            Case Constant.ENU_MODE.Model_Update

    '                '部门更新処理
    '                If objDbCon.PFn_ExcuteDB(objDalM外协对象T.Update(objM部门T)) < 0 Then
    '                    'ロールバック
    '                    objDbCon.PSb_Rollback()
    '                    '保存処理終了
    '                    Return Constant.ENU_RETURNTYPE.Failed
    '                End If
    '        End Select

    '        '事務のコミット
    '        objDbCon.PSb_Commit()

    '        'データベース接続を切断する
    '        objDbCon.PSb_CloseDB()

    '        Return Constant.ENU_RETURNTYPE.Succeed

    '    Catch ex As Exception

    '        '空対象をセットする
    '        If Not objDbCon Is Nothing Then
    '            'DB連接を閉じる
    '            objDbCon.PSb_CloseDB()
    '            objDbCon = Nothing
    '        End If

    '        Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)

    '    End Try

    'End Function

#End Region

End Class
