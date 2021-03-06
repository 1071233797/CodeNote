#Region "原材料出库申请基础类"
'   创建人: 李陈盛
'   创建日期: 2016/8/29
#End Region

Public Class Z原材料出库申请T

    '变量定义 
    Private str申请单编号 As String = String.Empty
    Private str领料者编号 As String = String.Empty
    Private str领料日期 As String = String.Empty
    Private str材料编号 As String = String.Empty
    Private str材料区分 As String = String.Empty
    Private str长 As String = String.Empty
    Private str宽 As String = String.Empty
    Private str高 As String = String.Empty
    Private str领料数量 As String = String.Empty
    Private str领料重量 As String = String.Empty
    Private str订单编号 As String = String.Empty
    Private str主图号 As String = String.Empty
    Private str上级图号 As String = String.Empty
    Private str分图号 As String = String.Empty

    Private str备注 As String = String.Empty
    Private str审核人 As String = String.Empty
    Private str审核状态 As String = String.Empty
    Private str审核备注 As String = String.Empty

    Private str登陆者 As String = String.Empty
    Private str登陆日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    Private str开始日期 As DateTime
    Private str结束日期 As DateTime

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
    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
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
    '------------------------------------------------------------------------------------
    '  领料者编号
    '------------------------------------------------------------------------------------
    Public Property 领料者编号() As String
        Get
            Return str领料者编号
        End Get
        Set(ByVal Value As String)
            str领料者编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  领料日期
    '------------------------------------------------------------------------------------
    Public Property 领料日期() As String
        Get
            Return str领料日期
        End Get
        Set(ByVal Value As String)
            str领料日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  材料编号
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
    '  长
    '------------------------------------------------------------------------------------
    Public Property 长() As String
        Get
            Return str长
        End Get
        Set(ByVal Value As String)
            str长 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  宽
    '------------------------------------------------------------------------------------
    Public Property 宽() As String
        Get
            Return str宽
        End Get
        Set(ByVal Value As String)
            str宽 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  高
    '------------------------------------------------------------------------------------
    Public Property 高() As String
        Get
            Return str高
        End Get
        Set(ByVal Value As String)
            str高 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  领料数量
    '------------------------------------------------------------------------------------
    Public Property 领料数量() As String
        Get
            Return str领料数量
        End Get
        Set(ByVal Value As String)
            str领料数量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  领料重量
    '------------------------------------------------------------------------------------
    Public Property 领料重量() As String
        Get
            Return str领料重量
        End Get
        Set(ByVal Value As String)
            str领料重量 = Value
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
    '  总图号
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
    '  审核人
    '------------------------------------------------------------------------------------
    Public Property 审核人() As String
        Get
            Return str审核人
        End Get
        Set(ByVal Value As String)
            str审核人 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  审核状态
    '------------------------------------------------------------------------------------
    Public Property 审核状态() As String
        Get
            Return str审核状态
        End Get
        Set(ByVal Value As String)
            str审核状态 = Value
        End Set
    End Property
    Public Property 审核备注() As String
        Get
            Return str审核备注
        End Get
        Set(ByVal Value As String)
            str审核备注 = Value
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
        Set(ByVal Value As DateTime)
            str开始日期 = Value
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
