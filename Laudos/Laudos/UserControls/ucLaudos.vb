Imports Laudos.BLL
Public Class ucLaudos

    Private mIdCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return mIdCliente
        End Get
        Set(ByVal value As Integer)
            mIdCliente = value
        End Set
    End Property

    Public Sub Carregar()
        UTL.Forms.FormatarDataGridView(dg, False)
        dg.AutoGenerateColumns = True
        dg.DataSource = Laudo.Listar(IdCliente)
    End Sub



    Event AposSelecao(idSel As Integer)

    Public ReadOnly Property IdSel() As Integer
        Get
            Dim linhasSelecionada As DataGridViewSelectedRowCollection = dg.SelectedRows
            If linhasSelecionada.Count = 1 Then
                Return linhasSelecionada(0).Cells(0).Value
            End If
            Return 0
        End Get
    End Property


    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs) Handles dg.DoubleClick
        Dim linhasSelecionada As DataGridViewSelectedRowCollection = dg.SelectedRows
        If linhasSelecionada.Count = 1 Then
            Dim idSelecionado As Integer = linhasSelecionada(0).Cells(0).Value
            RaiseEvent AposSelecao(idSelecionado)

            'dgLaudos.DataSource = Laudo.Listar(idSelecionado)
            'TabControl1.SelectedTab = tbLaudos

        End If
    End Sub

End Class
