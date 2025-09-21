Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        ComboBox1.SelectedIndex = 0






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            TextBox2.Enabled = True

        End If

        If TextBox2.Text <> "" Then
            TextBox3.Enabled = True
        End If

        If TextBox3.Text <> "" Then
            TextBox4.Enabled = True
        End If

        If TextBox4.Text <> "" Then
            TextBox5.Enabled = True
        End If

        If TextBox5.Text <> "" Then
            TextBox6.Enabled = True
        End If

        If TextBox6.Text <> "" Then
            TextBox7.Enabled = True
        End If


        If TextBox1.Text = "" Then
            MsgBox("Favor ingrese el primer nodo")
        End If

        If ComboBox1.SelectedIndex = 0 Then
            Form1.TextBox1.Text = Me.TextBox1.Text
            Form1.TextBox2.Text = Me.TextBox2.Text
            Form1.TextBox4.Text = Me.TextBox3.Text
            Form1.TextBox5.Text = Me.TextBox4.Text
            Form1.TextBox3.Text = Me.TextBox5.Text
            Form1.TextBox6.Text = Me.TextBox6.Text
            Form1.TextBox7.Text = Me.TextBox7.Text

        End If

        If ComboBox1.SelectedIndex = 1 Then
            Form1.TextBox4.Text = Me.TextBox1.Text
            Form1.TextBox5.Text = Me.TextBox2.Text
            Form1.TextBox2.Text = Me.TextBox3.Text
            Form1.TextBox6.Text = Me.TextBox4.Text
            Form1.TextBox7.Text = Me.TextBox5.Text
            Form1.TextBox3.Text = Me.TextBox6.Text
            Form1.TextBox1.Text = Me.TextBox7.Text


        End If

        If ComboBox1.SelectedIndex = 2 Then
            Form1.TextBox4.Text = Me.TextBox1.Text
            Form1.TextBox2.Text = Me.TextBox2.Text
            Form1.TextBox5.Text = Me.TextBox3.Text
            Form1.TextBox1.Text = Me.TextBox4.Text
            Form1.TextBox6.Text = Me.TextBox5.Text
            Form1.TextBox3.Text = Me.TextBox6.Text
            Form1.TextBox7.Text = Me.TextBox7.Text
        End If
        Dim nodo1 As New TreeNode(TextBox1.Text)
        Dim nodo2 As New TreeNode(TextBox2.Text)
        Dim nodo3 As New TreeNode(TextBox3.Text)
        Dim nodo4 As New TreeNode(TextBox4.Text)
        Dim nodo5 As New TreeNode(TextBox5.Text)
        Dim nodo6 As New TreeNode(TextBox6.Text)
        Dim nodo7 As New TreeNode(TextBox7.Text)

        nodo1.Nodes.Add(nodo2)
        nodo1.Nodes.Add(nodo3)
        nodo2.Nodes.Add(nodo4)
        nodo2.Nodes.Add(nodo5)
        nodo3.Nodes.Add(nodo6)
        nodo3.Nodes.Add(nodo7)





    End Sub
End Class