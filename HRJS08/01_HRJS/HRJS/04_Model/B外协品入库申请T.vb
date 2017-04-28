Public Class B外协品入库申请T

    '检索用
    Private str申请单编号 As String = ""
    Private str申请者编号 As String
    Private str职务 As String = ""
    Private str部门 As String = ""
    Private str申请日期1 As DateTime
    Private str申请日期2 As DateTime
    Private str主图号 As String = ""
    Private str产品图号 As String = ""
    Private str上级图号 As String = ""
    Private str外协计划单 As String
    Private str外协品名称 As String
    Private str外协厂家 As String
    Private str订单客户名称 As String
    Private str订单编号 As String
    Private str入库数量 As String
    Private str单重 As String

    Private str质检状态 As String
    Private str检查者编号 As String
    Private str异常数量 As String
    Private str异常原因 As String
    Private str备注 As String

    Private str登陆者 As String
    Private str登陆日期 As String
    Private str更新者 As String
    Private str更新日期 As String
    Private str外协加工工序编号 As String
    Private str取值 As String
   
    Public Property 检查者编号() As String
        Get
            Return str检查者编号
        End Get
        Set(ByVal Value As String)
            str检查者编号 = Value
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

    Public Property 申请单编号() As String
        Get
            Return str申请单编号
        End Get
        Set(ByVal Value As String)
            str申请单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请者编号
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
    '  职务
    '------------------------------------------------------------------------------------
    Public Property 职务() As String
        Get
            Return str职务

        End Get
        Set(ByVal Value As String)
            str职务 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部门
    '------------------------------------------------------------------------------------
    Public Property 部门() As String
        Get
            Return str部门

        End Get
        Set(ByVal Value As String)
            str部门 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请日期
    '------------------------------------------------------------------------------------
    Public Property 申请日期1() As String
        Get
            Return str申请日期1

        End Get
        Set(ByVal Value As String)
            str申请日期1 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  申请日期2
    '------------------------------------------------------------------------------------
    Public Property 申请日期2() As String
        Get
            Return str申请日期2

        End Get
        Set(ByVal Value As String)
            str申请日期2 = Value
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
    '  外协计划单号
    '------------------------------------------------------------------------------------
    Public Property 外协计划单() As String
        Get
            Return str外协计划单
        End Get
        Set(ByVal Value As String)
            str外协计划单 = Value
        End Set
    End Property

    Public Property 外协品名称() As String
        Get
            Return str外协品名称
        End Get
        Set(ByVal value As String)
            str外协品名称 = value
        End Set
    End Property
    Public Property 外协厂家() As String
        Get
            Return str外协厂家
        End Get
        Set(ByVal value As String)
            str外协厂家 = value
        End Set
    End Property
    Public Property 订单客户名称() As String
        Get
            Return str订单客户名称
        End Get
        Set(ByVal value As String)
            str订单客户名称 = value
        End Set
    End Property

    Public Property 订单编号() As String
        Get
            Return str订单编号
        End Get
        Set(ByVal value As String)
            str订单编号 = value
        End Set
    End Property

    Public Property 入库数量() As String
        Get
            Return str入库数量
        End Get
        Set(ByVal value As String)
            str入库数量 = value
        End Set
    End Property

    Public Property 单重() As String
        Get
            Return str单重
        End Get
        Set(ByVal value As String)
            str单重 = value
        End Set
    End Property

    Public Property 质检状态() As String
        Get
            Return str质检状态
        End Get
        Set(ByVal value As String)
            str质检状态 = value
        End Set
    End Property

    Public Property 登陆者() As String
        Get
            Return str登陆者
        End Get
        Set(ByVal value As String)
            str登陆者 = value
        End Set
    End Property
    Public Property 登陆日期() As String
        Get
            Return str登陆日期
        End Get
        Set(ByVal value As String)
            str登陆日期 = value
        End Set
    End Property

    Public Property 更新者() As String
        Get
            Return str更新者
        End Get
        Set(ByVal value As String)
            str更新者 = value
        End Set
    End Property
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(ByVal value As String)
            str更新日期 = value
        End Set
    End Property
    Public Property 外协加工工序编号() As String
        Get
            Return str外协加工工序编号

        End Get
        Set(ByVal Value As String)
            str外协加工工序编号 = Value
        End Set
    End Property
    Public Property 取值() As String
        Get
            Return str取值

        End Get
        Set(ByVal Value As String)
            str取值 = Value
        End Set
    End Property
End Class
