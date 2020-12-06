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
    public partial class AdminBenutzer : Form
    {
        public AdminBenutzer()
        {
            InitializeComponent();
        }
        //zurück knopf
        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminmain Adminmain = new Adminmain();
            Adminmain.Show();
        }
        //benutzerhinzufügen knopf
        private void pbxbenutzerhinzufuegen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminbenutzerhinzufügen adminbenutzerhinzufügen = new Adminbenutzerhinzufügen();
            adminbenutzerhinzufügen.Show();
        }
        //schließen log
        private void pbxschließen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am Adminbenutzer Form Geschlossen");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am Adminbenutzer Form Geschlossen");
                sw.Close();
            }

            Application.Exit();
        }
        //minimize
        private void pbxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
