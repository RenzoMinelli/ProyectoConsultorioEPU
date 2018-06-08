Public Class Form1

    Dim antecedentes As antecedentes = New antecedentes

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'antecedentes.Conectar()
        'MostrarDatos()
    End Sub
    Public Sub MostrarDatos()
        'antecedentes.Consulta("select * from antecedentes", "antecedentes")
        'antecedentes.DataSource = antecedentes.ds.Tables("antecedentes")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim agregar As String = "insert into antecedentes values (" + txtid_p.Text + ",'" + txtalergicos.Text + ",'" + txtfiebre_reumatica.Text + ",'" + txtfarmacos_recibidos.Text + ",'" + txtdiabeticos.Text + ",'" + txtfamiliares.Text + ",'" + txtcardiovasculares.Text + ",'" + txtodontologicos.Text + ",'" + txttratamiento_medico.Text + "')"
        Consulta = agregar
        consultar()
        'If (antecedentes.Insertar(agregar)) Then
        'MessageBox.Show("Antecedentes agregados correctamente")
        'MostrarDatos()
        'Else
        'MessageBox.Show("Error al agregar")
        'End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'If (antecedentes.Eliminar("antecedentes", "id_p= " + txtid_p.Text)) Then
        'MessageBox.Show("Antecedentes eliminados correctamente")
        'MostrarDatos()
        'Else
        'MessageBox.Show("Error al eliminar")
        'End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim actualizar As String = "alergicos ='" + txtalergicos.Text + "', fiebre_reumatica ='" + txtfiebre_reumatica.Text + "', farmacos_recibidos ='" + txtfarmacos_recibidos.Text + "', diabeticos ='" + txtdiabeticos.Text + "',coagulacion ='" + "',familiares ='" + txtfamiliares.Text + "',cardiovasculares ='" + txtcardiovasculares.Text + "',odontologicos ='" + txtodontologicos.Text + "',tratamiento_medico ='" + txttratamiento_medico.Text  '"
        Consulta = actualizar
        consultar()
        'If (antecedentes.Modificar("antecedentes", Editar, "id_p =" + txtid_p.Text)) Then
        'MessageBox.Show("Antecedentes actualizados")
        ' MostrarDatos()
        'Else
        'MessageBox.Show("Error al actualizar")
        ' End If
    End Sub

  

    Private Function txtalergicos() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtfiebre_reumatica() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtfarmacos_recibidos() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtdiabeticos() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtfamiliares() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtcardiovasculares() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtodontologicos() As Object
        Throw New NotImplementedException
    End Function

    Private Function txttratamiento_medico() As Object
        Throw New NotImplementedException
    End Function

    Private Function Editar() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtid_p() As Object
        Throw New NotImplementedException
    End Function

End Class