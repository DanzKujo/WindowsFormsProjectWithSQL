using MySqlConnector;
using System.Globalization;
namespace Projeto
{
    public class ClassDSD
    {
        public string connectionString = $"Server={SqlConnectionData.server};Database={SqlConnectionData.dbName};User={SqlConnectionData.userName};Password={SqlConnectionData.password};";
        public string Desc_Area { get; set; }
        public string Desc_Curso { get; set; }
        public string Desc_UC { get; set; }
        public double H_aulas_doc { get; set; }
        public int Id_Area { get; set; }
        public int Id_Docente { get; set; }
        public string Id_Semestre { get; set; }
        public string Id_Turma { get; set; }        
        public int Id_UC { get; set; }
        public string Nome { get; set; }

        public string query;

        public List<ClassDSD> GetDSD(int fk_id_area)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            double h_aulasdoc;
            string stringh_aulasdoc;
            if (fk_id_area == 9999)
            {                
                query = "SELECT s.ID_semestre, a.ID_area, a.desc_area, c.desc_curso, uc.ID_uc, uc.desc_uc, t.ID_turma, utd.h_aulas_doc, d.ID_docente, d.nome FROM t_docente AS d, t_categoria AS ct, t_area_cientifica AS ac, t_docente_area AS da, t_area AS a, t_doc_grau_acad AS dga, t_grau_acad AS ga, t_area_grau AS ag, t_doc_h_sem AS dhs, t_h_aulas AS ha, t_semestre AS s, t_uc_turma_doc AS utd, t_turma AS t, t_uc AS uc, t_curso AS c, t_docente AS dr, t_h_aulas AS haeti WHERE d.fk_ID_categoria=ct.ID_categoria AND d.fk_ID_a_cientifica=ac.ID_a_cientifica AND d.ID_docente=da.fk_ID_docente And d.ID_docente=dga.fk_ID_docente And d.ID_docente=dhs.fk_ID_docente AND a.ID_area=da.fk_ID_area AND dga.fk_ID_grau_acad=ga.ID_grau_acad AND dga.fk_ID_area_grau=ag.ID_area_grau AND dhs.fk_ID_horas=ha.ID_horas AND dhs.fk_ID_semestre=s.ID_semestre and d.ID_docente = utd.fk_ID_docente and utd.fk_ID_turma = t.ID_turma and utd.fk_ID_uc = uc.ID_uc and uc.fk_ID_curso = c.ID_curso and t.fk_ID_semestre = s.ID_semestre and uc.fk_ID_doc_regente = dr.ID_docente and d.fk_ID_horas = haeti.ID_horas ORDER BY s.ID_semestre, a.ID_area, c.desc_curso, uc.desc_uc, t.ID_turma";
            }
            else
            {               
                query = "SELECT s.ID_semestre, a.ID_area, a.desc_area, c.desc_curso, uc.ID_uc, uc.desc_uc, t.ID_turma, utd.h_aulas_doc, d.ID_docente, d.nome FROM t_docente AS d, t_categoria AS ct, t_area_cientifica AS ac, t_docente_area AS da, t_area AS a, t_doc_grau_acad AS dga, t_grau_acad AS ga, t_area_grau AS ag, t_doc_h_sem AS dhs, t_h_aulas AS ha, t_semestre AS s, t_uc_turma_doc AS utd, t_turma AS t, t_uc AS uc, t_curso AS c, t_docente AS dr, t_h_aulas AS haeti WHERE d.fk_ID_categoria=ct.ID_categoria AND d.fk_ID_a_cientifica=ac.ID_a_cientifica AND d.ID_docente=da.fk_ID_docente And d.ID_docente=dga.fk_ID_docente And d.ID_docente=dhs.fk_ID_docente AND a.ID_area= " + fk_id_area + " AND dga.fk_ID_grau_acad=ga.ID_grau_acad AND dga.fk_ID_area_grau=ag.ID_area_grau AND dhs.fk_ID_horas=ha.ID_horas AND dhs.fk_ID_semestre=s.ID_semestre and d.ID_docente = utd.fk_ID_docente and utd.fk_ID_turma = t.ID_turma and utd.fk_ID_uc = uc.ID_uc and uc.fk_ID_curso = c.ID_curso and t.fk_ID_semestre = s.ID_semestre and uc.fk_ID_doc_regente = dr.ID_docente and d.fk_ID_horas = haeti.ID_horas ORDER BY s.ID_semestre, a.ID_area, c.desc_curso, uc.desc_uc, t.ID_turma";
            }
            var DSD = new List<ClassDSD>();
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, cnn);
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    ClassDSD f = new ClassDSD();
                    f.Desc_Area = (string)reader["desc_area"];
                    f.Desc_Curso = (string)reader["desc_curso"];
                    f.Desc_UC = (string)reader["desc_uc"];
                    h_aulasdoc = (double)reader["h_aulas_doc"];
                    stringh_aulasdoc = h_aulasdoc.ToString(nfi);
                    h_aulasdoc = Convert.ToDouble(stringh_aulasdoc, NumberFormatInfo.InvariantInfo);
                    f.H_aulas_doc = h_aulasdoc;                    
                    f.Id_Area = (int)reader["id_area"];
                    f.Id_Docente = (int)reader["id_docente"];
                    f.Id_Semestre = (string)reader["id_semestre"];
                    f.Id_Turma = (string)reader["id_turma"];
                    f.Id_UC = (int)reader["id_uc"];
                    f.Nome = (string)reader["nome"];
                    DSD.Add(f);
                }
            }
            return DSD;
        }

        public void InsertDSDAdicionarOutroDocenteTurma(int id_docente, string id_turma, int id_uc, double h_aulas_doc)
        {
            string query = "INSERT INTO `t_uc_turma_doc`(`fk_id_docente`, `fk_id_turma`, `fk_id_uc`, `h_aulas_doc`) VALUES ('" + id_docente + " ','" + id_turma + "', '" + id_uc + "','" + h_aulas_doc + "')";

            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                try
                {
                    insCmd.ExecuteNonQuery();
                    MessageBox.Show("Sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel adicionar outro docente á turma por já existir este docente nesta turma.");
                }
            }
        }
        public void EditDSDh_doc(int id_docente, string id_turma, int id_uc, double h_aulas_doc)
        {
            string query = "UPDATE `t_uc_turma_doc` SET h_aulas_doc = " + h_aulas_doc + " WHERE fk_id_docente = " + id_docente + " AND " + "fk_id_turma = " + "'" + id_turma + "'" + " AND " + "fk_id_uc = " + id_uc + "";
            query = query.Replace(",", ".");
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
        public void EditDSDDocenteTurma(int oldid_docente,int id_docente, string id_turma, int id_uc, double h_aulas_doc)
        {
            string query = "UPDATE `t_uc_turma_doc` SET fk_id_docente = " + id_docente + " WHERE fk_id_uc = " + id_uc + " AND " + "fk_id_turma = " + "'" + id_turma + "'" + " AND " + "h_aulas_doc = " + h_aulas_doc + " AND " + "fk_id_docente = " + oldid_docente + "";
            query = query.Replace(",", ".");
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                cnn.Open();
                MySqlCommand insCmd = new MySqlCommand(query, cnn);
                insCmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso");
            }
        }
    }
}
