<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbClientes = New System.Windows.Forms.TabPage()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.tbLaudos = New System.Windows.Forms.TabPage()
        Me.dgLaudos = New System.Windows.Forms.DataGridView()
        Me.tbTopicos = New System.Windows.Forms.TabPage()
        Me.trvTopicos = New System.Windows.Forms.TreeView()
        Me.tbEditor = New System.Windows.Forms.TabPage()
        Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
        Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
        Me.object_22b6a235_e944_47df_9777_be3c4cf53f4f = New Telerik.WinControls.RootRadElement()
        Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbClientes.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbLaudos.SuspendLayout()
        CType(Me.dgLaudos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTopicos.SuspendLayout()
        Me.tbEditor.SuspendLayout()
        CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbClientes)
        Me.TabControl1.Controls.Add(Me.tbLaudos)
        Me.TabControl1.Controls.Add(Me.tbTopicos)
        Me.TabControl1.Controls.Add(Me.tbEditor)
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1178, 730)
        Me.TabControl1.TabIndex = 0
        '
        'tbClientes
        '
        Me.tbClientes.Controls.Add(Me.dgClientes)
        Me.tbClientes.Location = New System.Drawing.Point(4, 22)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbClientes.Size = New System.Drawing.Size(1170, 704)
        Me.tbClientes.TabIndex = 0
        Me.tbClientes.Text = "Clientes"
        Me.tbClientes.UseVisualStyleBackColor = True
        '
        'dgClientes
        '
        Me.dgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(1172, 738)
        Me.dgClientes.TabIndex = 0
        '
        'tbLaudos
        '
        Me.tbLaudos.Controls.Add(Me.dgLaudos)
        Me.tbLaudos.Location = New System.Drawing.Point(4, 22)
        Me.tbLaudos.Name = "tbLaudos"
        Me.tbLaudos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbLaudos.Size = New System.Drawing.Size(1170, 704)
        Me.tbLaudos.TabIndex = 2
        Me.tbLaudos.Text = "Laudos"
        Me.tbLaudos.UseVisualStyleBackColor = True
        '
        'dgLaudos
        '
        Me.dgLaudos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLaudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLaudos.Location = New System.Drawing.Point(3, 3)
        Me.dgLaudos.Name = "dgLaudos"
        Me.dgLaudos.Size = New System.Drawing.Size(1164, 701)
        Me.dgLaudos.TabIndex = 1
        '
        'tbTopicos
        '
        Me.tbTopicos.Controls.Add(Me.Button1)
        Me.tbTopicos.Controls.Add(Me.Label4)
        Me.tbTopicos.Controls.Add(Me.Label3)
        Me.tbTopicos.Controls.Add(Me.Label2)
        Me.tbTopicos.Controls.Add(Me.Label1)
        Me.tbTopicos.Controls.Add(Me.trvTopicos)
        Me.tbTopicos.Location = New System.Drawing.Point(4, 22)
        Me.tbTopicos.Name = "tbTopicos"
        Me.tbTopicos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTopicos.Size = New System.Drawing.Size(1170, 704)
        Me.tbTopicos.TabIndex = 3
        Me.tbTopicos.Text = "Tópicos"
        Me.tbTopicos.UseVisualStyleBackColor = True
        '
        'trvTopicos
        '
        Me.trvTopicos.AllowDrop = True
        Me.trvTopicos.FullRowSelect = True
        Me.trvTopicos.Location = New System.Drawing.Point(6, 6)
        Me.trvTopicos.Name = "trvTopicos"
        Me.trvTopicos.ShowNodeToolTips = True
        Me.trvTopicos.ShowPlusMinus = False
        Me.trvTopicos.Size = New System.Drawing.Size(580, 690)
        Me.trvTopicos.TabIndex = 4
        '
        'tbEditor
        '
        Me.tbEditor.Controls.Add(Me.radRichTextEditor1)
        Me.tbEditor.Controls.Add(Me.richTextEditorRibbonBar1)
        Me.tbEditor.Location = New System.Drawing.Point(4, 22)
        Me.tbEditor.Name = "tbEditor"
        Me.tbEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEditor.Size = New System.Drawing.Size(1170, 704)
        Me.tbEditor.TabIndex = 1
        Me.tbEditor.Text = "Editor"
        Me.tbEditor.UseVisualStyleBackColor = True
        '
        'radRichTextEditor1
        '
        Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radRichTextEditor1.Location = New System.Drawing.Point(3, 177)
        Me.radRichTextEditor1.Name = "radRichTextEditor1"
        Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radRichTextEditor1.Size = New System.Drawing.Size(1164, 524)
        Me.radRichTextEditor1.TabIndex = 3
        Me.radRichTextEditor1.Text = "radRichTextEditor1"
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
        Me.richTextEditorRibbonBar1.Location = New System.Drawing.Point(3, 3)
        Me.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1"
        '
        '
        '
        Me.richTextEditorRibbonBar1.OptionsButton.Text = "Options"
        Me.richTextEditorRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1})
        Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(1164, 174)
        Me.richTextEditorRibbonBar1.TabIndex = 2
        Me.richTextEditorRibbonBar1.TabStop = False
        Me.richTextEditorRibbonBar1.Text = "Table Styles"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0), Telerik.WinControls.UI.RadRibbonBarElement).Text = "Table Styles"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).IsSelected = False
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Home"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabHome"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Page Layout"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabPageLayout"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "References"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabReferences"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Mailings"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabMailings"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "Review"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(5), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabReview"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Text = "View"
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.richTextEditorRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0).GetChildAt(0).GetChildAt(6), Telerik.WinControls.UI.RichTextEditorRibbonUI.RichTextEditorRibbonTab).Name = "tabView"
        '
        'object_22b6a235_e944_47df_9777_be3c4cf53f4f
        '
        Me.object_22b6a235_e944_47df_9777_be3c4cf53f4f.Name = "object_22b6a235_e944_47df_9777_be3c4cf53f4f"
        Me.object_22b6a235_e944_47df_9777_be3c4cf53f4f.StretchHorizontally = True
        Me.object_22b6a235_e944_47df_9777_be3c4cf53f4f.StretchVertically = True
        '
        'RadButtonElement1
        '
        Me.RadButtonElement1.Name = "RadButtonElement1"
        Me.RadButtonElement1.StretchHorizontally = False
        Me.RadButtonElement1.StretchVertically = False
        Me.RadButtonElement1.Text = "SALVAR "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(593, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Alteração:  XX/XX/XXX XX:XX:XX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(592, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bloqueado Para: Xxxxxxxxxxxxxxxxxxxxx Xxxxxxxxxxxxxxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(592, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Alterado Por: Xxxxxxxxxxxxxxxxx Xxxxxxxxxxxxxx"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 667)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Abrir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tbClientes.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbLaudos.ResumeLayout(False)
        CType(Me.dgLaudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTopicos.ResumeLayout(False)
        Me.tbTopicos.PerformLayout()
        Me.tbEditor.ResumeLayout(False)
        Me.tbEditor.PerformLayout()
        CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbEditor As TabPage
    Friend WithEvents tbLaudos As TabPage
    Friend WithEvents tbTopicos As TabPage
    Friend WithEvents object_22b6a235_e944_47df_9777_be3c4cf53f4f As Telerik.WinControls.RootRadElement
    Private WithEvents radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
    Private WithEvents richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
    Friend WithEvents tbClientes As TabPage
    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents dgLaudos As DataGridView
    Friend WithEvents trvTopicos As TreeView
    Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
