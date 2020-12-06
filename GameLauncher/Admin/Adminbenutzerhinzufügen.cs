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
                StreamWriter sw = File.AppendText(@"D:\Benutzer.csv");
                sw.Write(tbxvorname.Text);
                sw.Write(";");
                sw.Write(tbxnachname.Text);
                sw.Write(";");
                sw.Write(tbxbenutzername.Text);
                sw.Write(";");
                sw.Write(tbxpasswort.Text);
                sw.Write(";");
                sw.Write(dtpgeburtstag.Text);
                sw.Write(";");
                sw.WriteLine("0");
                sw.Close();
            }
            else
            {

            }
          
        }
    }
}
