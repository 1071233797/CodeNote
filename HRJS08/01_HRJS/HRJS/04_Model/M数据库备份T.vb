Public Class M数据库备份T
    Dim _int备份ID As Integer
    Dim _str备份路径 As String
    Dim _str数据库名 As String
    Dim _str登录者 As String
    Dim _date登录日期 As DateTime



    Public Property 备份ID() As Integer
        Get
            Return _int备份ID
        End Get
        Set(ByVal value As Integer)
            _int备份ID = value
        End Set
    End Property


    Public Property 备份路径() As String

        Get
            Return _str备份路径
        End Get
        Set(ByVal value As String)
            _str备份路径 = value
        End Set
    End Property


    Public Property 数据库名() As String

        Get
            Return _str数据库名
        End Get
        Set(ByVal value As String)
            _str数据库名 = value
        End Set
    End Property

    Public Property 登录者() As String

        Get
            Return _str登录者
        End Get
        Set(ByVal value As String)
            _str登录者 = value
        End Set
    End Property

    Public Property 登录日期() As DateTime

        Get
            Return _date登录日期
        End Get
        Set(ByVal value As DateTime)
            _date登录日期 = value
        End Set
    End Property


End Class
