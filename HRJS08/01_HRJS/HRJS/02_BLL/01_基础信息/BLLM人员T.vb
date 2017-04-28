Imports System.Data.SqlClient

Public Class BLLM人员T

    Private dtReturn As DataTable
    Private intRows As Integer
    Private strErrorName As String

#Region " IsExists "

    '是否存在
    Public Function IsExists(ByVal str人员编号 As String) As Boolean

        Dim objDal人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        Dim objReturn As Object
        strErrorName = "BllM人员.IsExists"

        Try

            strSql = objDal人员T.IsExists(str人员编号)
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

#Region " Insert "

    '插入数据
    Public Function Insert(ByVal clsM人员T As M人员T, ByVal arr人员权限 As ArrayList) As Integer

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim obj人员权限T As New M人员权限T

        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.Insert"

        Try
            ObjDBConn.PSb_BeginTransaction()
            '新规
            strSql = objDalM人员T.Insert(clsM人员T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            If intRows < 0 Then
                'ロールバック
                ObjDBConn.PSb_Rollback()
                '保存処理終了
                Return Constant.ENU_RETURNTYPE.Failed
            End If

            '人员权限
            For i = 0 To arr人员权限.Count - 1
                obj人员权限T = New M人员权限T
                obj人员权限T = arr人员权限.Item(i)

                '人员权限新規を処理
                If ObjDBConn.PFn_ExcuteDB(objDalM人员T.InsertSQL人员权限(obj人员权限T)) < 0 Then
                    'ロールバック
                    ObjDBConn.PSb_Rollback()
                    '保存処理終了
                    Return Constant.ENU_RETURNTYPE.Failed
                End If

            Next

            '事務のコミット
            ObjDBConn.PSb_Commit()
            'データベース接続を切断する
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
    Public Function Update(ByVal clsM人员T As M人员T, ByVal arr人员权限 As ArrayList) As Integer

        Dim objDalM人员T As New DalM人员T
        Dim obj人员权限T As New M人员权限T

        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.Update"

        Try

            ObjDBConn.PSb_BeginTransaction()
            strSql = objDalM人员T.Update(clsM人员T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)
            If intRows < 0 Then
                'ロールバック
                ObjDBConn.PSb_Rollback()
                '保存処理終了
                Return Constant.ENU_RETURNTYPE.Failed
            End If


            '人员権限削除処理
            If ObjDBConn.PFn_ExcuteDB(objDalM人员T.DeleteSQL人员权限(clsM人员T)) < 0 Then
                'ロールバック
                ObjDBConn.PSb_Rollback()
                '保存処理終了
                Return Constant.ENU_RETURNTYPE.Failed
            End If

            For i = 0 To arr人员权限.Count - 1
                obj人员权限T = New M人员权限T
                obj人员权限T = arr人员权限.Item(i)

                '人员权限新規を処理
                If ObjDBConn.PFn_ExcuteDB(objDalM人员T.InsertSQL人员权限(obj人员权限T)) < 0 Then
                    'ロールバック
                    ObjDBConn.PSb_Rollback()
                    '保存処理終了
                    Return Constant.ENU_RETURNTYPE.Failed
                End If

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

#Region " Delete "

    '删除数据
    Public Function Delete(ByVal clsM人员T As M人员T) As Integer

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.Delete"

        Try

            strSql = objDalM人员T.Delete(clsM人员T)
            intRows = ObjDBConn.PFn_ExcuteDB(strSql)

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
    Public Function DeleteBatch(ByVal str人员编号 As String) As Integer

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.DeleteBatch"

        Try

            strSql = objDalM人员T.DeleteBatch(str人员编号)
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
    Public Function LoadByPKey(ByVal clsM人员T As M人员T) As M人员T

        Dim objM人员T As New M人员T
        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = System.String.Empty    'Sql文
        Dim sdr As SqlDataReader

        Try

            strSql = objDalM人员T.LoadByPK(clsM人员T)
            sdr = ObjDBConn.PFn_ExcuteReader(strSql)

            '数据存在
            If sdr.HasRows = True Then

                sdr.Read()

                objM人员T.人员编号 = sdr.Item("人员编号")          '人员CD
                objM人员T.人员名 = sdr.Item("人员名")            '人员名
                'objM人员T.密码 = sdr.Item("密码")          'パスワード
                objM人员T.部门 = Utility.PFn_IsDBNull(sdr.Item("部门名称"), "")          '部門
                objM人员T.职务 = Utility.PFn_IsDBNull(sdr.Item("职务"), "")          '部門
                objM人员T.电话号码 = Utility.PFn_IsDBNull(sdr.Item("电话号码"), "")
                objM人员T.邮箱 = Utility.PFn_IsDBNull(sdr.Item("邮箱"), "")
                'objM人员T.在职状态 = Utility.PFn_IsDBNull(sdr.Item("在职状态"), "")          '在職状態
                'objM人员T.电话号码 = Utility.PFn_IsDBNull(sdr.Item("电话号码"), "")          '電話番号
                'objM人员T.入职时间 = Utility.PFn_IsDBNull(sdr.Item("入职时间"), "")          '入職時間
            End If

            'DataReader关闭
            sdr.Close()
            ObjDBConn.PSb_CloseDB()

            Return objM人员T

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadAll "

    '检索全部数据
    Public Function LoadAll(ByVal clsM人员T As M人员T) As DataTable

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.LoadAll"

        Try

            strSql = objDalM人员T.LoadAll(clsM人员T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadList "

    '检索全部数据
    Public Function LoadList() As DataTable

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.LoadList"

        Try

            strSql = objDalM人员T.LoadList()
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByBM "

    '检索全部数据
    Public Function LoadByBM(ByVal clsM部门T As M部门T) As DataTable

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.LoadByBM"

        Try

            strSql = objDalM人员T.LoadBM(clsM部门T)
            dtReturn = ObjDBConn.PFn_FillDataTable(strSql)

            ObjDBConn.PSb_CloseDB()

            Return dtReturn

        Catch ex As Exception
            ExHelper.ProcessDBHelper(ObjDBConn)
            Throw New Exception(strErrorName, ex)
        End Try

    End Function

#End Region

#Region " LoadByCD"

    '检索全部数据
    Public Function LoadByCD(ByVal clsM人员T As M人员T) As DataTable

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.LoadByWhere"

        Try

            strSql = objDalM人员T.LoadByCD(clsM人员T)
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
    Public Function LoadByWhere(ByVal clsM人员T As M人员T) As DataTable

        Dim objDalM人员T As New DalM人员T
        Dim ObjDBConn As New DbHelper
        Dim strSql As String = String.Empty
        strErrorName = "BllM人员.LoadByWhere"

        Try

            strSql = objDalM人员T.LoadByWhere(clsM人员T)
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

    Public Function SaveData(ByVal objM人员T As M人员T, ByVal arr人员权限 As ArrayList, ByVal intMode As Integer) As Integer

        Dim MyMethodBase As System.Reflection.MethodBase = System.Reflection.MethodBase.GetCurrentMethod
        Dim objDbCon As DbHelper = Nothing         'DBオブジェクト
        Dim strRtnSQL As String = Nothing
        Dim objDalM人员T As New DalM人员T
        Dim obj人员权限T As New M人员权限T

        Try

            objDbCon = New DbHelper
            '事務の開始
            objDbCon.PSb_BeginTransaction()

            Select Case intMode

                Case Constant.ENU_MODE.Model_New, Constant.ENU_MODE.Model_Copy

                    '人员新規を処理
                    If objDbCon.PFn_ExcuteDB(objDalM人员T.Insert(objM人员T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '登録処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                    For i = 0 To arr人员权限.Count - 1
                        obj人员权限T = New M人员权限T
                        obj人员权限T = arr人员权限.Item(i)

                        '人员权限新規を処理
                        If objDbCon.PFn_ExcuteDB(objDalM人员T.InsertSQL人员权限(obj人员权限T)) < 0 Then
                            'ロールバック
                            objDbCon.PSb_Rollback()
                            '登録処理終了
                            Return Constant.ENU_RETURNTYPE.Failed
                        End If

                    Next

                Case Constant.ENU_MODE.Model_Update

                    '人员更新処理
                    If objDbCon.PFn_ExcuteDB(objDalM人员T.Update(objM人员T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '登録処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                    '人员权限削除処理
                    If objDbCon.PFn_ExcuteDB(objDalM人员T.DeleteSQL人员权限(objM人员T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '登録処理終了
                        Return Constant.ENU_RETURNTYPE.Failed
                    End If

                    For i = 0 To arr人员权限.Count - 1
                        obj人员权限T = New M人员权限T
                        obj人员权限T = arr人员权限.Item(i)

                        '人员权限新規を処理
                        If objDbCon.PFn_ExcuteDB(objDalM人员T.InsertSQL人员权限(obj人员权限T)) < 0 Then
                            'ロールバック
                            objDbCon.PSb_Rollback()
                            '登録処理終了
                            Return Constant.ENU_RETURNTYPE.Failed
                        End If

                    Next

                Case Constant.ENU_MODE.Model_Delete

                    '人员削除処理
                    If objDbCon.PFn_ExcuteDB(objDalM人员T.Delete(objM人员T)) < 0 Then
                        'ロールバック
                        objDbCon.PSb_Rollback()
                        '登録処理終了
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

    Public Function Select详细Band0(ByVal objM人员T As M人员T) As DataTable

        Dim strErrorName As String                              'エラーメッセージ用
        Dim objDtReturn As DataTable = Nothing                  '戻り用DataTable
        Dim objDBConn As DbHelper = Nothing                     'DBインスタンス
        Dim objDalM人员T As New DalM人员T              '人员详细マスタのDalインスタンス
        Dim strSql As String = String.Empty

        strErrorName = "Bll人员详细.Select详细Band0"

        Try

            objDBConn = New DbHelper

            '人员テーブルのデータを取得する
            strSql = objDalM人员T.Select详细Band0(objM人员T)
            objDtReturn = objDBConn.PFn_FillDataTable(strSql)

            'データベース接続を切断する
            objDBConn.PSb_CloseDB()

            '結果に戻る
            Return objDtReturn

        Catch ex As Exception

            ExHelper.ProcessDBHelper(objDBConn)
            Throw New Exception(strErrorName, ex)

        End Try

    End Function

    Public Function Select详细Band1(ByVal objM人员T As M人员T) As DataTable

        Dim strErrorName As String                              'エラーメッセージ用
        Dim objDtReturn As DataTable = Nothing                  '戻り用DataTable
        Dim objDBConn As DbHelper = Nothing                     'DBインスタンス
        Dim objDalM人员T As New DalM人员T               '人员详细マスタのDalインスタンス
        Dim strSql As String = String.Empty
        strErrorName = "Bll人员详细.Select详细Band1"

        Try

            objDBConn = New DbHelper

            '人员テーブルのデータを取得する
            strSql = objDalM人员T.Select详细Band1(objM人员T)
            objDtReturn = objDBConn.PFn_FillDataTable(strSql)

            'データベース接続を切断する
            objDBConn.PSb_CloseDB()

            '結果に戻る
            Return objDtReturn

        Catch ex As Exception

            ExHelper.ProcessDBHelper(objDBConn)
            Throw New Exception(strErrorName, ex)

        End Try

    End Function

    Public Function Select详细Band2(ByVal objM人员T As M人员T) As DataTable

        Dim strErrorName As String                              'エラーメッセージ用
        Dim objDtReturn As DataTable = Nothing                  '戻り用DataTable
        Dim objDBConn As DbHelper = Nothing                     'DBインスタンス
        Dim objDalM人员T As New DalM人员T               '人员详细マスタのDalインスタンス
        Dim strSql As String = String.Empty
        strErrorName = "Bll人员详细.Select详细Band2"

        Try

            objDBConn = New DbHelper

            '人员テーブルのデータを取得する
            strSql = objDalM人员T.Select详细Band2(objM人员T)
            objDtReturn = objDBConn.PFn_FillDataTable(strSql)

            'データベース接続を切断する
            objDBConn.PSb_CloseDB()

            '結果に戻る
            Return objDtReturn

        Catch ex As Exception

            ExHelper.ProcessDBHelper(objDBConn)
            Throw New Exception(strErrorName, ex)

        End Try

    End Function
End Class
