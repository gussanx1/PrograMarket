<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.Numero_Comprobante = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo_Comprobante = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DNI_Usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DNI_Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Monto_Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboClientes = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTodos = New MaterialSkin.Controls.MaterialButton()
        Me.btnExportarExcel = New MaterialSkin.Controls.MaterialButton()
        Me.btnBuscar = New MaterialSkin.Controls.MaterialButton()
        Me.lvReportesVentas = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.MINIMARKETDataSet = New PrograMarket.MINIMARKETDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New PrograMarket.MINIMARKETDataSetTableAdapters.VentaTableAdapter()
        Me.VentaNumeroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaTipoComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaClienteNombresApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaClienteApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaClienteApellidoMaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaMontoPagoComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaMontoVueltoComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaMontoTotalComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaFechaRegistroComprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.lvReportesVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero_Comprobante
        '
        Me.Numero_Comprobante.Text = "Numero_Comprobante"
        Me.Numero_Comprobante.Width = 180
        '
        'Tipo_Comprobante
        '
        Me.Tipo_Comprobante.Text = "Tipo_Comprobante"
        Me.Tipo_Comprobante.Width = 160
        '
        'DNI_Usuario
        '
        Me.DNI_Usuario.Text = "DNI_Usuario"
        Me.DNI_Usuario.Width = 111
        '
        'DNI_Proveedor
        '
        Me.DNI_Proveedor.Text = "DNI_Proveedor"
        Me.DNI_Proveedor.Width = 136
        '
        'Monto_Total
        '
        Me.Monto_Total.Text = "Monto_Total"
        Me.Monto_Total.Width = 116
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 77
        '
        'cboClientes
        '
        Me.cboClientes.AutoResize = False
        Me.cboClientes.BackColor = System.Drawing.Color.White
        Me.cboClientes.Depth = 0
        Me.cboClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboClientes.DropDownHeight = 174
        Me.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientes.DropDownWidth = 118
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboClientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.IntegralHeight = False
        Me.cboClientes.ItemHeight = 43
        Me.cboClientes.Location = New System.Drawing.Point(340, 190)
        Me.cboClientes.MaxDropDownItems = 4
        Me.cboClientes.MouseState = MaterialSkin.MouseState.OUT
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(346, 49)
        Me.cboClientes.StartIndex = -1
        Me.cboClientes.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Cliente:"
        '
        'btnTodos
        '
        Me.btnTodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTodos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnTodos.Depth = 0
        Me.btnTodos.HighEmphasis = True
        Me.btnTodos.Icon = Nothing
        Me.btnTodos.Location = New System.Drawing.Point(764, 203)
        Me.btnTodos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTodos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnTodos.Size = New System.Drawing.Size(141, 36)
        Me.btnTodos.TabIndex = 61
        Me.btnTodos.Text = "MOSTRAR TODOS"
        Me.btnTodos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnTodos.UseAccentColor = False
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExportarExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExportarExcel.Depth = 0
        Me.btnExportarExcel.HighEmphasis = True
        Me.btnExportarExcel.Icon = Nothing
        Me.btnExportarExcel.ImageKey = "Excel-Logo.png"
        Me.btnExportarExcel.Location = New System.Drawing.Point(232, 654)
        Me.btnExportarExcel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExportarExcel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExportarExcel.Size = New System.Drawing.Size(153, 36)
        Me.btnExportarExcel.TabIndex = 60
        Me.btnExportarExcel.Text = "Descargar Excel"
        Me.btnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportarExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnExportarExcel.UseAccentColor = False
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnBuscar.Depth = 0
        Me.btnBuscar.HighEmphasis = True
        Me.btnBuscar.Icon = Nothing
        Me.btnBuscar.ImageKey = "buscar.png"
        Me.btnBuscar.Location = New System.Drawing.Point(745, 147)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnBuscar.Size = New System.Drawing.Size(160, 36)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar por fecha"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBuscar.UseAccentColor = False
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lvReportesVentas
        '
        Me.lvReportesVentas.AutoGenerateColumns = False
        Me.lvReportesVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvReportesVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VentaNumeroComprobanteDataGridViewTextBoxColumn, Me.VentaTipoComprobanteDataGridViewTextBoxColumn, Me.VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn, Me.VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn, Me.VentaClienteNombresApellidosDataGridViewTextBoxColumn, Me.VentaClienteApellidoPaternoDataGridViewTextBoxColumn, Me.VentaClienteApellidoMaternoDataGridViewTextBoxColumn, Me.VentaMontoPagoComprobanteDataGridViewTextBoxColumn, Me.VentaMontoVueltoComprobanteDataGridViewTextBoxColumn, Me.VentaMontoTotalComprobanteDataGridViewTextBoxColumn, Me.VentaFechaRegistroComprobanteDataGridViewTextBoxColumn})
        Me.lvReportesVentas.DataSource = Me.VentaBindingSource
        Me.lvReportesVentas.Location = New System.Drawing.Point(209, 284)
        Me.lvReportesVentas.Name = "lvReportesVentas"
        Me.lvReportesVentas.Size = New System.Drawing.Size(1159, 330)
        Me.lvReportesVentas.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Fecha Fin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Fecha Inicio:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.CustomFormat = ""
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(565, 147)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(118, 20)
        Me.dtpFechaFinal.TabIndex = 55
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = ""
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(340, 147)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(118, 20)
        Me.dtpFechaInicial.TabIndex = 54
        '
        'MINIMARKETDataSet
        '
        Me.MINIMARKETDataSet.DataSetName = "MINIMARKETDataSet"
        Me.MINIMARKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.MINIMARKETDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'VentaNumeroComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaNumeroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaNumeroComprobante"
        Me.VentaNumeroComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaNumeroComprobante"
        Me.VentaNumeroComprobanteDataGridViewTextBoxColumn.Name = "VentaNumeroComprobanteDataGridViewTextBoxColumn"
        '
        'VentaTipoComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaTipoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaTipoComprobante"
        Me.VentaTipoComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaTipoComprobante"
        Me.VentaTipoComprobanteDataGridViewTextBoxColumn.Name = "VentaTipoComprobanteDataGridViewTextBoxColumn"
        '
        'VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "VentaUsuarioDocumentoIdentidad"
        Me.VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "VentaUsuarioDocumentoIdentidad"
        Me.VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn.Name = "VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn"
        '
        'VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn
        '
        Me.VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "VentaClienteDocumentoIdentidad"
        Me.VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn.HeaderText = "VentaClienteDocumentoIdentidad"
        Me.VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn.Name = "VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn"
        '
        'VentaClienteNombresApellidosDataGridViewTextBoxColumn
        '
        Me.VentaClienteNombresApellidosDataGridViewTextBoxColumn.DataPropertyName = "VentaClienteNombresApellidos"
        Me.VentaClienteNombresApellidosDataGridViewTextBoxColumn.HeaderText = "VentaClienteNombresApellidos"
        Me.VentaClienteNombresApellidosDataGridViewTextBoxColumn.Name = "VentaClienteNombresApellidosDataGridViewTextBoxColumn"
        '
        'VentaClienteApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.VentaClienteApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "VentaClienteApellidoPaterno"
        Me.VentaClienteApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "VentaClienteApellidoPaterno"
        Me.VentaClienteApellidoPaternoDataGridViewTextBoxColumn.Name = "VentaClienteApellidoPaternoDataGridViewTextBoxColumn"
        '
        'VentaClienteApellidoMaternoDataGridViewTextBoxColumn
        '
        Me.VentaClienteApellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "VentaClienteApellidoMaterno"
        Me.VentaClienteApellidoMaternoDataGridViewTextBoxColumn.HeaderText = "VentaClienteApellidoMaterno"
        Me.VentaClienteApellidoMaternoDataGridViewTextBoxColumn.Name = "VentaClienteApellidoMaternoDataGridViewTextBoxColumn"
        '
        'VentaMontoPagoComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaMontoPagoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaMontoPagoComprobante"
        Me.VentaMontoPagoComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaMontoPagoComprobante"
        Me.VentaMontoPagoComprobanteDataGridViewTextBoxColumn.Name = "VentaMontoPagoComprobanteDataGridViewTextBoxColumn"
        '
        'VentaMontoVueltoComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaMontoVueltoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaMontoVueltoComprobante"
        Me.VentaMontoVueltoComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaMontoVueltoComprobante"
        Me.VentaMontoVueltoComprobanteDataGridViewTextBoxColumn.Name = "VentaMontoVueltoComprobanteDataGridViewTextBoxColumn"
        '
        'VentaMontoTotalComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaMontoTotalComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaMontoTotalComprobante"
        Me.VentaMontoTotalComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaMontoTotalComprobante"
        Me.VentaMontoTotalComprobanteDataGridViewTextBoxColumn.Name = "VentaMontoTotalComprobanteDataGridViewTextBoxColumn"
        '
        'VentaFechaRegistroComprobanteDataGridViewTextBoxColumn
        '
        Me.VentaFechaRegistroComprobanteDataGridViewTextBoxColumn.DataPropertyName = "VentaFechaRegistroComprobante"
        Me.VentaFechaRegistroComprobanteDataGridViewTextBoxColumn.HeaderText = "VentaFechaRegistroComprobante"
        Me.VentaFechaRegistroComprobanteDataGridViewTextBoxColumn.Name = "VentaFechaRegistroComprobanteDataGridViewTextBoxColumn"
        '
        'FrmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1618, 836)
        Me.Controls.Add(Me.cboClientes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lvReportesVentas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Name = "FrmReporteVentas"
        Me.Text = "Reporte de las Ventas"
        CType(Me.lvReportesVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Numero_Comprobante As ColumnHeader
    Friend WithEvents Tipo_Comprobante As ColumnHeader
    Friend WithEvents DNI_Usuario As ColumnHeader
    Friend WithEvents DNI_Proveedor As ColumnHeader
    Friend WithEvents Monto_Total As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents cboClientes As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTodos As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExportarExcel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBuscar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lvReportesVentas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents MINIMARKETDataSet As MINIMARKETDataSet
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As MINIMARKETDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents VentaNumeroComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaTipoComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaUsuarioDocumentoIdentidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaClienteDocumentoIdentidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaClienteNombresApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaClienteApellidoPaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaClienteApellidoMaternoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaMontoPagoComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaMontoVueltoComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaMontoTotalComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VentaFechaRegistroComprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
