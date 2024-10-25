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
            this.pPlacar = new System.Windows.Forms.Panel();
            this.lblErrado = new System.Windows.Forms.Label();
            this.lblCerto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.pSegundo = new System.Windows.Forms.Panel();
            this.pPrimeiro = new System.Windows.Forms.Panel();
            this.pImagens = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnJogar = new System.Windows.Forms.Button();
            this.btAutores = new System.Windows.Forms.Button();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.pbSom2 = new System.Windows.Forms.PictureBox();
            this.pbSom1 = new System.Windows.Forms.PictureBox();
            this.pbJogo0 = new System.Windows.Forms.PictureBox();
            this.pbJogo1 = new System.Windows.Forms.PictureBox();
            this.pbJogo2 = new System.Windows.Forms.PictureBox();
            this.pbJogo3 = new System.Windows.Forms.PictureBox();
            this.pbJogo4 = new System.Windows.Forms.PictureBox();
            this.pbJogo5 = new System.Windows.Forms.PictureBox();
            this.pbJogo6 = new System.Windows.Forms.PictureBox();
            this.pbJogo7 = new System.Windows.Forms.PictureBox();
            this.gbJogo.SuspendLayout();
            this.pPlacar.SuspendLayout();
            this.pImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo7)).BeginInit();
            this.SuspendLayout();
            // 
            // gbJogo
            // 
            this.gbJogo.BackColor = System.Drawing.Color.Turquoise;
            this.gbJogo.Controls.Add(this.btnJogar);
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
            this.gbJogo.Enter += new System.EventHandler(this.gbJogo_Enter);
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
            // pSegundo
            // 
            this.pSegundo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pSegundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSegundo.Location = new System.Drawing.Point(575, 69);
            this.pSegundo.Name = "pSegundo";
            this.pSegundo.Size = new System.Drawing.Size(300, 300);
            this.pSegundo.TabIndex = 2;
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
            // pImagens
            // 
            this.pImagens.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pImagens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pImagens.Controls.Add(this.pbJogo7);
            this.pImagens.Controls.Add(this.pbJogo6);
            this.pImagens.Controls.Add(this.pbJogo5);
            this.pImagens.Controls.Add(this.pbJogo4);
            this.pImagens.Controls.Add(this.pbJogo3);
            this.pImagens.Controls.Add(this.pbJogo2);
            this.pImagens.Controls.Add(this.pbJogo1);
            this.pImagens.Controls.Add(this.pbJogo0);
            this.pImagens.Location = new System.Drawing.Point(6, 40);
            this.pImagens.Name = "pImagens";
            this.pImagens.Size = new System.Drawing.Size(200, 370);
            this.pImagens.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackgroundImage = global::Projeto_03_C_.Properties.Resources.botao_play_ponta_de_seta;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.Location = new System.Drawing.Point(600, 386);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(50, 50);
            this.btnJogar.TabIndex = 10;
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btAutores
            // 
            this.btAutores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAutores.BackgroundImage")));
            this.btAutores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAutores.Location = new System.Drawing.Point(741, 386);
            this.btAutores.Name = "btAutores";
            this.btAutores.Size = new System.Drawing.Size(50, 50);
            this.btAutores.TabIndex = 9;
            this.btAutores.UseVisualStyleBackColor = true;
            // 
            // btReiniciar
            // 
            this.btReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReiniciar.BackgroundImage")));
            this.btReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReiniciar.Location = new System.Drawing.Point(670, 386);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(50, 50);
            this.btReiniciar.TabIndex = 8;
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
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
            // pbJogo0
            // 
            this.pbJogo0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbJogo0.Location = new System.Drawing.Point(20, 27);
            this.pbJogo0.Name = "pbJogo0";
            this.pbJogo0.Size = new System.Drawing.Size(50, 50);
            this.pbJogo0.TabIndex = 0;
            this.pbJogo0.TabStop = false;
            this.pbJogo0.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbJogo0_DragDrop);
            // 
            // pbJogo1
            // 
            this.pbJogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbJogo1.Location = new System.Drawing.Point(20, 98);
            this.pbJogo1.Name = "pbJogo1";
            this.pbJogo1.Size = new System.Drawing.Size(50, 50);
            this.pbJogo1.TabIndex = 1;
            this.pbJogo1.TabStop = false;
            // 
            // pbJogo2
            // 
            this.pbJogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo2.Location = new System.Drawing.Point(20, 166);
            this.pbJogo2.Name = "pbJogo2";
            this.pbJogo2.Size = new System.Drawing.Size(50, 50);
            this.pbJogo2.TabIndex = 2;
            this.pbJogo2.TabStop = false;
            // 
            // pbJogo3
            // 
            this.pbJogo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo3.Location = new System.Drawing.Point(20, 234);
            this.pbJogo3.Name = "pbJogo3";
            this.pbJogo3.Size = new System.Drawing.Size(50, 50);
            this.pbJogo3.TabIndex = 3;
            this.pbJogo3.TabStop = false;
            // 
            // pbJogo4
            // 
            this.pbJogo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo4.Location = new System.Drawing.Point(102, 27);
            this.pbJogo4.Name = "pbJogo4";
            this.pbJogo4.Size = new System.Drawing.Size(50, 50);
            this.pbJogo4.TabIndex = 4;
            this.pbJogo4.TabStop = false;
            // 
            // pbJogo5
            // 
            this.pbJogo5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo5.Location = new System.Drawing.Point(102, 98);
            this.pbJogo5.Name = "pbJogo5";
            this.pbJogo5.Size = new System.Drawing.Size(50, 50);
            this.pbJogo5.TabIndex = 5;
            this.pbJogo5.TabStop = false;
            // 
            // pbJogo6
            // 
            this.pbJogo6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo6.Location = new System.Drawing.Point(102, 166);
            this.pbJogo6.Name = "pbJogo6";
            this.pbJogo6.Size = new System.Drawing.Size(50, 50);
            this.pbJogo6.TabIndex = 6;
            this.pbJogo6.TabStop = false;
            // 
            // pbJogo7
            // 
            this.pbJogo7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJogo7.Location = new System.Drawing.Point(102, 234);
            this.pbJogo7.Name = "pbJogo7";
            this.pbJogo7.Size = new System.Drawing.Size(50, 50);
            this.pbJogo7.TabIndex = 7;
            this.pbJogo7.TabStop = false;
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
            this.pPlacar.ResumeLayout(false);
            this.pPlacar.PerformLayout();
            this.pImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo7)).EndInit();
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
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.PictureBox pbJogo7;
        private System.Windows.Forms.PictureBox pbJogo6;
        private System.Windows.Forms.PictureBox pbJogo5;
        private System.Windows.Forms.PictureBox pbJogo4;
        private System.Windows.Forms.PictureBox pbJogo3;
        private System.Windows.Forms.PictureBox pbJogo2;
        private System.Windows.Forms.PictureBox pbJogo1;
        private System.Windows.Forms.PictureBox pbJogo0;
    }
}

