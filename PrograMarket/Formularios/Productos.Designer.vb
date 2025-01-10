<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.cmdEditar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.txtPrecioCompra = New MaterialSkin.Controls.MaterialTextBox()
        Me.cmdLimpiar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdRegistrar = New MaterialSkin.Controls.MaterialButton()
        Me.txtCodigoProducto = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtDescripcion = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbEstadoProducto = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtCodigoBuscar = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtMedidaProducto = New MaterialSkin.Controls.MaterialTextBox()
        Me.cbBuscarPor = New MaterialSkin.Controls.MaterialComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtPrecioVenta = New MaterialSkin.Controls.MaterialTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvProducto = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCategorias = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtStock = New MaterialSkin.Controls.MaterialTextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "azulRecuadro.gif")
        Me.ImageList1.Images.SetKeyName(1, "borrar.png")
        Me.ImageList1.Images.SetKeyName(2, "buscar.png")
        Me.ImageList1.Images.SetKeyName(3, "LIMPIAR COLOR.png")
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSize = False
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialButton1.ImageList = Me.ImageList1
        Me.MaterialButton1.Location = New System.Drawing.Point(1363, 111)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(134, 43)
        Me.MaterialButton1.TabIndex = 88
        Me.MaterialButton1.Text = "Agregar Categoria"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'cmdEditar
        '
        Me.cmdEditar.AutoSize = False
        Me.cmdEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdEditar.Depth = 0
        Me.cmdEditar.HighEmphasis = True
        Me.cmdEditar.Icon = Nothing
        Me.cmdEditar.Location = New System.Drawing.Point(270, 706)
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEditar.Size = New System.Drawing.Size(124, 33)
        Me.cmdEditar.TabIndex = 87
        Me.cmdEditar.Text = "EDITAR"
        Me.cmdEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdEditar.UseAccentColor = False
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.AutoSize = False
        Me.cmdEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdEliminar.Depth = 0
        Me.cmdEliminar.HighEmphasis = True
        Me.cmdEliminar.Icon = Nothing
        Me.cmdEliminar.Location = New System.Drawing.Point(270, 652)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEliminar.Size = New System.Drawing.Size(124, 33)
        Me.cmdEliminar.TabIndex = 86
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdEliminar.UseAccentColor = False
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.AnimateReadOnly = False
        Me.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioCompra.Depth = 0
        Me.txtPrecioCompra.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPrecioCompra.Hint = "Precio Compra (S/.)"
        Me.txtPrecioCompra.LeadingIcon = Nothing
        Me.txtPrecioCompra.Location = New System.Drawing.Point(119, 518)
        Me.txtPrecioCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioCompra.MaxLength = 50
        Me.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPrecioCompra.Multiline = False
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(201, 50)
        Me.txtPrecioCompra.TabIndex = 78
        Me.txtPrecioCompra.Text = ""
        Me.txtPrecioCompra.TrailingIcon = Nothing
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.AutoSize = False
        Me.cmdLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdLimpiar.Depth = 0
        Me.cmdLimpiar.HighEmphasis = True
        Me.cmdLimpiar.Icon = Nothing
        Me.cmdLimpiar.Location = New System.Drawing.Point(120, 706)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdLimpiar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdLimpiar.Size = New System.Drawing.Size(134, 33)
        Me.cmdLimpiar.TabIndex = 85
        Me.cmdLimpiar.Text = "LIMPIAR"
        Me.cmdLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdLimpiar.UseAccentColor = False
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.AutoSize = False
        Me.cmdRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdRegistrar.Depth = 0
        Me.cmdRegistrar.HighEmphasis = True
        Me.cmdRegistrar.Icon = Nothing
        Me.cmdRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRegistrar.ImageList = Me.ImageList1
        Me.cmdRegistrar.Location = New System.Drawing.Point(120, 652)
        Me.cmdRegistrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdRegistrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdRegistrar.Size = New System.Drawing.Size(134, 33)
        Me.cmdRegistrar.TabIndex = 84
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdRegistrar.UseAccentColor = False
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.AnimateReadOnly = False
        Me.txtCodigoProducto.BackColor = System.Drawing.Color.White
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoProducto.Depth = 0
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCodigoProducto.Hint = "Código de Producto"
        Me.txtCodigoProducto.LeadingIcon = Nothing
        Me.txtCodigoProducto.Location = New System.Drawing.Point(119, 168)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoProducto.MaxLength = 50
        Me.txtCodigoProducto.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCodigoProducto.Multiline = False
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(276, 50)
        Me.txtCodigoProducto.TabIndex = 70
        Me.txtCodigoProducto.Text = ""
        Me.txtCodigoProducto.TrailingIcon = Nothing
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AnimateReadOnly = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Depth = 0
        Me.txtDescripcion.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDescripcion.Hint = "Descripción"
        Me.txtDescripcion.LeadingIcon = Nothing
        Me.txtDescripcion.Location = New System.Drawing.Point(119, 232)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDescripcion.Multiline = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(276, 50)
        Me.txtDescripcion.TabIndex = 71
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.TrailingIcon = Nothing
        '
        'cbEstadoProducto
        '
        Me.cbEstadoProducto.AutoResize = False
        Me.cbEstadoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbEstadoProducto.Depth = 0
        Me.cbEstadoProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbEstadoProducto.DropDownHeight = 174
        Me.cbEstadoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoProducto.DropDownWidth = 121
        Me.cbEstadoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbEstadoProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbEstadoProducto.FormattingEnabled = True
        Me.cbEstadoProducto.Hint = "Estado"
        Me.cbEstadoProducto.IntegralHeight = False
        Me.cbEstadoProducto.ItemHeight = 43
        Me.cbEstadoProducto.Items.AddRange(New Object() {"A", "N"})
        Me.cbEstadoProducto.Location = New System.Drawing.Point(119, 374)
        Me.cbEstadoProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEstadoProducto.MaxDropDownItems = 4
        Me.cbEstadoProducto.MouseState = MaterialSkin.MouseState.OUT
        Me.cbEstadoProducto.Name = "cbEstadoProducto"
        Me.cbEstadoProducto.Size = New System.Drawing.Size(277, 49)
        Me.cbEstadoProducto.StartIndex = 0
        Me.cbEstadoProducto.TabIndex = 72
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.White
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdBuscar.ForeColor = System.Drawing.Color.Black
        Me.cmdBuscar.Image = Global.PrograMarket.My.Resources.Resources.buscar1
        Me.cmdBuscar.ImageKey = "(ninguno)"
        Me.cmdBuscar.Location = New System.Drawing.Point(959, 107)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(38, 41)
        Me.cmdBuscar.TabIndex = 83
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtCodigoBuscar
        '
        Me.txtCodigoBuscar.AnimateReadOnly = False
        Me.txtCodigoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoBuscar.Depth = 0
        Me.txtCodigoBuscar.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCodigoBuscar.Hint = "Ingresar campo"
        Me.txtCodigoBuscar.LeadingIcon = Nothing
        Me.txtCodigoBuscar.Location = New System.Drawing.Point(658, 107)
        Me.txtCodigoBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoBuscar.MaxLength = 50
        Me.txtCodigoBuscar.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCodigoBuscar.Multiline = False
        Me.txtCodigoBuscar.Name = "txtCodigoBuscar"
        Me.txtCodigoBuscar.Size = New System.Drawing.Size(279, 50)
        Me.txtCodigoBuscar.TabIndex = 82
        Me.txtCodigoBuscar.Text = ""
        Me.txtCodigoBuscar.TrailingIcon = Nothing
        '
        'txtMedidaProducto
        '
        Me.txtMedidaProducto.AnimateReadOnly = False
        Me.txtMedidaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMedidaProducto.Depth = 0
        Me.txtMedidaProducto.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMedidaProducto.Hint = "Medida del producto"
        Me.txtMedidaProducto.LeadingIcon = Nothing
        Me.txtMedidaProducto.Location = New System.Drawing.Point(119, 304)
        Me.txtMedidaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMedidaProducto.MaxLength = 50
        Me.txtMedidaProducto.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMedidaProducto.Multiline = False
        Me.txtMedidaProducto.Name = "txtMedidaProducto"
        Me.txtMedidaProducto.Size = New System.Drawing.Size(276, 50)
        Me.txtMedidaProducto.TabIndex = 73
        Me.txtMedidaProducto.Text = ""
        Me.txtMedidaProducto.TrailingIcon = Nothing
        '
        'cbBuscarPor
        '
        Me.cbBuscarPor.AutoResize = False
        Me.cbBuscarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbBuscarPor.Depth = 0
        Me.cbBuscarPor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbBuscarPor.DropDownHeight = 174
        Me.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarPor.DropDownWidth = 121
        Me.cbBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbBuscarPor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbBuscarPor.FormattingEnabled = True
        Me.cbBuscarPor.Hint = "Busca por:"
        Me.cbBuscarPor.IntegralHeight = False
        Me.cbBuscarPor.ItemHeight = 43
        Me.cbBuscarPor.Items.AddRange(New Object() {"Codigo", "Descripción"})
        Me.cbBuscarPor.Location = New System.Drawing.Point(500, 105)
        Me.cbBuscarPor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbBuscarPor.MaxDropDownItems = 4
        Me.cbBuscarPor.MouseState = MaterialSkin.MouseState.OUT
        Me.cbBuscarPor.Name = "cbBuscarPor"
        Me.cbBuscarPor.Size = New System.Drawing.Size(126, 49)
        Me.cbBuscarPor.StartIndex = 0
        Me.cbBuscarPor.TabIndex = 81
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(200, 128)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(144, 20)
        Me.dtpFecha.TabIndex = 74
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.AnimateReadOnly = False
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioVenta.Depth = 0
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPrecioVenta.Hint = "Precio Venta (S/.)"
        Me.txtPrecioVenta.LeadingIcon = Nothing
        Me.txtPrecioVenta.Location = New System.Drawing.Point(200, 578)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioVenta.MaxLength = 50
        Me.txtPrecioVenta.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPrecioVenta.Multiline = False
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(194, 50)
        Me.txtPrecioVenta.TabIndex = 79
        Me.txtPrecioVenta.Text = ""
        Me.txtPrecioVenta.TrailingIcon = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lvProducto)
        Me.Panel1.Location = New System.Drawing.Point(439, 177)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 636)
        Me.Panel1.TabIndex = 80
        '
        'lvProducto
        '
        Me.lvProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader5, Me.ColumnHeader8})
        Me.lvProducto.FullRowSelect = True
        Me.lvProducto.GridLines = True
        Me.lvProducto.HideSelection = False
        Me.lvProducto.Location = New System.Drawing.Point(10, 18)
        Me.lvProducto.Name = "lvProducto"
        Me.lvProducto.Size = New System.Drawing.Size(1032, 600)
        Me.lvProducto.TabIndex = 84
        Me.lvProducto.UseCompatibleStateImageBehavior = False
        Me.lvProducto.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CÓDIGO"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DESCRIPCIÓN"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ESTADO"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "STOCK"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PRECIO COMPRA (S/.)"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "PRECIO VENTA (S/.)"
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID CATEGORIA"
        Me.ColumnHeader5.Width = 142
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "FECHA PRODUCTO"
        Me.ColumnHeader8.Width = 143
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(116, 103)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(106, 19)
        Me.MaterialLabel9.TabIndex = 75
        Me.MaterialLabel9.Text = "Fecha Registro"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cboCategorias)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1124, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(220, 80)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categoria "
        '
        'cboCategorias
        '
        Me.cboCategorias.AutoResize = False
        Me.cboCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCategorias.Depth = 0
        Me.cboCategorias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCategorias.DropDownHeight = 174
        Me.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorias.DropDownWidth = 121
        Me.cboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboCategorias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Hint = "ID Categoria"
        Me.cboCategorias.IntegralHeight = False
        Me.cboCategorias.ItemHeight = 43
        Me.cboCategorias.Location = New System.Drawing.Point(4, 20)
        Me.cboCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCategorias.MaxDropDownItems = 4
        Me.cboCategorias.MouseState = MaterialSkin.MouseState.OUT
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(204, 49)
        Me.cboCategorias.StartIndex = 0
        Me.cboCategorias.TabIndex = 69
        '
        'txtStock
        '
        Me.txtStock.AnimateReadOnly = False
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStock.Depth = 0
        Me.txtStock.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStock.Hint = "Stock de producto"
        Me.txtStock.LeadingIcon = Nothing
        Me.txtStock.Location = New System.Drawing.Point(119, 450)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStock.MaxLength = 50
        Me.txtStock.MouseState = MaterialSkin.MouseState.OUT
        Me.txtStock.Multiline = False
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(276, 50)
        Me.txtStock.TabIndex = 77
        Me.txtStock.Text = ""
        Me.txtStock.TrailingIcon = Nothing
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.txtPrecioCompra)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cbEstadoProducto)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtCodigoBuscar)
        Me.Controls.Add(Me.txtMedidaProducto)
        Me.Controls.Add(Me.cbBuscarPor)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStock)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Productos"
        Me.Text = "Mantenimiento De Productos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtPrecioCompra As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cmdLimpiar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdRegistrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtCodigoProducto As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtDescripcion As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbEstadoProducto As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtCodigoBuscar As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtMedidaProducto As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cbBuscarPor As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtPrecioVenta As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvProducto As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCategorias As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtStock As MaterialSkin.Controls.MaterialTextBox
End Class
