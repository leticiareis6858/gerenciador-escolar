using GerenciadorEscolar.FormsDisciplinas;
using GerenciadorEscolar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEscolar.FormsProfessor
{
    public partial class FormBuscarDisciplinasProfessores : Form
    {
        private Database db;

        public FormBuscarDisciplinasProfessores()
        {
            InitializeComponent();
            db = new Database();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = db.BuscarDisciplinas();
            dataGridView_disciplinas.DataSource = dt;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_id_disciplina.Text))
            {
                DataTable resultado = db.BuscarDisciplinaPorId(txt_id_disciplina.Text.Trim());
                dataGridView_disciplinas.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_disciplina.Text))
            {
                DataTable resultado = db.BuscarDisciplinaPorNome(txt_disciplina.Text.Trim());
                dataGridView_disciplinas.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_habilidades.Text))
            {
                DataTable resultado = db.BuscarDisciplinaPorHabilidade(txt_habilidades.Text.Trim());
                dataGridView_disciplinas.DataSource = resultado;
            }
            else if (!string.IsNullOrWhiteSpace(txt_id_disciplina.Text) && !string.IsNullOrWhiteSpace(txt_disciplina.Text) && !string.IsNullOrWhiteSpace(txt_habilidades.Text))
            {
                int id = int.Parse(txt_id_disciplina.Text.Trim());
                string nome = txt_disciplina.Text.Trim();
                string habilidade = txt_habilidades.Text.Trim();

                DataTable resultado = db.BuscarDisciplina(nome, id, habilidade);
                dataGridView_disciplinas.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, preencha ao menos um dos campos para buscar por uma disciplina.");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id_disciplina.Text = string.Empty;
            txt_disciplina.Text = string.Empty;
            txt_habilidades.Text = string.Empty;

            DataTable dt = db.BuscarDisciplinas();
            dataGridView_disciplinas.DataSource = dt;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialProfessor telaInicial=new FormTelaInicialProfessor();
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
                form_login form_login = new form_login();
                this.Hide();
                form_login.ShowDialog();
                this.Close();
            }
        }
    }
}
