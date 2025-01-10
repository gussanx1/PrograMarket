<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPrincipal
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FiveCodSlidingMovingMenu1 = New FiveCodMaterialDesign.FiveCodSlidingMovingMenu()
        Me.btnUsuario = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnCliente = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnProveedor = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnProducto = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnCompra = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnVenta = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnRegistroCompras = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnReporteCompras = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnReporteVentas = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnAcercaDe = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnMenuSliding = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.contenido = New System.Windows.Forms.Panel()
        Me.FiveCodSlidingMovingMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FiveCodSlidingMovingMenu1
        '
        Me.FiveCodSlidingMovingMenu1.BottomLeft = System.Drawing.Color.Blue
        Me.FiveCodSlidingMovingMenu1.BottomRight = System.Drawing.Color.DeepSkyBlue
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnUsuario)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnCliente)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnProveedor)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnProducto)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnCompra)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnVenta)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnRegistroCompras)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnReporteCompras)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnReporteVentas)
        Me.FiveCodSlidingMovingMenu1.Controls.Add(Me.btnAcercaDe)
        Me.FiveCodSlidingMovingMenu1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FiveCodSlidingMovingMenu1.FCButton = Me.btnMenuSliding
        Me.FiveCodSlidingMovingMenu1.FCSlidingEnable = False
        Me.FiveCodSlidingMovingMenu1.FiveCodColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FiveCodSlidingMovingMenu1.FiveCodStyle = FiveCodMaterialDesign.FiveCodGradientPanel.GradientStyle.Vertical
        Me.FiveCodSlidingMovingMenu1.HideControls = True
        Me.FiveCodSlidingMovingMenu1.Location = New System.Drawing.Point(3, 64)
        Me.FiveCodSlidingMovingMenu1.Name = "FiveCodSlidingMovingMenu1"
        Me.FiveCodSlidingMovingMenu1.PanelWidthCollapsed = 0
        Me.FiveCodSlidingMovingMenu1.PanelWidthExpanded = 200
        Me.FiveCodSlidingMovingMenu1.Size = New System.Drawing.Size(200, 823)
        Me.FiveCodSlidingMovingMenu1.TabIndex = 3
        Me.FiveCodSlidingMovingMenu1.TopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.FiveCodSlidingMovingMenu1.TopRight = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(199, Byte), Integer))
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.BGColor = "#00b6ff"
        Me.btnUsuario.Enabled = False
        Me.btnUsuario.FontColor = "#ffffff"
        Me.btnUsuario.ImageButton = Global.PrograMarket.My.Resources.Resources.usuario
        Me.btnUsuario.Location = New System.Drawing.Point(3, 74)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUsuario.Size = New System.Drawing.Size(193, 41)
        Me.btnUsuario.TabIndex = 0
        Me.btnUsuario.Text = "Usuario"
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnCliente.BGColor = "#00b6ff"
        Me.btnCliente.Enabled = False
        Me.btnCliente.FontColor = "#ffffff"
        Me.btnCliente.ImageButton = Global.PrograMarket.My.Resources.Resources.cliente
        Me.btnCliente.Location = New System.Drawing.Point(3, 122)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCliente.Size = New System.Drawing.Size(193, 41)
        Me.btnCliente.TabIndex = 1
        Me.btnCliente.Text = "Cliente"
        '
        'btnProveedor
        '
        Me.btnProveedor.BackColor = System.Drawing.Color.Transparent
        Me.btnProveedor.BGColor = "#00b6ff"
        Me.btnProveedor.Enabled = False
        Me.btnProveedor.FontColor = "#ffffff"
        Me.btnProveedor.ImageButton = Global.PrograMarket.My.Resources.Resources.proveedor
        Me.btnProveedor.Location = New System.Drawing.Point(3, 170)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProveedor.Size = New System.Drawing.Size(193, 41)
        Me.btnProveedor.TabIndex = 2
        Me.btnProveedor.Text = "Proveedor"
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnProducto.BGColor = "#00b6ff"
        Me.btnProducto.Enabled = False
        Me.btnProducto.FontColor = "#ffffff"
        Me.btnProducto.ImageButton = Global.PrograMarket.My.Resources.Resources.producto
        Me.btnProducto.Location = New System.Drawing.Point(3, 217)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProducto.Size = New System.Drawing.Size(193, 41)
        Me.btnProducto.TabIndex = 3
        Me.btnProducto.Text = "Producto"
        '
        'btnCompra
        '
        Me.btnCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnCompra.BGColor = "#00b6ff"
        Me.btnCompra.Enabled = False
        Me.btnCompra.FontColor = "#ffffff"
        Me.btnCompra.ImageButton = Global.PrograMarket.My.Resources.Resources.compra
        Me.btnCompra.Location = New System.Drawing.Point(3, 264)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCompra.Size = New System.Drawing.Size(193, 41)
        Me.btnCompra.TabIndex = 4
        Me.btnCompra.Text = "Compra"
        '
        'btnVenta
        '
        Me.btnVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnVenta.BGColor = "#00b6ff"
        Me.btnVenta.Enabled = False
        Me.btnVenta.FontColor = "#ffffff"
        Me.btnVenta.ImageButton = Global.PrograMarket.My.Resources.Resources.venta
        Me.btnVenta.Location = New System.Drawing.Point(3, 311)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVenta.Size = New System.Drawing.Size(193, 41)
        Me.btnVenta.TabIndex = 5
        Me.btnVenta.Text = "Venta"
        '
        'btnRegistroCompras
        '
        Me.btnRegistroCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistroCompras.BGColor = "#00b6ff"
        Me.btnRegistroCompras.Enabled = False
        Me.btnRegistroCompras.FontColor = "#ffffff"
        Me.btnRegistroCompras.ImageButton = Global.PrograMarket.My.Resources.Resources.registrocompra
        Me.btnRegistroCompras.Location = New System.Drawing.Point(3, 359)
        Me.btnRegistroCompras.Name = "btnRegistroCompras"
        Me.btnRegistroCompras.Size = New System.Drawing.Size(193, 41)
        Me.btnRegistroCompras.TabIndex = 8
        Me.btnRegistroCompras.Text = "Registro Compras"
        '
        'btnReporteCompras
        '
        Me.btnReporteCompras.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteCompras.BGColor = "#00b6ff"
        Me.btnReporteCompras.Enabled = False
        Me.btnReporteCompras.FontColor = "#ffffff"
        Me.btnReporteCompras.ImageButton = Global.PrograMarket.My.Resources.Resources.reportecompra
        Me.btnReporteCompras.Location = New System.Drawing.Point(3, 406)
        Me.btnReporteCompras.Name = "btnReporteCompras"
        Me.btnReporteCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReporteCompras.Size = New System.Drawing.Size(193, 41)
        Me.btnReporteCompras.TabIndex = 6
        Me.btnReporteCompras.Text = "Reportes Compras"
        '
        'btnReporteVentas
        '
        Me.btnReporteVentas.BackColor = System.Drawing.Color.Transparent
        Me.btnReporteVentas.BGColor = "#00b6ff"
        Me.btnReporteVentas.Enabled = False
        Me.btnReporteVentas.FontColor = "#ffffff"
        Me.btnReporteVentas.ImageButton = Global.PrograMarket.My.Resources.Resources.reporteventa
        Me.btnReporteVentas.Location = New System.Drawing.Point(2, 453)
        Me.btnReporteVentas.Name = "btnReporteVentas"
        Me.btnReporteVentas.Size = New System.Drawing.Size(194, 41)
        Me.btnReporteVentas.TabIndex = 10
        Me.btnReporteVentas.Text = "Reportes Ventas"
        '
        'btnAcercaDe
        '
        Me.btnAcercaDe.BackColor = System.Drawing.Color.Transparent
        Me.btnAcercaDe.BGColor = "#00b6ff"
        Me.btnAcercaDe.Enabled = False
        Me.btnAcercaDe.FontColor = "#ffffff"
        Me.btnAcercaDe.ImageButton = Global.PrograMarket.My.Resources.Resources.acercade
        Me.btnAcercaDe.Location = New System.Drawing.Point(3, 500)
        Me.btnAcercaDe.Name = "btnAcercaDe"
        Me.btnAcercaDe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAcercaDe.Size = New System.Drawing.Size(193, 41)
        Me.btnAcercaDe.TabIndex = 7
        Me.btnAcercaDe.Text = "Acerca De"
        '
        'btnMenuSliding
        '
        Me.btnMenuSliding.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuSliding.BGColor = "#0b8793"
        Me.btnMenuSliding.FontColor = "#ffffff"
        Me.btnMenuSliding.ImageButton = Global.PrograMarket.My.Resources.Resources.menusliding
        Me.btnMenuSliding.Location = New System.Drawing.Point(11, 75)
        Me.btnMenuSliding.Name = "btnMenuSliding"
        Me.btnMenuSliding.Size = New System.Drawing.Size(119, 38)
        Me.btnMenuSliding.TabIndex = 5
        Me.btnMenuSliding.Text = "          Menu"
        '
        'contenido
        '
        Me.contenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contenido.AutoScroll = True
        Me.contenido.AutoSize = True
        Me.contenido.BackColor = System.Drawing.Color.White
        Me.contenido.Location = New System.Drawing.Point(-1, 64)
        Me.contenido.Name = "contenido"
        Me.contenido.Size = New System.Drawing.Size(1608, 829)
        Me.contenido.TabIndex = 6
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1606, 890)
        Me.Controls.Add(Me.btnMenuSliding)
        Me.Controls.Add(Me.FiveCodSlidingMovingMenu1)
        Me.Controls.Add(Me.contenido)
        Me.Name = "FormularioPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PM Progra Market"
        Me.FiveCodSlidingMovingMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FiveCodSlidingMovingMenu1 As FiveCodMaterialDesign.FiveCodSlidingMovingMenu
    Friend WithEvents btnUsuario As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnProveedor As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnCliente As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnAcercaDe As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnReporteCompras As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnVenta As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnCompra As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnProducto As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnMenuSliding As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents contenido As Panel
    Friend WithEvents btnRegistroCompras As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnReporteVentas As FiveCodMaterialDesign.FiveCodImageButton
End Class
