using System.ComponentModel;
using System.Text.RegularExpressions;
namespace Projeto
{
    public partial class AreaForm : Form
    {
        private BindingSource _dataSource;
        public AreaForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
        }
        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassArea area = new ClassArea();
            List<ClassArea> allAreas = area.GetAreas();
            SortableBindingList<ClassArea> sortableBindingList = new SortableBindingList<ClassArea>(allAreas);
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das areas todas á datasource 
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
            labelIDArea_Criar.Visible = false;
            textBoxIDArea_Criar.Visible = false;
            labelDescArea_Criar.Visible = false;
            textBoxDescArea_Criar.Visible = false;
            textBoxIDArea.Enabled = false;
            textBoxDescArea.Enabled = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;           
        }
        private void AreaForm_Load(object sender, EventArgs e) //Load do form "AreaForm" depois da função AreaForm() acabar
        {
            dataGridView1.Columns["AreaID"].Width = 90;
            dataGridView1.Columns["AreaID"].HeaderText = "Área ID";
            dataGridView1.Columns["Desc_Area"].HeaderText = "Descrição da Área";
            dataGridView1.Columns["AreaIDandDesc_Area"].Visible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes
        {
            var selectedArea = dataGridView1.SelectedRows[0].DataBoundItem as ClassArea;
            textBoxIDArea.Text = selectedArea.AreaID.ToString();
            textBoxDescArea.Text = selectedArea.Desc_Area;
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDArea_Criar.Text = "";
            textBoxDescArea_Criar.Text = "";
            labelIDArea_Criar.Visible = true;
            textBoxIDArea_Criar.Visible = true;
            labelDescArea_Criar.Visible = true;
            textBoxDescArea_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDArea.Enabled = false;
            textBoxDescArea.Enabled = false;
        }
        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            //textBoxIDArea.Enabled = true;
            textBoxDescArea.Enabled = true;
            buttonSave.Visible = true;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.ForeColor  = Color.Gray;
        }
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            ClassArea area = new ClassArea();
            List<ClassArea> allAreas = area.GetAreas();
            int listcount = allAreas.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover esta área?", "Remover área", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover esta área? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover área", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                { 
                    try
                    {
                        if (Convert.ToInt32(textBoxIDArea.Text) != 0 || Convert.ToInt32(textBoxIDArea.Text) > 0)
                        {
                            int index = allAreas.FindIndex(ind => ind.AreaID.Equals(Convert.ToInt32(textBoxIDArea.Text)));
                            if (index != -1)
                            {
                                area.RemoveArea(Convert.ToInt32(textBoxIDArea.Text));
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
            ClassArea area = new ClassArea();
            List<ClassArea> allAreas = area.GetAreas();
            if (textBoxIDArea_Criar.Visible == true)
            {
                DialogResult dialogResult = MessageBox.Show("Confirma que quer criar esta área?", "Criar área", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (allAreas.Any(x => x.AreaID == Int32.Parse(textBoxIDArea_Criar.Text)))
                        {
                            MessageBox.Show("Este ID já existe.");
                        }
                        else
                        {
                            area.InsertArea(Convert.ToInt32(textBoxIDArea_Criar.Text), textBoxDescArea_Criar.Text);                            
                            UpdateListGridView();
                            ResetScreenAfterSave();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ID da área não pode ser nulo");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Confirma que quer editar esta área?", "Editar área", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int index = allAreas.FindIndex(ind => ind.AreaID.Equals(Int32.Parse(textBoxIDArea.Text)));
                        if (index != -1)
                        {                           
                            area.EditArea(Convert.ToInt32(textBoxIDArea.Text), textBoxDescArea.Text);                               
                        }
                        else
                        {
                            MessageBox.Show("Este ID não existe, deve criar um.");
                            textBoxIDArea.Text = "";
                            textBoxDescArea.Text = "";
                        }
                        UpdateListGridView();
                        ResetScreenAfterSave();
                        dataGridView1_CellClick(null, null);
                    }
                    catch
                    {
                        MessageBox.Show("ID da área não pode ser nulo");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDArea_Criar.Visible = false;
            textBoxIDArea_Criar.Visible = false;
            labelDescArea_Criar.Visible = false;
            textBoxDescArea_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDArea.Enabled = false;
            textBoxDescArea.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDArea_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDArea_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDArea_Criar.Text.Length >= 1)
                    textBoxIDArea_Criar.Text = Regex.Replace(textBoxIDArea_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescArea_Criar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescArea_Criar.Text.Any(char.IsDigit) || ContainsSpecialChars(textBoxDescArea_Criar.Text))
            {
                MessageBox.Show("Obrigatório introduzir letras");
                if (textBoxDescArea_Criar.Text.Length >= 1)
                    textBoxDescArea_Criar.Text = Regex.Replace(textBoxDescArea_Criar.Text, "[0-9!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDArea_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDArea.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDArea.Text.Length >= 1)
                    textBoxIDArea_Criar.Text = Regex.Replace(textBoxIDArea_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxDescArea_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescArea.Text.Any(char.IsDigit) || ContainsSpecialChars(textBoxDescArea.Text))
            {
                MessageBox.Show("Obrigatório introduzir letras");
                if (textBoxDescArea.Text.Length >= 1)
                    textBoxDescArea.Text = Regex.Replace(textBoxDescArea.Text, "[0-9!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
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