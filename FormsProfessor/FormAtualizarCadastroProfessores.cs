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

namespace GerenciadorDeTurmas.FormsProfessor
{
    public partial class FormAtualizarCadastroProfessores : Form
    {
        private Database db;
        public FormAtualizarCadastroProfessores()
        {
            InitializeComponent();
            db = new Database();
            int id=db.BuscarIdProfessorPorNome(txt_nome.Text);
            txt_formacao.Text = db.BuscarFormacaoProfessorPorNome(txt_nome.Text);
            txt_titulacao.Text = db.BuscarTitulacaoProfessorPorNome(txt_nome.Text);
            txt_email.Text = db.BuscarEmailProfessorPorNome(txt_nome.Text);
            txt_senha.Text = db.BuscarSenhaProfessorPorNome(txt_nome.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_senha.Clear();
            txt_formacao.Clear();
            txt_titulacao.SelectedItem = null;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialProfessor formTelaInicial = new FormTelaInicialProfessor();
            formTelaInicial.ShowDialog();
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if(txt_email.Text==null||txt_senha.Text==null||txt_formacao==null||txt_titulacao.SelectedItem==null)
            {
                MessageBox.Show("Preencha ao menos um dos campos!");
            } else if(txt_email.Text!=null)
            {
                db.AtualizarEmailProfessor(txt_nome.Text, txt_email.Text);
                MessageBox.Show("Email atualizado com sucesso!");
            } else if(txt_senha!=null)
            {
                db.AtualizarSenhaProfessor(txt_nome.Text, txt_senha.Text);
                MessageBox.Show("Senha atualizada com sucesso!");
            } else if(txt_formacao!=null)
            {
                db.AtualizarFormacaoProfessor(txt_nome.Text, txt_formacao.Text);
                MessageBox.Show("Formação atualizada com sucesso!");
            } else if(txt_titulacao.SelectedItem!=null)
            {
                db.AtualizarTitulacaoProfessor(txt_nome.Text, txt_titulacao.SelectedItem.ToString());
                MessageBox.Show("Titulação atualizada com sucesso!");
            } else if(txt_email.Text != null || txt_senha.Text != null || txt_formacao != null || txt_titulacao.SelectedItem != null)
            {
                db.AtualizarProfessor(txt_nome.Text,txt_email.Text, txt_senha.Text, txt_formacao.Text, txt_titulacao.Text);
                MessageBox.Show("Cadastro atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar!");
            }

        }
    }
}
