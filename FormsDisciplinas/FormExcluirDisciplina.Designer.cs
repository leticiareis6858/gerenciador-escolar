namespace GerenciadorEscolar.FormsDisciplinas
{
    partial class FormExcluirDisciplina
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
            btn_voltar = new System.Windows.Forms.Button();
            list_disciplinas = new System.Windows.Forms.ListBox();
            btn_excluir = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_voltar.Location = new System.Drawing.Point(303, 14);
            btn_voltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new System.Drawing.Size(91, 35);
            btn_voltar.TabIndex = 50;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // list_disciplinas
            // 
            list_disciplinas.FormattingEnabled = true;
            list_disciplinas.ItemHeight = 15;
            list_disciplinas.Location = new System.Drawing.Point(35, 115);
            list_disciplinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            list_disciplinas.Name = "list_disciplinas";
            list_disciplinas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            list_disciplinas.Size = new System.Drawing.Size(331, 259);
            list_disciplinas.TabIndex = 52;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_excluir.Location = new System.Drawing.Point(78, 397);
            btn_excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new System.Drawing.Size(240, 35);
            btn_excluir.TabIndex = 53;
            btn_excluir.Text = "Excluir selecionada(s)";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(35, 63);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 36);
            label1.TabIndex = 54;
            label1.Text = "Selecione as disciplinas a serem\r\n excluidas:";
            // 
            // FormExcluirDisciplina
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(408, 445);
            Controls.Add(label1);
            Controls.Add(btn_excluir);
            Controls.Add(list_disciplinas);
            Controls.Add(btn_voltar);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormExcluirDisciplina";
            Text = "Excluir Disciplina";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ListBox list_disciplinas;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label label1;
    }
}