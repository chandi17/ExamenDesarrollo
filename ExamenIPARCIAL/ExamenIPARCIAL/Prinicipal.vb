Public Class Prinicipal
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtEdad.MaskInputRejected

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim recuperadosFM, muertosFM, infectadosFM As Integer
        Dim recuperadosCY, muertosCY, infectadosCY As Integer
        Dim edad As Integer
        Dim nombre, departamentos, estado, municipio, descripcion As String

        If txtNombre.Text = "" Or txtMunicipio.Text = "" Or txtEdad.Text = "" Or txtDescripcion.Text = "" Or cmbDepartamento.Text = "" Or Or cmbEstado.Text = "" Then
            MsgBox("Debe llenar todos los campos", "Error", MessageBoxButtons.OKCancel)
        End If

    End Sub
End Class