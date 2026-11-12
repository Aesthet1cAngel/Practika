using System;
using System.IO;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Книга_рецептов
{ 
    public static class AuthService
    {
        private static string ConnectionString
        {
            get
            {
                string dbPath = Path.GetFullPath(
                    Path.Combine(
                        AppContext.BaseDirectory,
                        @"..\..\..\Recipes.accdb")
                    );

                return "Provider=Microsoft.ACE.OLEDB.12.0;" +
                               "Data Source=" + dbPath + ";" +
                               "Persist Security Info=False;";
            }
        }
        

        private static string CreateHash(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);

            using (var pdkdf2 = new Rfc2898DeriveBytes(
                password, saltBytes, 150000))
            {
                return Convert.ToBase64String(
                    pdkdf2.GetBytes(32)
                );
            }
        }


        private static void CreateUser(
            string login, string password, string role)
        {
            byte[] saltBytes = new byte[16];

            using (var random = RandomNumberGenerator.Create())
            {
                random.GetBytes(saltBytes);
            }

            string salt = Convert.ToBase64String(saltBytes);
            string hash = CreateHash(password, salt);

            using (var connection =
                new OleDbConnection(ConnectionString))
            {
                connection.Open();

                string sql =
                    "INSERT INTO Users ([Login], [PasswordHash], [salt], [Role])" +
                    "VALUES (?, ?, ?, ?)";
                using (var command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@hash", hash);
                    command.Parameters.AddWithValue("@salt", salt);
                    command.Parameters.AddWithValue("@role", role);

                    command.ExecuteNonQuery();
                }
            }
        }


        public static void EnsureDefaultUsers()
        {
            using (var connection =
                new OleDbConnection(ConnectionString))
            {
                connection.Open();

                string[] logins = { "admin", "user" };

                foreach (string login in logins)
                {
                    string sql =
                        "SELECT COUNT(*) FROM Users WHERE [Login] = ?";

                    using (var command =
                        new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);

                        int count = Convert.ToInt32(
                            command.ExecuteScalar()
                            );
                        if (count == 0)
                        {
                            string password =
                                login == "admin" ? "Admin123!" : "User123!";

                            string role =
                                login == "admin" ? "Администратор" : "Пользователь";

                            connection.Close();
                            CreateUser(login, password, role);
                            connection.Open();
                        }
                    }
                }
            }
        }

        public static bool Login(
            string login, string password, out string role)
        {
            role = "";

            using (OleDbConnection connection =
                new OleDbConnection(ConnectionString))
            {
                connection.Open();

                string sql =
                    "SELECT [PasswordHash], [salt], [Role]" +
                    "FROM Users WHERE[Login] = ? ";

                using (OleDbCommand cmd = new OleDbCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        string savedHash =
                            reader["PasswordHash"].ToString();

                        string salt =
                            reader["Salt"].ToString();

                        string savedRole =
                            reader["Role"].ToString();

                        string enteredHash = CreateHash(password, salt);

                        if (savedHash != enteredHash)
                            return false;

                        if (savedRole != "Администратор" &&
                            savedRole != "Пользователь")
                            return false;

                        role = savedRole;
                        return true;
                    }
                }
            }
        }
    }
}

















