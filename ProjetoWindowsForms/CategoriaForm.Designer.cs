namespace Projeto
{
    #region Class do design deste Form (CategoriaForm)
    partial class CategoriaForm
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
            textBoxDescCategoria = new TextBox();
            textBoxIDCategoria = new TextBox();
            labelIDCategoria = new Label();
            labelDescCategoria = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSave = new Button();
            labelDescCategoria_Criar = new Label();
            labelIDCategoria_Criar = new Label();
            textBoxIDCategoria_Criar = new TextBox();
            textBoxDescCategoria_Criar = new TextBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 346F));
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
            label1.Location = new Point(361, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
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
            // textBoxDescCategoria
            // 
            textBoxDescCategoria.Anchor = AnchorStyles.Left;
            textBoxDescCategoria.Enabled = false;
            textBoxDescCategoria.Location = new Point(436, 3);
            textBoxDescCategoria.Name = "textBoxDescCategoria";
            textBoxDescCategoria.Size = new Size(244, 23);
            textBoxDescCategoria.TabIndex = 3;
            textBoxDescCategoria.TextChanged += textBoxDescCategoria_TextChanged;
            // 
            // textBoxIDCategoria
            // 
            textBoxIDCategoria.Anchor = AnchorStyles.Left;
            textBoxIDCategoria.Enabled = false;
            textBoxIDCategoria.Location = new Point(152, 3);
            textBoxIDCategoria.Name = "textBoxIDCategoria";
            textBoxIDCategoria.Size = new Size(63, 23);
            textBoxIDCategoria.TabIndex = 1;
            textBoxIDCategoria.TextChanged += textBoxIDCategoria_TextChanged;
            // 
            // labelIDCategoria
            // 
            labelIDCategoria.AutoSize = true;
            labelIDCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCategoria.Location = new Point(3, 0);
            labelIDCategoria.Name = "labelIDCategoria";
            labelIDCategoria.Size = new Size(143, 25);
            labelIDCategoria.TabIndex = 0;
            labelIDCategoria.Text = "ID da Categoria";
            // 
            // labelDescCategoria
            // 
            labelDescCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescCategoria.AutoSize = true;
            labelDescCategoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescCategoria.Location = new Point(223, 0);
            labelDescCategoria.Name = "labelDescCategoria";
            labelDescCategoria.Size = new Size(207, 25);
            labelDescCategoria.TabIndex = 2;
            labelDescCategoria.Text = "Descrição da Categoria";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.38623F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.051342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0875149F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1715279F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.409358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.824562F));
            tableLayoutPanel2.Controls.Add(labelDescCategoria, 2, 0);
            tableLayoutPanel2.Controls.Add(labelIDCategoria, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDCategoria, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescCategoria, 3, 0);
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
            buttonSave.Location = new Point(790, 136);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(79, 25);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelDescCategoria_Criar
            // 
            labelDescCategoria_Criar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescCategoria_Criar.AutoSize = true;
            labelDescCategoria_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescCategoria_Criar.Location = new Point(334, 133);
            labelDescCategoria_Criar.Name = "labelDescCategoria_Criar";
            labelDescCategoria_Criar.Size = new Size(207, 25);
            labelDescCategoria_Criar.TabIndex = 9;
            labelDescCategoria_Criar.Text = "Descrição da Categoria";
            labelDescCategoria_Criar.Visible = false;
            // 
            // labelIDCategoria_Criar
            // 
            labelIDCategoria_Criar.AutoSize = true;
            labelIDCategoria_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCategoria_Criar.Location = new Point(121, 132);
            labelIDCategoria_Criar.Name = "labelIDCategoria_Criar";
            labelIDCategoria_Criar.Size = new Size(143, 25);
            labelIDCategoria_Criar.TabIndex = 7;
            labelIDCategoria_Criar.Text = "ID da Categoria";
            labelIDCategoria_Criar.Visible = false;
            // 
            // textBoxIDCategoria_Criar
            // 
            textBoxIDCategoria_Criar.Anchor = AnchorStyles.Left;
            textBoxIDCategoria_Criar.Location = new Point(266, 135);
            textBoxIDCategoria_Criar.Name = "textBoxIDCategoria_Criar";
            textBoxIDCategoria_Criar.Size = new Size(62, 23);
            textBoxIDCategoria_Criar.TabIndex = 8;
            textBoxIDCategoria_Criar.Visible = false;
            textBoxIDCategoria_Criar.TextChanged += textBoxIDCategoria_Criar_TextChanged;
            // 
            // textBoxDescCategoria_Criar
            // 
            textBoxDescCategoria_Criar.Anchor = AnchorStyles.Left;
            textBoxDescCategoria_Criar.Location = new Point(547, 136);
            textBoxDescCategoria_Criar.Name = "textBoxDescCategoria_Criar";
            textBoxDescCategoria_Criar.Size = new Size(233, 23);
            textBoxDescCategoria_Criar.TabIndex = 10;
            textBoxDescCategoria_Criar.Visible = false;
            textBoxDescCategoria_Criar.TextChanged += textBoxDescCategoria_Criar_TextChanged;
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
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(buttonClose);
            Controls.Add(labelDescCategoria_Criar);
            Controls.Add(labelIDCategoria_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDCategoria_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(textBoxDescCategoria_Criar);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "CategoriaForm";
            Text = "Categorias";
            Load += CategoriaForm_Load;
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
        private TextBox textBoxDescCategoria;
        private TextBox textBoxIDCategoria;
        private Label labelIDCategoria;
        private Label labelDescCategoria;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelDescCategoria_Criar;
        private Label labelIDCategoria_Criar;
        private TextBox textBoxIDCategoria_Criar;
        private TextBox textBoxDescCategoria_Criar;
        private Button buttonClose;
        private Button buttonExcel;
        #endregion
    }
    #endregion
}