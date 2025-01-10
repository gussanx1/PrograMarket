Imports System.Data.SqlClient

Public Class FrmDetalleCompra
    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daDetalleCompra As SqlDataAdapter
    Dim daProducto As SqlDataAdapter
    Dim daCompra As SqlDataAdapter
    Dim vPosicion As Integer
    Shared indice As Integer
    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daDetalleCompra = New SqlDataAdapter("spDetalleCompraListasSinBorrados", cn)
        daCompra = New SqlDataAdapter("spCompraListaSinBorradosDetalleCompra", cn)
        daProducto = New SqlDataAdapter("spProductoListaSinBorrarDetalle", cn)
        daDetalleCompra.Fill(dsDatos, "DetalleCompra")
        daCompra.Fill(dsDatos, "Compra")
        daProducto.Fill(dsDatos, "Producto")
        'DATOS COMBO BOX
        'COMPRA
        cboNComprobanteCompra.DataSource = dsDatos.Tables("Compra")
        cboNComprobanteCompra.DisplayMember = "CompraNumeroComprobante"
        cboNComprobanteCompra.ValueMember = "CompraNumeroComprobante"
        'Uusuario
        cboCodProducto.DataSource = dsDatos.Tables("Producto")
        cboCodProducto.DisplayMember = "ProductoCodigo"
        cboCodProducto.ValueMember = "ProductoCodigo"

    End Sub

    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        MostrarRegistro()
        LlenarLista()
        Botones(True, True, True)
    End Sub

    Private Sub Botones(Agregar As Boolean, Editar As Boolean, Eliminar As Boolean)
        cmdRegistrar.Enabled = Agregar
        cmdEditar.Enabled = Editar
        cmdEliminar.Enabled = Eliminar
    End Sub

    Private Sub MostrarRegistro()
        txtIdDetalleCompra.Text = dsDatos.Tables("DetalleCompra").Rows(vPosicion).Item("DetalleCompraId").ToString

        'Seleccionar Numero Comprobante
        cboNComprobanteCompra.SelectedValue = dsDatos.Tables("DetalleCompra").Rows(vPosicion).Item("DetalleCompraCompraNumeroComprobante").ToString
        'FECHA REGISTRO
        dtpFecha.Text = dsDatos.Tables("DetalleCompra").Rows(vPosicion).Item("DetalleCompraFechaRegistro").ToString
        'Seleccionar CodigoProducto
        cboCodProducto.SelectedValue = dsDatos.Tables("DetalleCompra").Rows(vPosicion).Item("DetalleCompraProductoCodigo").ToString
    End Sub

    Private Sub LlenarLista()
        lvDetalleCompra.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("DetalleCompra").Rows.Count - 1
            lvDetalleCompra.Items.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraId").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraCompraNumeroComprobante").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraProductoCodigo").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraPrecioCompra").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraCantidad").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraCantidadPrecioCompra").ToString)
            lvDetalleCompra.Items(i).SubItems.Add(Format(dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraFechaRegistro").ToString, "Short Date"))
        Next
    End Sub

    Private Sub lvDetalleCompraSeleccion(sender As Object, e As EventArgs) Handles lvDetalleCompra.SelectedIndexChanged
        If lvDetalleCompra.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("DetalleCompra").Rows.Count - 1
            If lvDetalleCompra.SelectedItems(0).Text = dsDatos.Tables("DetalleCompra").Rows(i).Item("DetalleCompraId").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()
    End Sub

    Private Sub DetalleCompraAgregar(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        If cmdRegistrar.Text = "AGREGAR" Then
            cmdRegistrar.Text = "GUARDAR"
            Botones(True, False, False)
            txtIdDetalleCompra.Clear() : txtPrecioCompra.Clear() : txtPrecioVenta.Clear() : cboCodProducto.SelectedIndex = 0 : cboCodProducto.SelectedIndex = 0
            txtIdDetalleCompra.Focus()
        Else
            If Len(Trim(txtIdDetalleCompra.Text)) = 0 Then
                MessageBox.Show("Código invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdDetalleCompra.Focus()
                Exit Sub
            End If

            Dim coDetalleCompraAgregar As New SqlCommand("DetalleCompraAgregarRegistro", cn)
            coDetalleCompraAgregar.CommandType = CommandType.StoredProcedure

            '@DetalleCompraId int 
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraId", SqlDbType.Int, ParameterDirection.Input)).Value = txtIdDetalleCompra.Text
            '@DetalleCompraCompraNumeroComprobante nchar(9),
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraCompraNumeroComprobante", SqlDbType.NChar, 9, ParameterDirection.Input)).Value = cboNComprobanteCompra.SelectedValue.ToString
            'DetalleCompraProductoCodigo nchar(5),
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraProductoCodigo", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = cboCodProducto.ToString
            'DetalleCompraPrecioCompra numeric(9,2)
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraPrecioCompra", SqlDbType.Decimal)).Value = txtPrecioCompra.Text
            '@DetalleCompraPrecioVenta numeric(9,2)
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraPrecioVenta", SqlDbType.Decimal)).Value = txtPrecioVenta.Text
            '@DetalleCompraCantidad numeric(9,2) 
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraCantidad", SqlDbType.Decimal)).Value = txtCantidad.Value.ToString

            '@DetalleCompraFechaRegistro date 
            coDetalleCompraAgregar.Parameters.Add(New SqlParameter("@DetalleCompraFechaRegistro ", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coDetalleCompraAgregar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo insertar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try


            CrearDataSet()
            LlenarLista()

            Botones(True, True, True)
            cmdRegistrar.Text = "AGREGAR"
        End If
    End Sub

    Private Sub DetalleCompraEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "EDITAR" Then
            cmdEditar.Text = "GUARDAR"
            Botones(False, True, False)
        Else  'Guardar
            If Len(Trim(txtIdDetalleCompra.Text)) = 0 Then
                MessageBox.Show("Código invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdDetalleCompra.Focus()
                Exit Sub
            End If

            Dim coDetalleCompraEditar As New SqlCommand("DetalleCompraEditarRegistro", cn)
            coDetalleCompraEditar.CommandType = CommandType.StoredProcedure

            '@DetalleCompraId int 
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraId", SqlDbType.Int, ParameterDirection.Input)).Value = txtIdDetalleCompra.Text
            '@DetalleCompraCompraNumeroComprobante nchar(9),
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraCompraNumeroComprobante", SqlDbType.NChar, 9, ParameterDirection.Input)).Value = cboNComprobanteCompra.SelectedValue.ToString
            'DetalleCompraProductoCodigo nchar(5),
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraProductoCodigo", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = cboCodProducto.ToString
            'DetalleCompraPrecioCompra numeric(9,2)
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraPrecioCompra", SqlDbType.Decimal)).Value = txtPrecioCompra.Text
            '@DetalleCompraPrecioVenta numeric(9,2)
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraPrecioVenta", SqlDbType.Decimal)).Value = txtPrecioVenta.Text
            '@DetalleCompraCantidad numeric(9,2) 
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraCantidad", SqlDbType.Decimal)).Value = txtCantidad.Value.ToString

            '@DetalleCompraFechaRegistro date 
            coDetalleCompraEditar.Parameters.Add(New SqlParameter("@DetalleCompraFechaRegistro ", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coDetalleCompraEditar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se pudo editar el registro")
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            CrearDataSet()
            LlenarLista()

            Botones(True, True, True)
            cmdEditar.Text = "AGREGAR"
        End If
    End Sub

    Private Sub DetalleCompraEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar el producto " & vbCrLf & txtIdDetalleCompra.Text & "?",
                          "Eliminación de registros", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
                          DialogResult.OK Then
            Dim coDetalleCompraEliminar As New SqlCommand("spDetalleCompraEliminarRegistro", cn)
            coDetalleCompraEliminar.CommandType = CommandType.StoredProcedure

            coDetalleCompraEliminar.Parameters.Add(New SqlParameter("@DetalleCompraId", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = txtIdDetalleCompra.Text
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Open()
            coDetalleCompraEliminar.ExecuteNonQuery()
            cn.Close()
            vPosicion = 0
            CrearDataSet()
            LlenarLista()
            MostrarRegistro()
            MessageBox.Show("Detalle Compra eliminado id ", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        txtIdDetalleCompra.Clear() : txtPrecioCompra.Clear() : txtPrecioVenta.Clear()

    End Sub


    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodProducto.SelectedIndexChanged
        txtPrecioCompra.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioCompra").ToString
        txtPrecioVenta.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioVenta").ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
