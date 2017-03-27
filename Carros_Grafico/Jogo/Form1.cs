using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnligar_Click(object sender, EventArgs e)
        {
            Carro uno = new Carro();
            uno.ligar("UNO", 1996, true);
            lblmodelo.Text = uno.modelo ;
            lblano.Text = uno.ano.ToString();
            lblstatus.Text = uno.status.ToString();
        }

        private void btndesligar_Click(object sender, EventArgs e)
        {
            Carro uno = new Carro();
            uno.Desligar(false);
            lblstatus.Text = uno.status.ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Carro uno = new Carro();
                piccarro.Left += uno.acelerar(20);
        }
    }
}
