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

namespace GerenciadorDeTurmas.FormsAluno
{
    public partial class FormAtualizarCadastroAlunos : Form
    {
        private Database db;
        public FormAtualizarCadastroAlunos()
        {
            InitializeComponent();
            db= new Database();
            txt_email.Text = db.BuscarEmailAlunoPorNome(txt_nome.Text);
            txt_senha.Text = db.BuscarSenhaAlunoPorNome(txt_nome.Text);
            txt_telefone.Text = db.BuscarTelefoneAlunoPorNome(txt_nome.Text);
            txt_cidade.Text = db.BuscarCidadeAlunoPorNome(txt_nome.Text);
            txt_endereco.Text = db.BuscarEnderecoAlunoPorNome(txt_nome.Text);
            txt_data_nasc.Value = db.BuscarDataNascAlunoPorNome(txt_nome.Text);

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_telefone.Clear();
            txt_senha.Clear();
            txt_cidade.Clear();
            txt_endereco.Clear();
            txt_data_nasc.Value = DateTime.Now;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialAluno formTelaInicial = new FormTelaInicialAluno();
            formTelaInicial.txt_nome.Text = txt_nome.Text;
            this.Hide();
            formTelaInicial.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            String data = DateTime.Now.ToString();
           
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_telefone.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(txt_cidade.Text) || string.IsNullOrEmpty(txt_endereco.Text) || txt_data_nasc.Value==DateTime.Now)
            {
                MessageBox.Show("Preencha ao menos um dos campos!");
            }
            else if (txt_data_nasc.Value.ToString() == data)
            {
                MessageBox.Show("A data de nascimento não pode ser igual a data atual!");
            }
            else if (!string.IsNullOrEmpty(txt_email.Text))
            {
                db.AtualizarEmailAluno(txt_nome.Text, txt_email.Text);
                MessageBox.Show("Email atualizado com sucesso!");
            }
            else if (!string.IsNullOrEmpty(txt_telefone.Text))
            {
                db.AtualizarTelefoneAluno(txt_nome.Text, txt_telefone.Text);
                MessageBox.Show("Telefone atualizado com sucesso!");
            }
            else if (!string.IsNullOrEmpty(txt_senha.Text))
            {
                db.AtualizarSenhaAluno(txt_nome.Text, txt_senha.Text);
                MessageBox.Show("Senha atualizada com sucesso!");
            }
            else if (!string.IsNullOrEmpty(txt_cidade.Text))
            {
                db.AtualizarCidadeAluno(txt_nome.Text, txt_cidade.Text);
                MessageBox.Show("Cidade atualizada com sucesso!");
            }
            else if (!string.IsNullOrEmpty(txt_endereco.Text))
            {
                db.AtualizarEnderecoAluno(txt_nome.Text, txt_endereco.Text);
                MessageBox.Show("Endereço atualizado com sucesso!");
            }
            else if (txt_data_nasc.Value != DateTime.Now)
            {
                String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                db.AtualizarDataNascAluno(txt_nome.Text, data_nasc);
                MessageBox.Show("Data de nascimento atualizada com sucesso!");
            }
            else if (!string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_telefone.Text) && !string.IsNullOrEmpty(txt_senha.Text) && !string.IsNullOrEmpty(txt_cidade.Text) && !string.IsNullOrEmpty(txt_endereco.Text) && txt_data_nasc.Value != DateTime.Now)
            {
                String data_nasc = txt_data_nasc.Value.ToString("dd-MM-yyyy").Trim();
                db.AtualizarAluno(txt_nome.Text, txt_email.Text, txt_telefone.Text, txt_senha.Text, txt_cidade.Text, txt_endereco.Text, data_nasc);
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }
        }
    }
}
