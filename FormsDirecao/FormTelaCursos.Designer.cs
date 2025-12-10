namespace GerenciadorDeTurmas.FormsDirecao
{
    partial class FormTelaCursos
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
            btn_sair = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btn_cadastro = new System.Windows.Forms.Button();
            btn_alterar = new System.Windows.Forms.Button();
            btn_excluir = new System.Windows.Forms.Button();
            btn_buscar = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sair
            // 
            btn_sair.Location = new System.Drawing.Point(585, 28);
            btn_sair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new System.Drawing.Size(88, 27);
            btn_sair.TabIndex = 17;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_buscar);
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(btn_alterar);
            groupBox1.Controls.Add(btn_cadastro);
            groupBox1.Location = new System.Drawing.Point(68, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(582, 336);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "O que deseja fazer?";
            // 
            // btn_cadastro
            // 
            btn_cadastro.Location = new System.Drawing.Point(33, 43);
            btn_cadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new System.Drawing.Size(186, 97);
            btn_cadastro.TabIndex = 7;
            btn_cadastro.Text = "Cadastrar cursos";
            btn_cadastro.UseVisualStyleBackColor = true;
            btn_cadastro.Click += btn_cadastro_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new System.Drawing.Point(348, 43);
            btn_alterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new System.Drawing.Size(186, 97);
            btn_alterar.TabIndex = 8;
            btn_alterar.Text = "Alterar cursos";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_excluir.Location = new System.Drawing.Point(33, 184);
            btn_excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new System.Drawing.Size(186, 97);
            btn_excluir.TabIndex = 9;
            btn_excluir.Text = "Excluir cursos";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_buscar.Location = new System.Drawing.Point(348, 184);
            btn_buscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new System.Drawing.Size(186, 97);
            btn_buscar.TabIndex = 10;
            btn_buscar.Text = "Buscar cursos";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // FormTelaCursos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 460);
            Controls.Add(groupBox1);
            Controls.Add(btn_sair);
            Name = "FormTelaCursos";
            Text = "Gerenciar cursos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_buscar;
    }
}