Public Class M人员T

    '变量定义 
    Private str人员编号 As String = ""                 '人员编号
    Private str人员名 As String = ""                  '人员名
    Private str密码 As String = ""                 '密码
    Private str部门 As String = ""                    '部门
    Private str在职状态 As String = ""                  '在职状态
    Private str电话号码 As String = ""                  '电话号码
    Private dtm入职时间 As DateTime                     '入职时间

    Private str性别 As String = ""                 '性别
    Private str职务 As String = ""                  '职务

    Private str邮箱 As String = ""                 '邮箱
    Private str办公电话 As String = ""                    '办公电话
    Private str工种 As String = ""                  '工种

    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
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
    '  人员名
    '------------------------------------------------------------------------------------
    Public Property 人员名() As String
        Get
            Return str人员名
        End Get
        Set(ByVal Value As String)
            str人员名 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  密码
    '------------------------------------------------------------------------------------
    Public Property 密码() As String
        Get
            Return str密码
        End Get
        Set(ByVal Value As String)
            str密码 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部门
    '------------------------------------------------------------------------------------
    Public Property 部门() As String
        Get
            Return str部门
        End Get
        Set(ByVal Value As String)
            str部门 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  在职状态
    '------------------------------------------------------------------------------------
    Public Property 在职状态() As String
        Get
            Return str在职状态
        End Get
        Set(ByVal Value As String)
            str在职状态 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  电话号码
    '------------------------------------------------------------------------------------
    Public Property 电话号码() As String
        Get
            Return str电话号码
        End Get
        Set(ByVal Value As String)
            str电话号码 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  入职时间
    '------------------------------------------------------------------------------------
    Public Property 入职时间() As DateTime
        Get
            Return dtm入职时间
        End Get
        Set(ByVal Value As DateTime)
            dtm入职时间 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  性别
    '------------------------------------------------------------------------------------
    Public Property 性别() As String
        Get
            Return str性别
        End Get
        Set(ByVal Value As String)
            str性别 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  职务

    '------------------------------------------------------------------------------------
    Public Property 职务() As String
        Get
            Return str职务

        End Get
        Set(ByVal Value As String)
            str职务 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  邮箱
    '------------------------------------------------------------------------------------
    Public Property 邮箱() As String
        Get
            Return str邮箱
        End Get
        Set(ByVal Value As String)
            str邮箱 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  办公电话
    '------------------------------------------------------------------------------------
    Public Property 办公电话() As String
        Get
            Return str办公电话
        End Get
        Set(ByVal Value As String)
            str办公电话 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  工种

    '------------------------------------------------------------------------------------
    Public Property 工种() As String
        Get
            Return str工种

        End Get
        Set(ByVal Value As String)
            str工种 = Value
        End Set
    End Property

    Public Property 登录者() As String
        Get
            Return str登录者
        End Get
        Set(value As String)
            str登录者 = value
        End Set
    End Property

    ''' <summary>
    ''' 登录日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登录日期() As String
        Get
            Return str登录日期
        End Get
        Set(value As String)
            str登录日期 = value
        End Set
    End Property

  
    Public Property 更新者()
        Get
            Return str更新者
        End Get
        Set(value)
            str更新者 = value
        End Set
    End Property

    ''' <summary>
    ''' 更新日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(value As String)
            str更新日期 = value
        End Set
    End Property


End Class
