Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio, materia, aux_email, aux_foto, aux_id, n, tema1 As String
    Public cont As Integer

    Sub conectar_banco()
        'Try
        db = CreateObject("ADODB.Connection")
        db.Open("DRIVER={MySQL ODBC 3.51 Driver};port=3306;SERVER=localhost; DATABASE=enemgo; UID=root;")
        ' MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        ' Catch ex As Exception
        'MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        ' End Try
    End Sub
    Sub carregar_dados()
        Try

            With CORREÇÃO_REDAÇÃO.DataGridView1

                sql = "select * from tb_corrigirredacoes order by id asc"
                rs = db.Execute(sql)
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

    Sub carregar_tipo()
        Try
            With CORREÇÃO_REDAÇÃO.cmb_tipo.Items
                .Add("Email")
                .Add("Tema")
            End With
            CORREÇÃO_REDAÇÃO.cmb_tipo.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Sub Limpar_plano()

        With Form1
            .TXT_NOME.Text = "Nome do Professor"
            .TXT_PDF.Text = "PDF"
            .TXT_QTD.Text = "Qtd Exercicíos"
            .TXT_VIDEO.Text = "Vídeo"
            .TXT_TOPICO.Text = "Tópico"
            .TXT_MATERIA.Text = "Matéria"
            .TXT_PLANO.Text = "Plano"
            .img_foto.Image = Nothing

        End With
    End Sub


End Module














































































































































































