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

namespace GameLauncher
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(@"D:\Benutzer.csv"))
            {
              
                StreamWriter sw = File.AppendText(@"D:\Benutzer.csv");
                sw.Write(tbxVornameRegister.Text);
                sw.Write(";");
                sw.Write(tbxNameRegister.Text);
                sw.Write(";");
                sw.Write(tbxBenutzerRegister.Text);
                sw.Write(";");
                sw.Write(tbxPasswortRegister.Text);
                sw.Write(";");
                sw.Write(tbxtag.Text);
                sw.Write(".");
                sw.Write(tbxmonat.Text);
                sw.Write(".");
                sw.Write(tbxjahr.Text);
                sw.Write(";");
                if (rbtnadminrechte.Checked == true)
                {
                    sw.WriteLine("1");
                }
                else
                {
                    sw.WriteLine("0");
                }

                
                sw.Close();
            }

            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
