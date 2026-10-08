using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toturial2_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void showbackbutton_Click(object sender, EventArgs e)
        {
            cardface.Visible = false;
            cardback.Visible = true;
       
        }

        private void showfacebutton_Click(object sender, EventArgs e)
        {
            cardface.Visible = true;
            cardback.Visible = false;
        }
    }
}
