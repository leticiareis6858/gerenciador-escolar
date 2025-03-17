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
using GerenciadorDeTurmas.FormsDirecao;

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
            if (list_habilidades.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma habilidade para remover!");
                return;
            }

            List<string> habilidadesARemover = new List<string>();

            foreach (var item in list_habilidades.SelectedItems)
            {
                habilidadesARemover.Add(item.ToString());
            }

            string nomeDisciplina = txt_nomeDisciplina.Text;
            db.RemoverHabilidadesDisciplina(nomeDisciplina, habilidadesARemover);

            MessageBox.Show("Habilidades removidas com sucesso!");

            list_habilidades.Items.Clear();
            var habilidadesAtualizadas = db.BuscarHabilidadesPorDisciplina(nomeDisciplina);
            foreach (DataRow row in habilidadesAtualizadas.Rows)
            {
                list_habilidades.Items.Add(row["habilidades"].ToString());
            }
        }

        private void btn_adicionarHabilidades_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_novasHabilidades.Text))
            {
                MessageBox.Show("Informe as habilidades a serem adicionadas!");
            }
            else
            {
                string nomeDisciplina = txt_nomeDisciplina.Text;
                List<string> novasHabilidades = txt_novasHabilidades.Text.Split(',').Select(h => h.Trim()).ToList();
                db.AdicionarHabilidadesDisciplina(nomeDisciplina, novasHabilidades);
                MessageBox.Show("Habilidades adicionadas com sucesso!");

                list_habilidades.Items.Clear();
                var habilidadesAtualizadas = db.BuscarHabilidadesPorDisciplina(nomeDisciplina);
                foreach (DataRow row in habilidadesAtualizadas.Rows)
                {
                    list_habilidades.Items.Add(row["habilidades"].ToString());
                }
                txt_novasHabilidades.Text = String.Empty;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialDirecao formTelaInicialDirecao = new FormTelaInicialDirecao();
            this.Hide();
            formTelaInicialDirecao.ShowDialog();
            this.Close();
        }
    }
}
