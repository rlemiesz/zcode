Imports System.Linq

Class MainWindow

    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Dim ninjaBookList As List(Of String) = New List(Of String)

        ninjaBookList.Add("The Ninja Handbook")
        ninjaBookList.Add("Ninja: the Shadow Warrior")
        ninjaBookList.Add("Wink: The Ninja Who Wanted to be Noticed")
        ninjaBookList.Add("The Boy Who Cried Ninja")
        ninjaBookList.Add("True Path of the Ninja: The Definitive Translation of the Shoninki")
        ninjaBookList.Add("The Smoke Dragon (The Adventures of Yamabushi Kaidan")
        ninjaBookList.Add("Life As a Ninja: An Interactive History Adventure")
        ninjaBookList.Add("Wink: The Ninja Who Wanted to Nap")
        ninjaBookList.Add("The Ninja")
        ninjaBookList.Add("Secret of the Ninja (Choose Your Own Adventure #16)")
        ninjaBookList.Add("Fujita Seiko: The Last Koga Ninja")
        ninjaBookList.Add("Teaching Ninja: Tai Jutsu (Tesaihiryu Ninja)")
        ninjaBookList.Add("Ninja AD 1460-1650 (Warrior)")
        ninjaBookList.Add("Killing for Others (Dark Elf Ninja Trilogy)")
        ninjaBookList.Add("The Way of the Ninja: Secret Techniques")
        ninjaBookList.Add("Ninjutsu: The Secret Art of the Ninja")
        ninjaBookList.Add("Tales of a Teenage Ninja")
        ninjaBookList.Add("Blood Ninja")
        
        For Each book As String In ninjaBookList.OrderBy(Function(ninjaBook) ninjaBook)
            bookList.Items.Add(book)
        Next




    End Sub


End Class
