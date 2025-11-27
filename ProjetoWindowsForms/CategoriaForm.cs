using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Projeto
{
    public partial class CategoriaForm : Form
    {
        private BindingSource _dataSource;
        public CategoriaForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassCategoria categoria = new ClassCategoria();
            List<ClassCategoria> allCategorias = categoria.GetCategorias();
            SortableBindingList<ClassCategoria> sortableBindingList = new SortableBindingList<ClassCategoria>(allCategorias);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das categorias todas á datasource 
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
            labelIDCategoria_Criar.Visible = false;
            textBoxIDCategoria_Criar.Visible = false;
            labelDescCategoria_Criar.Visible = false;
            textBoxDescCategoria_Criar.Visible = false;
            textBoxIDCategoria.Enabled = false;
            textBoxDescCategoria.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }
        private void CategoriaForm_Load(object sender, EventArgs e) //Load do form "CategoriaForm" depois da função CategoriaForm() acabar
        {
            dataGridView1.Columns["CategoriaID"].Width = 100;
            dataGridView1.Columns["CategoriaID"].HeaderText = "Categoria ID";
            dataGridView1.Columns["Desc_Categoria"].HeaderText = "Descrição da Categoria";
            dataGridView1.Columns["CategoriaIDAndDesc_Categoria"].Visible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes
        {
            var selectedCategoria = dataGridView1.SelectedRows[0].DataBoundItem as ClassCategoria;
            textBoxIDCategoria.Text = selectedCategoria.CategoriaID.ToString();
            textBoxDescCategoria.Text = selectedCategoria.Desc_Categoria;
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDCategoria_Criar.Text = "";
            textBoxDescCategoria_Criar.Text = "";
            labelIDCategoria_Criar.Visible = true;
            textBoxIDCategoria_Criar.Visible = true;
            labelDescCategoria_Criar.Visible = true;
            textBoxDescCategoria_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDCategoria.Enabled = false;
            textBoxDescCategoria.Enabled = false;
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDCategoria.Enabled = true;
            textBoxDescCategoria.Enabled = true;
            buttonSave.Visible = true;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            dataGridView1.ForeColor = Color.Gray;
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            ClassCategoria categoria = new ClassCategoria();
            List<ClassCategoria> allCategoria = categoria.GetCategorias();
            int listcount = allCategoria.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover esta categoria?", "Remover categoria", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover esta categoria? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
            {
                if (Convert.ToInt32(textBoxIDCategoria.Text) != 0 || Convert.ToInt32(textBoxIDCategoria.Text) > 0)
                {
                    int index = allCategoria.FindIndex(ind => ind.CategoriaID.Equals(Convert.ToInt32(textBoxIDCategoria.Text)));
                    if (index != -1)
                    {
                        categoria.RemoveCategoria(Convert.ToInt32(textBoxIDCategoria.Text));
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
            ClassCategoria categoria = new ClassCategoria();
            List<ClassCategoria> allCategoria = categoria.GetCategorias();

            if (textBoxIDCategoria_Criar.Visible == true)
            {
                try
                {
                    if (allCategoria.Any(x => x.CategoriaID == Int32.Parse(textBoxIDCategoria_Criar.Text)))
                    {
                        MessageBox.Show("Este ID já existe.");
                    }
                    else
                    {
                        categoria.InsertCategoria(Convert.ToInt32(textBoxIDCategoria_Criar.Text), textBoxDescCategoria_Criar.Text);
                        UpdateListGridView();
                        ResetScreenAfterSave();
                    }
                }
                catch
                {
                    MessageBox.Show("ID da categoria não pode ser nulo");
                }
            }
            else
            {
                try
                {
                    int index = allCategoria.FindIndex(ind => ind.CategoriaID.Equals(Int32.Parse(textBoxIDCategoria.Text)));
                    if (index != -1)
                    {
                        categoria.EditCategoria(Convert.ToInt32(textBoxIDCategoria.Text), textBoxDescCategoria.Text);
                    }
                    else
                    {
                        MessageBox.Show("Este ID não existe, deve criar um.");
                        textBoxIDCategoria.Text = "";
                        textBoxDescCategoria.Text = "";
                    }
                    UpdateListGridView();
                    ResetScreenAfterSave();
                    dataGridView1_CellClick(null, null);
                }
                catch
                {
                    MessageBox.Show("ID da categoria não pode ser nulo");
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDCategoria_Criar.Visible = false;
            textBoxIDCategoria_Criar.Visible = false;
            labelDescCategoria_Criar.Visible = false;
            textBoxDescCategoria_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDCategoria.Enabled = false;
            textBoxDescCategoria.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDCategoria_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDCategoria_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDCategoria_Criar.Text.Length >= 1)
                    textBoxIDCategoria_Criar.Text = Regex.Replace(textBoxIDCategoria_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescCategoria_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescCategoria_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescCategoria_Criar.Text.Length >= 1)
                    textBoxDescCategoria_Criar.Text = Regex.Replace(textBoxDescCategoria_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDCategoria_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDCategoria.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDCategoria.Text.Length >= 1)
                    textBoxIDCategoria.Text = Regex.Replace(textBoxIDCategoria.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescCategoria_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxDescCategoria.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxDescCategoria.Text.Length >= 1)
                    textBoxDescCategoria.Text = Regex.Replace(textBoxDescCategoria.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
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
