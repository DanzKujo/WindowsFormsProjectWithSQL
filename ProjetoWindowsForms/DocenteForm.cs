using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Projeto
{
    public partial class DocenteForm : Form
    {
        private BindingSource _dataSource;       
        public DocenteForm() //Primeira função a ser corrida
        {
            InitializeComponent();
            UpdateListGridView();
            PopulateDropdownEditAreaCientifica();
            PopulateDropdownEditCategoria();
            PopulateDropdownEditHoras();
        }

        private void UpdateListGridView() //Faz update á lista da gridview
        {
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> allDocentes = docente.GetDocentes();
            SortableBindingList<ClassDocente> sortableBindingList = new SortableBindingList<ClassDocente>(allDocentes);            
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista dos docentes todos á datasource 
            dataGridView1.DataSource = _dataSource; //adiciona a datasource á gridview
            dataGridView1.Refresh();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
        private void PopulateDropdownEditAreaCientifica() //Preenche a lista da dropdown 
        {
            ClassAreaCientifica areacientifica = new ClassAreaCientifica();
            List<ClassAreaCientifica> allareascientificas = areacientifica.GetAreasCientificas();
            SortableBindingList<ClassAreaCientifica> sortableBindingList = new SortableBindingList<ClassAreaCientifica>(allareascientificas);
            dropDownEditarDocente_ID_Area_cientifica.ValueMember = "AreaCientificaID";
            dropDownEditarDocente_ID_Area_cientifica.DisplayMember = "AreaCientificaIDandDesc_AreaCientifica";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das areas cientificas todas á datasource 
            dropDownEditarDocente_ID_Area_cientifica.DataSource = _dataSource; //adiciona a datasource á dropdown
            dropDownEditarDocente_ID_Area_cientifica.Refresh();
        }
        private void PopulateDropdownEditCategoria()  //Preenche a lista da dropdown
        {
            ClassCategoria categoria = new ClassCategoria();
            List<ClassCategoria> allcategoria = categoria.GetCategorias();
            SortableBindingList<ClassCategoria> sortableBindingList = new SortableBindingList<ClassCategoria>(allcategoria);
            dropDownEditarDocente_ID_Categoria.ValueMember = "CategoriaID";
            dropDownEditarDocente_ID_Categoria.DisplayMember = "CategoriaIDAndDesc_Categoria";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das categorias todas á datasource 
            dropDownEditarDocente_ID_Categoria.DataSource = _dataSource; //adiciona a datasource á dropdown
            dropDownEditarDocente_ID_Categoria.Refresh();
        }
        private void PopulateDropdownEditHoras() //Preenche a lista da dropdown
        {
            ClassHorasAulas horas = new ClassHorasAulas();
            List<ClassHorasAulas> allhoras = horas.GetHorasAulas();
            SortableBindingList<ClassHorasAulas> sortableBindingList = new SortableBindingList<ClassHorasAulas>(allhoras);
            dropDownEditarDocente_ID_Horas.ValueMember = "HorasID";
            dropDownEditarDocente_ID_Horas.DisplayMember = "HorasIDandH_Aulas";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList; //Adiciona a lista das horas_aulas todas á datasource 
            dropDownEditarDocente_ID_Horas.DataSource = _dataSource; //adiciona a datasource á dropdown
            dropDownEditarDocente_ID_Horas.Refresh();
        }
        private void PopulateDropdownCriarAreaCientifica()
        {
            ClassAreaCientifica areacientifica = new ClassAreaCientifica();
            List<ClassAreaCientifica> allareascientificas = areacientifica.GetAreasCientificas();
            SortableBindingList<ClassAreaCientifica> sortableBindingList = new SortableBindingList<ClassAreaCientifica>(allareascientificas);
            dropDownID_Area_Cientifica_Criar.ValueMember = "AreaCientificaID";
            dropDownID_Area_Cientifica_Criar.DisplayMember = "AreaCientificaIDandDesc_AreaCientifica";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownID_Area_Cientifica_Criar.DataSource = _dataSource;
            dropDownID_Area_Cientifica_Criar.Refresh();
        }
        private void PopulateDropdownCriarCategoria()
        {
            ClassCategoria categoria = new ClassCategoria();
            List<ClassCategoria> allcategoria = categoria.GetCategorias();
            SortableBindingList<ClassCategoria> sortableBindingList = new SortableBindingList<ClassCategoria>(allcategoria);
            dropDownIDCategoria_Criar.ValueMember = "CategoriaID";
            dropDownIDCategoria_Criar.DisplayMember = "CategoriaIDAndDesc_Categoria";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownIDCategoria_Criar.DataSource = _dataSource;
            dropDownIDCategoria_Criar.Refresh();
        }
        private void PopulateDropdownCriarHoras()
        {
            ClassHorasAulas horas = new ClassHorasAulas();
            List<ClassHorasAulas> allhoras = horas.GetHorasAulas();
            SortableBindingList<ClassHorasAulas> sortableBindingList = new SortableBindingList<ClassHorasAulas>(allhoras);
            dropDownIDHoras_Criar.ValueMember = "HorasID";
            dropDownIDHoras_Criar.DisplayMember = "HorasIDandH_Aulas";
            _dataSource = new BindingSource();
            _dataSource.DataSource = sortableBindingList;
            dropDownIDHoras_Criar.DataSource = _dataSource;
            dropDownIDHoras_Criar.Refresh();
        }
        private bool ContainsSpecialChars(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }
        private bool ContainsSpecialCharsForEmail(string value) //Verifica se tem os characteres especificos (especiais) na string
        {
            var list = new[] { "~", "`", "!", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(value.Contains);
        }

        private void ResetScreenAfterSave()  //Update ao ecrã depois de ser feita uma alteração(save/guardar)
        {
            textBoxNomeDocente_Criar.Visible = false;
            textBoxIDDocente.Enabled = false;
            textBoxNomeDocente.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxc_mais_3.Enabled = false;
            textBoxCarreira.Enabled = false;
            dropDownEditarDocente_ID_Area_cientifica.Enabled = false;
            dropDownEditarDocente_ID_Categoria.Enabled = false;
            dropDownEditarDocente_ID_Horas.Enabled = false;
            labelIDDocente_Criar.Visible = false;
            textBoxIDDocente_Criar.Visible = false;
            labelNomeDocente_Criar.Visible = false;
            textBoxNomeDocente_Criar.Visible = false;
            labelEmail_Criar.Visible = false;
            textBoxEmail_Criar.Visible = false;
            labelC_mais_3_Criar.Visible = false;
            textBoxC_mais_3_Criar.Visible = false;
            labelCarreira_Criar.Visible = false;
            textBoxCarreira_Criar.Visible = false;
            labelID_AreaCientifica_Criar.Visible = false;
            dropDownID_Area_Cientifica_Criar.Visible = false;
            labelIDCategoria_Criar.Visible = false;
            dropDownIDCategoria_Criar.Visible = false;
            labelIDHoras_Criar.Visible = false;
            dropDownIDHoras_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
        }

        private void DocenteForm_Load(object sender, EventArgs e)  //Load do form "DocenteForm" depois da função DocenteForm() acabar
        {
            dataGridView1.Columns["id_docente"].Width = 80;
            dataGridView1.Columns["id_docente"].HeaderText = "Docente ID";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["fk_id_horas"].HeaderText = "Horas ID";
            dataGridView1.Columns["fk_id_categoria"].HeaderText = "Categoria ID";
            dataGridView1.Columns["fk_id_a_cientifica"].HeaderText = "Area Cientifica ID";
            dataGridView1.Columns["CarreiraString"].HeaderText = "Carreira";
            dataGridView1.Columns["c_mais_3String"].HeaderText = "C_mais_3";
            dataGridView1.Columns.Remove("carreira");
            dataGridView1.Columns.Remove("c_mais_3");
            dataGridView1.Columns.Remove("id_docenteAndNome");
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1_CellClick(null, null); //cell click para atualizar os valores nas textboxes/dropdowns 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //cell click quando se clica na gridview "puxar" os valores para as textboxes/dropdowns
        {
            var selectedDocente = dataGridView1.SelectedRows[0].DataBoundItem as ClassDocente;
            textBoxIDDocente.Text = selectedDocente.id_docente.ToString();
            textBoxNomeDocente.Text = selectedDocente.Nome;
            textBoxEmail.Text = selectedDocente.Email;
            textBoxc_mais_3.Text = selectedDocente.c_mais_3String;
            textBoxCarreira.Text = selectedDocente.CarreiraString;
            dropDownEditarDocente_ID_Area_cientifica.SelectedValue = selectedDocente.fk_id_a_cientifica;
            dropDownEditarDocente_ID_Categoria.SelectedValue = selectedDocente.fk_id_categoria;
            dropDownEditarDocente_ID_Horas.SelectedValue = selectedDocente.fk_id_horas;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            textBoxIDDocente_Criar.Text = "";
            textBoxNomeDocente_Criar.Text = "";
            labelIDDocente_Criar.Visible = true;
            textBoxIDDocente_Criar.Visible = true;
            labelNomeDocente_Criar.Visible = true;
            textBoxNomeDocente_Criar.Visible = true;
            labelEmail_Criar.Visible = true;
            textBoxEmail_Criar.Visible = true;
            labelC_mais_3_Criar.Visible = true;
            textBoxC_mais_3_Criar.Visible = true;
            labelCarreira_Criar.Visible = true;
            textBoxCarreira_Criar.Visible = true;
            labelID_AreaCientifica_Criar.Visible = true;
            dropDownID_Area_Cientifica_Criar.Visible = true;
            labelIDCategoria_Criar.Visible = true;
            dropDownIDCategoria_Criar.Visible = true;
            labelIDHoras_Criar.Visible = true;
            dropDownIDHoras_Criar.Visible = true;
            buttonSave.Visible = true;
            buttonEditar.Enabled = false;
            buttonRemove.Enabled = false;
            buttonCriar.Visible = false;
            buttonClose.Visible = true;
            textBoxIDDocente.Enabled = false;
            textBoxNomeDocente.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxc_mais_3.Enabled = false;
            textBoxCarreira.Enabled = false;
            dropDownEditarDocente_ID_Area_cientifica.Enabled = false;
            dropDownEditarDocente_ID_Categoria.Enabled = false;
            dropDownEditarDocente_ID_Horas.Enabled = false;
            PopulateDropdownCriarAreaCientifica();
            PopulateDropdownCriarCategoria();
            PopulateDropdownCriarHoras();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            textBoxIDDocente.Enabled = true;
            textBoxNomeDocente.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxc_mais_3.Enabled = true;
            textBoxCarreira.Enabled = true;
            dropDownEditarDocente_ID_Area_cientifica.Enabled = true;
            dropDownEditarDocente_ID_Categoria.Enabled = true;
            dropDownEditarDocente_ID_Horas.Enabled = true;
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
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> alldocentes = docente.GetDocentes();
            int listcount = alldocentes.Count();
            DialogResult dialogResult = MessageBox.Show("Quer remover este docente?", "Remover docente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Confirma que quer remover este docente? ESTA AÇÂO NÂO PODE SER REVERTIDA!", "Remover docente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    try
            {
                if (Convert.ToInt32(textBoxIDDocente.Text) != 0 || Convert.ToInt32(textBoxIDDocente.Text) > 0)
                {
                    int index = alldocentes.FindIndex(ind => ind.id_docente.Equals(Convert.ToInt32(textBoxIDDocente.Text)));
                    if (index != -1)
                    {
                        docente.RemoveDocente(Convert.ToInt32(textBoxIDDocente.Text));
                        UpdateListGridView();
                        dataGridView1_CellClick(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("The input string '' was not in a correct format."))
                {
                    MessageBox.Show("Tem que selecionar um docente");
                }
                else
                {
                    MessageBox.Show("Não é possivel apagar devido a este docente estar associado a outras tabelas.");
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
            ClassDocente docente = new ClassDocente();
            List<ClassDocente> alldocentes = docente.GetDocentes();
            ClassUtils classutils = new ClassUtils();
            int c_mais_3_criar = 0;
            int carreira_criar = 0;
            int c_mais_3_editar = 0;
            int carreira_editar = 0;

            if (textBoxIDDocente_Criar.Visible == true)
            {
                if (textBoxC_mais_3_Criar.Text == "Sim" | textBoxC_mais_3_Criar.Text == "Não" && textBoxCarreira_Criar.Text == "Sim" | textBoxCarreira_Criar.Text == "Não")
                {
                    if (classutils.IsValidEmail(textBoxEmail_Criar.Text) == true)
                    {
                        try
                        {
                            if (alldocentes.Any(x => x.id_docente == Int32.Parse(textBoxIDDocente_Criar.Text)))
                            {
                                MessageBox.Show("Este ID já existe.");
                            }
                            else
                            {
                                if (textBoxC_mais_3_Criar.Text == "Sim")
                                    c_mais_3_criar = 1;
                                if (textBoxCarreira_Criar.Text == "Sim")
                                    carreira_criar = 1;
                                docente.InsertDocente(Convert.ToInt32(textBoxIDDocente_Criar.Text), textBoxNomeDocente_Criar.Text, textBoxEmail_Criar.Text, Convert.ToInt32(dropDownIDHoras_Criar.SelectedValue), Convert.ToInt32(dropDownIDCategoria_Criar.SelectedValue), Convert.ToInt32(dropDownID_Area_Cientifica_Criar.SelectedValue), c_mais_3_criar, carreira_criar);
                                UpdateListGridView();
                                ResetScreenAfterSave();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("ID do docente não pode ser nulo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("C_mais_3 e Carreira só aceitam: Sim ou Não");
                }
            }
            else
            {
                if (textBoxc_mais_3.Text == "Sim" || textBoxc_mais_3.Text == "Não" && textBoxCarreira.Text == "Sim" || textBoxCarreira.Text == "Não")
                {
                    if (classutils.IsValidEmail(textBoxEmail.Text) == true)
                    {
                        try
                        {
                            int index = alldocentes.FindIndex(ind => ind.id_docente.Equals(Int32.Parse(textBoxIDDocente.Text)));
                            if (index != -1)
                            {
                                if (textBoxc_mais_3.Text == "Sim")
                                    c_mais_3_editar = 1;
                                if (textBoxCarreira.Text == "Sim")
                                    carreira_editar = 1;
                                docente.EditDocente(Convert.ToInt32(textBoxIDDocente.Text), textBoxNomeDocente.Text, textBoxEmail.Text, Convert.ToInt32(dropDownEditarDocente_ID_Horas.SelectedValue), Convert.ToInt32(dropDownEditarDocente_ID_Categoria.SelectedValue), Convert.ToInt32(dropDownEditarDocente_ID_Area_cientifica.SelectedValue), c_mais_3_editar, carreira_editar);
                            }
                            else
                            {
                                MessageBox.Show("Este ID não existe, deve criar um.");
                                textBoxIDDocente.Text = "";
                                textBoxNomeDocente.Text = "";
                                textBoxEmail.Text = "";
                                textBoxc_mais_3.Text = "";
                                textBoxCarreira.Text = "";
                                dropDownEditarDocente_ID_Horas.SelectedIndex = 0;
                                dropDownEditarDocente_ID_Categoria.SelectedIndex = 0;
                                dropDownEditarDocente_ID_Area_cientifica.SelectedIndex = 0;
                            }
                            UpdateListGridView();
                            ResetScreenAfterSave();
                            dataGridView1_CellClick(null, null);
                        }
                        catch
                        {
                            MessageBox.Show("ID do docente não pode ser nulo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("C_mais_3 e Carreira só aceitam: Sim ou Não");
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            labelIDDocente_Criar.Visible = false;
            textBoxIDDocente_Criar.Visible = false;
            labelNomeDocente_Criar.Visible = false;
            textBoxNomeDocente_Criar.Visible = false;
            labelEmail_Criar.Visible = false;
            textBoxEmail_Criar.Visible = false;
            labelC_mais_3_Criar.Visible = false;
            textBoxC_mais_3_Criar.Visible = false;
            labelCarreira_Criar.Visible = false;
            textBoxCarreira_Criar.Visible = false;
            labelID_AreaCientifica_Criar.Visible = false;
            dropDownID_Area_Cientifica_Criar.Visible = false;
            labelIDCategoria_Criar.Visible = false;
            dropDownIDCategoria_Criar.Visible = false;
            labelIDHoras_Criar.Visible = false;
            dropDownIDHoras_Criar.Visible = false;
            buttonSave.Visible = false;
            buttonEditar.Enabled = true;
            buttonRemove.Enabled = true;
            textBoxIDDocente.Enabled = false;
            textBoxNomeDocente.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxc_mais_3.Enabled = false;
            textBoxCarreira.Enabled = false;
            dropDownEditarDocente_ID_Area_cientifica.Enabled = false;
            dropDownEditarDocente_ID_Categoria.Enabled = false;
            dropDownEditarDocente_ID_Horas.Enabled = false;
            buttonCriar.Visible = true;
            buttonClose.Visible = false;
            dataGridView1.Enabled = true;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1_CellClick(null, null);
        }

        #region Manipulação de strings na zona de criar
        private void textBoxIDDocente_Criar_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDDocente_Criar.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDDocente_Criar.Text.Length >= 1)
                    textBoxIDDocente_Criar.Text = Regex.Replace(textBoxIDDocente_Criar.Text, "[^0-9]", "");
            }
        }
        private void textBoxNomeDocente_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxNomeDocente_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxNomeDocente_Criar.Text.Length >= 1)
                    textBoxNomeDocente_Criar.Text = Regex.Replace(textBoxNomeDocente_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxEmail_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialCharsForEmail(textBoxEmail_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxEmail_Criar.Text.Length >= 1)
                    textBoxEmail_Criar.Text = Regex.Replace(textBoxEmail_Criar.Text, " \b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,}\b", "");
            }
        }

        private void textBoxC_mais_3_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxC_mais_3_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxC_mais_3_Criar.Text.Length >= 1)
                    textBoxC_mais_3_Criar.Text = Regex.Replace(textBoxC_mais_3_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxCarreira_Criar_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxCarreira_Criar.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxCarreira_Criar.Text.Length >= 1)
                    textBoxCarreira_Criar.Text = Regex.Replace(textBoxCarreira_Criar.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        #endregion

        #region Manipulação de strings na zona de editar
        private void textBoxIDDocente_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxIDDocente.Text.All(char.IsDigit))
            {
                MessageBox.Show("Obrigatório introduzir um número");
                if (textBoxIDDocente.Text.Length >= 1)
                    textBoxIDDocente.Text = Regex.Replace(textBoxIDDocente.Text, "[^0-9]", "");
            }
        }

        private void textBoxNomeDocente_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxNomeDocente.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxNomeDocente.Text.Length >= 1)
                    textBoxNomeDocente.Text = Regex.Replace(textBoxNomeDocente.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialCharsForEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxEmail.Text.Length >= 1)
                    textBoxEmail.Text = Regex.Replace(textBoxEmail.Text, "\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,}\b", "");
            }
        }
        private void textBoxC_mais_3_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxc_mais_3.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxc_mais_3.Text.Length >= 1)
                    textBoxc_mais_3.Text = Regex.Replace(textBoxc_mais_3.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
            }
        }
        private void textBoxCarreira_TextChanged(object sender, EventArgs e)
        {
            if (ContainsSpecialChars(textBoxCarreira.Text))
            {
                MessageBox.Show("Caracteres inválidos");
                if (textBoxCarreira.Text.Length >= 1)
                    textBoxCarreira.Text = Regex.Replace(textBoxCarreira.Text, "[!@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]", "");
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
