Public Class marcar_cita
    Dim id_c As Integer
    Dim cambiador11 As Boolean = False
    Dim cambiador12 As Boolean = False
    Dim cambiador13 As Boolean = False
    Dim cambiador14 As Boolean = False
    Dim cambiador15 As Boolean = False
    Dim cambiador16 As Boolean = False
    Dim cambiador17 As Boolean = False
    Dim cambiador18 As Boolean = False
    Dim cambiador21 As Boolean = False
    Dim cambiador22 As Boolean = False
    Dim cambiador23 As Boolean = False
    Dim cambiador24 As Boolean = False
    Dim cambiador25 As Boolean = False
    Dim cambiador26 As Boolean = False
    Dim cambiador27 As Boolean = False
    Dim cambiador28 As Boolean = False
    Dim cambiador31 As Boolean = False
    Dim cambiador32 As Boolean = False
    Dim cambiador33 As Boolean = False
    Dim cambiador34 As Boolean = False
    Dim cambiador35 As Boolean = False
    Dim cambiador36 As Boolean = False
    Dim cambiador37 As Boolean = False
    Dim cambiador38 As Boolean = False
    Dim cambiador41 As Boolean = False
    Dim cambiador42 As Boolean = False
    Dim cambiador43 As Boolean = False
    Dim cambiador44 As Boolean = False
    Dim cambiador45 As Boolean = False
    Dim cambiador46 As Boolean = False
    Dim cambiador47 As Boolean = False
    Dim cambiador48 As Boolean = False
    Dim diente11 As Integer = 0
    Dim diente12 As Integer = 0
    Dim diente13 As Integer = 0
    Dim diente14 As Integer = 0
    Dim diente15 As Integer = 0
    Dim diente16 As Integer = 0
    Dim diente17 As Integer = 0
    Dim diente18 As Integer = 0
    Dim diente21 As Integer = 0
    Dim diente22 As Integer = 0
    Dim diente23 As Integer = 0
    Dim diente24 As Integer = 0
    Dim diente25 As Integer = 0
    Dim diente26 As Integer = 0
    Dim diente27 As Integer = 0
    Dim diente28 As Integer = 0
    Dim diente31 As Integer = 0
    Dim diente32 As Integer = 0
    Dim diente33 As Integer = 0
    Dim diente34 As Integer = 0
    Dim diente35 As Integer = 0
    Dim diente36 As Integer = 0
    Dim diente37 As Integer = 0
    Dim diente38 As Integer = 0
    Dim diente41 As Integer = 0
    Dim diente42 As Integer = 0
    Dim diente43 As Integer = 0
    Dim diente44 As Integer = 0
    Dim diente45 As Integer = 0
    Dim diente46 As Integer = 0
    Dim diente47 As Integer = 0
    Dim diente48 As Integer = 0
    Dim zona1 As String = "arriba-izquierda"
    Dim zona2 As String = "arriba-derecha"
    Dim zona3 As String = "abajo-derecha"
    Dim zona4 As String = "abajo-izquierda"
    Dim diente11f As String
    Dim diente12f As String
    Dim diente13f As String
    Dim diente14f As String
    Dim diente15f As String
    Dim diente16f As String
    Dim diente17f As String
    Dim diente18f As String
    Dim diente21f As String
    Dim diente22f As String
    Dim diente23f As String
    Dim diente24f As String
    Dim diente25f As String
    Dim diente26f As String
    Dim diente27f As String
    Dim diente28f As String
    Dim diente31f As String
    Dim diente32f As String
    Dim diente33f As String
    Dim diente34f As String
    Dim diente35f As String
    Dim diente36f As String
    Dim diente37f As String
    Dim diente38f As String
    Dim diente41f As String
    Dim diente42f As String
    Dim diente43f As String
    Dim diente44f As String
    Dim diente45f As String
    Dim diente46f As String
    Dim diente47f As String
    Dim diente48f As String



    Private Sub imgdiente1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente18.Click
        diente18 = diente18 + 1
        cambiador18 = True
        Select Case diente18
            Case 0
                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaBlanco
                diente18f = "normal"
            Case 1
                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                diente18f = "precaucion"
            Case 2
                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaRojo
                diente18f = "alerta"
            Case 3
                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaNegro
                diente18f = "ausente"
            Case 4
                pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaBlanco
                diente18f = "normal"
                diente18 = 0

        End Select


    End Sub

    Private Sub imgdiente2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente17.Click
        diente17 = diente17 + 1
        cambiador17 = True
        Select Case diente17
            Case 0
                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaBlanco
                diente17f = "normal"
            Case 1
                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                diente17f = "precaucion"
            Case 2
                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaRojo
                diente17f = "alerta"
            Case 3
                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaNegro
                diente17f = "ausente"
            Case 4
                pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaBlanco
                diente17f = "normal"
                diente17 = 0

        End Select
    End Sub

    Private Sub imgdiente3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente16.Click
        diente16 = diente16 + 1
        cambiador16 = True
        Select Case diente16
            Case 0
                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                diente16f = "normal"
            Case 1
                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                diente16f = "precaucion"
            Case 2
                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaRojo
                diente16f = "alerta"
            Case 3
                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaNegro
                diente16f = "ausente"
            Case 4
                pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                diente16f = "normal"
                diente16 = 0

        End Select
    End Sub

    Private Sub imgdiente4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente15.Click
        diente15 = diente15 + 1
        cambiador15 = True
        Select Case diente15
            Case 0
                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                diente15f = "normal"
            Case 1
                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                diente15f = "precaucion"
            Case 2
                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaRojo
                diente15f = "alerta"
            Case 3
                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaNegro
                diente15f = "ausente"
            Case 4
                pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                diente15 = 0
                diente15f = "normal"

        End Select
    End Sub

    Private Sub imgdiente5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente14.Click
        diente14 = diente14 + 1
        cambiador14 = True
        Select Case diente14
            Case 0
                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                diente14f = "normal"
            Case 1
                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                diente14f = "precaucion"
            Case 2
                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaRojo
                diente14f = "alerta"
            Case 3
                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaNegro
                diente14f = "ausente"
            Case 4
                pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                diente14 = 0
                diente14f = "normal"

        End Select
    End Sub

    Private Sub imgdiente6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente13.Click
        diente13 = diente13 + 1
        cambiador13 = True
        Select Case diente13
            Case 0
                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                diente13f = "normal"
            Case 1
                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                diente13f = "precaucion"

            Case 2
                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaRojo
                diente13f = "alerta"
            Case 3
                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaNegro
                diente13f = "ausente"
            Case 4
                pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                diente13 = 0
                diente13f = "normal"

        End Select
    End Sub

    Private Sub imgdiente7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente12.Click
        diente12 = diente12 + 1
        cambiador12 = True
        Select Case diente12
            Case 0
                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaBlanco
                diente12f = "normal"
            Case 1
                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                diente12f = "precaucion"
            Case 2
                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaRojo
                diente12f = "alerta"
            Case 3
                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaNegro
                diente12f = "ausente"
            Case 4
                pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaBlanco
                diente12 = 0
                diente12f = "normal"

        End Select
    End Sub

    Private Sub imgdiente8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente11.Click
        diente11 = diente11 + 1
        cambiador11 = True
        Select Case diente11
            Case 0
                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                diente11f = "normal"
            Case 1
                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                diente11f = "precaucion"
            Case 2
                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaRojo
                diente11f = "alerta"
            Case 3
                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaNegro
                diente11f = "ausente"
            Case 4
                pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                diente11 = 0
                diente11f = "normal"

        End Select
    End Sub

    Private Sub imgdiente9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente21.Click
        diente21 = diente21 + 1
        cambiador21 = True
        Select Case diente21
            Case 0
                pbDiente21.Image = My.Resources.AI1
                diente21f = "normal"
            Case 1
                pbDiente21.Image = My.Resources.AI1a
                diente21f = "precaucion"
            Case 2
                pbDiente21.Image = My.Resources.AI1r
                diente21f = "alerta"
            Case 3
                pbDiente21.Image = My.Resources.AI1n
                diente21f = "ausente"
            Case 4
                pbDiente21.Image = My.Resources.AI1
                diente21 = 0
                diente21f = "normal"

        End Select
    End Sub

    Private Sub imgdiente10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente22.Click
        diente22 = diente22 + 1
        cambiador22 = True
        Select Case diente22
            Case 0
                pbDiente22.Image = My.Resources.AI2
                diente22f = "normal"
            Case 1
                pbDiente22.Image = My.Resources.AI2a
                diente22f = "precaucion"
            Case 2
                pbDiente22.Image = My.Resources.AI2r
                diente22f = "alerta"
            Case 3
                pbDiente22.Image = My.Resources.AI2n
                diente22f = "ausente"
            Case 4
                pbDiente22.Image = My.Resources.AI2
                diente21 = 0
                diente22f = "normal"

        End Select

    End Sub

    Private Sub imgdiente11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente23.Click
        diente23 = diente23 + 1
        cambiador23 = True
        Select Case diente23
            Case 0
                pbDiente23.Image = My.Resources.AI3
                diente23f = "normal"
            Case 1
                pbDiente23.Image = My.Resources.AI3a
                diente23f = "precaucion"
            Case 2
                pbDiente23.Image = My.Resources.AI3r
                diente23f = "alerta"
            Case 3
                pbDiente23.Image = My.Resources.AI3n
                diente23f = "ausente"
            Case 4
                pbDiente23.Image = My.Resources.AI3
                diente23 = 0
                diente23f = "normal"

        End Select
    End Sub


    Private Sub imgdientenor4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente24.Click
        ''''''''''''''''''''''
        ''''''''''''''''''''''
        '''''''''''''''''''''' LA IMAGEN AI4N DEBERIA SER NEGRA PERO ES LA ROJA POR LO CUAL ESTAN INVERTIDAS
        ''''''''''''''''''''''
        ''''''''''''''''''''''
        ''''''''''''''''''''''
        diente24 = diente24 + 1
        cambiador24 = True
        Select Case diente24
            Case 0
                pbDiente24.Image = My.Resources.AI4
                diente24f = "normal"
            Case 1
                pbDiente24.Image = My.Resources.AI4a
                diente24f = "precaucion"
            Case 2
                pbDiente24.Image = My.Resources.AI4n
                diente24f = "alerta"
            Case 3
                pbDiente24.Image = My.Resources.AI4r
                diente24f = "ausente"
            Case 4
                pbDiente24.Image = My.Resources.AI4
                diente24 = 0
                diente24f = "normal"

        End Select
    End Sub

    Private Sub imgdiente12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente25.Click
        diente25 = diente25 + 1
        cambiador25 = True
        Select Case diente25
            Case 0
                pbDiente25.Image = My.Resources.AI5
                diente25f = "normal"
            Case 1
                pbDiente25.Image = My.Resources.AI5a
                diente25f = "precaucion"
            Case 2
                pbDiente25.Image = My.Resources.AI5r
                diente25f = "alerta"
            Case 3
                pbDiente25.Image = My.Resources.AI5n
                diente25f = "ausente"
            Case 4
                pbDiente25.Image = My.Resources.AI5
                diente25 = 0
                diente25f = "normal"

        End Select
    End Sub

    Private Sub imgdiente13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente26.Click
        diente26 = diente26 + 1
        cambiador26 = True
        Select Case diente26
            Case 0
                pbDiente26.Image = My.Resources.AI6
                diente26f = "normal"
            Case 1
                pbDiente26.Image = My.Resources.AI6a
                diente26f = "precaucion"
            Case 2
                pbDiente26.Image = My.Resources.AI6r
                diente26f = "alerta"
            Case 3
                pbDiente26.Image = My.Resources.AI6n
                diente26f = "ausente"
            Case 4
                pbDiente26.Image = My.Resources.AI6
                diente26 = 0
                diente26f = "normal"

        End Select
    End Sub

    Private Sub imgdiente14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente27.Click
        diente27 = diente27 + 1
        cambiador27 = True
        Select Case diente27
            Case 0
                pbDiente27.Image = My.Resources.AI7
                diente27f = "normal"
            Case 1
                pbDiente27.Image = My.Resources.AI7a
                diente27f = "precaucion"
            Case 2
                pbDiente27.Image = My.Resources.AI7r
                diente27f = "alerta"
            Case 3
                pbDiente27.Image = My.Resources.AI7n
                diente27f = "ausente"
            Case 4
                pbDiente27.Image = My.Resources.AI7
                diente27 = 0
                diente27f = "normal"

        End Select
    End Sub

    Private Sub imgdiente15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente28.Click
        diente28 = diente28 + 1
        cambiador28 = True
        Select Case diente28
            Case 0
                pbDiente28.Image = My.Resources.AI8
                diente28f = "normal"
            Case 1
                pbDiente28.Image = My.Resources.AI8a
                diente28f = "precaucion"
            Case 2
                pbDiente28.Image = My.Resources.AI8r
                diente28f = "alerta"
            Case 3
                pbDiente28.Image = My.Resources.AI8n
                diente28f = "ausente"
            Case 4
                pbDiente28.Image = My.Resources.AI8
                diente28 = 0
                diente28f = "normal"

        End Select
    End Sub

    Private Sub imgdiente16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente48.Click
        diente48 = diente48 + 1
        cambiador48 = True
        Select Case diente48
            Case 0
                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaBlanco
                diente48f = "normal"
            Case 1
                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                diente48f = "precaucion"
            Case 2
                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaRojo
                diente48f = "alerta"
            Case 3
                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaNegro
                diente48f = "ausente"
            Case 4
                pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaBlanco
                diente48 = 0
                diente48f = "normal"

        End Select
    End Sub

    Private Sub imgdiente17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente47.Click
        diente47 = diente47 + 1
        cambiador47 = True
        Select Case diente47
            Case 0
                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                diente47f = "normal"
            Case 1
                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                diente47f = "precaucion"
            Case 2
                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaRojo
                diente47f = "alerta"
            Case 3
                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaNegro
                diente47f = "ausente"
            Case 4
                pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                diente47 = 0
                diente47f = "normal"

        End Select
    End Sub

    Private Sub imgdiente18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente46.Click
        diente46 = diente46 + 1
        cambiador46 = True
        Select Case diente46
            Case 0
                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                diente46f = "normal"
            Case 1
                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                diente46f = "precaucion"
            Case 2
                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaRojo
                diente46f = "alerta"
            Case 3
                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaNegro
                diente46f = "ausente"
            Case 4
                pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                diente46 = 0
                diente46f = "normal"

        End Select
    End Sub

    Private Sub imgdiente19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente45.Click
        diente45 = diente45 + 1
        cambiador45 = True
        Select Case diente45
            Case 0
                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                diente45f = "normal"
            Case 1
                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                diente45f = "precaucion"
            Case 2
                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaRojo
                diente45f = "alerta"
            Case 3
                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaNegro
                diente45f = "ausente"
            Case 4
                pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                diente45 = 0
                diente45f = "normal"

        End Select
    End Sub

    Private Sub imgdiente20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente44.Click
        diente44 = diente44 + 1
        cambiador44 = True
        Select Case diente44
            Case 0
                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                diente44f = "normal"
            Case 1
                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                diente44f = "precaucion"
            Case 2
                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaRojo
                diente44f = "alerta"
            Case 3
                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaNegro
                diente44f = "ausente"
            Case 4
                pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                diente44 = 0
                diente44f = "normal"

        End Select
    End Sub


    Private Sub imgdiente21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente43.Click
        diente43 = diente43 + 1
        cambiador43 = True
        Select Case diente43
            Case 0
                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaBlanco
                diente43f = "normal"
            Case 1
                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                diente43f = "precaucion"
            Case 2
                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaRojo
                diente43f = "alerta"
            Case 3
                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaNegro
                diente43f = "ausente"
            Case 4
                pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaBlanco
                diente43 = 0
                diente43f = "normal"

        End Select
    End Sub

    Private Sub imgdiente22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente42.Click
        diente42 = diente42 + 1
        cambiador42 = True
        Select Case diente42
            Case 0
                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                diente42f = "normal"
            Case 1
                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                diente42f = "precaucion"
            Case 2
                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaRojo
                diente42f = "alerta"
            Case 3
                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaNegro
                diente42f = "ausente"
            Case 4
                pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                diente42 = 0
                diente42f = "normal"

        End Select
    End Sub

    Private Sub imgdiente23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente41.Click
        MsgBox("click")
        diente41 = diente41 + 1
        cambiador41 = True
        Select Case diente41
            Case 0
                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                diente41f = "normal"
            Case 1
                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaAmarillo
                diente41f = "precaucion"
            Case 2
                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaRojo
                diente41f = "alerta"
            Case 3
                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaNegro
                diente41f = "ausente"
            Case 4
                pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                diente41 = 0
                diente41f = "normal"

        End Select
    End Sub

    Private Sub imgdiente24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente31.Click
        diente31 = diente31 + 1
        cambiador31 = True
        Select Case diente31
            Case 0
                pbDiente31.Image = My.Resources.BI1
                diente31f = "normal"
            Case 1
                pbDiente31.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                diente31f = "precaucion"
            Case 2
                pbDiente31.Image = My.Resources.Diente4AbajoIzquierdaRojo
                diente31f = "alerta"
            Case 3
                pbDiente31.Image = My.Resources.Diente4AbajoIzquierdaNegro
                diente31f = "ausente"
            Case 4
                pbDiente31.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                diente31 = 0
                diente31f = "normal"

        End Select
    End Sub

    Private Sub imgdiente25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente32.Click
        diente32 = diente32 + 1
        cambiador32 = True
        Select Case diente32
            Case 0
                pbDiente32.Image = My.Resources.BI2
                diente32f = "normal"
            Case 1
                pbDiente32.Image = My.Resources.BI2a
                diente32f = "precaucion"
            Case 2
                pbDiente32.Image = My.Resources.BI2r
                diente32f = "alerta"
            Case 3
                pbDiente32.Image = My.Resources.BI2n
                diente32f = "ausente"
            Case 4
                pbDiente32.Image = My.Resources.BI2
                diente32 = 0
                diente32f = "normal"

        End Select
    End Sub

    Private Sub imgdiente26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente33.Click
        diente33 = diente33 + 1
        cambiador33 = True
        Select Case diente33
            Case 0
                pbDiente33.Image = My.Resources.BI3
                diente33f = "normal"
            Case 1
                pbDiente33.Image = My.Resources.BI3a
                diente33f = "precaucion"
            Case 2
                pbDiente33.Image = My.Resources.BI3r
                diente33f = "alerta"
            Case 3
                pbDiente33.Image = My.Resources.BI3n
                diente33f = "ausente"
            Case 4
                pbDiente33.Image = My.Resources.BI3
                diente33 = 0
                diente33f = "normal"

        End Select
    End Sub

    Private Sub imgdiente27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente34.Click
        diente34 = diente34 + 1
        cambiador34 = True
        Select Case diente34
            Case 0
                pbDiente34.Image = My.Resources.BI4
                diente34f = "normal"
            Case 1
                pbDiente34.Image = My.Resources.BI4a
                diente34f = "precaucion"
            Case 2
                pbDiente34.Image = My.Resources.BI4r
                diente34f = "alerta"
            Case 3
                pbDiente34.Image = My.Resources.BI4n
                diente34f = "ausente"
            Case 4
                pbDiente34.Image = My.Resources.BI4
                diente34 = 0
                diente34f = "normal"

        End Select
    End Sub

    Private Sub imgdiente28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente35.Click
        diente35 = diente35 + 1
        cambiador35 = True
        Select Case diente35
            Case 0
                pbDiente35.Image = My.Resources.BI5
                diente35f = "normal"
            Case 1
                pbDiente35.Image = My.Resources.BI5a
                diente35f = "precaucion"
            Case 2
                pbDiente35.Image = My.Resources.BI5r
                diente35f = "alerta"
            Case 3
                pbDiente35.Image = My.Resources.BI5n
                diente35f = "ausente"
            Case 4
                pbDiente35.Image = My.Resources.BI5
                diente35 = 0
                diente35f = "normal"

        End Select
    End Sub

    Private Sub imgdiente29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente36.Click
        diente36 = diente36 + 1
        cambiador36 = True
        Select Case diente36
            Case 0
                pbDiente36.Image = My.Resources.BI6
                diente36f = "normal"
            Case 1
                pbDiente36.Image = My.Resources.BI6a
                diente36f = "precaucion"
            Case 2
                pbDiente36.Image = My.Resources.BI6r
                diente36f = "alerta"
            Case 3
                pbDiente36.Image = My.Resources.BI6n
                diente36f = "ausente"
            Case 4
                pbDiente36.Image = My.Resources.BI6
                diente36 = 0
                diente36f = "normal"

        End Select
    End Sub

    Private Sub imgdiente30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente37.Click
        diente37 = diente37 + 1
        cambiador37 = True
        Select Case diente37
            Case 0
                pbDiente37.Image = My.Resources.BI7
                diente37f = "normal"
            Case 1
                pbDiente37.Image = My.Resources.BI7a
                diente37f = "precaucion"
            Case 2
                pbDiente37.Image = My.Resources.BI7r
                diente37f = "alerta"
            Case 3
                pbDiente37.Image = My.Resources.BI7n
                diente37f = "ausente"
            Case 4
                pbDiente37.Image = My.Resources.BI7
                diente37 = 0
                diente37f = "normal"

        End Select
    End Sub

    Private Sub imgdiente31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDiente38.Click
        diente38 = diente38 + 1
        cambiador38 = True
        Select Case diente38
            Case 0
                pbDiente38.Image = My.Resources.BI8
                diente38f = "normal"
            Case 1
                pbDiente38.Image = My.Resources.BI8a
                diente38f = "precaucion"
            Case 2
                pbDiente38.Image = My.Resources.BI8r
                diente38f = "alerta"
            Case 3
                pbDiente38.Image = My.Resources.BI8n
                diente38f = "ausente"
            Case 4
                pbDiente38.Image = My.Resources.BI8
                diente38 = 0
                diente38f = "normal"

        End Select
    End Sub


    Private Sub bttoningrdientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttoningrdientes.Click
        ' zona1 arriba-izquierda(diente 1 a 8):
        If cambiador11 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente11f + "','" + zona1 + "', '1', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador12 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente12f + "','" + zona1 + "', '2', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador13 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente13f + "','" + zona1 + "', '3', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador14 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente14f + "','" + zona1 + "', '4', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador15 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente15f + "','" + zona1 + "', '5', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador16 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente16f + "','" + zona1 + "', '6', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador17 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente17f + "','" + zona1 + "', '7', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador18 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente18f + "','" + zona1 + "', '8', '" + Citas.idcita.ToString + "');")
            consultar()
        End If


        ' zona 2 arriba-derecha(diente 9 a 15)


        If cambiador21 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente21f + "','" + zona2 + "', '1', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador22 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente22f + "','" + zona2 + "', '2', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador23 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente23f + "','" + zona2 + "', '3', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador24 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente24f + "','" + zona2 + "', '4', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador25 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente25f + "','" + zona2 + "', '5', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador26 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente26f + "','" + zona2 + "', '6', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador27 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente27f + "','" + zona2 + "', '7', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador28 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente28f + "','" + zona2 + "', '8', '" + Citas.idcita.ToString + "');")
            consultar()
        End If


        ' zona 3 abajo-izquierda(diente 16 a 23)



        If cambiador31 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente31f + "','" + zona3 + "', '1', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador32 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente32f + "','" + zona3 + "', '2', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador33 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente33f + "','" + zona3 + "', '3', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador34 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente34f + "','" + zona3 + "', '4', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador35 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente35f + "','" + zona3 + "', '5', '" + Citas.idcita.ToString + "');")
        End If
        If cambiador36 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente36f + "','" + zona3 + "', '6', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador37 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente37f + "','" + zona3 + "', '7', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador38 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente38f + "','" + zona3 + "', '8', '" + Citas.idcita.ToString + "');")
            consultar()
        End If


        ' zona 4 abajo-derecha(diente 23 a 31)


        If cambiador41 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente41f + "','" + zona4 + "', '1', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador42 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente42f + "','" + zona4 + "', '2', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador43 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente43f + "','" + zona4 + "', '3', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador44 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente44f + "','" + zona4 + "', '4', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador45 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente45f + "','" + zona4 + "', '5', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador46 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente46f + "','" + zona4 + "', '6', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador47 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente47f + "','" + zona4 + "', '7', '" + Citas.idcita.ToString + "');")
            consultar()
        End If
        If cambiador48 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,id_c) values ('" + id_p.ToString + "','" + diente48f + "','" + zona4 + "', '8', '" + Citas.idcita.ToString + "');")
            consultar()
        End If


        Citas.Show()
        Me.Dispose()
    End Sub



    Private Sub marcar_cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim zona As String = ""
        Try
            Consulta = "Select r.descripcion, zona, nro_diente, fecha from registro_medico r left join cita c on c.id_c = r.id_c where r.id_p = '" + Str(id_p) + "';"
            consultar()
            DataGridView1.DataSource = Tabla
            DataGridView1.Sort(DataGridView1.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

            For x As Integer = 0 To DataGridView1.RowCount - 1
                zona = ""
                If Not IsDBNull(DataGridView1.Rows(x).Cells(1).Value) Then

                    Select Case DataGridView1.Rows(x).Cells(1).Value

                        Case "arriba-izquierda"
                            zona = "1"
                        Case "arriba-derecha"
                            zona = "2"
                        Case "abajo-derecha"
                            zona = "3"
                        Case "abajo-izquierda"
                            zona = "4"

                    End Select

                    zona += DataGridView1.Rows(x).Cells(2).Value.ToString



                    Select Case zona
                        Case "11"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaRojo
                                    diente11 = 2
                                    diente11f = "alerta"
                                Case "precaucion"
                                    pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                                    diente11 = 1
                                    diente11f = "alerta"
                                Case "ausente"
                                    pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaNegro
                                    diente11 = 3
                                    diente11f = "ausente"
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                                    diente11 = 0
                                    diente11f = "normal"
                            End Select
                        Case "12"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaRojo
                                    diente11 = 2
                                    diente11f = "alerta"
                                Case "precaucion"
                                    pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                                    diente11 = 1
                                    diente11f = "precaucion"
                                Case "ausente"
                                    pbDiente12.Image = My.Resources.Diente2ArribaIzquierdaNegro
                                    diente11 = 3
                                    diente11f = "ausente"
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente2ArribaIzquierdaBlanco
                                    diente11 = 0
                                    diente11f = "normal"

                            End Select
                        Case "13"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente13.Image = My.Resources.Diente3ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                            End Select
                        Case "14"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente14.Image = My.Resources.Diente4ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                            End Select
                        Case "15"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente15.Image = My.Resources.Diente5ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                            End Select
                        Case "16"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente16.Image = My.Resources.Diente6ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                            End Select
                        Case "17"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente17.Image = My.Resources.Diente7ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente7ArribaIzquierdaBlanco
                            End Select
                        Case "18"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente18.Image = My.Resources.Diente8ArribaIzquierdaNegro
                                Case Else
                                    pbDiente11.Image = My.Resources.Diente8ArribaIzquierdaBlanco
                            End Select


                            ''arriba izquierda



                        Case "21"

                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaNegro
                                Case Else
                                    pbDiente21.Image = My.Resources.Diente1ArribaIzquierdaBlanco
                            End Select

                            pbDiente21.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "22"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaNegro
                                Case Else
                                    pbDiente22.Image = My.Resources.Diente2ArribaIzquierdaBlanco
                            End Select

                            pbDiente22.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "23"

                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaRojo
                                Case Else
                                    pbDiente23.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                            End Select

                            pbDiente23.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "24"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaNegro
                                Case Else
                                    pbDiente24.Image = My.Resources.Diente4ArribaIzquierdaBlanco
                            End Select

                            pbDiente24.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "25"

                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaNegro
                                Case Else
                                    pbDiente25.Image = My.Resources.Diente5ArribaIzquierdaBlanco
                            End Select

                            pbDiente25.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "26"

                            Select Case DataGridView1.Rows(x).Cells(0).Value

                                Case "alerta"
                                    pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaNegro
                                Case Else
                                    pbDiente26.Image = My.Resources.Diente6ArribaIzquierdaBlanco
                            End Select

                            pbDiente26.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "27"

                            Select Case DataGridView1.Rows(x).Cells(0).Value

                                Case "alerta"
                                    pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaNegro
                                Case Else
                                    pbDiente27.Image = My.Resources.Diente7ArribaIzquierdaBlanco

                            End Select

                            pbDiente27.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "28"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaRojo
                                Case "precaucion"
                                    pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaNegro
                                Case Else
                                    pbDiente28.Image = My.Resources.Diente8ArribaIzquierdaBlanco
                            End Select
                            pbDiente28.Image.RotateFlip(RotateFlipType.Rotate180FlipY)


                            ''abajo derecha

                        Case "31"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaNegro
                                Case Else
                                    pbDiente31.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                            End Select

                            pbDiente31.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        Case "32"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaNegro
                                Case Else
                                    pbDiente32.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                            End Select

                            pbDiente32.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "33"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaNegro
                                Case Else
                                    pbDiente33.Image = My.Resources.Diente3AbajoIzquierdaBlanco
                            End Select

                            pbDiente33.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "34"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaNegro
                                Case Else
                                    pbDiente34.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                            End Select

                            pbDiente34.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "35"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaNegro
                                Case Else
                                    pbDiente35.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                            End Select

                            pbDiente35.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "36"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaNegro
                                Case Else
                                    pbDiente36.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                            End Select

                            pbDiente36.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "37"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaNegro
                                Case Else
                                    pbDiente37.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                            End Select

                            pbDiente37.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                        Case "38"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaNegro
                                Case Else
                                    pbDiente38.Image = My.Resources.Diente8AbajoIzquierdaBlanco
                            End Select

                            pbDiente38.Image.RotateFlip(RotateFlipType.Rotate180FlipY)

                            ''abajo izquierda


                        Case "41"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaNegro
                                Case Else
                                    pbDiente41.Image = My.Resources.Diente1AbajoIzquierdaBlanco
                            End Select
                        Case "42"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaNegro
                                Case Else
                                    pbDiente42.Image = My.Resources.Diente2AbajoIzquierdaBlanco
                            End Select
                        Case "43"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente43.Image = My.Resources.Diente3AbajoIzquierdaNegro
                                Case Else
                                    pbDiente43.Image = My.Resources.Diente3ArribaIzquierdaBlanco
                            End Select
                        Case "44"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaNegro
                                Case Else
                                    pbDiente44.Image = My.Resources.Diente4AbajoIzquierdaBlanco
                            End Select
                        Case "45"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaNegro
                                Case Else
                                    pbDiente45.Image = My.Resources.Diente5AbajoIzquierdaBlanco
                            End Select
                        Case "46"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaNegro
                                Case Else
                                    pbDiente46.Image = My.Resources.Diente6AbajoIzquierdaBlanco
                            End Select
                        Case "47"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaNegro
                                Case Else
                                    pbDiente47.Image = My.Resources.Diente7AbajoIzquierdaBlanco
                            End Select
                        Case "48"
                            Select Case DataGridView1.Rows(x).Cells(0).Value
                                Case "alerta"
                                    pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaRojo
                                Case "precaucion"
                                    pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaAmarillo
                                Case "ausente"
                                    pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaNegro
                                Case Else
                                    pbDiente48.Image = My.Resources.Diente8AbajoIzquierdaBlanco
                            End Select
                    End Select

                End If
            Next

        Catch ex As Exception
            MsgBox("Error al cargar el estado de los dientes", MsgBoxStyle.Exclamation)
        End Try
       
    End Sub
End Class