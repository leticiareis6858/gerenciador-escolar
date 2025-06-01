using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
