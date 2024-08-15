namespace GerenciadorEscolar
{
    partial class FormTelaInicialProfessor
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
            this.txt_titulacao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            this.btn_cursos = new System.Windows.Forms.Button();
            this.btn_disciplinas = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja bem vindo(a),";
            // 
            // txt_titulacao
            // 
            this.txt_titulacao.AutoSize = true;
            this.txt_titulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulacao.Location = new System.Drawing.Point(208, 47);
            this.txt_titulacao.Name = "txt_titulacao";
            this.txt_titulacao.Size = new System.Drawing.Size(86, 24);
            this.txt_titulacao.TabIndex = 1;
            this.txt_titulacao.Text = "Titulação";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.Teal;
            this.txt_nome.Location = new System.Drawing.Point(79, 80);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(62, 24);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.Text = "Nome";
            // 
            // btn_cursos
            // 
            this.btn_cursos.Location = new System.Drawing.Point(269, 34);
            this.btn_cursos.Name = "btn_cursos";
            this.btn_cursos.Size = new System.Drawing.Size(159, 84);
            this.btn_cursos.TabIndex = 3;
            this.btn_cursos.Text = "Buscar cursos";
            this.btn_cursos.UseVisualStyleBackColor = true;
            this.btn_cursos.Click += new System.EventHandler(this.btn_cursos_Click);
            // 
            // btn_disciplinas
            // 
            this.btn_disciplinas.Location = new System.Drawing.Point(36, 34);
            this.btn_disciplinas.Name = "btn_disciplinas";
            this.btn_disciplinas.Size = new System.Drawing.Size(159, 84);
            this.btn_disciplinas.TabIndex = 4;
            this.btn_disciplinas.Text = "Buscar disciplinas";
            this.btn_disciplinas.UseVisualStyleBackColor = true;
            this.btn_disciplinas.Click += new System.EventHandler(this.btn_disciplinas_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(36, 140);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(159, 84);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.Text = "Verificar cursos e disciplinas atrelados a si";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(269, 140);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(159, 84);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar suas próprias informações";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(460, 25);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_atualizar);
            this.groupBox1.Controls.Add(this.btn_verificar);
            this.groupBox1.Controls.Add(this.btn_disciplinas);
            this.groupBox1.Controls.Add(this.btn_cursos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 247);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O que deseja fazer?";
            // 
            // FormTelaInicialProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_titulacao);
            this.Controls.Add(this.label1);
            this.Name = "FormTelaInicialProfessor";
            this.Text = "Tela incial - Professor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_titulacao;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Button btn_cursos;
        private System.Windows.Forms.Button btn_disciplinas;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}