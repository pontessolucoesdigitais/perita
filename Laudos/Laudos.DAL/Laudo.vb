
Public Class Laudo
    Public Shared Function Listar(idCliente As Integer) As DataTable
        Return conn.Selecionar($"select * from laudos where idcliente = {idCliente}")
    End Function

End Class

