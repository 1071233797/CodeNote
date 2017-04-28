Public Class M客户T

    Private str客户编号CD As String = String.Empty
    Private str客户编号 As String = String.Empty
    Private str客户名称 As String = String.Empty
    Private str公司地址 As String = String.Empty
    Private str电话号码 As String = String.Empty
    Private str邮政编码 As String = String.Empty
    Private str传真号码 As String = String.Empty
    Private str交货方式 As String = String.Empty
    Private str税率 As String = String.Empty

    Private str负责人姓名 As String = String.Empty
    Private str负责人电话 As String = String.Empty
    Private str负责人职务 As String = String.Empty
    Private str负责人邮箱 As String = String.Empty
    Private str负责人部门 As String = String.Empty

    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty

    Public Property 客户编号CD() As String
        Get
            Return str客户编号CD

        End Get
        Set(value As String)
            str客户编号CD = value
        End Set
    End Property
    Public Property 客户编号() As String
        Get
            Return str客户编号

        End Get
        Set(value As String)
            str客户编号 = value
        End Set
    End Property

    Public Property 客户名称() As String
        Get
            Return str客户名称

        End Get
        Set(value As String)
            str客户名称 = value
        End Set
    End Property

    Public Property 公司地址() As String
        Get
            Return str公司地址

        End Get
        Set(value As String)
            str公司地址 = value
        End Set
    End Property

    Public Property 电话号码() As String
        Get
            Return str电话号码

        End Get
        Set(value As String)
            str电话号码 = value
        End Set
    End Property
    Public Property 邮政编码() As String
        Get
            Return str邮政编码

        End Get
        Set(value As String)
            str邮政编码 = value
        End Set
    End Property
    Public Property 传真号码() As String
        Get
            Return str传真号码

        End Get
        Set(value As String)
            str传真号码 = value
        End Set
    End Property

    Public Property 负责人姓名() As String
        Get
            Return str负责人姓名

        End Get
        Set(value As String)
            str负责人姓名 = value
        End Set
    End Property


    Public Property 负责人电话() As String
        Get
            Return str负责人电话

        End Get
        Set(value As String)
            str负责人电话 = value
        End Set
    End Property

    Public Property 负责人职务() As String
        Get
            Return str负责人职务

        End Get
        Set(value As String)
            str负责人职务 = value
        End Set
    End Property

    Public Property 负责人邮箱() As String
        Get
            Return str负责人邮箱

        End Get
        Set(value As String)
            str负责人邮箱 = value
        End Set
    End Property


    Public Property 负责人部门() As String
        Get
            Return str负责人部门

        End Get
        Set(value As String)
            str负责人部门 = value
        End Set
    End Property

    Public Property 交货方式() As String
        Get
            Return str交货方式

        End Get
        Set(value As String)
            str交货方式 = value
        End Set
    End Property
    Public Property 税率() As String
        Get
            Return str税率

        End Get
        Set(ByVal value As String)
            str税率 = value
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
