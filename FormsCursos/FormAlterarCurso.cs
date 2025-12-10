using GerenciadorDeTurmas.FormsDirecao;
using GerenciadorEscolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTurmas.FormsCursos
{
    public partial class FormAlterarCurso : Form
    {
        private Database db;
        public FormAlterarCurso()
        {
            InitializeComponent();

            db = new Database();
            txt_novoNomeCurso.Enabled = false;
            btn_alterarNome.Enabled = false;
            btn_alterarPeriodos.Enabled = false;
            comboPeriodos.Enabled = false;
        }

        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            btn_buscarCurso = new Button();
            txt_nomeCurso = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txt_novoNomeCurso = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btn_alterarNome = new Button();
            groupBox1 = new GroupBox();
            comboPeriodos = new ComboBox();
            btn_alterarPeriodos = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_voltar = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_buscarCurso);
            groupBox3.Controls.Add(txt_nomeCurso);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(13, 27);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(372, 171);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btn_buscarCurso
            // 
            btn_buscarCurso.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscarCurso.Location = new Point(18, 119);
            btn_buscarCurso.Margin = new Padding(4, 3, 4, 3);
            btn_buscarCurso.Name = "btn_buscarCurso";
            btn_buscarCurso.Size = new Size(293, 27);
            btn_buscarCurso.TabIndex = 3;
            btn_buscarCurso.Text = "Buscar";
            btn_buscarCurso.UseVisualStyleBackColor = true;
            btn_buscarCurso.Click += btn_buscarCurso_Click;
            // 
            // txt_nomeCurso
            // 
            txt_nomeCurso.Location = new Point(22, 89);
            txt_nomeCurso.Margin = new Padding(4, 3, 4, 3);
            txt_nomeCurso.Name = "txt_nomeCurso";
            txt_nomeCurso.Size = new Size(288, 23);
            txt_nomeCurso.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 1;
            label4.Text = "Informe o nome do curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 20);
            label3.TabIndex = 0;
            label3.Text = "Buscar o curso a ser alterado";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_novoNomeCurso);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btn_alterarNome);
            groupBox2.Location = new Point(13, 221);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(372, 188);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // txt_novoNomeCurso
            // 
            txt_novoNomeCurso.Location = new Point(12, 81);
            txt_novoNomeCurso.Margin = new Padding(4, 3, 4, 3);
            txt_novoNomeCurso.Name = "txt_novoNomeCurso";
            txt_novoNomeCurso.Size = new Size(293, 23);
            txt_novoNomeCurso.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 46);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 15);
            label6.TabIndex = 2;
            label6.Text = "Informe o novo nome do curso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 20);
            label5.TabIndex = 1;
            label5.Text = "Mudar nome do curso";
            // 
            // btn_alterarNome
            // 
            btn_alterarNome.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_alterarNome.Location = new Point(13, 128);
            btn_alterarNome.Margin = new Padding(4, 3, 4, 3);
            btn_alterarNome.Name = "btn_alterarNome";
            btn_alterarNome.Size = new Size(288, 27);
            btn_alterarNome.TabIndex = 0;
            btn_alterarNome.Text = "Alterar nome";
            btn_alterarNome.UseVisualStyleBackColor = true;
            btn_alterarNome.Click += btn_alterarNome_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboPeriodos);
            groupBox1.Controls.Add(btn_alterarPeriodos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(393, 85);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(291, 255);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // comboPeriodos
            // 
            comboPeriodos.FormattingEnabled = true;
            comboPeriodos.Items.AddRange(new object[] { "1 período", "2 períodos", "3 períodos", "4 períodos", "5 períodos", "6 períodos", "7 períodos", "8 períodos", "9 períodos", "10 períodos", "11 períodos", "12 períodos", "13 períodos", "14 períodos" });
            comboPeriodos.Location = new Point(22, 102);
            comboPeriodos.Name = "comboPeriodos";
            comboPeriodos.Size = new Size(243, 23);
            comboPeriodos.TabIndex = 4;
            // 
            // btn_alterarPeriodos
            // 
            btn_alterarPeriodos.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_alterarPeriodos.Location = new Point(52, 143);
            btn_alterarPeriodos.Margin = new Padding(4, 3, 4, 3);
            btn_alterarPeriodos.Name = "btn_alterarPeriodos";
            btn_alterarPeriodos.Size = new Size(173, 40);
            btn_alterarPeriodos.TabIndex = 3;
            btn_alterarPeriodos.Text = "Alterar";
            btn_alterarPeriodos.UseVisualStyleBackColor = true;
            btn_alterarPeriodos.Click += btn_alterarPeriodos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 30);
            label2.TabIndex = 1;
            label2.Text = "Selecione a nova quantidade de períodos do \r\ncurso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Alterar duração";
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voltar.Location = new Point(593, 27);
            btn_voltar.Margin = new Padding(4, 3, 4, 3);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(91, 35);
            btn_voltar.TabIndex = 55;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FormAlterarCurso
            // 
            ClientSize = new Size(697, 443);
            Controls.Add(btn_voltar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FormAlterarCurso";
            Text = "Alterar curso";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaCursos formCursos = new FormTelaCursos();
            this.Hide();
            formCursos.ShowDialog();
            this.Close();
        }

        private void btn_buscarCurso_Click(object sender, EventArgs e)
        {
            string nomeCurso = txt_nomeCurso.Text;

            if (string.IsNullOrEmpty(nomeCurso))
            {
                MessageBox.Show("Informe o nome do curso!");
            }
            else if (db.BuscarCursoPorNome(nomeCurso) == null)
            {
                MessageBox.Show("Curso não encontrado!");
            }
            else
            {
                txt_novoNomeCurso.Enabled = true;
                btn_alterarNome.Enabled = true;
                btn_alterarPeriodos.Enabled = true;
            }
        }


        private void btn_alterarNome_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_novoNomeCurso.Text))
            {
                MessageBox.Show("Informe o novo nome do curso!");
            }
            else
            {
                string nomeCurso = txt_nomeCurso.Text;
                string novoNomeCurso = txt_novoNomeCurso.Text;
                db.AlterarNomeCurso(nomeCurso, novoNomeCurso);
                MessageBox.Show("Nome do curso alterado com sucesso!");
                txt_nomeCurso.Text = novoNomeCurso;

            }
        }

        private void btn_alterarPeriodos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboPeriodos.Text))
            {
                MessageBox.Show("Selecione a quantidade de períodos do curso!");
            }
            else
            {
                string nomeCurso = txt_nomeCurso.Text;
                string texto = comboPeriodos.SelectedItem.ToString();
                int quantidade = int.Parse(texto.Split(' ')[0]);
                db.AlterarPeriodosCurso(nomeCurso,quantidade);
                MessageBox.Show("Quantidade de períodos alterada com sucesso!");

                comboPeriodos.SelectedIndex= -1;
               
            }
        }
    }
}
