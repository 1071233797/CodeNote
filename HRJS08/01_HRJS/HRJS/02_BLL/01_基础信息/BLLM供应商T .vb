Imports System.Text
Imports System.Data.SqlClient
Imports HRJS.Constant
Public Class BLLM供应商T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry供应商 As ArrayList) As Integer

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM部门.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()

            'strSql = objDalM供应商T.Delete(arry供应商(0))
            'intRows = ObjDBConn.PFn_ExcuteDB(strSql)

            For i = 0 To arry供应商.Count - 1
                Dim cls供应商T As New M供应商T
                cls供应商T = arry供应商(i)
                If String.IsNullOrEmpty(cls供应商T.供应商编号CD) Then
                    strSql = objDalM供应商T.Get供应商编号CD(cls供应商T)

                    Dim str顺序号 As String
                    str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                    Dim str As String = cls供应商T.供应商编号 + "CD" + str顺序号
                    cls供应商T.供应商编号CD = str

                    strSql = objDalM供应商T.Insert(cls供应商T)
                Else
                    strSql = objDalM供应商T.Insert(cls供应商T)
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
    Public Function Update(ByVal arry供应商 As ArrayList) As Integer

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.Update"
        Dim strSqlS As String = String.Empty
        Dim cls供应商T As M供应商T
        Try
            cls供应商T = New M供应商T
            cls供应商T = arry供应商(0)

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM供应商T.Delete(cls供应商T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
        
            For i = 0 To arry供应商.Count - 1
                cls供应商T = New M供应商T
                cls供应商T = arry供应商(i)
                    strSql = objDalM供应商T.Get供应商编号CD(cls供应商T)

                    Dim str顺序号 As String
                    str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
                Dim str As String = cls供应商T.供应商编号 + "CD" + str顺序号
                    cls供应商T.供应商编号CD = str

                    strSql = objDalM供应商T.Insert(cls供应商T)
               
                intRows += ObjDBConn.PFn_ExcuteDB(strSql)

            Next
            'For i = 0 To arry供应商.Count - 1
            '    Dim cls供应商T As New M供应商T
            '    cls供应商T = arry供应商(i)
            '    strSqlS = objDalM供应商T.LoadInfoAll(cls供应商T)

            '    dtReturn = ObjDBConn.PFn_FillDataTable(strSqlS)
            '    If dtReturn.Rows.Count > 0 Then
            '        strSql = objDalM供应商T.Update(cls供应商T)

            '    Else
            '        strSql = objDalM供应商T.Get供应商编号CD(cls供应商T)

            '        Dim str顺序号 As String
            '        str顺序号 = ObjDBConn.PFn_ExcuteScalar(strSql)
            '        Dim str As String = cls供应商T.供应商编号 + str顺序号
            '        cls供应商T.供应商编号CD = str

            '        strSql = objDalM供应商T.Insert(cls供应商T)
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
    Public Function Delete(ByVal clsM供应商T As M供应商T) As Integer

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.Delete"

        Try

            strSql = objDalM供应商T.Delete(clsM供应商T)
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
    Public Function LoadByPKey(ByVal clsM供应商T As M供应商T) As M供应商T

        Dim objM供应商T As New M供应商T
        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM供应商T.LoadByPK(clsM供应商T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM供应商T.供应商编号 = sdr.Item("供应商编号")            '部门名                objM供应商T.供应商名称 = sdr.Item("供应商名称")            '部门名
                objM供应商T.税率 = sdr.Item("税率")            '部门名
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM供应商T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据    Public Function LoadInfoAll(ByVal clsM供应商T As M供应商T) As DataTable

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.LoadAll"

        Try

            strSql = objDalM供应商T.LoadInfoAll(clsM供应商T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadGridAll(ByVal clsM供应商T As M供应商T) As DataTable

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.LoadAll"

        Try

            strSql = objDalM供应商T.LoadGridAll(clsM供应商T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function
    Public Function LoadInfoCD(ByVal clsM供应商T As M供应商T) As DataTable

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.LoadAll"

        Try

            strSql = objDalM供应商T.LoadByPK(clsM供应商T)
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
    Public Function LoadByWhere(ByVal clsM供应商T As M供应商T) As DataTable

        Dim objDalM供应商T As New DalM供应商T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM供应商.LoadByWhere"

        Try

            strSql = objDalM供应商T.LoadByWhere(clsM供应商T)
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

    'Public Function SaveData(ByVal objM部门T As M供应商T, ByVal intMode As Integer) As Integer

    '    Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
    '    Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
    '    Dim strRtnSQL As String = Nothing
    '    Dim objDalM供应商T As New DalM供应商T

    '    Try

    '        objDbCon = New DbHelper
    '        '事務の開始
    '        objDbCon.PSb_BeginTransaction()

    '        Select Case intMode

    '            Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

    '                '部门新規を処理
    '                If objDbCon.PFn_ExcuteDB(objDalM供应商T.Insert(objM部门T)) < 0 Then
    '                    'ロールバック
    '                    objDbCon.PSb_Rollback()
    '                    '保存処理終了
    '                    Return Constant.ENU_RETURNTYPE.Failed
    '                End If

    '            Case Constant.ENU_MODE.Model_Update

    '                '部门更新処理
    '                If objDbCon.PFn_ExcuteDB(objDalM供应商T.Update(objM部门T)) < 0 Then
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
