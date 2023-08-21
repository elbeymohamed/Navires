using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class NaviresRepository
    {
        private static string connectionString = "Server=DESKTOP-DRKOCCQ;Database=NavireDB;User Id=DESKTOP-DRKOCCQ\RAM;Password=myPassword;";

        static void InsertNavire(Navire navire)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Navires (Numero, Nom, Annee, Longueur, Largeur, TonnageBrut, TonnageNet, Note) VALUES (@Numero, @Nom, @Annee, @Longueur, @Largeur, @TonnageBrut, @TonnageNet, @Note)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", navire.Numero);
                command.Parameters.AddWithValue("@Nom", navire.Nom);
                command.Parameters.AddWithValue("@Annee", navire.Annee);
                command.Parameters.AddWithValue("@Longueur", navire.Longueur);
                command.Parameters.AddWithValue("@Largeur", navire.Largeur);
                command.Parameters.AddWithValue("@TonnageBrut", navire.TonnageBrut);
                command.Parameters.AddWithValue("@TonnageNet", navire.TonnageNet);
                command.Parameters.AddWithValue("@Note", navire.Note);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        static Navire GetNavireByNumero(int numero)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Navires WHERE Numero = @Numero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", numero);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Navire
                    {
                        Numero = (int)reader["Numero"],
                        Nom = (string)reader["Nom"],
                        Annee = (int)reader["Annee"],
                        Longueur = (float)reader["Longueur"],
                        Largeur = (float)reader["Largeur"],
                        TonnageBrut = (int)reader["TonnageBrut"],
                        TonnageNet = (int)reader["TonnageNet"],
                        Note = (string)reader["Note"]
                    };
                }
                return null;
            }
        }

        static void UpdateNavire(Navire navire)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Navires SET Nom = @Nom, Annee = @Annee, Longueur = @Longueur, Largeur = @Largeur, TonnageBrut = @TonnageBrut, TonnageNet = @TonnageNet, Note = @Note WHERE Numero = @Numero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", navire.Numero);
                command.Parameters.AddWithValue("@Nom", navire.Nom);
                command.Parameters.AddWithValue("@Annee", navire.Annee);
                command.Parameters.AddWithValue("@Longueur", navire.Longueur);
                command.Parameters.AddWithValue("@Largeur", navire.Largeur);
                command.Parameters.AddWithValue("@TonnageBrut", navire.TonnageBrut);
                command.Parameters.AddWithValue("@TonnageNet", navire.TonnageNet);
                command.Parameters.AddWithValue("@Note", navire.Note);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        static void DeleteNavire(int numero)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Navires WHERE Numero = @Numero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", numero);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<Navire> GetAllNavires()
        {
            List<Navire> navires = new List<Navire>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Navires";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Navire navire = new Navire
                        {
                            Numero = (int)reader["Numero"],
                            Nom = (string)reader["Nom"],
                            Annee = (int)reader["Annee"],
                            Longueur = (float)reader["Longueur"],
                            Largeur = (float)reader["Largeur"],
                            TonnageBrut = (int)reader["TonnageBrut"],
                            TonnageNet = (int)reader["TonnageNet"],
                            Note = (string)reader["Note"]
                        };

                        navires.Add(navire);
                    }
                }
            }

            return navires;
        }

    }
}