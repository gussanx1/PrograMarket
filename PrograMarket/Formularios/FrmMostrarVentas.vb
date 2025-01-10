Imports System.Data.SqlClient

Public Class FrmMostrarVentas

    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Dim vPosicion As Integer
    Private Sub FrmMostrarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim material = materialSkinManager
        material = MaterialSkin.MaterialSkinManager.Instance
        material.EnforceBackcolorOnAllComponents = True
        material.AddFormToManage(Me)
        material.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        material.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo100, MaterialSkin.Primary.Blue800, MaterialSkin.TextShade.WHITE)

        CrearDataSet()
        LlenarLista()

    End Sub
    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("spListaDeVentas", cn)
        daClientes.Fill(dsDatos, "Ventas")
    End Sub

    Private Sub LlenarLista()
        lvVentas.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("Ventas").Rows.Count - 1
            lvVentas.Items.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaNumeroComprobante").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaTipoComprobante").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaUsuarioDocumentoIdentidad").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaClienteDocumentoIdentidad").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaClienteNombresApellidos").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaClienteApellidoPaterno").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaClienteApellidoMaterno").ToString)

            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaMontoPagoComprobante").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaMontoVueltoComprobante").ToString)
            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaMontoTotalComprobante").ToString)

            lvVentas.Items(i).SubItems.Add(dsDatos.Tables("Ventas").Rows(i).Item("VentaFechaRegistroComprobante").ToString)
        Next
    End Sub

End Class