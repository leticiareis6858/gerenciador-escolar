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
    public partial class FormBuscarCursosAlunos : Form
    {
        private Database db;
        public FormBuscarCursosAlunos()
        {
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text);
            InitializeComponent();
            db = new Database();
            DataTable cursos = db.BuscarCursosAluno(idAluno);

            dataGridView_cursos.DataSource = cursos;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            String idAluno = db.BuscarIdAlunoPorNome(txt_nome.Text.Trim());

            if (!string.IsNullOrWhiteSpace(txt_curso.Text))
            {
                String nomeCurso = txt_curso.Text.Trim();
                DataTable resultado = db.BuscarCursoDeAlunoPorNome(nomeCurso, idAluno);

                dataGridView_cursos.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_id_curso.Text))
            {
                int idCurso = int.Parse(txt_id_curso.Text.Trim());
                DataTable resultado = db.BuscarCursoDeAlunoPorId(idCurso, idAluno);

                dataGridView_cursos.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, preencha ao menos um dos campos para buscar por um curso.");
            }
        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialAluno telaInicial= new FormTelaInicialAluno();
            telaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
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
            txt_curso.Text = string.Empty;
            txt_id_curso.Text = string.Empty;

            DataTable dt = db.BuscarCursos();
            dataGridView_cursos.DataSource = dt;
        }

    }
}
