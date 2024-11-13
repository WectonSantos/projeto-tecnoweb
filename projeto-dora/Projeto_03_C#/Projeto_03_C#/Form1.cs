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

        public Form1()
        {
            InitializeComponent();
            btReiniciar.Enabled = false;            
            for (int i = 1; i <= 8; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                pb.Enabled = false;
            }
        }

        #region Funções
        private void timer_Tick(object sender, EventArgs e)
        {            
            if (remainingTime > 0)
            {
                remainingTime -= 1; // Diminui o tempo em 1 segundo
                lblTimer.Text = remainingTime.ToString(); // Atualiza a lbl com o tempo restante
            }
            else
            {
                timer.Stop(); // Para o cronômetro quando chegar a 0
                MessageBox.Show("Que pena! Tente novamente", "Tempo Esgotado", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                zerar();
                iniciar();  
            }            
        }

        private void iniciaTimer()
        {
            remainingTime = 15;
            lblTimer.Text = "15";
            timer.Start();
        }
        private void zerar()
        {            
            lblPrimeiro.Text = "- - - - - - - - - -";
            lblSegundo.Text = "- - - - - - - - - -";

            objeto1 = 0;
            objeto2 = 0;
            certo = 0;
            errado = 0;
            lblCerto.Text = certo.ToString();
            lblErrado.Text = errado.ToString();
            timePb.Clear();

            for (int i = 1; i <= 8; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                pb.BackgroundImage = null;
                pb.Enabled = false;
            }
            pbImagem1.BackgroundImage = null;
            pbImagem2.BackgroundImage = null;

            pbBox1.Location = new Point(29, 111);
            pbBox2.Location = new Point(29, 177);
            pbBox3.Location = new Point(29, 242);
            pbBox4.Location = new Point(29, 308);
            pbBox5.Location = new Point(116, 111);
            pbBox6.Location = new Point(116, 177);
            pbBox7.Location = new Point(116, 242);
            pbBox8.Location = new Point(116, 308);

            remainingTime = 15;
            lblTimer.Text = "15";
        }

        private void iniciar()
        {
            quantidadeQuadrados = randomizaQuadrados.Next(1, 9);

            errado = quantidadeQuadrados;
            lblErrado.Text = errado.ToString();


            objeto1 = randomizaQuadrados.Next(0, 20);
            objeto2 = randomizaQuadrados.Next(0, 20);

            while (objeto2 == objeto1)
            {
                objeto2 = randomizaQuadrados.Next(0, 20);
            }

            lblPrimeiro.Text = nomesEImagens[objeto1, 0];
            lblSegundo.Text = nomesEImagens[objeto2, 0];

            string caminhoDaImagem1 = Path.Combine(basePath, "Resources", nomesEImagens[objeto1, 1]);
            string caminhoDaImagem2 = Path.Combine(basePath, "Resources", nomesEImagens[objeto2, 1]);

            pbImagem1.BackgroundImage = Image.FromFile(caminhoDaImagem1);
            pbImagem2.BackgroundImage = Image.FromFile(caminhoDaImagem2);

            for (int i = 1; i <= quantidadeQuadrados; i++)
            {
                string nomePictureBox = $"pbBox{i}";
                PictureBox pb = (PictureBox)this.Controls.Find(nomePictureBox, true).FirstOrDefault();
                int time;
                pb.Enabled = true;

                time = randomizaQuadrados.Next(1, 101) % 2;

                if (time == 0)
                {
                    pb.BackgroundImage = Image.FromFile(caminhoDaImagem1);
                    timePb.Add('1');
                }
                else if (time == 1)
                {
                    pb.BackgroundImage = Image.FromFile(caminhoDaImagem2);
                    timePb.Add('2');
                }
            }
            iniciaTimer();
        }
        #endregion

        #region drag and drop
        private void verificaClick(MouseEventArgs e, PictureBox picturebox)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true; 
                initialPosition = e.Location; 
            }
        }
        private void mover(MouseEventArgs e, PictureBox picturebox)
        {
            if (isDragging)
            {
                picturebox.BringToFront();
                picturebox.Left += e.X - initialPosition.X;
                picturebox.Top += e.Y - initialPosition.Y;
            }
        }

        private void verificarPanel(PictureBox pictureBox, Panel targetPanel)
        {
            if (pictureBox.Parent == targetPanel)
            {                
            }
            else
            {                
                // Verificar se o PictureBox está dentro dos limites do Panel
                Point pictureBoxLocation = targetPanel.PointToClient(pictureBox.Parent.PointToScreen(pictureBox.Location));
                if (targetPanel.ClientRectangle.Contains(pictureBoxLocation))
                {
                    certo++;
                    errado--;
                    lblCerto.Text = certo.ToString();
                    lblErrado.Text = errado.ToString();
                    pictureBox.Enabled = false;
                }
            }            
        }

        private Panel verificaTime(int i)
        {
            if (timePb[i] == '2')
            {
                return pSegundo;
            }
            else
            {
                return pPrimeiro;
            }
        }
        private void verificaVitoria()
        {
            if (errado == 0)
            {
                MessageBox.Show("Você acertou!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                zerar();
                iniciar();
            }
        }

        #region pb1 move
        private void pbBox1_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }
        private void pbBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }
        private void pbBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(0));
            verificaVitoria();
        }
        #endregion

        #region pb2 move
        private void pbBox2_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }
        private void pbBox2_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }
        private void pbBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(1));
            verificaVitoria();
        }
        #endregion

        #region pb3 move
        private void pbBox3_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox3_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(2));
            verificaVitoria();
        }
        #endregion

        #region pb4 move
        private void pbBox4_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox4_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox4_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(3));
            verificaVitoria();
        }
        #endregion

        #region pb5 move
        private void pbBox5_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox5_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox5_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(4));
            verificaVitoria();
        }
        #endregion

        #region pb6 move
        private void pbBox6_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox6_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox6_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(5));
            verificaVitoria();
        }

        #endregion

        #region pb7 move
        private void pbBox7_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox7_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox7_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(6));
            verificaVitoria();
        }
        #endregion

        #region pb8 move
        private void pbBox8_MouseDown(object sender, MouseEventArgs e)
        {
            verificaClick(e, (PictureBox)sender);
        }

        private void pbBox8_MouseMove(object sender, MouseEventArgs e)
        {
            mover(e, (PictureBox)sender);
        }

        private void pbBox8_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            verificarPanel((PictureBox)sender, verificaTime(7));
            verificaVitoria();
        }
        #endregion

        #endregion

        #region Variavéis Globais
        Random randomizaQuadrados = new Random();
        int quantidadeQuadrados;
        int errado, certo = 0;
        int objeto1, objeto2;
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string[,] nomesEImagens = new string[,]
        {
            { "Estrela", "estrela.png" },
            { "Diamante", "diamante.png" },
            { "Arvore", "arvore.png" },
            { "Batman", "batman.png" },
            { "Cachorro", "cachorro.png" },
            { "Carro", "carro.png" },
            { "Dinossauro", "dinossauro.png" },
            { "Freeza", "freeza.png" },
            { "Goku", "goku.png" },
            { "Lula", "lula.png" },
            { "Mario", "mario.png" },
            { "Minion", "minion.png" },
            { "Moana", "moana.png" },
            { "Peppa", "peppa.png" },
            { "Pikachu", "pikachu.png" },
            { "Princesa", "princesa.png" },
            { "Real Madrid", "realmadrid.png" },
            { "Santos", "santos.png" },
            { "Sonic", "sonic.png" },
            { "Stitch", "stitch.png" }
        };
        private PictureBox pictureBox;
        private bool isDragging = false;
        private Point initialPosition;
        List<char> timePb = new List<char>();
        int remainingTime;

        #endregion

        #region Botão jogar
        private void btJogar_Click(object sender, EventArgs e)
        {
            btJogar.Enabled = false;
            btReiniciar.Enabled=true;
            iniciar();
        }
        #endregion

        #region Som
        private void pbSom1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak(nomesEImagens[objeto1,0]);
        }

        private void pbSom2_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak(nomesEImagens[objeto2,0]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak("Arraste as imagens até o quadrado certo, você consegue!");
        }
        #endregion

        #region Botão Reiniciar
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btJogar.Enabled = true;
            btReiniciar.Enabled = false;
            zerar();
        }
        #endregion

        #region Botão Autores
        private void btAutores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedro Henrique Moreira Santos Cretella - 226013 \nMaria Fernanda de Almeida Maneira - 214348 \nWecton Santos - 228550", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Information);
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