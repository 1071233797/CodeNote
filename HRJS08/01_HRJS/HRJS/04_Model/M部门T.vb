Public Class M部门T

    Private _str部门编号 As String = String.Empty
    Private _str部门名称 As String = String.Empty
    Private _str登录者 As String = String.Empty
    Private _str登录日期 As String = String.Empty
    Private _str更新者 As String = String.Empty
    Private _str更新日期 As String = String.Empty



    ''' <summary>
    ''' 部门编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 部门编号() As String
        Get
            Return _str部门编号
        End Get
        Set(value As String)
            _str部门编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 部门名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 部门名称() As String
        Get
            Return _str部门名称
        End Get
        Set(value As String)
            _str部门名称 = value
        End Set
    End Property

    Public Property 登录者() As String
        Get
            Return _str登录者
        End Get
        Set(value As String)
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
        Set(value As String)
            _str登录日期 = value
        End Set
    End Property

    Public Property 更新者()
        Get
            Return _str更新者
        End Get
        Set(value)
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
        Set(value As String)
            _str更新日期 = value
        End Set
    End Property

End Class
