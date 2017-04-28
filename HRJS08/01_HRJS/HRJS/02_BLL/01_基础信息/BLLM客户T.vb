Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM客户T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry客户 As ArrayList) As Integer

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM部门.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM客户T.Delete(arry客户(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry客户.Count - 1
                Dim cls客户T As New M客户T
                cls客户T = arry客户(i)
                If String.IsNullOrEmpty(cls客户T.客户编号CD) Then
                    strSql = objDalM客户T.Get客户编号CD(cls客户T)

                    Dim str顺序号 As String
                    str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                    Dim str As String = cls客户T.客户编号 + "CD" + str顺序号
                    cls客户T.客户编号CD = str

                    strSql = objDalM客户T.Insert(cls客户T)
                Else
                    strSql = objDalM客户T.Insert(cls客户T)
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
    Public Function Update(ByVal arry客户 As ArrayList) As Integer

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.Update"
        Dim strSqlS As String = String.Empty
        Dim cls客户T As M客户T
        Try
            cls客户T = New M客户T
            cls客户T = arry客户(0)

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM客户T.Delete(cls客户T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry客户.Count - 1
                cls客户T = New M客户T
                cls客户T = arry客户(i)
                strSql = objDalM客户T.Get客户编号CD(cls客户T)

                Dim str顺序号 As String
                str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                Dim str As String = cls客户T.客户编号 + "CD" + str顺序号
                cls客户T.客户编号CD = str

                strSql = objDalM客户T.Insert(cls客户T)

                intRows += ObjDBConn.PFn_ExcuteDB(strSql)

            Next
            'For i = 0 To arry客户.Count - 1
            '    Dim cls客户T As New M客户T
            '    cls客户T = arry客户(i)
            '    strSql = objDalM客户T.Update(cls客户T)
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
    Public Function Delete(ByVal clsM客户T As M客户T) As Integer

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.Delete"

        Try

            strSql = objDalM客户T.Delete(clsM客户T)
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
    Public Function LoadByPKey(ByVal clsM客户T As M客户T) As M客户T

        Dim objM客户T As New M客户T
        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM客户T.LoadByPK(clsM客户T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM客户T.客户编号 = sdr.Item("客户编号")            '部门名                objM客户T.客户名称 = sdr.Item("客户名称")            '部门名
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM客户T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function CheckByPKey(ByVal clsM客户T As M客户T) As DataTable
        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.CheckByPKey"

        Try

            strSql = objDalM客户T.CheckByPKey(clsM客户T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try


    End Function
    Public Function get客户编号BY客户名称(ByVal clsM客户T As M客户T) As M客户T

        Dim objM客户T As New M客户T
        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM客户T.LoadByPK(clsM客户T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM客户T.客户编号 = sdr.Item("客户编号")            '部门名                objM客户T.客户名称 = sdr.Item("客户名称")            '部门名
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM客户T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadInfoAll(ByVal clsM客户T As M客户T) As DataTable

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.LoadAll"

        Try

            strSql = objDalM客户T.LoadInfoAll(clsM客户T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadGridAll(ByVal clsM客户T As M客户T) As DataTable

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.LoadAll"

        Try

            strSql = objDalM客户T.LoadGridAll(clsM客户T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadInfoCD(ByVal clsM客户T As M客户T) As DataTable

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.LoadAll"

        Try

            strSql = objDalM客户T.LoadByPK(clsM客户T)
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
    Public Function LoadByWhere(ByVal clsM客户T As M客户T) As DataTable

        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM客户.LoadByWhere"

        Try

            strSql = objDalM客户T.LoadByWhere(clsM客户T)
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

    'Public Function SaveData(ByVal objM部门T As M客户T, ByVal intMode As Integer) As Integer

    '    Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
    '    Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
    '    Dim strRtnSQL As String = Nothing
    '    Dim objDalM客户T As New DalM客户T

    '    Try

    '        objDbCon = New DbHelper
    '        '事務の開始
    '        objDbCon.PSb_BeginTransaction()

    '        Select Case intMode

    '            Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

    '                '部门新規を処理
    '                If objDbCon.PFn_ExcuteDB(objDalM客户T.Insert(objM部门T)) < 0 Then
    '                    'ロールバック
    '                    objDbCon.PSb_Rollback()
    '                    '保存処理終了
    '                    Return Constant.ENU_RETURNTYPE.Failed
    '                End If

    '            Case Constant.ENU_MODE.Model_Update

    '                '部门更新処理
    '                If objDbCon.PFn_ExcuteDB(objDalM客户T.Update(objM部门T)) < 0 Then
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

#Region " IsExists "

    '插入数据
    Public Function IsExists(ByVal str客户编号 As String) As Boolean

        Dim objDal客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "BllM客户T.IsExists"

        Try

            strSql = objDal客户T.IsExists(str客户编号)
            objReturn = ObjDBConn.PFn_ExcuteScalar(strSql)
            ObjDBConn.PSb_CloseDB()

            If Convert.ToInt32(objReturn) = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
#End Region

    Public Function LoadByWhere1(ByVal clsM客户T As M客户T) As M客户T

        Dim objM客户T As New M客户T
        Dim objDalM客户T As New DalM客户T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM客户T.LoadByPK(clsM客户T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()
                objM客户T.客户编号 = sdr.Item("客户编号")            '原材料编号
                objM客户T.客户名称 = sdr.Item("客户名称")          '原材料名称 

            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM客户T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

End Class
