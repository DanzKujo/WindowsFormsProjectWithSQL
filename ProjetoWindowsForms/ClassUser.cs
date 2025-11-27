using MySqlConnector;

namespace Projeto
{
    public class ClassUser
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int fk_id_area {  get; set; }
        public int id_r_area {  get; set; }
        public string nome { get; set; }
        public string password { get; set; }
        public string user { get; set; }

        public List<ClassUser> GetUser(string username, string password)
        {
            string query = "SELECT * FROM `t_responsavel_area` where user='" + username + "' and password='" + password + "'";
            var user = new List<ClassUser>();
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassUser f = new ClassUser();
                    f.fk_id_area = (int)reader["fk_id_area"];
                    f.id_r_area = (int)reader["id_r_area"];
                    f.nome = (string)reader["nome"];
                    f.password = (string)reader["password"];
                    f.user = (string)reader["user"];
                    user.Add(f);
                }
            }
            return user;
        }
    }
}
