Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MaterialSkin.Controls

Public Class Usuarios

    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim vPosicion As Integer
    Public vUsuarioRecuperado As Integer = 0

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim material = materialSkinManager
        material = MaterialSkin.MaterialSkinManager.Instance
        material.EnforceBackcolorOnAllComponents = True
        material.AddFormToManage(Me)
        material.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        material.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo100, MaterialSkin.Primary.Blue800, MaterialSkin.TextShade.WHITE)
        CrearDataSet()
        MostrarRegistro()
        LlenarLista()
        Botones(True, True, True, False, True, True)
        Controles(False, False, False, False, False, False, False, False, False, True)

    End Sub

    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Cerrar As Boolean, Ver As Boolean)
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnEliminar.Enabled = Eliminar
        btnCancelar.Enabled = Cancelar
        btnVer.Enabled = Ver
    End Sub

    Private Sub Controles(Documento As Boolean, Nombres As Boolean, ApellidoP As Boolean, ApellidoM As Boolean, Correo As Boolean,
                          Clave As Boolean, Funcion As Boolean, Estado As Boolean, Fecha As Boolean, Lista As Boolean)
        txtDocumento.Enabled = Documento
        txtNombres.Enabled = Nombres
        txtApellidoP.Enabled = ApellidoP
        txtApellidoM.Enabled = ApellidoM
        txtCorreo.Enabled = Correo
        txtClave.Enabled = Clave
        cboFuncion.Enabled = Funcion
        cboEstado.Enabled = Estado
        lvUsuarios.Enabled = Lista
        cboFuncion.Focus()
        cboEstado.Focus()
        txtDocumento.Focus()
    End Sub

    Private Sub FiveCodFlatButton1_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MessageBox.Show("1	Administrador
2	Trabajador
3	Cliente
4	Proveedor 
5   Analista")
    End Sub

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("spUsuariosSinBorrados", cn)
        daClientes.Fill(dsDatos, "Usuario")
    End Sub
    Private Sub MostrarRegistro()
        txtDocumento.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioDocumentoIdentidad").ToString
        txtNombres.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioNombres").ToString
        txtApellidoP.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioApellidoPaterno").ToString
        txtApellidoM.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioApellidoMaterno").ToString
        txtCorreo.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioCorreo").ToString
        txtClave.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioClave").ToString
        cboEstado.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioFuncionCodigo").ToString
        cboEstado.Text = dsDatos.Tables("Usuario").Rows(vPosicion).Item("UsuarioEstado").ToString
    End Sub

    Private Sub LlenarLista()
        lvUsuarios.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Usuario").Rows.Count - 1
            lvUsuarios.Items.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioDocumentoIdentidad").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioNombres").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioApellidoPaterno").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioApellidoMaterno").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioCorreo").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioClave").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioFuncionCodigo").ToString)
            lvUsuarios.Items(i).SubItems.Add(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioEstado").ToString)
            lvUsuarios.Items(i).SubItems.Add(Format(dsDatos.Tables("Usuario").Rows(i).Item("UsuarioFechaRegistro").ToString, "Short Date"))
        Next
    End Sub

    Private Sub lvUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUsuarios.SelectedIndexChanged
        If lvUsuarios.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Usuario").Rows.Count - 1
            If lvUsuarios.SelectedItems(0).Text = dsDatos.Tables("Usuario").Rows(i).Item("UsuarioDocumentoIdentidad").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "AGREGAR" Then
            btnGuardar.Text = "GUARDAR"
            Botones(True, False, False, True, False, False)
            Controles(True, True, True, True, True, True, True, True, True, False)
            txtDocumento.Clear() : txtNombres.Clear() : txtApellidoP.Clear() : txtApellidoM.Clear() : txtCorreo.Clear() : txtClave.Clear() : txtDocumento.Focus()
        Else
            If Len(Trim(txtDocumento.Text)) = 0 Or Len(Trim(txtDocumento.Text)) <> 8 Then
                MessageBox.Show("DNI Incorrecto" & vbCrLf & "Deben ser 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Focus()
                Exit Sub
            End If
            If Len(Trim(txtNombres.Text)) = 0 Then
                MessageBox.Show("Falta Nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNombres.Focus()
                Exit Sub
            End If
            If Len(Trim(txtApellidoP.Text)) = 0 Then
                MessageBox.Show("Falta Apellido Paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtApellidoP.Focus()
                Exit Sub
            End If
            If Len(Trim(txtApellidoM.Text)) = 0 Then
                MessageBox.Show("Falta Apellido Materno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtApellidoM.Focus()
                Exit Sub
            End If
            If Val(txtClave.Text) < 0 Then
                MessageBox.Show("Falta una clave para inicio de sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtClave.Clear() : txtClave.Focus()
                Exit Sub
            End If
            Dim coUsuariosAgregar As New SqlCommand("dbo.UsuariosAgregarRegistro", cn)

            Dim fun As String = cboFuncion.Text
            Dim funcionCodigo As Integer
            funcionCodigo = Convert.ToInt32(fun)

            coUsuariosAgregar.CommandType = CommandType.StoredProcedure
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioNombres", SqlDbType.NVarChar, 70, ParameterDirection.Input)).Value = txtNombres.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioApellidoPaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoP.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioApellidoMaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoM.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioClave", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtClave.Text
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioFuncionCodigo", SqlDbType.Int)).Value = funcionCodigo
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            coUsuariosAgregar.Parameters.Add(New SqlParameter("@UsuarioFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coUsuariosAgregar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo insertar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            CrearDataSet()
            LlenarLista()

            btnGuardar.Text = "AGREGAR"
            Botones(True, True, True, False, True, True)
            Controles(False, False, False, False, False, False, False, False, False, True)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If btnEditar.Text = "EDITAR" Then
            btnEditar.Text = "GUARDAR"
            Botones(False, True, False, True, False, False)
            Controles(False, True, True, True, True, True, True, False, True, True)

        Else

            If Len(Trim(txtNombres.Text)) = 0 Then
                MessageBox.Show("Faltan Nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNombres.Focus()
                Exit Sub
            End If

            If Val(txtNombres.Text) < 0 Then
                MessageBox.Show("Faltan Nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Clear() : txtDocumento.Focus()
                Exit Sub
            End If
            Dim coUsuariosEditar As New SqlCommand("dbo.UsuariosEditarRegistro", cn)

            coUsuariosEditar.CommandType = CommandType.StoredProcedure

            Dim fun As String = cboFuncion.Text
            Dim funcionCodigo As Integer
            funcionCodigo = Convert.ToInt32(fun)

            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioNombres", SqlDbType.NVarChar, 70, ParameterDirection.Input)).Value = txtNombres.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioApellidoPaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoP.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioApellidoMaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoM.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioClave", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtClave.Text
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioFuncionCodigo", SqlDbType.Int)).Value = funcionCodigo
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            coUsuariosEditar.Parameters.Add(New SqlParameter("@UsuarioFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coUsuariosEditar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo Editar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            CrearDataSet()
            LlenarLista()

            btnEditar.Text = "EDITAR"
            Botones(True, True, True, False, True, True)
            Controles(False, False, False, False, False, False, False, False, False, True)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Desea eliminar el Usuario " & vbCrLf & txtNombres.Text & "?",
             "Eliminación de registros", MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
             DialogResult.OK Then

            Dim coClientesEliminar As New SqlCommand("dbo.spUsuarioEliminarRegistro", cn)
            coClientesEliminar.CommandType = CommandType.StoredProcedure
            '@ProductosCodigo nchar(5),
            coClientesEliminar.Parameters.Add(New SqlParameter("@UsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Open()
            coClientesEliminar.ExecuteNonQuery()
            cn.Close()
            vPosicion = 0
            CrearDataSet()
            LlenarLista()
            MostrarRegistro()
            MessageBox.Show("Usuario eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        vUsuarioRecuperado = 0
        Dim fUsuariosEliminados As New FrmEliminadosUsuarios
        fUsuariosEliminados.ShowDialog()
        'Regreso de la recuperación
        If vUsuarioRecuperado = 1 Then
            CrearDataSet()
            MostrarRegistro()
            LlenarLista()
        End If
        If (fUsuariosEliminados.Visible = False) Then
            CrearDataSet()
            MostrarRegistro()
            LlenarLista()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class