using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace AutokauppaWCF
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;

        public DatabaseHallinta()
        {
            yhteysTiedot = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=3;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbYhteys = new SqlConnection(yhteysTiedot);
        }

        public bool connectDatabase()
        {
            try
            {
                dbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO auto (Hinta, Rekisteri_paivamaara, Moottorin_tilavuus, Mittarilukema, AutonmerkkiID, AutonMalliID, VaritID, PolttoaineID) " +
                    "VALUES (@hinta, @rekisteri, @tilavuus, @mittarilukema, @merkki, @malli, @vari, @polttoaine)", dbYhteys);
                command.Parameters.AddWithValue("@hinta", newAuto.Hinta1);
                command.Parameters.AddWithValue("@rekisteri", newAuto.Rekisteri_paivamaara1);
                command.Parameters.AddWithValue("@tilavuus", newAuto.Moottorin_tilavuus1);
                command.Parameters.AddWithValue("@mittarilukema", newAuto.Mittarilukema1);
                command.Parameters.AddWithValue("@merkki", newAuto.AutonMerkkiID1);
                command.Parameters.AddWithValue("@malli", newAuto.AutonMalliID1);
                command.Parameters.AddWithValue("@vari", newAuto.VaritID1);
                command.Parameters.AddWithValue("@polttoaine", newAuto.PolttoaineID1);
                connectDatabase();
                command.ExecuteNonQuery();
                disconnectDatabase();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;
            }

        }

        public List<AutonMerkki> getAllAutoMakersFromDatabase()
        {
            try
            {
                List<AutonMerkki> palaute = new List<AutonMerkki>();
                connectDatabase();
                string sql = "SELECT ID, Merkki FROM AutonMerkki";
                SqlCommand merkkiCommand = new SqlCommand(sql, dbYhteys);
                SqlDataReader reader = merkkiCommand.ExecuteReader();

                while (reader.Read())
                {
                    AutonMerkki merkki = new AutonMerkki();
                    merkki.ID1 = (int)reader["ID"];
                    merkki.Merkki1 = (string)reader["Merkki"];
                    palaute.Add(merkki);
                }
                disconnectDatabase();
                return palaute;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                disconnectDatabase();
                return null;
            }
        }

        public List<AutonMalli> getAutoModelsByMakerId(int makerId)
        {
            try
            {
                List<AutonMalli> palaute = new List<AutonMalli>();
                connectDatabase();
                string sql = "SELECT * FROM AutonMallit WHERE AutonMerkkiID = @Merkki";
                SqlCommand malliCommand = new SqlCommand(sql, dbYhteys);
                malliCommand.Parameters.AddWithValue("@Merkki", makerId);
                SqlDataReader reader = malliCommand.ExecuteReader();

                while (reader.Read())
                {
                    AutonMalli malli = new AutonMalli();
                    malli.ID1 = (int)reader["ID"];
                    malli.Auton_mallin_nimi1 = (string)reader["Auton_mallin_nimi"];
                    palaute.Add(malli);
                }
                disconnectDatabase();
                return palaute;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                disconnectDatabase();
                return null;
            }
        }

        public List<Polttoaineet> GetPolttoaineetFromDatabase()
        {
            try
            {
                List<Polttoaineet> palaute = new List<Polttoaineet>();
                connectDatabase();
                string sql = "SELECT * FROM Polttoaine";
                SqlCommand paCommand = new SqlCommand(sql, dbYhteys);
                SqlDataReader reader = paCommand.ExecuteReader();

                while (reader.Read())
                {
                    Polttoaineet polttoaine = new Polttoaineet();
                    polttoaine.ID1 = (int)reader["ID"];
                    polttoaine.Polttoaineen_nimi1 = (string)reader["Polttoaineen_nimi"];
                    palaute.Add(polttoaine);
                }
                disconnectDatabase();
                return palaute;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                disconnectDatabase();
                return null;
            }
        }

        public List<Varit> GetVaritFromDatabase()
        {
            try
            {
                List<Varit> palaute = new List<Varit>();
                connectDatabase();
                string sql = "SELECT * FROM Varit";
                SqlCommand variCommand = new SqlCommand(sql, dbYhteys);
                SqlDataReader reader = variCommand.ExecuteReader();

                while (reader.Read())
                {
                    Varit vari = new Varit();
                    vari.ID1 = (int)reader["ID"];
                    vari.Varin_nimi1 = (string)reader["Varin_nimi"];
                    palaute.Add(vari);
                }
                disconnectDatabase();
                return palaute;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                disconnectDatabase();
                return null;
            }
        }

        public Auto NextPrevAutoFromDatabase(int autoId, bool next, bool prev)
        {
            Auto auto = new Auto();
            connectDatabase();
            SqlCommand command = null;
            if (next)
            {
                command = new SqlCommand("SELECT TOP 1 * FROM auto WHERE id > @autoID", dbYhteys);
            }
            if (prev)
            {
                command = new SqlCommand("SELECT TOP 1 * FROM auto WHERE id < @autoID ORDER BY id DESC", dbYhteys);
            }
            command.Parameters.AddWithValue("@autoID", autoId);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["ID"]);
                auto.ID1 = (int)reader["ID"];
                auto.AutonMerkkiID1 = (int)reader["AutonMerkkiID"];
                auto.AutonMalliID1 = (int)reader["AutonMalliID"];
                auto.PolttoaineID1 = (int)reader["PolttoaineID"];
                auto.VaritID1 = (int)reader["VaritID"];
                auto.Mittarilukema1 = (int)reader["Mittarilukema"];
                auto.Moottorin_tilavuus1 = (decimal)reader["Moottorin_tilavuus"];
                auto.Hinta1 = (decimal)reader["Hinta"];
                auto.Rekisteri_paivamaara1 = (DateTime)reader["Rekisteri_paivamaara"];
            }
            disconnectDatabase();
            return auto;
        }

        public void DeleteAutoFromDatabase(int autoId)
        {
            connectDatabase();
            SqlCommand command = new SqlCommand("DELETE FROM auto WHERE ID = @id", dbYhteys);
            command.Parameters.AddWithValue("@id", autoId);
            command.ExecuteNonQuery();
            disconnectDatabase();
        }

        public int GetMaxId()
        {
            int id = 0;
            connectDatabase();
            SqlCommand command = new SqlCommand("SELECT TOP 1 Id FROM auto ORDER BY Id DESC", dbYhteys);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["Id"];
            }
            disconnectDatabase();
            return id;
        }

        public int GetMinId()
        {
            int id = 0;
            connectDatabase();
            SqlCommand command = new SqlCommand("SELECT TOP 1 Id FROM auto ORDER BY Id ASC", dbYhteys);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = (int)reader["Id"];
            }
            disconnectDatabase();
            return id;
        }
    }
}