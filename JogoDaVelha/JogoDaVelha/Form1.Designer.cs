namespace JogoDaVelha
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
            this.buttonX = new System.Windows.Forms.Button();
            this.Placar = new System.Windows.Forms.Label();
            this.buttonO = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeJogo = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonX
            // 
            this.buttonX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(12, 43);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 52);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X";
            this.buttonX.UseMnemonic = false;
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.button1_Click);
            // 
            // Placar
            // 
            this.Placar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placar.Location = new System.Drawing.Point(22, 17);
            this.Placar.Name = "Placar";
            this.Placar.Size = new System.Drawing.Size(217, 23);
            this.Placar.TabIndex = 1;
            this.Placar.Text = "PLACAR";
            this.Placar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Placar.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonO
            // 
            this.buttonO.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonO.Location = new System.Drawing.Point(174, 43);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(75, 52);
            this.buttonO.TabIndex = 2;
            this.buttonO.Text = "O";
            this.buttonO.UseMnemonic = false;
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(12, 132);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 52);
            this.button11.TabIndex = 3;
            this.button11.UseMnemonic = false;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(93, 132);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 52);
            this.button12.TabIndex = 4;
            this.button12.UseMnemonic = false;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(174, 132);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 52);
            this.button13.TabIndex = 5;
            this.button13.UseMnemonic = false;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(12, 190);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 52);
            this.button21.TabIndex = 6;
            this.button21.UseMnemonic = false;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(93, 190);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 52);
            this.button22.TabIndex = 7;
            this.button22.UseMnemonic = false;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(174, 190);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 52);
            this.button23.TabIndex = 8;
            this.button23.UseMnemonic = false;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(12, 248);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 52);
            this.button31.TabIndex = 9;
            this.button31.UseMnemonic = false;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(93, 248);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 52);
            this.button32.TabIndex = 10;
            this.button32.UseMnemonic = false;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(174, 248);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 52);
            this.button33.TabIndex = 11;
            this.button33.UseMnemonic = false;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reiniciar.Location = new System.Drawing.Point(42, 320);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(172, 31);
            this.Reiniciar.TabIndex = 12;
            this.Reiniciar.Text = "REINICIAR";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // TimeJogo
            // 
            this.TimeJogo.Location = new System.Drawing.Point(42, 101);
            this.TimeJogo.Name = "TimeJogo";
            this.TimeJogo.Size = new System.Drawing.Size(172, 23);
            this.TimeJogo.TabIndex = 14;
            this.TimeJogo.Click += new System.EventHandler(this.TimeJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(263, 388);
            this.Controls.Add(this.TimeJogo);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.Placar);
            this.Controls.Add(this.buttonX);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da velha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Label Placar;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar TimeJogo;
    }
}

