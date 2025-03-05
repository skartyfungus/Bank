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

    }
}
