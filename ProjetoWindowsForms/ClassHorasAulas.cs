using MySqlConnector;

namespace Projeto
{
    public class ClassHorasAulas
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int HorasID { get; set; }
        public double H_Aulas { get; set; }
        public double Eti { get; set; }
        public string HorasIDandH_Aulas //retorna o id das horas e as horas em conjunto
        {
            get
            {
                return HorasID + " - " + H_Aulas;
            }
        }
        public void InsertHoras(int HorasID, double H_Aulas, double Eti)
        {
            string query = "INSERT INTO `t_h_aulas`(`id_horas`, `h_aulas`,`eti`) VALUES ('" + HorasID + "','" + H_Aulas + "','" + Eti + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveHoras(int HorasID)
        {
            string query = "DELETE FROM `t_h_aulas` WHERE id_horas = " + HorasID;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditHoras(int HorasID, double H_Aulas, double Eti)
        {
            string query = "UPDATE `t_h_aulas` SET `id_horas`='" + HorasID + "',`h_aulas` = '" + H_Aulas + "',`eti` = '" + Eti + "' WHERE id_horas =" + HorasID + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassHorasAulas> GetHorasAulas()
        {
            string query = "SELECT* FROM `t_h_aulas`";
            var HorasAulas = new List<ClassHorasAulas>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassHorasAulas f = new ClassHorasAulas();
                    f.HorasID = (int)reader["id_horas"];
                    f.H_Aulas = (double)reader["h_aulas"];
                    f.Eti = (double)reader["eti"];
                    HorasAulas.Add(f);
                }
            }
            return HorasAulas;
        }
    }
}
