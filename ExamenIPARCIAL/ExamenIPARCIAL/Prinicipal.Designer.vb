<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prinicipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbResultado = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataHistorial = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtInfectadosDep = New System.Windows.Forms.TextBox()
        Me.txtRecuperadosDep = New System.Windows.Forms.TextBox()
        Me.txtMuertosDep = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtInfectados = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMuertos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalAplicadas = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbTotalDepartamento = New System.Windows.Forms.ComboBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(487, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(124, 60)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEdad.Mask = "999"
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 25)
        Me.txtEdad.TabIndex = 1
        Me.txtEdad.ValidatingType = GetType(Integer)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(124, 31)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(187, 25)
        Me.txtNombre.TabIndex = 0
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(124, 89)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(121, 28)
        Me.cmbDepartamento.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Departamento:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(131, 42)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(187, 25)
        Me.txtMunicipio.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Municipio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 143)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(187, 63)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Estado: "
        '
        'cmbEstado
        '
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Infectado", "Recuperado", "Muerto"})
        Me.cmbEstado.Location = New System.Drawing.Point(131, 108)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 28)
        Me.cmbEstado.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbResultado)
        Me.GroupBox2.Controls.Add(Me.txtMunicipio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbEstado)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 246)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(487, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'cmbResultado
        '
        Me.cmbResultado.FormattingEnabled = True
        Me.cmbResultado.Items.AddRange(New Object() {"Positivo", "Negativo"})
        Me.cmbResultado.Location = New System.Drawing.Point(132, 74)
        Me.cmbResultado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbResultado.Name = "cmbResultado"
        Me.cmbResultado.Size = New System.Drawing.Size(121, 28)
        Me.cmbResultado.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Resultado:"
        '
        'btnGuardar
        '
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(964, 638)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(119, 43)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(1111, 638)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 43)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(1275, 639)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 43)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataHistorial)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(557, 74)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(839, 529)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'DataHistorial
        '
        Me.DataHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Edad, Me.Municipio, Me.Departamento, Me.Estado, Me.Descripcion})
        Me.DataHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataHistorial.Enabled = False
        Me.DataHistorial.Location = New System.Drawing.Point(3, 20)
        Me.DataHistorial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataHistorial.Name = "DataHistorial"
        Me.DataHistorial.RowHeadersWidth = 51
        Me.DataHistorial.RowTemplate.Height = 24
        Me.DataHistorial.Size = New System.Drawing.Size(833, 507)
        Me.DataHistorial.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Edad
        '
        Me.Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Edad.HeaderText = "Edad"
        Me.Edad.MaxInputLength = 120
        Me.Edad.MinimumWidth = 6
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 69
        '
        'Municipio
        '
        Me.Municipio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.MinimumWidth = 6
        Me.Municipio.Name = "Municipio"
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.MinimumWidth = 6
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Width = 125
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 125
        '
        'txtInfectadosDep
        '
        Me.txtInfectadosDep.BackColor = System.Drawing.Color.White
        Me.txtInfectadosDep.Enabled = False
        Me.txtInfectadosDep.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfectadosDep.Location = New System.Drawing.Point(124, 60)
        Me.txtInfectadosDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInfectadosDep.Name = "txtInfectadosDep"
        Me.txtInfectadosDep.Size = New System.Drawing.Size(72, 25)
        Me.txtInfectadosDep.TabIndex = 5
        '
        'txtRecuperadosDep
        '
        Me.txtRecuperadosDep.BackColor = System.Drawing.Color.White
        Me.txtRecuperadosDep.Enabled = False
        Me.txtRecuperadosDep.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecuperadosDep.Location = New System.Drawing.Point(124, 91)
        Me.txtRecuperadosDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecuperadosDep.Name = "txtRecuperadosDep"
        Me.txtRecuperadosDep.Size = New System.Drawing.Size(72, 25)
        Me.txtRecuperadosDep.TabIndex = 5
        '
        'txtMuertosDep
        '
        Me.txtMuertosDep.BackColor = System.Drawing.Color.White
        Me.txtMuertosDep.Enabled = False
        Me.txtMuertosDep.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuertosDep.Location = New System.Drawing.Point(124, 122)
        Me.txtMuertosDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMuertosDep.Name = "txtMuertosDep"
        Me.txtMuertosDep.Size = New System.Drawing.Size(72, 25)
        Me.txtMuertosDep.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Infectados:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Recuperados:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(55, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Muertos:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Departamento:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtInfectados)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtMuertos)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtRecuperados)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtTotalAplicadas)
        Me.GroupBox4.Location = New System.Drawing.Point(309, 487)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(205, 166)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales Nacionales"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Muertos:"
        '
        'txtInfectados
        '
        Me.txtInfectados.Enabled = False
        Me.txtInfectados.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfectados.Location = New System.Drawing.Point(105, 58)
        Me.txtInfectados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInfectados.Name = "txtInfectados"
        Me.txtInfectados.Size = New System.Drawing.Size(72, 25)
        Me.txtInfectados.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Recuperados:"
        '
        'txtMuertos
        '
        Me.txtMuertos.Enabled = False
        Me.txtMuertos.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuertos.Location = New System.Drawing.Point(105, 121)
        Me.txtMuertos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMuertos.Name = "txtMuertos"
        Me.txtMuertos.Size = New System.Drawing.Size(72, 25)
        Me.txtMuertos.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Infectados:"
        '
        'txtRecuperados
        '
        Me.txtRecuperados.Enabled = False
        Me.txtRecuperados.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecuperados.Location = New System.Drawing.Point(105, 90)
        Me.txtRecuperados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.Size = New System.Drawing.Size(72, 25)
        Me.txtRecuperados.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Total Aplic."
        '
        'txtTotalAplicadas
        '
        Me.txtTotalAplicadas.Enabled = False
        Me.txtTotalAplicadas.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAplicadas.Location = New System.Drawing.Point(105, 27)
        Me.txtTotalAplicadas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalAplicadas.Name = "txtTotalAplicadas"
        Me.txtTotalAplicadas.Size = New System.Drawing.Size(72, 25)
        Me.txtTotalAplicadas.TabIndex = 10
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmbTotalDepartamento)
        Me.GroupBox5.Controls.Add(Me.txtMuertosDep)
        Me.GroupBox5.Controls.Add(Me.txtInfectadosDep)
        Me.GroupBox5.Controls.Add(Me.txtRecuperadosDep)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(28, 479)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(273, 175)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos por Departamentos"
        '
        'cmbTotalDepartamento
        '
        Me.cmbTotalDepartamento.FormattingEnabled = True
        Me.cmbTotalDepartamento.Items.AddRange(New Object() {"Atlántida", "Choluteca", "Colón", "Comayagua", "Copán", "Cortés", "El Paraíso", "Francisco Morazán", "Gracias a Dios", "Intibucá", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbTotalDepartamento.Location = New System.Drawing.Point(124, 26)
        Me.cmbTotalDepartamento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbTotalDepartamento.Name = "cmbTotalDepartamento"
        Me.cmbTotalDepartamento.Size = New System.Drawing.Size(121, 24)
        Me.cmbTotalDepartamento.TabIndex = 6
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(463, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(571, 55)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Ingreso de Pruebas SINAGER"
        '
        'Prinicipal
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1439, 709)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prinicipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prinicipal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtInfectadosDep As TextBox
    Friend WithEvents txtRecuperadosDep As TextBox
    Friend WithEvents txtMuertosDep As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataHistorial As DataGridView
    Friend WithEvents cmbResultado As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMuertos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalAplicadas As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cmbTotalDepartamento As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtInfectados As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents Label16 As Label
End Class
