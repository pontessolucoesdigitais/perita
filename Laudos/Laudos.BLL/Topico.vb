Public Class Topico

    Private mIdTopico As Integer
    Public Property IdTopico() As Integer
        Get
            Return mIdTopico
        End Get
        Set(ByVal value As Integer)
            mIdTopico = value
        End Set
    End Property

    Private mIdLaudo As Integer
    Public Property IdLaudo() As Integer
        Get
            Return mIdLaudo
        End Get
        Set(ByVal value As Integer)
            mIdLaudo = value
        End Set
    End Property


    Private mBloqueado As Boolean
    Public Property Bloqueado() As Boolean
        Get
            Return mBloqueado
        End Get
        Set(ByVal value As Boolean)
            mBloqueado = value
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

    Private mdataUltAlteracao As DateTime
    Public Property dataUltAlteracao() As DateTime
        Get
            Return mdataUltAlteracao
        End Get
        Set(ByVal value As DateTime)
            mdataUltAlteracao = value
        End Set
    End Property

    Private mIdUsuarioUltAlteracao As Integer
    Public Property IdUsuarioUltAlteracao() As Integer
        Get
            Return mIdUsuarioUltAlteracao
        End Get
        Set(ByVal value As Integer)
            mIdUsuarioUltAlteracao = value
        End Set
    End Property

    Private mIdUsuarioBloqueio As Integer
    Public Property IdUsuarioBloqueio() As Integer
        Get
            Return mIdUsuarioBloqueio
        End Get
        Set(ByVal value As Integer)
            mIdUsuarioBloqueio = value
        End Set
    End Property

    Private mConteudo As Byte()
    Public Property Conteudo() As Byte()
        Get
            Return mConteudo
        End Get
        Set(ByVal value() As Byte)
            mConteudo = value
        End Set
    End Property

    Private mFilhos As New Dictionary(Of Integer, Topico)
    Public Property Filhos() As Dictionary(Of Integer, Topico)
        Get
            Return mFilhos
        End Get
        Set(ByVal value As Dictionary(Of Integer, Topico))
            mFilhos = value
        End Set
    End Property


    Private mPai As Topico
    Public Property Pai() As Topico
        Get
            Return mPai
        End Get
        Set(ByVal value As Topico)
            mPai = value
        End Set
    End Property

    Public Function Salvar() As Boolean
        DAL.Topico.ExcluirLaudoTopico(mIdLaudo, mIdTopico)

        'If ExisteLaudoTopico(mIdLaudo, mIdTopico) Then
        Return DAL.Topico.InserirLaudoTopico(mIdLaudo, mIdTopico, mIdUsuarioUltAlteracao, IIf(mBloqueado, 1, 0), Conteudo)
        'End If
        Return False
    End Function


    Private Function ExisteLaudoTopico(idLaudo As Integer, idTopico As Integer) As Boolean
        Return DAL.Topico.ExisteLaudoTopico(idLaudo, idTopico)
    End Function
    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nome As String, conteudo As Byte(), dataUltAlteracao As DateTime, idUsuarioUltAlteracao As Integer, idUsuarioBloqueio As Integer)
        mIdTopico = id
        mNome = nome
        mConteudo = conteudo
        mdataUltAlteracao = dataUltAlteracao
        mIdUsuarioUltAlteracao = idUsuarioUltAlteracao
        mIdUsuarioBloqueio = idUsuarioBloqueio
    End Sub

    Public Sub New(id As Integer, nome As String, conteudo As Byte())
        mIdTopico = id
        mNome = nome
        mConteudo = conteudo
    End Sub

    'Public Shared Function ListarPorLaudo(idLaudo As Integer) As Dictionary(Of Integer, Topico)
    '    Dim ret As New Dictionary(Of Integer, Topico)

    '    Dim dt As DataTable = Laudos.DAL.Topico.ListarPorLaudo(idLaudo)

    '    For Each dr As DataRow In dt.Rows

    '        Dim dtUltAlt As DateTime
    '        If IsDate(dr("dataUltAlteracao").ToString) Then
    '            dtUltAlt = dr("dataUltAlteracao")
    '        End If

    '        Dim byteConteudo() As Byte
    '        If Not IsDBNull(dr("conteudo")) Then
    '            byteConteudo = dr("conteudo")
    '        End If

    '        Dim topico As New Topico(dr("id"), dr("nome"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))

    '        ret.Add(dr("id"), topico)

    '        topico.Filhos = buscarFilhos(topico, True)
    '    Next

    '    Return ret

    'End Function

    Public Shared Function ListarPorLaudo(idLaudo As Integer) As Dictionary(Of Integer, Topico)
        Dim ret As New Dictionary(Of Integer, Topico)

        Dim dt As DataTable = Laudos.DAL.Topico.ListarPorLaudo(idLaudo)

        For Each dr As DataRow In dt.Rows
            Dim dtUltAlt As DateTime
            If IsDate(dr("dataUltAlteracao").ToString) Then
                dtUltAlt = dr("dataUltAlteracao")
            End If
            Dim byteConteudo() As Byte
            If Not IsDBNull(dr("conteudo")) Then
                byteConteudo = dr("conteudo")
            End If

            Dim topico As New Topico(dr("id"), dr("nome"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))

            ret.Add(dr("id"), topico)


            topico.Filhos = buscarFilhos(topico, False)
        Next


        Return ret

    End Function


    Public Shared Function Listar(idLaudo As Integer) As Dictionary(Of Integer, Topico)
        Dim ret As New Dictionary(Of Integer, Topico)

        Dim dt As DataTable = Laudos.DAL.LaudosTopicos.ListarPorLaudo(idLaudo)

        For Each dr As DataRow In dt.Rows
            Dim dtUltAlt As DateTime
            If IsDate(dr("dataUltAlteracao").ToString) Then
                dtUltAlt = dr("dataUltAlteracao")
            End If
            Dim byteConteudo() As Byte
            If Not IsDBNull(dr("conteudo")) Then
                byteConteudo = dr("conteudo")
            End If

            Dim topico As New Topico(dr("id"), dr("nome"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))

            ret.Add(dr("id"), topico)


            topico.Filhos = buscarFilhos(topico, False)
        Next


        Return ret

    End Function

    Private Shared Function buscarFilhos(topicoPai As Topico, PorLaudo As Boolean) As Dictionary(Of Integer, Topico)
        Dim ret As New Dictionary(Of Integer, Topico)

        Dim dt As DataTable = Laudos.DAL.Topico.ListarFilhosPorLaudo(topicoPai.IdTopico)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows

                Dim topico As Topico
                If PorLaudo Then
                    Dim dtUltAlt As DateTime
                    If IsDate(dr("dataUltAlteracao").ToString) Then
                        dtUltAlt = dr("dataUltAlteracao")
                    End If

                    Dim byteConteudo() As Byte
                    If Not IsDBNull(dr("conteudo")) Then
                        byteConteudo = dr("conteudo")
                    End If

                    topico = New Topico(dr("id"), dr("nome"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))
                    topico.Pai = topicoPai

                Else
                    topico = New Topico(dr("id"), dr("nome"), Nothing)
                    topico.Pai = topicoPai
                End If

                ret.Add(dr("id"), topico)

                topico.Filhos = buscarFilhos(topico, PorLaudo)
            Next

        End If

        Return ret


    End Function

    Public Shared Function Carregar(idLaudo As Integer, idTopico As Integer) As Topico

        Dim ret As Topico
        Dim dt As DataTable = Laudos.DAL.LaudosTopicos.Carregar(idLaudo, idTopico)
        Try


            For Each dr As DataRow In dt.Rows
                Dim dtUltAlt As DateTime
                If IsDate(dr("dataUltAlteracao").ToString) Then
                    dtUltAlt = dr("dataUltAlteracao")
                End If
                Dim byteConteudo() As Byte
                If Not IsDBNull(dr("conteudo")) Then
                    byteConteudo = dr("conteudo")
                End If

                ret = New Topico(dr("id"), dr("nome"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))

                ret.Filhos = buscarFilhos(ret, False)
            Next


            Return ret
        Catch ex As Exception
            Return Nothing
        End Try


    End Function


End Class

