Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PresidentAge() As String = IO.File.ReadAllLines("C:\Users\angel\Desktop\VS\Modulo8Thursday\Age.txt")

        'Query String which is base on a LINQ
        Dim query = From line In PresidentAge
                    Let Name = line.Split(",")(0)
                    Let Age = CInt(line.Split(",")(1))
                    Let Hometown = line.Split(",")(2)
                    Order By Name
                    Select Name, Age, Hometown
                    Distinct



        'Distincs any duplications

        ' DataGridView1.AutoResizeColumn = DataGridViewAutoSizeColumnsMode.DisplayedCells

        'attached colums to gridview
        DataGridView1.DataSource = query.ToList



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim StateFlower() As String = IO.File.ReadAllLines("C:\Users\angel\Desktop\VS\Modulo8Thursday\States.txt")

        Dim query = From line In StateFlower
                    Let State = line.Split(",")(0)
                    Let Abrv = line.Split(",")(1)
                    Let LandArea = CInt(line.Split(",")(2))
                    Let Population = CInt(line.Split(",")(3))
                    Let Flower = line.Split(",")(4)
                    Order By Name
                    Select State, Abrv, LandArea, Population, Flower


        DataGridView1.DataSource = query.ToList



    End Sub
End Class