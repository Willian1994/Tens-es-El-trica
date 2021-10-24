using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tensões_Elétrica
{
    public partial class Tomada : Form
    {
        public Tomada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FT;
            String TN;
            String FN;

            FT = textFT.Text;
            int FT1 = Convert.ToInt32(FT);

            TN = textTN.Text;
            int TN1 = Convert.ToInt32(TN);

            FN = textFN.Text;
            int FN1 = Convert.ToInt32(FN);

            if (FT1 >= 110 && FT1 < 128 && TN1 >= 110 && TN1 < 128 && FN1 >= 0.3 && FN1 < 3)
            {
                Resultado.Text += "Valor dentro dos padroes.";
            }
            else
            {
                Resultado.Text += "Valor fora dos padroes.";
            }


            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
