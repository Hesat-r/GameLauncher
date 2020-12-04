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

    
        private void pbxminecraftspielen_Click(object sender, EventArgs e)
        {
            string minecraft = "";
            if (File.Exists(minecraft))
            {
                Process PhasmoStarten2 = new Process();
                PhasmoStarten2.StartInfo.UseShellExecute = false;
                PhasmoStarten2.StartInfo.FileName = minecraft;
                PhasmoStarten2.StartInfo.CreateNoWindow = false;
                PhasmoStarten2.Start();
            }
            else
            {
                
                MessageBox.Show("Datei nicht vorhanden", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> Name = new List<string>();
        public List<string> Pfad = new List<string>();
        public List<string> Alter = new List<string>();
        public string benutzeralter;
        private void lbxspiele_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnspielstarten_Click(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;
            MessageBox.Show(Pfad[index],Alter[index],MessageBoxButtons.OK);
            MessageBox.Show(Convert.ToString(benutzeralter), "hi", MessageBoxButtons.OK);


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
