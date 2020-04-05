Public Class LaudoTopico

    Private mIdLaudo As Integer
    Public Property IdLaudo() As Integer
        Get
            Return mIdLaudo
        End Get
        Set(ByVal value As Integer)
            mIdLaudo = value
        End Set
    End Property

    Private mIdTopico As Integer
    Public Property IdTopico() As Integer
        Get
            Return mIdTopico
        End Get
        Set(ByVal value As Integer)
            mIdTopico = value
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

    Public Function Salvar(idLaudo As Integer, idTopico As Integer, idUsuario As Integer, bloqueado As Boolean, conteudo() As Byte) As Boolean
        DAL.Topico.ExcluirLaudoTopico(idLaudo, idTopico)

        If ExisteLaudoTopico(idLaudo, idTopico) Then
            Return DAL.Topico.InserirLaudoTopico(idLaudo, idTopico, idUsuario, IIf(bloqueado, 1, 0), conteudo)
        End If
        Return False
    End Function

    Private Function ExisteLaudoTopico(idLaudo As Integer, idTopico As Integer) As Boolean
        Return DAL.Topico.ExisteLaudoTopico(idLaudo, idTopico)
    End Function

    Public Sub New()

    End Sub

    Public Sub New(idTopico As Integer, conteudo As Byte(), dataUltAlteracao As DateTime, idUsuarioUltAlteracao As Integer, idUsuarioBloqueio As Integer)
        mIdTopico = idTopico
        mConteudo = conteudo
        mdataUltAlteracao = dataUltAlteracao
        mIdUsuarioUltAlteracao = idUsuarioUltAlteracao
        mIdUsuarioBloqueio = idUsuarioBloqueio
    End Sub

    Public Shared Function ListarPorLaudo(idLaudo As Integer) As Dictionary(Of Integer, LaudoTopico)
        Dim ret As New Dictionary(Of Integer, LaudoTopico)

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

            Dim laudoTopico As New LaudoTopico(dr("idTopico"), byteConteudo, dtUltAlt, Val(dr("idUsuarioUltAlteracao").ToString), Val(dr("idUsuarioBloqueio").ToString))

            ret.Add(dr("idTopico"), laudoTopico)

        Next

        Return ret

    End Function

    Public Shared Function Listar(idLaudo As Integer) As Dictionary(Of Integer, Topico)
        Dim ret As New Dictionary(Of Integer, Topico)

        Dim dt As DataTable = Laudos.DAL.Topico.Listar(idLaudo)

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

                Else
                    topico = New Topico(dr("id"), dr("nome"), Nothing)
                End If

                ret.Add(dr("id"), topico)

                topico.Filhos = buscarFilhos(topico, PorLaudo)
            Next

        End If

        Return ret


    End Function



End Class
