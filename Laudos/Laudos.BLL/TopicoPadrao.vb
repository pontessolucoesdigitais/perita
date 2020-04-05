Public Class TopicoPadrao
    Public Shared Function Listar(idTopico As Integer, idPadrao As Integer) As DataTable
        Return Laudos.DAL.TopicoPadrao.Listar(idTopico, idPadrao)
    End Function

End Class
