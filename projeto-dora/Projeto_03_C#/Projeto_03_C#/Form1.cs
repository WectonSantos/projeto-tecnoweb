using Projeto_03_C_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Projeto_03_C_
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBoxClicado = null; // Variável global para armazenar o PictureBox clicado
        private bool pb1Clicado = false;
        private Point[] posicoesIniciais = new Point[8]; // Array para armazenar as posições iniciais dos PictureBoxes

        public Form1()
        {
            InitializeComponent();
            btReiniciar.Enabled = false;
            for (int i = 1; i <= 8; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                pb.Enabled = false;

                // Armazenar a posição inicial de cada PictureBox
                posicoesIniciais[i - 1] = pb.Location;
            }
        }

        #region Variáveis Globais
        Random randomizaQuadrados = new Random();
        int quantidadeQuadrados;
        byte[][] imagensBytes = new byte[][]
        {
            Resources.Estrela,     // Imagem 1 no formato byte[]
            Resources.Diamante, // Imagem 2 no formato byte[]
            Resources.Arvore
        };
        string[] nomesImagens = new string[]
        {
            "Estrela",
            "Diamante",
            "Arvore"
        };
        int objeto1, objeto2;
        #endregion

        #region Botão Jogar
        private void btJogar_Click(object sender, EventArgs e)
        {
            btJogar.Enabled = false;
            btReiniciar.Enabled = true;

            quantidadeQuadrados = randomizaQuadrados.Next(1, 9);

            objeto1 = randomizaQuadrados.Next(0, 3);
            objeto2 = randomizaQuadrados.Next(0, 3);

            while (objeto2 == objeto1)
            {
                objeto2 = randomizaQuadrados.Next(0, 3);
            }

            lblPrimeiro.Text = nomesImagens[objeto1];
            lblSegundo.Text = nomesImagens[objeto2];

            byte[] imagemBytes1 = imagensBytes[objeto1], imagemBytes2 = imagensBytes[objeto2];

            using (MemoryStream ms = new MemoryStream(imagemBytes1))
            {
                pbImagem1.BackgroundImage = Image.FromStream(ms);
            }
            using (MemoryStream ms = new MemoryStream(imagemBytes2))
            {
                pbImagem2.BackgroundImage = Image.FromStream(ms);
            }

            for (int i = 1; i <= quantidadeQuadrados; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                int time;
                pb.Enabled = true;

                time = randomizaQuadrados.Next(1, 101) % 2;

                if (time == 0)
                {
                    using (MemoryStream ms = new MemoryStream(imagemBytes1))
                    {
                        pb.BackgroundImage = Image.FromStream(ms); // Converte os bytes para uma imagem
                    }
                }
                else if (time == 1)
                {
                    using (MemoryStream ms = new MemoryStream(imagemBytes2))
                    {
                        pb.BackgroundImage = Image.FromStream(ms); // Converte os bytes para uma imagem
                    }
                }
            }
        }
        #endregion

        #region Som 1 Click
        private void pbSom1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak(nomesImagens[objeto1]);
        }
        #endregion

        #region Som 2 Click
        private void pbSom2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak(nomesImagens[objeto2]);
        }
        #endregion

        #region Botão Reiniciar
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            btJogar.Enabled = true;
            btReiniciar.Enabled = false;

            lblPrimeiro.Text = "- - - - - - - - - -";
            lblSegundo.Text = "- - - - - - - - - -";

            objeto1 = 0;
            objeto2 = 0;

            // Resetar as imagens e as posições
            for (int i = 1; i <= 8; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                pb.BackgroundImage = null;
                pb.Enabled = false;

                // Resetar a posição do PictureBox
                pb.Location = posicoesIniciais[i - 1]; // Coloca o PictureBox de volta à sua posição inicial
            }

            pbImagem1.BackgroundImage = null;
            pbImagem2.BackgroundImage = null;
        }
        #endregion

        #region Botão Autores
        private void btAutores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedro Henrique Moreira Santos Cretella - 226013 \n Wecton Santos - 000000", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Clique no PictureBox
        private void pbBox1_Click(object sender, EventArgs e)
        {
            pb1Clicado = true;
            pictureBoxClicado = (PictureBox)sender;
        }
        #endregion

        #region Clique no Painel
        private void pPrimeiro_Click(object sender, EventArgs e)
        {
            if (pictureBoxClicado != null) // Verifica se um PictureBox foi clicado
            {
                // Converte as coordenadas do clique no painel para as coordenadas do PictureBox dentro do painel
                Point clickPosition = pPrimeiro.PointToClient(Cursor.Position);

                // Posiciona o PictureBox no local do clique dentro do painel
                pictureBoxClicado.Location = clickPosition;

                // Adiciona o PictureBox ao painel
                pPrimeiro.Controls.Add(pictureBoxClicado);

                // Traz o PictureBox para frente, caso haja outros controles no painel
                pictureBoxClicado.BringToFront();

                // Após mover, limpa a variável que armazena o PictureBox clicado
                pictureBoxClicado = null;
            }
        }
        #endregion

        #region Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair", "Deseja mesmo sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
