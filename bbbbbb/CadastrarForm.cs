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
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
        {
            InitializeComponent();
        }
        private void AdicionarSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RemoverSelecao_SelectedIndexChanged(object sender, EventArgs e)
        {      
        }

      

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Cápsula vencida, inclua uma cápsula dentro do prazo de válidade");
                return;
            }    
            
                if (AdicionarCapsula.SelectedIndex == 0)
                {

                    EstoqueClass.leite = double.Parse(textBox1.Text);
                    EstoqueClass.dataleite = dateTimePicker1.Value;
                    
                }

                else if (AdicionarCapsula.SelectedIndex == 1)
                {
                    EstoqueClass.Cafe1 = double.Parse(textBox1.Text);
                    EstoqueClass.dataCafe1 = dateTimePicker1.Value;

                }

                else if (AdicionarCapsula.SelectedIndex == 2)
                {
                    EstoqueClass.Cafe2 = double.Parse(textBox1.Text);
                    EstoqueClass.dataCafe2 = dateTimePicker1.Value;

                }
                else if (AdicionarCapsula.SelectedIndex == 3)
                {
                    EstoqueClass.Choco1 = double.Parse(textBox1.Text);
                    EstoqueClass.datachoco1 = dateTimePicker1.Value;

                }
                else
                {
                    EstoqueClass.Choco2 = double.Parse(textBox1.Text);
                    EstoqueClass.datachoco2 = dateTimePicker1.Value;

                }

                   MessageBox.Show("Item cadastrado com sucesso!");


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
