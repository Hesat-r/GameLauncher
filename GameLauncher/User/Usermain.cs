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
    public partial class Usermain : Form
    {
        public Usermain()
        {
            InitializeComponent();
        }

        private void pbxuserspielen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userspiele userspiele = new Userspiele();
            userspiele.Show();
        }

        private void pbxuserausloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
