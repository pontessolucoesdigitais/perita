Public Class Cliente

    Private mId As Integer
    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Private mNome As String
    Public Property Nome() As String
        Get
            Return mNome
        End Get
        Set(ByVal value As String)
            mNome = value
        End Set
    End Property

    Private mResponsaval As String
    Public Property Responsavel() As String
        Get
            Return mResponsaval
        End Get
        Set(ByVal value As String)
            mResponsaval = value
        End Set
    End Property

    Private mEndereco As String
    Public Property Endereco() As String
        Get
            Return mEndereco
        End Get
        Set(ByVal value As String)
            mEndereco = value
        End Set
    End Property

    Private mTipoPessoaId As Integer
    Public Property TipoPessoaId() As Integer
        Get
            Return mTipoPessoaId
        End Get
        Set(ByVal value As Integer)
            mTipoPessoaId = value
        End Set
    End Property

    Private mTipoPessoaNome As String
    Public Property TipoPessoaNome() As String
        Get
            Return mTipoPessoaNome
        End Get
        Set(ByVal value As String)
            mTipoPessoaNome = value
        End Set
    End Property

    Private mDocumento As String
    Public Property Documento() As String
        Get
            Return mDocumento
        End Get
        Set(ByVal value As String)
            mDocumento = value
        End Set
    End Property

    Private mRG As String
    Public Property RG() As String
        Get
            Return mRG
        End Get
        Set(ByVal value As String)
            mRG = value
        End Set
    End Property

    Private mExpedidoPor As String
    Public Property ExpedioPor() As String
        Get
            Return mExpedidoPor
        End Get
        Set(ByVal value As String)
            mExpedidoPor = value
        End Set
    End Property

    Public Sub New(id As Integer, nome As String, responsavel As String, endereco As String, tipoPessoa As Integer, documento As String, rg As String, expedidoPor As String)
        mId = id
        mNome = nome
        mEndereco = endereco
        mTipoPessoaId = tipoPessoa
        If tipoPessoa = Enums.TipoPessoa.Fisica Then
            mTipoPessoaNome = "Física"
        Else
            mTipoPessoaNome = "Jurídica"
        End If
        mDocumento = documento
        mRG = rg
        mExpedidoPor = expedidoPor

    End Sub

    Public Shared Function Listar() As List(Of Cliente)
        Dim retAux As New List(Of Cliente)

        Dim dt As DataTable = Laudos.DAL.Cliente.Listar
        If Not IsNothing(dt) Then

            For Each dr As DataRow In dt.Rows
                retAux.Add(New Cliente(dr("id").ToString(),
                                       dr("nome").ToString(),
                                       dr("responsavel").ToString(),
                                       dr("endereco").ToString(),
                                       dr("tipoPessoa").ToString(),
                                       dr("documento").ToString(),
                                       dr("rg").ToString(),
                                       dr("expedidoPor").ToString()))
            Next

        End If

    End Function

    Public Shared Function ListarDT() As DataTable
        Return Laudos.DAL.Cliente.Listar
    End Function



End Class
