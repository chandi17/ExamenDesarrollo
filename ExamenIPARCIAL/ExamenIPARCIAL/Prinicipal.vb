Imports System.ComponentModel

Public Class Prinicipal
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtEdad.MaskInputRejected

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dep, estado, resultado As Integer

        'Condición que evalua que todos los campos esten llenos 
        If txtNombre.Text = "" Or txtMunicipio.Text = "" Or txtEdad.Text = "" Or txtDescripcion.Text = "" Or cmbDepartamento.Text = "" Or cmbResultado.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtNombre.Focus()
            Exit Sub
        End If

        Try
            dep = cmbDepartamento.SelectedIndex
            estado = cmbEstado.SelectedIndex
            resultado = cmbResultado.SelectedIndex
            If cmbResultado.Text = "Positivo" Then
                ContadoresTotales(dep, estado)
                Variables.Totales(3) += 1
            End If
            txtTotalAplicadas.Text = Variables.Totales(3)
            txtInfectados.Text = Variables.Totales(0)
            txtRecuperados.Text = Variables.Totales(1)
            txtMuertos.Text = Variables.Totales(2)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        txtNombre.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtDescripcion.Clear()
        cmbDepartamento.Text = ""
        cmbResultado.Text = ""
        cmbEstado.Text = ""
        cmbEstado.Enabled = False



    End Sub
    Private Sub LlenarCampos()
        DataHistorial.Rows.Add(txtNombre.Text, txtEdad.Text, txtMunicipio.Text, cmbDepartamento.Text, cmbEstado.Text, txtDescripcion.Text)
    End Sub
    Private Sub ContadoresTotales(dep As Integer, estado As Integer)
        LlenarCampos()
        Variables.TotalesDepartamento(dep, estado) += 1
        Variables.Totales(estado) += 1
    End Sub

    Private Sub cmbResultado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResultado.SelectedIndexChanged
        If cmbResultado.SelectedIndex = 0 Then
            cmbEstado.Enabled = True
        Else
            cmbEstado.Enabled = False
        End If

    End Sub
    Private Function TotalesDepartamentos(Estado As Integer)
        txtInfectadosDep.Text = TotalesDepartamento(Estado, 0)
        txtRecuperadosDep.Text = TotalesDepartamento(Estado, 1)
        txtMuertosDep.Text = TotalesDepartamento(Estado, 2)
    End Function

    Private Sub cmbTotalDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTotalDepartamento.SelectedIndexChanged

        Dim op As Integer
        op = cmbTotalDepartamento.SelectedIndex
        TotalesDepartamentos(op)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtEdad.Clear()
        txtMunicipio.Clear()
        txtDescripcion.Clear()
        cmbDepartamento.Text = ""
        cmbResultado.Text = ""
        cmbEstado.Text = ""
        cmbEstado.Enabled = False
    End Sub

    Private Sub Prinicipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim salir As String
        salir = MsgBox("¿Esta seguro que desea salir?", 36, "SALIR")
        If salir <> 6 Then
            txtNombre.Focus()
        Else
            End
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Nombre del Paciente")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Edad del Paciente")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtNombre, "Municipio al que pertenece")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip.SetToolTip(txtNombre, "Selecciones el Departamento del departamento")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip.SetToolTip(txtNombre, "Seleccione el estado del paciente")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbResultado_MouseHover(sender As Object, e As EventArgs) Handles cmbResultado.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese el Resultado del la prueba")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingrese una Descripción del estado del paciente")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGuardar_MouseHover(sender As Object, e As EventArgs) Handles btnGuardar.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingresa el Registro a la base de Datos")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        ToolTip.SetToolTip(txtNombre, "Inicializa los campos")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_MouseHover(sender As Object, e As EventArgs) Handles btnSalir.MouseHover
        ToolTip.SetToolTip(txtNombre, "Sale de la Aplicación")
        ToolTip.ToolTipTitle = "SINAGER"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
