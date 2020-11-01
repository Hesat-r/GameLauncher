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
    public partial class Adminmain : Form
    {
        public Adminmain()
        {
            InitializeComponent();
        }

        private void pbxadminbenutzer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBenutzer adminbenutzer = new AdminBenutzer();
            adminbenutzer.Show();
        }

        private void pbxadminspiele_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminspiele adminspiele = new Adminspiele();
            adminspiele.Show();
        }

        private void pbxadmineinstellung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admineinstellungen admineinstellung = new Admineinstellungen();
            admineinstellung.Show();
        }

        private void pbxadminausloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
