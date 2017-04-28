Public Class B原材料入出库一览T

    '检索用
    Private str入出库申请单编号 As String = ""
    Private str材料编号 As String = ""
    Private str入出库区分 As String = ""
    Private str材料区分 As String = ""
    Private str客户编号 As String
    Private str供应商编号 As String

    Private dt开始日期 As DateTime
    Private dt结束日期 As DateTime
    Private int入出库记录CD As Integer
    Private str订单编号 As String = ""

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
    '  制造批量号
    '------------------------------------------------------------------------------------
    Public Property 材料编号() As String
        Get
            Return str材料编号
        End Get
        Set(ByVal Value As String)
            str材料编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 材料区分() As String
        Get
            Return str材料区分
        End Get
        Set(ByVal Value As String)
            str材料区分 = Value
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
    Public Property 供应商编号() As String
        Get
            Return str供应商编号
        End Get
        Set(ByVal Value As String)
            str供应商编号 = Value
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

#Region "入出库记录CD"
    Public Property 入出库记录CD As Integer
        Get
            Return int入出库记录CD
        End Get
        Set(value As Integer)
            int入出库记录CD = value
        End Set
    End Property
#End Region

#Region "订单编号"
    Public Property 订单编号 As String
        Get
            Return str订单编号
        End Get
        Set(value As String)
            str订单编号 = value
        End Set
    End Property
#End Region

#End Region

End Class
