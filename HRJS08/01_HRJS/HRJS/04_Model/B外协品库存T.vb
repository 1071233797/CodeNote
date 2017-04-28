Public Class B外协品库存T

    '变量定义 
    Private str外协订单编号 As String = ""                       '外协订单编号　
    Private str客户编号 As String = ""                       '客户名称 
    Private str产品图号 As String = ""                       '产品图号 
    Private str主图号 As String = ""                       '产品图号 
    Private str上级图号 As String = ""                       '产品图号 
    Private str产品名称 As String = ""                       '产品名称 

    Private str订单编号 As String = ""                     '库存数量
    Private str外协工序 As String = ""                     '库存数量
    Private str外协加工数量 As String = ""                       '库存数量
    Private str入库日期 As String = ""                       '库存数量

    Private str作成者 As String = ""                       '制造批量号 
    Private str库存区域 As String = ""                       '制造批量号 

    Private str出库去向 As String = ""                       '库存状态 
    Private dt入库日期From As DateTime                       '订单日期
    Private dt入库日期To As DateTime                         '订单日期

    Private str计划带料数 As String = ""                     '作成者
    Private str实际带料数 As String = ""                       'CENO
    Private str备注 As String = ""                           '作成者


    '------------------------------------------------------------------------------------
    '  外协订单编号
    '------------------------------------------------------------------------------------
    Public Property 外协订单编号() As String
        Get
            Return str外协订单编号
        End Get
        Set(ByVal Value As String)
            str外协订单编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  客户名称

    '------------------------------------------------------------------------------------
    Public Property 客户编号() As String
        Get
            Return str客户编号

        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property

    Public Property 主图号() As String
        Get
            Return str主图号

        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property

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
    Public Property 产品图号() As String
        Get
            Return str产品图号

        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    ' 产品名称

    '------------------------------------------------------------------------------------
    Public Property 产品名称() As String
        Get
            Return str产品名称

        End Get
        Set(ByVal Value As String)
            str产品名称 = Value
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
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 外协工序() As String
        Get
            Return str外协工序
        End Get
        Set(ByVal Value As String)
            str外协工序 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 外协加工数量() As String
        Get
            Return str外协加工数量
        End Get
        Set(ByVal Value As String)
            str外协加工数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 作成者() As String
        Get
            Return str作成者
        End Get
        Set(ByVal Value As String)
            str作成者 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  订单编号
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
    '  订单编号
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
    '  计划带料数
    '------------------------------------------------------------------------------------
    Public Property 计划带料数() As String
        Get
            Return str计划带料数
        End Get
        Set(ByVal Value As String)
            str计划带料数 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  实际带料数
    '------------------------------------------------------------------------------------
    Public Property 实际带料数() As String
        Get
            Return str实际带料数
        End Get
        Set(ByVal Value As String)
            str实际带料数 = Value
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



Public Class B外协品标签打印T



    Private str材料编号 As String = String.Empty
    Private str数量 As String = String.Empty
    Private str重量 As String = String.Empty
    Private str批次 As String = String.Empty
    Private str库存区域 As String = String.Empty
    Private str打印者 As String = String.Empty
    Private str打印时间 As String = String.Empty

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