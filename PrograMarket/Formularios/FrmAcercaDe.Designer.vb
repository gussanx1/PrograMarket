<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAcercaDe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAcercaDe))
        Me.fecha = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FiveCodGradientPanel1 = New FiveCodMaterialDesign.FiveCodGradientPanel()
        Me.lblHora = New MaterialSkin.Controls.MaterialLabel()
        Me.lblFecha = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FiveCodGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.Enabled = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel1.Location = New System.Drawing.Point(499, 2)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(796, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "PrograMarket, el programa para realizar las operaciones de registro, facil, rápid" &
    "o e interactivo para tu MiniMarket."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.FiveCodGradientPanel1)
        Me.Panel1.Controls.Add(Me.MaterialLabel11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.MaterialLabel10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.MaterialLabel9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.MaterialLabel8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.MaterialLabel7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MaterialLabel6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MaterialLabel5)
        Me.Panel1.Controls.Add(Me.MaterialLabel4)
        Me.Panel1.Controls.Add(Me.MaterialLabel3)
        Me.Panel1.Controls.Add(Me.MaterialLabel2)
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1615, 770)
        Me.Panel1.TabIndex = 2
        '
        'FiveCodGradientPanel1
        '
        Me.FiveCodGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.FiveCodGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FiveCodGradientPanel1.Controls.Add(Me.lblHora)
        Me.FiveCodGradientPanel1.Controls.Add(Me.lblFecha)
        Me.FiveCodGradientPanel1.Controls.Add(Me.MaterialLabel12)
        Me.FiveCodGradientPanel1.FiveCodColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.FiveCodGradientPanel1.FiveCodStyle = FiveCodMaterialDesign.FiveCodGradientPanel.GradientStyle.Corners
        Me.FiveCodGradientPanel1.Location = New System.Drawing.Point(-1, 24)
        Me.FiveCodGradientPanel1.Name = "FiveCodGradientPanel1"
        Me.FiveCodGradientPanel1.Size = New System.Drawing.Size(1613, 100)
        Me.FiveCodGradientPanel1.TabIndex = 6
        Me.FiveCodGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FiveCodGradientPanel1.TopRight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Depth = 0
        Me.lblHora.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHora.Location = New System.Drawing.Point(1469, 18)
        Me.lblHora.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(35, 19)
        Me.lblHora.TabIndex = 6
        Me.lblHora.Text = "Hora"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.lblFecha.Depth = 0
        Me.lblFecha.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lblFecha.Location = New System.Drawing.Point(28, 63)
        Me.lblFecha.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(66, 29)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel12.ForeColor = System.Drawing.SystemColors.Window
        Me.MaterialLabel12.Location = New System.Drawing.Point(24, 7)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(667, 41)
        Me.MaterialLabel12.TabIndex = 0
        Me.MaterialLabel12.Text = "Administración/Control/Registros y Detalles"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel11.Location = New System.Drawing.Point(43, 642)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(78, 24)
        Me.MaterialLabel11.TabIndex = 19
        Me.MaterialLabel11.Text = "◍ Venta  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 673)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(988, 39)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = resources.GetString("Label7.Text")
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel10.Location = New System.Drawing.Point(43, 557)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(95, 24)
        Me.MaterialLabel10.TabIndex = 17
        Me.MaterialLabel10.Text = "◍ Compra  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 586)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1013, 39)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel9.Location = New System.Drawing.Point(43, 473)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(106, 24)
        Me.MaterialLabel9.TabIndex = 15
        Me.MaterialLabel9.Text = "◍ Producto  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 503)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(859, 39)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel8.Location = New System.Drawing.Point(43, 404)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(117, 24)
        Me.MaterialLabel8.TabIndex = 13
        Me.MaterialLabel8.Text = "◍ Proveedor  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(839, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel7.Location = New System.Drawing.Point(43, 342)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(88, 24)
        Me.MaterialLabel7.TabIndex = 11
        Me.MaterialLabel7.Text = "◍ Cliente  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(765, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apartado en dónde se almacenan los datos personales de todas aquellas personas qu" &
    "e adquieren y utilizan nuestros servicios, también conocidos como clientes."
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel6.Location = New System.Drawing.Point(43, 269)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(93, 24)
        Me.MaterialLabel6.TabIndex = 9
        Me.MaterialLabel6.Text = "◍ Usuario  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(875, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Está detalla todos aquellos registros de información de usuarios nuevos y existen" &
    "tes en el negocio. Este apartado ofrece los beneficios de ingreso al programa a " &
    "los Usuarios registrados."
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel5.Location = New System.Drawing.Point(28, 245)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(1142, 17)
        Me.MaterialLabel5.TabIndex = 7
        Me.MaterialLabel5.Text = "Esta herramienta permitirá llevar un control completo y detallado de las entidade" &
    "s disponibles en el MiniMarket, tendrá acceso a estas herramientas en el menú, l" &
    "as cuales algunas serian:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel4.Location = New System.Drawing.Point(27, 212)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(1418, 17)
        Me.MaterialLabel4.TabIndex = 5
        Me.MaterialLabel4.Text = resources.GetString("MaterialLabel4.Text")
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel3.Location = New System.Drawing.Point(28, 184)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(1557, 17)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = resources.GetString("MaterialLabel3.Text")
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.Color.SlateGray
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel2.Location = New System.Drawing.Point(26, 132)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(166, 41)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Bienvenido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrograMarket.My.Resources.Resources.LogoPrograma
        Me.PictureBox1.Location = New System.Drawing.Point(1193, 219)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(393, 378)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FrmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1610, 830)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAcercaDe"
        Me.ShowInTaskbar = False
        Me.Text = "Acerca De"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FiveCodGradientPanel1.ResumeLayout(False)
        Me.FiveCodGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fecha As Timer
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents FiveCodGradientPanel1 As FiveCodMaterialDesign.FiveCodGradientPanel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblHora As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblFecha As MaterialSkin.Controls.MaterialLabel
End Class
