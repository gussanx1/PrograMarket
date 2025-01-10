<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompra
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdLimpiar = New MaterialSkin.Controls.MaterialButton()
        Me.cboTipoComprobante = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdEditar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdRegistrar = New MaterialSkin.Controls.MaterialButton()
        Me.cmdEliminar = New MaterialSkin.Controls.MaterialButton()
        Me.txtNComprobante = New MaterialSkin.Controls.MaterialTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboUsuario = New MaterialSkin.Controls.MaterialComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvCompra = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboProveedor = New MaterialSkin.Controls.MaterialComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.AutoSize = False
        Me.cmdLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdLimpiar.Depth = 0
        Me.cmdLimpiar.HighEmphasis = True
        Me.cmdLimpiar.Icon = Nothing
        Me.cmdLimpiar.Location = New System.Drawing.Point(134, 702)
        Me.cmdLimpiar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdLimpiar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdLimpiar.Size = New System.Drawing.Size(150, 29)
        Me.cmdLimpiar.TabIndex = 39
        Me.cmdLimpiar.Text = "LIMPIAR"
        Me.cmdLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdLimpiar.UseAccentColor = False
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.AutoResize = False
        Me.cboTipoComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTipoComprobante.Depth = 0
        Me.cboTipoComprobante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboTipoComprobante.DropDownHeight = 174
        Me.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoComprobante.DropDownWidth = 121
        Me.cboTipoComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboTipoComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Hint = "Tipo de Comprobante"
        Me.cboTipoComprobante.IntegralHeight = False
        Me.cboTipoComprobante.ItemHeight = 43
        Me.cboTipoComprobante.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cboTipoComprobante.Location = New System.Drawing.Point(134, 196)
        Me.cboTipoComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoComprobante.MaxDropDownItems = 4
        Me.cboTipoComprobante.MouseState = MaterialSkin.MouseState.OUT
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(216, 49)
        Me.cboTipoComprobante.StartIndex = 0
        Me.cboTipoComprobante.TabIndex = 38
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.Location = New System.Drawing.Point(80, 124)
        Me.MaterialLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(106, 19)
        Me.MaterialLabel9.TabIndex = 37
        Me.MaterialLabel9.Text = "Fecha Registro"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(136, 153)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(215, 20)
        Me.dtpFecha.TabIndex = 36
        '
        'cmdEditar
        '
        Me.cmdEditar.AutoSize = False
        Me.cmdEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdEditar.Depth = 0
        Me.cmdEditar.HighEmphasis = True
        Me.cmdEditar.Icon = Nothing
        Me.cmdEditar.Location = New System.Drawing.Point(134, 592)
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEditar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEditar.Size = New System.Drawing.Size(150, 33)
        Me.cmdEditar.TabIndex = 35
        Me.cmdEditar.Text = "EDITAR"
        Me.cmdEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdEditar.UseAccentColor = False
        Me.cmdEditar.UseVisualStyleBackColor = True
        '
        'cmdRegistrar
        '
        Me.cmdRegistrar.AutoSize = False
        Me.cmdRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdRegistrar.Depth = 0
        Me.cmdRegistrar.HighEmphasis = True
        Me.cmdRegistrar.Icon = Nothing
        Me.cmdRegistrar.ImageKey = "anadir.png"
        Me.cmdRegistrar.Location = New System.Drawing.Point(134, 537)
        Me.cmdRegistrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdRegistrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdRegistrar.Name = "cmdRegistrar"
        Me.cmdRegistrar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdRegistrar.Size = New System.Drawing.Size(150, 37)
        Me.cmdRegistrar.TabIndex = 34
        Me.cmdRegistrar.Text = "REGISTRAR"
        Me.cmdRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdRegistrar.UseAccentColor = False
        Me.cmdRegistrar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.AutoSize = False
        Me.cmdEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.cmdEliminar.Depth = 0
        Me.cmdEliminar.HighEmphasis = True
        Me.cmdEliminar.Icon = Nothing
        Me.cmdEliminar.Location = New System.Drawing.Point(134, 647)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cmdEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.cmdEliminar.Size = New System.Drawing.Size(150, 34)
        Me.cmdEliminar.TabIndex = 33
        Me.cmdEliminar.Text = "ELIMINAR"
        Me.cmdEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.cmdEliminar.UseAccentColor = False
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'txtNComprobante
        '
        Me.txtNComprobante.AnimateReadOnly = False
        Me.txtNComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNComprobante.Depth = 0
        Me.txtNComprobante.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNComprobante.Hint = "Número de Comprobante"
        Me.txtNComprobante.LeadingIcon = Nothing
        Me.txtNComprobante.Location = New System.Drawing.Point(134, 258)
        Me.txtNComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNComprobante.MaxLength = 50
        Me.txtNComprobante.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNComprobante.Multiline = False
        Me.txtNComprobante.Name = "txtNComprobante"
        Me.txtNComprobante.Size = New System.Drawing.Size(215, 50)
        Me.txtNComprobante.TabIndex = 31
        Me.txtNComprobante.Text = ""
        Me.txtNComprobante.TrailingIcon = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cboUsuario)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(66, 319)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(284, 80)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Usuario"
        '
        'cboUsuario
        '
        Me.cboUsuario.AutoResize = False
        Me.cboUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboUsuario.Depth = 0
        Me.cboUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboUsuario.DropDownHeight = 174
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.DropDownWidth = 121
        Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Hint = "DNI"
        Me.cboUsuario.IntegralHeight = False
        Me.cboUsuario.ItemHeight = 43
        Me.cboUsuario.Location = New System.Drawing.Point(4, 28)
        Me.cboUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUsuario.MaxDropDownItems = 4
        Me.cboUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(276, 49)
        Me.cboUsuario.StartIndex = 0
        Me.cboUsuario.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lvCompra)
        Me.Panel1.Location = New System.Drawing.Point(384, 178)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 470)
        Me.Panel1.TabIndex = 32
        '
        'lvCompra
        '
        Me.lvCompra.AutoSizeTable = False
        Me.lvCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCompra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader7})
        Me.lvCompra.Depth = 0
        Me.lvCompra.ForeColor = System.Drawing.Color.Black
        Me.lvCompra.FullRowSelect = True
        Me.lvCompra.HideSelection = False
        Me.lvCompra.Location = New System.Drawing.Point(13, 18)
        Me.lvCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.lvCompra.MinimumSize = New System.Drawing.Size(150, 81)
        Me.lvCompra.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvCompra.MouseState = MaterialSkin.MouseState.OUT
        Me.lvCompra.Name = "lvCompra"
        Me.lvCompra.OwnerDraw = True
        Me.lvCompra.Size = New System.Drawing.Size(1066, 444)
        Me.lvCompra.TabIndex = 16
        Me.lvCompra.UseCompatibleStateImageBehavior = False
        Me.lvCompra.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "TIPO COMPROBANTE"
        Me.ColumnHeader1.Width = 182
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "N° COMPROBANTE"
        Me.ColumnHeader2.Width = 172
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI USUARIO"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DNI PROVEEDOR"
        Me.ColumnHeader8.Width = 160
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "MONTO TOTAL COMPRA"
        Me.ColumnHeader9.Width = 199
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "FECHA REGISTRO"
        Me.ColumnHeader7.Width = 171
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoResize = False
        Me.cboProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProveedor.Depth = 0
        Me.cboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboProveedor.DropDownHeight = 174
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.DropDownWidth = 121
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Hint = "DNI"
        Me.cboProveedor.IntegralHeight = False
        Me.cboProveedor.ItemHeight = 43
        Me.cboProveedor.Location = New System.Drawing.Point(4, 31)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProveedor.MaxDropDownItems = 4
        Me.cboProveedor.MouseState = MaterialSkin.MouseState.OUT
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(276, 49)
        Me.cboProveedor.StartIndex = 0
        Me.cboProveedor.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cboProveedor)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(66, 425)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(284, 83)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Proveedor"
        '
        'FormCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1625, 924)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cboTipoComprobante)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdRegistrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.txtNComprobante)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCompra"
        Me.Text = "Registrar Compra"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLimpiar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cboTipoComprobante As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmdEditar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdRegistrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmdEliminar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtNComprobante As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboUsuario As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvCompra As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents cboProveedor As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
