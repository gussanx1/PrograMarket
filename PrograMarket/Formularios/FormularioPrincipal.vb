Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MaterialSkin
Imports PrograMarket.MINIMARKETDataSetTableAdapters

Public Class FormularioPrincipal

    Dim conexion As conexion = New conexion()
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daPermisos As SqlDataAdapter
    Dim vPosicion As Integer


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estadoMenus()
        AbrirFormulario(New FrmAcercaDe)
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click

        AbrirFormulario(New Usuarios)

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click

        AbrirFormulario(New Clientes)

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click

        AbrirFormulario(New Form1)

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click

        AbrirFormulario(New Productos)

    End Sub

    Private Sub btnCompra_Click(sender As Object, e As EventArgs) Handles btnCompra.Click

        AbrirFormulario(New FormCompra)

    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click

        AbrirFormulario(New FrmMostrarVentas)

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporteCompras.Click

        AbrirFormulario(New FrmReporteCompras)

    End Sub

    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click

        AbrirFormulario(New FrmAcercaDe)

    End Sub

    Private Sub btnRegistroCompras_Click(sender As Object, e As EventArgs) Handles btnRegistroCompras.Click

        AbrirFormulario(New FrmDetalleCompra)

    End Sub

    Private Sub btnReporteVentas_Click(sender As Object, e As EventArgs) Handles btnReporteVentas.Click

        AbrirFormulario(New FrmReporteVentas)

    End Sub

    Private Sub estadoMenus()

        Dim funcion As String = FormularioLogin.funcion
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        Dim documentoUsuario As String = FormularioLogin.dni
        Dim coUsuariosLectura As New SqlCommand("dbo.spPermisosUsuarios", cn)
        coUsuariosLectura.CommandType = CommandType.StoredProcedure
        coUsuariosLectura.Parameters.Add(New SqlParameter("@PermisoFuncionCodigo", SqlDbType.Int)).Value = funcion

        If cn.State <> ConnectionState.Closed Then
            cn.Close()
        End If

        Try
            cn.Open()
            coUsuariosLectura.ExecuteNonQuery()
            daPermisos = New SqlDataAdapter(coUsuariosLectura)
            daPermisos.Fill(dsDatos, "Permisos")
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo mostrar el registro")
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try

        For i As Integer = 0 To dsDatos.Tables("Permisos").Rows.Count - 1

            If (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuAcercaDe")) Then
                btnAcercaDe.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuClientes")) Then
                btnCliente.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuCompras")) Then
                btnCompra.Enabled = True
                btnRegistroCompras.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuProductos")) Then
                btnProducto.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuProveedores")) Then
                btnProveedor.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuReportes")) Then
                btnReporteCompras.Enabled = True
                btnReporteVentas.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuUsuario")) Then
                btnUsuario.Enabled = True
            ElseIf (dsDatos.Tables("Permisos").Rows(i).Item("PermisoNombreMenu").Equals("MenuVentas")) Then
                btnVenta.Enabled = True
            End If

        Next

    End Sub

    Private Sub AbrirFormulario(frmHijo As Object)
        If (contenido.Controls.Count > 0) Then
            contenido.Controls.RemoveAt(0)
            Dim frm As Form
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            contenido.Controls.Add(frm)
            contenido.Tag = frm
            frm.Show()
        Else

            Dim frm As Form
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            contenido.Controls.Add(frm)
            contenido.Tag = frm
            frm.Show()
        End If

    End Sub

End Class