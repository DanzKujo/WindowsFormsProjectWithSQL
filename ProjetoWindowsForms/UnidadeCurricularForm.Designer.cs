namespace Projeto
{
    #region Class do design deste Form (UnidadeCurricularForm)
    partial class UnidadeCurricularForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Design code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonExcel = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            buttonCriar = new Button();
            buttonRemove = new Button();
            buttonEditar = new Button();
            textBoxDescUnidadeCurricular = new TextBox();
            textBoxIDUnidadeCurricular = new TextBox();
            labelIDUnidadeCurricular = new Label();
            labelDescUnidadeCurricular = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dropDownEditarUC_ID_Area = new ComboBox();
            buttonSave = new Button();
            labelDescUnidadeCurricular_Criar = new Label();
            labelIDUnidadeCurricular_Criar = new Label();
            textBoxIDUnidadeCurricular_Criar = new TextBox();
            textBoxDescUnidadeCurricular_Criar = new TextBox();
            buttonClose = new Button();
            labelID_Area = new Label();
            labelID_Curso = new Label();
            dropDownEditar_UC_ID_Curso = new ComboBox();
            labelID_Docente = new Label();
            dropDownEditar_UC_ID_Docente = new ComboBox();
            textboxEditarn_h_s = new TextBox();
            labeln_h_s = new Label();
            textBoxn_h_s_Criar = new TextBox();
            labeln_h_s_Criar = new Label();
            labelID_Docente_Criar = new Label();
            dropDownID_Docente_Criar = new ComboBox();
            labelIDCurso_Criar = new Label();
            dropDownIDCurso_Criar = new ComboBox();
            labelIDArea_Criar = new Label();
            dropDownIDArea_Criar = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.Controls.Add(buttonExcel, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(857, 74);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // buttonExcel
            // 
            buttonExcel.Anchor = AnchorStyles.Right;
            buttonExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcel.Location = new Point(726, 10);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(128, 53);
            buttonExcel.TabIndex = 2;
            buttonExcel.Text = "Export to CSV";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 18);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 0;
            label1.Text = "Unidades Curriculares";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 277);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(857, 174);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(12, 248);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(103, 23);
            buttonCriar.TabIndex = 5;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += ButtonCreate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(772, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(82, 24);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remover";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonRemove_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(690, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(76, 24);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += ButtonEditar_Click;
            // 
            // textBoxDescUnidadeCurricular
            // 
            textBoxDescUnidadeCurricular.Anchor = AnchorStyles.Left;
            textBoxDescUnidadeCurricular.Enabled = false;
            textBoxDescUnidadeCurricular.Location = new Point(346, 3);
            textBoxDescUnidadeCurricular.Name = "textBoxDescUnidadeCurricular";
            textBoxDescUnidadeCurricular.Size = new Size(338, 23);
            textBoxDescUnidadeCurricular.TabIndex = 3;
            textBoxDescUnidadeCurricular.TextChanged += textBoxDescUnidadeCurricular_TextChanged;
            // 
            // textBoxIDUnidadeCurricular
            // 
            textBoxIDUnidadeCurricular.Anchor = AnchorStyles.Left;
            textBoxIDUnidadeCurricular.Enabled = false;
            textBoxIDUnidadeCurricular.Location = new Point(101, 3);
            textBoxIDUnidadeCurricular.Name = "textBoxIDUnidadeCurricular";
            textBoxIDUnidadeCurricular.Size = new Size(76, 23);
            textBoxIDUnidadeCurricular.TabIndex = 1;
            textBoxIDUnidadeCurricular.TextChanged += textBoxIDUnidadeCurricular_TextChanged;
            // 
            // labelIDUnidadeCurricular
            // 
            labelIDUnidadeCurricular.AutoSize = true;
            labelIDUnidadeCurricular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDUnidadeCurricular.Location = new Point(3, 0);
            labelIDUnidadeCurricular.Name = "labelIDUnidadeCurricular";
            labelIDUnidadeCurricular.Size = new Size(86, 25);
            labelIDUnidadeCurricular.TabIndex = 0;
            labelIDUnidadeCurricular.Text = "ID da UC";
            // 
            // labelDescUnidadeCurricular
            // 
            labelDescUnidadeCurricular.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescUnidadeCurricular.AutoSize = true;
            labelDescUnidadeCurricular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescUnidadeCurricular.Location = new Point(190, 0);
            labelDescUnidadeCurricular.Name = "labelDescUnidadeCurricular";
            labelDescUnidadeCurricular.Size = new Size(150, 25);
            labelDescUnidadeCurricular.TabIndex = 2;
            labelDescUnidadeCurricular.Text = "Descrição da UC";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.5427961F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.700862F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.25806F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.49008F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.684948F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1516924F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(labelDescUnidadeCurricular, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDUnidadeCurricular, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescUnidadeCurricular, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(labelIDUnidadeCurricular, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(857, 30);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // dropDownEditarUC_ID_Area
            // 
            dropDownEditarUC_ID_Area.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditarUC_ID_Area.DropDownWidth = 250;
            dropDownEditarUC_ID_Area.Enabled = false;
            dropDownEditarUC_ID_Area.FormattingEnabled = true;
            dropDownEditarUC_ID_Area.Location = new Point(121, 129);
            dropDownEditarUC_ID_Area.Name = "dropDownEditarUC_ID_Area";
            dropDownEditarUC_ID_Area.Size = new Size(117, 23);
            dropDownEditarUC_ID_Area.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(786, 245);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(83, 25);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelDescUnidadeCurricular_Criar
            // 
            labelDescUnidadeCurricular_Criar.AutoSize = true;
            labelDescUnidadeCurricular_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescUnidadeCurricular_Criar.Location = new Point(205, 184);
            labelDescUnidadeCurricular_Criar.Name = "labelDescUnidadeCurricular_Criar";
            labelDescUnidadeCurricular_Criar.Size = new Size(150, 25);
            labelDescUnidadeCurricular_Criar.TabIndex = 9;
            labelDescUnidadeCurricular_Criar.Text = "Descrição da UC";
            labelDescUnidadeCurricular_Criar.Visible = false;
            // 
            // labelIDUnidadeCurricular_Criar
            // 
            labelIDUnidadeCurricular_Criar.AutoSize = true;
            labelIDUnidadeCurricular_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDUnidadeCurricular_Criar.Location = new Point(17, 183);
            labelIDUnidadeCurricular_Criar.Name = "labelIDUnidadeCurricular_Criar";
            labelIDUnidadeCurricular_Criar.Size = new Size(86, 25);
            labelIDUnidadeCurricular_Criar.TabIndex = 7;
            labelIDUnidadeCurricular_Criar.Text = "ID da UC";
            labelIDUnidadeCurricular_Criar.Visible = false;
            // 
            // textBoxIDUnidadeCurricular_Criar
            // 
            textBoxIDUnidadeCurricular_Criar.Location = new Point(109, 185);
            textBoxIDUnidadeCurricular_Criar.Name = "textBoxIDUnidadeCurricular_Criar";
            textBoxIDUnidadeCurricular_Criar.Size = new Size(90, 23);
            textBoxIDUnidadeCurricular_Criar.TabIndex = 8;
            textBoxIDUnidadeCurricular_Criar.Visible = false;
            textBoxIDUnidadeCurricular_Criar.TextChanged += textBoxIDUnidadeCurricular_Criar_TextChanged;
            // 
            // textBoxDescUnidadeCurricular_Criar
            // 
            textBoxDescUnidadeCurricular_Criar.Location = new Point(361, 185);
            textBoxDescUnidadeCurricular_Criar.Name = "textBoxDescUnidadeCurricular_Criar";
            textBoxDescUnidadeCurricular_Criar.Size = new Size(312, 23);
            textBoxDescUnidadeCurricular_Criar.TabIndex = 10;
            textBoxDescUnidadeCurricular_Criar.Visible = false;
            textBoxDescUnidadeCurricular_Criar.TextChanged += textBoxDescUnidadeCurricular_Criar_TextChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 245);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(103, 26);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Cancelar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelID_Area
            // 
            labelID_Area.AutoSize = true;
            labelID_Area.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Area.Location = new Point(15, 127);
            labelID_Area.Name = "labelID_Area";
            labelID_Area.Size = new Size(100, 25);
            labelID_Area.TabIndex = 15;
            labelID_Area.Text = "ID da Área";
            // 
            // labelID_Curso
            // 
            labelID_Curso.AutoSize = true;
            labelID_Curso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Curso.Location = new Point(244, 127);
            labelID_Curso.Name = "labelID_Curso";
            labelID_Curso.Size = new Size(111, 25);
            labelID_Curso.TabIndex = 17;
            labelID_Curso.Text = "ID do Curso";
            // 
            // dropDownEditar_UC_ID_Curso
            // 
            dropDownEditar_UC_ID_Curso.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditar_UC_ID_Curso.DropDownWidth = 250;
            dropDownEditar_UC_ID_Curso.Enabled = false;
            dropDownEditar_UC_ID_Curso.FormattingEnabled = true;
            dropDownEditar_UC_ID_Curso.Location = new Point(361, 129);
            dropDownEditar_UC_ID_Curso.Name = "dropDownEditar_UC_ID_Curso";
            dropDownEditar_UC_ID_Curso.Size = new Size(131, 23);
            dropDownEditar_UC_ID_Curso.TabIndex = 16;
            // 
            // labelID_Docente
            // 
            labelID_Docente.AutoSize = true;
            labelID_Docente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Docente.Location = new Point(498, 127);
            labelID_Docente.Name = "labelID_Docente";
            labelID_Docente.Size = new Size(132, 25);
            labelID_Docente.TabIndex = 19;
            labelID_Docente.Text = "ID do Docente";
            // 
            // dropDownEditar_UC_ID_Docente
            // 
            dropDownEditar_UC_ID_Docente.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditar_UC_ID_Docente.DropDownWidth = 250;
            dropDownEditar_UC_ID_Docente.Enabled = false;
            dropDownEditar_UC_ID_Docente.FormattingEnabled = true;
            dropDownEditar_UC_ID_Docente.Location = new Point(636, 129);
            dropDownEditar_UC_ID_Docente.Name = "dropDownEditar_UC_ID_Docente";
            dropDownEditar_UC_ID_Docente.Size = new Size(102, 23);
            dropDownEditar_UC_ID_Docente.TabIndex = 18;
            // 
            // textboxEditarn_h_s
            // 
            textboxEditarn_h_s.Enabled = false;
            textboxEditarn_h_s.Location = new Point(808, 129);
            textboxEditarn_h_s.Name = "textboxEditarn_h_s";
            textboxEditarn_h_s.Size = new Size(58, 23);
            textboxEditarn_h_s.TabIndex = 21;
            textboxEditarn_h_s.TextChanged += textboxEditarn_h_s_TextChanged;
            // 
            // labeln_h_s
            // 
            labeln_h_s.AutoSize = true;
            labeln_h_s.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeln_h_s.Location = new Point(744, 127);
            labeln_h_s.Name = "labeln_h_s";
            labeln_h_s.Size = new Size(58, 25);
            labeln_h_s.TabIndex = 20;
            labeln_h_s.Text = "n_h_s";
            // 
            // textBoxn_h_s_Criar
            // 
            textBoxn_h_s_Criar.Location = new Point(515, 212);
            textBoxn_h_s_Criar.Name = "textBoxn_h_s_Criar";
            textBoxn_h_s_Criar.Size = new Size(76, 23);
            textBoxn_h_s_Criar.TabIndex = 29;
            textBoxn_h_s_Criar.Visible = false;
            textBoxn_h_s_Criar.TextChanged += textBoxn_h_s_Criar_TextChanged;
            // 
            // labeln_h_s_Criar
            // 
            labeln_h_s_Criar.AutoSize = true;
            labeln_h_s_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeln_h_s_Criar.Location = new Point(451, 210);
            labeln_h_s_Criar.Name = "labeln_h_s_Criar";
            labeln_h_s_Criar.Size = new Size(58, 25);
            labeln_h_s_Criar.TabIndex = 28;
            labeln_h_s_Criar.Text = "n_h_s";
            labeln_h_s_Criar.Visible = false;
            // 
            // labelID_Docente_Criar
            // 
            labelID_Docente_Criar.AutoSize = true;
            labelID_Docente_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Docente_Criar.Location = new Point(223, 210);
            labelID_Docente_Criar.Name = "labelID_Docente_Criar";
            labelID_Docente_Criar.Size = new Size(132, 25);
            labelID_Docente_Criar.TabIndex = 27;
            labelID_Docente_Criar.Text = "ID do Docente";
            labelID_Docente_Criar.Visible = false;
            // 
            // dropDownID_Docente_Criar
            // 
            dropDownID_Docente_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownID_Docente_Criar.DropDownWidth = 250;
            dropDownID_Docente_Criar.FormattingEnabled = true;
            dropDownID_Docente_Criar.Location = new Point(361, 212);
            dropDownID_Docente_Criar.Name = "dropDownID_Docente_Criar";
            dropDownID_Docente_Criar.Size = new Size(84, 23);
            dropDownID_Docente_Criar.TabIndex = 26;
            dropDownID_Docente_Criar.Visible = false;
            // 
            // labelIDCurso_Criar
            // 
            labelIDCurso_Criar.AutoSize = true;
            labelIDCurso_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCurso_Criar.Location = new Point(16, 210);
            labelIDCurso_Criar.Name = "labelIDCurso_Criar";
            labelIDCurso_Criar.Size = new Size(111, 25);
            labelIDCurso_Criar.TabIndex = 25;
            labelIDCurso_Criar.Text = "ID do Curso";
            labelIDCurso_Criar.Visible = false;
            // 
            // dropDownIDCurso_Criar
            // 
            dropDownIDCurso_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownIDCurso_Criar.DropDownWidth = 250;
            dropDownIDCurso_Criar.FormattingEnabled = true;
            dropDownIDCurso_Criar.Location = new Point(133, 212);
            dropDownIDCurso_Criar.Name = "dropDownIDCurso_Criar";
            dropDownIDCurso_Criar.Size = new Size(84, 23);
            dropDownIDCurso_Criar.TabIndex = 24;
            dropDownIDCurso_Criar.Visible = false;
            // 
            // labelIDArea_Criar
            // 
            labelIDArea_Criar.AutoSize = true;
            labelIDArea_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDArea_Criar.Location = new Point(681, 183);
            labelIDArea_Criar.Name = "labelIDArea_Criar";
            labelIDArea_Criar.Size = new Size(100, 25);
            labelIDArea_Criar.TabIndex = 23;
            labelIDArea_Criar.Text = "ID da Área";
            labelIDArea_Criar.Visible = false;
            // 
            // dropDownIDArea_Criar
            // 
            dropDownIDArea_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownIDArea_Criar.DropDownWidth = 250;
            dropDownIDArea_Criar.FormattingEnabled = true;
            dropDownIDArea_Criar.Location = new Point(786, 186);
            dropDownIDArea_Criar.Name = "dropDownIDArea_Criar";
            dropDownIDArea_Criar.Size = new Size(82, 23);
            dropDownIDArea_Criar.TabIndex = 22;
            dropDownIDArea_Criar.Visible = false;
            // 
            // UnidadeCurricularForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(textBoxn_h_s_Criar);
            Controls.Add(labeln_h_s_Criar);
            Controls.Add(labelID_Docente_Criar);
            Controls.Add(dropDownID_Docente_Criar);
            Controls.Add(labelIDCurso_Criar);
            Controls.Add(dropDownIDCurso_Criar);
            Controls.Add(labelIDArea_Criar);
            Controls.Add(dropDownIDArea_Criar);
            Controls.Add(textboxEditarn_h_s);
            Controls.Add(labeln_h_s);
            Controls.Add(labelID_Docente);
            Controls.Add(dropDownEditar_UC_ID_Docente);
            Controls.Add(labelID_Curso);
            Controls.Add(dropDownEditar_UC_ID_Curso);
            Controls.Add(labelID_Area);
            Controls.Add(buttonClose);
            Controls.Add(labelDescUnidadeCurricular_Criar);
            Controls.Add(labelIDUnidadeCurricular_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDUnidadeCurricular_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dropDownEditarUC_ID_Area);
            Controls.Add(textBoxDescUnidadeCurricular_Criar);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "UnidadeCurricularForm";
            Text = "Unidades Curriculares";
            Load += UnidadeCurricularForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button buttonCriar;
        private Button buttonRemove;
        private Button buttonEditar;
        private TextBox textBoxDescUnidadeCurricular;
        private TextBox textBoxIDUnidadeCurricular;
        private Label labelIDUnidadeCurricular;
        private Label labelDescUnidadeCurricular;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelDescUnidadeCurricular_Criar;
        private Label labelIDUnidadeCurricular_Criar;
        private TextBox textBoxIDUnidadeCurricular_Criar;
        private TextBox textBoxDescUnidadeCurricular_Criar;
        private Button buttonClose;
        private ComboBox dropDownEditarUC_ID_Area;
        private Label labelID_Area;
        private Label labelID_Curso;
        private ComboBox dropDownEditar_UC_ID_Curso;
        private Label labelID_Docente;
        private ComboBox dropDownEditar_UC_ID_Docente;
        private TextBox textboxEditarn_h_s;
        private Label labeln_h_s;
        private TextBox textBoxn_h_s_Criar;
        private Label labeln_h_s_Criar;
        private Label labelID_Docente_Criar;
        private ComboBox dropDownID_Docente_Criar;
        private Label labelIDCurso_Criar;
        private ComboBox dropDownIDCurso_Criar;
        private Label labelIDArea_Criar;
        private ComboBox dropDownIDArea_Criar;
        private Button buttonExcel;
        #endregion
    }
    #endregion
}