using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Game
{
    
    public partial class FormQuest1 : Form
    {
        
        public FormQuest1()
        {
            InitializeComponent();
        }

        private void labelPergunta_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result ="CORRETO";
            string res = "VOCÊ ERROU";
            if (P1Correct.Checked == true)
            {
                Score.Text = result;
                Score.BackColor = Color.Green;
            }
            if (P1Correct.Checked == false)
            {
                Score.Text = res;
                Score.BackColor = Color.Red;
            }
            Res.BackColor = Color.Green;
            Res.Text = "Yuri Gagarin, pôde observar a Terra de forma externa e viu a olho nu a tonalidade azulada do nosso planeta no dia 12/04/1961.";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
