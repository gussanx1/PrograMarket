<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MINIMARKETDataSet = New PrograMarket.MINIMARKETDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnVer = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEliminar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEditar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnGuardar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.lvClientes = New MaterialSkin.Controls.MaterialListView()
        Me.xd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboEstado = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtTelefono = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCorreo = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtApellidoM = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtApellidoP = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNombres = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.txtDocumento = New MaterialSkin.Controls.MaterialTextBox()
        Me.ClienteTableAdapter = New PrograMarket.MINIMARKETDataSetTableAdapters.ClienteTableAdapter()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.MINIMARKETDataSet
        '
        'MINIMARKETDataSet
        '
        Me.MINIMARKETDataSet.DataSetName = "MINIMARKETDataSet"
        Me.MINIMARKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnVer)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lvClientes)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.txtApellidoM)
        Me.Panel1.Controls.Add(Me.txtApellidoP)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Location = New System.Drawing.Point(-3, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1655, 776)
        Me.Panel1.TabIndex = 68
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BGColor = "#d1e5ff"
        Me.btnCancelar.FontColor = "#000000"
        Me.btnCancelar.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.btnCancelar.Location = New System.Drawing.Point(1460, 716)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 41)
        Me.btnCancelar.TabIndex = 95
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.BGColor = "#415EFF"
        Me.btnVer.FontColor = "#ffffff"
        Me.btnVer.ImageButton = Global.PrograMarket.My.Resources.Resources.ver
        Me.btnVer.Location = New System.Drawing.Point(1274, 716)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(180, 41)
        Me.btnVer.TabIndex = 94
        Me.btnVer.Text = "Ver Eliminados"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BGColor = "#415EFF"
        Me.btnEliminar.FontColor = "#ffffff"
        Me.btnEliminar.ImageButton = Global.PrograMarket.My.Resources.Resources.borrar
        Me.btnEliminar.Location = New System.Drawing.Point(69, 646)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(240, 41)
        Me.btnEliminar.TabIndex = 93
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BGColor = "#ffffff"
        Me.btnEditar.FontColor = "#415eff"
        Me.btnEditar.ImageButton = Global.PrograMarket.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(69, 585)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(240, 41)
        Me.btnEditar.TabIndex = 92
        Me.btnEditar.Text = "EDITAR"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BGColor = "#415EFF"
        Me.btnGuardar.FontColor = "#ffffff"
        Me.btnGuardar.ImageButton = Global.PrograMarket.My.Resources.Resources.anadir
        Me.btnGuardar.Location = New System.Drawing.Point(69, 525)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 41)
        Me.btnGuardar.TabIndex = 88
        Me.btnGuardar.Text = "AGREGAR"
        '
        'lvClientes
        '
        Me.lvClientes.AutoSizeTable = False
        Me.lvClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xd, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvClientes.Depth = 0
        Me.lvClientes.FullRowSelect = True
        Me.lvClientes.HideSelection = False
        Me.lvClientes.Location = New System.Drawing.Point(358, 27)
        Me.lvClientes.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvClientes.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvClientes.MouseState = MaterialSkin.MouseState.OUT
        Me.lvClientes.Name = "lvClientes"
        Me.lvClientes.OwnerDraw = True
        Me.lvClientes.Size = New System.Drawing.Size(1245, 677)
        Me.lvClientes.TabIndex = 87
        Me.lvClientes.UseCompatibleStateImageBehavior = False
        Me.lvClientes.View = System.Windows.Forms.View.Details
        '
        'xd
        '
        Me.xd.Text = "DNI"
        Me.xd.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombres"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apellido Paterno"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido Materno"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Correo"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telefono"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 160
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Estado"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Fecha Registro"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 180
        '
        'cboEstado
        '
        Me.cboEstado.AutoResize = False
        Me.cboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboEstado.Depth = 0
        Me.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboEstado.DropDownHeight = 174
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 121
        Me.cboEstado.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Hint = "Estado"
        Me.cboEstado.IntegralHeight = False
        Me.cboEstado.ItemHeight = 43
        Me.cboEstado.Items.AddRange(New Object() {"A", "N"})
        Me.cboEstado.Location = New System.Drawing.Point(42, 431)
        Me.cboEstado.MaxDropDownItems = 4
        Me.cboEstado.MouseState = MaterialSkin.MouseState.OUT
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(293, 49)
        Me.cboEstado.StartIndex = 0
        Me.cboEstado.TabIndex = 83
        '
        'txtTelefono
        '
        Me.txtTelefono.AnimateReadOnly = False
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Depth = 0
        Me.txtTelefono.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtTelefono.Hint = "Telefono"
        Me.txtTelefono.LeadingIcon = Nothing
        Me.txtTelefono.Location = New System.Drawing.Point(42, 367)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTelefono.Multiline = False
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(293, 50)
        Me.txtTelefono.TabIndex = 82
        Me.txtTelefono.Text = ""
        Me.txtTelefono.TrailingIcon = Nothing
        '
        'txtCorreo
        '
        Me.txtCorreo.AnimateReadOnly = False
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Depth = 0
        Me.txtCorreo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCorreo.Hint = "Correo Electronico"
        Me.txtCorreo.LeadingIcon = Nothing
        Me.txtCorreo.Location = New System.Drawing.Point(42, 303)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCorreo.Multiline = False
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(293, 50)
        Me.txtCorreo.TabIndex = 81
        Me.txtCorreo.Text = ""
        Me.txtCorreo.TrailingIcon = Nothing
        '
        'txtApellidoM
        '
        Me.txtApellidoM.AnimateReadOnly = False
        Me.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidoM.Depth = 0
        Me.txtApellidoM.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtApellidoM.Hint = "Apellido Materno"
        Me.txtApellidoM.LeadingIcon = Nothing
        Me.txtApellidoM.Location = New System.Drawing.Point(42, 239)
        Me.txtApellidoM.MaxLength = 50
        Me.txtApellidoM.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoM.Multiline = False
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(293, 50)
        Me.txtApellidoM.TabIndex = 80
        Me.txtApellidoM.Text = ""
        Me.txtApellidoM.TrailingIcon = Nothing
        '
        'txtApellidoP
        '
        Me.txtApellidoP.AnimateReadOnly = False
        Me.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApellidoP.Depth = 0
        Me.txtApellidoP.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtApellidoP.Hint = "Apellido Paterno"
        Me.txtApellidoP.LeadingIcon = Nothing
        Me.txtApellidoP.Location = New System.Drawing.Point(42, 175)
        Me.txtApellidoP.MaxLength = 50
        Me.txtApellidoP.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoP.Multiline = False
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(293, 50)
        Me.txtApellidoP.TabIndex = 79
        Me.txtApellidoP.Text = ""
        Me.txtApellidoP.TrailingIcon = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.AllowPromptAsInput = True
        Me.txtNombres.AnimateReadOnly = False
        Me.txtNombres.AsciiOnly = False
        Me.txtNombres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtNombres.BeepOnError = False
        Me.txtNombres.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtNombres.Depth = 0
        Me.txtNombres.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNombres.HidePromptOnLeave = False
        Me.txtNombres.HideSelection = True
        Me.txtNombres.Hint = "Nombres"
        Me.txtNombres.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.txtNombres.LeadingIcon = Nothing
        Me.txtNombres.Location = New System.Drawing.Point(42, 113)
        Me.txtNombres.Mask = ""
        Me.txtNombres.MaxLength = 32767
        Me.txtNombres.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombres.PrefixSuffixText = Nothing
        Me.txtNombres.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtNombres.ReadOnly = False
        Me.txtNombres.RejectInputOnFirstFailure = False
        Me.txtNombres.ResetOnPrompt = True
        Me.txtNombres.ResetOnSpace = True
        Me.txtNombres.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNombres.SelectedText = ""
        Me.txtNombres.SelectionLength = 0
        Me.txtNombres.SelectionStart = 0
        Me.txtNombres.ShortcutsEnabled = True
        Me.txtNombres.Size = New System.Drawing.Size(293, 48)
        Me.txtNombres.SkipLiterals = True
        Me.txtNombres.TabIndex = 78
        Me.txtNombres.TabStop = False
        Me.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNombres.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtNombres.TrailingIcon = Nothing
        Me.txtNombres.UseSystemPasswordChar = False
        Me.txtNombres.ValidatingType = Nothing
        '
        'txtDocumento
        '
        Me.txtDocumento.AnimateReadOnly = False
        Me.txtDocumento.BackColor = System.Drawing.Color.White
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Depth = 0
        Me.txtDocumento.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDocumento.Hint = "Documento Identidad"
        Me.txtDocumento.LeadingIcon = Nothing
        Me.txtDocumento.Location = New System.Drawing.Point(42, 49)
        Me.txtDocumento.MaxLength = 50
        Me.txtDocumento.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDocumento.Multiline = False
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(293, 50)
        Me.txtDocumento.TabIndex = 77
        Me.txtDocumento.Text = ""
        Me.txtDocumento.TrailingIcon = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Clientes"
        Me.Text = "Detalles de Clientes"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MINIMARKETDataSet As MINIMARKETDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As MINIMARKETDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents txtDocumento As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNombres As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents cboEstado As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtTelefono As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCorreo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtApellidoM As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtApellidoP As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents lvClientes As MaterialSkin.Controls.MaterialListView
    Friend WithEvents xd As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnGuardar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEditar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEliminar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnVer As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnCancelar As FiveCodMaterialDesign.FiveCodImageButton
End Class
