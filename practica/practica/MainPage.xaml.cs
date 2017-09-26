using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace practica
{
    public partial class MainPage : ContentPage
    {
        float uno;
        float dos;
        String op;
        float rsl;

        public MainPage()
        {
            InitializeComponent();
           
        }
        private void a_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "1";
        }
        private void b_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "2";
        }
        private void c_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "3";
        }
        private void d_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "4";
        }
        private void e_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "5";
        }
        private void f_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "6";
        }
        private void g_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "7";
        }
        private void h_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "8";
        }
        private void i_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "9";
        }
        private void j_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + "0";
        }
        private void punto_Clicked(object sender, EventArgs o)
        {
            caja.Text = caja.Text + ".";
        }
        private void l_Clicked(object sender, EventArgs o)
        {
            double raiz = double.Parse(caja.Text);
            double rl;
            rl = Math.Sqrt(raiz);
            caja.Text = "" + rl;
        }
        private void lim_Clicked(object sender, EventArgs o)
        {
            caja.Text = null;
            uno = 0;
            dos = 0;
            op = null;
        }
        private void suma_Clicked(object sender, EventArgs o)
        {
            op = "+";
            uno = float.Parse(caja.Text);
            caja.Text = null;
        }
        private void r_Clicked(object sender, EventArgs o)
        {
            op = "-";
            uno = float.Parse(caja.Text);
            caja.Text = null;
        }
        private void o_Clicked(object sender, EventArgs o)
        {
            op = "*";
            uno = float.Parse(caja.Text);
            caja.Text = null;
        }
        private void k_Clicked(object sender, EventArgs o)
        {
            op = "/";
            uno = float.Parse(caja.Text);
            caja.Text = null;
        }
        private void p_Clicked(object sender, EventArgs o)
        {
            dos = float.Parse(caja.Text);
            if (op.Equals("+"))
            {
                suma();
            }
            if (op.Equals("-"))
            {
                resta();
            }
            if (op.Equals("*"))
            {
                multi();
            }
            if (op.Equals("/"))
            {
                div();
            }

        }

        private void div()
        {
            rsl = uno / dos;
            caja.Text = "" + rsl;
        }

        private void multi()
        {
            rsl = uno * dos;
            caja.Text = "" + rsl;
        }

        private void suma()
        {
            rsl = uno + dos;
            caja.Text=""+rsl;
        }

        private void resta()
        {
            rsl = uno - dos;
            caja.Text = "" +rsl;
        }
    }
}
