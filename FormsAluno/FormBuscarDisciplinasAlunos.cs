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
    public partial class FormBuscarDisciplinasAlunos : Form
    {
        private Database db;
        public FormBuscarDisciplinasAlunos()
        {
            InitializeComponent();
            db = new Database();
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text);
            DataTable disciplinas = db.BuscarDisciplinasAluno(idAluno);

            dataGridView_disciplinas.DataSource = disciplinas;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form_login formLogin = new form_login();
                this.Hide();
                formLogin.ShowDialog();
                this.Close();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id_disciplina.Text = string.Empty;
            txt_disciplina.Text = string.Empty;

            DataTable dt = db.BuscarDisciplinas();
            dataGridView_disciplinas.DataSource = dt;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialAluno telaInicialAluno = new FormTelaInicialAluno();
            telaInicialAluno.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicialAluno.ShowDialog();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text.Trim());

            if (!string.IsNullOrWhiteSpace(txt_disciplina.Text))
            {
                String nomeDisciplina = txt_disciplina.Text.Trim();
                DataTable resultado = db.BuscarDisciplinaDeAlunoPorNome(nomeDisciplina, idAluno);

                dataGridView_disciplinas.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_id_disciplina.Text))
            {
                int idDisciplina = int.Parse(txt_id_disciplina.Text.Trim());
                DataTable resultado = db.BuscarDisciplinaDeAlunoPorId(idDisciplina, idAluno);

                dataGridView_disciplinas.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, preencha ao menos um dos campos para buscar por uma disciplina.");
            }
        }

    }
}
