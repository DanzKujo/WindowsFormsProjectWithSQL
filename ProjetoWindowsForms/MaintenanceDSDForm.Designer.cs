using Label = System.Windows.Forms.Label;

namespace Projeto
{
    #region Class do design deste Form (MaintenanceDSDForm)
    partial class MaintenanceDSDForm
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

        #region Windows Form Layout

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            labelSeperator = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.7269554F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.2730446F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(857, 74);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 17);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Maintenance";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(656, 17);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 1;
            label2.Text = "DSD";
            label2.UseMnemonic = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.42707F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.57293F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 92);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(857, 350);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button1, 0, 2);
            tableLayoutPanel3.Controls.Add(button2, 0, 3);
            tableLayoutPanel3.Location = new Point(538, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel3.Size = new Size(316, 344);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(47, 113);
            button1.Name = "button1";
            button1.Size = new Size(221, 49);
            button1.TabIndex = 0;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonConsultar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(47, 168);
            button2.Name = "button2";
            button2.Size = new Size(221, 49);
            button2.TabIndex = 1;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonEditar_Click;
            // 
            // labelSeperator
            // 
            labelSeperator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelSeperator.BackColor = Color.Black;
            labelSeperator.BorderStyle = BorderStyle.Fixed3D;
            labelSeperator.Location = new Point(540, 92);
            labelSeperator.Name = "labelSeperator";
            labelSeperator.Size = new Size(4, 350);
            labelSeperator.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.None;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(button9, 0, 6);
            tableLayoutPanel4.Controls.Add(button8, 0, 5);
            tableLayoutPanel4.Controls.Add(button7, 0, 4);
            tableLayoutPanel4.Controls.Add(button6, 0, 3);
            tableLayoutPanel4.Controls.Add(button4, 0, 1);
            tableLayoutPanel4.Controls.Add(button5, 0, 2);
            tableLayoutPanel4.Controls.Add(button3, 0, 0);
            tableLayoutPanel4.Location = new Point(12, 95);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(522, 344);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(150, 297);
            button9.Name = "button9";
            button9.Size = new Size(221, 44);
            button9.TabIndex = 8;
            button9.Text = "Unidade Curricular";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonUnidadeCurricular_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(150, 248);
            button8.Name = "button8";
            button8.Size = new Size(221, 43);
            button8.TabIndex = 7;
            button8.Text = "Turma";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonTurma_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(150, 199);
            button7.Name = "button7";
            button7.Size = new Size(221, 43);
            button7.TabIndex = 6;
            button7.Text = "Semestre";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonSemestre_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(150, 150);
            button6.Name = "button6";
            button6.Size = new Size(221, 43);
            button6.TabIndex = 5;
            button6.Text = "Docente";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonDocente_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(150, 52);
            button4.Name = "button4";
            button4.Size = new Size(221, 43);
            button4.TabIndex = 2;
            button4.Text = "Categoria";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonCategoria_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(150, 101);
            button5.Name = "button5";
            button5.Size = new Size(221, 43);
            button5.TabIndex = 4;
            button5.Text = "Curso";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonCurso_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(150, 3);
            button3.Name = "button3";
            button3.Size = new Size(221, 43);
            button3.TabIndex = 3;
            button3.Text = "Area";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonArea_Click;
            // 
            // MaintenanceDSDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(labelSeperator);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "MaintenanceDSDForm";
            Text = "MaintenanceDSDForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;

        #endregion

        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private Label labelSeperator;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button9;
    }
    #endregion
}