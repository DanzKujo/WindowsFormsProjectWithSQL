using MySqlConnector;

namespace Projeto
{
    public class ClassCurso
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int CursoID { get; set; }
        public string Desc_Curso { get; set; }
        public string CursoIDAndDesc_Curso //retorna o id do curso e a decrição do curso em conjunto
        {
            get
            {
                return CursoID + " - " + Desc_Curso;
            }
        }
        public void InsertCurso(int cursoid, string desc_curso)
        {
            string query = "INSERT INTO `t_curso`(`id_curso`, `desc_curso`) VALUES ('" + cursoid + "','" + desc_curso + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveCurso(int cursoid)
        {
            string query = "DELETE FROM `t_curso` WHERE id_curso = " + cursoid;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditCurso(int cursoid, string desc_curso)
        {
            string query = "UPDATE `t_curso` SET `id_curso`= '" + cursoid + "',`desc_curso` = '" + desc_curso + "' WHERE id_curso =" + cursoid + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassCurso> GetCursos()
        {
            string query = "SELECT* FROM `t_curso`";
            var cursos = new List<ClassCurso>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassCurso f = new ClassCurso();
                    f.CursoID = (int)reader["id_curso"];
                    f.Desc_Curso = (string)reader["desc_curso"];
                    cursos.Add(f);
                }
            }
            return cursos;
        }
    }
}
