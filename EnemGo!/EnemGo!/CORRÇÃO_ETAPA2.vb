Public Class CORRÇÃO_ETAPA2

    Private Sub CORRÇÃO_ETAPA2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        BTN_COR_REDAÇÃO.Visible = True
        BTN_MATERIA.Visible = False
        BTN_SIMU.Visible = False
        BTN_REDACAO.Visible = False
        Panel4.Visible = False

        PictureBox9.Visible = False
        PictureBox10.Visible = True
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



    Private Sub BTN_ENVIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ENVIAR.Click
        'Try

        sql = "select * from tb_redacaocorrigida where ID='" & N.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = True Then
            sql = "insert into tb_redacaocorrigida values (null, '" & ID.Text & "', '" & TEMA.Text & "','" & foto.Text & "', '" & TXT_COMENTARIOS.Text & "')"
            rs = db.Execute(UCase(sql))
            MsgBox("Correção gravados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            TXT_COMENTARIOS.Text = ""

            CORREÇÃO_REDAÇÃO.Show()
            Me.Hide()

        Else
            MsgBox("Conteúdo já cadastrado no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If

        'Catch ex As Exception
        'MsgBox("Erro ao gravar!", MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub
End Class