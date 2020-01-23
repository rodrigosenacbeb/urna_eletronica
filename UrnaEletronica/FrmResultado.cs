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
    public partial class FrmResultado : Form
    {
        public FrmResultado(int silvio, int fausto, int gloria, int gretchen, int branco)
        {
            InitializeComponent();
            lblSilvio.Text = silvio.ToString();
            lblFausto.Text = fausto.ToString();
            lblGloria.Text = gloria.ToString();
            lblGretchen.Text = gretchen.ToString();
            lblBranco.Text = branco.ToString();
        }
    }
}
