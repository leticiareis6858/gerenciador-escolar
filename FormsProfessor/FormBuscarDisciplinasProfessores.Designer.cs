namespace GerenciadorEscolar.FormsProfessor
{
    partial class FormBuscarDisciplinasProfessores
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            dataGridView_disciplinas = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_id_disciplina = new System.Windows.Forms.TextBox();
            btn_buscar = new System.Windows.Forms.Button();
            btn_limpar = new System.Windows.Forms.Button();
            btn_voltar = new System.Windows.Forms.Button();
            btn_sair = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txt_disciplina = new System.Windows.Forms.TextBox();
            txt_habilidades = new System.Windows.Forms.TextBox();
            txt_nome = new System.Windows.Forms.Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_disciplinas).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripComboBox1, toolStripSeparator1, toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(182, 59);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // dataGridView_disciplinas
            // 
            dataGridView_disciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_disciplinas.Location = new System.Drawing.Point(46, 224);
            dataGridView_disciplinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView_disciplinas.Name = "dataGridView_disciplinas";
            dataGridView_disciplinas.Size = new System.Drawing.Size(453, 257);
            dataGridView_disciplinas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(42, 205);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 15);
            label1.TabIndex = 3;
            label1.Text = "Disciplinas Disponíveis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 150);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "ID da Disciplina:";
            // 
            // txt_id_disciplina
            // 
            txt_id_disciplina.Location = new System.Drawing.Point(46, 168);
            txt_id_disciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_id_disciplina.Name = "txt_id_disciplina";
            txt_id_disciplina.Size = new System.Drawing.Size(116, 23);
            txt_id_disciplina.TabIndex = 5;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new System.Drawing.Point(214, 168);
            btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new System.Drawing.Size(88, 27);
            btn_buscar.TabIndex = 6;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new System.Drawing.Point(320, 168);
            btn_limpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new System.Drawing.Size(88, 27);
            btn_limpar.TabIndex = 7;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new System.Drawing.Point(411, 14);
            btn_voltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new System.Drawing.Size(88, 27);
            btn_voltar.TabIndex = 8;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new System.Drawing.Point(411, 47);
            btn_sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new System.Drawing.Size(88, 27);
            btn_sair.TabIndex = 9;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 47);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 15);
            label3.TabIndex = 10;
            label3.Text = "Nome da disciplina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(234, 47);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 15);
            label4.TabIndex = 11;
            label4.Text = "Habilidade(s):";
            // 
            // txt_disciplina
            // 
            txt_disciplina.Location = new System.Drawing.Point(46, 66);
            txt_disciplina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_disciplina.Multiline = true;
            txt_disciplina.Name = "txt_disciplina";
            txt_disciplina.Size = new System.Drawing.Size(153, 79);
            txt_disciplina.TabIndex = 12;
            // 
            // txt_habilidades
            // 
            txt_habilidades.Location = new System.Drawing.Point(238, 66);
            txt_habilidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_habilidades.Multiline = true;
            txt_habilidades.Name = "txt_habilidades";
            txt_habilidades.Size = new System.Drawing.Size(153, 79);
            txt_habilidades.TabIndex = 13;
            // 
            // txt_nome
            // 
            txt_nome.AutoSize = true;
            txt_nome.ForeColor = System.Drawing.Color.DarkOrange;
            txt_nome.Location = new System.Drawing.Point(42, 25);
            txt_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new System.Drawing.Size(40, 15);
            txt_nome.TabIndex = 14;
            txt_nome.Text = "Nome";
            txt_nome.Visible = false;
            // 
            // FormBuscarDisciplinasProfessores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(540, 500);
            Controls.Add(txt_nome);
            Controls.Add(txt_habilidades);
            Controls.Add(txt_disciplina);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_sair);
            Controls.Add(btn_voltar);
            Controls.Add(btn_limpar);
            Controls.Add(btn_buscar);
            Controls.Add(txt_id_disciplina);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_disciplinas);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormBuscarDisciplinasProfessores";
            Text = "Buscar disciplinas";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_disciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView_disciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_disciplina;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_disciplina;
        private System.Windows.Forms.TextBox txt_habilidades;
        public System.Windows.Forms.Label txt_nome;
    }
}