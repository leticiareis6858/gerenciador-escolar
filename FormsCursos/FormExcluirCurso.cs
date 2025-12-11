using GerenciadorDeTurmas.FormsDirecao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTurmas.FormsCursos
{
    public partial class FormExcluirCurso : Form
    {
        private Database db;
        public FormExcluirCurso()
        {
            InitializeComponent();
            db = new Database();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FormTelaCursos formCurso = new FormTelaCursos();
            this.Hide();
            formCurso.ShowDialog();
            this.Close();
        }

        private void PreencherListBoxCursos()
        {
            List<string> cursos = db.BuscarNomeIdCursos();
            list_cursos.Items.Clear();

            foreach (string curso in cursos)
            {
                list_cursos.Items.Add(curso);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (list_cursos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um curso para excluir!");
                return;
            }

            List<int> idsCursos= new List<int>();

            foreach (var item in list_cursos.SelectedItems)
            {
                string itemStr = item.ToString();
                int id;
                string[] partes = itemStr.Split(',');
                if (partes.Length > 0 && int.TryParse(partes[0].Trim(), out id))
                {
                    idsCursos.Add(id);
                }
            }

            if (idsCursos.Count > 0)
            {
                db.ExcluirDisciplinas(idsCursos);
                MessageBox.Show("Curso(s) excluído(s) com sucesso!");
                PreencherListBoxCursos();
            }
        }
    }
}
