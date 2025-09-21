Public Class Form1
    Dim nodP As New TreeNode
    Dim nodPhi As New TreeNode
    Dim nodPhd As New TreeNode
    Dim nodPhi2 As New TreeNode
    Dim nodPhid2 As New TreeNode
    Dim nodPhdi As New TreeNode
    Dim nodPhdd2 As New TreeNode


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TreeView1.Font = New Font("Arial", 20)



        If TextBox1.Text = "" Then
            MsgBox("Por favor ingrese un valor ha ingresar como nodo")

        Else
            If TreeView1.GetNodeCount(True) = 0 Then
                nodP.Text = TextBox1.Text
                Me.TreeView1.Nodes.Add(nodP)
                nodP.BackColor = Color.Gold

            ElseIf TreeView1.GetNodeCount(True) = 1 Then
                nodP.Nodes.Add(nodPhi)
                nodPhi.Text = TextBox1.Text
                If Val(nodPhi.Text) > Val(nodP.Text) Then
                    nodPhi.BackColor = Color.Blue
                Else
                    nodPhi.BackColor = Color.Cyan
                End If

            ElseIf TreeView1.GetNodeCount(True) = 2 Then
                nodP.Nodes.Add(nodPhd)
                nodPhd.Text = TextBox1.Text
                If Val(nodPhd.Text) > Val(nodP.Text) Then
                    nodPhd.BackColor = Color.Blue
                Else
                    nodPhd.BackColor = Color.Cyan
                End If


            ElseIf TreeView1.GetNodeCount(True) = 3 Then
                nodPhi.Nodes.Add(nodPhi2)
                nodPhi2.Text = TextBox1.Text
                If Val(nodPhi2.Text) > Val(nodPhi.Text) Then
                    nodPhi2.BackColor = Color.Blue
                Else
                    nodPhi2.BackColor = Color.Cyan
                End If


            ElseIf TreeView1.GetNodeCount(True) = 4 Then
                nodPhi.Nodes.Add(nodPhid2)
                nodPhid2.Text = TextBox1.Text
                If Val(nodPhid2.Text) > Val(nodPhi.Text) Then
                    nodPhid2.BackColor = Color.Blue
                Else
                    nodPhid2.BackColor = Color.Cyan
                End If

            ElseIf TreeView1.GetNodeCount(True) = 5 Then
                nodPhd.Nodes.Add(nodPhdi)
                nodPhdi.Text = TextBox1.Text
                If Val(nodPhdi.Text) > Val(nodPhd.Text) Then
                    nodPhdi.BackColor = Color.Blue
                Else
                    nodPhdi.BackColor = Color.Cyan
                End If

            ElseIf TreeView1.GetNodeCount(True) = 6 Then
                nodPhd.Nodes.Add(nodPhdd2)
                nodPhdd2.Text = TextBox1.Text

                If Val(nodPhdd2.Text) > Val(nodPhd.Text) Then
                    nodPhdd2.BackColor = Color.Blue
                Else
                    nodPhdd2.BackColor = Color.Cyan
                End If

            ElseIf TreeView1.GetNodeCount(True) = 7 Then



                MsgBox("Ha alcanzado el nivel maximo de jerarquia, ahora puede eliminar nodos")
                GroupBox1.Enabled = True
                ComboBox1.Items.Add(nodP.Text)
                ComboBox1.Items.Add(nodPhi.Text)
                ComboBox1.Items.Add(nodPhd.Text)
                ComboBox1.Items.Add(nodPhi2.Text)
                ComboBox1.Items.Add(nodPhid2.Text)
                ComboBox1.Items.Add(nodPhdi.Text)
                ComboBox1.Items.Add(nodPhdd2.Text)






            End If








        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        GroupBox1.Enabled = False







    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ComboBox1.SelectedIndex = 3 Then
            TreeView1.Nodes.Remove(nodPhi2)

        ElseIf ComboBox1.SelectedIndex = 4 Then
            TreeView1.Nodes.Remove(nodPhid2)

        ElseIf ComboBox1.SelectedIndex = 5 Then
            TreeView1.Nodes.Remove(nodPhdi)

        ElseIf ComboBox1.SelectedIndex = 6 Then
            TreeView1.Nodes.Remove(nodPhdd2)

        ElseIf ComboBox1.SelectedIndex = 1 Then
            If Math.Abs(Val(nodPhi2.Text) - Val(nodPhi.Text)) < Math.Abs(Val(nodPhid2.Text) - Val(nodPhi.Text)) Then

                nodPhi.Text = ""
                nodPhi.Text = nodPhi2.Text
                TreeView1.Nodes.Remove(nodPhi2)

                If Val(nodPhi.Text) < Val(nodP.Text) Then
                    nodPhi.BackColor = Color.Cyan

                Else
                    nodPhi.BackColor = Color.Blue
                End If
            Else
                nodPhi.Text = ""
                nodPhi.Text = nodPhid2.Text
                TreeView1.Nodes.Remove(nodPhid2)
                If Val(nodPhi.Text) < Val(nodP.Text) Then
                    nodPhi.BackColor = Color.Cyan

                Else
                    nodPhi.BackColor = Color.Blue
                End If

            End If

        ElseIf ComboBox1.SelectedIndex = 2 Then
            If Math.Abs(Val(nodPhdi.Text) - Val(nodPhd.Text)) < Math.Abs(Val(nodPhdd2.Text) - Val(nodPhd.Text)) Then
                nodPhd.Text = ""
                nodPhd.Text = nodPhdi.Text
                TreeView1.Nodes.Remove(nodPhdi)
                If Val(nodPhd.Text) < nodP.Text Then
                    nodPhd.BackColor = Color.Cyan
                Else
                    nodPhd.BackColor = Color.Blue
                End If

            Else
                nodPhd.Text = ""
                nodPhd.Text = nodPhdd2.Text
                TreeView1.Nodes.Remove(nodPhdd2)
                If Val(nodPhd.Text) < nodP.Text Then
                    nodPhd.BackColor = Color.Cyan
                Else
                    nodPhd.BackColor = Color.Blue
                End If

            End If

        ElseIf ComboBox1.SelectedIndex = 0 Then
            MsgBox("No puede eliminar la raiz principal del arbol")

        End If

    End Sub
End Class
