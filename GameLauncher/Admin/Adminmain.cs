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
    public partial class Adminmain : Form
    {
        public Adminmain()
        {
            InitializeComponent();
        }
        //adminbenutzer wird geöffnet
        private void pbxadminbenutzer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminBenutzer adminbenutzer = new AdminBenutzer();
            adminbenutzer.Show();
        }
        //adminspiele wird geöffnet
        private void pbxadminspiele_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminspiele adminspiele = new Adminspiele();
            adminspiele.Show();
        }
        //admineinstellung wird geöffnet
        private void pbxadmineinstellung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admineinstellungen admineinstellung = new Admineinstellungen();
            admineinstellung.Show();
        }
        //user wird ausgeloggt
        private void pbxadminausloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        //admin seite geöffnet LOG
        private void Adminmain_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Die admin seite wurde am " + DateTime.Now.ToString("F") + " Geöffnet");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Die admin seite wurde am " + DateTime.Now.ToString("F") + " Geöffnet ");
                sw.Close();
            }
        }
        //Schließungs LOG
        private void pbxschließen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am adminmain Form Geschlossen");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am Adminmain Form Geschlossen");
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
