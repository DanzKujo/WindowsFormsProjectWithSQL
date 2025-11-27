using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Projeto
{
    public partial class UnidadeCurricularForm : Form
    {
        private BindingSource _dataSource;

        public UnidadeCurricularForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
            PopulateDropdownEditArea();
            PopulateDropdownEditCurso();
            PopulateDropdownEditDocente();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassUC UC = new ClassUC();
            List<ClassUC> allUcs = UC.GetUCs();
            SortableBindingList<ClassUC> sortableBindingList = new SortableBindingList<ClassUC>(allUcs);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das UCs todas á datasource
            dataGridView1.DataSource = _dataSource; //adiciona a datasource á gridview
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private void PopulateDropdownEditArea() //Preenche a lista da dropdown 
        {
            ClassArea area = new ClassArea();
            List<ClassArea> allareas = area.GetAreas();
            SortableBindingList<ClassArea> sortableBindingList = new SortableBindingList<ClassArea>(allareas);
            dropDownEditarUC_ID_Area.ValueMember = "AreaID";
            dropDownEditarUC_ID_Area.DisplayMember = "AreaIDandDesc_Area";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das areas todas á datasource
            dropDownEditarUC_ID_Area.DataSource = _dataSource; //adiciona a datasource á dropdown
            dropDownEditarUC_ID_Area.Refresh();
        }
        private void PopulateDropdownEditCurso() //Preenche a lista da dropdown 
        {
            ClassCurso curso = new ClassCurso();
            List<ClassCurso> allcursos = curso.GetCursos();
            SortableBindingList<ClassCurso> sortableBindingList = new SortableBindingList<ClassCurso>(allcursos);
            dropDownEditar_UC_ID_Curso.ValueMember = "CursoID";
            dropDownEditar_UC_ID_Curso.DisplayMember = "CursoIDAndDesc_Curso";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownEditar_UC_ID_Curso.DataSource = _dataSource;
            dropDownEditar_UC_ID_Curso.Refresh();
        }
        private void PopulateDropdownEditDocente() //Preenche a lista da dropdown 
        {
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> alldocentes = docente.GetDocentes();
            SortableBindingList<ClassDocente> sortableBindingList = new SortableBindingList<ClassDocente>(alldocentes);
            dropDownEditar_UC_ID_Docente.ValueMember = "id_docente";
            dropDownEditar_UC_ID_Docente.DisplayMember = "id_docenteAndNome";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownEditar_UC_ID_Docente.DataSource = _dataSource;
            dropDownEditar_UC_ID_Docente.Refresh();
        }
        private void PopulateDropdownCriarArea()
        {
            ClassArea area = new ClassArea();
            List<ClassArea> allareas = area.GetAreas();
            SortableBindingList<ClassArea> sortableBindingList = new SortableBindingList<ClassArea>(allareas);
            dropDownIDArea_Criar.ValueMember = "AreaID";
            dropDownIDArea_Criar.DisplayMember = "AreaIDandDesc_Area";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownIDArea_Criar.DataSource = _dataSource;
            dropDownIDArea_Criar.Refresh();
        }
        private void PopulateDropdownCriarCurso()
        {
            ClassCurso curso = new ClassCurso();
            List<ClassCurso> allcursos = curso.GetCursos();
            SortableBindingList<ClassCurso> sortableBindingList = new SortableBindingList<ClassCurso>(allcursos);
            dropDownIDCurso_Criar.ValueMember = "CursoID";
            dropDownIDCurso_Criar.DisplayMember = "CursoIDAndDesc_Curso";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownIDCurso_Criar.DataSource = _dataSource;
            dropDownIDCurso_Criar.Refresh();
        }
        private void PopulateDropdownCriarDocente()
        {
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> alldocentes = docente.GetDocentes();
            SortableBindingList<ClassDocente> sortableBindingList = new SortableBindingList<ClassDocente>(alldocentes);
            dropDownID_Docente_Criar.ValueMember = "id_docente";
            dropDownID_Docente_Criar.DisplayMember = "id_docenteAndNome";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownID_Docente_Criar.DataSource = _dataSource;
            dropDownID_Docente_Criar.Refresh();
        }
        private bool ContainsSpecialChars(string value)
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }
        private void ResetScreenAfterSave() //Update ao ecrã depois de ser feita uma alteração(save/guardar)
        {
            labelIDUnidadeCurricular_Criar.Visible = false;
            textBoxIDUnidadeCurricular_Criar.Visible = false;
            labelDescUnidadeCurricular_Criar.Visible = false;
            textBoxDescUnidadeCurricular_Criar.Visible = false;
            labelIDArea_Criar.Visible = false;
            labelIDCurso_Criar.Visible = false;
            labelID_Docente_Criar.Visible = false;
            labeln_h_s_Criar.Visible = false;
            textBoxn_h_s_Criar.Visible = false;
            dropDownIDArea_Criar.Visible = false;
            dropDownIDCurso_Criar.Visible = false;
            dropDownID_Docente_Criar.Visible = false;
            textBoxIDUnidadeCurricular.Enabled = false;
            textBoxDescUnidadeCurricular.Enabled = false;
            textboxEditarn_h_s.Enabled = false;
            dropDownEditarUC_ID_Area.Enabled = false;
            dropDownEditar_UC_ID_Curso.Enabled = false;
            dropDownEditar_UC_ID_Docente.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }
        private void UnidadeCurricularForm_Load(object sender, EventArgs e) //Load do form "UnidadeCurricular" depois da função UnidadeCurricularForm() acabar
        {
            dataGridView1.Columns["id_uc"].Width = 60;
            dataGridView1.Columns["id_uc"].HeaderText = "UC ID";
            dataGridView1.Columns["desc_uc"].HeaderText = "Descrição da UC";
            dataGridView1.Columns["fk_id_area"].HeaderText = "Area ID";
            dataGridView1.Columns["fk_id_curso"].HeaderText = "Curso ID";
            dataGridView1.Columns["fk_id_doc_regente"].HeaderText = "Docente Regente ID";
            dataGridView1.Columns["n_h_s"].HeaderText = "n_h_s";            
            dataGridView1.Columns.Remove("ID_UCAndDesc_UC");            
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes/dropdowns
        {
            var selectedUnidadeCurricular = dataGridView1.SelectedRows[0].DataBoundItem as ClassUC;
            textBoxIDUnidadeCurricular.Text = selectedUnidadeCurricular.ID_UC.ToString();
            textBoxDescUnidadeCurricular.Text = selectedUnidadeCurricular.Desc_UC;
            textboxEditarn_h_s.Text = selectedUnidadeCurricular.n_h_s.ToString();
            dropDownEditarUC_ID_Area.SelectedValue = selectedUnidadeCurricular.fk_id_area;
            dropDownEditar_UC_ID_Curso.SelectedValue = selectedUnidadeCurricular.fk_id_curso;
            dropDownEditar_UC_ID_Docente.SelectedValue = selectedUnidadeCurricular.fk_id_doc_regente;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDUnidadeCurricular_Criar.Text = "";
            textBoxDescUnidadeCurricular_Criar.Text = "";
            labelIDUnidadeCurricular_Criar.Visible = true;
            textBoxIDUnidadeCurricular_Criar.Visible = true;
            labelDescUnidadeCurricular_Criar.Visible = true;
            textBoxDescUnidadeCurricular_Criar.Visible = true;
            labelIDArea_Criar.Visible = true;
            labelIDCurso_Criar.Visible = true;
            labelID_Docente_Criar.Visible = true;
            dropDownIDArea_Criar.Visible = true;
            dropDownIDCurso_Criar.Visible = true;
            dropDownID_Docente_Criar.Visible = true;
            textBoxn_h_s_Criar.Visible = true;
            labeln_h_s_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDUnidadeCurricular.Enabled = false;
            textBoxDescUnidadeCurricular.Enabled = false;
            dropDownEditarUC_ID_Area.Enabled = false;
            dropDownEditar_UC_ID_Curso.Enabled = false;
            dropDownEditar_UC_ID_Docente.Enabled = false;
            PopulateDropdownCriarArea();
            PopulateDropdownCriarCurso();
            PopulateDropdownCriarDocente();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDUnidadeCurricular.Enabled = true;
            textBoxDescUnidadeCurricular.Enabled = true;
            dropDownEditarUC_ID_Area.Enabled = true;
            dropDownEditar_UC_ID_Curso.Enabled = true;
            dropDownEditar_UC_ID_Docente.Enabled = true;
            textboxEditarn_h_s.Enabled = true;
            buttonSave.Visible = true;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.ForeColor = Color.Gray;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            ClassUC uc = new ClassUC();
            List<ClassUC> allucs = uc.GetUCs();
            int listcount = allucs.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover esta Unidade Curricular?", "Remover Unidade Curricular", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover esta Unidade Curricular? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover Unidade Curricular", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
                    {
                        if (Convert.ToInt32(textBoxIDUnidadeCurricular.Text) != 0 || Convert.ToInt32(textBoxIDUnidadeCurricular.Text) > 0)
                        {
                            int index = allucs.FindIndex(ind => ind.ID_UC.Equals(Convert.ToInt32(textBoxIDUnidadeCurricular.Text)));
                            if (index != -1)
                            {
                                uc.RemoveUC(Convert.ToInt32(textBoxIDUnidadeCurricular.Text));
                                UpdateListGridView();
                                dataGridView1_CellClick(null, null);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.ToString().Contains("The input string '' was not in a correct format."))
                        {
                            MessageBox.Show("Tem que selecionar uma unidade curricular");
                        }
                        else
                        {
                            MessageBox.Show("Não é possivel apagar devido a esta unidade curricular estar associada a outras tabelas.");
                        }
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClassUC uc = new ClassUC();
            List<ClassUC> allucs = uc.GetUCs();

            if (textBoxIDUnidadeCurricular_Criar.Visible == true)
            {
                try
                {
                    if (allucs.Any(x => x.ID_UC == Int32.Parse(textBoxIDUnidadeCurricular_Criar.Text)))
                    {
                        MessageBox.Show("Este ID já existe.");
                    }
                    else
                    {
                        uc.InsertUC(Convert.ToInt32(textBoxIDUnidadeCurricular_Criar.Text), textBoxDescUnidadeCurricular_Criar.Text, Convert.ToInt32(dropDownIDArea_Criar.SelectedValue), Convert.ToInt32(dropDownIDCurso_Criar.SelectedValue), Convert.ToInt32(dropDownID_Docente_Criar.SelectedValue), Convert.ToDouble(textBoxn_h_s_Criar.Text));
                        UpdateListGridView();
                        ResetScreenAfterSave();
                    }
                }
                catch
                {
                    MessageBox.Show("ID da Unidade Curricular não pode ser nulo");
                }
            }
            else
            {
                try
                {
                    int index = allucs.FindIndex(ind => ind.ID_UC.Equals(Int32.Parse(textBoxIDUnidadeCurricular.Text)));
                    if (index != -1)
                    {
                        uc.EditUC(Convert.ToInt32(textBoxIDUnidadeCurricular.Text), textBoxDescUnidadeCurricular.Text, Convert.ToInt32(dropDownEditarUC_ID_Area.SelectedValue), Convert.ToInt32(dropDownEditar_UC_ID_Curso.SelectedValue), Convert.ToInt32(dropDownEditar_UC_ID_Docente.SelectedValue), Convert.ToDouble(textboxEditarn_h_s.Text));
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe, deve criar um.");
                        textBoxIDUnidadeCurricular.Text = "";
                        textBoxDescUnidadeCurricular.Text = "";
                        textboxEditarn_h_s.Text = "";
                        dropDownEditarUC_ID_Area.SelectedIndex = 0;
                        dropDownEditar_UC_ID_Curso.SelectedIndex = 0;
                        dropDownEditar_UC_ID_Docente.SelectedIndex = 0;
                    }
                    UpdateListGridView();
                    ResetScreenAfterSave();
                    dataGridView1_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("ID da Unidade Curricular não pode ser nulo");
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDUnidadeCurricular_Criar.Visible = false;
            textBoxIDUnidadeCurricular_Criar.Visible = false;
            labelDescUnidadeCurricular_Criar.Visible = false;
            textBoxDescUnidadeCurricular_Criar.Visible = false;
            labelIDArea_Criar.Visible = false;
            labelIDCurso_Criar.Visible = false;
            labelID_Docente_Criar.Visible = false;
            dropDownIDArea_Criar.Visible = false;
            dropDownIDCurso_Criar.Visible = false;
            dropDownID_Docente_Criar.Visible = false;
            textBoxn_h_s_Criar.Visible = false;
            labeln_h_s_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDUnidadeCurricular.Enabled = false;
            textBoxDescUnidadeCurricular.Enabled = false;
            textboxEditarn_h_s.Enabled = false;
            dropDownEditarUC_ID_Area.Enabled = false;
            dropDownEditar_UC_ID_Curso.Enabled = false;
            dropDownEditar_UC_ID_Docente.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }
        #region Manipulação de strings na zona de criar
        private void textBoxIDUnidadeCurricular_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDUnidadeCurricular_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDUnidadeCurricular_Criar.Text.Length >= 1)
                    textBoxIDUnidadeCurricular_Criar.Text = Regex.Replace(textBoxIDUnidadeCurricular_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescUnidadeCurricular_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescUnidadeCurricular_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescUnidadeCurricular_Criar.Text.Length >= 1)
                    textBoxDescUnidadeCurricular_Criar.Text = Regex.Replace(textBoxDescUnidadeCurricular_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxn_h_s_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxn_h_s_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxn_h_s_Criar.Text.Length >= 1)
                    textBoxn_h_s_Criar.Text = Regex.Replace(textBoxn_h_s_Criar.Text, "[^0-9]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDUnidadeCurricular_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDUnidadeCurricular.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDUnidadeCurricular.Text.Length >= 1)
                    textBoxIDUnidadeCurricular.Text = Regex.Replace(textBoxIDUnidadeCurricular.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescUnidadeCurricular_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescUnidadeCurricular.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescUnidadeCurricular.Text.Length >= 1)
                    textBoxDescUnidadeCurricular.Text = Regex.Replace(textBoxDescUnidadeCurricular.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }

        private void textboxEditarn_h_s_TextChanged(object sender, EventArgs e)
        {
            if (!textboxEditarn_h_s.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textboxEditarn_h_s.Text.Length >= 1)
                    textboxEditarn_h_s.Text = Regex.Replace(textboxEditarn_h_s.Text, "[^0-9]", "");
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
