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
            this.pnlpasswort = new System.Windows.Forms.Panel();
            this.tbxpasswort = new System.Windows.Forms.TextBox();
            this.pbxpasswort = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblgame = new System.Windows.Forms.Label();
            this.lbllauncher = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.pbxminimize = new System.Windows.Forms.PictureBox();
            this.pbxschließen = new System.Windows.Forms.PictureBox();
            this.pnlBenutzerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBenutzerLogin)).BeginInit();
            this.pnlpasswort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpasswort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxschließen)).BeginInit();
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
            this.tbxBenutzerLogin.Location = new System.Drawing.Point(84, 14);
            this.tbxBenutzerLogin.Name = "tbxBenutzerLogin";
            this.tbxBenutzerLogin.Size = new System.Drawing.Size(370, 42);
            this.tbxBenutzerLogin.TabIndex = 1;
            this.tbxBenutzerLogin.Text = "Email";
            this.tbxBenutzerLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbxBenutzerLogin
            // 
            this.pbxBenutzerLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxBenutzerLogin.Image")));
            this.pbxBenutzerLogin.Location = new System.Drawing.Point(6, 3);
            this.pbxBenutzerLogin.Name = "pbxBenutzerLogin";
            this.pbxBenutzerLogin.Size = new System.Drawing.Size(72, 53);
            this.pbxBenutzerLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBenutzerLogin.TabIndex = 0;
            this.pbxBenutzerLogin.TabStop = false;
            // 
            // pnlpasswort
            // 
            this.pnlpasswort.Controls.Add(this.tbxpasswort);
            this.pnlpasswort.Controls.Add(this.pbxpasswort);
            this.pnlpasswort.Location = new System.Drawing.Point(135, 439);
            this.pnlpasswort.Name = "pnlpasswort";
            this.pnlpasswort.Size = new System.Drawing.Size(454, 59);
            this.pnlpasswort.TabIndex = 1;
            // 
            // tbxpasswort
            // 
            this.tbxpasswort.AcceptsReturn = true;
            this.tbxpasswort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxpasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxpasswort.Font = new System.Drawing.Font("Arial", 22.25F);
            this.tbxpasswort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxpasswort.Location = new System.Drawing.Point(81, 14);
            this.tbxpasswort.Name = "tbxpasswort";
            this.tbxpasswort.PasswordChar = '*';
            this.tbxpasswort.Size = new System.Drawing.Size(370, 42);
            this.tbxpasswort.TabIndex = 2;
            this.tbxpasswort.Text = "Passwort";
            this.tbxpasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxpasswort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxpasswort_KeyDown);
            // 
            // pbxpasswort
            // 
            this.pbxpasswort.Image = ((System.Drawing.Image)(resources.GetObject("pbxpasswort.Image")));
            this.pbxpasswort.Location = new System.Drawing.Point(6, 3);
            this.pbxpasswort.Name = "pbxpasswort";
            this.pbxpasswort.Size = new System.Drawing.Size(72, 53);
            this.pbxpasswort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxpasswort.TabIndex = 0;
            this.pbxpasswort.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(135, 521);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(197, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblgame
            // 
            this.lblgame.AutoSize = true;
            this.lblgame.Font = new System.Drawing.Font("Paper Flowers", 102.25F);
            this.lblgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.lblgame.Location = new System.Drawing.Point(101, 58);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(231, 141);
            this.lblgame.TabIndex = 4;
            this.lblgame.Text = "Game";
            // 
            // lbllauncher
            // 
            this.lbllauncher.AutoSize = true;
            this.lbllauncher.Font = new System.Drawing.Font("Paper Flowers", 82.25F);
            this.lbllauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lbllauncher.Location = new System.Drawing.Point(248, 190);
            this.lbllauncher.Name = "lbllauncher";
            this.lbllauncher.Size = new System.Drawing.Size(315, 113);
            this.lbllauncher.TabIndex = 5;
            this.lbllauncher.Text = "Launcher";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregister.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.Black;
            this.btnregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregister.Location = new System.Drawing.Point(389, 521);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(197, 67);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "Registrieren";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // pbxminimize
            // 
            this.pbxminimize.Image = ((System.Drawing.Image)(resources.GetObject("pbxminimize.Image")));
            this.pbxminimize.Location = new System.Drawing.Point(600, 12);
            this.pbxminimize.Name = "pbxminimize";
            this.pbxminimize.Size = new System.Drawing.Size(64, 55);
            this.pbxminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxminimize.TabIndex = 13;
            this.pbxminimize.TabStop = false;
            this.pbxminimize.Click += new System.EventHandler(this.pbxminimize_Click);
            // 
            // pbxschließen
            // 
            this.pbxschließen.Image = ((System.Drawing.Image)(resources.GetObject("pbxschließen.Image")));
            this.pbxschließen.Location = new System.Drawing.Point(670, 12);
            this.pbxschließen.Name = "pbxschließen";
            this.pbxschließen.Size = new System.Drawing.Size(64, 55);
            this.pbxschließen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxschließen.TabIndex = 12;
            this.pbxschließen.TabStop = false;
            this.pbxschließen.Click += new System.EventHandler(this.pbxschließen_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(725, 693);
            this.Controls.Add(this.pbxminimize);
            this.Controls.Add(this.pbxschließen);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.lbllauncher);
            this.Controls.Add(this.lblgame);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlpasswort);
            this.Controls.Add(this.pnlBenutzerLogin);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(741, 732);
            this.MinimumSize = new System.Drawing.Size(741, 732);
            this.Name = "Login";
            this.Text = "Login";
            this.pnlBenutzerLogin.ResumeLayout(false);
            this.pnlBenutzerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBenutzerLogin)).EndInit();
            this.pnlpasswort.ResumeLayout(false);
            this.pnlpasswort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpasswort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxschließen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBenutzerLogin;
        private System.Windows.Forms.TextBox tbxBenutzerLogin;
        private System.Windows.Forms.PictureBox pbxBenutzerLogin;
        private System.Windows.Forms.Panel pnlpasswort;
        private System.Windows.Forms.TextBox tbxpasswort;
        private System.Windows.Forms.PictureBox pbxpasswort;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.Label lbllauncher;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.PictureBox pbxminimize;
        private System.Windows.Forms.PictureBox pbxschließen;
    }
}

