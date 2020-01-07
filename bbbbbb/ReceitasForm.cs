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
    public partial class ReceitasForm : Form
    {
        
        public ReceitasForm()
        {
            InitializeComponent();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            if (LeiteCombobox.SelectedIndex == 0 && EstoqueClass.leite < 1)
            {
                MessageBox.Show("Não há cápsulas disponíveis, favor verificar estque! ", "Alerta!!!");
                return;

            }

            else if ((CafeComboBox1.SelectedIndex == 0 && EstoqueClass.Cafe1 <1) || (CafeComboBox1.SelectedIndex == 1 && EstoqueClass.Cafe2 <1) )
            {
                MessageBox.Show("Não há cápsulas disponíveis, favor verificar estque! ", "Alerta!!!");
                return;
            }

            else if ((ChocoComboBox.SelectedIndex == 0 && EstoqueClass.Choco1<1) || (ChocoComboBox.SelectedIndex==1 && EstoqueClass.Choco2<1))
            {
                MessageBox.Show("Não há cápsulas disponíveis, favor verificar estque! ", "Alerta!!!");
                return;
            }


            //validação de vencimento

            if ((ChocoComboBox.SelectedIndex == 0 && EstoqueClass.datachoco1 < DateTime.Today) || (ChocoComboBox.SelectedIndex == 1 && EstoqueClass.datachoco2 < DateTime.Today))
            {
                MessageBox.Show("As Cápsulas disponíveis de chocolate estão vencidas !!", "Alerta !!!");
                return;
            }

            if ((CafeComboBox1.SelectedIndex == 0 && EstoqueClass.dataCafe1 < DateTime.Today) || (CafeComboBox1.SelectedIndex == 1 && EstoqueClass.dataCafe2 < DateTime.Today))
            {
                MessageBox.Show(" As Cápsulas disponíveis de café estão vencidas !!", "Alerta !!!");
                return;
            }

            if (LeiteCombobox.SelectedIndex == 0 && EstoqueClass.dataleite < DateTime.Today)
            {
                MessageBox.Show(" As Cápsulas disponíveis de leite estão vencidas !!", "Alerta !!!");
                return;
            }


            if (ChocoComboBox.SelectedIndex == 0 && LeiteCombobox.SelectedIndex == 0)
            {    
                MessageBox.Show("Seu Chocotino está sendo preparado !.", "Status de preparação");
                MessageBox.Show("Seu Chocotino está pronto !", "Status de preparação");
                --EstoqueClass.leite;
              --EstoqueClass.Choco1;
                
            }

            else if (LeiteCombobox.SelectedIndex ==0 && CafeComboBox1.SelectedIndex ==1 && ChocoComboBox.SelectedIndex == 1)
            {
                 MessageBox.Show("Seu Mocaccino está sendo preparado !", "Status de preparação");
                 MessageBox.Show("Seu Mocaccino está pronto !", "Status de preparação");
                --EstoqueClass.leite;
               --EstoqueClass.Cafe2;
               --EstoqueClass.Choco2;
                                  
            }

            else if (LeiteCombobox.SelectedIndex == 0 && CafeComboBox1.SelectedIndex == 0 )
            {
                MessageBox.Show("Seu Capuccino está sendo preparado !", "Status de preparação");
                MessageBox.Show("Seu Capuccino está pronto !", "Status de preparação");
                --EstoqueClass.leite;
                --EstoqueClass.Cafe2;
                
            }

            else
            {
                MessageBox.Show("Opção Inválida");
            }
  
                     
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void leite_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Receitas_Load(object sender, EventArgs e)
        {

        }

        private void LeiteCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CafeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cafe1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cafe2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chocolate1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chocolate2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
