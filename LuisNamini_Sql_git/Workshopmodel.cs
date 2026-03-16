using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisNamini_Sql_git
{
    public class WorkshopModel
    {
        private WorkshopController controller;
        private string connectionString = "server=127.0.0.1; uid=root; pwd=; database=projektwoche2017;";

        public WorkshopModel(WorkshopController controller)
        {
            this.controller = controller;
        }

        public void InsertWorkshop(Workshop w)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "INSERT INTO Workshops (Nr, Titel, Kosten, Beschreibung, Voraussetzungen, TeilnehmerMin, TeilnehmerMax, Schwerpunkt) " +
                    "VALUES (@Nr, @Titel, @Kosten, @Beschreibung, @Voraussetzungen, @TeilnehmerMin, @TeilnehmerMax, @Schwerpunkt)", conn);

                cmd.Parameters.AddWithValue("@Nr", w.Nr);
                cmd.Parameters.AddWithValue("@Titel", w.Titel);
                cmd.Parameters.AddWithValue("@Kosten", w.Kosten);
                cmd.Parameters.AddWithValue("@Beschreibung", w.Beschreibung);
                cmd.Parameters.AddWithValue("@Voraussetzungen", w.Voraussetzungen);
                cmd.Parameters.AddWithValue("@TeilnehmerMin", w.TeilnehmerMin);
                cmd.Parameters.AddWithValue("@TeilnehmerMax", w.TeilnehmerMax);
                cmd.Parameters.AddWithValue("@Schwerpunkt", w.Schwerpunkt);

                cmd.ExecuteNonQuery();
            }
        }

        public System.Collections.Generic.List<Workshop> GetWorkshops()
        {
            var liste = new System.Collections.Generic.List<Workshop>();

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM Workshops", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var w = new Workshop()
                        {
                            WorkshopID = (int)reader["WorkshopID"],
                            Nr = (int)reader["Nr"],
                            Titel = (string)reader["Titel"],
                            Kosten = (int)reader["Kosten"],
                            Beschreibung = (string)reader["Beschreibung"],
                            Voraussetzungen = (string)reader["Voraussetzungen"],
                            TeilnehmerMin = (int)reader["TeilnehmerMin"],
                            TeilnehmerMax = (int)reader["TeilnehmerMax"],
                            Schwerpunkt = (string)reader["Schwerpunkt"]
                        };
                        liste.Add(w);
                    }
                }
            }

            return liste;
        }
    }
}