Public Class B外协品入出库一览T

    '检索用
    Private str入出库区分 As String = ""
    Private str客户编号 As String
    Private str产品图号 As String = ""
    Private str订单编号 As String = ""
    Private str数量 As String = ""
    Private str入出库日期 As String = ""
    Private str出库去向 As String
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

    '------------------------------------------------------------------------------------
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 数量() As String
        Get
            Return str数量
        End Get
        Set(ByVal Value As String)
            str数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 入出库日期() As String
        Get
            Return str入出库日期
        End Get
        Set(ByVal Value As String)
            str入出库日期 = Value
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
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 出库去向() As String
        Get
            Return str出库去向

        End Get
        Set(ByVal Value As String)
            str出库去向 = Value
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



#Region "订单编号"
    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal value As String)
            str订单编号 = value
        End Set
    End Property
#End Region

#End Region

End Class
