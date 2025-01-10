Imports MaterialSkin

Public Class FrmAcercaDe
    ReadOnly materialSkinManager As MaterialSkin.MaterialSkinManager
    Private Sub FrmAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim material = materialSkinManager

        material = MaterialSkin.MaterialSkinManager.Instance
        material.EnforceBackcolorOnAllComponents = True
        material.AddFormToManage(Me)
        material.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        material.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo400, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Amber200, MaterialSkin.Primary.Pink800, MaterialSkin.TextShade.WHITE)

        lblFecha.Text = "Hoy es " + DateTime.Now.ToString("dddd:MMMM:yyyy")
        lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss")

    End Sub

End Class