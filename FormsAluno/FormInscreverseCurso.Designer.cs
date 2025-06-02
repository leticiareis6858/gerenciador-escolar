namespace GerenciadorDeTurmas.FormsAluno
{
    partial class FormInscreverseCurso
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
            this.dataGridView_cursos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_curso = new System.Windows.Forms.TextBox();
            this.btn_inscrever = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cursos
            // 
            this.dataGridView_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cursos.Location = new System.Drawing.Point(52, 164);
            this.dataGridView_cursos.Name = "dataGridView_cursos";
            this.dataGridView_cursos.Size = new System.Drawing.Size(414, 248);
            this.dataGridView_cursos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id do Curso:";
            // 
            // txt_id_curso
            // 
            this.txt_id_curso.Location = new System.Drawing.Point(52, 75);
            this.txt_id_curso.Multiline = true;
            this.txt_id_curso.Name = "txt_id_curso";
            this.txt_id_curso.Size = new System.Drawing.Size(100, 55);
            this.txt_id_curso.TabIndex = 2;
            // 
            // btn_inscrever
            // 
            this.btn_inscrever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscrever.Location = new System.Drawing.Point(177, 65);
            this.btn_inscrever.Name = "btn_inscrever";
            this.btn_inscrever.Size = new System.Drawing.Size(100, 36);
            this.btn_inscrever.TabIndex = 3;
            this.btn_inscrever.Text = "Inscrever-se";
            this.btn_inscrever.UseVisualStyleBackColor = true;
            this.btn_inscrever.Click += new System.EventHandler(this.btn_inscrever_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(177, 107);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(356, 30);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aluno(a)";
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_nome.Location = new System.Drawing.Point(337, 78);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(35, 13);
            this.txt_nome.TabIndex = 7;
            this.txt_nome.Text = "Nome";
            // 
            // FormInscreverseCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_inscrever);
            this.Controls.Add(this.txt_id_curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_cursos);
            this.Name = "FormInscreverseCurso";
            this.Text = "Inscrever-se em um curso";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_curso;
        private System.Windows.Forms.Button btn_inscrever;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txt_nome;
    }
}