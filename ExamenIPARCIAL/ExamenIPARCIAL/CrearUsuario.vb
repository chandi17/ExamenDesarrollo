Public Class CrearUsuario

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Debe Llenar todos los campos...", "Creae Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Focus()
            Exit Sub
        End If

        pautaPassword = txtPassword.Text
        pautaUsuario = txtUsuario.Text
        MessageBox.Show("Usuario Agregado con exito....", "Creae Usuario", MessageBoxButtons.OK)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim salir As String
        salir = MsgBox("¿Esta seguro que desea Regresar?", 36, "SALIR")
        If salir <> 6 Then
            txtUsuario.Focus()
        Else
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class
