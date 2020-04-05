Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.Model
Imports Laudos.BLL

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UTL.Forms.FormatarDataGridView(dgClientes, False)
        UTL.Forms.FormatarDataGridView(dgLaudos, False)

        dgClientes.AutoGenerateColumns = True
        dgLaudos.AutoGenerateColumns = True

        trvTopicos.ExpandAll()

        dgClientes.DataSource = Cliente.ListarDT()

    End Sub

    Private Sub dgClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgClientes.DoubleClick
        Dim linhasSelecionada As DataGridViewSelectedRowCollection = dgClientes.SelectedRows
        If linhasSelecionada.Count = 1 Then
            Dim idSelecionado As Integer = linhasSelecionada(0).Cells(0).Value

            dgLaudos.DataSource = Laudo.Listar(idSelecionado)
            TabControl1.SelectedTab = tbLaudos

        End If
    End Sub

    Private Sub trvAnamnese_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvTopicos.AfterSelect

        Dim dt As DataTable = TopicoPadrao.Listar(DirectCast(sender, TreeView).SelectedNode.Name, 1)

        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            Dim utf As New System.Text.UTF7Encoding()
            Dim strConteudo = utf.GetString(dt.Rows(0)("conteudoPadrao"))

            radRichTextEditor1.Text = strConteudo

            TabControl1.SelectedTab = tbEditor

        End If



    End Sub

    Private Sub dgLaudos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgLaudos.CellContentClick

    End Sub

    Private Sub dgLaudos_DoubleClick(sender As Object, e As EventArgs) Handles dgLaudos.DoubleClick

        trvTopicos.Nodes.Clear()

        Dim linhasSelecionada As DataGridViewSelectedRowCollection = dgLaudos.SelectedRows
        If linhasSelecionada.Count = 1 Then
            Dim idSelecionado As Integer = linhasSelecionada(0).Cells(0).Value

            For Each it As Topico In BLL.Topico.Listar(idSelecionado).Values
                Dim node As TreeNode = trvTopicos.Nodes.Add(it.IdTopico,
                                                            it.Nome)

                If it.Filhos.Count > 0 Then
                    ListarFilhos(node,
                                 it.Filhos.Values.ToList)
                End If
            Next

            trvTopicos.ExpandAll()

            TabControl1.SelectedTab = tbTopicos

        End If

    End Sub

    Private Sub ListarFilhos(nodePai As TreeNode, topicos As List(Of Topico))

        For Each itPai As Topico In topicos
            Dim nodeAux As TreeNode = nodePai.Nodes.Add(itPai.IdTopico,
                                                        itPai.Nome)

            For Each it As Topico In itPai.Filhos.Values

                nodeAux.Nodes.Add(it.IdTopico,
                                  it.Nome)

                If it.Filhos.Count > 0 Then
                    ListarFilhos(nodeAux,
                                 it.Filhos.Values.ToList)
                End If
            Next

        Next

    End Sub

    Private Sub richTextEditorRibbonBar1_Click(sender As Object, e As EventArgs) Handles richTextEditorRibbonBar1.Click
        'MsgBox(radRichTextEditor1.Text)

        'Dim provider As DocxFormatProvider = New DocxFormatProvider()
        'Dim document As RadDocument = Me.radRichTextEditor1.Document
        'Dim output1 As Byte() = provider.Export(document)


        'Using output As FileStream = File.OpenWrite("c:\temp\Sample.docx")
        '    provider.Export(document, output)
        'End Using
    End Sub
End Class
