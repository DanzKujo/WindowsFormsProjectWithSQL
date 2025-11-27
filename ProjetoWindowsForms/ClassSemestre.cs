using MySqlConnector;

namespace Projeto
{
    public class ClassSemestre
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public string SemestreID { get; set; }
        public string Desc_Semestre { get; set; }
        public string SemestreIDAndDesc_Semestre //retorna o id do semestre e a decrição do semestre em conjunto
        {
            get
            {
                return SemestreID + " - " + Desc_Semestre;
            }
        }
        public void InsertSemestre(string semestreid, string desc_semestre)
        {
            string query = "INSERT INTO `t_semestre`(`id_semestre`, `desc_semestre`) VALUES ('" + semestreid + "','" + desc_semestre + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveSemestre(string semestreid)
        {
            string query = "DELETE FROM `t_semestre` WHERE id_semestre = '" + semestreid + "'";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditSemestre(string semestreid, string desc_semestre)
        {
            string query = "UPDATE `t_semestre` SET `id_semestre`= '" + semestreid + "',`desc_semestre` = '" + desc_semestre + "' WHERE id_semestre = '" + semestreid + "'";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassSemestre> GetSemestres()
        {
            string query = "SELECT* FROM `t_semestre`";
            var semestres = new List<ClassSemestre>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassSemestre f = new ClassSemestre();
                    f.SemestreID = (string)reader["id_semestre"];
                    f.Desc_Semestre = (string)reader["desc_semestre"];
                    semestres.Add(f);
                }
            }
            return semestres;
        }
    }
}
