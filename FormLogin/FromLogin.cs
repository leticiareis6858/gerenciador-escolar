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
            if (txt_usuario.Text == null)
            {
                MessageBox.Show("Informe um nome de usuário");
            }
            else if (txt_senha.Text == null) {
                MessageBox.Show("Informe uma senha");
            }

            string usuario = txt_usuario.Text.Trim();
            string senha = txt_senha.Text.Trim();

            bool alunoValido = db.verificarLoginAluno(usuario, senha);
            bool professorValido = db.verificarLoginProfessor(usuario, senha);

            if (alunoValido)
            {
                FormTelaInicialAluno formTelaInicialAluno = new FormTelaInicialAluno();
                formTelaInicialAluno.Show();
                this.Close();

            } else if (professorValido)
            {
                FormTelaInicialProfessor formTelaInicialProfessor = new FormTelaInicialProfessor();
                formTelaInicialProfessor.Show();
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
            formCadastro.Show();
            this.Close();
        }

        private void link_mudar_senha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarSenha formRecuperarSenha = new FormRecuperarSenha();
            formRecuperarSenha.Show();
            this.Close();
        }
    }
}
