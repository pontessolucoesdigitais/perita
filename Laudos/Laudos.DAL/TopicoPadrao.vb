
Public Class TopicoPadrao
    Public Shared Function Listar(idTopico As Integer, idPadrao As Integer) As DataTable
        Return conn.Selecionar($"select * from topicosPadroes where idTopico = {idTopico} and idPadrao= {idPadrao}")
    End Function

End Class
