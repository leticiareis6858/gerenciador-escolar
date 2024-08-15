namespace GerenciadorDeTurmas.FormsCursos
{
    partial class FormBuscarCursosProfessores
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
            this.txt_disciplina = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.txt_disciplinas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_id_curso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_cursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_disciplina
            // 
            this.txt_disciplina.Location = new System.Drawing.Point(204, 55);
            this.txt_disciplina.Multiline = true;
            this.txt_disciplina.Name = "txt_disciplina";
            this.txt_disciplina.Size = new System.Drawing.Size(132, 69);
            this.txt_disciplina.TabIndex = 25;
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(39, 55);
            this.txt_curso.Multiline = true;
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(132, 69);
            this.txt_curso.TabIndex = 24;
            // 
            // txt_disciplinas
            // 
            this.txt_disciplinas.AutoSize = true;
            this.txt_disciplinas.Location = new System.Drawing.Point(201, 39);
            this.txt_disciplinas.Name = "txt_disciplinas";
            this.txt_disciplinas.Size = new System.Drawing.Size(66, 13);
            this.txt_disciplinas.TabIndex = 23;
            this.txt_disciplinas.Text = "Disciplina(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome do curso:";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(352, 58);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(352, 29);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 20;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(273, 147);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 19;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(192, 147);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_id_curso
            // 
            this.txt_id_curso.Location = new System.Drawing.Point(39, 150);
            this.txt_id_curso.Name = "txt_id_curso";
            this.txt_id_curso.Size = new System.Drawing.Size(100, 20);
            this.txt_id_curso.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID do Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cursos disponíveis:";
            // 
            // dataGridView_cursos
            // 
            this.dataGridView_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cursos.Location = new System.Drawing.Point(39, 199);
            this.dataGridView_cursos.Name = "dataGridView_cursos";
            this.dataGridView_cursos.Size = new System.Drawing.Size(388, 223);
            this.dataGridView_cursos.TabIndex = 14;
            // 
            // FormBuscarCursosProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.txt_disciplina);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.txt_disciplinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id_curso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_cursos);
            this.Name = "FormBuscarCursosProfessores";
            this.Text = "Buscar cursos - Professores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_disciplina;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Label txt_disciplinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_id_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_cursos;
    }
}