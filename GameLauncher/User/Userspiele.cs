using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
        //zurück button zum usermain
        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usermain usermain = new Usermain();
            usermain.Show();
        }

    
       //List strings
        public List<string> Name = new List<string>();
        public List<string> Pfad = new List<string>();
        public List<string> Alter = new List<string>();
        public List<string> beschreibung = new List<string>();
        public string benutzeralter;
      
        
        private void btnspielstarten_Click(object sender, EventArgs e)
        {

            
            int index = lbxspiele.SelectedIndex;
            //benutzeralter wird in einer variablen gepackt
            if (File.Exists(@"alter.txt"))
            {
                StreamReader sr = File.OpenText(@"alter.txt");
                benutzeralter = sr.ReadLine();
                
            }
            else
            {
                MessageBox.Show("Die Alter.txt datei konnte nicht in pfad gefunden werden es kann sein das die datei beschädigt wurde wir bitten sie die datei manuell zu erstellen und ein alter einzugeben", "FEHLER!", MessageBoxButtons.OK);
            }

           // ALTER ABFRAGE!
            if (Convert.ToInt32(benutzeralter) < Convert.ToInt32(Alter[index]))
            {
                MessageBox.Show("Du Hast noch nicht das alter erreicht um das spiel spielen zu können", "Fehler", MessageBoxButtons.OK);
               
            }
            else
            {
                //spiel wird geöffnet von der csv datei
                if (File.Exists(Pfad[index]))
                {
                    Process spielstarten = new Process();
                    spielstarten.StartInfo.UseShellExecute = false;
                    spielstarten.StartInfo.FileName = Pfad[index];
                    spielstarten.Start();
                    MessageBox.Show("Spiel erfolgreich gestartet", "Erfolgreich", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Spiel Konnte nicht gestartet werden", "Fehler", MessageBoxButtons.OK);
                }
               

            }
            


        }
        //spiele werden beim form öffnen in die listbox geladen
        private void Userspiele_Load(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText((@"Spiele.csv"));

            string geleseneZeile;
            while (!sr.EndOfStream)
            {

                geleseneZeile = sr.ReadLine();
                string[] spalten = geleseneZeile.Split(';');

                Name.Add(spalten[0]);
                Pfad.Add(spalten[1]);
                Alter.Add(spalten[2]);
                beschreibung.Add(spalten[3]);
                lbxspiele.Items.Add(spalten[0]);

            }
            sr.Close();
            
            
        }
        //beim auswählen ändert sich die spielebeschreibung / alter
        private void lbxspiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;
            lblalterzahl.Text = Alter[index];
            lblspielebeschreibung.Text = beschreibung[index];
        }
        // LOG programm wurde bei userpsiele geschlossen 
        private void pbxschließen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " Am Userspielen Form Geschlossen");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " Am Userspielen Form Geschlossen");
                sw.Close();
            }

            Application.Exit();
        }

        private void pbxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
