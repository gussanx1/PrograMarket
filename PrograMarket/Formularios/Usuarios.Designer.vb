<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnVer = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEliminar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEditar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnGuardar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.lvUsuarios = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboFuncion = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnMostrar = New FiveCodMaterialDesign.FiveCodFlatButton()
        Me.cboEstado = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtClave = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCorreo = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtApellidoM = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtApellidoP = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtNombres = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtDocumento = New MaterialSkin.Controls.MaterialTextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MINIMARKETDataSet = New PrograMarket.MINIMARKETDataSet()
        Me.UsuarioTableAdapter = New PrograMarket.MINIMARKETDataSetTableAdapters.UsuarioTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnVer)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.lvUsuarios)
        Me.Panel1.Controls.Add(Me.cboFuncion)
        Me.Panel1.Controls.Add(Me.btnMostrar)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Controls.Add(Me.txtCorreo)
        Me.Panel1.Controls.Add(Me.txtApellidoM)
        Me.Panel1.Controls.Add(Me.txtApellidoP)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Location = New System.Drawing.Point(-1, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1609, 758)
        Me.Panel1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BGColor = "#d1e5ff"
        Me.btnCancelar.FontColor = "#000000"
        Me.btnCancelar.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.btnCancelar.Location = New System.Drawing.Point(1433, 695)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 41)
        Me.btnCancelar.TabIndex = 100
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.BGColor = "#415EFF"
        Me.btnVer.FontColor = "#ffffff"
        Me.btnVer.ImageButton = Global.PrograMarket.My.Resources.Resources.ver
        Me.btnVer.Location = New System.Drawing.Point(1247, 695)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(180, 41)
        Me.btnVer.TabIndex = 99
        Me.btnVer.Text = "Ver Eliminados"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BGColor = "#415EFF"
        Me.btnEliminar.FontColor = "#ffffff"
        Me.btnEliminar.ImageButton = Global.PrograMarket.My.Resources.Resources.borrar
        Me.btnEliminar.Location = New System.Drawing.Point(87, 668)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(240, 41)
        Me.btnEliminar.TabIndex = 98
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BGColor = "#ffffff"
        Me.btnEditar.FontColor = "#415eff"
        Me.btnEditar.ImageButton = Global.PrograMarket.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(87, 607)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(240, 41)
        Me.btnEditar.TabIndex = 97
        Me.btnEditar.Text = "EDITAR"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BGColor = "#415EFF"
        Me.btnGuardar.FontColor = "#ffffff"
        Me.btnGuardar.ImageButton = Global.PrograMarket.My.Resources.Resources.anadir
        Me.btnGuardar.Location = New System.Drawing.Point(87, 547)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 41)
        Me.btnGuardar.TabIndex = 96
        Me.btnGuardar.Text = "AGREGAR"
        '
        'lvUsuarios
        '
        Me.lvUsuarios.AutoSizeTable = False
        Me.lvUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvUsuarios.Depth = 0
        Me.lvUsuarios.FullRowSelect = True
        Me.lvUsuarios.HideSelection = False
        Me.lvUsuarios.Location = New System.Drawing.Point(410, 13)
        Me.lvUsuarios.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvUsuarios.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvUsuarios.MouseState = MaterialSkin.MouseState.OUT
        Me.lvUsuarios.Name = "lvUsuarios"
        Me.lvUsuarios.OwnerDraw = True
        Me.lvUsuarios.Size = New System.Drawing.Size(1166, 676)
        Me.lvUsuarios.TabIndex = 82
        Me.lvUsuarios.UseCompatibleStateImageBehavior = False
        Me.lvUsuarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DNI"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombres"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido P."
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Apellido M."
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Correo"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contraseña"
        Me.ColumnHeader6.Width = 160
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Funcion"
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Estado"
        Me.ColumnHeader8.Width = 85
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fecha"
        Me.ColumnHeader9.Width = 160
        '
        'cboFuncion
        '
        Me.cboFuncion.AutoResize = False
        Me.cboFuncion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFuncion.Depth = 0
        Me.cboFuncion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboFuncion.DropDownHeight = 174
        Me.cboFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuncion.DropDownWidth = 121
        Me.cboFuncion.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboFuncion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboFuncion.FormattingEnabled = True
        Me.cboFuncion.Hint = "Funcion del Usuario"
        Me.cboFuncion.IntegralHeight = False
        Me.cboFuncion.ItemHeight = 43
        Me.cboFuncion.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cboFuncion.Location = New System.Drawing.Point(34, 366)
        Me.cboFuncion.MaxDropDownItems = 4
        Me.cboFuncion.MouseState = MaterialSkin.MouseState.OUT
        Me.cboFuncion.Name = "cboFuncion"
        Me.cboFuncion.Size = New System.Drawing.Size(267, 49)
        Me.cboFuncion.StartIndex = 0
        Me.cboFuncion.TabIndex = 81
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrar.FontColor = "#508ef5"
        Me.btnMostrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnMostrar.Location = New System.Drawing.Point(307, 369)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(61, 41)
        Me.btnMostrar.TabIndex = 80
        Me.btnMostrar.Text = "Mostrar"
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
        Me.cboEstado.Hint = "Estado del Usuario"
        Me.cboEstado.IntegralHeight = False
        Me.cboEstado.ItemHeight = 43
        Me.cboEstado.Items.AddRange(New Object() {"A", "N"})
        Me.cboEstado.Location = New System.Drawing.Point(34, 423)
        Me.cboEstado.MaxDropDownItems = 4
        Me.cboEstado.MouseState = MaterialSkin.MouseState.OUT
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(334, 49)
        Me.cboEstado.StartIndex = 0
        Me.cboEstado.TabIndex = 10
        '
        'txtClave
        '
        Me.txtClave.AnimateReadOnly = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Depth = 0
        Me.txtClave.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtClave.Hint = "Clave o Contraseña"
        Me.txtClave.LeadingIcon = Nothing
        Me.txtClave.Location = New System.Drawing.Point(34, 310)
        Me.txtClave.MaxLength = 50
        Me.txtClave.MouseState = MaterialSkin.MouseState.OUT
        Me.txtClave.Multiline = False
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(334, 50)
        Me.txtClave.TabIndex = 7
        Me.txtClave.Text = ""
        Me.txtClave.TrailingIcon = Nothing
        '
        'txtCorreo
        '
        Me.txtCorreo.AnimateReadOnly = False
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCorreo.Depth = 0
        Me.txtCorreo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtCorreo.Hint = "Correo Electronico"
        Me.txtCorreo.LeadingIcon = Nothing
        Me.txtCorreo.Location = New System.Drawing.Point(34, 253)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCorreo.Multiline = False
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(334, 50)
        Me.txtCorreo.TabIndex = 6
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
        Me.txtApellidoM.Location = New System.Drawing.Point(34, 196)
        Me.txtApellidoM.MaxLength = 50
        Me.txtApellidoM.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoM.Multiline = False
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(334, 50)
        Me.txtApellidoM.TabIndex = 5
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
        Me.txtApellidoP.Location = New System.Drawing.Point(34, 139)
        Me.txtApellidoP.MaxLength = 50
        Me.txtApellidoP.MouseState = MaterialSkin.MouseState.OUT
        Me.txtApellidoP.Multiline = False
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(334, 50)
        Me.txtApellidoP.TabIndex = 4
        Me.txtApellidoP.Text = ""
        Me.txtApellidoP.TrailingIcon = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.AnimateReadOnly = False
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombres.Depth = 0
        Me.txtNombres.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNombres.Hint = "Nombres"
        Me.txtNombres.LeadingIcon = Nothing
        Me.txtNombres.Location = New System.Drawing.Point(34, 83)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNombres.Multiline = False
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(334, 50)
        Me.txtNombres.TabIndex = 3
        Me.txtNombres.Text = ""
        Me.txtNombres.TrailingIcon = Nothing
        '
        'txtDocumento
        '
        Me.txtDocumento.AnimateReadOnly = False
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Depth = 0
        Me.txtDocumento.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDocumento.Hint = "Documento Identidad"
        Me.txtDocumento.LeadingIcon = Nothing
        Me.txtDocumento.Location = New System.Drawing.Point(34, 27)
        Me.txtDocumento.MaxLength = 50
        Me.txtDocumento.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDocumento.Multiline = False
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(334, 50)
        Me.txtDocumento.TabIndex = 2
        Me.txtDocumento.Text = ""
        Me.txtDocumento.TrailingIcon = Nothing
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.MINIMARKETDataSet
        '
        'MINIMARKETDataSet
        '
        Me.MINIMARKETDataSet.DataSetName = "MINIMARKETDataSet"
        Me.MINIMARKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1602, 822)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MINIMARKETDataSet As MINIMARKETDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As MINIMARKETDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents txtDocumento As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents cboEstado As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtClave As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCorreo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtApellidoM As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtApellidoP As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtNombres As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnMostrar As FiveCodMaterialDesign.FiveCodFlatButton
    Friend WithEvents cboFuncion As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnCancelar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnVer As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEliminar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEditar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnGuardar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents lvUsuarios As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
