Public Class B成品库存盘点T

    Private _str产品图号 As String
    Private _str名称 As String
    Private _str客户编号 As String
    Private _str客户名称 As String
    Private _str订单编号 As String
    Private _str入库日期1 As DateTime
    Private _str入库日期2 As DateTime
    Private _str在库数量 As String
    Private _str在库重量 As String
    Private _str盘点数量 As String
    Private _str盘点重量 As String
    Private _str差异数量 As String
    Private _str差异重量 As String
    Private _str差额调整数量 As String
    Private _str差额调整重量 As String
    Private _str处理方式 As String
    Private _str调整后在库数量 As String
    Private _str调整后在库重量 As String
    Private _str库存状态 As String
    Private _str仅显示差异项 As String


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
    ''' 名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 名称() As String
        Get
            Return _str名称
        End Get
        Set(ByVal value As String)
            _str名称 = value
        End Set
    End Property

    ''' <summary>
    ''' 客户编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 客户编号() As String
        Get
            Return _str客户编号
        End Get
        Set(ByVal value As String)
            _str客户编号 = value
        End Set
    End Property

    ''' <summary>
    ''' 客户名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 客户名称() As String
        Get
            Return _str客户名称
        End Get
        Set(ByVal value As String)
            _str客户名称 = value
        End Set
    End Property

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
    Public Property 仅显示差异项() As String
        Get
            Return _str仅显示差异项
        End Get
        Set(ByVal Value As String)
            _str仅显示差异项 = Value
        End Set
    End Property
    ''' <summary>
    ''' 入库日期1
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 入库日期1() As DateTime
        Get
            Return _str入库日期1
        End Get
        Set(ByVal value As DateTime)
            _str入库日期1 = value
        End Set
    End Property

    ''' <summary>
    ''' 入库日期2
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 入库日期2() As DateTime
        Get
            Return _str入库日期2
        End Get
        Set(ByVal value As DateTime)
            _str入库日期2 = value
        End Set
    End Property

    ''' <summary>
    ''' 在库数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 在库数量() As String
        Get
            Return _str在库数量
        End Get
        Set(ByVal value As String)
            _str在库数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 在库重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 在库重量() As String
        Get
            Return _str在库重量
        End Get
        Set(ByVal value As String)
            _str在库重量 = value
        End Set
    End Property

    ''' <summary>
    ''' 盘点数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 盘点数量() As String
        Get
            Return _str盘点数量
        End Get
        Set(ByVal value As String)
            _str盘点数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 盘点重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 盘点重量() As String
        Get
            Return _str盘点重量
        End Get
        Set(ByVal value As String)
            _str盘点重量 = value
        End Set
    End Property

    ''' <summary>
    ''' 差异数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 差异数量() As String
        Get
            Return _str差异数量
        End Get
        Set(ByVal value As String)
            _str差异数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 差异重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 差异重量() As String
        Get
            Return _str差异重量
        End Get
        Set(ByVal value As String)
            _str差异重量 = value
        End Set
    End Property
    ''' <summary>
    ''' 差额调整数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 差额调整数量() As String
        Get
            Return _str差额调整数量
        End Get
        Set(ByVal value As String)
            _str差额调整数量 = value
        End Set
    End Property
    ''' <summary>
    ''' 差额调整重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 差额调整重量() As String
        Get
            Return _str差额调整重量
        End Get
        Set(ByVal value As String)
            _str差额调整重量 = value
        End Set
    End Property
    ''' <summary>
    ''' 处理方式
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 处理方式() As String
        Get
            Return _str处理方式
        End Get
        Set(ByVal value As String)
            _str处理方式 = value
        End Set
    End Property

    ''' <summary>
    ''' 调整后在库数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 调整后在库数量() As String
        Get
            Return _str调整后在库数量
        End Get
        Set(ByVal value As String)
            _str调整后在库数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 调整后在库重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 调整后在库重量() As String
        Get
            Return _str调整后在库重量
        End Get
        Set(ByVal value As String)
            _str调整后在库重量 = value
        End Set
    End Property

    ''' <summary>
    ''' 库存状态
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 库存状态() As String
        Get
            Return _str库存状态
        End Get
        Set(ByVal value As String)
            _str库存状态 = value
        End Set
    End Property
End Class
