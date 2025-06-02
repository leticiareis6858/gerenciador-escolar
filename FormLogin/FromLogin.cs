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

namespace GerenciadorEscolar
{
    public partial class form_login : Form
    {
        private Database db;
        public form_login()
        {
            InitializeComponent();
            db = new Database();
            db.CreateTables(); 
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == null)
            {
                MessageBox.Show("Informe um email");
            }
            else if (txt_senha.Text == null) {
                MessageBox.Show("Informe uma senha");
            }

            string email = txt_email.Text.Trim();
            string senha = txt_senha.Text.Trim();

            bool alunoValido = db.verificarLoginAluno(email, senha);
            bool professorValido = db.verificarLoginProfessor(email, senha);

            if (alunoValido)
            {
                FormTelaInicialAluno formTelaInicialAluno = new FormTelaInicialAluno();
                formTelaInicialAluno.txt_nome.Text=db.BuscarNomePorEmailAluno(email);
                this.Hide();
                formTelaInicialAluno.ShowDialog();
                this.Close();

            } else if (professorValido)
            {
                FormTelaInicialProfessor formTelaInicialProfessor = new FormTelaInicialProfessor();
                formTelaInicialProfessor.txt_nome.Text=db.BuscarNomePorEmailProfessor(email);
                formTelaInicialProfessor.txt_titulacao.Text = db.BuscarTitulacaoProfessorPorNome(db.BuscarNomePorEmailProfessor(email));
                this.Hide();
                formTelaInicialProfessor.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou usuário inválidos!");
            }
        }

        private void link_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void link_mudar_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarSenha formRecuperarSenha = new FormRecuperarSenha();
            formRecuperarSenha.txt_email.Text= txt_email.Text;
            this.Hide();
            formRecuperarSenha.ShowDialog();
            this.Close();
        }
    }
}
