using System;
using System.IO;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            if (File.Exists(@"benutzer.csv"))
            {
                int alter = DateTime.Today.Year - Convert.ToInt32(dtpgeburtstag.Value.Year);
                StreamWriter sw = File.AppendText(@"benutzer.csv");
                sw.Write(tbxVornameRegister.Text);
                sw.Write(";");
                sw.Write(tbxNameRegister.Text);
                sw.Write(";");
                sw.Write(tbxBenutzerRegister.Text);
                sw.Write(";");
                sw.Write(tbxPasswortRegister.Text);
                sw.Write(";");
                sw.Write(dtpgeburtstag.Text);
                sw.Write(";");
                if (rbtnadminrechte.Checked == true)
                {
                    sw.Write("1");
                }
                else
                {
                    sw.Write("0");
                }

                sw.Write(";");
                sw.WriteLine(alter);
                sw.Close();
               
               
            }

            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
