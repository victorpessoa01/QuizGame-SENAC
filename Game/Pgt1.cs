using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Pgt1 : Form
    {
        public Pgt1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioBntC.Checked == true)
            {
                Pontuação pontuação = new Pontuação();
                pontuação.pontos += 1;

                labelQuest1.Text = "Questão 2";
                labelPergunta.Text = "Qual é o valor de 3+(2x6)";
                radioBntC.Text = "= 15";
                radioBnt1.Text = "= 30";
                radioBnt2.Text = "= 14";
                radioBnt3.Text = "= 4";
            }
             else if (radioBnt1.Checked || radioBnt2.Checked || radioBnt3.Checked)
            {
                labelQuest1.Text = "Questão 2";
                labelPergunta.Text = "Qual é o valor de 3+(2x6)";
                radioBntC.Text = "= 15";
                radioBnt1.Text = "= 30";
                radioBnt2.Text = "= 14";
                radioBnt3.Text = "= 4";
            }

            else
            {
                MessageBox.Show("Marque uma alternativa");
            }
        }
    }
}
