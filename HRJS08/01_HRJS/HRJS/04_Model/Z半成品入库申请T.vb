#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z半成品入库申请T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str申请者编号 As String = String.Empty
    Private str申请日期 As String = String.Empty
    Private str分图号 As String = String.Empty
    Private str检查日期 As String = String.Empty
    Private str检查者编号 As String = String.Empty

    Private str不良数量 As String = String.Empty
    Private str不良原因 As String = String.Empty
    Private str检查内容 As String = String.Empty
    Private str检查数量 As String = String.Empty
    ' Private str处理结果结果 As String = String.Empty

    Private str备注 As String = String.Empty
    Private str半成品种类 As String = String.Empty
    Private str已完成半成品 As String = String.Empty
    Private str未完成半成品 As String = String.Empty
    Private str工序编号 As String = String.Empty
    Private str工序名称 As String = String.Empty
    Private str半成品名称 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str主图号 As String = String.Empty
    Private str上级图号 As String = String.Empty
    Private str入库数量 As String = String.Empty
    Private str客户名称 As String = String.Empty
    Private str登陆者 As String = String.Empty
    Private str登陆日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    Private str开始日期 As DateTime
    Private str结束日期 As DateTime
    Private str处理结果 As String = String.Empty
    '------------------------------------------------------------------------------------
    '  检查者编号
    '------------------------------------------------------------------------------------
    Public Property 检查日期() As String
        Get
            Return str检查日期
        End Get
        Set(ByVal Value As String)
            str检查日期 = Value
        End Set
    End Property
    Public Property 工序编号() As String
        Get
            Return str工序编号
        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
        End Set
    End Property
    Public Property 半成品种类() As String
        Get
            Return str半成品种类
        End Get
        Set(ByVal Value As String)
            str半成品种类 = Value
        End Set
    End Property
    Public Property 已完成半成品() As String
        Get
            Return str已完成半成品
        End Get
        Set(ByVal Value As String)
            str已完成半成品 = Value
        End Set
    End Property
    Public Property 未完成半成品() As String
        Get
            Return str未完成半成品
        End Get
        Set(ByVal Value As String)
            str未完成半成品 = Value
        End Set
    End Property
    Public Property 检查者编号() As String
        Get
            Return str检查者编号
        End Get
        Set(ByVal Value As String)
            str检查者编号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 不良数量() As String
        Get
            Return str不良数量
        End Get
        Set(ByVal Value As String)
            str不良数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 检查数量() As String
        Get
            Return str检查数量
        End Get
        Set(ByVal Value As String)
            str检查数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常数量
    '------------------------------------------------------------------------------------
    Public Property 检查内容() As String
        Get
            Return str检查内容
        End Get
        Set(ByVal Value As String)
            str检查内容 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  异常原因
    '------------------------------------------------------------------------------------
    Public Property 不良原因() As String
        Get
            Return str不良原因
        End Get
        Set(ByVal Value As String)
            str不良原因 = Value
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
    '  工序名称
    '------------------------------------------------------------------------------------
    Public Property 工序名称() As String
        Get
            Return str工序名称
        End Get
        Set(ByVal Value As String)
            str工序名称 = Value
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
    Public Property 申请日期() As String
        Get
            Return str申请日期
        End Get
        Set(ByVal Value As String)
            str申请日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  产品图号
    '------------------------------------------------------------------------------------
    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  上级图号
    '------------------------------------------------------------------------------------
    Public Property 上级图号() As String
        Get
            Return str上级图号
        End Get
        Set(ByVal Value As String)
            str上级图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str半成品名称
    '------------------------------------------------------------------------------------
    Public Property 半成品名称() As String
        Get
            Return str半成品名称
        End Get
        Set(ByVal Value As String)
            str半成品名称 = Value
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
    '  主图号
    '------------------------------------------------------------------------------------
    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  登陆者
    '------------------------------------------------------------------------------------
    Public Property 登陆者() As String
        Get
            Return str登陆者
        End Get
        Set(ByVal Value As String)
            str登陆者 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  登陆日期
    '------------------------------------------------------------------------------------
    Public Property 登陆日期() As String
        Get
            Return str登陆日期
        End Get
        Set(ByVal Value As String)
            str登陆日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新者
    '------------------------------------------------------------------------------------
    Public Property 更新者() As String
        Get
            Return str更新者
        End Get
        Set(ByVal Value As String)
            str更新者 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新日期
    '------------------------------------------------------------------------------------
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(ByVal Value As String)
            str更新日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新日期
    '------------------------------------------------------------------------------------
    Public Property 开始日期() As DateTime
        Get
            Return str开始日期
        End Get
        Set(ByVal value As DateTime)
            str开始日期 = value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  更新日期
    '------------------------------------------------------------------------------------
    Public Property 结束日期() As DateTime
        Get
            Return str结束日期
        End Get
        Set(ByVal Value As DateTime)
            str结束日期 = Value
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
#Region "半成品标签打印"
Public Class Z半成品标签打印
    Private str申请单编号 As String = String.Empty
    Private str分图号 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str主图号 As String = String.Empty
    Private str上级图号 As String = String.Empty
    Private str入库数量 As String = String.Empty
    Private str半成品种类 As String = String.Empty
    Private str库存区域 As String = String.Empty
    Private str库存编号 As String = String.Empty
    Private str工序编号 As String = String.Empty
    Public Property 半成品种类() As String
        Get
            Return str半成品种类
        End Get
        Set(ByVal Value As String)
            str半成品种类 = Value
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
    '  产品图号
    '------------------------------------------------------------------------------------
    Public Property 上级图号() As String
        Get
            Return str上级图号
        End Get
        Set(ByVal Value As String)
            str上级图号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  产品图号
    '------------------------------------------------------------------------------------
    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
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
    '  主图号
    '------------------------------------------------------------------------------------
    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
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

    '------------------------------------------------------------------------------------
    '  库存编号
    '------------------------------------------------------------------------------------
    Public Property 库存编号() As String
        Get
            Return str库存编号
        End Get
        Set(ByVal Value As String)
            str库存编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  工序编号
    '------------------------------------------------------------------------------------
    Public Property 工序编号() As String
        Get
            Return str工序编号
        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
        End Set
    End Property
End Class
#End Region