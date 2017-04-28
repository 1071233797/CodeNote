Public Class Z生产检查管理T

    Private _str检查者编号 As String = String.Empty
    Private _str检查ID As String = String.Empty
    Private _str检查日期 As DateTime
    Private _str检查日期s As DateTime
    Private _str检查日期e As DateTime
    Private _str订单编号 As String = String.Empty
    Private _str主图号 As String = String.Empty
    Private _str上级图号 As String = String.Empty
    Private _str分图号 As String = String.Empty
    Private _str工序编号 As String = String.Empty
    Private _str检查数量 As String = String.Empty
    Private _str检查内容 As String = String.Empty
    Private _str不良数量 As String = String.Empty
    Private _str不良原因 As String = String.Empty
    Private _str处理结果 As String = String.Empty
    Private _str备注 As String = String.Empty


    Public Property 检查ID() As String
        Get
            Return _str检查ID

        End Get
        Set(ByVal value As String)
            _str检查ID = value
        End Set
    End Property
    Public Property 上级图号() As String
        Get
            Return _str上级图号

        End Get
        Set(ByVal value As String)
            _str上级图号 = value
        End Set
    End Property
    Public Property 订单编号() As String
        Get
            Return _str订单编号

        End Get
        Set(ByVal value As String)
            _str订单编号 = value
        End Set
    End Property
    Public Property 主图号() As String
        Get
            Return _str主图号

        End Get
        Set(ByVal value As String)
            _str主图号 = value
        End Set
    End Property
    Public Property 分图号() As String
        Get
            Return _str分图号

        End Get
        Set(ByVal value As String)
            _str分图号 = value
        End Set
    End Property
    Public Property 工序编号() As String
        Get
            Return _str工序编号

        End Get
        Set(ByVal value As String)
            _str工序编号 = value
        End Set
    End Property
    Public Property 检查数量() As String
        Get
            Return _str检查数量

        End Get
        Set(ByVal value As String)
            _str检查数量 = value
        End Set
    End Property
    Public Property 检查内容() As String
        Get
            Return _str检查内容

        End Get
        Set(ByVal value As String)
            _str检查内容 = value
        End Set
    End Property
    Public Property 不良数量() As String
        Get
            Return _str不良数量

        End Get
        Set(ByVal value As String)
            _str不良数量 = value
        End Set
    End Property
    Public Property 不良原因() As String
        Get
            Return _str不良原因

        End Get
        Set(ByVal value As String)
            _str不良原因 = value
        End Set
    End Property
    Public Property 处理结果() As String
        Get
            Return _str处理结果

        End Get
        Set(ByVal value As String)
            _str处理结果 = value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return _str备注

        End Get
        Set(ByVal value As String)
            _str备注 = value
        End Set
    End Property
    Public Property 检查者编号() As String
        Get
            Return _str检查者编号

        End Get
        Set(ByVal value As String)
            _str检查者编号 = value
        End Set
    End Property
    Public Property 检查日期() As DateTime
        Get
            Return _str检查日期

        End Get
        Set(ByVal value As DateTime)
            _str检查日期 = value
        End Set
    End Property
    Public Property 检查日期s() As DateTime
        Get
            Return _str检查日期s

        End Get
        Set(ByVal value As DateTime)
            _str检查日期s = value
        End Set
    End Property
    Public Property 检查日期e() As DateTime
        Get
            Return _str检查日期e

        End Get
        Set(ByVal value As DateTime)
            _str检查日期e = value
        End Set
    End Property

End Class
