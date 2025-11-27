namespace Projeto
{
    #region Class do design deste Form (TurmaForm)
    partial class TurmaForm
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

        #region Windows Form Design Code

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
            textBoxIDTurma = new TextBox();
            labelIDTurma = new Label();
            labelSemestreID = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dropDownEditarTurmaSemestre = new ComboBox();
            buttonSave = new Button();
            labelSemestreID_Criar = new Label();
            labelIDTurma_Criar = new Label();
            textBoxIDTurma_Criar = new TextBox();
            buttonClose = new Button();
            dropDownCriarTurmaSemestre = new ComboBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 372F));
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
            label1.Location = new Point(376, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Turmas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(857, 287);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(12, 135);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(103, 23);
            buttonCriar.TabIndex = 5;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += ButtonCreate_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(775, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(79, 24);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remover";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonRemove_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(686, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(83, 24);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += ButtonEditar_Click;
            // 
            // textBoxIDTurma
            // 
            textBoxIDTurma.Anchor = AnchorStyles.Left;
            textBoxIDTurma.Enabled = false;
            textBoxIDTurma.Location = new Point(127, 3);
            textBoxIDTurma.Name = "textBoxIDTurma";
            textBoxIDTurma.Size = new Size(208, 23);
            textBoxIDTurma.TabIndex = 1;
            textBoxIDTurma.TextChanged += textBoxIDTurma_TextChanged;
            // 
            // labelIDTurma
            // 
            labelIDTurma.AutoSize = true;
            labelIDTurma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDTurma.Location = new Point(3, 0);
            labelIDTurma.Name = "labelIDTurma";
            labelIDTurma.Size = new Size(115, 25);
            labelIDTurma.TabIndex = 0;
            labelIDTurma.Text = "ID da Turma";
            // 
            // labelSemestreID
            // 
            labelSemestreID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSemestreID.AutoSize = true;
            labelSemestreID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSemestreID.Location = new Point(349, 0);
            labelSemestreID.Name = "labelSemestreID";
            labelSemestreID.Size = new Size(89, 25);
            labelSemestreID.TabIndex = 2;
            labelSemestreID.Text = "Semestre";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.4690781F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2042F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7852974F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.238039F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.409358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.824562F));
            tableLayoutPanel2.Controls.Add(labelSemestreID, 2, 0);
            tableLayoutPanel2.Controls.Add(labelIDTurma, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDTurma, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Controls.Add(dropDownEditarTurmaSemestre, 3, 0);
            tableLayoutPanel2.Location = new Point(12, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(857, 30);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // dropDownEditarTurmaSemestre
            // 
            dropDownEditarTurmaSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditarTurmaSemestre.Enabled = false;
            dropDownEditarTurmaSemestre.FormattingEnabled = true;
            dropDownEditarTurmaSemestre.Location = new Point(444, 3);
            dropDownEditarTurmaSemestre.Name = "dropDownEditarTurmaSemestre";
            dropDownEditarTurmaSemestre.Size = new Size(234, 23);
            dropDownEditarTurmaSemestre.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(786, 135);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(83, 25);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelSemestreID_Criar
            // 
            labelSemestreID_Criar.AutoSize = true;
            labelSemestreID_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSemestreID_Criar.Location = new Point(461, 133);
            labelSemestreID_Criar.Name = "labelSemestreID_Criar";
            labelSemestreID_Criar.Size = new Size(89, 25);
            labelSemestreID_Criar.TabIndex = 9;
            labelSemestreID_Criar.Text = "Semestre";
            labelSemestreID_Criar.Visible = false;
            // 
            // labelIDTurma_Criar
            // 
            labelIDTurma_Criar.AutoSize = true;
            labelIDTurma_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDTurma_Criar.Location = new Point(128, 134);
            labelIDTurma_Criar.Name = "labelIDTurma_Criar";
            labelIDTurma_Criar.Size = new Size(115, 25);
            labelIDTurma_Criar.TabIndex = 7;
            labelIDTurma_Criar.Text = "ID da Turma";
            labelIDTurma_Criar.Visible = false;
            // 
            // textBoxIDTurma_Criar
            // 
            textBoxIDTurma_Criar.Location = new Point(249, 137);
            textBoxIDTurma_Criar.Name = "textBoxIDTurma_Criar";
            textBoxIDTurma_Criar.Size = new Size(206, 23);
            textBoxIDTurma_Criar.TabIndex = 8;
            textBoxIDTurma_Criar.Visible = false;
            textBoxIDTurma_Criar.TextChanged += textBoxIDTurma_Criar_TextChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 134);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(103, 26);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Cancelar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // dropDownCriarTurmaSemestre
            // 
            dropDownCriarTurmaSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownCriarTurmaSemestre.FormattingEnabled = true;
            dropDownCriarTurmaSemestre.Location = new Point(556, 136);
            dropDownCriarTurmaSemestre.Name = "dropDownCriarTurmaSemestre";
            dropDownCriarTurmaSemestre.Size = new Size(224, 23);
            dropDownCriarTurmaSemestre.TabIndex = 14;
            dropDownCriarTurmaSemestre.Visible = false;
            // 
            // TurmaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(dropDownCriarTurmaSemestre);
            Controls.Add(buttonClose);
            Controls.Add(labelSemestreID_Criar);
            Controls.Add(labelIDTurma_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDTurma_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "TurmaForm";
            Text = "Turmas";
            Load += TurmaForm_Load;
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
        private TextBox textBoxIDTurma;
        private Label labelIDTurma;
        private Label labelSemestreID;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelSemestreID_Criar;
        private Label labelIDTurma_Criar;
        private TextBox textBoxIDTurma_Criar;
        private Button buttonClose;
        private ComboBox dropDownCriarTurmaSemestre;
        private ComboBox dropDownEditarTurmaSemestre;
        private Button buttonExcel;
        #endregion
    }
    #endregion
}