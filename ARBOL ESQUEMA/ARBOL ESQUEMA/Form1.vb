Public Class Form1

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TreeView1.BackColor = Color.DeepSkyBlue
        Dim nodo As New TreeNode("Abuelo")
        Dim noda As New TreeNode("Padre 1")
        Dim nodb As New TreeNode("Padre 2")
        Dim noda1 As New TreeNode("Hijo 1a")
        Dim noda2 As New TreeNode("Hijo 1b")
        Dim nodb1 As New TreeNode("Hijo 2a")
        Dim nodb2 As New TreeNode("Hijo 2b")

        nodo.Nodes.Add(noda)
        nodo.Nodes.Add(nodb)
        noda.Nodes.Add(noda1)
        noda.Nodes.Add(noda2)
        nodb.Nodes.Add(nodb1)
        nodb.Nodes.Add(nodb2)


        TreeView1.Font = New Font("Arial", 20)
        nodo.BackColor = Color.Gold
        noda.BackColor = Color.Aquamarine
        noda1.BackColor = Color.LightBlue
        noda2.BackColor = Color.LightBlue
        nodb.BackColor = Color.GreenYellow
        nodb1.BackColor = Color.LightGreen
        nodb2.BackColor = Color.LightGreen





        Me.TreeView1.Nodes.Add(nodo)







    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
