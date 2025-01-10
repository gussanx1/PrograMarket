<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminadosClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminadosClientes))
        Me.lvClientesElimin = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FiveCodImageButton2 = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.cmdRecuperar = New FiveCodMaterialDesign.FiveCodImageButton()
        Me.SuspendLayout()
        '
        'lvClientesElimin
        '
        Me.lvClientesElimin.AutoSizeTable = False
        Me.lvClientesElimin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lvClientesElimin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvClientesElimin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvClientesElimin.Depth = 0
        Me.lvClientesElimin.FullRowSelect = True
        Me.lvClientesElimin.HideSelection = False
        Me.lvClientesElimin.Location = New System.Drawing.Point(11, 80)
        Me.lvClientesElimin.MinimumSize = New System.Drawing.Size(200, 100)
        Me.lvClientesElimin.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvClientesElimin.MouseState = MaterialSkin.MouseState.OUT
        Me.lvClientesElimin.Name = "lvClientesElimin"
        Me.lvClientesElimin.OwnerDraw = True
        Me.lvClientesElimin.Size = New System.Drawing.Size(943, 365)
        Me.lvClientesElimin.TabIndex = 2
        Me.lvClientesElimin.UseCompatibleStateImageBehavior = False
        Me.lvClientesElimin.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DNI"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombres"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido Paterno"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Apellido Materno"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 250
        '
        'FiveCodImageButton2
        '
        Me.FiveCodImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.FiveCodImageButton2.BGColor = "#32bea6"
        Me.FiveCodImageButton2.FontColor = "#ffffff"
        Me.FiveCodImageButton2.ImageButton = Global.PrograMarket.My.Resources.Resources.cancelar
        Me.FiveCodImageButton2.Location = New System.Drawing.Point(813, 455)
        Me.FiveCodImageButton2.Name = "FiveCodImageButton2"
        Me.FiveCodImageButton2.Size = New System.Drawing.Size(143, 41)
        Me.FiveCodImageButton2.TabIndex = 1
        Me.FiveCodImageButton2.Text = "            Cancelar"
        '
        'cmdRecuperar
        '
        Me.cmdRecuperar.BackColor = System.Drawing.Color.Transparent
        Me.cmdRecuperar.BGColor = "#32bea6"
        Me.cmdRecuperar.FontColor = "#ffffff"
        Me.cmdRecuperar.ImageButton = Global.PrograMarket.My.Resources.Resources.recuperar
        Me.cmdRecuperar.Location = New System.Drawing.Point(664, 455)
        Me.cmdRecuperar.Name = "cmdRecuperar"
        Me.cmdRecuperar.Size = New System.Drawing.Size(143, 41)
        Me.cmdRecuperar.TabIndex = 0
        Me.cmdRecuperar.Text = "            Recuperar"
        '
        'FrmEliminadosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 505)
        Me.Controls.Add(Me.lvClientesElimin)
        Me.Controls.Add(Me.FiveCodImageButton2)
        Me.Controls.Add(Me.cmdRecuperar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEliminadosClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes Eliminados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdRecuperar As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents FiveCodImageButton2 As FiveCodMaterialDesign.FiveCodImageButton
    Friend WithEvents lvClientesElimin As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
