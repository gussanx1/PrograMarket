Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MaterialSkin.Controls
Imports PrograMarket.MINIMARKETDataSetTableAdapters

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-U689QGJ\JEYSSONSR;Initial Catalog=MINIMARKET;Integrated Security=True")
    Private cmd As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public lector As SqlDataReader
    Dim estado As String
    Dim funcion As String

    Public Sub Conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Fallo conectando a la base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmd = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function ConsultaEspecifica(ByVal sql As String, ByVal tabla As String, ByVal condicion As String)
        conexion.Open()
        Dim consulta As String = sql + tabla + " WHERE " + condicion
        comando = New SqlCommand(consulta, conexion)
        lector = comando.ExecuteReader

        While lector.Read
            funcion = lector.Item("UsuarioFuncionCodigo")
            estado = lector.Item("UsuarioEstado")

            If (estado.Equals("N")) Then
                MessageBox.Show("Usuario No Activo")
                Return 0
            End If

            If (funcion.Equals("1")) Then
                MessageBox.Show("Pase Master Admin")
                Return 1
            ElseIf (funcion.Equals("2")) Then
                MessageBox.Show("Pase Trabajador")
                Return 2
            ElseIf (funcion.Equals("3")) Then
                MessageBox.Show("Pase Cliente")
                Return 3
            ElseIf (funcion.Equals("4")) Then
                MessageBox.Show("Pase Proveedor")
                Return 4
            Else
                MessageBox.Show("No Es Un Usuario Registrado")
                Return 0
            End If
        End While
        Return funcion

        conexion.Close()
    End Function

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "DELETE FROM " + tabla + " WHERE " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub consultarFechaDeVentas(ByVal tabla As DataGridView, ByVal fechaI As Date, ByVal fechaF As Date)

        da = New SqlDataAdapter("select * from dbMiniMarket.Venta  where VentaFechaRegistroComprobante between'" & fechaI & "'and'" & fechaF & "'", conexion)
        Dim dataS As New DataSet
        da.Fill(dataS, "dbMiniMarket.Venta")
        tabla.DataSource = dataS.Tables("dbMiniMarket.Venta")
    End Sub

End Class
