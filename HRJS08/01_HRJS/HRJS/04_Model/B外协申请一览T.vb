Public Class B外协申请一览T

    Private _str订单编号 As String = String.Empty
    Private _str外协申请日期 As String = String.Empty
    Private _str产品图号 As String = String.Empty
    Private _str外协工序 As String = String.Empty
    Private _str外协加工状态 As String = String.Empty
    Private _str登录者 As String = String.Empty
    Private _str登录日期 As String = String.Empty
    Private _str更新者 As String = String.Empty
    Private _str更新日期 As String = String.Empty
    Private _str外协申请日期起 As String = String.Empty
    Private _str外协申请日期止 As String = String.Empty



    ''' <summary>
    ''' 订单编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 订单编号() As String
        Get
            Return _str订单编号
        End Get
        Set(ByVal value As String)
            _str订单编号 = value
        End Set
    End Property
    ''' <summary>
    ''' 产品图号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品图号() As String
        Get
            Return _str产品图号
        End Get
        Set(ByVal value As String)
            _str产品图号 = value
        End Set
    End Property
    ''' <summary>
    ''' 外协工序
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 外协工序() As String
        Get
            Return _str外协工序
        End Get
        Set(ByVal value As String)
            _str外协工序 = value
        End Set
    End Property
    ''' <summary>
    ''' 外协加工状态
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 外协加工状态() As String
        Get
            Return _str外协加工状态
        End Get
        Set(ByVal value As String)
            _str外协加工状态 = value
        End Set
    End Property

    ''' <summary>
    ''' 外协申请日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 外协申请日期() As String
        Get
            Return _str外协申请日期
        End Get
        Set(ByVal value As String)
            _str外协申请日期 = value
        End Set
    End Property
    Public Property 外协申请日期起() As String
        Get
            Return _str外协申请日期起
        End Get
        Set(ByVal value As String)
            _str外协申请日期起 = value
        End Set
    End Property
    Public Property 外协申请日期止() As String
        Get
            Return _str外协申请日期止
        End Get
        Set(ByVal value As String)
            _str外协申请日期止 = value
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

    ''' <summary>
    ''' 登录日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登录日期() As String
        Get
            Return _str登录日期
        End Get
        Set(ByVal value As String)
            _str登录日期 = value
        End Set
    End Property

    Public Property 更新者()
        Get
            Return _str更新者
        End Get
        Set(ByVal value)
            _str更新者 = value
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
            Return _str更新日期
        End Get
        Set(ByVal value As String)
            _str更新日期 = value
        End Set
    End Property

End Class


