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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.txt_titulacao.Click += new System.EventHandler(this.txt_titulacao_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.OrangeRed;
            this.txt_nome.Location = new System.Drawing.Point(79, 80);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(62, 24);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.Text = "Nome";
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar cursos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar disciplinas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 84);
            this.button3.TabIndex = 5;
            this.button3.Text = "Verificar cursos e disciplinas atrelados a si";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 84);
            this.button4.TabIndex = 6;
            this.button4.Text = "Atualizar suas próprias informações";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(460, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Sair";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 247);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O que deseja fazer?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormTelaInicialProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_titulacao);
            this.Controls.Add(this.label1);
            this.Name = "FormTelaInicialProfessor";
            this.Text = "Tela incial - Professor";
            this.Load += new System.EventHandler(this.FormTelaInicialProfessor_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_titulacao;
        private System.Windows.Forms.Label txt_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}