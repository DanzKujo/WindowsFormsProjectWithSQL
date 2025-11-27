using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Projeto
{
    public partial class SemestreForm : Form
    {
        private BindingSource _dataSource;

        public SemestreForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassSemestre semestre = new ClassSemestre();
            List<ClassSemestre> allSemestres = semestre.GetSemestres();
            SortableBindingList<ClassSemestre> sortableBindingList = new SortableBindingList<ClassSemestre>(allSemestres);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista dos semestres todos á datasource 
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
            labelIDSemestre_Criar.Visible = false;
            textBoxIDSemestre_Criar.Visible = false;
            labelDescSemestre_Criar.Visible = false;
            textBoxDescSemestre_Criar.Visible = false;
            textBoxIDSemestre.Enabled = false;
            textBoxDescSemestre.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }
        private void SemestreForm_Load(object sender, EventArgs e) //Load do form "SemestreForm" depois da função SemestreForm() acabar
        {
            dataGridView1.Columns["SemestreID"].Width = 100;
            dataGridView1.Columns["SemestreID"].HeaderText = "Semestre ID";
            dataGridView1.Columns["Desc_Semestre"].HeaderText = "Descrição do Semestre";
            dataGridView1.Columns["SemestreIDAndDesc_Semestre"].Visible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes
        {
            var selectedSemestre = dataGridView1.SelectedRows[0].DataBoundItem as ClassSemestre;
            textBoxIDSemestre.Text = selectedSemestre.SemestreID;
            textBoxDescSemestre.Text = selectedSemestre.Desc_Semestre;
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDSemestre_Criar.Text = "";
            textBoxDescSemestre_Criar.Text = "";
            labelIDSemestre_Criar.Visible = true;
            textBoxIDSemestre_Criar.Visible = true;
            labelDescSemestre_Criar.Visible = true;
            textBoxDescSemestre_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDSemestre.Enabled = false;
            textBoxDescSemestre.Enabled = false;
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDSemestre.Enabled = true;
            textBoxDescSemestre.Enabled = true;
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
            ClassSemestre semestre = new ClassSemestre();
            List<ClassSemestre> allSemestres = semestre.GetSemestres();
            int listcount = allSemestres.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover este semestre?", "Remover semestre", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover este semestre? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover semestre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
            {
                if (!string.IsNullOrEmpty(textBoxIDSemestre.Text))
                {
                    int index = allSemestres.FindIndex(ind => ind.SemestreID.Equals(textBoxIDSemestre.Text));
                    if (index != -1)
                    {
                        semestre.RemoveSemestre(textBoxIDSemestre.Text);
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
            ClassSemestre semestre = new ClassSemestre();
            List<ClassSemestre> allSemestres = semestre.GetSemestres();

            if (textBoxIDSemestre_Criar.Visible == true)
            {
                try
                {
                    if (allSemestres.Any(x => x.SemestreID == textBoxIDSemestre_Criar.Text))
                    {
                        MessageBox.Show("Este ID já existe.");
                    }
                    else
                    {
                        semestre.InsertSemestre(textBoxIDSemestre_Criar.Text, textBoxDescSemestre_Criar.Text);
                        UpdateListGridView();
                        ResetScreenAfterSave();
                    }
                }
                catch
                {
                    MessageBox.Show("ID do Semestre não pode ser nulo");
                }
            }
            else
            {
                try
                {
                    int index = allSemestres.FindIndex(ind => ind.SemestreID.Equals(textBoxIDSemestre.Text));
                    if (index != -1)
                    {
                        semestre.EditSemestre(textBoxIDSemestre.Text, textBoxDescSemestre.Text);
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe, deve criar um.");
                        textBoxIDSemestre.Text = "";
                        textBoxDescSemestre.Text = "";
                    }
                    UpdateListGridView();
                    ResetScreenAfterSave();
                    dataGridView1_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("ID do Semestre não pode ser nulo");
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDSemestre_Criar.Visible = false;
            textBoxIDSemestre_Criar.Visible = false;
            labelDescSemestre_Criar.Visible = false;
            textBoxDescSemestre_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDSemestre.Enabled = false;
            textBoxDescSemestre.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDSemestre_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxIDSemestre_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxIDSemestre_Criar.Text.Length >= 1)
                    textBoxIDSemestre_Criar.Text = Regex.Replace(textBoxIDSemestre_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxDescSemestre_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescSemestre_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescSemestre_Criar.Text.Length >= 1)
                    textBoxDescSemestre_Criar.Text = Regex.Replace(textBoxDescSemestre_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDSemestre_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxIDSemestre.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxIDSemestre.Text.Length >= 1)
                    textBoxIDSemestre.Text = Regex.Replace(textBoxIDSemestre.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }

        private void textBoxDescSemestre_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescSemestre.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescSemestre.Text.Length >= 1)
                    textBoxDescSemestre.Text = Regex.Replace(textBoxDescSemestre.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
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
