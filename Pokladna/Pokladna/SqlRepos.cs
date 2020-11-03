using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    public class SqlRepos : IRepos
    {

        private string connstring=(@"Data Source=(localdb)\MSSQLLocalDB;
                                                      Initial Catalog=master;
                                                      Integrated Security=True;
                                                      Connect Timeout=30;
                                                      Encrypt=False;
                                                      TrustServerCertificate=False;
                                                      ApplicationIntent=ReadWrite;
                                                      MultiSubnetFailover=False");

        public void VytvorTestData(List<PokladniZaznam> vychoziZaznamy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                string dotaz = "DROP TABLE IF EXISTS   [dbo].[Table]" +
                    "CREATE TABLE [dbo].[Table]" +
                    "(IdPokladniZaznam] INT NOT NULL PRIMARY KEY IDENTITY (1,1),  " +
                    "[Cislo] INT NOT NULL," +
                    "[Datum] DATETIME NOT NULL, " +
                    "[Popis] VARCHAR(250) NOT NULL," +
                    " [Castka] INT NOT NULL, " +
                    "[Zustatek] FLOAT NOT NULL," +
                    "[Poznamka] VARCHAR(250) NOT NULL)";
                foreach(var z in vychoziZaznamy)
                {
                    dotaz += $"insert into Table(Cislo, Datum,Popis,Castka, Zustatek,Poznamka)"
                        + $"values({z.Cislo},'{z.Datum.ToString("yyyyMMdd")}','{z.Popis}',{z.Castka},{z.Zustatek},{z.Poznamka})";
                }
                using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }
        public List<PokladniZaznam> NactiMesic(int rok, int mesic)
        {
            throw new NotImplementedException();
        }

        public List<PokladniZaznam> NactiVse()
        {
            List<PokladniZaznam> result = new List<PokladniZaznam>();
            using(SqlConnection sqlConnection= new SqlConnection(connstring))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select * from Table", sqlConnection))
                {
                    sqlConnection.Open();
                    using(SqlDataReader dataReader= sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            result.Add(new PokladniZaznam(
                                Convert.ToInt32(dataReader["IdPokladniZaznam"]),
                               Convert.ToInt32 (dataReader["Cislo"]),
                               Convert.ToDateTime (dataReader["Datum"]),
                                dataReader["Popis"].ToString(),
                                Convert.ToDouble (dataReader["Castka"]),
                               Convert.ToDouble (dataReader["Zustatek"]),
                                dataReader["Poznamka"].ToString()
                                ));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return result;
        }

        public PokladniZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public PokladniZaznam VytvorZaznam(PokladniZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
