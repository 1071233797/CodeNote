Public Class M产品种类T

    Private _str产品种类编号 As String = String.Empty
    Private _str产品种类名称 As String = String.Empty


    ''' <summary>
    ''' 产品种类编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品种类编号() As String
        Get
            Return _str产品种类编号
        End Get
        Set(value As String)
            _str产品种类编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 产品种类名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 产品种类名称() As String
        Get
            Return _str产品种类名称
        End Get
        Set(value As String)
            _str产品种类名称 = value
        End Set
    End Property
End Class
