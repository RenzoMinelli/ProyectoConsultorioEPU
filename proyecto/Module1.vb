﻿Imports System.Data
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
    Public nombre As String
    Public cedula As String
    Public telefono As String
    Public direccion As String
    Public enviado As String
    Public direTra As String
    Public nac As String
    Public saldo As Integer
    Public id_p As Integer



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
End Module









