using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Projeto
{
    public partial class CursoForm : Form
    {
        private BindingSource _dataSource;

        public CursoForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassCurso curso = new ClassCurso();
            List<ClassCurso> allCursos = curso.GetCursos();
            SortableBindingList<ClassCurso> sortableBindingList = new SortableBindingList<ClassCurso>(allCursos);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista dos cursos todos á datasource 
            dataGridView1.DataSource = _dataSource; //adiciona a datasource ao gridview 
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private bool ContainsSpecialChars(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }
        private void ResetScreenAfterSave() //Update ao ecrã depois de ser feita uma alteração(save/guardar)
        {
            labelIDCurso_Criar.Visible = false;
            textBoxIDCurso_Criar.Visible = false;
            labelDescCurso_Criar.Visible = false;
            textBoxDescCurso_Criar.Visible = false;
            textBoxIDCurso.Enabled = false;
            textBoxDescCurso.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }
        private void CursoForm_Load(object sender, EventArgs e) //Load do form "CursoForm" depois da função CursoForm() acabar
        {
            dataGridView1.Columns["CursoID"].Width = 100;
            dataGridView1.Columns["CursoID"].HeaderText = "Curso ID";
            dataGridView1.Columns["Desc_Curso"].HeaderText = "Descrição do Curso";
            dataGridView1.Columns["CursoIDAndDesc_Curso"].Visible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCurso = dataGridView1.SelectedRows[0].DataBoundItem as ClassCurso;
            textBoxIDCurso.Text = selectedCurso.CursoID.ToString();
            textBoxDescCurso.Text = selectedCurso.Desc_Curso;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDCurso_Criar.Text = "";
            textBoxDescCurso_Criar.Text = "";
            labelIDCurso_Criar.Visible = true;
            textBoxIDCurso_Criar.Visible = true;
            labelDescCurso_Criar.Visible = true;
            textBoxDescCurso_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDCurso.Enabled = false;
            textBoxDescCurso.Enabled = false;
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDCurso.Enabled = true;
            textBoxDescCurso.Enabled = true;
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
            ClassCurso curso = new ClassCurso();
            List<ClassCurso> allCursos = curso.GetCursos();
            int listcount = allCursos.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover este curso?", "Remover curso", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover este curso? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover curso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
            {
                if (Convert.ToInt32(textBoxIDCurso.Text) != 0 || Convert.ToInt32(textBoxIDCurso.Text) > 0)
                {
                    int index = allCursos.FindIndex(ind => ind.CursoID.Equals(Convert.ToInt32(textBoxIDCurso.Text)));
                    if (index != -1)
                    {
                        curso.RemoveCurso(Convert.ToInt32(textBoxIDCurso.Text));
                        UpdateListGridView();
                        dataGridView1_CellClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("The input string '' was not in a correct format."))
                {
                    MessageBox.Show("Tem que selecionar uma área");
                }
                else
                {
                    MessageBox.Show("Não é possivel apagar devido a esta area estar associada a outras tabelas.");
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
            ClassCurso curso = new ClassCurso();
            List<ClassCurso> allCursos = curso.GetCursos();

            if (textBoxIDCurso_Criar.Visible == true)
            {
                try
                {
                    if (allCursos.Any(x => x.CursoID == Convert.ToInt32(textBoxIDCurso_Criar.Text)))
                    {
                        MessageBox.Show("Este ID já existe.");
                    }
                    else
                    {
                        curso.InsertCurso(Convert.ToInt32(textBoxIDCurso_Criar.Text), textBoxDescCurso_Criar.Text);
                        UpdateListGridView();
                        ResetScreenAfterSave();
                    }
                }
                catch
                {
                    MessageBox.Show("ID do curso não pode ser nulo");
                }
            }
            else
            {
                try
                {
                    //int index = _dataSource.IndexOf(textBoxDescCurso.Text);
                    int index = allCursos.FindIndex(ind => ind.CursoID.Equals(Convert.ToInt32(textBoxIDCurso.Text)));
                    if (index != -1)
                    {
                        curso.EditCurso(Convert.ToInt32(textBoxIDCurso.Text), textBoxDescCurso.Text);
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe, deve criar um.");
                        textBoxIDCurso.Text = "";
                        textBoxDescCurso.Text = "";
                    }
                    UpdateListGridView();
                    ResetScreenAfterSave();
                    dataGridView1_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("ID do curso não pode ser nulo");
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDCurso_Criar.Visible = false;
            textBoxIDCurso_Criar.Visible = false;
            labelDescCurso_Criar.Visible = false;
            textBoxDescCurso_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDCurso.Enabled = false;
            textBoxDescCurso.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDCurso_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDCurso_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDCurso_Criar.Text.Length >= 1)
                    textBoxIDCurso_Criar.Text = Regex.Replace(textBoxIDCurso_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescCurso_Criar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescCurso_Criar.Text.Any(char.IsDigit) || ContainsSpecialChars(textBoxDescCurso_Criar.Text))
            {
                MessageBox.Show("Obrigatório introduzir letras");
                if (textBoxDescCurso_Criar.Text.Length >= 1)
                    textBoxDescCurso_Criar.Text = Regex.Replace(textBoxDescCurso_Criar.Text, "[0-9!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDCurso_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDCurso.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDCurso.Text.Length >= 1)
                    textBoxIDCurso.Text = Regex.Replace(textBoxIDCurso.Text, "[^0-9]", "");
            }
        }

        private void textBoxDescCurso_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescCurso.Text.Any(char.IsDigit) || ContainsSpecialChars(textBoxDescCurso.Text))
            {
                MessageBox.Show("Obrigatório introduzir letras");
                if (textBoxDescCurso.Text.Length >= 1)
                    textBoxDescCurso.Text = Regex.Replace(textBoxDescCurso.Text, "[0-9!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ClassUtils classUtils = new ClassUtils();
            classUtils.DataGridViewtoCSV(dataGridView1);
        }
    }
}
