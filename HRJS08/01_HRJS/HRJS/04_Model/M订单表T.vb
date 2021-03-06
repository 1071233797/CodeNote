#Region "订单表基础类"
'   创建人: 解辉品
'   创建日期: 2016/5/25
#End Region

Public Class M订单表T

    '变量定义 
    Private str订单编号 As String = ""                  '订单编号
    Private str订单编号CD As String = ""                  '订单编号
    Private str订单状态 As String = ""                  '订单编号
    Private str订单区分 As String = ""                    '区分
    Private str厂内编号 As String = ""                  '出荷去向
    Private str币种 As String = ""                  '出荷方法
    Private str产品发票号 As String = ""                  '制造区分
    Private str目的港编号 As String = ""                  '部品番号
    Private str目的港名 As String = ""                  '部品番号
    Private str产品种类编号 As String = ""                  '部品区分
    Private str产品区分 As String = ""                   '试做品
    Private str交货方式 As String = ""                  'イベント
    Private str含税单价 As String = ""                  'CENO
    Private str含税总金额 As String = ""                  '佳能要求
    Private str产品图号 As String = ""                  '工程图番
    Private str产品名称 As String = ""                    '机种
    Private str客户编号 As String = ""                  '包装方法
   
    Private str长 As String = ""                  '工程图番
    Private str宽 As String = ""                    '机种
    Private str高 As String = ""                  '包装方法
    Private str未税单价 As String = ""                  '工程图番
    Private str未税总金额 As String = ""                    '机种
    Private str产品助记码 As String = ""                  '包装方法
    Private str备注 As String = ""                    '备注
    Private str作成者编号 As String = ""                   '作成者
    Private dtm订单接受日期 As DateTime                     '订单日期
    Private dt发货日期 As DateTime                     '订单日期
    Private dt到货日期 As DateTime                     '订单日期
    Private dt发货日期2 As DateTime                     '订单日期
    Private dt到货日期2 As DateTime                     '订单日期
    Private str审核状态 As String = ""                    '备注
    Private int订单数量 As Integer = 0                  '出荷数量
    Private str登录者 As String = String.Empty
    Private str登录日期 As String = String.Empty
    Private str更新者 As String = String.Empty
    Private str更新日期 As String = String.Empty
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
    Public Property 订单编号CD() As String
        Get
            Return str订单编号CD
        End Get
        Set(ByVal Value As String)
            str订单编号CD = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  订单编号
    '------------------------------------------------------------------------------------
    Public Property 订单状态() As String
        Get
            Return str订单状态
        End Get
        Set(ByVal Value As String)
            str订单状态 = Value
        End Set
    End Property
    Public Property 审核状态() As String
        Get
            Return str审核状态
        End Get
        Set(ByVal Value As String)
            str审核状态 = Value
        End Set
    End Property
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
    '------------------------------------------------------------------------------------
    '  订单区分
    '------------------------------------------------------------------------------------
    Public Property 订单区分() As String
        Get
            Return str订单区分
        End Get
        Set(ByVal Value As String)
            str订单区分 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  str厂内编号
    '------------------------------------------------------------------------------------
    Public Property 厂内编号() As String
        Get
            Return str厂内编号
        End Get
        Set(ByVal Value As String)
            str厂内编号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  出荷方法
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
    '  制造区分
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
    '  部品番号
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

    '------------------------------------------------------------------------------------
    '  出荷箱数
    '------------------------------------------------------------------------------------
    Public Property 目的港编号() As String
        Get
            Return str目的港编号
        End Get
        Set(ByVal Value As String)
            str目的港编号 = Value
        End Set
    End Property

    Public Property 目的港名() As String
        Get
            Return str目的港名
        End Get
        Set(ByVal Value As String)
            str目的港名 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  试做品
    '------------------------------------------------------------------------------------
    Public Property 产品发票号() As String
        Get
            Return str产品发票号
        End Get
        Set(ByVal Value As String)
            str产品发票号 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  イベント
    '------------------------------------------------------------------------------------
    Public Property 产品区分() As String
        Get
            Return str产品区分
        End Get
        Set(ByVal Value As String)
            str产品区分 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  CENO
    '------------------------------------------------------------------------------------
    Public Property 产品种类编号() As String
        Get
            Return str产品种类编号
        End Get
        Set(ByVal Value As String)
            str产品种类编号 = Value
        End Set
    End Property

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

    '------------------------------------------------------------------------------------
    '  包装方法
    '------------------------------------------------------------------------------------
    Public Property 产品助记码() As String
        Get
            Return str产品助记码
        End Get
        Set(ByVal Value As String)
            str产品助记码 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  出荷日期
    '------------------------------------------------------------------------------------
    Public Property 发货日期() As DateTime
        Get
            Return dt发货日期
        End Get
        Set(ByVal Value As DateTime)
            dt发货日期 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  出荷日期2
    '------------------------------------------------------------------------------------
    Public Property 到货日期() As DateTime
        Get
            Return dt到货日期
        End Get
        Set(ByVal Value As DateTime)
            dt到货日期 = Value
        End Set
    End Property
    Public Property 发货日期2() As DateTime
        Get
            Return dt发货日期2
        End Get
        Set(ByVal Value As DateTime)
            dt发货日期2 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  出荷日期2
    '------------------------------------------------------------------------------------
    Public Property 到货日期2() As DateTime
        Get
            Return dt到货日期2
        End Get
        Set(ByVal Value As DateTime)
            dt到货日期2 = Value
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

    '------------------------------------------------------------------------------------
    '  订单日期
    '------------------------------------------------------------------------------------
    Public Property 订单接受日期() As DateTime
        Get
            Return dtm订单接受日期
        End Get
        Set(ByVal Value As DateTime)
            dtm订单接受日期 = Value
        End Set
    End Property


    Public Property 交货方式() As String
        Get
            Return str交货方式

        End Get
        Set(value As String)
            str交货方式 = value
        End Set
    End Property


    Public Property 登录者() As String
        Get
            Return str登录者
        End Get
        Set(value As String)
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
        Set(value As String)
            str登录日期 = value
        End Set
    End Property

    ''' <summary>
    ''' 更新者
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property 更新者()
        Get
            Return str更新者
        End Get
        Set(value)
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
        Set(value As String)
            str更新日期 = value
        End Set
    End Property

End Class
