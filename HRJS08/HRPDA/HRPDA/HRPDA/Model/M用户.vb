Public Class M用户

    Private str用户名 As String = ""
   
    Public Property 用户名() As String
        Get
            Return str用户名
        End Get
        Set(ByVal Value As String)
            str用户名 = Value
        End Set
    End Property


    Private str密码 As String = ""

    Public Property 密码() As String
        Get
            Return str密码
        End Get
        Set(ByVal Value As String)
            str密码 = Value
        End Set
    End Property


End Class
