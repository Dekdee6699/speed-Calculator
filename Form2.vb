Public Class Form2

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, d, q, w, ee As String
        Try
            q = CSng(TextBox1.Text)
            w = CSng(TextBox2.Text)
            ee = CSng(TextBox3.Text)
            If TextBox1.Text = 0 And TextBox2.Text = 0 And TextBox3.Text = 0 Then
                Form3.Label1.Text = 0
                Form3.Show()
            ElseIf TextBox1.Text <> ("") And TextBox2.Text <> ("") And TextBox3.Text <> ("") Then
                a = (TextBox2.Text * 60) + TextBox3.Text
                d = TextBox1.Text / a
                Form3.Label1.Text = d * 60
                Form3.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาใส่ตัวเลข")
            TextBox1.Text = ("")
        End Try

    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class