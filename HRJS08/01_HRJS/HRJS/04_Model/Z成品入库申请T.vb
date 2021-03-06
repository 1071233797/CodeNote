#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z成品入库申请T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str申请者编号 As String = String.Empty
    Private str申请日期1 As DateTime
    Private str申请日期2 As DateTime
    Private str产品图号 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str入库数量 As String = String.Empty
    Private str入库重量 As String = String.Empty
    Private str备注 As String = String.Empty
    Private str处理结果 As String = String.Empty
    Private str隐藏项 As String = String.Empty


    '------------------------------------------------------------------------------------
    '  备注
    '------------------------------------------------------------------------------------
    Public Property 隐藏项() As String
        Get
            Return str隐藏项
        End Get
        Set(ByVal Value As String)
            str隐藏项 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  备注
    '------------------------------------------------------------------------------------
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请单编号
    '------------------------------------------------------------------------------------
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  领料者编号
    '------------------------------------------------------------------------------------
    Public Property 申请者编号() As String
        Get
            Return str申请者编号
        End Get
        Set(ByVal Value As String)
            str申请者编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请日期
    '------------------------------------------------------------------------------------
    Public Property 申请日期1() As DateTime
        Get
            Return str申请日期1
        End Get
        Set(ByVal Value As DateTime)
            str申请日期1 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请日期
    '------------------------------------------------------------------------------------
    Public Property 申请日期2() As DateTime
        Get
            Return str申请日期2
        End Get
        Set(ByVal Value As DateTime)
            str申请日期2 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  产品图号
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
    '  入库数量
    '------------------------------------------------------------------------------------
    Public Property 入库数量() As String
        Get
            Return str入库数量
        End Get
        Set(ByVal Value As String)
            str入库数量 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  入库重量
    '------------------------------------------------------------------------------------
    Public Property 入库重量() As String
        Get
            Return str入库重量
        End Get
        Set(ByVal Value As String)
            str入库重量 = Value
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
    '  质检状态
    '------------------------------------------------------------------------------------
    Public Property 处理结果() As String
        Get
            Return str处理结果
        End Get
        Set(ByVal Value As String)
            str处理结果 = Value
        End Set
    End Property

End Class
Public Class Z成品标签打印
    Private str申请单编号 As String = String.Empty
    Private str产品图号 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str入库数量 As String = String.Empty
    Private str入库重量 As String = String.Empty
    Private str库存区域 As String = String.Empty


    '------------------------------------------------------------------------------------
    '  申请单编号
    '------------------------------------------------------------------------------------
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  产品图号
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
    '  入库数量
    '------------------------------------------------------------------------------------
    Public Property 入库数量() As String
        Get
            Return str入库数量
        End Get
        Set(ByVal Value As String)
            str入库数量 = Value
        End Set
    End Property


    '------------------------------------------------------------------------------------
    '  入库重量
    '------------------------------------------------------------------------------------
    Public Property 入库重量() As String
        Get
            Return str入库重量
        End Get
        Set(ByVal Value As String)
            str入库重量 = Value
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
    '  库存区域
    '------------------------------------------------------------------------------------
    Public Property 库存区域() As String
        Get
            Return str库存区域
        End Get
        Set(ByVal Value As String)
            str库存区域 = Value
        End Set
    End Property
End Class
