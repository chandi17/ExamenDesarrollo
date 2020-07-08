Public Class Productos
    Dim conexion As Conexion = New Conexion()
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try
            Dim tabla As DataTable
            tabla = conexion.consultarProductos()
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

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If txtIdClientes.Text = "" Or txtDescripcion.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Debe llenar todas las casillas ")
            Exit Sub
        End If
        Dim IdProducto As Integer
        Dim Nombre, Descripcion As String
        IdProducto = Int(Val(txtIdClientes.Text))
        Nombre = txtNombre.Text
        Descripcion = txtDescripcion.Text

        Try

            'If Conexion.consultarVentaExiste(idVentas) = False Then
            If conexion.agregarProducto(IdProducto, Nombre, Descripcion) Then
                MsgBox("Producto Ingresado correctamente")
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIdClientes.Text = "" Or txtDescripcion.Text = "" Or txtNombre.Text = "" Then
            MsgBox("Debe llenar todas las casillas ")
            Exit Sub
        End If
        Dim IdProducto As Integer
        Dim Nombre, Descripcion As String
        IdProducto = Int(Val(txtIdClientes.Text))
        Nombre = txtNombre.Text
        Descripcion = txtDescripcion.Text

        Try

            'If Conexion.consultarVentaExiste(idVentas) = False Then
            If conexion.actualizarProducto(IdProducto, Nombre, Descripcion) Then
                MsgBox("Producto Actualizado correctamente")
            Else
                MsgBox("El Producto no existe")
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
            Dim IdProducto As Integer = Int(Val(txtIdClientes.Text))
            Try
                'If conexion.consultarVentaExiste(idVentas) = True Then
                If conexion.EliminarProducto(IdProducto) Then
                    MsgBox("Producto Eliminado Correctamente")
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
        txtDescripcion.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        My.Forms.PanelMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnCleintes_Click(sender As Object, e As EventArgs) Handles btnCleintes.Click
        My.Forms.Clientes.Show()
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