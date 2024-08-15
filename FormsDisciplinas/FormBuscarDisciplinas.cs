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

namespace GerenciadorDeTurmas.FormsDisciplinas
{
    public partial class FormBuscarDisciplinas : Form
    {
        private Database db;

        public FormBuscarDisciplinas()
        {
            InitializeComponent();
            db = new Database();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = db.GetDisciplinas();
            dataGridView_disciplinas.DataSource = dt;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_id_disciplina!=null)
            {
                int id = int.Parse(txt_id_disciplina.Text);
                DataTable resultado = db.BuscarDisciplinaPorId(id);

                dataGridView_disciplinas.DataSource = resultado;
            } else if(txt_disciplina!=null)
            {
                String nome=txt_disciplina.Text;
                DataTable resultado = db.BuscarDisciplinaPorNome(nome);

                dataGridView_disciplinas.DataSource= resultado;
            } else if(txt_habilidades!=null)
            {
                String habilidade=txt_habilidades.Text;
                DataTable resultado = db.BuscarDisciplinaPorHabilidade(habilidade);

                dataGridView_disciplinas.DataSource = resultado;
            } else if(txt_id_disciplina!=null && txt_disciplina!=null && txt_habilidades!=null)
            {
                int id = int.Parse(txt_id_disciplina.Text);
                String nome = txt_disciplina.Text;
                String habilidade=txt_habilidades.Text;

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

        }
    }
}
