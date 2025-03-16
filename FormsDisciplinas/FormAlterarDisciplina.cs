using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEscolar.FormsDisciplinas
{
    public partial class FormAlterarDisciplina : Form
    {
        private Database db;
        public FormAlterarDisciplina()
        {
            InitializeComponent();
            db = new Database();
            txt_novoNomeDisciplina.Enabled = false;
            btn_alterarNome.Enabled = false;
            btn_removerHabilidades.Enabled = false;
            list_habilidades.Enabled = false;
        }

        private void btn_buscarDisciplina_Click(object sender, EventArgs e)
        {
            string nomeDisciplina = txt_nomeDisciplina.Text;

            if (string.IsNullOrEmpty(nomeDisciplina))
            {
                MessageBox.Show("Informe o nome da disciplina!");
            }
            else if (db.BuscarDisciplinaPorNome(nomeDisciplina) == null)
            {
                MessageBox.Show("Disciplina não encontrada!");
            }
            else
            {
                txt_novoNomeDisciplina.Enabled = true;
                btn_alterarNome.Enabled = true;
                btn_removerHabilidades.Enabled = true;
                list_habilidades.Items.Add(db.BuscarHabilidadesPorDisciplina(nomeDisciplina));
                list_habilidades.Enabled = true;
                list_habilidades.SelectionMode = SelectionMode.MultiSimple;
            }
        }

        private void btn_alterarNome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_novoNomeDisciplina.Text))
            {
                MessageBox.Show("Informe o novo nome da disciplina!");
            }
            else
            {
                string nomeDisciplina = txt_nomeDisciplina.Text;
                string novoNomeDisciplina = txt_novoNomeDisciplina.Text;
                db.AlterarNomeDisciplina(nomeDisciplina, novoNomeDisciplina);
                MessageBox.Show("Nome da disciplina alterado com sucesso!");
                txt_nomeDisciplina.Text = novoNomeDisciplina;
            }
        }

        private void btn_removerHabilidades_Click(object sender, EventArgs e)
        {

        }
    }
}
