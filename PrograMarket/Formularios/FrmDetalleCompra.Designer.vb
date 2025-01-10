<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalleCompra
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
        Me.cmdEditar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdLimpiar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdRegistrar = New MaterialSkin.Controls.MaterialButton()
        Me.txtIdDetalleCompra = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCodProducto = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtPrecioVenta = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtPrecioCompra = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboNComprobanteCompra = New MaterialSkin.Controls.MaterialComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lvDetalleCompra = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEditar
        '
        Me.cmdEditar.AutoSize = False
        Me.cmdEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdEditar.Depth = 0
        Me.cmdEditar.HighEmphasis = True
        Me.cmdEditar.Icon = Nothing
        Me.cmdEditar.Location = New System.Drawing.Point(211, 627)
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEditar.Size = New System.Drawing.Size(124, 33)
        Me.cmdEditar.TabIndex = 82
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
        Me.cmdEliminar.Location = New System.Drawing.Point(211, 573)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEliminar.Size = New System.Drawing.Size(124, 33)
        Me.cmdEliminar.TabIndex = 81
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdEliminar.UseAccentColor = False
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.AutoSize = False
        Me.cmdLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdLimpiar.Depth = 0
        Me.cmdLimpiar.HighEmphasis = True
        Me.cmdLimpiar.Icon = Nothing
        Me.cmdLimpiar.Location = New System.Drawing.Point(61, 627)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdLimpiar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdLimpiar.Size = New System.Drawing.Size(134, 33)
        Me.cmdLimpiar.TabIndex = 80
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
        Me.cmdRegistrar.Location = New System.Drawing.Point(61, 573)
        Me.cmdRegistrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdRegistrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdRegistrar.Size = New System.Drawing.Size(134, 33)
        Me.cmdRegistrar.TabIndex = 79
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdRegistrar.UseAccentColor = False
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'txtIdDetalleCompra
        '
        Me.txtIdDetalleCompra.AnimateReadOnly = False
        Me.txtIdDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdDetalleCompra.Depth = 0
        Me.txtIdDetalleCompra.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtIdDetalleCompra.Hint = "ID Detalle Compra"
        Me.txtIdDetalleCompra.LeadingIcon = Nothing
        Me.txtIdDetalleCompra.Location = New System.Drawing.Point(29, 106)
        Me.txtIdDetalleCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdDetalleCompra.MaxLength = 50
        Me.txtIdDetalleCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.txtIdDetalleCompra.Multiline = False
        Me.txtIdDetalleCompra.Name = "txtIdDetalleCompra"
        Me.txtIdDetalleCompra.Size = New System.Drawing.Size(230, 50)
        Me.txtIdDetalleCompra.TabIndex = 78
        Me.txtIdDetalleCompra.Text = ""
        Me.txtIdDetalleCompra.TrailingIcon = Nothing
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(1434, 128)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(106, 19)
        Me.MaterialLabel9.TabIndex = 74
        Me.MaterialLabel9.Text = "Fecha Registro"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(1124, 126)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(292, 20)
        Me.dtpFecha.TabIndex = 73
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCodProducto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel7)
        Me.GroupBox1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox1.Controls.Add(Me.txtPrecioCompra)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(283, 149)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1278, 108)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Producto"
        '
        'cboCodProducto
        '
        Me.cboCodProducto.AutoResize = False
        Me.cboCodProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCodProducto.Depth = 0
        Me.cboCodProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCodProducto.DropDownHeight = 174
        Me.cboCodProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodProducto.DropDownWidth = 121
        Me.cboCodProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboCodProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboCodProducto.FormattingEnabled = True
        Me.cboCodProducto.IntegralHeight = False
        Me.cboCodProducto.ItemHeight = 43
        Me.cboCodProducto.Location = New System.Drawing.Point(296, 44)
        Me.cboCodProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCodProducto.MaxDropDownItems = 4
        Me.cboCodProducto.MouseState = MaterialSkin.MouseState.OUT
        Me.cboCodProducto.Name = "cboCodProducto"
        Me.cboCodProducto.Size = New System.Drawing.Size(272, 49)
        Me.cboCodProducto.StartIndex = 0
        Me.cboCodProducto.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(572, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "S/."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(737, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "S/."
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.Location = New System.Drawing.Point(928, 25)
        Me.MaterialLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel7.TabIndex = 12
        Me.MaterialLabel7.Text = "Cantidad"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.AnimateReadOnly = False
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioVenta.Depth = 0
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPrecioVenta.LeadingIcon = Nothing
        Me.txtPrecioVenta.Location = New System.Drawing.Point(768, 47)
        Me.txtPrecioVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioVenta.MaxLength = 50
        Me.txtPrecioVenta.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPrecioVenta.Multiline = False
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(116, 50)
        Me.txtPrecioVenta.TabIndex = 11
        Me.txtPrecioVenta.Text = ""
        Me.txtPrecioVenta.TrailingIcon = Nothing
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.Location = New System.Drawing.Point(766, 24)
        Me.MaterialLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(111, 19)
        Me.MaterialLabel6.TabIndex = 10
        Me.MaterialLabel6.Text = "Precio de Venta"
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.AnimateReadOnly = False
        Me.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioCompra.Depth = 0
        Me.txtPrecioCompra.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPrecioCompra.LeadingIcon = Nothing
        Me.txtPrecioCompra.Location = New System.Drawing.Point(603, 45)
        Me.txtPrecioCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioCompra.MaxLength = 50
        Me.txtPrecioCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPrecioCompra.Multiline = False
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(111, 50)
        Me.txtPrecioCompra.TabIndex = 9
        Me.txtPrecioCompra.Text = ""
        Me.txtPrecioCompra.TrailingIcon = Nothing
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(917, 50)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(74, 23)
        Me.txtCantidad.TabIndex = 6
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(600, 22)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(126, 19)
        Me.MaterialLabel4.TabIndex = 5
        Me.MaterialLabel4.Text = "Precio de Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNComprobanteCompra)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 177)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(230, 83)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Compra"
        '
        'cboNComprobanteCompra
        '
        Me.cboNComprobanteCompra.AutoResize = False
        Me.cboNComprobanteCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboNComprobanteCompra.Depth = 0
        Me.cboNComprobanteCompra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboNComprobanteCompra.DropDownHeight = 174
        Me.cboNComprobanteCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNComprobanteCompra.DropDownWidth = 121
        Me.cboNComprobanteCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboNComprobanteCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboNComprobanteCompra.FormattingEnabled = True
        Me.cboNComprobanteCompra.Hint = "Número comprobante"
        Me.cboNComprobanteCompra.IntegralHeight = False
        Me.cboNComprobanteCompra.ItemHeight = 43
        Me.cboNComprobanteCompra.Location = New System.Drawing.Point(4, 31)
        Me.cboNComprobanteCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNComprobanteCompra.MaxDropDownItems = 4
        Me.cboNComprobanteCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.cboNComprobanteCompra.Name = "cboNComprobanteCompra"
        Me.cboNComprobanteCompra.Size = New System.Drawing.Size(221, 49)
        Me.cboNComprobanteCompra.StartIndex = 0
        Me.cboNComprobanteCompra.TabIndex = 47
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lvDetalleCompra)
        Me.Panel5.Location = New System.Drawing.Point(29, 271)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1532, 288)
        Me.Panel5.TabIndex = 76
        '
        'lvDetalleCompra
        '
        Me.lvDetalleCompra.AutoSizeTable = False
        Me.lvDetalleCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvDetalleCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvDetalleCompra.Depth = 0
        Me.lvDetalleCompra.ForeColor = System.Drawing.Color.Gray
        Me.lvDetalleCompra.FullRowSelect = True
        Me.lvDetalleCompra.HideSelection = False
        Me.lvDetalleCompra.Location = New System.Drawing.Point(7, 7)
        Me.lvDetalleCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.lvDetalleCompra.MinimumSize = New System.Drawing.Size(150, 81)
        Me.lvDetalleCompra.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvDetalleCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.lvDetalleCompra.Name = "lvDetalleCompra"
        Me.lvDetalleCompra.OwnerDraw = True
        Me.lvDetalleCompra.Size = New System.Drawing.Size(1504, 271)
        Me.lvDetalleCompra.TabIndex = 39
        Me.lvDetalleCompra.UseCompatibleStateImageBehavior = False
        Me.lvDetalleCompra.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID DETALLE COMPRA "
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CODIGO COMPRA"
        Me.ColumnHeader7.Width = 167
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "N° COMPROBANTE"
        Me.ColumnHeader2.Width = 159
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRECIO COMPRA (S/.)"
        Me.ColumnHeader3.Width = 171
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CANTIDAD"
        Me.ColumnHeader4.Width = 186
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "SUB TOTAL POR PRODUCTO"
        Me.ColumnHeader5.Width = 189
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "FECHA REGISTRO"
        Me.ColumnHeader6.Width = 233
        '
        'FrmDetalleCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.txtIdDetalleCompra)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel5)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmDetalleCompra"
        Me.Text = "Detalle De Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdLimpiar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdRegistrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtIdDetalleCompra As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboCodProducto As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtPrecioVenta As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtPrecioCompra As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCantidad As NumericUpDown
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboNComprobanteCompra As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lvDetalleCompra As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
