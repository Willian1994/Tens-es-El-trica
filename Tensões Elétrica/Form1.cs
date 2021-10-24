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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char A;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioTomada.Checked)
            {
                Tomada novaform = new Tomada();
                novaform.Show();                
            }
            else if (radioAutotrafo.Checked)
            {               
                Autotrafo novaform = new Autotrafo();
                novaform.Show();
            }
            

        }
    }
}
