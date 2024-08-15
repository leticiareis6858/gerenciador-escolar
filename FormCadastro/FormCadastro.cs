using System;
using GerenciadorEscolar;
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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            form_login formLogin=new form_login();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            String escolha=txt_escolha.Text;

            if(escolha=="professor")
            {
                FormCadastroProfessor formCadastroProfessor=new FormCadastroProfessor();
                formCadastroProfessor.ShowDialog();
                this.Close();
            } else if (escolha == "aluno")
            {
                FormCadastroAluno formCadastroAluno=new FormCadastroAluno();
                formCadastroAluno.ShowDialog();
                this.Close();
            } else if(escolha=="disciplina")
            {
                FormCadastroDisciplina formCadastroDisciplina=new FormCadastroDisciplina();
                formCadastroDisciplina.ShowDialog();
                this.Close();
            } else if (escolha == "curso")
            {
                FormCadastroCurso formCadastroCurso=new FormCadastroCurso();
                formCadastroCurso.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Por favor, infome o que deseja cadastrar.");
            }
           
        }
    }
}
