namespace GerenciadorEscolar.FormsDisciplinas
{
    partial class FormAlterarDisciplina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_removerHabilidades = new System.Windows.Forms.Button();
            this.list_habilidades = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_novoNomeDisciplina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_alterarNome = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscarDisciplina = new System.Windows.Forms.Button();
            this.txt_nomeDisciplina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_novasHabilidades = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_adicionarHabilidades = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_removerHabilidades);
            this.groupBox1.Controls.Add(this.list_habilidades);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_removerHabilidades
            // 
            this.btn_removerHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removerHabilidades.Location = new System.Drawing.Point(89, 320);
            this.btn_removerHabilidades.Name = "btn_removerHabilidades";
            this.btn_removerHabilidades.Size = new System.Drawing.Size(148, 35);
            this.btn_removerHabilidades.TabIndex = 3;
            this.btn_removerHabilidades.Text = "Remover";
            this.btn_removerHabilidades.UseVisualStyleBackColor = true;
            this.btn_removerHabilidades.Click += new System.EventHandler(this.btn_removerHabilidades_Click);
            // 
            // list_habilidades
            // 
            this.list_habilidades.FormattingEnabled = true;
            this.list_habilidades.Location = new System.Drawing.Point(22, 91);
            this.list_habilidades.Name = "list_habilidades";
            this.list_habilidades.Size = new System.Drawing.Size(274, 214);
            this.list_habilidades.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione as habilidades a serem removidas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remover habilidades";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_novoNomeDisciplina);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_alterarNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txt_novoNomeDisciplina
            // 
            this.txt_novoNomeDisciplina.Location = new System.Drawing.Point(10, 70);
            this.txt_novoNomeDisciplina.Name = "txt_novoNomeDisciplina";
            this.txt_novoNomeDisciplina.Size = new System.Drawing.Size(252, 20);
            this.txt_novoNomeDisciplina.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Informe o novo nome da disciplina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mudar nome da disciplina";
            // 
            // btn_alterarNome
            // 
            this.btn_alterarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarNome.Location = new System.Drawing.Point(15, 112);
            this.btn_alterarNome.Name = "btn_alterarNome";
            this.btn_alterarNome.Size = new System.Drawing.Size(247, 23);
            this.btn_alterarNome.TabIndex = 0;
            this.btn_alterarNome.Text = "Alterar nome";
            this.btn_alterarNome.UseVisualStyleBackColor = true;
            this.btn_alterarNome.Click += new System.EventHandler(this.btn_alterarNome_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_buscarDisciplina);
            this.groupBox3.Controls.Add(this.txt_nomeDisciplina);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_buscarDisciplina
            // 
            this.btn_buscarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarDisciplina.Location = new System.Drawing.Point(15, 103);
            this.btn_buscarDisciplina.Name = "btn_buscarDisciplina";
            this.btn_buscarDisciplina.Size = new System.Drawing.Size(251, 23);
            this.btn_buscarDisciplina.TabIndex = 3;
            this.btn_buscarDisciplina.Text = "Buscar";
            this.btn_buscarDisciplina.UseVisualStyleBackColor = true;
            this.btn_buscarDisciplina.Click += new System.EventHandler(this.btn_buscarDisciplina_Click);
            // 
            // txt_nomeDisciplina
            // 
            this.txt_nomeDisciplina.Location = new System.Drawing.Point(19, 77);
            this.txt_nomeDisciplina.Name = "txt_nomeDisciplina";
            this.txt_nomeDisciplina.Size = new System.Drawing.Size(247, 20);
            this.txt_nomeDisciplina.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Informe o nome da disciplina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buscar disciplina a ser alterada";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_novasHabilidades);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btn_adicionarHabilidades);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(682, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 377);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // txt_novasHabilidades
            // 
            this.txt_novasHabilidades.Location = new System.Drawing.Point(18, 91);
            this.txt_novasHabilidades.Multiline = true;
            this.txt_novasHabilidades.Name = "txt_novasHabilidades";
            this.txt_novasHabilidades.Size = new System.Drawing.Size(267, 214);
            this.txt_novasHabilidades.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(36, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "As habilidades devem ser informadas separadas por vírgula";
            // 
            // btn_adicionarHabilidades
            // 
            this.btn_adicionarHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarHabilidades.Location = new System.Drawing.Point(81, 320);
            this.btn_adicionarHabilidades.Name = "btn_adicionarHabilidades";
            this.btn_adicionarHabilidades.Size = new System.Drawing.Size(148, 35);
            this.btn_adicionarHabilidades.TabIndex = 3;
            this.btn_adicionarHabilidades.Text = "Adicionar";
            this.btn_adicionarHabilidades.UseVisualStyleBackColor = true;
            this.btn_adicionarHabilidades.Click += new System.EventHandler(this.btn_adicionarHabilidades_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Informe as habilidades a serem adicionadas a disciplina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adicionar habilidades";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(930, 9);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(78, 30);
            this.btn_voltar.TabIndex = 49;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // FormAlterarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 446);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAlterarDisciplina";
            this.Text = "FormAlterarDisciplina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removerHabilidades;
        private System.Windows.Forms.CheckedListBox list_habilidades;
        private System.Windows.Forms.Button btn_buscarDisciplina;
        private System.Windows.Forms.TextBox txt_nomeDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_novoNomeDisciplina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_alterarNome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_adicionarHabilidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_novasHabilidades;
        private System.Windows.Forms.Button btn_voltar;
    }
}