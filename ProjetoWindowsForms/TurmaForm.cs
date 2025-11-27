using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Projeto
{
    public partial class TurmaForm : Form
    {
        private BindingSource _dataSource;

        public TurmaForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
            PopulateDropdownEditSemestre();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassTurma turma = new ClassTurma();
            List<ClassTurma> allTurmas = turma.GetTurmas();
            SortableBindingList<ClassTurma> sortableBindingList = new SortableBindingList<ClassTurma>(allTurmas);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;  //Adiciona a lista das turmas todas á datasource 
            dataGridView1.DataSource = _dataSource; //adiciona a datasource á gridview
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private void PopulateDropdownEditSemestre() //Preenche a lista da dropdown 
        {
            ClassSemestre semestre = new ClassSemestre();
            List<ClassSemestre> allSemestres = semestre.GetSemestres();
            SortableBindingList<ClassSemestre> sortableBindingList = new SortableBindingList<ClassSemestre>(allSemestres);
            dropDownEditarTurmaSemestre.ValueMember = "SemestreID";
            dropDownEditarTurmaSemestre.DisplayMember = "SemestreIDAndDesc_Semestre";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;//Adiciona a lista dos semestres todas á datasource 
            dropDownEditarTurmaSemestre.DataSource = _dataSource;  //adiciona a datasource á dropdown
            dropDownEditarTurmaSemestre.Refresh();
        }
        private void PopulateDropdownCriarSemestre()  //Preenche a lista da dropdown
        {
            ClassSemestre semestre = new ClassSemestre();
            List<ClassSemestre> allSemestres = semestre.GetSemestres();
            SortableBindingList<ClassSemestre> sortableBindingList = new SortableBindingList<ClassSemestre>(allSemestres);
            dropDownCriarTurmaSemestre.ValueMember = "SemestreID";
            dropDownCriarTurmaSemestre.DisplayMember = "SemestreIDAndDesc_Semestre";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownCriarTurmaSemestre.DataSource = _dataSource;
            dropDownCriarTurmaSemestre.Refresh();
        }
        private bool ContainsSpecialChars(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }
        private bool ContainsSpecialCharsExcludePlusChar(string value) //Verifica se tem os characteres especificos (especiais sem ser o "+") na string 
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "=", "\"" };
            return list.Any(value.Contains);
        }
        private void ResetScreenAfterSave() //Update ao ecrã depois de ser feita uma alteração(save/guardar)
        {
            labelIDTurma_Criar.Visible = false;
            textBoxIDTurma_Criar.Visible = false;
            labelSemestreID_Criar.Visible = false;
            dropDownCriarTurmaSemestre.Visible = false;
            textBoxIDTurma.Enabled = false;
            dropDownEditarTurmaSemestre.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }
        private void TurmaForm_Load(object sender, EventArgs e) //Load do form "TurmaForm" depois da função TurmaForm() acabar
        {
            dataGridView1.Columns["TurmaID"].Width = 120;
            dataGridView1.Columns["TurmaID"].HeaderText = "Turma ID";
            dataGridView1.Columns["SemestreID"].HeaderText = "Semestre ID";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes/dropdowns
        {
            var selectedTurma = dataGridView1.SelectedRows[0].DataBoundItem as ClassTurma;
            textBoxIDTurma.Text = selectedTurma.TurmaID;
            dropDownEditarTurmaSemestre.SelectedValue = selectedTurma.SemestreID;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDTurma_Criar.Text = "";
            labelIDTurma_Criar.Visible = true;
            textBoxIDTurma_Criar.Visible = true;
            labelSemestreID_Criar.Visible = true;
            dropDownCriarTurmaSemestre.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDTurma.Enabled = false;
            dropDownEditarTurmaSemestre.Enabled = false;
            PopulateDropdownCriarSemestre();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDTurma.Enabled = true;
            dropDownEditarTurmaSemestre.Enabled = true;
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
            ClassTurma turma = new ClassTurma();
            List<ClassTurma> allTurmas = turma.GetTurmas();
            int listcount = allTurmas.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover esta turma?", "Remover turma", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover esta turma? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover turma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
            {
                if (!string.IsNullOrEmpty(textBoxIDTurma.Text))
                {
                    int index = allTurmas.FindIndex(ind => ind.TurmaID.Equals(textBoxIDTurma.Text));
                    if (index != -1)
                    {
                        turma.RemoveTurma(textBoxIDTurma.Text);
                        UpdateListGridView();
                        dataGridView1_CellClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("The input string '' was not in a correct format."))
                {
                    MessageBox.Show("Tem que selecionar uma turma");
                }
                else
                {
                    MessageBox.Show("Não é possivel apagar devido a esta turma estar associada a outras tabelas.");
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
            ClassTurma turma = new ClassTurma();
            List<ClassTurma> allTurmas = turma.GetTurmas();

            if (textBoxIDTurma_Criar.Visible == true)
            {
                try
                {
                    if (allTurmas.Any(x => x.TurmaID == textBoxIDTurma_Criar.Text))
                    {
                        MessageBox.Show("Este ID já existe.");
                    }
                    else
                    {
                        turma.InsertTurma(textBoxIDTurma_Criar.Text, dropDownCriarTurmaSemestre.SelectedValue.ToString());
                        UpdateListGridView();
                        ResetScreenAfterSave();
                    }
                }
                catch
                {
                    MessageBox.Show("ID da área não pode ser nulo");
                }
            }
            else
            {
                try
                {
                    int index = allTurmas.FindIndex(ind => ind.TurmaID.Equals(textBoxIDTurma.Text));
                    if (index != -1)
                    {
                        turma.EditTurma(textBoxIDTurma.Text, dropDownEditarTurmaSemestre.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe, deve criar um.");
                        textBoxIDTurma.Text = "";
                        dropDownEditarTurmaSemestre.SelectedIndex = 0;
                    }
                    UpdateListGridView();
                    ResetScreenAfterSave();
                    dataGridView1_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("ID da Turma não pode ser nulo");
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDTurma_Criar.Visible = false;
            textBoxIDTurma_Criar.Visible = false;
            labelSemestreID_Criar.Visible = false;
            dropDownCriarTurmaSemestre.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDTurma.Enabled = false;
            dropDownEditarTurmaSemestre.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDTurma_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxIDTurma_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxIDTurma_Criar.Text.Length >= 1)
                    textBoxIDTurma_Criar.Text = Regex.Replace(textBoxIDTurma_Criar.Text, "[!@#$%^&*()_\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }

        #endregion
        #region Manipulação de strings na zona de editar
        private void textBoxIDTurma_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxIDTurma.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxIDTurma.Text.Length >= 1)
                    textBoxIDTurma.Text = Regex.Replace(textBoxIDTurma.Text, "[!@#$%^&*()_\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
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
