namespace Projeto
{
    #region Class do design deste Form (EditarDSDForm)
    partial class EditarDSDForm
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

        #region Windows Form Designer generated code

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
            labelID_Semestre = new Label();
            textboxID_Semestre = new TextBox();
            textboxID_Area = new TextBox();
            labelID_Area = new Label();
            textboxDesc_area = new TextBox();
            labelDesc_area = new Label();
            textboxDesc_curso = new TextBox();
            labelDesc_curso = new Label();
            textboxID_docente = new TextBox();
            labelID_docente = new Label();
            textboxID_turma = new TextBox();
            labelID_turma = new Label();
            textboxDesc_uc = new TextBox();
            labelDesc_uc = new Label();
            textboxID_uc = new TextBox();
            labelID_uc = new Label();
            textboxh_aulas_doc = new TextBox();
            labelh_aulas_doc = new Label();
            label_nome = new Label();
            dropDownNome = new ComboBox();
            buttonAlterarDocenteTurma = new Button();
            buttonAlterarHorasLecionacao = new Button();
            buttonAdicionarOutroDocenteTurma = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelAlterarDocenteTurma = new Label();
            labelAlterarHorasLecionacao = new Label();
            labelAdicionarOutroDocenteTurma = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonExcel, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(857, 74);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonExcel
            // 
            buttonExcel.Anchor = AnchorStyles.Right;
            buttonExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcel.Location = new Point(724, 9);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(128, 53);
            buttonExcel.TabIndex = 3;
            buttonExcel.Text = "Export to CSV";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 17);
            label1.Name = "label1";
            label1.Size = new Size(319, 37);
            label1.TabIndex = 0;
            label1.Text = "Editar DSD";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 92);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(347, 350);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // labelID_Semestre
            // 
            labelID_Semestre.AutoSize = true;
            labelID_Semestre.Location = new Point(73, 104);
            labelID_Semestre.Name = "labelID_Semestre";
            labelID_Semestre.Size = new Size(55, 15);
            labelID_Semestre.TabIndex = 12;
            labelID_Semestre.Text = "Semestre";
            // 
            // textboxID_Semestre
            // 
            textboxID_Semestre.Enabled = false;
            textboxID_Semestre.Location = new Point(141, 101);
            textboxID_Semestre.Name = "textboxID_Semestre";
            textboxID_Semestre.Size = new Size(343, 23);
            textboxID_Semestre.TabIndex = 13;
            // 
            // textboxID_Area
            // 
            textboxID_Area.Enabled = false;
            textboxID_Area.Location = new Point(141, 130);
            textboxID_Area.Name = "textboxID_Area";
            textboxID_Area.Size = new Size(343, 23);
            textboxID_Area.TabIndex = 15;
            // 
            // labelID_Area
            // 
            labelID_Area.AutoSize = true;
            labelID_Area.Location = new Point(73, 133);
            labelID_Area.Name = "labelID_Area";
            labelID_Area.Size = new Size(61, 15);
            labelID_Area.TabIndex = 14;
            labelID_Area.Text = "ID da Área";
            // 
            // textboxDesc_area
            // 
            textboxDesc_area.Enabled = false;
            textboxDesc_area.Location = new Point(141, 159);
            textboxDesc_area.Name = "textboxDesc_area";
            textboxDesc_area.Size = new Size(343, 23);
            textboxDesc_area.TabIndex = 17;
            // 
            // labelDesc_area
            // 
            labelDesc_area.AutoSize = true;
            labelDesc_area.Location = new Point(33, 162);
            labelDesc_area.Name = "labelDesc_area";
            labelDesc_area.Size = new Size(101, 15);
            labelDesc_area.TabIndex = 16;
            labelDesc_area.Text = "Descrição da Área";
            // 
            // textboxDesc_curso
            // 
            textboxDesc_curso.Enabled = false;
            textboxDesc_curso.Location = new Point(141, 188);
            textboxDesc_curso.Name = "textboxDesc_curso";
            textboxDesc_curso.Size = new Size(343, 23);
            textboxDesc_curso.TabIndex = 19;
            // 
            // labelDesc_curso
            // 
            labelDesc_curso.AutoSize = true;
            labelDesc_curso.Location = new Point(25, 191);
            labelDesc_curso.Name = "labelDesc_curso";
            labelDesc_curso.Size = new Size(109, 15);
            labelDesc_curso.TabIndex = 18;
            labelDesc_curso.Text = "Descrição do Curso";
            // 
            // textboxID_docente
            // 
            textboxID_docente.Enabled = false;
            textboxID_docente.Location = new Point(141, 304);
            textboxID_docente.Name = "textboxID_docente";
            textboxID_docente.Size = new Size(343, 23);
            textboxID_docente.TabIndex = 27;
            // 
            // labelID_docente
            // 
            labelID_docente.AutoSize = true;
            labelID_docente.Location = new Point(52, 307);
            labelID_docente.Name = "labelID_docente";
            labelID_docente.Size = new Size(82, 15);
            labelID_docente.TabIndex = 26;
            labelID_docente.Text = "ID do Docente";
            // 
            // textboxID_turma
            // 
            textboxID_turma.Enabled = false;
            textboxID_turma.Location = new Point(141, 275);
            textboxID_turma.Name = "textboxID_turma";
            textboxID_turma.Size = new Size(343, 23);
            textboxID_turma.TabIndex = 25;
            // 
            // labelID_turma
            // 
            labelID_turma.AutoSize = true;
            labelID_turma.Location = new Point(63, 278);
            labelID_turma.Name = "labelID_turma";
            labelID_turma.Size = new Size(71, 15);
            labelID_turma.TabIndex = 24;
            labelID_turma.Text = "ID da Turma";
            // 
            // textboxDesc_uc
            // 
            textboxDesc_uc.Enabled = false;
            textboxDesc_uc.Location = new Point(141, 246);
            textboxDesc_uc.Name = "textboxDesc_uc";
            textboxDesc_uc.Size = new Size(343, 23);
            textboxDesc_uc.TabIndex = 23;
            // 
            // labelDesc_uc
            // 
            labelDesc_uc.AutoSize = true;
            labelDesc_uc.Location = new Point(41, 249);
            labelDesc_uc.Name = "labelDesc_uc";
            labelDesc_uc.Size = new Size(93, 15);
            labelDesc_uc.TabIndex = 22;
            labelDesc_uc.Text = "Descrição da UC";
            // 
            // textboxID_uc
            // 
            textboxID_uc.Enabled = false;
            textboxID_uc.Location = new Point(141, 217);
            textboxID_uc.Name = "textboxID_uc";
            textboxID_uc.Size = new Size(343, 23);
            textboxID_uc.TabIndex = 21;
            // 
            // labelID_uc
            // 
            labelID_uc.AutoSize = true;
            labelID_uc.Location = new Point(81, 220);
            labelID_uc.Name = "labelID_uc";
            labelID_uc.Size = new Size(53, 15);
            labelID_uc.TabIndex = 20;
            labelID_uc.Text = "ID da UC";
            // 
            // textboxh_aulas_doc
            // 
            textboxh_aulas_doc.Enabled = false;
            textboxh_aulas_doc.Location = new Point(141, 362);
            textboxh_aulas_doc.Name = "textboxh_aulas_doc";
            textboxh_aulas_doc.Size = new Size(343, 23);
            textboxh_aulas_doc.TabIndex = 31;
            textboxh_aulas_doc.TextChanged += textboxh_aulas_doc_TextChanged;
            // 
            // labelh_aulas_doc
            // 
            labelh_aulas_doc.AutoSize = true;
            labelh_aulas_doc.Location = new Point(62, 365);
            labelh_aulas_doc.Name = "labelh_aulas_doc";
            labelh_aulas_doc.Size = new Size(73, 15);
            labelh_aulas_doc.TabIndex = 30;
            labelh_aulas_doc.Text = "H_aulas_doc";
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Location = new Point(94, 336);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(40, 15);
            label_nome.TabIndex = 28;
            label_nome.Text = "Nome";
            // 
            // dropDownNome
            // 
            dropDownNome.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownNome.DropDownWidth = 250;
            dropDownNome.Enabled = false;
            dropDownNome.FormattingEnabled = true;
            dropDownNome.Location = new Point(141, 333);
            dropDownNome.Name = "dropDownNome";
            dropDownNome.Size = new Size(343, 23);
            dropDownNome.TabIndex = 32;
            // 
            // buttonAlterarDocenteTurma
            // 
            buttonAlterarDocenteTurma.Location = new Point(57, 402);
            buttonAlterarDocenteTurma.Name = "buttonAlterarDocenteTurma";
            buttonAlterarDocenteTurma.Size = new Size(108, 40);
            buttonAlterarDocenteTurma.TabIndex = 33;
            buttonAlterarDocenteTurma.Text = "Alterar Docente da Turma";
            buttonAlterarDocenteTurma.UseVisualStyleBackColor = true;
            buttonAlterarDocenteTurma.Click += buttonAlterarDocenteTurma_Click;
            // 
            // buttonAlterarHorasLecionacao
            // 
            buttonAlterarHorasLecionacao.Location = new Point(171, 402);
            buttonAlterarHorasLecionacao.Name = "buttonAlterarHorasLecionacao";
            buttonAlterarHorasLecionacao.Size = new Size(146, 40);
            buttonAlterarHorasLecionacao.TabIndex = 34;
            buttonAlterarHorasLecionacao.Text = "Alterar horas lecionação do Docente";
            buttonAlterarHorasLecionacao.UseVisualStyleBackColor = true;
            buttonAlterarHorasLecionacao.Click += buttonAlterarHorasLecionacao_Click;
            // 
            // buttonAdicionarOutroDocenteTurma
            // 
            buttonAdicionarOutroDocenteTurma.Location = new Point(323, 402);
            buttonAdicionarOutroDocenteTurma.Name = "buttonAdicionarOutroDocenteTurma";
            buttonAdicionarOutroDocenteTurma.Size = new Size(108, 40);
            buttonAdicionarOutroDocenteTurma.TabIndex = 35;
            buttonAdicionarOutroDocenteTurma.Text = "Adicionar outro Docente à Turma";
            buttonAdicionarOutroDocenteTurma.UseVisualStyleBackColor = true;
            buttonAdicionarOutroDocenteTurma.Click += buttonAdicionarOutroDocenteTurma_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(437, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(76, 40);
            buttonSave.TabIndex = 36;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(12, 402);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(76, 40);
            buttonCancel.TabIndex = 37;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelAlterarDocenteTurma
            // 
            labelAlterarDocenteTurma.AutoSize = true;
            labelAlterarDocenteTurma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlterarDocenteTurma.Location = new Point(157, 407);
            labelAlterarDocenteTurma.Name = "labelAlterarDocenteTurma";
            labelAlterarDocenteTurma.Size = new Size(229, 25);
            labelAlterarDocenteTurma.TabIndex = 38;
            labelAlterarDocenteTurma.Text = "Alterar Docente da Turma";
            labelAlterarDocenteTurma.Visible = false;
            // 
            // labelAlterarHorasLecionacao
            // 
            labelAlterarHorasLecionacao.AutoSize = true;
            labelAlterarHorasLecionacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAlterarHorasLecionacao.Location = new Point(112, 407);
            labelAlterarHorasLecionacao.Name = "labelAlterarHorasLecionacao";
            labelAlterarHorasLecionacao.Size = new Size(319, 25);
            labelAlterarHorasLecionacao.TabIndex = 39;
            labelAlterarHorasLecionacao.Text = "Alterar horas lecionação do Docente";
            labelAlterarHorasLecionacao.Visible = false;
            // 
            // labelAdicionarOutroDocenteTurma
            // 
            labelAdicionarOutroDocenteTurma.AutoSize = true;
            labelAdicionarOutroDocenteTurma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAdicionarOutroDocenteTurma.Location = new Point(121, 407);
            labelAdicionarOutroDocenteTurma.Name = "labelAdicionarOutroDocenteTurma";
            labelAdicionarOutroDocenteTurma.Size = new Size(293, 25);
            labelAdicionarOutroDocenteTurma.TabIndex = 40;
            labelAdicionarOutroDocenteTurma.Text = "Adicionar outro Docente à Turma";
            labelAdicionarOutroDocenteTurma.Visible = false;
            // 
            // EditarDSDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdicionarOutroDocenteTurma);
            Controls.Add(buttonAlterarHorasLecionacao);
            Controls.Add(buttonAlterarDocenteTurma);
            Controls.Add(dropDownNome);
            Controls.Add(textboxh_aulas_doc);
            Controls.Add(labelh_aulas_doc);
            Controls.Add(label_nome);
            Controls.Add(textboxID_docente);
            Controls.Add(labelID_docente);
            Controls.Add(textboxID_turma);
            Controls.Add(labelID_turma);
            Controls.Add(textboxDesc_uc);
            Controls.Add(labelDesc_uc);
            Controls.Add(textboxID_uc);
            Controls.Add(labelID_uc);
            Controls.Add(textboxDesc_curso);
            Controls.Add(labelDesc_curso);
            Controls.Add(textboxDesc_area);
            Controls.Add(labelDesc_area);
            Controls.Add(textboxID_Area);
            Controls.Add(labelID_Area);
            Controls.Add(textboxID_Semestre);
            Controls.Add(labelID_Semestre);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCancel);
            Controls.Add(labelAlterarDocenteTurma);
            Controls.Add(labelAlterarHorasLecionacao);
            Controls.Add(labelAdicionarOutroDocenteTurma);
            Name = "EditarDSDForm";
            Text = "EditarDSD";
            Load += EditarDSDForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label labelID_Semestre;
        private TextBox textboxID_Semestre;
        private TextBox textboxID_Area;
        private Label labelID_Area;
        private TextBox textboxDesc_area;
        private Label labelDesc_area;
        private TextBox textboxDesc_curso;
        private Label labelDesc_curso;
        private TextBox textboxID_docente;
        private Label labelID_docente;
        private TextBox textboxID_turma;
        private Label labelID_turma;
        private TextBox textboxDesc_uc;
        private Label labelDesc_uc;
        private TextBox textboxID_uc;
        private Label labelID_uc;
        private TextBox textboxh_aulas_doc;
        private Label labelh_aulas_doc;
        private Label label_nome;
        private ComboBox dropDownNome;
        private Button buttonExcel;
        private Label label1;
        private Button buttonAlterarDocenteTurma;
        private Button buttonAlterarHorasLecionacao;
        private Button buttonAdicionarOutroDocenteTurma;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelAlterarDocenteTurma;
        private Label labelAlterarHorasLecionacao;
        private Label labelAdicionarOutroDocenteTurma;
        #endregion
    }
    #endregion
}