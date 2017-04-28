Public Class MessageT

    Private mdecmsg_id As Decimal                            'メッセージID
    Private mdecmsg_type As Decimal                          'メッセージタイプ
    Private mstrmsg_contents As String                       '内容
    Private mstrhint As String                               'ヒント    Private mdtminsert_date As DateTime                      '登録日
    Private mdtmupdate_date As DateTime                      '変更日

    Public Property msg_id() As Decimal
        Get
            msg_id = Me.mdecmsg_id
        End Get
        Set(ByVal Value As Decimal)
            mdecmsg_id = Value
        End Set
    End Property

    Public Property msg_type() As Decimal
        Get
            msg_type = Me.mdecmsg_type
        End Get
        Set(ByVal Value As Decimal)
            mdecmsg_type = Value
        End Set
    End Property

    Public Property msg_contents() As String
        Get
            msg_contents = Me.mstrmsg_contents
        End Get
        Set(ByVal Value As String)
            mstrmsg_contents = Value
        End Set
    End Property

    Public Property hint() As String
        Get
            hint = Me.mstrhint
        End Get
        Set(ByVal Value As String)
            mstrhint = Value
        End Set
    End Property

    Public Property insert_date() As DateTime
        Get
            insert_date = Me.mdtminsert_date
        End Get
        Set(ByVal Value As DateTime)
            mdtminsert_date = Value
        End Set
    End Property

    Public Property update_date() As DateTime
        Get
            update_date = Me.mdtmupdate_date
        End Get
        Set(ByVal Value As DateTime)
            mdtmupdate_date = Value
        End Set
    End Property

End Class
