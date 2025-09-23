namespace DiceGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRoubar = new System.Windows.Forms.Button();
            this.btnRolar = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManter = new System.Windows.Forms.Button();
            this.numIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRoubar
            // 
            this.btnRoubar.Location = new System.Drawing.Point(421, 363);
            this.btnRoubar.Name = "btnRoubar";
            this.btnRoubar.Size = new System.Drawing.Size(75, 23);
            this.btnRoubar.TabIndex = 1;
            this.btnRoubar.Text = "Roubar";
            this.btnRoubar.UseVisualStyleBackColor = true;
            this.btnRoubar.Click += new System.EventHandler(this.btnRoubar_Click);
            // 
            // btnRolar
            // 
            this.btnRolar.Location = new System.Drawing.Point(296, 363);
            this.btnRolar.Name = "btnRolar";
            this.btnRolar.Size = new System.Drawing.Size(75, 23);
            this.btnRolar.TabIndex = 2;
            this.btnRolar.Text = "Rolar";
            this.btnRolar.UseVisualStyleBackColor = true;
            this.btnRolar.Click += new System.EventHandler(this.btnRolar_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblName1.Location = new System.Drawing.Point(12, 31);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(254, 37);
            this.lblName1.TabIndex = 3;
            this.lblName1.Text = "Nome Jogador 1";
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName2
            // 
            this.lblName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblName2.Location = new System.Drawing.Point(534, 31);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(256, 37);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "Nome Jogador 2";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placar";
            // 
            // btnManter
            // 
            this.btnManter.Location = new System.Drawing.Point(360, 388);
            this.btnManter.Name = "btnManter";
            this.btnManter.Size = new System.Drawing.Size(75, 23);
            this.btnManter.TabIndex = 7;
            this.btnManter.Text = "Manter";
            this.btnManter.UseVisualStyleBackColor = true;
            this.btnManter.Click += new System.EventHandler(this.btnManter_Click);
            // 
            // numIndicator
            // 
            this.numIndicator.Location = new System.Drawing.Point(380, 211);
            this.numIndicator.Name = "numIndicator";
            this.numIndicator.Size = new System.Drawing.Size(35, 13);
            this.numIndicator.TabIndex = 5;
            this.numIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numIndicator);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnRolar);
            this.Controls.Add(this.btnRoubar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRoubar;
        private System.Windows.Forms.Button btnRolar;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManter;
        private System.Windows.Forms.Label numIndicator;
    }
}

