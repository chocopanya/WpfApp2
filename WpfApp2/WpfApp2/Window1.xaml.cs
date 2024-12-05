using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string Name { get; set; }
        public int Numb { get; set; }
        public Window1()
        {
            InitializeComponent();
        }
        public void TextBox_TextChanged(object sender, TextChangedEventArgs e, TextBox textBox)
        {
            Name = textBox.Text;

        }
        public void TextBox1_TextChanged1(object sender, TextChangedEventArgs e, TextBox textBox1)
        {
            Numb = Convert.ToInt32(textBox1.Text);

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            // Строка подключения к вашей базе данных. Замените на ваши данные!
            string connectionString = @"parkingdb";

            // Имя таблицы. Замените на ваше имя таблицы!
            string Parking = "parking";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Запрос INSERT.  Важно:  Убедитесь, что имена столбцов и типы данных соответствуют вашей таблице!
                    string query = $"INSERT INTO {Parking} (Name, Numb) VALUES (@Name, @Numb)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавление параметров -  защищает от SQL injection!
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Numb", Numb);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Успешно добавлена запись в таблицу {Parking}.");
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка при добавлении записи в таблицу {Parking}.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Ошибка при подключении к базе данных или выполнении запроса: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
