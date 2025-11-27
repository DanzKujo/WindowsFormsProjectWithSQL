namespace Projeto
{
    #region Class do design deste Form (DocenteForm)
    partial class DocenteForm
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
            textBoxNomeDocente = new TextBox();
            textBoxIDDocente = new TextBox();
            labelIDDocente = new Label();
            labelNomeDocente = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonSave = new Button();
            labelc_mais_3 = new Label();
            buttonClose = new Button();
            labelID_Horas = new Label();
            dropDownEditarDocente_ID_Horas = new ComboBox();
            labelID_Categoria = new Label();
            dropDownEditarDocente_ID_Categoria = new ComboBox();
            labelID_AreaCientifica = new Label();
            dropDownEditarDocente_ID_Area_cientifica = new ComboBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxc_mais_3 = new TextBox();
            labelCarreira = new Label();
            textBoxCarreira = new TextBox();
            labelIDDocente_Criar = new Label();
            textBoxIDDocente_Criar = new TextBox();
            textBoxNomeDocente_Criar = new TextBox();
            labelNomeDocente_Criar = new Label();
            labelCarreira_Criar = new Label();
            textBoxCarreira_Criar = new TextBox();
            textBoxC_mais_3_Criar = new TextBox();
            labelEmail_Criar = new Label();
            textBoxEmail_Criar = new TextBox();
            labelIDHoras_Criar = new Label();
            dropDownIDHoras_Criar = new ComboBox();
            labelIDCategoria_Criar = new Label();
            dropDownIDCategoria_Criar = new ComboBox();
            labelID_AreaCientifica_Criar = new Label();
            dropDownID_Area_Cientifica_Criar = new ComboBox();
            labelC_mais_3_Criar = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 357F));
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
            label1.Location = new Point(364, 17);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "Docentes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 349);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(857, 102);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(12, 318);
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
            // textBoxNomeDocente
            // 
            textBoxNomeDocente.Anchor = AnchorStyles.Left;
            textBoxNomeDocente.Enabled = false;
            textBoxNomeDocente.Location = new Point(292, 3);
            textBoxNomeDocente.Name = "textBoxNomeDocente";
            textBoxNomeDocente.Size = new Size(387, 23);
            textBoxNomeDocente.TabIndex = 3;
            textBoxNomeDocente.TextChanged += textBoxNomeDocente_TextChanged;
            // 
            // textBoxIDDocente
            // 
            textBoxIDDocente.Anchor = AnchorStyles.Left;
            textBoxIDDocente.Enabled = false;
            textBoxIDDocente.Location = new Point(143, 3);
            textBoxIDDocente.Name = "textBoxIDDocente";
            textBoxIDDocente.Size = new Size(72, 23);
            textBoxIDDocente.TabIndex = 1;
            textBoxIDDocente.TextChanged += textBoxIDDocente_TextChanged;
            // 
            // labelIDDocente
            // 
            labelIDDocente.AutoSize = true;
            labelIDDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDDocente.Location = new Point(3, 0);
            labelIDDocente.Name = "labelIDDocente";
            labelIDDocente.Size = new Size(82, 25);
            labelIDDocente.TabIndex = 0;
            labelIDDocente.Text = "Docente";
            // 
            // labelNomeDocente
            // 
            labelNomeDocente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNomeDocente.AutoSize = true;
            labelNomeDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomeDocente.Location = new Point(223, 0);
            labelNomeDocente.Name = "labelNomeDocente";
            labelNomeDocente.Size = new Size(63, 25);
            labelNomeDocente.TabIndex = 2;
            labelNomeDocente.Text = "Nome";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3665257F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.118491F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.284714F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8576431F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.428771F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.842884F));
            tableLayoutPanel2.Controls.Add(labelIDDocente, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxIDDocente, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxNomeDocente, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonEditar, 4, 0);
            tableLayoutPanel2.Controls.Add(buttonRemove, 5, 0);
            tableLayoutPanel2.Controls.Add(labelNomeDocente, 2, 0);
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
            buttonSave.Location = new Point(786, 318);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(83, 25);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelc_mais_3
            // 
            labelc_mais_3.AutoSize = true;
            labelc_mais_3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelc_mais_3.Location = new Point(391, 131);
            labelc_mais_3.Name = "labelc_mais_3";
            labelc_mais_3.Size = new Size(89, 25);
            labelc_mais_3.TabIndex = 9;
            labelc_mais_3.Text = "C_mais_3";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 317);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(103, 26);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Cancelar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelID_Horas
            // 
            labelID_Horas.AutoSize = true;
            labelID_Horas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Horas.Location = new Point(677, 165);
            labelID_Horas.Name = "labelID_Horas";
            labelID_Horas.Size = new Size(61, 25);
            labelID_Horas.TabIndex = 27;
            labelID_Horas.Text = "Horas";
            // 
            // dropDownEditarDocente_ID_Horas
            // 
            dropDownEditarDocente_ID_Horas.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditarDocente_ID_Horas.DropDownWidth = 250;
            dropDownEditarDocente_ID_Horas.Enabled = false;
            dropDownEditarDocente_ID_Horas.FormattingEnabled = true;
            dropDownEditarDocente_ID_Horas.Location = new Point(764, 167);
            dropDownEditarDocente_ID_Horas.Name = "dropDownEditarDocente_ID_Horas";
            dropDownEditarDocente_ID_Horas.Size = new Size(102, 23);
            dropDownEditarDocente_ID_Horas.TabIndex = 26;
            // 
            // labelID_Categoria
            // 
            labelID_Categoria.AutoSize = true;
            labelID_Categoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_Categoria.Location = new Point(391, 165);
            labelID_Categoria.Name = "labelID_Categoria";
            labelID_Categoria.Size = new Size(94, 25);
            labelID_Categoria.TabIndex = 25;
            labelID_Categoria.Text = "Categoria";
            // 
            // dropDownEditarDocente_ID_Categoria
            // 
            dropDownEditarDocente_ID_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditarDocente_ID_Categoria.DropDownWidth = 250;
            dropDownEditarDocente_ID_Categoria.Enabled = false;
            dropDownEditarDocente_ID_Categoria.FormattingEnabled = true;
            dropDownEditarDocente_ID_Categoria.Location = new Point(540, 167);
            dropDownEditarDocente_ID_Categoria.Name = "dropDownEditarDocente_ID_Categoria";
            dropDownEditarDocente_ID_Categoria.Size = new Size(131, 23);
            dropDownEditarDocente_ID_Categoria.TabIndex = 24;
            // 
            // labelID_AreaCientifica
            // 
            labelID_AreaCientifica.AutoSize = true;
            labelID_AreaCientifica.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_AreaCientifica.Location = new Point(16, 165);
            labelID_AreaCientifica.Name = "labelID_AreaCientifica";
            labelID_AreaCientifica.Size = new Size(135, 25);
            labelID_AreaCientifica.TabIndex = 23;
            labelID_AreaCientifica.Text = "Área Cientifica";
            // 
            // dropDownEditarDocente_ID_Area_cientifica
            // 
            dropDownEditarDocente_ID_Area_cientifica.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownEditarDocente_ID_Area_cientifica.DropDownWidth = 250;
            dropDownEditarDocente_ID_Area_cientifica.Enabled = false;
            dropDownEditarDocente_ID_Area_cientifica.FormattingEnabled = true;
            dropDownEditarDocente_ID_Area_cientifica.Location = new Point(206, 167);
            dropDownEditarDocente_ID_Area_cientifica.Name = "dropDownEditarDocente_ID_Area_cientifica";
            dropDownEditarDocente_ID_Area_cientifica.Size = new Size(179, 23);
            dropDownEditarDocente_ID_Area_cientifica.TabIndex = 22;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(14, 131);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(58, 25);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Enabled = false;
            textBoxEmail.Location = new Point(78, 132);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(307, 23);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxc_mais_3
            // 
            textBoxc_mais_3.Enabled = false;
            textBoxc_mais_3.Location = new Point(483, 133);
            textBoxc_mais_3.Name = "textBoxc_mais_3";
            textBoxc_mais_3.Size = new Size(116, 23);
            textBoxc_mais_3.TabIndex = 29;
            textBoxc_mais_3.TextChanged += textBoxC_mais_3_TextChanged;
            // 
            // labelCarreira
            // 
            labelCarreira.AutoSize = true;
            labelCarreira.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCarreira.Location = new Point(605, 131);
            labelCarreira.Name = "labelCarreira";
            labelCarreira.Size = new Size(80, 25);
            labelCarreira.TabIndex = 30;
            labelCarreira.Text = "Carreira";
            // 
            // textBoxCarreira
            // 
            textBoxCarreira.Enabled = false;
            textBoxCarreira.Location = new Point(691, 133);
            textBoxCarreira.Name = "textBoxCarreira";
            textBoxCarreira.Size = new Size(110, 23);
            textBoxCarreira.TabIndex = 31;
            textBoxCarreira.TextChanged += textBoxCarreira_TextChanged;
            // 
            // labelIDDocente_Criar
            // 
            labelIDDocente_Criar.AutoSize = true;
            labelIDDocente_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDDocente_Criar.Location = new Point(15, 210);
            labelIDDocente_Criar.Name = "labelIDDocente_Criar";
            labelIDDocente_Criar.Size = new Size(82, 25);
            labelIDDocente_Criar.TabIndex = 32;
            labelIDDocente_Criar.Text = "Docente";
            labelIDDocente_Criar.Visible = false;
            // 
            // textBoxIDDocente_Criar
            // 
            textBoxIDDocente_Criar.Location = new Point(155, 213);
            textBoxIDDocente_Criar.Name = "textBoxIDDocente_Criar";
            textBoxIDDocente_Criar.Size = new Size(72, 23);
            textBoxIDDocente_Criar.TabIndex = 33;
            textBoxIDDocente_Criar.Visible = false;
            textBoxIDDocente_Criar.TextChanged += textBoxIDDocente_Criar_TextChanged;
            // 
            // textBoxNomeDocente_Criar
            // 
            textBoxNomeDocente_Criar.Location = new Point(304, 213);
            textBoxNomeDocente_Criar.Name = "textBoxNomeDocente_Criar";
            textBoxNomeDocente_Criar.Size = new Size(387, 23);
            textBoxNomeDocente_Criar.TabIndex = 35;
            textBoxNomeDocente_Criar.Visible = false;
            textBoxNomeDocente_Criar.TextChanged += textBoxNomeDocente_Criar_TextChanged;
            // 
            // labelNomeDocente_Criar
            // 
            labelNomeDocente_Criar.AutoSize = true;
            labelNomeDocente_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomeDocente_Criar.Location = new Point(235, 210);
            labelNomeDocente_Criar.Name = "labelNomeDocente_Criar";
            labelNomeDocente_Criar.Size = new Size(63, 25);
            labelNomeDocente_Criar.TabIndex = 34;
            labelNomeDocente_Criar.Text = "Nome";
            labelNomeDocente_Criar.Visible = false;
            // 
            // labelCarreira_Criar
            // 
            labelCarreira_Criar.AutoSize = true;
            labelCarreira_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCarreira_Criar.Location = new Point(605, 246);
            labelCarreira_Criar.Name = "labelCarreira_Criar";
            labelCarreira_Criar.Size = new Size(80, 25);
            labelCarreira_Criar.TabIndex = 46;
            labelCarreira_Criar.Text = "Carreira";
            labelCarreira_Criar.Visible = false;
            // 
            // textBoxCarreira_Criar
            // 
            textBoxCarreira_Criar.Location = new Point(691, 248);
            textBoxCarreira_Criar.Name = "textBoxCarreira_Criar";
            textBoxCarreira_Criar.Size = new Size(110, 23);
            textBoxCarreira_Criar.TabIndex = 47;
            textBoxCarreira_Criar.Visible = false;
            textBoxCarreira_Criar.TextChanged += textBoxCarreira_Criar_TextChanged;
            // 
            // textBoxC_mais_3_Criar
            // 
            textBoxC_mais_3_Criar.Location = new Point(483, 248);
            textBoxC_mais_3_Criar.Name = "textBoxC_mais_3_Criar";
            textBoxC_mais_3_Criar.Size = new Size(116, 23);
            textBoxC_mais_3_Criar.TabIndex = 45;
            textBoxC_mais_3_Criar.Visible = false;
            textBoxC_mais_3_Criar.TextChanged += textBoxC_mais_3_Criar_TextChanged;
            // 
            // labelEmail_Criar
            // 
            labelEmail_Criar.AutoSize = true;
            labelEmail_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail_Criar.Location = new Point(14, 246);
            labelEmail_Criar.Name = "labelEmail_Criar";
            labelEmail_Criar.Size = new Size(58, 25);
            labelEmail_Criar.TabIndex = 36;
            labelEmail_Criar.Text = "Email";
            labelEmail_Criar.Visible = false;
            // 
            // textBoxEmail_Criar
            // 
            textBoxEmail_Criar.Location = new Point(78, 247);
            textBoxEmail_Criar.Name = "textBoxEmail_Criar";
            textBoxEmail_Criar.Size = new Size(307, 23);
            textBoxEmail_Criar.TabIndex = 37;
            textBoxEmail_Criar.Visible = false;
            textBoxEmail_Criar.TextChanged += textBoxEmail_Criar_TextChanged;
            // 
            // labelIDHoras_Criar
            // 
            labelIDHoras_Criar.AutoSize = true;
            labelIDHoras_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDHoras_Criar.Location = new Point(677, 280);
            labelIDHoras_Criar.Name = "labelIDHoras_Criar";
            labelIDHoras_Criar.Size = new Size(61, 25);
            labelIDHoras_Criar.TabIndex = 44;
            labelIDHoras_Criar.Text = "Horas";
            labelIDHoras_Criar.Visible = false;
            // 
            // dropDownIDHoras_Criar
            // 
            dropDownIDHoras_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownIDHoras_Criar.DropDownWidth = 250;
            dropDownIDHoras_Criar.FormattingEnabled = true;
            dropDownIDHoras_Criar.Location = new Point(764, 282);
            dropDownIDHoras_Criar.Name = "dropDownIDHoras_Criar";
            dropDownIDHoras_Criar.Size = new Size(102, 23);
            dropDownIDHoras_Criar.TabIndex = 43;
            dropDownIDHoras_Criar.Visible = false;
            // 
            // labelIDCategoria_Criar
            // 
            labelIDCategoria_Criar.AutoSize = true;
            labelIDCategoria_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIDCategoria_Criar.Location = new Point(391, 280);
            labelIDCategoria_Criar.Name = "labelIDCategoria_Criar";
            labelIDCategoria_Criar.Size = new Size(94, 25);
            labelIDCategoria_Criar.TabIndex = 42;
            labelIDCategoria_Criar.Text = "Categoria";
            labelIDCategoria_Criar.Visible = false;
            // 
            // dropDownIDCategoria_Criar
            // 
            dropDownIDCategoria_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownIDCategoria_Criar.DropDownWidth = 250;
            dropDownIDCategoria_Criar.FormattingEnabled = true;
            dropDownIDCategoria_Criar.Location = new Point(540, 282);
            dropDownIDCategoria_Criar.Name = "dropDownIDCategoria_Criar";
            dropDownIDCategoria_Criar.Size = new Size(131, 23);
            dropDownIDCategoria_Criar.TabIndex = 41;
            dropDownIDCategoria_Criar.Visible = false;
            // 
            // labelID_AreaCientifica_Criar
            // 
            labelID_AreaCientifica_Criar.AutoSize = true;
            labelID_AreaCientifica_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID_AreaCientifica_Criar.Location = new Point(16, 280);
            labelID_AreaCientifica_Criar.Name = "labelID_AreaCientifica_Criar";
            labelID_AreaCientifica_Criar.Size = new Size(135, 25);
            labelID_AreaCientifica_Criar.TabIndex = 40;
            labelID_AreaCientifica_Criar.Text = "Área Cientifica";
            labelID_AreaCientifica_Criar.Visible = false;
            // 
            // dropDownID_Area_Cientifica_Criar
            // 
            dropDownID_Area_Cientifica_Criar.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDownID_Area_Cientifica_Criar.DropDownWidth = 250;
            dropDownID_Area_Cientifica_Criar.FormattingEnabled = true;
            dropDownID_Area_Cientifica_Criar.Location = new Point(206, 282);
            dropDownID_Area_Cientifica_Criar.Name = "dropDownID_Area_Cientifica_Criar";
            dropDownID_Area_Cientifica_Criar.Size = new Size(179, 23);
            dropDownID_Area_Cientifica_Criar.TabIndex = 39;
            dropDownID_Area_Cientifica_Criar.Visible = false;
            // 
            // labelC_mais_3_Criar
            // 
            labelC_mais_3_Criar.AutoSize = true;
            labelC_mais_3_Criar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelC_mais_3_Criar.Location = new Point(391, 246);
            labelC_mais_3_Criar.Name = "labelC_mais_3_Criar";
            labelC_mais_3_Criar.Size = new Size(89, 25);
            labelC_mais_3_Criar.TabIndex = 38;
            labelC_mais_3_Criar.Text = "C_mais_3";
            labelC_mais_3_Criar.Visible = false;
            // 
            // DocenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(labelCarreira_Criar);
            Controls.Add(textBoxCarreira_Criar);
            Controls.Add(textBoxC_mais_3_Criar);
            Controls.Add(labelEmail_Criar);
            Controls.Add(textBoxEmail_Criar);
            Controls.Add(labelIDHoras_Criar);
            Controls.Add(dropDownIDHoras_Criar);
            Controls.Add(labelIDCategoria_Criar);
            Controls.Add(dropDownIDCategoria_Criar);
            Controls.Add(labelID_AreaCientifica_Criar);
            Controls.Add(dropDownID_Area_Cientifica_Criar);
            Controls.Add(labelC_mais_3_Criar);
            Controls.Add(labelIDDocente_Criar);
            Controls.Add(textBoxIDDocente_Criar);
            Controls.Add(textBoxNomeDocente_Criar);
            Controls.Add(labelNomeDocente_Criar);
            Controls.Add(labelCarreira);
            Controls.Add(textBoxCarreira);
            Controls.Add(textBoxc_mais_3);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelID_Horas);
            Controls.Add(dropDownEditarDocente_ID_Horas);
            Controls.Add(labelID_Categoria);
            Controls.Add(dropDownEditarDocente_ID_Categoria);
            Controls.Add(labelID_AreaCientifica);
            Controls.Add(dropDownEditarDocente_ID_Area_cientifica);
            Controls.Add(buttonClose);
            Controls.Add(labelc_mais_3);
            Controls.Add(buttonSave);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonCriar);
            Name = "DocenteForm";
            Text = "Docentes";
            Load += DocenteForm_Load;
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
        private TextBox textBoxNomeDocente;
        private TextBox textBoxIDDocente;
        private Label labelIDDocente;
        private Label labelNomeDocente;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSave;
        private Label labelc_mais_3;
        private Button buttonClose;
        private Label labelID_Horas;
        private ComboBox dropDownEditarDocente_ID_Horas;
        private Label labelID_Categoria;
        private ComboBox dropDownEditarDocente_ID_Categoria;
        private Label labelID_AreaCientifica;
        private ComboBox dropDownEditarDocente_ID_Area_cientifica;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxc_mais_3;
        private Label labelCarreira;
        private TextBox textBoxCarreira;
        private Label labelIDDocente_Criar;
        private TextBox textBoxIDDocente_Criar;
        private TextBox textBoxNomeDocente_Criar;
        private Label labelNomeDocente_Criar;
        private Label labelCarreira_Criar;
        private TextBox textBoxCarreira_Criar;
        private TextBox textBoxC_mais_3_Criar;
        private Label labelEmail_Criar;
        private TextBox textBoxEmail_Criar;
        private Label labelIDHoras_Criar;
        private ComboBox dropDownIDHoras_Criar;
        private Label labelIDCategoria_Criar;
        private ComboBox dropDownIDCategoria_Criar;
        private Label labelID_AreaCientifica_Criar;
        private ComboBox dropDownID_Area_Cientifica_Criar;
        private Label labelC_mais_3_Criar;
        private Button buttonExcel;
#endregion
    }
    #endregion
}