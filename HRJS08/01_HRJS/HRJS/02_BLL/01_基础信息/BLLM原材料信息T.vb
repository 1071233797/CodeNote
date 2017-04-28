Imports System.Text
Imports HRJS.Constant
Imports System.Data.SqlClient

Public Class BLLM原材料信息T

#Region "private variable"
    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String
#End Region

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal arry原材料 As M原材料信息T) As Integer

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.Insert"

        Try

            strSql = objDalM原材料T.Insert(arry原材料)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

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
    Public Function Update(ByVal cls原材料信息T As M原材料信息T) As Integer

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM原材料T.Update(cls原材料信息T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
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
    Public Function Delete(ByVal cls原材料信息T As M原材料信息T) As Integer

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.Delete"

        Try

            strSql = objDalM原材料T.Delete(cls原材料信息T)
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

    Public Function LoadByPKey(ByVal cls原材料信息T As M原材料信息T) As M原材料信息T

        Dim objM原材料T As New M原材料信息T
        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文

        Dim sdr As SqlDataReader

        Try

            strSql = objDalM原材料T.LoadByPK(cls原材料信息T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM原材料T.原材料编号 = sdr.Item("原材料编号")            '原材料编号                objM原材料T.原材料名称 = sdr.Item("原材料名称")            '原材料编号
                objM原材料T.原材料区分 = sdr.Item("原材料区分")            '原材料区分                objM原材料T.材质 = sdr.Item("材质")          '材料种类 
                objM原材料T.材料种类 = sdr.Item("材料种类")          '材料种类 
                objM原材料T.材料代号 = sdr.Item("材料代号") & ""
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM原材料T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据

    Public Function LoadAll(ByVal cls原材料信息T As M原材料信息T) As DataTable

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.LoadAll"

        Try

            strSql = objDalM原材料T.LoadAll(cls原材料信息T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAllHead "

    '检索全部数据

    Public Function LoadAllHead(ByVal cls原材料信息T As M原材料信息T) As DataTable

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.LoadAllHead"

        Try

            strSql = objDalM原材料T.LoadAllHead(cls原材料信息T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region
#Region " LoadAllInfo "

    '检索全部数据

    

#End Region

#Region " LoadByWhere "

    '检索全部数据

    Public Function LoadByWhere(ByVal cls原材料信息T As M原材料信息T) As DataTable

        Dim objDalM原材料T As New DalM原材料信息T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM原材料信息.LoadByWhere"

        Try

            strSql = objDalM原材料T.LoadByWhere(cls原材料信息T)
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

    Public Function SaveData(ByVal objM原材料T As M原材料信息T, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM原材料T As New DalM原材料信息T

        Try

            objDbCon = New DbHelper
            '事務の開始

            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '原材料新規を処理

                    If objDbCon.PFn_ExcuteDB(objDalM原材料T.Insert(objM原材料T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                Case Constant.ENU_MODE.Model_Update

                    '部门更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM原材料T.Update(objM原材料T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '保存処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If
            End Select

            '事務のコミット

            objDbCon.PSb_Commit()

            'データベース接続を切断する

            objDbCon.PSb_CloseDB()

            Return Constant.ENU_RETURNTYPE.Succeed

        Catch ex As Exception

            '空対象をセットする

            If Not objDbCon Is Nothing Then
                'DB連接を閉じる
                objDbCon.PSb_CloseDB()
                objDbCon = Nothing
            End If

            Throw New Exception(MyMethodBase.ReflectedType.Name & "." & MyMethodBase.Name, ex)

        End Try

    End Function

#End Region



End Class
