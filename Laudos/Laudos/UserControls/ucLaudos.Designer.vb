<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucLaudos
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucLaudos))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.brnNovoLaudo = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.dg = New System.Windows.Forms.DataGridView()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brnNovoLaudo
        '
        Me.brnNovoLaudo.AllowToggling = False
        Me.brnNovoLaudo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.brnNovoLaudo.AnimationSpeed = 200
        Me.brnNovoLaudo.AutoGenerateColors = False
        Me.brnNovoLaudo.BackColor = System.Drawing.Color.Transparent
        Me.brnNovoLaudo.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.brnNovoLaudo.BackgroundImage = CType(resources.GetObject("brnNovoLaudo.BackgroundImage"), System.Drawing.Image)
        Me.brnNovoLaudo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.brnNovoLaudo.ButtonText = "Novo Laudo"
        Me.brnNovoLaudo.ButtonTextMarginLeft = 0
        Me.brnNovoLaudo.ColorContrastOnClick = 45
        Me.brnNovoLaudo.ColorContrastOnHover = 45
        Me.brnNovoLaudo.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.brnNovoLaudo.CustomizableEdges = BorderEdges1
        Me.brnNovoLaudo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.brnNovoLaudo.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.brnNovoLaudo.DisabledFillColor = System.Drawing.Color.Gray
        Me.brnNovoLaudo.DisabledForecolor = System.Drawing.Color.White
        Me.brnNovoLaudo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.brnNovoLaudo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.brnNovoLaudo.ForeColor = System.Drawing.Color.White
        Me.brnNovoLaudo.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.brnNovoLaudo.IconMarginLeft = 11
        Me.brnNovoLaudo.IconPadding = 5
        Me.brnNovoLaudo.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.brnNovoLaudo.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.brnNovoLaudo.IdleBorderRadius = 25
        Me.brnNovoLaudo.IdleBorderThickness = 2
        Me.brnNovoLaudo.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.brnNovoLaudo.IdleIconLeftImage = Nothing
        Me.brnNovoLaudo.IdleIconRightImage = Nothing
        Me.brnNovoLaudo.IndicateFocus = False
        Me.brnNovoLaudo.Location = New System.Drawing.Point(3, 382)
        Me.brnNovoLaudo.Name = "brnNovoLaudo"
        StateProperties1.BorderColor = System.Drawing.Color.White
        StateProperties1.BorderRadius = 25
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 2
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Global.Laudos.My.Resources.Resources.word
        StateProperties1.IconRightImage = Nothing
        Me.brnNovoLaudo.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 25
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 2
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.brnNovoLaudo.OnPressedState = StateProperties2
        Me.brnNovoLaudo.Size = New System.Drawing.Size(176, 39)
        Me.brnNovoLaudo.TabIndex = 34
        Me.brnNovoLaudo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brnNovoLaudo.TextMarginLeft = 0
        Me.brnNovoLaudo.UseDefaultRadiusAndThickness = True
        '
        'dgClientes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.Name = "dgClientes"
        Me.dg.Size = New System.Drawing.Size(781, 376)
        Me.dg.TabIndex = 33
        '
        'ucLaudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.brnNovoLaudo)
        Me.Controls.Add(Me.dg)
        Me.Name = "ucLaudos"
        Me.Size = New System.Drawing.Size(781, 431)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents brnNovoLaudo As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents dg As DataGridView
End Class
