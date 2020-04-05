<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucClientes))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.dgClientes = New System.Windows.Forms.DataGridView()
        Me.brnNovo = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgClientes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgClientes.Location = New System.Drawing.Point(0, 0)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.Size = New System.Drawing.Size(781, 376)
        Me.dgClientes.TabIndex = 1
        '
        'brnNovo
        '
        Me.brnNovo.AllowToggling = False
        Me.brnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.brnNovo.AnimationSpeed = 200
        Me.brnNovo.AutoGenerateColors = False
        Me.brnNovo.BackColor = System.Drawing.Color.Transparent
        Me.brnNovo.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.brnNovo.BackgroundImage = CType(resources.GetObject("brnNovo.BackgroundImage"), System.Drawing.Image)
        Me.brnNovo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.brnNovo.ButtonText = "Novo Cliente"
        Me.brnNovo.ButtonTextMarginLeft = 0
        Me.brnNovo.ColorContrastOnClick = 45
        Me.brnNovo.ColorContrastOnHover = 45
        Me.brnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.brnNovo.CustomizableEdges = BorderEdges1
        Me.brnNovo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.brnNovo.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.brnNovo.DisabledFillColor = System.Drawing.Color.Gray
        Me.brnNovo.DisabledForecolor = System.Drawing.Color.White
        Me.brnNovo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.brnNovo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.brnNovo.ForeColor = System.Drawing.Color.White
        Me.brnNovo.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.brnNovo.IconMarginLeft = 11
        Me.brnNovo.IconPadding = 5
        Me.brnNovo.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.brnNovo.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.brnNovo.IdleBorderRadius = 25
        Me.brnNovo.IdleBorderThickness = 2
        Me.brnNovo.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.brnNovo.IdleIconLeftImage = Nothing
        Me.brnNovo.IdleIconRightImage = Nothing
        Me.brnNovo.IndicateFocus = False
        Me.brnNovo.Location = New System.Drawing.Point(3, 382)
        Me.brnNovo.Name = "brnNovo"
        StateProperties1.BorderColor = System.Drawing.Color.White
        StateProperties1.BorderRadius = 25
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 2
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Global.Laudos.My.Resources.Resources.word
        StateProperties1.IconRightImage = Nothing
        Me.brnNovo.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 25
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 2
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.brnNovo.OnPressedState = StateProperties2
        Me.brnNovo.Size = New System.Drawing.Size(176, 39)
        Me.brnNovo.TabIndex = 32
        Me.brnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brnNovo.TextMarginLeft = 0
        Me.brnNovo.UseDefaultRadiusAndThickness = True
        '
        'ucClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.brnNovo)
        Me.Controls.Add(Me.dgClientes)
        Me.Name = "ucClientes"
        Me.Size = New System.Drawing.Size(781, 431)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgClientes As DataGridView
    Private WithEvents brnNovo As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
