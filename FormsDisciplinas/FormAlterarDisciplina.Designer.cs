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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_removerHabilidades = new System.Windows.Forms.Button();
            list_habilidades = new System.Windows.Forms.CheckedListBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txt_novoNomeDisciplina = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btn_alterarNome = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btn_buscarDisciplina = new System.Windows.Forms.Button();
            txt_nomeDisciplina = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            txt_novasHabilidades = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            btn_adicionarHabilidades = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btn_voltar = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_removerHabilidades);
            groupBox1.Controls.Add(list_habilidades);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(410, 52);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(365, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btn_removerHabilidades
            // 
            btn_removerHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_removerHabilidades.Location = new System.Drawing.Point(104, 369);
            btn_removerHabilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_removerHabilidades.Name = "btn_removerHabilidades";
            btn_removerHabilidades.Size = new System.Drawing.Size(173, 40);
            btn_removerHabilidades.TabIndex = 3;
            btn_removerHabilidades.Text = "Remover";
            btn_removerHabilidades.UseVisualStyleBackColor = true;
            btn_removerHabilidades.Click += btn_removerHabilidades_Click;
            // 
            // list_habilidades
            // 
            list_habilidades.FormattingEnabled = true;
            list_habilidades.Location = new System.Drawing.Point(26, 105);
            list_habilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            list_habilidades.Name = "list_habilidades";
            list_habilidades.Size = new System.Drawing.Size(319, 238);
            list_habilidades.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 66);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(239, 15);
            label2.TabIndex = 1;
            label2.Text = "Selecione as habilidades a serem removidas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(21, 30);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Remover habilidades";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_novoNomeDisciplina);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btn_alterarNome);
            groupBox2.Location = new System.Drawing.Point(14, 257);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(372, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txt_novoNomeDisciplina
            // 
            txt_novoNomeDisciplina.Location = new System.Drawing.Point(12, 81);
            txt_novoNomeDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_novoNomeDisciplina.Name = "txt_novoNomeDisciplina";
            txt_novoNomeDisciplina.Size = new System.Drawing.Size(293, 23);
            txt_novoNomeDisciplina.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 46);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(195, 15);
            label6.TabIndex = 2;
            label6.Text = "Informe o novo nome da disciplina:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(7, 18);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(212, 20);
            label5.TabIndex = 1;
            label5.Text = "Mudar nome da disciplina";
            // 
            // btn_alterarNome
            // 
            btn_alterarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_alterarNome.Location = new System.Drawing.Point(18, 129);
            btn_alterarNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_alterarNome.Name = "btn_alterarNome";
            btn_alterarNome.Size = new System.Drawing.Size(288, 27);
            btn_alterarNome.TabIndex = 0;
            btn_alterarNome.Text = "Alterar nome";
            btn_alterarNome.UseVisualStyleBackColor = true;
            btn_alterarNome.Click += btn_alterarNome_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_buscarDisciplina);
            groupBox3.Controls.Add(txt_nomeDisciplina);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new System.Drawing.Point(14, 52);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(372, 171);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btn_buscarDisciplina
            // 
            btn_buscarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_buscarDisciplina.Location = new System.Drawing.Point(18, 119);
            btn_buscarDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_buscarDisciplina.Name = "btn_buscarDisciplina";
            btn_buscarDisciplina.Size = new System.Drawing.Size(293, 27);
            btn_buscarDisciplina.TabIndex = 3;
            btn_buscarDisciplina.Text = "Buscar";
            btn_buscarDisciplina.UseVisualStyleBackColor = true;
            btn_buscarDisciplina.Click += btn_buscarDisciplina_Click;
            // 
            // txt_nomeDisciplina
            // 
            txt_nomeDisciplina.Location = new System.Drawing.Point(22, 89);
            txt_nomeDisciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_nomeDisciplina.Name = "txt_nomeDisciplina";
            txt_nomeDisciplina.Size = new System.Drawing.Size(288, 23);
            txt_nomeDisciplina.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 58);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(165, 15);
            label4.TabIndex = 1;
            label4.Text = "Informe o nome da disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(7, 18);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(260, 20);
            label3.TabIndex = 0;
            label3.Text = "Buscar disciplina a ser alterada";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_novasHabilidades);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btn_adicionarHabilidades);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new System.Drawing.Point(796, 52);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(365, 435);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // txt_novasHabilidades
            // 
            txt_novasHabilidades.Location = new System.Drawing.Point(21, 105);
            txt_novasHabilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_novasHabilidades.Multiline = true;
            txt_novasHabilidades.Name = "txt_novasHabilidades";
            txt_novasHabilidades.Size = new System.Drawing.Size(311, 246);
            txt_novasHabilidades.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(42, 355);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(249, 12);
            label9.TabIndex = 4;
            label9.Text = "As habilidades devem ser informadas separadas por vírgula";
            // 
            // btn_adicionarHabilidades
            // 
            btn_adicionarHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_adicionarHabilidades.Location = new System.Drawing.Point(94, 369);
            btn_adicionarHabilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_adicionarHabilidades.Name = "btn_adicionarHabilidades";
            btn_adicionarHabilidades.Size = new System.Drawing.Size(173, 40);
            btn_adicionarHabilidades.TabIndex = 3;
            btn_adicionarHabilidades.Text = "Adicionar";
            btn_adicionarHabilidades.UseVisualStyleBackColor = true;
            btn_adicionarHabilidades.Click += btn_adicionarHabilidades_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(18, 66);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(301, 15);
            label7.TabIndex = 1;
            label7.Text = "Informe as habilidades a serem adicionadas a disciplina:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(16, 30);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(180, 20);
            label8.TabIndex = 0;
            label8.Text = "Adicionar habilidades";
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_voltar.Location = new System.Drawing.Point(1085, 10);
            btn_voltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new System.Drawing.Size(91, 35);
            btn_voltar.TabIndex = 49;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FormAlterarDisciplina
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1190, 515);
            Controls.Add(btn_voltar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormAlterarDisciplina";
            Text = "Alterar disciplina";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);

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