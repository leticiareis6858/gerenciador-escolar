namespace GerenciadorDeTurmas.FormsCursos
{
    partial class FormExcluirCurso
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
            label1 = new System.Windows.Forms.Label();
            list_cursos = new System.Windows.Forms.ListBox();
            btn_excluir = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_voltar.Location = new System.Drawing.Point(290, 12);
            btn_voltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new System.Drawing.Size(91, 35);
            btn_voltar.TabIndex = 51;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(23, 50);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(358, 18);
            label1.TabIndex = 55;
            label1.Text = "Selecione o(s) curso(s) a ser(em) excluido(s):";
            // 
            // list_cursos
            // 
            list_cursos.FormattingEnabled = true;
            list_cursos.ItemHeight = 15;
            list_cursos.Location = new System.Drawing.Point(39, 71);
            list_cursos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            list_cursos.Name = "list_cursos";
            list_cursos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            list_cursos.Size = new System.Drawing.Size(331, 289);
            list_cursos.TabIndex = 56;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_excluir.Location = new System.Drawing.Point(90, 381);
            btn_excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new System.Drawing.Size(240, 35);
            btn_excluir.TabIndex = 57;
            btn_excluir.Text = "Excluir selecionado(s)";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // FormExcluirCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(408, 445);
            Controls.Add(btn_excluir);
            Controls.Add(list_cursos);
            Controls.Add(label1);
            Controls.Add(btn_voltar);
            Name = "FormExcluirCurso";
            Text = "Excluir Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_cursos;
        private System.Windows.Forms.Button btn_excluir;
    }
}