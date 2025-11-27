using MySqlConnector;

namespace Projeto
{
    public class ClassAreaCientifica
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int AreaCientificaID { get; set; }
        public string Desc_AreaCientifica { get; set; }
        public string AreaCientificaIDandDesc_AreaCientifica //retorna o id da area cientifica e a decrição da area cientifica em conjunto
        {
            get
            {
                return AreaCientificaID + " - " + Desc_AreaCientifica;
            }
        }
        public void InsertArea(int AreaCientificaID, string Desc_AreaCientifica)
        {
            string query = "INSERT INTO `t_area_cientifica`(`id_a_cientifica`, `desc_a_cientifica`) VALUES ('" + AreaCientificaID + "','" + Desc_AreaCientifica + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveArea(int AreaCientificaID)
        {
            string query = "DELETE FROM `t_area_cientifica` WHERE id_a_cientifica = " + AreaCientificaID;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditArea(int AreaCientificaID, string Desc_AreaCientifica)
        {
            string query = "UPDATE `t_area_cientifica` SET `id_a_cientifica`= '" + AreaCientificaID + "',`desc_a_cientifica` = '" + Desc_AreaCientifica + "' WHERE id_a_cientifica =" + AreaCientificaID + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassAreaCientifica> GetAreasCientificas()
        {
            string query = "SELECT* FROM `t_area_cientifica`";
            var areascientificas = new List<ClassAreaCientifica>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassAreaCientifica f = new ClassAreaCientifica();
                    f.AreaCientificaID = (int)reader["id_a_cientifica"];
                    f.Desc_AreaCientifica = (string)reader["desc_a_cientifica"];
                    areascientificas.Add(f);
                }
            }
            return areascientificas;
        }
    }
}
