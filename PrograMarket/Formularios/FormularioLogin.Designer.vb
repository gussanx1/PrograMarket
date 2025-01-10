<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioLogin))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtClave = New MaterialSkin.Controls.MaterialTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtDocumentoIdentidad = New MaterialSkin.Controls.MaterialTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.PrograMarket.My.Resources.Resources.MiniMarketLogin
        Me.PictureBox4.Image = Global.PrograMarket.My.Resources.Resources.clave
        Me.PictureBox4.Location = New System.Drawing.Point(512, 180)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'txtClave
        '
        Me.txtClave.AnimateReadOnly = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Depth = 0
        Me.txtClave.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtClave.Hint = "Clave/Contraseña"
        Me.txtClave.LeadingIcon = Nothing
        Me.txtClave.Location = New System.Drawing.Point(567, 180)
        Me.txtClave.MaxLength = 50
        Me.txtClave.MouseState = MaterialSkin.MouseState.OUT
        Me.txtClave.Multiline = False
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Password = True
        Me.txtClave.Size = New System.Drawing.Size(378, 50)
        Me.txtClave.TabIndex = 8
        Me.txtClave.Text = ""
        Me.txtClave.TrailingIcon = Nothing
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.PrograMarket.My.Resources.Resources.MiniMarketLogin
        Me.PictureBox3.Image = Global.PrograMarket.My.Resources.Resources.dni
        Me.PictureBox3.Location = New System.Drawing.Point(512, 88)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'txtDocumentoIdentidad
        '
        Me.txtDocumentoIdentidad.AnimateReadOnly = False
        Me.txtDocumentoIdentidad.BackColor = System.Drawing.Color.LightGray
        Me.txtDocumentoIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumentoIdentidad.Depth = 0
        Me.txtDocumentoIdentidad.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDocumentoIdentidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.txtDocumentoIdentidad.Hint = "Documento De Identidad"
        Me.txtDocumentoIdentidad.LeadingIcon = Nothing
        Me.txtDocumentoIdentidad.Location = New System.Drawing.Point(567, 89)
        Me.txtDocumentoIdentidad.MaxLength = 50
        Me.txtDocumentoIdentidad.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDocumentoIdentidad.Multiline = False
        Me.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad"
        Me.txtDocumentoIdentidad.Size = New System.Drawing.Size(378, 50)
        Me.txtDocumentoIdentidad.TabIndex = 6
        Me.txtDocumentoIdentidad.Text = ""
        Me.txtDocumentoIdentidad.TrailingIcon = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.PrograMarket.My.Resources.Resources.MiniMarketLogin
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.PrograMarket.My.Resources.Resources.LogoPrograma
        Me.PictureBox2.Location = New System.Drawing.Point(73, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(397, 372)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSize = False
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.BackColor = System.Drawing.Color.Blue
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Global.PrograMarket.My.Resources.Resources.InicioSesion
        Me.MaterialButton1.Location = New System.Drawing.Point(596, 268)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(321, 36)
        Me.MaterialButton1.TabIndex = 10
        Me.MaterialButton1.Text = "Iniciar Sesión"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(581, 45)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(1, 0)
        Me.MaterialLabel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.PrograMarket.My.Resources.Resources.MiniMarketLogin
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Controls.Add(Me.txtDocumentoIdentidad)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.MaterialButton1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 379)
        Me.Panel1.TabIndex = 11
        '
        'FormularioLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PrograMarket.My.Resources.Resources.MiniMarketLogin
        Me.ClientSize = New System.Drawing.Size(987, 394)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormularioLogin"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioLogin"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtDocumentoIdentidad As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtClave As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel1 As Panel
End Class
