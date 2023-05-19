using System;
using System.Data;
using System.Data.OleDb;
using System.Windows;

namespace Task
{
    public partial class MainWindow : Window
    {
        private string connectionString;

        public MainWindow()
        {
            InitializeComponent();

            // Получение пути к файлу базы данных
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBTur_firm.accdb");

            // Создание строки подключения
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
        }

        private void SelectAllTours_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM Туры";

                    // Создание DataAdapter и DataSet
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Заполнение DataSet данными из базы данных
                    dataAdapter.Fill(dataSet, "Туры");

                    // Очистка списка перед загрузкой новых данных
                    TourList.Items.Clear();

                    // Чтение данных из DataSet и добавление их в список
                    foreach (DataRow row in dataSet.Tables["Туры"].Rows)
                    {
                        int tourID = (int)row["Код тура"];
                        string tourName = (string)row["Название"];
                        string tourPrice = ((decimal)row["Цена"]).ToString();

                        // Создание строки, содержащей все данные о туре
                        string tourData = $"ID тура: {tourID} - Название: {tourName} - Цена: {tourPrice}";

                        // Добавление строки с данными о туре в список
                        TourList.Items.Add(tourData);
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при выполнении запроса или открытии/закрытии подключения
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void DeleteTour_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtTourIdToDelete.Text, out int tourId))
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "DELETE FROM Туры WHERE [Код тура] = @TourId";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@TourId", tourId);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Тур успешно удален.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ID тура.");
            }
        }

        private void AddTourist_Click(object sender, RoutedEventArgs e)
        {
            string name = txtTouristName.Text;
            string surname = txtTouristSurname.Text;
            string patronymic = txtTouristPatronymic.Text;

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@Surname, @Name, @Patronymic)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Surname", surname);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Patronymic", patronymic);

                    connection.Open();
                    command.ExecuteNonQuery();


                    MessageBox.Show("Турист успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
        }
        private void UpdateTourist_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtTouristIdToUpdate.Text, out int touristId))
            {
                string newName = txtNewTouristName.Text;
                string newSurname = txtNewTouristSurname.Text;
                string newPatronymic = txtNewTouristPatronymic.Text;

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        string query = "UPDATE Туристы SET Фамилия = @NewSurname, Имя = @NewName, Отчество = @NewPatronymic WHERE [Код туриста] = @TouristId";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@NewSurname", newSurname);
                        command.Parameters.AddWithValue("@NewName", newName);
                        command.Parameters.AddWithValue("@NewPatronymic", newPatronymic);
                        command.Parameters.AddWithValue("@TouristId", touristId);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Турист успешно изменен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ID туриста.");
            }
        }
    }
}

