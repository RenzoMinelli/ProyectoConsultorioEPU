Public Class marcar_cita
    Dim id_c As Integer
    Dim cambiador1 As Boolean = False
    Dim cambiador2 As Boolean = False
    Dim cambiador3 As Boolean = False
    Dim cambiador4 As Boolean = False
    Dim cambiador5 As Boolean = False
    Dim cambiador6 As Boolean = False
    Dim cambiador7 As Boolean = False
    Dim cambiador8 As Boolean = False
    Dim cambiador9 As Boolean = False
    Dim cambiador10 As Boolean = False
    Dim cambiador11 As Boolean = False
    Dim cambiador12 As Boolean = False
    Dim cambiador13 As Boolean = False
    Dim cambiador14 As Boolean = False
    Dim cambiador15 As Boolean = False
    Dim cambiador16 As Boolean = False
    Dim cambiador17 As Boolean = False
    Dim cambiador18 As Boolean = False
    Dim cambiador19 As Boolean = False
    Dim cambiador20 As Boolean = False
    Dim cambiador21 As Boolean = False
    Dim cambiador22 As Boolean = False
    Dim cambiador23 As Boolean = False
    Dim cambiador24 As Boolean = False
    Dim cambiador25 As Boolean = False
    Dim cambiador26 As Boolean = False
    Dim cambiador27 As Boolean = False
    Dim cambiador28 As Boolean = False
    Dim cambiador29 As Boolean = False
    Dim cambiador30 As Boolean = False
    Dim cambiador31 As Boolean = False
    Dim cambiador32 As Boolean = False
    Dim diente1 As Integer = 0
    Dim diente2 As Integer = 0
    Dim diente3 As Integer = 0
    Dim diente4 As Integer = 0
    Dim diente5 As Integer = 0
    Dim diente6 As Integer = 0
    Dim diente7 As Integer = 0
    Dim diente8 As Integer = 0
    Dim diente9 As Integer = 0
    Dim diente10 As Integer = 0
    Dim diente11 As Integer = 0
    Dim diente12 As Integer = 0
    Dim diente13 As Integer = 0
    Dim diente14 As Integer = 0
    Dim diente15 As Integer = 0
    Dim diente16 As Integer = 0
    Dim diente17 As Integer = 0
    Dim diente18 As Integer = 0
    Dim diente19 As Integer = 0
    Dim diente20 As Integer = 0
    Dim diente21 As Integer = 0
    Dim diente22 As Integer = 0
    Dim diente23 As Integer = 0
    Dim diente24 As Integer = 0
    Dim diente25 As Integer = 0
    Dim diente26 As Integer = 0
    Dim diente27 As Integer = 0
    Dim diente28 As Integer = 0
    Dim diente29 As Integer = 0
    Dim diente30 As Integer = 0
    Dim diente31 As Integer = 0
    Dim diente32 As Integer = 0
    Dim zona1 As String = "arriba-izquierda"
    Dim zona2 As String = "ariba-derecha"
    Dim zona3 As String = "abajo-izquierda"
    Dim zona4 As String = "abajo-derecha"
    Dim diente1f As String
    Dim diente2f As String
    Dim diente3f As String
    Dim diente4f As String
    Dim diente5f As String
    Dim diente6f As String
    Dim diente7f As String
    Dim diente8f As String
    Dim diente9f As String
    Dim diente10f As String
    Dim diente11f As String
    Dim diente12f As String
    Dim diente13f As String
    Dim diente14f As String
    Dim diente15f As String
    Dim diente16f As String
    Dim diente17f As String
    Dim diente18f As String
    Dim diente19f As String
    Dim diente20f As String
    Dim diente21f As String
    Dim diente22f As String
    Dim diente23f As String
    Dim diente24f As String
    Dim diente25f As String
    Dim diente26f As String
    Dim diente27f As String
    Dim diente28f As String
    Dim diente29f As String
    Dim diente30f As String
    Dim diente31f As String
    Dim diente32f As String


    Private Sub imgdiente1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente1.Click
        diente1 = diente1 + 1
        cambiador1 = True
        Select Case diente1
            Case 0
                imgdiente1.Image = My.Resources.AD8
                diente1f = "blanco"
            Case 1
                imgdiente1.Image = My.Resources._8aa
                diente1f = "amarillo"
            Case 2
                imgdiente1.Image = My.Resources._8a
                diente1f = "rojo"
            Case 3
                imgdiente1.Image = My.Resources._8na
                diente1f = "negro"
            Case 4
                imgdiente1.Image = My.Resources.AD8
                diente1f = "blanco"
                diente1 = 0
                cambiador1 = False
        End Select


    End Sub

    Private Sub imgdiente2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente2.Click
        diente2 = diente2 + 1
        Select Case diente2
            Case 0
                imgdiente2.Image = My.Resources.AD71
                diente2f = "blanco"
            Case 1
                imgdiente2.Image = My.Resources._7aa
                diente2f = "amarillo"
            Case 2
                imgdiente2.Image = My.Resources._7a
                diente2f = "rojo"
            Case 3
                imgdiente2.Image = My.Resources._7na
                diente2f = "negro"
            Case 4
                imgdiente2.Image = My.Resources.AD71
                diente2f = "blanco"
                diente2 = 0
        End Select
    End Sub

    Private Sub imgdiente3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente3.Click
        diente3 = diente3 + 1
        Select Case diente3
            Case 0
                imgdiente3.Image = My.Resources.AD6
                diente3f = "blanco"
            Case 1
                imgdiente3.Image = My.Resources._6aa
                diente3f = "amarillo"
            Case 2
                imgdiente3.Image = My.Resources._6a
                diente3f = "rojo"
            Case 3
                imgdiente3.Image = My.Resources._6na
                diente3f = "negro"
            Case 4
                imgdiente3.Image = My.Resources.AD6
                diente3f = "blanco"
                diente3 = 0
        End Select
    End Sub

    Private Sub imgdiente4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente4.Click
        diente4 = diente4 + 1
        Select Case diente4
            Case 0
                imgdiente4.Image = My.Resources.AD5
                diente4f = "blanco"
            Case 1
                imgdiente4.Image = My.Resources._5aa
                diente4f = "amarillo"
            Case 2
                imgdiente4.Image = My.Resources._5a
                diente4f = "rojo"
            Case 3
                imgdiente4.Image = My.Resources._5na
                diente4f = "negro"
            Case 4
                imgdiente4.Image = My.Resources.AD5
                diente4 = 0
                diente4f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente5.Click
        diente5 = diente5 + 1
        Select Case diente5
            Case 0
                imgdiente5.Image = My.Resources.AD4
                diente5f = "blanco"
            Case 1
                imgdiente5.Image = My.Resources._4aa
                diente5f = "amarillo"
            Case 2
                imgdiente5.Image = My.Resources._4a
                diente5f = "rojo"
            Case 3
                imgdiente5.Image = My.Resources._4na
                diente5f = "negro"
            Case 4
                imgdiente5.Image = My.Resources.AD4
                diente5 = 0
                diente5f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente6.Click
        diente6 = diente6 + 1
        Select Case diente6
            Case 0
                imgdiente6.Image = My.Resources.AD3
                diente6f = "blanco"
            Case 1
                imgdiente6.Image = My.Resources._3aa
                diente6f = "amarillo"

            Case 2
                imgdiente6.Image = My.Resources._3a
                diente6f = "rojo"
            Case 3
                imgdiente6.Image = My.Resources._3na
                diente6f = "negro"
            Case 4
                imgdiente6.Image = My.Resources.AD3
                diente6 = 0
                diente6f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente7.Click
        diente7 = diente7 + 1
        Select Case diente7
            Case 0
                imgdiente7.Image = My.Resources.AD2
                diente7f = "blanco"
            Case 1
                imgdiente7.Image = My.Resources._2aa
                diente7f = "amarillo"
            Case 2
                imgdiente7.Image = My.Resources._2a
                diente7f = "rojo"
            Case 3
                imgdiente7.Image = My.Resources._2na
                diente7f = "negro"
            Case 4
                imgdiente7.Image = My.Resources.AD2
                diente7 = 0
                diente7f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente8.Click
        diente8 = diente8 + 1
        Select Case diente8
            Case 0
                imgdiente8.Image = My.Resources.AD1
                diente8f = "blanco"
            Case 1
                imgdiente8.Image = My.Resources._1aa
                diente8f = "amarillo"
            Case 2
                imgdiente8.Image = My.Resources._1a
                diente8f = "rojo"
            Case 3
                imgdiente8.Image = My.Resources._1na
                diente8f = "negro"
            Case 4
                imgdiente8.Image = My.Resources.AD1
                diente8 = 0
                diente8f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente9.Click
        diente9 = diente9 + 1
        Select Case diente9
            Case 0
                imgdiente9.Image = My.Resources.AI1
                diente9f = "blanco"
            Case 1
                imgdiente9.Image = My.Resources.AI1a
                diente9f = "amarillo"
            Case 2
                imgdiente9.Image = My.Resources.AI1r
                diente9f = "rojo"
            Case 3
                imgdiente9.Image = My.Resources.AI1n
                diente9f = "negro"
            Case 4
                imgdiente9.Image = My.Resources.AI1
                diente9 = 0
                diente9f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente10.Click
        diente10 = diente10 + 1
        Select Case diente10
            Case 0
                imgdiente10.Image = My.Resources.AI2
                diente10f = "blanco"
            Case 1
                imgdiente10.Image = My.Resources.AI2a
                diente10f = "amarillo"
            Case 2
                imgdiente10.Image = My.Resources.AI2r
                diente10f = "rojo"
            Case 3
                imgdiente10.Image = My.Resources.AI2n
                diente10f = "negro"
            Case 4
                imgdiente10.Image = My.Resources.AI2
                diente10 = 0
                diente10f = "blanco"
        End Select

    End Sub

    Private Sub imgdiente11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente11.Click
        diente11 = diente11 + 1
        Select Case diente11
            Case 0
                imgdiente11.Image = My.Resources.AI3
                diente11f = "blanco"
            Case 1
                imgdiente11.Image = My.Resources.AI3a
                diente11f = "amarillo"
            Case 2
                imgdiente11.Image = My.Resources.AI3r
                diente11f = "rojo"
            Case 3
                imgdiente11.Image = My.Resources.AI3n
                diente11f = "negro"
            Case 4
                imgdiente11.Image = My.Resources.AI3
                diente11 = 0
                diente11f = "blanco"
        End Select
    End Sub


    Private Sub imgdientenor4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdientenor4.Click
        diente12 = diente12 + 1
        Select Case diente12
            Case 0
                imgdientenor4.Image = My.Resources.AI4
                diente12f = "blanco"
            Case 1
                imgdientenor4.Image = My.Resources.AI4a
                diente12f = "amarillo"
            Case 2
                imgdientenor4.Image = My.Resources.AI4r
                diente12f = "rojo"
            Case 3
                imgdientenor4.Image = My.Resources.AI4n
                diente12f = "negro"
            Case 4
                imgdientenor4.Image = My.Resources.AI4
                diente12 = 0
                diente12f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente12.Click
        diente13 = diente13 + 1
        Select Case diente13
            Case 0
                imgdiente12.Image = My.Resources.AI5
                diente13f = "blanco"
            Case 1
                imgdiente12.Image = My.Resources.AI5a
                diente13f = "amarillo"
            Case 2
                imgdiente12.Image = My.Resources.AI5r
                diente13f = "rojo"
            Case 3
                imgdiente12.Image = My.Resources.AI5n
                diente13f = "negro"
            Case 4
                imgdiente12.Image = My.Resources.AI5
                diente13 = 0
                diente13f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente13.Click
        diente14 = diente14 + 1
        Select Case diente14
            Case 0
                imgdiente13.Image = My.Resources.AI6
                diente14f = "blanco"
            Case 1
                imgdiente13.Image = My.Resources.AI6a
                diente14f = "amarillo"
            Case 2
                imgdiente13.Image = My.Resources.AI6r
                diente14f = "rojo"
            Case 3
                imgdiente13.Image = My.Resources.AI6n
                diente14f = "negro"
            Case 4
                imgdiente13.Image = My.Resources.AI6
                diente14 = 0
                diente14f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente14.Click
        diente15 = diente15 + 1
        Select Case diente15
            Case 0
                imgdiente14.Image = My.Resources.AI7
                diente15f = "blanco"
            Case 1
                imgdiente14.Image = My.Resources.AI7a
                diente15f = "amarillo"
            Case 2
                imgdiente14.Image = My.Resources.AI7r
                diente15f = "rojo"
            Case 3
                imgdiente14.Image = My.Resources.AI7n
                diente15f = "negro"
            Case 4
                imgdiente14.Image = My.Resources.AI7
                diente15 = 0
                diente15f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente15.Click
        diente16 = diente16 + 1
        Select Case diente16
            Case 0
                imgdiente15.Image = My.Resources.AI8
                diente16f = "blanco"
            Case 1
                imgdiente15.Image = My.Resources.AI8a
                diente16f = "amarillo"
            Case 2
                imgdiente15.Image = My.Resources.AI8r
                diente16f = "rojo"
            Case 3
                imgdiente15.Image = My.Resources.AI8n
                diente16f = "negro"
            Case 4
                imgdiente15.Image = My.Resources.AI8
                diente16 = 0
                diente16f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente16.Click
        diente17 = diente17 + 1
        Select Case diente17
            Case 0
                imgdiente16.Image = My.Resources.BD8
                diente17f = "blanco"
            Case 1
                imgdiente16.Image = My.Resources._8ab
                diente17f = "amarillo"
            Case 2
                imgdiente16.Image = My.Resources._8b
                diente17f = "rojo"
            Case 3
                imgdiente16.Image = My.Resources._8nb
                diente17f = "negro"
            Case 4
                imgdiente16.Image = My.Resources.BD8
                diente17 = 0
                diente17f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente17.Click
        diente18 = diente18 + 1
        Select Case diente18
            Case 0
                imgdiente17.Image = My.Resources.BD7
                diente18f = "blanco"
            Case 1
                imgdiente17.Image = My.Resources._7ab
                diente18f = "amarillo"
            Case 2
                imgdiente17.Image = My.Resources._7b
                diente18f = "rojo"
            Case 3
                imgdiente17.Image = My.Resources._7nb
                diente18f = "negro"
            Case 4
                imgdiente17.Image = My.Resources.BD7
                diente18 = 0
                diente18f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente18.Click
        diente19 = diente19 + 1
        Select Case diente19
            Case 0
                imgdiente18.Image = My.Resources.BD6
                diente19f = "blanco"
            Case 1
                imgdiente18.Image = My.Resources._6ab
                diente19f = "amarillo"
            Case 2
                imgdiente18.Image = My.Resources._6b
                diente19f = "rojo"
            Case 3
                imgdiente18.Image = My.Resources._6nb
                diente19f = "negro"
            Case 4
                imgdiente18.Image = My.Resources.BD6
                diente19 = 0
                diente19f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente19.Click
        diente20 = diente20 + 1
        Select Case diente20
            Case 0
                imgdiente19.Image = My.Resources.BD5
                diente20f = "blanco"
            Case 1
                imgdiente19.Image = My.Resources._5ab
                diente20f = "amarillo"
            Case 2
                imgdiente19.Image = My.Resources._5b
                diente20f = "rojo"
            Case 3
                imgdiente19.Image = My.Resources._5nb
                diente20f = "negro"
            Case 4
                imgdiente19.Image = My.Resources.BD5
                diente20 = 0
                diente20f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente20.Click
        diente21 = diente21 + 1
        Select Case diente21
            Case 0
                imgdiente20.Image = My.Resources.BD4
                diente21f = "blanco"
            Case 1
                imgdiente20.Image = My.Resources._4ab
                diente21f = "amarillo"
            Case 2
                imgdiente20.Image = My.Resources._4b
                diente21f = "rojo"
            Case 3
                imgdiente20.Image = My.Resources._4nb
                diente21f = "negro"
            Case 4
                imgdiente20.Image = My.Resources.BD4
                diente21 = 0
                diente21f = "blanco"
        End Select
    End Sub


    Private Sub imgdiente21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente21.Click
        diente22 = diente22 + 1
        Select Case diente22
            Case 0
                imgdiente21.Image = My.Resources.BD3
                diente22f = "blanco"
            Case 1
                imgdiente21.Image = My.Resources._3ab
                diente22f = "amarillo"
            Case 2
                imgdiente21.Image = My.Resources._3b
                diente22f = "rojo"
            Case 3
                imgdiente21.Image = My.Resources._3nb
                diente22f = "negro"
            Case 4
                imgdiente21.Image = My.Resources.BD3
                diente22 = 0
                diente22f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente22.Click
        diente23 = diente23 + 1
        Select Case diente23
            Case 0
                imgdiente22.Image = My.Resources.BD2
                diente23f = "blanco"
            Case 1
                imgdiente22.Image = My.Resources._2ab
                diente23f = "amarillo"
            Case 2
                imgdiente22.Image = My.Resources._2b
                diente23f = "rojo"
            Case 3
                imgdiente22.Image = My.Resources._2nb
                diente23f = "negro"
            Case 4
                imgdiente22.Image = My.Resources.BD2
                diente23 = 0
                diente23f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente23.Click
        diente24 = diente24 + 1
        Select Case diente24
            Case 0
                imgdiente23.Image = My.Resources.BD1
                diente24f = "blanco"
            Case 1
                imgdiente23.Image = My.Resources._1ab
                diente24f = "amarillo"
            Case 2
                imgdiente23.Image = My.Resources._1b
                diente24f = "rojo"
            Case 3
                imgdiente23.Image = My.Resources._1nb
                diente24f = "negro"
            Case 4
                imgdiente23.Image = My.Resources.BD1
                diente24 = 0
                diente24f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente24.Click
        diente25 = diente25 + 1
        Select Case diente25
            Case 0
                imgdiente24.Image = My.Resources.BI1
                diente25f = "blanco"
            Case 1
                imgdiente24.Image = My.Resources._4ab
                diente25f = "amarillo"
            Case 2
                imgdiente24.Image = My.Resources._4b
                diente25f = "rojo"
            Case 3
                imgdiente24.Image = My.Resources._4nb
                diente25f = "negro"
            Case 4
                imgdiente24.Image = My.Resources.BD4
                diente25 = 0
                diente25f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente25.Click
        diente26 = diente26 + 1
        Select Case diente26
            Case 0
                imgdiente25.Image = My.Resources.BI2
                diente26f = "blanco"
            Case 1
                imgdiente25.Image = My.Resources.BI2a
                diente26f = "amarillo"
            Case 2
                imgdiente25.Image = My.Resources.BI2r
                diente26f = "rojo"
            Case 3
                imgdiente25.Image = My.Resources.BI2n
                diente26f = "negro"
            Case 4
                imgdiente25.Image = My.Resources.BI2
                diente26 = 0
                diente26f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente26.Click
        diente27 = diente27 + 1
        Select Case diente27
            Case 0
                imgdiente26.Image = My.Resources.BI3
                diente27f = "blanco"
            Case 1
                imgdiente26.Image = My.Resources.BI3a
                diente27f = "amarillo"
            Case 2
                imgdiente26.Image = My.Resources.BI3r
                diente27f = "rojo"
            Case 3
                imgdiente26.Image = My.Resources.BI3n
                diente27f = "negro"
            Case 4
                imgdiente26.Image = My.Resources.BI3
                diente27 = 0
                diente27f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente27.Click
        diente28 = diente28 + 1
        Select Case diente28
            Case 0
                imgdiente27.Image = My.Resources.BI4
                diente28f = "blanco"
            Case 1
                imgdiente27.Image = My.Resources.BI4a
                diente28f = "amarillo"
            Case 2
                imgdiente27.Image = My.Resources.BI4r
                diente28f = "rojo"
            Case 3
                imgdiente27.Image = My.Resources.BI4n
                diente28f = "negro"
            Case 4
                imgdiente27.Image = My.Resources.BI4
                diente28 = 0
                diente28f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente28.Click
        diente29 = diente29 + 1
        Select Case diente29
            Case 0
                imgdiente28.Image = My.Resources.BI5
                diente29f = "blanco"
            Case 1
                imgdiente28.Image = My.Resources.BI5a
                diente29f = "amarillo"
            Case 2
                imgdiente28.Image = My.Resources.BI5r
                diente29f = "rojo"
            Case 3
                imgdiente28.Image = My.Resources.BI5n
                diente29f = "negro"
            Case 4
                imgdiente28.Image = My.Resources.BI5
                diente29 = 0
                diente29f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente29.Click
        diente30 = diente30 + 1
        Select Case diente30
            Case 0
                imgdiente29.Image = My.Resources.BI6
                diente30f = "blanco"
            Case 1
                imgdiente29.Image = My.Resources.BI6a
                diente30f = "amarillo"
            Case 2
                imgdiente29.Image = My.Resources.BI6r
                diente30f = "rojo"
            Case 3
                imgdiente29.Image = My.Resources.BI6n
                diente30f = "negro"
            Case 4
                imgdiente29.Image = My.Resources.BI6
                diente30 = 0
                diente30f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente30.Click
        diente31 = diente31 + 1
        Select Case diente31
            Case 0
                imgdiente30.Image = My.Resources.BI7
                diente31f = "blanco"
            Case 1
                imgdiente30.Image = My.Resources.BI7a
                diente31f = "amarillo"
            Case 2
                imgdiente30.Image = My.Resources.BI7r
                diente31f = "rojo"
            Case 3
                imgdiente30.Image = My.Resources.BI7n
                diente31f = "negro"
            Case 4
                imgdiente30.Image = My.Resources.BI7
                diente31 = 0
                diente31f = "blanco"
        End Select
    End Sub

    Private Sub imgdiente31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgdiente31.Click
        diente32 = diente32 + 1
        Select Case diente32
            Case 0
                imgdiente31.Image = My.Resources.BI8
                diente31f = "blanco"
            Case 1
                imgdiente31.Image = My.Resources.BI8a
                diente31f = "amarillo"
            Case 2
                imgdiente31.Image = My.Resources.BI8r
                diente31f = "rojo"
            Case 3
                imgdiente31.Image = My.Resources.BI8n
                diente31f = "negro"
            Case 4
                imgdiente31.Image = My.Resources.BI8
                diente32 = 0
                diente31f = "blanco"
        End Select
    End Sub


    Private Sub bttoningrdientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttoningrdientes.Click
        ' zona1 arriba-izquierda(diente 1 a 8):
        If cambiador1 = True Then
            Consulta = ("insert into registro_medico (id_p,descripcion,zona,nro_diente,precio,id_c,id_a) values ('" + Citas.idpaciente + "','" + diente1f + "','" + zona1 + "','diente 1-1','','" + id_c + "','');")
            consultar()
        End If

        ' zona 2 arriba-derecha(diente 9 a 15)
        ' zona 3 abajo-izquierda(diente 16 a 23)
        ' zona 4 abajo-derecha(diente 17 a 31)
        ' cambio de ventana
        Citas.Show()
        Me.Dispose()
    End Sub

    Private Sub marcar_cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub marcar_cita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class