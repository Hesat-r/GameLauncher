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
    public partial class Adminbenutzerhinzufügen : Form
    {
        public Adminbenutzerhinzufügen()
        {
            InitializeComponent();
        }

        private void Adminbenutzerhinzufügen_Load(object sender, EventArgs e)
        {

        }

        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminmain adminmain = new Adminmain();
            adminmain.Show();
        }
    }
}
