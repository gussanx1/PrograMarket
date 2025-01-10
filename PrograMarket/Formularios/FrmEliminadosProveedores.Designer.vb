<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminadosProveedores
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
        Me.lvProvedoresElimin = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FiveCodImageButton2 = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.cmdRecuperar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.SuspendLayout()
        '
        'lvProvedoresElimin
        '
        Me.lvProvedoresElimin.AutoSizeTable = False
        Me.lvProvedoresElimin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvProvedoresElimin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvProvedoresElimin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvProvedoresElimin.Depth = 0
        Me.lvProvedoresElimin.FullRowSelect = True
        Me.lvProvedoresElimin.HideSelection = False
        Me.lvProvedoresElimin.Location = New System.Drawing.Point(6, 67)
        Me.lvProvedoresElimin.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvProvedoresElimin.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvProvedoresElimin.MouseState = MaterialSkin.MouseState.OUT
        Me.lvProvedoresElimin.Name = "lvProvedoresElimin"
        Me.lvProvedoresElimin.OwnerDraw = True
        Me.lvProvedoresElimin.Size = New System.Drawing.Size(953, 372)
        Me.lvProvedoresElimin.TabIndex = 0
        Me.lvProvedoresElimin.UseCompatibleStateImageBehavior = False
        Me.lvProvedoresElimin.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DNI"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Razon Social"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Correo"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono"
        Me.ColumnHeader4.Width = 250
        '
        'FiveCodImageButton2
        '
        Me.FiveCodImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.FiveCodImageButton2.BGColor = "#32bea6"
        Me.FiveCodImageButton2.FontColor = "#ffffff"
        Me.FiveCodImageButton2.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.FiveCodImageButton2.Location = New System.Drawing.Point(816, 450)
        Me.FiveCodImageButton2.Name = "FiveCodImageButton2"
        Me.FiveCodImageButton2.Size = New System.Drawing.Size(143, 41)
        Me.FiveCodImageButton2.TabIndex = 3
        Me.FiveCodImageButton2.Text = "            Cancelar"
        '
        'cmdRecuperar
        '
        Me.cmdRecuperar.BackColor = System.Drawing.Color.Transparent
        Me.cmdRecuperar.BGColor = "#32bea6"
        Me.cmdRecuperar.FontColor = "#ffffff"
        Me.cmdRecuperar.ImageButton = Global.PrograMarket.My.Resources.Resources.recuperar
        Me.cmdRecuperar.Location = New System.Drawing.Point(667, 450)
        Me.cmdRecuperar.Name = "cmdRecuperar"
        Me.cmdRecuperar.Size = New System.Drawing.Size(143, 41)
        Me.cmdRecuperar.TabIndex = 2
        Me.cmdRecuperar.Text = "            Recuperar"
        '
        'FrmEliminadosProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 505)
        Me.Controls.Add(Me.FiveCodImageButton2)
        Me.Controls.Add(Me.cmdRecuperar)
        Me.Controls.Add(Me.lvProvedoresElimin)
        Me.Name = "FrmEliminadosProveedores"
        Me.Text = "Proveedores Eliminados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvProvedoresElimin As MaterialSkin.Controls.MaterialListView
    Friend WithEvents FiveCodImageButton2 As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents cmdRecuperar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
