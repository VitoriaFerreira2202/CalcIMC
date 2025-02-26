namespace PROVA_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
        }



        private void buttonTotal_Click(object sender, EventArgs e)
        {
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
        {
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

                if () 
                { 
                }
            }
            else
            {
                txtAltura.Text += Numero.Text;
                txtAltura.BackColor = Color.Red;
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            txtPeso.BackColor = Color.White;
             // txtPeso.Focus();
        }

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            txtAltura.BackColor = Color.White;
           // txtAltura.Focus();
        }
    }
}
