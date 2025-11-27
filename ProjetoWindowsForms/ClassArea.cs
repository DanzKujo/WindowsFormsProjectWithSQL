using MySqlConnector;

namespace Projeto
{
    public class ClassArea
    {        
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public int AreaID { get; set; }
        public string Desc_Area { get; set; }
        public string AreaIDandDesc_Area //retorna o id da area e a decrição da area em conjunto
        {
            get
            {
                return AreaID + " - " + Desc_Area;
            }
        }
        public void InsertArea(int areaid, string desc_area)
        {            
            string query = "INSERT INTO `t_area`(`id_area`, `desc_area`) VALUES ('" + areaid + "','" + desc_area + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query,cnn);                
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void RemoveArea(int areaid)
        {           
            string query = "DELETE FROM `t_area` WHERE id_area = " + areaid;

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);               
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditArea(int areaid, string desc_area)
        {            
            string query = "UPDATE `t_area` SET `id_area`= '" + areaid + "',`desc_area` = '" + desc_area + "' WHERE id_area =" + areaid + "";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);                
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public List<ClassArea> GetAreas()
        {                       
            string query = "SELECT* FROM `t_area`";
            var areas = new List<ClassArea>();

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassArea f = new ClassArea();
                    f.AreaID = (int)reader["id_area"];
                    f.Desc_Area = (string)reader["desc_area"];                    
                    areas.Add(f);
                }                
            }
            return areas;
        }      
    }
}
