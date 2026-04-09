using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace LuisNamini_Sql_git
{
    public class Model : IModel
    {
        private string connectionString = "server=127.0.0.1; uid=root; pwd=; database=projektwoche2017;";

        public void insertWorkshop(Workshop w)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand(
    "INSERT INTO Workshop (Nr, Titel, Kosten, Beschreibung, Voraussetzungen, TeilnehmerMin, TeilnehmerMax, Schwerpunkt) " +
    "VALUES (@nr, @titel, @kosten, @beschreibung, @voraussetzungen, @teilnehmerMin, @teilnehmerMax, @schwerpunkt)",
    conn
);

                cmd.Parameters.AddWithValue("nr", w.Nr);
                cmd.Parameters.AddWithValue("@titel", w.Titel);
                cmd.Parameters.AddWithValue("@kosten", w.Kosten);
                cmd.Parameters.AddWithValue("@beschreibung", w.Beschreibung);
                cmd.Parameters.AddWithValue("@voraussetzungen", w.Voraussetzungen);
                cmd.Parameters.AddWithValue("@teilnehmerMin", w.TeilnehmerMin);
                cmd.Parameters.AddWithValue("@teilnehmerMax", w.TeilnehmerMax);
                cmd.Parameters.AddWithValue("@schwerpunkt", w.Schwerpunkt);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Workshop> alleWorkshops()
        {
            var liste = new List<Workshop>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM Workshop", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var w = new Workshop()
                        {
                            Titel = (string)reader["Titel"]
                        };
                        liste.Add(w);
                    }
                }
            }

            return liste;
        }
    }
}