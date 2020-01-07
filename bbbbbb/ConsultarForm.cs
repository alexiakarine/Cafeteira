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
    public partial class ConsultarForm : Form
    {
        public ConsultarForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarForm_Load(object sender, EventArgs e)
        {
            QtnLeite.Text = EstoqueClass.leite.ToString();
            QtnCafe1.Text = EstoqueClass.Cafe1.ToString();
            QtnCafe2.Text = EstoqueClass.Cafe2.ToString();
            QtnChoc1.Text = EstoqueClass.Choco1.ToString();
            QtnChoc2.Text = EstoqueClass.Choco2.ToString();

            DateTime datafinal, dataIncial;

            dataIncial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            datafinal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 31);

             if (EstoqueClass.dataleite >= dataIncial  && EstoqueClass.dataleite <= datafinal)
             {
                LeiteVencer.Text = EstoqueClass.leite.ToString();
                
             }
            if (EstoqueClass.dataCafe1 >= dataIncial && EstoqueClass.dataCafe2 <= datafinal)
            {
                Cafe1Vencer.Text = EstoqueClass.Cafe1.ToString();
                
            }
            if (EstoqueClass.datachoco1 >= dataIncial && EstoqueClass.datachoco1 <= datafinal)
            {
                Choco1Vencer.Text = EstoqueClass.Choco1.ToString();
                
            }
             if (EstoqueClass.datachoco2 >= dataIncial && EstoqueClass.datachoco2 <= datafinal)
            {
                Choco2Vencer.Text = EstoqueClass.Choco2.ToString();
                
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterarCapsula_Click(object sender, EventArgs e)
        {
            CadastrarForm adicionar = new CadastrarForm();
            adicionar.Show();
        }

        private void QtnLeite_Click(object sender, EventArgs e)
        {

        }

        private void QtnCafe1_Click(object sender, EventArgs e)
        {

        }

        private void QtnCafe2_Click(object sender, EventArgs e)
        {

        }

        private void QtnChoc1_Click(object sender, EventArgs e)
        {

        }

        private void QtnChoc2_Click(object sender, EventArgs e)
        {

        }

        private void LeiteVencer_Click(object sender, EventArgs e)
        {

        }

        private void Cafe1Vencer_Click(object sender, EventArgs e)
        {

        }

        private void Cafe2Vencer_Click(object sender, EventArgs e)
        {

        }

        private void Choco1Vencer_Click(object sender, EventArgs e)
        {

        }

        private void Choco2Vencer_Click(object sender, EventArgs e)
        {

        }
    }
}
