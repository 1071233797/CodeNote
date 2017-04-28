Public Class B返品一览T

    '检索用
    Private str客户名称 As String = ""
    Private str客户编号 As String
    Private str产品图号 As String = ""
    Private str订单编号 As String = ""
    Private str库存区域 As String = ""
    Private str返品数量 As String = ""
    Private str生产日期 As String = ""
    Private str返品原因 As String = ""
    Private dt开始日期 As DateTime
    Private dt结束日期 As DateTime



#Region "属性"
    '------------------------------------------------------------------------------------
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 返品数量() As String
        Get
            Return str返品数量
        End Get
        Set(ByVal Value As String)
            str返品数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 生产日期() As String
        Get
            Return str生产日期
        End Get
        Set(ByVal Value As String)
            str生产日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  客户名称

    '------------------------------------------------------------------------------------
    Public Property 客户名称() As String
        Get
            Return str客户名称

        End Get
        Set(ByVal Value As String)
            str客户名称 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 返品原因() As String
        Get
            Return str返品原因

        End Get
        Set(ByVal Value As String)
            str返品原因 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  客户编号
    '------------------------------------------------------------------------------------
    Public Property 客户编号() As String
        Get
            Return str客户编号
        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  开始日期
    '------------------------------------------------------------------------------------
    Public Property 开始日期() As DateTime
        Get
            Return dt开始日期
        End Get
        Set(ByVal Value As DateTime)
            dt开始日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  结束日期
    '------------------------------------------------------------------------------------
    Public Property 结束日期() As DateTime
        Get
            Return dt结束日期
        End Get
        Set(ByVal Value As DateTime)
            dt结束日期 = Value
        End Set
    End Property



#Region "库存区域"
    Public Property 库存区域() As String
        Get
            Return str库存区域
        End Get
        Set(ByVal value As String)
            str库存区域 = value
        End Set
    End Property
#End Region

#End Region

End Class
