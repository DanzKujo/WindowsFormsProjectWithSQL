namespace Projeto
{
    #region Class do design deste Form (SemestreForm)
    partial class SemestreForm
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
            textBoxDescSemestre = new TextBox();
            textBoxIDSemestre = new TextBox();
            labelIDSemestre = new Label();
            labelDescSemestre = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSave = new Button();
            labelDescSemestre_Criar = new Label();
            labelIDSemestre_Criar = new Label();
            textBoxIDSemestre_Criar = new TextBox();
            textBoxDescSemestre_Criar = new TextBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 347F));
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
            label1.Location = new Point(365, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "Semestres";
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
            // textBoxDescSemestre
            // 
            textBoxDescSemestre.Anchor = AnchorStyles.Left;
            textBoxDescSemestre.Enabled = false;
            textBoxDescSemestre.Location = new Point(422, 3);
            textBoxDescSemestre.Name = "textBoxDescSemestre";
            textBoxDescSemestre.Size = new Size(257, 23);
            textBoxDescSemestre.TabIndex = 3;
            textBoxDescSemestre.TextChanged += textBoxDescSemestre_TextChanged;
            // 
            // textBoxIDSemestre
            // 
            textBoxIDSemestre.Anchor = AnchorStyles.Left;
            textBoxIDSemestre.Enabled = false;
            textBoxIDSemestre.Location = new Point(148, 3);
            textBoxIDSemestre.Name = "textBoxIDSemestre";
            textBoxIDSemestre.Size = new Size(55, 23);
            textBoxIDSemestre.TabIndex = 1;
            textBoxIDSemestre.TextChanged += textBoxIDSemestre_TextChanged;
            // 
            // labelIDSemestre
            // 
            labelIDSemestre.AutoSize = true;
            labelIDSemestre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDSemestre.Location = new Point(3, 0);
            labelIDSemestre.Name = "labelIDSemestre";
            labelIDSemestre.Size = new Size(139, 25);
            labelIDSemestre.TabIndex = 0;
            labelIDSemestre.Text = "ID do Semestre";
            // 
            // labelDescSemestre
            // 
            labelDescSemestre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescSemestre.AutoSize = true;
            labelDescSemestre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescSemestre.Location = new Point(213, 0);
            labelDescSemestre.Name = "labelDescSemestre";
            labelDescSemestre.Size = new Size(203, 25);
            labelDescSemestre.TabIndex = 2;
            labelDescSemestre.Text = "Descrição do Semestre";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.919487F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.117853F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8541431F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.688448F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.409358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.824562F));
            tableLayoutPanel2.Controls.Add(labelIDSemestre, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDSemestre, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescSemestre, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Controls.Add(labelDescSemestre, 2, 0);
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
            // labelDescSemestre_Criar
            // 
            labelDescSemestre_Criar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescSemestre_Criar.AutoSize = true;
            labelDescSemestre_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescSemestre_Criar.Location = new Point(334, 133);
            labelDescSemestre_Criar.Name = "labelDescSemestre_Criar";
            labelDescSemestre_Criar.Size = new Size(203, 25);
            labelDescSemestre_Criar.TabIndex = 9;
            labelDescSemestre_Criar.Text = "Descrição do Semestre";
            labelDescSemestre_Criar.Visible = false;
            // 
            // labelIDSemestre_Criar
            // 
            labelIDSemestre_Criar.AutoSize = true;
            labelIDSemestre_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDSemestre_Criar.Location = new Point(123, 132);
            labelIDSemestre_Criar.Name = "labelIDSemestre_Criar";
            labelIDSemestre_Criar.Size = new Size(139, 25);
            labelIDSemestre_Criar.TabIndex = 7;
            labelIDSemestre_Criar.Text = "ID do Semestre";
            labelIDSemestre_Criar.Visible = false;
            // 
            // textBoxIDSemestre_Criar
            // 
            textBoxIDSemestre_Criar.Anchor = AnchorStyles.Left;
            textBoxIDSemestre_Criar.Location = new Point(268, 136);
            textBoxIDSemestre_Criar.Name = "textBoxIDSemestre_Criar";
            textBoxIDSemestre_Criar.Size = new Size(60, 23);
            textBoxIDSemestre_Criar.TabIndex = 8;
            textBoxIDSemestre_Criar.Visible = false;
            textBoxIDSemestre_Criar.TextChanged += textBoxIDSemestre_Criar_TextChanged;
            // 
            // textBoxDescSemestre_Criar
            // 
            textBoxDescSemestre_Criar.Anchor = AnchorStyles.Left;
            textBoxDescSemestre_Criar.Location = new Point(543, 136);
            textBoxDescSemestre_Criar.Name = "textBoxDescSemestre_Criar";
            textBoxDescSemestre_Criar.Size = new Size(237, 23);
            textBoxDescSemestre_Criar.TabIndex = 10;
            textBoxDescSemestre_Criar.Visible = false;
            textBoxDescSemestre_Criar.TextChanged += textBoxDescSemestre_Criar_TextChanged;
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
            // SemestreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(buttonClose);
            Controls.Add(labelDescSemestre_Criar);
            Controls.Add(labelIDSemestre_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDSemestre_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(textBoxDescSemestre_Criar);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "SemestreForm";
            Text = "Semestres";
            Load += SemestreForm_Load;
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
        private TextBox textBoxDescSemestre;
        private TextBox textBoxIDSemestre;
        private Label labelIDSemestre;
        private Label labelDescSemestre;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelDescSemestre_Criar;
        private Label labelIDSemestre_Criar;
        private TextBox textBoxIDSemestre_Criar;
        private TextBox textBoxDescSemestre_Criar;
        private Button buttonClose;
        private Button buttonExcel;
        #endregion
    }
    #endregion
}