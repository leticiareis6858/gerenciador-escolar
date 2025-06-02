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
    public partial class FormRecuperarSenha : Form
    {
        private Database db;

        public FormRecuperarSenha()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            form_login formLogin=new form_login();

            this.Hide();
            formLogin.ShowDialog();
            this.Close();
        }

        private void btn_mudar_Click(object sender, EventArgs e)
        {
            String nome=txt_nome.Text.Trim();
            String email=txt_email.Text.Trim();
            String novaSenha = txt_nova_senha.Text.Trim();

            bool alunoValido = db.verificarNomeEmailAluno(nome, email);
            bool professorValido = db.verificarNomeEmailProfessor(nome, email);

            if(alunoValido)
            {
                bool mudarSenha = db.mudarSenhaAluno(email, novaSenha);
                MessageBox.Show("Senha alterada com sucesso!");
                
            } else if (professorValido)
            {
                bool mudarSenha = db.mudarSenhaProfessor(email, novaSenha);
                MessageBox.Show("Senha alterada com sucesso!");
            }
            else
            {
                MessageBox.Show("Nome de usuário e email inválidos!");
            }
        }
    }
}
