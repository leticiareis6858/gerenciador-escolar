using GerenciadorDeTurmas.FormsProfessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTurmas.FormsDisciplinas
{
    public partial class FormOpcoesDisciplinasProfessores : Form
    {
        public FormOpcoesDisciplinasProfessores()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            FormBuscarDisciplinasProfessores formBuscarDisciplinas = new FormBuscarDisciplinasProfessores();
            formBuscarDisciplinas.Show();
            this.Close();
        }
    }
}
