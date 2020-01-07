using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbbbbb
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {            
        }        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarForm telacadastro = new CadastrarForm();
            telacadastro.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {   ConsultarForm telaconsulta = new ConsultarForm();
            telaconsulta.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
