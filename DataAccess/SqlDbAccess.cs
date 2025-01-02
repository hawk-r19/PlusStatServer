using DataTypes;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class SqlDbAccess : I_DbAccess
    {
        private string _sqlConnectionString;

        public SqlDbAccess(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }

        public List<PlayerInfo> GetPlayerInfo(uint count = 0)
        {
            List<PlayerInfo> players = new List<PlayerInfo>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = _sqlConnectionString;
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    if (count > 0)
                    {
                        command.CommandText = "SELECT TOP(@count) * FROM PlayerInfo";
                        command.Parameters.AddWithValue("@count", (int)count);
                    }
                    else
                    {
                        command.CommandText = "SELECT * FROM PlayerInfo";
                    }

                    command.Connection = connection;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int birthYear = 0;
                            if (reader["BirthYear"] != DBNull.Value)
                            {
                                birthYear = (int)reader["BirthYear"];
                            }
                            PlayerInfo p = new PlayerInfo((int)reader["PlayerID"], reader["Name"].ToString(), birthYear);
                            players.Add(p);
                        }
                    }
                }
            }

            return players;
        }
    }
}
