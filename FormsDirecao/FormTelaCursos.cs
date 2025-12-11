using GerenciadorDeTurmas.FormsCursos;
using GerenciadorEscolar;
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
    public partial class FormTelaCursos : Form
    {
        public FormTelaCursos()
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
            FormCadastroCurso formCadastro = new FormCadastroCurso();
            this.Hide();
            formCadastro.ShowDialog();
            this.Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            FormAlterarCurso formAlterar = new FormAlterarCurso();
            this.Hide();
            formAlterar.ShowDialog();
            this.Close();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            FormExcluirCurso formExcluir = new FormExcluirCurso();
            this.Hide();
            formExcluir.ShowDialog();
            this.Close();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FormBuscarCursosProfessores formBuscar = new FormBuscarCursosProfessores();
            this.Hide();
            formBuscar.ShowDialog();
            this.Close();
        }
    }
}
