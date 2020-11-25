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

        private void btnbenutzererstellen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\Benutzer.csv"))
            {
                StreamWriter sw = new StreamWriter(@"D:\Benutzer.csv");
                sw.WriteAsync(tbxvorname.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxnachname.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxbenutzername.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxpasswort.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxtag.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxmonat.Text);
                sw.WriteAsync(";");
                sw.WriteAsync(tbxjahr.Text);
                sw.Close();
            }
            else
            {

            }
          
        }
    }
}
