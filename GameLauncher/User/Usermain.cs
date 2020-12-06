using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("jemand hat sich um " + DateTime.Now.ToString("F") + " Ausgeloggt");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("jemand hat sich um " + DateTime.Now.ToString("F") + " Ausgeloggt");
                sw.Close();
            }
        }
    }
}
