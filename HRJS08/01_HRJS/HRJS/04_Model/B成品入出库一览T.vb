Public Class B成品入出库一览T

    '检索用
    Private str入出库申请单编号 As String = ""
    Private str订单编号 As String = ""
    Private str入出库区分 As String = ""
    Private str订单区分 As String = ""
    Private str产品图号 As String = ""
    Private str客户编号 As String
    Private str库存状态 As String
    Private dt入出库日期 As DateTime
    Private dt入出库日期1 As DateTime
    Private int入出库记录CD As Integer
    Private str入出库数量 As String = ""
    Private str操作者 As String = ""

#Region "属性"
    '------------------------------------------------------------------------------------
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 入出库申请单编号() As String
        Get
            Return str入出库申请单编号
        End Get
        Set(ByVal Value As String)
            str入出库申请单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal Value As String)
            str订单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  入出库区分
    '------------------------------------------------------------------------------------
    Public Property 入出库区分() As String
        Get
            Return str入出库区分
        End Get
        Set(ByVal Value As String)
            str入出库区分 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  订单区分

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
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 产品图号() As String
        Get
            Return str产品图号

        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
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
    '  入出库日期
    '------------------------------------------------------------------------------------
    Public Property 入出库日期() As DateTime
        Get
            Return dt入出库日期
        End Get
        Set(ByVal Value As DateTime)
            dt入出库日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  入出库日期
    '------------------------------------------------------------------------------------
    Public Property 入出库日期1() As DateTime
        Get
            Return dt入出库日期1
        End Get
        Set(ByVal Value As DateTime)
            dt入出库日期1 = Value
        End Set
    End Property

#Region "入出库记录CD"
    Public Property 入出库记录CD() As Integer
        Get
            Return int入出库记录CD
        End Get
        Set(ByVal value As Integer)
            int入出库记录CD = value
        End Set
    End Property
#End Region

#Region "库存状态"
    Public Property 库存状态() As String
        Get
            Return str库存状态
        End Get
        Set(ByVal value As String)
            str库存状态 = value
        End Set
    End Property
#End Region
#Region "入出库数量"
    Public Property 入出库数量() As String
        Get
            Return str入出库数量
        End Get
        Set(ByVal value As String)
            str入出库数量 = value
        End Set
    End Property
#End Region
#Region "操作者"
    Public Property 操作者() As String
        Get
            Return str操作者
        End Get
        Set(ByVal value As String)
            str操作者 = value
        End Set
    End Property
#End Region
#End Region

End Class
