Imports System.Data
Imports System.Data.SqlClient


Public Class Form1

    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim conexion As conexion = New conexion()
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim vPosicion As Integer
    Public vProveedorRecuoerado As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        daClientes = New SqlDataAdapter("spProveedoresListasSinBorrados", cn)
        Dim v = daClientes.Fill(dsDatos, "Proveedor")
    End Sub
    Private Sub MostrarRegistro()
        txtDocumento.Text = dsDatos.Tables("Proveedor").Rows(vPosicion).Item("ProveedorDocumentoIdentidad").ToString
        txtRazonSocial.Text = dsDatos.Tables("Proveedor").Rows(vPosicion).Item("ProveedorRazonSocial").ToString
        txtCorreo.Text = dsDatos.Tables("Proveedor").Rows(vPosicion).Item("ProveedorCorreo").ToString
        txtTelefono.Text = dsDatos.Tables("Proveedor").Rows(vPosicion).Item("ProveedorTelefono").ToString
        cboEstado.Text = dsDatos.Tables("Proveedor").Rows(vPosicion).Item("ProveedorEstado").ToString
    End Sub
    Private Sub LlenarLista()
        lvProveedores.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Proveedor").Rows.Count - 1
            lvProveedores.Items.Add(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorDocumentoIdentidad").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorRazonSocial").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorCorreo").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorTelefono").ToString)
            lvProveedores.Items(i).SubItems.Add(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorEstado").ToString)
            lvProveedores.Items(i).SubItems.Add(Format(dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorFechaRegistro").ToString, "Short Date"))
        Next
    End Sub
    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean, Cancelar As Boolean, Cerrar As Boolean, Ver As Boolean)
        btnGuardar.Enabled = Agregar
        btnEditar.Enabled = Editar
        btnEliminar.Enabled = Eliminar
        btnCancelar.Enabled = Cancelar
        btnVer.Enabled = Ver
    End Sub
    Private Sub Controles(Documento As Boolean, RazonSocial As Boolean, ApellidoP As Boolean, ApellidoM As Boolean, Correo As Boolean,
                          Telefono As Boolean, Estado As Boolean, Fecha As Boolean, Lista As Boolean)
        txtDocumento.Enabled = Documento
        txtRazonSocial.Enabled = RazonSocial

        txtCorreo.Enabled = Correo
        txtTelefono.Enabled = Telefono
        cboEstado.Enabled = Estado
        lvProveedores.Enabled = Lista
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "AGREGAR" Then
            btnGuardar.Text = "GUARDAR"
            Botones(True, False, False, True, False, False)
            Controles(True, True, True, True, True, True, True, True, True)
            txtDocumento.Clear() : txtRazonSocial.Clear() : txtCorreo.Clear() : txtTelefono.Clear()
            txtDocumento.Focus()
        Else
            If Len(Trim(txtDocumento.Text)) = 0 Or Len(Trim(txtDocumento.Text)) <> 8 Then
                MessageBox.Show("Codigo Incorrecto" & vbCrLf & "Deben ser 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Focus()
                Exit Sub
            End If

            If Len(Trim(txtRazonSocial.Text)) = 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRazonSocial.Focus()
                Exit Sub
            End If

            If Val(txtDocumento.Text) < 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Clear() : txtDocumento.Focus()
                Exit Sub
            End If

            Dim coProvedoresAgregar As New SqlCommand("dbo.ProvedorAgregarRegistro", cn)

            coProvedoresAgregar.CommandType = CommandType.StoredProcedure

            '@ProveedorDocumentoIdentidad nchar(11),
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            '@ProveedorRazonSocial nvarchar(30),
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorRazonSocial", SqlDbType.NVarChar, 30, ParameterDirection.Input)).Value = txtRazonSocial.Text
            '@ProveedorCorreo nvarchar(55),
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            '@ProveedorTelefono nvarchar(9),
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtTelefono.Text
            '@ProveedorEstado nchar(1),
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            '@ProveedorFechaRegistro Date
            coProvedoresAgregar.Parameters.Add(New SqlParameter("@ProveedorFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coProvedoresAgregar.ExecuteNonQuery()
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If btnEditar.Text = "EDITAR" Then
            btnEditar.Text = "GUARDAR"
            Botones(False, True, False, True, False, False)
            Controles(False, True, True, True, True, True, False, True, True)
        Else
            If Len(Trim(txtRazonSocial.Text)) = 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRazonSocial.Focus()
                Exit Sub
            End If

            If Val(txtDocumento.Text) < 0 Then
                MessageBox.Show("Falta Razon Social", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDocumento.Clear() : txtDocumento.Focus()
                Exit Sub
            End If

            Dim coProvedoresEditar As New SqlCommand("dbo.ProvedorEditarRegistro", cn)

            coProvedoresEditar.CommandType = CommandType.StoredProcedure

            '@ProveedorDocumentoIdentidad nchar(11),
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            '@ProveedorRazonSocial nvarchar(30),
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorRazonSocial", SqlDbType.NVarChar, 30, ParameterDirection.Input)).Value = txtRazonSocial.Text
            '@ProveedorCorreo nvarchar(55),
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorCorreo", SqlDbType.NVarChar, 55, ParameterDirection.Input)).Value = txtCorreo.Text
            '@ProveedorTelefono nvarchar(9),
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorTelefono", SqlDbType.NVarChar, 9, ParameterDirection.Input)).Value = txtTelefono.Text
            '@ProveedorEstado nchar(1),
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorEstado", SqlDbType.NVarChar, 1, ParameterDirection.Input)).Value = "A"
            '@ProveedorFechaRegistro Date
            coProvedoresEditar.Parameters.Add(New SqlParameter("@ProveedorFechaRegistro", SqlDbType.Date)).Value = Date.Now

            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coProvedoresEditar.ExecuteNonQuery()
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("¿Desea eliminar el provedor " & vbCrLf & txtRazonSocial.Text & "?",
                     "Eliminación de registros", MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
                     DialogResult.OK Then

            Dim coProvedoresEliminar As New SqlCommand("dbo.spProvedoresEliminarRegistro", cn)
            coProvedoresEliminar.CommandType = CommandType.StoredProcedure
            '@ProductosCodigo nchar(5),
            coProvedoresEliminar.Parameters.Add(New SqlParameter("@ProveedorDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = txtDocumento.Text
            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Open()
            coProvedoresEliminar.ExecuteNonQuery()
            cn.Close()
            vPosicion = 0
            CrearDataSet()
            LlenarLista()
            MostrarRegistro()
            MessageBox.Show("Proveedor eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        vProveedorRecuoerado = 0
        Dim fProductosEliminados As New FrmEliminadosProveedores
        fProductosEliminados.ShowDialog()
        'Regreso de la recuperación
        If vProveedorRecuoerado = 1 Then
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()

    End Sub

    Private Sub lvProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProveedores.SelectedIndexChanged
        If lvProveedores.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Proveedor").Rows.Count - 1
            If lvProveedores.SelectedItems(0).Text = dsDatos.Tables("Proveedor").Rows(i).Item("ProveedorDocumentoIdentidad").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        CrearDataSet()
        LlenarLista()
        MostrarRegistro()
    End Sub
End Class
