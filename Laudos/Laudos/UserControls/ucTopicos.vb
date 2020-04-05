Imports Laudos.BLL

Public Class ucTopicos
    Dim dicTopicosTrv As Dictionary(Of Integer, Topico)
    Dim dicTopicosFull As Dictionary(Of Integer, Topico)

    Public Event AbrirEditor(oTopico As Topico)

    Private mIdLaudo As Integer
    Public Property IdLaudo() As Integer
        Get
            Return mIdLaudo
        End Get
        Set(ByVal value As Integer)
            mIdLaudo = value
        End Set
    End Property

    Public Sub Carregar()
        Ampulheta(True, New Form)
        If mIdLaudo > 0 Then
            dicTopicosTrv = BLL.Topico.ListarPorLaudo(mIdLaudo)

            For Each it As Topico In dicTopicosTrv.Values
                Dim node As TreeNode = trvTopicos.Nodes.Add(it.IdTopico, it.Nome)

                If it.Filhos.Count > 0 Then
                    ListarFilhos(node, it.Filhos.Values.ToList)
                End If
            Next

            trvTopicos.ExpandAll()

        End If
        Ampulheta(False, New Form)
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

    Private Sub btnEditPhoto_Click(sender As Object, e As EventArgs) Handles btnEditPhoto.Click

        If Not IsNothing(trvTopicos.SelectedNode.Name) Then
            Dim idTopico As Integer = trvTopicos.SelectedNode.Name

            Dim oTopico As Topico = Topico.Carregar(IdLaudo, idTopico)

            'Dim auxTop As New Topico()
            oTopico.IdLaudo = IdLaudo
            oTopico.IdTopico = idTopico

            RaiseEvent AbrirEditor(oTopico)
        End If

    End Sub

    Private Function BuscaTopicoDic(idTopico As Integer) As Topico
        For Each top As Topico In dicTopicosTrv.Values

            If top.IdTopico = idTopico Then
                Return top
            Else
                Dim auxRet As Topico = BuscaTopicoFilhosDic(top, idTopico)
                If Not IsNothing(auxRet) Then
                    Return auxRet
                End If
            End If



        Next


        dicTopicosTrv.ContainsKey(trvTopicos.SelectedNode.Name)
    End Function


    Private Function BuscaTopicoFilhosDic(topicoPai As Topico, idTopico As Integer) As Topico
        If topicoPai.IdTopico = idTopico Then
            Return topicoPai
        Else
            For Each top As Topico In topicoPai.Filhos.Values
                If top.IdTopico = idTopico Then
                    Return top
                Else
                    Dim auxRet As Topico = BuscaTopicoFilhosDic(top, idTopico)
                    If Not IsNothing(auxRet) Then
                        Return auxRet
                    End If
                End If
            Next
        End If
        Return Nothing
    End Function


    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs)

        '''''''''''Dim provider As DocxFormatProvider = New DocxFormatProvider()
        '''''''''''Dim document As RadDocument = Me.radRichTextEditor1.Document
        '''''''''''Dim output1 As Byte() = provider.Export(document)

        '''''''''''topicoSel.Conteudo = output1
        '''''''''''topicoSel.dataUltAlteracao = Now
        '''''''''''topicoSel.IdUsuarioUltAlteracao = "1"

        '''''''''''Dim oLaudoTopico As New LaudoTopico()

        '''''''''''If topicoSel.Salvar() Then
        '''''''''''    MsgBox("Salvo com sucesso", vbInformation)
        '''''''''''Else
        '''''''''''    MsgBox("Erro ao salvar", vbExclamation)

        '''''''''''End If


        'Using output As FileStream = File.OpenWrite("c:\temp\Sample.docx")
        'provider.Export(document, output)
        'End Using



    End Sub
    Dim topicoSel As Topico
    Private Sub trvTopicos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvTopicos.AfterSelect
        Ampulheta(True, New Form)

        Dim idTopico As Integer = DirectCast(sender, TreeView).SelectedNode.Name

        Dim oTopico As Topico = Topico.Carregar(IdLaudo, idTopico)
        If Not IsNothing(oTopico) Then


            If IsDate(oTopico.dataUltAlteracao) AndAlso Val(oTopico.dataUltAlteracao.ToString("yyyy")) > 1 Then
                lblDataAlteracao.Valor = oTopico.dataUltAlteracao.ToString("dd/MM/yyyy HH:mm")

                lblAlteradoPor.Valor = oTopico.IdUsuarioUltAlteracao
            Else
                lblDataAlteracao.Valor = ""

                lblAlteradoPor.Valor = ""
            End If
            topicoSel = oTopico
        End If

        Ampulheta(False, New Form)


    End Sub

End Class
