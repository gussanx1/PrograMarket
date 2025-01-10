<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteCompras
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
        Me.MINIMARKETDataSet = New PrograMarket.MINIMARKETDataSet()
        Me.MINIMARKETDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLimpiar = New MaterialSkin.Controls.MaterialButton()
        Me.btnTodos = New MaterialSkin.Controls.MaterialButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboProveedor = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnExportarExcel = New MaterialSkin.Controls.MaterialButton()
        Me.btnBuscar = New MaterialSkin.Controls.MaterialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MINIMARKETDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MINIMARKETDataSet
        '
        Me.MINIMARKETDataSet.DataSetName = "MINIMARKETDataSet"
        Me.MINIMARKETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MINIMARKETDataSetBindingSource
        '
        Me.MINIMARKETDataSetBindingSource.DataSource = Me.MINIMARKETDataSet
        Me.MINIMARKETDataSetBindingSource.Position = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLimpiar.Depth = 0
        Me.btnLimpiar.HighEmphasis = True
        Me.btnLimpiar.Icon = Nothing
        Me.btnLimpiar.Location = New System.Drawing.Point(547, 153)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLimpiar.Size = New System.Drawing.Size(128, 36)
        Me.btnLimpiar.TabIndex = 60
        Me.btnLimpiar.Text = "LIMPIAR TABLA"
        Me.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnLimpiar.UseAccentColor = False
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTodos
        '
        Me.btnTodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTodos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnTodos.Depth = 0
        Me.btnTodos.HighEmphasis = True
        Me.btnTodos.Icon = Nothing
        Me.btnTodos.Location = New System.Drawing.Point(237, 779)
        Me.btnTodos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnTodos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnTodos.Size = New System.Drawing.Size(141, 36)
        Me.btnTodos.TabIndex = 59
        Me.btnTodos.Text = "MOSTRAR TODOS"
        Me.btnTodos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnTodos.UseAccentColor = False
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1283, 550)
        Me.DataGridView1.TabIndex = 58
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoResize = False
        Me.cboProveedor.BackColor = System.Drawing.Color.White
        Me.cboProveedor.Depth = 0
        Me.cboProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboProveedor.DropDownHeight = 174
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.DropDownWidth = 118
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.IntegralHeight = False
        Me.cboProveedor.ItemHeight = 43
        Me.cboProveedor.Location = New System.Drawing.Point(159, 148)
        Me.cboProveedor.MaxDropDownItems = 4
        Me.cboProveedor.MouseState = MaterialSkin.MouseState.OUT
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(346, 49)
        Me.cboProveedor.StartIndex = -1
        Me.cboProveedor.TabIndex = 57
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExportarExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExportarExcel.Depth = 0
        Me.btnExportarExcel.HighEmphasis = True
        Me.btnExportarExcel.Icon = Nothing
        Me.btnExportarExcel.ImageKey = "Excel-Logo.png"
        Me.btnExportarExcel.Location = New System.Drawing.Point(46, 779)
        Me.btnExportarExcel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExportarExcel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExportarExcel.Size = New System.Drawing.Size(153, 36)
        Me.btnExportarExcel.TabIndex = 56
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
        Me.btnBuscar.Location = New System.Drawing.Point(547, 88)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnBuscar.Size = New System.Drawing.Size(160, 36)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar por fecha"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBuscar.UseAccentColor = False
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Proveedor: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Fecha Fin:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha Inicio:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.CustomFormat = ""
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(387, 94)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(118, 20)
        Me.dtpFechaFinal.TabIndex = 51
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = ""
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(159, 95)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(118, 20)
        Me.dtpFechaInicial.TabIndex = 50
        '
        'FrmReporteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1668, 838)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.btnExportarExcel)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Name = "FrmReporteCompras"
        Me.Text = "Reporte De Las Compras"
        CType(Me.MINIMARKETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MINIMARKETDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MINIMARKETDataSet As MINIMARKETDataSet
    Friend WithEvents MINIMARKETDataSetBindingSource As BindingSource
    Friend WithEvents btnLimpiar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnTodos As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboProveedor As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnExportarExcel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBuscar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
End Class
