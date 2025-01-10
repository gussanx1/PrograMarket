Imports System.Data.SqlClient

Public Class FrmCategorias
    Dim conexion As SqlConnection
    Dim dsDatos As DataSet
    Dim daCategoria As SqlDataAdapter
    Dim daCompras As SqlDataAdapter
    Dim vPosicion As Integer


    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CrearDataSet()

        MostrarCategoriasEnLaTabla()
        LimpiarTextos()
        LlenarLista()


    End Sub

    Private Sub CrearDataSet()
        conexion = New SqlConnection(cCadena)
        dsDatos = New DataSet
        'Adaptadores
        daCategoria = New SqlDataAdapter("spCategoriasSinBorrados", conexion)
        daCategoria.Fill(dsDatos, "dbMiniMarket.Categoria")

        cboEstadoCategoria.StartIndex = -1


    End Sub

    Private Sub MostrarCategoriasEnLaTabla()

        txtDescripcion.Text = dsDatos.Tables("dbMiniMarket.Categoria").Rows(vPosicion).Item("CategoriaDescripcion").ToString
        dtpFechaInicial.Text = dsDatos.Tables("dbMiniMarket.Categoria").Rows(vPosicion).Item("CategoriaFechaRegistro").ToString
        'ComboBox
        cboEstadoCategoria.Text = dsDatos.Tables("dbMiniMarket.Categoria").Rows(vPosicion).Item("CategoriaEstado").ToString
    End Sub

    Private Sub LlenarLista()
        lvCategoria.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("dbMiniMarket.Categoria").Rows.Count - 1
            lvCategoria.Items.Add(dsDatos.Tables("dbMiniMarket.Categoria").Rows(i).Item("CategoriaId").ToString)
            lvCategoria.Items(i).SubItems.Add(dsDatos.Tables("dbMiniMarket.Categoria").Rows(i).Item("CategoriaDescripcion").ToString)
            lvCategoria.Items(i).SubItems.Add(dsDatos.Tables("dbMiniMarket.Categoria").Rows(i).Item("CategoriaEstado").ToString)
            lvCategoria.Items(i).SubItems.Add(dsDatos.Tables("dbMiniMarket.Categoria").Rows(i).Item("CategoriaFechaRegistro").ToString)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LimpiarTextos()
        txtDescripcion.Text = ""
        cboEstadoCategoria.StartIndex = -1
        dtpFechaInicial.Text = Date.Now

    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        LimpiarTextos()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim coCateAgregar As New SqlCommand("CategoriasAgregarRegistro", conexion)
        coCateAgregar.CommandType = CommandType.StoredProcedure



        ' 2. Parámetros si los tuviera.
        ' Para cada parámetro: Nombre, Tipo de dato, Tamaño (sólo para texto), Dirección, Valor


        coCateAgregar.Parameters.Add(New SqlParameter("@CategoriaDescripcion", SqlDbType.NVarChar, 70, ParameterDirection.Input)).Value = txtDescripcion.Text
        coCateAgregar.Parameters.Add(New SqlParameter("@CategoriaEstado", SqlDbType.NChar, 25, ParameterDirection.Input)).Value = cboEstadoCategoria.Text
        coCateAgregar.Parameters.Add(New SqlParameter("@CategoriaFechaRegistro", SqlDbType.Date, 25, ParameterDirection.Input)).Value = dtpFechaInicial.Text.ToString


        If conexion.State <> ConnectionState.Closed Then
            conexion.Close()
        End If
        Try
            conexion.Open()
            coCateAgregar.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("NO se pudo agregar el registro")
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        txtDescripcion.Clear()
        cboEstadoCategoria.StartIndex = -1
        dtpFechaInicial.Text = Date.Now
        CrearDataSet()
        LlenarLista()


    End Sub

    Private Sub MaterialListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCategoria.SelectedIndexChanged
        If lvCategoria.SelectedItems.Count = 0 Then Exit Sub
        For i As Integer = 0 To dsDatos.Tables("dbMiniMarket.Categoria").Rows.Count - 1
            If lvCategoria.SelectedItems(0).Text = dsDatos.Tables("dbMiniMarket.Categoria").Rows(i).Item("CategoriaId").ToString Then
                vPosicion = i
                Exit For
            End If
        Next

    End Sub

End Class