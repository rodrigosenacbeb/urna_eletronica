using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Para guardar a quantidade de votos de cada candidato.
        int silvio, faustao, gloria, gretchen, branco = 0;

        void NovoDigito(string digito)
        {
            if (txtNumero1.Text == "")
                txtNumero1.Text = digito;
            else
            {
                txtNumero2.Text = digito;
                ValidarVoto();
            }
        }

        void ValidarVoto()
        {
            switch (txtNumero1.Text + txtNumero2.Text)
            {
                case "11":
                    pcbCandidato.BackgroundImage = Image.FromFile("silvio.jpg");
                    lblNomeCandidato.Text = "Silvio Santos";
                    lblNomeCandidato.Visible = true;
                    break;
                case "21":
                    pcbCandidato.BackgroundImage = Image.FromFile("fausto.jpg");
                    lblNomeCandidato.Text = "Faustão";
                    lblNomeCandidato.Visible = true;
                    break;
                case "31":
                    pcbCandidato.BackgroundImage = Image.FromFile("gloria.jpg");
                    lblNomeCandidato.Text = "Glória Maria";
                    lblNomeCandidato.Visible = true;
                    break;
                case "41":
                    pcbCandidato.BackgroundImage = Image.FromFile("gretchen.jpg");
                    lblNomeCandidato.Text = "Gretchen";
                    lblNomeCandidato.Visible = true;
                    break;
                default:
                    MessageBox.Show("Candidato Inválido!");
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NovoDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NovoDigito("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NovoDigito("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NovoDigito("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NovoDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NovoDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NovoDigito("7");
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            pcbCandidato.BackgroundImage = null;
            lblNomeCandidato.Visible = false;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Visible = true;
            lblNomeCandidato.Text = "Voto em Branco";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (lblNomeCandidato.Text == "Voto em Branco")
            {
                branco++;
            }
            else
            {
                switch (txtNumero1.Text + txtNumero2.Text)
                {
                    case "11":
                        silvio++;
                        break;
                    case "21":
                        faustao++;
                        break;
                    case "31":
                        gloria++;
                        break;
                    case "41":
                        gretchen++;
                        break;
                    default:
                        MessageBox.Show("Você precisa informar um Voto Inválido!");
                        break;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NovoDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NovoDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NovoDigito("0");
        }
    }
}
