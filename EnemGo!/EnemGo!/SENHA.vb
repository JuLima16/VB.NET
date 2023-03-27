Public Class SENHA

    Private Sub BTN_GRAVAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_GRAVAR.Click
        If TXT_LOGIN.Text = "Julia" And TXT_SENHA.Text = "123" Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Usuário ou senha incorreto!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If
    End Sub
End Class