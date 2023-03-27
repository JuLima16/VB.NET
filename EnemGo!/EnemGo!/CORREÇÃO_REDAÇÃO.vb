Public Class CORREÇÃO_REDAÇÃO


    Private Sub CORREÇÃO_REDAÇÃO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregar_dados()
        carregar_tipo()
        conectar_banco()

        Try
            BTN_COR_REDAÇÃO.Visible = True
            BTN_MATERIA.Visible = False
            BTN_SIMU.Visible = False
            BTN_REDACAO.Visible = False
            Panel4.Visible = False


            PictureBox9.Visible = False
            PictureBox10.Visible = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        MATERIA.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        SIMULADOS.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Hide()
        REDAÇÃO.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If BTN_MATERIA.Visible = True And BTN_SIMU.Visible = True And BTN_REDACAO.Visible = True And Panel4.Visible = True Then
            BTN_MATERIA.Visible = False
            BTN_SIMU.Visible = False
            BTN_REDACAO.Visible = False
            Panel4.Visible = False

            PictureBox10.Visible = True
            PictureBox9.Visible = True
        Else
            Panel4.Visible = True
            BTN_REDACAO.Visible = True
            BTN_SIMU.Visible = True
            BTN_MATERIA.Visible = True
            BTN_COR_REDAÇÃO.Visible = False


            PictureBox10.Visible = False
            PictureBox9.Visible = True
        End If
    End Sub



    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Try

            If BTN_COR_REDAÇÃO.Visible = True Then

                BTN_COR_REDAÇÃO.Visible = False

                PictureBox9.Visible = True
                PictureBox10.Visible = True
            Else

                BTN_COR_REDAÇÃO.Visible = True
                BTN_MATERIA.Visible = False
                BTN_SIMU.Visible = False
                BTN_REDACAO.Visible = False
                Panel4.Visible = False

                PictureBox9.Visible = False
                PictureBox10.Visible = True
            End If

        Catch ex As Exception

        End Try
    End Sub



   

    Private Sub txt_busca_TextChanged(sender As Object, e As System.EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_corrigirredacoes where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%' order by email asc"
            rs = db.Execute(sql)
            With DataGridView1
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Try
        With DataGridView1
            If .CurrentRow.Cells(4).Selected = True Then

                tema1 = .CurrentRow.Cells(2).Value
                aux_foto = .CurrentRow.Cells(3).Value
                aux_id = .CurrentRow.Cells(1).Value
                n = .CurrentRow.Cells(0).Value
                Process.Start("" & aux_foto & "")
                CORRÇÃO_ETAPA2.ID.Text = aux_id
                CORRÇÃO_ETAPA2.foto.Text = aux_foto
                CORRÇÃO_ETAPA2.N.Text = n
                CORRÇÃO_ETAPA2.TEMA.Text = tema1
                Me.Hide()
                CORRÇÃO_ETAPA2.Show()


            Else
                Exit Sub
            End If


        End With
        'Catch ex As Exception

        ' End Try
    End Sub

 
  
  

End Class