Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader

Public Class FrmReporteVentas

    Dim conexion As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim daCompras As SqlDataAdapter


    Private Sub FrmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CrearDataSet()
        Controles(True, True, True)
        Botones(True, True, True)
        mostrarTbla()

    End Sub

    Private Sub CrearDataSet()
        conexion = New SqlConnection(cCadena)
        dsDatos = New DataSet
        'Adaptadores
        daClientes = New SqlDataAdapter("spClientesReporteVentas", conexion)
        daClientes.Fill(dsDatos, "dbMiniMarket.Cliente")
        'Ver los datos en el ComboBox de Proveedores
        cboClientes.DataSource = dsDatos.Tables("dbMiniMarket.Cliente")
        cboClientes.DisplayMember = "ClienteDocumentoIdentidad"
        cboClientes.StartIndex = -1
        conexion.Close()
    End Sub

    Private Sub limpiarTextos()
        cboClientes.StartIndex = -1
        dtpFechaInicial.Text = Date.Now
        dtpFechaFinal.Text = Date.Now
    End Sub
    Private Sub Botones(Buscar As Boolean, MostrarTodos As Boolean, Descargar As Boolean)
        btnBuscar.Enabled = Buscar
        btnTodos.Enabled = MostrarTodos
        btnExportarExcel.Enabled = Descargar
    End Sub
    Private Sub Controles(FechatInicial As Boolean, FechaFinal As Boolean, TablaCompras As Boolean)
        dtpFechaFinal.Enabled = FechatInicial
        dtpFechaFinal.Enabled = FechaFinal
        lvReportesVentas.Enabled = TablaCompras
    End Sub

    Private Sub btnExportarExcel_Click(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        Dim SAVE As New SaveFileDialog
        Dim ruta As String
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim pth As String = ""

        'Crear nueva hoja de calculo

        Dim xlwb As Object = xlApp.WorkBooks.add
        Dim xlws As Object = xlwb.WorkSheets(1)
        Try
            'Exportar los caracteres de las columnas
            For c As Integer = 0 To lvReportesVentas.Columns.Count - 1
                xlws.cells(1, c + 1).value = lvReportesVentas.Columns(c).HeaderText

            Next
            'Exportar las cabeceras de las columnas
            For r As Integer = 0 To lvReportesVentas.RowCount - 1
                For c As Integer = 0 To lvReportesVentas.Columns.Count - 1
                    xlws.cells(r + 2, c + 1).value = Convert.ToString(lvReportesVentas.Item(c, r).Value)
                Next
            Next

            ' Guardamos la hoja de excel en ruta especifica

            Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog
            SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog1.Filter = "Archivo Excel| =.xlsx"
            SaveFileDialog1.FilterIndex = 2
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                ruta = SaveFileDialog1.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlApp.quit()
                MsgBox("Exportado correctamente", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim fecha As Date = dtpFechaInicial.Text 'dd-MM-yyyy'
        Dim diaI As String = fecha.Day
        Dim mesI As String = fecha.Month
        Dim añoI As String = fecha.Year

        Dim fechaF As Date = dtpFechaFinal.Text 'dd-MM-yyyy'
        Dim diaF As String = fechaF.Day
        Dim mesF As String = fechaF.Month
        Dim añoF As String = fechaF.Year

        Dim cm1 As New SqlCommand("Select * from dbMiniMarket.Venta where VentaFechaRegistroComprobante between '" + añoI + "-" + mesI + "-" + diaI + "' and '" + añoF + "-" + mesF + "-" + diaF + "'", conexion)

        Dim da1 As New SqlDataAdapter
        Dim dt1 As New DataTable

        da1.SelectCommand = cm1
        dt1.Clear()
        da1.Fill(dt1)
        lvReportesVentas.DataSource = dt1
        conexion.Close()
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click

        mostrarTbla()
    End Sub

    Private Sub mostrarTbla()
        Dim cm1 As New SqlCommand("Select * from dbMiniMarket.Venta", conexion)

        Dim da1 As New SqlDataAdapter
        Dim dt1 As New DataTable

        da1.SelectCommand = cm1
        dt1.Clear()
        da1.Fill(dt1)
        lvReportesVentas.DataSource = dt1
        conexion.Close()
    End Sub

    Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClientes.SelectedIndexChanged
        Dim fechaActual As Date = Date.Now

        If ((dtpFechaInicial.Text.Equals(fechaActual)) AndAlso (dtpFechaFinal.Text.Equals(fechaActual))) Then
            Dim cm1 As New SqlCommand("select VentaNumeroComprobante,VentaTipoComprobante,VentaUsuarioDocumentoIdentidad,VentaClienteDocumentoIdentidad,
            VentaClienteNombresApellidos, VentaClienteApellidoPaterno, VentaClienteApellidoMaterno,
            VentaMontoPagoComprobante, VentaMontoVueltoComprobante, VentaMontoTotalComprobante, VentaFechaRegistroComprobante 
            from dbMiniMarket.Venta where VentaClienteDocumentoIdentidad Like '%" + cboClientes.Text + "%'", conexion)

            Dim da1 As New SqlDataAdapter
            Dim dt1 As New DataTable

            da1.SelectCommand = cm1
            dt1.Clear()
            da1.Fill(dt1)
            lvReportesVentas.DataSource = dt1
            conexion.Close()
        Else

            Dim fecha As Date = dtpFechaInicial.Text 'dd-MM-yyyy'
            Dim diaI As String = fecha.Day
            Dim mesI As String = fecha.Month
            Dim añoI As String = fecha.Year

            Dim fechaF As Date = dtpFechaFinal.Text 'dd-MM-yyyy'
            Dim diaF As String = fechaF.Day
            Dim mesF As String = fechaF.Month
            Dim añoF As String = fechaF.Year


            Dim cm1 As New SqlCommand("select VentaNumeroComprobante,VentaTipoComprobante,VentaUsuarioDocumentoIdentidad,VentaClienteDocumentoIdentidad,
            VentaClienteNombresApellidos, VentaClienteApellidoPaterno, VentaClienteApellidoMaterno,
            VentaMontoPagoComprobante, VentaMontoVueltoComprobante, VentaMontoTotalComprobante, VentaFechaRegistroComprobante 
            from dbMiniMarket.Venta where VentaFechaRegistroComprobante between '" + añoI + "-" + mesI + "-" + diaI + "' and '" + añoF + "-" + mesF + "-" + diaF + "' AND VentaClienteDocumentoIdentidad Like '%" + cboClientes.Text + "%' ", conexion)

            Dim da1 As New SqlDataAdapter
            Dim dt1 As New DataTable

            da1.SelectCommand = cm1
            dt1.Clear()
            da1.Fill(dt1)
            lvReportesVentas.DataSource = dt1
            conexion.Close()
        End If
    End Sub
End Class