namespace GerenciadorDeTurmas.FormsDirecao
{
    partial class FormTelaInicialDirecao
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
            label1 = new System.Windows.Forms.Label();
            txt_nome = new System.Windows.Forms.Label();
            btn_sair = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_alunos = new System.Windows.Forms.Button();
            btn_verificar_professores = new System.Windows.Forms.Button();
            btn_atualizar_informacoes = new System.Windows.Forms.Button();
            btn_disciplinas = new System.Windows.Forms.Button();
            btn_cursos = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(62, 87);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 24);
            label1.TabIndex = 12;
            label1.Text = "Seja bem vindo(a),";
            // 
            // txt_nome
            // 
            txt_nome.AutoSize = true;
            txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txt_nome.ForeColor = System.Drawing.Color.OrangeRed;
            txt_nome.Location = new System.Drawing.Point(265, 87);
            txt_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new System.Drawing.Size(62, 24);
            txt_nome.TabIndex = 14;
            txt_nome.Text = "Nome";
            // 
            // btn_sair
            // 
            btn_sair.Location = new System.Drawing.Point(586, 32);
            btn_sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new System.Drawing.Size(88, 27);
            btn_sair.TabIndex = 15;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_alunos);
            groupBox1.Controls.Add(btn_verificar_professores);
            groupBox1.Controls.Add(btn_atualizar_informacoes);
            groupBox1.Controls.Add(btn_disciplinas);
            groupBox1.Controls.Add(btn_cursos);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.Location = new System.Drawing.Point(66, 129);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(546, 420);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "O que deseja fazer?";
            // 
            // btn_alunos
            // 
            btn_alunos.Location = new System.Drawing.Point(323, 170);
            btn_alunos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_alunos.Name = "btn_alunos";
            btn_alunos.Size = new System.Drawing.Size(186, 97);
            btn_alunos.TabIndex = 8;
            btn_alunos.Text = "Gerenciar alunos";
            btn_alunos.UseVisualStyleBackColor = true;
            btn_alunos.Click += btn_alunos_Click;
            // 
            // btn_verificar_professores
            // 
            btn_verificar_professores.Location = new System.Drawing.Point(43, 170);
            btn_verificar_professores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_verificar_professores.Name = "btn_verificar_professores";
            btn_verificar_professores.Size = new System.Drawing.Size(186, 97);
            btn_verificar_professores.TabIndex = 7;
            btn_verificar_professores.Text = "Gerenciar professores";
            btn_verificar_professores.UseVisualStyleBackColor = true;
            btn_verificar_professores.Click += btn_verificar_professores_Click;
            // 
            // btn_atualizar_informacoes
            // 
            btn_atualizar_informacoes.Location = new System.Drawing.Point(43, 294);
            btn_atualizar_informacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_atualizar_informacoes.Name = "btn_atualizar_informacoes";
            btn_atualizar_informacoes.Size = new System.Drawing.Size(186, 97);
            btn_atualizar_informacoes.TabIndex = 6;
            btn_atualizar_informacoes.Text = "Atualizar suas próprias informações";
            btn_atualizar_informacoes.UseVisualStyleBackColor = true;
            btn_atualizar_informacoes.Click += btn_atualizar_informacoes_Click;
            // 
            // btn_disciplinas
            // 
            btn_disciplinas.Location = new System.Drawing.Point(43, 39);
            btn_disciplinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_disciplinas.Name = "btn_disciplinas";
            btn_disciplinas.Size = new System.Drawing.Size(186, 97);
            btn_disciplinas.TabIndex = 5;
            btn_disciplinas.Text = "Gerenciar disciplinas";
            btn_disciplinas.UseVisualStyleBackColor = true;
            btn_disciplinas.Click += btn_disciplinas_Click;
            // 
            // btn_cursos
            // 
            btn_cursos.Location = new System.Drawing.Point(323, 39);
            btn_cursos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_cursos.Name = "btn_cursos";
            btn_cursos.Size = new System.Drawing.Size(186, 97);
            btn_cursos.TabIndex = 3;
            btn_cursos.Text = "Gerenciar cursos";
            btn_cursos.UseVisualStyleBackColor = true;
            btn_cursos.Click += btn_cursos_Click;
            // 
            // FormTelaInicialDirecao
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 632);
            Controls.Add(groupBox1);
            Controls.Add(btn_sair);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormTelaInicialDirecao";
            Text = "Tela Inicial - Direção";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_alunos;
        private System.Windows.Forms.Button btn_verificar_professores;
        private System.Windows.Forms.Button btn_atualizar_informacoes;
        private System.Windows.Forms.Button btn_disciplinas;
        private System.Windows.Forms.Button btn_cursos;
    }
}