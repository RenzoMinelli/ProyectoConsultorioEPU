Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Module Module1
    Public user As String = "root"
    Public pass As String = ""
    Dim ubicacion As String = "server=localhost; user id= '" + user + "'  ; password='" + pass + "';database = consultorio_odontologico"

    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String
    Public MysqlConexion As MySqlConnection = New MySqlConnection(ubicacion)

    Public conex As Boolean

    Public id_p As Integer

    Public frmContenedor As New Form

    Public respint As Integer
    Public respString As String

    Public screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Public screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    '////////////////Posicionamiento///////////////////////////
    Public xf, yf As Integer

    Public Sub actPos()

        xf = Menu_Inicio.Location.X
        yf = Menu_Inicio.Location.Y

    End Sub
    '///////////////////////////////////////////////////////


    Public Sub consultar()
        Try
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
        Catch ex As Exception
            'MsgBox(ex.ToString)
            conex = False
        End Try

    End Sub

    Public Sub veriCon()
        Try

            Consulta = "select * from aranceles"
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)
            conex = True

        Catch ex As Exception

            conex = False

        End Try

    End Sub
    Public Sub MuestraMsgBoxVersatil(ByVal texto As String, ByVal tipo As Integer)
        frmFondoTransparente.Show()
        If tipo = 0 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblTexto.Text = texto
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Sí"
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
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Aceptar"
            msgbv.btnNo.Text = "Cancelar"
            msgbv.btnSi.Location = New Point(msgbv.Width / 4 - msgbv.btnSi.Width / 2, msgbv.btnSi.Location.Y)
            msgbv.btnSi.Location = New Point(msgbv.Width / 4 * 3 - msgbv.btnNo.Width / 2, msgbv.btnSi.Location.Y)
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

        End If

    End Sub
   

End Module









