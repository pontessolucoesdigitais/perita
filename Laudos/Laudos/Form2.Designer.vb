<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pnlDrawer = New System.Windows.Forms.Panel()
        Me.btnToggleDrawer = New Bunifu.Framework.UI.BunifuImageButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.bunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.bunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.bunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.UcLaudos1 = New Laudos.ucLaudos()
        Me.UcClientes1 = New Laudos.ucClientes()
        Me.UcTopicos1 = New Laudos.ucTopicos()
        Me.UcEditor1 = New Laudos.ucEditor()
        Me.pnlDrawer.SuspendLayout()
        CType(Me.btnToggleDrawer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDrawer
        '
        Me.pnlDrawer.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlDrawer.Controls.Add(Me.btnToggleDrawer)
        Me.pnlDrawer.Controls.Add(Me.label4)
        Me.pnlDrawer.Controls.Add(Me.bunifuFlatButton3)
        Me.pnlDrawer.Controls.Add(Me.bunifuFlatButton4)
        Me.pnlDrawer.Controls.Add(Me.bunifuFlatButton2)
        Me.pnlDrawer.Controls.Add(Me.bunifuFlatButton1)
        Me.pnlDrawer.Controls.Add(Me.pictureBox1)
        Me.bunifuTransition1.SetDecoration(Me.pnlDrawer, BunifuAnimatorNS.DecorationType.None)
        Me.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDrawer.Location = New System.Drawing.Point(0, 0)
        Me.pnlDrawer.Name = "pnlDrawer"
        Me.pnlDrawer.Size = New System.Drawing.Size(233, 706)
        Me.pnlDrawer.TabIndex = 1
        '
        'btnToggleDrawer
        '
        Me.btnToggleDrawer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.btnToggleDrawer, BunifuAnimatorNS.DecorationType.None)
        Me.btnToggleDrawer.Image = CType(resources.GetObject("btnToggleDrawer.Image"), System.Drawing.Image)
        Me.btnToggleDrawer.ImageActive = Nothing
        Me.btnToggleDrawer.Location = New System.Drawing.Point(3, 9)
        Me.btnToggleDrawer.Name = "btnToggleDrawer"
        Me.btnToggleDrawer.Size = New System.Drawing.Size(27, 27)
        Me.btnToggleDrawer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnToggleDrawer.TabIndex = 6
        Me.btnToggleDrawer.TabStop = False
        Me.btnToggleDrawer.Zoom = 10
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuTransition1.SetDecoration(Me.label4, BunifuAnimatorNS.DecorationType.None)
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(189, 277)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(19, 13)
        Me.label4.TabIndex = 4
        Me.label4.Text = "10"
        '
        'bunifuFlatButton3
        '
        Me.bunifuFlatButton3.Active = False
        Me.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton3.BorderRadius = 0
        Me.bunifuFlatButton3.ButtonText = "    Support"
        Me.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton3.Iconimage = CType(resources.GetObject("bunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.bunifuFlatButton3.Iconimage_right = Nothing
        Me.bunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton3.Iconimage_Selected = Nothing
        Me.bunifuFlatButton3.IconMarginLeft = 0
        Me.bunifuFlatButton3.IconMarginRight = 0
        Me.bunifuFlatButton3.IconRightVisible = True
        Me.bunifuFlatButton3.IconRightZoom = 0R
        Me.bunifuFlatButton3.IconVisible = True
        Me.bunifuFlatButton3.IconZoom = 50.0R
        Me.bunifuFlatButton3.IsTab = True
        Me.bunifuFlatButton3.Location = New System.Drawing.Point(0, 378)
        Me.bunifuFlatButton3.Name = "bunifuFlatButton3"
        Me.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuFlatButton3.selected = False
        Me.bunifuFlatButton3.Size = New System.Drawing.Size(240, 55)
        Me.bunifuFlatButton3.TabIndex = 5
        Me.bunifuFlatButton3.Text = "    Support"
        Me.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton3.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        '
        'bunifuFlatButton4
        '
        Me.bunifuFlatButton4.Active = False
        Me.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton4.BorderRadius = 0
        Me.bunifuFlatButton4.ButtonText = "    Dashboard"
        Me.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton4.Iconimage = CType(resources.GetObject("bunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.bunifuFlatButton4.Iconimage_right = Nothing
        Me.bunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton4.Iconimage_Selected = Nothing
        Me.bunifuFlatButton4.IconMarginLeft = 0
        Me.bunifuFlatButton4.IconMarginRight = 0
        Me.bunifuFlatButton4.IconRightVisible = True
        Me.bunifuFlatButton4.IconRightZoom = 0R
        Me.bunifuFlatButton4.IconVisible = True
        Me.bunifuFlatButton4.IconZoom = 50.0R
        Me.bunifuFlatButton4.IsTab = True
        Me.bunifuFlatButton4.Location = New System.Drawing.Point(0, 317)
        Me.bunifuFlatButton4.Name = "bunifuFlatButton4"
        Me.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuFlatButton4.selected = False
        Me.bunifuFlatButton4.Size = New System.Drawing.Size(240, 55)
        Me.bunifuFlatButton4.TabIndex = 4
        Me.bunifuFlatButton4.Text = "    Dashboard"
        Me.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton4.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        '
        'bunifuFlatButton2
        '
        Me.bunifuFlatButton2.Active = False
        Me.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton2.BorderRadius = 0
        Me.bunifuFlatButton2.ButtonText = "    Messages"
        Me.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton2.Iconimage = CType(resources.GetObject("bunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.bunifuFlatButton2.Iconimage_right = Nothing
        Me.bunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton2.Iconimage_Selected = Nothing
        Me.bunifuFlatButton2.IconMarginLeft = 0
        Me.bunifuFlatButton2.IconMarginRight = 0
        Me.bunifuFlatButton2.IconRightVisible = True
        Me.bunifuFlatButton2.IconRightZoom = 0R
        Me.bunifuFlatButton2.IconVisible = True
        Me.bunifuFlatButton2.IconZoom = 50.0R
        Me.bunifuFlatButton2.IsTab = True
        Me.bunifuFlatButton2.Location = New System.Drawing.Point(0, 256)
        Me.bunifuFlatButton2.Name = "bunifuFlatButton2"
        Me.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuFlatButton2.selected = False
        Me.bunifuFlatButton2.Size = New System.Drawing.Size(240, 55)
        Me.bunifuFlatButton2.TabIndex = 3
        Me.bunifuFlatButton2.Text = "    Messages"
        Me.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton2.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        '
        'bunifuFlatButton1
        '
        Me.bunifuFlatButton1.Active = True
        Me.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bunifuFlatButton1.BorderRadius = 0
        Me.bunifuFlatButton1.ButtonText = "    Clientes"
        Me.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.bunifuFlatButton1.Iconimage = Global.Laudos.My.Resources.Resources.target
        Me.bunifuFlatButton1.Iconimage_right = Nothing
        Me.bunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.bunifuFlatButton1.Iconimage_Selected = Nothing
        Me.bunifuFlatButton1.IconMarginLeft = 0
        Me.bunifuFlatButton1.IconMarginRight = 0
        Me.bunifuFlatButton1.IconRightVisible = True
        Me.bunifuFlatButton1.IconRightZoom = 0R
        Me.bunifuFlatButton1.IconVisible = True
        Me.bunifuFlatButton1.IconZoom = 50.0R
        Me.bunifuFlatButton1.IsTab = True
        Me.bunifuFlatButton1.Location = New System.Drawing.Point(0, 195)
        Me.bunifuFlatButton1.Name = "bunifuFlatButton1"
        Me.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuFlatButton1.selected = True
        Me.bunifuFlatButton1.Size = New System.Drawing.Size(240, 55)
        Me.bunifuFlatButton1.TabIndex = 2
        Me.bunifuFlatButton1.Text = "    Clientes"
        Me.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.bunifuFlatButton1.TextFont = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.White
        Me.bunifuTransition1.SetDecoration(Me.pictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(12, 42)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(210, 112)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Menu_50px.png")
        Me.imageList1.Images.SetKeyName(1, "Left_48px.png")
        '
        'bunifuTransition1
        '
        Me.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.bunifuTransition1.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.bunifuTransition1.DefaultAnimation = Animation3
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.label3)
        Me.pnlHeader.Controls.Add(Me.bunifuImageButton1)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.label1)
        Me.bunifuTransition1.SetDecoration(Me.pnlHeader, BunifuAnimatorNS.DecorationType.None)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(233, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(985, 31)
        Me.pnlHeader.TabIndex = 2
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuTransition1.SetDecoration(Me.label3, BunifuAnimatorNS.DecorationType.None)
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(914, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(19, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "10"
        '
        'bunifuImageButton1
        '
        Me.bunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.bunifuImageButton1.Image = CType(resources.GetObject("bunifuImageButton1.Image"), System.Drawing.Image)
        Me.bunifuImageButton1.ImageActive = Nothing
        Me.bunifuImageButton1.Location = New System.Drawing.Point(888, 1)
        Me.bunifuImageButton1.Name = "bunifuImageButton1"
        Me.bunifuImageButton1.Size = New System.Drawing.Size(36, 30)
        Me.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bunifuImageButton1.TabIndex = 2
        Me.bunifuImageButton1.TabStop = False
        Me.bunifuImageButton1.Zoom = 10
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bunifuTransition1.SetDecoration(Me.btnClose, BunifuAnimatorNS.DecorationType.None)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(937, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(36, 30)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.bunifuTransition1.SetDecoration(Me.label1, BunifuAnimatorNS.DecorationType.None)
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.LightGray
        Me.label1.Location = New System.Drawing.Point(3, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(110, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "VERSION SOFT"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.panel4.Controls.Add(Me.UcEditor1)
        Me.panel4.Controls.Add(Me.UcLaudos1)
        Me.panel4.Controls.Add(Me.UcClientes1)
        Me.panel4.Controls.Add(Me.UcTopicos1)
        Me.bunifuTransition1.SetDecoration(Me.panel4, BunifuAnimatorNS.DecorationType.None)
        Me.panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel4.Location = New System.Drawing.Point(233, 31)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(985, 675)
        Me.panel4.TabIndex = 3
        '
        'bunifuElipse1
        '
        Me.bunifuElipse1.ElipseRadius = 5
        Me.bunifuElipse1.TargetControl = Me
        '
        'UcLaudos1
        '
        Me.UcLaudos1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcLaudos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuTransition1.SetDecoration(Me.UcLaudos1, BunifuAnimatorNS.DecorationType.None)
        Me.UcLaudos1.IdCliente = 0
        Me.UcLaudos1.Location = New System.Drawing.Point(0, 0)
        Me.UcLaudos1.Name = "UcLaudos1"
        Me.UcLaudos1.Size = New System.Drawing.Size(983, 672)
        Me.UcLaudos1.TabIndex = 3
        Me.UcLaudos1.Visible = False
        '
        'UcClientes1
        '
        Me.UcClientes1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcClientes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuTransition1.SetDecoration(Me.UcClientes1, BunifuAnimatorNS.DecorationType.None)
        Me.UcClientes1.Location = New System.Drawing.Point(0, 0)
        Me.UcClientes1.Name = "UcClientes1"
        Me.UcClientes1.Size = New System.Drawing.Size(985, 675)
        Me.UcClientes1.TabIndex = 2
        '
        'UcTopicos1
        '
        Me.UcTopicos1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcTopicos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bunifuTransition1.SetDecoration(Me.UcTopicos1, BunifuAnimatorNS.DecorationType.None)
        Me.UcTopicos1.IdLaudo = 0
        Me.UcTopicos1.Location = New System.Drawing.Point(0, 0)
        Me.UcTopicos1.Name = "UcTopicos1"
        Me.UcTopicos1.Size = New System.Drawing.Size(982, 672)
        Me.UcTopicos1.TabIndex = 4
        Me.UcTopicos1.Visible = False
        '
        'UcEditor1
        '
        Me.UcEditor1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcEditor1.Conteudo = Nothing
        Me.bunifuTransition1.SetDecoration(Me.UcEditor1, BunifuAnimatorNS.DecorationType.None)
        Me.UcEditor1.IdLaudo = 0
        Me.UcEditor1.IdTopico = 0
        Me.UcEditor1.Location = New System.Drawing.Point(0, 0)
        Me.UcEditor1.Name = "UcEditor1"
        Me.UcEditor1.Size = New System.Drawing.Size(985, 672)
        Me.UcEditor1.TabIndex = 5
        Me.UcEditor1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 706)
        Me.Controls.Add(Me.panel4)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlDrawer)
        Me.bunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDrawer.ResumeLayout(False)
        Me.pnlDrawer.PerformLayout()
        CType(Me.btnToggleDrawer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.bunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlDrawer As Panel
    Private WithEvents label4 As Label
    Public WithEvents bunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents bunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Public WithEvents bunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents bunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Private WithEvents imageList1 As ImageList
    Private WithEvents btnToggleDrawer As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents pnlHeader As Panel
    Private WithEvents label3 As Label
    Private WithEvents bunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents label1 As Label
    Private WithEvents panel4 As Panel
    Private WithEvents bunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Public WithEvents bunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents UcClientes1 As ucClientes
    Friend WithEvents UcLaudos1 As ucLaudos
    Friend WithEvents UcTopicos1 As ucTopicos
    Friend WithEvents UcEditor1 As ucEditor
End Class
