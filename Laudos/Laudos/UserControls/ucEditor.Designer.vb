<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEditor
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.documentRuler1 = New Telerik.WinControls.UI.RadRichTextEditorRuler()
        Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
        CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.documentRuler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.documentRuler1.SuspendLayout()
        CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radRichTextEditor1
        '
        Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.radRichTextEditor1.Location = New System.Drawing.Point(29, 29)
        Me.radRichTextEditor1.Name = "radRichTextEditor1"
        Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radRichTextEditor1.Size = New System.Drawing.Size(1353, 622)
        Me.radRichTextEditor1.TabIndex = 0
        Me.radRichTextEditor1.Text = "radRichTextEditor1"
        '
        'documentRuler1
        '
        Me.documentRuler1.AssociatedRichTextBox = Me.radRichTextEditor1
        Me.documentRuler1.Controls.Add(Me.radRichTextEditor1)
        Me.documentRuler1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.documentRuler1.Location = New System.Drawing.Point(0, 174)
        Me.documentRuler1.Name = "documentRuler1"
        Me.documentRuler1.Size = New System.Drawing.Size(1383, 652)
        Me.documentRuler1.TabIndex = 3
        '
        'richTextEditorRibbonBar1
        '
        Me.richTextEditorRibbonBar1.ApplicationMenuStyle = Telerik.WinControls.UI.ApplicationMenuStyle.BackstageView
        Me.richTextEditorRibbonBar1.AssociatedRichTextEditor = Me.radRichTextEditor1
        Me.richTextEditorRibbonBar1.BuiltInStylesVersion = Telerik.WinForms.Documents.Model.Styles.BuiltInStylesVersion.Office2013
        Me.richTextEditorRibbonBar1.EnableKeyMap = False
        '
        '
        '
        Me.richTextEditorRibbonBar1.ExitButton.Text = "Exit"
        Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
        '
        '
        '
        Me.richTextEditorRibbonBar1.OptionsButton.Text = "Options"
        Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1383, 174)
        Me.richTextEditorRibbonBar1.TabIndex = 2
        Me.richTextEditorRibbonBar1.TabStop = False
        Me.richTextEditorRibbonBar1.Text = "First Look"
        '
        'ucEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.documentRuler1)
        Me.Controls.Add(Me.richTextEditorRibbonBar1)
        Me.Name = "ucEditor"
        Me.Size = New System.Drawing.Size(1383, 826)
        CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.documentRuler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.documentRuler1.ResumeLayout(False)
        CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
    Private WithEvents documentRuler1 As Telerik.WinControls.UI.RadRichTextEditorRuler
    Private WithEvents richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
End Class
