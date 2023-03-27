Public Class Form1
    Public foto, pdf, video, icone As String
    Public data As DateTime

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectar_banco()

        Panel4.Visible = True
        BTN_REDACAO.Visible = True
        BTN_SIMU.Visible = True
        BTN_MATERIA.Visible = True
        BTN_COR_REDAÇÃO.Visible = False

        PictureBox10.Visible = False
        PictureBox9.Visible = True

        data = Today
        TXT_SEMANA.Text = data
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


    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Me.Hide()
        CORREÇÃO_REDAÇÃO.Show()
    End Sub


    
    Private Sub img_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_foto.Click
        Try
            With Carregar_Foto
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\CADASTROS\PLANO_ESTUDOS"
                .ShowDialog()
                foto = .FileName.Replace("\", "\\")
                img_foto.Load(foto)
            End With

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_PDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PDF.Click
        Try
            With Carregar_Foto
                .Title = "SELECIONE O PDF"
                .DefaultExt = "pdf"
                .InitialDirectory = Application.StartupPath & "\CADASTROS\PLANO_ESTUDOS"
                .ShowDialog()
                pdf = .FileName.Replace("\", "\\")
                TXT_PDF.Text = pdf
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

    Private Sub BTN_GRAVAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_GRAVAR.Click
        Try

            sql = "select * from tb_planoestudos where TOPICO='" & TXT_TOPICO.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_planoestudos values (null,'" & TXT_SEMANA.Text & "','" & TXT_MATERIA.Text & "', '" & TXT_TOPICO.Text & "', '" & TXT_VIDEO.Text & "', '" & foto & "', '" & TXT_NOME.Text & "', '" & pdf & "', '" & TXT_QTD.Text & "','" & icone & "','" & TXT_PLANO.Text & "')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "DADOS CADASTRADO")
                Limpar_plano()
            Else
                MsgBox("Tópico já cadastrado no sistema!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If

        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End Try
    End Sub

    Private Sub TXT_MATERIA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TXT_MATERIA.SelectedIndexChanged
        Try

            If TXT_MATERIA.Text = "Geografia" Then
                icone = "public"

            ElseIf TXT_MATERIA.Text = "Sociologia" Then
                icone = "balance"

            ElseIf TXT_MATERIA.Text = "História" Then
                icone = "history_edu"

            ElseIf TXT_MATERIA.Text = "Filosofia" Then
                icone = "psychology_alt"

            ElseIf TXT_MATERIA.Text = "Física" Then
                icone = "hub"

            ElseIf TXT_MATERIA.Text = "Química" Then
                icone = "science"

            ElseIf TXT_MATERIA.Text = "Biologia" Then
                icone = "biotech"

            ElseIf TXT_MATERIA.Text = "Literatura" Then
                icone = "menu_book"

            ElseIf TXT_MATERIA.Text = "Interpretação" Then
                icone = "library_books"

            ElseIf TXT_MATERIA.Text = "Português" Then
                icone = "abc"

            ElseIf TXT_MATERIA.Text = "Matemática" Then
                icone = "calculate"

            ElseIf TXT_MATERIA.Text = "Redação" Then
                icone = "border_color"

            End If

        Catch ex As Exception

        End Try
    End Sub


End Class
