Public Class M货位T

    Private _str货位编号 As String = String.Empty
    Private _str货位名称 As String = String.Empty

    ''' <summary>
    ''' 货位编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 货位编号() As String
        Get
            Return _str货位编号
        End Get
        Set(ByVal value As String)
            _str货位编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 货位名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 货位名称() As String
        Get
            Return _str货位名称
        End Get
        Set(ByVal value As String)
            _str货位名称 = value
        End Set
    End Property

End Class
