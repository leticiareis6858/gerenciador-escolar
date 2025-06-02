using GerenciadorDeTurmas.FormsAluno;
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
    public partial class FormTelaInicialAluno : Form
    {
        public FormTelaInicialAluno()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            form_login formLogin=new form_login();
            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btn_inscrever_curso_Click(object sender, EventArgs e)
        {
            FormInscreverseCurso formInscreverCurso= new FormInscreverseCurso();
            formInscreverCurso.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formInscreverCurso.ShowDialog();
            this.Close();
        }

        private void btn_verificar_cursos_Click(object sender, EventArgs e)
        {
            FormBuscarCursosAlunos formCursosAluno=new FormBuscarCursosAlunos();
            formCursosAluno.txt_nome.Text= txt_nome.Text;
            this.Hide();
            formCursosAluno.ShowDialog();
            this.Close();
        }

        private void btn_verificar_disciplinas_Click(object sender, EventArgs e)
        {
            FormBuscarDisciplinasAlunos formDisciplinasAluno = new FormBuscarDisciplinasAlunos();
            formDisciplinasAluno.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formDisciplinasAluno.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_informacoes_Click(object sender, EventArgs e)
        {
            FormAtualizarCadastroAlunos formAtualizarAluno= new FormAtualizarCadastroAlunos();
            txt_nome.Text = formAtualizarAluno.txt_nome.Text;
            formAtualizarAluno.ShowDialog();
            this.Close();
        }

        private void btn_verificar_professores_Click(object sender, EventArgs e)
        {
            FormConsultarProfessoresAluno formConsultarProfessores= new FormConsultarProfessoresAluno();
            formConsultarProfessores.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formConsultarProfessores.ShowDialog();
            this.Close();
        }

        private void btn_inscrever_Click(object sender, EventArgs e)
        {
            FormInscreverseCurso formInscreverCurso = new FormInscreverseCurso();
            formInscreverCurso.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formInscreverCurso.ShowDialog();
            this.Close();
        }
    }
}
