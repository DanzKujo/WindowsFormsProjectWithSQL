using System.ComponentModel;

namespace Projeto
{
    public partial class ConsultarDSDForm : Form
    {
        private BindingSource _dataSource;
        public int fk_id_area; //id da area do responsavel
        public ConsultarDSDForm() //Primeira função a ser corrida
        {
            InitializeComponent();
        }
        public void setFk_id_area(int fk_id_area) //passa id da area do responsavel para a funçao UpdateListGridView()
        {
            this.fk_id_area = fk_id_area;
            UpdateListGridView(fk_id_area); 
        }

        private void UpdateListGridView(int fk_id_area) //atualizar a gridview com o filtro da area do responsavel
        {
            ClassDSD DSD = new ClassDSD();
            List<ClassDSD> allDSD = DSD.GetDSD(fk_id_area);
            SortableBindingList<ClassDSD> sortableBindingList = new SortableBindingList<ClassDSD>(allDSD);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista da query DSD com o filtro da area do responsavel á datasource
            dataGridView1.DataSource = _dataSource; //adiciona a datasource ao gridview 
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void ConsultarDSDForm_Load(object sender, EventArgs e) //Load do form "ConsultarDSDForm" depois da função ConsultarDSDForm() acabar
        {
            dataGridView1.Columns["Desc_Area"].HeaderText = "Descrição da Area";
            dataGridView1.Columns["Desc_Curso"].HeaderText = "Descrição do Curso";
            dataGridView1.Columns["Desc_UC"].HeaderText = "Descrição da UC";
            dataGridView1.Columns["H_aulas_doc"].HeaderText = "Horas/Aulas Docente";
            dataGridView1.Columns["Id_Area"].HeaderText = "ID da Área";
            dataGridView1.Columns["Id_Docente"].HeaderText = "ID do Docente";
            dataGridView1.Columns["Id_Semestre"].HeaderText = "ID do Semestre";
            dataGridView1.Columns["Id_Turma"].HeaderText = "ID da Turma";
            dataGridView1.Columns["Id_UC"].HeaderText = "ID da UC";
            dataGridView1.Columns["Nome"].HeaderText = "Nome";
            dataGridView1.Columns["Desc_Area"].Width = 100;
            dataGridView1.Columns["Desc_Curso"].Width = 100;
            dataGridView1.Columns["Desc_UC"].Width = 80;
            dataGridView1.Columns["H_aulas_doc"].Width = 50;
            dataGridView1.Columns["Id_Area"].Width = 50;
            dataGridView1.Columns["Id_Docente"].Width = 50;
            dataGridView1.Columns["Id_Semestre"].Width = 50;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ClassUtils classUtils = new ClassUtils();
            classUtils.DataGridViewtoCSVAlternative(dataGridView1);
        }
    }
}
