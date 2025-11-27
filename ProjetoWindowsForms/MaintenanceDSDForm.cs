namespace Projeto
{
    public partial class MaintenanceDSDForm : Form
    {
        private ConsultarDSDForm _currentInstanceConsultarDSDForm = null;
        private EditarDSDForm _currentInstanceEditarDSDForm = null;
        private AreaForm _currentInstanceAreaForm = null;
        private CategoriaForm _currentInstanceCategoriaForm = null;
        private CursoForm _currentInstanceCursoForm = null;
        private DocenteForm _currentInstanceDocenteForm = null;
        private SemestreForm _currentInstanceSemestreForm = null;
        private TurmaForm _currentInstanceTurmaForm = null;
        private UnidadeCurricularForm _currentInstanceUnidadeCurricularForm = null;
        public string user;
        public int fk_id_area;

        public MaintenanceDSDForm() //Primeira função a ser corrida
        {
            InitializeComponent();
        }

        public void setUser(string user, int fk_id_area) //Set ao user com o id da area do responsavel
        {
            this.user = user;
            this.fk_id_area = fk_id_area;
        }
        private void instanceHasBeenClosed(object sender, FormClosedEventArgs e) //Permite fechar os forms todos e deixar este form(MaintenanceDSDForm) aberto
        {
            _currentInstanceConsultarDSDForm = null;
            _currentInstanceEditarDSDForm = null;
            _currentInstanceAreaForm = null;
            _currentInstanceCategoriaForm = null;
            _currentInstanceCursoForm = null;
            _currentInstanceDocenteForm = null;
            _currentInstanceSemestreForm = null;
            _currentInstanceTurmaForm = null;
            _currentInstanceUnidadeCurricularForm = null;
        }

        private void buttonConsultar_Click(object sender, EventArgs e) //Permite abrir o form ConsultarDSDForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
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

        private void buttonEditar_Click(object sender, EventArgs e) //Permite abrir o form EditarDSDForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
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

        private void buttonArea_Click(object sender, EventArgs e) //Permite abrir o form AreaForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {
            if (_currentInstanceAreaForm == null)
            {
                _currentInstanceAreaForm = new AreaForm();
                _currentInstanceAreaForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceAreaForm.Show();
            }
            _currentInstanceAreaForm.BringToFront();
        }
        
        private void buttonCategoria_Click(object sender, EventArgs e) //Permite abrir o form CategoriaForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {           
            if (_currentInstanceCategoriaForm == null)
            {
                _currentInstanceCategoriaForm = new CategoriaForm();
                _currentInstanceCategoriaForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceCategoriaForm.Show();
            }
            _currentInstanceCategoriaForm.BringToFront();
        }

        private void buttonCurso_Click(object sender, EventArgs e) //Permite abrir o form CursoForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {           
            if (_currentInstanceCursoForm == null)
            {
                _currentInstanceCursoForm = new CursoForm();
                _currentInstanceCursoForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceCursoForm.Show();
            }
            _currentInstanceCursoForm.BringToFront();
        }

        private void buttonDocente_Click(object sender, EventArgs e) //Permite abrir o form DocenteForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {           
            if (_currentInstanceDocenteForm == null)
            {
                _currentInstanceDocenteForm = new DocenteForm();
                _currentInstanceDocenteForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceDocenteForm.Show();
            }
            _currentInstanceDocenteForm.BringToFront();
        }

        private void buttonSemestre_Click(object sender, EventArgs e) //Permite abrir o form SemestreForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {            
            if (_currentInstanceSemestreForm == null)
            {
                _currentInstanceSemestreForm = new SemestreForm();
                _currentInstanceSemestreForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceSemestreForm.Show();
            }
            _currentInstanceSemestreForm.BringToFront();
        }

        private void buttonTurma_Click(object sender, EventArgs e) //Permite abrir o form TurmaForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {            
            if (_currentInstanceTurmaForm == null)
            {
                _currentInstanceTurmaForm = new TurmaForm();
                _currentInstanceTurmaForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceTurmaForm.Show();
            }
            _currentInstanceTurmaForm.BringToFront();
        }

        private void buttonUnidadeCurricular_Click(object sender, EventArgs e) //Permite abrir o form UnidadeCurricularForm com o id da area do responsavel sem fechar este form(MaintenanceDSDForm)
        {            
            if (_currentInstanceUnidadeCurricularForm == null)
            {
                _currentInstanceUnidadeCurricularForm = new UnidadeCurricularForm();
                _currentInstanceUnidadeCurricularForm.FormClosed += instanceHasBeenClosed;
                _currentInstanceUnidadeCurricularForm.Show();
            }
            _currentInstanceUnidadeCurricularForm.BringToFront();
        }
    }
}
