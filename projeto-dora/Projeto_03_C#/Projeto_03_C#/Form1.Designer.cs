namespace Projeto_03_C_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbJogo = new System.Windows.Forms.GroupBox();
            this.pImagens = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pPrimeiro = new System.Windows.Forms.Panel();
            this.pSegundo = new System.Windows.Forms.Panel();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.pbSom1 = new System.Windows.Forms.PictureBox();
            this.pbSom2 = new System.Windows.Forms.PictureBox();
            this.pPlacar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCerto = new System.Windows.Forms.Label();
            this.lblErrado = new System.Windows.Forms.Label();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.btAutores = new System.Windows.Forms.Button();
            this.gbJogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom2)).BeginInit();
            this.pPlacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJogo
            // 
            this.gbJogo.BackColor = System.Drawing.Color.Turquoise;
            this.gbJogo.Controls.Add(this.btAutores);
            this.gbJogo.Controls.Add(this.btReiniciar);
            this.gbJogo.Controls.Add(this.pPlacar);
            this.gbJogo.Controls.Add(this.pbSom2);
            this.gbJogo.Controls.Add(this.pbSom1);
            this.gbJogo.Controls.Add(this.lblSegundo);
            this.gbJogo.Controls.Add(this.lblPrimeiro);
            this.gbJogo.Controls.Add(this.pSegundo);
            this.gbJogo.Controls.Add(this.pPrimeiro);
            this.gbJogo.Controls.Add(this.pImagens);
            this.gbJogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbJogo.Location = new System.Drawing.Point(12, 12);
            this.gbJogo.Name = "gbJogo";
            this.gbJogo.Size = new System.Drawing.Size(907, 479);
            this.gbJogo.TabIndex = 0;
            this.gbJogo.TabStop = false;
            this.gbJogo.Text = "CLASSIFICAR E ORGANIZAR";
            // 
            // pImagens
            // 
            this.pImagens.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pImagens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pImagens.Location = new System.Drawing.Point(6, 40);
            this.pImagens.Name = "pImagens";
            this.pImagens.Size = new System.Drawing.Size(200, 370);
            this.pImagens.TabIndex = 0;
            // 
            // pPrimeiro
            // 
            this.pPrimeiro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pPrimeiro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPrimeiro.Location = new System.Drawing.Point(238, 69);
            this.pPrimeiro.Name = "pPrimeiro";
            this.pPrimeiro.Size = new System.Drawing.Size(300, 300);
            this.pPrimeiro.TabIndex = 1;
            // 
            // pSegundo
            // 
            this.pSegundo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pSegundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSegundo.Location = new System.Drawing.Point(575, 69);
            this.pSegundo.Name = "pSegundo";
            this.pSegundo.Size = new System.Drawing.Size(300, 300);
            this.pSegundo.TabIndex = 2;
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiro.Location = new System.Drawing.Point(331, 33);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(187, 22);
            this.lblPrimeiro.TabIndex = 3;
            this.lblPrimeiro.Text = "Primeiro Quadrado";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.Location = new System.Drawing.Point(666, 33);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(192, 22);
            this.lblSegundo.TabIndex = 4;
            this.lblSegundo.Text = "Segundo Quadrado";
            // 
            // pbSom1
            // 
            this.pbSom1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSom1.BackgroundImage")));
            this.pbSom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSom1.Location = new System.Drawing.Point(278, 24);
            this.pbSom1.Name = "pbSom1";
            this.pbSom1.Size = new System.Drawing.Size(47, 39);
            this.pbSom1.TabIndex = 5;
            this.pbSom1.TabStop = false;
            // 
            // pbSom2
            // 
            this.pbSom2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSom2.BackgroundImage")));
            this.pbSom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSom2.Location = new System.Drawing.Point(613, 24);
            this.pbSom2.Name = "pbSom2";
            this.pbSom2.Size = new System.Drawing.Size(47, 39);
            this.pbSom2.TabIndex = 6;
            this.pbSom2.TabStop = false;
            // 
            // pPlacar
            // 
            this.pPlacar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPlacar.Controls.Add(this.lblErrado);
            this.pPlacar.Controls.Add(this.lblCerto);
            this.pPlacar.Controls.Add(this.label2);
            this.pPlacar.Controls.Add(this.label1);
            this.pPlacar.Location = new System.Drawing.Point(294, 375);
            this.pPlacar.Name = "pPlacar";
            this.pPlacar.Size = new System.Drawing.Size(178, 85);
            this.pPlacar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Errado:";
            // 
            // lblCerto
            // 
            this.lblCerto.AutoSize = true;
            this.lblCerto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerto.Location = new System.Drawing.Point(66, 9);
            this.lblCerto.Name = "lblCerto";
            this.lblCerto.Size = new System.Drawing.Size(18, 19);
            this.lblCerto.TabIndex = 2;
            this.lblCerto.Text = "0";
            // 
            // lblErrado
            // 
            this.lblErrado.AutoSize = true;
            this.lblErrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrado.Location = new System.Drawing.Point(66, 45);
            this.lblErrado.Name = "lblErrado";
            this.lblErrado.Size = new System.Drawing.Size(18, 19);
            this.lblErrado.TabIndex = 3;
            this.lblErrado.Text = "0";
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReiniciar.BackgroundImage")));
            this.btReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReiniciar.Location = new System.Drawing.Point(651, 386);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(60, 54);
            this.btReiniciar.TabIndex = 8;
            this.btReiniciar.UseVisualStyleBackColor = true;
            // 
            // btAutores
            // 
            this.btAutores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAutores.BackgroundImage")));
            this.btAutores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAutores.Location = new System.Drawing.Point(741, 386);
            this.btAutores.Name = "btAutores";
            this.btAutores.Size = new System.Drawing.Size(60, 54);
            this.btAutores.TabIndex = 9;
            this.btAutores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(931, 503);
            this.Controls.Add(this.gbJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Classificar e organizar";
            this.gbJogo.ResumeLayout(false);
            this.gbJogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom2)).EndInit();
            this.pPlacar.ResumeLayout(false);
            this.pPlacar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJogo;
        private System.Windows.Forms.Panel pImagens;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Panel pSegundo;
        private System.Windows.Forms.Panel pPrimeiro;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbSom2;
        private System.Windows.Forms.PictureBox pbSom1;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Panel pPlacar;
        private System.Windows.Forms.Label lblErrado;
        private System.Windows.Forms.Label lblCerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.Button btAutores;
    }
}

