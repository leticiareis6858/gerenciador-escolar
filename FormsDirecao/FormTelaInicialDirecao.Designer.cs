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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_alunos = new System.Windows.Forms.Button();
            this.btn_verificar_professores = new System.Windows.Forms.Button();
            this.btn_atualizar_informacoes = new System.Windows.Forms.Button();
            this.btn_disciplinas = new System.Windows.Forms.Button();
            this.btn_cursos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seja bem vindo(a),";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_nome.Location = new System.Drawing.Point(227, 75);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(62, 24);
            this.txt_nome.TabIndex = 14;
            this.txt_nome.Text = "Nome";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(502, 28);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 15;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_alunos);
            this.groupBox1.Controls.Add(this.btn_verificar_professores);
            this.groupBox1.Controls.Add(this.btn_atualizar_informacoes);
            this.groupBox1.Controls.Add(this.btn_disciplinas);
            this.groupBox1.Controls.Add(this.btn_cursos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 364);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O que deseja fazer?";
            // 
            // btn_alunos
            // 
            this.btn_alunos.Location = new System.Drawing.Point(277, 147);
            this.btn_alunos.Name = "btn_alunos";
            this.btn_alunos.Size = new System.Drawing.Size(159, 84);
            this.btn_alunos.TabIndex = 8;
            this.btn_alunos.Text = "Gerenciar alunos";
            this.btn_alunos.UseVisualStyleBackColor = true;
            this.btn_alunos.Click += new System.EventHandler(this.btn_alunos_Click);
            // 
            // btn_verificar_professores
            // 
            this.btn_verificar_professores.Location = new System.Drawing.Point(37, 147);
            this.btn_verificar_professores.Name = "btn_verificar_professores";
            this.btn_verificar_professores.Size = new System.Drawing.Size(159, 84);
            this.btn_verificar_professores.TabIndex = 7;
            this.btn_verificar_professores.Text = "Gerenciar professores";
            this.btn_verificar_professores.UseVisualStyleBackColor = true;
            this.btn_verificar_professores.Click += new System.EventHandler(this.btn_verificar_professores_Click);
            // 
            // btn_atualizar_informacoes
            // 
            this.btn_atualizar_informacoes.Location = new System.Drawing.Point(37, 255);
            this.btn_atualizar_informacoes.Name = "btn_atualizar_informacoes";
            this.btn_atualizar_informacoes.Size = new System.Drawing.Size(159, 84);
            this.btn_atualizar_informacoes.TabIndex = 6;
            this.btn_atualizar_informacoes.Text = "Atualizar suas próprias informações";
            this.btn_atualizar_informacoes.UseVisualStyleBackColor = true;
            this.btn_atualizar_informacoes.Click += new System.EventHandler(this.btn_atualizar_informacoes_Click);
            // 
            // btn_disciplinas
            // 
            this.btn_disciplinas.Location = new System.Drawing.Point(37, 34);
            this.btn_disciplinas.Name = "btn_disciplinas";
            this.btn_disciplinas.Size = new System.Drawing.Size(159, 84);
            this.btn_disciplinas.TabIndex = 5;
            this.btn_disciplinas.Text = "Gerenciar disciplinas";
            this.btn_disciplinas.UseVisualStyleBackColor = true;
            this.btn_disciplinas.Click += new System.EventHandler(this.btn_disciplinas_Click);
            // 
            // btn_cursos
            // 
            this.btn_cursos.Location = new System.Drawing.Point(277, 34);
            this.btn_cursos.Name = "btn_cursos";
            this.btn_cursos.Size = new System.Drawing.Size(159, 84);
            this.btn_cursos.TabIndex = 3;
            this.btn_cursos.Text = "Gerenciar cursos";
            this.btn_cursos.UseVisualStyleBackColor = true;
            this.btn_cursos.Click += new System.EventHandler(this.btn_cursos_Click);
            // 
            // FormTelaInicialDirecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "FormTelaInicialDirecao";
            this.Text = "Tela Inicial - Direção";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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