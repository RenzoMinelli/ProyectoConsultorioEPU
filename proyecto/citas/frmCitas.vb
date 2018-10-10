﻿Public Class frmCitas

    Public fechaCita As String
    Public horaCita As String
    Public idcita As Integer

    Dim hora2, horadgv, horadgv2 As TimeSpan

    Public fechita, dia, FCalendario As String
    Dim DiaSeleccionado As System.DateTime

   
    Private Sub Citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvDatosCita.Hide()

        LabelDia.Hide()
        seleccionado.Hide()

        dgvHora.ColumnCount = 7

        dgvHora.Columns(0).HeaderText = "Horarios"
        dgvHora.Columns(1).HeaderText = "Lunes"
        dgvHora.Columns(2).HeaderText = "Martes"
        dgvHora.Columns(3).HeaderText = "Miercoles"
        dgvHora.Columns(4).HeaderText = "Jueves"
        dgvHora.Columns(5).HeaderText = "Viernes"
        dgvHora.Columns(6).HeaderText = "Sábado"

        dgvHora.Rows.Add("8:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("8:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("9:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("9:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("10:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("10:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("11:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("11:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("12:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("12:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("13:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("13:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("14:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("14:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("15:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("15:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("16:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("16:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("17:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("17:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("18:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("18:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("19:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("19:30", "", "", "", "", "", "")
        dgvHora.Rows.Add("20:00", "", "", "", "", "", "")
        dgvHora.Rows.Add("20:30", "", "", "", "", "", "")

        actCitas()

        btnMarcarCita.Visible = False
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        frmAranceles.Show()
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        frmPacientes.Show()
    End Sub

    Private Sub SaveFileDialog3_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCita.Click
        horaCita = dgvHora.CurrentRow.Cells(0).Value.ToString

        DiaSeleccionado = MCFecha.SelectionRange.Start
        FCalendario = Weekday(DiaSeleccionado)

        Select Case dgvHora.CurrentCell.ColumnIndex
            Case 1

                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                        
                    Case "4"
                        fechaCita = DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd")
                        
                    Case "5"
                        fechaCita = DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd")
                        
                    Case "6"
                        fechaCita = DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd")
                        
                    Case "7"
                        fechaCita = DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd")

                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-6).ToString("yyyy-MM-dd")
                        
                End Select

            Case 2
                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                        
                    Case "4"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                        
                    Case "5"
                        fechaCita = DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd")

                    Case "6"
                        fechaCita = DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd")
                        
                    Case "7"
                        fechaCita = DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd")
                        
                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd")
                       
                End Select

            Case 3
                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd")
                        
                    Case "4"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                        
                    Case "5"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                        
                    Case "6"
                        fechaCita = DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd")
                        
                    Case "7"
                        fechaCita = DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd")

                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd")
                        
                End Select
            Case 4
                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd")
                        
                    Case "4"
                        fechaCita = DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd")
                        
                    Case "5"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                        
                    Case "6"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                        
                    Case "7"
                        fechaCita = DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd")
                        
                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd")
                        
                End Select
            Case 5
                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd")
                     
                    Case "4"
                        fechaCita = DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd")
                        
                    Case "5"
                        fechaCita = DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd")
                      
                    Case "6"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                        
                    Case "7"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                      
                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd")
                       
                End Select
            Case 6
                Select Case FCalendario

                    Case "2"
                        fechaCita = DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd")
                        
                    Case "3"
                        fechaCita = DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd")
                       
                    Case "4"
                        fechaCita = DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd")
                       
                    Case "5"
                        fechaCita = DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd")

                    Case "6"
                        fechaCita = DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd")
                    Case "7"
                        fechaCita = DiaSeleccionado.ToString("yyyy-MM-dd")
                       
                    Case "1"
                        fechaCita = DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd")
                        
                End Select

        End Select

        Me.Hide()
        frmContenedor = frmAgregarCita
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()
        frmAgregarCita.dgvPacientes.ClearSelection()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarCita.Click

        Me.Hide()
        frmContenedor = frmMarcarCitaConcluida
        frmContenedor.MdiParent = frmMenuInicio
        frmContenedor.Dock = DockStyle.Fill
        frmContenedor.Show()

    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        btnMarcarCita.Visible = True
        'Aca le asigno el valor a idPaciente y de idCita cuando se hace click en la tabla
        'idcita = dgvLunes.CurrentRow.Cells(3).Value
        'Mira que id_p es una variable global que se usa en todo el programa, no es necesario crear otra xd
        'id_p = dgvLunes.CurrentRow.Cells(4).Value
    End Sub





    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub dgvHora_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHora.CellClick
        If user = "odontologo" Or user = "root" Then

            If dgvHora.CurrentCell.Value = "" Then
                btnMarcarCita.Hide()
                btnAgregarCita.Show()
            Else
                btnAgregarCita.Hide()
            End If

            DiaSeleccionado = MCFecha.SelectionRange.Start
            FCalendario = Weekday(DiaSeleccionado)

            Dim verificar As Integer = 0
            Dim indice As Integer = 1
            Dim row As Integer
            If dgvHora.CurrentCell.Value <> "" Then
                While verificar = 0
                    If dgvHora.CurrentRow.Index - indice > 0 Then
                        If dgvHora.Rows(dgvHora.CurrentRow.Index - indice).Cells(dgvHora.CurrentCell.ColumnIndex).Value = dgvHora.CurrentCell.Value Then

                            indice += 1

                        Else
                            verificar = 1
                            row = dgvHora.CurrentRow.Index - (indice - 1)

                        End If
                    Else

                        verificar = 1
                        row = dgvHora.CurrentRow.Index - (indice - 1)

                    End If
                    

                End While
            End If

            Select Case dgvHora.CurrentCell.ColumnIndex

                Case 1

                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-6).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select

                Case 2
                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"

                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla

                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select

                Case 3
                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select
                Case 4
                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select
                Case 5
                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select
                Case 6
                    Select Case FCalendario

                        Case "2"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "3"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "4"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "5"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "6"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "7"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                        Case "1"
                            Consulta = "select id_c, p.id_p, fecha, hora,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), p.apellido from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                            consultar()
                            dgvDatosCita.DataSource = Tabla
                    End Select

            End Select



            ' MsgBox("dia act: " + FCalendario.ToString + " dia selec: " + dgvHora.CurrentCell.ColumnIndex.ToString)
            ' viendo en que linea se selecciono ver en que hora esta
            'en un for ver la tabla aux
            'if comparando la hora de las citas con la hora de la cita seleccionada del (current row) y menor a la siguiente (current row.index(+1))


            If dgvDatosCita.RowCount <> 0 Then

                Dim numero As Integer = dgvDatosCita.RowCount - 1
                For x = numero To 0 Step -1


                    hora2 = TimeSpan.Parse(dgvDatosCita.Rows(x).Cells(3).Value.ToString)


                    horadgv = TimeSpan.Parse(dgvHora.Rows(row).Cells(0).Value.ToString)


                    horadgv2 = TimeSpan.Parse(dgvHora.Rows(row + 1).Cells(0).Value.ToString)

                   
                    If hora2 < horadgv Or hora2 >= horadgv2 Then

                        dgvDatosCita.Rows.Remove(dgvDatosCita.Rows(x))

                    End If

                Next

            End If

            If dgvHora.CurrentCell.Value <> "" And dgvHora.CurrentCell.ColumnIndex <> 0 Then



                id_p = dgvDatosCita.Rows(0).Cells(1).Value
                idcita = dgvDatosCita.Rows(0).Cells(0).Value

                btnMarcarCita.Show()

            Else
                dgvDatosCita.DataSource = Nothing

            End If

        End If

    End Sub

    Public Sub actCitas()
        For x = 0 To dgvHora.RowCount - 1
            dgvHora.Rows(x).Cells(1).Value = ""
            dgvHora.Rows(x).Cells(1).Style.BackColor = Color.White
            dgvHora.Rows(x).Cells(2).Value = ""
            dgvHora.Rows(x).Cells(2).Style.BackColor = Color.White
            dgvHora.Rows(x).Cells(3).Value = ""
            dgvHora.Rows(x).Cells(3).Style.BackColor = Color.White
            dgvHora.Rows(x).Cells(4).Value = ""
            dgvHora.Rows(x).Cells(4).Style.BackColor = Color.White
            dgvHora.Rows(x).Cells(5).Value = ""
            dgvHora.Rows(x).Cells(5).Style.BackColor = Color.White
            dgvHora.Rows(x).Cells(6).Value = ""
            dgvHora.Rows(x).Cells(6).Style.BackColor = Color.White
        Next

        Try
            DiaSeleccionado = MCFecha.SelectionRange.Start
            FCalendario = Weekday(DiaSeleccionado)



            ''En un case se muestran los datos de la semana seleccionada por el usuario
            Select Case FCalendario

                Case "2"


                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(1).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(2).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(3).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(4).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(5).ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value

                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre


                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If

                                        IndHoras += 1

                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then

                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If

                                        IndHoras += 1
                                    Next


                                    Exit For


                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre


                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then

                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre
                                        
                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If

                                        IndHoras += 1

                                    Next



                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), duracion, atendida  from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then

                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "3"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-1).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(1).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(2).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(3).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(4).ToString("dd")


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For


                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                Case "4"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-2).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(-1).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(1).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(2).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(3).ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If



                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "5"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-3).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(-2).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(-1).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(1).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(2).ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "6"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-4).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(-3).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(-2).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(-1).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(1).ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "7"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-5).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(-4).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(-3).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(-2).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(-1).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If
                Case "1"

                    dgvHora.Columns(1).HeaderText = "Lunes " + DiaSeleccionado.AddDays(-6).ToString("dd")
                    dgvHora.Columns(2).HeaderText = "Martes " + DiaSeleccionado.AddDays(-5).ToString("dd")
                    dgvHora.Columns(3).HeaderText = "Miércoles " + DiaSeleccionado.AddDays(-4).ToString("dd")
                    dgvHora.Columns(4).HeaderText = "Jueves " + DiaSeleccionado.AddDays(-3).ToString("dd")
                    dgvHora.Columns(5).HeaderText = "Viernes " + DiaSeleccionado.AddDays(-2).ToString("dd")
                    dgvHora.Columns(6).HeaderText = "Sábado " + DiaSeleccionado.AddDays(-1).ToString("dd")

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-6).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(1).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(1).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-5).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(2).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(2).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next

                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ),duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-4).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(3).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(3).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-3).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(4).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(4).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If


                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-2).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(5).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(5).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If

                    Consulta = "select hora ,  concat(concat(upper(left(nombre,1)), lower(substring(nombre from 2))),' ',concat(upper(left(apellido,1)), lower(substring(apellido from 2))) ), duracion, atendida from cita c inner join paciente p on p.id_p = c.id_p where fecha = '" + DiaSeleccionado.AddDays(-1).ToString("yyyy-MM-dd") + "';"
                    consultar()


                    dgvConsultaDia.DataSource = Tabla


                    If Not dgvConsultaDia.RowCount = 0 Then



                        Dim hora As TimeSpan
                        Dim nombre As String

                        For indice = 0 To dgvConsultaDia.RowCount - 1


                            hora = dgvConsultaDia.Rows(indice).Cells(0).Value
                            nombre = dgvConsultaDia.Rows(indice).Cells(1).Value

                            For IndHoras = 0 To 25


                                Dim posicion As TimeSpan

                                posicion = TimeSpan.Parse(dgvHora.Rows(IndHoras).Cells(0).Value.ToString)

                                If hora < posicion Then


                                    For indice2 = 1 To dgvConsultaDia.Rows(indice).Cells(2).Value
                                        dgvHora.Rows(IndHoras - 1).Cells(6).Value = nombre

                                        If dgvConsultaDia.Rows(indice).Cells(3).Value = 0 Then
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.LightBlue
                                        Else
                                            dgvHora.Rows(IndHoras - 1).Cells(6).Style.BackColor = Color.Orange
                                        End If
                                        IndHoras += 1
                                    Next
                                    Exit For
                                End If

                            Next
                        Next

                    End If
            End Select



        Catch ex As Exception
            MsgBox("Error al cargar citas", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub MCFecha_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MCFecha.DateChanged
        actCitas()
    End Sub

 
End Class
