Imports Laudos.BLL
Public Class ucClientes

    Event AposSelecao(idSel As Integer)

    Public ReadOnly Property IdSel() As Integer
        Get
            Dim linhasSelecionada As DataGridViewSelectedRowCollection = dgClientes.SelectedRows
            If linhasSelecionada.Count = 1 Then
                Return linhasSelecionada(0).Cells(0).Value
            End If
            Return 0
        End Get
    End Property

    'Private Sub ucClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Carregar()
    'End Sub

    Public Sub Carregar()
        UTL.Forms.FormatarDataGridView(dgClientes, False)
        dgClientes.AutoGenerateColumns = True
        dgClientes.DataSource = Cliente.ListarDT()
    End Sub


    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgClientes.DoubleClick
        Dim linhasSelecionada As DataGridViewSelectedRowCollection = dgClientes.SelectedRows
        If linhasSelecionada.Count = 1 Then
            Dim idSelecionado As Integer = linhasSelecionada(0).Cells(0).Value
            RaiseEvent AposSelecao(idSelecionado)

            'dgLaudos.DataSource = Laudo.Listar(idSelecionado)
            'TabControl1.SelectedTab = tbLaudos

        End If
    End Sub

End Class
