using GerenciadorDeTurmas.FormsAluno;
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

namespace GerenciadorDeTurmas.FormsDirecao
{
    public partial class FormTelaInicialDirecao : Form
    {
        public FormTelaInicialDirecao()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            form_login formLogin = new form_login();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btn_disciplinas_Click(object sender, EventArgs e)
        {
            FormTelaDisciplinas formTelaDisciplinas= new FormTelaDisciplinas();
            this.Hide();
            formTelaDisciplinas.ShowDialog();
            this.Close();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            FormTelaCursos formTelaCursos = new FormTelaCursos();
            this.Hide();
            formTelaCursos.ShowDialog();
            this.Close();
        }

        private void btn_verificar_professores_Click(object sender, EventArgs e)
        {
            FormTelaProfessores formTelaProfessores = new FormTelaProfessores();
            this.Hide();
            formTelaProfessores.ShowDialog();
            this.Close();
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            FormTelaAlunos formTelaAlunos = new FormTelaAlunos();
            this.Hide();
            formTelaAlunos.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_informacoes_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastro formAtualizarCadastro = new FormAtualizarCadastro();
            this.Hide();
            formAtualizarCadastro.ShowDialog();
            this.Close();
        }
    }
}
