Imports System.Data.SqlClient
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class FormularioLogin

    Dim conexion As conexion = New conexion()
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daLogin As SqlDataAdapter
    Dim vPosicion As Integer
    Public funcion As String
    Public DocumentoIdentidad As String
    Public dni As String

    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager

    Private Sub FormularioLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim material = materialSkinManager

        material = MaterialSkin.MaterialSkinManager.Instance
        material.EnforceBackcolorOnAllComponents = True
        material.AddFormToManage(Me)
        material.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        material.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Amber200, MaterialSkin.Primary.Pink800, MaterialSkin.TextShade.WHITE)

        conexion.Conectar()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim sql As String
        Dim tabla As String
        Dim condicion As String

        sql = "SELECT * FROM "
        tabla = "programaIngreso.Usuario"
        condicion = "UsuarioDocumentoIdentidad = '" + txtDocumentoIdentidad.Text + "' " + "AND UsuarioClave = '" + txtClave.Text + "'"

        funcion = conexion.ConsultaEspecifica(sql, tabla, condicion)
        If (funcion > 0) Then
            dni = txtDocumentoIdentidad.Text
            Me.Visible = False
            FormularioPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error. Usuario No Registrado")
        End If
    End Sub

End Class