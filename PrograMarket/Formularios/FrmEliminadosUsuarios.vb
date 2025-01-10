Imports System.Data.SqlClient

Public Class FrmEliminadosUsuarios
    Dim cn As SqlConnection
    Dim dsDatos As DataSet
    Dim daUsuarios As SqlDataAdapter
    Public vUsuarioRecuperado As Integer = 0
    Private Sub FrmEliminadosUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataSet()
        LlenarBorrados()
        cmdRecuperar.Enabled = False
    End Sub
    Private Sub LlenarBorrados()
        lvUsuariosEliminados.Items.Clear()
        For i As Integer = 0 To dsDatos.Tables("UsuariosBorrados").Rows.Count - 1
            lvUsuariosEliminados.Items.Add(dsDatos.Tables("UsuariosBorrados").Rows(i).Item("UsuarioDocumentoIdentidad").ToString)
            lvUsuariosEliminados.Items(i).SubItems.Add(dsDatos.Tables("UsuariosBorrados").Rows(i).Item("UsuarioNombres").ToString)
            lvUsuariosEliminados.Items(i).SubItems.Add(dsDatos.Tables("UsuariosBorrados").Rows(i).Item("UsuarioApellidoPaterno").ToString)
            lvUsuariosEliminados.Items(i).SubItems.Add(dsDatos.Tables("UsuariosBorrados").Rows(i).Item("UsuarioApellidoMaterno").ToString)
        Next
    End Sub

    Private Sub CrearDataSet()
        cn = New SqlConnection(cCadena)
        dsDatos = New DataSet
        daUsuarios = New SqlDataAdapter("dbo.spUsuariosBorrados", cn)
        daUsuarios.Fill(dsDatos, "UsuariosBorrados")
        If dsDatos.Tables("UsuariosBorrados").Rows.Count = 0 Then
            cmdRecuperar.Enabled = False
        End If
    End Sub

    Private Sub FiveCodImageButton2_Click(sender As Object, e As EventArgs) Handles FiveCodImageButton2.Click
        Me.Dispose()

    End Sub

    Private Sub cmdRecuperar_Click(sender As Object, e As EventArgs) Handles cmdRecuperar.Click
        If MessageBox.Show("¿Desea recuperar el Usuario?",
                           "Recuperación de registros", MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) =
                           DialogResult.OK Then
            Dim coClientesRecuperar As New SqlCommand("dbo.spUsuarioRecuperarRegistro", cn)
            coClientesRecuperar.CommandType = CommandType.StoredProcedure
            '@MedicosCodigo nchar(10),
            coClientesRecuperar.Parameters.Add(New SqlParameter("@UsuarioDocumentoIdentidad", SqlDbType.NChar, 8, ParameterDirection.Input)).Value = lvUsuariosEliminados.SelectedItems(0).Text
            cn.Open()
            coClientesRecuperar.ExecuteNonQuery()
            cn.Close()
            CrearDataSet()
            LlenarBorrados()
            MessageBox.Show("Usuario recuperado", "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            vUsuarioRecuperado = 1
            cmdRecuperar.Enabled = False

        End If
    End Sub

    Private Sub lvClientesElimin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUsuariosEliminados.SelectedIndexChanged
        If lvUsuariosEliminados.SelectedItems.Count = 0 Then
            cmdRecuperar.Enabled = False
            Exit Sub
        End If
        cmdRecuperar.Enabled = True
    End Sub
End Class