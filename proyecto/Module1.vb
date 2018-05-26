Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Module Module1

    Dim ubicacion As String = "server=localhost; user id=root ; password='';database = consultorio_odontologico"
    Public Conexion As MySqlDataAdapter
    Public Tabla As DataTable
    Public Consulta As String

    Public conex As Boolean
    Public nombre As String
    Public cedula As String
    Public direccion As String
    Public enviado As String
    Public direTra As String
    Public nac As String
    Public saldo As Integer
    Public id_p As Integer

    Public Sub consultar()
        Try

            Conexion = New MySqlDataAdapter(Consulta, ubicacion)
            Tabla = New DataTable
            Conexion.Fill(Tabla)

        Catch ex As MySqlException

            'MsgBox(ex.ToString)

        End Try

    End Sub
    Public Sub veriCon()
        Try
            conex = True
            Consulta = "select * from paciente"
            Conexion = New MySqlDataAdapter(Consulta, ubicacion)

        Catch ex As Exception

            conex = False

        End Try
        ' MsgBox(Str(conex))
    End Sub
End Module
