﻿using System;
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
        public string ausgewählterpfad;
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

        //Funkioniert zurzeit nicht da dieganzezit dort steht das die array zu klein oder zu gr0ß ist was kein sinn macht
        private void btnspiellöschen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Spiele.csv"))
            {
                int index = lbxspiele.SelectedIndex;
                Pfad.Remove(Pfad[index]);
                Alter.Remove(Alter[index]);
                beschreibung.Remove(beschreibung[index]);
                lbxspiele.Items.Remove(Name[index]);
                
                int anzahl = Name.Count;
                for (int i = 0; i < anzahl; i++)
                {
                    if (File.Exists(@"Spiele.csv"))
                    {
                        using (System.IO.StreamWriter file =
                         new System.IO.StreamWriter(@"spiele.csv", true))
                        {
                            file.Write(Name[i]);
                            file.Write(";");
                            file.Write(Pfad[i]);
                            file.Write(";");
                            file.Write(Alter[i]);
                            file.Write(";");
                            file.Write(beschreibung[i]);
                            file.Write(";");
                            file.WriteLine("");
                        }
                    }
                }

            }

        }

        private void btnspielhinzufuegne_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Spiele.csv"))
            {
                StreamWriter sw = File.AppendText(@"spiele.csv");
                sw.Write(tbxspielenamen.Text);
                sw.Write(";");
                sw.Write(ausgewählterpfad);
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
            ausgewählterpfad = ofd.FileName;
            MessageBox.Show(ausgewählterpfad, "test", MessageBoxButtons.OK);
        }

        private void lbxspiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbxspiele.SelectedIndex;

            if(index == -1)
            {
                index++;
              
            }
            else
            {
                tbxspielenamenlöschen.Text = Name[index];
                tbxspielealter.Text = Alter[index];
            }
        }
    }
}
