Public Class B成品库存T

    '变量定义 
    Private str产品图号 As String = ""                  '部品番号　
    Private int库存数量 As Integer                    '库存数量
    Private int库存重量 As Integer                    '库存数量
    Private str制造批量号 As String = ""                      '制造批量号 
    Private str订单区分 As String = ""                      '制造区分 
    Private str库存状态 As String = ""                      '库存状态 
    Private str产品种类编号 As String = ""
    Private str客户编号 As String = ""
    Private str订单编号 As String = ""
    Private dt发货日期 As DateTime                     '订单日期
    Private dt发货日期2 As DateTime                     '订单日期
    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  金型番号
    '------------------------------------------------------------------------------------
    Public Property 客户编号() As String
        Get
            Return str客户编号
        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property
    Public Property 发货日期From() As DateTime
        Get
            Return dt发货日期
        End Get
        Set(ByVal Value As DateTime)
            dt发货日期 = Value
        End Set
    End Property
    Public Property 发货日期To() As DateTime
        Get
            Return dt发货日期2
        End Get
        Set(ByVal Value As DateTime)
            dt发货日期2 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  金型番号
    '------------------------------------------------------------------------------------
    Public Property 产品种类编号() As String
        Get
            Return str产品种类编号
        End Get
        Set(ByVal Value As String)
            str产品种类编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  库存数量
    '------------------------------------------------------------------------------------
    Public Property 库存数量() As Integer
        Get
            Return int库存数量
        End Get
        Set(ByVal Value As Integer)
            int库存数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 制造批量号() As String
        Get
            Return str制造批量号
        End Get
        Set(ByVal Value As String)
            str制造批量号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  制造区分
    '------------------------------------------------------------------------------------
    Public Property 订单区分() As String
        Get
            Return str订单区分
        End Get
        Set(ByVal Value As String)
            str订单区分 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  库存状态
    '------------------------------------------------------------------------------------
    Public Property 库存状态() As String
        Get
            Return str库存状态
        End Get
        Set(ByVal Value As String)
            str库存状态 = Value
        End Set
    End Property

End Class
