Public Class M包装T

    Private _str包装物编号 As String = String.Empty
    Private _str包装物名称 As String = String.Empty
    Private _str规格 As String = String.Empty
    Private _str供应商编号 As String = String.Empty
    Private _str登录者 As String = String.Empty
    Private _str登录日期 As String = String.Empty
    Private _str更新者 As String = String.Empty
    Private _str更新日期 As String = String.Empty


    ''' <summary>
    ''' 包装物编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 包装物编号() As String
        Get
            Return _str包装物编号
        End Get
        Set(value As String)
            _str包装物编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 包装物名称    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 包装物名称() As String
        Get
            Return _str包装物名称
        End Get
        Set(value As String)
            _str包装物名称 = value
        End Set
    End Property

    ''' <summary>
    ''' 规格
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 规格() As String
        Get
            Return _str规格

        End Get
        Set(value As String)
            _str规格 = value
        End Set
    End Property

    ''' <summary>
    ''' 供应商编号    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 供应商编号() As String
        Get
            Return _str供应商编号
        End Get
        Set(value As String)
            _str供应商编号 = value
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
