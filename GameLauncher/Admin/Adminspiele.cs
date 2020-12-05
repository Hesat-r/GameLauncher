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
    public partial class Adminspiele : Form
    {
        public Adminspiele()
        {
            InitializeComponent();
        }
        public List<string> Name = new List<string>();
        public List<string> Pfad = new List<string>();
        public List<string> Alter = new List<string>();
        public string benutzeralter;
        private void pbxzurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminmain Adminmain = new Adminmain();
            Adminmain.Show();
        }

       
        private void Adminspiele_Load(object sender, EventArgs e)
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
           
        }

    
        private void btnspiellöschen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Spiele.csv"))
            {
                StreamWriter sw = File.AppendText(@"spiele.csv");

                sw.Write(tbxspielenamen.Text);
                sw.Write(";");
                
            }
        }

        private void btnspielhinzufuegne_Click(object sender, EventArgs e)
        {
            
        }
    }
}
