Public Class Cliente
    Public Shared Function Listar() As DataTable
        Return conn.Selecionar("select * from clientes")
    End Function

End Class

