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

namespace GerenciadorDeTurmas.FormsAluno
{
    public partial class FormConsultarProfessoresAluno : Form
    {
        private Database db;
        public FormConsultarProfessoresAluno()
        {
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text);
            InitializeComponent();
            db = new Database();
            DataTable professores = db.BuscarProfessoresDeAluno(idAluno);

            dataGridView_professores.DataSource = professores;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialAluno telaInicial = new FormTelaInicialAluno();
            telaInicial.txt_nome.Text = txt_nome.Text;
            telaInicial.Show();
            this.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form_login formLogin = new form_login();
                formLogin.Show();
                this.Close();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_professor.Text = string.Empty;
            txt_id_professor.Text = string.Empty;

            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text);
            DataTable dt = db.BuscarProfessoresDeAluno(idAluno);
            dataGridView_professores.DataSource = dt;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text);
            if (txt_professor.Text != null)
            {
                String nomeProfessor = txt_professor.Text;
                DataTable resultado = db.BuscarProfessorDeAlunoPorNome(idAluno, nomeProfessor);

                dataGridView_professores.DataSource = resultado;
            }
            else if (txt_id_professor != null)
            {
                String idProfessor = txt_id_professor.Text.ToString();
                DataTable resultado = db.BuscarProfessorDeAlunoPorId(idAluno, idProfessor);

                dataGridView_professores.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, preencha ao menos um dos campos para buscar por um professor.");
            }
        }
    }
}
