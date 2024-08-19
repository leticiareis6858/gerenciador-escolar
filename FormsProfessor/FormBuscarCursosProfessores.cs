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
    public partial class FormBuscarCursosProfessores : Form
    {
        private Database db;
        public FormBuscarCursosProfessores()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialProfessor telaInicial = new FormTelaInicialProfessor();
            telaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id_curso.Text = string.Empty;
            txt_curso.Text = string.Empty;
           txt_disciplina.Text = string.Empty;

            DataTable dt = db.BuscarDisciplinas();
            dataGridView_cursos.DataSource = dt;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_id_curso.Text))
            {
                int id = int.Parse(txt_id_curso.Text.Trim());
                DataTable resultado = db.BuscarCursoPorId(id);

                dataGridView_cursos.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_curso.Text))
            {
                String nome = txt_curso.Text.Trim();
                DataTable resultado = db.BuscarCursoPorNome(nome);

                dataGridView_cursos.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_disciplina.Text))
            {
                String disciplina = txt_disciplina.Text.Trim();
                DataTable resultado = db.BuscarCursoPorDisciplina(disciplina);

                dataGridView_cursos.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_id_curso.Text) &&
                     !string.IsNullOrWhiteSpace(txt_curso.Text) &&
                     !string.IsNullOrWhiteSpace(txt_disciplina.Text))
            {
                int id = int.Parse(txt_id_curso.Text.Trim());
                String nome = txt_curso.Text.Trim();
                String disciplina = txt_disciplina.Text.Trim();

                DataTable resultado = db.BuscarCurso(nome, id, disciplina);

                dataGridView_cursos.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, preencha ao menos um dos campos para buscar por um curso.");
            }
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                form_login form_login = new form_login();
                this.Hide();
                form_login.ShowDialog();
                this.Close();
            }
        }
    }
}
