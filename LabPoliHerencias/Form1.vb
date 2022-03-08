Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empleado1 As Empleado = New Empleado()
        empleado1.Nombres = TextBox1.Text
        empleado1.Apellidos = TextBox2.Text
        empleado1.Documentos = TextBox3.Text
        empleado1.Tipos = ComboBox1.Text
        empleado1.codigo = ComboBox2.Text
        empleado1.calcularSueldo(3000)
        DataGridView1.Rows.Insert(0, empleado1.Tipos,
empleado1.Nombres, empleado1.Apellidos, empleado1.Documentos, empleado1.tiposueldos)
    End Sub
End Class
