<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroVentas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDocumentoCliente = New MaterialSkin.Controls.MaterialComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCodigo = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        Me.btnCancelar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEliminar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEditar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnGuardarVenta = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnAgregar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        Me.cboTipoComprobante = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtApellidoPaterno = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNombres = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtApellidoMaterno = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBox3 = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtPago = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtVuelto = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtMontoTotal = New MaterialSkin.Controls.MaterialTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.cboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.MaterialTextBox1)
        Me.GroupBox1.Controls.Add(Me.btnGuardarVenta)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 143)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.txtApellidoMaterno)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.txtApellidoPaterno)
        Me.GroupBox2.Controls.Add(Me.cboDocumentoCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(525, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 143)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información Cliente"
        '
        'cboDocumentoCliente
        '
        Me.cboDocumentoCliente.AutoResize = False
        Me.cboDocumentoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboDocumentoCliente.Depth = 0
        Me.cboDocumentoCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboDocumentoCliente.DropDownHeight = 174
        Me.cboDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumentoCliente.DropDownWidth = 121
        Me.cboDocumentoCliente.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboDocumentoCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboDocumentoCliente.FormattingEnabled = True
        Me.cboDocumentoCliente.Hint = "DNI"
        Me.cboDocumentoCliente.IntegralHeight = False
        Me.cboDocumentoCliente.ItemHeight = 43
        Me.cboDocumentoCliente.Location = New System.Drawing.Point(6, 19)
        Me.cboDocumentoCliente.MaxDropDownItems = 4
        Me.cboDocumentoCliente.MouseState = MaterialSkin.MouseState.OUT
        Me.cboDocumentoCliente.Name = "cboDocumentoCliente"
        Me.cboDocumentoCliente.Size = New System.Drawing.Size(296, 49)
        Me.cboDocumentoCliente.StartIndex = 0
        Me.cboDocumentoCliente.TabIndex = 86
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.MaterialTextBox3)
        Me.GroupBox3.Controls.Add(Me.MaterialTextBox2)
        Me.GroupBox3.Controls.Add(Me.cboCodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(1158, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(427, 143)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Informacion  de Producto"
        '
        'cboCodigo
        '
        Me.cboCodigo.AutoResize = False
        Me.cboCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboCodigo.Depth = 0
        Me.cboCodigo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboCodigo.DropDownHeight = 174
        Me.cboCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodigo.DropDownWidth = 121
        Me.cboCodigo.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboCodigo.FormattingEnabled = True
        Me.cboCodigo.Hint = "Codigo"
        Me.cboCodigo.IntegralHeight = False
        Me.cboCodigo.ItemHeight = 43
        Me.cboCodigo.Location = New System.Drawing.Point(12, 20)
        Me.cboCodigo.MaxDropDownItems = 4
        Me.cboCodigo.MouseState = MaterialSkin.MouseState.OUT
        Me.cboCodigo.Name = "cboCodigo"
        Me.cboCodigo.Size = New System.Drawing.Size(177, 49)
        Me.cboCodigo.StartIndex = 0
        Me.cboCodigo.TabIndex = 87
        '
        'MaterialListView1
        '
        Me.MaterialListView1.AutoSizeTable = False
        Me.MaterialListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialListView1.Depth = 0
        Me.MaterialListView1.FullRowSelect = True
        Me.MaterialListView1.HideSelection = False
        Me.MaterialListView1.Location = New System.Drawing.Point(23, 318)
        Me.MaterialListView1.MinimumSize = New System.Drawing.Size(200, 100)
        Me.MaterialListView1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialListView1.Name = "MaterialListView1"
        Me.MaterialListView1.OwnerDraw = True
        Me.MaterialListView1.Size = New System.Drawing.Size(1579, 419)
        Me.MaterialListView1.TabIndex = 94
        Me.MaterialListView1.UseCompatibleStateImageBehavior = False
        Me.MaterialListView1.View = System.Windows.Forms.View.Details
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BGColor = "#d1e5ff"
        Me.btnCancelar.FontColor = "#000000"
        Me.btnCancelar.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.btnCancelar.Location = New System.Drawing.Point(1459, 757)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 41)
        Me.btnCancelar.TabIndex = 99
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BGColor = "#415EFF"
        Me.btnEliminar.FontColor = "#ffffff"
        Me.btnEliminar.ImageButton = Global.PrograMarket.My.Resources.Resources.borrar
        Me.btnEliminar.Location = New System.Drawing.Point(970, 256)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(184, 41)
        Me.btnEliminar.TabIndex = 98
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BGColor = "#ffffff"
        Me.btnEditar.FontColor = "#415eff"
        Me.btnEditar.ImageButton = Global.PrograMarket.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(733, 256)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(184, 41)
        Me.btnEditar.TabIndex = 97
        Me.btnEditar.Text = "EDITAR"
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarVenta.BGColor = "#415EFF"
        Me.btnGuardarVenta.FontColor = "#ffffff"
        Me.btnGuardarVenta.ImageButton = Global.PrograMarket.My.Resources.Resources.anadir
        Me.btnGuardarVenta.Location = New System.Drawing.Point(8, 82)
        Me.btnGuardarVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Size = New System.Drawing.Size(184, 41)
        Me.btnGuardarVenta.TabIndex = 96
        Me.btnGuardarVenta.Text = "         AGREGAR"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BGColor = "#415EFF"
        Me.btnAgregar.FontColor = "#ffffff"
        Me.btnAgregar.ImageButton = Global.PrograMarket.My.Resources.Resources.anadir
        Me.btnAgregar.Location = New System.Drawing.Point(510, 256)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(175, 41)
        Me.btnAgregar.TabIndex = 100
        Me.btnAgregar.Text = "         AGREGAR"
        '
        'MaterialTextBox1
        '
        Me.MaterialTextBox1.AnimateReadOnly = False
        Me.MaterialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox1.Depth = 0
        Me.MaterialTextBox1.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox1.Hint = "Numero Comprobante"
        Me.MaterialTextBox1.LeadingIcon = Nothing
        Me.MaterialTextBox1.Location = New System.Drawing.Point(6, 19)
        Me.MaterialTextBox1.MaxLength = 50
        Me.MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox1.Multiline = False
        Me.MaterialTextBox1.Name = "MaterialTextBox1"
        Me.MaterialTextBox1.Size = New System.Drawing.Size(415, 50)
        Me.MaterialTextBox1.TabIndex = 101
        Me.MaterialTextBox1.Text = ""
        Me.MaterialTextBox1.TrailingIcon = Nothing
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
        Me.cboTipoComprobante.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboTipoComprobante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Hint = "Tipo de Comprobante"
        Me.cboTipoComprobante.IntegralHeight = False
        Me.cboTipoComprobante.ItemHeight = 43
        Me.cboTipoComprobante.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cboTipoComprobante.Location = New System.Drawing.Point(200, 78)
        Me.cboTipoComprobante.MaxDropDownItems = 4
        Me.cboTipoComprobante.MouseState = MaterialSkin.MouseState.OUT
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(221, 49)
        Me.cboTipoComprobante.StartIndex = 0
        Me.cboTipoComprobante.TabIndex = 102
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.AnimateReadOnly = False
        Me.txtApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidoPaterno.Depth = 0
        Me.txtApellidoPaterno.Enabled = False
        Me.txtApellidoPaterno.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtApellidoPaterno.Hint = "Apellido Paterno"
        Me.txtApellidoPaterno.LeadingIcon = Nothing
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(6, 77)
        Me.txtApellidoPaterno.MaxLength = 50
        Me.txtApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoPaterno.Multiline = False
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(296, 50)
        Me.txtApellidoPaterno.TabIndex = 87
        Me.txtApellidoPaterno.Text = ""
        Me.txtApellidoPaterno.TrailingIcon = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.AnimateReadOnly = False
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombres.Depth = 0
        Me.txtNombres.Enabled = False
        Me.txtNombres.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNombres.Hint = "Nombres"
        Me.txtNombres.LeadingIcon = Nothing
        Me.txtNombres.Location = New System.Drawing.Point(308, 19)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNombres.Multiline = False
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(281, 50)
        Me.txtNombres.TabIndex = 88
        Me.txtNombres.Text = ""
        Me.txtNombres.TrailingIcon = Nothing
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.AnimateReadOnly = False
        Me.txtApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidoMaterno.Depth = 0
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoMaterno.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtApellidoMaterno.Hint = "Apellido Materno"
        Me.txtApellidoMaterno.LeadingIcon = Nothing
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(308, 78)
        Me.txtApellidoMaterno.MaxLength = 50
        Me.txtApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoMaterno.Multiline = False
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(281, 50)
        Me.txtApellidoMaterno.TabIndex = 89
        Me.txtApellidoMaterno.Text = ""
        Me.txtApellidoMaterno.TrailingIcon = Nothing
        '
        'MaterialTextBox2
        '
        Me.MaterialTextBox2.AnimateReadOnly = False
        Me.MaterialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox2.Depth = 0
        Me.MaterialTextBox2.Enabled = False
        Me.MaterialTextBox2.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox2.Hint = "Precio"
        Me.MaterialTextBox2.LeadingIcon = Nothing
        Me.MaterialTextBox2.Location = New System.Drawing.Point(195, 20)
        Me.MaterialTextBox2.MaxLength = 50
        Me.MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox2.Multiline = False
        Me.MaterialTextBox2.Name = "MaterialTextBox2"
        Me.MaterialTextBox2.Size = New System.Drawing.Size(226, 50)
        Me.MaterialTextBox2.TabIndex = 88
        Me.MaterialTextBox2.Text = ""
        Me.MaterialTextBox2.TrailingIcon = Nothing
        '
        'MaterialTextBox3
        '
        Me.MaterialTextBox3.AnimateReadOnly = False
        Me.MaterialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBox3.Depth = 0
        Me.MaterialTextBox3.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox3.Hint = "Cantidad"
        Me.MaterialTextBox3.LeadingIcon = Nothing
        Me.MaterialTextBox3.Location = New System.Drawing.Point(85, 79)
        Me.MaterialTextBox3.MaxLength = 50
        Me.MaterialTextBox3.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox3.Multiline = False
        Me.MaterialTextBox3.Name = "MaterialTextBox3"
        Me.MaterialTextBox3.Size = New System.Drawing.Size(265, 50)
        Me.MaterialTextBox3.TabIndex = 89
        Me.MaterialTextBox3.Text = ""
        Me.MaterialTextBox3.TrailingIcon = Nothing
        '
        'txtPago
        '
        Me.txtPago.AnimateReadOnly = False
        Me.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPago.Depth = 0
        Me.txtPago.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPago.Hint = "Pago Con: "
        Me.txtPago.LeadingIcon = Nothing
        Me.txtPago.Location = New System.Drawing.Point(882, 757)
        Me.txtPago.MaxLength = 50
        Me.txtPago.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPago.Multiline = False
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(272, 50)
        Me.txtPago.TabIndex = 101
        Me.txtPago.Text = ""
        Me.txtPago.TrailingIcon = Nothing
        '
        'txtVuelto
        '
        Me.txtVuelto.AnimateReadOnly = False
        Me.txtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVuelto.Depth = 0
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtVuelto.Hint = "Vuelto De:"
        Me.txtVuelto.LeadingIcon = Nothing
        Me.txtVuelto.Location = New System.Drawing.Point(1170, 757)
        Me.txtVuelto.MaxLength = 50
        Me.txtVuelto.MouseState = MaterialSkin.MouseState.OUT
        Me.txtVuelto.Multiline = False
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.Size = New System.Drawing.Size(272, 50)
        Me.txtVuelto.TabIndex = 102
        Me.txtVuelto.Text = ""
        Me.txtVuelto.TrailingIcon = Nothing
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.AnimateReadOnly = False
        Me.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoTotal.Depth = 0
        Me.txtMontoTotal.Enabled = False
        Me.txtMontoTotal.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMontoTotal.Hint = "Monto a Pagar"
        Me.txtMontoTotal.LeadingIcon = Nothing
        Me.txtMontoTotal.Location = New System.Drawing.Point(1353, 256)
        Me.txtMontoTotal.MaxLength = 50
        Me.txtMontoTotal.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMontoTotal.Multiline = False
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(226, 50)
        Me.txtMontoTotal.TabIndex = 103
        Me.txtMontoTotal.Text = ""
        Me.txtMontoTotal.TrailingIcon = Nothing
        '
        'RegistroVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.txtMontoTotal)
        Me.Controls.Add(Me.txtVuelto)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.MaterialListView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RegistroVentas"
        Me.Text = "PrograMarket - Mantenimiento De Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboDocumentoCliente As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cboCodigo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents btnCancelar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEliminar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEditar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnGuardarVenta As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnAgregar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cboTipoComprobante As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtApellidoMaterno As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNombres As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtApellidoPaterno As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox3 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPago As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtVuelto As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtMontoTotal As MaterialSkin.Controls.MaterialTextBox
End Class
