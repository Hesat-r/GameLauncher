using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.User
{
    public partial class Userspiele : Form
    {
        public Userspiele()
        {
            InitializeComponent();
        }

        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usermain usermain = new Usermain();
            usermain.Show();
        }

        private void Userspiele_Load(object sender, EventArgs e)
        {

        }
    }
}
