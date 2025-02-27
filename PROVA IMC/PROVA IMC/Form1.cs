namespace PROVA_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {//VAI LIMPA OS DOIS CAMPOS
            txtAltura.Clear();
            txtPeso.Clear();
        }



        private void buttonTotal_Click(object sender, EventArgs e)
        {
            if ((txtPeso.Text =="") && (txtAltura.Text == ""))
            {
                MessageBox.Show("OS CAMPOS ESTÃO VAZIO", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            
                var peso = float.Parse(txtPeso.Text);
                var altura = float.Parse(txtAltura.Text);
                var resulto = peso / (altura * 2);
                txtIMC.Text = resulto.ToString("N2");
           

            
            
             if (resulto < 19.1)
             {
                lblSituaçao.Text = " Abaixo do peso ";
             }
            else if ((resulto >= 19.1) && (resulto < 25.8))
            {
                lblSituaçao.Text = "PESO NORMAL";
            }
            else if ((resulto >= 25.8) && (resulto < 32.3))
            {
                lblSituaçao.Text = " ACIMA DO PESO ";
            }
            else
            {
                lblSituaçao.Text = " OBESO ";
            }
        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {// PARA SABER AONDE ESTA O FORCO
            txtPeso.BackColor = Color.Red;
            txtPeso.Tag = true;
            txtAltura.Tag = false;
        }

        private void txtAltura_Enter(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.Red;
            txtPeso.Tag = false;
            txtAltura.Tag = true;
        }

        private void Numero(object sender, EventArgs e)
        {
            Button Numero = sender as Button;

            if (txtPeso.Tag.Equals(true))
            {
                txtPeso.Text += Numero.Text;
                txtPeso.BackColor = Color.Red;
            }
            else
            {
                txtAltura.Text += Numero.Text;
                txtAltura.BackColor = Color.Red;
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {// AQUI É PARA MUDAR A COR DO CAMPO
            txtPeso.BackColor = Color.White;
            
        }

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.White;
          
        }

        private void buttonVig_Click(object sender, EventArgs e)
        {
            if (txtPeso.Tag.Equals(true)) 
            {
                if (!txtPeso.Text.Contains(","))
                {
                    if (txtPeso.Text.Length == 0)//AQUI SER NÃO TIVE NUMERO, VAI ACRESENTA A VIRGULA COM O ZERO
                    {
                        txtPeso.Text = "0,";
                    }
                    else
                    {
                        txtPeso.Text += ",";// SER TIVE O NUMERO, VAI ACRESENTA A VIGULA
                    }

                }
            }

            if (txtAltura.Tag.Equals(true))
            {
                if (!txtAltura.Text.Contains(","))
                {
                    if (txtAltura.Text.Length == 0)
                    {
                        txtAltura.Text = "0,";
                    }
                    else
                    {
                        txtAltura.Text += ",";
                    }

                }
            }

        }
    }
}
