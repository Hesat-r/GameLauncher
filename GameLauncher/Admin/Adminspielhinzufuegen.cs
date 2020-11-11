using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher.Admin
{
    public partial class Adminspielhinzufuegen : Form
    {
        public Adminspielhinzufuegen()
        {
            InitializeComponent();
        }

        private void btnbildpfad_Click(object sender, EventArgs e)
        {
            fbdbildpfad.ShowDialog();
            string path = fbdbildpfad.SelectedPath;

            MessageBox.Show(path, "test", MessageBoxButtons.OK);

        }

        private void btnspielepfad_Click(object sender, EventArgs e)
        {
            fbdspielpfad.ShowDialog();
            string path = fbdspielpfad.SelectedPath;

            MessageBox.Show(path, "test", MessageBoxButtons.OK);
        }
    }
}
