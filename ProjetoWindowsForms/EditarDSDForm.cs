using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Projeto
{
    public partial class EditarDSDForm : Form
    {
        private BindingSource _dataSource;
        public int fk_id_area;
        public EditarDSDForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            PopulateDropdownNome();
        }

        public void setFk_id_area(int fk_id_area) //Set ao user com o id da area do responsavel
        {
            this.fk_id_area = fk_id_area;
            UpdateListGridView(fk_id_area);
        }

        private void UpdateListGridView(int fk_id_area) //Faz update á lista da gridview com o filtro do id da area responsavel
        {
            ClassDSD DSD = new ClassDSD();
            List<ClassDSD> allDSD = DSD.GetDSD(fk_id_area);
            SortableBindingList<ClassDSD> sortableBindingList = new SortableBindingList<ClassDSD>(allDSD);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista da query dsd com o filtro id da area responsavel todos á datasource 
            dataGridView1.DataSource = _dataSource; //adiciona a datasource á gridview
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);            
        }

        private void PopulateDropdownNome() //Preenche a lista da dropdown 
        {
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> alldocentes = docente.GetDocentes();
            SortableBindingList<ClassDocente> sortableBindingList = new SortableBindingList<ClassDocente>(alldocentes);
            dropDownNome.ValueMember = "id_docente";
            dropDownNome.DisplayMember = "nome";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista dos nomes todos á datasource 
            dropDownNome.DataSource = _dataSource; //adiciona a datasource á dropdown
            dropDownNome.Refresh();
        }

        private bool ContainsSpecialChars(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }

        private void ResetScreenAfterSave() //Update ao ecrã depois de ser feita uma alteração(save/guardar)
        {
            dropDownNome.Enabled = false;
            textboxh_aulas_doc.Enabled = false;
            buttonSave.Enabled = false;
            buttonSave.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;
            labelAlterarDocenteTurma.Visible = false;
            labelAlterarHorasLecionacao.Visible = false;
            labelAdicionarOutroDocenteTurma.Visible = false;
            buttonAlterarDocenteTurma.Visible = true;
            buttonAlterarHorasLecionacao.Visible = true;
            buttonAdicionarOutroDocenteTurma.Visible = true;
            labelID_Semestre.Visible = true;
            textboxID_Semestre.Visible = true;
            labelID_Area.Visible = true;
            textboxID_Area.Visible = true;
            labelDesc_area.Visible = true;
            textboxDesc_area.Visible = true;
            labelDesc_curso.Visible = true;
            textboxDesc_curso.Visible = true;
            labelID_docente.Visible = true;
            textboxID_docente.Visible = true;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.Columns["Id_Semestre"].DisplayIndex = 0;
            dataGridView1.Columns["Desc_UC"].DisplayIndex = 1;
            dataGridView1.Columns["Id_Turma"].DisplayIndex = 2;
            dataGridView1.Columns["H_aulas_doc"].DisplayIndex = 3;
            dataGridView1.Columns["Nome"].DisplayIndex = 4;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null);
        }

        private void EditarDSDForm_Load(object sender, EventArgs e) //Load do form "EditarDSDForm" depois da função EditarDSDForm() acabar
        {
            dataGridView1.Columns["Desc_Area"].HeaderText = "Descrição da Area";
            dataGridView1.Columns["Desc_Curso"].HeaderText = "Descrição do Curso";
            dataGridView1.Columns["H_aulas_doc"].HeaderText = "Horas/Aulas Docente";
            dataGridView1.Columns["Desc_UC"].HeaderText = "Descrição da UC";
            dataGridView1.Columns["Id_Area"].HeaderText = "ID da Área";
            dataGridView1.Columns["Id_Docente"].HeaderText = "ID do Docente";
            dataGridView1.Columns["Id_Semestre"].HeaderText = "ID do Semestre";
            dataGridView1.Columns["Id_Turma"].HeaderText = "ID da Turma";
            dataGridView1.Columns["Id_UC"].HeaderText = "ID da UC";
            dataGridView1.Columns["Nome"].HeaderText = "Nome";
            dataGridView1.Columns["Id_Semestre"].DisplayIndex = 0;
            dataGridView1.Columns["Desc_UC"].DisplayIndex = 1;
            dataGridView1.Columns["Id_Turma"].DisplayIndex = 2;
            dataGridView1.Columns["H_aulas_doc"].DisplayIndex = 3;
            dataGridView1.Columns["Nome"].DisplayIndex = 4;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes/dropdowns
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes/dropdowns
        {
            var selectedDSD = dataGridView1.SelectedRows[0].DataBoundItem as ClassDSD;
            textboxID_Semestre.Text = selectedDSD.Id_Semestre;
            textboxID_Area.Text = selectedDSD.Id_Area.ToString();
            textboxDesc_area.Text = selectedDSD.Desc_Area;
            textboxDesc_curso.Text = selectedDSD.Desc_Curso;
            textboxID_uc.Text = selectedDSD.Id_UC.ToString();
            textboxDesc_uc.Text = selectedDSD.Desc_UC;
            textboxID_turma.Text = selectedDSD.Id_Turma;
            textboxID_docente.Text = selectedDSD.Id_Docente.ToString();
            dropDownNome.SelectedValue = selectedDSD.Id_Docente;
            textboxh_aulas_doc.Text = selectedDSD.H_aulas_doc.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClassDSD dsd = new ClassDSD();
            List<ClassDSD> alldsd = dsd.GetDSD(fk_id_area);
            string h_aulasdoc = textboxh_aulas_doc.Text.Replace(",", ".");

            if (labelAlterarDocenteTurma.Visible == true)
            {
                dsd.EditDSDDocenteTurma(Convert.ToInt32(textboxID_docente.Text), Convert.ToInt32(dropDownNome.SelectedValue), textboxID_turma.Text, Convert.ToInt32(textboxID_uc.Text), Convert.ToDouble(textboxh_aulas_doc.Text));
                UpdateListGridView(fk_id_area);
                ResetScreenAfterSave();
            }
            else if (labelAlterarHorasLecionacao.Visible == true)
            {
                dsd.EditDSDh_doc(Convert.ToInt32(dropDownNome.SelectedValue), textboxID_turma.Text, Convert.ToInt32(textboxID_uc.Text), Convert.ToDouble(h_aulasdoc, NumberFormatInfo.InvariantInfo));
                UpdateListGridView(fk_id_area);
                ResetScreenAfterSave();
            }
            else
            {
                dsd.InsertDSDAdicionarOutroDocenteTurma(Convert.ToInt32(dropDownNome.SelectedValue), textboxID_turma.Text, Convert.ToInt32(textboxID_uc.Text), Convert.ToDouble(textboxh_aulas_doc.Text));
                UpdateListGridView(fk_id_area);
                ResetScreenAfterSave();
            }
        }

        private void buttonAlterarDocenteTurma_Click(object sender, EventArgs e)
        {
            dropDownNome.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView1.ForeColor = Color.Gray;
            labelID_docente.Visible = false;
            textboxID_docente.Visible = false;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            labelAlterarDocenteTurma.Visible = true;
            buttonAlterarDocenteTurma.Visible = false;
            buttonAlterarHorasLecionacao.Visible = false;
            buttonAdicionarOutroDocenteTurma.Visible = false;
        }
        private void buttonAlterarHorasLecionacao_Click(object sender, EventArgs e)
        {
            textboxh_aulas_doc.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView1.ForeColor = Color.Gray;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            labelAlterarHorasLecionacao.Visible = true;
            buttonAlterarDocenteTurma.Visible = false;
            buttonAlterarHorasLecionacao.Visible = false;
            buttonAdicionarOutroDocenteTurma.Visible = false;
        }
        private void buttonAdicionarOutroDocenteTurma_Click(object sender, EventArgs e)
        {
            dropDownNome.Enabled = true;
            dataGridView1.Enabled = false;
            dataGridView1.ForeColor = Color.Gray;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            labelAdicionarOutroDocenteTurma.Visible = true;
            buttonAlterarDocenteTurma.Visible = false;
            buttonAlterarHorasLecionacao.Visible = false;
            buttonAdicionarOutroDocenteTurma.Visible = false;
            labelID_Semestre.Visible = false;
            textboxID_Semestre.Visible = false;
            labelID_Area.Visible = false;
            textboxID_Area.Visible = false;
            labelDesc_area.Visible = false;
            textboxDesc_area.Visible = false;
            labelDesc_curso.Visible = false;
            textboxDesc_curso.Visible = false;
            labelID_docente.Visible = false;
            textboxID_docente.Visible = false;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dropDownNome.Enabled = false;
            textboxh_aulas_doc.Enabled = false;
            buttonSave.Enabled = false;
            buttonSave.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;
            labelAlterarDocenteTurma.Visible = false;
            labelAlterarHorasLecionacao.Visible = false;
            labelAdicionarOutroDocenteTurma.Visible = false;
            buttonAlterarDocenteTurma.Visible = true;
            buttonAlterarHorasLecionacao.Visible = true;
            buttonAdicionarOutroDocenteTurma.Visible = true;
            labelID_Semestre.Visible = true;
            textboxID_Semestre.Visible = true;
            labelID_Area.Visible = true;
            textboxID_Area.Visible = true;
            labelDesc_area.Visible = true;
            textboxDesc_area.Visible = true;
            labelDesc_curso.Visible = true;
            textboxDesc_curso.Visible = true;
            labelID_docente.Visible = true;
            textboxID_docente.Visible = true;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }
        #region Manipulação de string na textbox h_aulas_doc
        private void textboxh_aulas_doc_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textboxh_aulas_doc.Text))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textboxh_aulas_doc.Text.Length >= 1)
                    textboxh_aulas_doc.Text = Regex.Replace(textboxh_aulas_doc.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|<>\\/?]", "");
            }
        }
        #endregion
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ClassUtils classUtils = new ClassUtils();
            classUtils.DataGridViewtoCSVAlternative(dataGridView1);
        }
    }
}
