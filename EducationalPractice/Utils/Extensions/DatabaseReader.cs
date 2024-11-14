using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DatabaseReader
{
    private readonly string _connectionString;

    public DatabaseReader()
    {
        // Получаем строку подключения из app.config
        _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
    }

    public void ShowData()
    {
        string query = "SELECT TOP 1 Position, FullName FROM Employees"; // Пример запроса
        string message = "";

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Считываем данные из столбцов
                    string firstName = reader["Position"].ToString();
                    string lastName = reader["FullName"].ToString();
                    message = $"Имя: {firstName}, Фамилия: {lastName}";
                }
                else
                {
                    message = "Данные не найдены";
                }
            }
        }

        // Выводим данные в MessageBox
        MessageBox.Show(message, "Информация о клиенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
