Public Class Clientes
    Dim conexion As Conexion = New Conexion()
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If txtIdClientes.Text = "" Or txtApellido.Text = "" Or txtNombre.Text = "" Or txtDierccion.Text = "" Then
            MsgBox("Debe llenar todas las casillas ")
            Exit Sub
        End If
        Dim IdCliente As Integer
        Dim Nombre, Apellido, Direccion As String
        IdCliente = Int(Val(txtIdClientes.Text))
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Direccion = txtDierccion.Text

        Try

            'If Conexion.consultarVentaExiste(idVentas) = False Then
            If conexion.agregarClientes(IdCliente, Nombre, Apellido, Direccion) Then
                MsgBox("Ingresado correctamente")
            Else
                MsgBox("Error al Agregar")
            End If
            'If Conexion.consultarVentaExiste(idVentas) = True Then
            'MsgBox("El Codigo de venta ya existe", "Error", MessageBoxButtons.OK)
            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Limpiar()
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try
            Dim tabla As DataTable
            tabla = conexion.consultarClientes()
            If tabla.Rows.Count <> 0 Then
                dgvVentas.DataSource = tabla
            Else
                dgvVentas.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox("Error al consultar")
        Finally
            Limpiar()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdClientes.Text = "" Or txtApellido.Text = "" Or txtNombre.Text = "" Or txtDierccion.Text = "" Then
            MsgBox("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim IdCliente As Integer
        Dim Nombre, Apellido, Direccion As String
        IdCliente = Int(Val(txtIdClientes.Text))
        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Direccion = txtDierccion.Text

        Try
            'If Conexion.consultarVentaExiste(idVentas) = False Then
            If conexion.actualizarclientes(IdCliente, Nombre, Apellido, Direccion) Then
                MsgBox("Actualizado correctamente")
            Else
                MsgBox("ID de Cliente Incorrecto")
            End If
            'If Conexion.consultarVentaExiste(idVentas) = True Then
            'MsgBox("El Codigo de venta ya existe", "Error", MessageBoxButtons.OK)
            ' End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Limpiar()
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea Eliminar?", 36, "SALIR")
        If salir = 6 Then
            Dim IdVentas As Integer = Int(Val(txtIdClientes.Text))
            Try
                'If conexion.consultarVentaExiste(idVentas) = True Then
                If conexion.EliminarVenta(IdVentas) Then
                    MsgBox("Cliente Eliminada")
                Else
                    MsgBox("El Codigo No existe")
                End If
                'Else
                'MsgBox("El Codigo No existe")
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Limpiar()
            End Try
        End If

    End Sub






    Private Sub Limpiar()
        txtIdClientes.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDierccion.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        My.Forms.PanelMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        My.Forms.Productos.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim salir As String

        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir = 6 Then
            My.Forms.MenuPrincipal.Close()
        End If

    End Sub
End Class