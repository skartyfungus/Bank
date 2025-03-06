using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Collections;
using System.Transactions;


namespace Bank
{
    class DBAPI
    {
        public string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";
        public static int CurrentUserId = -1;
        public static float currTempBal = 0;
        public static bool CheckUser(int? userIdToFind, string? usernameToFind)
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";


            string queryID = "SELECT * FROM users WHERE userid = @userid";
            string queryUN = "SELECT * FROM users WHERE username = @username";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                if (userIdToFind != null)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryID, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userIdToFind);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read()) // Reads each matching row
                                {
                                    int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    string username = reader["username"].ToString(); // Replace with actual column names

                                    Debug.WriteLine($"User found: ID={userid}, Name={username}");
                                    return true;
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return false;
                            }
                        }
                    }
                }
                else if (usernameToFind != null)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryUN, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameToFind);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read()) // Reads each matching row
                                {
                                    int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    string username = reader["username"].ToString(); // Replace with actual column names

                                    Debug.WriteLine($"User found: ID={userid}, Name={username}");
                                    return true;
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return false;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public static string GetUserInfo(int? userIdToFind, string? usernameToFind)
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";


            string queryID = "SELECT * FROM users WHERE userid = @userid";
            string queryUN = "SELECT * FROM users WHERE username = @username";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                if (userIdToFind != null)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryID, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userIdToFind);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read()) // Reads each matching row
                                {
                                    int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    string username = reader["username"].ToString(); // Replace with actual column names

                                    Debug.WriteLine($"User found: ID={userid}, Name={username}");
                                    return username;
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return null;
                            }
                        }
                    }
                }
                else if (usernameToFind != null)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryUN, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameToFind);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read()) // Reads each matching row
                                {
                                    int userid = reader.GetInt32(reader.GetOrdinal("userid"));
                                    string username = reader["username"].ToString(); // Replace with actual column names

                                    Debug.WriteLine($"User found: ID={userid}, Name={username}");
                                    return userid.ToString();
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return null;
                            }
                        }
                    }
                }
                return null;
            }
        }

        public static decimal GetUserBalance(int? userId, string username)
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";
            decimal balance = 0;

            if (userId.HasValue)
            {
                string query = "SELECT balance FROM users WHERE userid = @userid";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userId);
                        var result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            // Try to parse the result as a decimal
                            decimal.TryParse(result.ToString(), out balance);
                        }
                        else
                        {
                            // Handle null balance, set to 0
                            balance = 0;
                        }
                    }
                }
            }
            else if (username != null)
            {
                string query = "SELECT balance FROM users WHERE username = @username";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        var result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            // Try to parse the result as a decimal
                            decimal.TryParse(result.ToString(), out balance);
                        }
                        else
                        {
                            // Handle null balance, set to 0
                            balance = 0;
                        }
                    }
                }
            }
            return balance;
        }


        public static void Register(string username, string password)
        {

            if (!CheckUser(null, username))
            {
                //create acc
                string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";

                // Hash the password before storing it
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the new user
                    string query = "INSERT INTO users (username, passwordhash, userid) VALUES (@username, @password, @userid);";
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            int newUserId = GetHighestUserID() + 1;
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", hashedPassword);
                            command.Parameters.AddWithValue("@userid", newUserId);

                            command.ExecuteNonQuery();
                            transaction.Commit();
                            Debug.WriteLine($"User registered successfully! Username: {username}, UserID: {newUserId}");
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            else
            {
                Debug.WriteLine("Username already used");
                MessageBox.Show("Username already exists.", "Username exists.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }





        }

        public static bool Login(string username, string password)
        {
            if (username == null || password == null || username == "" || password == "")
            {
                MessageBox.Show("Invalid username or password, please try again.", "Invalid username or password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Debug.WriteLine("Invalid username or password.");
                return false;
            }


            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";
            CurrentUserId = -1;
            string query = "SELECT userid, passwordhash FROM users WHERE username = @username";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Read the user record
                            string storedPasswordHash = reader["passwordhash"].ToString();


                            // Compare the provided password with the stored hash
                            if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                            {
                                CurrentUserId = reader.GetInt32(reader.GetOrdinal("userid"));
                                Debug.WriteLine("Login successful!");
                                return true;

                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password, please try again.", "Invalid username or password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Debug.WriteLine("Invalid username or password.");
                                return false;
                            }
                        }
                        else
                        {
                            Debug.WriteLine("Invalid username or password.");
                            MessageBox.Show("Invalid username or password, please try again.", "Invalid username or password.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
            }
        }

        public static List<string> GetAllUsernames()
        {
            List<string> usernames = new List<string>();
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT username FROM users";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usernames.Add(reader["username"].ToString());
                    }
                }
            }
            return usernames;
        }

        public static bool RemoveUser(string username)
        {
            if (username == null)
            {
                Debug.WriteLine("Invalid username.");
                return false;
            }
            if (username == "admin")
            {
                Debug.WriteLine("Cannot remove admin user.");
                return false;
            }

            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists before attempting deletion
                if (!CheckUser(null, username))
                {
                    Debug.WriteLine("User not found.");
                    return false;
                }

                string query = "DELETE FROM users WHERE username = @username";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Debug.WriteLine($"User {username} successfully removed.");
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine("Failed to remove user.");
                        return false;
                    }
                }
            }
        }

        static int GetHighestUserID()
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;SslMode=Disable;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COALESCE(MAX(userid), 0) FROM users"; // Ensures a non-null return

                using (var command = new NpgsqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public static bool ChangePassword(int userId, string newPassword)
        {
            if (GetUserInfo(userId, null) == "admin")
            {
                MessageBox.Show("Cannot change password for admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            string query = "UPDATE users SET passwordhash = @password WHERE userid = @userid";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.Parameters.AddWithValue("@userid", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        transaction.Commit();

                        if (rowsAffected > 0)
                        {
                            Debug.WriteLine("Password changed successfully!");
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }

            Debug.WriteLine("Failed to change password.");
            MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public static bool ChangeUsername(int userId, string newUsername)
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";
            if (GetUserInfo(userId, null) == "admin")
            {
                MessageBox.Show("Cannot change username for admin user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            // Check if the new username already exists
            if (CheckUser(null, newUsername))
            {
                Debug.WriteLine("Username already taken!");
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            string query = "UPDATE users SET username = @username WHERE userid = @userid";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", newUsername);
                        command.Parameters.AddWithValue("@userid", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        transaction.Commit();

                        if (rowsAffected > 0)
                        {
                            Debug.WriteLine($"Username changed successfully to {newUsername}!");
                            MessageBox.Show("Username changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }

            Debug.WriteLine("Failed to change username.");
            MessageBox.Show("Failed to change username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public static void AlterBalance(int? userId, string? username, decimal amount)
        {
            string connectionString = "Host=turntable.proxy.rlwy.net;Port=21586;Username=postgres;Password=HXtronaixLLelRkVLSfEasmfatkOSblH;Database=railway;";

            // Initial balance to be retrieved from the database
            decimal currTempBal = 0;

            if (userId.HasValue)
            {
                // Query to get current balance
                string query1 = "SELECT balance FROM users WHERE userid = @userid";
                string query2 = "UPDATE users SET balance = @balance WHERE userid = @userid";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Get current balance
                    using (NpgsqlCommand command = new NpgsqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userId);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Check if balance is null, if so set it to 0
                                    currTempBal = reader.IsDBNull(reader.GetOrdinal("balance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("balance"));
                                    Debug.WriteLine($"Retrieved balance for userId {userId}: {currTempBal}");
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return;
                            }
                        }
                    }

                    // Calculate new balance (add or subtract based on the amount passed)
                    decimal newBalance = currTempBal + amount;

                    // Check if the new balance is less than 0
                    if (newBalance < 0)
                    {
                        MessageBox.Show("Insufficient balance. Balance cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method without updating the balance
                    }

                    // Update balance
                    using (NpgsqlCommand command = new NpgsqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@balance", newBalance);
                        command.Parameters.AddWithValue("@userid", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Debug.WriteLine($"Balance updated successfully for userId {userId}. New balance: {newBalance}");
                        }
                        else
                        {
                            Debug.WriteLine("Failed to update balance.");
                        }
                    }
                }
            }
            else if (!string.IsNullOrEmpty(username))
            {
                // Query to get current balance by username
                string query1 = "SELECT balance FROM users WHERE username = @username";
                string query2 = "UPDATE users SET balance = @balance WHERE username = @username";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Get current balance
                    using (NpgsqlCommand command = new NpgsqlCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    // Check if balance is null, if so set it to 0
                                    currTempBal = reader.IsDBNull(reader.GetOrdinal("balance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("balance"));
                                    Debug.WriteLine($"Retrieved balance for username {username}: {currTempBal}");
                                }
                            }
                            else
                            {
                                Debug.WriteLine("User not found.");
                                return;
                            }
                        }
                    }

                    // Calculate new balance (add or subtract based on the amount passed)
                    decimal newBalance = currTempBal + amount;

                    // Check if the new balance is less than 0
                    if (newBalance < 0)
                    {
                        MessageBox.Show("Insufficient balance. Balance cannot be less than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method without updating the balance
                    }

                    // Update balance
                    using (NpgsqlCommand command = new NpgsqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@balance", newBalance);
                        command.Parameters.AddWithValue("@username", username);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Debug.WriteLine($"Balance updated successfully for username {username}. New balance: {newBalance}");
                        }
                        else
                        {
                            Debug.WriteLine("Failed to update balance.");
                        }
                    }
                }
            }
        }







    }
}
