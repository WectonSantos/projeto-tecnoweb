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
        private Point localOriginal;

        public Form1()
        {
            InitializeComponent();
            ConfigureDragAndDrop();

        }
        private void ConfigureDragAndDrop()
        {
            pbJogo0.AllowDrop = true;
            pbJogo1.AllowDrop = true;
            pbJogo2.AllowDrop = true;
            pbJogo3.AllowDrop = true;
            pbJogo4.AllowDrop = true;
            pbJogo5.AllowDrop = true;
            pbJogo6.AllowDrop = true;
            pbJogo7.AllowDrop = true;

            pbJogo0.MouseDown += PbImagem_MouseDown;
            pbJogo1.MouseDown += PbImagem_MouseDown;
            pbJogo2.MouseDown += PbImagem_MouseDown;
            pbJogo3.MouseDown += PbImagem_MouseDown;
            pbJogo4.MouseDown += PbImagem_MouseDown;
            pbJogo5.MouseDown += PbImagem_MouseDown;
            pbJogo6.MouseDown += PbImagem_MouseDown;
            pbJogo7.MouseDown += PbImagem_MouseDown;

            pbJogo0.DragEnter += PbImagem_DragEnter;
            pbJogo1.DragEnter += PbImagem_DragEnter;
            pbJogo2.DragEnter += PbImagem_DragEnter;
            pbJogo3.DragEnter += PbImagem_DragEnter;
            pbJogo4.DragEnter += PbImagem_DragEnter;
            pbJogo5.DragEnter += PbImagem_DragEnter;
            pbJogo6.DragEnter += PbImagem_DragEnter;
            pbJogo7.DragEnter += PbImagem_DragEnter;

            pbJogo0.DragDrop += PbImagem_DragDrop;
            pbJogo1.DragDrop += PbImagem_DragDrop;
            pbJogo2.DragDrop += PbImagem_DragDrop;
            pbJogo3.DragDrop += PbImagem_DragDrop;
            pbJogo4.DragDrop += PbImagem_DragDrop;
            pbJogo5.DragDrop += PbImagem_DragDrop;
            pbJogo6.DragDrop += PbImagem_DragDrop;
            pbJogo7.DragDrop += PbImagem_DragDrop;
        }

        private void PbImagem_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb)
            {
                localOriginal = pb.Location; // Salva a posição original
                pb.DoDragDrop(pb.Image, DragDropEffects.Move);
            }
        }

        private void PbImagem_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Image)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void PbImagem_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Image)))
            {
                PictureBox pb = sender as PictureBox;
                if (pb != null)
                {
                    pb.Image = (Image)e.Data.GetData(typeof(Image)); // Define a imagem do PictureBox
                    pb.Location = new Point(pb.Location.X, pb.Location.Y); // Ajuste se necessário
                }
            }
        }

        private void gbJogo_Enter(object sender, EventArgs e)
        {

        }

        private void btReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            comecou = 1;
            x = aleatorio.Next(4, 9);

            int[] vetorImagens = new int[x + 1];

            for (int i = 0; i < x; i++)
            {
                int y = aleatorio.Next(0, 100);

                if (y % 2 == 0)
                {
                    vetorImagens[i] = 0;
                }
                else
                {
                    vetorImagens[i] = 1;
                }
            }

            processaImagens(vetorImagens);


        }

        #region lixo
        private void pbJogo0_DragDrop(object sender, DragEventArgs e)
        {
            pbJogo0.AllowDrop = true;
        }
        #endregion

        void processaImagens(int[] vetor)
        {
            #region imagens
            if (vetor[0] == 0)
            {
                pbJogo0.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo0.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[1] == 0)
            {
                pbJogo1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[2] == 0)
            {
                pbJogo2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[3] == 0)
            {
                pbJogo3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[4] == 0)
            {
                pbJogo4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[5] == 0)
            {
                pbJogo5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[6] == 0)
            {
                pbJogo6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            if (vetor[7] == 0)
            {
                pbJogo7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\estrela.png");
            }
            else
            {
                pbJogo7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\quadrado.png");
            }
            #endregion

        }

    }
}
