using Label = System.Windows.Forms.Label;

namespace Projeto
{
    #region Class do design deste Form (DSDForm)
    partial class DSDForm
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
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ButtonConsulta = new Button();
            ButtonEditar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.SkyBlue;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(857, 74);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // labelDSD
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 18);
            label1.Name = "labelDSD";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 0;
            label1.Text = "DSD";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ButtonConsulta, 0, 0);
            tableLayoutPanel2.Controls.Add(ButtonEditar, 0, 1);
            tableLayoutPanel2.Location = new Point(12, 170);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(857, 116);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ButtonConsulta
            // 
            ButtonConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ButtonConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConsulta.Location = new Point(326, 3);
            ButtonConsulta.Name = "ButtonConsulta";
            ButtonConsulta.Size = new Size(205, 52);
            ButtonConsulta.TabIndex = 0;
            ButtonConsulta.Text = "Consulta";
            ButtonConsulta.UseVisualStyleBackColor = true;
            ButtonConsulta.Click += ButtonConsulta_Click;
            // 
            // ButtonEditar
            // 
            ButtonEditar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ButtonEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEditar.Location = new Point(325, 61);
            ButtonEditar.Name = "ButtonEditar";
            ButtonEditar.Size = new Size(206, 52);
            ButtonEditar.TabIndex = 1;
            ButtonEditar.Text = "Editar";
            ButtonEditar.UseVisualStyleBackColor = true;
            ButtonEditar.Click += ButtonEditar_Click;
            // 
            // DSDForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(881, 454);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "DSDForm";
            Text = "DSDForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ButtonConsulta;
        private Button ButtonEditar;
        #endregion
    }
    #endregion
}