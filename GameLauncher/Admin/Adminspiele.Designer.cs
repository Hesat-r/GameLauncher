namespace GameLauncher.Admin
{
    partial class Adminspiele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminspiele));
            this.lblLauncher = new System.Windows.Forms.Label();
            this.lblgame = new System.Windows.Forms.Label();
            this.pbxzurueck = new System.Windows.Forms.PictureBox();
            this.pnlspiellöschen = new System.Windows.Forms.Panel();
            this.tbxspielealter = new System.Windows.Forms.TextBox();
            this.btnspiellöschen = new System.Windows.Forms.Button();
            this.lblspiellöschen = new System.Windows.Forms.Label();
            this.btnspielepfadlöschen = new System.Windows.Forms.Button();
            this.tbxspielenamenlöschen = new System.Windows.Forms.TextBox();
            this.lbxspiele = new System.Windows.Forms.ListBox();
            this.pnlspielehinzufuegen = new System.Windows.Forms.Panel();
            this.tbxspielealterhinzufuegen = new System.Windows.Forms.TextBox();
            this.btnspielhinzufuegne = new System.Windows.Forms.Button();
            this.lblspielehinzufuegen = new System.Windows.Forms.Label();
            this.btnspielepfad = new System.Windows.Forms.Button();
            this.tbxspielenamen = new System.Windows.Forms.TextBox();
            this.tbxbeschreibung = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).BeginInit();
            this.pnlspiellöschen.SuspendLayout();
            this.pnlspielehinzufuegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLauncher
            // 
            this.lblLauncher.Font = new System.Drawing.Font("Paper Flowers", 100.75F);
            this.lblLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lblLauncher.Location = new System.Drawing.Point(515, 45);
            this.lblLauncher.Name = "lblLauncher";
            this.lblLauncher.Size = new System.Drawing.Size(546, 136);
            this.lblLauncher.TabIndex = 11;
            this.lblLauncher.Text = "Launcher";
            // 
            // lblgame
            // 
            this.lblgame.Font = new System.Drawing.Font("Paper Flowers", 100.75F);
            this.lblgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.lblgame.Location = new System.Drawing.Point(312, 45);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(386, 136);
            this.lblgame.TabIndex = 10;
            this.lblgame.Text = "Game";
            // 
            // pbxzurueck
            // 
            this.pbxzurueck.Image = ((System.Drawing.Image)(resources.GetObject("pbxzurueck.Image")));
            this.pbxzurueck.Location = new System.Drawing.Point(12, 12);
            this.pbxzurueck.Name = "pbxzurueck";
            this.pbxzurueck.Size = new System.Drawing.Size(75, 69);
            this.pbxzurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxzurueck.TabIndex = 10;
            this.pbxzurueck.TabStop = false;
            this.pbxzurueck.Click += new System.EventHandler(this.pbxzurueck_Click);
            // 
            // pnlspiellöschen
            // 
            this.pnlspiellöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlspiellöschen.Controls.Add(this.tbxspielealter);
            this.pnlspiellöschen.Controls.Add(this.btnspiellöschen);
            this.pnlspiellöschen.Controls.Add(this.lblspiellöschen);
            this.pnlspiellöschen.Controls.Add(this.btnspielepfadlöschen);
            this.pnlspiellöschen.Controls.Add(this.tbxspielenamenlöschen);
            this.pnlspiellöschen.Location = new System.Drawing.Point(418, 184);
            this.pnlspiellöschen.Name = "pnlspiellöschen";
            this.pnlspiellöschen.Size = new System.Drawing.Size(284, 312);
            this.pnlspiellöschen.TabIndex = 17;
            // 
            // tbxspielealter
            // 
            this.tbxspielealter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxspielealter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxspielealter.Font = new System.Drawing.Font("Arial", 16.25F);
            this.tbxspielealter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxspielealter.Location = new System.Drawing.Point(-1, 196);
            this.tbxspielealter.Multiline = true;
            this.tbxspielealter.Name = "tbxspielealter";
            this.tbxspielealter.Size = new System.Drawing.Size(284, 53);
            this.tbxspielealter.TabIndex = 17;
            this.tbxspielealter.Text = "spielealter";
            this.tbxspielealter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnspiellöschen
            // 
            this.btnspiellöschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspiellöschen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspiellöschen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspiellöschen.ForeColor = System.Drawing.Color.Black;
            this.btnspiellöschen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspiellöschen.Location = new System.Drawing.Point(3, 255);
            this.btnspiellöschen.Name = "btnspiellöschen";
            this.btnspiellöschen.Size = new System.Drawing.Size(276, 52);
            this.btnspiellöschen.TabIndex = 16;
            this.btnspiellöschen.Text = "Spiellöschen";
            this.btnspiellöschen.UseVisualStyleBackColor = false;
            this.btnspiellöschen.Click += new System.EventHandler(this.btnspiellöschen_Click);
            // 
            // lblspiellöschen
            // 
            this.lblspiellöschen.AutoSize = true;
            this.lblspiellöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblspiellöschen.ForeColor = System.Drawing.Color.White;
            this.lblspiellöschen.Location = new System.Drawing.Point(68, 22);
            this.lblspiellöschen.Name = "lblspiellöschen";
            this.lblspiellöschen.Size = new System.Drawing.Size(144, 26);
            this.lblspiellöschen.TabIndex = 15;
            this.lblspiellöschen.Text = "spielelöschen";
            // 
            // btnspielepfadlöschen
            // 
            this.btnspielepfadlöschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielepfadlöschen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielepfadlöschen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielepfadlöschen.ForeColor = System.Drawing.Color.Black;
            this.btnspielepfadlöschen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielepfadlöschen.Location = new System.Drawing.Point(3, 133);
            this.btnspielepfadlöschen.Name = "btnspielepfadlöschen";
            this.btnspielepfadlöschen.Size = new System.Drawing.Size(276, 57);
            this.btnspielepfadlöschen.TabIndex = 14;
            this.btnspielepfadlöschen.Text = "Spielepfad";
            this.btnspielepfadlöschen.UseVisualStyleBackColor = false;
            // 
            // tbxspielenamenlöschen
            // 
            this.tbxspielenamenlöschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxspielenamenlöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxspielenamenlöschen.Font = new System.Drawing.Font("Arial", 16.25F);
            this.tbxspielenamenlöschen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxspielenamenlöschen.Location = new System.Drawing.Point(-1, 74);
            this.tbxspielenamenlöschen.Multiline = true;
            this.tbxspielenamenlöschen.Name = "tbxspielenamenlöschen";
            this.tbxspielenamenlöschen.Size = new System.Drawing.Size(284, 53);
            this.tbxspielenamenlöschen.TabIndex = 13;
            this.tbxspielenamenlöschen.Text = "spielename";
            this.tbxspielenamenlöschen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxspiele
            // 
            this.lbxspiele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.lbxspiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbxspiele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lbxspiele.FormattingEnabled = true;
            this.lbxspiele.ItemHeight = 20;
            this.lbxspiele.Location = new System.Drawing.Point(44, 176);
            this.lbxspiele.Name = "lbxspiele";
            this.lbxspiele.Size = new System.Drawing.Size(343, 584);
            this.lbxspiele.TabIndex = 18;
            // 
            // pnlspielehinzufuegen
            // 
            this.pnlspielehinzufuegen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlspielehinzufuegen.Controls.Add(this.tbxspielealterhinzufuegen);
            this.pnlspielehinzufuegen.Controls.Add(this.btnspielhinzufuegne);
            this.pnlspielehinzufuegen.Controls.Add(this.lblspielehinzufuegen);
            this.pnlspielehinzufuegen.Controls.Add(this.btnspielepfad);
            this.pnlspielehinzufuegen.Controls.Add(this.tbxspielenamen);
            this.pnlspielehinzufuegen.Location = new System.Drawing.Point(781, 184);
            this.pnlspielehinzufuegen.Name = "pnlspielehinzufuegen";
            this.pnlspielehinzufuegen.Size = new System.Drawing.Size(284, 311);
            this.pnlspielehinzufuegen.TabIndex = 19;
            // 
            // tbxspielealterhinzufuegen
            // 
            this.tbxspielealterhinzufuegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxspielealterhinzufuegen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxspielealterhinzufuegen.Font = new System.Drawing.Font("Arial", 16.25F);
            this.tbxspielealterhinzufuegen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxspielealterhinzufuegen.Location = new System.Drawing.Point(-1, 195);
            this.tbxspielealterhinzufuegen.Multiline = true;
            this.tbxspielealterhinzufuegen.Name = "tbxspielealterhinzufuegen";
            this.tbxspielealterhinzufuegen.Size = new System.Drawing.Size(284, 53);
            this.tbxspielealterhinzufuegen.TabIndex = 18;
            this.tbxspielealterhinzufuegen.Text = "spielealter";
            this.tbxspielealterhinzufuegen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnspielhinzufuegne
            // 
            this.btnspielhinzufuegne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielhinzufuegne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielhinzufuegne.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielhinzufuegne.ForeColor = System.Drawing.Color.Black;
            this.btnspielhinzufuegne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielhinzufuegne.Location = new System.Drawing.Point(3, 254);
            this.btnspielhinzufuegne.Name = "btnspielhinzufuegne";
            this.btnspielhinzufuegne.Size = new System.Drawing.Size(276, 52);
            this.btnspielhinzufuegne.TabIndex = 16;
            this.btnspielhinzufuegne.Text = "Spielhinzufügen";
            this.btnspielhinzufuegne.UseVisualStyleBackColor = false;
            this.btnspielhinzufuegne.Click += new System.EventHandler(this.btnspielhinzufuegne_Click);
            // 
            // lblspielehinzufuegen
            // 
            this.lblspielehinzufuegen.AutoSize = true;
            this.lblspielehinzufuegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblspielehinzufuegen.ForeColor = System.Drawing.Color.White;
            this.lblspielehinzufuegen.Location = new System.Drawing.Point(55, 21);
            this.lblspielehinzufuegen.Name = "lblspielehinzufuegen";
            this.lblspielehinzufuegen.Size = new System.Drawing.Size(175, 26);
            this.lblspielehinzufuegen.TabIndex = 15;
            this.lblspielehinzufuegen.Text = "spielehinzufügen";
            // 
            // btnspielepfad
            // 
            this.btnspielepfad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielepfad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielepfad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielepfad.ForeColor = System.Drawing.Color.Black;
            this.btnspielepfad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielepfad.Location = new System.Drawing.Point(3, 132);
            this.btnspielepfad.Name = "btnspielepfad";
            this.btnspielepfad.Size = new System.Drawing.Size(276, 56);
            this.btnspielepfad.TabIndex = 14;
            this.btnspielepfad.Text = "Spielepfad";
            this.btnspielepfad.UseVisualStyleBackColor = false;
            this.btnspielepfad.Click += new System.EventHandler(this.btnspielepfad_Click);
            // 
            // tbxspielenamen
            // 
            this.tbxspielenamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxspielenamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxspielenamen.Font = new System.Drawing.Font("Arial", 16.25F);
            this.tbxspielenamen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxspielenamen.Location = new System.Drawing.Point(-1, 73);
            this.tbxspielenamen.Multiline = true;
            this.tbxspielenamen.Name = "tbxspielenamen";
            this.tbxspielenamen.Size = new System.Drawing.Size(284, 53);
            this.tbxspielenamen.TabIndex = 13;
            this.tbxspielenamen.Text = "spielename";
            this.tbxspielenamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxbeschreibung
            // 
            this.tbxbeschreibung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxbeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tbxbeschreibung.ForeColor = System.Drawing.Color.White;
            this.tbxbeschreibung.Location = new System.Drawing.Point(418, 502);
            this.tbxbeschreibung.Multiline = true;
            this.tbxbeschreibung.Name = "tbxbeschreibung";
            this.tbxbeschreibung.Size = new System.Drawing.Size(647, 258);
            this.tbxbeschreibung.TabIndex = 20;
            this.tbxbeschreibung.Text = "spielebeschreibung";
            // 
            // Adminspiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1115, 781);
            this.Controls.Add(this.tbxbeschreibung);
            this.Controls.Add(this.pnlspielehinzufuegen);
            this.Controls.Add(this.lbxspiele);
            this.Controls.Add(this.pnlspiellöschen);
            this.Controls.Add(this.pbxzurueck);
            this.Controls.Add(this.lblLauncher);
            this.Controls.Add(this.lblgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Adminspiele";
            this.Load += new System.EventHandler(this.Adminspiele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).EndInit();
            this.pnlspiellöschen.ResumeLayout(false);
            this.pnlspiellöschen.PerformLayout();
            this.pnlspielehinzufuegen.ResumeLayout(false);
            this.pnlspielehinzufuegen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLauncher;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.PictureBox pbxzurueck;
        private System.Windows.Forms.Panel pnlspiellöschen;
        private System.Windows.Forms.Button btnspiellöschen;
        private System.Windows.Forms.Label lblspiellöschen;
        private System.Windows.Forms.Button btnspielepfadlöschen;
        private System.Windows.Forms.TextBox tbxspielenamenlöschen;
        private System.Windows.Forms.ListBox lbxspiele;
        private System.Windows.Forms.Panel pnlspielehinzufuegen;
        private System.Windows.Forms.Button btnspielhinzufuegne;
        private System.Windows.Forms.Label lblspielehinzufuegen;
        private System.Windows.Forms.Button btnspielepfad;
        private System.Windows.Forms.TextBox tbxspielenamen;
        private System.Windows.Forms.TextBox tbxspielealter;
        private System.Windows.Forms.TextBox tbxspielealterhinzufuegen;
        private System.Windows.Forms.TextBox tbxbeschreibung;
    }
}