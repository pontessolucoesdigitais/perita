Imports Microsoft.VisualBasic
Imports System
Namespace RichTextEditor.TableStyles
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.richTextEditorRibbonBar1 = New Telerik.WinControls.UI.RichTextEditorRibbonBar()
            Me.radRichTextEditor1 = New Telerik.WinControls.UI.RadRichTextEditor()
            Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.richTextEditorRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement1})
            Me.richTextEditorRibbonBar1.Size = New System.Drawing.Size(891, 174)
            Me.richTextEditorRibbonBar1.TabIndex = 0
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
            'radRichTextEditor1
            '
            Me.radRichTextEditor1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.radRichTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radRichTextEditor1.Location = New System.Drawing.Point(0, 174)
            Me.radRichTextEditor1.Name = "radRichTextEditor1"
            Me.radRichTextEditor1.SelectionFill = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.radRichTextEditor1.Size = New System.Drawing.Size(891, 552)
            Me.radRichTextEditor1.TabIndex = 1
            Me.radRichTextEditor1.Text = "radRichTextEditor1"
            '
            'RadButtonElement1
            '
            Me.RadButtonElement1.Name = "RadButtonElement1"
            Me.RadButtonElement1.StretchHorizontally = False
            Me.RadButtonElement1.StretchVertically = False
            Me.RadButtonElement1.Text = "SALVAR....."
            '
            'Form1
            '
            Me.AllowAero = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(891, 726)
            Me.Controls.Add(Me.radRichTextEditor1)
            Me.Controls.Add(Me.richTextEditorRibbonBar1)
            Me.Name = "Form1"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.Text = "Table Styles"
            CType(Me.richTextEditorRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radRichTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private richTextEditorRibbonBar1 As Telerik.WinControls.UI.RichTextEditorRibbonBar
		Private radRichTextEditor1 As Telerik.WinControls.UI.RadRichTextEditor
        Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
    End Class
End Namespace