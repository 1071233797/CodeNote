#Region "库存盘点表基础类"
'   创建人: 刘春广
'   创建日期: 2016/5/25
#End Region

Public Class B原材料库存盘点表T

    '变量定义 
    Private str盘点人编号 As String

    Private str在库状态 As String = ""                  '在库状态

    Private str处理方式 As String = ""                  '处理方式
    Private str备注 As String = ""                    '备注

    Private dtm盘点日期From As Date                     '盘点日期
    Private dtm盘点日期To As Date                     '盘点日期
    Private dtm调整日期 As Date                     '盘点日期

    Private dec在库数量 As Decimal = 0                  '在库数量
    Private dec盘点数量 As Decimal = 0                   '盘点数量
    Private dec在库重量 As Decimal = 0                  '在库数量
    Private dec盘点重量 As Decimal = 0                   '盘点数量
    Private dec调整数量 As Decimal = 0                  '调整数量
    Private dec调整重量 As Decimal = 0                  '调整数量
    Private dec差异数量 As Decimal = 0                   '差异数
    Private dec差异重量 As Decimal = 0                   '差异数
    Private dec调整后在库数量 As Decimal = 0                 '调整后在库
    Private dec调整后在库重量 As Decimal = 0                 '调整后在库
    Private str仅显示差异项 As String = ""
    '------------------------------------------------------------------------------------
    '  在库数量
    '------------------------------------------------------------------------------------
    Public Property 在库数量() As Decimal
        Get
            Return dec在库数量
        End Get
        Set(ByVal Value As Decimal)
            dec在库数量 = Value
        End Set
    End Property
    Public Property 仅显示差异项() As String
        Get
            Return str仅显示差异项
        End Get
        Set(ByVal Value As String)
            str仅显示差异项 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  在库数量
    '------------------------------------------------------------------------------------
    Public Property 在库重量() As Decimal
        Get
            Return dec在库重量
        End Get
        Set(ByVal Value As Decimal)
            dec在库重量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  盘点数量
    '------------------------------------------------------------------------------------
    Public Property 盘点数量() As Decimal
        Get
            Return dec盘点数量
        End Get
        Set(ByVal Value As Decimal)
            dec盘点数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  在库数量
    '------------------------------------------------------------------------------------
    Public Property 盘点重量() As Decimal
        Get
            Return dec盘点重量
        End Get
        Set(ByVal Value As Decimal)
            dec盘点重量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  调整数量
    '------------------------------------------------------------------------------------
    Public Property 调整数量() As Decimal
        Get
            Return dec调整数量
        End Get
        Set(ByVal Value As Decimal)
            dec调整数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  在库数量
    '------------------------------------------------------------------------------------
    Public Property 调整重量() As Decimal
        Get
            Return dec调整重量
        End Get
        Set(ByVal Value As Decimal)
            dec调整重量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  调整后在库
    '------------------------------------------------------------------------------------
    Public Property 调整后在库数量() As Decimal
        Get
            Return dec调整后在库数量
        End Get
        Set(ByVal Value As Decimal)
            dec调整后在库数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  调整后在库
    '------------------------------------------------------------------------------------
    Public Property 调整后在库重量() As Decimal
        Get
            Return dec调整后在库重量
        End Get
        Set(ByVal Value As Decimal)
            dec调整后在库重量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  差异数
    '------------------------------------------------------------------------------------
    Public Property 差异数量() As Decimal
        Get
            Return dec差异数量
        End Get
        Set(ByVal Value As Decimal)
            dec差异数量 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  差异数
    '------------------------------------------------------------------------------------
    Public Property 差异重量() As Decimal
        Get
            Return dec差异重量
        End Get
        Set(ByVal Value As Decimal)
            dec差异重量 = Value
        End Set
    End Property
    Private str材料编号 As String = ""                  '部品番号
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

    Private str材料区分 As String = ""                  '部品区分
    '------------------------------------------------------------------------------------
    '  部品区分
    '------------------------------------------------------------------------------------
    Public Property 材料区分() As String
        Get
            Return str材料区分
        End Get
        Set(ByVal Value As String)
            str材料区分 = Value
        End Set
    End Property
    Private int盘点CD As Integer
    Public Property 盘点CD() As Integer
        Get
            Return int盘点CD
        End Get
        Set(value As Integer)
            int盘点CD = value
        End Set
    End Property

    Private str材料批号 As String
    Public Property 材料批号() As String
        Get
            Return str材料批号
        End Get
        Set(value As String)
            str材料批号 = value
        End Set
    End Property

    Private str货架编号 As String = ""                  '货架编号
    '------------------------------------------------------------------------------------
    '  货架编号
    '------------------------------------------------------------------------------------
    Public Property 货架编号() As String
        Get
            Return str货架编号
        End Get
        Set(ByVal Value As String)
            str货架编号 = Value
        End Set
    End Property

    Public Property 盘点人编号() As String
        Get
            Return str盘点人编号
        End Get
        Set(value As String)
            str盘点人编号 = value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  盘点日期
    '------------------------------------------------------------------------------------
    Public Property 盘点日期From() As DateTime
        Get
            Return dtm盘点日期From
        End Get
        Set(ByVal Value As DateTime)
            dtm盘点日期From = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  盘点日期
    '------------------------------------------------------------------------------------
    Public Property 盘点日期To() As DateTime
        Get
            Return dtm盘点日期To
        End Get
        Set(ByVal Value As DateTime)
            dtm盘点日期To = Value
        End Set
    End Property
    Public Property 调整日期() As DateTime
        Get
            Return dtm调整日期
        End Get
        Set(ByVal Value As DateTime)
            dtm调整日期 = Value
        End Set
    End Property
    '------------------------------------------------------------------------------------
    '  处理方式
    '------------------------------------------------------------------------------------
    Public Property 处理方式() As String
        Get
            Return str处理方式
        End Get
        Set(ByVal Value As String)
            str处理方式 = Value
        End Set
    End Property

    '------------------------------------------------------------------------------------
    '  在库状态
    '------------------------------------------------------------------------------------
    Public Property 在库状态() As String
        Get
            Return str在库状态
        End Get
        Set(ByVal Value As String)
            str在库状态 = Value
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
