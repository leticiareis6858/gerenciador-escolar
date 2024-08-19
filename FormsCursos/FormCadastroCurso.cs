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
    public partial class FormCadastroCurso : Form
    {
        private Database db;
        public FormCadastroCurso()
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
            FormCadastro formCadastro = new FormCadastro();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String nome = txt_nome_curso.Text.Trim();
            String duracao = txt_semestres.Text.Trim();

            List<int> disciplinasSelecionadas = new List<int>();

            foreach (var item in list_disciplinas.SelectedItems)
            {
                var partes = item.ToString().Split(',');
                if (partes.Length > 0)
                {
                    var idParte = partes[0].Split(':')[1].Trim();
                    if (int.TryParse(idParte, out int idDisciplina))
                    {
                        disciplinasSelecionadas.Add(idDisciplina);
                    }
                }
            }

            if (!nome.Equals("") && !duracao.Equals("") && disciplinasSelecionadas.Count > 0)
            {
                db.CadastrarCurso(nome, duracao);

                int idCurso = db.BuscarIdCursoPorNome(nome);

                foreach (var idDisciplina in disciplinasSelecionadas)
                {
                    db.AtrelarDisciplinasAoCurso(idCurso, idDisciplina);
                }

                MessageBox.Show("Curso cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

    }
}
