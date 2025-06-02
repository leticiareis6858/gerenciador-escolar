namespace GerenciadorEscolar
{
    partial class FormCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_escolha = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que deseja cadastrar?";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(141, 127);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_proximo.TabIndex = 3;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(260, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_escolha
            // 
            this.txt_escolha.FormattingEnabled = true;
            this.txt_escolha.Items.AddRange(new object[] {
            "professor",
            "aluno",
            "disciplina",
            "curso"});
            this.txt_escolha.Location = new System.Drawing.Point(95, 88);
            this.txt_escolha.Name = "txt_escolha";
            this.txt_escolha.Size = new System.Drawing.Size(173, 21);
            this.txt_escolha.TabIndex = 5;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 168);
            this.Controls.Add(this.txt_escolha);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Text = "Tela de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ComboBox txt_escolha;
    }
}