#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class B原材料入库申请T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str采购单编号 As String = String.Empty
    Private str申请者编号 As String = String.Empty
    Private str检查者编号 As String = String.Empty

    Private str申请日期 As String = String.Empty
    Private str材料编号 As String = String.Empty
    Private str材料区分 As String = String.Empty
    Private str材料名称 As String = String.Empty
    Private str材料种类 As String = String.Empty
    Private str材质 As String = String.Empty
    Private str入库数量 As String = String.Empty
    Private str入库重量 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str产品图号 As String = String.Empty
    Private str客户名称 As String = String.Empty
    Private str长 As String = String.Empty
    Private str宽 As String = String.Empty
    Private str高 As String = String.Empty

    Private str异常数量 As String = String.Empty
    Private str异常原因 As String = String.Empty
    Private str备注 As String = String.Empty
    Private str质检状态 As String = String.Empty
    Private str供应商批次号 As String = String.Empty
    Private str批次号 As String = String.Empty
    'Private str备注 As String = String.Empty

    'Private str登陆者 As String = String.Empty
    'Private str登陆日期 As String = String.Empty
    'Private str更新者 As String = String.Empty
    'Private str更新日期 As String = String.Empty
    Private str开始日期 As DateTime
    Private str结束日期 As DateTime
    Public Property 长() As String
        Get
            Return str长
        End Get
        Set(ByVal Value As String)
            str长 = Value
        End Set
    End Property
    Public Property 宽() As String
        Get
            Return str宽
        End Get
        Set(ByVal Value As String)
            str宽 = Value
        End Set
    End Property
    Public Property 高() As String
        Get
            Return str高
        End Get
        Set(ByVal Value As String)
            str高 = Value
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
    Public Property 采购单编号() As String
        Get
            Return str采购单编号
        End Get
        Set(ByVal Value As String)
            str采购单编号 = Value
        End Set
    End Property

    Public Property 异常数量() As String
        Get
            Return str异常数量
        End Get
        Set(ByVal Value As String)
            str异常数量 = Value
        End Set
    End Property
    Public Property 异常原因() As String
        Get
            Return str异常原因
        End Get
        Set(ByVal Value As String)
            str异常原因 = Value
        End Set
    End Property
    Public Property 备注() As String
        Get
            Return str备注
        End Get
        Set(ByVal Value As String)
            str备注 = Value
        End Set
    End Property
    Public Property 质检状态() As String
        Get
            Return str质检状态
        End Get
        Set(ByVal Value As String)
            str质检状态 = Value
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
    '  申请者
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
    '  材料名称
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
    '  str材料区分
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
    '  str材料区分
    '------------------------------------------------------------------------------------
    Public Property 材料名称() As String
        Get
            Return str材料名称
        End Get
        Set(ByVal Value As String)
            str材料名称 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str材料种类
    '------------------------------------------------------------------------------------
    Public Property 材料种类() As String
        Get
            Return str材料种类
        End Get
        Set(ByVal Value As String)
            str材料种类 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str材料区分
    '------------------------------------------------------------------------------------
    Public Property 材质() As String
        Get
            Return str材质
        End Get
        Set(ByVal Value As String)
            str材质 = Value
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
    '  登陆者
    '------------------------------------------------------------------------------------
    'Public Property 登陆者() As String
    '    Get
    '        Return str登陆者
    '    End Get
    '    Set(ByVal Value As String)
    '        str登陆者 = Value
    '    End Set
    'End Property

    ''------------------------------------------------------------------------------------
    ''  登陆日期
    ''------------------------------------------------------------------------------------
    'Public Property 登陆日期() As String
    '    Get
    '        Return str登陆日期
    '    End Get
    '    Set(ByVal Value As String)
    '        str登陆日期 = Value
    '    End Set
    'End Property

    ''------------------------------------------------------------------------------------
    ''  更新者
    ''------------------------------------------------------------------------------------
    'Public Property 更新者() As String
    '    Get
    '        Return str更新者
    '    End Get
    '    Set(ByVal Value As String)
    '        str更新者 = Value
    '    End Set
    'End Property

    ''------------------------------------------------------------------------------------
    ''  更新日期
    ''------------------------------------------------------------------------------------
    Public Property 批次号() As String
        Get
            Return str批次号
        End Get
        Set(ByVal Value As String)
            str批次号 = Value
        End Set
    End Property
    Public Property 供应商批次号() As String
        Get
            Return str供应商批次号
        End Get
        Set(ByVal Value As String)
            str供应商批次号 = Value
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

End Class
