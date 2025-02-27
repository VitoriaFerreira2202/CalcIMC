namespace PROVA_IMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblSituaçao = new Label();
            label5 = new Label();
            txtIMC = new TextBox();
            label8 = new Label();
            txtAltura = new TextBox();
            label6 = new Label();
            label4 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            buttonTotal = new Button();
            buttonDel = new Button();
            button06 = new Button();
            button03 = new Button();
            button09 = new Button();
            button0 = new Button();
            button05 = new Button();
            button02 = new Button();
            button08 = new Button();
            buttonVig = new Button();
            button04 = new Button();
            button01 = new Button();
            button07 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(64, 50);
            label2.Name = "label2";
            label2.Size = new Size(253, 18);
            label2.TabIndex = 1;
            label2.Text = "Informe o seu Peso e Altura";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSituaçao);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtIMC);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 282);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblSituaçao
            // 
            lblSituaçao.AutoSize = true;
            lblSituaçao.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSituaçao.Location = new Point(79, 220);
            lblSituaçao.Name = "lblSituaçao";
            lblSituaçao.Size = new Size(92, 23);
            lblSituaçao.TabIndex = 8;
            lblSituaçao.Text = "Situação";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(250, 142);
            label5.Name = "label5";
            label5.Size = new Size(28, 23);
            label5.TabIndex = 7;
            label5.Text = "m";
            // 
            // txtIMC
            // 
            txtIMC.Enabled = false;
            txtIMC.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIMC.Location = new Point(175, 175);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(69, 27);
            txtIMC.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(115, 175);
            label8.Name = "label8";
            label8.Size = new Size(47, 23);
            label8.TabIndex = 5;
            label8.Text = "IMC";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAltura.Location = new Point(175, 142);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(69, 27);
            txtAltura.TabIndex = 6;
            txtAltura.Enter += txtAltura_Enter;
            txtAltura.Leave += txtAltura_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(102, 142);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 5;
            label6.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 102);
            label4.Name = "label4";
            label4.Size = new Size(35, 23);
            label4.TabIndex = 4;
            label4.Text = "Kg";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(175, 102);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(69, 27);
            txtPeso.TabIndex = 3;
            txtPeso.Tag = "peso";
            txtPeso.Enter += txtPeso_Enter;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 102);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 2;
            label3.Text = "Peso";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(buttonTotal);
            panel2.Controls.Add(buttonDel);
            panel2.Controls.Add(button06);
            panel2.Controls.Add(button03);
            panel2.Controls.Add(button09);
            panel2.Controls.Add(button0);
            panel2.Controls.Add(button05);
            panel2.Controls.Add(button02);
            panel2.Controls.Add(button08);
            panel2.Controls.Add(buttonVig);
            panel2.Controls.Add(button04);
            panel2.Controls.Add(button01);
            panel2.Controls.Add(button07);
            panel2.Location = new Point(29, 316);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 268);
            panel2.TabIndex = 3;
            // 
            // buttonTotal
            // 
            buttonTotal.BackColor = Color.Gold;
            buttonTotal.Location = new Point(64, 230);
            buttonTotal.Name = "buttonTotal";
            buttonTotal.Size = new Size(238, 24);
            buttonTotal.TabIndex = 12;
            buttonTotal.Text = "Calcula Índice de Massa Corporal";
            buttonTotal.UseVisualStyleBackColor = false;
            buttonTotal.Click += buttonTotal_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.Gold;
            buttonDel.Font = new Font("Segoe UI", 20F);
            buttonDel.Location = new Point(235, 175);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(67, 49);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // button06
            // 
            button06.BackColor = Color.Gold;
            button06.Font = new Font("Segoe UI", 20F);
            button06.Location = new Point(235, 65);
            button06.Name = "button06";
            button06.Size = new Size(67, 49);
            button06.TabIndex = 10;
            button06.Text = "6";
            button06.UseVisualStyleBackColor = false;
            button06.Click += Numero;
            // 
            // button03
            // 
            button03.BackColor = Color.Gold;
            button03.Font = new Font("Segoe UI", 20F);
            button03.Location = new Point(235, 120);
            button03.Name = "button03";
            button03.Size = new Size(67, 49);
            button03.TabIndex = 9;
            button03.Text = "3";
            button03.UseVisualStyleBackColor = false;
            button03.Click += Numero;
            // 
            // button09
            // 
            button09.BackColor = Color.Gold;
            button09.Font = new Font("Segoe UI", 20F);
            button09.Location = new Point(235, 10);
            button09.Name = "button09";
            button09.Size = new Size(67, 49);
            button09.TabIndex = 8;
            button09.Text = "9";
            button09.UseVisualStyleBackColor = false;
            button09.Click += Numero;
            // 
            // button0
            // 
            button0.BackColor = Color.Gold;
            button0.Font = new Font("Segoe UI", 20F);
            button0.Location = new Point(150, 175);
            button0.Name = "button0";
            button0.Size = new Size(68, 49);
            button0.TabIndex = 7;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += Numero;
            // 
            // button05
            // 
            button05.BackColor = Color.Gold;
            button05.Font = new Font("Segoe UI", 20F);
            button05.Location = new Point(150, 65);
            button05.Name = "button05";
            button05.Size = new Size(68, 49);
            button05.TabIndex = 6;
            button05.Text = "5";
            button05.UseVisualStyleBackColor = false;
            button05.Click += Numero;
            // 
            // button02
            // 
            button02.BackColor = Color.Gold;
            button02.Font = new Font("Segoe UI", 20F);
            button02.Location = new Point(150, 120);
            button02.Name = "button02";
            button02.Size = new Size(68, 49);
            button02.TabIndex = 5;
            button02.Text = "2";
            button02.UseVisualStyleBackColor = false;
            button02.Click += Numero;
            // 
            // button08
            // 
            button08.BackColor = Color.Gold;
            button08.Font = new Font("Segoe UI", 20F);
            button08.Location = new Point(150, 10);
            button08.Name = "button08";
            button08.Size = new Size(68, 49);
            button08.TabIndex = 4;
            button08.Text = "8";
            button08.UseVisualStyleBackColor = false;
            button08.Click += Numero;
            // 
            // buttonVig
            // 
            buttonVig.BackColor = Color.Gold;
            buttonVig.Font = new Font("Segoe UI", 20F);
            buttonVig.Location = new Point(64, 175);
            buttonVig.Name = "buttonVig";
            buttonVig.Size = new Size(66, 49);
            buttonVig.TabIndex = 3;
            buttonVig.Text = ",";
            buttonVig.UseVisualStyleBackColor = false;
            buttonVig.Click += buttonVig_Click;
            // 
            // button04
            // 
            button04.BackColor = Color.Gold;
            button04.Font = new Font("Segoe UI", 20F);
            button04.Location = new Point(64, 65);
            button04.Name = "button04";
            button04.Size = new Size(66, 49);
            button04.TabIndex = 2;
            button04.Text = "4";
            button04.UseVisualStyleBackColor = false;
            button04.Click += Numero;
            // 
            // button01
            // 
            button01.BackColor = Color.Gold;
            button01.Font = new Font("Segoe UI", 20F);
            button01.Location = new Point(64, 120);
            button01.Name = "button01";
            button01.Size = new Size(66, 49);
            button01.TabIndex = 1;
            button01.Text = "1";
            button01.UseVisualStyleBackColor = false;
            button01.Click += Numero;
            // 
            // button07
            // 
            button07.BackColor = Color.Gold;
            button07.Font = new Font("Segoe UI", 20F);
            button07.Location = new Point(64, 10);
            button07.Name = "button07";
            button07.Size = new Size(66, 49);
            button07.TabIndex = 0;
            button07.Text = "7";
            button07.UseVisualStyleBackColor = false;
            button07.Click += Numero;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(429, 615);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calculadora";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button07;
        private Button buttonTotal;
        private Button buttonDel;
        private Button button06;
        private Button button03;
        private Button button09;
        private Button button0;
        private Button button05;
        private Button button02;
        private Button button08;
        private Button buttonVig;
        private Button button04;
        private Button button01;
        private Label label5;
        private TextBox txtAltura;
        private Label label6;
        private Label label4;
        private TextBox txtPeso;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblSituaçao;
        private TextBox txtIMC;
        private Label label8;
        private PictureBox pictureBox2;
    }
}
