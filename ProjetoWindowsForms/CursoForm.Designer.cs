namespace Projeto
{
    #region Class do design deste Form (CursoForm)
    partial class CursoForm
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
            textBoxDescCurso = new TextBox();
            textBoxIDCurso = new TextBox();
            labelIDCurso = new Label();
            labelDescCurso = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSave = new Button();
            labelDescCurso_Criar = new Label();
            labelIDCurso_Criar = new Label();
            textBoxIDCurso_Criar = new TextBox();
            textBoxDescCurso_Criar = new TextBox();
            buttonClose = new Button();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 378F));
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
            label1.Size = new Size(100, 37);
            label1.TabIndex = 0;
            label1.Text = "Cursos";
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
            buttonRemove.Location = new Point(774, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(80, 24);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remover";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonRemove_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(685, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(83, 24);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += ButtonEditar_Click;
            // 
            // textBoxDescCurso
            // 
            textBoxDescCurso.Anchor = AnchorStyles.Left;
            textBoxDescCurso.Enabled = false;
            textBoxDescCurso.Location = new Point(378, 3);
            textBoxDescCurso.Name = "textBoxDescCurso";
            textBoxDescCurso.Size = new Size(301, 23);
            textBoxDescCurso.TabIndex = 3;
            textBoxDescCurso.TextChanged += textBoxDescCurso_TextChanged;
            // 
            // textBoxIDCurso
            // 
            textBoxIDCurso.Anchor = AnchorStyles.Left;
            textBoxIDCurso.Enabled = false;
            textBoxIDCurso.Location = new Point(121, 3);
            textBoxIDCurso.Name = "textBoxIDCurso";
            textBoxIDCurso.Size = new Size(66, 23);
            textBoxIDCurso.TabIndex = 1;
            textBoxIDCurso.TextChanged += textBoxIDCurso_TextChanged;
            // 
            // labelIDCurso
            // 
            labelIDCurso.AutoSize = true;
            labelIDCurso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCurso.Location = new Point(3, 0);
            labelIDCurso.Name = "labelIDCurso";
            labelIDCurso.Size = new Size(111, 25);
            labelIDCurso.TabIndex = 0;
            labelIDCurso.Text = "ID do Curso";
            // 
            // labelDescCurso
            // 
            labelDescCurso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescCurso.AutoSize = true;
            labelDescCurso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescCurso.Location = new Point(197, 0);
            labelDescCurso.Name = "labelDescCurso";
            labelDescCurso.Size = new Size(175, 25);
            labelDescCurso.TabIndex = 2;
            labelDescCurso.Text = "Descrição do Curso";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7689619F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.401401F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5869312F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8226357F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.409358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.824562F));
            tableLayoutPanel2.Controls.Add(labelDescCurso, 2, 0);
            tableLayoutPanel2.Controls.Add(labelIDCurso, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDCurso, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescCurso, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Location = new Point(12, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(857, 30);
            tableLayoutPanel2.TabIndex = 11;
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
            // labelDescCurso_Criar
            // 
            labelDescCurso_Criar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescCurso_Criar.AutoSize = true;
            labelDescCurso_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescCurso_Criar.Location = new Point(313, 134);
            labelDescCurso_Criar.Name = "labelDescCurso_Criar";
            labelDescCurso_Criar.Size = new Size(175, 25);
            labelDescCurso_Criar.TabIndex = 9;
            labelDescCurso_Criar.Text = "Descrição do Curso";
            labelDescCurso_Criar.Visible = false;
            // 
            // labelIDCurso_Criar
            // 
            labelIDCurso_Criar.AutoSize = true;
            labelIDCurso_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCurso_Criar.Location = new Point(123, 132);
            labelIDCurso_Criar.Name = "labelIDCurso_Criar";
            labelIDCurso_Criar.Size = new Size(111, 25);
            labelIDCurso_Criar.TabIndex = 7;
            labelIDCurso_Criar.Text = "ID do Curso";
            labelIDCurso_Criar.Visible = false;
            // 
            // textBoxIDCurso_Criar
            // 
            textBoxIDCurso_Criar.Anchor = AnchorStyles.Left;
            textBoxIDCurso_Criar.Location = new Point(239, 136);
            textBoxIDCurso_Criar.Name = "textBoxIDCurso_Criar";
            textBoxIDCurso_Criar.Size = new Size(66, 23);
            textBoxIDCurso_Criar.TabIndex = 8;
            textBoxIDCurso_Criar.Visible = false;
            textBoxIDCurso_Criar.TextChanged += textBoxIDCurso_Criar_TextChanged;
            // 
            // textBoxDescCurso_Criar
            // 
            textBoxDescCurso_Criar.Anchor = AnchorStyles.Left;
            textBoxDescCurso_Criar.Location = new Point(493, 136);
            textBoxDescCurso_Criar.Name = "textBoxDescCurso_Criar";
            textBoxDescCurso_Criar.Size = new Size(287, 23);
            textBoxDescCurso_Criar.TabIndex = 10;
            textBoxDescCurso_Criar.Visible = false;
            textBoxDescCurso_Criar.TextChanged += textBoxDescCurso_Criar_TextChanged;
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
            // CursoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(buttonClose);
            Controls.Add(labelDescCurso_Criar);
            Controls.Add(labelIDCurso_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDCurso_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(textBoxDescCurso_Criar);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "CursoForm";
            Text = "Cursos";
            Load += CursoForm_Load;
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
        private TextBox textBoxDescCurso;
        private TextBox textBoxIDCurso;
        private Label labelIDCurso;
        private Label labelDescCurso;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelDescCurso_Criar;
        private Label labelIDCurso_Criar;
        private TextBox textBoxIDCurso_Criar;
        private TextBox textBoxDescCurso_Criar;
        private Button buttonClose;
        private Button buttonExcel;
        #endregion
    }
    #endregion
}