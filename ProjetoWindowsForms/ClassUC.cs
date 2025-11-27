using MySqlConnector;

namespace Projeto
{
    public class ClassUC
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int ID_UC { get; set; }
        public string Desc_UC { get; set; }
        public string ID_UCAndDesc_UC //retorna o id da UC e a decrição da UC em conjunto
        {
            get
            {
                return ID_UC + " - " + Desc_UC;
            }
        }
        public double n_h_s { get; set; }
        public int fk_id_curso { get; set; }
        public int fk_id_area { get; set; }
        public int fk_id_doc_regente { get; set; }
        public void InsertUC(int id_uc, string desc_uc, int fk_id_area, int fk_id_curso, int fk_id_doc_regente, double n_h_s)
        {
            string query = "INSERT INTO `t_uc`(`id_uc`, `desc_uc`, `fk_id_area`, `fk_id_curso`, `fk_id_doc_regente`, `n_h_s`) VALUES ('" + id_uc + "','" + desc_uc + "', '" + fk_id_area + "','" + fk_id_curso + "','" + fk_id_doc_regente + "', '" + n_h_s + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveUC(int id_uc)
        {
            string query = "DELETE FROM `t_uc` WHERE id_uc = " + id_uc;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditUC(int id_uc, string desc_uc, int fk_id_area, int fk_id_curso, int fk_id_doc_regente, double n_h_s)
        {
            string query = "UPDATE `t_uc` SET `id_uc`= '" + id_uc + "',`desc_uc` = '" + desc_uc + "',`fk_id_area` = '" + fk_id_area + "',`fk_id_curso` = '" + fk_id_curso + "',`fk_id_doc_regente` = '" + fk_id_doc_regente + "',`n_h_s` = '" + n_h_s + "' WHERE id_uc =" + id_uc + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassUC> GetUCs()
        {
            string query = "SELECT* FROM `t_uc`";
            var ucs = new List<ClassUC>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassUC f = new ClassUC();
                    f.ID_UC = (int)reader["id_uc"];
                    f.Desc_UC = (string)reader["desc_uc"];
                    f.fk_id_area = (int)reader["fk_id_area"];
                    f.fk_id_curso = (int)reader["fk_id_curso"];
                    f.fk_id_doc_regente = (int)reader["fk_id_doc_regente"];
                    f.n_h_s = (double)reader["n_h_s"];                    
                    ucs.Add(f);
                }
            }
            return ucs;
        }
    }
}
