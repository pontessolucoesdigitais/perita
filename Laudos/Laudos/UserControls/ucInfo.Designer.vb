<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInfo
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
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.bunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.SuspendLayout()
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblValor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblValor.ForeColor = System.Drawing.Color.DarkGray
        Me.lblValor.Location = New System.Drawing.Point(16, 29)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(62, 15)
        Me.lblValor.TabIndex = 25
        Me.lblValor.Text = "email here"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNome.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(15, 9)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(87, 20)
        Me.lblNome.TabIndex = 24
        Me.lblNome.Text = "Name Here"
        '
        'bunifuSeparator1
        '
        Me.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left
        Me.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bunifuSeparator1.LineThickness = 4
        Me.bunifuSeparator1.Location = New System.Drawing.Point(0, 0)
        Me.bunifuSeparator1.Name = "bunifuSeparator1"
        Me.bunifuSeparator1.Size = New System.Drawing.Size(10, 56)
        Me.bunifuSeparator1.TabIndex = 23
        Me.bunifuSeparator1.Transparency = 255
        Me.bunifuSeparator1.Vertical = True
        '
        'ucInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.bunifuSeparator1)
        Me.Name = "ucInfo"
        Me.Size = New System.Drawing.Size(308, 56)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblValor As Label
    Private WithEvents lblNome As Label
    Private WithEvents bunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
