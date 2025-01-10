Imports System.Data.SqlClient

Public Class FormCompra
    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daCompra As SqlDataAdapter
    Dim daUsuario As SqlDataAdapter
    Dim daProveedor As SqlDataAdapter
    Dim vPosicion As Integer

    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarRegistro()
        LlenarDatos()
        Botones(True, True, True)
    End Sub



    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean)
        cmdRegistrar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
    End Sub

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        'Adaptadores

        daCompra = New SqlDataAdapter("spCompraListasSinBorrados", cn)
        daUsuario = New SqlDataAdapter("spUsuarioListaSinBorradosCompra", cn)
        daProveedor = New SqlDataAdapter("psProveedorListaSinBorradosCompra", cn)
        daCompra.Fill(dsDatos, "Compra")
        daUsuario.Fill(dsDatos, "Usuario")
        daProveedor.Fill(dsDatos, "Proveedor")
        'Ver los datos en el ComboBox
        'Proveedor
        cboProveedor.DataSource = dsDatos.Tables("Proveedor")
        cboProveedor.DisplayMember = "ProveedorDocumentoIdentidad"
        cboProveedor.ValueMember = "ProveedorDocumentoIdentidad"
        'Uusuario
        cboUsuario.DataSource = dsDatos.Tables("Usuario")
        cboUsuario.DisplayMember = "UsuarioDocumentoIdentidad"
        cboUsuario.ValueMember = "UsuarioDocumentoIdentidad"
    End Sub

    Private Sub MostrarRegistro()
        dtpFecha.Text = dsDatos.Tables("Compra").Rows(vPosicion).Item("CompraFechaRegistro").ToString
        txtNComprobante.Text = dsDatos.Tables("Compra").Rows(vPosicion).Item("CompraNumeroComprobante").ToString
        cboProveedor.SelectedValue = dsDatos.Tables("Compra").Rows(vPosicion).Item("CompraProveedorDocumentoIdentidad").ToString
        cboUsuario.SelectedValue = dsDatos.Tables("Compra").Rows(vPosicion).Item("CompraUsuarioDocumentoIdentidad").ToString
        Dim comprobante As String = dsDatos.Tables("Compra").Rows(vPosicion).Item("CompraTipoComprobante").ToString
        If comprobante.Equals("Boleta") Then
            cboTipoComprobante.SelectedIndex = 0
        End If
        If comprobante.Equals("Factura") Then
            cboTipoComprobante.SelectedIndex = 1
        End If

    End Sub

    Private Sub LlenarDatos()
        lvCompra.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Compra").Rows.Count - 1
            lvCompra.Items.Add(dsDatos.Tables("Compra").Rows(i).Item("CompraNumeroComprobante").ToString)
            lvCompra.Items(i).SubItems.Add(dsDatos.Tables("Compra").Rows(i).Item("CompraTipoComprobante").ToString)
            lvCompra.Items(i).SubItems.Add(dsDatos.Tables("Compra").Rows(i).Item("CompraUsuarioDocumentoIdentidad").ToString)
            lvCompra.Items(i).SubItems.Add(dsDatos.Tables("Compra").Rows(i).Item("CompraProveedorDocumentoIdentidad").ToString)
            lvCompra.Items(i).SubItems.Add(dsDatos.Tables("Compra").Rows(i).Item("CompraMontoTotal").ToString)
            lvCompra.Items(i).SubItems.Add(Format(dsDatos.Tables("Compra").Rows(i).Item("CompraFechaRegistro").ToString, "Short Date"))
        Next
    End Sub

    Private Sub CompraSeleccion(sender As Object, e As EventArgs) Handles lvCompra.SelectedIndexChanged
        If lvCompra.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Compra").Rows.Count - 1
            If lvCompra.SelectedItems(0).Text = dsDatos.Tables("Compra").Rows(i).Item("CompraNumeroComprobante").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()
    End Sub


    Private Sub CompraAgregar(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        If cmdRegistrar.Text = "AGREGAR" Then
            cmdRegistrar.Text = "GUARDAR"
            Botones(True, False, False)

            txtNComprobante.Clear()
            txtNComprobante.Focus()
        Else
            'Numero Comprobante
            If Len(Trim(txtNComprobante.Text)) = 0 Or Len(Trim(txtNComprobante.Text)) <> 9 Then
                MessageBox.Show("Falta añadir el numero de comprobante" & vbCrLf & "Debe considerar 9 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNComprobante.Focus()
                Exit Sub
            End If

            Dim coCompraAgregar As New SqlCommand("CompraAgregarRegistro", cn)
            coCompraAgregar.CommandType = CommandType.StoredProcedure

            '@CompraNumeroComprobante nchar(9),
            coCompraAgregar.Parameters.Add(New SqlParameter("@CompraNumeroComprobante ", SqlDbType.NChar, 9, ParameterDirection.Input)).Value = txtNComprobante.Text
            '@CompraTipoComprobante nvarchar(7)
            coCompraAgregar.Parameters.Add(New SqlParameter("@CompraTipoComprobante", SqlDbType.NVarChar, 7, ParameterDirection.Input)).Value = cboTipoComprobante.SelectedItem.ToString
            'CompraUsuarioDocumentoIdentidad nchar(8),
            coCompraAgregar.Parameters.Add(New SqlParameter("@CompraUsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = cboUsuario.SelectedValue.ToString
            '@CompraProveedorDocumentoIdentidad nchar(8),
            coCompraAgregar.Parameters.Add(New SqlParameter("@CompraProveedorDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = cboProveedor.SelectedValue.ToString
            '@CompraFechaRegistro Date, 
            coCompraAgregar.Parameters.Add(New SqlParameter("@CompraFechaRegistro", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coCompraAgregar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo insertar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try

            CrearDataSet()
            LlenarDatos()

            Botones(True, True, True)
            cmdRegistrar.Text = "AGREGAR"
        End If
    End Sub

    Private Sub compraEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "EDITAR" Then
            cmdEditar.Text = "GUARDAR"
            Botones(False, True, False)
        Else  'Numero Comprobante
            If Len(Trim(txtNComprobante.Text)) = 0 Or Len(Trim(txtNComprobante.Text)) <> 9 Then
                MessageBox.Show("Falta añadir el numero de comprobante" & vbCrLf & "Debe considerar 9 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNComprobante.Focus()
                Exit Sub
            End If

            Dim coCompraEditar As New SqlCommand("CompraEditarRegistro", cn)
            coCompraEditar.CommandType = CommandType.StoredProcedure

            '@CompraNumeroComprobante nchar(9),
            coCompraEditar.Parameters.Add(New SqlParameter("@CompraNumeroComprobante ", SqlDbType.NChar, 9, ParameterDirection.Input)).Value = txtNComprobante.Text
            '@CompraTipoComprobante nvarchar(7)
            coCompraEditar.Parameters.Add(New SqlParameter("@CompraTipoComprobante", SqlDbType.NVarChar, 7, ParameterDirection.Input)).Value = cboTipoComprobante.SelectedItem.ToString
            'CompraUsuarioDocumentoIdentidad nchar(8),
            coCompraEditar.Parameters.Add(New SqlParameter("@CompraUsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = cboUsuario.SelectedValue.ToString
            '@CompraProveedorDocumentoIdentidad nchar(8),
            coCompraEditar.Parameters.Add(New SqlParameter("@CompraProveedorDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = cboProveedor.SelectedValue.ToString
            '@CompraFechaRegistro Date, 
            coCompraEditar.Parameters.Add(New SqlParameter("@CompraFechaRegistro ", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coCompraEditar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo editar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            CrearDataSet()
            LlenarDatos()

            Botones(True, True, True)
            cmdEditar.Text = "AGREGAR"
        End If
    End Sub

    Private Sub CompraEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar el registro de compra N° " & vbCrLf & txtNComprobante.Text & "?",
                          "Eliminación de registros", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
                          DialogResult.OK Then
            Dim coCompraEliminar As New SqlCommand("spCompraEliminarRegistro", cn)
            coCompraEliminar.CommandType = CommandType.StoredProcedure
            '@ProductoCodigo nchar(5),
            coCompraEliminar.Parameters.Add(New SqlParameter("@CompraNumeroComprobante ", SqlDbType.NChar, 9, ParameterDirection.Input)).Value = txtNComprobante.Text
            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Open()
            coCompraEliminar.ExecuteNonQuery()
            cn.Close()
            vPosicion = 0
            CrearDataSet()
            LlenarDatos()
            MostrarRegistro()
            MessageBox.Show("Producto eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        txtNComprobante.Clear()
    End Sub
End Class
