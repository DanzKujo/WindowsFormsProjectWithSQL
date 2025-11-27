namespace Projeto
{
    public partial class DSDForm : Form
    {
        private ConsultarDSDForm _currentInstanceConsultarDSDForm = null;
        private EditarDSDForm _currentInstanceEditarDSDForm = null;
        public string user;
        public int fk_id_area;
        public DSDForm() //Primeira função a ser corrida
        {
            InitializeComponent();
        }

        public void setUser(string user, int fk_id_area) //Set ao user com o id da area do responsavel
        {
            this.user = user;
            this.fk_id_area = fk_id_area;
        }

        private void instanceHasBeenClosed(object sender, FormClosedEventArgs e) //Permite fechar o form EditarDSDForm e ConsultarDSDForm e deixar este form(DSDForm) aberto
        {
            _currentInstanceConsultarDSDForm = null;
            _currentInstanceEditarDSDForm = null;
        }

        private void ButtonConsulta_Click(object sender, EventArgs e) //Permite abrir o form ConsultarDSDForm com o id da area do responsavel sem fechar este form(DSDForm)
        {
            if (_currentInstanceConsultarDSDForm == null)
            {
                _currentInstanceConsultarDSDForm = new ConsultarDSDForm();
                _currentInstanceConsultarDSDForm.setFk_id_area(this.fk_id_area);
                _currentInstanceConsultarDSDForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceConsultarDSDForm.Show();
            }
            _currentInstanceConsultarDSDForm.BringToFront();
        }

        private void ButtonEditar_Click(object sender, EventArgs e) //Permite abrir o form EditarDSDForm com o id da area do responsavel sem fechar este form(DSDForm)
        {
            if (_currentInstanceEditarDSDForm == null)
            {
                _currentInstanceEditarDSDForm = new EditarDSDForm();
                _currentInstanceEditarDSDForm.setFk_id_area(this.fk_id_area);
                _currentInstanceEditarDSDForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceEditarDSDForm.Show();
            }
            _currentInstanceEditarDSDForm.BringToFront();
        }

    }
}
