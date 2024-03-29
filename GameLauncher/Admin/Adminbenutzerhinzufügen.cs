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
    public partial class Adminbenutzerhinzufügen : Form
    {
        public Adminbenutzerhinzufügen()
        {
            InitializeComponent();
        }
        //adminbenutzerhinzufügen seite log
        private void Adminbenutzerhinzufügen_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Die AdminBenutzerhinzufügen seite wurde um " + DateTime.Now.ToString("F") + " Geöffnet");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Die adminBenutzerhinzufügen seite wurde um " + DateTime.Now.ToString("F") + " Geöffnet");
                sw.Close();
            }
        }
        //benutzer erstellen
        private void btnbenutzererstellen_Click(object sender, EventArgs e)
        {
            int alter = DateTime.Today.Year - Convert.ToInt32(dtpgeburtstag.Value.Year);
            StreamWriter sw = File.AppendText(@"benutzer.csv");
            sw.Write(tbxvorname.Text);
            sw.Write(";");
            sw.Write(tbxnachname.Text);
            sw.Write(";");
            sw.Write(tbxbenutzername.Text);
            sw.Write(";");
            sw.Write(tbxpasswort.Text);
            sw.Write(";");
            sw.Write(dtpgeburtstag.Text);
            sw.Write(";");
            sw.Write("0");
            sw.Write(";");
            sw.WriteLine(alter);
            sw.Close();


        }
        //schließen log
        private void pbxschließen_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt"))
            {
                StreamWriter sw = File.AppendText(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");

                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am Adminbenutzerhinzufügen Form Geschlossen");
                sw.Close();
            }
            else
            {

                StreamWriter sw = new StreamWriter(@"log\" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + ".txt");
                sw.WriteLine("Das Programm wurde am " + DateTime.Now.ToString("F") + " am Adminbenutzerhinzufügen Form Geschlossen");
                sw.Close();
            }

            Application.Exit();
        }
        // minimize
        private void pbxminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxzurueck_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Adminmain adminmain = new Adminmain();
            adminmain.Show();
        }
    }
}
