using MySqlConnector;

namespace Projeto
{
    public class ClassCategoria
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int CategoriaID { get; set; }
        public string Desc_Categoria { get; set; }
        public string CategoriaIDAndDesc_Categoria //retorna o id da categoria e a decrição da categoria em conjunto
        {
            get
            {
                return CategoriaID + " - " + Desc_Categoria;
            }
        }
        public void InsertCategoria(int categoriaid, string desc_categoria)
        {
            string query = "INSERT INTO `t_categoria`(`id_categoria`, `desc_categoria`) VALUES ('" + categoriaid + "','" + desc_categoria + "')";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveCategoria(int categoriaid)
        {
            string query = "DELETE FROM `t_categoria` WHERE id_categoria = " + categoriaid;
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditCategoria(int categoriaid, string desc_categoria)
        {
            string query = "UPDATE `t_categoria` SET `id_categoria`= '" + categoriaid + "',`desc_categoria` = '" + desc_categoria + "' WHERE id_categoria =" + categoriaid + "";
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassCategoria> GetCategorias()
        {
            string query = "SELECT* FROM `t_categoria`";
            var categorias = new List<ClassCategoria>();
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassCategoria f = new ClassCategoria();
                    f.CategoriaID = (int)reader["id_categoria"];
                    f.Desc_Categoria = (string)reader["desc_categoria"];
                    categorias.Add(f);
                }
            }
            return categorias;
        }
    }
}
