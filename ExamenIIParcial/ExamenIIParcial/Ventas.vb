Public Class PanelMenu
    Dim conexion As Conexion = New Conexion()
    Dim tabla As New DataTable


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If txtIdVenta.Text = "" Or txtFecha.Text = "" Or txtPrecio.Text = "" Or txtCantidad.Text = "" Or txtCliente.Text = "" Or txtProducto.Text = "" Then
            MsgBox("Debe llenar todas las casillas ", "Error")
            Exit Sub
        End If
        Dim idVentas, Precio, Cantidad, IdCliente, IdProducto As Integer
        Dim FechaVenta As Date
        idVentas = Int(Val(txtIdVenta.Text))
        FechaVenta = txtFecha.Text
        Precio = txtPrecio.Text
        Cantidad = txtCantidad.Text
        IdCliente = txtCliente.Text
        IdProducto = txtProducto.Text
        Dim temporal As Boolean = conexion.consultarVentaExiste(idVentas)

        Try

            If conexion.consultarVentaExiste(idVentas) = False Then
                If conexion.agregarVenta(idVentas, FechaVenta, Precio, Cantidad, IdCliente, IdProducto) Then
                    MsgBox("Ingresado correctamente")
                Else
                    MsgBox("Error al Agregar")
                End If
            End If
            If conexion.consultarVentaExiste(idVentas) = True Then
                MsgBox("El Codigo de venta ya existe", "Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Limpiar()
        End Try

    End Sub

    Private Sub PanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Abrirconexion()
    End Sub

    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim tabla As DataTable
            tabla = conexion.consultarVentas()
            If tabla.Rows.Count <> 0 Then
                dgvVentas.DataSource = tabla
            Else
                dgvVentas.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox("Error al consultar")
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        Try
            Dim tabla As DataTable
            Dim codigoVenta As Integer = Int(Val(txtIdVenta.Text))
            tabla = conexion.consultarVentaIndividual(codigoVenta)

            If tabla.Rows.Count <> 0 Then
                dgvVentas.DataSource = tabla
            Else
                dgvVentas.DataSource = Nothing
                MsgBox("El Id no Existe")
            End If
        Catch ex As Exception
            MsgBox("Error al Buscar Venta")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idVentas, Precio, Cantidad, IdProducto As String
        idVentas = Int(Val(txtIdVenta.Text))
        Precio = Int(txtPrecio.Text)
        Cantidad = Int(txtCantidad.Text)
        IdProducto = txtProducto.Text

        Try
            If conexion.consultarVentaExiste(idVentas) = True Then
                If conexion.actualizarVenta(idVentas, Precio, Cantidad, IdProducto) Then
                    MsgBox("Actualizado correctamente")
                Else
                    MsgBox("Error al Actualizar")
                End If
            Else
                MsgBox("El Codigo No existe")
            End If
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
            Dim IdVentas As Integer = Int(Val(txtIdVenta.Text))
            Try
                'If conexion.consultarVentaExiste(idVentas) = True Then
                If conexion.EliminarVenta(IdVentas) Then
                    MsgBox("Venta Eliminada")
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
        txtIdVenta.Clear()
        txtFecha.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtCliente.Clear()
        txtProducto.Clear()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        My.Forms.Productos.Show()
        Me.Close()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
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

    Private Sub dgvVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick
        txtIdVenta.Text = dgvVentas.CurrentRow.Cells(0).Value.ToString
        txtFecha.Text = dgvVentas.CurrentRow.Cells(0).Value.ToString
    End Sub
End Class
