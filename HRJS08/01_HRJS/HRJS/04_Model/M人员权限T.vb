Public Class M人员权限T

    '变量定义 
    Private str人员编号 As String = ""                 '人员编号
    Private str菜单区分 As String = ""                  '菜单区分

    '------------------------------------------------------------------------------------
    '  人员编号
    '------------------------------------------------------------------------------------
    Public Property 人员编号() As String
        Get
            Return str人员编号
        End Get
        Set(ByVal Value As String)
            str人员编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  菜单区分
    '------------------------------------------------------------------------------------
    Public Property 菜单区分() As String
        Get
            Return str菜单区分
        End Get
        Set(ByVal Value As String)
            str菜单区分 = Value
        End Set
    End Property
End Class
