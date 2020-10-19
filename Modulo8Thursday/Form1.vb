Public Class Form1
    Dim Connect As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\angel\Desktop\Database1Modulo8.accdb")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1Modulo8DataSet4.States' table. You can move, or remove it, as needed.
        Me.StatesTableAdapter.Fill(Me.Database1Modulo8DataSet4.States)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'insert
        Connect.Open()
        MessageBox.Show("Connection Open")

        Dim Convert1 As Integer
        Dim Convert2 As Integer

        Integer.TryParse(TextBox3.Text, Convert1)
        Integer.TryParse(TextBox4.Text, Convert2)




        Try

            Dim Command As New OleDb.OleDbCommand("Insert into [States] ([States],[ABBR],[Land Area],[Population]) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "') ", Connect)

            Command.ExecuteNonQuery()
            MessageBox.Show("The State of " & TextBox1.Text & "has been added")
            Me.StatesTableAdapter.Fill(Me.Database1Modulo8DataSet4.States)



        Catch ex As Exception

            MessageBox.Show(ex.ToString)


        End Try
        Connect.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'update
        Connect.Open()

        Try

            Dim Command As New OleDb.OleDbCommand
            Command.CommandText = "Update [States] set [Population] = '" & TextBox4.Text & "' where ABBR = '" & TextBox2.Text & "' "
            'inizialize connection
            Command.Connection = Connect

            Command.ExecuteNonQuery()
            MessageBox.Show("The Population of " & TextBox1.Text & "has been Updated to " & TextBox4.Text)
            Me.StatesTableAdapter.Fill(Me.Database1Modulo8DataSet4.States)


        Catch ex As Exception

            MessageBox.Show(ex.ToString)


        End Try
        Connect.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete
        Connect.Open()
        Try
            Dim Command As New OleDb.OleDbCommand
            Command.CommandText = "Delete  from [States] where ABBR = '" & TextBox2.Text & "' "
            'inizialize connection
            Command.Connection = Connect

            Command.ExecuteNonQuery()
            MessageBox.Show("TheState of " & TextBox2.Text & "has been Deleted")
            Me.StatesTableAdapter.Fill(Me.Database1Modulo8DataSet4.States)


        Catch ex As Exception

            MessageBox.Show(ex.ToString)


        End Try
        Connect.Close()
    End Sub


    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
End Class
