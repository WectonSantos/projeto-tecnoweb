using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            for (int i = 0; i < x; i++)
            {
                int y = aleatorio.Next(0, 100);
                PictureBox pb = (PictureBox)Controls["pbJogo" + i]; // Fazendo o cast para PictureBox
                if (y % 2 == 0)
                {
                    vetorImagens[i] = 0;
                    // Altera a imagem da PictureBox para a imagem correspondente a 0
                    pb.Image = Image.FromFile("C:\\Users\\unisanta\\Pictures\\quadrado.png"); // Substitua pelo caminho da imagem
                }
                else
                {
                    vetorImagens[i] = 1;
                    // Altera a imagem da PictureBox para a imagem correspondente a 1
                    pb.Image = Image.FromFile("C:\\Users\\unisanta\\Pictures\\estrela.png"); // Substitua pelo caminho da imagem
                }
            }


        }

    }

}
