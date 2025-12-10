using GerenciadorEscolar;
using GerenciadorEscolar.FormsDisciplinas;
using GerenciadorEscolar.FormsProfessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTurmas.FormsDirecao
{
    public partial class FormTelaDisciplinas : Form
    {
        public FormTelaDisciplinas()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            FormTelaInicialDirecao formDirecao = new FormTelaInicialDirecao();
            this.Hide();
            formDirecao.ShowDialog();
            this.Close();
        }


        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            FormCadastroDisciplina formCadastro = new FormCadastroDisciplina();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }
        
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            FormExcluirDisciplina formExcluir = new FormExcluirDisciplina();
            this.Hide();
            formExcluir.ShowDialog();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FormBuscarDisciplinasProfessores formBuscar = new FormBuscarDisciplinasProfessores();
            this.Hide();
            formBuscar.ShowDialog();
            this.Close();
        }
    }
}
