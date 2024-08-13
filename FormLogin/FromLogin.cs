using GerenciadorDeTurmas.FormsDisciplinas;
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
    public partial class form_login : Form
    {
        private Database db;
        public form_login()
        {
            InitializeComponent();
            db = new Database();
            db.CreateTables(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
