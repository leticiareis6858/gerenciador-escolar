using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeTurmas.FormsDirecao;

namespace GerenciadorEscolar.FormsDisciplinas
{
    public partial class FormExcluirDisciplina : Form
    {
        private Database db;
        public FormExcluirDisciplina()
        {
            InitializeComponent();
            db = new Database();
        }

        private void PreencherListBoxDisciplinas()
        {
            List<string> disciplinas = db.BuscarNomeIdDisciplinas();
            list_disciplinas.Items.Clear();

            foreach (string disciplina in disciplinas)
            {
                list_disciplinas.Items.Add(disciplina);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaInicialDirecao formTelaInicialDirecao = new FormTelaInicialDirecao();
            this.Hide();
            formTelaInicialDirecao.ShowDialog();
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (list_disciplinas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma disciplina para excluir!");
                return;
            }

            List<int> idsDisciplinas = new List<int>();

            foreach (var item in list_disciplinas.SelectedItems)
            {
                string itemStr = item.ToString();
                int id;
                string[] partes = itemStr.Split(',');
                if (partes.Length > 0 && int.TryParse(partes[0].Trim(), out id))
                {
                    idsDisciplinas.Add(id);
                }
            }

            if (idsDisciplinas.Count > 0)
            {
                db.ExcluirDisciplinas(idsDisciplinas);
                MessageBox.Show("Disciplina(s) excluída(s) com sucesso!");
                PreencherListBoxDisciplinas();
            }
        }
    }
}
