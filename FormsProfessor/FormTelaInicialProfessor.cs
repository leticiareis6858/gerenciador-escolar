using GerenciadorDeTurmas.FormsCursos;
using GerenciadorDeTurmas.FormsProfessor;
using GerenciadorEscolar.FormsProfessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEscolar
{
    public partial class FormTelaInicialProfessor : Form
    {
        private Database db;
        public FormTelaInicialProfessor()
        {
            InitializeComponent();
            db=new Database();
            txt_titulacao.Text=db.ObterTitulacaoPorNome(txt_nome.Text);
        }

        private void btn_disciplinas_Click(object sender, EventArgs e)
        {
            FormBuscarDisciplinasProfessores formDisciplinas = new FormBuscarDisciplinasProfessores();
            formDisciplinas.txt_nome.Text = txt_nome.Text;
            formDisciplinas.ShowDialog();
            this.Close();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            FormBuscarCursosProfessores formCursos = new FormBuscarCursosProfessores();
            formCursos.txt_nome.Text = txt_nome.Text;
            formCursos.ShowDialog();
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            FormVerificarAtrelamentosProfessores formVerificar= new FormVerificarAtrelamentosProfessores();
            formVerificar.txt_nome.Text = txt_nome.Text;
            formVerificar.txt_titulacao.Text = txt_titulacao.Text;
            formVerificar.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastroProfessores formAtualizar= new FormAtualizarCadastroProfessores();
            formAtualizar.txt_nome.Text = txt_nome.Text;
            formAtualizar.ShowDialog();
            this.Close();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            form_login formLogin=new form_login();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
