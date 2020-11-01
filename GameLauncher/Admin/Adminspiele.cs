using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Admin
{
    public partial class Adminspiele : Form
    {
        public Adminspiele()
        {
            InitializeComponent();
        }

        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminmain Adminmain = new Adminmain();
            Adminmain.Show();
        }
    }
}
