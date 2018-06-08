Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class antecedentes

    Public antecedentes As SqlConnection = New SqlConnection("C:\Users\Renzo\Downloads\consultorio_odontologico (6).sql")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Property DataSource As DataTable

    Public Sub Conectar()
        Try
            antecedentes.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            antecedentes.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, antecedentes)
        cmb = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)
    End Sub

    Function Insertar(ByVal sql)
        antecedentes.Open()
        comando = New SqlCommand(sql, antecedentes)
        Dim a As Integer = comando.ExecuteNonQuery()
        If (a > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Eliminar(ByVal tabla, ByVal condicion)
        antecedentes.Open()
        Dim elimina As String = "delete from" + tabla + "where" + condicion
        comando = New SqlCommand(elimina, antecedentes)
        Dim a As Integer = comando.ExecuteNonQuery()
        antecedentes.Close()
        If (a > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Modificar(ByVal tabla, ByVal campos, ByVal condicion)
        antecedentes.Open()
        Dim modifica As String = "update" + tabla + "set" + campos + "where" + condicion
        comando = New SqlCommand(modifica, antecedentes)
        Dim a As Integer = comando.ExecuteNonQuery()
        antecedentes.Close()
        If (a > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
