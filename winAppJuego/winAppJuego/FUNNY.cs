using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAppJuego
{
    public partial class FUNNY : Form
    {
        public FUNNY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _1 objForm = new _1();
            objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu objForm = new Menu();
            objForm.Show();
        }
    }
}
