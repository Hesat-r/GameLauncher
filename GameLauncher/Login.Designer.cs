namespace GameLauncher
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlBenutzerLogin = new System.Windows.Forms.Panel();
            this.tbxBenutzerLogin = new System.Windows.Forms.TextBox();
            this.pbxBenutzerLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblgame = new System.Windows.Forms.Label();
            this.lbllauncher = new System.Windows.Forms.Label();
            this.pnlBenutzerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBenutzerLogin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBenutzerLogin
            // 
            this.pnlBenutzerLogin.Controls.Add(this.tbxBenutzerLogin);
            this.pnlBenutzerLogin.Controls.Add(this.pbxBenutzerLogin);
            this.pnlBenutzerLogin.Location = new System.Drawing.Point(135, 338);
            this.pnlBenutzerLogin.Name = "pnlBenutzerLogin";
            this.pnlBenutzerLogin.Size = new System.Drawing.Size(454, 59);
            this.pnlBenutzerLogin.TabIndex = 0;
            // 
            // tbxBenutzerLogin
            // 
            this.tbxBenutzerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxBenutzerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBenutzerLogin.Font = new System.Drawing.Font("Arial", 22.25F);
            this.tbxBenutzerLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxBenutzerLogin.Location = new System.Drawing.Point(84, 0);
            this.tbxBenutzerLogin.Multiline = true;
            this.tbxBenutzerLogin.Name = "tbxBenutzerLogin";
            this.tbxBenutzerLogin.Size = new System.Drawing.Size(370, 53);
            this.tbxBenutzerLogin.TabIndex = 1;
            this.tbxBenutzerLogin.Text = "Email";
            this.tbxBenutzerLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxBenutzerLogin
            // 
            this.pbxBenutzerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBenutzerLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxBenutzerLogin.Image")));
            this.pbxBenutzerLogin.Location = new System.Drawing.Point(15, 0);
            this.pbxBenutzerLogin.Name = "pbxBenutzerLogin";
            this.pbxBenutzerLogin.Size = new System.Drawing.Size(72, 53);
            this.pbxBenutzerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBenutzerLogin.TabIndex = 0;
            this.pbxBenutzerLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(135, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 59);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 22.25F);
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(81, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Passwort";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(242, 526);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(197, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblgame
            // 
            this.lblgame.AutoSize = true;
            this.lblgame.Font = new System.Drawing.Font("Paper Flowers", 102.25F);
            this.lblgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(252)))), ((int)(((byte)(241)))));
            this.lblgame.Location = new System.Drawing.Point(146, 48);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(231, 141);
            this.lblgame.TabIndex = 4;
            this.lblgame.Text = "Game";
            // 
            // lbllauncher
            // 
            this.lbllauncher.AutoSize = true;
            this.lbllauncher.Font = new System.Drawing.Font("Paper Flowers", 102.25F);
            this.lbllauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lbllauncher.Location = new System.Drawing.Point(254, 173);
            this.lbllauncher.Name = "lbllauncher";
            this.lbllauncher.Size = new System.Drawing.Size(395, 141);
            this.lbllauncher.TabIndex = 5;
            this.lbllauncher.Text = "Launcher";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(725, 693);
            this.Controls.Add(this.lbllauncher);
            this.Controls.Add(this.lblgame);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBenutzerLogin);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlBenutzerLogin.ResumeLayout(false);
            this.pnlBenutzerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBenutzerLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBenutzerLogin;
        private System.Windows.Forms.TextBox tbxBenutzerLogin;
        private System.Windows.Forms.PictureBox pbxBenutzerLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.Label lbllauncher;
    }
}

