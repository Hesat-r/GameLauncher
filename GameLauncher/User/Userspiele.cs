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

        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usermain usermain = new Usermain();
            usermain.Show();
        }

    
       
        public List<string> Name = new List<string>();
        public List<string> Pfad = new List<string>();
        public List<string> Alter = new List<string>();
        public List<string> beschreibung = new List<string>();
        public string benutzeralter;
      

        private void btnspielstarten_Click(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;
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

        private void lbxspiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;
            lblalterzahl.Text = Alter[index];
            lblspielebeschreibung.Text = beschreibung[index];
        }
    }
}
