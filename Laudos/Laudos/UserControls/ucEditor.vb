Imports System.IO
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents
Imports Telerik.WinForms.Documents.FormatProviders.OpenXml.Docx
Imports Telerik.WinForms.Documents.Model
Imports Laudos.BLL



Public Class ucEditor

    Private mIdLaudo As Integer
    Public Property IdLaudo() As Integer
        Get
            Return mIdLaudo
        End Get
        Set(ByVal value As Integer)
            mIdLaudo = value
        End Set
    End Property

    Private mIdTopico As Integer
    Public Property IdTopico() As Integer
        Get
            Return mIdTopico
        End Get
        Set(ByVal value As Integer)
            mIdTopico = value
        End Set
    End Property

    Private mConteudo() As Byte
    Public Property Conteudo() As Byte()
        Get
            Return mConteudo
        End Get
        Set(ByVal value() As Byte)
            mConteudo = value
        End Set
    End Property



    Public Sub Carregar()

        radRichTextEditor1.Text = ""

        'Dim topicoSel As Topico = Topico.Carregar(mIdLaudo, mIdTopico)
        Try



            Try
                If Not IsNothing(mConteudo) Then
                    Try
                        Dim provider As New DocxFormatProvider()
                        provider.Import(mConteudo)
                        radRichTextEditor1.Document = provider.Import(mConteudo)

                    Catch ex As Exception
                        radRichTextEditor1.Text = System.Text.Encoding.Unicode.GetString(mConteudo)

                    End Try
                Else
                    radRichTextEditor1.Text = ""
                End If
            Catch ex As Exception
                radRichTextEditor1.Text = ""
            End Try
        Catch ex As Exception
            MsgBox("Erro ao carregar conteudo")
        End Try

    End Sub

    Private Sub richTextEditorRibbonBar1_Click(sender As Object, e As EventArgs)
        Salvar()

    End Sub

    Private Sub Salvar()

        Dim provider As DocxFormatProvider = New DocxFormatProvider()
        Dim document As RadDocument = Me.radRichTextEditor1.Document
        Dim output1 As Byte() = provider.Export(document)

        Dim topicoSel As New Topico
        topicoSel.IdLaudo = IdLaudo
        topicoSel.IdTopico = topicoSel.IdTopico
        topicoSel.IdUsuarioUltAlteracao = 1
        topicoSel.dataUltAlteracao = Now
        topicoSel.Conteudo = output1

        If topicoSel.Salvar() Then
            MsgBox("Salvo com sucesso", vbInformation)
        Else
            MsgBox("Erro ao salvar", vbExclamation)

        End If

    End Sub

    Private Sub ucEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeComponent()


        Dim ribbonUI As New CustomRichTextEditorRibbonBar()
        Panel1.Controls.Add(ribbonUI)
    End Sub

    Public Class CustomRichTextEditorRibbonBar
        Inherits RichTextEditorRibbonBar

        Protected Overrides Sub Initialize()
            MyBase.Initialize()
            Me.buttonSaveHTML.Visible = False
            Me.buttonSavePlain.Visible = False
            Me.buttonSaveRich.Visible = False
            Me.buttonXAML.Visible = False
            Me.buttonSave.Visibility = False


        End Sub
    End Class

End Class
