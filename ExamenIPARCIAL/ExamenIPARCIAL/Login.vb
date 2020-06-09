Public Class Login
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim password, usuario As String

        usuario = txtUsuario.Text
        password = txtPassword.Text

        If password = pautaPassword And usuario = pautaUsuario Then
            Prinicipal.Show()
            Me.Hide()
            Exit Sub
        End If

        MsgBox("Usuario o Contraseña Incorrecto, Vuelva a intentarlo", "Error", MessageBoxButtons.OKCancel)
        txtPassword.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String
        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            txtUsuario.Focus()
        Else
            Prinicipal.Show()
            Me.Hide()
        End If
    End Sub
End Class