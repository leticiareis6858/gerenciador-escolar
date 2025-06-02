namespace GerenciadorDeTurmas.FormsProfessor
{
    partial class FormVerificarAtrelamentosProfessores
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
            this.dataGridView_disciplinas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_cursos = new System.Windows.Forms.DataGridView();
            this.txt_nome = new System.Windows.Forms.Label();
            this.txt_titulacao = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_disciplinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_disciplinas
            // 
            this.dataGridView_disciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_disciplinas.Location = new System.Drawing.Point(38, 137);
            this.dataGridView_disciplinas.Name = "dataGridView_disciplinas";
            this.dataGridView_disciplinas.Size = new System.Drawing.Size(326, 236);
            this.dataGridView_disciplinas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplinas que você ministra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos que você ministra:";
            // 
            // dataGridView_cursos
            // 
            this.dataGridView_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cursos.Location = new System.Drawing.Point(439, 137);
            this.dataGridView_cursos.Name = "dataGridView_cursos";
            this.dataGridView_cursos.Size = new System.Drawing.Size(326, 236);
            this.dataGridView_cursos.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.AutoSize = true;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_nome.Location = new System.Drawing.Point(90, 64);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(62, 24);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.Text = "Nome";
            // 
            // txt_titulacao
            // 
            this.txt_titulacao.AutoSize = true;
            this.txt_titulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulacao.Location = new System.Drawing.Point(34, 40);
            this.txt_titulacao.Name = "txt_titulacao";
            this.txt_titulacao.Size = new System.Drawing.Size(86, 24);
            this.txt_titulacao.TabIndex = 5;
            this.txt_titulacao.Text = "Titulação";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(703, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // FormVerificarAtrelamentosProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_titulacao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.dataGridView_cursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_disciplinas);
            this.Name = "FormVerificarAtrelamentosProfessores";
            this.Text = "Verificar atrelamentos - Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_disciplinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_disciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_cursos;
        public System.Windows.Forms.Label txt_nome;
        public System.Windows.Forms.Label txt_titulacao;
        private System.Windows.Forms.Button btn_voltar;
    }
}