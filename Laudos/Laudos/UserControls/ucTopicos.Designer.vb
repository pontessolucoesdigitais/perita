<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTopicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTopicos))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.trvTopicos = New System.Windows.Forms.TreeView()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnEditPhoto = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lblSituacao = New Laudos.ucInfo()
        Me.lblBloqueadoPor = New Laudos.ucInfo()
        Me.lblAlteradoPor = New Laudos.ucInfo()
        Me.lblDataAlteracao = New Laudos.ucInfo()
        Me.SuspendLayout()
        '
        'trvTopicos
        '
        Me.trvTopicos.AllowDrop = True
        Me.trvTopicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvTopicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.trvTopicos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.trvTopicos.ForeColor = System.Drawing.Color.White
        Me.trvTopicos.FullRowSelect = True
        Me.trvTopicos.Location = New System.Drawing.Point(3, 3)
        Me.trvTopicos.Name = "trvTopicos"
        Me.trvTopicos.ShowNodeToolTips = True
        Me.trvTopicos.ShowPlusMinus = False
        Me.trvTopicos.Size = New System.Drawing.Size(580, 591)
        Me.trvTopicos.TabIndex = 31
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = "   Abrir Tópico"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton3.CustomizableEdges = BorderEdges1
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 5
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BunifuButton3.IdleBorderRadius = 25
        Me.BunifuButton3.IdleBorderThickness = 2
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuButton3.IdleIconLeftImage = Nothing
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(5, 600)
        Me.BunifuButton3.Name = "BunifuButton3"
        StateProperties1.BorderColor = System.Drawing.Color.White
        StateProperties1.BorderRadius = 25
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 2
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Global.Laudos.My.Resources.Resources.word
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 25
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 2
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState = StateProperties2
        Me.BunifuButton3.Size = New System.Drawing.Size(176, 39)
        Me.BunifuButton3.TabIndex = 37
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'btnEditPhoto
        '
        Me.btnEditPhoto.AllowToggling = False
        Me.btnEditPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditPhoto.AnimationSpeed = 200
        Me.btnEditPhoto.AutoGenerateColors = False
        Me.btnEditPhoto.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPhoto.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEditPhoto.BackgroundImage = CType(resources.GetObject("btnEditPhoto.BackgroundImage"), System.Drawing.Image)
        Me.btnEditPhoto.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEditPhoto.ButtonText = "   Abrir Tópico"
        Me.btnEditPhoto.ButtonTextMarginLeft = 0
        Me.btnEditPhoto.ColorContrastOnClick = 45
        Me.btnEditPhoto.ColorContrastOnHover = 45
        Me.btnEditPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnEditPhoto.CustomizableEdges = BorderEdges2
        Me.btnEditPhoto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditPhoto.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEditPhoto.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnEditPhoto.DisabledForecolor = System.Drawing.Color.White
        Me.btnEditPhoto.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnEditPhoto.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditPhoto.ForeColor = System.Drawing.Color.White
        Me.btnEditPhoto.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnEditPhoto.IconMarginLeft = 11
        Me.btnEditPhoto.IconPadding = 5
        Me.btnEditPhoto.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnEditPhoto.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnEditPhoto.IdleBorderRadius = 25
        Me.btnEditPhoto.IdleBorderThickness = 2
        Me.btnEditPhoto.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEditPhoto.IdleIconLeftImage = Global.Laudos.My.Resources.Resources.word
        Me.btnEditPhoto.IdleIconRightImage = Nothing
        Me.btnEditPhoto.IndicateFocus = False
        Me.btnEditPhoto.Location = New System.Drawing.Point(594, 261)
        Me.btnEditPhoto.Name = "btnEditPhoto"
        StateProperties3.BorderColor = System.Drawing.Color.White
        StateProperties3.BorderRadius = 25
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 2
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Global.Laudos.My.Resources.Resources.word
        StateProperties3.IconRightImage = Nothing
        Me.btnEditPhoto.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 25
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 2
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnEditPhoto.OnPressedState = StateProperties4
        Me.btnEditPhoto.Size = New System.Drawing.Size(308, 39)
        Me.btnEditPhoto.TabIndex = 36
        Me.btnEditPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditPhoto.TextMarginLeft = 0
        Me.btnEditPhoto.UseDefaultRadiusAndThickness = True
        '
        'lblSituacao
        '
        Me.lblSituacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSituacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblSituacao.Location = New System.Drawing.Point(594, 193)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Nome = " Situação"
        Me.lblSituacao.Size = New System.Drawing.Size(308, 56)
        Me.lblSituacao.TabIndex = 35
        Me.lblSituacao.Valor = ""
        '
        'lblBloqueadoPor
        '
        Me.lblBloqueadoPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBloqueadoPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblBloqueadoPor.Location = New System.Drawing.Point(594, 131)
        Me.lblBloqueadoPor.Name = "lblBloqueadoPor"
        Me.lblBloqueadoPor.Nome = " Bloqueado Por"
        Me.lblBloqueadoPor.Size = New System.Drawing.Size(308, 56)
        Me.lblBloqueadoPor.TabIndex = 34
        Me.lblBloqueadoPor.Valor = ""
        '
        'lblAlteradoPor
        '
        Me.lblAlteradoPor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlteradoPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblAlteradoPor.Location = New System.Drawing.Point(594, 69)
        Me.lblAlteradoPor.Name = "lblAlteradoPor"
        Me.lblAlteradoPor.Nome = "Alterado Por"
        Me.lblAlteradoPor.Size = New System.Drawing.Size(308, 56)
        Me.lblAlteradoPor.TabIndex = 33
        Me.lblAlteradoPor.Valor = ""
        '
        'lblDataAlteracao
        '
        Me.lblDataAlteracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataAlteracao.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblDataAlteracao.Location = New System.Drawing.Point(594, 7)
        Me.lblDataAlteracao.Name = "lblDataAlteracao"
        Me.lblDataAlteracao.Nome = "Data Alteração"
        Me.lblDataAlteracao.Size = New System.Drawing.Size(308, 56)
        Me.lblDataAlteracao.TabIndex = 32
        Me.lblDataAlteracao.Valor = ""
        '
        'ucTopicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.BunifuButton3)
        Me.Controls.Add(Me.btnEditPhoto)
        Me.Controls.Add(Me.trvTopicos)
        Me.Controls.Add(Me.lblSituacao)
        Me.Controls.Add(Me.lblBloqueadoPor)
        Me.Controls.Add(Me.lblAlteradoPor)
        Me.Controls.Add(Me.lblDataAlteracao)
        Me.Name = "ucTopicos"
        Me.Size = New System.Drawing.Size(937, 642)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Private WithEvents btnEditPhoto As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents trvTopicos As TreeView
    Friend WithEvents lblSituacao As ucInfo
    Friend WithEvents lblBloqueadoPor As ucInfo
    Friend WithEvents lblAlteradoPor As ucInfo
    Friend WithEvents lblDataAlteracao As ucInfo
End Class
