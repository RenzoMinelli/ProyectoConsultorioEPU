﻿Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Module ModuloUtilidades
    Public user As String = "root"
    Public pass As String = ""
    Dim ubicacion As String = "server=localhost; user id= 'root'  ; password='';database = consultorio"

    Public Conexion As MySqlDataAdapter = New MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)

    Public conex As Boolean
    Public ver As Integer = 0
    Public id_p As Integer

    Public frmContenedor As New Form
    Public rutaGuardadoFotos As String = "Imagen VB" 'Ruta en la que se guardarán las imágenes cargadas: "Escritorio\Imágenes VB"

    Public respint As Integer
    Public respString As String
    Public respString2 As String

    Public screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Public Sub cambiarUsuario(ByVal us As String, ByVal pas As String)

        ubicacion = "server=localhost; user id= '" + us + "'  ; password='" + pas + "'; database = consultorio"
        Conexion = New MySqlDataAdapter
        MysqlConexion = New MySqlConnection(ubicacion)


    End Sub

    '////////////////Posicionamiento///////////////////////////
    Public xf, yf As Integer
    Public xco, yco As Integer
    Public xc, yc As Integer
    '///////////////////////////////////////////////////////


    Public Sub consultar()
        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
            MysqlConexion.Close()
            conex = True
        Catch ex As Exception
            conex = False
        End Try

    End Sub


    Public Sub MuestraMsgBoxVersatil(ByVal texto As String, ByVal tipo As Integer)
        frmFondoTransparente.Show()
        If tipo = 0 Then

            Dim msgbv As New MsgBoxVersatil()
            msgbv.lblTexto.Location = New Point(27, 50)
            msgbv.lblTexto.Text = texto
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Sí"
            msgbv.btnNo.Text = "No"
            msgbv.txbRespuesta.Visible = False


            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respint = msgbv.respuestaInt
            Else
                respint = 0
            End If
            frmFondoTransparente.Dispose()
            msgbv.Dispose()

        ElseIf tipo = 1 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblTexto.Text = texto
            msgbv.lblTexto.TextAlign = ContentAlignment.TopCenter
            msgbv.btnNo.Visible = False
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Aceptar"
            msgbv.btnSi.Location = New Point(msgbv.Width / 2 - msgbv.btnSi.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.txbRespuesta.Location = New Point(msgbv.Width / 2 - msgbv.txbRespuesta.Width / 2, msgbv.txbRespuesta.Location.Y)
            msgbv.txbRespuesta.Visible = True


            msgbv.txbRespuesta.Focus()
            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respString = msgbv.respuestaString
            Else
                respString = "Error"
            End If
            frmFondoTransparente.Dispose()
            msgbv.Dispose()

        ElseIf tipo = 2 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblTexto.Text = texto
            msgbv.lblTexto.Location = New Point(msgbv.Width / 2 - msgbv.lblTexto.Width / 2, msgbv.lblTexto.Location.Y)
            msgbv.lblTexto.TextAlign = ContentAlignment.TopCenter
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Aceptar"
            msgbv.btnNo.Text = "Cancelar"
            msgbv.btnSi.Location = New Point(msgbv.Width / 4 - msgbv.btnSi.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.btnNo.Location = New Point(msgbv.Width / 4 * 3 - msgbv.btnNo.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.txbRespuesta.Location = New Point(msgbv.Width / 2 - msgbv.txbRespuesta.Width / 2, msgbv.txbRespuesta.Location.Y)
            msgbv.txbRespuesta.Visible = True

            msgbv.txbRespuesta.Focus()
            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respString = msgbv.respuestaString
                respint = msgbv.respuestaInt
            Else
                respString = "Error"
                respint = 0
            End If
            frmFondoTransparente.Dispose()
            msgbv.Dispose()

        ElseIf tipo = 3 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblOpcional.Visible = True
            msgbv.lblTexto.Text = "¿Qué realizo?"
            msgbv.lblOpcional.Text = "Monto"
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnNo.Text = "Cancelar"
            msgbv.btnSi.Text = "Aceptar"
            msgbv.txbOpcional.Visible = True
            msgbv.txbRespuesta.Visible = True
            msgbv.btnSi.Location = New Point(msgbv.Width / 4 - msgbv.btnSi.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.btnNo.Location = New Point(msgbv.Width / 4 * 3 - msgbv.btnNo.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.lblOpcional.Location = New Point(7, 78)
            msgbv.lblTexto.Location = New Point(7, 174)
            msgbv.txbOpcional.Location = New Point(198, 78)
            msgbv.txbRespuesta.Location = New Point(198, 174)
            msgbv.lblOpcional.Focus()

            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respString = msgbv.respuestaString
                respString2 = msgbv.txbOpcional.Text

                respint = msgbv.respuestaInt
            Else
                respString = "Error"
                respint = 0
            End If

            frmFondoTransparente.Dispose()
            msgbv.Dispose()

        End If

    End Sub



End Module









