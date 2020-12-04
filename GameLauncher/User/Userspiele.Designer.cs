namespace GameLauncher.User
{
    partial class Userspiele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userspiele));
            this.lblLauncher = new System.Windows.Forms.Label();
            this.lblgame = new System.Windows.Forms.Label();
            this.pbxzurueck = new System.Windows.Forms.PictureBox();
            this.lbxspiele = new System.Windows.Forms.ListBox();
            this.tbxspielenamen = new System.Windows.Forms.TextBox();
            this.btnspielepfad = new System.Windows.Forms.Button();
            this.pnlspielehinzufuegen = new System.Windows.Forms.Panel();
            this.btnspielhinzufuegen = new System.Windows.Forms.Button();
            this.lblspielehinzufügen = new System.Windows.Forms.Label();
            this.pnlspiellöschen = new System.Windows.Forms.Panel();
            this.btnspiellöschen = new System.Windows.Forms.Button();
            this.lblspiellöschen = new System.Windows.Forms.Label();
            this.btnspielepfadlöschen = new System.Windows.Forms.Button();
            this.tbxspielenamenlöschen = new System.Windows.Forms.TextBox();
            this.btnspielstarten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).BeginInit();
            this.pnlspielehinzufuegen.SuspendLayout();
            this.pnlspiellöschen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLauncher
            // 
            this.lblLauncher.Font = new System.Drawing.Font("Paper Flowers", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lblLauncher.Location = new System.Drawing.Point(315, 45);
            this.lblLauncher.Name = "lblLauncher";
            this.lblLauncher.Size = new System.Drawing.Size(404, 136);
            this.lblLauncher.TabIndex = 9;
            this.lblLauncher.Text = "Launcher";
            // 
            // lblgame
            // 
            this.lblgame.Font = new System.Drawing.Font("Paper Flowers", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.lblgame.Location = new System.Drawing.Point(120, 45);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(244, 136);
            this.lblgame.TabIndex = 8;
            this.lblgame.Text = "Game";
            // 
            // pbxzurueck
            // 
            this.pbxzurueck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxzurueck.Image = ((System.Drawing.Image)(resources.GetObject("pbxzurueck.Image")));
            this.pbxzurueck.Location = new System.Drawing.Point(21, 28);
            this.pbxzurueck.Name = "pbxzurueck";
            this.pbxzurueck.Size = new System.Drawing.Size(63, 76);
            this.pbxzurueck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxzurueck.TabIndex = 1;
            this.pbxzurueck.TabStop = false;
            this.pbxzurueck.Click += new System.EventHandler(this.pbxzurueck_Click);
            // 
            // lbxspiele
            // 
            this.lbxspiele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.lbxspiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbxspiele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lbxspiele.FormattingEnabled = true;
            this.lbxspiele.ItemHeight = 20;
            this.lbxspiele.Location = new System.Drawing.Point(21, 181);
            this.lbxspiele.Name = "lbxspiele";
            this.lbxspiele.Size = new System.Drawing.Size(289, 464);
            this.lbxspiele.TabIndex = 12;
            this.lbxspiele.SelectedIndexChanged += new System.EventHandler(this.lbxspiele_SelectedIndexChanged);
            // 
            // tbxspielenamen
            // 
            this.tbxspielenamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.tbxspielenamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxspielenamen.Font = new System.Drawing.Font("Arial", 16.25F);
            this.tbxspielenamen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxspielenamen.Location = new System.Drawing.Point(-1, 42);
            this.tbxspielenamen.Multiline = true;
            this.tbxspielenamen.Name = "tbxspielenamen";
            this.tbxspielenamen.Size = new System.Drawing.Size(280, 53);
            this.tbxspielenamen.TabIndex = 13;
            this.tbxspielenamen.Text = "spielename";
            this.tbxspielenamen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnspielepfad
            // 
            this.btnspielepfad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielepfad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielepfad.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielepfad.ForeColor = System.Drawing.Color.Black;
            this.btnspielepfad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielepfad.Location = new System.Drawing.Point(3, 101);
            this.btnspielepfad.Name = "btnspielepfad";
            this.btnspielepfad.Size = new System.Drawing.Size(276, 52);
            this.btnspielepfad.TabIndex = 14;
            this.btnspielepfad.Text = "Spielepfad";
            this.btnspielepfad.UseVisualStyleBackColor = false;
            // 
            // pnlspielehinzufuegen
            // 
            this.pnlspielehinzufuegen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlspielehinzufuegen.Controls.Add(this.btnspielhinzufuegen);
            this.pnlspielehinzufuegen.Controls.Add(this.lblspielehinzufügen);
            this.pnlspielehinzufuegen.Controls.Add(this.btnspielepfad);
            this.pnlspielehinzufuegen.Controls.Add(this.tbxspielenamen);
            this.pnlspielehinzufuegen.Location = new System.Drawing.Point(683, 180);
            this.pnlspielehinzufuegen.Name = "pnlspielehinzufuegen";
            this.pnlspielehinzufuegen.Size = new System.Drawing.Size(284, 225);
            this.pnlspielehinzufuegen.TabIndex = 15;
            // 
            // btnspielhinzufuegen
            // 
            this.btnspielhinzufuegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielhinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielhinzufuegen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielhinzufuegen.ForeColor = System.Drawing.Color.Black;
            this.btnspielhinzufuegen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielhinzufuegen.Location = new System.Drawing.Point(3, 159);
            this.btnspielhinzufuegen.Name = "btnspielhinzufuegen";
            this.btnspielhinzufuegen.Size = new System.Drawing.Size(276, 52);
            this.btnspielhinzufuegen.TabIndex = 16;
            this.btnspielhinzufuegen.Text = "Spielhinzufügen";
            this.btnspielhinzufuegen.UseVisualStyleBackColor = false;
            // 
            // lblspielehinzufügen
            // 
            this.lblspielehinzufügen.AutoSize = true;
            this.lblspielehinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblspielehinzufügen.ForeColor = System.Drawing.Color.White;
            this.lblspielehinzufügen.Location = new System.Drawing.Point(3, 0);
            this.lblspielehinzufügen.Name = "lblspielehinzufügen";
            this.lblspielehinzufügen.Size = new System.Drawing.Size(175, 26);
            this.lblspielehinzufügen.TabIndex = 15;
            this.lblspielehinzufügen.Text = "spielehinzufügen";
            // 
            // pnlspiellöschen
            // 
            this.pnlspiellöschen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlspiellöschen.Controls.Add(this.btnspiellöschen);
            this.pnlspiellöschen.Controls.Add(this.lblspiellöschen);
            this.pnlspiellöschen.Controls.Add(this.btnspielepfadlöschen);
            this.pnlspiellöschen.Controls.Add(this.tbxspielenamenlöschen);
            this.pnlspiellöschen.Location = new System.Drawing.Point(350, 180);
            this.pnlspiellöschen.Name = "pnlspiellöschen";
            this.pnlspiellöschen.Size = new System.Drawing.Size(284, 225);
            this.pnlspiellöschen.TabIndex = 16;
            // 
            // btnspiellöschen
            // 
            this.btnspiellöschen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspiellöschen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspiellöschen.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspiellöschen.ForeColor = System.Drawing.Color.Black;
            this.btnspiellöschen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspiellöschen.Location = new System.Drawing.Point(3, 159);
            this.btnspiellöschen.Name = "btnspiellöschen";
            this.btnspiellöschen.Size = new System.Drawing.Size(276, 52);
            this.btnspiellöschen.TabIndex = 16;
            this.btnspiellöschen.Text = "Spielhinzufügen";
            this.btnspiellöschen.UseVisualStyleBackColor = false;
            // 
            // lblspiellöschen
            // 
            this.lblspiellöschen.AutoSize = true;
            this.lblspiellöschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblspiellöschen.ForeColor = System.Drawing.Color.White;
            this.lblspiellöschen.Location = new System.Drawing.Point(3, 0);
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
            this.btnspielepfadlöschen.Location = new System.Drawing.Point(3, 101);
            this.btnspielepfadlöschen.Name = "btnspielepfadlöschen";
            this.btnspielepfadlöschen.Size = new System.Drawing.Size(276, 52);
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
            this.tbxspielenamenlöschen.Location = new System.Drawing.Point(-1, 42);
            this.tbxspielenamenlöschen.Multiline = true;
            this.tbxspielenamenlöschen.Name = "tbxspielenamenlöschen";
            this.tbxspielenamenlöschen.Size = new System.Drawing.Size(280, 53);
            this.tbxspielenamenlöschen.TabIndex = 13;
            this.tbxspielenamenlöschen.Text = "spielename";
            this.tbxspielenamenlöschen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnspielstarten
            // 
            this.btnspielstarten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(50)))), ((int)(((byte)(37)))));
            this.btnspielstarten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnspielstarten.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnspielstarten.ForeColor = System.Drawing.Color.Black;
            this.btnspielstarten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnspielstarten.Location = new System.Drawing.Point(701, 608);
            this.btnspielstarten.Name = "btnspielstarten";
            this.btnspielstarten.Size = new System.Drawing.Size(276, 52);
            this.btnspielstarten.TabIndex = 17;
            this.btnspielstarten.Text = "Spielestarten";
            this.btnspielstarten.UseVisualStyleBackColor = false;
            this.btnspielstarten.Click += new System.EventHandler(this.btnspielstarten_Click);
            // 
            // Userspiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(989, 672);
            this.Controls.Add(this.btnspielstarten);
            this.Controls.Add(this.pnlspiellöschen);
            this.Controls.Add(this.pnlspielehinzufuegen);
            this.Controls.Add(this.pbxzurueck);
            this.Controls.Add(this.lbxspiele);
            this.Controls.Add(this.lblLauncher);
            this.Controls.Add(this.lblgame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Userspiele";
            this.Load += new System.EventHandler(this.Userspiele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxzurueck)).EndInit();
            this.pnlspielehinzufuegen.ResumeLayout(false);
            this.pnlspielehinzufuegen.PerformLayout();
            this.pnlspiellöschen.ResumeLayout(false);
            this.pnlspiellöschen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLauncher;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.PictureBox pbxzurueck;
        private System.Windows.Forms.ListBox lbxspiele;
        private System.Windows.Forms.TextBox tbxspielenamen;
        private System.Windows.Forms.Button btnspielepfad;
        private System.Windows.Forms.Panel pnlspielehinzufuegen;
        private System.Windows.Forms.Label lblspielehinzufügen;
        private System.Windows.Forms.Button btnspielhinzufuegen;
        private System.Windows.Forms.Panel pnlspiellöschen;
        private System.Windows.Forms.Button btnspiellöschen;
        private System.Windows.Forms.Label lblspiellöschen;
        private System.Windows.Forms.Button btnspielepfadlöschen;
        private System.Windows.Forms.TextBox tbxspielenamenlöschen;
        private System.Windows.Forms.Button btnspielstarten;
    }
}