#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z外协品出库申请T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str申请者编号 As String = String.Empty
    Private str申请日期 As String = String.Empty
    Private str流转票编号 As String = String.Empty
    Private str外协品名称 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str产品图号 As String = String.Empty
    Private str主图号 As String = String.Empty
    Private str上级图号 As String = String.Empty
    Private str出库数量 As String = String.Empty
    Private str客户名称 As String = String.Empty
    Private str登陆者 As String = String.Empty
    Private str登陆日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    Private str备注 As String = String.Empty
    Private str开始日期 As DateTime
    Private str结束日期 As DateTime
    Private str外协工序 As String = String.Empty
    Private str工序编号 As String = String.Empty
    Private str分图号 As String = String.Empty

    '------------------------------------------------------------------------------------
    '  申请单编号
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
    '  申请单编号
    '------------------------------------------------------------------------------------
    Public Property 工序编号() As String
        Get
            Return str工序编号
        End Get
        Set(ByVal Value As String)
            str工序编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请单编号
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
    '  申请单编号
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
    Public Property 外协工序() As String
        Get
            Return str外协工序
        End Get
        Set(ByVal Value As String)
            str外协工序 = Value
        End Set
    End Property
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
    '  流转票编号
    '------------------------------------------------------------------------------------
    Public Property 流转票编号() As String
        Get
            Return str流转票编号
        End Get
        Set(ByVal Value As String)
            str流转票编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  str外协品名称
    '------------------------------------------------------------------------------------
    Public Property 外协品名称() As String
        Get
            Return str外协品名称
        End Get
        Set(ByVal Value As String)
            str外协品名称 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  出库数量
    '------------------------------------------------------------------------------------
    Public Property 出库数量() As String
        Get
            Return str出库数量
        End Get
        Set(ByVal Value As String)
            str出库数量 = Value
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

End Class
