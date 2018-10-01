<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnMostrarAntecedentes = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblNumeroCitasAtendidas = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblEnviadoPor = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDireccionTrabajo = New System.Windows.Forms.Label()
        Me.lblDireccionParticular = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSaldoPendiente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTapa = New System.Windows.Forms.Panel()
        Me.lblCartel = New System.Windows.Forms.Label()
        Me.txbBusqueda = New System.Windows.Forms.TextBox()
        Me.btnRegistroMedico = New System.Windows.Forms.Button()
        Me.btnRegistrarCita = New System.Windows.Forms.Button()
        Me.btnCambiarEstado = New System.Windows.Forms.Button()
        Me.btnModificarDatos = New System.Windows.Forms.Button()
        Me.btnIngresarPaciente = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.btnRealizarPago = New System.Windows.Forms.Button()
        Me.dgvFiltro = New System.Windows.Forms.DataGridView()
        Me.btnCambiarPacientes = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.dgvImagenes = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.pnlTapa.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.lblEstado)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.btnMostrarAntecedentes)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblNumeroCitasAtendidas)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblEnviadoPor)
        Me.Panel1.Controls.Add(Me.lblCedula)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblFechaNacimiento)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblDireccionTrabajo)
        Me.Panel1.Controls.Add(Me.lblDireccionParticular)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblSaldoPendiente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(602, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 453)
        Me.Panel1.TabIndex = 3
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(279, 15)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(99, 29)
        Me.lblEstado.TabIndex = 21
        Me.lblEstado.Text = "Label21"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 29)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Estado:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(279, 151)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(99, 29)
        Me.lblTelefono.TabIndex = 19
        Me.lblTelefono.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 29)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Teléfono:"
        '
        'btnMostrarAntecedentes
        '
        Me.btnMostrarAntecedentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarAntecedentes.Location = New System.Drawing.Point(8, 385)
        Me.btnMostrarAntecedentes.Name = "btnMostrarAntecedentes"
        Me.btnMostrarAntecedentes.Size = New System.Drawing.Size(546, 54)
        Me.btnMostrarAntecedentes.TabIndex = 15
        Me.btnMostrarAntecedentes.Text = "Mostrar Antecedentes"
        Me.btnMostrarAntecedentes.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 29)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Enviado por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 333)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(198, 29)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Saldo Pendiente:"
        '
        'lblNumeroCitasAtendidas
        '
        Me.lblNumeroCitasAtendidas.AutoSize = True
        Me.lblNumeroCitasAtendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroCitasAtendidas.Location = New System.Drawing.Point(279, 298)
        Me.lblNumeroCitasAtendidas.Name = "lblNumeroCitasAtendidas"
        Me.lblNumeroCitasAtendidas.Size = New System.Drawing.Size(99, 29)
        Me.lblNumeroCitasAtendidas.TabIndex = 7
        Me.lblNumeroCitasAtendidas.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 29)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cédula:"
        '
        'lblEnviadoPor
        '
        Me.lblEnviadoPor.AutoSize = True
        Me.lblEnviadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnviadoPor.Location = New System.Drawing.Point(279, 187)
        Me.lblEnviadoPor.Name = "lblEnviadoPor"
        Me.lblEnviadoPor.Size = New System.Drawing.Size(86, 29)
        Me.lblEnviadoPor.TabIndex = 4
        Me.lblEnviadoPor.Text = "Label7"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(279, 81)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(86, 29)
        Me.lblCedula.TabIndex = 1
        Me.lblCedula.Text = "Label4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(214, 29)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Fecha Nacimiento:"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(279, 114)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(86, 29)
        Me.lblFechaNacimiento.TabIndex = 3
        Me.lblFechaNacimiento.Text = "Label6"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 29)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Direccion Particular:"
        '
        'lblDireccionTrabajo
        '
        Me.lblDireccionTrabajo.AutoSize = True
        Me.lblDireccionTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionTrabajo.Location = New System.Drawing.Point(279, 260)
        Me.lblDireccionTrabajo.Name = "lblDireccionTrabajo"
        Me.lblDireccionTrabajo.Size = New System.Drawing.Size(86, 29)
        Me.lblDireccionTrabajo.TabIndex = 6
        Me.lblDireccionTrabajo.Text = "Label9"
        '
        'lblDireccionParticular
        '
        Me.lblDireccionParticular.AutoSize = True
        Me.lblDireccionParticular.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionParticular.Location = New System.Drawing.Point(279, 223)
        Me.lblDireccionParticular.Name = "lblDireccionParticular"
        Me.lblDireccionParticular.Size = New System.Drawing.Size(86, 29)
        Me.lblDireccionParticular.TabIndex = 5
        Me.lblDireccionParticular.Text = "Label8"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(279, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(86, 29)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Label5"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(245, 29)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Direccion de Trabajo:"
        '
        'lblSaldoPendiente
        '
        Me.lblSaldoPendiente.AutoSize = True
        Me.lblSaldoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPendiente.Location = New System.Drawing.Point(279, 333)
        Me.lblSaldoPendiente.Name = "lblSaldoPendiente"
        Me.lblSaldoPendiente.Size = New System.Drawing.Size(86, 29)
        Me.lblSaldoPendiente.TabIndex = 17
        Me.lblSaldoPendiente.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "N° Citas Atendidas:"
        '
        'pnlTapa
        '
        Me.pnlTapa.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlTapa.Controls.Add(Me.lblCartel)
        Me.pnlTapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTapa.ForeColor = System.Drawing.Color.Black
        Me.pnlTapa.Location = New System.Drawing.Point(602, 22)
        Me.pnlTapa.Name = "pnlTapa"
        Me.pnlTapa.Size = New System.Drawing.Size(566, 453)
        Me.pnlTapa.TabIndex = 6
        '
        'lblCartel
        '
        Me.lblCartel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartel.Location = New System.Drawing.Point(161, 175)
        Me.lblCartel.Name = "lblCartel"
        Me.lblCartel.Size = New System.Drawing.Size(282, 125)
        Me.lblCartel.TabIndex = 0
        Me.lblCartel.Text = "SELECCIONE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UN PACIENTE"
        '
        'txbBusqueda
        '
        Me.txbBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbBusqueda.Location = New System.Drawing.Point(17, 22)
        Me.txbBusqueda.Name = "txbBusqueda"
        Me.txbBusqueda.Size = New System.Drawing.Size(515, 35)
        Me.txbBusqueda.TabIndex = 13
        '
        'btnRegistroMedico
        '
        Me.btnRegistroMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroMedico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistroMedico.Image = Global.WindowsApplication1.My.Resources.Resources._104901_1_
        Me.btnRegistroMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroMedico.Location = New System.Drawing.Point(17, 603)
        Me.btnRegistroMedico.Name = "btnRegistroMedico"
        Me.btnRegistroMedico.Size = New System.Drawing.Size(178, 75)
        Me.btnRegistroMedico.TabIndex = 16
        Me.btnRegistroMedico.Text = "Registro Médico"
        Me.btnRegistroMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistroMedico.UseVisualStyleBackColor = True
        Me.btnRegistroMedico.Visible = False
        '
        'btnRegistrarCita
        '
        Me.btnRegistrarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCita.ForeColor = System.Drawing.Color.Black
        Me.btnRegistrarCita.Image = Global.WindowsApplication1.My.Resources.Resources._42954__1_
        Me.btnRegistrarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrarCita.Location = New System.Drawing.Point(796, 603)
        Me.btnRegistrarCita.Name = "btnRegistrarCita"
        Me.btnRegistrarCita.Size = New System.Drawing.Size(171, 75)
        Me.btnRegistrarCita.TabIndex = 9
        Me.btnRegistrarCita.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cita"
        Me.btnRegistrarCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrarCita.UseVisualStyleBackColor = True
        Me.btnRegistrarCita.Visible = False
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarEstado.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarEstado.Image = Global.WindowsApplication1.My.Resources.Resources._675024_delete_512x512_1_
        Me.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarEstado.Location = New System.Drawing.Point(999, 522)
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Size = New System.Drawing.Size(172, 75)
        Me.btnCambiarEstado.TabIndex = 8
        Me.btnCambiarEstado.Text = "Volver Inactivo"
        Me.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCambiarEstado.UseVisualStyleBackColor = True
        Me.btnCambiarEstado.Visible = False
        '
        'btnModificarDatos
        '
        Me.btnModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDatos.ForeColor = System.Drawing.Color.Black
        Me.btnModificarDatos.Image = Global.WindowsApplication1.My.Resources.Resources.Users_Edit_User_icon__1_
        Me.btnModificarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarDatos.Location = New System.Drawing.Point(796, 522)
        Me.btnModificarDatos.Name = "btnModificarDatos"
        Me.btnModificarDatos.Size = New System.Drawing.Size(171, 75)
        Me.btnModificarDatos.TabIndex = 7
        Me.btnModificarDatos.Text = "Modificar Datos"
        Me.btnModificarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificarDatos.UseVisualStyleBackColor = True
        Me.btnModificarDatos.Visible = False
        '
        'btnIngresarPaciente
        '
        Me.btnIngresarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnIngresarPaciente.Image = Global.WindowsApplication1.My.Resources.Resources.add_user_icon_icons__2_
        Me.btnIngresarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIngresarPaciente.Location = New System.Drawing.Point(17, 522)
        Me.btnIngresarPaciente.Name = "btnIngresarPaciente"
        Me.btnIngresarPaciente.Size = New System.Drawing.Size(178, 75)
        Me.btnIngresarPaciente.TabIndex = 0
        Me.btnIngresarPaciente.Text = "Ingresar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paciente"
        Me.btnIngresarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIngresarPaciente.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeColumns = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPacientes.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPacientes.Location = New System.Drawing.Point(17, 70)
        Me.dgvPacientes.MultiSelect = False
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(515, 348)
        Me.dgvPacientes.TabIndex = 17
        '
        'btnRealizarPago
        '
        Me.btnRealizarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRealizarPago.Image = Global.WindowsApplication1.My.Resources.Resources.fac159a300a5cd5efbd3c544cb37d3b0_1_
        Me.btnRealizarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRealizarPago.Location = New System.Drawing.Point(999, 603)
        Me.btnRealizarPago.Name = "btnRealizarPago"
        Me.btnRealizarPago.Size = New System.Drawing.Size(169, 75)
        Me.btnRealizarPago.TabIndex = 18
        Me.btnRealizarPago.Text = "Realizar Pago"
        Me.btnRealizarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRealizarPago.UseVisualStyleBackColor = True
        Me.btnRealizarPago.Visible = False
        '
        'dgvFiltro
        '
        Me.dgvFiltro.AllowUserToAddRows = False
        Me.dgvFiltro.AllowUserToDeleteRows = False
        Me.dgvFiltro.AllowUserToResizeColumns = False
        Me.dgvFiltro.AllowUserToResizeRows = False
        Me.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiltro.Location = New System.Drawing.Point(561, 226)
        Me.dgvFiltro.Name = "dgvFiltro"
        Me.dgvFiltro.ReadOnly = True
        Me.dgvFiltro.Size = New System.Drawing.Size(25, 22)
        Me.dgvFiltro.TabIndex = 19
        Me.dgvFiltro.Visible = False
        '
        'btnCambiarPacientes
        '
        Me.btnCambiarPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPacientes.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarPacientes.Location = New System.Drawing.Point(17, 434)
        Me.btnCambiarPacientes.Name = "btnCambiarPacientes"
        Me.btnCambiarPacientes.Size = New System.Drawing.Size(515, 53)
        Me.btnCambiarPacientes.TabIndex = 20
        Me.btnCambiarPacientes.Text = "Mostrar Pacientes Inactivos"
        Me.btnCambiarPacientes.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.Black
        Me.btnCargar.Image = Global.WindowsApplication1.My.Resources.Resources.upload_file_icon_icons_com_56026__1_
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(232, 522)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(209, 75)
        Me.btnCargar.TabIndex = 21
        Me.btnCargar.Text = "Cargar Documento"
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargar.UseVisualStyleBackColor = True
        Me.btnCargar.Visible = False
        '
        'dgvImagenes
        '
        Me.dgvImagenes.AllowUserToAddRows = False
        Me.dgvImagenes.AllowUserToDeleteRows = False
        Me.dgvImagenes.AllowUserToResizeColumns = False
        Me.dgvImagenes.AllowUserToResizeRows = False
        Me.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImagenes.Location = New System.Drawing.Point(447, 522)
        Me.dgvImagenes.Name = "dgvImagenes"
        Me.dgvImagenes.ReadOnly = True
        Me.dgvImagenes.Size = New System.Drawing.Size(334, 162)
        Me.dgvImagenes.TabIndex = 22
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1300, 750)
        Me.Controls.Add(Me.dgvImagenes)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.pnlTapa)
        Me.Controls.Add(Me.btnCambiarPacientes)
        Me.Controls.Add(Me.dgvFiltro)
        Me.Controls.Add(Me.btnRealizarPago)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Controls.Add(Me.btnRegistroMedico)
        Me.Controls.Add(Me.txbBusqueda)
        Me.Controls.Add(Me.btnRegistrarCita)
        Me.Controls.Add(Me.btnCambiarEstado)
        Me.Controls.Add(Me.btnModificarDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnIngresarPaciente)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPacientes"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlTapa.ResumeLayout(False)
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresarPaciente As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNumeroCitasAtendidas As System.Windows.Forms.Label
    Friend WithEvents lblDireccionTrabajo As System.Windows.Forms.Label
    Friend WithEvents lblDireccionParticular As System.Windows.Forms.Label
    Friend WithEvents lblEnviadoPor As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCartel As System.Windows.Forms.Label
    Friend WithEvents pnlTapa As System.Windows.Forms.Panel
    Friend WithEvents btnModificarDatos As System.Windows.Forms.Button
    Friend WithEvents btnCambiarEstado As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarCita As System.Windows.Forms.Button
    Friend WithEvents txbBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistroMedico As System.Windows.Forms.Button
    Friend WithEvents btnMostrarAntecedentes As System.Windows.Forms.Button
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnRealizarPago As System.Windows.Forms.Button
    Friend WithEvents lblSaldoPendiente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvFiltro As System.Windows.Forms.DataGridView
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnCambiarPacientes As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents dgvImagenes As System.Windows.Forms.DataGridView

End Class
