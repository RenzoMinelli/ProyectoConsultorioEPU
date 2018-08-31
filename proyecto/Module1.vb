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
        If tipo = 0 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblTexto.Text = texto
            msgbv.btnNo.Visible = True
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Sí"
            msgbv.TextBox1.Visible = False
            msgbv.Location = New Point(23, 222)

            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respint = msgbv.respuestaInt
            Else
                respint = 0
            End If
            msgbv.Dispose()

        ElseIf tipo = 1 Then

            Dim msgbv As New MsgBoxVersatil()

            msgbv.lblTexto.Text = texto
            msgbv.btnNo.Visible = False
            msgbv.btnSi.Visible = True
            msgbv.btnSi.Text = "Aceptar"
            msgbv.TextBox1.Visible = True
            msgbv.Location = New Point(262, 208)

            'Determinar si el formulario esta listo para seguir
            If msgbv.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'Obtener la respuesta ingresada
                respString = msgbv.respuestaString
            Else
                respString = "Error"
            End If
            msgbv.Dispose()

        End If
       
    End Sub
   

End Module









