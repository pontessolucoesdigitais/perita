Public Class Topico

    Public Shared Function Listar(idLaudo As Integer) As DataTable
        Return conn.Selecionar($"select * from topicos where idPai=0") ' where idcliente = {idLaudo}")
    End Function

    Public Shared Function ListarFull(idLaudo As Integer) As DataTable
        Return conn.Selecionar($"select * from topicos where  where idLaudo  = {idLaudo}")
    End Function

    Public Shared Function ListarPorLaudo(idLaudo As Integer) As DataTable
        Return conn.Selecionar($"Select * From vwLaudosTopicos as l Where (l.idLaudo = 1 Or l.idLaudo Is null) and idPai = 0")
    End Function

    Public Shared Function ListarFilhos(idPai As Integer) As DataTable
        Return conn.Selecionar($"select * from topicos where idPai = {idPai}") ' where idcliente = {idLaudo}")
    End Function

    Public Shared Function ListarFilhosPorLaudo(idPai As Integer) As DataTable
        Return conn.Selecionar($"Select * From vwLaudosTopicos as l Where (l.idLaudo = 1 Or l.idLaudo Is null) and idPai = {idPai}")
    End Function

    Public Shared Function InserirLaudoTopico(idLaudo As Integer, idTopico As Integer, idUsuario As Integer, bloqueado As Integer, conteudo() As Byte) As Boolean

        Dim Sql = "INSERT INTO laudosTopicos (idlaudo, idTopico, idUsuarioBloqueio, conteudo, idUsuarioUltAlteracao, dataUltAlteracao) values (@idLaudo ,@idTopico, @idUsuarioBloqueio, @conteudo, @idUsuarioUltAlteracao, @dataUltAlteracao)"

        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
        cmd.CommandText = Sql
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@idLaudo", idLaudo)
        cmd.Parameters.AddWithValue("@idTopico", idTopico)
        cmd.Parameters.AddWithValue("@idUsuarioBloqueio", idUsuario)
        cmd.Parameters.AddWithValue("@conteudo", conteudo)
        cmd.Parameters.AddWithValue("@idUsuarioUltAlteracao", idUsuario)
        cmd.Parameters.AddWithValue("@dataUltAlteracao", Now)
        Return conn.ExecutarCommand(cmd)

    End Function


    Public Shared Function ExcluirLaudoTopico(idLaudo As Integer, idTopico As Integer) As Boolean
        Dim Sql = $"DELETE FROM laudosTopicos WHERE  idlaudo = {idLaudo} AND idTopico = {idTopico}"
        Return conn.Executar(Sql)
    End Function



    Public Shared Function ExisteLaudoTopico(idLaudo As Integer, idTopico As Integer) As Integer
        Return conn.SelecionarNumero($"SELECT count(*) FROM laudosTopicos WHERE idLaudo= {idLaudo} and idTopico = {idTopico} ")
    End Function


End Class
