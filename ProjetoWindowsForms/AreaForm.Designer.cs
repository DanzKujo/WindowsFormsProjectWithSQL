namespace Projeto
{
    #region Class do design deste Form (AreaForm)
    partial class AreaForm
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
            label1 = new Label();
            buttonExcel = new Button();
            dataGridView1 = new DataGridView();
            buttonCriar = new Button();
            buttonRemove = new Button();
            buttonEditar = new Button();
            textBoxDescArea = new TextBox();
            textBoxIDArea = new TextBox();
            labelIDArea = new Label();
            labelDescArea = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSave = new Button();
            labelDescArea_Criar = new Label();
            labelIDArea_Criar = new Label();
            textBoxIDArea_Criar = new TextBox();
            textBoxDescArea_Criar = new TextBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 383F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonExcel, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(857, 74);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 18);
            label1.Name = "label1";
            label1.Size = new Size(85, 37);
            label1.TabIndex = 0;
            label1.Text = "Areas";
            // 
            // buttonExcel
            // 
            buttonExcel.Anchor = AnchorStyles.Right;
            buttonExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExcel.Location = new Point(726, 10);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(128, 53);
            buttonExcel.TabIndex = 1;
            buttonExcel.Text = "Export to CSV";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
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
            // textBoxDescArea
            // 
            textBoxDescArea.Anchor = AnchorStyles.Left;
            textBoxDescArea.Enabled = false;
            textBoxDescArea.Location = new Point(363, 3);
            textBoxDescArea.Name = "textBoxDescArea";
            textBoxDescArea.Size = new Size(315, 23);
            textBoxDescArea.TabIndex = 3;
            textBoxDescArea.TextChanged += textBoxDescArea_TextChanged;
            // 
            // textBoxIDArea
            // 
            textBoxIDArea.Anchor = AnchorStyles.Left;
            textBoxIDArea.Enabled = false;
            textBoxIDArea.Location = new Point(111, 3);
            textBoxIDArea.Name = "textBoxIDArea";
            textBoxIDArea.Size = new Size(76, 23);
            textBoxIDArea.TabIndex = 1;
            textBoxIDArea.TextChanged += textBoxIDArea_TextChanged;
            // 
            // labelIDArea
            // 
            labelIDArea.AutoSize = true;
            labelIDArea.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDArea.Location = new Point(3, 0);
            labelIDArea.Name = "labelIDArea";
            labelIDArea.Size = new Size(100, 25);
            labelIDArea.TabIndex = 0;
            labelIDArea.Text = "ID da Area";
            // 
            // labelDescArea
            // 
            labelDescArea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescArea.AutoSize = true;
            labelDescArea.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescArea.Location = new Point(193, 0);
            labelDescArea.Name = "labelDescArea";
            labelDescArea.Size = new Size(164, 25);
            labelDescArea.TabIndex = 2;
            labelDescArea.Text = "Descrição da Area";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6315794F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.590643F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8830414F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.66082F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.409358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.824562F));
            tableLayoutPanel2.Controls.Add(labelDescArea, 2, 0);
            tableLayoutPanel2.Controls.Add(labelIDArea, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDArea, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxDescArea, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Location = new Point(12, 97);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
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
            // labelDescArea_Criar
            // 
            labelDescArea_Criar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDescArea_Criar.AutoSize = true;
            labelDescArea_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescArea_Criar.Location = new Point(313, 134);
            labelDescArea_Criar.Name = "labelDescArea_Criar";
            labelDescArea_Criar.Size = new Size(164, 25);
            labelDescArea_Criar.TabIndex = 9;
            labelDescArea_Criar.Text = "Descrição da Area";
            labelDescArea_Criar.Visible = false;
            // 
            // labelIDArea_Criar
            // 
            labelIDArea_Criar.AutoSize = true;
            labelIDArea_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDArea_Criar.Location = new Point(123, 132);
            labelIDArea_Criar.Name = "labelIDArea_Criar";
            labelIDArea_Criar.Size = new Size(100, 25);
            labelIDArea_Criar.TabIndex = 7;
            labelIDArea_Criar.Text = "ID da Area";
            labelIDArea_Criar.Visible = false;
            // 
            // textBoxIDArea_Criar
            // 
            textBoxIDArea_Criar.Anchor = AnchorStyles.Left;
            textBoxIDArea_Criar.Location = new Point(229, 136);
            textBoxIDArea_Criar.Name = "textBoxIDArea_Criar";
            textBoxIDArea_Criar.Size = new Size(76, 23);
            textBoxIDArea_Criar.TabIndex = 8;
            textBoxIDArea_Criar.Visible = false;
            textBoxIDArea_Criar.TextChanged += textBoxIDArea_Criar_TextChanged;
            // 
            // textBoxDescArea_Criar
            // 
            textBoxDescArea_Criar.Anchor = AnchorStyles.Left;
            textBoxDescArea_Criar.Location = new Point(481, 136);
            textBoxDescArea_Criar.Name = "textBoxDescArea_Criar";
            textBoxDescArea_Criar.Size = new Size(299, 23);
            textBoxDescArea_Criar.TabIndex = 10;
            textBoxDescArea_Criar.Visible = false;
            textBoxDescArea_Criar.TextChanged += textBoxDescArea_Criar_TextChanged;
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
            // AreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(buttonClose);
            Controls.Add(labelDescArea_Criar);
            Controls.Add(labelIDArea_Criar);
            Controls.Add(buttonSave);
            Controls.Add(textBoxIDArea_Criar);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(textBoxDescArea_Criar);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "AreaForm";
            Text = "Areas";
            Load += AreaForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Button buttonCriar;
        private Button buttonRemove;
        private Button buttonEditar;
        private TextBox textBoxDescArea;
        private TextBox textBoxIDArea;
        private Label labelIDArea;
        private Label labelDescArea;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelDescArea_Criar;
        private Label labelIDArea_Criar;
        private TextBox textBoxIDArea_Criar;
        private TextBox textBoxDescArea_Criar;
        private Button buttonClose;
        private Label label1;
        private Button buttonExcel;
        #endregion

    }
    #endregion
}