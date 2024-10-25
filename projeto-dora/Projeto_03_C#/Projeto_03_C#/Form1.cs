using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03_C_
{
    public partial class Form1 : Form
    {
        private int comecou = 0;
        Random aleatorio = new Random();
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void gbJogo_Enter(object sender, EventArgs e)
        {

        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            comecou = 0;
            x = aleatorio.Next(4, 9); 

            int[] vetorImagens = new int[x + 1]; 

            for (int i = 0; i <= x; i++)
            {
                y = aleatorio.Next(0, 100);
                if (y % 2 == 0)
                {
                    vetorImagens[i] = 0;
                }
                else
                {
                    vetorImagens[i] = 1; 
                }
            }

            lblCerto.Text = string.Join(", ", vetorImagens);

        }

    }

}
