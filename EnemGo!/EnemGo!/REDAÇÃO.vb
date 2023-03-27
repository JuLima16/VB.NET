Public Class REDAÇÃO
    Public imagem As String

    Private Sub REDAÇÃO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conectar_banco()

        Panel4.Visible = True
        BTN_REDACAO.Visible = True
        BTN_SIMU.Visible = True
        BTN_MATERIA.Visible = True
        BTN_COR_REDAÇÃO.Visible = False

        PictureBox10.Visible = False
        PictureBox9.Visible = True
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
        MATERIA.Show()
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Hide()
        SIMULADOS.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Hide()
        CORREÇÃO_REDAÇÃO.Show()
    End Sub
    

    Private Sub img_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_foto.Click
        Try
            With Carregar
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\FOTOS"
                .ShowDialog()
                imagem = .FileName
                img_foto.Load(imagem)
            End With

        Catch ex As Exception
            Exit Sub
        End Try
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



    Private Sub BTN_GRAVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GRAVAR.Click
        Try

            sql = "select * from tb_redacoes where TEMA='" & TXT_TEMA.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_redacoes values (null, '" & TXT_TEMA.Text & "', '" & imagem & "', '" & TXT_TEXTO1.Text & "', '" & TXT_TEXTO2.Text & "', '" & TXT_TEXTO3.Text & "', '" & TXT_TEXTO4.Text & "', '" & TXT_PLANO.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DADOS CADASTRADO")
            Else
                MsgBox("Redação já cadastrado no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CANDIDATO JÁ CADASTRADO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROOOOOO!")
        End Try
    End Sub
End Class