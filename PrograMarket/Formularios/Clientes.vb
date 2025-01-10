Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection

Public Class Clientes

    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim vPosicion As Integer
    Public vClienteRecuoerado As Integer = 0

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Controles(False, False, False, False, False, False, False, False, True)
    End Sub
    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("spClientesListasSinBorrados", cn)
        daClientes.Fill(dsDatos, "Cliente")
    End Sub
    Private Sub MostrarRegistro()
        txtDocumento.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteDocumentoIdentidad").ToString
        txtNombres.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteNombres").ToString
        txtApellidoP.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteApellidoPaterno").ToString
        txtApellidoM.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteApellidoMaterno").ToString
        txtCorreo.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteCorreo").ToString
        txtTelefono.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteTelefono").ToString
        cboEstado.Text = dsDatos.Tables("Cliente").Rows(vPosicion).Item("ClienteEstado").ToString
    End Sub
    Private Sub LlenarLista()
        lvClientes.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            lvClientes.Items.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteDocumentoIdentidad").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteNombres").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteApellidoPaterno").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteApellidoMaterno").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteCorreo").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteTelefono").ToString)
            lvClientes.Items(i).SubItems.Add(dsDatos.Tables("Cliente").Rows(i).Item("ClienteEstado").ToString)
            lvClientes.Items(i).SubItems.Add(Format(dsDatos.Tables("Cliente").Rows(i).Item("ClienteFechaRegistro").ToString, "Short Date"))
        Next
    End Sub
    Private Sub lvClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvClientes.SelectedIndexChanged
        If lvClientes.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Cliente").Rows.Count - 1
            If lvClientes.SelectedItems(0).Text = dsDatos.Tables("Cliente").Rows(i).Item("ClienteDocumentoIdentidad").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()
    End Sub

    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Cerrar As Boolean, Ver As Boolean)
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnEliminar.Enabled = Eliminar
        btnCancelar.Enabled = Cancelar
        btnVer.Enabled = Ver
    End Sub

    Private Sub Controles(Documento As Boolean, Nombres As Boolean, ApellidoP As Boolean, ApellidoM As Boolean, Correo As Boolean,
                          Telefono As Boolean, Estado As Boolean, Fecha As Boolean, Lista As Boolean)
        txtDocumento.Enabled = Documento
        txtNombres.Enabled = Nombres
        txtApellidoP.Enabled = ApellidoP
        txtApellidoM.Enabled = ApellidoM
        txtCorreo.Enabled = Correo
        txtTelefono.Enabled = Telefono
        cboEstado.Enabled = Estado
        lvClientes.Enabled = Lista
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "AGREGAR" Then
            btnGuardar.Text = "GUARDAR"
            Botones(True, False, False, True, False, False)
            Controles(True, True, True, True, True, True, True, True, False)
            txtDocumento.Clear() : txtNombres.Clear() : txtApellidoP.Clear() : txtApellidoM.Clear() : txtCorreo.Clear() : txtTelefono.Clear() : txtDocumento.Focus()
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
            If Val(txtDocumento.Text) < 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Clear() : txtDocumento.Focus()
                Exit Sub
            End If
            Dim coClientesAgregar As New SqlCommand("dbo.ClienteAgregarRegistro", cn)

            coClientesAgregar.CommandType = CommandType.StoredProcedure
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteNombres", SqlDbType.NVarChar, 70, ParameterDirection.Input)).Value = txtNombres.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteApellidoPaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoP.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteApellidoMaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoM.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtTelefono.Text
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            coClientesAgregar.Parameters.Add(New SqlParameter("@ClienteFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coClientesAgregar.ExecuteNonQuery()
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
            Controles(False, False, False, False, False, False, False, False, True)
        End If
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FiveCodImageButton1_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If btnEditar.Text = "EDITAR" Then
            btnEditar.Text = "GUARDAR"
            Botones(False, True, False, True, False, False)
            Controles(False, True, True, True, True, True, False, True, True)

        Else

            If Len(Trim(txtNombres.Text)) = 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNombres.Focus()
                Exit Sub
            End If

            If Val(txtDocumento.Text) < 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Clear() : txtDocumento.Focus()
                Exit Sub
            End If
            Dim coClientesEditae As New SqlCommand("dbo.ClienteEditarRegistro", cn)

            coClientesEditae.CommandType = CommandType.StoredProcedure

            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteNombres", SqlDbType.NVarChar, 70, ParameterDirection.Input)).Value = txtNombres.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteApellidoPaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoP.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteApellidoMaterno", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtApellidoM.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtTelefono.Text
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            coClientesEditae.Parameters.Add(New SqlParameter("@ClienteFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coClientesEditae.ExecuteNonQuery()
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
            Controles(False, False, False, False, False, False, False, False, True)
        End If
    End Sub

    Private Sub FiveCodImageButton1_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Desea eliminar el cliente " & vbCrLf & txtNombres.Text & "?",
             "Eliminación de registros", MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
             DialogResult.OK Then

            Dim coClientesEliminar As New SqlCommand("dbo.spClientesEliminarRegistro", cn)
            coClientesEliminar.CommandType = CommandType.StoredProcedure
            '@ProductosCodigo nchar(5),
            coClientesEliminar.Parameters.Add(New SqlParameter("@ClienteDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
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
            MessageBox.Show("Cliente eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FiveCodImageButton3_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnVer_Click_1(sender As Object, e As EventArgs) Handles btnVer.Click
        vClienteRecuoerado = 0
        Dim fProductosEliminados As New FrmEliminadosClientes
        fProductosEliminados.ShowDialog()
        'Regreso de la recuperación
        If vClienteRecuoerado = 1 Then
            CrearDataSet()
            MostrarRegistro()
            LlenarLista()
        End If

        If (fProductosEliminados.Visible = False) Then
            CrearDataSet()
            MostrarRegistro()
            LlenarLista()
        End If
    End Sub
End Class
