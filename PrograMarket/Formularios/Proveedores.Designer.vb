<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lvProveedores = New MaterialSkin.Controls.MaterialListView()
        Me.xd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboEstado = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtTelefono = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtCorreo = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtRazonSocial = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.txtDocumento = New MaterialSkin.Controls.MaterialTextBox()
        Me.btnEliminar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnEditar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnGuardar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnCancelar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.btnVer = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.SuspendLayout()
        '
        'lvProveedores
        '
        Me.lvProveedores.AutoSizeTable = False
        Me.lvProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvProveedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.xd, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvProveedores.Depth = 0
        Me.lvProveedores.FullRowSelect = True
        Me.lvProveedores.HideSelection = False
        Me.lvProveedores.Location = New System.Drawing.Point(391, 77)
        Me.lvProveedores.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvProveedores.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvProveedores.MouseState = MaterialSkin.MouseState.OUT
        Me.lvProveedores.Name = "lvProveedores"
        Me.lvProveedores.OwnerDraw = True
        Me.lvProveedores.Size = New System.Drawing.Size(1193, 664)
        Me.lvProveedores.TabIndex = 74
        Me.lvProveedores.UseCompatibleStateImageBehavior = False
        Me.lvProveedores.View = System.Windows.Forms.View.Details
        '
        'xd
        '
        Me.xd.Text = "DNI"
        Me.xd.Width = 150
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Razon Social"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Correo"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefono"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Estado"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha Registro"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 280
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
        Me.cboEstado.Location = New System.Drawing.Point(28, 427)
        Me.cboEstado.MaxDropDownItems = 4
        Me.cboEstado.MouseState = MaterialSkin.MouseState.OUT
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(342, 49)
        Me.cboEstado.StartIndex = 0
        Me.cboEstado.TabIndex = 101
        '
        'txtTelefono
        '
        Me.txtTelefono.AnimateReadOnly = False
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Depth = 0
        Me.txtTelefono.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtTelefono.Hint = "Telefono"
        Me.txtTelefono.LeadingIcon = Nothing
        Me.txtTelefono.Location = New System.Drawing.Point(28, 347)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTelefono.Multiline = False
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(342, 50)
        Me.txtTelefono.TabIndex = 100
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
        Me.txtCorreo.Location = New System.Drawing.Point(28, 271)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtCorreo.Multiline = False
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(342, 50)
        Me.txtCorreo.TabIndex = 99
        Me.txtCorreo.Text = ""
        Me.txtCorreo.TrailingIcon = Nothing
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.AllowPromptAsInput = True
        Me.txtRazonSocial.AnimateReadOnly = False
        Me.txtRazonSocial.AsciiOnly = False
        Me.txtRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtRazonSocial.BeepOnError = False
        Me.txtRazonSocial.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtRazonSocial.Depth = 0
        Me.txtRazonSocial.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtRazonSocial.HidePromptOnLeave = False
        Me.txtRazonSocial.HideSelection = True
        Me.txtRazonSocial.Hint = "Razon Social"
        Me.txtRazonSocial.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.txtRazonSocial.LeadingIcon = Nothing
        Me.txtRazonSocial.Location = New System.Drawing.Point(28, 194)
        Me.txtRazonSocial.Mask = ""
        Me.txtRazonSocial.MaxLength = 32767
        Me.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonSocial.PrefixSuffixText = Nothing
        Me.txtRazonSocial.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtRazonSocial.ReadOnly = False
        Me.txtRazonSocial.RejectInputOnFirstFailure = False
        Me.txtRazonSocial.ResetOnPrompt = True
        Me.txtRazonSocial.ResetOnSpace = True
        Me.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRazonSocial.SelectedText = ""
        Me.txtRazonSocial.SelectionLength = 0
        Me.txtRazonSocial.SelectionStart = 0
        Me.txtRazonSocial.ShortcutsEnabled = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(342, 48)
        Me.txtRazonSocial.SkipLiterals = True
        Me.txtRazonSocial.TabIndex = 98
        Me.txtRazonSocial.TabStop = False
        Me.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRazonSocial.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txtRazonSocial.TrailingIcon = Nothing
        Me.txtRazonSocial.UseSystemPasswordChar = False
        Me.txtRazonSocial.ValidatingType = Nothing
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
        Me.txtDocumento.Location = New System.Drawing.Point(28, 121)
        Me.txtDocumento.MaxLength = 50
        Me.txtDocumento.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDocumento.Multiline = False
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(342, 50)
        Me.txtDocumento.TabIndex = 97
        Me.txtDocumento.Text = ""
        Me.txtDocumento.TrailingIcon = Nothing
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BGColor = "#415EFF"
        Me.btnEliminar.FontColor = "#ffffff"
        Me.btnEliminar.ImageButton = Global.PrograMarket.My.Resources.Resources.borrar
        Me.btnEliminar.Location = New System.Drawing.Point(82, 638)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(240, 41)
        Me.btnEliminar.TabIndex = 106
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BGColor = "#ffffff"
        Me.btnEditar.FontColor = "#415eff"
        Me.btnEditar.ImageButton = Global.PrograMarket.My.Resources.Resources.editar
        Me.btnEditar.Location = New System.Drawing.Point(82, 577)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(240, 41)
        Me.btnEditar.TabIndex = 105
        Me.btnEditar.Text = "EDITAR"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BGColor = "#415EFF"
        Me.btnGuardar.FontColor = "#ffffff"
        Me.btnGuardar.ImageButton = Global.PrograMarket.My.Resources.Resources.anadir
        Me.btnGuardar.Location = New System.Drawing.Point(82, 517)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 41)
        Me.btnGuardar.TabIndex = 104
        Me.btnGuardar.Text = "AGREGAR"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BGColor = "#d1e5ff"
        Me.btnCancelar.FontColor = "#000000"
        Me.btnCancelar.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.btnCancelar.Location = New System.Drawing.Point(1420, 765)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(143, 41)
        Me.btnCancelar.TabIndex = 103
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.Transparent
        Me.btnVer.BGColor = "#415EFF"
        Me.btnVer.FontColor = "#ffffff"
        Me.btnVer.ImageButton = Global.PrograMarket.My.Resources.Resources.ver
        Me.btnVer.Location = New System.Drawing.Point(1234, 765)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(180, 41)
        Me.btnVer.TabIndex = 102
        Me.btnVer.Text = "Ver Eliminados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.lvProveedores)
        Me.Name = "Form1"
        Me.Text = "Detalle De Proveedores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvProveedores As MaterialSkin.Controls.MaterialListView
    Friend WithEvents xd As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents cboEstado As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtTelefono As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtCorreo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtRazonSocial As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txtDocumento As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnCancelar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnVer As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEliminar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnEditar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents btnGuardar As FiveCodMaterialDesign.FiveCodImageButton
End Class
