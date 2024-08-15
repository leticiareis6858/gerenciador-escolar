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
        public FormTelaInicialProfessor()
        {
            InitializeComponent();
        }

        private void btn_disciplinas_Click(object sender, EventArgs e)
        {
            FormBuscarDisciplinasProfessores formDisciplinas = new FormBuscarDisciplinasProfessores();
            formDisciplinas.ShowDialog();
            this.Close();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            FormBuscarCursosProfessores formCursos = new FormBuscarCursosProfessores();
            formCursos.ShowDialog();
            this.Close();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            FormVerificarAtrelamentosProfessores formVerificar= new FormVerificarAtrelamentosProfessores();
            formVerificar.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastroProfessores formAtualizar= new FormAtualizarCadastroProfessores();
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
