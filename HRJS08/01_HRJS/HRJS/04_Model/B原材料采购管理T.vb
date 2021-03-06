#Region "订单表基础类"
'   创建人: 解辉品
'   创建日期: 2016/5/25
#End Region

Public Class B原材料采购管理T

    '变量定义 
    Private str采购单编号 As String = ""                  '制造区分


    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Private str审核备注 As String = ""
    Public Property 审核备注() As String
        Get
            Return str审核备注
        End Get
        Set(ByVal Value As String)
            str审核备注 = Value
        End Set
    End Property
    Private str采购状态 As String = ""
    Public Property 采购状态() As String
        Get
            Return str采购状态
        End Get
        Set(ByVal Value As String)
            str采购状态 = Value
        End Set
    End Property
    Private str长度方向加工数量 As String = ""
    Public Property 长度方向加工数量() As String
        Get
            Return str长度方向加工数量
        End Get
        Set(ByVal Value As String)
            str长度方向加工数量 = Value
        End Set
    End Property
    Private str宽度方向加工数量 As String = ""
    Public Property 宽度方向加工数量() As String
        Get
            Return str宽度方向加工数量
        End Get
        Set(ByVal Value As String)
            str宽度方向加工数量 = Value
        End Set
    End Property
    Private str数量1 As String = ""
    Public Property 数量1() As String
        Get
            Return str数量1
        End Get
        Set(ByVal Value As String)
            str数量1 = Value
        End Set
    End Property
    Private str材料种类 As String = ""
    Public Property 材料种类() As String
        Get
            Return str材料种类
        End Get
        Set(ByVal Value As String)
            str材料种类 = Value
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

    Private str订单编号 As String = ""                  '订单编号
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

    Private str税率 As String = ""                  '订单编号

    Public Property 税率() As String
        Get
            Return str税率
        End Get
        Set(ByVal Value As String)
            str税率 = Value
        End Set
    End Property
    Private str供应商编号 As String = ""                  '订单编号

    Public Property 供应商编号() As String
        Get
            Return str供应商编号
        End Get
        Set(ByVal Value As String)
            str供应商编号 = Value
        End Set
    End Property

    Private str材质 As String = ""                  '订单编号

    Public Property 材质() As String
        Get
            Return str材质
        End Get
        Set(ByVal Value As String)
            str材质 = Value
        End Set
    End Property
    Private str主图号 As String = ""                  '制造区分
    Private str分图号 As String = ""                  '制造区分
    Private str上级图号 As String = ""
    Public Property 主图号() As String
        Get
            Return str主图号
        End Get
        Set(ByVal Value As String)
            str主图号 = Value
        End Set
    End Property
    Public Property 分图号() As String
        Get
            Return str分图号
        End Get
        Set(ByVal Value As String)
            str分图号 = Value
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
    Private str审核状态 As String = ""                    '备注
    Private str审核人编号 As String = ""                    '备注
    Public Property 审核状态() As String
        Get
            Return str审核状态
        End Get
        Set(ByVal Value As String)
            str审核状态 = Value
        End Set
    End Property
    Public Property 审核人编号() As String
        Get
            Return str审核人编号
        End Get
        Set(ByVal Value As String)
            str审核人编号 = Value
        End Set
    End Property
    Private str单价修改状态 As String = ""
    Public Property 单价修改状态() As String
        Get
            Return str单价修改状态
        End Get
        Set(ByVal Value As String)
            str单价修改状态 = Value
        End Set
    End Property

    Private str长 As String = ""                  '工程图番
    Private str宽 As String = ""                    '机种
    Private str高 As String = ""                  '包装方法

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
    Private str计划采购数量 As String = ""                  '工程图番
    Private str实际采购数量 As String = ""                    '机种

    Private str计划采购重量 As String = ""                  'CENO
    Private str实际采购重量 As String = ""                  '佳能要求
    Public Property 计划采购重量() As String
        Get
            Return str计划采购重量
        End Get
        Set(ByVal Value As String)
            str计划采购重量 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  机种
    '------------------------------------------------------------------------------------
    Public Property 计划采购数量() As String
        Get
            Return str计划采购数量
        End Get
        Set(ByVal Value As String)
            str计划采购数量 = Value
        End Set
    End Property
    Public Property 实际采购数量() As String
        Get
            Return str实际采购数量
        End Get
        Set(ByVal Value As String)
            str实际采购数量 = Value
        End Set
    End Property
    Public Property 实际采购重量() As String
        Get
            Return str实际采购重量
        End Get
        Set(ByVal Value As String)
            str实际采购重量 = Value
        End Set
    End Property
    Private str未税单价 As String = ""                  '工程图番
    Private str未税总金额 As String = ""                    '机种

    Private str含税单价 As String = ""                  'CENO
    Private str含税总金额 As String = ""                  '佳能要求

    '------------------------------------------------------------------------------------
    '  工程图番
    '------------------------------------------------------------------------------------
    Public Property 未税单价() As String
        Get
            Return str未税单价
        End Get
        Set(ByVal Value As String)
            str未税单价 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  机种
    '------------------------------------------------------------------------------------
    Public Property 未税总金额() As String
        Get
            Return str未税总金额
        End Get
        Set(ByVal Value As String)
            str未税总金额 = Value
        End Set
    End Property
    Public Property 含税单价() As String
        Get
            Return str含税单价
        End Get
        Set(ByVal Value As String)
            str含税单价 = Value
        End Set
    End Property
    Public Property 含税总金额() As String
        Get
            Return str含税总金额
        End Get
        Set(ByVal Value As String)
            str含税总金额 = Value
        End Set
    End Property

    Private str材料区分 As String = ""                    '区分
    '------------------------------------------------------------------------------------
    '  订单区分
    '------------------------------------------------------------------------------------

    Public Property 材料区分() As String
        Get
            Return str材料区分
        End Get
        Set(ByVal Value As String)
            str材料区分 = Value
        End Set
    End Property


    ''Private str供应商编号 As String = ""                   '作成者

    ''------------------------------------------------------------------------------------
    ''  出荷方法
    ''------------------------------------------------------------------------------------
    ''Public Property 供应商编号() As String
    ''    Get
    ''        Return str供应商编号
    ''    End Get
    ''    Set(ByVal Value As String)
    ''        str供应商编号 = Value
    ''    End Set
    ''End Property

    '------------------------------------------------------------------------------------
    '  制造区分
    '------------------------------------------------------------------------------------


    Private str原材料编号 As String = ""                  'イベント
    Private str原材料名称 As String = ""                  'イベント

    Public Property 原材料编号() As String
        Get
            Return str原材料编号
        End Get
        Set(ByVal Value As String)
            str原材料编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  部品番号
    '------------------------------------------------------------------------------------
    Public Property 原材料名称() As String
        Get
            Return str原材料名称
        End Get
        Set(ByVal Value As String)
            str原材料名称 = Value
        End Set
    End Property

    Private str币种 As String = ""                  '出荷方法

    '------------------------------------------------------------------------------------
    '  部品区分
    '------------------------------------------------------------------------------------
    Public Property 币种() As String
        Get
            Return str币种
        End Get
        Set(ByVal Value As String)
            str币种 = Value
        End Set
    End Property

    Private int订单数量 As Integer = 0                  '出荷数量

    '------------------------------------------------------------------------------------
    '  出荷数量
    '------------------------------------------------------------------------------------
    Public Property 订单数量() As Integer
        Get
            Return int订单数量
        End Get
        Set(ByVal Value As Integer)
            int订单数量 = Value
        End Set
    End Property

    Private str备注 As String = ""                    '备注
    Private str作成者编号 As String = ""                   '作成者

    Private dt供货日期 As DateTime                     '订单日期
    Private dt申请日期 As DateTime                     '订单日期
    Private dt供货日期2 As DateTime                     '订单日期

    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
    '------------------------------------------------------------------------------------
    '  出荷日期
    '------------------------------------------------------------------------------------
    Public Property 供货日期() As String
        Get
            Return dt供货日期
        End Get
        Set(ByVal Value As String)
            dt供货日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  出荷日期2
    '------------------------------------------------------------------------------------
    Public Property 申请日期() As String
        Get
            Return dt申请日期
        End Get
        Set(ByVal Value As String)
            dt申请日期 = Value
        End Set
    End Property
    Public Property 供货日期2() As String
        Get
            Return dt供货日期2
        End Get
        Set(ByVal Value As String)
            dt供货日期2 = Value
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
    '  作成者
    '------------------------------------------------------------------------------------
    Public Property 作成者编号() As String
        Get
            Return str作成者编号
        End Get
        Set(ByVal Value As String)
            str作成者编号 = Value
        End Set
    End Property

    Private str交货方式 As String = ""                  'イベント
    Public Property 供货方式() As String
        Get
            Return str交货方式

        End Get
        Set(ByVal value As String)
            str交货方式 = value
        End Set
    End Property


    Public Property 登录者() As String
        Get
            Return str登录者

        End Get
        Set(ByVal value As String)
            str登录者 = value
        End Set
    End Property

    ''' <summary>
    ''' 登录日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 登录日期() As String
        Get
            Return str登录日期
        End Get
        Set(ByVal value As String)
            str登录日期 = value
        End Set
    End Property


    Public Property 更新者()
        Get
            Return str更新者

        End Get
        Set(ByVal value)
            str更新者 = value
        End Set
    End Property

    ''' <summary>
    ''' 更新日期
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 更新日期() As String
        Get
            Return str更新日期
        End Get
        Set(ByVal value As String)
            str更新日期 = value
        End Set
    End Property
    Private str客户编号 As String = ""                  '客户编号
    Private str产品图号 As String = ""                  '产品图号
    Private str型号 As String = ""                  '型号
    Private str单品耗材数量 As String = ""              '单品耗材数量
    Private str数量 As String = ""              '数量
    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 客户编号() As String
        Get
            Return str客户编号
        End Get
        Set(ByVal Value As String)
            str客户编号 = Value
        End Set
    End Property
    Public Property 产品图号() As String
        Get
            Return str产品图号
        End Get
        Set(ByVal Value As String)
            str产品图号 = Value
        End Set
    End Property
    Public Property 型号() As String
        Get
            Return str型号
        End Get
        Set(ByVal Value As String)
            str型号 = Value
        End Set
    End Property
    Public Property 单品耗材数量() As String
        Get
            Return str单品耗材数量
        End Get
        Set(ByVal Value As String)
            str单品耗材数量 = Value
        End Set
    End Property
    Public Property 数量() As String
        Get
            Return str数量
        End Get
        Set(ByVal Value As String)
            str数量 = Value
        End Set
    End Property
    Private _str密度 As String
    Public Property 密度() As String
        Get
            Return _str密度
        End Get
        Set(ByVal value As String)
            _str密度 = value
        End Set
    End Property
    Private _str区分 As Boolean
    Public Property 区分() As Boolean
        Get
            Return _str区分
        End Get
        Set(ByVal value As Boolean)
            _str区分 = value
        End Set
    End Property
    Private _str重量 As String
    Public Property 重量() As String
        Get
            Return _str重量
        End Get
        Set(ByVal value As String)
            _str重量 = value
        End Set
    End Property
End Class
