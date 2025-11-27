using MySqlConnector;

namespace Projeto
{
    public class ClassTurma
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public string TurmaID { get; set; }
        public string SemestreID { get; set; }

        public void InsertTurma(string turmaid, string semestreid)
        {
            string query = "INSERT INTO `t_turma`(`id_turma`, `fk_id_semestre`) VALUES ('"+ turmaid +"','"+ semestreid +"')";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveTurma(string turmaid)
        {
            string query = "DELETE FROM `t_turma` WHERE id_turma = '" + turmaid + "'";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditTurma(string turmaid, string semestreid)
        {
            string query = "UPDATE `t_turma` SET `id_turma`= '" + turmaid + "',`fk_id_semestre` = '" + semestreid + "' WHERE id_turma = '" + turmaid + "'";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassTurma> GetTurmas()
        {
            string query = "SELECT* FROM `t_turma`";
            var turmas = new List<ClassTurma>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassTurma f = new ClassTurma();
                    f.TurmaID = (string)reader["id_turma"];
                    f.SemestreID = (string)reader["fk_id_semestre"];
                    turmas.Add(f);
                }
            }
            return turmas;
        }       
    }
}
