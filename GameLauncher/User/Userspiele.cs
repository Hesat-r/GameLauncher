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
        public string benutzeralter;
      

        private void btnspielstarten_Click(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;
           
           // ALTER ABFRAGE!
            if (Convert.ToInt32(benutzeralter) <= Convert.ToInt32(Alter[index]))
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

                lbxspiele.Items.Add(spalten[0]);

            }
            sr.Close();
            StreamReader srbenutzer = File.OpenText(@"benutzer.csv");
            string geleseneZeilebenutzer;
            while (!srbenutzer.EndOfStream)
            {
                geleseneZeilebenutzer = srbenutzer.ReadLine();
                string[] spalten = geleseneZeilebenutzer.Split(';');

                benutzeralter = spalten[6];
            }

            srbenutzer.Close();
        }
    }
}
