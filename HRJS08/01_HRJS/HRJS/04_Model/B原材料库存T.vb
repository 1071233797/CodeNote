Public Class M原材料库存T

    '变量定义 

    Private str材料编号 As String = ""                       '部品番号　
    Private str材料区分 As String = ""                       '制造区分 
    Private str材料类别 As String = ""                       '制造区分 
    Private str材质型号 As String = ""                       '制造区分 

    Private str库存总数量 As String = ""                     '库存数量
    Private str库存总重量 As String = ""                     '库存数量
    Private str库存数量 As String = ""                       '库存数量
    Private str库存重量 As String = ""                       '库存数量

    Private str材料批号 As String = ""                       '制造批量号 
    Private str库存区域 As String = ""                       '制造批量号 

    Private str库存状态 As String = ""                       '库存状态 
    Private dt入库日期From As DateTime                       '订单日期
    Private dt入库日期To As DateTime                         '订单日期

    Private str供应商编号 As String = ""                     '作成者
    Private str含税单价 As String = ""                       'CENO
    Private str含税总金额 As String = ""                     '佳能要求
    Private str备注 As String = ""                           '作成者

    '------------------------------------------------------------------------------------
    '  含税单价
    '------------------------------------------------------------------------------------
    Public Property 含税单价() As String
        Get
            Return str含税单价
        End Get
        Set(ByVal Value As String)
            str含税单价 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  含税总金额
    '------------------------------------------------------------------------------------
    Public Property 含税总金额() As String
        Get
            Return str含税总金额
        End Get
        Set(ByVal Value As String)
            str含税总金额 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  供应商编号
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
    '  入库日期From
    '------------------------------------------------------------------------------------
    Public Property 入库日期From() As DateTime
        Get
            Return dt入库日期From
        End Get
        Set(ByVal Value As DateTime)
            dt入库日期From = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  入库日期To
    '------------------------------------------------------------------------------------
    Public Property 入库日期To() As DateTime
        Get
            Return dt入库日期To
        End Get
        Set(ByVal Value As DateTime)
            dt入库日期To = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  部品番号
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
    '  库存数量
    '------------------------------------------------------------------------------------
    Public Property 库存数量() As String
        Get
            Return str库存数量
        End Get
        Set(ByVal Value As String)
            str库存数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  库存数量
    '------------------------------------------------------------------------------------
    Public Property 库存总重量() As String
        Get
            Return str库存总重量
        End Get
        Set(ByVal Value As String)
            str库存总重量 = Value
        End Set
    End Property
    Public Property 库存总数量() As String
        Get
            Return str库存总数量
        End Get
        Set(ByVal Value As String)
            str库存总数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  库存数量
    '------------------------------------------------------------------------------------
    Public Property 库存重量() As String
        Get
            Return str库存重量
        End Get
        Set(ByVal Value As String)
            str库存重量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  材料批号
    '------------------------------------------------------------------------------------
    Public Property 材料批号() As String
        Get
            Return str材料批号
        End Get
        Set(ByVal Value As String)
            str材料批号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  材料类别
    '------------------------------------------------------------------------------------
    Public Property 材料类别() As String
        Get
            Return str材料类别
        End Get
        Set(ByVal Value As String)
            str材料类别 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  材料区分
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
    '  材质型号
    '------------------------------------------------------------------------------------
    Public Property 材质型号() As String
        Get
            Return str材质型号
        End Get
        Set(ByVal Value As String)
            str材质型号 = Value
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
End Class



Public Class B原材料标签打印T


    Private str申请单编号 As String = String.Empty
    Private str材料编号 As String = String.Empty
    Private str材料名称 As String = String.Empty
    Private str宽 As String = String.Empty
    Private str长 As String = String.Empty
    Private str高 As String = String.Empty
    Private str数量 As String = String.Empty
    Private str重量 As String = String.Empty
    Private str批次 As String = String.Empty
    Private str库存区域 As String = String.Empty
    Private str库存名称 As String = String.Empty
    Private str打印者 As String = String.Empty
    Private str打印时间 As String = String.Empty

    ''' <summary>
    ''' 申请单编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 申请单编号() As String
        Get
            Return str申请单编号

        End Get
        Set(ByVal value As String)
            str申请单编号 = value
        End Set
    End Property
    ''' <summary>
    ''' 材料编号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 材料编号() As String
        Get
            Return str材料编号

        End Get
        Set(ByVal value As String)
            str材料编号 = value
        End Set
    End Property
    ''' <summary>
    ''' 材料名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 材料名称() As String
        Get
            Return str材料名称

        End Get
        Set(ByVal value As String)
            str材料名称 = value
        End Set
    End Property
    ''' <summary>
    ''' 长
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 长() As String
        Get
            Return str长

        End Get
        Set(ByVal value As String)
            str长 = value
        End Set
    End Property
    ''' <summary>
    ''' 宽
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 宽() As String
        Get
            Return str宽

        End Get
        Set(ByVal value As String)
            str宽 = value
        End Set
    End Property
    ''' <summary>
    ''' 高
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 高() As String
        Get
            Return str高

        End Get
        Set(ByVal value As String)
            str高 = value
        End Set
    End Property
    ''' <summary>
    ''' 数量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 数量() As String
        Get
            Return str数量

        End Get
        Set(ByVal value As String)
            str数量 = value
        End Set
    End Property

    ''' <summary>
    ''' 重量
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 重量() As String
        Get
            Return str重量

        End Get
        Set(ByVal value As String)
            str重量 = value
        End Set
    End Property


    ''' <summary>
    ''' 批次
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 批次() As String
        Get
            Return str批次

        End Get
        Set(ByVal value As String)
            str批次 = value
        End Set
    End Property

    ''' <summary>
    ''' 库存区域
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 库存区域() As String
        Get
            Return str库存区域

        End Get
        Set(ByVal value As String)
            str库存区域 = value
        End Set
    End Property

    ''' <summary>
    ''' 库存名称
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 库存名称() As String
        Get
            Return str库存名称

        End Get
        Set(ByVal value As String)
            str库存名称 = value
        End Set
    End Property

    ''' <summary>
    ''' 打印者    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 打印者() As String
        Get
            Return str打印者
        End Get
        Set(ByVal value As String)
            str打印者 = value
        End Set
    End Property

    ''' <summary>
    ''' 打印时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 打印时间() As String
        Get
            Return str打印时间

        End Get
        Set(ByVal value As String)
            str打印时间 = value
        End Set
    End Property
End Class