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
    public partial class FormInscreverseCurso : Form
    {
        private Database db;
        public FormInscreverseCurso()
        {
            InitializeComponent();
            db = new Database();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dt = db.BuscarCursos();
            dataGridView_cursos.DataSource = dt;
        }

        private void btn_inscrever_Click(object sender, EventArgs e)
        {
            String id = txt_id_curso.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id_curso.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }
    }
}
