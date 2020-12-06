using System;
using System.IO;
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
           // Registriert den nuter
            if (File.Exists(@"benutzer.csv"))
            {
                int alter = DateTime.Today.Year - Convert.ToInt32(dtpgeburtstag.Value.Year);
                StreamWriter sw = File.AppendText(@"benutzer.csv");
                sw.Write(tbxVornameRegister.Text);
                sw.Write(";");
                sw.Write(tbxNameRegister.Text);
                sw.Write(";");
                sw.Write(tbxBenutzerRegister.Text);
                sw.Write(";");
                sw.Write(tbxPasswortRegister.Text);
                sw.Write(";");
                sw.Write(dtpgeburtstag.Text);
                sw.Write(";");
                //Admin-User Abfrage
                if (rbtnadminrechte.Checked == true)
                {
                    sw.Write("1");
                }
                else
                {
                    sw.Write("0");
                }

                sw.Write(";");
                sw.WriteLine(alter);
                sw.Close();
               
               
            }
            //Registrier LOG
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine(tbxBenutzerRegister.Text + " hat sich um " + DateTime.Now.ToString("F") + " Registriert");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine(tbxBenutzerRegister.Text + " hat sich um " + DateTime.Now.ToString("F") + " Registriert");
                sw.Close();
            }

            this.Hide();
            Login login = new Login();
            login.Show();
        }

       

        private void dtpgeburtstag_KeyDown(object sender, KeyEventArgs e)
        {
            // nach geburtagsabfrage enter als button benutzen
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(this, new EventArgs());
            }
        }

        private void pbxschließen_Click(object sender, EventArgs e)
        {
            // programm bei register geschlossen LOG + schließung
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " Beim Register Pannel Geschlossen");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " Beim Register Pannel Geschlossen");
                sw.Close();
            }

            Application.Exit();
        }
        // minimized die Form
        private void pbxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
