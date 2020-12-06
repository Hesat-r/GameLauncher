﻿using GameLauncher.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using GameLauncher.User;
using Microsoft.VisualBasic.FileIO;

namespace GameLauncher
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool angemeldet = false;
        public bool angemeldetadmin = false;
        public bool passwort = false;
        public bool benutzer = false;
        public bool admincheck = true;
        public string[] spalten = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (File.Exists(@"Benutzer.csv"))
            {
                StreamReader sr = File.OpenText((@"Benutzer.csv"));

                string geleseneZeile;
                while (!sr.EndOfStream)
                {
                    geleseneZeile = sr.ReadLine();
                    spalten = geleseneZeile.Split(';');

                    if (tbxBenutzerLogin.Text == spalten[2])
                    {
                        benutzer = true;
                        if (tbxpasswort.Text == spalten[3])
                        {

                            passwort = true;
                            MessageBox.Show("Erfolgreich eingelogt", "Erfolgreich", MessageBoxButtons.OK);
                            //alter.txt datei erstellen und alter vom eingeloggten benutzer in einer txt datei abspeichern
                            if (File.Exists(@"alter.txt"))
                            {
                                StreamWriter sw = new StreamWriter(@"alter.txt");
                                sw.WriteLine(spalten[6]);
                                sw.Close();
                            }
                            else
                            {
                                File.Create(@"alter.txt");
                                StreamWriter sw = new StreamWriter(@"alter.txt");
                                sw.WriteLine(spalten[6]);
                                sw.Close();
                            }

                            if (spalten[5] == "0" && benutzer == true && passwort == true)
                            {
                                angemeldet = true;
                                MessageBox.Show(spalten[6], "test", MessageBoxButtons.OK);
                                this.Hide();
                                Userspiele userspiele = new Userspiele();
                                userspiele.Show();

                            }
                            else if (spalten[5] == "1" && benutzer == true && passwort == true)
                            {
                                angemeldetadmin = true;
                                MessageBox.Show(spalten[6], "test", MessageBoxButtons.OK);
                                this.Hide();
                                Adminmain adminmain = new Adminmain();
                                adminmain.Show();
                            }

                        }


                    }

                }

                sr.Close();
            }
            else
            {
                File.Create(@"Benutzer.csv");
                return;
            }







        }
        private void tbxpasswort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

      
    }
}
