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
        public List<string> beschreibung = new List<string>();
        public string benutzeralter;
        public string pfadhinzufuegen;
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
                beschreibung.Add(spalten[3]);
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
                sw.Write(pfadhinzufuegen);
                sw.Write(";");
                sw.Write(tbxspielealterhinzufuegen.Text);
                sw.Write(";");
                sw.WriteLine(tbxbeschreibung.Text);
                sw.Close();
            }
        }

        private void btnspielhinzufuegne_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Spiele.csv"))
            {
                StreamWriter sw = File.AppendText(@"spiele.csv");
                MessageBox.Show(pfadhinzufuegen, "test", MessageBoxButtons.OK);
                sw.Write(tbxspielenamen.Text);
                sw.Write(";");
                sw.Write(pfadhinzufuegen);
                sw.Write(";");
                sw.Write(tbxspielealterhinzufuegen.Text);
                sw.Write(";");
                sw.WriteLine(tbxbeschreibung.Text);
                sw.Close();
            }
            
            
        }

        private void btnspielepfad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pfadhinzufuegen = ofd.FileName;
            MessageBox.Show(pfadhinzufuegen, "test", MessageBoxButtons.OK);
        }
    }
}
