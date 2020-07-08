Imports System.Data.SqlClient
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=CHANDIA;Initial Catalog=Tienda;Integrated Security=True")

    Public Sub Abrirconexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar")
        Finally
            conexion.Close()
        End Try

    End Sub

    Public Function agregarVenta(idVenta As Integer, fechaVenta As Date, precio As Integer, cantidad As Integer, idCliente As Integer, idProducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ingresarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function agregarProducto(idproducto As Integer, nombreProducto As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ingresarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idproducto", idproducto)
            cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al Agregar Producto")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function agregarClientes(idCliente As Integer, nombre As String, apellido As String, direccion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ingresarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)
            cmd.Parameters.AddWithValue("@direccion", direccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al Agregar Cliente")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarclientes(idCliente As Integer, nombre As String, apellido As String, direccion As String) As Boolean

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idCliente", idCliente)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@apellido", apellido)
            cmd.Parameters.AddWithValue("@direccion", direccion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al Actualizar Cliente")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarProducto(idproducto As Integer, nombreProducto As String, descripcion As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idproducto", idproducto)
            cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al actualizar Producto")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function actualizarVenta(idVenta As Integer, precio As Integer, cantidad As Integer, idProducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("actualizarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idVenta", idVenta)
            cmd.Parameters.AddWithValue("@precio", precio)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@idProducto", idProducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al actualizar Venta")
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function EliminarCliente(idcliente As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idcliente", idcliente)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Cliente")
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function EliminarProducto(idproducto As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idproducto", idproducto)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar Producto")
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function EliminarVenta(idventa As Integer) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idventa", idventa)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error al eliminar venta")
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function consultarClientes()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarClientes", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar CLientes")
        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarClienteIndividual(idcliente As Integer)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarClienteIndividual", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idcliente", idcliente)

            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar CLientes Individuales")
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function consultarVentas()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVentas", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar Ventas")
        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarVentaIndividual(nombre As String)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVentaIndividual", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)

            If cmd.ExecuteNonQuery > 0 Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar venta Individual")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function consultarVentaExiste(idventa As Integer) As Boolean

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVentaExiste", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idventa", idventa)

            If cmd.ExecuteNonQuery > 0 Then
                MsgBox(cmd.ExecuteNonQuery)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar venta Existe")
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function consultarProductos()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarProductos", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar Productos")
        Finally
            conexion.Close()

        End Try
    End Function
    Public Function consultarProductoIndividual(idproducto As Integer)

        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarProductoIndividual", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idproducto", idproducto)

            If cmd.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
            MsgBox("Error al consultar Producto Individual")
        Finally
            conexion.Close()
        End Try
    End Function
End Class
