using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

       
    }
}
