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

namespace GerenciadorDeTurmas.FormsProfessor
{
    public partial class FormVerificarAtrelamentosProfessores : Form
    {
        private Database db;
        public FormVerificarAtrelamentosProfessores()
        {
            InitializeComponent();
            db= new Database();

            String nome = txt_nome.Text;
            int idProfessor = db.BuscarIdProfessorPorNome(nome);

            DataTable dt_disciplinas = db.BuscarDisciplinasProfessorPorId(idProfessor);
            dataGridView_disciplinas.DataSource = dt_disciplinas;

            DataTable dt_cursos=db.BuscarCursosProfessorPorId(idProfessor);
            dataGridView_cursos.DataSource = dt_cursos;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialProfessor formInicial= new FormTelaInicialProfessor();
            formInicial.txt_nome.Text = txt_nome.Text;
            formInicial.txt_titulacao.Text = txt_titulacao.Text;
            formInicial.ShowDialog();
            this.Close();

        }
    }
}
