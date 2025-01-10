Imports System.Data.SqlClient
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Productos
    'Zona de declaraciones
    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daProducto As SqlDataAdapter
    Dim daCategoria As SqlDataAdapter
    Dim daProveedores As SqlDataAdapter
    Dim vPosicion As Integer

    Private Sub ProductosCarga(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim material = materialSkinManager
        material = MaterialSkin.MaterialSkinManager.Instance
        material.EnforceBackcolorOnAllComponents = True
        material.AddFormToManage(Me)
        material.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        material.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo100, MaterialSkin.Primary.Blue800, MaterialSkin.TextShade.WHITE)
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

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        'Adaptadores
        daProducto = New SqlDataAdapter("spProductoListasSinBorrados", cn)
        daCategoria = New SqlDataAdapter("spCategoriaListaSinBorradosProducto", cn)
        daProducto.Fill(dsDatos, "Producto")
        daCategoria.Fill(dsDatos, "Categoria")
        'Ver los datos en el ComboBox
        'Categorias
        cboCategorias.DataSource = dsDatos.Tables("Categoria")
        cboCategorias.DisplayMember = "CategoriaId"
        cboCategorias.ValueMember = "CategoriaId"
    End Sub

    Private Sub MostrarRegistro()
        txtCodigoProducto.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoCodigo").ToString
        txtDescripcion.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoDescripcion").ToString
        txtMedidaProducto.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoMedida").ToString
        'Seleccionar categoria
        cboCategorias.SelectedValue = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoCategoriaId").ToString
        txtStock.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoStock").ToString
        txtPrecioCompra.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoPrecioCompra").ToString
        txtPrecioVenta.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoPrecioVenta").ToString
        'ESTADO
        Dim Estado As String = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoEstado").ToString
        If Estado.Equals("A") Then
            cbEstadoProducto.SelectedIndex = 0
        End If
        If Estado.Equals("N") Then
            cbEstadoProducto.SelectedIndex = 1
        End If
        dtpFecha.Text = dsDatos.Tables("Producto").Rows(vPosicion).Item("ProductoFechaRegistro").ToString
    End Sub

    Private Sub LlenarLista()
        lvProducto.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Producto").Rows.Count - 1
            lvProducto.Items.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoCodigo").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoDescripcion").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoEstado").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoStock").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoPrecioCompra").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoPrecioVenta").ToString)
            lvProducto.Items(i).SubItems.Add(dsDatos.Tables("Producto").Rows(i).Item("ProductoCategoriaId").ToString)
            lvProducto.Items(i).SubItems.Add(Format(dsDatos.Tables("Producto").Rows(i).Item("ProductoFechaRegistro").ToString, "Short Date"))
        Next
    End Sub

    Private Sub ProductoSeleccion(sender As Object, e As EventArgs) Handles lvProducto.SelectedIndexChanged
        If lvProducto.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("Producto").Rows.Count - 1
            If lvProducto.SelectedItems(0).Text = dsDatos.Tables("Producto").Rows(i).Item("ProductoCodigo").ToString Then
                vPosicion = i
                Exit For
            End If
        Next
        MostrarRegistro()
    End Sub
    Private Sub ProductosAgregar(sender As Object, e As EventArgs) Handles cmdRegistrar.Click
        If cmdRegistrar.Text = "AGREGAR" Then
            cmdRegistrar.Text = "GUARDAR"
            Botones(True, False, False)

            txtCodigoProducto.Clear() : txtDescripcion.Clear() : txtMedidaProducto.Clear() : cbEstadoProducto.SelectedIndex = 0 : txtStock.Clear() : txtPrecioCompra.Clear() : txtPrecioVenta.Clear()
            txtCodigoProducto.Focus()
        Else  'Guardar
            'Consistencias a los datos
            'Código
            If Len(Trim(txtCodigoProducto.Text)) = 0 Or Len(Trim(txtCodigoProducto.Text)) <> 5 Then
                MessageBox.Show("Código ingresado incorrecto" & vbCrLf & "Debe considerar 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigoProducto.Focus()
                Exit Sub
            End If
            'Descripción
            If Len(Trim(txtDescripcion.Text)) = 0 Then
                MessageBox.Show("Falta la Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDescripcion.Focus()
                Exit Sub
            End If
            'Medida
            If Len(Trim(txtMedidaProducto.Text)) = 0 Then
                MessageBox.Show("Falta ingresar Medida de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMedidaProducto.Focus()
                Exit Sub
            End If
            'Cat
            'Stock
            If Len(Trim(txtStock.Text)) = 0 Then
                MessageBox.Show("Falta ingresar Stock de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStock.Focus()
                Exit Sub
            End If
            'Precio Compra
            If Val(txtPrecioCompra.Text) < 0 Then
                MessageBox.Show("Precio compra inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrecioCompra.Clear() : txtPrecioCompra.Focus()
                Exit Sub
            End If
            'Precio Venta
            If Val(txtPrecioVenta.Text) < 0 Then
                MessageBox.Show("Precio venta inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrecioVenta.Clear() : txtPrecioVenta.Focus()
                Exit Sub

            End If


            'Consumir el SP
            '@ProductosCodigo nchar(5), 
            '@ProductosDescripcion nvarchar(100), 
            '@ProductosCategoriasCodigo nchar(4), 
            '@ProductosPrecio Numeric(9,2), 
            '@ProductosStock Numeric(9,2), 
            '@ProductosEstado nchar(1), 
            '@ProductosFechaCompra Date, 
            '@ProductosProveedoresCodigo nchar(5)
            ' 1. Crear Comando - SQLCommand: Nombre del SP, Conexión, Tipo
            ' 2. Parámetros si los tuviera.
            ' 3. Usar ExecuteNonQuery (cuidado con EndExecuteNonQuery)

            'DESARROLLO
            ' 1. Crear Comando - SQLCommand: Nombre del SP, Conexión, Tipo
            Dim coProductoAgregar As New SqlCommand("ProductoAgregarRegistro", cn)
            coProductoAgregar.CommandType = CommandType.StoredProcedure

            ' 2. Parámetros si los tuviera.
            ' Para cada parámetro: Nombre, Tipo de dato, Tamaño (sólo para texto), Dirección, Valor
            '@ProductoCodigo nchar(5)
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoCodigo", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = txtCodigoProducto.Text
            '@ProductoDescripcion nvarchar(50)
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoDescripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtDescripcion.Text
            '@ProductoMedida nvarchar(50)
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoMedida", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtMedidaProducto.Text
            '@ProductoCategoriaId int
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoCategoriaId", SqlDbType.Int)).Value = cboCategorias.SelectedValue.ToString
            '@ProductoStock numeric(9,2) 
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoStock", SqlDbType.Decimal)).Value = txtStock.Text
            '@ProductoPrecioCompra numeric(9,2)
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoPrecioCompra", SqlDbType.Decimal)).Value = txtPrecioCompra.Text
            '@ProductoPrecioVenta numeric(9,2)
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoPrecioVenta", SqlDbType.Decimal)).Value = txtPrecioVenta.Text

            '@ProductoEstado nchar(1), 
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = cbEstadoProducto.SelectedItem.ToString

            '@ProductoFechaCompra Date, 
            coProductoAgregar.Parameters.Add(New SqlParameter("@ProductoFechaRegistro ", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coProductoAgregar.ExecuteNonQuery()
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

    Private Sub ProductosEditar(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "EDITAR" Then
            cmdEditar.Text = "GUARDAR"
            Botones(False, True, False)
        Else  'Guardar
            If Len(Trim(txtCodigoProducto.Text)) = 0 Or Len(Trim(txtCodigoProducto.Text)) <> 5 Then
                MessageBox.Show("Código ingresado incorrecto" & vbCrLf & "Debe considerar 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigoProducto.Focus()
                Exit Sub
            End If
            'Descripción
            If Len(Trim(txtDescripcion.Text)) = 0 Then
                MessageBox.Show("Falta la Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDescripcion.Focus()
                Exit Sub
            End If
            'Medida
            If Len(Trim(txtMedidaProducto.Text)) = 0 Then
                MessageBox.Show("Falta ingresar Medida de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMedidaProducto.Focus()
                Exit Sub
            End If
            'Cat
            'Stock
            If Len(Trim(txtStock.Text)) = 0 Then
                MessageBox.Show("Falta ingresar Stock de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStock.Focus()
                Exit Sub
            End If
            'Precio Compra
            If Val(txtPrecioCompra.Text) < 0 Then
                MessageBox.Show("Precio compra inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrecioCompra.Clear() : txtPrecioCompra.Focus()
                Exit Sub
            End If
            'Precio Venta
            If Val(txtPrecioVenta.Text) < 0 Then
                MessageBox.Show("Precio venta inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrecioVenta.Clear() : txtPrecioVenta.Focus()
                Exit Sub
            End If
            'Fecha
            If Val(dtpFecha.Text) < 0 Then
                MessageBox.Show("Falta ingreso de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrecioVenta.Clear() : txtPrecioVenta.Focus()
                Exit Sub
            End If

            'Consumir el SP
            '@ProductosCodigo nchar(5), 
            '@ProductosDescripcion nvarchar(100), 
            '@ProductosCategoriasCodigo nchar(4), 
            '@ProductosPrecio Numeric(9,2), 
            '@ProductosStock Numeric(9,2), 
            '@ProductosFechaCompra Date, 
            '@ProductosProveedoresCodigo nchar(5)
            ' 1. Crear Comando - SQLCommand: Nombre del SP, Conexión, Tipo
            ' 2. Parámetros si los tuviera.
            ' 3. Usar ExecuteNonQuery (cuidado con EndExecuteNonQuery)

            'DESARROLLO
            ' 1. Crear Comando - SQLCommand: Nombre del SP, Conexión, Tipo
            Dim coProductoEditar As New SqlCommand("ProductoEditarRegistro", cn)
            coProductoEditar.CommandType = CommandType.StoredProcedure

            ' 2. Parámetros si los tuviera.
            ' Para cada parámetro: Nombre, Tipo de dato, Tamaño (sólo para texto), Dirección, Valor
            '@ProductoCodigo nchar(5)
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoCodigo", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = txtCodigoProducto.Text
            '@ProductoDescripcion nvarchar(50)
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoDescripcion", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtDescripcion.Text
            '@ProductoMedida nvarchar(50)
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoMedida", SqlDbType.NVarChar, 50, ParameterDirection.Input)).Value = txtMedidaProducto.Text
            '@ProductoCategoriaId int
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoCategoriaId", SqlDbType.Int)).Value = cboCategorias.SelectedValue.ToString
            '@ProductoStock numeric(9,2) 
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoStock", SqlDbType.Decimal)).Value = txtStock.Text
            '@ProductoPrecioCompra numeric(9,2)
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoPrecioCompra", SqlDbType.Decimal)).Value = txtPrecioCompra.Text
            '@ProductoPrecioVenta numeric(9,2)
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoPrecioVenta", SqlDbType.Decimal)).Value = txtPrecioVenta.Text

            '@ProductoEstado nchar(1), 
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoEstado", SqlDbType.NChar, 1, ParameterDirection.Input)).Value = cbEstadoProducto.SelectedItem.ToString

            '@ProductoFechaCompra Date, 
            coProductoEditar.Parameters.Add(New SqlParameter("@ProductoFechaRegistro ", SqlDbType.Date)).Value = dtpFecha.Text

            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            Try
                cn.Open()
                coProductoEditar.ExecuteNonQuery()
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

    Private Sub ProductosEliminar(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If MessageBox.Show("¿Desea eliminar el producto " & vbCrLf & txtDescripcion.Text & "?",
                          "Eliminación de registros", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
                          DialogResult.OK Then
            Dim coProductoEliminar As New SqlCommand("spProductoEliminarRegistro", cn)
            coProductoEliminar.CommandType = CommandType.StoredProcedure
            '@ProductoCodigo nchar(5),
            coProductoEliminar.Parameters.Add(New SqlParameter("@ProductoCodigo", SqlDbType.NChar, 5, ParameterDirection.Input)).Value = txtCodigoProducto.Text
            ' Abrir la conexión
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
            cn.Open()
            coProductoEliminar.ExecuteNonQuery()
            cn.Close()
            vPosicion = 0
            CrearDataSet()
            LlenarLista()
            MostrarRegistro()
            MessageBox.Show("Producto eliminado", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        txtCodigoProducto.Clear() : txtDescripcion.Clear() : txtMedidaProducto.Clear() : txtStock.Clear() : txtPrecioCompra.Clear() : txtPrecioVenta.Clear() : txtCodigoBuscar.Clear()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Dim tipo As String = cbBuscarPor.SelectedItem.ToString
        If tipo.Equals("Codigo") Then
            Dim indice As Integer = 0
            For i As Integer = 0 To dsDatos.Tables("Producto").Rows.Count - 1
                If txtCodigoBuscar.Text = dsDatos.Tables("Producto").Rows(i).Item("ProductoCodigo").ToString Then
                    indice = i
                End If
            Next
            txtCodigoProducto.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoCodigo").ToString
            txtDescripcion.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoDescripcion").ToString
            txtMedidaProducto.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoMedida").ToString
            'Seleccionar categoria
            cboCategorias.SelectedValue = dsDatos.Tables("Producto").Rows(indice).Item("ProductoCategoriaId").ToString
            txtStock.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoStock").ToString
            txtPrecioCompra.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioCompra").ToString
            txtPrecioVenta.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioVenta").ToString
            'ESTADO
            Dim Estado As String = dsDatos.Tables("Producto").Rows(indice).Item("ProductoEstado").ToString
            If Estado.Equals("A") Then
                cbEstadoProducto.SelectedIndex = 0
            Else
                cbEstadoProducto.SelectedIndex = 1
            End If
            dtpFecha.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoFechaRegistro").ToString

        Else
            Dim indice As Integer = 0
            For i As Integer = 0 To dsDatos.Tables("Producto").Rows.Count - 1
                If txtCodigoBuscar.Text = dsDatos.Tables("Producto").Rows(i).Item("ProductoDescripcion").ToString Then
                    indice = i
                End If
            Next
            txtCodigoProducto.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoCodigo").ToString
            txtDescripcion.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoDescripcion").ToString
            txtMedidaProducto.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoMedida").ToString
            'Seleccionar categoria
            cboCategorias.SelectedValue = dsDatos.Tables("Producto").Rows(indice).Item("ProductoCategoriaId").ToString
            txtStock.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoStock").ToString
            txtPrecioCompra.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioCompra").ToString
            txtPrecioVenta.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoPrecioVenta").ToString
            'ESTADO
            Dim Estado As String = dsDatos.Tables("Producto").Rows(indice).Item("ProductoEstado").ToString
            If Estado.Equals("A") Then
                cbEstadoProducto.SelectedIndex = 0
            Else
                cbEstadoProducto.SelectedIndex = 1
            End If
            dtpFecha.Text = dsDatos.Tables("Producto").Rows(indice).Item("ProductoFechaRegistro").ToString
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim fProductosEliminados As New FrmEliminadosClientes
        fProductosEliminados.ShowDialog()

        If (fProductosEliminados.Visible = False) Then
            CrearDataSet()
            MostrarRegistro()
            LlenarLista()
        End If
    End Sub
End Class
