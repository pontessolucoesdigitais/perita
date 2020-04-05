Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.Model
Imports Laudos.BLL

Public Class Form2

    Dim DrawerOpen As Boolean = True

    Dim idLaudoSel As Integer
    'Dim idTopicoSel As Integer = 0

    Dim topicoSel As Topico

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        UcClientes1.Carregar()
    End Sub
    Private Sub btnToggleDrawer_Click(sender As Object, e As EventArgs) Handles btnToggleDrawer.Click
        DrawerOpen = Not DrawerOpen
        pnlDrawer.Visible = False

        If DrawerOpen Then

            'animated Drawer Open
            pnlDrawer.Width = 233
            btnToggleDrawer.Image = imageList1.Images(1)
            bunifuTransition1.ShowSync(pnlDrawer)
            pictureBox1.Visible = True
        Else
            'Aminated Drawer close
            pnlDrawer.Width = 56
            btnToggleDrawer.Image = imageList1.Images(0)
            bunifuTransition1.ShowSync(pnlDrawer)
            pictureBox1.Visible = False
        End If

    End Sub

    Private Sub UcClientes1_AposSelecao(idSel As Integer) Handles UcClientes1.AposSelecao

        UcLaudos1.IdCliente = idSel
        UcLaudos1.Carregar()
        UcLaudos1.Visible = True
        UcClientes1.Visible = False

    End Sub

    Private Sub UcLaudosAposSelecao(idSel As Integer) Handles UcLaudos1.AposSelecao

        UcTopicos1.IdLaudo = idSel
        UcTopicos1.Carregar()
        UcTopicos1.Visible = True
        UcLaudos1.Visible = False

    End Sub

    Private Sub UcTopicos1_AbrirEditor(oTopico As Topico) Handles UcTopicos1.AbrirEditor
        Dim auxTop As New Topico()
        auxTop = oTopico

        Do While Not IsNothing(auxTop.Pai)
            label1.Text = auxTop.Pai.Nome & " > " & label1.Text
            auxTop = auxTop.Pai
        Loop

        auxTop = Nothing

        label1.Text &= oTopico.Nome

        UcEditor1.IdLaudo = oTopico.IdLaudo
        UcEditor1.IdTopico = oTopico.IdTopico
        UcEditor1.Conteudo = oTopico.Conteudo
        UcEditor1.Carregar()
        UcEditor1.Visible = True
        UcTopicos1.Visible = False
    End Sub
End Class