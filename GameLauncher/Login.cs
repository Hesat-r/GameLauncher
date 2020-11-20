using GameLauncher.Admin;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string[] benutzerfile = File.ReadAllLines(@"D:\Benutzer.csv");
            
            //foreach (var benutzer in benutzerfile)
            //{
            //    string[] spalten = benutzer.Split(';');
            //    Console.WriteLine(spalten[2]);

            //    string[] passwortspalte = benutzer.Split(';');
            //    Console.WriteLine(passwortspalte[4]);


            //}
            

            if (File.Exists(@"D:\Benutzer.csv"))
            {
                StreamReader sr = File.OpenText((@"D:\Benutzer.csv"));

                string geleseneZeile;
                while (!sr.EndOfStream)
                {
                    geleseneZeile = sr.ReadLine();
                    string[] spalten = geleseneZeile.Split(';');
                    if (tbxBenutzerLogin.Text == spalten[2])
                    {
                        if (tbxpasswort.Text == spalten[4])
                        {
                            MessageBox.Show("Erfolgreich eingelogt", "Erfolgreich", MessageBoxButtons.OK);

                            angemeldet = true;

                        }
                    }
                }
                if (angemeldet == true)
                {
                    this.Hide();
                    Usermain usermain = new Usermain();
                    usermain.Show();
                }
                sr.Close();
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
