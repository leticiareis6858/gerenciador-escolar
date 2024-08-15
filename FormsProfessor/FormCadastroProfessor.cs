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
    public partial class FormCadastroProfessor : Form
    {
        public FormCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String nome=txt_nome.Text.Trim();
            String email=txt_email.Text.Trim();
            String senha=txt_senha.Text.Trim();
            String formacao=txt_formacao.Text.Trim();
            String titulacao=txt_titulacao.Text.Trim();

            if(!nome.Equals("") && !email.Equals("") && !senha.Equals("") && !formacao.Equals("") && !titulacao.Equals(""))
            {
                Database db = new Database();
                db.cadastrarProfessor(nome, email, senha, formacao, titulacao);
                MessageBox.Show("Professor cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            txt_formacao.Clear();
            txt_titulacao.SelectedItem = null;
        }
    }
}
