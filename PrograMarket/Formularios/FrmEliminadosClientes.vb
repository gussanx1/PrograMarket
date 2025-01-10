Imports System.Data.SqlClient

Public Class FrmEliminadosClientes
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daClientes As SqlDataAdapter
    Public vClienteRecuoerado As Integer = 0
    Private Sub FiveCodImageButton1_Click(sender As Object, e As EventArgs) Handles cmdRecuperar.Click
        If MessageBox.Show("¿Desea recuperar el Cliente?",
                           "Recuperación de registros", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) =
                           DialogResult.OK Then
            Dim coClientesRecuperar As New SqlCommand("dbo.spClientesRecupararRegistro", cn)
            coClientesRecuperar.CommandType = CommandType.StoredProcedure
            '@MedicosCodigo nchar(10),
            coClientesRecuperar.Parameters.Add(New SqlParameter("@ClienteDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = lvClientesElimin.SelectedItems(0).Text
            cn.Open()
            coClientesRecuperar.ExecuteNonQuery()
            cn.Close()
            CrearDataSet()
            LlenarBorrados()
            MessageBox.Show("Clientes recuperado", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vClienteRecuoerado = 1
            cmdRecuperar.Enabled = False

        End If
    End Sub
    Private Sub LlenarBorrados()
        lvClientesElimin.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("ClientesBorrados").Rows.Count - 1
            lvClientesElimin.Items.Add(dsDatos.Tables("ClientesBorrados").Rows(i).Item("ClienteDocumentoIdentidad").ToString)
            lvClientesElimin.Items(i).SubItems.Add(dsDatos.Tables("ClientesBorrados").Rows(i).Item("ClienteNombres").ToString)
            lvClientesElimin.Items(i).SubItems.Add(dsDatos.Tables("ClientesBorrados").Rows(i).Item("ClienteApellidoPaterno").ToString)
            lvClientesElimin.Items(i).SubItems.Add(dsDatos.Tables("ClientesBorrados").Rows(i).Item("ClienteApellidoMaterno").ToString)
        Next
    End Sub

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daClientes = New SqlDataAdapter("dbo.spClientesListadoBorrados", cn)
        daClientes.Fill(dsDatos, "ClientesBorrados")
        If dsDatos.Tables("ClientesBorrados").Rows.Count = 0 Then
            cmdRecuperar.Enabled = False
        End If
    End Sub
    Private Sub FrmEliminadosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        LlenarBorrados()
        cmdRecuperar.Enabled = False
    End Sub

    Private Sub lvClientesElimin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvClientesElimin.SelectedIndexChanged
        If lvClientesElimin.SelectedItems.Count = 0 Then
            cmdRecuperar.Enabled = False
            Exit Sub
        End If
        cmdRecuperar.Enabled = True
    End Sub

    Private Sub FiveCodImageButton2_Click(sender As Object, e As EventArgs) Handles FiveCodImageButton2.Click
        Me.Dispose()

    End Sub
End Class