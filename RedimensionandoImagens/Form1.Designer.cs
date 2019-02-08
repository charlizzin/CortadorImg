namespace RedimensionandoImagens
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNovoTamanhoImagem = new System.Windows.Forms.Label();
            this.lblTamanhoOriginal = new System.Windows.Forms.Label();
            this.btnRedimensionarImagem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupImagem = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinoImagem = new System.Windows.Forms.TextBox();
            this.txtOrigemImagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarImagem = new System.Windows.Forms.Button();
            this.btnProcurarImagem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picImagem);
            this.panel1.Location = new System.Drawing.Point(8, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 226);
            this.panel1.TabIndex = 1;
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.picImagem.Location = new System.Drawing.Point(4, 3);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(746, 218);
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblNovoTamanhoImagem);
            this.panel2.Controls.Add(this.lblTamanhoOriginal);
            this.panel2.Controls.Add(this.btnRedimensionarImagem);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nupImagem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDestinoImagem);
            this.panel2.Controls.Add(this.txtOrigemImagem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSalvarImagem);
            this.panel2.Controls.Add(this.btnProcurarImagem);
            this.panel2.Location = new System.Drawing.Point(8, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 181);
            this.panel2.TabIndex = 2;
            // 
            // lblNovoTamanhoImagem
            // 
            this.lblNovoTamanhoImagem.AutoSize = true;
            this.lblNovoTamanhoImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNovoTamanhoImagem.Location = new System.Drawing.Point(310, 92);
            this.lblNovoTamanhoImagem.Name = "lblNovoTamanhoImagem";
            this.lblNovoTamanhoImagem.Size = new System.Drawing.Size(35, 13);
            this.lblNovoTamanhoImagem.TabIndex = 12;
            this.lblNovoTamanhoImagem.Text = "label6";
            // 
            // lblTamanhoOriginal
            // 
            this.lblTamanhoOriginal.AutoSize = true;
            this.lblTamanhoOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTamanhoOriginal.Location = new System.Drawing.Point(310, 48);
            this.lblTamanhoOriginal.Name = "lblTamanhoOriginal";
            this.lblTamanhoOriginal.Size = new System.Drawing.Size(37, 13);
            this.lblTamanhoOriginal.TabIndex = 11;
            this.lblTamanhoOriginal.Text = "lablel5";
            // 
            // btnRedimensionarImagem
            // 
            this.btnRedimensionarImagem.BackColor = System.Drawing.Color.White;
            this.btnRedimensionarImagem.Image = global::RedimensionandoImagens.Properties.Resources.tool;
            this.btnRedimensionarImagem.Location = new System.Drawing.Point(498, 128);
            this.btnRedimensionarImagem.Name = "btnRedimensionarImagem";
            this.btnRedimensionarImagem.Size = new System.Drawing.Size(99, 47);
            this.btnRedimensionarImagem.TabIndex = 10;
            this.btnRedimensionarImagem.Text = "Redimensionar";
            this.btnRedimensionarImagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedimensionarImagem.UseVisualStyleBackColor = false;
            this.btnRedimensionarImagem.Visible = false;
            this.btnRedimensionarImagem.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Novo Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tamanho Original";
            // 
            // nupImagem
            // 
            this.nupImagem.Location = new System.Drawing.Point(314, 133);
            this.nupImagem.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nupImagem.Name = "nupImagem";
            this.nupImagem.Size = new System.Drawing.Size(58, 20);
            this.nupImagem.TabIndex = 7;
            this.nupImagem.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentual  Largura/Altura Original";
            this.label3.Visible = false;
            // 
            // txtDestinoImagem
            // 
            this.txtDestinoImagem.Location = new System.Drawing.Point(213, 69);
            this.txtDestinoImagem.Name = "txtDestinoImagem";
            this.txtDestinoImagem.Size = new System.Drawing.Size(525, 20);
            this.txtDestinoImagem.TabIndex = 5;
            // 
            // txtOrigemImagem
            // 
            this.txtOrigemImagem.Location = new System.Drawing.Point(213, 25);
            this.txtOrigemImagem.Name = "txtOrigemImagem";
            this.txtOrigemImagem.Size = new System.Drawing.Size(525, 20);
            this.txtOrigemImagem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imagem Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagem Origem";
            // 
            // btnSalvarImagem
            // 
            this.btnSalvarImagem.BackColor = System.Drawing.Color.White;
            this.btnSalvarImagem.Image = global::RedimensionandoImagens.Properties.Resources.save;
            this.btnSalvarImagem.Location = new System.Drawing.Point(604, 127);
            this.btnSalvarImagem.Name = "btnSalvarImagem";
            this.btnSalvarImagem.Size = new System.Drawing.Size(99, 47);
            this.btnSalvarImagem.TabIndex = 1;
            this.btnSalvarImagem.Text = "Salvar Imagem";
            this.btnSalvarImagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarImagem.UseVisualStyleBackColor = false;
            this.btnSalvarImagem.Visible = false;
            this.btnSalvarImagem.Click += new System.EventHandler(this.btnSalvarImagem_Click);
            // 
            // btnProcurarImagem
            // 
            this.btnProcurarImagem.BackColor = System.Drawing.Color.White;
            this.btnProcurarImagem.Image = global::RedimensionandoImagens.Properties.Resources.find3;
            this.btnProcurarImagem.Location = new System.Drawing.Point(10, 22);
            this.btnProcurarImagem.Name = "btnProcurarImagem";
            this.btnProcurarImagem.Size = new System.Drawing.Size(99, 59);
            this.btnProcurarImagem.TabIndex = 0;
            this.btnProcurarImagem.Text = "Procurar Imagem";
            this.btnProcurarImagem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurarImagem.UseVisualStyleBackColor = false;
            this.btnProcurarImagem.Click += new System.EventHandler(this.btnProcurarImagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 436);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redimensionando Imagens";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRedimensionarImagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupImagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinoImagem;
        private System.Windows.Forms.TextBox txtOrigemImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarImagem;
        private System.Windows.Forms.Button btnProcurarImagem;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label lblTamanhoOriginal;
        private System.Windows.Forms.Label lblNovoTamanhoImagem;

    }
}

