Public Class ucInfo

    'Private mNome As String
    Public Property Nome() As String
        Get
            Return lblNome.Text
        End Get
        Set(ByVal value As String)
            lblNome.Text = value
        End Set
    End Property

    Public Property Valor() As String
        Get
            Return lblValor.Text
        End Get
        Set(ByVal value As String)
            lblValor.Text = value
        End Set
    End Property

End Class
