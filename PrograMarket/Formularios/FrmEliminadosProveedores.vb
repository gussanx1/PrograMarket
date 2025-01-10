Imports System.Data.SqlClient

Public Class FrmEliminadosProveedores
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daProveedores As SqlDataAdapter
    Public vProveedorRecuoerado As Integer = 0
    Private Sub FrmEliminadosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        LlenarBorrados()
        cmdRecuperar.Enabled = False
    End Sub
    Private Sub LlenarBorrados()
        lvProvedoresElimin.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("ProveedoressBorrados").Rows.Count - 1
            lvProvedoresElimin.Items.Add(dsDatos.Tables("ProveedoressBorrados").Rows(i).Item("ProveedorDocumentoIdentidad").ToString)
            lvProvedoresElimin.Items(i).SubItems.Add(dsDatos.Tables("ProveedoressBorrados").Rows(i).Item("ProveedorRazonSocial").ToString)
            lvProvedoresElimin.Items(i).SubItems.Add(dsDatos.Tables("ProveedoressBorrados").Rows(i).Item("ProveedorCorreo").ToString)
            lvProvedoresElimin.Items(i).SubItems.Add(dsDatos.Tables("ProveedoressBorrados").Rows(i).Item("ProveedorTelefono").ToString)
        Next
    End Sub

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daProveedores = New SqlDataAdapter("dbo.spProductosListadoBorrados", cn)
        daProveedores.Fill(dsDatos, "ProveedoressBorrados")
        If dsDatos.Tables("ProveedoressBorrados").Rows.Count = 0 Then
            cmdRecuperar.Enabled = False
        End If
    End Sub

    Private Sub FiveCodImageButton2_Click(sender As Object, e As EventArgs) Handles FiveCodImageButton2.Click
        Me.Dispose()

    End Sub

    Private Sub cmdRecuperar_Click(sender As Object, e As EventArgs) Handles cmdRecuperar.Click
        If MessageBox.Show("¿Desea recuperar el Proveedor?",
                           "Recuperación de registros", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) =
                           DialogResult.OK Then
            Dim coProveedoresRecuperar As New SqlCommand("dbo.spProvedoresRecupararRegistro", cn)
            coProveedoresRecuperar.CommandType = CommandType.StoredProcedure
            '@MedicosCodigo nchar(10),
            coProveedoresRecuperar.Parameters.Add(New SqlParameter("@ProveedorDocumentoIdentidad", SqlDbType.NChar, 11, ParameterDirection.Input)).Value = lvProvedoresElimin.SelectedItems(0).Text
            cn.Open()
            coProveedoresRecuperar.ExecuteNonQuery()
            cn.Close()
            CrearDataSet()
            LlenarBorrados()
            MessageBox.Show("Proveedor recuperado", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vProveedorRecuoerado = 1
            cmdRecuperar.Enabled = False
        End If
    End Sub

    Private Sub lvProvedoresElimin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProvedoresElimin.SelectedIndexChanged
        If lvProvedoresElimin.SelectedItems.Count = 0 Then
            cmdRecuperar.Enabled = False
            Exit Sub
        End If
        cmdRecuperar.Enabled = True
    End Sub
End Class