Public Class Laudo
    Public Shared Function Listar(idCliente As Integer) As DataTable
        Return DAL.Laudo.Listar(idCliente)
    End Function
End Class
