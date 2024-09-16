using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Data.SqlClient;
using IASFit.Model;

namespace IASFit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            Level1.Content = "Button";
=======
            AnmeldungDatenbank();

            if (Kundennummer.Text=="1")
            {
                if(Passwort.Text=="1")
                {
                Benachrichtigung.Content = "Anmeldung erfolgreich";
                }
                else
                {
                Benachrichtigung.Content = "Das Passwort zu diesem Benutzer ist falsch!";
                }
            }
            else
            {
                Benachrichtigung.Content = "Diese Kundennummer gibt es nicht";
            }
        }

        public Anmeldung AnmeldungDatenbank()
        {


                Anmeldung anmeldung = new Anmeldung();
                // Verbindungszeichenfolge anpassen
                string connectionString = "Server=IASVNB42;Database=Schule1;User Id=sa;Password=Start11!;";

                // Verbindung zur Datenbank erstellen
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Verbindung öffnen
                        connection.Open();

                        // Beispiel für eine einfache Abfrage
                        string query = $"SELECT TOP 1 * FROM Anmeldung WHERE Kundennr = {Kundennummer.Text}" ;

                        // SQL-Befehl ausführen
                        SqlCommand command = new SqlCommand(query, connection);

                        // Ergebnis abrufen
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            Console.WriteLine($"{reader[0]} | {reader[1]}");
                             anmeldung.reader[0]
                        return anmeldung;
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Fehler bei der Verbindung zur Datenbank:");
                        Console.WriteLine(e.Message);
                    }

                }
            
        

    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}
