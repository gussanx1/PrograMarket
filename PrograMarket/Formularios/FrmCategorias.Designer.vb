<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategorias
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
        Me.lvCategoria = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MaterialSkin.Controls.MaterialButton()
        Me.cboEstadoCategoria = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'lvCategoria
        '
        Me.lvCategoria.AutoSizeTable = False
        Me.lvCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvCategoria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvCategoria.Depth = 0
        Me.lvCategoria.FullRowSelect = True
        Me.lvCategoria.HideSelection = False
        Me.lvCategoria.Location = New System.Drawing.Point(51, 245)
        Me.lvCategoria.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvCategoria.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvCategoria.MouseState = MaterialSkin.MouseState.OUT
        Me.lvCategoria.Name = "lvCategoria"
        Me.lvCategoria.OwnerDraw = True
        Me.lvCategoria.Size = New System.Drawing.Size(1279, 385)
        Me.lvCategoria.TabIndex = 67
        Me.lvCategoria.UseCompatibleStateImageBehavior = False
        Me.lvCategoria.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DESCRIPCION"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ESTADO"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "FECHA"
        Me.ColumnHeader4.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(753, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Fecha:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = ""
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(756, 132)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(225, 20)
        Me.dtpFechaInicial.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Lista de Categorias:"
        '
        'btnGuardar
        '
        Me.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGuardar.Depth = 0
        Me.btnGuardar.HighEmphasis = True
        Me.btnGuardar.Icon = Nothing
        Me.btnGuardar.Location = New System.Drawing.Point(1068, 120)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGuardar.Size = New System.Drawing.Size(88, 36)
        Me.btnGuardar.TabIndex = 63
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnGuardar.UseAccentColor = False
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cboEstadoCategoria
        '
        Me.cboEstadoCategoria.AutoResize = False
        Me.cboEstadoCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboEstadoCategoria.Depth = 0
        Me.cboEstadoCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboEstadoCategoria.DropDownHeight = 174
        Me.cboEstadoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCategoria.DropDownWidth = 121
        Me.cboEstadoCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboEstadoCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboEstadoCategoria.FormattingEnabled = True
        Me.cboEstadoCategoria.IntegralHeight = False
        Me.cboEstadoCategoria.ItemHeight = 43
        Me.cboEstadoCategoria.Items.AddRange(New Object() {"A", "N"})
        Me.cboEstadoCategoria.Location = New System.Drawing.Point(394, 118)
        Me.cboEstadoCategoria.MaxDropDownItems = 4
        Me.cboEstadoCategoria.MouseState = MaterialSkin.MouseState.OUT
        Me.cboEstadoCategoria.Name = "cboEstadoCategoria"
        Me.cboEstadoCategoria.Size = New System.Drawing.Size(296, 49)
        Me.cboEstadoCategoria.Sorted = True
        Me.cboEstadoCategoria.StartIndex = 0
        Me.cboEstadoCategoria.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AnimateReadOnly = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Depth = 0
        Me.txtDescripcion.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDescripcion.LeadingIcon = Nothing
        Me.txtDescripcion.Location = New System.Drawing.Point(49, 120)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDescripcion.Multiline = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(296, 50)
        Me.txtDescripcion.TabIndex = 59
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.TrailingIcon = Nothing
        '
        'FrmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 743)
        Me.Controls.Add(Me.lvCategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cboEstadoCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Name = "FrmCategorias"
        Me.Text = "Categorias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvCategoria As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cboEstadoCategoria As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As MaterialSkin.Controls.MaterialTextBox
End Class
