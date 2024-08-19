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
    public partial class FormCadastroDisciplina : Form
    {
        private Database db;
        public FormCadastroDisciplina()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String disciplina = txt_nome_disciplina.Text.Trim();
            String habilidades = txt_habilidades.Text.Trim();

            if (!disciplina.Equals("") && !habilidades.Equals(""))
            {
                db.CadastrarDisciplina(disciplina, habilidades);
                MessageBox.Show("Disciplina cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
    }
}
