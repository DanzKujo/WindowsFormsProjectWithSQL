using MySqlConnector;

namespace Projeto
{
    public class ClassDocente
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int id_docente { get; set; }
        public string Nome { get; set; }
        public string id_docenteAndNome //retorna o id do docente e o nome do docente em conjunto
        {
            get
            {
                return id_docente + " - " + Nome;
            }
        }

        public string Email { get; set; }
        public bool Carreira { get; set; }        
        public bool C_mais_3 { get; set; }
        public int fk_id_categoria { get; set; }
        public int fk_id_a_cientifica { get; set; }
        public int fk_id_horas { get; set; }        
        public string CarreiraString { get; set; }        
        public string c_mais_3String { get; set; }



        public void InsertDocente(int docenteid, string nome, string email, int fk_id_horas, int fk_id_categoria, int fk_id_a_cientifica, int c_mais_3, int carreira)
        {
            string query = "INSERT INTO `t_docente`(`id_docente`, `nome`, `email`, `fk_id_horas`, `fk_id_categoria`, `fk_id_a_cientifica`,`c_mais_3`,`carreira` ) VALUES ('" + docenteid + " ','" + nome + "', '" + email + "','" + fk_id_horas + "','" + fk_id_categoria + "', '" + fk_id_a_cientifica + "','" + c_mais_3 + "','" + carreira + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
       public void RemoveDocente(int docenteid)
        {
            string query = "DELETE FROM `t_docente` WHERE id_docente = " + docenteid;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditDocente(int docenteid, string nome, string email, int fk_id_horas, int fk_id_categoria, int fk_id_a_cientifica, int c_mais_3, int carreira)
        {
            string query = "UPDATE `t_docente` SET `id_docente`= '" + docenteid + "',`nome` = '" + nome + "',`email` = '" + email + "',`fk_id_horas` = '" + fk_id_horas + "',`fk_id_categoria` = '" + fk_id_categoria + "',`fk_id_a_cientifica` = '" + fk_id_a_cientifica + "',`c_mais_3` = '" + c_mais_3 + "',`carreira` = '" + carreira + "' WHERE id_docente =" + docenteid + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassDocente> GetDocentes()
        {
            string query = "SELECT* FROM `t_docente`";
            var docentes = new List<ClassDocente>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassDocente f = new ClassDocente();
                    f.id_docente = (int)reader["id_docente"];
                    f.Nome = (string)reader["nome"];
                    f.Email = (string)reader["email"];
                    f.fk_id_horas = (int)reader["fk_id_horas"];
                    f.fk_id_categoria = (int)reader["fk_id_categoria"];
                    f.fk_id_a_cientifica = (int)reader["fk_id_a_cientifica"];
                    f.C_mais_3 = (bool)reader["c_mais_3"];
                    f.Carreira = (bool)reader["carreira"];
                    f.c_mais_3String = f.C_mais_3 ? "Sim" : "Não";
                    f.CarreiraString = f.Carreira ? "Sim" : "Não";
                    docentes.Add(f);
                }
            }
            return docentes;
        }
    }
}
