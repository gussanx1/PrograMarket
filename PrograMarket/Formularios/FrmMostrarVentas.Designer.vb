<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMostrarVentas
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
        Me.lvVentas = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvVentas
        '
        Me.lvVentas.AutoSizeTable = False
        Me.lvVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader11, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvVentas.Depth = 0
        Me.lvVentas.FullRowSelect = True
        Me.lvVentas.HideSelection = False
        Me.lvVentas.Location = New System.Drawing.Point(22, 67)
        Me.lvVentas.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvVentas.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvVentas.MouseState = MaterialSkin.MouseState.OUT
        Me.lvVentas.Name = "lvVentas"
        Me.lvVentas.OwnerDraw = True
        Me.lvVentas.Size = New System.Drawing.Size(1574, 749)
        Me.lvVentas.TabIndex = 0
        Me.lvVentas.UseCompatibleStateImageBehavior = False
        Me.lvVentas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Comprobante"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI Usuario"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cliente Nombres"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cliente Apellido P"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cliente Apellido M"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Pago"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Vuelto"
        Me.ColumnHeader8.Width = 110
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Total"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Fecha"
        Me.ColumnHeader10.Width = 150
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "DNI Cliente"
        Me.ColumnHeader11.Width = 150
        '
        'FrmMostrarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1602, 822)
        Me.Controls.Add(Me.lvVentas)
        Me.Name = "FrmMostrarVentas"
        Me.Text = "FrmMostrarVentas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvVentas As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
End Class
